#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module duv =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/duv#" "duv"
    /// <summary>
    ///   <para>rdfs:label : Rating Feedback</para>
    ///   <para>rdfs:comment : Predefined criteria used to express a user opinion about a dataset or distribution using a discrete range of values.</para>
    ///   <a href="http://www.w3.org/ns/duv#RatingFeedback">duv:RatingFeedback</a>
    /// </summary>
    let RatingFeedback = _prefixId.prefix "RatingFeedback"
    /// <summary>
    ///   <para>rdfs:label : Usage</para>
    ///   <para>rdfs:comment : A helpful description of actions that can be performed on a given dataset or distribution.</para>
    ///   <a href="http://www.w3.org/ns/duv#Usage">duv:Usage</a>
    /// </summary>
    let Usage = _prefixId.prefix "Usage"
    /// <summary>
    ///   <para>rdfs:label : UsageTool</para>
    ///   <para>rdfs:comment : A synopsis describing the way a tool can use a dataset or distribution.</para>
    ///   <a href="http://www.w3.org/ns/duv#UsageTool">duv:UsageTool</a>
    /// </summary>
    let UsageTool = _prefixId.prefix "UsageTool"
    /// <summary>
    ///   <para>rdfs:label : User Feedback</para>
    ///   <para>rdfs:comment : User feedback on the dataset. Expresses whether the dataset was useful or not, for example.</para>
    ///   <a href="http://www.w3.org/ns/duv#UserFeedback">duv:UserFeedback</a>
    /// </summary>
    let UserFeedback = _prefixId.prefix "UserFeedback"
    /// <summary>
    ///   <para>vann:usageNote : dcat:Dataset (subject) duv:hasDistributor (predicate) foaf:Agent (object)vann:usageNote : dcat:Distribution (subject) duv:hasDistributor (predicate) foaf:Agent (object)</para>
    ///   <para>rdfs:label : has distributor</para>
    ///   <para>rdfs:comment : The distributor is the organization that makes the dataset available for downloading and use.</para>
    ///   <a href="http://www.w3.org/ns/duv#hasDistributor">duv:hasDistributor</a>
    /// </summary>
    let hasDistributor = _prefixId.prefix "hasDistributor"
    /// <summary>
    ///   <para>vann:usageNote : dcat:Dataset (subject) duv:hasFeedback (predicate) duv:UserFeedback (object)vann:usageNote : dcat:Distribution (subject) duv:hasFeedback (predicate) duv:UserFeedback (object)</para>
    ///   <para>rdfs:label : has dataset feedback</para>
    ///   <para>rdfs:comment : User feedback associated with Dataset or distribution</para>
    ///   <a href="http://www.w3.org/ns/duv#hasFeedback">duv:hasFeedback</a>
    /// </summary>
    let hasFeedback = _prefixId.prefix "hasFeedback"
    /// <summary>
    ///   <para>rdfs:label : has rating</para>
    ///   <para>rdfs:comment : Rating Feedback has rating opinion</para>
    ///   <a href="http://www.w3.org/ns/duv#hasRating">duv:hasRating</a>
    /// </summary>
    let hasRating = _prefixId.prefix "hasRating"
    /// <summary>
    ///   <para>rdfs:label : has dataset/distribution usage</para>
    ///   <para>rdfs:comment : Dataset/distribution usage guidance or instructions.</para>
    ///   <a href="http://www.w3.org/ns/duv#hasUsage">duv:hasUsage</a>
    /// </summary>
    let hasUsage = _prefixId.prefix "hasUsage"
    /// <summary>
    ///   <para>rdfs:label : has usage tool</para>
    ///   <para>rdfs:comment : Describes the tool that provides the Usage </para>
    ///   <a href="http://www.w3.org/ns/duv#hasUsageTool">duv:hasUsageTool</a>
    /// </summary>
    let hasUsageTool = _prefixId.prefix "hasUsageTool"
    /// <summary>
    ///   <para>rdfs:label : refers to dataset</para>
    ///   <para>rdfs:comment : Dataset associated with Usage. </para>
    ///   <a href="http://www.w3.org/ns/duv#refersTo">duv:refersTo</a>
    /// </summary>
    let refersTo = _prefixId.prefix "refersTo"
