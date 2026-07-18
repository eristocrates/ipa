namespace http.www.w3.org.ns.rdftest.hash

open DoxAletheia.Rdf_Vocabulary

module rdft =
    let _namespace_name = "http://www.w3.org/ns/rdftest#"
    /// <summary>
    /// The superclass of all test approval statuses.
    /// <see href="http://www.w3.org/ns/rdftest#Approval"></see></summary>
    let Approval = Namespaced_IRI.parse _namespace_name "Approval" |> NamespacedName
    /// <summary>
    /// Indicates that a test is approved.
    /// <see href="http://www.w3.org/ns/rdftest#Approved"></see></summary>
    let Approved = Namespaced_IRI.parse _namespace_name "Approved" |> NamespacedName
    /// <summary>
    /// Indicates that a test is proposed, but not approved.
    /// <see href="http://www.w3.org/ns/rdftest#Proposed"></see></summary>
    let Proposed = Namespaced_IRI.parse _namespace_name "Proposed" |> NamespacedName
    /// <summary>
    /// Indicates that a test is not approved.
    /// <see href="http://www.w3.org/ns/rdftest#Rejected"></see></summary>
    let Rejected = Namespaced_IRI.parse _namespace_name "Rejected" |> NamespacedName
    /// <summary>
    /// Superclass of all RDF Tests.
    /// <see href="http://www.w3.org/ns/rdftest#Test"></see></summary>
    let Test = Namespaced_IRI.parse _namespace_name "Test" |> NamespacedName
    /// <summary>
    /// Superclass of all RDF Evaluation Tests.
    /// <see href="http://www.w3.org/ns/rdftest#TestEval"></see></summary>
    let TestEval = Namespaced_IRI.parse _namespace_name "TestEval" |> NamespacedName

    /// <summary>
    /// A negative N-Quads syntax test.
    /// <see href="http://www.w3.org/ns/rdftest#TestNQuadsNegativeSyntax"></see></summary>
    let TestNQuadsNegativeSyntax =
        Namespaced_IRI.parse _namespace_name "TestNQuadsNegativeSyntax" |> NamespacedName

    /// <summary>
    /// Superclass of all RDF Syntax Tests.
    /// <see href="http://www.w3.org/ns/rdftest#TestSyntax"></see></summary>
    let TestSyntax = Namespaced_IRI.parse _namespace_name "TestSyntax" |> NamespacedName

    /// <summary>
    /// A positive N-Quads syntax test.
    /// <see href="http://www.w3.org/ns/rdftest#TestNQuadsPositiveSyntax"></see></summary>
    let TestNQuadsPositiveSyntax =
        Namespaced_IRI.parse _namespace_name "TestNQuadsPositiveSyntax" |> NamespacedName

    /// <summary>
    /// A negative N-Triples syntax test.
    /// <see href="http://www.w3.org/ns/rdftest#TestNTriplesNegativeSyntax"></see></summary>
    let TestNTriplesNegativeSyntax =
        Namespaced_IRI.parse _namespace_name "TestNTriplesNegativeSyntax" |> NamespacedName

    /// <summary>
    /// A positive N-Triples syntax test.
    /// <see href="http://www.w3.org/ns/rdftest#TestNTriplesPositiveSyntax"></see></summary>
    let TestNTriplesPositiveSyntax =
        Namespaced_IRI.parse _namespace_name "TestNTriplesPositiveSyntax" |> NamespacedName

    /// <summary>
    /// A negative TriG syntax test.
    /// <see href="http://www.w3.org/ns/rdftest#TestTriGNegativeSyntax"></see></summary>
    let TestTriGNegativeSyntax =
        Namespaced_IRI.parse _namespace_name "TestTriGNegativeSyntax" |> NamespacedName

    /// <summary>
    /// A positive TriG syntax test.
    /// <see href="http://www.w3.org/ns/rdftest#TestTriGPositiveSyntax"></see></summary>
    let TestTriGPositiveSyntax =
        Namespaced_IRI.parse _namespace_name "TestTriGPositiveSyntax" |> NamespacedName

    /// <summary>
    /// A positive TriG evaluation test.
    /// <see href="http://www.w3.org/ns/rdftest#TestTrigEval"></see></summary>
    let TestTrigEval =
        Namespaced_IRI.parse _namespace_name "TestTrigEval" |> NamespacedName

    /// <summary>
    /// A negative TriG evaluation test.
    /// <see href="http://www.w3.org/ns/rdftest#TestTrigNegativeEval"></see></summary>
    let TestTrigNegativeEval =
        Namespaced_IRI.parse _namespace_name "TestTrigNegativeEval" |> NamespacedName

    /// <summary>
    /// A positive Turtle evaluation test.
    /// <see href="http://www.w3.org/ns/rdftest#TestTurtleEval"></see></summary>
    let TestTurtleEval =
        Namespaced_IRI.parse _namespace_name "TestTurtleEval" |> NamespacedName

    /// <summary>
    /// A negative Turtle evaluation test.
    /// <see href="http://www.w3.org/ns/rdftest#TestTurtleNegativeEval"></see></summary>
    let TestTurtleNegativeEval =
        Namespaced_IRI.parse _namespace_name "TestTurtleNegativeEval" |> NamespacedName

    /// <summary>
    /// A negative Turtle syntax test.
    /// <see href="http://www.w3.org/ns/rdftest#TestTurtleNegativeSyntax"></see></summary>
    let TestTurtleNegativeSyntax =
        Namespaced_IRI.parse _namespace_name "TestTurtleNegativeSyntax" |> NamespacedName

    /// <summary>
    /// A positive Turtle syntax test.
    /// <see href="http://www.w3.org/ns/rdftest#TestTurtlePositiveSyntax"></see></summary>
    let TestTurtlePositiveSyntax =
        Namespaced_IRI.parse _namespace_name "TestTurtlePositiveSyntax" |> NamespacedName

    /// <summary>
    /// A negative RDF/XML syntax test.
    /// <see href="http://www.w3.org/ns/rdftest#TestXMLNegativeSyntax"></see></summary>
    let TestXMLNegativeSyntax =
        Namespaced_IRI.parse _namespace_name "TestXMLNegativeSyntax" |> NamespacedName

    /// <summary>
    /// A positive RDF/XML evaluation test.
    /// <see href="http://www.w3.org/ns/rdftest#XMLEval"></see></summary>
    let XMLEval = Namespaced_IRI.parse _namespace_name "XMLEval" |> NamespacedName
    /// <summary>
    /// Approval status of a test.
    /// <see href="http://www.w3.org/ns/rdftest#approval"></see></summary>
    let approval = Namespaced_IRI.parse _namespace_name "approval" |> NamespacedName
