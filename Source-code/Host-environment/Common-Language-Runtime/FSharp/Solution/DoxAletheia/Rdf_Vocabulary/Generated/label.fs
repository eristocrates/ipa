namespace http.purl.org.net.vocab._2004._03.label.hash

open DoxAletheia.Rdf_Vocabulary

module label =
    let _namespace_name = "http://purl.org/net/vocab/2004/03/label#"

    /// <summary>
    /// A relation between a term and the label of its inverse in literal plural form
    /// <see href="http://purl.org/net/vocab/2004/03/label#inversePlural"></see></summary>
    let inversePlural =
        Namespaced_IRI.parse _namespace_name "inversePlural" |> NamespacedName

    /// <summary>
    /// A relation between a term and its label in literal plural form
    /// <see href="http://purl.org/net/vocab/2004/03/label#plural"></see></summary>
    let plural = Namespaced_IRI.parse _namespace_name "plural" |> NamespacedName
    /// <summary>
    /// A relation between a term and its label in literal singular form
    /// <see href="http://purl.org/net/vocab/2004/03/label#singular"></see></summary>
    let singular = Namespaced_IRI.parse _namespace_name "singular" |> NamespacedName

    /// <summary>
    /// A relation between a term and the label of its inverse in literal singular form
    /// <see href="http://purl.org/net/vocab/2004/03/label#inverseSingular"></see></summary>
    let inverseSingular =
        Namespaced_IRI.parse _namespace_name "inverseSingular" |> NamespacedName
