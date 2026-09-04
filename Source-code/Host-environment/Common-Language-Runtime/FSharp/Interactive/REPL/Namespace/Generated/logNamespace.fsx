#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module log =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.w3.org/2000/10/swap/log#" "log"

    /// <summary>
    ///   <para>rdfs:comment : Any statement mentioning anything in this class
    /// is considered boring and purged by the cwm --purge option.
    /// This is a convenience, and does not have any value when published as a
    /// general fact on the web.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/log#Chaff">log:Chaff</a>
    /// </summary>
    let Chaff = _prefixId.prefix "Chaff"
    let Formula = _prefixId.prefix "Formula"
    let List = _prefixId.prefix "List"
    /// <summary>
    ///   <para>rdfs:comment : A document which, which parsed as Notation3
    /// as defined in general by http://www.w3.org/DesignIssues/Notation3.html
    /// and this schema, conveys the intent of the author by the semantics defined
    /// on those specifications, and the semantics defined by the specifications
    /// of any other identifiers used in the document.
    /// ^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/log#N3Document">log:N3Document</a>
    /// </summary>
    let N3Document = _prefixId.prefix "N3Document"
    let Other = _prefixId.prefix "Other"
    let String = _prefixId.prefix "String"
    /// <summary>
    ///   <para>rdfs:comment : Something which is true: believe it as you would believe this.
    ///
    /// 	Understood natively by cwm in that it will execute rules in a formula
    /// 	declared a Truth within a formula it is already taking rules from.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/log#Truth">log:Truth</a>
    /// </summary>
    let Truth = _prefixId.prefix "Truth"
    /// <summary>
    ///   <para>rdfs:label : conclusion^^xsd:string</para>
    ///   <para>rdfs:comment : All possible conclusions which can be drawn from a formula.
    ///
    /// The object of this function, a formula, is the set of conclusions which can be
    /// drawn from the subject formula, by successively applying any
    /// rules it contains to the data it contains. This is equivalent to
    /// cwm's "--think" command line function.  It does use built-ins, so
    /// it may for example indirectly invoke other documents, validate
    /// signatures, etc.
    /// ^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/log#conclusion">log:conclusion</a>
    /// </summary>
    let conclusion = _prefixId.prefix "conclusion"
    /// <summary>
    ///   <para>rdfs:label : conjunction^^xsd:string</para>
    ///   <para>rdfs:comment : "A function to merge formulae: logical AND.
    ///
    /// The subject is a list of formulae.
    /// The object, which can be generated, is a formula containing a copy
    /// of each of the formulae in the list on the left.
    /// A cwm built-in function.
    /// ^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/log#conjunction">log:conjunction</a>
    /// </summary>
    let conjunction = _prefixId.prefix "conjunction"
    /// <summary>
    ///   <para>rdfs:label : content^^xsd:string</para>
    ///   <para>rdfs:comment : This connects a document and a string that represents it.
    /// (Cwm knows how to go get a document in order to evaluate this.)
    /// Note that the content-type of the information is not given and
    /// so must be known or guessed.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/log#content">log:content</a>
    /// </summary>
    let content = _prefixId.prefix "content"
    /// <summary>
    ///   <para>rdfs:label : definitive document^^xsd:string</para>
    ///   <para>rdfs:comment : 	When document D is the definitiveDocument for property P,
    /// any statement X P Y is true iff and only if the semantics of document D
    /// include that statement.
    ///
    /// For example, there may be a definitive document for the zipcode of
    /// airports by airport code, and so on. This is useful to let a reasoner
    /// know that it can extend its query to the given document.
    /// (Cwm will do this if its mode includes "r").
    /// ^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/log#definitiveDocument">log:definitiveDocument</a>
    /// </summary>
    let definitiveDocument = _prefixId.prefix "definitiveDocument"
    /// <summary>
    ///   <para>rdfs:label : definitive service^^xsd:string</para>
    ///   <para>rdfs:comment : 	When service S is the definitiveService for property P,
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
    /// ^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/log#definitiveService">log:definitiveService</a>
    /// </summary>
    let definitiveService = _prefixId.prefix "definitiveService"
    /// <summary>
    ///   <para>rdfs:comment : Takes a list of a string and a URI and creates a datatyped
    ///      literal. For example, { ("2005-03-30T11:00:00" :tz) log:dtlit ?X } =&gt; { ?X a :Answer } .
    ///     will produce "2005-03-30T11:00:00"^^:tz a :Answer .^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/log#dtlit">log:dtlit</a>
    /// </summary>
    let dtlit = _prefixId.prefix "dtlit"
    /// <summary>
    ///   <para>rdfs:comment : True if the subject and object are the same RDF node (symbol or literal).
    /// Do not confuse with owl:sameAs.
    /// A cwm built-in logical operator, RDF graph level.
    /// ^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/log#equalTo">log:equalTo</a>
    /// </summary>
    let equalTo = _prefixId.prefix "equalTo"
    /// <summary>
    ///   <para>rdfs:comment : Logical implication.
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
    /// ^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/log#implies">log:implies</a>
    /// </summary>
    let implies = _prefixId.prefix "implies"
    /// <summary>
    ///   <para>rdfs:comment : The subject formula includes the object formula.
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
    /// You can use this to peer inside nested formulae.)^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/log#includes">log:includes</a>
    /// </summary>
    let includes = _prefixId.prefix "includes"
    /// <summary>
    ///   <para>rdfs:label : n3 string^^xsd:string</para>
    ///   <para>rdfs:comment : The subject formula, expressed as N3, gives this string.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/log#n3String">log:n3String</a>
    /// </summary>
    let n3String = _prefixId.prefix "n3String"
    /// <summary>
    ///   <para>rdfs:comment : Equality in this sense is actually the same URI.
    /// A cwm built-in logical operator.
    /// ^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/log#notEqualTo">log:notEqualTo</a>
    /// </summary>
    let notEqualTo = _prefixId.prefix "notEqualTo"
    /// <summary>
    ///   <para>rdfs:comment : The object formula is NOT a subset of subject.
    ///     True iff log:includes is false.
    ///     The converse of log:includes. (Understood natively by cwm.
    ///     The subject formula may contain variables.
    ///     (In cwm, variables must of course end up getting bound
    ///     before the log:include test can be done, or an infinite result set
    ///     would result)
    ///     Related: See includes^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/log#notIncludes">log:notIncludes</a>
    /// </summary>
    let notIncludes = _prefixId.prefix "notIncludes"
    /// <summary>
    ///   <para>rdfs:label : output string^^xsd:string</para>
    ///   <para>rdfs:comment : The subject is a key and the object is a string,
    /// where the strings are to be output in the order of the keys.
    /// See cwm --strings in cwm --help.
    /// ^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/log#outputString">log:outputString</a>
    /// </summary>
    let outputString = _prefixId.prefix "outputString"
    /// <summary>
    ///   <para>rdfs:label : parses to^^xsd:string</para>
    ///   <para>rdfs:comment : The subject string, parsed as N3, gives this formula.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/log#parsedAsN3">log:parsedAsN3</a>
    /// </summary>
    let parsedAsN3 = _prefixId.prefix "parsedAsN3"
    /// <summary>
    ///   <para>rdfs:comment : For anything identified by a URI with a fragid, this is the
    /// thing identified by the same URI without a hash or fragid.
    /// For anything else, it is itself.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/log#racine">log:racine</a>
    /// </summary>
    let racine = _prefixId.prefix "racine"
    /// <summary>
    ///   <para>rdfs:comment :
    /// This is a low-level language type, one of log:Formula, log:Literal,
    /// log:List, log:Set or log:Other.
    /// Example: log:semanticsOrError returns either a formula or a string,
    /// and you can check which using log:rawType.
    /// ^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/log#rawType">log:rawType</a>
    /// </summary>
    let rawType = _prefixId.prefix "rawType"
    /// <summary>
    ///   <para>rdfs:comment : This allows one to look at the actual string of the URI which identifies this,
    /// for anything, even a blank node or a formula. This peeks into the internal
    /// workings of cwm, and so is not normally used. Use log:uri instead.
    /// ^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/log#rawUri">log:rawUri</a>
    /// </summary>
    let rawUri = _prefixId.prefix "rawUri"
    /// <summary>
    ///   <para>rdfs:label : semantics^^xsd:string</para>
    ///   <para>rdfs:comment : The log:semantics of a document is the formula.
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
    /// See for example GRDDL, RDFa, etc)^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/log#semantics">log:semantics</a>
    /// </summary>
    let semantics = _prefixId.prefix "semantics"
    /// <summary>
    ///   <para>rdfs:label : semantics or error message^^xsd:string</para>
    ///   <para>rdfs:comment : This connects a document and either the formula it parses to,
    /// or an error message explaining what went wrong with trying. See log:semantics.
    /// (Cwm knows how to go get a document and parse it in order to evaluate this.)
    /// ^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/log#semanticsOrError">log:semanticsOrError</a>
    /// </summary>
    let semanticsOrError = _prefixId.prefix "semanticsOrError"
    /// <summary>
    ///   <para>rdfs:comment : This allows one to look at the actual string of the URI which identifies this.
    ///
    /// (Cwm can get the URI of a resource or get the resource from the URI.)
    /// This is a level breaker, breaking the rule of not looking inside a
    /// URI.   Use (eg with  string:match) to replace RDF's old "aboutEach"
    /// functionality. Use to implement the URI spec and protocol specs, etc.
    /// ^^xsd:string</para>
    ///   <a href="http://www.w3.org/2000/10/swap/log#uri">log:uri</a>
    /// </summary>
    let uri = _prefixId.prefix "uri"
