namespace http.www.sealitproject.eu.ontology.slash

open DoxAletheia

module sealit =
    let _namespace_name = "http://www.sealitproject.eu/ontology/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// This class comprises information about the kinds and the number of guns of the ship at the moment of registration. The current documentation is mostly about merchant ships. With the beginning of the Greek Revolution in 1821, the Greek merchant fleet was transformed to military – consequently, there are also references to vessels that have ammunition during that period.
    /// <see href="http://www.sealitproject.eu/ontology/Ammunition"></see></summary>
    let Ammunition = _prefix "Ammunition"
    /// <summary>
    /// This class comprises the arrival activity of a ship, which is a part, a stage of the overall voyage. It includes information about a place where the ship lands within a specific timeframe. It describes end points of the partial routes or within the overall voyage.
    /// <see href="http://www.sealitproject.eu/ontology/Arrival"></see></summary>
    let Arrival = _prefix "Arrival"
    /// <summary>
    /// Civil registration stands for legal processes of registering persons in various contexts. The outcomes of this process are legal documents such as civil acts of birth or death, or other documents (such as Register of Entries in shipyards), which usually have a period of validity.
    /// <see href="http://www.sealitproject.eu/ontology/Civil_Registration"></see></summary>
    let Civil_Registration = _prefix "Civil_Registration"
    /// <summary>
    /// This class describes the country, a place identified as a distinct entity in political geography.
    /// <see href="http://www.sealitproject.eu/ontology/Country"></see></summary>
    let Country = _prefix "Country"
    /// <summary>
    /// This class comprises information about courses, teaching units divided and organized for educational purposes.
    /// <see href="http://www.sealitproject.eu/ontology/Course"></see></summary>
    let Course = _prefix "Course"
    /// <summary>
    /// This class comprises information about the school year, the period of time during which the school holds classes and offers courses. It is a period of educational activities.
    /// <see href="http://www.sealitproject.eu/ontology/Teaching_Unit"></see></summary>
    let Teaching_Unit = _prefix "Teaching_Unit"
    /// <summary>
    /// This class comprises information about the wage payments of the people that are members of the crew of a ship.
    /// <see href="http://www.sealitproject.eu/ontology/Crew_Payment"></see></summary>
    let Crew_Payment = _prefix "Crew_Payment"
    /// <summary>
    /// This class comprises activities in which actors pay/receive money for services related to labour, human work, in order to earn wage.
    /// <see href="http://www.sealitproject.eu/ontology/Money_for_Labour"></see></summary>
    let Money_for_Labour = _prefix "Money_for_Labour"
    /// <summary>
    /// De-flagging is regarded in this context as synonym to ship de-registration. When a ship is no longer flagged, this means that for a reason (e.g., demolished, shipwreck, lost, sold, etc.) the ship does not anymore sail under a legal state (of registration, having a flag).
    /// <see href="http://www.sealitproject.eu/ontology/De-flagging"></see></summary>
    let ``De-flagging`` = _prefix "De-flagging"
    /// <summary>
    /// This class comprises the termination of a working relationship, the ending of an employee to provide service. In the context of the SeaLiT project, which explores data regarding employments records with lists of maritime personnel, a discharge is specifically defined in the sense of disembarkation, which is the activity that usually terminates a sailor’s employment service.
    /// <see href="http://www.sealitproject.eu/ontology/Discharge"></see></summary>
    let Discharge = _prefix "Discharge"
    /// <summary>
    /// This class expresses the length of time in terms of indeterminacy of the duration value that can be approximated. A duration may be expressed using all the parts of a date-time (from years to seconds) and can therefore be defined as a six-dimensional space. Because the relation between some of date parts is not fixed (such as the number of days in a month), the order relationship between durations is only partial, and the result of a comparison between two durations may be undetermined. The same value may consists of different parts, such as 4 years, 10 months and 2 days.
    /// <see href="http://www.sealitproject.eu/ontology/Duration"></see></summary>
    let Duration = _prefix "Duration"
    /// <summary>
    /// This class comprises information about employment services between two parties, usually based on a contract where work is paid for. In the context of the SeaLiT project, it comprises information about the employment services provided on board. This relationship is initiated by the recruitment of the sailor man and is terminated by the discharge/disembarkation of this worker.
    /// <see href="http://www.sealitproject.eu/ontology/Employment"></see></summary>
    let Employment = _prefix "Employment"
    /// <summary>
    /// Service is the willing, the capability to offer a service, by some instance of E39 Actor, independently if it is executed or not. This offer is declared at the request of another instance of E39 Actor.
    /// <see href="http://www.sealitproject.eu/ontology/Service"></see></summary>
    let Service = _prefix "Service"
    /// <summary>
    /// The power of the ship’s marine propulsion engine. The overall operation of the ship is highly dependent on the performance of its main propulsion engine, measured in terms of its power rating. There are various types of horsepower such as Nominal horsepower (NHP), Shaft horsepower (SHP), Indicated horsepower (IHP).
    /// <see href="http://www.sealitproject.eu/ontology/Horsepower"></see></summary>
    let Horsepower = _prefix "Horsepower"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/ID_of"></see>
    /// </summary>
    let ID_of = _prefix "ID_of"
    /// <summary>
    /// This property records the identifier that was assigned to a person in a Civil Registration activity.
    /// <see href="http://www.sealitproject.eu/ontology/with_ID"></see></summary>
    let with_ID = _prefix "with_ID"
    /// <summary>
    /// This class comprises plans expressed in a document that specifies the employment conditions.
    /// <see href="http://www.sealitproject.eu/ontology/Labour_Contract"></see></summary>
    let Labour_Contract = _prefix "Labour_Contract"
    /// <summary>
    /// This class comprises concepts denoting a person knowledge of various languages.
    /// <see href="http://www.sealitproject.eu/ontology/Language_Capacity"></see></summary>
    let Language_Capacity = _prefix "Language_Capacity"
    /// <summary>
    /// This class comprises the leaving of a ship, which is a part, a stage of the overall voyage. It includes information about a place from which the ship leaves within a specific timeframe. It describes start points of the partial routes or with the overall voyage.
    /// <see href="http://www.sealitproject.eu/ontology/Leaving"></see></summary>
    let Leaving = _prefix "Leaving"

    /// <summary>
    /// This class comprises official documents or legal agreements that are valid for a specific timespan. The concept of this class includes licenses, official permissions, authorizations, etc., having a temporal validity.
    /// <see href="http://www.sealitproject.eu/ontology/Legal_Document_with_Temporal_Validity"></see></summary>
    let Legal_Document_with_Temporal_Validity =
        _prefix "Legal_Document_with_Temporal_Validity"

    /// <summary>
    /// This class comprises legal object relationships of which the timespan and the state (of these relationships) cannot be observed or documented. We can only observe these relationships through the events that initialize or terminate this state of relationship (starting event and terminating event). Basically, it comprises of characteristics/properties of a legal relationship which is the kind of information that can be inferred/asserted and not by temporal documentation of these properties.
    /// <see href="http://www.sealitproject.eu/ontology/Legal_Object_Relationship"></see></summary>
    let Legal_Object_Relationship = _prefix "Legal_Object_Relationship"
    /// <summary>
    /// This class comprises concepts denoting a person’s literacy status.
    /// <see href="http://www.sealitproject.eu/ontology/Literacy_Status"></see></summary>
    let Literacy_Status = _prefix "Literacy_Status"
    /// <summary>
    /// This class comprises loading activities as they are documented during the voyages (or as parts of the routes) of the ships. It seems that the definition of a ship includes the notion of the loading of things; the procedures of loading/unloading are very important; the types of ships, the ports and the routes seem to define the types of loading, the dimensions, and the technology of loading/unloading and storage in ships.
    /// <see href="http://www.sealitproject.eu/ontology/Loading"></see></summary>
    let Loading = _prefix "Loading"
    /// <summary>
    /// This class comprises transaction activities in which actors pay/receive money for services.
    /// <see href="http://www.sealitproject.eu/ontology/Money_for_Service"></see></summary>
    let Money_for_Service = _prefix "Money_for_Service"
    /// <summary>
    /// This class comprises transaction activities in which actors pay/receive money for services related to things, such as purchase of foods, etc.
    /// <see href="http://www.sealitproject.eu/ontology/Money_for_Things"></see></summary>
    let Money_for_Things = _prefix "Money_for_Things"
    /// <summary>
    /// This class comprises concepts denoted by terms used to characterize and classify a ship, in particular its navigation type, based on the long or short distances of travel.
    /// <see href="http://www.sealitproject.eu/ontology/Navigation_Type"></see></summary>
    let Navigation_Type = _prefix "Navigation_Type"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/PC_has_type"></see>
    /// </summary>
    let PC_has_type = _prefix "PC_has_type"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/PC_related_to"></see>
    /// </summary>
    let PC_related_to = _prefix "PC_related_to"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/PC_provided_service"></see>
    /// </summary>
    let PC_provided_service = _prefix "PC_provided_service"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/PC_student_in"></see>
    /// </summary>
    let PC_student_in = _prefix "PC_student_in"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/PC_with_status_of_participation"></see>
    /// </summary>
    let PC_with_status_of_participation = _prefix "PC_with_status_of_participation"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/PC_works_at"></see>
    /// </summary>
    let PC_works_at = _prefix "PC_works_at"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/PCa_in_the_role_of"></see>
    /// </summary>
    let PCa_in_the_role_of = _prefix "PCa_in_the_role_of"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/PCb_in_the_role_of"></see>
    /// </summary>
    let PCb_in_the_role_of = _prefix "PCb_in_the_role_of"
    /// <summary>
    /// This class comprises passing by (or through) activities of a ship at sea. This information helps to track the ships and the routes. Passing by or through is a part of the overall voyage. It includes information about places by/through which the ship passes within a specific timeframe.
    /// <see href="http://www.sealitproject.eu/ontology/Passing"></see></summary>
    let Passing = _prefix "Passing"
    /// <summary>
    /// This class describes the port (the issuing authority) that is responsible for a vessel registration.
    /// <see href="http://www.sealitproject.eu/ontology/Port_of_Registry"></see></summary>
    let Port_of_Registry = _prefix "Port_of_Registry"
    /// <summary>
    /// This class comprises information about the person profession, work, career or job, as it was written inside the original source.
    /// <see href="http://www.sealitproject.eu/ontology/Profession"></see></summary>
    let Profession = _prefix "Profession"
    /// <summary>
    /// This class comprises activities that result in the promotion, the advancement of an employee within a company position or job tasks or in a higher ranking as a reward for good performance. It is typically associated with a higher rate or a financial bonus.
    /// <see href="http://www.sealitproject.eu/ontology/Promotion"></see></summary>
    let Promotion = _prefix "Promotion"
    /// <summary>
    /// This class comprises instances of punishments in terms of public policy, defined by an authority, as a response to a particular action that is deemed undesirable or unacceptable. Examples of penalties for punishment are prison, or loss of a privilege or of a status, etc.
    /// <see href="http://www.sealitproject.eu/ontology/Punishment"></see></summary>
    let Punishment = _prefix "Punishment"
    /// <summary>
    /// This class comprises the process of hiring and bringing new staff member to work for a company, or to become a new member of an organization. In the context of the SeaLiT project, which explores data regarding employments records with lists of maritime personnel, a recruitment is specifically defined in the sense of on board employment. Recruitment or embarkation is the activity that usually starts a sailor’s employment service. There is information from sources, such as from the Maritime Register of the State for La Ciotat (matricule des maîtres au cabotage) , referring that they used to have “recruitment” systems that registered every man 18 years old and up, or a younger boy (as apprentice), exercising one of the maritime professions for over a year, at the Navy’s disposal, in case of a war. On the same time, the state provided many privileges in return for service in the navy, such as tax exemptions, military pensions, free education and life insurance for the families of listed seamen.
    /// <see href="http://www.sealitproject.eu/ontology/Recruitment"></see></summary>
    let Recruitment = _prefix "Recruitment"
    /// <summary>
    /// This class comprises concepts used to characterize the religious affiliation of a person.
    /// <see href="http://www.sealitproject.eu/ontology/Religion_Status"></see></summary>
    let Religion_Status = _prefix "Religion_Status"
    /// <summary>
    /// This class comprises information about sections of lessons. Some courses are divided into multiple sections.
    /// <see href="http://www.sealitproject.eu/ontology/Section"></see></summary>
    let Section = _prefix "Section"
    /// <summary>
    /// The gender of a person.
    /// <see href="http://www.sealitproject.eu/ontology/Sex_Type"></see></summary>
    let Sex_Type = _prefix "Sex_Type"
    /// <summary>
    /// This class describes the common phenomenon through periods in which ships share ownership. Therefore, if for example a person is allowed to possess up to 1/48 of a ship, it means that a single person could have many ships shares in the same time. Sometimes the leading owner has the absolute majority of the shares, sometimes only the relative majority; these are just assumptions/examples that this class can describe.
    /// <see href="http://www.sealitproject.eu/ontology/Shareholding"></see></summary>
    let Shareholding = _prefix "Shareholding"
    /// <summary>
    /// This class comprises information about the ownership state of a ship. It consists of characteristics or properties of ownership. Ownership is a legal agreement, a kind of information that can be inferred/asserted and cannot be directly observed. Ownership usually characterizes/assigns a name to a ship and a ship changes its name under an ownership state. Ownership phase can be traced by the ship registration activity that initiates it, and by the de-flagging activity that terminates the phase. A single ship can have many owners (persons or/and companies).
    /// <see href="http://www.sealitproject.eu/ontology/Ship_Ownership_Phase"></see></summary>
    let Ship_Ownership_Phase = _prefix "Ship_Ownership_Phase"
    /// <summary>
    /// This class comprises vessels, ships of different kinds, which can cross large open waters. Ships have been important contributors to human migration and commerce.
    /// <see href="http://www.sealitproject.eu/ontology/Ship"></see></summary>
    let Ship = _prefix "Ship"
    /// <summary>
    /// This class describes the activity of building new ships and other floating vessels. The ship construction information, in particular the location and date of construction, is the most reliable information (extracted from the source) that helps to identify a ship. A very important methodological question is what information can be used to define the unique identity of a ship. The answer is that there does not exist a single information that can define it: it is always a matter of comparison of the sources and information. Even though, there is information that is critical to the identity of a ship, such as the place and the year of construction.
    /// <see href="http://www.sealitproject.eu/ontology/Ship_Construction"></see></summary>
    let Ship_Construction = _prefix "Ship_Construction"
    /// <summary>
    /// This class comprises numeric information assigned as registration number of a ship.
    /// <see href="http://www.sealitproject.eu/ontology/Ship_ID"></see></summary>
    let Ship_ID = _prefix "Ship_ID"
    /// <summary>
    /// This class comprises the name that identifies a ship. The name of the ship can be changed because of an ownership (so a ship can have many names through time).
    /// <see href="http://www.sealitproject.eu/ontology/Ship_Name"></see></summary>
    let Ship_Name = _prefix "Ship_Name"
    /// <summary>
    /// A ship acquires legal identity with the process of its registration, the register of its name, flag, id, dimensions and horsepower. The ownership information is documented in the registry book signed by the Port of Registry.
    /// <see href="http://www.sealitproject.eu/ontology/Ship_Registration"></see></summary>
    let Ship_Registration = _prefix "Ship_Registration"
    /// <summary>
    /// This class comprises activities that alter or change or restore/repair a ship.
    /// <see href="http://www.sealitproject.eu/ontology/Ship_Repair"></see></summary>
    let Ship_Repair = _prefix "Ship_Repair"
    /// <summary>
    /// This class comprises a person’s social status, as it was written inside the original source. This can include different kinds of social status, such as marital status or estate. In such cases of further classification, these concepts can be used as instances of the Social Status class. This class extends E55 Type in order to refine the meaning of this specific concept (social status). This concept is sufficiently stable and associated with additional explicitly modelled property specific to it ( “has social status” ). An alternative mechanism is to specialize the classification of Social Status instances to any level of detail, by linking to external vocabulary sources, thesauri, classification schemas or ontologies. In general, a good practice for concepts that are not user defined metaclasses, would be to be treated as particulars with the relationship P2 has type.
    /// <see href="http://www.sealitproject.eu/ontology/Social_Status"></see></summary>
    let Social_Status = _prefix "Social_Status"
    /// <summary>
    /// This class comprises information about the scientific subjects of the courses that were taught at a specific semester.
    /// <see href="http://www.sealitproject.eu/ontology/Subject"></see></summary>
    let Subject = _prefix "Subject"
    /// <summary>
    /// Tonnage is a measure of the cargo-carrying capacity of a ship. The sources refer to different kinds of tonnage, such as gross tonnage, net tonnage, etc. and through time, tonnage types may change. Tonnage may change during a reconstruction phase of a ship, for example.
    /// <see href="http://www.sealitproject.eu/ontology/Tonnage"></see></summary>
    let Tonnage = _prefix "Tonnage"
    /// <summary>
    /// This class comprises unloading activities as they are documented during the voyages (or as parts of the routes) of the ships. The procedures of loading/unloading are very important; the types of ships, the ports and the routes seem to define the types of loading, the dimensions, and the technology of loading/unloading and storage in ships.
    /// <see href="http://www.sealitproject.eu/ontology/Unloading"></see></summary>
    let Unloading = _prefix "Unloading"
    /// <summary>
    /// This class comprises information about the voyages of ships. Voyage is defined as the process of travelling from one place to another, staying there, usually for a short time; it is not a simple move/change from place to place; it is a movement in space and time (and it is documented as that [1] ). The same ship can sail many voyages during its lifetime. Voyage and route information is very important for historically investigating the various trade routes and navigation patterns used to exist in different times. Voyage is an important aspect of the ship and the seaman, and generally of the seafaring life, both at sea and ashore .
    /// <see href="http://www.sealitproject.eu/ontology/Voyage"></see></summary>
    let Voyage = _prefix "Voyage"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/arrival_is_part_of"></see>
    /// </summary>
    let arrival_is_part_of = _prefix "arrival_is_part_of"
    /// <summary>
    /// This property allows an instance of a Voyage to be analysed into parts such as arrival activities. It is a subproperty of P9 consists of (forms part of). This analysis of parts of the voyage contributes to the route analysis, which provides information about specific navigation patterns of the ship.
    /// <see href="http://www.sealitproject.eu/ontology/consists_of_arrival"></see></summary>
    let consists_of_arrival = _prefix "consists_of_arrival"
    /// <summary>
    /// This property describes the spatial location of an arrival.
    /// <see href="http://www.sealitproject.eu/ontology/at_place"></see></summary>
    let at_place = _prefix "at_place"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_place_of_arrival"></see>
    /// </summary>
    let is_place_of_arrival = _prefix "is_place_of_arrival"
    /// <summary>
    /// This property associates an instance of a place with an instance of a passing activity by that place. This class provides information about the types of movements of a ship, which are parts of the route (of the voyage), and are documented as that.
    /// <see href="http://www.sealitproject.eu/ontology/by_place"></see></summary>
    let by_place = _prefix "by_place"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_place_of_passing_by"></see>
    /// </summary>
    let is_place_of_passing_by = _prefix "is_place_of_passing_by"
    /// <summary>
    /// This property identifies the person that was promoted by a promotion activity.
    /// <see href="http://www.sealitproject.eu/ontology/concerned"></see></summary>
    let concerned = _prefix "concerned"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/was_promoted_by"></see>
    /// </summary>
    let was_promoted_by = _prefix "was_promoted_by"
    /// <summary>
    /// This property allows an instance of a Voyage to be analysed into parts such as leaving activities. It is a subproperty of P9 consists of (forms part of). This analysis of parts of the voyage contributes to the route analysis, which provides information about specific navigation patterns of the ship.
    /// <see href="http://www.sealitproject.eu/ontology/consists_of_leaving"></see></summary>
    let consists_of_leaving = _prefix "consists_of_leaving"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/leaving_is_part_of"></see>
    /// </summary>
    let leaving_is_part_of = _prefix "leaving_is_part_of"
    /// <summary>
    /// This property allows an instance of a Voyage to be analysed into parts such as loading activities. It is a subproperty of P9 consists of (forms part of). The activities of loading/unloading happen ashore, before, in between, or after (with the end) of the voyage of a ship and are part of its definition.
    /// <see href="http://www.sealitproject.eu/ontology/consists_of_loading"></see></summary>
    let consists_of_loading = _prefix "consists_of_loading"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/loading_is_part_of"></see>
    /// </summary>
    let loading_is_part_of = _prefix "loading_is_part_of"
    /// <summary>
    /// This property allows an instance of a Voyage to be analysed into parts such as passing by/through activities. It is a subproperty of P9 consists of (forms part of). This analysis of parts of the voyage contributes to the route analysis, which provides information about specific navigation patterns of the ship
    /// <see href="http://www.sealitproject.eu/ontology/consists_of_passing"></see></summary>
    let consists_of_passing = _prefix "consists_of_passing"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/passing_is_part_of"></see>
    /// </summary>
    let passing_is_part_of = _prefix "passing_is_part_of"
    /// <summary>
    /// This property allows an instance of a Voyage to be analysed into parts such as unloading activities. It is a subproperty of P9 consists of (forms part of). The activities of loading/unloading happen ashore, before, in between, or after (with the end) of the voyage of a ship and are part of its definition.
    /// <see href="http://www.sealitproject.eu/ontology/consists_of_unloading"></see></summary>
    let consists_of_unloading = _prefix "consists_of_unloading"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/unloading_is_part_of"></see>
    /// </summary>
    let unloading_is_part_of = _prefix "unloading_is_part_of"
    /// <summary>
    /// This property identifies a ship that came into existence as a result of a construction event.
    /// <see href="http://www.sealitproject.eu/ontology/constructed"></see></summary>
    let constructed = _prefix "constructed"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/was_constructed_by"></see>
    /// </summary>
    let was_constructed_by = _prefix "was_constructed_by"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/de-flagged_in"></see>
    /// </summary>
    let ``de-flagged_in`` = _prefix "de-flagged_in"
    /// <summary>
    /// This property associates an instance of a ship with the instance of the de-flagging activity that de-registered it.
    /// <see href="http://www.sealitproject.eu/ontology/de-flagging_of"></see></summary>
    let ``de-flagging_of`` = _prefix "de-flagging_of"
    /// <summary>
    /// This property describes the intended place where the voyage, theoretically, according to the maps and the plans should end. It is the planned destination of the route, which may change in reality.
    /// <see href="http://www.sealitproject.eu/ontology/destination"></see></summary>
    let destination = _prefix "destination"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_destination_of"></see>
    /// </summary>
    let is_destination_of = _prefix "is_destination_of"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/duration_of"></see>
    /// </summary>
    let duration_of = _prefix "duration_of"
    /// <summary>
    /// This property describes the length of time covered by an E52 Time-Span. It allows an E52 Time-Span to be associated with a duration (as a dimension, an interval) independent from the actual beginning and end.
    /// <see href="http://www.sealitproject.eu/ontology/had_duration"></see></summary>
    let had_duration = _prefix "had_duration"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/employment_of"></see>
    /// </summary>
    let employment_of = _prefix "employment_of"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/service_of"></see>
    /// </summary>
    let service_of = _prefix "service_of"
    /// <summary>
    /// This property associates an instance of a payment with an instance of an employment that was used in order to specify rights and responsibilities between the “employee” and the “employer”.
    /// <see href="http://www.sealitproject.eu/ontology/for_employment"></see></summary>
    let for_employment = _prefix "for_employment"

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/employment_position_type_was_promoted_by"></see>
    /// </summary>
    let employment_position_type_was_promoted_by =
        _prefix "employment_position_type_was_promoted_by"

    /// <summary>
    /// This property records the employment (job) position type that was promoted by a promotion activity. In that sense, we regard that a promotion can be related to a social status promotion or to a job/career promotion.
    /// <see href="http://www.sealitproject.eu/ontology/promoted_into_employment_position_type"></see></summary>
    let promoted_into_employment_position_type =
        _prefix "promoted_into_employment_position_type"

    /// <summary>
    /// This property describes the employment service provided by an E39 Actor.
    /// <see href="http://www.sealitproject.eu/ontology/employment_provided_by"></see></summary>
    let employment_provided_by = _prefix "employment_provided_by"
    /// <summary>
    /// This property describes the intention of an E39 Actor to provide a service. The property of property in the role of allows specifying the nature of an Actor’s service provision.
    /// <see href="http://www.sealitproject.eu/ontology/service_provided_by"></see></summary>
    let service_provided_by = _prefix "service_provided_by"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/provided_employment"></see>
    /// </summary>
    let provided_employment = _prefix "provided_employment"
    /// <summary>
    /// This property describes an employment that was ended/terminated by a discharge activity.
    /// <see href="http://www.sealitproject.eu/ontology/ended"></see></summary>
    let ended = _prefix "ended"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/ended_by"></see>
    /// </summary>
    let ended_by = _prefix "ended_by"
    /// <summary>
    /// This property identifies the final place (end) of a voyage. It is the actual arrival place, meaning it does not refer to the original destination place but the place to which the ship finally arrived.
    /// <see href="http://www.sealitproject.eu/ontology/finally_arriving_at"></see></summary>
    let finally_arriving_at = _prefix "finally_arriving_at"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_arrival_place_of"></see>
    /// </summary>
    let is_arrival_place_of = _prefix "is_arrival_place_of"
    /// <summary>
    /// This property describes a Money for Service activity that pays/receives money for Services.
    /// <see href="http://www.sealitproject.eu/ontology/for_service"></see></summary>
    let for_service = _prefix "for_service"
    /// <summary>
    /// This property describes the total timespan (full employment period) of the Money for Labour activity and it is a shortcut of the most detailed path: Money for Labour – for employment: Employment – P4 has timespan: E52 Time-Span (timespan of recruitment and discharge) . The time-span can be also specified through a Duration instance, using the property had duration (duration of).
    /// <see href="http://www.sealitproject.eu/ontology/for_employment_period"></see></summary>
    let for_employment_period = _prefix "for_employment_period"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_employment_period_of"></see>
    /// </summary>
    let is_employment_period_of = _prefix "is_employment_period_of"
    /// <summary>
    /// This property describes a Money for Things activity that pays/receives money for physical things.
    /// <see href="http://www.sealitproject.eu/ontology/for_thing"></see></summary>
    let for_thing = _prefix "for_thing"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/thing_of"></see>
    /// </summary>
    let thing_of = _prefix "thing_of"
    /// <summary>
    /// This property describes the voyage that sets the preconditions (motivates, determines, fixes) a crew payment. There is a dependency relationship between them; a new voyage sets the preconditions for a new crew payment activity.
    /// <see href="http://www.sealitproject.eu/ontology/for_voyage"></see></summary>
    let for_voyage = _prefix "for_voyage"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/motivated_payment"></see>
    /// </summary>
    let motivated_payment = _prefix "motivated_payment"
    /// <summary>
    /// This property associates an instance of a Legal Document with Temporal Validity with the instance of an Actor that formerly or currently possesses it, at the time of validity of the record or database containing the statement that uses this property. The property does not allow any indication of how long the legal document with temporal validity has been possessed by the specific Actor.
    /// <see href="http://www.sealitproject.eu/ontology/formerly_or_currently_possesses"></see></summary>
    let formerly_or_currently_possesses = _prefix "formerly_or_currently_possesses"

    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_formerly_or_currently_possessed_by"></see>
    /// </summary>
    let is_formerly_or_currently_possessed_by =
        _prefix "is_formerly_or_currently_possessed_by"

    /// <summary>
    /// This property describes the spatial location from which leaving (of ship) was documented. The description of this type of movement provides information about the route analysis.
    /// <see href="http://www.sealitproject.eu/ontology/from_place"></see></summary>
    let from_place = _prefix "from_place"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_place_of_leaving"></see>
    /// </summary>
    let is_place_of_leaving = _prefix "is_place_of_leaving"
    /// <summary>
    /// This property associates an instance of a Ship with an instance of the country of which this ship becomes property and consequently acquires this country’s flag. The property is a shortcut of the full path Ship – is registered by: Ship Registration – with ship flag of: Country.
    /// <see href="http://www.sealitproject.eu/ontology/had_flag_of"></see></summary>
    let had_flag_of = _prefix "had_flag_of"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/was_flag_of"></see>
    /// </summary>
    let was_flag_of = _prefix "was_flag_of"
    /// <summary>
    /// This property describes the Monetary Amount paid (i.e., the cost) for a specific Money for Service activity.
    /// <see href="http://www.sealitproject.eu/ontology/had_money_value"></see></summary>
    let had_money_value = _prefix "had_money_value"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/was_price_of"></see>
    /// </summary>
    let was_price_of = _prefix "was_price_of"
    /// <summary>
    /// This property associates instances of E39 Actor with the instances of Teaching Unit in which they participated in the role of students. The property of the property status of participation allows specifying the nature of an Actor’s participation in a course/teaching unit. For example, it can be the student’s exam status or paying/scholarship status in a course.
    /// <see href="http://www.sealitproject.eu/ontology/had_student"></see></summary>
    let had_student = _prefix "had_student"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/student_in"></see>
    /// </summary>
    let student_in = _prefix "student_in"
    /// <summary>
    /// This property associates a ship with the ammunition that it is equipped with.
    /// <see href="http://www.sealitproject.eu/ontology/has_ammunition"></see></summary>
    let has_ammunition = _prefix "has_ammunition"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_ammunition_of"></see>
    /// </summary>
    let is_ammunition_of = _prefix "is_ammunition_of"
    /// <summary>
    /// This property associates an instance of a money for labour with an instance of a Labour Contract document that is agreed and planned for this payment.
    /// <see href="http://www.sealitproject.eu/ontology/has_been_agreed_in"></see></summary>
    let has_been_agreed_in = _prefix "has_been_agreed_in"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_agreement_for"></see>
    /// </summary>
    let is_agreement_for = _prefix "is_agreement_for"
    /// <summary>
    /// This property specifies the numbers of workers/sailors authorized to work on board.
    /// <see href="http://www.sealitproject.eu/ontology/has_crew_number_capacity"></see></summary>
    let has_crew_number_capacity = _prefix "has_crew_number_capacity"
    /// <summary>
    /// This property describes the current age of a person at a specific time (the time of the information recording).
    /// <see href="http://www.sealitproject.eu/ontology/has_current_age"></see></summary>
    let has_current_age = _prefix "has_current_age"
    /// <summary>
    /// This property allows an instance of Duration to be approximated by an instance of E60 Number primitive that provides the duration value of a time-span. The value can be expressed in multiple units (such as “2 months and 5 days” or “3 years and 10 months” ), thus it is proposed to be implemented in RDFS following ISO 8601 [2] and xsd:duration [3] (form: PnYnMnDTnHnMnS).
    /// <see href="http://www.sealitproject.eu/ontology/has_duration_value"></see></summary>
    let has_duration_value = _prefix "has_duration_value"
    /// <summary>
    /// This property associates an instance of E21 Person with an instance of E62 String used as the person’s first name. This property is an alternative (more convenient) implementation of P1 is identified by: E41 Appellation – P2 has type: “first name”; P190 has symbolic content: E62 String . The use of the P1 is identified by: E41 Appellation is required if there is the need to assign some additional properties to the first name, such as properties of use or attribution.
    /// <see href="http://www.sealitproject.eu/ontology/has_first_name"></see></summary>
    let has_first_name = _prefix "has_first_name"
    /// <summary>
    /// This property records the horsepower dimension of a ship.
    /// <see href="http://www.sealitproject.eu/ontology/has_horsepower"></see></summary>
    let has_horsepower = _prefix "has_horsepower"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_horsepower_of"></see>
    /// </summary>
    let is_horsepower_of = _prefix "is_horsepower_of"
    /// <summary>
    /// This property describes concepts that represent language capacity/knowledge that characterizes a E21 Person at a specific time period that is maybe unknown.
    /// <see href="http://www.sealitproject.eu/ontology/has_language_capacity"></see></summary>
    let has_language_capacity = _prefix "has_language_capacity"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_language_capacity_of"></see>
    /// </summary>
    let is_language_capacity_of = _prefix "is_language_capacity_of"
    /// <summary>
    /// This property associates an instance of E21 Person with an instance of E62 String used as the person’s last name. This property is an alternative (more convenient) implementation of P1 is identified by: E41 Appellation – P2 has type: “last name”; P190 has symbolic content: E62 String . The use of the P1 is identified by: E41 Appellation is required if there is the need to assign some additional properties to the last name, such as type, properties of use or attribution. In some countries (e.g., Spain), each person has two last names. In such cases, the value assigned to E62 String can contain both last names, if a clear distinction is not required.
    /// <see href="http://www.sealitproject.eu/ontology/has_last_name"></see></summary>
    let has_last_name = _prefix "has_last_name"
    /// <summary>
    /// This property describes the literacy status of a person at a specific time period that is maybe unknown.
    /// <see href="http://www.sealitproject.eu/ontology/has_literacy_status"></see></summary>
    let has_literacy_status = _prefix "has_literacy_status"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_literacy_status_of"></see>
    /// </summary>
    let is_literacy_status_of = _prefix "is_literacy_status_of"
    /// <summary>
    /// This property describes the navigation type of the ship. It allows a form of specialisation through the use of a terminological hierarchy, or thesaurus.
    /// <see href="http://www.sealitproject.eu/ontology/has_navigation_type"></see></summary>
    let has_navigation_type = _prefix "has_navigation_type"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_navigation_type_of"></see>
    /// </summary>
    let is_navigation_type_of = _prefix "is_navigation_type_of"
    /// <summary>
    /// This property describes information about the owner, the person or the company (shipping enterprise), of a ship. In the context of the SeaLiT project, we make the hypothesis that the owner as a concept, implies a legal entity, so in that sense, a person is the minimum legal entity-company (with members himself/herself) of a ship.
    /// <see href="http://www.sealitproject.eu/ontology/has_owner"></see></summary>
    let has_owner = _prefix "has_owner"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_owner_of_phase"></see>
    /// </summary>
    let is_owner_of_phase = _prefix "is_owner_of_phase"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/has_ownership_phase"></see>
    /// </summary>
    let has_ownership_phase = _prefix "has_ownership_phase"
    /// <summary>
    /// This property associates a ship with the different ownership phases related to it.
    /// <see href="http://www.sealitproject.eu/ontology/is_ownership_phase_of"></see></summary>
    let is_ownership_phase_of = _prefix "is_ownership_phase_of"
    /// <summary>
    /// This property associates a person with the profession, job or career that has been practicing at a specific time period that is maybe unknown. The evolution in the career/profession of a person is an important historical question; it implies the person development and evolution (microhistory) and consequently the population evolution (macrohistory).
    /// <see href="http://www.sealitproject.eu/ontology/has_profession"></see></summary>
    let has_profession = _prefix "has_profession"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/profession_of"></see>
    /// </summary>
    let profession_of = _prefix "profession_of"
    /// <summary>
    /// This property describes the religion status of a person at a specific time period that is maybe unknown.
    /// <see href="http://www.sealitproject.eu/ontology/has_religion_status"></see></summary>
    let has_religion_status = _prefix "has_religion_status"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_religion_status_of"></see>
    /// </summary>
    let is_religion_status_of = _prefix "is_religion_status_of"
    /// <summary>
    /// This property associates a person with the sex type that this person has at a specific time period that is maybe unknown.
    /// <see href="http://www.sealitproject.eu/ontology/has_sex_type"></see></summary>
    let has_sex_type = _prefix "has_sex_type"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_sex_type_of"></see>
    /// </summary>
    let is_sex_type_of = _prefix "is_sex_type_of"
    /// <summary>
    /// This property associates an actor with the activity of participating in an ownership with shares. It implies that a phase of a shareholding represents one participation of a share by an actor. This means that if for a ship there are more than one shareholders, there will be consequently same number of shareholding phases. If we want to describe the sum of the shares of the shareholding for a ship in a specific timespan, then we will describe a composite shareholding activity that consists of individual shareholding activities of shares.
    /// <see href="http://www.sealitproject.eu/ontology/has_shareholder"></see></summary>
    let has_shareholder = _prefix "has_shareholder"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/participates_with_share"></see>
    /// </summary>
    let participates_with_share = _prefix "participates_with_share"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/has_shareholding"></see>
    /// </summary>
    let has_shareholding = _prefix "has_shareholding"
    /// <summary>
    /// This property associates a shareholding phase to a particular ship.
    /// <see href="http://www.sealitproject.eu/ontology/is_shareholding_phase_of"></see></summary>
    let is_shareholding_phase_of = _prefix "is_shareholding_phase_of"
    /// <summary>
    /// This property describes the identification of a ship by an identifier. This property does not reveal anything about when, where and by whom this identifier was used. A more detailed representation can be made using the fully developed path through Ship Registration. The property is a shortcut for the path Ship – is registered by: Ship Registration – with ship ID: Ship ID .
    /// <see href="http://www.sealitproject.eu/ontology/has_ship_ID"></see></summary>
    let has_ship_ID = _prefix "has_ship_ID"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/ship_ID_identifies"></see>
    /// </summary>
    let ship_ID_identifies = _prefix "ship_ID_identifies"
    /// <summary>
    /// This property identifies the social status of a person at a specific time period that is maybe unknown.
    /// <see href="http://www.sealitproject.eu/ontology/has_social_status"></see></summary>
    let has_social_status = _prefix "has_social_status"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_social_status_of"></see>
    /// </summary>
    let is_social_status_of = _prefix "is_social_status_of"
    /// <summary>
    /// This property describes the subject of a teaching unit.
    /// <see href="http://www.sealitproject.eu/ontology/has_subject"></see></summary>
    let has_subject = _prefix "has_subject"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_subject_of"></see>
    /// </summary>
    let is_subject_of = _prefix "is_subject_of"
    /// <summary>
    /// This property provides the tonnage dimension of a ship.
    /// <see href="http://www.sealitproject.eu/ontology/has_tonnage"></see></summary>
    let has_tonnage = _prefix "has_tonnage"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_tonnage_of"></see>
    /// </summary>
    let is_tonnage_of = _prefix "is_tonnage_of"
    /// <summary>
    /// This property describes the inferred time-span of a legal object relationship, which cannot be observed or documented. It is implicit knowledge.
    /// <see href="http://www.sealitproject.eu/ontology/in_time"></see></summary>
    let in_time = _prefix "in_time"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_time_of"></see>
    /// </summary>
    let is_time_of = _prefix "is_time_of"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/initializes"></see>
    /// </summary>
    let initializes = _prefix "initializes"
    /// <summary>
    /// This property associates the beginning of an instance of Legal Object Relationship with an explicit event initiating it.
    /// <see href="http://www.sealitproject.eu/ontology/is_initialized_by"></see></summary>
    let is_initialized_by = _prefix "is_initialized_by"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/initializes_ownership"></see>
    /// </summary>
    let initializes_ownership = _prefix "initializes_ownership"
    /// <summary>
    /// This property associates the beginning of an instance of Ship Ownership Phase with the Ship Registration that initiates it.
    /// <see href="http://www.sealitproject.eu/ontology/ownership_is_initialized_by"></see></summary>
    let ownership_is_initialized_by = _prefix "ownership_is_initialized_by"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_flag_of"></see>
    /// </summary>
    let is_flag_of = _prefix "is_flag_of"
    /// <summary>
    /// This property identifies the country represented in the ship flag of a Ship Registration activity.
    /// <see href="http://www.sealitproject.eu/ontology/with_ship_flag_of"></see></summary>
    let with_ship_flag_of = _prefix "with_ship_flag_of"
    /// <summary>
    /// This property associates a punishment to the actor that received the punishment.
    /// <see href="http://www.sealitproject.eu/ontology/is_given_to"></see></summary>
    let is_given_to = _prefix "is_given_to"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/was_punished_by"></see>
    /// </summary>
    let was_punished_by = _prefix "was_punished_by"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_place_of_passing_through"></see>
    /// </summary>
    let is_place_of_passing_through = _prefix "is_place_of_passing_through"
    /// <summary>
    /// This property associates an instance of a place with an instance of a passing activity through that place. This class provides information about the types of movements of a ship, which are parts of the route (of the voyage), and are documented as that.
    /// <see href="http://www.sealitproject.eu/ontology/through_place"></see></summary>
    let through_place = _prefix "through_place"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_registered_by"></see>
    /// </summary>
    let is_registered_by = _prefix "is_registered_by"
    /// <summary>
    /// This property associates a ship and the ship registration activity that registered and identified it.
    /// <see href="http://www.sealitproject.eu/ontology/registers"></see></summary>
    let registers = _prefix "registers"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_responsible_for_registration"></see>
    /// </summary>
    let is_responsible_for_registration = _prefix "is_responsible_for_registration"
    /// <summary>
    /// This property describes the authority, the port of registry, which is responsible for the registration of a ship.
    /// <see href="http://www.sealitproject.eu/ontology/registered_by"></see></summary>
    let registered_by = _prefix "registered_by"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_starting_place_of"></see>
    /// </summary>
    let is_starting_place_of = _prefix "is_starting_place_of"
    /// <summary>
    /// This property describes the spatial location from which a voyage started. It is the beginning of the route.
    /// <see href="http://www.sealitproject.eu/ontology/starting_from"></see></summary>
    let starting_from = _prefix "starting_from"
    /// <summary>
    /// This property associates the end of existence of an instance of Legal Object Relationship with an explicit event that terminates it.
    /// <see href="http://www.sealitproject.eu/ontology/is_terminated_by"></see></summary>
    let is_terminated_by = _prefix "is_terminated_by"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/terminates"></see>
    /// </summary>
    let terminates = _prefix "terminates"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/is_working_place_of"></see>
    /// </summary>
    let is_working_place_of = _prefix "is_working_place_of"
    /// <summary>
    /// This property identifies the workplace, meaning the organisation/company in which a person works at. The in the role of property of the property allows specifying the nature, the role of an actor’s work in the organisation/company.
    /// <see href="http://www.sealitproject.eu/ontology/works_at"></see></summary>
    let works_at = _prefix "works_at"
    /// <summary>
    /// This property associates an instance E18 Physical Thing with an instance of the loading activity that moved (loaded) it.
    /// <see href="http://www.sealitproject.eu/ontology/loaded"></see></summary>
    let loaded = _prefix "loaded"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/was_loaded_by"></see>
    /// </summary>
    let was_loaded_by = _prefix "was_loaded_by"
    /// <summary>
    /// This property identifies the E39 Actor that paid (gave money) for a specific service (Money For Service).
    /// <see href="http://www.sealitproject.eu/ontology/money_provided_by"></see></summary>
    let money_provided_by = _prefix "money_provided_by"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/provided_money"></see>
    /// </summary>
    let provided_money = _prefix "provided_money"
    /// <summary>
    /// This property identifies the E39 Actor that received money for a specific service (Money For Service).
    /// <see href="http://www.sealitproject.eu/ontology/money_provided_to"></see></summary>
    let money_provided_to = _prefix "money_provided_to"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/received_money"></see>
    /// </summary>
    let received_money = _prefix "received_money"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/name_with_ownership"></see>
    /// </summary>
    let name_with_ownership = _prefix "name_with_ownership"
    /// <summary>
    /// This property identifies the change of ship name because of an ownership phase. It can be used to provide previous/old names of a ship.
    /// <see href="http://www.sealitproject.eu/ontology/ownership_under_name"></see></summary>
    let ownership_under_name = _prefix "ownership_under_name"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/named_with"></see>
    /// </summary>
    let named_with = _prefix "named_with"
    /// <summary>
    /// This property identifies the name of the ship with the ship construction information.
    /// <see href="http://www.sealitproject.eu/ontology/under_name"></see></summary>
    let under_name = _prefix "under_name"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/navigated"></see>
    /// </summary>
    let navigated = _prefix "navigated"
    /// <summary>
    /// This property describes the participation of an E39 Actor as being responsible for the navigation of the voyage. The captain may change from voyage to voyage. The concept of the captain is normally synonym to the concept of ruling, of the power of governing, so in that sense should be mapped to the E74 Group. But, in the context of the SeaLiT project, there is the requirement for a simpler structure with more details on the biographic data of a captain, so the decision is to model the captain as a role by person (not by group).
    /// <see href="http://www.sealitproject.eu/ontology/navigated_by_captain"></see></summary>
    let navigated_by_captain = _prefix "navigated_by_captain"
    /// <summary>
    /// This property describes the number of shares hold by an owner.
    /// <see href="http://www.sealitproject.eu/ontology/of_share"></see></summary>
    let of_share = _prefix "of_share"
    /// <summary>
    /// This property associates the end of existence of an instance of Ship Ownership Phase with a De-flagging event that terminates it.
    /// <see href="http://www.sealitproject.eu/ontology/ownership_is_terminated_by"></see></summary>
    let ownership_is_terminated_by = _prefix "ownership_is_terminated_by"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/terminates_ownership"></see>
    /// </summary>
    let terminates_ownership = _prefix "terminates_ownership"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/person_is_registered_by"></see>
    /// </summary>
    let person_is_registered_by = _prefix "person_is_registered_by"
    /// <summary>
    /// This property describes a person that is registered by a civil registration activity.
    /// <see href="http://www.sealitproject.eu/ontology/registers_person"></see></summary>
    let registers_person = _prefix "registers_person"
    /// <summary>
    /// This property records the social status type that was promoted by a promotion activity. In that sense, we regard that a promotion can be related to a social status promotion or to a job/career promotion.
    /// <see href="http://www.sealitproject.eu/ontology/promoted_into_status_type"></see></summary>
    let promoted_into_status_type = _prefix "promoted_into_status_type"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/status_type_was_promoted_by"></see>
    /// </summary>
    let status_type_was_promoted_by = _prefix "status_type_was_promoted_by"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/provided_service"></see>
    /// </summary>
    let provided_service = _prefix "provided_service"
    /// <summary>
    /// This property describes the existence of a relation between persons, without the need to also specify the kind of relation. It is used in cases in which the types of the possible relationships between persons are many and not defined by the model, or in cases in which there is lack of knowledge about the kind of the relationships and there is only a requirement to mark just the existence of a link between persons. The property of property has type: E55 Type can be used to specify the type of relation, e.g., by linking to a vocabulary or thesaurus.
    /// <see href="http://www.sealitproject.eu/ontology/related_to"></see></summary>
    let related_to = _prefix "related_to"
    /// <summary>
    /// This property identifies a ship repaired by a ship repair activity.
    /// <see href="http://www.sealitproject.eu/ontology/repaired"></see></summary>
    let repaired = _prefix "repaired"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/was_repaired_by"></see>
    /// </summary>
    let was_repaired_by = _prefix "was_repaired_by"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/ship_ID_of"></see>
    /// </summary>
    let ship_ID_of = _prefix "ship_ID_of"
    /// <summary>
    /// This property records the ship identifier assigned by a Ship Registration activity.
    /// <see href="http://www.sealitproject.eu/ontology/with_ship_ID"></see></summary>
    let with_ship_ID = _prefix "with_ship_ID"
    /// <summary>
    /// This property describes an employment that was started by a recruitment activity.
    /// <see href="http://www.sealitproject.eu/ontology/started"></see></summary>
    let started = _prefix "started"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/started_by"></see>
    /// </summary>
    let started_by = _prefix "started_by"
    /// <summary>
    /// This property associates an instance of E18 Physical Thing with an instance of the unloading activity that moved (unloaded) it.
    /// <see href="http://www.sealitproject.eu/ontology/unloaded"></see></summary>
    let unloaded = _prefix "unloaded"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/was_unloaded_by"></see>
    /// </summary>
    let was_unloaded_by = _prefix "was_unloaded_by"
    /// <summary>
    /// This property describes the voyage of a ship, its movement/travelling at sea.
    /// <see href="http://www.sealitproject.eu/ontology/voyage_of"></see></summary>
    let voyage_of = _prefix "voyage_of"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/voyages"></see>
    /// </summary>
    let voyages = _prefix "voyages"
    /// <summary>
    /// This property identifies the E39 Actor that participated in the transaction (Money for Service activity) in the role of a mediator. For example, there are sources that refer that seamen used to provide money to the captain of the ship in order that the wives to receive these money (so the captain was the mediator of this transaction).
    /// <see href="http://www.sealitproject.eu/ontology/was_mediated_by"></see></summary>
    let was_mediated_by = _prefix "was_mediated_by"
    /// <summary>
    ///   <see href="http://www.sealitproject.eu/ontology/was_mediator_of"></see>
    /// </summary>
    let was_mediator_of = _prefix "was_mediator_of"
    /// <summary>
    /// This property describes the number of the students participating in a teaching unit.
    /// <see href="http://www.sealitproject.eu/ontology/with_number_of_students"></see></summary>
    let with_number_of_students = _prefix "with_number_of_students"
