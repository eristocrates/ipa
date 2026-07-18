namespace https.privatealpha.com.ontology.ibis._1.hash

open DoxAletheia.Rdf_Vocabulary

module ibis =
    let _namespace_name = "https://privatealpha.com/ontology/ibis/1#"
    /// <summary>
    /// An Argument is a type of Issue that explicitly supports or refutes a Position.
    /// <see href="https://privatealpha.com/ontology/ibis/1#Argument"></see></summary>
    let Argument = Namespaced_IRI.parse _namespace_name "Argument" |> NamespacedName

    /// <summary>
    /// Indicates when a concept is replaced by another concept of the same type.
    /// <see href="https://privatealpha.com/ontology/ibis/1#replaced-by"></see></summary>
    let ``replaced-by`` =
        Namespaced_IRI.parse _namespace_name "replaced-by" |> NamespacedName

    /// <summary>
    /// Indicates when a concept replaces another concept of the same type.
    /// <see href="https://privatealpha.com/ontology/ibis/1#replaces"></see></summary>
    let replaces = Namespaced_IRI.parse _namespace_name "replaces" |> NamespacedName
    /// <summary>
    /// An Issue is a state of affairs, claimed by one or more Agents to either be a misfit itself, or affecting some other Issue or Position.
    /// <see href="https://privatealpha.com/ontology/ibis/1#Issue"></see></summary>
    let Issue = Namespaced_IRI.parse _namespace_name "Issue" |> NamespacedName
    /// <summary>
    /// A Position asserts a moral, ethical, pragmatic, or similar kind of assertion, typically identifying what, if anything, should be done about an Issue.
    /// <see href="https://privatealpha.com/ontology/ibis/1#Position"></see></summary>
    let Position = Namespaced_IRI.parse _namespace_name "Position" |> NamespacedName
    /// <summary>
    /// An Issue or Position can be marked Invariant to denote that it has been deemed outside of the influence of the Agents in the system, i.e., something to be steered around.
    /// <see href="https://privatealpha.com/ontology/ibis/1#Invariant"></see></summary>
    let Invariant = Namespaced_IRI.parse _namespace_name "Invariant" |> NamespacedName
    /// <summary>
    /// A network of issues, positions, and arguments.
    /// <see href="https://privatealpha.com/ontology/ibis/1#Network"></see></summary>
    let Network = Namespaced_IRI.parse _namespace_name "Network" |> NamespacedName
    /// <summary>
    /// The subject is an issue concerning the object, which can be any resource.
    /// <see href="https://privatealpha.com/ontology/ibis/1#concerns"></see></summary>
    let concerns = Namespaced_IRI.parse _namespace_name "concerns" |> NamespacedName

    /// <summary>
    /// A concept can be endorsed by an Agent without said Agent having mentioned or advanced it initially, and without any additional comment.
    /// <see href="https://privatealpha.com/ontology/ibis/1#endorsed-by"></see></summary>
    let ``endorsed-by`` =
        Namespaced_IRI.parse _namespace_name "endorsed-by" |> NamespacedName

    /// <summary>
    /// An Agent can endorse a concept without having initially mentioned or advanced it, and without any additional comment.
    /// <see href="https://privatealpha.com/ontology/ibis/1#endorses"></see></summary>
    let endorses = Namespaced_IRI.parse _namespace_name "endorses" |> NamespacedName

    /// <summary>
    /// The subject is a more generic form of the object.
    /// <see href="https://privatealpha.com/ontology/ibis/1#generalizes"></see></summary>
    let generalizes =
        Namespaced_IRI.parse _namespace_name "generalizes" |> NamespacedName

    /// <summary>
    /// The subject is a more specific form of the object.
    /// <see href="https://privatealpha.com/ontology/ibis/1#specializes"></see></summary>
    let specializes =
        Namespaced_IRI.parse _namespace_name "specializes" |> NamespacedName

    /// <summary>
    /// Indicates a subject position opposed by an object argument.
    /// <see href="https://privatealpha.com/ontology/ibis/1#opposed-by"></see></summary>
    let ``opposed-by`` =
        Namespaced_IRI.parse _namespace_name "opposed-by" |> NamespacedName

    /// <summary>
    /// Indicates a subject argument that opposes an object position.
    /// <see href="https://privatealpha.com/ontology/ibis/1#opposes"></see></summary>
    let opposes = Namespaced_IRI.parse _namespace_name "opposes" |> NamespacedName

    /// <summary>
    /// Indicates a belief called into question by an issue.
    /// <see href="https://privatealpha.com/ontology/ibis/1#questioned-by"></see></summary>
    let ``questioned-by`` =
        Namespaced_IRI.parse _namespace_name "questioned-by" |> NamespacedName

    /// <summary>
    /// Indicates an issue that raises doubt on a belief.
    /// <see href="https://privatealpha.com/ontology/ibis/1#questions"></see></summary>
    let questions = Namespaced_IRI.parse _namespace_name "questions" |> NamespacedName

    /// <summary>
    /// Indicates an issue to which the subject position responds.
    /// <see href="https://privatealpha.com/ontology/ibis/1#responds-to"></see></summary>
    let ``responds-to`` =
        Namespaced_IRI.parse _namespace_name "responds-to" |> NamespacedName

    /// <summary>
    /// Indicates a position that responds to the subject issue.
    /// <see href="https://privatealpha.com/ontology/ibis/1#response"></see></summary>
    let response = Namespaced_IRI.parse _namespace_name "response" |> NamespacedName

    /// <summary>
    /// Indicates when the subject issue is suggested by the object belief.
    /// <see href="https://privatealpha.com/ontology/ibis/1#suggested-by"></see></summary>
    let ``suggested-by`` =
        Namespaced_IRI.parse _namespace_name "suggested-by" |> NamespacedName

    /// <summary>
    /// Indicates when the subject belief suggests the object issue.
    /// <see href="https://privatealpha.com/ontology/ibis/1#suggests"></see></summary>
    let suggests = Namespaced_IRI.parse _namespace_name "suggests" |> NamespacedName

    /// <summary>
    /// Indicates a subject position supported by an object argument.
    /// <see href="https://privatealpha.com/ontology/ibis/1#supported-by"></see></summary>
    let ``supported-by`` =
        Namespaced_IRI.parse _namespace_name "supported-by" |> NamespacedName

    /// <summary>
    /// Indicates a subject argument that supports an object position.
    /// <see href="https://privatealpha.com/ontology/ibis/1#supports"></see></summary>
    let supports = Namespaced_IRI.parse _namespace_name "supports" |> NamespacedName
