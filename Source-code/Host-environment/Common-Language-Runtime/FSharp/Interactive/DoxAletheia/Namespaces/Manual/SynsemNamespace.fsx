#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\RDFErgonomics.fsx"
open RDFErgonomics

module synsem =

    let _prefix = prefix_label "synsem"

    let OntoMap = _prefix "OntoMap"


    let SyntacticArgument = _prefix "SyntacticArgument"


    /// A 'syntactic frame' represents the syntactic behavior of an open class word in terms of the (syntactic) arguments it requires. It essentially describes the so called subcategorization structure of the word in question, in particular the syntactic arguments it requires.
    let SyntacticFrame = _prefix "SyntacticFrame"


    /// The 'condition' property defines an evaluable constraint that derives from using a certain lexical entry to express a given ontological predicate.
    let condition = _prefix "condition"


    let isA = _prefix "isA"


    /// The 'marker' property indicates the marker of a syntactic argument; this can be a case marker or some other lexical entry such as a preposition or particle.
    let marker = _prefix "marker"


    /// The 'objOfProp' represents the 2nd argument or object of a binary predicate (property) in the ontology.
    let objOfProp = _prefix "objOfProp"


    let ontoCorrespondence = _prefix "ontoCorrespondence"


    /// The 'ontoMapping'  property relates an ontology mapping to its corresponding lexical sense.
    let ontoMapping = _prefix "ontoMapping"


    /// The 'optional' property indicates whether a syntactic argument is optional, that is, it can be syntactically omitted.
    let optional = _prefix "optional"


    let propertyDomain = _prefix "propertyDomain"


    /// 'Property domain' provides a pragmatic restriction on the range of the property referred to by this sense.
    let propertyRange = _prefix "propertyRange"


    let subjOfProp = _prefix "subjOfProp"


    /// The 'submap' property relates a (complex) ontological mapping to a set of bindings that together bind the arguments of the involved predicates to a set of syntactic arguments that realize them syntactically.
    let submap = _prefix "submap"


    /// The object property synArg relates a syntactic frame to one of its syntactic arguments.
    let synArg = _prefix "synArg"


    let synBehavior = _prefix "synBehavior"
