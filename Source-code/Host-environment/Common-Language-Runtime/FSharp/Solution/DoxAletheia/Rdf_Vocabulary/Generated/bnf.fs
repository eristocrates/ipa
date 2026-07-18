namespace http.www.w3.org._2000._10.swap.grammar.bnf.hash

open DoxAletheia.Rdf_Vocabulary

module bnf =
    let _namespace_name = "http://www.w3.org/2000/10/swap/grammar/bnf#"
    /// <summary>
    /// A terminal, aka atomic, production,
    /// 	defined as string or regexp
    /// <see href="http://www.w3.org/2000/10/swap/grammar/bnf#Token"></see></summary>
    let Token = Namespaced_IRI.parse _namespace_name "Token" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/grammar/bnf#Production"></see>
    /// </summary>
    let Production = Namespaced_IRI.parse _namespace_name "Production" |> NamespacedName

    /// <summary>
    /// The production can only start with the given
    /// 		representative character. In the case that a token starts
    /// 		with always the same character, that is the one given.
    /// 		In th eevent that it can start with alpha character, 'a'
    /// 		is given; if it can start with a numeric, '0' is given
    /// 		as the value for this predicate.  This predicate is used
    /// 		only when a predictive parser is possible and desired.
    /// <see href="http://www.w3.org/2000/10/swap/grammar/bnf#canStartWith"></see></summary>
    let canStartWith =
        Namespaced_IRI.parse _namespace_name "canStartWith" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/grammar/bnf#String"></see>
    /// </summary>
    let String = Namespaced_IRI.parse _namespace_name "String" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/grammar/bnf#commaSeparatedPeriodTerminatedListOf"></see>
    /// </summary>
    let commaSeparatedPeriodTerminatedListOf =
        Namespaced_IRI.parse _namespace_name "commaSeparatedPeriodTerminatedListOf" |> NamespacedName

    /// <summary>
    /// The given token is defined by the
    /// 		regular expression which a token must match
    /// <see href="http://www.w3.org/2000/10/swap/grammar/bnf#matches"></see></summary>
    let matches = Namespaced_IRI.parse _namespace_name "matches" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/grammar/bnf#RegularExpression"></see>
    /// </summary>
    let RegularExpression =
        Namespaced_IRI.parse _namespace_name "RegularExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/grammar/bnf#mustBe"></see>
    /// </summary>
    let mustBe = Namespaced_IRI.parse _namespace_name "mustBe" |> NamespacedName

    /// <summary>
    /// This is the core property you need to define a BNF production.
    /// It defines the list of the only sequences to which a given
    /// term may expand.  Each sequence is just a list of other productions in order.
    ///
    /// <see href="http://www.w3.org/2000/10/swap/grammar/bnf#mustBeOneSequence"></see></summary>
    let mustBeOneSequence =
        Namespaced_IRI.parse _namespace_name "mustBeOneSequence" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/grammar/bnf#ListOfSequencesOfProductions"></see>
    /// </summary>
    let ListOfSequencesOfProductions =
        Namespaced_IRI.parse _namespace_name "ListOfSequencesOfProductions" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/grammar/bnf#zeroOrMore"></see>
    /// </summary>
    let zeroOrMore = Namespaced_IRI.parse _namespace_name "zeroOrMore" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/grammar/bnf#Term"></see>
    /// </summary>
    let Term = Namespaced_IRI.parse _namespace_name "Term" |> NamespacedName
