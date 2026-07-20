namespace http.purl.org.dita.ns.hash

open DoxAletheia

module dita =
    let _namespace_name = "http://purl.org/dita/ns#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The audience metadata element indicates, through the value of its type attribute, the intended audience for a topic.
    /// <see href="http://purl.org/dita/ns#Audience"></see></summary>
    let Audience = _prefix "Audience"
    /// <summary>
    /// The DITA bookmap specialization represents the key markup requirements for managing DITA content through book-oriented publication processes, including book metadata and book structures for organizing content.
    /// <see href="http://purl.org/dita/ns#Bookmap"></see></summary>
    let Bookmap = _prefix "Bookmap"
    /// <summary>
    /// DITA maps are documents that organize topics and other resources into structured collections of information. DITA maps specify hierarchy and the relationships among the topics; they also provide the context in which keys are defined and resolved.
    /// <see href="http://purl.org/dita/ns#Map"></see></summary>
    let Map = _prefix "Map"
    /// <summary>
    /// The coderef element references an external file that contains literal code.
    /// <see href="http://purl.org/dita/ns#Coderef"></see></summary>
    let Coderef = _prefix "Coderef"
    /// <summary>
    /// The DITA reference object is used to link, fetch or push content in relation with another file or object.
    /// <see href="http://purl.org/dita/ns#ReferenceObject"></see></summary>
    let ReferenceObject = _prefix "ReferenceObject"
    /// <summary>
    /// The DITA concept document type uses the concept information type.
    /// <see href="http://purl.org/dita/ns#Concept"></see></summary>
    let Concept = _prefix "Concept"
    /// <summary>
    /// DITA topics are the basic units of DITA content and the basic units of reuse. Each topic contains a single subject. Topics may be of specific specialized information types, such as task, concept, or reference, or may be generic, that is, without a specified information type.
    /// <see href="http://purl.org/dita/ns#Topic"></see></summary>
    let Topic = _prefix "Topic"
    /// <summary>
    /// The conkeyref attribute provides an indirect content reference to topic elements, map elements, or elements within maps or topics.
    /// <see href="http://purl.org/dita/ns#Conkeyref"></see></summary>
    let Conkeyref = _prefix "Conkeyref"
    /// <summary>
    /// This attribute is used to reference content that can be reused.
    /// <see href="http://purl.org/dita/ns#Conref"></see></summary>
    let Conref = _prefix "Conref"
    /// <summary>
    /// All the DITA document types.
    /// <see href="http://purl.org/dita/ns#Doctype"></see></summary>
    let Doctype = _prefix "Doctype"
    /// <summary>
    /// Include artwork or images in a DITA topic by using the image element.
    /// <see href="http://purl.org/dita/ns#Image"></see></summary>
    let Image = _prefix "Image"
    /// <summary>
    /// The DITA key-reference mechanism provides a layer of abstraction so that the resources addressed by references can be defined globally at the DITA map level instead of locally in each topic.
    /// <see href="http://purl.org/dita/ns#Key"></see></summary>
    let Key = _prefix "Key"
    /// <summary>
    /// The keydef element is a convenience element that is used to define keys without any of the other effects that occur when using a topicref element: no content is included in output, no title is included in the table of contents, and no linking or other relationships are defined.
    /// <see href="http://purl.org/dita/ns#Keydef"></see></summary>
    let Keydef = _prefix "Keydef"
    /// <summary>
    /// The topicref element identifies a topic (such as a concept, task, or reference) or other resource.
    /// <see href="http://purl.org/dita/ns#Topicref"></see></summary>
    let Topicref = _prefix "Topicref"
    /// <summary>
    /// The keyref attribute provides an indirect, late-bound reference to topics, to collections of topics (ditabase), to maps, to referenceable portions of maps, to non-DITA documents, to external URIs, or to XML content contained within a key definition topic reference.
    /// <see href="http://purl.org/dita/ns#Keyref"></see></summary>
    let Keyref = _prefix "Keyref"
    /// <summary>
    /// The keyword element identifies a keyword or token, such as a single value from an enumerated list, the name of a command or parameter, product name, or a lookup key for a message.
    /// <see href="http://purl.org/dita/ns#Keyword"></see></summary>
    let Keyword = _prefix "Keyword"
    /// <summary>
    /// A Learning Assessment presents questions or interactions that measure progress, encourage recollection, and stimulate reinforcement of the learning content, and can be presented before the content as a pre-assessment or as a post-assessment test.
    /// <see href="http://purl.org/dita/ns#LearningAssessment"></see></summary>
    let LearningAssessment = _prefix "LearningAssessment"
    /// <summary>
    /// The learningBase topic type is not used to deliver any actual learning content, but instead provides a set of common elements for use in the other more specific learning content types.
    /// <see href="http://purl.org/dita/ns#LearningBase"></see></summary>
    let LearningBase = _prefix "LearningBase"
    /// <summary>
    /// A Learning Content topic provides the learning content itself, and enables direct use of content from DITA task, concept, and reference topics, as well as additional content of any topic type that supports specific objectives declared in the Learning Overview topic type.
    /// <see href="http://purl.org/dita/ns#LearningContent"></see></summary>
    let LearningContent = _prefix "LearningContent"
    /// <summary>
    /// Use a learningContentComponentRef element to include a topic reference to a topic that acts as a subtopic of a learningContent topic.
    /// <see href="http://purl.org/dita/ns#LearningContentComponentRef"></see></summary>
    let LearningContentComponentRef = _prefix "LearningContentComponentRef"
    /// <summary>
    /// Use a learningContentRef element to include a topic reference to a learning content topic as part of a DITA learningObject.
    /// <see href="http://purl.org/dita/ns#LearningContentRef"></see></summary>
    let LearningContentRef = _prefix "LearningContentRef"
    /// <summary>
    /// learningObject organizes topic references to DITA learning topics as a learning object.
    /// <see href="http://purl.org/dita/ns#LearningObject"></see></summary>
    let LearningObject = _prefix "LearningObject"
    /// <summary>
    /// A Learning Overview topic identifies the learning objectives, includes other information helpful to the learner, such as prerequisites, duration, intended audience, and can include information and strategies that seeks to gain attention and stimulate recall of prior learning.
    /// <see href="http://purl.org/dita/ns#LearningOverview"></see></summary>
    let LearningOverview = _prefix "LearningOverview"
    /// <summary>
    /// Use a learningOverviewRef element to include a topic reference to a learning overview topic as part of a learningObject.
    /// <see href="http://purl.org/dita/ns#LearningOverviewRef"></see></summary>
    let LearningOverviewRef = _prefix "LearningOverviewRef"
    /// <summary>
    /// A Learning Plan topic describes learning needs and goals, instructional design models, task analyses, learning taxonomies, and other information necessary to the lesson planning process.
    /// <see href="http://purl.org/dita/ns#LearningPlan"></see></summary>
    let LearningPlan = _prefix "LearningPlan"
    /// <summary>
    /// Use a learningPlanRef element to include a topic reference to a learning plan topic as part of a learningObject.
    /// <see href="http://purl.org/dita/ns#LearningPlanRef"></see></summary>
    let LearningPlanRef = _prefix "LearningPlanRef"
    /// <summary>
    /// Use a learningPostAssessmentRef element to include a topic reference to a learning assessment topic as part of a DITA learningObject.
    /// <see href="http://purl.org/dita/ns#LearningPostAssessmentRef"></see></summary>
    let LearningPostAssessmentRef = _prefix "LearningPostAssessmentRef"
    /// <summary>
    /// Use a learningPreAssessmentRef element to include a topic reference to a learning assessment topic as part of a DITA learningObject.
    /// <see href="http://purl.org/dita/ns#LearningPreAssessmentRef"></see></summary>
    let LearningPreAssessmentRef = _prefix "LearningPreAssessmentRef"
    /// <summary>
    /// A Learning Summary recaps and provides context for the achievement or accomplishment of learning objectives, provides guidance to reinforce learning and long-term memory, and may pose questions to enhance encoding and verification of the learning content.
    /// <see href="http://purl.org/dita/ns#LearningSummary"></see></summary>
    let LearningSummary = _prefix "LearningSummary"
    /// <summary>
    /// Use a &lt;learningSummaryRef&gt; to include topic reference to a learning summary topic in a DITA learning object.
    /// <see href="http://purl.org/dita/ns#LearningSummaryRef"></see></summary>
    let LearningSummaryRef = _prefix "LearningSummaryRef"
    /// <summary>
    /// The link element defines a relationship to another topic. Links are typically sorted when displayed based on their attributes, which define the type or role of the link's target in relation to the current topic.
    /// <see href="http://purl.org/dita/ns#Link"></see></summary>
    let Link = _prefix "Link"
    /// <summary>
    /// The mapref element is a convenience element that is equivalent to a topicref element with the format attribute set to 'ditamap'.
    /// <see href="http://purl.org/dita/ns#Mapref"></see></summary>
    let Mapref = _prefix "Mapref"
    /// <summary>
    /// When referencing the name of an application programming interface parameter within the text flow of your topic, use the parameter name (&lt;parmname&gt;) element to mark up the parameter.
    /// <see href="http://purl.org/dita/ns#Parmname"></see></summary>
    let Parmname = _prefix "Parmname"
    /// <summary>
    /// The prodinfo metadata element contains information about the product or products that are the subject matter of the current topic.
    /// <see href="http://purl.org/dita/ns#Prodinfo"></see></summary>
    let Prodinfo = _prefix "Prodinfo"
    /// <summary>
    /// The DITA reference document type uses the reference information type.
    /// <see href="http://purl.org/dita/ns#Reference"></see></summary>
    let Reference = _prefix "Reference"
    /// <summary>
    /// The strict task document type supports the development of instructions for the completion of a procedure.
    /// <see href="http://purl.org/dita/ns#Task"></see></summary>
    let Task = _prefix "Task"
    /// <summary>
    /// The variable name (varname) element defines a variable that must be supplied to a software application.
    /// <see href="http://purl.org/dita/ns#Varname"></see></summary>
    let Varname = _prefix "Varname"
    /// <summary>
    /// Use the cross-reference (xref) element to link to a different location within the current topic, or a different topic within the same help system, or to external sources, such as Web pages, or to a location in another topic.
    /// <see href="http://purl.org/dita/ns#Xref"></see></summary>
    let Xref = _prefix "Xref"
    /// <summary>
    /// The audience metadata element indicates, through the value of its type attribute, the intended audience for a topic.
    /// <see href="http://purl.org/dita/ns#audience"></see></summary>
    let audience = _prefix "audience"
    /// <summary>
    /// Indicates that the file contains the target element.
    /// <see href="http://purl.org/dita/ns#element"></see></summary>
    let element = _prefix "element"
    /// <summary>
    /// Indicates the kind of person for whom the content of the topic is intended. Note that this differs from the type attribute on many other DITA elements.
    /// <see href="http://purl.org/dita/ns#audienceType"></see></summary>
    let audienceType = _prefix "audienceType"
    /// <summary>
    /// The author metadata element contains the name of the topic's author.
    /// <see href="http://purl.org/dita/ns#author"></see></summary>
    let author = _prefix "author"
    /// <summary>
    /// The backmatter element contains the material that follows the main body of a document and any appendices. It may include items such as a colophon, legal notices, and various types of book lists such as a glossary or an index.
    /// <see href="http://purl.org/dita/ns#backmatter"></see></summary>
    let backmatter = _prefix "backmatter"
    /// <summary>
    /// Describes a reference object that is part of a DITA file.
    /// <see href="http://purl.org/dita/ns#referenceObject"></see></summary>
    let referenceObject = _prefix "referenceObject"
    /// <summary>
    /// The topicref element identifies a topic (such as a concept, task, or reference) or other resource.
    /// <see href="http://purl.org/dita/ns#topicref"></see></summary>
    let topicref = _prefix "topicref"
    /// <summary>
    /// The booklibrary element contains the library information for a book. Library entries contain information about the series, library, or collection of documents to which the book belongs.
    /// <see href="http://purl.org/dita/ns#booklibrary"></see></summary>
    let booklibrary = _prefix "booklibrary"
    /// <summary>
    /// The booktitlealt element contains the alternative title, subtitle, or short title for a book. It may be specialized into a specific element for those or other purposes.
    /// <see href="http://purl.org/dita/ns#booktitlealt"></see></summary>
    let booktitlealt = _prefix "booktitlealt"
    /// <summary>
    /// The category element represents any category by which a topic might be classified for retrieval or navigation.
    /// <see href="http://purl.org/dita/ns#category"></see></summary>
    let category = _prefix "category"
    /// <summary>
    /// The chapter element references a topic or map as a chapter within a book.
    /// <see href="http://purl.org/dita/ns#chapter"></see></summary>
    let chapter = _prefix "chapter"
    /// <summary>
    /// Attribute used to store the class attribute and identify the nature of the Conref/Conkeyref.
    /// <see href="http://purl.org/dita/ns#class"></see></summary>
    let class_ = _prefix "class"
    /// <summary>
    /// The conkeyref attribute provides an indirect content reference to topic elements, map elements, or elements within maps or topics.
    /// <see href="http://purl.org/dita/ns#conkeyref"></see></summary>
    let conkeyref = _prefix "conkeyref"
    /// <summary>
    /// This attribute is used to reference content that can be reused.
    /// <see href="http://purl.org/dita/ns#conref"></see></summary>
    let conref = _prefix "conref"
    /// <summary>
    /// The copyright element specifies legal ownership of the content.
    /// <see href="http://purl.org/dita/ns#copyright"></see></summary>
    let copyright = _prefix "copyright"
    /// <summary>
    /// The created element specifies the document creation date using the date attribute.
    /// <see href="http://purl.org/dita/ns#created"></see></summary>
    let created = _prefix "created"
    /// <summary>
    /// The date when the information should be retired or refreshed, entered as YYYY-MM-DD, where YYYY is the year, MM is the month from 01 to 12, and DD is the day from 01-31.
    /// <see href="http://purl.org/dita/ns#createdExpiry"></see></summary>
    let createdExpiry = _prefix "createdExpiry"
    /// <summary>
    /// The publication or general availability (GA) date, entered as YYYY-MM-DD, where YYYY is the year, MM is the month from 01 to 12, and DD is the day from 01-31.
    /// <see href="http://purl.org/dita/ns#createdGolive"></see></summary>
    let createdGolive = _prefix "createdGolive"
    /// <summary>
    /// Indicates the level of experience the audience is assumed to possess.
    /// <see href="http://purl.org/dita/ns#experiencelevel"></see></summary>
    let experiencelevel = _prefix "experiencelevel"
    /// <summary>
    /// The format attribute identifies the format of the resource being cross referenced.
    /// <see href="http://purl.org/dita/ns#format"></see></summary>
    let format = _prefix "format"
    /// <summary>
    /// The frontmatter element contains the material that precedes the main body of a document. It may include items such as an abstract, a preface, and various types of book lists such as a toc, tablelist, or figurelist.
    /// <see href="http://purl.org/dita/ns#frontmatter"></see></summary>
    let frontmatter = _prefix "frontmatter"
    /// <summary>
    /// The href attribute is used by many elements to provide a reference to another DITA topic or map, to a specific element inside a DITA topic or map, or to an external Web page or other non-DITA resource.
    /// <see href="http://purl.org/dita/ns#href"></see></summary>
    let href = _prefix "href"
    /// <summary>
    /// The DITA identity attribute provides a mechanism for identifying content for linking.
    /// <see href="http://purl.org/dita/ns#id"></see></summary>
    let id = _prefix "id"
    /// <summary>
    /// Indicates the high-level task the audience for the topic is trying to accomplish.
    /// <see href="http://purl.org/dita/ns#job"></see></summary>
    let job = _prefix "job"
    /// <summary>
    /// The keydef element is a convenience element that is used to define keys without any of the other effects that occur when using a topicref element: no content is included in output, no title is included in the table of contents, and no linking or other relationships are defined.
    /// <see href="http://purl.org/dita/ns#keydef"></see></summary>
    let keydef = _prefix "keydef"
    /// <summary>
    /// The name of the key.
    /// <see href="http://purl.org/dita/ns#keyname"></see></summary>
    let keyname = _prefix "keyname"
    /// <summary>
    /// The keyref attribute provides an indirect, late-bound reference to topics, to collections of topics (ditabase), to maps, to referenceable portions of maps, to non-DITA documents, to external URIs, or to XML content contained within a key definition topic reference.
    /// <see href="http://purl.org/dita/ns#keyref"></see></summary>
    let keyref = _prefix "keyref"
    /// <summary>
    /// This attribute is used to reference content that can be reused.
    /// <see href="http://purl.org/dita/ns#keys"></see></summary>
    let keys = _prefix "keys"
    /// <summary>
    /// The keyword element identifies a keyword or token, such as a single value from an enumerated list, the name of a command or parameter, product name, or a lookup key for a message.
    /// <see href="http://purl.org/dita/ns#keyword"></see></summary>
    let keyword = _prefix "keyword"
    /// <summary>
    /// The language of the file as specified in @xml:lang, and supposed to conform to RFC 1766.
    /// <see href="http://purl.org/dita/ns#lang"></see></summary>
    let lang = _prefix "lang"
    /// <summary>
    /// The link element defines a relationship to another topic. Links are typically sorted when displayed based on their attributes, which define the type or role of the link's target in relation to the current topic.
    /// <see href="http://purl.org/dita/ns#link"></see></summary>
    let link = _prefix "link"
    /// <summary>
    /// The mainbooktitle element contains the primary title information for a book.
    /// <see href="http://purl.org/dita/ns#mainbooktitle"></see></summary>
    let mainbooktitle = _prefix "mainbooktitle"
    /// <summary>
    /// The mapref element is a convenience element that is equivalent to a &lt;topicref&gt; element with the format attribute set to 'ditamap'. The hierarchy of the referenced map is merged into the container map at the position of the reference, and the relationship tables of the child map are added to the parent map.
    /// <see href="http://purl.org/dita/ns#mapref"></see></summary>
    let mapref = _prefix "mapref"
    /// <summary>
    /// The notices element references a topic containing special notice information, for example, legal notices about supplementary copyrights and trademarks associated with the book.
    /// <see href="http://purl.org/dita/ns#notices"></see></summary>
    let notices = _prefix "notices"
    /// <summary>
    /// The othermeta element can be used to identify properties not otherwise included in &lt;metadata&gt; and to assign name/content values to those properties.
    /// <see href="http://purl.org/dita/ns#othermeta"></see></summary>
    let othermeta = _prefix "othermeta"
    /// <summary>
    /// The part element references a part topic or a map that references part topics for the book. A new part is started. Use &lt;part&gt; to divide a document's chapters into logical groupings. For example, in a document that contains both guide and reference information, you can define two parts, one containing the guide information and the other containing the reference information.
    /// <see href="http://purl.org/dita/ns#part"></see></summary>
    let part = _prefix "part"
    /// <summary>
    /// The permissions prolog element specifies the level of entitlement needed to access the content.
    /// <see href="http://purl.org/dita/ns#permissions"></see></summary>
    let permissions = _prefix "permissions"
    /// <summary>
    /// The platform metadata element contains a description of the operating system and/or hardware related to the product being described by the prodinfo element.
    /// <see href="http://purl.org/dita/ns#platform"></see></summary>
    let platform = _prefix "platform"
    /// <summary>
    /// Connects a DITA file with the product information that it is related to.
    /// <see href="http://purl.org/dita/ns#prodinfo"></see></summary>
    let prodinfo = _prefix "prodinfo"
    /// <summary>
    /// The prodname metadata element contains the name of the product that is supported by the information in this topic.
    /// <see href="http://purl.org/dita/ns#prodname"></see></summary>
    let prodname = _prefix "prodname"
    /// <summary>
    /// The publisher metadata element contains the name of the person, company, or organization responsible for making the content or subject of the topic available.
    /// <see href="http://purl.org/dita/ns#publisher"></see></summary>
    let publisher = _prefix "publisher"
    /// <summary>
    /// The revised element in the prolog is used to maintain tracking dates that are important in a topic development cycle, such as the last modification date, the original availability date, and the expiration date.
    /// <see href="http://purl.org/dita/ns#revised"></see></summary>
    let revised = _prefix "revised"
    /// <summary>
    /// The date when the information should be retired or refreshed, entered as YYYY-MM-DD, where YYYY is the year, MM is the month from 01 to 12, and DD is the day from 01-31.
    /// <see href="http://purl.org/dita/ns#revisedExpiry"></see></summary>
    let revisedExpiry = _prefix "revisedExpiry"
    /// <summary>
    /// The publication or general availability (GA) date, entered as YYYY-MM-DD, where YYYY is the year, MM is the month from 01 to 12, and DD is the day from 01-31.
    /// <see href="http://purl.org/dita/ns#revisedGolive"></see></summary>
    let revisedGolive = _prefix "revisedGolive"
    /// <summary>
    /// The scope attribute identifies the closeness of the relationship between the current document and the target resource.
    /// <see href="http://purl.org/dita/ns#scope"></see></summary>
    let scope = _prefix "scope"
    /// <summary>
    /// The searchtitle element is used to specify a title that should be displayed by search tools that locate the topic.
    /// <see href="http://purl.org/dita/ns#searchtitle"></see></summary>
    let searchtitle = _prefix "searchtitle"
    /// <summary>
    ///   <see href="http://purl.org/dita/ns#metadata"></see>
    /// </summary>
    let metadata = _prefix "metadata"
    /// <summary>
    /// The short description (shortdesc) element occurs between the topic title and the topic body, as the initial paragraph-like content of a topic, or it can be embedded in an abstract element.
    /// <see href="http://purl.org/dita/ns#shortdesc"></see></summary>
    let shortdesc = _prefix "shortdesc"
    /// <summary>
    /// The source element identifies a resource from which the present topic is derived, either completely or in part.
    /// <see href="http://purl.org/dita/ns#source"></see></summary>
    let source = _prefix "source"
    /// <summary>
    /// Topics can be nested.
    /// <see href="http://purl.org/dita/ns#subtopic"></see></summary>
    let subtopic = _prefix "subtopic"
    /// <summary>
    /// The text contained in the element
    /// <see href="http://purl.org/dita/ns#text"></see></summary>
    let text = _prefix "text"
    /// <summary>
    /// The title element contains a heading or label for the main parts of a topic, including the topic as a whole, its sections and examples, and its labelled content, such as figures and tables.
    /// <see href="http://purl.org/dita/ns#title"></see></summary>
    let title = _prefix "title"
    /// <summary>
    /// The vrm element contains information about a single product's version, modification, and release, to which the current topic applies.
    /// <see href="http://purl.org/dita/ns#vrmModification"></see></summary>
    let vrmModification = _prefix "vrmModification"
    /// <summary>
    /// The vrm element contains information about a single product's version, modification, and release, to which the current topic applies.
    /// <see href="http://purl.org/dita/ns#vrmRelease"></see></summary>
    let vrmRelease = _prefix "vrmRelease"
    /// <summary>
    /// The vrm element contains information about a single product's version, modification, and release, to which the current topic applies.
    /// <see href="http://purl.org/dita/ns#vrmVersion"></see></summary>
    let vrmVersion = _prefix "vrmVersion"
    /// <summary>
    /// Use the cross-reference (xref) element to link to a different location within the current topic, or a different topic within the same help system, or to external sources, such as Web pages, or to a location in another topic.
    /// <see href="http://purl.org/dita/ns#xref"></see></summary>
    let xref = _prefix "xref"
    /// <summary>
    /// xml-trace-filename, the original filename
    /// <see href="http://purl.org/dita/ns#xtrf"></see></summary>
    let xtrf = _prefix "xtrf"
