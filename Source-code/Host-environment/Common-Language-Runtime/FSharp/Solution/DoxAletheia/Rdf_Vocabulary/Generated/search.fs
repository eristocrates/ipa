namespace http.sindice.com.vocab.search.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module search =
    let _namespace_iri = Namespace_Iri search |> NamespaceIRI
    /// <summary>
    ///   <para>search:Page</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A page in a paged list of search results"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Page"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://sindice.com/vocab/search#Page">http://sindice.com/vocab/search#Page</seealso>
    let Page = Prefixed_Name(search, "Page") |> PrefixedName
    /// <summary>
    ///   <para>search:Query</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A search query"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Query"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://sindice.com/vocab/search#Query">http://sindice.com/vocab/search#Query</seealso>
    let Query = Prefixed_Name(search, "Query") |> PrefixedName
    /// <summary>
    ///   <para>search:Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"An individual result in a list of ranked search results to a search query"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Result"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://sindice.com/vocab/search#Result">http://sindice.com/vocab/search#Result</seealso>
    let Result = Prefixed_Name(search, "Result") |> PrefixedName
    /// <summary>
    ///   <para>search:cache</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Link to a cached copy of a search result"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cache"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://sindice.com/vocab/search#cache">http://sindice.com/vocab/search#cache</seealso>
    let cache = Prefixed_Name(search, "cache") |> PrefixedName
    /// <summary>
    ///   <para>search:first</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A link to the first page of results to a search query"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"First"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://sindice.com/vocab/search#first">http://sindice.com/vocab/search#first</seealso>
    let first = Prefixed_Name(search, "first") |> PrefixedName
    /// <summary>
    ///   <para>search:itemsPerPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The number of items found on each page in a paged list of search results"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Items per Page"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://sindice.com/vocab/search#itemsPerPage">http://sindice.com/vocab/search#itemsPerPage</seealso>
    let itemsPerPage = Prefixed_Name(search, "itemsPerPage") |> PrefixedName
    /// <summary>
    ///   <para>search:last</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A link to the last page of results to a search query"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Last"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://sindice.com/vocab/search#last">http://sindice.com/vocab/search#last</seealso>
    let last = Prefixed_Name(search, "last") |> PrefixedName
    /// <summary>
    ///   <para>search:link</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A link to a resource that was found as a search result"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Link"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://sindice.com/vocab/search#link">http://sindice.com/vocab/search#link</seealso>
    let link = Prefixed_Name(search, "link") |> PrefixedName
    /// <summary>
    ///   <para>search:next</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A link from one page of a paged search result to the following page"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Next"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://sindice.com/vocab/search#next">http://sindice.com/vocab/search#next</seealso>
    let next = Prefixed_Name(search, "next") |> PrefixedName

    /// <summary>
    ///   <para>search:openSearchDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A link to an OpenSearch XML description of a search service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"OpenSearch Description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://sindice.com/vocab/search#openSearchDescription">http://sindice.com/vocab/search#openSearchDescription</seealso>
    let openSearchDescription =
        Prefixed_Name(search, "openSearchDescription") |> PrefixedName

    /// <summary>
    ///   <para>search:page</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A link from a paged list of search results to one page within that list"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Page"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://sindice.com/vocab/search#page">http://sindice.com/vocab/search#page</seealso>
    let page = Prefixed_Name(search, "page") |> PrefixedName
    /// <summary>
    ///   <para>search:previous</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A link from one page of a paged search result to the preceding page"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Previous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://sindice.com/vocab/search#previous">http://sindice.com/vocab/search#previous</seealso>
    let previous = Prefixed_Name(search, "previous") |> PrefixedName
    /// <summary>
    ///   <para>search:rank</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The rank (or index) of an individual search result item within the list of search results"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Rank"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://sindice.com/vocab/search#rank">http://sindice.com/vocab/search#rank</seealso>
    let rank = Prefixed_Name(search, "rank") |> PrefixedName
    /// <summary>
    ///   <para>search:result</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A link from a search query to an individual search result of that query"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Result"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://sindice.com/vocab/search#result">http://sindice.com/vocab/search#result</seealso>
    let result = Prefixed_Name(search, "result") |> PrefixedName
    /// <summary>
    ///   <para>search:searchTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The search terms used in a search query"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Search Terms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://sindice.com/vocab/search#searchTerms">http://sindice.com/vocab/search#searchTerms</seealso>
    let searchTerms = Prefixed_Name(search, "searchTerms") |> PrefixedName
    /// <summary>
    ///   <para>search:startIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The rank (or index) of the first result on a page of search results"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Start Index"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://sindice.com/vocab/search#startIndex">http://sindice.com/vocab/search#startIndex</seealso>
    let startIndex = Prefixed_Name(search, "startIndex") |> PrefixedName
    /// <summary>
    ///   <para>search:totalResults</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The total number of results of a search query"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Total Results"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://sindice.com/vocab/search#totalResults">http://sindice.com/vocab/search#totalResults</seealso>
    let totalResults = Prefixed_Name(search, "totalResults") |> PrefixedName
