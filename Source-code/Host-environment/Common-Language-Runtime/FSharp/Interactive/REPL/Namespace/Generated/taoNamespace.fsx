#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module tao =
    let _prefixId = PrefixId.fromNamespaceLabel "http://vocab.deri.ie/tao#" "tao"
    let ``DERI%2C%20NUI%20Galway`` = _prefixId.prefix "DERI%2C%20NUI%20Galway"
    /// <summary>
    ///   <para>rdfs:label : A trust assertion describes asserted user's subjective trust values for either the source, the content or a requester based on various Social factors.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/tao#TrustAssertion">tao:TrustAssertion</a>
    /// </summary>
    let TrustAssertion = _prefixId.prefix "TrustAssertion"
    /// <summary>
    ///   <para>rdfs:label : A class that specifies the min and max range of values for the subjective trust values.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/tao#TrustScale">tao:TrustScale</a>
    /// </summary>
    let TrustScale = _prefixId.prefix "TrustScale"
    /// <summary>
    ///   <para>rdfs:label : A class that specifies the subjective trust value within a min and max range described by tao:TrustScale^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/tao#TrustValue">tao:TrustValue</a>
    /// </summary>
    let TrustValue = _prefixId.prefix "TrustValue"
    /// <summary>
    ///   <para>rdfs:label : Identifies the agent (i.e. the requester) whom the user’s subjective trust value is about.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/tao#appliesToAgent">tao:appliesToAgent</a>
    /// </summary>
    let appliesToAgent = _prefixId.prefix "appliesToAgent"
    /// <summary>
    ///   <para>rdfs:label : Identifies the content which the user’s subjective trust value is about.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/tao#appliesToContent">tao:appliesToContent</a>
    /// </summary>
    let appliesToContent = _prefixId.prefix "appliesToContent"
    /// <summary>
    ///   <para>rdfs:label : Identifies the source which the user’s subjective trust value is about.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/tao#appliesToSource">tao:appliesToSource</a>
    /// </summary>
    let appliesToSource = _prefixId.prefix "appliesToSource"
    /// <summary>
    ///   <para>rdfs:label : Identifies who assigned the trust values.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/tao#assertedBy">tao:assertedBy</a>
    /// </summary>
    let assertedBy = _prefixId.prefix "assertedBy"
    /// <summary>
    ///   <para>rdfs:label : Specifies the user's subjective trust value based on the number of comments which friends have exchanged with the requester.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/tao#hasCommentsTrust">tao:hasCommentsTrust</a>
    /// </summary>
    let hasCommentsTrust = _prefixId.prefix "hasCommentsTrust"
    /// <summary>
    ///   <para>rdfs:label : Specifies the user's subjective trust value based on the requester's identity.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/tao#hasIdentityTrust">tao:hasIdentityTrust</a>
    /// </summary>
    let hasIdentityTrust = _prefixId.prefix "hasIdentityTrust"
    /// <summary>
    ///   <para>rdfs:label : Specifies the user's subjective trust value based on the number of interactions between the user and the requester.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/tao#hasInteractionsTrust">tao:hasInteractionsTrust</a>
    /// </summary>
    let hasInteractionsTrust = _prefixId.prefix "hasInteractionsTrust"
    /// <summary>
    ///   <para>rdfs:label : Specifies the user's subjective trust value based on the number of Likes, +1s or Favorites which friends have given to content which is being requested by the user or the number of Likes, +1s or Favorites given to other users.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/tao#hasLikesTrust">tao:hasLikesTrust</a>
    /// </summary>
    let hasLikesTrust = _prefixId.prefix "hasLikesTrust"
    /// <summary>
    ///   <para>rdfs:label : The maximum value within a trust range (i.e. a trust scale).^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/tao#hasMaxValue">tao:hasMaxValue</a>
    /// </summary>
    let hasMaxValue = _prefixId.prefix "hasMaxValue"
    /// <summary>
    ///   <para>rdfs:label : The minimum value within a trust range (i.e. a trust scale).^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/tao#hasMinValue">tao:hasMinValue</a>
    /// </summary>
    let hasMinValue = _prefixId.prefix "hasMinValue"
    /// <summary>
    ///   <para>rdfs:label : Specifies the user's subjective trust value based on how similar the user's profile and the requester's profile are.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/tao#hasProfileSimilarityTrust">tao:hasProfileSimilarityTrust</a>
    /// </summary>
    let hasProfileSimilarityTrust = _prefixId.prefix "hasProfileSimilarityTrust"
    /// <summary>
    ///   <para>rdfs:label : Specifies the user's subjective trust value based on the relationship type between a user and a requester.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/tao#hasRelationshipTrust">tao:hasRelationshipTrust</a>
    /// </summary>
    let hasRelationshipTrust = _prefixId.prefix "hasRelationshipTrust"
    /// <summary>
    ///   <para>rdfs:label : Specifies the user's subjective trust value based on the requester's reputation within a Social Network.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/tao#hasReputationTrust">tao:hasReputationTrust</a>
    /// </summary>
    let hasReputationTrust = _prefixId.prefix "hasReputationTrust"
    /// <summary>
    ///   <para>rdfs:label : Specifies the user's subjective trust value based on the number of re-shares of content which friends have re-shared.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/tao#hasResharesTrust">tao:hasResharesTrust</a>
    /// </summary>
    let hasResharesTrust = _prefixId.prefix "hasResharesTrust"
    /// <summary>
    ///   <para>rdfs:label : Specifies the user's subjective trust value based on the number of shares of the content which friends have shared.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/tao#hasSharesTrust">tao:hasSharesTrust</a>
    /// </summary>
    let hasSharesTrust = _prefixId.prefix "hasSharesTrust"
    /// <summary>
    ///   <para>rdfs:label : Specifies the user's subjective trust value based on the number of tags or mentions of requesters by the user's friends.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/tao#hasTaggingTrust">tao:hasTaggingTrust</a>
    /// </summary>
    let hasTaggingTrust = _prefixId.prefix "hasTaggingTrust"
    /// <summary>
    ///   <para>rdfs:label : Identifies which trust scale range the trust values have to be within.^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/tao#hasTrustScale">tao:hasTrustScale</a>
    /// </summary>
    let hasTrustScale = _prefixId.prefix "hasTrustScale"
    /// <summary>
    ///   <para>rdfs:label : The subjective trust value. ^^xsd:string</para>
    ///   <a href="http://vocab.deri.ie/tao#hasValue">tao:hasValue</a>
    /// </summary>
    let hasValue = _prefixId.prefix "hasValue"
    let owesac = _prefixId.prefix "owesac"
    let rdf = _prefixId.prefix "rdf"
    let ttl = _prefixId.prefix "ttl"
