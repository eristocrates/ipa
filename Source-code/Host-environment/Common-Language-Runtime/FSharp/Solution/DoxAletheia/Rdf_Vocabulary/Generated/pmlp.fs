namespace http.inference_web.org._2._0.pml_provenance.owl.hash

open DoxAletheia.Rdf_Vocabulary

module pmlp =
    let _namespace_name = "http://inference-web.org/2.0/pml-provenance.owl#"
    /// <summary>
    /// actionalble entities.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#Agent"></see></summary>
    let Agent = Namespaced_IRI.parse _namespace_name "Agent" |> NamespacedName
    /// <summary>
    /// A source refers to the source of information. It is the place where we obtain information.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#Source"></see></summary>
    let Source = Namespaced_IRI.parse _namespace_name "Source" |> NamespacedName
    /// <summary>
    ///   <see href="http://inference-web.org/2.0/pml-provenance.owl#AgentList"></see>
    /// </summary>
    let AgentList = Namespaced_IRI.parse _namespace_name "AgentList" |> NamespacedName
    /// <summary>
    /// A dataset is a collection of data document whose information is encoded in a defined structure (for example, lists, tables, and databases). see also http://purl.org/dc/dcmitype/Dataset.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#Dataset"></see></summary>
    let Dataset = Namespaced_IRI.parse _namespace_name "Dataset" |> NamespacedName
    /// <summary>
    /// A physical information container that is not actionable. They function like database.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#Document"></see></summary>
    let Document = Namespaced_IRI.parse _namespace_name "Document" |> NamespacedName

    /// <summary>
    /// A declarative inference rule can be fully specified by patterns for premises and its conclusion.   For example, Modus Ponens, can be specified by the premise patterns ?A,  ?A -&amp;gt; ?B and the conclusion pattern ?B.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#DeclarativeRule"></see></summary>
    let DeclarativeRule =
        Namespaced_IRI.parse _namespace_name "DeclarativeRule" |> NamespacedName

    /// <summary>
    /// Inference rules are used to derive conclusions from premises.
    /// Inference Web divides inference rules into three classes: Primitive and Derived and Translation.
    /// This is an abstract class without any direct instance. A primitive rule is an atomic rule with respect to an inference engine. An inference engine may support rules that it does not need to further decompose. Since a primitive rule is an inference engine dependent concept, we may find a rule is primitive to one inference engine but not to another engine. For example a `natural deduction reasoner R1 may define Modus Ponens as a primitive rule and another reasoner R2 may register Robinson's resolution rule as a primitive rule. The reasoner R2 may be able to derive a Modus Ponens rule using its primitive resolution rule.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#InferenceRule"></see></summary>
    let InferenceRule =
        Namespaced_IRI.parse _namespace_name "InferenceRule" |> NamespacedName

    /// <summary>
    ///  This is a common concept that links to a piece of information. Currently, we focus on content of document, and inference rule.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasContent"></see></summary>
    let hasContent = Namespaced_IRI.parse _namespace_name "hasContent" |> NamespacedName
    /// <summary>
    /// the version number.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasVersion"></see></summary>
    let hasVersion = Namespaced_IRI.parse _namespace_name "hasVersion" |> NamespacedName

    /// <summary>
    /// The abstract of a document.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasAbstract"></see></summary>
    let hasAbstract =
        Namespaced_IRI.parse _namespace_name "hasAbstract" |> NamespacedName

    /// <summary>
    /// A fragment of document that can be used as source.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#DocumentFragment"></see></summary>
    let DocumentFragment =
        Namespaced_IRI.parse _namespace_name "DocumentFragment" |> NamespacedName

    /// <summary>
    /// A document fragment always depend on one source document, which is also the source.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasDocument"></see></summary>
    let hasDocument =
        Namespaced_IRI.parse _namespace_name "hasDocument" |> NamespacedName

    /// <summary>
    /// We may treat a document a one dimensional string, so we can mark a fragment with two offsets. We don't use byte because characters in text document may be multi-bytes.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#DocumentFragmentByOffset"></see></summary>
    let DocumentFragmentByOffset =
        Namespaced_IRI.parse _namespace_name "DocumentFragmentByOffset" |> NamespacedName

    /// <summary>
    /// The from offset of the fragment (inclusive, index based on 0).
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasFromOffset"></see></summary>
    let hasFromOffset =
        Namespaced_IRI.parse _namespace_name "hasFromOffset" |> NamespacedName

    /// <summary>
    /// The to offset of the fragment (exclusive, index based on 0)
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasToOffset"></see></summary>
    let hasToOffset =
        Namespaced_IRI.parse _namespace_name "hasToOffset" |> NamespacedName

    /// <summary>
    ///   <see href="http://inference-web.org/2.0/pml-provenance.owl#DocumentFragmentByRowCol"></see>
    /// </summary>
    let DocumentFragmentByRowCol =
        Namespaced_IRI.parse _namespace_name "DocumentFragmentByRowCol" |> NamespacedName

    /// <summary>
    /// The to row of the fragment (inclusive, index based on 1)
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasToRow"></see></summary>
    let hasToRow = Namespaced_IRI.parse _namespace_name "hasToRow" |> NamespacedName
    /// <summary>
    /// The to column of the fragment (inclusive, index based on 1)
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasToCol"></see></summary>
    let hasToCol = Namespaced_IRI.parse _namespace_name "hasToCol" |> NamespacedName
    /// <summary>
    /// The from column of the fragment (inclusive, index based on 1)
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasFromCol"></see></summary>
    let hasFromCol = Namespaced_IRI.parse _namespace_name "hasFromCol" |> NamespacedName
    /// <summary>
    /// The from row of the fragment (inclusive, index based on 1)
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasFromRow"></see></summary>
    let hasFromRow = Namespaced_IRI.parse _namespace_name "hasFromRow" |> NamespacedName

    /// <summary>
    /// An instance of information indicating no conclusion has been derived, i.e. empty set of statements. In this case, the rawstring may contain some english message indicating no answer.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#EmptyInformation"></see></summary>
    let EmptyInformation =
        Namespaced_IRI.parse _namespace_name "EmptyInformation" |> NamespacedName

    /// <summary>
    /// A piece of information, e.g. a formula in logic languages, and an utterance/word/phrase/sentence/paragraph/article in natural language. It is used as a range of iw:hasContent. This class and two of its sub-classes enable users to specify four types of semantics  (i) Information Annotation - annotate just the format and language used by the content of information; (ii) Information With Content - additionally provide the content of information that is materialized as string without loading a web page; (iii) Information external - additionally provide the URL for fetching the content; and (iv) Information - with every thing including the content string and URL. The second semantics is especially useful when the content is short or mainly used locally. For example, when learning by instruction, the utterances used for learning can be stored within the PML document without being externally stored. By assigning URI reference to information, we can even use owl:sameAs to capture the equivalence of two pieces of information.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#Information"></see></summary>
    let Information =
        Namespaced_IRI.parse _namespace_name "Information" |> NamespacedName

    /// <summary>
    /// A plan for the organization and arrangement of specified information. Examples: binary, text,  pdf, etc.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#Format"></see></summary>
    let Format = Namespaced_IRI.parse _namespace_name "Format" |> NamespacedName

    /// <summary>
    /// The abstract root of provenance related concepts. It organizes a collection of common metadata about the referenced object, and it does not have any instance.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#IdentifiedThing"></see></summary>
    let IdentifiedThing =
        Namespaced_IRI.parse _namespace_name "IdentifiedThing" |> NamespacedName

    /// <summary>
    /// the human readable label of the identified thing.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasName"></see></summary>
    let hasName = Namespaced_IRI.parse _namespace_name "hasName" |> NamespacedName

    /// <summary>
    /// A list of agents primarily responsible for making the artifact, for example, a person, an organization, or a software service. The AgentList enables an ordered list of agents; however, domain applications may optionally choose to ignore the order. We should be able to derive that each agent is the dc:creator of the artifact.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasAuthorList"></see></summary>
    let hasAuthorList =
        Namespaced_IRI.parse _namespace_name "hasAuthorList" |> NamespacedName

    /// <summary>
    /// When the artifact has been first created.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasCreationDateTime"></see></summary>
    let hasCreationDateTime =
        Namespaced_IRI.parse _namespace_name "hasCreationDateTime" |> NamespacedName

    /// <summary>
    /// the owner of a thing.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasOwner"></see></summary>
    let hasOwner = Namespaced_IRI.parse _namespace_name "hasOwner" |> NamespacedName

    /// <summary>
    /// An inference engine represents an engine that is able to produce a justification for a conclusion. Note that the phrase "inference engine" applies not only to reasoners but also to other systems like search engines which may justify their answers by direct assertion
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#InferenceEngine"></see></summary>
    let InferenceEngine =
        Namespaced_IRI.parse _namespace_name "InferenceEngine" |> NamespacedName

    /// <summary>
    /// The inference rules used by the inference engine
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasInferenceEngineRule"></see></summary>
    let hasInferenceEngineRule =
        Namespaced_IRI.parse _namespace_name "hasInferenceEngineRule" |> NamespacedName

    /// <summary>
    /// written programs or procedures or rules and associated documentation pertaining to the operation of a computer system and that are stored in read/write memory.(WordNet)
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#Software"></see></summary>
    let Software = Namespaced_IRI.parse _namespace_name "Software" |> NamespacedName

    /// <summary>
    /// it is sub-property of rdfs:comment. It is also a simplified template for adding rule description template in English rather than using hasDescription.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasEnglishDescriptionTemplate"></see></summary>
    let hasEnglishDescriptionTemplate =
        Namespaced_IRI.parse _namespace_name "hasEnglishDescriptionTemplate" |> NamespacedName

    /// <summary>
    /// The URL of a relevant web page.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasURL"></see></summary>
    let hasURL = Namespaced_IRI.parse _namespace_name "hasURL" |> NamespacedName

    /// <summary>
    /// it specifies the language used to encode information, e.g. "Tony's specialty is shellfish" is encoded in English. This property may also link to a registered formal language such as KIF.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasLanguage"></see></summary>
    let hasLanguage =
        Namespaced_IRI.parse _namespace_name "hasLanguage" |> NamespacedName

    /// <summary>
    /// the human friendly presentation of the information. Its format is text and it is usually written in English.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasPrettyString"></see></summary>
    let hasPrettyString =
        Namespaced_IRI.parse _namespace_name "hasPrettyString" |> NamespacedName

    /// <summary>
    /// The rendering instruction. UI tools may feed the PrettyNameMapping in sequence to string replace operation to get a pretty rendering of the conclusion of a NodeSet. It only applies to the conclusion of the node set.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasPrettyNameMappingList"></see></summary>
    let hasPrettyNameMappingList =
        Namespaced_IRI.parse _namespace_name "hasPrettyNameMappingList" |> NamespacedName

    /// <summary>
    /// materialized version of the content of information
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasRawString"></see></summary>
    let hasRawString =
        Namespaced_IRI.parse _namespace_name "hasRawString" |> NamespacedName

    /// <summary>
    /// it specifies the format of information, e.g. "pdf", "ppt" (Power Point). It is mainly used to determine the appropriate application for process/display purpose.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasFormat"></see></summary>
    let hasFormat = Namespaced_IRI.parse _namespace_name "hasFormat" |> NamespacedName

    /// <summary>
    /// Explain how this information is obtained from a source: by whom, when, which source and which part of the source.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasReferenceSourceUsage"></see></summary>
    let hasReferenceSourceUsage =
        Namespaced_IRI.parse _namespace_name "hasReferenceSourceUsage" |> NamespacedName

    /// <summary>
    /// The language used to encode the raw string, e.g. English, Knowledge Interchange Format (KIF) , and N3. Languages are in general registered at the core IWRegistry.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#Language"></see></summary>
    let Language = Namespaced_IRI.parse _namespace_name "Language" |> NamespacedName

    /// <summary>
    /// A special type of source usage. It records the modification of sources - the question that initiates the learning process, the duration of learning, the original source and current source used by learning.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#LearnedSourceUsage"></see></summary>
    let LearnedSourceUsage =
        Namespaced_IRI.parse _namespace_name "LearnedSourceUsage" |> NamespacedName

    /// <summary>
    /// the time stamp when data collection started
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasDataCollectionStartDateTime"></see></summary>
    let hasDataCollectionStartDateTime =
        Namespaced_IRI.parse _namespace_name "hasDataCollectionStartDateTime" |> NamespacedName

    /// <summary>
    /// the time stamp when data collection ended
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasDataCollectionEndDateTime"></see></summary>
    let hasDataCollectionEndDateTime =
        Namespaced_IRI.parse _namespace_name "hasDataCollectionEndDateTime" |> NamespacedName

    /// <summary>
    /// A usage of the source. It records an access of a source at a certain date time.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#SourceUsage"></see></summary>
    let SourceUsage =
        Namespaced_IRI.parse _namespace_name "SourceUsage" |> NamespacedName

    /// <summary>
    /// A method inference rule, uses patterns for premises and its conclusions, and additionally contains a method that must be applied.  In addition,
    /// the conclusion needs to be a valid output of the method, using the premises.  For example, procedural attachment is a common encoding form for method rules.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#MethodRule"></see></summary>
    let MethodRule = Namespaced_IRI.parse _namespace_name "MethodRule" |> NamespacedName
    /// <summary>
    /// An Ontology is a document that describes a vocabulary of terms and their correlations.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#Ontology"></see></summary>
    let Ontology = Namespaced_IRI.parse _namespace_name "Ontology" |> NamespacedName

    /// <summary>
    /// A group of agents organized for a particular purpose, e.g., KSL, stanford.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#Organization"></see></summary>
    let Organization =
        Namespaced_IRI.parse _namespace_name "Organization" |> NamespacedName

    /// <summary>
    /// A person
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#Person"></see></summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName

    /// <summary>
    /// specially designed for pretty display purpose.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#PrettyNameMapping"></see></summary>
    let PrettyNameMapping =
        Namespaced_IRI.parse _namespace_name "PrettyNameMapping" |> NamespacedName

    /// <summary>
    ///   <see href="http://inference-web.org/2.0/pml-provenance.owl#hasReplacee"></see>
    /// </summary>
    let hasReplacee =
        Namespaced_IRI.parse _namespace_name "hasReplacee" |> NamespacedName

    /// <summary>
    ///   <see href="http://inference-web.org/2.0/pml-provenance.owl#hasShortPrettyName"></see>
    /// </summary>
    let hasShortPrettyName =
        Namespaced_IRI.parse _namespace_name "hasShortPrettyName" |> NamespacedName

    /// <summary>
    ///   <see href="http://inference-web.org/2.0/pml-provenance.owl#PrettyNameMappingList"></see>
    /// </summary>
    let PrettyNameMappingList =
        Namespaced_IRI.parse _namespace_name "PrettyNameMappingList" |> NamespacedName

    /// <summary>
    /// If we have two versions of the same publication, we need to create two instances of Publication. A publication may have multiple ISBNs.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#Publication"></see></summary>
    let Publication =
        Namespaced_IRI.parse _namespace_name "Publication" |> NamespacedName

    /// <summary>
    /// The International Standard Book Number.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasISBN"></see></summary>
    let hasISBN = Namespaced_IRI.parse _namespace_name "hasISBN" |> NamespacedName

    /// <summary>
    /// When the publication is published.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasPublicationDateTime"></see></summary>
    let hasPublicationDateTime =
        Namespaced_IRI.parse _namespace_name "hasPublicationDateTime" |> NamespacedName

    /// <summary>
    /// any device that receives a signal or stimulus (as heat or pressure or light or motion etc.) and records it. (WordNet)
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#Sensor"></see></summary>
    let Sensor = Namespaced_IRI.parse _namespace_name "Sensor" |> NamespacedName
    /// <summary>
    /// the source of the Source Usage, i.e. where does it come from.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasSource"></see></summary>
    let hasSource = Namespaced_IRI.parse _namespace_name "hasSource" |> NamespacedName

    /// <summary>
    /// the time stamp when the source usage occurred.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasUsageDateTime"></see></summary>
    let hasUsageDateTime =
        Namespaced_IRI.parse _namespace_name "hasUsageDateTime" |> NamespacedName

    /// <summary>
    /// The query content that leads to the source usage. e.g. the query part of a URL.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasUsageQueryContent"></see></summary>
    let hasUsageQueryContent =
        Namespaced_IRI.parse _namespace_name "hasUsageQueryContent" |> NamespacedName

    /// <summary>
    /// Translation rules are special kinds of inference rules which are used to translate expressions from one language to the other.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#TranslationRule"></see></summary>
    let TranslationRule =
        Namespaced_IRI.parse _namespace_name "TranslationRule" |> NamespacedName

    /// <summary>
    /// language used by the target.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasToLanguage"></see></summary>
    let hasToLanguage =
        Namespaced_IRI.parse _namespace_name "hasToLanguage" |> NamespacedName

    /// <summary>
    /// language used by the source.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasFromLanguage"></see></summary>
    let hasFromLanguage =
        Namespaced_IRI.parse _namespace_name "hasFromLanguage" |> NamespacedName

    /// <summary>
    /// services implemented by software and available on the Web
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#WebService"></see></summary>
    let WebService = Namespaced_IRI.parse _namespace_name "WebService" |> NamespacedName
    /// <summary>
    /// Collection of files and related resources accessible through the World Wide Web and organized under a particular domain name. Typical files found at a Web site are HTML documents with their associated graphic image files (GIF, JPEG, etc.), scripted programs (in Perl, CGI, Java, etc.), and similar resources. The site's files are usually accessed through hypertext or hyperlinks embedded in other files. A Web site may consist of a single HTML file, or it may comprise hundreds or thousands of related files. A Web site's usual starting point or opening page, called a home page, usually functions as a table of contents or index, with links to other sections of the site. Web sites are hosted on one or more Web servers, which transfer files to client computers or other servers that request them using the HTTP protocol. Although the term ?ite?implies a single physical location, the files and resources of a Web site may actually be spread among several servers in different geographic locations.(adapted from Britannica Concise Encyclopedia).
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#Website"></see></summary>
    let Website = Namespaced_IRI.parse _namespace_name "Website" |> NamespacedName

    /// <summary>
    /// this is a common property and can be used to describe an agent's confidence
    ///         on a piece of information or an action step.It is typically used together with an object property
    ///         indicating who asserted the confidence. For example, an inference engine may be one example.
    ///         Although we did not specified its cardinality, it is typically used only once in one individual.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasConfidenceValue"></see></summary>
    let hasConfidenceValue =
        Namespaced_IRI.parse _namespace_name "hasConfidenceValue" |> NamespacedName

    /// <summary>
    /// The detailed description of the identified thing, e.g. a web page describing KIF language. An identified thing may have zero to many descriptions that could be written in different languages, format, and etc.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasDescription"></see></summary>
    let hasDescription =
        Namespaced_IRI.parse _namespace_name "hasDescription" |> NamespacedName

    /// <summary>
    /// The content encoding, e.g. "base64". The value of this property helps applications determine the decoder of the raw string.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasEncoding"></see></summary>
    let hasEncoding =
        Namespaced_IRI.parse _namespace_name "hasEncoding" |> NamespacedName

    /// <summary>
    /// The escape character used by a (formal) language (for parse use). It is used more like a comment indicator. This is used by InferenceML to embed metalangauge for proof checking (talk to Priyendra Deshwa).
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasEscapeCharacterSequence"></see></summary>
    let hasEscapeCharacterSequence =
        Namespaced_IRI.parse _namespace_name "hasEscapeCharacterSequence" |> NamespacedName

    /// <summary>
    ///   <see href="http://inference-web.org/2.0/pml-provenance.owl#hasLongPrettyName"></see>
    /// </summary>
    let hasLongPrettyName =
        Namespaced_IRI.parse _namespace_name "hasLongPrettyName" |> NamespacedName

    /// <summary>
    ///   <see href="http://inference-web.org/2.0/pml-provenance.owl#hasPrettyName"></see>
    /// </summary>
    let hasPrettyName =
        Namespaced_IRI.parse _namespace_name "hasPrettyName" |> NamespacedName

    /// <summary>
    /// An organization may have member agents such as persons and other organizations.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasMember"></see></summary>
    let hasMember = Namespaced_IRI.parse _namespace_name "hasMember" |> NamespacedName

    /// <summary>
    /// A well-defined string indicating the mime type of information content. Internet Media Types (MIME). see also http://www.iana.org/assignments/media-types/.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasMimetype"></see></summary>
    let hasMimetype =
        Namespaced_IRI.parse _namespace_name "hasMimetype" |> NamespacedName

    /// <summary>
    /// When the artifact has been modified.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasModificationDateTime"></see></summary>
    let hasModificationDateTime =
        Namespaced_IRI.parse _namespace_name "hasModificationDateTime" |> NamespacedName

    /// <summary>
    /// An agent responsible for making the document publicly available. see also http://purl.org/dc/elements/1.1/publisher.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasPublisher"></see></summary>
    let hasPublisher =
        Namespaced_IRI.parse _namespace_name "hasPublisher" |> NamespacedName

    /// <summary>
    /// it is sub-property of rdfs:comment. It is used to provide an example to help users understand the referred entity.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#hasRuleExample"></see></summary>
    let hasRuleExample =
        Namespaced_IRI.parse _namespace_name "hasRuleExample" |> NamespacedName

    /// <summary>
    /// An organization may have member agents such as persons and other organizations.
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#isMemberOf"></see></summary>
    let isMemberOf = Namespaced_IRI.parse _namespace_name "isMemberOf" |> NamespacedName

    /// <summary>
    /// The inference engine used by an agent
    /// <see href="http://inference-web.org/2.0/pml-provenance.owl#usesInferenceEngine"></see></summary>
    let usesInferenceEngine =
        Namespaced_IRI.parse _namespace_name "usesInferenceEngine" |> NamespacedName
