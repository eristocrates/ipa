namespace https.w3id.org.cmd.hash

open DoxAletheia.Rdf_Vocabulary

module cmd =
    let _namespace_name = "https://w3id.org/cmd#"

    /// <summary>
    /// Node of the tree structure to classify requirements.
    /// <see href="https://w3id.org/cmd#AnalysisElement"></see></summary>
    let AnalysisElement =
        Namespaced_IRI.parse _namespace_name "AnalysisElement" |> NamespacedName

    /// <summary>
    /// An implementation describing a procedure and/or an executable document. Can either be expressed in a query language, or be refering to an executable file, or be precisly describing the procedure.
    /// <see href="https://w3id.org/cmd#Implementation"></see></summary>
    let Implementation =
        Namespaced_IRI.parse _namespace_name "Implementation" |> NamespacedName

    /// <summary>
    /// Node of the tree structure representing a given metric to evaluate a concrete element.
    /// <see href="https://w3id.org/cmd#Requirement"></see></summary>
    let Requirement =
        Namespaced_IRI.parse _namespace_name "Requirement" |> NamespacedName

    /// <summary>
    /// Defines a compound measure with a set of requirements as well as a structuration of these requirements through the use of analysis elements.
    /// <see href="https://w3id.org/cmd#TSoR"></see></summary>
    let TSoR = Namespaced_IRI.parse _namespace_name "TSoR" |> NamespacedName

    /// <summary>
    /// Definition of a function expressing how to compute a unique global score based on the result obtained on each requirements and their weight.
    /// <see href="https://w3id.org/cmd#aggregFunction"></see></summary>
    let aggregFunction =
        Namespaced_IRI.parse _namespace_name "aggregFunction" |> NamespacedName

    /// <summary>
    /// Associate a requirement with an analysis element: an analysis element expects a requirement.
    /// <see href="https://w3id.org/cmd#expects"></see></summary>
    let expects = Namespaced_IRI.parse _namespace_name "expects" |> NamespacedName
    /// <summary>
    /// A node of a TSoR has as content a given concept or metric.
    /// <see href="https://w3id.org/cmd#hasContent"></see></summary>
    let hasContent = Namespaced_IRI.parse _namespace_name "hasContent" |> NamespacedName
    /// <summary>
    /// The TSoR has a given root among the analysis element.
    /// <see href="https://w3id.org/cmd#hasRoot"></see></summary>
    let hasRoot = Namespaced_IRI.parse _namespace_name "hasRoot" |> NamespacedName

    /// <summary>
    /// An implementation is followed by another implementation if the the second complement the first one.
    /// <see href="https://w3id.org/cmd#isFollowedBy"></see></summary>
    let isFollowedBy =
        Namespaced_IRI.parse _namespace_name "isFollowedBy" |> NamespacedName

    /// <summary>
    /// A requirement is implemented by an implementation.
    /// <see href="https://w3id.org/cmd#isImplementedBy"></see></summary>
    let isImplementedBy =
        Namespaced_IRI.parse _namespace_name "isImplementedBy" |> NamespacedName

    /// <summary>
    /// Structures analysis elements through this relation. An analysis element is specified by one or more other analysis elements that detail the analysis.
    /// <see href="https://w3id.org/cmd#isSpecifiedBy"></see></summary>
    let isSpecifiedBy =
        Namespaced_IRI.parse _namespace_name "isSpecifiedBy" |> NamespacedName

    /// <summary>
    /// Number representing the relative importance of one node (analysis element or requirement) of a TSoR compared to its siblings.
    /// <see href="https://w3id.org/cmd#weight"></see></summary>
    let weight = Namespaced_IRI.parse _namespace_name "weight" |> NamespacedName
