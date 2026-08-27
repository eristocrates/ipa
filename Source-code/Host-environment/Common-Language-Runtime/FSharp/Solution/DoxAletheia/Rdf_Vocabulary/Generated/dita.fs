namespace http.purl.org.dita.ns.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dita =
    let _namespace_iri = Namespace_Iri dita |> NamespaceIRI
    /// <summary>
    ///   <para>dita:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dita/ns#">http://purl.org/dita/ns#</seealso>
    let _prefix_iri = Prefixed_Name(dita, "") |> PrefixedName
    /// <summary>
    ///   <para>dita:Audience</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The audience metadata element indicates, through the value of its type attribute, the intended audience for a topic."</para>
    /// labels<para>"Audience"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#Audience">http://purl.org/dita/ns#Audience</seealso>
    let Audience = Prefixed_Name(dita, "Audience") |> PrefixedName
    /// <summary>
    ///   <para>dita:Bookmap</para>
    /// </summary>
    /// <remarks>
    ///   <para>"The DITA bookmap specialization represents the key markup requirements for managing DITA content through book-oriented publication processes, including book metadata and book structures for organizing content."</para>
    /// labels<para>"Bookmap"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#Bookmap">http://purl.org/dita/ns#Bookmap</seealso>
    let Bookmap = Prefixed_Name(dita, "Bookmap") |> PrefixedName
    /// <summary>
    ///   <para>dita:Coderef</para>
    /// </summary>
    /// <remarks>
    ///   <para>"The coderef element references an external file that contains literal code."</para>
    /// labels<para>"Coderef"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#Coderef">http://purl.org/dita/ns#Coderef</seealso>
    let Coderef = Prefixed_Name(dita, "Coderef") |> PrefixedName
    /// <summary>
    ///   <para>dita:Concept</para>
    /// </summary>
    /// <remarks>
    ///   <para>"The DITA concept document type uses the concept information type."</para>
    /// labels<para>"Concept"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#Concept">http://purl.org/dita/ns#Concept</seealso>
    let Concept = Prefixed_Name(dita, "Concept") |> PrefixedName
    /// <summary>
    ///   <para>dita:Conkeyref</para>
    /// </summary>
    /// <remarks>
    ///   <para>"The conkeyref attribute provides an indirect content reference to topic elements, map elements, or elements within maps or topics."</para>
    /// labels<para>"Conkeyref"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#Conkeyref">http://purl.org/dita/ns#Conkeyref</seealso>
    let Conkeyref = Prefixed_Name(dita, "Conkeyref") |> PrefixedName
    /// <summary>
    ///   <para>dita:Conref</para>
    /// </summary>
    /// <remarks>
    ///   <para>"This attribute is used to reference content that can be reused."</para>
    /// labels<para>"Conref"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#Conref">http://purl.org/dita/ns#Conref</seealso>
    let Conref = Prefixed_Name(dita, "Conref") |> PrefixedName
    /// <summary>
    ///   <para>dita:Doctype</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"All the DITA document types."</para>
    /// labels<para>"Doctype"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#Doctype">http://purl.org/dita/ns#Doctype</seealso>
    let Doctype = Prefixed_Name(dita, "Doctype") |> PrefixedName
    /// <summary>
    ///   <para>dita:Image</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Include artwork or images in a DITA topic by using the image element."</para>
    /// labels<para>"Image"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#Image">http://purl.org/dita/ns#Image</seealso>
    let Image = Prefixed_Name(dita, "Image") |> PrefixedName
    /// <summary>
    ///   <para>dita:Key</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The DITA key-reference mechanism provides a layer of abstraction so that the resources addressed by references can be defined globally at the DITA map level instead of locally in each topic."</para>
    /// labels<para>"Key"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#Key">http://purl.org/dita/ns#Key</seealso>
    let Key = Prefixed_Name(dita, "Key") |> PrefixedName
    /// <summary>
    ///   <para>dita:Keydef</para>
    /// </summary>
    /// <remarks>
    ///   <para>"The keydef element is a convenience element that is used to define keys without any of the other effects that occur when using a topicref element: no content is included in output, no title is included in the table of contents, and no linking or other relationships are defined."</para>
    /// labels<para>"Keydef"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#Keydef">http://purl.org/dita/ns#Keydef</seealso>
    let Keydef = Prefixed_Name(dita, "Keydef") |> PrefixedName
    /// <summary>
    ///   <para>dita:Keyref</para>
    /// </summary>
    /// <remarks>
    ///   <para>"The keyref attribute provides an indirect, late-bound reference to topics, to collections of topics (ditabase), to maps, to referenceable portions of maps, to non-DITA documents, to external URIs, or to XML content contained within a key definition topic reference."</para>
    /// labels<para>"Keyref"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#Keyref">http://purl.org/dita/ns#Keyref</seealso>
    let Keyref = Prefixed_Name(dita, "Keyref") |> PrefixedName
    /// <summary>
    ///   <para>dita:Keyword</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The keyword element identifies a keyword or token, such as a single value from an enumerated list, the name of a command or parameter, product name, or a lookup key for a message."</para>
    /// labels<para>"Keyword"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#Keyword">http://purl.org/dita/ns#Keyword</seealso>
    let Keyword = Prefixed_Name(dita, "Keyword") |> PrefixedName
    /// <summary>
    ///   <para>dita:LearningAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>"A Learning Assessment presents questions or interactions that measure progress, encourage recollection, and stimulate reinforcement of the learning content, and can be presented before the content as a pre-assessment or as a post-assessment test."</para>
    /// labels<para>"LearningAssessment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#LearningAssessment">http://purl.org/dita/ns#LearningAssessment</seealso>
    let LearningAssessment = Prefixed_Name(dita, "LearningAssessment") |> PrefixedName
    /// <summary>
    ///   <para>dita:LearningBase</para>
    /// </summary>
    /// <remarks>
    ///   <para>"The learningBase topic type is not used to deliver any actual learning content, but instead provides a set of common elements for use in the other more specific learning content types."</para>
    /// labels<para>"LearningBase"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#LearningBase">http://purl.org/dita/ns#LearningBase</seealso>
    let LearningBase = Prefixed_Name(dita, "LearningBase") |> PrefixedName
    /// <summary>
    ///   <para>dita:LearningContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>"A Learning Content topic provides the learning content itself, and enables direct use of content from DITA task, concept, and reference topics, as well as additional content of any topic type that supports specific objectives declared in the Learning Overview topic type."</para>
    /// labels<para>"LearningContent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#LearningContent">http://purl.org/dita/ns#LearningContent</seealso>
    let LearningContent = Prefixed_Name(dita, "LearningContent") |> PrefixedName

    /// <summary>
    ///   <para>dita:LearningContentComponentRef</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Use a learningContentComponentRef element to include a topic reference to a topic that acts as a subtopic of a learningContent topic."</para>
    /// labels<para>"LearningContentComponentRef"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#LearningContentComponentRef">http://purl.org/dita/ns#LearningContentComponentRef</seealso>
    let LearningContentComponentRef =
        Prefixed_Name(dita, "LearningContentComponentRef") |> PrefixedName

    /// <summary>
    ///   <para>dita:LearningContentRef</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Use a learningContentRef element to include a topic reference to a learning content topic as part of a DITA learningObject."</para>
    /// labels<para>"LearningContentRef"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#LearningContentRef">http://purl.org/dita/ns#LearningContentRef</seealso>
    let LearningContentRef = Prefixed_Name(dita, "LearningContentRef") |> PrefixedName
    /// <summary>
    ///   <para>dita:LearningObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>"learningObject organizes topic references to DITA learning topics as a learning object. "</para>
    /// labels<para>"LearningObject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#LearningObject">http://purl.org/dita/ns#LearningObject</seealso>
    let LearningObject = Prefixed_Name(dita, "LearningObject") |> PrefixedName
    /// <summary>
    ///   <para>dita:LearningOverview</para>
    /// </summary>
    /// <remarks>
    ///   <para>"A Learning Overview topic identifies the learning objectives, includes other information helpful to the learner, such as prerequisites, duration, intended audience, and can include information and strategies that seeks to gain attention and stimulate recall of prior learning."</para>
    /// labels<para>"LearningOverview"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#LearningOverview">http://purl.org/dita/ns#LearningOverview</seealso>
    let LearningOverview = Prefixed_Name(dita, "LearningOverview") |> PrefixedName
    /// <summary>
    ///   <para>dita:LearningOverviewRef</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Use a learningOverviewRef element to include a topic reference to a learning overview topic as part of a learningObject."</para>
    /// labels<para>"LearningOverviewRef"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#LearningOverviewRef">http://purl.org/dita/ns#LearningOverviewRef</seealso>
    let LearningOverviewRef = Prefixed_Name(dita, "LearningOverviewRef") |> PrefixedName
    /// <summary>
    ///   <para>dita:LearningPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>"A Learning Plan topic describes learning needs and goals, instructional design models, task analyses, learning taxonomies, and other information necessary to the lesson planning process."</para>
    /// labels<para>"LearningPlan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#LearningPlan">http://purl.org/dita/ns#LearningPlan</seealso>
    let LearningPlan = Prefixed_Name(dita, "LearningPlan") |> PrefixedName
    /// <summary>
    ///   <para>dita:LearningPlanRef</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Use a learningPlanRef element to include a topic reference to a learning plan topic as part of a learningObject."</para>
    /// labels<para>"LearningPlanRef"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#LearningPlanRef">http://purl.org/dita/ns#LearningPlanRef</seealso>
    let LearningPlanRef = Prefixed_Name(dita, "LearningPlanRef") |> PrefixedName

    /// <summary>
    ///   <para>dita:LearningPostAssessmentRef</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Use a learningPostAssessmentRef element to include a topic reference to a learning assessment topic as part of a DITA learningObject."</para>
    /// labels<para>"LearningPostAssessmentRef"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#LearningPostAssessmentRef">http://purl.org/dita/ns#LearningPostAssessmentRef</seealso>
    let LearningPostAssessmentRef =
        Prefixed_Name(dita, "LearningPostAssessmentRef") |> PrefixedName

    /// <summary>
    ///   <para>dita:LearningPreAssessmentRef</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Use a learningPreAssessmentRef element to include a topic reference to a learning assessment topic as part of a DITA learningObject."</para>
    /// labels<para>"LearningPreAssessmentRef"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#LearningPreAssessmentRef">http://purl.org/dita/ns#LearningPreAssessmentRef</seealso>
    let LearningPreAssessmentRef =
        Prefixed_Name(dita, "LearningPreAssessmentRef") |> PrefixedName

    /// <summary>
    ///   <para>dita:LearningSummary</para>
    /// </summary>
    /// <remarks>
    ///   <para>"A Learning Summary recaps and provides context for the achievement or accomplishment of learning objectives, provides guidance to reinforce learning and long-term memory, and may pose questions to enhance encoding and verification of the learning content."</para>
    /// labels<para>"LearningSummary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#LearningSummary">http://purl.org/dita/ns#LearningSummary</seealso>
    let LearningSummary = Prefixed_Name(dita, "LearningSummary") |> PrefixedName
    /// <summary>
    ///   <para>dita:LearningSummaryRef</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Use a &lt;learningSummaryRef&gt; to include topic reference to a learning summary topic in a DITA learning object."</para>
    /// labels<para>"LearningSummaryRef"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#LearningSummaryRef">http://purl.org/dita/ns#LearningSummaryRef</seealso>
    let LearningSummaryRef = Prefixed_Name(dita, "LearningSummaryRef") |> PrefixedName
    /// <summary>
    ///   <para>dita:Link</para>
    /// </summary>
    /// <remarks>
    ///   <para>"The link element defines a relationship to another topic. Links are typically sorted when displayed based on their attributes, which define the type or role of the link's target in relation to the current topic."</para>
    /// labels<para>"Link"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#Link">http://purl.org/dita/ns#Link</seealso>
    let Link = Prefixed_Name(dita, "Link") |> PrefixedName
    /// <summary>
    ///   <para>dita:Map</para>
    /// </summary>
    /// <remarks>
    ///   <para>"DITA maps are documents that organize topics and other resources into structured collections of information. DITA maps specify hierarchy and the relationships among the topics; they also provide the context in which keys are defined and resolved."</para>
    /// labels<para>"Map"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#Map">http://purl.org/dita/ns#Map</seealso>
    let Map = Prefixed_Name(dita, "Map") |> PrefixedName
    /// <summary>
    ///   <para>dita:Mapref</para>
    /// </summary>
    /// <remarks>
    ///   <para>"The mapref element is a convenience element that is equivalent to a topicref element with the format attribute set to 'ditamap'."</para>
    /// labels<para>"Mapref"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#Mapref">http://purl.org/dita/ns#Mapref</seealso>
    let Mapref = Prefixed_Name(dita, "Mapref") |> PrefixedName
    /// <summary>
    ///   <para>dita:Parmname</para>
    /// </summary>
    /// <remarks>
    ///   <para>"When referencing the name of an application programming interface parameter within the text flow of your topic, use the parameter name (&lt;parmname&gt;) element to mark up the parameter."</para>
    /// labels<para>"Parmname"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#Parmname">http://purl.org/dita/ns#Parmname</seealso>
    let Parmname = Prefixed_Name(dita, "Parmname") |> PrefixedName
    /// <summary>
    ///   <para>dita:Prodinfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The prodinfo metadata element contains information about the product or products that are the subject matter of the current topic."</para>
    /// labels<para>"Prodinfo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#Prodinfo">http://purl.org/dita/ns#Prodinfo</seealso>
    let Prodinfo = Prefixed_Name(dita, "Prodinfo") |> PrefixedName
    /// <summary>
    ///   <para>dita:Reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>"The DITA reference document type uses the reference information type."</para>
    /// labels<para>"Reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#Reference">http://purl.org/dita/ns#Reference</seealso>
    let Reference = Prefixed_Name(dita, "Reference") |> PrefixedName
    /// <summary>
    ///   <para>dita:ReferenceObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The DITA reference object is used to link, fetch or push content in relation with another file or object."</para>
    /// labels<para>"DITA base reference object"</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#ReferenceObject">http://purl.org/dita/ns#ReferenceObject</seealso>
    let ReferenceObject = Prefixed_Name(dita, "ReferenceObject") |> PrefixedName
    /// <summary>
    ///   <para>dita:Task</para>
    /// </summary>
    /// <remarks>
    ///   <para>"The strict task document type supports the development of instructions for the completion of a procedure."</para>
    /// labels<para>"Task"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#Task">http://purl.org/dita/ns#Task</seealso>
    let Task = Prefixed_Name(dita, "Task") |> PrefixedName
    /// <summary>
    ///   <para>dita:Topic</para>
    /// </summary>
    /// <remarks>
    ///   <para>"DITA topics are the basic units of DITA content and the basic units of reuse. Each topic contains a single subject. Topics may be of specific specialized information types, such as task, concept, or reference, or may be generic, that is, without a specified information type."</para>
    /// labels<para>"Topic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#Topic">http://purl.org/dita/ns#Topic</seealso>
    let Topic = Prefixed_Name(dita, "Topic") |> PrefixedName
    /// <summary>
    ///   <para>dita:Topicref</para>
    /// </summary>
    /// <remarks>
    ///   <para>"The topicref element identifies a topic (such as a concept, task, or reference) or other resource."</para>
    /// labels<para>"Topicref"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#Topicref">http://purl.org/dita/ns#Topicref</seealso>
    let Topicref = Prefixed_Name(dita, "Topicref") |> PrefixedName
    /// <summary>
    ///   <para>dita:Varname</para>
    /// </summary>
    /// <remarks>
    ///   <para>"The variable name (varname) element defines a variable that must be supplied to a software application."</para>
    /// labels<para>"Varname"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#Varname">http://purl.org/dita/ns#Varname</seealso>
    let Varname = Prefixed_Name(dita, "Varname") |> PrefixedName
    /// <summary>
    ///   <para>dita:Xref</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Use the cross-reference (xref) element to link to a different location within the current topic, or a different topic within the same help system, or to external sources, such as Web pages, or to a location in another topic."</para>
    /// labels<para>"Xref"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#Xref">http://purl.org/dita/ns#Xref</seealso>
    let Xref = Prefixed_Name(dita, "Xref") |> PrefixedName
    /// <summary>
    ///   <para>dita:audience</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The audience metadata element indicates, through the value of its type attribute, the intended audience for a topic."</para>
    /// labels<para>"audience"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#audience">http://purl.org/dita/ns#audience</seealso>
    let audience = Prefixed_Name(dita, "audience") |> PrefixedName
    /// <summary>
    ///   <para>dita:audienceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates the kind of person for whom the content of the topic is intended. Note that this differs from the type attribute on many other DITA elements."</para>
    /// labels<para>"type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#audienceType">http://purl.org/dita/ns#audienceType</seealso>
    let audienceType = Prefixed_Name(dita, "audienceType") |> PrefixedName
    /// <summary>
    ///   <para>dita:author</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The author metadata element contains the name of the topic's author."</para>
    /// labels<para>"author"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#author">http://purl.org/dita/ns#author</seealso>
    let author = Prefixed_Name(dita, "author") |> PrefixedName
    /// <summary>
    ///   <para>dita:backmatter</para>
    /// </summary>
    /// <remarks>
    ///   <para>"The backmatter element contains the material that follows the main body of a document and any appendices. It may include items such as a colophon, legal notices, and various types of book lists such as a glossary or an index."</para>
    /// labels<para>"backmatter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#backmatter">http://purl.org/dita/ns#backmatter</seealso>
    let backmatter = Prefixed_Name(dita, "backmatter") |> PrefixedName
    /// <summary>
    ///   <para>dita:booklibrary</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The booklibrary element contains the library information for a book. Library entries contain information about the series, library, or collection of documents to which the book belongs. "</para>
    /// labels<para>"booklibrary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#booklibrary">http://purl.org/dita/ns#booklibrary</seealso>
    let booklibrary = Prefixed_Name(dita, "booklibrary") |> PrefixedName
    /// <summary>
    ///   <para>dita:booktitlealt</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The booktitlealt element contains the alternative title, subtitle, or short title for a book. It may be specialized into a specific element for those or other purposes."</para>
    /// labels<para>"booktitlealt"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#booktitlealt">http://purl.org/dita/ns#booktitlealt</seealso>
    let booktitlealt = Prefixed_Name(dita, "booktitlealt") |> PrefixedName
    /// <summary>
    ///   <para>dita:category</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The category element represents any category by which a topic might be classified for retrieval or navigation."</para>
    /// labels<para>"category"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#category">http://purl.org/dita/ns#category</seealso>
    let category = Prefixed_Name(dita, "category") |> PrefixedName
    /// <summary>
    ///   <para>dita:chapter</para>
    /// </summary>
    /// <remarks>
    ///   <para>"The chapter element references a topic or map as a chapter within a book."</para>
    /// labels<para>"chapter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#chapter">http://purl.org/dita/ns#chapter</seealso>
    let chapter = Prefixed_Name(dita, "chapter") |> PrefixedName
    /// <summary>
    ///   <para>dita:class</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Attribute used to store the class attribute and identify the nature of the Conref/Conkeyref."</para>
    /// labels<para>"class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#class">http://purl.org/dita/ns#class</seealso>
    let class_ = Prefixed_Name(dita, "class") |> PrefixedName
    /// <summary>
    ///   <para>dita:conkeyref</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The conkeyref attribute provides an indirect content reference to topic elements, map elements, or elements within maps or topics."</para>
    /// labels<para>"conkeyref"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#conkeyref">http://purl.org/dita/ns#conkeyref</seealso>
    let conkeyref = Prefixed_Name(dita, "conkeyref") |> PrefixedName
    /// <summary>
    ///   <para>dita:conref</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This attribute is used to reference content that can be reused."</para>
    /// labels<para>"conref"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#conref">http://purl.org/dita/ns#conref</seealso>
    let conref = Prefixed_Name(dita, "conref") |> PrefixedName
    /// <summary>
    ///   <para>dita:copyright</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The copyright element specifies legal ownership of the content."</para>
    /// labels<para>"copyright"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#copyright">http://purl.org/dita/ns#copyright</seealso>
    let copyright = Prefixed_Name(dita, "copyright") |> PrefixedName
    /// <summary>
    ///   <para>dita:created</para>
    /// </summary>
    /// <remarks>
    ///   <para>"The created element specifies the document creation date using the date attribute."</para>
    /// labels<para>"created"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#created">http://purl.org/dita/ns#created</seealso>
    let created = Prefixed_Name(dita, "created") |> PrefixedName
    /// <summary>
    ///   <para>dita:createdExpiry</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The date when the information should be retired or refreshed, entered as YYYY-MM-DD, where YYYY is the year, MM is the month from 01 to 12, and DD is the day from 01-31."</para>
    /// labels<para>"created (expiry)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#createdExpiry">http://purl.org/dita/ns#createdExpiry</seealso>
    let createdExpiry = Prefixed_Name(dita, "createdExpiry") |> PrefixedName
    /// <summary>
    ///   <para>dita:createdGolive</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The publication or general availability (GA) date, entered as YYYY-MM-DD, where YYYY is the year, MM is the month from 01 to 12, and DD is the day from 01-31."</para>
    /// labels<para>"created (golive)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#createdGolive">http://purl.org/dita/ns#createdGolive</seealso>
    let createdGolive = Prefixed_Name(dita, "createdGolive") |> PrefixedName
    /// <summary>
    ///   <para>dita:element</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates that the file contains the target element."</para>
    /// labels<para>"element"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#element">http://purl.org/dita/ns#element</seealso>
    let element = Prefixed_Name(dita, "element") |> PrefixedName
    /// <summary>
    ///   <para>dita:experiencelevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates the level of experience the audience is assumed to possess."</para>
    /// labels<para>"experiencelevel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#experiencelevel">http://purl.org/dita/ns#experiencelevel</seealso>
    let experiencelevel = Prefixed_Name(dita, "experiencelevel") |> PrefixedName
    /// <summary>
    ///   <para>dita:format</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The format attribute identifies the format of the resource being cross referenced."</para>
    /// labels<para>"format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#format">http://purl.org/dita/ns#format</seealso>
    let format = Prefixed_Name(dita, "format") |> PrefixedName
    /// <summary>
    ///   <para>dita:frontmatter</para>
    /// </summary>
    /// <remarks>
    ///   <para>"The frontmatter element contains the material that precedes the main body of a document. It may include items such as an abstract, a preface, and various types of book lists such as a toc, tablelist, or figurelist. "</para>
    /// labels<para>"frontmatter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#frontmatter">http://purl.org/dita/ns#frontmatter</seealso>
    let frontmatter = Prefixed_Name(dita, "frontmatter") |> PrefixedName
    /// <summary>
    ///   <para>dita:href</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The href attribute is used by many elements to provide a reference to another DITA topic or map, to a specific element inside a DITA topic or map, or to an external Web page or other non-DITA resource."</para>
    /// labels<para>"href"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#href">http://purl.org/dita/ns#href</seealso>
    let href = Prefixed_Name(dita, "href") |> PrefixedName
    /// <summary>
    ///   <para>dita:id</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The DITA identity attribute provides a mechanism for identifying content for linking. "</para>
    /// labels<para>"id"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#id">http://purl.org/dita/ns#id</seealso>
    let id = Prefixed_Name(dita, "id") |> PrefixedName
    /// <summary>
    ///   <para>dita:job</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates the high-level task the audience for the topic is trying to accomplish."</para>
    /// labels<para>"job"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#job">http://purl.org/dita/ns#job</seealso>
    let job = Prefixed_Name(dita, "job") |> PrefixedName
    /// <summary>
    ///   <para>dita:keydef</para>
    /// </summary>
    /// <remarks>
    ///   <para>"The keydef element is a convenience element that is used to define keys without any of the other effects that occur when using a topicref element: no content is included in output, no title is included in the table of contents, and no linking or other relationships are defined."</para>
    /// labels<para>"keydef"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#keydef">http://purl.org/dita/ns#keydef</seealso>
    let keydef = Prefixed_Name(dita, "keydef") |> PrefixedName
    /// <summary>
    ///   <para>dita:keyname</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The name of the key."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"keyname"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#keyname">http://purl.org/dita/ns#keyname</seealso>
    let keyname = Prefixed_Name(dita, "keyname") |> PrefixedName
    /// <summary>
    ///   <para>dita:keyref</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The keyref attribute provides an indirect, late-bound reference to topics, to collections of topics (ditabase), to maps, to referenceable portions of maps, to non-DITA documents, to external URIs, or to XML content contained within a key definition topic reference."</para>
    /// labels<para>"keyref"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#keyref">http://purl.org/dita/ns#keyref</seealso>
    let keyref = Prefixed_Name(dita, "keyref") |> PrefixedName
    /// <summary>
    ///   <para>dita:keys</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This attribute is used to reference content that can be reused."</para>
    /// labels<para>"keys"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#keys">http://purl.org/dita/ns#keys</seealso>
    let keys = Prefixed_Name(dita, "keys") |> PrefixedName
    /// <summary>
    ///   <para>dita:keyword</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The keyword element identifies a keyword or token, such as a single value from an enumerated list, the name of a command or parameter, product name, or a lookup key for a message."</para>
    /// labels<para>"keyword"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#keyword">http://purl.org/dita/ns#keyword</seealso>
    let keyword = Prefixed_Name(dita, "keyword") |> PrefixedName
    /// <summary>
    ///   <para>dita:lang</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The language of the file as specified in @xml:lang, and supposed to conform to RFC 1766."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"language"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#lang">http://purl.org/dita/ns#lang</seealso>
    let lang = Prefixed_Name(dita, "lang") |> PrefixedName
    /// <summary>
    ///   <para>dita:link</para>
    /// </summary>
    /// <remarks>
    ///   <para>"The link element defines a relationship to another topic. Links are typically sorted when displayed based on their attributes, which define the type or role of the link's target in relation to the current topic."</para>
    /// labels<para>"link"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#link">http://purl.org/dita/ns#link</seealso>
    let link = Prefixed_Name(dita, "link") |> PrefixedName
    /// <summary>
    ///   <para>dita:mainbooktitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The mainbooktitle element contains the primary title information for a book."</para>
    /// labels<para>"mainbooktitle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#mainbooktitle">http://purl.org/dita/ns#mainbooktitle</seealso>
    let mainbooktitle = Prefixed_Name(dita, "mainbooktitle") |> PrefixedName
    /// <summary>
    ///   <para>dita:mapref</para>
    /// </summary>
    /// <remarks>
    ///   <para>"The mapref element is a convenience element that is equivalent to a &lt;topicref&gt; element with the format attribute set to 'ditamap'. The hierarchy of the referenced map is merged into the container map at the position of the reference, and the relationship tables of the child map are added to the parent map."</para>
    /// labels<para>"mapref"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#mapref">http://purl.org/dita/ns#mapref</seealso>
    let mapref = Prefixed_Name(dita, "mapref") |> PrefixedName
    /// <summary>
    ///   <para>dita:metadata</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/dita/ns#metadata">http://purl.org/dita/ns#metadata</seealso>
    let metadata = Prefixed_Name(dita, "metadata") |> PrefixedName
    /// <summary>
    ///   <para>dita:notices</para>
    /// </summary>
    /// <remarks>
    ///   <para>"The notices element references a topic containing special notice information, for example, legal notices about supplementary copyrights and trademarks associated with the book."</para>
    /// labels<para>"notices"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#notices">http://purl.org/dita/ns#notices</seealso>
    let notices = Prefixed_Name(dita, "notices") |> PrefixedName
    /// <summary>
    ///   <para>dita:othermeta</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The othermeta element can be used to identify properties not otherwise included in &lt;metadata&gt; and to assign name/content values to those properties."</para>
    /// labels<para>"othermeta"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#othermeta">http://purl.org/dita/ns#othermeta</seealso>
    let othermeta = Prefixed_Name(dita, "othermeta") |> PrefixedName
    /// <summary>
    ///   <para>dita:part</para>
    /// </summary>
    /// <remarks>
    ///   <para>"The part element references a part topic or a map that references part topics for the book. A new part is started. Use &lt;part&gt; to divide a document's chapters into logical groupings. For example, in a document that contains both guide and reference information, you can define two parts, one containing the guide information and the other containing the reference information."</para>
    /// labels<para>"part"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#part">http://purl.org/dita/ns#part</seealso>
    let part = Prefixed_Name(dita, "part") |> PrefixedName
    /// <summary>
    ///   <para>dita:permissions</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The permissions prolog element specifies the level of entitlement needed to access the content."</para>
    /// labels<para>"permissions	"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#permissions">http://purl.org/dita/ns#permissions</seealso>
    let permissions = Prefixed_Name(dita, "permissions") |> PrefixedName
    /// <summary>
    ///   <para>dita:platform</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The platform metadata element contains a description of the operating system and/or hardware related to the product being described by the prodinfo element."</para>
    /// labels<para>"platform"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#platform">http://purl.org/dita/ns#platform</seealso>
    let platform = Prefixed_Name(dita, "platform") |> PrefixedName
    /// <summary>
    ///   <para>dita:prodinfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Connects a DITA file with the product information that it is related to."</para>
    /// labels<para>"prodinfo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#prodinfo">http://purl.org/dita/ns#prodinfo</seealso>
    let prodinfo = Prefixed_Name(dita, "prodinfo") |> PrefixedName
    /// <summary>
    ///   <para>dita:prodname</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The prodname metadata element contains the name of the product that is supported by the information in this topic."</para>
    /// labels<para>"prodname"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#prodname">http://purl.org/dita/ns#prodname</seealso>
    let prodname = Prefixed_Name(dita, "prodname") |> PrefixedName
    /// <summary>
    ///   <para>dita:publisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The publisher metadata element contains the name of the person, company, or organization responsible for making the content or subject of the topic available."</para>
    /// labels<para>"publisher"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#publisher">http://purl.org/dita/ns#publisher</seealso>
    let publisher = Prefixed_Name(dita, "publisher") |> PrefixedName
    /// <summary>
    ///   <para>dita:referenceObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Describes a reference object that is part of a DITA file."</para>
    /// labels<para>"referenceObject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#referenceObject">http://purl.org/dita/ns#referenceObject</seealso>
    let referenceObject = Prefixed_Name(dita, "referenceObject") |> PrefixedName
    /// <summary>
    ///   <para>dita:revised</para>
    /// </summary>
    /// <remarks>
    ///   <para>"The revised element in the prolog is used to maintain tracking dates that are important in a topic development cycle, such as the last modification date, the original availability date, and the expiration date."</para>
    /// labels<para>"revised"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#revised">http://purl.org/dita/ns#revised</seealso>
    let revised = Prefixed_Name(dita, "revised") |> PrefixedName
    /// <summary>
    ///   <para>dita:revisedExpiry</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The date when the information should be retired or refreshed, entered as YYYY-MM-DD, where YYYY is the year, MM is the month from 01 to 12, and DD is the day from 01-31."</para>
    /// labels<para>"revised (expiry)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#revisedExpiry">http://purl.org/dita/ns#revisedExpiry</seealso>
    let revisedExpiry = Prefixed_Name(dita, "revisedExpiry") |> PrefixedName
    /// <summary>
    ///   <para>dita:revisedGolive</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The publication or general availability (GA) date, entered as YYYY-MM-DD, where YYYY is the year, MM is the month from 01 to 12, and DD is the day from 01-31."</para>
    /// labels<para>"revised (golive)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#revisedGolive">http://purl.org/dita/ns#revisedGolive</seealso>
    let revisedGolive = Prefixed_Name(dita, "revisedGolive") |> PrefixedName
    /// <summary>
    ///   <para>dita:scope</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The scope attribute identifies the closeness of the relationship between the current document and the target resource."</para>
    /// labels<para>"scope"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#scope">http://purl.org/dita/ns#scope</seealso>
    let scope = Prefixed_Name(dita, "scope") |> PrefixedName
    /// <summary>
    ///   <para>dita:searchtitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The searchtitle element is used to specify a title that should be displayed by search tools that locate the topic."</para>
    /// labels<para>"searchtitle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#searchtitle">http://purl.org/dita/ns#searchtitle</seealso>
    let searchtitle = Prefixed_Name(dita, "searchtitle") |> PrefixedName
    /// <summary>
    ///   <para>dita:shortdesc</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The short description (shortdesc) element occurs between the topic title and the topic body, as the initial paragraph-like content of a topic, or it can be embedded in an abstract element."</para>
    /// labels<para>"shortdesc"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#shortdesc">http://purl.org/dita/ns#shortdesc</seealso>
    let shortdesc = Prefixed_Name(dita, "shortdesc") |> PrefixedName
    /// <summary>
    ///   <para>dita:source</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The source element identifies a resource from which the present topic is derived, either completely or in part."</para>
    /// labels<para>"source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#source">http://purl.org/dita/ns#source</seealso>
    let source = Prefixed_Name(dita, "source") |> PrefixedName
    /// <summary>
    ///   <para>dita:subtopic</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Topics can be nested."</para>
    /// labels<para>"subtopic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#subtopic">http://purl.org/dita/ns#subtopic</seealso>
    let subtopic = Prefixed_Name(dita, "subtopic") |> PrefixedName
    /// <summary>
    ///   <para>dita:text</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The text contained in the element"</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dita/ns#text">http://purl.org/dita/ns#text</seealso>
    let text = Prefixed_Name(dita, "text") |> PrefixedName
    /// <summary>
    ///   <para>dita:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The title element contains a heading or label for the main parts of a topic, including the topic as a whole, its sections and examples, and its labelled content, such as figures and tables."</para>
    /// labels<para>"title"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#title">http://purl.org/dita/ns#title</seealso>
    let title = Prefixed_Name(dita, "title") |> PrefixedName
    /// <summary>
    ///   <para>dita:topicref</para>
    /// </summary>
    /// <remarks>
    ///   <para>"The topicref element identifies a topic (such as a concept, task, or reference) or other resource."</para>
    /// labels<para>"topicref"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#topicref">http://purl.org/dita/ns#topicref</seealso>
    let topicref = Prefixed_Name(dita, "topicref") |> PrefixedName
    /// <summary>
    ///   <para>dita:vrmModification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The vrm element contains information about a single product's version, modification, and release, to which the current topic applies."</para>
    /// labels<para>"vrm Modification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#vrmModification">http://purl.org/dita/ns#vrmModification</seealso>
    let vrmModification = Prefixed_Name(dita, "vrmModification") |> PrefixedName
    /// <summary>
    ///   <para>dita:vrmRelease</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The vrm element contains information about a single product's version, modification, and release, to which the current topic applies."</para>
    /// labels<para>"vrm Release"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#vrmRelease">http://purl.org/dita/ns#vrmRelease</seealso>
    let vrmRelease = Prefixed_Name(dita, "vrmRelease") |> PrefixedName
    /// <summary>
    ///   <para>dita:vrmVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The vrm element contains information about a single product's version, modification, and release, to which the current topic applies."</para>
    /// labels<para>"vrm Version"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#vrmVersion">http://purl.org/dita/ns#vrmVersion</seealso>
    let vrmVersion = Prefixed_Name(dita, "vrmVersion") |> PrefixedName
    /// <summary>
    ///   <para>dita:xref</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Use the cross-reference (xref) element to link to a different location within the current topic, or a different topic within the same help system, or to external sources, such as Web pages, or to a location in another topic."</para>
    /// labels<para>"xref"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#xref">http://purl.org/dita/ns#xref</seealso>
    let xref = Prefixed_Name(dita, "xref") |> PrefixedName
    /// <summary>
    ///   <para>dita:xtrf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"xml-trace-filename, the original filename"</para>
    /// labels<para>"xtrf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/dita/ns#xtrf">http://purl.org/dita/ns#xtrf</seealso>
    let xtrf = Prefixed_Name(dita, "xtrf") |> PrefixedName
