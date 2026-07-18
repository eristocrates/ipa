namespace https.liidr.org.trust_recommendation_in_social_internet_of_things.slash

open DoxAletheia.Rdf_Vocabulary

module tresiot =
    let _namespace_name =
        "https://liidr.org/trust-recommendation-in-social-internet-of-things/"

    /// <summary>
    ///   <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/1.0.0"></see>
    /// </summary>
    let ``_1.0.0`` = Namespaced_IRI.parse _namespace_name "1.0.0" |> NamespacedName

    /// <summary>
    /// Attribute-based relationships form the relationship based on node features between two nodes based on certain attributes.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/AttributeBasedRelationship"></see></summary>
    let AttributeBasedRelationship =
        Namespaced_IRI.parse _namespace_name "AttributeBasedRelationship" |> NamespacedName

    /// <summary>
    /// The relationship concept defines the type of relationships that can exisit between nodes.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Relationship"></see></summary>
    let Relationship =
        Namespaced_IRI.parse _namespace_name "Relationship" |> NamespacedName

    /// <summary>
    /// Betweenness centrality describes how often a node acts as an intermediate node between other nodes in the network. Nodes with a high betweenness centrality have a central role in the network to enable trust recommendation between other nodes.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/BetweennessCentrality"></see></summary>
    let BetweennessCentrality =
        Namespaced_IRI.parse _namespace_name "BetweennessCentrality" |> NamespacedName

    /// <summary>
    /// Centrality refers to the relative importance or influence of a device or entity within the network
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Centrality"></see></summary>
    let Centrality = Namespaced_IRI.parse _namespace_name "Centrality" |> NamespacedName

    /// <summary>
    /// The network similarity measures local metrics that deviate from graph theory. For example, cooperativeness and centrality can be deviated based on the network metrics
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/NetworkSimilarityMetric"></see></summary>
    let NetworkSimilarityMetric =
        Namespaced_IRI.parse _namespace_name "NetworkSimilarityMetric" |> NamespacedName

    /// <summary>
    /// Certificate-based relationships establish relationships based on the affiliation of the certificate.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/CertificateBasedRelationship"></see></summary>
    let CertificateBasedRelationship =
        Namespaced_IRI.parse _namespace_name "CertificateBasedRelationship" |> NamespacedName

    /// <summary>
    /// The Class Setting Recommendation provides recommendations towards the setting of classes for trust recommendations.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Class_Setting_Recommendation"></see></summary>
    let Class_Setting_Recommendation =
        Namespaced_IRI.parse _namespace_name "Class_Setting_Recommendation" |> NamespacedName

    /// <summary>
    /// Trust Decision Setting Recommendation concerns about the recommendation of settings for trust decision-making.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Trust_Decision_Setting_Recommendation"></see></summary>
    let Trust_Decision_Setting_Recommendation =
        Namespaced_IRI.parse _namespace_name "Trust_Decision_Setting_Recommendation" |> NamespacedName

    /// <summary>
    /// Closeness centrality calculates how close a node is to all other nodes in the network. Nodes with a high closeness centrality are well-connected to other nodes in the network and can quickly access and share information with them.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/ClosenessCentrality"></see></summary>
    let ClosenessCentrality =
        Namespaced_IRI.parse _namespace_name "ClosenessCentrality" |> NamespacedName

    /// <summary>
    /// Co-Location relationships establish relationships based on the close proximity of two nodes.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/CoLocationObjectRelationship"></see></summary>
    let CoLocationObjectRelationship =
        Namespaced_IRI.parse _namespace_name "CoLocationObjectRelationship" |> NamespacedName

    /// <summary>
    /// Co-Work relationships establish relationships based on frequent cooperation.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/CoWorkRelationship"></see></summary>
    let CoWorkRelationship =
        Namespaced_IRI.parse _namespace_name "CoWorkRelationship" |> NamespacedName

    /// <summary>
    /// The community recommendation entity recommends multiple trust relations between and trustor and multiple trustee in the network based on the criteria in the given context.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/CommunityRecommendation"></see></summary>
    let CommunityRecommendation =
        Namespaced_IRI.parse _namespace_name "CommunityRecommendation" |> NamespacedName

    /// <summary>
    /// Domain-specific Trust Recommendation provides trust recommendation towards entities in this domain.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Domain-specific_Trust_Recommendation"></see></summary>
    let ``Domain-specific_Trust_Recommendation`` =
        Namespaced_IRI.parse _namespace_name "Domain-specific_Trust_Recommendation" |> NamespacedName

    /// <summary>
    /// Cooperativeness refers to the willingness of devices or entities to work together towards a common goal. Therefore, cooperativeness can be determined by the degree of common friends between nodes (Bao, 2011).
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Cooperativeness"></see></summary>
    let Cooperativeness =
        Namespaced_IRI.parse _namespace_name "Cooperativeness" |> NamespacedName

    /// <summary>
    /// Credibility refers to the degree to which a device, service requestor, or service provider is reliable and trustworthy.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Credibility"></see></summary>
    let Credibility =
        Namespaced_IRI.parse _namespace_name "Credibility" |> NamespacedName

    /// <summary>
    /// The social trust metrics measure trust between two nodes based on their social properties.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/SocialTrustMetric"></see></summary>
    let SocialTrustMetric =
        Namespaced_IRI.parse _namespace_name "SocialTrustMetric" |> NamespacedName

    /// <summary>
    /// The cumulative bandwidth average describes the maximum transfer capacity of a network in a given time interval.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/CumulativeBandwidthAverage"></see></summary>
    let CumulativeBandwidthAverage =
        Namespaced_IRI.parse _namespace_name "CumulativeBandwidthAverage" |> NamespacedName

    /// <summary>
    /// The network traffic considers interaction-related attributes within the network.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/NetworkTrafficMetric"></see></summary>
    let NetworkTrafficMetric =
        Namespaced_IRI.parse _namespace_name "NetworkTrafficMetric" |> NamespacedName

    /// <summary>
    /// Degree centrality measures the number of relationships a node has within a network. Nodes with a high degree of centrality are well-connected within the network.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/DegreeCentrality"></see></summary>
    let DegreeCentrality =
        Namespaced_IRI.parse _namespace_name "DegreeCentrality" |> NamespacedName

    /// <summary>
    /// The delivery metric measures the satisfaction of the package delivery.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/DeliveryMetric"></see></summary>
    let DeliveryMetric =
        Namespaced_IRI.parse _namespace_name "DeliveryMetric" |> NamespacedName

    /// <summary>
    /// The physical network metric summarizes attributes to measure Quality-of-Service attributes to ensure reliablity and availability.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/PhysicalNetworkMetric"></see></summary>
    let PhysicalNetworkMetric =
        Namespaced_IRI.parse _namespace_name "PhysicalNetworkMetric" |> NamespacedName

    /// <summary>
    /// The delivery ratio consider transactions with a certain attribute in contrast to the overall transactions.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/DeliveryRatio"></see></summary>
    let DeliveryRatio =
        Namespaced_IRI.parse _namespace_name "DeliveryRatio" |> NamespacedName

    /// <summary>
    /// In the SAREF ontology, a tangible object is designed to accomplish a particular task. In order to accomplish this task, the device performs one or more functions. For example, a washing machine is designed to wash (task) and to accomplish this task it performs a start and stop function.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Device"></see></summary>
    let Device = Namespaced_IRI.parse _namespace_name "Device" |> NamespacedName
    /// <summary>
    /// A node can be perceived at various device levels depending on the granularity.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Node"></see></summary>
    let Node = Namespaced_IRI.parse _namespace_name "Node" |> NamespacedName

    /// <summary>
    /// The device reputation refers to collected ratings of individual devices about the rated device.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/DeviceReputation"></see></summary>
    let DeviceReputation =
        Namespaced_IRI.parse _namespace_name "DeviceReputation" |> NamespacedName

    /// <summary>
    /// The objective experience evaluation refers to collected ratings of individual nodes about the specific entity.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/ObjectiveExperience"></see></summary>
    let ObjectiveExperience =
        Namespaced_IRI.parse _namespace_name "ObjectiveExperience" |> NamespacedName

    /// <summary>
    /// Direct Recommendation refers between the subjective node with directly interacted node that recommends its experience with the recommended node. The direct recommendation is a subclass of direct recommendation since a direct recommendation consists of two direct experiences.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/DirectRecommendation"></see></summary>
    let DirectRecommendation =
        Namespaced_IRI.parse _namespace_name "DirectRecommendation" |> NamespacedName

    /// <summary>
    /// The subjective-based experience category includes only the local transaction context of one node with other nodes.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/SubjectiveExperience"></see></summary>
    let SubjectiveExperience =
        Namespaced_IRI.parse _namespace_name "SubjectiveExperience" |> NamespacedName

    /// <summary>
    /// Direct Trust refers to the experience between the subjective node with directly interacted node.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/DirectTrust"></see></summary>
    let DirectTrust =
        Namespaced_IRI.parse _namespace_name "DirectTrust" |> NamespacedName

    /// <summary>
    /// The trust recommendation entity provides a recommendation towards entities in the network
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/TrustRecommendation"></see></summary>
    let TrustRecommendation =
        Namespaced_IRI.parse _namespace_name "TrustRecommendation" |> NamespacedName

    /// <summary>
    /// The dropped package ratio presents the number of dropped packages in contrast to the overall sent packges.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/DroppedPackageRatio"></see></summary>
    let DroppedPackageRatio =
        Namespaced_IRI.parse _namespace_name "DroppedPackageRatio" |> NamespacedName

    /// <summary>
    /// Experience-based relationships emerge from the transaction context between the service provider and the service requestor
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/ExperienceBasedRelationship"></see></summary>
    let ExperienceBasedRelationship =
        Namespaced_IRI.parse _namespace_name "ExperienceBasedRelationship" |> NamespacedName

    /// <summary>
    /// A function is a node in Social Internet of Things.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Function"></see></summary>
    let Function = Namespaced_IRI.parse _namespace_name "Function" |> NamespacedName

    /// <summary>
    /// The service reputation refers to collected ratings of individual service about the rated service.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/FunctionReputation"></see></summary>
    let FunctionReputation =
        Namespaced_IRI.parse _namespace_name "FunctionReputation" |> NamespacedName

    /// <summary>
    /// Honesty refers to the degree to which a device, service requestor, or service provider is the accuracy of the delivered information. Honesty is determined through direct experiences from previous transactions.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Honesty"></see></summary>
    let Honesty = Namespaced_IRI.parse _namespace_name "Honesty" |> NamespacedName

    /// <summary>
    /// The indirect recommendation is a direct recommendation from a related node to the recommending node to the local transaction context of the node, whereas the |edge_distance| = 3.
    ///
    /// The indirect recommendation consists of one direct trust relationship and one direct recommendation relationships.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/IndirectRecommendation"></see></summary>
    let IndirectRecommendation =
        Namespaced_IRI.parse _namespace_name "IndirectRecommendation" |> NamespacedName

    /// <summary>
    /// Theinteraction frequency measures how often nodes have been interacting with each other.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/InteractionFrequency"></see></summary>
    let InteractionFrequency =
        Namespaced_IRI.parse _namespace_name "InteractionFrequency" |> NamespacedName

    /// <summary>
    /// Tie strength formed by interaction-related attribtues from previous transactions
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/TieStengthMetric"></see></summary>
    let TieStengthMetric =
        Namespaced_IRI.parse _namespace_name "TieStengthMetric" |> NamespacedName

    /// <summary>
    /// The interaction length describes how long two nodes have been interacting with to conclude trustworthiness between nodes.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/InteractionLength"></see></summary>
    let InteractionLength =
        Namespaced_IRI.parse _namespace_name "InteractionLength" |> NamespacedName

    /// <summary>
    /// Latency refers to the measured time delay for a data packet to travel from its source to its destination over a network.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Latency"></see></summary>
    let Latency = Namespaced_IRI.parse _namespace_name "Latency" |> NamespacedName

    /// <summary>
    /// Time-dependent metric refers to the behavior of network traffic based on the time property.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/TimeRelatedMetric"></see></summary>
    let TimeRelatedMetric =
        Namespaced_IRI.parse _namespace_name "TimeRelatedMetric" |> NamespacedName

    /// <summary>
    /// The network provides information related to the network
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Network"></see></summary>
    let Network = Namespaced_IRI.parse _namespace_name "Network" |> NamespacedName

    /// <summary>
    /// The social network metric provides information related to entities of the socialized network.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/SocialNetworkMetric"></see></summary>
    let SocialNetworkMetric =
        Namespaced_IRI.parse _namespace_name "SocialNetworkMetric" |> NamespacedName

    /// <summary>
    /// The node recommendation entity recommends a node in the network that is most suitable to conduct at task depending on the evaluation metrics in the given context.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Node_Recommendation"></see></summary>
    let Node_Recommendation =
        Namespaced_IRI.parse _namespace_name "Node_Recommendation" |> NamespacedName

    /// <summary>
    /// The owner object relationship refers to devices that are owned by the same user
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/OwnershipObjectRelationship"></see></summary>
    let OwnershipObjectRelationship =
        Namespaced_IRI.parse _namespace_name "OwnershipObjectRelationship" |> NamespacedName

    /// <summary>
    /// The package overhead ratio refers to the ratio of the packet header information to the payload information in a network packet.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/PackageOverheadRatio"></see></summary>
    let PackageOverheadRatio =
        Namespaced_IRI.parse _namespace_name "PackageOverheadRatio" |> NamespacedName

    /// <summary>
    /// The package transmission rate defines the number of transmitted packages in a given time interval.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/PackageTramsmissionRate"></see></summary>
    let PackageTramsmissionRate =
        Namespaced_IRI.parse _namespace_name "PackageTramsmissionRate" |> NamespacedName

    /// <summary>
    /// A parental object relationship refers to objects that are manufactured in the same period of time by the same manufacturer.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/ParentalObjectRelationship"></see></summary>
    let ParentalObjectRelationship =
        Namespaced_IRI.parse _namespace_name "ParentalObjectRelationship" |> NamespacedName

    /// <summary>
    /// The delivery ratio consider failed transactions in contrast to the overall transactions.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/RatioOfFailedTransactions"></see></summary>
    let RatioOfFailedTransactions =
        Namespaced_IRI.parse _namespace_name "RatioOfFailedTransactions" |> NamespacedName

    /// <summary>
    /// The delivery ratio consider successful transactions in contrast to the overall transactions.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/RatioOfSuccessfulTransactions"></see></summary>
    let RatioOfSuccessfulTransactions =
        Namespaced_IRI.parse _namespace_name "RatioOfSuccessfulTransactions" |> NamespacedName

    /// <summary>
    /// The Relationship Existance Recommendation entity provides a recommendation if a social link between two nodes exists.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Relationship_Existance_Recommendation"></see></summary>
    let Relationship_Existance_Recommendation =
        Namespaced_IRI.parse _namespace_name "Relationship_Existance_Recommendation" |> NamespacedName

    /// <summary>
    /// The trust relation recommendation entity recommends a trust relation between the trustor and the trustee in the given context.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/TrustRelationRecommendation"></see></summary>
    let TrustRelationRecommendation =
        Namespaced_IRI.parse _namespace_name "TrustRelationRecommendation" |> NamespacedName

    /// <summary>
    /// The Relationship Existance Recommendation entity provides a recommendation about the label of the link between two nodes exists. The label of a relationship can be a set of attributes, a specific name of the relationship, or a specific value.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Relationship_Labeling_Recommendation"></see></summary>
    let Relationship_Labeling_Recommendation =
        Namespaced_IRI.parse _namespace_name "Relationship_Labeling_Recommendation" |> NamespacedName

    /// <summary>
    /// The representation of trust defines the concept of different trust representation. For example, trust can be represented using qualitative expressions, such as "Trusted" and "Untrusted", or binary expressions, such TRUE and FALSE
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/RepresentationOfTrust"></see></summary>
    let RepresentationOfTrust =
        Namespaced_IRI.parse _namespace_name "RepresentationOfTrust" |> NamespacedName

    /// <summary>
    /// Response time refers to the time of a device to respond to a network request.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/ResponseTime"></see></summary>
    let ResponseTime =
        Namespaced_IRI.parse _namespace_name "ResponseTime" |> NamespacedName

    /// <summary>
    /// The retransmission rate referes to the number of retransmitted packets to the total number of packets transmitted.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/RetransmissionRate"></see></summary>
    let RetransmissionRate =
        Namespaced_IRI.parse _namespace_name "RetransmissionRate" |> NamespacedName

    /// <summary>
    /// A service is a node in Social Internet of Things.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Service"></see></summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName

    /// <summary>
    ///   <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/ServiceProvider"></see>
    /// </summary>
    let ServiceProvider =
        Namespaced_IRI.parse _namespace_name "ServiceProvider" |> NamespacedName

    /// <summary>
    /// The function reputation refers to collected ratings of individual function about the rated function.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/ServiceReputation"></see></summary>
    let ServiceReputation =
        Namespaced_IRI.parse _namespace_name "ServiceReputation" |> NamespacedName

    /// <summary>
    /// The trustor is an agent that initiates the interaction to a perceived trustworthy agent, the trustee, to request a task in a given context to achieve its objective.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/ServiceRequestor"></see></summary>
    let ServiceRequestor =
        Namespaced_IRI.parse _namespace_name "ServiceRequestor" |> NamespacedName

    /// <summary>
    /// The Situation-dependent Trust Recommendation entity captures concepts related to imrprove the trust recommendation based on the existing situation.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Situation-Dependent_Trust_Settings_Recommendation"></see></summary>
    let ``Situation-Dependent_Trust_Settings_Recommendation`` =
        Namespaced_IRI.parse _namespace_name "Situation-Dependent_Trust_Settings_Recommendation" |> NamespacedName

    /// <summary>
    /// Technical Trust Recommendation addresses technical issues of the trust computation, decision-making, and review to produce accurate trust recommendations.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/TechnicalTrustRecommendation"></see></summary>
    let TechnicalTrustRecommendation =
        Namespaced_IRI.parse _namespace_name "TechnicalTrustRecommendation" |> NamespacedName

    /// <summary>
    /// Social Object Relationship defines occasionally encounters  of devices due to the relation between owners
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/SocialObjectRelationship"></see></summary>
    let SocialObjectRelationship =
        Namespaced_IRI.parse _namespace_name "SocialObjectRelationship" |> NamespacedName

    /// <summary>
    /// Throughput represents the amount of data that is successfully transmitted in a network in a given period of time to measure the efficiency of a network.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Throughput"></see></summary>
    let Throughput = Namespaced_IRI.parse _namespace_name "Throughput" |> NamespacedName

    /// <summary>
    /// The transaction context involves all attributes to model the perceived trust based in a given context.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/TransactionContext"></see></summary>
    let TransactionContext =
        Namespaced_IRI.parse _namespace_name "TransactionContext" |> NamespacedName

    /// <summary>
    /// The Trust Feature Recommendation entity provides a recommendation of trust features to produce trust recommendations based on the exisiting situation.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Trust_Feature_Recommendation"></see></summary>
    let Trust_Feature_Recommendation =
        Namespaced_IRI.parse _namespace_name "Trust_Feature_Recommendation" |> NamespacedName

    /// <summary>
    /// The Trust Metric Evaluation Recommendation entity provides a recommendation of trust evaluation metrics to review the produced trust recommendation in the exisiting situation.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Trust_Metric_Evaluation_Recommendation"></see></summary>
    let Trust_Metric_Evaluation_Recommendation =
        Namespaced_IRI.parse _namespace_name "Trust_Metric_Evaluation_Recommendation" |> NamespacedName

    /// <summary>
    /// The Trust Threshold Recommendation provides a recommendation for a threshold in a trust decision-marking process.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Trust_Threshold_Recommendation"></see></summary>
    let Trust_Threshold_Recommendation =
        Namespaced_IRI.parse _namespace_name "Trust_Threshold_Recommendation" |> NamespacedName

    /// <summary>
    /// The Trust Weight Adaption Recommendation entity provides recommendations to the appropriate weight for a feature in the current situation.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/Trust_Weight_Adaption_Recommendation"></see></summary>
    let Trust_Weight_Adaption_Recommendation =
        Namespaced_IRI.parse _namespace_name "Trust_Weight_Adaption_Recommendation" |> NamespacedName

    /// <summary>
    /// A node acts as trustor or as trustee.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/actsAs"></see></summary>
    let actsAs = Namespaced_IRI.parse _namespace_name "actsAs" |> NamespacedName
    /// <summary>
    /// An trustor or and trustee are acted by a device.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/isActedBy"></see></summary>
    let isActedBy = Namespaced_IRI.parse _namespace_name "isActedBy" |> NamespacedName

    /// <summary>
    /// A node is a component of the network.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/communicatesIn"></see></summary>
    let communicatesIn =
        Namespaced_IRI.parse _namespace_name "communicatesIn" |> NamespacedName

    /// <summary>
    /// A network has a device as component
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/isCommunicatedIn"></see></summary>
    let isCommunicatedIn =
        Namespaced_IRI.parse _namespace_name "isCommunicatedIn" |> NamespacedName

    /// <summary>
    /// A trustor establishes the transaction context.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/establishes"></see></summary>
    let establishes =
        Namespaced_IRI.parse _namespace_name "establishes" |> NamespacedName

    /// <summary>
    /// The transaction context is established by the trustor.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/isEstablishedBy"></see></summary>
    let isEstablishedBy =
        Namespaced_IRI.parse _namespace_name "isEstablishedBy" |> NamespacedName

    /// <summary>
    /// A relationship forms the network.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/forms"></see></summary>
    let forms = Namespaced_IRI.parse _namespace_name "forms" |> NamespacedName
    /// <summary>
    /// The network is formed by relationships.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/isFormedBy"></see></summary>
    let isFormedBy = Namespaced_IRI.parse _namespace_name "isFormedBy" |> NamespacedName

    /// <summary>
    /// The transaction context has a requrest function
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/hasRequestFunction"></see></summary>
    let hasRequestFunction =
        Namespaced_IRI.parse _namespace_name "hasRequestFunction" |> NamespacedName

    /// <summary>
    /// A transaction context has a timestamp
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/hasTimestamp"></see></summary>
    let hasTimestamp =
        Namespaced_IRI.parse _namespace_name "hasTimestamp" |> NamespacedName

    /// <summary>
    /// A transaction context has a trust value
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/hasTrustValue"></see></summary>
    let hasTrustValue =
        Namespaced_IRI.parse _namespace_name "hasTrustValue" |> NamespacedName

    /// <summary>
    /// Devices are linked by relationships.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/isLinkedBy"></see></summary>
    let isLinkedBy = Namespaced_IRI.parse _namespace_name "isLinkedBy" |> NamespacedName
    /// <summary>
    /// A relationship links devices.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/links"></see></summary>
    let links = Namespaced_IRI.parse _namespace_name "links" |> NamespacedName

    /// <summary>
    /// Trustor, Trustee, Network, and Relationship classes are recommended by Trust Recommendation.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/isRecommendedBy"></see></summary>
    let isRecommendedBy =
        Namespaced_IRI.parse _namespace_name "isRecommendedBy" |> NamespacedName

    /// <summary>
    /// A Trust Recommendation recommends Networks, Relationships, Trustor, and Trustee.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/recommends"></see></summary>
    let recommends = Namespaced_IRI.parse _namespace_name "recommends" |> NamespacedName

    /// <summary>
    /// A trust recommendation is requested by a trustee or a trustor
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/isRequestedBy"></see></summary>
    let isRequestedBy =
        Namespaced_IRI.parse _namespace_name "isRequestedBy" |> NamespacedName

    /// <summary>
    /// The trustee and the trustor request trust recommendations.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/requests"></see></summary>
    let requests = Namespaced_IRI.parse _namespace_name "requests" |> NamespacedName

    /// <summary>
    /// The transaction context is required by the trustor and the trustee.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/isRequiredBy"></see></summary>
    let isRequiredBy =
        Namespaced_IRI.parse _namespace_name "isRequiredBy" |> NamespacedName

    /// <summary>
    /// The transaction context requires a trustor and a trustee.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/requires"></see></summary>
    let requires = Namespaced_IRI.parse _namespace_name "requires" |> NamespacedName

    /// <summary>
    /// The transaction context has a representsation of the trust value.
    /// <see href="https://liidr.org/trust-recommendation-in-social-internet-of-things/representsTrustValueIn"></see></summary>
    let representsTrustValueIn =
        Namespaced_IRI.parse _namespace_name "representsTrustValueIn" |> NamespacedName
