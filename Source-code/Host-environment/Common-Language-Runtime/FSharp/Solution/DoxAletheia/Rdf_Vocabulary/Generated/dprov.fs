namespace http.promsns.org.def._do.hash

open DoxAletheia.Rdf_Vocabulary

module dprov =
    let _namespace_name = "http://promsns.org/def/do#"
    /// <summary>
    /// A recorded answer to a Question
    /// <see href="http://promsns.org/def/do#Answer"></see></summary>
    let Answer = Namespaced_IRI.parse _namespace_name "Answer" |> NamespacedName

    /// <summary>
    /// Option Selection is a process (prov:Activity) through which a decision-making Agent selects something.
    ///
    /// At least two Option Selection Activities, possibly more, must be run in parrallel by an Agent and at least one must yield an outcome in order for a Question to be answered.
    /// <see href="http://promsns.org/def/do#OptionSelection"></see></summary>
    let OptionSelection =
        Namespaced_IRI.parse _namespace_name "OptionSelection" |> NamespacedName

    /// <summary>
    /// A recorded question
    /// <see href="http://promsns.org/def/do#Question"></see></summary>
    let Question = Namespaced_IRI.parse _namespace_name "Question" |> NamespacedName

    /// <summary>
    ///   <see href="http://promsns.org/def/do#DecisionMaker"></see>
    /// </summary>
    let DecisionMaker =
        Namespaced_IRI.parse _namespace_name "DecisionMaker" |> NamespacedName

    /// <summary>
    /// A temporal event in which decision processes are undertaken, such as initiating sub-questions for the question to be answered, consideration of options etc.
    /// <see href="http://promsns.org/def/do#DecisionMaking"></see></summary>
    let DecisionMaking =
        Namespaced_IRI.parse _namespace_name "DecisionMaking" |> NamespacedName

    /// <summary>
    ///   <see href="http://promsns.org/def/do#Decision_making"></see>
    /// </summary>
    let Decision_making =
        Namespaced_IRI.parse _namespace_name "Decision_making" |> NamespacedName

    /// <summary>
    /// Requirements require something from an OptionSelection Activity. They indicate their requirement with a set (a class) of objects. They are then satisified by the presense of an onject within that class. Multiple Requirements can be intersected to require very specific OptionSelection outcomes.
    /// <see href="http://promsns.org/def/do#Requirement"></see></summary>
    let Requirement =
        Namespaced_IRI.parse _namespace_name "Requirement" |> NamespacedName
