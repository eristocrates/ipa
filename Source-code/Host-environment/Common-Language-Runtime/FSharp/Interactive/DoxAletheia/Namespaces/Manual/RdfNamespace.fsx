#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\RDFErgonomics.fsx"
open RDFErgonomics

module rdf =
    let _prefix = prefix_label "rdf"


    /// The class of containers of alternatives.
    let Alt = _prefix "Alt"


    /// The class of unordered containers.
    let Bag = _prefix "Bag"


    /// A class representing a compound literal.
    let CompoundLiteral = _prefix "CompoundLiteral"


    /// The datatype of RDF literals storing fragments of HTML content
    let HTML = _prefix "HTML"


    /// The datatype of RDF literals storing JSON content.
    let JSON = _prefix "JSON"


    /// The class of RDF Lists.
    let List = _prefix "List"


    /// The class of plain (i.e. untyped) literal values, as used in RIF and OWL 2
    let PlainLiteral = _prefix "PlainLiteral"


    /// The class of RDF properties.
    let Property = _prefix "Property"


    /// The class of ordered containers.
    let Seq = _prefix "Seq"


    /// The class of RDF statements.
    let Statement = _prefix "Statement"


    /// The datatype of XML literal values.
    let XMLLiteral = _prefix "XMLLiteral"


    /// The base direction component of a CompoundLiteral.
    let direction = _prefix "direction"


    /// The first item in the subject RDF list.
    let first = _prefix "first"


    /// The datatype of language-tagged string values
    let langString = _prefix "langString"


    /// The language component of a CompoundLiteral.
    let language = _prefix "language"


    /// The empty list, with no items in it. If the rest of a list is nil then the list has no more items in it.
    let nil = _prefix "nil"


    /// The object of the subject RDF statement.
    let object = _prefix "object"


    /// The predicate of the subject RDF statement.
    let predicate = _prefix "predicate"


    /// The rest of the subject RDF list after the first item.
    let rest = _prefix "rest"


    /// The subject of the subject RDF statement.
    let subject = _prefix "subject"


    /// The subject is an instance of a class.
    let ``type`` = _prefix "type"


    /// Idiomatic property used for structured values.
    let value = _prefix "value"

let a = rdf.``type``
