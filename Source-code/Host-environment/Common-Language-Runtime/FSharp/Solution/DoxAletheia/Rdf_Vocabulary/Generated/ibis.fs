namespace https.privatealpha.com.ontology.ibis._1.hash

open DoxAletheia

module ibis =
    let _namespace_name = "https://privatealpha.com/ontology/ibis/1#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An Argument is a type of Issue that explicitly supports or refutes a Position.
    /// <see href="https://privatealpha.com/ontology/ibis/1#Argument"></see></summary>
    let Argument = _prefix "Argument"
    /// <summary>
    /// Indicates when a concept is replaced by another concept of the same type.
    /// <see href="https://privatealpha.com/ontology/ibis/1#replaced-by"></see></summary>
    let ``replaced-by`` = _prefix "replaced-by"
    /// <summary>
    /// Indicates when a concept replaces another concept of the same type.
    /// <see href="https://privatealpha.com/ontology/ibis/1#replaces"></see></summary>
    let replaces = _prefix "replaces"
    /// <summary>
    /// An Issue is a state of affairs, claimed by one or more Agents to either be a misfit itself, or affecting some other Issue or Position.
    /// <see href="https://privatealpha.com/ontology/ibis/1#Issue"></see></summary>
    let Issue = _prefix "Issue"
    /// <summary>
    /// A Position asserts a moral, ethical, pragmatic, or similar kind of assertion, typically identifying what, if anything, should be done about an Issue.
    /// <see href="https://privatealpha.com/ontology/ibis/1#Position"></see></summary>
    let Position = _prefix "Position"
    /// <summary>
    /// An Issue or Position can be marked Invariant to denote that it has been deemed outside of the influence of the Agents in the system, i.e., something to be steered around.
    /// <see href="https://privatealpha.com/ontology/ibis/1#Invariant"></see></summary>
    let Invariant = _prefix "Invariant"
    /// <summary>
    /// A network of issues, positions, and arguments.
    /// <see href="https://privatealpha.com/ontology/ibis/1#Network"></see></summary>
    let Network = _prefix "Network"
    /// <summary>
    /// The subject is an issue concerning the object, which can be any resource.
    /// <see href="https://privatealpha.com/ontology/ibis/1#concerns"></see></summary>
    let concerns = _prefix "concerns"
    /// <summary>
    /// A concept can be endorsed by an Agent without said Agent having mentioned or advanced it initially, and without any additional comment.
    /// <see href="https://privatealpha.com/ontology/ibis/1#endorsed-by"></see></summary>
    let ``endorsed-by`` = _prefix "endorsed-by"
    /// <summary>
    /// An Agent can endorse a concept without having initially mentioned or advanced it, and without any additional comment.
    /// <see href="https://privatealpha.com/ontology/ibis/1#endorses"></see></summary>
    let endorses = _prefix "endorses"
    /// <summary>
    /// The subject is a more generic form of the object.
    /// <see href="https://privatealpha.com/ontology/ibis/1#generalizes"></see></summary>
    let generalizes = _prefix "generalizes"
    /// <summary>
    /// The subject is a more specific form of the object.
    /// <see href="https://privatealpha.com/ontology/ibis/1#specializes"></see></summary>
    let specializes = _prefix "specializes"
    /// <summary>
    /// Indicates a subject position opposed by an object argument.
    /// <see href="https://privatealpha.com/ontology/ibis/1#opposed-by"></see></summary>
    let ``opposed-by`` = _prefix "opposed-by"
    /// <summary>
    /// Indicates a subject argument that opposes an object position.
    /// <see href="https://privatealpha.com/ontology/ibis/1#opposes"></see></summary>
    let opposes = _prefix "opposes"
    /// <summary>
    /// Indicates a belief called into question by an issue.
    /// <see href="https://privatealpha.com/ontology/ibis/1#questioned-by"></see></summary>
    let ``questioned-by`` = _prefix "questioned-by"
    /// <summary>
    /// Indicates an issue that raises doubt on a belief.
    /// <see href="https://privatealpha.com/ontology/ibis/1#questions"></see></summary>
    let questions = _prefix "questions"
    /// <summary>
    /// Indicates an issue to which the subject position responds.
    /// <see href="https://privatealpha.com/ontology/ibis/1#responds-to"></see></summary>
    let ``responds-to`` = _prefix "responds-to"
    /// <summary>
    /// Indicates a position that responds to the subject issue.
    /// <see href="https://privatealpha.com/ontology/ibis/1#response"></see></summary>
    let response = _prefix "response"
    /// <summary>
    /// Indicates when the subject issue is suggested by the object belief.
    /// <see href="https://privatealpha.com/ontology/ibis/1#suggested-by"></see></summary>
    let ``suggested-by`` = _prefix "suggested-by"
    /// <summary>
    /// Indicates when the subject belief suggests the object issue.
    /// <see href="https://privatealpha.com/ontology/ibis/1#suggests"></see></summary>
    let suggests = _prefix "suggests"
    /// <summary>
    /// Indicates a subject position supported by an object argument.
    /// <see href="https://privatealpha.com/ontology/ibis/1#supported-by"></see></summary>
    let ``supported-by`` = _prefix "supported-by"
    /// <summary>
    /// Indicates a subject argument that supports an object position.
    /// <see href="https://privatealpha.com/ontology/ibis/1#supports"></see></summary>
    let supports = _prefix "supports"
