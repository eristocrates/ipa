#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\RDFErgonomics.fsx"
open RDFErgonomics

module rdf =
    let prefix = prefix_label "rdf"

    /// 	rdfs:comment "The datatype of RDF literals storing fragments of HTML content" .
    let HTML = prefix "HTML"
    /// 	rdfs:comment "The datatype of language-tagged string values" .
    let langString = prefix "langString"
    let dirLangString = prefix "dirLangString"
    /// 	rdfs:comment "The class of plain (i.e. untyped) literal values, as used in RIF and OWL 2" .
    let PlainLiteral = prefix "PlainLiteral"
    /// 	rdfs:comment "The subject is an instance of a class." ;
    let ``type`` = prefix "type"
    /// 	rdfs:comment "The class of RDF properties." ;
    let Property = prefix "Property"
    /// 	rdfs:comment "The class of RDF statements." .
    let Statement = prefix "Statement"
    /// 	rdfs:comment "The subject of the subject RDF statement." ;
    let subject = prefix "subject"
    /// 	rdfs:comment "The predicate of the subject RDF statement." ;
    let predicate = prefix "predicate"
    /// 	rdfs:comment "The object of the subject RDF statement." ;
    let object = prefix "object"
    /// 	rdfs:comment "The class of unordered containers." ;
    let Bag = prefix "Bag"
    /// 	rdfs:comment "The class of ordered containers." ;
    let Seq = prefix "Seq"
    /// 	rdfs:comment "The class of containers of alternatives." ;
    let Alt = prefix "Alt"
    /// 	rdfs:comment "Idiomatic property used for structured values." ;
    let value = prefix "value"
    /// 	rdfs:comment "The class of RDF Lists." ;
    let List = prefix "List"
    /// 	rdfs:comment "The empty list, with no items in it. If the rest of a list is nil then the list has no more items in it." .
    let nil = prefix "nil"
    /// 	rdfs:comment "The first item in the subject RDF list." ;
    let first = prefix "first"
    /// 	rdfs:comment "The rest of the subject RDF list after the first item." ;
    let rest = prefix "rest"
    /// 	rdfs:comment "The datatype of XML literal values." .
    let XMLLiteral = prefix "XMLLiteral"
    /// 	rdfs:comment "The datatype of RDF literals storing JSON content." ;
    let JSON = prefix "JSON"
    /// 	rdfs:comment "A class representing a compound literal." ;
    let CompoundLiteral = prefix "CompoundLiteral"
    /// 	rdfs:comment "The language component of a CompoundLiteral." ;
    let language = prefix "language"
    /// 	rdfs:comment "The base direction component of a CompoundLiteral." ;
    let direction = prefix "direction"

let a = rdf.``type``
