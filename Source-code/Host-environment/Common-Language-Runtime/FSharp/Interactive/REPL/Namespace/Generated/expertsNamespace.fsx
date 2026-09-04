#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module experts =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://w3id.org/emmo-maeo/maeo#" "experts"

    /// <summary>
    ///   <para>rdfs:comment : It describes an actual certification a human expert may possess, with datatype properties like certificationTitle and expirationDate.^^xsd:string</para>
    ///   <para>skos:prefLabel : Certification</para>
    ///   <para>rdfs:label : Certification^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#Certification">experts:Certification</a>
    /// </summary>
    let Certification = _prefixId.prefix "Certification"
    /// <summary>
    ///   <para>rdfs:comment : It models the authority that has issued a certification.^^xsd:string</para>
    ///   <para>skos:prefLabel : Certification Authority</para>
    ///   <para>rdfs:label : Certification Authority^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#CertificationAuthority">experts:CertificationAuthority</a>
    /// </summary>
    let CertificationAuthority = _prefixId.prefix "CertificationAuthority"
    /// <summary>
    ///   <para>rdfs:comment : It is meant to describe the details of certifications possessed by a human expert.^^xsd:string</para>
    ///   <para>skos:prefLabel : Certification Detail</para>
    ///   <para>rdfs:label : Certification Detail^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#CertificationDetail">experts:CertificationDetail</a>
    /// </summary>
    let CertificationDetail = _prefixId.prefix "CertificationDetail"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : Competence^^xsd:string</para>
    ///   <para>skos:prefLabel : Competence</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#Competence">experts:Competence</a>
    /// </summary>
    let Competence = _prefixId.prefix "Competence"
    /// <summary>
    ///   <para>rdfs:comment : It is meant to model the actual contract(s) a given expert may be currently under. It includes datatype properties like contractType and contractConstraint, the latter modeling potential legal or business constraints and limitations a contract may specify with regard to potential consulting and collaboration activities an expert may be allowed to carry out.^^xsd:string</para>
    ///   <para>skos:prefLabel : Contract</para>
    ///   <para>rdfs:label : Contract^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#Contract">experts:Contract</a>
    /// </summary>
    let Contract = _prefixId.prefix "Contract"
    /// <summary>
    ///   <para>rdfs:comment : It describes the details about the contract a human experts is currently under.^^xsd:string</para>
    ///   <para>skos:prefLabel : Contractual Detail</para>
    ///   <para>rdfs:label : Contractual Detail^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#ContractualDetail">experts:ContractualDetail</a>
    /// </summary>
    let ContractualDetail = _prefixId.prefix "ContractualDetail"
    let DTEN = _prefixId.prefix "DTEN"
    /// <summary>
    ///   <para>rdfs:comment : It models the daily rate a human experts requests.^^xsd:string</para>
    ///   <para>skos:prefLabel : Daily Rate</para>
    ///   <para>rdfs:label : Daily Rate^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#DailyRate">experts:DailyRate</a>
    /// </summary>
    let DailyRate = _prefixId.prefix "DailyRate"
    let DanieleToti = _prefixId.prefix "DanieleToti"
    let English = _prefixId.prefix "English"
    /// <summary>
    ///   <para>rdfs:comment : A knowledge-providing human expert that possesses a certain expertise and whose information can be stored and accessed within the MarketPlace application. It sports datatype properties like experienceInYears and yearsOnMarketPlace, and it is the domain of several object properties.^^xsd:string</para>
    ///   <para>skos:prefLabel : Expert</para>
    ///   <para>rdfs:label : Expert^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#Expert">experts:Expert</a>
    /// </summary>
    let Expert = _prefixId.prefix "Expert"
    /// <summary>
    ///   <para>rdfs:comment : It is meant to represent the superclass of all of the objective properties potentially possessed by the entities of the MAEO ontology.^^xsd:string</para>
    ///   <para>skos:prefLabel : Expert Objective Property</para>
    ///   <para>rdfs:label : Expert Objective Property^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#ExpertObjectiveProperty">experts:ExpertObjectiveProperty</a>
    /// </summary>
    let ExpertObjectiveProperty = _prefixId.prefix "ExpertObjectiveProperty"
    /// <summary>
    ///   <para>rdfs:comment : It models the organization an expert may be working at/with, distinguishing it from a knowledge-providing organization. An instance of the former may also be the same organization as an instance of the latter; in order to model such a case, the object property refersToOrganizationWithExpertise (domain: ExpertOrganization, range: Organization) has been introduced for connecting the two.^^xsd:string</para>
    ///   <para>skos:prefLabel : Expert Organization</para>
    ///   <para>rdfs:label : Expert Organization^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#ExpertOrganization">experts:ExpertOrganization</a>
    /// </summary>
    let ExpertOrganization = _prefixId.prefix "ExpertOrganization"
    /// <summary>
    ///   <para>rdfs:comment : It is meant to represent the superclass of subjective properties that may be possessed by entities modeled in the MAEO ontology.^^xsd:string</para>
    ///   <para>skos:prefLabel : Expert Subjective Property</para>
    ///   <para>rdfs:label : Expert Subjective Property^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#ExpertSubjectiveProperty">experts:ExpertSubjectiveProperty</a>
    /// </summary>
    let ExpertSubjectiveProperty = _prefixId.prefix "ExpertSubjectiveProperty"
    /// <summary>
    ///   <para>rdfs:comment : It represents the expertise possessed by a generic knowledge provider, by which users of the MarketPlace application can look for experts and such (and vice versa).^^xsd:string</para>
    ///   <para>skos:prefLabel : Expertise</para>
    ///   <para>rdfs:label : Expertise^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#Expertise">experts:Expertise</a>
    /// </summary>
    let Expertise = _prefixId.prefix "Expertise"
    let Expertise1 = _prefixId.prefix "Expertise1"
    let Expertise2 = _prefixId.prefix "Expertise2"
    let Expertise3 = _prefixId.prefix "Expertise3"
    let Expertise4 = _prefixId.prefix "Expertise4"
    /// <summary>
    ///   <para>rdfs:comment : It represents a connection with an external profile for a given experts, e.g. a social network profile on LinkedIn, Facebook, etc.^^xsd:string</para>
    ///   <para>skos:prefLabel : External Profile</para>
    ///   <para>rdfs:label : External Profile^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#ExternalProfile">experts:ExternalProfile</a>
    /// </summary>
    let ExternalProfile = _prefixId.prefix "ExternalProfile"
    let GerhardGoldbeck = _prefixId.prefix "GerhardGoldbeck"
    /// <summary>
    ///   <para>rdfs:comment : It models a generic provider of knowledge that possesses a certain expertise.^^xsd:string</para>
    ///   <para>skos:prefLabel : Knowledge Provider</para>
    ///   <para>rdfs:label : Knowledge Provider^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#KnowledgeProvider">experts:KnowledgeProvider</a>
    /// </summary>
    let KnowledgeProvider = _prefixId.prefix "KnowledgeProvider"
    /// <summary>
    ///   <para>rdfs:comment : It models a generic seeker of knowledge as a user of the MarketPlace application.^^xsd:string</para>
    ///   <para>skos:prefLabel : Knowledge Seeker</para>
    ///   <para>rdfs:label : Knowledge Seeker^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#KnowledgeSeeker">experts:KnowledgeSeeker</a>
    /// </summary>
    let KnowledgeSeeker = _prefixId.prefix "KnowledgeSeeker"
    /// <summary>
    ///   <para>rdfs:comment : a knowledge-providing laboratory.^^xsd:string</para>
    ///   <para>skos:prefLabel : Knowledge-providing Lab</para>
    ///   <para>rdfs:label : Knowledge-providing Lab^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#Lab">experts:Lab</a>
    /// </summary>
    let Lab = _prefixId.prefix "Lab"
    /// <summary>
    ///   <para>rdfs:comment : It describes a language known by a human expert. By reification (via the rdf:Statement construct), the datatype properties languageType and languageLevel are associated with a 'Expert knowsLanguage Language' triple.^^xsd:string</para>
    ///   <para>skos:prefLabel : Language</para>
    ///   <para>rdfs:label : Language^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#Language">experts:Language</a>
    /// </summary>
    let Language = _prefixId.prefix "Language"
    /// <summary>
    ///   <para>rdfs:comment : It describes the physical address of an organization.^^xsd:string</para>
    ///   <para>skos:prefLabel : Location</para>
    ///   <para>rdfs:label : Location^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#Location">experts:Location</a>
    /// </summary>
    let Location = _prefixId.prefix "Location"
    /// <summary>
    ///   <para>rdfs:comment : It models a generic Agent in the MarketPlace, i.e. any entity (Knowledge Seeker, Knowledge Provider) that can act on the MarketPlace^^xsd:string</para>
    ///   <para>skos:prefLabel : MarketPlace Agent</para>
    ///   <para>rdfs:label : MarketPlace Agent^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#MarketPlaceAgent">experts:MarketPlaceAgent</a>
    /// </summary>
    let MarketPlaceAgent = _prefixId.prefix "MarketPlaceAgent"

    /// <summary>
    ///   <para>rdfs:comment : This is the root class of the MAEO ontology, introduced for providing the ontology itself with a tree-like structure, with all of its other explicitly defined internal classes being subclasses of this class at various hierarchical levels.^^xsd:string</para>
    ///   <para>skos:prefLabel : MarketPlace Agent and Expert Ontology</para>
    ///   <para>rdfs:label : MarketPlace Agent and Expert Ontology^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#MarketPlaceAgentExpertOntology">experts:MarketPlaceAgentExpertOntology</a>
    /// </summary>
    let MarketPlaceAgentExpertOntology =
        _prefixId.prefix "MarketPlaceAgentExpertOntology"

    /// <summary>
    ///   <para>rdfs:comment : A knowledge-providing juridical entity that possesses a certain expertise, and may or may not have something to do with Experts^^xsd:string</para>
    ///   <para>skos:prefLabel : Knowledge-providing Organization</para>
    ///   <para>rdfs:label : Knowledge-providing Organization^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#Organization">experts:Organization</a>
    /// </summary>
    let Organization = _prefixId.prefix "Organization"
    /// <summary>
    ///   <para>rdfs:comment : It is meant to model the details of the company, institution, organization an expert may be working at/with.^^xsd:string</para>
    ///   <para>skos:prefLabel : Organizational Detail</para>
    ///   <para>rdfs:label : Organizational Detail^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#OrganizationalDetail">experts:OrganizationalDetail</a>
    /// </summary>
    let OrganizationalDetail = _prefixId.prefix "OrganizationalDetail"
    /// <summary>
    ///   <para>rdfs:comment : It models the personal details (name, address, contacts, etc.) of a human expert.^^xsd:string</para>
    ///   <para>skos:prefLabel : Personal Detail</para>
    ///   <para>rdfs:label : Personal Detail^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#PersonalDetail">experts:PersonalDetail</a>
    /// </summary>
    let PersonalDetail = _prefixId.prefix "PersonalDetail"
    let PierluigiDelNostro = _prefixId.prefix "PierluigiDelNostro"
    /// <summary>
    ///   <para>rdfs:comment : It is meant to encompass the professional details of a human expert, e.g. title, role, qualifications, languages spoken, current or desired daily rate for hiring and its corresponding remuneration, etc.^^xsd:string</para>
    ///   <para>skos:prefLabel : Professional Detail</para>
    ///   <para>rdfs:label : Professional Detail^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#ProfessionalDetail">experts:ProfessionalDetail</a>
    /// </summary>
    let ProfessionalDetail = _prefixId.prefix "ProfessionalDetail"
    /// <summary>
    ///   <para>rdfs:comment : It includes the details of a human expert's profile.^^xsd:string</para>
    ///   <para>skos:prefLabel : Profile</para>
    ///   <para>rdfs:label : Profile^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#Profile">experts:Profile</a>
    /// </summary>
    let Profile = _prefixId.prefix "Profile"
    let Profile1 = _prefixId.prefix "Profile1"
    let Profile2 = _prefixId.prefix "Profile2"
    let Profile3 = _prefixId.prefix "Profile3"
    /// <summary>
    ///   <para>rdfs:comment : It models the remuneration value and currency of the daily rate requested by a human expert, as well as the one associated with an existing contract a human expert may be under.^^xsd:string</para>
    ///   <para>skos:prefLabel : Remuneration</para>
    ///   <para>rdfs:label : Remuneration^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#Remuneration">experts:Remuneration</a>
    /// </summary>
    let Remuneration = _prefixId.prefix "Remuneration"
    /// <summary>
    ///   <para>rdfs:comment : A knowledge-providing group of people.^^xsd:string</para>
    ///   <para>skos:prefLabel : Knowledge-providing Team</para>
    ///   <para>rdfs:label : Knowledge-providing Team^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#Team">experts:Team</a>
    /// </summary>
    let Team = _prefixId.prefix "Team"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : address^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#address">experts:address</a>
    /// </summary>
    let address = _prefixId.prefix "address"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : amountsTo^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#amountsTo">experts:amountsTo</a>
    /// </summary>
    let amountsTo = _prefixId.prefix "amountsTo"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : certificationAuthorityName^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#certificationAuthorityName">experts:certificationAuthorityName</a>
    /// </summary>
    let certificationAuthorityName = _prefixId.prefix "certificationAuthorityName"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : certificationTitle^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#certificationTitle">experts:certificationTitle</a>
    /// </summary>
    let certificationTitle = _prefixId.prefix "certificationTitle"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : contractConstraint^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#contractConstraint">experts:contractConstraint</a>
    /// </summary>
    let contractConstraint = _prefixId.prefix "contractConstraint"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : contractType^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#contractType">experts:contractType</a>
    /// </summary>
    let contractType = _prefixId.prefix "contractType"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : experienceInYears^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#experienceInYears">experts:experienceInYears</a>
    /// </summary>
    let experienceInYears = _prefixId.prefix "experienceInYears"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : expertiseOn^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#expertiseOn">experts:expertiseOn</a>
    /// </summary>
    let expertiseOn = _prefixId.prefix "expertiseOn"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : expirationDate^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#expirationDate">experts:expirationDate</a>
    /// </summary>
    let expirationDate = _prefixId.prefix "expirationDate"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : externalProfileName^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#externalProfileName">experts:externalProfileName</a>
    /// </summary>
    let externalProfileName = _prefixId.prefix "externalProfileName"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : externalProfileUrl^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#externalProfileUrl">experts:externalProfileUrl</a>
    /// </summary>
    let externalProfileUrl = _prefixId.prefix "externalProfileUrl"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : hasCertification^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#hasCertification">experts:hasCertification</a>
    /// </summary>
    let hasCertification = _prefixId.prefix "hasCertification"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : hasExpertise^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#hasExpertise">experts:hasExpertise</a>
    /// </summary>
    let hasExpertise = _prefixId.prefix "hasExpertise"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : hasExternalProfile^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#hasExternalProfile">experts:hasExternalProfile</a>
    /// </summary>
    let hasExternalProfile = _prefixId.prefix "hasExternalProfile"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : hasProfile^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#hasProfile">experts:hasProfile</a>
    /// </summary>
    let hasProfile = _prefixId.prefix "hasProfile"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : hasRemuneration^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#hasRemuneration">experts:hasRemuneration</a>
    /// </summary>
    let hasRemuneration = _prefixId.prefix "hasRemuneration"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : isLocatedAt^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#isLocatedAt">experts:isLocatedAt</a>
    /// </summary>
    let isLocatedAt = _prefixId.prefix "isLocatedAt"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : isUnderContract^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#isUnderContract">experts:isUnderContract</a>
    /// </summary>
    let isUnderContract = _prefixId.prefix "isUnderContract"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : issuedBy^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#issuedBy">experts:issuedBy</a>
    /// </summary>
    let issuedBy = _prefixId.prefix "issuedBy"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : knowsLanguage^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#knowsLanguage">experts:knowsLanguage</a>
    /// </summary>
    let knowsLanguage = _prefixId.prefix "knowsLanguage"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : languageCode^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#languageCode">experts:languageCode</a>
    /// </summary>
    let languageCode = _prefixId.prefix "languageCode"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : languageLevel^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#languageLevel">experts:languageLevel</a>
    /// </summary>
    let languageLevel = _prefixId.prefix "languageLevel"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : languageName^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#languageName">experts:languageName</a>
    /// </summary>
    let languageName = _prefixId.prefix "languageName"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : languageType^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#languageType">experts:languageType</a>
    /// </summary>
    let languageType = _prefixId.prefix "languageType"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : maeoDatatypeProperty^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#maeoDatatypeProperty">experts:maeoDatatypeProperty</a>
    /// </summary>
    let maeoDatatypeProperty = _prefixId.prefix "maeoDatatypeProperty"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : maeoObjectProperty^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#maeoObjectProperty">experts:maeoObjectProperty</a>
    /// </summary>
    let maeoObjectProperty = _prefixId.prefix "maeoObjectProperty"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : profileAddress^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#profileAddress">experts:profileAddress</a>
    /// </summary>
    let profileAddress = _prefixId.prefix "profileAddress"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : profileEmail^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#profileEmail">experts:profileEmail</a>
    /// </summary>
    let profileEmail = _prefixId.prefix "profileEmail"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : profileName^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#profileName">experts:profileName</a>
    /// </summary>
    let profileName = _prefixId.prefix "profileName"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : profileUsername^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#profileUsername">experts:profileUsername</a>
    /// </summary>
    let profileUsername = _prefixId.prefix "profileUsername"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : refersToOrganizationWithExpertise^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#refersToOrganizationWithExpertise">experts:refersToOrganizationWithExpertise</a>
    /// </summary>
    let refersToOrganizationWithExpertise =
        _prefixId.prefix "refersToOrganizationWithExpertise"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : remunerationCurrency^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#remunerationCurrency">experts:remunerationCurrency</a>
    /// </summary>
    let remunerationCurrency = _prefixId.prefix "remunerationCurrency"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : remunerationValue^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#remunerationValue">experts:remunerationValue</a>
    /// </summary>
    let remunerationValue = _prefixId.prefix "remunerationValue"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : requests^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#requests">experts:requests</a>
    /// </summary>
    let requests = _prefixId.prefix "requests"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : worksAt^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#worksAt">experts:worksAt</a>
    /// </summary>
    let worksAt = _prefixId.prefix "worksAt"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : yearsOnMarketPlace^^xsd:string</para>
    ///   <a href="http://w3id.org/emmo-maeo/maeo#yearsOnMarketPlace">experts:yearsOnMarketPlace</a>
    /// </summary>
    let yearsOnMarketPlace = _prefixId.prefix "yearsOnMarketPlace"
