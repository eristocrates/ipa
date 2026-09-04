#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dita =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/dita/ns#" "dita"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Audience^^xsd:string</para>
    ///   <para>rdfs:comment : The audience metadata element indicates, through the value of its type attribute, the intended audience for a topic.</para>
    ///   <a href="http://purl.org/dita/ns#Audience">dita:Audience</a>
    /// </summary>
    let Audience = _prefixId.prefix "Audience"
    let Bookmap = _prefixId.prefix "Bookmap"
    let Coderef = _prefixId.prefix "Coderef"
    let Concept = _prefixId.prefix "Concept"
    let Conkeyref = _prefixId.prefix "Conkeyref"
    let Conref = _prefixId.prefix "Conref"
    /// <summary>
    ///   <para>rdfs:label : Doctype^^xsd:string</para>
    ///   <para>rdfs:comment : All the DITA document types.</para>
    ///   <a href="http://purl.org/dita/ns#Doctype">dita:Doctype</a>
    /// </summary>
    let Doctype = _prefixId.prefix "Doctype"
    let Image = _prefixId.prefix "Image"
    /// <summary>
    ///   <para>rdfs:label : Key^^xsd:string</para>
    ///   <para>rdfs:comment : The DITA key-reference mechanism provides a layer of abstraction so that the resources addressed by references can be defined globally at the DITA map level instead of locally in each topic.</para>
    ///   <a href="http://purl.org/dita/ns#Key">dita:Key</a>
    /// </summary>
    let Key = _prefixId.prefix "Key"
    let Keydef = _prefixId.prefix "Keydef"
    let Keyref = _prefixId.prefix "Keyref"
    /// <summary>
    ///   <para>rdfs:label : Keyword^^xsd:string</para>
    ///   <para>rdfs:comment : The keyword element identifies a keyword or token, such as a single value from an enumerated list, the name of a command or parameter, product name, or a lookup key for a message.</para>
    ///   <a href="http://purl.org/dita/ns#Keyword">dita:Keyword</a>
    /// </summary>
    let Keyword = _prefixId.prefix "Keyword"
    let LearningAssessment = _prefixId.prefix "LearningAssessment"
    let LearningBase = _prefixId.prefix "LearningBase"
    let LearningContent = _prefixId.prefix "LearningContent"
    let LearningContentComponentRef = _prefixId.prefix "LearningContentComponentRef"
    let LearningContentRef = _prefixId.prefix "LearningContentRef"
    let LearningObject = _prefixId.prefix "LearningObject"
    let LearningOverview = _prefixId.prefix "LearningOverview"
    let LearningOverviewRef = _prefixId.prefix "LearningOverviewRef"
    let LearningPlan = _prefixId.prefix "LearningPlan"
    let LearningPlanRef = _prefixId.prefix "LearningPlanRef"
    let LearningPostAssessmentRef = _prefixId.prefix "LearningPostAssessmentRef"
    let LearningPreAssessmentRef = _prefixId.prefix "LearningPreAssessmentRef"
    let LearningSummary = _prefixId.prefix "LearningSummary"
    let LearningSummaryRef = _prefixId.prefix "LearningSummaryRef"
    let Link = _prefixId.prefix "Link"
    let Map = _prefixId.prefix "Map"
    let Mapref = _prefixId.prefix "Mapref"
    let Parmname = _prefixId.prefix "Parmname"
    /// <summary>
    ///   <para>rdfs:label : Prodinfo^^xsd:string</para>
    ///   <para>rdfs:comment : The prodinfo metadata element contains information about the product or products that are the subject matter of the current topic.</para>
    ///   <a href="http://purl.org/dita/ns#Prodinfo">dita:Prodinfo</a>
    /// </summary>
    let Prodinfo = _prefixId.prefix "Prodinfo"
    let Reference = _prefixId.prefix "Reference"
    /// <summary>
    ///   <para>rdfs:label : DITA base reference object</para>
    ///   <para>rdfs:comment : The DITA reference object is used to link, fetch or push content in relation with another file or object.</para>
    ///   <a href="http://purl.org/dita/ns#ReferenceObject">dita:ReferenceObject</a>
    /// </summary>
    let ReferenceObject = _prefixId.prefix "ReferenceObject"
    let Task = _prefixId.prefix "Task"
    let Topic = _prefixId.prefix "Topic"
    let Topicref = _prefixId.prefix "Topicref"
    let Varname = _prefixId.prefix "Varname"
    let Xref = _prefixId.prefix "Xref"
    /// <summary>
    ///   <para>rdfs:label : audience^^xsd:string</para>
    ///   <para>rdfs:comment : The audience metadata element indicates, through the value of its type attribute, the intended audience for a topic.</para>
    ///   <a href="http://purl.org/dita/ns#audience">dita:audience</a>
    /// </summary>
    let audience = _prefixId.prefix "audience"
    /// <summary>
    ///   <para>rdfs:label : type^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the kind of person for whom the content of the topic is intended. Note that this differs from the type attribute on many other DITA elements.</para>
    ///   <a href="http://purl.org/dita/ns#audienceType">dita:audienceType</a>
    /// </summary>
    let audienceType = _prefixId.prefix "audienceType"
    /// <summary>
    ///   <para>rdfs:label : author^^xsd:string</para>
    ///   <para>rdfs:comment : The author metadata element contains the name of the topic's author.</para>
    ///   <a href="http://purl.org/dita/ns#author">dita:author</a>
    /// </summary>
    let author = _prefixId.prefix "author"
    let backmatter = _prefixId.prefix "backmatter"
    /// <summary>
    ///   <para>rdfs:label : booklibrary^^xsd:string</para>
    ///   <para>rdfs:comment : The booklibrary element contains the library information for a book. Library entries contain information about the series, library, or collection of documents to which the book belongs. </para>
    ///   <a href="http://purl.org/dita/ns#booklibrary">dita:booklibrary</a>
    /// </summary>
    let booklibrary = _prefixId.prefix "booklibrary"
    /// <summary>
    ///   <para>rdfs:label : booktitlealt^^xsd:string</para>
    ///   <para>rdfs:comment : The booktitlealt element contains the alternative title, subtitle, or short title for a book. It may be specialized into a specific element for those or other purposes.</para>
    ///   <a href="http://purl.org/dita/ns#booktitlealt">dita:booktitlealt</a>
    /// </summary>
    let booktitlealt = _prefixId.prefix "booktitlealt"
    /// <summary>
    ///   <para>rdfs:label : category^^xsd:string</para>
    ///   <para>rdfs:comment : The category element represents any category by which a topic might be classified for retrieval or navigation.</para>
    ///   <a href="http://purl.org/dita/ns#category">dita:category</a>
    /// </summary>
    let category = _prefixId.prefix "category"
    let chapter = _prefixId.prefix "chapter"
    /// <summary>
    ///   <para>rdfs:label : class^^xsd:string</para>
    ///   <para>rdfs:comment : Attribute used to store the class attribute and identify the nature of the Conref/Conkeyref.</para>
    ///   <a href="http://purl.org/dita/ns#class">dita:class</a>
    /// </summary>
    let class_ = _prefixId.prefix "class"
    /// <summary>
    ///   <para>rdfs:label : conkeyref^^xsd:string</para>
    ///   <para>rdfs:comment : The conkeyref attribute provides an indirect content reference to topic elements, map elements, or elements within maps or topics.</para>
    ///   <a href="http://purl.org/dita/ns#conkeyref">dita:conkeyref</a>
    /// </summary>
    let conkeyref = _prefixId.prefix "conkeyref"
    /// <summary>
    ///   <para>rdfs:label : conref^^xsd:string</para>
    ///   <para>rdfs:comment : This attribute is used to reference content that can be reused.</para>
    ///   <a href="http://purl.org/dita/ns#conref">dita:conref</a>
    /// </summary>
    let conref = _prefixId.prefix "conref"
    /// <summary>
    ///   <para>rdfs:label : copyright^^xsd:string</para>
    ///   <para>rdfs:comment : The copyright element specifies legal ownership of the content.</para>
    ///   <a href="http://purl.org/dita/ns#copyright">dita:copyright</a>
    /// </summary>
    let copyright = _prefixId.prefix "copyright"
    let created = _prefixId.prefix "created"
    /// <summary>
    ///   <para>rdfs:label : created (expiry)^^xsd:string</para>
    ///   <para>rdfs:comment : The date when the information should be retired or refreshed, entered as YYYY-MM-DD, where YYYY is the year, MM is the month from 01 to 12, and DD is the day from 01-31.</para>
    ///   <a href="http://purl.org/dita/ns#createdExpiry">dita:createdExpiry</a>
    /// </summary>
    let createdExpiry = _prefixId.prefix "createdExpiry"
    /// <summary>
    ///   <para>rdfs:label : created (golive)^^xsd:string</para>
    ///   <para>rdfs:comment : The publication or general availability (GA) date, entered as YYYY-MM-DD, where YYYY is the year, MM is the month from 01 to 12, and DD is the day from 01-31.</para>
    ///   <a href="http://purl.org/dita/ns#createdGolive">dita:createdGolive</a>
    /// </summary>
    let createdGolive = _prefixId.prefix "createdGolive"
    /// <summary>
    ///   <para>rdfs:label : element^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that the file contains the target element.</para>
    ///   <a href="http://purl.org/dita/ns#element">dita:element</a>
    /// </summary>
    let element = _prefixId.prefix "element"
    /// <summary>
    ///   <para>rdfs:label : experiencelevel^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the level of experience the audience is assumed to possess.</para>
    ///   <a href="http://purl.org/dita/ns#experiencelevel">dita:experiencelevel</a>
    /// </summary>
    let experiencelevel = _prefixId.prefix "experiencelevel"
    /// <summary>
    ///   <para>rdfs:label : format^^xsd:string</para>
    ///   <para>rdfs:comment : The format attribute identifies the format of the resource being cross referenced.</para>
    ///   <a href="http://purl.org/dita/ns#format">dita:format</a>
    /// </summary>
    let format = _prefixId.prefix "format"
    let frontmatter = _prefixId.prefix "frontmatter"
    /// <summary>
    ///   <para>rdfs:label : href^^xsd:string</para>
    ///   <para>rdfs:comment : The href attribute is used by many elements to provide a reference to another DITA topic or map, to a specific element inside a DITA topic or map, or to an external Web page or other non-DITA resource.</para>
    ///   <a href="http://purl.org/dita/ns#href">dita:href</a>
    /// </summary>
    let href = _prefixId.prefix "href"
    /// <summary>
    ///   <para>rdfs:label : id^^xsd:string</para>
    ///   <para>rdfs:comment : The DITA identity attribute provides a mechanism for identifying content for linking. </para>
    ///   <a href="http://purl.org/dita/ns#id">dita:id</a>
    /// </summary>
    let id = _prefixId.prefix "id"
    /// <summary>
    ///   <para>rdfs:label : job^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the high-level task the audience for the topic is trying to accomplish.</para>
    ///   <a href="http://purl.org/dita/ns#job">dita:job</a>
    /// </summary>
    let job = _prefixId.prefix "job"
    let keydef = _prefixId.prefix "keydef"
    /// <summary>
    ///   <para>rdfs:label : keyname^^xsd:string</para>
    ///   <para>rdfs:comment : The name of the key.^^xsd:string</para>
    ///   <a href="http://purl.org/dita/ns#keyname">dita:keyname</a>
    /// </summary>
    let keyname = _prefixId.prefix "keyname"
    /// <summary>
    ///   <para>rdfs:label : keyref^^xsd:string</para>
    ///   <para>rdfs:comment : The keyref attribute provides an indirect, late-bound reference to topics, to collections of topics (ditabase), to maps, to referenceable portions of maps, to non-DITA documents, to external URIs, or to XML content contained within a key definition topic reference.</para>
    ///   <a href="http://purl.org/dita/ns#keyref">dita:keyref</a>
    /// </summary>
    let keyref = _prefixId.prefix "keyref"
    /// <summary>
    ///   <para>rdfs:label : keys^^xsd:string</para>
    ///   <para>rdfs:comment : This attribute is used to reference content that can be reused.</para>
    ///   <a href="http://purl.org/dita/ns#keys">dita:keys</a>
    /// </summary>
    let keys = _prefixId.prefix "keys"
    /// <summary>
    ///   <para>rdfs:label : keyword^^xsd:string</para>
    ///   <para>rdfs:comment : The keyword element identifies a keyword or token, such as a single value from an enumerated list, the name of a command or parameter, product name, or a lookup key for a message.</para>
    ///   <a href="http://purl.org/dita/ns#keyword">dita:keyword</a>
    /// </summary>
    let keyword = _prefixId.prefix "keyword"
    /// <summary>
    ///   <para>rdfs:label : language^^xsd:string</para>
    ///   <para>rdfs:comment : The language of the file as specified in @xml:lang, and supposed to conform to RFC 1766.^^xsd:string</para>
    ///   <a href="http://purl.org/dita/ns#lang">dita:lang</a>
    /// </summary>
    let lang = _prefixId.prefix "lang"
    let link = _prefixId.prefix "link"
    /// <summary>
    ///   <para>rdfs:label : mainbooktitle^^xsd:string</para>
    ///   <para>rdfs:comment : The mainbooktitle element contains the primary title information for a book.</para>
    ///   <a href="http://purl.org/dita/ns#mainbooktitle">dita:mainbooktitle</a>
    /// </summary>
    let mainbooktitle = _prefixId.prefix "mainbooktitle"
    let mapref = _prefixId.prefix "mapref"
    let metadata = _prefixId.prefix "metadata"
    let notices = _prefixId.prefix "notices"
    /// <summary>
    ///   <para>rdfs:label : othermeta^^xsd:string</para>
    ///   <para>rdfs:comment : The othermeta element can be used to identify properties not otherwise included in &lt;metadata&gt; and to assign name/content values to those properties.</para>
    ///   <a href="http://purl.org/dita/ns#othermeta">dita:othermeta</a>
    /// </summary>
    let othermeta = _prefixId.prefix "othermeta"
    let part = _prefixId.prefix "part"
    /// <summary>
    ///   <para>rdfs:label : permissions	^^xsd:string</para>
    ///   <para>rdfs:comment : The permissions prolog element specifies the level of entitlement needed to access the content.</para>
    ///   <a href="http://purl.org/dita/ns#permissions">dita:permissions</a>
    /// </summary>
    let permissions = _prefixId.prefix "permissions"
    /// <summary>
    ///   <para>rdfs:label : platform^^xsd:string</para>
    ///   <para>rdfs:comment : The platform metadata element contains a description of the operating system and/or hardware related to the product being described by the prodinfo element.</para>
    ///   <a href="http://purl.org/dita/ns#platform">dita:platform</a>
    /// </summary>
    let platform = _prefixId.prefix "platform"
    /// <summary>
    ///   <para>rdfs:label : prodinfo^^xsd:string</para>
    ///   <para>rdfs:comment : Connects a DITA file with the product information that it is related to.</para>
    ///   <a href="http://purl.org/dita/ns#prodinfo">dita:prodinfo</a>
    /// </summary>
    let prodinfo = _prefixId.prefix "prodinfo"
    /// <summary>
    ///   <para>rdfs:label : prodname^^xsd:string</para>
    ///   <para>rdfs:comment : The prodname metadata element contains the name of the product that is supported by the information in this topic.</para>
    ///   <a href="http://purl.org/dita/ns#prodname">dita:prodname</a>
    /// </summary>
    let prodname = _prefixId.prefix "prodname"
    /// <summary>
    ///   <para>rdfs:label : publisher^^xsd:string</para>
    ///   <para>rdfs:comment : The publisher metadata element contains the name of the person, company, or organization responsible for making the content or subject of the topic available.</para>
    ///   <a href="http://purl.org/dita/ns#publisher">dita:publisher</a>
    /// </summary>
    let publisher = _prefixId.prefix "publisher"
    /// <summary>
    ///   <para>rdfs:label : referenceObject^^xsd:string</para>
    ///   <para>rdfs:comment : Describes a reference object that is part of a DITA file.</para>
    ///   <a href="http://purl.org/dita/ns#referenceObject">dita:referenceObject</a>
    /// </summary>
    let referenceObject = _prefixId.prefix "referenceObject"
    let revised = _prefixId.prefix "revised"
    /// <summary>
    ///   <para>rdfs:label : revised (expiry)^^xsd:string</para>
    ///   <para>rdfs:comment : The date when the information should be retired or refreshed, entered as YYYY-MM-DD, where YYYY is the year, MM is the month from 01 to 12, and DD is the day from 01-31.</para>
    ///   <a href="http://purl.org/dita/ns#revisedExpiry">dita:revisedExpiry</a>
    /// </summary>
    let revisedExpiry = _prefixId.prefix "revisedExpiry"
    /// <summary>
    ///   <para>rdfs:label : revised (golive)^^xsd:string</para>
    ///   <para>rdfs:comment : The publication or general availability (GA) date, entered as YYYY-MM-DD, where YYYY is the year, MM is the month from 01 to 12, and DD is the day from 01-31.</para>
    ///   <a href="http://purl.org/dita/ns#revisedGolive">dita:revisedGolive</a>
    /// </summary>
    let revisedGolive = _prefixId.prefix "revisedGolive"
    /// <summary>
    ///   <para>rdfs:label : scope^^xsd:string</para>
    ///   <para>rdfs:comment : The scope attribute identifies the closeness of the relationship between the current document and the target resource.</para>
    ///   <a href="http://purl.org/dita/ns#scope">dita:scope</a>
    /// </summary>
    let scope = _prefixId.prefix "scope"
    /// <summary>
    ///   <para>rdfs:label : searchtitle^^xsd:string</para>
    ///   <para>rdfs:comment : The searchtitle element is used to specify a title that should be displayed by search tools that locate the topic.</para>
    ///   <a href="http://purl.org/dita/ns#searchtitle">dita:searchtitle</a>
    /// </summary>
    let searchtitle = _prefixId.prefix "searchtitle"
    /// <summary>
    ///   <para>rdfs:label : shortdesc^^xsd:string</para>
    ///   <para>rdfs:comment : The short description (shortdesc) element occurs between the topic title and the topic body, as the initial paragraph-like content of a topic, or it can be embedded in an abstract element.</para>
    ///   <a href="http://purl.org/dita/ns#shortdesc">dita:shortdesc</a>
    /// </summary>
    let shortdesc = _prefixId.prefix "shortdesc"
    /// <summary>
    ///   <para>rdfs:label : source^^xsd:string</para>
    ///   <para>rdfs:comment : The source element identifies a resource from which the present topic is derived, either completely or in part.</para>
    ///   <a href="http://purl.org/dita/ns#source">dita:source</a>
    /// </summary>
    let source = _prefixId.prefix "source"
    /// <summary>
    ///   <para>rdfs:label : subtopic^^xsd:string</para>
    ///   <para>rdfs:comment : Topics can be nested.</para>
    ///   <a href="http://purl.org/dita/ns#subtopic">dita:subtopic</a>
    /// </summary>
    let subtopic = _prefixId.prefix "subtopic"
    /// <summary>
    ///   <para>rdfs:comment : The text contained in the element</para>
    ///   <a href="http://purl.org/dita/ns#text">dita:text</a>
    /// </summary>
    let text = _prefixId.prefix "text"
    /// <summary>
    ///   <para>rdfs:label : title^^xsd:string</para>
    ///   <para>rdfs:comment : The title element contains a heading or label for the main parts of a topic, including the topic as a whole, its sections and examples, and its labelled content, such as figures and tables.</para>
    ///   <a href="http://purl.org/dita/ns#title">dita:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    let topicref = _prefixId.prefix "topicref"
    /// <summary>
    ///   <para>rdfs:label : vrm Modification^^xsd:string</para>
    ///   <para>rdfs:comment : The vrm element contains information about a single product's version, modification, and release, to which the current topic applies.</para>
    ///   <a href="http://purl.org/dita/ns#vrmModification">dita:vrmModification</a>
    /// </summary>
    let vrmModification = _prefixId.prefix "vrmModification"
    /// <summary>
    ///   <para>rdfs:label : vrm Release^^xsd:string</para>
    ///   <para>rdfs:comment : The vrm element contains information about a single product's version, modification, and release, to which the current topic applies.</para>
    ///   <a href="http://purl.org/dita/ns#vrmRelease">dita:vrmRelease</a>
    /// </summary>
    let vrmRelease = _prefixId.prefix "vrmRelease"
    /// <summary>
    ///   <para>rdfs:label : vrm Version^^xsd:string</para>
    ///   <para>rdfs:comment : The vrm element contains information about a single product's version, modification, and release, to which the current topic applies.</para>
    ///   <a href="http://purl.org/dita/ns#vrmVersion">dita:vrmVersion</a>
    /// </summary>
    let vrmVersion = _prefixId.prefix "vrmVersion"
    let xref = _prefixId.prefix "xref"
    /// <summary>
    ///   <para>rdfs:label : xtrf^^xsd:string</para>
    ///   <para>rdfs:comment : xml-trace-filename, the original filename</para>
    ///   <a href="http://purl.org/dita/ns#xtrf">dita:xtrf</a>
    /// </summary>
    let xtrf = _prefixId.prefix "xtrf"
