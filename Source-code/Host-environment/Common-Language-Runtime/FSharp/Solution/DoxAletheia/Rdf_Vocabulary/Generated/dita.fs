namespace http.purl.org.dita.ns.hash

open DoxAletheia.Rdf_Vocabulary

module dita =
    let _namespace_name = "http://purl.org/dita/ns#"
    /// <summary>
    /// The audience metadata element indicates, through the value of its type attribute, the intended audience for a topic.
    /// <see href="http://purl.org/dita/ns#Audience"></see></summary>
    let Audience = Namespaced_IRI.parse _namespace_name "Audience" |> NamespacedName
    /// <summary>
    /// The DITA bookmap specialization represents the key markup requirements for managing DITA content through book-oriented publication processes, including book metadata and book structures for organizing content.
    /// <see href="http://purl.org/dita/ns#Bookmap"></see></summary>
    let Bookmap = Namespaced_IRI.parse _namespace_name "Bookmap" |> NamespacedName
    /// <summary>
    /// DITA maps are documents that organize topics and other resources into structured collections of information. DITA maps specify hierarchy and the relationships among the topics; they also provide the context in which keys are defined and resolved.
    /// <see href="http://purl.org/dita/ns#Map"></see></summary>
    let Map = Namespaced_IRI.parse _namespace_name "Map" |> NamespacedName
    /// <summary>
    /// The coderef element references an external file that contains literal code.
    /// <see href="http://purl.org/dita/ns#Coderef"></see></summary>
    let Coderef = Namespaced_IRI.parse _namespace_name "Coderef" |> NamespacedName

    /// <summary>
    /// The DITA reference object is used to link, fetch or push content in relation with another file or object.
    /// <see href="http://purl.org/dita/ns#ReferenceObject"></see></summary>
    let ReferenceObject =
        Namespaced_IRI.parse _namespace_name "ReferenceObject" |> NamespacedName

    /// <summary>
    /// The DITA concept document type uses the concept information type.
    /// <see href="http://purl.org/dita/ns#Concept"></see></summary>
    let Concept = Namespaced_IRI.parse _namespace_name "Concept" |> NamespacedName
    /// <summary>
    /// DITA topics are the basic units of DITA content and the basic units of reuse. Each topic contains a single subject. Topics may be of specific specialized information types, such as task, concept, or reference, or may be generic, that is, without a specified information type.
    /// <see href="http://purl.org/dita/ns#Topic"></see></summary>
    let Topic = Namespaced_IRI.parse _namespace_name "Topic" |> NamespacedName
    /// <summary>
    /// The conkeyref attribute provides an indirect content reference to topic elements, map elements, or elements within maps or topics.
    /// <see href="http://purl.org/dita/ns#Conkeyref"></see></summary>
    let Conkeyref = Namespaced_IRI.parse _namespace_name "Conkeyref" |> NamespacedName
    /// <summary>
    /// This attribute is used to reference content that can be reused.
    /// <see href="http://purl.org/dita/ns#Conref"></see></summary>
    let Conref = Namespaced_IRI.parse _namespace_name "Conref" |> NamespacedName
    /// <summary>
    /// All the DITA document types.
    /// <see href="http://purl.org/dita/ns#Doctype"></see></summary>
    let Doctype = Namespaced_IRI.parse _namespace_name "Doctype" |> NamespacedName
    /// <summary>
    /// Include artwork or images in a DITA topic by using the image element.
    /// <see href="http://purl.org/dita/ns#Image"></see></summary>
    let Image = Namespaced_IRI.parse _namespace_name "Image" |> NamespacedName
    /// <summary>
    /// The DITA key-reference mechanism provides a layer of abstraction so that the resources addressed by references can be defined globally at the DITA map level instead of locally in each topic.
    /// <see href="http://purl.org/dita/ns#Key"></see></summary>
    let Key = Namespaced_IRI.parse _namespace_name "Key" |> NamespacedName
    /// <summary>
    /// The keydef element is a convenience element that is used to define keys without any of the other effects that occur when using a topicref element: no content is included in output, no title is included in the table of contents, and no linking or other relationships are defined.
    /// <see href="http://purl.org/dita/ns#Keydef"></see></summary>
    let Keydef = Namespaced_IRI.parse _namespace_name "Keydef" |> NamespacedName
    /// <summary>
    /// The topicref element identifies a topic (such as a concept, task, or reference) or other resource.
    /// <see href="http://purl.org/dita/ns#Topicref"></see></summary>
    let Topicref = Namespaced_IRI.parse _namespace_name "Topicref" |> NamespacedName
    /// <summary>
    /// The keyref attribute provides an indirect, late-bound reference to topics, to collections of topics (ditabase), to maps, to referenceable portions of maps, to non-DITA documents, to external URIs, or to XML content contained within a key definition topic reference.
    /// <see href="http://purl.org/dita/ns#Keyref"></see></summary>
    let Keyref = Namespaced_IRI.parse _namespace_name "Keyref" |> NamespacedName
    /// <summary>
    /// The keyword element identifies a keyword or token, such as a single value from an enumerated list, the name of a command or parameter, product name, or a lookup key for a message.
    /// <see href="http://purl.org/dita/ns#Keyword"></see></summary>
    let Keyword = Namespaced_IRI.parse _namespace_name "Keyword" |> NamespacedName

    /// <summary>
    /// A Learning Assessment presents questions or interactions that measure progress, encourage recollection, and stimulate reinforcement of the learning content, and can be presented before the content as a pre-assessment or as a post-assessment test.
    /// <see href="http://purl.org/dita/ns#LearningAssessment"></see></summary>
    let LearningAssessment =
        Namespaced_IRI.parse _namespace_name "LearningAssessment" |> NamespacedName

    /// <summary>
    /// The learningBase topic type is not used to deliver any actual learning content, but instead provides a set of common elements for use in the other more specific learning content types.
    /// <see href="http://purl.org/dita/ns#LearningBase"></see></summary>
    let LearningBase =
        Namespaced_IRI.parse _namespace_name "LearningBase" |> NamespacedName

    /// <summary>
    /// A Learning Content topic provides the learning content itself, and enables direct use of content from DITA task, concept, and reference topics, as well as additional content of any topic type that supports specific objectives declared in the Learning Overview topic type.
    /// <see href="http://purl.org/dita/ns#LearningContent"></see></summary>
    let LearningContent =
        Namespaced_IRI.parse _namespace_name "LearningContent" |> NamespacedName

    /// <summary>
    /// Use a learningContentComponentRef element to include a topic reference to a topic that acts as a subtopic of a learningContent topic.
    /// <see href="http://purl.org/dita/ns#LearningContentComponentRef"></see></summary>
    let LearningContentComponentRef =
        Namespaced_IRI.parse _namespace_name "LearningContentComponentRef" |> NamespacedName

    /// <summary>
    /// Use a learningContentRef element to include a topic reference to a learning content topic as part of a DITA learningObject.
    /// <see href="http://purl.org/dita/ns#LearningContentRef"></see></summary>
    let LearningContentRef =
        Namespaced_IRI.parse _namespace_name "LearningContentRef" |> NamespacedName

    /// <summary>
    /// learningObject organizes topic references to DITA learning topics as a learning object.
    /// <see href="http://purl.org/dita/ns#LearningObject"></see></summary>
    let LearningObject =
        Namespaced_IRI.parse _namespace_name "LearningObject" |> NamespacedName

    /// <summary>
    /// A Learning Overview topic identifies the learning objectives, includes other information helpful to the learner, such as prerequisites, duration, intended audience, and can include information and strategies that seeks to gain attention and stimulate recall of prior learning.
    /// <see href="http://purl.org/dita/ns#LearningOverview"></see></summary>
    let LearningOverview =
        Namespaced_IRI.parse _namespace_name "LearningOverview" |> NamespacedName

    /// <summary>
    /// Use a learningOverviewRef element to include a topic reference to a learning overview topic as part of a learningObject.
    /// <see href="http://purl.org/dita/ns#LearningOverviewRef"></see></summary>
    let LearningOverviewRef =
        Namespaced_IRI.parse _namespace_name "LearningOverviewRef" |> NamespacedName

    /// <summary>
    /// A Learning Plan topic describes learning needs and goals, instructional design models, task analyses, learning taxonomies, and other information necessary to the lesson planning process.
    /// <see href="http://purl.org/dita/ns#LearningPlan"></see></summary>
    let LearningPlan =
        Namespaced_IRI.parse _namespace_name "LearningPlan" |> NamespacedName

    /// <summary>
    /// Use a learningPlanRef element to include a topic reference to a learning plan topic as part of a learningObject.
    /// <see href="http://purl.org/dita/ns#LearningPlanRef"></see></summary>
    let LearningPlanRef =
        Namespaced_IRI.parse _namespace_name "LearningPlanRef" |> NamespacedName

    /// <summary>
    /// Use a learningPostAssessmentRef element to include a topic reference to a learning assessment topic as part of a DITA learningObject.
    /// <see href="http://purl.org/dita/ns#LearningPostAssessmentRef"></see></summary>
    let LearningPostAssessmentRef =
        Namespaced_IRI.parse _namespace_name "LearningPostAssessmentRef" |> NamespacedName

    /// <summary>
    /// Use a learningPreAssessmentRef element to include a topic reference to a learning assessment topic as part of a DITA learningObject.
    /// <see href="http://purl.org/dita/ns#LearningPreAssessmentRef"></see></summary>
    let LearningPreAssessmentRef =
        Namespaced_IRI.parse _namespace_name "LearningPreAssessmentRef" |> NamespacedName

    /// <summary>
    /// A Learning Summary recaps and provides context for the achievement or accomplishment of learning objectives, provides guidance to reinforce learning and long-term memory, and may pose questions to enhance encoding and verification of the learning content.
    /// <see href="http://purl.org/dita/ns#LearningSummary"></see></summary>
    let LearningSummary =
        Namespaced_IRI.parse _namespace_name "LearningSummary" |> NamespacedName

    /// <summary>
    /// Use a &lt;learningSummaryRef&gt; to include topic reference to a learning summary topic in a DITA learning object.
    /// <see href="http://purl.org/dita/ns#LearningSummaryRef"></see></summary>
    let LearningSummaryRef =
        Namespaced_IRI.parse _namespace_name "LearningSummaryRef" |> NamespacedName

    /// <summary>
    /// The link element defines a relationship to another topic. Links are typically sorted when displayed based on their attributes, which define the type or role of the link's target in relation to the current topic.
    /// <see href="http://purl.org/dita/ns#Link"></see></summary>
    let Link = Namespaced_IRI.parse _namespace_name "Link" |> NamespacedName
    /// <summary>
    /// The mapref element is a convenience element that is equivalent to a topicref element with the format attribute set to 'ditamap'.
    /// <see href="http://purl.org/dita/ns#Mapref"></see></summary>
    let Mapref = Namespaced_IRI.parse _namespace_name "Mapref" |> NamespacedName
    /// <summary>
    /// When referencing the name of an application programming interface parameter within the text flow of your topic, use the parameter name (&lt;parmname&gt;) element to mark up the parameter.
    /// <see href="http://purl.org/dita/ns#Parmname"></see></summary>
    let Parmname = Namespaced_IRI.parse _namespace_name "Parmname" |> NamespacedName
    /// <summary>
    /// The prodinfo metadata element contains information about the product or products that are the subject matter of the current topic.
    /// <see href="http://purl.org/dita/ns#Prodinfo"></see></summary>
    let Prodinfo = Namespaced_IRI.parse _namespace_name "Prodinfo" |> NamespacedName
    /// <summary>
    /// The DITA reference document type uses the reference information type.
    /// <see href="http://purl.org/dita/ns#Reference"></see></summary>
    let Reference = Namespaced_IRI.parse _namespace_name "Reference" |> NamespacedName
    /// <summary>
    /// The strict task document type supports the development of instructions for the completion of a procedure.
    /// <see href="http://purl.org/dita/ns#Task"></see></summary>
    let Task = Namespaced_IRI.parse _namespace_name "Task" |> NamespacedName
    /// <summary>
    /// The variable name (varname) element defines a variable that must be supplied to a software application.
    /// <see href="http://purl.org/dita/ns#Varname"></see></summary>
    let Varname = Namespaced_IRI.parse _namespace_name "Varname" |> NamespacedName
    /// <summary>
    /// Use the cross-reference (xref) element to link to a different location within the current topic, or a different topic within the same help system, or to external sources, such as Web pages, or to a location in another topic.
    /// <see href="http://purl.org/dita/ns#Xref"></see></summary>
    let Xref = Namespaced_IRI.parse _namespace_name "Xref" |> NamespacedName
    /// <summary>
    /// The audience metadata element indicates, through the value of its type attribute, the intended audience for a topic.
    /// <see href="http://purl.org/dita/ns#audience"></see></summary>
    let audience = Namespaced_IRI.parse _namespace_name "audience" |> NamespacedName
    /// <summary>
    /// Indicates that the file contains the target element.
    /// <see href="http://purl.org/dita/ns#element"></see></summary>
    let element = Namespaced_IRI.parse _namespace_name "element" |> NamespacedName

    /// <summary>
    /// Indicates the kind of person for whom the content of the topic is intended. Note that this differs from the type attribute on many other DITA elements.
    /// <see href="http://purl.org/dita/ns#audienceType"></see></summary>
    let audienceType =
        Namespaced_IRI.parse _namespace_name "audienceType" |> NamespacedName

    /// <summary>
    /// The author metadata element contains the name of the topic's author.
    /// <see href="http://purl.org/dita/ns#author"></see></summary>
    let author = Namespaced_IRI.parse _namespace_name "author" |> NamespacedName
    /// <summary>
    /// The backmatter element contains the material that follows the main body of a document and any appendices. It may include items such as a colophon, legal notices, and various types of book lists such as a glossary or an index.
    /// <see href="http://purl.org/dita/ns#backmatter"></see></summary>
    let backmatter = Namespaced_IRI.parse _namespace_name "backmatter" |> NamespacedName

    /// <summary>
    /// Describes a reference object that is part of a DITA file.
    /// <see href="http://purl.org/dita/ns#referenceObject"></see></summary>
    let referenceObject =
        Namespaced_IRI.parse _namespace_name "referenceObject" |> NamespacedName

    /// <summary>
    /// The topicref element identifies a topic (such as a concept, task, or reference) or other resource.
    /// <see href="http://purl.org/dita/ns#topicref"></see></summary>
    let topicref = Namespaced_IRI.parse _namespace_name "topicref" |> NamespacedName

    /// <summary>
    /// The booklibrary element contains the library information for a book. Library entries contain information about the series, library, or collection of documents to which the book belongs.
    /// <see href="http://purl.org/dita/ns#booklibrary"></see></summary>
    let booklibrary =
        Namespaced_IRI.parse _namespace_name "booklibrary" |> NamespacedName

    /// <summary>
    /// The booktitlealt element contains the alternative title, subtitle, or short title for a book. It may be specialized into a specific element for those or other purposes.
    /// <see href="http://purl.org/dita/ns#booktitlealt"></see></summary>
    let booktitlealt =
        Namespaced_IRI.parse _namespace_name "booktitlealt" |> NamespacedName

    /// <summary>
    /// The category element represents any category by which a topic might be classified for retrieval or navigation.
    /// <see href="http://purl.org/dita/ns#category"></see></summary>
    let category = Namespaced_IRI.parse _namespace_name "category" |> NamespacedName
    /// <summary>
    /// The chapter element references a topic or map as a chapter within a book.
    /// <see href="http://purl.org/dita/ns#chapter"></see></summary>
    let chapter = Namespaced_IRI.parse _namespace_name "chapter" |> NamespacedName
    /// <summary>
    /// Attribute used to store the class attribute and identify the nature of the Conref/Conkeyref.
    /// <see href="http://purl.org/dita/ns#class"></see></summary>
    let class_ = Namespaced_IRI.parse _namespace_name "class" |> NamespacedName
    /// <summary>
    /// The conkeyref attribute provides an indirect content reference to topic elements, map elements, or elements within maps or topics.
    /// <see href="http://purl.org/dita/ns#conkeyref"></see></summary>
    let conkeyref = Namespaced_IRI.parse _namespace_name "conkeyref" |> NamespacedName
    /// <summary>
    /// This attribute is used to reference content that can be reused.
    /// <see href="http://purl.org/dita/ns#conref"></see></summary>
    let conref = Namespaced_IRI.parse _namespace_name "conref" |> NamespacedName
    /// <summary>
    /// The copyright element specifies legal ownership of the content.
    /// <see href="http://purl.org/dita/ns#copyright"></see></summary>
    let copyright = Namespaced_IRI.parse _namespace_name "copyright" |> NamespacedName
    /// <summary>
    /// The created element specifies the document creation date using the date attribute.
    /// <see href="http://purl.org/dita/ns#created"></see></summary>
    let created = Namespaced_IRI.parse _namespace_name "created" |> NamespacedName

    /// <summary>
    /// The date when the information should be retired or refreshed, entered as YYYY-MM-DD, where YYYY is the year, MM is the month from 01 to 12, and DD is the day from 01-31.
    /// <see href="http://purl.org/dita/ns#createdExpiry"></see></summary>
    let createdExpiry =
        Namespaced_IRI.parse _namespace_name "createdExpiry" |> NamespacedName

    /// <summary>
    /// The publication or general availability (GA) date, entered as YYYY-MM-DD, where YYYY is the year, MM is the month from 01 to 12, and DD is the day from 01-31.
    /// <see href="http://purl.org/dita/ns#createdGolive"></see></summary>
    let createdGolive =
        Namespaced_IRI.parse _namespace_name "createdGolive" |> NamespacedName

    /// <summary>
    /// Indicates the level of experience the audience is assumed to possess.
    /// <see href="http://purl.org/dita/ns#experiencelevel"></see></summary>
    let experiencelevel =
        Namespaced_IRI.parse _namespace_name "experiencelevel" |> NamespacedName

    /// <summary>
    /// The format attribute identifies the format of the resource being cross referenced.
    /// <see href="http://purl.org/dita/ns#format"></see></summary>
    let format = Namespaced_IRI.parse _namespace_name "format" |> NamespacedName

    /// <summary>
    /// The frontmatter element contains the material that precedes the main body of a document. It may include items such as an abstract, a preface, and various types of book lists such as a toc, tablelist, or figurelist.
    /// <see href="http://purl.org/dita/ns#frontmatter"></see></summary>
    let frontmatter =
        Namespaced_IRI.parse _namespace_name "frontmatter" |> NamespacedName

    /// <summary>
    /// The href attribute is used by many elements to provide a reference to another DITA topic or map, to a specific element inside a DITA topic or map, or to an external Web page or other non-DITA resource.
    /// <see href="http://purl.org/dita/ns#href"></see></summary>
    let href = Namespaced_IRI.parse _namespace_name "href" |> NamespacedName
    /// <summary>
    /// The DITA identity attribute provides a mechanism for identifying content for linking.
    /// <see href="http://purl.org/dita/ns#id"></see></summary>
    let id = Namespaced_IRI.parse _namespace_name "id" |> NamespacedName
    /// <summary>
    /// Indicates the high-level task the audience for the topic is trying to accomplish.
    /// <see href="http://purl.org/dita/ns#job"></see></summary>
    let job = Namespaced_IRI.parse _namespace_name "job" |> NamespacedName
    /// <summary>
    /// The keydef element is a convenience element that is used to define keys without any of the other effects that occur when using a topicref element: no content is included in output, no title is included in the table of contents, and no linking or other relationships are defined.
    /// <see href="http://purl.org/dita/ns#keydef"></see></summary>
    let keydef = Namespaced_IRI.parse _namespace_name "keydef" |> NamespacedName
    /// <summary>
    /// The name of the key.
    /// <see href="http://purl.org/dita/ns#keyname"></see></summary>
    let keyname = Namespaced_IRI.parse _namespace_name "keyname" |> NamespacedName
    /// <summary>
    /// The keyref attribute provides an indirect, late-bound reference to topics, to collections of topics (ditabase), to maps, to referenceable portions of maps, to non-DITA documents, to external URIs, or to XML content contained within a key definition topic reference.
    /// <see href="http://purl.org/dita/ns#keyref"></see></summary>
    let keyref = Namespaced_IRI.parse _namespace_name "keyref" |> NamespacedName
    /// <summary>
    /// This attribute is used to reference content that can be reused.
    /// <see href="http://purl.org/dita/ns#keys"></see></summary>
    let keys = Namespaced_IRI.parse _namespace_name "keys" |> NamespacedName
    /// <summary>
    /// The keyword element identifies a keyword or token, such as a single value from an enumerated list, the name of a command or parameter, product name, or a lookup key for a message.
    /// <see href="http://purl.org/dita/ns#keyword"></see></summary>
    let keyword = Namespaced_IRI.parse _namespace_name "keyword" |> NamespacedName
    /// <summary>
    /// The language of the file as specified in @xml:lang, and supposed to conform to RFC 1766.
    /// <see href="http://purl.org/dita/ns#lang"></see></summary>
    let lang = Namespaced_IRI.parse _namespace_name "lang" |> NamespacedName
    /// <summary>
    /// The link element defines a relationship to another topic. Links are typically sorted when displayed based on their attributes, which define the type or role of the link's target in relation to the current topic.
    /// <see href="http://purl.org/dita/ns#link"></see></summary>
    let link = Namespaced_IRI.parse _namespace_name "link" |> NamespacedName

    /// <summary>
    /// The mainbooktitle element contains the primary title information for a book.
    /// <see href="http://purl.org/dita/ns#mainbooktitle"></see></summary>
    let mainbooktitle =
        Namespaced_IRI.parse _namespace_name "mainbooktitle" |> NamespacedName

    /// <summary>
    /// The mapref element is a convenience element that is equivalent to a &lt;topicref&gt; element with the format attribute set to 'ditamap'. The hierarchy of the referenced map is merged into the container map at the position of the reference, and the relationship tables of the child map are added to the parent map.
    /// <see href="http://purl.org/dita/ns#mapref"></see></summary>
    let mapref = Namespaced_IRI.parse _namespace_name "mapref" |> NamespacedName
    /// <summary>
    /// The notices element references a topic containing special notice information, for example, legal notices about supplementary copyrights and trademarks associated with the book.
    /// <see href="http://purl.org/dita/ns#notices"></see></summary>
    let notices = Namespaced_IRI.parse _namespace_name "notices" |> NamespacedName
    /// <summary>
    /// The othermeta element can be used to identify properties not otherwise included in &lt;metadata&gt; and to assign name/content values to those properties.
    /// <see href="http://purl.org/dita/ns#othermeta"></see></summary>
    let othermeta = Namespaced_IRI.parse _namespace_name "othermeta" |> NamespacedName
    /// <summary>
    /// The part element references a part topic or a map that references part topics for the book. A new part is started. Use &lt;part&gt; to divide a document's chapters into logical groupings. For example, in a document that contains both guide and reference information, you can define two parts, one containing the guide information and the other containing the reference information.
    /// <see href="http://purl.org/dita/ns#part"></see></summary>
    let part = Namespaced_IRI.parse _namespace_name "part" |> NamespacedName

    /// <summary>
    /// The permissions prolog element specifies the level of entitlement needed to access the content.
    /// <see href="http://purl.org/dita/ns#permissions"></see></summary>
    let permissions =
        Namespaced_IRI.parse _namespace_name "permissions" |> NamespacedName

    /// <summary>
    /// The platform metadata element contains a description of the operating system and/or hardware related to the product being described by the prodinfo element.
    /// <see href="http://purl.org/dita/ns#platform"></see></summary>
    let platform = Namespaced_IRI.parse _namespace_name "platform" |> NamespacedName
    /// <summary>
    /// Connects a DITA file with the product information that it is related to.
    /// <see href="http://purl.org/dita/ns#prodinfo"></see></summary>
    let prodinfo = Namespaced_IRI.parse _namespace_name "prodinfo" |> NamespacedName
    /// <summary>
    /// The prodname metadata element contains the name of the product that is supported by the information in this topic.
    /// <see href="http://purl.org/dita/ns#prodname"></see></summary>
    let prodname = Namespaced_IRI.parse _namespace_name "prodname" |> NamespacedName
    /// <summary>
    /// The publisher metadata element contains the name of the person, company, or organization responsible for making the content or subject of the topic available.
    /// <see href="http://purl.org/dita/ns#publisher"></see></summary>
    let publisher = Namespaced_IRI.parse _namespace_name "publisher" |> NamespacedName
    /// <summary>
    /// The revised element in the prolog is used to maintain tracking dates that are important in a topic development cycle, such as the last modification date, the original availability date, and the expiration date.
    /// <see href="http://purl.org/dita/ns#revised"></see></summary>
    let revised = Namespaced_IRI.parse _namespace_name "revised" |> NamespacedName

    /// <summary>
    /// The date when the information should be retired or refreshed, entered as YYYY-MM-DD, where YYYY is the year, MM is the month from 01 to 12, and DD is the day from 01-31.
    /// <see href="http://purl.org/dita/ns#revisedExpiry"></see></summary>
    let revisedExpiry =
        Namespaced_IRI.parse _namespace_name "revisedExpiry" |> NamespacedName

    /// <summary>
    /// The publication or general availability (GA) date, entered as YYYY-MM-DD, where YYYY is the year, MM is the month from 01 to 12, and DD is the day from 01-31.
    /// <see href="http://purl.org/dita/ns#revisedGolive"></see></summary>
    let revisedGolive =
        Namespaced_IRI.parse _namespace_name "revisedGolive" |> NamespacedName

    /// <summary>
    /// The scope attribute identifies the closeness of the relationship between the current document and the target resource.
    /// <see href="http://purl.org/dita/ns#scope"></see></summary>
    let scope = Namespaced_IRI.parse _namespace_name "scope" |> NamespacedName

    /// <summary>
    /// The searchtitle element is used to specify a title that should be displayed by search tools that locate the topic.
    /// <see href="http://purl.org/dita/ns#searchtitle"></see></summary>
    let searchtitle =
        Namespaced_IRI.parse _namespace_name "searchtitle" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/dita/ns#metadata"></see>
    /// </summary>
    let metadata = Namespaced_IRI.parse _namespace_name "metadata" |> NamespacedName
    /// <summary>
    /// The short description (shortdesc) element occurs between the topic title and the topic body, as the initial paragraph-like content of a topic, or it can be embedded in an abstract element.
    /// <see href="http://purl.org/dita/ns#shortdesc"></see></summary>
    let shortdesc = Namespaced_IRI.parse _namespace_name "shortdesc" |> NamespacedName
    /// <summary>
    /// The source element identifies a resource from which the present topic is derived, either completely or in part.
    /// <see href="http://purl.org/dita/ns#source"></see></summary>
    let source = Namespaced_IRI.parse _namespace_name "source" |> NamespacedName
    /// <summary>
    /// Topics can be nested.
    /// <see href="http://purl.org/dita/ns#subtopic"></see></summary>
    let subtopic = Namespaced_IRI.parse _namespace_name "subtopic" |> NamespacedName
    /// <summary>
    /// The text contained in the element
    /// <see href="http://purl.org/dita/ns#text"></see></summary>
    let text = Namespaced_IRI.parse _namespace_name "text" |> NamespacedName
    /// <summary>
    /// The title element contains a heading or label for the main parts of a topic, including the topic as a whole, its sections and examples, and its labelled content, such as figures and tables.
    /// <see href="http://purl.org/dita/ns#title"></see></summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName

    /// <summary>
    /// The vrm element contains information about a single product's version, modification, and release, to which the current topic applies.
    /// <see href="http://purl.org/dita/ns#vrmModification"></see></summary>
    let vrmModification =
        Namespaced_IRI.parse _namespace_name "vrmModification" |> NamespacedName

    /// <summary>
    /// The vrm element contains information about a single product's version, modification, and release, to which the current topic applies.
    /// <see href="http://purl.org/dita/ns#vrmRelease"></see></summary>
    let vrmRelease = Namespaced_IRI.parse _namespace_name "vrmRelease" |> NamespacedName
    /// <summary>
    /// The vrm element contains information about a single product's version, modification, and release, to which the current topic applies.
    /// <see href="http://purl.org/dita/ns#vrmVersion"></see></summary>
    let vrmVersion = Namespaced_IRI.parse _namespace_name "vrmVersion" |> NamespacedName
    /// <summary>
    /// Use the cross-reference (xref) element to link to a different location within the current topic, or a different topic within the same help system, or to external sources, such as Web pages, or to a location in another topic.
    /// <see href="http://purl.org/dita/ns#xref"></see></summary>
    let xref = Namespaced_IRI.parse _namespace_name "xref" |> NamespacedName
    /// <summary>
    /// xml-trace-filename, the original filename
    /// <see href="http://purl.org/dita/ns#xtrf"></see></summary>
    let xtrf = Namespaced_IRI.parse _namespace_name "xtrf" |> NamespacedName
