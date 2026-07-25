namespace http.persistence.uni_leipzig.org.nlp2rdf.ontologies.nif_core.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module nif =
    let _namespace_iri = Namespace_Iri nif |> NamespaceIRI
    /// <summary>
    ///   <para>nif:URIScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A URI Scheme for NIF, subclasses need to define guidelines on the URI Scheme as well as the text it refers to. This class is just to keep some order, and should not be serialized.
    ///
    ///     This is an abstract class and should not be serialized.
    ///
    ///     Changelog:
    ///     * 0.1.1 changed comment
    ///     </para>
    /// labels<para>URI Scheme</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#URIScheme">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#URIScheme</seealso>
    let URIScheme = Prefixed_Name(nif, "URIScheme") |> PrefixedName
    /// <summary>
    ///   <para>nif:Context</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The string that serves as a context for its substrings.  The Unicode String given in the nif:isString property must be used to calculate the begin and endIndex for all nif:Strings that have a nif:referenceContext property to this URI. For further information, see http://svn.aksw.org/papers/2013/ISWC_NIF/public.pdf
    ///
    ///     Changelog
    ///     * 1.0.1. improved documentation
    ///     * 1.0.2. merged inf model
    ///     </para>
    /// labels<para>Context</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#Context">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#Context</seealso>
    let Context = Prefixed_Name(nif, "Context") |> PrefixedName
    /// <summary>
    ///   <para>nif:beginIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The begin index of a character range as defined in http://tools.ietf.org/html/rfc5147#section-2.2.1 and http://tools.ietf.org/html/rfc5147#section-2.2.2, measured as the gap between two characters, starting to count from 0 (the position before the first character of a text).
    ///     Example: Index "2" is the postion between "Mr" and "."  in "Mr. Sandman".
    ///     Note: RFC 5147 is re-used for the definition of character ranges. RFC 5147 is assuming a text/plain MIME type. NIF builds upon Unicode and is content agnostic.
    ///     Requirement (1): This property has the same value the "Character position" of RFC 5147 and it MUST therefore be castable to xsd:nonNegativeInteger, i.e. it MUST not have negative values.
    ///     Requirement (2): The index of the subject string MUST be calculated relative to the nif:referenceContext of the subject. If available, this is the rdf:Literal of the nif:isString property.
    ///
    ///     Changelog:
    ///     * 1.0.0: Introduced stable version.
    ///     * 1.0.1: merged val+inf, added range
    ///     </para>
    /// labels<para>begin index</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#beginIndex">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#beginIndex</seealso>
    let beginIndex = Prefixed_Name(nif, "beginIndex") |> PrefixedName
    /// <summary>
    ///   <para>nif:referenceContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a URI of a string to its reference context of type nif:Context.  The reference context determines the calculation of begin and end index
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
    /// labels<para>reference context</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#referenceContext">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#referenceContext</seealso>
    let referenceContext = Prefixed_Name(nif, "referenceContext") |> PrefixedName
    /// <summary>
    ///   <para>nif:superStringTrans</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>see nif:subStringTrans</para>
    /// labels<para>transitive version of superString</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#superStringTrans">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#superStringTrans</seealso>
    let superStringTrans = Prefixed_Name(nif, "superStringTrans") |> PrefixedName

    /// <summary>
    ///   <para>nif:CollectionOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#CollectionOccurrence">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#CollectionOccurrence</seealso>
    let CollectionOccurrence =
        Prefixed_Name(nif, "CollectionOccurrence") |> PrefixedName

    /// <summary>
    ///   <para>nif:category</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A simple annotation for machine learning purposes. The object can be anything, e.g. the literal "A. PRESS: Reportage" from Brown or any URI.
    /// 	ChangeLog:
    /// 	* 0.2.0 changed nif:class to nif:category due to conflict with Java
    /// 	</para>
    /// labels<para>category</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#category">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#category</seealso>
    let category = Prefixed_Name(nif, "category") |> PrefixedName
    /// <summary>
    ///   <para>nif:classAnnotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>
    ///       see Towards Web-Scale Collaborative Knowledge Extraction  http://svn.aksw.org/papers/2012/PeoplesWeb/public_preprint.pdf‎ page 12 .
    ///       Changelog:
    ///       * 0.1.1 Fixed page number
    ///     </para>
    /// labels<para>classAnnotation</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#classAnnotation">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#classAnnotation</seealso>
    let classAnnotation = Prefixed_Name(nif, "classAnnotation") |> PrefixedName
    /// <summary>
    ///   <para>nif:dependency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 		A dependency relation pointing from gov to dep.
    /// 		Changelog:
    /// 		* 0.1.0 initial commit of property "dependency"
    /// 		* 0.1.1 made the property subproperty of dependencyTrans
    ///     </para>
    /// labels<para>dependency</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#dependency">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#dependency</seealso>
    let dependency = Prefixed_Name(nif, "dependency") |> PrefixedName

    /// <summary>
    ///   <para>nif:dependencyRelationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>String denoting the kind of dependency relation</para>
    /// labels<para>dependency relation type</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#dependencyRelationType">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#dependencyRelationType</seealso>
    let dependencyRelationType =
        Prefixed_Name(nif, "dependencyRelationType") |> PrefixedName

    /// <summary>
    ///   <para>nif:NormalizedCollectionOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#NormalizedCollectionOccurrence">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#NormalizedCollectionOccurrence</seealso>
    let NormalizedCollectionOccurrence =
        Prefixed_Name(nif, "NormalizedCollectionOccurrence") |> PrefixedName

    /// <summary>
    ///   <para>nif:narrowerContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The inverse of nif:narrowerContext</para>
    /// labels<para>narrower Context</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#narrowerContext">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#narrowerContext</seealso>
    let narrowerContext = Prefixed_Name(nif, "narrowerContext") |> PrefixedName
    /// <summary>
    ///   <para>nif:nextWord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>see nif:nextSentence</para>
    /// </remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#nextWord">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#nextWord</seealso>
    let nextWord = Prefixed_Name(nif, "nextWord") |> PrefixedName
    /// <summary>
    ///   <para>nif:previousWord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>see nif:nextSentence</para>
    /// </remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#previousWord">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#previousWord</seealso>
    let previousWord = Prefixed_Name(nif, "previousWord") |> PrefixedName
    /// <summary>
    ///   <para>nif:oliaConf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The confidence is relative to the tool and can be between 0.0 and 1.0, it is for nif:oliaLink and therefore also for nif:oliaCategory.
    ///     Changelog:
    ///     0.2.0 merged confidence for category and link
    ///     </para>
    /// labels<para>Confidence of OLiA tag</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#oliaConf">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#oliaConf</seealso>
    let oliaConf = Prefixed_Name(nif, "oliaConf") |> PrefixedName
    /// <summary>
    ///   <para>nif:oliaProv</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links to the URI describing the provenance</para>
    /// labels<para>Provenance of OLiA tag</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#oliaProv">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#oliaProv</seealso>
    let oliaProv = Prefixed_Name(nif, "oliaProv") |> PrefixedName
    /// <summary>
    ///   <para>nif:opinion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is used to link to a marl:Opinion. We have not investigated marl, so it might be replaced. http://marl.gi2mo.org/?page_id=1#overview . InverseOf marl:extractedFrom</para>
    /// labels<para>opinion</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#opinion">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#opinion</seealso>
    let opinion = Prefixed_Name(nif, "opinion") |> PrefixedName
    /// <summary>
    ///   <para>nif:predLang</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
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
    /// labels<para>predominant language</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#predLang">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#predLang</seealso>
    let predLang = Prefixed_Name(nif, "predLang") |> PrefixedName
    /// <summary>
    ///   <para>nif:Phrase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A nif:Phrase can be a nif:String, that is a chunk of several words or a word itself (e.g. a NounPhrase as a Named Entity). The term is underspecified and can be compatible with many defintitions of phrase. Please subClass it to specify the meaning (e.g. for Chunking or Phrase Structure Grammar). Example: ((My dog)(also)(likes)(eating (sausage)))
    ///     Changelog:
    ///     * 0.1.1 fixed spelling
    ///     </para>
    /// labels<para>Phrase</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#Phrase">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#Phrase</seealso>
    let Phrase = Prefixed_Name(nif, "Phrase") |> PrefixedName
    /// <summary>
    ///   <para>nif:Title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     A title within a text.
    ///     Changelog:
    ///     * 0.1.1 fixed spelling, added language tag
    ///     </para>
    /// labels<para>Title</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#Title">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#Title</seealso>
    let Title = Prefixed_Name(nif, "Title") |> PrefixedName
    /// <summary>
    ///   <para>nif:Word</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
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
    /// labels<para>Word</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#Word">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#Word</seealso>
    let Word = Prefixed_Name(nif, "Word") |> PrefixedName
    /// <summary>
    ///   <para>nif:anchorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The string, which the URI is representing as an RDF Literal. Some use cases require this property, as it is necessary for certain sparql queries. </para>
    /// labels<para>anchor of</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#anchorOf">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#anchorOf</seealso>
    let anchorOf = Prefixed_Name(nif, "anchorOf") |> PrefixedName
    /// <summary>
    ///   <para>nif:before</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>For each string you can include a snippet (e.g. 10-40 characters of text), that occurs immediately before the subject string.</para>
    /// labels<para>before</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#before">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#before</seealso>
    let before = Prefixed_Name(nif, "before") |> PrefixedName
    /// <summary>
    ///   <para>nif:hasContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a nif:ContextCollection to its contexts.
    ///
    ///     Changelog
    ///     * 0.2.0. renamed property since a lot of people where too confused by nif:context
    ///     </para>
    /// labels<para>has context</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#hasContext">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#hasContext</seealso>
    let hasContext = Prefixed_Name(nif, "hasContext") |> PrefixedName
    /// <summary>
    ///   <para>nif:ContextOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#ContextOccurrence">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#ContextOccurrence</seealso>
    let ContextOccurrence = Prefixed_Name(nif, "ContextOccurrence") |> PrefixedName
    /// <summary>
    ///   <para>nif:nextSentenceTrans</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>see nif:nextSentence</para>
    /// </remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#nextSentenceTrans">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#nextSentenceTrans</seealso>
    let nextSentenceTrans = Prefixed_Name(nif, "nextSentenceTrans") |> PrefixedName
    /// <summary>
    ///   <para>nif:nextWordTrans</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>see nif:nextSentence</para>
    /// </remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#nextWordTrans">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#nextWordTrans</seealso>
    let nextWordTrans = Prefixed_Name(nif, "nextWordTrans") |> PrefixedName
    /// <summary>
    ///   <para>nif:oliaCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>This property links a string URI to classes of the OLiA Reference model. It provides a direct link for querying, thus it is a redundant optimization.
    ///     Changelog:
    ///     0.1.1 - added subproperty of nif:classAnnotation as per http://svn.aksw.org/papers/2012/PeoplesWeb/public_preprint.pdf‎ page 21
    ///     0.1.2 - removed domain axiom for annotationproperty
    ///     0.1.3 - improved documentation
    ///     </para>
    /// labels<para>OLiA Category</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#oliaCategory">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#oliaCategory</seealso>
    let oliaCategory = Prefixed_Name(nif, "oliaCategory") |> PrefixedName
    /// <summary>
    ///   <para>nif:oliaLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property links a string to a URI from one of the OLiA Annotation model, e.g. http://purl.org/olia/penn.owl#NNP
    ///
    ///     Changelog
    ///     0.1.1 - added subproperty of nif:annotation as per http://svn.aksw.org/papers/2012/PeoplesWeb/public_preprint.pdf‎ page 21
    ///     </para>
    /// labels<para>OLiA link</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#oliaLink">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#oliaLink</seealso>
    let oliaLink = Prefixed_Name(nif, "oliaLink") |> PrefixedName
    /// <summary>
    ///   <para>nif:posTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>To include the pos tag as it comes out of the NLP tool as RDF Literal. This property is discouraged to use alone, please use oliaLink and oliaCategory.  We included it, because some people might still want it and will even create their own property, if the string variant is missing </para>
    /// labels<para>Part of speech tag</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#posTag">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#posTag</seealso>
    let posTag = Prefixed_Name(nif, "posTag") |> PrefixedName
    /// <summary>
    ///   <para>nif:Sentence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     A sentence.
    ///     Changelog:
    ///     * 0.1.1 fixed spelling, added language tag
    ///     </para>
    /// labels<para>Sentence</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#Sentence">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#Sentence</seealso>
    let Sentence = Prefixed_Name(nif, "Sentence") |> PrefixedName
    /// <summary>
    ///   <para>nif:after</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>For each string you can include a snippet (e.g. 10-40 characters of text), that occurs immediately after the subject string.</para>
    /// labels<para>after</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#after">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#after</seealso>
    let after = Prefixed_Name(nif, "after") |> PrefixedName
    /// <summary>
    ///   <para>nif:wasConvertedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property should be used, when mapping one nif:String or nif:Context to another and is often confused with nif:sourceUrl.
    ///     While nif:sourceUrl is built on PROV-O and is used to link the nif:Context to the document URL for provenance information, nif:convertedFrom is more precise and pinpoints exact locations where a certain NIF String "wasConvertedFrom".
    ///     nif:wasConvertedFrom is therefore used to provide *exact* provenance during a conversion process, e.g. when removing tags from XHTML and then linking XPath URIs to NIF index based URIs (e.g.  RFC 5147 with char=x,y). An example of the usage of this property can be found here: http://www.w3.org/TR/its20/#conversion-to-nif
    ///
    ///     Example
    ///     # "Dublin"
    /// &lt;http://example.com/myitsservice?informat=html&amp;intype=url&amp;input=http://example.com/doc.html&amp;char=11,17&gt;
    ///  nif:wasConvertedFrom
    ///  &lt;http://example.com/myitsservice?informat=html&amp;intype=url&amp;input=http://example.com/doc.html&amp;xpath=/html/body[1]/h2[1]/span[1]/text()[1]&gt;.
    ///     </para>
    /// labels<para>was converted from</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#wasConvertedFrom">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#wasConvertedFrom</seealso>
    let wasConvertedFrom = Prefixed_Name(nif, "wasConvertedFrom") |> PrefixedName
    /// <summary>
    ///   <para>nif:annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///       see Towards Web-Scale Collaborative Knowledge Extraction  http://svn.aksw.org/papers/2012/PeoplesWeb/public_preprint.pdf‎ page 21 .
    ///       Changelog:
    ///       * 0.1.1 Fixed page number
    ///     </para>
    /// labels<para>annotation</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#annotation">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#annotation</seealso>
    let annotation = Prefixed_Name(nif, "annotation") |> PrefixedName
    /// <summary>
    ///   <para>nif:broaderContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property should be used to express that one Context is contained in another Context, e.g. several sentences of a document are modelled indivudally and refer to the broader context of the whole document.</para>
    /// labels<para>broader Context</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#broaderContext">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#broaderContext</seealso>
    let broaderContext = Prefixed_Name(nif, "broaderContext") |> PrefixedName
    /// <summary>
    ///   <para>nif:confidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The confidence of an annotation as decimal between 0 and 1
    ///     Changelog:
    ///     * 0.0.1 initial commit of property</para>
    /// labels<para>confidence of annotation</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#confidence">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#confidence</seealso>
    let confidence = Prefixed_Name(nif, "confidence") |> PrefixedName
    /// <summary>
    ///   <para>nif:contextAsLiteral</para>
    /// </summary>
    /// <remarks>
    ///   <para>
    ///       The string that the nif:anchorOf is embedded in. FILTER ( strlen (nif:referenceContext [ nif:isString ] ) )
    ///     </para>
    /// labels<para>contextAsLiteral</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#contextAsLiteral">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#contextAsLiteral</seealso>
    let contextAsLiteral = Prefixed_Name(nif, "contextAsLiteral") |> PrefixedName
    /// <summary>
    ///   <para>nif:dependencyTrans</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 		Changelog:
    /// 		* 0.1.0 initial commit of property
    /// 		* 0.1.1 merged inf model
    ///     </para>
    /// labels<para>transitive version of dependency</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#dependencyTrans">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#dependencyTrans</seealso>
    let dependencyTrans = Prefixed_Name(nif, "dependencyTrans") |> PrefixedName
    /// <summary>
    ///   <para>nif:inter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 		This object property models a relation between two nif:Strings. The name "inter" is kept generic and can be used to express any kind of relation in between (inter) two nif:Strings. Extensions can create rdfs:subPropertyOf for "head", "dependent", nif:substring and nif:nextWord.
    ///
    /// 		Changelog:
    /// 		* 0.1.0 initial commit of property "dependency"
    /// 		* 0.2.0 changed name to "inter" which is more general than "dependency".
    ///     </para>
    /// labels<para>inter</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#inter">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#inter</seealso>
    let inter = Prefixed_Name(nif, "inter") |> PrefixedName
    /// <summary>
    ///   <para>nif:firstWord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property links sentences to their first word.
    ///     Changelog:
    ///     * 0.1.1 merged inf+val
    ///     </para>
    /// labels<para>has first word</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#firstWord">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#firstWord</seealso>
    let firstWord = Prefixed_Name(nif, "firstWord") |> PrefixedName
    /// <summary>
    ///   <para>nif:head</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    ///       The first few chars of the nif:anchorOf. Typically used if the nif:anchorOf
    ///       is to long for inclusion as RDF literal.
    ///     </para>
    /// labels<para>head</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#head">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#head</seealso>
    let head = Prefixed_Name(nif, "head") |> PrefixedName
    /// <summary>
    ///   <para>nif:word</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property links sentences to their words.</para>
    /// labels<para>has word</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#word">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#word</seealso>
    let word = Prefixed_Name(nif, "word") |> PrefixedName
    /// <summary>
    ///   <para>nif:keyword</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A general keyword associated with a string
    ///     Changelog:
    ///     * 0.0.1 initial commit of property</para>
    /// labels<para>keyword</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#keyword">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#keyword</seealso>
    let keyword = Prefixed_Name(nif, "keyword") |> PrefixedName
    /// <summary>
    ///   <para>nif:lang</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 	Defines the language of a substring of the context. If the language for the nif:Context should be specified, nif:predominantLanguage must be used.
    /// 	see nif:predominantLanguage for more info.
    /// 	</para>
    /// labels<para>language of the string</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#lang">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#lang</seealso>
    let lang = Prefixed_Name(nif, "lang") |> PrefixedName
    /// <summary>
    ///   <para>nif:lastWord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property links sentences to their last word.
    /// 	 Changelog:
    /// 	 * 0.1.1 fixed label
    /// 	 * 0.1.2 merged inf+val
    ///     </para>
    /// labels<para>has last word</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#lastWord">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#lastWord</seealso>
    let lastWord = Prefixed_Name(nif, "lastWord") |> PrefixedName
    /// <summary>
    ///   <para>nif:lemma</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The lemma(s) of the nif:String.</para>
    /// labels<para>lemma</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#lemma">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#lemma</seealso>
    let lemma = Prefixed_Name(nif, "lemma") |> PrefixedName
    /// <summary>
    ///   <para>nif:literalAnnotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    ///       see Towards Web-Scale Collaborative Knowledge Extraction  http://svn.aksw.org/papers/2012/PeoplesWeb/public_preprint.pdf‎ page 21 .
    ///       Changelog:
    ///       * 0.1.1 Fixed page number
    ///     </para>
    /// labels<para>literalAnnotation</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#literalAnnotation">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#literalAnnotation</seealso>
    let literalAnnotation = Prefixed_Name(nif, "literalAnnotation") |> PrefixedName
    /// <summary>
    ///   <para>nif:nextSentence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>This property (and nif:previousSentence, nif:nextWord, nif:previousWord and their transitive extension) can be used to make resources of nif:Sentence and nif:Word traversable, it can not be assumed that no gaps or whitespaces between sentences or words exist, i.e. string adjacency is not mandatory. The transitivity axioms are included in nif-core-inf.ttl and need to be included separately to keep a low reasoning profile. They are modeled after skos:broader and skos:broaderTransitive
    ///     </para>
    /// </remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#nextSentence">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#nextSentence</seealso>
    let nextSentence = Prefixed_Name(nif, "nextSentence") |> PrefixedName
    /// <summary>
    ///   <para>nif:previousSentence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>see nif:nextSentence</para>
    /// </remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#previousSentence">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#previousSentence</seealso>
    let previousSentence = Prefixed_Name(nif, "previousSentence") |> PrefixedName
    /// <summary>
    ///   <para>nif:RFC5147String</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>cf. http://tools.ietf.org/html/rfc5147 URIs of this class have to conform with the syntax of RFC 5147 in a way that the end on a valid identifier, if you remove the prefix. Note that unlike RFC 5147 NIF does not requrire '#' URIs. So valid URIs are http://example.org#char=0,28 , http://example.org/whatever/char=0,28 , http://example.org/nif?char=0,28
    ///     Changelog:
    ///     * 1.1.0 changed subclass to CString .
    ///     * 1.1.1 typo in rdfs:label and extension of comment
    ///     </para>
    /// labels<para>RFC 5147 String</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#RFC5147String">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#RFC5147String</seealso>
    let RFC5147String = Prefixed_Name(nif, "RFC5147String") |> PrefixedName

    /// <summary>
    ///   <para>nif:ContextHashBasedString</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para> cf. https://www.google.de/search?q=Linked-Data+Aware+URI+Schemes+for+Referencing+Text</para>
    /// labels<para>Context Hash Based String</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#ContextHashBasedString">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#ContextHashBasedString</seealso>
    let ContextHashBasedString =
        Prefixed_Name(nif, "ContextHashBasedString") |> PrefixedName

    /// <summary>
    ///   <para>nif:OffsetBasedString</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>cf. Linked-Data Aware URI Schemes for Referencing Text Fragments by Sebastian Hellmann, Jens Lehmann und Sören Auer in EKAW 2012 http://jens-lehmann.org/files/2012/ekaw_nif.pdf
    ///
    /// 	requires the existence of begin, endIndex and referenceContext
    ///
    /// 	Changelog:
    /// 	* 1.0.0 originally a plain text string was attached to this uri scheme, but this was removed later, because of complaints and complexity.
    /// 	* 1.1.0 subclassing of nif:CString
    ///     </para>
    /// labels<para>Offset-based String</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#OffsetBasedString">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#OffsetBasedString</seealso>
    let OffsetBasedString = Prefixed_Name(nif, "OffsetBasedString") |> PrefixedName
    /// <summary>
    ///   <para>nif:CStringInst</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An abitrary URI (e.g. a URN) for an arbitrary string of the context. This is roughly the same as TextAnnotations are currently implemented in Stanbol.</para>
    /// labels<para>Consecutive String Instantiation</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#CStringInst">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#CStringInst</seealso>
    let CStringInst = Prefixed_Name(nif, "CStringInst") |> PrefixedName
    /// <summary>
    ///   <para>nif:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>The NLP Interchange Format (NIF) is an RDF/OWL-based format that aims to achieve interoperability between Natural Language Processing (NLP) tools, language resources and annotations. NIF consists of specifications, ontologies and software, which are combined under the version identifier "2.0", but are versioned individually. This ontology is developed by the NLP2RDF project (http://nlp2rdf.org) and provided as part of NIF 2.0 under CC-BY license as well as Apache 2.0. The ontology contains seven core URIs (String, RFC5147String, Context, isString, referenceContext, beginIndex, endIndex) that provide the foundation  to express NLP annotations effectively in RDF.</para>
    /// labels<para>NIF 2.0 Core Ontology</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#</seealso>
    let _prefix_iri = Prefixed_Name(nif, "") |> PrefixedName
    /// <summary>
    ///   <para>nif:Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Individuals of this class are annotations of strings. This class can be used if an annotation statement has to be annotated with further information, like confidence or annotation provenance (like which tool produced the annotation).
    ///     Changelog:
    ///     * 0.0.1 initial commit of class</para>
    /// labels<para>Annotation</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#Annotation">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#Annotation</seealso>
    let Annotation = Prefixed_Name(nif, "Annotation") |> PrefixedName
    /// <summary>
    ///   <para>nif:CString</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A URI Scheme for NIF which is able to refer to a single, consecutive string in a context. Note that any scheme subclassing this class, requires the existence of beginIndex, endIndex and referenceContext .
    ///     This is an abstract class and should not be serialized.
    ///     </para>
    /// labels<para>Consecutive String</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#CString">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#CString</seealso>
    let CString = Prefixed_Name(nif, "CString") |> PrefixedName
    /// <summary>
    ///   <para>nif:endIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The end index of a character range as defined in http://tools.ietf.org/html/rfc5147#section-2.2.1 and http://tools.ietf.org/html/rfc5147#section-2.2.2, measured as the gap between two characters, starting to count from 0 (the position before the first character of a text).
    ///     Example: Index "2" is the postion between "Mr" and "."  in "Mr. Sandman".
    ///     Note: RFC 5147 is re-used for the definition of character ranges. RFC 5147 is assuming a text/plain MIME type. NIF builds upon Unicode and is content agnostic.
    ///     Requirement (1): This property has the same value the "Character position" of RFC 5147 and it must therefore be an xsd:nonNegativeInteger .
    ///     Requirement (2): The index of the subject string MUST be calculated relative to the nif:referenceContext of the subject. If available, this is the rdf:Literal of the nif:isString property.</para>
    /// labels<para>end index</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#endIndex">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#endIndex</seealso>
    let endIndex = Prefixed_Name(nif, "endIndex") |> PrefixedName
    /// <summary>
    ///   <para>nif:isString</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The reference text as rdf:Literal for this nif:Context resource.
    ///     NIF requires that the reference text (i.e. the context) is always included in the RDF as an rdf:Literal.
    ///     Note, that the isString property is *the* place to keep the string itself in RDF.
    ///     All other nif:Strings and nif:URISchemes relate to the text of this property to calculate character position and indices.
    ///
    ///     Changelog
    ///     * 1.0.0: Introduced stable version.
    ///     * 1.0.1 improved documentation
    ///     * 1.0.2: merged val+inf
    ///     </para>
    /// labels<para>is string</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#isString">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#isString</seealso>
    let isString = Prefixed_Name(nif, "isString") |> PrefixedName
    /// <summary>
    ///   <para>nif:String</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Individuals of this class are a string, i.e. Unicode characters, who have been given a URI and are used in the subject of an RDF statement.
    ///     This class is abstract and should not be serialized.
    ///
    ///     NIF-Stanbol (nif-stanbol.ttl):
    ///     subclassOf nifs:Annotation because it "annotates" strings for example with begin and end index. The class is similar to fise:TextAnnotation
    ///
    ///     Changelog
    ///     * 1.0.1. improved documentation
    ///     * 1.0.2. merged inf and val model
    ///     </para>
    /// labels<para>String</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#String">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#String</seealso>
    let String = Prefixed_Name(nif, "String") |> PrefixedName
    /// <summary>
    ///   <para>nif:ContextCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A collection of contexts used to create an unordered set of context via the nif:hasContext property. This can be compared to a document collection, but here it is a collection of nif:Context and therefore a collection of annotated strings, not documents.
    ///
    ///     Open Issues
    ///     Investigate ordered collections
    ///
    ///     Changelog
    ///     * 0.1.1 improved documentation
    ///     </para>
    /// labels<para>Context Collection</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#ContextCollection">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#ContextCollection</seealso>
    let ContextCollection = Prefixed_Name(nif, "ContextCollection") |> PrefixedName

    /// <summary>
    ///   <para>nif:NormalizedContextOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#NormalizedContextOccurrence">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#NormalizedContextOccurrence</seealso>
    let NormalizedContextOccurrence =
        Prefixed_Name(nif, "NormalizedContextOccurrence") |> PrefixedName

    /// <summary>
    ///   <para>nif:Paragraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     A paragraph.
    ///     Changelog:
    ///     * 0.1.1 fixed spelling, added language tag
    ///     </para>
    /// labels<para>Paragraph</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#Paragraph">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#Paragraph</seealso>
    let Paragraph = Prefixed_Name(nif, "Paragraph") |> PrefixedName
    /// <summary>
    ///   <para>nif:Structure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A structure is a more or less arbitrary label for a partitioning of a string. We do not follow a strict approach for what a word, phrase, sentence, title, paragraph is. These labels enable the definition processes for tool chains, e.g. tool analyses nif:Paragraph and calculates term frequency.
    ///
    ///     This is an abstract class and should not be serialized.
    ///
    ///     Changelog
    ///     0.1.1 not to be serialized comment
    ///     </para>
    /// labels<para>Structure</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#Structure">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#Structure</seealso>
    let Structure = Prefixed_Name(nif, "Structure") |> PrefixedName

    /// <summary>
    ///   <para>nif:previousSentenceTrans</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>see nif:nextSentence</para>
    /// </remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#previousSentenceTrans">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#previousSentenceTrans</seealso>
    let previousSentenceTrans =
        Prefixed_Name(nif, "previousSentenceTrans") |> PrefixedName

    /// <summary>
    ///   <para>nif:previousWordTrans</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>see nif:nextSentence</para>
    /// </remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#previousWordTrans">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#previousWordTrans</seealso>
    let previousWordTrans = Prefixed_Name(nif, "previousWordTrans") |> PrefixedName
    /// <summary>
    ///   <para>nif:sentence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property links words and other structures to their sentence.
    ///     Changelog:
    ///     * 0.2.0 Changed domain from nif:Word to nif:Structure, not longer inverseOf nif:word</para>
    /// </remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#sentence">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#sentence</seealso>
    let sentence = Prefixed_Name(nif, "sentence") |> PrefixedName
    /// <summary>
    ///   <para>nif:sentimentValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Between -1 negative and 1 positive </para>
    /// labels<para>sentiment value</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#sentimentValue">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#sentimentValue</seealso>
    let sentimentValue = Prefixed_Name(nif, "sentimentValue") |> PrefixedName
    /// <summary>
    ///   <para>nif:sourceUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The URL the context was extracted from, e.g. the blog or news article url. Doesn't matter whether it is HTML or XML or plain text. rdfs:range is foaf:Document.  Subproperty of prov:hadPrimarySource. In case the string comes from another NIF String and gives the exact provenance, please use nif:wasConvertedFrom or a subProperty thereof.
    ///     Changelog:
    ///     * 0.2.0 added subPropertyOf prov:hadPrimarySource
    ///     * 0.2.1 clarification
    ///     </para>
    /// labels<para>source URL</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#sourceUrl">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#sourceUrl</seealso>
    let sourceUrl = Prefixed_Name(nif, "sourceUrl") |> PrefixedName
    /// <summary>
    ///   <para>nif:stem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The stem(s) of the nif:String.</para>
    /// labels<para>stem</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#stem">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#stem</seealso>
    let stem = Prefixed_Name(nif, "stem") |> PrefixedName
    /// <summary>
    ///   <para>nif:subString</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property together with nif:subString, nif:superString, and their transitive extension can be used to express that one string is contained in another one. Examples: "a" nif:subString "apple" , "apple" nif:subString "apple".  The transitivity axioms are included in nif-core-inf.ttl and need to be included separately to keep a low reasoning profile. They are modeled after skos:broader and skos:broaderTransitive</para>
    /// labels<para>sub string</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#subString">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#subString</seealso>
    let subString = Prefixed_Name(nif, "subString") |> PrefixedName
    /// <summary>
    ///   <para>nif:subStringTrans</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>transitive version of subString
    ///
    ///     Inferences (nif-core-inf.ttl):
    ///     Transitive definition kept in a different ontology
    ///
    ///     Changelog:
    ///     * 0.1.0: Initial version
    ///     * 0.1.1: merged inf
    ///     </para>
    /// labels<para>transitive version of subString</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#subStringTrans">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#subStringTrans</seealso>
    let subStringTrans = Prefixed_Name(nif, "subStringTrans") |> PrefixedName
    /// <summary>
    ///   <para>nif:superString</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>see nif:subString</para>
    /// labels<para>super String</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#superString">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#superString</seealso>
    let superString = Prefixed_Name(nif, "superString") |> PrefixedName
    /// <summary>
    ///   <para>nif:taMsClassRef</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>This property marks the most specific class from itsrdf:taClassRef. The rule is: from the set S of itsrdf:taClassRef attached to this resource taMscRef points to the one that does not have any subclasses in the set S except itself. So if taClassRef is owl:Thing, dbo:Agent, dbo:Person, dbp:Actor taMsClassRef is dbo:Actor </para>
    /// labels<para>most specific class reference</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#taMsClassRef">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#taMsClassRef</seealso>
    let taMsClassRef = Prefixed_Name(nif, "taMsClassRef") |> PrefixedName
    /// <summary>
    ///   <para>nif:tail</para>
    /// </summary>
    /// <remarks>
    ///   <para>
    ///       The last few chars of the nif:anchorOf. Typically used if the nif:anchorOf
    ///       is to long for inclusion as RDF literal.
    ///     </para>
    /// labels<para>tail</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#tail">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#tail</seealso>
    let tail = Prefixed_Name(nif, "tail") |> PrefixedName
    /// <summary>
    ///   <para>nif:topic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The topic of a string
    ///     Changelog:
    ///     * 0.0.1 initial commit of property</para>
    /// labels<para>topic</para></remarks>
    /// <seealso href="http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#topic">http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#topic</seealso>
    let topic = Prefixed_Name(nif, "topic") |> PrefixedName
