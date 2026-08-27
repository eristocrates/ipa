namespace http.inference_web.org._2._0.pml_provenance.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pmlp =
    let _namespace_iri = Namespace_Iri pmlp |> NamespaceIRI
    /// <summary>
    ///   <para>pmlp:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"actionalble entities."</para>
    /// labels<para>"Agent"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#Agent">http://inference-web.org/2.0/pml-provenance.owl#Agent</seealso>
    let Agent = Prefixed_Name(pmlp, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:AgentList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>" List of Agents"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#AgentList">http://inference-web.org/2.0/pml-provenance.owl#AgentList</seealso>
    let AgentList = Prefixed_Name(pmlp, "AgentList") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:Dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A dataset is a collection of data document whose information is encoded in a defined structure (for example, lists, tables, and databases). see also http://purl.org/dc/dcmitype/Dataset."</para>
    /// labels<para>"Dataset"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#Dataset">http://inference-web.org/2.0/pml-provenance.owl#Dataset</seealso>
    let Dataset = Prefixed_Name(pmlp, "Dataset") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:DeclarativeRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A declarative inference rule can be fully specified by patterns for premises and its conclusion.   For example, Modus Ponens, can be specified by the premise patterns ?A,  ?A -&amp;gt; ?B and the conclusion pattern ?B."</para>
    /// labels<para>"Declarative Rule"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#DeclarativeRule">http://inference-web.org/2.0/pml-provenance.owl#DeclarativeRule</seealso>
    let DeclarativeRule = Prefixed_Name(pmlp, "DeclarativeRule") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:Document</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A physical information container that is not actionable. They function like database."</para>
    /// labels<para>"Document"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#Document">http://inference-web.org/2.0/pml-provenance.owl#Document</seealso>
    let Document = Prefixed_Name(pmlp, "Document") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:DocumentFragment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A fragment of document that can be used as source."</para>
    /// labels<para>"Document Fragment"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#DocumentFragment">http://inference-web.org/2.0/pml-provenance.owl#DocumentFragment</seealso>
    let DocumentFragment = Prefixed_Name(pmlp, "DocumentFragment") |> PrefixedName

    /// <summary>
    ///   <para>pmlp:DocumentFragmentByOffset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"We may treat a document a one dimensional string, so we can mark a fragment with two offsets. We don't use byte because characters in text document may be multi-bytes."</para>
    /// labels<para>"Document Fragment by Offset"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#DocumentFragmentByOffset">http://inference-web.org/2.0/pml-provenance.owl#DocumentFragmentByOffset</seealso>
    let DocumentFragmentByOffset =
        Prefixed_Name(pmlp, "DocumentFragmentByOffset") |> PrefixedName

    /// <summary>
    ///   <para>pmlp:DocumentFragmentByRowCol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Document Fragment by Row/Column"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#DocumentFragmentByRowCol">http://inference-web.org/2.0/pml-provenance.owl#DocumentFragmentByRowCol</seealso>
    let DocumentFragmentByRowCol =
        Prefixed_Name(pmlp, "DocumentFragmentByRowCol") |> PrefixedName

    /// <summary>
    ///   <para>pmlp:EmptyInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An instance of information indicating no conclusion has been derived, i.e. empty set of statements. In this case, the rawstring may contain some english message indicating no answer. "</para>
    /// labels<para>"Empty Information"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#EmptyInformation">http://inference-web.org/2.0/pml-provenance.owl#EmptyInformation</seealso>
    let EmptyInformation = Prefixed_Name(pmlp, "EmptyInformation") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:Format</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A plan for the organization and arrangement of specified information. Examples: binary, text,  pdf, etc."</para>
    /// labels<para>"Format"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#Format">http://inference-web.org/2.0/pml-provenance.owl#Format</seealso>
    let Format = Prefixed_Name(pmlp, "Format") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:IdentifiedThing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The abstract root of provenance related concepts. It organizes a collection of common metadata about the referenced object, and it does not have any instance. "</para>
    /// labels<para>"Identified Thing"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#IdentifiedThing">http://inference-web.org/2.0/pml-provenance.owl#IdentifiedThing</seealso>
    let IdentifiedThing = Prefixed_Name(pmlp, "IdentifiedThing") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:InferenceEngine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An inference engine represents an engine that is able to produce a justification for a conclusion. Note that the phrase "inference engine" applies not only to reasoners but also to other systems like search engines which may justify their answers by direct assertion"</para>
    /// labels<para>"Inference Engine"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#InferenceEngine">http://inference-web.org/2.0/pml-provenance.owl#InferenceEngine</seealso>
    let InferenceEngine = Prefixed_Name(pmlp, "InferenceEngine") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:InferenceRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Inference rules are used to derive conclusions from premises.
    /// Inference Web divides inference rules into three classes: Primitive and Derived and Translation.
    /// This is an abstract class without any direct instance. A primitive rule is an atomic rule with respect to an inference engine. An inference engine may support rules that it does not need to further decompose. Since a primitive rule is an inference engine dependent concept, we may find a rule is primitive to one inference engine but not to another engine. For example a `natural deduction reasoner R1 may define Modus Ponens as a primitive rule and another reasoner R2 may register Robinson's resolution rule as a primitive rule. The reasoner R2 may be able to derive a Modus Ponens rule using its primitive resolution rule. "</para>
    /// labels<para>"Inference Rule"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#InferenceRule">http://inference-web.org/2.0/pml-provenance.owl#InferenceRule</seealso>
    let InferenceRule = Prefixed_Name(pmlp, "InferenceRule") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:Information</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A piece of information, e.g. a formula in logic languages, and an utterance/word/phrase/sentence/paragraph/article in natural language. It is used as a range of iw:hasContent. This class and two of its sub-classes enable users to specify four types of semantics  (i) Information Annotation - annotate just the format and language used by the content of information; (ii) Information With Content - additionally provide the content of information that is materialized as string without loading a web page; (iii) Information external - additionally provide the URL for fetching the content; and (iv) Information - with every thing including the content string and URL. The second semantics is especially useful when the content is short or mainly used locally. For example, when learning by instruction, the utterances used for learning can be stored within the PML document without being externally stored. By assigning URI reference to information, we can even use owl:sameAs to capture the equivalence of two pieces of information. "</para>
    /// labels<para>"Information"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#Information">http://inference-web.org/2.0/pml-provenance.owl#Information</seealso>
    let Information = Prefixed_Name(pmlp, "Information") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:Language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The language used to encode the raw string, e.g. English, Knowledge Interchange Format (KIF) , and N3. Languages are in general registered at the core IWRegistry."</para>
    /// labels<para>"Language"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#Language">http://inference-web.org/2.0/pml-provenance.owl#Language</seealso>
    let Language = Prefixed_Name(pmlp, "Language") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:LearnedSourceUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A special type of source usage. It records the modification of sources - the question that initiates the learning process, the duration of learning, the original source and current source used by learning."</para>
    /// labels<para>"Learned Source Usage"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#LearnedSourceUsage">http://inference-web.org/2.0/pml-provenance.owl#LearnedSourceUsage</seealso>
    let LearnedSourceUsage = Prefixed_Name(pmlp, "LearnedSourceUsage") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:MethodRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A method inference rule, uses patterns for premises and its conclusions, and additionally contains a method that must be applied.  In addition,
    /// the conclusion needs to be a valid output of the method, using the premises.  For example, procedural attachment is a common encoding form for method rules."</para>
    /// labels<para>"Method Rule"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#MethodRule">http://inference-web.org/2.0/pml-provenance.owl#MethodRule</seealso>
    let MethodRule = Prefixed_Name(pmlp, "MethodRule") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:Ontology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Ontology is a document that describes a vocabulary of terms and their correlations."</para>
    /// labels<para>"Ontology"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#Ontology">http://inference-web.org/2.0/pml-provenance.owl#Ontology</seealso>
    let Ontology = Prefixed_Name(pmlp, "Ontology") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A group of agents organized for a particular purpose, e.g., KSL, stanford."</para>
    /// labels<para>"Organization"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#Organization">http://inference-web.org/2.0/pml-provenance.owl#Organization</seealso>
    let Organization = Prefixed_Name(pmlp, "Organization") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person"</para>
    /// labels<para>"Person"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#Person">http://inference-web.org/2.0/pml-provenance.owl#Person</seealso>
    let Person = Prefixed_Name(pmlp, "Person") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:PrettyNameMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"specially designed for pretty display purpose."</para>
    /// labels<para>"Pretty Name Mapping"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#PrettyNameMapping">http://inference-web.org/2.0/pml-provenance.owl#PrettyNameMapping</seealso>
    let PrettyNameMapping = Prefixed_Name(pmlp, "PrettyNameMapping") |> PrefixedName

    /// <summary>
    ///   <para>pmlp:PrettyNameMappingList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>" List of PrettyNameMappings"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#PrettyNameMappingList">http://inference-web.org/2.0/pml-provenance.owl#PrettyNameMappingList</seealso>
    let PrettyNameMappingList =
        Prefixed_Name(pmlp, "PrettyNameMappingList") |> PrefixedName

    /// <summary>
    ///   <para>pmlp:Publication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"If we have two versions of the same publication, we need to create two instances of Publication. A publication may have multiple ISBNs."</para>
    /// labels<para>"Publication"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#Publication">http://inference-web.org/2.0/pml-provenance.owl#Publication</seealso>
    let Publication = Prefixed_Name(pmlp, "Publication") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"any device that receives a signal or stimulus (as heat or pressure or light or motion etc.) and records it. (WordNet)"</para>
    /// labels<para>"Sensor"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#Sensor">http://inference-web.org/2.0/pml-provenance.owl#Sensor</seealso>
    let Sensor = Prefixed_Name(pmlp, "Sensor") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:Software</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"written programs or procedures or rules and associated documentation pertaining to the operation of a computer system and that are stored in read/write memory.(WordNet)"</para>
    /// labels<para>"Software"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#Software">http://inference-web.org/2.0/pml-provenance.owl#Software</seealso>
    let Software = Prefixed_Name(pmlp, "Software") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:Source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A source refers to the source of information. It is the place where we obtain information."</para>
    /// labels<para>"Source"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#Source">http://inference-web.org/2.0/pml-provenance.owl#Source</seealso>
    let Source = Prefixed_Name(pmlp, "Source") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:SourceUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A usage of the source. It records an access of a source at a certain date time."</para>
    /// labels<para>"Source Usage"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#SourceUsage">http://inference-web.org/2.0/pml-provenance.owl#SourceUsage</seealso>
    let SourceUsage = Prefixed_Name(pmlp, "SourceUsage") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:TranslationRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Translation rules are special kinds of inference rules which are used to translate expressions from one language to the other."</para>
    /// labels<para>"Translation Rule"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#TranslationRule">http://inference-web.org/2.0/pml-provenance.owl#TranslationRule</seealso>
    let TranslationRule = Prefixed_Name(pmlp, "TranslationRule") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:WebService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"services implemented by software and available on the Web"</para>
    /// labels<para>"Web Service"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#WebService">http://inference-web.org/2.0/pml-provenance.owl#WebService</seealso>
    let WebService = Prefixed_Name(pmlp, "WebService") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:Website</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Collection of files and related resources accessible through the World Wide Web and organized under a particular domain name. Typical files found at a Web site are HTML documents with their associated graphic image files (GIF, JPEG, etc.), scripted programs (in Perl, CGI, Java, etc.), and similar resources. The site's files are usually accessed through hypertext or hyperlinks embedded in other files. A Web site may consist of a single HTML file, or it may comprise hundreds or thousands of related files. A Web site's usual starting point or opening page, called a home page, usually functions as a table of contents or index, with links to other sections of the site. Web sites are hosted on one or more Web servers, which transfer files to client computers or other servers that request them using the HTTP protocol. Although the term ?ite?implies a single physical location, the files and resources of a Web site may actually be spread among several servers in different geographic locations.(adapted from Britannica Concise Encyclopedia)."</para>
    /// labels<para>"Website"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#Website">http://inference-web.org/2.0/pml-provenance.owl#Website</seealso>
    let Website = Prefixed_Name(pmlp, "Website") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:hasAbstract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The abstract of a document."</para>
    /// labels<para>"abstract"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasAbstract">http://inference-web.org/2.0/pml-provenance.owl#hasAbstract</seealso>
    let hasAbstract = Prefixed_Name(pmlp, "hasAbstract") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:hasAuthorList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A list of agents primarily responsible for making the artifact, for example, a person, an organization, or a software service. The AgentList enables an ordered list of agents; however, domain applications may optionally choose to ignore the order. We should be able to derive that each agent is the dc:creator of the artifact."</para>
    /// labels<para>"author(s)"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasAuthorList">http://inference-web.org/2.0/pml-provenance.owl#hasAuthorList</seealso>
    let hasAuthorList = Prefixed_Name(pmlp, "hasAuthorList") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:hasConfidenceValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"this is a common property and can be used to describe an agent's confidence
    ///         on a piece of information or an action step.It is typically used together with an object property
    ///         indicating who asserted the confidence. For example, an inference engine may be one example.
    ///         Although we did not specified its cardinality, it is typically used only once in one individual."</para>
    /// labels<para>"confidence"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasConfidenceValue">http://inference-web.org/2.0/pml-provenance.owl#hasConfidenceValue</seealso>
    let hasConfidenceValue = Prefixed_Name(pmlp, "hasConfidenceValue") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:hasContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>" This is a common concept that links to a piece of information. Currently, we focus on content of document, and inference rule."</para>
    /// labels<para>"content"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasContent">http://inference-web.org/2.0/pml-provenance.owl#hasContent</seealso>
    let hasContent = Prefixed_Name(pmlp, "hasContent") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:hasCreationDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"When the artifact has been first created."</para>
    /// labels<para>"created"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasCreationDateTime">http://inference-web.org/2.0/pml-provenance.owl#hasCreationDateTime</seealso>
    let hasCreationDateTime = Prefixed_Name(pmlp, "hasCreationDateTime") |> PrefixedName

    /// <summary>
    ///   <para>pmlp:hasDataCollectionEndDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the time stamp when data collection ended"</para>
    /// labels<para>"data-collection-end-datetime"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasDataCollectionEndDateTime">http://inference-web.org/2.0/pml-provenance.owl#hasDataCollectionEndDateTime</seealso>
    let hasDataCollectionEndDateTime =
        Prefixed_Name(pmlp, "hasDataCollectionEndDateTime") |> PrefixedName

    /// <summary>
    ///   <para>pmlp:hasDataCollectionStartDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the time stamp when data collection started"</para>
    /// labels<para>"data-collection-start-datetime"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasDataCollectionStartDateTime">http://inference-web.org/2.0/pml-provenance.owl#hasDataCollectionStartDateTime</seealso>
    let hasDataCollectionStartDateTime =
        Prefixed_Name(pmlp, "hasDataCollectionStartDateTime") |> PrefixedName

    /// <summary>
    ///   <para>pmlp:hasDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The detailed description of the identified thing, e.g. a web page describing KIF language. An identified thing may have zero to many descriptions that could be written in different languages, format, and etc. "</para>
    /// labels<para>"description"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasDescription">http://inference-web.org/2.0/pml-provenance.owl#hasDescription</seealso>
    let hasDescription = Prefixed_Name(pmlp, "hasDescription") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:hasDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A document fragment always depend on one source document, which is also the source."</para>
    /// labels<para>"document"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasDocument">http://inference-web.org/2.0/pml-provenance.owl#hasDocument</seealso>
    let hasDocument = Prefixed_Name(pmlp, "hasDocument") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:hasEncoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The content encoding, e.g. "base64". The value of this property helps applications determine the decoder of the raw string.	"</para>
    /// labels<para>"encoding"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasEncoding">http://inference-web.org/2.0/pml-provenance.owl#hasEncoding</seealso>
    let hasEncoding = Prefixed_Name(pmlp, "hasEncoding") |> PrefixedName

    /// <summary>
    ///   <para>pmlp:hasEnglishDescriptionTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"it is sub-property of rdfs:comment. It is also a simplified template for adding rule description template in English rather than using hasDescription."</para>
    /// labels<para>"english-description-template"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasEnglishDescriptionTemplate">http://inference-web.org/2.0/pml-provenance.owl#hasEnglishDescriptionTemplate</seealso>
    let hasEnglishDescriptionTemplate =
        Prefixed_Name(pmlp, "hasEnglishDescriptionTemplate") |> PrefixedName

    /// <summary>
    ///   <para>pmlp:hasEscapeCharacterSequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The escape character used by a (formal) language (for parse use). It is used more like a comment indicator. This is used by InferenceML to embed metalangauge for proof checking (talk to Priyendra Deshwa)."</para>
    /// labels<para>"escape character sequence"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasEscapeCharacterSequence">http://inference-web.org/2.0/pml-provenance.owl#hasEscapeCharacterSequence</seealso>
    let hasEscapeCharacterSequence =
        Prefixed_Name(pmlp, "hasEscapeCharacterSequence") |> PrefixedName

    /// <summary>
    ///   <para>pmlp:hasFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"it specifies the format of information, e.g. "pdf", "ppt" (Power Point). It is mainly used to determine the appropriate application for process/display purpose."</para>
    /// labels<para>"format"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasFormat">http://inference-web.org/2.0/pml-provenance.owl#hasFormat</seealso>
    let hasFormat = Prefixed_Name(pmlp, "hasFormat") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:hasFromCol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The from column of the fragment (inclusive, index based on 1)"</para>
    /// labels<para>"from-column"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasFromCol">http://inference-web.org/2.0/pml-provenance.owl#hasFromCol</seealso>
    let hasFromCol = Prefixed_Name(pmlp, "hasFromCol") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:hasFromLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"language used by the source."</para>
    /// labels<para>"from-language"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasFromLanguage">http://inference-web.org/2.0/pml-provenance.owl#hasFromLanguage</seealso>
    let hasFromLanguage = Prefixed_Name(pmlp, "hasFromLanguage") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:hasFromOffset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The from offset of the fragment (inclusive, index based on 0)."</para>
    /// labels<para>"from-offset"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasFromOffset">http://inference-web.org/2.0/pml-provenance.owl#hasFromOffset</seealso>
    let hasFromOffset = Prefixed_Name(pmlp, "hasFromOffset") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:hasFromRow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The from row of the fragment (inclusive, index based on 1)"</para>
    /// labels<para>"from-row"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasFromRow">http://inference-web.org/2.0/pml-provenance.owl#hasFromRow</seealso>
    let hasFromRow = Prefixed_Name(pmlp, "hasFromRow") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:hasISBN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The International Standard Book Number."</para>
    /// labels<para>"isbn"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasISBN">http://inference-web.org/2.0/pml-provenance.owl#hasISBN</seealso>
    let hasISBN = Prefixed_Name(pmlp, "hasISBN") |> PrefixedName

    /// <summary>
    ///   <para>pmlp:hasInferenceEngineRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The inference rules used by the inference engine"</para>
    /// labels<para>"uses-inference-rule"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasInferenceEngineRule">http://inference-web.org/2.0/pml-provenance.owl#hasInferenceEngineRule</seealso>
    let hasInferenceEngineRule =
        Prefixed_Name(pmlp, "hasInferenceEngineRule") |> PrefixedName

    /// <summary>
    ///   <para>pmlp:hasLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"it specifies the language used to encode information, e.g. "Tony's specialty is shellfish" is encoded in English. This property may also link to a registered formal language such as KIF."</para>
    /// labels<para>"language"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasLanguage">http://inference-web.org/2.0/pml-provenance.owl#hasLanguage</seealso>
    let hasLanguage = Prefixed_Name(pmlp, "hasLanguage") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:hasLongPrettyName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"long pretty name"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasLongPrettyName">http://inference-web.org/2.0/pml-provenance.owl#hasLongPrettyName</seealso>
    let hasLongPrettyName = Prefixed_Name(pmlp, "hasLongPrettyName") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:hasMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An organization may have member agents such as persons and other organizations."</para>
    /// labels<para>"member"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasMember">http://inference-web.org/2.0/pml-provenance.owl#hasMember</seealso>
    let hasMember = Prefixed_Name(pmlp, "hasMember") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:hasMimetype</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A well-defined string indicating the mime type of information content. Internet Media Types (MIME). see also http://www.iana.org/assignments/media-types/."</para>
    /// labels<para>"mime-type"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasMimetype">http://inference-web.org/2.0/pml-provenance.owl#hasMimetype</seealso>
    let hasMimetype = Prefixed_Name(pmlp, "hasMimetype") |> PrefixedName

    /// <summary>
    ///   <para>pmlp:hasModificationDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"When the artifact has been modified."</para>
    /// labels<para>"last modified"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasModificationDateTime">http://inference-web.org/2.0/pml-provenance.owl#hasModificationDateTime</seealso>
    let hasModificationDateTime =
        Prefixed_Name(pmlp, "hasModificationDateTime") |> PrefixedName

    /// <summary>
    ///   <para>pmlp:hasName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the human readable label of the identified thing."</para>
    /// labels<para>"name"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasName">http://inference-web.org/2.0/pml-provenance.owl#hasName</seealso>
    let hasName = Prefixed_Name(pmlp, "hasName") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:hasOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"the owner of a thing."</para>
    /// labels<para>"owner"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasOwner">http://inference-web.org/2.0/pml-provenance.owl#hasOwner</seealso>
    let hasOwner = Prefixed_Name(pmlp, "hasOwner") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:hasPrettyName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"pretty name"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasPrettyName">http://inference-web.org/2.0/pml-provenance.owl#hasPrettyName</seealso>
    let hasPrettyName = Prefixed_Name(pmlp, "hasPrettyName") |> PrefixedName

    /// <summary>
    ///   <para>pmlp:hasPrettyNameMappingList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The rendering instruction. UI tools may feed the PrettyNameMapping in sequence to string replace operation to get a pretty rendering of the conclusion of a NodeSet. It only applies to the conclusion of the node set."</para>
    /// labels<para>"pretty name mapping"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasPrettyNameMappingList">http://inference-web.org/2.0/pml-provenance.owl#hasPrettyNameMappingList</seealso>
    let hasPrettyNameMappingList =
        Prefixed_Name(pmlp, "hasPrettyNameMappingList") |> PrefixedName

    /// <summary>
    ///   <para>pmlp:hasPrettyString</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the human friendly presentation of the information. Its format is text and it is usually written in English."</para>
    /// labels<para>"pretty-string"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasPrettyString">http://inference-web.org/2.0/pml-provenance.owl#hasPrettyString</seealso>
    let hasPrettyString = Prefixed_Name(pmlp, "hasPrettyString") |> PrefixedName

    /// <summary>
    ///   <para>pmlp:hasPublicationDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"When the publication is published."</para>
    /// labels<para>"published in"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasPublicationDateTime">http://inference-web.org/2.0/pml-provenance.owl#hasPublicationDateTime</seealso>
    let hasPublicationDateTime =
        Prefixed_Name(pmlp, "hasPublicationDateTime") |> PrefixedName

    /// <summary>
    ///   <para>pmlp:hasPublisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An agent responsible for making the document publicly available. see also http://purl.org/dc/elements/1.1/publisher."</para>
    /// labels<para>"publisher"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasPublisher">http://inference-web.org/2.0/pml-provenance.owl#hasPublisher</seealso>
    let hasPublisher = Prefixed_Name(pmlp, "hasPublisher") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:hasRawString</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"materialized version of the content of information"</para>
    /// labels<para>"raw-string"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasRawString">http://inference-web.org/2.0/pml-provenance.owl#hasRawString</seealso>
    let hasRawString = Prefixed_Name(pmlp, "hasRawString") |> PrefixedName

    /// <summary>
    ///   <para>pmlp:hasReferenceSourceUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Explain how this information is obtained from a source: by whom, when, which source and which part of the source."</para>
    /// labels<para>"reference source usage"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasReferenceSourceUsage">http://inference-web.org/2.0/pml-provenance.owl#hasReferenceSourceUsage</seealso>
    let hasReferenceSourceUsage =
        Prefixed_Name(pmlp, "hasReferenceSourceUsage") |> PrefixedName

    /// <summary>
    ///   <para>pmlp:hasReplacee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"replacee"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasReplacee">http://inference-web.org/2.0/pml-provenance.owl#hasReplacee</seealso>
    let hasReplacee = Prefixed_Name(pmlp, "hasReplacee") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:hasRuleExample</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"it is sub-property of rdfs:comment. It is used to provide an example to help users understand the referred entity."</para>
    /// labels<para>"rule example"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasRuleExample">http://inference-web.org/2.0/pml-provenance.owl#hasRuleExample</seealso>
    let hasRuleExample = Prefixed_Name(pmlp, "hasRuleExample") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:hasShortPrettyName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"short pretty name"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasShortPrettyName">http://inference-web.org/2.0/pml-provenance.owl#hasShortPrettyName</seealso>
    let hasShortPrettyName = Prefixed_Name(pmlp, "hasShortPrettyName") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:hasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"the source of the Source Usage, i.e. where does it come from."</para>
    /// labels<para>"source"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasSource">http://inference-web.org/2.0/pml-provenance.owl#hasSource</seealso>
    let hasSource = Prefixed_Name(pmlp, "hasSource") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:hasToCol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The to column of the fragment (inclusive, index based on 1)"</para>
    /// labels<para>"to-column"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasToCol">http://inference-web.org/2.0/pml-provenance.owl#hasToCol</seealso>
    let hasToCol = Prefixed_Name(pmlp, "hasToCol") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:hasToLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"language used by the target."</para>
    /// labels<para>"to-language"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasToLanguage">http://inference-web.org/2.0/pml-provenance.owl#hasToLanguage</seealso>
    let hasToLanguage = Prefixed_Name(pmlp, "hasToLanguage") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:hasToOffset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The to offset of the fragment (exclusive, index based on 0)"</para>
    /// labels<para>"to-offset"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasToOffset">http://inference-web.org/2.0/pml-provenance.owl#hasToOffset</seealso>
    let hasToOffset = Prefixed_Name(pmlp, "hasToOffset") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:hasToRow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The to row of the fragment (inclusive, index based on 1)"</para>
    /// labels<para>"to-row"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasToRow">http://inference-web.org/2.0/pml-provenance.owl#hasToRow</seealso>
    let hasToRow = Prefixed_Name(pmlp, "hasToRow") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:hasURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The URL of a relevant web page."</para>
    /// labels<para>"url"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasURL">http://inference-web.org/2.0/pml-provenance.owl#hasURL</seealso>
    let hasURL = Prefixed_Name(pmlp, "hasURL") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:hasUsageDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the time stamp when the source usage occurred."</para>
    /// labels<para>"usage-datetime"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasUsageDateTime">http://inference-web.org/2.0/pml-provenance.owl#hasUsageDateTime</seealso>
    let hasUsageDateTime = Prefixed_Name(pmlp, "hasUsageDateTime") |> PrefixedName

    /// <summary>
    ///   <para>pmlp:hasUsageQueryContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The query content that leads to the source usage. e.g. the query part of a URL."</para>
    /// labels<para>"query-content"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasUsageQueryContent">http://inference-web.org/2.0/pml-provenance.owl#hasUsageQueryContent</seealso>
    let hasUsageQueryContent =
        Prefixed_Name(pmlp, "hasUsageQueryContent") |> PrefixedName

    /// <summary>
    ///   <para>pmlp:hasVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"the version number."</para>
    /// labels<para>"version"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#hasVersion">http://inference-web.org/2.0/pml-provenance.owl#hasVersion</seealso>
    let hasVersion = Prefixed_Name(pmlp, "hasVersion") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:isMemberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An organization may have member agents such as persons and other organizations."</para>
    /// labels<para>"member of"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#isMemberOf">http://inference-web.org/2.0/pml-provenance.owl#isMemberOf</seealso>
    let isMemberOf = Prefixed_Name(pmlp, "isMemberOf") |> PrefixedName
    /// <summary>
    ///   <para>pmlp:usesInferenceEngine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The inference engine used by an agent"</para>
    /// labels<para>"uses-inference-engine"</para></remarks>
    /// <seealso href="http://inference-web.org/2.0/pml-provenance.owl#usesInferenceEngine">http://inference-web.org/2.0/pml-provenance.owl#usesInferenceEngine</seealso>
    let usesInferenceEngine = Prefixed_Name(pmlp, "usesInferenceEngine") |> PrefixedName
