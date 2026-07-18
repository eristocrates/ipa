namespace http.www.aktors.org.ontology.portal.hash

open DoxAletheia.Rdf_Vocabulary

module akt =
    let _namespace_name = "http://www.aktors.org/ontology/portal#"

    /// <summary>
    /// Information in general, independent of an object in which it is encoded. Whatever is transferred in an information-transfer event. It is clearly an intangible thing
    /// <see href="http://www.aktors.org/ontology/portal#Abstract-Information"></see></summary>
    let ``Abstract-Information`` =
        Namespaced_IRI.parse _namespace_name "Abstract-Information" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Academic"></see>
    /// </summary>
    let Academic = Namespaced_IRI.parse _namespace_name "Academic" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Higher-Educational-Organization"></see>
    /// </summary>
    let ``Higher-Educational-Organization`` =
        Namespaced_IRI.parse _namespace_name "Higher-Educational-Organization" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#works-for"></see>
    /// </summary>
    let ``works-for`` =
        Namespaced_IRI.parse _namespace_name "works-for" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Educational-Employee"></see>
    /// </summary>
    let ``Educational-Employee`` =
        Namespaced_IRI.parse _namespace_name "Educational-Employee" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Academic-Degree"></see>
    /// </summary>
    let ``Academic-Degree`` =
        Namespaced_IRI.parse _namespace_name "Academic-Degree" |> NamespacedName

    /// <summary>
    /// A degree is type of award
    /// <see href="http://www.aktors.org/ontology/portal#Degree"></see></summary>
    let Degree = Namespaced_IRI.parse _namespace_name "Degree" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Academic-Support-Staff"></see>
    /// </summary>
    let ``Academic-Support-Staff`` =
        Namespaced_IRI.parse _namespace_name "Academic-Support-Staff" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Academic-Support-Unit"></see>
    /// </summary>
    let ``Academic-Support-Unit`` =
        Namespaced_IRI.parse _namespace_name "Academic-Support-Unit" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Educational-Organization-Unit"></see>
    /// </summary>
    let ``Educational-Organization-Unit`` =
        Namespaced_IRI.parse _namespace_name "Educational-Organization-Unit" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Academic-Unit"></see>
    /// </summary>
    let ``Academic-Unit`` =
        Namespaced_IRI.parse _namespace_name "Academic-Unit" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#University"></see>
    /// </summary>
    let University = Namespaced_IRI.parse _namespace_name "University" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#unit-of-organization"></see>
    /// </summary>
    let ``unit-of-organization`` =
        Namespaced_IRI.parse _namespace_name "unit-of-organization" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Activity"></see>
    /// </summary>
    let Activity = Namespaced_IRI.parse _namespace_name "Activity" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Adaptive-Hypermedia"></see>
    /// </summary>
    let ``Adaptive-Hypermedia`` =
        Namespaced_IRI.parse _namespace_name "Adaptive-Hypermedia" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#sub-area-of"></see>
    /// </summary>
    let ``sub-area-of`` =
        Namespaced_IRI.parse _namespace_name "sub-area-of" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Hypermedia"></see>
    /// </summary>
    let Hypermedia = Namespaced_IRI.parse _namespace_name "Hypermedia" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Research-Area"></see>
    /// </summary>
    let ``Research-Area`` =
        Namespaced_IRI.parse _namespace_name "Research-Area" |> NamespacedName

    /// <summary>
    /// A generic class for addresses, whether email or postal. We see an address as abstract information and therefore it is an intangible thing
    /// <see href="http://www.aktors.org/ontology/portal#Address"></see></summary>
    let Address = Namespaced_IRI.parse _namespace_name "Address" |> NamespacedName

    /// <summary>
    /// A person which has an affiliation with some organization. For instance employees are affiliated to the organization they work for, students to the institution where they are studying, etc. A person can have multiple affiliations, which means that there is no constraint relating the values of slot has-affiliation-to-unit to the values of slot has-affiliation
    /// <see href="http://www.aktors.org/ontology/portal#Affiliated-Person"></see></summary>
    let ``Affiliated-Person`` =
        Namespaced_IRI.parse _namespace_name "Affiliated-Person" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-affiliation"></see>
    /// </summary>
    let ``has-affiliation`` =
        Namespaced_IRI.parse _namespace_name "has-affiliation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Person"></see>
    /// </summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Agent-Based-Computing"></see>
    /// </summary>
    let ``Agent-Based-Computing`` =
        Namespaced_IRI.parse _namespace_name "Agent-Based-Computing" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Alpha-Version"></see>
    /// </summary>
    let ``Alpha-Version`` =
        Namespaced_IRI.parse _namespace_name "Alpha-Version" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Software-Status"></see>
    /// </summary>
    let ``Software-Status`` =
        Namespaced_IRI.parse _namespace_name "Software-Status" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Amount-Of-Money"></see>
    /// </summary>
    let ``Amount-Of-Money`` =
        Namespaced_IRI.parse _namespace_name "Amount-Of-Money" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Currency"></see>
    /// </summary>
    let Currency = Namespaced_IRI.parse _namespace_name "Currency" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Appellation"></see>
    /// </summary>
    let Appellation =
        Namespaced_IRI.parse _namespace_name "Appellation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Article-In-A-Composite-Publication"></see>
    /// </summary>
    let ``Article-In-A-Composite-Publication`` =
        Namespaced_IRI.parse _namespace_name "Article-In-A-Composite-Publication" |> NamespacedName

    /// <summary>
    /// A publication which contains items which cane be themselves referenced through a publication reference.  Composite publications include newspapers, magazines and journals. A book which is a collection of articles is a composite publication, a monograph is not
    /// <see href="http://www.aktors.org/ontology/portal#Composite-Publication"></see></summary>
    let ``Composite-Publication`` =
        Namespaced_IRI.parse _namespace_name "Composite-Publication" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#included-in-publication"></see>
    /// </summary>
    let ``included-in-publication`` =
        Namespaced_IRI.parse _namespace_name "included-in-publication" |> NamespacedName

    /// <summary>
    /// A publication is something which has one or more publication references. A publication can be both an article in a journal or a journal itself. The distinction between publication and publication-reference makes it possible to distinguish between multiple occurrences of the sam publication, for instance in different media
    /// <see href="http://www.aktors.org/ontology/portal#Publication"></see></summary>
    let Publication =
        Namespaced_IRI.parse _namespace_name "Publication" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Article-Reference"></see>
    /// </summary>
    let ``Article-Reference`` =
        Namespaced_IRI.parse _namespace_name "Article-Reference" |> NamespacedName

    /// <summary>
    /// we have decided that a publication reference is an intangible, abstract information
    /// <see href="http://www.aktors.org/ontology/portal#Publication-Reference"></see></summary>
    let ``Publication-Reference`` =
        Namespaced_IRI.parse _namespace_name "Publication-Reference" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Artificial-Intelligence-Research-Area"></see>
    /// </summary>
    let ``Artificial-Intelligence-Research-Area`` =
        Namespaced_IRI.parse _namespace_name "Artificial-Intelligence-Research-Area" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Attending-A-Conference"></see>
    /// </summary>
    let ``Attending-A-Conference`` =
        Namespaced_IRI.parse _namespace_name "Attending-A-Conference" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Conference"></see>
    /// </summary>
    let Conference = Namespaced_IRI.parse _namespace_name "Conference" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#event-attended"></see>
    /// </summary>
    let ``event-attended`` =
        Namespaced_IRI.parse _namespace_name "event-attended" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Attending-An-Event"></see>
    /// </summary>
    let ``Attending-An-Event`` =
        Namespaced_IRI.parse _namespace_name "Attending-An-Event" |> NamespacedName

    /// <summary>
    /// This is a minimalist definition of class event.  We start with the very basic and we will then add slots as we specialise this definition for specific classes of events. The fillers of slots has-other-agents-involved and has-main-agent should not intersect
    /// <see href="http://www.aktors.org/ontology/portal#Event"></see></summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName
    /// <summary>
    /// An award is an intangible thing, even if the piece of paper which is often associated with an award is tangible.  What about the virtual piece of paper in the virtual degree ceremony?  I guess that ought to be an intangible
    /// <see href="http://www.aktors.org/ontology/portal#Award"></see></summary>
    let Award = Namespaced_IRI.parse _namespace_name "Award" |> NamespacedName

    /// <summary>
    /// Legal agents can be either organizations or people. An awarding body is normally an organization, an individual, or a bunch of people
    /// <see href="http://www.aktors.org/ontology/portal#Awarding-Body"></see></summary>
    let ``Awarding-Body`` =
        Namespaced_IRI.parse _namespace_name "Awarding-Body" |> NamespacedName

    /// <summary>
    /// Some agents have legal status: definitely organizations and people, anybody else?
    /// <see href="http://www.aktors.org/ontology/portal#Legal-Agent"></see></summary>
    let ``Legal-Agent`` =
        Namespaced_IRI.parse _namespace_name "Legal-Agent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#BA"></see>
    /// </summary>
    let BA = Namespaced_IRI.parse _namespace_name "BA" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#BSc"></see>
    /// </summary>
    let BSc = Namespaced_IRI.parse _namespace_name "BSc" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Beta-Version"></see>
    /// </summary>
    let ``Beta-Version`` =
        Namespaced_IRI.parse _namespace_name "Beta-Version" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Book"></see>
    /// </summary>
    let Book = Namespaced_IRI.parse _namespace_name "Book" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-publication-reference"></see>
    /// </summary>
    let ``has-publication-reference`` =
        Namespaced_IRI.parse _namespace_name "has-publication-reference" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Book-Reference"></see>
    /// </summary>
    let ``Book-Reference`` =
        Namespaced_IRI.parse _namespace_name "Book-Reference" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Book-Publishing"></see>
    /// </summary>
    let ``Book-Publishing`` =
        Namespaced_IRI.parse _namespace_name "Book-Publishing" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Publication-Type-Event"></see>
    /// </summary>
    let ``Publication-Type-Event`` =
        Namespaced_IRI.parse _namespace_name "Publication-Type-Event" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Publishing-House"></see>
    /// </summary>
    let ``Publishing-House`` =
        Namespaced_IRI.parse _namespace_name "Publishing-House" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#published-by"></see>
    /// </summary>
    let ``published-by`` =
        Namespaced_IRI.parse _namespace_name "published-by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Book-Section-Reference"></see>
    /// </summary>
    let ``Book-Section-Reference`` =
        Namespaced_IRI.parse _namespace_name "Book-Section-Reference" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Broken-Version"></see>
    /// </summary>
    let ``Broken-Version`` =
        Namespaced_IRI.parse _namespace_name "Broken-Version" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Business-Area"></see>
    /// </summary>
    let ``Business-Area`` =
        Namespaced_IRI.parse _namespace_name "Business-Area" |> NamespacedName

    /// <summary>
    /// A generic class to specify generic areas for research or business initiatives. For instance, the area in which a project is situated
    /// <see href="http://www.aktors.org/ontology/portal#Generic-Area-Of-Interest"></see></summary>
    let ``Generic-Area-Of-Interest`` =
        Namespaced_IRI.parse _namespace_name "Generic-Area-Of-Interest" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Capital-City"></see>
    /// </summary>
    let ``Capital-City`` =
        Namespaced_IRI.parse _namespace_name "Capital-City" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#City"></see>
    /// </summary>
    let City = Namespaced_IRI.parse _namespace_name "City" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Charitable-Organization"></see>
    /// </summary>
    let ``Charitable-Organization`` =
        Namespaced_IRI.parse _namespace_name "Charitable-Organization" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Non-Profit-Organization"></see>
    /// </summary>
    let ``Non-Profit-Organization`` =
        Namespaced_IRI.parse _namespace_name "Non-Profit-Organization" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Municipal-Unit"></see>
    /// </summary>
    let ``Municipal-Unit`` =
        Namespaced_IRI.parse _namespace_name "Municipal-Unit" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Civil-Service"></see>
    /// </summary>
    let ``Civil-Service`` =
        Namespaced_IRI.parse _namespace_name "Civil-Service" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Government-Organization"></see>
    /// </summary>
    let ``Government-Organization`` =
        Namespaced_IRI.parse _namespace_name "Government-Organization" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Cognitive-Modelling-Research-Area"></see>
    /// </summary>
    let ``Cognitive-Modelling-Research-Area`` =
        Namespaced_IRI.parse _namespace_name "Cognitive-Modelling-Research-Area" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Collaborative-Hypermedia"></see>
    /// </summary>
    let ``Collaborative-Hypermedia`` =
        Namespaced_IRI.parse _namespace_name "Collaborative-Hypermedia" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Company"></see>
    /// </summary>
    let Company = Namespaced_IRI.parse _namespace_name "Company" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Profit-Organization"></see>
    /// </summary>
    let ``Profit-Organization`` =
        Namespaced_IRI.parse _namespace_name "Profit-Organization" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#contains-publication"></see>
    /// </summary>
    let ``contains-publication`` =
        Namespaced_IRI.parse _namespace_name "contains-publication" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Computing-Research-Area"></see>
    /// </summary>
    let ``Computing-Research-Area`` =
        Namespaced_IRI.parse _namespace_name "Computing-Research-Area" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Computing-Technology"></see>
    /// </summary>
    let ``Computing-Technology`` =
        Namespaced_IRI.parse _namespace_name "Computing-Technology" |> NamespacedName

    /// <summary>
    /// By technology we mean engineered applications of science. I guess we are probably confining ourselves to tangible things but as I am not sure I will use thing as the direct superclass - e.g., an algorithm is an intangible thing, but it could be seen as a technology, if we give a broad interpretation of the term
    /// <see href="http://www.aktors.org/ontology/portal#Technology"></see></summary>
    let Technology = Namespaced_IRI.parse _namespace_name "Technology" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Conference-Proceedings-Reference"></see>
    /// </summary>
    let ``Conference-Proceedings-Reference`` =
        Namespaced_IRI.parse _namespace_name "Conference-Proceedings-Reference" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#published-proceedings"></see>
    /// </summary>
    let ``published-proceedings`` =
        Namespaced_IRI.parse _namespace_name "published-proceedings" |> NamespacedName

    /// <summary>
    /// A meeting type of event. Note that both attendee and organizer have multiple cardinality
    /// <see href="http://www.aktors.org/ontology/portal#Meeting-Taking-Place"></see></summary>
    let ``Meeting-Taking-Place`` =
        Namespaced_IRI.parse _namespace_name "Meeting-Taking-Place" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Conferring-An-Award"></see>
    /// </summary>
    let ``Conferring-An-Award`` =
        Namespaced_IRI.parse _namespace_name "Conferring-An-Award" |> NamespacedName

    /// <summary>
    /// An event in which the main agent transfers something (the thing-acted-on, tangible or intangible) to one or more recipient agents. Note that we do not say anything about whether the original agent still retain the thing-acted-on.  In some cases this is clearly true ('I pass my wisdom on to my daughter'), in other cases it is not (I give you my wallet).
    /// <see href="http://www.aktors.org/ontology/portal#Generalized-Transfer"></see></summary>
    let ``Generalized-Transfer`` =
        Namespaced_IRI.parse _namespace_name "Generalized-Transfer" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Country"></see>
    /// </summary>
    let Country = Namespaced_IRI.parse _namespace_name "Country" |> NamespacedName

    /// <summary>
    /// A geopolitical entity is a geographical area which is associated with some sort of political structure. For instance, Russia, Italy, The-city-of-Messina, etc. A geopolitical entity can be also seen as an agent - e.g., France declared war to Spain
    /// <see href="http://www.aktors.org/ontology/portal#Geopolitical-Entity"></see></summary>
    let ``Geopolitical-Entity`` =
        Namespaced_IRI.parse _namespace_name "Geopolitical-Entity" |> NamespacedName

    /// <summary>
    /// This notion comes from Cyc.  It is useful to group together all information bearing entities, including video, audio and documents. An information bearing object may have an author (a generic agent) and may be owned by a legal agent. It is a tangible object
    /// <see href="http://www.aktors.org/ontology/portal#Information-Bearing-Object"></see></summary>
    let ``Information-Bearing-Object`` =
        Namespaced_IRI.parse _namespace_name "Information-Bearing-Object" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#DEng"></see>
    /// </summary>
    let DEng = Namespaced_IRI.parse _namespace_name "DEng" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Daily-Newspaper"></see>
    /// </summary>
    let ``Daily-Newspaper`` =
        Namespaced_IRI.parse _namespace_name "Daily-Newspaper" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-periodicity"></see>
    /// </summary>
    let ``has-periodicity`` =
        Namespaced_IRI.parse _namespace_name "has-periodicity" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Newspaper"></see>
    /// </summary>
    let Newspaper = Namespaced_IRI.parse _namespace_name "Newspaper" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Distance-Teaching-University"></see>
    /// </summary>
    let ``Distance-Teaching-University`` =
        Namespaced_IRI.parse _namespace_name "Distance-Teaching-University" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Dr"></see>
    /// </summary>
    let Dr = Namespaced_IRI.parse _namespace_name "Dr" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Dynamic-Linking"></see>
    /// </summary>
    let ``Dynamic-Linking`` =
        Namespaced_IRI.parse _namespace_name "Dynamic-Linking" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#E-Commerce-Research-Area"></see>
    /// </summary>
    let ``E-Commerce-Research-Area`` =
        Namespaced_IRI.parse _namespace_name "E-Commerce-Research-Area" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Edited-Book"></see>
    /// </summary>
    let ``Edited-Book`` =
        Namespaced_IRI.parse _namespace_name "Edited-Book" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Edited-Book-Reference"></see>
    /// </summary>
    let ``Edited-Book-Reference`` =
        Namespaced_IRI.parse _namespace_name "Edited-Book-Reference" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#edited-by"></see>
    /// </summary>
    let ``edited-by`` =
        Namespaced_IRI.parse _namespace_name "edited-by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Editor"></see>
    /// </summary>
    let Editor = Namespaced_IRI.parse _namespace_name "Editor" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Implemented-System"></see>
    /// </summary>
    let ``Implemented-System`` =
        Namespaced_IRI.parse _namespace_name "Implemented-System" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Educational-Organization"></see>
    /// </summary>
    let ``Educational-Organization`` =
        Namespaced_IRI.parse _namespace_name "Educational-Organization" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Employee"></see>
    /// </summary>
    let Employee = Namespaced_IRI.parse _namespace_name "Employee" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Learning-Centred-Organization"></see>
    /// </summary>
    let ``Learning-Centred-Organization`` =
        Namespaced_IRI.parse _namespace_name "Learning-Centred-Organization" |> NamespacedName

    /// <summary>
    /// An organization may have a number of units. Units may themselves have sub-units
    /// <see href="http://www.aktors.org/ontology/portal#Organization-Unit"></see></summary>
    let ``Organization-Unit`` =
        Namespaced_IRI.parse _namespace_name "Organization-Unit" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Email-Medium"></see>
    /// </summary>
    let ``Email-Medium`` =
        Namespaced_IRI.parse _namespace_name "Email-Medium" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Information-Transfer-Medium"></see>
    /// </summary>
    let ``Information-Transfer-Medium`` =
        Namespaced_IRI.parse _namespace_name "Information-Transfer-Medium" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Email-Message"></see>
    /// </summary>
    let ``Email-Message`` =
        Namespaced_IRI.parse _namespace_name "Email-Message" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Message"></see>
    /// </summary>
    let Message = Namespaced_IRI.parse _namespace_name "Message" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Working-Person"></see>
    /// </summary>
    let ``Working-Person`` =
        Namespaced_IRI.parse _namespace_name "Working-Person" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Employment-Contract-Type"></see>
    /// </summary>
    let ``Employment-Contract-Type`` =
        Namespaced_IRI.parse _namespace_name "Employment-Contract-Type" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Permanent-Contract"></see>
    /// </summary>
    let ``Permanent-Contract`` =
        Namespaced_IRI.parse _namespace_name "Permanent-Contract" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Temporary-Contract"></see>
    /// </summary>
    let ``Temporary-Contract`` =
        Namespaced_IRI.parse _namespace_name "Temporary-Contract" |> NamespacedName

    /// <summary>
    /// This is an event in which the main agent (plus maybe others) goes from some place to another
    /// <see href="http://www.aktors.org/ontology/portal#Event-Involving-Movement"></see></summary>
    let ``Event-Involving-Movement`` =
        Namespaced_IRI.parse _namespace_name "Event-Involving-Movement" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#location-at-end"></see>
    /// </summary>
    let ``location-at-end`` =
        Namespaced_IRI.parse _namespace_name "location-at-end" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#location-at-start"></see>
    /// </summary>
    let ``location-at-start`` =
        Namespaced_IRI.parse _namespace_name "location-at-start" |> NamespacedName

    /// <summary>
    /// When something is produced
    /// <see href="http://www.aktors.org/ontology/portal#Event-Involving-Production"></see></summary>
    let ``Event-Involving-Production`` =
        Namespaced_IRI.parse _namespace_name "Event-Involving-Production" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Experimental-Version"></see>
    /// </summary>
    let ``Experimental-Version`` =
        Namespaced_IRI.parse _namespace_name "Experimental-Version" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Female-Gender"></see>
    /// </summary>
    let ``Female-Gender`` =
        Namespaced_IRI.parse _namespace_name "Female-Gender" |> NamespacedName

    /// <summary>
    /// HPKB says that genders are intangible..Uhm...
    /// <see href="http://www.aktors.org/ontology/portal#Gender"></see></summary>
    let Gender = Namespaced_IRI.parse _namespace_name "Gender" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Financial-Award"></see>
    /// </summary>
    let ``Financial-Award`` =
        Namespaced_IRI.parse _namespace_name "Financial-Award" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Full-Time"></see>
    /// </summary>
    let ``Full-Time`` =
        Namespaced_IRI.parse _namespace_name "Full-Time" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Work-Status"></see>
    /// </summary>
    let ``Work-Status`` =
        Namespaced_IRI.parse _namespace_name "Work-Status" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Male-Gender"></see>
    /// </summary>
    let ``Male-Gender`` =
        Namespaced_IRI.parse _namespace_name "Male-Gender" |> NamespacedName

    /// <summary>
    /// This is a generic class to catch all sorts of borderline and metaphorical ways to carry things from A to B
    /// <see href="http://www.aktors.org/ontology/portal#Generalised-Means-Of-Transport"></see></summary>
    let ``Generalised-Means-Of-Transport`` =
        Namespaced_IRI.parse _namespace_name "Generalised-Means-Of-Transport" |> NamespacedName

    /// <summary>
    /// This is a generic notion, an agent can be an organization, a person an animal, a software agent, etc
    /// <see href="http://www.aktors.org/ontology/portal#Generic-Agent"></see></summary>
    let ``Generic-Agent`` =
        Namespaced_IRI.parse _namespace_name "Generic-Agent" |> NamespacedName

    /// <summary>
    /// 'Real' geographical regions
    /// <see href="http://www.aktors.org/ontology/portal#Geographical-Region"></see></summary>
    let ``Geographical-Region`` =
        Namespaced_IRI.parse _namespace_name "Geographical-Region" |> NamespacedName

    /// <summary>
    /// A generic class for locations.  It includes both real and fantastic places
    /// <see href="http://www.aktors.org/ontology/portal#Location"></see></summary>
    let Location = Namespaced_IRI.parse _namespace_name "Location" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Giving-A-Talk"></see>
    /// </summary>
    let ``Giving-A-Talk`` =
        Namespaced_IRI.parse _namespace_name "Giving-A-Talk" |> NamespacedName

    /// <summary>
    /// A generalized transfer in which information is passed from main agent to one or more recipient agents.  Examples include giving a tutorial.
    /// <see href="http://www.aktors.org/ontology/portal#Information-Transfer-Event"></see></summary>
    let ``Information-Transfer-Event`` =
        Namespaced_IRI.parse _namespace_name "Information-Transfer-Event" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Government"></see>
    /// </summary>
    let Government = Namespaced_IRI.parse _namespace_name "Government" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Graphic-Designer"></see>
    /// </summary>
    let ``Graphic-Designer`` =
        Namespaced_IRI.parse _namespace_name "Graphic-Designer" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Hardware-Platform"></see>
    /// </summary>
    let ``Hardware-Platform`` =
        Namespaced_IRI.parse _namespace_name "Hardware-Platform" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Hardware-Technology"></see>
    /// </summary>
    let ``Hardware-Technology`` =
        Namespaced_IRI.parse _namespace_name "Hardware-Technology" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Human-Computer-Interaction"></see>
    /// </summary>
    let ``Human-Computer-Interaction`` =
        Namespaced_IRI.parse _namespace_name "Human-Computer-Interaction" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Software-Technology"></see>
    /// </summary>
    let ``Software-Technology`` =
        Namespaced_IRI.parse _namespace_name "Software-Technology" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Incidental-KA"></see>
    /// </summary>
    let ``Incidental-KA`` =
        Namespaced_IRI.parse _namespace_name "Incidental-KA" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Knowledge-Acquisition"></see>
    /// </summary>
    let ``Knowledge-Acquisition`` =
        Namespaced_IRI.parse _namespace_name "Knowledge-Acquisition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Industrial-Organization"></see>
    /// </summary>
    let ``Industrial-Organization`` =
        Namespaced_IRI.parse _namespace_name "Industrial-Organization" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#owned-by"></see>
    /// </summary>
    let ``owned-by`` = Namespaced_IRI.parse _namespace_name "owned-by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-author"></see>
    /// </summary>
    let ``has-author`` =
        Namespaced_IRI.parse _namespace_name "has-author" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Information-Extraction"></see>
    /// </summary>
    let ``Information-Extraction`` =
        Namespaced_IRI.parse _namespace_name "Information-Extraction" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Language-Engineering"></see>
    /// </summary>
    let ``Language-Engineering`` =
        Namespaced_IRI.parse _namespace_name "Language-Engineering" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Information-Retrieval"></see>
    /// </summary>
    let ``Information-Retrieval`` =
        Namespaced_IRI.parse _namespace_name "Information-Retrieval" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Journal"></see>
    /// </summary>
    let Journal = Namespaced_IRI.parse _namespace_name "Journal" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#contains-article"></see>
    /// </summary>
    let ``contains-article`` =
        Namespaced_IRI.parse _namespace_name "contains-article" |> NamespacedName

    /// <summary>
    /// This used to be called periodical publication.  However, many periodicals do not appear at fixed intervals, which is why librarians refer to them as serials. So, we now use the concept of serial publication and the has-periodicity slot has been removed
    /// <see href="http://www.aktors.org/ontology/portal#Serial-Publication"></see></summary>
    let ``Serial-Publication`` =
        Namespaced_IRI.parse _namespace_name "Serial-Publication" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Magazine"></see>
    /// </summary>
    let Magazine = Namespaced_IRI.parse _namespace_name "Magazine" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Knowledge-Management"></see>
    /// </summary>
    let ``Knowledge-Management`` =
        Namespaced_IRI.parse _namespace_name "Knowledge-Management" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Knowledge-Lifecycle"></see>
    /// </summary>
    let ``Knowledge-Lifecycle`` =
        Namespaced_IRI.parse _namespace_name "Knowledge-Lifecycle" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Knowledge-Maintenance"></see>
    /// </summary>
    let ``Knowledge-Maintenance`` =
        Namespaced_IRI.parse _namespace_name "Knowledge-Maintenance" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Knowledge-Modelling"></see>
    /// </summary>
    let ``Knowledge-Modelling`` =
        Namespaced_IRI.parse _namespace_name "Knowledge-Modelling" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Knowledge-Publishing"></see>
    /// </summary>
    let ``Knowledge-Publishing`` =
        Namespaced_IRI.parse _namespace_name "Knowledge-Publishing" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Knowledge-Retrieval"></see>
    /// </summary>
    let ``Knowledge-Retrieval`` =
        Namespaced_IRI.parse _namespace_name "Knowledge-Retrieval" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Knowledge-Reuse"></see>
    /// </summary>
    let ``Knowledge-Reuse`` =
        Namespaced_IRI.parse _namespace_name "Knowledge-Reuse" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Lady"></see>
    /// </summary>
    let Lady = Namespaced_IRI.parse _namespace_name "Lady" |> NamespacedName

    /// <summary>
    /// An organization is a type of legal agent
    /// <see href="http://www.aktors.org/ontology/portal#Organization"></see></summary>
    let Organization =
        Namespaced_IRI.parse _namespace_name "Organization" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Learning-Research-Area"></see>
    /// </summary>
    let ``Learning-Research-Area`` =
        Namespaced_IRI.parse _namespace_name "Learning-Research-Area" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Lecturer-In-Academia"></see>
    /// </summary>
    let ``Lecturer-In-Academia`` =
        Namespaced_IRI.parse _namespace_name "Lecturer-In-Academia" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Letter"></see>
    /// </summary>
    let Letter = Namespaced_IRI.parse _namespace_name "Letter" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Local-District"></see>
    /// </summary>
    let ``Local-District`` =
        Namespaced_IRI.parse _namespace_name "Local-District" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#MA"></see>
    /// </summary>
    let MA = Namespaced_IRI.parse _namespace_name "MA" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#MSc"></see>
    /// </summary>
    let MSc = Namespaced_IRI.parse _namespace_name "MSc" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Social-Gathering"></see>
    /// </summary>
    let ``Social-Gathering`` =
        Namespaced_IRI.parse _namespace_name "Social-Gathering" |> NamespacedName

    /// <summary>
    /// Merrian-Webster has a good set of definitions for a method. They say it is 'a systematic procedure, technique, or mode of inquiry employed by or proper to a particular discipline or art;  a systematic plan followed in presenting material for instruction; a way, technique, or process of or for doing something; a body of skills or techniques'. This is very much also what we mean by method.
    /// <see href="http://www.aktors.org/ontology/portal#Method"></see></summary>
    let Method = Namespaced_IRI.parse _namespace_name "Method" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Miss"></see>
    /// </summary>
    let Miss = Namespaced_IRI.parse _namespace_name "Miss" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Mr"></see>
    /// </summary>
    let Mr = Namespaced_IRI.parse _namespace_name "Mr" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Mrs"></see>
    /// </summary>
    let Mrs = Namespaced_IRI.parse _namespace_name "Mrs" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Ms"></see>
    /// </summary>
    let Ms = Namespaced_IRI.parse _namespace_name "Ms" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Multimedia-Designer"></see>
    /// </summary>
    let ``Multimedia-Designer`` =
        Namespaced_IRI.parse _namespace_name "Multimedia-Designer" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Multimedia-Research-Area"></see>
    /// </summary>
    let ``Multimedia-Research-Area`` =
        Namespaced_IRI.parse _namespace_name "Multimedia-Research-Area" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#News-Item"></see>
    /// </summary>
    let ``News-Item`` =
        Namespaced_IRI.parse _namespace_name "News-Item" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#contains-news-item"></see>
    /// </summary>
    let ``contains-news-item`` =
        Namespaced_IRI.parse _namespace_name "contains-news-item" |> NamespacedName

    /// <summary>
    /// This comes from the ontolingua library. A periodical-publication is published regularly, such as once every week.  Strictly speaking, the noun 'periodical' is used by librarians to refer to things published at intervals of greater than a day.  We use the phase periodical-publication to include newspapers and other daily publications, since they share many bibliographic features. The periodicity indicates how often the publication comes out. Note that this is a duration, rather than a time interval. A time interval indicates a specific time interval on the time continuum, so we need to model periodicity as a time quantity
    /// <see href="http://www.aktors.org/ontology/portal#Periodical-Publication"></see></summary>
    let ``Periodical-Publication`` =
        Namespaced_IRI.parse _namespace_name "Periodical-Publication" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Ontologies"></see>
    /// </summary>
    let Ontologies = Namespaced_IRI.parse _namespace_name "Ontologies" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Operating-System"></see>
    /// </summary>
    let ``Operating-System`` =
        Namespaced_IRI.parse _namespace_name "Operating-System" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-sub-unit"></see>
    /// </summary>
    let ``has-sub-unit`` =
        Namespaced_IRI.parse _namespace_name "has-sub-unit" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-size"></see>
    /// </summary>
    let ``has-size`` = Namespaced_IRI.parse _namespace_name "has-size" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#headed-by"></see>
    /// </summary>
    let ``headed-by`` =
        Namespaced_IRI.parse _namespace_name "headed-by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#organization-part-of"></see>
    /// </summary>
    let ``organization-part-of`` =
        Namespaced_IRI.parse _namespace_name "organization-part-of" |> NamespacedName

    /// <summary>
    /// We use EU guidelines to distinguish between different organization sizes
    /// <see href="http://www.aktors.org/ontology/portal#Organization-Size"></see></summary>
    let ``Organization-Size`` =
        Namespaced_IRI.parse _namespace_name "Organization-Size" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#affiliated-person"></see>
    /// </summary>
    let ``affiliated-person`` =
        Namespaced_IRI.parse _namespace_name "affiliated-person" |> NamespacedName

    /// <summary>
    /// An organization with over 10000 employees
    /// <see href="http://www.aktors.org/ontology/portal#very-large-size"></see></summary>
    let ``very-large-size`` =
        Namespaced_IRI.parse _namespace_name "very-large-size" |> NamespacedName

    /// <summary>
    /// An organization with more than 250 employees
    /// <see href="http://www.aktors.org/ontology/portal#large-size"></see></summary>
    let ``large-size`` =
        Namespaced_IRI.parse _namespace_name "large-size" |> NamespacedName

    /// <summary>
    /// An organization with no more than 250 employees.  It also has to be independent, i.e., less than 25% owned by one enterprise (or jointly by several enterprises) falling outside the definition of medium-sized enterprise. Finally, either the turnover total must be less than 40M Euros or the balance sheet total must be less than 27M Euros.
    /// <see href="http://www.aktors.org/ontology/portal#medium-size"></see></summary>
    let ``medium-size`` =
        Namespaced_IRI.parse _namespace_name "medium-size" |> NamespacedName

    /// <summary>
    /// An organization with no more than 50 employees.  It also has to be independent, i.e., less than 25% owned by one enterprise (or jointly by several enterprises) falling outside the definition of small-sized enterprise. Finally, either the turnover total must be less than 7M Euros or the balance sheet total must be less than 5M Euros.
    /// <see href="http://www.aktors.org/ontology/portal#small-size"></see></summary>
    let ``small-size`` =
        Namespaced_IRI.parse _namespace_name "small-size" |> NamespacedName

    /// <summary>
    /// An organization with no more than 10 employees.  It also has to be independent, i.e., less than 25% owned by one enterprise (or jointly by several enterprises) falling outside the definition of micro-sized enterprise.
    /// <see href="http://www.aktors.org/ontology/portal#micro-size"></see></summary>
    let ``micro-size`` =
        Namespaced_IRI.parse _namespace_name "micro-size" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Organizational-Learning"></see>
    /// </summary>
    let ``Organizational-Learning`` =
        Namespaced_IRI.parse _namespace_name "Organizational-Learning" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Part-Time"></see>
    /// </summary>
    let ``Part-Time`` =
        Namespaced_IRI.parse _namespace_name "Part-Time" |> NamespacedName

    /// <summary>
    /// A partnership is not necessarily a company, e.g. a consultancy firm is not a company
    /// <see href="http://www.aktors.org/ontology/portal#Partnership"></see></summary>
    let Partnership =
        Namespaced_IRI.parse _namespace_name "Partnership" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#PhD"></see>
    /// </summary>
    let PhD = Namespaced_IRI.parse _namespace_name "PhD" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#PhD-Student"></see>
    /// </summary>
    let ``PhD-Student`` =
        Namespaced_IRI.parse _namespace_name "PhD-Student" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#studies-at"></see>
    /// </summary>
    let ``studies-at`` =
        Namespaced_IRI.parse _namespace_name "studies-at" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Student"></see>
    /// </summary>
    let Student = Namespaced_IRI.parse _namespace_name "Student" |> NamespacedName

    /// <summary>
    /// An organization which has a political connotation
    /// <see href="http://www.aktors.org/ontology/portal#Political-Organization"></see></summary>
    let ``Political-Organization`` =
        Namespaced_IRI.parse _namespace_name "Political-Organization" |> NamespacedName

    /// <summary>
    /// Modified to allow addresses to be given as strings, with no structure
    /// <see href="http://www.aktors.org/ontology/portal#Postal-Address"></see></summary>
    let ``Postal-Address`` =
        Namespaced_IRI.parse _namespace_name "Postal-Address" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Private-Company"></see>
    /// </summary>
    let ``Private-Company`` =
        Namespaced_IRI.parse _namespace_name "Private-Company" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Problem-Solving-Methods"></see>
    /// </summary>
    let ``Problem-Solving-Methods`` =
        Namespaced_IRI.parse _namespace_name "Problem-Solving-Methods" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Proceedings-Paper-Reference"></see>
    /// </summary>
    let ``Proceedings-Paper-Reference`` =
        Namespaced_IRI.parse _namespace_name "Proceedings-Paper-Reference" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Prof"></see>
    /// </summary>
    let Prof = Namespaced_IRI.parse _namespace_name "Prof" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Professor-In-Academia"></see>
    /// </summary>
    let ``Professor-In-Academia`` =
        Namespaced_IRI.parse _namespace_name "Professor-In-Academia" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Programming-Environment"></see>
    /// </summary>
    let ``Programming-Environment`` =
        Namespaced_IRI.parse _namespace_name "Programming-Environment" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Programming-Language"></see>
    /// </summary>
    let ``Programming-Language`` =
        Namespaced_IRI.parse _namespace_name "Programming-Language" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#supports-language"></see>
    /// </summary>
    let ``supports-language`` =
        Namespaced_IRI.parse _namespace_name "supports-language" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Specification-Or-Computing-Language"></see>
    /// </summary>
    let ``Specification-Or-Computing-Language`` =
        Namespaced_IRI.parse _namespace_name "Specification-Or-Computing-Language" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Project"></see>
    /// </summary>
    let Project = Namespaced_IRI.parse _namespace_name "Project" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-project-member"></see>
    /// </summary>
    let ``has-project-member`` =
        Namespaced_IRI.parse _namespace_name "has-project-member" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#involves-organization"></see>
    /// </summary>
    let ``involves-organization`` =
        Namespaced_IRI.parse _namespace_name "involves-organization" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#produces-output"></see>
    /// </summary>
    let ``produces-output`` =
        Namespaced_IRI.parse _namespace_name "produces-output" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Project-Officer-In-Academia"></see>
    /// </summary>
    let ``Project-Officer-In-Academia`` =
        Namespaced_IRI.parse _namespace_name "Project-Officer-In-Academia" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Public-Company"></see>
    /// </summary>
    let ``Public-Company`` =
        Namespaced_IRI.parse _namespace_name "Public-Company" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#cites-publication-reference"></see>
    /// </summary>
    let ``cites-publication-reference`` =
        Namespaced_IRI.parse _namespace_name "cites-publication-reference" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-place-of-publication"></see>
    /// </summary>
    let ``has-place-of-publication`` =
        Namespaced_IRI.parse _namespace_name "has-place-of-publication" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-date"></see>
    /// </summary>
    let ``has-date`` = Namespaced_IRI.parse _namespace_name "has-date" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#event-product"></see>
    /// </summary>
    let ``event-product`` =
        Namespaced_IRI.parse _namespace_name "event-product" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#R-And-D-Institute"></see>
    /// </summary>
    let ``R-And-D-Institute`` =
        Namespaced_IRI.parse _namespace_name "R-And-D-Institute" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#R-And-D-Institute-Within-Larger-Institute"></see>
    /// </summary>
    let ``R-And-D-Institute-Within-Larger-Institute`` =
        Namespaced_IRI.parse _namespace_name "R-And-D-Institute-Within-Larger-Institute" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Reader-In-Academia"></see>
    /// </summary>
    let ``Reader-In-Academia`` =
        Namespaced_IRI.parse _namespace_name "Reader-In-Academia" |> NamespacedName

    /// <summary>
    /// Any kind of recorded audio, which is tangible.  This also includes a audio file on a machine
    /// <see href="http://www.aktors.org/ontology/portal#Recorded-Audio"></see></summary>
    let ``Recorded-Audio`` =
        Namespaced_IRI.parse _namespace_name "Recorded-Audio" |> NamespacedName

    /// <summary>
    /// Any kind of recorded video, which is tangible.  This also includes a mpeg file on a machine
    /// <see href="http://www.aktors.org/ontology/portal#Recorded-Video"></see></summary>
    let ``Recorded-Video`` =
        Namespaced_IRI.parse _namespace_name "Recorded-Video" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Released-Version"></see>
    /// </summary>
    let ``Released-Version`` =
        Namespaced_IRI.parse _namespace_name "Released-Version" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Research-Assistant-In-Academia"></see>
    /// </summary>
    let ``Research-Assistant-In-Academia`` =
        Namespaced_IRI.parse _namespace_name "Research-Assistant-In-Academia" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Researcher-In-Academia"></see>
    /// </summary>
    let ``Researcher-In-Academia`` =
        Namespaced_IRI.parse _namespace_name "Researcher-In-Academia" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Research-Fellow-In-Academia"></see>
    /// </summary>
    let ``Research-Fellow-In-Academia`` =
        Namespaced_IRI.parse _namespace_name "Research-Fellow-In-Academia" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Researcher"></see>
    /// </summary>
    let Researcher = Namespaced_IRI.parse _namespace_name "Researcher" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#School"></see>
    /// </summary>
    let School = Namespaced_IRI.parse _namespace_name "School" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Scripting-Language"></see>
    /// </summary>
    let ``Scripting-Language`` =
        Namespaced_IRI.parse _namespace_name "Scripting-Language" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Secretary"></see>
    /// </summary>
    let Secretary = Namespaced_IRI.parse _namespace_name "Secretary" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Self-Employed-Person"></see>
    /// </summary>
    let ``Self-Employed-Person`` =
        Namespaced_IRI.parse _namespace_name "Self-Employed-Person" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Semantic-Web-Area"></see>
    /// </summary>
    let ``Semantic-Web-Area`` =
        Namespaced_IRI.parse _namespace_name "Semantic-Web-Area" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Web-Research-Area"></see>
    /// </summary>
    let ``Web-Research-Area`` =
        Namespaced_IRI.parse _namespace_name "Web-Research-Area" |> NamespacedName

    /// <summary>
    /// a generalized transfer in which information is passed from main agent to one or more recipient agents.  examples include giving a tutorial.
    /// <see href="http://www.aktors.org/ontology/portal#Sending-An-Email"></see></summary>
    let ``Sending-An-Email`` =
        Namespaced_IRI.parse _namespace_name "Sending-An-Email" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#information-transfer-medium-used"></see>
    /// </summary>
    let ``information-transfer-medium-used`` =
        Namespaced_IRI.parse _namespace_name "information-transfer-medium-used" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#information-object-being-transferred"></see>
    /// </summary>
    let ``information-object-being-transferred`` =
        Namespaced_IRI.parse _namespace_name "information-object-being-transferred" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Senior-Lecturer-In-Academia"></see>
    /// </summary>
    let ``Senior-Lecturer-In-Academia`` =
        Namespaced_IRI.parse _namespace_name "Senior-Lecturer-In-Academia" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Senior-Research-Fellow-In-Academia"></see>
    /// </summary>
    let ``Senior-Research-Fellow-In-Academia`` =
        Namespaced_IRI.parse _namespace_name "Senior-Research-Fellow-In-Academia" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Sir"></see>
    /// </summary>
    let Sir = Namespaced_IRI.parse _namespace_name "Sir" |> NamespacedName

    /// <summary>
    /// SME are important, so we define a class to represent them explicitly. In some case we might not know or we do not want to bother specifying excatly whether something is a small-organization or a medium-organization. Hence, we can just say 'x is a SME' without going into further detail.
    /// <see href="http://www.aktors.org/ontology/portal#Small-Or-Medium-Sized-Organization"></see></summary>
    let ``Small-Or-Medium-Sized-Organization`` =
        Namespaced_IRI.parse _namespace_name "Small-Or-Medium-Sized-Organization" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Software-Visualization"></see>
    /// </summary>
    let ``Software-Visualization`` =
        Namespaced_IRI.parse _namespace_name "Software-Visualization" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Specification-Language"></see>
    /// </summary>
    let ``Specification-Language`` =
        Namespaced_IRI.parse _namespace_name "Specification-Language" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#studies-in-unit"></see>
    /// </summary>
    let ``studies-in-unit`` =
        Namespaced_IRI.parse _namespace_name "studies-in-unit" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#System-Administrator"></see>
    /// </summary>
    let ``System-Administrator`` =
        Namespaced_IRI.parse _namespace_name "System-Administrator" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Technical-Report-Reference"></see>
    /// </summary>
    let ``Technical-Report-Reference`` =
        Namespaced_IRI.parse _namespace_name "Technical-Report-Reference" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Telepresence-Research-Area"></see>
    /// </summary>
    let ``Telepresence-Research-Area`` =
        Namespaced_IRI.parse _namespace_name "Telepresence-Research-Area" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Thesis-Reference"></see>
    /// </summary>
    let ``Thesis-Reference`` =
        Namespaced_IRI.parse _namespace_name "Thesis-Reference" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Town"></see>
    /// </summary>
    let Town = Namespaced_IRI.parse _namespace_name "Town" |> NamespacedName

    /// <summary>
    /// Something tangible designed to transport people, animals, objects from A to B. For instance a bycicle, a car, a boat, etc.
    /// <see href="http://www.aktors.org/ontology/portal#Transportation-Device"></see></summary>
    let ``Transportation-Device`` =
        Namespaced_IRI.parse _namespace_name "Transportation-Device" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#University-Faculty"></see>
    /// </summary>
    let ``University-Faculty`` =
        Namespaced_IRI.parse _namespace_name "University-Faculty" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Village"></see>
    /// </summary>
    let Village = Namespaced_IRI.parse _namespace_name "Village" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Visiting-Researcher"></see>
    /// </summary>
    let ``Visiting-Researcher`` =
        Namespaced_IRI.parse _namespace_name "Visiting-Researcher" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Web-Based-Editor"></see>
    /// </summary>
    let ``Web-Based-Editor`` =
        Namespaced_IRI.parse _namespace_name "Web-Based-Editor" |> NamespacedName

    /// <summary>
    /// A system which is accessible through the web
    /// <see href="http://www.aktors.org/ontology/portal#Web-Based-System"></see></summary>
    let ``Web-Based-System`` =
        Namespaced_IRI.parse _namespace_name "Web-Based-System" |> NamespacedName

    /// <summary>
    /// A web browser is not a web-based system!
    /// <see href="http://www.aktors.org/ontology/portal#Web-Browser"></see></summary>
    let ``Web-Browser`` =
        Namespaced_IRI.parse _namespace_name "Web-Browser" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Web-Reference"></see>
    /// </summary>
    let ``Web-Reference`` =
        Namespaced_IRI.parse _namespace_name "Web-Reference" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Web-Site"></see>
    /// </summary>
    let ``Web-Site`` = Namespaced_IRI.parse _namespace_name "Web-Site" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Workshop"></see>
    /// </summary>
    let Workshop = Namespaced_IRI.parse _namespace_name "Workshop" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#Workshop-Proceedings-Reference"></see>
    /// </summary>
    let ``Workshop-Proceedings-Reference`` =
        Namespaced_IRI.parse _namespace_name "Workshop-Proceedings-Reference" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#address-area"></see>
    /// </summary>
    let ``address-area`` =
        Namespaced_IRI.parse _namespace_name "address-area" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#address-building"></see>
    /// </summary>
    let ``address-building`` =
        Namespaced_IRI.parse _namespace_name "address-building" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#address-city-or-village"></see>
    /// </summary>
    let ``address-city-or-village`` =
        Namespaced_IRI.parse _namespace_name "address-city-or-village" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#address-country"></see>
    /// </summary>
    let ``address-country`` =
        Namespaced_IRI.parse _namespace_name "address-country" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#address-number"></see>
    /// </summary>
    let ``address-number`` =
        Namespaced_IRI.parse _namespace_name "address-number" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#address-postcode"></see>
    /// </summary>
    let ``address-postcode`` =
        Namespaced_IRI.parse _namespace_name "address-postcode" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#address-pretty-label"></see>
    /// </summary>
    let ``address-pretty-label`` =
        Namespaced_IRI.parse _namespace_name "address-pretty-label" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#address-region"></see>
    /// </summary>
    let ``address-region`` =
        Namespaced_IRI.parse _namespace_name "address-region" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#address-street"></see>
    /// </summary>
    let ``address-street`` =
        Namespaced_IRI.parse _namespace_name "address-street" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#addresses-generic-area-of-interest"></see>
    /// </summary>
    let ``addresses-generic-area-of-interest`` =
        Namespaced_IRI.parse _namespace_name "addresses-generic-area-of-interest" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#affiliated-people"></see>
    /// </summary>
    let ``affiliated-people`` =
        Namespaced_IRI.parse _namespace_name "affiliated-people" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#confers-award"></see>
    /// </summary>
    let ``confers-award`` =
        Namespaced_IRI.parse _namespace_name "confers-award" |> NamespacedName

    /// <summary>
    /// What is being transferred
    /// <see href="http://www.aktors.org/ontology/portal#thing-acted-on"></see></summary>
    let ``thing-acted-on`` =
        Namespaced_IRI.parse _namespace_name "thing-acted-on" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#contains-property"></see>
    /// </summary>
    let ``contains-property`` =
        Namespaced_IRI.parse _namespace_name "contains-property" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#family-name"></see>
    /// </summary>
    let ``family-name`` =
        Namespaced_IRI.parse _namespace_name "family-name" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#full-name"></see>
    /// </summary>
    let ``full-name`` =
        Namespaced_IRI.parse _namespace_name "full-name" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#funding-source"></see>
    /// </summary>
    let ``funding-source`` =
        Namespaced_IRI.parse _namespace_name "funding-source" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#given-name"></see>
    /// </summary>
    let ``given-name`` =
        Namespaced_IRI.parse _namespace_name "given-name" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#government-of-country"></see>
    /// </summary>
    let ``government-of-country`` =
        Namespaced_IRI.parse _namespace_name "government-of-country" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-ISBN-number"></see>
    /// </summary>
    let ``has-ISBN-number`` =
        Namespaced_IRI.parse _namespace_name "has-ISBN-number" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-URL"></see>
    /// </summary>
    let ``has-URL`` = Namespaced_IRI.parse _namespace_name "has-URL" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-academic-degree"></see>
    /// </summary>
    let ``has-academic-degree`` =
        Namespaced_IRI.parse _namespace_name "has-academic-degree" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-academic-unit"></see>
    /// </summary>
    let ``has-academic-unit`` =
        Namespaced_IRI.parse _namespace_name "has-academic-unit" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-affiliation-to-unit"></see>
    /// </summary>
    let ``has-affiliation-to-unit`` =
        Namespaced_IRI.parse _namespace_name "has-affiliation-to-unit" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-amount"></see>
    /// </summary>
    let ``has-amount`` =
        Namespaced_IRI.parse _namespace_name "has-amount" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-appellation"></see>
    /// </summary>
    let ``has-appellation`` =
        Namespaced_IRI.parse _namespace_name "has-appellation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-award-rationale"></see>
    /// </summary>
    let ``has-award-rationale`` =
        Namespaced_IRI.parse _namespace_name "has-award-rationale" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-awarding-body"></see>
    /// </summary>
    let ``has-awarding-body`` =
        Namespaced_IRI.parse _namespace_name "has-awarding-body" |> NamespacedName

    /// <summary>
    /// The agents causing the event to happen, if they are known.
    /// <see href="http://www.aktors.org/ontology/portal#has-main-agent"></see></summary>
    let ``has-main-agent`` =
        Namespaced_IRI.parse _namespace_name "has-main-agent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-capital"></see>
    /// </summary>
    let ``has-capital`` =
        Namespaced_IRI.parse _namespace_name "has-capital" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#is-capital-of"></see>
    /// </summary>
    let ``is-capital-of`` =
        Namespaced_IRI.parse _namespace_name "is-capital-of" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-contract-type"></see>
    /// </summary>
    let ``has-contract-type`` =
        Namespaced_IRI.parse _namespace_name "has-contract-type" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-currency"></see>
    /// </summary>
    let ``has-currency`` =
        Namespaced_IRI.parse _namespace_name "has-currency" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-email-address"></see>
    /// </summary>
    let ``has-email-address`` =
        Namespaced_IRI.parse _namespace_name "has-email-address" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-faculty"></see>
    /// </summary>
    let ``has-faculty`` =
        Namespaced_IRI.parse _namespace_name "has-faculty" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-fax-number"></see>
    /// </summary>
    let ``has-fax-number`` =
        Namespaced_IRI.parse _namespace_name "has-fax-number" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-gender"></see>
    /// </summary>
    let ``has-gender`` =
        Namespaced_IRI.parse _namespace_name "has-gender" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-goals"></see>
    /// </summary>
    let ``has-goals`` =
        Namespaced_IRI.parse _namespace_name "has-goals" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-government"></see>
    /// </summary>
    let ``has-government`` =
        Namespaced_IRI.parse _namespace_name "has-government" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-job-title"></see>
    /// </summary>
    let ``has-job-title`` =
        Namespaced_IRI.parse _namespace_name "has-job-title" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-leading-organization"></see>
    /// </summary>
    let ``has-leading-organization`` =
        Namespaced_IRI.parse _namespace_name "has-leading-organization" |> NamespacedName

    /// <summary>
    /// The location at which an event takes place
    /// <see href="http://www.aktors.org/ontology/portal#has-location"></see></summary>
    let ``has-location`` =
        Namespaced_IRI.parse _namespace_name "has-location" |> NamespacedName

    /// <summary>
    /// Other agents involved in the event
    /// <see href="http://www.aktors.org/ontology/portal#has-other-agents-involved"></see></summary>
    let ``has-other-agents-involved`` =
        Namespaced_IRI.parse _namespace_name "has-other-agents-involved" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-page-numbers"></see>
    /// </summary>
    let ``has-page-numbers`` =
        Namespaced_IRI.parse _namespace_name "has-page-numbers" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-postal-address"></see>
    /// </summary>
    let ``has-postal-address`` =
        Namespaced_IRI.parse _namespace_name "has-postal-address" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-project-leader"></see>
    /// </summary>
    let ``has-project-leader`` =
        Namespaced_IRI.parse _namespace_name "has-project-leader" |> NamespacedName

    /// <summary>
    /// People and in general even organizations and organization units may have research interests.  This relation shoudl be used to specify them
    /// <see href="http://www.aktors.org/ontology/portal#has-research-interest"></see></summary>
    let ``has-research-interest`` =
        Namespaced_IRI.parse _namespace_name "has-research-interest" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-speaker"></see>
    /// </summary>
    let ``has-speaker`` =
        Namespaced_IRI.parse _namespace_name "has-speaker" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#sender-of-information"></see>
    /// </summary>
    let ``sender-of-information`` =
        Namespaced_IRI.parse _namespace_name "sender-of-information" |> NamespacedName

    /// <summary>
    /// Whether the software is released, alpha or beta
    /// <see href="http://www.aktors.org/ontology/portal#has-status"></see></summary>
    let ``has-status`` =
        Namespaced_IRI.parse _namespace_name "has-status" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-sub-activity"></see>
    /// </summary>
    let ``has-sub-activity`` =
        Namespaced_IRI.parse _namespace_name "has-sub-activity" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-supervisor"></see>
    /// </summary>
    let ``has-supervisor`` =
        Namespaced_IRI.parse _namespace_name "has-supervisor" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-support-unit"></see>
    /// </summary>
    let ``has-support-unit`` =
        Namespaced_IRI.parse _namespace_name "has-support-unit" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-telephone-number"></see>
    /// </summary>
    let ``has-telephone-number`` =
        Namespaced_IRI.parse _namespace_name "has-telephone-number" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-title"></see>
    /// </summary>
    let ``has-title`` =
        Namespaced_IRI.parse _namespace_name "has-title" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-vice-chancellor"></see>
    /// </summary>
    let ``has-vice-chancellor`` =
        Namespaced_IRI.parse _namespace_name "has-vice-chancellor" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#has-web-address"></see>
    /// </summary>
    let ``has-web-address`` =
        Namespaced_IRI.parse _namespace_name "has-web-address" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#information-being-transferred"></see>
    /// </summary>
    let ``information-being-transferred`` =
        Namespaced_IRI.parse _namespace_name "information-being-transferred" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#means-of-transport-used"></see>
    /// </summary>
    let ``means-of-transport-used`` =
        Namespaced_IRI.parse _namespace_name "means-of-transport-used" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#issued-by"></see>
    /// </summary>
    let ``issued-by`` =
        Namespaced_IRI.parse _namespace_name "issued-by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#meeting-attendee"></see>
    /// </summary>
    let ``meeting-attendee`` =
        Namespaced_IRI.parse _namespace_name "meeting-attendee" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#meeting-organizer"></see>
    /// </summary>
    let ``meeting-organizer`` =
        Namespaced_IRI.parse _namespace_name "meeting-organizer" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#method-builds-on"></see>
    /// </summary>
    let ``method-builds-on`` =
        Namespaced_IRI.parse _namespace_name "method-builds-on" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#organization-being-visited"></see>
    /// </summary>
    let ``organization-being-visited`` =
        Namespaced_IRI.parse _namespace_name "organization-being-visited" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#organization-unit-being-visited"></see>
    /// </summary>
    let ``organization-unit-being-visited`` =
        Namespaced_IRI.parse _namespace_name "organization-unit-being-visited" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#person-being-visited"></see>
    /// </summary>
    let ``person-being-visited`` =
        Namespaced_IRI.parse _namespace_name "person-being-visited" |> NamespacedName

    /// <summary>
    /// It is sufficient that somebody in unit ?u works in project ?p
    /// <see href="http://www.aktors.org/ontology/portal#project-involves-organization-unit"></see></summary>
    let ``project-involves-organization-unit`` =
        Namespaced_IRI.parse _namespace_name "project-involves-organization-unit" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#published-book"></see>
    /// </summary>
    let ``published-book`` =
        Namespaced_IRI.parse _namespace_name "published-book" |> NamespacedName

    /// <summary>
    /// The agents which receive the thing-acted-on
    /// <see href="http://www.aktors.org/ontology/portal#recipient-agents"></see></summary>
    let ``recipient-agents`` =
        Namespaced_IRI.parse _namespace_name "recipient-agents" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#recipient-of-message"></see>
    /// </summary>
    let ``recipient-of-message`` =
        Namespaced_IRI.parse _namespace_name "recipient-of-message" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#requires-hardware-platform"></see>
    /// </summary>
    let ``requires-hardware-platform`` =
        Namespaced_IRI.parse _namespace_name "requires-hardware-platform" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#requires-hardware-platform-on-client-side"></see>
    /// </summary>
    let ``requires-hardware-platform-on-client-side`` =
        Namespaced_IRI.parse _namespace_name "requires-hardware-platform-on-client-side" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#requires-hardware-platform-on-server-side"></see>
    /// </summary>
    let ``requires-hardware-platform-on-server-side`` =
        Namespaced_IRI.parse _namespace_name "requires-hardware-platform-on-server-side" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#requires-software-technology"></see>
    /// </summary>
    let ``requires-software-technology`` =
        Namespaced_IRI.parse _namespace_name "requires-software-technology" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#requires-software-technology-on-client-side"></see>
    /// </summary>
    let ``requires-software-technology-on-client-side`` =
        Namespaced_IRI.parse _namespace_name "requires-software-technology-on-client-side" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#requires-software-technology-on-server-side"></see>
    /// </summary>
    let ``requires-software-technology-on-server-side`` =
        Namespaced_IRI.parse _namespace_name "requires-software-technology-on-server-side" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#runs-on-operating-system"></see>
    /// </summary>
    let ``runs-on-operating-system`` =
        Namespaced_IRI.parse _namespace_name "runs-on-operating-system" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#runs-on-operating-system-on-client-side"></see>
    /// </summary>
    let ``runs-on-operating-system-on-client-side`` =
        Namespaced_IRI.parse _namespace_name "runs-on-operating-system-on-client-side" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#runs-on-operating-system-on-server-side"></see>
    /// </summary>
    let ``runs-on-operating-system-on-server-side`` =
        Namespaced_IRI.parse _namespace_name "runs-on-operating-system-on-server-side" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#sender-of-message"></see>
    /// </summary>
    let ``sender-of-message`` =
        Namespaced_IRI.parse _namespace_name "sender-of-message" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#sub-unit-of-organization-unit"></see>
    /// </summary>
    let ``sub-unit-of-organization-unit`` =
        Namespaced_IRI.parse _namespace_name "sub-unit-of-organization-unit" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#subsidiary-of"></see>
    /// </summary>
    let ``subsidiary-of`` =
        Namespaced_IRI.parse _namespace_name "subsidiary-of" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#supports-method"></see>
    /// </summary>
    let ``supports-method`` =
        Namespaced_IRI.parse _namespace_name "supports-method" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#technology-builds-on"></see>
    /// </summary>
    let ``technology-builds-on`` =
        Namespaced_IRI.parse _namespace_name "technology-builds-on" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#time-of-message"></see>
    /// </summary>
    let ``time-of-message`` =
        Namespaced_IRI.parse _namespace_name "time-of-message" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#uses-resource"></see>
    /// </summary>
    let ``uses-resource`` =
        Namespaced_IRI.parse _namespace_name "uses-resource" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.aktors.org/ontology/portal#works-in-unit"></see>
    /// </summary>
    let ``works-in-unit`` =
        Namespaced_IRI.parse _namespace_name "works-in-unit" |> NamespacedName
