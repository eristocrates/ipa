#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module pmlp =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://inference-web.org/2.0/pml-provenance.owl#" "pmlp"

    /// <summary>
    ///   <para>rdfs:label : Agent</para>
    ///   <para>rdfs:comment : actionalble entities.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#Agent">pmlp:Agent</a>
    /// </summary>
    let Agent = _prefixId.prefix "Agent"
    /// <summary>
    ///   <para>rdfs:label :  List of Agents</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#AgentList">pmlp:AgentList</a>
    /// </summary>
    let AgentList = _prefixId.prefix "AgentList"
    /// <summary>
    ///   <para>rdfs:label : Dataset</para>
    ///   <para>rdfs:comment : A dataset is a collection of data document whose information is encoded in a defined structure (for example, lists, tables, and databases). see also http://purl.org/dc/dcmitype/Dataset.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#Dataset">pmlp:Dataset</a>
    /// </summary>
    let Dataset = _prefixId.prefix "Dataset"
    /// <summary>
    ///   <para>rdfs:label : Declarative Rule</para>
    ///   <para>rdfs:comment : A declarative inference rule can be fully specified by patterns for premises and its conclusion.   For example, Modus Ponens, can be specified by the premise patterns ?A,  ?A -&amp;gt; ?B and the conclusion pattern ?B.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#DeclarativeRule">pmlp:DeclarativeRule</a>
    /// </summary>
    let DeclarativeRule = _prefixId.prefix "DeclarativeRule"
    /// <summary>
    ///   <para>rdfs:label : Document</para>
    ///   <para>rdfs:comment : A physical information container that is not actionable. They function like database.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#Document">pmlp:Document</a>
    /// </summary>
    let Document = _prefixId.prefix "Document"
    /// <summary>
    ///   <para>rdfs:label : Document Fragment</para>
    ///   <para>rdfs:comment : A fragment of document that can be used as source.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#DocumentFragment">pmlp:DocumentFragment</a>
    /// </summary>
    let DocumentFragment = _prefixId.prefix "DocumentFragment"
    /// <summary>
    ///   <para>rdfs:label : Document Fragment by Offset</para>
    ///   <para>rdfs:comment : We may treat a document a one dimensional string, so we can mark a fragment with two offsets. We don't use byte because characters in text document may be multi-bytes.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#DocumentFragmentByOffset">pmlp:DocumentFragmentByOffset</a>
    /// </summary>
    let DocumentFragmentByOffset = _prefixId.prefix "DocumentFragmentByOffset"
    /// <summary>
    ///   <para>rdfs:label : Document Fragment by Row/Column</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#DocumentFragmentByRowCol">pmlp:DocumentFragmentByRowCol</a>
    /// </summary>
    let DocumentFragmentByRowCol = _prefixId.prefix "DocumentFragmentByRowCol"
    /// <summary>
    ///   <para>rdfs:label : Empty Information</para>
    ///   <para>rdfs:comment : An instance of information indicating no conclusion has been derived, i.e. empty set of statements. In this case, the rawstring may contain some english message indicating no answer. </para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#EmptyInformation">pmlp:EmptyInformation</a>
    /// </summary>
    let EmptyInformation = _prefixId.prefix "EmptyInformation"
    /// <summary>
    ///   <para>rdfs:label : Format</para>
    ///   <para>rdfs:comment : A plan for the organization and arrangement of specified information. Examples: binary, text,  pdf, etc.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#Format">pmlp:Format</a>
    /// </summary>
    let Format = _prefixId.prefix "Format"
    /// <summary>
    ///   <para>rdfs:label : Identified Thing</para>
    ///   <para>rdfs:comment : The abstract root of provenance related concepts. It organizes a collection of common metadata about the referenced object, and it does not have any instance. </para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#IdentifiedThing">pmlp:IdentifiedThing</a>
    /// </summary>
    let IdentifiedThing = _prefixId.prefix "IdentifiedThing"
    /// <summary>
    ///   <para>rdfs:label : Inference Engine</para>
    ///   <para>rdfs:comment : An inference engine represents an engine that is able to produce a justification for a conclusion. Note that the phrase "inference engine" applies not only to reasoners but also to other systems like search engines which may justify their answers by direct assertion</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#InferenceEngine">pmlp:InferenceEngine</a>
    /// </summary>
    let InferenceEngine = _prefixId.prefix "InferenceEngine"
    /// <summary>
    ///   <para>rdfs:label : Inference Rule</para>
    ///   <para>rdfs:comment : Inference rules are used to derive conclusions from premises.
    /// Inference Web divides inference rules into three classes: Primitive and Derived and Translation.
    /// This is an abstract class without any direct instance. A primitive rule is an atomic rule with respect to an inference engine. An inference engine may support rules that it does not need to further decompose. Since a primitive rule is an inference engine dependent concept, we may find a rule is primitive to one inference engine but not to another engine. For example a `natural deduction reasoner R1 may define Modus Ponens as a primitive rule and another reasoner R2 may register Robinson's resolution rule as a primitive rule. The reasoner R2 may be able to derive a Modus Ponens rule using its primitive resolution rule. </para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#InferenceRule">pmlp:InferenceRule</a>
    /// </summary>
    let InferenceRule = _prefixId.prefix "InferenceRule"
    /// <summary>
    ///   <para>rdfs:comment : A piece of information, e.g. a formula in logic languages, and an utterance/word/phrase/sentence/paragraph/article in natural language. It is used as a range of iw:hasContent. This class and two of its sub-classes enable users to specify four types of semantics  (i) Information Annotation - annotate just the format and language used by the content of information; (ii) Information With Content - additionally provide the content of information that is materialized as string without loading a web page; (iii) Information external - additionally provide the URL for fetching the content; and (iv) Information - with every thing including the content string and URL. The second semantics is especially useful when the content is short or mainly used locally. For example, when learning by instruction, the utterances used for learning can be stored within the PML document without being externally stored. By assigning URI reference to information, we can even use owl:sameAs to capture the equivalence of two pieces of information. </para>
    ///   <para>rdfs:label : Information</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#Information">pmlp:Information</a>
    /// </summary>
    let Information = _prefixId.prefix "Information"
    /// <summary>
    ///   <para>rdfs:label : Language</para>
    ///   <para>rdfs:comment : The language used to encode the raw string, e.g. English, Knowledge Interchange Format (KIF) , and N3. Languages are in general registered at the core IWRegistry.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#Language">pmlp:Language</a>
    /// </summary>
    let Language = _prefixId.prefix "Language"
    /// <summary>
    ///   <para>rdfs:label : Learned Source Usage</para>
    ///   <para>rdfs:comment : A special type of source usage. It records the modification of sources - the question that initiates the learning process, the duration of learning, the original source and current source used by learning.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#LearnedSourceUsage">pmlp:LearnedSourceUsage</a>
    /// </summary>
    let LearnedSourceUsage = _prefixId.prefix "LearnedSourceUsage"
    /// <summary>
    ///   <para>rdfs:label : Method Rule</para>
    ///   <para>rdfs:comment : A method inference rule, uses patterns for premises and its conclusions, and additionally contains a method that must be applied.  In addition,
    /// the conclusion needs to be a valid output of the method, using the premises.  For example, procedural attachment is a common encoding form for method rules.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#MethodRule">pmlp:MethodRule</a>
    /// </summary>
    let MethodRule = _prefixId.prefix "MethodRule"
    /// <summary>
    ///   <para>rdfs:label : Ontology</para>
    ///   <para>rdfs:comment : An Ontology is a document that describes a vocabulary of terms and their correlations.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#Ontology">pmlp:Ontology</a>
    /// </summary>
    let Ontology = _prefixId.prefix "Ontology"
    /// <summary>
    ///   <para>rdfs:label : Organization</para>
    ///   <para>rdfs:comment : A group of agents organized for a particular purpose, e.g., KSL, stanford.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#Organization">pmlp:Organization</a>
    /// </summary>
    let Organization = _prefixId.prefix "Organization"
    /// <summary>
    ///   <para>rdfs:label : Person</para>
    ///   <para>rdfs:comment : A person</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#Person">pmlp:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>rdfs:label : Pretty Name Mapping</para>
    ///   <para>rdfs:comment : specially designed for pretty display purpose.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#PrettyNameMapping">pmlp:PrettyNameMapping</a>
    /// </summary>
    let PrettyNameMapping = _prefixId.prefix "PrettyNameMapping"
    /// <summary>
    ///   <para>rdfs:label :  List of PrettyNameMappings</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#PrettyNameMappingList">pmlp:PrettyNameMappingList</a>
    /// </summary>
    let PrettyNameMappingList = _prefixId.prefix "PrettyNameMappingList"
    /// <summary>
    ///   <para>rdfs:label : Publication</para>
    ///   <para>rdfs:comment : If we have two versions of the same publication, we need to create two instances of Publication. A publication may have multiple ISBNs.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#Publication">pmlp:Publication</a>
    /// </summary>
    let Publication = _prefixId.prefix "Publication"
    /// <summary>
    ///   <para>rdfs:label : Sensor</para>
    ///   <para>rdfs:comment : any device that receives a signal or stimulus (as heat or pressure or light or motion etc.) and records it. (WordNet)</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#Sensor">pmlp:Sensor</a>
    /// </summary>
    let Sensor = _prefixId.prefix "Sensor"
    /// <summary>
    ///   <para>rdfs:label : Software</para>
    ///   <para>rdfs:comment : written programs or procedures or rules and associated documentation pertaining to the operation of a computer system and that are stored in read/write memory.(WordNet)</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#Software">pmlp:Software</a>
    /// </summary>
    let Software = _prefixId.prefix "Software"
    /// <summary>
    ///   <para>rdfs:label : Source</para>
    ///   <para>rdfs:comment : A source refers to the source of information. It is the place where we obtain information.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#Source">pmlp:Source</a>
    /// </summary>
    let Source = _prefixId.prefix "Source"
    /// <summary>
    ///   <para>rdfs:label : Source Usage</para>
    ///   <para>rdfs:comment : A usage of the source. It records an access of a source at a certain date time.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#SourceUsage">pmlp:SourceUsage</a>
    /// </summary>
    let SourceUsage = _prefixId.prefix "SourceUsage"
    /// <summary>
    ///   <para>rdfs:label : Translation Rule</para>
    ///   <para>rdfs:comment : Translation rules are special kinds of inference rules which are used to translate expressions from one language to the other.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#TranslationRule">pmlp:TranslationRule</a>
    /// </summary>
    let TranslationRule = _prefixId.prefix "TranslationRule"
    /// <summary>
    ///   <para>rdfs:label : Web Service</para>
    ///   <para>rdfs:comment : services implemented by software and available on the Web</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#WebService">pmlp:WebService</a>
    /// </summary>
    let WebService = _prefixId.prefix "WebService"
    /// <summary>
    ///   <para>rdfs:label : Website</para>
    ///   <para>rdfs:comment : Collection of files and related resources accessible through the World Wide Web and organized under a particular domain name. Typical files found at a Web site are HTML documents with their associated graphic image files (GIF, JPEG, etc.), scripted programs (in Perl, CGI, Java, etc.), and similar resources. The site's files are usually accessed through hypertext or hyperlinks embedded in other files. A Web site may consist of a single HTML file, or it may comprise hundreds or thousands of related files. A Web site's usual starting point or opening page, called a home page, usually functions as a table of contents or index, with links to other sections of the site. Web sites are hosted on one or more Web servers, which transfer files to client computers or other servers that request them using the HTTP protocol. Although the term ?ite?implies a single physical location, the files and resources of a Web site may actually be spread among several servers in different geographic locations.(adapted from Britannica Concise Encyclopedia).</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#Website">pmlp:Website</a>
    /// </summary>
    let Website = _prefixId.prefix "Website"
    /// <summary>
    ///   <para>rdfs:label : abstract</para>
    ///   <para>rdfs:comment : The abstract of a document.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasAbstract">pmlp:hasAbstract</a>
    /// </summary>
    let hasAbstract = _prefixId.prefix "hasAbstract"
    /// <summary>
    ///   <para>rdfs:label : author(s)</para>
    ///   <para>rdfs:comment : A list of agents primarily responsible for making the artifact, for example, a person, an organization, or a software service. The AgentList enables an ordered list of agents; however, domain applications may optionally choose to ignore the order. We should be able to derive that each agent is the dc:creator of the artifact.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasAuthorList">pmlp:hasAuthorList</a>
    /// </summary>
    let hasAuthorList = _prefixId.prefix "hasAuthorList"
    /// <summary>
    ///   <para>rdfs:label : confidence</para>
    ///   <para>rdfs:comment : this is a common property and can be used to describe an agent's confidence
    ///         on a piece of information or an action step.It is typically used together with an object property
    ///         indicating who asserted the confidence. For example, an inference engine may be one example.
    ///         Although we did not specified its cardinality, it is typically used only once in one individual.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasConfidenceValue">pmlp:hasConfidenceValue</a>
    /// </summary>
    let hasConfidenceValue = _prefixId.prefix "hasConfidenceValue"
    /// <summary>
    ///   <para>rdfs:label : content</para>
    ///   <para>rdfs:comment :  This is a common concept that links to a piece of information. Currently, we focus on content of document, and inference rule.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasContent">pmlp:hasContent</a>
    /// </summary>
    let hasContent = _prefixId.prefix "hasContent"
    /// <summary>
    ///   <para>rdfs:label : created</para>
    ///   <para>rdfs:comment : When the artifact has been first created.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasCreationDateTime">pmlp:hasCreationDateTime</a>
    /// </summary>
    let hasCreationDateTime = _prefixId.prefix "hasCreationDateTime"
    /// <summary>
    ///   <para>rdfs:label : data-collection-end-datetime</para>
    ///   <para>rdfs:comment : the time stamp when data collection ended</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasDataCollectionEndDateTime">pmlp:hasDataCollectionEndDateTime</a>
    /// </summary>
    let hasDataCollectionEndDateTime = _prefixId.prefix "hasDataCollectionEndDateTime"

    /// <summary>
    ///   <para>rdfs:label : data-collection-start-datetime</para>
    ///   <para>rdfs:comment : the time stamp when data collection started</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasDataCollectionStartDateTime">pmlp:hasDataCollectionStartDateTime</a>
    /// </summary>
    let hasDataCollectionStartDateTime =
        _prefixId.prefix "hasDataCollectionStartDateTime"

    /// <summary>
    ///   <para>rdfs:label : description</para>
    ///   <para>rdfs:comment : The detailed description of the identified thing, e.g. a web page describing KIF language. An identified thing may have zero to many descriptions that could be written in different languages, format, and etc. </para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasDescription">pmlp:hasDescription</a>
    /// </summary>
    let hasDescription = _prefixId.prefix "hasDescription"
    /// <summary>
    ///   <para>rdfs:label : document</para>
    ///   <para>rdfs:comment : A document fragment always depend on one source document, which is also the source.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasDocument">pmlp:hasDocument</a>
    /// </summary>
    let hasDocument = _prefixId.prefix "hasDocument"
    /// <summary>
    ///   <para>rdfs:label : encoding</para>
    ///   <para>rdfs:comment : The content encoding, e.g. "base64". The value of this property helps applications determine the decoder of the raw string.	</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasEncoding">pmlp:hasEncoding</a>
    /// </summary>
    let hasEncoding = _prefixId.prefix "hasEncoding"
    /// <summary>
    ///   <para>rdfs:label : english-description-template</para>
    ///   <para>rdfs:comment : it is sub-property of rdfs:comment. It is also a simplified template for adding rule description template in English rather than using hasDescription.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasEnglishDescriptionTemplate">pmlp:hasEnglishDescriptionTemplate</a>
    /// </summary>
    let hasEnglishDescriptionTemplate = _prefixId.prefix "hasEnglishDescriptionTemplate"
    /// <summary>
    ///   <para>rdfs:label : escape character sequence</para>
    ///   <para>rdfs:comment : The escape character used by a (formal) language (for parse use). It is used more like a comment indicator. This is used by InferenceML to embed metalangauge for proof checking (talk to Priyendra Deshwa).</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasEscapeCharacterSequence">pmlp:hasEscapeCharacterSequence</a>
    /// </summary>
    let hasEscapeCharacterSequence = _prefixId.prefix "hasEscapeCharacterSequence"
    /// <summary>
    ///   <para>rdfs:label : format</para>
    ///   <para>rdfs:comment : it specifies the format of information, e.g. "pdf", "ppt" (Power Point). It is mainly used to determine the appropriate application for process/display purpose.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasFormat">pmlp:hasFormat</a>
    /// </summary>
    let hasFormat = _prefixId.prefix "hasFormat"
    /// <summary>
    ///   <para>rdfs:label : from-column</para>
    ///   <para>rdfs:comment : The from column of the fragment (inclusive, index based on 1)</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasFromCol">pmlp:hasFromCol</a>
    /// </summary>
    let hasFromCol = _prefixId.prefix "hasFromCol"
    /// <summary>
    ///   <para>rdfs:label : from-language</para>
    ///   <para>rdfs:comment : language used by the source.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasFromLanguage">pmlp:hasFromLanguage</a>
    /// </summary>
    let hasFromLanguage = _prefixId.prefix "hasFromLanguage"
    /// <summary>
    ///   <para>rdfs:label : from-offset</para>
    ///   <para>rdfs:comment : The from offset of the fragment (inclusive, index based on 0).</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasFromOffset">pmlp:hasFromOffset</a>
    /// </summary>
    let hasFromOffset = _prefixId.prefix "hasFromOffset"
    /// <summary>
    ///   <para>rdfs:label : from-row</para>
    ///   <para>rdfs:comment : The from row of the fragment (inclusive, index based on 1)</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasFromRow">pmlp:hasFromRow</a>
    /// </summary>
    let hasFromRow = _prefixId.prefix "hasFromRow"
    /// <summary>
    ///   <para>rdfs:label : isbn</para>
    ///   <para>rdfs:comment : The International Standard Book Number.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasISBN">pmlp:hasISBN</a>
    /// </summary>
    let hasISBN = _prefixId.prefix "hasISBN"
    /// <summary>
    ///   <para>rdfs:label : uses-inference-rule</para>
    ///   <para>rdfs:comment : The inference rules used by the inference engine</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasInferenceEngineRule">pmlp:hasInferenceEngineRule</a>
    /// </summary>
    let hasInferenceEngineRule = _prefixId.prefix "hasInferenceEngineRule"
    /// <summary>
    ///   <para>rdfs:label : language</para>
    ///   <para>rdfs:comment : it specifies the language used to encode information, e.g. "Tony's specialty is shellfish" is encoded in English. This property may also link to a registered formal language such as KIF.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasLanguage">pmlp:hasLanguage</a>
    /// </summary>
    let hasLanguage = _prefixId.prefix "hasLanguage"
    /// <summary>
    ///   <para>rdfs:label : long pretty name</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasLongPrettyName">pmlp:hasLongPrettyName</a>
    /// </summary>
    let hasLongPrettyName = _prefixId.prefix "hasLongPrettyName"
    /// <summary>
    ///   <para>rdfs:label : member</para>
    ///   <para>rdfs:comment : An organization may have member agents such as persons and other organizations.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasMember">pmlp:hasMember</a>
    /// </summary>
    let hasMember = _prefixId.prefix "hasMember"
    /// <summary>
    ///   <para>rdfs:label : mime-type</para>
    ///   <para>rdfs:comment : A well-defined string indicating the mime type of information content. Internet Media Types (MIME). see also http://www.iana.org/assignments/media-types/.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasMimetype">pmlp:hasMimetype</a>
    /// </summary>
    let hasMimetype = _prefixId.prefix "hasMimetype"
    /// <summary>
    ///   <para>rdfs:label : last modified</para>
    ///   <para>rdfs:comment : When the artifact has been modified.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasModificationDateTime">pmlp:hasModificationDateTime</a>
    /// </summary>
    let hasModificationDateTime = _prefixId.prefix "hasModificationDateTime"
    /// <summary>
    ///   <para>rdfs:label : name</para>
    ///   <para>rdfs:comment : the human readable label of the identified thing.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasName">pmlp:hasName</a>
    /// </summary>
    let hasName = _prefixId.prefix "hasName"
    /// <summary>
    ///   <para>rdfs:label : owner</para>
    ///   <para>rdfs:comment : the owner of a thing.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasOwner">pmlp:hasOwner</a>
    /// </summary>
    let hasOwner = _prefixId.prefix "hasOwner"
    /// <summary>
    ///   <para>rdfs:label : pretty name</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasPrettyName">pmlp:hasPrettyName</a>
    /// </summary>
    let hasPrettyName = _prefixId.prefix "hasPrettyName"
    /// <summary>
    ///   <para>rdfs:label : pretty name mapping</para>
    ///   <para>rdfs:comment : The rendering instruction. UI tools may feed the PrettyNameMapping in sequence to string replace operation to get a pretty rendering of the conclusion of a NodeSet. It only applies to the conclusion of the node set.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasPrettyNameMappingList">pmlp:hasPrettyNameMappingList</a>
    /// </summary>
    let hasPrettyNameMappingList = _prefixId.prefix "hasPrettyNameMappingList"
    /// <summary>
    ///   <para>rdfs:label : pretty-string</para>
    ///   <para>rdfs:comment : the human friendly presentation of the information. Its format is text and it is usually written in English.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasPrettyString">pmlp:hasPrettyString</a>
    /// </summary>
    let hasPrettyString = _prefixId.prefix "hasPrettyString"
    /// <summary>
    ///   <para>rdfs:label : published in</para>
    ///   <para>rdfs:comment : When the publication is published.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasPublicationDateTime">pmlp:hasPublicationDateTime</a>
    /// </summary>
    let hasPublicationDateTime = _prefixId.prefix "hasPublicationDateTime"
    /// <summary>
    ///   <para>rdfs:label : publisher</para>
    ///   <para>rdfs:comment : An agent responsible for making the document publicly available. see also http://purl.org/dc/elements/1.1/publisher.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasPublisher">pmlp:hasPublisher</a>
    /// </summary>
    let hasPublisher = _prefixId.prefix "hasPublisher"
    /// <summary>
    ///   <para>rdfs:label : raw-string</para>
    ///   <para>rdfs:comment : materialized version of the content of information</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasRawString">pmlp:hasRawString</a>
    /// </summary>
    let hasRawString = _prefixId.prefix "hasRawString"
    /// <summary>
    ///   <para>rdfs:label : reference source usage</para>
    ///   <para>rdfs:comment : Explain how this information is obtained from a source: by whom, when, which source and which part of the source.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasReferenceSourceUsage">pmlp:hasReferenceSourceUsage</a>
    /// </summary>
    let hasReferenceSourceUsage = _prefixId.prefix "hasReferenceSourceUsage"
    /// <summary>
    ///   <para>rdfs:label : replacee</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasReplacee">pmlp:hasReplacee</a>
    /// </summary>
    let hasReplacee = _prefixId.prefix "hasReplacee"
    /// <summary>
    ///   <para>rdfs:label : rule example</para>
    ///   <para>rdfs:comment : it is sub-property of rdfs:comment. It is used to provide an example to help users understand the referred entity.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasRuleExample">pmlp:hasRuleExample</a>
    /// </summary>
    let hasRuleExample = _prefixId.prefix "hasRuleExample"
    /// <summary>
    ///   <para>rdfs:label : short pretty name</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasShortPrettyName">pmlp:hasShortPrettyName</a>
    /// </summary>
    let hasShortPrettyName = _prefixId.prefix "hasShortPrettyName"
    /// <summary>
    ///   <para>rdfs:label : source</para>
    ///   <para>rdfs:comment : the source of the Source Usage, i.e. where does it come from.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasSource">pmlp:hasSource</a>
    /// </summary>
    let hasSource = _prefixId.prefix "hasSource"
    /// <summary>
    ///   <para>rdfs:label : to-column</para>
    ///   <para>rdfs:comment : The to column of the fragment (inclusive, index based on 1)</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasToCol">pmlp:hasToCol</a>
    /// </summary>
    let hasToCol = _prefixId.prefix "hasToCol"
    /// <summary>
    ///   <para>rdfs:label : to-language</para>
    ///   <para>rdfs:comment : language used by the target.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasToLanguage">pmlp:hasToLanguage</a>
    /// </summary>
    let hasToLanguage = _prefixId.prefix "hasToLanguage"
    /// <summary>
    ///   <para>rdfs:label : to-offset</para>
    ///   <para>rdfs:comment : The to offset of the fragment (exclusive, index based on 0)</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasToOffset">pmlp:hasToOffset</a>
    /// </summary>
    let hasToOffset = _prefixId.prefix "hasToOffset"
    /// <summary>
    ///   <para>rdfs:label : to-row</para>
    ///   <para>rdfs:comment : The to row of the fragment (inclusive, index based on 1)</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasToRow">pmlp:hasToRow</a>
    /// </summary>
    let hasToRow = _prefixId.prefix "hasToRow"
    /// <summary>
    ///   <para>rdfs:label : url</para>
    ///   <para>rdfs:comment : The URL of a relevant web page.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasURL">pmlp:hasURL</a>
    /// </summary>
    let hasURL = _prefixId.prefix "hasURL"
    /// <summary>
    ///   <para>rdfs:label : usage-datetime</para>
    ///   <para>rdfs:comment : the time stamp when the source usage occurred.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasUsageDateTime">pmlp:hasUsageDateTime</a>
    /// </summary>
    let hasUsageDateTime = _prefixId.prefix "hasUsageDateTime"
    /// <summary>
    ///   <para>rdfs:label : query-content</para>
    ///   <para>rdfs:comment : The query content that leads to the source usage. e.g. the query part of a URL.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasUsageQueryContent">pmlp:hasUsageQueryContent</a>
    /// </summary>
    let hasUsageQueryContent = _prefixId.prefix "hasUsageQueryContent"
    /// <summary>
    ///   <para>rdfs:label : version</para>
    ///   <para>rdfs:comment : the version number.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#hasVersion">pmlp:hasVersion</a>
    /// </summary>
    let hasVersion = _prefixId.prefix "hasVersion"
    /// <summary>
    ///   <para>rdfs:label : member of</para>
    ///   <para>rdfs:comment : An organization may have member agents such as persons and other organizations.</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#isMemberOf">pmlp:isMemberOf</a>
    /// </summary>
    let isMemberOf = _prefixId.prefix "isMemberOf"
    /// <summary>
    ///   <para>rdfs:label : uses-inference-engine</para>
    ///   <para>rdfs:comment : The inference engine used by an agent</para>
    ///   <a href="http://inference-web.org/2.0/pml-provenance.owl#usesInferenceEngine">pmlp:usesInferenceEngine</a>
    /// </summary>
    let usesInferenceEngine = _prefixId.prefix "usesInferenceEngine"
