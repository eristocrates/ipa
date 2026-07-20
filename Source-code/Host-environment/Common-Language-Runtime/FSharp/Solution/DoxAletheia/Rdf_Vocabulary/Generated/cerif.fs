namespace http.www.eurocris.org.ontologies.cerif._1._3.hash

open DoxAletheia

module cerif =
    let _namespace_name = "http://www.eurocris.org/ontologies/cerif/1.3#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.eurocris.org/ontologies/cerif/1.3#msicilia"></see>
    /// </summary>
    let msicilia = _prefix "msicilia"
    /// <summary>
    ///   <see href="http://www.eurocris.org/ontologies/cerif/1.3#keith"></see>
    /// </summary>
    let keith = _prefix "keith"
    /// <summary>
    ///   <see href="http://www.eurocris.org/ontologies/cerif/1.3#jan"></see>
    /// </summary>
    let jan = _prefix "jan"
    /// <summary>
    ///   <see href="http://www.eurocris.org/ontologies/cerif/1.3#brigitte"></see>
    /// </summary>
    let brigitte = _prefix "brigitte"
    /// <summary>
    ///   <see href="http://www.eurocris.org/ontologies/cerif/1.3#ruizrube"></see>
    /// </summary>
    let ruizrube = _prefix "ruizrube"
    /// <summary>
    ///   <see href="http://www.eurocris.org/ontologies/cerif/1.3#geert"></see>
    /// </summary>
    let geert = _prefix "geert"
    /// <summary>
    /// This abstract class brings together the main entities of the CERIF model.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#BaseEntity"></see></summary>
    let BaseEntity = _prefix "BaseEntity"
    /// <summary>
    /// Common superclass of all non-link entities, as an aid in querying.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#Entity"></see></summary>
    let Entity = _prefix "Entity"
    /// <summary>
    /// Cite
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#Cite"></see></summary>
    let Cite = _prefix "Cite"
    /// <summary>
    /// The 2nd level entities allow for the representation of the research context by linking to them from the base and result entities.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#SecondLevelEntity"></see></summary>
    let SecondLevelEntity = _prefix "SecondLevelEntity"
    /// <summary>
    /// Represents the classification of a given entity
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#Classification"></see></summary>
    let Classification = _prefix "Classification"
    /// <summary>
    /// Curriculum Vitae
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#CurriculumVitae"></see></summary>
    let CurriculumVitae = _prefix "CurriculumVitae"
    /// <summary>
    /// ElectronicAddress
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#ElectronicAddress"></see></summary>
    let ElectronicAddress = _prefix "ElectronicAddress"
    /// <summary>
    /// Equipment
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#Equipment"></see></summary>
    let Equipment = _prefix "Equipment"
    /// <summary>
    /// Abstract entity for representing infrastructures
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#InfrastructureEntity"></see></summary>
    let InfrastructureEntity = _prefix "InfrastructureEntity"
    /// <summary>
    /// Event
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#Event"></see></summary>
    let Event = _prefix "Event"
    /// <summary>
    /// Expertise and skills
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#ExpSkill"></see></summary>
    let ExpSkill = _prefix "ExpSkill"
    /// <summary>
    /// Facility
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#Facility"></see></summary>
    let Facility = _prefix "Facility"
    /// <summary>
    /// Funding
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#Funding"></see></summary>
    let Funding = _prefix "Funding"
    /// <summary>
    /// Metrics
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#Metrics"></see></summary>
    let Metrics = _prefix "Metrics"
    /// <summary>
    /// A given organizational unit
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#OrganizationalUnit"></see></summary>
    let OrganizationalUnit = _prefix "OrganizationalUnit"
    /// <summary>
    /// A registered patent as a research result
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#Patent"></see></summary>
    let Patent = _prefix "Patent"
    /// <summary>
    /// Represents a research result
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#ResultEntity"></see></summary>
    let ResultEntity = _prefix "ResultEntity"
    /// <summary>
    /// A given person
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#Person"></see></summary>
    let Person = _prefix "Person"
    /// <summary>
    /// Postal Address
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#PostalAddress"></see></summary>
    let PostalAddress = _prefix "PostalAddress"
    /// <summary>
    /// Price Award
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#PriceAward"></see></summary>
    let PriceAward = _prefix "PriceAward"
    /// <summary>
    /// A research result that is classified neither as a patent nor as a publication.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#Product"></see></summary>
    let Product = _prefix "Product"
    /// <summary>
    /// A research project
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#Project"></see></summary>
    let Project = _prefix "Project"
    /// <summary>
    /// Represents a scientific or academic publication
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#Publication"></see></summary>
    let Publication = _prefix "Publication"
    /// <summary>
    /// Qualification
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#Qualification"></see></summary>
    let Qualification = _prefix "Qualification"
    /// <summary>
    /// intermediate entity between two entities.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#Relationship"></see></summary>
    let Relationship = _prefix "Relationship"
    /// <summary>
    /// Service
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#Service"></see></summary>
    let Service = _prefix "Service"
    /// <summary>
    /// Abstract of a given Project
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#abstract"></see></summary>
    let abstract_ = _prefix "abstract"
    /// <summary>
    /// Acronym of a given Project or an Organisation Unit
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#acronym"></see></summary>
    let acronym = _prefix "acronym"
    /// <summary>
    /// Numbered line of a given postal address
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#addressLine"></see></summary>
    let addressLine = _prefix "addressLine"
    /// <summary>
    /// External Classification Scheme according to Agrovoc Vocabulary
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#agrovoc"></see></summary>
    let agrovoc = _prefix "agrovoc"
    /// <summary>
    /// Approval Date of a patent
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#approvalDate"></see></summary>
    let approvalDate = _prefix "approvalDate"
    /// <summary>
    /// BirthDate of a Person
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#birthdate"></see></summary>
    let birthdate = _prefix "birthdate"
    /// <summary>
    /// City Town of an physical localisation
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#cityTown"></see></summary>
    let cityTown = _prefix "cityTown"
    /// <summary>
    /// Indicates a classification for a entity according to a suitable external vocabulary
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#classification"></see></summary>
    let classification = _prefix "classification"
    /// <summary>
    /// It is a generalisation for relationship and classification properties
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#link"></see></summary>
    let link = _prefix "link"
    /// <summary>
    /// Generic property for represent international and shared codes
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#code"></see></summary>
    let code = _prefix "code"
    /// <summary>
    /// A given country - http://dbpedia.org/ontology/Country
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#country"></see></summary>
    let country = _prefix "country"
    /// <summary>
    /// International code of a given country
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#countryCode"></see></summary>
    let countryCode = _prefix "countryCode"
    /// <summary>
    /// Specific currency used for denote amounts, prices and turnovers. Linking with http://dbpedia.org/ontology/Language
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#currency"></see></summary>
    let currency = _prefix "currency"
    /// <summary>
    /// Code of a specific currency used for denote amounts, prices and turnovers.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#currencyCode"></see></summary>
    let currencyCode = _prefix "currencyCode"
    /// <summary>
    /// Digital CV
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#digitalCV"></see></summary>
    let digitalCV = _prefix "digitalCV"
    /// <summary>
    /// End of a period of time
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#endDate"></see></summary>
    let endDate = _prefix "endDate"
    /// <summary>
    /// Flag indicating if the event is fee or free
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#feeOrFree"></see></summary>
    let feeOrFree = _prefix "feeOrFree"
    /// <summary>
    /// Fractional value to indicate a classification reference or a % allocation in the relationship between entities.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#fraction"></see></summary>
    let fraction = _prefix "fraction"
    /// <summary>
    /// Amount of a given Funding (measured in a specific currency)
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#funding"></see></summary>
    let funding = _prefix "funding"
    /// <summary>
    /// This property embraces all Currency-dependent properties
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#money"></see></summary>
    let money = _prefix "money"
    /// <summary>
    /// Currency code used to denote the funding amount
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#fundingCurrencyCode"></see></summary>
    let fundingCurrencyCode = _prefix "fundingCurrencyCode"
    /// <summary>
    /// Gender of a CERIF person
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#gender"></see></summary>
    let gender = _prefix "gender"
    /// <summary>
    /// Number of persons enrolled in a Organisation Unit
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#headcount"></see></summary>
    let headcount = _prefix "headcount"
    /// <summary>
    /// Internal Identifier for a research entity. It fits with the primary key in the corresponding table from the internal database
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#internalIdentifier"></see></summary>
    let internalIdentifier = _prefix "internalIdentifier"
    /// <summary>
    /// The equipment owner's inventory identifier.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#inventoryIdentifier"></see></summary>
    let inventoryIdentifier = _prefix "inventoryIdentifier"
    /// <summary>
    /// A entity is classified within a time interval according to CERIF Semantic Vocabulary.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#isClassifiedBy"></see></summary>
    let isClassifiedBy = _prefix "isClassifiedBy"
    /// <summary>
    /// This is an abstract property to group all properties that inversely relate a entity with other through a time-stamped link.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#isLinkedByEntity"></see></summary>
    let isLinkedByEntity = _prefix "isLinkedByEntity"
    /// <summary>
    /// A given Funding is related with a entity through a time-stamped link.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#isLinkedByFunding"></see></summary>
    let isLinkedByFunding = _prefix "isLinkedByFunding"
    /// <summary>
    /// A given Organisation Unit is related with a entity through a time-stamped link.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#isLinkedByOrganisationUnit"></see></summary>
    let isLinkedByOrganisationUnit = _prefix "isLinkedByOrganisationUnit"
    /// <summary>
    /// A given Person is related with a entity through a time-stamped link.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#isLinkedByPerson"></see></summary>
    let isLinkedByPerson = _prefix "isLinkedByPerson"
    /// <summary>
    /// A given Project is related with a entity through a time-stamped link.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#isLinkedByProject"></see></summary>
    let isLinkedByProject = _prefix "isLinkedByProject"
    /// <summary>
    /// A given Publication is related with a entity through a time-stamped link.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#isLinkedByPublication"></see></summary>
    let isLinkedByPublication = _prefix "isLinkedByPublication"
    /// <summary>
    /// Keywords of a given entity
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#keyword"></see></summary>
    let keyword = _prefix "keyword"
    /// <summary>
    /// A given language. Linking to http://dbpedia.org/ontology/Language
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#language"></see></summary>
    let language = _prefix "language"
    /// <summary>
    /// International code of a given language
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#languageCode"></see></summary>
    let languageCode = _prefix "languageCode"
    /// <summary>
    /// This is an abstract property to group all properties that directly relate a entity with other through a time-stamped link.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#linksToEntity"></see></summary>
    let linksToEntity = _prefix "linksToEntity"
    /// <summary>
    /// It relates a entity with a given Funding entity through a time-stamped link.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#linksToFunding"></see></summary>
    let linksToFunding = _prefix "linksToFunding"
    /// <summary>
    /// It relates a entity with a given Organisation Unit through a time-stamped link.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#linksToOrganisationUnit"></see></summary>
    let linksToOrganisationUnit = _prefix "linksToOrganisationUnit"
    /// <summary>
    /// It relates a entity with a given Person through a time-stamped link.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#linksToPerson"></see></summary>
    let linksToPerson = _prefix "linksToPerson"
    /// <summary>
    /// It relates a entity with a given Postal Address through a time-stamped link. Used, for example, in Persons and Organisation Units
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#linksToPostalAddress"></see></summary>
    let linksToPostalAddress = _prefix "linksToPostalAddress"
    /// <summary>
    /// It relates a  entity with a given Project through a time-stamped link.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#linksToProject"></see></summary>
    let linksToProject = _prefix "linksToProject"
    /// <summary>
    /// It relates a entity with a given Publication through a time-stamped link.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#linksToPublication"></see></summary>
    let linksToPublication = _prefix "linksToPublication"
    /// <summary>
    /// The equipment manufacturer's ID.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#manufacturerIdentifier"></see></summary>
    let manufacturerIdentifier = _prefix "manufacturerIdentifier"
    /// <summary>
    /// Name of a CERIF entity, e.g.: Person, or Organization Unit
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    /// Number of a Registered Patent
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#patentNumber"></see></summary>
    let patentNumber = _prefix "patentNumber"
    /// <summary>
    /// Postal Code of a given Address
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#postCode"></see></summary>
    let postCode = _prefix "postCode"
    /// <summary>
    /// Quantity of payment or compensation given by one party to another in return for goods or service (measured in a specific currency)
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#price"></see></summary>
    let price = _prefix "price"
    /// <summary>
    ///   <see href="http://www.eurocris.org/ontologies/cerif/1.3#priceCurrencyCode"></see>
    /// </summary>
    let priceCurrencyCode = _prefix "priceCurrencyCode"
    /// <summary>
    /// Number of a Product
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#productNumber"></see></summary>
    let productNumber = _prefix "productNumber"
    /// <summary>
    /// Registration Date of a patent
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#registrationDate"></see></summary>
    let registrationDate = _prefix "registrationDate"
    /// <summary>
    /// Research Activities
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#researchActivities"></see></summary>
    let researchActivities = _prefix "researchActivities"
    /// <summary>
    /// Research Interests
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#researchInterests"></see></summary>
    let researchInterests = _prefix "researchInterests"
    /// <summary>
    /// Indicates a role for the association or composition between two CERIF entities indicated by a term from a suitable external vocabulary
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#role"></see></summary>
    let role = _prefix "role"
    /// <summary>
    /// Beginning of a period of time
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#startDate"></see></summary>
    let startDate = _prefix "startDate"
    /// <summary>
    /// Title of a given CERIF entity
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#title"></see></summary>
    let title = _prefix "title"
    /// <summary>
    /// Turnover of a Organisation Unit (measured in a specific currency)
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#turnover"></see></summary>
    let turnover = _prefix "turnover"
    /// <summary>
    /// Currency Code used to denote turnovers
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#turnoverCurrencyCode"></see></summary>
    let turnoverCurrencyCode = _prefix "turnoverCurrencyCode"
    /// <summary>
    /// Uniform Resource Identifier related with a given CERIF entity
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#uri"></see></summary>
    let uri = _prefix "uri"
