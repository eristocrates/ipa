namespace http.www.sealitproject.eu.ontology.slash

open DoxAletheia.Rdf_Vocabulary

module sealit =
    let _namespace_name = "http://www.sealitproject.eu/ontology/"
    /// <summary>
    /// This class comprises information about the kinds and the number of guns of the ship at the moment of registration. The current documentation is mostly about merchant ships. With the beginning of the Greek Revolution in 1821, the Greek merchant fleet was transformed to military – consequently, there are also references to vessels that have ammunition during that period.
    /// <see href="http://www.sealitproject.eu/ontology/Ammunition"></see></summary>
    let Ammunition = Namespaced_IRI.parse _namespace_name "Ammunition" |> NamespacedName
    /// <summary>
    /// This class comprises the arrival activity of a ship, which is a part, a stage of the overall voyage. It includes information about a place where the ship lands within a specific timeframe. It describes end points of the partial routes or within the overall voyage.
    /// <see href="http://www.sealitproject.eu/ontology/Arrival"></see></summary>
    let Arrival = Namespaced_IRI.parse _namespace_name "Arrival" |> NamespacedName

    /// <summary>
    /// Civil registration stands for legal processes of registering persons in various contexts. The outcomes of this process are legal documents such as civil acts of birth or death, or other documents (such as Register of Entries in shipyards), which usually have a period of validity.
    /// <see href="http://www.sealitproject.eu/ontology/Civil_Registration"></see></summary>
    let Civil_Registration =
        Namespaced_IRI.parse _namespace_name "Civil_Registration" |> NamespacedName

    /// <summary>
    /// This class describes the country, a place identified as a distinct entity in political geography.
    /// <see href="http://www.sealitproject.eu/ontology/Country"></see></summary>
    let Country = Namespaced_IRI.parse _namespace_name "Country" |> NamespacedName
    /// <summary>
    /// This class comprises information about courses, teaching units divided and organized for educational purposes.
    /// <see href="http://www.sealitproject.eu/ontology/Course"></see></summary>
    let Course = Namespaced_IRI.parse _namespace_name "Course" |> NamespacedName

    /// <summary>
    /// This class comprises information about the school year, the period of time during which the school holds classes and offers courses. It is a period of educational activities.
    /// <see href="http://www.sealitproject.eu/ontology/Teaching_Unit"></see></summary>
    let Teaching_Unit =
        Namespaced_IRI.parse _namespace_name "Teaching_Unit" |> NamespacedName

    /// <summary>
    /// This class comprises information about the wage payments of the people that are members of the crew of a ship.
    /// <see href="http://www.sealitproject.eu/ontology/Crew_Payment"></see></summary>
    let Crew_Payment =
        Namespaced_IRI.parse _namespace_name "Crew_Payment" |> NamespacedName

    /// <summary>
    /// This class comprises activities in which actors pay/receive money for services related to labour, human work, in order to earn wage.
    /// <see href="http://www.sealitproject.eu/ontology/Money_for_Labour"></see></summary>
    let Money_for_Labour =
        Namespaced_IRI.parse _namespace_name "Money_for_Labour" |> NamespacedName

    /// <summary>
    /// De-flagging is regarded in this context as synonym to ship de-registration. When a ship is no longer flagged, this means that for a reason (e.g., demolished, shipwreck, lost, sold, etc.) the ship does not anymore sail under a legal state (of registration, having a flag).
    /// <see href="http://www.sealitproject.eu/ontology/De-flagging"></see></summary>
    let ``De-flagging`` =
        Namespaced_IRI.parse _namespace_name "De-flagging" |> NamespacedName

    /// <summary>
    /// This class comprises the termination of a working relationship, the ending of an employee to provide service. In the context of the SeaLiT project, which explores data regarding employments records with lists of maritime personnel, a discharge is specifically defined in the sense of disembarkation, which is the activity that usually terminates a sailor’s employment service.
    /// <see href="http://www.sealitproject.eu/ontology/Discharge"></see></summary>
    let Discharge = Namespaced_IRI.parse _namespace_name "Discharge" |> NamespacedName
    /// <summary>
    /// This class expresses the length of time in terms of indeterminacy of the duration value that can be approximated. A duration may be expressed using all the parts of a date-time (from years to seconds) and can therefore be defined as a six-dimensional space. Because the relation between some of date parts is not fixed (such as the number of days in a month), the order relationship between durations is only partial, and the result of a comparison between two durations may be undetermined. The same value may consists of different parts, such as 4 years, 10 months and 2 days.
    /// <see href="http://www.sealitproject.eu/ontology/Duration"></see></summary>
    let Duration = Namespaced_IRI.parse _namespace_name "Duration" |> NamespacedName
    /// <summary>
    /// This class comprises information about employment services between two parties, usually based on a contract where work is paid for. In the context of the SeaLiT project, it comprises information about the employment services provided on board. This relationship is initiated by the recruitment of the sailor man and is terminated by the discharge/disembarkation of this worker.
    /// <see href="http://www.sealitproject.eu/ontology/Employment"></see></summary>
    let Employment = Namespaced_IRI.parse _namespace_name "Employment" |> NamespacedName
    /// <summary>
    /// Service is the willing, the capability to offer a service, by some instance of E39 Actor, independently if it is executed or not. This offer is declared at the request of another instance of E39 Actor.
    /// <see href="http://www.sealitproject.eu/ontology/Service"></see></summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName
    /// <summary>
    /// The power of the ship’s marine propulsion engine. The overall operation of the ship is highly dependent on the performance of its main propulsion engine, measured in terms of its power rating. There are various types of horsepower such as Nominal horsepower (NHP), Shaft horsepower (SHP), Indicated horsepower (IHP).
    /// <see href="http://www.sealitproject.eu/ontology/Horsepower"></see></summary>
    let Horsepower = Namespaced_IRI.parse _namespace_name "Horsepower" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/ID_of"></see>
    /// </summary>
    let ID_of = Namespaced_IRI.parse _namespace_name "ID_of" |> NamespacedName
    /// <summary>
    /// This property records the identifier that was assigned to a person in a Civil Registration activity.
    /// <see href="http://www.sealitproject.eu/ontology/with_ID"></see></summary>
    let with_ID = Namespaced_IRI.parse _namespace_name "with_ID" |> NamespacedName

    /// <summary>
    /// This class comprises plans expressed in a document that specifies the employment conditions.
    /// <see href="http://www.sealitproject.eu/ontology/Labour_Contract"></see></summary>
    let Labour_Contract =
        Namespaced_IRI.parse _namespace_name "Labour_Contract" |> NamespacedName

    /// <summary>
    /// This class comprises concepts denoting a person knowledge of various languages.
    /// <see href="http://www.sealitproject.eu/ontology/Language_Capacity"></see></summary>
    let Language_Capacity =
        Namespaced_IRI.parse _namespace_name "Language_Capacity" |> NamespacedName

    /// <summary>
    /// This class comprises the leaving of a ship, which is a part, a stage of the overall voyage. It includes information about a place from which the ship leaves within a specific timeframe. It describes start points of the partial routes or with the overall voyage.
    /// <see href="http://www.sealitproject.eu/ontology/Leaving"></see></summary>
    let Leaving = Namespaced_IRI.parse _namespace_name "Leaving" |> NamespacedName

    /// <summary>
    /// This class comprises official documents or legal agreements that are valid for a specific timespan. The concept of this class includes licenses, official permissions, authorizations, etc., having a temporal validity.
    /// <see href="http://www.sealitproject.eu/ontology/Legal_Document_with_Temporal_Validity"></see></summary>
    let Legal_Document_with_Temporal_Validity =
        Namespaced_IRI.parse _namespace_name "Legal_Document_with_Temporal_Validity" |> NamespacedName

    /// <summary>
    /// This class comprises legal object relationships of which the timespan and the state (of these relationships) cannot be observed or documented. We can only observe these relationships through the events that initialize or terminate this state of relationship (starting event and terminating event). Basically, it comprises of characteristics/properties of a legal relationship which is the kind of information that can be inferred/asserted and not by temporal documentation of these properties.
    /// <see href="http://www.sealitproject.eu/ontology/Legal_Object_Relationship"></see></summary>
    let Legal_Object_Relationship =
        Namespaced_IRI.parse _namespace_name "Legal_Object_Relationship" |> NamespacedName

    /// <summary>
    /// This class comprises concepts denoting a person’s literacy status.
    /// <see href="http://www.sealitproject.eu/ontology/Literacy_Status"></see></summary>
    let Literacy_Status =
        Namespaced_IRI.parse _namespace_name "Literacy_Status" |> NamespacedName

    /// <summary>
    /// This class comprises loading activities as they are documented during the voyages (or as parts of the routes) of the ships. It seems that the definition of a ship includes the notion of the loading of things; the procedures of loading/unloading are very important; the types of ships, the ports and the routes seem to define the types of loading, the dimensions, and the technology of loading/unloading and storage in ships.
    /// <see href="http://www.sealitproject.eu/ontology/Loading"></see></summary>
    let Loading = Namespaced_IRI.parse _namespace_name "Loading" |> NamespacedName

    /// <summary>
    /// This class comprises transaction activities in which actors pay/receive money for services.
    /// <see href="http://www.sealitproject.eu/ontology/Money_for_Service"></see></summary>
    let Money_for_Service =
        Namespaced_IRI.parse _namespace_name "Money_for_Service" |> NamespacedName

    /// <summary>
    /// This class comprises transaction activities in which actors pay/receive money for services related to things, such as purchase of foods, etc.
    /// <see href="http://www.sealitproject.eu/ontology/Money_for_Things"></see></summary>
    let Money_for_Things =
        Namespaced_IRI.parse _namespace_name "Money_for_Things" |> NamespacedName

    /// <summary>
    /// This class comprises concepts denoted by terms used to characterize and classify a ship, in particular its navigation type, based on the long or short distances of travel.
    /// <see href="http://www.sealitproject.eu/ontology/Navigation_Type"></see></summary>
    let Navigation_Type =
        Namespaced_IRI.parse _namespace_name "Navigation_Type" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/PC_has_type"></see>
    /// </summary>
    let PC_has_type =
        Namespaced_IRI.parse _namespace_name "PC_has_type" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/PC_related_to"></see>
    /// </summary>
    let PC_related_to =
        Namespaced_IRI.parse _namespace_name "PC_related_to" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/PC_provided_service"></see>
    /// </summary>
    let PC_provided_service =
        Namespaced_IRI.parse _namespace_name "PC_provided_service" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/PC_student_in"></see>
    /// </summary>
    let PC_student_in =
        Namespaced_IRI.parse _namespace_name "PC_student_in" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/PC_with_status_of_participation"></see>
    /// </summary>
    let PC_with_status_of_participation =
        Namespaced_IRI.parse _namespace_name "PC_with_status_of_participation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/PC_works_at"></see>
    /// </summary>
    let PC_works_at =
        Namespaced_IRI.parse _namespace_name "PC_works_at" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/PCa_in_the_role_of"></see>
    /// </summary>
    let PCa_in_the_role_of =
        Namespaced_IRI.parse _namespace_name "PCa_in_the_role_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/PCb_in_the_role_of"></see>
    /// </summary>
    let PCb_in_the_role_of =
        Namespaced_IRI.parse _namespace_name "PCb_in_the_role_of" |> NamespacedName

    /// <summary>
    /// This class comprises passing by (or through) activities of a ship at sea. This information helps to track the ships and the routes. Passing by or through is a part of the overall voyage. It includes information about places by/through which the ship passes within a specific timeframe.
    /// <see href="http://www.sealitproject.eu/ontology/Passing"></see></summary>
    let Passing = Namespaced_IRI.parse _namespace_name "Passing" |> NamespacedName

    /// <summary>
    /// This class describes the port (the issuing authority) that is responsible for a vessel registration.
    /// <see href="http://www.sealitproject.eu/ontology/Port_of_Registry"></see></summary>
    let Port_of_Registry =
        Namespaced_IRI.parse _namespace_name "Port_of_Registry" |> NamespacedName

    /// <summary>
    /// This class comprises information about the person profession, work, career or job, as it was written inside the original source.
    /// <see href="http://www.sealitproject.eu/ontology/Profession"></see></summary>
    let Profession = Namespaced_IRI.parse _namespace_name "Profession" |> NamespacedName
    /// <summary>
    /// This class comprises activities that result in the promotion, the advancement of an employee within a company position or job tasks or in a higher ranking as a reward for good performance. It is typically associated with a higher rate or a financial bonus.
    /// <see href="http://www.sealitproject.eu/ontology/Promotion"></see></summary>
    let Promotion = Namespaced_IRI.parse _namespace_name "Promotion" |> NamespacedName
    /// <summary>
    /// This class comprises instances of punishments in terms of public policy, defined by an authority, as a response to a particular action that is deemed undesirable or unacceptable. Examples of penalties for punishment are prison, or loss of a privilege or of a status, etc.
    /// <see href="http://www.sealitproject.eu/ontology/Punishment"></see></summary>
    let Punishment = Namespaced_IRI.parse _namespace_name "Punishment" |> NamespacedName

    /// <summary>
    /// This class comprises the process of hiring and bringing new staff member to work for a company, or to become a new member of an organization. In the context of the SeaLiT project, which explores data regarding employments records with lists of maritime personnel, a recruitment is specifically defined in the sense of on board employment. Recruitment or embarkation is the activity that usually starts a sailor’s employment service. There is information from sources, such as from the Maritime Register of the State for La Ciotat (matricule des maîtres au cabotage) , referring that they used to have “recruitment” systems that registered every man 18 years old and up, or a younger boy (as apprentice), exercising one of the maritime professions for over a year, at the Navy’s disposal, in case of a war. On the same time, the state provided many privileges in return for service in the navy, such as tax exemptions, military pensions, free education and life insurance for the families of listed seamen.
    /// <see href="http://www.sealitproject.eu/ontology/Recruitment"></see></summary>
    let Recruitment =
        Namespaced_IRI.parse _namespace_name "Recruitment" |> NamespacedName

    /// <summary>
    /// This class comprises concepts used to characterize the religious affiliation of a person.
    /// <see href="http://www.sealitproject.eu/ontology/Religion_Status"></see></summary>
    let Religion_Status =
        Namespaced_IRI.parse _namespace_name "Religion_Status" |> NamespacedName

    /// <summary>
    /// This class comprises information about sections of lessons. Some courses are divided into multiple sections.
    /// <see href="http://www.sealitproject.eu/ontology/Section"></see></summary>
    let Section = Namespaced_IRI.parse _namespace_name "Section" |> NamespacedName
    /// <summary>
    /// The gender of a person.
    /// <see href="http://www.sealitproject.eu/ontology/Sex_Type"></see></summary>
    let Sex_Type = Namespaced_IRI.parse _namespace_name "Sex_Type" |> NamespacedName

    /// <summary>
    /// This class describes the common phenomenon through periods in which ships share ownership. Therefore, if for example a person is allowed to possess up to 1/48 of a ship, it means that a single person could have many ships shares in the same time. Sometimes the leading owner has the absolute majority of the shares, sometimes only the relative majority; these are just assumptions/examples that this class can describe.
    /// <see href="http://www.sealitproject.eu/ontology/Shareholding"></see></summary>
    let Shareholding =
        Namespaced_IRI.parse _namespace_name "Shareholding" |> NamespacedName

    /// <summary>
    /// This class comprises information about the ownership state of a ship. It consists of characteristics or properties of ownership. Ownership is a legal agreement, a kind of information that can be inferred/asserted and cannot be directly observed. Ownership usually characterizes/assigns a name to a ship and a ship changes its name under an ownership state. Ownership phase can be traced by the ship registration activity that initiates it, and by the de-flagging activity that terminates the phase. A single ship can have many owners (persons or/and companies).
    /// <see href="http://www.sealitproject.eu/ontology/Ship_Ownership_Phase"></see></summary>
    let Ship_Ownership_Phase =
        Namespaced_IRI.parse _namespace_name "Ship_Ownership_Phase" |> NamespacedName

    /// <summary>
    /// This class comprises vessels, ships of different kinds, which can cross large open waters. Ships have been important contributors to human migration and commerce.
    /// <see href="http://www.sealitproject.eu/ontology/Ship"></see></summary>
    let Ship = Namespaced_IRI.parse _namespace_name "Ship" |> NamespacedName

    /// <summary>
    /// This class describes the activity of building new ships and other floating vessels. The ship construction information, in particular the location and date of construction, is the most reliable information (extracted from the source) that helps to identify a ship. A very important methodological question is what information can be used to define the unique identity of a ship. The answer is that there does not exist a single information that can define it: it is always a matter of comparison of the sources and information. Even though, there is information that is critical to the identity of a ship, such as the place and the year of construction.
    /// <see href="http://www.sealitproject.eu/ontology/Ship_Construction"></see></summary>
    let Ship_Construction =
        Namespaced_IRI.parse _namespace_name "Ship_Construction" |> NamespacedName

    /// <summary>
    /// This class comprises numeric information assigned as registration number of a ship.
    /// <see href="http://www.sealitproject.eu/ontology/Ship_ID"></see></summary>
    let Ship_ID = Namespaced_IRI.parse _namespace_name "Ship_ID" |> NamespacedName
    /// <summary>
    /// This class comprises the name that identifies a ship. The name of the ship can be changed because of an ownership (so a ship can have many names through time).
    /// <see href="http://www.sealitproject.eu/ontology/Ship_Name"></see></summary>
    let Ship_Name = Namespaced_IRI.parse _namespace_name "Ship_Name" |> NamespacedName

    /// <summary>
    /// A ship acquires legal identity with the process of its registration, the register of its name, flag, id, dimensions and horsepower. The ownership information is documented in the registry book signed by the Port of Registry.
    /// <see href="http://www.sealitproject.eu/ontology/Ship_Registration"></see></summary>
    let Ship_Registration =
        Namespaced_IRI.parse _namespace_name "Ship_Registration" |> NamespacedName

    /// <summary>
    /// This class comprises activities that alter or change or restore/repair a ship.
    /// <see href="http://www.sealitproject.eu/ontology/Ship_Repair"></see></summary>
    let Ship_Repair =
        Namespaced_IRI.parse _namespace_name "Ship_Repair" |> NamespacedName

    /// <summary>
    /// This class comprises a person’s social status, as it was written inside the original source. This can include different kinds of social status, such as marital status or estate. In such cases of further classification, these concepts can be used as instances of the Social Status class. This class extends E55 Type in order to refine the meaning of this specific concept (social status). This concept is sufficiently stable and associated with additional explicitly modelled property specific to it ( “has social status” ). An alternative mechanism is to specialize the classification of Social Status instances to any level of detail, by linking to external vocabulary sources, thesauri, classification schemas or ontologies. In general, a good practice for concepts that are not user defined metaclasses, would be to be treated as particulars with the relationship P2 has type.
    /// <see href="http://www.sealitproject.eu/ontology/Social_Status"></see></summary>
    let Social_Status =
        Namespaced_IRI.parse _namespace_name "Social_Status" |> NamespacedName

    /// <summary>
    /// This class comprises information about the scientific subjects of the courses that were taught at a specific semester.
    /// <see href="http://www.sealitproject.eu/ontology/Subject"></see></summary>
    let Subject = Namespaced_IRI.parse _namespace_name "Subject" |> NamespacedName
    /// <summary>
    /// Tonnage is a measure of the cargo-carrying capacity of a ship. The sources refer to different kinds of tonnage, such as gross tonnage, net tonnage, etc. and through time, tonnage types may change. Tonnage may change during a reconstruction phase of a ship, for example.
    /// <see href="http://www.sealitproject.eu/ontology/Tonnage"></see></summary>
    let Tonnage = Namespaced_IRI.parse _namespace_name "Tonnage" |> NamespacedName
    /// <summary>
    /// This class comprises unloading activities as they are documented during the voyages (or as parts of the routes) of the ships. The procedures of loading/unloading are very important; the types of ships, the ports and the routes seem to define the types of loading, the dimensions, and the technology of loading/unloading and storage in ships.
    /// <see href="http://www.sealitproject.eu/ontology/Unloading"></see></summary>
    let Unloading = Namespaced_IRI.parse _namespace_name "Unloading" |> NamespacedName
    /// <summary>
    /// This class comprises information about the voyages of ships. Voyage is defined as the process of travelling from one place to another, staying there, usually for a short time; it is not a simple move/change from place to place; it is a movement in space and time (and it is documented as that [1] ). The same ship can sail many voyages during its lifetime. Voyage and route information is very important for historically investigating the various trade routes and navigation patterns used to exist in different times. Voyage is an important aspect of the ship and the seaman, and generally of the seafaring life, both at sea and ashore .
    /// <see href="http://www.sealitproject.eu/ontology/Voyage"></see></summary>
    let Voyage = Namespaced_IRI.parse _namespace_name "Voyage" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/arrival_is_part_of"></see>
    /// </summary>
    let arrival_is_part_of =
        Namespaced_IRI.parse _namespace_name "arrival_is_part_of" |> NamespacedName

    /// <summary>
    /// This property allows an instance of a Voyage to be analysed into parts such as arrival activities. It is a subproperty of P9 consists of (forms part of). This analysis of parts of the voyage contributes to the route analysis, which provides information about specific navigation patterns of the ship.
    /// <see href="http://www.sealitproject.eu/ontology/consists_of_arrival"></see></summary>
    let consists_of_arrival =
        Namespaced_IRI.parse _namespace_name "consists_of_arrival" |> NamespacedName

    /// <summary>
    /// This property describes the spatial location of an arrival.
    /// <see href="http://www.sealitproject.eu/ontology/at_place"></see></summary>
    let at_place = Namespaced_IRI.parse _namespace_name "at_place" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_place_of_arrival"></see>
    /// </summary>
    let is_place_of_arrival =
        Namespaced_IRI.parse _namespace_name "is_place_of_arrival" |> NamespacedName

    /// <summary>
    /// This property associates an instance of a place with an instance of a passing activity by that place. This class provides information about the types of movements of a ship, which are parts of the route (of the voyage), and are documented as that.
    /// <see href="http://www.sealitproject.eu/ontology/by_place"></see></summary>
    let by_place = Namespaced_IRI.parse _namespace_name "by_place" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_place_of_passing_by"></see>
    /// </summary>
    let is_place_of_passing_by =
        Namespaced_IRI.parse _namespace_name "is_place_of_passing_by" |> NamespacedName

    /// <summary>
    /// This property identifies the person that was promoted by a promotion activity.
    /// <see href="http://www.sealitproject.eu/ontology/concerned"></see></summary>
    let concerned = Namespaced_IRI.parse _namespace_name "concerned" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/was_promoted_by"></see>
    /// </summary>
    let was_promoted_by =
        Namespaced_IRI.parse _namespace_name "was_promoted_by" |> NamespacedName

    /// <summary>
    /// This property allows an instance of a Voyage to be analysed into parts such as leaving activities. It is a subproperty of P9 consists of (forms part of). This analysis of parts of the voyage contributes to the route analysis, which provides information about specific navigation patterns of the ship.
    /// <see href="http://www.sealitproject.eu/ontology/consists_of_leaving"></see></summary>
    let consists_of_leaving =
        Namespaced_IRI.parse _namespace_name "consists_of_leaving" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/leaving_is_part_of"></see>
    /// </summary>
    let leaving_is_part_of =
        Namespaced_IRI.parse _namespace_name "leaving_is_part_of" |> NamespacedName

    /// <summary>
    /// This property allows an instance of a Voyage to be analysed into parts such as loading activities. It is a subproperty of P9 consists of (forms part of). The activities of loading/unloading happen ashore, before, in between, or after (with the end) of the voyage of a ship and are part of its definition.
    /// <see href="http://www.sealitproject.eu/ontology/consists_of_loading"></see></summary>
    let consists_of_loading =
        Namespaced_IRI.parse _namespace_name "consists_of_loading" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/loading_is_part_of"></see>
    /// </summary>
    let loading_is_part_of =
        Namespaced_IRI.parse _namespace_name "loading_is_part_of" |> NamespacedName

    /// <summary>
    /// This property allows an instance of a Voyage to be analysed into parts such as passing by/through activities. It is a subproperty of P9 consists of (forms part of). This analysis of parts of the voyage contributes to the route analysis, which provides information about specific navigation patterns of the ship
    /// <see href="http://www.sealitproject.eu/ontology/consists_of_passing"></see></summary>
    let consists_of_passing =
        Namespaced_IRI.parse _namespace_name "consists_of_passing" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/passing_is_part_of"></see>
    /// </summary>
    let passing_is_part_of =
        Namespaced_IRI.parse _namespace_name "passing_is_part_of" |> NamespacedName

    /// <summary>
    /// This property allows an instance of a Voyage to be analysed into parts such as unloading activities. It is a subproperty of P9 consists of (forms part of). The activities of loading/unloading happen ashore, before, in between, or after (with the end) of the voyage of a ship and are part of its definition.
    /// <see href="http://www.sealitproject.eu/ontology/consists_of_unloading"></see></summary>
    let consists_of_unloading =
        Namespaced_IRI.parse _namespace_name "consists_of_unloading" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/unloading_is_part_of"></see>
    /// </summary>
    let unloading_is_part_of =
        Namespaced_IRI.parse _namespace_name "unloading_is_part_of" |> NamespacedName

    /// <summary>
    /// This property identifies a ship that came into existence as a result of a construction event.
    /// <see href="http://www.sealitproject.eu/ontology/constructed"></see></summary>
    let constructed =
        Namespaced_IRI.parse _namespace_name "constructed" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/was_constructed_by"></see>
    /// </summary>
    let was_constructed_by =
        Namespaced_IRI.parse _namespace_name "was_constructed_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/de-flagged_in"></see>
    /// </summary>
    let ``de-flagged_in`` =
        Namespaced_IRI.parse _namespace_name "de-flagged_in" |> NamespacedName

    /// <summary>
    /// This property associates an instance of a ship with the instance of the de-flagging activity that de-registered it.
    /// <see href="http://www.sealitproject.eu/ontology/de-flagging_of"></see></summary>
    let ``de-flagging_of`` =
        Namespaced_IRI.parse _namespace_name "de-flagging_of" |> NamespacedName

    /// <summary>
    /// This property describes the intended place where the voyage, theoretically, according to the maps and the plans should end. It is the planned destination of the route, which may change in reality.
    /// <see href="http://www.sealitproject.eu/ontology/destination"></see></summary>
    let destination =
        Namespaced_IRI.parse _namespace_name "destination" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_destination_of"></see>
    /// </summary>
    let is_destination_of =
        Namespaced_IRI.parse _namespace_name "is_destination_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/duration_of"></see>
    /// </summary>
    let duration_of =
        Namespaced_IRI.parse _namespace_name "duration_of" |> NamespacedName

    /// <summary>
    /// This property describes the length of time covered by an E52 Time-Span. It allows an E52 Time-Span to be associated with a duration (as a dimension, an interval) independent from the actual beginning and end.
    /// <see href="http://www.sealitproject.eu/ontology/had_duration"></see></summary>
    let had_duration =
        Namespaced_IRI.parse _namespace_name "had_duration" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/employment_of"></see>
    /// </summary>
    let employment_of =
        Namespaced_IRI.parse _namespace_name "employment_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/service_of"></see>
    /// </summary>
    let service_of = Namespaced_IRI.parse _namespace_name "service_of" |> NamespacedName

    /// <summary>
    /// This property associates an instance of a payment with an instance of an employment that was used in order to specify rights and responsibilities between the “employee” and the “employer”.
    /// <see href="http://www.sealitproject.eu/ontology/for_employment"></see></summary>
    let for_employment =
        Namespaced_IRI.parse _namespace_name "for_employment" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/employment_position_type_was_promoted_by"></see>
    /// </summary>
    let employment_position_type_was_promoted_by =
        Namespaced_IRI.parse _namespace_name "employment_position_type_was_promoted_by" |> NamespacedName

    /// <summary>
    /// This property records the employment (job) position type that was promoted by a promotion activity. In that sense, we regard that a promotion can be related to a social status promotion or to a job/career promotion.
    /// <see href="http://www.sealitproject.eu/ontology/promoted_into_employment_position_type"></see></summary>
    let promoted_into_employment_position_type =
        Namespaced_IRI.parse _namespace_name "promoted_into_employment_position_type" |> NamespacedName

    /// <summary>
    /// This property describes the employment service provided by an E39 Actor.
    /// <see href="http://www.sealitproject.eu/ontology/employment_provided_by"></see></summary>
    let employment_provided_by =
        Namespaced_IRI.parse _namespace_name "employment_provided_by" |> NamespacedName

    /// <summary>
    /// This property describes the intention of an E39 Actor to provide a service. The property of property in the role of allows specifying the nature of an Actor’s service provision.
    /// <see href="http://www.sealitproject.eu/ontology/service_provided_by"></see></summary>
    let service_provided_by =
        Namespaced_IRI.parse _namespace_name "service_provided_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/provided_employment"></see>
    /// </summary>
    let provided_employment =
        Namespaced_IRI.parse _namespace_name "provided_employment" |> NamespacedName

    /// <summary>
    /// This property describes an employment that was ended/terminated by a discharge activity.
    /// <see href="http://www.sealitproject.eu/ontology/ended"></see></summary>
    let ended = Namespaced_IRI.parse _namespace_name "ended" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/ended_by"></see>
    /// </summary>
    let ended_by = Namespaced_IRI.parse _namespace_name "ended_by" |> NamespacedName

    /// <summary>
    /// This property identifies the final place (end) of a voyage. It is the actual arrival place, meaning it does not refer to the original destination place but the place to which the ship finally arrived.
    /// <see href="http://www.sealitproject.eu/ontology/finally_arriving_at"></see></summary>
    let finally_arriving_at =
        Namespaced_IRI.parse _namespace_name "finally_arriving_at" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_arrival_place_of"></see>
    /// </summary>
    let is_arrival_place_of =
        Namespaced_IRI.parse _namespace_name "is_arrival_place_of" |> NamespacedName

    /// <summary>
    /// This property describes a Money for Service activity that pays/receives money for Services.
    /// <see href="http://www.sealitproject.eu/ontology/for_service"></see></summary>
    let for_service =
        Namespaced_IRI.parse _namespace_name "for_service" |> NamespacedName

    /// <summary>
    /// This property describes the total timespan (full employment period) of the Money for Labour activity and it is a shortcut of the most detailed path: Money for Labour – for employment: Employment – P4 has timespan: E52 Time-Span (timespan of recruitment and discharge) . The time-span can be also specified through a Duration instance, using the property had duration (duration of).
    /// <see href="http://www.sealitproject.eu/ontology/for_employment_period"></see></summary>
    let for_employment_period =
        Namespaced_IRI.parse _namespace_name "for_employment_period" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_employment_period_of"></see>
    /// </summary>
    let is_employment_period_of =
        Namespaced_IRI.parse _namespace_name "is_employment_period_of" |> NamespacedName

    /// <summary>
    /// This property describes a Money for Things activity that pays/receives money for physical things.
    /// <see href="http://www.sealitproject.eu/ontology/for_thing"></see></summary>
    let for_thing = Namespaced_IRI.parse _namespace_name "for_thing" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/thing_of"></see>
    /// </summary>
    let thing_of = Namespaced_IRI.parse _namespace_name "thing_of" |> NamespacedName
    /// <summary>
    /// This property describes the voyage that sets the preconditions (motivates, determines, fixes) a crew payment. There is a dependency relationship between them; a new voyage sets the preconditions for a new crew payment activity.
    /// <see href="http://www.sealitproject.eu/ontology/for_voyage"></see></summary>
    let for_voyage = Namespaced_IRI.parse _namespace_name "for_voyage" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/motivated_payment"></see>
    /// </summary>
    let motivated_payment =
        Namespaced_IRI.parse _namespace_name "motivated_payment" |> NamespacedName

    /// <summary>
    /// This property associates an instance of a Legal Document with Temporal Validity with the instance of an Actor that formerly or currently possesses it, at the time of validity of the record or database containing the statement that uses this property. The property does not allow any indication of how long the legal document with temporal validity has been possessed by the specific Actor.
    /// <see href="http://www.sealitproject.eu/ontology/formerly_or_currently_possesses"></see></summary>
    let formerly_or_currently_possesses =
        Namespaced_IRI.parse _namespace_name "formerly_or_currently_possesses" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_formerly_or_currently_possessed_by"></see>
    /// </summary>
    let is_formerly_or_currently_possessed_by =
        Namespaced_IRI.parse _namespace_name "is_formerly_or_currently_possessed_by" |> NamespacedName

    /// <summary>
    /// This property describes the spatial location from which leaving (of ship) was documented. The description of this type of movement provides information about the route analysis.
    /// <see href="http://www.sealitproject.eu/ontology/from_place"></see></summary>
    let from_place = Namespaced_IRI.parse _namespace_name "from_place" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_place_of_leaving"></see>
    /// </summary>
    let is_place_of_leaving =
        Namespaced_IRI.parse _namespace_name "is_place_of_leaving" |> NamespacedName

    /// <summary>
    /// This property associates an instance of a Ship with an instance of the country of which this ship becomes property and consequently acquires this country’s flag. The property is a shortcut of the full path Ship – is registered by: Ship Registration – with ship flag of: Country.
    /// <see href="http://www.sealitproject.eu/ontology/had_flag_of"></see></summary>
    let had_flag_of =
        Namespaced_IRI.parse _namespace_name "had_flag_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/was_flag_of"></see>
    /// </summary>
    let was_flag_of =
        Namespaced_IRI.parse _namespace_name "was_flag_of" |> NamespacedName

    /// <summary>
    /// This property describes the Monetary Amount paid (i.e., the cost) for a specific Money for Service activity.
    /// <see href="http://www.sealitproject.eu/ontology/had_money_value"></see></summary>
    let had_money_value =
        Namespaced_IRI.parse _namespace_name "had_money_value" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/was_price_of"></see>
    /// </summary>
    let was_price_of =
        Namespaced_IRI.parse _namespace_name "was_price_of" |> NamespacedName

    /// <summary>
    /// This property associates instances of E39 Actor with the instances of Teaching Unit in which they participated in the role of students. The property of the property status of participation allows specifying the nature of an Actor’s participation in a course/teaching unit. For example, it can be the student’s exam status or paying/scholarship status in a course.
    /// <see href="http://www.sealitproject.eu/ontology/had_student"></see></summary>
    let had_student =
        Namespaced_IRI.parse _namespace_name "had_student" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/student_in"></see>
    /// </summary>
    let student_in = Namespaced_IRI.parse _namespace_name "student_in" |> NamespacedName

    /// <summary>
    /// This property associates a ship with the ammunition that it is equipped with.
    /// <see href="http://www.sealitproject.eu/ontology/has_ammunition"></see></summary>
    let has_ammunition =
        Namespaced_IRI.parse _namespace_name "has_ammunition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_ammunition_of"></see>
    /// </summary>
    let is_ammunition_of =
        Namespaced_IRI.parse _namespace_name "is_ammunition_of" |> NamespacedName

    /// <summary>
    /// This property associates an instance of a money for labour with an instance of a Labour Contract document that is agreed and planned for this payment.
    /// <see href="http://www.sealitproject.eu/ontology/has_been_agreed_in"></see></summary>
    let has_been_agreed_in =
        Namespaced_IRI.parse _namespace_name "has_been_agreed_in" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_agreement_for"></see>
    /// </summary>
    let is_agreement_for =
        Namespaced_IRI.parse _namespace_name "is_agreement_for" |> NamespacedName

    /// <summary>
    /// This property specifies the numbers of workers/sailors authorized to work on board.
    /// <see href="http://www.sealitproject.eu/ontology/has_crew_number_capacity"></see></summary>
    let has_crew_number_capacity =
        Namespaced_IRI.parse _namespace_name "has_crew_number_capacity" |> NamespacedName

    /// <summary>
    /// This property describes the current age of a person at a specific time (the time of the information recording).
    /// <see href="http://www.sealitproject.eu/ontology/has_current_age"></see></summary>
    let has_current_age =
        Namespaced_IRI.parse _namespace_name "has_current_age" |> NamespacedName

    /// <summary>
    /// This property allows an instance of Duration to be approximated by an instance of E60 Number primitive that provides the duration value of a time-span. The value can be expressed in multiple units (such as “2 months and 5 days” or “3 years and 10 months” ), thus it is proposed to be implemented in RDFS following ISO 8601 [2] and xsd:duration [3] (form: PnYnMnDTnHnMnS).
    /// <see href="http://www.sealitproject.eu/ontology/has_duration_value"></see></summary>
    let has_duration_value =
        Namespaced_IRI.parse _namespace_name "has_duration_value" |> NamespacedName

    /// <summary>
    /// This property associates an instance of E21 Person with an instance of E62 String used as the person’s first name. This property is an alternative (more convenient) implementation of P1 is identified by: E41 Appellation – P2 has type: “first name”; P190 has symbolic content: E62 String . The use of the P1 is identified by: E41 Appellation is required if there is the need to assign some additional properties to the first name, such as properties of use or attribution.
    /// <see href="http://www.sealitproject.eu/ontology/has_first_name"></see></summary>
    let has_first_name =
        Namespaced_IRI.parse _namespace_name "has_first_name" |> NamespacedName

    /// <summary>
    /// This property records the horsepower dimension of a ship.
    /// <see href="http://www.sealitproject.eu/ontology/has_horsepower"></see></summary>
    let has_horsepower =
        Namespaced_IRI.parse _namespace_name "has_horsepower" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_horsepower_of"></see>
    /// </summary>
    let is_horsepower_of =
        Namespaced_IRI.parse _namespace_name "is_horsepower_of" |> NamespacedName

    /// <summary>
    /// This property describes concepts that represent language capacity/knowledge that characterizes a E21 Person at a specific time period that is maybe unknown.
    /// <see href="http://www.sealitproject.eu/ontology/has_language_capacity"></see></summary>
    let has_language_capacity =
        Namespaced_IRI.parse _namespace_name "has_language_capacity" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_language_capacity_of"></see>
    /// </summary>
    let is_language_capacity_of =
        Namespaced_IRI.parse _namespace_name "is_language_capacity_of" |> NamespacedName

    /// <summary>
    /// This property associates an instance of E21 Person with an instance of E62 String used as the person’s last name. This property is an alternative (more convenient) implementation of P1 is identified by: E41 Appellation – P2 has type: “last name”; P190 has symbolic content: E62 String . The use of the P1 is identified by: E41 Appellation is required if there is the need to assign some additional properties to the last name, such as type, properties of use or attribution. In some countries (e.g., Spain), each person has two last names. In such cases, the value assigned to E62 String can contain both last names, if a clear distinction is not required.
    /// <see href="http://www.sealitproject.eu/ontology/has_last_name"></see></summary>
    let has_last_name =
        Namespaced_IRI.parse _namespace_name "has_last_name" |> NamespacedName

    /// <summary>
    /// This property describes the literacy status of a person at a specific time period that is maybe unknown.
    /// <see href="http://www.sealitproject.eu/ontology/has_literacy_status"></see></summary>
    let has_literacy_status =
        Namespaced_IRI.parse _namespace_name "has_literacy_status" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_literacy_status_of"></see>
    /// </summary>
    let is_literacy_status_of =
        Namespaced_IRI.parse _namespace_name "is_literacy_status_of" |> NamespacedName

    /// <summary>
    /// This property describes the navigation type of the ship. It allows a form of specialisation through the use of a terminological hierarchy, or thesaurus.
    /// <see href="http://www.sealitproject.eu/ontology/has_navigation_type"></see></summary>
    let has_navigation_type =
        Namespaced_IRI.parse _namespace_name "has_navigation_type" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_navigation_type_of"></see>
    /// </summary>
    let is_navigation_type_of =
        Namespaced_IRI.parse _namespace_name "is_navigation_type_of" |> NamespacedName

    /// <summary>
    /// This property describes information about the owner, the person or the company (shipping enterprise), of a ship. In the context of the SeaLiT project, we make the hypothesis that the owner as a concept, implies a legal entity, so in that sense, a person is the minimum legal entity-company (with members himself/herself) of a ship.
    /// <see href="http://www.sealitproject.eu/ontology/has_owner"></see></summary>
    let has_owner = Namespaced_IRI.parse _namespace_name "has_owner" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_owner_of_phase"></see>
    /// </summary>
    let is_owner_of_phase =
        Namespaced_IRI.parse _namespace_name "is_owner_of_phase" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/has_ownership_phase"></see>
    /// </summary>
    let has_ownership_phase =
        Namespaced_IRI.parse _namespace_name "has_ownership_phase" |> NamespacedName

    /// <summary>
    /// This property associates a ship with the different ownership phases related to it.
    /// <see href="http://www.sealitproject.eu/ontology/is_ownership_phase_of"></see></summary>
    let is_ownership_phase_of =
        Namespaced_IRI.parse _namespace_name "is_ownership_phase_of" |> NamespacedName

    /// <summary>
    /// This property associates a person with the profession, job or career that has been practicing at a specific time period that is maybe unknown. The evolution in the career/profession of a person is an important historical question; it implies the person development and evolution (microhistory) and consequently the population evolution (macrohistory).
    /// <see href="http://www.sealitproject.eu/ontology/has_profession"></see></summary>
    let has_profession =
        Namespaced_IRI.parse _namespace_name "has_profession" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/profession_of"></see>
    /// </summary>
    let profession_of =
        Namespaced_IRI.parse _namespace_name "profession_of" |> NamespacedName

    /// <summary>
    /// This property describes the religion status of a person at a specific time period that is maybe unknown.
    /// <see href="http://www.sealitproject.eu/ontology/has_religion_status"></see></summary>
    let has_religion_status =
        Namespaced_IRI.parse _namespace_name "has_religion_status" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_religion_status_of"></see>
    /// </summary>
    let is_religion_status_of =
        Namespaced_IRI.parse _namespace_name "is_religion_status_of" |> NamespacedName

    /// <summary>
    /// This property associates a person with the sex type that this person has at a specific time period that is maybe unknown.
    /// <see href="http://www.sealitproject.eu/ontology/has_sex_type"></see></summary>
    let has_sex_type =
        Namespaced_IRI.parse _namespace_name "has_sex_type" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_sex_type_of"></see>
    /// </summary>
    let is_sex_type_of =
        Namespaced_IRI.parse _namespace_name "is_sex_type_of" |> NamespacedName

    /// <summary>
    /// This property associates an actor with the activity of participating in an ownership with shares. It implies that a phase of a shareholding represents one participation of a share by an actor. This means that if for a ship there are more than one shareholders, there will be consequently same number of shareholding phases. If we want to describe the sum of the shares of the shareholding for a ship in a specific timespan, then we will describe a composite shareholding activity that consists of individual shareholding activities of shares.
    /// <see href="http://www.sealitproject.eu/ontology/has_shareholder"></see></summary>
    let has_shareholder =
        Namespaced_IRI.parse _namespace_name "has_shareholder" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/participates_with_share"></see>
    /// </summary>
    let participates_with_share =
        Namespaced_IRI.parse _namespace_name "participates_with_share" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/has_shareholding"></see>
    /// </summary>
    let has_shareholding =
        Namespaced_IRI.parse _namespace_name "has_shareholding" |> NamespacedName

    /// <summary>
    /// This property associates a shareholding phase to a particular ship.
    /// <see href="http://www.sealitproject.eu/ontology/is_shareholding_phase_of"></see></summary>
    let is_shareholding_phase_of =
        Namespaced_IRI.parse _namespace_name "is_shareholding_phase_of" |> NamespacedName

    /// <summary>
    /// This property describes the identification of a ship by an identifier. This property does not reveal anything about when, where and by whom this identifier was used. A more detailed representation can be made using the fully developed path through Ship Registration. The property is a shortcut for the path Ship – is registered by: Ship Registration – with ship ID: Ship ID .
    /// <see href="http://www.sealitproject.eu/ontology/has_ship_ID"></see></summary>
    let has_ship_ID =
        Namespaced_IRI.parse _namespace_name "has_ship_ID" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/ship_ID_identifies"></see>
    /// </summary>
    let ship_ID_identifies =
        Namespaced_IRI.parse _namespace_name "ship_ID_identifies" |> NamespacedName

    /// <summary>
    /// This property identifies the social status of a person at a specific time period that is maybe unknown.
    /// <see href="http://www.sealitproject.eu/ontology/has_social_status"></see></summary>
    let has_social_status =
        Namespaced_IRI.parse _namespace_name "has_social_status" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_social_status_of"></see>
    /// </summary>
    let is_social_status_of =
        Namespaced_IRI.parse _namespace_name "is_social_status_of" |> NamespacedName

    /// <summary>
    /// This property describes the subject of a teaching unit.
    /// <see href="http://www.sealitproject.eu/ontology/has_subject"></see></summary>
    let has_subject =
        Namespaced_IRI.parse _namespace_name "has_subject" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_subject_of"></see>
    /// </summary>
    let is_subject_of =
        Namespaced_IRI.parse _namespace_name "is_subject_of" |> NamespacedName

    /// <summary>
    /// This property provides the tonnage dimension of a ship.
    /// <see href="http://www.sealitproject.eu/ontology/has_tonnage"></see></summary>
    let has_tonnage =
        Namespaced_IRI.parse _namespace_name "has_tonnage" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_tonnage_of"></see>
    /// </summary>
    let is_tonnage_of =
        Namespaced_IRI.parse _namespace_name "is_tonnage_of" |> NamespacedName

    /// <summary>
    /// This property describes the inferred time-span of a legal object relationship, which cannot be observed or documented. It is implicit knowledge.
    /// <see href="http://www.sealitproject.eu/ontology/in_time"></see></summary>
    let in_time = Namespaced_IRI.parse _namespace_name "in_time" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_time_of"></see>
    /// </summary>
    let is_time_of = Namespaced_IRI.parse _namespace_name "is_time_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/initializes"></see>
    /// </summary>
    let initializes =
        Namespaced_IRI.parse _namespace_name "initializes" |> NamespacedName

    /// <summary>
    /// This property associates the beginning of an instance of Legal Object Relationship with an explicit event initiating it.
    /// <see href="http://www.sealitproject.eu/ontology/is_initialized_by"></see></summary>
    let is_initialized_by =
        Namespaced_IRI.parse _namespace_name "is_initialized_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/initializes_ownership"></see>
    /// </summary>
    let initializes_ownership =
        Namespaced_IRI.parse _namespace_name "initializes_ownership" |> NamespacedName

    /// <summary>
    /// This property associates the beginning of an instance of Ship Ownership Phase with the Ship Registration that initiates it.
    /// <see href="http://www.sealitproject.eu/ontology/ownership_is_initialized_by"></see></summary>
    let ownership_is_initialized_by =
        Namespaced_IRI.parse _namespace_name "ownership_is_initialized_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_flag_of"></see>
    /// </summary>
    let is_flag_of = Namespaced_IRI.parse _namespace_name "is_flag_of" |> NamespacedName

    /// <summary>
    /// This property identifies the country represented in the ship flag of a Ship Registration activity.
    /// <see href="http://www.sealitproject.eu/ontology/with_ship_flag_of"></see></summary>
    let with_ship_flag_of =
        Namespaced_IRI.parse _namespace_name "with_ship_flag_of" |> NamespacedName

    /// <summary>
    /// This property associates a punishment to the actor that received the punishment.
    /// <see href="http://www.sealitproject.eu/ontology/is_given_to"></see></summary>
    let is_given_to =
        Namespaced_IRI.parse _namespace_name "is_given_to" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/was_punished_by"></see>
    /// </summary>
    let was_punished_by =
        Namespaced_IRI.parse _namespace_name "was_punished_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_place_of_passing_through"></see>
    /// </summary>
    let is_place_of_passing_through =
        Namespaced_IRI.parse _namespace_name "is_place_of_passing_through" |> NamespacedName

    /// <summary>
    /// This property associates an instance of a place with an instance of a passing activity through that place. This class provides information about the types of movements of a ship, which are parts of the route (of the voyage), and are documented as that.
    /// <see href="http://www.sealitproject.eu/ontology/through_place"></see></summary>
    let through_place =
        Namespaced_IRI.parse _namespace_name "through_place" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_registered_by"></see>
    /// </summary>
    let is_registered_by =
        Namespaced_IRI.parse _namespace_name "is_registered_by" |> NamespacedName

    /// <summary>
    /// This property associates a ship and the ship registration activity that registered and identified it.
    /// <see href="http://www.sealitproject.eu/ontology/registers"></see></summary>
    let registers = Namespaced_IRI.parse _namespace_name "registers" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_responsible_for_registration"></see>
    /// </summary>
    let is_responsible_for_registration =
        Namespaced_IRI.parse _namespace_name "is_responsible_for_registration" |> NamespacedName

    /// <summary>
    /// This property describes the authority, the port of registry, which is responsible for the registration of a ship.
    /// <see href="http://www.sealitproject.eu/ontology/registered_by"></see></summary>
    let registered_by =
        Namespaced_IRI.parse _namespace_name "registered_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_starting_place_of"></see>
    /// </summary>
    let is_starting_place_of =
        Namespaced_IRI.parse _namespace_name "is_starting_place_of" |> NamespacedName

    /// <summary>
    /// This property describes the spatial location from which a voyage started. It is the beginning of the route.
    /// <see href="http://www.sealitproject.eu/ontology/starting_from"></see></summary>
    let starting_from =
        Namespaced_IRI.parse _namespace_name "starting_from" |> NamespacedName

    /// <summary>
    /// This property associates the end of existence of an instance of Legal Object Relationship with an explicit event that terminates it.
    /// <see href="http://www.sealitproject.eu/ontology/is_terminated_by"></see></summary>
    let is_terminated_by =
        Namespaced_IRI.parse _namespace_name "is_terminated_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/terminates"></see>
    /// </summary>
    let terminates = Namespaced_IRI.parse _namespace_name "terminates" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_working_place_of"></see>
    /// </summary>
    let is_working_place_of =
        Namespaced_IRI.parse _namespace_name "is_working_place_of" |> NamespacedName

    /// <summary>
    /// This property identifies the workplace, meaning the organisation/company in which a person works at. The in the role of property of the property allows specifying the nature, the role of an actor’s work in the organisation/company.
    /// <see href="http://www.sealitproject.eu/ontology/works_at"></see></summary>
    let works_at = Namespaced_IRI.parse _namespace_name "works_at" |> NamespacedName
    /// <summary>
    /// This property associates an instance E18 Physical Thing with an instance of the loading activity that moved (loaded) it.
    /// <see href="http://www.sealitproject.eu/ontology/loaded"></see></summary>
    let loaded = Namespaced_IRI.parse _namespace_name "loaded" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/was_loaded_by"></see>
    /// </summary>
    let was_loaded_by =
        Namespaced_IRI.parse _namespace_name "was_loaded_by" |> NamespacedName

    /// <summary>
    /// This property identifies the E39 Actor that paid (gave money) for a specific service (Money For Service).
    /// <see href="http://www.sealitproject.eu/ontology/money_provided_by"></see></summary>
    let money_provided_by =
        Namespaced_IRI.parse _namespace_name "money_provided_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/provided_money"></see>
    /// </summary>
    let provided_money =
        Namespaced_IRI.parse _namespace_name "provided_money" |> NamespacedName

    /// <summary>
    /// This property identifies the E39 Actor that received money for a specific service (Money For Service).
    /// <see href="http://www.sealitproject.eu/ontology/money_provided_to"></see></summary>
    let money_provided_to =
        Namespaced_IRI.parse _namespace_name "money_provided_to" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/received_money"></see>
    /// </summary>
    let received_money =
        Namespaced_IRI.parse _namespace_name "received_money" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/name_with_ownership"></see>
    /// </summary>
    let name_with_ownership =
        Namespaced_IRI.parse _namespace_name "name_with_ownership" |> NamespacedName

    /// <summary>
    /// This property identifies the change of ship name because of an ownership phase. It can be used to provide previous/old names of a ship.
    /// <see href="http://www.sealitproject.eu/ontology/ownership_under_name"></see></summary>
    let ownership_under_name =
        Namespaced_IRI.parse _namespace_name "ownership_under_name" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/named_with"></see>
    /// </summary>
    let named_with = Namespaced_IRI.parse _namespace_name "named_with" |> NamespacedName
    /// <summary>
    /// This property identifies the name of the ship with the ship construction information.
    /// <see href="http://www.sealitproject.eu/ontology/under_name"></see></summary>
    let under_name = Namespaced_IRI.parse _namespace_name "under_name" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/navigated"></see>
    /// </summary>
    let navigated = Namespaced_IRI.parse _namespace_name "navigated" |> NamespacedName

    /// <summary>
    /// This property describes the participation of an E39 Actor as being responsible for the navigation of the voyage. The captain may change from voyage to voyage. The concept of the captain is normally synonym to the concept of ruling, of the power of governing, so in that sense should be mapped to the E74 Group. But, in the context of the SeaLiT project, there is the requirement for a simpler structure with more details on the biographic data of a captain, so the decision is to model the captain as a role by person (not by group).
    /// <see href="http://www.sealitproject.eu/ontology/navigated_by_captain"></see></summary>
    let navigated_by_captain =
        Namespaced_IRI.parse _namespace_name "navigated_by_captain" |> NamespacedName

    /// <summary>
    /// This property describes the number of shares hold by an owner.
    /// <see href="http://www.sealitproject.eu/ontology/of_share"></see></summary>
    let of_share = Namespaced_IRI.parse _namespace_name "of_share" |> NamespacedName

    /// <summary>
    /// This property associates the end of existence of an instance of Ship Ownership Phase with a De-flagging event that terminates it.
    /// <see href="http://www.sealitproject.eu/ontology/ownership_is_terminated_by"></see></summary>
    let ownership_is_terminated_by =
        Namespaced_IRI.parse _namespace_name "ownership_is_terminated_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/terminates_ownership"></see>
    /// </summary>
    let terminates_ownership =
        Namespaced_IRI.parse _namespace_name "terminates_ownership" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/person_is_registered_by"></see>
    /// </summary>
    let person_is_registered_by =
        Namespaced_IRI.parse _namespace_name "person_is_registered_by" |> NamespacedName

    /// <summary>
    /// This property describes a person that is registered by a civil registration activity.
    /// <see href="http://www.sealitproject.eu/ontology/registers_person"></see></summary>
    let registers_person =
        Namespaced_IRI.parse _namespace_name "registers_person" |> NamespacedName

    /// <summary>
    /// This property records the social status type that was promoted by a promotion activity. In that sense, we regard that a promotion can be related to a social status promotion or to a job/career promotion.
    /// <see href="http://www.sealitproject.eu/ontology/promoted_into_status_type"></see></summary>
    let promoted_into_status_type =
        Namespaced_IRI.parse _namespace_name "promoted_into_status_type" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/status_type_was_promoted_by"></see>
    /// </summary>
    let status_type_was_promoted_by =
        Namespaced_IRI.parse _namespace_name "status_type_was_promoted_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/provided_service"></see>
    /// </summary>
    let provided_service =
        Namespaced_IRI.parse _namespace_name "provided_service" |> NamespacedName

    /// <summary>
    /// This property describes the existence of a relation between persons, without the need to also specify the kind of relation. It is used in cases in which the types of the possible relationships between persons are many and not defined by the model, or in cases in which there is lack of knowledge about the kind of the relationships and there is only a requirement to mark just the existence of a link between persons. The property of property has type: E55 Type can be used to specify the type of relation, e.g., by linking to a vocabulary or thesaurus.
    /// <see href="http://www.sealitproject.eu/ontology/related_to"></see></summary>
    let related_to = Namespaced_IRI.parse _namespace_name "related_to" |> NamespacedName
    /// <summary>
    /// This property identifies a ship repaired by a ship repair activity.
    /// <see href="http://www.sealitproject.eu/ontology/repaired"></see></summary>
    let repaired = Namespaced_IRI.parse _namespace_name "repaired" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/was_repaired_by"></see>
    /// </summary>
    let was_repaired_by =
        Namespaced_IRI.parse _namespace_name "was_repaired_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/ship_ID_of"></see>
    /// </summary>
    let ship_ID_of = Namespaced_IRI.parse _namespace_name "ship_ID_of" |> NamespacedName

    /// <summary>
    /// This property records the ship identifier assigned by a Ship Registration activity.
    /// <see href="http://www.sealitproject.eu/ontology/with_ship_ID"></see></summary>
    let with_ship_ID =
        Namespaced_IRI.parse _namespace_name "with_ship_ID" |> NamespacedName

    /// <summary>
    /// This property describes an employment that was started by a recruitment activity.
    /// <see href="http://www.sealitproject.eu/ontology/started"></see></summary>
    let started = Namespaced_IRI.parse _namespace_name "started" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/started_by"></see>
    /// </summary>
    let started_by = Namespaced_IRI.parse _namespace_name "started_by" |> NamespacedName
    /// <summary>
    /// This property associates an instance of E18 Physical Thing with an instance of the unloading activity that moved (unloaded) it.
    /// <see href="http://www.sealitproject.eu/ontology/unloaded"></see></summary>
    let unloaded = Namespaced_IRI.parse _namespace_name "unloaded" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/was_unloaded_by"></see>
    /// </summary>
    let was_unloaded_by =
        Namespaced_IRI.parse _namespace_name "was_unloaded_by" |> NamespacedName

    /// <summary>
    /// This property describes the voyage of a ship, its movement/travelling at sea.
    /// <see href="http://www.sealitproject.eu/ontology/voyage_of"></see></summary>
    let voyage_of = Namespaced_IRI.parse _namespace_name "voyage_of" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/voyages"></see>
    /// </summary>
    let voyages = Namespaced_IRI.parse _namespace_name "voyages" |> NamespacedName

    /// <summary>
    /// This property identifies the E39 Actor that participated in the transaction (Money for Service activity) in the role of a mediator. For example, there are sources that refer that seamen used to provide money to the captain of the ship in order that the wives to receive these money (so the captain was the mediator of this transaction).
    /// <see href="http://www.sealitproject.eu/ontology/was_mediated_by"></see></summary>
    let was_mediated_by =
        Namespaced_IRI.parse _namespace_name "was_mediated_by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/was_mediator_of"></see>
    /// </summary>
    let was_mediator_of =
        Namespaced_IRI.parse _namespace_name "was_mediator_of" |> NamespacedName

    /// <summary>
    /// This property describes the number of the students participating in a teaching unit.
    /// <see href="http://www.sealitproject.eu/ontology/with_number_of_students"></see></summary>
    let with_number_of_students =
        Namespaced_IRI.parse _namespace_name "with_number_of_students" |> NamespacedName
