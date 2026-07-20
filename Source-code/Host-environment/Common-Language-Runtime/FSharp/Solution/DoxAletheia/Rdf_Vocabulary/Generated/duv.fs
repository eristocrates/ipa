namespace http.www.w3.org.ns.duv.hash

open DoxAletheia

module duv =
    let _namespace_name = "http://www.w3.org/ns/duv#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Predefined criteria used to express a user opinion about a dataset or distribution using a discrete range of values.
    /// <see href="http://www.w3.org/ns/duv#RatingFeedback"></see></summary>
    let RatingFeedback = _prefix "RatingFeedback"
    /// <summary>
    /// User feedback on the dataset. Expresses whether the dataset was useful or not, for example.
    /// <see href="http://www.w3.org/ns/duv#UserFeedback"></see></summary>
    let UserFeedback = _prefix "UserFeedback"
    /// <summary>
    /// A helpful description of actions that can be performed on a given dataset or distribution.
    /// <see href="http://www.w3.org/ns/duv#Usage"></see></summary>
    let Usage = _prefix "Usage"
    /// <summary>
    /// A synopsis describing the way a tool can use a dataset or distribution.
    /// <see href="http://www.w3.org/ns/duv#UsageTool"></see></summary>
    let UsageTool = _prefix "UsageTool"
    /// <summary>
    /// The distributor is the organization that makes the dataset available for downloading and use.
    /// <see href="http://www.w3.org/ns/duv#hasDistributor"></see></summary>
    let hasDistributor = _prefix "hasDistributor"
    /// <summary>
    /// User feedback associated with Dataset or distribution
    /// <see href="http://www.w3.org/ns/duv#hasFeedback"></see></summary>
    let hasFeedback = _prefix "hasFeedback"
    /// <summary>
    /// Rating Feedback has rating opinion
    /// <see href="http://www.w3.org/ns/duv#hasRating"></see></summary>
    let hasRating = _prefix "hasRating"
    /// <summary>
    /// Dataset/distribution usage guidance or instructions.
    /// <see href="http://www.w3.org/ns/duv#hasUsage"></see></summary>
    let hasUsage = _prefix "hasUsage"
    /// <summary>
    /// Describes the tool that provides the Usage
    /// <see href="http://www.w3.org/ns/duv#hasUsageTool"></see></summary>
    let hasUsageTool = _prefix "hasUsageTool"
    /// <summary>
    /// Dataset associated with Usage.
    /// <see href="http://www.w3.org/ns/duv#refersTo"></see></summary>
    let refersTo = _prefix "refersTo"
