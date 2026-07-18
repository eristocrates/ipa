namespace http.www.w3.org._2004._06.rei.hash

open DoxAletheia.Rdf_Vocabulary

module rei =
    let _namespace_name = "http://www.w3.org/2004/06/rei#"
    /// <summary>
    ///   <see href="http://www.w3.org/2004/06/rei#BNode"></see>
    /// </summary>
    let BNode = Namespaced_IRI.parse _namespace_name "BNode" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2004/06/rei#Term"></see>
    /// </summary>
    let Term = Namespaced_IRI.parse _namespace_name "Term" |> NamespacedName
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
    let Formula = Namespaced_IRI.parse _namespace_name "Formula" |> NamespacedName
    /// <summary>
    /// Literals are identified by their string value, their
    /// 	datatype (or absence thereof) and their language code
    /// 	(or absencethereof). As we are modeling RDF in RDF,
    /// 	we can just use a literal the value of a literal.
    ///
    /// <see href="http://www.w3.org/2004/06/rei#Literal"></see></summary>
    let Literal = Namespaced_IRI.parse _namespace_name "Literal" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2004/06/rei#RDFTerm"></see>
    /// </summary>
    let RDFTerm = Namespaced_IRI.parse _namespace_name "RDFTerm" |> NamespacedName
    /// <summary>
    /// A formula which meets the constaints of being
    /// 	an RDF Graph as per the RDF spec. No universally qualified variables,
    /// 	no nested formulae, no literals as subject, etc.
    /// <see href="http://www.w3.org/2004/06/rei#RDFGraph"></see></summary>
    let RDFGraph = Namespaced_IRI.parse _namespace_name "RDFGraph" |> NamespacedName
    /// <summary>
    /// A statement is the unit of information.
    /// 	It expresses a binary relation.
    /// 	Its significance is determined by the realtion,
    /// 	generally referred to as its predicate.
    ///
    /// <see href="http://www.w3.org/2004/06/rei#Statement"></see></summary>
    let Statement = Namespaced_IRI.parse _namespace_name "Statement" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2004/06/rei#Symbol"></see>
    /// </summary>
    let Symbol = Namespaced_IRI.parse _namespace_name "Symbol" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2004/06/rei#existentials"></see>
    /// </summary>
    let existentials =
        Namespaced_IRI.parse _namespace_name "existentials" |> NamespacedName

    /// <summary>
    /// Shorhand for object!uri
    /// <see href="http://www.w3.org/2004/06/rei#objURI"></see></summary>
    let objURI = Namespaced_IRI.parse _namespace_name "objURI" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2004/06/rei#String"></see>
    /// </summary>
    let String = Namespaced_IRI.parse _namespace_name "String" |> NamespacedName
    /// <summary>
    /// Shorhand for object!Literal
    /// <see href="http://www.w3.org/2004/06/rei#objValue"></see></summary>
    let objValue = Namespaced_IRI.parse _namespace_name "objValue" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2004/06/rei#object"></see>
    /// </summary>
    let object = Namespaced_IRI.parse _namespace_name "object" |> NamespacedName
    /// <summary>
    /// Shorhand for predicate!uri
    /// <see href="http://www.w3.org/2004/06/rei#predURI"></see></summary>
    let predURI = Namespaced_IRI.parse _namespace_name "predURI" |> NamespacedName
    /// <summary>
    /// Shorhand for predicate!Literal. Not RDF 1.0.
    /// <see href="http://www.w3.org/2004/06/rei#predValue"></see></summary>
    let predValue = Namespaced_IRI.parse _namespace_name "predValue" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2004/06/rei#predicate"></see>
    /// </summary>
    let predicate = Namespaced_IRI.parse _namespace_name "predicate" |> NamespacedName
    /// <summary>
    /// The order of the statements is irrelevant.
    /// 	They are given as a rdf:List because rdf:Lists exist,
    /// 	and we want a closed set.
    ///
    /// <see href="http://www.w3.org/2004/06/rei#statements"></see></summary>
    let statements = Namespaced_IRI.parse _namespace_name "statements" |> NamespacedName
    /// <summary>
    /// Shorhand for subject!uri
    /// <see href="http://www.w3.org/2004/06/rei#subjURI"></see></summary>
    let subjURI = Namespaced_IRI.parse _namespace_name "subjURI" |> NamespacedName
    /// <summary>
    /// Shorhand for subject!Literal. Not in RDF 1.0
    /// <see href="http://www.w3.org/2004/06/rei#subjValue"></see></summary>
    let subjValue = Namespaced_IRI.parse _namespace_name "subjValue" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2004/06/rei#subject"></see>
    /// </summary>
    let subject = Namespaced_IRI.parse _namespace_name "subject" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2004/06/rei#universals"></see>
    /// </summary>
    let universals = Namespaced_IRI.parse _namespace_name "universals" |> NamespacedName
    /// <summary>
    /// The URI of the symbol is all that is needed to identify it.
    /// 	This is the name string.
    /// <see href="http://www.w3.org/2004/06/rei#uri"></see></summary>
    let uri = Namespaced_IRI.parse _namespace_name "uri" |> NamespacedName
    /// <summary>
    /// The value of a literal.
    ///
    /// 	Value is the relation between a node (which happens to be a literal, list etc,..) and the value it takes.
    /// <see href="http://www.w3.org/2004/06/rei#value"></see></summary>
    let value = Namespaced_IRI.parse _namespace_name "value" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2004/06/rei#iteral"></see>
    /// </summary>
    let iteral = Namespaced_IRI.parse _namespace_name "iteral" |> NamespacedName
