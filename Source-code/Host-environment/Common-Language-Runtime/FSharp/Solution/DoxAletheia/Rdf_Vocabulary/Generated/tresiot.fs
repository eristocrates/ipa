namespace https.liidr.org.trust_recommendation_in_social_internet_of_things.slash

open DoxAletheia

module tresiot =
    let _namespace_name =
        "https://liidr.org/trust-recommendation-in-social-internet-of-things/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/1.0.0"></see>
    /// </summary>
    let ``_1.0.0`` = _prefix "1.0.0"
    /// <summary>
    /// Attribute-based relationships form the relationship based on node features between two nodes based on certain attributes.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/AttributeBasedRelationship"></see></summary>
    let AttributeBasedRelationship = _prefix "AttributeBasedRelationship"
    /// <summary>
    /// The relationship concept defines the type of relationships that can exisit between nodes.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Relationship"></see></summary>
    let Relationship = _prefix "Relationship"
    /// <summary>
    /// Betweenness centrality describes how often a node acts as an intermediate node between other nodes in the network. Nodes with a high betweenness centrality have a central role in the network to enable trust recommendation between other nodes.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/BetweennessCentrality"></see></summary>
    let BetweennessCentrality = _prefix "BetweennessCentrality"
    /// <summary>
    /// Centrality refers to the relative importance or influence of a device or entity within the network
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Centrality"></see></summary>
    let Centrality = _prefix "Centrality"
    /// <summary>
    /// The network similarity measures local metrics that deviate from graph theory. For example, cooperativeness and centrality can be deviated based on the network metrics
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/NetworkSimilarityMetric"></see></summary>
    let NetworkSimilarityMetric = _prefix "NetworkSimilarityMetric"
    /// <summary>
    /// Certificate-based relationships establish relationships based on the affiliation of the certificate.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/CertificateBasedRelationship"></see></summary>
    let CertificateBasedRelationship = _prefix "CertificateBasedRelationship"
    /// <summary>
    /// The Class Setting Recommendation provides recommendations towards the setting of classes for trust recommendations.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Class_Setting_Recommendation"></see></summary>
    let Class_Setting_Recommendation = _prefix "Class_Setting_Recommendation"

    /// <summary>
    /// Trust Decision Setting Recommendation concerns about the recommendation of settings for trust decision-making.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Trust_Decision_Setting_Recommendation"></see></summary>
    let Trust_Decision_Setting_Recommendation =
        _prefix "Trust_Decision_Setting_Recommendation"

    /// <summary>
    /// Closeness centrality calculates how close a node is to all other nodes in the network. Nodes with a high closeness centrality are well-connected to other nodes in the network and can quickly access and share information with them.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/ClosenessCentrality"></see></summary>
    let ClosenessCentrality = _prefix "ClosenessCentrality"
    /// <summary>
    /// Co-Location relationships establish relationships based on the close proximity of two nodes.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/CoLocationObjectRelationship"></see></summary>
    let CoLocationObjectRelationship = _prefix "CoLocationObjectRelationship"
    /// <summary>
    /// Co-Work relationships establish relationships based on frequent cooperation.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/CoWorkRelationship"></see></summary>
    let CoWorkRelationship = _prefix "CoWorkRelationship"
    /// <summary>
    /// The community recommendation entity recommends multiple trust relations between and trustor and multiple trustee in the network based on the criteria in the given context.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/CommunityRecommendation"></see></summary>
    let CommunityRecommendation = _prefix "CommunityRecommendation"

    /// <summary>
    /// Domain-specific Trust Recommendation provides trust recommendation towards entities in this domain.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Domain-specific_Trust_Recommendation"></see></summary>
    let ``Domain-specific_Trust_Recommendation`` =
        _prefix "Domain-specific_Trust_Recommendation"

    /// <summary>
    /// Cooperativeness refers to the willingness of devices or entities to work together towards a common goal. Therefore, cooperativeness can be determined by the degree of common friends between nodes (Bao, 2011).
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Cooperativeness"></see></summary>
    let Cooperativeness = _prefix "Cooperativeness"
    /// <summary>
    /// Credibility refers to the degree to which a device, service requestor, or service provider is reliable and trustworthy.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Credibility"></see></summary>
    let Credibility = _prefix "Credibility"
    /// <summary>
    /// The social trust metrics measure trust between two nodes based on their social properties.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/SocialTrustMetric"></see></summary>
    let SocialTrustMetric = _prefix "SocialTrustMetric"
    /// <summary>
    /// The cumulative bandwidth average describes the maximum transfer capacity of a network in a given time interval.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/CumulativeBandwidthAverage"></see></summary>
    let CumulativeBandwidthAverage = _prefix "CumulativeBandwidthAverage"
    /// <summary>
    /// The network traffic considers interaction-related attributes within the network.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/NetworkTrafficMetric"></see></summary>
    let NetworkTrafficMetric = _prefix "NetworkTrafficMetric"
    /// <summary>
    /// Degree centrality measures the number of relationships a node has within a network. Nodes with a high degree of centrality are well-connected within the network.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/DegreeCentrality"></see></summary>
    let DegreeCentrality = _prefix "DegreeCentrality"
    /// <summary>
    /// The delivery metric measures the satisfaction of the package delivery.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/DeliveryMetric"></see></summary>
    let DeliveryMetric = _prefix "DeliveryMetric"
    /// <summary>
    /// The physical network metric summarizes attributes to measure Quality-of-Service attributes to ensure reliablity and availability.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/PhysicalNetworkMetric"></see></summary>
    let PhysicalNetworkMetric = _prefix "PhysicalNetworkMetric"
    /// <summary>
    /// The delivery ratio consider transactions with a certain attribute in contrast to the overall transactions.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/DeliveryRatio"></see></summary>
    let DeliveryRatio = _prefix "DeliveryRatio"
    /// <summary>
    /// In the SAREF ontology, a tangible object is designed to accomplish a particular task. In order to accomplish this task, the device performs one or more functions. For example, a washing machine is designed to wash (task) and to accomplish this task it performs a start and stop function.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Device"></see></summary>
    let Device = _prefix "Device"
    /// <summary>
    /// A node can be perceived at various device levels depending on the granularity.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Node"></see></summary>
    let Node = _prefix "Node"
    /// <summary>
    /// The device reputation refers to collected ratings of individual devices about the rated device.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/DeviceReputation"></see></summary>
    let DeviceReputation = _prefix "DeviceReputation"
    /// <summary>
    /// The objective experience evaluation refers to collected ratings of individual nodes about the specific entity.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/ObjectiveExperience"></see></summary>
    let ObjectiveExperience = _prefix "ObjectiveExperience"
    /// <summary>
    /// Direct Recommendation refers between the subjective node with directly interacted node that recommends its experience with the recommended node. The direct recommendation is a subclass of direct recommendation since a direct recommendation consists of two direct experiences.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/DirectRecommendation"></see></summary>
    let DirectRecommendation = _prefix "DirectRecommendation"
    /// <summary>
    /// The subjective-based experience category includes only the local transaction context of one node with other nodes.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/SubjectiveExperience"></see></summary>
    let SubjectiveExperience = _prefix "SubjectiveExperience"
    /// <summary>
    /// Direct Trust refers to the experience between the subjective node with directly interacted node.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/DirectTrust"></see></summary>
    let DirectTrust = _prefix "DirectTrust"
    /// <summary>
    /// The trust recommendation entity provides a recommendation towards entities in the network
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/TrustRecommendation"></see></summary>
    let TrustRecommendation = _prefix "TrustRecommendation"
    /// <summary>
    /// The dropped package ratio presents the number of dropped packages in contrast to the overall sent packges.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/DroppedPackageRatio"></see></summary>
    let DroppedPackageRatio = _prefix "DroppedPackageRatio"
    /// <summary>
    /// Experience-based relationships emerge from the transaction context between the service provider and the service requestor
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/ExperienceBasedRelationship"></see></summary>
    let ExperienceBasedRelationship = _prefix "ExperienceBasedRelationship"
    /// <summary>
    /// A function is a node in Social Internet of Things.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Function"></see></summary>
    let Function = _prefix "Function"
    /// <summary>
    /// The service reputation refers to collected ratings of individual service about the rated service.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/FunctionReputation"></see></summary>
    let FunctionReputation = _prefix "FunctionReputation"
    /// <summary>
    /// Honesty refers to the degree to which a device, service requestor, or service provider is the accuracy of the delivered information. Honesty is determined through direct experiences from previous transactions.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Honesty"></see></summary>
    let Honesty = _prefix "Honesty"
    /// <summary>
    /// The indirect recommendation is a direct recommendation from a related node to the recommending node to the local transaction context of the node, whereas the |edge_distance| = 3.
    ///
    /// The indirect recommendation consists of one direct trust relationship and one direct recommendation relationships.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/IndirectRecommendation"></see></summary>
    let IndirectRecommendation = _prefix "IndirectRecommendation"
    /// <summary>
    /// Theinteraction frequency measures how often nodes have been interacting with each other.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/InteractionFrequency"></see></summary>
    let InteractionFrequency = _prefix "InteractionFrequency"
    /// <summary>
    /// Tie strength formed by interaction-related attribtues from previous transactions
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/TieStengthMetric"></see></summary>
    let TieStengthMetric = _prefix "TieStengthMetric"
    /// <summary>
    /// The interaction length describes how long two nodes have been interacting with to conclude trustworthiness between nodes.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/InteractionLength"></see></summary>
    let InteractionLength = _prefix "InteractionLength"
    /// <summary>
    /// Latency refers to the measured time delay for a data packet to travel from its source to its destination over a network.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Latency"></see></summary>
    let Latency = _prefix "Latency"
    /// <summary>
    /// Time-dependent metric refers to the behavior of network traffic based on the time property.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/TimeRelatedMetric"></see></summary>
    let TimeRelatedMetric = _prefix "TimeRelatedMetric"
    /// <summary>
    /// The network provides information related to the network
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Network"></see></summary>
    let Network = _prefix "Network"
    /// <summary>
    /// The social network metric provides information related to entities of the socialized network.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/SocialNetworkMetric"></see></summary>
    let SocialNetworkMetric = _prefix "SocialNetworkMetric"
    /// <summary>
    /// The node recommendation entity recommends a node in the network that is most suitable to conduct at task depending on the evaluation metrics in the given context.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Node_Recommendation"></see></summary>
    let Node_Recommendation = _prefix "Node_Recommendation"
    /// <summary>
    /// The owner object relationship refers to devices that are owned by the same user
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/OwnershipObjectRelationship"></see></summary>
    let OwnershipObjectRelationship = _prefix "OwnershipObjectRelationship"
    /// <summary>
    /// The package overhead ratio refers to the ratio of the packet header information to the payload information in a network packet.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/PackageOverheadRatio"></see></summary>
    let PackageOverheadRatio = _prefix "PackageOverheadRatio"
    /// <summary>
    /// The package transmission rate defines the number of transmitted packages in a given time interval.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/PackageTramsmissionRate"></see></summary>
    let PackageTramsmissionRate = _prefix "PackageTramsmissionRate"
    /// <summary>
    /// A parental object relationship refers to objects that are manufactured in the same period of time by the same manufacturer.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/ParentalObjectRelationship"></see></summary>
    let ParentalObjectRelationship = _prefix "ParentalObjectRelationship"
    /// <summary>
    /// The delivery ratio consider failed transactions in contrast to the overall transactions.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/RatioOfFailedTransactions"></see></summary>
    let RatioOfFailedTransactions = _prefix "RatioOfFailedTransactions"
    /// <summary>
    /// The delivery ratio consider successful transactions in contrast to the overall transactions.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/RatioOfSuccessfulTransactions"></see></summary>
    let RatioOfSuccessfulTransactions = _prefix "RatioOfSuccessfulTransactions"

    /// <summary>
    /// The Relationship Existance Recommendation entity provides a recommendation if a social link between two nodes exists.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Relationship_Existance_Recommendation"></see></summary>
    let Relationship_Existance_Recommendation =
        _prefix "Relationship_Existance_Recommendation"

    /// <summary>
    /// The trust relation recommendation entity recommends a trust relation between the trustor and the trustee in the given context.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/TrustRelationRecommendation"></see></summary>
    let TrustRelationRecommendation = _prefix "TrustRelationRecommendation"

    /// <summary>
    /// The Relationship Existance Recommendation entity provides a recommendation about the label of the link between two nodes exists. The label of a relationship can be a set of attributes, a specific name of the relationship, or a specific value.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Relationship_Labeling_Recommendation"></see></summary>
    let Relationship_Labeling_Recommendation =
        _prefix "Relationship_Labeling_Recommendation"

    /// <summary>
    /// The representation of trust defines the concept of different trust representation. For example, trust can be represented using qualitative expressions, such as "Trusted" and "Untrusted", or binary expressions, such TRUE and FALSE
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/RepresentationOfTrust"></see></summary>
    let RepresentationOfTrust = _prefix "RepresentationOfTrust"
    /// <summary>
    /// Response time refers to the time of a device to respond to a network request.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/ResponseTime"></see></summary>
    let ResponseTime = _prefix "ResponseTime"
    /// <summary>
    /// The retransmission rate referes to the number of retransmitted packets to the total number of packets transmitted.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/RetransmissionRate"></see></summary>
    let RetransmissionRate = _prefix "RetransmissionRate"
    /// <summary>
    /// A service is a node in Social Internet of Things.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Service"></see></summary>
    let Service = _prefix "Service"
    /// <summary>
    ///   <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/ServiceProvider"></see>
    /// </summary>
    let ServiceProvider = _prefix "ServiceProvider"
    /// <summary>
    /// The function reputation refers to collected ratings of individual function about the rated function.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/ServiceReputation"></see></summary>
    let ServiceReputation = _prefix "ServiceReputation"
    /// <summary>
    /// The trustor is an agent that initiates the interaction to a perceived trustworthy agent, the trustee, to request a task in a given context to achieve its objective.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/ServiceRequestor"></see></summary>
    let ServiceRequestor = _prefix "ServiceRequestor"

    /// <summary>
    /// The Situation-dependent Trust Recommendation entity captures concepts related to imrprove the trust recommendation based on the existing situation.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Situation-Dependent_Trust_Settings_Recommendation"></see></summary>
    let ``Situation-Dependent_Trust_Settings_Recommendation`` =
        _prefix "Situation-Dependent_Trust_Settings_Recommendation"

    /// <summary>
    /// Technical Trust Recommendation addresses technical issues of the trust computation, decision-making, and review to produce accurate trust recommendations.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/TechnicalTrustRecommendation"></see></summary>
    let TechnicalTrustRecommendation = _prefix "TechnicalTrustRecommendation"
    /// <summary>
    /// Social Object Relationship defines occasionally encounters  of devices due to the relation between owners
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/SocialObjectRelationship"></see></summary>
    let SocialObjectRelationship = _prefix "SocialObjectRelationship"
    /// <summary>
    /// Throughput represents the amount of data that is successfully transmitted in a network in a given period of time to measure the efficiency of a network.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Throughput"></see></summary>
    let Throughput = _prefix "Throughput"
    /// <summary>
    /// The transaction context involves all attributes to model the perceived trust based in a given context.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/TransactionContext"></see></summary>
    let TransactionContext = _prefix "TransactionContext"
    /// <summary>
    /// The Trust Feature Recommendation entity provides a recommendation of trust features to produce trust recommendations based on the exisiting situation.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Trust_Feature_Recommendation"></see></summary>
    let Trust_Feature_Recommendation = _prefix "Trust_Feature_Recommendation"

    /// <summary>
    /// The Trust Metric Evaluation Recommendation entity provides a recommendation of trust evaluation metrics to review the produced trust recommendation in the exisiting situation.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Trust_Metric_Evaluation_Recommendation"></see></summary>
    let Trust_Metric_Evaluation_Recommendation =
        _prefix "Trust_Metric_Evaluation_Recommendation"

    /// <summary>
    /// The Trust Threshold Recommendation provides a recommendation for a threshold in a trust decision-marking process.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Trust_Threshold_Recommendation"></see></summary>
    let Trust_Threshold_Recommendation = _prefix "Trust_Threshold_Recommendation"

    /// <summary>
    /// The Trust Weight Adaption Recommendation entity provides recommendations to the appropriate weight for a feature in the current situation.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Trust_Weight_Adaption_Recommendation"></see></summary>
    let Trust_Weight_Adaption_Recommendation =
        _prefix "Trust_Weight_Adaption_Recommendation"

    /// <summary>
    /// A node acts as trustor or as trustee.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/actsAs"></see></summary>
    let actsAs = _prefix "actsAs"
    /// <summary>
    /// An trustor or and trustee are acted by a device.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/isActedBy"></see></summary>
    let isActedBy = _prefix "isActedBy"
    /// <summary>
    /// A node is a component of the network.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/communicatesIn"></see></summary>
    let communicatesIn = _prefix "communicatesIn"
    /// <summary>
    /// A network has a device as component
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/isCommunicatedIn"></see></summary>
    let isCommunicatedIn = _prefix "isCommunicatedIn"
    /// <summary>
    /// A trustor establishes the transaction context.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/establishes"></see></summary>
    let establishes = _prefix "establishes"
    /// <summary>
    /// The transaction context is established by the trustor.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/isEstablishedBy"></see></summary>
    let isEstablishedBy = _prefix "isEstablishedBy"
    /// <summary>
    /// A relationship forms the network.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/forms"></see></summary>
    let forms = _prefix "forms"
    /// <summary>
    /// The network is formed by relationships.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/isFormedBy"></see></summary>
    let isFormedBy = _prefix "isFormedBy"
    /// <summary>
    /// The transaction context has a requrest function
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/hasRequestFunction"></see></summary>
    let hasRequestFunction = _prefix "hasRequestFunction"
    /// <summary>
    /// A transaction context has a timestamp
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/hasTimestamp"></see></summary>
    let hasTimestamp = _prefix "hasTimestamp"
    /// <summary>
    /// A transaction context has a trust value
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/hasTrustValue"></see></summary>
    let hasTrustValue = _prefix "hasTrustValue"
    /// <summary>
    /// Devices are linked by relationships.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/isLinkedBy"></see></summary>
    let isLinkedBy = _prefix "isLinkedBy"
    /// <summary>
    /// A relationship links devices.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/links"></see></summary>
    let links = _prefix "links"
    /// <summary>
    /// Trustor, Trustee, Network, and Relationship classes are recommended by Trust Recommendation.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/isRecommendedBy"></see></summary>
    let isRecommendedBy = _prefix "isRecommendedBy"
    /// <summary>
    /// A Trust Recommendation recommends Networks, Relationships, Trustor, and Trustee.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/recommends"></see></summary>
    let recommends = _prefix "recommends"
    /// <summary>
    /// A trust recommendation is requested by a trustee or a trustor
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/isRequestedBy"></see></summary>
    let isRequestedBy = _prefix "isRequestedBy"
    /// <summary>
    /// The trustee and the trustor request trust recommendations.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/requests"></see></summary>
    let requests = _prefix "requests"
    /// <summary>
    /// The transaction context is required by the trustor and the trustee.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/isRequiredBy"></see></summary>
    let isRequiredBy = _prefix "isRequiredBy"
    /// <summary>
    /// The transaction context requires a trustor and a trustee.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/requires"></see></summary>
    let requires = _prefix "requires"
    /// <summary>
    /// The transaction context has a representsation of the trust value.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/representsTrustValueIn"></see></summary>
    let representsTrustValueIn = _prefix "representsTrustValueIn"
