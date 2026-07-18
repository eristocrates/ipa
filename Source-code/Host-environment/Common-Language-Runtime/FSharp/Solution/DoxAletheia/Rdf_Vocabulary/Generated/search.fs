namespace http.sindice.com.vocab.search.hash

open DoxAletheia.Rdf_Vocabulary

module search =
    let _namespace_name = "http://sindice.com/vocab/search#"
    /// <summary>
    /// A page in a paged list of search results
    /// <see href="http://sindice.com/vocab/search#Page"></see></summary>
    let Page = Namespaced_IRI.parse _namespace_name "Page" |> NamespacedName
    /// <summary>
    /// A search query
    /// <see href="http://sindice.com/vocab/search#Query"></see></summary>
    let Query = Namespaced_IRI.parse _namespace_name "Query" |> NamespacedName
    /// <summary>
    /// An individual result in a list of ranked search results to a search query
    /// <see href="http://sindice.com/vocab/search#Result"></see></summary>
    let Result = Namespaced_IRI.parse _namespace_name "Result" |> NamespacedName
    /// <summary>
    /// Link to a cached copy of a search result
    /// <see href="http://sindice.com/vocab/search#cache"></see></summary>
    let cache = Namespaced_IRI.parse _namespace_name "cache" |> NamespacedName
    /// <summary>
    /// A link to the first page of results to a search query
    /// <see href="http://sindice.com/vocab/search#first"></see></summary>
    let first = Namespaced_IRI.parse _namespace_name "first" |> NamespacedName

    /// <summary>
    /// The number of items found on each page in a paged list of search results
    /// <see href="http://sindice.com/vocab/search#itemsPerPage"></see></summary>
    let itemsPerPage =
        Namespaced_IRI.parse _namespace_name "itemsPerPage" |> NamespacedName

    /// <summary>
    /// A link to the last page of results to a search query
    /// <see href="http://sindice.com/vocab/search#last"></see></summary>
    let last = Namespaced_IRI.parse _namespace_name "last" |> NamespacedName
    /// <summary>
    /// A link to a resource that was found as a search result
    /// <see href="http://sindice.com/vocab/search#link"></see></summary>
    let link = Namespaced_IRI.parse _namespace_name "link" |> NamespacedName
    /// <summary>
    /// A link from one page of a paged search result to the following page
    /// <see href="http://sindice.com/vocab/search#next"></see></summary>
    let next = Namespaced_IRI.parse _namespace_name "next" |> NamespacedName

    /// <summary>
    /// A link to an OpenSearch XML description of a search service
    /// <see href="http://sindice.com/vocab/search#openSearchDescription"></see></summary>
    let openSearchDescription =
        Namespaced_IRI.parse _namespace_name "openSearchDescription" |> NamespacedName

    /// <summary>
    /// A link from a paged list of search results to one page within that list
    /// <see href="http://sindice.com/vocab/search#page"></see></summary>
    let page = Namespaced_IRI.parse _namespace_name "page" |> NamespacedName
    /// <summary>
    /// A link from one page of a paged search result to the preceding page
    /// <see href="http://sindice.com/vocab/search#previous"></see></summary>
    let previous = Namespaced_IRI.parse _namespace_name "previous" |> NamespacedName
    /// <summary>
    /// The rank (or index) of an individual search result item within the list of search results
    /// <see href="http://sindice.com/vocab/search#rank"></see></summary>
    let rank = Namespaced_IRI.parse _namespace_name "rank" |> NamespacedName
    /// <summary>
    /// A link from a search query to an individual search result of that query
    /// <see href="http://sindice.com/vocab/search#result"></see></summary>
    let result = Namespaced_IRI.parse _namespace_name "result" |> NamespacedName

    /// <summary>
    /// The search terms used in a search query
    /// <see href="http://sindice.com/vocab/search#searchTerms"></see></summary>
    let searchTerms =
        Namespaced_IRI.parse _namespace_name "searchTerms" |> NamespacedName

    /// <summary>
    /// The rank (or index) of the first result on a page of search results
    /// <see href="http://sindice.com/vocab/search#startIndex"></see></summary>
    let startIndex = Namespaced_IRI.parse _namespace_name "startIndex" |> NamespacedName

    /// <summary>
    /// The total number of results of a search query
    /// <see href="http://sindice.com/vocab/search#totalResults"></see></summary>
    let totalResults =
        Namespaced_IRI.parse _namespace_name "totalResults" |> NamespacedName
