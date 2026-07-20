namespace http.sindice.com.vocab.search.hash

open DoxAletheia

module search =
    let _namespace_name = "http://sindice.com/vocab/search#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A page in a paged list of search results
    /// <see href="http://sindice.com/vocab/search#Page"></see></summary>
    let Page = _prefix "Page"
    /// <summary>
    /// A search query
    /// <see href="http://sindice.com/vocab/search#Query"></see></summary>
    let Query = _prefix "Query"
    /// <summary>
    /// An individual result in a list of ranked search results to a search query
    /// <see href="http://sindice.com/vocab/search#Result"></see></summary>
    let Result = _prefix "Result"
    /// <summary>
    /// Link to a cached copy of a search result
    /// <see href="http://sindice.com/vocab/search#cache"></see></summary>
    let cache = _prefix "cache"
    /// <summary>
    /// A link to the first page of results to a search query
    /// <see href="http://sindice.com/vocab/search#first"></see></summary>
    let first = _prefix "first"
    /// <summary>
    /// The number of items found on each page in a paged list of search results
    /// <see href="http://sindice.com/vocab/search#itemsPerPage"></see></summary>
    let itemsPerPage = _prefix "itemsPerPage"
    /// <summary>
    /// A link to the last page of results to a search query
    /// <see href="http://sindice.com/vocab/search#last"></see></summary>
    let last = _prefix "last"
    /// <summary>
    /// A link to a resource that was found as a search result
    /// <see href="http://sindice.com/vocab/search#link"></see></summary>
    let link = _prefix "link"
    /// <summary>
    /// A link from one page of a paged search result to the following page
    /// <see href="http://sindice.com/vocab/search#next"></see></summary>
    let next = _prefix "next"
    /// <summary>
    /// A link to an OpenSearch XML description of a search service
    /// <see href="http://sindice.com/vocab/search#openSearchDescription"></see></summary>
    let openSearchDescription = _prefix "openSearchDescription"
    /// <summary>
    /// A link from a paged list of search results to one page within that list
    /// <see href="http://sindice.com/vocab/search#page"></see></summary>
    let page = _prefix "page"
    /// <summary>
    /// A link from one page of a paged search result to the preceding page
    /// <see href="http://sindice.com/vocab/search#previous"></see></summary>
    let previous = _prefix "previous"
    /// <summary>
    /// The rank (or index) of an individual search result item within the list of search results
    /// <see href="http://sindice.com/vocab/search#rank"></see></summary>
    let rank = _prefix "rank"
    /// <summary>
    /// A link from a search query to an individual search result of that query
    /// <see href="http://sindice.com/vocab/search#result"></see></summary>
    let result = _prefix "result"
    /// <summary>
    /// The search terms used in a search query
    /// <see href="http://sindice.com/vocab/search#searchTerms"></see></summary>
    let searchTerms = _prefix "searchTerms"
    /// <summary>
    /// The rank (or index) of the first result on a page of search results
    /// <see href="http://sindice.com/vocab/search#startIndex"></see></summary>
    let startIndex = _prefix "startIndex"
    /// <summary>
    /// The total number of results of a search query
    /// <see href="http://sindice.com/vocab/search#totalResults"></see></summary>
    let totalResults = _prefix "totalResults"
