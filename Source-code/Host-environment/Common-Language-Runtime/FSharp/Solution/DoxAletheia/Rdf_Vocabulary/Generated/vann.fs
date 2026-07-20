namespace http.purl.org.vocab.vann.slash

open DoxAletheia

module vann =
    let _namespace_name = "http://purl.org/vocab/vann/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/vocab/vann/vann-vocab-20040305"></see>
    /// </summary>
    let ``vann-vocab-20040305`` = _prefix "vann-vocab-20040305"
    /// <summary>
    /// The preferred namespace prefix to use when using terms from this vocabulary in an XML document.
    /// <see href="http://purl.org/vocab/vann/preferredNamespacePrefix"></see></summary>
    let preferredNamespacePrefix = _prefix "preferredNamespacePrefix"
    /// <summary>
    /// The preferred namespace URI to use when using terms from this vocabulary in an XML document.
    /// <see href="http://purl.org/vocab/vann/preferredNamespaceUri"></see></summary>
    let preferredNamespaceUri = _prefix "preferredNamespaceUri"
    /// <summary>
    /// A reference to a resource that describes changes between this version of a vocabulary and the previous.
    /// <see href="http://purl.org/vocab/vann/changes"></see></summary>
    let changes = _prefix "changes"
    /// <summary>
    /// A reference to a resource that provides an example of how this resource can be used.
    /// <see href="http://purl.org/vocab/vann/example"></see></summary>
    let example = _prefix "example"
    /// <summary>
    /// A group of related terms in a vocabulary.
    /// <see href="http://purl.org/vocab/vann/termGroup"></see></summary>
    let termGroup = _prefix "termGroup"
    /// <summary>
    /// A reference to a resource that provides information on how this resource is to be used.
    /// <see href="http://purl.org/vocab/vann/usageNote"></see></summary>
    let usageNote = _prefix "usageNote"
