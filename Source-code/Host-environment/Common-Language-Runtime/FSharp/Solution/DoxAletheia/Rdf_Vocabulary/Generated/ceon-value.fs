namespace http.w3id.org.CEON.ontology.value.slash

open DoxAletheia.Rdf_Vocabulary

module ceon_value =
    let _namespace_name = "http://w3id.org/CEON/ontology/value/"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/value/0.3/"></see>
    /// </summary>
    let ``_0.3/`` = Namespaced_IRI.parse _namespace_name "0.3/" |> NamespacedName

    /// <summary>
    /// Use/Economics value represents how a thing (e.g., a product or service) match some goals or needs of an actor under some circumstances.
    /// <see href="http://w3id.org/CEON/ontology/value/EconomicValue"></see></summary>
    let EconomicValue =
        Namespaced_IRI.parse _namespace_name "EconomicValue" |> NamespacedName

    /// <summary>
    /// Gain(s) or benefit(s) from satisfying needs and expectations,	in relation to the use	and conservation of resources. EXAMPLE: Revenue, savings, productivity, sustainability, satisfaction, empowerment, engagement, experience, public health, trust. Value is relative to, and determined by the perception of, those interested party(ies) able to capture it. Value can be financial or non-financial, e.g. social, environmental, other gains or benefits. Value is dynamic over time.
    /// <see href="http://w3id.org/CEON/ontology/value/Value"></see></summary>
    let Value = Namespaced_IRI.parse _namespace_name "Value" |> NamespacedName
    /// <summary>
    /// Use/Economics value represents how a thing (e.g., a product or service) match some goals or needs of an actor under some circumstances.
    /// <see href="http://w3id.org/CEON/ontology/value/UseValue"></see></summary>
    let UseValue = Namespaced_IRI.parse _namespace_name "UseValue" |> NamespacedName

    /// <summary>
    /// Environmental value represents how a thing (e.g., a product or service) match some environmental goals or needs of an actor under some circumstances.
    /// <see href="http://w3id.org/CEON/ontology/value/EnvironmentalValue"></see></summary>
    let EnvironmentalValue =
        Namespaced_IRI.parse _namespace_name "EnvironmentalValue" |> NamespacedName

    /// <summary>
    /// Exchange value represents the worth of a product, resource, service in a exchange setting, i.e., a product, resource, service is traded or sold.
    /// <see href="http://w3id.org/CEON/ontology/value/ExchangeValue"></see></summary>
    let ExchangeValue =
        Namespaced_IRI.parse _namespace_name "ExchangeValue" |> NamespacedName

    /// <summary>
    /// Social value represents how a thing (e.g., a product or service) match some social goals or needs of an actor under some circumstances.
    /// <see href="http://w3id.org/CEON/ontology/value/SocialValue"></see></summary>
    let SocialValue =
        Namespaced_IRI.parse _namespace_name "SocialValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/value/ValueConsumer"></see>
    /// </summary>
    let ValueConsumer =
        Namespaced_IRI.parse _namespace_name "ValueConsumer" |> NamespacedName

    /// <summary>
    /// A role that a value participant can take.
    /// <see href="http://w3id.org/CEON/ontology/value/ValueParticipationRole"></see></summary>
    let ValueParticipationRole =
        Namespaced_IRI.parse _namespace_name "ValueParticipationRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/value/ValueContributor"></see>
    /// </summary>
    let ValueContributor =
        Namespaced_IRI.parse _namespace_name "ValueContributor" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/value/ValueCreator"></see>
    /// </summary>
    let ValueCreator =
        Namespaced_IRI.parse _namespace_name "ValueCreator" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/value/ValueDestroyer"></see>
    /// </summary>
    let ValueDestroyer =
        Namespaced_IRI.parse _namespace_name "ValueDestroyer" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/value/ValueDistributor"></see>
    /// </summary>
    let ValueDistributor =
        Namespaced_IRI.parse _namespace_name "ValueDistributor" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/value/ValueEvaluator"></see>
    /// </summary>
    let ValueEvaluator =
        Namespaced_IRI.parse _namespace_name "ValueEvaluator" |> NamespacedName

    /// <summary>
    /// A participation that may create/destory/miss value.
    /// <see href="http://w3id.org/CEON/ontology/value/ValueParticipation"></see></summary>
    let ValueParticipation =
        Namespaced_IRI.parse _namespace_name "ValueParticipation" |> NamespacedName

    /// <summary>
    /// A value perception about creating/destoring/missing some value.
    /// <see href="http://w3id.org/CEON/ontology/value/hasAssociatedValue"></see></summary>
    let hasAssociatedValue =
        Namespaced_IRI.parse _namespace_name "hasAssociatedValue" |> NamespacedName

    /// <summary>
    /// Value perception of an actor determines specifc values.
    /// <see href="http://w3id.org/CEON/ontology/value/ValuePerception"></see></summary>
    let ValuePerception =
        Namespaced_IRI.parse _namespace_name "ValuePerception" |> NamespacedName

    /// <summary>
    /// Proposed or intended value outcome of some process, action or collaboration.
    /// <see href="http://w3id.org/CEON/ontology/value/ValueProposition"></see></summary>
    let ValueProposition =
        Namespaced_IRI.parse _namespace_name "ValueProposition" |> NamespacedName

    /// <summary>
    /// A value proposition has specific aimed values.
    /// <see href="http://w3id.org/CEON/ontology/value/hasAimedValue"></see></summary>
    let hasAimedValue =
        Namespaced_IRI.parse _namespace_name "hasAimedValue" |> NamespacedName

    /// <summary>
    /// A value proposition is about some actors.
    /// <see href="http://w3id.org/CEON/ontology/value/targettingActor"></see></summary>
    let targettingActor =
        Namespaced_IRI.parse _namespace_name "targettingActor" |> NamespacedName

    /// <summary>
    /// A value proposition is about some participation.
    /// <see href="http://w3id.org/CEON/ontology/value/targettingValueParticipation"></see></summary>
    let targettingValueParticipation =
        Namespaced_IRI.parse _namespace_name "targettingValueParticipation" |> NamespacedName

    /// <summary>
    /// An actor perceive specific values, or a value proposition is about specific values.
    /// <see href="http://w3id.org/CEON/ontology/value/hasPerception"></see></summary>
    let hasPerception =
        Namespaced_IRI.parse _namespace_name "hasPerception" |> NamespacedName

    /// <summary>
    /// A value proposition is proposed about specific actors, participations or resources.
    /// <see href="http://w3id.org/CEON/ontology/value/hasVPTargets"></see></summary>
    let hasVPTargets =
        Namespaced_IRI.parse _namespace_name "hasVPTargets" |> NamespacedName

    /// <summary>
    /// A value participation has participating resources.
    /// <see href="http://w3id.org/CEON/ontology/value/hasValuableResource"></see></summary>
    let hasValuableResource =
        Namespaced_IRI.parse _namespace_name "hasValuableResource" |> NamespacedName

    /// <summary>
    /// Holds the value of the role of the value participant in this value participation relation.
    /// <see href="http://w3id.org/CEON/ontology/value/hasValueParticipantRole"></see></summary>
    let hasValueParticipantRole =
        Namespaced_IRI.parse _namespace_name "hasValueParticipantRole" |> NamespacedName

    /// <summary>
    /// A perception is on specific value participations.
    /// <see href="http://w3id.org/CEON/ontology/value/onValueParticipation"></see></summary>
    let onValueParticipation =
        Namespaced_IRI.parse _namespace_name "onValueParticipation" |> NamespacedName

    /// <summary>
    /// A value proposition is proposed by specific actors.
    /// <see href="http://w3id.org/CEON/ontology/value/proposedBy"></see></summary>
    let proposedBy = Namespaced_IRI.parse _namespace_name "proposedBy" |> NamespacedName

    /// <summary>
    /// A value proposition is about some resources.
    /// <see href="http://w3id.org/CEON/ontology/value/targettingResource"></see></summary>
    let targettingResource =
        Namespaced_IRI.parse _namespace_name "targettingResource" |> NamespacedName
