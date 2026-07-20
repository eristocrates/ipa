namespace http.purl.org.vsearch.slash

open DoxAletheia

module vsearch =
    let _namespace_name = "http://purl.org/vsearch/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A query.
    /// <see href="http://purl.org/vsearch/Query"></see></summary>
    let Query = _prefix "Query"
    /// <summary>
    /// A result term.
    /// <see href="http://purl.org/vsearch/ResultTerm"></see></summary>
    let ResultTerm = _prefix "ResultTerm"
    /// <summary>
    /// A query that an entity executes.
    /// <see href="http://purl.org/vsearch/doQuery"></see></summary>
    let doQuery = _prefix "doQuery"
    /// <summary>
    /// The rank for a result term.
    /// <see href="http://purl.org/vsearch/hasRank"></see></summary>
    let hasRank = _prefix "hasRank"
    /// <summary>
    /// A result term for a query.
    /// <see href="http://purl.org/vsearch/hasResultTerm"></see></summary>
    let hasResultTerm = _prefix "hasResultTerm"
    /// <summary>
    /// The keyword of the query.
    /// <see href="http://purl.org/vsearch/keyword"></see></summary>
    let keyword = _prefix "keyword"
    /// <summary>
    /// The language of the query keyword.
    /// <see href="http://purl.org/vsearch/language"></see></summary>
    let language = _prefix "language"
    /// <summary>
    /// The rank value of a term's ranking.
    /// <see href="http://purl.org/vsearch/rankValue"></see></summary>
    let rankValue = _prefix "rankValue"
    /// <summary>
    /// The URI of the result term.
    /// <see href="http://purl.org/vsearch/termURI"></see></summary>
    let termURI = _prefix "termURI"
