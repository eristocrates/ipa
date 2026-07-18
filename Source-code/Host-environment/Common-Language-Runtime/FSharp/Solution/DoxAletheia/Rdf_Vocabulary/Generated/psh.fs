namespace http.ns.inria.fr.probabilistic_shacl.slash

open DoxAletheia.Rdf_Vocabulary

module psh =
    let _namespace_name = "http://ns.inria.fr/probabilistic-shacl/"

    /// <summary>
    /// The class of probabilistic validation summary
    /// <see href="http://ns.inria.fr/probabilistic-shacl/ValidationSummary"></see></summary>
    let ValidationSummary =
        Namespaced_IRI.parse _namespace_name "ValidationSummary" |> NamespacedName

    /// <summary>
    /// The shape concerned by the results of the probabilistic validation
    /// <see href="http://ns.inria.fr/probabilistic-shacl/focusShape"></see></summary>
    let focusShape = Namespaced_IRI.parse _namespace_name "focusShape" |> NamespacedName
    /// <summary>
    /// Specifies the representativeness of the current shape
    /// <see href="http://ns.inria.fr/probabilistic-shacl/generality"></see></summary>
    let generality = Namespaced_IRI.parse _namespace_name "generality" |> NamespacedName
    /// <summary>
    /// Specifies the likelihood to observe the number of exceptions among the RDF triples tested (i.e. referenceCardinality)
    /// <see href="http://ns.inria.fr/probabilistic-shacl/likelihood"></see></summary>
    let likelihood = Namespaced_IRI.parse _namespace_name "likelihood" |> NamespacedName

    /// <summary>
    /// Specifies the number of nodes that confirm the current shape
    /// <see href="http://ns.inria.fr/probabilistic-shacl/numConfirmation"></see></summary>
    let numConfirmation =
        Namespaced_IRI.parse _namespace_name "numConfirmation" |> NamespacedName

    /// <summary>
    /// Specifies the number of nodes that contradict the current shape
    /// <see href="http://ns.inria.fr/probabilistic-shacl/numViolation"></see></summary>
    let numViolation =
        Namespaced_IRI.parse _namespace_name "numViolation" |> NamespacedName

    /// <summary>
    /// Specifies the number of RDF triples tested during the validation of the current shape
    /// <see href="http://ns.inria.fr/probabilistic-shacl/referenceCardinality"></see></summary>
    let referenceCardinality =
        Namespaced_IRI.parse _namespace_name "referenceCardinality" |> NamespacedName

    /// <summary>
    /// The probabilistic validation results contained in a validation report.
    /// <see href="http://ns.inria.fr/probabilistic-shacl/summary"></see></summary>
    let summary = Namespaced_IRI.parse _namespace_name "summary" |> NamespacedName
