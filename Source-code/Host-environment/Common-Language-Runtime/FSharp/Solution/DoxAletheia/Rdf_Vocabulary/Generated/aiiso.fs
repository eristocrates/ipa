namespace http.purl.org.vocab.aiiso.schema.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module aiiso =
    let _namespace_iri = Namespace_Iri aiiso |> NamespaceIRI
    /// <summary>
    ///   <para>aiiso:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/vocab/aiiso/schema#">http://purl.org/vocab/aiiso/schema#</seealso>
    let _prefix_iri = Prefixed_Name(aiiso, "") |> PrefixedName
    /// <summary>
    ///   <para>aiiso:Center</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Center is a group of people recognised by an organization as forming a cohesive group referred to by the organization as a center.</para>
    /// labels<para>Center</para></remarks>
    /// <seealso href="http://purl.org/vocab/aiiso/schema#Center">http://purl.org/vocab/aiiso/schema#Center</seealso>
    let Center = Prefixed_Name(aiiso, "Center") |> PrefixedName
    /// <summary>
    ///   <para>aiiso:College</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A College is a group of people recognised by an organization as forming a cohesive group referred to by the organization as a college.</para>
    /// labels<para>College</para></remarks>
    /// <seealso href="http://purl.org/vocab/aiiso/schema#College">http://purl.org/vocab/aiiso/schema#College</seealso>
    let College = Prefixed_Name(aiiso, "College") |> PrefixedName
    /// <summary>
    ///   <para>aiiso:KnowledgeGrouping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A KnowledgeGrouping represents a collection of resources, learning objectives, timetables, and other materials. The more specific subclasses of Subject, Programme, Course and Module are preferred.</para>
    /// labels<para>KnowledgeGrouping</para></remarks>
    /// <seealso href="http://purl.org/vocab/aiiso/schema#KnowledgeGrouping">http://purl.org/vocab/aiiso/schema#KnowledgeGrouping</seealso>
    let KnowledgeGrouping = Prefixed_Name(aiiso, "KnowledgeGrouping") |> PrefixedName
    /// <summary>
    ///   <para>aiiso:Department</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Department is a group of people recognised by an organization as forming a cohesive group referred to by the organization as a department.</para>
    /// labels<para>Department</para></remarks>
    /// <seealso href="http://purl.org/vocab/aiiso/schema#Department">http://purl.org/vocab/aiiso/schema#Department</seealso>
    let Department = Prefixed_Name(aiiso, "Department") |> PrefixedName
    /// <summary>
    ///   <para>aiiso:Faculty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Faculty is a group of people recognised by an organization as forming a cohesive group referred to by the organization as a faculty.</para>
    /// labels<para>Faculty</para></remarks>
    /// <seealso href="http://purl.org/vocab/aiiso/schema#Faculty">http://purl.org/vocab/aiiso/schema#Faculty</seealso>
    let Faculty = Prefixed_Name(aiiso, "Faculty") |> PrefixedName
    /// <summary>
    ///   <para>aiiso:Programme</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Programme is a KnowledgeGrouping that represents a cohesive collection of educational material referred to by the owning organization as a programme.</para>
    /// labels<para>Programme</para></remarks>
    /// <seealso href="http://purl.org/vocab/aiiso/schema#Programme">http://purl.org/vocab/aiiso/schema#Programme</seealso>
    let Programme = Prefixed_Name(aiiso, "Programme") |> PrefixedName
    /// <summary>
    ///   <para>aiiso:School</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A School is a group of people recognised by an organization as forming a cohesive group referred to by the organization as a school. This class refers schools within a higher education institution such as 'Harvard Law School' it does not refer to schools involved in earlier education.</para>
    /// labels<para>School</para></remarks>
    /// <seealso href="http://purl.org/vocab/aiiso/schema#School">http://purl.org/vocab/aiiso/schema#School</seealso>
    let School = Prefixed_Name(aiiso, "School") |> PrefixedName
    /// <summary>
    ///   <para>aiiso:code</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The code used by an Institution to refer to a KnowledgeGrouping or Organization.</para>
    /// labels<para>code</para></remarks>
    /// <seealso href="http://purl.org/vocab/aiiso/schema#code">http://purl.org/vocab/aiiso/schema#code</seealso>
    let code = Prefixed_Name(aiiso, "code") |> PrefixedName
    /// <summary>
    ///   <para>aiiso:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A Description of the KnowledgeGrouping or Organization.</para>
    /// labels<para>description</para></remarks>
    /// <seealso href="http://purl.org/vocab/aiiso/schema#description">http://purl.org/vocab/aiiso/schema#description</seealso>
    let description = Prefixed_Name(aiiso, "description") |> PrefixedName
    /// <summary>
    ///   <para>aiiso:knowledgeGrouping</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A KnowledgeGrouping may be contained by another KnowledgeGrouping or an organizationalUnit using knowledgeGrouping.</para>
    /// labels<para>knowledgeGrouping</para></remarks>
    /// <seealso href="http://purl.org/vocab/aiiso/schema#knowledgeGrouping">http://purl.org/vocab/aiiso/schema#knowledgeGrouping</seealso>
    let knowledgeGrouping = Prefixed_Name(aiiso, "knowledgeGrouping") |> PrefixedName
    /// <summary>
    ///   <para>aiiso:Course</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Course is a KnowledgeGrouping that represents a cohesive collection of educational material referred to by the owning organization as a course.</para>
    /// labels<para>Course</para></remarks>
    /// <seealso href="http://purl.org/vocab/aiiso/schema#Course">http://purl.org/vocab/aiiso/schema#Course</seealso>
    let Course = Prefixed_Name(aiiso, "Course") |> PrefixedName
    /// <summary>
    ///   <para>aiiso:Division</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Division is a group of people recognised by an organization as forming a cohesive group referred to by the organization as a division.</para>
    /// labels<para>Division</para></remarks>
    /// <seealso href="http://purl.org/vocab/aiiso/schema#Division">http://purl.org/vocab/aiiso/schema#Division</seealso>
    let Division = Prefixed_Name(aiiso, "Division") |> PrefixedName
    /// <summary>
    ///   <para>aiiso:Institute</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An Institute is a group of people recognised by an organization as forming a cohesive group referred to by the organization as an institute.</para>
    /// labels<para>Institute</para></remarks>
    /// <seealso href="http://purl.org/vocab/aiiso/schema#Institute">http://purl.org/vocab/aiiso/schema#Institute</seealso>
    let Institute = Prefixed_Name(aiiso, "Institute") |> PrefixedName
    /// <summary>
    ///   <para>aiiso:Institution</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An Institution is the upper most level of an academic institution.</para>
    /// labels<para>Institution</para></remarks>
    /// <seealso href="http://purl.org/vocab/aiiso/schema#Institution">http://purl.org/vocab/aiiso/schema#Institution</seealso>
    let Institution = Prefixed_Name(aiiso, "Institution") |> PrefixedName
    /// <summary>
    ///   <para>aiiso:Module</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Module is a KnowledgeGrouping that represents a cohesive collection of educational material referred to by the owning organization as a module.</para>
    /// labels<para>Module</para></remarks>
    /// <seealso href="http://purl.org/vocab/aiiso/schema#Module">http://purl.org/vocab/aiiso/schema#Module</seealso>
    let Module = Prefixed_Name(aiiso, "Module") |> PrefixedName
    /// <summary>
    ///   <para>aiiso:ResearchGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Research Group is a group of people recognised by an organization as forming a cohesive group referred to by the organization as a research group.</para>
    /// labels<para>Research Group</para></remarks>
    /// <seealso href="http://purl.org/vocab/aiiso/schema#ResearchGroup">http://purl.org/vocab/aiiso/schema#ResearchGroup</seealso>
    let ResearchGroup = Prefixed_Name(aiiso, "ResearchGroup") |> PrefixedName
    /// <summary>
    ///   <para>aiiso:Subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Subject is a KnowledgeGrouping that represents a cohesive collection of educational material referred to by the owning organization as a subject.</para>
    /// labels<para>Subject</para></remarks>
    /// <seealso href="http://purl.org/vocab/aiiso/schema#Subject">http://purl.org/vocab/aiiso/schema#Subject</seealso>
    let Subject = Prefixed_Name(aiiso, "Subject") |> PrefixedName
    /// <summary>
    ///   <para>aiiso:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Deprecated in favour of foaf:name. The name given to a KnowledgeGrouping or Organization.</para>
    /// labels<para>name</para></remarks>
    /// <seealso href="http://purl.org/vocab/aiiso/schema#name">http://purl.org/vocab/aiiso/schema#name</seealso>
    let name = Prefixed_Name(aiiso, "name") |> PrefixedName
    /// <summary>
    ///   <para>aiiso:organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A foaf Organization may contain other subsidiary Organizations using organization.</para>
    /// labels<para>organization</para></remarks>
    /// <seealso href="http://purl.org/vocab/aiiso/schema#organization">http://purl.org/vocab/aiiso/schema#organization</seealso>
    let organization = Prefixed_Name(aiiso, "organization") |> PrefixedName
    /// <summary>
    ///   <para>aiiso:organizationalUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>rdfs:Class</para>
    ///   <para>organizationalUnit is now deprecated, it was used to describe a group of people that form a part of an organizations institutional hierarchy. More specific classes of Institution, Department, Faculty, School, College, Center, Division and Institute exist were previously subclassed from here. They now subclass foaf:Organization.</para>
    ///   <para>Deprecated due to poor naming, you should use organization and part_of instead. An organizationalUnit may contain other organizationalUnits using organizationalUnit.</para>
    /// labels<para>organizational Unit</para><para>organizationalUnit</para></remarks>
    /// <seealso href="http://purl.org/vocab/aiiso/schema#organizationalUnit">http://purl.org/vocab/aiiso/schema#organizationalUnit</seealso>
    let organizationalUnit = Prefixed_Name(aiiso, "organizationalUnit") |> PrefixedName
    /// <summary>
    ///   <para>aiiso:part_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A foaf Organization may refer to its parent Organizations using part_of.</para>
    /// labels<para>part of</para></remarks>
    /// <seealso href="http://purl.org/vocab/aiiso/schema#part_of">http://purl.org/vocab/aiiso/schema#part_of</seealso>
    let part_of = Prefixed_Name(aiiso, "part_of") |> PrefixedName
    /// <summary>
    ///   <para>aiiso:responsibilityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>responsibility of</para></remarks>
    /// <seealso href="http://purl.org/vocab/aiiso/schema#responsibilityOf">http://purl.org/vocab/aiiso/schema#responsibilityOf</seealso>
    let responsibilityOf = Prefixed_Name(aiiso, "responsibilityOf") |> PrefixedName
    /// <summary>
    ///   <para>aiiso:responsibleFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>responsible for</para></remarks>
    /// <seealso href="http://purl.org/vocab/aiiso/schema#responsibleFor">http://purl.org/vocab/aiiso/schema#responsibleFor</seealso>
    let responsibleFor = Prefixed_Name(aiiso, "responsibleFor") |> PrefixedName
    /// <summary>
    ///   <para>aiiso:teaches</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An organization may specify the Knowledge Groupings that it teaches using this property.</para>
    /// labels<para>teaches</para></remarks>
    /// <seealso href="http://purl.org/vocab/aiiso/schema#teaches">http://purl.org/vocab/aiiso/schema#teaches</seealso>
    let teaches = Prefixed_Name(aiiso, "teaches") |> PrefixedName
