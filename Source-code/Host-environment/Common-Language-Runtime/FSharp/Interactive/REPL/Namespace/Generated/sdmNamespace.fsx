#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module sdm =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/vocab/sdm#" "sdm"
    /// <summary>
    ///   <para>rdfs:label : EndPoint feature extension</para>
    ///   <para>rdfs:comment : Principal class extending the sd:Feature for providing more metadata on an endpoint service. </para>
    ///   <a href="https://w3id.org/vocab/sdm#EndPointFeatureExtension">sdm:EndPointFeatureExtension</a>
    /// </summary>
    let EndPointFeatureExtension = _prefixId.prefix "EndPointFeatureExtension"
    /// <summary>
    ///   <para>rdfs:label : SPARQL request</para>
    ///   <a href="https://w3id.org/vocab/sdm#SPARQLRequest">sdm:SPARQLRequest</a>
    /// </summary>
    let SPARQLRequest = _prefixId.prefix "SPARQLRequest"
    /// <summary>
    ///   <para>rdfs:label : Triple store</para>
    ///   <a href="https://w3id.org/vocab/sdm#TripleStore">sdm:TripleStore</a>
    /// </summary>
    let TripleStore = _prefixId.prefix "TripleStore"
    /// <summary>
    ///   <para>rdfs:label : developer</para>
    ///   <para>rdfs:comment : Developer of the triple store</para>
    ///   <a href="https://w3id.org/vocab/sdm#developer">sdm:developer</a>
    /// </summary>
    let developer = _prefixId.prefix "developer"
    /// <summary>
    ///   <para>rdfs:label : http message</para>
    ///   <para>rdfs:comment : Links to the message of an http connection, and helps to connect with http:httpVersion which is a rdfs:Literal</para>
    ///   <a href="https://w3id.org/vocab/sdm#httpMessage">sdm:httpMessage</a>
    /// </summary>
    let httpMessage = _prefixId.prefix "httpMessage"
    /// <summary>
    ///   <para>rdfs:label : Max results per request</para>
    ///   <para>rdfs:comment : The limit of the maximum results for the endpoint service</para>
    ///   <a href="https://w3id.org/vocab/sdm#maxResultPerRequest">sdm:maxResultPerRequest</a>
    /// </summary>
    let maxResultPerRequest = _prefixId.prefix "maxResultPerRequest"
    /// <summary>
    ///   <para>rdfs:label : mirror</para>
    ///   <para>rdfs:comment : URI of a mirror of the endpoint service</para>
    ///   <a href="https://w3id.org/vocab/sdm#mirror">sdm:mirror</a>
    /// </summary>
    let mirror = _prefixId.prefix "mirror"
    /// <summary>
    ///   <para>rdfs:label : query time out</para>
    ///   <para>rdfs:comment : The timeout of a query in milliseconds</para>
    ///   <a href="https://w3id.org/vocab/sdm#queryTimeOut">sdm:queryTimeOut</a>
    /// </summary>
    let queryTimeOut = _prefixId.prefix "queryTimeOut"
    /// <summary>
    ///   <para>rdfs:label : Remaining per request</para>
    ///   <para>rdfs:comment : The remaining results for a given request</para>
    ///   <a href="https://w3id.org/vocab/sdm#remainingPerRequest">sdm:remainingPerRequest</a>
    /// </summary>
    let remainingPerRequest = _prefixId.prefix "remainingPerRequest"
    /// <summary>
    ///   <para>rdfs:label : requests</para>
    ///   <para>rdfs:comment : Links to a SPARQL request</para>
    ///   <a href="https://w3id.org/vocab/sdm#request">sdm:request</a>
    /// </summary>
    let request = _prefixId.prefix "request"
    /// <summary>
    ///   <para>rdfs:label : scheduled downtime</para>
    ///   <para>rdfs:comment : Links to an interval period time</para>
    ///   <a href="https://w3id.org/vocab/sdm#scheduledDowntime">sdm:scheduledDowntime</a>
    /// </summary>
    let scheduledDowntime = _prefixId.prefix "scheduledDowntime"
    /// <summary>
    ///   <para>rdfs:label : tripleStore</para>
    ///   <para>rdfs:comment : Links to a given software acting as a triple store</para>
    ///   <a href="https://w3id.org/vocab/sdm#tripleStore">sdm:tripleStore</a>
    /// </summary>
    let tripleStore = _prefixId.prefix "tripleStore"
