namespace http.purl.org.net.vocab._2004._03.label.hash

open DoxAletheia

module label =
    let _namespace_name = "http://purl.org/net/vocab/2004/03/label#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A relation between a term and the label of its inverse in literal plural form
    /// <see href="http://purl.org/net/vocab/2004/03/label#inversePlural"></see></summary>
    let inversePlural = _prefix "inversePlural"
    /// <summary>
    /// A relation between a term and its label in literal plural form
    /// <see href="http://purl.org/net/vocab/2004/03/label#plural"></see></summary>
    let plural = _prefix "plural"
    /// <summary>
    /// A relation between a term and its label in literal singular form
    /// <see href="http://purl.org/net/vocab/2004/03/label#singular"></see></summary>
    let singular = _prefix "singular"
    /// <summary>
    /// A relation between a term and the label of its inverse in literal singular form
    /// <see href="http://purl.org/net/vocab/2004/03/label#inverseSingular"></see></summary>
    let inverseSingular = _prefix "inverseSingular"
