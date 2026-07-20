namespace http.purl.org.vocab.aiiso.schema.hash

open DoxAletheia

module aiiso =
    let _namespace_name = "http://purl.org/vocab/aiiso/schema#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A Center is a group of people recognised by an organization as forming a cohesive group referred to by the organization as a center.
    /// <see href="http://purl.org/vocab/aiiso/schema#Center"></see></summary>
    let Center = _prefix "Center"
    /// <summary>
    /// A College is a group of people recognised by an organization as forming a cohesive group referred to by the organization as a college.
    /// <see href="http://purl.org/vocab/aiiso/schema#College"></see></summary>
    let College = _prefix "College"
    /// <summary>
    /// A Course is a KnowledgeGrouping that represents a cohesive collection of educational material referred to by the owning organization as a course.
    /// <see href="http://purl.org/vocab/aiiso/schema#Course"></see></summary>
    let Course = _prefix "Course"
    /// <summary>
    /// A KnowledgeGrouping represents a collection of resources, learning objectives, timetables, and other materials. The more specific subclasses of Subject, Programme, Course and Module are preferred.
    /// <see href="http://purl.org/vocab/aiiso/schema#KnowledgeGrouping"></see></summary>
    let KnowledgeGrouping = _prefix "KnowledgeGrouping"
    /// <summary>
    /// A Department is a group of people recognised by an organization as forming a cohesive group referred to by the organization as a department.
    /// <see href="http://purl.org/vocab/aiiso/schema#Department"></see></summary>
    let Department = _prefix "Department"
    /// <summary>
    /// A Division is a group of people recognised by an organization as forming a cohesive group referred to by the organization as a division.
    /// <see href="http://purl.org/vocab/aiiso/schema#Division"></see></summary>
    let Division = _prefix "Division"
    /// <summary>
    /// A Faculty is a group of people recognised by an organization as forming a cohesive group referred to by the organization as a faculty.
    /// <see href="http://purl.org/vocab/aiiso/schema#Faculty"></see></summary>
    let Faculty = _prefix "Faculty"
    /// <summary>
    /// An Institute is a group of people recognised by an organization as forming a cohesive group referred to by the organization as an institute.
    /// <see href="http://purl.org/vocab/aiiso/schema#Institute"></see></summary>
    let Institute = _prefix "Institute"
    /// <summary>
    /// An Institution is the upper most level of an academic institution.
    /// <see href="http://purl.org/vocab/aiiso/schema#Institution"></see></summary>
    let Institution = _prefix "Institution"
    /// <summary>
    /// A Module is a KnowledgeGrouping that represents a cohesive collection of educational material referred to by the owning organization as a module.
    /// <see href="http://purl.org/vocab/aiiso/schema#Module"></see></summary>
    let Module = _prefix "Module"
    /// <summary>
    /// A Programme is a KnowledgeGrouping that represents a cohesive collection of educational material referred to by the owning organization as a programme.
    /// <see href="http://purl.org/vocab/aiiso/schema#Programme"></see></summary>
    let Programme = _prefix "Programme"
    /// <summary>
    /// A Research Group is a group of people recognised by an organization as forming a cohesive group referred to by the organization as a research group.
    /// <see href="http://purl.org/vocab/aiiso/schema#ResearchGroup"></see></summary>
    let ResearchGroup = _prefix "ResearchGroup"
    /// <summary>
    /// A School is a group of people recognised by an organization as forming a cohesive group referred to by the organization as a school. This class refers schools within a higher education institution such as 'Harvard Law School' it does not refer to schools involved in earlier education.
    /// <see href="http://purl.org/vocab/aiiso/schema#School"></see></summary>
    let School = _prefix "School"
    /// <summary>
    /// A Subject is a KnowledgeGrouping that represents a cohesive collection of educational material referred to by the owning organization as a subject.
    /// <see href="http://purl.org/vocab/aiiso/schema#Subject"></see></summary>
    let Subject = _prefix "Subject"
    /// <summary>
    /// The code used by an Institution to refer to a KnowledgeGrouping or Organization.
    /// <see href="http://purl.org/vocab/aiiso/schema#code"></see></summary>
    let code = _prefix "code"
    /// <summary>
    /// A Description of the KnowledgeGrouping or Organization.
    /// <see href="http://purl.org/vocab/aiiso/schema#description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// A KnowledgeGrouping may be contained by another KnowledgeGrouping or an organizationalUnit using knowledgeGrouping.
    /// <see href="http://purl.org/vocab/aiiso/schema#knowledgeGrouping"></see></summary>
    let knowledgeGrouping = _prefix "knowledgeGrouping"
    /// <summary>
    /// Deprecated in favour of foaf:name. The name given to a KnowledgeGrouping or Organization.
    /// <see href="http://purl.org/vocab/aiiso/schema#name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    /// A foaf Organization may contain other subsidiary Organizations using organization.
    /// <see href="http://purl.org/vocab/aiiso/schema#organization"></see></summary>
    let organization = _prefix "organization"
    /// <summary>
    /// A foaf Organization may refer to its parent Organizations using part_of.
    /// <see href="http://purl.org/vocab/aiiso/schema#part_of"></see></summary>
    let part_of = _prefix "part_of"
    /// <summary>
    /// Deprecated due to poor naming, you should use organization and part_of instead. An organizationalUnit may contain other organizationalUnits using organizationalUnit.
    /// organizationalUnit is now deprecated, it was used to describe a group of people that form a part of an organizations institutional hierarchy. More specific classes of Institution, Department, Faculty, School, College, Center, Division and Institute exist were previously subclassed from here. They now subclass foaf:Organization.
    /// <see href="http://purl.org/vocab/aiiso/schema#organizationalUnit"></see></summary>
    let organizationalUnit = _prefix "organizationalUnit"
    /// <summary>
    ///   <see href="http://purl.org/vocab/aiiso/schema#responsibilityOf"></see>
    /// </summary>
    let responsibilityOf = _prefix "responsibilityOf"
    /// <summary>
    ///   <see href="http://purl.org/vocab/aiiso/schema#responsibleFor"></see>
    /// </summary>
    let responsibleFor = _prefix "responsibleFor"
    /// <summary>
    /// An organization may specify the Knowledge Groupings that it teaches using this property.
    /// <see href="http://purl.org/vocab/aiiso/schema#teaches"></see></summary>
    let teaches = _prefix "teaches"
