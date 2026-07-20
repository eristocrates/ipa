namespace http.purl.org.voc.vrank.hash

open DoxAletheia

module vrank =
    let _namespace_name = "http://purl.org/voc/vrank#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A ranking algorithm used to compute the ranking scores associated with an item (vrank:Rank).
    /// <see href="http://purl.org/voc/vrank#Algorithm"></see></summary>
    let Algorithm = _prefix "Algorithm"
    /// <summary>
    /// A feature of a vrank:Algorithm such as Granularity, RankingFactor, etc.
    /// <see href="http://purl.org/voc/vrank#Feature"></see></summary>
    let Feature = _prefix "Feature"
    /// <summary>
    /// A parameter of a vrank:Algorithm such as number of iterations or damping factor.
    /// <see href="http://purl.org/voc/vrank#Parameter"></see></summary>
    let Parameter = _prefix "Parameter"
    /// <summary>
    /// Represents a ranking score associated with an item.
    /// <see href="http://purl.org/voc/vrank#Rank"></see></summary>
    let Rank = _prefix "Rank"
    /// <summary>
    /// A vrank:Rank is computed by an vrank:Algorithm.
    /// <see href="http://purl.org/voc/vrank#computedBy"></see></summary>
    let computedBy = _prefix "computedBy"
    /// <summary>
    /// The id associated to a vrank:Feature.
    /// <see href="http://purl.org/voc/vrank#featureId"></see></summary>
    let featureId = _prefix "featureId"
    /// <summary>
    /// The value associated to a vrank:Feature.
    /// <see href="http://purl.org/voc/vrank#featureValue"></see></summary>
    let featureValue = _prefix "featureValue"
    /// <summary>
    /// TODO.
    /// <see href="http://purl.org/voc/vrank#hasFeature"></see></summary>
    let hasFeature = _prefix "hasFeature"
    /// <summary>
    /// A vrank:Algorithm has a name.
    /// <see href="http://purl.org/voc/vrank#hasName"></see></summary>
    let hasName = _prefix "hasName"
    /// <summary>
    /// TODO.
    /// <see href="http://purl.org/voc/vrank#hasParameter"></see></summary>
    let hasParameter = _prefix "hasParameter"
    /// <summary>
    /// A subject, property or object hasRank a vrank:Rank.
    /// <see href="http://purl.org/voc/vrank#hasRank"></see></summary>
    let hasRank = _prefix "hasRank"
    /// <summary>
    /// The time when a vrank:Rank was computed.
    /// <see href="http://purl.org/voc/vrank#hasRankTimeStamp"></see></summary>
    let hasRankTimeStamp = _prefix "hasRankTimeStamp"
    /// <summary>
    /// The id associated to a vrank:Parameter.
    /// <see href="http://purl.org/voc/vrank#paramId"></see></summary>
    let paramId = _prefix "paramId"
    /// <summary>
    /// The value associated to a vrank:Parameter.
    /// <see href="http://purl.org/voc/vrank#paramValue"></see></summary>
    let paramValue = _prefix "paramValue"
    /// <summary>
    /// The numerical value associated to a vrank:Rank.
    /// <see href="http://purl.org/voc/vrank#rankValue"></see></summary>
    let rankValue = _prefix "rankValue"
