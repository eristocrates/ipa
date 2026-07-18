namespace http.www.w3.org.ns.duv.hash

open DoxAletheia.Rdf_Vocabulary

module duv =
    let _namespace_name = "http://www.w3.org/ns/duv#"

    /// <summary>
    /// Predefined criteria used to express a user opinion about a dataset or distribution using a discrete range of values.
    /// <see href="http://www.w3.org/ns/duv#RatingFeedback"></see></summary>
    let RatingFeedback =
        Namespaced_IRI.parse _namespace_name "RatingFeedback" |> NamespacedName

    /// <summary>
    /// User feedback on the dataset. Expresses whether the dataset was useful or not, for example.
    /// <see href="http://www.w3.org/ns/duv#UserFeedback"></see></summary>
    let UserFeedback =
        Namespaced_IRI.parse _namespace_name "UserFeedback" |> NamespacedName

    /// <summary>
    /// A helpful description of actions that can be performed on a given dataset or distribution.
    /// <see href="http://www.w3.org/ns/duv#Usage"></see></summary>
    let Usage = Namespaced_IRI.parse _namespace_name "Usage" |> NamespacedName
    /// <summary>
    /// A synopsis describing the way a tool can use a dataset or distribution.
    /// <see href="http://www.w3.org/ns/duv#UsageTool"></see></summary>
    let UsageTool = Namespaced_IRI.parse _namespace_name "UsageTool" |> NamespacedName

    /// <summary>
    /// The distributor is the organization that makes the dataset available for downloading and use.
    /// <see href="http://www.w3.org/ns/duv#hasDistributor"></see></summary>
    let hasDistributor =
        Namespaced_IRI.parse _namespace_name "hasDistributor" |> NamespacedName

    /// <summary>
    /// User feedback associated with Dataset or distribution
    /// <see href="http://www.w3.org/ns/duv#hasFeedback"></see></summary>
    let hasFeedback =
        Namespaced_IRI.parse _namespace_name "hasFeedback" |> NamespacedName

    /// <summary>
    /// Rating Feedback has rating opinion
    /// <see href="http://www.w3.org/ns/duv#hasRating"></see></summary>
    let hasRating = Namespaced_IRI.parse _namespace_name "hasRating" |> NamespacedName
    /// <summary>
    /// Dataset/distribution usage guidance or instructions.
    /// <see href="http://www.w3.org/ns/duv#hasUsage"></see></summary>
    let hasUsage = Namespaced_IRI.parse _namespace_name "hasUsage" |> NamespacedName

    /// <summary>
    /// Describes the tool that provides the Usage
    /// <see href="http://www.w3.org/ns/duv#hasUsageTool"></see></summary>
    let hasUsageTool =
        Namespaced_IRI.parse _namespace_name "hasUsageTool" |> NamespacedName

    /// <summary>
    /// Dataset associated with Usage.
    /// <see href="http://www.w3.org/ns/duv#refersTo"></see></summary>
    let refersTo = Namespaced_IRI.parse _namespace_name "refersTo" |> NamespacedName
