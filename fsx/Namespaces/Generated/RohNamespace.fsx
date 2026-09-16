#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module roh =
    let _prefixId = PrefixId.fromNamespaceLabel "http://w3id.org/roh#" "roh"
    /// <summary>
    ///   <para>rdfs:label : Academic Accreditationrdfs:label : Acreditación Académica</para>
    ///   <para>rdfs:comment : An attestation of qualification, competence, or authority issued to an individual by a third party with a relevant or  de facto authority or assumed competence to do so in the academic field.</para>
    ///   <a href="http://w3id.org/roh#AcademicAccreditation">roh:AcademicAccreditation</a>
    /// </summary>
    let AcademicAccreditation = _prefixId.prefix "AcademicAccreditation"
    /// <summary>
    ///   <para>http://w3id.org/roh/mirror/skos#altLabel : Cadeira</para>
    ///   <para>rdfs:label : Academic subjectrdfs:label : Asignatura académicardfs:label : Assignatura acadèmicardfs:label : Unidade curricular acadêmica</para>
    ///   <para>rdfs:comment : Matière académique</para>
    ///   <a href="http://w3id.org/roh#AcademicSubject">roh:AcademicSubject</a>
    /// </summary>
    let AcademicSubject = _prefixId.prefix "AcademicSubject"
    /// <summary>
    ///   <para>rdfs:label : Accepted</para>
    ///   <a href="http://w3id.org/roh#Accepted">roh:Accepted</a>
    /// </summary>
    let Accepted = _prefixId.prefix "Accepted"
    /// <summary>
    ///   <para>rdfs:label : Acreditaciónrdfs:label : Accreditation</para>
    ///   <para>rdfs:comment : An Accreditation models research and academic position accreditations. Qualification goes beyond Accreditation because it also refers to degrees and other qualifications a person may have.  Accreditation has an important data property which is dateIssued which links Accreditation with vivo:DataTimeValue^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : An attestation of qualification, competence, or authority issued to an individual by a third party with a relevant or  de facto authority or assumed competence to do so.^^xsd:string</para>
    ///   <para>obo:IAO_0000115 : An attestation of qualification, competence, or authority issued to an individual by a third party with a relevant or  de facto authority or assumed competence to do so.^^xsd:string</para>
    ///   <a href="http://w3id.org/roh#Accreditation">roh:Accreditation</a>
    /// </summary>
    let Accreditation = _prefixId.prefix "Accreditation"
    /// <summary>
    ///   <para>rdfs:label : Accreditation Issuerrdfs:label : Emisor de Acreditación</para>
    ///   <para>rdfs:comment : An organization with a relevant or de facto authority or assumed competence to issue research or academic accreditations.</para>
    ///   <a href="http://w3id.org/roh#AccreditationIssuer">roh:AccreditationIssuer</a>
    /// </summary>
    let AccreditationIssuer = _prefixId.prefix "AccreditationIssuer"
    /// <summary>
    ///   <para>obo:IAO_0000112 : Only use if no specific subclasses of event:Event are appropriate.^^xsd:stringobo:IAO_0000112 : This class will also display instances of subclasses under Event, e.g. Philosophy Department Discussion Club; 2009 Racker Lecture; screening of a documentary. In addition to a location in space and time, an event may have any or all the following qualities: actively participating agents, passive factors, work products. Also, it may be in a virtual space or part of a series such as a lecture series.
    ///
    /// The previous short definition was: "An arbitrary classification of a space/time region, by a cognitive agent."^^xsd:string</para>
    ///   <para>rdfs:label : Activityrdfs:label : Actividad</para>
    ///   <para>rdfs:comment : A roh:Activity is participated by Persons (roh:participates) and organized by Organizations through roh:hasRole connecting to intermediary entity vivo:OrganizerRole. Each activity is usually linked to a Project through relationship (roh:participates) and causes a ProjectExpense linked through (vivo:relates). A thorough hierarchy of roh:Activity subtypes is defined: bibo:Conference, vivo:Intership, roh:ThesisViva.^^xsd:string</para>
    ///   <para>obo:IAO_0000115 : Something that happens at a given place and time.^^xsd:string</para>
    ///   <a href="http://w3id.org/roh#Activity">roh:Activity</a>
    /// </summary>
    let Activity = _prefixId.prefix "Activity"
    /// <summary>
    ///   <para>rdfs:label : Administrative</para>
    ///   <a href="http://w3id.org/roh#Administrative">roh:Administrative</a>
    /// </summary>
    let Administrative = _prefixId.prefix "Administrative"
    /// <summary>
    ///   <para>http://w3id.org/roh/mirror/skos#prefLabel : Entidades administrativashttp://w3id.org/roh/mirror/skos#prefLabel : Entidades administrativashttp://w3id.org/roh/mirror/skos#prefLabel : Administrative entitieshttp://w3id.org/roh/mirror/skos#prefLabel : Entitats administrativeshttp://w3id.org/roh/mirror/skos#prefLabel : Entitats administrativeshttp://w3id.org/roh/mirror/skos#prefLabel : Entités administratives</para>
    ///   <para>rdfs:label : Entités administrativesrdfs:label : Entidades administrativasrdfs:label : Entidades administrativasrdfs:label : Administrative entitiesrdfs:label : Entitats administrativesrdfs:label : Entitats administratives</para>
    ///   <para>rdfs:comment : This vertical module in ASIO models all the relevant administrative bodies ("Administración Autonómica") of Spain's Autonomous Communities (conserjerías, departamentos, secretarías) that might have a role (funding, participating) within the development of a given project. It is modeled hierarchically through the relevant administrative levels thereof.</para>
    ///   <a href="http://w3id.org/roh#AdministrativeEntity">roh:AdministrativeEntity</a>
    /// </summary>
    let AdministrativeEntity = _prefixId.prefix "AdministrativeEntity"
    /// <summary>
    ///   <para>rdfs:label : Auditee Rolerdfs:label : Rol de Auditado</para>
    ///   <a href="http://w3id.org/roh#AuditeeRole">roh:AuditeeRole</a>
    /// </summary>
    let AuditeeRole = _prefixId.prefix "AuditeeRole"
    /// <summary>
    ///   <para>rdfs:label : Relación de Auditoríardfs:label : Auditing Relationship</para>
    ///   <a href="http://w3id.org/roh#AuditingRelationship">roh:AuditingRelationship</a>
    /// </summary>
    let AuditingRelationship = _prefixId.prefix "AuditingRelationship"
    /// <summary>
    ///   <para>rdfs:label : Auditor Rolerdfs:label : Rol de Auditor</para>
    ///   <a href="http://w3id.org/roh#AuditorRole">roh:AuditorRole</a>
    /// </summary>
    let AuditorRole = _prefixId.prefix "AuditorRole"
    /// <summary>
    ///   <para>rdfs:label : Author Metricrdfs:label : Métrica de Autor</para>
    ///   <a href="http://w3id.org/roh#AuthorMetric">roh:AuthorMetric</a>
    /// </summary>
    let AuthorMetric = _prefixId.prefix "AuthorMetric"
    /// <summary>
    ///   <para>rdfs:label : Awardrdfs:label : Premio</para>
    ///   <a href="http://w3id.org/roh#Award">roh:Award</a>
    /// </summary>
    let Award = _prefixId.prefix "Award"
    /// <summary>
    ///   <para>http://w3id.org/roh/mirror/skos#altLabel : Bàtxelorhttp://w3id.org/roh/mirror/skos#altLabel : Grauhttp://w3id.org/roh/mirror/skos#altLabel : Grauhttp://w3id.org/roh/mirror/skos#altLabel : Graduhttp://w3id.org/roh/mirror/skos#altLabel : Graohttp://w3id.org/roh/mirror/skos#altLabel : Grado</para>
    ///   <para>rdfs:label : Títol de graurdfs:label : Títol de bàtxelorrdfs:label : Título de gradordfs:label : Licenciatura (pós-Bologna)rdfs:label : Bachelor's degree</para>
    ///   <para>http://w3id.org/roh/mirror/skos#prefLabel : Licenciatura (pós-Bologna)http://w3id.org/roh/mirror/skos#prefLabel : Título de gradohttp://w3id.org/roh/mirror/skos#prefLabel : Bachelor's degreehttp://w3id.org/roh/mirror/skos#prefLabel : Títol de grauhttp://w3id.org/roh/mirror/skos#prefLabel : Títol de bàtxelor</para>
    ///   <para>rdfs:comment : An undergraduate academic degree awarded by colleges and universities upon completion of a course of study lasting three to four years (depending on institution and academic discipline).</para>
    ///   <a href="http://w3id.org/roh#BachelorsDegree">roh:BachelorsDegree</a>
    /// </summary>
    let BachelorsDegree = _prefixId.prefix "BachelorsDegree"
    /// <summary>
    ///   <para>rdfs:label : Asignatura de graordfs:label : Assignatura de bàtxelorrdfs:label : Assignatura de graurdfs:label : Bachelor's degree subject</para>
    ///   <para>rdfs:comment : Unidade curricular de grau</para>
    ///   <a href="http://w3id.org/roh#BachelorsDegreeSubject">roh:BachelorsDegreeSubject</a>
    /// </summary>
    let BachelorsDegreeSubject = _prefixId.prefix "BachelorsDegreeSubject"

    /// <summary>
    ///   <para>rdfs:label : Bachelor's Supervising Relationshiprdfs:label : Relación de Supervisión de Titulación Universitaria</para>
    ///   <a href="http://w3id.org/roh#BachelorsSupervisingRelationship">roh:BachelorsSupervisingRelationship</a>
    /// </summary>
    let BachelorsSupervisingRelationship = _prefixId.prefix "BachelorsSupervisingRelationship"

    /// <summary>
    ///   <para>rdfs:label : Degree Thesisrdfs:label : Bachelor's Thesisrdfs:label : Mémoire de fin de licencerdfs:label : Trabajo de fin de gradordfs:label : Trabayu de fin de graurdfs:label : Treball fi de graurdfs:label : Treball fi de bàtxelorrdfs:label : Tesis de Grado</para>
    ///   <para>http://w3id.org/roh/mirror/skos#altLabel : Trabajo de fin de carrerahttp://w3id.org/roh/mirror/skos#altLabel : Treball de fi de carrerahttp://w3id.org/roh/mirror/skos#altLabel : TFGhttp://w3id.org/roh/mirror/skos#altLabel : TFGhttp://w3id.org/roh/mirror/skos#altLabel : TFGhttp://w3id.org/roh/mirror/skos#altLabel : TFGhttp://w3id.org/roh/mirror/skos#altLabel : Honor's thesishttp://w3id.org/roh/mirror/skos#altLabel : TFBhttp://w3id.org/roh/mirror/skos#altLabel : Traballo de fin de carreirahttp://w3id.org/roh/mirror/skos#altLabel : GALahttp://w3id.org/roh/mirror/skos#altLabel : Honour's thesishttp://w3id.org/roh/mirror/skos#altLabel : Honour's thesis</para>
    ///   <para>http://w3id.org/roh/mirror/skos#prefLabel : Treball de fi de grauhttp://w3id.org/roh/mirror/skos#prefLabel : Trabajo de fin de gradohttp://w3id.org/roh/mirror/skos#prefLabel : Trabayu de fin de grauhttp://w3id.org/roh/mirror/skos#prefLabel : Gradu Amaierako Lanahttp://w3id.org/roh/mirror/skos#prefLabel : Traballo de fin de graohttp://w3id.org/roh/mirror/skos#prefLabel : Mémoire de fin de licencehttp://w3id.org/roh/mirror/skos#prefLabel : Bachelor's Thesishttp://w3id.org/roh/mirror/skos#prefLabel : Treball de fi de bàtxelor</para>
    ///   <para>rdfs:comment : A document created to summarize research findings associated with the completion of an academic degree.rdfs:comment : A thesis reporting a research project undertaken as part of an undergraduate course of education to receive a bachelor's degree.</para>
    ///   <a href="http://w3id.org/roh#BachelorsThesis">roh:BachelorsThesis</a>
    /// </summary>
    let BachelorsThesis = _prefixId.prefix "BachelorsThesis"
    /// <summary>
    ///   <para>rdfs:label : BitBucket Repositoryrdfs:label : Repositorio  de BitBucket</para>
    ///   <para>rdfs:comment : Esta entidad define un repositorio BitBucket (https://bitbucket.org).rdfs:comment : This entity defines a BitBucket Repository (https://bitbucket.org).</para>
    ///   <a href="http://w3id.org/roh#BitBucketRepository">roh:BitBucketRepository</a>
    /// </summary>
    let BitBucketRepository = _prefixId.prefix "BitBucketRepository"
    /// <summary>
    ///   <para>rdfs:label : Blog Post</para>
    ///   <a href="http://w3id.org/roh#BlogPost">roh:BlogPost</a>
    /// </summary>
    let BlogPost = _prefixId.prefix "BlogPost"
    /// <summary>
    ///   <para>rdfs:label : CV derdfs:label : CV of</para>
    ///   <para>rdfs:comment : An object property linking a CV to the person it belongs to.</para>
    ///   <a href="http://w3id.org/roh#CVOf">roh:CVOf</a>
    /// </summary>
    let CVOf = _prefixId.prefix "CVOf"
    /// <summary>
    ///   <para>rdfs:label : Cancelled</para>
    ///   <a href="http://w3id.org/roh#Cancelled">roh:Cancelled</a>
    /// </summary>
    let Cancelled = _prefixId.prefix "Cancelled"
    /// <summary>
    ///   <para>rdfs:label : Case study</para>
    ///   <para>rdfs:comment : A qualitative descriptive research study of individuals or a group.</para>
    ///   <a href="http://w3id.org/roh#CaseStudy">roh:CaseStudy</a>
    /// </summary>
    let CaseStudy = _prefixId.prefix "CaseStudy"
    /// <summary>
    ///   <para>rdfs:label : Catalog</para>
    ///   <para>rdfs:comment : A list of items in a collection; an ordered compilation of item descriptions and sufficient information to afford access to them.</para>
    ///   <a href="http://w3id.org/roh#Catalog">roh:Catalog</a>
    /// </summary>
    let Catalog = _prefixId.prefix "Catalog"
    /// <summary>
    ///   <para>rdfs:label : Closed</para>
    ///   <a href="http://w3id.org/roh#Closed">roh:Closed</a>
    /// </summary>
    let Closed = _prefixId.prefix "Closed"
    /// <summary>
    ///   <para>rdfs:label : Company Classification</para>
    ///   <a href="http://w3id.org/roh#CompanyClassification">roh:CompanyClassification</a>
    /// </summary>
    let CompanyClassification = _prefixId.prefix "CompanyClassification"
    /// <summary>
    ///   <para>rdfs:label : Contest</para>
    ///   <a href="http://w3id.org/roh#Contest">roh:Contest</a>
    /// </summary>
    let Contest = _prefixId.prefix "Contest"
    /// <summary>
    ///   <para>rdfs:label : Paísrdfs:label : Paísrdfs:label : Paísrdfs:label : Paísrdfs:label : Countryrdfs:label : Paysrdfs:label : Herrialde</para>
    ///   <para>rdfs:comment : A region legally identified as a distinct entity in political geography.</para>
    ///   <para>http://w3id.org/roh/mirror/skos#prefLabel : Countryhttp://w3id.org/roh/mirror/skos#prefLabel : Herrialdehttp://w3id.org/roh/mirror/skos#prefLabel : Payshttp://w3id.org/roh/mirror/skos#prefLabel : Paíshttp://w3id.org/roh/mirror/skos#prefLabel : Paíshttp://w3id.org/roh/mirror/skos#prefLabel : Paíshttp://w3id.org/roh/mirror/skos#prefLabel : Paíshttp://w3id.org/roh/mirror/skos#prefLabel : País</para>
    ///   <a href="http://w3id.org/roh#Country">roh:Country</a>
    /// </summary>
    let Country = _prefixId.prefix "Country"
    /// <summary>
    ///   <para>rdfs:label : Certificado de Cursordfs:label : Course Certificate</para>
    ///   <a href="http://w3id.org/roh#CourseCertificate">roh:CourseCertificate</a>
    /// </summary>
    let CourseCertificate = _prefixId.prefix "CourseCertificate"
    /// <summary>
    ///   <para>http://w3id.org/roh/mirror/skos#altLabel : Curriculum vitæhttp://w3id.org/roh/mirror/skos#altLabel : Curriculum vitæhttp://w3id.org/roh/mirror/skos#altLabel : Résuméhttp://w3id.org/roh/mirror/skos#altLabel : CVhttp://w3id.org/roh/mirror/skos#altLabel : CVhttp://w3id.org/roh/mirror/skos#altLabel : CVhttp://w3id.org/roh/mirror/skos#altLabel : CVhttp://w3id.org/roh/mirror/skos#altLabel : CVhttp://w3id.org/roh/mirror/skos#altLabel : CVhttp://w3id.org/roh/mirror/skos#altLabel : CVhttp://w3id.org/roh/mirror/skos#altLabel : Curriculum vitaehttp://w3id.org/roh/mirror/skos#altLabel : Curriculum vitaehttp://w3id.org/roh/mirror/skos#altLabel : Currículohttp://w3id.org/roh/mirror/skos#altLabel : Currículohttp://w3id.org/roh/mirror/skos#altLabel : Currículohttp://w3id.org/roh/mirror/skos#altLabel : Resumehttp://w3id.org/roh/mirror/skos#altLabel : Currículumhttp://w3id.org/roh/mirror/skos#altLabel : Currículum</para>
    ///   <para>http://w3id.org/roh/mirror/skos#prefLabel : Curriculum vitaehttp://w3id.org/roh/mirror/skos#prefLabel : Curriculum vitaehttp://w3id.org/roh/mirror/skos#prefLabel : Curriculum vitaehttp://w3id.org/roh/mirror/skos#prefLabel : Currículum vitaehttp://w3id.org/roh/mirror/skos#prefLabel : Currículum vitae</para>
    ///   <para>rdfs:label : Currículum vitaerdfs:label : Currículum vitaerdfs:label : Currículum vitaerdfs:label : Currículum vitaerdfs:label : Currículum vitaerdfs:label : Curriculum Vitaerdfs:label : Curriculum Vitaerdfs:label : Curriculum vitaerdfs:label : Curriculum vitaerdfs:label : Curriculum vitae</para>
    ///   <para>rdfs:comment : roh:CurriculumVitae adds extra fields necessary to be able to complete the CV of a foaf:Person which cannot be extracted from the relationships with roh:ResearchObject and vivo:Project, among others, that a foaf:Person may have.^^xsd:stringrdfs:comment : A document used and created by a person to present their background, skills and accomplishments.</para>
    ///   <a href="http://w3id.org/roh#CurriculumVitae">roh:CurriculumVitae</a>
    /// </summary>
    let CurriculumVitae = _prefixId.prefix "CurriculumVitae"
    /// <summary>
    ///   <para>rdfs:label : Database</para>
    ///   <a href="http://w3id.org/roh#Database">roh:Database</a>
    /// </summary>
    let Database = _prefixId.prefix "Database"
    /// <summary>
    ///   <para>rdfs:label : Degree Homologationrdfs:label : Homologación de Titulación</para>
    ///   <a href="http://w3id.org/roh#DegreeHomologation">roh:DegreeHomologation</a>
    /// </summary>
    let DegreeHomologation = _prefixId.prefix "DegreeHomologation"
    /// <summary>
    ///   <para>rdfs:label : Degree Metricrdfs:label : Métrica de Grado</para>
    ///   <a href="http://w3id.org/roh#DegreeMetric">roh:DegreeMetric</a>
    /// </summary>
    let DegreeMetric = _prefixId.prefix "DegreeMetric"
    /// <summary>
    ///   <para>rdfs:label : Dissemination Event</para>
    ///   <a href="http://w3id.org/roh#DisseminationEvent">roh:DisseminationEvent</a>
    /// </summary>
    let DisseminationEvent = _prefixId.prefix "DisseminationEvent"
    /// <summary>
    ///   <para>http://w3id.org/roh/mirror/skos#prefLabel : Doctoradohttp://w3id.org/roh/mirror/skos#prefLabel : Doctoral degreehttp://w3id.org/roh/mirror/skos#prefLabel : Doktoregohttp://w3id.org/roh/mirror/skos#prefLabel : Doctorathttp://w3id.org/roh/mirror/skos#prefLabel : Doctorathttp://w3id.org/roh/mirror/skos#prefLabel : Doctorathttp://w3id.org/roh/mirror/skos#prefLabel : Doctorathttp://w3id.org/roh/mirror/skos#prefLabel : Doctorathttp://w3id.org/roh/mirror/skos#prefLabel : Doctorathttp://w3id.org/roh/mirror/skos#prefLabel : Doutoramentohttp://w3id.org/roh/mirror/skos#prefLabel : Doutoramento</para>
    ///   <para>http://w3id.org/roh/mirror/skos#altLabel : Doctoratehttp://w3id.org/roh/mirror/skos#altLabel : Doktoretza</para>
    ///   <para>rdfs:label : Doktoregordfs:label : Doctoratrdfs:label : Doctoratrdfs:label : Doctoratrdfs:label : Doctoratrdfs:label : Doctoratrdfs:label : Doctoratrdfs:label : Doutoramentordfs:label : Doctoral degreerdfs:label : Doutoramentordfs:label : Doctorado</para>
    ///   <a href="http://w3id.org/roh#DoctoralDegree">roh:DoctoralDegree</a>
    /// </summary>
    let DoctoralDegree = _prefixId.prefix "DoctoralDegree"
    /// <summary>
    ///   <para>rdfs:label : Dossierrdfs:label : Dossier</para>
    ///   <para>rdfs:comment : File is a collection in which all assets related to a Project are stored, including the Research Proposal, approval documents, viability plans and so on associated to a project are stored.</para>
    ///   <a href="http://w3id.org/roh#Dossier">roh:Dossier</a>
    /// </summary>
    let Dossier = _prefixId.prefix "Dossier"
    /// <summary>
    ///   <para>rdfs:label : Edited publication</para>
    ///   <a href="http://w3id.org/roh#EditedPublication">roh:EditedPublication</a>
    /// </summary>
    let EditedPublication = _prefixId.prefix "EditedPublication"
    /// <summary>
    ///   <para>rdfs:label : EthicalAudit</para>
    ///   <a href="http://w3id.org/roh#EthicalAudit">roh:EthicalAudit</a>
    /// </summary>
    let EthicalAudit = _prefixId.prefix "EthicalAudit"
    /// <summary>
    ///   <para>rdfs:label : EthicalReport</para>
    ///   <a href="http://w3id.org/roh#EthicalReport">roh:EthicalReport</a>
    /// </summary>
    let EthicalReport = _prefixId.prefix "EthicalReport"
    /// <summary>
    ///   <para>rdfs:label : EthicalValidation</para>
    ///   <a href="http://w3id.org/roh#EthicalValidation">roh:EthicalValidation</a>
    /// </summary>
    let EthicalValidation = _prefixId.prefix "EthicalValidation"
    /// <summary>
    ///   <para>rdfs:label : Comite Eticordfs:label : Ethics Comitee</para>
    ///   <para>rdfs:comment : An ethics committee is a body responsible for ensuring that medical experimentation and human subject research are carried out in an ethical manner in accordance with national and international law.</para>
    ///   <a href="http://w3id.org/roh#EthicsCommittee">roh:EthicsCommittee</a>
    /// </summary>
    let EthicsCommittee = _prefixId.prefix "EthicsCommittee"

    let EuropeanAgriculturalGuaranteeFund = _prefixId.prefix "EuropeanAgriculturalGuaranteeFund"

    let EuropeanMaritimeAndFisheriesFund = _prefixId.prefix "EuropeanMaritimeAndFisheriesFund"

    let EuropeanRegionalDevelopmentFund = _prefixId.prefix "EuropeanRegionalDevelopmentFund"

    let EuropeanSocialFund = _prefixId.prefix "EuropeanSocialFund"
    /// <summary>
    ///   <para>rdfs:label : Evaluation Summaryrdfs:label : Resumen de Evaluación</para>
    ///   <para>rdfs:comment : An evaluation summary provided by a funding organization.</para>
    ///   <a href="http://w3id.org/roh#EvaluationSummary">roh:EvaluationSummary</a>
    /// </summary>
    let EvaluationSummary = _prefixId.prefix "EvaluationSummary"
    /// <summary>
    ///   <para>rdfs:label : Event organiser</para>
    ///   <para>rdfs:comment : A role of organising cientific events, such as conferences, workshops, etc.</para>
    ///   <a href="http://w3id.org/roh#EventOrganiser">roh:EventOrganiser</a>
    /// </summary>
    let EventOrganiser = _prefixId.prefix "EventOrganiser"
    /// <summary>
    ///   <para>rdfs:label : Gastordfs:label : Expense</para>
    ///   <para>rdfs:comment : A roh:Expense is carried out in a vivo:Project or by foaf:Person and associated through relationship roh:spends. It timestamps each expense with a vivo:DateTimeValue and has attributes roh:monetaryAmount, roh:currency, roh:title and roh:description and expenseAmount . The types of expenses considered are: Personnel Expenses, Subcontracting, Travel, Equipment, Research Infrastructure and Other Goods and Services. Some of these classes still not defined.^^xsd:string</para>
    ///   <a href="http://w3id.org/roh#Expense">roh:Expense</a>
    /// </summary>
    let Expense = _prefixId.prefix "Expense"
    /// <summary>
    ///   <para>rdfs:label : Expense Classification</para>
    ///   <a href="http://w3id.org/roh#ExpenseClassification">roh:ExpenseClassification</a>
    /// </summary>
    let ExpenseClassification = _prefixId.prefix "ExpenseClassification"
    /// <summary>
    ///   <para>rdfs:label : Experimental Protocolrdfs:label : Protocolo Experimental</para>
    ///   <a href="http://w3id.org/roh#ExperimentalProtocol">roh:ExperimentalProtocol</a>
    /// </summary>
    let ExperimentalProtocol = _prefixId.prefix "ExperimentalProtocol"
    /// <summary>
    ///   <para>rdfs:label : Experimental Protocol Resultrdfs:label : Resultado del Protocolo Experimental</para>
    ///   <para>rdfs:comment : Document that contains the result or execution of a Experimental Protocol.rdfs:comment : Documento que describe el resultado y la ejecución del protocolo experimental.</para>
    ///   <a href="http://w3id.org/roh#ExperimentalProtocolResult">roh:ExperimentalProtocolResult</a>
    /// </summary>
    let ExperimentalProtocolResult = _prefixId.prefix "ExperimentalProtocolResult"
    /// <summary>
    ///   <para>rdfs:label : External Member Rolerdfs:label : Rol de Miembro Externo</para>
    ///   <para>rdfs:comment : A member who works in a Project or participates in an Activity but do not belong to the main Organization.</para>
    ///   <a href="http://w3id.org/roh#ExternalMemberRole">roh:ExternalMemberRole</a>
    /// </summary>
    let ExternalMemberRole = _prefixId.prefix "ExternalMemberRole"
    /// <summary>
    ///   <para>rdfs:label : Faculty Position Emeritusrdfs:label : Posición de Profesor Emérito</para>
    ///   <para>rdfs:comment : A retired professor who has retained their rank, title and privileges.</para>
    ///   <a href="http://w3id.org/roh#FacultyPositionEmeritus">roh:FacultyPositionEmeritus</a>
    /// </summary>
    let FacultyPositionEmeritus = _prefixId.prefix "FacultyPositionEmeritus"
    /// <summary>
    ///   <para>rdfs:label : Final</para>
    ///   <a href="http://w3id.org/roh#Final">roh:Final</a>
    /// </summary>
    let Final = _prefixId.prefix "Final"
    /// <summary>
    ///   <para>rdfs:label : Funded</para>
    ///   <a href="http://w3id.org/roh#Funded">roh:Funded</a>
    /// </summary>
    let Funded = _prefixId.prefix "Funded"
    /// <summary>
    ///   <para>rdfs:label : Financiaciónrdfs:label : Funding</para>
    ///   <para>rdfs:comment : A roh:Funding is the funding associated to a vivo:Project whose funding is associated to a roh:FundingProgram, which in turn is associated to a vivo:FundingOrganization. A roh:Funding consists of several roh:FundingAmounts, associated to the different entities that participate in a project and to the annuities in which they do it.  Funding gathers information about the total funding received for a Project and its currency through properties roh:monetaryAmount and roh:currency. A roh:FundingSource funds a roh:FundingProgram. A roh:Funding supports a vivo:Project or a roh:PersonContract. A Funding can be tagged as public or private, by updating the data property roh:publicFunding.^^xsd:string</para>
    ///   <a href="http://w3id.org/roh#Funding">roh:Funding</a>
    /// </summary>
    let Funding = _prefixId.prefix "Funding"
    /// <summary>
    ///   <para>rdfs:label : Funding Amountrdfs:label : Monto de Financiación</para>
    ///   <para>rdfs:comment : A roh:FundingAmount is linked to a roh:Funding which is roh:fundedBy a roh:FundingProgram and finances a Project (through roh:supports relationship). Each FundingAmount is associated to an Organization participating in the Project (through roh:grants relationship) for each project specific annuity.^^rdfs:Literal</para>
    ///   <a href="http://w3id.org/roh#FundingAmount">roh:FundingAmount</a>
    /// </summary>
    let FundingAmount = _prefixId.prefix "FundingAmount"
    /// <summary>
    ///   <para>rdfs:label : Funding programmerdfs:label : Programa de Financiaciónrdfs:label : Funding Program</para>
    ///   <para>rdfs:comment : A roh:FundingProgram is promoted (roh:promotedBy) by a Funding Organization (vivo:FundingOrganization) and it is in place for a time interval (vivo:dateTimeInterval)^^xsd:stringrdfs:comment : A programme of related funded projects, typically established by a funding organization.</para>
    ///   <a href="http://w3id.org/roh#FundingProgram">roh:FundingProgram</a>
    /// </summary>
    let FundingProgram = _prefixId.prefix "FundingProgram"
    /// <summary>
    ///   <para>rdfs:label : Funding Program Classification</para>
    ///   <a href="http://w3id.org/roh#FundingProgramClassification">roh:FundingProgramClassification</a>
    /// </summary>
    let FundingProgramClassification = _prefixId.prefix "FundingProgramClassification"
    /// <summary>
    ///   <para>rdfs:label : Fuente de Financiaciónrdfs:label : Funding Source</para>
    ///   <para>rdfs:comment : We have just considered a subset of the available funding sources, taking into account the sample datasets provided by University of Murcia
    ///
    /// A roh:FundingSource roh:feeds a roh:Funding with funds to sponsor some projects.</para>
    ///   <a href="http://w3id.org/roh#FundingSource">roh:FundingSource</a>
    /// </summary>
    let FundingSource = _prefixId.prefix "FundingSource"
    /// <summary>
    ///   <para>rdfs:label : GitHub Repositoryrdfs:label : Repositorio de GitHub</para>
    ///   <para>rdfs:comment : Es un repositorio concreto almacenado en https://github.com.rdfs:comment : It's a concrete Repository that is stored in https://github.com.</para>
    ///   <a href="http://w3id.org/roh#GitHubRepository">roh:GitHubRepository</a>
    /// </summary>
    let GitHubRepository = _prefixId.prefix "GitHubRepository"
    /// <summary>
    ///   <para>rdfs:label : Grantrdfs:label : Subvención</para>
    ///   <para>rdfs:comment : A financial award provided by a funding organisation for a particular project or purpose, usually awarded on the basis of a competitive application.rdfs:comment : An amount of money given especially by the government to a person or organization for a special purpose.</para>
    ///   <a href="http://w3id.org/roh#Grant">roh:Grant</a>
    /// </summary>
    let Grant = _prefixId.prefix "Grant"
    /// <summary>
    ///   <para>rdfs:label : Clasificación de los recursos humanosrdfs:label : Human Resource Classification</para>
    ///   <a href="http://w3id.org/roh#HRClassification">roh:HRClassification</a>
    /// </summary>
    let HRClassification = _prefixId.prefix "HRClassification"
    /// <summary>
    ///   <para>rdfs:comment : Inventionrdfs:comment : A new device, method, or process developed from study and experimentation in the framework of research.</para>
    ///   <para>rdfs:label : Invention</para>
    ///   <a href="http://w3id.org/roh#Invention">roh:Invention</a>
    /// </summary>
    let Invention = _prefixId.prefix "Invention"
    /// <summary>
    ///   <para>rdfs:label : Facturardfs:label : Invoice</para>
    ///   <a href="http://w3id.org/roh#Invoice">roh:Invoice</a>
    /// </summary>
    let Invoice = _prefixId.prefix "Invoice"
    /// <summary>
    ///   <para>rdfs:label : Journal Metricrdfs:label : Metrica de una revista</para>
    ///   <para>rdfs:comment : This is the metric of a jorunal. When the journal metric is updated, a new journal metric must be created with the same impactFactorName but with the updated impactFactor, ranking and quartile values.rdfs:comment : Esta entidad es la metrica de una revista. Cada cierto tiempo se actualiza la metrica de cada revista por lo que esa revista debe  crear una nueva JournalMetric con el mismo impactFactorName pero en la cual los valores de fecha impactFactor, ranking y quartile esten actualizados.</para>
    ///   <a href="http://w3id.org/roh#JournalMetric">roh:JournalMetric</a>
    /// </summary>
    let JournalMetric = _prefixId.prefix "JournalMetric"
    /// <summary>
    ///   <para>rdfs:label : Justification</para>
    ///   <para>rdfs:comment : A Justification is a bibo:Report used to justify eithet technically, economically or both a project.^^xsd:string</para>
    ///   <a href="http://w3id.org/roh#Justification">roh:Justification</a>
    /// </summary>
    let Justification = _prefixId.prefix "Justification"
    /// <summary>
    ///   <para>http://w3id.org/roh/mirror/skos#altLabel : Cadeira</para>
    ///   <para>rdfs:label : Knowledge Areardfs:label : Área de Conocimiento</para>
    ///   <para>rdfs:comment : ROH will be populated with instance data of UNESCO skos concepts. A Person, Activity, Project and Organization can be qualified by a KnowledgeArea^^xsd:string</para>
    ///   <a href="http://w3id.org/roh#KnowledgeArea">roh:KnowledgeArea</a>
    /// </summary>
    let KnowledgeArea = _prefixId.prefix "KnowledgeArea"
    /// <summary>
    ///   <para>rdfs:label : Language Certificaterdfs:label : Certificado de Idioma</para>
    ///   <para>rdfs:comment : A language certificate from the Common European Framework of Reference for Languages: Learning, Teaching, Assessment.</para>
    ///   <a href="http://w3id.org/roh#LanguageCertificate">roh:LanguageCertificate</a>
    /// </summary>
    let LanguageCertificate = _prefixId.prefix "LanguageCertificate"
    /// <summary>
    ///   <para>rdfs:label : Empresa granrdfs:label : Empresa granderdfs:label : Grande empresardfs:label : Large Enterpriserdfs:label : Large enterprise</para>
    ///   <a href="http://w3id.org/roh#LargeEnterprise">roh:LargeEnterprise</a>
    /// </summary>
    let LargeEnterprise = _prefixId.prefix "LargeEnterprise"
    /// <summary>
    ///   <para>rdfs:label : Librarian Position Emeritusrdfs:label : Posición de Bibliotecario Emérito</para>
    ///   <para>rdfs:comment : A retired librarian who has retained their rank, title and privileges.</para>
    ///   <a href="http://w3id.org/roh#LibrarianPositionEmeritus">roh:LibrarianPositionEmeritus</a>
    /// </summary>
    let LibrarianPositionEmeritus = _prefixId.prefix "LibrarianPositionEmeritus"
    /// <summary>
    ///   <para>rdfs:label : Loanrdfs:label : Préstamo</para>
    ///   <para>rdfs:comment : An amount of money that is borrowed, often from a bank or a funding organization, and has to be paid back, usually together with an extra amount of money that you have to pay as a charge for borrowing.</para>
    ///   <a href="http://w3id.org/roh#Loan">roh:Loan</a>
    /// </summary>
    let Loan = _prefixId.prefix "Loan"
    /// <summary>
    ///   <para>rdfs:label : ManagementUnit</para>
    ///   <a href="http://w3id.org/roh#ManagementUnit">roh:ManagementUnit</a>
    /// </summary>
    let ManagementUnit = _prefixId.prefix "ManagementUnit"
    /// <summary>
    ///   <para>rdfs:label : Magister Scientiaerdfs:label : Maîtrise universitairerdfs:label : Maîtrise universitairerdfs:label : Maîtrise universitairerdfs:label : Maîtrise universitairerdfs:label : Mestradordfs:label : Mestradordfs:label : Master's degreerdfs:label : Máster universitariordfs:label : Máster universitariordfs:label : Màster universitarirdfs:label : Màster universitari</para>
    ///   <para>http://w3id.org/roh/mirror/skos#prefLabel : Màster universitarihttp://w3id.org/roh/mirror/skos#prefLabel : Màster universitarihttp://w3id.org/roh/mirror/skos#prefLabel : Maîtrise universitairehttp://w3id.org/roh/mirror/skos#prefLabel : Maîtrise universitairehttp://w3id.org/roh/mirror/skos#prefLabel : Maîtrise universitairehttp://w3id.org/roh/mirror/skos#prefLabel : Master's degreehttp://w3id.org/roh/mirror/skos#prefLabel : Maîtrise universitairehttp://w3id.org/roh/mirror/skos#prefLabel : Mestradohttp://w3id.org/roh/mirror/skos#prefLabel : Mestradohttp://w3id.org/roh/mirror/skos#prefLabel : Magister Scientiaehttp://w3id.org/roh/mirror/skos#prefLabel : Máster universitariohttp://w3id.org/roh/mirror/skos#prefLabel : Máster universitario</para>
    ///   <para>http://w3id.org/roh/mirror/skos#altLabel : Mestrado universitariohttp://w3id.org/roh/mirror/skos#altLabel : Mestratge universitarihttp://w3id.org/roh/mirror/skos#altLabel : Mestratge universitari</para>
    ///   <a href="http://w3id.org/roh#MastersDegree">roh:MastersDegree</a>
    /// </summary>
    let MastersDegree = _prefixId.prefix "MastersDegree"
    /// <summary>
    ///   <para>rdfs:label : Assignatura de mestratgerdfs:label : Unidace curricular de mestradordfs:label : Assignatura de màsterrdfs:label : Asignatura de másterrdfs:label : Master's degree subjectrdfs:label : Asignatura de máster</para>
    ///   <para>rdfs:comment : Matière de masterrdfs:comment : Matière de maîtrise</para>
    ///   <a href="http://w3id.org/roh#MastersDegreeSubject">roh:MastersDegreeSubject</a>
    /// </summary>
    let MastersDegreeSubject = _prefixId.prefix "MastersDegreeSubject"
    /// <summary>
    ///   <para>rdfs:label : Master's Student</para>
    ///   <a href="http://w3id.org/roh#MastersStudent">roh:MastersStudent</a>
    /// </summary>
    let MastersStudent = _prefixId.prefix "MastersStudent"

    /// <summary>
    ///   <para>rdfs:label : Master's Supervising Relationshiprdfs:label : Relación de Supervisión de Máster Universitario</para>
    ///   <a href="http://w3id.org/roh#MastersSupervisingRelationship">roh:MastersSupervisingRelationship</a>
    /// </summary>
    let MastersSupervisingRelationship = _prefixId.prefix "MastersSupervisingRelationship"

    /// <summary>
    ///   <para>rdfs:label : Tese de mestradordfs:label : Mémoire de maîtriserdfs:label : Mémoire de maîtriserdfs:label : Tesis de maestríardfs:label : Tesis de maestríardfs:label : Tesis de maestríardfs:label : Tesis de maestríardfs:label : Tesis de Másterrdfs:label : Traballo de fin de másterrdfs:label : Master's Thesisrdfs:label : Treball de fi de màsterrdfs:label : Treball de fi de màsterrdfs:label : Dissertação de mestradordfs:label : Dissertação de mestradordfs:label : Trabajo de fin de máster</para>
    ///   <para>http://w3id.org/roh/mirror/skos#prefLabel : Master Amaierako Lanahttp://w3id.org/roh/mirror/skos#prefLabel : Dissertação de mestradohttp://w3id.org/roh/mirror/skos#prefLabel : Dissertação de mestradohttp://w3id.org/roh/mirror/skos#prefLabel : Trabajo de fin de másterhttp://w3id.org/roh/mirror/skos#prefLabel : Tesis de maestríahttp://w3id.org/roh/mirror/skos#prefLabel : Tesis de maestríahttp://w3id.org/roh/mirror/skos#prefLabel : Tesis de maestríahttp://w3id.org/roh/mirror/skos#prefLabel : Tesis de maestríahttp://w3id.org/roh/mirror/skos#prefLabel : Tese de mestradohttp://w3id.org/roh/mirror/skos#prefLabel : Mémoire de maîtrisehttp://w3id.org/roh/mirror/skos#prefLabel : Mémoire de maîtrisehttp://w3id.org/roh/mirror/skos#prefLabel : Treball de fi de màsterhttp://w3id.org/roh/mirror/skos#prefLabel : Treball de fi de màsterhttp://w3id.org/roh/mirror/skos#prefLabel : Traballo de fin de másterhttp://w3id.org/roh/mirror/skos#prefLabel : Master's thesis</para>
    ///   <para>http://w3id.org/roh/mirror/skos#altLabel : TFMhttp://w3id.org/roh/mirror/skos#altLabel : TFMhttp://w3id.org/roh/mirror/skos#altLabel : TFMhttp://w3id.org/roh/mirror/skos#altLabel : TFMhttp://w3id.org/roh/mirror/skos#altLabel : Traballo de fin de mestradohttp://w3id.org/roh/mirror/skos#altLabel : Trabajo de fin de masterhttp://w3id.org/roh/mirror/skos#altLabel : Treball de fi de masterhttp://w3id.org/roh/mirror/skos#altLabel : Treball de fi de masterhttp://w3id.org/roh/mirror/skos#altLabel : MALahttp://w3id.org/roh/mirror/skos#altLabel : Treball de fi de mestratgehttp://w3id.org/roh/mirror/skos#altLabel : Treball de fi de mestratge</para>
    ///   <para>rdfs:comment : A thesis reporting a research project undertaken as part of a second-cycle course of education to receive a master's degree.rdfs:comment : A document created to summarize research findings associated with the completion of a master's degree.</para>
    ///   <a href="http://w3id.org/roh#MastersThesis">roh:MastersThesis</a>
    /// </summary>
    let MastersThesis = _prefixId.prefix "MastersThesis"
    /// <summary>
    ///   <para>rdfs:label : Medium Enterprise</para>
    ///   <para>rdfs:comment : An enterprise which employ fewer than 250 persons and which have an annual turnover not exceeding EUR 50 million, and/or an annual balance sheet total not exceeding EUR 43 million.</para>
    ///   <a href="http://w3id.org/roh#MediumEnterprise">roh:MediumEnterprise</a>
    /// </summary>
    let MediumEnterprise = _prefixId.prefix "MediumEnterprise"
    /// <summary>
    ///   <para>rdfs:label : Metricrdfs:label : Métrica</para>
    ///   <para>rdfs:comment : An roh:Metric indicates qualifies a roh:ResearchObject according to common established quality measurement metrics, e.g. impact factor or mark in an PhD viva.^^xsd:string</para>
    ///   <a href="http://w3id.org/roh#Metric">roh:Metric</a>
    /// </summary>
    let Metric = _prefixId.prefix "Metric"
    /// <summary>
    ///   <para>rdfs:label : Micro Enterprise</para>
    ///   <para>rdfs:comment : An enterprise which employs fewer than 10 persons and whose annual turnover and/or annual balance sheet total does not exceed EUR 2 million.</para>
    ///   <a href="http://w3id.org/roh#MicroEnterprise">roh:MicroEnterprise</a>
    /// </summary>
    let MicroEnterprise = _prefixId.prefix "MicroEnterprise"
    /// <summary>
    ///   <para>rdfs:label : ORCID</para>
    ///   <a href="http://w3id.org/roh#ORCID">roh:ORCID</a>
    /// </summary>
    let ORCID = _prefixId.prefix "ORCID"
    /// <summary>
    ///   <para>rdfs:label : Open</para>
    ///   <a href="http://w3id.org/roh#Open">roh:Open</a>
    /// </summary>
    let Open = _prefixId.prefix "Open"
    /// <summary>
    ///   <para>rdfs:label : Outsourcingrdfs:label : Subcontratación</para>
    ///   <para>rdfs:comment : The process of paying to have part of a company's work done by another company.</para>
    ///   <a href="http://w3id.org/roh#Outsourcing">roh:Outsourcing</a>
    /// </summary>
    let Outsourcing = _prefixId.prefix "Outsourcing"
    /// <summary>
    ///   <para>rdfs:label : Charla en Panelrdfs:label : Panel Talk</para>
    ///   <para>rdfs:comment : A group of people gathered to discuss a topic in front of an audience, typically at scientific, business, or academic conferences, fan conventions, and on television shows. Panels usually include a moderator who guides the discussion and sometimes elicits audience questions, with the goal of being informative and entertaining</para>
    ///   <a href="http://w3id.org/roh#PanelTalk">roh:PanelTalk</a>
    /// </summary>
    let PanelTalk = _prefixId.prefix "PanelTalk"
    /// <summary>
    ///   <para>rdfs:label : Patent Application</para>
    ///   <a href="http://w3id.org/roh#PatentApplication">roh:PatentApplication</a>
    /// </summary>
    let PatentApplication = _prefixId.prefix "PatentApplication"
    /// <summary>
    ///   <para>rdfs:label : Patent Contract</para>
    ///   <a href="http://w3id.org/roh#PatentContract">roh:PatentContract</a>
    /// </summary>
    let PatentContract = _prefixId.prefix "PatentContract"
    /// <summary>
    ///   <para>rdfs:label : Patent Expense</para>
    ///   <a href="http://w3id.org/roh#PatentExpense">roh:PatentExpense</a>
    /// </summary>
    let PatentExpense = _prefixId.prefix "PatentExpense"
    /// <summary>
    ///   <para>rdfs:label : Contrato de trabalhordfs:label : Contrat de travailrdfs:label : Contracte de treballrdfs:label : Contracte de treballrdfs:label : Contrato de trabajordfs:label : Contrato de Personardfs:label : Person Contract</para>
    ///   <para>rdfs:comment : An agreement between a person and an organization to work in a project for a specified duration.</para>
    ///   <para>http://w3id.org/roh/mirror/skos#prefLabel : Contrato de trabalhohttp://w3id.org/roh/mirror/skos#prefLabel : Contracte de treballhttp://w3id.org/roh/mirror/skos#prefLabel : Contracte de treballhttp://w3id.org/roh/mirror/skos#prefLabel : Employment contracthttp://w3id.org/roh/mirror/skos#prefLabel : Contrat de travailhttp://w3id.org/roh/mirror/skos#prefLabel : Contrato de trabajo</para>
    ///   <a href="http://w3id.org/roh#PersonContract">roh:PersonContract</a>
    /// </summary>
    let PersonContract = _prefixId.prefix "PersonContract"
    /// <summary>
    ///   <para>rdfs:label : Gasto de Personardfs:label : Person Expense</para>
    ///   <para>rdfs:comment : A ProjectExpense is carried out by a Researcher (by default the principal researcher) in charge of a Project, which indirectly links it to Funding, understood as a set of FundingAmounts. The types of expenses considered are: Personnel Expenses, Subcontracting, Travel, Equipment, Research Infrastructure and Other Goods and Services."^^rdfs:Literal</para>
    ///   <a href="http://w3id.org/roh#PersonExpense">roh:PersonExpense</a>
    /// </summary>
    let PersonExpense = _prefixId.prefix "PersonExpense"
    /// <summary>
    ///   <para>rdfs:label : PhD Supervising Relationshiprdfs:label : Relación de Supervisión de Doctorado</para>
    ///   <a href="http://w3id.org/roh#PhDSupervisingRelationship">roh:PhDSupervisingRelationship</a>
    /// </summary>
    let PhDSupervisingRelationship = _prefixId.prefix "PhDSupervisingRelationship"
    /// <summary>
    ///   <para>http://w3id.org/roh/mirror/skos#altLabel : Tese de doutoramento</para>
    ///   <para>rdfs:label : Tese doctoralrdfs:label : Tesis doctoralrdfs:label : Thèse doctoralerdfs:label : Doktore tesirdfs:label : Tesis de Doctoradordfs:label : Tese de doutoramentordfs:label : Tesi doctoralrdfs:label : Tesi doctoralrdfs:label : PhD Thesisrdfs:label : Doctoral thesis</para>
    ///   <para>http://w3id.org/roh/mirror/skos#prefLabel : Tesi doctoralhttp://w3id.org/roh/mirror/skos#prefLabel : Doctoral thesishttp://w3id.org/roh/mirror/skos#prefLabel : Tesis doctoralhttp://w3id.org/roh/mirror/skos#prefLabel : Doktorego tesihttp://w3id.org/roh/mirror/skos#prefLabel : Tese doctoralhttp://w3id.org/roh/mirror/skos#prefLabel : Tese de doutoramentohttp://w3id.org/roh/mirror/skos#prefLabel : Thèse doctoralehttp://w3id.org/roh/mirror/skos#prefLabel : Tesi doctoral</para>
    ///   <para>rdfs:comment : A thesis reporting a research project undertaken as part of an undergraduate course of education to receive a doctoral degree.rdfs:comment : A document created to summarize research findings associated with the completion of a doctoral thesis.</para>
    ///   <a href="http://w3id.org/roh#PhDThesis">roh:PhDThesis</a>
    /// </summary>
    let PhDThesis = _prefixId.prefix "PhDThesis"
    /// <summary>
    ///   <para>rdfs:label : Métrica de Tesis Doctoralrdfs:label : PhD Thesis Metric</para>
    ///   <a href="http://w3id.org/roh#PhDThesisMetric">roh:PhDThesisMetric</a>
    /// </summary>
    let PhDThesisMetric = _prefixId.prefix "PhDThesisMetric"
    /// <summary>
    ///   <para>rdfs:label : Press Article</para>
    ///   <a href="http://w3id.org/roh#PressArticle">roh:PressArticle</a>
    /// </summary>
    let PressArticle = _prefixId.prefix "PressArticle"
    /// <summary>
    ///   <para>rdfs:label : Product</para>
    ///   <para>rdfs:comment : A product as outcome of a project.</para>
    ///   <a href="http://w3id.org/roh#Product">roh:Product</a>
    /// </summary>
    let Product = _prefixId.prefix "Product"
    /// <summary>
    ///   <para>rdfs:label : Proforma invoice</para>
    ///   <a href="http://w3id.org/roh#ProformaInvoice">roh:ProformaInvoice</a>
    /// </summary>
    let ProformaInvoice = _prefixId.prefix "ProformaInvoice"
    /// <summary>
    ///   <para>rdfs:label : Clasificación de Proyectordfs:label : Project Classification</para>
    ///   <a href="http://w3id.org/roh#ProjectClassification">roh:ProjectClassification</a>
    /// </summary>
    let ProjectClassification = _prefixId.prefix "ProjectClassification"
    /// <summary>
    ///   <para>rdfs:label : Contrato de Proyectordfs:label : Project Contract</para>
    ///   <para>rdfs:comment : An agreement among different organizations to work in a project for a specified duration.</para>
    ///   <a href="http://w3id.org/roh#ProjectContract">roh:ProjectContract</a>
    /// </summary>
    let ProjectContract = _prefixId.prefix "ProjectContract"
    /// <summary>
    ///   <para>rdfs:label : Gasto de Proyectordfs:label : Project Expense</para>
    ///   <para>rdfs:comment : A ProjectExpense is carried out by a Researcher (by default the principal researcher) in charge of a Project, which indirectly links it to Funding, understood as a set of FundingAmounts. The types of expenses considered are: Personnel Expenses, Subcontracting, Travel, Equipment, Research Infrastructure and Other Goods and Services.^^rdfs:Literal</para>
    ///   <a href="http://w3id.org/roh#ProjectExpense">roh:ProjectExpense</a>
    /// </summary>
    let ProjectExpense = _prefixId.prefix "ProjectExpense"
    /// <summary>
    ///   <para>rdfs:label : Clasificación de la propiedadrdfs:label : Property Classification</para>
    ///   <a href="http://w3id.org/roh#PropertyClassification">roh:PropertyClassification</a>
    /// </summary>
    let PropertyClassification = _prefixId.prefix "PropertyClassification"
    /// <summary>
    ///   <para>rdfs:label : Proposal Submitted</para>
    ///   <a href="http://w3id.org/roh#ProposalSubmitted">roh:ProposalSubmitted</a>
    /// </summary>
    let ProposalSubmitted = _prefixId.prefix "ProposalSubmitted"
    /// <summary>
    ///   <para>rdfs:label : Prototype</para>
    ///   <para>rdfs:comment : A product prototype</para>
    ///   <a href="http://w3id.org/roh#Prototype">roh:Prototype</a>
    /// </summary>
    let Prototype = _prefixId.prefix "Prototype"
    /// <summary>
    ///   <para>rdfs:label : Provisional</para>
    ///   <a href="http://w3id.org/roh#Provisional">roh:Provisional</a>
    /// </summary>
    let Provisional = _prefixId.prefix "Provisional"
    /// <summary>
    ///   <para>rdfs:label : Métrica de Publicaciónrdfs:label : Publication Metric</para>
    ///   <para>rdfs:comment : An article is cited roh:citationCount times in the roh:metricName network. Example: if an article is cited 5 times in the Web of Science, then the roh:metricName should be Web of Science and the roh:citationCount 5. Thus, a roh:metricName can be roh and the value of roh:citationCount the number of times that article has been cited in the knowledge graph of this ontology.rdfs:comment : Un artículo es citado roh:citationCount veces en la red the roh:metricName. Ejemplo: si un artículo ha sido citado 5 veces en la Web of Science, entonces los atributos roh:metricName debe ser Web Of Science y roh:citationCount 5. De este modo, una roh:metricName puede ser roh y el valor de roh:citationCount el número de veces que dicho artículo ha sido citado en el grafo de conocimiento de esta ontología.</para>
    ///   <a href="http://w3id.org/roh#PublicationMetric">roh:PublicationMetric</a>
    /// </summary>
    let PublicationMetric = _prefixId.prefix "PublicationMetric"
    /// <summary>
    ///   <para>rdfs:label : README</para>
    ///   <para>rdfs:comment : Documento llamado README que describe el contenido de un Repositorio.rdfs:comment : The document named README that describe the content of a concret Repository.</para>
    ///   <a href="http://w3id.org/roh#README">roh:README</a>
    /// </summary>
    let README = _prefixId.prefix "README"
    /// <summary>
    ///   <para>rdfs:label : Radio Program</para>
    ///   <a href="http://w3id.org/roh#RadioProgram">roh:RadioProgram</a>
    /// </summary>
    let RadioProgram = _prefixId.prefix "RadioProgram"
    /// <summary>
    ///   <para>rdfs:label : RefundableAdvance</para>
    ///   <a href="http://w3id.org/roh#RefundableAdvance">roh:RefundableAdvance</a>
    /// </summary>
    let RefundableAdvance = _prefixId.prefix "RefundableAdvance"
    /// <summary>
    ///   <para>rdfs:label : Rejected</para>
    ///   <a href="http://w3id.org/roh#Rejected">roh:Rejected</a>
    /// </summary>
    let Rejected = _prefixId.prefix "Rejected"
    let Repository = _prefixId.prefix "Repository"
    /// <summary>
    ///   <para>rdfs:label : Acreditación de Investigaciónrdfs:label : Research Accreditation</para>
    ///   <para>rdfs:comment : An attestation of qualification, competence, or authority issued to an individual by a third party with a relevant or  de facto authority or assumed competence to do so in the research field.</para>
    ///   <a href="http://w3id.org/roh#ResearchAccreditation">roh:ResearchAccreditation</a>
    /// </summary>
    let ResearchAccreditation = _prefixId.prefix "ResearchAccreditation"
    /// <summary>
    ///   <para>rdfs:label : Research contribution</para>
    ///   <a href="http://w3id.org/roh#ResearchContribution">roh:ResearchContribution</a>
    /// </summary>
    let ResearchContribution = _prefixId.prefix "ResearchContribution"
    /// <summary>
    ///   <para>rdfs:label : Grup d'investigaciórdfs:label : Research Grouprdfs:label : Research grouprdfs:label : Grupo de investigaçãordfs:label : Group de rechercherdfs:label : Grupo de investigaciónrdfs:label : Grupo de Investigaciónrdfs:label : Grup de recerca</para>
    ///   <para>http://w3id.org/roh/mirror/skos#prefLabel : Grupo de investigaçãohttp://w3id.org/roh/mirror/skos#prefLabel : Grupo de investigaciónhttp://w3id.org/roh/mirror/skos#prefLabel : Group de recherchehttp://w3id.org/roh/mirror/skos#prefLabel : Grup d'investigacióhttp://w3id.org/roh/mirror/skos#prefLabel : Grup de recercahttp://w3id.org/roh/mirror/skos#prefLabel : Research group</para>
    ///   <para>rdfs:comment : A group of researchers often from the same centre, specialised on the same subject, working together on the issue or topic.</para>
    ///   <a href="http://w3id.org/roh#ResearchGroup">roh:ResearchGroup</a>
    /// </summary>
    let ResearchGroup = _prefixId.prefix "ResearchGroup"
    /// <summary>
    ///   <para>rdfs:label : Research Group Metric</para>
    ///   <a href="http://w3id.org/roh#ResearchGroupMetric">roh:ResearchGroupMetric</a>
    /// </summary>
    let ResearchGroupMetric = _prefixId.prefix "ResearchGroupMetric"
    /// <summary>
    ///   <para>http://w3id.org/roh/mirror/skos#prefLabel : Centre de recercahttp://w3id.org/roh/mirror/skos#prefLabel : Research institutehttp://w3id.org/roh/mirror/skos#prefLabel : Centro de investigaciónhttp://w3id.org/roh/mirror/skos#prefLabel : Centre d'investigacióhttp://w3id.org/roh/mirror/skos#prefLabel : Centro de investigaçãohttp://w3id.org/roh/mirror/skos#prefLabel : Centre de recherche</para>
    ///   <para>rdfs:label : Research instituterdfs:label : Centro de investigaciónrdfs:label : Centre de rechercherdfs:label : Centro de investigaçãordfs:label : Centre de recercardfs:label : Centre d'investigació</para>
    ///   <para>rdfs:comment : An establishment founded for doing research.</para>
    ///   <a href="http://w3id.org/roh#ResearchInstitute">roh:ResearchInstitute</a>
    /// </summary>
    let ResearchInstitute = _prefixId.prefix "ResearchInstitute"
    /// <summary>
    ///   <para>http://w3id.org/roh/mirror/skos#prefLabel : Research material</para>
    ///   <para>rdfs:label : Research material</para>
    ///   <a href="http://w3id.org/roh#ResearchMaterial">roh:ResearchMaterial</a>
    /// </summary>
    let ResearchMaterial = _prefixId.prefix "ResearchMaterial"
    /// <summary>
    ///   <para>http://w3id.org/roh/mirror/skos#prefLabel : Research method</para>
    ///   <para>rdfs:label : Research method</para>
    ///   <a href="http://w3id.org/roh#ResearchMethod">roh:ResearchMethod</a>
    /// </summary>
    let ResearchMethod = _prefixId.prefix "ResearchMethod"
    /// <summary>
    ///   <para>rdfs:label : Objecto de investigaciónrdfs:label : Research Object</para>
    ///   <para>rdfs:comment : A roh:ResearchObject is generated by one to several foaf:Person specified through property bibo:authorList. Usually a roh:ResearchObject results from the work in a vivo:Project (roh:produces). An elaborated taxonomy of research objects is provided, covering all types of publications, Patents, Software and Webpage. The main author of a research object is accessible through property roh:correspondingAuthor.</para>
    ///   <a href="http://w3id.org/roh#ResearchObject">roh:ResearchObject</a>
    /// </summary>
    let ResearchObject = _prefixId.prefix "ResearchObject"
    /// <summary>
    ///   <para>rdfs:label : Gasto de Objeto de Investigaciónrdfs:label : Research Object Expense</para>
    ///   <a href="http://w3id.org/roh#ResearchObjectExpense">roh:ResearchObjectExpense</a>
    /// </summary>
    let ResearchObjectExpense = _prefixId.prefix "ResearchObjectExpense"
    /// <summary>
    ///   <para>http://w3id.org/roh/mirror/skos#prefLabel : Research problem</para>
    ///   <para>rdfs:label : Research problem</para>
    ///   <a href="http://w3id.org/roh#ResearchProblem">roh:ResearchProblem</a>
    /// </summary>
    let ResearchProblem = _prefixId.prefix "ResearchProblem"
    /// <summary>
    ///   <para>rdfs:label : Resultado de investigaciónrdfs:label : Research Result</para>
    ///   <a href="http://w3id.org/roh#ResearchResult">roh:ResearchResult</a>
    /// </summary>
    let ResearchResult = _prefixId.prefix "ResearchResult"
    /// <summary>
    ///   <para>rdfs:label : Posición de Investigadorrdfs:label : Researcher Position</para>
    ///   <para>rdfs:comment : A member of a university or research organization focused on research task further than other ones.</para>
    ///   <a href="http://w3id.org/roh#ResearcherPosition">roh:ResearcherPosition</a>
    /// </summary>
    let ResearcherPosition = _prefixId.prefix "ResearcherPosition"
    /// <summary>
    ///   <para>rdfs:label : Researching</para>
    ///   <a href="http://w3id.org/roh#Researching">roh:Researching</a>
    /// </summary>
    let Researching = _prefixId.prefix "Researching"
    /// <summary>
    ///   <para>rdfs:label : Reservablerdfs:label : Reservable</para>
    ///   <para>rdfs:comment : Some resources may available by an organization to be used by others.</para>
    ///   <a href="http://w3id.org/roh#Reservable">roh:Reservable</a>
    /// </summary>
    let Reservable = _prefixId.prefix "Reservable"
    /// <summary>
    ///   <para>rdfs:label : ReservableConsumerRole</para>
    ///   <a href="http://w3id.org/roh#ReservableConsumerRole">roh:ReservableConsumerRole</a>
    /// </summary>
    let ReservableConsumerRole = _prefixId.prefix "ReservableConsumerRole"
    /// <summary>
    ///   <para>rdfs:label : ReservableProviderRole</para>
    ///   <a href="http://w3id.org/roh#ReservableProviderRole">roh:ReservableProviderRole</a>
    /// </summary>
    let ReservableProviderRole = _prefixId.prefix "ReservableProviderRole"
    /// <summary>
    ///   <para>rdfs:label : Reservable Softwarerdfs:label : Software Reservable</para>
    ///   <para>rdfs:comment : Esta entidad denota el Software que es reservable.rdfs:comment : Software that is reservable.</para>
    ///   <a href="http://w3id.org/roh#ReservableSoftware">roh:ReservableSoftware</a>
    /// </summary>
    let ReservableSoftware = _prefixId.prefix "ReservableSoftware"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A dual relationship of one organization offering a service to another organization, typically including start and end dates^^xsd:string</para>
    ///   <para>rdfs:label : Reservation Relationship</para>
    ///   <a href="http://w3id.org/roh#ReservationRelationship">roh:ReservationRelationship</a>
    /// </summary>
    let ReservationRelationship = _prefixId.prefix "ReservationRelationship"
    /// <summary>
    ///   <para>rdfs:label : Round Table</para>
    ///   <a href="http://w3id.org/roh#RoundTable">roh:RoundTable</a>
    /// </summary>
    let RoundTable = _prefixId.prefix "RoundTable"
    /// <summary>
    ///   <para>http://w3id.org/roh/mirror/skos#prefLabel : Seal of qualityhttp://w3id.org/roh/mirror/skos#prefLabel : Segell de qualitathttp://w3id.org/roh/mirror/skos#prefLabel : Segell de qualitathttp://w3id.org/roh/mirror/skos#prefLabel : Selo de qualidadehttp://w3id.org/roh/mirror/skos#prefLabel : Sello de calidadhttp://w3id.org/roh/mirror/skos#prefLabel : Label qualité</para>
    ///   <para>rdfs:label : Label qualitérdfs:label : Seal of qualityrdfs:label : Segell de qualitatrdfs:label : Segell de qualitatrdfs:label : Selo de qualidaderdfs:label : Sello de calidad</para>
    ///   <para>rdfs:comment : A graphic mark indicating highest levels of quality in research, often measured in terms of relevant publications related to the researching activity.</para>
    ///   <a href="http://w3id.org/roh#SealOfQuality">roh:SealOfQuality</a>
    /// </summary>
    let SealOfQuality = _prefixId.prefix "SealOfQuality"
    /// <summary>
    ///   <para>rdfs:label : Contrat de servicerdfs:label : Contrato de serviciordfs:label : Contracte de serveirdfs:label : Service contractrdfs:label : Contrato de serviço</para>
    ///   <para>http://w3id.org/roh/mirror/skos#prefLabel : Contrato de serviçohttp://w3id.org/roh/mirror/skos#prefLabel : Service contracthttp://w3id.org/roh/mirror/skos#prefLabel : Contrat de servicehttp://w3id.org/roh/mirror/skos#prefLabel : Contracte de serveihttp://w3id.org/roh/mirror/skos#prefLabel : Contrato de servicio</para>
    ///   <a href="http://w3id.org/roh#ServiceContract">roh:ServiceContract</a>
    /// </summary>
    let ServiceContract = _prefixId.prefix "ServiceContract"
    /// <summary>
    ///   <para>rdfs:label : Signed</para>
    ///   <a href="http://w3id.org/roh#Signed">roh:Signed</a>
    /// </summary>
    let Signed = _prefixId.prefix "Signed"
    /// <summary>
    ///   <para>rdfs:label : Small Enterprise</para>
    ///   <para>rdfs:comment : An enterprise which employs fewer than 50 persons and whose annual turnover and/or annual balance sheet total does not exceed EUR 10 million.</para>
    ///   <a href="http://w3id.org/roh#SmallEnterprise">roh:SmallEnterprise</a>
    /// </summary>
    let SmallEnterprise = _prefixId.prefix "SmallEnterprise"
    /// <summary>
    ///   <para>rdfs:label : Status</para>
    ///   <a href="http://w3id.org/roh#Status">roh:Status</a>
    /// </summary>
    let Status = _prefixId.prefix "Status"
    /// <summary>
    ///   <para>rdfs:label : Submitted</para>
    ///   <a href="http://w3id.org/roh#Submitted">roh:Submitted</a>
    /// </summary>
    let Submitted = _prefixId.prefix "Submitted"
    /// <summary>
    ///   <para>rdfs:label : Rol de Supervisadordfs:label : Supervisee Role</para>
    ///   <a href="http://w3id.org/roh#SuperviseeRole">roh:SuperviseeRole</a>
    /// </summary>
    let SuperviseeRole = _prefixId.prefix "SuperviseeRole"
    /// <summary>
    ///   <para>rdfs:label : Relación de Supervisiónrdfs:label : Supervising Relationship</para>
    ///   <a href="http://w3id.org/roh#SupervisingRelationship">roh:SupervisingRelationship</a>
    /// </summary>
    let SupervisingRelationship = _prefixId.prefix "SupervisingRelationship"
    /// <summary>
    ///   <para>rdfs:label : Rol de Supervisorrdfs:label : Supervisor Role</para>
    ///   <a href="http://w3id.org/roh#SupervisorRole">roh:SupervisorRole</a>
    /// </summary>
    let SupervisorRole = _prefixId.prefix "SupervisorRole"
    /// <summary>
    ///   <para>rdfs:label : Teaching</para>
    ///   <a href="http://w3id.org/roh#Teaching">roh:Teaching</a>
    /// </summary>
    let Teaching = _prefixId.prefix "Teaching"
    /// <summary>
    ///   <para>http://w3id.org/roh/mirror/skos#prefLabel : Technical report</para>
    ///   <para>rdfs:label : Technical report</para>
    ///   <a href="http://w3id.org/roh#TechnicalReport">roh:TechnicalReport</a>
    /// </summary>
    let TechnicalReport = _prefixId.prefix "TechnicalReport"
    /// <summary>
    ///   <para>rdfs:label : TechnicalSupport</para>
    ///   <a href="http://w3id.org/roh#TechnicalSupport">roh:TechnicalSupport</a>
    /// </summary>
    let TechnicalSupport = _prefixId.prefix "TechnicalSupport"
    /// <summary>
    ///   <para>rdfs:label : Terminated</para>
    ///   <a href="http://w3id.org/roh#Terminated">roh:Terminated</a>
    /// </summary>
    let Terminated = _prefixId.prefix "Terminated"
    let TestAnotherGovernmentAgency = _prefixId.prefix "TestAnotherGovernmentAgency"
    let TestBook = _prefixId.prefix "TestBook"
    let TestChapterOne = _prefixId.prefix "TestChapterOne"
    let TestChapterThree = _prefixId.prefix "TestChapterThree"
    let TestChapterTwo = _prefixId.prefix "TestChapterTwo"
    let TestCoSupervisorRole = _prefixId.prefix "TestCoSupervisorRole"
    let TestDateTimeInterval = _prefixId.prefix "TestDateTimeInterval"
    let TestEndDateTimeValue = _prefixId.prefix "TestEndDateTimeValue"
    let TestFundingProgram = _prefixId.prefix "TestFundingProgram"
    let TestFundingSource = _prefixId.prefix "TestFundingSource"
    let TestGovernmentAgency = _prefixId.prefix "TestGovernmentAgency"
    let TestListofAuthors = _prefixId.prefix "TestListofAuthors"
    let TestListofEditors = _prefixId.prefix "TestListofEditors"
    let TestNonResearchSoftware = _prefixId.prefix "TestNonResearchSoftware"
    let TestOrganization = _prefixId.prefix "TestOrganization"
    let TestPhDStudent = _prefixId.prefix "TestPhDStudent"

    let TestPhDSupervisingRelationship = _prefixId.prefix "TestPhDSupervisingRelationship"

    let TestPhdCoSupervisor = _prefixId.prefix "TestPhdCoSupervisor"
    let TestPhdSupervisor = _prefixId.prefix "TestPhdSupervisor"
    let TestProject = _prefixId.prefix "TestProject"
    let TestStartDateTimeValue = _prefixId.prefix "TestStartDateTimeValue"
    let TestSuperviseeRole = _prefixId.prefix "TestSuperviseeRole"
    let TestSupervisorRole = _prefixId.prefix "TestSupervisorRole"
    /// <summary>
    ///   <para>rdfs:label : Métrica de Tesisrdfs:label : Thesis Metric</para>
    ///   <a href="http://w3id.org/roh#ThesisMetric">roh:ThesisMetric</a>
    /// </summary>
    let ThesisMetric = _prefixId.prefix "ThesisMetric"
    /// <summary>
    ///   <para>rdfs:label : Defensa de Tesisrdfs:label : Thesis Viva</para>
    ///   <para>rdfs:comment : An oral examination in which a PhD Student defends her/his doctoral thesis.</para>
    ///   <a href="http://w3id.org/roh#ThesisViva">roh:ThesisViva</a>
    /// </summary>
    let ThesisViva = _prefixId.prefix "ThesisViva"
    /// <summary>
    ///   <para>rdfs:label : Rol de Contración de Tercera Parterdfs:label : Third Party Contractor Role</para>
    ///   <para>rdfs:comment : A role of contracting someone to perform a job.</para>
    ///   <a href="http://w3id.org/roh#ThirdPartyContractorRole">roh:ThirdPartyContractorRole</a>
    /// </summary>
    let ThirdPartyContractorRole = _prefixId.prefix "ThirdPartyContractorRole"
    /// <summary>
    ///   <para>rdfs:label : Tv Program</para>
    ///   <a href="http://w3id.org/roh#TvProgram">roh:TvProgram</a>
    /// </summary>
    let TvProgram = _prefixId.prefix "TvProgram"
    /// <summary>
    ///   <para>rdfs:label : UndergraduateStudent</para>
    ///   <a href="http://w3id.org/roh#UndergraduateStudent">roh:UndergraduateStudent</a>
    /// </summary>
    let UndergraduateStudent = _prefixId.prefix "UndergraduateStudent"
    /// <summary>
    ///   <para>rdfs:label : Unfunded</para>
    ///   <a href="http://w3id.org/roh#Unfunded">roh:Unfunded</a>
    /// </summary>
    let Unfunded = _prefixId.prefix "Unfunded"
    /// <summary>
    ///   <para>rdfs:label : Division d'universitérdfs:label : Divisió d'universitatrdfs:label : Divisió d'universitatrdfs:label : División de universidaderdfs:label : University divisionrdfs:label : División de universidadrdfs:label : Divisão de universidade</para>
    ///   <para>rdfs:comment : A division within a university (school, faculty, etc.)</para>
    ///   <a href="http://w3id.org/roh#UniversityDivision">roh:UniversityDivision</a>
    /// </summary>
    let UniversityDivision = _prefixId.prefix "UniversityDivision"
    /// <summary>
    ///   <para>rdfs:label : Artículo de Seminariordfs:label : Workshop Paper</para>
    ///   <para>rdfs:comment : A paper published on a conference workshop.</para>
    ///   <a href="http://w3id.org/roh#WorkshopPaper">roh:WorkshopPaper</a>
    /// </summary>
    let WorkshopPaper = _prefixId.prefix "WorkshopPaper"
    /// <summary>
    ///   <para>rdfs:label : Repositorio de Zenodordfs:label : Zenodo Repository</para>
    ///   <para>rdfs:comment : Es un repositorio de Zenodo que podemos encontrar en https://zenodo.org.rdfs:comment : It`s a Zenodo Repository that we can find in https://zenodo.org.</para>
    ///   <a href="http://w3id.org/roh#ZenodoRepository">roh:ZenodoRepository</a>
    /// </summary>
    let ZenodoRepository = _prefixId.prefix "ZenodoRepository"
    /// <summary>
    ///   <para>rdfs:label : accreditation ofrdfs:label : acreditación de</para>
    ///   <para>rdfs:comment : An object property linking an Accreditation to the Agent is associated with.</para>
    ///   <a href="http://w3id.org/roh#accreditationOf">roh:accreditationOf</a>
    /// </summary>
    let accreditationOf = _prefixId.prefix "accreditationOf"
    /// <summary>
    ///   <para>rdfs:label : addresses</para>
    ///   <a href="http://w3id.org/roh#addresses">roh:addresses</a>
    /// </summary>
    let addresses = _prefixId.prefix "addresses"
    /// <summary>
    ///   <para>rdfs:label : advises</para>
    ///   <a href="http://w3id.org/roh#advises">roh:advises</a>
    /// </summary>
    let advises = _prefixId.prefix "advises"
    /// <summary>
    ///   <para>rdfs:label : associated with</para>
    ///   <para>rdfs:comment : an organisation (i.e. university) is associated with another organsiation (i.e. research institute).</para>
    ///   <a href="http://w3id.org/roh#associatedWith">roh:associatedWith</a>
    /// </summary>
    let associatedWith = _prefixId.prefix "associatedWith"
    /// <summary>
    ///   <para>rdfs:label : adjuntordfs:label : attachment</para>
    ///   <para>rdfs:comment : An object property describing a not machine-readable document attached to an entity offering more detailed information.</para>
    ///   <a href="http://w3id.org/roh#attachment">roh:attachment</a>
    /// </summary>
    let attachment = _prefixId.prefix "attachment"
    /// <summary>
    ///   <para>rdfs:label : authors</para>
    ///   <a href="http://w3id.org/roh#authors">roh:authors</a>
    /// </summary>
    let authors = _prefixId.prefix "authors"
    /// <summary>
    ///   <para>rdfs:label : awarded byrdfs:label : concedido por</para>
    ///   <para>rdfs:comment : An object property linking an AwardedDegree to the University that awarded it.</para>
    ///   <a href="http://w3id.org/roh#awardedBy">roh:awardedBy</a>
    /// </summary>
    let awardedBy = _prefixId.prefix "awardedBy"
    /// <summary>
    ///   <para>rdfs:label : awarded with</para>
    ///   <a href="http://w3id.org/roh#awardedWith">roh:awardedWith</a>
    /// </summary>
    let awardedWith = _prefixId.prefix "awardedWith"
    /// <summary>
    ///   <para>rdfs:label : awardsrdfs:label : concede</para>
    ///   <para>rdfs:comment : An object property linking the University awarding a degree to the AwardedDegree.</para>
    ///   <a href="http://w3id.org/roh#awards">roh:awards</a>
    /// </summary>
    let awards = _prefixId.prefix "awards"
    /// <summary>
    ///   <para>rdfs:label : birthdaterdfs:label : fecha de nacimiento</para>
    ///   <para>rdfs:comment : The birthdate of an Entity.</para>
    ///   <a href="http://w3id.org/roh#birthdate">roh:birthdate</a>
    /// </summary>
    let birthdate = _prefixId.prefix "birthdate"
    /// <summary>
    ///   <para>rdfs:label : citation count</para>
    ///   <para>rdfs:comment : the number of times a publication has been cited (when used in PublicationMetric) or the total number of citations for all of an author's works (when used in AuthorMetric)</para>
    ///   <a href="http://w3id.org/roh#citationCount">roh:citationCount</a>
    /// </summary>
    let citationCount = _prefixId.prefix "citationCount"
    /// <summary>
    ///   <para>rdfs:label : co-advised by</para>
    ///   <para>rdfs:comment : An academic publication (bachelor's thesis, master's thesis or doctoral thesis) is co-advised by an advisor.</para>
    ///   <a href="http://w3id.org/roh#coadvisedBy">roh:coadvisedBy</a>
    /// </summary>
    let coadvisedBy = _prefixId.prefix "coadvisedBy"
    /// <summary>
    ///   <para>rdfs:label : co-advises</para>
    ///   <para>rdfs:comment : A person co-advises an academic publication (bachelor's thesis, master's thesis or doctoral thesis).</para>
    ///   <a href="http://w3id.org/roh#coadvises">roh:coadvises</a>
    /// </summary>
    let coadvises = _prefixId.prefix "coadvises"
    /// <summary>
    ///   <para>rdfs:label : code of</para>
    ///   <para>rdfs:comment : A code is assigned to a concept.</para>
    ///   <a href="http://w3id.org/roh#codeOf">roh:codeOf</a>
    /// </summary>
    let codeOf = _prefixId.prefix "codeOf"
    /// <summary>
    ///   <para>rdfs:label : company founder</para>
    ///   <a href="http://w3id.org/roh#companyFounder">roh:companyFounder</a>
    /// </summary>
    let companyFounder = _prefixId.prefix "companyFounder"
    /// <summary>
    ///   <para>rdfs:label : contact info ofrdfs:label : información de contacto de</para>
    ///   <para>rdfs:comment : Specifies the contact info of type vcard:Kind for an Agent.</para>
    ///   <a href="http://w3id.org/roh#contactInfoOf">roh:contactInfoOf</a>
    /// </summary>
    let contactInfoOf = _prefixId.prefix "contactInfoOf"
    /// <summary>
    ///   <para>rdfs:label : contract ofrdfs:label : contrato de</para>
    ///   <para>rdfs:comment : An object property linking a Contract to an Entity.</para>
    ///   <a href="http://w3id.org/roh#contractOf">roh:contractOf</a>
    /// </summary>
    let contractOf = _prefixId.prefix "contractOf"
    /// <summary>
    ///   <para>rdfs:label : contract signing daterdfs:label : fecha de firma del contrato</para>
    ///   <para>rdfs:comment : An object property linking a Contract with the date (DateTimeValue) when it was signed.</para>
    ///   <a href="http://w3id.org/roh#contractSigningDate">roh:contractSigningDate</a>
    /// </summary>
    let contractSigningDate = _prefixId.prefix "contractSigningDate"
    /// <summary>
    ///   <para>rdfs:label : contract signing date ofrdfs:label : fecha de firma asociada a contrato</para>
    ///   <para>rdfs:comment : An object property linking a signing date (DateTimeValue) with a Contract.</para>
    ///   <a href="http://w3id.org/roh#contractSigningDateOf">roh:contractSigningDateOf</a>
    /// </summary>
    let contractSigningDateOf = _prefixId.prefix "contractSigningDateOf"
    /// <summary>
    ///   <para>rdfs:label : coordinated by</para>
    ///   <para>rdfs:comment : inverse property of 'project coordinator'</para>
    ///   <a href="http://w3id.org/roh#coordinatedBy">roh:coordinatedBy</a>
    /// </summary>
    let coordinatedBy = _prefixId.prefix "coordinatedBy"
    /// <summary>
    ///   <para>rdfs:label : autor de correspondenciardfs:label : corresponding author</para>
    ///   <para>rdfs:comment : An object property linking an Entity to a Person, considered the author of such Thing.</para>
    ///   <a href="http://w3id.org/roh#correspondingAuthor">roh:correspondingAuthor</a>
    /// </summary>
    let correspondingAuthor = _prefixId.prefix "correspondingAuthor"
    /// <summary>
    ///   <para>rdfs:label : autor de correspondencia derdfs:label : corresponding author of</para>
    ///   <para>rdfs:comment : An object property linking a Person with a Thing, such person is corresponding author for.</para>
    ///   <a href="http://w3id.org/roh#correspondingAuthorOf">roh:correspondingAuthorOf</a>
    /// </summary>
    let correspondingAuthorOf = _prefixId.prefix "correspondingAuthorOf"
    /// <summary>
    ///   <para>rdfs:label : correspondingOrganization</para>
    ///   <a href="http://w3id.org/roh#correspondingOrganization">roh:correspondingOrganization</a>
    /// </summary>
    let correspondingOrganization = _prefixId.prefix "correspondingOrganization"
    /// <summary>
    ///   <para>rdfs:label : correspondingOrganizationOf</para>
    ///   <a href="http://w3id.org/roh#correspondingOrganizationOf">roh:correspondingOrganizationOf</a>
    /// </summary>
    let correspondingOrganizationOf = _prefixId.prefix "correspondingOrganizationOf"
    /// <summary>
    ///   <para>rdfs:label : countryrdfs:label : país</para>
    ///   <para>rdfs:comment : This property indicates the nationality of a resource. The domain is not set so unpredicted resources within the ontology could be attached to countries.</para>
    ///   <a href="http://w3id.org/roh#country">roh:country</a>
    /// </summary>
    let country = _prefixId.prefix "country"
    /// <summary>
    ///   <para>rdfs:label : course hoursrdfs:label : horas lectivas</para>
    ///   <para>rdfs:comment : The number of hours a course lasts.</para>
    ///   <a href="http://w3id.org/roh#courseHours">roh:courseHours</a>
    /// </summary>
    let courseHours = _prefixId.prefix "courseHours"
    /// <summary>
    ///   <para>rdfs:label : cum lauderdfs:label : cum laude</para>
    ///   <para>rdfs:comment : Meaning "with praise", used to indicate the level of distinction with which an academic degree has been earned.</para>
    ///   <a href="http://w3id.org/roh#cumLaude">roh:cumLaude</a>
    /// </summary>
    let cumLaude = _prefixId.prefix "cumLaude"
    /// <summary>
    ///   <para>rdfs:label : currencyrdfs:label : moneda</para>
    ///   <para>rdfs:comment : Data property used by roh:Funding and roh:FundingAmount^^xsd:string</para>
    ///   <a href="http://w3id.org/roh#currency">roh:currency</a>
    /// </summary>
    let currency = _prefixId.prefix "currency"
    /// <summary>
    ///   <para>rdfs:label : dedicaciónrdfs:label : dedication</para>
    ///   <para>rdfs:comment : The dedication which a Person dedicates to a Role.</para>
    ///   <a href="http://w3id.org/roh#dedication">roh:dedication</a>
    /// </summary>
    let dedication = _prefixId.prefix "dedication"
    /// <summary>
    ///   <para>rdfs:label : dedication percentage</para>
    ///   <a href="http://w3id.org/roh#dedicationPercentage">roh:dedicationPercentage</a>
    /// </summary>
    let dedicationPercentage = _prefixId.prefix "dedicationPercentage"
    /// <summary>
    ///   <para>rdfs:label : document statusrdfs:label : estado del documento</para>
    ///   <para>rdfs:comment : The status of a Document (Accepted or Rejected).</para>
    ///   <a href="http://w3id.org/roh#documentStatus">roh:documentStatus</a>
    /// </summary>
    let documentStatus = _prefixId.prefix "documentStatus"
    /// <summary>
    ///   <para>rdfs:label : empleardfs:label : employs</para>
    ///   <a href="http://w3id.org/roh#employs">roh:employs</a>
    /// </summary>
    let employs = _prefixId.prefix "employs"
    /// <summary>
    ///   <para>rdfs:label : estado de la evaluaciónrdfs:label : evaluation status</para>
    ///   <para>rdfs:comment : The status in which a Evaluation Summary could be.</para>
    ///   <a href="http://w3id.org/roh#evaluationStatus">roh:evaluationStatus</a>
    /// </summary>
    let evaluationStatus = _prefixId.prefix "evaluationStatus"
    /// <summary>
    ///   <para>rdfs:label : excellence labelrdfs:label : sello de excelencia</para>
    ///   <para>rdfs:comment : Represents if an Entity has an excellence label or some kind of mention.</para>
    ///   <a href="http://w3id.org/roh#excellenceLabel">roh:excellenceLabel</a>
    /// </summary>
    let excellenceLabel = _prefixId.prefix "excellenceLabel"
    /// <summary>
    ///   <para>rdfs:label : expense modalityrdfs:label : modalidad de gasto</para>
    ///   <para>rdfs:comment : A free text property to represent the modality of an Expense.</para>
    ///   <a href="http://w3id.org/roh#expenseModality">roh:expenseModality</a>
    /// </summary>
    let expenseModality = _prefixId.prefix "expenseModality"
    /// <summary>
    ///   <para>rdfs:label : expiration date</para>
    ///   <a href="http://w3id.org/roh#expirationDate">roh:expirationDate</a>
    /// </summary>
    let expirationDate = _prefixId.prefix "expirationDate"
    /// <summary>
    ///   <para>rdfs:label : fecha de justificación previstardfs:label : foreseen justification date</para>
    ///   <para>rdfs:comment : The date in which a Justificacion has to be delivered.</para>
    ///   <a href="http://w3id.org/roh#foreseenJustificationDate">roh:foreseenJustificationDate</a>
    /// </summary>
    let foreseenJustificationDate = _prefixId.prefix "foreseenJustificationDate"
    /// <summary>
    ///   <para>rdfs:label : fecha de fundaciónrdfs:label : foundation date</para>
    ///   <para>rdfs:comment : Date in which an Organization was created.</para>
    ///   <a href="http://w3id.org/roh#foundationDate">roh:foundationDate</a>
    /// </summary>
    let foundationDate = _prefixId.prefix "foundationDate"
    /// <summary>
    ///   <para>rdfs:label : free or paidrdfs:label : gratuito o de pago</para>
    ///   <a href="http://w3id.org/roh#freeOrPaid">roh:freeOrPaid</a>
    /// </summary>
    let freeOrPaid = _prefixId.prefix "freeOrPaid"
    /// <summary>
    ///   <para>rdfs:label : financiado porrdfs:label : fundedBy</para>
    ///   <para>rdfs:comment : An object property linking a Thing when is funded by another Thing.</para>
    ///   <a href="http://w3id.org/roh#fundedBy">roh:fundedBy</a>
    /// </summary>
    let fundedBy = _prefixId.prefix "fundedBy"
    /// <summary>
    ///   <para>rdfs:label : financiardfs:label : funds</para>
    ///   <para>rdfs:comment : An object property linking a Thing when it funds another Thing.</para>
    ///   <a href="http://w3id.org/roh#funds">roh:funds</a>
    /// </summary>
    let funds = _prefixId.prefix "funds"
    /// <summary>
    ///   <para>rdfs:label : concedido porrdfs:label : granted by</para>
    ///   <para>rdfs:comment : An object property linking an Organization with a FundingAmount.</para>
    ///   <a href="http://w3id.org/roh#grantedBy">roh:grantedBy</a>
    /// </summary>
    let grantedBy = _prefixId.prefix "grantedBy"
    /// <summary>
    ///   <para>rdfs:label : concede ardfs:label : grants</para>
    ///   <para>rdfs:comment : An object property linking a FundingAmount with an Organization.</para>
    ///   <a href="http://w3id.org/roh#grants">roh:grants</a>
    /// </summary>
    let grants = _prefixId.prefix "grants"
    /// <summary>
    ///   <para>rdfs:label : h-index</para>
    ///   <a href="http://w3id.org/roh#h-index">roh:h-index</a>
    /// </summary>
    let h_index = _prefixId.prefix "h-index"
    /// <summary>
    ///   <para>rdfs:label : has accreditationrdfs:label : tiene acreditación</para>
    ///   <para>rdfs:comment : An object property linking an Agent with an Accreditation it posseses.</para>
    ///   <a href="http://w3id.org/roh#hasAccreditation">roh:hasAccreditation</a>
    /// </summary>
    let hasAccreditation = _prefixId.prefix "hasAccreditation"
    /// <summary>
    ///   <para>rdfs:label : has CVrdfs:label : tiene CV</para>
    ///   <para>rdfs:comment : An object property linking a Person with her CV.</para>
    ///   <a href="http://w3id.org/roh#hasCV">roh:hasCV</a>
    /// </summary>
    let hasCV = _prefixId.prefix "hasCV"
    /// <summary>
    ///   <para>rdfs:label : has Code</para>
    ///   <para>rdfs:comment : A concept can be asigned a code.</para>
    ///   <a href="http://w3id.org/roh#hasCode">roh:hasCode</a>
    /// </summary>
    let hasCode = _prefixId.prefix "hasCode"
    /// <summary>
    ///   <para>rdfs:label : has company classification</para>
    ///   <a href="http://w3id.org/roh#hasCompanyClassification">roh:hasCompanyClassification</a>
    /// </summary>
    let hasCompanyClassification = _prefixId.prefix "hasCompanyClassification"
    /// <summary>
    ///   <para>rdfs:label : has contact infordfs:label : tiene información de contacto</para>
    ///   <para>rdfs:comment : An Agent has a contact info of type vcard:Kind.</para>
    ///   <a href="http://w3id.org/roh#hasContactInfo">roh:hasContactInfo</a>
    /// </summary>
    let hasContactInfo = _prefixId.prefix "hasContactInfo"
    /// <summary>
    ///   <para>rdfs:label : has contractrdfs:label : tiene contrato</para>
    ///   <para>rdfs:comment : An object property linking an Entity to a Contract.</para>
    ///   <a href="http://w3id.org/roh#hasContract">roh:hasContract</a>
    /// </summary>
    let hasContract = _prefixId.prefix "hasContract"
    /// <summary>
    ///   <para>rdfs:label : has Expense Classification</para>
    ///   <a href="http://w3id.org/roh#hasExpenseClassification">roh:hasExpenseClassification</a>
    /// </summary>
    let hasExpenseClassification = _prefixId.prefix "hasExpenseClassification"

    /// <summary>
    ///   <para>rdfs:label : has Funding Program Classification^^xsd:string</para>
    ///   <a href="http://w3id.org/roh#hasFundingProgramClassification">roh:hasFundingProgramClassification</a>
    /// </summary>
    let hasFundingProgramClassification = _prefixId.prefix "hasFundingProgramClassification"

    /// <summary>
    ///   <para>rdfs:label : clasificado en RRHH comordfs:label : has HR classification</para>
    ///   <para>rdfs:comment : The position a person has inside its organization.</para>
    ///   <a href="http://w3id.org/roh#hasHRClassification">roh:hasHRClassification</a>
    /// </summary>
    let hasHRClassification = _prefixId.prefix "hasHRClassification"
    /// <summary>
    ///   <para>rdfs:label : has knowledge areardfs:label : tiene area de conocimiento</para>
    ///   <para>rdfs:comment : Some entity related to any Concept.</para>
    ///   <a href="http://w3id.org/roh#hasKnowledgeArea">roh:hasKnowledgeArea</a>
    /// </summary>
    let hasKnowledgeArea = _prefixId.prefix "hasKnowledgeArea"
    /// <summary>
    ///   <para>rdfs:label : has licenserdfs:label : tiene licencia</para>
    ///   <para>rdfs:comment : Esta propiedad nos permite especificar la licencia (vivo:License) de una instancia.rdfs:comment : This object property is used to specify the licence (vivo:License) of a given instance.</para>
    ///   <a href="http://w3id.org/roh#hasLicense">roh:hasLicense</a>
    /// </summary>
    let hasLicense = _prefixId.prefix "hasLicense"
    /// <summary>
    ///   <para>rdfs:label : has metricrdfs:label : tiene métrica</para>
    ///   <para>rdfs:comment : A Metric which quantifies a Research Object.</para>
    ///   <a href="http://w3id.org/roh#hasMetric">roh:hasMetric</a>
    /// </summary>
    let hasMetric = _prefixId.prefix "hasMetric"
    /// <summary>
    ///   <para>rdfs:label : has patent</para>
    ///   <a href="http://w3id.org/roh#hasPatent">roh:hasPatent</a>
    /// </summary>
    let hasPatent = _prefixId.prefix "hasPatent"
    /// <summary>
    ///   <para>rdfs:label : has positionrdfs:label : tiene plaza</para>
    ///   <para>rdfs:comment : A Person has a Position in his/her Organization.</para>
    ///   <a href="http://w3id.org/roh#hasPosition">roh:hasPosition</a>
    /// </summary>
    let hasPosition = _prefixId.prefix "hasPosition"
    /// <summary>
    ///   <para>rdfs:label : has predecessorrdfs:label : tiene predecesor</para>
    ///   <a href="http://w3id.org/roh#hasPredecessor">roh:hasPredecessor</a>
    /// </summary>
    let hasPredecessor = _prefixId.prefix "hasPredecessor"
    /// <summary>
    ///   <para>rdfs:label : has project categorizationrdfs:label : tiene categorizacion proyecto</para>
    ///   <para>rdfs:comment : A Project is categorized by different Project Classifications.</para>
    ///   <a href="http://w3id.org/roh#hasProjectClassification">roh:hasProjectClassification</a>
    /// </summary>
    let hasProjectClassification = _prefixId.prefix "hasProjectClassification"
    /// <summary>
    ///   <para>rdfs:label : has property classification</para>
    ///   <a href="http://w3id.org/roh#hasPropertyClassification">roh:hasPropertyClassification</a>
    /// </summary>
    let hasPropertyClassification = _prefixId.prefix "hasPropertyClassification"
    /// <summary>
    ///   <para>rdfs:label : has readmerdfs:label : tiene readme</para>
    ///   <para>rdfs:comment : This object property is used to specify the README document of a given  Respository or Software.</para>
    ///   <a href="http://w3id.org/roh#hasReadme">roh:hasReadme</a>
    /// </summary>
    let hasReadme = _prefixId.prefix "hasReadme"
    /// <summary>
    ///   <para>rdfs:label : has research contribution</para>
    ///   <a href="http://w3id.org/roh#hasResearchContribution">roh:hasResearchContribution</a>
    /// </summary>
    let hasResearchContribution = _prefixId.prefix "hasResearchContribution"
    /// <summary>
    ///   <para>rdfs:label : has reservablerdfs:label : tiene reservable</para>
    ///   <para>rdfs:comment : An Agent who owns an infrastructure.</para>
    ///   <a href="http://w3id.org/roh#hasReservable">roh:hasReservable</a>
    /// </summary>
    let hasReservable = _prefixId.prefix "hasReservable"
    /// <summary>
    ///   <para>rdfs:label : has rolerdfs:label : tiene rol</para>
    ///   <para>rdfs:comment : An Agent has a Role in a Relation.</para>
    ///   <a href="http://w3id.org/roh#hasRole">roh:hasRole</a>
    /// </summary>
    let hasRole = _prefixId.prefix "hasRole"
    /// <summary>
    ///   <para>rdfs:label : has scientific domain</para>
    ///   <a href="http://w3id.org/roh#hasScientificDomain">roh:hasScientificDomain</a>
    /// </summary>
    let hasScientificDomain = _prefixId.prefix "hasScientificDomain"
    /// <summary>
    ///   <para>rdfs:label : has spinoffrdfs:label : tiene spinoff</para>
    ///   <para>rdfs:comment : An Organization which has a spin off Company.</para>
    ///   <a href="http://w3id.org/roh#hasSpinoff">roh:hasSpinoff</a>
    /// </summary>
    let hasSpinoff = _prefixId.prefix "hasSpinoff"
    /// <summary>
    ///   <para>rdfs:label : has sucessorrdfs:label : tiene sucesor</para>
    ///   <a href="http://w3id.org/roh#hasSucessor">roh:hasSucessor</a>
    /// </summary>
    let hasSucessor = _prefixId.prefix "hasSucessor"
    /// <summary>
    ///   <para>rdfs:label : has TRL</para>
    ///   <para>rdfs:comment : A prototype has a given technology readiness level</para>
    ///   <a href="http://w3id.org/roh#hasTRL">roh:hasTRL</a>
    /// </summary>
    let hasTRL = _prefixId.prefix "hasTRL"
    /// <summary>
    ///   <para>rdfs:label : HR classification ofrdfs:label : clasificación de RRHH de</para>
    ///   <para>rdfs:comment : The classification of the position of a Person.</para>
    ///   <a href="http://w3id.org/roh#hrClassificationOf">roh:hrClassificationOf</a>
    /// </summary>
    let hrClassificationOf = _prefixId.prefix "hrClassificationOf"
    /// <summary>
    ///   <para>rdfs:label : i10-index</para>
    ///   <para>rdfs:comment : A property to express the i10-index of an author.</para>
    ///   <a href="http://w3id.org/roh#i10-index">roh:i10-index</a>
    /// </summary>
    let i10_index = _prefixId.prefix "i10-index"
    /// <summary>
    ///   <para>rdfs:label : factor de impactordfs:label : impact factor</para>
    ///   <para>rdfs:comment : A scientometric index that reflects the yearly average number of citations that articles published in the last two years in a given journal received.</para>
    ///   <a href="http://w3id.org/roh#impactFactor">roh:impactFactor</a>
    /// </summary>
    let impactFactor = _prefixId.prefix "impactFactor"
    let impactFactorName = _prefixId.prefix "impactFactorName"
    /// <summary>
    ///   <para>rdfs:label : is advised by</para>
    ///   <a href="http://w3id.org/roh#isAdvisedBy">roh:isAdvisedBy</a>
    /// </summary>
    let isAdvisedBy = _prefixId.prefix "isAdvisedBy"
    /// <summary>
    ///   <para>rdfs:label : is authored by</para>
    ///   <a href="http://w3id.org/roh#isAuthoredBy">roh:isAuthoredBy</a>
    /// </summary>
    let isAuthoredBy = _prefixId.prefix "isAuthoredBy"
    /// <summary>
    ///   <para>rdfs:label : is awarded by</para>
    ///   <a href="http://w3id.org/roh#isAwardedBy">roh:isAwardedBy</a>
    /// </summary>
    let isAwardedBy = _prefixId.prefix "isAwardedBy"
    /// <summary>
    ///   <para>rdfs:label : is competitive</para>
    ///   <a href="http://w3id.org/roh#isCompetitive">roh:isCompetitive</a>
    /// </summary>
    let isCompetitive = _prefixId.prefix "isCompetitive"
    /// <summary>
    ///   <para>rdfs:label : is granted with</para>
    ///   <para>rdfs:comment : A person is granted with a stipend for researching.</para>
    ///   <a href="http://w3id.org/roh#isGrantedWith">roh:isGrantedWith</a>
    /// </summary>
    let isGrantedWith = _prefixId.prefix "isGrantedWith"
    /// <summary>
    ///   <para>rdfs:label : is provided byrdfs:label : provisto por</para>
    ///   <para>rdfs:comment : A Service provided by an Organization.</para>
    ///   <a href="http://w3id.org/roh#isProvidedBy">roh:isProvidedBy</a>
    /// </summary>
    let isProvidedBy = _prefixId.prefix "isProvidedBy"
    /// <summary>
    ///   <para>rdfs:label : es spinoff derdfs:label : is spinoff ofrdfs:label : spins of from</para>
    ///   <para>rdfs:comment : A Company which is an spinoff of an Organization.</para>
    ///   <a href="http://w3id.org/roh#isSpinfoffOf">roh:isSpinfoffOf</a>
    /// </summary>
    let isSpinfoffOf = _prefixId.prefix "isSpinfoffOf"
    /// <summary>
    ///   <para>rdfs:label : es startuprdfs:label : is startup</para>
    ///   <para>rdfs:comment : To specify that a company is in its early stage of life.</para>
    ///   <a href="http://w3id.org/roh#isStartup">roh:isStartup</a>
    /// </summary>
    let isStartup = _prefixId.prefix "isStartup"
    /// <summary>
    ///   <para>rdfs:label : apoyado porrdfs:label : is supported by</para>
    ///   <para>rdfs:comment : A Project supported by a Funding.</para>
    ///   <a href="http://w3id.org/roh#isSupportedBy">roh:isSupportedBy</a>
    /// </summary>
    let isSupportedBy = _prefixId.prefix "isSupportedBy"
    /// <summary>
    ///   <para>rdfs:label : isbnrdfs:label : isbn</para>
    ///   <para>rdfs:comment : A numeric commercial book identifier which is intended to be unique.</para>
    ///   <a href="http://w3id.org/roh#isbn">roh:isbn</a>
    /// </summary>
    let isbn = _prefixId.prefix "isbn"
    /// <summary>
    ///   <para>rdfs:label : emitido porrdfs:label : issued by</para>
    ///   <para>rdfs:comment : An Accreditation issued by an Accreditation Issuer.</para>
    ///   <a href="http://w3id.org/roh#issuedBy">roh:issuedBy</a>
    /// </summary>
    let issuedBy = _prefixId.prefix "issuedBy"
    /// <summary>
    ///   <para>rdfs:label : emiterdfs:label : issues</para>
    ///   <para>rdfs:comment : An Accreditation Issuer which issues an Accreditation.</para>
    ///   <a href="http://w3id.org/roh#issues">roh:issues</a>
    /// </summary>
    let issues = _prefixId.prefix "issues"
    /// <summary>
    ///   <para>rdfs:label : area de conocimiento derdfs:label : knowledge area of</para>
    ///   <para>rdfs:comment : A skos:Concept which is the knowledge area of some entity.</para>
    ///   <a href="http://w3id.org/roh#knowledgeAreaOf">roh:knowledgeAreaOf</a>
    /// </summary>
    let knowledgeAreaOf = _prefixId.prefix "knowledgeAreaOf"
    /// <summary>
    ///   <para>rdfs:label : languagerdfs:label : lenguaje</para>
    ///   <a href="http://w3id.org/roh#language">roh:language</a>
    /// </summary>
    let language = _prefixId.prefix "language"
    /// <summary>
    ///   <para>rdfs:label : idioma del certificadordfs:label : language of the certificate</para>
    ///   <para>rdfs:comment : The language to which refers the Language Certificate.</para>
    ///   <a href="http://w3id.org/roh#languageOfTheCertificate">roh:languageOfTheCertificate</a>
    /// </summary>
    let languageOfTheCertificate = _prefixId.prefix "languageOfTheCertificate"
    /// <summary>
    ///   <para>rdfs:label : competencia de idiomasrdfs:label : language skill</para>
    ///   <para>rdfs:comment : Different skills required by the Common European Framework of Reference for Languages: Learning, Teaching, Assessment.</para>
    ///   <a href="http://w3id.org/roh#languageSkill">roh:languageSkill</a>
    /// </summary>
    let languageSkill = _prefixId.prefix "languageSkill"
    /// <summary>
    ///   <para>rdfs:label : comprensión auditivardfs:label : listening skill</para>
    ///   <para>rdfs:comment : The ability to understand spoken language.</para>
    ///   <a href="http://w3id.org/roh#listeningSkill">roh:listeningSkill</a>
    /// </summary>
    let listeningSkill = _prefixId.prefix "listeningSkill"
    /// <summary>
    ///   <para>rdfs:label : markrdfs:label : nota</para>
    ///   <para>rdfs:comment : A judgment, expressed as a number or letter, about the quality of a work.</para>
    ///   <a href="http://w3id.org/roh#mark">roh:mark</a>
    /// </summary>
    let mark = _prefixId.prefix "mark"
    /// <summary>
    ///   <para>rdfs:label : metric namerdfs:label : nombre de la métrica</para>
    ///   <para>rdfs:comment : The name of a Metric.</para>
    ///   <a href="http://w3id.org/roh#metricName">roh:metricName</a>
    /// </summary>
    let metricName = _prefixId.prefix "metricName"
    /// <summary>
    ///   <para>rdfs:label : metric ofrdfs:label : métrica de</para>
    ///   <para>rdfs:comment : relates a Metric to the entity it describes</para>
    ///   <a href="http://w3id.org/roh#metricOf">roh:metricOf</a>
    /// </summary>
    let metricOf = _prefixId.prefix "metricOf"
    /// <summary>
    ///   <para>rdfs:label : modalidadrdfs:label : modalidad</para>
    ///   <para>rdfs:comment : A free text property to represent the modality of a Project.</para>
    ///   <a href="http://w3id.org/roh#modality">roh:modality</a>
    /// </summary>
    let modality = _prefixId.prefix "modality"
    /// <summary>
    ///   <para>rdfs:label : cantidad monetariardfs:label : monetary amount</para>
    ///   <para>rdfs:comment : Data property used by roh:Funding and roh:FundingAmount^^xsd:string</para>
    ///   <a href="http://w3id.org/roh#monetaryAmount">roh:monetaryAmount</a>
    /// </summary>
    let monetaryAmount = _prefixId.prefix "monetaryAmount"
    /// <summary>
    ///   <para>rdfs:label : necesita validación éticardfs:label : needs ethical validation</para>
    ///   <para>rdfs:comment : Represents if a Project needs to pass an ethical validation.</para>
    ///   <a href="http://w3id.org/roh#needsEthicalValidation">roh:needsEthicalValidation</a>
    /// </summary>
    let needsEthicalValidation = _prefixId.prefix "needsEthicalValidation"
    /// <summary>
    ///   <para>rdfs:label : organización propietariardfs:label : owner organization</para>
    ///   <para>rdfs:comment : A Patent has an Organization who owns it.</para>
    ///   <a href="http://w3id.org/roh#ownerOrganization">roh:ownerOrganization</a>
    /// </summary>
    let ownerOrganization = _prefixId.prefix "ownerOrganization"
    /// <summary>
    ///   <para>rdfs:label : organización propietaria derdfs:label : owner organization of</para>
    ///   <para>rdfs:comment : An Organization owning a Patent.</para>
    ///   <a href="http://w3id.org/roh#ownerOrganizationOf">roh:ownerOrganizationOf</a>
    /// </summary>
    let ownerOrganizationOf = _prefixId.prefix "ownerOrganizationOf"
    /// <summary>
    ///   <para>rdfs:label : part of repositoryrdfs:label : parte de un repositorio.</para>
    ///   <para>rdfs:comment : A core relation that holds between a part and its hole, that in this case is a Repository.</para>
    ///   <a href="http://w3id.org/roh#partOfRepository">roh:partOfRepository</a>
    /// </summary>
    let partOfRepository = _prefixId.prefix "partOfRepository"
    /// <summary>
    ///   <para>rdfs:label : part of research resultrdfs:label : parte de un resultado de investigación</para>
    ///   <para>rdfs:comment : A core relation that holds between a part and its hole, that in this case is a Research.</para>
    ///   <a href="http://w3id.org/roh#partOfResearchResult">roh:partOfResearchResult</a>
    /// </summary>
    let partOfResearchResult = _prefixId.prefix "partOfResearchResult"
    /// <summary>
    ///   <para>rdfs:label : participanterdfs:label : participated by</para>
    ///   <para>rdfs:comment : An Activity participated by an Entity.</para>
    ///   <a href="http://w3id.org/roh#participatedBy">roh:participatedBy</a>
    /// </summary>
    let participatedBy = _prefixId.prefix "participatedBy"
    /// <summary>
    ///   <para>rdfs:label : participa enrdfs:label : participates</para>
    ///   <para>rdfs:comment : An Entity participating in an Activity.</para>
    ///   <a href="http://w3id.org/roh#participates">roh:participates</a>
    /// </summary>
    let participates = _prefixId.prefix "participates"
    /// <summary>
    ///   <para>rdfs:label : patent assistant examiner</para>
    ///   <a href="http://w3id.org/roh#patentAssistantExaminer">roh:patentAssistantExaminer</a>
    /// </summary>
    let patentAssistantExaminer = _prefixId.prefix "patentAssistantExaminer"
    /// <summary>
    ///   <para>rdfs:label : patent country</para>
    ///   <a href="http://w3id.org/roh#patentCountry">roh:patentCountry</a>
    /// </summary>
    let patentCountry = _prefixId.prefix "patentCountry"
    /// <summary>
    ///   <para>rdfs:label : patent inventor</para>
    ///   <a href="http://w3id.org/roh#patentInventor">roh:patentInventor</a>
    /// </summary>
    let patentInventor = _prefixId.prefix "patentInventor"
    /// <summary>
    ///   <para>rdfs:label : patent primary examiner</para>
    ///   <a href="http://w3id.org/roh#patentPrimaryExaminer">roh:patentPrimaryExaminer</a>
    /// </summary>
    let patentPrimaryExaminer = _prefixId.prefix "patentPrimaryExaminer"
    /// <summary>
    ///   <para>rdfs:label : patent status</para>
    ///   <a href="http://w3id.org/roh#patentStatus">roh:patentStatus</a>
    /// </summary>
    let patentStatus = _prefixId.prefix "patentStatus"
    let platform = _prefixId.prefix "platform"
    /// <summary>
    ///   <para>rdfs:label : plaza derdfs:label : position of</para>
    ///   <para>rdfs:comment : The Position of a Person within an Organization.</para>
    ///   <a href="http://w3id.org/roh#positionOf">roh:positionOf</a>
    /// </summary>
    let positionOf = _prefixId.prefix "positionOf"
    /// <summary>
    ///   <para>rdfs:label : produced byrdfs:label : producido por</para>
    ///   <para>rdfs:comment : Some entity producing some Thing.</para>
    ///   <a href="http://w3id.org/roh#producedBy">roh:producedBy</a>
    /// </summary>
    let producedBy = _prefixId.prefix "producedBy"
    /// <summary>
    ///   <para>rdfs:label : producerdfs:label : produces</para>
    ///   <para>rdfs:comment : Some Thing producing some entity.</para>
    ///   <a href="http://w3id.org/roh#produces">roh:produces</a>
    /// </summary>
    let produces = _prefixId.prefix "produces"
    /// <summary>
    ///   <para>rdfs:label : lenguaje de programaciónrdfs:label : programming language</para>
    ///   <a href="http://w3id.org/roh#programmingLanguage">roh:programmingLanguage</a>
    /// </summary>
    let programmingLanguage = _prefixId.prefix "programmingLanguage"
    /// <summary>
    ///   <para>rdfs:label : project acronym</para>
    ///   <a href="http://w3id.org/roh#projectAcronym">roh:projectAcronym</a>
    /// </summary>
    let projectAcronym = _prefixId.prefix "projectAcronym"
    /// <summary>
    ///   <para>rdfs:label : categorización de proyecto derdfs:label : project categorization of</para>
    ///   <para>rdfs:comment : A Project Classification which categorizes a Project.</para>
    ///   <a href="http://w3id.org/roh#projectClassificationOf">roh:projectClassificationOf</a>
    /// </summary>
    let projectClassificationOf = _prefixId.prefix "projectClassificationOf"
    /// <summary>
    ///   <para>rdfs:label : project ID</para>
    ///   <a href="http://w3id.org/roh#projectID">roh:projectID</a>
    /// </summary>
    let projectID = _prefixId.prefix "projectID"
    /// <summary>
    ///   <para>rdfs:label : objetivo de proyectordfs:label : project objective</para>
    ///   <para>rdfs:comment : A defined objective of the project.</para>
    ///   <a href="http://w3id.org/roh#projectObjective">roh:projectObjective</a>
    /// </summary>
    let projectObjective = _prefixId.prefix "projectObjective"
    /// <summary>
    ///   <para>rdfs:label : estado del proyectordfs:label : project status</para>
    ///   <para>rdfs:comment : A project may be in a CLOSED, OPEN or in other future status that may be defined.^^xsd:string</para>
    ///   <a href="http://w3id.org/roh#projectStatus">roh:projectStatus</a>
    /// </summary>
    let projectStatus = _prefixId.prefix "projectStatus"
    /// <summary>
    ///   <para>rdfs:label : promocionado porrdfs:label : promoted by</para>
    ///   <para>rdfs:comment : A Funding Program or Funding Source promoted by a Funding Organization.</para>
    ///   <a href="http://w3id.org/roh#promotedBy">roh:promotedBy</a>
    /// </summary>
    let promotedBy = _prefixId.prefix "promotedBy"
    /// <summary>
    ///   <para>rdfs:label : promocionardfs:label : promotes</para>
    ///   <para>rdfs:comment : A Funding Organization which promotes a Funding Program or a Funding Source.</para>
    ///   <a href="http://w3id.org/roh#promotes">roh:promotes</a>
    /// </summary>
    let promotes = _prefixId.prefix "promotes"
    /// <summary>
    ///   <para>rdfs:label : proveerdfs:label : provides</para>
    ///   <para>rdfs:comment : An Organization which provides a Service.</para>
    ///   <a href="http://w3id.org/roh#provides">roh:provides</a>
    /// </summary>
    let provides = _prefixId.prefix "provides"
    /// <summary>
    ///   <para>rdfs:label : empresa públicardfs:label : public company</para>
    ///   <para>rdfs:comment : To define if a Company is public or not.</para>
    ///   <a href="http://w3id.org/roh#publicCompany">roh:publicCompany</a>
    /// </summary>
    let publicCompany = _prefixId.prefix "publicCompany"
    /// <summary>
    ///   <para>rdfs:label : financiación públicardfs:label : public funding</para>
    ///   <para>rdfs:comment : To tag something as public (true) or private (false)</para>
    ///   <a href="http://w3id.org/roh#publicFunding">roh:publicFunding</a>
    /// </summary>
    let publicFunding = _prefixId.prefix "publicFunding"
    /// <summary>
    ///   <para>rdfs:label : cuartilrdfs:label : quartile</para>
    ///   <para>rdfs:comment : The quartile to which a Journal publication belongs.</para>
    ///   <a href="http://w3id.org/roh#quartile">roh:quartile</a>
    /// </summary>
    let quartile = _prefixId.prefix "quartile"
    /// <summary>
    ///   <para>rdfs:label : rankingrdfs:label : ranking</para>
    ///   <para>rdfs:comment : The ranking of a scientific publication.</para>
    ///   <a href="http://w3id.org/roh#ranking">roh:ranking</a>
    /// </summary>
    let ranking = _prefixId.prefix "ranking"
    /// <summary>
    ///   <para>rdfs:label : comprensión lectorardfs:label : reading skill</para>
    ///   <para>rdfs:comment : The ability to understand written text.</para>
    ///   <a href="http://w3id.org/roh#readingSkill">roh:readingSkill</a>
    /// </summary>
    let readingSkill = _prefixId.prefix "readingSkill"
    /// <summary>
    ///   <para>rdfs:label : readme derdfs:label : readme of</para>
    ///   <para>rdfs:comment : This object property is used to specify the Repository or Software of a given README document.</para>
    ///   <a href="http://w3id.org/roh#readmeOf">roh:readmeOf</a>
    /// </summary>
    let readmeOf = _prefixId.prefix "readmeOf"
    /// <summary>
    ///   <para>rdfs:label : reference law</para>
    ///   <para>rdfs:comment : A reference law that establishes a position.</para>
    ///   <a href="http://w3id.org/roh#referencedLaw">roh:referencedLaw</a>
    /// </summary>
    let referencedLaw = _prefixId.prefix "referencedLaw"
    /// <summary>
    ///   <para>rdfs:label : repositorio contienerdfs:label : repository has part</para>
    ///   <para>rdfs:comment : A core relation that holds between a whole, that in this case is an Repository, and its part .</para>
    ///   <a href="http://w3id.org/roh#repositoryHasPart">roh:repositoryHasPart</a>
    /// </summary>
    let repositoryHasPart = _prefixId.prefix "repositoryHasPart"
    /// <summary>
    ///   <para>rdfs:label : estado del repositoriordfs:label : repository status</para>
    ///   <para>rdfs:comment : The status of a Repository (Closed or Open).</para>
    ///   <a href="http://w3id.org/roh#repositoryStatus">roh:repositoryStatus</a>
    /// </summary>
    let repositoryStatus = _prefixId.prefix "repositoryStatus"
    /// <summary>
    ///   <para>rdfs:label : required for</para>
    ///   <a href="http://w3id.org/roh#requiredFor">roh:requiredFor</a>
    /// </summary>
    let requiredFor = _prefixId.prefix "requiredFor"
    /// <summary>
    ///   <para>rdfs:label : requires</para>
    ///   <para>rdfs:comment : This property relates roles and their requisites, i.e. other roles.</para>
    ///   <a href="http://w3id.org/roh#requires">roh:requires</a>
    /// </summary>
    let requires = _prefixId.prefix "requires"
    /// <summary>
    ///   <para>rdfs:label : línea de investigaciónrdfs:label : research line</para>
    ///   <para>rdfs:comment : A free-text property to define the research line in which an Organization or Researcher is working on.</para>
    ///   <a href="http://w3id.org/roh#researchLine">roh:researchLine</a>
    /// </summary>
    let researchLine = _prefixId.prefix "researchLine"
    /// <summary>
    ///   <para>rdfs:label : research result has partrdfs:label : resultado de investigación contiene</para>
    ///   <para>rdfs:comment : A core relation that holds between a whole, that in this case is an Research Object (roh:ResearchObject), and its part .</para>
    ///   <a href="http://w3id.org/roh#researchResultHasPart">roh:researchResultHasPart</a>
    /// </summary>
    let researchResultHasPart = _prefixId.prefix "researchResultHasPart"
    /// <summary>
    ///   <para>rdfs:label : reservable derdfs:label : reservable of</para>
    ///   <para>rdfs:comment : An Infrastructure belonging to an Agent.</para>
    ///   <a href="http://w3id.org/roh#reservableOf">roh:reservableOf</a>
    /// </summary>
    let reservableOf = _prefixId.prefix "reservableOf"
    /// <summary>
    ///   <para>rdfs:label : reviews</para>
    ///   <para>rdfs:comment : a proerty to link a person to a publication as a reviewer.</para>
    ///   <a href="http://w3id.org/roh#reviews">roh:reviews</a>
    /// </summary>
    let reviews = _prefixId.prefix "reviews"
    /// <summary>
    ///   <para>rdfs:label : rol derdfs:label : role of</para>
    ///   <para>rdfs:comment : The Role held by an Agent in a Relationship.</para>
    ///   <a href="http://w3id.org/roh#roleOf">roh:roleOf</a>
    /// </summary>
    let roleOf = _prefixId.prefix "roleOf"
    /// <summary>
    ///   <para>rdfs:label : conjunto de autoresrdfs:label : seq of authors</para>
    ///   <para>rdfs:comment : An unordered list of authors.rdfs:comment : Una lista no ordenada de los autores.</para>
    ///   <a href="http://w3id.org/roh#seqOfAuthors">roh:seqOfAuthors</a>
    /// </summary>
    let seqOfAuthors = _prefixId.prefix "seqOfAuthors"
    /// <summary>
    ///   <para>rdfs:label : estatus de softwarerdfs:label : software status</para>
    ///   <para>rdfs:comment : The status of a Software  (Final or Provisional).</para>
    ///   <a href="http://w3id.org/roh#softwareStatus">roh:softwareStatus</a>
    /// </summary>
    let softwareStatus = _prefixId.prefix "softwareStatus"
    /// <summary>
    ///   <para>rdfs:label : expresión oralrdfs:label : speaking skill</para>
    ///   <para>rdfs:comment : The ability to speak a language.</para>
    ///   <a href="http://w3id.org/roh#speakingSkill">roh:speakingSkill</a>
    /// </summary>
    let speakingSkill = _prefixId.prefix "speakingSkill"
    /// <summary>
    ///   <para>rdfs:label : gastardfs:label : spends</para>
    ///   <para>rdfs:comment : An entity spending an Expense.</para>
    ///   <a href="http://w3id.org/roh#spends">roh:spends</a>
    /// </summary>
    let spends = _prefixId.prefix "spends"
    /// <summary>
    ///   <para>rdfs:label : gasto realizado porrdfs:label : spent by</para>
    ///   <para>rdfs:comment : An Expense spent by an Entity.</para>
    ///   <a href="http://w3id.org/roh#spentBy">roh:spentBy</a>
    /// </summary>
    let spentBy = _prefixId.prefix "spentBy"
    /// <summary>
    ///   <para>rdfs:label : interacción oralrdfs:label : spoken interaction skill</para>
    ///   <para>rdfs:comment : The ability to participate into a conversation.</para>
    ///   <a href="http://w3id.org/roh#spokenInteractionSkill">roh:spokenInteractionSkill</a>
    /// </summary>
    let spokenInteractionSkill = _prefixId.prefix "spokenInteractionSkill"
    /// <summary>
    ///   <para>rdfs:label : resumenrdfs:label : summary</para>
    ///   <para>rdfs:comment : A textual summary of the Curriculum Vitae</para>
    ///   <a href="http://w3id.org/roh#summary">roh:summary</a>
    /// </summary>
    let summary = _prefixId.prefix "summary"
    /// <summary>
    ///   <para>rdfs:label : supervisado porrdfs:label : supervised by</para>
    ///   <para>rdfs:comment : A Thesis supervised by a Person.</para>
    ///   <a href="http://w3id.org/roh#supervisedBy">roh:supervisedBy</a>
    /// </summary>
    let supervisedBy = _prefixId.prefix "supervisedBy"
    /// <summary>
    ///   <para>rdfs:label : supervisor derdfs:label : supervisor of</para>
    ///   <para>rdfs:comment : A Person supervising a Thesis.</para>
    ///   <a href="http://w3id.org/roh#supervisorOf">roh:supervisorOf</a>
    /// </summary>
    let supervisorOf = _prefixId.prefix "supervisorOf"
    /// <summary>
    ///   <para>rdfs:label : apoyardfs:label : supports</para>
    ///   <para>rdfs:comment : A Funding which supports a Person Contract or a Project.</para>
    ///   <a href="http://w3id.org/roh#supports">roh:supports</a>
    /// </summary>
    let supports = _prefixId.prefix "supports"
    /// <summary>
    ///   <para>rdfs:label : taught by</para>
    ///   <a href="http://w3id.org/roh#taughtBy">roh:taughtBy</a>
    /// </summary>
    let taughtBy = _prefixId.prefix "taughtBy"
    /// <summary>
    ///   <para>rdfs:label : tax ID</para>
    ///   <a href="http://w3id.org/roh#taxID">roh:taxID</a>
    /// </summary>
    let taxID = _prefixId.prefix "taxID"
    /// <summary>
    ///   <para>rdfs:label : teaches</para>
    ///   <a href="http://w3id.org/roh#teaches">roh:teaches</a>
    /// </summary>
    let teaches = _prefixId.prefix "teaches"
    /// <summary>
    ///   <para>rdfs:label : titlerdfs:label : título</para>
    ///   <para>rdfs:comment : A data property that associates a title to any ROH entity requiring it.^^xsd:string</para>
    ///   <a href="http://w3id.org/roh#title">roh:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>rdfs:label : Universal Product Coderdfs:label : has UPC</para>
    ///   <a href="http://w3id.org/roh#upc">roh:upc</a>
    /// </summary>
    let upc = _prefixId.prefix "upc"
    /// <summary>
    ///   <para>rdfs:label : urlrdfs:label : url</para>
    ///   <para>rdfs:comment : A Uniform Resource Identifier.</para>
    ///   <a href="http://w3id.org/roh#url">roh:url</a>
    /// </summary>
    let url = _prefixId.prefix "url"
    /// <summary>
    ///   <para>rdfs:label : utilizes</para>
    ///   <a href="http://w3id.org/roh#utilizes">roh:utilizes</a>
    /// </summary>
    let utilizes = _prefixId.prefix "utilizes"
    /// <summary>
    ///   <para>rdfs:label : expresión escritardfs:label : writing skill</para>
    ///   <para>rdfs:comment : The ability to write into a certain language.</para>
    ///   <a href="http://w3id.org/roh#writingSkill">roh:writingSkill</a>
    /// </summary>
    let writingSkill = _prefixId.prefix "writingSkill"
