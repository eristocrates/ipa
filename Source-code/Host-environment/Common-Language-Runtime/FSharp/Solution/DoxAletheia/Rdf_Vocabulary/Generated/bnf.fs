namespace http.www.w3.org._2000._10.swap.grammar.bnf.hash

open DoxAletheia

module bnf =
    let _namespace_name = "http://www.w3.org/2000/10/swap/grammar/bnf#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A terminal, aka atomic, production,
    /// 	defined as string or regexp
    /// <see href="http://www.w3.org/2000/10/swap/grammar/bnf#Token"></see></summary>
    let Token = _prefix "Token"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/grammar/bnf#Production"></see>
    /// </summary>
    let Production = _prefix "Production"
    /// <summary>
    /// The production can only start with the given
    /// 		representative character. In the case that a token starts
    /// 		with always the same character, that is the one given.
    /// 		In th eevent that it can start with alpha character, 'a'
    /// 		is given; if it can start with a numeric, '0' is given
    /// 		as the value for this predicate.  This predicate is used
    /// 		only when a predictive parser is possible and desired.
    /// <see href="http://www.w3.org/2000/10/swap/grammar/bnf#canStartWith"></see></summary>
    let canStartWith = _prefix "canStartWith"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/grammar/bnf#String"></see>
    /// </summary>
    let String = _prefix "String"

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/grammar/bnf#commaSeparatedPeriodTerminatedListOf"></see>
    /// </summary>
    let commaSeparatedPeriodTerminatedListOf =
        _prefix "commaSeparatedPeriodTerminatedListOf"

    /// <summary>
    /// The given token is defined by the
    /// 		regular expression which a token must match
    /// <see href="http://www.w3.org/2000/10/swap/grammar/bnf#matches"></see></summary>
    let matches = _prefix "matches"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/grammar/bnf#RegularExpression"></see>
    /// </summary>
    let RegularExpression = _prefix "RegularExpression"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/grammar/bnf#mustBe"></see>
    /// </summary>
    let mustBe = _prefix "mustBe"
    /// <summary>
    /// This is the core property you need to define a BNF production.
    /// It defines the list of the only sequences to which a given
    /// term may expand.  Each sequence is just a list of other productions in order.
    ///
    /// <see href="http://www.w3.org/2000/10/swap/grammar/bnf#mustBeOneSequence"></see></summary>
    let mustBeOneSequence = _prefix "mustBeOneSequence"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/grammar/bnf#ListOfSequencesOfProductions"></see>
    /// </summary>
    let ListOfSequencesOfProductions = _prefix "ListOfSequencesOfProductions"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/grammar/bnf#zeroOrMore"></see>
    /// </summary>
    let zeroOrMore = _prefix "zeroOrMore"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/grammar/bnf#Term"></see>
    /// </summary>
    let Term = _prefix "Term"
