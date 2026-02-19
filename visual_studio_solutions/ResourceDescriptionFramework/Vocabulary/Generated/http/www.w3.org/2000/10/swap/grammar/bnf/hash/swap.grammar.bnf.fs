namespace Swap.grammar.bnf.Namespace
module bnf =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.w3.org/2000/10/swap/grammar/bnf#" (Some "http://www.w3.org/2000/10/swap/grammar/bnf") (Some "swap.grammar.bnf") None
    let ListOfSequencesOfProductions = {_prefixID with _localName = "ListOfSequencesOfProductions"}
    let Production = {_prefixID with _localName = "Production"}
    let RegularExpression = {_prefixID with _localName = "RegularExpression"}
    let String = {_prefixID with _localName = "String"}
    let Term = {_prefixID with _localName = "Term"}
    let Token = {_prefixID with _localName = "Token"}
    let canStartWith = {_prefixID with _localName = "canStartWith"}
    let commaSeparatedPeriodTerminatedListOf = {_prefixID with _localName = "commaSeparatedPeriodTerminatedListOf"}
    let matches = {_prefixID with _localName = "matches"}
    let mustBe = {_prefixID with _localName = "mustBe"}
    let mustBeOneSequence = {_prefixID with _localName = "mustBeOneSequence"}
    let zeroOrMore = {_prefixID with _localName = "zeroOrMore"}