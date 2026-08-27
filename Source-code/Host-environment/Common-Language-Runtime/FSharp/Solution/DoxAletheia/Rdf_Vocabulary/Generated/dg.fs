namespace https.w3id.org.dingo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dg =
    let _namespace_iri = Namespace_Iri dg |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:dingo#</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    ///   <para>owl:Ontology</para>
    ///   <para>"The DINGO ontology (Data Integration for Grant Ontology) defines the terms of the DINGO vocabulary and provides a machine readable extensible framework to model data relative to projects, funding, project and funding actors, and, notably, funding policies. It is designed to yield high modeling power and elasticity to cope with the huge variety in funding and project practices, which makes it applicable to many areas where funding is an important aspect: first of all research, but also the arts, cultural conservation, and many others."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dingo#">https://w3id.org/dingo#</seealso>
    let _prefix_iri = Prefixed_Name(dg, "") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#AcademicDegree</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class for academic degrees: college or university diploma."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AcademicDegree"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#AcademicDegree">https://w3id.org/dingo#AcademicDegree</seealso>
    let AcademicDegree = Prefixed_Name(dg, "AcademicDegree") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#AgeCriterion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Specifies that grants are awarded to projects on the basis of age limits."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AgeCriterion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#AgeCriterion">https://w3id.org/dingo#AgeCriterion</seealso>
    let AgeCriterion = Prefixed_Name(dg, "AgeCriterion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#ArchiveOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Institution that holds artifacts and other objects of scientific, artistic, cultural, historical, or other importance."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ArchiveOrganisation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#ArchiveOrganisation">https://w3id.org/dingo#ArchiveOrganisation</seealso>
    let ArchiveOrganisation = Prefixed_Name(dg, "ArchiveOrganisation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#BottomUpCriterion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Specifies that grants are awarded to projects on the basis of the research proposal itself without restriction on theme/subject or research area. The funding body does not specifies beforehand missions, targets nor topics of the research projects that can apply."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"BottomUpCriterion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#BottomUpCriterion">https://w3id.org/dingo#BottomUpCriterion</seealso>
    let BottomUpCriterion = Prefixed_Name(dg, "BottomUpCriterion") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#CareerPurposeCriterion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Specifies that grants are awarded on the basis of career-related goals and applicants must be at a defined career stage (defined academic degree) to be achieved."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CareerPurposeCriterion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#CareerPurposeCriterion">https://w3id.org/dingo#CareerPurposeCriterion</seealso>
    let CareerPurposeCriterion =
        Prefixed_Name(dg, "CareerPurposeCriterion") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#CareerStageCriterion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Specifies that grants are awarded to projects on the basis of career stage limits."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CareerStageCriterion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#CareerStageCriterion">https://w3id.org/dingo#CareerStageCriterion</seealso>
    let CareerStageCriterion = Prefixed_Name(dg, "CareerStageCriterion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#Company</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A commercial business."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Company"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#Company">https://w3id.org/dingo#Company</seealso>
    let Company = Prefixed_Name(dg, "Company") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#Criterion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Specification of Grant coverage, Grant eligibility, Grant reimbursement rates, Grant specific criteria for funding, Grant population targets, and similar features."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Criterion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#Criterion">https://w3id.org/dingo#Criterion</seealso>
    let Criterion = Prefixed_Name(dg, "Criterion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#CulturalOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Cultural institution or cultural organization is an organization within a culture/subculture that works for the preservation or promotion of culture."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CulturalOrganisation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#CulturalOrganisation">https://w3id.org/dingo#CulturalOrganisation</seealso>
    let CulturalOrganisation = Prefixed_Name(dg, "CulturalOrganisation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#EducationOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Institution that provides education."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"EducationOrganisation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#EducationOrganisation">https://w3id.org/dingo#EducationOrganisation</seealso>
    let EducationOrganisation =
        Prefixed_Name(dg, "EducationOrganisation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#EmploymentCriterion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Specifies that grants are awarded on the basis of employment conditions by an organisation eligible for funding at the time of applying or receiving the funds."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"EmploymentCriterion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#EmploymentCriterion">https://w3id.org/dingo#EmploymentCriterion</seealso>
    let EmploymentCriterion = Prefixed_Name(dg, "EmploymentCriterion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#FacilityOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A place providing for a particular purpose."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"FacilityOrganisation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#FacilityOrganisation">https://w3id.org/dingo#FacilityOrganisation</seealso>
    let FacilityOrganisation = Prefixed_Name(dg, "FacilityOrganisation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#ForProfitOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"For profit entity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ForProfictOrganisation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#ForProfitOrganisation">https://w3id.org/dingo#ForProfitOrganisation</seealso>
    let ForProfitOrganisation =
        Prefixed_Name(dg, "ForProfitOrganisation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#FundingAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class for funding agencies: organisations that materially disburse and administer the Grant process."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"FundingAgency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#FundingAgency">https://w3id.org/dingo#FundingAgency</seealso>
    let FundingAgency = Prefixed_Name(dg, "FundingAgency") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#FundingScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class for funding schemes: plans, designs, and/or programs that determines and organizes the funding."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"FundingScheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#FundingScheme">https://w3id.org/dingo#FundingScheme</seealso>
    let FundingScheme = Prefixed_Name(dg, "FundingScheme") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#GeographicCriterion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Specifies that grants are awarded to projects on the basis of geographic areas, either where the project has to be implemented, or where the researcher must have been operating before applying for funding, or where the participants must be resident or citizens."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"GeographicCriterion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#GeographicCriterion">https://w3id.org/dingo#GeographicCriterion</seealso>
    let GeographicCriterion = Prefixed_Name(dg, "GeographicCriterion") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#GovernamentalOrganisation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/dingo#GovernamentalOrganisation">https://w3id.org/dingo#GovernamentalOrganisation</seealso>
    let GovernamentalOrganisation =
        Prefixed_Name(dg, "GovernamentalOrganisation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#GovernmentalOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Organisation or agency depending on a government, State or other supranational organisation and mainly operated by the government."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"GovernmentalOrganisation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#GovernmentalOrganisation">https://w3id.org/dingo#GovernmentalOrganisation</seealso>
    let GovernmentalOrganisation =
        Prefixed_Name(dg, "GovernmentalOrganisation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#Grant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class for grant: a disbursed fund payed to a recipient or beneficiary and the process for it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Grant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#Grant">https://w3id.org/dingo#Grant</seealso>
    let Grant = Prefixed_Name(dg, "Grant") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#GrantPayment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class for grant payments: a single payment to a recipient or beneficiary within a Grant."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"GrantPayment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#GrantPayment">https://w3id.org/dingo#GrantPayment</seealso>
    let GrantPayment = Prefixed_Name(dg, "GrantPayment") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#GrantShare</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class for grant shares: the full or proper portion or part allotted or belonging to or contributed to an individual entity within a Grant."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"GrantShare"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#GrantShare">https://w3id.org/dingo#GrantShare</seealso>
    let GrantShare = Prefixed_Name(dg, "GrantShare") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#HealthcareOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Organization that provides health care and related services."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"HealthcareOrganisation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#HealthcareOrganisation">https://w3id.org/dingo#HealthcareOrganisation</seealso>
    let HealthcareOrganisation =
        Prefixed_Name(dg, "HealthcareOrganisation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#HigherEducationOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Place of postsecondary education (e.g., universities, vocational universities, community colleges, liberal arts colleges, institutes of technology, and others)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"HigherEducationOrganisation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#HigherEducationOrganisation">https://w3id.org/dingo#HigherEducationOrganisation</seealso>
    let HigherEducationOrganisation =
        Prefixed_Name(dg, "HigherEducationOrganisation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#Identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class for identifiers."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#Identifier">https://w3id.org/dingo#Identifier</seealso>
    let Identifier = Prefixed_Name(dg, "Identifier") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#InformationBase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An organized collection of data and/or information. It can use any available technology. The temr can also indicate in general the information system built integrating such information bases."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"InformationBase"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#InformationBase">https://w3id.org/dingo#InformationBase</seealso>
    let InformationBase = Prefixed_Name(dg, "InformationBase") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#InfrastructurePurposeCriterion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Specifies that grants are awarded to cover for the expenses of infrastructure."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"InfrastructurePurposeCriterion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#InfrastructurePurposeCriterion">https://w3id.org/dingo#InfrastructurePurposeCriterion</seealso>
    let InfrastructurePurposeCriterion =
        Prefixed_Name(dg, "InfrastructurePurposeCriterion") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#IntergovernmentalOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Organization composed primarily of sovereign states. Example: United Nations."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"IntergovernmentalOrganisation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#IntergovernmentalOrganisation">https://w3id.org/dingo#IntergovernmentalOrganisation</seealso>
    let IntergovernmentalOrganisation =
        Prefixed_Name(dg, "IntergovernmentalOrganisation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#NonprofitOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Business entity that pays no income tax, as it furthers a religious, scientific or social cause, providing a public benefit."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NonprofitOrganisation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#NonprofitOrganisation">https://w3id.org/dingo#NonprofitOrganisation</seealso>
    let NonprofitOrganisation =
        Prefixed_Name(dg, "NonprofitOrganisation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#Organisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class for organisations: social entities with a collective goal."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Organisation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#Organisation">https://w3id.org/dingo#Organisation</seealso>
    let Organisation = Prefixed_Name(dg, "Organisation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#OrganisationRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class for organisation roles: function assumed by or ascribed to an organisation that takes part in something."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"OrganisationRole"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#OrganisationRole">https://w3id.org/dingo#OrganisationRole</seealso>
    let OrganisationRole = Prefixed_Name(dg, "OrganisationRole") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#OrganisationalCriterion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Specifies that grants are awarded on the basis of specified organisational form of the project, for instance demanding for participation of different research groups (synergy)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"OrganisationalCriterion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#OrganisationalCriterion">https://w3id.org/dingo#OrganisationalCriterion</seealso>
    let OrganisationalCriterion =
        Prefixed_Name(dg, "OrganisationalCriterion") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#PerformingGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A performance group, such as a band, an orchestra, or a circus."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PerformingGroup"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#PerformingGroup">https://w3id.org/dingo#PerformingGroup</seealso>
    let PerformingGroup = Prefixed_Name(dg, "PerformingGroup") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class for persons: alive, dead, undead, or fictional."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Person"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#Person">https://w3id.org/dingo#Person</seealso>
    let Person = Prefixed_Name(dg, "Person") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#PersonRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class for person roles: function assumed by or ascribed to a person that takes part in something."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PersonRole"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#PersonRole">https://w3id.org/dingo#PersonRole</seealso>
    let PersonRole = Prefixed_Name(dg, "PersonRole") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#Project</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class for projects: an organised endeavour (collective or individual) planned to reach a particular aim or achieve a result."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Project"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#Project">https://w3id.org/dingo#Project</seealso>
    let Project = Prefixed_Name(dg, "Project") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#ResearchPerformingOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Organisations devoted to research activities."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ResearchPerformingOrganisation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#ResearchPerformingOrganisation">https://w3id.org/dingo#ResearchPerformingOrganisation</seealso>
    let ResearchPerformingOrganisation =
        Prefixed_Name(dg, "ResearchPerformingOrganisation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class for roles: the function assumed by or ascribed to an entity (typically person, group of persons or organisation) in a particular situation.
    /// It can be used to precise or represent additional information about a relationship or property such as participation or membership. The class should be only used to derive subclasses."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#Role">https://w3id.org/dingo#Role</seealso>
    let Role = Prefixed_Name(dg, "Role") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#SportsOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents the class of all sports organizations, including sports teams, governing bodies, and sports associations."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SportsOrganisation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#SportsOrganisation">https://w3id.org/dingo#SportsOrganisation</seealso>
    let SportsOrganisation = Prefixed_Name(dg, "SportsOrganisation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#SupranationalOrganisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"International organisation with power and influence in the jurisdictions of its member states. Example: European Union."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SupranationalOrganisation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#SupranationalOrganisation">https://w3id.org/dingo#SupranationalOrganisation</seealso>
    let SupranationalOrganisation =
        Prefixed_Name(dg, "SupranationalOrganisation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#ThematicCriterion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Specifies that grants are awarded to projects on the basis of specified thematic/subject areas or well-defined areas of investigation indicated by the funding body."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ThematicCriterion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#ThematicCriterion">https://w3id.org/dingo#ThematicCriterion</seealso>
    let ThematicCriterion = Prefixed_Name(dg, "ThematicCriterion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#WorkingTimeCriterion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Specifies that grants are awarded to projects on the basis of percentage of work time specifically devoted to the funded research."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"WorkingTimeCriterion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#WorkingTimeCriterion">https://w3id.org/dingo#WorkingTimeCriterion</seealso>
    let WorkingTimeCriterion = Prefixed_Name(dg, "WorkingTimeCriterion") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#abstract_or_summary_description</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Short summary description of a project."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"abstract_or_summary_description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#abstract_or_summary_description">https://w3id.org/dingo#abstract_or_summary_description</seealso>
    let abstract_or_summary_description =
        Prefixed_Name(dg, "abstract_or_summary_description") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#academic_degree</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Qualification awarded to the person taking the role by a higher education organisation, normally at a college or university."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"academic_degree"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#academic_degree">https://w3id.org/dingo#academic_degree</seealso>
    let academic_degree = Prefixed_Name(dg, "academic_degree") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#additionalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Additional part of a person's beyond given name and surname, can be used for a middle name."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"additionalName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#additionalName">https://w3id.org/dingo#additionalName</seealso>
    let additionalName = Prefixed_Name(dg, "additionalName") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#affiliation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An organization that this person is affiliated with. For example, a school/university, a club, or a team."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"affiliation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#affiliation">https://w3id.org/dingo#affiliation</seealso>
    let affiliation = Prefixed_Name(dg, "affiliation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#agency_identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:Class</para>
    ///   <para>"Identifier (for example of Project, Grant, GrantPayment, PersonRole instance, OrganizationRole instance, FundingScheme, Person, Organisation) in the database/archive of the funding agency/funding body/funder."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"agency_identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#agency_identifier">https://w3id.org/dingo#agency_identifier</seealso>
    let agency_identifier = Prefixed_Name(dg, "agency_identifier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#baseline_academic_degree</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Academic degree used as minimal/reference point for establishing a set of age limits or other classification."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"baseline_academic_degree"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#baseline_academic_degree">https://w3id.org/dingo#baseline_academic_degree</seealso>
    let baseline_academic_degree =
        Prefixed_Name(dg, "baseline_academic_degree") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#beneficiary</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The relation between the Grant (subject) and a (one of the) person(s) or organisation(s) receiving benefits from it identified by his/her/its role."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"beneficiary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#beneficiary">https://w3id.org/dingo#beneficiary</seealso>
    let beneficiary = Prefixed_Name(dg, "beneficiary") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#beneficiary_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The relation between a (one of the) person(s) or organisation(s) receiving benefits from a Grant identified by his/her/its role (subject), and the Grant."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"beneficiary_of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#beneficiary_of">https://w3id.org/dingo#beneficiary_of</seealso>
    let beneficiary_of = Prefixed_Name(dg, "beneficiary_of") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#budget</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Amount of money necessary or planned for a determined project/activity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"budget"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#budget">https://w3id.org/dingo#budget</seealso>
    let budget = Prefixed_Name(dg, "budget") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#country</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Country where the organisation is located ufficially."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"country"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#country">https://w3id.org/dingo#country</seealso>
    let country = Prefixed_Name(dg, "country") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#criterion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Property by which a distinction or classification is made. When applied to, for instance, FundingScheme items it indicates criterion item establishing the eligibility conditions, target and other relevant points of the FundingScheme to fund an application."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"criterion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#criterion">https://w3id.org/dingo#criterion</seealso>
    let criterion = Prefixed_Name(dg, "criterion") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#criterion_description</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Description of the eligibility, targets and other relevant points of the FundingScheme."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"criterion_description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#criterion_description">https://w3id.org/dingo#criterion_description</seealso>
    let criterion_description =
        Prefixed_Name(dg, "criterion_description") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#crossref_grantid</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Identifier for funding in the Crossref registry."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"crossref_grantid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#crossref_grantid">https://w3id.org/dingo#crossref_grantid</seealso>
    let crossref_grantid = Prefixed_Name(dg, "crossref_grantid") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#crossref_id</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Identifier for an organisation that funds research, in the Crossref registry."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"crossref_id"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#crossref_id">https://w3id.org/dingo#crossref_id</seealso>
    let crossref_id = Prefixed_Name(dg, "crossref_id") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#degree_title</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Title denoting the academic degree."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"degree_title"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#degree_title">https://w3id.org/dingo#degree_title</seealso>
    let degree_title = Prefixed_Name(dg, "degree_title") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#disbursed_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The relation between the disbursed grant (subject) and the funding agency (object)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"disbursed_by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#disbursed_by">https://w3id.org/dingo#disbursed_by</seealso>
    let disbursed_by = Prefixed_Name(dg, "disbursed_by") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#disburses</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The relation between the funding agency (subject) and the disbursed grant (object)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"disburses"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#disburses">https://w3id.org/dingo#disburses</seealso>
    let disburses = Prefixed_Name(dg, "disburses") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#early_termination</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates if the role was ended ahead of time with respect to the grant contract of project ending."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"early_termination"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#early_termination">https://w3id.org/dingo#early_termination</seealso>
    let early_termination = Prefixed_Name(dg, "early_termination") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#economic_value</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Amount or value expressed in a specific currency (relationship between the item and a value expressed in a currency unit)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"economic_value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#economic_value">https://w3id.org/dingo#economic_value</seealso>
    let economic_value = Prefixed_Name(dg, "economic_value") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#employer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A person or company that provides a job (possibly paying wages or a salary) to the person taking the role."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"employer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#employer">https://w3id.org/dingo#employer</seealso>
    let employer = Prefixed_Name(dg, "employer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#end_time</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The time an item ceases to exist or a statement stops being valid."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"end_time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#end_time">https://w3id.org/dingo#end_time</seealso>
    let end_time = Prefixed_Name(dg, "end_time") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#entity_taking_role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The person or organisation or entity (object) assuming or to whom is assigned the role (subject)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"entity_taking_role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#entity_taking_role">https://w3id.org/dingo#entity_taking_role</seealso>
    let entity_taking_role = Prefixed_Name(dg, "entity_taking_role") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#excluded_academic_degree</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Academic degree possessing which the subject of the statement cannot apply to the funding program."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"excluded_academic_degree"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#excluded_academic_degree">https://w3id.org/dingo#excluded_academic_degree</seealso>
    let excluded_academic_degree =
        Prefixed_Name(dg, "excluded_academic_degree") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#field_of_work</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:Class</para>
    ///   <para>"Specialisation of a person, project or organisation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"title"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#field_of_work">https://w3id.org/dingo#field_of_work</seealso>
    let field_of_work = Prefixed_Name(dg, "field_of_work") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#finances</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The relation between the Grant (subject) and the Project (object)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"finances"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#finances">https://w3id.org/dingo#finances</seealso>
    let finances = Prefixed_Name(dg, "finances") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#funded_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The relation between the Project (subject) and the Grant (object)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"funded_by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#funded_by">https://w3id.org/dingo#funded_by</seealso>
    let funded_by = Prefixed_Name(dg, "funded_by") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#funder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The ultimate funder who decided and is ultimately responsible for the funding scheme.
    /// (Example: FundingScheme Horizon2020 dg:funder European Commission)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"funder"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#funder">https://w3id.org/dingo#funder</seealso>
    let funder = Prefixed_Name(dg, "funder") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#givenName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Part of a person's name that individuates the person within the (typically closest) group that shares the same surname."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"givenName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#givenName">https://w3id.org/dingo#givenName</seealso>
    let givenName = Prefixed_Name(dg, "givenName") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#grid_id</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Institutional identifier from the GRID.ac global research identifier database."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"grid_id"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#grid_id">https://w3id.org/dingo#grid_id</seealso>
    let grid_id = Prefixed_Name(dg, "grid_id") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#hasPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The relation between a superset and its direct subset(s). Indicates an item that is a part (also in generalised sense) of the subject item."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasPart"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#hasPart">https://w3id.org/dingo#hasPart</seealso>
    let hasPart = Prefixed_Name(dg, "hasPart") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#has_implementation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The relationship between the decision, plan, program (subject) and the grant (object) that the grant is the concrete realisation of."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has_implementation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#has_implementation">https://w3id.org/dingo#has_implementation</seealso>
    let has_implementation = Prefixed_Name(dg, "has_implementation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#headquarters_location</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Address of the headquarters of the organisation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"headquarters_location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#headquarters_location">https://w3id.org/dingo#headquarters_location</seealso>
    let headquarters_location =
        Prefixed_Name(dg, "headquarters_location") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#id_context_agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:Class</para>
    ///   <para>"Organization, Person, Agency related to the identifiers (for instance, creator, attributor, curator, maintainer, or similar). The specific semantic should be indicated with dedicated ontologies, such as PROV-O."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"id_context_agent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#id_context_agent">https://w3id.org/dingo#id_context_agent</seealso>
    let id_context_agent = Prefixed_Name(dg, "id_context_agent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#id_value</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"String representing the identifier."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"id_value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#id_value">https://w3id.org/dingo#id_value</seealso>
    let id_value = Prefixed_Name(dg, "id_value") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#implementation_country</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Country where the project must be implemented."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"implementation_country"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#implementation_country">https://w3id.org/dingo#implementation_country</seealso>
    let implementation_country =
        Prefixed_Name(dg, "implementation_country") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#implementation_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The relationship between the grant (subject) and the decision, plan, program (object) that the grant is the concrete realisation of."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"implementation_of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#implementation_of">https://w3id.org/dingo#implementation_of</seealso>
    let implementation_of = Prefixed_Name(dg, "implementation_of") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#implemented_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The relationship between the decision, plan, program (subject) and the funding agency (object) that the funding agency implements and administers."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"implemented_by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#implemented_by">https://w3id.org/dingo#implemented_by</seealso>
    let implemented_by = Prefixed_Name(dg, "implemented_by") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#implements</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The relationship between the funding agency (subject) and the decision, plan, program (object) that the funding agency implements and administers."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"implements"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#implements">https://w3id.org/dingo#implements</seealso>
    let implements = Prefixed_Name(dg, "implements") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#inception</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Date or point in time when the subject was founded/created."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"inception"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#inception">https://w3id.org/dingo#inception</seealso>
    let inception = Prefixed_Name(dg, "inception") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#isPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The relation between a subset and its direct superset(s). Indicates an item that is a part (also in generalised sense) of the object item."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isPartOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#isPartOf">https://w3id.org/dingo#isPartOf</seealso>
    let isPartOf = Prefixed_Name(dg, "isPartOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#legalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The official name of the organization, for example the registered company name."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"legalName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#legalName">https://w3id.org/dingo#legalName</seealso>
    let legalName = Prefixed_Name(dg, "legalName") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#max_age</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Maximum age allowed."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"max_age"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#max_age">https://w3id.org/dingo#max_age</seealso>
    let max_age = Prefixed_Name(dg, "max_age") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#max_years_from_baseline_degree</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Maximum number of years counting from the year of when the dg:baseline_academic_degree was obtained."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"max_years_from_baseline_degree"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#max_years_from_baseline_degree">https://w3id.org/dingo#max_years_from_baseline_degree</seealso>
    let max_years_from_baseline_degree =
        Prefixed_Name(dg, "max_years_from_baseline_degree") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#min_age</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Minimum age required."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"min_age"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#min_age">https://w3id.org/dingo#min_age</seealso>
    let min_age = Prefixed_Name(dg, "min_age") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#min_research_years</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Minimum number of research years required."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"min_research_years"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#min_research_years">https://w3id.org/dingo#min_research_years</seealso>
    let min_research_years = Prefixed_Name(dg, "min_research_years") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#min_years_from_baseline_degree</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Minimum number of years counting from the year of when the dg:baseline_academic_degree was obtained."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"min_years_from_baseline_degree"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#min_years_from_baseline_degree">https://w3id.org/dingo#min_years_from_baseline_degree</seealso>
    let min_years_from_baseline_degree =
        Prefixed_Name(dg, "min_years_from_baseline_degree") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#objective</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Desired result or outcome."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"objective"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#objective">https://w3id.org/dingo#objective</seealso>
    let objective = Prefixed_Name(dg, "objective") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#official_website</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"URL of the official website of an item."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"official_website"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#official_website">https://w3id.org/dingo#official_website</seealso>
    let official_website = Prefixed_Name(dg, "official_website") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#orcid_id</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Nonproprietary alphanumeric code to uniquely identify scientific and other academic authors."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"orcid_id"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#orcid_id">https://w3id.org/dingo#orcid_id</seealso>
    let orcid_id = Prefixed_Name(dg, "orcid_id") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#organisation_location</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Country or geographical administrative entity where an organisation must be established to apply for funding."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"organisation_location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#organisation_location">https://w3id.org/dingo#organisation_location</seealso>
    let organisation_location =
        Prefixed_Name(dg, "organisation_location") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#participant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The relation between the Project (subject) and a (one of the) person(s) or organisation(s) contributing to or taking part in it identified by his/her/its role."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"participant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#participant">https://w3id.org/dingo#participant</seealso>
    let participant = Prefixed_Name(dg, "participant") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#participant_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The relation between a (one of the) person(s) or organisation(s) participant of a Project identified by his/her/its role (subject), and the Project."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"participant_of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#participant_of">https://w3id.org/dingo#participant_of</seealso>
    let participant_of = Prefixed_Name(dg, "participant_of") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#percentage_employment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Minimum percentage of employment required (for example to be eligible for funding)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"percentage_employment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#percentage_employment">https://w3id.org/dingo#percentage_employment</seealso>
    let percentage_employment =
        Prefixed_Name(dg, "percentage_employment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#percentage_working_time</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Amount of working time in percentage."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"percentage_working_time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#percentage_working_time">https://w3id.org/dingo#percentage_working_time</seealso>
    let percentage_working_time =
        Prefixed_Name(dg, "percentage_working_time") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#person_location</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Country or geographical administrative entity where the person must reside or be citizen or have undertaken research up to the moment of applying for funding."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"person_location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#person_location">https://w3id.org/dingo#person_location</seealso>
    let person_location = Prefixed_Name(dg, "person_location") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#point_in_time</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The moment in time when an event occurs."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"point_in_time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#point_in_time">https://w3id.org/dingo#point_in_time</seealso>
    let point_in_time = Prefixed_Name(dg, "point_in_time") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#product_or_material_produced</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Material, product or output produced by a Project."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"product_or_material_produced"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#product_or_material_produced">https://w3id.org/dingo#product_or_material_produced</seealso>
    let product_or_material_produced =
        Prefixed_Name(dg, "product_or_material_produced") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dingo#recipient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The receiver of a GrantPayment or receiver/beneficiary of a GrantShare."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"recipient"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#recipient">https://w3id.org/dingo#recipient</seealso>
    let recipient = Prefixed_Name(dg, "recipient") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#role_label</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Label (name) of a Role."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"role_label"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#role_label">https://w3id.org/dingo#role_label</seealso>
    let role_label = Prefixed_Name(dg, "role_label") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#role_type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Item representing the specific class of a Role."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"role_type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#role_type">https://w3id.org/dingo#role_type</seealso>
    let role_type = Prefixed_Name(dg, "role_type") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#short_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Acronym or short name of an organisation or project or funding scheme."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"short_name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#short_name">https://w3id.org/dingo#short_name</seealso>
    let short_name = Prefixed_Name(dg, "short_name") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#start_time</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The time an item starts to exist/operate or a statement starts being valid."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"start_time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#start_time">https://w3id.org/dingo#start_time</seealso>
    let start_time = Prefixed_Name(dg, "start_time") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#surname</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Part of a person's name shared with a group (typically family or tribe or clan depending on the culture), and/or used in formal contexts or with people that do not know the person well."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"surname"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#surname">https://w3id.org/dingo#surname</seealso>
    let surname = Prefixed_Name(dg, "surname") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#takes_role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The role (object) assumed or assigned to a person or organisation or entity (subject)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"takes_role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#takes_role">https://w3id.org/dingo#takes_role</seealso>
    let takes_role = Prefixed_Name(dg, "takes_role") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#thematic_area</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Topics and/or area of interest."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"thematic_area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#thematic_area">https://w3id.org/dingo#thematic_area</seealso>
    let thematic_area = Prefixed_Name(dg, "thematic_area") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#title</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The title of a project (original or translated)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"title"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#title">https://w3id.org/dingo#title</seealso>
    let title = Prefixed_Name(dg, "title") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#used_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Database or information system where the identifier is/was used."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"used_in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#used_in">https://w3id.org/dingo#used_in</seealso>
    let used_in = Prefixed_Name(dg, "used_in") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dingo#wikidata_item_id</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Identifier for a class or item existing in Wikidata."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"wikidata_item_id"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dingo#wikidata_item_id">https://w3id.org/dingo#wikidata_item_id</seealso>
    let wikidata_item_id = Prefixed_Name(dg, "wikidata_item_id") |> PrefixedName
