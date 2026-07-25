namespace http.purl.org.voc.vrank.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module vrank =
    let _namespace_iri = Namespace_Iri vrank |> NamespaceIRI
    /// <summary>
    ///   <para>vrank:Feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A feature of a vrank:Algorithm such as Granularity, RankingFactor, etc.</para>
    /// labels<para>feature</para></remarks>
    /// <seealso href="http://purl.org/voc/vrank#Feature">http://purl.org/voc/vrank#Feature</seealso>
    let Feature = Prefixed_Name(vrank, "Feature") |> PrefixedName
    /// <summary>
    ///   <para>vrank:Parameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A parameter of a vrank:Algorithm such as number of iterations or damping factor.</para>
    /// labels<para>parameter</para></remarks>
    /// <seealso href="http://purl.org/voc/vrank#Parameter">http://purl.org/voc/vrank#Parameter</seealso>
    let Parameter = Prefixed_Name(vrank, "Parameter") |> PrefixedName
    /// <summary>
    ///   <para>vrank:Rank</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Represents a ranking score associated with an item.</para>
    /// labels<para>rank</para></remarks>
    /// <seealso href="http://purl.org/voc/vrank#Rank">http://purl.org/voc/vrank#Rank</seealso>
    let Rank = Prefixed_Name(vrank, "Rank") |> PrefixedName
    /// <summary>
    ///   <para>vrank:computedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A vrank:Rank is computed by an vrank:Algorithm.</para>
    /// labels<para>computed by</para></remarks>
    /// <seealso href="http://purl.org/voc/vrank#computedBy">http://purl.org/voc/vrank#computedBy</seealso>
    let computedBy = Prefixed_Name(vrank, "computedBy") |> PrefixedName
    /// <summary>
    ///   <para>vrank:featureValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The value associated to a vrank:Feature.</para>
    /// labels<para>feature value</para></remarks>
    /// <seealso href="http://purl.org/voc/vrank#featureValue">http://purl.org/voc/vrank#featureValue</seealso>
    let featureValue = Prefixed_Name(vrank, "featureValue") |> PrefixedName
    /// <summary>
    ///   <para>vrank:hasName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>A vrank:Algorithm has a name.</para>
    /// labels<para>has name</para></remarks>
    /// <seealso href="http://purl.org/voc/vrank#hasName">http://purl.org/voc/vrank#hasName</seealso>
    let hasName = Prefixed_Name(vrank, "hasName") |> PrefixedName
    /// <summary>
    ///   <para>vrank:hasRank</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A subject, property or object hasRank a vrank:Rank.</para>
    /// labels<para>has rank</para></remarks>
    /// <seealso href="http://purl.org/voc/vrank#hasRank">http://purl.org/voc/vrank#hasRank</seealso>
    let hasRank = Prefixed_Name(vrank, "hasRank") |> PrefixedName
    /// <summary>
    ///   <para>vrank:rankValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The numerical value associated to a vrank:Rank.</para>
    /// labels<para>has rank value</para></remarks>
    /// <seealso href="http://purl.org/voc/vrank#rankValue">http://purl.org/voc/vrank#rankValue</seealso>
    let rankValue = Prefixed_Name(vrank, "rankValue") |> PrefixedName
    /// <summary>
    ///   <para>vrank:hasFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TODO.</para>
    /// labels<para>has feature</para></remarks>
    /// <seealso href="http://purl.org/voc/vrank#hasFeature">http://purl.org/voc/vrank#hasFeature</seealso>
    let hasFeature = Prefixed_Name(vrank, "hasFeature") |> PrefixedName
    /// <summary>
    ///   <para>vrank:hasRankTimeStamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The time when a vrank:Rank was computed.</para>
    /// labels<para>has rank timestamp</para></remarks>
    /// <seealso href="http://purl.org/voc/vrank#hasRankTimeStamp">http://purl.org/voc/vrank#hasRankTimeStamp</seealso>
    let hasRankTimeStamp = Prefixed_Name(vrank, "hasRankTimeStamp") |> PrefixedName
    /// <summary>
    ///   <para>vrank:paramId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The id associated to a vrank:Parameter.</para>
    /// labels<para>parameter id</para></remarks>
    /// <seealso href="http://purl.org/voc/vrank#paramId">http://purl.org/voc/vrank#paramId</seealso>
    let paramId = Prefixed_Name(vrank, "paramId") |> PrefixedName
    /// <summary>
    ///   <para>vrank:hasParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TODO.</para>
    /// labels<para>has parameter</para></remarks>
    /// <seealso href="http://purl.org/voc/vrank#hasParameter">http://purl.org/voc/vrank#hasParameter</seealso>
    let hasParameter = Prefixed_Name(vrank, "hasParameter") |> PrefixedName
    /// <summary>
    ///   <para>vrank:paramValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The value associated to a vrank:Parameter.</para>
    /// labels<para>parameter value</para></remarks>
    /// <seealso href="http://purl.org/voc/vrank#paramValue">http://purl.org/voc/vrank#paramValue</seealso>
    let paramValue = Prefixed_Name(vrank, "paramValue") |> PrefixedName
    /// <summary>
    ///   <para>vrank:Algorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A ranking algorithm used to compute the ranking scores associated with an item (vrank:Rank).</para>
    /// labels<para>algorithm</para></remarks>
    /// <seealso href="http://purl.org/voc/vrank#Algorithm">http://purl.org/voc/vrank#Algorithm</seealso>
    let Algorithm = Prefixed_Name(vrank, "Algorithm") |> PrefixedName
    /// <summary>
    ///   <para>vrank:featureId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The id associated to a vrank:Feature.</para>
    /// labels<para>feature id</para></remarks>
    /// <seealso href="http://purl.org/voc/vrank#featureId">http://purl.org/voc/vrank#featureId</seealso>
    let featureId = Prefixed_Name(vrank, "featureId") |> PrefixedName
