#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module aiiso =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/vocab/aiiso/schema#" "aiiso"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>dcterms:issued : 2008-05-14^^xsd:string</para>
    ///   <para>rdfs:label : Center</para>
    ///   <para>rdfs:comment : A Center is a group of people recognised by an organization as forming a cohesive group referred to by the organization as a center.^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/aiiso/schema#Center">aiiso:Center</a>
    /// </summary>
    let Center = _prefixId.prefix "Center"
    /// <summary>
    ///   <para>dcterms:issued : 2008-05-14^^xsd:string</para>
    ///   <para>rdfs:label : College</para>
    ///   <para>rdfs:comment : A College is a group of people recognised by an organization as forming a cohesive group referred to by the organization as a college.^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/aiiso/schema#College">aiiso:College</a>
    /// </summary>
    let College = _prefixId.prefix "College"
    /// <summary>
    ///   <para>dcterms:issued : 2008-05-14^^xsd:string</para>
    ///   <para>rdfs:label : Course</para>
    ///   <para>rdfs:comment : A Course is a KnowledgeGrouping that represents a cohesive collection of educational material referred to by the owning organization as a course.^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/aiiso/schema#Course">aiiso:Course</a>
    /// </summary>
    let Course = _prefixId.prefix "Course"
    /// <summary>
    ///   <para>dcterms:issued : 2008-05-14^^xsd:string</para>
    ///   <para>rdfs:label : Department</para>
    ///   <para>rdfs:comment : A Department is a group of people recognised by an organization as forming a cohesive group referred to by the organization as a department.^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/aiiso/schema#Department">aiiso:Department</a>
    /// </summary>
    let Department = _prefixId.prefix "Department"
    /// <summary>
    ///   <para>dcterms:issued : 2008-05-14^^xsd:string</para>
    ///   <para>rdfs:label : Division</para>
    ///   <para>rdfs:comment : A Division is a group of people recognised by an organization as forming a cohesive group referred to by the organization as a division.^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/aiiso/schema#Division">aiiso:Division</a>
    /// </summary>
    let Division = _prefixId.prefix "Division"
    /// <summary>
    ///   <para>dcterms:issued : 2008-05-14^^xsd:string</para>
    ///   <para>rdfs:label : Faculty</para>
    ///   <para>rdfs:comment : A Faculty is a group of people recognised by an organization as forming a cohesive group referred to by the organization as a faculty.^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/aiiso/schema#Faculty">aiiso:Faculty</a>
    /// </summary>
    let Faculty = _prefixId.prefix "Faculty"
    /// <summary>
    ///   <para>dcterms:issued : 2008-05-14^^xsd:string</para>
    ///   <para>rdfs:label : Institute</para>
    ///   <para>rdfs:comment : An Institute is a group of people recognised by an organization as forming a cohesive group referred to by the organization as an institute.^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/aiiso/schema#Institute">aiiso:Institute</a>
    /// </summary>
    let Institute = _prefixId.prefix "Institute"
    /// <summary>
    ///   <para>dcterms:issued : 2008-05-14^^xsd:string</para>
    ///   <para>rdfs:label : Institution</para>
    ///   <para>rdfs:comment : An Institution is the upper most level of an academic institution.^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/aiiso/schema#Institution">aiiso:Institution</a>
    /// </summary>
    let Institution = _prefixId.prefix "Institution"
    /// <summary>
    ///   <para>dcterms:issued : 2008-05-14^^xsd:string</para>
    ///   <para>rdfs:label : KnowledgeGrouping</para>
    ///   <para>rdfs:comment : A KnowledgeGrouping represents a collection of resources, learning objectives, timetables, and other materials. The more specific subclasses of Subject, Programme, Course and Module are preferred.^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/aiiso/schema#KnowledgeGrouping">aiiso:KnowledgeGrouping</a>
    /// </summary>
    let KnowledgeGrouping = _prefixId.prefix "KnowledgeGrouping"
    /// <summary>
    ///   <para>dcterms:issued : 2008-05-14^^xsd:string</para>
    ///   <para>rdfs:label : Module</para>
    ///   <para>rdfs:comment : A Module is a KnowledgeGrouping that represents a cohesive collection of educational material referred to by the owning organization as a module.^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/aiiso/schema#Module">aiiso:Module</a>
    /// </summary>
    let Module = _prefixId.prefix "Module"
    /// <summary>
    ///   <para>dcterms:issued : 2008-05-14^^xsd:string</para>
    ///   <para>rdfs:label : Programme</para>
    ///   <para>rdfs:comment : A Programme is a KnowledgeGrouping that represents a cohesive collection of educational material referred to by the owning organization as a programme.^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/aiiso/schema#Programme">aiiso:Programme</a>
    /// </summary>
    let Programme = _prefixId.prefix "Programme"
    /// <summary>
    ///   <para>dcterms:issued : 2008-05-14^^xsd:string</para>
    ///   <para>rdfs:label : Research Group</para>
    ///   <para>rdfs:comment : A Research Group is a group of people recognised by an organization as forming a cohesive group referred to by the organization as a research group.^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/aiiso/schema#ResearchGroup">aiiso:ResearchGroup</a>
    /// </summary>
    let ResearchGroup = _prefixId.prefix "ResearchGroup"
    /// <summary>
    ///   <para>dcterms:issued : 2008-05-14^^xsd:string</para>
    ///   <para>rdfs:label : School</para>
    ///   <para>rdfs:comment : A School is a group of people recognised by an organization as forming a cohesive group referred to by the organization as a school. This class refers schools within a higher education institution such as 'Harvard Law School' it does not refer to schools involved in earlier education.^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/aiiso/schema#School">aiiso:School</a>
    /// </summary>
    let School = _prefixId.prefix "School"
    /// <summary>
    ///   <para>dcterms:issued : 2008-05-14^^xsd:string</para>
    ///   <para>rdfs:label : Subject</para>
    ///   <para>rdfs:comment : A Subject is a KnowledgeGrouping that represents a cohesive collection of educational material referred to by the owning organization as a subject.^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/aiiso/schema#Subject">aiiso:Subject</a>
    /// </summary>
    let Subject = _prefixId.prefix "Subject"
    /// <summary>
    ///   <para>dcterms:issued : 2008-05-14^^xsd:string</para>
    ///   <para>rdfs:label : code</para>
    ///   <para>rdfs:comment : The code used by an Institution to refer to a KnowledgeGrouping or Organization.^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/aiiso/schema#code">aiiso:code</a>
    /// </summary>
    let code = _prefixId.prefix "code"
    /// <summary>
    ///   <para>dcterms:issued : 2008-05-14^^xsd:string</para>
    ///   <para>rdfs:label : description</para>
    ///   <para>rdfs:comment : A Description of the KnowledgeGrouping or Organization.^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/aiiso/schema#description">aiiso:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>vs:term_status : Deprecated^^xsd:string</para>
    ///   <para>dcterms:issued : 2008-05-14^^xsd:string</para>
    ///   <para>rdfs:label : knowledgeGrouping</para>
    ///   <para>rdfs:comment : A KnowledgeGrouping may be contained by another KnowledgeGrouping or an organizationalUnit using knowledgeGrouping.^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/aiiso/schema#knowledgeGrouping">aiiso:knowledgeGrouping</a>
    /// </summary>
    let knowledgeGrouping = _prefixId.prefix "knowledgeGrouping"
    /// <summary>
    ///   <para>rdfs:label : name</para>
    ///   <para>dcterms:issued : 2008-05-14^^xsd:string</para>
    ///   <para>rdfs:comment : Deprecated in favour of foaf:name. The name given to a KnowledgeGrouping or Organization.^^xsd:string</para>
    ///   <para>vs:term_status : Deprecated^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/aiiso/schema#name">aiiso:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>dcterms:issued : 2008-09-25^^xsd:string</para>
    ///   <para>rdfs:label : organization</para>
    ///   <para>rdfs:comment : A foaf Organization may contain other subsidiary Organizations using organization.^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/aiiso/schema#organization">aiiso:organization</a>
    /// </summary>
    let organization = _prefixId.prefix "organization"
    /// <summary>
    ///   <para>rdfs:comment : Deprecated due to poor naming, you should use organization and part_of instead. An organizationalUnit may contain other organizationalUnits using organizationalUnit.^^xsd:stringrdfs:comment : organizationalUnit is now deprecated, it was used to describe a group of people that form a part of an organizations institutional hierarchy. More specific classes of Institution, Department, Faculty, School, College, Center, Division and Institute exist were previously subclassed from here. They now subclass foaf:Organization.^^xsd:string</para>
    ///   <para>rdfs:label : organizational Unitrdfs:label : organizationalUnit</para>
    ///   <para>vs:term_status : Deprecated^^xsd:string</para>
    ///   <para>dcterms:issued : 2008-05-14^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/aiiso/schema#organizationalUnit">aiiso:organizationalUnit</a>
    /// </summary>
    let organizationalUnit = _prefixId.prefix "organizationalUnit"
    /// <summary>
    ///   <para>dcterms:issued : 2008-09-25^^xsd:string</para>
    ///   <para>rdfs:label : part of</para>
    ///   <para>rdfs:comment : A foaf Organization may refer to its parent Organizations using part_of.^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/aiiso/schema#part_of">aiiso:part_of</a>
    /// </summary>
    let part_of = _prefixId.prefix "part_of"
    /// <summary>
    ///   <para>dcterms:issued : 2008-05-20^^xsd:string</para>
    ///   <para>rdfs:label : responsibility of</para>
    ///   <a href="http://purl.org/vocab/aiiso/schema#responsibilityOf">aiiso:responsibilityOf</a>
    /// </summary>
    let responsibilityOf = _prefixId.prefix "responsibilityOf"
    /// <summary>
    ///   <para>dcterms:issued : 2008-09-25^^xsd:string</para>
    ///   <para>rdfs:label : responsible for</para>
    ///   <a href="http://purl.org/vocab/aiiso/schema#responsibleFor">aiiso:responsibleFor</a>
    /// </summary>
    let responsibleFor = _prefixId.prefix "responsibleFor"
    /// <summary>
    ///   <para>dcterms:issued : 2008-09-25^^xsd:string</para>
    ///   <para>rdfs:label : teaches</para>
    ///   <para>rdfs:comment : An organization may specify the Knowledge Groupings that it teaches using this property.^^xsd:string</para>
    ///   <a href="http://purl.org/vocab/aiiso/schema#teaches">aiiso:teaches</a>
    /// </summary>
    let teaches = _prefixId.prefix "teaches"
