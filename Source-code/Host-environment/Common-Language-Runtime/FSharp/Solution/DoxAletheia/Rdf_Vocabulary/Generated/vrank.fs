namespace http.purl.org.voc.vrank.hash

open DoxAletheia.Rdf_Vocabulary

module vrank =
    let _namespace_name = "http://purl.org/voc/vrank#"
    /// <summary>
    /// A ranking algorithm used to compute the ranking scores associated with an item (vrank:Rank).
    /// <see href="http://purl.org/voc/vrank#Algorithm"></see></summary>
    let Algorithm = Namespaced_IRI.parse _namespace_name "Algorithm" |> NamespacedName
    /// <summary>
    /// A feature of a vrank:Algorithm such as Granularity, RankingFactor, etc.
    /// <see href="http://purl.org/voc/vrank#Feature"></see></summary>
    let Feature = Namespaced_IRI.parse _namespace_name "Feature" |> NamespacedName
    /// <summary>
    /// A parameter of a vrank:Algorithm such as number of iterations or damping factor.
    /// <see href="http://purl.org/voc/vrank#Parameter"></see></summary>
    let Parameter = Namespaced_IRI.parse _namespace_name "Parameter" |> NamespacedName
    /// <summary>
    /// Represents a ranking score associated with an item.
    /// <see href="http://purl.org/voc/vrank#Rank"></see></summary>
    let Rank = Namespaced_IRI.parse _namespace_name "Rank" |> NamespacedName
    /// <summary>
    /// A vrank:Rank is computed by an vrank:Algorithm.
    /// <see href="http://purl.org/voc/vrank#computedBy"></see></summary>
    let computedBy = Namespaced_IRI.parse _namespace_name "computedBy" |> NamespacedName
    /// <summary>
    /// The id associated to a vrank:Feature.
    /// <see href="http://purl.org/voc/vrank#featureId"></see></summary>
    let featureId = Namespaced_IRI.parse _namespace_name "featureId" |> NamespacedName

    /// <summary>
    /// The value associated to a vrank:Feature.
    /// <see href="http://purl.org/voc/vrank#featureValue"></see></summary>
    let featureValue =
        Namespaced_IRI.parse _namespace_name "featureValue" |> NamespacedName

    /// <summary>
    /// TODO.
    /// <see href="http://purl.org/voc/vrank#hasFeature"></see></summary>
    let hasFeature = Namespaced_IRI.parse _namespace_name "hasFeature" |> NamespacedName
    /// <summary>
    /// A vrank:Algorithm has a name.
    /// <see href="http://purl.org/voc/vrank#hasName"></see></summary>
    let hasName = Namespaced_IRI.parse _namespace_name "hasName" |> NamespacedName

    /// <summary>
    /// TODO.
    /// <see href="http://purl.org/voc/vrank#hasParameter"></see></summary>
    let hasParameter =
        Namespaced_IRI.parse _namespace_name "hasParameter" |> NamespacedName

    /// <summary>
    /// A subject, property or object hasRank a vrank:Rank.
    /// <see href="http://purl.org/voc/vrank#hasRank"></see></summary>
    let hasRank = Namespaced_IRI.parse _namespace_name "hasRank" |> NamespacedName

    /// <summary>
    /// The time when a vrank:Rank was computed.
    /// <see href="http://purl.org/voc/vrank#hasRankTimeStamp"></see></summary>
    let hasRankTimeStamp =
        Namespaced_IRI.parse _namespace_name "hasRankTimeStamp" |> NamespacedName

    /// <summary>
    /// The id associated to a vrank:Parameter.
    /// <see href="http://purl.org/voc/vrank#paramId"></see></summary>
    let paramId = Namespaced_IRI.parse _namespace_name "paramId" |> NamespacedName
    /// <summary>
    /// The value associated to a vrank:Parameter.
    /// <see href="http://purl.org/voc/vrank#paramValue"></see></summary>
    let paramValue = Namespaced_IRI.parse _namespace_name "paramValue" |> NamespacedName
    /// <summary>
    /// The numerical value associated to a vrank:Rank.
    /// <see href="http://purl.org/voc/vrank#rankValue"></see></summary>
    let rankValue = Namespaced_IRI.parse _namespace_name "rankValue" |> NamespacedName
