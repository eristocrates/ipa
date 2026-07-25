namespace http.www.w3.org._2004._06.rei.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rei =
    let _namespace_iri = Namespace_Iri rei |> NamespaceIRI
    /// <summary>
    ///   <para>rei:Literal</para>
    /// </summary>
    /// <remarks>
    ///   <para>Literals are identified by their string value, their
    /// 	datatype (or absence thereof) and their language code
    /// 	(or absencethereof). As we are modeling RDF in RDF,
    /// 	we can just use a literal the value of a literal.
    /// 	</para>
    /// labels<para>Literal</para></remarks>
    /// <seealso href="http://www.w3.org/2004/06/rei#Literal">http://www.w3.org/2004/06/rei#Literal</seealso>
    let Literal = Prefixed_Name(rei, "Literal") |> PrefixedName
    /// <summary>
    ///   <para>rei:iteral</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2004/06/rei#iteral">http://www.w3.org/2004/06/rei#iteral</seealso>
    let iteral = Prefixed_Name(rei, "iteral") |> PrefixedName
    /// <summary>
    ///   <para>rei:Term</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>term</para></remarks>
    /// <seealso href="http://www.w3.org/2004/06/rei#Term">http://www.w3.org/2004/06/rei#Term</seealso>
    let Term = Prefixed_Name(rei, "Term") |> PrefixedName
    /// <summary>
    ///   <para>rei:RDFGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>A formula which meets the constaints of being
    /// 	an RDF Graph as per the RDF spec. No universally qualified variables,
    /// 	no nested formulae, no literals as subject, etc.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2004/06/rei#RDFGraph">http://www.w3.org/2004/06/rei#RDFGraph</seealso>
    let RDFGraph = Prefixed_Name(rei, "RDFGraph") |> PrefixedName
    /// <summary>
    ///   <para>rei:existentials</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>for all</para></remarks>
    /// <seealso href="http://www.w3.org/2004/06/rei#existentials">http://www.w3.org/2004/06/rei#existentials</seealso>
    let existentials = Prefixed_Name(rei, "existentials") |> PrefixedName
    /// <summary>
    ///   <para>rei:predURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Shorhand for predicate!uri</para>
    /// labels<para>predicate URI</para></remarks>
    /// <seealso href="http://www.w3.org/2004/06/rei#predURI">http://www.w3.org/2004/06/rei#predURI</seealso>
    let predURI = Prefixed_Name(rei, "predURI") |> PrefixedName
    /// <summary>
    ///   <para>rei:predicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>predicate</para></remarks>
    /// <seealso href="http://www.w3.org/2004/06/rei#predicate">http://www.w3.org/2004/06/rei#predicate</seealso>
    let predicate = Prefixed_Name(rei, "predicate") |> PrefixedName
    /// <summary>
    ///   <para>rei:objURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Shorhand for object!uri</para>
    /// labels<para>object URI</para></remarks>
    /// <seealso href="http://www.w3.org/2004/06/rei#objURI">http://www.w3.org/2004/06/rei#objURI</seealso>
    let objURI = Prefixed_Name(rei, "objURI") |> PrefixedName
    /// <summary>
    ///   <para>rei:predValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Shorhand for predicate!Literal. Not RDF 1.0.</para>
    /// labels<para>predicate value</para></remarks>
    /// <seealso href="http://www.w3.org/2004/06/rei#predValue">http://www.w3.org/2004/06/rei#predValue</seealso>
    let predValue = Prefixed_Name(rei, "predValue") |> PrefixedName
    /// <summary>
    ///   <para>rei:statements</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The order of the statements is irrelevant.
    /// 	They are given as a rdf:List because rdf:Lists exist,
    /// 	and we want a closed set.
    /// 	</para>
    /// labels<para>statements</para></remarks>
    /// <seealso href="http://www.w3.org/2004/06/rei#statements">http://www.w3.org/2004/06/rei#statements</seealso>
    let statements = Prefixed_Name(rei, "statements") |> PrefixedName
    /// <summary>
    ///   <para>rei:object</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>object</para></remarks>
    /// <seealso href="http://www.w3.org/2004/06/rei#object">http://www.w3.org/2004/06/rei#object</seealso>
    let object = Prefixed_Name(rei, "object") |> PrefixedName
    /// <summary>
    ///   <para>rei:subjURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Shorhand for subject!uri</para>
    /// labels<para>subject URI</para></remarks>
    /// <seealso href="http://www.w3.org/2004/06/rei#subjURI">http://www.w3.org/2004/06/rei#subjURI</seealso>
    let subjURI = Prefixed_Name(rei, "subjURI") |> PrefixedName
    /// <summary>
    ///   <para>rei:subjValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Shorhand for subject!Literal. Not in RDF 1.0</para>
    /// labels<para>subject value</para></remarks>
    /// <seealso href="http://www.w3.org/2004/06/rei#subjValue">http://www.w3.org/2004/06/rei#subjValue</seealso>
    let subjValue = Prefixed_Name(rei, "subjValue") |> PrefixedName
    /// <summary>
    ///   <para>rei:subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>subject</para></remarks>
    /// <seealso href="http://www.w3.org/2004/06/rei#subject">http://www.w3.org/2004/06/rei#subject</seealso>
    let subject = Prefixed_Name(rei, "subject") |> PrefixedName
    /// <summary>
    ///   <para>rei:uri</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The URI of the symbol is all that is needed to identify it.
    /// 	This is the name string.</para>
    /// labels<para>symbol URI, not arbitray</para></remarks>
    /// <seealso href="http://www.w3.org/2004/06/rei#uri">http://www.w3.org/2004/06/rei#uri</seealso>
    let uri = Prefixed_Name(rei, "uri") |> PrefixedName
    /// <summary>
    ///   <para>rei:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The value of a literal.
    ///
    /// 	Value is the relation between a node (which happens to be a literal, list etc,..) and the value it takes.</para>
    /// labels<para>Value</para></remarks>
    /// <seealso href="http://www.w3.org/2004/06/rei#value">http://www.w3.org/2004/06/rei#value</seealso>
    let value = Prefixed_Name(rei, "value") |> PrefixedName
    /// <summary>
    ///   <para>rei:universals</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>for all</para></remarks>
    /// <seealso href="http://www.w3.org/2004/06/rei#universals">http://www.w3.org/2004/06/rei#universals</seealso>
    let universals = Prefixed_Name(rei, "universals") |> PrefixedName
    /// <summary>
    ///   <para>rei:BNode</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>blank node</para></remarks>
    /// <seealso href="http://www.w3.org/2004/06/rei#BNode">http://www.w3.org/2004/06/rei#BNode</seealso>
    let BNode = Prefixed_Name(rei, "BNode") |> PrefixedName
    /// <summary>
    ///   <para>rei:Formula</para>
    /// </summary>
    /// <remarks>
    ///   <para>A formula is identified by an unordered set of statements,
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
    /// 	</para>
    /// labels<para>Formula</para></remarks>
    /// <seealso href="http://www.w3.org/2004/06/rei#Formula">http://www.w3.org/2004/06/rei#Formula</seealso>
    let Formula = Prefixed_Name(rei, "Formula") |> PrefixedName
    /// <summary>
    ///   <para>rei:RDFTerm</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2004/06/rei#RDFTerm">http://www.w3.org/2004/06/rei#RDFTerm</seealso>
    let RDFTerm = Prefixed_Name(rei, "RDFTerm") |> PrefixedName
    /// <summary>
    ///   <para>rei:Statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A statement is the unit of information.
    /// 	It expresses a binary relation.
    /// 	Its significance is determined by the realtion,
    /// 	generally referred to as its predicate.
    /// 	</para>
    /// labels<para>Statement</para></remarks>
    /// <seealso href="http://www.w3.org/2004/06/rei#Statement">http://www.w3.org/2004/06/rei#Statement</seealso>
    let Statement = Prefixed_Name(rei, "Statement") |> PrefixedName
    /// <summary>
    ///   <para>rei:Symbol</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>RDF symbol, identified by a URI</para></remarks>
    /// <seealso href="http://www.w3.org/2004/06/rei#Symbol">http://www.w3.org/2004/06/rei#Symbol</seealso>
    let Symbol = Prefixed_Name(rei, "Symbol") |> PrefixedName
    /// <summary>
    ///   <para>rei:String</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2004/06/rei#String">http://www.w3.org/2004/06/rei#String</seealso>
    let String = Prefixed_Name(rei, "String") |> PrefixedName
    /// <summary>
    ///   <para>rei:objValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Shorhand for object!Literal</para>
    /// labels<para>object value</para></remarks>
    /// <seealso href="http://www.w3.org/2004/06/rei#objValue">http://www.w3.org/2004/06/rei#objValue</seealso>
    let objValue = Prefixed_Name(rei, "objValue") |> PrefixedName
