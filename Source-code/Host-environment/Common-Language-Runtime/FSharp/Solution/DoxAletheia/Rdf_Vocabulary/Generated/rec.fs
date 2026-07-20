namespace http.purl.org.ontology._rec.core.hash

open DoxAletheia

module rec_ =
    let _namespace_name = "http://purl.org/ontology/rec/core#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A ranked recommendation that includes an ordered list of recommendations.
    /// <see href="http://purl.org/ontology/rec/core#RankedRecommendation"></see></summary>
    let RankedRecommendation = _prefix "RankedRecommendation"
    /// <summary>
    /// A recommendation of something for someone or a specific audience by a recommender.
    /// <see href="http://purl.org/ontology/rec/core#Recommendation"></see></summary>
    let Recommendation = _prefix "Recommendation"
    /// <summary>
    /// Relates a recommendation to someone or something.
    /// <see href="http://purl.org/ontology/rec/core#for"></see></summary>
    let for_ = _prefix "for"
    /// <summary>
    /// A recommendation for someone or something.
    /// <see href="http://purl.org/ontology/rec/core#recommendation"></see></summary>
    let recommendation = _prefix "recommendation"
    /// <summary>
    /// A ranked recommendation object in a ranked recommendation
    /// <see href="http://purl.org/ontology/rec/core#ranked_recommendation_object"></see></summary>
    let ranked_recommendation_object = _prefix "ranked_recommendation_object"
    /// <summary>
    /// A recommendation object that is part of a specific recommendation.
    /// <see href="http://purl.org/ontology/rec/core#recommendation_object"></see></summary>
    let recommendation_object = _prefix "recommendation_object"
    /// <summary>
    /// An audience for a specific recommendation.
    /// <see href="http://purl.org/ontology/rec/core#recommendation_audience"></see></summary>
    let recommendation_audience = _prefix "recommendation_audience"
    /// <summary>
    /// A thing, which is recommended in a recommendation.
    /// <see href="http://purl.org/ontology/rec/core#recommended_in"></see></summary>
    let recommended_in = _prefix "recommended_in"
    /// <summary>
    /// An agent, which provided/calculated this recommendation.
    /// <see href="http://purl.org/ontology/rec/core#recommender"></see></summary>
    let recommender = _prefix "recommender"
    /// <summary>
    /// An agent recommends a recommendation to someone or a recommendation audience.
    /// <see href="http://purl.org/ontology/rec/core#recommends"></see></summary>
    let recommends = _prefix "recommends"
