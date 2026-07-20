namespace http.persistence.uni_leipzig.org.nlp2rdf.ontologies.nif_core.hash

open DoxAletheia

module nif =
    let _namespace_name =
        "http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// cf. http://tools.ietf.org/html/rfc5147 URIs of this class have to conform with the syntax of RFC 5147 in a way that the end on a valid identifier, if you remove the prefix. Note that unlike RFC 5147 NIF does not requrire '#' URIs. So valid URIs are http://example.org#char=0,28 , http://example.org/whatever/char=0,28 , http://example.org/nif?char=0,28
    ///     Changelog:
    ///     * 1.1.0 changed subclass to CString .
    ///     * 1.1.1 typo in rdfs:label and extension of comment
    ///
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#RFC5147String"></see></summary>
    let RFC5147String = _prefix "RFC5147String"
    /// <summary>
    ///  cf. https://www.google.de/search?q=Linked-Data+Aware+URI+Schemes+for+Referencing+Text
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#ContextHashBasedString"></see></summary>
    let ContextHashBasedString = _prefix "ContextHashBasedString"
    /// <summary>
    /// cf. Linked-Data Aware URI Schemes for Referencing Text Fragments by Sebastian Hellmann, Jens Lehmann und Sören Auer in EKAW 2012 http://jens-lehmann.org/files/2012/ekaw_nif.pdf
    ///
    /// 	requires the existence of begin, endIndex and referenceContext
    ///
    /// 	Changelog:
    /// 	* 1.0.0 originally a plain text string was attached to this uri scheme, but this was removed later, because of complaints and complexity.
    /// 	* 1.1.0 subclassing of nif:CString
    ///
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#OffsetBasedString"></see></summary>
    let OffsetBasedString = _prefix "OffsetBasedString"
    /// <summary>
    /// An abitrary URI (e.g. a URN) for an arbitrary string of the context. This is roughly the same as TextAnnotations are currently implemented in Stanbol.
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#CStringInst"></see></summary>
    let CStringInst = _prefix "CStringInst"
    /// <summary>
    /// Individuals of this class are annotations of strings. This class can be used if an annotation statement has to be annotated with further information, like confidence or annotation provenance (like which tool produced the annotation).
    ///     Changelog:
    ///     * 0.0.1 initial commit of class
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#Annotation"></see></summary>
    let Annotation = _prefix "Annotation"
    /// <summary>
    /// A URI Scheme for NIF which is able to refer to a single, consecutive string in a context. Note that any scheme subclassing this class, requires the existence of beginIndex, endIndex and referenceContext .
    ///     This is an abstract class and should not be serialized.
    ///
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#CString"></see></summary>
    let CString = _prefix "CString"
    /// <summary>
    /// The end index of a character range as defined in http://tools.ietf.org/html/rfc5147#section-2.2.1 and http://tools.ietf.org/html/rfc5147#section-2.2.2, measured as the gap between two characters, starting to count from 0 (the position before the first character of a text).
    ///     Example: Index "2" is the postion between "Mr" and "."  in "Mr. Sandman".
    ///     Note: RFC 5147 is re-used for the definition of character ranges. RFC 5147 is assuming a text/plain MIME type. NIF builds upon Unicode and is content agnostic.
    ///     Requirement (1): This property has the same value the "Character position" of RFC 5147 and it must therefore be an xsd:nonNegativeInteger .
    ///     Requirement (2): The index of the subject string MUST be calculated relative to the nif:referenceContext of the subject. If available, this is the rdf:Literal of the nif:isString property.
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#endIndex"></see></summary>
    let endIndex = _prefix "endIndex"
    /// <summary>
    /// The begin index of a character range as defined in http://tools.ietf.org/html/rfc5147#section-2.2.1 and http://tools.ietf.org/html/rfc5147#section-2.2.2, measured as the gap between two characters, starting to count from 0 (the position before the first character of a text).
    ///     Example: Index "2" is the postion between "Mr" and "."  in "Mr. Sandman".
    ///     Note: RFC 5147 is re-used for the definition of character ranges. RFC 5147 is assuming a text/plain MIME type. NIF builds upon Unicode and is content agnostic.
    ///     Requirement (1): This property has the same value the "Character position" of RFC 5147 and it MUST therefore be castable to xsd:nonNegativeInteger, i.e. it MUST not have negative values.
    ///     Requirement (2): The index of the subject string MUST be calculated relative to the nif:referenceContext of the subject. If available, this is the rdf:Literal of the nif:isString property.
    ///
    ///     Changelog:
    ///     * 1.0.0: Introduced stable version.
    ///     * 1.0.1: merged val+inf, added range
    ///
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#beginIndex"></see></summary>
    let beginIndex = _prefix "beginIndex"
    /// <summary>
    /// A URI Scheme for NIF, subclasses need to define guidelines on the URI Scheme as well as the text it refers to. This class is just to keep some order, and should not be serialized.
    ///
    ///     This is an abstract class and should not be serialized.
    ///
    ///     Changelog:
    ///     * 0.1.1 changed comment
    ///
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#URIScheme"></see></summary>
    let URIScheme = _prefix "URIScheme"
    /// <summary>
    ///   <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#CollectionOccurrence"></see>
    /// </summary>
    let CollectionOccurrence = _prefix "CollectionOccurrence"
    /// <summary>
    /// The string that serves as a context for its substrings.  The Unicode String given in the nif:isString property must be used to calculate the begin and endIndex for all nif:Strings that have a nif:referenceContext property to this URI. For further information, see http://svn.aksw.org/papers/2013/ISWC_NIF/public.pdf
    ///
    ///     Changelog
    ///     * 1.0.1. improved documentation
    ///     * 1.0.2. merged inf model
    ///
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#Context"></see></summary>
    let Context = _prefix "Context"
    /// <summary>
    /// Links a URI of a string to its reference context of type nif:Context.  The reference context determines the calculation of begin and end index
    ///     Each String that is not an instance of nif:Context MUST have exactly one reference context.
    ///
    ///     Inferences (nif-core-inf.ttl):
    ///     Instances of nif:Context do have itself as reference context, this is inferred automatically, MAY be materialized, as well.
    ///
    ///     OWL validation (nif-core-val.ttl):
    ///     This property is functional.
    ///
    ///     Changelog:
    ///     * 1.0.0: Introduced stable version.
    ///     * 1.0.1: merged val model
    ///
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#referenceContext"></see></summary>
    let referenceContext = _prefix "referenceContext"
    /// <summary>
    /// The reference text as rdf:Literal for this nif:Context resource.
    ///     NIF requires that the reference text (i.e. the context) is always included in the RDF as an rdf:Literal.
    ///     Note, that the isString property is *the* place to keep the string itself in RDF.
    ///     All other nif:Strings and nif:URISchemes relate to the text of this property to calculate character position and indices.
    ///
    ///     Changelog
    ///     * 1.0.0: Introduced stable version.
    ///     * 1.0.1 improved documentation
    ///     * 1.0.2: merged val+inf
    ///
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#isString"></see></summary>
    let isString = _prefix "isString"
    /// <summary>
    /// Individuals of this class are a string, i.e. Unicode characters, who have been given a URI and are used in the subject of an RDF statement.
    ///     This class is abstract and should not be serialized.
    ///
    ///     NIF-Stanbol (nif-stanbol.ttl):
    ///     subclassOf nifs:Annotation because it "annotates" strings for example with begin and end index. The class is similar to fise:TextAnnotation
    ///
    ///     Changelog
    ///     * 1.0.1. improved documentation
    ///     * 1.0.2. merged inf and val model
    ///
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#String"></see></summary>
    let String = _prefix "String"
    /// <summary>
    /// A collection of contexts used to create an unordered set of context via the nif:hasContext property. This can be compared to a document collection, but here it is a collection of nif:Context and therefore a collection of annotated strings, not documents.
    ///
    ///     Open Issues
    ///     Investigate ordered collections
    ///
    ///     Changelog
    ///     * 0.1.1 improved documentation
    ///
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#ContextCollection"></see></summary>
    let ContextCollection = _prefix "ContextCollection"
    /// <summary>
    ///   <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#ContextOccurrence"></see>
    /// </summary>
    let ContextOccurrence = _prefix "ContextOccurrence"
    /// <summary>
    ///   <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#NormalizedCollectionOccurrence"></see>
    /// </summary>
    let NormalizedCollectionOccurrence = _prefix "NormalizedCollectionOccurrence"
    /// <summary>
    ///   <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#NormalizedContextOccurrence"></see>
    /// </summary>
    let NormalizedContextOccurrence = _prefix "NormalizedContextOccurrence"
    /// <summary>
    ///
    ///     A paragraph.
    ///     Changelog:
    ///     * 0.1.1 fixed spelling, added language tag
    ///
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#Paragraph"></see></summary>
    let Paragraph = _prefix "Paragraph"
    /// <summary>
    /// A structure is a more or less arbitrary label for a partitioning of a string. We do not follow a strict approach for what a word, phrase, sentence, title, paragraph is. These labels enable the definition processes for tool chains, e.g. tool analyses nif:Paragraph and calculates term frequency.
    ///
    ///     This is an abstract class and should not be serialized.
    ///
    ///     Changelog
    ///     0.1.1 not to be serialized comment
    ///
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#Structure"></see></summary>
    let Structure = _prefix "Structure"
    /// <summary>
    /// A nif:Phrase can be a nif:String, that is a chunk of several words or a word itself (e.g. a NounPhrase as a Named Entity). The term is underspecified and can be compatible with many defintitions of phrase. Please subClass it to specify the meaning (e.g. for Chunking or Phrase Structure Grammar). Example: ((My dog)(also)(likes)(eating (sausage)))
    ///     Changelog:
    ///     * 0.1.1 fixed spelling
    ///
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#Phrase"></see></summary>
    let Phrase = _prefix "Phrase"
    /// <summary>
    ///
    ///     A sentence.
    ///     Changelog:
    ///     * 0.1.1 fixed spelling, added language tag
    ///
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#Sentence"></see></summary>
    let Sentence = _prefix "Sentence"
    /// <summary>
    ///
    ///     A title within a text.
    ///     Changelog:
    ///     * 0.1.1 fixed spelling, added language tag
    ///
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#Title"></see></summary>
    let Title = _prefix "Title"
    /// <summary>
    ///
    ///     The Word class represents strings that are tokens or words. A string is a Word, if it is a word. We don't nitpic about whether it is a a pronoun, a name, a punctuation mark or an apostrophe or whether it is separated by white space from another Word or something else. The string 'He enters the room.' for example has 5 words. Words are assigned by a tokenizer NIF Implementation. Single word phrases might be tagged as nif:Word and nif:Phrase.
    ///
    ///     Example 1: "The White House" are three Words separated by whitespace
    ///
    ///     Comment 1: We adopted the definition style from foaf:Person, see here: http://xmlns.com/foaf/spec/#term_Person We are well aware that the world out there is much more complicated, but we are ignorant about it, for the following reasons:
    ///     Comment 2:
    ///
    ///     1. NIF has a client-server and the client has the ability to dictate the tokenization to the server (i.e. the NIF Implementation) by sending properly tokenized NIF annotated with nif:Word. All NIF Implementations are supposed to honor and respect the current assignment of the Word class. Thus the client should decide which NIF Implementation should create the tokenization. Therefore this class is not descriptive, but prescriptive.
    ///     2. The client may choose to send an existing tokenization to a NIF Implementation, with the capability to change (for better or for worse) the tokenization.
    ///
    ///
    ///
    ///     The class has not been named 'Token' as the NLP definition of 'token' is descriptive (and not well-defined), while the assignment of what is a Word and what not is prescriptive, e.g. "can't" could be described as one, two or three tokens or defined as being one, two or three words. For further reading, we refer the reader to: By all these lovely tokens... Merging conflicting tokenizations by Christian Chiarcos, Julia Ritz, and Manfred Stede. Language Resources and Evaluation 46(1):53-74 (2012) or the short form: http://www.aclweb.org/anthology/W09-3005
    ///     There the task at hand is to merge two tokenization T_1 and T_2 which is normally not the case in the NIF world as tokenization is prescribed, i.e. given as a baseline (Note that this ideal state might not be achieved by all implementations.)
    ///
    ///     Changelog:
    ///     * 0.1.1 fixed spelling
    ///     * 0.2.1 added a proper definition.
    ///     * 0.2.3 added examples and clarifications
    ///
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#Word"></see></summary>
    let Word = _prefix "Word"
    /// <summary>
    /// For each string you can include a snippet (e.g. 10-40 characters of text), that occurs immediately after the subject string.
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#after"></see></summary>
    let after = _prefix "after"
    /// <summary>
    /// The string, which the URI is representing as an RDF Literal. Some use cases require this property, as it is necessary for certain sparql queries.
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#anchorOf"></see></summary>
    let anchorOf = _prefix "anchorOf"
    /// <summary>
    ///
    ///       see Towards Web-Scale Collaborative Knowledge Extraction  http://svn.aksw.org/papers/2012/PeoplesWeb/public_preprint.pdf‎ page 21 .
    ///       Changelog:
    ///       * 0.1.1 Fixed page number
    ///
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#annotation"></see></summary>
    let annotation = _prefix "annotation"
    /// <summary>
    /// For each string you can include a snippet (e.g. 10-40 characters of text), that occurs immediately before the subject string.
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#before"></see></summary>
    let before = _prefix "before"
    /// <summary>
    /// This property should be used to express that one Context is contained in another Context, e.g. several sentences of a document are modelled indivudally and refer to the broader context of the whole document.
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#broaderContext"></see></summary>
    let broaderContext = _prefix "broaderContext"
    /// <summary>
    /// A simple annotation for machine learning purposes. The object can be anything, e.g. the literal "A. PRESS: Reportage" from Brown or any URI.
    /// 	ChangeLog:
    /// 	* 0.2.0 changed nif:class to nif:category due to conflict with Java
    ///
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#category"></see></summary>
    let category = _prefix "category"
    /// <summary>
    ///
    ///       see Towards Web-Scale Collaborative Knowledge Extraction  http://svn.aksw.org/papers/2012/PeoplesWeb/public_preprint.pdf‎ page 12 .
    ///       Changelog:
    ///       * 0.1.1 Fixed page number
    ///
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#classAnnotation"></see></summary>
    let classAnnotation = _prefix "classAnnotation"
    /// <summary>
    /// The confidence of an annotation as decimal between 0 and 1
    ///     Changelog:
    ///     * 0.0.1 initial commit of property
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#confidence"></see></summary>
    let confidence = _prefix "confidence"
    /// <summary>
    ///
    ///       The string that the nif:anchorOf is embedded in. FILTER ( strlen (nif:referenceContext [ nif:isString ] ) )
    ///
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#contextAsLiteral"></see></summary>
    let contextAsLiteral = _prefix "contextAsLiteral"
    /// <summary>
    ///
    /// 		A dependency relation pointing from gov to dep.
    /// 		Changelog:
    /// 		* 0.1.0 initial commit of property "dependency"
    /// 		* 0.1.1 made the property subproperty of dependencyTrans
    ///
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#dependency"></see></summary>
    let dependency = _prefix "dependency"
    /// <summary>
    ///
    /// 		Changelog:
    /// 		* 0.1.0 initial commit of property
    /// 		* 0.1.1 merged inf model
    ///
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#dependencyTrans"></see></summary>
    let dependencyTrans = _prefix "dependencyTrans"
    /// <summary>
    /// String denoting the kind of dependency relation
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#dependencyRelationType"></see></summary>
    let dependencyRelationType = _prefix "dependencyRelationType"
    /// <summary>
    ///
    /// 		This object property models a relation between two nif:Strings. The name "inter" is kept generic and can be used to express any kind of relation in between (inter) two nif:Strings. Extensions can create rdfs:subPropertyOf for "head", "dependent", nif:substring and nif:nextWord.
    ///
    /// 		Changelog:
    /// 		* 0.1.0 initial commit of property "dependency"
    /// 		* 0.2.0 changed name to "inter" which is more general than "dependency".
    ///
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#inter"></see></summary>
    let inter = _prefix "inter"
    /// <summary>
    /// This property links sentences to their first word.
    ///     Changelog:
    ///     * 0.1.1 merged inf+val
    ///
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#firstWord"></see></summary>
    let firstWord = _prefix "firstWord"
    /// <summary>
    /// This property links sentences to their words.
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#word"></see></summary>
    let word = _prefix "word"
    /// <summary>
    /// Links a nif:ContextCollection to its contexts.
    ///
    ///     Changelog
    ///     * 0.2.0. renamed property since a lot of people where too confused by nif:context
    ///
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#hasContext"></see></summary>
    let hasContext = _prefix "hasContext"
    /// <summary>
    ///
    ///       The first few chars of the nif:anchorOf. Typically used if the nif:anchorOf
    ///       is to long for inclusion as RDF literal.
    ///
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#head"></see></summary>
    let head = _prefix "head"
    /// <summary>
    /// A general keyword associated with a string
    ///     Changelog:
    ///     * 0.0.1 initial commit of property
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#keyword"></see></summary>
    let keyword = _prefix "keyword"
    /// <summary>
    ///
    /// 	Defines the language of a substring of the context. If the language for the nif:Context should be specified, nif:predominantLanguage must be used.
    /// 	see nif:predominantLanguage for more info.
    ///
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#lang"></see></summary>
    let lang = _prefix "lang"
    /// <summary>
    /// This property links sentences to their last word.
    /// 	 Changelog:
    /// 	 * 0.1.1 fixed label
    /// 	 * 0.1.2 merged inf+val
    ///
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#lastWord"></see></summary>
    let lastWord = _prefix "lastWord"
    /// <summary>
    /// The lemma(s) of the nif:String.
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#lemma"></see></summary>
    let lemma = _prefix "lemma"
    /// <summary>
    ///
    ///       see Towards Web-Scale Collaborative Knowledge Extraction  http://svn.aksw.org/papers/2012/PeoplesWeb/public_preprint.pdf‎ page 21 .
    ///       Changelog:
    ///       * 0.1.1 Fixed page number
    ///
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#literalAnnotation"></see></summary>
    let literalAnnotation = _prefix "literalAnnotation"
    /// <summary>
    /// The inverse of nif:narrowerContext
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#narrowerContext"></see></summary>
    let narrowerContext = _prefix "narrowerContext"
    /// <summary>
    /// This property (and nif:previousSentence, nif:nextWord, nif:previousWord and their transitive extension) can be used to make resources of nif:Sentence and nif:Word traversable, it can not be assumed that no gaps or whitespaces between sentences or words exist, i.e. string adjacency is not mandatory. The transitivity axioms are included in nif-core-inf.ttl and need to be included separately to keep a low reasoning profile. They are modeled after skos:broader and skos:broaderTransitive
    ///
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#nextSentence"></see></summary>
    let nextSentence = _prefix "nextSentence"
    /// <summary>
    /// see nif:nextSentence
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#nextSentenceTrans"></see></summary>
    let nextSentenceTrans = _prefix "nextSentenceTrans"
    /// <summary>
    /// see nif:nextSentence
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#previousSentence"></see></summary>
    let previousSentence = _prefix "previousSentence"
    /// <summary>
    /// see nif:nextSentence
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#nextWord"></see></summary>
    let nextWord = _prefix "nextWord"
    /// <summary>
    /// see nif:nextSentence
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#nextWordTrans"></see></summary>
    let nextWordTrans = _prefix "nextWordTrans"
    /// <summary>
    /// see nif:nextSentence
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#previousWord"></see></summary>
    let previousWord = _prefix "previousWord"
    /// <summary>
    /// This property links a string URI to classes of the OLiA Reference model. It provides a direct link for querying, thus it is a redundant optimization.
    ///     Changelog:
    ///     0.1.1 - added subproperty of nif:classAnnotation as per http://svn.aksw.org/papers/2012/PeoplesWeb/public_preprint.pdf‎ page 21
    ///     0.1.2 - removed domain axiom for annotationproperty
    ///     0.1.3 - improved documentation
    ///
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#oliaCategory"></see></summary>
    let oliaCategory = _prefix "oliaCategory"
    /// <summary>
    /// The confidence is relative to the tool and can be between 0.0 and 1.0, it is for nif:oliaLink and therefore also for nif:oliaCategory.
    ///     Changelog:
    ///     0.2.0 merged confidence for category and link
    ///
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#oliaConf"></see></summary>
    let oliaConf = _prefix "oliaConf"
    /// <summary>
    /// This property links a string to a URI from one of the OLiA Annotation model, e.g. http://purl.org/olia/penn.owl#NNP
    ///
    ///     Changelog
    ///     0.1.1 - added subproperty of nif:annotation as per http://svn.aksw.org/papers/2012/PeoplesWeb/public_preprint.pdf‎ page 21
    ///
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#oliaLink"></see></summary>
    let oliaLink = _prefix "oliaLink"
    /// <summary>
    /// Links to the URI describing the provenance
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#oliaProv"></see></summary>
    let oliaProv = _prefix "oliaProv"
    /// <summary>
    /// This property is used to link to a marl:Opinion. We have not investigated marl, so it might be replaced. http://marl.gi2mo.org/?page_id=1#overview . InverseOf marl:extractedFrom
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#opinion"></see></summary>
    let opinion = _prefix "opinion"
    /// <summary>
    /// To include the pos tag as it comes out of the NLP tool as RDF Literal. This property is discouraged to use alone, please use oliaLink and oliaCategory.  We included it, because some people might still want it and will even create their own property, if the string variant is missing
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#posTag"></see></summary>
    let posTag = _prefix "posTag"
    /// <summary>
    ///
    /// 	Defines the predominant language of the text. If this annotation is given on a nif:Context, all NIF tools have to treat the text to be in this language unless specified differently for a subpart. To change the language for a smaller substring nif:lang must be used.
    ///
    /// 	This property requires a uri as an argument. We expect this to be a URI from the lexvo.org namespace, e.g. http://lexvo.org/id/iso639-3/eng using ISO639-3
    ///
    ///
    /// 	Examples
    /// 	"The dealer says: "Rien ne va plus!" "
    /// 	has nif:predomintLanguage http://lexvo.org/id/iso639-3/eng and nif:lang http://www.lexvo.org/page/iso639-3/fra
    ///
    /// 	see also: http://www.w3.org/TR/its20/#selection-local
    ///
    /// 	Tests for RDFUnit (not written yet):
    /// 	- write a test for RDFUnit, so people do not use http://www.lexvo.org/page/iso639-3/eng
    ///
    ///
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#predLang"></see></summary>
    let predLang = _prefix "predLang"
    /// <summary>
    /// see nif:nextSentence
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#previousSentenceTrans"></see></summary>
    let previousSentenceTrans = _prefix "previousSentenceTrans"
    /// <summary>
    /// see nif:nextSentence
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#previousWordTrans"></see></summary>
    let previousWordTrans = _prefix "previousWordTrans"
    /// <summary>
    /// This property links words and other structures to their sentence.
    ///     Changelog:
    ///     * 0.2.0 Changed domain from nif:Word to nif:Structure, not longer inverseOf nif:word
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#sentence"></see></summary>
    let sentence = _prefix "sentence"
    /// <summary>
    /// Between -1 negative and 1 positive
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#sentimentValue"></see></summary>
    let sentimentValue = _prefix "sentimentValue"
    /// <summary>
    /// The URL the context was extracted from, e.g. the blog or news article url. Doesn't matter whether it is HTML or XML or plain text. rdfs:range is foaf:Document.  Subproperty of prov:hadPrimarySource. In case the string comes from another NIF String and gives the exact provenance, please use nif:wasConvertedFrom or a subProperty thereof.
    ///     Changelog:
    ///     * 0.2.0 added subPropertyOf prov:hadPrimarySource
    ///     * 0.2.1 clarification
    ///
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#sourceUrl"></see></summary>
    let sourceUrl = _prefix "sourceUrl"
    /// <summary>
    /// The stem(s) of the nif:String.
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#stem"></see></summary>
    let stem = _prefix "stem"
    /// <summary>
    /// This property together with nif:subString, nif:superString, and their transitive extension can be used to express that one string is contained in another one. Examples: "a" nif:subString "apple" , "apple" nif:subString "apple".  The transitivity axioms are included in nif-core-inf.ttl and need to be included separately to keep a low reasoning profile. They are modeled after skos:broader and skos:broaderTransitive
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#subString"></see></summary>
    let subString = _prefix "subString"
    /// <summary>
    /// transitive version of subString
    ///
    ///     Inferences (nif-core-inf.ttl):
    ///     Transitive definition kept in a different ontology
    ///
    ///     Changelog:
    ///     * 0.1.0: Initial version
    ///     * 0.1.1: merged inf
    ///
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#subStringTrans"></see></summary>
    let subStringTrans = _prefix "subStringTrans"
    /// <summary>
    /// see nif:subString
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#superString"></see></summary>
    let superString = _prefix "superString"
    /// <summary>
    /// see nif:subStringTrans
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#superStringTrans"></see></summary>
    let superStringTrans = _prefix "superStringTrans"
    /// <summary>
    /// This property marks the most specific class from itsrdf:taClassRef. The rule is: from the set S of itsrdf:taClassRef attached to this resource taMscRef points to the one that does not have any subclasses in the set S except itself. So if taClassRef is owl:Thing, dbo:Agent, dbo:Person, dbp:Actor taMsClassRef is dbo:Actor
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#taMsClassRef"></see></summary>
    let taMsClassRef = _prefix "taMsClassRef"
    /// <summary>
    ///
    ///       The last few chars of the nif:anchorOf. Typically used if the nif:anchorOf
    ///       is to long for inclusion as RDF literal.
    ///
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#tail"></see></summary>
    let tail = _prefix "tail"
    /// <summary>
    /// The topic of a string
    ///     Changelog:
    ///     * 0.0.1 initial commit of property
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#topic"></see></summary>
    let topic = _prefix "topic"
    /// <summary>
    /// This property should be used, when mapping one nif:String or nif:Context to another and is often confused with nif:sourceUrl.
    ///     While nif:sourceUrl is built on PROV-O and is used to link the nif:Context to the document URL for provenance information, nif:convertedFrom is more precise and pinpoints exact locations where a certain NIF String "wasConvertedFrom".
    ///     nif:wasConvertedFrom is therefore used to provide *exact* provenance during a conversion process, e.g. when removing tags from XHTML and then linking XPath URIs to NIF index based URIs (e.g.  RFC 5147 with char=x,y). An example of the usage of this property can be found here: http://www.w3.org/TR/its20/#conversion-to-nif
    ///
    ///     Example
    ///     # "Dublin"
    /// &lt;http://example.com/myitsservice?informat=html&amp;intype=url&amp;input=http://example.com/doc.html&amp;char=11,17&gt;
    ///  nif:wasConvertedFrom
    ///  &lt;http://example.com/myitsservice?informat=html&amp;intype=url&amp;input=http://example.com/doc.html&amp;xpath=/html/body[1]/h2[1]/span[1]/text()[1]&gt;.
    ///
    /// <see href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#wasConvertedFrom"></see></summary>
    let wasConvertedFrom = _prefix "wasConvertedFrom"
