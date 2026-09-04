#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module tresiot =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://liidr.org/trust-recommendation-in-social-internet-of-things/" "tresiot"

    let _namespaceIri = _prefixId.prefix ""
    let ``_1.0.0`` = _prefixId.prefix "1.0.0"
    /// <summary>
    ///   <para>rdfs:label : Attribute-based Relationship</para>
    ///   <para>rdfs:comment : Attribute-based relationships form the relationship based on node features between two nodes based on certain attributes.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/AttributeBasedRelationship">tresiot:AttributeBasedRelationship</a>
    /// </summary>
    let AttributeBasedRelationship = _prefixId.prefix "AttributeBasedRelationship"
    /// <summary>
    ///   <para>rdfs:label : Betweenness Centrality</para>
    ///   <para>rdfs:comment : Betweenness centrality describes how often a node acts as an intermediate node between other nodes in the network. Nodes with a high betweenness centrality have a central role in the network to enable trust recommendation between other nodes.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/BetweennessCentrality">tresiot:BetweennessCentrality</a>
    /// </summary>
    let BetweennessCentrality = _prefixId.prefix "BetweennessCentrality"
    /// <summary>
    ///   <para>rdfs:label : Centrality</para>
    ///   <para>rdfs:comment : Centrality refers to the relative importance or influence of a device or entity within the network</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Centrality">tresiot:Centrality</a>
    /// </summary>
    let Centrality = _prefixId.prefix "Centrality"
    /// <summary>
    ///   <para>rdfs:label : Certificate-based Relationship</para>
    ///   <para>rdfs:comment : Certificate-based relationships establish relationships based on the affiliation of the certificate.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/CertificateBasedRelationship">tresiot:CertificateBasedRelationship</a>
    /// </summary>
    let CertificateBasedRelationship = _prefixId.prefix "CertificateBasedRelationship"
    /// <summary>
    ///   <para>rdfs:label : Class Setting Recommendation</para>
    ///   <para>rdfs:comment : The Class Setting Recommendation provides recommendations towards the setting of classes for trust recommendations.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Class_Setting_Recommendation">tresiot:Class_Setting_Recommendation</a>
    /// </summary>
    let Class_Setting_Recommendation = _prefixId.prefix "Class_Setting_Recommendation"
    /// <summary>
    ///   <para>rdfs:label : Closeness Centrality</para>
    ///   <para>rdfs:comment : Closeness centrality calculates how close a node is to all other nodes in the network. Nodes with a high closeness centrality are well-connected to other nodes in the network and can quickly access and share information with them.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/ClosenessCentrality">tresiot:ClosenessCentrality</a>
    /// </summary>
    let ClosenessCentrality = _prefixId.prefix "ClosenessCentrality"
    /// <summary>
    ///   <para>rdfs:label : Co-Location Relationship</para>
    ///   <para>rdfs:comment : Co-Location relationships establish relationships based on the close proximity of two nodes.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/CoLocationObjectRelationship">tresiot:CoLocationObjectRelationship</a>
    /// </summary>
    let CoLocationObjectRelationship = _prefixId.prefix "CoLocationObjectRelationship"
    /// <summary>
    ///   <para>rdfs:label : Co-Work Relationship</para>
    ///   <para>rdfs:comment : Co-Work relationships establish relationships based on frequent cooperation.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/CoWorkRelationship">tresiot:CoWorkRelationship</a>
    /// </summary>
    let CoWorkRelationship = _prefixId.prefix "CoWorkRelationship"
    /// <summary>
    ///   <para>rdfs:label : Community Recommendation</para>
    ///   <para>rdfs:comment : The community recommendation entity recommends multiple trust relations between and trustor and multiple trustee in the network based on the criteria in the given context.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/CommunityRecommendation">tresiot:CommunityRecommendation</a>
    /// </summary>
    let CommunityRecommendation = _prefixId.prefix "CommunityRecommendation"
    /// <summary>
    ///   <para>rdfs:label : Cooperativeness</para>
    ///   <para>rdfs:comment : Cooperativeness refers to the willingness of devices or entities to work together towards a common goal. Therefore, cooperativeness can be determined by the degree of common friends between nodes (Bao, 2011).</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Cooperativeness">tresiot:Cooperativeness</a>
    /// </summary>
    let Cooperativeness = _prefixId.prefix "Cooperativeness"
    /// <summary>
    ///   <para>rdfs:label : Credibility</para>
    ///   <para>rdfs:comment : Credibility refers to the degree to which a device, service requestor, or service provider is reliable and trustworthy.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Credibility">tresiot:Credibility</a>
    /// </summary>
    let Credibility = _prefixId.prefix "Credibility"
    /// <summary>
    ///   <para>rdfs:label : Cumulative Bandwidth Average</para>
    ///   <para>rdfs:comment : The cumulative bandwidth average describes the maximum transfer capacity of a network in a given time interval.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/CumulativeBandwidthAverage">tresiot:CumulativeBandwidthAverage</a>
    /// </summary>
    let CumulativeBandwidthAverage = _prefixId.prefix "CumulativeBandwidthAverage"
    /// <summary>
    ///   <para>rdfs:label : Degree Centrality</para>
    ///   <para>rdfs:comment : Degree centrality measures the number of relationships a node has within a network. Nodes with a high degree of centrality are well-connected within the network.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/DegreeCentrality">tresiot:DegreeCentrality</a>
    /// </summary>
    let DegreeCentrality = _prefixId.prefix "DegreeCentrality"
    /// <summary>
    ///   <para>rdfs:label : Delivery Metric</para>
    ///   <para>rdfs:comment : The delivery metric measures the satisfaction of the package delivery.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/DeliveryMetric">tresiot:DeliveryMetric</a>
    /// </summary>
    let DeliveryMetric = _prefixId.prefix "DeliveryMetric"
    /// <summary>
    ///   <para>rdfs:label : Delivery Ratio</para>
    ///   <para>rdfs:comment : The delivery ratio consider transactions with a certain attribute in contrast to the overall transactions.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/DeliveryRatio">tresiot:DeliveryRatio</a>
    /// </summary>
    let DeliveryRatio = _prefixId.prefix "DeliveryRatio"
    /// <summary>
    ///   <para>rdfs:label : Device</para>
    ///   <para>rdfs:comment : In the SAREF ontology, a tangible object is designed to accomplish a particular task. In order to accomplish this task, the device performs one or more functions. For example, a washing machine is designed to wash (task) and to accomplish this task it performs a start and stop function.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Device">tresiot:Device</a>
    /// </summary>
    let Device = _prefixId.prefix "Device"
    /// <summary>
    ///   <para>rdfs:label : Device Reputation</para>
    ///   <para>rdfs:comment : The device reputation refers to collected ratings of individual devices about the rated device.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/DeviceReputation">tresiot:DeviceReputation</a>
    /// </summary>
    let DeviceReputation = _prefixId.prefix "DeviceReputation"
    /// <summary>
    ///   <para>rdfs:label : Direct Recommendation</para>
    ///   <para>rdfs:comment : Direct Recommendation refers between the subjective node with directly interacted node that recommends its experience with the recommended node. The direct recommendation is a subclass of direct recommendation since a direct recommendation consists of two direct experiences.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/DirectRecommendation">tresiot:DirectRecommendation</a>
    /// </summary>
    let DirectRecommendation = _prefixId.prefix "DirectRecommendation"
    /// <summary>
    ///   <para>rdfs:label : Direct Trust</para>
    ///   <para>rdfs:comment : Direct Trust refers to the experience between the subjective node with directly interacted node.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/DirectTrust">tresiot:DirectTrust</a>
    /// </summary>
    let DirectTrust = _prefixId.prefix "DirectTrust"

    /// <summary>
    ///   <para>rdfs:label : Domain-specific Trust Recommendation</para>
    ///   <para>rdfs:comment : Domain-specific Trust Recommendation provides trust recommendation towards entities in this domain.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Domain-specific_Trust_Recommendation">tresiot:Domain-specific_Trust_Recommendation</a>
    /// </summary>
    let Domain_specific_Trust_Recommendation =
        _prefixId.prefix "Domain-specific_Trust_Recommendation"

    /// <summary>
    ///   <para>rdfs:label : Dropped Package Ratio</para>
    ///   <para>rdfs:comment : The dropped package ratio presents the number of dropped packages in contrast to the overall sent packges.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/DroppedPackageRatio">tresiot:DroppedPackageRatio</a>
    /// </summary>
    let DroppedPackageRatio = _prefixId.prefix "DroppedPackageRatio"
    /// <summary>
    ///   <para>rdfs:label : Experience-based Relationship</para>
    ///   <para>rdfs:comment : Experience-based relationships emerge from the transaction context between the service provider and the service requestor</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/ExperienceBasedRelationship">tresiot:ExperienceBasedRelationship</a>
    /// </summary>
    let ExperienceBasedRelationship = _prefixId.prefix "ExperienceBasedRelationship"
    /// <summary>
    ///   <para>rdfs:label : Function</para>
    ///   <para>rdfs:comment : A function is a node in Social Internet of Things.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Function">tresiot:Function</a>
    /// </summary>
    let Function = _prefixId.prefix "Function"
    /// <summary>
    ///   <para>rdfs:label : Service Reputation</para>
    ///   <para>rdfs:comment : The service reputation refers to collected ratings of individual service about the rated service.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/FunctionReputation">tresiot:FunctionReputation</a>
    /// </summary>
    let FunctionReputation = _prefixId.prefix "FunctionReputation"
    /// <summary>
    ///   <para>rdfs:label : Honesty</para>
    ///   <para>rdfs:comment : Honesty refers to the degree to which a device, service requestor, or service provider is the accuracy of the delivered information. Honesty is determined through direct experiences from previous transactions.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Honesty">tresiot:Honesty</a>
    /// </summary>
    let Honesty = _prefixId.prefix "Honesty"
    /// <summary>
    ///   <para>rdfs:label : Indirect Recommendation</para>
    ///   <para>rdfs:comment : The indirect recommendation is a direct recommendation from a related node to the recommending node to the local transaction context of the node, whereas the |edge_distance| = 3.
    ///
    /// The indirect recommendation consists of one direct trust relationship and one direct recommendation relationships.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/IndirectRecommendation">tresiot:IndirectRecommendation</a>
    /// </summary>
    let IndirectRecommendation = _prefixId.prefix "IndirectRecommendation"
    /// <summary>
    ///   <para>rdfs:label : Interaction Frequency</para>
    ///   <para>rdfs:comment : Theinteraction frequency measures how often nodes have been interacting with each other.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/InteractionFrequency">tresiot:InteractionFrequency</a>
    /// </summary>
    let InteractionFrequency = _prefixId.prefix "InteractionFrequency"
    /// <summary>
    ///   <para>rdfs:label : Interaction Length</para>
    ///   <para>rdfs:comment : The interaction length describes how long two nodes have been interacting with to conclude trustworthiness between nodes.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/InteractionLength">tresiot:InteractionLength</a>
    /// </summary>
    let InteractionLength = _prefixId.prefix "InteractionLength"
    /// <summary>
    ///   <para>rdfs:label : Latency</para>
    ///   <para>rdfs:comment : Latency refers to the measured time delay for a data packet to travel from its source to its destination over a network.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Latency">tresiot:Latency</a>
    /// </summary>
    let Latency = _prefixId.prefix "Latency"
    /// <summary>
    ///   <para>rdfs:label : Network</para>
    ///   <para>rdfs:comment : The network provides information related to the network</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Network">tresiot:Network</a>
    /// </summary>
    let Network = _prefixId.prefix "Network"
    /// <summary>
    ///   <para>rdfs:label : Network Similarity Metric</para>
    ///   <para>rdfs:comment : The network similarity measures local metrics that deviate from graph theory. For example, cooperativeness and centrality can be deviated based on the network metrics</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/NetworkSimilarityMetric">tresiot:NetworkSimilarityMetric</a>
    /// </summary>
    let NetworkSimilarityMetric = _prefixId.prefix "NetworkSimilarityMetric"
    /// <summary>
    ///   <para>rdfs:label : Network Traffic Metric</para>
    ///   <para>rdfs:comment : The network traffic considers interaction-related attributes within the network.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/NetworkTrafficMetric">tresiot:NetworkTrafficMetric</a>
    /// </summary>
    let NetworkTrafficMetric = _prefixId.prefix "NetworkTrafficMetric"
    /// <summary>
    ///   <para>rdfs:label : Node</para>
    ///   <para>rdfs:comment : A node can be perceived at various device levels depending on the granularity.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Node">tresiot:Node</a>
    /// </summary>
    let Node = _prefixId.prefix "Node"
    /// <summary>
    ///   <para>rdfs:label : Node Recommendation</para>
    ///   <para>rdfs:comment : The node recommendation entity recommends a node in the network that is most suitable to conduct at task depending on the evaluation metrics in the given context.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Node_Recommendation">tresiot:Node_Recommendation</a>
    /// </summary>
    let Node_Recommendation = _prefixId.prefix "Node_Recommendation"
    /// <summary>
    ///   <para>rdfs:label : Objective-based Experience</para>
    ///   <para>rdfs:comment : The objective experience evaluation refers to collected ratings of individual nodes about the specific entity.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/ObjectiveExperience">tresiot:ObjectiveExperience</a>
    /// </summary>
    let ObjectiveExperience = _prefixId.prefix "ObjectiveExperience"
    /// <summary>
    ///   <para>rdfs:label : Ownership-Object Relationship</para>
    ///   <para>rdfs:comment : The owner object relationship refers to devices that are owned by the same user</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/OwnershipObjectRelationship">tresiot:OwnershipObjectRelationship</a>
    /// </summary>
    let OwnershipObjectRelationship = _prefixId.prefix "OwnershipObjectRelationship"
    /// <summary>
    ///   <para>rdfs:label : Package Overhead Ratio</para>
    ///   <para>rdfs:comment : The package overhead ratio refers to the ratio of the packet header information to the payload information in a network packet.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/PackageOverheadRatio">tresiot:PackageOverheadRatio</a>
    /// </summary>
    let PackageOverheadRatio = _prefixId.prefix "PackageOverheadRatio"
    /// <summary>
    ///   <para>rdfs:label : Package Tramsmission Rate</para>
    ///   <para>rdfs:comment : The package transmission rate defines the number of transmitted packages in a given time interval.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/PackageTramsmissionRate">tresiot:PackageTramsmissionRate</a>
    /// </summary>
    let PackageTramsmissionRate = _prefixId.prefix "PackageTramsmissionRate"
    /// <summary>
    ///   <para>rdfs:label : Parental Object Relationship</para>
    ///   <para>rdfs:comment : A parental object relationship refers to objects that are manufactured in the same period of time by the same manufacturer.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/ParentalObjectRelationship">tresiot:ParentalObjectRelationship</a>
    /// </summary>
    let ParentalObjectRelationship = _prefixId.prefix "ParentalObjectRelationship"
    /// <summary>
    ///   <para>rdfs:label : Physical Network Metric</para>
    ///   <para>rdfs:comment : The physical network metric summarizes attributes to measure Quality-of-Service attributes to ensure reliablity and availability.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/PhysicalNetworkMetric">tresiot:PhysicalNetworkMetric</a>
    /// </summary>
    let PhysicalNetworkMetric = _prefixId.prefix "PhysicalNetworkMetric"
    /// <summary>
    ///   <para>rdfs:label : Ratio Of Failed Transactions</para>
    ///   <para>rdfs:comment : The delivery ratio consider failed transactions in contrast to the overall transactions.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/RatioOfFailedTransactions">tresiot:RatioOfFailedTransactions</a>
    /// </summary>
    let RatioOfFailedTransactions = _prefixId.prefix "RatioOfFailedTransactions"
    /// <summary>
    ///   <para>rdfs:label : Ratio Of Successful Transactions</para>
    ///   <para>rdfs:comment : The delivery ratio consider successful transactions in contrast to the overall transactions.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/RatioOfSuccessfulTransactions">tresiot:RatioOfSuccessfulTransactions</a>
    /// </summary>
    let RatioOfSuccessfulTransactions = _prefixId.prefix "RatioOfSuccessfulTransactions"
    /// <summary>
    ///   <para>rdfs:label : Relationship</para>
    ///   <para>rdfs:comment : The relationship concept defines the type of relationships that can exisit between nodes.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Relationship">tresiot:Relationship</a>
    /// </summary>
    let Relationship = _prefixId.prefix "Relationship"

    /// <summary>
    ///   <para>rdfs:label : Relationship Existance Recommendation</para>
    ///   <para>rdfs:comment : The Relationship Existance Recommendation entity provides a recommendation if a social link between two nodes exists.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Relationship_Existance_Recommendation">tresiot:Relationship_Existance_Recommendation</a>
    /// </summary>
    let Relationship_Existance_Recommendation =
        _prefixId.prefix "Relationship_Existance_Recommendation"

    /// <summary>
    ///   <para>rdfs:label : Relationship Labeling Recommendation</para>
    ///   <para>rdfs:comment : The Relationship Existance Recommendation entity provides a recommendation about the label of the link between two nodes exists. The label of a relationship can be a set of attributes, a specific name of the relationship, or a specific value.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Relationship_Labeling_Recommendation">tresiot:Relationship_Labeling_Recommendation</a>
    /// </summary>
    let Relationship_Labeling_Recommendation =
        _prefixId.prefix "Relationship_Labeling_Recommendation"

    /// <summary>
    ///   <para>rdfs:label : Representation of Trust</para>
    ///   <para>rdfs:comment : The representation of trust defines the concept of different trust representation. For example, trust can be represented using qualitative expressions, such as "Trusted" and "Untrusted", or binary expressions, such TRUE and FALSE</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/RepresentationOfTrust">tresiot:RepresentationOfTrust</a>
    /// </summary>
    let RepresentationOfTrust = _prefixId.prefix "RepresentationOfTrust"
    /// <summary>
    ///   <para>rdfs:label : Response Time</para>
    ///   <para>rdfs:comment : Response time refers to the time of a device to respond to a network request.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/ResponseTime">tresiot:ResponseTime</a>
    /// </summary>
    let ResponseTime = _prefixId.prefix "ResponseTime"
    /// <summary>
    ///   <para>rdfs:label : Retransmission Rate</para>
    ///   <para>rdfs:comment : The retransmission rate referes to the number of retransmitted packets to the total number of packets transmitted.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/RetransmissionRate">tresiot:RetransmissionRate</a>
    /// </summary>
    let RetransmissionRate = _prefixId.prefix "RetransmissionRate"
    /// <summary>
    ///   <para>rdfs:label : Service</para>
    ///   <para>rdfs:comment : A service is a node in Social Internet of Things.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Service">tresiot:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    /// <summary>
    ///   <para>rdfs:label : Trusteerdfs:label : The trustee is an agent that is perceived as trusted from the trustor to deliver a requested task in a given context in the expected manner.^^xsd:string</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/ServiceProvider">tresiot:ServiceProvider</a>
    /// </summary>
    let ServiceProvider = _prefixId.prefix "ServiceProvider"
    /// <summary>
    ///   <para>rdfs:label : Function Reputation</para>
    ///   <para>rdfs:comment : The function reputation refers to collected ratings of individual function about the rated function.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/ServiceReputation">tresiot:ServiceReputation</a>
    /// </summary>
    let ServiceReputation = _prefixId.prefix "ServiceReputation"
    /// <summary>
    ///   <para>rdfs:label : Trustor</para>
    ///   <para>rdfs:comment : The trustor is an agent that initiates the interaction to a perceived trustworthy agent, the trustee, to request a task in a given context to achieve its objective.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/ServiceRequestor">tresiot:ServiceRequestor</a>
    /// </summary>
    let ServiceRequestor = _prefixId.prefix "ServiceRequestor"

    /// <summary>
    ///   <para>rdfs:label : Situation-dependent Trust Recommendation</para>
    ///   <para>rdfs:comment : The Situation-dependent Trust Recommendation entity captures concepts related to imrprove the trust recommendation based on the existing situation.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Situation-Dependent_Trust_Settings_Recommendation">tresiot:Situation-Dependent_Trust_Settings_Recommendation</a>
    /// </summary>
    let Situation_Dependent_Trust_Settings_Recommendation =
        _prefixId.prefix "Situation-Dependent_Trust_Settings_Recommendation"

    /// <summary>
    ///   <para>rdfs:label : Social Network Metric</para>
    ///   <para>rdfs:comment : The social network metric provides information related to entities of the socialized network.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/SocialNetworkMetric">tresiot:SocialNetworkMetric</a>
    /// </summary>
    let SocialNetworkMetric = _prefixId.prefix "SocialNetworkMetric"
    /// <summary>
    ///   <para>rdfs:label : Social Object Relationship</para>
    ///   <para>rdfs:comment : Social Object Relationship defines occasionally encounters  of devices due to the relation between owners</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/SocialObjectRelationship">tresiot:SocialObjectRelationship</a>
    /// </summary>
    let SocialObjectRelationship = _prefixId.prefix "SocialObjectRelationship"
    /// <summary>
    ///   <para>rdfs:label : Social Trust Metric</para>
    ///   <para>rdfs:comment : The social trust metrics measure trust between two nodes based on their social properties.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/SocialTrustMetric">tresiot:SocialTrustMetric</a>
    /// </summary>
    let SocialTrustMetric = _prefixId.prefix "SocialTrustMetric"
    /// <summary>
    ///   <para>rdfs:label : Subjective-based Experience</para>
    ///   <para>rdfs:comment : The subjective-based experience category includes only the local transaction context of one node with other nodes.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/SubjectiveExperience">tresiot:SubjectiveExperience</a>
    /// </summary>
    let SubjectiveExperience = _prefixId.prefix "SubjectiveExperience"
    /// <summary>
    ///   <para>rdfs:label : Technical Trust Recommendation</para>
    ///   <para>rdfs:comment : Technical Trust Recommendation addresses technical issues of the trust computation, decision-making, and review to produce accurate trust recommendations.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/TechnicalTrustRecommendation">tresiot:TechnicalTrustRecommendation</a>
    /// </summary>
    let TechnicalTrustRecommendation = _prefixId.prefix "TechnicalTrustRecommendation"
    /// <summary>
    ///   <para>rdfs:label : Throughput</para>
    ///   <para>rdfs:comment : Throughput represents the amount of data that is successfully transmitted in a network in a given period of time to measure the efficiency of a network.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Throughput">tresiot:Throughput</a>
    /// </summary>
    let Throughput = _prefixId.prefix "Throughput"
    /// <summary>
    ///   <para>rdfs:label : Tie Strength Metric</para>
    ///   <para>rdfs:comment : Tie strength formed by interaction-related attribtues from previous transactions</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/TieStengthMetric">tresiot:TieStengthMetric</a>
    /// </summary>
    let TieStengthMetric = _prefixId.prefix "TieStengthMetric"
    /// <summary>
    ///   <para>rdfs:label : Time-dependent Metric</para>
    ///   <para>rdfs:comment : Time-dependent metric refers to the behavior of network traffic based on the time property.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/TimeRelatedMetric">tresiot:TimeRelatedMetric</a>
    /// </summary>
    let TimeRelatedMetric = _prefixId.prefix "TimeRelatedMetric"
    /// <summary>
    ///   <para>rdfs:label : Transaction Context</para>
    ///   <para>rdfs:comment : The transaction context involves all attributes to model the perceived trust based in a given context.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/TransactionContext">tresiot:TransactionContext</a>
    /// </summary>
    let TransactionContext = _prefixId.prefix "TransactionContext"
    /// <summary>
    ///   <para>rdfs:label : Trust Recommendation</para>
    ///   <para>rdfs:comment : The trust recommendation entity provides a recommendation towards entities in the network</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/TrustRecommendation">tresiot:TrustRecommendation</a>
    /// </summary>
    let TrustRecommendation = _prefixId.prefix "TrustRecommendation"
    /// <summary>
    ///   <para>rdfs:label : Trust Relation Recommendation</para>
    ///   <para>rdfs:comment : The trust relation recommendation entity recommends a trust relation between the trustor and the trustee in the given context.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/TrustRelationRecommendation">tresiot:TrustRelationRecommendation</a>
    /// </summary>
    let TrustRelationRecommendation = _prefixId.prefix "TrustRelationRecommendation"

    /// <summary>
    ///   <para>rdfs:label : Trust Decision Setting Recommendation</para>
    ///   <para>rdfs:comment : Trust Decision Setting Recommendation concerns about the recommendation of settings for trust decision-making.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Trust_Decision_Setting_Recommendation">tresiot:Trust_Decision_Setting_Recommendation</a>
    /// </summary>
    let Trust_Decision_Setting_Recommendation =
        _prefixId.prefix "Trust_Decision_Setting_Recommendation"

    /// <summary>
    ///   <para>rdfs:label : Trust Feature Recommendation</para>
    ///   <para>rdfs:comment : The Trust Feature Recommendation entity provides a recommendation of trust features to produce trust recommendations based on the exisiting situation.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Trust_Feature_Recommendation">tresiot:Trust_Feature_Recommendation</a>
    /// </summary>
    let Trust_Feature_Recommendation = _prefixId.prefix "Trust_Feature_Recommendation"

    /// <summary>
    ///   <para>rdfs:label : Trust Metric Evaluation Recommendation</para>
    ///   <para>rdfs:comment : The Trust Metric Evaluation Recommendation entity provides a recommendation of trust evaluation metrics to review the produced trust recommendation in the exisiting situation.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Trust_Metric_Evaluation_Recommendation">tresiot:Trust_Metric_Evaluation_Recommendation</a>
    /// </summary>
    let Trust_Metric_Evaluation_Recommendation =
        _prefixId.prefix "Trust_Metric_Evaluation_Recommendation"

    /// <summary>
    ///   <para>rdfs:label : Trust Threshold Recommendation</para>
    ///   <para>rdfs:comment : The Trust Threshold Recommendation provides a recommendation for a threshold in a trust decision-marking process.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Trust_Threshold_Recommendation">tresiot:Trust_Threshold_Recommendation</a>
    /// </summary>
    let Trust_Threshold_Recommendation =
        _prefixId.prefix "Trust_Threshold_Recommendation"

    /// <summary>
    ///   <para>rdfs:label : Trust Weight Adaption Recommendation</para>
    ///   <para>rdfs:comment : The Trust Weight Adaption Recommendation entity provides recommendations to the appropriate weight for a feature in the current situation.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Trust_Weight_Adaption_Recommendation">tresiot:Trust_Weight_Adaption_Recommendation</a>
    /// </summary>
    let Trust_Weight_Adaption_Recommendation =
        _prefixId.prefix "Trust_Weight_Adaption_Recommendation"

    /// <summary>
    ///   <para>rdfs:label : acts as</para>
    ///   <para>rdfs:comment : A node acts as trustor or as trustee.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/actsAs">tresiot:actsAs</a>
    /// </summary>
    let actsAs = _prefixId.prefix "actsAs"
    /// <summary>
    ///   <para>rdfs:label : is component of</para>
    ///   <para>rdfs:comment : A node is a component of the network.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/communicatesIn">tresiot:communicatesIn</a>
    /// </summary>
    let communicatesIn = _prefixId.prefix "communicatesIn"
    /// <summary>
    ///   <para>rdfs:label : establishes</para>
    ///   <para>rdfs:comment : A trustor establishes the transaction context.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/establishes">tresiot:establishes</a>
    /// </summary>
    let establishes = _prefixId.prefix "establishes"
    /// <summary>
    ///   <para>rdfs:label : forms</para>
    ///   <para>rdfs:comment : A relationship forms the network.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/forms">tresiot:forms</a>
    /// </summary>
    let forms = _prefixId.prefix "forms"
    /// <summary>
    ///   <para>rdfs:label : has request function</para>
    ///   <para>rdfs:comment : The transaction context has a requrest function</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/hasRequestFunction">tresiot:hasRequestFunction</a>
    /// </summary>
    let hasRequestFunction = _prefixId.prefix "hasRequestFunction"
    /// <summary>
    ///   <para>rdfs:label : has timestamp</para>
    ///   <para>rdfs:comment : A transaction context has a timestamp</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/hasTimestamp">tresiot:hasTimestamp</a>
    /// </summary>
    let hasTimestamp = _prefixId.prefix "hasTimestamp"
    /// <summary>
    ///   <para>rdfs:label : has trust value</para>
    ///   <para>rdfs:comment : A transaction context has a trust value</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/hasTrustValue">tresiot:hasTrustValue</a>
    /// </summary>
    let hasTrustValue = _prefixId.prefix "hasTrustValue"
    /// <summary>
    ///   <para>rdfs:label : is acted by</para>
    ///   <para>rdfs:comment : An trustor or and trustee are acted by a device.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/isActedBy">tresiot:isActedBy</a>
    /// </summary>
    let isActedBy = _prefixId.prefix "isActedBy"
    /// <summary>
    ///   <para>rdfs:label : has component</para>
    ///   <para>rdfs:comment : A network has a device as component</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/isCommunicatedIn">tresiot:isCommunicatedIn</a>
    /// </summary>
    let isCommunicatedIn = _prefixId.prefix "isCommunicatedIn"
    /// <summary>
    ///   <para>rdfs:label : is established by</para>
    ///   <para>rdfs:comment : The transaction context is established by the trustor.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/isEstablishedBy">tresiot:isEstablishedBy</a>
    /// </summary>
    let isEstablishedBy = _prefixId.prefix "isEstablishedBy"
    /// <summary>
    ///   <para>rdfs:label : is formed by</para>
    ///   <para>rdfs:comment : The network is formed by relationships.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/isFormedBy">tresiot:isFormedBy</a>
    /// </summary>
    let isFormedBy = _prefixId.prefix "isFormedBy"
    /// <summary>
    ///   <para>rdfs:label : is linked by</para>
    ///   <para>rdfs:comment : Devices are linked by relationships.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/isLinkedBy">tresiot:isLinkedBy</a>
    /// </summary>
    let isLinkedBy = _prefixId.prefix "isLinkedBy"
    /// <summary>
    ///   <para>rdfs:label : is recommended by</para>
    ///   <para>rdfs:comment : Trustor, Trustee, Network, and Relationship classes are recommended by Trust Recommendation.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/isRecommendedBy">tresiot:isRecommendedBy</a>
    /// </summary>
    let isRecommendedBy = _prefixId.prefix "isRecommendedBy"
    /// <summary>
    ///   <para>rdfs:label : is requested by</para>
    ///   <para>rdfs:comment : A trust recommendation is requested by a trustee or a trustor</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/isRequestedBy">tresiot:isRequestedBy</a>
    /// </summary>
    let isRequestedBy = _prefixId.prefix "isRequestedBy"
    /// <summary>
    ///   <para>rdfs:label : is required by</para>
    ///   <para>rdfs:comment : The transaction context is required by the trustor and the trustee.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/isRequiredBy">tresiot:isRequiredBy</a>
    /// </summary>
    let isRequiredBy = _prefixId.prefix "isRequiredBy"
    /// <summary>
    ///   <para>rdfs:label : links</para>
    ///   <para>rdfs:comment : A relationship links devices.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/links">tresiot:links</a>
    /// </summary>
    let links = _prefixId.prefix "links"
    /// <summary>
    ///   <para>rdfs:label : recommends</para>
    ///   <para>rdfs:comment : A Trust Recommendation recommends Networks, Relationships, Trustor, and Trustee.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/recommends">tresiot:recommends</a>
    /// </summary>
    let recommends = _prefixId.prefix "recommends"
    /// <summary>
    ///   <para>rdfs:label : represents Trust Value</para>
    ///   <para>rdfs:comment : The transaction context has a representsation of the trust value.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/representsTrustValueIn">tresiot:representsTrustValueIn</a>
    /// </summary>
    let representsTrustValueIn = _prefixId.prefix "representsTrustValueIn"
    /// <summary>
    ///   <para>rdfs:label : requests</para>
    ///   <para>rdfs:comment : The trustee and the trustor request trust recommendations.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/requests">tresiot:requests</a>
    /// </summary>
    let requests = _prefixId.prefix "requests"
    /// <summary>
    ///   <para>rdfs:label : requires</para>
    ///   <para>rdfs:comment : The transaction context requires a trustor and a trustee.</para>
    ///   <a href="https://liidr.org/trust-recommendation-in-social-internet-of-things/requires">tresiot:requires</a>
    /// </summary>
    let requires = _prefixId.prefix "requires"
