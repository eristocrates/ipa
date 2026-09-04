#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module vsearch =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/vsearch/" "vsearch"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : query</para>
    ///   <para>rdfs:comment : A query.^^xsd:string</para>
    ///   <a href="http://purl.org/vsearch/Query">vsearch:Query</a>
    /// </summary>
    let Query = _prefixId.prefix "Query"
    /// <summary>
    ///   <para>rdfs:label : result term</para>
    ///   <para>rdfs:comment : A result term.^^xsd:string</para>
    ///   <a href="http://purl.org/vsearch/ResultTerm">vsearch:ResultTerm</a>
    /// </summary>
    let ResultTerm = _prefixId.prefix "ResultTerm"
    /// <summary>
    ///   <para>rdfs:label : do query</para>
    ///   <para>rdfs:comment : A query that an entity executes.^^xsd:string</para>
    ///   <a href="http://purl.org/vsearch/doQuery">vsearch:doQuery</a>
    /// </summary>
    let doQuery = _prefixId.prefix "doQuery"
    /// <summary>
    ///   <para>rdfs:label : has rank</para>
    ///   <para>rdfs:comment : The rank for a result term.^^xsd:string</para>
    ///   <a href="http://purl.org/vsearch/hasRank">vsearch:hasRank</a>
    /// </summary>
    let hasRank = _prefixId.prefix "hasRank"
    /// <summary>
    ///   <para>rdfs:label : has result term</para>
    ///   <para>rdfs:comment : A result term for a query.^^xsd:string</para>
    ///   <a href="http://purl.org/vsearch/hasResultTerm">vsearch:hasResultTerm</a>
    /// </summary>
    let hasResultTerm = _prefixId.prefix "hasResultTerm"
    /// <summary>
    ///   <para>rdfs:label : keyword</para>
    ///   <para>rdfs:comment : The keyword of the query.^^xsd:string</para>
    ///   <a href="http://purl.org/vsearch/keyword">vsearch:keyword</a>
    /// </summary>
    let keyword = _prefixId.prefix "keyword"
    /// <summary>
    ///   <para>rdfs:label : language</para>
    ///   <para>rdfs:comment : The language of the query keyword.^^xsd:string</para>
    ///   <a href="http://purl.org/vsearch/language">vsearch:language</a>
    /// </summary>
    let language = _prefixId.prefix "language"
    /// <summary>
    ///   <para>rdfs:label : rank value</para>
    ///   <para>rdfs:comment : The rank value of a term's ranking.^^xsd:string</para>
    ///   <a href="http://purl.org/vsearch/rankValue">vsearch:rankValue</a>
    /// </summary>
    let rankValue = _prefixId.prefix "rankValue"
    /// <summary>
    ///   <para>rdfs:label : term URI</para>
    ///   <para>rdfs:comment : The URI of the result term.^^xsd:string</para>
    ///   <a href="http://purl.org/vsearch/termURI">vsearch:termURI</a>
    /// </summary>
    let termURI = _prefixId.prefix "termURI"
