namespace http.www.w3.org._2000._10.swap.log.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module log =
    let _namespace_iri = Namespace_Iri log |> NamespaceIRI
    /// <summary>
    ///   <para>log:List</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/log#List">http://www.w3.org/2000/10/swap/log#List</seealso>
    let List = Prefixed_Name(log, "List") |> PrefixedName
    /// <summary>
    ///   <para>log:Formula</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/log#Formula">http://www.w3.org/2000/10/swap/log#Formula</seealso>
    let Formula = Prefixed_Name(log, "Formula") |> PrefixedName
    /// <summary>
    ///   <para>log:Truth</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Something which is true: believe it as you would believe this.
    ///
    /// 	Understood natively by cwm in that it will execute rules in a formula
    /// 	declared a Truth within a formula it is already taking rules from.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/log#Truth">http://www.w3.org/2000/10/swap/log#Truth</seealso>
    let Truth = Prefixed_Name(log, "Truth") |> PrefixedName
    /// <summary>
    ///   <para>log:conclusion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>All possible conclusions which can be drawn from a formula.
    ///
    /// The object of this function, a formula, is the set of conclusions which can be
    /// drawn from the subject formula, by successively applying any
    /// rules it contains to the data it contains. This is equivalent to
    /// cwm's "--think" command line function.  It does use built-ins, so
    /// it may for example indirectly invoke other documents, validate
    /// signatures, etc.
    /// </para>
    /// labels<para>conclusion</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/log#conclusion">http://www.w3.org/2000/10/swap/log#conclusion</seealso>
    let conclusion = Prefixed_Name(log, "conclusion") |> PrefixedName
    /// <summary>
    ///   <para>log:dtlit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Takes a list of a string and a URI and creates a datatyped
    ///      literal. For example, { ("2005-03-30T11:00:00" :tz) log:dtlit ?X } =&gt; { ?X a :Answer } .
    ///     will produce "2005-03-30T11:00:00"^^:tz a :Answer .</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/log#dtlit">http://www.w3.org/2000/10/swap/log#dtlit</seealso>
    let dtlit = Prefixed_Name(log, "dtlit") |> PrefixedName
    /// <summary>
    ///   <para>log:n3String</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The subject formula, expressed as N3, gives this string.</para>
    /// labels<para>n3 string</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/log#n3String">http://www.w3.org/2000/10/swap/log#n3String</seealso>
    let n3String = Prefixed_Name(log, "n3String") |> PrefixedName
    /// <summary>
    ///   <para>log:outputString</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The subject is a key and the object is a string,
    /// where the strings are to be output in the order of the keys.
    /// See cwm --strings in cwm --help.
    /// </para>
    /// labels<para>output string</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/log#outputString">http://www.w3.org/2000/10/swap/log#outputString</seealso>
    let outputString = Prefixed_Name(log, "outputString") |> PrefixedName
    /// <summary>
    ///   <para>log:String</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/log#String">http://www.w3.org/2000/10/swap/log#String</seealso>
    let String = Prefixed_Name(log, "String") |> PrefixedName
    /// <summary>
    ///   <para>log:conjunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A function to merge formulae: logical AND.
    ///
    /// The subject is a list of formulae.
    /// The object, which can be generated, is a formula containing a copy
    /// of each of the formulae in the list on the left.
    /// A cwm built-in function.
    /// </para>
    /// labels<para>conjunction</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/log#conjunction">http://www.w3.org/2000/10/swap/log#conjunction</seealso>
    let conjunction = Prefixed_Name(log, "conjunction") |> PrefixedName
    /// <summary>
    ///   <para>log:definitiveDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>	When document D is the definitiveDocument for property P,
    /// any statement X P Y is true iff and only if the semantics of document D
    /// include that statement.
    ///
    /// For example, there may be a definitive document for the zipcode of
    /// airports by airport code, and so on. This is useful to let a reasoner
    /// know that it can extend its query to the given document.
    /// (Cwm will do this if its mode includes "r").
    /// </para>
    /// labels<para>definitive document</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/log#definitiveDocument">http://www.w3.org/2000/10/swap/log#definitiveDocument</seealso>
    let definitiveDocument = Prefixed_Name(log, "definitiveDocument") |> PrefixedName
    /// <summary>
    ///   <para>log:definitiveService</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>	When service S is the definitiveService for property P,
    /// any statement X P Y is true iff and only if a query to S returns
    /// that it is.  The protocol for the service S depends on the scheme.
    /// For mysql protocol, the URI of the service is like
    /// sql://user:password@host.domain/database/.
    ///
    /// For example, there may be a definitive service for the zipcode of
    /// airports by airport code, and so on. This is useful to let a reasoner
    /// know that it can help resolve a query by delegating it to the service
    /// in question.
    /// (Cwm will do this if its mode includes "r").
    /// </para>
    /// labels<para>definitive service</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/log#definitiveService">http://www.w3.org/2000/10/swap/log#definitiveService</seealso>
    let definitiveService = Prefixed_Name(log, "definitiveService") |> PrefixedName
    /// <summary>
    ///   <para>log:equalTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>True if the subject and object are the same RDF node (symbol or literal).
    /// Do not confuse with owl:sameAs.
    /// A cwm built-in logical operator, RDF graph level.
    /// </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/log#equalTo">http://www.w3.org/2000/10/swap/log#equalTo</seealso>
    let equalTo = Prefixed_Name(log, "equalTo") |> PrefixedName
    /// <summary>
    ///   <para>log:includes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The subject formula includes the object formula.
    /// Formula A includes formula B if there exists some substitution
    /// which when applied to B creates a formula B' such that for
    /// every statement in B' is also in A, every variable
    /// universally (or existentially) quantified in B' is quantified in
    /// the same way in A.
    ///
    /// Variable substitution is applied recursively to nested compound terms such as
    /// formulae, lists and sets.
    ///
    /// (Understood natively by cwm when in in the antecedent of a rule.
    /// You can use this to peer inside nested formulae.)</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/log#includes">http://www.w3.org/2000/10/swap/log#includes</seealso>
    let includes = Prefixed_Name(log, "includes") |> PrefixedName
    /// <summary>
    ///   <para>log:implies</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Logical implication.
    /// This is the relation between the antecedent (subject) and
    /// conclusion (object) of a rule.
    /// The application of a rule to a knowledge-base is as follows.
    /// For every substitution which, applied to the antecedent,
    /// gives a formula which is a subset of the knowledge-base,
    /// then the result of applying that same substitution to the
    /// conclusion may be added to the knowledge-base.
    ///
    /// related: See log:conclusion.
    /// (See the CWM manual for command line options to determine how
    /// rules from different sources are applied to and the results
    /// added to various formula.)
    /// </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/log#implies">http://www.w3.org/2000/10/swap/log#implies</seealso>
    let implies = Prefixed_Name(log, "implies") |> PrefixedName
    /// <summary>
    ///   <para>log:notEqualTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Equality in this sense is actually the same URI.
    /// A cwm built-in logical operator.
    /// </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/log#notEqualTo">http://www.w3.org/2000/10/swap/log#notEqualTo</seealso>
    let notEqualTo = Prefixed_Name(log, "notEqualTo") |> PrefixedName
    /// <summary>
    ///   <para>log:notIncludes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The object formula is NOT a subset of subject.
    ///     True iff log:includes is false.
    ///     The converse of log:includes. (Understood natively by cwm.
    ///     The subject formula may contain variables.
    ///     (In cwm, variables must of course end up getting bound
    ///     before the log:include test can be done, or an infinite result set
    ///     would result)
    ///     Related: See includes</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/log#notIncludes">http://www.w3.org/2000/10/swap/log#notIncludes</seealso>
    let notIncludes = Prefixed_Name(log, "notIncludes") |> PrefixedName
    /// <summary>
    ///   <para>log:parsedAsN3</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The subject string, parsed as N3, gives this formula.</para>
    /// labels<para>parses to</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/log#parsedAsN3">http://www.w3.org/2000/10/swap/log#parsedAsN3</seealso>
    let parsedAsN3 = Prefixed_Name(log, "parsedAsN3") |> PrefixedName
    /// <summary>
    ///   <para>log:racine</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>For anything identified by a URI with a fragid, this is the
    /// thing identified by the same URI without a hash or fragid.
    /// For anything else, it is itself.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/log#racine">http://www.w3.org/2000/10/swap/log#racine</seealso>
    let racine = Prefixed_Name(log, "racine") |> PrefixedName
    /// <summary>
    ///   <para>log:rawType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>
    /// This is a low-level language type, one of log:Formula, log:Literal,
    /// log:List, log:Set or log:Other.
    /// Example: log:semanticsOrError returns either a formula or a string,
    /// and you can check which using log:rawType.
    /// </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/log#rawType">http://www.w3.org/2000/10/swap/log#rawType</seealso>
    let rawType = Prefixed_Name(log, "rawType") |> PrefixedName
    /// <summary>
    ///   <para>log:rawUri</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This allows one to look at the actual string of the URI which identifies this,
    /// for anything, even a blank node or a formula. This peeks into the internal
    /// workings of cwm, and so is not normally used. Use log:uri instead.
    /// </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/log#rawUri">http://www.w3.org/2000/10/swap/log#rawUri</seealso>
    let rawUri = Prefixed_Name(log, "rawUri") |> PrefixedName
    /// <summary>
    ///   <para>log:semantics</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The log:semantics of a document is the formula.
    /// achieved by parsing representation of the document.
    ///  For a document in Notation3, log:semantics is the
    /// log:parsedAsN3 of the log:contents of the document.
    /// For a document in RDF/XML, it is parsed according to the
    /// RDF/XML specification to yield an RDF formula
    /// (a subclass of N3 log:Formula).
    ///
    /// [Aside: Philosophers will be distracted here into worrying about the meaning
    /// of meaning. At least we didn't call this function "meaning"!
    /// In as much as N3 is used as an interlingua for interoperability
    /// for different systems, this for an N3 based system is the meaning
    /// expressed by a document.]
    ///
    /// (Cwm knows how to go get a document and parse N3 and RDF/XML
    /// it in order to evaluate this.
    /// Other languages for web documents
    /// may be defined whose N3 semantics are therefore
    /// also calculable, and so they could be added in due course.
    /// See for example GRDDL, RDFa, etc)</para>
    /// labels<para>semantics</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/log#semantics">http://www.w3.org/2000/10/swap/log#semantics</seealso>
    let semantics = Prefixed_Name(log, "semantics") |> PrefixedName
    /// <summary>
    ///   <para>log:uri</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This allows one to look at the actual string of the URI which identifies this.
    ///
    /// (Cwm can get the URI of a resource or get the resource from the URI.)
    /// This is a level breaker, breaking the rule of not looking inside a
    /// URI.   Use (eg with  string:match) to replace RDF's old "aboutEach"
    /// functionality. Use to implement the URI spec and protocol specs, etc.
    /// </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/log#uri">http://www.w3.org/2000/10/swap/log#uri</seealso>
    let uri = Prefixed_Name(log, "uri") |> PrefixedName
    /// <summary>
    ///   <para>log:semanticsOrError</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This connects a document and either the formula it parses to,
    /// or an error message explaining what went wrong with trying. See log:semantics.
    /// (Cwm knows how to go get a document and parse it in order to evaluate this.)
    /// </para>
    /// labels<para>semantics or error message</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/log#semanticsOrError">http://www.w3.org/2000/10/swap/log#semanticsOrError</seealso>
    let semanticsOrError = Prefixed_Name(log, "semanticsOrError") |> PrefixedName
    /// <summary>
    ///   <para>log:Chaff</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Any statement mentioning anything in this class
    /// is considered boring and purged by the cwm --purge option.
    /// This is a convenience, and does not have any value when published as a
    /// general fact on the web.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/log#Chaff">http://www.w3.org/2000/10/swap/log#Chaff</seealso>
    let Chaff = Prefixed_Name(log, "Chaff") |> PrefixedName
    /// <summary>
    ///   <para>log:N3Document</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A document which, which parsed as Notation3
    /// as defined in general by http://www.w3.org/DesignIssues/Notation3.html
    /// and this schema, conveys the intent of the author by the semantics defined
    /// on those specifications, and the semantics defined by the specifications
    /// of any other identifiers used in the document.
    /// </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/log#N3Document">http://www.w3.org/2000/10/swap/log#N3Document</seealso>
    let N3Document = Prefixed_Name(log, "N3Document") |> PrefixedName
    /// <summary>
    ///   <para>log:Other</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/log#Other">http://www.w3.org/2000/10/swap/log#Other</seealso>
    let Other = Prefixed_Name(log, "Other") |> PrefixedName
    /// <summary>
    ///   <para>log:content</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This connects a document and a string that represents it.
    /// (Cwm knows how to go get a document in order to evaluate this.)
    /// Note that the content-type of the information is not given and
    /// so must be known or guessed.</para>
    /// labels<para>content</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/log#content">http://www.w3.org/2000/10/swap/log#content</seealso>
    let content = Prefixed_Name(log, "content") |> PrefixedName
