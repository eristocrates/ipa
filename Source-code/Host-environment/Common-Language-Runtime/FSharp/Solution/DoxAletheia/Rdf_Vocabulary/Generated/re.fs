namespace http.www.w3.org._2000._10.swap.reason.hash

open DoxAletheia

module re =
    let _namespace_name = "http://www.w3.org/2000/10/swap/reason#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A binding is given eg in a proof or query result.
    /// 	The binding specifies which variable was bound (:variable),
    /// 	and what term it was bound to.
    ///
    /// <see href="http://www.w3.org/2000/10/swap/reason#Binding"></see></summary>
    let Binding = _prefix "Binding"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/reason#CommandLine"></see>
    /// </summary>
    let CommandLine = _prefix "CommandLine"
    /// <summary>
    /// A step in a proof.
    ///
    /// 	See :gives for the arc to the formula actually proved at this step.
    ///
    /// <see href="http://www.w3.org/2000/10/swap/reason#Step"></see></summary>
    let Step = _prefix "Step"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/reason#Conjunction"></see>
    /// </summary>
    let Conjunction = _prefix "Conjunction"
    /// <summary>
    /// The step of taking one statement out of a formula.
    /// 	The step is identified by the :gives formula (the statement)
    /// 	and the :because step's :gives formula (the formula extracted
    /// 	from).
    ///
    /// <see href="http://www.w3.org/2000/10/swap/reason#Extraction"></see></summary>
    let Extraction = _prefix "Extraction"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/reason#Inference"></see>
    /// </summary>
    let Inference = _prefix "Inference"
    /// <summary>
    /// The formula given was derived from parsing a
    /// 	resource.
    /// <see href="http://www.w3.org/2000/10/swap/reason#Parsing"></see></summary>
    let Parsing = _prefix "Parsing"
    /// <summary>
    /// A Proof step is the last step in the proof,
    /// 	a step which :gives that which was to be proved.
    /// 	Typically a document will assert just one :Proof,
    /// 	which a checker can then check and turn into
    /// 	the Formula proved - Q.E.D. .
    ///
    /// <see href="http://www.w3.org/2000/10/swap/reason#Proof"></see></summary>
    let Proof = _prefix "Proof"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/reason#args"></see>
    /// </summary>
    let args = _prefix "args"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/reason#Commandline"></see>
    /// </summary>
    let Commandline = _prefix "Commandline"
    /// <summary>
    /// gives the step whose data was input to this step.
    /// <see href="http://www.w3.org/2000/10/swap/reason#because"></see></summary>
    let because = _prefix "because"
    /// <summary>
    ///
    /// 	This binding binds its variable to this term.
    ///
    /// <see href="http://www.w3.org/2000/10/swap/reason#boundTo"></see></summary>
    let boundTo = _prefix "boundTo"
    /// <summary>
    /// A step whose data was used in building this conjunction
    /// <see href="http://www.w3.org/2000/10/swap/reason#component"></see></summary>
    let component_ = _prefix "component"
    /// <summary>
    /// The :evidence for a GMP inference step is a list of
    ///     formulas, each proved by other means, which combined entail the
    ///     result of making the given substitution in the antecedent of the rule.
    /// <see href="http://www.w3.org/2000/10/swap/reason#evidence"></see></summary>
    let evidence = _prefix "evidence"
    /// <summary>
    /// The proof step gives the formula as a result.
    /// 	For some steps, like extraction of a statement from a formula,
    /// 	it is essential to give the result formula in a proof to define
    /// 	what step has been taken.  For other steps, such as GMP inference,
    /// 	the specification of the rule and bindings defines the result,
    /// 	and so the proof can still be checked if the reason:gives ars
    /// <see href="http://www.w3.org/2000/10/swap/reason#gives"></see></summary>
    let gives = _prefix "gives"
    /// <summary>
    /// The inference step was performed using a rule (implication)
    ///     given.
    /// <see href="http://www.w3.org/2000/10/swap/reason#rule"></see></summary>
    let rule = _prefix "rule"
    /// <summary>
    /// The source document which was parsed.
    ///
    /// <see href="http://www.w3.org/2000/10/swap/reason#source"></see></summary>
    let source = _prefix "source"
    /// <summary>
    ///
    /// 	The given string is that used as the identifier of the variable
    /// 	which is bound by this binding.  The variable name has to be given as
    /// 	a string, rather than the variable being put here, or the variable
    /// 	would be treated as a variable.
    /// <see href="http://www.w3.org/2000/10/swap/reason#variable"></see></summary>
    let variable = _prefix "variable"
