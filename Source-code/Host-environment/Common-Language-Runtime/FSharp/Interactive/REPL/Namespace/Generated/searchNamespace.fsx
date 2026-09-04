#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module search =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://sindice.com/vocab/search#" "search"

    /// <summary>
    ///   <para>rdfs:label : Page^^xsd:string</para>
    ///   <para>rdfs:comment : A page in a paged list of search results^^xsd:string</para>
    ///   <a href="http://sindice.com/vocab/search#Page">search:Page</a>
    /// </summary>
    let Page = _prefixId.prefix "Page"
    /// <summary>
    ///   <para>rdfs:label : Query^^xsd:string</para>
    ///   <para>rdfs:comment : A search query^^xsd:string</para>
    ///   <a href="http://sindice.com/vocab/search#Query">search:Query</a>
    /// </summary>
    let Query = _prefixId.prefix "Query"
    /// <summary>
    ///   <para>rdfs:label : Result^^xsd:string</para>
    ///   <para>rdfs:comment : An individual result in a list of ranked search results to a search query^^xsd:string</para>
    ///   <a href="http://sindice.com/vocab/search#Result">search:Result</a>
    /// </summary>
    let Result = _prefixId.prefix "Result"
    /// <summary>
    ///   <para>rdfs:label : Cache^^xsd:string</para>
    ///   <para>rdfs:comment : Link to a cached copy of a search result^^xsd:string</para>
    ///   <a href="http://sindice.com/vocab/search#cache">search:cache</a>
    /// </summary>
    let cache = _prefixId.prefix "cache"
    /// <summary>
    ///   <para>rdfs:label : First^^xsd:string</para>
    ///   <para>rdfs:comment : A link to the first page of results to a search query^^xsd:string</para>
    ///   <a href="http://sindice.com/vocab/search#first">search:first</a>
    /// </summary>
    let first = _prefixId.prefix "first"
    /// <summary>
    ///   <para>rdfs:label : Items per Page^^xsd:string</para>
    ///   <para>rdfs:comment : The number of items found on each page in a paged list of search results^^xsd:string</para>
    ///   <a href="http://sindice.com/vocab/search#itemsPerPage">search:itemsPerPage</a>
    /// </summary>
    let itemsPerPage = _prefixId.prefix "itemsPerPage"
    /// <summary>
    ///   <para>rdfs:label : Last^^xsd:string</para>
    ///   <para>rdfs:comment : A link to the last page of results to a search query^^xsd:string</para>
    ///   <a href="http://sindice.com/vocab/search#last">search:last</a>
    /// </summary>
    let last = _prefixId.prefix "last"
    /// <summary>
    ///   <para>rdfs:label : Link^^xsd:string</para>
    ///   <para>rdfs:comment : A link to a resource that was found as a search result^^xsd:string</para>
    ///   <a href="http://sindice.com/vocab/search#link">search:link</a>
    /// </summary>
    let link = _prefixId.prefix "link"
    /// <summary>
    ///   <para>rdfs:label : Next^^xsd:string</para>
    ///   <para>rdfs:comment : A link from one page of a paged search result to the following page^^xsd:string</para>
    ///   <a href="http://sindice.com/vocab/search#next">search:next</a>
    /// </summary>
    let next = _prefixId.prefix "next"
    /// <summary>
    ///   <para>rdfs:label : OpenSearch Description^^xsd:string</para>
    ///   <para>rdfs:comment : A link to an OpenSearch XML description of a search service^^xsd:string</para>
    ///   <a href="http://sindice.com/vocab/search#openSearchDescription">search:openSearchDescription</a>
    /// </summary>
    let openSearchDescription = _prefixId.prefix "openSearchDescription"
    /// <summary>
    ///   <para>rdfs:label : Page^^xsd:string</para>
    ///   <para>rdfs:comment : A link from a paged list of search results to one page within that list^^xsd:string</para>
    ///   <a href="http://sindice.com/vocab/search#page">search:page</a>
    /// </summary>
    let page = _prefixId.prefix "page"
    /// <summary>
    ///   <para>rdfs:label : Previous^^xsd:string</para>
    ///   <para>rdfs:comment : A link from one page of a paged search result to the preceding page^^xsd:string</para>
    ///   <a href="http://sindice.com/vocab/search#previous">search:previous</a>
    /// </summary>
    let previous = _prefixId.prefix "previous"
    /// <summary>
    ///   <para>rdfs:label : Rank^^xsd:string</para>
    ///   <para>rdfs:comment : The rank (or index) of an individual search result item within the list of search results^^xsd:string</para>
    ///   <a href="http://sindice.com/vocab/search#rank">search:rank</a>
    /// </summary>
    let rank = _prefixId.prefix "rank"
    /// <summary>
    ///   <para>rdfs:label : Result^^xsd:string</para>
    ///   <para>rdfs:comment : A link from a search query to an individual search result of that query^^xsd:string</para>
    ///   <a href="http://sindice.com/vocab/search#result">search:result</a>
    /// </summary>
    let result = _prefixId.prefix "result"
    /// <summary>
    ///   <para>rdfs:label : Search Terms^^xsd:string</para>
    ///   <para>rdfs:comment : The search terms used in a search query^^xsd:string</para>
    ///   <a href="http://sindice.com/vocab/search#searchTerms">search:searchTerms</a>
    /// </summary>
    let searchTerms = _prefixId.prefix "searchTerms"
    /// <summary>
    ///   <para>rdfs:label : Start Index^^xsd:string</para>
    ///   <para>rdfs:comment : The rank (or index) of the first result on a page of search results^^xsd:string</para>
    ///   <a href="http://sindice.com/vocab/search#startIndex">search:startIndex</a>
    /// </summary>
    let startIndex = _prefixId.prefix "startIndex"
    /// <summary>
    ///   <para>rdfs:label : Total Results^^xsd:string</para>
    ///   <para>rdfs:comment : The total number of results of a search query^^xsd:string</para>
    ///   <a href="http://sindice.com/vocab/search#totalResults">search:totalResults</a>
    /// </summary>
    let totalResults = _prefixId.prefix "totalResults"
