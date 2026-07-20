namespace http.www.aktors.org.ontology.portal.hash

open DoxAletheia

module akt =
    let _namespace_name = "http://www.aktors.org/ontology/portal#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Information in general, independent of an object in which it is encoded. Whatever is transferred in an information-transfer event. It is clearly an intangible thing
    /// <see href="http://www.aktors.org/ontology/portal#Abstract-Information"></see></summary>
    let ``Abstract-Information`` = _prefix "Abstract-Information"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Academic"></see>
    /// </summary>
    let Academic = _prefix "Academic"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Higher-Educational-Organization"></see>
    /// </summary>
    let ``Higher-Educational-Organization`` = _prefix "Higher-Educational-Organization"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#works-for"></see>
    /// </summary>
    let ``works-for`` = _prefix "works-for"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Educational-Employee"></see>
    /// </summary>
    let ``Educational-Employee`` = _prefix "Educational-Employee"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Academic-Degree"></see>
    /// </summary>
    let ``Academic-Degree`` = _prefix "Academic-Degree"
    /// <summary>
    /// A degree is type of award
    /// <see href="http://www.aktors.org/ontology/portal#Degree"></see></summary>
    let Degree = _prefix "Degree"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Academic-Support-Staff"></see>
    /// </summary>
    let ``Academic-Support-Staff`` = _prefix "Academic-Support-Staff"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Academic-Support-Unit"></see>
    /// </summary>
    let ``Academic-Support-Unit`` = _prefix "Academic-Support-Unit"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Educational-Organization-Unit"></see>
    /// </summary>
    let ``Educational-Organization-Unit`` = _prefix "Educational-Organization-Unit"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Academic-Unit"></see>
    /// </summary>
    let ``Academic-Unit`` = _prefix "Academic-Unit"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#University"></see>
    /// </summary>
    let University = _prefix "University"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#unit-of-organization"></see>
    /// </summary>
    let ``unit-of-organization`` = _prefix "unit-of-organization"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Activity"></see>
    /// </summary>
    let Activity = _prefix "Activity"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Adaptive-Hypermedia"></see>
    /// </summary>
    let ``Adaptive-Hypermedia`` = _prefix "Adaptive-Hypermedia"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#sub-area-of"></see>
    /// </summary>
    let ``sub-area-of`` = _prefix "sub-area-of"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Hypermedia"></see>
    /// </summary>
    let Hypermedia = _prefix "Hypermedia"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Research-Area"></see>
    /// </summary>
    let ``Research-Area`` = _prefix "Research-Area"
    /// <summary>
    /// A generic class for addresses, whether email or postal. We see an address as abstract information and therefore it is an intangible thing
    /// <see href="http://www.aktors.org/ontology/portal#Address"></see></summary>
    let Address = _prefix "Address"
    /// <summary>
    /// A person which has an affiliation with some organization. For instance employees are affiliated to the organization they work for, students to the institution where they are studying, etc. A person can have multiple affiliations, which means that there is no constraint relating the values of slot has-affiliation-to-unit to the values of slot has-affiliation
    /// <see href="http://www.aktors.org/ontology/portal#Affiliated-Person"></see></summary>
    let ``Affiliated-Person`` = _prefix "Affiliated-Person"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-affiliation"></see>
    /// </summary>
    let ``has-affiliation`` = _prefix "has-affiliation"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Person"></see>
    /// </summary>
    let Person = _prefix "Person"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Agent-Based-Computing"></see>
    /// </summary>
    let ``Agent-Based-Computing`` = _prefix "Agent-Based-Computing"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Alpha-Version"></see>
    /// </summary>
    let ``Alpha-Version`` = _prefix "Alpha-Version"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Software-Status"></see>
    /// </summary>
    let ``Software-Status`` = _prefix "Software-Status"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Amount-Of-Money"></see>
    /// </summary>
    let ``Amount-Of-Money`` = _prefix "Amount-Of-Money"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Currency"></see>
    /// </summary>
    let Currency = _prefix "Currency"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Appellation"></see>
    /// </summary>
    let Appellation = _prefix "Appellation"

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Article-In-A-Composite-Publication"></see>
    /// </summary>
    let ``Article-In-A-Composite-Publication`` =
        _prefix "Article-In-A-Composite-Publication"

    /// <summary>
    /// A publication which contains items which cane be themselves referenced through a publication reference.  Composite publications include newspapers, magazines and journals. A book which is a collection of articles is a composite publication, a monograph is not
    /// <see href="http://www.aktors.org/ontology/portal#Composite-Publication"></see></summary>
    let ``Composite-Publication`` = _prefix "Composite-Publication"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#included-in-publication"></see>
    /// </summary>
    let ``included-in-publication`` = _prefix "included-in-publication"
    /// <summary>
    /// A publication is something which has one or more publication references. A publication can be both an article in a journal or a journal itself. The distinction between publication and publication-reference makes it possible to distinguish between multiple occurrences of the sam publication, for instance in different media
    /// <see href="http://www.aktors.org/ontology/portal#Publication"></see></summary>
    let Publication = _prefix "Publication"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Article-Reference"></see>
    /// </summary>
    let ``Article-Reference`` = _prefix "Article-Reference"
    /// <summary>
    /// we have decided that a publication reference is an intangible, abstract information
    /// <see href="http://www.aktors.org/ontology/portal#Publication-Reference"></see></summary>
    let ``Publication-Reference`` = _prefix "Publication-Reference"

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Artificial-Intelligence-Research-Area"></see>
    /// </summary>
    let ``Artificial-Intelligence-Research-Area`` =
        _prefix "Artificial-Intelligence-Research-Area"

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Attending-A-Conference"></see>
    /// </summary>
    let ``Attending-A-Conference`` = _prefix "Attending-A-Conference"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Conference"></see>
    /// </summary>
    let Conference = _prefix "Conference"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#event-attended"></see>
    /// </summary>
    let ``event-attended`` = _prefix "event-attended"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Attending-An-Event"></see>
    /// </summary>
    let ``Attending-An-Event`` = _prefix "Attending-An-Event"
    /// <summary>
    /// This is a minimalist definition of class event.  We start with the very basic and we will then add slots as we specialise this definition for specific classes of events. The fillers of slots has-other-agents-involved and has-main-agent should not intersect
    /// <see href="http://www.aktors.org/ontology/portal#Event"></see></summary>
    let Event = _prefix "Event"
    /// <summary>
    /// An award is an intangible thing, even if the piece of paper which is often associated with an award is tangible.  What about the virtual piece of paper in the virtual degree ceremony?  I guess that ought to be an intangible
    /// <see href="http://www.aktors.org/ontology/portal#Award"></see></summary>
    let Award = _prefix "Award"
    /// <summary>
    /// Legal agents can be either organizations or people. An awarding body is normally an organization, an individual, or a bunch of people
    /// <see href="http://www.aktors.org/ontology/portal#Awarding-Body"></see></summary>
    let ``Awarding-Body`` = _prefix "Awarding-Body"
    /// <summary>
    /// Some agents have legal status: definitely organizations and people, anybody else?
    /// <see href="http://www.aktors.org/ontology/portal#Legal-Agent"></see></summary>
    let ``Legal-Agent`` = _prefix "Legal-Agent"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#BA"></see>
    /// </summary>
    let BA = _prefix "BA"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#BSc"></see>
    /// </summary>
    let BSc = _prefix "BSc"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Beta-Version"></see>
    /// </summary>
    let ``Beta-Version`` = _prefix "Beta-Version"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Book"></see>
    /// </summary>
    let Book = _prefix "Book"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-publication-reference"></see>
    /// </summary>
    let ``has-publication-reference`` = _prefix "has-publication-reference"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Book-Reference"></see>
    /// </summary>
    let ``Book-Reference`` = _prefix "Book-Reference"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Book-Publishing"></see>
    /// </summary>
    let ``Book-Publishing`` = _prefix "Book-Publishing"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Publication-Type-Event"></see>
    /// </summary>
    let ``Publication-Type-Event`` = _prefix "Publication-Type-Event"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Publishing-House"></see>
    /// </summary>
    let ``Publishing-House`` = _prefix "Publishing-House"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#published-by"></see>
    /// </summary>
    let ``published-by`` = _prefix "published-by"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Book-Section-Reference"></see>
    /// </summary>
    let ``Book-Section-Reference`` = _prefix "Book-Section-Reference"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Broken-Version"></see>
    /// </summary>
    let ``Broken-Version`` = _prefix "Broken-Version"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Business-Area"></see>
    /// </summary>
    let ``Business-Area`` = _prefix "Business-Area"
    /// <summary>
    /// A generic class to specify generic areas for research or business initiatives. For instance, the area in which a project is situated
    /// <see href="http://www.aktors.org/ontology/portal#Generic-Area-Of-Interest"></see></summary>
    let ``Generic-Area-Of-Interest`` = _prefix "Generic-Area-Of-Interest"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Capital-City"></see>
    /// </summary>
    let ``Capital-City`` = _prefix "Capital-City"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#City"></see>
    /// </summary>
    let City = _prefix "City"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Charitable-Organization"></see>
    /// </summary>
    let ``Charitable-Organization`` = _prefix "Charitable-Organization"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Non-Profit-Organization"></see>
    /// </summary>
    let ``Non-Profit-Organization`` = _prefix "Non-Profit-Organization"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Municipal-Unit"></see>
    /// </summary>
    let ``Municipal-Unit`` = _prefix "Municipal-Unit"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Civil-Service"></see>
    /// </summary>
    let ``Civil-Service`` = _prefix "Civil-Service"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Government-Organization"></see>
    /// </summary>
    let ``Government-Organization`` = _prefix "Government-Organization"

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Cognitive-Modelling-Research-Area"></see>
    /// </summary>
    let ``Cognitive-Modelling-Research-Area`` =
        _prefix "Cognitive-Modelling-Research-Area"

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Collaborative-Hypermedia"></see>
    /// </summary>
    let ``Collaborative-Hypermedia`` = _prefix "Collaborative-Hypermedia"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Company"></see>
    /// </summary>
    let Company = _prefix "Company"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Profit-Organization"></see>
    /// </summary>
    let ``Profit-Organization`` = _prefix "Profit-Organization"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#contains-publication"></see>
    /// </summary>
    let ``contains-publication`` = _prefix "contains-publication"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Computing-Research-Area"></see>
    /// </summary>
    let ``Computing-Research-Area`` = _prefix "Computing-Research-Area"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Computing-Technology"></see>
    /// </summary>
    let ``Computing-Technology`` = _prefix "Computing-Technology"
    /// <summary>
    /// By technology we mean engineered applications of science. I guess we are probably confining ourselves to tangible things but as I am not sure I will use thing as the direct superclass - e.g., an algorithm is an intangible thing, but it could be seen as a technology, if we give a broad interpretation of the term
    /// <see href="http://www.aktors.org/ontology/portal#Technology"></see></summary>
    let Technology = _prefix "Technology"

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Conference-Proceedings-Reference"></see>
    /// </summary>
    let ``Conference-Proceedings-Reference`` =
        _prefix "Conference-Proceedings-Reference"

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#published-proceedings"></see>
    /// </summary>
    let ``published-proceedings`` = _prefix "published-proceedings"
    /// <summary>
    /// A meeting type of event. Note that both attendee and organizer have multiple cardinality
    /// <see href="http://www.aktors.org/ontology/portal#Meeting-Taking-Place"></see></summary>
    let ``Meeting-Taking-Place`` = _prefix "Meeting-Taking-Place"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Conferring-An-Award"></see>
    /// </summary>
    let ``Conferring-An-Award`` = _prefix "Conferring-An-Award"
    /// <summary>
    /// An event in which the main agent transfers something (the thing-acted-on, tangible or intangible) to one or more recipient agents. Note that we do not say anything about whether the original agent still retain the thing-acted-on.  In some cases this is clearly true ('I pass my wisdom on to my daughter'), in other cases it is not (I give you my wallet).
    /// <see href="http://www.aktors.org/ontology/portal#Generalized-Transfer"></see></summary>
    let ``Generalized-Transfer`` = _prefix "Generalized-Transfer"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Country"></see>
    /// </summary>
    let Country = _prefix "Country"
    /// <summary>
    /// A geopolitical entity is a geographical area which is associated with some sort of political structure. For instance, Russia, Italy, The-city-of-Messina, etc. A geopolitical entity can be also seen as an agent - e.g., France declared war to Spain
    /// <see href="http://www.aktors.org/ontology/portal#Geopolitical-Entity"></see></summary>
    let ``Geopolitical-Entity`` = _prefix "Geopolitical-Entity"
    /// <summary>
    /// This notion comes from Cyc.  It is useful to group together all information bearing entities, including video, audio and documents. An information bearing object may have an author (a generic agent) and may be owned by a legal agent. It is a tangible object
    /// <see href="http://www.aktors.org/ontology/portal#Information-Bearing-Object"></see></summary>
    let ``Information-Bearing-Object`` = _prefix "Information-Bearing-Object"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#DEng"></see>
    /// </summary>
    let DEng = _prefix "DEng"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Daily-Newspaper"></see>
    /// </summary>
    let ``Daily-Newspaper`` = _prefix "Daily-Newspaper"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-periodicity"></see>
    /// </summary>
    let ``has-periodicity`` = _prefix "has-periodicity"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Newspaper"></see>
    /// </summary>
    let Newspaper = _prefix "Newspaper"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Distance-Teaching-University"></see>
    /// </summary>
    let ``Distance-Teaching-University`` = _prefix "Distance-Teaching-University"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Dr"></see>
    /// </summary>
    let Dr = _prefix "Dr"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Dynamic-Linking"></see>
    /// </summary>
    let ``Dynamic-Linking`` = _prefix "Dynamic-Linking"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#E-Commerce-Research-Area"></see>
    /// </summary>
    let ``E-Commerce-Research-Area`` = _prefix "E-Commerce-Research-Area"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Edited-Book"></see>
    /// </summary>
    let ``Edited-Book`` = _prefix "Edited-Book"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Edited-Book-Reference"></see>
    /// </summary>
    let ``Edited-Book-Reference`` = _prefix "Edited-Book-Reference"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#edited-by"></see>
    /// </summary>
    let ``edited-by`` = _prefix "edited-by"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Editor"></see>
    /// </summary>
    let Editor = _prefix "Editor"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Implemented-System"></see>
    /// </summary>
    let ``Implemented-System`` = _prefix "Implemented-System"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Educational-Organization"></see>
    /// </summary>
    let ``Educational-Organization`` = _prefix "Educational-Organization"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Employee"></see>
    /// </summary>
    let Employee = _prefix "Employee"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Learning-Centred-Organization"></see>
    /// </summary>
    let ``Learning-Centred-Organization`` = _prefix "Learning-Centred-Organization"
    /// <summary>
    /// An organization may have a number of units. Units may themselves have sub-units
    /// <see href="http://www.aktors.org/ontology/portal#Organization-Unit"></see></summary>
    let ``Organization-Unit`` = _prefix "Organization-Unit"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Email-Medium"></see>
    /// </summary>
    let ``Email-Medium`` = _prefix "Email-Medium"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Information-Transfer-Medium"></see>
    /// </summary>
    let ``Information-Transfer-Medium`` = _prefix "Information-Transfer-Medium"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Email-Message"></see>
    /// </summary>
    let ``Email-Message`` = _prefix "Email-Message"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Message"></see>
    /// </summary>
    let Message = _prefix "Message"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Working-Person"></see>
    /// </summary>
    let ``Working-Person`` = _prefix "Working-Person"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Employment-Contract-Type"></see>
    /// </summary>
    let ``Employment-Contract-Type`` = _prefix "Employment-Contract-Type"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Permanent-Contract"></see>
    /// </summary>
    let ``Permanent-Contract`` = _prefix "Permanent-Contract"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Temporary-Contract"></see>
    /// </summary>
    let ``Temporary-Contract`` = _prefix "Temporary-Contract"
    /// <summary>
    /// This is an event in which the main agent (plus maybe others) goes from some place to another
    /// <see href="http://www.aktors.org/ontology/portal#Event-Involving-Movement"></see></summary>
    let ``Event-Involving-Movement`` = _prefix "Event-Involving-Movement"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#location-at-end"></see>
    /// </summary>
    let ``location-at-end`` = _prefix "location-at-end"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#location-at-start"></see>
    /// </summary>
    let ``location-at-start`` = _prefix "location-at-start"
    /// <summary>
    /// When something is produced
    /// <see href="http://www.aktors.org/ontology/portal#Event-Involving-Production"></see></summary>
    let ``Event-Involving-Production`` = _prefix "Event-Involving-Production"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Experimental-Version"></see>
    /// </summary>
    let ``Experimental-Version`` = _prefix "Experimental-Version"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Female-Gender"></see>
    /// </summary>
    let ``Female-Gender`` = _prefix "Female-Gender"
    /// <summary>
    /// HPKB says that genders are intangible..Uhm...
    /// <see href="http://www.aktors.org/ontology/portal#Gender"></see></summary>
    let Gender = _prefix "Gender"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Financial-Award"></see>
    /// </summary>
    let ``Financial-Award`` = _prefix "Financial-Award"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Full-Time"></see>
    /// </summary>
    let ``Full-Time`` = _prefix "Full-Time"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Work-Status"></see>
    /// </summary>
    let ``Work-Status`` = _prefix "Work-Status"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Male-Gender"></see>
    /// </summary>
    let ``Male-Gender`` = _prefix "Male-Gender"
    /// <summary>
    /// This is a generic class to catch all sorts of borderline and metaphorical ways to carry things from A to B
    /// <see href="http://www.aktors.org/ontology/portal#Generalised-Means-Of-Transport"></see></summary>
    let ``Generalised-Means-Of-Transport`` = _prefix "Generalised-Means-Of-Transport"
    /// <summary>
    /// This is a generic notion, an agent can be an organization, a person an animal, a software agent, etc
    /// <see href="http://www.aktors.org/ontology/portal#Generic-Agent"></see></summary>
    let ``Generic-Agent`` = _prefix "Generic-Agent"
    /// <summary>
    /// 'Real' geographical regions
    /// <see href="http://www.aktors.org/ontology/portal#Geographical-Region"></see></summary>
    let ``Geographical-Region`` = _prefix "Geographical-Region"
    /// <summary>
    /// A generic class for locations.  It includes both real and fantastic places
    /// <see href="http://www.aktors.org/ontology/portal#Location"></see></summary>
    let Location = _prefix "Location"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Giving-A-Talk"></see>
    /// </summary>
    let ``Giving-A-Talk`` = _prefix "Giving-A-Talk"
    /// <summary>
    /// A generalized transfer in which information is passed from main agent to one or more recipient agents.  Examples include giving a tutorial.
    /// <see href="http://www.aktors.org/ontology/portal#Information-Transfer-Event"></see></summary>
    let ``Information-Transfer-Event`` = _prefix "Information-Transfer-Event"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Government"></see>
    /// </summary>
    let Government = _prefix "Government"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Graphic-Designer"></see>
    /// </summary>
    let ``Graphic-Designer`` = _prefix "Graphic-Designer"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Hardware-Platform"></see>
    /// </summary>
    let ``Hardware-Platform`` = _prefix "Hardware-Platform"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Hardware-Technology"></see>
    /// </summary>
    let ``Hardware-Technology`` = _prefix "Hardware-Technology"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Human-Computer-Interaction"></see>
    /// </summary>
    let ``Human-Computer-Interaction`` = _prefix "Human-Computer-Interaction"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Software-Technology"></see>
    /// </summary>
    let ``Software-Technology`` = _prefix "Software-Technology"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Incidental-KA"></see>
    /// </summary>
    let ``Incidental-KA`` = _prefix "Incidental-KA"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Knowledge-Acquisition"></see>
    /// </summary>
    let ``Knowledge-Acquisition`` = _prefix "Knowledge-Acquisition"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Industrial-Organization"></see>
    /// </summary>
    let ``Industrial-Organization`` = _prefix "Industrial-Organization"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#owned-by"></see>
    /// </summary>
    let ``owned-by`` = _prefix "owned-by"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-author"></see>
    /// </summary>
    let ``has-author`` = _prefix "has-author"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Information-Extraction"></see>
    /// </summary>
    let ``Information-Extraction`` = _prefix "Information-Extraction"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Language-Engineering"></see>
    /// </summary>
    let ``Language-Engineering`` = _prefix "Language-Engineering"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Information-Retrieval"></see>
    /// </summary>
    let ``Information-Retrieval`` = _prefix "Information-Retrieval"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Journal"></see>
    /// </summary>
    let Journal = _prefix "Journal"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#contains-article"></see>
    /// </summary>
    let ``contains-article`` = _prefix "contains-article"
    /// <summary>
    /// This used to be called periodical publication.  However, many periodicals do not appear at fixed intervals, which is why librarians refer to them as serials. So, we now use the concept of serial publication and the has-periodicity slot has been removed
    /// <see href="http://www.aktors.org/ontology/portal#Serial-Publication"></see></summary>
    let ``Serial-Publication`` = _prefix "Serial-Publication"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Magazine"></see>
    /// </summary>
    let Magazine = _prefix "Magazine"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Knowledge-Management"></see>
    /// </summary>
    let ``Knowledge-Management`` = _prefix "Knowledge-Management"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Knowledge-Lifecycle"></see>
    /// </summary>
    let ``Knowledge-Lifecycle`` = _prefix "Knowledge-Lifecycle"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Knowledge-Maintenance"></see>
    /// </summary>
    let ``Knowledge-Maintenance`` = _prefix "Knowledge-Maintenance"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Knowledge-Modelling"></see>
    /// </summary>
    let ``Knowledge-Modelling`` = _prefix "Knowledge-Modelling"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Knowledge-Publishing"></see>
    /// </summary>
    let ``Knowledge-Publishing`` = _prefix "Knowledge-Publishing"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Knowledge-Retrieval"></see>
    /// </summary>
    let ``Knowledge-Retrieval`` = _prefix "Knowledge-Retrieval"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Knowledge-Reuse"></see>
    /// </summary>
    let ``Knowledge-Reuse`` = _prefix "Knowledge-Reuse"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Lady"></see>
    /// </summary>
    let Lady = _prefix "Lady"
    /// <summary>
    /// An organization is a type of legal agent
    /// <see href="http://www.aktors.org/ontology/portal#Organization"></see></summary>
    let Organization = _prefix "Organization"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Learning-Research-Area"></see>
    /// </summary>
    let ``Learning-Research-Area`` = _prefix "Learning-Research-Area"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Lecturer-In-Academia"></see>
    /// </summary>
    let ``Lecturer-In-Academia`` = _prefix "Lecturer-In-Academia"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Letter"></see>
    /// </summary>
    let Letter = _prefix "Letter"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Local-District"></see>
    /// </summary>
    let ``Local-District`` = _prefix "Local-District"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#MA"></see>
    /// </summary>
    let MA = _prefix "MA"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#MSc"></see>
    /// </summary>
    let MSc = _prefix "MSc"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Social-Gathering"></see>
    /// </summary>
    let ``Social-Gathering`` = _prefix "Social-Gathering"
    /// <summary>
    /// Merrian-Webster has a good set of definitions for a method. They say it is 'a systematic procedure, technique, or mode of inquiry employed by or proper to a particular discipline or art;  a systematic plan followed in presenting material for instruction; a way, technique, or process of or for doing something; a body of skills or techniques'. This is very much also what we mean by method.
    /// <see href="http://www.aktors.org/ontology/portal#Method"></see></summary>
    let Method = _prefix "Method"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Miss"></see>
    /// </summary>
    let Miss = _prefix "Miss"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Mr"></see>
    /// </summary>
    let Mr = _prefix "Mr"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Mrs"></see>
    /// </summary>
    let Mrs = _prefix "Mrs"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Ms"></see>
    /// </summary>
    let Ms = _prefix "Ms"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Multimedia-Designer"></see>
    /// </summary>
    let ``Multimedia-Designer`` = _prefix "Multimedia-Designer"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Multimedia-Research-Area"></see>
    /// </summary>
    let ``Multimedia-Research-Area`` = _prefix "Multimedia-Research-Area"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#News-Item"></see>
    /// </summary>
    let ``News-Item`` = _prefix "News-Item"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#contains-news-item"></see>
    /// </summary>
    let ``contains-news-item`` = _prefix "contains-news-item"
    /// <summary>
    /// This comes from the ontolingua library. A periodical-publication is published regularly, such as once every week.  Strictly speaking, the noun 'periodical' is used by librarians to refer to things published at intervals of greater than a day.  We use the phase periodical-publication to include newspapers and other daily publications, since they share many bibliographic features. The periodicity indicates how often the publication comes out. Note that this is a duration, rather than a time interval. A time interval indicates a specific time interval on the time continuum, so we need to model periodicity as a time quantity
    /// <see href="http://www.aktors.org/ontology/portal#Periodical-Publication"></see></summary>
    let ``Periodical-Publication`` = _prefix "Periodical-Publication"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Ontologies"></see>
    /// </summary>
    let Ontologies = _prefix "Ontologies"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Operating-System"></see>
    /// </summary>
    let ``Operating-System`` = _prefix "Operating-System"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-sub-unit"></see>
    /// </summary>
    let ``has-sub-unit`` = _prefix "has-sub-unit"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-size"></see>
    /// </summary>
    let ``has-size`` = _prefix "has-size"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#headed-by"></see>
    /// </summary>
    let ``headed-by`` = _prefix "headed-by"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#organization-part-of"></see>
    /// </summary>
    let ``organization-part-of`` = _prefix "organization-part-of"
    /// <summary>
    /// We use EU guidelines to distinguish between different organization sizes
    /// <see href="http://www.aktors.org/ontology/portal#Organization-Size"></see></summary>
    let ``Organization-Size`` = _prefix "Organization-Size"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#affiliated-person"></see>
    /// </summary>
    let ``affiliated-person`` = _prefix "affiliated-person"
    /// <summary>
    /// An organization with over 10000 employees
    /// <see href="http://www.aktors.org/ontology/portal#very-large-size"></see></summary>
    let ``very-large-size`` = _prefix "very-large-size"
    /// <summary>
    /// An organization with more than 250 employees
    /// <see href="http://www.aktors.org/ontology/portal#large-size"></see></summary>
    let ``large-size`` = _prefix "large-size"
    /// <summary>
    /// An organization with no more than 250 employees.  It also has to be independent, i.e., less than 25% owned by one enterprise (or jointly by several enterprises) falling outside the definition of medium-sized enterprise. Finally, either the turnover total must be less than 40M Euros or the balance sheet total must be less than 27M Euros.
    /// <see href="http://www.aktors.org/ontology/portal#medium-size"></see></summary>
    let ``medium-size`` = _prefix "medium-size"
    /// <summary>
    /// An organization with no more than 50 employees.  It also has to be independent, i.e., less than 25% owned by one enterprise (or jointly by several enterprises) falling outside the definition of small-sized enterprise. Finally, either the turnover total must be less than 7M Euros or the balance sheet total must be less than 5M Euros.
    /// <see href="http://www.aktors.org/ontology/portal#small-size"></see></summary>
    let ``small-size`` = _prefix "small-size"
    /// <summary>
    /// An organization with no more than 10 employees.  It also has to be independent, i.e., less than 25% owned by one enterprise (or jointly by several enterprises) falling outside the definition of micro-sized enterprise.
    /// <see href="http://www.aktors.org/ontology/portal#micro-size"></see></summary>
    let ``micro-size`` = _prefix "micro-size"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Organizational-Learning"></see>
    /// </summary>
    let ``Organizational-Learning`` = _prefix "Organizational-Learning"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Part-Time"></see>
    /// </summary>
    let ``Part-Time`` = _prefix "Part-Time"
    /// <summary>
    /// A partnership is not necessarily a company, e.g. a consultancy firm is not a company
    /// <see href="http://www.aktors.org/ontology/portal#Partnership"></see></summary>
    let Partnership = _prefix "Partnership"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#PhD"></see>
    /// </summary>
    let PhD = _prefix "PhD"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#PhD-Student"></see>
    /// </summary>
    let ``PhD-Student`` = _prefix "PhD-Student"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#studies-at"></see>
    /// </summary>
    let ``studies-at`` = _prefix "studies-at"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Student"></see>
    /// </summary>
    let Student = _prefix "Student"
    /// <summary>
    /// An organization which has a political connotation
    /// <see href="http://www.aktors.org/ontology/portal#Political-Organization"></see></summary>
    let ``Political-Organization`` = _prefix "Political-Organization"
    /// <summary>
    /// Modified to allow addresses to be given as strings, with no structure
    /// <see href="http://www.aktors.org/ontology/portal#Postal-Address"></see></summary>
    let ``Postal-Address`` = _prefix "Postal-Address"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Private-Company"></see>
    /// </summary>
    let ``Private-Company`` = _prefix "Private-Company"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Problem-Solving-Methods"></see>
    /// </summary>
    let ``Problem-Solving-Methods`` = _prefix "Problem-Solving-Methods"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Proceedings-Paper-Reference"></see>
    /// </summary>
    let ``Proceedings-Paper-Reference`` = _prefix "Proceedings-Paper-Reference"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Prof"></see>
    /// </summary>
    let Prof = _prefix "Prof"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Professor-In-Academia"></see>
    /// </summary>
    let ``Professor-In-Academia`` = _prefix "Professor-In-Academia"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Programming-Environment"></see>
    /// </summary>
    let ``Programming-Environment`` = _prefix "Programming-Environment"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Programming-Language"></see>
    /// </summary>
    let ``Programming-Language`` = _prefix "Programming-Language"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#supports-language"></see>
    /// </summary>
    let ``supports-language`` = _prefix "supports-language"

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Specification-Or-Computing-Language"></see>
    /// </summary>
    let ``Specification-Or-Computing-Language`` =
        _prefix "Specification-Or-Computing-Language"

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Project"></see>
    /// </summary>
    let Project = _prefix "Project"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-project-member"></see>
    /// </summary>
    let ``has-project-member`` = _prefix "has-project-member"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#involves-organization"></see>
    /// </summary>
    let ``involves-organization`` = _prefix "involves-organization"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#produces-output"></see>
    /// </summary>
    let ``produces-output`` = _prefix "produces-output"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Project-Officer-In-Academia"></see>
    /// </summary>
    let ``Project-Officer-In-Academia`` = _prefix "Project-Officer-In-Academia"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Public-Company"></see>
    /// </summary>
    let ``Public-Company`` = _prefix "Public-Company"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#cites-publication-reference"></see>
    /// </summary>
    let ``cites-publication-reference`` = _prefix "cites-publication-reference"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-place-of-publication"></see>
    /// </summary>
    let ``has-place-of-publication`` = _prefix "has-place-of-publication"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-date"></see>
    /// </summary>
    let ``has-date`` = _prefix "has-date"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#event-product"></see>
    /// </summary>
    let ``event-product`` = _prefix "event-product"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#R-And-D-Institute"></see>
    /// </summary>
    let ``R-And-D-Institute`` = _prefix "R-And-D-Institute"

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#R-And-D-Institute-Within-Larger-Institute"></see>
    /// </summary>
    let ``R-And-D-Institute-Within-Larger-Institute`` =
        _prefix "R-And-D-Institute-Within-Larger-Institute"

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Reader-In-Academia"></see>
    /// </summary>
    let ``Reader-In-Academia`` = _prefix "Reader-In-Academia"
    /// <summary>
    /// Any kind of recorded audio, which is tangible.  This also includes a audio file on a machine
    /// <see href="http://www.aktors.org/ontology/portal#Recorded-Audio"></see></summary>
    let ``Recorded-Audio`` = _prefix "Recorded-Audio"
    /// <summary>
    /// Any kind of recorded video, which is tangible.  This also includes a mpeg file on a machine
    /// <see href="http://www.aktors.org/ontology/portal#Recorded-Video"></see></summary>
    let ``Recorded-Video`` = _prefix "Recorded-Video"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Released-Version"></see>
    /// </summary>
    let ``Released-Version`` = _prefix "Released-Version"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Research-Assistant-In-Academia"></see>
    /// </summary>
    let ``Research-Assistant-In-Academia`` = _prefix "Research-Assistant-In-Academia"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Researcher-In-Academia"></see>
    /// </summary>
    let ``Researcher-In-Academia`` = _prefix "Researcher-In-Academia"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Research-Fellow-In-Academia"></see>
    /// </summary>
    let ``Research-Fellow-In-Academia`` = _prefix "Research-Fellow-In-Academia"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Researcher"></see>
    /// </summary>
    let Researcher = _prefix "Researcher"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#School"></see>
    /// </summary>
    let School = _prefix "School"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Scripting-Language"></see>
    /// </summary>
    let ``Scripting-Language`` = _prefix "Scripting-Language"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Secretary"></see>
    /// </summary>
    let Secretary = _prefix "Secretary"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Self-Employed-Person"></see>
    /// </summary>
    let ``Self-Employed-Person`` = _prefix "Self-Employed-Person"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Semantic-Web-Area"></see>
    /// </summary>
    let ``Semantic-Web-Area`` = _prefix "Semantic-Web-Area"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Web-Research-Area"></see>
    /// </summary>
    let ``Web-Research-Area`` = _prefix "Web-Research-Area"
    /// <summary>
    /// a generalized transfer in which information is passed from main agent to one or more recipient agents.  examples include giving a tutorial.
    /// <see href="http://www.aktors.org/ontology/portal#Sending-An-Email"></see></summary>
    let ``Sending-An-Email`` = _prefix "Sending-An-Email"

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#information-transfer-medium-used"></see>
    /// </summary>
    let ``information-transfer-medium-used`` =
        _prefix "information-transfer-medium-used"

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#information-object-being-transferred"></see>
    /// </summary>
    let ``information-object-being-transferred`` =
        _prefix "information-object-being-transferred"

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Senior-Lecturer-In-Academia"></see>
    /// </summary>
    let ``Senior-Lecturer-In-Academia`` = _prefix "Senior-Lecturer-In-Academia"

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Senior-Research-Fellow-In-Academia"></see>
    /// </summary>
    let ``Senior-Research-Fellow-In-Academia`` =
        _prefix "Senior-Research-Fellow-In-Academia"

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Sir"></see>
    /// </summary>
    let Sir = _prefix "Sir"

    /// <summary>
    /// SME are important, so we define a class to represent them explicitly. In some case we might not know or we do not want to bother specifying excatly whether something is a small-organization or a medium-organization. Hence, we can just say 'x is a SME' without going into further detail.
    /// <see href="http://www.aktors.org/ontology/portal#Small-Or-Medium-Sized-Organization"></see></summary>
    let ``Small-Or-Medium-Sized-Organization`` =
        _prefix "Small-Or-Medium-Sized-Organization"

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Software-Visualization"></see>
    /// </summary>
    let ``Software-Visualization`` = _prefix "Software-Visualization"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Specification-Language"></see>
    /// </summary>
    let ``Specification-Language`` = _prefix "Specification-Language"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#studies-in-unit"></see>
    /// </summary>
    let ``studies-in-unit`` = _prefix "studies-in-unit"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#System-Administrator"></see>
    /// </summary>
    let ``System-Administrator`` = _prefix "System-Administrator"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Technical-Report-Reference"></see>
    /// </summary>
    let ``Technical-Report-Reference`` = _prefix "Technical-Report-Reference"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Telepresence-Research-Area"></see>
    /// </summary>
    let ``Telepresence-Research-Area`` = _prefix "Telepresence-Research-Area"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Thesis-Reference"></see>
    /// </summary>
    let ``Thesis-Reference`` = _prefix "Thesis-Reference"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Town"></see>
    /// </summary>
    let Town = _prefix "Town"
    /// <summary>
    /// Something tangible designed to transport people, animals, objects from A to B. For instance a bycicle, a car, a boat, etc.
    /// <see href="http://www.aktors.org/ontology/portal#Transportation-Device"></see></summary>
    let ``Transportation-Device`` = _prefix "Transportation-Device"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#University-Faculty"></see>
    /// </summary>
    let ``University-Faculty`` = _prefix "University-Faculty"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Village"></see>
    /// </summary>
    let Village = _prefix "Village"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Visiting-Researcher"></see>
    /// </summary>
    let ``Visiting-Researcher`` = _prefix "Visiting-Researcher"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Web-Based-Editor"></see>
    /// </summary>
    let ``Web-Based-Editor`` = _prefix "Web-Based-Editor"
    /// <summary>
    /// A system which is accessible through the web
    /// <see href="http://www.aktors.org/ontology/portal#Web-Based-System"></see></summary>
    let ``Web-Based-System`` = _prefix "Web-Based-System"
    /// <summary>
    /// A web browser is not a web-based system!
    /// <see href="http://www.aktors.org/ontology/portal#Web-Browser"></see></summary>
    let ``Web-Browser`` = _prefix "Web-Browser"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Web-Reference"></see>
    /// </summary>
    let ``Web-Reference`` = _prefix "Web-Reference"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Web-Site"></see>
    /// </summary>
    let ``Web-Site`` = _prefix "Web-Site"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Workshop"></see>
    /// </summary>
    let Workshop = _prefix "Workshop"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Workshop-Proceedings-Reference"></see>
    /// </summary>
    let ``Workshop-Proceedings-Reference`` = _prefix "Workshop-Proceedings-Reference"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#address-area"></see>
    /// </summary>
    let ``address-area`` = _prefix "address-area"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#address-building"></see>
    /// </summary>
    let ``address-building`` = _prefix "address-building"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#address-city-or-village"></see>
    /// </summary>
    let ``address-city-or-village`` = _prefix "address-city-or-village"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#address-country"></see>
    /// </summary>
    let ``address-country`` = _prefix "address-country"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#address-number"></see>
    /// </summary>
    let ``address-number`` = _prefix "address-number"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#address-postcode"></see>
    /// </summary>
    let ``address-postcode`` = _prefix "address-postcode"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#address-pretty-label"></see>
    /// </summary>
    let ``address-pretty-label`` = _prefix "address-pretty-label"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#address-region"></see>
    /// </summary>
    let ``address-region`` = _prefix "address-region"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#address-street"></see>
    /// </summary>
    let ``address-street`` = _prefix "address-street"

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#addresses-generic-area-of-interest"></see>
    /// </summary>
    let ``addresses-generic-area-of-interest`` =
        _prefix "addresses-generic-area-of-interest"

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#affiliated-people"></see>
    /// </summary>
    let ``affiliated-people`` = _prefix "affiliated-people"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#confers-award"></see>
    /// </summary>
    let ``confers-award`` = _prefix "confers-award"
    /// <summary>
    /// What is being transferred
    /// <see href="http://www.aktors.org/ontology/portal#thing-acted-on"></see></summary>
    let ``thing-acted-on`` = _prefix "thing-acted-on"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#contains-property"></see>
    /// </summary>
    let ``contains-property`` = _prefix "contains-property"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#family-name"></see>
    /// </summary>
    let ``family-name`` = _prefix "family-name"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#full-name"></see>
    /// </summary>
    let ``full-name`` = _prefix "full-name"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#funding-source"></see>
    /// </summary>
    let ``funding-source`` = _prefix "funding-source"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#given-name"></see>
    /// </summary>
    let ``given-name`` = _prefix "given-name"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#government-of-country"></see>
    /// </summary>
    let ``government-of-country`` = _prefix "government-of-country"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-ISBN-number"></see>
    /// </summary>
    let ``has-ISBN-number`` = _prefix "has-ISBN-number"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-URL"></see>
    /// </summary>
    let ``has-URL`` = _prefix "has-URL"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-academic-degree"></see>
    /// </summary>
    let ``has-academic-degree`` = _prefix "has-academic-degree"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-academic-unit"></see>
    /// </summary>
    let ``has-academic-unit`` = _prefix "has-academic-unit"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-affiliation-to-unit"></see>
    /// </summary>
    let ``has-affiliation-to-unit`` = _prefix "has-affiliation-to-unit"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-amount"></see>
    /// </summary>
    let ``has-amount`` = _prefix "has-amount"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-appellation"></see>
    /// </summary>
    let ``has-appellation`` = _prefix "has-appellation"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-award-rationale"></see>
    /// </summary>
    let ``has-award-rationale`` = _prefix "has-award-rationale"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-awarding-body"></see>
    /// </summary>
    let ``has-awarding-body`` = _prefix "has-awarding-body"
    /// <summary>
    /// The agents causing the event to happen, if they are known.
    /// <see href="http://www.aktors.org/ontology/portal#has-main-agent"></see></summary>
    let ``has-main-agent`` = _prefix "has-main-agent"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-capital"></see>
    /// </summary>
    let ``has-capital`` = _prefix "has-capital"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#is-capital-of"></see>
    /// </summary>
    let ``is-capital-of`` = _prefix "is-capital-of"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-contract-type"></see>
    /// </summary>
    let ``has-contract-type`` = _prefix "has-contract-type"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-currency"></see>
    /// </summary>
    let ``has-currency`` = _prefix "has-currency"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-email-address"></see>
    /// </summary>
    let ``has-email-address`` = _prefix "has-email-address"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-faculty"></see>
    /// </summary>
    let ``has-faculty`` = _prefix "has-faculty"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-fax-number"></see>
    /// </summary>
    let ``has-fax-number`` = _prefix "has-fax-number"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-gender"></see>
    /// </summary>
    let ``has-gender`` = _prefix "has-gender"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-goals"></see>
    /// </summary>
    let ``has-goals`` = _prefix "has-goals"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-government"></see>
    /// </summary>
    let ``has-government`` = _prefix "has-government"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-job-title"></see>
    /// </summary>
    let ``has-job-title`` = _prefix "has-job-title"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-leading-organization"></see>
    /// </summary>
    let ``has-leading-organization`` = _prefix "has-leading-organization"
    /// <summary>
    /// The location at which an event takes place
    /// <see href="http://www.aktors.org/ontology/portal#has-location"></see></summary>
    let ``has-location`` = _prefix "has-location"
    /// <summary>
    /// Other agents involved in the event
    /// <see href="http://www.aktors.org/ontology/portal#has-other-agents-involved"></see></summary>
    let ``has-other-agents-involved`` = _prefix "has-other-agents-involved"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-page-numbers"></see>
    /// </summary>
    let ``has-page-numbers`` = _prefix "has-page-numbers"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-postal-address"></see>
    /// </summary>
    let ``has-postal-address`` = _prefix "has-postal-address"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-project-leader"></see>
    /// </summary>
    let ``has-project-leader`` = _prefix "has-project-leader"
    /// <summary>
    /// People and in general even organizations and organization units may have research interests.  This relation shoudl be used to specify them
    /// <see href="http://www.aktors.org/ontology/portal#has-research-interest"></see></summary>
    let ``has-research-interest`` = _prefix "has-research-interest"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-speaker"></see>
    /// </summary>
    let ``has-speaker`` = _prefix "has-speaker"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#sender-of-information"></see>
    /// </summary>
    let ``sender-of-information`` = _prefix "sender-of-information"
    /// <summary>
    /// Whether the software is released, alpha or beta
    /// <see href="http://www.aktors.org/ontology/portal#has-status"></see></summary>
    let ``has-status`` = _prefix "has-status"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-sub-activity"></see>
    /// </summary>
    let ``has-sub-activity`` = _prefix "has-sub-activity"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-supervisor"></see>
    /// </summary>
    let ``has-supervisor`` = _prefix "has-supervisor"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-support-unit"></see>
    /// </summary>
    let ``has-support-unit`` = _prefix "has-support-unit"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-telephone-number"></see>
    /// </summary>
    let ``has-telephone-number`` = _prefix "has-telephone-number"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-title"></see>
    /// </summary>
    let ``has-title`` = _prefix "has-title"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-vice-chancellor"></see>
    /// </summary>
    let ``has-vice-chancellor`` = _prefix "has-vice-chancellor"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-web-address"></see>
    /// </summary>
    let ``has-web-address`` = _prefix "has-web-address"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#information-being-transferred"></see>
    /// </summary>
    let ``information-being-transferred`` = _prefix "information-being-transferred"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#means-of-transport-used"></see>
    /// </summary>
    let ``means-of-transport-used`` = _prefix "means-of-transport-used"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#issued-by"></see>
    /// </summary>
    let ``issued-by`` = _prefix "issued-by"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#meeting-attendee"></see>
    /// </summary>
    let ``meeting-attendee`` = _prefix "meeting-attendee"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#meeting-organizer"></see>
    /// </summary>
    let ``meeting-organizer`` = _prefix "meeting-organizer"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#method-builds-on"></see>
    /// </summary>
    let ``method-builds-on`` = _prefix "method-builds-on"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#organization-being-visited"></see>
    /// </summary>
    let ``organization-being-visited`` = _prefix "organization-being-visited"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#organization-unit-being-visited"></see>
    /// </summary>
    let ``organization-unit-being-visited`` = _prefix "organization-unit-being-visited"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#person-being-visited"></see>
    /// </summary>
    let ``person-being-visited`` = _prefix "person-being-visited"

    /// <summary>
    /// It is sufficient that somebody in unit ?u works in project ?p
    /// <see href="http://www.aktors.org/ontology/portal#project-involves-organization-unit"></see></summary>
    let ``project-involves-organization-unit`` =
        _prefix "project-involves-organization-unit"

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#published-book"></see>
    /// </summary>
    let ``published-book`` = _prefix "published-book"
    /// <summary>
    /// The agents which receive the thing-acted-on
    /// <see href="http://www.aktors.org/ontology/portal#recipient-agents"></see></summary>
    let ``recipient-agents`` = _prefix "recipient-agents"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#recipient-of-message"></see>
    /// </summary>
    let ``recipient-of-message`` = _prefix "recipient-of-message"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#requires-hardware-platform"></see>
    /// </summary>
    let ``requires-hardware-platform`` = _prefix "requires-hardware-platform"

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#requires-hardware-platform-on-client-side"></see>
    /// </summary>
    let ``requires-hardware-platform-on-client-side`` =
        _prefix "requires-hardware-platform-on-client-side"

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#requires-hardware-platform-on-server-side"></see>
    /// </summary>
    let ``requires-hardware-platform-on-server-side`` =
        _prefix "requires-hardware-platform-on-server-side"

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#requires-software-technology"></see>
    /// </summary>
    let ``requires-software-technology`` = _prefix "requires-software-technology"

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#requires-software-technology-on-client-side"></see>
    /// </summary>
    let ``requires-software-technology-on-client-side`` =
        _prefix "requires-software-technology-on-client-side"

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#requires-software-technology-on-server-side"></see>
    /// </summary>
    let ``requires-software-technology-on-server-side`` =
        _prefix "requires-software-technology-on-server-side"

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#runs-on-operating-system"></see>
    /// </summary>
    let ``runs-on-operating-system`` = _prefix "runs-on-operating-system"

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#runs-on-operating-system-on-client-side"></see>
    /// </summary>
    let ``runs-on-operating-system-on-client-side`` =
        _prefix "runs-on-operating-system-on-client-side"

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#runs-on-operating-system-on-server-side"></see>
    /// </summary>
    let ``runs-on-operating-system-on-server-side`` =
        _prefix "runs-on-operating-system-on-server-side"

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#sender-of-message"></see>
    /// </summary>
    let ``sender-of-message`` = _prefix "sender-of-message"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#sub-unit-of-organization-unit"></see>
    /// </summary>
    let ``sub-unit-of-organization-unit`` = _prefix "sub-unit-of-organization-unit"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#subsidiary-of"></see>
    /// </summary>
    let ``subsidiary-of`` = _prefix "subsidiary-of"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#supports-method"></see>
    /// </summary>
    let ``supports-method`` = _prefix "supports-method"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#technology-builds-on"></see>
    /// </summary>
    let ``technology-builds-on`` = _prefix "technology-builds-on"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#time-of-message"></see>
    /// </summary>
    let ``time-of-message`` = _prefix "time-of-message"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#uses-resource"></see>
    /// </summary>
    let ``uses-resource`` = _prefix "uses-resource"
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#works-in-unit"></see>
    /// </summary>
    let ``works-in-unit`` = _prefix "works-in-unit"
