namespace http.w3id.org.emmo_maeo.maeo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module maeo =
    let _namespace_iri = Namespace_Iri maeo |> NamespaceIRI
    /// <summary>
    ///   <para>maeo:Certification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It describes an actual certification a human expert may possess, with datatype properties like certificationTitle and expirationDate."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Certification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#Certification">http://w3id.org/emmo-maeo/maeo#Certification</seealso>
    let Certification = Prefixed_Name(maeo, "Certification") |> PrefixedName

    /// <summary>
    ///   <para>maeo:CertificationAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It models the authority that has issued a certification."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Certification Authority"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#CertificationAuthority">http://w3id.org/emmo-maeo/maeo#CertificationAuthority</seealso>
    let CertificationAuthority =
        Prefixed_Name(maeo, "CertificationAuthority") |> PrefixedName

    /// <summary>
    ///   <para>maeo:CertificationDetail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is meant to describe the details of certifications possessed by a human expert."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Certification Detail"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#CertificationDetail">http://w3id.org/emmo-maeo/maeo#CertificationDetail</seealso>
    let CertificationDetail = Prefixed_Name(maeo, "CertificationDetail") |> PrefixedName
    /// <summary>
    ///   <para>maeo:Competence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Competence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#Competence">http://w3id.org/emmo-maeo/maeo#Competence</seealso>
    let Competence = Prefixed_Name(maeo, "Competence") |> PrefixedName
    /// <summary>
    ///   <para>maeo:Contract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is meant to model the actual contract(s) a given expert may be currently under. It includes datatype properties like contractType and contractConstraint, the latter modeling potential legal or business constraints and limitations a contract may specify with regard to potential consulting and collaboration activities an expert may be allowed to carry out."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Contract"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#Contract">http://w3id.org/emmo-maeo/maeo#Contract</seealso>
    let Contract = Prefixed_Name(maeo, "Contract") |> PrefixedName
    /// <summary>
    ///   <para>maeo:ContractualDetail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It describes the details about the contract a human experts is currently under."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Contractual Detail"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#ContractualDetail">http://w3id.org/emmo-maeo/maeo#ContractualDetail</seealso>
    let ContractualDetail = Prefixed_Name(maeo, "ContractualDetail") |> PrefixedName
    /// <summary>
    ///   <para>maeo:DTEN</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Statement</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#DTEN">http://w3id.org/emmo-maeo/maeo#DTEN</seealso>
    let DTEN = Prefixed_Name(maeo, "DTEN") |> PrefixedName
    /// <summary>
    ///   <para>maeo:DailyRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It models the daily rate a human experts requests."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Daily Rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#DailyRate">http://w3id.org/emmo-maeo/maeo#DailyRate</seealso>
    let DailyRate = Prefixed_Name(maeo, "DailyRate") |> PrefixedName
    /// <summary>
    ///   <para>maeo:DanieleToti</para>
    /// </summary>
    /// <remarks>
    ///   <para>maeo:Expert</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#DanieleToti">http://w3id.org/emmo-maeo/maeo#DanieleToti</seealso>
    let DanieleToti = Prefixed_Name(maeo, "DanieleToti") |> PrefixedName
    /// <summary>
    ///   <para>maeo:English</para>
    /// </summary>
    /// <remarks>
    ///   <para>maeo:Language</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#English">http://w3id.org/emmo-maeo/maeo#English</seealso>
    let English = Prefixed_Name(maeo, "English") |> PrefixedName
    /// <summary>
    ///   <para>maeo:Expert</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A knowledge-providing human expert that possesses a certain expertise and whose information can be stored and accessed within the MarketPlace application. It sports datatype properties like experienceInYears and yearsOnMarketPlace, and it is the domain of several object properties."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Expert"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#Expert">http://w3id.org/emmo-maeo/maeo#Expert</seealso>
    let Expert = Prefixed_Name(maeo, "Expert") |> PrefixedName

    /// <summary>
    ///   <para>maeo:ExpertObjectiveProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is meant to represent the superclass of all of the objective properties potentially possessed by the entities of the MAEO ontology."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Expert Objective Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#ExpertObjectiveProperty">http://w3id.org/emmo-maeo/maeo#ExpertObjectiveProperty</seealso>
    let ExpertObjectiveProperty =
        Prefixed_Name(maeo, "ExpertObjectiveProperty") |> PrefixedName

    /// <summary>
    ///   <para>maeo:ExpertOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It models the organization an expert may be working at/with, distinguishing it from a knowledge-providing organization. An instance of the former may also be the same organization as an instance of the latter; in order to model such a case, the object property refersToOrganizationWithExpertise (domain: ExpertOrganization, range: Organization) has been introduced for connecting the two."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Expert Organization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#ExpertOrganization">http://w3id.org/emmo-maeo/maeo#ExpertOrganization</seealso>
    let ExpertOrganization = Prefixed_Name(maeo, "ExpertOrganization") |> PrefixedName

    /// <summary>
    ///   <para>maeo:ExpertSubjectiveProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is meant to represent the superclass of subjective properties that may be possessed by entities modeled in the MAEO ontology."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Expert Subjective Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#ExpertSubjectiveProperty">http://w3id.org/emmo-maeo/maeo#ExpertSubjectiveProperty</seealso>
    let ExpertSubjectiveProperty =
        Prefixed_Name(maeo, "ExpertSubjectiveProperty") |> PrefixedName

    /// <summary>
    ///   <para>maeo:Expertise</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It represents the expertise possessed by a generic knowledge provider, by which users of the MarketPlace application can look for experts and such (and vice versa)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Expertise"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#Expertise">http://w3id.org/emmo-maeo/maeo#Expertise</seealso>
    let Expertise = Prefixed_Name(maeo, "Expertise") |> PrefixedName
    /// <summary>
    ///   <para>maeo:Expertise1</para>
    /// </summary>
    /// <remarks>
    ///   <para>maeo:Expertise</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#Expertise1">http://w3id.org/emmo-maeo/maeo#Expertise1</seealso>
    let Expertise1 = Prefixed_Name(maeo, "Expertise1") |> PrefixedName
    /// <summary>
    ///   <para>maeo:Expertise2</para>
    /// </summary>
    /// <remarks>
    ///   <para>maeo:Expertise</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#Expertise2">http://w3id.org/emmo-maeo/maeo#Expertise2</seealso>
    let Expertise2 = Prefixed_Name(maeo, "Expertise2") |> PrefixedName
    /// <summary>
    ///   <para>maeo:Expertise3</para>
    /// </summary>
    /// <remarks>
    ///   <para>maeo:Expertise</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#Expertise3">http://w3id.org/emmo-maeo/maeo#Expertise3</seealso>
    let Expertise3 = Prefixed_Name(maeo, "Expertise3") |> PrefixedName
    /// <summary>
    ///   <para>maeo:Expertise4</para>
    /// </summary>
    /// <remarks>
    ///   <para>maeo:Expertise</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#Expertise4">http://w3id.org/emmo-maeo/maeo#Expertise4</seealso>
    let Expertise4 = Prefixed_Name(maeo, "Expertise4") |> PrefixedName
    /// <summary>
    ///   <para>maeo:ExternalProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It represents a connection with an external profile for a given experts, e.g. a social network profile on LinkedIn, Facebook, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"External Profile"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#ExternalProfile">http://w3id.org/emmo-maeo/maeo#ExternalProfile</seealso>
    let ExternalProfile = Prefixed_Name(maeo, "ExternalProfile") |> PrefixedName
    /// <summary>
    ///   <para>maeo:GerhardGoldbeck</para>
    /// </summary>
    /// <remarks>
    ///   <para>maeo:Expert</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#GerhardGoldbeck">http://w3id.org/emmo-maeo/maeo#GerhardGoldbeck</seealso>
    let GerhardGoldbeck = Prefixed_Name(maeo, "GerhardGoldbeck") |> PrefixedName
    /// <summary>
    ///   <para>maeo:KnowledgeProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It models a generic provider of knowledge that possesses a certain expertise."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Knowledge Provider"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#KnowledgeProvider">http://w3id.org/emmo-maeo/maeo#KnowledgeProvider</seealso>
    let KnowledgeProvider = Prefixed_Name(maeo, "KnowledgeProvider") |> PrefixedName
    /// <summary>
    ///   <para>maeo:KnowledgeSeeker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It models a generic seeker of knowledge as a user of the MarketPlace application."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Knowledge Seeker"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#KnowledgeSeeker">http://w3id.org/emmo-maeo/maeo#KnowledgeSeeker</seealso>
    let KnowledgeSeeker = Prefixed_Name(maeo, "KnowledgeSeeker") |> PrefixedName
    /// <summary>
    ///   <para>maeo:Lab</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"a knowledge-providing laboratory."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Knowledge-providing Lab"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#Lab">http://w3id.org/emmo-maeo/maeo#Lab</seealso>
    let Lab = Prefixed_Name(maeo, "Lab") |> PrefixedName
    /// <summary>
    ///   <para>maeo:Language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It describes a language known by a human expert. By reification (via the rdf:Statement construct), the datatype properties languageType and languageLevel are associated with a 'Expert knowsLanguage Language' triple."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Language"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#Language">http://w3id.org/emmo-maeo/maeo#Language</seealso>
    let Language = Prefixed_Name(maeo, "Language") |> PrefixedName
    /// <summary>
    ///   <para>maeo:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It describes the physical address of an organization."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#Location">http://w3id.org/emmo-maeo/maeo#Location</seealso>
    let Location = Prefixed_Name(maeo, "Location") |> PrefixedName
    /// <summary>
    ///   <para>maeo:MarketPlaceAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It models a generic Agent in the MarketPlace, i.e. any entity (Knowledge Seeker, Knowledge Provider) that can act on the MarketPlace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MarketPlace Agent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#MarketPlaceAgent">http://w3id.org/emmo-maeo/maeo#MarketPlaceAgent</seealso>
    let MarketPlaceAgent = Prefixed_Name(maeo, "MarketPlaceAgent") |> PrefixedName

    /// <summary>
    ///   <para>maeo:MarketPlaceAgentExpertOntology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This is the root class of the MAEO ontology, introduced for providing the ontology itself with a tree-like structure, with all of its other explicitly defined internal classes being subclasses of this class at various hierarchical levels."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MarketPlace Agent and Expert Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#MarketPlaceAgentExpertOntology">http://w3id.org/emmo-maeo/maeo#MarketPlaceAgentExpertOntology</seealso>
    let MarketPlaceAgentExpertOntology =
        Prefixed_Name(maeo, "MarketPlaceAgentExpertOntology") |> PrefixedName

    /// <summary>
    ///   <para>maeo:Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A knowledge-providing juridical entity that possesses a certain expertise, and may or may not have something to do with Experts"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Knowledge-providing Organization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#Organization">http://w3id.org/emmo-maeo/maeo#Organization</seealso>
    let Organization = Prefixed_Name(maeo, "Organization") |> PrefixedName

    /// <summary>
    ///   <para>maeo:OrganizationalDetail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is meant to model the details of the company, institution, organization an expert may be working at/with."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Organizational Detail"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#OrganizationalDetail">http://w3id.org/emmo-maeo/maeo#OrganizationalDetail</seealso>
    let OrganizationalDetail =
        Prefixed_Name(maeo, "OrganizationalDetail") |> PrefixedName

    /// <summary>
    ///   <para>maeo:PersonalDetail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It models the personal details (name, address, contacts, etc.) of a human expert."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Personal Detail"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#PersonalDetail">http://w3id.org/emmo-maeo/maeo#PersonalDetail</seealso>
    let PersonalDetail = Prefixed_Name(maeo, "PersonalDetail") |> PrefixedName
    /// <summary>
    ///   <para>maeo:PierluigiDelNostro</para>
    /// </summary>
    /// <remarks>
    ///   <para>maeo:Expert</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#PierluigiDelNostro">http://w3id.org/emmo-maeo/maeo#PierluigiDelNostro</seealso>
    let PierluigiDelNostro = Prefixed_Name(maeo, "PierluigiDelNostro") |> PrefixedName
    /// <summary>
    ///   <para>maeo:ProfessionalDetail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is meant to encompass the professional details of a human expert, e.g. title, role, qualifications, languages spoken, current or desired daily rate for hiring and its corresponding remuneration, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Professional Detail"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#ProfessionalDetail">http://w3id.org/emmo-maeo/maeo#ProfessionalDetail</seealso>
    let ProfessionalDetail = Prefixed_Name(maeo, "ProfessionalDetail") |> PrefixedName
    /// <summary>
    ///   <para>maeo:Profile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It includes the details of a human expert's profile."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Profile"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#Profile">http://w3id.org/emmo-maeo/maeo#Profile</seealso>
    let Profile = Prefixed_Name(maeo, "Profile") |> PrefixedName
    /// <summary>
    ///   <para>maeo:Profile1</para>
    /// </summary>
    /// <remarks>
    ///   <para>maeo:Profile</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#Profile1">http://w3id.org/emmo-maeo/maeo#Profile1</seealso>
    let Profile1 = Prefixed_Name(maeo, "Profile1") |> PrefixedName
    /// <summary>
    ///   <para>maeo:Profile2</para>
    /// </summary>
    /// <remarks>
    ///   <para>maeo:Profile</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#Profile2">http://w3id.org/emmo-maeo/maeo#Profile2</seealso>
    let Profile2 = Prefixed_Name(maeo, "Profile2") |> PrefixedName
    /// <summary>
    ///   <para>maeo:Profile3</para>
    /// </summary>
    /// <remarks>
    ///   <para>maeo:Profile</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#Profile3">http://w3id.org/emmo-maeo/maeo#Profile3</seealso>
    let Profile3 = Prefixed_Name(maeo, "Profile3") |> PrefixedName
    /// <summary>
    ///   <para>maeo:Remuneration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It models the remuneration value and currency of the daily rate requested by a human expert, as well as the one associated with an existing contract a human expert may be under."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Remuneration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#Remuneration">http://w3id.org/emmo-maeo/maeo#Remuneration</seealso>
    let Remuneration = Prefixed_Name(maeo, "Remuneration") |> PrefixedName
    /// <summary>
    ///   <para>maeo:Team</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A knowledge-providing group of people."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Knowledge-providing Team"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#Team">http://w3id.org/emmo-maeo/maeo#Team</seealso>
    let Team = Prefixed_Name(maeo, "Team") |> PrefixedName
    /// <summary>
    ///   <para>maeo:address</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#address">http://w3id.org/emmo-maeo/maeo#address</seealso>
    let address = Prefixed_Name(maeo, "address") |> PrefixedName
    /// <summary>
    ///   <para>maeo:amountsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"amountsTo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#amountsTo">http://w3id.org/emmo-maeo/maeo#amountsTo</seealso>
    let amountsTo = Prefixed_Name(maeo, "amountsTo") |> PrefixedName

    /// <summary>
    ///   <para>maeo:certificationAuthorityName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"certificationAuthorityName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#certificationAuthorityName">http://w3id.org/emmo-maeo/maeo#certificationAuthorityName</seealso>
    let certificationAuthorityName =
        Prefixed_Name(maeo, "certificationAuthorityName") |> PrefixedName

    /// <summary>
    ///   <para>maeo:certificationTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"certificationTitle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#certificationTitle">http://w3id.org/emmo-maeo/maeo#certificationTitle</seealso>
    let certificationTitle = Prefixed_Name(maeo, "certificationTitle") |> PrefixedName
    /// <summary>
    ///   <para>maeo:contractConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"contractConstraint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#contractConstraint">http://w3id.org/emmo-maeo/maeo#contractConstraint</seealso>
    let contractConstraint = Prefixed_Name(maeo, "contractConstraint") |> PrefixedName
    /// <summary>
    ///   <para>maeo:contractType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"contractType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#contractType">http://w3id.org/emmo-maeo/maeo#contractType</seealso>
    let contractType = Prefixed_Name(maeo, "contractType") |> PrefixedName
    /// <summary>
    ///   <para>maeo:experienceInYears</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"experienceInYears"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#experienceInYears">http://w3id.org/emmo-maeo/maeo#experienceInYears</seealso>
    let experienceInYears = Prefixed_Name(maeo, "experienceInYears") |> PrefixedName
    /// <summary>
    ///   <para>maeo:expertiseOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"expertiseOn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#expertiseOn">http://w3id.org/emmo-maeo/maeo#expertiseOn</seealso>
    let expertiseOn = Prefixed_Name(maeo, "expertiseOn") |> PrefixedName
    /// <summary>
    ///   <para>maeo:expirationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"expirationDate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#expirationDate">http://w3id.org/emmo-maeo/maeo#expirationDate</seealso>
    let expirationDate = Prefixed_Name(maeo, "expirationDate") |> PrefixedName
    /// <summary>
    ///   <para>maeo:externalProfileName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"externalProfileName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#externalProfileName">http://w3id.org/emmo-maeo/maeo#externalProfileName</seealso>
    let externalProfileName = Prefixed_Name(maeo, "externalProfileName") |> PrefixedName
    /// <summary>
    ///   <para>maeo:externalProfileUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"externalProfileUrl"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#externalProfileUrl">http://w3id.org/emmo-maeo/maeo#externalProfileUrl</seealso>
    let externalProfileUrl = Prefixed_Name(maeo, "externalProfileUrl") |> PrefixedName
    /// <summary>
    ///   <para>maeo:hasCertification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasCertification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#hasCertification">http://w3id.org/emmo-maeo/maeo#hasCertification</seealso>
    let hasCertification = Prefixed_Name(maeo, "hasCertification") |> PrefixedName
    /// <summary>
    ///   <para>maeo:hasExpertise</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasExpertise"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#hasExpertise">http://w3id.org/emmo-maeo/maeo#hasExpertise</seealso>
    let hasExpertise = Prefixed_Name(maeo, "hasExpertise") |> PrefixedName
    /// <summary>
    ///   <para>maeo:hasExternalProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasExternalProfile"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#hasExternalProfile">http://w3id.org/emmo-maeo/maeo#hasExternalProfile</seealso>
    let hasExternalProfile = Prefixed_Name(maeo, "hasExternalProfile") |> PrefixedName
    /// <summary>
    ///   <para>maeo:hasProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasProfile"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#hasProfile">http://w3id.org/emmo-maeo/maeo#hasProfile</seealso>
    let hasProfile = Prefixed_Name(maeo, "hasProfile") |> PrefixedName
    /// <summary>
    ///   <para>maeo:hasRemuneration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasRemuneration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#hasRemuneration">http://w3id.org/emmo-maeo/maeo#hasRemuneration</seealso>
    let hasRemuneration = Prefixed_Name(maeo, "hasRemuneration") |> PrefixedName
    /// <summary>
    ///   <para>maeo:isLocatedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isLocatedAt"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#isLocatedAt">http://w3id.org/emmo-maeo/maeo#isLocatedAt</seealso>
    let isLocatedAt = Prefixed_Name(maeo, "isLocatedAt") |> PrefixedName
    /// <summary>
    ///   <para>maeo:isUnderContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isUnderContract"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#isUnderContract">http://w3id.org/emmo-maeo/maeo#isUnderContract</seealso>
    let isUnderContract = Prefixed_Name(maeo, "isUnderContract") |> PrefixedName
    /// <summary>
    ///   <para>maeo:issuedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"issuedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#issuedBy">http://w3id.org/emmo-maeo/maeo#issuedBy</seealso>
    let issuedBy = Prefixed_Name(maeo, "issuedBy") |> PrefixedName
    /// <summary>
    ///   <para>maeo:knowsLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"knowsLanguage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#knowsLanguage">http://w3id.org/emmo-maeo/maeo#knowsLanguage</seealso>
    let knowsLanguage = Prefixed_Name(maeo, "knowsLanguage") |> PrefixedName
    /// <summary>
    ///   <para>maeo:languageCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"languageCode"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#languageCode">http://w3id.org/emmo-maeo/maeo#languageCode</seealso>
    let languageCode = Prefixed_Name(maeo, "languageCode") |> PrefixedName
    /// <summary>
    ///   <para>maeo:languageLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"languageLevel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#languageLevel">http://w3id.org/emmo-maeo/maeo#languageLevel</seealso>
    let languageLevel = Prefixed_Name(maeo, "languageLevel") |> PrefixedName
    /// <summary>
    ///   <para>maeo:languageName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"languageName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#languageName">http://w3id.org/emmo-maeo/maeo#languageName</seealso>
    let languageName = Prefixed_Name(maeo, "languageName") |> PrefixedName
    /// <summary>
    ///   <para>maeo:languageType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"languageType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#languageType">http://w3id.org/emmo-maeo/maeo#languageType</seealso>
    let languageType = Prefixed_Name(maeo, "languageType") |> PrefixedName

    /// <summary>
    ///   <para>maeo:maeoDatatypeProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"maeoDatatypeProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#maeoDatatypeProperty">http://w3id.org/emmo-maeo/maeo#maeoDatatypeProperty</seealso>
    let maeoDatatypeProperty =
        Prefixed_Name(maeo, "maeoDatatypeProperty") |> PrefixedName

    /// <summary>
    ///   <para>maeo:maeoObjectProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"maeoObjectProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#maeoObjectProperty">http://w3id.org/emmo-maeo/maeo#maeoObjectProperty</seealso>
    let maeoObjectProperty = Prefixed_Name(maeo, "maeoObjectProperty") |> PrefixedName
    /// <summary>
    ///   <para>maeo:profileAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"profileAddress"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#profileAddress">http://w3id.org/emmo-maeo/maeo#profileAddress</seealso>
    let profileAddress = Prefixed_Name(maeo, "profileAddress") |> PrefixedName
    /// <summary>
    ///   <para>maeo:profileEmail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"profileEmail"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#profileEmail">http://w3id.org/emmo-maeo/maeo#profileEmail</seealso>
    let profileEmail = Prefixed_Name(maeo, "profileEmail") |> PrefixedName
    /// <summary>
    ///   <para>maeo:profileName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"profileName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#profileName">http://w3id.org/emmo-maeo/maeo#profileName</seealso>
    let profileName = Prefixed_Name(maeo, "profileName") |> PrefixedName
    /// <summary>
    ///   <para>maeo:profileUsername</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"profileUsername"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#profileUsername">http://w3id.org/emmo-maeo/maeo#profileUsername</seealso>
    let profileUsername = Prefixed_Name(maeo, "profileUsername") |> PrefixedName

    /// <summary>
    ///   <para>maeo:refersToOrganizationWithExpertise</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"refersToOrganizationWithExpertise"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#refersToOrganizationWithExpertise">http://w3id.org/emmo-maeo/maeo#refersToOrganizationWithExpertise</seealso>
    let refersToOrganizationWithExpertise =
        Prefixed_Name(maeo, "refersToOrganizationWithExpertise") |> PrefixedName

    /// <summary>
    ///   <para>maeo:remunerationCurrency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"remunerationCurrency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#remunerationCurrency">http://w3id.org/emmo-maeo/maeo#remunerationCurrency</seealso>
    let remunerationCurrency =
        Prefixed_Name(maeo, "remunerationCurrency") |> PrefixedName

    /// <summary>
    ///   <para>maeo:remunerationValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"remunerationValue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#remunerationValue">http://w3id.org/emmo-maeo/maeo#remunerationValue</seealso>
    let remunerationValue = Prefixed_Name(maeo, "remunerationValue") |> PrefixedName
    /// <summary>
    ///   <para>maeo:requests</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"requests"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#requests">http://w3id.org/emmo-maeo/maeo#requests</seealso>
    let requests = Prefixed_Name(maeo, "requests") |> PrefixedName
    /// <summary>
    ///   <para>maeo:worksAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"worksAt"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#worksAt">http://w3id.org/emmo-maeo/maeo#worksAt</seealso>
    let worksAt = Prefixed_Name(maeo, "worksAt") |> PrefixedName
    /// <summary>
    ///   <para>maeo:yearsOnMarketPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"yearsOnMarketPlace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/emmo-maeo/maeo#yearsOnMarketPlace">http://w3id.org/emmo-maeo/maeo#yearsOnMarketPlace</seealso>
    let yearsOnMarketPlace = Prefixed_Name(maeo, "yearsOnMarketPlace") |> PrefixedName
