namespace http.purl.org.vsearch.slash

open DoxAletheia.Rdf_Vocabulary

module vsearch =
    let _namespace_name = "http://purl.org/vsearch/"
    /// <summary>
    /// A query.
    /// <see href="http://purl.org/vsearch/Query"></see></summary>
    let Query = Namespaced_IRI.parse _namespace_name "Query" |> NamespacedName
    /// <summary>
    /// A result term.
    /// <see href="http://purl.org/vsearch/ResultTerm"></see></summary>
    let ResultTerm = Namespaced_IRI.parse _namespace_name "ResultTerm" |> NamespacedName
    /// <summary>
    /// A query that an entity executes.
    /// <see href="http://purl.org/vsearch/doQuery"></see></summary>
    let doQuery = Namespaced_IRI.parse _namespace_name "doQuery" |> NamespacedName
    /// <summary>
    /// The rank for a result term.
    /// <see href="http://purl.org/vsearch/hasRank"></see></summary>
    let hasRank = Namespaced_IRI.parse _namespace_name "hasRank" |> NamespacedName

    /// <summary>
    /// A result term for a query.
    /// <see href="http://purl.org/vsearch/hasResultTerm"></see></summary>
    let hasResultTerm =
        Namespaced_IRI.parse _namespace_name "hasResultTerm" |> NamespacedName

    /// <summary>
    /// The keyword of the query.
    /// <see href="http://purl.org/vsearch/keyword"></see></summary>
    let keyword = Namespaced_IRI.parse _namespace_name "keyword" |> NamespacedName
    /// <summary>
    /// The language of the query keyword.
    /// <see href="http://purl.org/vsearch/language"></see></summary>
    let language = Namespaced_IRI.parse _namespace_name "language" |> NamespacedName
    /// <summary>
    /// The rank value of a term's ranking.
    /// <see href="http://purl.org/vsearch/rankValue"></see></summary>
    let rankValue = Namespaced_IRI.parse _namespace_name "rankValue" |> NamespacedName
    /// <summary>
    /// The URI of the result term.
    /// <see href="http://purl.org/vsearch/termURI"></see></summary>
    let termURI = Namespaced_IRI.parse _namespace_name "termURI" |> NamespacedName
