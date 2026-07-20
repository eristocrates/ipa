namespace http.www.w3.org._2004._06.rei.hash

open DoxAletheia

module rei =
    let _namespace_name = "http://www.w3.org/2004/06/rei#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2004/06/rei#BNode"></see>
    /// </summary>
    let BNode = _prefix "BNode"
    /// <summary>
    ///   <see href="http://www.w3.org/2004/06/rei#Term"></see>
    /// </summary>
    let Term = _prefix "Term"
    /// <summary>
    /// A formula is identified by an unordered set of statements,
    /// 	with a sets of existentially and universally quantified symbols.
    /// 	For example,
    /// 		[ :forAll  ( [:uri "ex:#x"] [:uri "ex:#y"]);
    /// 		  :forSome ( [:uri "ex:#a"] [:uri "ex:#b"]);
    /// 		  :statements ( :s1 :s2 :s3 )
    /// 		]
    /// 	is equivalent to e.g. in loose math
    /// 		forall x,y,x there exists a,b,c such that s1 and s2 and s3
    /// 	That is, the universals are always outside the existentials.
    /// 	Two formulae are the equal if the contents
    /// 	of their forAll, forSome, and statements lists are the same
    /// 	irrespective of order.
    /// 	Two formulae are equivalent if there is a 1:1 mapping between
    /// 	variable names of one and variable names in the other
    /// 	which used as subsitution bindings on one gives a formula
    /// 	equal to the other.
    ///
    /// <see href="http://www.w3.org/2004/06/rei#Formula"></see></summary>
    let Formula = _prefix "Formula"
    /// <summary>
    /// Literals are identified by their string value, their
    /// 	datatype (or absence thereof) and their language code
    /// 	(or absencethereof). As we are modeling RDF in RDF,
    /// 	we can just use a literal the value of a literal.
    ///
    /// <see href="http://www.w3.org/2004/06/rei#Literal"></see></summary>
    let Literal = _prefix "Literal"
    /// <summary>
    ///   <see href="http://www.w3.org/2004/06/rei#RDFTerm"></see>
    /// </summary>
    let RDFTerm = _prefix "RDFTerm"
    /// <summary>
    /// A formula which meets the constaints of being
    /// 	an RDF Graph as per the RDF spec. No universally qualified variables,
    /// 	no nested formulae, no literals as subject, etc.
    /// <see href="http://www.w3.org/2004/06/rei#RDFGraph"></see></summary>
    let RDFGraph = _prefix "RDFGraph"
    /// <summary>
    /// A statement is the unit of information.
    /// 	It expresses a binary relation.
    /// 	Its significance is determined by the realtion,
    /// 	generally referred to as its predicate.
    ///
    /// <see href="http://www.w3.org/2004/06/rei#Statement"></see></summary>
    let Statement = _prefix "Statement"
    /// <summary>
    ///   <see href="http://www.w3.org/2004/06/rei#Symbol"></see>
    /// </summary>
    let Symbol = _prefix "Symbol"
    /// <summary>
    ///   <see href="http://www.w3.org/2004/06/rei#existentials"></see>
    /// </summary>
    let existentials = _prefix "existentials"
    /// <summary>
    /// Shorhand for object!uri
    /// <see href="http://www.w3.org/2004/06/rei#objURI"></see></summary>
    let objURI = _prefix "objURI"
    /// <summary>
    ///   <see href="http://www.w3.org/2004/06/rei#String"></see>
    /// </summary>
    let String = _prefix "String"
    /// <summary>
    /// Shorhand for object!Literal
    /// <see href="http://www.w3.org/2004/06/rei#objValue"></see></summary>
    let objValue = _prefix "objValue"
    /// <summary>
    ///   <see href="http://www.w3.org/2004/06/rei#object"></see>
    /// </summary>
    let object = _prefix "object"
    /// <summary>
    /// Shorhand for predicate!uri
    /// <see href="http://www.w3.org/2004/06/rei#predURI"></see></summary>
    let predURI = _prefix "predURI"
    /// <summary>
    /// Shorhand for predicate!Literal. Not RDF 1.0.
    /// <see href="http://www.w3.org/2004/06/rei#predValue"></see></summary>
    let predValue = _prefix "predValue"
    /// <summary>
    ///   <see href="http://www.w3.org/2004/06/rei#predicate"></see>
    /// </summary>
    let predicate = _prefix "predicate"
    /// <summary>
    /// The order of the statements is irrelevant.
    /// 	They are given as a rdf:List because rdf:Lists exist,
    /// 	and we want a closed set.
    ///
    /// <see href="http://www.w3.org/2004/06/rei#statements"></see></summary>
    let statements = _prefix "statements"
    /// <summary>
    /// Shorhand for subject!uri
    /// <see href="http://www.w3.org/2004/06/rei#subjURI"></see></summary>
    let subjURI = _prefix "subjURI"
    /// <summary>
    /// Shorhand for subject!Literal. Not in RDF 1.0
    /// <see href="http://www.w3.org/2004/06/rei#subjValue"></see></summary>
    let subjValue = _prefix "subjValue"
    /// <summary>
    ///   <see href="http://www.w3.org/2004/06/rei#subject"></see>
    /// </summary>
    let subject = _prefix "subject"
    /// <summary>
    ///   <see href="http://www.w3.org/2004/06/rei#universals"></see>
    /// </summary>
    let universals = _prefix "universals"
    /// <summary>
    /// The URI of the symbol is all that is needed to identify it.
    /// 	This is the name string.
    /// <see href="http://www.w3.org/2004/06/rei#uri"></see></summary>
    let uri = _prefix "uri"
    /// <summary>
    /// The value of a literal.
    ///
    /// 	Value is the relation between a node (which happens to be a literal, list etc,..) and the value it takes.
    /// <see href="http://www.w3.org/2004/06/rei#value"></see></summary>
    let value = _prefix "value"
    /// <summary>
    ///   <see href="http://www.w3.org/2004/06/rei#iteral"></see>
    /// </summary>
    let iteral = _prefix "iteral"
