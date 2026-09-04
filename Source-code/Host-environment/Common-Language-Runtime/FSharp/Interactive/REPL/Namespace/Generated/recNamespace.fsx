#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``rec`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/ontology/rec/core#" "rec"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : Ranked Recommendation</para>
    ///   <para>rdfs:comment : A ranked recommendation that includes an ordered list of recommendations.</para>
    ///   <a href="http://purl.org/ontology/rec/core#RankedRecommendation">rec:RankedRecommendation</a>
    /// </summary>
    let RankedRecommendation = _prefixId.prefix "RankedRecommendation"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Recommendation</para>
    ///   <para>rdfs:comment : A recommendation of something for someone or a specific audience by a recommender.</para>
    ///   <a href="http://purl.org/ontology/rec/core#Recommendation">rec:Recommendation</a>
    /// </summary>
    let Recommendation = _prefixId.prefix "Recommendation"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : for</para>
    ///   <para>rdfs:comment : Relates a recommendation to someone or something.</para>
    ///   <a href="http://purl.org/ontology/rec/core#for">rec:for</a>
    /// </summary>
    let for_ = _prefixId.prefix "for"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : ranked recommendation object</para>
    ///   <para>rdfs:comment : A ranked recommendation object in a ranked recommendation</para>
    ///   <a href="http://purl.org/ontology/rec/core#ranked_recommendation_object">rec:ranked_recommendation_object</a>
    /// </summary>
    let ranked_recommendation_object = _prefixId.prefix "ranked_recommendation_object"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : has recommendation</para>
    ///   <para>rdfs:comment : A recommendation for someone or something.</para>
    ///   <a href="http://purl.org/ontology/rec/core#recommendation">rec:recommendation</a>
    /// </summary>
    let recommendation = _prefixId.prefix "recommendation"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : has recommendation audience</para>
    ///   <para>rdfs:comment : An audience for a specific recommendation.</para>
    ///   <a href="http://purl.org/ontology/rec/core#recommendation_audience">rec:recommendation_audience</a>
    /// </summary>
    let recommendation_audience = _prefixId.prefix "recommendation_audience"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : has recommendation object</para>
    ///   <para>rdfs:comment : A recommendation object that is part of a specific recommendation.</para>
    ///   <a href="http://purl.org/ontology/rec/core#recommendation_object">rec:recommendation_object</a>
    /// </summary>
    let recommendation_object = _prefixId.prefix "recommendation_object"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : recommended in</para>
    ///   <para>rdfs:comment : A thing, which is recommended in a recommendation.</para>
    ///   <a href="http://purl.org/ontology/rec/core#recommended_in">rec:recommended_in</a>
    /// </summary>
    let recommended_in = _prefixId.prefix "recommended_in"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : has recommender</para>
    ///   <para>rdfs:comment : An agent, which provided/calculated this recommendation.</para>
    ///   <a href="http://purl.org/ontology/rec/core#recommender">rec:recommender</a>
    /// </summary>
    let recommender = _prefixId.prefix "recommender"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : recommends</para>
    ///   <para>rdfs:comment : An agent recommends a recommendation to someone or a recommendation audience.</para>
    ///   <a href="http://purl.org/ontology/rec/core#recommends">rec:recommends</a>
    /// </summary>
    let recommends = _prefixId.prefix "recommends"
