namespace http.www.w3.org.ns.duv.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module duv =
    let _namespace_iri = Namespace_Iri duv |> NamespaceIRI
    /// <summary>
    ///   <para>duv:RatingFeedback</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Predefined criteria used to express a user opinion about a dataset or distribution using a discrete range of values."</para>
    /// labels<para>"Rating Feedback"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/duv#RatingFeedback">http://www.w3.org/ns/duv#RatingFeedback</seealso>
    let RatingFeedback = Prefixed_Name(duv, "RatingFeedback") |> PrefixedName
    /// <summary>
    ///   <para>duv:Usage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A helpful description of actions that can be performed on a given dataset or distribution."</para>
    /// labels<para>"Usage"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/duv#Usage">http://www.w3.org/ns/duv#Usage</seealso>
    let Usage = Prefixed_Name(duv, "Usage") |> PrefixedName
    /// <summary>
    ///   <para>duv:UsageTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A synopsis describing the way a tool can use a dataset or distribution."</para>
    /// labels<para>"UsageTool"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/duv#UsageTool">http://www.w3.org/ns/duv#UsageTool</seealso>
    let UsageTool = Prefixed_Name(duv, "UsageTool") |> PrefixedName
    /// <summary>
    ///   <para>duv:UserFeedback</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"User feedback on the dataset. Expresses whether the dataset was useful or not, for example."</para>
    /// labels<para>"User Feedback"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/duv#UserFeedback">http://www.w3.org/ns/duv#UserFeedback</seealso>
    let UserFeedback = Prefixed_Name(duv, "UserFeedback") |> PrefixedName
    /// <summary>
    ///   <para>duv:hasDistributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The distributor is the organization that makes the dataset available for downloading and use."</para>
    /// labels<para>"has distributor"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/duv#hasDistributor">http://www.w3.org/ns/duv#hasDistributor</seealso>
    let hasDistributor = Prefixed_Name(duv, "hasDistributor") |> PrefixedName
    /// <summary>
    ///   <para>duv:hasFeedback</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"User feedback associated with Dataset or distribution"</para>
    /// labels<para>"has dataset feedback"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/duv#hasFeedback">http://www.w3.org/ns/duv#hasFeedback</seealso>
    let hasFeedback = Prefixed_Name(duv, "hasFeedback") |> PrefixedName
    /// <summary>
    ///   <para>duv:hasRating</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Rating Feedback has rating opinion"</para>
    /// labels<para>"has rating"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/duv#hasRating">http://www.w3.org/ns/duv#hasRating</seealso>
    let hasRating = Prefixed_Name(duv, "hasRating") |> PrefixedName
    /// <summary>
    ///   <para>duv:hasUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Dataset/distribution usage guidance or instructions."</para>
    /// labels<para>"has dataset/distribution usage"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/duv#hasUsage">http://www.w3.org/ns/duv#hasUsage</seealso>
    let hasUsage = Prefixed_Name(duv, "hasUsage") |> PrefixedName
    /// <summary>
    ///   <para>duv:hasUsageTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Describes the tool that provides the Usage "</para>
    /// labels<para>"has usage tool"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/duv#hasUsageTool">http://www.w3.org/ns/duv#hasUsageTool</seealso>
    let hasUsageTool = Prefixed_Name(duv, "hasUsageTool") |> PrefixedName
    /// <summary>
    ///   <para>duv:refersTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Dataset associated with Usage. "</para>
    /// labels<para>"refers to dataset"</para></remarks>
    /// <seealso href="http://www.w3.org/ns/duv#refersTo">http://www.w3.org/ns/duv#refersTo</seealso>
    let refersTo = Prefixed_Name(duv, "refersTo") |> PrefixedName
