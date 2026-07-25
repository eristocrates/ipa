namespace http.www.sealitproject.eu.ontology.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module sealit =
    let _namespace_iri = Namespace_Iri sealit |> NamespaceIRI
    /// <summary>
    ///   <para>sealit:Duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class expresses the length of time in terms of indeterminacy of the duration value that can be approximated. A duration may be expressed using all the parts of a date-time (from years to seconds) and can therefore be defined as a six-dimensional space. Because the relation between some of date parts is not fixed (such as the number of days in a month), the order relationship between durations is only partial, and the result of a comparison between two durations may be undetermined. The same value may consists of different parts, such as 4 years, 10 months and 2 days.</para>
    /// labels<para>Duration</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Duration">http://www.sealitproject.eu/ontology/Duration</seealso>
    let Duration = Prefixed_Name(sealit, "Duration") |> PrefixedName
    /// <summary>
    ///   <para>sealit:Employment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises information about employment services between two parties, usually based on a contract where work is paid for. In the context of the SeaLiT project, it comprises information about the employment services provided on board. This relationship is initiated by the recruitment of the sailor man and is terminated by the discharge/disembarkation of this worker.</para>
    /// labels<para>Employment</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Employment">http://www.sealitproject.eu/ontology/Employment</seealso>
    let Employment = Prefixed_Name(sealit, "Employment") |> PrefixedName
    /// <summary>
    ///   <para>sealit:ID_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>ID of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/ID_of">http://www.sealitproject.eu/ontology/ID_of</seealso>
    let ID_of = Prefixed_Name(sealit, "ID_of") |> PrefixedName
    /// <summary>
    ///   <para>sealit:Leaving</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises the leaving of a ship, which is a part, a stage of the overall voyage. It includes information about a place from which the ship leaves within a specific timeframe. It describes start points of the partial routes or with the overall voyage.</para>
    /// labels<para>Leaving</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Leaving">http://www.sealitproject.eu/ontology/Leaving</seealso>
    let Leaving = Prefixed_Name(sealit, "Leaving") |> PrefixedName
    /// <summary>
    ///   <para>sealit:for_employment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property associates an instance of a payment with an instance of an employment that was used in order to specify rights and responsibilities between the “employee” and the “employer”.</para>
    /// labels<para>for employment</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/for_employment">http://www.sealitproject.eu/ontology/for_employment</seealso>
    let for_employment = Prefixed_Name(sealit, "for_employment") |> PrefixedName

    /// <summary>
    ///   <para>sealit:employment_position_type_was_promoted_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>employment position type was promoted by</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/employment_position_type_was_promoted_by">http://www.sealitproject.eu/ontology/employment_position_type_was_promoted_by</seealso>
    let employment_position_type_was_promoted_by =
        Prefixed_Name(sealit, "employment_position_type_was_promoted_by") |> PrefixedName

    /// <summary>
    ///   <para>sealit:</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:Ontology</para>
    ///   <para>The SeaLiT Ontology is a formal ontology intended to facilitate the integration, mediation and interchange of heterogeneous information related to maritime history. It aims at providing the semantic definitions needed to transform disparate, localised information sources of maritime history into a coherent global resource. It also serves as a common language for domain experts and IT developers to formulate requirements and to agree on system functionalities with respect to the correct handling of historical information. The ontology uses and extends the CIDOC Conceptual Reference Model (ISO 21127:2014), in particular version 7.1.1, as a general ontology of human activity, things and events happening in space and time.</para>
    /// labels<para>SeaLiT Ontology</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/">http://www.sealitproject.eu/ontology/</seealso>
    let _prefix_iri = Prefixed_Name(sealit, "") |> PrefixedName
    /// <summary>
    ///   <para>sealit:Ammunition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises information about the kinds and the number of guns of the ship at the moment of registration. The current documentation is mostly about merchant ships. With the beginning of the Greek Revolution in 1821, the Greek merchant fleet was transformed to military – consequently, there are also references to vessels that have ammunition during that period.</para>
    /// labels<para>Ammunition</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Ammunition">http://www.sealitproject.eu/ontology/Ammunition</seealso>
    let Ammunition = Prefixed_Name(sealit, "Ammunition") |> PrefixedName
    /// <summary>
    ///   <para>sealit:has_tonnage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property provides the tonnage dimension of a ship.</para>
    /// labels<para>has tonnage</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/has_tonnage">http://www.sealitproject.eu/ontology/has_tonnage</seealso>
    let has_tonnage = Prefixed_Name(sealit, "has_tonnage") |> PrefixedName
    /// <summary>
    ///   <para>sealit:Arrival</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises the arrival activity of a ship, which is a part, a stage of the overall voyage. It includes information about a place where the ship lands within a specific timeframe. It describes end points of the partial routes or within the overall voyage.</para>
    /// labels<para>Arrival</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Arrival">http://www.sealitproject.eu/ontology/Arrival</seealso>
    let Arrival = Prefixed_Name(sealit, "Arrival") |> PrefixedName
    /// <summary>
    ///   <para>sealit:Country</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class describes the country, a place identified as a distinct entity in political geography.</para>
    /// labels<para>Country</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Country">http://www.sealitproject.eu/ontology/Country</seealso>
    let Country = Prefixed_Name(sealit, "Country") |> PrefixedName
    /// <summary>
    ///   <para>sealit:Profession</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises information about the person profession, work, career or job, as it was written inside the original source.</para>
    /// labels<para>Profession</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Profession">http://www.sealitproject.eu/ontology/Profession</seealso>
    let Profession = Prefixed_Name(sealit, "Profession") |> PrefixedName
    /// <summary>
    ///   <para>sealit:Ship_Construction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class describes the activity of building new ships and other floating vessels. The ship construction information, in particular the location and date of construction, is the most reliable information (extracted from the source) that helps to identify a ship. A very important methodological question is what information can be used to define the unique identity of a ship. The answer is that there does not exist a single information that can define it: it is always a matter of comparison of the sources and information. Even though, there is information that is critical to the identity of a ship, such as the place and the year of construction.</para>
    /// labels<para>Ship Construction</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Ship_Construction">http://www.sealitproject.eu/ontology/Ship_Construction</seealso>
    let Ship_Construction = Prefixed_Name(sealit, "Ship_Construction") |> PrefixedName
    /// <summary>
    ///   <para>sealit:Ship_Name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises the name that identifies a ship. The name of the ship can be changed because of an ownership (so a ship can have many names through time).</para>
    /// labels<para>Ship Name</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Ship_Name">http://www.sealitproject.eu/ontology/Ship_Name</seealso>
    let Ship_Name = Prefixed_Name(sealit, "Ship_Name") |> PrefixedName
    /// <summary>
    ///   <para>sealit:ship_ID_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>ship ID of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/ship_ID_of">http://www.sealitproject.eu/ontology/ship_ID_of</seealso>
    let ship_ID_of = Prefixed_Name(sealit, "ship_ID_of") |> PrefixedName
    /// <summary>
    ///   <para>sealit:started</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes an employment that was started by a recruitment activity.</para>
    /// labels<para>started</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/started">http://www.sealitproject.eu/ontology/started</seealso>
    let started = Prefixed_Name(sealit, "started") |> PrefixedName
    /// <summary>
    ///   <para>sealit:was_mediated_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the E39 Actor that participated in the transaction (Money for Service activity) in the role of a mediator. For example, there are sources that refer that seamen used to provide money to the captain of the ship in order that the wives to receive these money (so the captain was the mediator of this transaction).</para>
    /// labels<para>was mediated by</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/was_mediated_by">http://www.sealitproject.eu/ontology/was_mediated_by</seealso>
    let was_mediated_by = Prefixed_Name(sealit, "was_mediated_by") |> PrefixedName
    /// <summary>
    ///   <para>sealit:Civil_Registration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Civil registration stands for legal processes of registering persons in various contexts. The outcomes of this process are legal documents such as civil acts of birth or death, or other documents (such as Register of Entries in shipyards), which usually have a period of validity.</para>
    /// labels<para>Civil Registration</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Civil_Registration">http://www.sealitproject.eu/ontology/Civil_Registration</seealso>
    let Civil_Registration = Prefixed_Name(sealit, "Civil_Registration") |> PrefixedName
    /// <summary>
    ///   <para>sealit:Teaching_Unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises information about the school year, the period of time during which the school holds classes and offers courses. It is a period of educational activities.</para>
    /// labels<para>Teaching Unit</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Teaching_Unit">http://www.sealitproject.eu/ontology/Teaching_Unit</seealso>
    let Teaching_Unit = Prefixed_Name(sealit, "Teaching_Unit") |> PrefixedName
    /// <summary>
    ///   <para>sealit:Ship_ID</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises numeric information assigned as registration number of a ship.</para>
    /// labels<para>Ship ID</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Ship_ID">http://www.sealitproject.eu/ontology/Ship_ID</seealso>
    let Ship_ID = Prefixed_Name(sealit, "Ship_ID") |> PrefixedName
    /// <summary>
    ///   <para>sealit:with_ship_ID</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property records the ship identifier assigned by a Ship Registration activity.</para>
    /// labels<para>with ship ID</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/with_ship_ID">http://www.sealitproject.eu/ontology/with_ship_ID</seealso>
    let with_ship_ID = Prefixed_Name(sealit, "with_ship_ID") |> PrefixedName
    /// <summary>
    ///   <para>sealit:Course</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises information about courses, teaching units divided and organized for educational purposes.</para>
    /// labels<para>Course</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Course">http://www.sealitproject.eu/ontology/Course</seealso>
    let Course = Prefixed_Name(sealit, "Course") |> PrefixedName
    /// <summary>
    ///   <para>sealit:Crew_Payment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises information about the wage payments of the people that are members of the crew of a ship.</para>
    /// labels<para>Crew Payment</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Crew_Payment">http://www.sealitproject.eu/ontology/Crew_Payment</seealso>
    let Crew_Payment = Prefixed_Name(sealit, "Crew_Payment") |> PrefixedName
    /// <summary>
    ///   <para>sealit:Money_for_Labour</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises activities in which actors pay/receive money for services related to labour, human work, in order to earn wage.</para>
    /// labels<para>Money for Labour</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Money_for_Labour">http://www.sealitproject.eu/ontology/Money_for_Labour</seealso>
    let Money_for_Labour = Prefixed_Name(sealit, "Money_for_Labour") |> PrefixedName
    /// <summary>
    ///   <para>sealit:Discharge</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises the termination of a working relationship, the ending of an employee to provide service. In the context of the SeaLiT project, which explores data regarding employments records with lists of maritime personnel, a discharge is specifically defined in the sense of disembarkation, which is the activity that usually terminates a sailor’s employment service.</para>
    /// labels<para>Discharge</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Discharge">http://www.sealitproject.eu/ontology/Discharge</seealso>
    let Discharge = Prefixed_Name(sealit, "Discharge") |> PrefixedName
    /// <summary>
    ///   <para>sealit:Social_Status</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises a person’s social status, as it was written inside the original source. This can include different kinds of social status, such as marital status or estate. In such cases of further classification, these concepts can be used as instances of the Social Status class. This class extends E55 Type in order to refine the meaning of this specific concept (social status). This concept is sufficiently stable and associated with additional explicitly modelled property specific to it ( “has social status” ). An alternative mechanism is to specialize the classification of Social Status instances to any level of detail, by linking to external vocabulary sources, thesauri, classification schemas or ontologies. In general, a good practice for concepts that are not user defined metaclasses, would be to be treated as particulars with the relationship P2 has type.</para>
    /// labels<para>Social Status</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Social_Status">http://www.sealitproject.eu/ontology/Social_Status</seealso>
    let Social_Status = Prefixed_Name(sealit, "Social_Status") |> PrefixedName
    /// <summary>
    ///   <para>sealit:Tonnage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Tonnage is a measure of the cargo-carrying capacity of a ship. The sources refer to different kinds of tonnage, such as gross tonnage, net tonnage, etc. and through time, tonnage types may change. Tonnage may change during a reconstruction phase of a ship, for example.</para>
    /// labels<para>Tonnage</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Tonnage">http://www.sealitproject.eu/ontology/Tonnage</seealso>
    let Tonnage = Prefixed_Name(sealit, "Tonnage") |> PrefixedName
    /// <summary>
    ///   <para>sealit:Unloading</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises unloading activities as they are documented during the voyages (or as parts of the routes) of the ships. The procedures of loading/unloading are very important; the types of ships, the ports and the routes seem to define the types of loading, the dimensions, and the technology of loading/unloading and storage in ships.</para>
    /// labels<para>Unloading</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Unloading">http://www.sealitproject.eu/ontology/Unloading</seealso>
    let Unloading = Prefixed_Name(sealit, "Unloading") |> PrefixedName
    /// <summary>
    ///   <para>sealit:Voyage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises information about the voyages of ships. Voyage is defined as the process of travelling from one place to another, staying there, usually for a short time; it is not a simple move/change from place to place; it is a movement in space and time (and it is documented as that [1] ). The same ship can sail many voyages during its lifetime. Voyage and route information is very important for historically investigating the various trade routes and navigation patterns used to exist in different times. Voyage is an important aspect of the ship and the seaman, and generally of the seafaring life, both at sea and ashore .</para>
    /// labels<para>Voyage</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Voyage">http://www.sealitproject.eu/ontology/Voyage</seealso>
    let Voyage = Prefixed_Name(sealit, "Voyage") |> PrefixedName
    /// <summary>
    ///   <para>sealit:at_place</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the spatial location of an arrival.</para>
    /// labels<para>at place</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/at_place">http://www.sealitproject.eu/ontology/at_place</seealso>
    let at_place = Prefixed_Name(sealit, "at_place") |> PrefixedName

    /// <summary>
    ///   <para>sealit:is_place_of_arrival</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is place of arrival</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/is_place_of_arrival">http://www.sealitproject.eu/ontology/is_place_of_arrival</seealso>
    let is_place_of_arrival =
        Prefixed_Name(sealit, "is_place_of_arrival") |> PrefixedName

    /// <summary>
    ///   <para>sealit:is_place_of_passing_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is place of passing by</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/is_place_of_passing_by">http://www.sealitproject.eu/ontology/is_place_of_passing_by</seealso>
    let is_place_of_passing_by =
        Prefixed_Name(sealit, "is_place_of_passing_by") |> PrefixedName

    /// <summary>
    ///   <para>sealit:concerned</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the person that was promoted by a promotion activity.</para>
    /// labels<para>concerned</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/concerned">http://www.sealitproject.eu/ontology/concerned</seealso>
    let concerned = Prefixed_Name(sealit, "concerned") |> PrefixedName
    /// <summary>
    ///   <para>sealit:was_promoted_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>was promoted by</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/was_promoted_by">http://www.sealitproject.eu/ontology/was_promoted_by</seealso>
    let was_promoted_by = Prefixed_Name(sealit, "was_promoted_by") |> PrefixedName

    /// <summary>
    ///   <para>sealit:consists_of_leaving</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property allows an instance of a Voyage to be analysed into parts such as leaving activities. It is a subproperty of P9 consists of (forms part of). This analysis of parts of the voyage contributes to the route analysis, which provides information about specific navigation patterns of the ship.</para>
    /// labels<para>consists of leaving</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/consists_of_leaving">http://www.sealitproject.eu/ontology/consists_of_leaving</seealso>
    let consists_of_leaving =
        Prefixed_Name(sealit, "consists_of_leaving") |> PrefixedName

    /// <summary>
    ///   <para>sealit:leaving_is_part_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>leaving is part of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/leaving_is_part_of">http://www.sealitproject.eu/ontology/leaving_is_part_of</seealso>
    let leaving_is_part_of = Prefixed_Name(sealit, "leaving_is_part_of") |> PrefixedName
    /// <summary>
    ///   <para>sealit:loading_is_part_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>loading is part of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/loading_is_part_of">http://www.sealitproject.eu/ontology/loading_is_part_of</seealso>
    let loading_is_part_of = Prefixed_Name(sealit, "loading_is_part_of") |> PrefixedName

    /// <summary>
    ///   <para>sealit:consists_of_passing</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property allows an instance of a Voyage to be analysed into parts such as passing by/through activities. It is a subproperty of P9 consists of (forms part of). This analysis of parts of the voyage contributes to the route analysis, which provides information about specific navigation patterns of the ship</para>
    /// labels<para>consists of passing</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/consists_of_passing">http://www.sealitproject.eu/ontology/consists_of_passing</seealso>
    let consists_of_passing =
        Prefixed_Name(sealit, "consists_of_passing") |> PrefixedName

    /// <summary>
    ///   <para>sealit:passing_is_part_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>passing is part of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/passing_is_part_of">http://www.sealitproject.eu/ontology/passing_is_part_of</seealso>
    let passing_is_part_of = Prefixed_Name(sealit, "passing_is_part_of") |> PrefixedName

    /// <summary>
    ///   <para>sealit:consists_of_unloading</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property allows an instance of a Voyage to be analysed into parts such as unloading activities. It is a subproperty of P9 consists of (forms part of). The activities of loading/unloading happen ashore, before, in between, or after (with the end) of the voyage of a ship and are part of its definition.</para>
    /// labels<para>consists of unloading</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/consists_of_unloading">http://www.sealitproject.eu/ontology/consists_of_unloading</seealso>
    let consists_of_unloading =
        Prefixed_Name(sealit, "consists_of_unloading") |> PrefixedName

    /// <summary>
    ///   <para>sealit:constructed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies a ship that came into existence as a result of a construction event.</para>
    /// labels<para>constructed</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/constructed">http://www.sealitproject.eu/ontology/constructed</seealso>
    let constructed = Prefixed_Name(sealit, "constructed") |> PrefixedName
    /// <summary>
    ///   <para>sealit:de-flagged_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>de-flagged in</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/de-flagged_in">http://www.sealitproject.eu/ontology/de-flagged_in</seealso>
    let de_flagged_in = Prefixed_Name(sealit, "de-flagged_in") |> PrefixedName
    /// <summary>
    ///   <para>sealit:de-flagging_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property associates an instance of a ship with the instance of the de-flagging activity that de-registered it.</para>
    /// labels<para>de-flagging of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/de-flagging_of">http://www.sealitproject.eu/ontology/de-flagging_of</seealso>
    let de_flagging_of = Prefixed_Name(sealit, "de-flagging_of") |> PrefixedName
    /// <summary>
    ///   <para>sealit:is_destination_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is destination of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/is_destination_of">http://www.sealitproject.eu/ontology/is_destination_of</seealso>
    let is_destination_of = Prefixed_Name(sealit, "is_destination_of") |> PrefixedName
    /// <summary>
    ///   <para>sealit:duration_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>duration of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/duration_of">http://www.sealitproject.eu/ontology/duration_of</seealso>
    let duration_of = Prefixed_Name(sealit, "duration_of") |> PrefixedName
    /// <summary>
    ///   <para>sealit:had_duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the length of time covered by an E52 Time-Span. It allows an E52 Time-Span to be associated with a duration (as a dimension, an interval) independent from the actual beginning and end.</para>
    /// labels<para>had duration</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/had_duration">http://www.sealitproject.eu/ontology/had_duration</seealso>
    let had_duration = Prefixed_Name(sealit, "had_duration") |> PrefixedName
    /// <summary>
    ///   <para>sealit:employment_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>employment of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/employment_of">http://www.sealitproject.eu/ontology/employment_of</seealso>
    let employment_of = Prefixed_Name(sealit, "employment_of") |> PrefixedName

    /// <summary>
    ///   <para>sealit:promoted_into_employment_position_type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property records the employment (job) position type that was promoted by a promotion activity. In that sense, we regard that a promotion can be related to a social status promotion or to a job/career promotion.</para>
    /// labels<para>promoted into employment position type</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/promoted_into_employment_position_type">http://www.sealitproject.eu/ontology/promoted_into_employment_position_type</seealso>
    let promoted_into_employment_position_type =
        Prefixed_Name(sealit, "promoted_into_employment_position_type") |> PrefixedName

    /// <summary>
    ///   <para>sealit:employment_provided_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the employment service provided by an E39 Actor.</para>
    /// labels<para>employment provided by</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/employment_provided_by">http://www.sealitproject.eu/ontology/employment_provided_by</seealso>
    let employment_provided_by =
        Prefixed_Name(sealit, "employment_provided_by") |> PrefixedName

    /// <summary>
    ///   <para>sealit:service_provided_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the intention of an E39 Actor to provide a service. The property of property in the role of allows specifying the nature of an Actor’s service provision.</para>
    /// labels<para>service provided by</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/service_provided_by">http://www.sealitproject.eu/ontology/service_provided_by</seealso>
    let service_provided_by =
        Prefixed_Name(sealit, "service_provided_by") |> PrefixedName

    /// <summary>
    ///   <para>sealit:provided_employment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>provided employment</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/provided_employment">http://www.sealitproject.eu/ontology/provided_employment</seealso>
    let provided_employment =
        Prefixed_Name(sealit, "provided_employment") |> PrefixedName

    /// <summary>
    ///   <para>sealit:ended</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes an employment that was ended/terminated by a discharge activity.</para>
    /// labels<para>ended</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/ended">http://www.sealitproject.eu/ontology/ended</seealso>
    let ended = Prefixed_Name(sealit, "ended") |> PrefixedName

    /// <summary>
    ///   <para>sealit:finally_arriving_at</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the final place (end) of a voyage. It is the actual arrival place, meaning it does not refer to the original destination place but the place to which the ship finally arrived.</para>
    /// labels<para>finally arriving at</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/finally_arriving_at">http://www.sealitproject.eu/ontology/finally_arriving_at</seealso>
    let finally_arriving_at =
        Prefixed_Name(sealit, "finally_arriving_at") |> PrefixedName

    /// <summary>
    ///   <para>sealit:is_arrival_place_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is arrival place of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/is_arrival_place_of">http://www.sealitproject.eu/ontology/is_arrival_place_of</seealso>
    let is_arrival_place_of =
        Prefixed_Name(sealit, "is_arrival_place_of") |> PrefixedName

    /// <summary>
    ///   <para>sealit:for_service</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes a Money for Service activity that pays/receives money for Services.</para>
    /// labels<para>for service</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/for_service">http://www.sealitproject.eu/ontology/for_service</seealso>
    let for_service = Prefixed_Name(sealit, "for_service") |> PrefixedName

    /// <summary>
    ///   <para>sealit:is_employment_period_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is employment period of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/is_employment_period_of">http://www.sealitproject.eu/ontology/is_employment_period_of</seealso>
    let is_employment_period_of =
        Prefixed_Name(sealit, "is_employment_period_of") |> PrefixedName

    /// <summary>
    ///   <para>sealit:for_thing</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes a Money for Things activity that pays/receives money for physical things.</para>
    /// labels<para>for thing</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/for_thing">http://www.sealitproject.eu/ontology/for_thing</seealso>
    let for_thing = Prefixed_Name(sealit, "for_thing") |> PrefixedName
    /// <summary>
    ///   <para>sealit:for_voyage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the voyage that sets the preconditions (motivates, determines, fixes) a crew payment. There is a dependency relationship between them; a new voyage sets the preconditions for a new crew payment activity.</para>
    /// labels<para>for voyage</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/for_voyage">http://www.sealitproject.eu/ontology/for_voyage</seealso>
    let for_voyage = Prefixed_Name(sealit, "for_voyage") |> PrefixedName
    /// <summary>
    ///   <para>sealit:motivated_payment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>motivated payment</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/motivated_payment">http://www.sealitproject.eu/ontology/motivated_payment</seealso>
    let motivated_payment = Prefixed_Name(sealit, "motivated_payment") |> PrefixedName

    /// <summary>
    ///   <para>sealit:formerly_or_currently_possesses</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property associates an instance of a Legal Document with Temporal Validity with the instance of an Actor that formerly or currently possesses it, at the time of validity of the record or database containing the statement that uses this property. The property does not allow any indication of how long the legal document with temporal validity has been possessed by the specific Actor.</para>
    /// labels<para>formerly or currently possesses</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/formerly_or_currently_possesses">http://www.sealitproject.eu/ontology/formerly_or_currently_possesses</seealso>
    let formerly_or_currently_possesses =
        Prefixed_Name(sealit, "formerly_or_currently_possesses") |> PrefixedName

    /// <summary>
    ///   <para>sealit:from_place</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the spatial location from which leaving (of ship) was documented. The description of this type of movement provides information about the route analysis.</para>
    /// labels<para>from place</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/from_place">http://www.sealitproject.eu/ontology/from_place</seealso>
    let from_place = Prefixed_Name(sealit, "from_place") |> PrefixedName

    /// <summary>
    ///   <para>sealit:is_place_of_leaving</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is place of leaving</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/is_place_of_leaving">http://www.sealitproject.eu/ontology/is_place_of_leaving</seealso>
    let is_place_of_leaving =
        Prefixed_Name(sealit, "is_place_of_leaving") |> PrefixedName

    /// <summary>
    ///   <para>sealit:had_flag_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property associates an instance of a Ship with an instance of the country of which this ship becomes property and consequently acquires this country’s flag. The property is a shortcut of the full path Ship – is registered by: Ship Registration – with ship flag of: Country.</para>
    /// labels<para>had flag of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/had_flag_of">http://www.sealitproject.eu/ontology/had_flag_of</seealso>
    let had_flag_of = Prefixed_Name(sealit, "had_flag_of") |> PrefixedName
    /// <summary>
    ///   <para>sealit:had_money_value</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the Monetary Amount paid (i.e., the cost) for a specific Money for Service activity.</para>
    /// labels<para>had money value</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/had_money_value">http://www.sealitproject.eu/ontology/had_money_value</seealso>
    let had_money_value = Prefixed_Name(sealit, "had_money_value") |> PrefixedName
    /// <summary>
    ///   <para>sealit:was_price_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>was price of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/was_price_of">http://www.sealitproject.eu/ontology/was_price_of</seealso>
    let was_price_of = Prefixed_Name(sealit, "was_price_of") |> PrefixedName
    /// <summary>
    ///   <para>sealit:had_student</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property associates instances of E39 Actor with the instances of Teaching Unit in which they participated in the role of students. The property of the property status of participation allows specifying the nature of an Actor’s participation in a course/teaching unit. For example, it can be the student’s exam status or paying/scholarship status in a course.</para>
    /// labels<para>had student</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/had_student">http://www.sealitproject.eu/ontology/had_student</seealso>
    let had_student = Prefixed_Name(sealit, "had_student") |> PrefixedName
    /// <summary>
    ///   <para>sealit:is_ammunition_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is ammunition of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/is_ammunition_of">http://www.sealitproject.eu/ontology/is_ammunition_of</seealso>
    let is_ammunition_of = Prefixed_Name(sealit, "is_ammunition_of") |> PrefixedName
    /// <summary>
    ///   <para>sealit:has_been_agreed_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property associates an instance of a money for labour with an instance of a Labour Contract document that is agreed and planned for this payment.</para>
    /// labels<para>has been agreed in</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/has_been_agreed_in">http://www.sealitproject.eu/ontology/has_been_agreed_in</seealso>
    let has_been_agreed_in = Prefixed_Name(sealit, "has_been_agreed_in") |> PrefixedName
    /// <summary>
    ///   <para>sealit:is_agreement_for</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is agreement for</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/is_agreement_for">http://www.sealitproject.eu/ontology/is_agreement_for</seealso>
    let is_agreement_for = Prefixed_Name(sealit, "is_agreement_for") |> PrefixedName

    /// <summary>
    ///   <para>sealit:has_crew_number_capacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property specifies the numbers of workers/sailors authorized to work on board.</para>
    /// labels<para>has crew number capacity</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/has_crew_number_capacity">http://www.sealitproject.eu/ontology/has_crew_number_capacity</seealso>
    let has_crew_number_capacity =
        Prefixed_Name(sealit, "has_crew_number_capacity") |> PrefixedName

    /// <summary>
    ///   <para>sealit:has_first_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property associates an instance of E21 Person with an instance of E62 String used as the person’s first name. This property is an alternative (more convenient) implementation of P1 is identified by: E41 Appellation – P2 has type: “first name”; P190 has symbolic content: E62 String . The use of the P1 is identified by: E41 Appellation is required if there is the need to assign some additional properties to the first name, such as properties of use or attribution.</para>
    /// labels<para>has first name</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/has_first_name">http://www.sealitproject.eu/ontology/has_first_name</seealso>
    let has_first_name = Prefixed_Name(sealit, "has_first_name") |> PrefixedName
    /// <summary>
    ///   <para>sealit:has_horsepower</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property records the horsepower dimension of a ship.</para>
    /// labels<para>has horsepower</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/has_horsepower">http://www.sealitproject.eu/ontology/has_horsepower</seealso>
    let has_horsepower = Prefixed_Name(sealit, "has_horsepower") |> PrefixedName
    /// <summary>
    ///   <para>sealit:is_horsepower_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is horsepower of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/is_horsepower_of">http://www.sealitproject.eu/ontology/is_horsepower_of</seealso>
    let is_horsepower_of = Prefixed_Name(sealit, "is_horsepower_of") |> PrefixedName

    /// <summary>
    ///   <para>sealit:has_language_capacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes concepts that represent language capacity/knowledge that characterizes a E21 Person at a specific time period that is maybe unknown.</para>
    /// labels<para>has language capacity</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/has_language_capacity">http://www.sealitproject.eu/ontology/has_language_capacity</seealso>
    let has_language_capacity =
        Prefixed_Name(sealit, "has_language_capacity") |> PrefixedName

    /// <summary>
    ///   <para>sealit:is_language_capacity_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is language capacity of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/is_language_capacity_of">http://www.sealitproject.eu/ontology/is_language_capacity_of</seealso>
    let is_language_capacity_of =
        Prefixed_Name(sealit, "is_language_capacity_of") |> PrefixedName

    /// <summary>
    ///   <para>sealit:has_last_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property associates an instance of E21 Person with an instance of E62 String used as the person’s last name. This property is an alternative (more convenient) implementation of P1 is identified by: E41 Appellation – P2 has type: “last name”; P190 has symbolic content: E62 String . The use of the P1 is identified by: E41 Appellation is required if there is the need to assign some additional properties to the last name, such as type, properties of use or attribution. In some countries (e.g., Spain), each person has two last names. In such cases, the value assigned to E62 String can contain both last names, if a clear distinction is not required.</para>
    /// labels<para>has last name</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/has_last_name">http://www.sealitproject.eu/ontology/has_last_name</seealso>
    let has_last_name = Prefixed_Name(sealit, "has_last_name") |> PrefixedName

    /// <summary>
    ///   <para>sealit:has_literacy_status</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the literacy status of a person at a specific time period that is maybe unknown.</para>
    /// labels<para>has literacy status</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/has_literacy_status">http://www.sealitproject.eu/ontology/has_literacy_status</seealso>
    let has_literacy_status =
        Prefixed_Name(sealit, "has_literacy_status") |> PrefixedName

    /// <summary>
    ///   <para>sealit:is_literacy_status_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is literacy status of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/is_literacy_status_of">http://www.sealitproject.eu/ontology/is_literacy_status_of</seealso>
    let is_literacy_status_of =
        Prefixed_Name(sealit, "is_literacy_status_of") |> PrefixedName

    /// <summary>
    ///   <para>sealit:has_navigation_type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the navigation type of the ship. It allows a form of specialisation through the use of a terminological hierarchy, or thesaurus.</para>
    /// labels<para>has navigation type</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/has_navigation_type">http://www.sealitproject.eu/ontology/has_navigation_type</seealso>
    let has_navigation_type =
        Prefixed_Name(sealit, "has_navigation_type") |> PrefixedName

    /// <summary>
    ///   <para>sealit:is_navigation_type_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is navigation type of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/is_navigation_type_of">http://www.sealitproject.eu/ontology/is_navigation_type_of</seealso>
    let is_navigation_type_of =
        Prefixed_Name(sealit, "is_navigation_type_of") |> PrefixedName

    /// <summary>
    ///   <para>sealit:has_owner</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes information about the owner, the person or the company (shipping enterprise), of a ship. In the context of the SeaLiT project, we make the hypothesis that the owner as a concept, implies a legal entity, so in that sense, a person is the minimum legal entity-company (with members himself/herself) of a ship.</para>
    /// labels<para>has owner</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/has_owner">http://www.sealitproject.eu/ontology/has_owner</seealso>
    let has_owner = Prefixed_Name(sealit, "has_owner") |> PrefixedName
    /// <summary>
    ///   <para>sealit:is_owner_of_phase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is owner of phase</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/is_owner_of_phase">http://www.sealitproject.eu/ontology/is_owner_of_phase</seealso>
    let is_owner_of_phase = Prefixed_Name(sealit, "is_owner_of_phase") |> PrefixedName

    /// <summary>
    ///   <para>sealit:has_ownership_phase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has ownership phase</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/has_ownership_phase">http://www.sealitproject.eu/ontology/has_ownership_phase</seealso>
    let has_ownership_phase =
        Prefixed_Name(sealit, "has_ownership_phase") |> PrefixedName

    /// <summary>
    ///   <para>sealit:is_ownership_phase_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property associates a ship with the different ownership phases related to it.</para>
    /// labels<para>is ownership phase of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/is_ownership_phase_of">http://www.sealitproject.eu/ontology/is_ownership_phase_of</seealso>
    let is_ownership_phase_of =
        Prefixed_Name(sealit, "is_ownership_phase_of") |> PrefixedName

    /// <summary>
    ///   <para>sealit:has_profession</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property associates a person with the profession, job or career that has been practicing at a specific time period that is maybe unknown. The evolution in the career/profession of a person is an important historical question; it implies the person development and evolution (microhistory) and consequently the population evolution (macrohistory).</para>
    /// labels<para>has profession</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/has_profession">http://www.sealitproject.eu/ontology/has_profession</seealso>
    let has_profession = Prefixed_Name(sealit, "has_profession") |> PrefixedName
    /// <summary>
    ///   <para>sealit:profession_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>profession of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/profession_of">http://www.sealitproject.eu/ontology/profession_of</seealso>
    let profession_of = Prefixed_Name(sealit, "profession_of") |> PrefixedName

    /// <summary>
    ///   <para>sealit:has_religion_status</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the religion status of a person at a specific time period that is maybe unknown.</para>
    /// labels<para>has religion status</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/has_religion_status">http://www.sealitproject.eu/ontology/has_religion_status</seealso>
    let has_religion_status =
        Prefixed_Name(sealit, "has_religion_status") |> PrefixedName

    /// <summary>
    ///   <para>sealit:is_religion_status_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is religion status of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/is_religion_status_of">http://www.sealitproject.eu/ontology/is_religion_status_of</seealso>
    let is_religion_status_of =
        Prefixed_Name(sealit, "is_religion_status_of") |> PrefixedName

    /// <summary>
    ///   <para>sealit:has_sex_type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property associates a person with the sex type that this person has at a specific time period that is maybe unknown.</para>
    /// labels<para>has sex type</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/has_sex_type">http://www.sealitproject.eu/ontology/has_sex_type</seealso>
    let has_sex_type = Prefixed_Name(sealit, "has_sex_type") |> PrefixedName
    /// <summary>
    ///   <para>sealit:is_sex_type_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is sex type of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/is_sex_type_of">http://www.sealitproject.eu/ontology/is_sex_type_of</seealso>
    let is_sex_type_of = Prefixed_Name(sealit, "is_sex_type_of") |> PrefixedName
    /// <summary>
    ///   <para>sealit:has_shareholder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property associates an actor with the activity of participating in an ownership with shares. It implies that a phase of a shareholding represents one participation of a share by an actor. This means that if for a ship there are more than one shareholders, there will be consequently same number of shareholding phases. If we want to describe the sum of the shares of the shareholding for a ship in a specific timespan, then we will describe a composite shareholding activity that consists of individual shareholding activities of shares.</para>
    /// labels<para>has shareholder</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/has_shareholder">http://www.sealitproject.eu/ontology/has_shareholder</seealso>
    let has_shareholder = Prefixed_Name(sealit, "has_shareholder") |> PrefixedName
    /// <summary>
    ///   <para>sealit:has_shareholding</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has shareholding</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/has_shareholding">http://www.sealitproject.eu/ontology/has_shareholding</seealso>
    let has_shareholding = Prefixed_Name(sealit, "has_shareholding") |> PrefixedName

    /// <summary>
    ///   <para>sealit:is_shareholding_phase_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property associates a shareholding phase to a particular ship.</para>
    /// labels<para>is shareholding phase of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/is_shareholding_phase_of">http://www.sealitproject.eu/ontology/is_shareholding_phase_of</seealso>
    let is_shareholding_phase_of =
        Prefixed_Name(sealit, "is_shareholding_phase_of") |> PrefixedName

    /// <summary>
    ///   <para>sealit:has_ship_ID</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the identification of a ship by an identifier. This property does not reveal anything about when, where and by whom this identifier was used. A more detailed representation can be made using the fully developed path through Ship Registration. The property is a shortcut for the path Ship – is registered by: Ship Registration – with ship ID: Ship ID .</para>
    /// labels<para>has ship ID</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/has_ship_ID">http://www.sealitproject.eu/ontology/has_ship_ID</seealso>
    let has_ship_ID = Prefixed_Name(sealit, "has_ship_ID") |> PrefixedName
    /// <summary>
    ///   <para>sealit:ship_ID_identifies</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>ship ID identifies</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/ship_ID_identifies">http://www.sealitproject.eu/ontology/ship_ID_identifies</seealso>
    let ship_ID_identifies = Prefixed_Name(sealit, "ship_ID_identifies") |> PrefixedName
    /// <summary>
    ///   <para>sealit:has_social_status</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the social status of a person at a specific time period that is maybe unknown.</para>
    /// labels<para>has social status</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/has_social_status">http://www.sealitproject.eu/ontology/has_social_status</seealso>
    let has_social_status = Prefixed_Name(sealit, "has_social_status") |> PrefixedName

    /// <summary>
    ///   <para>sealit:is_social_status_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is social status of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/is_social_status_of">http://www.sealitproject.eu/ontology/is_social_status_of</seealso>
    let is_social_status_of =
        Prefixed_Name(sealit, "is_social_status_of") |> PrefixedName

    /// <summary>
    ///   <para>sealit:has_subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the subject of a teaching unit.</para>
    /// labels<para>has subject</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/has_subject">http://www.sealitproject.eu/ontology/has_subject</seealso>
    let has_subject = Prefixed_Name(sealit, "has_subject") |> PrefixedName
    /// <summary>
    ///   <para>sealit:is_subject_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is subject of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/is_subject_of">http://www.sealitproject.eu/ontology/is_subject_of</seealso>
    let is_subject_of = Prefixed_Name(sealit, "is_subject_of") |> PrefixedName
    /// <summary>
    ///   <para>sealit:is_tonnage_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is tonnage of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/is_tonnage_of">http://www.sealitproject.eu/ontology/is_tonnage_of</seealso>
    let is_tonnage_of = Prefixed_Name(sealit, "is_tonnage_of") |> PrefixedName
    /// <summary>
    ///   <para>sealit:in_time</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the inferred time-span of a legal object relationship, which cannot be observed or documented. It is implicit knowledge.</para>
    /// labels<para>in time</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/in_time">http://www.sealitproject.eu/ontology/in_time</seealso>
    let in_time = Prefixed_Name(sealit, "in_time") |> PrefixedName
    /// <summary>
    ///   <para>sealit:is_time_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is time of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/is_time_of">http://www.sealitproject.eu/ontology/is_time_of</seealso>
    let is_time_of = Prefixed_Name(sealit, "is_time_of") |> PrefixedName
    /// <summary>
    ///   <para>sealit:initializes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>initializes</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/initializes">http://www.sealitproject.eu/ontology/initializes</seealso>
    let initializes = Prefixed_Name(sealit, "initializes") |> PrefixedName
    /// <summary>
    ///   <para>sealit:is_initialized_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property associates the beginning of an instance of Legal Object Relationship with an explicit event initiating it.</para>
    /// labels<para>is initialized by</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/is_initialized_by">http://www.sealitproject.eu/ontology/is_initialized_by</seealso>
    let is_initialized_by = Prefixed_Name(sealit, "is_initialized_by") |> PrefixedName

    /// <summary>
    ///   <para>sealit:initializes_ownership</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>initializes ownership</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/initializes_ownership">http://www.sealitproject.eu/ontology/initializes_ownership</seealso>
    let initializes_ownership =
        Prefixed_Name(sealit, "initializes_ownership") |> PrefixedName

    /// <summary>
    ///   <para>sealit:ownership_is_initialized_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property associates the beginning of an instance of Ship Ownership Phase with the Ship Registration that initiates it.</para>
    /// labels<para>ownership is initialized by</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/ownership_is_initialized_by">http://www.sealitproject.eu/ontology/ownership_is_initialized_by</seealso>
    let ownership_is_initialized_by =
        Prefixed_Name(sealit, "ownership_is_initialized_by") |> PrefixedName

    /// <summary>
    ///   <para>sealit:is_flag_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is flag of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/is_flag_of">http://www.sealitproject.eu/ontology/is_flag_of</seealso>
    let is_flag_of = Prefixed_Name(sealit, "is_flag_of") |> PrefixedName
    /// <summary>
    ///   <para>sealit:with_ship_flag_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the country represented in the ship flag of a Ship Registration activity.</para>
    /// labels<para>with ship flag of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/with_ship_flag_of">http://www.sealitproject.eu/ontology/with_ship_flag_of</seealso>
    let with_ship_flag_of = Prefixed_Name(sealit, "with_ship_flag_of") |> PrefixedName
    /// <summary>
    ///   <para>sealit:is_given_to</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property associates a punishment to the actor that received the punishment.</para>
    /// labels<para>is given to</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/is_given_to">http://www.sealitproject.eu/ontology/is_given_to</seealso>
    let is_given_to = Prefixed_Name(sealit, "is_given_to") |> PrefixedName
    /// <summary>
    ///   <para>sealit:was_punished_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>was punished by</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/was_punished_by">http://www.sealitproject.eu/ontology/was_punished_by</seealso>
    let was_punished_by = Prefixed_Name(sealit, "was_punished_by") |> PrefixedName
    /// <summary>
    ///   <para>sealit:De-flagging</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>De-flagging is regarded in this context as synonym to ship de-registration. When a ship is no longer flagged, this means that for a reason (e.g., demolished, shipwreck, lost, sold, etc.) the ship does not anymore sail under a legal state (of registration, having a flag).</para>
    /// labels<para>De-flagging</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/De-flagging">http://www.sealitproject.eu/ontology/De-flagging</seealso>
    let De_flagging = Prefixed_Name(sealit, "De-flagging") |> PrefixedName
    /// <summary>
    ///   <para>sealit:Ship_Registration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A ship acquires legal identity with the process of its registration, the register of its name, flag, id, dimensions and horsepower. The ownership information is documented in the registry book signed by the Port of Registry.</para>
    /// labels<para>Ship Registration</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Ship_Registration">http://www.sealitproject.eu/ontology/Ship_Registration</seealso>
    let Ship_Registration = Prefixed_Name(sealit, "Ship_Registration") |> PrefixedName
    /// <summary>
    ///   <para>sealit:Ship_Repair</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises activities that alter or change or restore/repair a ship.</para>
    /// labels<para>Ship Repair</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Ship_Repair">http://www.sealitproject.eu/ontology/Ship_Repair</seealso>
    let Ship_Repair = Prefixed_Name(sealit, "Ship_Repair") |> PrefixedName
    /// <summary>
    ///   <para>sealit:Subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises information about the scientific subjects of the courses that were taught at a specific semester.</para>
    /// labels<para>Subject</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Subject">http://www.sealitproject.eu/ontology/Subject</seealso>
    let Subject = Prefixed_Name(sealit, "Subject") |> PrefixedName
    /// <summary>
    ///   <para>sealit:started_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>started by</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/started_by">http://www.sealitproject.eu/ontology/started_by</seealso>
    let started_by = Prefixed_Name(sealit, "started_by") |> PrefixedName
    /// <summary>
    ///   <para>sealit:Horsepower</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The power of the ship’s marine propulsion engine. The overall operation of the ship is highly dependent on the performance of its main propulsion engine, measured in terms of its power rating. There are various types of horsepower such as Nominal horsepower (NHP), Shaft horsepower (SHP), Indicated horsepower (IHP).</para>
    /// labels<para>Horsepower</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Horsepower">http://www.sealitproject.eu/ontology/Horsepower</seealso>
    let Horsepower = Prefixed_Name(sealit, "Horsepower") |> PrefixedName
    /// <summary>
    ///   <para>sealit:Labour_Contract</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises plans expressed in a document that specifies the employment conditions.</para>
    /// labels<para>Labour Contract</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Labour_Contract">http://www.sealitproject.eu/ontology/Labour_Contract</seealso>
    let Labour_Contract = Prefixed_Name(sealit, "Labour_Contract") |> PrefixedName
    /// <summary>
    ///   <para>sealit:was_unloaded_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>was unloaded by</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/was_unloaded_by">http://www.sealitproject.eu/ontology/was_unloaded_by</seealso>
    let was_unloaded_by = Prefixed_Name(sealit, "was_unloaded_by") |> PrefixedName
    /// <summary>
    ///   <para>sealit:voyages</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>voyages</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/voyages">http://www.sealitproject.eu/ontology/voyages</seealso>
    let voyages = Prefixed_Name(sealit, "voyages") |> PrefixedName
    /// <summary>
    ///   <para>sealit:arrival_is_part_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>arrival is part of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/arrival_is_part_of">http://www.sealitproject.eu/ontology/arrival_is_part_of</seealso>
    let arrival_is_part_of = Prefixed_Name(sealit, "arrival_is_part_of") |> PrefixedName

    /// <summary>
    ///   <para>sealit:consists_of_arrival</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property allows an instance of a Voyage to be analysed into parts such as arrival activities. It is a subproperty of P9 consists of (forms part of). This analysis of parts of the voyage contributes to the route analysis, which provides information about specific navigation patterns of the ship.</para>
    /// labels<para>consists of arrival</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/consists_of_arrival">http://www.sealitproject.eu/ontology/consists_of_arrival</seealso>
    let consists_of_arrival =
        Prefixed_Name(sealit, "consists_of_arrival") |> PrefixedName

    /// <summary>
    ///   <para>sealit:by_place</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property associates an instance of a place with an instance of a passing activity by that place. This class provides information about the types of movements of a ship, which are parts of the route (of the voyage), and are documented as that.</para>
    /// labels<para>by place</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/by_place">http://www.sealitproject.eu/ontology/by_place</seealso>
    let by_place = Prefixed_Name(sealit, "by_place") |> PrefixedName
    /// <summary>
    ///   <para>sealit:unloaded</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property associates an instance of E18 Physical Thing with an instance of the unloading activity that moved (unloaded) it.</para>
    /// labels<para>unloaded</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/unloaded">http://www.sealitproject.eu/ontology/unloaded</seealso>
    let unloaded = Prefixed_Name(sealit, "unloaded") |> PrefixedName
    /// <summary>
    ///   <para>sealit:voyage_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the voyage of a ship, its movement/travelling at sea.</para>
    /// labels<para>voyage of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/voyage_of">http://www.sealitproject.eu/ontology/voyage_of</seealso>
    let voyage_of = Prefixed_Name(sealit, "voyage_of") |> PrefixedName

    /// <summary>
    ///   <para>sealit:consists_of_loading</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property allows an instance of a Voyage to be analysed into parts such as loading activities. It is a subproperty of P9 consists of (forms part of). The activities of loading/unloading happen ashore, before, in between, or after (with the end) of the voyage of a ship and are part of its definition.</para>
    /// labels<para>consists of loading</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/consists_of_loading">http://www.sealitproject.eu/ontology/consists_of_loading</seealso>
    let consists_of_loading =
        Prefixed_Name(sealit, "consists_of_loading") |> PrefixedName

    /// <summary>
    ///   <para>sealit:unloading_is_part_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>unloading is part of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/unloading_is_part_of">http://www.sealitproject.eu/ontology/unloading_is_part_of</seealso>
    let unloading_is_part_of =
        Prefixed_Name(sealit, "unloading_is_part_of") |> PrefixedName

    /// <summary>
    ///   <para>sealit:was_constructed_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>was constructed by</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/was_constructed_by">http://www.sealitproject.eu/ontology/was_constructed_by</seealso>
    let was_constructed_by = Prefixed_Name(sealit, "was_constructed_by") |> PrefixedName
    /// <summary>
    ///   <para>sealit:destination</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the intended place where the voyage, theoretically, according to the maps and the plans should end. It is the planned destination of the route, which may change in reality.</para>
    /// labels<para>destination</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/destination">http://www.sealitproject.eu/ontology/destination</seealso>
    let destination = Prefixed_Name(sealit, "destination") |> PrefixedName
    /// <summary>
    ///   <para>sealit:service_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>service of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/service_of">http://www.sealitproject.eu/ontology/service_of</seealso>
    let service_of = Prefixed_Name(sealit, "service_of") |> PrefixedName
    /// <summary>
    ///   <para>sealit:was_mediator_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>was mediator of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/was_mediator_of">http://www.sealitproject.eu/ontology/was_mediator_of</seealso>
    let was_mediator_of = Prefixed_Name(sealit, "was_mediator_of") |> PrefixedName

    /// <summary>
    ///   <para>sealit:with_number_of_students</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the number of the students participating in a teaching unit.</para>
    /// labels<para>with number of students</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/with_number_of_students">http://www.sealitproject.eu/ontology/with_number_of_students</seealso>
    let with_number_of_students =
        Prefixed_Name(sealit, "with_number_of_students") |> PrefixedName

    /// <summary>
    ///   <para>sealit:Legal_Document_with_Temporal_Validity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises official documents or legal agreements that are valid for a specific timespan. The concept of this class includes licenses, official permissions, authorizations, etc., having a temporal validity.</para>
    /// labels<para>Legal Document with Temporal Validity</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Legal_Document_with_Temporal_Validity">http://www.sealitproject.eu/ontology/Legal_Document_with_Temporal_Validity</seealso>
    let Legal_Document_with_Temporal_Validity =
        Prefixed_Name(sealit, "Legal_Document_with_Temporal_Validity") |> PrefixedName

    /// <summary>
    ///   <para>sealit:Literacy_Status</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises concepts denoting a person’s literacy status.</para>
    /// labels<para>Literacy Status</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Literacy_Status">http://www.sealitproject.eu/ontology/Literacy_Status</seealso>
    let Literacy_Status = Prefixed_Name(sealit, "Literacy_Status") |> PrefixedName

    /// <summary>
    ///   <para>sealit:for_employment_period</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the total timespan (full employment period) of the Money for Labour activity and it is a shortcut of the most detailed path: Money for Labour – for employment: Employment – P4 has timespan: E52 Time-Span (timespan of recruitment and discharge) . The time-span can be also specified through a Duration instance, using the property had duration (duration of).</para>
    /// labels<para>for employment period</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/for_employment_period">http://www.sealitproject.eu/ontology/for_employment_period</seealso>
    let for_employment_period =
        Prefixed_Name(sealit, "for_employment_period") |> PrefixedName

    /// <summary>
    ///   <para>sealit:thing_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>thing of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/thing_of">http://www.sealitproject.eu/ontology/thing_of</seealso>
    let thing_of = Prefixed_Name(sealit, "thing_of") |> PrefixedName

    /// <summary>
    ///   <para>sealit:Legal_Object_Relationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises legal object relationships of which the timespan and the state (of these relationships) cannot be observed or documented. We can only observe these relationships through the events that initialize or terminate this state of relationship (starting event and terminating event). Basically, it comprises of characteristics/properties of a legal relationship which is the kind of information that can be inferred/asserted and not by temporal documentation of these properties.</para>
    /// labels<para>Legal Object Relationship</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Legal_Object_Relationship">http://www.sealitproject.eu/ontology/Legal_Object_Relationship</seealso>
    let Legal_Object_Relationship =
        Prefixed_Name(sealit, "Legal_Object_Relationship") |> PrefixedName

    /// <summary>
    ///   <para>sealit:Loading</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises loading activities as they are documented during the voyages (or as parts of the routes) of the ships. It seems that the definition of a ship includes the notion of the loading of things; the procedures of loading/unloading are very important; the types of ships, the ports and the routes seem to define the types of loading, the dimensions, and the technology of loading/unloading and storage in ships.</para>
    /// labels<para>Loading</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Loading">http://www.sealitproject.eu/ontology/Loading</seealso>
    let Loading = Prefixed_Name(sealit, "Loading") |> PrefixedName

    /// <summary>
    ///   <para>sealit:is_formerly_or_currently_possessed_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is formerly or currently possessed by</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/is_formerly_or_currently_possessed_by">http://www.sealitproject.eu/ontology/is_formerly_or_currently_possessed_by</seealso>
    let is_formerly_or_currently_possessed_by =
        Prefixed_Name(sealit, "is_formerly_or_currently_possessed_by") |> PrefixedName

    /// <summary>
    ///   <para>sealit:was_flag_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>was flag of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/was_flag_of">http://www.sealitproject.eu/ontology/was_flag_of</seealso>
    let was_flag_of = Prefixed_Name(sealit, "was_flag_of") |> PrefixedName
    /// <summary>
    ///   <para>sealit:student_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>student in</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/student_in">http://www.sealitproject.eu/ontology/student_in</seealso>
    let student_in = Prefixed_Name(sealit, "student_in") |> PrefixedName
    /// <summary>
    ///   <para>sealit:has_ammunition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property associates a ship with the ammunition that it is equipped with.</para>
    /// labels<para>has ammunition</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/has_ammunition">http://www.sealitproject.eu/ontology/has_ammunition</seealso>
    let has_ammunition = Prefixed_Name(sealit, "has_ammunition") |> PrefixedName
    /// <summary>
    ///   <para>sealit:has_current_age</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the current age of a person at a specific time (the time of the information recording).</para>
    /// labels<para>has current age</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/has_current_age">http://www.sealitproject.eu/ontology/has_current_age</seealso>
    let has_current_age = Prefixed_Name(sealit, "has_current_age") |> PrefixedName
    /// <summary>
    ///   <para>sealit:has_duration_value</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property allows an instance of Duration to be approximated by an instance of E60 Number primitive that provides the duration value of a time-span. The value can be expressed in multiple units (such as “2 months and 5 days” or “3 years and 10 months” ), thus it is proposed to be implemented in RDFS following ISO 8601 [2] and xsd:duration [3] (form: PnYnMnDTnHnMnS).</para>
    /// labels<para>has duration value</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/has_duration_value">http://www.sealitproject.eu/ontology/has_duration_value</seealso>
    let has_duration_value = Prefixed_Name(sealit, "has_duration_value") |> PrefixedName
    /// <summary>
    ///   <para>sealit:Money_for_Things</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises transaction activities in which actors pay/receive money for services related to things, such as purchase of foods, etc.</para>
    /// labels<para>Money for Things</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Money_for_Things">http://www.sealitproject.eu/ontology/Money_for_Things</seealso>
    let Money_for_Things = Prefixed_Name(sealit, "Money_for_Things") |> PrefixedName

    /// <summary>
    ///   <para>sealit:participates_with_share</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>participates with share</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/participates_with_share">http://www.sealitproject.eu/ontology/participates_with_share</seealso>
    let participates_with_share =
        Prefixed_Name(sealit, "participates_with_share") |> PrefixedName

    /// <summary>
    ///   <para>sealit:Money_for_Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises transaction activities in which actors pay/receive money for services.</para>
    /// labels<para>Money for Service</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Money_for_Service">http://www.sealitproject.eu/ontology/Money_for_Service</seealso>
    let Money_for_Service = Prefixed_Name(sealit, "Money_for_Service") |> PrefixedName
    /// <summary>
    ///   <para>sealit:Navigation_Type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises concepts denoted by terms used to characterize and classify a ship, in particular its navigation type, based on the long or short distances of travel.</para>
    /// labels<para>Navigation Type</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Navigation_Type">http://www.sealitproject.eu/ontology/Navigation_Type</seealso>
    let Navigation_Type = Prefixed_Name(sealit, "Navigation_Type") |> PrefixedName
    /// <summary>
    ///   <para>sealit:PC_related_to</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>PC related to</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/PC_related_to">http://www.sealitproject.eu/ontology/PC_related_to</seealso>
    let PC_related_to = Prefixed_Name(sealit, "PC_related_to") |> PrefixedName
    /// <summary>
    ///   <para>sealit:PC_student_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>PC student_in</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/PC_student_in">http://www.sealitproject.eu/ontology/PC_student_in</seealso>
    let PC_student_in = Prefixed_Name(sealit, "PC_student_in") |> PrefixedName
    /// <summary>
    ///   <para>sealit:PCa_in_the_role_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>in the role of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/PCa_in_the_role_of">http://www.sealitproject.eu/ontology/PCa_in_the_role_of</seealso>
    let PCa_in_the_role_of = Prefixed_Name(sealit, "PCa_in_the_role_of") |> PrefixedName
    /// <summary>
    ///   <para>sealit:PCb_in_the_role_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>in the role of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/PCb_in_the_role_of">http://www.sealitproject.eu/ontology/PCb_in_the_role_of</seealso>
    let PCb_in_the_role_of = Prefixed_Name(sealit, "PCb_in_the_role_of") |> PrefixedName
    /// <summary>
    ///   <para>sealit:through_place</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property associates an instance of a place with an instance of a passing activity through that place. This class provides information about the types of movements of a ship, which are parts of the route (of the voyage), and are documented as that.</para>
    /// labels<para>through place</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/through_place">http://www.sealitproject.eu/ontology/through_place</seealso>
    let through_place = Prefixed_Name(sealit, "through_place") |> PrefixedName

    /// <summary>
    ///   <para>sealit:is_responsible_for_registration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is responsible for registration</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/is_responsible_for_registration">http://www.sealitproject.eu/ontology/is_responsible_for_registration</seealso>
    let is_responsible_for_registration =
        Prefixed_Name(sealit, "is_responsible_for_registration") |> PrefixedName

    /// <summary>
    ///   <para>sealit:starting_from</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the spatial location from which a voyage started. It is the beginning of the route.</para>
    /// labels<para>starting from</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/starting_from">http://www.sealitproject.eu/ontology/starting_from</seealso>
    let starting_from = Prefixed_Name(sealit, "starting_from") |> PrefixedName
    /// <summary>
    ///   <para>sealit:terminates</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>terminates</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/terminates">http://www.sealitproject.eu/ontology/terminates</seealso>
    let terminates = Prefixed_Name(sealit, "terminates") |> PrefixedName

    /// <summary>
    ///   <para>sealit:is_working_place_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is working place of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/is_working_place_of">http://www.sealitproject.eu/ontology/is_working_place_of</seealso>
    let is_working_place_of =
        Prefixed_Name(sealit, "is_working_place_of") |> PrefixedName

    /// <summary>
    ///   <para>sealit:works_at</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the workplace, meaning the organisation/company in which a person works at. The in the role of property of the property allows specifying the nature, the role of an actor’s work in the organisation/company.</para>
    /// labels<para>works at</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/works_at">http://www.sealitproject.eu/ontology/works_at</seealso>
    let works_at = Prefixed_Name(sealit, "works_at") |> PrefixedName
    /// <summary>
    ///   <para>sealit:loaded</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property associates an instance E18 Physical Thing with an instance of the loading activity that moved (loaded) it.</para>
    /// labels<para>loaded</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/loaded">http://www.sealitproject.eu/ontology/loaded</seealso>
    let loaded = Prefixed_Name(sealit, "loaded") |> PrefixedName
    /// <summary>
    ///   <para>sealit:provided_money</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>provided money</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/provided_money">http://www.sealitproject.eu/ontology/provided_money</seealso>
    let provided_money = Prefixed_Name(sealit, "provided_money") |> PrefixedName
    /// <summary>
    ///   <para>sealit:PC_has_type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has type</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/PC_has_type">http://www.sealitproject.eu/ontology/PC_has_type</seealso>
    let PC_has_type = Prefixed_Name(sealit, "PC_has_type") |> PrefixedName

    /// <summary>
    ///   <para>sealit:PC_provided_service</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>PC provided service</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/PC_provided_service">http://www.sealitproject.eu/ontology/PC_provided_service</seealso>
    let PC_provided_service =
        Prefixed_Name(sealit, "PC_provided_service") |> PrefixedName

    /// <summary>
    ///   <para>sealit:PC_with_status_of_participation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>with status of participation</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/PC_with_status_of_participation">http://www.sealitproject.eu/ontology/PC_with_status_of_participation</seealso>
    let PC_with_status_of_participation =
        Prefixed_Name(sealit, "PC_with_status_of_participation") |> PrefixedName

    /// <summary>
    ///   <para>sealit:PC_works_at</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>PC works at</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/PC_works_at">http://www.sealitproject.eu/ontology/PC_works_at</seealso>
    let PC_works_at = Prefixed_Name(sealit, "PC_works_at") |> PrefixedName

    /// <summary>
    ///   <para>sealit:is_place_of_passing_through</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is place of passing through</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/is_place_of_passing_through">http://www.sealitproject.eu/ontology/is_place_of_passing_through</seealso>
    let is_place_of_passing_through =
        Prefixed_Name(sealit, "is_place_of_passing_through") |> PrefixedName

    /// <summary>
    ///   <para>sealit:is_registered_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is registered by</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/is_registered_by">http://www.sealitproject.eu/ontology/is_registered_by</seealso>
    let is_registered_by = Prefixed_Name(sealit, "is_registered_by") |> PrefixedName
    /// <summary>
    ///   <para>sealit:registers</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property associates a ship and the ship registration activity that registered and identified it.</para>
    /// labels<para>registers</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/registers">http://www.sealitproject.eu/ontology/registers</seealso>
    let registers = Prefixed_Name(sealit, "registers") |> PrefixedName
    /// <summary>
    ///   <para>sealit:registered_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the authority, the port of registry, which is responsible for the registration of a ship.</para>
    /// labels<para>registered by</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/registered_by">http://www.sealitproject.eu/ontology/registered_by</seealso>
    let registered_by = Prefixed_Name(sealit, "registered_by") |> PrefixedName
    /// <summary>
    ///   <para>sealit:Passing</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises passing by (or through) activities of a ship at sea. This information helps to track the ships and the routes. Passing by or through is a part of the overall voyage. It includes information about places by/through which the ship passes within a specific timeframe.</para>
    /// labels<para>Passing</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Passing">http://www.sealitproject.eu/ontology/Passing</seealso>
    let Passing = Prefixed_Name(sealit, "Passing") |> PrefixedName

    /// <summary>
    ///   <para>sealit:is_starting_place_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>is starting place of</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/is_starting_place_of">http://www.sealitproject.eu/ontology/is_starting_place_of</seealso>
    let is_starting_place_of =
        Prefixed_Name(sealit, "is_starting_place_of") |> PrefixedName

    /// <summary>
    ///   <para>sealit:is_terminated_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property associates the end of existence of an instance of Legal Object Relationship with an explicit event that terminates it.</para>
    /// labels<para>is terminated by</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/is_terminated_by">http://www.sealitproject.eu/ontology/is_terminated_by</seealso>
    let is_terminated_by = Prefixed_Name(sealit, "is_terminated_by") |> PrefixedName
    /// <summary>
    ///   <para>sealit:money_provided_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the E39 Actor that paid (gave money) for a specific service (Money For Service).</para>
    /// labels<para>money provided by</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/money_provided_by">http://www.sealitproject.eu/ontology/money_provided_by</seealso>
    let money_provided_by = Prefixed_Name(sealit, "money_provided_by") |> PrefixedName
    /// <summary>
    ///   <para>sealit:money_provided_to</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the E39 Actor that received money for a specific service (Money For Service).</para>
    /// labels<para>money provided to</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/money_provided_to">http://www.sealitproject.eu/ontology/money_provided_to</seealso>
    let money_provided_to = Prefixed_Name(sealit, "money_provided_to") |> PrefixedName

    /// <summary>
    ///   <para>sealit:name_with_ownership</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>name with ownership</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/name_with_ownership">http://www.sealitproject.eu/ontology/name_with_ownership</seealso>
    let name_with_ownership =
        Prefixed_Name(sealit, "name_with_ownership") |> PrefixedName

    /// <summary>
    ///   <para>sealit:named_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>named with</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/named_with">http://www.sealitproject.eu/ontology/named_with</seealso>
    let named_with = Prefixed_Name(sealit, "named_with") |> PrefixedName

    /// <summary>
    ///   <para>sealit:navigated_by_captain</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the participation of an E39 Actor as being responsible for the navigation of the voyage. The captain may change from voyage to voyage. The concept of the captain is normally synonym to the concept of ruling, of the power of governing, so in that sense should be mapped to the E74 Group. But, in the context of the SeaLiT project, there is the requirement for a simpler structure with more details on the biographic data of a captain, so the decision is to model the captain as a role by person (not by group).</para>
    /// labels<para>navigated by captain</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/navigated_by_captain">http://www.sealitproject.eu/ontology/navigated_by_captain</seealso>
    let navigated_by_captain =
        Prefixed_Name(sealit, "navigated_by_captain") |> PrefixedName

    /// <summary>
    ///   <para>sealit:ownership_is_terminated_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property associates the end of existence of an instance of Ship Ownership Phase with a De-flagging event that terminates it.</para>
    /// labels<para>ownership is terminated by</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/ownership_is_terminated_by">http://www.sealitproject.eu/ontology/ownership_is_terminated_by</seealso>
    let ownership_is_terminated_by =
        Prefixed_Name(sealit, "ownership_is_terminated_by") |> PrefixedName

    /// <summary>
    ///   <para>sealit:terminates_ownership</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>terminates ownership</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/terminates_ownership">http://www.sealitproject.eu/ontology/terminates_ownership</seealso>
    let terminates_ownership =
        Prefixed_Name(sealit, "terminates_ownership") |> PrefixedName

    /// <summary>
    ///   <para>sealit:Port_of_Registry</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class describes the port (the issuing authority) that is responsible for a vessel registration.</para>
    /// labels<para>Port of Registry</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Port_of_Registry">http://www.sealitproject.eu/ontology/Port_of_Registry</seealso>
    let Port_of_Registry = Prefixed_Name(sealit, "Port_of_Registry") |> PrefixedName
    /// <summary>
    ///   <para>sealit:Promotion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises activities that result in the promotion, the advancement of an employee within a company position or job tasks or in a higher ranking as a reward for good performance. It is typically associated with a higher rate or a financial bonus.</para>
    /// labels<para>Promotion</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Promotion">http://www.sealitproject.eu/ontology/Promotion</seealso>
    let Promotion = Prefixed_Name(sealit, "Promotion") |> PrefixedName
    /// <summary>
    ///   <para>sealit:Recruitment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises the process of hiring and bringing new staff member to work for a company, or to become a new member of an organization. In the context of the SeaLiT project, which explores data regarding employments records with lists of maritime personnel, a recruitment is specifically defined in the sense of on board employment. Recruitment or embarkation is the activity that usually starts a sailor’s employment service. There is information from sources, such as from the Maritime Register of the State for La Ciotat (matricule des maîtres au cabotage) , referring that they used to have “recruitment” systems that registered every man 18 years old and up, or a younger boy (as apprentice), exercising one of the maritime professions for over a year, at the Navy’s disposal, in case of a war. On the same time, the state provided many privileges in return for service in the navy, such as tax exemptions, military pensions, free education and life insurance for the families of listed seamen.</para>
    /// labels<para>Recruitment</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Recruitment">http://www.sealitproject.eu/ontology/Recruitment</seealso>
    let Recruitment = Prefixed_Name(sealit, "Recruitment") |> PrefixedName
    /// <summary>
    ///   <para>sealit:was_loaded_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>was loaded by</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/was_loaded_by">http://www.sealitproject.eu/ontology/was_loaded_by</seealso>
    let was_loaded_by = Prefixed_Name(sealit, "was_loaded_by") |> PrefixedName
    /// <summary>
    ///   <para>sealit:received_money</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>received money</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/received_money">http://www.sealitproject.eu/ontology/received_money</seealso>
    let received_money = Prefixed_Name(sealit, "received_money") |> PrefixedName

    /// <summary>
    ///   <para>sealit:ownership_under_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the change of ship name because of an ownership phase. It can be used to provide previous/old names of a ship.</para>
    /// labels<para>ownership under name</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/ownership_under_name">http://www.sealitproject.eu/ontology/ownership_under_name</seealso>
    let ownership_under_name =
        Prefixed_Name(sealit, "ownership_under_name") |> PrefixedName

    /// <summary>
    ///   <para>sealit:under_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies the name of the ship with the ship construction information.</para>
    /// labels<para>under name</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/under_name">http://www.sealitproject.eu/ontology/under_name</seealso>
    let under_name = Prefixed_Name(sealit, "under_name") |> PrefixedName
    /// <summary>
    ///   <para>sealit:navigated</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>navigated</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/navigated">http://www.sealitproject.eu/ontology/navigated</seealso>
    let navigated = Prefixed_Name(sealit, "navigated") |> PrefixedName
    /// <summary>
    ///   <para>sealit:of_share</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the number of shares hold by an owner.</para>
    /// labels<para>of share</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/of_share">http://www.sealitproject.eu/ontology/of_share</seealso>
    let of_share = Prefixed_Name(sealit, "of_share") |> PrefixedName

    /// <summary>
    ///   <para>sealit:person_is_registered_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>person is registered by</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/person_is_registered_by">http://www.sealitproject.eu/ontology/person_is_registered_by</seealso>
    let person_is_registered_by =
        Prefixed_Name(sealit, "person_is_registered_by") |> PrefixedName

    /// <summary>
    ///   <para>sealit:registers_person</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes a person that is registered by a civil registration activity.</para>
    /// labels<para>registers person</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/registers_person">http://www.sealitproject.eu/ontology/registers_person</seealso>
    let registers_person = Prefixed_Name(sealit, "registers_person") |> PrefixedName

    /// <summary>
    ///   <para>sealit:promoted_into_status_type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property records the social status type that was promoted by a promotion activity. In that sense, we regard that a promotion can be related to a social status promotion or to a job/career promotion.</para>
    /// labels<para>promoted into status type</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/promoted_into_status_type">http://www.sealitproject.eu/ontology/promoted_into_status_type</seealso>
    let promoted_into_status_type =
        Prefixed_Name(sealit, "promoted_into_status_type") |> PrefixedName

    /// <summary>
    ///   <para>sealit:provided_service</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>provided service</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/provided_service">http://www.sealitproject.eu/ontology/provided_service</seealso>
    let provided_service = Prefixed_Name(sealit, "provided_service") |> PrefixedName
    /// <summary>
    ///   <para>sealit:related_to</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property describes the existence of a relation between persons, without the need to also specify the kind of relation. It is used in cases in which the types of the possible relationships between persons are many and not defined by the model, or in cases in which there is lack of knowledge about the kind of the relationships and there is only a requirement to mark just the existence of a link between persons. The property of property has type: E55 Type can be used to specify the type of relation, e.g., by linking to a vocabulary or thesaurus.</para>
    /// labels<para>related to</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/related_to">http://www.sealitproject.eu/ontology/related_to</seealso>
    let related_to = Prefixed_Name(sealit, "related_to") |> PrefixedName
    /// <summary>
    ///   <para>sealit:was_repaired_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>was repaired by</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/was_repaired_by">http://www.sealitproject.eu/ontology/was_repaired_by</seealso>
    let was_repaired_by = Prefixed_Name(sealit, "was_repaired_by") |> PrefixedName
    /// <summary>
    ///   <para>sealit:Punishment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises instances of punishments in terms of public policy, defined by an authority, as a response to a particular action that is deemed undesirable or unacceptable. Examples of penalties for punishment are prison, or loss of a privilege or of a status, etc.</para>
    /// labels<para>Punishment</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Punishment">http://www.sealitproject.eu/ontology/Punishment</seealso>
    let Punishment = Prefixed_Name(sealit, "Punishment") |> PrefixedName
    /// <summary>
    ///   <para>sealit:Religion_Status</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises concepts used to characterize the religious affiliation of a person.</para>
    /// labels<para>Religion Status</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Religion_Status">http://www.sealitproject.eu/ontology/Religion_Status</seealso>
    let Religion_Status = Prefixed_Name(sealit, "Religion_Status") |> PrefixedName
    /// <summary>
    ///   <para>sealit:Sex_Type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The gender of a person.</para>
    /// labels<para>Sex Type</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Sex_Type">http://www.sealitproject.eu/ontology/Sex_Type</seealso>
    let Sex_Type = Prefixed_Name(sealit, "Sex_Type") |> PrefixedName

    /// <summary>
    ///   <para>sealit:Ship_Ownership_Phase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises information about the ownership state of a ship. It consists of characteristics or properties of ownership. Ownership is a legal agreement, a kind of information that can be inferred/asserted and cannot be directly observed. Ownership usually characterizes/assigns a name to a ship and a ship changes its name under an ownership state. Ownership phase can be traced by the ship registration activity that initiates it, and by the de-flagging activity that terminates the phase. A single ship can have many owners (persons or/and companies).</para>
    /// labels<para>Ship Ownership Phase</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Ship_Ownership_Phase">http://www.sealitproject.eu/ontology/Ship_Ownership_Phase</seealso>
    let Ship_Ownership_Phase =
        Prefixed_Name(sealit, "Ship_Ownership_Phase") |> PrefixedName

    /// <summary>
    ///   <para>sealit:Section</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises information about sections of lessons. Some courses are divided into multiple sections.</para>
    /// labels<para>Section</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Section">http://www.sealitproject.eu/ontology/Section</seealso>
    let Section = Prefixed_Name(sealit, "Section") |> PrefixedName
    /// <summary>
    ///   <para>sealit:Shareholding</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class describes the common phenomenon through periods in which ships share ownership. Therefore, if for example a person is allowed to possess up to 1/48 of a ship, it means that a single person could have many ships shares in the same time. Sometimes the leading owner has the absolute majority of the shares, sometimes only the relative majority; these are just assumptions/examples that this class can describe.</para>
    /// labels<para>Shareholding</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Shareholding">http://www.sealitproject.eu/ontology/Shareholding</seealso>
    let Shareholding = Prefixed_Name(sealit, "Shareholding") |> PrefixedName
    /// <summary>
    ///   <para>sealit:Ship</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises vessels, ships of different kinds, which can cross large open waters. Ships have been important contributors to human migration and commerce.</para>
    /// labels<para>Ship</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Ship">http://www.sealitproject.eu/ontology/Ship</seealso>
    let Ship = Prefixed_Name(sealit, "Ship") |> PrefixedName
    /// <summary>
    ///   <para>sealit:repaired</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property identifies a ship repaired by a ship repair activity.</para>
    /// labels<para>repaired</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/repaired">http://www.sealitproject.eu/ontology/repaired</seealso>
    let repaired = Prefixed_Name(sealit, "repaired") |> PrefixedName

    /// <summary>
    ///   <para>sealit:status_type_was_promoted_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>status type was promoted by</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/status_type_was_promoted_by">http://www.sealitproject.eu/ontology/status_type_was_promoted_by</seealso>
    let status_type_was_promoted_by =
        Prefixed_Name(sealit, "status_type_was_promoted_by") |> PrefixedName

    /// <summary>
    ///   <para>sealit:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Service is the willing, the capability to offer a service, by some instance of E39 Actor, independently if it is executed or not. This offer is declared at the request of another instance of E39 Actor.</para>
    /// labels<para>Service</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Service">http://www.sealitproject.eu/ontology/Service</seealso>
    let Service = Prefixed_Name(sealit, "Service") |> PrefixedName
    /// <summary>
    ///   <para>sealit:with_ID</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property records the identifier that was assigned to a person in a Civil Registration activity.</para>
    /// labels<para>with ID</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/with_ID">http://www.sealitproject.eu/ontology/with_ID</seealso>
    let with_ID = Prefixed_Name(sealit, "with_ID") |> PrefixedName
    /// <summary>
    ///   <para>sealit:Language_Capacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This class comprises concepts denoting a person knowledge of various languages.</para>
    /// labels<para>Language Capacity</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/Language_Capacity">http://www.sealitproject.eu/ontology/Language_Capacity</seealso>
    let Language_Capacity = Prefixed_Name(sealit, "Language_Capacity") |> PrefixedName
    /// <summary>
    ///   <para>sealit:ended_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>ended by</para></remarks>
    /// <seealso href="http://www.sealitproject.eu/ontology/ended_by">http://www.sealitproject.eu/ontology/ended_by</seealso>
    let ended_by = Prefixed_Name(sealit, "ended_by") |> PrefixedName
