namespace http.www.w3.org._2000._10.swap.reason.hash

open DoxAletheia.Rdf_Vocabulary

module re =
    let _namespace_name = "http://www.w3.org/2000/10/swap/reason#"
    /// <summary>
    /// A binding is given eg in a proof or query result.
    /// 	The binding specifies which variable was bound (:variable),
    /// 	and what term it was bound to.
    ///
    /// <see href="http://www.w3.org/2000/10/swap/reason#Binding"></see></summary>
    let Binding = Namespaced_IRI.parse _namespace_name "Binding" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/reason#CommandLine"></see>
    /// </summary>
    let CommandLine =
        Namespaced_IRI.parse _namespace_name "CommandLine" |> NamespacedName

    /// <summary>
    /// A step in a proof.
    ///
    /// 	See :gives for the arc to the formula actually proved at this step.
    ///
    /// <see href="http://www.w3.org/2000/10/swap/reason#Step"></see></summary>
    let Step = Namespaced_IRI.parse _namespace_name "Step" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/reason#Conjunction"></see>
    /// </summary>
    let Conjunction =
        Namespaced_IRI.parse _namespace_name "Conjunction" |> NamespacedName

    /// <summary>
    /// The step of taking one statement out of a formula.
    /// 	The step is identified by the :gives formula (the statement)
    /// 	and the :because step's :gives formula (the formula extracted
    /// 	from).
    ///
    /// <see href="http://www.w3.org/2000/10/swap/reason#Extraction"></see></summary>
    let Extraction = Namespaced_IRI.parse _namespace_name "Extraction" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/reason#Inference"></see>
    /// </summary>
    let Inference = Namespaced_IRI.parse _namespace_name "Inference" |> NamespacedName
    /// <summary>
    /// The formula given was derived from parsing a
    /// 	resource.
    /// <see href="http://www.w3.org/2000/10/swap/reason#Parsing"></see></summary>
    let Parsing = Namespaced_IRI.parse _namespace_name "Parsing" |> NamespacedName
    /// <summary>
    /// A Proof step is the last step in the proof,
    /// 	a step which :gives that which was to be proved.
    /// 	Typically a document will assert just one :Proof,
    /// 	which a checker can then check and turn into
    /// 	the Formula proved - Q.E.D. .
    ///
    /// <see href="http://www.w3.org/2000/10/swap/reason#Proof"></see></summary>
    let Proof = Namespaced_IRI.parse _namespace_name "Proof" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/reason#args"></see>
    /// </summary>
    let args = Namespaced_IRI.parse _namespace_name "args" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/reason#Commandline"></see>
    /// </summary>
    let Commandline =
        Namespaced_IRI.parse _namespace_name "Commandline" |> NamespacedName

    /// <summary>
    /// gives the step whose data was input to this step.
    /// <see href="http://www.w3.org/2000/10/swap/reason#because"></see></summary>
    let because = Namespaced_IRI.parse _namespace_name "because" |> NamespacedName
    /// <summary>
    ///
    /// 	This binding binds its variable to this term.
    ///
    /// <see href="http://www.w3.org/2000/10/swap/reason#boundTo"></see></summary>
    let boundTo = Namespaced_IRI.parse _namespace_name "boundTo" |> NamespacedName
    /// <summary>
    /// A step whose data was used in building this conjunction
    /// <see href="http://www.w3.org/2000/10/swap/reason#component"></see></summary>
    let component_ = Namespaced_IRI.parse _namespace_name "component" |> NamespacedName
    /// <summary>
    /// The :evidence for a GMP inference step is a list of
    ///     formulas, each proved by other means, which combined entail the
    ///     result of making the given substitution in the antecedent of the rule.
    /// <see href="http://www.w3.org/2000/10/swap/reason#evidence"></see></summary>
    let evidence = Namespaced_IRI.parse _namespace_name "evidence" |> NamespacedName
    /// <summary>
    /// The proof step gives the formula as a result.
    /// 	For some steps, like extraction of a statement from a formula,
    /// 	it is essential to give the result formula in a proof to define
    /// 	what step has been taken.  For other steps, such as GMP inference,
    /// 	the specification of the rule and bindings defines the result,
    /// 	and so the proof can still be checked if the reason:gives ars
    /// <see href="http://www.w3.org/2000/10/swap/reason#gives"></see></summary>
    let gives = Namespaced_IRI.parse _namespace_name "gives" |> NamespacedName
    /// <summary>
    /// The inference step was performed using a rule (implication)
    ///     given.
    /// <see href="http://www.w3.org/2000/10/swap/reason#rule"></see></summary>
    let rule = Namespaced_IRI.parse _namespace_name "rule" |> NamespacedName
    /// <summary>
    /// The source document which was parsed.
    ///
    /// <see href="http://www.w3.org/2000/10/swap/reason#source"></see></summary>
    let source = Namespaced_IRI.parse _namespace_name "source" |> NamespacedName
    /// <summary>
    ///
    /// 	The given string is that used as the identifier of the variable
    /// 	which is bound by this binding.  The variable name has to be given as
    /// 	a string, rather than the variable being put here, or the variable
    /// 	would be treated as a variable.
    /// <see href="http://www.w3.org/2000/10/swap/reason#variable"></see></summary>
    let variable = Namespaced_IRI.parse _namespace_name "variable" |> NamespacedName
