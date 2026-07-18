namespace http.www.w3.org._1999._02._22_rdf_syntax_ns.hash

open DoxAletheia.Rdf_Vocabulary

module rdf =
    let _namespace_name = "http://www.w3.org/1999/02/22-rdf-syntax-ns#"
    /// <summary>
    /// The subject is an instance of a class.
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#type"></see></summary>
    let type_ = Namespaced_IRI.parse _namespace_name "type" |> NamespacedName
    /// <summary>
    /// The class of containers of alternatives.
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Alt"></see></summary>
    let Alt = Namespaced_IRI.parse _namespace_name "Alt" |> NamespacedName
    /// <summary>
    /// The class of unordered containers.
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Bag"></see></summary>
    let Bag = Namespaced_IRI.parse _namespace_name "Bag" |> NamespacedName

    /// <summary>
    /// A class representing a compound literal.
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#CompoundLiteral"></see></summary>
    let CompoundLiteral =
        Namespaced_IRI.parse _namespace_name "CompoundLiteral" |> NamespacedName

    /// <summary>
    /// The datatype of RDF literals storing fragments of HTML content
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#HTML"></see></summary>
    let HTML = Namespaced_IRI.parse _namespace_name "HTML" |> NamespacedName
    /// <summary>
    /// The datatype of RDF literals storing JSON content.
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#JSON"></see></summary>
    let JSON = Namespaced_IRI.parse _namespace_name "JSON" |> NamespacedName
    /// <summary>
    /// The class of RDF Lists.
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#List"></see></summary>
    let List = Namespaced_IRI.parse _namespace_name "List" |> NamespacedName

    /// <summary>
    /// The class of plain (i.e. untyped) literal values, as used in RIF and OWL 2
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral"></see></summary>
    let PlainLiteral =
        Namespaced_IRI.parse _namespace_name "PlainLiteral" |> NamespacedName

    /// <summary>
    /// The class of RDF properties.
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Property"></see></summary>
    let Property = Namespaced_IRI.parse _namespace_name "Property" |> NamespacedName
    /// <summary>
    /// The class of ordered containers.
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Seq"></see></summary>
    let Seq = Namespaced_IRI.parse _namespace_name "Seq" |> NamespacedName
    /// <summary>
    /// The class of RDF statements.
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#Statement"></see></summary>
    let Statement = Namespaced_IRI.parse _namespace_name "Statement" |> NamespacedName
    /// <summary>
    /// The datatype of XML literal values.
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#XMLLiteral"></see></summary>
    let XMLLiteral = Namespaced_IRI.parse _namespace_name "XMLLiteral" |> NamespacedName
    /// <summary>
    /// The base direction component of a CompoundLiteral.
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#direction"></see></summary>
    let direction = Namespaced_IRI.parse _namespace_name "direction" |> NamespacedName
    /// <summary>
    /// The first item in the subject RDF list.
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#first"></see></summary>
    let first = Namespaced_IRI.parse _namespace_name "first" |> NamespacedName
    /// <summary>
    /// The datatype of language-tagged string values
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#langString"></see></summary>
    let langString = Namespaced_IRI.parse _namespace_name "langString" |> NamespacedName
    /// <summary>
    /// The language component of a CompoundLiteral.
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#language"></see></summary>
    let language = Namespaced_IRI.parse _namespace_name "language" |> NamespacedName
    /// <summary>
    /// The empty list, with no items in it. If the rest of a list is nil then the list has no more items in it.
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#nil"></see></summary>
    let nil = Namespaced_IRI.parse _namespace_name "nil" |> NamespacedName
    /// <summary>
    /// The object of the subject RDF statement.
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#object"></see></summary>
    let object = Namespaced_IRI.parse _namespace_name "object" |> NamespacedName
    /// <summary>
    /// The predicate of the subject RDF statement.
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#predicate"></see></summary>
    let predicate = Namespaced_IRI.parse _namespace_name "predicate" |> NamespacedName
    /// <summary>
    /// The rest of the subject RDF list after the first item.
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#rest"></see></summary>
    let rest = Namespaced_IRI.parse _namespace_name "rest" |> NamespacedName
    /// <summary>
    /// The subject of the subject RDF statement.
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#subject"></see></summary>
    let subject = Namespaced_IRI.parse _namespace_name "subject" |> NamespacedName
    /// <summary>
    /// Idiomatic property used for structured values.
    /// <see href="http://www.w3.org/1999/02/22-rdf-syntax-ns#value"></see></summary>
    let value = Namespaced_IRI.parse _namespace_name "value" |> NamespacedName
