namespace http.purl.org.ontology._rec.core.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rec_ =
    let _namespace_iri = Namespace_Iri rec_ |> NamespaceIRI

    /// <summary>
    ///   <para>rec:RankedRecommendation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A ranked recommendation that includes an ordered list of recommendations.</para>
    /// labels<para>Ranked Recommendation</para></remarks>
    /// <seealso href="http://purl.org/ontology/rec/core#RankedRecommendation">http://purl.org/ontology/rec/core#RankedRecommendation</seealso>
    let RankedRecommendation =
        Prefixed_Name(rec_, "RankedRecommendation") |> PrefixedName

    /// <summary>
    ///   <para>rec:for</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Relates a recommendation to someone or something.</para>
    /// labels<para>for</para></remarks>
    /// <seealso href="http://purl.org/ontology/rec/core#for">http://purl.org/ontology/rec/core#for</seealso>
    let for_ = Prefixed_Name(rec_, "for") |> PrefixedName

    /// <summary>
    ///   <para>rec:recommendation_object</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A recommendation object that is part of a specific recommendation.</para>
    /// labels<para>has recommendation object</para></remarks>
    /// <seealso href="http://purl.org/ontology/rec/core#recommendation_object">http://purl.org/ontology/rec/core#recommendation_object</seealso>
    let recommendation_object =
        Prefixed_Name(rec_, "recommendation_object") |> PrefixedName

    /// <summary>
    ///   <para>rec:recommendation_audience</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An audience for a specific recommendation.</para>
    /// labels<para>has recommendation audience</para></remarks>
    /// <seealso href="http://purl.org/ontology/rec/core#recommendation_audience">http://purl.org/ontology/rec/core#recommendation_audience</seealso>
    let recommendation_audience =
        Prefixed_Name(rec_, "recommendation_audience") |> PrefixedName

    /// <summary>
    ///   <para>rec:Recommendation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A recommendation of something for someone or a specific audience by a recommender.</para>
    /// labels<para>Recommendation</para></remarks>
    /// <seealso href="http://purl.org/ontology/rec/core#Recommendation">http://purl.org/ontology/rec/core#Recommendation</seealso>
    let Recommendation = Prefixed_Name(rec_, "Recommendation") |> PrefixedName
    /// <summary>
    ///   <para>rec:recommendation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A recommendation for someone or something.</para>
    /// labels<para>has recommendation</para></remarks>
    /// <seealso href="http://purl.org/ontology/rec/core#recommendation">http://purl.org/ontology/rec/core#recommendation</seealso>
    let recommendation = Prefixed_Name(rec_, "recommendation") |> PrefixedName

    /// <summary>
    ///   <para>rec:ranked_recommendation_object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A ranked recommendation object in a ranked recommendation</para>
    /// labels<para>ranked recommendation object</para></remarks>
    /// <seealso href="http://purl.org/ontology/rec/core#ranked_recommendation_object">http://purl.org/ontology/rec/core#ranked_recommendation_object</seealso>
    let ranked_recommendation_object =
        Prefixed_Name(rec_, "ranked_recommendation_object") |> PrefixedName

    /// <summary>
    ///   <para>rec:recommended_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A thing, which is recommended in a recommendation.</para>
    /// labels<para>recommended in</para></remarks>
    /// <seealso href="http://purl.org/ontology/rec/core#recommended_in">http://purl.org/ontology/rec/core#recommended_in</seealso>
    let recommended_in = Prefixed_Name(rec_, "recommended_in") |> PrefixedName
    /// <summary>
    ///   <para>rec:recommends</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An agent recommends a recommendation to someone or a recommendation audience.</para>
    /// labels<para>recommends</para></remarks>
    /// <seealso href="http://purl.org/ontology/rec/core#recommends">http://purl.org/ontology/rec/core#recommends</seealso>
    let recommends = Prefixed_Name(rec_, "recommends") |> PrefixedName
    /// <summary>
    ///   <para>rec:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/rec/core#">http://purl.org/ontology/rec/core#</seealso>
    let _prefix_iri = Prefixed_Name(rec_, "") |> PrefixedName
    /// <summary>
    ///   <para>rec:recommender</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An agent, which provided/calculated this recommendation.</para>
    /// labels<para>has recommender</para></remarks>
    /// <seealso href="http://purl.org/ontology/rec/core#recommender">http://purl.org/ontology/rec/core#recommender</seealso>
    let recommender = Prefixed_Name(rec_, "recommender") |> PrefixedName
