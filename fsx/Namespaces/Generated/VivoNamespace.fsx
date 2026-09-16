#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module vivo =
    let _prefixId = PrefixId.fromNamespaceLabel "http://vivoweb.org/ontology/core#" "vivo"

    /// <summary>
    ///   <para>obo:IAO_0000115 : An abstract that is published as a standalone document or in a journal of abstracts^^xsd:string</para>
    ///   <para>rdfs:label : Abstract^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Abstract">vivo:Abstract</a>
    /// </summary>
    let Abstract = _prefixId.prefix "Abstract"
    /// <summary>
    ///   <para>obo:IAO_0000112 : B.A. Bachelor of Arts^^xsd:stringobo:IAO_0000112 : This list may have multiple abbreviations for some degrees.^^xsd:string</para>
    ///   <para>obo:IAO_0000115 : An academic degree at any level, both as reported by individuals for employment and as offered by academic degree programs.^^xsd:string</para>
    ///   <para>rdfs:label : Academic Degree^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#AcademicDegree">vivo:AcademicDegree</a>
    /// </summary>
    let AcademicDegree = _prefixId.prefix "AcademicDegree"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A distinct, usually specialized educational unit within an educational organization.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Endodontics (department within a College of Dentistry); English (department within a College of Liberal Arts)^^xsd:string</para>
    ///   <para>rdfs:label : Academic Department^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#AcademicDepartment">vivo:AcademicDepartment</a>
    /// </summary>
    let AcademicDepartment = _prefixId.prefix "AcademicDepartment"
    /// <summary>
    ///   <para>obo:IAO_0000115 : An explicit individual academic term, quarter, or semester rather than the generic fall, spring or summer semester.^^xsd:string</para>
    ///   <para>rdfs:label : Academic Term^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#AcademicTerm">vivo:AcademicTerm</a>
    /// </summary>
    let AcademicTerm = _prefixId.prefix "AcademicTerm"
    /// <summary>
    ///   <para>obo:IAO_0000115 : An explicit individual period considered by an academic institution to be its primary academic cycle.^^xsd:string</para>
    ///   <para>rdfs:label : Academic Year^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#AcademicYear">vivo:AcademicYear</a>
    /// </summary>
    let AcademicYear = _prefixId.prefix "AcademicYear"
    /// <summary>
    ///   <para>rdfs:label : Administrator Role^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#AdministratorRole">vivo:AdministratorRole</a>
    /// </summary>
    let AdministratorRole = _prefixId.prefix "AdministratorRole"
    /// <summary>
    ///   <para>rdfs:label : Advisee Role^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#AdviseeRole">vivo:AdviseeRole</a>
    /// </summary>
    let AdviseeRole = _prefixId.prefix "AdviseeRole"
    /// <summary>
    ///   <para>rdfs:label : Advising Process^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#AdvisingProcess">vivo:AdvisingProcess</a>
    /// </summary>
    let AdvisingProcess = _prefixId.prefix "AdvisingProcess"
    /// <summary>
    ///   <para>rdfs:label : Advising Relationship^^xsd:string</para>
    ///   <para>obo:IAO_0000115 : A dual relationship of one person being advised or mentored by another person, typically including start and end dates^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#AdvisingRelationship">vivo:AdvisingRelationship</a>
    /// </summary>
    let AdvisingRelationship = _prefixId.prefix "AdvisingRelationship"
    /// <summary>
    ///   <para>rdfs:label : Advisor Role^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#AdvisorRole">vivo:AdvisorRole</a>
    /// </summary>
    let AdvisorRole = _prefixId.prefix "AdvisorRole"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A group of persons or organizations organized for a common purpose.^^xsd:stringobo:IAO_0000115 : A formal organization of people or groups of people around a subject or practice.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Special Libraries Association; Association for Computing Machinery(ACM); American Medical Informatics Association(AMIA)^^xsd:string</para>
    ///   <para>rdfs:label : Association^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Association">vivo:Association</a>
    /// </summary>
    let Association = _prefixId.prefix "Association"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A role of attending an Event or EventSeries^^xsd:string</para>
    ///   <para>rdfs:label : Attendee Role^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#AttendeeRole">vivo:AttendeeRole</a>
    /// </summary>
    let AttendeeRole = _prefixId.prefix "AttendeeRole"
    /// <summary>
    ///   <para>rdfs:label : Attending Process^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#AttendingProcess">vivo:AttendingProcess</a>
    /// </summary>
    let AttendingProcess = _prefixId.prefix "AttendingProcess"
    /// <summary>
    ///   <para>obo:IAO_0000112 : Currently any abstract name is given to members of this class. This could change in the future.^^xsd:stringobo:IAO_0000112 : Authorship of journal articles, books and other original works is a means by which academics communicate the results of their scholarly work, establish priority for their discoveries, and build their reputation among their peers.
    /// This class allows for linking an author to a publication while indicating information about that author's authorship.^^xsd:string</para>
    ///   <para>rdfs:label : Authorship^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>obo:IAO_0000115 : Contains the authors name, their rank in the publication, and whether or not they are a corresponding author on the publication.^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Authorship">vivo:Authorship</a>
    /// </summary>
    let Authorship = _prefixId.prefix "Authorship"
    /// <summary>
    ///   <para>obo:IAO_0000115 : An Award or Honor^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : An Award or Honor^^xsd:stringobo:IAO_0000112 : Wiley Prize in Biomedical Sciences^^xsd:string</para>
    ///   <para>rdfs:label : Award or Honor^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Award">vivo:Award</a>
    /// </summary>
    let Award = _prefixId.prefix "Award"
    /// <summary>
    ///   <para>rdfs:label : Award or Honor Receipt^^xsd:string</para>
    ///   <para>obo:IAO_0000115 : The bestowal of an award, honor, or distinction to a person or person's at a particular time.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : The award bestowed may be represented with the Award class.^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#AwardReceipt">vivo:AwardReceipt</a>
    /// </summary>
    let AwardReceipt = _prefixId.prefix "AwardReceipt"
    /// <summary>
    ///   <para>obo:IAO_0000115 : The awarding of a degree by an agent to another agent. It is mostly for academic degrees.^^xsd:string</para>
    ///   <para>rdfs:label : Awarded Degree^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#AwardedDegree">vivo:AwardedDegree</a>
    /// </summary>
    let AwardedDegree = _prefixId.prefix "AwardedDegree"
    /// <summary>
    ///   <para>obo:IAO_0000115 : Regularly updated online journal or newsletter by one or more writers, called bloggers, containing articles and commentary of interest to the blogger^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Blog is short for weblog.^^xsd:stringobo:IAO_0000112 : Library of Congress Blog^^xsd:string</para>
    ///   <para>rdfs:label : Blog^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Blog">vivo:Blog</a>
    /// </summary>
    let Blog = _prefixId.prefix "Blog"
    /// <summary>
    ///   <para>obo:IAO_0000115 : An online article or commentary appearing on a blog^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : A specific blog posting^^xsd:string</para>
    ///   <para>rdfs:label : Blog Posting^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#BlogPosting">vivo:BlogPosting</a>
    /// </summary>
    let BlogPosting = _prefixId.prefix "BlogPosting"
    /// <summary>
    ///   <para>obo:IAO_0000115 : Building that provides a particular service or is used for a particular activity.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Martha Van Rensselaer Hall (VR); Caldwell Hall (CD); University Auditorium^^xsd:stringobo:IAO_0000112 : Enter building name. If the building's name is a number (as in many governmental organizations such as national laboratories and military bases), then enter it. Do not confuse with the number that appears in a postal address.^^xsd:string</para>
    ///   <para>rdfs:label : Building^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Building">vivo:Building</a>
    /// </summary>
    let Building = _prefixId.prefix "Building"
    /// <summary>
    ///   <para>obo:IAO_0000115 : The grounds of a school, college, university, or hospital. Or, a large, usually suburban, landscaped business or industrial site.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Definition taken from dictionary.com (http://dictionary.reference.com/browse/campus).^^xsd:stringobo:IAO_0000112 : Cornell Ithaca; Cornell Geneva; Cornell New York City; Cornell Qatar^^xsd:string</para>
    ///   <para>rdfs:label : Campus^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Campus">vivo:Campus</a>
    /// </summary>
    let Campus = _prefixId.prefix "Campus"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A qualitative descriptive research study of individuals or a group^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : A form of qualitative descriptive research that is used to study individuals, a small group of participants, or a group as a whole. Medical usage (from MeSH): clinical presentations that may be followed by evaluative studies that eventually lead to a diagnosis.^^xsd:string</para>
    ///   <para>rdfs:label : Case Study^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#CaseStudy">vivo:CaseStudy</a>
    /// </summary>
    let CaseStudy = _prefixId.prefix "CaseStudy"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A list of items in a collection; an ordered compilation of item descriptions and sufficient information to afford access to them^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Short Definition is the Medical Subject Heading (MeSH) definition^^xsd:stringobo:IAO_0000112 : NLM Catalog^^xsd:string</para>
    ///   <para>rdfs:label : Catalog^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Catalog">vivo:Catalog</a>
    /// </summary>
    let Catalog = _prefixId.prefix "Catalog"
    /// <summary>
    ///   <para>obo:IAO_0000115 : An organization where a specified activity is concentrated.^^xsd:stringobo:IAO_0000115 : A place where a particular activity or service is concentrated.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Short Definition take from http://www.thefreedictionary.com/center.^^xsd:stringobo:IAO_0000112 : Alchohol Education Center; Center for Arts and Public Policy; Hearing Research Center^^xsd:string</para>
    ///   <para>rdfs:label : Center^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Center">vivo:Center</a>
    /// </summary>
    let Center = _prefixId.prefix "Center"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A document confirming certain characteristics of a person or organization, usually provided by some form of external review, education, or assessment.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : A document confirming certain characteristics of a person or organization, usually provided by some form of external review, education, or assessment.^^xsd:string</para>
    ///   <para>rdfs:label : Certificate^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Certificate">vivo:Certificate</a>
    /// </summary>
    let Certificate = _prefixId.prefix "Certificate"
    /// <summary>
    ///   <para>obo:IAO_0000115 : An issued certificate^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : see also core:Certificate^^xsd:string</para>
    ///   <para>rdfs:label : Certification^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Certification">vivo:Certification</a>
    /// </summary>
    let Certification = _prefixId.prefix "Certification"
    /// <summary>
    ///   <para>obo:IAO_0000115 : Any organization with a significant clinical function as a matter of course and not just through occasional clinical roles^^xsd:stringobo:IAO_0000115 : Any organization that offers significant health services or routinely provides medical care to patients.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : In the future we may be able to make this a defined class that would not need to be directly asserted, but the consensus seems to be that some organizations "are" clinical and some "are" research organizations and that the distinction is important enough to warrant the additional class and class assertions^^xsd:string</para>
    ///   <para>rdfs:label : Clinical Organization^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#ClinicalOrganization">vivo:ClinicalOrganization</a>
    /// </summary>
    let ClinicalOrganization = _prefixId.prefix "ClinicalOrganization"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A role of observing or treating patients^^xsd:string</para>
    ///   <para>rdfs:label : Clinical Role^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#ClinicalRole">vivo:ClinicalRole</a>
    /// </summary>
    let ClinicalRole = _prefixId.prefix "ClinicalRole"
    /// <summary>
    ///   <para>obo:IAO_0000115 : Role of co-principal investigator of an Agreement (for example, a grant), who devotes a specified percentage of time and is considered key personnel.^^xsd:string</para>
    ///   <para>rdfs:label : Co-Principal Investigator Role^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#CoPrincipalInvestigatorRole">vivo:CoPrincipalInvestigatorRole</a>
    /// </summary>
    let CoPrincipalInvestigatorRole = _prefixId.prefix "CoPrincipalInvestigatorRole"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A primary academic unit within a University or a free-standing higher education organization without graduate degree programs^^xsd:stringobo:IAO_0000115 : A primary academic unit within a University or a free-standing higher education organization without graduate degree programs.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : College of Arts &amp; Sciences; Ivy Tech Community College^^xsd:string</para>
    ///   <para>rdfs:label : College^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#College">vivo:College</a>
    /// </summary>
    let College = _prefixId.prefix "College"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A group of people organized for a specific purpose, whose members are often selected from a larger group to serve for designated periods of time.^^xsd:stringobo:IAO_0000115 : A group of people organized for a specific purpose (e.g., a reporting or advisory role), often with a charge and for a specific duration^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : There could be many subclasses such as thesis committee or tenure committee, but these may typically be differentiated via the moniker unless distinct properties become important.^^xsd:stringobo:IAO_0000112 : Curriculum Steering Committee; PhD Advisory Committee^^xsd:string</para>
    ///   <para>rdfs:label : Committee^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Committee">vivo:Committee</a>
    /// </summary>
    let Committee = _prefixId.prefix "Committee"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A legally-recognized business organization.^^xsd:stringobo:IAO_0000115 : A legally-recognized business organization^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : from Wikipedia: "A company is a form of business organization. It is an association or collection of individual real persons and/or other companies ... This collection, group or association of persons can be made to exist in law and then a company is itself considered a "legal person". The name company arose because, at least originally, it represented or was owned by more than one real or legal person."^^xsd:string</para>
    ///   <para>rdfs:label : Company^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Company">vivo:Company</a>
    /// </summary>
    let Company = _prefixId.prefix "Company"
    /// <summary>
    ///   <para>obo:IAO_0000115 : An occasion on which a winner is selected from among two or more contestants.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Intel Talent Search; poetry contest^^xsd:stringobo:IAO_0000112 : Not the same as an award or distinction.^^xsd:string</para>
    ///   <para>rdfs:label : Competition^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Competition">vivo:Competition</a>
    /// </summary>
    let Competition = _prefixId.prefix "Competition"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A paper presented at a conference; optionally collected into a Proceedings or a special Journal issue^^xsd:string</para>
    ///   <para>rdfs:label : Conference Paper^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#ConferencePaper">vivo:ConferencePaper</a>
    /// </summary>
    let ConferencePaper = _prefixId.prefix "ConferencePaper"
    /// <summary>
    ///   <para>obo:IAO_0000115 : The digital file (or physical equivalent), if available after the conference, vs. the act of attending/presenting: use ConferencePresentation for information about date/time/location/name of the event where the poster was presented^^xsd:string</para>
    ///   <para>rdfs:label : Conference Poster^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#ConferencePoster">vivo:ConferencePoster</a>
    /// </summary>
    let ConferencePoster = _prefixId.prefix "ConferencePoster"
    /// <summary>
    ///   <para>obo:IAO_0000115 : An organized series of a meeting for consultation or discussion.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : For individual, separate conferences, use conference instead.  core:ConferenceSeries and core:SeminarSeries are very similar.^^xsd:string</para>
    ///   <para>rdfs:label : Conference Series^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#ConferenceSeries">vivo:ConferenceSeries</a>
    /// </summary>
    let ConferenceSeries = _prefixId.prefix "ConferenceSeries"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A group  of independent organizations working together toward a common goal, under an expressed agreement.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Committee on Institutional Cooperation (CIC); The Five Colleges of Ohio^^xsd:string</para>
    ///   <para>rdfs:label : Consortium^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Consortium">vivo:Consortium</a>
    /// </summary>
    let Consortium = _prefixId.prefix "Consortium"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A large contiguous landmass  that is at least partially surrounded by water, together with any islands on its continental shelf.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : The seven commonly recognized continents are Africa; Antarctica; Asia; Australia; Europe; North America; South America^^xsd:stringobo:IAO_0000112 : Short Definition take from http://en.wiktionary.org/wiki/continent.^^xsd:string</para>
    ///   <para>rdfs:label : Continent^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Continent">vivo:Continent</a>
    /// </summary>
    let Continent = _prefixId.prefix "Continent"
    /// <summary>
    ///   <para>obo:IAO_0000115 : An agreement involving specific deliverables and payment^^xsd:string</para>
    ///   <para>rdfs:label : Contract^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Contract">vivo:Contract</a>
    /// </summary>
    let Contract = _prefixId.prefix "Contract"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A lab providing services such as training, protocols, or access to instruments or software^^xsd:string</para>
    ///   <para>rdfs:label : Core Laboratory^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#CoreLaboratory">vivo:CoreLaboratory</a>
    /// </summary>
    let CoreLaboratory = _prefixId.prefix "CoreLaboratory"
    /// <summary>
    ///   <para>obo:IAO_0000115 : An area of land distinguished by its political autonomy. Politically independent territories.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Source of the Short Definition: http://www.thefreedictionary.com/country.  This is also the same as geopolitical.owl:self_governing.^^xsd:stringobo:IAO_0000112 : Afghanistan; Antigua and Barbuda; Cameroon; Iceland; Jamaica; Nigeria; United States of America^^xsd:string</para>
    ///   <para>rdfs:label : Country^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Country">vivo:Country</a>
    /// </summary>
    let Country = _prefixId.prefix "Country"
    /// <summary>
    ///   <para>obo:IAO_0000115 : The largest administrative division of most states or provinces.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Alachua; Baker; Bradford; Kenora; Ottawa; Waterloo^^xsd:stringobo:IAO_0000112 : Short Definition modified from the one found here: http://www.thefreedictionary.com/county.^^xsd:string</para>
    ///   <para>rdfs:label : County^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#County">vivo:County</a>
    /// </summary>
    let County = _prefixId.prefix "County"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A course as taught in one time period by one or more instructors, normally but not always for credit. Does not represent either each meeting of the course or the course offering such as Biology 101 taught every semester from 1980 to 2010^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : A course as taught in one time period (such as a semester; although note that a course could consist of only one meeting (teaching session)) by one or more instructors, normally but not always for credit. Does not represent either each meeting of the course or the course offering such as Biology 101 taught every semester from 1980 to 2010^^xsd:string</para>
    ///   <para>rdfs:label : Course^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Course">vivo:Course</a>
    /// </summary>
    let Course = _prefixId.prefix "Course"
    /// <summary>
    ///   <para>obo:IAO_0000112 : An attestation of qualification, competence, or authority issued to an individual by a third party with a relevant or  de facto authority or assumed competence to do so.^^xsd:string</para>
    ///   <para>obo:IAO_0000115 : An attestation of qualification, competence, or authority issued to an individual by a third party with a relevant or  de facto authority or assumed competence to do so.^^xsd:string</para>
    ///   <para>rdfs:label : Credential^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Credential">vivo:Credential</a>
    /// </summary>
    let Credential = _prefixId.prefix "Credential"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A structured file of information or a set of logically related data stored and retrieved using computer-based means^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Short Definition is the Medical Subject Heading (MeSH) definition^^xsd:stringobo:IAO_0000112 : PubMed^^xsd:string</para>
    ///   <para>rdfs:label : Database^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Database">vivo:Database</a>
    /// </summary>
    let Database = _prefixId.prefix "Database"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A named collection of data, usually containing only one type of data^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : US Patent Data; US Job Data^^xsd:string</para>
    ///   <para>rdfs:label : Dataset^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Dataset">vivo:Dataset</a>
    /// </summary>
    let Dataset = _prefixId.prefix "Dataset"
    /// <summary>
    ///   <para>obo:IAO_0000115 : a specific period or duration, defined by (optional) start and end date/times.^^xsd:string</para>
    ///   <para>rdfs:label : Date/Time Interval^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#DateTimeInterval">vivo:DateTimeInterval</a>
    /// </summary>
    let DateTimeInterval = _prefixId.prefix "DateTimeInterval"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A date and/or time^^xsd:string</para>
    ///   <para>rdfs:label : Date/Time Value^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#DateTimeValue">vivo:DateTimeValue</a>
    /// </summary>
    let DateTimeValue = _prefixId.prefix "DateTimeValue"
    /// <summary>
    ///   <para>obo:IAO_0000115 : Indicates the precision of the value of a DateTimeValue instance.^^xsd:string</para>
    ///   <para>rdfs:label : Date/Time Value Precision^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#DateTimeValuePrecision">vivo:DateTimeValuePrecision</a>
    /// </summary>
    let DateTimeValuePrecision = _prefixId.prefix "DateTimeValuePrecision"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A unit within a larger organization that addresses a specific subject or area of activity.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Legal (department within a company); Use for any non-academic department^^xsd:stringobo:IAO_0000112 : Definition modified from the definition here: http://dictionary.reference.com/browse/department. It is difficult to tell the difference between and department and a division.^^xsd:string</para>
    ///   <para>rdfs:label : Department^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Department">vivo:Department</a>
    /// </summary>
    let Department = _prefixId.prefix "Department"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A major unit or section within a larger organization.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Definition modified from http://www.thefreedictionary.com/division.  It is difficult to tell the difference between a division and a department.^^xsd:stringobo:IAO_0000112 : Cardiovascular Medicine (division within medicine)^^xsd:string</para>
    ///   <para>rdfs:label : Division^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Division">vivo:Division</a>
    /// </summary>
    let Division = _prefixId.prefix "Division"
    /// <summary>
    ///   <para>obo:IAO_0000115 : An ongoing editorial responsibility for a bibo:Collection, such as a Journal or Series^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : An ongoing editorial responsibility for a bibo:Collection, such as a Journal or Series^^xsd:string</para>
    ///   <para>rdfs:label : Editor Role^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#EditorRole">vivo:EditorRole</a>
    /// </summary>
    let EditorRole = _prefixId.prefix "EditorRole"
    /// <summary>
    ///   <para>obo:IAO_0000115 : An article of opinion, typically published in a newspaper. For academics, most commonly Op Ed pieces^^xsd:string</para>
    ///   <para>rdfs:label : Editorial Article^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#EditorialArticle">vivo:EditorialArticle</a>
    /// </summary>
    let EditorialArticle = _prefixId.prefix "EditorialArticle"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A relationship that represents the recognition of an agent as an editor.^^xsd:string</para>
    ///   <para>rdfs:label : Editorship^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Editorship">vivo:Editorship</a>
    /// </summary>
    let Editorship = _prefixId.prefix "Editorship"
    /// <summary>
    ///   <para>obo:IAO_0000112 : Currently any abstract name is given to individuals of this class. This could change in the future.^^xsd:string</para>
    ///   <para>rdfs:label : Educational Process^^xsd:string</para>
    ///   <para>obo:IAO_0000115 : Represents educational training that has been received.^^xsd:string</para>
    ///   <para>http://vitro.mannlib.cornell.edu/ns/vitro/0.7#descriptionAnnot : This connects person to their academic degree through this educational training, but can also be used when the training does not result in a degree.^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#EducationalProcess">vivo:EducationalProcess</a>
    /// </summary>
    let EducationalProcess = _prefixId.prefix "EducationalProcess"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A retired faculty member who has retained their rank, title and privileges.^^xsd:string</para>
    ///   <para>rdfs:label : Faculty Member Emeritus^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#EmeritusFaculty">vivo:EmeritusFaculty</a>
    /// </summary>
    let EmeritusFaculty = _prefixId.prefix "EmeritusFaculty"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A retired librarian who has retained their rank, title and privileges.^^xsd:string</para>
    ///   <para>rdfs:label : Librarian Emeritus^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#EmeritusLibrarian">vivo:EmeritusLibrarian</a>
    /// </summary>
    let EmeritusLibrarian = _prefixId.prefix "EmeritusLibrarian"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A retired professor who has retained their rank, title and privileges.^^xsd:string</para>
    ///   <para>rdfs:label : Professor Emeritus^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#EmeritusProfessor">vivo:EmeritusProfessor</a>
    /// </summary>
    let EmeritusProfessor = _prefixId.prefix "EmeritusProfessor"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A physical object provided for specific purpose, task or occupation.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : A network server is one example. Medical schools and research laboratories can list professional equipment, such as microscopes.^^xsd:stringobo:IAO_0000112 : server; Bruker Vector-33 FT-IR^^xsd:string</para>
    ///   <para>rdfs:label : Equipment^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Equipment">vivo:Equipment</a>
    /// </summary>
    let Equipment = _prefixId.prefix "Equipment"
    /// <summary>
    ///   <para>obo:IAO_0000112 : A generic class which may include a conference series, a course section, a seminar series, or a workshop series. When possible, use one of these more specific classes.^^xsd:stringobo:IAO_0000112 : Only use if no specific subclasses of core:EventSeries desribe the activity.^^xsd:string</para>
    ///   <para>rdfs:label : Event Series^^xsd:string</para>
    ///   <para>obo:IAO_0000115 : Two or more events that occur at different times and are connected to each other.^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#EventSeries">vivo:EventSeries</a>
    /// </summary>
    let EventSeries = _prefixId.prefix "EventSeries"
    /// <summary>
    ///   <para>obo:IAO_0000115 : The showing of an object or a collection of objects, in an organized manner.^^xsd:string</para>
    ///   <para>rdfs:label : Exhibit^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Exhibit">vivo:Exhibit</a>
    /// </summary>
    let Exhibit = _prefixId.prefix "Exhibit"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A unit devoted primarily to extension activities, whether for outreach or research.^^xsd:stringobo:IAO_0000115 : A unit devoted primarily to extension activities, whether for outreach or research^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Alachua County Extension Office^^xsd:string</para>
    ///   <para>rdfs:label : Extension Unit^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#ExtensionUnit">vivo:ExtensionUnit</a>
    /// </summary>
    let ExtensionUnit = _prefixId.prefix "ExtensionUnit"
    /// <summary>
    ///   <para>obo:IAO_0000112 : F1000 is a place where faculty go to critique papers published in PubMed. Any given record in F1000 might have anywhere from one to dozens of reviews.^^xsd:string</para>
    ///   <para>rdfs:label : F1000 Link^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#F1000Link">vivo:F1000Link</a>
    /// </summary>
    let F1000Link = _prefixId.prefix "F1000Link"
    /// <summary>
    ///   <para>obo:IAO_0000112 : Distinct from the organization that runs it; e.g., a laboratory may be an organization but may be run by another organization and only consist of facilities housing equipment or services. Can be a building or place that provides a particular service or is used for a particular activity. Use the specific Building or Room whenever possible. Short definition from http://dictionary.reference.com/browse/facility.^^xsd:stringobo:IAO_0000112 : Use subclasses of core:Facility subclasses instead of this class if possible^^xsd:string</para>
    ///   <para>obo:IAO_0000115 : Something designed, built, installed, etc., to serve a specific function or activity affording a convenience or service.^^xsd:string</para>
    ///   <para>rdfs:label : Facility^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Facility">vivo:Facility</a>
    /// </summary>
    let Facility = _prefixId.prefix "Facility"
    /// <summary>
    ///   <para>obo:IAO_0000115 : An academic administrative position (associate dean, etc.) as distinct from a professional administrative position (non-academic)^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : That is a position held by an academic faculty member who works for administration.^^xsd:stringobo:IAO_0000112 : Associate Dean^^xsd:string</para>
    ///   <para>rdfs:label : Faculty Administrative Position^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#FacultyAdministrativePosition">vivo:FacultyAdministrativePosition</a>
    /// </summary>
    let FacultyAdministrativePosition = _prefixId.prefix "FacultyAdministrativePosition"
    /// <summary>
    ///   <para>http://vitro.mannlib.cornell.edu/ns/vitro/0.7#descriptionAnnot : Definition from here: http://research.carleton.ca/htr/defs.php.^^xsd:string</para>
    ///   <para>obo:IAO_0000115 : A person with at least one academic appointment to a specific faculty of a university or institution of higher learning.^^xsd:string</para>
    ///   <para>rdfs:label : Faculty Member^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#FacultyMember">vivo:FacultyMember</a>
    /// </summary>
    let FacultyMember = _prefixId.prefix "FacultyMember"
    /// <summary>
    ///   <para>obo:IAO_0000115 : An advisory relationship in which one faculty member mentors another faculty member.^^xsd:string</para>
    ///   <para>rdfs:label : Faculty Mentoring Relationship^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#FacultyMentoringRelationship">vivo:FacultyMentoringRelationship</a>
    /// </summary>
    let FacultyMentoringRelationship = _prefixId.prefix "FacultyMentoringRelationship"
    /// <summary>
    ///   <para>obo:IAO_0000115 : Academic position in a university or institution^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Professor; Associate Professor; Assistant Professor^^xsd:stringobo:IAO_0000112 : Professor, associate professor and assistant professor are common positions for academic faculty.^^xsd:string</para>
    ///   <para>rdfs:label : Faculty Position^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#FacultyPosition">vivo:FacultyPosition</a>
    /// </summary>
    let FacultyPosition = _prefixId.prefix "FacultyPosition"
    /// <summary>
    ///   <para>obo:IAO_0000115 : An institution founded with an endowment to support educational, research, artistic or other charitable activities.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Definition take from: http://dictionary.reference.com/browse/foundation.^^xsd:stringobo:IAO_0000112 : The Ford Foundation^^xsd:string</para>
    ///   <para>rdfs:label : Foundation^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Foundation">vivo:Foundation</a>
    /// </summary>
    let Foundation = _prefixId.prefix "Foundation"
    /// <summary>
    ///   <para>obo:IAO_0000115 : An organization that provides financial support to individuals or organizations to carry out specified activities.^^xsd:stringobo:IAO_0000115 : A defined class of organizations that fund Grants^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : National Institute of Health (NIH)^^xsd:string</para>
    ///   <para>rdfs:label : Funding Organization^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#FundingOrganization">vivo:FundingOrganization</a>
    /// </summary>
    let FundingOrganization = _prefixId.prefix "FundingOrganization"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A location having coordinates in geographic space.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Removed the word "stable" because disputed territories from geopolitical.owl are included. This could imply that the geographic coordinates could change. I've also copied this definition to core:Geographic Location.  I think core:Geographic Location and core:Geographic Region are both the same and only one is needed. There is also geopolitical.owl:geographical_region which further causes confusion.^^xsd:stringobo:IAO_0000112 : Use subclasses of core:Geographic Location subclasses instead of this class if possible.^^xsd:string</para>
    ///   <para>rdfs:label : Geographic Location^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#GeographicLocation">vivo:GeographicLocation</a>
    /// </summary>
    let GeographicLocation = _prefixId.prefix "GeographicLocation"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A location having coordinates in geographic space.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Use subclasses of core:Geographic Region subclasses instead of this class if possible.^^xsd:stringobo:IAO_0000112 : Removed the word "stable" because disputed territories from geopolitical.owl are included. This could imply that the geographic coordinates could change. This definition was originally in core:Geographic Location.  I simply copied the definition from there.  I think core:Geographic Location and core:Geographic Region are both the same and only one is needed. There is also geopolitical.owl:geographical_region which further causes confusion.^^xsd:string</para>
    ///   <para>rdfs:label : Geographic Region^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#GeographicRegion">vivo:GeographicRegion</a>
    /// </summary>
    let GeographicRegion = _prefixId.prefix "GeographicRegion"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A geographical area which is associated with some sort of political  structure.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Use subclasses of core:GeopoliticalEntity subclasses instead of this class if possible.^^xsd:stringobo:IAO_0000112 : Short definition obtained here: http://en.wiktionary.org/wiki/geopolitical_entity.^^xsd:string</para>
    ///   <para>rdfs:label : Geopolitical Entity^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#GeopoliticalEntity">vivo:GeopoliticalEntity</a>
    /// </summary>
    let GeopoliticalEntity = _prefixId.prefix "GeopoliticalEntity"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A unit of government responsible for oversight and regulation of certain activities or the administration and provision of specific services.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Definition take from: http://en.wikipedia.org/wiki/Government_agency.^^xsd:stringobo:IAO_0000112 : United States Library of Congress^^xsd:string</para>
    ///   <para>rdfs:label : Government Agency^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#GovernmentAgency">vivo:GovernmentAgency</a>
    /// </summary>
    let GovernmentAgency = _prefixId.prefix "GovernmentAgency"
    /// <summary>
    ///   <para>obo:IAO_0000115 : An advisory relationship in which a professor advises a graduate student.^^xsd:string</para>
    ///   <para>rdfs:label : Graduate Advising Relationship^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#GraduateAdvisingRelationship">vivo:GraduateAdvisingRelationship</a>
    /// </summary>
    let GraduateAdvisingRelationship = _prefixId.prefix "GraduateAdvisingRelationship"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A person who has already received a bachelor's degree and is working toward a Master's or Doctoral degree.^^xsd:string</para>
    ///   <para>rdfs:label : Graduate Student^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#GraduateStudent">vivo:GraduateStudent</a>
    /// </summary>
    let GraduateStudent = _prefixId.prefix "GraduateStudent"
    /// <summary>
    ///   <para>obo:IAO_0000112 : An intramural or extramural award to support scholarly work, such as UF09179 (VIVO)^^xsd:stringobo:IAO_0000112 : Short definition is from the Glossary of NIH Terms.^^xsd:string</para>
    ///   <para>rdfs:label : Grant^^xsd:string</para>
    ///   <para>obo:IAO_0000115 : Financial assistance mechanism providing money, property, or both to an eligible entity to carry out an approved project or activity^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Grant">vivo:Grant</a>
    /// </summary>
    let Grant = _prefixId.prefix "Grant"
    /// <summary>
    ///   <para>obo:IAO_0000115 : An institution that provides medical, surgical, psychiatric or nursing care.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Definition take from: http://dictionary.reference.com/browse/hospital.^^xsd:stringobo:IAO_0000112 : Shands at the University of Florida^^xsd:string</para>
    ///   <para>rdfs:label : Hospital^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Hospital">vivo:Hospital</a>
    /// </summary>
    let Hospital = _prefixId.prefix "Hospital"
    /// <summary>
    ///   <para>obo:IAO_0000115 : An Institute normally has a research focus but may also fulfill instructional or outreach roles^^xsd:stringobo:IAO_0000115 : An organization founded to pursue or promote certain research, educational or public policy interests or activities.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Institute for Fundamental Theory^^xsd:string</para>
    ///   <para>rdfs:label : Institute^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Institute">vivo:Institute</a>
    /// </summary>
    let Institute = _prefixId.prefix "Institute"
    /// <summary>
    ///   <para>obo:IAO_0000115 : Typically a student or a recent graduate undergoing supervised practical training.^^xsd:string</para>
    ///   <para>rdfs:label : Internship^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Internship">vivo:Internship</a>
    /// </summary>
    let Internship = _prefixId.prefix "Internship"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A role in an Agreement (for example, a grant) as a named investigator or key personnel.^^xsd:string</para>
    ///   <para>rdfs:label : Investigator Role^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#InvestigatorRole">vivo:InvestigatorRole</a>
    /// </summary>
    let InvestigatorRole = _prefixId.prefix "InvestigatorRole"
    /// <summary>
    ///   <para>rdfs:label : Invited Talk^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#InvitedTalk">vivo:InvitedTalk</a>
    /// </summary>
    let InvitedTalk = _prefixId.prefix "InvitedTalk"
    /// <summary>
    ///   <para>rdfs:label : Issued Credential^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#IssuedCredential">vivo:IssuedCredential</a>
    /// </summary>
    let IssuedCredential = _prefixId.prefix "IssuedCredential"
    /// <summary>
    ///   <para>obo:IAO_0000115 : An organization unit that facilitates or conduits observation, testing, experimentation, or research in a field of study or practice.^^xsd:stringobo:IAO_0000115 : An organizational unit (as opposed to the physical facility) that performs research, provides services, or processes materials^^xsd:string</para>
    ///   <para>rdfs:label : Laboratory^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Laboratory">vivo:Laboratory</a>
    /// </summary>
    let Laboratory = _prefixId.prefix "Laboratory"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A leadership role^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : A broad-ranging leader concept, from leading a small temporary committee to head of a large international organization.^^xsd:string</para>
    ///   <para>rdfs:label : Leader Role^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#LeaderRole">vivo:LeaderRole</a>
    /// </summary>
    let LeaderRole = _prefixId.prefix "LeaderRole"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A person working in a position of librarian or information professional, or academic or technical expert in support of providing information services or materials.^^xsd:string</para>
    ///   <para>rdfs:label : Librarian^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Librarian">vivo:Librarian</a>
    /// </summary>
    let Librarian = _prefixId.prefix "Librarian"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A position held  by library and information science professionals, or academic or technical experts, in support of providing information services or materials^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Librarian; Library Systems Analyst; Music Bibliographer^^xsd:stringobo:IAO_0000112 : It is the common position in libraries.^^xsd:string</para>
    ///   <para>rdfs:label : Librarian Position^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#LibrarianPosition">vivo:LibrarianPosition</a>
    /// </summary>
    let LibrarianPosition = _prefixId.prefix "LibrarianPosition"
    /// <summary>
    ///   <para>obo:IAO_0000115 : An organization maintaining one or more collections of physical and/or electronic information resources for access or lending.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Marston Science Library^^xsd:stringobo:IAO_0000112 : Used information from this definition: http://dictionary.reference.com/browse/library.^^xsd:string</para>
    ///   <para>rdfs:label : Library^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Library">vivo:Library</a>
    /// </summary>
    let Library = _prefixId.prefix "Library"
    /// <summary>
    ///   <para>obo:IAO_0000115 : Official or legal permission to do something^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Licenses are usually issued in order to regulate some activity that is deemed to be dangerous or a threat to the person or the public or which involves a high level of specialized skill.  See also core:Licensure.^^xsd:string</para>
    ///   <para>rdfs:label : License^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#License">vivo:License</a>
    /// </summary>
    let License = _prefixId.prefix "License"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A granted license, which gives a 'permission to practice.'^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : A granted license, which gives a 'permission to practice.' Such licenses are usually issued in order to regulate some activity that is deemed to be dangerous or a threat to the person or the public or which involves a high level of specialized skill.  See also core:License.^^xsd:string</para>
    ///   <para>rdfs:label : Licensure^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Licensure">vivo:Licensure</a>
    /// </summary>
    let Licensure = _prefixId.prefix "Licensure"
    /// <summary>
    ///   <para>obo:IAO_0000115 : Top level of all location classes.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : It's anticipated that the subclasses will be used when classifying items. And, all locations can be viewable via this class.^^xsd:stringobo:IAO_0000112 : Use subclasses of core:Location when classsifying items.^^xsd:string</para>
    ///   <para>rdfs:label : Location^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Location">vivo:Location</a>
    /// </summary>
    let Location = _prefixId.prefix "Location"
    /// <summary>
    ///   <para>obo:IAO_0000115 : Residency is a stage of graduate medical training.^^xsd:string</para>
    ///   <para>rdfs:label : Medical Residency^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#MedicalResidency">vivo:MedicalResidency</a>
    /// </summary>
    let MedicalResidency = _prefixId.prefix "MedicalResidency"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A gathering of people for a defined purpose, not necessarily public or announced^^xsd:string</para>
    ///   <para>rdfs:label : Meeting^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Meeting">vivo:Meeting</a>
    /// </summary>
    let Meeting = _prefixId.prefix "Meeting"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A role of being a member in a Process or an Organization^^xsd:string</para>
    ///   <para>rdfs:label : Member Role^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#MemberRole">vivo:MemberRole</a>
    /// </summary>
    let MemberRole = _prefixId.prefix "MemberRole"
    /// <summary>
    ///   <para>obo:IAO_0000115 : An organization devoted to the acquisition, conservation, study, exhibition, and educational interpretation of objects having scientific, historical, cultural or artistic value.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : The Getty Museum^^xsd:stringobo:IAO_0000112 : Definition was take from here:  http://dictionary.reference.com/browse/museum^^xsd:string</para>
    ///   <para>rdfs:label : Museum^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Museum">vivo:Museum</a>
    /// </summary>
    let Museum = _prefixId.prefix "Museum"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A short written piece focused on an event or announcement of note, having a defined publication time and of less enduring interest than a news feature.^^xsd:string</para>
    ///   <para>rdfs:label : News Release^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#NewsRelease">vivo:NewsRelease</a>
    /// </summary>
    let NewsRelease = _prefixId.prefix "NewsRelease"
    /// <summary>
    ///   <para>obo:IAO_0000115 : Usually issued periodically, prepared by or for a group or institution to present information to a specific audience, often also made available to the press and public^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : The Ornithological Newsletter^^xsd:string</para>
    ///   <para>rdfs:label : Newsletter^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Newsletter">vivo:Newsletter</a>
    /// </summary>
    let Newsletter = _prefixId.prefix "Newsletter"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A person holding a position that is not considered to be an academic appointment.^^xsd:string</para>
    ///   <para>rdfs:label : Non-Academic^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#NonAcademic">vivo:NonAcademic</a>
    /// </summary>
    let NonAcademic = _prefixId.prefix "NonAcademic"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A position classified as professional, staff, support, or any other non-academic role^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Accounting &amp; Research Services Assistant; Director of Information Technology^^xsd:stringobo:IAO_0000112 : Staff, support, and other non-academic positions.^^xsd:string</para>
    ///   <para>rdfs:label : Non-Academic Position^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#NonAcademicPosition">vivo:NonAcademicPosition</a>
    /// </summary>
    let NonAcademicPosition = _prefixId.prefix "NonAcademicPosition"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A person not considered a faculty member but holding an academic appointment.^^xsd:string</para>
    ///   <para>rdfs:label : Non-Faculty Academic^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#NonFacultyAcademic">vivo:NonFacultyAcademic</a>
    /// </summary>
    let NonFacultyAcademic = _prefixId.prefix "NonFacultyAcademic"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A position involving academic work but without faculty status^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Those positions are held by people who do academic work but do not have faculty positions in universities or institutes.^^xsd:stringobo:IAO_0000112 : Researcher; Academic Extension Associate; Postdoctoral Associate^^xsd:string</para>
    ///   <para>rdfs:label : Non-Faculty Academic Position^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#NonFacultyAcademicPosition">vivo:NonFacultyAcademicPosition</a>
    /// </summary>
    let NonFacultyAcademicPosition = _prefixId.prefix "NonFacultyAcademicPosition"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A role of organizing^^xsd:string</para>
    ///   <para>rdfs:label : Organizer Role^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#OrganizerRole">vivo:OrganizerRole</a>
    /// </summary>
    let OrganizerRole = _prefixId.prefix "OrganizerRole"
    /// <summary>
    ///   <para>rdfs:label : Organizing Process^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#OrganizingProcess">vivo:OrganizingProcess</a>
    /// </summary>
    let OrganizingProcess = _prefixId.prefix "OrganizingProcess"
    /// <summary>
    ///   <para>obo:IAO_0000115 : An outreach or community service role directed outside a person's primary profession and institution^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : The example is one outreach role required by US space agency NASA, which is related with one project in NASA. Name of the outreach role should be put here.^^xsd:stringobo:IAO_0000112 : Communicating Astronomy to the Public^^xsd:string</para>
    ///   <para>rdfs:label : Outreach Provider Role^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#OutreachProviderRole">vivo:OutreachProviderRole</a>
    /// </summary>
    let OutreachProviderRole = _prefixId.prefix "OutreachProviderRole"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A role of peer reviewing^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : is a generic term for a process of self-regulation by a profession or a process of evaluation involving qualified individuals within the relevant field. Peer review methods are employed to maintain standards, improve performance and provide credibility. In academia  the term is often used to denote a prepublication review of academic papers; reviewing an academic paper is often called refereeing.
    /// Contents
    /// [hide]^^xsd:string</para>
    ///   <para>rdfs:label : Peer Reviewer Role^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#PeerReviewerRole">vivo:PeerReviewerRole</a>
    /// </summary>
    let PeerReviewerRole = _prefixId.prefix "PeerReviewerRole"
    /// <summary>
    ///   <para>obo:IAO_0000115 : Either city or town - a thickly populated area having fixed boundaries and certain local powers of government.^^xsd:string</para>
    ///   <para>rdfs:label : Populated Place^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#PopulatedPlace">vivo:PopulatedPlace</a>
    /// </summary>
    let PopulatedPlace = _prefixId.prefix "PopulatedPlace"
    /// <summary>
    ///   <para>obo:IAO_0000115 : Particular position in an organization, commonly identified by job title, and normally associated with a job description that details the tasks and responsibilities that go with the position.^^xsd:string</para>
    ///   <para>rdfs:label : Position^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Director of Admissions and Placement; Associate University Librarian^^xsd:stringobo:IAO_0000112 : An employment activity, whether compensated or not. Short definition comes from http://en.wikipedia.org/wiki/Position, and has been modified.^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Position">vivo:Position</a>
    /// </summary>
    let Position = _prefixId.prefix "Position"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A Person holding an academic employment appointment focused on research rather than teaching; temporary (or for some defined term)^^xsd:string</para>
    ///   <para>rdfs:label : Postdoc^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Postdoc">vivo:Postdoc</a>
    /// </summary>
    let Postdoc = _prefixId.prefix "Postdoc"

    /// <summary>
    ///   <para>obo:IAO_0000115 : An advisory relationship in which the advisee is a Postdoc or Fellow.^^xsd:string</para>
    ///   <para>rdfs:label : Postdoc or Fellow Advising Relationship^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#PostdocOrFellowAdvisingRelationship">vivo:PostdocOrFellowAdvisingRelationship</a>
    /// </summary>
    let PostdocOrFellowAdvisingRelationship = _prefixId.prefix "PostdocOrFellowAdvisingRelationship"

    /// <summary>
    ///   <para>obo:IAO_0000115 : A postdoctoral training appointment (job)^^xsd:string</para>
    ///   <para>rdfs:label : Postdoctoral Position^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#PostdocPosition">vivo:PostdocPosition</a>
    /// </summary>
    let PostdocPosition = _prefixId.prefix "PostdocPosition"
    /// <summary>
    ///   <para>obo:IAO_0000115 : Postdoctoral research is academic or scholarly research conducted by a person who has completed his or her doctoral studies, normally within the following five years. It is intended to further deepen expertise in a specialist subject.^^xsd:string</para>
    ///   <para>rdfs:label : Postdoctoral Training^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#PostdoctoralTraining">vivo:PostdoctoralTraining</a>
    /// </summary>
    let PostdoctoralTraining = _prefixId.prefix "PostdoctoralTraining"
    /// <summary>
    ///   <para>obo:IAO_0000115 : Encompasses talk, speech, lecture, slide lecture, conference presentation^^xsd:string</para>
    ///   <para>rdfs:label : Presentation^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Presentation">vivo:Presentation</a>
    /// </summary>
    let Presentation = _prefixId.prefix "Presentation"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A role of presenting information^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Are we assuming that a PresenterRole is in a Presentation?  Or could you have a PresenterRole in, say, a committee?^^xsd:string</para>
    ///   <para>rdfs:label : Presenter Role^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#PresenterRole">vivo:PresenterRole</a>
    /// </summary>
    let PresenterRole = _prefixId.prefix "PresenterRole"
    /// <summary>
    ///   <para>rdfs:label : Presenting Process^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#PresentingProcess">vivo:PresentingProcess</a>
    /// </summary>
    let PresentingProcess = _prefixId.prefix "PresentingProcess"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A position designated as primary by the organization where it is held.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : A position designated as primary by the organization or group where it is held. This designation may be applied to zero or more of an agent's positions and may be asserted in conjunction with other subclasses of position.^^xsd:string</para>
    ///   <para>rdfs:label : Primary Position^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#PrimaryPosition">vivo:PrimaryPosition</a>
    /// </summary>
    let PrimaryPosition = _prefixId.prefix "PrimaryPosition"
    /// <summary>
    ///   <para>obo:IAO_0000115 : Role of a person to direct a project or activity being supported by an Agreement (for example, a grant), and who is accountable to the grantee for the proper conduct of the project or activity. Also known as Program Director or Project Director.^^xsd:string</para>
    ///   <para>rdfs:label : Principal Investigator Role^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#PrincipalInvestigatorRole">vivo:PrincipalInvestigatorRole</a>
    /// </summary>
    let PrincipalInvestigatorRole = _prefixId.prefix "PrincipalInvestigatorRole"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A private company is one that is privately-owned, and thus, is not publicly-traded in the stock market. Members of the general public cannot purchase stock in a private company unless that company chooses to go public and become a public company.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Definition obtained here: http://answers.ask.com/Business/Finance/what_is_a_private_company.  Examples of private companies found here: http://www.forbes.com/2008/11/03/largest-private-companies-biz-privates08-cx_sr_1103private_land.html^^xsd:stringobo:IAO_0000112 : Publix Super Markets; Ernst &amp; Young; PricewaterhouseCoopers^^xsd:string</para>
    ///   <para>rdfs:label : Private Company^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#PrivateCompany">vivo:PrivateCompany</a>
    /// </summary>
    let PrivateCompany = _prefixId.prefix "PrivateCompany"
    /// <summary>
    ///   <para>obo:IAO_0000115 : An ongoing academic initiative not formalized with department or division status.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : A Cornell graduate field (http://vivo.cornell.edu/index.jsp?home=65535&amp;collection=820)^^xsd:string</para>
    ///   <para>rdfs:label : Program^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Program">vivo:Program</a>
    /// </summary>
    let Program = _prefixId.prefix "Program"
    /// <summary>
    ///   <para>obo:IAO_0000115 : An endeavor, frequently collaborative, that occurs over a finite period of time and is intended to achieve a particular aim.^^xsd:string</para>
    ///   <para>rdfs:label : Project^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : An endeavor, frequently collaborative, that occurs over a finite period of time and is intended to achieve a particular aim.^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Project">vivo:Project</a>
    /// </summary>
    let Project = _prefixId.prefix "Project"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A person or company whose business is the publishing of books, periodicals, engravings, computer software, etc.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Definition found here: http://dictionary.reference.com/browse/publisher^^xsd:stringobo:IAO_0000112 : Elsevier; Harper &amp; Row; Indiana University Press^^xsd:string</para>
    ///   <para>rdfs:label : Publisher^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Publisher">vivo:Publisher</a>
    /// </summary>
    let Publisher = _prefixId.prefix "Publisher"
    /// <summary>
    ///   <para>obo:IAO_0000115 : a reified relationship^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : functions as an n-ary predicate^^xsd:string</para>
    ///   <para>rdfs:label : Relationship^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Relationship">vivo:Relationship</a>
    /// </summary>
    let Relationship = _prefixId.prefix "Relationship"
    /// <summary>
    ///   <para>obo:IAO_0000115 : Any organization (likely also asserted as another class of Organization) with a primary, ongoing research function, not just through occasional roles^^xsd:string</para>
    ///   <para>rdfs:label : Research Organization^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#ResearchOrganization">vivo:ResearchOrganization</a>
    /// </summary>
    let ResearchOrganization = _prefixId.prefix "ResearchOrganization"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A proposal for a research grant that has been submitted but not approved; does not represent an existing activity^^xsd:string</para>
    ///   <para>rdfs:label : Research Proposal^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#ResearchProposal">vivo:ResearchProposal</a>
    /// </summary>
    let ResearchProposal = _prefixId.prefix "ResearchProposal"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A role of conducting funded or unfunded research,  sometimes linked to an Agreement.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Examples of research can be seen at: http://www.ufl.edu/research/products/index.html.  Note these may have been funded, but the research doesn't have to be funded.  Also, the research may be linked to an Agreement (for example, a Grant), but does not need to be.^^xsd:string</para>
    ///   <para>rdfs:label : Researcher Role^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#ResearcherRole">vivo:ResearcherRole</a>
    /// </summary>
    let ResearcherRole = _prefixId.prefix "ResearcherRole"
    /// <summary>
    ///   <para>obo:IAO_0000115 : An article reviewing one or more other information resources (a book, one or more other articles, movies, etc)^^xsd:string</para>
    ///   <para>rdfs:label : Review^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Review">vivo:Review</a>
    /// </summary>
    let Review = _prefixId.prefix "Review"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A role that encompasses both ongoing reviewer responsibility for a bibo:Collection, such as a Journal or Series, and also a review performed for a bibo:Document, such as a book, academic article or conference paper.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : A role that encompasses both ongoing reviewer responsibility for a bibo:Collection, such as a Journal or Series, and also a review performed for a bibo:Document, such as a book, academic article or conference paper.^^xsd:string</para>
    ///   <para>rdfs:label : Reviewer Role^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#ReviewerRole">vivo:ReviewerRole</a>
    /// </summary>
    let ReviewerRole = _prefixId.prefix "ReviewerRole"
    /// <summary>
    ///   <para>obo:IAO_0000115 : Room that provides a particular service or is used for a particular activity.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : 100 Caldwell Hall; 114 Martha Van Rensselaer (Rushmore Conference Room)^^xsd:stringobo:IAO_0000112 : Enter room number of name.^^xsd:string</para>
    ///   <para>rdfs:label : Room^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Room">vivo:Room</a>
    /// </summary>
    let Room = _prefixId.prefix "Room"
    /// <summary>
    ///   <para>obo:IAO_0000115 : An institution for instruction in a particular skill or field.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : School of Architecture; School of Music^^xsd:stringobo:IAO_0000112 : Definition take from here: http://dictionary.reference.com/browse/school.^^xsd:string</para>
    ///   <para>rdfs:label : School^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#School">vivo:School</a>
    /// </summary>
    let School = _prefixId.prefix "School"
    /// <summary>
    ///   <para>obo:IAO_0000115 : Written musical composition for voice or instruments or both^^xsd:string</para>
    ///   <para>rdfs:label : Score^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Score">vivo:Score</a>
    /// </summary>
    let Score = _prefixId.prefix "Score"
    /// <summary>
    ///   <para>obo:IAO_0000115 : Written script for a film production, including dialogue and descriptions of gestures, actions, shooting directions^^xsd:string</para>
    ///   <para>rdfs:label : Screenplay^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Screenplay">vivo:Screenplay</a>
    /// </summary>
    let Screenplay = _prefixId.prefix "Screenplay"
    /// <summary>
    ///   <para>obo:IAO_0000115 : An organized series of a meeting for an exchange of ideas, typically put on by a department or center.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : For individual seminars, use seminar instead.  core:ConferenceSeries and core:SeminarSeries are very similar.^^xsd:stringobo:IAO_0000112 : Applied Microeconomics Seminars; Future of Rural New York Seminar Series^^xsd:string</para>
    ///   <para>rdfs:label : Seminar Series^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#SeminarSeries">vivo:SeminarSeries</a>
    /// </summary>
    let SeminarSeries = _prefixId.prefix "SeminarSeries"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A laboratory that provides services^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Ideally a defined class -- a Laboratory the provides some Service via the property^^xsd:string</para>
    ///   <para>rdfs:label : Service Providing Lab^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#ServiceProvidingLaboratory">vivo:ServiceProvidingLaboratory</a>
    /// </summary>
    let ServiceProvidingLaboratory = _prefixId.prefix "ServiceProvidingLaboratory"
    /// <summary>
    ///   <para>obo:IAO_0000115 : Text of a speech written in preparation for delivery of the speech.^^xsd:string</para>
    ///   <para>rdfs:label : Speech^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Speech">vivo:Speech</a>
    /// </summary>
    let Speech = _prefixId.prefix "Speech"
    /// <summary>
    ///   <para>obo:IAO_0000115 : One of a number of areas or communities having their own governments and forming a federation under a sovereign government, as in the US.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Source of the Short Definition: http://www.thefreedictionary.com/state.^^xsd:stringobo:IAO_0000112 : Minnesota; Michigan; Indiana; New York; Quebec; Manitoba; Ontario^^xsd:string</para>
    ///   <para>rdfs:label : State or Province^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#StateOrProvince">vivo:StateOrProvince</a>
    /// </summary>
    let StateOrProvince = _prefixId.prefix "StateOrProvince"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A person who is enrolled in an educational institution.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Use only if no specific subclasses of core:Student describe the person.^^xsd:string</para>
    ///   <para>rdfs:label : Student^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Student">vivo:Student</a>
    /// </summary>
    let Student = _prefixId.prefix "Student"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A student organization is an organization, operated by students at a university, whose membership normally consists only of students.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Dancin' Gators^^xsd:stringobo:IAO_0000112 : Definition take from here: http://en.wikipedia.org/wiki/Student_society^^xsd:string</para>
    ///   <para>rdfs:label : Student Organization^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#StudentOrganization">vivo:StudentOrganization</a>
    /// </summary>
    let StudentOrganization = _prefixId.prefix "StudentOrganization"
    /// <summary>
    ///   <para>obo:IAO_0000115 : Smaller administrative division into which a country may be divided.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Boroughs; townships; districts; the Midwest^^xsd:stringobo:IAO_0000112 : Short definition was partially taken from http://en.wikipedia.org/wiki/Subnational_entity.^^xsd:string</para>
    ///   <para>rdfs:label : Subnational Region^^xsd:string</para>
    ///   <para>rdfs:comment : For example, the Midwest, northeast U.S.^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#SubnationalRegion">vivo:SubnationalRegion</a>
    /// </summary>
    let SubnationalRegion = _prefixId.prefix "SubnationalRegion"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A role of serving as an educator^^xsd:string</para>
    ///   <para>rdfs:label : Teacher Role^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#TeacherRole">vivo:TeacherRole</a>
    /// </summary>
    let TeacherRole = _prefixId.prefix "TeacherRole"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A group of people working together.^^xsd:stringobo:IAO_0000115 : An informal organization brought together for the purposes of a project or event^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : VIVO Outreach Team; VIVO Ontology Team^^xsd:string</para>
    ///   <para>rdfs:label : Team^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Team">vivo:Team</a>
    /// </summary>
    let Team = _prefixId.prefix "Team"
    /// <summary>
    ///   <para>obo:IAO_0000115 : The result of rendering a work from one language to another^^xsd:string</para>
    ///   <para>rdfs:label : Translation^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Translation">vivo:Translation</a>
    /// </summary>
    let Translation = _prefixId.prefix "Translation"

    /// <summary>
    ///   <para>obo:IAO_0000115 : An advisory relationship in which a professor advises an undergraduate student.^^xsd:string</para>
    ///   <para>rdfs:label : Undergraduate Advising Relationship^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#UndergraduateAdvisingRelationship">vivo:UndergraduateAdvisingRelationship</a>
    /// </summary>
    let UndergraduateAdvisingRelationship = _prefixId.prefix "UndergraduateAdvisingRelationship"

    /// <summary>
    ///   <para>obo:IAO_0000115 : A person registered in an undergraduate program leading to a bachelor's degree or an undergraduate diploma or certificate.^^xsd:string</para>
    ///   <para>rdfs:label : Undergraduate Student^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#UndergraduateStudent">vivo:UndergraduateStudent</a>
    /// </summary>
    let UndergraduateStudent = _prefixId.prefix "UndergraduateStudent"
    /// <summary>
    ///   <para>obo:IAO_0000115 : An institution of higher education and research, which grants academic degrees in a variety of subjects, and provides both undergraduate education and postgraduate education.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Definition taken from: http://en.wikipedia.org/wiki/University^^xsd:stringobo:IAO_0000112 : University of Florida; Washington University in St. Louis^^xsd:string</para>
    ///   <para>rdfs:label : University^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#University">vivo:University</a>
    /// </summary>
    let University = _prefixId.prefix "University"
    /// <summary>
    ///   <para>obo:IAO_0000115 : Audiovisual recording in video format^^xsd:string</para>
    ///   <para>rdfs:label : Video^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#Video">vivo:Video</a>
    /// </summary>
    let Video = _prefixId.prefix "Video"
    /// <summary>
    ///   <para>obo:IAO_0000115 : A document created as a basis for discussion or a very early draft of a formal paper^^xsd:string</para>
    ///   <para>rdfs:label : Working Paper^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#WorkingPaper">vivo:WorkingPaper</a>
    /// </summary>
    let WorkingPaper = _prefixId.prefix "WorkingPaper"
    /// <summary>
    ///   <para>obo:IAO_0000115 : An organized series of workshop events, whether repetitions of the same workshop or multiple different workshops.^^xsd:string</para>
    ///   <para>obo:IAO_0000112 : Use workshop for individual events.^^xsd:string</para>
    ///   <para>rdfs:label : Workshop Series^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#WorkshopSeries">vivo:WorkshopSeries</a>
    /// </summary>
    let WorkshopSeries = _prefixId.prefix "WorkshopSeries"
    /// <summary>
    ///   <para>obo:IAO_0000112 : B.A.^^xsd:stringobo:IAO_0000112 : A short form for an longer title or name.^^xsd:string</para>
    ///   <para>rdfs:label : abbreviation^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#abbreviation">vivo:abbreviation</a>
    /// </summary>
    let abbreviation = _prefixId.prefix "abbreviation"
    /// <summary>
    ///   <para>rdfs:label : has affiliated organization^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#affiliatedOrganization">vivo:affiliatedOrganization</a>
    /// </summary>
    let affiliatedOrganization = _prefixId.prefix "affiliatedOrganization"
    /// <summary>
    ///   <para>obo:IAO_0000115 : Relates a Relationship (as a predicate or n-ary relation over one or more Thing) to an Agent that defined or instantiated the predicate instance.</para>
    ///   <para>rdfs:label : assigned by^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#assignedBy">vivo:assignedBy</a>
    /// </summary>
    let assignedBy = _prefixId.prefix "assignedBy"
    /// <summary>
    ///   <para>rdfs:label : assignee^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#assignee">vivo:assignee</a>
    /// </summary>
    let assignee = _prefixId.prefix "assignee"
    /// <summary>
    ///   <para>rdfs:label : assignee for patent^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#assigneeFor">vivo:assigneeFor</a>
    /// </summary>
    let assigneeFor = _prefixId.prefix "assigneeFor"
    /// <summary>
    ///   <para>rdfs:label : assigns^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#assigns">vivo:assigns</a>
    /// </summary>
    let assigns = _prefixId.prefix "assigns"
    /// <summary>
    ///   <para>rdfs:label : published US Classification Class/subclass (CCL) code^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#cclCode">vivo:cclCode</a>
    /// </summary>
    let cclCode = _prefixId.prefix "cclCode"
    let conceptAssociatedWith = _prefixId.prefix "conceptAssociatedWith"
    let contactInformation = _prefixId.prefix "contactInformation"
    /// <summary>
    ///   <para>rdfs:label : contributor^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#contributingRole">vivo:contributingRole</a>
    /// </summary>
    let contributingRole = _prefixId.prefix "contributingRole"
    /// <summary>
    ///   <para>rdfs:label : credits^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#courseCredits">vivo:courseCredits</a>
    /// </summary>
    let courseCredits = _prefixId.prefix "courseCredits"
    /// <summary>
    ///   <para>rdfs:label : date filed^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#dateFiled">vivo:dateFiled</a>
    /// </summary>
    let dateFiled = _prefixId.prefix "dateFiled"
    /// <summary>
    ///   <para>rdfs:label : date issued^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#dateIssued">vivo:dateIssued</a>
    /// </summary>
    let dateIssued = _prefixId.prefix "dateIssued"
    /// <summary>
    ///   <para>rdfs:label : date/time^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#dateTime">vivo:dateTime</a>
    /// </summary>
    let dateTime = _prefixId.prefix "dateTime"
    /// <summary>
    ///   <para>rdfs:label : date/time interval^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#dateTimeInterval">vivo:dateTimeInterval</a>
    /// </summary>
    let dateTimeInterval = _prefixId.prefix "dateTimeInterval"
    /// <summary>
    ///   <para>rdfs:label : date/time precision^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#dateTimePrecision">vivo:dateTimePrecision</a>
    /// </summary>
    let dateTimePrecision = _prefixId.prefix "dateTimePrecision"
    /// <summary>
    ///   <para>rdfs:label : date/time value^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#dateTimeValue">vivo:dateTimeValue</a>
    /// </summary>
    let dateTimeValue = _prefixId.prefix "dateTimeValue"
    /// <summary>
    ///   <para>rdfs:label : degree candidacy^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#degreeCandidacy">vivo:degreeCandidacy</a>
    /// </summary>
    let degreeCandidacy = _prefixId.prefix "degreeCandidacy"
    /// <summary>
    ///   <para>http://vitro.mannlib.cornell.edu/ns/vitro/0.7#descriptionAnnot : Not intended to be an institution name.^^xsd:string</para>
    ///   <para>rdfs:label : department or school name within institution^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#departmentOrSchool">vivo:departmentOrSchool</a>
    /// </summary>
    let departmentOrSchool = _prefixId.prefix "departmentOrSchool"
    /// <summary>
    ///   <para>rdfs:label : description^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#description">vivo:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>http://vitro.mannlib.cornell.edu/ns/vitro/0.7#descriptionAnnot : Public Description for bibo:distributor taken from here:  http://bibotools.googlecode.com/svn/bibo-ontology/trunk/doc/index.html .^^xsd:string</para>
    ///   <para>rdfs:label : distributes^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#distributes">vivo:distributes</a>
    /// </summary>
    let distributes = _prefixId.prefix "distributes"
    /// <summary>
    ///   <para>http://vitro.mannlib.cornell.edu/ns/vitro/0.7#descriptionAnnot : For example, National Science Foundation providesFundingThrough Graduate Research Fellowship Program; National Institutes of Health providesFundingThrough National Center for Research Resources.^^xsd:string</para>
    ///   <para>rdfs:label : distributes funding from^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#distributesFundingFrom">vivo:distributesFundingFrom</a>
    /// </summary>
    let distributesFundingFrom = _prefixId.prefix "distributesFundingFrom"
    /// <summary>
    ///   <para>rdfs:label : eRA Commons ID^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#eRACommonsId">vivo:eRACommonsId</a>
    /// </summary>
    let eRACommonsId = _prefixId.prefix "eRACommonsId"
    /// <summary>
    ///   <para>rdfs:label : credential eligibility attained^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#eligibleFor">vivo:eligibleFor</a>
    /// </summary>
    let eligibleFor = _prefixId.prefix "eligibleFor"
    /// <summary>
    ///   <para>rdfs:label : end^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#end">vivo:end</a>
    /// </summary>
    let end_ = _prefixId.prefix "end"
    /// <summary>
    ///   <para>rdfs:label : entry term^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#entryTerm">vivo:entryTerm</a>
    /// </summary>
    let entryTerm = _prefixId.prefix "entryTerm"
    /// <summary>
    ///   <para>rdfs:label : equipment for^^xsd:stringrdfs:label : equipment for</para>
    ///   <a href="http://vivoweb.org/ontology/core#equipmentFor">vivo:equipmentFor</a>
    /// </summary>
    let equipmentFor = _prefixId.prefix "equipmentFor"
    /// <summary>
    ///   <para>rdfs:label : expiration date^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#expirationDate">vivo:expirationDate</a>
    /// </summary>
    let expirationDate = _prefixId.prefix "expirationDate"
    let facilityFor = _prefixId.prefix "facilityFor"
    /// <summary>
    ///   <para>http://vitro.mannlib.cornell.edu/ns/vitro/0.7#descriptionAnnot : This is done through a restriction on the foaf:Person class.^^xsd:string</para>
    ///   <para>rdfs:label : featured in^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#featuredIn">vivo:featuredIn</a>
    /// </summary>
    let featuredIn = _prefixId.prefix "featuredIn"
    /// <summary>
    ///   <para>obo:IAO_0000112 : This is done through a restriction on the foaf:Person class.^^xsd:string</para>
    ///   <para>rdfs:label : features^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#features">vivo:features</a>
    /// </summary>
    let features = _prefixId.prefix "features"
    /// <summary>
    ///   <para>obo:IAO_0000112 : one keyword or phrase per freetextKeyword assertion^^xsd:stringobo:IAO_0000112 : conservation
    ///
    /// use one freetextKeyword assertion for each keyword or phrase.^^xsd:string</para>
    ///   <para>rdfs:label : keywords^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#freetextKeyword">vivo:freetextKeyword</a>
    /// </summary>
    let freetextKeyword = _prefixId.prefix "freetextKeyword"
    /// <summary>
    ///   <para>rdfs:label : provides funding for^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#fundingVehicleFor">vivo:fundingVehicleFor</a>
    /// </summary>
    let fundingVehicleFor = _prefixId.prefix "fundingVehicleFor"
    /// <summary>
    ///   <para>rdfs:label : geographic focus^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#geographicFocus">vivo:geographicFocus</a>
    /// </summary>
    let geographicFocus = _prefixId.prefix "geographicFocus"
    /// <summary>
    ///   <para>rdfs:label : geographic focus of^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#geographicFocusOf">vivo:geographicFocusOf</a>
    /// </summary>
    let geographicFocusOf = _prefixId.prefix "geographicFocusOf"
    /// <summary>
    ///   <para>rdfs:label : governing authority for^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#governingAuthorityFor">vivo:governingAuthorityFor</a>
    /// </summary>
    let governingAuthorityFor = _prefixId.prefix "governingAuthorityFor"
    /// <summary>
    ///   <para>rdfs:label : direct costs^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#grantDirectCosts">vivo:grantDirectCosts</a>
    /// </summary>
    let grantDirectCosts = _prefixId.prefix "grantDirectCosts"
    /// <summary>
    ///   <para>rdfs:label : subcontracted through^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#grantSubcontractedThrough">vivo:grantSubcontractedThrough</a>
    /// </summary>
    let grantSubcontractedThrough = _prefixId.prefix "grantSubcontractedThrough"
    /// <summary>
    ///   <para>rdfs:label : associated concept^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#hasAssociatedConcept">vivo:hasAssociatedConcept</a>
    /// </summary>
    let hasAssociatedConcept = _prefixId.prefix "hasAssociatedConcept"
    /// <summary>
    ///   <para>rdfs:label : has collaborator^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#hasCollaborator">vivo:hasCollaborator</a>
    /// </summary>
    let hasCollaborator = _prefixId.prefix "hasCollaborator"
    /// <summary>
    ///   <para>rdfs:label : has equipment^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#hasEquipment">vivo:hasEquipment</a>
    /// </summary>
    let hasEquipment = _prefixId.prefix "hasEquipment"
    let hasFacility = _prefixId.prefix "hasFacility"
    let hasFundingVehicle = _prefixId.prefix "hasFundingVehicle"
    let hasGoverningAuthority = _prefixId.prefix "hasGoverningAuthority"
    /// <summary>
    ///   <para>rdfs:label : has monetary amount^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#hasMonetaryAmount">vivo:hasMonetaryAmount</a>
    /// </summary>
    let hasMonetaryAmount = _prefixId.prefix "hasMonetaryAmount"
    /// <summary>
    ///   <para>rdfs:label : predecessor organization^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#hasPredecessorOrganization">vivo:hasPredecessorOrganization</a>
    /// </summary>
    let hasPredecessorOrganization = _prefixId.prefix "hasPredecessorOrganization"
    /// <summary>
    ///   <para>rdfs:label : has prerequisite^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#hasPrerequisite">vivo:hasPrerequisite</a>
    /// </summary>
    let hasPrerequisite = _prefixId.prefix "hasPrerequisite"
    /// <summary>
    ///   <para>http://vitro.mannlib.cornell.edu/ns/vitro/0.7#descriptionAnnot : A possible working example: The conference proceeding of the SPIE was generated from the conference - International Society for Optical Engineering.^^xsd:string</para>
    ///   <para>rdfs:label : proceedings^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#hasProceedings">vivo:hasProceedings</a>
    /// </summary>
    let hasProceedings = _prefixId.prefix "hasProceedings"
    /// <summary>
    ///   <para>rdfs:label : published in^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#hasPublicationVenue">vivo:hasPublicationVenue</a>
    /// </summary>
    let hasPublicationVenue = _prefixId.prefix "hasPublicationVenue"
    /// <summary>
    ///   <para>rdfs:label : research areas^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#hasResearchArea">vivo:hasResearchArea</a>
    /// </summary>
    let hasResearchArea = _prefixId.prefix "hasResearchArea"
    /// <summary>
    ///   <para>rdfs:label : has subject area^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#hasSubjectArea">vivo:hasSubjectArea</a>
    /// </summary>
    let hasSubjectArea = _prefixId.prefix "hasSubjectArea"
    /// <summary>
    ///   <para>rdfs:label : successor organization^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#hasSuccessorOrganization">vivo:hasSuccessorOrganization</a>
    /// </summary>
    let hasSuccessorOrganization = _prefixId.prefix "hasSuccessorOrganization"
    /// <summary>
    ///   <para>obo:IAO_0000112 : Examples shows a book has French language version. Public description source: http://bibotools.googlecode.com/svn/bibo-ontology/trunk/doc/index.html .^^xsd:string</para>
    ///   <para>rdfs:label : has translation^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#hasTranslation">vivo:hasTranslation</a>
    /// </summary>
    let hasTranslation = _prefixId.prefix "hasTranslation"
    /// <summary>
    ///   <para>rdfs:label : has value^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#hasValue">vivo:hasValue</a>
    /// </summary>
    let hasValue = _prefixId.prefix "hasValue"
    /// <summary>
    ///   <para>rdfs:label : hide from display^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#hideFromDisplay">vivo:hideFromDisplay</a>
    /// </summary>
    let hideFromDisplay = _prefixId.prefix "hideFromDisplay"
    /// <summary>
    ///   <para>http://vitro.mannlib.cornell.edu/ns/vitro/0.7#exampleAnnot : administrative secretary^^xsd:string</para>
    ///   <para>http://vitro.mannlib.cornell.edu/ns/vitro/0.7#descriptionAnnot : Definition http://en.wikipedia.org/wiki/Job_title#Job_title.^^xsd:string</para>
    ///   <para>rdfs:label : HR job title^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#hrJobTitle">vivo:hrJobTitle</a>
    /// </summary>
    let hrJobTitle = _prefixId.prefix "hrJobTitle"
    /// <summary>
    ///   <para>obo:IAO_0000112 : The International classification(s) to which the published application has been assigned.^^xsd:string</para>
    ///   <para>rdfs:label : International Classification (ICL) code^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#iclCode">vivo:iclCode</a>
    /// </summary>
    let iclCode = _prefixId.prefix "iclCode"
    /// <summary>
    ///   <para>rdfs:label : identifier^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#identifier">vivo:identifier</a>
    /// </summary>
    let identifier = _prefixId.prefix "identifier"
    let inPress = _prefixId.prefix "inPress"

    /// <summary>
    ///   <para>http://vitro.mannlib.cornell.edu/ns/vitro/0.7#descriptionAnnot : an information resource (typically a publication) supported by (typically via funding) an agreement (such as a grant)^^xsd:string</para>
    ///   <para>rdfs:label : supported by^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#informationResourceSupportedBy">vivo:informationResourceSupportedBy</a>
    /// </summary>
    let informationResourceSupportedBy = _prefixId.prefix "informationResourceSupportedBy"

    let invited = _prefixId.prefix "invited"
    /// <summary>
    ///   <para>http://vitro.mannlib.cornell.edu/ns/vitro/0.7#exampleAnnot : True; False^^xsd:string</para>
    ///   <para>rdfs:label : Is this person a corresponding author?^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#isCorrespondingAuthor">vivo:isCorrespondingAuthor</a>
    /// </summary>
    let isCorrespondingAuthor = _prefixId.prefix "isCorrespondingAuthor"
    /// <summary>
    ///   <para>rdfs:label : license number^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#licenseNumber">vivo:licenseNumber</a>
    /// </summary>
    let licenseNumber = _prefixId.prefix "licenseNumber"
    /// <summary>
    ///   <para>obo:IAO_0000112 : core:localAwardId has a domain of core:Grant, and should be public since that's its public identifier for local use by OSP, accounting, department admins, and the PI^^xsd:string</para>
    ///   <para>rdfs:label : local award ID^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#localAwardId">vivo:localAwardId</a>
    /// </summary>
    let localAwardId = _prefixId.prefix "localAwardId"
    /// <summary>
    ///   <para>obo:IAO_0000112 : Information Science; Computer Science; Anthropology^^xsd:string</para>
    ///   <para>rdfs:label : major field of degree^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#majorField">vivo:majorField</a>
    /// </summary>
    let majorField = _prefixId.prefix "majorField"
    /// <summary>
    ///   <para>rdfs:label : middle name or initial^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#middleName">vivo:middleName</a>
    /// </summary>
    let middleName = _prefixId.prefix "middleName"
    /// <summary>
    ///   <para>rdfs:label : NIH Manuscript Submission System ID^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#nihmsid">vivo:nihmsid</a>
    /// </summary>
    let nihmsid = _prefixId.prefix "nihmsid"
    /// <summary>
    ///   <para>rdfs:label : offered by^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#offeredBy">vivo:offeredBy</a>
    /// </summary>
    let offeredBy = _prefixId.prefix "offeredBy"
    /// <summary>
    ///   <para>rdfs:label : offers^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#offers">vivo:offers</a>
    /// </summary>
    let offers = _prefixId.prefix "offers"
    /// <summary>
    ///   <para>obo:IAO_0000112 : This is now an object property where the object value is a resource of the form &lt;http://orcid.org/NNNN-NNNN-NNNN-NNNN&gt;.  This is to support connecting VIVO and ORCID in the linked data web.   Note: a person can have multiple ORCID iDs.^^xsd:string</para>
    ///   <para>rdfs:label : ORCID iD^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#orcidId">vivo:orcidId</a>
    /// </summary>
    let orcidId = _prefixId.prefix "orcidId"
    /// <summary>
    ///   <para>obo:IAO_0000112 : My extension program consists of developing and reporting disease management strategies that are both economically and environmentally sound for fresh market vegetable production. We hope that some of this testing will result in practices adaptable for organic production.^^xsd:stringobo:IAO_0000112 : Used for a single narrative summary of outreach, typically covering a wide range of activities and time periods; use Outreach Provider Role for information on individual activities^^xsd:string</para>
    ///   <para>rdfs:label : outreach overview^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#outreachOverview">vivo:outreachOverview</a>
    /// </summary>
    let outreachOverview = _prefixId.prefix "outreachOverview"
    /// <summary>
    ///   <para>rdfs:label : overview^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#overview">vivo:overview</a>
    /// </summary>
    let overview = _prefixId.prefix "overview"
    /// <summary>
    ///   <para>obo:IAO_0000112 : source of definition: http://www.uspto.gov/main/glossary/#p . The following site has patent number formats: http://www.uspto.gov/patents/ebc/kindcodesum.jsp .^^xsd:string</para>
    ///   <para>rdfs:label : patent number^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#patentNumber">vivo:patentNumber</a>
    /// </summary>
    let patentNumber = _prefixId.prefix "patentNumber"
    /// <summary>
    ///   <para>rdfs:label : place of publication^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#placeOfPublication">vivo:placeOfPublication</a>
    /// </summary>
    let placeOfPublication = _prefixId.prefix "placeOfPublication"
    /// <summary>
    ///   <para>obo:IAO_0000112 : A PMCID is a unique PubMed Central reference number, which is assigned to each full-text record made available A PMCID is a unique PubMed Central reference number, which is assigned to each full-text record made available in PubMed Central. The PMCID is issued shortly after the PI or author approves the PubMed Central formatted web version of the submission.^^xsd:string</para>
    ///   <para>rdfs:label : PubMed Central ID^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#pmcid">vivo:pmcid</a>
    /// </summary>
    let pmcid = _prefixId.prefix "pmcid"
    /// <summary>
    ///   <para>rdfs:label : preferred display order^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#preferredDisplayOrder">vivo:preferredDisplayOrder</a>
    /// </summary>
    let preferredDisplayOrder = _prefixId.prefix "preferredDisplayOrder"
    /// <summary>
    ///   <para>rdfs:label : prerequisite for^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#prerequisiteFor">vivo:prerequisiteFor</a>
    /// </summary>
    let prerequisiteFor = _prefixId.prefix "prerequisiteFor"
    /// <summary>
    ///   <para>http://vitro.mannlib.cornell.edu/ns/vitro/0.7#descriptionAnnot : A possible working example: The conference proceeding of the SPIE was generated from the conference - International Society for Optical Engineering.^^xsd:string</para>
    ///   <para>rdfs:label : proceedings of^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#proceedingsOf">vivo:proceedingsOf</a>
    /// </summary>
    let proceedingsOf = _prefixId.prefix "proceedingsOf"
    /// <summary>
    ///   <para>obo:IAO_0000112 : For example, National Science Foundation providesFundingThrough Graduate Research Fellowship Program; National Institutes of Health providesFundingThrough National Center for Research Resources.^^xsd:string</para>
    ///   <para>rdfs:label : provides funding through^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#providesFundingThrough">vivo:providesFundingThrough</a>
    /// </summary>
    let providesFundingThrough = _prefixId.prefix "providesFundingThrough"
    /// <summary>
    ///   <para>rdfs:label : publication venue for^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#publicationVenueFor">vivo:publicationVenueFor</a>
    /// </summary>
    let publicationVenueFor = _prefixId.prefix "publicationVenueFor"
    /// <summary>
    ///   <para>obo:IAO_0000112 : Public Definition source (http://www.answers.com/topic/publisher).^^xsd:string</para>
    ///   <para>rdfs:label : publisher^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#publisher">vivo:publisher</a>
    /// </summary>
    let publisher = _prefixId.prefix "publisher"
    /// <summary>
    ///   <para>obo:IAO_0000112 : Public Definition source (http://www.answers.com/topic/publisher).^^xsd:string</para>
    ///   <para>rdfs:label : publisher of^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#publisherOf">vivo:publisherOf</a>
    /// </summary>
    let publisherOf = _prefixId.prefix "publisherOf"
    /// <summary>
    ///   <para>obo:IAO_0000112 : this number indicates a position in a list^^xsd:string</para>
    ///   <para>rdfs:label : rank^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#rank">vivo:rank</a>
    /// </summary>
    let rank = _prefixId.prefix "rank"
    /// <summary>
    ///   <para>obo:IAO_0000115 : Relates a Thing to a Relationship as a Thing that is somehow related to other Thing in the same Relationship instance. A Relationship instnace is a predicate over Thing and is created by an Agent.</para>
    ///   <para>rdfs:label : related by^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#relatedBy">vivo:relatedBy</a>
    /// </summary>
    let relatedBy = _prefixId.prefix "relatedBy"
    /// <summary>
    ///   <para>obo:IAO_0000115 : Relates a Relationship instance to the one or more Thing of the Relationship. There is a separate property (assigned by) to relate to the Agent that defines the Relationship.</para>
    ///   <para>rdfs:label : relates^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#relates">vivo:relates</a>
    /// </summary>
    let relates = _prefixId.prefix "relates"
    /// <summary>
    ///   <para>rdfs:label : report identifier^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#reportId">vivo:reportId</a>
    /// </summary>
    let reportId = _prefixId.prefix "reportId"
    /// <summary>
    ///   <para>rdfs:label : reproduces^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#reproduces">vivo:reproduces</a>
    /// </summary>
    let reproduces = _prefixId.prefix "reproduces"
    /// <summary>
    ///   <para>rdfs:label : research area of^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#researchAreaOf">vivo:researchAreaOf</a>
    /// </summary>
    let researchAreaOf = _prefixId.prefix "researchAreaOf"
    /// <summary>
    ///   <para>obo:IAO_0000112 : Used for a single narrative summary of research, typically covering a wide range of activities and time periods; use Researcher Role for information on individual activities^^xsd:string</para>
    ///   <para>rdfs:label : research overview^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#researchOverview">vivo:researchOverview</a>
    /// </summary>
    let researchOverview = _prefixId.prefix "researchOverview"
    /// <summary>
    ///   <para>obo:IAO_0000112 : RearcherID is a Thomson Reuters project where researchers have a place to manage and share their professional information. It will allow them to solve author identity issues while simultaneously adding dynamic citation metrics and collaboration networks to your personal profile.
    /// Definition source: http://isiwebofknowledge.com/researcherid/^^xsd:string</para>
    ///   <para>rdfs:label : ISI Researcher ID^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#researcherId">vivo:researcherId</a>
    /// </summary>
    let researcherId = _prefixId.prefix "researcherId"
    /// <summary>
    ///   <para>http://vitro.mannlib.cornell.edu/ns/vitro/0.7#descriptionAnnot : The bibo:reviewOf public description was found here: http://bibotools.googlecode.com/svn/bibo-ontology/trunk/doc/index.html .  As of 26 May 2010, bibo:reviewOf is used with the class Review, but core:reviewIn doesn't seem to be being used.^^xsd:string</para>
    ///   <para>rdfs:label : reviewed in^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#reviewedIn">vivo:reviewedIn</a>
    /// </summary>
    let reviewedIn = _prefixId.prefix "reviewedIn"
    /// <summary>
    ///   <para>rdfs:label : contributes to^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#roleContributesTo">vivo:roleContributesTo</a>
    /// </summary>
    let roleContributesTo = _prefixId.prefix "roleContributesTo"
    /// <summary>
    ///   <para>obo:IAO_0000112 : Home page for Scopus: http://www.scopus.com/home.url^^xsd:string</para>
    ///   <para>rdfs:label : Scopus ID^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#scopusId">vivo:scopusId</a>
    /// </summary>
    let scopusId = _prefixId.prefix "scopusId"
    /// <summary>
    ///   <para>obo:IAO_0000112 : definition modified from: source (http://en.wikipedia.org/wiki/Seating_capacity).^^xsd:stringobo:IAO_0000112 : 55^^xsd:string</para>
    ///   <para>rdfs:label : seating capacity^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#seatingCapacity">vivo:seatingCapacity</a>
    /// </summary>
    let seatingCapacity = _prefixId.prefix "seatingCapacity"
    /// <summary>
    ///   <para>obo:IAO_0000112 : Has a domain of Grant. There is not a strong reason have this be publically visible, since most users would care more about the name of the sponsoring agency than its identifier, but it does no harm to be public.
    ///
    ///
    /// See also core:localAwardId.^^xsd:string</para>
    ///   <para>rdfs:label : sponsor award ID^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#sponsorAwardId">vivo:sponsorAwardId</a>
    /// </summary>
    let sponsorAwardId = _prefixId.prefix "sponsorAwardId"
    /// <summary>
    ///   <para>rdfs:label : award sponsored by^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#sponsoredBy">vivo:sponsoredBy</a>
    /// </summary>
    let sponsoredBy = _prefixId.prefix "sponsoredBy"
    /// <summary>
    ///   <para>rdfs:label : sponsors award or honor^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#sponsors">vivo:sponsors</a>
    /// </summary>
    let sponsors = _prefixId.prefix "sponsors"
    /// <summary>
    ///   <para>rdfs:label : start^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#start">vivo:start</a>
    /// </summary>
    let start = _prefixId.prefix "start"
    /// <summary>
    ///   <para>rdfs:label : subcontracts grant^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#subcontractsGrant">vivo:subcontractsGrant</a>
    /// </summary>
    let subcontractsGrant = _prefixId.prefix "subcontractsGrant"
    /// <summary>
    ///   <para>rdfs:label : subject area of^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#subjectAreaOf">vivo:subjectAreaOf</a>
    /// </summary>
    let subjectAreaOf = _prefixId.prefix "subjectAreaOf"
    let submitted = _prefixId.prefix "submitted"
    /// <summary>
    ///   <para>rdfs:label : supplemental information^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#supplementalInformation">vivo:supplementalInformation</a>
    /// </summary>
    let supplementalInformation = _prefixId.prefix "supplementalInformation"
    /// <summary>
    ///   <para>http://vitro.mannlib.cornell.edu/ns/vitro/0.7#descriptionAnnot : general relationship of support^^xsd:string</para>
    ///   <para>rdfs:label : supported by^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#supportedBy">vivo:supportedBy</a>
    /// </summary>
    let supportedBy = _prefixId.prefix "supportedBy"
    /// <summary>
    ///   <para>http://vitro.mannlib.cornell.edu/ns/vitro/0.7#descriptionAnnot : an information resource (typically a publication) supported by (typically via funding) an agreement (such as a grant)^^xsd:string</para>
    ///   <para>rdfs:label : supported publications or other works^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#supportedInformationResource">vivo:supportedInformationResource</a>
    /// </summary>
    let supportedInformationResource = _prefixId.prefix "supportedInformationResource"
    /// <summary>
    ///   <para>http://vitro.mannlib.cornell.edu/ns/vitro/0.7#descriptionAnnot : general relationship of support^^xsd:string</para>
    ///   <para>rdfs:label : supports^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#supports">vivo:supports</a>
    /// </summary>
    let supports = _prefixId.prefix "supports"
    /// <summary>
    ///   <para>obo:IAO_0000112 : Used for a single narrative summary of teaching, typically covering a wide range of courses including for credit and non-credit teaching over multiple semesters; the "teaches" property links a person directly with an instance of a Semester Class, typically from an institutional database of record; then use Teacher Role for information about a person's role in non-credit teaching or their specific contribution to individual courses^^xsd:string</para>
    ///   <para>rdfs:label : teaching overview^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#teachingOverview">vivo:teachingOverview</a>
    /// </summary>
    let teachingOverview = _prefixId.prefix "teachingOverview"
    /// <summary>
    ///   <para>rdfs:label : term label^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#termLabel">vivo:termLabel</a>
    /// </summary>
    let termLabel = _prefixId.prefix "termLabel"
    /// <summary>
    ///   <para>rdfs:label : term type^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#termType">vivo:termType</a>
    /// </summary>
    let termType = _prefixId.prefix "termType"
    /// <summary>
    ///   <para>rdfs:label : total award amount^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#totalAwardAmount">vivo:totalAwardAmount</a>
    /// </summary>
    let totalAwardAmount = _prefixId.prefix "totalAwardAmount"
    /// <summary>
    ///   <para>rdfs:label : translator of^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#translatorOf">vivo:translatorOf</a>
    /// </summary>
    let translatorOf = _prefixId.prefix "translatorOf"
    /// <summary>
    ///   <para>rdfs:label : valid in^^xsd:string</para>
    ///   <a href="http://vivoweb.org/ontology/core#validIn">vivo:validIn</a>
    /// </summary>
    let validIn = _prefixId.prefix "validIn"
    let yearMonthDayPrecision = _prefixId.prefix "yearMonthDayPrecision"
    let yearMonthDayTimePrecision = _prefixId.prefix "yearMonthDayTimePrecision"
    let yearMonthPrecision = _prefixId.prefix "yearMonthPrecision"
    let yearPrecision = _prefixId.prefix "yearPrecision"
