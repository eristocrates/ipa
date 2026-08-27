namespace https.w3id.org.vocab.sdm.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module sdm =
    let _namespace_iri = Namespace_Iri sdm |> NamespaceIRI

    /// <summary>
    ///   <para>w3id:vocab/sdm#EndPointFeatureExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Principal class extending the sd:Feature for providing more metadata on an endpoint service. "</para>
    /// labels<para>"EndPoint feature extension"</para></remarks>
    /// <seealso href="https://w3id.org/vocab/sdm#EndPointFeatureExtension">https://w3id.org/vocab/sdm#EndPointFeatureExtension</seealso>
    let EndPointFeatureExtension =
        Prefixed_Name(sdm, "EndPointFeatureExtension") |> PrefixedName

    /// <summary>
    ///   <para>w3id:vocab/sdm#SPARQLRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"SPARQL request"</para></remarks>
    /// <seealso href="https://w3id.org/vocab/sdm#SPARQLRequest">https://w3id.org/vocab/sdm#SPARQLRequest</seealso>
    let SPARQLRequest = Prefixed_Name(sdm, "SPARQLRequest") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vocab/sdm#TripleStore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Triple store"</para></remarks>
    /// <seealso href="https://w3id.org/vocab/sdm#TripleStore">https://w3id.org/vocab/sdm#TripleStore</seealso>
    let TripleStore = Prefixed_Name(sdm, "TripleStore") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vocab/sdm#developer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Developer of the triple store"</para>
    /// labels<para>"developer"</para></remarks>
    /// <seealso href="https://w3id.org/vocab/sdm#developer">https://w3id.org/vocab/sdm#developer</seealso>
    let developer = Prefixed_Name(sdm, "developer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vocab/sdm#httpMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Links to the message of an http connection, and helps to connect with http:httpVersion which is a rdfs:Literal"</para>
    /// labels<para>"http message"</para></remarks>
    /// <seealso href="https://w3id.org/vocab/sdm#httpMessage">https://w3id.org/vocab/sdm#httpMessage</seealso>
    let httpMessage = Prefixed_Name(sdm, "httpMessage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vocab/sdm#maxResultPerRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The limit of the maximum results for the endpoint service"</para>
    /// labels<para>"Max results per request"</para></remarks>
    /// <seealso href="https://w3id.org/vocab/sdm#maxResultPerRequest">https://w3id.org/vocab/sdm#maxResultPerRequest</seealso>
    let maxResultPerRequest = Prefixed_Name(sdm, "maxResultPerRequest") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vocab/sdm#mirror</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"URI of a mirror of the endpoint service"</para>
    /// labels<para>"mirror"</para></remarks>
    /// <seealso href="https://w3id.org/vocab/sdm#mirror">https://w3id.org/vocab/sdm#mirror</seealso>
    let mirror = Prefixed_Name(sdm, "mirror") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vocab/sdm#queryTimeOut</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The timeout of a query in milliseconds"</para>
    /// labels<para>"query time out"</para></remarks>
    /// <seealso href="https://w3id.org/vocab/sdm#queryTimeOut">https://w3id.org/vocab/sdm#queryTimeOut</seealso>
    let queryTimeOut = Prefixed_Name(sdm, "queryTimeOut") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vocab/sdm#remainingPerRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The remaining results for a given request"</para>
    /// labels<para>"Remaining per request"</para></remarks>
    /// <seealso href="https://w3id.org/vocab/sdm#remainingPerRequest">https://w3id.org/vocab/sdm#remainingPerRequest</seealso>
    let remainingPerRequest = Prefixed_Name(sdm, "remainingPerRequest") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vocab/sdm#request</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links to a SPARQL request"</para>
    /// labels<para>"requests"</para></remarks>
    /// <seealso href="https://w3id.org/vocab/sdm#request">https://w3id.org/vocab/sdm#request</seealso>
    let request = Prefixed_Name(sdm, "request") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vocab/sdm#scheduledDowntime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Links to an interval period time"</para>
    /// labels<para>"scheduled downtime"</para></remarks>
    /// <seealso href="https://w3id.org/vocab/sdm#scheduledDowntime">https://w3id.org/vocab/sdm#scheduledDowntime</seealso>
    let scheduledDowntime = Prefixed_Name(sdm, "scheduledDowntime") |> PrefixedName
    /// <summary>
    ///   <para>w3id:vocab/sdm#tripleStore</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links to a given software acting as a triple store"</para>
    /// labels<para>"tripleStore"</para></remarks>
    /// <seealso href="https://w3id.org/vocab/sdm#tripleStore">https://w3id.org/vocab/sdm#tripleStore</seealso>
    let tripleStore = Prefixed_Name(sdm, "tripleStore") |> PrefixedName
