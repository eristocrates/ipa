#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module nif =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#" "nif"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>owl:versionInfo : 0.0.1^^xsd:string</para>
    ///   <para>rdfs:label : Annotation^^xsd:string</para>
    ///   <para>rdfs:comment : Individuals of this class are annotations of strings. This class can be used if an annotation statement has to be annotated with further information, like confidence or annotation provenance (like which tool produced the annotation).
    ///     Changelog:
    ///     * 0.0.1 initial commit of class</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#Annotation">nif:Annotation</a>
    /// </summary>
    let Annotation = _prefixId.prefix "Annotation"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.0^^xsd:string</para>
    ///   <para>rdfs:label : Consecutive String</para>
    ///   <para>rdfs:comment : A URI Scheme for NIF which is able to refer to a single, consecutive string in a context. Note that any scheme subclassing this class, requires the existence of beginIndex, endIndex and referenceContext .
    ///     This is an abstract class and should not be serialized.
    ///     </para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#CString">nif:CString</a>
    /// </summary>
    let CString = _prefixId.prefix "CString"
    /// <summary>
    ///   <para>owl:versionInfo : 0.0.0^^xsd:string</para>
    ///   <para>rdfs:label : Consecutive String Instantiation</para>
    ///   <para>rdfs:comment : An abitrary URI (e.g. a URN) for an arbitrary string of the context. This is roughly the same as TextAnnotations are currently implemented in Stanbol.</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#CStringInst">nif:CStringInst</a>
    /// </summary>
    let CStringInst = _prefixId.prefix "CStringInst"
    let CollectionOccurrence = _prefixId.prefix "CollectionOccurrence"
    /// <summary>
    ///   <para>owl:versionInfo : 1.0.2^^xsd:string</para>
    ///   <para>rdfs:label : Context</para>
    ///   <para>rdfs:comment : The string that serves as a context for its substrings.  The Unicode String given in the nif:isString property must be used to calculate the begin and endIndex for all nif:Strings that have a nif:referenceContext property to this URI. For further information, see http://svn.aksw.org/papers/2013/ISWC_NIF/public.pdf
    ///
    ///     Changelog
    ///     * 1.0.1. improved documentation
    ///     * 1.0.2. merged inf model
    ///     </para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#Context">nif:Context</a>
    /// </summary>
    let Context = _prefixId.prefix "Context"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.1^^xsd:string</para>
    ///   <para>rdfs:label : Context Collection</para>
    ///   <para>rdfs:comment : A collection of contexts used to create an unordered set of context via the nif:hasContext property. This can be compared to a document collection, but here it is a collection of nif:Context and therefore a collection of annotated strings, not documents.
    ///
    ///     Open Issues
    ///     Investigate ordered collections
    ///
    ///     Changelog
    ///     * 0.1.1 improved documentation
    ///     </para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#ContextCollection">nif:ContextCollection</a>
    /// </summary>
    let ContextCollection = _prefixId.prefix "ContextCollection"
    /// <summary>
    ///   <para>owl:versionInfo : 1.0.0^^xsd:string</para>
    ///   <para>rdfs:label : Context Hash Based String</para>
    ///   <para>rdfs:comment :  cf. https://www.google.de/search?q=Linked-Data+Aware+URI+Schemes+for+Referencing+Text^^xsd:string</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#ContextHashBasedString">nif:ContextHashBasedString</a>
    /// </summary>
    let ContextHashBasedString = _prefixId.prefix "ContextHashBasedString"
    let ContextOccurrence = _prefixId.prefix "ContextOccurrence"

    let NormalizedCollectionOccurrence =
        _prefixId.prefix "NormalizedCollectionOccurrence"

    let NormalizedContextOccurrence = _prefixId.prefix "NormalizedContextOccurrence"
    /// <summary>
    ///   <para>owl:versionInfo : 1.1.0^^xsd:string</para>
    ///   <para>rdfs:label : Offset-based String</para>
    ///   <para>rdfs:comment : cf. Linked-Data Aware URI Schemes for Referencing Text Fragments by Sebastian Hellmann, Jens Lehmann und Sören Auer in EKAW 2012 http://jens-lehmann.org/files/2012/ekaw_nif.pdf
    ///
    /// 	requires the existence of begin, endIndex and referenceContext
    ///
    /// 	Changelog:
    /// 	* 1.0.0 originally a plain text string was attached to this uri scheme, but this was removed later, because of complaints and complexity.
    /// 	* 1.1.0 subclassing of nif:CString
    ///     </para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#OffsetBasedString">nif:OffsetBasedString</a>
    /// </summary>
    let OffsetBasedString = _prefixId.prefix "OffsetBasedString"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.1^^xsd:string</para>
    ///   <para>rdfs:label : Paragraph</para>
    ///   <para>rdfs:comment :
    ///     A paragraph.
    ///     Changelog:
    ///     * 0.1.1 fixed spelling, added language tag
    ///     </para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#Paragraph">nif:Paragraph</a>
    /// </summary>
    let Paragraph = _prefixId.prefix "Paragraph"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.1^^xsd:string</para>
    ///   <para>rdfs:label : Phrase</para>
    ///   <para>rdfs:comment : A nif:Phrase can be a nif:String, that is a chunk of several words or a word itself (e.g. a NounPhrase as a Named Entity). The term is underspecified and can be compatible with many defintitions of phrase. Please subClass it to specify the meaning (e.g. for Chunking or Phrase Structure Grammar). Example: ((My dog)(also)(likes)(eating (sausage)))
    ///     Changelog:
    ///     * 0.1.1 fixed spelling
    ///     ^^xsd:string</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#Phrase">nif:Phrase</a>
    /// </summary>
    let Phrase = _prefixId.prefix "Phrase"
    /// <summary>
    ///   <para>owl:versionInfo : 1.1.0^^xsd:string</para>
    ///   <para>rdfs:label : RFC 5147 String</para>
    ///   <para>rdfs:comment : cf. http://tools.ietf.org/html/rfc5147 URIs of this class have to conform with the syntax of RFC 5147 in a way that the end on a valid identifier, if you remove the prefix. Note that unlike RFC 5147 NIF does not requrire '#' URIs. So valid URIs are http://example.org#char=0,28 , http://example.org/whatever/char=0,28 , http://example.org/nif?char=0,28
    ///     Changelog:
    ///     * 1.1.0 changed subclass to CString .
    ///     * 1.1.1 typo in rdfs:label and extension of comment
    ///     ^^xsd:string</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#RFC5147String">nif:RFC5147String</a>
    /// </summary>
    let RFC5147String = _prefixId.prefix "RFC5147String"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.1^^xsd:string</para>
    ///   <para>rdfs:label : Sentence</para>
    ///   <para>rdfs:comment :
    ///     A sentence.
    ///     Changelog:
    ///     * 0.1.1 fixed spelling, added language tag
    ///     </para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#Sentence">nif:Sentence</a>
    /// </summary>
    let Sentence = _prefixId.prefix "Sentence"
    /// <summary>
    ///   <para>owl:versionInfo : 1.0.2^^xsd:string</para>
    ///   <para>rdfs:label : String</para>
    ///   <para>rdfs:comment : Individuals of this class are a string, i.e. Unicode characters, who have been given a URI and are used in the subject of an RDF statement.
    ///     This class is abstract and should not be serialized.
    ///
    ///     NIF-Stanbol (nif-stanbol.ttl):
    ///     subclassOf nifs:Annotation because it "annotates" strings for example with begin and end index. The class is similar to fise:TextAnnotation
    ///
    ///     Changelog
    ///     * 1.0.1. improved documentation
    ///     * 1.0.2. merged inf and val model
    ///     </para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#String">nif:String</a>
    /// </summary>
    let String = _prefixId.prefix "String"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.0^^xsd:string</para>
    ///   <para>rdfs:label : Structure</para>
    ///   <para>rdfs:comment : A structure is a more or less arbitrary label for a partitioning of a string. We do not follow a strict approach for what a word, phrase, sentence, title, paragraph is. These labels enable the definition processes for tool chains, e.g. tool analyses nif:Paragraph and calculates term frequency.
    ///
    ///     This is an abstract class and should not be serialized.
    ///
    ///     Changelog
    ///     0.1.1 not to be serialized comment
    ///     ^^xsd:string</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#Structure">nif:Structure</a>
    /// </summary>
    let Structure = _prefixId.prefix "Structure"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.1^^xsd:string</para>
    ///   <para>rdfs:label : Title</para>
    ///   <para>rdfs:comment :
    ///     A title within a text.
    ///     Changelog:
    ///     * 0.1.1 fixed spelling, added language tag
    ///     </para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#Title">nif:Title</a>
    /// </summary>
    let Title = _prefixId.prefix "Title"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.1^^xsd:string</para>
    ///   <para>rdfs:label : URI Scheme</para>
    ///   <para>rdfs:comment : A URI Scheme for NIF, subclasses need to define guidelines on the URI Scheme as well as the text it refers to. This class is just to keep some order, and should not be serialized.
    ///
    ///     This is an abstract class and should not be serialized.
    ///
    ///     Changelog:
    ///     * 0.1.1 changed comment
    ///     </para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#URIScheme">nif:URIScheme</a>
    /// </summary>
    let URIScheme = _prefixId.prefix "URIScheme"
    /// <summary>
    ///   <para>owl:versionInfo : 0.2.2^^xsd:string</para>
    ///   <para>rdfs:label : Word</para>
    ///   <para>rdfs:comment :
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
    ///     </para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#Word">nif:Word</a>
    /// </summary>
    let Word = _prefixId.prefix "Word"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.0^^xsd:string</para>
    ///   <para>rdfs:label : after</para>
    ///   <para>rdfs:comment : For each string you can include a snippet (e.g. 10-40 characters of text), that occurs immediately after the subject string.^^xsd:string</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#after">nif:after</a>
    /// </summary>
    let after = _prefixId.prefix "after"
    /// <summary>
    ///   <para>owl:versionInfo : 1.0.0^^xsd:string</para>
    ///   <para>rdfs:label : anchor of</para>
    ///   <para>rdfs:comment : The string, which the URI is representing as an RDF Literal. Some use cases require this property, as it is necessary for certain sparql queries. ^^xsd:string</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#anchorOf">nif:anchorOf</a>
    /// </summary>
    let anchorOf = _prefixId.prefix "anchorOf"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.1^^xsd:string</para>
    ///   <para>rdfs:label : annotation</para>
    ///   <para>rdfs:comment :
    ///       see Towards Web-Scale Collaborative Knowledge Extraction  http://svn.aksw.org/papers/2012/PeoplesWeb/public_preprint.pdf‎ page 21 .
    ///       Changelog:
    ///       * 0.1.1 Fixed page number
    ///     </para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#annotation">nif:annotation</a>
    /// </summary>
    let annotation = _prefixId.prefix "annotation"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.0^^xsd:string</para>
    ///   <para>rdfs:label : before</para>
    ///   <para>rdfs:comment : For each string you can include a snippet (e.g. 10-40 characters of text), that occurs immediately before the subject string.^^xsd:string</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#before">nif:before</a>
    /// </summary>
    let before = _prefixId.prefix "before"
    /// <summary>
    ///   <para>owl:versionInfo : 1.0.1^^xsd:string</para>
    ///   <para>rdfs:label : begin index</para>
    ///   <para>rdfs:comment : The begin index of a character range as defined in http://tools.ietf.org/html/rfc5147#section-2.2.1 and http://tools.ietf.org/html/rfc5147#section-2.2.2, measured as the gap between two characters, starting to count from 0 (the position before the first character of a text).
    ///     Example: Index "2" is the postion between "Mr" and "."  in "Mr. Sandman".
    ///     Note: RFC 5147 is re-used for the definition of character ranges. RFC 5147 is assuming a text/plain MIME type. NIF builds upon Unicode and is content agnostic.
    ///     Requirement (1): This property has the same value the "Character position" of RFC 5147 and it MUST therefore be castable to xsd:nonNegativeInteger, i.e. it MUST not have negative values.
    ///     Requirement (2): The index of the subject string MUST be calculated relative to the nif:referenceContext of the subject. If available, this is the rdf:Literal of the nif:isString property.
    ///
    ///     Changelog:
    ///     * 1.0.0: Introduced stable version.
    ///     * 1.0.1: merged val+inf, added range
    ///     ^^xsd:string</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#beginIndex">nif:beginIndex</a>
    /// </summary>
    let beginIndex = _prefixId.prefix "beginIndex"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.0^^xsd:string</para>
    ///   <para>rdfs:label : broader Context</para>
    ///   <para>rdfs:comment : This property should be used to express that one Context is contained in another Context, e.g. several sentences of a document are modelled indivudally and refer to the broader context of the whole document.</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#broaderContext">nif:broaderContext</a>
    /// </summary>
    let broaderContext = _prefixId.prefix "broaderContext"
    /// <summary>
    ///   <para>owl:versionInfo : 0.2.0^^xsd:string</para>
    ///   <para>rdfs:label : category^^xsd:string</para>
    ///   <para>rdfs:comment : A simple annotation for machine learning purposes. The object can be anything, e.g. the literal "A. PRESS: Reportage" from Brown or any URI.
    /// 	ChangeLog:
    /// 	* 0.2.0 changed nif:class to nif:category due to conflict with Java
    /// 	</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#category">nif:category</a>
    /// </summary>
    let category = _prefixId.prefix "category"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.1^^xsd:string</para>
    ///   <para>rdfs:label : classAnnotation</para>
    ///   <para>rdfs:comment :
    ///       see Towards Web-Scale Collaborative Knowledge Extraction  http://svn.aksw.org/papers/2012/PeoplesWeb/public_preprint.pdf‎ page 12 .
    ///       Changelog:
    ///       * 0.1.1 Fixed page number
    ///     </para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#classAnnotation">nif:classAnnotation</a>
    /// </summary>
    let classAnnotation = _prefixId.prefix "classAnnotation"
    /// <summary>
    ///   <para>owl:versionInfo : 0.0.1^^xsd:string</para>
    ///   <para>rdfs:label : confidence of annotation^^xsd:string</para>
    ///   <para>rdfs:comment : The confidence of an annotation as decimal between 0 and 1
    ///     Changelog:
    ///     * 0.0.1 initial commit of property</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#confidence">nif:confidence</a>
    /// </summary>
    let confidence = _prefixId.prefix "confidence"
    let contextAsLiteral = _prefixId.prefix "contextAsLiteral"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.0^^xsd:string</para>
    ///   <para>rdfs:label : dependency</para>
    ///   <para>rdfs:comment :
    /// 		A dependency relation pointing from gov to dep.
    /// 		Changelog:
    /// 		* 0.1.0 initial commit of property "dependency"
    /// 		* 0.1.1 made the property subproperty of dependencyTrans
    ///     </para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#dependency">nif:dependency</a>
    /// </summary>
    let dependency = _prefixId.prefix "dependency"
    /// <summary>
    ///   <para>owl:versionInfo : 0.0.1^^xsd:string</para>
    ///   <para>rdfs:label : dependency relation type^^xsd:string</para>
    ///   <para>rdfs:comment : String denoting the kind of dependency relation</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#dependencyRelationType">nif:dependencyRelationType</a>
    /// </summary>
    let dependencyRelationType = _prefixId.prefix "dependencyRelationType"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.1^^xsd:string</para>
    ///   <para>rdfs:label : transitive version of dependency</para>
    ///   <para>rdfs:comment :
    /// 		Changelog:
    /// 		* 0.1.0 initial commit of property
    /// 		* 0.1.1 merged inf model
    ///     </para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#dependencyTrans">nif:dependencyTrans</a>
    /// </summary>
    let dependencyTrans = _prefixId.prefix "dependencyTrans"
    /// <summary>
    ///   <para>owl:versionInfo : 1.0.2^^xsd:string</para>
    ///   <para>rdfs:label : end index</para>
    ///   <para>rdfs:comment : The end index of a character range as defined in http://tools.ietf.org/html/rfc5147#section-2.2.1 and http://tools.ietf.org/html/rfc5147#section-2.2.2, measured as the gap between two characters, starting to count from 0 (the position before the first character of a text).
    ///     Example: Index "2" is the postion between "Mr" and "."  in "Mr. Sandman".
    ///     Note: RFC 5147 is re-used for the definition of character ranges. RFC 5147 is assuming a text/plain MIME type. NIF builds upon Unicode and is content agnostic.
    ///     Requirement (1): This property has the same value the "Character position" of RFC 5147 and it must therefore be an xsd:nonNegativeInteger .
    ///     Requirement (2): The index of the subject string MUST be calculated relative to the nif:referenceContext of the subject. If available, this is the rdf:Literal of the nif:isString property.^^xsd:string</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#endIndex">nif:endIndex</a>
    /// </summary>
    let endIndex = _prefixId.prefix "endIndex"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.1^^xsd:string</para>
    ///   <para>rdfs:label : has first word</para>
    ///   <para>rdfs:comment : This property links sentences to their first word.
    ///     Changelog:
    ///     * 0.1.1 merged inf+val
    ///     </para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#firstWord">nif:firstWord</a>
    /// </summary>
    let firstWord = _prefixId.prefix "firstWord"
    /// <summary>
    ///   <para>owl:versionInfo : 0.2.0^^xsd:string</para>
    ///   <para>rdfs:label : has context</para>
    ///   <para>rdfs:comment : Links a nif:ContextCollection to its contexts.
    ///
    ///     Changelog
    ///     * 0.2.0. renamed property since a lot of people where too confused by nif:context
    ///     </para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#hasContext">nif:hasContext</a>
    /// </summary>
    let hasContext = _prefixId.prefix "hasContext"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.0^^xsd:string</para>
    ///   <para>rdfs:label : head</para>
    ///   <para>rdfs:comment :
    ///       The first few chars of the nif:anchorOf. Typically used if the nif:anchorOf
    ///       is to long for inclusion as RDF literal.
    ///     </para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#head">nif:head</a>
    /// </summary>
    let head = _prefixId.prefix "head"
    /// <summary>
    ///   <para>owl:versionInfo : 0.2.0^^xsd:string</para>
    ///   <para>rdfs:label : inter</para>
    ///   <para>rdfs:comment :
    /// 		This object property models a relation between two nif:Strings. The name "inter" is kept generic and can be used to express any kind of relation in between (inter) two nif:Strings. Extensions can create rdfs:subPropertyOf for "head", "dependent", nif:substring and nif:nextWord.
    ///
    /// 		Changelog:
    /// 		* 0.1.0 initial commit of property "dependency"
    /// 		* 0.2.0 changed name to "inter" which is more general than "dependency".
    ///     </para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#inter">nif:inter</a>
    /// </summary>
    let inter = _prefixId.prefix "inter"
    /// <summary>
    ///   <para>owl:versionInfo : 1.0.2^^xsd:string</para>
    ///   <para>rdfs:label : is string</para>
    ///   <para>rdfs:comment : The reference text as rdf:Literal for this nif:Context resource.
    ///     NIF requires that the reference text (i.e. the context) is always included in the RDF as an rdf:Literal.
    ///     Note, that the isString property is *the* place to keep the string itself in RDF.
    ///     All other nif:Strings and nif:URISchemes relate to the text of this property to calculate character position and indices.
    ///
    ///     Changelog
    ///     * 1.0.0: Introduced stable version.
    ///     * 1.0.1 improved documentation
    ///     * 1.0.2: merged val+inf
    ///     </para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#isString">nif:isString</a>
    /// </summary>
    let isString = _prefixId.prefix "isString"
    /// <summary>
    ///   <para>owl:versionInfo : 0.0.1^^xsd:string</para>
    ///   <para>rdfs:label : keyword^^xsd:string</para>
    ///   <para>rdfs:comment : A general keyword associated with a string
    ///     Changelog:
    ///     * 0.0.1 initial commit of property</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#keyword">nif:keyword</a>
    /// </summary>
    let keyword = _prefixId.prefix "keyword"
    /// <summary>
    ///   <para>owl:versionInfo : 0.0.0^^xsd:string</para>
    ///   <para>rdfs:label : language of the string^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 	Defines the language of a substring of the context. If the language for the nif:Context should be specified, nif:predominantLanguage must be used.
    /// 	see nif:predominantLanguage for more info.
    /// 	</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#lang">nif:lang</a>
    /// </summary>
    let lang = _prefixId.prefix "lang"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.2^^xsd:string</para>
    ///   <para>rdfs:label : has last word</para>
    ///   <para>rdfs:comment : This property links sentences to their last word.
    /// 	 Changelog:
    /// 	 * 0.1.1 fixed label
    /// 	 * 0.1.2 merged inf+val
    ///     </para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#lastWord">nif:lastWord</a>
    /// </summary>
    let lastWord = _prefixId.prefix "lastWord"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.0^^xsd:string</para>
    ///   <para>rdfs:label : lemma</para>
    ///   <para>rdfs:comment : The lemma(s) of the nif:String.</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#lemma">nif:lemma</a>
    /// </summary>
    let lemma = _prefixId.prefix "lemma"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.1^^xsd:string</para>
    ///   <para>rdfs:label : literalAnnotation</para>
    ///   <para>rdfs:comment :
    ///       see Towards Web-Scale Collaborative Knowledge Extraction  http://svn.aksw.org/papers/2012/PeoplesWeb/public_preprint.pdf‎ page 21 .
    ///       Changelog:
    ///       * 0.1.1 Fixed page number
    ///     </para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#literalAnnotation">nif:literalAnnotation</a>
    /// </summary>
    let literalAnnotation = _prefixId.prefix "literalAnnotation"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.0^^xsd:string</para>
    ///   <para>rdfs:label : narrower Context</para>
    ///   <para>rdfs:comment : The inverse of nif:narrowerContext</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#narrowerContext">nif:narrowerContext</a>
    /// </summary>
    let narrowerContext = _prefixId.prefix "narrowerContext"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.1^^xsd:string</para>
    ///   <para>rdfs:comment : This property (and nif:previousSentence, nif:nextWord, nif:previousWord and their transitive extension) can be used to make resources of nif:Sentence and nif:Word traversable, it can not be assumed that no gaps or whitespaces between sentences or words exist, i.e. string adjacency is not mandatory. The transitivity axioms are included in nif-core-inf.ttl and need to be included separately to keep a low reasoning profile. They are modeled after skos:broader and skos:broaderTransitive
    ///     </para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#nextSentence">nif:nextSentence</a>
    /// </summary>
    let nextSentence = _prefixId.prefix "nextSentence"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.1^^xsd:string</para>
    ///   <para>rdfs:comment : see nif:nextSentence</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#nextSentenceTrans">nif:nextSentenceTrans</a>
    /// </summary>
    let nextSentenceTrans = _prefixId.prefix "nextSentenceTrans"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.1^^xsd:string</para>
    ///   <para>rdfs:comment : see nif:nextSentence</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#nextWord">nif:nextWord</a>
    /// </summary>
    let nextWord = _prefixId.prefix "nextWord"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.1^^xsd:string</para>
    ///   <para>rdfs:comment : see nif:nextSentence</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#nextWordTrans">nif:nextWordTrans</a>
    /// </summary>
    let nextWordTrans = _prefixId.prefix "nextWordTrans"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.3^^xsd:string</para>
    ///   <para>rdfs:label : OLiA Category</para>
    ///   <para>rdfs:comment : This property links a string URI to classes of the OLiA Reference model. It provides a direct link for querying, thus it is a redundant optimization.
    ///     Changelog:
    ///     0.1.1 - added subproperty of nif:classAnnotation as per http://svn.aksw.org/papers/2012/PeoplesWeb/public_preprint.pdf‎ page 21
    ///     0.1.2 - removed domain axiom for annotationproperty
    ///     0.1.3 - improved documentation
    ///     </para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#oliaCategory">nif:oliaCategory</a>
    /// </summary>
    let oliaCategory = _prefixId.prefix "oliaCategory"
    /// <summary>
    ///   <para>owl:versionInfo : 0.2.0^^xsd:string</para>
    ///   <para>rdfs:label : Confidence of OLiA tag^^xsd:string</para>
    ///   <para>rdfs:comment : The confidence is relative to the tool and can be between 0.0 and 1.0, it is for nif:oliaLink and therefore also for nif:oliaCategory.
    ///     Changelog:
    ///     0.2.0 merged confidence for category and link
    ///     </para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#oliaConf">nif:oliaConf</a>
    /// </summary>
    let oliaConf = _prefixId.prefix "oliaConf"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.1^^xsd:string</para>
    ///   <para>rdfs:label : OLiA link</para>
    ///   <para>rdfs:comment : This property links a string to a URI from one of the OLiA Annotation model, e.g. http://purl.org/olia/penn.owl#NNP
    ///
    ///     Changelog
    ///     0.1.1 - added subproperty of nif:annotation as per http://svn.aksw.org/papers/2012/PeoplesWeb/public_preprint.pdf‎ page 21
    ///     </para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#oliaLink">nif:oliaLink</a>
    /// </summary>
    let oliaLink = _prefixId.prefix "oliaLink"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.0^^xsd:string</para>
    ///   <para>rdfs:label : Provenance of OLiA tag^^xsd:string</para>
    ///   <para>rdfs:comment : Links to the URI describing the provenance</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#oliaProv">nif:oliaProv</a>
    /// </summary>
    let oliaProv = _prefixId.prefix "oliaProv"
    /// <summary>
    ///   <para>owl:versionInfo : 0.0.0^^xsd:string</para>
    ///   <para>rdfs:label : opinion^^xsd:string</para>
    ///   <para>rdfs:comment : This property is used to link to a marl:Opinion. We have not investigated marl, so it might be replaced. http://marl.gi2mo.org/?page_id=1#overview . InverseOf marl:extractedFrom</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#opinion">nif:opinion</a>
    /// </summary>
    let opinion = _prefixId.prefix "opinion"
    /// <summary>
    ///   <para>owl:versionInfo : discouraged^^xsd:string</para>
    ///   <para>rdfs:label : Part of speech tag</para>
    ///   <para>rdfs:comment : To include the pos tag as it comes out of the NLP tool as RDF Literal. This property is discouraged to use alone, please use oliaLink and oliaCategory.  We included it, because some people might still want it and will even create their own property, if the string variant is missing ^^xsd:string</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#posTag">nif:posTag</a>
    /// </summary>
    let posTag = _prefixId.prefix "posTag"
    /// <summary>
    ///   <para>owl:versionInfo : 0.0.0^^xsd:string</para>
    ///   <para>rdfs:label : predominant language^^xsd:string</para>
    ///   <para>rdfs:comment :
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
    /// 	</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#predLang">nif:predLang</a>
    /// </summary>
    let predLang = _prefixId.prefix "predLang"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.1^^xsd:string</para>
    ///   <para>rdfs:comment : see nif:nextSentence</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#previousSentence">nif:previousSentence</a>
    /// </summary>
    let previousSentence = _prefixId.prefix "previousSentence"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.1^^xsd:string</para>
    ///   <para>rdfs:comment : see nif:nextSentence</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#previousSentenceTrans">nif:previousSentenceTrans</a>
    /// </summary>
    let previousSentenceTrans = _prefixId.prefix "previousSentenceTrans"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.1^^xsd:string</para>
    ///   <para>rdfs:comment : see nif:nextSentence</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#previousWord">nif:previousWord</a>
    /// </summary>
    let previousWord = _prefixId.prefix "previousWord"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.1^^xsd:string</para>
    ///   <para>rdfs:comment : see nif:nextSentence</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#previousWordTrans">nif:previousWordTrans</a>
    /// </summary>
    let previousWordTrans = _prefixId.prefix "previousWordTrans"
    /// <summary>
    ///   <para>owl:versionInfo : 1.0.0^^xsd:string</para>
    ///   <para>rdfs:label : reference context</para>
    ///   <para>rdfs:comment : Links a URI of a string to its reference context of type nif:Context.  The reference context determines the calculation of begin and end index
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
    ///     </para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#referenceContext">nif:referenceContext</a>
    /// </summary>
    let referenceContext = _prefixId.prefix "referenceContext"
    /// <summary>
    ///   <para>owl:versionInfo : 0.2.0^^xsd:string</para>
    ///   <para>rdfs:comment : This property links words and other structures to their sentence.
    ///     Changelog:
    ///     * 0.2.0 Changed domain from nif:Word to nif:Structure, not longer inverseOf nif:word</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#sentence">nif:sentence</a>
    /// </summary>
    let sentence = _prefixId.prefix "sentence"
    /// <summary>
    ///   <para>owl:versionInfo : 0.0.0^^xsd:string</para>
    ///   <para>rdfs:label : sentiment value^^xsd:string</para>
    ///   <para>rdfs:comment : Between -1 negative and 1 positive </para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#sentimentValue">nif:sentimentValue</a>
    /// </summary>
    let sentimentValue = _prefixId.prefix "sentimentValue"
    /// <summary>
    ///   <para>owl:versionInfo : 0.2.0^^xsd:string</para>
    ///   <para>rdfs:label : source URL</para>
    ///   <para>rdfs:comment : The URL the context was extracted from, e.g. the blog or news article url. Doesn't matter whether it is HTML or XML or plain text. rdfs:range is foaf:Document.  Subproperty of prov:hadPrimarySource. In case the string comes from another NIF String and gives the exact provenance, please use nif:wasConvertedFrom or a subProperty thereof.
    ///     Changelog:
    ///     * 0.2.0 added subPropertyOf prov:hadPrimarySource
    ///     * 0.2.1 clarification
    ///     </para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#sourceUrl">nif:sourceUrl</a>
    /// </summary>
    let sourceUrl = _prefixId.prefix "sourceUrl"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.0^^xsd:string</para>
    ///   <para>rdfs:label : stem</para>
    ///   <para>rdfs:comment : The stem(s) of the nif:String.</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#stem">nif:stem</a>
    /// </summary>
    let stem = _prefixId.prefix "stem"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.1^^xsd:string</para>
    ///   <para>rdfs:label : sub string</para>
    ///   <para>rdfs:comment : This property together with nif:subString, nif:superString, and their transitive extension can be used to express that one string is contained in another one. Examples: "a" nif:subString "apple" , "apple" nif:subString "apple".  The transitivity axioms are included in nif-core-inf.ttl and need to be included separately to keep a low reasoning profile. They are modeled after skos:broader and skos:broaderTransitive</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#subString">nif:subString</a>
    /// </summary>
    let subString = _prefixId.prefix "subString"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.1^^xsd:string</para>
    ///   <para>rdfs:label : transitive version of subString</para>
    ///   <para>rdfs:comment : transitive version of subString
    ///
    ///     Inferences (nif-core-inf.ttl):
    ///     Transitive definition kept in a different ontology
    ///
    ///     Changelog:
    ///     * 0.1.0: Initial version
    ///     * 0.1.1: merged inf
    ///     </para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#subStringTrans">nif:subStringTrans</a>
    /// </summary>
    let subStringTrans = _prefixId.prefix "subStringTrans"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.0^^xsd:string</para>
    ///   <para>rdfs:label : super String</para>
    ///   <para>rdfs:comment : see nif:subString</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#superString">nif:superString</a>
    /// </summary>
    let superString = _prefixId.prefix "superString"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.1^^xsd:string</para>
    ///   <para>rdfs:label : transitive version of superString</para>
    ///   <para>rdfs:comment : see nif:subStringTrans^^xsd:string</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#superStringTrans">nif:superStringTrans</a>
    /// </summary>
    let superStringTrans = _prefixId.prefix "superStringTrans"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.0^^xsd:string</para>
    ///   <para>rdfs:label : most specific class reference</para>
    ///   <para>rdfs:comment : This property marks the most specific class from itsrdf:taClassRef. The rule is: from the set S of itsrdf:taClassRef attached to this resource taMscRef points to the one that does not have any subclasses in the set S except itself. So if taClassRef is owl:Thing, dbo:Agent, dbo:Person, dbp:Actor taMsClassRef is dbo:Actor </para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#taMsClassRef">nif:taMsClassRef</a>
    /// </summary>
    let taMsClassRef = _prefixId.prefix "taMsClassRef"
    let tail = _prefixId.prefix "tail"
    /// <summary>
    ///   <para>owl:versionInfo : 0.0.1^^xsd:string</para>
    ///   <para>rdfs:label : topic^^xsd:string</para>
    ///   <para>rdfs:comment : The topic of a string
    ///     Changelog:
    ///     * 0.0.1 initial commit of property</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#topic">nif:topic</a>
    /// </summary>
    let topic = _prefixId.prefix "topic"
    /// <summary>
    ///   <para>owl:versionInfo : 0.1.0^^xsd:string</para>
    ///   <para>rdfs:label : was converted from</para>
    ///   <para>rdfs:comment : This property should be used, when mapping one nif:String or nif:Context to another and is often confused with nif:sourceUrl.
    ///     While nif:sourceUrl is built on PROV-O and is used to link the nif:Context to the document URL for provenance information, nif:convertedFrom is more precise and pinpoints exact locations where a certain NIF String "wasConvertedFrom".
    ///     nif:wasConvertedFrom is therefore used to provide *exact* provenance during a conversion process, e.g. when removing tags from XHTML and then linking XPath URIs to NIF index based URIs (e.g.  RFC 5147 with char=x,y). An example of the usage of this property can be found here: http://www.w3.org/TR/its20/#conversion-to-nif
    ///
    ///     Example
    ///     # "Dublin"
    /// &lt;http://example.com/myitsservice?informat=html&amp;intype=url&amp;input=http://example.com/doc.html&amp;char=11,17&gt;
    ///  nif:wasConvertedFrom
    ///  &lt;http://example.com/myitsservice?informat=html&amp;intype=url&amp;input=http://example.com/doc.html&amp;xpath=/html/body[1]/h2[1]/span[1]/text()[1]&gt;.
    ///     </para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#wasConvertedFrom">nif:wasConvertedFrom</a>
    /// </summary>
    let wasConvertedFrom = _prefixId.prefix "wasConvertedFrom"
    /// <summary>
    ///   <para>owl:versionInfo : 0.2.0^^xsd:string</para>
    ///   <para>rdfs:label : has word</para>
    ///   <para>rdfs:comment : This property links sentences to their words.</para>
    ///   <a href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#word">nif:word</a>
    /// </summary>
    let word = _prefixId.prefix "word"
