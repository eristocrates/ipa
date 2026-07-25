namespace https.liidr.org.trust_recommendation_in_social_internet_of_things.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tresiot =
    let _namespace_iri = Namespace_Iri tresiot |> NamespaceIRI

    /// <summary>
    ///   <para>tresiot:CertificateBasedRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Certificate-based relationships establish relationships based on the affiliation of the certificate.</para>
    /// labels<para>Certificate-based Relationship</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/CertificateBasedRelationship">https://liidr.org/trust-recommendation-in-social-internet-of-things/CertificateBasedRelationship</seealso>
    let CertificateBasedRelationship =
        Prefixed_Name(tresiot, "CertificateBasedRelationship") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:CoLocationObjectRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Co-Location relationships establish relationships based on the close proximity of two nodes.</para>
    /// labels<para>Co-Location Relationship</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/CoLocationObjectRelationship">https://liidr.org/trust-recommendation-in-social-internet-of-things/CoLocationObjectRelationship</seealso>
    let CoLocationObjectRelationship =
        Prefixed_Name(tresiot, "CoLocationObjectRelationship") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:Credibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Credibility refers to the degree to which a device, service requestor, or service provider is reliable and trustworthy.</para>
    /// labels<para>Credibility</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Credibility">https://liidr.org/trust-recommendation-in-social-internet-of-things/Credibility</seealso>
    let Credibility = Prefixed_Name(tresiot, "Credibility") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:NetworkTrafficMetric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The network traffic considers interaction-related attributes within the network.</para>
    /// labels<para>Network Traffic Metric</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/NetworkTrafficMetric">https://liidr.org/trust-recommendation-in-social-internet-of-things/NetworkTrafficMetric</seealso>
    let NetworkTrafficMetric =
        Prefixed_Name(tresiot, "NetworkTrafficMetric") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:DeliveryRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The delivery ratio consider transactions with a certain attribute in contrast to the overall transactions.</para>
    /// labels<para>Delivery Ratio</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/DeliveryRatio">https://liidr.org/trust-recommendation-in-social-internet-of-things/DeliveryRatio</seealso>
    let DeliveryRatio = Prefixed_Name(tresiot, "DeliveryRatio") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:DirectRecommendation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Direct Recommendation refers between the subjective node with directly interacted node that recommends its experience with the recommended node. The direct recommendation is a subclass of direct recommendation since a direct recommendation consists of two direct experiences.</para>
    /// labels<para>Direct Recommendation</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/DirectRecommendation">https://liidr.org/trust-recommendation-in-social-internet-of-things/DirectRecommendation</seealso>
    let DirectRecommendation =
        Prefixed_Name(tresiot, "DirectRecommendation") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:SubjectiveExperience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The subjective-based experience category includes only the local transaction context of one node with other nodes.</para>
    /// labels<para>Subjective-based Experience</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/SubjectiveExperience">https://liidr.org/trust-recommendation-in-social-internet-of-things/SubjectiveExperience</seealso>
    let SubjectiveExperience =
        Prefixed_Name(tresiot, "SubjectiveExperience") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>This ontology models trust recommendation concepts in SIoT to bridge the gap between abstract trust concepts and real-world device concepts.</para>
    /// </remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/">https://liidr.org/trust-recommendation-in-social-internet-of-things/</seealso>
    let _prefix_iri = Prefixed_Name(tresiot, "") |> PrefixedName
    /// <summary>
    ///   <para>tresiot:1.0.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/1.0.0">https://liidr.org/trust-recommendation-in-social-internet-of-things/1.0.0</seealso>
    let ``_1.0.0`` = Prefixed_Name(tresiot, "1.0.0") |> PrefixedName
    /// <summary>
    ///   <para>tresiot:Relationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The relationship concept defines the type of relationships that can exisit between nodes.</para>
    /// labels<para>Relationship</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Relationship">https://liidr.org/trust-recommendation-in-social-internet-of-things/Relationship</seealso>
    let Relationship = Prefixed_Name(tresiot, "Relationship") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:BetweennessCentrality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Betweenness centrality describes how often a node acts as an intermediate node between other nodes in the network. Nodes with a high betweenness centrality have a central role in the network to enable trust recommendation between other nodes.</para>
    /// labels<para>Betweenness Centrality</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/BetweennessCentrality">https://liidr.org/trust-recommendation-in-social-internet-of-things/BetweennessCentrality</seealso>
    let BetweennessCentrality =
        Prefixed_Name(tresiot, "BetweennessCentrality") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:NetworkSimilarityMetric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The network similarity measures local metrics that deviate from graph theory. For example, cooperativeness and centrality can be deviated based on the network metrics</para>
    /// labels<para>Network Similarity Metric</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/NetworkSimilarityMetric">https://liidr.org/trust-recommendation-in-social-internet-of-things/NetworkSimilarityMetric</seealso>
    let NetworkSimilarityMetric =
        Prefixed_Name(tresiot, "NetworkSimilarityMetric") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:ClosenessCentrality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Closeness centrality calculates how close a node is to all other nodes in the network. Nodes with a high closeness centrality are well-connected to other nodes in the network and can quickly access and share information with them.</para>
    /// labels<para>Closeness Centrality</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/ClosenessCentrality">https://liidr.org/trust-recommendation-in-social-internet-of-things/ClosenessCentrality</seealso>
    let ClosenessCentrality =
        Prefixed_Name(tresiot, "ClosenessCentrality") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:CommunityRecommendation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The community recommendation entity recommends multiple trust relations between and trustor and multiple trustee in the network based on the criteria in the given context.</para>
    /// labels<para>Community Recommendation</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/CommunityRecommendation">https://liidr.org/trust-recommendation-in-social-internet-of-things/CommunityRecommendation</seealso>
    let CommunityRecommendation =
        Prefixed_Name(tresiot, "CommunityRecommendation") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:SocialTrustMetric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The social trust metrics measure trust between two nodes based on their social properties.</para>
    /// labels<para>Social Trust Metric</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/SocialTrustMetric">https://liidr.org/trust-recommendation-in-social-internet-of-things/SocialTrustMetric</seealso>
    let SocialTrustMetric = Prefixed_Name(tresiot, "SocialTrustMetric") |> PrefixedName
    /// <summary>
    ///   <para>tresiot:DegreeCentrality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Degree centrality measures the number of relationships a node has within a network. Nodes with a high degree of centrality are well-connected within the network.</para>
    /// labels<para>Degree Centrality</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/DegreeCentrality">https://liidr.org/trust-recommendation-in-social-internet-of-things/DegreeCentrality</seealso>
    let DegreeCentrality = Prefixed_Name(tresiot, "DegreeCentrality") |> PrefixedName
    /// <summary>
    ///   <para>tresiot:DeliveryMetric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The delivery metric measures the satisfaction of the package delivery.</para>
    /// labels<para>Delivery Metric</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/DeliveryMetric">https://liidr.org/trust-recommendation-in-social-internet-of-things/DeliveryMetric</seealso>
    let DeliveryMetric = Prefixed_Name(tresiot, "DeliveryMetric") |> PrefixedName
    /// <summary>
    ///   <para>tresiot:Device</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>In the SAREF ontology, a tangible object is designed to accomplish a particular task. In order to accomplish this task, the device performs one or more functions. For example, a washing machine is designed to wash (task) and to accomplish this task it performs a start and stop function.</para>
    /// labels<para>Device</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Device">https://liidr.org/trust-recommendation-in-social-internet-of-things/Device</seealso>
    let Device = Prefixed_Name(tresiot, "Device") |> PrefixedName
    /// <summary>
    ///   <para>tresiot:DeviceReputation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The device reputation refers to collected ratings of individual devices about the rated device.</para>
    /// labels<para>Device Reputation</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/DeviceReputation">https://liidr.org/trust-recommendation-in-social-internet-of-things/DeviceReputation</seealso>
    let DeviceReputation = Prefixed_Name(tresiot, "DeviceReputation") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:ObjectiveExperience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The objective experience evaluation refers to collected ratings of individual nodes about the specific entity.</para>
    /// labels<para>Objective-based Experience</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/ObjectiveExperience">https://liidr.org/trust-recommendation-in-social-internet-of-things/ObjectiveExperience</seealso>
    let ObjectiveExperience =
        Prefixed_Name(tresiot, "ObjectiveExperience") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:DirectTrust</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Direct Trust refers to the experience between the subjective node with directly interacted node.</para>
    /// labels<para>Direct Trust</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/DirectTrust">https://liidr.org/trust-recommendation-in-social-internet-of-things/DirectTrust</seealso>
    let DirectTrust = Prefixed_Name(tresiot, "DirectTrust") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:TrustRecommendation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The trust recommendation entity provides a recommendation towards entities in the network</para>
    /// labels<para>Trust Recommendation</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/TrustRecommendation">https://liidr.org/trust-recommendation-in-social-internet-of-things/TrustRecommendation</seealso>
    let TrustRecommendation =
        Prefixed_Name(tresiot, "TrustRecommendation") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:DroppedPackageRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The dropped package ratio presents the number of dropped packages in contrast to the overall sent packges.</para>
    /// labels<para>Dropped Package Ratio</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/DroppedPackageRatio">https://liidr.org/trust-recommendation-in-social-internet-of-things/DroppedPackageRatio</seealso>
    let DroppedPackageRatio =
        Prefixed_Name(tresiot, "DroppedPackageRatio") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:FunctionReputation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The service reputation refers to collected ratings of individual service about the rated service.</para>
    /// labels<para>Service Reputation</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/FunctionReputation">https://liidr.org/trust-recommendation-in-social-internet-of-things/FunctionReputation</seealso>
    let FunctionReputation =
        Prefixed_Name(tresiot, "FunctionReputation") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:IndirectRecommendation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The indirect recommendation is a direct recommendation from a related node to the recommending node to the local transaction context of the node, whereas the |edge_distance| = 3.
    ///
    /// The indirect recommendation consists of one direct trust relationship and one direct recommendation relationships.</para>
    /// labels<para>Indirect Recommendation</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/IndirectRecommendation">https://liidr.org/trust-recommendation-in-social-internet-of-things/IndirectRecommendation</seealso>
    let IndirectRecommendation =
        Prefixed_Name(tresiot, "IndirectRecommendation") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:InteractionLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The interaction length describes how long two nodes have been interacting with to conclude trustworthiness between nodes.</para>
    /// labels<para>Interaction Length</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/InteractionLength">https://liidr.org/trust-recommendation-in-social-internet-of-things/InteractionLength</seealso>
    let InteractionLength = Prefixed_Name(tresiot, "InteractionLength") |> PrefixedName
    /// <summary>
    ///   <para>tresiot:Latency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Latency refers to the measured time delay for a data packet to travel from its source to its destination over a network.</para>
    /// labels<para>Latency</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Latency">https://liidr.org/trust-recommendation-in-social-internet-of-things/Latency</seealso>
    let Latency = Prefixed_Name(tresiot, "Latency") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:AttributeBasedRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Attribute-based relationships form the relationship based on node features between two nodes based on certain attributes.</para>
    /// labels<para>Attribute-based Relationship</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/AttributeBasedRelationship">https://liidr.org/trust-recommendation-in-social-internet-of-things/AttributeBasedRelationship</seealso>
    let AttributeBasedRelationship =
        Prefixed_Name(tresiot, "AttributeBasedRelationship") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:RetransmissionRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The retransmission rate referes to the number of retransmitted packets to the total number of packets transmitted.</para>
    /// labels<para>Retransmission Rate</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/RetransmissionRate">https://liidr.org/trust-recommendation-in-social-internet-of-things/RetransmissionRate</seealso>
    let RetransmissionRate =
        Prefixed_Name(tresiot, "RetransmissionRate") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:Centrality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Centrality refers to the relative importance or influence of a device or entity within the network</para>
    /// labels<para>Centrality</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Centrality">https://liidr.org/trust-recommendation-in-social-internet-of-things/Centrality</seealso>
    let Centrality = Prefixed_Name(tresiot, "Centrality") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:Trust_Decision_Setting_Recommendation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Trust Decision Setting Recommendation concerns about the recommendation of settings for trust decision-making.</para>
    /// labels<para>Trust Decision Setting Recommendation</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Trust_Decision_Setting_Recommendation">https://liidr.org/trust-recommendation-in-social-internet-of-things/Trust_Decision_Setting_Recommendation</seealso>
    let Trust_Decision_Setting_Recommendation =
        Prefixed_Name(tresiot, "Trust_Decision_Setting_Recommendation") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:Trust_Threshold_Recommendation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Trust Threshold Recommendation provides a recommendation for a threshold in a trust decision-marking process.</para>
    /// labels<para>Trust Threshold Recommendation</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Trust_Threshold_Recommendation">https://liidr.org/trust-recommendation-in-social-internet-of-things/Trust_Threshold_Recommendation</seealso>
    let Trust_Threshold_Recommendation =
        Prefixed_Name(tresiot, "Trust_Threshold_Recommendation") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:actsAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A node acts as trustor or as trustee.</para>
    /// labels<para>acts as</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/actsAs">https://liidr.org/trust-recommendation-in-social-internet-of-things/actsAs</seealso>
    let actsAs = Prefixed_Name(tresiot, "actsAs") |> PrefixedName
    /// <summary>
    ///   <para>tresiot:isActedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An trustor or and trustee are acted by a device.</para>
    /// labels<para>is acted by</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/isActedBy">https://liidr.org/trust-recommendation-in-social-internet-of-things/isActedBy</seealso>
    let isActedBy = Prefixed_Name(tresiot, "isActedBy") |> PrefixedName
    /// <summary>
    ///   <para>tresiot:isEstablishedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The transaction context is established by the trustor.</para>
    /// labels<para>is established by</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/isEstablishedBy">https://liidr.org/trust-recommendation-in-social-internet-of-things/isEstablishedBy</seealso>
    let isEstablishedBy = Prefixed_Name(tresiot, "isEstablishedBy") |> PrefixedName
    /// <summary>
    ///   <para>tresiot:forms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship forms the network.</para>
    /// labels<para>forms</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/forms">https://liidr.org/trust-recommendation-in-social-internet-of-things/forms</seealso>
    let forms = Prefixed_Name(tresiot, "forms") |> PrefixedName
    /// <summary>
    ///   <para>tresiot:hasTimestamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A transaction context has a timestamp</para>
    /// labels<para>has timestamp</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/hasTimestamp">https://liidr.org/trust-recommendation-in-social-internet-of-things/hasTimestamp</seealso>
    let hasTimestamp = Prefixed_Name(tresiot, "hasTimestamp") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:Class_Setting_Recommendation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Class Setting Recommendation provides recommendations towards the setting of classes for trust recommendations.</para>
    /// labels<para>Class Setting Recommendation</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Class_Setting_Recommendation">https://liidr.org/trust-recommendation-in-social-internet-of-things/Class_Setting_Recommendation</seealso>
    let Class_Setting_Recommendation =
        Prefixed_Name(tresiot, "Class_Setting_Recommendation") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:CoWorkRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Co-Work relationships establish relationships based on frequent cooperation.</para>
    /// labels<para>Co-Work Relationship</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/CoWorkRelationship">https://liidr.org/trust-recommendation-in-social-internet-of-things/CoWorkRelationship</seealso>
    let CoWorkRelationship =
        Prefixed_Name(tresiot, "CoWorkRelationship") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:Domain-specific_Trust_Recommendation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Domain-specific Trust Recommendation provides trust recommendation towards entities in this domain.</para>
    /// labels<para>Domain-specific Trust Recommendation</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Domain-specific_Trust_Recommendation">https://liidr.org/trust-recommendation-in-social-internet-of-things/Domain-specific_Trust_Recommendation</seealso>
    let Domain_specific_Trust_Recommendation =
        Prefixed_Name(tresiot, "Domain-specific_Trust_Recommendation") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:Cooperativeness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Cooperativeness refers to the willingness of devices or entities to work together towards a common goal. Therefore, cooperativeness can be determined by the degree of common friends between nodes (Bao, 2011).</para>
    /// labels<para>Cooperativeness</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Cooperativeness">https://liidr.org/trust-recommendation-in-social-internet-of-things/Cooperativeness</seealso>
    let Cooperativeness = Prefixed_Name(tresiot, "Cooperativeness") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:CumulativeBandwidthAverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The cumulative bandwidth average describes the maximum transfer capacity of a network in a given time interval.</para>
    /// labels<para>Cumulative Bandwidth Average</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/CumulativeBandwidthAverage">https://liidr.org/trust-recommendation-in-social-internet-of-things/CumulativeBandwidthAverage</seealso>
    let CumulativeBandwidthAverage =
        Prefixed_Name(tresiot, "CumulativeBandwidthAverage") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:links</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship links devices.</para>
    /// labels<para>links</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/links">https://liidr.org/trust-recommendation-in-social-internet-of-things/links</seealso>
    let links = Prefixed_Name(tresiot, "links") |> PrefixedName
    /// <summary>
    ///   <para>tresiot:isRecommendedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Trustor, Trustee, Network, and Relationship classes are recommended by Trust Recommendation.</para>
    /// labels<para>is recommended by</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/isRecommendedBy">https://liidr.org/trust-recommendation-in-social-internet-of-things/isRecommendedBy</seealso>
    let isRecommendedBy = Prefixed_Name(tresiot, "isRecommendedBy") |> PrefixedName
    /// <summary>
    ///   <para>tresiot:requests</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The trustee and the trustor request trust recommendations.</para>
    /// labels<para>requests</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/requests">https://liidr.org/trust-recommendation-in-social-internet-of-things/requests</seealso>
    let requests = Prefixed_Name(tresiot, "requests") |> PrefixedName
    /// <summary>
    ///   <para>tresiot:isRequiredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The transaction context is required by the trustor and the trustee.</para>
    /// labels<para>is required by</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/isRequiredBy">https://liidr.org/trust-recommendation-in-social-internet-of-things/isRequiredBy</seealso>
    let isRequiredBy = Prefixed_Name(tresiot, "isRequiredBy") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:Trust_Metric_Evaluation_Recommendation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Trust Metric Evaluation Recommendation entity provides a recommendation of trust evaluation metrics to review the produced trust recommendation in the exisiting situation.</para>
    /// labels<para>Trust Metric Evaluation Recommendation</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Trust_Metric_Evaluation_Recommendation">https://liidr.org/trust-recommendation-in-social-internet-of-things/Trust_Metric_Evaluation_Recommendation</seealso>
    let Trust_Metric_Evaluation_Recommendation =
        Prefixed_Name(tresiot, "Trust_Metric_Evaluation_Recommendation") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:communicatesIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A node is a component of the network.</para>
    /// labels<para>is component of</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/communicatesIn">https://liidr.org/trust-recommendation-in-social-internet-of-things/communicatesIn</seealso>
    let communicatesIn = Prefixed_Name(tresiot, "communicatesIn") |> PrefixedName
    /// <summary>
    ///   <para>tresiot:hasTrustValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A transaction context has a trust value</para>
    /// labels<para>has trust value</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/hasTrustValue">https://liidr.org/trust-recommendation-in-social-internet-of-things/hasTrustValue</seealso>
    let hasTrustValue = Prefixed_Name(tresiot, "hasTrustValue") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:PhysicalNetworkMetric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The physical network metric summarizes attributes to measure Quality-of-Service attributes to ensure reliablity and availability.</para>
    /// labels<para>Physical Network Metric</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/PhysicalNetworkMetric">https://liidr.org/trust-recommendation-in-social-internet-of-things/PhysicalNetworkMetric</seealso>
    let PhysicalNetworkMetric =
        Prefixed_Name(tresiot, "PhysicalNetworkMetric") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:Node</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A node can be perceived at various device levels depending on the granularity.</para>
    /// labels<para>Node</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Node">https://liidr.org/trust-recommendation-in-social-internet-of-things/Node</seealso>
    let Node = Prefixed_Name(tresiot, "Node") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:ExperienceBasedRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Experience-based relationships emerge from the transaction context between the service provider and the service requestor</para>
    /// labels<para>Experience-based Relationship</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/ExperienceBasedRelationship">https://liidr.org/trust-recommendation-in-social-internet-of-things/ExperienceBasedRelationship</seealso>
    let ExperienceBasedRelationship =
        Prefixed_Name(tresiot, "ExperienceBasedRelationship") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:SocialNetworkMetric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The social network metric provides information related to entities of the socialized network.</para>
    /// labels<para>Social Network Metric</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/SocialNetworkMetric">https://liidr.org/trust-recommendation-in-social-internet-of-things/SocialNetworkMetric</seealso>
    let SocialNetworkMetric =
        Prefixed_Name(tresiot, "SocialNetworkMetric") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:Node_Recommendation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The node recommendation entity recommends a node in the network that is most suitable to conduct at task depending on the evaluation metrics in the given context.</para>
    /// labels<para>Node Recommendation</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Node_Recommendation">https://liidr.org/trust-recommendation-in-social-internet-of-things/Node_Recommendation</seealso>
    let Node_Recommendation =
        Prefixed_Name(tresiot, "Node_Recommendation") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:PackageOverheadRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The package overhead ratio refers to the ratio of the packet header information to the payload information in a network packet.</para>
    /// labels<para>Package Overhead Ratio</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/PackageOverheadRatio">https://liidr.org/trust-recommendation-in-social-internet-of-things/PackageOverheadRatio</seealso>
    let PackageOverheadRatio =
        Prefixed_Name(tresiot, "PackageOverheadRatio") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:ParentalObjectRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A parental object relationship refers to objects that are manufactured in the same period of time by the same manufacturer.</para>
    /// labels<para>Parental Object Relationship</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/ParentalObjectRelationship">https://liidr.org/trust-recommendation-in-social-internet-of-things/ParentalObjectRelationship</seealso>
    let ParentalObjectRelationship =
        Prefixed_Name(tresiot, "ParentalObjectRelationship") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:RatioOfSuccessfulTransactions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The delivery ratio consider successful transactions in contrast to the overall transactions.</para>
    /// labels<para>Ratio Of Successful Transactions</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/RatioOfSuccessfulTransactions">https://liidr.org/trust-recommendation-in-social-internet-of-things/RatioOfSuccessfulTransactions</seealso>
    let RatioOfSuccessfulTransactions =
        Prefixed_Name(tresiot, "RatioOfSuccessfulTransactions") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:Relationship_Existance_Recommendation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Relationship Existance Recommendation entity provides a recommendation if a social link between two nodes exists.</para>
    /// labels<para>Relationship Existance Recommendation</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Relationship_Existance_Recommendation">https://liidr.org/trust-recommendation-in-social-internet-of-things/Relationship_Existance_Recommendation</seealso>
    let Relationship_Existance_Recommendation =
        Prefixed_Name(tresiot, "Relationship_Existance_Recommendation") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:OwnershipObjectRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The owner object relationship refers to devices that are owned by the same user</para>
    /// labels<para>Ownership-Object Relationship</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/OwnershipObjectRelationship">https://liidr.org/trust-recommendation-in-social-internet-of-things/OwnershipObjectRelationship</seealso>
    let OwnershipObjectRelationship =
        Prefixed_Name(tresiot, "OwnershipObjectRelationship") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:PackageTramsmissionRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The package transmission rate defines the number of transmitted packages in a given time interval.</para>
    /// labels<para>Package Tramsmission Rate</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/PackageTramsmissionRate">https://liidr.org/trust-recommendation-in-social-internet-of-things/PackageTramsmissionRate</seealso>
    let PackageTramsmissionRate =
        Prefixed_Name(tresiot, "PackageTramsmissionRate") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:RatioOfFailedTransactions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The delivery ratio consider failed transactions in contrast to the overall transactions.</para>
    /// labels<para>Ratio Of Failed Transactions</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/RatioOfFailedTransactions">https://liidr.org/trust-recommendation-in-social-internet-of-things/RatioOfFailedTransactions</seealso>
    let RatioOfFailedTransactions =
        Prefixed_Name(tresiot, "RatioOfFailedTransactions") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:TrustRelationRecommendation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The trust relation recommendation entity recommends a trust relation between the trustor and the trustee in the given context.</para>
    /// labels<para>Trust Relation Recommendation</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/TrustRelationRecommendation">https://liidr.org/trust-recommendation-in-social-internet-of-things/TrustRelationRecommendation</seealso>
    let TrustRelationRecommendation =
        Prefixed_Name(tresiot, "TrustRelationRecommendation") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:RepresentationOfTrust</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The representation of trust defines the concept of different trust representation. For example, trust can be represented using qualitative expressions, such as "Trusted" and "Untrusted", or binary expressions, such TRUE and FALSE</para>
    /// labels<para>Representation of Trust</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/RepresentationOfTrust">https://liidr.org/trust-recommendation-in-social-internet-of-things/RepresentationOfTrust</seealso>
    let RepresentationOfTrust =
        Prefixed_Name(tresiot, "RepresentationOfTrust") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:ResponseTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Response time refers to the time of a device to respond to a network request.</para>
    /// labels<para>Response Time</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/ResponseTime">https://liidr.org/trust-recommendation-in-social-internet-of-things/ResponseTime</seealso>
    let ResponseTime = Prefixed_Name(tresiot, "ResponseTime") |> PrefixedName
    /// <summary>
    ///   <para>tresiot:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A service is a node in Social Internet of Things.</para>
    /// labels<para>Service</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Service">https://liidr.org/trust-recommendation-in-social-internet-of-things/Service</seealso>
    let Service = Prefixed_Name(tresiot, "Service") |> PrefixedName
    /// <summary>
    ///   <para>tresiot:ServiceReputation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The function reputation refers to collected ratings of individual function about the rated function.</para>
    /// labels<para>Function Reputation</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/ServiceReputation">https://liidr.org/trust-recommendation-in-social-internet-of-things/ServiceReputation</seealso>
    let ServiceReputation = Prefixed_Name(tresiot, "ServiceReputation") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:Situation-Dependent_Trust_Settings_Recommendation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Situation-dependent Trust Recommendation entity captures concepts related to imrprove the trust recommendation based on the existing situation.</para>
    /// labels<para>Situation-dependent Trust Recommendation</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Situation-Dependent_Trust_Settings_Recommendation">https://liidr.org/trust-recommendation-in-social-internet-of-things/Situation-Dependent_Trust_Settings_Recommendation</seealso>
    let Situation_Dependent_Trust_Settings_Recommendation =
        Prefixed_Name(tresiot, "Situation-Dependent_Trust_Settings_Recommendation") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:Relationship_Labeling_Recommendation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Relationship Existance Recommendation entity provides a recommendation about the label of the link between two nodes exists. The label of a relationship can be a set of attributes, a specific name of the relationship, or a specific value.</para>
    /// labels<para>Relationship Labeling Recommendation</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Relationship_Labeling_Recommendation">https://liidr.org/trust-recommendation-in-social-internet-of-things/Relationship_Labeling_Recommendation</seealso>
    let Relationship_Labeling_Recommendation =
        Prefixed_Name(tresiot, "Relationship_Labeling_Recommendation") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:ServiceProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>The trustee is an agent that is perceived as trusted from the trustor to deliver a requested task in a given context in the expected manner.</para><para>Trustee</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/ServiceProvider">https://liidr.org/trust-recommendation-in-social-internet-of-things/ServiceProvider</seealso>
    let ServiceProvider = Prefixed_Name(tresiot, "ServiceProvider") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:SocialObjectRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Social Object Relationship defines occasionally encounters  of devices due to the relation between owners</para>
    /// labels<para>Social Object Relationship</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/SocialObjectRelationship">https://liidr.org/trust-recommendation-in-social-internet-of-things/SocialObjectRelationship</seealso>
    let SocialObjectRelationship =
        Prefixed_Name(tresiot, "SocialObjectRelationship") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:Throughput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Throughput represents the amount of data that is successfully transmitted in a network in a given period of time to measure the efficiency of a network.</para>
    /// labels<para>Throughput</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Throughput">https://liidr.org/trust-recommendation-in-social-internet-of-things/Throughput</seealso>
    let Throughput = Prefixed_Name(tresiot, "Throughput") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:TransactionContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The transaction context involves all attributes to model the perceived trust based in a given context.</para>
    /// labels<para>Transaction Context</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/TransactionContext">https://liidr.org/trust-recommendation-in-social-internet-of-things/TransactionContext</seealso>
    let TransactionContext =
        Prefixed_Name(tresiot, "TransactionContext") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:Trust_Feature_Recommendation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Trust Feature Recommendation entity provides a recommendation of trust features to produce trust recommendations based on the exisiting situation.</para>
    /// labels<para>Trust Feature Recommendation</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Trust_Feature_Recommendation">https://liidr.org/trust-recommendation-in-social-internet-of-things/Trust_Feature_Recommendation</seealso>
    let Trust_Feature_Recommendation =
        Prefixed_Name(tresiot, "Trust_Feature_Recommendation") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:Trust_Weight_Adaption_Recommendation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Trust Weight Adaption Recommendation entity provides recommendations to the appropriate weight for a feature in the current situation.</para>
    /// labels<para>Trust Weight Adaption Recommendation</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Trust_Weight_Adaption_Recommendation">https://liidr.org/trust-recommendation-in-social-internet-of-things/Trust_Weight_Adaption_Recommendation</seealso>
    let Trust_Weight_Adaption_Recommendation =
        Prefixed_Name(tresiot, "Trust_Weight_Adaption_Recommendation") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:isCommunicatedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A network has a device as component</para>
    /// labels<para>has component</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/isCommunicatedIn">https://liidr.org/trust-recommendation-in-social-internet-of-things/isCommunicatedIn</seealso>
    let isCommunicatedIn = Prefixed_Name(tresiot, "isCommunicatedIn") |> PrefixedName
    /// <summary>
    ///   <para>tresiot:establishes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A trustor establishes the transaction context.</para>
    /// labels<para>establishes</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/establishes">https://liidr.org/trust-recommendation-in-social-internet-of-things/establishes</seealso>
    let establishes = Prefixed_Name(tresiot, "establishes") |> PrefixedName
    /// <summary>
    ///   <para>tresiot:isFormedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The network is formed by relationships.</para>
    /// labels<para>is formed by</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/isFormedBy">https://liidr.org/trust-recommendation-in-social-internet-of-things/isFormedBy</seealso>
    let isFormedBy = Prefixed_Name(tresiot, "isFormedBy") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:hasRequestFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The transaction context has a requrest function</para>
    /// labels<para>has request function</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/hasRequestFunction">https://liidr.org/trust-recommendation-in-social-internet-of-things/hasRequestFunction</seealso>
    let hasRequestFunction =
        Prefixed_Name(tresiot, "hasRequestFunction") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:isLinkedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Devices are linked by relationships.</para>
    /// labels<para>is linked by</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/isLinkedBy">https://liidr.org/trust-recommendation-in-social-internet-of-things/isLinkedBy</seealso>
    let isLinkedBy = Prefixed_Name(tresiot, "isLinkedBy") |> PrefixedName
    /// <summary>
    ///   <para>tresiot:recommends</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Trust Recommendation recommends Networks, Relationships, Trustor, and Trustee.</para>
    /// labels<para>recommends</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/recommends">https://liidr.org/trust-recommendation-in-social-internet-of-things/recommends</seealso>
    let recommends = Prefixed_Name(tresiot, "recommends") |> PrefixedName
    /// <summary>
    ///   <para>tresiot:isRequestedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A trust recommendation is requested by a trustee or a trustor</para>
    /// labels<para>is requested by</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/isRequestedBy">https://liidr.org/trust-recommendation-in-social-internet-of-things/isRequestedBy</seealso>
    let isRequestedBy = Prefixed_Name(tresiot, "isRequestedBy") |> PrefixedName
    /// <summary>
    ///   <para>tresiot:requires</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The transaction context requires a trustor and a trustee.</para>
    /// labels<para>requires</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/requires">https://liidr.org/trust-recommendation-in-social-internet-of-things/requires</seealso>
    let requires = Prefixed_Name(tresiot, "requires") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:representsTrustValueIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The transaction context has a representsation of the trust value.</para>
    /// labels<para>represents Trust Value</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/representsTrustValueIn">https://liidr.org/trust-recommendation-in-social-internet-of-things/representsTrustValueIn</seealso>
    let representsTrustValueIn =
        Prefixed_Name(tresiot, "representsTrustValueIn") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:ServiceRequestor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The trustor is an agent that initiates the interaction to a perceived trustworthy agent, the trustee, to request a task in a given context to achieve its objective.</para>
    /// labels<para>Trustor</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/ServiceRequestor">https://liidr.org/trust-recommendation-in-social-internet-of-things/ServiceRequestor</seealso>
    let ServiceRequestor = Prefixed_Name(tresiot, "ServiceRequestor") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:TechnicalTrustRecommendation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Technical Trust Recommendation addresses technical issues of the trust computation, decision-making, and review to produce accurate trust recommendations.</para>
    /// labels<para>Technical Trust Recommendation</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/TechnicalTrustRecommendation">https://liidr.org/trust-recommendation-in-social-internet-of-things/TechnicalTrustRecommendation</seealso>
    let TechnicalTrustRecommendation =
        Prefixed_Name(tresiot, "TechnicalTrustRecommendation") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:Function</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A function is a node in Social Internet of Things.</para>
    /// labels<para>Function</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Function">https://liidr.org/trust-recommendation-in-social-internet-of-things/Function</seealso>
    let Function = Prefixed_Name(tresiot, "Function") |> PrefixedName
    /// <summary>
    ///   <para>tresiot:Honesty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Honesty refers to the degree to which a device, service requestor, or service provider is the accuracy of the delivered information. Honesty is determined through direct experiences from previous transactions.</para>
    /// labels<para>Honesty</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Honesty">https://liidr.org/trust-recommendation-in-social-internet-of-things/Honesty</seealso>
    let Honesty = Prefixed_Name(tresiot, "Honesty") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:InteractionFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Theinteraction frequency measures how often nodes have been interacting with each other.</para>
    /// labels<para>Interaction Frequency</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/InteractionFrequency">https://liidr.org/trust-recommendation-in-social-internet-of-things/InteractionFrequency</seealso>
    let InteractionFrequency =
        Prefixed_Name(tresiot, "InteractionFrequency") |> PrefixedName

    /// <summary>
    ///   <para>tresiot:TieStengthMetric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Tie strength formed by interaction-related attribtues from previous transactions</para>
    /// labels<para>Tie Strength Metric</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/TieStengthMetric">https://liidr.org/trust-recommendation-in-social-internet-of-things/TieStengthMetric</seealso>
    let TieStengthMetric = Prefixed_Name(tresiot, "TieStengthMetric") |> PrefixedName
    /// <summary>
    ///   <para>tresiot:TimeRelatedMetric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Time-dependent metric refers to the behavior of network traffic based on the time property.</para>
    /// labels<para>Time-dependent Metric</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/TimeRelatedMetric">https://liidr.org/trust-recommendation-in-social-internet-of-things/TimeRelatedMetric</seealso>
    let TimeRelatedMetric = Prefixed_Name(tresiot, "TimeRelatedMetric") |> PrefixedName
    /// <summary>
    ///   <para>tresiot:Network</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The network provides information related to the network</para>
    /// labels<para>Network</para></remarks>
    /// <seealso href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Network">https://liidr.org/trust-recommendation-in-social-internet-of-things/Network</seealso>
    let Network = Prefixed_Name(tresiot, "Network") |> PrefixedName
