namespace http.dati.beniculturali.it.cis.slash

open DoxAletheia.Rdf_Vocabulary

module cis =
    let _namespace_name = "http://dati.beniculturali.it/cis/"

    /// <summary>
    ///   <see href="http://dati.beniculturali.it/cis/img/cultural-ON.png"></see>
    /// </summary>
    let ``img/cultural-ON.png`` =
        Namespaced_IRI.parse _namespace_name "img/cultural-ON.png" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.beniculturali.it/cis/2.0"></see>
    /// </summary>
    let ``_2.0`` = Namespaced_IRI.parse _namespace_name "2.0" |> NamespacedName

    /// <summary>
    /// Concept used to represent general information for the public access to the Cultural Institute or Site or to the Event. For instance, examples of information include: opening hours, type of admission, temporary closing, etc.
    /// <see href="http://dati.beniculturali.it/cis/AccessCondition"></see></summary>
    let AccessCondition =
        Namespaced_IRI.parse _namespace_name "AccessCondition" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.beniculturali.it/cis/img/access.png"></see>
    /// </summary>
    let ``img/access.png`` =
        Namespaced_IRI.parse _namespace_name "img/access.png" |> NamespacedName

    /// <summary>
    /// Inverse property of "has access condition"
    /// <see href="http://dati.beniculturali.it/cis/accessConditionFor"></see></summary>
    let accessConditionFor =
        Namespaced_IRI.parse _namespace_name "accessConditionFor" |> NamespacedName

    /// <summary>
    /// The class Cultural Institute or Site represents museums, libraries, archive holders, archaeologic areas and parks, monumental areas. The cultural institutes of sites that are owned by public bodies are meant to offer public services. The cultural institutes or sites that are owned by private subjects, and are open to the public, offer a public and societal service.
    /// <see href="http://dati.beniculturali.it/cis/CulturalInstituteOrSite"></see></summary>
    let CulturalInstituteOrSite =
        Namespaced_IRI.parse _namespace_name "CulturalInstituteOrSite" |> NamespacedName

    /// <summary>
    /// it represents an event that typically is related to the cultural domain
    /// <see href="http://dati.beniculturali.it/cis/Event"></see></summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName
    /// <summary>
    /// It represents an address as defined by the specifications of the EU INSPIRE directive https://inspire-twg.jrc.ec.europa.eu/inspire-fc.html#_C2538
    /// <see href="http://dati.beniculturali.it/cis/Address"></see></summary>
    let Address = Namespaced_IRI.parse _namespace_name "Address" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.beniculturali.it/cis/img/address.png"></see>
    /// </summary>
    let ``img/address.png`` =
        Namespaced_IRI.parse _namespace_name "img/address.png" |> NamespacedName

    /// <summary>
    /// Property used to represent the globally unique identifier for each instance of an address. A crucial part of the INSPIRE data specifications. Subproperty of identifier.
    /// <see href="http://dati.beniculturali.it/cis/addressID"></see></summary>
    let addressID = Namespaced_IRI.parse _namespace_name "addressID" |> NamespacedName

    /// <summary>
    /// Property used to represent the uppermost administrative unit for the address of the site of the cultural institute or site, almost always a country.
    /// <see href="http://dati.beniculturali.it/cis/adminUnitL1"></see></summary>
    let adminUnitL1 =
        Namespaced_IRI.parse _namespace_name "adminUnitL1" |> NamespacedName

    /// <summary>
    /// Property used to represent the post code of the address of the site of a cultural institute or site.
    /// <see href="http://dati.beniculturali.it/cis/postCode"></see></summary>
    let postCode = Namespaced_IRI.parse _namespace_name "postCode" |> NamespacedName

    /// <summary>
    /// Property used to represent the full address of the site of a cultural institute or site.
    /// <see href="http://dati.beniculturali.it/cis/fullAddress"></see></summary>
    let fullAddress =
        Namespaced_IRI.parse _namespace_name "fullAddress" |> NamespacedName

    /// <summary>
    /// Property used to represent the region of the address of the site of a cultural institute or site, usually a county, state or other such area that typically encompasses several localities.
    /// <see href="http://dati.beniculturali.it/cis/adminUnitL2"></see></summary>
    let adminUnitL2 =
        Namespaced_IRI.parse _namespace_name "adminUnitL2" |> NamespacedName

    /// <summary>
    /// Property used to represent the key postal division of the address of the site of the cultural institute or site, usually the city. (INSPIRE's definition is 'One or more names created and maintained for postal purposes to identify a subdivision of addresses and postal delivery points.').
    /// <see href="http://dati.beniculturali.it/cis/postName"></see></summary>
    let postName = Namespaced_IRI.parse _namespace_name "postName" |> NamespacedName

    /// <summary>
    /// It represents the type of admission. Examples are: weekly, monthly, daily, etc.
    /// <see href="http://dati.beniculturali.it/cis/AdmissionType"></see></summary>
    let AdmissionType =
        Namespaced_IRI.parse _namespace_name "AdmissionType" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.beniculturali.it/cis/img/admissionType.png"></see>
    /// </summary>
    let ``img/admissionType.png`` =
        Namespaced_IRI.parse _namespace_name "img/admissionType.png" |> NamespacedName

    /// <summary>
    /// Property used to associate a name with an event and a project
    /// <see href="http://dati.beniculturali.it/cis/name"></see></summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName

    /// <summary>
    /// This property is used to indicate a description of the cultural institute or site
    /// <see href="http://dati.beniculturali.it/cis/description"></see></summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    /// It represents an agent. It can be an organization (public and/or private), an association/foundation or a single person. In the context of this ontology it can be a municipality, a supervision authority, a single private citizen
    /// <see href="http://dati.beniculturali.it/cis/Agent"></see></summary>
    let Agent = Namespaced_IRI.parse _namespace_name "Agent" |> NamespacedName

    /// <summary>
    /// Property used to associate an agent with the situation role in time the agent can play
    /// <see href="http://dati.beniculturali.it/cis/holdsRoleInTime"></see></summary>
    let holdsRoleInTime =
        Namespaced_IRI.parse _namespace_name "holdsRoleInTime" |> NamespacedName

    /// <summary>
    /// Concept used to represent a situation in which a role can vary in time. In this specific domain, it is the role of an agent played on a Cultural Institute or Site.
    /// <see href="http://dati.beniculturali.it/cis/RoleInTime"></see></summary>
    let RoleInTime = Namespaced_IRI.parse _namespace_name "RoleInTime" |> NamespacedName
    /// <summary>
    /// This property permits to represent a general belonging relationship of an agent. For instance, the property can be used to represent the case in which an agent with Role responsible acts on the cultural Istitute or site on behalf of an Organization to which (s)he belongs.
    /// <see href="http://dati.beniculturali.it/cis/reportsTo"></see></summary>
    let reportsTo = Namespaced_IRI.parse _namespace_name "reportsTo" |> NamespacedName

    /// <summary>
    /// It represents a specific type of Cultural Institute or SIte; that is, ArchaeologicalArea
    /// <see href="http://dati.beniculturali.it/cis/ArchaeologicalArea"></see></summary>
    let ArchaeologicalArea =
        Namespaced_IRI.parse _namespace_name "ArchaeologicalArea" |> NamespacedName

    /// <summary>
    /// This class represents the type of cultural institute or site.
    /// <see href="http://dati.beniculturali.it/cis/CISType"></see></summary>
    let CISType = Namespaced_IRI.parse _namespace_name "CISType" |> NamespacedName
    /// <summary>
    /// The property is used to link a cultural institure or site to its type.
    /// <see href="http://dati.beniculturali.it/cis/hasCISType"></see></summary>
    let hasCISType = Namespaced_IRI.parse _namespace_name "hasCISType" |> NamespacedName

    /// <summary>
    /// It represents a specific type of Cultural Institute or SIte; that is, Archaeological Park
    /// <see href="http://dati.beniculturali.it/cis/ArchaeologicalPark"></see></summary>
    let ArchaeologicalPark =
        Namespaced_IRI.parse _namespace_name "ArchaeologicalPark" |> NamespacedName

    /// <summary>
    /// It represents the attribute that a site description of a site of a cultural institute or site may have. For instance, length, the shelving in a library, etc.
    /// <see href="http://dati.beniculturali.it/cis/Attribute"></see></summary>
    let Attribute = Namespaced_IRI.parse _namespace_name "Attribute" |> NamespacedName

    /// <summary>
    /// Concept used to represent multimedia objects of type audio.
    /// <see href="http://dati.beniculturali.it/cis/AudioObject"></see></summary>
    let AudioObject =
        Namespaced_IRI.parse _namespace_name "AudioObject" |> NamespacedName

    /// <summary>
    /// Thi property represents an URL.
    /// <see href="http://dati.beniculturali.it/cis/url"></see></summary>
    let url = Namespaced_IRI.parse _namespace_name "url" |> NamespacedName

    /// <summary>
    /// Concept used to represent all types of creative works such multimedia objects (audio, video, image files), bibliographic references, and different types of articles, that refer to and cite the Cultural Institute or Site
    /// <see href="http://dati.beniculturali.it/cis/CreativeWork"></see></summary>
    let CreativeWork =
        Namespaced_IRI.parse _namespace_name "CreativeWork" |> NamespacedName

    /// <summary>
    /// It represents the  type of booking for the cultural institute or site or for the event. Examples can be: Mandatory, Optional, None (free access).
    /// <see href="http://dati.beniculturali.it/cis/Booking"></see></summary>
    let Booking = Namespaced_IRI.parse _namespace_name "Booking" |> NamespacedName
    /// <summary>
    /// This class represents a card valid for the entrance to more than one Cultural Institute or Site. It is a subclass of Ticket.
    /// <see href="http://dati.beniculturali.it/cis/Card"></see></summary>
    let Card = Namespaced_IRI.parse _namespace_name "Card" |> NamespacedName
    /// <summary>
    /// It represents an entrance ticket for a Cultural Institute or Site, if required, and for an event
    /// <see href="http://dati.beniculturali.it/cis/Ticket"></see></summary>
    let Ticket = Namespaced_IRI.parse _namespace_name "Ticket" |> NamespacedName
    /// <summary>
    /// Concept used to represent the catalogue which describes the set of cultural heritage objects included in a Cultural Institute or Site
    /// <see href="http://dati.beniculturali.it/cis/Catalogue"></see></summary>
    let Catalogue = Namespaced_IRI.parse _namespace_name "Catalogue" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.beniculturali.it/cis/img/catalogue.png"></see>
    /// </summary>
    let ``img/catalogue.png`` =
        Namespaced_IRI.parse _namespace_name "img/catalogue.png" |> NamespacedName

    /// <summary>
    /// Property used to associate the catalogue with the cultural heritage objects of a cultural institute or site that the catalogue describes.
    /// <see href="http://dati.beniculturali.it/cis/describes"></see></summary>
    let describes = Namespaced_IRI.parse _namespace_name "describes" |> NamespacedName
    /// <summary>
    /// It represents the cultural heritage included in a Cultural Institute or Site or single collections that compone the cultural heritage
    /// <see href="http://dati.beniculturali.it/cis/Collection"></see></summary>
    let Collection = Namespaced_IRI.parse _namespace_name "Collection" |> NamespacedName

    /// <summary>
    /// Inverse property of "has catalogue".
    /// <see href="http://dati.beniculturali.it/cis/isCatalogueOf"></see></summary>
    let isCatalogueOf =
        Namespaced_IRI.parse _namespace_name "isCatalogueOf" |> NamespacedName

    /// <summary>
    /// Property used to represent a web site
    /// <see href="http://dati.beniculturali.it/cis/hasWebSite"></see></summary>
    let hasWebSite = Namespaced_IRI.parse _namespace_name "hasWebSite" |> NamespacedName
    /// <summary>
    /// This class represents a cultural institute or site of type Cinema
    /// <see href="http://dati.beniculturali.it/cis/Cinema"></see></summary>
    let Cinema = Namespaced_IRI.parse _namespace_name "Cinema" |> NamespacedName

    /// <summary>
    /// This class represents the clerical administrative area. It can be used to represents Diocese, Parish, etc.
    /// <see href="http://dati.beniculturali.it/cis/ClericalAdministrativeArea"></see></summary>
    let ClericalAdministrativeArea =
        Namespaced_IRI.parse _namespace_name "ClericalAdministrativeArea" |> NamespacedName

    /// <summary>
    /// It represents a geographical feature. It can be used to model a municipality or an area across different administrative areas.
    /// <see href="http://dati.beniculturali.it/cis/GeographicalFeature"></see></summary>
    let GeographicalFeature =
        Namespaced_IRI.parse _namespace_name "GeographicalFeature" |> NamespacedName

    /// <summary>
    /// This property represents an identifier for a Thing.
    /// <see href="http://dati.beniculturali.it/cis/identifier"></see></summary>
    let identifier = Namespaced_IRI.parse _namespace_name "identifier" |> NamespacedName
    /// <summary>
    /// Property used to associate the situation role in time with a temporal interval. The same property is used in a similar way to link a site or a collection to a temporal interval
    /// <see href="http://dati.beniculturali.it/cis/atTime"></see></summary>
    let atTime = Namespaced_IRI.parse _namespace_name "atTime" |> NamespacedName

    /// <summary>
    /// It represents a temporal interval
    /// <see href="http://dati.beniculturali.it/cis/TimeInterval"></see></summary>
    let TimeInterval =
        Namespaced_IRI.parse _namespace_name "TimeInterval" |> NamespacedName

    /// <summary>
    /// Property that permits to specify the cultural heritage objects that form a specific collection or the entire cultural heritage included in a cultural institute or site
    /// <see href="http://dati.beniculturali.it/cis/hasMember"></see></summary>
    let hasMember = Namespaced_IRI.parse _namespace_name "hasMember" |> NamespacedName

    /// <summary>
    /// It represents a cultural asset (even intagible) of the cultural heritage.
    /// <see href="http://dati.beniculturali.it/cis/CulturalHeritageObject"></see></summary>
    let CulturalHeritageObject =
        Namespaced_IRI.parse _namespace_name "CulturalHeritageObject" |> NamespacedName

    /// <summary>
    /// Class that provides a generalization of three classes; that is , cultural institute or site, collection and cultural heritage object. It does not correspond to a concept used typically in the cultural domain but it is used in order to model properties and property restrictions that are common to all the these three classes. The class will never be directly instanziated.
    /// <see href="http://dati.beniculturali.it/cis/CulturalEntity"></see></summary>
    let CulturalEntity =
        Namespaced_IRI.parse _namespace_name "CulturalEntity" |> NamespacedName

    /// <summary>
    /// Inverse property of "describes"
    /// <see href="http://dati.beniculturali.it/cis/isDescribedBy"></see></summary>
    let isDescribedBy =
        Namespaced_IRI.parse _namespace_name "isDescribedBy" |> NamespacedName

    /// <summary>
    /// It represents a contact point which consists of phone numbers, e-mail addresses, web sites and their availability where applicable. We recommend the domain experts to specify better during the data production phase which type of contact point is in use (administrative contact point, tourist contact point, etc,).
    /// <see href="http://dati.beniculturali.it/cis/ContactPoint"></see></summary>
    let ContactPoint =
        Namespaced_IRI.parse _namespace_name "ContactPoint" |> NamespacedName

    /// <summary>
    /// Property used to represent one or more telephone numbers for the contact point
    /// <see href="http://dati.beniculturali.it/cis/hasTelephone"></see></summary>
    let hasTelephone =
        Namespaced_IRI.parse _namespace_name "hasTelephone" |> NamespacedName

    /// <summary>
    /// Property used to associate a contact point with hours specification in which the contact point is available.
    /// <see href="http://dati.beniculturali.it/cis/available"></see></summary>
    let available = Namespaced_IRI.parse _namespace_name "available" |> NamespacedName

    /// <summary>
    /// It represents the opening hours specification
    /// <see href="http://dati.beniculturali.it/cis/OpeningHoursSpecification"></see></summary>
    let OpeningHoursSpecification =
        Namespaced_IRI.parse _namespace_name "OpeningHoursSpecification" |> NamespacedName

    /// <summary>
    /// Property used to associate a certified email address to a contact point
    /// <see href="http://dati.beniculturali.it/cis/hasCertifiedEmail"></see></summary>
    let hasCertifiedEmail =
        Namespaced_IRI.parse _namespace_name "hasCertifiedEmail" |> NamespacedName

    /// <summary>
    /// Property used to specify email address for a contact point
    /// <see href="http://dati.beniculturali.it/cis/hasEmail"></see></summary>
    let hasEmail = Namespaced_IRI.parse _namespace_name "hasEmail" |> NamespacedName
    /// <summary>
    /// Property used to represent one or more fax numbers for the contact point
    /// <see href="http://dati.beniculturali.it/cis/hasFax"></see></summary>
    let hasFax = Namespaced_IRI.parse _namespace_name "hasFax" |> NamespacedName
    /// <summary>
    /// Property used to associate a creative work with a cultural entity. The same property is used in a similar way to associate the creative work with an event or site
    /// <see href="http://dati.beniculturali.it/cis/isAbout"></see></summary>
    let isAbout = Namespaced_IRI.parse _namespace_name "isAbout" |> NamespacedName
    /// <summary>
    /// It represents a georeferenced physical site related to the Cultural Institute or Site. A Cultural Institute or Site can be located in more than one physical site. For instance, a Site can be "Palazzo Venezia" which is the site of the "Museum of Palazzo Venezia" and of "Library of Archaelogy and Art History".
    /// <see href="http://dati.beniculturali.it/cis/Site"></see></summary>
    let Site = Namespaced_IRI.parse _namespace_name "Site" |> NamespacedName

    /// <summary>
    /// This class represents cultural institutions that form so-called cultural research and promotion centers.
    /// <see href="http://dati.beniculturali.it/cis/CultReseachCenter"></see></summary>
    let CultReseachCenter =
        Namespaced_IRI.parse _namespace_name "CultReseachCenter" |> NamespacedName

    /// <summary>
    /// Property that permits to associate cultural heritage objects with the site(s) which conserve(s) them
    /// <see href="http://dati.beniculturali.it/cis/isInSite"></see></summary>
    let isInSite = Namespaced_IRI.parse _namespace_name "isInSite" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.beniculturali.it/cis/img/cis.png"></see>
    /// </summary>
    let ``img/cis.png`` =
        Namespaced_IRI.parse _namespace_name "img/cis.png" |> NamespacedName

    /// <summary>
    /// Property used to associate the Cultural Institute or Site with the set of cultural objects it contains.
    /// <see href="http://dati.beniculturali.it/cis/hasCollection"></see></summary>
    let hasCollection =
        Namespaced_IRI.parse _namespace_name "hasCollection" |> NamespacedName

    /// <summary>
    /// Property used to represent an involvement relationship between a cultural institute or site and a project
    /// <see href="http://dati.beniculturali.it/cis/isInvolvedInProject"></see></summary>
    let isInvolvedInProject =
        Namespaced_IRI.parse _namespace_name "isInvolvedInProject" |> NamespacedName

    /// <summary>
    /// It represents a Project the Cultural Institute and Site can be involved in.
    /// <see href="http://dati.beniculturali.it/cis/Project"></see></summary>
    let Project = Namespaced_IRI.parse _namespace_name "Project" |> NamespacedName

    /// <summary>
    /// Property used to associate the Cultural Institute or Site or the Event with its access condition information
    /// <see href="http://dati.beniculturali.it/cis/hasAccessCondition"></see></summary>
    let hasAccessCondition =
        Namespaced_IRI.parse _namespace_name "hasAccessCondition" |> NamespacedName

    /// <summary>
    /// Inverse propery of "is about".
    /// <see href="http://dati.beniculturali.it/cis/isSubjectOf"></see></summary>
    let isSubjectOf =
        Namespaced_IRI.parse _namespace_name "isSubjectOf" |> NamespacedName

    /// <summary>
    /// Property used to associate the Cultural Institute or SIte with a catalogue of cultural collections included in the institute or site. The relatioships can be used to indicate that a Cultural Institute or Site has an its own catalogue or situations where a Cultural Institute or Site contributes to a union catalogue (this latter case is represented by libraries that can contribute to or participate in a union catalogue).
    /// <see href="http://dati.beniculturali.it/cis/catalogue"></see></summary>
    let catalogue = Namespaced_IRI.parse _namespace_name "catalogue" |> NamespacedName

    /// <summary>
    /// This data property identifies  the institutional name of the Cultural Institute or Site.
    /// <see href="http://dati.beniculturali.it/cis/institutionalName"></see></summary>
    let institutionalName =
        Namespaced_IRI.parse _namespace_name "institutionalName" |> NamespacedName

    /// <summary>
    /// Property which associate a cultural institute or site or a site with the situation name in time
    /// <see href="http://dati.beniculturali.it/cis/hasNameInTime"></see></summary>
    let hasNameInTime =
        Namespaced_IRI.parse _namespace_name "hasNameInTime" |> NamespacedName

    /// <summary>
    /// Permits to represent a situation in which a name of the Cultural Institute or Site change in time.
    /// <see href="http://dati.beniculturali.it/cis/NameInTime"></see></summary>
    let NameInTime = Namespaced_IRI.parse _namespace_name "NameInTime" |> NamespacedName
    /// <summary>
    /// This object property is meant to link a cultural institute or site with itself. This can be used to represent all those cases in which a institute or site can be part of another general institute or site. This property can be effectively used in the cases of Sections of the Central Archive.
    /// <see href="http://dati.beniculturali.it/cis/isPartOf"></see></summary>
    let isPartOf = Namespaced_IRI.parse _namespace_name "isPartOf" |> NamespacedName
    /// <summary>
    /// Inverse property of "for access to"
    /// <see href="http://dati.beniculturali.it/cis/hasTicket"></see></summary>
    let hasTicket = Namespaced_IRI.parse _namespace_name "hasTicket" |> NamespacedName

    /// <summary>
    /// Property used to represent a supply service relationship between a cultural institute or site and a service.
    /// <see href="http://dati.beniculturali.it/cis/providesService"></see></summary>
    let providesService =
        Namespaced_IRI.parse _namespace_name "providesService" |> NamespacedName

    /// <summary>
    /// It represents a service that is provided by the Cultural Institute or Site. For instance, a service can be: the presence of a restaurant internal to the Cultural Institute or Site, the uso of an educational room, the use of a free wifi connection
    /// <see href="http://dati.beniculturali.it/cis/Service"></see></summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName

    /// <summary>
    /// Property that permits to associate the Cultural Institute or Site with its own equipment
    /// <see href="http://dati.beniculturali.it/cis/makesAvailableEquipment"></see></summary>
    let makesAvailableEquipment =
        Namespaced_IRI.parse _namespace_name "makesAvailableEquipment" |> NamespacedName

    /// <summary>
    /// It represents the equipment made available by the Cultural Institute or Site. For instance, the equipment can be a totem, etc.
    /// <see href="http://dati.beniculturali.it/cis/Equipment"></see></summary>
    let Equipment = Namespaced_IRI.parse _namespace_name "Equipment" |> NamespacedName

    /// <summary>
    /// inverse property for "roleFor"
    /// <see href="http://dati.beniculturali.it/cis/isRelatedToRiT"></see></summary>
    let isRelatedToRiT =
        Namespaced_IRI.parse _namespace_name "isRelatedToRiT" |> NamespacedName

    /// <summary>
    /// Property which links a cultural insttiute or site to its contact points. The same property is used to link in a similar way the event to its contact points and to link the site of the cultural institute or site with its contact points
    /// <see href="http://dati.beniculturali.it/cis/hasContactPoint"></see></summary>
    let hasContactPoint =
        Namespaced_IRI.parse _namespace_name "hasContactPoint" |> NamespacedName

    /// <summary>
    /// This property is used to define the unique identifier of the cultural institute or site (i.e., the ISIL - International Standard Identifier for Libriaries and Related Organization - code). Subproperty of identifier.
    /// <see href="http://dati.beniculturali.it/cis/ISILIdentifier"></see></summary>
    let ISILIdentifier =
        Namespaced_IRI.parse _namespace_name "ISILIdentifier" |> NamespacedName

    /// <summary>
    /// Property used to associate the Cultural Institute or Site with its own field of knowledge
    /// <see href="http://dati.beniculturali.it/cis/hasDiscipline"></see></summary>
    let hasDiscipline =
        Namespaced_IRI.parse _namespace_name "hasDiscipline" |> NamespacedName

    /// <summary>
    /// It represents a a field of knowledge or human activity. This can be defined in a controlled vocabulary. Examples can be: Modern Art, Ancient History, Ethnografy, etc.
    /// <see href="http://dati.beniculturali.it/cis/SubjectDiscipline"></see></summary>
    let SubjectDiscipline =
        Namespaced_IRI.parse _namespace_name "SubjectDiscipline" |> NamespacedName

    /// <summary>
    /// Property which links a cultural institute or site to its own physical site(s).
    /// <see href="http://dati.beniculturali.it/cis/hasSite"></see></summary>
    let hasSite = Namespaced_IRI.parse _namespace_name "hasSite" |> NamespacedName

    /// <summary>
    /// This class represents a specific types of cultural institute or site, i.e., the cultural landscape asset.
    /// <see href="http://dati.beniculturali.it/cis/CulturalLandscapeAsset"></see></summary>
    let CulturalLandscapeAsset =
        Namespaced_IRI.parse _namespace_name "CulturalLandscapeAsset" |> NamespacedName

    /// <summary>
    /// This class represents a currency. In our domain currency is typically associated with Price Specification for tickets, and assumes specific values (e.g., Euro).
    /// <see href="http://dati.beniculturali.it/cis/Currency"></see></summary>
    let Currency = Namespaced_IRI.parse _namespace_name "Currency" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.beniculturali.it/cis/Day"></see>
    /// </summary>
    let Day = Namespaced_IRI.parse _namespace_name "Day" |> NamespacedName

    /// <summary>
    /// Class that represents a measurement unit
    /// <see href="http://dati.beniculturali.it/cis/MeasurementUnit"></see></summary>
    let MeasurementUnit =
        Namespaced_IRI.parse _namespace_name "MeasurementUnit" |> NamespacedName

    /// <summary>
    /// This class represents the set of all the days of the week.
    /// <see href="http://dati.beniculturali.it/cis/DayOfWeek"></see></summary>
    let DayOfWeek = Namespaced_IRI.parse _namespace_name "DayOfWeek" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.beniculturali.it/cis/img/openingHoursSpecification.png"></see>
    /// </summary>
    let ``img/openingHoursSpecification.png`` =
        Namespaced_IRI.parse _namespace_name "img/openingHoursSpecification.png" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.beniculturali.it/cis/Euro"></see>
    /// </summary>
    let Euro = Namespaced_IRI.parse _namespace_name "Euro" |> NamespacedName
    /// <summary>
    /// This property is the inverse of "hosts" and links the Event to the Site of the Cultural Institute or Site
    /// <see href="http://dati.beniculturali.it/cis/isHostedBy"></see></summary>
    let isHostedBy = Namespaced_IRI.parse _namespace_name "isHostedBy" |> NamespacedName

    /// <summary>
    /// Property used to describe large events to which single sub events refer. For instance, a large event can be the first world war centenary to which single events celebrating the 100th anniversary refer
    /// <see href="http://dati.beniculturali.it/cis/hasSubEvent"></see></summary>
    let hasSubEvent =
        Namespaced_IRI.parse _namespace_name "hasSubEvent" |> NamespacedName

    /// <summary>
    /// Inverse Property of "has sub event"
    /// <see href="http://dati.beniculturali.it/cis/isSubEventOf"></see></summary>
    let isSubEventOf =
        Namespaced_IRI.parse _namespace_name "isSubEventOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.beniculturali.it/cis/Friday"></see>
    /// </summary>
    let Friday = Namespaced_IRI.parse _namespace_name "Friday" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.beniculturali.it/cis/img/geographicalArea.png"></see>
    /// </summary>
    let ``img/geographicalArea.png`` =
        Namespaced_IRI.parse _namespace_name "img/geographicalArea.png" |> NamespacedName

    /// <summary>
    /// This property represents the toponym of a geographical area.
    /// <see href="http://dati.beniculturali.it/cis/toponym"></see></summary>
    let toponym = Namespaced_IRI.parse _namespace_name "toponym" |> NamespacedName

    /// <summary>
    /// Property used to associate a site with its own geographical coordinates
    /// <see href="http://dati.beniculturali.it/cis/hasGeometry"></see></summary>
    let hasGeometry =
        Namespaced_IRI.parse _namespace_name "hasGeometry" |> NamespacedName

    /// <summary>
    /// It represents a geometry which is typically described by using a coordinate system related to Earth such as WGS84. It is univocally identified by lat/long
    /// <see href="http://dati.beniculturali.it/cis/Geometry"></see></summary>
    let Geometry = Namespaced_IRI.parse _namespace_name "Geometry" |> NamespacedName

    /// <summary>
    /// This property is used to represent the methodology used for the georeferentiation.
    /// <see href="http://dati.beniculturali.it/cis/geoMethodology"></see></summary>
    let geoMethodology =
        Namespaced_IRI.parse _namespace_name "geoMethodology" |> NamespacedName

    /// <summary>
    /// Property used to associate a latitude with a Point
    /// <see href="http://dati.beniculturali.it/cis/hasLat"></see></summary>
    let hasLat = Namespaced_IRI.parse _namespace_name "hasLat" |> NamespacedName
    /// <summary>
    /// Property used to associate the longitude with a Point
    /// <see href="http://dati.beniculturali.it/cis/hasLong"></see></summary>
    let hasLong = Namespaced_IRI.parse _namespace_name "hasLong" |> NamespacedName

    /// <summary>
    /// This property is used to represent the geometry type (point, line, or polygon) in the geospatial representation.
    /// <see href="http://dati.beniculturali.it/cis/geometryType"></see></summary>
    let geometryType =
        Namespaced_IRI.parse _namespace_name "geometryType" |> NamespacedName

    /// <summary>
    /// This class represents an administrative geographical area that is typically managed by a public body. It can be a Region, a Municipality, a Province, a sub-municipality area, etc.
    /// <see href="http://dati.beniculturali.it/cis/GovernamentalAdministrativeArea"></see></summary>
    let GovernamentalAdministrativeArea =
        Namespaced_IRI.parse _namespace_name "GovernamentalAdministrativeArea" |> NamespacedName

    /// <summary>
    /// This property is used to represent a specific code used in the Italian context for the governamental administrative areas.
    /// <see href="http://dati.beniculturali.it/cis/hasISTATCode"></see></summary>
    let hasISTATCode =
        Namespaced_IRI.parse _namespace_name "hasISTATCode" |> NamespacedName

    /// <summary>
    /// This class represents a specific tyep of cultural institute or site, i.e.,  Holder of Archive
    /// <see href="http://dati.beniculturali.it/cis/HolderOfArchive"></see></summary>
    let HolderOfArchive =
        Namespaced_IRI.parse _namespace_name "HolderOfArchive" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.beniculturali.it/cis/Hour"></see>
    /// </summary>
    let Hour = Namespaced_IRI.parse _namespace_name "Hour" |> NamespacedName

    /// <summary>
    /// Concept used to represent an image file.
    /// <see href="http://dati.beniculturali.it/cis/ImageObject"></see></summary>
    let ImageObject =
        Namespaced_IRI.parse _namespace_name "ImageObject" |> NamespacedName

    /// <summary>
    /// It represents a specific type of Cultural Institute or Site; that is, Library
    /// <see href="http://dati.beniculturali.it/cis/Library"></see></summary>
    let Library = Namespaced_IRI.parse _namespace_name "Library" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.beniculturali.it/cis/Monday"></see>
    /// </summary>
    let Monday = Namespaced_IRI.parse _namespace_name "Monday" |> NamespacedName

    /// <summary>
    /// It represents a specific type of Cultural Institute or Site; that is, Monumental Area
    /// <see href="http://dati.beniculturali.it/cis/MonumentalArea"></see></summary>
    let MonumentalArea =
        Namespaced_IRI.parse _namespace_name "MonumentalArea" |> NamespacedName

    /// <summary>
    /// It represents a specific type of Cultural Institute or Site; that is, Museum
    /// <see href="http://dati.beniculturali.it/cis/Museum"></see></summary>
    let Museum = Namespaced_IRI.parse _namespace_name "Museum" |> NamespacedName

    /// <summary>
    /// Property used to associate the situation name in time with a temporal validity interval
    /// <see href="http://dati.beniculturali.it/cis/isValidDuring"></see></summary>
    let isValidDuring =
        Namespaced_IRI.parse _namespace_name "isValidDuring" |> NamespacedName

    /// <summary>
    /// Property used to associate the situation name in time with the alternative name of the cultural institute or site
    /// <see href="http://dati.beniculturali.it/cis/altLabel"></see></summary>
    let altLabel = Namespaced_IRI.parse _namespace_name "altLabel" |> NamespacedName

    /// <summary>
    /// Concept used to represent a news article.
    /// <see href="http://dati.beniculturali.it/cis/NewsArticle"></see></summary>
    let NewsArticle =
        Namespaced_IRI.parse _namespace_name "NewsArticle" |> NamespacedName

    /// <summary>
    /// It represents an offer (reduction  for specific types of users or base price) related to the entrance ticket for the Cultural Institute or Site or for the Event.
    /// <see href="http://dati.beniculturali.it/cis/Offer"></see></summary>
    let Offer = Namespaced_IRI.parse _namespace_name "Offer" |> NamespacedName
    /// <summary>
    /// Property used to associate an offer with the relative ticket
    /// <see href="http://dati.beniculturali.it/cis/includes"></see></summary>
    let includes = Namespaced_IRI.parse _namespace_name "includes" |> NamespacedName

    /// <summary>
    /// Property used to specify the validity of an offer or ticket.
    /// <see href="http://dati.beniculturali.it/cis/hasValidity"></see></summary>
    let hasValidity =
        Namespaced_IRI.parse _namespace_name "hasValidity" |> NamespacedName

    /// <summary>
    /// This class represents the validity for the ticket and offering.
    /// <see href="http://dati.beniculturali.it/cis/Validity"></see></summary>
    let Validity = Namespaced_IRI.parse _namespace_name "Validity" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.beniculturali.it/cis/OneDay"></see>
    /// </summary>
    let OneDay = Namespaced_IRI.parse _namespace_name "OneDay" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.beniculturali.it/cis/OneWeek"></see>
    /// </summary>
    let OneWeek = Namespaced_IRI.parse _namespace_name "OneWeek" |> NamespacedName
    /// <summary>
    /// This property is used to represent the closing time
    /// <see href="http://dati.beniculturali.it/cis/closes"></see></summary>
    let closes = Namespaced_IRI.parse _namespace_name "closes" |> NamespacedName
    /// <summary>
    /// This property is used to represent the opening time
    /// <see href="http://dati.beniculturali.it/cis/opens"></see></summary>
    let opens = Namespaced_IRI.parse _namespace_name "opens" |> NamespacedName

    /// <summary>
    /// This property is used to specify the opening hours and in particular the days of the week.
    /// <see href="http://dati.beniculturali.it/cis/hasDayOfWeek"></see></summary>
    let hasDayOfWeek =
        Namespaced_IRI.parse _namespace_name "hasDayOfWeek" |> NamespacedName

    /// <summary>
    /// Property used to associate the opening hours specification to the admission type
    /// <see href="http://dati.beniculturali.it/cis/hasAdmissionType"></see></summary>
    let hasAdmissionType =
        Namespaced_IRI.parse _namespace_name "hasAdmissionType" |> NamespacedName

    /// <summary>
    /// It represents the price specification of the ticket
    /// <see href="http://dati.beniculturali.it/cis/PriceSpecification"></see></summary>
    let PriceSpecification =
        Namespaced_IRI.parse _namespace_name "PriceSpecification" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.beniculturali.it/cis/img/priceSpecification.png"></see>
    /// </summary>
    let ``img/priceSpecification.png`` =
        Namespaced_IRI.parse _namespace_name "img/priceSpecification.png" |> NamespacedName

    /// <summary>
    /// Property used to represent the price of the ticket.
    /// <see href="http://dati.beniculturali.it/cis/hasCurrencyValue"></see></summary>
    let hasCurrencyValue =
        Namespaced_IRI.parse _namespace_name "hasCurrencyValue" |> NamespacedName

    /// <summary>
    /// This property is used to connected the Price specification to Currency
    /// <see href="http://dati.beniculturali.it/cis/hasCurrency"></see></summary>
    let hasCurrency =
        Namespaced_IRI.parse _namespace_name "hasCurrency" |> NamespacedName

    /// <summary>
    /// Class that represents a quantitative value.
    /// <see href="http://dati.beniculturali.it/cis/QuantitativeValue"></see></summary>
    let QuantitativeValue =
        Namespaced_IRI.parse _namespace_name "QuantitativeValue" |> NamespacedName

    /// <summary>
    /// This property is used to represent a measurement unit.
    /// <see href="http://dati.beniculturali.it/cis/hasMeasurementUnit"></see></summary>
    let hasMeasurementUnit =
        Namespaced_IRI.parse _namespace_name "hasMeasurementUnit" |> NamespacedName

    /// <summary>
    /// Property used to represent a value
    /// <see href="http://dati.beniculturali.it/cis/hasValue"></see></summary>
    let hasValue = Namespaced_IRI.parse _namespace_name "hasValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.beniculturali.it/cis/QuantityOfAdmissions"></see>
    /// </summary>
    let QuantityOfAdmissions =
        Namespaced_IRI.parse _namespace_name "QuantityOfAdmissions" |> NamespacedName

    /// <summary>
    /// It represents a role. It can be modelled using a controlled vocabulary. Examples of roles include: ManagingAuthority, AccountableAuthority, Owner, Director, etc.
    /// <see href="http://dati.beniculturali.it/cis/Role"></see></summary>
    let Role = Namespaced_IRI.parse _namespace_name "Role" |> NamespacedName
    /// <summary>
    /// Inverse property of "with role"
    /// <see href="http://dati.beniculturali.it/cis/isRoleIn"></see></summary>
    let isRoleIn = Namespaced_IRI.parse _namespace_name "isRoleIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.beniculturali.it/cis/img/roleInTime.png"></see>
    /// </summary>
    let ``img/roleInTime.png`` =
        Namespaced_IRI.parse _namespace_name "img/roleInTime.png" |> NamespacedName

    /// <summary>
    /// Property used to associate the situation role in time with the role itself
    /// <see href="http://dati.beniculturali.it/cis/withRole"></see></summary>
    let withRole = Namespaced_IRI.parse _namespace_name "withRole" |> NamespacedName
    /// <summary>
    /// Property used to associate the situation role in time played by an agent with the relative cultural institute or site. The same property is used in a similar way to associate role in time with an event
    /// <see href="http://dati.beniculturali.it/cis/roleFor"></see></summary>
    let roleFor = Namespaced_IRI.parse _namespace_name "roleFor" |> NamespacedName
    /// <summary>
    /// Inverse property of "holds a role in time"
    /// <see href="http://dati.beniculturali.it/cis/isHeldBy"></see></summary>
    let isHeldBy = Namespaced_IRI.parse _namespace_name "isHeldBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.beniculturali.it/cis/Saturday"></see>
    /// </summary>
    let Saturday = Namespaced_IRI.parse _namespace_name "Saturday" |> NamespacedName

    /// <summary>
    /// Inverse property of "provides service"
    /// <see href="http://dati.beniculturali.it/cis/isProvidedBy"></see></summary>
    let isProvidedBy =
        Namespaced_IRI.parse _namespace_name "isProvidedBy" |> NamespacedName

    /// <summary>
    /// Property used to associate a cultural institute or site to an event
    /// <see href="http://dati.beniculturali.it/cis/hosts"></see></summary>
    let hosts = Namespaced_IRI.parse _namespace_name "hosts" |> NamespacedName
    /// <summary>
    /// Inverse property of "has Site"
    /// <see href="http://dati.beniculturali.it/cis/isSiteOf"></see></summary>
    let isSiteOf = Namespaced_IRI.parse _namespace_name "isSiteOf" |> NamespacedName
    /// <summary>
    /// Property that permits to associate a site with an address
    /// <see href="http://dati.beniculturali.it/cis/hasAddress"></see></summary>
    let hasAddress = Namespaced_IRI.parse _namespace_name "hasAddress" |> NamespacedName

    /// <summary>
    /// Property used to associate a site with a geographical area where the site is located.
    /// <see href="http://dati.beniculturali.it/cis/hasGeographicalLocation"></see></summary>
    let hasGeographicalLocation =
        Namespaced_IRI.parse _namespace_name "hasGeographicalLocation" |> NamespacedName

    /// <summary>
    /// Permits to represents a description of a site of the cultural institute or site (for instance, the site has a total space available XXX, and a shelving that consists of a set of XX X shelves, etc.)
    /// <see href="http://dati.beniculturali.it/cis/SiteDescription"></see></summary>
    let SiteDescription =
        Namespaced_IRI.parse _namespace_name "SiteDescription" |> NamespacedName

    /// <summary>
    /// Propery that permits to associate a site of a cultural institute or site with its description.
    /// <see href="http://dati.beniculturali.it/cis/hasSiteDescription"></see></summary>
    let hasSiteDescription =
        Namespaced_IRI.parse _namespace_name "hasSiteDescription" |> NamespacedName

    /// <summary>
    /// Property used to associate the description of the site of the cultural institute or site an attribute (e.g., total space, shelving, etc.)
    /// <see href="http://dati.beniculturali.it/cis/hasAttribute"></see></summary>
    let hasAttribute =
        Namespaced_IRI.parse _namespace_name "hasAttribute" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.beniculturali.it/cis/Sunday"></see>
    /// </summary>
    let Sunday = Namespaced_IRI.parse _namespace_name "Sunday" |> NamespacedName

    /// <summary>
    /// It represents the information on the temporary closure
    /// <see href="http://dati.beniculturali.it/cis/TemporaryClosure"></see></summary>
    let TemporaryClosure =
        Namespaced_IRI.parse _namespace_name "TemporaryClosure" |> NamespacedName

    /// <summary>
    /// Property used to represent the date of the temporary closure.
    /// <see href="http://dati.beniculturali.it/cis/hasDate"></see></summary>
    let hasDate = Namespaced_IRI.parse _namespace_name "hasDate" |> NamespacedName
    /// <summary>
    /// Property used to describe a reason for the temporary closure.
    /// <see href="http://dati.beniculturali.it/cis/hasReason"></see></summary>
    let hasReason = Namespaced_IRI.parse _namespace_name "hasReason" |> NamespacedName

    /// <summary>
    /// Property used to associate the temporary closure with its type
    /// <see href="http://dati.beniculturali.it/cis/hasTemporaryClosureType"></see></summary>
    let hasTemporaryClosureType =
        Namespaced_IRI.parse _namespace_name "hasTemporaryClosureType" |> NamespacedName

    /// <summary>
    /// It represents the type of temporary. Examples can be: closed for renovation, unfit for use, etc.
    /// <see href="http://dati.beniculturali.it/cis/TemporaryClosureType"></see></summary>
    let TemporaryClosureType =
        Namespaced_IRI.parse _namespace_name "TemporaryClosureType" |> NamespacedName

    /// <summary>
    /// This class represents a cultural institute or site of type Theatre
    /// <see href="http://dati.beniculturali.it/cis/Theatre"></see></summary>
    let Theatre = Namespaced_IRI.parse _namespace_name "Theatre" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.beniculturali.it/cis/Thursday"></see>
    /// </summary>
    let Thursday = Namespaced_IRI.parse _namespace_name "Thursday" |> NamespacedName

    /// <summary>
    /// Property used to associate a ticket with an event or a cultural institute or site
    /// <see href="http://dati.beniculturali.it/cis/forAccessTo"></see></summary>
    let forAccessTo =
        Namespaced_IRI.parse _namespace_name "forAccessTo" |> NamespacedName

    /// <summary>
    /// Srart date of a Time Interval
    /// <see href="http://dati.beniculturali.it/cis/startDate"></see></summary>
    let startDate = Namespaced_IRI.parse _namespace_name "startDate" |> NamespacedName
    /// <summary>
    /// end Date of a Time Interval
    /// <see href="http://dati.beniculturali.it/cis/endDate"></see></summary>
    let endDate = Namespaced_IRI.parse _namespace_name "endDate" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.beniculturali.it/cis/Tuesday"></see>
    /// </summary>
    let Tuesday = Namespaced_IRI.parse _namespace_name "Tuesday" |> NamespacedName
    /// <summary>
    /// It represents the identified type of users related to the tickets used to access an event or a Cultural Institute or Site. Examples include: people over 25 years old, people over 65 years old,  children, etc.
    /// <see href="http://dati.beniculturali.it/cis/UserType"></see></summary>
    let UserType = Namespaced_IRI.parse _namespace_name "UserType" |> NamespacedName

    /// <summary>
    /// This property is used to specify the temporal duration of the validity.
    /// <see href="http://dati.beniculturali.it/cis/hasDuration"></see></summary>
    let hasDuration =
        Namespaced_IRI.parse _namespace_name "hasDuration" |> NamespacedName

    /// <summary>
    /// Concept used to represent multimedia objects of type video.
    /// <see href="http://dati.beniculturali.it/cis/VideoObject"></see></summary>
    let VideoObject =
        Namespaced_IRI.parse _namespace_name "VideoObject" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.beniculturali.it/cis/Wednesday"></see>
    /// </summary>
    let Wednesday = Namespaced_IRI.parse _namespace_name "Wednesday" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.beniculturali.it/cis/Week"></see>
    /// </summary>
    let Week = Namespaced_IRI.parse _namespace_name "Week" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.beniculturali.it/cis/Year"></see>
    /// </summary>
    let Year = Namespaced_IRI.parse _namespace_name "Year" |> NamespacedName

    /// <summary>
    /// Inverse property of has day of week.
    /// <see href="http://dati.beniculturali.it/cis/isDayOfWeekOf"></see></summary>
    let isDayOfWeekOf =
        Namespaced_IRI.parse _namespace_name "isDayOfWeekOf" |> NamespacedName

    /// <summary>
    /// Property used to associate the an offert for the access to an event or a cultural institute or site with the type of user
    /// <see href="http://dati.beniculturali.it/cis/hasEligibleUser"></see></summary>
    let hasEligibleUser =
        Namespaced_IRI.parse _namespace_name "hasEligibleUser" |> NamespacedName

    /// <summary>
    /// Inverse property of hasMember.
    /// <see href="http://dati.beniculturali.it/cis/isMemberOf"></see></summary>
    let isMemberOf = Namespaced_IRI.parse _namespace_name "isMemberOf" |> NamespacedName

    /// <summary>
    /// This property is used to link the offer for a ticket to its price specification.
    /// <see href="http://dati.beniculturali.it/cis/hasPriceSpecification"></see></summary>
    let hasPriceSpecification =
        Namespaced_IRI.parse _namespace_name "hasPriceSpecification" |> NamespacedName

    /// <summary>
    /// Involvment property that associates an event with a general cultural entity
    /// <see href="http://dati.beniculturali.it/cis/involves"></see></summary>
    let involves = Namespaced_IRI.parse _namespace_name "involves" |> NamespacedName
    /// <summary>
    /// Property used to associate an agent with an offer for accessing an event or a cultural institute or site
    /// <see href="http://dati.beniculturali.it/cis/offers"></see></summary>
    let offers = Namespaced_IRI.parse _namespace_name "offers" |> NamespacedName

    /// <summary>
    /// Property used to associate an event with a temporal interval within which the event takes place
    /// <see href="http://dati.beniculturali.it/cis/takesPlaceDuring"></see></summary>
    let takesPlaceDuring =
        Namespaced_IRI.parse _namespace_name "takesPlaceDuring" |> NamespacedName
