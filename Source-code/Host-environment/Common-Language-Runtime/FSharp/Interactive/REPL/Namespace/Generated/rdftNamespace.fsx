#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module rdft =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/rdftest#" "rdft"
    /// <summary>
    ///   <para>rdfs:label : Approval</para>
    ///   <para>rdfs:comment : The superclass of all test approval statuses.</para>
    ///   <a href="http://www.w3.org/ns/rdftest#Approval">rdft:Approval</a>
    /// </summary>
    let Approval = _prefixId.prefix "Approval"
    /// <summary>
    ///   <para>rdfs:label : Approved</para>
    ///   <para>rdfs:comment : Indicates that a test is approved.</para>
    ///   <a href="http://www.w3.org/ns/rdftest#Approved">rdft:Approved</a>
    /// </summary>
    let Approved = _prefixId.prefix "Approved"
    /// <summary>
    ///   <para>rdfs:label : Proposed</para>
    ///   <para>rdfs:comment : Indicates that a test is proposed, but not approved.</para>
    ///   <a href="http://www.w3.org/ns/rdftest#Proposed">rdft:Proposed</a>
    /// </summary>
    let Proposed = _prefixId.prefix "Proposed"
    /// <summary>
    ///   <para>rdfs:label : Rejected</para>
    ///   <para>rdfs:comment : Indicates that a test is not approved.</para>
    ///   <a href="http://www.w3.org/ns/rdftest#Rejected">rdft:Rejected</a>
    /// </summary>
    let Rejected = _prefixId.prefix "Rejected"
    /// <summary>
    ///   <para>rdfs:label : Test</para>
    ///   <para>rdfs:comment : Superclass of all RDF Tests.</para>
    ///   <a href="http://www.w3.org/ns/rdftest#Test">rdft:Test</a>
    /// </summary>
    let Test = _prefixId.prefix "Test"
    /// <summary>
    ///   <para>rdfs:label : Test Evaluation</para>
    ///   <para>rdfs:comment : Superclass of all RDF Evaluation Tests.</para>
    ///   <a href="http://www.w3.org/ns/rdftest#TestEval">rdft:TestEval</a>
    /// </summary>
    let TestEval = _prefixId.prefix "TestEval"
    /// <summary>
    ///   <para>rdfs:label : N-Quads Negative Syntax</para>
    ///   <para>rdfs:comment : A negative N-Quads syntax test.</para>
    ///   <a href="http://www.w3.org/ns/rdftest#TestNQuadsNegativeSyntax">rdft:TestNQuadsNegativeSyntax</a>
    /// </summary>
    let TestNQuadsNegativeSyntax = _prefixId.prefix "TestNQuadsNegativeSyntax"
    /// <summary>
    ///   <para>rdfs:label : N-Quads Positive Syntax</para>
    ///   <para>rdfs:comment : A positive N-Quads syntax test.</para>
    ///   <a href="http://www.w3.org/ns/rdftest#TestNQuadsPositiveSyntax">rdft:TestNQuadsPositiveSyntax</a>
    /// </summary>
    let TestNQuadsPositiveSyntax = _prefixId.prefix "TestNQuadsPositiveSyntax"
    /// <summary>
    ///   <para>rdfs:label : N-Triples Negative Syntax</para>
    ///   <para>rdfs:comment : A negative N-Triples syntax test.</para>
    ///   <a href="http://www.w3.org/ns/rdftest#TestNTriplesNegativeSyntax">rdft:TestNTriplesNegativeSyntax</a>
    /// </summary>
    let TestNTriplesNegativeSyntax = _prefixId.prefix "TestNTriplesNegativeSyntax"
    /// <summary>
    ///   <para>rdfs:label : N-Triples Positive Syntax</para>
    ///   <para>rdfs:comment : A positive N-Triples syntax test.</para>
    ///   <a href="http://www.w3.org/ns/rdftest#TestNTriplesPositiveSyntax">rdft:TestNTriplesPositiveSyntax</a>
    /// </summary>
    let TestNTriplesPositiveSyntax = _prefixId.prefix "TestNTriplesPositiveSyntax"
    /// <summary>
    ///   <para>rdfs:label : Test Syntax</para>
    ///   <para>rdfs:comment : Superclass of all RDF Syntax Tests.</para>
    ///   <a href="http://www.w3.org/ns/rdftest#TestSyntax">rdft:TestSyntax</a>
    /// </summary>
    let TestSyntax = _prefixId.prefix "TestSyntax"
    /// <summary>
    ///   <para>rdfs:label : TriG Negative Syntax</para>
    ///   <para>rdfs:comment : A negative TriG syntax test.</para>
    ///   <a href="http://www.w3.org/ns/rdftest#TestTriGNegativeSyntax">rdft:TestTriGNegativeSyntax</a>
    /// </summary>
    let TestTriGNegativeSyntax = _prefixId.prefix "TestTriGNegativeSyntax"
    /// <summary>
    ///   <para>rdfs:label : TriG Positive Syntax</para>
    ///   <para>rdfs:comment : A positive TriG syntax test.</para>
    ///   <a href="http://www.w3.org/ns/rdftest#TestTriGPositiveSyntax">rdft:TestTriGPositiveSyntax</a>
    /// </summary>
    let TestTriGPositiveSyntax = _prefixId.prefix "TestTriGPositiveSyntax"
    /// <summary>
    ///   <para>rdfs:label : TriG Positive Evaluation</para>
    ///   <para>rdfs:comment : A positive TriG evaluation test.</para>
    ///   <a href="http://www.w3.org/ns/rdftest#TestTrigEval">rdft:TestTrigEval</a>
    /// </summary>
    let TestTrigEval = _prefixId.prefix "TestTrigEval"
    /// <summary>
    ///   <para>rdfs:label : TriG Negative Evaluation</para>
    ///   <para>rdfs:comment : A negative TriG evaluation test.</para>
    ///   <a href="http://www.w3.org/ns/rdftest#TestTrigNegativeEval">rdft:TestTrigNegativeEval</a>
    /// </summary>
    let TestTrigNegativeEval = _prefixId.prefix "TestTrigNegativeEval"
    /// <summary>
    ///   <para>rdfs:label : Turtle Positive Evaluation</para>
    ///   <para>rdfs:comment : A positive Turtle evaluation test.</para>
    ///   <a href="http://www.w3.org/ns/rdftest#TestTurtleEval">rdft:TestTurtleEval</a>
    /// </summary>
    let TestTurtleEval = _prefixId.prefix "TestTurtleEval"
    /// <summary>
    ///   <para>rdfs:label : Turtle Negative Evaluation</para>
    ///   <para>rdfs:comment : A negative Turtle evaluation test.</para>
    ///   <a href="http://www.w3.org/ns/rdftest#TestTurtleNegativeEval">rdft:TestTurtleNegativeEval</a>
    /// </summary>
    let TestTurtleNegativeEval = _prefixId.prefix "TestTurtleNegativeEval"
    /// <summary>
    ///   <para>rdfs:label : Turtle Negative Syntax</para>
    ///   <para>rdfs:comment : A negative Turtle syntax test.</para>
    ///   <a href="http://www.w3.org/ns/rdftest#TestTurtleNegativeSyntax">rdft:TestTurtleNegativeSyntax</a>
    /// </summary>
    let TestTurtleNegativeSyntax = _prefixId.prefix "TestTurtleNegativeSyntax"
    /// <summary>
    ///   <para>rdfs:label : Turtle Positive Syntax</para>
    ///   <para>rdfs:comment : A positive Turtle syntax test.</para>
    ///   <a href="http://www.w3.org/ns/rdftest#TestTurtlePositiveSyntax">rdft:TestTurtlePositiveSyntax</a>
    /// </summary>
    let TestTurtlePositiveSyntax = _prefixId.prefix "TestTurtlePositiveSyntax"
    /// <summary>
    ///   <para>rdfs:label : RDF/XML Negative Syntax</para>
    ///   <para>rdfs:comment : A negative RDF/XML syntax test.</para>
    ///   <a href="http://www.w3.org/ns/rdftest#TestXMLNegativeSyntax">rdft:TestXMLNegativeSyntax</a>
    /// </summary>
    let TestXMLNegativeSyntax = _prefixId.prefix "TestXMLNegativeSyntax"
    /// <summary>
    ///   <para>rdfs:label : RDF/XML Evaluation</para>
    ///   <para>rdfs:comment : A positive RDF/XML evaluation test.</para>
    ///   <a href="http://www.w3.org/ns/rdftest#XMLEval">rdft:XMLEval</a>
    /// </summary>
    let XMLEval = _prefixId.prefix "XMLEval"
    /// <summary>
    ///   <para>rdfs:label : approval</para>
    ///   <para>rdfs:comment : Approval status of a test.</para>
    ///   <a href="http://www.w3.org/ns/rdftest#approval">rdft:approval</a>
    /// </summary>
    let approval = _prefixId.prefix "approval"
