#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module cerif =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.eurocris.org/ontologies/cerif/1.3#" "cerif"

    /// <summary>
    ///   <para>rdfs:label : Base Entity^^xsd:string</para>
    ///   <para>rdfs:comment : This abstract class brings together the main entities of the CERIF model.^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#BaseEntity">cerif:BaseEntity</a>
    /// </summary>
    let BaseEntity = _prefixId.prefix "BaseEntity"
    /// <summary>
    ///   <para>rdfs:label : Cite^^xsd:string</para>
    ///   <para>rdfs:comment : Cite^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#Cite">cerif:Cite</a>
    /// </summary>
    let Cite = _prefixId.prefix "Cite"
    /// <summary>
    ///   <para>rdfs:label : Classification^^xsd:string</para>
    ///   <para>rdfs:comment : Represents the classification of a given entity^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#Classification">cerif:Classification</a>
    /// </summary>
    let Classification = _prefixId.prefix "Classification"
    /// <summary>
    ///   <para>rdfs:label : Curriculum Vitae^^xsd:string</para>
    ///   <para>rdfs:comment : Curriculum Vitae^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#CurriculumVitae">cerif:CurriculumVitae</a>
    /// </summary>
    let CurriculumVitae = _prefixId.prefix "CurriculumVitae"
    /// <summary>
    ///   <para>rdfs:label : Electronic Address^^xsd:string</para>
    ///   <para>rdfs:comment : ElectronicAddress^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#ElectronicAddress">cerif:ElectronicAddress</a>
    /// </summary>
    let ElectronicAddress = _prefixId.prefix "ElectronicAddress"
    /// <summary>
    ///   <para>rdfs:label : Entity^^xsd:string</para>
    ///   <para>rdfs:comment : Common superclass of all non-link entities, as an aid in querying.^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#Entity">cerif:Entity</a>
    /// </summary>
    let Entity = _prefixId.prefix "Entity"
    /// <summary>
    ///   <para>rdfs:label : Equipment^^xsd:string</para>
    ///   <para>rdfs:comment : Equipment^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#Equipment">cerif:Equipment</a>
    /// </summary>
    let Equipment = _prefixId.prefix "Equipment"
    /// <summary>
    ///   <para>rdfs:label : Event^^xsd:string</para>
    ///   <para>rdfs:comment : Event^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#Event">cerif:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>rdfs:label : Expertise and skills^^xsd:string</para>
    ///   <para>rdfs:comment : Expertise and skills^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#ExpSkill">cerif:ExpSkill</a>
    /// </summary>
    let ExpSkill = _prefixId.prefix "ExpSkill"
    /// <summary>
    ///   <para>rdfs:label : Facility^^xsd:string</para>
    ///   <para>rdfs:comment : Facility^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#Facility">cerif:Facility</a>
    /// </summary>
    let Facility = _prefixId.prefix "Facility"
    /// <summary>
    ///   <para>rdfs:label : Funding^^xsd:string</para>
    ///   <para>rdfs:comment : Funding^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#Funding">cerif:Funding</a>
    /// </summary>
    let Funding = _prefixId.prefix "Funding"
    /// <summary>
    ///   <para>rdfs:label : Infrastructure Entity^^xsd:string</para>
    ///   <para>rdfs:comment : Abstract entity for representing infrastructures^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#InfrastructureEntity">cerif:InfrastructureEntity</a>
    /// </summary>
    let InfrastructureEntity = _prefixId.prefix "InfrastructureEntity"
    /// <summary>
    ///   <para>rdfs:label : Metrics^^xsd:string</para>
    ///   <para>rdfs:comment : Metrics^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#Metrics">cerif:Metrics</a>
    /// </summary>
    let Metrics = _prefixId.prefix "Metrics"
    /// <summary>
    ///   <para>rdfs:label : Organizational Unit (cfOrgUnit)^^xsd:string</para>
    ///   <para>rdfs:comment : A given organizational unit^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#OrganizationalUnit">cerif:OrganizationalUnit</a>
    /// </summary>
    let OrganizationalUnit = _prefixId.prefix "OrganizationalUnit"
    /// <summary>
    ///   <para>rdfs:label : Patent^^xsd:string</para>
    ///   <para>rdfs:comment : A registered patent as a research result^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#Patent">cerif:Patent</a>
    /// </summary>
    let Patent = _prefixId.prefix "Patent"
    /// <summary>
    ///   <para>rdfs:label : Person (cfPers)^^xsd:string</para>
    ///   <para>rdfs:comment : A given person^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#Person">cerif:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>rdfs:label : Postal Address^^xsd:string</para>
    ///   <para>rdfs:comment : Postal Address^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#PostalAddress">cerif:PostalAddress</a>
    /// </summary>
    let PostalAddress = _prefixId.prefix "PostalAddress"
    /// <summary>
    ///   <para>rdfs:label : Price Award^^xsd:string</para>
    ///   <para>rdfs:comment : Price Award^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#PriceAward">cerif:PriceAward</a>
    /// </summary>
    let PriceAward = _prefixId.prefix "PriceAward"
    /// <summary>
    ///   <para>rdfs:label : Product^^xsd:string</para>
    ///   <para>rdfs:comment : A research result that is classified neither as a patent nor as a publication.^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#Product">cerif:Product</a>
    /// </summary>
    let Product = _prefixId.prefix "Product"
    /// <summary>
    ///   <para>rdfs:label : Project^^xsd:string</para>
    ///   <para>rdfs:comment : A research project^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#Project">cerif:Project</a>
    /// </summary>
    let Project = _prefixId.prefix "Project"
    /// <summary>
    ///   <para>rdfs:label : Publication^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a scientific or academic publication ^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#Publication">cerif:Publication</a>
    /// </summary>
    let Publication = _prefixId.prefix "Publication"
    /// <summary>
    ///   <para>rdfs:label : Qualification^^xsd:string</para>
    ///   <para>rdfs:comment : Qualification^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#Qualification">cerif:Qualification</a>
    /// </summary>
    let Qualification = _prefixId.prefix "Qualification"
    /// <summary>
    ///   <para>rdfs:label : Relationship^^xsd:string</para>
    ///   <para>rdfs:comment : intermediate entity between two entities.^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#Relationship">cerif:Relationship</a>
    /// </summary>
    let Relationship = _prefixId.prefix "Relationship"
    /// <summary>
    ///   <para>rdfs:label : Result Entity^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a research result^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#ResultEntity">cerif:ResultEntity</a>
    /// </summary>
    let ResultEntity = _prefixId.prefix "ResultEntity"
    /// <summary>
    ///   <para>rdfs:label : Second-level Entity^^xsd:string</para>
    ///   <para>rdfs:comment : The 2nd level entities allow for the representation of the research context by linking to them from the base and result entities.^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#SecondLevelEntity">cerif:SecondLevelEntity</a>
    /// </summary>
    let SecondLevelEntity = _prefixId.prefix "SecondLevelEntity"
    /// <summary>
    ///   <para>rdfs:label : Service^^xsd:string</para>
    ///   <para>rdfs:comment : Service^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#Service">cerif:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    /// <summary>
    ///   <para>rdfs:label : Abstract^^xsd:string</para>
    ///   <para>rdfs:comment : Abstract of a given Project^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#abstract">cerif:abstract</a>
    /// </summary>
    let abstract_ = _prefixId.prefix "abstract"
    /// <summary>
    ///   <para>rdfs:label : Acronym^^xsd:string</para>
    ///   <para>rdfs:comment : Acronym of a given Project or an Organisation Unit^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#acronym">cerif:acronym</a>
    /// </summary>
    let acronym = _prefixId.prefix "acronym"
    /// <summary>
    ///   <para>rdfs:label : Address Line^^xsd:string</para>
    ///   <para>rdfs:comment : Numbered line of a given postal address^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#addressLine">cerif:addressLine</a>
    /// </summary>
    let addressLine = _prefixId.prefix "addressLine"
    /// <summary>
    ///   <para>rdfs:label : Agrovoc Classification^^xsd:string</para>
    ///   <para>rdfs:comment : External Classification Scheme according to Agrovoc Vocabulary^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#agrovoc">cerif:agrovoc</a>
    /// </summary>
    let agrovoc = _prefixId.prefix "agrovoc"
    /// <summary>
    ///   <para>rdfs:label : Approval Date^^xsd:string</para>
    ///   <para>rdfs:comment : Approval Date of a patent^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#approvalDate">cerif:approvalDate</a>
    /// </summary>
    let approvalDate = _prefixId.prefix "approvalDate"
    /// <summary>
    ///   <para>rdfs:label : Birthdate^^xsd:string</para>
    ///   <para>rdfs:comment : BirthDate of a Person^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#birthdate">cerif:birthdate</a>
    /// </summary>
    let birthdate = _prefixId.prefix "birthdate"
    let brigitte = _prefixId.prefix "brigitte"
    /// <summary>
    ///   <para>rdfs:label : City Town^^xsd:string</para>
    ///   <para>rdfs:comment : City Town of an physical localisation^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#cityTown">cerif:cityTown</a>
    /// </summary>
    let cityTown = _prefixId.prefix "cityTown"
    /// <summary>
    ///   <para>rdfs:label : Classification^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates a classification for a entity according to a suitable external vocabulary^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#classification">cerif:classification</a>
    /// </summary>
    let classification = _prefixId.prefix "classification"
    /// <summary>
    ///   <para>rdfs:label : Code^^xsd:string</para>
    ///   <para>rdfs:comment : Generic property for represent international and shared codes^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#code">cerif:code</a>
    /// </summary>
    let code = _prefixId.prefix "code"
    /// <summary>
    ///   <para>rdfs:label : Country ^^xsd:string</para>
    ///   <para>rdfs:comment : A given country - http://dbpedia.org/ontology/Country^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#country">cerif:country</a>
    /// </summary>
    let country = _prefixId.prefix "country"
    /// <summary>
    ///   <para>rdfs:label : Country Code^^xsd:string</para>
    ///   <para>rdfs:comment : International code of a given country ^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#countryCode">cerif:countryCode</a>
    /// </summary>
    let countryCode = _prefixId.prefix "countryCode"
    /// <summary>
    ///   <para>rdfs:label : Currency^^xsd:string</para>
    ///   <para>rdfs:comment : Specific currency used for denote amounts, prices and turnovers. Linking with http://dbpedia.org/ontology/Language^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#currency">cerif:currency</a>
    /// </summary>
    let currency = _prefixId.prefix "currency"
    /// <summary>
    ///   <para>rdfs:label : Currency Code^^xsd:string</para>
    ///   <para>rdfs:comment : Code of a specific currency used for denote amounts, prices and turnovers.^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#currencyCode">cerif:currencyCode</a>
    /// </summary>
    let currencyCode = _prefixId.prefix "currencyCode"
    /// <summary>
    ///   <para>rdfs:label : Digital CV^^xsd:string</para>
    ///   <para>rdfs:comment : Digital CV^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#digitalCV">cerif:digitalCV</a>
    /// </summary>
    let digitalCV = _prefixId.prefix "digitalCV"
    /// <summary>
    ///   <para>rdfs:comment : End of a period of time^^xsd:string</para>
    ///   <para>rdfs:label : End Date^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#endDate">cerif:endDate</a>
    /// </summary>
    let endDate = _prefixId.prefix "endDate"
    /// <summary>
    ///   <para>rdfs:label : Fee Or Free^^xsd:string</para>
    ///   <para>rdfs:comment : Flag indicating if the event is fee or free^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#feeOrFree">cerif:feeOrFree</a>
    /// </summary>
    let feeOrFree = _prefixId.prefix "feeOrFree"
    /// <summary>
    ///   <para>rdfs:label : Fraction^^xsd:string</para>
    ///   <para>rdfs:comment : Fractional value to indicate a classification reference or a % allocation in the relationship between entities.^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#fraction">cerif:fraction</a>
    /// </summary>
    let fraction = _prefixId.prefix "fraction"
    /// <summary>
    ///   <para>rdfs:label : Funding^^xsd:string</para>
    ///   <para>rdfs:comment : Amount of a given Funding (measured in a specific currency)^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#funding">cerif:funding</a>
    /// </summary>
    let funding = _prefixId.prefix "funding"
    /// <summary>
    ///   <para>rdfs:label : Funding Currency Code^^xsd:string</para>
    ///   <para>rdfs:comment : Currency code used to denote the funding amount^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#fundingCurrencyCode">cerif:fundingCurrencyCode</a>
    /// </summary>
    let fundingCurrencyCode = _prefixId.prefix "fundingCurrencyCode"
    let geert = _prefixId.prefix "geert"
    /// <summary>
    ///   <para>rdfs:label : Gender^^xsd:string</para>
    ///   <para>rdfs:comment : Gender of a CERIF person^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#gender">cerif:gender</a>
    /// </summary>
    let gender = _prefixId.prefix "gender"
    /// <summary>
    ///   <para>rdfs:label : Headcount^^xsd:string</para>
    ///   <para>rdfs:comment : Number of persons enrolled in a Organisation Unit^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#headcount">cerif:headcount</a>
    /// </summary>
    let headcount = _prefixId.prefix "headcount"
    /// <summary>
    ///   <para>rdfs:label : Internal Identifier^^xsd:string</para>
    ///   <para>rdfs:comment : Internal Identifier for a research entity. It fits with the primary key in the corresponding table from the internal database^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#internalIdentifier">cerif:internalIdentifier</a>
    /// </summary>
    let internalIdentifier = _prefixId.prefix "internalIdentifier"
    /// <summary>
    ///   <para>rdfs:label : Inventory Identifier^^xsd:string</para>
    ///   <para>rdfs:comment : The equipment owner's inventory identifier.^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#inventoryIdentifier">cerif:inventoryIdentifier</a>
    /// </summary>
    let inventoryIdentifier = _prefixId.prefix "inventoryIdentifier"
    /// <summary>
    ///   <para>rdfs:label : Is Classified By^^xsd:string</para>
    ///   <para>rdfs:comment : A entity is classified within a time interval according to CERIF Semantic Vocabulary.^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#isClassifiedBy">cerif:isClassifiedBy</a>
    /// </summary>
    let isClassifiedBy = _prefixId.prefix "isClassifiedBy"
    /// <summary>
    ///   <para>rdfs:label : Is Linked by Entity^^xsd:string</para>
    ///   <para>rdfs:comment : This is an abstract property to group all properties that inversely relate a entity with other through a time-stamped link.^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#isLinkedByEntity">cerif:isLinkedByEntity</a>
    /// </summary>
    let isLinkedByEntity = _prefixId.prefix "isLinkedByEntity"
    /// <summary>
    ///   <para>rdfs:label : Is Linked By Funding^^xsd:string</para>
    ///   <para>rdfs:comment : A given Funding is related with a entity through a time-stamped link.^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#isLinkedByFunding">cerif:isLinkedByFunding</a>
    /// </summary>
    let isLinkedByFunding = _prefixId.prefix "isLinkedByFunding"
    /// <summary>
    ///   <para>rdfs:label : Is Linked By a Organisation Unit^^xsd:string</para>
    ///   <para>rdfs:comment : A given Organisation Unit is related with a entity through a time-stamped link.^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#isLinkedByOrganisationUnit">cerif:isLinkedByOrganisationUnit</a>
    /// </summary>
    let isLinkedByOrganisationUnit = _prefixId.prefix "isLinkedByOrganisationUnit"
    /// <summary>
    ///   <para>rdfs:label : Is Linked By a Person^^xsd:string</para>
    ///   <para>rdfs:comment : A given Person is related with a entity through a time-stamped link. ^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#isLinkedByPerson">cerif:isLinkedByPerson</a>
    /// </summary>
    let isLinkedByPerson = _prefixId.prefix "isLinkedByPerson"
    /// <summary>
    ///   <para>rdfs:label : is Linked By Project^^xsd:string</para>
    ///   <para>rdfs:comment : A given Project is related with a entity through a time-stamped link.^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#isLinkedByProject">cerif:isLinkedByProject</a>
    /// </summary>
    let isLinkedByProject = _prefixId.prefix "isLinkedByProject"
    /// <summary>
    ///   <para>rdfs:label : is Linked By Publication^^xsd:string</para>
    ///   <para>rdfs:comment : A given Publication is related with a entity through a time-stamped link.^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#isLinkedByPublication">cerif:isLinkedByPublication</a>
    /// </summary>
    let isLinkedByPublication = _prefixId.prefix "isLinkedByPublication"
    let jan = _prefixId.prefix "jan"
    let keith = _prefixId.prefix "keith"
    /// <summary>
    ///   <para>rdfs:label : Keyword^^xsd:string</para>
    ///   <para>rdfs:comment : Keywords of a given entity^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#keyword">cerif:keyword</a>
    /// </summary>
    let keyword = _prefixId.prefix "keyword"
    /// <summary>
    ///   <para>rdfs:label : Language^^xsd:string</para>
    ///   <para>rdfs:comment : A given language. Linking to http://dbpedia.org/ontology/Language^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#language">cerif:language</a>
    /// </summary>
    let language = _prefixId.prefix "language"
    /// <summary>
    ///   <para>rdfs:label : Language Code^^xsd:string</para>
    ///   <para>rdfs:comment : International code of a given language^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#languageCode">cerif:languageCode</a>
    /// </summary>
    let languageCode = _prefixId.prefix "languageCode"
    /// <summary>
    ///   <para>rdfs:label : Link^^xsd:string</para>
    ///   <para>rdfs:comment : It is a generalisation for relationship and classification properties^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#link">cerif:link</a>
    /// </summary>
    let link = _prefixId.prefix "link"
    /// <summary>
    ///   <para>rdfs:label : Links to Entity^^xsd:string</para>
    ///   <para>rdfs:comment : This is an abstract property to group all properties that directly relate a entity with other through a time-stamped link.^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#linksToEntity">cerif:linksToEntity</a>
    /// </summary>
    let linksToEntity = _prefixId.prefix "linksToEntity"
    /// <summary>
    ///   <para>rdfs:label : Links to Funding^^xsd:string</para>
    ///   <para>rdfs:comment : It relates a entity with a given Funding entity through a time-stamped link.^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#linksToFunding">cerif:linksToFunding</a>
    /// </summary>
    let linksToFunding = _prefixId.prefix "linksToFunding"
    /// <summary>
    ///   <para>rdfs:label : Links To a Organisation Unit^^xsd:string</para>
    ///   <para>rdfs:comment : It relates a entity with a given Organisation Unit through a time-stamped link.^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#linksToOrganisationUnit">cerif:linksToOrganisationUnit</a>
    /// </summary>
    let linksToOrganisationUnit = _prefixId.prefix "linksToOrganisationUnit"
    /// <summary>
    ///   <para>rdfs:label : Is Linked By a Person^^xsd:string</para>
    ///   <para>rdfs:comment : It relates a entity with a given Person through a time-stamped link.^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#linksToPerson">cerif:linksToPerson</a>
    /// </summary>
    let linksToPerson = _prefixId.prefix "linksToPerson"
    /// <summary>
    ///   <para>rdfs:label : Links to a Postal Address^^xsd:string</para>
    ///   <para>rdfs:comment : It relates a entity with a given Postal Address through a time-stamped link. Used, for example, in Persons and Organisation Units^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#linksToPostalAddress">cerif:linksToPostalAddress</a>
    /// </summary>
    let linksToPostalAddress = _prefixId.prefix "linksToPostalAddress"
    /// <summary>
    ///   <para>rdfs:label : Links To a Project^^xsd:string</para>
    ///   <para>rdfs:comment : It relates a  entity with a given Project through a time-stamped link.^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#linksToProject">cerif:linksToProject</a>
    /// </summary>
    let linksToProject = _prefixId.prefix "linksToProject"
    /// <summary>
    ///   <para>rdfs:label : Links To a Publication^^xsd:string</para>
    ///   <para>rdfs:comment : It relates a entity with a given Publication through a time-stamped link.^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#linksToPublication">cerif:linksToPublication</a>
    /// </summary>
    let linksToPublication = _prefixId.prefix "linksToPublication"
    /// <summary>
    ///   <para>rdfs:label : Manufacturer Identifier^^xsd:string</para>
    ///   <para>rdfs:comment : The equipment manufacturer's ID.^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#manufacturerIdentifier">cerif:manufacturerIdentifier</a>
    /// </summary>
    let manufacturerIdentifier = _prefixId.prefix "manufacturerIdentifier"
    /// <summary>
    ///   <para>rdfs:label : Money^^xsd:string</para>
    ///   <para>rdfs:comment : This property embraces all Currency-dependent properties ^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#money">cerif:money</a>
    /// </summary>
    let money = _prefixId.prefix "money"
    let msicilia = _prefixId.prefix "msicilia"
    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <para>rdfs:comment : Name of a CERIF entity, e.g.: Person, or Organization Unit^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#name">cerif:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>rdfs:label : Patent Number^^xsd:string</para>
    ///   <para>rdfs:comment : Number of a Registered Patent^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#patentNumber">cerif:patentNumber</a>
    /// </summary>
    let patentNumber = _prefixId.prefix "patentNumber"
    /// <summary>
    ///   <para>rdfs:label : Post Code^^xsd:string</para>
    ///   <para>rdfs:comment : Postal Code of a given Address^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#postCode">cerif:postCode</a>
    /// </summary>
    let postCode = _prefixId.prefix "postCode"
    /// <summary>
    ///   <para>rdfs:label : Price^^xsd:string</para>
    ///   <para>rdfs:comment : Quantity of payment or compensation given by one party to another in return for goods or service (measured in a specific currency)^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#price">cerif:price</a>
    /// </summary>
    let price = _prefixId.prefix "price"
    /// <summary>
    ///   <para>rdfs:label : Price Currency Code^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#priceCurrencyCode">cerif:priceCurrencyCode</a>
    /// </summary>
    let priceCurrencyCode = _prefixId.prefix "priceCurrencyCode"
    /// <summary>
    ///   <para>rdfs:label : Product Number^^xsd:string</para>
    ///   <para>rdfs:comment : Number of a Product^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#productNumber">cerif:productNumber</a>
    /// </summary>
    let productNumber = _prefixId.prefix "productNumber"
    /// <summary>
    ///   <para>rdfs:label : Registration Date^^xsd:string</para>
    ///   <para>rdfs:comment : Registration Date of a patent^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#registrationDate">cerif:registrationDate</a>
    /// </summary>
    let registrationDate = _prefixId.prefix "registrationDate"
    /// <summary>
    ///   <para>rdfs:label : Research Activities^^xsd:string</para>
    ///   <para>rdfs:comment : Research Activities^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#researchActivities">cerif:researchActivities</a>
    /// </summary>
    let researchActivities = _prefixId.prefix "researchActivities"
    /// <summary>
    ///   <para>rdfs:label : Research Interests^^xsd:string</para>
    ///   <para>rdfs:comment : Research Interests^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#researchInterests">cerif:researchInterests</a>
    /// </summary>
    let researchInterests = _prefixId.prefix "researchInterests"
    /// <summary>
    ///   <para>rdfs:label : Role^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates a role for the association or composition between two CERIF entities indicated by a term from a suitable external vocabulary^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#role">cerif:role</a>
    /// </summary>
    let role = _prefixId.prefix "role"
    let ruizrube = _prefixId.prefix "ruizrube"
    /// <summary>
    ///   <para>rdfs:comment : Beginning of a period of time^^xsd:string</para>
    ///   <para>rdfs:label : Start Date^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#startDate">cerif:startDate</a>
    /// </summary>
    let startDate = _prefixId.prefix "startDate"
    /// <summary>
    ///   <para>rdfs:label : Title^^xsd:string</para>
    ///   <para>rdfs:comment : Title of a given CERIF entity^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#title">cerif:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>rdfs:label : Turnover^^xsd:string</para>
    ///   <para>rdfs:comment : Turnover of a Organisation Unit (measured in a specific currency)^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#turnover">cerif:turnover</a>
    /// </summary>
    let turnover = _prefixId.prefix "turnover"
    /// <summary>
    ///   <para>rdfs:label : Turnover Currency Code^^xsd:string</para>
    ///   <para>rdfs:comment : Currency Code used to denote turnovers^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#turnoverCurrencyCode">cerif:turnoverCurrencyCode</a>
    /// </summary>
    let turnoverCurrencyCode = _prefixId.prefix "turnoverCurrencyCode"
    /// <summary>
    ///   <para>rdfs:label : URI^^xsd:string</para>
    ///   <para>rdfs:comment : Uniform Resource Identifier related with a given CERIF entity^^xsd:string</para>
    ///   <a href="http://www.eurocris.org/ontologies/cerif/1.3#uri">cerif:uri</a>
    /// </summary>
    let uri = _prefixId.prefix "uri"
