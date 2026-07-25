namespace http.www.w3.org._2000._10.swap.reason.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module re =
    let _namespace_iri = Namespace_Iri re |> NamespaceIRI
    /// <summary>
    ///   <para>re:CommandLine</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/reason#CommandLine">http://www.w3.org/2000/10/swap/reason#CommandLine</seealso>
    let CommandLine = Prefixed_Name(re, "CommandLine") |> PrefixedName
    /// <summary>
    ///   <para>re:Step</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A step in a proof.
    ///
    /// 	See :gives for the arc to the formula actually proved at this step.
    /// 	</para>
    /// labels<para>proof step</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/reason#Step">http://www.w3.org/2000/10/swap/reason#Step</seealso>
    let Step = Prefixed_Name(re, "Step") |> PrefixedName
    /// <summary>
    ///   <para>re:Extraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>The step of taking one statement out of a formula.
    /// 	The step is identified by the :gives formula (the statement)
    /// 	and the :because step's :gives formula (the formula extracted
    /// 	from).
    /// 	</para>
    /// labels<para>Conjunction elimination</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/reason#Extraction">http://www.w3.org/2000/10/swap/reason#Extraction</seealso>
    let Extraction = Prefixed_Name(re, "Extraction") |> PrefixedName
    /// <summary>
    ///   <para>re:Parsing</para>
    /// </summary>
    /// <remarks>
    ///   <para>The formula given was derived from parsing a
    /// 	resource.</para>
    /// labels<para>parsing</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/reason#Parsing">http://www.w3.org/2000/10/swap/reason#Parsing</seealso>
    let Parsing = Prefixed_Name(re, "Parsing") |> PrefixedName
    /// <summary>
    ///   <para>re:args</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>A human-readable representation of the arguments given
    /// 	    on the command line</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/reason#args">http://www.w3.org/2000/10/swap/reason#args</seealso>
    let args = Prefixed_Name(re, "args") |> PrefixedName
    /// <summary>
    ///   <para>re:because</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>gives the step whose data was input to this step.</para>
    /// labels<para>from</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/reason#because">http://www.w3.org/2000/10/swap/reason#because</seealso>
    let because = Prefixed_Name(re, "because") |> PrefixedName
    /// <summary>
    ///   <para>re:component</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A step whose data was used in building this conjunction</para>
    /// labels<para>component</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/reason#component">http://www.w3.org/2000/10/swap/reason#component</seealso>
    let component_ = Prefixed_Name(re, "component") |> PrefixedName
    /// <summary>
    ///   <para>re:gives</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The proof step gives the formula as a result.
    /// 	For some steps, like extraction of a statement from a formula,
    /// 	it is essential to give the result formula in a proof to define
    /// 	what step has been taken.  For other steps, such as GMP inference,
    /// 	the specification of the rule and bindings defines the result,
    /// 	and so the proof can still be checked if the reason:gives ars</para>
    /// labels<para>gives</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/reason#gives">http://www.w3.org/2000/10/swap/reason#gives</seealso>
    let gives = Prefixed_Name(re, "gives") |> PrefixedName
    /// <summary>
    ///   <para>re:variable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>
    /// 	The given string is that used as the identifier of the variable
    /// 	which is bound by this binding.  The variable name has to be given as
    /// 	a string, rather than the variable being put here, or the variable
    /// 	would be treated as a variable.</para>
    /// labels<para>variable</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/reason#variable">http://www.w3.org/2000/10/swap/reason#variable</seealso>
    let variable = Prefixed_Name(re, "variable") |> PrefixedName
    /// <summary>
    ///   <para>re:Binding</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A binding is given eg in a proof or query result.
    /// 	The binding specifies which variable was bound (:variable),
    /// 	and what term it was bound to.
    /// 	</para>
    /// labels<para>binding</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/reason#Binding">http://www.w3.org/2000/10/swap/reason#Binding</seealso>
    let Binding = Prefixed_Name(re, "Binding") |> PrefixedName
    /// <summary>
    ///   <para>re:Conjunction</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>The step of conjunction introduction:
    /// 	taking a bunch of compent statements
    /// 	and building a formula from them.</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/reason#Conjunction">http://www.w3.org/2000/10/swap/reason#Conjunction</seealso>
    let Conjunction = Prefixed_Name(re, "Conjunction") |> PrefixedName
    /// <summary>
    ///   <para>re:Inference</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>GMP Inference</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/reason#Inference">http://www.w3.org/2000/10/swap/reason#Inference</seealso>
    let Inference = Prefixed_Name(re, "Inference") |> PrefixedName
    /// <summary>
    ///   <para>re:Proof</para>
    /// </summary>
    /// <remarks>
    ///   <para>A Proof step is the last step in the proof,
    /// 	a step which :gives that which was to be proved.
    /// 	Typically a document will assert just one :Proof,
    /// 	which a checker can then check and turn into
    /// 	the Formula proved - Q.E.D. .
    /// 	</para>
    /// labels<para>proof</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/reason#Proof">http://www.w3.org/2000/10/swap/reason#Proof</seealso>
    let Proof = Prefixed_Name(re, "Proof") |> PrefixedName
    /// <summary>
    ///   <para>re:Commandline</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/reason#Commandline">http://www.w3.org/2000/10/swap/reason#Commandline</seealso>
    let Commandline = Prefixed_Name(re, "Commandline") |> PrefixedName
    /// <summary>
    ///   <para>re:boundTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>
    /// 	This binding binds its variable to this term.
    /// 	</para>
    /// labels<para>bound to</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/reason#boundTo">http://www.w3.org/2000/10/swap/reason#boundTo</seealso>
    let boundTo = Prefixed_Name(re, "boundTo") |> PrefixedName
    /// <summary>
    ///   <para>re:evidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The :evidence for a GMP inference step is a list of
    ///     formulas, each proved by other means, which combined entail the
    ///     result of making the given substitution in the antecedent of the rule.</para>
    /// labels<para>antecedents</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/reason#evidence">http://www.w3.org/2000/10/swap/reason#evidence</seealso>
    let evidence = Prefixed_Name(re, "evidence") |> PrefixedName
    /// <summary>
    ///   <para>re:rule</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The inference step was performed using a rule (implication)
    ///     given.</para>
    /// labels<para>rule</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/reason#rule">http://www.w3.org/2000/10/swap/reason#rule</seealso>
    let rule = Prefixed_Name(re, "rule") |> PrefixedName
    /// <summary>
    ///   <para>re:source</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The source document which was parsed.
    /// 	</para>
    /// labels<para>source</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/reason#source">http://www.w3.org/2000/10/swap/reason#source</seealso>
    let source = Prefixed_Name(re, "source") |> PrefixedName
