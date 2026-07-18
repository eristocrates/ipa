namespace http.purl.org.ontology._rec.core.hash

open DoxAletheia.Rdf_Vocabulary

module rec_ =
    let _namespace_name = "http://purl.org/ontology/rec/core#"

    /// <summary>
    /// A ranked recommendation that includes an ordered list of recommendations.
    /// <see href="http://purl.org/ontology/rec/core#RankedRecommendation"></see></summary>
    let RankedRecommendation =
        Namespaced_IRI.parse _namespace_name "RankedRecommendation" |> NamespacedName

    /// <summary>
    /// A recommendation of something for someone or a specific audience by a recommender.
    /// <see href="http://purl.org/ontology/rec/core#Recommendation"></see></summary>
    let Recommendation =
        Namespaced_IRI.parse _namespace_name "Recommendation" |> NamespacedName

    /// <summary>
    /// Relates a recommendation to someone or something.
    /// <see href="http://purl.org/ontology/rec/core#for"></see></summary>
    let for_ = Namespaced_IRI.parse _namespace_name "for" |> NamespacedName

    /// <summary>
    /// A recommendation for someone or something.
    /// <see href="http://purl.org/ontology/rec/core#recommendation"></see></summary>
    let recommendation =
        Namespaced_IRI.parse _namespace_name "recommendation" |> NamespacedName

    /// <summary>
    /// A ranked recommendation object in a ranked recommendation
    /// <see href="http://purl.org/ontology/rec/core#ranked_recommendation_object"></see></summary>
    let ranked_recommendation_object =
        Namespaced_IRI.parse _namespace_name "ranked_recommendation_object" |> NamespacedName

    /// <summary>
    /// A recommendation object that is part of a specific recommendation.
    /// <see href="http://purl.org/ontology/rec/core#recommendation_object"></see></summary>
    let recommendation_object =
        Namespaced_IRI.parse _namespace_name "recommendation_object" |> NamespacedName

    /// <summary>
    /// An audience for a specific recommendation.
    /// <see href="http://purl.org/ontology/rec/core#recommendation_audience"></see></summary>
    let recommendation_audience =
        Namespaced_IRI.parse _namespace_name "recommendation_audience" |> NamespacedName

    /// <summary>
    /// A thing, which is recommended in a recommendation.
    /// <see href="http://purl.org/ontology/rec/core#recommended_in"></see></summary>
    let recommended_in =
        Namespaced_IRI.parse _namespace_name "recommended_in" |> NamespacedName

    /// <summary>
    /// An agent, which provided/calculated this recommendation.
    /// <see href="http://purl.org/ontology/rec/core#recommender"></see></summary>
    let recommender =
        Namespaced_IRI.parse _namespace_name "recommender" |> NamespacedName

    /// <summary>
    /// An agent recommends a recommendation to someone or a recommendation audience.
    /// <see href="http://purl.org/ontology/rec/core#recommends"></see></summary>
    let recommends = Namespaced_IRI.parse _namespace_name "recommends" |> NamespacedName
