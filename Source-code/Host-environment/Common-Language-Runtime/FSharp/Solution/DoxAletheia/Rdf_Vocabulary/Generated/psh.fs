namespace http.ns.inria.fr.probabilistic_shacl.slash

open DoxAletheia

module psh =
    let _namespace_name = "http://ns.inria.fr/probabilistic-shacl/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The class of probabilistic validation summary
    /// <see href="http://ns.inria.fr/probabilistic-shacl/ValidationSummary"></see></summary>
    let ValidationSummary = _prefix "ValidationSummary"
    /// <summary>
    /// The shape concerned by the results of the probabilistic validation
    /// <see href="http://ns.inria.fr/probabilistic-shacl/focusShape"></see></summary>
    let focusShape = _prefix "focusShape"
    /// <summary>
    /// Specifies the representativeness of the current shape
    /// <see href="http://ns.inria.fr/probabilistic-shacl/generality"></see></summary>
    let generality = _prefix "generality"
    /// <summary>
    /// Specifies the likelihood to observe the number of exceptions among the RDF triples tested (i.e. referenceCardinality)
    /// <see href="http://ns.inria.fr/probabilistic-shacl/likelihood"></see></summary>
    let likelihood = _prefix "likelihood"
    /// <summary>
    /// Specifies the number of nodes that confirm the current shape
    /// <see href="http://ns.inria.fr/probabilistic-shacl/numConfirmation"></see></summary>
    let numConfirmation = _prefix "numConfirmation"
    /// <summary>
    /// Specifies the number of nodes that contradict the current shape
    /// <see href="http://ns.inria.fr/probabilistic-shacl/numViolation"></see></summary>
    let numViolation = _prefix "numViolation"
    /// <summary>
    /// Specifies the number of RDF triples tested during the validation of the current shape
    /// <see href="http://ns.inria.fr/probabilistic-shacl/referenceCardinality"></see></summary>
    let referenceCardinality = _prefix "referenceCardinality"
    /// <summary>
    /// The probabilistic validation results contained in a validation report.
    /// <see href="http://ns.inria.fr/probabilistic-shacl/summary"></see></summary>
    let summary = _prefix "summary"
