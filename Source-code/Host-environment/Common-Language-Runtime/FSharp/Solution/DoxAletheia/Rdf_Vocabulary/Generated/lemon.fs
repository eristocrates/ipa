namespace http.lemon_model.net.lemon.hash

open DoxAletheia.Rdf_Vocabulary

module lemon =
    let _namespace_name = "http://lemon-model.net/lemon#"
    /// <summary>
    /// A slot representing a gap that must be filled in realising a lexical entry in a given projection
    /// <see href="http://lemon-model.net/lemon#Argument"></see></summary>
    let Argument = Namespaced_IRI.parse _namespace_name "Argument" |> NamespacedName

    /// <summary>
    ///   <see href="http://lemon-model.net/lemon#LemonElement"></see>
    /// </summary>
    let LemonElement =
        Namespaced_IRI.parse _namespace_name "LemonElement" |> NamespacedName

    /// <summary>
    /// A terminal node in a phrase structure graph, i.e., a realisable, lexical element.
    /// <see href="http://lemon-model.net/lemon#PhraseElement"></see></summary>
    let PhraseElement =
        Namespaced_IRI.parse _namespace_name "PhraseElement" |> NamespacedName

    /// <summary>
    /// An entry in the lexicon. This may be any morpheme, word, compound, phrase or clause that is included in the lexicon
    /// <see href="http://lemon-model.net/lemon#LexicalEntry"></see></summary>
    let LexicalEntry =
        Namespaced_IRI.parse _namespace_name "LexicalEntry" |> NamespacedName

    /// <summary>
    /// A value that can be used in the range of linguistic property
    /// <see href="http://lemon-model.net/lemon#PropertyValue"></see></summary>
    let PropertyValue =
        Namespaced_IRI.parse _namespace_name "PropertyValue" |> NamespacedName

    /// <summary>
    /// A given written or spoken realisation of a lexical entry
    /// <see href="http://lemon-model.net/lemon#Form"></see></summary>
    let Form = Namespaced_IRI.parse _namespace_name "Form" |> NamespacedName
    /// <summary>
    /// A stereotypical example of the usage of a given lexical entry. The most common example of projections are subcategorization frames which describe the slots taken by the arguments of a verb.
    /// <see href="http://lemon-model.net/lemon#Frame"></see></summary>
    let Frame = Namespaced_IRI.parse _namespace_name "Frame" |> NamespacedName

    /// <summary>
    /// The indicator of a given syntactic argument, normally a preposition or other particle marker or a linguistic property such as case
    /// <see href="http://lemon-model.net/lemon#SynRoleMarker"></see></summary>
    let SynRoleMarker =
        Namespaced_IRI.parse _namespace_name "SynRoleMarker" |> NamespacedName

    /// <summary>
    /// A node in a phrase structure or dependency parse graph
    /// <see href="http://lemon-model.net/lemon#Node"></see></summary>
    let Node = Namespaced_IRI.parse _namespace_name "Node" |> NamespacedName

    /// <summary>
    /// A definition of a sememe, that is the a text describing the exact meaning of the lexical entry when its sense is the given ontology reference
    /// <see href="http://lemon-model.net/lemon#SenseDefinition"></see></summary>
    let SenseDefinition =
        Namespaced_IRI.parse _namespace_name "SenseDefinition" |> NamespacedName

    /// <summary>
    /// The lexicon object. This object is specific to the given language and/or domain it describes
    /// <see href="http://lemon-model.net/lemon#Lexicon"></see></summary>
    let Lexicon = Namespaced_IRI.parse _namespace_name "Lexicon" |> NamespacedName
    /// <summary>
    /// A constituent element of a lexical entry. This may be a word in a multi-word lexical element or a constituent of a compound word
    /// <see href="http://lemon-model.net/lemon#Component"></see></summary>
    let Component = Namespaced_IRI.parse _namespace_name "Component" |> NamespacedName

    /// <summary>
    /// Represents the intersection in meaning between the lexical entry and the ontology entity. This is used as the ontology entity and lexical entry may not be in one-to-one correspondence as such the existence of a sense between them states meerly that there are some cases when this lexical entry refer to the ontology entity and vica versa. Mapping elements can be used to further specify this relation
    /// <see href="http://lemon-model.net/lemon#LexicalSense"></see></summary>
    let LexicalSense =
        Namespaced_IRI.parse _namespace_name "LexicalSense" |> NamespacedName

    /// <summary>
    /// An example of the usage of a lexical entry when refering to the ontology entity given by the sememe's reference. This should in effect be an example of the form used in context. E.g., "this is a *usage example*"
    /// <see href="http://lemon-model.net/lemon#UsageExample"></see></summary>
    let UsageExample =
        Namespaced_IRI.parse _namespace_name "UsageExample" |> NamespacedName

    /// <summary>
    /// Denotes the lexical entry represented by the component
    /// <see href="http://lemon-model.net/lemon#element"></see></summary>
    let element = Namespaced_IRI.parse _namespace_name "element" |> NamespacedName

    /// <summary>
    /// A node within a list of components. This should generally be a blank node,see rdf:List
    /// <see href="http://lemon-model.net/lemon#ComponentList"></see></summary>
    let ComponentList =
        Namespaced_IRI.parse _namespace_name "ComponentList" |> NamespacedName

    /// <summary>
    /// A realisation of a given form
    /// <see href="http://lemon-model.net/lemon#representation"></see></summary>
    let representation =
        Namespaced_IRI.parse _namespace_name "representation" |> NamespacedName

    /// <summary>
    /// Structural element for all elements that can be tagged with a language
    /// <see href="http://lemon-model.net/lemon#HasLanguage"></see></summary>
    let HasLanguage =
        Namespaced_IRI.parse _namespace_name "HasLanguage" |> NamespacedName

    /// <summary>
    ///   <see href="http://lemon-model.net/lemon#HasPattern"></see>
    /// </summary>
    let HasPattern = Namespaced_IRI.parse _namespace_name "HasPattern" |> NamespacedName

    /// <summary>
    /// An evaluable condition on when a sense applies.
    /// <see href="http://lemon-model.net/lemon#LexicalCondition"></see></summary>
    let LexicalCondition =
        Namespaced_IRI.parse _namespace_name "LexicalCondition" |> NamespacedName

    /// <summary>
    /// Indicates the pragmatic or discourse context in which a sense applies
    /// <see href="http://lemon-model.net/lemon#LexicalContext"></see></summary>
    let LexicalContext =
        Namespaced_IRI.parse _namespace_name "LexicalContext" |> NamespacedName

    /// <summary>
    /// Denotes a written representation of a lexical entry
    /// <see href="http://lemon-model.net/lemon#lexicalForm"></see></summary>
    let lexicalForm =
        Namespaced_IRI.parse _namespace_name "lexicalForm" |> NamespacedName

    /// <summary>
    /// The canonical ("dictionary") form of the lexical entry. This can be used to indicate the "lemma" form of a lexical entry
    /// <see href="http://lemon-model.net/lemon#canonicalForm"></see></summary>
    let canonicalForm =
        Namespaced_IRI.parse _namespace_name "canonicalForm" |> NamespacedName

    /// <summary>
    /// Indicates that the relation between a compound sense and its atomic subsenses
    /// <see href="http://lemon-model.net/lemon#subsense"></see></summary>
    let subsense = Namespaced_IRI.parse _namespace_name "subsense" |> NamespacedName
    /// <summary>
    /// A reference to an external resource
    /// <see href="http://lemon-model.net/lemon#reference"></see></summary>
    let reference = Namespaced_IRI.parse _namespace_name "reference" |> NamespacedName

    /// <summary>
    /// Indicates the topic of a lexicon or a lexical entry
    /// <see href="http://lemon-model.net/lemon#LexicalTopic"></see></summary>
    let LexicalTopic =
        Namespaced_IRI.parse _namespace_name "LexicalTopic" |> NamespacedName

    /// <summary>
    /// Indicates an entry in a lexicon
    /// <see href="http://lemon-model.net/lemon#entry"></see></summary>
    let entry = Namespaced_IRI.parse _namespace_name "entry" |> NamespacedName
    /// <summary>
    /// The language of a given lexicon. This should be some ISO-639 string
    /// <see href="http://lemon-model.net/lemon#language"></see></summary>
    let language = Namespaced_IRI.parse _namespace_name "language" |> NamespacedName

    /// <summary>
    ///   <see href="http://lemon-model.net/lemon#MorphPattern"></see>
    /// </summary>
    let MorphPattern =
        Namespaced_IRI.parse _namespace_name "MorphPattern" |> NamespacedName

    /// <summary>
    ///   <see href="http://lemon-model.net/lemon#MorphTransform"></see>
    /// </summary>
    let MorphTransform =
        Namespaced_IRI.parse _namespace_name "MorphTransform" |> NamespacedName

    /// <summary>
    /// Denotes the relation between a node in a multi-word expression structure and an edge
    /// <see href="http://lemon-model.net/lemon#edge"></see></summary>
    let edge = Namespaced_IRI.parse _namespace_name "edge" |> NamespacedName
    /// <summary>
    /// Denotes the component referred to by the lex (pre-terminal) of the phrase structure
    /// <see href="http://lemon-model.net/lemon#leaf"></see></summary>
    let leaf = Namespaced_IRI.parse _namespace_name "leaf" |> NamespacedName

    /// <summary>
    /// The class of constituents, that is types applied to nodes in a phrase structure graph
    /// <see href="http://lemon-model.net/lemon#NodeConstituent"></see></summary>
    let NodeConstituent =
        Namespaced_IRI.parse _namespace_name "NodeConstituent" |> NamespacedName

    /// <summary>
    /// An affix is a morpheme that is attached to a word stem to form a new word.  Use this for lexical entries with only abstract forms
    /// <see href="http://lemon-model.net/lemon#Part"></see></summary>
    let Part = Namespaced_IRI.parse _namespace_name "Part" |> NamespacedName
    /// <summary>
    /// A phrase in lemon is defined in the looser sense of a sequence of words, it does not have to a fully grammatical phrase
    /// <see href="http://lemon-model.net/lemon#Phrase"></see></summary>
    let Phrase = Namespaced_IRI.parse _namespace_name "Phrase" |> NamespacedName

    /// <summary>
    /// Denotes a component of a lexical entry
    /// <see href="http://lemon-model.net/lemon#decomposition"></see></summary>
    let decomposition =
        Namespaced_IRI.parse _namespace_name "decomposition" |> NamespacedName

    /// <summary>
    ///   <see href="http://lemon-model.net/lemon#Prototype"></see>
    /// </summary>
    let Prototype = Namespaced_IRI.parse _namespace_name "Prototype" |> NamespacedName

    /// <summary>
    /// Indicates a logical condition that is used indicate when a particular term has the given meaning
    /// <see href="http://lemon-model.net/lemon#SenseCondition"></see></summary>
    let SenseCondition =
        Namespaced_IRI.parse _namespace_name "SenseCondition" |> NamespacedName

    /// <summary>
    /// Indicates the context in which a term is to be used. The context refers not to the immediate syntactic context, but the document and register the document is used in
    /// <see href="http://lemon-model.net/lemon#SenseContext"></see></summary>
    let SenseContext =
        Namespaced_IRI.parse _namespace_name "SenseContext" |> NamespacedName

    /// <summary>
    /// This indicates the value of a pseudo-data node. An example of this is definition where the value would generally be a string but it would not be possible to add further annotations, such as source or creation date.
    /// <see href="http://lemon-model.net/lemon#value"></see></summary>
    let value = Namespaced_IRI.parse _namespace_name "value" |> NamespacedName
    /// <summary>
    /// A word is a single unit of writing or speech. In languages written in Latin, Cyrillic, Greek, Arabic scripts etc. these are assumed to be separated by white-space characters. For Chinese, Japanese, Korean this should correspond to some agreed segmentation scheme.
    /// <see href="http://lemon-model.net/lemon#Word"></see></summary>
    let Word = Namespaced_IRI.parse _namespace_name "Word" |> NamespacedName

    /// <summary>
    /// A representation of a lexical entry that should not be considered canonical. This is primarily from a linguistic view for non-realisable forms such as stems but may also include misspellings and other unusual forms
    /// <see href="http://lemon-model.net/lemon#abstractForm"></see></summary>
    let abstractForm =
        Namespaced_IRI.parse _namespace_name "abstractForm" |> NamespacedName

    /// <summary>
    /// The sense of a non-preferred but admissible lexicalization of a given ontology entity
    /// <see href="http://lemon-model.net/lemon#altRef"></see></summary>
    let altRef = Namespaced_IRI.parse _namespace_name "altRef" |> NamespacedName

    /// <summary>
    /// Indicate that a reference has a given sense
    /// <see href="http://lemon-model.net/lemon#isReferenceOf"></see></summary>
    let isReferenceOf =
        Namespaced_IRI.parse _namespace_name "isReferenceOf" |> NamespacedName

    /// <summary>
    /// Denotes that one sense is broader than another. From a lexical point of view  this means replacing one lexical entry with another generalizes the meaning of the phrase. From an ontological point of view this property makes not strong assertions. From a mapping point of view if the broader sense applies the narrower sense must also
    /// <see href="http://lemon-model.net/lemon#broader"></see></summary>
    let broader = Namespaced_IRI.parse _namespace_name "broader" |> NamespacedName

    /// <summary>
    /// Denotes a relationship between senses
    /// <see href="http://lemon-model.net/lemon#senseRelation"></see></summary>
    let senseRelation =
        Namespaced_IRI.parse _namespace_name "senseRelation" |> NamespacedName

    /// <summary>
    /// Denotes that one sense is narrower than another. From a lexical point of view  this means replacing one lexical entry with another specializes the meaning of the phrase. From an ontological point of view this property makes not strong assertions. From a mapping point of view if the broader sense applies the narrower sense must also
    /// <see href="http://lemon-model.net/lemon#narrower"></see></summary>
    let narrower = Namespaced_IRI.parse _namespace_name "narrower" |> NamespacedName
    /// <summary>
    /// Indicates an evaluable test, the is necessary for this sense to apply
    /// <see href="http://lemon-model.net/lemon#condition"></see></summary>
    let condition = Namespaced_IRI.parse _namespace_name "condition" |> NamespacedName

    /// <summary>
    ///   <see href="http://lemon-model.net/lemon#constituent"></see>
    /// </summary>
    let constituent =
        Namespaced_IRI.parse _namespace_name "constituent" |> NamespacedName

    /// <summary>
    /// Denotes the pragmatic or discursive context of a sense mapping or a constraint on the mapping by syntactic or semantic properites
    /// <see href="http://lemon-model.net/lemon#context"></see></summary>
    let context = Namespaced_IRI.parse _namespace_name "context" |> NamespacedName
    /// <summary>
    /// Indicates a natural language definition. Note there is a pseudo-node to allow for further description of the definition (e.g., source, creation date etc.). The value property should be used to indicate the string value of the definition.
    /// <see href="http://lemon-model.net/lemon#definition"></see></summary>
    let definition = Namespaced_IRI.parse _namespace_name "definition" |> NamespacedName
    /// <summary>
    /// Indicates that two senses are equivalent. From a lexical point of view , this indicates that the lexical entries can be substituted for each other with no change in meaning. From an ontological point of view it means that the two references are not disjoint. From a mapping point of view it means if one mapping apply the other must necessarily apply
    /// <see href="http://lemon-model.net/lemon#equivalent"></see></summary>
    let equivalent = Namespaced_IRI.parse _namespace_name "equivalent" |> NamespacedName
    /// <summary>
    ///   <see href="http://lemon-model.net/lemon#example"></see>
    /// </summary>
    let example = Namespaced_IRI.parse _namespace_name "example" |> NamespacedName

    /// <summary>
    /// A raisable semantic argument is not in fact the semantic argument of the current frame-sense but instead is "raised" into a frame-sense used for an argument. For example the phrase "John seemed to be happy", is interpreted as "it seemed that X" where X is "John is happy", hence the subject of "seem" is a raisable argument.
    /// <see href="http://lemon-model.net/lemon#extrinsicArg"></see></summary>
    let extrinsicArg =
        Namespaced_IRI.parse _namespace_name "extrinsicArg" |> NamespacedName

    /// <summary>
    /// Denotes a semantic argument slot of a semantic unit
    /// <see href="http://lemon-model.net/lemon#semArg"></see></summary>
    let semArg = Namespaced_IRI.parse _namespace_name "semArg" |> NamespacedName

    /// <summary>
    ///   <see href="http://lemon-model.net/lemon#formVariant"></see>
    /// </summary>
    let formVariant =
        Namespaced_IRI.parse _namespace_name "formVariant" |> NamespacedName

    /// <summary>
    ///   <see href="http://lemon-model.net/lemon#generates"></see>
    /// </summary>
    let generates = Namespaced_IRI.parse _namespace_name "generates" |> NamespacedName
    /// <summary>
    ///   <see href="http://lemon-model.net/lemon#rule"></see>
    /// </summary>
    let rule = Namespaced_IRI.parse _namespace_name "rule" |> NamespacedName
    /// <summary>
    /// The sense of a non-admissible lexicalization for a ontology entity. This is used to denote incorrect or deprecated language that may be useful for information extraction but not generation
    /// <see href="http://lemon-model.net/lemon#hiddenRef"></see></summary>
    let hiddenRef = Namespaced_IRI.parse _namespace_name "hiddenRef" |> NamespacedName

    /// <summary>
    /// Says that the two senses are disjoint. From a lexical point of view, this means substituting the lexical entries must change the meaning of the phrase. From an ontological point of view, this property is implied if both references are also disjoint, but does not imply disjointness, but non-equivalence of the references. For the mapping point of view  there is not instance when both mappings are valid.
    /// <see href="http://lemon-model.net/lemon#incompatible"></see></summary>
    let incompatible =
        Namespaced_IRI.parse _namespace_name "incompatible" |> NamespacedName

    /// <summary>
    /// Denotes that the single argument of a class predicate is represented in the lexicon by the given semantic argument. That is Class(?x) or ?x rdf:type Class
    /// <see href="http://lemon-model.net/lemon#isA"></see></summary>
    let isA = Namespaced_IRI.parse _namespace_name "isA" |> NamespacedName
    /// <summary>
    /// Indicate that a sense is realised by the given lexical entry
    /// <see href="http://lemon-model.net/lemon#isSenseOf"></see></summary>
    let isSenseOf = Namespaced_IRI.parse _namespace_name "isSenseOf" |> NamespacedName
    /// <summary>
    /// Indicates the sense of a lexical entry
    /// <see href="http://lemon-model.net/lemon#sense"></see></summary>
    let sense = Namespaced_IRI.parse _namespace_name "sense" |> NamespacedName

    /// <summary>
    /// Indicates a non-semantic relationship between two lexical entries. E.g., a term is derived from another term, such as "lexical" and "lexicalize"
    /// <see href="http://lemon-model.net/lemon#lexicalVariant"></see></summary>
    let lexicalVariant =
        Namespaced_IRI.parse _namespace_name "lexicalVariant" |> NamespacedName

    /// <summary>
    /// Denotes the marker of a semantic argument. This should generally either be a semantic property i.e., case or another lexical entry e.g., a preposition or particle
    /// <see href="http://lemon-model.net/lemon#marker"></see></summary>
    let marker = Namespaced_IRI.parse _namespace_name "marker" |> NamespacedName

    /// <summary>
    ///   <see href="http://lemon-model.net/lemon#nextTransform"></see>
    /// </summary>
    let nextTransform =
        Namespaced_IRI.parse _namespace_name "nextTransform" |> NamespacedName

    /// <summary>
    /// Indicates the semantic argument which represents the objects (ranges) of the property referred to by this sense
    /// <see href="http://lemon-model.net/lemon#objOfProp"></see></summary>
    let objOfProp = Namespaced_IRI.parse _namespace_name "objOfProp" |> NamespacedName
    /// <summary>
    /// Denotes that the syntactic argument is optional (may be omitted)
    /// <see href="http://lemon-model.net/lemon#optional"></see></summary>
    let optional = Namespaced_IRI.parse _namespace_name "optional" |> NamespacedName
    /// <summary>
    /// A non-preferred ("non-dictionary") representation of a lexical entry. This should be variant that is either a morphological variant, an abbreviation, short form or acronym
    /// <see href="http://lemon-model.net/lemon#otherForm"></see></summary>
    let otherForm = Namespaced_IRI.parse _namespace_name "otherForm" |> NamespacedName
    /// <summary>
    ///   <see href="http://lemon-model.net/lemon#pattern"></see>
    /// </summary>
    let pattern = Namespaced_IRI.parse _namespace_name "pattern" |> NamespacedName
    /// <summary>
    /// Indicates the head node of a phrase structure or dependency parse graph
    /// <see href="http://lemon-model.net/lemon#phraseRoot"></see></summary>
    let phraseRoot = Namespaced_IRI.parse _namespace_name "phraseRoot" |> NamespacedName
    /// <summary>
    /// The sense of the preferred lexicalization of a given ontology entity
    /// <see href="http://lemon-model.net/lemon#prefRef"></see></summary>
    let prefRef = Namespaced_IRI.parse _namespace_name "prefRef" |> NamespacedName
    /// <summary>
    /// Denotes a lexical property of a lexical entry, form, component or MWE node. For the lexical entry this is assumed to be static properties e.g., part of speech and gender and for the others this is assumed to be specific properties e.g., case, number
    /// <see href="http://lemon-model.net/lemon#property"></see></summary>
    let property = Namespaced_IRI.parse _namespace_name "property" |> NamespacedName

    /// <summary>
    /// Indicates a restrictions on the domain of the property. That is, this sense only applies if the property the sense refers to has a subject in the class referred to by this property
    /// <see href="http://lemon-model.net/lemon#propertyDomain"></see></summary>
    let propertyDomain =
        Namespaced_IRI.parse _namespace_name "propertyDomain" |> NamespacedName

    /// <summary>
    /// Indicates a restrictions on the range of the property. That is, this sense only applies if the property the sense refers to has a object in the class referred to by this property
    /// <see href="http://lemon-model.net/lemon#propertyRange"></see></summary>
    let propertyRange =
        Namespaced_IRI.parse _namespace_name "propertyRange" |> NamespacedName

    /// <summary>
    /// Indicates the graphical element used to seperate the subnodes of this phrase structure. It is generally recommended that you use a string value with the language tag used to indicate script, (i.e., using ISO-15924 codes, such as "Latn"), as orthographic features may change with script.
    /// <see href="http://lemon-model.net/lemon#separator"></see></summary>
    let separator = Namespaced_IRI.parse _namespace_name "separator" |> NamespacedName
    /// <summary>
    /// Indicates the semantic argument which represents the subjects (domain) of the property referred to by this sense
    /// <see href="http://lemon-model.net/lemon#subjOfProp"></see></summary>
    let subjOfProp = Namespaced_IRI.parse _namespace_name "subjOfProp" |> NamespacedName
    /// <summary>
    /// Indicates a slot in a syntactic frame
    /// <see href="http://lemon-model.net/lemon#synArg"></see></summary>
    let synArg = Namespaced_IRI.parse _namespace_name "synArg" |> NamespacedName

    /// <summary>
    /// Indicates a syntactic behavior of a lexical entry
    /// <see href="http://lemon-model.net/lemon#synBehavior"></see></summary>
    let synBehavior =
        Namespaced_IRI.parse _namespace_name "synBehavior" |> NamespacedName

    /// <summary>
    /// Indicates the topic of the overrall lexicon, this is property is sometimes called "subject field". Note that in addition to the topic of a lexicon each lexical entry may belong to a given domain, this can be modelled as equal or not equal to the topic of the associated lexicon
    /// <see href="http://lemon-model.net/lemon#topic"></see></summary>
    let topic = Namespaced_IRI.parse _namespace_name "topic" |> NamespacedName
    /// <summary>
    ///   <see href="http://lemon-model.net/lemon#transform"></see>
    /// </summary>
    let transform = Namespaced_IRI.parse _namespace_name "transform" |> NamespacedName
    /// <summary>
    ///   <see href="http://lemon-model.net/lemon#tree"></see>
    /// </summary>
    let tree = Namespaced_IRI.parse _namespace_name "tree" |> NamespacedName
    /// <summary>
    /// Gives the written representation of a given form
    /// <see href="http://lemon-model.net/lemon#writtenRep"></see></summary>
    let writtenRep = Namespaced_IRI.parse _namespace_name "writtenRep" |> NamespacedName
