namespace http.w3id.org.emmo_maeo.maeo.hash

open DoxAletheia

module experts =
    let _namespace_name = "http://w3id.org/emmo-maeo/maeo#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// It describes an actual certification a human expert may possess, with datatype properties like certificationTitle and expirationDate.
    /// <see href="http://w3id.org/emmo-maeo/maeo#Certification"></see></summary>
    let Certification = _prefix "Certification"
    /// <summary>
    /// It is meant to describe the details of certifications possessed by a human expert.
    /// <see href="http://w3id.org/emmo-maeo/maeo#CertificationDetail"></see></summary>
    let CertificationDetail = _prefix "CertificationDetail"
    /// <summary>
    /// It models the authority that has issued a certification.
    /// <see href="http://w3id.org/emmo-maeo/maeo#CertificationAuthority"></see></summary>
    let CertificationAuthority = _prefix "CertificationAuthority"
    /// <summary>
    /// It is meant to represent the superclass of all of the objective properties potentially possessed by the entities of the MAEO ontology.
    /// <see href="http://w3id.org/emmo-maeo/maeo#ExpertObjectiveProperty"></see></summary>
    let ExpertObjectiveProperty = _prefix "ExpertObjectiveProperty"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#Competence"></see>
    /// </summary>
    let Competence = _prefix "Competence"
    /// <summary>
    /// This is the root class of the MAEO ontology, introduced for providing the ontology itself with a tree-like structure, with all of its other explicitly defined internal classes being subclasses of this class at various hierarchical levels.
    /// <see href="http://w3id.org/emmo-maeo/maeo#MarketPlaceAgentExpertOntology"></see></summary>
    let MarketPlaceAgentExpertOntology = _prefix "MarketPlaceAgentExpertOntology"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#expertiseOn"></see>
    /// </summary>
    let expertiseOn = _prefix "expertiseOn"
    /// <summary>
    /// It is meant to model the actual contract(s) a given expert may be currently under. It includes datatype properties like contractType and contractConstraint, the latter modeling potential legal or business constraints and limitations a contract may specify with regard to potential consulting and collaboration activities an expert may be allowed to carry out.
    /// <see href="http://w3id.org/emmo-maeo/maeo#Contract"></see></summary>
    let Contract = _prefix "Contract"
    /// <summary>
    /// It describes the details about the contract a human experts is currently under.
    /// <see href="http://w3id.org/emmo-maeo/maeo#ContractualDetail"></see></summary>
    let ContractualDetail = _prefix "ContractualDetail"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#DTEN"></see>
    /// </summary>
    let DTEN = _prefix "DTEN"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#languageLevel"></see>
    /// </summary>
    let languageLevel = _prefix "languageLevel"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#languageType"></see>
    /// </summary>
    let languageType = _prefix "languageType"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#English"></see>
    /// </summary>
    let English = _prefix "English"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#knowsLanguage"></see>
    /// </summary>
    let knowsLanguage = _prefix "knowsLanguage"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#DanieleToti"></see>
    /// </summary>
    let DanieleToti = _prefix "DanieleToti"
    /// <summary>
    /// It models the daily rate a human experts requests.
    /// <see href="http://w3id.org/emmo-maeo/maeo#DailyRate"></see></summary>
    let DailyRate = _prefix "DailyRate"
    /// <summary>
    /// It is meant to encompass the professional details of a human expert, e.g. title, role, qualifications, languages spoken, current or desired daily rate for hiring and its corresponding remuneration, etc.
    /// <see href="http://w3id.org/emmo-maeo/maeo#ProfessionalDetail"></see></summary>
    let ProfessionalDetail = _prefix "ProfessionalDetail"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#hasExpertise"></see>
    /// </summary>
    let hasExpertise = _prefix "hasExpertise"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#Expertise4"></see>
    /// </summary>
    let Expertise4 = _prefix "Expertise4"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#hasProfile"></see>
    /// </summary>
    let hasProfile = _prefix "hasProfile"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#Profile3"></see>
    /// </summary>
    let Profile3 = _prefix "Profile3"
    /// <summary>
    /// A knowledge-providing human expert that possesses a certain expertise and whose information can be stored and accessed within the MarketPlace application. It sports datatype properties like experienceInYears and yearsOnMarketPlace, and it is the domain of several object properties.
    /// <see href="http://w3id.org/emmo-maeo/maeo#Expert"></see></summary>
    let Expert = _prefix "Expert"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#languageCode"></see>
    /// </summary>
    let languageCode = _prefix "languageCode"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#languageName"></see>
    /// </summary>
    let languageName = _prefix "languageName"
    /// <summary>
    /// It describes a language known by a human expert. By reification (via the rdf:Statement construct), the datatype properties languageType and languageLevel are associated with a 'Expert knowsLanguage Language' triple.
    /// <see href="http://w3id.org/emmo-maeo/maeo#Language"></see></summary>
    let Language = _prefix "Language"
    /// <summary>
    /// It models a generic provider of knowledge that possesses a certain expertise.
    /// <see href="http://w3id.org/emmo-maeo/maeo#KnowledgeProvider"></see></summary>
    let KnowledgeProvider = _prefix "KnowledgeProvider"
    /// <summary>
    /// It models the organization an expert may be working at/with, distinguishing it from a knowledge-providing organization. An instance of the former may also be the same organization as an instance of the latter; in order to model such a case, the object property refersToOrganizationWithExpertise (domain: ExpertOrganization, range: Organization) has been introduced for connecting the two.
    /// <see href="http://w3id.org/emmo-maeo/maeo#ExpertOrganization"></see></summary>
    let ExpertOrganization = _prefix "ExpertOrganization"
    /// <summary>
    /// It is meant to model the details of the company, institution, organization an expert may be working at/with.
    /// <see href="http://w3id.org/emmo-maeo/maeo#OrganizationalDetail"></see></summary>
    let OrganizationalDetail = _prefix "OrganizationalDetail"
    /// <summary>
    /// It is meant to represent the superclass of subjective properties that may be possessed by entities modeled in the MAEO ontology.
    /// <see href="http://w3id.org/emmo-maeo/maeo#ExpertSubjectiveProperty"></see></summary>
    let ExpertSubjectiveProperty = _prefix "ExpertSubjectiveProperty"
    /// <summary>
    /// It represents the expertise possessed by a generic knowledge provider, by which users of the MarketPlace application can look for experts and such (and vice versa).
    /// <see href="http://w3id.org/emmo-maeo/maeo#Expertise"></see></summary>
    let Expertise = _prefix "Expertise"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#Expertise1"></see>
    /// </summary>
    let Expertise1 = _prefix "Expertise1"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#Expertise2"></see>
    /// </summary>
    let Expertise2 = _prefix "Expertise2"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#Expertise3"></see>
    /// </summary>
    let Expertise3 = _prefix "Expertise3"
    /// <summary>
    /// It represents a connection with an external profile for a given experts, e.g. a social network profile on LinkedIn, Facebook, etc.
    /// <see href="http://w3id.org/emmo-maeo/maeo#ExternalProfile"></see></summary>
    let ExternalProfile = _prefix "ExternalProfile"
    /// <summary>
    /// It models the personal details (name, address, contacts, etc.) of a human expert.
    /// <see href="http://w3id.org/emmo-maeo/maeo#PersonalDetail"></see></summary>
    let PersonalDetail = _prefix "PersonalDetail"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#GerhardGoldbeck"></see>
    /// </summary>
    let GerhardGoldbeck = _prefix "GerhardGoldbeck"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#Profile2"></see>
    /// </summary>
    let Profile2 = _prefix "Profile2"
    /// <summary>
    /// It models a generic Agent in the MarketPlace, i.e. any entity (Knowledge Seeker, Knowledge Provider) that can act on the MarketPlace
    /// <see href="http://w3id.org/emmo-maeo/maeo#MarketPlaceAgent"></see></summary>
    let MarketPlaceAgent = _prefix "MarketPlaceAgent"
    /// <summary>
    /// It models a generic seeker of knowledge as a user of the MarketPlace application.
    /// <see href="http://w3id.org/emmo-maeo/maeo#KnowledgeSeeker"></see></summary>
    let KnowledgeSeeker = _prefix "KnowledgeSeeker"
    /// <summary>
    /// a knowledge-providing laboratory.
    /// <see href="http://w3id.org/emmo-maeo/maeo#Lab"></see></summary>
    let Lab = _prefix "Lab"
    /// <summary>
    /// It describes the physical address of an organization.
    /// <see href="http://w3id.org/emmo-maeo/maeo#Location"></see></summary>
    let Location = _prefix "Location"
    /// <summary>
    /// A knowledge-providing juridical entity that possesses a certain expertise, and may or may not have something to do with Experts
    /// <see href="http://w3id.org/emmo-maeo/maeo#Organization"></see></summary>
    let Organization = _prefix "Organization"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#PierluigiDelNostro"></see>
    /// </summary>
    let PierluigiDelNostro = _prefix "PierluigiDelNostro"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#Profile1"></see>
    /// </summary>
    let Profile1 = _prefix "Profile1"
    /// <summary>
    /// It includes the details of a human expert's profile.
    /// <see href="http://w3id.org/emmo-maeo/maeo#Profile"></see></summary>
    let Profile = _prefix "Profile"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#profileName"></see>
    /// </summary>
    let profileName = _prefix "profileName"
    /// <summary>
    /// It models the remuneration value and currency of the daily rate requested by a human expert, as well as the one associated with an existing contract a human expert may be under.
    /// <see href="http://w3id.org/emmo-maeo/maeo#Remuneration"></see></summary>
    let Remuneration = _prefix "Remuneration"
    /// <summary>
    /// A knowledge-providing group of people.
    /// <see href="http://w3id.org/emmo-maeo/maeo#Team"></see></summary>
    let Team = _prefix "Team"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#address"></see>
    /// </summary>
    let address = _prefix "address"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#maeoDatatypeProperty"></see>
    /// </summary>
    let maeoDatatypeProperty = _prefix "maeoDatatypeProperty"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#amountsTo"></see>
    /// </summary>
    let amountsTo = _prefix "amountsTo"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#maeoObjectProperty"></see>
    /// </summary>
    let maeoObjectProperty = _prefix "maeoObjectProperty"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#certificationAuthorityName"></see>
    /// </summary>
    let certificationAuthorityName = _prefix "certificationAuthorityName"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#certificationTitle"></see>
    /// </summary>
    let certificationTitle = _prefix "certificationTitle"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#contractConstraint"></see>
    /// </summary>
    let contractConstraint = _prefix "contractConstraint"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#contractType"></see>
    /// </summary>
    let contractType = _prefix "contractType"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#experienceInYears"></see>
    /// </summary>
    let experienceInYears = _prefix "experienceInYears"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#expirationDate"></see>
    /// </summary>
    let expirationDate = _prefix "expirationDate"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#externalProfileName"></see>
    /// </summary>
    let externalProfileName = _prefix "externalProfileName"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#externalProfileUrl"></see>
    /// </summary>
    let externalProfileUrl = _prefix "externalProfileUrl"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#hasCertification"></see>
    /// </summary>
    let hasCertification = _prefix "hasCertification"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#hasExternalProfile"></see>
    /// </summary>
    let hasExternalProfile = _prefix "hasExternalProfile"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#hasRemuneration"></see>
    /// </summary>
    let hasRemuneration = _prefix "hasRemuneration"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#isLocatedAt"></see>
    /// </summary>
    let isLocatedAt = _prefix "isLocatedAt"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#isUnderContract"></see>
    /// </summary>
    let isUnderContract = _prefix "isUnderContract"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#issuedBy"></see>
    /// </summary>
    let issuedBy = _prefix "issuedBy"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#profileAddress"></see>
    /// </summary>
    let profileAddress = _prefix "profileAddress"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#profileEmail"></see>
    /// </summary>
    let profileEmail = _prefix "profileEmail"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#profileUsername"></see>
    /// </summary>
    let profileUsername = _prefix "profileUsername"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#refersToOrganizationWithExpertise"></see>
    /// </summary>
    let refersToOrganizationWithExpertise = _prefix "refersToOrganizationWithExpertise"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#remunerationCurrency"></see>
    /// </summary>
    let remunerationCurrency = _prefix "remunerationCurrency"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#remunerationValue"></see>
    /// </summary>
    let remunerationValue = _prefix "remunerationValue"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#requests"></see>
    /// </summary>
    let requests = _prefix "requests"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#worksAt"></see>
    /// </summary>
    let worksAt = _prefix "worksAt"
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#yearsOnMarketPlace"></see>
    /// </summary>
    let yearsOnMarketPlace = _prefix "yearsOnMarketPlace"
