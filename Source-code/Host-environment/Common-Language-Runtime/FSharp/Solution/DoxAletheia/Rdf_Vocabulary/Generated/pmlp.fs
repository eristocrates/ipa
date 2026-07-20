namespace http.inference_web.org._2._0.pml_provenance.owl.hash

open DoxAletheia

module pmlp =
    let _namespace_name = "http://inference-web.org/2.0/pml-provenance.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// actionalble entities.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#Agent"></see></summary>
    let Agent = _prefix "Agent"
    /// <summary>
    /// A source refers to the source of information. It is the place where we obtain information.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#Source"></see></summary>
    let Source = _prefix "Source"
    /// <summary>
    ///   <see href="http://inference-web.org/2.0/pml-provenance.owl#AgentList"></see>
    /// </summary>
    let AgentList = _prefix "AgentList"
    /// <summary>
    /// A dataset is a collection of data document whose information is encoded in a defined structure (for example, lists, tables, and databases). see also http://purl.org/dc/dcmitype/Dataset.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#Dataset"></see></summary>
    let Dataset = _prefix "Dataset"
    /// <summary>
    /// A physical information container that is not actionable. They function like database.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#Document"></see></summary>
    let Document = _prefix "Document"
    /// <summary>
    /// A declarative inference rule can be fully specified by patterns for premises and its conclusion.   For example, Modus Ponens, can be specified by the premise patterns ?A,  ?A -&amp;gt; ?B and the conclusion pattern ?B.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#DeclarativeRule"></see></summary>
    let DeclarativeRule = _prefix "DeclarativeRule"
    /// <summary>
    /// Inference rules are used to derive conclusions from premises.
    /// Inference Web divides inference rules into three classes: Primitive and Derived and Translation.
    /// This is an abstract class without any direct instance. A primitive rule is an atomic rule with respect to an inference engine. An inference engine may support rules that it does not need to further decompose. Since a primitive rule is an inference engine dependent concept, we may find a rule is primitive to one inference engine but not to another engine. For example a `natural deduction reasoner R1 may define Modus Ponens as a primitive rule and another reasoner R2 may register Robinson's resolution rule as a primitive rule. The reasoner R2 may be able to derive a Modus Ponens rule using its primitive resolution rule.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#InferenceRule"></see></summary>
    let InferenceRule = _prefix "InferenceRule"
    /// <summary>
    ///  This is a common concept that links to a piece of information. Currently, we focus on content of document, and inference rule.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasContent"></see></summary>
    let hasContent = _prefix "hasContent"
    /// <summary>
    /// the version number.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasVersion"></see></summary>
    let hasVersion = _prefix "hasVersion"
    /// <summary>
    /// The abstract of a document.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasAbstract"></see></summary>
    let hasAbstract = _prefix "hasAbstract"
    /// <summary>
    /// A fragment of document that can be used as source.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#DocumentFragment"></see></summary>
    let DocumentFragment = _prefix "DocumentFragment"
    /// <summary>
    /// A document fragment always depend on one source document, which is also the source.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasDocument"></see></summary>
    let hasDocument = _prefix "hasDocument"
    /// <summary>
    /// We may treat a document a one dimensional string, so we can mark a fragment with two offsets. We don't use byte because characters in text document may be multi-bytes.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#DocumentFragmentByOffset"></see></summary>
    let DocumentFragmentByOffset = _prefix "DocumentFragmentByOffset"
    /// <summary>
    /// The from offset of the fragment (inclusive, index based on 0).
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasFromOffset"></see></summary>
    let hasFromOffset = _prefix "hasFromOffset"
    /// <summary>
    /// The to offset of the fragment (exclusive, index based on 0)
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasToOffset"></see></summary>
    let hasToOffset = _prefix "hasToOffset"
    /// <summary>
    ///   <see href="http://inference-web.org/2.0/pml-provenance.owl#DocumentFragmentByRowCol"></see>
    /// </summary>
    let DocumentFragmentByRowCol = _prefix "DocumentFragmentByRowCol"
    /// <summary>
    /// The to row of the fragment (inclusive, index based on 1)
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasToRow"></see></summary>
    let hasToRow = _prefix "hasToRow"
    /// <summary>
    /// The to column of the fragment (inclusive, index based on 1)
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasToCol"></see></summary>
    let hasToCol = _prefix "hasToCol"
    /// <summary>
    /// The from column of the fragment (inclusive, index based on 1)
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasFromCol"></see></summary>
    let hasFromCol = _prefix "hasFromCol"
    /// <summary>
    /// The from row of the fragment (inclusive, index based on 1)
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasFromRow"></see></summary>
    let hasFromRow = _prefix "hasFromRow"
    /// <summary>
    /// An instance of information indicating no conclusion has been derived, i.e. empty set of statements. In this case, the rawstring may contain some english message indicating no answer.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#EmptyInformation"></see></summary>
    let EmptyInformation = _prefix "EmptyInformation"
    /// <summary>
    /// A piece of information, e.g. a formula in logic languages, and an utterance/word/phrase/sentence/paragraph/article in natural language. It is used as a range of iw:hasContent. This class and two of its sub-classes enable users to specify four types of semantics  (i) Information Annotation - annotate just the format and language used by the content of information; (ii) Information With Content - additionally provide the content of information that is materialized as string without loading a web page; (iii) Information external - additionally provide the URL for fetching the content; and (iv) Information - with every thing including the content string and URL. The second semantics is especially useful when the content is short or mainly used locally. For example, when learning by instruction, the utterances used for learning can be stored within the PML document without being externally stored. By assigning URI reference to information, we can even use owl:sameAs to capture the equivalence of two pieces of information.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#Information"></see></summary>
    let Information = _prefix "Information"
    /// <summary>
    /// A plan for the organization and arrangement of specified information. Examples: binary, text,  pdf, etc.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#Format"></see></summary>
    let Format = _prefix "Format"
    /// <summary>
    /// The abstract root of provenance related concepts. It organizes a collection of common metadata about the referenced object, and it does not have any instance.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#IdentifiedThing"></see></summary>
    let IdentifiedThing = _prefix "IdentifiedThing"
    /// <summary>
    /// the human readable label of the identified thing.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasName"></see></summary>
    let hasName = _prefix "hasName"
    /// <summary>
    /// A list of agents primarily responsible for making the artifact, for example, a person, an organization, or a software service. The AgentList enables an ordered list of agents; however, domain applications may optionally choose to ignore the order. We should be able to derive that each agent is the dc:creator of the artifact.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasAuthorList"></see></summary>
    let hasAuthorList = _prefix "hasAuthorList"
    /// <summary>
    /// When the artifact has been first created.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasCreationDateTime"></see></summary>
    let hasCreationDateTime = _prefix "hasCreationDateTime"
    /// <summary>
    /// the owner of a thing.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasOwner"></see></summary>
    let hasOwner = _prefix "hasOwner"
    /// <summary>
    /// An inference engine represents an engine that is able to produce a justification for a conclusion. Note that the phrase "inference engine" applies not only to reasoners but also to other systems like search engines which may justify their answers by direct assertion
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#InferenceEngine"></see></summary>
    let InferenceEngine = _prefix "InferenceEngine"
    /// <summary>
    /// The inference rules used by the inference engine
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasInferenceEngineRule"></see></summary>
    let hasInferenceEngineRule = _prefix "hasInferenceEngineRule"
    /// <summary>
    /// written programs or procedures or rules and associated documentation pertaining to the operation of a computer system and that are stored in read/write memory.(WordNet)
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#Software"></see></summary>
    let Software = _prefix "Software"
    /// <summary>
    /// it is sub-property of rdfs:comment. It is also a simplified template for adding rule description template in English rather than using hasDescription.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasEnglishDescriptionTemplate"></see></summary>
    let hasEnglishDescriptionTemplate = _prefix "hasEnglishDescriptionTemplate"
    /// <summary>
    /// The URL of a relevant web page.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasURL"></see></summary>
    let hasURL = _prefix "hasURL"
    /// <summary>
    /// it specifies the language used to encode information, e.g. "Tony's specialty is shellfish" is encoded in English. This property may also link to a registered formal language such as KIF.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasLanguage"></see></summary>
    let hasLanguage = _prefix "hasLanguage"
    /// <summary>
    /// the human friendly presentation of the information. Its format is text and it is usually written in English.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasPrettyString"></see></summary>
    let hasPrettyString = _prefix "hasPrettyString"
    /// <summary>
    /// The rendering instruction. UI tools may feed the PrettyNameMapping in sequence to string replace operation to get a pretty rendering of the conclusion of a NodeSet. It only applies to the conclusion of the node set.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasPrettyNameMappingList"></see></summary>
    let hasPrettyNameMappingList = _prefix "hasPrettyNameMappingList"
    /// <summary>
    /// materialized version of the content of information
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasRawString"></see></summary>
    let hasRawString = _prefix "hasRawString"
    /// <summary>
    /// it specifies the format of information, e.g. "pdf", "ppt" (Power Point). It is mainly used to determine the appropriate application for process/display purpose.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasFormat"></see></summary>
    let hasFormat = _prefix "hasFormat"
    /// <summary>
    /// Explain how this information is obtained from a source: by whom, when, which source and which part of the source.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasReferenceSourceUsage"></see></summary>
    let hasReferenceSourceUsage = _prefix "hasReferenceSourceUsage"
    /// <summary>
    /// The language used to encode the raw string, e.g. English, Knowledge Interchange Format (KIF) , and N3. Languages are in general registered at the core IWRegistry.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#Language"></see></summary>
    let Language = _prefix "Language"
    /// <summary>
    /// A special type of source usage. It records the modification of sources - the question that initiates the learning process, the duration of learning, the original source and current source used by learning.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#LearnedSourceUsage"></see></summary>
    let LearnedSourceUsage = _prefix "LearnedSourceUsage"
    /// <summary>
    /// the time stamp when data collection started
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasDataCollectionStartDateTime"></see></summary>
    let hasDataCollectionStartDateTime = _prefix "hasDataCollectionStartDateTime"
    /// <summary>
    /// the time stamp when data collection ended
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasDataCollectionEndDateTime"></see></summary>
    let hasDataCollectionEndDateTime = _prefix "hasDataCollectionEndDateTime"
    /// <summary>
    /// A usage of the source. It records an access of a source at a certain date time.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#SourceUsage"></see></summary>
    let SourceUsage = _prefix "SourceUsage"
    /// <summary>
    /// A method inference rule, uses patterns for premises and its conclusions, and additionally contains a method that must be applied.  In addition,
    /// the conclusion needs to be a valid output of the method, using the premises.  For example, procedural attachment is a common encoding form for method rules.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#MethodRule"></see></summary>
    let MethodRule = _prefix "MethodRule"
    /// <summary>
    /// An Ontology is a document that describes a vocabulary of terms and their correlations.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#Ontology"></see></summary>
    let Ontology = _prefix "Ontology"
    /// <summary>
    /// A group of agents organized for a particular purpose, e.g., KSL, stanford.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#Organization"></see></summary>
    let Organization = _prefix "Organization"
    /// <summary>
    /// A person
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#Person"></see></summary>
    let Person = _prefix "Person"
    /// <summary>
    /// specially designed for pretty display purpose.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#PrettyNameMapping"></see></summary>
    let PrettyNameMapping = _prefix "PrettyNameMapping"
    /// <summary>
    ///   <see href="http://inference-web.org/2.0/pml-provenance.owl#hasReplacee"></see>
    /// </summary>
    let hasReplacee = _prefix "hasReplacee"
    /// <summary>
    ///   <see href="http://inference-web.org/2.0/pml-provenance.owl#hasShortPrettyName"></see>
    /// </summary>
    let hasShortPrettyName = _prefix "hasShortPrettyName"
    /// <summary>
    ///   <see href="http://inference-web.org/2.0/pml-provenance.owl#PrettyNameMappingList"></see>
    /// </summary>
    let PrettyNameMappingList = _prefix "PrettyNameMappingList"
    /// <summary>
    /// If we have two versions of the same publication, we need to create two instances of Publication. A publication may have multiple ISBNs.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#Publication"></see></summary>
    let Publication = _prefix "Publication"
    /// <summary>
    /// The International Standard Book Number.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasISBN"></see></summary>
    let hasISBN = _prefix "hasISBN"
    /// <summary>
    /// When the publication is published.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasPublicationDateTime"></see></summary>
    let hasPublicationDateTime = _prefix "hasPublicationDateTime"
    /// <summary>
    /// any device that receives a signal or stimulus (as heat or pressure or light or motion etc.) and records it. (WordNet)
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#Sensor"></see></summary>
    let Sensor = _prefix "Sensor"
    /// <summary>
    /// the source of the Source Usage, i.e. where does it come from.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasSource"></see></summary>
    let hasSource = _prefix "hasSource"
    /// <summary>
    /// the time stamp when the source usage occurred.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasUsageDateTime"></see></summary>
    let hasUsageDateTime = _prefix "hasUsageDateTime"
    /// <summary>
    /// The query content that leads to the source usage. e.g. the query part of a URL.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasUsageQueryContent"></see></summary>
    let hasUsageQueryContent = _prefix "hasUsageQueryContent"
    /// <summary>
    /// Translation rules are special kinds of inference rules which are used to translate expressions from one language to the other.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#TranslationRule"></see></summary>
    let TranslationRule = _prefix "TranslationRule"
    /// <summary>
    /// language used by the target.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasToLanguage"></see></summary>
    let hasToLanguage = _prefix "hasToLanguage"
    /// <summary>
    /// language used by the source.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasFromLanguage"></see></summary>
    let hasFromLanguage = _prefix "hasFromLanguage"
    /// <summary>
    /// services implemented by software and available on the Web
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#WebService"></see></summary>
    let WebService = _prefix "WebService"
    /// <summary>
    /// Collection of files and related resources accessible through the World Wide Web and organized under a particular domain name. Typical files found at a Web site are HTML documents with their associated graphic image files (GIF, JPEG, etc.), scripted programs (in Perl, CGI, Java, etc.), and similar resources. The site's files are usually accessed through hypertext or hyperlinks embedded in other files. A Web site may consist of a single HTML file, or it may comprise hundreds or thousands of related files. A Web site's usual starting point or opening page, called a home page, usually functions as a table of contents or index, with links to other sections of the site. Web sites are hosted on one or more Web servers, which transfer files to client computers or other servers that request them using the HTTP protocol. Although the term ?ite?implies a single physical location, the files and resources of a Web site may actually be spread among several servers in different geographic locations.(adapted from Britannica Concise Encyclopedia).
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#Website"></see></summary>
    let Website = _prefix "Website"
    /// <summary>
    /// this is a common property and can be used to describe an agent's confidence
    ///         on a piece of information or an action step.It is typically used together with an object property
    ///         indicating who asserted the confidence. For example, an inference engine may be one example.
    ///         Although we did not specified its cardinality, it is typically used only once in one individual.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasConfidenceValue"></see></summary>
    let hasConfidenceValue = _prefix "hasConfidenceValue"
    /// <summary>
    /// The detailed description of the identified thing, e.g. a web page describing KIF language. An identified thing may have zero to many descriptions that could be written in different languages, format, and etc.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasDescription"></see></summary>
    let hasDescription = _prefix "hasDescription"
    /// <summary>
    /// The content encoding, e.g. "base64". The value of this property helps applications determine the decoder of the raw string.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasEncoding"></see></summary>
    let hasEncoding = _prefix "hasEncoding"
    /// <summary>
    /// The escape character used by a (formal) language (for parse use). It is used more like a comment indicator. This is used by InferenceML to embed metalangauge for proof checking (talk to Priyendra Deshwa).
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasEscapeCharacterSequence"></see></summary>
    let hasEscapeCharacterSequence = _prefix "hasEscapeCharacterSequence"
    /// <summary>
    ///   <see href="http://inference-web.org/2.0/pml-provenance.owl#hasLongPrettyName"></see>
    /// </summary>
    let hasLongPrettyName = _prefix "hasLongPrettyName"
    /// <summary>
    ///   <see href="http://inference-web.org/2.0/pml-provenance.owl#hasPrettyName"></see>
    /// </summary>
    let hasPrettyName = _prefix "hasPrettyName"
    /// <summary>
    /// An organization may have member agents such as persons and other organizations.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasMember"></see></summary>
    let hasMember = _prefix "hasMember"
    /// <summary>
    /// A well-defined string indicating the mime type of information content. Internet Media Types (MIME). see also http://www.iana.org/assignments/media-types/.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasMimetype"></see></summary>
    let hasMimetype = _prefix "hasMimetype"
    /// <summary>
    /// When the artifact has been modified.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasModificationDateTime"></see></summary>
    let hasModificationDateTime = _prefix "hasModificationDateTime"
    /// <summary>
    /// An agent responsible for making the document publicly available. see also http://purl.org/dc/elements/1.1/publisher.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasPublisher"></see></summary>
    let hasPublisher = _prefix "hasPublisher"
    /// <summary>
    /// it is sub-property of rdfs:comment. It is used to provide an example to help users understand the referred entity.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasRuleExample"></see></summary>
    let hasRuleExample = _prefix "hasRuleExample"
    /// <summary>
    /// An organization may have member agents such as persons and other organizations.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#isMemberOf"></see></summary>
    let isMemberOf = _prefix "isMemberOf"
    /// <summary>
    /// The inference engine used by an agent
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#usesInferenceEngine"></see></summary>
    let usesInferenceEngine = _prefix "usesInferenceEngine"
