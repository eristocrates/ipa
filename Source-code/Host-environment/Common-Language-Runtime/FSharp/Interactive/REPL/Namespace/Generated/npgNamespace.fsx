#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module npg =
    let _prefixId = PrefixId.fromNamespaceLabel "http://ns.nature.com/terms/" "npg"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>skos:prefLabel : Abstract</para>
    ///   <para>skos:definition : The :Abstract class represents a brief description of a scholarly work, usually author generated. Instances of :Abstract normally do not exist in isolation, but are linked to a :Document instance (of which they provide a summary).</para>
    ///   <a href="http://ns.nature.com/terms/Abstract">npg:Abstract</a>
    /// </summary>
    let Abstract = _prefixId.prefix "Abstract"
    /// <summary>
    ///   <para>skos:prefLabel : Agent</para>
    ///   <para>skos:definition : The :Agent class groups together all entities that can be the subject of an action. These can be single persons (:Person), or groups of people organised as a legal entity (:Organization).</para>
    ///   <a href="http://ns.nature.com/terms/Agent">npg:Agent</a>
    /// </summary>
    let Agent = _prefixId.prefix "Agent"
    /// <summary>
    ///   <para>skos:prefLabel : Aggregation Event</para>
    ///   <para>skos:definition : The :AggregationEvent class groups together all events related to the construction of a publication.</para>
    ///   <a href="http://ns.nature.com/terms/AggregationEvent">npg:AggregationEvent</a>
    /// </summary>
    let AggregationEvent = _prefixId.prefix "AggregationEvent"
    /// <summary>
    ///   <para>skos:prefLabel : Article</para>
    ///   <para>skos:note : With reference to the FRBR model [http://www.ifla.org/publications/functional-requirements-for-bibliographic-records], an :Article can be mapped directly to the frbr:Expression concept. It is worth noting though that within the NPG core ontology we do not have any notion of a frbr:Work. Hence multiple versions of the same article (e.g. language translations, or revisions) are characterised as such simply by means of some relationship.</para>
    ///   <para>skos:definition : The :Article class represents a scholarly work normally published as an item of a serial publication. In particular, this concept refers to the abstract notion of an article, rather than any of its realisations after it becomes embodied via a physical medium.</para>
    ///   <a href="http://ns.nature.com/terms/Article">npg:Article</a>
    /// </summary>
    let Article = _prefixId.prefix "Article"
    /// <summary>
    ///   <para>skos:prefLabel : Article Type</para>
    ///   <para>skos:definition : The :ArticleType class represents the various kinds of publication which can be used to index and group content published by Macmillan Science and Education. The instances of :ArticleType are organised hierarchically using the SKOS vocabulary.</para>
    ///   <a href="http://ns.nature.com/terms/ArticleType">npg:ArticleType</a>
    /// </summary>
    let ArticleType = _prefixId.prefix "ArticleType"
    /// <summary>
    ///   <para>skos:prefLabel : Asset</para>
    ///   <para>skos:definition : The :Asset class groups together all physical entities which can be stored in digital systems.</para>
    ///   <a href="http://ns.nature.com/terms/Asset">npg:Asset</a>
    /// </summary>
    let Asset = _prefixId.prefix "Asset"
    /// <summary>
    ///   <para>skos:prefLabel : Binary Asset</para>
    ///   <para>skos:definition : The :BinaryAsset class represents the physical rendition of a generic binary object.</para>
    ///   <a href="http://ns.nature.com/terms/BinaryAsset">npg:BinaryAsset</a>
    /// </summary>
    let BinaryAsset = _prefixId.prefix "BinaryAsset"
    /// <summary>
    ///   <para>skos:prefLabel : Blob Asset</para>
    ///   <para>skos:definition : The :BlobAsset class groups together all assets used to store blobs - i.e. documents, images, or other media objects - within digital systems.</para>
    ///   <a href="http://ns.nature.com/terms/BlobAsset">npg:BlobAsset</a>
    /// </summary>
    let BlobAsset = _prefixId.prefix "BlobAsset"
    /// <summary>
    ///   <para>skos:prefLabel : Blog</para>
    ///   <para>skos:definition : The :Blog class represents an informal serial publication.</para>
    ///   <a href="http://ns.nature.com/terms/Blog">npg:Blog</a>
    /// </summary>
    let Blog = _prefixId.prefix "Blog"
    /// <summary>
    ///   <para>skos:prefLabel : Collection</para>
    ///   <para>skos:definition : The :Collection class represents a group of documents which are published (or republished) as part of a new composite publication. Often these documents have been published elsewhere, but since they share a common theme or belong to an identifiable narrative it is of interest to publish them again within a different container. (See also :Issue.)</para>
    ///   <a href="http://ns.nature.com/terms/Collection">npg:Collection</a>
    /// </summary>
    let Collection = _prefixId.prefix "Collection"
    /// <summary>
    ///   <para>skos:prefLabel : Component</para>
    ///   <para>skos:definition : The :Component class groups together all individuals that normally come into existence as part of a :Document.</para>
    ///   <a href="http://ns.nature.com/terms/Component">npg:Component</a>
    /// </summary>
    let Component = _prefixId.prefix "Component"
    /// <summary>
    ///   <para>skos:prefLabel : Concept</para>
    ///   <para>skos:definition : The :Concept class groups together all individuals which do not exist in the physical world (i.e. have no extension in spacetime).</para>
    ///   <a href="http://ns.nature.com/terms/Concept">npg:Concept</a>
    /// </summary>
    let Concept = _prefixId.prefix "Concept"
    /// <summary>
    ///   <para>skos:prefLabel : Contributor</para>
    ///   <para>skos:definition : The :Contributor class represents a document component detailing a contributor (personal or corporate) to the work being published. This class is disjoint from the :Agent class. Hence a :Contributor instance can be described as the name used to refer to a person or organisation in the context of a publication.</para>
    ///   <a href="http://ns.nature.com/terms/Contributor">npg:Contributor</a>
    /// </summary>
    let Contributor = _prefixId.prefix "Contributor"
    /// <summary>
    ///   <para>skos:prefLabel : Dataset</para>
    ///   <para>skos:note : We are currently using this class for RDF datasets.</para>
    ///   <para>skos:definition : The :Dataset class represents a collection of related sets of information modelled in a known way and stored in a computer system.</para>
    ///   <a href="http://ns.nature.com/terms/Dataset">npg:Dataset</a>
    /// </summary>
    let Dataset = _prefixId.prefix "Dataset"
    /// <summary>
    ///   <para>skos:prefLabel : Document</para>
    ///   <para>skos:definition : The :Document class groups together all publications which were created to be distributed and consumed as individual, self-contained entities.</para>
    ///   <a href="http://ns.nature.com/terms/Document">npg:Document</a>
    /// </summary>
    let Document = _prefixId.prefix "Document"
    /// <summary>
    ///   <para>skos:prefLabel : Event</para>
    ///   <para>skos:definition : The :Event class groups together events of varying granularity. Events differ from :Concept entities because they have an extension in time; they differ from :Asset entities because they do not have an extension in space.</para>
    ///   <a href="http://ns.nature.com/terms/Event">npg:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>skos:prefLabel : Figure</para>
    ///   <para>skos:definition : The :Figure class represents a numbered and captioned image within a publication. This image typically results as a direct outcome of the work described in the publication.</para>
    ///   <a href="http://ns.nature.com/terms/Figure">npg:Figure</a>
    /// </summary>
    let Figure = _prefixId.prefix "Figure"
    /// <summary>
    ///   <para>skos:prefLabel : Graph</para>
    ///   <para>skos:note : Each Graph instance is associated with instances of a particular class. For example, the 'npgg:articles' :Graph instance is a named graph which contains all the instances of the :Article class. The :Graph instances themselves are then used to describe the RDF graph, providing sometimes known as an RDF annotation. This may furnish various kinds of information about the RDF graph: provenance, rights, metrics, validation reports, etc.</para>
    ///   <para>skos:definition : The :Graph class represents a collection of related sets of information modelled in RDF and organized as a named graph.</para>
    ///   <a href="http://ns.nature.com/terms/Graph">npg:Graph</a>
    /// </summary>
    let Graph = _prefixId.prefix "Graph"
    /// <summary>
    ///   <para>skos:prefLabel : Illustration</para>
    ///   <para>skos:definition : The :Illustration class represents a numbered and captioned image within a publication. This image typically illustrates a point about the work described in the publication.</para>
    ///   <a href="http://ns.nature.com/terms/Illustration">npg:Illustration</a>
    /// </summary>
    let Illustration = _prefixId.prefix "Illustration"
    /// <summary>
    ///   <para>skos:prefLabel : Image</para>
    ///   <para>skos:definition : The :Image class represents a graphical element within a publication.</para>
    ///   <a href="http://ns.nature.com/terms/Image">npg:Image</a>
    /// </summary>
    let Image = _prefixId.prefix "Image"
    /// <summary>
    ///   <para>skos:prefLabel : Image Asset</para>
    ///   <para>skos:definition : The :ImageAsset class represents the physical rendition of an image asset in an encoded format.</para>
    ///   <a href="http://ns.nature.com/terms/ImageAsset">npg:ImageAsset</a>
    /// </summary>
    let ImageAsset = _prefixId.prefix "ImageAsset"
    /// <summary>
    ///   <para>skos:prefLabel : Issue</para>
    ///   <para>skos:definition : The :Issue class represents an aggregate object which is published periodically as part of a :Serial and is normally composed by one or more articles. (See also :Collection.)</para>
    ///   <a href="http://ns.nature.com/terms/Issue">npg:Issue</a>
    /// </summary>
    let Issue = _prefixId.prefix "Issue"
    /// <summary>
    ///   <para>skos:prefLabel : Item</para>
    ///   <para>skos:definition : The :Item class represents the state of a document after this has been added to a :Collection by someone, at a specific time, and within a specific sequence.</para>
    ///   <a href="http://ns.nature.com/terms/Item">npg:Item</a>
    /// </summary>
    let Item = _prefixId.prefix "Item"
    /// <summary>
    ///   <para>skos:prefLabel : Journal</para>
    ///   <para>skos:definition : The :Journal class represents a scholarly serial publication, considered from both the scholarly and the commercial perspectives. Thus a journal is more than the sum of its publications (i.e. the set of all the :Issue instances it has published); it is an entity characterised by many properties, e.g. its founders, its impact factor, etc.</para>
    ///   <a href="http://ns.nature.com/terms/Journal">npg:Journal</a>
    /// </summary>
    let Journal = _prefixId.prefix "Journal"
    /// <summary>
    ///   <para>skos:prefLabel : KnowledgeBase</para>
    ///   <para>skos:note : Differently from datasets, knowledge-bases refer to a composite dataset intended to be used as a consistent whole.</para>
    ///   <para>skos:definition : The :KnowledgeBase class represents a collection of related sets of information modelled in RDF and consisting of various objects, e.g. one or more graphs, other RDF datasets etc.</para>
    ///   <a href="http://ns.nature.com/terms/KnowledgeBase">npg:KnowledgeBase</a>
    /// </summary>
    let KnowledgeBase = _prefixId.prefix "KnowledgeBase"
    /// <summary>
    ///   <para>skos:prefLabel : Organization</para>
    ///   <para>skos:definition : The :Organization class represents an organised body of people normally having a legal status.</para>
    ///   <a href="http://ns.nature.com/terms/Organization">npg:Organization</a>
    /// </summary>
    let Organization = _prefixId.prefix "Organization"
    /// <summary>
    ///   <para>skos:prefLabel : Pdf Asset</para>
    ///   <para>skos:definition : The :PdfAsset class represents the physical rendition of a document asset in PDF format.</para>
    ///   <a href="http://ns.nature.com/terms/PdfAsset">npg:PdfAsset</a>
    /// </summary>
    let PdfAsset = _prefixId.prefix "PdfAsset"
    /// <summary>
    ///   <para>skos:prefLabel : Person</para>
    ///   <para>skos:definition : The :Person class represents a single person entity.</para>
    ///   <a href="http://ns.nature.com/terms/Person">npg:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>skos:prefLabel : Publication</para>
    ///   <para>skos:definition : The :Publication class groups together all individuals (or part of) created as the result of the publishing process. Note that we are not referring here to the physical artefacts, but just their abstract counterparts.</para>
    ///   <a href="http://ns.nature.com/terms/Publication">npg:Publication</a>
    /// </summary>
    let Publication = _prefixId.prefix "Publication"
    /// <summary>
    ///   <para>skos:prefLabel : Publication Event</para>
    ///   <para>skos:definition : The :PublicationEvent class groups together events that happen within the publishing process, broadly conceived. For example, the submission of an article, or the acceptance of a paper.</para>
    ///   <a href="http://ns.nature.com/terms/PublicationEvent">npg:PublicationEvent</a>
    /// </summary>
    let PublicationEvent = _prefixId.prefix "PublicationEvent"
    /// <summary>
    ///   <para>skos:prefLabel : Publish Event</para>
    ///   <para>skos:note : In order to differentiate these events further, the :PublishState vocabulary is used.</para>
    ///   <para>skos:definition : The :PublishEvent class represents events related to the publication of a document. This is intended in a strict sense, i.e. the time when a publication is made 'public'.</para>
    ///   <a href="http://ns.nature.com/terms/PublishEvent">npg:PublishEvent</a>
    /// </summary>
    let PublishEvent = _prefixId.prefix "PublishEvent"
    /// <summary>
    ///   <para>skos:prefLabel : Publish State</para>
    ///   <para>skos:definition : The :PublishState class provides a categorisation of the possible states a document may have after it has been published. For example, whether it’s an 'Advanced online publication' or an 'Issue publication'.  This categorisation is implemented as a SKOS vocabulary.</para>
    ///   <a href="http://ns.nature.com/terms/PublishState">npg:PublishState</a>
    /// </summary>
    let PublishState = _prefixId.prefix "PublishState"
    /// <summary>
    ///   <para>skos:prefLabel : Publisher</para>
    ///   <para>skos:definition : The :Publisher class represents organizations involved in the publishing business.</para>
    ///   <a href="http://ns.nature.com/terms/Publisher">npg:Publisher</a>
    /// </summary>
    let Publisher = _prefixId.prefix "Publisher"
    /// <summary>
    ///   <para>skos:prefLabel : Review Event</para>
    ///   <para>skos:definition : The :ReviewEvent class models events related to the reviewing of a document (before its publication). In order to differentiate these events further, the :ReviewState vocabulary is used.</para>
    ///   <a href="http://ns.nature.com/terms/ReviewEvent">npg:ReviewEvent</a>
    /// </summary>
    let ReviewEvent = _prefixId.prefix "ReviewEvent"
    /// <summary>
    ///   <para>skos:prefLabel : Review State</para>
    ///   <para>skos:definition : The :ReviewState class provides a categorisation of the possible states a document may have as a result of a reviewing process. For example, whether it’s been 'Received' or 'Accepted'.  This categorisation is implemented as a SKOS vocabulary.</para>
    ///   <a href="http://ns.nature.com/terms/ReviewState">npg:ReviewState</a>
    /// </summary>
    let ReviewState = _prefixId.prefix "ReviewState"
    /// <summary>
    ///   <para>skos:prefLabel : Section</para>
    ///   <para>skos:definition : The :Section class represents a part of a document.</para>
    ///   <a href="http://ns.nature.com/terms/Section">npg:Section</a>
    /// </summary>
    let Section = _prefixId.prefix "Section"
    /// <summary>
    ///   <para>skos:prefLabel : Serial</para>
    ///   <para>skos:definition : The :Serial class represents publications which appear in a new edition on a regular schedule. For example, a journal, a magazine or a blog. The :PublishEvent class is used to provide more details about the time, place and other contextual information relevant to when a new edition gets published.</para>
    ///   <a href="http://ns.nature.com/terms/Serial">npg:Serial</a>
    /// </summary>
    let Serial = _prefixId.prefix "Serial"
    /// <summary>
    ///   <para>skos:prefLabel : Severity Level</para>
    ///   <para>skos:definition : The :SeverityLevel class represents a system status. The syslog standard (RFC 5424) for computer message logging is used to provide a reference set of states. This categorisation is implemented as a SKOS concept scheme.</para>
    ///   <a href="http://ns.nature.com/terms/SeverityLevel">npg:SeverityLevel</a>
    /// </summary>
    let SeverityLevel = _prefixId.prefix "SeverityLevel"
    /// <summary>
    ///   <para>skos:prefLabel : Subject</para>
    ///   <para>skos:definition : The :Subject class represents a topic, field of study or research area which can be used to categorise the contents of a publication. The instances of :Subject are organised hierarchically using the SKOS vocabulary.</para>
    ///   <a href="http://ns.nature.com/terms/Subject">npg:Subject</a>
    /// </summary>
    let Subject = _prefixId.prefix "Subject"
    /// <summary>
    ///   <para>skos:prefLabel : Summary</para>
    ///   <para>skos:definition : The :Summary class represents a brief description of a scholarly work, usually editorially generated.</para>
    ///   <a href="http://ns.nature.com/terms/Summary">npg:Summary</a>
    /// </summary>
    let Summary = _prefixId.prefix "Summary"
    /// <summary>
    ///   <para>skos:prefLabel : Summary Type</para>
    ///   <para>skos:definition : The :SummaryType class represents an instance from  a categorisation of types of :Summary. For example, 'Long Summary', 'Short Summary', etc. This categorisation is implemented as a SKOS concept scheme.</para>
    ///   <a href="http://ns.nature.com/terms/SummaryType">npg:SummaryType</a>
    /// </summary>
    let SummaryType = _prefixId.prefix "SummaryType"
    /// <summary>
    ///   <para>skos:prefLabel : Technique</para>
    ///   <para>skos:definition : The :Technique class represents an instance from a categorisation of recognisable scientific methods or procedures described in scholarly articles. This categorisation is implemented as a SKOS concept scheme.</para>
    ///   <a href="http://ns.nature.com/terms/Technique">npg:Technique</a>
    /// </summary>
    let Technique = _prefixId.prefix "Technique"
    /// <summary>
    ///   <para>skos:prefLabel : Thing</para>
    ///   <para>skos:definition : The :Thing class groups together all individuals used by Macmillan Science and Education within the NPG publishing world.</para>
    ///   <a href="http://ns.nature.com/terms/Thing">npg:Thing</a>
    /// </summary>
    let Thing = _prefixId.prefix "Thing"
    /// <summary>
    ///   <para>skos:prefLabel : Type</para>
    ///   <para>skos:note : All of the :Type categorisations are implemented as self-contained reusable SKOS vocabularies (although not all of them are taxonomies in the strict sense of hierarchical vocabularies).</para>
    ///   <para>skos:definition : The :Type class groups together  all domain-specific categorisations relevant to the NPG publishing world.</para>
    ///   <a href="http://ns.nature.com/terms/Type">npg:Type</a>
    /// </summary>
    let Type = _prefixId.prefix "Type"
    /// <summary>
    ///   <para>skos:prefLabel : Xml Asset</para>
    ///   <para>skos:definition : The :XmlAsset class represents the physical rendition of a document asset in XML format.</para>
    ///   <a href="http://ns.nature.com/terms/XmlAsset">npg:XmlAsset</a>
    /// </summary>
    let XmlAsset = _prefixId.prefix "XmlAsset"
    /// <summary>
    ///   <para>skos:prefLabel : Asset Version</para>
    ///   <para>skos:definition : The :assetVersion property specifies the version of an :Asset associated with a :PublishEvent.</para>
    ///   <a href="http://ns.nature.com/terms/assetVersion">npg:assetVersion</a>
    /// </summary>
    let assetVersion = _prefixId.prefix "assetVersion"
    /// <summary>
    ///   <para>skos:prefLabel : Body</para>
    ///   <para>skos:definition : The :body property specifies the main body content of a publication as a string.</para>
    ///   <a href="http://ns.nature.com/terms/body">npg:body</a>
    /// </summary>
    let body = _prefixId.prefix "body"
    /// <summary>
    ///   <para>skos:prefLabel : Body (XML)</para>
    ///   <para>skos:definition : The :bodyXml property specifies the main body content of a publication as an XML string.</para>
    ///   <a href="http://ns.nature.com/terms/bodyXml">npg:bodyXml</a>
    /// </summary>
    let bodyXml = _prefixId.prefix "bodyXml"
    /// <summary>
    ///   <para>skos:prefLabel : Caption</para>
    ///   <para>skos:definition : The :caption property specifies the caption of a figure or illustration as a string.</para>
    ///   <a href="http://ns.nature.com/terms/caption">npg:caption</a>
    /// </summary>
    let caption = _prefixId.prefix "caption"
    /// <summary>
    ///   <para>skos:prefLabel : Caption (XML)</para>
    ///   <para>skos:definition : The :captionXml property specifies the caption of a figure or illustration as an XML string.</para>
    ///   <a href="http://ns.nature.com/terms/captionXml">npg:captionXml</a>
    /// </summary>
    let captionXml = _prefixId.prefix "captionXml"
    /// <summary>
    ///   <para>skos:prefLabel : Cover Date</para>
    ///   <para>skos:note : This is not necessarily the actual date of publication.</para>
    ///   <para>skos:definition : The :coverDate property specifies the full date of a publication as it is displayed on its cover.</para>
    ///   <a href="http://ns.nature.com/terms/coverDate">npg:coverDate</a>
    /// </summary>
    let coverDate = _prefixId.prefix "coverDate"
    /// <summary>
    ///   <para>skos:prefLabel : Cover Year</para>
    ///   <para>skos:note : This is not necessarily the actual date of publication.</para>
    ///   <para>skos:definition : The :coverDate property specifies the year date of a publication as it is displayed on its cover.</para>
    ///   <a href="http://ns.nature.com/terms/coverYear">npg:coverYear</a>
    /// </summary>
    let coverYear = _prefixId.prefix "coverYear"
    /// <summary>
    ///   <para>skos:prefLabel : Cover YearMonth</para>
    ///   <para>skos:note : This is not necessarily the actual date of publication.</para>
    ///   <para>skos:definition : The :coverDate property specifies the year and month date of a publication as it is displayed on its cover.</para>
    ///   <a href="http://ns.nature.com/terms/coverYearMonth">npg:coverYearMonth</a>
    /// </summary>
    let coverYearMonth = _prefixId.prefix "coverYearMonth"
    /// <summary>
    ///   <para>skos:prefLabel : Credit</para>
    ///   <para>skos:definition : The :credit property specifies the photographer, illustrator, or copyright holder for an image in a publication.</para>
    ///   <a href="http://ns.nature.com/terms/credit">npg:credit</a>
    /// </summary>
    let credit = _prefixId.prefix "credit"
    /// <summary>
    ///   <para>skos:prefLabel : Date</para>
    ///   <para>skos:definition : The :date property specifies the full date of a publication event as a string.</para>
    ///   <a href="http://ns.nature.com/terms/date">npg:date</a>
    /// </summary>
    let date = _prefixId.prefix "date"
    /// <summary>
    ///   <para>skos:prefLabel : DateTime</para>
    ///   <para>skos:definition : The :dateTime property specifies the full date of a publication event as a string, including the time of publication scheduling.</para>
    ///   <a href="http://ns.nature.com/terms/dateTime">npg:dateTime</a>
    /// </summary>
    let dateTime = _prefixId.prefix "dateTime"
    /// <summary>
    ///   <para>skos:prefLabel : DOI</para>
    ///   <para>skos:definition : The :doi property specifies a DOI number for a publication.</para>
    ///   <a href="http://ns.nature.com/terms/doi">npg:doi</a>
    /// </summary>
    let doi = _prefixId.prefix "doi"
    /// <summary>
    ///   <para>skos:prefLabel : E-ISSN</para>
    ///   <para>skos:definition : The :eissn property specifies an E-ISSN number for a serial.</para>
    ///   <a href="http://ns.nature.com/terms/eissn">npg:eissn</a>
    /// </summary>
    let eissn = _prefixId.prefix "eissn"
    /// <summary>
    ///   <para>skos:prefLabel : Family Name</para>
    ///   <para>skos:definition : The :familyName property specifies the family name of a person.</para>
    ///   <a href="http://ns.nature.com/terms/familyName">npg:familyName</a>
    /// </summary>
    let familyName = _prefixId.prefix "familyName"
    /// <summary>
    ///   <para>skos:prefLabel : File Extension</para>
    ///   <para>skos:definition : The :fileExtension property specifies the extension part of the filename of an asset.</para>
    ///   <a href="http://ns.nature.com/terms/fileExtension">npg:fileExtension</a>
    /// </summary>
    let fileExtension = _prefixId.prefix "fileExtension"
    /// <summary>
    ///   <para>skos:prefLabel : Filename</para>
    ///   <para>skos:definition : The :filename property specifies the filename of an asset.</para>
    ///   <a href="http://ns.nature.com/terms/filename">npg:filename</a>
    /// </summary>
    let filename = _prefixId.prefix "filename"
    /// <summary>
    ///   <para>skos:prefLabel : Filesize</para>
    ///   <para>skos:definition : The :filesize property specifies an integer value for the size (in bytes) of an asset.</para>
    ///   <a href="http://ns.nature.com/terms/filesize">npg:filesize</a>
    /// </summary>
    let filesize = _prefixId.prefix "filesize"
    /// <summary>
    ///   <para>skos:prefLabel : Given Name</para>
    ///   <para>skos:definition : The :givenName property specifies the given name of a person.</para>
    ///   <a href="http://ns.nature.com/terms/givenName">npg:givenName</a>
    /// </summary>
    let givenName = _prefixId.prefix "givenName"
    /// <summary>
    ///   <para>skos:prefLabel : Has Abstract</para>
    ///   <para>skos:definition : The :hasAbstract property relates an article to the abstract for an article.</para>
    ///   <a href="http://ns.nature.com/terms/hasAbstract">npg:hasAbstract</a>
    /// </summary>
    let hasAbstract = _prefixId.prefix "hasAbstract"
    /// <summary>
    ///   <para>skos:prefLabel : Has Article</para>
    ///   <para>skos:definition : The :hasArticle property relates a publication-event to an article.</para>
    ///   <a href="http://ns.nature.com/terms/hasArticle">npg:hasArticle</a>
    /// </summary>
    let hasArticle = _prefixId.prefix "hasArticle"
    /// <summary>
    ///   <para>skos:prefLabel : Has Article Type</para>
    ///   <para>skos:definition : The :hasArticleType relates a publication to an article-type.</para>
    ///   <a href="http://ns.nature.com/terms/hasArticleType">npg:hasArticleType</a>
    /// </summary>
    let hasArticleType = _prefixId.prefix "hasArticleType"
    let hasAsset = _prefixId.prefix "hasAsset"
    /// <summary>
    ///   <para>skos:prefLabel : Has Broader Subject</para>
    ///   <para>skos:definition : The :hasBroaderSubject property relates a publication to a broader subject term than it is actually classified with.</para>
    ///   <a href="http://ns.nature.com/terms/hasBroaderSubject">npg:hasBroaderSubject</a>
    /// </summary>
    let hasBroaderSubject = _prefixId.prefix "hasBroaderSubject"
    /// <summary>
    ///   <para>skos:prefLabel : Has Collection</para>
    ///   <para>skos:definition : The :hasCollection property relates a publication-event to a collection.</para>
    ///   <a href="http://ns.nature.com/terms/hasCollection">npg:hasCollection</a>
    /// </summary>
    let hasCollection = _prefixId.prefix "hasCollection"
    /// <summary>
    ///   <para>skos:prefLabel : Has Contributor</para>
    ///   <para>skos:note : Normally, the contributor name is a non-disambiguated person name, meaning that several contributor instances may refer to the same person.</para>
    ///   <para>skos:definition : The :hasContributor property relates a publication to a string containing the name of one of the authors of that publication.</para>
    ///   <a href="http://ns.nature.com/terms/hasContributor">npg:hasContributor</a>
    /// </summary>
    let hasContributor = _prefixId.prefix "hasContributor"
    /// <summary>
    ///   <para>skos:prefLabel : Has Figure</para>
    ///   <para>skos:definition : The :hasFigure property relates a publication to a figure.</para>
    ///   <a href="http://ns.nature.com/terms/hasFigure">npg:hasFigure</a>
    /// </summary>
    let hasFigure = _prefixId.prefix "hasFigure"
    /// <summary>
    ///   <para>skos:prefLabel : Has Illustration</para>
    ///   <para>skos:definition : The :hasIllustration property relates a publication to an illustration.</para>
    ///   <a href="http://ns.nature.com/terms/hasIllustration">npg:hasIllustration</a>
    /// </summary>
    let hasIllustration = _prefixId.prefix "hasIllustration"
    /// <summary>
    ///   <para>skos:prefLabel : Has Image</para>
    ///   <para>skos:definition : The :hasImage property relates a publication to an image.</para>
    ///   <a href="http://ns.nature.com/terms/hasImage">npg:hasImage</a>
    /// </summary>
    let hasImage = _prefixId.prefix "hasImage"
    /// <summary>
    ///   <para>skos:prefLabel : Has Image Asset</para>
    ///   <para>skos:definition : The :hasImageAsset property relates an image to an image-asset.</para>
    ///   <a href="http://ns.nature.com/terms/hasImageAsset">npg:hasImageAsset</a>
    /// </summary>
    let hasImageAsset = _prefixId.prefix "hasImageAsset"
    /// <summary>
    ///   <para>skos:prefLabel : Has Issue</para>
    ///   <para>skos:definition : The :hasIssue property relates a publication-event to an issue.</para>
    ///   <a href="http://ns.nature.com/terms/hasIssue">npg:hasIssue</a>
    /// </summary>
    let hasIssue = _prefixId.prefix "hasIssue"
    /// <summary>
    ///   <para>skos:prefLabel : Has Item</para>
    ///   <para>skos:definition : The :hasItem property relates a publication to an item.</para>
    ///   <a href="http://ns.nature.com/terms/hasItem">npg:hasItem</a>
    /// </summary>
    let hasItem = _prefixId.prefix "hasItem"
    /// <summary>
    ///   <para>skos:prefLabel : Has PDF Asset</para>
    ///   <para>skos:definition : The :hasPdfAsset property relates a publication to a pdf-asset.</para>
    ///   <a href="http://ns.nature.com/terms/hasPdfAsset">npg:hasPdfAsset</a>
    /// </summary>
    let hasPdfAsset = _prefixId.prefix "hasPdfAsset"
    /// <summary>
    ///   <para>skos:prefLabel : Has Primary Article Type</para>
    ///   <para>skos:definition : The :hasPrimaryArticleType relates a publication to a primary article-type.</para>
    ///   <a href="http://ns.nature.com/terms/hasPrimaryArticleType">npg:hasPrimaryArticleType</a>
    /// </summary>
    let hasPrimaryArticleType = _prefixId.prefix "hasPrimaryArticleType"
    /// <summary>
    ///   <para>skos:prefLabel : Has Publication</para>
    ///   <para>skos:definition : The :hasPublication property relates a publication-event to a publication.</para>
    ///   <a href="http://ns.nature.com/terms/hasPublication">npg:hasPublication</a>
    /// </summary>
    let hasPublication = _prefixId.prefix "hasPublication"
    /// <summary>
    ///   <para>skos:prefLabel : Has Publish Event</para>
    ///   <para>skos:definition : The :hasPublishEvent property relates a publication to a publish-event that describes some recognized change in the status of a publication's publish history.</para>
    ///   <a href="http://ns.nature.com/terms/hasPublishEvent">npg:hasPublishEvent</a>
    /// </summary>
    let hasPublishEvent = _prefixId.prefix "hasPublishEvent"
    /// <summary>
    ///   <para>skos:prefLabel : Has Publish State</para>
    ///   <para>skos:definition : The :hasPublishState property relates a publish-event to a publish-state that describes some recognized change in the status of a publication's publish history.</para>
    ///   <a href="http://ns.nature.com/terms/hasPublishState">npg:hasPublishState</a>
    /// </summary>
    let hasPublishState = _prefixId.prefix "hasPublishState"
    /// <summary>
    ///   <para>skos:prefLabel : Has Publisher</para>
    ///   <para>skos:definition : The :hasPublisher property relates a publication to the organization that publishes it.</para>
    ///   <a href="http://ns.nature.com/terms/hasPublisher">npg:hasPublisher</a>
    /// </summary>
    let hasPublisher = _prefixId.prefix "hasPublisher"
    /// <summary>
    ///   <para>skos:prefLabel : Has Root</para>
    ///   <para>skos:definition : The :hasRoot property relates a :Type instance to a toplevel :Type instance within the same domain model.</para>
    ///   <a href="http://ns.nature.com/terms/hasRoot">npg:hasRoot</a>
    /// </summary>
    let hasRoot = _prefixId.prefix "hasRoot"
    /// <summary>
    ///   <para>skos:prefLabel : Has Section</para>
    ///   <para>skos:definition : The :hasSection property relates a publication to a section component.</para>
    ///   <a href="http://ns.nature.com/terms/hasSection">npg:hasSection</a>
    /// </summary>
    let hasSection = _prefixId.prefix "hasSection"
    /// <summary>
    ///   <para>skos:prefLabel : Has Subject</para>
    ///   <para>skos:definition : The :hasSubject property relates a publication to a subject term which describes one of the main topics the publication is about.</para>
    ///   <a href="http://ns.nature.com/terms/hasSubject">npg:hasSubject</a>
    /// </summary>
    let hasSubject = _prefixId.prefix "hasSubject"
    /// <summary>
    ///   <para>skos:prefLabel : Has Summary</para>
    ///   <para>skos:definition : The :hasSummary property relates an article to an article summary.</para>
    ///   <a href="http://ns.nature.com/terms/hasSummary">npg:hasSummary</a>
    /// </summary>
    let hasSummary = _prefixId.prefix "hasSummary"
    /// <summary>
    ///   <para>skos:prefLabel : Has Summary Type</para>
    ///   <para>skos:definition : The :hasSummaryType property relates a summary to a summary-type classification.</para>
    ///   <a href="http://ns.nature.com/terms/hasSummaryType">npg:hasSummaryType</a>
    /// </summary>
    let hasSummaryType = _prefixId.prefix "hasSummaryType"
    /// <summary>
    ///   <para>skos:prefLabel : Has Technique</para>
    ///   <para>skos:definition : The :hasTechnique property relates a publication to a technique term which describes one of the main scientific methods the publication is about.</para>
    ///   <a href="http://ns.nature.com/terms/hasTechnique">npg:hasTechnique</a>
    /// </summary>
    let hasTechnique = _prefixId.prefix "hasTechnique"
    /// <summary>
    ///   <para>skos:prefLabel : Has XML Asset</para>
    ///   <para>skos:definition : The :hasXmlAsset property relates a publication to an xml-asset.</para>
    ///   <a href="http://ns.nature.com/terms/hasXmlAsset">npg:hasXmlAsset</a>
    /// </summary>
    let hasXmlAsset = _prefixId.prefix "hasXmlAsset"
    /// <summary>
    ///   <para>skos:prefLabel : ID</para>
    ///   <para>skos:note : The :id value forms the local part of the full URI for an entity name.</para>
    ///   <para>skos:definition : The :id property provides a unique ID for a thing.</para>
    ///   <a href="http://ns.nature.com/terms/id">npg:id</a>
    /// </summary>
    let id = _prefixId.prefix "id"
    /// <summary>
    ///   <para>skos:prefLabel : Is Asset Of</para>
    ///   <para>skos:definition : The :isAssetOf property relates an asset to the publication it represents.</para>
    ///   <a href="http://ns.nature.com/terms/isAssetOf">npg:isAssetOf</a>
    /// </summary>
    let isAssetOf = _prefixId.prefix "isAssetOf"
    /// <summary>
    ///   <para>skos:prefLabel : Is Corresponding</para>
    ///   <para>skos:definition : The :isCorresponding property marks whether a contributor is a corresponding author.</para>
    ///   <a href="http://ns.nature.com/terms/isCorresponding">npg:isCorresponding</a>
    /// </summary>
    let isCorresponding = _prefixId.prefix "isCorresponding"
    /// <summary>
    ///   <para>skos:prefLabel : Is Curated</para>
    ///   <para>skos:definition : The :isCurated property marks whether an image is editiorially managed.</para>
    ///   <a href="http://ns.nature.com/terms/isCurated">npg:isCurated</a>
    /// </summary>
    let isCurated = _prefixId.prefix "isCurated"
    /// <summary>
    ///   <para>skos:prefLabel : Is Leaf</para>
    ///   <para>skos:definition : The :isLeaf property marks whether a SKOS concept is a leaf SKOS concept.</para>
    ///   <a href="http://ns.nature.com/terms/isLeaf">npg:isLeaf</a>
    /// </summary>
    let isLeaf = _prefixId.prefix "isLeaf"
    /// <summary>
    ///   <para>skos:prefLabel : Is PrimaryArticleType</para>
    ///   <para>skos:definition : The :isPrimaryArticleType property marks whether an article-type can be used for grouping purposes.</para>
    ///   <a href="http://ns.nature.com/terms/isPrimaryArticleType">npg:isPrimaryArticleType</a>
    /// </summary>
    let isPrimaryArticleType = _prefixId.prefix "isPrimaryArticleType"
    /// <summary>
    ///   <para>skos:prefLabel : Is Root</para>
    ///   <para>skos:definition : The :isRoot property marks whether a SKOS concept is a SKOS top concept.</para>
    ///   <a href="http://ns.nature.com/terms/isRoot">npg:isRoot</a>
    /// </summary>
    let isRoot = _prefixId.prefix "isRoot"
    /// <summary>
    ///   <para>skos:prefLabel : ISSN</para>
    ///   <para>skos:definition : The :issn property specifies an ISSN number for a serial.</para>
    ///   <a href="http://ns.nature.com/terms/issn">npg:issn</a>
    /// </summary>
    let issn = _prefixId.prefix "issn"
    /// <summary>
    ///   <para>skos:prefLabel : Issue</para>
    ///   <para>skos:definition : The :issue property specifies an issue label for a journal.</para>
    ///   <a href="http://ns.nature.com/terms/issue">npg:issue</a>
    /// </summary>
    let issue = _prefixId.prefix "issue"
    /// <summary>
    ///   <para>skos:prefLabel : Name</para>
    ///   <para>skos:definition : The :name property specifies the full name for a thing.</para>
    ///   <a href="http://ns.nature.com/terms/name">npg:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>skos:prefLabel : Namespace</para>
    ///   <para>skos:definition : The :namespace property provides the RDF namespace used in creating instances of a class.</para>
    ///   <a href="http://ns.nature.com/terms/namespace">npg:namespace</a>
    /// </summary>
    let namespace_ = _prefixId.prefix "namespace"
    /// <summary>
    ///   <para>skos:prefLabel : Number</para>
    ///   <para>skos:definition : The :number property specifies a generic relationship between an entity and a number for ordering purposes.</para>
    ///   <a href="http://ns.nature.com/terms/number">npg:number</a>
    /// </summary>
    let number = _prefixId.prefix "number"
    /// <summary>
    ///   <para>skos:prefLabel : Page End</para>
    ///   <para>skos:definition : The :pageEnd property specifies an ending page number for a document.</para>
    ///   <a href="http://ns.nature.com/terms/pageEnd">npg:pageEnd</a>
    /// </summary>
    let pageEnd = _prefixId.prefix "pageEnd"
    /// <summary>
    ///   <para>skos:prefLabel : Page Start</para>
    ///   <para>skos:definition : The :pageStart property specifies a starting page number for a document.</para>
    ///   <a href="http://ns.nature.com/terms/pageStart">npg:pageStart</a>
    /// </summary>
    let pageStart = _prefixId.prefix "pageStart"
    /// <summary>
    ///   <para>skos:prefLabel : Pages</para>
    ///   <para>skos:definition : The :pages property specifies a page range numbering for a document.</para>
    ///   <a href="http://ns.nature.com/terms/pages">npg:pages</a>
    /// </summary>
    let pages = _prefixId.prefix "pages"
    /// <summary>
    ///   <para>skos:prefLabel : Publication Date</para>
    ///   <para>skos:definition : The :publicationDate property specifies the full date of a publication as a string.</para>
    ///   <a href="http://ns.nature.com/terms/publicationDate">npg:publicationDate</a>
    /// </summary>
    let publicationDate = _prefixId.prefix "publicationDate"
    /// <summary>
    ///   <para>skos:prefLabel : Publication DateTime</para>
    ///   <para>skos:definition : The :publicationDateTime property specifies the full date of a publication as a string, including the time of publication.</para>
    ///   <a href="http://ns.nature.com/terms/publicationDateTime">npg:publicationDateTime</a>
    /// </summary>
    let publicationDateTime = _prefixId.prefix "publicationDateTime"
    /// <summary>
    ///   <para>skos:prefLabel : Publication Year</para>
    ///   <para>skos:definition : The :publicationYear property specifies the year date of a publication as a string.</para>
    ///   <a href="http://ns.nature.com/terms/publicationYear">npg:publicationYear</a>
    /// </summary>
    let publicationYear = _prefixId.prefix "publicationYear"
    /// <summary>
    ///   <para>skos:prefLabel : Publication YearMonth</para>
    ///   <para>skos:definition : The :publicationYearMonth property specifies the year and month date of a publication as a string.</para>
    ///   <a href="http://ns.nature.com/terms/publicationYearMonth">npg:publicationYearMonth</a>
    /// </summary>
    let publicationYearMonth = _prefixId.prefix "publicationYearMonth"
    /// <summary>
    ///   <para>skos:prefLabel : Replaced By</para>
    ///   <para>skos:definition : The :replacedBy property relates a publication to another publication that replaces it.</para>
    ///   <a href="http://ns.nature.com/terms/replacedBy">npg:replacedBy</a>
    /// </summary>
    let replacedBy = _prefixId.prefix "replacedBy"
    /// <summary>
    ///   <para>skos:prefLabel : Replaces</para>
    ///   <para>skos:definition : The :replaces property relates a publication to another publication that it replaces.</para>
    ///   <a href="http://ns.nature.com/terms/replaces">npg:replaces</a>
    /// </summary>
    let replaces = _prefixId.prefix "replaces"
    /// <summary>
    ///   <para>skos:prefLabel : Repository</para>
    ///   <para>skos:definition : The :repository property relates an asset to a storage repository.</para>
    ///   <a href="http://ns.nature.com/terms/repository">npg:repository</a>
    /// </summary>
    let repository = _prefixId.prefix "repository"
    /// <summary>
    ///   <para>skos:prefLabel : Repository ID</para>
    ///   <para>skos:definition : The :repositoryId property specifies a (local) repository ID for an asset.</para>
    ///   <a href="http://ns.nature.com/terms/repositoryId">npg:repositoryId</a>
    /// </summary>
    let repositoryId = _prefixId.prefix "repositoryId"
    /// <summary>
    ///   <para>skos:prefLabel : Short Title</para>
    ///   <para>skos:definition : The :shortTitle property specifies an abbreviated title for a publication.</para>
    ///   <a href="http://ns.nature.com/terms/shortTitle">npg:shortTitle</a>
    /// </summary>
    let shortTitle = _prefixId.prefix "shortTitle"
    /// <summary>
    ///   <para>skos:prefLabel : Title</para>
    ///   <para>skos:definition : The :title property specifies a title to the main body content of a publication as a string.</para>
    ///   <a href="http://ns.nature.com/terms/title">npg:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>skos:prefLabel : Title (XML)</para>
    ///   <para>skos:definition : The :titleXml property specifies a title to the main body content of a publication as an XML string.</para>
    ///   <a href="http://ns.nature.com/terms/titleXml">npg:titleXml</a>
    /// </summary>
    let titleXml = _prefixId.prefix "titleXml"
    /// <summary>
    ///   <para>skos:prefLabel : Tree Depth</para>
    ///   <para>skos:note : This property is generally computed by a build-time rule</para>
    ///   <para>skos:definition : The :treeDepth property specifies the depth of a term within a taxonomy tree.</para>
    ///   <a href="http://ns.nature.com/terms/treeDepth">npg:treeDepth</a>
    /// </summary>
    let treeDepth = _prefixId.prefix "treeDepth"
    /// <summary>
    ///   <para>skos:prefLabel : Volume</para>
    ///   <para>skos:definition : The :volume property specifies a volume label for a journal.</para>
    ///   <a href="http://ns.nature.com/terms/volume">npg:volume</a>
    /// </summary>
    let volume = _prefixId.prefix "volume"
    /// <summary>
    ///   <para>skos:prefLabel : Web Page</para>
    ///   <para>skos:definition : The :webpage property relates a publication to the main page on the web that describes it.</para>
    ///   <a href="http://ns.nature.com/terms/webpage">npg:webpage</a>
    /// </summary>
    let webpage = _prefixId.prefix "webpage"
    /// <summary>
    ///   <para>skos:prefLabel : Year</para>
    ///   <para>skos:definition : The :date property specifies the year date of a publication event as a string.</para>
    ///   <a href="http://ns.nature.com/terms/year">npg:year</a>
    /// </summary>
    let year = _prefixId.prefix "year"
    /// <summary>
    ///   <para>skos:prefLabel : YearMonth</para>
    ///   <para>skos:definition : The :date property specifies the year and month date of a publication event as a string.</para>
    ///   <a href="http://ns.nature.com/terms/yearMonth">npg:yearMonth</a>
    /// </summary>
    let yearMonth = _prefixId.prefix "yearMonth"
