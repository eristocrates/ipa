namespace http.w3id.org.roh.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module roh =
    let _namespace_iri = Namespace_Iri roh |> NamespaceIRI

    /// <summary>
    ///   <para>roh:AcademicAccreditation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An attestation of qualification, competence, or authority issued to an individual by a third party with a relevant or  de facto authority or assumed competence to do so in the academic field."</para>
    /// labels<para>"Acreditación Académica"</para><para>"Academic Accreditation"</para></remarks>
    /// <seealso href="http://w3id.org/roh#AcademicAccreditation">http://w3id.org/roh#AcademicAccreditation</seealso>
    let AcademicAccreditation =
        Prefixed_Name(roh, "AcademicAccreditation") |> PrefixedName

    /// <summary>
    ///   <para>roh:AcademicSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Matière académique"</para>
    /// labels<para>"Academic subject"</para><para>"Assignatura acadèmica"</para><para>"Asignatura académica"</para><para>"Unidade curricular acadêmica"</para></remarks>
    /// <seealso href="http://w3id.org/roh#AcademicSubject">http://w3id.org/roh#AcademicSubject</seealso>
    let AcademicSubject = Prefixed_Name(roh, "AcademicSubject") |> PrefixedName
    /// <summary>
    ///   <para>roh:Accepted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Accepted"</para></remarks>
    /// <seealso href="http://w3id.org/roh#Accepted">http://w3id.org/roh#Accepted</seealso>
    let Accepted = Prefixed_Name(roh, "Accepted") |> PrefixedName
    /// <summary>
    ///   <para>roh:Accreditation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Accreditation models research and academic position accreditations. Qualification goes beyond Accreditation because it also refers to degrees and other qualifications a person may have.  Accreditation has an important data property which is dateIssued which links Accreditation with vivo:DataTimeValue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Acreditación"</para><para>"Accreditation"</para></remarks>
    /// <seealso href="http://w3id.org/roh#Accreditation">http://w3id.org/roh#Accreditation</seealso>
    let Accreditation = Prefixed_Name(roh, "Accreditation") |> PrefixedName
    /// <summary>
    ///   <para>roh:AccreditationIssuer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An organization with a relevant or de facto authority or assumed competence to issue research or academic accreditations."</para>
    /// labels<para>"Accreditation Issuer"</para><para>"Emisor de Acreditación"</para></remarks>
    /// <seealso href="http://w3id.org/roh#AccreditationIssuer">http://w3id.org/roh#AccreditationIssuer</seealso>
    let AccreditationIssuer = Prefixed_Name(roh, "AccreditationIssuer") |> PrefixedName
    /// <summary>
    ///   <para>roh:Activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A roh:Activity is participated by Persons (roh:participates) and organized by Organizations through roh:hasRole connecting to intermediary entity vivo:OrganizerRole. Each activity is usually linked to a Project through relationship (roh:participates) and causes a ProjectExpense linked through (vivo:relates). A thorough hierarchy of roh:Activity subtypes is defined: bibo:Conference, vivo:Intership, roh:ThesisViva."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Activity"</para><para>"Actividad"</para></remarks>
    /// <seealso href="http://w3id.org/roh#Activity">http://w3id.org/roh#Activity</seealso>
    let Activity = Prefixed_Name(roh, "Activity") |> PrefixedName
    /// <summary>
    ///   <para>roh:Administrative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Administrative"</para></remarks>
    /// <seealso href="http://w3id.org/roh#Administrative">http://w3id.org/roh#Administrative</seealso>
    let Administrative = Prefixed_Name(roh, "Administrative") |> PrefixedName

    /// <summary>
    ///   <para>roh:AdministrativeEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This vertical module in ASIO models all the relevant administrative bodies ("Administración Autonómica") of Spain's Autonomous Communities (conserjerías, departamentos, secretarías) that might have a role (funding, participating) within the development of a given project. It is modeled hierarchically through the relevant administrative levels thereof."</para>
    /// labels<para>"Entidades administrativas"</para><para>"Entités administratives"</para><para>"Entitats administratives"</para><para>"Administrative entities"</para></remarks>
    /// <seealso href="http://w3id.org/roh#AdministrativeEntity">http://w3id.org/roh#AdministrativeEntity</seealso>
    let AdministrativeEntity =
        Prefixed_Name(roh, "AdministrativeEntity") |> PrefixedName

    /// <summary>
    ///   <para>roh:AuditeeRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Auditee Role"</para><para>"Rol de Auditado"</para></remarks>
    /// <seealso href="http://w3id.org/roh#AuditeeRole">http://w3id.org/roh#AuditeeRole</seealso>
    let AuditeeRole = Prefixed_Name(roh, "AuditeeRole") |> PrefixedName

    /// <summary>
    ///   <para>roh:AuditingRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Auditing Relationship"</para><para>"Relación de Auditoría"</para></remarks>
    /// <seealso href="http://w3id.org/roh#AuditingRelationship">http://w3id.org/roh#AuditingRelationship</seealso>
    let AuditingRelationship =
        Prefixed_Name(roh, "AuditingRelationship") |> PrefixedName

    /// <summary>
    ///   <para>roh:AuditorRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Auditor Role"</para><para>"Rol de Auditor"</para></remarks>
    /// <seealso href="http://w3id.org/roh#AuditorRole">http://w3id.org/roh#AuditorRole</seealso>
    let AuditorRole = Prefixed_Name(roh, "AuditorRole") |> PrefixedName
    /// <summary>
    ///   <para>roh:AuthorMetric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Métrica de Autor"</para><para>"Author Metric"</para></remarks>
    /// <seealso href="http://w3id.org/roh#AuthorMetric">http://w3id.org/roh#AuthorMetric</seealso>
    let AuthorMetric = Prefixed_Name(roh, "AuthorMetric") |> PrefixedName
    /// <summary>
    ///   <para>roh:Award</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Premio"</para><para>"Award"</para></remarks>
    /// <seealso href="http://w3id.org/roh#Award">http://w3id.org/roh#Award</seealso>
    let Award = Prefixed_Name(roh, "Award") |> PrefixedName
    /// <summary>
    ///   <para>roh:BachelorsDegree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An undergraduate academic degree awarded by colleges and universities upon completion of a course of study lasting three to four years (depending on institution and academic discipline)."</para>
    /// labels<para>"Títol de bàtxelor"</para><para>"Bachelor's degree"</para><para>"Licenciatura (pós-Bologna)"</para><para>"Títol de grau"</para><para>"Título de grado"</para></remarks>
    /// <seealso href="http://w3id.org/roh#BachelorsDegree">http://w3id.org/roh#BachelorsDegree</seealso>
    let BachelorsDegree = Prefixed_Name(roh, "BachelorsDegree") |> PrefixedName

    /// <summary>
    ///   <para>roh:BachelorsDegreeSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Unidade curricular de grau"</para>
    /// labels<para>"Assignatura de grau"</para><para>"Bachelor's degree subject"</para><para>"Asignatura de grao"</para><para>"Assignatura de bàtxelor"</para></remarks>
    /// <seealso href="http://w3id.org/roh#BachelorsDegreeSubject">http://w3id.org/roh#BachelorsDegreeSubject</seealso>
    let BachelorsDegreeSubject =
        Prefixed_Name(roh, "BachelorsDegreeSubject") |> PrefixedName

    /// <summary>
    ///   <para>roh:BachelorsSupervisingRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Relación de Supervisión de Titulación Universitaria"</para><para>"Bachelor's Supervising Relationship"</para></remarks>
    /// <seealso href="http://w3id.org/roh#BachelorsSupervisingRelationship">http://w3id.org/roh#BachelorsSupervisingRelationship</seealso>
    let BachelorsSupervisingRelationship =
        Prefixed_Name(roh, "BachelorsSupervisingRelationship") |> PrefixedName

    /// <summary>
    ///   <para>roh:BachelorsThesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document created to summarize research findings associated with the completion of an academic degree."</para>
    ///   <para>"A thesis reporting a research project undertaken as part of an undergraduate course of education to receive a bachelor's degree."</para>
    /// labels<para>"Treball fi de bàtxelor"</para><para>"Degree Thesis"</para><para>"Trabayu de fin de grau"</para><para>"Tesis de Grado"</para><para>"Bachelor's Thesis"</para><para>"Mémoire de fin de licence"</para><para>"Trabajo de fin de grado"</para><para>"Treball fi de grau"</para></remarks>
    /// <seealso href="http://w3id.org/roh#BachelorsThesis">http://w3id.org/roh#BachelorsThesis</seealso>
    let BachelorsThesis = Prefixed_Name(roh, "BachelorsThesis") |> PrefixedName
    /// <summary>
    ///   <para>roh:BitBucketRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Esta entidad define un repositorio BitBucket (https://bitbucket.org)."</para>
    ///   <para>"This entity defines a BitBucket Repository (https://bitbucket.org)."</para>
    /// labels<para>"BitBucket Repository"</para><para>"Repositorio  de BitBucket"</para></remarks>
    /// <seealso href="http://w3id.org/roh#BitBucketRepository">http://w3id.org/roh#BitBucketRepository</seealso>
    let BitBucketRepository = Prefixed_Name(roh, "BitBucketRepository") |> PrefixedName
    /// <summary>
    ///   <para>roh:BlogPost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Blog Post"</para></remarks>
    /// <seealso href="http://w3id.org/roh#BlogPost">http://w3id.org/roh#BlogPost</seealso>
    let BlogPost = Prefixed_Name(roh, "BlogPost") |> PrefixedName
    /// <summary>
    ///   <para>roh:CVOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An object property linking a CV to the person it belongs to."</para>
    /// labels<para>"CV of"</para><para>"CV de"</para></remarks>
    /// <seealso href="http://w3id.org/roh#CVOf">http://w3id.org/roh#CVOf</seealso>
    let CVOf = Prefixed_Name(roh, "CVOf") |> PrefixedName
    /// <summary>
    ///   <para>roh:Cancelled</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Cancelled"</para></remarks>
    /// <seealso href="http://w3id.org/roh#Cancelled">http://w3id.org/roh#Cancelled</seealso>
    let Cancelled = Prefixed_Name(roh, "Cancelled") |> PrefixedName
    /// <summary>
    ///   <para>roh:CaseStudy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A qualitative descriptive research study of individuals or a group."</para>
    /// labels<para>"Case study"</para></remarks>
    /// <seealso href="http://w3id.org/roh#CaseStudy">http://w3id.org/roh#CaseStudy</seealso>
    let CaseStudy = Prefixed_Name(roh, "CaseStudy") |> PrefixedName
    /// <summary>
    ///   <para>roh:Catalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A list of items in a collection; an ordered compilation of item descriptions and sufficient information to afford access to them."</para>
    /// labels<para>"Catalog"</para></remarks>
    /// <seealso href="http://w3id.org/roh#Catalog">http://w3id.org/roh#Catalog</seealso>
    let Catalog = Prefixed_Name(roh, "Catalog") |> PrefixedName
    /// <summary>
    ///   <para>roh:Closed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Closed"</para></remarks>
    /// <seealso href="http://w3id.org/roh#Closed">http://w3id.org/roh#Closed</seealso>
    let Closed = Prefixed_Name(roh, "Closed") |> PrefixedName

    /// <summary>
    ///   <para>roh:CompanyClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Company Classification"</para></remarks>
    /// <seealso href="http://w3id.org/roh#CompanyClassification">http://w3id.org/roh#CompanyClassification</seealso>
    let CompanyClassification =
        Prefixed_Name(roh, "CompanyClassification") |> PrefixedName

    /// <summary>
    ///   <para>roh:Contest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Contest"</para></remarks>
    /// <seealso href="http://w3id.org/roh#Contest">http://w3id.org/roh#Contest</seealso>
    let Contest = Prefixed_Name(roh, "Contest") |> PrefixedName
    /// <summary>
    ///   <para>roh:Country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A region legally identified as a distinct entity in political geography."</para>
    /// labels<para>"País"</para><para>"Pays"</para><para>"Herrialde"</para><para>"Country"</para></remarks>
    /// <seealso href="http://w3id.org/roh#Country">http://w3id.org/roh#Country</seealso>
    let Country = Prefixed_Name(roh, "Country") |> PrefixedName
    /// <summary>
    ///   <para>roh:CourseCertificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Certificado de Curso"</para><para>"Course Certificate"</para></remarks>
    /// <seealso href="http://w3id.org/roh#CourseCertificate">http://w3id.org/roh#CourseCertificate</seealso>
    let CourseCertificate = Prefixed_Name(roh, "CourseCertificate") |> PrefixedName
    /// <summary>
    ///   <para>roh:CurriculumVitae</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document used and created by a person to present their background, skills and accomplishments."</para>
    ///   <para>"roh:CurriculumVitae adds extra fields necessary to be able to complete the CV of a foaf:Person which cannot be extracted from the relationships with roh:ResearchObject and vivo:Project, among others, that a foaf:Person may have."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Curriculum vitae"</para><para>"Currículum vitae"</para><para>"Curriculum Vitae"</para></remarks>
    /// <seealso href="http://w3id.org/roh#CurriculumVitae">http://w3id.org/roh#CurriculumVitae</seealso>
    let CurriculumVitae = Prefixed_Name(roh, "CurriculumVitae") |> PrefixedName
    /// <summary>
    ///   <para>roh:Database</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Database"</para></remarks>
    /// <seealso href="http://w3id.org/roh#Database">http://w3id.org/roh#Database</seealso>
    let Database = Prefixed_Name(roh, "Database") |> PrefixedName
    /// <summary>
    ///   <para>roh:DegreeHomologation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Homologación de Titulación"</para><para>"Degree Homologation"</para></remarks>
    /// <seealso href="http://w3id.org/roh#DegreeHomologation">http://w3id.org/roh#DegreeHomologation</seealso>
    let DegreeHomologation = Prefixed_Name(roh, "DegreeHomologation") |> PrefixedName
    /// <summary>
    ///   <para>roh:DegreeMetric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Degree Metric"</para><para>"Métrica de Grado"</para></remarks>
    /// <seealso href="http://w3id.org/roh#DegreeMetric">http://w3id.org/roh#DegreeMetric</seealso>
    let DegreeMetric = Prefixed_Name(roh, "DegreeMetric") |> PrefixedName
    /// <summary>
    ///   <para>roh:DisseminationEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Dissemination Event"</para></remarks>
    /// <seealso href="http://w3id.org/roh#DisseminationEvent">http://w3id.org/roh#DisseminationEvent</seealso>
    let DisseminationEvent = Prefixed_Name(roh, "DisseminationEvent") |> PrefixedName
    /// <summary>
    ///   <para>roh:DoctoralDegree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Doctorat"</para><para>"Doutoramento"</para><para>"Doktorego"</para><para>"Doctoral degree"</para><para>"Doctorado"</para></remarks>
    /// <seealso href="http://w3id.org/roh#DoctoralDegree">http://w3id.org/roh#DoctoralDegree</seealso>
    let DoctoralDegree = Prefixed_Name(roh, "DoctoralDegree") |> PrefixedName
    /// <summary>
    ///   <para>roh:Dossier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"File is a collection in which all assets related to a Project are stored, including the Research Proposal, approval documents, viability plans and so on associated to a project are stored."</para>
    /// labels<para>"Dossier"</para></remarks>
    /// <seealso href="http://w3id.org/roh#Dossier">http://w3id.org/roh#Dossier</seealso>
    let Dossier = Prefixed_Name(roh, "Dossier") |> PrefixedName
    /// <summary>
    ///   <para>roh:EditedPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Edited publication"</para></remarks>
    /// <seealso href="http://w3id.org/roh#EditedPublication">http://w3id.org/roh#EditedPublication</seealso>
    let EditedPublication = Prefixed_Name(roh, "EditedPublication") |> PrefixedName
    /// <summary>
    ///   <para>roh:EthicalAudit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EthicalAudit"</para></remarks>
    /// <seealso href="http://w3id.org/roh#EthicalAudit">http://w3id.org/roh#EthicalAudit</seealso>
    let EthicalAudit = Prefixed_Name(roh, "EthicalAudit") |> PrefixedName
    /// <summary>
    ///   <para>roh:EthicalReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EthicalReport"</para></remarks>
    /// <seealso href="http://w3id.org/roh#EthicalReport">http://w3id.org/roh#EthicalReport</seealso>
    let EthicalReport = Prefixed_Name(roh, "EthicalReport") |> PrefixedName
    /// <summary>
    ///   <para>roh:EthicalValidation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EthicalValidation"</para></remarks>
    /// <seealso href="http://w3id.org/roh#EthicalValidation">http://w3id.org/roh#EthicalValidation</seealso>
    let EthicalValidation = Prefixed_Name(roh, "EthicalValidation") |> PrefixedName
    /// <summary>
    ///   <para>roh:EthicsCommittee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An ethics committee is a body responsible for ensuring that medical experimentation and human subject research are carried out in an ethical manner in accordance with national and international law."</para>
    /// labels<para>"Ethics Comitee"</para><para>"Comite Etico"</para></remarks>
    /// <seealso href="http://w3id.org/roh#EthicsCommittee">http://w3id.org/roh#EthicsCommittee</seealso>
    let EthicsCommittee = Prefixed_Name(roh, "EthicsCommittee") |> PrefixedName

    /// <summary>
    ///   <para>roh:EuropeanAgriculturalGuaranteeFund</para>
    /// </summary>
    /// <remarks>
    ///   <para>roh:FundingSource</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A fund allocated by the European Union. It finances direct payments to farmers under the Common Agricultural Policy (CAP) and measures to regulate agricultural markets such as intervention and export refunds."</para>
    /// labels<para>"Fondo Europeo de Orientación y Garantía Agrícola"</para><para>"European Agricultural Guarantee Fund"</para></remarks>
    /// <seealso href="http://w3id.org/roh#EuropeanAgriculturalGuaranteeFund">http://w3id.org/roh#EuropeanAgriculturalGuaranteeFund</seealso>
    let EuropeanAgriculturalGuaranteeFund =
        Prefixed_Name(roh, "EuropeanAgriculturalGuaranteeFund") |> PrefixedName

    /// <summary>
    ///   <para>roh:EuropeanMaritimeAndFisheriesFund</para>
    /// </summary>
    /// <remarks>
    ///   <para>roh:FundingSource</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The EMFF is the fund for the EU's maritime and fisheries policies for 2014-2020."</para>
    /// labels<para>"European Maritime and Fisheries Fund"</para><para>"Fondo Europeo Marítimo y de Pesca"</para></remarks>
    /// <seealso href="http://w3id.org/roh#EuropeanMaritimeAndFisheriesFund">http://w3id.org/roh#EuropeanMaritimeAndFisheriesFund</seealso>
    let EuropeanMaritimeAndFisheriesFund =
        Prefixed_Name(roh, "EuropeanMaritimeAndFisheriesFund") |> PrefixedName

    /// <summary>
    ///   <para>roh:EuropeanRegionalDevelopmentFund</para>
    /// </summary>
    /// <remarks>
    ///   <para>roh:FundingSource</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A fund allocated by the European Union. Its purpose is to transfer money from richer regions (not countries), and invest it in the infrastructure and services of underdeveloped regions. This will allow those regions to start attracting private sector investments, and create jobs on their own."</para>
    /// labels<para>"European Regional Development Fund"</para><para>"Fondo Europeo de Desarrollo Regional"</para></remarks>
    /// <seealso href="http://w3id.org/roh#EuropeanRegionalDevelopmentFund">http://w3id.org/roh#EuropeanRegionalDevelopmentFund</seealso>
    let EuropeanRegionalDevelopmentFund =
        Prefixed_Name(roh, "EuropeanRegionalDevelopmentFund") |> PrefixedName

    /// <summary>
    ///   <para>roh:EuropeanSocialFund</para>
    /// </summary>
    /// <remarks>
    ///   <para>roh:FundingSource</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"It is one of the European Structural and Investment Funds (ESIF), which are dedicated to improving social cohesion and economic well-being across the regions of the Union. The funds are redistributive financial instruments that support cohesion within Europe by concentrating spending on the less-developed regions."</para>
    /// labels<para>"European Social Fund"</para><para>"Fondo Social Europeo"</para></remarks>
    /// <seealso href="http://w3id.org/roh#EuropeanSocialFund">http://w3id.org/roh#EuropeanSocialFund</seealso>
    let EuropeanSocialFund = Prefixed_Name(roh, "EuropeanSocialFund") |> PrefixedName
    /// <summary>
    ///   <para>roh:EvaluationSummary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An evaluation summary provided by a funding organization."</para>
    /// labels<para>"Resumen de Evaluación"</para><para>"Evaluation Summary"</para></remarks>
    /// <seealso href="http://w3id.org/roh#EvaluationSummary">http://w3id.org/roh#EvaluationSummary</seealso>
    let EvaluationSummary = Prefixed_Name(roh, "EvaluationSummary") |> PrefixedName
    /// <summary>
    ///   <para>roh:EventOrganiser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A role of organising cientific events, such as conferences, workshops, etc."</para>
    /// labels<para>"Event organiser"</para></remarks>
    /// <seealso href="http://w3id.org/roh#EventOrganiser">http://w3id.org/roh#EventOrganiser</seealso>
    let EventOrganiser = Prefixed_Name(roh, "EventOrganiser") |> PrefixedName
    /// <summary>
    ///   <para>roh:Expense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A roh:Expense is carried out in a vivo:Project or by foaf:Person and associated through relationship roh:spends. It timestamps each expense with a vivo:DateTimeValue and has attributes roh:monetaryAmount, roh:currency, roh:title and roh:description and expenseAmount . The types of expenses considered are: Personnel Expenses, Subcontracting, Travel, Equipment, Research Infrastructure and Other Goods and Services. Some of these classes still not defined."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Gasto"</para><para>"Expense"</para></remarks>
    /// <seealso href="http://w3id.org/roh#Expense">http://w3id.org/roh#Expense</seealso>
    let Expense = Prefixed_Name(roh, "Expense") |> PrefixedName

    /// <summary>
    ///   <para>roh:ExpenseClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Expense Classification"</para></remarks>
    /// <seealso href="http://w3id.org/roh#ExpenseClassification">http://w3id.org/roh#ExpenseClassification</seealso>
    let ExpenseClassification =
        Prefixed_Name(roh, "ExpenseClassification") |> PrefixedName

    /// <summary>
    ///   <para>roh:ExperimentalProtocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Protocolo Experimental"</para><para>"Experimental Protocol"</para></remarks>
    /// <seealso href="http://w3id.org/roh#ExperimentalProtocol">http://w3id.org/roh#ExperimentalProtocol</seealso>
    let ExperimentalProtocol =
        Prefixed_Name(roh, "ExperimentalProtocol") |> PrefixedName

    /// <summary>
    ///   <para>roh:ExperimentalProtocolResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Document that contains the result or execution of a Experimental Protocol."</para>
    ///   <para>"Documento que describe el resultado y la ejecución del protocolo experimental."</para>
    /// labels<para>"Resultado del Protocolo Experimental"</para><para>"Experimental Protocol Result"</para></remarks>
    /// <seealso href="http://w3id.org/roh#ExperimentalProtocolResult">http://w3id.org/roh#ExperimentalProtocolResult</seealso>
    let ExperimentalProtocolResult =
        Prefixed_Name(roh, "ExperimentalProtocolResult") |> PrefixedName

    /// <summary>
    ///   <para>roh:ExternalMemberRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A member who works in a Project or participates in an Activity but do not belong to the main Organization."</para>
    /// labels<para>"External Member Role"</para><para>"Rol de Miembro Externo"</para></remarks>
    /// <seealso href="http://w3id.org/roh#ExternalMemberRole">http://w3id.org/roh#ExternalMemberRole</seealso>
    let ExternalMemberRole = Prefixed_Name(roh, "ExternalMemberRole") |> PrefixedName

    /// <summary>
    ///   <para>roh:FacultyPositionEmeritus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A retired professor who has retained their rank, title and privileges."</para>
    /// labels<para>"Posición de Profesor Emérito"</para><para>"Faculty Position Emeritus"</para></remarks>
    /// <seealso href="http://w3id.org/roh#FacultyPositionEmeritus">http://w3id.org/roh#FacultyPositionEmeritus</seealso>
    let FacultyPositionEmeritus =
        Prefixed_Name(roh, "FacultyPositionEmeritus") |> PrefixedName

    /// <summary>
    ///   <para>roh:Final</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Final"</para></remarks>
    /// <seealso href="http://w3id.org/roh#Final">http://w3id.org/roh#Final</seealso>
    let Final = Prefixed_Name(roh, "Final") |> PrefixedName
    /// <summary>
    ///   <para>roh:Funded</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Funded"</para></remarks>
    /// <seealso href="http://w3id.org/roh#Funded">http://w3id.org/roh#Funded</seealso>
    let Funded = Prefixed_Name(roh, "Funded") |> PrefixedName
    /// <summary>
    ///   <para>roh:Funding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A roh:Funding is the funding associated to a vivo:Project whose funding is associated to a roh:FundingProgram, which in turn is associated to a vivo:FundingOrganization. A roh:Funding consists of several roh:FundingAmounts, associated to the different entities that participate in a project and to the annuities in which they do it.  Funding gathers information about the total funding received for a Project and its currency through properties roh:monetaryAmount and roh:currency. A roh:FundingSource funds a roh:FundingProgram. A roh:Funding supports a vivo:Project or a roh:PersonContract. A Funding can be tagged as public or private, by updating the data property roh:publicFunding."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Funding"</para><para>"Financiación"</para></remarks>
    /// <seealso href="http://w3id.org/roh#Funding">http://w3id.org/roh#Funding</seealso>
    let Funding = Prefixed_Name(roh, "Funding") |> PrefixedName
    /// <summary>
    ///   <para>roh:FundingAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A roh:FundingAmount is linked to a roh:Funding which is roh:fundedBy a roh:FundingProgram and finances a Project (through roh:supports relationship). Each FundingAmount is associated to an Organization participating in the Project (through roh:grants relationship) for each project specific annuity."^^&lt;http://www.w3.org/2000/01/rdf-schema#Literal&gt;</para>
    /// labels<para>"Funding Amount"</para><para>"Monto de Financiación"</para></remarks>
    /// <seealso href="http://w3id.org/roh#FundingAmount">http://w3id.org/roh#FundingAmount</seealso>
    let FundingAmount = Prefixed_Name(roh, "FundingAmount") |> PrefixedName
    /// <summary>
    ///   <para>roh:FundingProgram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A roh:FundingProgram is promoted (roh:promotedBy) by a Funding Organization (vivo:FundingOrganization) and it is in place for a time interval (vivo:dateTimeInterval)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A programme of related funded projects, typically established by a funding organization."</para>
    /// labels<para>"Funding programme"</para><para>"Programa de Financiación"</para><para>"Funding Program"</para></remarks>
    /// <seealso href="http://w3id.org/roh#FundingProgram">http://w3id.org/roh#FundingProgram</seealso>
    let FundingProgram = Prefixed_Name(roh, "FundingProgram") |> PrefixedName

    /// <summary>
    ///   <para>roh:FundingProgramClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Funding Program Classification"</para></remarks>
    /// <seealso href="http://w3id.org/roh#FundingProgramClassification">http://w3id.org/roh#FundingProgramClassification</seealso>
    let FundingProgramClassification =
        Prefixed_Name(roh, "FundingProgramClassification") |> PrefixedName

    /// <summary>
    ///   <para>roh:FundingSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"We have just considered a subset of the available funding sources, taking into account the sample datasets provided by University of Murcia
    ///
    /// A roh:FundingSource roh:feeds a roh:Funding with funds to sponsor some projects."</para>
    /// labels<para>"Fuente de Financiación"</para><para>"Funding Source"</para></remarks>
    /// <seealso href="http://w3id.org/roh#FundingSource">http://w3id.org/roh#FundingSource</seealso>
    let FundingSource = Prefixed_Name(roh, "FundingSource") |> PrefixedName
    /// <summary>
    ///   <para>roh:GitHubRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It's a concrete Repository that is stored in https://github.com."</para>
    ///   <para>"Es un repositorio concreto almacenado en https://github.com."</para>
    /// labels<para>"GitHub Repository"</para><para>"Repositorio de GitHub"</para></remarks>
    /// <seealso href="http://w3id.org/roh#GitHubRepository">http://w3id.org/roh#GitHubRepository</seealso>
    let GitHubRepository = Prefixed_Name(roh, "GitHubRepository") |> PrefixedName
    /// <summary>
    ///   <para>roh:Grant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A financial award provided by a funding organisation for a particular project or purpose, usually awarded on the basis of a competitive application."</para>
    ///   <para>"An amount of money given especially by the government to a person or organization for a special purpose."</para>
    /// labels<para>"Subvención"</para><para>"Grant"</para></remarks>
    /// <seealso href="http://w3id.org/roh#Grant">http://w3id.org/roh#Grant</seealso>
    let Grant = Prefixed_Name(roh, "Grant") |> PrefixedName
    /// <summary>
    ///   <para>roh:HRClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Clasificación de los recursos humanos"</para><para>"Human Resource Classification"</para></remarks>
    /// <seealso href="http://w3id.org/roh#HRClassification">http://w3id.org/roh#HRClassification</seealso>
    let HRClassification = Prefixed_Name(roh, "HRClassification") |> PrefixedName
    /// <summary>
    ///   <para>roh:Invention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Invention"</para>
    ///   <para>"A new device, method, or process developed from study and experimentation in the framework of research."</para>
    /// labels<para>"Invention"</para></remarks>
    /// <seealso href="http://w3id.org/roh#Invention">http://w3id.org/roh#Invention</seealso>
    let Invention = Prefixed_Name(roh, "Invention") |> PrefixedName
    /// <summary>
    ///   <para>roh:Invoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Factura"</para><para>"Invoice"</para></remarks>
    /// <seealso href="http://w3id.org/roh#Invoice">http://w3id.org/roh#Invoice</seealso>
    let Invoice = Prefixed_Name(roh, "Invoice") |> PrefixedName
    /// <summary>
    ///   <para>roh:JournalMetric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This is the metric of a jorunal. When the journal metric is updated, a new journal metric must be created with the same impactFactorName but with the updated impactFactor, ranking and quartile values."</para>
    ///   <para>"Esta entidad es la metrica de una revista. Cada cierto tiempo se actualiza la metrica de cada revista por lo que esa revista debe  crear una nueva JournalMetric con el mismo impactFactorName pero en la cual los valores de fecha impactFactor, ranking y quartile esten actualizados."</para>
    /// labels<para>"Journal Metric"</para><para>"Metrica de una revista"</para></remarks>
    /// <seealso href="http://w3id.org/roh#JournalMetric">http://w3id.org/roh#JournalMetric</seealso>
    let JournalMetric = Prefixed_Name(roh, "JournalMetric") |> PrefixedName
    /// <summary>
    ///   <para>roh:Justification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Justification is a bibo:Report used to justify eithet technically, economically or both a project."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Justification"</para></remarks>
    /// <seealso href="http://w3id.org/roh#Justification">http://w3id.org/roh#Justification</seealso>
    let Justification = Prefixed_Name(roh, "Justification") |> PrefixedName
    /// <summary>
    ///   <para>roh:KnowledgeArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ROH will be populated with instance data of UNESCO skos concepts. A Person, Activity, Project and Organization can be qualified by a KnowledgeArea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Knowledge Area"</para><para>"Área de Conocimiento"</para></remarks>
    /// <seealso href="http://w3id.org/roh#KnowledgeArea">http://w3id.org/roh#KnowledgeArea</seealso>
    let KnowledgeArea = Prefixed_Name(roh, "KnowledgeArea") |> PrefixedName
    /// <summary>
    ///   <para>roh:LanguageCertificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A language certificate from the Common European Framework of Reference for Languages: Learning, Teaching, Assessment."</para>
    /// labels<para>"Certificado de Idioma"</para><para>"Language Certificate"</para></remarks>
    /// <seealso href="http://w3id.org/roh#LanguageCertificate">http://w3id.org/roh#LanguageCertificate</seealso>
    let LanguageCertificate = Prefixed_Name(roh, "LanguageCertificate") |> PrefixedName
    /// <summary>
    ///   <para>roh:LargeEnterprise</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Large enterprise"</para><para>"Grande empresa"</para><para>"Empresa grande"</para><para>"Large Enterprise"</para><para>"Empresa gran"</para></remarks>
    /// <seealso href="http://w3id.org/roh#LargeEnterprise">http://w3id.org/roh#LargeEnterprise</seealso>
    let LargeEnterprise = Prefixed_Name(roh, "LargeEnterprise") |> PrefixedName

    /// <summary>
    ///   <para>roh:LibrarianPositionEmeritus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A retired librarian who has retained their rank, title and privileges."</para>
    /// labels<para>"Posición de Bibliotecario Emérito"</para><para>"Librarian Position Emeritus"</para></remarks>
    /// <seealso href="http://w3id.org/roh#LibrarianPositionEmeritus">http://w3id.org/roh#LibrarianPositionEmeritus</seealso>
    let LibrarianPositionEmeritus =
        Prefixed_Name(roh, "LibrarianPositionEmeritus") |> PrefixedName

    /// <summary>
    ///   <para>roh:Loan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An amount of money that is borrowed, often from a bank or a funding organization, and has to be paid back, usually together with an extra amount of money that you have to pay as a charge for borrowing."</para>
    /// labels<para>"Loan"</para><para>"Préstamo"</para></remarks>
    /// <seealso href="http://w3id.org/roh#Loan">http://w3id.org/roh#Loan</seealso>
    let Loan = Prefixed_Name(roh, "Loan") |> PrefixedName
    /// <summary>
    ///   <para>roh:ManagementUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ManagementUnit"</para></remarks>
    /// <seealso href="http://w3id.org/roh#ManagementUnit">http://w3id.org/roh#ManagementUnit</seealso>
    let ManagementUnit = Prefixed_Name(roh, "ManagementUnit") |> PrefixedName
    /// <summary>
    ///   <para>roh:MastersDegree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Màster universitari"</para><para>"Maîtrise universitaire"</para><para>"Master's degree"</para><para>"Máster universitario"</para><para>"Mestrado"</para><para>"Magister Scientiae"</para></remarks>
    /// <seealso href="http://w3id.org/roh#MastersDegree">http://w3id.org/roh#MastersDegree</seealso>
    let MastersDegree = Prefixed_Name(roh, "MastersDegree") |> PrefixedName

    /// <summary>
    ///   <para>roh:MastersDegreeSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Matière de master"</para>
    ///   <para>"Matière de maîtrise"</para>
    /// labels<para>"Assignatura de màster"</para><para>"Unidace curricular de mestrado"</para><para>"Asignatura de máster"</para><para>"Master's degree subject"</para><para>"Assignatura de mestratge"</para></remarks>
    /// <seealso href="http://w3id.org/roh#MastersDegreeSubject">http://w3id.org/roh#MastersDegreeSubject</seealso>
    let MastersDegreeSubject =
        Prefixed_Name(roh, "MastersDegreeSubject") |> PrefixedName

    /// <summary>
    ///   <para>roh:MastersStudent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Master's Student"</para></remarks>
    /// <seealso href="http://w3id.org/roh#MastersStudent">http://w3id.org/roh#MastersStudent</seealso>
    let MastersStudent = Prefixed_Name(roh, "MastersStudent") |> PrefixedName

    /// <summary>
    ///   <para>roh:MastersSupervisingRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Master's Supervising Relationship"</para><para>"Relación de Supervisión de Máster Universitario"</para></remarks>
    /// <seealso href="http://w3id.org/roh#MastersSupervisingRelationship">http://w3id.org/roh#MastersSupervisingRelationship</seealso>
    let MastersSupervisingRelationship =
        Prefixed_Name(roh, "MastersSupervisingRelationship") |> PrefixedName

    /// <summary>
    ///   <para>roh:MastersThesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document created to summarize research findings associated with the completion of a master's degree."</para>
    ///   <para>"A thesis reporting a research project undertaken as part of a second-cycle course of education to receive a master's degree."</para>
    /// labels<para>"Tesis de Máster"</para><para>"Mémoire de maîtrise"</para><para>"Trabajo de fin de máster"</para><para>"Tesis de maestría"</para><para>"Treball de fi de màster"</para><para>"Dissertação de mestrado"</para><para>"Tese de mestrado"</para><para>"Master's Thesis"</para><para>"Traballo de fin de máster"</para></remarks>
    /// <seealso href="http://w3id.org/roh#MastersThesis">http://w3id.org/roh#MastersThesis</seealso>
    let MastersThesis = Prefixed_Name(roh, "MastersThesis") |> PrefixedName
    /// <summary>
    ///   <para>roh:MediumEnterprise</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An enterprise which employ fewer than 250 persons and which have an annual turnover not exceeding EUR 50 million, and/or an annual balance sheet total not exceeding EUR 43 million."</para>
    /// labels<para>"Medium Enterprise"</para></remarks>
    /// <seealso href="http://w3id.org/roh#MediumEnterprise">http://w3id.org/roh#MediumEnterprise</seealso>
    let MediumEnterprise = Prefixed_Name(roh, "MediumEnterprise") |> PrefixedName
    /// <summary>
    ///   <para>roh:Metric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An roh:Metric indicates qualifies a roh:ResearchObject according to common established quality measurement metrics, e.g. impact factor or mark in an PhD viva."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Métrica"</para><para>"Metric"</para></remarks>
    /// <seealso href="http://w3id.org/roh#Metric">http://w3id.org/roh#Metric</seealso>
    let Metric = Prefixed_Name(roh, "Metric") |> PrefixedName
    /// <summary>
    ///   <para>roh:MicroEnterprise</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An enterprise which employs fewer than 10 persons and whose annual turnover and/or annual balance sheet total does not exceed EUR 2 million."</para>
    /// labels<para>"Micro Enterprise"</para></remarks>
    /// <seealso href="http://w3id.org/roh#MicroEnterprise">http://w3id.org/roh#MicroEnterprise</seealso>
    let MicroEnterprise = Prefixed_Name(roh, "MicroEnterprise") |> PrefixedName
    /// <summary>
    ///   <para>roh:ORCID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"ORCID"</para></remarks>
    /// <seealso href="http://w3id.org/roh#ORCID">http://w3id.org/roh#ORCID</seealso>
    let ORCID = Prefixed_Name(roh, "ORCID") |> PrefixedName
    /// <summary>
    ///   <para>roh:Open</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Open"</para></remarks>
    /// <seealso href="http://w3id.org/roh#Open">http://w3id.org/roh#Open</seealso>
    let Open = Prefixed_Name(roh, "Open") |> PrefixedName
    /// <summary>
    ///   <para>roh:Outsourcing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The process of paying to have part of a company's work done by another company."</para>
    /// labels<para>"Outsourcing"</para><para>"Subcontratación"</para></remarks>
    /// <seealso href="http://w3id.org/roh#Outsourcing">http://w3id.org/roh#Outsourcing</seealso>
    let Outsourcing = Prefixed_Name(roh, "Outsourcing") |> PrefixedName
    /// <summary>
    ///   <para>roh:PanelTalk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A group of people gathered to discuss a topic in front of an audience, typically at scientific, business, or academic conferences, fan conventions, and on television shows. Panels usually include a moderator who guides the discussion and sometimes elicits audience questions, with the goal of being informative and entertaining"</para>
    /// labels<para>"Panel Talk"</para><para>"Charla en Panel"</para></remarks>
    /// <seealso href="http://w3id.org/roh#PanelTalk">http://w3id.org/roh#PanelTalk</seealso>
    let PanelTalk = Prefixed_Name(roh, "PanelTalk") |> PrefixedName
    /// <summary>
    ///   <para>roh:PatentApplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Patent Application"</para></remarks>
    /// <seealso href="http://w3id.org/roh#PatentApplication">http://w3id.org/roh#PatentApplication</seealso>
    let PatentApplication = Prefixed_Name(roh, "PatentApplication") |> PrefixedName
    /// <summary>
    ///   <para>roh:PatentContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Patent Contract"</para></remarks>
    /// <seealso href="http://w3id.org/roh#PatentContract">http://w3id.org/roh#PatentContract</seealso>
    let PatentContract = Prefixed_Name(roh, "PatentContract") |> PrefixedName
    /// <summary>
    ///   <para>roh:PatentExpense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Patent Expense"</para></remarks>
    /// <seealso href="http://w3id.org/roh#PatentExpense">http://w3id.org/roh#PatentExpense</seealso>
    let PatentExpense = Prefixed_Name(roh, "PatentExpense") |> PrefixedName
    /// <summary>
    ///   <para>roh:PersonContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An agreement between a person and an organization to work in a project for a specified duration."</para>
    /// labels<para>"Contrat de travail"</para><para>"Contracte de treball"</para><para>"Contrato de trabajo"</para><para>"Contrato de trabalho"</para><para>"Person Contract"</para><para>"Contrato de Persona"</para></remarks>
    /// <seealso href="http://w3id.org/roh#PersonContract">http://w3id.org/roh#PersonContract</seealso>
    let PersonContract = Prefixed_Name(roh, "PersonContract") |> PrefixedName
    /// <summary>
    ///   <para>roh:PersonExpense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A ProjectExpense is carried out by a Researcher (by default the principal researcher) in charge of a Project, which indirectly links it to Funding, understood as a set of FundingAmounts. The types of expenses considered are: Personnel Expenses, Subcontracting, Travel, Equipment, Research Infrastructure and Other Goods and Services."^^rdfs:Literal"</para>
    /// labels<para>"Person Expense"</para><para>"Gasto de Persona"</para></remarks>
    /// <seealso href="http://w3id.org/roh#PersonExpense">http://w3id.org/roh#PersonExpense</seealso>
    let PersonExpense = Prefixed_Name(roh, "PersonExpense") |> PrefixedName

    /// <summary>
    ///   <para>roh:PhDSupervisingRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Relación de Supervisión de Doctorado"</para><para>"PhD Supervising Relationship"</para></remarks>
    /// <seealso href="http://w3id.org/roh#PhDSupervisingRelationship">http://w3id.org/roh#PhDSupervisingRelationship</seealso>
    let PhDSupervisingRelationship =
        Prefixed_Name(roh, "PhDSupervisingRelationship") |> PrefixedName

    /// <summary>
    ///   <para>roh:PhDThesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A thesis reporting a research project undertaken as part of an undergraduate course of education to receive a doctoral degree."</para>
    ///   <para>"A document created to summarize research findings associated with the completion of a doctoral thesis."</para>
    /// labels<para>"Doktore tesi"</para><para>"Tesi doctoral"</para><para>"Thèse doctorale"</para><para>"Tesis doctoral"</para><para>"Tese doctoral"</para><para>"PhD Thesis"</para><para>"Tesis de Doctorado"</para><para>"Doctoral thesis"</para><para>"Tese de doutoramento"</para></remarks>
    /// <seealso href="http://w3id.org/roh#PhDThesis">http://w3id.org/roh#PhDThesis</seealso>
    let PhDThesis = Prefixed_Name(roh, "PhDThesis") |> PrefixedName
    /// <summary>
    ///   <para>roh:PhDThesisMetric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"PhD Thesis Metric"</para><para>"Métrica de Tesis Doctoral"</para></remarks>
    /// <seealso href="http://w3id.org/roh#PhDThesisMetric">http://w3id.org/roh#PhDThesisMetric</seealso>
    let PhDThesisMetric = Prefixed_Name(roh, "PhDThesisMetric") |> PrefixedName
    /// <summary>
    ///   <para>roh:PressArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Press Article"</para></remarks>
    /// <seealso href="http://w3id.org/roh#PressArticle">http://w3id.org/roh#PressArticle</seealso>
    let PressArticle = Prefixed_Name(roh, "PressArticle") |> PrefixedName
    /// <summary>
    ///   <para>roh:Product</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A product as outcome of a project."</para>
    /// labels<para>"Product"</para></remarks>
    /// <seealso href="http://w3id.org/roh#Product">http://w3id.org/roh#Product</seealso>
    let Product = Prefixed_Name(roh, "Product") |> PrefixedName
    /// <summary>
    ///   <para>roh:ProformaInvoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Proforma invoice"</para></remarks>
    /// <seealso href="http://w3id.org/roh#ProformaInvoice">http://w3id.org/roh#ProformaInvoice</seealso>
    let ProformaInvoice = Prefixed_Name(roh, "ProformaInvoice") |> PrefixedName

    /// <summary>
    ///   <para>roh:ProjectClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Project Classification"</para><para>"Clasificación de Proyecto"</para></remarks>
    /// <seealso href="http://w3id.org/roh#ProjectClassification">http://w3id.org/roh#ProjectClassification</seealso>
    let ProjectClassification =
        Prefixed_Name(roh, "ProjectClassification") |> PrefixedName

    /// <summary>
    ///   <para>roh:ProjectContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An agreement among different organizations to work in a project for a specified duration."</para>
    /// labels<para>"Project Contract"</para><para>"Contrato de Proyecto"</para></remarks>
    /// <seealso href="http://w3id.org/roh#ProjectContract">http://w3id.org/roh#ProjectContract</seealso>
    let ProjectContract = Prefixed_Name(roh, "ProjectContract") |> PrefixedName
    /// <summary>
    ///   <para>roh:ProjectExpense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A ProjectExpense is carried out by a Researcher (by default the principal researcher) in charge of a Project, which indirectly links it to Funding, understood as a set of FundingAmounts. The types of expenses considered are: Personnel Expenses, Subcontracting, Travel, Equipment, Research Infrastructure and Other Goods and Services."^^&lt;http://www.w3.org/2000/01/rdf-schema#Literal&gt;</para>
    /// labels<para>"Project Expense"</para><para>"Gasto de Proyecto"</para></remarks>
    /// <seealso href="http://w3id.org/roh#ProjectExpense">http://w3id.org/roh#ProjectExpense</seealso>
    let ProjectExpense = Prefixed_Name(roh, "ProjectExpense") |> PrefixedName

    /// <summary>
    ///   <para>roh:PropertyClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Clasificación de la propiedad"</para><para>"Property Classification"</para></remarks>
    /// <seealso href="http://w3id.org/roh#PropertyClassification">http://w3id.org/roh#PropertyClassification</seealso>
    let PropertyClassification =
        Prefixed_Name(roh, "PropertyClassification") |> PrefixedName

    /// <summary>
    ///   <para>roh:ProposalSubmitted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Proposal Submitted"</para></remarks>
    /// <seealso href="http://w3id.org/roh#ProposalSubmitted">http://w3id.org/roh#ProposalSubmitted</seealso>
    let ProposalSubmitted = Prefixed_Name(roh, "ProposalSubmitted") |> PrefixedName
    /// <summary>
    ///   <para>roh:Prototype</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A product prototype"</para>
    /// labels<para>"Prototype"</para></remarks>
    /// <seealso href="http://w3id.org/roh#Prototype">http://w3id.org/roh#Prototype</seealso>
    let Prototype = Prefixed_Name(roh, "Prototype") |> PrefixedName
    /// <summary>
    ///   <para>roh:Provisional</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Provisional"</para></remarks>
    /// <seealso href="http://w3id.org/roh#Provisional">http://w3id.org/roh#Provisional</seealso>
    let Provisional = Prefixed_Name(roh, "Provisional") |> PrefixedName
    /// <summary>
    ///   <para>roh:PublicationMetric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Un artículo es citado roh:citationCount veces en la red the roh:metricName. Ejemplo: si un artículo ha sido citado 5 veces en la Web of Science, entonces los atributos roh:metricName debe ser Web Of Science y roh:citationCount 5. De este modo, una roh:metricName puede ser roh y el valor de roh:citationCount el número de veces que dicho artículo ha sido citado en el grafo de conocimiento de esta ontología."</para>
    ///   <para>"An article is cited roh:citationCount times in the roh:metricName network. Example: if an article is cited 5 times in the Web of Science, then the roh:metricName should be Web of Science and the roh:citationCount 5. Thus, a roh:metricName can be roh and the value of roh:citationCount the number of times that article has been cited in the knowledge graph of this ontology."</para>
    /// labels<para>"Publication Metric"</para><para>"Métrica de Publicación"</para></remarks>
    /// <seealso href="http://w3id.org/roh#PublicationMetric">http://w3id.org/roh#PublicationMetric</seealso>
    let PublicationMetric = Prefixed_Name(roh, "PublicationMetric") |> PrefixedName
    /// <summary>
    ///   <para>roh:README</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Documento llamado README que describe el contenido de un Repositorio."</para>
    ///   <para>"The document named README that describe the content of a concret Repository."</para>
    /// labels<para>"README"</para></remarks>
    /// <seealso href="http://w3id.org/roh#README">http://w3id.org/roh#README</seealso>
    let README = Prefixed_Name(roh, "README") |> PrefixedName
    /// <summary>
    ///   <para>roh:RadioProgram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Radio Program"</para></remarks>
    /// <seealso href="http://w3id.org/roh#RadioProgram">http://w3id.org/roh#RadioProgram</seealso>
    let RadioProgram = Prefixed_Name(roh, "RadioProgram") |> PrefixedName
    /// <summary>
    ///   <para>roh:RefundableAdvance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"RefundableAdvance"</para></remarks>
    /// <seealso href="http://w3id.org/roh#RefundableAdvance">http://w3id.org/roh#RefundableAdvance</seealso>
    let RefundableAdvance = Prefixed_Name(roh, "RefundableAdvance") |> PrefixedName
    /// <summary>
    ///   <para>roh:Rejected</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Rejected"</para></remarks>
    /// <seealso href="http://w3id.org/roh#Rejected">http://w3id.org/roh#Rejected</seealso>
    let Rejected = Prefixed_Name(roh, "Rejected") |> PrefixedName
    /// <summary>
    ///   <para>roh:Repository</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/roh#Repository">http://w3id.org/roh#Repository</seealso>
    let Repository = Prefixed_Name(roh, "Repository") |> PrefixedName

    /// <summary>
    ///   <para>roh:ResearchAccreditation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An attestation of qualification, competence, or authority issued to an individual by a third party with a relevant or  de facto authority or assumed competence to do so in the research field."</para>
    /// labels<para>"Research Accreditation"</para><para>"Acreditación de Investigación"</para></remarks>
    /// <seealso href="http://w3id.org/roh#ResearchAccreditation">http://w3id.org/roh#ResearchAccreditation</seealso>
    let ResearchAccreditation =
        Prefixed_Name(roh, "ResearchAccreditation") |> PrefixedName

    /// <summary>
    ///   <para>roh:ResearchContribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Research contribution"</para></remarks>
    /// <seealso href="http://w3id.org/roh#ResearchContribution">http://w3id.org/roh#ResearchContribution</seealso>
    let ResearchContribution =
        Prefixed_Name(roh, "ResearchContribution") |> PrefixedName

    /// <summary>
    ///   <para>roh:ResearchGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A group of researchers often from the same centre, specialised on the same subject, working together on the issue or topic."</para>
    /// labels<para>"Grupo de Investigación"</para><para>"Grup de recerca"</para><para>"Grupo de investigación"</para><para>"Grupo de investigação"</para><para>"Research group"</para><para>"Grup d'investigació"</para><para>"Research Group"</para><para>"Group de recherche"</para></remarks>
    /// <seealso href="http://w3id.org/roh#ResearchGroup">http://w3id.org/roh#ResearchGroup</seealso>
    let ResearchGroup = Prefixed_Name(roh, "ResearchGroup") |> PrefixedName
    /// <summary>
    ///   <para>roh:ResearchGroupMetric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Research Group Metric"</para></remarks>
    /// <seealso href="http://w3id.org/roh#ResearchGroupMetric">http://w3id.org/roh#ResearchGroupMetric</seealso>
    let ResearchGroupMetric = Prefixed_Name(roh, "ResearchGroupMetric") |> PrefixedName
    /// <summary>
    ///   <para>roh:ResearchInstitute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An establishment founded for doing research."</para>
    /// labels<para>"Centre de recherche"</para><para>"Centre d'investigació"</para><para>"Centre de recerca"</para><para>"Research institute"</para><para>"Centro de investigação"</para><para>"Centro de investigación"</para></remarks>
    /// <seealso href="http://w3id.org/roh#ResearchInstitute">http://w3id.org/roh#ResearchInstitute</seealso>
    let ResearchInstitute = Prefixed_Name(roh, "ResearchInstitute") |> PrefixedName
    /// <summary>
    ///   <para>roh:ResearchMaterial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Research material"</para></remarks>
    /// <seealso href="http://w3id.org/roh#ResearchMaterial">http://w3id.org/roh#ResearchMaterial</seealso>
    let ResearchMaterial = Prefixed_Name(roh, "ResearchMaterial") |> PrefixedName
    /// <summary>
    ///   <para>roh:ResearchMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Research method"</para></remarks>
    /// <seealso href="http://w3id.org/roh#ResearchMethod">http://w3id.org/roh#ResearchMethod</seealso>
    let ResearchMethod = Prefixed_Name(roh, "ResearchMethod") |> PrefixedName
    /// <summary>
    ///   <para>roh:ResearchObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A roh:ResearchObject is generated by one to several foaf:Person specified through property bibo:authorList. Usually a roh:ResearchObject results from the work in a vivo:Project (roh:produces). An elaborated taxonomy of research objects is provided, covering all types of publications, Patents, Software and Webpage. The main author of a research object is accessible through property roh:correspondingAuthor."</para>
    /// labels<para>"Research Object"</para><para>"Objecto de investigación"</para></remarks>
    /// <seealso href="http://w3id.org/roh#ResearchObject">http://w3id.org/roh#ResearchObject</seealso>
    let ResearchObject = Prefixed_Name(roh, "ResearchObject") |> PrefixedName

    /// <summary>
    ///   <para>roh:ResearchObjectExpense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Research Object Expense"</para><para>"Gasto de Objeto de Investigación"</para></remarks>
    /// <seealso href="http://w3id.org/roh#ResearchObjectExpense">http://w3id.org/roh#ResearchObjectExpense</seealso>
    let ResearchObjectExpense =
        Prefixed_Name(roh, "ResearchObjectExpense") |> PrefixedName

    /// <summary>
    ///   <para>roh:ResearchProblem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Research problem"</para></remarks>
    /// <seealso href="http://w3id.org/roh#ResearchProblem">http://w3id.org/roh#ResearchProblem</seealso>
    let ResearchProblem = Prefixed_Name(roh, "ResearchProblem") |> PrefixedName
    /// <summary>
    ///   <para>roh:ResearchResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Resultado de investigación"</para><para>"Research Result"</para></remarks>
    /// <seealso href="http://w3id.org/roh#ResearchResult">http://w3id.org/roh#ResearchResult</seealso>
    let ResearchResult = Prefixed_Name(roh, "ResearchResult") |> PrefixedName
    /// <summary>
    ///   <para>roh:ResearcherPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A member of a university or research organization focused on research task further than other ones."</para>
    /// labels<para>"Researcher Position"</para><para>"Posición de Investigador"</para></remarks>
    /// <seealso href="http://w3id.org/roh#ResearcherPosition">http://w3id.org/roh#ResearcherPosition</seealso>
    let ResearcherPosition = Prefixed_Name(roh, "ResearcherPosition") |> PrefixedName
    /// <summary>
    ///   <para>roh:Researching</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Researching"</para></remarks>
    /// <seealso href="http://w3id.org/roh#Researching">http://w3id.org/roh#Researching</seealso>
    let Researching = Prefixed_Name(roh, "Researching") |> PrefixedName
    /// <summary>
    ///   <para>roh:Reservable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Some resources may available by an organization to be used by others."</para>
    /// labels<para>"Reservable"</para></remarks>
    /// <seealso href="http://w3id.org/roh#Reservable">http://w3id.org/roh#Reservable</seealso>
    let Reservable = Prefixed_Name(roh, "Reservable") |> PrefixedName

    /// <summary>
    ///   <para>roh:ReservableConsumerRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ReservableConsumerRole"</para></remarks>
    /// <seealso href="http://w3id.org/roh#ReservableConsumerRole">http://w3id.org/roh#ReservableConsumerRole</seealso>
    let ReservableConsumerRole =
        Prefixed_Name(roh, "ReservableConsumerRole") |> PrefixedName

    /// <summary>
    ///   <para>roh:ReservableProviderRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ReservableProviderRole"</para></remarks>
    /// <seealso href="http://w3id.org/roh#ReservableProviderRole">http://w3id.org/roh#ReservableProviderRole</seealso>
    let ReservableProviderRole =
        Prefixed_Name(roh, "ReservableProviderRole") |> PrefixedName

    /// <summary>
    ///   <para>roh:ReservableSoftware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Software that is reservable."</para>
    ///   <para>"Esta entidad denota el Software que es reservable."</para>
    /// labels<para>"Reservable Software"</para><para>"Software Reservable"</para></remarks>
    /// <seealso href="http://w3id.org/roh#ReservableSoftware">http://w3id.org/roh#ReservableSoftware</seealso>
    let ReservableSoftware = Prefixed_Name(roh, "ReservableSoftware") |> PrefixedName

    /// <summary>
    ///   <para>roh:ReservationRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Reservation Relationship"</para></remarks>
    /// <seealso href="http://w3id.org/roh#ReservationRelationship">http://w3id.org/roh#ReservationRelationship</seealso>
    let ReservationRelationship =
        Prefixed_Name(roh, "ReservationRelationship") |> PrefixedName

    /// <summary>
    ///   <para>roh:RoundTable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Round Table"</para></remarks>
    /// <seealso href="http://w3id.org/roh#RoundTable">http://w3id.org/roh#RoundTable</seealso>
    let RoundTable = Prefixed_Name(roh, "RoundTable") |> PrefixedName
    /// <summary>
    ///   <para>roh:SealOfQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A graphic mark indicating highest levels of quality in research, often measured in terms of relevant publications related to the researching activity."</para>
    /// labels<para>"Selo de qualidade"</para><para>"Label qualité"</para><para>"Seal of quality"</para><para>"Sello de calidad"</para><para>"Segell de qualitat"</para></remarks>
    /// <seealso href="http://w3id.org/roh#SealOfQuality">http://w3id.org/roh#SealOfQuality</seealso>
    let SealOfQuality = Prefixed_Name(roh, "SealOfQuality") |> PrefixedName
    /// <summary>
    ///   <para>roh:ServiceContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Contrato de servicio"</para><para>"Contrat de service"</para><para>"Contracte de servei"</para><para>"Contrato de serviço"</para><para>"Service contract"</para></remarks>
    /// <seealso href="http://w3id.org/roh#ServiceContract">http://w3id.org/roh#ServiceContract</seealso>
    let ServiceContract = Prefixed_Name(roh, "ServiceContract") |> PrefixedName
    /// <summary>
    ///   <para>roh:Signed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Signed"</para></remarks>
    /// <seealso href="http://w3id.org/roh#Signed">http://w3id.org/roh#Signed</seealso>
    let Signed = Prefixed_Name(roh, "Signed") |> PrefixedName
    /// <summary>
    ///   <para>roh:SmallEnterprise</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An enterprise which employs fewer than 50 persons and whose annual turnover and/or annual balance sheet total does not exceed EUR 10 million."</para>
    /// labels<para>"Small Enterprise"</para></remarks>
    /// <seealso href="http://w3id.org/roh#SmallEnterprise">http://w3id.org/roh#SmallEnterprise</seealso>
    let SmallEnterprise = Prefixed_Name(roh, "SmallEnterprise") |> PrefixedName
    /// <summary>
    ///   <para>roh:Status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Status"</para></remarks>
    /// <seealso href="http://w3id.org/roh#Status">http://w3id.org/roh#Status</seealso>
    let Status = Prefixed_Name(roh, "Status") |> PrefixedName
    /// <summary>
    ///   <para>roh:Submitted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Submitted"</para></remarks>
    /// <seealso href="http://w3id.org/roh#Submitted">http://w3id.org/roh#Submitted</seealso>
    let Submitted = Prefixed_Name(roh, "Submitted") |> PrefixedName
    /// <summary>
    ///   <para>roh:SuperviseeRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Rol de Supervisado"</para><para>"Supervisee Role"</para></remarks>
    /// <seealso href="http://w3id.org/roh#SuperviseeRole">http://w3id.org/roh#SuperviseeRole</seealso>
    let SuperviseeRole = Prefixed_Name(roh, "SuperviseeRole") |> PrefixedName

    /// <summary>
    ///   <para>roh:SupervisingRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Relación de Supervisión"</para><para>"Supervising Relationship"</para></remarks>
    /// <seealso href="http://w3id.org/roh#SupervisingRelationship">http://w3id.org/roh#SupervisingRelationship</seealso>
    let SupervisingRelationship =
        Prefixed_Name(roh, "SupervisingRelationship") |> PrefixedName

    /// <summary>
    ///   <para>roh:SupervisorRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Rol de Supervisor"</para><para>"Supervisor Role"</para></remarks>
    /// <seealso href="http://w3id.org/roh#SupervisorRole">http://w3id.org/roh#SupervisorRole</seealso>
    let SupervisorRole = Prefixed_Name(roh, "SupervisorRole") |> PrefixedName
    /// <summary>
    ///   <para>roh:Teaching</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Teaching"</para></remarks>
    /// <seealso href="http://w3id.org/roh#Teaching">http://w3id.org/roh#Teaching</seealso>
    let Teaching = Prefixed_Name(roh, "Teaching") |> PrefixedName
    /// <summary>
    ///   <para>roh:TechnicalReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Technical report"</para></remarks>
    /// <seealso href="http://w3id.org/roh#TechnicalReport">http://w3id.org/roh#TechnicalReport</seealso>
    let TechnicalReport = Prefixed_Name(roh, "TechnicalReport") |> PrefixedName
    /// <summary>
    ///   <para>roh:TechnicalSupport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"TechnicalSupport"</para></remarks>
    /// <seealso href="http://w3id.org/roh#TechnicalSupport">http://w3id.org/roh#TechnicalSupport</seealso>
    let TechnicalSupport = Prefixed_Name(roh, "TechnicalSupport") |> PrefixedName
    /// <summary>
    ///   <para>roh:Terminated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Terminated"</para></remarks>
    /// <seealso href="http://w3id.org/roh#Terminated">http://w3id.org/roh#Terminated</seealso>
    let Terminated = Prefixed_Name(roh, "Terminated") |> PrefixedName

    /// <summary>
    ///   <para>roh:TestAnotherGovernmentAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>&lt;http://w3id.org/roh/mirror/vivo#GovernmentAgency&gt;</para>
    ///
    /// labels<para>"TestAnotherGovernmentAgency"</para></remarks>
    /// <seealso href="http://w3id.org/roh#TestAnotherGovernmentAgency">http://w3id.org/roh#TestAnotherGovernmentAgency</seealso>
    let TestAnotherGovernmentAgency =
        Prefixed_Name(roh, "TestAnotherGovernmentAgency") |> PrefixedName

    /// <summary>
    ///   <para>roh:TestBook</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>&lt;http://w3id.org/roh/mirror/bibo#Book&gt;</para>
    ///
    /// labels<para>"TestBook"</para></remarks>
    /// <seealso href="http://w3id.org/roh#TestBook">http://w3id.org/roh#TestBook</seealso>
    let TestBook = Prefixed_Name(roh, "TestBook") |> PrefixedName
    /// <summary>
    ///   <para>roh:TestChapterOne</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://w3id.org/roh/mirror/bibo#Chapter&gt;</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"TestChapterOne"</para></remarks>
    /// <seealso href="http://w3id.org/roh#TestChapterOne">http://w3id.org/roh#TestChapterOne</seealso>
    let TestChapterOne = Prefixed_Name(roh, "TestChapterOne") |> PrefixedName
    /// <summary>
    ///   <para>roh:TestChapterThree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>&lt;http://w3id.org/roh/mirror/bibo#Chapter&gt;</para>
    ///
    /// labels<para>"TestChapterThree"</para></remarks>
    /// <seealso href="http://w3id.org/roh#TestChapterThree">http://w3id.org/roh#TestChapterThree</seealso>
    let TestChapterThree = Prefixed_Name(roh, "TestChapterThree") |> PrefixedName
    /// <summary>
    ///   <para>roh:TestChapterTwo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>&lt;http://w3id.org/roh/mirror/bibo#Chapter&gt;</para>
    ///
    /// labels<para>"TestChapterTwo"</para></remarks>
    /// <seealso href="http://w3id.org/roh#TestChapterTwo">http://w3id.org/roh#TestChapterTwo</seealso>
    let TestChapterTwo = Prefixed_Name(roh, "TestChapterTwo") |> PrefixedName

    /// <summary>
    ///   <para>roh:TestCoSupervisorRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>roh:SupervisorRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"TestCoSupervisorRole"</para></remarks>
    /// <seealso href="http://w3id.org/roh#TestCoSupervisorRole">http://w3id.org/roh#TestCoSupervisorRole</seealso>
    let TestCoSupervisorRole =
        Prefixed_Name(roh, "TestCoSupervisorRole") |> PrefixedName

    /// <summary>
    ///   <para>roh:TestDateTimeInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://w3id.org/roh/mirror/vivo#DateTimeInterval&gt;</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"TestDateTimeInterval"</para></remarks>
    /// <seealso href="http://w3id.org/roh#TestDateTimeInterval">http://w3id.org/roh#TestDateTimeInterval</seealso>
    let TestDateTimeInterval =
        Prefixed_Name(roh, "TestDateTimeInterval") |> PrefixedName

    /// <summary>
    ///   <para>roh:TestEndDateTimeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://w3id.org/roh/mirror/vivo#DateTimeValue&gt;</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"TestEndDateTimeValue"</para></remarks>
    /// <seealso href="http://w3id.org/roh#TestEndDateTimeValue">http://w3id.org/roh#TestEndDateTimeValue</seealso>
    let TestEndDateTimeValue =
        Prefixed_Name(roh, "TestEndDateTimeValue") |> PrefixedName

    /// <summary>
    ///   <para>roh:TestFundingProgram</para>
    /// </summary>
    /// <remarks>
    ///   <para>roh:FundingProgram</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"TestFundingProgram"</para></remarks>
    /// <seealso href="http://w3id.org/roh#TestFundingProgram">http://w3id.org/roh#TestFundingProgram</seealso>
    let TestFundingProgram = Prefixed_Name(roh, "TestFundingProgram") |> PrefixedName
    /// <summary>
    ///   <para>roh:TestFundingSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>roh:FundingSource</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"TestFundingSource"</para></remarks>
    /// <seealso href="http://w3id.org/roh#TestFundingSource">http://w3id.org/roh#TestFundingSource</seealso>
    let TestFundingSource = Prefixed_Name(roh, "TestFundingSource") |> PrefixedName

    /// <summary>
    ///   <para>roh:TestGovernmentAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>&lt;http://w3id.org/roh/mirror/vivo#GovernmentAgency&gt;</para>
    ///
    /// labels<para>"TestGovernmentAgency"</para></remarks>
    /// <seealso href="http://w3id.org/roh#TestGovernmentAgency">http://w3id.org/roh#TestGovernmentAgency</seealso>
    let TestGovernmentAgency =
        Prefixed_Name(roh, "TestGovernmentAgency") |> PrefixedName

    /// <summary>
    ///   <para>roh:TestListofAuthors</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Seq</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"TestListofAuthors"</para></remarks>
    /// <seealso href="http://w3id.org/roh#TestListofAuthors">http://w3id.org/roh#TestListofAuthors</seealso>
    let TestListofAuthors = Prefixed_Name(roh, "TestListofAuthors") |> PrefixedName
    /// <summary>
    ///   <para>roh:TestListofEditors</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Seq</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"TestListofEditors"</para></remarks>
    /// <seealso href="http://w3id.org/roh#TestListofEditors">http://w3id.org/roh#TestListofEditors</seealso>
    let TestListofEditors = Prefixed_Name(roh, "TestListofEditors") |> PrefixedName

    /// <summary>
    ///   <para>roh:TestNonResearchSoftware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>&lt;http://w3id.org/roh/mirror/obo/ero#ERO_0000071&gt;</para>
    ///   <para>roh:Reservable</para>
    ///
    /// labels<para>"TestNonResearchSoftware"</para></remarks>
    /// <seealso href="http://w3id.org/roh#TestNonResearchSoftware">http://w3id.org/roh#TestNonResearchSoftware</seealso>
    let TestNonResearchSoftware =
        Prefixed_Name(roh, "TestNonResearchSoftware") |> PrefixedName

    /// <summary>
    ///   <para>roh:TestOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://w3id.org/roh/mirror/foaf#Organization&gt;</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"TestOrganization"</para></remarks>
    /// <seealso href="http://w3id.org/roh#TestOrganization">http://w3id.org/roh#TestOrganization</seealso>
    let TestOrganization = Prefixed_Name(roh, "TestOrganization") |> PrefixedName
    /// <summary>
    ///   <para>roh:TestPhDStudent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>&lt;http://w3id.org/roh/mirror/foaf#Person&gt;</para>
    ///
    /// labels<para>"TestPhDStudent"</para></remarks>
    /// <seealso href="http://w3id.org/roh#TestPhDStudent">http://w3id.org/roh#TestPhDStudent</seealso>
    let TestPhDStudent = Prefixed_Name(roh, "TestPhDStudent") |> PrefixedName

    /// <summary>
    ///   <para>roh:TestPhDSupervisingRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>roh:PhDSupervisingRelationship</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"TestPhDSupervisingRelationship"</para></remarks>
    /// <seealso href="http://w3id.org/roh#TestPhDSupervisingRelationship">http://w3id.org/roh#TestPhDSupervisingRelationship</seealso>
    let TestPhDSupervisingRelationship =
        Prefixed_Name(roh, "TestPhDSupervisingRelationship") |> PrefixedName

    /// <summary>
    ///   <para>roh:TestPhdCoSupervisor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>&lt;http://w3id.org/roh/mirror/foaf#Person&gt;</para>
    ///
    /// labels<para>"TestPhdCoSupervisor"</para></remarks>
    /// <seealso href="http://w3id.org/roh#TestPhdCoSupervisor">http://w3id.org/roh#TestPhdCoSupervisor</seealso>
    let TestPhdCoSupervisor = Prefixed_Name(roh, "TestPhdCoSupervisor") |> PrefixedName
    /// <summary>
    ///   <para>roh:TestPhdSupervisor</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://w3id.org/roh/mirror/foaf#Person&gt;</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"TestPhdSupervisor"</para></remarks>
    /// <seealso href="http://w3id.org/roh#TestPhdSupervisor">http://w3id.org/roh#TestPhdSupervisor</seealso>
    let TestPhdSupervisor = Prefixed_Name(roh, "TestPhdSupervisor") |> PrefixedName
    /// <summary>
    ///   <para>roh:TestProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>&lt;http://w3id.org/roh/mirror/vivo#Project&gt;</para>
    ///
    /// labels<para>"TestProject"</para></remarks>
    /// <seealso href="http://w3id.org/roh#TestProject">http://w3id.org/roh#TestProject</seealso>
    let TestProject = Prefixed_Name(roh, "TestProject") |> PrefixedName

    /// <summary>
    ///   <para>roh:TestStartDateTimeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>&lt;http://w3id.org/roh/mirror/vivo#DateTimeValue&gt;</para>
    ///
    /// labels<para>"TestStartDateTimeValue"</para></remarks>
    /// <seealso href="http://w3id.org/roh#TestStartDateTimeValue">http://w3id.org/roh#TestStartDateTimeValue</seealso>
    let TestStartDateTimeValue =
        Prefixed_Name(roh, "TestStartDateTimeValue") |> PrefixedName

    /// <summary>
    ///   <para>roh:TestSuperviseeRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>roh:SuperviseeRole</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"TestSuperviseeRole"</para></remarks>
    /// <seealso href="http://w3id.org/roh#TestSuperviseeRole">http://w3id.org/roh#TestSuperviseeRole</seealso>
    let TestSuperviseeRole = Prefixed_Name(roh, "TestSuperviseeRole") |> PrefixedName
    /// <summary>
    ///   <para>roh:TestSupervisorRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>roh:SupervisorRole</para>
    ///
    /// labels<para>"TestSupervisorRole"</para></remarks>
    /// <seealso href="http://w3id.org/roh#TestSupervisorRole">http://w3id.org/roh#TestSupervisorRole</seealso>
    let TestSupervisorRole = Prefixed_Name(roh, "TestSupervisorRole") |> PrefixedName
    /// <summary>
    ///   <para>roh:ThesisMetric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Métrica de Tesis"</para><para>"Thesis Metric"</para></remarks>
    /// <seealso href="http://w3id.org/roh#ThesisMetric">http://w3id.org/roh#ThesisMetric</seealso>
    let ThesisMetric = Prefixed_Name(roh, "ThesisMetric") |> PrefixedName
    /// <summary>
    ///   <para>roh:ThesisViva</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An oral examination in which a PhD Student defends her/his doctoral thesis."</para>
    /// labels<para>"Defensa de Tesis"</para><para>"Thesis Viva"</para></remarks>
    /// <seealso href="http://w3id.org/roh#ThesisViva">http://w3id.org/roh#ThesisViva</seealso>
    let ThesisViva = Prefixed_Name(roh, "ThesisViva") |> PrefixedName

    /// <summary>
    ///   <para>roh:ThirdPartyContractorRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A role of contracting someone to perform a job."</para>
    /// labels<para>"Third Party Contractor Role"</para><para>"Rol de Contración de Tercera Parte"</para></remarks>
    /// <seealso href="http://w3id.org/roh#ThirdPartyContractorRole">http://w3id.org/roh#ThirdPartyContractorRole</seealso>
    let ThirdPartyContractorRole =
        Prefixed_Name(roh, "ThirdPartyContractorRole") |> PrefixedName

    /// <summary>
    ///   <para>roh:TvProgram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Tv Program"</para></remarks>
    /// <seealso href="http://w3id.org/roh#TvProgram">http://w3id.org/roh#TvProgram</seealso>
    let TvProgram = Prefixed_Name(roh, "TvProgram") |> PrefixedName

    /// <summary>
    ///   <para>roh:UndergraduateStudent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"UndergraduateStudent"</para></remarks>
    /// <seealso href="http://w3id.org/roh#UndergraduateStudent">http://w3id.org/roh#UndergraduateStudent</seealso>
    let UndergraduateStudent =
        Prefixed_Name(roh, "UndergraduateStudent") |> PrefixedName

    /// <summary>
    ///   <para>roh:Unfunded</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Unfunded"</para></remarks>
    /// <seealso href="http://w3id.org/roh#Unfunded">http://w3id.org/roh#Unfunded</seealso>
    let Unfunded = Prefixed_Name(roh, "Unfunded") |> PrefixedName
    /// <summary>
    ///   <para>roh:UniversityDivision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A division within a university (school, faculty, etc.)"</para>
    /// labels<para>"Divisió d'universitat"</para><para>"Division d'université"</para><para>"División de universidad"</para><para>"División de universidade"</para><para>"University division"</para><para>"Divisão de universidade"</para></remarks>
    /// <seealso href="http://w3id.org/roh#UniversityDivision">http://w3id.org/roh#UniversityDivision</seealso>
    let UniversityDivision = Prefixed_Name(roh, "UniversityDivision") |> PrefixedName
    /// <summary>
    ///   <para>roh:WorkshopPaper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A paper published on a conference workshop."</para>
    /// labels<para>"Workshop Paper"</para><para>"Artículo de Seminario"</para></remarks>
    /// <seealso href="http://w3id.org/roh#WorkshopPaper">http://w3id.org/roh#WorkshopPaper</seealso>
    let WorkshopPaper = Prefixed_Name(roh, "WorkshopPaper") |> PrefixedName
    /// <summary>
    ///   <para>roh:ZenodoRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Es un repositorio de Zenodo que podemos encontrar en https://zenodo.org."</para>
    ///   <para>"It`s a Zenodo Repository that we can find in https://zenodo.org."</para>
    /// labels<para>"Repositorio de Zenodo"</para><para>"Zenodo Repository"</para></remarks>
    /// <seealso href="http://w3id.org/roh#ZenodoRepository">http://w3id.org/roh#ZenodoRepository</seealso>
    let ZenodoRepository = Prefixed_Name(roh, "ZenodoRepository") |> PrefixedName
    /// <summary>
    ///   <para>roh:accreditationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An object property linking an Accreditation to the Agent is associated with."</para>
    /// labels<para>"acreditación de"</para><para>"accreditation of"</para></remarks>
    /// <seealso href="http://w3id.org/roh#accreditationOf">http://w3id.org/roh#accreditationOf</seealso>
    let accreditationOf = Prefixed_Name(roh, "accreditationOf") |> PrefixedName
    /// <summary>
    ///   <para>roh:addresses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"addresses"</para></remarks>
    /// <seealso href="http://w3id.org/roh#addresses">http://w3id.org/roh#addresses</seealso>
    let addresses = Prefixed_Name(roh, "addresses") |> PrefixedName
    /// <summary>
    ///   <para>roh:advises</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"advises"</para></remarks>
    /// <seealso href="http://w3id.org/roh#advises">http://w3id.org/roh#advises</seealso>
    let advises = Prefixed_Name(roh, "advises") |> PrefixedName
    /// <summary>
    ///   <para>roh:associatedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>"an organisation (i.e. university) is associated with another organsiation (i.e. research institute)."</para>
    /// labels<para>"associated with"</para></remarks>
    /// <seealso href="http://w3id.org/roh#associatedWith">http://w3id.org/roh#associatedWith</seealso>
    let associatedWith = Prefixed_Name(roh, "associatedWith") |> PrefixedName
    /// <summary>
    ///   <para>roh:attachment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An object property describing a not machine-readable document attached to an entity offering more detailed information."</para>
    /// labels<para>"attachment"</para><para>"adjunto"</para></remarks>
    /// <seealso href="http://w3id.org/roh#attachment">http://w3id.org/roh#attachment</seealso>
    let attachment = Prefixed_Name(roh, "attachment") |> PrefixedName
    /// <summary>
    ///   <para>roh:authors</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"authors"</para></remarks>
    /// <seealso href="http://w3id.org/roh#authors">http://w3id.org/roh#authors</seealso>
    let authors = Prefixed_Name(roh, "authors") |> PrefixedName
    /// <summary>
    ///   <para>roh:awardedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An object property linking an AwardedDegree to the University that awarded it."</para>
    /// labels<para>"concedido por"</para><para>"awarded by"</para></remarks>
    /// <seealso href="http://w3id.org/roh#awardedBy">http://w3id.org/roh#awardedBy</seealso>
    let awardedBy = Prefixed_Name(roh, "awardedBy") |> PrefixedName
    /// <summary>
    ///   <para>roh:awardedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"awarded with"</para></remarks>
    /// <seealso href="http://w3id.org/roh#awardedWith">http://w3id.org/roh#awardedWith</seealso>
    let awardedWith = Prefixed_Name(roh, "awardedWith") |> PrefixedName
    /// <summary>
    ///   <para>roh:awards</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An object property linking the University awarding a degree to the AwardedDegree."</para>
    /// labels<para>"concede"</para><para>"awards"</para></remarks>
    /// <seealso href="http://w3id.org/roh#awards">http://w3id.org/roh#awards</seealso>
    let awards = Prefixed_Name(roh, "awards") |> PrefixedName
    /// <summary>
    ///   <para>roh:birthdate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The birthdate of an Entity."</para>
    /// labels<para>"birthdate"</para><para>"fecha de nacimiento"</para></remarks>
    /// <seealso href="http://w3id.org/roh#birthdate">http://w3id.org/roh#birthdate</seealso>
    let birthdate = Prefixed_Name(roh, "birthdate") |> PrefixedName
    /// <summary>
    ///   <para>roh:citationCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the number of times a publication has been cited (when used in PublicationMetric) or the total number of citations for all of an author's works (when used in AuthorMetric)"</para>
    /// labels<para>"citation count"</para></remarks>
    /// <seealso href="http://w3id.org/roh#citationCount">http://w3id.org/roh#citationCount</seealso>
    let citationCount = Prefixed_Name(roh, "citationCount") |> PrefixedName
    /// <summary>
    ///   <para>roh:coadvisedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An academic publication (bachelor's thesis, master's thesis or doctoral thesis) is co-advised by an advisor."</para>
    /// labels<para>"co-advised by"</para></remarks>
    /// <seealso href="http://w3id.org/roh#coadvisedBy">http://w3id.org/roh#coadvisedBy</seealso>
    let coadvisedBy = Prefixed_Name(roh, "coadvisedBy") |> PrefixedName
    /// <summary>
    ///   <para>roh:coadvises</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A person co-advises an academic publication (bachelor's thesis, master's thesis or doctoral thesis)."</para>
    /// labels<para>"co-advises"</para></remarks>
    /// <seealso href="http://w3id.org/roh#coadvises">http://w3id.org/roh#coadvises</seealso>
    let coadvises = Prefixed_Name(roh, "coadvises") |> PrefixedName
    /// <summary>
    ///   <para>roh:codeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A code is assigned to a concept."</para>
    /// labels<para>"code of"</para></remarks>
    /// <seealso href="http://w3id.org/roh#codeOf">http://w3id.org/roh#codeOf</seealso>
    let codeOf = Prefixed_Name(roh, "codeOf") |> PrefixedName
    /// <summary>
    ///   <para>roh:companyFounder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"company founder"</para></remarks>
    /// <seealso href="http://w3id.org/roh#companyFounder">http://w3id.org/roh#companyFounder</seealso>
    let companyFounder = Prefixed_Name(roh, "companyFounder") |> PrefixedName
    /// <summary>
    ///   <para>roh:contactInfoOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the contact info of type vcard:Kind for an Agent."</para>
    /// labels<para>"contact info of"</para><para>"información de contacto de"</para></remarks>
    /// <seealso href="http://w3id.org/roh#contactInfoOf">http://w3id.org/roh#contactInfoOf</seealso>
    let contactInfoOf = Prefixed_Name(roh, "contactInfoOf") |> PrefixedName
    /// <summary>
    ///   <para>roh:contractOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An object property linking a Contract to an Entity."</para>
    /// labels<para>"contrato de"</para><para>"contract of"</para></remarks>
    /// <seealso href="http://w3id.org/roh#contractOf">http://w3id.org/roh#contractOf</seealso>
    let contractOf = Prefixed_Name(roh, "contractOf") |> PrefixedName
    /// <summary>
    ///   <para>roh:contractSigningDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An object property linking a Contract with the date (DateTimeValue) when it was signed."</para>
    /// labels<para>"contract signing date"</para><para>"fecha de firma del contrato"</para></remarks>
    /// <seealso href="http://w3id.org/roh#contractSigningDate">http://w3id.org/roh#contractSigningDate</seealso>
    let contractSigningDate = Prefixed_Name(roh, "contractSigningDate") |> PrefixedName

    /// <summary>
    ///   <para>roh:contractSigningDateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An object property linking a signing date (DateTimeValue) with a Contract."</para>
    /// labels<para>"fecha de firma asociada a contrato"</para><para>"contract signing date of"</para></remarks>
    /// <seealso href="http://w3id.org/roh#contractSigningDateOf">http://w3id.org/roh#contractSigningDateOf</seealso>
    let contractSigningDateOf =
        Prefixed_Name(roh, "contractSigningDateOf") |> PrefixedName

    /// <summary>
    ///   <para>roh:coordinatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"inverse property of 'project coordinator'"</para>
    /// labels<para>"coordinated by"</para></remarks>
    /// <seealso href="http://w3id.org/roh#coordinatedBy">http://w3id.org/roh#coordinatedBy</seealso>
    let coordinatedBy = Prefixed_Name(roh, "coordinatedBy") |> PrefixedName
    /// <summary>
    ///   <para>roh:correspondingAuthor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An object property linking an Entity to a Person, considered the author of such Thing."</para>
    /// labels<para>"autor de correspondencia"</para><para>"corresponding author"</para></remarks>
    /// <seealso href="http://w3id.org/roh#correspondingAuthor">http://w3id.org/roh#correspondingAuthor</seealso>
    let correspondingAuthor = Prefixed_Name(roh, "correspondingAuthor") |> PrefixedName

    /// <summary>
    ///   <para>roh:correspondingAuthorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An object property linking a Person with a Thing, such person is corresponding author for."</para>
    /// labels<para>"autor de correspondencia de"</para><para>"corresponding author of"</para></remarks>
    /// <seealso href="http://w3id.org/roh#correspondingAuthorOf">http://w3id.org/roh#correspondingAuthorOf</seealso>
    let correspondingAuthorOf =
        Prefixed_Name(roh, "correspondingAuthorOf") |> PrefixedName

    /// <summary>
    ///   <para>roh:correspondingOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"correspondingOrganization"</para></remarks>
    /// <seealso href="http://w3id.org/roh#correspondingOrganization">http://w3id.org/roh#correspondingOrganization</seealso>
    let correspondingOrganization =
        Prefixed_Name(roh, "correspondingOrganization") |> PrefixedName

    /// <summary>
    ///   <para>roh:correspondingOrganizationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"correspondingOrganizationOf"</para></remarks>
    /// <seealso href="http://w3id.org/roh#correspondingOrganizationOf">http://w3id.org/roh#correspondingOrganizationOf</seealso>
    let correspondingOrganizationOf =
        Prefixed_Name(roh, "correspondingOrganizationOf") |> PrefixedName

    /// <summary>
    ///   <para>roh:country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property indicates the nationality of a resource. The domain is not set so unpredicted resources within the ontology could be attached to countries."</para>
    /// labels<para>"país"</para><para>"country"</para></remarks>
    /// <seealso href="http://w3id.org/roh#country">http://w3id.org/roh#country</seealso>
    let country = Prefixed_Name(roh, "country") |> PrefixedName
    /// <summary>
    ///   <para>roh:courseHours</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The number of hours a course lasts."</para>
    /// labels<para>"course hours"</para><para>"horas lectivas"</para></remarks>
    /// <seealso href="http://w3id.org/roh#courseHours">http://w3id.org/roh#courseHours</seealso>
    let courseHours = Prefixed_Name(roh, "courseHours") |> PrefixedName
    /// <summary>
    ///   <para>roh:cumLaude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Meaning "with praise", used to indicate the level of distinction with which an academic degree has been earned."</para>
    /// labels<para>"cum laude"</para></remarks>
    /// <seealso href="http://w3id.org/roh#cumLaude">http://w3id.org/roh#cumLaude</seealso>
    let cumLaude = Prefixed_Name(roh, "cumLaude") |> PrefixedName
    /// <summary>
    ///   <para>roh:currency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Data property used by roh:Funding and roh:FundingAmount"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"moneda"</para><para>"currency"</para></remarks>
    /// <seealso href="http://w3id.org/roh#currency">http://w3id.org/roh#currency</seealso>
    let currency = Prefixed_Name(roh, "currency") |> PrefixedName
    /// <summary>
    ///   <para>roh:dedication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"The dedication which a Person dedicates to a Role."</para>
    /// labels<para>"dedication"</para><para>"dedicación"</para></remarks>
    /// <seealso href="http://w3id.org/roh#dedication">http://w3id.org/roh#dedication</seealso>
    let dedication = Prefixed_Name(roh, "dedication") |> PrefixedName

    /// <summary>
    ///   <para>roh:dedicationPercentage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"dedication percentage"</para></remarks>
    /// <seealso href="http://w3id.org/roh#dedicationPercentage">http://w3id.org/roh#dedicationPercentage</seealso>
    let dedicationPercentage =
        Prefixed_Name(roh, "dedicationPercentage") |> PrefixedName

    /// <summary>
    ///   <para>roh:documentStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The status of a Document (Accepted or Rejected)."</para>
    /// labels<para>"estado del documento"</para><para>"document status"</para></remarks>
    /// <seealso href="http://w3id.org/roh#documentStatus">http://w3id.org/roh#documentStatus</seealso>
    let documentStatus = Prefixed_Name(roh, "documentStatus") |> PrefixedName
    /// <summary>
    ///   <para>roh:employs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"employs"</para><para>"emplea"</para></remarks>
    /// <seealso href="http://w3id.org/roh#employs">http://w3id.org/roh#employs</seealso>
    let employs = Prefixed_Name(roh, "employs") |> PrefixedName
    /// <summary>
    ///   <para>roh:evaluationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The status in which a Evaluation Summary could be."</para>
    /// labels<para>"evaluation status"</para><para>"estado de la evaluación"</para></remarks>
    /// <seealso href="http://w3id.org/roh#evaluationStatus">http://w3id.org/roh#evaluationStatus</seealso>
    let evaluationStatus = Prefixed_Name(roh, "evaluationStatus") |> PrefixedName
    /// <summary>
    ///   <para>roh:excellenceLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Represents if an Entity has an excellence label or some kind of mention."</para>
    /// labels<para>"sello de excelencia"</para><para>"excellence label"</para></remarks>
    /// <seealso href="http://w3id.org/roh#excellenceLabel">http://w3id.org/roh#excellenceLabel</seealso>
    let excellenceLabel = Prefixed_Name(roh, "excellenceLabel") |> PrefixedName
    /// <summary>
    ///   <para>roh:expenseModality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A free text property to represent the modality of an Expense."</para>
    /// labels<para>"modalidad de gasto"</para><para>"expense modality"</para></remarks>
    /// <seealso href="http://w3id.org/roh#expenseModality">http://w3id.org/roh#expenseModality</seealso>
    let expenseModality = Prefixed_Name(roh, "expenseModality") |> PrefixedName
    /// <summary>
    ///   <para>roh:expirationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"expiration date"</para></remarks>
    /// <seealso href="http://w3id.org/roh#expirationDate">http://w3id.org/roh#expirationDate</seealso>
    let expirationDate = Prefixed_Name(roh, "expirationDate") |> PrefixedName

    /// <summary>
    ///   <para>roh:foreseenJustificationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The date in which a Justificacion has to be delivered."</para>
    /// labels<para>"fecha de justificación prevista"</para><para>"foreseen justification date"</para></remarks>
    /// <seealso href="http://w3id.org/roh#foreseenJustificationDate">http://w3id.org/roh#foreseenJustificationDate</seealso>
    let foreseenJustificationDate =
        Prefixed_Name(roh, "foreseenJustificationDate") |> PrefixedName

    /// <summary>
    ///   <para>roh:foundationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Date in which an Organization was created."</para>
    /// labels<para>"fecha de fundación"</para><para>"foundation date"</para></remarks>
    /// <seealso href="http://w3id.org/roh#foundationDate">http://w3id.org/roh#foundationDate</seealso>
    let foundationDate = Prefixed_Name(roh, "foundationDate") |> PrefixedName
    /// <summary>
    ///   <para>roh:freeOrPaid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"gratuito o de pago"</para><para>"free or paid"</para></remarks>
    /// <seealso href="http://w3id.org/roh#freeOrPaid">http://w3id.org/roh#freeOrPaid</seealso>
    let freeOrPaid = Prefixed_Name(roh, "freeOrPaid") |> PrefixedName
    /// <summary>
    ///   <para>roh:fundedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An object property linking a Thing when is funded by another Thing."</para>
    /// labels<para>"financiado por"</para><para>"fundedBy"</para></remarks>
    /// <seealso href="http://w3id.org/roh#fundedBy">http://w3id.org/roh#fundedBy</seealso>
    let fundedBy = Prefixed_Name(roh, "fundedBy") |> PrefixedName
    /// <summary>
    ///   <para>roh:funds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An object property linking a Thing when it funds another Thing."</para>
    /// labels<para>"financia"</para><para>"funds"</para></remarks>
    /// <seealso href="http://w3id.org/roh#funds">http://w3id.org/roh#funds</seealso>
    let funds = Prefixed_Name(roh, "funds") |> PrefixedName
    /// <summary>
    ///   <para>roh:grantedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An object property linking an Organization with a FundingAmount."</para>
    /// labels<para>"concedido por"</para><para>"granted by"</para></remarks>
    /// <seealso href="http://w3id.org/roh#grantedBy">http://w3id.org/roh#grantedBy</seealso>
    let grantedBy = Prefixed_Name(roh, "grantedBy") |> PrefixedName
    /// <summary>
    ///   <para>roh:grants</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An object property linking a FundingAmount with an Organization."</para>
    /// labels<para>"grants"</para><para>"concede a"</para></remarks>
    /// <seealso href="http://w3id.org/roh#grants">http://w3id.org/roh#grants</seealso>
    let grants = Prefixed_Name(roh, "grants") |> PrefixedName
    /// <summary>
    ///   <para>roh:h-index</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"h-index"</para></remarks>
    /// <seealso href="http://w3id.org/roh#h-index">http://w3id.org/roh#h-index</seealso>
    let h_index = Prefixed_Name(roh, "h-index") |> PrefixedName
    /// <summary>
    ///   <para>roh:hasAccreditation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An object property linking an Agent with an Accreditation it posseses."</para>
    /// labels<para>"has accreditation"</para><para>"tiene acreditación"</para></remarks>
    /// <seealso href="http://w3id.org/roh#hasAccreditation">http://w3id.org/roh#hasAccreditation</seealso>
    let hasAccreditation = Prefixed_Name(roh, "hasAccreditation") |> PrefixedName
    /// <summary>
    ///   <para>roh:hasCV</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An object property linking a Person with her CV."</para>
    /// labels<para>"has CV"</para><para>"tiene CV"</para></remarks>
    /// <seealso href="http://w3id.org/roh#hasCV">http://w3id.org/roh#hasCV</seealso>
    let hasCV = Prefixed_Name(roh, "hasCV") |> PrefixedName
    /// <summary>
    ///   <para>roh:hasCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A concept can be asigned a code."</para>
    /// labels<para>"has Code"</para></remarks>
    /// <seealso href="http://w3id.org/roh#hasCode">http://w3id.org/roh#hasCode</seealso>
    let hasCode = Prefixed_Name(roh, "hasCode") |> PrefixedName

    /// <summary>
    ///   <para>roh:hasCompanyClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has company classification"</para></remarks>
    /// <seealso href="http://w3id.org/roh#hasCompanyClassification">http://w3id.org/roh#hasCompanyClassification</seealso>
    let hasCompanyClassification =
        Prefixed_Name(roh, "hasCompanyClassification") |> PrefixedName

    /// <summary>
    ///   <para>roh:hasContactInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An Agent has a contact info of type vcard:Kind."</para>
    /// labels<para>"tiene información de contacto"</para><para>"has contact info"</para></remarks>
    /// <seealso href="http://w3id.org/roh#hasContactInfo">http://w3id.org/roh#hasContactInfo</seealso>
    let hasContactInfo = Prefixed_Name(roh, "hasContactInfo") |> PrefixedName
    /// <summary>
    ///   <para>roh:hasContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An object property linking an Entity to a Contract."</para>
    /// labels<para>"has contract"</para><para>"tiene contrato"</para></remarks>
    /// <seealso href="http://w3id.org/roh#hasContract">http://w3id.org/roh#hasContract</seealso>
    let hasContract = Prefixed_Name(roh, "hasContract") |> PrefixedName

    /// <summary>
    ///   <para>roh:hasExpenseClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has Expense Classification"</para></remarks>
    /// <seealso href="http://w3id.org/roh#hasExpenseClassification">http://w3id.org/roh#hasExpenseClassification</seealso>
    let hasExpenseClassification =
        Prefixed_Name(roh, "hasExpenseClassification") |> PrefixedName

    /// <summary>
    ///   <para>roh:hasFundingProgramClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"has Funding Program Classification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/roh#hasFundingProgramClassification">http://w3id.org/roh#hasFundingProgramClassification</seealso>
    let hasFundingProgramClassification =
        Prefixed_Name(roh, "hasFundingProgramClassification") |> PrefixedName

    /// <summary>
    ///   <para>roh:hasHRClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The position a person has inside its organization."</para>
    /// labels<para>"has HR classification"</para><para>"clasificado en RRHH como"</para></remarks>
    /// <seealso href="http://w3id.org/roh#hasHRClassification">http://w3id.org/roh#hasHRClassification</seealso>
    let hasHRClassification = Prefixed_Name(roh, "hasHRClassification") |> PrefixedName
    /// <summary>
    ///   <para>roh:hasKnowledgeArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Some entity related to any Concept."</para>
    /// labels<para>"has knowledge area"</para><para>"tiene area de conocimiento"</para></remarks>
    /// <seealso href="http://w3id.org/roh#hasKnowledgeArea">http://w3id.org/roh#hasKnowledgeArea</seealso>
    let hasKnowledgeArea = Prefixed_Name(roh, "hasKnowledgeArea") |> PrefixedName
    /// <summary>
    ///   <para>roh:hasLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Esta propiedad nos permite especificar la licencia (vivo:License) de una instancia."</para>
    ///   <para>"This object property is used to specify the licence (vivo:License) of a given instance."</para>
    /// labels<para>"tiene licencia"</para><para>"has license"</para></remarks>
    /// <seealso href="http://w3id.org/roh#hasLicense">http://w3id.org/roh#hasLicense</seealso>
    let hasLicense = Prefixed_Name(roh, "hasLicense") |> PrefixedName
    /// <summary>
    ///   <para>roh:hasMetric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Metric which quantifies a Research Object."</para>
    /// labels<para>"tiene métrica"</para><para>"has metric"</para></remarks>
    /// <seealso href="http://w3id.org/roh#hasMetric">http://w3id.org/roh#hasMetric</seealso>
    let hasMetric = Prefixed_Name(roh, "hasMetric") |> PrefixedName
    /// <summary>
    ///   <para>roh:hasPatent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has patent"</para></remarks>
    /// <seealso href="http://w3id.org/roh#hasPatent">http://w3id.org/roh#hasPatent</seealso>
    let hasPatent = Prefixed_Name(roh, "hasPatent") |> PrefixedName
    /// <summary>
    ///   <para>roh:hasPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Person has a Position in his/her Organization."</para>
    /// labels<para>"has position"</para><para>"tiene plaza"</para></remarks>
    /// <seealso href="http://w3id.org/roh#hasPosition">http://w3id.org/roh#hasPosition</seealso>
    let hasPosition = Prefixed_Name(roh, "hasPosition") |> PrefixedName
    /// <summary>
    ///   <para>roh:hasPredecessor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has predecessor"</para><para>"tiene predecesor"</para></remarks>
    /// <seealso href="http://w3id.org/roh#hasPredecessor">http://w3id.org/roh#hasPredecessor</seealso>
    let hasPredecessor = Prefixed_Name(roh, "hasPredecessor") |> PrefixedName

    /// <summary>
    ///   <para>roh:hasProjectClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Project is categorized by different Project Classifications."</para>
    /// labels<para>"has project categorization"</para><para>"tiene categorizacion proyecto"</para></remarks>
    /// <seealso href="http://w3id.org/roh#hasProjectClassification">http://w3id.org/roh#hasProjectClassification</seealso>
    let hasProjectClassification =
        Prefixed_Name(roh, "hasProjectClassification") |> PrefixedName

    /// <summary>
    ///   <para>roh:hasPropertyClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"has property classification"</para></remarks>
    /// <seealso href="http://w3id.org/roh#hasPropertyClassification">http://w3id.org/roh#hasPropertyClassification</seealso>
    let hasPropertyClassification =
        Prefixed_Name(roh, "hasPropertyClassification") |> PrefixedName

    /// <summary>
    ///   <para>roh:hasReadme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This object property is used to specify the README document of a given  Respository or Software."</para>
    /// labels<para>"has readme"</para><para>"tiene readme"</para></remarks>
    /// <seealso href="http://w3id.org/roh#hasReadme">http://w3id.org/roh#hasReadme</seealso>
    let hasReadme = Prefixed_Name(roh, "hasReadme") |> PrefixedName

    /// <summary>
    ///   <para>roh:hasResearchContribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has research contribution"</para></remarks>
    /// <seealso href="http://w3id.org/roh#hasResearchContribution">http://w3id.org/roh#hasResearchContribution</seealso>
    let hasResearchContribution =
        Prefixed_Name(roh, "hasResearchContribution") |> PrefixedName

    /// <summary>
    ///   <para>roh:hasReservable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An Agent who owns an infrastructure."</para>
    /// labels<para>"has reservable"</para><para>"tiene reservable"</para></remarks>
    /// <seealso href="http://w3id.org/roh#hasReservable">http://w3id.org/roh#hasReservable</seealso>
    let hasReservable = Prefixed_Name(roh, "hasReservable") |> PrefixedName
    /// <summary>
    ///   <para>roh:hasRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An Agent has a Role in a Relation."</para>
    /// labels<para>"tiene rol"</para><para>"has role"</para></remarks>
    /// <seealso href="http://w3id.org/roh#hasRole">http://w3id.org/roh#hasRole</seealso>
    let hasRole = Prefixed_Name(roh, "hasRole") |> PrefixedName
    /// <summary>
    ///   <para>roh:hasScientificDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has scientific domain"</para></remarks>
    /// <seealso href="http://w3id.org/roh#hasScientificDomain">http://w3id.org/roh#hasScientificDomain</seealso>
    let hasScientificDomain = Prefixed_Name(roh, "hasScientificDomain") |> PrefixedName
    /// <summary>
    ///   <para>roh:hasSpinoff</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An Organization which has a spin off Company."</para>
    /// labels<para>"tiene spinoff"</para><para>"has spinoff"</para></remarks>
    /// <seealso href="http://w3id.org/roh#hasSpinoff">http://w3id.org/roh#hasSpinoff</seealso>
    let hasSpinoff = Prefixed_Name(roh, "hasSpinoff") |> PrefixedName
    /// <summary>
    ///   <para>roh:hasSucessor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"tiene sucesor"</para><para>"has sucessor"</para></remarks>
    /// <seealso href="http://w3id.org/roh#hasSucessor">http://w3id.org/roh#hasSucessor</seealso>
    let hasSucessor = Prefixed_Name(roh, "hasSucessor") |> PrefixedName
    /// <summary>
    ///   <para>roh:hasTRL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A prototype has a given technology readiness level"</para>
    /// labels<para>"has TRL"</para></remarks>
    /// <seealso href="http://w3id.org/roh#hasTRL">http://w3id.org/roh#hasTRL</seealso>
    let hasTRL = Prefixed_Name(roh, "hasTRL") |> PrefixedName
    /// <summary>
    ///   <para>roh:hrClassificationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The classification of the position of a Person."</para>
    /// labels<para>"clasificación de RRHH de"</para><para>"HR classification of"</para></remarks>
    /// <seealso href="http://w3id.org/roh#hrClassificationOf">http://w3id.org/roh#hrClassificationOf</seealso>
    let hrClassificationOf = Prefixed_Name(roh, "hrClassificationOf") |> PrefixedName
    /// <summary>
    ///   <para>roh:i10-index</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A property to express the i10-index of an author."</para>
    /// labels<para>"i10-index"</para></remarks>
    /// <seealso href="http://w3id.org/roh#i10-index">http://w3id.org/roh#i10-index</seealso>
    let i10_index = Prefixed_Name(roh, "i10-index") |> PrefixedName
    /// <summary>
    ///   <para>roh:impactFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A scientometric index that reflects the yearly average number of citations that articles published in the last two years in a given journal received."</para>
    /// labels<para>"impact factor"</para><para>"factor de impacto"</para></remarks>
    /// <seealso href="http://w3id.org/roh#impactFactor">http://w3id.org/roh#impactFactor</seealso>
    let impactFactor = Prefixed_Name(roh, "impactFactor") |> PrefixedName
    /// <summary>
    ///   <para>roh:impactFactorName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/roh#impactFactorName">http://w3id.org/roh#impactFactorName</seealso>
    let impactFactorName = Prefixed_Name(roh, "impactFactorName") |> PrefixedName
    /// <summary>
    ///   <para>roh:isAdvisedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is advised by"</para></remarks>
    /// <seealso href="http://w3id.org/roh#isAdvisedBy">http://w3id.org/roh#isAdvisedBy</seealso>
    let isAdvisedBy = Prefixed_Name(roh, "isAdvisedBy") |> PrefixedName
    /// <summary>
    ///   <para>roh:isAuthoredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is authored by"</para></remarks>
    /// <seealso href="http://w3id.org/roh#isAuthoredBy">http://w3id.org/roh#isAuthoredBy</seealso>
    let isAuthoredBy = Prefixed_Name(roh, "isAuthoredBy") |> PrefixedName
    /// <summary>
    ///   <para>roh:isAwardedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"is awarded by"</para></remarks>
    /// <seealso href="http://w3id.org/roh#isAwardedBy">http://w3id.org/roh#isAwardedBy</seealso>
    let isAwardedBy = Prefixed_Name(roh, "isAwardedBy") |> PrefixedName
    /// <summary>
    ///   <para>roh:isCompetitive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is competitive"</para></remarks>
    /// <seealso href="http://w3id.org/roh#isCompetitive">http://w3id.org/roh#isCompetitive</seealso>
    let isCompetitive = Prefixed_Name(roh, "isCompetitive") |> PrefixedName
    /// <summary>
    ///   <para>roh:isGrantedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A person is granted with a stipend for researching."</para>
    /// labels<para>"is granted with"</para></remarks>
    /// <seealso href="http://w3id.org/roh#isGrantedWith">http://w3id.org/roh#isGrantedWith</seealso>
    let isGrantedWith = Prefixed_Name(roh, "isGrantedWith") |> PrefixedName
    /// <summary>
    ///   <para>roh:isProvidedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Service provided by an Organization."</para>
    /// labels<para>"is provided by"</para><para>"provisto por"</para></remarks>
    /// <seealso href="http://w3id.org/roh#isProvidedBy">http://w3id.org/roh#isProvidedBy</seealso>
    let isProvidedBy = Prefixed_Name(roh, "isProvidedBy") |> PrefixedName
    /// <summary>
    ///   <para>roh:isSpinfoffOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Company which is an spinoff of an Organization."</para>
    /// labels<para>"es spinoff de"</para><para>"spins of from"</para><para>"is spinoff of"</para></remarks>
    /// <seealso href="http://w3id.org/roh#isSpinfoffOf">http://w3id.org/roh#isSpinfoffOf</seealso>
    let isSpinfoffOf = Prefixed_Name(roh, "isSpinfoffOf") |> PrefixedName
    /// <summary>
    ///   <para>roh:isStartup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"To specify that a company is in its early stage of life."</para>
    /// labels<para>"es startup"</para><para>"is startup"</para></remarks>
    /// <seealso href="http://w3id.org/roh#isStartup">http://w3id.org/roh#isStartup</seealso>
    let isStartup = Prefixed_Name(roh, "isStartup") |> PrefixedName
    /// <summary>
    ///   <para>roh:isSupportedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Project supported by a Funding."</para>
    /// labels<para>"is supported by"</para><para>"apoyado por"</para></remarks>
    /// <seealso href="http://w3id.org/roh#isSupportedBy">http://w3id.org/roh#isSupportedBy</seealso>
    let isSupportedBy = Prefixed_Name(roh, "isSupportedBy") |> PrefixedName
    /// <summary>
    ///   <para>roh:isbn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A numeric commercial book identifier which is intended to be unique."</para>
    /// labels<para>"isbn"</para></remarks>
    /// <seealso href="http://w3id.org/roh#isbn">http://w3id.org/roh#isbn</seealso>
    let isbn = Prefixed_Name(roh, "isbn") |> PrefixedName
    /// <summary>
    ///   <para>roh:issuedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An Accreditation issued by an Accreditation Issuer."</para>
    /// labels<para>"issued by"</para><para>"emitido por"</para></remarks>
    /// <seealso href="http://w3id.org/roh#issuedBy">http://w3id.org/roh#issuedBy</seealso>
    let issuedBy = Prefixed_Name(roh, "issuedBy") |> PrefixedName
    /// <summary>
    ///   <para>roh:issues</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An Accreditation Issuer which issues an Accreditation."</para>
    /// labels<para>"issues"</para><para>"emite"</para></remarks>
    /// <seealso href="http://w3id.org/roh#issues">http://w3id.org/roh#issues</seealso>
    let issues = Prefixed_Name(roh, "issues") |> PrefixedName
    /// <summary>
    ///   <para>roh:knowledgeAreaOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A skos:Concept which is the knowledge area of some entity."</para>
    /// labels<para>"area de conocimiento de"</para><para>"knowledge area of"</para></remarks>
    /// <seealso href="http://w3id.org/roh#knowledgeAreaOf">http://w3id.org/roh#knowledgeAreaOf</seealso>
    let knowledgeAreaOf = Prefixed_Name(roh, "knowledgeAreaOf") |> PrefixedName
    /// <summary>
    ///   <para>roh:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"lenguaje"</para><para>"language"</para></remarks>
    /// <seealso href="http://w3id.org/roh#language">http://w3id.org/roh#language</seealso>
    let language = Prefixed_Name(roh, "language") |> PrefixedName

    /// <summary>
    ///   <para>roh:languageOfTheCertificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The language to which refers the Language Certificate."</para>
    /// labels<para>"idioma del certificado"</para><para>"language of the certificate"</para></remarks>
    /// <seealso href="http://w3id.org/roh#languageOfTheCertificate">http://w3id.org/roh#languageOfTheCertificate</seealso>
    let languageOfTheCertificate =
        Prefixed_Name(roh, "languageOfTheCertificate") |> PrefixedName

    /// <summary>
    ///   <para>roh:languageSkill</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"Different skills required by the Common European Framework of Reference for Languages: Learning, Teaching, Assessment."</para>
    /// labels<para>"competencia de idiomas"</para><para>"language skill"</para></remarks>
    /// <seealso href="http://w3id.org/roh#languageSkill">http://w3id.org/roh#languageSkill</seealso>
    let languageSkill = Prefixed_Name(roh, "languageSkill") |> PrefixedName
    /// <summary>
    ///   <para>roh:listeningSkill</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"The ability to understand spoken language."</para>
    /// labels<para>"listening skill"</para><para>"comprensión auditiva"</para></remarks>
    /// <seealso href="http://w3id.org/roh#listeningSkill">http://w3id.org/roh#listeningSkill</seealso>
    let listeningSkill = Prefixed_Name(roh, "listeningSkill") |> PrefixedName
    /// <summary>
    ///   <para>roh:mark</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A judgment, expressed as a number or letter, about the quality of a work."</para>
    /// labels<para>"mark"</para><para>"nota"</para></remarks>
    /// <seealso href="http://w3id.org/roh#mark">http://w3id.org/roh#mark</seealso>
    let mark = Prefixed_Name(roh, "mark") |> PrefixedName
    /// <summary>
    ///   <para>roh:metricName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The name of a Metric."</para>
    /// labels<para>"metric name"</para><para>"nombre de la métrica"</para></remarks>
    /// <seealso href="http://w3id.org/roh#metricName">http://w3id.org/roh#metricName</seealso>
    let metricName = Prefixed_Name(roh, "metricName") |> PrefixedName
    /// <summary>
    ///   <para>roh:metricOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"relates a Metric to the entity it describes"</para>
    /// labels<para>"métrica de"</para><para>"metric of"</para></remarks>
    /// <seealso href="http://w3id.org/roh#metricOf">http://w3id.org/roh#metricOf</seealso>
    let metricOf = Prefixed_Name(roh, "metricOf") |> PrefixedName
    /// <summary>
    ///   <para>roh:modality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A free text property to represent the modality of a Project."</para>
    /// labels<para>"modalidad"</para></remarks>
    /// <seealso href="http://w3id.org/roh#modality">http://w3id.org/roh#modality</seealso>
    let modality = Prefixed_Name(roh, "modality") |> PrefixedName
    /// <summary>
    ///   <para>roh:monetaryAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Data property used by roh:Funding and roh:FundingAmount"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"cantidad monetaria"</para><para>"monetary amount"</para></remarks>
    /// <seealso href="http://w3id.org/roh#monetaryAmount">http://w3id.org/roh#monetaryAmount</seealso>
    let monetaryAmount = Prefixed_Name(roh, "monetaryAmount") |> PrefixedName

    /// <summary>
    ///   <para>roh:needsEthicalValidation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Represents if a Project needs to pass an ethical validation."</para>
    /// labels<para>"needs ethical validation"</para><para>"necesita validación ética"</para></remarks>
    /// <seealso href="http://w3id.org/roh#needsEthicalValidation">http://w3id.org/roh#needsEthicalValidation</seealso>
    let needsEthicalValidation =
        Prefixed_Name(roh, "needsEthicalValidation") |> PrefixedName

    /// <summary>
    ///   <para>roh:ownerOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"A Patent has an Organization who owns it."</para>
    /// labels<para>"owner organization"</para><para>"organización propietaria"</para></remarks>
    /// <seealso href="http://w3id.org/roh#ownerOrganization">http://w3id.org/roh#ownerOrganization</seealso>
    let ownerOrganization = Prefixed_Name(roh, "ownerOrganization") |> PrefixedName
    /// <summary>
    ///   <para>roh:ownerOrganizationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An Organization owning a Patent."</para>
    /// labels<para>"owner organization of"</para><para>"organización propietaria de"</para></remarks>
    /// <seealso href="http://w3id.org/roh#ownerOrganizationOf">http://w3id.org/roh#ownerOrganizationOf</seealso>
    let ownerOrganizationOf = Prefixed_Name(roh, "ownerOrganizationOf") |> PrefixedName
    /// <summary>
    ///   <para>roh:partOfRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"A core relation that holds between a part and its hole, that in this case is a Repository."</para>
    /// labels<para>"part of repository"</para><para>"parte de un repositorio."</para></remarks>
    /// <seealso href="http://w3id.org/roh#partOfRepository">http://w3id.org/roh#partOfRepository</seealso>
    let partOfRepository = Prefixed_Name(roh, "partOfRepository") |> PrefixedName

    /// <summary>
    ///   <para>roh:partOfResearchResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A core relation that holds between a part and its hole, that in this case is a Research."</para>
    /// labels<para>"parte de un resultado de investigación"</para><para>"part of research result"</para></remarks>
    /// <seealso href="http://w3id.org/roh#partOfResearchResult">http://w3id.org/roh#partOfResearchResult</seealso>
    let partOfResearchResult =
        Prefixed_Name(roh, "partOfResearchResult") |> PrefixedName

    /// <summary>
    ///   <para>roh:participatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An Activity participated by an Entity."</para>
    /// labels<para>"participante"</para><para>"participated by"</para></remarks>
    /// <seealso href="http://w3id.org/roh#participatedBy">http://w3id.org/roh#participatedBy</seealso>
    let participatedBy = Prefixed_Name(roh, "participatedBy") |> PrefixedName
    /// <summary>
    ///   <para>roh:participates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An Entity participating in an Activity."</para>
    /// labels<para>"participates"</para><para>"participa en"</para></remarks>
    /// <seealso href="http://w3id.org/roh#participates">http://w3id.org/roh#participates</seealso>
    let participates = Prefixed_Name(roh, "participates") |> PrefixedName

    /// <summary>
    ///   <para>roh:patentAssistantExaminer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"patent assistant examiner"</para></remarks>
    /// <seealso href="http://w3id.org/roh#patentAssistantExaminer">http://w3id.org/roh#patentAssistantExaminer</seealso>
    let patentAssistantExaminer =
        Prefixed_Name(roh, "patentAssistantExaminer") |> PrefixedName

    /// <summary>
    ///   <para>roh:patentCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"patent country"</para></remarks>
    /// <seealso href="http://w3id.org/roh#patentCountry">http://w3id.org/roh#patentCountry</seealso>
    let patentCountry = Prefixed_Name(roh, "patentCountry") |> PrefixedName
    /// <summary>
    ///   <para>roh:patentInventor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"patent inventor"</para></remarks>
    /// <seealso href="http://w3id.org/roh#patentInventor">http://w3id.org/roh#patentInventor</seealso>
    let patentInventor = Prefixed_Name(roh, "patentInventor") |> PrefixedName

    /// <summary>
    ///   <para>roh:patentPrimaryExaminer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"patent primary examiner"</para></remarks>
    /// <seealso href="http://w3id.org/roh#patentPrimaryExaminer">http://w3id.org/roh#patentPrimaryExaminer</seealso>
    let patentPrimaryExaminer =
        Prefixed_Name(roh, "patentPrimaryExaminer") |> PrefixedName

    /// <summary>
    ///   <para>roh:patentStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"patent status"</para></remarks>
    /// <seealso href="http://w3id.org/roh#patentStatus">http://w3id.org/roh#patentStatus</seealso>
    let patentStatus = Prefixed_Name(roh, "patentStatus") |> PrefixedName
    /// <summary>
    ///   <para>roh:platform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/roh#platform">http://w3id.org/roh#platform</seealso>
    let platform = Prefixed_Name(roh, "platform") |> PrefixedName
    /// <summary>
    ///   <para>roh:positionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The Position of a Person within an Organization."</para>
    /// labels<para>"position of"</para><para>"plaza de"</para></remarks>
    /// <seealso href="http://w3id.org/roh#positionOf">http://w3id.org/roh#positionOf</seealso>
    let positionOf = Prefixed_Name(roh, "positionOf") |> PrefixedName
    /// <summary>
    ///   <para>roh:producedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Some entity producing some Thing."</para>
    /// labels<para>"produced by"</para><para>"producido por"</para></remarks>
    /// <seealso href="http://w3id.org/roh#producedBy">http://w3id.org/roh#producedBy</seealso>
    let producedBy = Prefixed_Name(roh, "producedBy") |> PrefixedName
    /// <summary>
    ///   <para>roh:produces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Some Thing producing some entity."</para>
    /// labels<para>"produce"</para><para>"produces"</para></remarks>
    /// <seealso href="http://w3id.org/roh#produces">http://w3id.org/roh#produces</seealso>
    let produces = Prefixed_Name(roh, "produces") |> PrefixedName
    /// <summary>
    ///   <para>roh:programmingLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"programming language"</para><para>"lenguaje de programación"</para></remarks>
    /// <seealso href="http://w3id.org/roh#programmingLanguage">http://w3id.org/roh#programmingLanguage</seealso>
    let programmingLanguage = Prefixed_Name(roh, "programmingLanguage") |> PrefixedName
    /// <summary>
    ///   <para>roh:projectAcronym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"project acronym"</para></remarks>
    /// <seealso href="http://w3id.org/roh#projectAcronym">http://w3id.org/roh#projectAcronym</seealso>
    let projectAcronym = Prefixed_Name(roh, "projectAcronym") |> PrefixedName

    /// <summary>
    ///   <para>roh:projectClassificationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"A Project Classification which categorizes a Project."</para>
    /// labels<para>"project categorization of"</para><para>"categorización de proyecto de"</para></remarks>
    /// <seealso href="http://w3id.org/roh#projectClassificationOf">http://w3id.org/roh#projectClassificationOf</seealso>
    let projectClassificationOf =
        Prefixed_Name(roh, "projectClassificationOf") |> PrefixedName

    /// <summary>
    ///   <para>roh:projectID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"project ID"</para></remarks>
    /// <seealso href="http://w3id.org/roh#projectID">http://w3id.org/roh#projectID</seealso>
    let projectID = Prefixed_Name(roh, "projectID") |> PrefixedName
    /// <summary>
    ///   <para>roh:projectObjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A defined objective of the project."</para>
    /// labels<para>"project objective"</para><para>"objetivo de proyecto"</para></remarks>
    /// <seealso href="http://w3id.org/roh#projectObjective">http://w3id.org/roh#projectObjective</seealso>
    let projectObjective = Prefixed_Name(roh, "projectObjective") |> PrefixedName
    /// <summary>
    ///   <para>roh:projectStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A project may be in a CLOSED, OPEN or in other future status that may be defined."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"estado del proyecto"</para><para>"project status"</para></remarks>
    /// <seealso href="http://w3id.org/roh#projectStatus">http://w3id.org/roh#projectStatus</seealso>
    let projectStatus = Prefixed_Name(roh, "projectStatus") |> PrefixedName
    /// <summary>
    ///   <para>roh:promotedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Funding Program or Funding Source promoted by a Funding Organization."</para>
    /// labels<para>"promocionado por"</para><para>"promoted by"</para></remarks>
    /// <seealso href="http://w3id.org/roh#promotedBy">http://w3id.org/roh#promotedBy</seealso>
    let promotedBy = Prefixed_Name(roh, "promotedBy") |> PrefixedName
    /// <summary>
    ///   <para>roh:promotes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"A Funding Organization which promotes a Funding Program or a Funding Source."</para>
    /// labels<para>"promociona"</para><para>"promotes"</para></remarks>
    /// <seealso href="http://w3id.org/roh#promotes">http://w3id.org/roh#promotes</seealso>
    let promotes = Prefixed_Name(roh, "promotes") |> PrefixedName
    /// <summary>
    ///   <para>roh:provides</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An Organization which provides a Service."</para>
    /// labels<para>"provee"</para><para>"provides"</para></remarks>
    /// <seealso href="http://w3id.org/roh#provides">http://w3id.org/roh#provides</seealso>
    let provides = Prefixed_Name(roh, "provides") |> PrefixedName
    /// <summary>
    ///   <para>roh:publicCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"To define if a Company is public or not."</para>
    /// labels<para>"empresa pública"</para><para>"public company"</para></remarks>
    /// <seealso href="http://w3id.org/roh#publicCompany">http://w3id.org/roh#publicCompany</seealso>
    let publicCompany = Prefixed_Name(roh, "publicCompany") |> PrefixedName
    /// <summary>
    ///   <para>roh:publicFunding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"To tag something as public (true) or private (false)"</para>
    /// labels<para>"public funding"</para><para>"financiación pública"</para></remarks>
    /// <seealso href="http://w3id.org/roh#publicFunding">http://w3id.org/roh#publicFunding</seealso>
    let publicFunding = Prefixed_Name(roh, "publicFunding") |> PrefixedName
    /// <summary>
    ///   <para>roh:quartile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"The quartile to which a Journal publication belongs."</para>
    /// labels<para>"cuartil"</para><para>"quartile"</para></remarks>
    /// <seealso href="http://w3id.org/roh#quartile">http://w3id.org/roh#quartile</seealso>
    let quartile = Prefixed_Name(roh, "quartile") |> PrefixedName
    /// <summary>
    ///   <para>roh:ranking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The ranking of a scientific publication."</para>
    /// labels<para>"ranking"</para></remarks>
    /// <seealso href="http://w3id.org/roh#ranking">http://w3id.org/roh#ranking</seealso>
    let ranking = Prefixed_Name(roh, "ranking") |> PrefixedName
    /// <summary>
    ///   <para>roh:readingSkill</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The ability to understand written text."</para>
    /// labels<para>"comprensión lectora"</para><para>"reading skill"</para></remarks>
    /// <seealso href="http://w3id.org/roh#readingSkill">http://w3id.org/roh#readingSkill</seealso>
    let readingSkill = Prefixed_Name(roh, "readingSkill") |> PrefixedName
    /// <summary>
    ///   <para>roh:readmeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This object property is used to specify the Repository or Software of a given README document."</para>
    /// labels<para>"readme de"</para><para>"readme of"</para></remarks>
    /// <seealso href="http://w3id.org/roh#readmeOf">http://w3id.org/roh#readmeOf</seealso>
    let readmeOf = Prefixed_Name(roh, "readmeOf") |> PrefixedName
    /// <summary>
    ///   <para>roh:referencedLaw</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A reference law that establishes a position."</para>
    /// labels<para>"reference law"</para></remarks>
    /// <seealso href="http://w3id.org/roh#referencedLaw">http://w3id.org/roh#referencedLaw</seealso>
    let referencedLaw = Prefixed_Name(roh, "referencedLaw") |> PrefixedName
    /// <summary>
    ///   <para>roh:repositoryHasPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A core relation that holds between a whole, that in this case is an Repository, and its part ."</para>
    /// labels<para>"repositorio contiene"</para><para>"repository has part"</para></remarks>
    /// <seealso href="http://w3id.org/roh#repositoryHasPart">http://w3id.org/roh#repositoryHasPart</seealso>
    let repositoryHasPart = Prefixed_Name(roh, "repositoryHasPart") |> PrefixedName
    /// <summary>
    ///   <para>roh:repositoryStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The status of a Repository (Closed or Open)."</para>
    /// labels<para>"repository status"</para><para>"estado del repositorio"</para></remarks>
    /// <seealso href="http://w3id.org/roh#repositoryStatus">http://w3id.org/roh#repositoryStatus</seealso>
    let repositoryStatus = Prefixed_Name(roh, "repositoryStatus") |> PrefixedName
    /// <summary>
    ///   <para>roh:requiredFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"required for"</para></remarks>
    /// <seealso href="http://w3id.org/roh#requiredFor">http://w3id.org/roh#requiredFor</seealso>
    let requiredFor = Prefixed_Name(roh, "requiredFor") |> PrefixedName
    /// <summary>
    ///   <para>roh:requires</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates roles and their requisites, i.e. other roles."</para>
    /// labels<para>"requires"</para></remarks>
    /// <seealso href="http://w3id.org/roh#requires">http://w3id.org/roh#requires</seealso>
    let requires = Prefixed_Name(roh, "requires") |> PrefixedName
    /// <summary>
    ///   <para>roh:researchLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A free-text property to define the research line in which an Organization or Researcher is working on."</para>
    /// labels<para>"research line"</para><para>"línea de investigación"</para></remarks>
    /// <seealso href="http://w3id.org/roh#researchLine">http://w3id.org/roh#researchLine</seealso>
    let researchLine = Prefixed_Name(roh, "researchLine") |> PrefixedName

    /// <summary>
    ///   <para>roh:researchResultHasPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A core relation that holds between a whole, that in this case is an Research Object (roh:ResearchObject), and its part ."</para>
    /// labels<para>"resultado de investigación contiene"</para><para>"research result has part"</para></remarks>
    /// <seealso href="http://w3id.org/roh#researchResultHasPart">http://w3id.org/roh#researchResultHasPart</seealso>
    let researchResultHasPart =
        Prefixed_Name(roh, "researchResultHasPart") |> PrefixedName

    /// <summary>
    ///   <para>roh:reservableOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An Infrastructure belonging to an Agent."</para>
    /// labels<para>"reservable de"</para><para>"reservable of"</para></remarks>
    /// <seealso href="http://w3id.org/roh#reservableOf">http://w3id.org/roh#reservableOf</seealso>
    let reservableOf = Prefixed_Name(roh, "reservableOf") |> PrefixedName
    /// <summary>
    ///   <para>roh:reviews</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"a proerty to link a person to a publication as a reviewer."</para>
    /// labels<para>"reviews"</para></remarks>
    /// <seealso href="http://w3id.org/roh#reviews">http://w3id.org/roh#reviews</seealso>
    let reviews = Prefixed_Name(roh, "reviews") |> PrefixedName
    /// <summary>
    ///   <para>roh:roleOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The Role held by an Agent in a Relationship."</para>
    /// labels<para>"rol de"</para><para>"role of"</para></remarks>
    /// <seealso href="http://w3id.org/roh#roleOf">http://w3id.org/roh#roleOf</seealso>
    let roleOf = Prefixed_Name(roh, "roleOf") |> PrefixedName
    /// <summary>
    ///   <para>roh:seqOfAuthors</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An unordered list of authors."</para>
    ///   <para>"Una lista no ordenada de los autores."</para>
    /// labels<para>"conjunto de autores"</para><para>"seq of authors"</para></remarks>
    /// <seealso href="http://w3id.org/roh#seqOfAuthors">http://w3id.org/roh#seqOfAuthors</seealso>
    let seqOfAuthors = Prefixed_Name(roh, "seqOfAuthors") |> PrefixedName
    /// <summary>
    ///   <para>roh:softwareStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The status of a Software  (Final or Provisional)."</para>
    /// labels<para>"estatus de software"</para><para>"software status"</para></remarks>
    /// <seealso href="http://w3id.org/roh#softwareStatus">http://w3id.org/roh#softwareStatus</seealso>
    let softwareStatus = Prefixed_Name(roh, "softwareStatus") |> PrefixedName
    /// <summary>
    ///   <para>roh:speakingSkill</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The ability to speak a language."</para>
    /// labels<para>"expresión oral"</para><para>"speaking skill"</para></remarks>
    /// <seealso href="http://w3id.org/roh#speakingSkill">http://w3id.org/roh#speakingSkill</seealso>
    let speakingSkill = Prefixed_Name(roh, "speakingSkill") |> PrefixedName
    /// <summary>
    ///   <para>roh:spends</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An entity spending an Expense."</para>
    /// labels<para>"spends"</para><para>"gasta"</para></remarks>
    /// <seealso href="http://w3id.org/roh#spends">http://w3id.org/roh#spends</seealso>
    let spends = Prefixed_Name(roh, "spends") |> PrefixedName
    /// <summary>
    ///   <para>roh:spentBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An Expense spent by an Entity."</para>
    /// labels<para>"spent by"</para><para>"gasto realizado por"</para></remarks>
    /// <seealso href="http://w3id.org/roh#spentBy">http://w3id.org/roh#spentBy</seealso>
    let spentBy = Prefixed_Name(roh, "spentBy") |> PrefixedName

    /// <summary>
    ///   <para>roh:spokenInteractionSkill</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The ability to participate into a conversation."</para>
    /// labels<para>"interacción oral"</para><para>"spoken interaction skill"</para></remarks>
    /// <seealso href="http://w3id.org/roh#spokenInteractionSkill">http://w3id.org/roh#spokenInteractionSkill</seealso>
    let spokenInteractionSkill =
        Prefixed_Name(roh, "spokenInteractionSkill") |> PrefixedName

    /// <summary>
    ///   <para>roh:summary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A textual summary of the Curriculum Vitae"</para>
    /// labels<para>"resumen"</para><para>"summary"</para></remarks>
    /// <seealso href="http://w3id.org/roh#summary">http://w3id.org/roh#summary</seealso>
    let summary = Prefixed_Name(roh, "summary") |> PrefixedName
    /// <summary>
    ///   <para>roh:supervisedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Thesis supervised by a Person."</para>
    /// labels<para>"supervised by"</para><para>"supervisado por"</para></remarks>
    /// <seealso href="http://w3id.org/roh#supervisedBy">http://w3id.org/roh#supervisedBy</seealso>
    let supervisedBy = Prefixed_Name(roh, "supervisedBy") |> PrefixedName
    /// <summary>
    ///   <para>roh:supervisorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Person supervising a Thesis."</para>
    /// labels<para>"supervisor of"</para><para>"supervisor de"</para></remarks>
    /// <seealso href="http://w3id.org/roh#supervisorOf">http://w3id.org/roh#supervisorOf</seealso>
    let supervisorOf = Prefixed_Name(roh, "supervisorOf") |> PrefixedName
    /// <summary>
    ///   <para>roh:supports</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Funding which supports a Person Contract or a Project."</para>
    /// labels<para>"apoya"</para><para>"supports"</para></remarks>
    /// <seealso href="http://w3id.org/roh#supports">http://w3id.org/roh#supports</seealso>
    let supports = Prefixed_Name(roh, "supports") |> PrefixedName
    /// <summary>
    ///   <para>roh:taughtBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"taught by"</para></remarks>
    /// <seealso href="http://w3id.org/roh#taughtBy">http://w3id.org/roh#taughtBy</seealso>
    let taughtBy = Prefixed_Name(roh, "taughtBy") |> PrefixedName
    /// <summary>
    ///   <para>roh:taxID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"tax ID"</para></remarks>
    /// <seealso href="http://w3id.org/roh#taxID">http://w3id.org/roh#taxID</seealso>
    let taxID = Prefixed_Name(roh, "taxID") |> PrefixedName
    /// <summary>
    ///   <para>roh:teaches</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"teaches"</para></remarks>
    /// <seealso href="http://w3id.org/roh#teaches">http://w3id.org/roh#teaches</seealso>
    let teaches = Prefixed_Name(roh, "teaches") |> PrefixedName
    /// <summary>
    ///   <para>roh:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A data property that associates a title to any ROH entity requiring it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"title"</para><para>"título"</para></remarks>
    /// <seealso href="http://w3id.org/roh#title">http://w3id.org/roh#title</seealso>
    let title = Prefixed_Name(roh, "title") |> PrefixedName
    /// <summary>
    ///   <para>roh:upc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has UPC"</para><para>"Universal Product Code"</para></remarks>
    /// <seealso href="http://w3id.org/roh#upc">http://w3id.org/roh#upc</seealso>
    let upc = Prefixed_Name(roh, "upc") |> PrefixedName
    /// <summary>
    ///   <para>roh:url</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A Uniform Resource Identifier."</para>
    /// labels<para>"url"</para></remarks>
    /// <seealso href="http://w3id.org/roh#url">http://w3id.org/roh#url</seealso>
    let url = Prefixed_Name(roh, "url") |> PrefixedName
    /// <summary>
    ///   <para>roh:utilizes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"utilizes"</para></remarks>
    /// <seealso href="http://w3id.org/roh#utilizes">http://w3id.org/roh#utilizes</seealso>
    let utilizes = Prefixed_Name(roh, "utilizes") |> PrefixedName
    /// <summary>
    ///   <para>roh:writingSkill</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The ability to write into a certain language."</para>
    /// labels<para>"writing skill"</para><para>"expresión escrita"</para></remarks>
    /// <seealso href="http://w3id.org/roh#writingSkill">http://w3id.org/roh#writingSkill</seealso>
    let writingSkill = Prefixed_Name(roh, "writingSkill") |> PrefixedName
