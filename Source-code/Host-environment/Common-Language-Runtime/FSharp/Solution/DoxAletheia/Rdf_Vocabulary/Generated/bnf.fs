namespace http.www.w3.org._2000._10.swap.grammar.bnf.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module bnf =
    let _namespace_iri = Namespace_Iri bnf |> NamespaceIRI

    /// <summary>
    ///   <para>bnf:ListOfSequencesOfProductions</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/grammar/bnf#ListOfSequencesOfProductions">http://www.w3.org/2000/10/swap/grammar/bnf#ListOfSequencesOfProductions</seealso>
    let ListOfSequencesOfProductions =
        Prefixed_Name(bnf, "ListOfSequencesOfProductions") |> PrefixedName

    /// <summary>
    ///   <para>bnf:Production</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/grammar/bnf#Production">http://www.w3.org/2000/10/swap/grammar/bnf#Production</seealso>
    let Production = Prefixed_Name(bnf, "Production") |> PrefixedName
    /// <summary>
    ///   <para>bnf:RegularExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/grammar/bnf#RegularExpression">http://www.w3.org/2000/10/swap/grammar/bnf#RegularExpression</seealso>
    let RegularExpression = Prefixed_Name(bnf, "RegularExpression") |> PrefixedName
    /// <summary>
    ///   <para>bnf:String</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/grammar/bnf#String">http://www.w3.org/2000/10/swap/grammar/bnf#String</seealso>
    let String = Prefixed_Name(bnf, "String") |> PrefixedName
    /// <summary>
    ///   <para>bnf:Term</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/grammar/bnf#Term">http://www.w3.org/2000/10/swap/grammar/bnf#Term</seealso>
    let Term = Prefixed_Name(bnf, "Term") |> PrefixedName
    /// <summary>
    ///   <para>bnf:Token</para>
    /// </summary>
    /// <remarks>
    ///   <para>"A terminal, aka atomic, production,
    /// 	defined as string or regexp"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"token"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/grammar/bnf#Token">http://www.w3.org/2000/10/swap/grammar/bnf#Token</seealso>
    let Token = Prefixed_Name(bnf, "Token") |> PrefixedName
    /// <summary>
    ///   <para>bnf:canStartWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The production can only start with the given
    /// 		representative character. In the case that a token starts
    /// 		with always the same character, that is the one given.
    /// 		In th eevent that it can start with alpha character, 'a'
    /// 		is given; if it can start with a numeric, '0' is given
    /// 		as the value for this predicate.  This predicate is used
    /// 		only when a predictive parser is possible and desired."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"can start with"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/grammar/bnf#canStartWith">http://www.w3.org/2000/10/swap/grammar/bnf#canStartWith</seealso>
    let canStartWith = Prefixed_Name(bnf, "canStartWith") |> PrefixedName

    /// <summary>
    ///   <para>bnf:commaSeparatedPeriodTerminatedListOf</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"comma-separated period-terminated list of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/grammar/bnf#commaSeparatedPeriodTerminatedListOf">http://www.w3.org/2000/10/swap/grammar/bnf#commaSeparatedPeriodTerminatedListOf</seealso>
    let commaSeparatedPeriodTerminatedListOf =
        Prefixed_Name(bnf, "commaSeparatedPeriodTerminatedListOf") |> PrefixedName

    /// <summary>
    ///   <para>bnf:matches</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The given token is defined by the
    /// 		regular expression which a token must match"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"matches"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/grammar/bnf#matches">http://www.w3.org/2000/10/swap/grammar/bnf#matches</seealso>
    let matches = Prefixed_Name(bnf, "matches") |> PrefixedName
    /// <summary>
    ///   <para>bnf:mustBe</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/grammar/bnf#mustBe">http://www.w3.org/2000/10/swap/grammar/bnf#mustBe</seealso>
    let mustBe = Prefixed_Name(bnf, "mustBe") |> PrefixedName
    /// <summary>
    ///   <para>bnf:mustBeOneSequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This is the core property you need to define a BNF production.
    /// It defines the list of the only sequences to which a given
    /// term may expand.  Each sequence is just a list of other productions in order.
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"productions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/grammar/bnf#mustBeOneSequence">http://www.w3.org/2000/10/swap/grammar/bnf#mustBeOneSequence</seealso>
    let mustBeOneSequence = Prefixed_Name(bnf, "mustBeOneSequence") |> PrefixedName
    /// <summary>
    ///   <para>bnf:zeroOrMore</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"zero or more"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/grammar/bnf#zeroOrMore">http://www.w3.org/2000/10/swap/grammar/bnf#zeroOrMore</seealso>
    let zeroOrMore = Prefixed_Name(bnf, "zeroOrMore") |> PrefixedName
