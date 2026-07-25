namespace http.vocab.deri.ie.tao.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ietao =
    let _namespace_iri = Namespace_Iri ietao |> NamespaceIRI
    /// <summary>
    ///   <para>ietao:owesac</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/tao#owesac">http://vocab.deri.ie/tao#owesac</seealso>
    let owesac = Prefixed_Name(ietao, "owesac") |> PrefixedName

    /// <summary>
    ///   <para>ietao:hasProfileSimilarityTrust</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Specifies the user's subjective trust value based on how similar the user's profile and the requester's profile are.</para></remarks>
    /// <seealso href="http://vocab.deri.ie/tao#hasProfileSimilarityTrust">http://vocab.deri.ie/tao#hasProfileSimilarityTrust</seealso>
    let hasProfileSimilarityTrust =
        Prefixed_Name(ietao, "hasProfileSimilarityTrust") |> PrefixedName

    /// <summary>
    ///   <para>ietao:hasSharesTrust</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Specifies the user's subjective trust value based on the number of shares of the content which friends have shared.</para></remarks>
    /// <seealso href="http://vocab.deri.ie/tao#hasSharesTrust">http://vocab.deri.ie/tao#hasSharesTrust</seealso>
    let hasSharesTrust = Prefixed_Name(ietao, "hasSharesTrust") |> PrefixedName

    /// <summary>
    ///   <para>ietao:DERI%2C%20NUI%20Galway</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:Agent</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/tao#DERI%2C%20NUI%20Galway">http://vocab.deri.ie/tao#DERI%2C%20NUI%20Galway</seealso>
    let ``DERI%2C%20NUI%20Galway`` =
        Prefixed_Name(ietao, "DERI%2C%20NUI%20Galway") |> PrefixedName

    /// <summary>
    ///   <para>ietao:TrustAssertion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>A trust assertion describes asserted user's subjective trust values for either the source, the content or a requester based on various Social factors.</para></remarks>
    /// <seealso href="http://vocab.deri.ie/tao#TrustAssertion">http://vocab.deri.ie/tao#TrustAssertion</seealso>
    let TrustAssertion = Prefixed_Name(ietao, "TrustAssertion") |> PrefixedName
    /// <summary>
    ///   <para>ietao:TrustValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>A class that specifies the subjective trust value within a min and max range described by tao:TrustScale</para></remarks>
    /// <seealso href="http://vocab.deri.ie/tao#TrustValue">http://vocab.deri.ie/tao#TrustValue</seealso>
    let TrustValue = Prefixed_Name(ietao, "TrustValue") |> PrefixedName
    /// <summary>
    ///   <para>ietao:TrustScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>A class that specifies the min and max range of values for the subjective trust values.</para></remarks>
    /// <seealso href="http://vocab.deri.ie/tao#TrustScale">http://vocab.deri.ie/tao#TrustScale</seealso>
    let TrustScale = Prefixed_Name(ietao, "TrustScale") |> PrefixedName
    /// <summary>
    ///   <para>ietao:appliesToAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Identifies the agent (i.e. the requester) whom the user’s subjective trust value is about.</para></remarks>
    /// <seealso href="http://vocab.deri.ie/tao#appliesToAgent">http://vocab.deri.ie/tao#appliesToAgent</seealso>
    let appliesToAgent = Prefixed_Name(ietao, "appliesToAgent") |> PrefixedName
    /// <summary>
    ///   <para>ietao:appliesToSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Identifies the source which the user’s subjective trust value is about.</para></remarks>
    /// <seealso href="http://vocab.deri.ie/tao#appliesToSource">http://vocab.deri.ie/tao#appliesToSource</seealso>
    let appliesToSource = Prefixed_Name(ietao, "appliesToSource") |> PrefixedName
    /// <summary>
    ///   <para>ietao:appliesToContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Identifies the content which the user’s subjective trust value is about.</para></remarks>
    /// <seealso href="http://vocab.deri.ie/tao#appliesToContent">http://vocab.deri.ie/tao#appliesToContent</seealso>
    let appliesToContent = Prefixed_Name(ietao, "appliesToContent") |> PrefixedName
    /// <summary>
    ///   <para>ietao:hasCommentsTrust</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Specifies the user's subjective trust value based on the number of comments which friends have exchanged with the requester.</para></remarks>
    /// <seealso href="http://vocab.deri.ie/tao#hasCommentsTrust">http://vocab.deri.ie/tao#hasCommentsTrust</seealso>
    let hasCommentsTrust = Prefixed_Name(ietao, "hasCommentsTrust") |> PrefixedName
    /// <summary>
    ///   <para>ietao:assertedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Identifies who assigned the trust values.</para></remarks>
    /// <seealso href="http://vocab.deri.ie/tao#assertedBy">http://vocab.deri.ie/tao#assertedBy</seealso>
    let assertedBy = Prefixed_Name(ietao, "assertedBy") |> PrefixedName
    /// <summary>
    ///   <para>ietao:hasIdentityTrust</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Specifies the user's subjective trust value based on the requester's identity.</para></remarks>
    /// <seealso href="http://vocab.deri.ie/tao#hasIdentityTrust">http://vocab.deri.ie/tao#hasIdentityTrust</seealso>
    let hasIdentityTrust = Prefixed_Name(ietao, "hasIdentityTrust") |> PrefixedName

    /// <summary>
    ///   <para>ietao:hasInteractionsTrust</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Specifies the user's subjective trust value based on the number of interactions between the user and the requester.</para></remarks>
    /// <seealso href="http://vocab.deri.ie/tao#hasInteractionsTrust">http://vocab.deri.ie/tao#hasInteractionsTrust</seealso>
    let hasInteractionsTrust =
        Prefixed_Name(ietao, "hasInteractionsTrust") |> PrefixedName

    /// <summary>
    ///   <para>ietao:hasLikesTrust</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Specifies the user's subjective trust value based on the number of Likes, +1s or Favorites which friends have given to content which is being requested by the user or the number of Likes, +1s or Favorites given to other users.</para></remarks>
    /// <seealso href="http://vocab.deri.ie/tao#hasLikesTrust">http://vocab.deri.ie/tao#hasLikesTrust</seealso>
    let hasLikesTrust = Prefixed_Name(ietao, "hasLikesTrust") |> PrefixedName
    /// <summary>
    ///   <para>ietao:hasMinValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>The minimum value within a trust range (i.e. a trust scale).</para></remarks>
    /// <seealso href="http://vocab.deri.ie/tao#hasMinValue">http://vocab.deri.ie/tao#hasMinValue</seealso>
    let hasMinValue = Prefixed_Name(ietao, "hasMinValue") |> PrefixedName
    /// <summary>
    ///   <para>ietao:hasMaxValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>The maximum value within a trust range (i.e. a trust scale).</para></remarks>
    /// <seealso href="http://vocab.deri.ie/tao#hasMaxValue">http://vocab.deri.ie/tao#hasMaxValue</seealso>
    let hasMaxValue = Prefixed_Name(ietao, "hasMaxValue") |> PrefixedName
    /// <summary>
    ///   <para>ietao:hasReputationTrust</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Specifies the user's subjective trust value based on the requester's reputation within a Social Network.</para></remarks>
    /// <seealso href="http://vocab.deri.ie/tao#hasReputationTrust">http://vocab.deri.ie/tao#hasReputationTrust</seealso>
    let hasReputationTrust = Prefixed_Name(ietao, "hasReputationTrust") |> PrefixedName
    /// <summary>
    ///   <para>ietao:hasTrustScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Identifies which trust scale range the trust values have to be within.</para></remarks>
    /// <seealso href="http://vocab.deri.ie/tao#hasTrustScale">http://vocab.deri.ie/tao#hasTrustScale</seealso>
    let hasTrustScale = Prefixed_Name(ietao, "hasTrustScale") |> PrefixedName

    /// <summary>
    ///   <para>ietao:hasRelationshipTrust</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Specifies the user's subjective trust value based on the relationship type between a user and a requester.</para></remarks>
    /// <seealso href="http://vocab.deri.ie/tao#hasRelationshipTrust">http://vocab.deri.ie/tao#hasRelationshipTrust</seealso>
    let hasRelationshipTrust =
        Prefixed_Name(ietao, "hasRelationshipTrust") |> PrefixedName

    /// <summary>
    ///   <para>ietao:hasResharesTrust</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Specifies the user's subjective trust value based on the number of re-shares of content which friends have re-shared.</para></remarks>
    /// <seealso href="http://vocab.deri.ie/tao#hasResharesTrust">http://vocab.deri.ie/tao#hasResharesTrust</seealso>
    let hasResharesTrust = Prefixed_Name(ietao, "hasResharesTrust") |> PrefixedName
    /// <summary>
    ///   <para>ietao:hasTaggingTrust</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Specifies the user's subjective trust value based on the number of tags or mentions of requesters by the user's friends.</para></remarks>
    /// <seealso href="http://vocab.deri.ie/tao#hasTaggingTrust">http://vocab.deri.ie/tao#hasTaggingTrust</seealso>
    let hasTaggingTrust = Prefixed_Name(ietao, "hasTaggingTrust") |> PrefixedName
    /// <summary>
    ///   <para>ietao:hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>The subjective trust value. </para></remarks>
    /// <seealso href="http://vocab.deri.ie/tao#hasValue">http://vocab.deri.ie/tao#hasValue</seealso>
    let hasValue = Prefixed_Name(ietao, "hasValue") |> PrefixedName
    /// <summary>
    ///   <para>ietao:rdf</para>
    /// </summary>
    /// <remarks>
    ///   <para>adms:SemanticDistribution</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/tao#rdf">http://vocab.deri.ie/tao#rdf</seealso>
    let rdf = Prefixed_Name(ietao, "rdf") |> PrefixedName
    /// <summary>
    ///   <para>ietao:ttl</para>
    /// </summary>
    /// <remarks>
    ///   <para>adms:SemanticDistribution</para>
    /// </remarks>
    /// <seealso href="http://vocab.deri.ie/tao#ttl">http://vocab.deri.ie/tao#ttl</seealso>
    let ttl = Prefixed_Name(ietao, "ttl") |> PrefixedName
