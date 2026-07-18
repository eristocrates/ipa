namespace http.www.eurocris.org.ontologies.cerif._1._3.hash

open DoxAletheia.Rdf_Vocabulary

module cerif =
    let _namespace_name = "http://www.eurocris.org/ontologies/cerif/1.3#"
    /// <summary>
    ///   <see href="http://www.eurocris.org/ontologies/cerif/1.3#msicilia"></see>
    /// </summary>
    let msicilia = Namespaced_IRI.parse _namespace_name "msicilia" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.eurocris.org/ontologies/cerif/1.3#keith"></see>
    /// </summary>
    let keith = Namespaced_IRI.parse _namespace_name "keith" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.eurocris.org/ontologies/cerif/1.3#jan"></see>
    /// </summary>
    let jan = Namespaced_IRI.parse _namespace_name "jan" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.eurocris.org/ontologies/cerif/1.3#brigitte"></see>
    /// </summary>
    let brigitte = Namespaced_IRI.parse _namespace_name "brigitte" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.eurocris.org/ontologies/cerif/1.3#ruizrube"></see>
    /// </summary>
    let ruizrube = Namespaced_IRI.parse _namespace_name "ruizrube" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.eurocris.org/ontologies/cerif/1.3#geert"></see>
    /// </summary>
    let geert = Namespaced_IRI.parse _namespace_name "geert" |> NamespacedName
    /// <summary>
    /// This abstract class brings together the main entities of the CERIF model.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#BaseEntity"></see></summary>
    let BaseEntity = Namespaced_IRI.parse _namespace_name "BaseEntity" |> NamespacedName
    /// <summary>
    /// Common superclass of all non-link entities, as an aid in querying.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#Entity"></see></summary>
    let Entity = Namespaced_IRI.parse _namespace_name "Entity" |> NamespacedName
    /// <summary>
    /// Cite
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#Cite"></see></summary>
    let Cite = Namespaced_IRI.parse _namespace_name "Cite" |> NamespacedName

    /// <summary>
    /// The 2nd level entities allow for the representation of the research context by linking to them from the base and result entities.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#SecondLevelEntity"></see></summary>
    let SecondLevelEntity =
        Namespaced_IRI.parse _namespace_name "SecondLevelEntity" |> NamespacedName

    /// <summary>
    /// Represents the classification of a given entity
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#Classification"></see></summary>
    let Classification =
        Namespaced_IRI.parse _namespace_name "Classification" |> NamespacedName

    /// <summary>
    /// Curriculum Vitae
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#CurriculumVitae"></see></summary>
    let CurriculumVitae =
        Namespaced_IRI.parse _namespace_name "CurriculumVitae" |> NamespacedName

    /// <summary>
    /// ElectronicAddress
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#ElectronicAddress"></see></summary>
    let ElectronicAddress =
        Namespaced_IRI.parse _namespace_name "ElectronicAddress" |> NamespacedName

    /// <summary>
    /// Equipment
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#Equipment"></see></summary>
    let Equipment = Namespaced_IRI.parse _namespace_name "Equipment" |> NamespacedName

    /// <summary>
    /// Abstract entity for representing infrastructures
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#InfrastructureEntity"></see></summary>
    let InfrastructureEntity =
        Namespaced_IRI.parse _namespace_name "InfrastructureEntity" |> NamespacedName

    /// <summary>
    /// Event
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#Event"></see></summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName
    /// <summary>
    /// Expertise and skills
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#ExpSkill"></see></summary>
    let ExpSkill = Namespaced_IRI.parse _namespace_name "ExpSkill" |> NamespacedName
    /// <summary>
    /// Facility
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#Facility"></see></summary>
    let Facility = Namespaced_IRI.parse _namespace_name "Facility" |> NamespacedName
    /// <summary>
    /// Funding
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#Funding"></see></summary>
    let Funding = Namespaced_IRI.parse _namespace_name "Funding" |> NamespacedName
    /// <summary>
    /// Metrics
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#Metrics"></see></summary>
    let Metrics = Namespaced_IRI.parse _namespace_name "Metrics" |> NamespacedName

    /// <summary>
    /// A given organizational unit
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#OrganizationalUnit"></see></summary>
    let OrganizationalUnit =
        Namespaced_IRI.parse _namespace_name "OrganizationalUnit" |> NamespacedName

    /// <summary>
    /// A registered patent as a research result
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#Patent"></see></summary>
    let Patent = Namespaced_IRI.parse _namespace_name "Patent" |> NamespacedName

    /// <summary>
    /// Represents a research result
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#ResultEntity"></see></summary>
    let ResultEntity =
        Namespaced_IRI.parse _namespace_name "ResultEntity" |> NamespacedName

    /// <summary>
    /// A given person
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#Person"></see></summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName

    /// <summary>
    /// Postal Address
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#PostalAddress"></see></summary>
    let PostalAddress =
        Namespaced_IRI.parse _namespace_name "PostalAddress" |> NamespacedName

    /// <summary>
    /// Price Award
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#PriceAward"></see></summary>
    let PriceAward = Namespaced_IRI.parse _namespace_name "PriceAward" |> NamespacedName
    /// <summary>
    /// A research result that is classified neither as a patent nor as a publication.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#Product"></see></summary>
    let Product = Namespaced_IRI.parse _namespace_name "Product" |> NamespacedName
    /// <summary>
    /// A research project
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#Project"></see></summary>
    let Project = Namespaced_IRI.parse _namespace_name "Project" |> NamespacedName

    /// <summary>
    /// Represents a scientific or academic publication
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#Publication"></see></summary>
    let Publication =
        Namespaced_IRI.parse _namespace_name "Publication" |> NamespacedName

    /// <summary>
    /// Qualification
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#Qualification"></see></summary>
    let Qualification =
        Namespaced_IRI.parse _namespace_name "Qualification" |> NamespacedName

    /// <summary>
    /// intermediate entity between two entities.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#Relationship"></see></summary>
    let Relationship =
        Namespaced_IRI.parse _namespace_name "Relationship" |> NamespacedName

    /// <summary>
    /// Service
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#Service"></see></summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName
    /// <summary>
    /// Abstract of a given Project
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#abstract"></see></summary>
    let abstract_ = Namespaced_IRI.parse _namespace_name "abstract" |> NamespacedName
    /// <summary>
    /// Acronym of a given Project or an Organisation Unit
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#acronym"></see></summary>
    let acronym = Namespaced_IRI.parse _namespace_name "acronym" |> NamespacedName

    /// <summary>
    /// Numbered line of a given postal address
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#addressLine"></see></summary>
    let addressLine =
        Namespaced_IRI.parse _namespace_name "addressLine" |> NamespacedName

    /// <summary>
    /// External Classification Scheme according to Agrovoc Vocabulary
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#agrovoc"></see></summary>
    let agrovoc = Namespaced_IRI.parse _namespace_name "agrovoc" |> NamespacedName

    /// <summary>
    /// Approval Date of a patent
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#approvalDate"></see></summary>
    let approvalDate =
        Namespaced_IRI.parse _namespace_name "approvalDate" |> NamespacedName

    /// <summary>
    /// BirthDate of a Person
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#birthdate"></see></summary>
    let birthdate = Namespaced_IRI.parse _namespace_name "birthdate" |> NamespacedName
    /// <summary>
    /// City Town of an physical localisation
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#cityTown"></see></summary>
    let cityTown = Namespaced_IRI.parse _namespace_name "cityTown" |> NamespacedName

    /// <summary>
    /// Indicates a classification for a entity according to a suitable external vocabulary
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#classification"></see></summary>
    let classification =
        Namespaced_IRI.parse _namespace_name "classification" |> NamespacedName

    /// <summary>
    /// It is a generalisation for relationship and classification properties
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#link"></see></summary>
    let link = Namespaced_IRI.parse _namespace_name "link" |> NamespacedName
    /// <summary>
    /// Generic property for represent international and shared codes
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#code"></see></summary>
    let code = Namespaced_IRI.parse _namespace_name "code" |> NamespacedName
    /// <summary>
    /// A given country - http://dbpedia.org/ontology/Country
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#country"></see></summary>
    let country = Namespaced_IRI.parse _namespace_name "country" |> NamespacedName

    /// <summary>
    /// International code of a given country
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#countryCode"></see></summary>
    let countryCode =
        Namespaced_IRI.parse _namespace_name "countryCode" |> NamespacedName

    /// <summary>
    /// Specific currency used for denote amounts, prices and turnovers. Linking with http://dbpedia.org/ontology/Language
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#currency"></see></summary>
    let currency = Namespaced_IRI.parse _namespace_name "currency" |> NamespacedName

    /// <summary>
    /// Code of a specific currency used for denote amounts, prices and turnovers.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#currencyCode"></see></summary>
    let currencyCode =
        Namespaced_IRI.parse _namespace_name "currencyCode" |> NamespacedName

    /// <summary>
    /// Digital CV
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#digitalCV"></see></summary>
    let digitalCV = Namespaced_IRI.parse _namespace_name "digitalCV" |> NamespacedName
    /// <summary>
    /// End of a period of time
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#endDate"></see></summary>
    let endDate = Namespaced_IRI.parse _namespace_name "endDate" |> NamespacedName
    /// <summary>
    /// Flag indicating if the event is fee or free
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#feeOrFree"></see></summary>
    let feeOrFree = Namespaced_IRI.parse _namespace_name "feeOrFree" |> NamespacedName
    /// <summary>
    /// Fractional value to indicate a classification reference or a % allocation in the relationship between entities.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#fraction"></see></summary>
    let fraction = Namespaced_IRI.parse _namespace_name "fraction" |> NamespacedName
    /// <summary>
    /// Amount of a given Funding (measured in a specific currency)
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#funding"></see></summary>
    let funding = Namespaced_IRI.parse _namespace_name "funding" |> NamespacedName
    /// <summary>
    /// This property embraces all Currency-dependent properties
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#money"></see></summary>
    let money = Namespaced_IRI.parse _namespace_name "money" |> NamespacedName

    /// <summary>
    /// Currency code used to denote the funding amount
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#fundingCurrencyCode"></see></summary>
    let fundingCurrencyCode =
        Namespaced_IRI.parse _namespace_name "fundingCurrencyCode" |> NamespacedName

    /// <summary>
    /// Gender of a CERIF person
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#gender"></see></summary>
    let gender = Namespaced_IRI.parse _namespace_name "gender" |> NamespacedName
    /// <summary>
    /// Number of persons enrolled in a Organisation Unit
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#headcount"></see></summary>
    let headcount = Namespaced_IRI.parse _namespace_name "headcount" |> NamespacedName

    /// <summary>
    /// Internal Identifier for a research entity. It fits with the primary key in the corresponding table from the internal database
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#internalIdentifier"></see></summary>
    let internalIdentifier =
        Namespaced_IRI.parse _namespace_name "internalIdentifier" |> NamespacedName

    /// <summary>
    /// The equipment owner's inventory identifier.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#inventoryIdentifier"></see></summary>
    let inventoryIdentifier =
        Namespaced_IRI.parse _namespace_name "inventoryIdentifier" |> NamespacedName

    /// <summary>
    /// A entity is classified within a time interval according to CERIF Semantic Vocabulary.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#isClassifiedBy"></see></summary>
    let isClassifiedBy =
        Namespaced_IRI.parse _namespace_name "isClassifiedBy" |> NamespacedName

    /// <summary>
    /// This is an abstract property to group all properties that inversely relate a entity with other through a time-stamped link.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#isLinkedByEntity"></see></summary>
    let isLinkedByEntity =
        Namespaced_IRI.parse _namespace_name "isLinkedByEntity" |> NamespacedName

    /// <summary>
    /// A given Funding is related with a entity through a time-stamped link.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#isLinkedByFunding"></see></summary>
    let isLinkedByFunding =
        Namespaced_IRI.parse _namespace_name "isLinkedByFunding" |> NamespacedName

    /// <summary>
    /// A given Organisation Unit is related with a entity through a time-stamped link.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#isLinkedByOrganisationUnit"></see></summary>
    let isLinkedByOrganisationUnit =
        Namespaced_IRI.parse _namespace_name "isLinkedByOrganisationUnit" |> NamespacedName

    /// <summary>
    /// A given Person is related with a entity through a time-stamped link.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#isLinkedByPerson"></see></summary>
    let isLinkedByPerson =
        Namespaced_IRI.parse _namespace_name "isLinkedByPerson" |> NamespacedName

    /// <summary>
    /// A given Project is related with a entity through a time-stamped link.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#isLinkedByProject"></see></summary>
    let isLinkedByProject =
        Namespaced_IRI.parse _namespace_name "isLinkedByProject" |> NamespacedName

    /// <summary>
    /// A given Publication is related with a entity through a time-stamped link.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#isLinkedByPublication"></see></summary>
    let isLinkedByPublication =
        Namespaced_IRI.parse _namespace_name "isLinkedByPublication" |> NamespacedName

    /// <summary>
    /// Keywords of a given entity
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#keyword"></see></summary>
    let keyword = Namespaced_IRI.parse _namespace_name "keyword" |> NamespacedName
    /// <summary>
    /// A given language. Linking to http://dbpedia.org/ontology/Language
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#language"></see></summary>
    let language = Namespaced_IRI.parse _namespace_name "language" |> NamespacedName

    /// <summary>
    /// International code of a given language
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#languageCode"></see></summary>
    let languageCode =
        Namespaced_IRI.parse _namespace_name "languageCode" |> NamespacedName

    /// <summary>
    /// This is an abstract property to group all properties that directly relate a entity with other through a time-stamped link.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#linksToEntity"></see></summary>
    let linksToEntity =
        Namespaced_IRI.parse _namespace_name "linksToEntity" |> NamespacedName

    /// <summary>
    /// It relates a entity with a given Funding entity through a time-stamped link.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#linksToFunding"></see></summary>
    let linksToFunding =
        Namespaced_IRI.parse _namespace_name "linksToFunding" |> NamespacedName

    /// <summary>
    /// It relates a entity with a given Organisation Unit through a time-stamped link.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#linksToOrganisationUnit"></see></summary>
    let linksToOrganisationUnit =
        Namespaced_IRI.parse _namespace_name "linksToOrganisationUnit" |> NamespacedName

    /// <summary>
    /// It relates a entity with a given Person through a time-stamped link.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#linksToPerson"></see></summary>
    let linksToPerson =
        Namespaced_IRI.parse _namespace_name "linksToPerson" |> NamespacedName

    /// <summary>
    /// It relates a entity with a given Postal Address through a time-stamped link. Used, for example, in Persons and Organisation Units
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#linksToPostalAddress"></see></summary>
    let linksToPostalAddress =
        Namespaced_IRI.parse _namespace_name "linksToPostalAddress" |> NamespacedName

    /// <summary>
    /// It relates a  entity with a given Project through a time-stamped link.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#linksToProject"></see></summary>
    let linksToProject =
        Namespaced_IRI.parse _namespace_name "linksToProject" |> NamespacedName

    /// <summary>
    /// It relates a entity with a given Publication through a time-stamped link.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#linksToPublication"></see></summary>
    let linksToPublication =
        Namespaced_IRI.parse _namespace_name "linksToPublication" |> NamespacedName

    /// <summary>
    /// The equipment manufacturer's ID.
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#manufacturerIdentifier"></see></summary>
    let manufacturerIdentifier =
        Namespaced_IRI.parse _namespace_name "manufacturerIdentifier" |> NamespacedName

    /// <summary>
    /// Name of a CERIF entity, e.g.: Person, or Organization Unit
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#name"></see></summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName

    /// <summary>
    /// Number of a Registered Patent
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#patentNumber"></see></summary>
    let patentNumber =
        Namespaced_IRI.parse _namespace_name "patentNumber" |> NamespacedName

    /// <summary>
    /// Postal Code of a given Address
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#postCode"></see></summary>
    let postCode = Namespaced_IRI.parse _namespace_name "postCode" |> NamespacedName
    /// <summary>
    /// Quantity of payment or compensation given by one party to another in return for goods or service (measured in a specific currency)
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#price"></see></summary>
    let price = Namespaced_IRI.parse _namespace_name "price" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.eurocris.org/ontologies/cerif/1.3#priceCurrencyCode"></see>
    /// </summary>
    let priceCurrencyCode =
        Namespaced_IRI.parse _namespace_name "priceCurrencyCode" |> NamespacedName

    /// <summary>
    /// Number of a Product
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#productNumber"></see></summary>
    let productNumber =
        Namespaced_IRI.parse _namespace_name "productNumber" |> NamespacedName

    /// <summary>
    /// Registration Date of a patent
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#registrationDate"></see></summary>
    let registrationDate =
        Namespaced_IRI.parse _namespace_name "registrationDate" |> NamespacedName

    /// <summary>
    /// Research Activities
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#researchActivities"></see></summary>
    let researchActivities =
        Namespaced_IRI.parse _namespace_name "researchActivities" |> NamespacedName

    /// <summary>
    /// Research Interests
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#researchInterests"></see></summary>
    let researchInterests =
        Namespaced_IRI.parse _namespace_name "researchInterests" |> NamespacedName

    /// <summary>
    /// Indicates a role for the association or composition between two CERIF entities indicated by a term from a suitable external vocabulary
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#role"></see></summary>
    let role = Namespaced_IRI.parse _namespace_name "role" |> NamespacedName
    /// <summary>
    /// Beginning of a period of time
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#startDate"></see></summary>
    let startDate = Namespaced_IRI.parse _namespace_name "startDate" |> NamespacedName
    /// <summary>
    /// Title of a given CERIF entity
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#title"></see></summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName
    /// <summary>
    /// Turnover of a Organisation Unit (measured in a specific currency)
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#turnover"></see></summary>
    let turnover = Namespaced_IRI.parse _namespace_name "turnover" |> NamespacedName

    /// <summary>
    /// Currency Code used to denote turnovers
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#turnoverCurrencyCode"></see></summary>
    let turnoverCurrencyCode =
        Namespaced_IRI.parse _namespace_name "turnoverCurrencyCode" |> NamespacedName

    /// <summary>
    /// Uniform Resource Identifier related with a given CERIF entity
    /// <see href="http://www.eurocris.org/ontologies/cerif/1.3#uri"></see></summary>
    let uri = Namespaced_IRI.parse _namespace_name "uri" |> NamespacedName
