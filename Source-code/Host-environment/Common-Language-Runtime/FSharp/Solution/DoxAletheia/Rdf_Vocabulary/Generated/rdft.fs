namespace http.www.w3.org.ns.rdftest.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rdft =
    let _namespace_iri = Namespace_Iri rdft |> NamespaceIRI
    /// <summary>
    ///   <para>rdft:Approval</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The superclass of all test approval statuses."</para>
    /// labels<para>"Approval"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/rdftest#Approval">http://www.w3.org/ns/rdftest#Approval</seealso>
    let Approval = Prefixed_Name(rdft, "Approval") |> PrefixedName
    /// <summary>
    ///   <para>rdft:Approved</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Indicates that a test is approved."</para>
    /// labels<para>"Approved"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/rdftest#Approved">http://www.w3.org/ns/rdftest#Approved</seealso>
    let Approved = Prefixed_Name(rdft, "Approved") |> PrefixedName
    /// <summary>
    ///   <para>rdft:Proposed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Indicates that a test is proposed, but not approved."</para>
    /// labels<para>"Proposed"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/rdftest#Proposed">http://www.w3.org/ns/rdftest#Proposed</seealso>
    let Proposed = Prefixed_Name(rdft, "Proposed") |> PrefixedName
    /// <summary>
    ///   <para>rdft:Rejected</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Indicates that a test is not approved."</para>
    /// labels<para>"Rejected"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/rdftest#Rejected">http://www.w3.org/ns/rdftest#Rejected</seealso>
    let Rejected = Prefixed_Name(rdft, "Rejected") |> PrefixedName
    /// <summary>
    ///   <para>rdft:Test</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Superclass of all RDF Tests."</para>
    /// labels<para>"Test"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/rdftest#Test">http://www.w3.org/ns/rdftest#Test</seealso>
    let Test = Prefixed_Name(rdft, "Test") |> PrefixedName
    /// <summary>
    ///   <para>rdft:TestEval</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Superclass of all RDF Evaluation Tests."</para>
    /// labels<para>"Test Evaluation"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/rdftest#TestEval">http://www.w3.org/ns/rdftest#TestEval</seealso>
    let TestEval = Prefixed_Name(rdft, "TestEval") |> PrefixedName

    /// <summary>
    ///   <para>rdft:TestNQuadsNegativeSyntax</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A negative N-Quads syntax test."</para>
    /// labels<para>"N-Quads Negative Syntax"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/rdftest#TestNQuadsNegativeSyntax">http://www.w3.org/ns/rdftest#TestNQuadsNegativeSyntax</seealso>
    let TestNQuadsNegativeSyntax =
        Prefixed_Name(rdft, "TestNQuadsNegativeSyntax") |> PrefixedName

    /// <summary>
    ///   <para>rdft:TestNQuadsPositiveSyntax</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A positive N-Quads syntax test."</para>
    /// labels<para>"N-Quads Positive Syntax"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/rdftest#TestNQuadsPositiveSyntax">http://www.w3.org/ns/rdftest#TestNQuadsPositiveSyntax</seealso>
    let TestNQuadsPositiveSyntax =
        Prefixed_Name(rdft, "TestNQuadsPositiveSyntax") |> PrefixedName

    /// <summary>
    ///   <para>rdft:TestNTriplesNegativeSyntax</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A negative N-Triples syntax test."</para>
    /// labels<para>"N-Triples Negative Syntax"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/rdftest#TestNTriplesNegativeSyntax">http://www.w3.org/ns/rdftest#TestNTriplesNegativeSyntax</seealso>
    let TestNTriplesNegativeSyntax =
        Prefixed_Name(rdft, "TestNTriplesNegativeSyntax") |> PrefixedName

    /// <summary>
    ///   <para>rdft:TestNTriplesPositiveSyntax</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A positive N-Triples syntax test."</para>
    /// labels<para>"N-Triples Positive Syntax"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/rdftest#TestNTriplesPositiveSyntax">http://www.w3.org/ns/rdftest#TestNTriplesPositiveSyntax</seealso>
    let TestNTriplesPositiveSyntax =
        Prefixed_Name(rdft, "TestNTriplesPositiveSyntax") |> PrefixedName

    /// <summary>
    ///   <para>rdft:TestSyntax</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Superclass of all RDF Syntax Tests."</para>
    /// labels<para>"Test Syntax"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/rdftest#TestSyntax">http://www.w3.org/ns/rdftest#TestSyntax</seealso>
    let TestSyntax = Prefixed_Name(rdft, "TestSyntax") |> PrefixedName

    /// <summary>
    ///   <para>rdft:TestTriGNegativeSyntax</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A negative TriG syntax test."</para>
    /// labels<para>"TriG Negative Syntax"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/rdftest#TestTriGNegativeSyntax">http://www.w3.org/ns/rdftest#TestTriGNegativeSyntax</seealso>
    let TestTriGNegativeSyntax =
        Prefixed_Name(rdft, "TestTriGNegativeSyntax") |> PrefixedName

    /// <summary>
    ///   <para>rdft:TestTriGPositiveSyntax</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A positive TriG syntax test."</para>
    /// labels<para>"TriG Positive Syntax"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/rdftest#TestTriGPositiveSyntax">http://www.w3.org/ns/rdftest#TestTriGPositiveSyntax</seealso>
    let TestTriGPositiveSyntax =
        Prefixed_Name(rdft, "TestTriGPositiveSyntax") |> PrefixedName

    /// <summary>
    ///   <para>rdft:TestTrigEval</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A positive TriG evaluation test."</para>
    /// labels<para>"TriG Positive Evaluation"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/rdftest#TestTrigEval">http://www.w3.org/ns/rdftest#TestTrigEval</seealso>
    let TestTrigEval = Prefixed_Name(rdft, "TestTrigEval") |> PrefixedName

    /// <summary>
    ///   <para>rdft:TestTrigNegativeEval</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A negative TriG evaluation test."</para>
    /// labels<para>"TriG Negative Evaluation"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/rdftest#TestTrigNegativeEval">http://www.w3.org/ns/rdftest#TestTrigNegativeEval</seealso>
    let TestTrigNegativeEval =
        Prefixed_Name(rdft, "TestTrigNegativeEval") |> PrefixedName

    /// <summary>
    ///   <para>rdft:TestTurtleEval</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A positive Turtle evaluation test."</para>
    /// labels<para>"Turtle Positive Evaluation"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/rdftest#TestTurtleEval">http://www.w3.org/ns/rdftest#TestTurtleEval</seealso>
    let TestTurtleEval = Prefixed_Name(rdft, "TestTurtleEval") |> PrefixedName

    /// <summary>
    ///   <para>rdft:TestTurtleNegativeEval</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A negative Turtle evaluation test."</para>
    /// labels<para>"Turtle Negative Evaluation"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/rdftest#TestTurtleNegativeEval">http://www.w3.org/ns/rdftest#TestTurtleNegativeEval</seealso>
    let TestTurtleNegativeEval =
        Prefixed_Name(rdft, "TestTurtleNegativeEval") |> PrefixedName

    /// <summary>
    ///   <para>rdft:TestTurtleNegativeSyntax</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A negative Turtle syntax test."</para>
    /// labels<para>"Turtle Negative Syntax"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/rdftest#TestTurtleNegativeSyntax">http://www.w3.org/ns/rdftest#TestTurtleNegativeSyntax</seealso>
    let TestTurtleNegativeSyntax =
        Prefixed_Name(rdft, "TestTurtleNegativeSyntax") |> PrefixedName

    /// <summary>
    ///   <para>rdft:TestTurtlePositiveSyntax</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A positive Turtle syntax test."</para>
    /// labels<para>"Turtle Positive Syntax"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/rdftest#TestTurtlePositiveSyntax">http://www.w3.org/ns/rdftest#TestTurtlePositiveSyntax</seealso>
    let TestTurtlePositiveSyntax =
        Prefixed_Name(rdft, "TestTurtlePositiveSyntax") |> PrefixedName

    /// <summary>
    ///   <para>rdft:TestXMLNegativeSyntax</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A negative RDF/XML syntax test."</para>
    /// labels<para>"RDF/XML Negative Syntax"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/rdftest#TestXMLNegativeSyntax">http://www.w3.org/ns/rdftest#TestXMLNegativeSyntax</seealso>
    let TestXMLNegativeSyntax =
        Prefixed_Name(rdft, "TestXMLNegativeSyntax") |> PrefixedName

    /// <summary>
    ///   <para>rdft:XMLEval</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A positive RDF/XML evaluation test."</para>
    /// labels<para>"RDF/XML Evaluation"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/rdftest#XMLEval">http://www.w3.org/ns/rdftest#XMLEval</seealso>
    let XMLEval = Prefixed_Name(rdft, "XMLEval") |> PrefixedName
    /// <summary>
    ///   <para>rdft:approval</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Approval status of a test."</para>
    /// labels<para>"approval"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/rdftest#approval">http://www.w3.org/ns/rdftest#approval</seealso>
    let approval = Prefixed_Name(rdft, "approval") |> PrefixedName
