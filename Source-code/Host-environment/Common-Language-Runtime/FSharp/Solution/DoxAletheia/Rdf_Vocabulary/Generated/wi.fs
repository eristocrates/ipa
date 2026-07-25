namespace http.purl.org.ontology.wi.core.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module wi =
    let _namespace_iri = Namespace_Iri wi |> NamespaceIRI
    /// <summary>
    ///   <para>wi:InterestDynamics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>An event concept for describing dynamics of interests, e.g. weight changes, periods of interest.</para>
    /// labels<para>Interest Dynamics</para></remarks>
    /// <seealso href="http://purl.org/ontology/wi/core#InterestDynamics">http://purl.org/ontology/wi/core#InterestDynamics</seealso>
    let InterestDynamics = Prefixed_Name(wi, "InterestDynamics") |> PrefixedName
    /// <summary>
    ///   <para>wi:WeightedInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A weighted interest object, which also can have interest dynamics etc.</para>
    /// labels<para>Weighted Interest</para></remarks>
    /// <seealso href="http://purl.org/ontology/wi/core#WeightedInterest">http://purl.org/ontology/wi/core#WeightedInterest</seealso>
    let WeightedInterest = Prefixed_Name(wi, "WeightedInterest") |> PrefixedName
    /// <summary>
    ///   <para>wi:preference</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A link between an agent and a weighted interest</para>
    /// labels<para>has preference</para></remarks>
    /// <seealso href="http://purl.org/ontology/wi/core#preference">http://purl.org/ontology/wi/core#preference</seealso>
    let preference = Prefixed_Name(wi, "preference") |> PrefixedName
    /// <summary>
    ///   <para>wi:appear_time</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The time when the interest appears in a certain kind of scenario.</para>
    /// labels<para>has appear time</para></remarks>
    /// <seealso href="http://purl.org/ontology/wi/core#appear_time">http://purl.org/ontology/wi/core#appear_time</seealso>
    let appear_time = Prefixed_Name(wi, "appear_time") |> PrefixedName
    /// <summary>
    ///   <para>wi:evidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A link between a context and evidence supporting the interpretation of preferences in a context</para>
    /// labels<para>has evidence</para></remarks>
    /// <seealso href="http://purl.org/ontology/wi/core#evidence">http://purl.org/ontology/wi/core#evidence</seealso>
    let evidence = Prefixed_Name(wi, "evidence") |> PrefixedName
    /// <summary>
    ///   <para>wi:ExplicitMining</para>
    /// </summary>
    /// <remarks>
    ///   <para>scovo:Dimension</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/wi/core#ExplicitMining">http://purl.org/ontology/wi/core#ExplicitMining</seealso>
    let ExplicitMining = Prefixed_Name(wi, "ExplicitMining") |> PrefixedName
    /// <summary>
    ///   <para>wi:ImplicitMining</para>
    /// </summary>
    /// <remarks>
    ///   <para>scovo:Dimension</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/wi/core#ImplicitMining">http://purl.org/ontology/wi/core#ImplicitMining</seealso>
    let ImplicitMining = Prefixed_Name(wi, "ImplicitMining") |> PrefixedName
    /// <summary>
    ///   <para>wi:agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A link from a mined interest to the related person</para>
    /// labels<para>has agent</para></remarks>
    /// <seealso href="http://purl.org/ontology/wi/core#agent">http://purl.org/ontology/wi/core#agent</seealso>
    let agent = Prefixed_Name(wi, "agent") |> PrefixedName
    /// <summary>
    ///   <para>wi:attention_duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An interval of attention for an interest.</para>
    /// labels<para>has attention duration</para></remarks>
    /// <seealso href="http://purl.org/ontology/wi/core#attention_duration">http://purl.org/ontology/wi/core#attention_duration</seealso>
    let attention_duration = Prefixed_Name(wi, "attention_duration") |> PrefixedName
    /// <summary>
    ///   <para>wi:longest_duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The longest continuous interval of attention for an interest, e.g. for an interest, if it appears in the following years: 1990, 1991, 1995, 1996, 1997, 1998, 2001, then the longest duration is 4 years.</para>
    /// labels<para>has longest duration</para></remarks>
    /// <seealso href="http://purl.org/ontology/wi/core#longest_duration">http://purl.org/ontology/wi/core#longest_duration</seealso>
    let longest_duration = Prefixed_Name(wi, "longest_duration") |> PrefixedName
    /// <summary>
    ///   <para>wi:interest_dynamics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>To relate a weighted interest to its temporal dynamics.</para>
    /// labels<para>has interest dynamics</para></remarks>
    /// <seealso href="http://purl.org/ontology/wi/core#interest_dynamics">http://purl.org/ontology/wi/core#interest_dynamics</seealso>
    let interest_dynamics = Prefixed_Name(wi, "interest_dynamics") |> PrefixedName
    /// <summary>
    ///   <para>wi:not_interested_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A link between an agent and a topic of no interest to them</para>
    /// labels<para>is not interested in</para></remarks>
    /// <seealso href="http://purl.org/ontology/wi/core#not_interested_in">http://purl.org/ontology/wi/core#not_interested_in</seealso>
    let not_interested_in = Prefixed_Name(wi, "not_interested_in") |> PrefixedName
    /// <summary>
    ///   <para>wi:overall_weight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>This weight reflects the overall interest in a topic and should be different from the actual weight of interest.</para>
    /// labels<para>has overall weight</para></remarks>
    /// <seealso href="http://purl.org/ontology/wi/core#overall_weight">http://purl.org/ontology/wi/core#overall_weight</seealso>
    let overall_weight = Prefixed_Name(wi, "overall_weight") |> PrefixedName
    /// <summary>
    ///   <para>wi:topic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A topic of the weighted interest</para>
    /// labels<para>has topic</para></remarks>
    /// <seealso href="http://purl.org/ontology/wi/core#topic">http://purl.org/ontology/wi/core#topic</seealso>
    let topic = Prefixed_Name(wi, "topic") |> PrefixedName
    /// <summary>
    ///   <para>wi:ultimative_duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The overall duration of attention for an interest, e.g. for an interest, if it appears in the following years: 1990, 1991, 1995, 1996, 1997, 1998, 2001, then the longest duration is 7 years.</para>
    /// labels<para>has ultimative duration</para></remarks>
    /// <seealso href="http://purl.org/ontology/wi/core#ultimative_duration">http://purl.org/ontology/wi/core#ultimative_duration</seealso>
    let ultimative_duration = Prefixed_Name(wi, "ultimative_duration") |> PrefixedName
    /// <summary>
    ///   <para>wi:statistical_item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A link from an interest to statistics about itself</para>
    /// labels<para>has statistical item</para></remarks>
    /// <seealso href="http://purl.org/ontology/wi/core#statistical_item">http://purl.org/ontology/wi/core#statistical_item</seealso>
    let statistical_item = Prefixed_Name(wi, "statistical_item") |> PrefixedName
    /// <summary>
    ///   <para>wi:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/wi/core#">http://purl.org/ontology/wi/core#</seealso>
    let _prefix_iri = Prefixed_Name(wi, "") |> PrefixedName
