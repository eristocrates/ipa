namespace http.purl.org.vocab.vann.slash

open DoxAletheia.Rdf_Vocabulary

module vann =
    let _namespace_name = "http://purl.org/vocab/vann/"

    /// <summary>
    ///   <see href="http://purl.org/vocab/vann/vann-vocab-20040305"></see>
    /// </summary>
    let ``vann-vocab-20040305`` =
        Namespaced_IRI.parse _namespace_name "vann-vocab-20040305" |> NamespacedName

    /// <summary>
    /// The preferred namespace prefix to use when using terms from this vocabulary in an XML document.
    /// <see href="http://purl.org/vocab/vann/preferredNamespacePrefix"></see></summary>
    let preferredNamespacePrefix =
        Namespaced_IRI.parse _namespace_name "preferredNamespacePrefix" |> NamespacedName

    /// <summary>
    /// The preferred namespace URI to use when using terms from this vocabulary in an XML document.
    /// <see href="http://purl.org/vocab/vann/preferredNamespaceUri"></see></summary>
    let preferredNamespaceUri =
        Namespaced_IRI.parse _namespace_name "preferredNamespaceUri" |> NamespacedName

    /// <summary>
    /// A reference to a resource that describes changes between this version of a vocabulary and the previous.
    /// <see href="http://purl.org/vocab/vann/changes"></see></summary>
    let changes = Namespaced_IRI.parse _namespace_name "changes" |> NamespacedName
    /// <summary>
    /// A reference to a resource that provides an example of how this resource can be used.
    /// <see href="http://purl.org/vocab/vann/example"></see></summary>
    let example = Namespaced_IRI.parse _namespace_name "example" |> NamespacedName
    /// <summary>
    /// A group of related terms in a vocabulary.
    /// <see href="http://purl.org/vocab/vann/termGroup"></see></summary>
    let termGroup = Namespaced_IRI.parse _namespace_name "termGroup" |> NamespacedName
    /// <summary>
    /// A reference to a resource that provides information on how this resource is to be used.
    /// <see href="http://purl.org/vocab/vann/usageNote"></see></summary>
    let usageNote = Namespaced_IRI.parse _namespace_name "usageNote" |> NamespacedName
