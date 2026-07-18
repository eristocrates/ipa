namespace http.purl.org.net.ns.ex.hash

open DoxAletheia.Rdf_Vocabulary

module ex =
    let _namespace_name = "http://purl.org/net/ns/ex#"
    /// <summary>
    /// Has an example code of an RDF/XML statements that use the schema. Content may be CDATA section or rdf:parseType="Literal".
    /// <see href="http://purl.org/net/ns/ex#code"></see></summary>
    let code = Namespaced_IRI.parse _namespace_name "code" |> NamespacedName
    /// <summary>
    /// The subject is an example of the object vocabulary.
    /// <see href="http://purl.org/net/ns/ex#exampleOf"></see></summary>
    let exampleOf = Namespaced_IRI.parse _namespace_name "exampleOf" |> NamespacedName
    /// <summary>
    /// A prefix used in the example to represent the schema namespace. A rendaring application may use this value to distinguish target terms in the example.
    /// <see href="http://purl.org/net/ns/ex#pfx"></see></summary>
    let pfx = Namespaced_IRI.parse _namespace_name "pfx" |> NamespacedName
    /// <summary>
    /// A class represents one example.
    /// <see href="http://purl.org/net/ns/ex#Example"></see></summary>
    let Example = Namespaced_IRI.parse _namespace_name "Example" |> NamespacedName
    /// <summary>
    /// The subject has an Example. Use to include example(s) in a term definition.
    /// <see href="http://purl.org/net/ns/ex#example"></see></summary>
    let example = Namespaced_IRI.parse _namespace_name "example" |> NamespacedName
    /// <summary>
    /// A pointer to an image that helps to understand the vocabulary.
    /// <see href="http://purl.org/net/ns/ex#image"></see></summary>
    let image = Namespaced_IRI.parse _namespace_name "image" |> NamespacedName
    /// <summary>
    /// A pointer to a real example or a trial page.
    /// <see href="http://purl.org/net/ns/ex#trial"></see></summary>
    let trial = Namespaced_IRI.parse _namespace_name "trial" |> NamespacedName
