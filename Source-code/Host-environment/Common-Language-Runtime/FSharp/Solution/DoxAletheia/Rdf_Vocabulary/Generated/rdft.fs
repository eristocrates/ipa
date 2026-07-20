namespace http.www.w3.org.ns.rdftest.hash

open DoxAletheia

module rdft =
    let _namespace_name = "http://www.w3.org/ns/rdftest#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The superclass of all test approval statuses.
    /// <see href="http://www.w3.org/ns/rdftest#Approval"></see></summary>
    let Approval = _prefix "Approval"
    /// <summary>
    /// Indicates that a test is approved.
    /// <see href="http://www.w3.org/ns/rdftest#Approved"></see></summary>
    let Approved = _prefix "Approved"
    /// <summary>
    /// Indicates that a test is proposed, but not approved.
    /// <see href="http://www.w3.org/ns/rdftest#Proposed"></see></summary>
    let Proposed = _prefix "Proposed"
    /// <summary>
    /// Indicates that a test is not approved.
    /// <see href="http://www.w3.org/ns/rdftest#Rejected"></see></summary>
    let Rejected = _prefix "Rejected"
    /// <summary>
    /// Superclass of all RDF Tests.
    /// <see href="http://www.w3.org/ns/rdftest#Test"></see></summary>
    let Test = _prefix "Test"
    /// <summary>
    /// Superclass of all RDF Evaluation Tests.
    /// <see href="http://www.w3.org/ns/rdftest#TestEval"></see></summary>
    let TestEval = _prefix "TestEval"
    /// <summary>
    /// A negative N-Quads syntax test.
    /// <see href="http://www.w3.org/ns/rdftest#TestNQuadsNegativeSyntax"></see></summary>
    let TestNQuadsNegativeSyntax = _prefix "TestNQuadsNegativeSyntax"
    /// <summary>
    /// Superclass of all RDF Syntax Tests.
    /// <see href="http://www.w3.org/ns/rdftest#TestSyntax"></see></summary>
    let TestSyntax = _prefix "TestSyntax"
    /// <summary>
    /// A positive N-Quads syntax test.
    /// <see href="http://www.w3.org/ns/rdftest#TestNQuadsPositiveSyntax"></see></summary>
    let TestNQuadsPositiveSyntax = _prefix "TestNQuadsPositiveSyntax"
    /// <summary>
    /// A negative N-Triples syntax test.
    /// <see href="http://www.w3.org/ns/rdftest#TestNTriplesNegativeSyntax"></see></summary>
    let TestNTriplesNegativeSyntax = _prefix "TestNTriplesNegativeSyntax"
    /// <summary>
    /// A positive N-Triples syntax test.
    /// <see href="http://www.w3.org/ns/rdftest#TestNTriplesPositiveSyntax"></see></summary>
    let TestNTriplesPositiveSyntax = _prefix "TestNTriplesPositiveSyntax"
    /// <summary>
    /// A negative TriG syntax test.
    /// <see href="http://www.w3.org/ns/rdftest#TestTriGNegativeSyntax"></see></summary>
    let TestTriGNegativeSyntax = _prefix "TestTriGNegativeSyntax"
    /// <summary>
    /// A positive TriG syntax test.
    /// <see href="http://www.w3.org/ns/rdftest#TestTriGPositiveSyntax"></see></summary>
    let TestTriGPositiveSyntax = _prefix "TestTriGPositiveSyntax"
    /// <summary>
    /// A positive TriG evaluation test.
    /// <see href="http://www.w3.org/ns/rdftest#TestTrigEval"></see></summary>
    let TestTrigEval = _prefix "TestTrigEval"
    /// <summary>
    /// A negative TriG evaluation test.
    /// <see href="http://www.w3.org/ns/rdftest#TestTrigNegativeEval"></see></summary>
    let TestTrigNegativeEval = _prefix "TestTrigNegativeEval"
    /// <summary>
    /// A positive Turtle evaluation test.
    /// <see href="http://www.w3.org/ns/rdftest#TestTurtleEval"></see></summary>
    let TestTurtleEval = _prefix "TestTurtleEval"
    /// <summary>
    /// A negative Turtle evaluation test.
    /// <see href="http://www.w3.org/ns/rdftest#TestTurtleNegativeEval"></see></summary>
    let TestTurtleNegativeEval = _prefix "TestTurtleNegativeEval"
    /// <summary>
    /// A negative Turtle syntax test.
    /// <see href="http://www.w3.org/ns/rdftest#TestTurtleNegativeSyntax"></see></summary>
    let TestTurtleNegativeSyntax = _prefix "TestTurtleNegativeSyntax"
    /// <summary>
    /// A positive Turtle syntax test.
    /// <see href="http://www.w3.org/ns/rdftest#TestTurtlePositiveSyntax"></see></summary>
    let TestTurtlePositiveSyntax = _prefix "TestTurtlePositiveSyntax"
    /// <summary>
    /// A negative RDF/XML syntax test.
    /// <see href="http://www.w3.org/ns/rdftest#TestXMLNegativeSyntax"></see></summary>
    let TestXMLNegativeSyntax = _prefix "TestXMLNegativeSyntax"
    /// <summary>
    /// A positive RDF/XML evaluation test.
    /// <see href="http://www.w3.org/ns/rdftest#XMLEval"></see></summary>
    let XMLEval = _prefix "XMLEval"
    /// <summary>
    /// Approval status of a test.
    /// <see href="http://www.w3.org/ns/rdftest#approval"></see></summary>
    let approval = _prefix "approval"
