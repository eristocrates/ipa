namespace http.w3id.org.emmo_maeo.maeo.hash

open DoxAletheia.Rdf_Vocabulary

module experts =
    let _namespace_name = "http://w3id.org/emmo-maeo/maeo#"

    /// <summary>
    /// It describes an actual certification a human expert may possess, with datatype properties like certificationTitle and expirationDate.
    /// <see href="http://w3id.org/emmo-maeo/maeo#Certification"></see></summary>
    let Certification =
        Namespaced_IRI.parse _namespace_name "Certification" |> NamespacedName

    /// <summary>
    /// It is meant to describe the details of certifications possessed by a human expert.
    /// <see href="http://w3id.org/emmo-maeo/maeo#CertificationDetail"></see></summary>
    let CertificationDetail =
        Namespaced_IRI.parse _namespace_name "CertificationDetail" |> NamespacedName

    /// <summary>
    /// It models the authority that has issued a certification.
    /// <see href="http://w3id.org/emmo-maeo/maeo#CertificationAuthority"></see></summary>
    let CertificationAuthority =
        Namespaced_IRI.parse _namespace_name "CertificationAuthority" |> NamespacedName

    /// <summary>
    /// It is meant to represent the superclass of all of the objective properties potentially possessed by the entities of the MAEO ontology.
    /// <see href="http://w3id.org/emmo-maeo/maeo#ExpertObjectiveProperty"></see></summary>
    let ExpertObjectiveProperty =
        Namespaced_IRI.parse _namespace_name "ExpertObjectiveProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#Competence"></see>
    /// </summary>
    let Competence = Namespaced_IRI.parse _namespace_name "Competence" |> NamespacedName

    /// <summary>
    /// This is the root class of the MAEO ontology, introduced for providing the ontology itself with a tree-like structure, with all of its other explicitly defined internal classes being subclasses of this class at various hierarchical levels.
    /// <see href="http://w3id.org/emmo-maeo/maeo#MarketPlaceAgentExpertOntology"></see></summary>
    let MarketPlaceAgentExpertOntology =
        Namespaced_IRI.parse _namespace_name "MarketPlaceAgentExpertOntology" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#expertiseOn"></see>
    /// </summary>
    let expertiseOn =
        Namespaced_IRI.parse _namespace_name "expertiseOn" |> NamespacedName

    /// <summary>
    /// It is meant to model the actual contract(s) a given expert may be currently under. It includes datatype properties like contractType and contractConstraint, the latter modeling potential legal or business constraints and limitations a contract may specify with regard to potential consulting and collaboration activities an expert may be allowed to carry out.
    /// <see href="http://w3id.org/emmo-maeo/maeo#Contract"></see></summary>
    let Contract = Namespaced_IRI.parse _namespace_name "Contract" |> NamespacedName

    /// <summary>
    /// It describes the details about the contract a human experts is currently under.
    /// <see href="http://w3id.org/emmo-maeo/maeo#ContractualDetail"></see></summary>
    let ContractualDetail =
        Namespaced_IRI.parse _namespace_name "ContractualDetail" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#DTEN"></see>
    /// </summary>
    let DTEN = Namespaced_IRI.parse _namespace_name "DTEN" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#languageLevel"></see>
    /// </summary>
    let languageLevel =
        Namespaced_IRI.parse _namespace_name "languageLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#languageType"></see>
    /// </summary>
    let languageType =
        Namespaced_IRI.parse _namespace_name "languageType" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#English"></see>
    /// </summary>
    let English = Namespaced_IRI.parse _namespace_name "English" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#knowsLanguage"></see>
    /// </summary>
    let knowsLanguage =
        Namespaced_IRI.parse _namespace_name "knowsLanguage" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#DanieleToti"></see>
    /// </summary>
    let DanieleToti =
        Namespaced_IRI.parse _namespace_name "DanieleToti" |> NamespacedName

    /// <summary>
    /// It models the daily rate a human experts requests.
    /// <see href="http://w3id.org/emmo-maeo/maeo#DailyRate"></see></summary>
    let DailyRate = Namespaced_IRI.parse _namespace_name "DailyRate" |> NamespacedName

    /// <summary>
    /// It is meant to encompass the professional details of a human expert, e.g. title, role, qualifications, languages spoken, current or desired daily rate for hiring and its corresponding remuneration, etc.
    /// <see href="http://w3id.org/emmo-maeo/maeo#ProfessionalDetail"></see></summary>
    let ProfessionalDetail =
        Namespaced_IRI.parse _namespace_name "ProfessionalDetail" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#hasExpertise"></see>
    /// </summary>
    let hasExpertise =
        Namespaced_IRI.parse _namespace_name "hasExpertise" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#Expertise4"></see>
    /// </summary>
    let Expertise4 = Namespaced_IRI.parse _namespace_name "Expertise4" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#hasProfile"></see>
    /// </summary>
    let hasProfile = Namespaced_IRI.parse _namespace_name "hasProfile" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#Profile3"></see>
    /// </summary>
    let Profile3 = Namespaced_IRI.parse _namespace_name "Profile3" |> NamespacedName
    /// <summary>
    /// A knowledge-providing human expert that possesses a certain expertise and whose information can be stored and accessed within the MarketPlace application. It sports datatype properties like experienceInYears and yearsOnMarketPlace, and it is the domain of several object properties.
    /// <see href="http://w3id.org/emmo-maeo/maeo#Expert"></see></summary>
    let Expert = Namespaced_IRI.parse _namespace_name "Expert" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#languageCode"></see>
    /// </summary>
    let languageCode =
        Namespaced_IRI.parse _namespace_name "languageCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#languageName"></see>
    /// </summary>
    let languageName =
        Namespaced_IRI.parse _namespace_name "languageName" |> NamespacedName

    /// <summary>
    /// It describes a language known by a human expert. By reification (via the rdf:Statement construct), the datatype properties languageType and languageLevel are associated with a 'Expert knowsLanguage Language' triple.
    /// <see href="http://w3id.org/emmo-maeo/maeo#Language"></see></summary>
    let Language = Namespaced_IRI.parse _namespace_name "Language" |> NamespacedName

    /// <summary>
    /// It models a generic provider of knowledge that possesses a certain expertise.
    /// <see href="http://w3id.org/emmo-maeo/maeo#KnowledgeProvider"></see></summary>
    let KnowledgeProvider =
        Namespaced_IRI.parse _namespace_name "KnowledgeProvider" |> NamespacedName

    /// <summary>
    /// It models the organization an expert may be working at/with, distinguishing it from a knowledge-providing organization. An instance of the former may also be the same organization as an instance of the latter; in order to model such a case, the object property refersToOrganizationWithExpertise (domain: ExpertOrganization, range: Organization) has been introduced for connecting the two.
    /// <see href="http://w3id.org/emmo-maeo/maeo#ExpertOrganization"></see></summary>
    let ExpertOrganization =
        Namespaced_IRI.parse _namespace_name "ExpertOrganization" |> NamespacedName

    /// <summary>
    /// It is meant to model the details of the company, institution, organization an expert may be working at/with.
    /// <see href="http://w3id.org/emmo-maeo/maeo#OrganizationalDetail"></see></summary>
    let OrganizationalDetail =
        Namespaced_IRI.parse _namespace_name "OrganizationalDetail" |> NamespacedName

    /// <summary>
    /// It is meant to represent the superclass of subjective properties that may be possessed by entities modeled in the MAEO ontology.
    /// <see href="http://w3id.org/emmo-maeo/maeo#ExpertSubjectiveProperty"></see></summary>
    let ExpertSubjectiveProperty =
        Namespaced_IRI.parse _namespace_name "ExpertSubjectiveProperty" |> NamespacedName

    /// <summary>
    /// It represents the expertise possessed by a generic knowledge provider, by which users of the MarketPlace application can look for experts and such (and vice versa).
    /// <see href="http://w3id.org/emmo-maeo/maeo#Expertise"></see></summary>
    let Expertise = Namespaced_IRI.parse _namespace_name "Expertise" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#Expertise1"></see>
    /// </summary>
    let Expertise1 = Namespaced_IRI.parse _namespace_name "Expertise1" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#Expertise2"></see>
    /// </summary>
    let Expertise2 = Namespaced_IRI.parse _namespace_name "Expertise2" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#Expertise3"></see>
    /// </summary>
    let Expertise3 = Namespaced_IRI.parse _namespace_name "Expertise3" |> NamespacedName

    /// <summary>
    /// It represents a connection with an external profile for a given experts, e.g. a social network profile on LinkedIn, Facebook, etc.
    /// <see href="http://w3id.org/emmo-maeo/maeo#ExternalProfile"></see></summary>
    let ExternalProfile =
        Namespaced_IRI.parse _namespace_name "ExternalProfile" |> NamespacedName

    /// <summary>
    /// It models the personal details (name, address, contacts, etc.) of a human expert.
    /// <see href="http://w3id.org/emmo-maeo/maeo#PersonalDetail"></see></summary>
    let PersonalDetail =
        Namespaced_IRI.parse _namespace_name "PersonalDetail" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#GerhardGoldbeck"></see>
    /// </summary>
    let GerhardGoldbeck =
        Namespaced_IRI.parse _namespace_name "GerhardGoldbeck" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#Profile2"></see>
    /// </summary>
    let Profile2 = Namespaced_IRI.parse _namespace_name "Profile2" |> NamespacedName

    /// <summary>
    /// It models a generic Agent in the MarketPlace, i.e. any entity (Knowledge Seeker, Knowledge Provider) that can act on the MarketPlace
    /// <see href="http://w3id.org/emmo-maeo/maeo#MarketPlaceAgent"></see></summary>
    let MarketPlaceAgent =
        Namespaced_IRI.parse _namespace_name "MarketPlaceAgent" |> NamespacedName

    /// <summary>
    /// It models a generic seeker of knowledge as a user of the MarketPlace application.
    /// <see href="http://w3id.org/emmo-maeo/maeo#KnowledgeSeeker"></see></summary>
    let KnowledgeSeeker =
        Namespaced_IRI.parse _namespace_name "KnowledgeSeeker" |> NamespacedName

    /// <summary>
    /// a knowledge-providing laboratory.
    /// <see href="http://w3id.org/emmo-maeo/maeo#Lab"></see></summary>
    let Lab = Namespaced_IRI.parse _namespace_name "Lab" |> NamespacedName
    /// <summary>
    /// It describes the physical address of an organization.
    /// <see href="http://w3id.org/emmo-maeo/maeo#Location"></see></summary>
    let Location = Namespaced_IRI.parse _namespace_name "Location" |> NamespacedName

    /// <summary>
    /// A knowledge-providing juridical entity that possesses a certain expertise, and may or may not have something to do with Experts
    /// <see href="http://w3id.org/emmo-maeo/maeo#Organization"></see></summary>
    let Organization =
        Namespaced_IRI.parse _namespace_name "Organization" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#PierluigiDelNostro"></see>
    /// </summary>
    let PierluigiDelNostro =
        Namespaced_IRI.parse _namespace_name "PierluigiDelNostro" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#Profile1"></see>
    /// </summary>
    let Profile1 = Namespaced_IRI.parse _namespace_name "Profile1" |> NamespacedName
    /// <summary>
    /// It includes the details of a human expert's profile.
    /// <see href="http://w3id.org/emmo-maeo/maeo#Profile"></see></summary>
    let Profile = Namespaced_IRI.parse _namespace_name "Profile" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#profileName"></see>
    /// </summary>
    let profileName =
        Namespaced_IRI.parse _namespace_name "profileName" |> NamespacedName

    /// <summary>
    /// It models the remuneration value and currency of the daily rate requested by a human expert, as well as the one associated with an existing contract a human expert may be under.
    /// <see href="http://w3id.org/emmo-maeo/maeo#Remuneration"></see></summary>
    let Remuneration =
        Namespaced_IRI.parse _namespace_name "Remuneration" |> NamespacedName

    /// <summary>
    /// A knowledge-providing group of people.
    /// <see href="http://w3id.org/emmo-maeo/maeo#Team"></see></summary>
    let Team = Namespaced_IRI.parse _namespace_name "Team" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#address"></see>
    /// </summary>
    let address = Namespaced_IRI.parse _namespace_name "address" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#maeoDatatypeProperty"></see>
    /// </summary>
    let maeoDatatypeProperty =
        Namespaced_IRI.parse _namespace_name "maeoDatatypeProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#amountsTo"></see>
    /// </summary>
    let amountsTo = Namespaced_IRI.parse _namespace_name "amountsTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#maeoObjectProperty"></see>
    /// </summary>
    let maeoObjectProperty =
        Namespaced_IRI.parse _namespace_name "maeoObjectProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#certificationAuthorityName"></see>
    /// </summary>
    let certificationAuthorityName =
        Namespaced_IRI.parse _namespace_name "certificationAuthorityName" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#certificationTitle"></see>
    /// </summary>
    let certificationTitle =
        Namespaced_IRI.parse _namespace_name "certificationTitle" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#contractConstraint"></see>
    /// </summary>
    let contractConstraint =
        Namespaced_IRI.parse _namespace_name "contractConstraint" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#contractType"></see>
    /// </summary>
    let contractType =
        Namespaced_IRI.parse _namespace_name "contractType" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#experienceInYears"></see>
    /// </summary>
    let experienceInYears =
        Namespaced_IRI.parse _namespace_name "experienceInYears" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#expirationDate"></see>
    /// </summary>
    let expirationDate =
        Namespaced_IRI.parse _namespace_name "expirationDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#externalProfileName"></see>
    /// </summary>
    let externalProfileName =
        Namespaced_IRI.parse _namespace_name "externalProfileName" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#externalProfileUrl"></see>
    /// </summary>
    let externalProfileUrl =
        Namespaced_IRI.parse _namespace_name "externalProfileUrl" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#hasCertification"></see>
    /// </summary>
    let hasCertification =
        Namespaced_IRI.parse _namespace_name "hasCertification" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#hasExternalProfile"></see>
    /// </summary>
    let hasExternalProfile =
        Namespaced_IRI.parse _namespace_name "hasExternalProfile" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#hasRemuneration"></see>
    /// </summary>
    let hasRemuneration =
        Namespaced_IRI.parse _namespace_name "hasRemuneration" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#isLocatedAt"></see>
    /// </summary>
    let isLocatedAt =
        Namespaced_IRI.parse _namespace_name "isLocatedAt" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#isUnderContract"></see>
    /// </summary>
    let isUnderContract =
        Namespaced_IRI.parse _namespace_name "isUnderContract" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#issuedBy"></see>
    /// </summary>
    let issuedBy = Namespaced_IRI.parse _namespace_name "issuedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#profileAddress"></see>
    /// </summary>
    let profileAddress =
        Namespaced_IRI.parse _namespace_name "profileAddress" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#profileEmail"></see>
    /// </summary>
    let profileEmail =
        Namespaced_IRI.parse _namespace_name "profileEmail" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#profileUsername"></see>
    /// </summary>
    let profileUsername =
        Namespaced_IRI.parse _namespace_name "profileUsername" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#refersToOrganizationWithExpertise"></see>
    /// </summary>
    let refersToOrganizationWithExpertise =
        Namespaced_IRI.parse _namespace_name "refersToOrganizationWithExpertise" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#remunerationCurrency"></see>
    /// </summary>
    let remunerationCurrency =
        Namespaced_IRI.parse _namespace_name "remunerationCurrency" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#remunerationValue"></see>
    /// </summary>
    let remunerationValue =
        Namespaced_IRI.parse _namespace_name "remunerationValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#requests"></see>
    /// </summary>
    let requests = Namespaced_IRI.parse _namespace_name "requests" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#worksAt"></see>
    /// </summary>
    let worksAt = Namespaced_IRI.parse _namespace_name "worksAt" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/emmo-maeo/maeo#yearsOnMarketPlace"></see>
    /// </summary>
    let yearsOnMarketPlace =
        Namespaced_IRI.parse _namespace_name "yearsOnMarketPlace" |> NamespacedName
