namespace http.promsns.org.def._do.hash

open DoxAletheia

module dprov =
    let _namespace_name = "http://promsns.org/def/do#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A recorded answer to a Question
    /// <see href="http://promsns.org/def/do#Answer"></see></summary>
    let Answer = _prefix "Answer"
    /// <summary>
    /// Option Selection is a process (prov:Activity) through which a decision-making Agent selects something.
    ///
    /// At least two Option Selection Activities, possibly more, must be run in parrallel by an Agent and at least one must yield an outcome in order for a Question to be answered.
    /// <see href="http://promsns.org/def/do#OptionSelection"></see></summary>
    let OptionSelection = _prefix "OptionSelection"
    /// <summary>
    /// A recorded question
    /// <see href="http://promsns.org/def/do#Question"></see></summary>
    let Question = _prefix "Question"
    /// <summary>
    ///   <see href="http://promsns.org/def/do#DecisionMaker"></see>
    /// </summary>
    let DecisionMaker = _prefix "DecisionMaker"
    /// <summary>
    /// A temporal event in which decision processes are undertaken, such as initiating sub-questions for the question to be answered, consideration of options etc.
    /// <see href="http://promsns.org/def/do#DecisionMaking"></see></summary>
    let DecisionMaking = _prefix "DecisionMaking"
    /// <summary>
    ///   <see href="http://promsns.org/def/do#Decision_making"></see>
    /// </summary>
    let Decision_making = _prefix "Decision_making"
    /// <summary>
    /// Requirements require something from an OptionSelection Activity. They indicate their requirement with a set (a class) of objects. They are then satisified by the presense of an onject within that class. Multiple Requirements can be intersected to require very specific OptionSelection outcomes.
    /// <see href="http://promsns.org/def/do#Requirement"></see></summary>
    let Requirement = _prefix "Requirement"
