#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module sealit =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.sealitproject.eu/ontology/" "sealit"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Ammunition</para>
    ///   <para>rdfs:comment : This class comprises information about the kinds and the number of guns of the ship at the moment of registration. The current documentation is mostly about merchant ships. With the beginning of the Greek Revolution in 1821, the Greek merchant fleet was transformed to military – consequently, there are also references to vessels that have ammunition during that period.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Ammunition">sealit:Ammunition</a>
    /// </summary>
    let Ammunition = _prefixId.prefix "Ammunition"
    /// <summary>
    ///   <para>rdfs:label : Arrival</para>
    ///   <para>rdfs:comment : This class comprises the arrival activity of a ship, which is a part, a stage of the overall voyage. It includes information about a place where the ship lands within a specific timeframe. It describes end points of the partial routes or within the overall voyage.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Arrival">sealit:Arrival</a>
    /// </summary>
    let Arrival = _prefixId.prefix "Arrival"
    /// <summary>
    ///   <para>rdfs:label : Civil Registration</para>
    ///   <para>rdfs:comment : Civil registration stands for legal processes of registering persons in various contexts. The outcomes of this process are legal documents such as civil acts of birth or death, or other documents (such as Register of Entries in shipyards), which usually have a period of validity.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Civil_Registration">sealit:Civil_Registration</a>
    /// </summary>
    let Civil_Registration = _prefixId.prefix "Civil_Registration"
    /// <summary>
    ///   <para>rdfs:label : Country</para>
    ///   <para>rdfs:comment : This class describes the country, a place identified as a distinct entity in political geography.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Country">sealit:Country</a>
    /// </summary>
    let Country = _prefixId.prefix "Country"
    /// <summary>
    ///   <para>rdfs:label : Course</para>
    ///   <para>rdfs:comment : This class comprises information about courses, teaching units divided and organized for educational purposes.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Course">sealit:Course</a>
    /// </summary>
    let Course = _prefixId.prefix "Course"
    /// <summary>
    ///   <para>rdfs:label : Crew Payment</para>
    ///   <para>rdfs:comment : This class comprises information about the wage payments of the people that are members of the crew of a ship.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Crew_Payment">sealit:Crew_Payment</a>
    /// </summary>
    let Crew_Payment = _prefixId.prefix "Crew_Payment"
    /// <summary>
    ///   <para>rdfs:label : De-flagging</para>
    ///   <para>rdfs:comment : De-flagging is regarded in this context as synonym to ship de-registration. When a ship is no longer flagged, this means that for a reason (e.g., demolished, shipwreck, lost, sold, etc.) the ship does not anymore sail under a legal state (of registration, having a flag).</para>
    ///   <a href="http://www.sealitproject.eu/ontology/De-flagging">sealit:De-flagging</a>
    /// </summary>
    let De_flagging = _prefixId.prefix "De-flagging"
    /// <summary>
    ///   <para>rdfs:label : Discharge</para>
    ///   <para>rdfs:comment : This class comprises the termination of a working relationship, the ending of an employee to provide service. In the context of the SeaLiT project, which explores data regarding employments records with lists of maritime personnel, a discharge is specifically defined in the sense of disembarkation, which is the activity that usually terminates a sailor’s employment service.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Discharge">sealit:Discharge</a>
    /// </summary>
    let Discharge = _prefixId.prefix "Discharge"
    /// <summary>
    ///   <para>rdfs:label : Duration</para>
    ///   <para>rdfs:comment : This class expresses the length of time in terms of indeterminacy of the duration value that can be approximated. A duration may be expressed using all the parts of a date-time (from years to seconds) and can therefore be defined as a six-dimensional space. Because the relation between some of date parts is not fixed (such as the number of days in a month), the order relationship between durations is only partial, and the result of a comparison between two durations may be undetermined. The same value may consists of different parts, such as 4 years, 10 months and 2 days.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Duration">sealit:Duration</a>
    /// </summary>
    let Duration = _prefixId.prefix "Duration"
    /// <summary>
    ///   <para>rdfs:label : Employment</para>
    ///   <para>rdfs:comment : This class comprises information about employment services between two parties, usually based on a contract where work is paid for. In the context of the SeaLiT project, it comprises information about the employment services provided on board. This relationship is initiated by the recruitment of the sailor man and is terminated by the discharge/disembarkation of this worker.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Employment">sealit:Employment</a>
    /// </summary>
    let Employment = _prefixId.prefix "Employment"
    /// <summary>
    ///   <para>rdfs:label : Horsepower</para>
    ///   <para>rdfs:comment : The power of the ship’s marine propulsion engine. The overall operation of the ship is highly dependent on the performance of its main propulsion engine, measured in terms of its power rating. There are various types of horsepower such as Nominal horsepower (NHP), Shaft horsepower (SHP), Indicated horsepower (IHP).</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Horsepower">sealit:Horsepower</a>
    /// </summary>
    let Horsepower = _prefixId.prefix "Horsepower"
    /// <summary>
    ///   <para>rdfs:label : ID of</para>
    ///   <a href="http://www.sealitproject.eu/ontology/ID_of">sealit:ID_of</a>
    /// </summary>
    let ID_of = _prefixId.prefix "ID_of"
    /// <summary>
    ///   <para>rdfs:label : Labour Contract</para>
    ///   <para>rdfs:comment : This class comprises plans expressed in a document that specifies the employment conditions.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Labour_Contract">sealit:Labour_Contract</a>
    /// </summary>
    let Labour_Contract = _prefixId.prefix "Labour_Contract"
    /// <summary>
    ///   <para>rdfs:label : Language Capacity</para>
    ///   <para>rdfs:comment : This class comprises concepts denoting a person knowledge of various languages.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Language_Capacity">sealit:Language_Capacity</a>
    /// </summary>
    let Language_Capacity = _prefixId.prefix "Language_Capacity"
    /// <summary>
    ///   <para>rdfs:label : Leaving</para>
    ///   <para>rdfs:comment : This class comprises the leaving of a ship, which is a part, a stage of the overall voyage. It includes information about a place from which the ship leaves within a specific timeframe. It describes start points of the partial routes or with the overall voyage.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Leaving">sealit:Leaving</a>
    /// </summary>
    let Leaving = _prefixId.prefix "Leaving"

    /// <summary>
    ///   <para>rdfs:label : Legal Document with Temporal Validity</para>
    ///   <para>rdfs:comment : This class comprises official documents or legal agreements that are valid for a specific timespan. The concept of this class includes licenses, official permissions, authorizations, etc., having a temporal validity.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Legal_Document_with_Temporal_Validity">sealit:Legal_Document_with_Temporal_Validity</a>
    /// </summary>
    let Legal_Document_with_Temporal_Validity =
        _prefixId.prefix "Legal_Document_with_Temporal_Validity"

    /// <summary>
    ///   <para>rdfs:label : Legal Object Relationship</para>
    ///   <para>rdfs:comment : This class comprises legal object relationships of which the timespan and the state (of these relationships) cannot be observed or documented. We can only observe these relationships through the events that initialize or terminate this state of relationship (starting event and terminating event). Basically, it comprises of characteristics/properties of a legal relationship which is the kind of information that can be inferred/asserted and not by temporal documentation of these properties.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Legal_Object_Relationship">sealit:Legal_Object_Relationship</a>
    /// </summary>
    let Legal_Object_Relationship = _prefixId.prefix "Legal_Object_Relationship"
    /// <summary>
    ///   <para>rdfs:label : Literacy Status</para>
    ///   <para>rdfs:comment : This class comprises concepts denoting a person’s literacy status.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Literacy_Status">sealit:Literacy_Status</a>
    /// </summary>
    let Literacy_Status = _prefixId.prefix "Literacy_Status"
    /// <summary>
    ///   <para>rdfs:label : Loading</para>
    ///   <para>rdfs:comment : This class comprises loading activities as they are documented during the voyages (or as parts of the routes) of the ships. It seems that the definition of a ship includes the notion of the loading of things; the procedures of loading/unloading are very important; the types of ships, the ports and the routes seem to define the types of loading, the dimensions, and the technology of loading/unloading and storage in ships.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Loading">sealit:Loading</a>
    /// </summary>
    let Loading = _prefixId.prefix "Loading"
    /// <summary>
    ///   <para>rdfs:label : Money for Labour</para>
    ///   <para>rdfs:comment : This class comprises activities in which actors pay/receive money for services related to labour, human work, in order to earn wage.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Money_for_Labour">sealit:Money_for_Labour</a>
    /// </summary>
    let Money_for_Labour = _prefixId.prefix "Money_for_Labour"
    /// <summary>
    ///   <para>rdfs:label : Money for Service</para>
    ///   <para>rdfs:comment : This class comprises transaction activities in which actors pay/receive money for services.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Money_for_Service">sealit:Money_for_Service</a>
    /// </summary>
    let Money_for_Service = _prefixId.prefix "Money_for_Service"
    /// <summary>
    ///   <para>rdfs:label : Money for Things</para>
    ///   <para>rdfs:comment : This class comprises transaction activities in which actors pay/receive money for services related to things, such as purchase of foods, etc.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Money_for_Things">sealit:Money_for_Things</a>
    /// </summary>
    let Money_for_Things = _prefixId.prefix "Money_for_Things"
    /// <summary>
    ///   <para>rdfs:label : Navigation Type</para>
    ///   <para>rdfs:comment : This class comprises concepts denoted by terms used to characterize and classify a ship, in particular its navigation type, based on the long or short distances of travel.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Navigation_Type">sealit:Navigation_Type</a>
    /// </summary>
    let Navigation_Type = _prefixId.prefix "Navigation_Type"
    /// <summary>
    ///   <para>rdfs:label : has type</para>
    ///   <a href="http://www.sealitproject.eu/ontology/PC_has_type">sealit:PC_has_type</a>
    /// </summary>
    let PC_has_type = _prefixId.prefix "PC_has_type"
    /// <summary>
    ///   <para>rdfs:label : PC provided service</para>
    ///   <a href="http://www.sealitproject.eu/ontology/PC_provided_service">sealit:PC_provided_service</a>
    /// </summary>
    let PC_provided_service = _prefixId.prefix "PC_provided_service"
    /// <summary>
    ///   <para>rdfs:label : PC related to</para>
    ///   <a href="http://www.sealitproject.eu/ontology/PC_related_to">sealit:PC_related_to</a>
    /// </summary>
    let PC_related_to = _prefixId.prefix "PC_related_to"
    /// <summary>
    ///   <para>rdfs:label : PC student_in</para>
    ///   <a href="http://www.sealitproject.eu/ontology/PC_student_in">sealit:PC_student_in</a>
    /// </summary>
    let PC_student_in = _prefixId.prefix "PC_student_in"

    /// <summary>
    ///   <para>rdfs:label : with status of participation</para>
    ///   <a href="http://www.sealitproject.eu/ontology/PC_with_status_of_participation">sealit:PC_with_status_of_participation</a>
    /// </summary>
    let PC_with_status_of_participation =
        _prefixId.prefix "PC_with_status_of_participation"

    /// <summary>
    ///   <para>rdfs:label : PC works at</para>
    ///   <a href="http://www.sealitproject.eu/ontology/PC_works_at">sealit:PC_works_at</a>
    /// </summary>
    let PC_works_at = _prefixId.prefix "PC_works_at"
    /// <summary>
    ///   <para>rdfs:label : in the role of</para>
    ///   <a href="http://www.sealitproject.eu/ontology/PCa_in_the_role_of">sealit:PCa_in_the_role_of</a>
    /// </summary>
    let PCa_in_the_role_of = _prefixId.prefix "PCa_in_the_role_of"
    /// <summary>
    ///   <para>rdfs:label : in the role of</para>
    ///   <a href="http://www.sealitproject.eu/ontology/PCb_in_the_role_of">sealit:PCb_in_the_role_of</a>
    /// </summary>
    let PCb_in_the_role_of = _prefixId.prefix "PCb_in_the_role_of"
    /// <summary>
    ///   <para>rdfs:label : Passing</para>
    ///   <para>rdfs:comment : This class comprises passing by (or through) activities of a ship at sea. This information helps to track the ships and the routes. Passing by or through is a part of the overall voyage. It includes information about places by/through which the ship passes within a specific timeframe.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Passing">sealit:Passing</a>
    /// </summary>
    let Passing = _prefixId.prefix "Passing"
    /// <summary>
    ///   <para>rdfs:label : Port of Registry</para>
    ///   <para>rdfs:comment : This class describes the port (the issuing authority) that is responsible for a vessel registration.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Port_of_Registry">sealit:Port_of_Registry</a>
    /// </summary>
    let Port_of_Registry = _prefixId.prefix "Port_of_Registry"
    /// <summary>
    ///   <para>rdfs:label : Profession</para>
    ///   <para>rdfs:comment : This class comprises information about the person profession, work, career or job, as it was written inside the original source.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Profession">sealit:Profession</a>
    /// </summary>
    let Profession = _prefixId.prefix "Profession"
    /// <summary>
    ///   <para>rdfs:label : Promotion</para>
    ///   <para>rdfs:comment : This class comprises activities that result in the promotion, the advancement of an employee within a company position or job tasks or in a higher ranking as a reward for good performance. It is typically associated with a higher rate or a financial bonus.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Promotion">sealit:Promotion</a>
    /// </summary>
    let Promotion = _prefixId.prefix "Promotion"
    /// <summary>
    ///   <para>rdfs:label : Punishment</para>
    ///   <para>rdfs:comment : This class comprises instances of punishments in terms of public policy, defined by an authority, as a response to a particular action that is deemed undesirable or unacceptable. Examples of penalties for punishment are prison, or loss of a privilege or of a status, etc.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Punishment">sealit:Punishment</a>
    /// </summary>
    let Punishment = _prefixId.prefix "Punishment"
    /// <summary>
    ///   <para>rdfs:label : Recruitment</para>
    ///   <para>rdfs:comment : This class comprises the process of hiring and bringing new staff member to work for a company, or to become a new member of an organization. In the context of the SeaLiT project, which explores data regarding employments records with lists of maritime personnel, a recruitment is specifically defined in the sense of on board employment. Recruitment or embarkation is the activity that usually starts a sailor’s employment service. There is information from sources, such as from the Maritime Register of the State for La Ciotat (matricule des maîtres au cabotage) , referring that they used to have “recruitment” systems that registered every man 18 years old and up, or a younger boy (as apprentice), exercising one of the maritime professions for over a year, at the Navy’s disposal, in case of a war. On the same time, the state provided many privileges in return for service in the navy, such as tax exemptions, military pensions, free education and life insurance for the families of listed seamen.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Recruitment">sealit:Recruitment</a>
    /// </summary>
    let Recruitment = _prefixId.prefix "Recruitment"
    /// <summary>
    ///   <para>rdfs:label : Religion Status</para>
    ///   <para>rdfs:comment : This class comprises concepts used to characterize the religious affiliation of a person.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Religion_Status">sealit:Religion_Status</a>
    /// </summary>
    let Religion_Status = _prefixId.prefix "Religion_Status"
    /// <summary>
    ///   <para>rdfs:label : Section</para>
    ///   <para>rdfs:comment : This class comprises information about sections of lessons. Some courses are divided into multiple sections.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Section">sealit:Section</a>
    /// </summary>
    let Section = _prefixId.prefix "Section"
    /// <summary>
    ///   <para>rdfs:label : Service</para>
    ///   <para>rdfs:comment : Service is the willing, the capability to offer a service, by some instance of E39 Actor, independently if it is executed or not. This offer is declared at the request of another instance of E39 Actor.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Service">sealit:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    /// <summary>
    ///   <para>rdfs:label : Sex Type</para>
    ///   <para>rdfs:comment : The gender of a person.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Sex_Type">sealit:Sex_Type</a>
    /// </summary>
    let Sex_Type = _prefixId.prefix "Sex_Type"
    /// <summary>
    ///   <para>rdfs:label : Shareholding</para>
    ///   <para>rdfs:comment : This class describes the common phenomenon through periods in which ships share ownership. Therefore, if for example a person is allowed to possess up to 1/48 of a ship, it means that a single person could have many ships shares in the same time. Sometimes the leading owner has the absolute majority of the shares, sometimes only the relative majority; these are just assumptions/examples that this class can describe.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Shareholding">sealit:Shareholding</a>
    /// </summary>
    let Shareholding = _prefixId.prefix "Shareholding"
    /// <summary>
    ///   <para>rdfs:label : Ship</para>
    ///   <para>rdfs:comment : This class comprises vessels, ships of different kinds, which can cross large open waters. Ships have been important contributors to human migration and commerce.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Ship">sealit:Ship</a>
    /// </summary>
    let Ship = _prefixId.prefix "Ship"
    /// <summary>
    ///   <para>rdfs:label : Ship Construction</para>
    ///   <para>rdfs:comment : This class describes the activity of building new ships and other floating vessels. The ship construction information, in particular the location and date of construction, is the most reliable information (extracted from the source) that helps to identify a ship. A very important methodological question is what information can be used to define the unique identity of a ship. The answer is that there does not exist a single information that can define it: it is always a matter of comparison of the sources and information. Even though, there is information that is critical to the identity of a ship, such as the place and the year of construction.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Ship_Construction">sealit:Ship_Construction</a>
    /// </summary>
    let Ship_Construction = _prefixId.prefix "Ship_Construction"
    /// <summary>
    ///   <para>rdfs:label : Ship ID</para>
    ///   <para>rdfs:comment : This class comprises numeric information assigned as registration number of a ship.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Ship_ID">sealit:Ship_ID</a>
    /// </summary>
    let Ship_ID = _prefixId.prefix "Ship_ID"
    /// <summary>
    ///   <para>rdfs:label : Ship Name</para>
    ///   <para>rdfs:comment : This class comprises the name that identifies a ship. The name of the ship can be changed because of an ownership (so a ship can have many names through time).</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Ship_Name">sealit:Ship_Name</a>
    /// </summary>
    let Ship_Name = _prefixId.prefix "Ship_Name"
    /// <summary>
    ///   <para>rdfs:label : Ship Ownership Phase</para>
    ///   <para>rdfs:comment : This class comprises information about the ownership state of a ship. It consists of characteristics or properties of ownership. Ownership is a legal agreement, a kind of information that can be inferred/asserted and cannot be directly observed. Ownership usually characterizes/assigns a name to a ship and a ship changes its name under an ownership state. Ownership phase can be traced by the ship registration activity that initiates it, and by the de-flagging activity that terminates the phase. A single ship can have many owners (persons or/and companies).</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Ship_Ownership_Phase">sealit:Ship_Ownership_Phase</a>
    /// </summary>
    let Ship_Ownership_Phase = _prefixId.prefix "Ship_Ownership_Phase"
    /// <summary>
    ///   <para>rdfs:label : Ship Registration</para>
    ///   <para>rdfs:comment : A ship acquires legal identity with the process of its registration, the register of its name, flag, id, dimensions and horsepower. The ownership information is documented in the registry book signed by the Port of Registry.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Ship_Registration">sealit:Ship_Registration</a>
    /// </summary>
    let Ship_Registration = _prefixId.prefix "Ship_Registration"
    /// <summary>
    ///   <para>rdfs:label : Ship Repair</para>
    ///   <para>rdfs:comment : This class comprises activities that alter or change or restore/repair a ship.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Ship_Repair">sealit:Ship_Repair</a>
    /// </summary>
    let Ship_Repair = _prefixId.prefix "Ship_Repair"
    /// <summary>
    ///   <para>rdfs:label : Social Status</para>
    ///   <para>rdfs:comment : This class comprises a person’s social status, as it was written inside the original source. This can include different kinds of social status, such as marital status or estate. In such cases of further classification, these concepts can be used as instances of the Social Status class. This class extends E55 Type in order to refine the meaning of this specific concept (social status). This concept is sufficiently stable and associated with additional explicitly modelled property specific to it ( “has social status” ). An alternative mechanism is to specialize the classification of Social Status instances to any level of detail, by linking to external vocabulary sources, thesauri, classification schemas or ontologies. In general, a good practice for concepts that are not user defined metaclasses, would be to be treated as particulars with the relationship P2 has type.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Social_Status">sealit:Social_Status</a>
    /// </summary>
    let Social_Status = _prefixId.prefix "Social_Status"
    /// <summary>
    ///   <para>rdfs:label : Subject</para>
    ///   <para>rdfs:comment : This class comprises information about the scientific subjects of the courses that were taught at a specific semester.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Subject">sealit:Subject</a>
    /// </summary>
    let Subject = _prefixId.prefix "Subject"
    /// <summary>
    ///   <para>rdfs:label : Teaching Unit</para>
    ///   <para>rdfs:comment : This class comprises information about the school year, the period of time during which the school holds classes and offers courses. It is a period of educational activities.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Teaching_Unit">sealit:Teaching_Unit</a>
    /// </summary>
    let Teaching_Unit = _prefixId.prefix "Teaching_Unit"
    /// <summary>
    ///   <para>rdfs:label : Tonnage</para>
    ///   <para>rdfs:comment : Tonnage is a measure of the cargo-carrying capacity of a ship. The sources refer to different kinds of tonnage, such as gross tonnage, net tonnage, etc. and through time, tonnage types may change. Tonnage may change during a reconstruction phase of a ship, for example.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Tonnage">sealit:Tonnage</a>
    /// </summary>
    let Tonnage = _prefixId.prefix "Tonnage"
    /// <summary>
    ///   <para>rdfs:label : Unloading</para>
    ///   <para>rdfs:comment : This class comprises unloading activities as they are documented during the voyages (or as parts of the routes) of the ships. The procedures of loading/unloading are very important; the types of ships, the ports and the routes seem to define the types of loading, the dimensions, and the technology of loading/unloading and storage in ships.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Unloading">sealit:Unloading</a>
    /// </summary>
    let Unloading = _prefixId.prefix "Unloading"
    /// <summary>
    ///   <para>rdfs:label : Voyage</para>
    ///   <para>rdfs:comment : This class comprises information about the voyages of ships. Voyage is defined as the process of travelling from one place to another, staying there, usually for a short time; it is not a simple move/change from place to place; it is a movement in space and time (and it is documented as that [1] ). The same ship can sail many voyages during its lifetime. Voyage and route information is very important for historically investigating the various trade routes and navigation patterns used to exist in different times. Voyage is an important aspect of the ship and the seaman, and generally of the seafaring life, both at sea and ashore .</para>
    ///   <a href="http://www.sealitproject.eu/ontology/Voyage">sealit:Voyage</a>
    /// </summary>
    let Voyage = _prefixId.prefix "Voyage"
    /// <summary>
    ///   <para>rdfs:label : arrival is part of</para>
    ///   <a href="http://www.sealitproject.eu/ontology/arrival_is_part_of">sealit:arrival_is_part_of</a>
    /// </summary>
    let arrival_is_part_of = _prefixId.prefix "arrival_is_part_of"
    /// <summary>
    ///   <para>rdfs:label : at place</para>
    ///   <para>rdfs:comment : This property describes the spatial location of an arrival.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/at_place">sealit:at_place</a>
    /// </summary>
    let at_place = _prefixId.prefix "at_place"
    /// <summary>
    ///   <para>rdfs:label : by place</para>
    ///   <para>rdfs:comment : This property associates an instance of a place with an instance of a passing activity by that place. This class provides information about the types of movements of a ship, which are parts of the route (of the voyage), and are documented as that.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/by_place">sealit:by_place</a>
    /// </summary>
    let by_place = _prefixId.prefix "by_place"
    /// <summary>
    ///   <para>rdfs:label : concerned</para>
    ///   <para>rdfs:comment : This property identifies the person that was promoted by a promotion activity.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/concerned">sealit:concerned</a>
    /// </summary>
    let concerned = _prefixId.prefix "concerned"
    /// <summary>
    ///   <para>rdfs:label : consists of arrival</para>
    ///   <para>rdfs:comment : This property allows an instance of a Voyage to be analysed into parts such as arrival activities. It is a subproperty of P9 consists of (forms part of). This analysis of parts of the voyage contributes to the route analysis, which provides information about specific navigation patterns of the ship.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/consists_of_arrival">sealit:consists_of_arrival</a>
    /// </summary>
    let consists_of_arrival = _prefixId.prefix "consists_of_arrival"
    /// <summary>
    ///   <para>rdfs:label : consists of leaving</para>
    ///   <para>rdfs:comment : This property allows an instance of a Voyage to be analysed into parts such as leaving activities. It is a subproperty of P9 consists of (forms part of). This analysis of parts of the voyage contributes to the route analysis, which provides information about specific navigation patterns of the ship.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/consists_of_leaving">sealit:consists_of_leaving</a>
    /// </summary>
    let consists_of_leaving = _prefixId.prefix "consists_of_leaving"
    /// <summary>
    ///   <para>rdfs:label : consists of loading</para>
    ///   <para>rdfs:comment : This property allows an instance of a Voyage to be analysed into parts such as loading activities. It is a subproperty of P9 consists of (forms part of). The activities of loading/unloading happen ashore, before, in between, or after (with the end) of the voyage of a ship and are part of its definition.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/consists_of_loading">sealit:consists_of_loading</a>
    /// </summary>
    let consists_of_loading = _prefixId.prefix "consists_of_loading"
    /// <summary>
    ///   <para>rdfs:label : consists of passing</para>
    ///   <para>rdfs:comment : This property allows an instance of a Voyage to be analysed into parts such as passing by/through activities. It is a subproperty of P9 consists of (forms part of). This analysis of parts of the voyage contributes to the route analysis, which provides information about specific navigation patterns of the ship</para>
    ///   <a href="http://www.sealitproject.eu/ontology/consists_of_passing">sealit:consists_of_passing</a>
    /// </summary>
    let consists_of_passing = _prefixId.prefix "consists_of_passing"
    /// <summary>
    ///   <para>rdfs:label : consists of unloading</para>
    ///   <para>rdfs:comment : This property allows an instance of a Voyage to be analysed into parts such as unloading activities. It is a subproperty of P9 consists of (forms part of). The activities of loading/unloading happen ashore, before, in between, or after (with the end) of the voyage of a ship and are part of its definition.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/consists_of_unloading">sealit:consists_of_unloading</a>
    /// </summary>
    let consists_of_unloading = _prefixId.prefix "consists_of_unloading"
    /// <summary>
    ///   <para>rdfs:label : constructed</para>
    ///   <para>rdfs:comment : This property identifies a ship that came into existence as a result of a construction event.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/constructed">sealit:constructed</a>
    /// </summary>
    let constructed = _prefixId.prefix "constructed"
    /// <summary>
    ///   <para>rdfs:label : de-flagged in</para>
    ///   <a href="http://www.sealitproject.eu/ontology/de-flagged_in">sealit:de-flagged_in</a>
    /// </summary>
    let de_flagged_in = _prefixId.prefix "de-flagged_in"
    /// <summary>
    ///   <para>rdfs:label : de-flagging of</para>
    ///   <para>rdfs:comment : This property associates an instance of a ship with the instance of the de-flagging activity that de-registered it.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/de-flagging_of">sealit:de-flagging_of</a>
    /// </summary>
    let de_flagging_of = _prefixId.prefix "de-flagging_of"
    /// <summary>
    ///   <para>rdfs:label : destination</para>
    ///   <para>rdfs:comment : This property describes the intended place where the voyage, theoretically, according to the maps and the plans should end. It is the planned destination of the route, which may change in reality.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/destination">sealit:destination</a>
    /// </summary>
    let destination = _prefixId.prefix "destination"
    /// <summary>
    ///   <para>rdfs:label : duration of</para>
    ///   <a href="http://www.sealitproject.eu/ontology/duration_of">sealit:duration_of</a>
    /// </summary>
    let duration_of = _prefixId.prefix "duration_of"
    /// <summary>
    ///   <para>rdfs:label : employment of</para>
    ///   <a href="http://www.sealitproject.eu/ontology/employment_of">sealit:employment_of</a>
    /// </summary>
    let employment_of = _prefixId.prefix "employment_of"

    /// <summary>
    ///   <para>rdfs:label : employment position type was promoted by</para>
    ///   <a href="http://www.sealitproject.eu/ontology/employment_position_type_was_promoted_by">sealit:employment_position_type_was_promoted_by</a>
    /// </summary>
    let employment_position_type_was_promoted_by =
        _prefixId.prefix "employment_position_type_was_promoted_by"

    /// <summary>
    ///   <para>rdfs:label : employment provided by</para>
    ///   <para>rdfs:comment : This property describes the employment service provided by an E39 Actor.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/employment_provided_by">sealit:employment_provided_by</a>
    /// </summary>
    let employment_provided_by = _prefixId.prefix "employment_provided_by"
    /// <summary>
    ///   <para>rdfs:label : ended</para>
    ///   <para>rdfs:comment : This property describes an employment that was ended/terminated by a discharge activity.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/ended">sealit:ended</a>
    /// </summary>
    let ended = _prefixId.prefix "ended"
    /// <summary>
    ///   <para>rdfs:label : ended by</para>
    ///   <a href="http://www.sealitproject.eu/ontology/ended_by">sealit:ended_by</a>
    /// </summary>
    let ended_by = _prefixId.prefix "ended_by"
    /// <summary>
    ///   <para>rdfs:label : finally arriving at</para>
    ///   <para>rdfs:comment : This property identifies the final place (end) of a voyage. It is the actual arrival place, meaning it does not refer to the original destination place but the place to which the ship finally arrived.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/finally_arriving_at">sealit:finally_arriving_at</a>
    /// </summary>
    let finally_arriving_at = _prefixId.prefix "finally_arriving_at"
    /// <summary>
    ///   <para>rdfs:label : for employment</para>
    ///   <para>rdfs:comment : This property associates an instance of a payment with an instance of an employment that was used in order to specify rights and responsibilities between the “employee” and the “employer”.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/for_employment">sealit:for_employment</a>
    /// </summary>
    let for_employment = _prefixId.prefix "for_employment"
    /// <summary>
    ///   <para>rdfs:label : for employment period</para>
    ///   <para>rdfs:comment : This property describes the total timespan (full employment period) of the Money for Labour activity and it is a shortcut of the most detailed path: Money for Labour – for employment: Employment – P4 has timespan: E52 Time-Span (timespan of recruitment and discharge) . The time-span can be also specified through a Duration instance, using the property had duration (duration of).</para>
    ///   <a href="http://www.sealitproject.eu/ontology/for_employment_period">sealit:for_employment_period</a>
    /// </summary>
    let for_employment_period = _prefixId.prefix "for_employment_period"
    /// <summary>
    ///   <para>rdfs:label : for service</para>
    ///   <para>rdfs:comment : This property describes a Money for Service activity that pays/receives money for Services.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/for_service">sealit:for_service</a>
    /// </summary>
    let for_service = _prefixId.prefix "for_service"
    /// <summary>
    ///   <para>rdfs:label : for thing</para>
    ///   <para>rdfs:comment : This property describes a Money for Things activity that pays/receives money for physical things.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/for_thing">sealit:for_thing</a>
    /// </summary>
    let for_thing = _prefixId.prefix "for_thing"
    /// <summary>
    ///   <para>rdfs:label : for voyage</para>
    ///   <para>rdfs:comment : This property describes the voyage that sets the preconditions (motivates, determines, fixes) a crew payment. There is a dependency relationship between them; a new voyage sets the preconditions for a new crew payment activity.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/for_voyage">sealit:for_voyage</a>
    /// </summary>
    let for_voyage = _prefixId.prefix "for_voyage"

    /// <summary>
    ///   <para>rdfs:label : formerly or currently possesses</para>
    ///   <para>rdfs:comment : This property associates an instance of a Legal Document with Temporal Validity with the instance of an Actor that formerly or currently possesses it, at the time of validity of the record or database containing the statement that uses this property. The property does not allow any indication of how long the legal document with temporal validity has been possessed by the specific Actor.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/formerly_or_currently_possesses">sealit:formerly_or_currently_possesses</a>
    /// </summary>
    let formerly_or_currently_possesses =
        _prefixId.prefix "formerly_or_currently_possesses"

    /// <summary>
    ///   <para>rdfs:label : from place</para>
    ///   <para>rdfs:comment : This property describes the spatial location from which leaving (of ship) was documented. The description of this type of movement provides information about the route analysis.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/from_place">sealit:from_place</a>
    /// </summary>
    let from_place = _prefixId.prefix "from_place"
    /// <summary>
    ///   <para>rdfs:label : had duration</para>
    ///   <para>rdfs:comment : This property describes the length of time covered by an E52 Time-Span. It allows an E52 Time-Span to be associated with a duration (as a dimension, an interval) independent from the actual beginning and end.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/had_duration">sealit:had_duration</a>
    /// </summary>
    let had_duration = _prefixId.prefix "had_duration"
    /// <summary>
    ///   <para>rdfs:label : had flag of</para>
    ///   <para>rdfs:comment : This property associates an instance of a Ship with an instance of the country of which this ship becomes property and consequently acquires this country’s flag. The property is a shortcut of the full path Ship – is registered by: Ship Registration – with ship flag of: Country.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/had_flag_of">sealit:had_flag_of</a>
    /// </summary>
    let had_flag_of = _prefixId.prefix "had_flag_of"
    /// <summary>
    ///   <para>rdfs:label : had money value</para>
    ///   <para>rdfs:comment : This property describes the Monetary Amount paid (i.e., the cost) for a specific Money for Service activity.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/had_money_value">sealit:had_money_value</a>
    /// </summary>
    let had_money_value = _prefixId.prefix "had_money_value"
    /// <summary>
    ///   <para>rdfs:label : had student</para>
    ///   <para>rdfs:comment : This property associates instances of E39 Actor with the instances of Teaching Unit in which they participated in the role of students. The property of the property status of participation allows specifying the nature of an Actor’s participation in a course/teaching unit. For example, it can be the student’s exam status or paying/scholarship status in a course.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/had_student">sealit:had_student</a>
    /// </summary>
    let had_student = _prefixId.prefix "had_student"
    /// <summary>
    ///   <para>rdfs:label : has ammunition</para>
    ///   <para>rdfs:comment : This property associates a ship with the ammunition that it is equipped with.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/has_ammunition">sealit:has_ammunition</a>
    /// </summary>
    let has_ammunition = _prefixId.prefix "has_ammunition"
    /// <summary>
    ///   <para>rdfs:label : has been agreed in</para>
    ///   <para>rdfs:comment : This property associates an instance of a money for labour with an instance of a Labour Contract document that is agreed and planned for this payment.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/has_been_agreed_in">sealit:has_been_agreed_in</a>
    /// </summary>
    let has_been_agreed_in = _prefixId.prefix "has_been_agreed_in"
    /// <summary>
    ///   <para>rdfs:label : has crew number capacity</para>
    ///   <para>rdfs:comment : This property specifies the numbers of workers/sailors authorized to work on board.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/has_crew_number_capacity">sealit:has_crew_number_capacity</a>
    /// </summary>
    let has_crew_number_capacity = _prefixId.prefix "has_crew_number_capacity"
    /// <summary>
    ///   <para>rdfs:label : has current age</para>
    ///   <para>rdfs:comment : This property describes the current age of a person at a specific time (the time of the information recording).</para>
    ///   <a href="http://www.sealitproject.eu/ontology/has_current_age">sealit:has_current_age</a>
    /// </summary>
    let has_current_age = _prefixId.prefix "has_current_age"
    /// <summary>
    ///   <para>rdfs:label : has duration value</para>
    ///   <para>rdfs:comment : This property allows an instance of Duration to be approximated by an instance of E60 Number primitive that provides the duration value of a time-span. The value can be expressed in multiple units (such as “2 months and 5 days” or “3 years and 10 months” ), thus it is proposed to be implemented in RDFS following ISO 8601 [2] and xsd:duration [3] (form: PnYnMnDTnHnMnS).</para>
    ///   <a href="http://www.sealitproject.eu/ontology/has_duration_value">sealit:has_duration_value</a>
    /// </summary>
    let has_duration_value = _prefixId.prefix "has_duration_value"
    /// <summary>
    ///   <para>rdfs:label : has first name</para>
    ///   <para>rdfs:comment : This property associates an instance of E21 Person with an instance of E62 String used as the person’s first name. This property is an alternative (more convenient) implementation of P1 is identified by: E41 Appellation – P2 has type: “first name”; P190 has symbolic content: E62 String . The use of the P1 is identified by: E41 Appellation is required if there is the need to assign some additional properties to the first name, such as properties of use or attribution.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/has_first_name">sealit:has_first_name</a>
    /// </summary>
    let has_first_name = _prefixId.prefix "has_first_name"
    /// <summary>
    ///   <para>rdfs:label : has horsepower</para>
    ///   <para>rdfs:comment : This property records the horsepower dimension of a ship.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/has_horsepower">sealit:has_horsepower</a>
    /// </summary>
    let has_horsepower = _prefixId.prefix "has_horsepower"
    /// <summary>
    ///   <para>rdfs:label : has language capacity</para>
    ///   <para>rdfs:comment : This property describes concepts that represent language capacity/knowledge that characterizes a E21 Person at a specific time period that is maybe unknown.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/has_language_capacity">sealit:has_language_capacity</a>
    /// </summary>
    let has_language_capacity = _prefixId.prefix "has_language_capacity"
    /// <summary>
    ///   <para>rdfs:label : has last name</para>
    ///   <para>rdfs:comment : This property associates an instance of E21 Person with an instance of E62 String used as the person’s last name. This property is an alternative (more convenient) implementation of P1 is identified by: E41 Appellation – P2 has type: “last name”; P190 has symbolic content: E62 String . The use of the P1 is identified by: E41 Appellation is required if there is the need to assign some additional properties to the last name, such as type, properties of use or attribution. In some countries (e.g., Spain), each person has two last names. In such cases, the value assigned to E62 String can contain both last names, if a clear distinction is not required.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/has_last_name">sealit:has_last_name</a>
    /// </summary>
    let has_last_name = _prefixId.prefix "has_last_name"
    /// <summary>
    ///   <para>rdfs:label : has literacy status</para>
    ///   <para>rdfs:comment : This property describes the literacy status of a person at a specific time period that is maybe unknown.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/has_literacy_status">sealit:has_literacy_status</a>
    /// </summary>
    let has_literacy_status = _prefixId.prefix "has_literacy_status"
    /// <summary>
    ///   <para>rdfs:label : has navigation type</para>
    ///   <para>rdfs:comment : This property describes the navigation type of the ship. It allows a form of specialisation through the use of a terminological hierarchy, or thesaurus.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/has_navigation_type">sealit:has_navigation_type</a>
    /// </summary>
    let has_navigation_type = _prefixId.prefix "has_navigation_type"
    /// <summary>
    ///   <para>rdfs:label : has owner</para>
    ///   <para>rdfs:comment : This property describes information about the owner, the person or the company (shipping enterprise), of a ship. In the context of the SeaLiT project, we make the hypothesis that the owner as a concept, implies a legal entity, so in that sense, a person is the minimum legal entity-company (with members himself/herself) of a ship.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/has_owner">sealit:has_owner</a>
    /// </summary>
    let has_owner = _prefixId.prefix "has_owner"
    /// <summary>
    ///   <para>rdfs:label : has ownership phase</para>
    ///   <a href="http://www.sealitproject.eu/ontology/has_ownership_phase">sealit:has_ownership_phase</a>
    /// </summary>
    let has_ownership_phase = _prefixId.prefix "has_ownership_phase"
    /// <summary>
    ///   <para>rdfs:label : has profession</para>
    ///   <para>rdfs:comment : This property associates a person with the profession, job or career that has been practicing at a specific time period that is maybe unknown. The evolution in the career/profession of a person is an important historical question; it implies the person development and evolution (microhistory) and consequently the population evolution (macrohistory).</para>
    ///   <a href="http://www.sealitproject.eu/ontology/has_profession">sealit:has_profession</a>
    /// </summary>
    let has_profession = _prefixId.prefix "has_profession"
    /// <summary>
    ///   <para>rdfs:label : has religion status</para>
    ///   <para>rdfs:comment : This property describes the religion status of a person at a specific time period that is maybe unknown.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/has_religion_status">sealit:has_religion_status</a>
    /// </summary>
    let has_religion_status = _prefixId.prefix "has_religion_status"
    /// <summary>
    ///   <para>rdfs:label : has sex type</para>
    ///   <para>rdfs:comment : This property associates a person with the sex type that this person has at a specific time period that is maybe unknown.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/has_sex_type">sealit:has_sex_type</a>
    /// </summary>
    let has_sex_type = _prefixId.prefix "has_sex_type"
    /// <summary>
    ///   <para>rdfs:label : has shareholder</para>
    ///   <para>rdfs:comment : This property associates an actor with the activity of participating in an ownership with shares. It implies that a phase of a shareholding represents one participation of a share by an actor. This means that if for a ship there are more than one shareholders, there will be consequently same number of shareholding phases. If we want to describe the sum of the shares of the shareholding for a ship in a specific timespan, then we will describe a composite shareholding activity that consists of individual shareholding activities of shares.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/has_shareholder">sealit:has_shareholder</a>
    /// </summary>
    let has_shareholder = _prefixId.prefix "has_shareholder"
    /// <summary>
    ///   <para>rdfs:label : has shareholding</para>
    ///   <a href="http://www.sealitproject.eu/ontology/has_shareholding">sealit:has_shareholding</a>
    /// </summary>
    let has_shareholding = _prefixId.prefix "has_shareholding"
    /// <summary>
    ///   <para>rdfs:label : has ship ID</para>
    ///   <para>rdfs:comment : This property describes the identification of a ship by an identifier. This property does not reveal anything about when, where and by whom this identifier was used. A more detailed representation can be made using the fully developed path through Ship Registration. The property is a shortcut for the path Ship – is registered by: Ship Registration – with ship ID: Ship ID .</para>
    ///   <a href="http://www.sealitproject.eu/ontology/has_ship_ID">sealit:has_ship_ID</a>
    /// </summary>
    let has_ship_ID = _prefixId.prefix "has_ship_ID"
    /// <summary>
    ///   <para>rdfs:label : has social status</para>
    ///   <para>rdfs:comment : This property identifies the social status of a person at a specific time period that is maybe unknown.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/has_social_status">sealit:has_social_status</a>
    /// </summary>
    let has_social_status = _prefixId.prefix "has_social_status"
    /// <summary>
    ///   <para>rdfs:label : has subject</para>
    ///   <para>rdfs:comment : This property describes the subject of a teaching unit.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/has_subject">sealit:has_subject</a>
    /// </summary>
    let has_subject = _prefixId.prefix "has_subject"
    /// <summary>
    ///   <para>rdfs:label : has tonnage</para>
    ///   <para>rdfs:comment : This property provides the tonnage dimension of a ship.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/has_tonnage">sealit:has_tonnage</a>
    /// </summary>
    let has_tonnage = _prefixId.prefix "has_tonnage"
    /// <summary>
    ///   <para>rdfs:label : in time</para>
    ///   <para>rdfs:comment : This property describes the inferred time-span of a legal object relationship, which cannot be observed or documented. It is implicit knowledge.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/in_time">sealit:in_time</a>
    /// </summary>
    let in_time = _prefixId.prefix "in_time"
    /// <summary>
    ///   <para>rdfs:label : initializes</para>
    ///   <a href="http://www.sealitproject.eu/ontology/initializes">sealit:initializes</a>
    /// </summary>
    let initializes = _prefixId.prefix "initializes"
    /// <summary>
    ///   <para>rdfs:label : initializes ownership</para>
    ///   <a href="http://www.sealitproject.eu/ontology/initializes_ownership">sealit:initializes_ownership</a>
    /// </summary>
    let initializes_ownership = _prefixId.prefix "initializes_ownership"
    /// <summary>
    ///   <para>rdfs:label : is agreement for</para>
    ///   <a href="http://www.sealitproject.eu/ontology/is_agreement_for">sealit:is_agreement_for</a>
    /// </summary>
    let is_agreement_for = _prefixId.prefix "is_agreement_for"
    /// <summary>
    ///   <para>rdfs:label : is ammunition of</para>
    ///   <a href="http://www.sealitproject.eu/ontology/is_ammunition_of">sealit:is_ammunition_of</a>
    /// </summary>
    let is_ammunition_of = _prefixId.prefix "is_ammunition_of"
    /// <summary>
    ///   <para>rdfs:label : is arrival place of</para>
    ///   <a href="http://www.sealitproject.eu/ontology/is_arrival_place_of">sealit:is_arrival_place_of</a>
    /// </summary>
    let is_arrival_place_of = _prefixId.prefix "is_arrival_place_of"
    /// <summary>
    ///   <para>rdfs:label : is destination of</para>
    ///   <a href="http://www.sealitproject.eu/ontology/is_destination_of">sealit:is_destination_of</a>
    /// </summary>
    let is_destination_of = _prefixId.prefix "is_destination_of"
    /// <summary>
    ///   <para>rdfs:label : is employment period of</para>
    ///   <a href="http://www.sealitproject.eu/ontology/is_employment_period_of">sealit:is_employment_period_of</a>
    /// </summary>
    let is_employment_period_of = _prefixId.prefix "is_employment_period_of"
    /// <summary>
    ///   <para>rdfs:label : is flag of</para>
    ///   <a href="http://www.sealitproject.eu/ontology/is_flag_of">sealit:is_flag_of</a>
    /// </summary>
    let is_flag_of = _prefixId.prefix "is_flag_of"

    /// <summary>
    ///   <para>rdfs:label : is formerly or currently possessed by</para>
    ///   <a href="http://www.sealitproject.eu/ontology/is_formerly_or_currently_possessed_by">sealit:is_formerly_or_currently_possessed_by</a>
    /// </summary>
    let is_formerly_or_currently_possessed_by =
        _prefixId.prefix "is_formerly_or_currently_possessed_by"

    /// <summary>
    ///   <para>rdfs:label : is given to</para>
    ///   <para>rdfs:comment : This property associates a punishment to the actor that received the punishment.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/is_given_to">sealit:is_given_to</a>
    /// </summary>
    let is_given_to = _prefixId.prefix "is_given_to"
    /// <summary>
    ///   <para>rdfs:label : is horsepower of</para>
    ///   <a href="http://www.sealitproject.eu/ontology/is_horsepower_of">sealit:is_horsepower_of</a>
    /// </summary>
    let is_horsepower_of = _prefixId.prefix "is_horsepower_of"
    /// <summary>
    ///   <para>rdfs:label : is initialized by</para>
    ///   <para>rdfs:comment : This property associates the beginning of an instance of Legal Object Relationship with an explicit event initiating it.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/is_initialized_by">sealit:is_initialized_by</a>
    /// </summary>
    let is_initialized_by = _prefixId.prefix "is_initialized_by"
    /// <summary>
    ///   <para>rdfs:label : is language capacity of</para>
    ///   <a href="http://www.sealitproject.eu/ontology/is_language_capacity_of">sealit:is_language_capacity_of</a>
    /// </summary>
    let is_language_capacity_of = _prefixId.prefix "is_language_capacity_of"
    /// <summary>
    ///   <para>rdfs:label : is literacy status of</para>
    ///   <a href="http://www.sealitproject.eu/ontology/is_literacy_status_of">sealit:is_literacy_status_of</a>
    /// </summary>
    let is_literacy_status_of = _prefixId.prefix "is_literacy_status_of"
    /// <summary>
    ///   <para>rdfs:label : is navigation type of</para>
    ///   <a href="http://www.sealitproject.eu/ontology/is_navigation_type_of">sealit:is_navigation_type_of</a>
    /// </summary>
    let is_navigation_type_of = _prefixId.prefix "is_navigation_type_of"
    /// <summary>
    ///   <para>rdfs:label : is owner of phase</para>
    ///   <a href="http://www.sealitproject.eu/ontology/is_owner_of_phase">sealit:is_owner_of_phase</a>
    /// </summary>
    let is_owner_of_phase = _prefixId.prefix "is_owner_of_phase"
    /// <summary>
    ///   <para>rdfs:label : is ownership phase of</para>
    ///   <para>rdfs:comment : This property associates a ship with the different ownership phases related to it.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/is_ownership_phase_of">sealit:is_ownership_phase_of</a>
    /// </summary>
    let is_ownership_phase_of = _prefixId.prefix "is_ownership_phase_of"
    /// <summary>
    ///   <para>rdfs:label : is place of arrival</para>
    ///   <a href="http://www.sealitproject.eu/ontology/is_place_of_arrival">sealit:is_place_of_arrival</a>
    /// </summary>
    let is_place_of_arrival = _prefixId.prefix "is_place_of_arrival"
    /// <summary>
    ///   <para>rdfs:label : is place of leaving</para>
    ///   <a href="http://www.sealitproject.eu/ontology/is_place_of_leaving">sealit:is_place_of_leaving</a>
    /// </summary>
    let is_place_of_leaving = _prefixId.prefix "is_place_of_leaving"
    /// <summary>
    ///   <para>rdfs:label : is place of passing by</para>
    ///   <a href="http://www.sealitproject.eu/ontology/is_place_of_passing_by">sealit:is_place_of_passing_by</a>
    /// </summary>
    let is_place_of_passing_by = _prefixId.prefix "is_place_of_passing_by"
    /// <summary>
    ///   <para>rdfs:label : is place of passing through</para>
    ///   <a href="http://www.sealitproject.eu/ontology/is_place_of_passing_through">sealit:is_place_of_passing_through</a>
    /// </summary>
    let is_place_of_passing_through = _prefixId.prefix "is_place_of_passing_through"
    /// <summary>
    ///   <para>rdfs:label : is registered by</para>
    ///   <a href="http://www.sealitproject.eu/ontology/is_registered_by">sealit:is_registered_by</a>
    /// </summary>
    let is_registered_by = _prefixId.prefix "is_registered_by"
    /// <summary>
    ///   <para>rdfs:label : is religion status of</para>
    ///   <a href="http://www.sealitproject.eu/ontology/is_religion_status_of">sealit:is_religion_status_of</a>
    /// </summary>
    let is_religion_status_of = _prefixId.prefix "is_religion_status_of"

    /// <summary>
    ///   <para>rdfs:label : is responsible for registration</para>
    ///   <a href="http://www.sealitproject.eu/ontology/is_responsible_for_registration">sealit:is_responsible_for_registration</a>
    /// </summary>
    let is_responsible_for_registration =
        _prefixId.prefix "is_responsible_for_registration"

    /// <summary>
    ///   <para>rdfs:label : is sex type of</para>
    ///   <a href="http://www.sealitproject.eu/ontology/is_sex_type_of">sealit:is_sex_type_of</a>
    /// </summary>
    let is_sex_type_of = _prefixId.prefix "is_sex_type_of"
    /// <summary>
    ///   <para>rdfs:label : is shareholding phase of</para>
    ///   <para>rdfs:comment : This property associates a shareholding phase to a particular ship.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/is_shareholding_phase_of">sealit:is_shareholding_phase_of</a>
    /// </summary>
    let is_shareholding_phase_of = _prefixId.prefix "is_shareholding_phase_of"
    /// <summary>
    ///   <para>rdfs:label : is social status of</para>
    ///   <a href="http://www.sealitproject.eu/ontology/is_social_status_of">sealit:is_social_status_of</a>
    /// </summary>
    let is_social_status_of = _prefixId.prefix "is_social_status_of"
    /// <summary>
    ///   <para>rdfs:label : is starting place of</para>
    ///   <a href="http://www.sealitproject.eu/ontology/is_starting_place_of">sealit:is_starting_place_of</a>
    /// </summary>
    let is_starting_place_of = _prefixId.prefix "is_starting_place_of"
    /// <summary>
    ///   <para>rdfs:label : is subject of</para>
    ///   <a href="http://www.sealitproject.eu/ontology/is_subject_of">sealit:is_subject_of</a>
    /// </summary>
    let is_subject_of = _prefixId.prefix "is_subject_of"
    /// <summary>
    ///   <para>rdfs:label : is terminated by</para>
    ///   <para>rdfs:comment : This property associates the end of existence of an instance of Legal Object Relationship with an explicit event that terminates it.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/is_terminated_by">sealit:is_terminated_by</a>
    /// </summary>
    let is_terminated_by = _prefixId.prefix "is_terminated_by"
    /// <summary>
    ///   <para>rdfs:label : is time of</para>
    ///   <a href="http://www.sealitproject.eu/ontology/is_time_of">sealit:is_time_of</a>
    /// </summary>
    let is_time_of = _prefixId.prefix "is_time_of"
    /// <summary>
    ///   <para>rdfs:label : is tonnage of</para>
    ///   <a href="http://www.sealitproject.eu/ontology/is_tonnage_of">sealit:is_tonnage_of</a>
    /// </summary>
    let is_tonnage_of = _prefixId.prefix "is_tonnage_of"
    /// <summary>
    ///   <para>rdfs:label : is working place of</para>
    ///   <a href="http://www.sealitproject.eu/ontology/is_working_place_of">sealit:is_working_place_of</a>
    /// </summary>
    let is_working_place_of = _prefixId.prefix "is_working_place_of"
    /// <summary>
    ///   <para>rdfs:label : leaving is part of</para>
    ///   <a href="http://www.sealitproject.eu/ontology/leaving_is_part_of">sealit:leaving_is_part_of</a>
    /// </summary>
    let leaving_is_part_of = _prefixId.prefix "leaving_is_part_of"
    /// <summary>
    ///   <para>rdfs:label : loaded</para>
    ///   <para>rdfs:comment : This property associates an instance E18 Physical Thing with an instance of the loading activity that moved (loaded) it.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/loaded">sealit:loaded</a>
    /// </summary>
    let loaded = _prefixId.prefix "loaded"
    /// <summary>
    ///   <para>rdfs:label : loading is part of</para>
    ///   <a href="http://www.sealitproject.eu/ontology/loading_is_part_of">sealit:loading_is_part_of</a>
    /// </summary>
    let loading_is_part_of = _prefixId.prefix "loading_is_part_of"
    /// <summary>
    ///   <para>rdfs:label : money provided by</para>
    ///   <para>rdfs:comment : This property identifies the E39 Actor that paid (gave money) for a specific service (Money For Service).</para>
    ///   <a href="http://www.sealitproject.eu/ontology/money_provided_by">sealit:money_provided_by</a>
    /// </summary>
    let money_provided_by = _prefixId.prefix "money_provided_by"
    /// <summary>
    ///   <para>rdfs:label : money provided to</para>
    ///   <para>rdfs:comment : This property identifies the E39 Actor that received money for a specific service (Money For Service).</para>
    ///   <a href="http://www.sealitproject.eu/ontology/money_provided_to">sealit:money_provided_to</a>
    /// </summary>
    let money_provided_to = _prefixId.prefix "money_provided_to"
    /// <summary>
    ///   <para>rdfs:label : motivated payment</para>
    ///   <a href="http://www.sealitproject.eu/ontology/motivated_payment">sealit:motivated_payment</a>
    /// </summary>
    let motivated_payment = _prefixId.prefix "motivated_payment"
    /// <summary>
    ///   <para>rdfs:label : name with ownership</para>
    ///   <a href="http://www.sealitproject.eu/ontology/name_with_ownership">sealit:name_with_ownership</a>
    /// </summary>
    let name_with_ownership = _prefixId.prefix "name_with_ownership"
    /// <summary>
    ///   <para>rdfs:label : named with</para>
    ///   <a href="http://www.sealitproject.eu/ontology/named_with">sealit:named_with</a>
    /// </summary>
    let named_with = _prefixId.prefix "named_with"
    /// <summary>
    ///   <para>rdfs:label : navigated</para>
    ///   <a href="http://www.sealitproject.eu/ontology/navigated">sealit:navigated</a>
    /// </summary>
    let navigated = _prefixId.prefix "navigated"
    /// <summary>
    ///   <para>rdfs:label : navigated by captain</para>
    ///   <para>rdfs:comment : This property describes the participation of an E39 Actor as being responsible for the navigation of the voyage. The captain may change from voyage to voyage. The concept of the captain is normally synonym to the concept of ruling, of the power of governing, so in that sense should be mapped to the E74 Group. But, in the context of the SeaLiT project, there is the requirement for a simpler structure with more details on the biographic data of a captain, so the decision is to model the captain as a role by person (not by group).</para>
    ///   <a href="http://www.sealitproject.eu/ontology/navigated_by_captain">sealit:navigated_by_captain</a>
    /// </summary>
    let navigated_by_captain = _prefixId.prefix "navigated_by_captain"
    /// <summary>
    ///   <para>rdfs:label : of share</para>
    ///   <para>rdfs:comment : This property describes the number of shares hold by an owner.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/of_share">sealit:of_share</a>
    /// </summary>
    let of_share = _prefixId.prefix "of_share"
    /// <summary>
    ///   <para>rdfs:label : ownership is initialized by</para>
    ///   <para>rdfs:comment : This property associates the beginning of an instance of Ship Ownership Phase with the Ship Registration that initiates it.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/ownership_is_initialized_by">sealit:ownership_is_initialized_by</a>
    /// </summary>
    let ownership_is_initialized_by = _prefixId.prefix "ownership_is_initialized_by"
    /// <summary>
    ///   <para>rdfs:label : ownership is terminated by</para>
    ///   <para>rdfs:comment : This property associates the end of existence of an instance of Ship Ownership Phase with a De-flagging event that terminates it.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/ownership_is_terminated_by">sealit:ownership_is_terminated_by</a>
    /// </summary>
    let ownership_is_terminated_by = _prefixId.prefix "ownership_is_terminated_by"
    /// <summary>
    ///   <para>rdfs:label : ownership under name</para>
    ///   <para>rdfs:comment : This property identifies the change of ship name because of an ownership phase. It can be used to provide previous/old names of a ship.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/ownership_under_name">sealit:ownership_under_name</a>
    /// </summary>
    let ownership_under_name = _prefixId.prefix "ownership_under_name"
    /// <summary>
    ///   <para>rdfs:label : participates with share</para>
    ///   <a href="http://www.sealitproject.eu/ontology/participates_with_share">sealit:participates_with_share</a>
    /// </summary>
    let participates_with_share = _prefixId.prefix "participates_with_share"
    /// <summary>
    ///   <para>rdfs:label : passing is part of</para>
    ///   <a href="http://www.sealitproject.eu/ontology/passing_is_part_of">sealit:passing_is_part_of</a>
    /// </summary>
    let passing_is_part_of = _prefixId.prefix "passing_is_part_of"
    /// <summary>
    ///   <para>rdfs:label : person is registered by</para>
    ///   <a href="http://www.sealitproject.eu/ontology/person_is_registered_by">sealit:person_is_registered_by</a>
    /// </summary>
    let person_is_registered_by = _prefixId.prefix "person_is_registered_by"
    /// <summary>
    ///   <para>rdfs:label : profession of</para>
    ///   <a href="http://www.sealitproject.eu/ontology/profession_of">sealit:profession_of</a>
    /// </summary>
    let profession_of = _prefixId.prefix "profession_of"

    /// <summary>
    ///   <para>rdfs:label : promoted into employment position type</para>
    ///   <para>rdfs:comment : This property records the employment (job) position type that was promoted by a promotion activity. In that sense, we regard that a promotion can be related to a social status promotion or to a job/career promotion.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/promoted_into_employment_position_type">sealit:promoted_into_employment_position_type</a>
    /// </summary>
    let promoted_into_employment_position_type =
        _prefixId.prefix "promoted_into_employment_position_type"

    /// <summary>
    ///   <para>rdfs:label : promoted into status type</para>
    ///   <para>rdfs:comment : This property records the social status type that was promoted by a promotion activity. In that sense, we regard that a promotion can be related to a social status promotion or to a job/career promotion.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/promoted_into_status_type">sealit:promoted_into_status_type</a>
    /// </summary>
    let promoted_into_status_type = _prefixId.prefix "promoted_into_status_type"
    /// <summary>
    ///   <para>rdfs:label : provided employment</para>
    ///   <a href="http://www.sealitproject.eu/ontology/provided_employment">sealit:provided_employment</a>
    /// </summary>
    let provided_employment = _prefixId.prefix "provided_employment"
    /// <summary>
    ///   <para>rdfs:label : provided money</para>
    ///   <a href="http://www.sealitproject.eu/ontology/provided_money">sealit:provided_money</a>
    /// </summary>
    let provided_money = _prefixId.prefix "provided_money"
    /// <summary>
    ///   <para>rdfs:label : provided service</para>
    ///   <a href="http://www.sealitproject.eu/ontology/provided_service">sealit:provided_service</a>
    /// </summary>
    let provided_service = _prefixId.prefix "provided_service"
    /// <summary>
    ///   <para>rdfs:label : received money</para>
    ///   <a href="http://www.sealitproject.eu/ontology/received_money">sealit:received_money</a>
    /// </summary>
    let received_money = _prefixId.prefix "received_money"
    /// <summary>
    ///   <para>rdfs:label : registered by</para>
    ///   <para>rdfs:comment : This property describes the authority, the port of registry, which is responsible for the registration of a ship.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/registered_by">sealit:registered_by</a>
    /// </summary>
    let registered_by = _prefixId.prefix "registered_by"
    /// <summary>
    ///   <para>rdfs:label : registers</para>
    ///   <para>rdfs:comment : This property associates a ship and the ship registration activity that registered and identified it.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/registers">sealit:registers</a>
    /// </summary>
    let registers = _prefixId.prefix "registers"
    /// <summary>
    ///   <para>rdfs:label : registers person</para>
    ///   <para>rdfs:comment : This property describes a person that is registered by a civil registration activity.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/registers_person">sealit:registers_person</a>
    /// </summary>
    let registers_person = _prefixId.prefix "registers_person"
    /// <summary>
    ///   <para>rdfs:label : related to</para>
    ///   <para>rdfs:comment : This property describes the existence of a relation between persons, without the need to also specify the kind of relation. It is used in cases in which the types of the possible relationships between persons are many and not defined by the model, or in cases in which there is lack of knowledge about the kind of the relationships and there is only a requirement to mark just the existence of a link between persons. The property of property has type: E55 Type can be used to specify the type of relation, e.g., by linking to a vocabulary or thesaurus.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/related_to">sealit:related_to</a>
    /// </summary>
    let related_to = _prefixId.prefix "related_to"
    /// <summary>
    ///   <para>rdfs:label : repaired</para>
    ///   <para>rdfs:comment : This property identifies a ship repaired by a ship repair activity.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/repaired">sealit:repaired</a>
    /// </summary>
    let repaired = _prefixId.prefix "repaired"
    /// <summary>
    ///   <para>rdfs:label : service of</para>
    ///   <a href="http://www.sealitproject.eu/ontology/service_of">sealit:service_of</a>
    /// </summary>
    let service_of = _prefixId.prefix "service_of"
    /// <summary>
    ///   <para>rdfs:label : service provided by</para>
    ///   <para>rdfs:comment : This property describes the intention of an E39 Actor to provide a service. The property of property in the role of allows specifying the nature of an Actor’s service provision.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/service_provided_by">sealit:service_provided_by</a>
    /// </summary>
    let service_provided_by = _prefixId.prefix "service_provided_by"
    /// <summary>
    ///   <para>rdfs:label : ship ID identifies</para>
    ///   <a href="http://www.sealitproject.eu/ontology/ship_ID_identifies">sealit:ship_ID_identifies</a>
    /// </summary>
    let ship_ID_identifies = _prefixId.prefix "ship_ID_identifies"
    /// <summary>
    ///   <para>rdfs:label : ship ID of</para>
    ///   <a href="http://www.sealitproject.eu/ontology/ship_ID_of">sealit:ship_ID_of</a>
    /// </summary>
    let ship_ID_of = _prefixId.prefix "ship_ID_of"
    /// <summary>
    ///   <para>rdfs:label : started</para>
    ///   <para>rdfs:comment : This property describes an employment that was started by a recruitment activity.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/started">sealit:started</a>
    /// </summary>
    let started = _prefixId.prefix "started"
    /// <summary>
    ///   <para>rdfs:label : started by</para>
    ///   <a href="http://www.sealitproject.eu/ontology/started_by">sealit:started_by</a>
    /// </summary>
    let started_by = _prefixId.prefix "started_by"
    /// <summary>
    ///   <para>rdfs:label : starting from</para>
    ///   <para>rdfs:comment : This property describes the spatial location from which a voyage started. It is the beginning of the route.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/starting_from">sealit:starting_from</a>
    /// </summary>
    let starting_from = _prefixId.prefix "starting_from"
    /// <summary>
    ///   <para>rdfs:label : status type was promoted by</para>
    ///   <a href="http://www.sealitproject.eu/ontology/status_type_was_promoted_by">sealit:status_type_was_promoted_by</a>
    /// </summary>
    let status_type_was_promoted_by = _prefixId.prefix "status_type_was_promoted_by"
    /// <summary>
    ///   <para>rdfs:label : student in</para>
    ///   <a href="http://www.sealitproject.eu/ontology/student_in">sealit:student_in</a>
    /// </summary>
    let student_in = _prefixId.prefix "student_in"
    /// <summary>
    ///   <para>rdfs:label : terminates</para>
    ///   <a href="http://www.sealitproject.eu/ontology/terminates">sealit:terminates</a>
    /// </summary>
    let terminates = _prefixId.prefix "terminates"
    /// <summary>
    ///   <para>rdfs:label : terminates ownership</para>
    ///   <a href="http://www.sealitproject.eu/ontology/terminates_ownership">sealit:terminates_ownership</a>
    /// </summary>
    let terminates_ownership = _prefixId.prefix "terminates_ownership"
    /// <summary>
    ///   <para>rdfs:label : thing of</para>
    ///   <a href="http://www.sealitproject.eu/ontology/thing_of">sealit:thing_of</a>
    /// </summary>
    let thing_of = _prefixId.prefix "thing_of"
    /// <summary>
    ///   <para>rdfs:label : through place</para>
    ///   <para>rdfs:comment : This property associates an instance of a place with an instance of a passing activity through that place. This class provides information about the types of movements of a ship, which are parts of the route (of the voyage), and are documented as that.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/through_place">sealit:through_place</a>
    /// </summary>
    let through_place = _prefixId.prefix "through_place"
    /// <summary>
    ///   <para>rdfs:label : under name</para>
    ///   <para>rdfs:comment : This property identifies the name of the ship with the ship construction information.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/under_name">sealit:under_name</a>
    /// </summary>
    let under_name = _prefixId.prefix "under_name"
    /// <summary>
    ///   <para>rdfs:label : unloaded</para>
    ///   <para>rdfs:comment : This property associates an instance of E18 Physical Thing with an instance of the unloading activity that moved (unloaded) it.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/unloaded">sealit:unloaded</a>
    /// </summary>
    let unloaded = _prefixId.prefix "unloaded"
    /// <summary>
    ///   <para>rdfs:label : unloading is part of</para>
    ///   <a href="http://www.sealitproject.eu/ontology/unloading_is_part_of">sealit:unloading_is_part_of</a>
    /// </summary>
    let unloading_is_part_of = _prefixId.prefix "unloading_is_part_of"
    /// <summary>
    ///   <para>rdfs:label : voyage of</para>
    ///   <para>rdfs:comment : This property describes the voyage of a ship, its movement/travelling at sea.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/voyage_of">sealit:voyage_of</a>
    /// </summary>
    let voyage_of = _prefixId.prefix "voyage_of"
    /// <summary>
    ///   <para>rdfs:label : voyages</para>
    ///   <a href="http://www.sealitproject.eu/ontology/voyages">sealit:voyages</a>
    /// </summary>
    let voyages = _prefixId.prefix "voyages"
    /// <summary>
    ///   <para>rdfs:label : was constructed by</para>
    ///   <a href="http://www.sealitproject.eu/ontology/was_constructed_by">sealit:was_constructed_by</a>
    /// </summary>
    let was_constructed_by = _prefixId.prefix "was_constructed_by"
    /// <summary>
    ///   <para>rdfs:label : was flag of</para>
    ///   <a href="http://www.sealitproject.eu/ontology/was_flag_of">sealit:was_flag_of</a>
    /// </summary>
    let was_flag_of = _prefixId.prefix "was_flag_of"
    /// <summary>
    ///   <para>rdfs:label : was loaded by</para>
    ///   <a href="http://www.sealitproject.eu/ontology/was_loaded_by">sealit:was_loaded_by</a>
    /// </summary>
    let was_loaded_by = _prefixId.prefix "was_loaded_by"
    /// <summary>
    ///   <para>rdfs:label : was mediated by</para>
    ///   <para>rdfs:comment : This property identifies the E39 Actor that participated in the transaction (Money for Service activity) in the role of a mediator. For example, there are sources that refer that seamen used to provide money to the captain of the ship in order that the wives to receive these money (so the captain was the mediator of this transaction).</para>
    ///   <a href="http://www.sealitproject.eu/ontology/was_mediated_by">sealit:was_mediated_by</a>
    /// </summary>
    let was_mediated_by = _prefixId.prefix "was_mediated_by"
    /// <summary>
    ///   <para>rdfs:label : was mediator of</para>
    ///   <a href="http://www.sealitproject.eu/ontology/was_mediator_of">sealit:was_mediator_of</a>
    /// </summary>
    let was_mediator_of = _prefixId.prefix "was_mediator_of"
    /// <summary>
    ///   <para>rdfs:label : was price of</para>
    ///   <a href="http://www.sealitproject.eu/ontology/was_price_of">sealit:was_price_of</a>
    /// </summary>
    let was_price_of = _prefixId.prefix "was_price_of"
    /// <summary>
    ///   <para>rdfs:label : was promoted by</para>
    ///   <a href="http://www.sealitproject.eu/ontology/was_promoted_by">sealit:was_promoted_by</a>
    /// </summary>
    let was_promoted_by = _prefixId.prefix "was_promoted_by"
    /// <summary>
    ///   <para>rdfs:label : was punished by</para>
    ///   <a href="http://www.sealitproject.eu/ontology/was_punished_by">sealit:was_punished_by</a>
    /// </summary>
    let was_punished_by = _prefixId.prefix "was_punished_by"
    /// <summary>
    ///   <para>rdfs:label : was repaired by</para>
    ///   <a href="http://www.sealitproject.eu/ontology/was_repaired_by">sealit:was_repaired_by</a>
    /// </summary>
    let was_repaired_by = _prefixId.prefix "was_repaired_by"
    /// <summary>
    ///   <para>rdfs:label : was unloaded by</para>
    ///   <a href="http://www.sealitproject.eu/ontology/was_unloaded_by">sealit:was_unloaded_by</a>
    /// </summary>
    let was_unloaded_by = _prefixId.prefix "was_unloaded_by"
    /// <summary>
    ///   <para>rdfs:label : with ID</para>
    ///   <para>rdfs:comment : This property records the identifier that was assigned to a person in a Civil Registration activity.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/with_ID">sealit:with_ID</a>
    /// </summary>
    let with_ID = _prefixId.prefix "with_ID"
    /// <summary>
    ///   <para>rdfs:label : with number of students</para>
    ///   <para>rdfs:comment : This property describes the number of the students participating in a teaching unit.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/with_number_of_students">sealit:with_number_of_students</a>
    /// </summary>
    let with_number_of_students = _prefixId.prefix "with_number_of_students"
    /// <summary>
    ///   <para>rdfs:label : with ship ID</para>
    ///   <para>rdfs:comment : This property records the ship identifier assigned by a Ship Registration activity.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/with_ship_ID">sealit:with_ship_ID</a>
    /// </summary>
    let with_ship_ID = _prefixId.prefix "with_ship_ID"
    /// <summary>
    ///   <para>rdfs:label : with ship flag of</para>
    ///   <para>rdfs:comment : This property identifies the country represented in the ship flag of a Ship Registration activity.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/with_ship_flag_of">sealit:with_ship_flag_of</a>
    /// </summary>
    let with_ship_flag_of = _prefixId.prefix "with_ship_flag_of"
    /// <summary>
    ///   <para>rdfs:label : works at</para>
    ///   <para>rdfs:comment : This property identifies the workplace, meaning the organisation/company in which a person works at. The in the role of property of the property allows specifying the nature, the role of an actor’s work in the organisation/company.</para>
    ///   <a href="http://www.sealitproject.eu/ontology/works_at">sealit:works_at</a>
    /// </summary>
    let works_at = _prefixId.prefix "works_at"
