#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module akt =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.aktors.org/ontology/portal#" "akt"

    /// <summary>
    ///   <para>rdfs:comment : Information in general, independent of an object in which it is encoded. Whatever is transferred in an information-transfer event. It is clearly an intangible thing^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Abstract-Information">akt:Abstract-Information</a>
    /// </summary>
    let Abstract_Information = _prefixId.prefix "Abstract-Information"
    let Academic = _prefixId.prefix "Academic"
    let Academic_Degree = _prefixId.prefix "Academic-Degree"
    let Academic_Support_Staff = _prefixId.prefix "Academic-Support-Staff"
    let Academic_Support_Unit = _prefixId.prefix "Academic-Support-Unit"
    let Academic_Unit = _prefixId.prefix "Academic-Unit"
    let Activity = _prefixId.prefix "Activity"
    let Adaptive_Hypermedia = _prefixId.prefix "Adaptive-Hypermedia"
    /// <summary>
    ///   <para>rdfs:comment : A generic class for addresses, whether email or postal. We see an address as abstract information and therefore it is an intangible thing^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Address">akt:Address</a>
    /// </summary>
    let Address = _prefixId.prefix "Address"
    /// <summary>
    ///   <para>rdfs:comment : A person which has an affiliation with some organization. For instance employees are affiliated to the organization they work for, students to the institution where they are studying, etc. A person can have multiple affiliations, which means that there is no constraint relating the values of slot has-affiliation-to-unit to the values of slot has-affiliation^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Affiliated-Person">akt:Affiliated-Person</a>
    /// </summary>
    let Affiliated_Person = _prefixId.prefix "Affiliated-Person"
    let Agent_Based_Computing = _prefixId.prefix "Agent-Based-Computing"
    let Alpha_Version = _prefixId.prefix "Alpha-Version"
    let Amount_Of_Money = _prefixId.prefix "Amount-Of-Money"
    let Appellation = _prefixId.prefix "Appellation"

    let Article_In_A_Composite_Publication =
        _prefixId.prefix "Article-In-A-Composite-Publication"

    let Article_Reference = _prefixId.prefix "Article-Reference"

    let Artificial_Intelligence_Research_Area =
        _prefixId.prefix "Artificial-Intelligence-Research-Area"

    let Attending_A_Conference = _prefixId.prefix "Attending-A-Conference"
    let Attending_An_Event = _prefixId.prefix "Attending-An-Event"
    /// <summary>
    ///   <para>rdfs:comment : An award is an intangible thing, even if the piece of paper which is often associated with an award is tangible.  What about the virtual piece of paper in the virtual degree ceremony?  I guess that ought to be an intangible^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Award">akt:Award</a>
    /// </summary>
    let Award = _prefixId.prefix "Award"
    /// <summary>
    ///   <para>rdfs:comment : Legal agents can be either organizations or people. An awarding body is normally an organization, an individual, or a bunch of people^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Awarding-Body">akt:Awarding-Body</a>
    /// </summary>
    let Awarding_Body = _prefixId.prefix "Awarding-Body"
    let BA = _prefixId.prefix "BA"
    let BSc = _prefixId.prefix "BSc"
    let Beta_Version = _prefixId.prefix "Beta-Version"
    let Book = _prefixId.prefix "Book"
    let Book_Publishing = _prefixId.prefix "Book-Publishing"
    let Book_Reference = _prefixId.prefix "Book-Reference"
    let Book_Section_Reference = _prefixId.prefix "Book-Section-Reference"
    let Broken_Version = _prefixId.prefix "Broken-Version"
    let Business_Area = _prefixId.prefix "Business-Area"
    let Capital_City = _prefixId.prefix "Capital-City"
    let Charitable_Organization = _prefixId.prefix "Charitable-Organization"
    let City = _prefixId.prefix "City"
    let Civil_Service = _prefixId.prefix "Civil-Service"

    let Cognitive_Modelling_Research_Area =
        _prefixId.prefix "Cognitive-Modelling-Research-Area"

    let Collaborative_Hypermedia = _prefixId.prefix "Collaborative-Hypermedia"
    let Company = _prefixId.prefix "Company"
    /// <summary>
    ///   <para>rdfs:comment : A publication which contains items which cane be themselves referenced through a publication reference.  Composite publications include newspapers, magazines and journals. A book which is a collection of articles is a composite publication, a monograph is not^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Composite-Publication">akt:Composite-Publication</a>
    /// </summary>
    let Composite_Publication = _prefixId.prefix "Composite-Publication"
    let Computing_Research_Area = _prefixId.prefix "Computing-Research-Area"
    let Computing_Technology = _prefixId.prefix "Computing-Technology"
    let Conference = _prefixId.prefix "Conference"

    let Conference_Proceedings_Reference =
        _prefixId.prefix "Conference-Proceedings-Reference"

    let Conferring_An_Award = _prefixId.prefix "Conferring-An-Award"
    let Country = _prefixId.prefix "Country"
    let Currency = _prefixId.prefix "Currency"
    let DEng = _prefixId.prefix "DEng"
    let Daily_Newspaper = _prefixId.prefix "Daily-Newspaper"
    /// <summary>
    ///   <para>rdfs:comment : A degree is type of award^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Degree">akt:Degree</a>
    /// </summary>
    let Degree = _prefixId.prefix "Degree"
    let Distance_Teaching_University = _prefixId.prefix "Distance-Teaching-University"
    let Dr = _prefixId.prefix "Dr"
    let Dynamic_Linking = _prefixId.prefix "Dynamic-Linking"
    let E_Commerce_Research_Area = _prefixId.prefix "E-Commerce-Research-Area"
    let Edited_Book = _prefixId.prefix "Edited-Book"
    let Edited_Book_Reference = _prefixId.prefix "Edited-Book-Reference"
    let Editor = _prefixId.prefix "Editor"
    let Educational_Employee = _prefixId.prefix "Educational-Employee"
    let Educational_Organization = _prefixId.prefix "Educational-Organization"
    let Educational_Organization_Unit = _prefixId.prefix "Educational-Organization-Unit"
    let Email_Medium = _prefixId.prefix "Email-Medium"
    let Email_Message = _prefixId.prefix "Email-Message"
    let Employee = _prefixId.prefix "Employee"
    let Employment_Contract_Type = _prefixId.prefix "Employment-Contract-Type"
    /// <summary>
    ///   <para>rdfs:comment : This is a minimalist definition of class event.  We start with the very basic and we will then add slots as we specialise this definition for specific classes of events. The fillers of slots has-other-agents-involved and has-main-agent should not intersect^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Event">akt:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>rdfs:comment : This is an event in which the main agent (plus maybe others) goes from some place to another^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Event-Involving-Movement">akt:Event-Involving-Movement</a>
    /// </summary>
    let Event_Involving_Movement = _prefixId.prefix "Event-Involving-Movement"
    /// <summary>
    ///   <para>rdfs:comment : When something is produced^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Event-Involving-Production">akt:Event-Involving-Production</a>
    /// </summary>
    let Event_Involving_Production = _prefixId.prefix "Event-Involving-Production"
    let Experimental_Version = _prefixId.prefix "Experimental-Version"
    let Female_Gender = _prefixId.prefix "Female-Gender"
    let Financial_Award = _prefixId.prefix "Financial-Award"
    let Full_Time = _prefixId.prefix "Full-Time"
    /// <summary>
    ///   <para>rdfs:comment : HPKB says that genders are intangible..Uhm...^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Gender">akt:Gender</a>
    /// </summary>
    let Gender = _prefixId.prefix "Gender"

    /// <summary>
    ///   <para>rdfs:comment : This is a generic class to catch all sorts of borderline and metaphorical ways to carry things from A to B^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Generalised-Means-Of-Transport">akt:Generalised-Means-Of-Transport</a>
    /// </summary>
    let Generalised_Means_Of_Transport =
        _prefixId.prefix "Generalised-Means-Of-Transport"

    /// <summary>
    ///   <para>rdfs:comment : An event in which the main agent transfers something (the thing-acted-on, tangible or intangible) to one or more recipient agents. Note that we do not say anything about whether the original agent still retain the thing-acted-on.  In some cases this is clearly true ('I pass my wisdom on to my daughter'), in other cases it is not (I give you my wallet).^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Generalized-Transfer">akt:Generalized-Transfer</a>
    /// </summary>
    let Generalized_Transfer = _prefixId.prefix "Generalized-Transfer"
    /// <summary>
    ///   <para>rdfs:comment : This is a generic notion, an agent can be an organization, a person an animal, a software agent, etc^^xsd:string</para>
    ///   <para>rdfs:label : Generic Agent^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Generic-Agent">akt:Generic-Agent</a>
    /// </summary>
    let Generic_Agent = _prefixId.prefix "Generic-Agent"
    /// <summary>
    ///   <para>rdfs:comment : A generic class to specify generic areas for research or business initiatives. For instance, the area in which a project is situated^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Generic-Area-Of-Interest">akt:Generic-Area-Of-Interest</a>
    /// </summary>
    let Generic_Area_Of_Interest = _prefixId.prefix "Generic-Area-Of-Interest"
    /// <summary>
    ///   <para>rdfs:comment : 'Real' geographical regions^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Geographical-Region">akt:Geographical-Region</a>
    /// </summary>
    let Geographical_Region = _prefixId.prefix "Geographical-Region"
    /// <summary>
    ///   <para>rdfs:comment : A geopolitical entity is a geographical area which is associated with some sort of political structure. For instance, Russia, Italy, The-city-of-Messina, etc. A geopolitical entity can be also seen as an agent - e.g., France declared war to Spain^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Geopolitical-Entity">akt:Geopolitical-Entity</a>
    /// </summary>
    let Geopolitical_Entity = _prefixId.prefix "Geopolitical-Entity"
    let Giving_A_Talk = _prefixId.prefix "Giving-A-Talk"
    let Government = _prefixId.prefix "Government"
    let Government_Organization = _prefixId.prefix "Government-Organization"
    let Graphic_Designer = _prefixId.prefix "Graphic-Designer"
    let Hardware_Platform = _prefixId.prefix "Hardware-Platform"
    let Hardware_Technology = _prefixId.prefix "Hardware-Technology"

    let Higher_Educational_Organization =
        _prefixId.prefix "Higher-Educational-Organization"

    let Human_Computer_Interaction = _prefixId.prefix "Human-Computer-Interaction"
    let Hypermedia = _prefixId.prefix "Hypermedia"
    let Implemented_System = _prefixId.prefix "Implemented-System"
    let Incidental_KA = _prefixId.prefix "Incidental-KA"
    let Industrial_Organization = _prefixId.prefix "Industrial-Organization"
    /// <summary>
    ///   <para>rdfs:comment : This notion comes from Cyc.  It is useful to group together all information bearing entities, including video, audio and documents. An information bearing object may have an author (a generic agent) and may be owned by a legal agent. It is a tangible object^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Information-Bearing-Object">akt:Information-Bearing-Object</a>
    /// </summary>
    let Information_Bearing_Object = _prefixId.prefix "Information-Bearing-Object"
    let Information_Extraction = _prefixId.prefix "Information-Extraction"
    let Information_Retrieval = _prefixId.prefix "Information-Retrieval"
    /// <summary>
    ///   <para>rdfs:comment : A generalized transfer in which information is passed from main agent to one or more recipient agents.  Examples include giving a tutorial.^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Information-Transfer-Event">akt:Information-Transfer-Event</a>
    /// </summary>
    let Information_Transfer_Event = _prefixId.prefix "Information-Transfer-Event"
    let Information_Transfer_Medium = _prefixId.prefix "Information-Transfer-Medium"
    let Journal = _prefixId.prefix "Journal"
    let Knowledge_Acquisition = _prefixId.prefix "Knowledge-Acquisition"
    let Knowledge_Lifecycle = _prefixId.prefix "Knowledge-Lifecycle"
    let Knowledge_Maintenance = _prefixId.prefix "Knowledge-Maintenance"
    let Knowledge_Management = _prefixId.prefix "Knowledge-Management"
    let Knowledge_Modelling = _prefixId.prefix "Knowledge-Modelling"
    let Knowledge_Publishing = _prefixId.prefix "Knowledge-Publishing"
    let Knowledge_Retrieval = _prefixId.prefix "Knowledge-Retrieval"
    let Knowledge_Reuse = _prefixId.prefix "Knowledge-Reuse"
    let Lady = _prefixId.prefix "Lady"
    let Language_Engineering = _prefixId.prefix "Language-Engineering"
    let Learning_Centred_Organization = _prefixId.prefix "Learning-Centred-Organization"
    let Learning_Research_Area = _prefixId.prefix "Learning-Research-Area"
    let Lecturer_In_Academia = _prefixId.prefix "Lecturer-In-Academia"
    /// <summary>
    ///   <para>rdfs:comment : Some agents have legal status: definitely organizations and people, anybody else?^^xsd:string</para>
    ///   <para>rdfs:label : Legal Agent^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Legal-Agent">akt:Legal-Agent</a>
    /// </summary>
    let Legal_Agent = _prefixId.prefix "Legal-Agent"
    let Letter = _prefixId.prefix "Letter"
    let Local_District = _prefixId.prefix "Local-District"
    /// <summary>
    ///   <para>rdfs:comment : A generic class for locations.  It includes both real and fantastic places^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Location">akt:Location</a>
    /// </summary>
    let Location = _prefixId.prefix "Location"
    let MA = _prefixId.prefix "MA"
    let MSc = _prefixId.prefix "MSc"
    let Magazine = _prefixId.prefix "Magazine"
    let Male_Gender = _prefixId.prefix "Male-Gender"
    /// <summary>
    ///   <para>rdfs:comment : A meeting type of event. Note that both attendee and organizer have multiple cardinality^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Meeting-Taking-Place">akt:Meeting-Taking-Place</a>
    /// </summary>
    let Meeting_Taking_Place = _prefixId.prefix "Meeting-Taking-Place"
    let Message = _prefixId.prefix "Message"
    /// <summary>
    ///   <para>rdfs:comment : Merrian-Webster has a good set of definitions for a method. They say it is 'a systematic procedure, technique, or mode of inquiry employed by or proper to a particular discipline or art;  a systematic plan followed in presenting material for instruction; a way, technique, or process of or for doing something; a body of skills or techniques'. This is very much also what we mean by method.^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Method">akt:Method</a>
    /// </summary>
    let Method = _prefixId.prefix "Method"
    let Miss = _prefixId.prefix "Miss"
    let Mr = _prefixId.prefix "Mr"
    let Mrs = _prefixId.prefix "Mrs"
    let Ms = _prefixId.prefix "Ms"
    let Multimedia_Designer = _prefixId.prefix "Multimedia-Designer"
    let Multimedia_Research_Area = _prefixId.prefix "Multimedia-Research-Area"
    let Municipal_Unit = _prefixId.prefix "Municipal-Unit"
    let News_Item = _prefixId.prefix "News-Item"
    let Newspaper = _prefixId.prefix "Newspaper"
    let Non_Profit_Organization = _prefixId.prefix "Non-Profit-Organization"
    let Ontologies = _prefixId.prefix "Ontologies"
    let Operating_System = _prefixId.prefix "Operating-System"
    /// <summary>
    ///   <para>rdfs:comment : An organization is a type of legal agent^^xsd:string</para>
    ///   <para>rdfs:label : Organization^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Organization">akt:Organization</a>
    /// </summary>
    let Organization = _prefixId.prefix "Organization"
    /// <summary>
    ///   <para>rdfs:comment : We use EU guidelines to distinguish between different organization sizes^^xsd:string</para>
    ///   <para>rdfs:label : Organization Size^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Organization-Size">akt:Organization-Size</a>
    /// </summary>
    let Organization_Size = _prefixId.prefix "Organization-Size"
    /// <summary>
    ///   <para>rdfs:comment : An organization may have a number of units. Units may themselves have sub-units^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Organization-Unit">akt:Organization-Unit</a>
    /// </summary>
    let Organization_Unit = _prefixId.prefix "Organization-Unit"
    let Organizational_Learning = _prefixId.prefix "Organizational-Learning"
    let Part_Time = _prefixId.prefix "Part-Time"
    /// <summary>
    ///   <para>rdfs:comment : A partnership is not necessarily a company, e.g. a consultancy firm is not a company^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Partnership">akt:Partnership</a>
    /// </summary>
    let Partnership = _prefixId.prefix "Partnership"
    /// <summary>
    ///   <para>rdfs:comment : This comes from the ontolingua library. A periodical-publication is published regularly, such as once every week.  Strictly speaking, the noun 'periodical' is used by librarians to refer to things published at intervals of greater than a day.  We use the phase periodical-publication to include newspapers and other daily publications, since they share many bibliographic features. The periodicity indicates how often the publication comes out. Note that this is a duration, rather than a time interval. A time interval indicates a specific time interval on the time continuum, so we need to model periodicity as a time quantity^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Periodical-Publication">akt:Periodical-Publication</a>
    /// </summary>
    let Periodical_Publication = _prefixId.prefix "Periodical-Publication"
    let Permanent_Contract = _prefixId.prefix "Permanent-Contract"
    let Person = _prefixId.prefix "Person"
    let PhD = _prefixId.prefix "PhD"
    let PhD_Student = _prefixId.prefix "PhD-Student"
    /// <summary>
    ///   <para>rdfs:comment : An organization which has a political connotation^^xsd:string</para>
    ///   <para>rdfs:label : Political Organization^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Political-Organization">akt:Political-Organization</a>
    /// </summary>
    let Political_Organization = _prefixId.prefix "Political-Organization"
    /// <summary>
    ///   <para>rdfs:comment : Modified to allow addresses to be given as strings, with no structure^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Postal-Address">akt:Postal-Address</a>
    /// </summary>
    let Postal_Address = _prefixId.prefix "Postal-Address"
    let Private_Company = _prefixId.prefix "Private-Company"
    let Problem_Solving_Methods = _prefixId.prefix "Problem-Solving-Methods"
    let Proceedings_Paper_Reference = _prefixId.prefix "Proceedings-Paper-Reference"
    let Prof = _prefixId.prefix "Prof"
    let Professor_In_Academia = _prefixId.prefix "Professor-In-Academia"
    let Profit_Organization = _prefixId.prefix "Profit-Organization"
    let Programming_Environment = _prefixId.prefix "Programming-Environment"
    let Programming_Language = _prefixId.prefix "Programming-Language"
    let Project = _prefixId.prefix "Project"
    let Project_Officer_In_Academia = _prefixId.prefix "Project-Officer-In-Academia"
    let Public_Company = _prefixId.prefix "Public-Company"
    /// <summary>
    ///   <para>rdfs:comment : A publication is something which has one or more publication references. A publication can be both an article in a journal or a journal itself. The distinction between publication and publication-reference makes it possible to distinguish between multiple occurrences of the sam publication, for instance in different media^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Publication">akt:Publication</a>
    /// </summary>
    let Publication = _prefixId.prefix "Publication"
    /// <summary>
    ///   <para>rdfs:comment : we have decided that a publication reference is an intangible, abstract information^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Publication-Reference">akt:Publication-Reference</a>
    /// </summary>
    let Publication_Reference = _prefixId.prefix "Publication-Reference"
    let Publication_Type_Event = _prefixId.prefix "Publication-Type-Event"
    let Publishing_House = _prefixId.prefix "Publishing-House"
    let R_And_D_Institute = _prefixId.prefix "R-And-D-Institute"

    let R_And_D_Institute_Within_Larger_Institute =
        _prefixId.prefix "R-And-D-Institute-Within-Larger-Institute"

    let Reader_In_Academia = _prefixId.prefix "Reader-In-Academia"
    /// <summary>
    ///   <para>rdfs:comment : Any kind of recorded audio, which is tangible.  This also includes a audio file on a machine^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Recorded-Audio">akt:Recorded-Audio</a>
    /// </summary>
    let Recorded_Audio = _prefixId.prefix "Recorded-Audio"
    /// <summary>
    ///   <para>rdfs:comment : Any kind of recorded video, which is tangible.  This also includes a mpeg file on a machine^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Recorded-Video">akt:Recorded-Video</a>
    /// </summary>
    let Recorded_Video = _prefixId.prefix "Recorded-Video"
    let Released_Version = _prefixId.prefix "Released-Version"
    let Research_Area = _prefixId.prefix "Research-Area"

    let Research_Assistant_In_Academia =
        _prefixId.prefix "Research-Assistant-In-Academia"

    let Research_Fellow_In_Academia = _prefixId.prefix "Research-Fellow-In-Academia"
    let Researcher = _prefixId.prefix "Researcher"
    let Researcher_In_Academia = _prefixId.prefix "Researcher-In-Academia"
    let School = _prefixId.prefix "School"
    let Scripting_Language = _prefixId.prefix "Scripting-Language"
    let Secretary = _prefixId.prefix "Secretary"
    let Self_Employed_Person = _prefixId.prefix "Self-Employed-Person"
    let Semantic_Web_Area = _prefixId.prefix "Semantic-Web-Area"
    /// <summary>
    ///   <para>rdfs:comment : a generalized transfer in which information is passed from main agent to one or more recipient agents.  examples include giving a tutorial.^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Sending-An-Email">akt:Sending-An-Email</a>
    /// </summary>
    let Sending_An_Email = _prefixId.prefix "Sending-An-Email"
    let Senior_Lecturer_In_Academia = _prefixId.prefix "Senior-Lecturer-In-Academia"

    let Senior_Research_Fellow_In_Academia =
        _prefixId.prefix "Senior-Research-Fellow-In-Academia"

    /// <summary>
    ///   <para>rdfs:comment : This used to be called periodical publication.  However, many periodicals do not appear at fixed intervals, which is why librarians refer to them as serials. So, we now use the concept of serial publication and the has-periodicity slot has been removed^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Serial-Publication">akt:Serial-Publication</a>
    /// </summary>
    let Serial_Publication = _prefixId.prefix "Serial-Publication"
    let Sir = _prefixId.prefix "Sir"

    /// <summary>
    ///   <para>rdfs:comment : SME are important, so we define a class to represent them explicitly. In some case we might not know or we do not want to bother specifying excatly whether something is a small-organization or a medium-organization. Hence, we can just say 'x is a SME' without going into further detail.^^xsd:string</para>
    ///   <para>rdfs:label : Small or Medium-sized Organization^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Small-Or-Medium-Sized-Organization">akt:Small-Or-Medium-Sized-Organization</a>
    /// </summary>
    let Small_Or_Medium_Sized_Organization =
        _prefixId.prefix "Small-Or-Medium-Sized-Organization"

    let Social_Gathering = _prefixId.prefix "Social-Gathering"
    let Software_Status = _prefixId.prefix "Software-Status"
    let Software_Technology = _prefixId.prefix "Software-Technology"
    let Software_Visualization = _prefixId.prefix "Software-Visualization"
    let Specification_Language = _prefixId.prefix "Specification-Language"

    let Specification_Or_Computing_Language =
        _prefixId.prefix "Specification-Or-Computing-Language"

    let Student = _prefixId.prefix "Student"
    let System_Administrator = _prefixId.prefix "System-Administrator"
    let Technical_Report_Reference = _prefixId.prefix "Technical-Report-Reference"
    /// <summary>
    ///   <para>rdfs:comment : By technology we mean engineered applications of science. I guess we are probably confining ourselves to tangible things but as I am not sure I will use thing as the direct superclass - e.g., an algorithm is an intangible thing, but it could be seen as a technology, if we give a broad interpretation of the term^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Technology">akt:Technology</a>
    /// </summary>
    let Technology = _prefixId.prefix "Technology"
    let Telepresence_Research_Area = _prefixId.prefix "Telepresence-Research-Area"
    let Temporary_Contract = _prefixId.prefix "Temporary-Contract"
    let Thesis_Reference = _prefixId.prefix "Thesis-Reference"
    let Town = _prefixId.prefix "Town"
    /// <summary>
    ///   <para>rdfs:comment : Something tangible designed to transport people, animals, objects from A to B. For instance a bycicle, a car, a boat, etc.^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Transportation-Device">akt:Transportation-Device</a>
    /// </summary>
    let Transportation_Device = _prefixId.prefix "Transportation-Device"
    let University = _prefixId.prefix "University"
    let University_Faculty = _prefixId.prefix "University-Faculty"
    let Village = _prefixId.prefix "Village"
    let Visiting_Researcher = _prefixId.prefix "Visiting-Researcher"
    let Web_Based_Editor = _prefixId.prefix "Web-Based-Editor"
    /// <summary>
    ///   <para>rdfs:comment : A system which is accessible through the web^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Web-Based-System">akt:Web-Based-System</a>
    /// </summary>
    let Web_Based_System = _prefixId.prefix "Web-Based-System"
    /// <summary>
    ///   <para>rdfs:comment : A web browser is not a web-based system!^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#Web-Browser">akt:Web-Browser</a>
    /// </summary>
    let Web_Browser = _prefixId.prefix "Web-Browser"
    let Web_Reference = _prefixId.prefix "Web-Reference"
    let Web_Research_Area = _prefixId.prefix "Web-Research-Area"
    let Web_Site = _prefixId.prefix "Web-Site"
    let Work_Status = _prefixId.prefix "Work-Status"
    let Working_Person = _prefixId.prefix "Working-Person"
    let Workshop = _prefixId.prefix "Workshop"

    let Workshop_Proceedings_Reference =
        _prefixId.prefix "Workshop-Proceedings-Reference"

    let address_area = _prefixId.prefix "address-area"
    let address_building = _prefixId.prefix "address-building"
    let address_city_or_village = _prefixId.prefix "address-city-or-village"
    let address_country = _prefixId.prefix "address-country"
    let address_number = _prefixId.prefix "address-number"
    let address_postcode = _prefixId.prefix "address-postcode"
    let address_pretty_label = _prefixId.prefix "address-pretty-label"
    let address_region = _prefixId.prefix "address-region"
    let address_street = _prefixId.prefix "address-street"

    let addresses_generic_area_of_interest =
        _prefixId.prefix "addresses-generic-area-of-interest"

    let affiliated_people = _prefixId.prefix "affiliated-people"
    let affiliated_person = _prefixId.prefix "affiliated-person"
    let cites_publication_reference = _prefixId.prefix "cites-publication-reference"
    let confers_award = _prefixId.prefix "confers-award"
    let contains_article = _prefixId.prefix "contains-article"
    let contains_news_item = _prefixId.prefix "contains-news-item"
    let contains_property = _prefixId.prefix "contains-property"
    let contains_publication = _prefixId.prefix "contains-publication"
    let edited_by = _prefixId.prefix "edited-by"
    let event_attended = _prefixId.prefix "event-attended"
    let event_product = _prefixId.prefix "event-product"
    let family_name = _prefixId.prefix "family-name"
    let full_name = _prefixId.prefix "full-name"
    let funding_source = _prefixId.prefix "funding-source"
    let given_name = _prefixId.prefix "given-name"
    let government_of_country = _prefixId.prefix "government-of-country"
    let has_ISBN_number = _prefixId.prefix "has-ISBN-number"
    let has_URL = _prefixId.prefix "has-URL"
    let has_academic_degree = _prefixId.prefix "has-academic-degree"
    let has_academic_unit = _prefixId.prefix "has-academic-unit"
    let has_affiliation = _prefixId.prefix "has-affiliation"
    let has_affiliation_to_unit = _prefixId.prefix "has-affiliation-to-unit"
    let has_amount = _prefixId.prefix "has-amount"
    let has_appellation = _prefixId.prefix "has-appellation"
    let has_author = _prefixId.prefix "has-author"
    let has_award_rationale = _prefixId.prefix "has-award-rationale"
    let has_awarding_body = _prefixId.prefix "has-awarding-body"
    let has_capital = _prefixId.prefix "has-capital"
    let has_contract_type = _prefixId.prefix "has-contract-type"
    let has_currency = _prefixId.prefix "has-currency"
    let has_date = _prefixId.prefix "has-date"
    /// <summary>
    ///   <para>rdfs:label : has email address^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#has-email-address">akt:has-email-address</a>
    /// </summary>
    let has_email_address = _prefixId.prefix "has-email-address"
    let has_faculty = _prefixId.prefix "has-faculty"
    let has_fax_number = _prefixId.prefix "has-fax-number"
    let has_gender = _prefixId.prefix "has-gender"
    let has_goals = _prefixId.prefix "has-goals"
    let has_government = _prefixId.prefix "has-government"
    let has_job_title = _prefixId.prefix "has-job-title"
    let has_leading_organization = _prefixId.prefix "has-leading-organization"
    /// <summary>
    ///   <para>rdfs:comment : The location at which an event takes place^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#has-location">akt:has-location</a>
    /// </summary>
    let has_location = _prefixId.prefix "has-location"
    /// <summary>
    ///   <para>rdfs:comment : The agents causing the event to happen, if they are known.^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#has-main-agent">akt:has-main-agent</a>
    /// </summary>
    let has_main_agent = _prefixId.prefix "has-main-agent"
    /// <summary>
    ///   <para>rdfs:comment : Other agents involved in the event^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#has-other-agents-involved">akt:has-other-agents-involved</a>
    /// </summary>
    let has_other_agents_involved = _prefixId.prefix "has-other-agents-involved"
    let has_page_numbers = _prefixId.prefix "has-page-numbers"
    let has_periodicity = _prefixId.prefix "has-periodicity"
    let has_place_of_publication = _prefixId.prefix "has-place-of-publication"
    let has_postal_address = _prefixId.prefix "has-postal-address"
    let has_project_leader = _prefixId.prefix "has-project-leader"
    let has_project_member = _prefixId.prefix "has-project-member"
    let has_publication_reference = _prefixId.prefix "has-publication-reference"
    /// <summary>
    ///   <para>rdfs:comment : People and in general even organizations and organization units may have research interests.  This relation shoudl be used to specify them^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#has-research-interest">akt:has-research-interest</a>
    /// </summary>
    let has_research_interest = _prefixId.prefix "has-research-interest"
    let has_size = _prefixId.prefix "has-size"
    let has_speaker = _prefixId.prefix "has-speaker"
    /// <summary>
    ///   <para>rdfs:comment : Whether the software is released, alpha or beta^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#has-status">akt:has-status</a>
    /// </summary>
    let has_status = _prefixId.prefix "has-status"
    let has_sub_activity = _prefixId.prefix "has-sub-activity"
    let has_sub_unit = _prefixId.prefix "has-sub-unit"
    let has_supervisor = _prefixId.prefix "has-supervisor"
    let has_support_unit = _prefixId.prefix "has-support-unit"
    let has_telephone_number = _prefixId.prefix "has-telephone-number"
    let has_title = _prefixId.prefix "has-title"
    let has_vice_chancellor = _prefixId.prefix "has-vice-chancellor"
    /// <summary>
    ///   <para>rdfs:label : has web address^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#has-web-address">akt:has-web-address</a>
    /// </summary>
    let has_web_address = _prefixId.prefix "has-web-address"
    let headed_by = _prefixId.prefix "headed-by"
    let included_in_publication = _prefixId.prefix "included-in-publication"
    let information_being_transferred = _prefixId.prefix "information-being-transferred"

    let information_object_being_transferred =
        _prefixId.prefix "information-object-being-transferred"

    let information_transfer_medium_used =
        _prefixId.prefix "information-transfer-medium-used"

    let involves_organization = _prefixId.prefix "involves-organization"
    let is_capital_of = _prefixId.prefix "is-capital-of"
    let issued_by = _prefixId.prefix "issued-by"
    let large_size = _prefixId.prefix "large-size"
    let location_at_end = _prefixId.prefix "location-at-end"
    let location_at_start = _prefixId.prefix "location-at-start"
    let means_of_transport_used = _prefixId.prefix "means-of-transport-used"
    let medium_size = _prefixId.prefix "medium-size"
    let meeting_attendee = _prefixId.prefix "meeting-attendee"
    let meeting_organizer = _prefixId.prefix "meeting-organizer"
    let method_builds_on = _prefixId.prefix "method-builds-on"
    let micro_size = _prefixId.prefix "micro-size"
    let organization_being_visited = _prefixId.prefix "organization-being-visited"
    let organization_part_of = _prefixId.prefix "organization-part-of"

    let organization_unit_being_visited =
        _prefixId.prefix "organization-unit-being-visited"

    let owned_by = _prefixId.prefix "owned-by"
    let person_being_visited = _prefixId.prefix "person-being-visited"
    let produces_output = _prefixId.prefix "produces-output"

    /// <summary>
    ///   <para>rdfs:comment : It is sufficient that somebody in unit ?u works in project ?p^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#project-involves-organization-unit">akt:project-involves-organization-unit</a>
    /// </summary>
    let project_involves_organization_unit =
        _prefixId.prefix "project-involves-organization-unit"

    let published_book = _prefixId.prefix "published-book"
    let published_by = _prefixId.prefix "published-by"
    let published_proceedings = _prefixId.prefix "published-proceedings"
    /// <summary>
    ///   <para>rdfs:comment : The agents which receive the thing-acted-on^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#recipient-agents">akt:recipient-agents</a>
    /// </summary>
    let recipient_agents = _prefixId.prefix "recipient-agents"
    let recipient_of_message = _prefixId.prefix "recipient-of-message"
    let requires_hardware_platform = _prefixId.prefix "requires-hardware-platform"

    let requires_hardware_platform_on_client_side =
        _prefixId.prefix "requires-hardware-platform-on-client-side"

    let requires_hardware_platform_on_server_side =
        _prefixId.prefix "requires-hardware-platform-on-server-side"

    let requires_software_technology = _prefixId.prefix "requires-software-technology"

    let requires_software_technology_on_client_side =
        _prefixId.prefix "requires-software-technology-on-client-side"

    let requires_software_technology_on_server_side =
        _prefixId.prefix "requires-software-technology-on-server-side"

    let runs_on_operating_system = _prefixId.prefix "runs-on-operating-system"

    let runs_on_operating_system_on_client_side =
        _prefixId.prefix "runs-on-operating-system-on-client-side"

    let runs_on_operating_system_on_server_side =
        _prefixId.prefix "runs-on-operating-system-on-server-side"

    let sender_of_information = _prefixId.prefix "sender-of-information"
    let sender_of_message = _prefixId.prefix "sender-of-message"
    let small_size = _prefixId.prefix "small-size"
    let studies_at = _prefixId.prefix "studies-at"
    let studies_in_unit = _prefixId.prefix "studies-in-unit"
    let sub_area_of = _prefixId.prefix "sub-area-of"
    let sub_unit_of_organization_unit = _prefixId.prefix "sub-unit-of-organization-unit"
    let subsidiary_of = _prefixId.prefix "subsidiary-of"
    let supports_language = _prefixId.prefix "supports-language"
    let supports_method = _prefixId.prefix "supports-method"
    let technology_builds_on = _prefixId.prefix "technology-builds-on"
    /// <summary>
    ///   <para>rdfs:comment : What is being transferred^^xsd:string</para>
    ///   <a href="http://www.aktors.org/ontology/portal#thing-acted-on">akt:thing-acted-on</a>
    /// </summary>
    let thing_acted_on = _prefixId.prefix "thing-acted-on"
    let time_of_message = _prefixId.prefix "time-of-message"
    let unit_of_organization = _prefixId.prefix "unit-of-organization"
    let uses_resource = _prefixId.prefix "uses-resource"
    let very_large_size = _prefixId.prefix "very-large-size"
    let works_for = _prefixId.prefix "works-for"
    let works_in_unit = _prefixId.prefix "works-in-unit"
