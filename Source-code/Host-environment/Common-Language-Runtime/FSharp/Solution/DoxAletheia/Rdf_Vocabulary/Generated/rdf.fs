namespace http.www.w3.org._1999._02._22_rdf_syntax_ns.hash

open DoxAletheia

module rdf =
    let _namespace_name = "http://www.w3.org/1999/02/22-rdf-syntax-ns#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The subject is an instance of a class.
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#type"></see></summary>
    let type_ = _prefix "type"
    /// <summary>
    /// The class of containers of alternatives.
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Alt"></see></summary>
    let Alt = _prefix "Alt"
    /// <summary>
    /// The class of unordered containers.
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Bag"></see></summary>
    let Bag = _prefix "Bag"
    /// <summary>
    /// A class representing a compound literal.
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#CompoundLiteral"></see></summary>
    let CompoundLiteral = _prefix "CompoundLiteral"
    /// <summary>
    /// The datatype of RDF literals storing fragments of HTML content
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#HTML"></see></summary>
    let HTML = _prefix "HTML"
    /// <summary>
    /// The datatype of RDF literals storing JSON content.
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#JSON"></see></summary>
    let JSON = _prefix "JSON"
    /// <summary>
    /// The class of RDF Lists.
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#List"></see></summary>
    let List = _prefix "List"
    /// <summary>
    /// The class of plain (i.e. untyped) literal values, as used in RIF and OWL 2
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral"></see></summary>
    let PlainLiteral = _prefix "PlainLiteral"
    /// <summary>
    /// The class of RDF properties.
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Property"></see></summary>
    let Property = _prefix "Property"
    /// <summary>
    /// The class of ordered containers.
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Seq"></see></summary>
    let Seq = _prefix "Seq"
    /// <summary>
    /// The class of RDF statements.
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Statement"></see></summary>
    let Statement = _prefix "Statement"
    /// <summary>
    /// The datatype of XML literal values.
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#XMLLiteral"></see></summary>
    let XMLLiteral = _prefix "XMLLiteral"
    /// <summary>
    /// The base direction component of a CompoundLiteral.
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#direction"></see></summary>
    let direction = _prefix "direction"
    /// <summary>
    /// The first item in the subject RDF list.
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#first"></see></summary>
    let first = _prefix "first"
    /// <summary>
    /// The datatype of language-tagged string values
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#langString"></see></summary>
    let langString = _prefix "langString"
    /// <summary>
    /// The language component of a CompoundLiteral.
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#language"></see></summary>
    let language = _prefix "language"
    /// <summary>
    /// The empty list, with no items in it. If the rest of a list is nil then the list has no more items in it.
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#nil"></see></summary>
    let nil = _prefix "nil"
    /// <summary>
    /// The object of the subject RDF statement.
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#object"></see></summary>
    let object = _prefix "object"
    /// <summary>
    /// The predicate of the subject RDF statement.
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#predicate"></see></summary>
    let predicate = _prefix "predicate"
    /// <summary>
    /// The rest of the subject RDF list after the first item.
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#rest"></see></summary>
    let rest = _prefix "rest"
    /// <summary>
    /// The subject of the subject RDF statement.
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#subject"></see></summary>
    let subject = _prefix "subject"
    /// <summary>
    /// Idiomatic property used for structured values.
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#value"></see></summary>
    let value = _prefix "value"
