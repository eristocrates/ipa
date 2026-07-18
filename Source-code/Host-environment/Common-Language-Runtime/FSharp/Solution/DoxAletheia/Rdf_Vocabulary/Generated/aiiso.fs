namespace http.purl.org.vocab.aiiso.schema.hash

open DoxAletheia.Rdf_Vocabulary

module aiiso =
    let _namespace_name = "http://purl.org/vocab/aiiso/schema#"
    /// <summary>
    /// A Center is a group of people recognised by an organization as forming a cohesive group referred to by the organization as a center.
    /// <see href="http://purl.org/vocab/aiiso/schema#Center"></see></summary>
    let Center = Namespaced_IRI.parse _namespace_name "Center" |> NamespacedName
    /// <summary>
    /// A College is a group of people recognised by an organization as forming a cohesive group referred to by the organization as a college.
    /// <see href="http://purl.org/vocab/aiiso/schema#College"></see></summary>
    let College = Namespaced_IRI.parse _namespace_name "College" |> NamespacedName
    /// <summary>
    /// A Course is a KnowledgeGrouping that represents a cohesive collection of educational material referred to by the owning organization as a course.
    /// <see href="http://purl.org/vocab/aiiso/schema#Course"></see></summary>
    let Course = Namespaced_IRI.parse _namespace_name "Course" |> NamespacedName

    /// <summary>
    /// A KnowledgeGrouping represents a collection of resources, learning objectives, timetables, and other materials. The more specific subclasses of Subject, Programme, Course and Module are preferred.
    /// <see href="http://purl.org/vocab/aiiso/schema#KnowledgeGrouping"></see></summary>
    let KnowledgeGrouping =
        Namespaced_IRI.parse _namespace_name "KnowledgeGrouping" |> NamespacedName

    /// <summary>
    /// A Department is a group of people recognised by an organization as forming a cohesive group referred to by the organization as a department.
    /// <see href="http://purl.org/vocab/aiiso/schema#Department"></see></summary>
    let Department = Namespaced_IRI.parse _namespace_name "Department" |> NamespacedName
    /// <summary>
    /// A Division is a group of people recognised by an organization as forming a cohesive group referred to by the organization as a division.
    /// <see href="http://purl.org/vocab/aiiso/schema#Division"></see></summary>
    let Division = Namespaced_IRI.parse _namespace_name "Division" |> NamespacedName
    /// <summary>
    /// A Faculty is a group of people recognised by an organization as forming a cohesive group referred to by the organization as a faculty.
    /// <see href="http://purl.org/vocab/aiiso/schema#Faculty"></see></summary>
    let Faculty = Namespaced_IRI.parse _namespace_name "Faculty" |> NamespacedName
    /// <summary>
    /// An Institute is a group of people recognised by an organization as forming a cohesive group referred to by the organization as an institute.
    /// <see href="http://purl.org/vocab/aiiso/schema#Institute"></see></summary>
    let Institute = Namespaced_IRI.parse _namespace_name "Institute" |> NamespacedName

    /// <summary>
    /// An Institution is the upper most level of an academic institution.
    /// <see href="http://purl.org/vocab/aiiso/schema#Institution"></see></summary>
    let Institution =
        Namespaced_IRI.parse _namespace_name "Institution" |> NamespacedName

    /// <summary>
    /// A Module is a KnowledgeGrouping that represents a cohesive collection of educational material referred to by the owning organization as a module.
    /// <see href="http://purl.org/vocab/aiiso/schema#Module"></see></summary>
    let Module = Namespaced_IRI.parse _namespace_name "Module" |> NamespacedName
    /// <summary>
    /// A Programme is a KnowledgeGrouping that represents a cohesive collection of educational material referred to by the owning organization as a programme.
    /// <see href="http://purl.org/vocab/aiiso/schema#Programme"></see></summary>
    let Programme = Namespaced_IRI.parse _namespace_name "Programme" |> NamespacedName

    /// <summary>
    /// A Research Group is a group of people recognised by an organization as forming a cohesive group referred to by the organization as a research group.
    /// <see href="http://purl.org/vocab/aiiso/schema#ResearchGroup"></see></summary>
    let ResearchGroup =
        Namespaced_IRI.parse _namespace_name "ResearchGroup" |> NamespacedName

    /// <summary>
    /// A School is a group of people recognised by an organization as forming a cohesive group referred to by the organization as a school. This class refers schools within a higher education institution such as 'Harvard Law School' it does not refer to schools involved in earlier education.
    /// <see href="http://purl.org/vocab/aiiso/schema#School"></see></summary>
    let School = Namespaced_IRI.parse _namespace_name "School" |> NamespacedName
    /// <summary>
    /// A Subject is a KnowledgeGrouping that represents a cohesive collection of educational material referred to by the owning organization as a subject.
    /// <see href="http://purl.org/vocab/aiiso/schema#Subject"></see></summary>
    let Subject = Namespaced_IRI.parse _namespace_name "Subject" |> NamespacedName
    /// <summary>
    /// The code used by an Institution to refer to a KnowledgeGrouping or Organization.
    /// <see href="http://purl.org/vocab/aiiso/schema#code"></see></summary>
    let code = Namespaced_IRI.parse _namespace_name "code" |> NamespacedName

    /// <summary>
    /// A Description of the KnowledgeGrouping or Organization.
    /// <see href="http://purl.org/vocab/aiiso/schema#description"></see></summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    /// A KnowledgeGrouping may be contained by another KnowledgeGrouping or an organizationalUnit using knowledgeGrouping.
    /// <see href="http://purl.org/vocab/aiiso/schema#knowledgeGrouping"></see></summary>
    let knowledgeGrouping =
        Namespaced_IRI.parse _namespace_name "knowledgeGrouping" |> NamespacedName

    /// <summary>
    /// Deprecated in favour of foaf:name. The name given to a KnowledgeGrouping or Organization.
    /// <see href="http://purl.org/vocab/aiiso/schema#name"></see></summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName

    /// <summary>
    /// A foaf Organization may contain other subsidiary Organizations using organization.
    /// <see href="http://purl.org/vocab/aiiso/schema#organization"></see></summary>
    let organization =
        Namespaced_IRI.parse _namespace_name "organization" |> NamespacedName

    /// <summary>
    /// A foaf Organization may refer to its parent Organizations using part_of.
    /// <see href="http://purl.org/vocab/aiiso/schema#part_of"></see></summary>
    let part_of = Namespaced_IRI.parse _namespace_name "part_of" |> NamespacedName

    /// <summary>
    /// Deprecated due to poor naming, you should use organization and part_of instead. An organizationalUnit may contain other organizationalUnits using organizationalUnit.
    /// organizationalUnit is now deprecated, it was used to describe a group of people that form a part of an organizations institutional hierarchy. More specific classes of Institution, Department, Faculty, School, College, Center, Division and Institute exist were previously subclassed from here. They now subclass foaf:Organization.
    /// <see href="http://purl.org/vocab/aiiso/schema#organizationalUnit"></see></summary>
    let organizationalUnit =
        Namespaced_IRI.parse _namespace_name "organizationalUnit" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/aiiso/schema#responsibilityOf"></see>
    /// </summary>
    let responsibilityOf =
        Namespaced_IRI.parse _namespace_name "responsibilityOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/aiiso/schema#responsibleFor"></see>
    /// </summary>
    let responsibleFor =
        Namespaced_IRI.parse _namespace_name "responsibleFor" |> NamespacedName

    /// <summary>
    /// An organization may specify the Knowledge Groupings that it teaches using this property.
    /// <see href="http://purl.org/vocab/aiiso/schema#teaches"></see></summary>
    let teaches = Namespaced_IRI.parse _namespace_name "teaches" |> NamespacedName
