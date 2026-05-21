#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\RDFErgonomics.fsx"
open RDFErgonomics

module lexicog =

    let _prefix = prefix_label "lexicog"

    /// An entry is a structural element that represents a lexicographic article or record as it is arranged in a source lexicographic resource. As such, it supports the description of lexical entries or senses according to the lexicographic micro-structure, decided upon during a lexicographic resource compilation process.
    let Entry = _prefix "Entry"


    /// Er zijn gevallen waarin een gegeven ontolex:LexicalSense niet voorkomt met alle mogelijke ontolex:Form(s) van de ontolex:LexicalEntry. In zulke gevallen representeert de klasse FormRestriction (een set van) grammaticale kenmerken van de ontolex:Form(s) waarin die zin voorkomt. De zin komt niet voor in de vormen waarvan de kenmerken niet voldoen aan die aangegeven door de vastgelegde set.
    let FormRestriction = _prefix "FormRestriction"


    /// A lexicographic component is a structural element that represents the (sub-)structures of lexicographic articles providing information about lexical entries, senses or sub-entries. If desired, lexicographic components can be arranged in a specific order and/or hierarchy.
    let LexicographicComponent = _prefix "LexicographicComponent"


    /// A lexicographic resource represents a collection of lexicographic entries (lexicog:Entry) in accord with the lexicographic criteria followed in the development of that resource.
    let LexicographicResource = _prefix "LexicographicResource"


    /// De klasse UsageExample representeert een tekstueel voorbeeld van het gebruik van een zin binnen een gegeven lexicografisch item. Een gebruiksvoorbeeld kan verscheidene tekstwaardes groeperen, waarbij deze waardes dezelfde betekenis duiden. Indien zulke waardes in verschillende talen zijn vastgelegd, kunnen ze dus ge�nterpreteerd worden als vertalingen van elkaar.
    let UsageExample = _prefix "UsageExample"


    /// De relatie "describes" relateert een lexicografisch component aan een element dat de daadwerkelijke informatie representeert dat is vastgelegd in het desbetreffende component in het lexicografisch werk. In de meeste gevallen zal deze informatie lexicaal van aard zijn, en zal de relatie dus verwijzen naar een instantie van ontolex:LexicalEntry of ontolex:LexicalSense.
    let describes = _prefix "describes"


    /// De relatie "entry" relateert een lexicografisch werk aan een item (of 'record' in de literatuur).
    let entry = _prefix "entry"


    /// De relatie "restrictedTo" relateert een LexicalSense aan een FormRestriction wanneer een lexicografisch werk informatie verschaft over de specifieke morfologische kenmerken van de ontolex:Form in de desbetreffende zin.
    let restrictedTo = _prefix "restrictedTo"


    /// De relatie "subComponent" relateert een lexicografisch component aan een ander lexicografisch component welke hierarchisch ondergeschikt is.
    let subComponent = _prefix "subComponent"


    /// De relatie usageExample relateert een ontolex:LexicalSense aan een lexciog:UsageExample.
    let usageExample = _prefix "usageExample"
