namespace http.w3id.org.CEON.ontology.value.slash

open DoxAletheia

module ceon_value =
    let _namespace_name = "http://w3id.org/CEON/ontology/value/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/value/0.3/"></see>
    /// </summary>
    let ``_0.3/`` = _prefix "0.3/"
    /// <summary>
    /// Use/Economics value represents how a thing (e.g., a product or service) match some goals or needs of an actor under some circumstances.
    /// <see href="http://w3id.org/CEON/ontology/value/EconomicValue"></see></summary>
    let EconomicValue = _prefix "EconomicValue"
    /// <summary>
    /// Gain(s) or benefit(s) from satisfying needs and expectations,	in relation to the use	and conservation of resources. EXAMPLE: Revenue, savings, productivity, sustainability, satisfaction, empowerment, engagement, experience, public health, trust. Value is relative to, and determined by the perception of, those interested party(ies) able to capture it. Value can be financial or non-financial, e.g. social, environmental, other gains or benefits. Value is dynamic over time.
    /// <see href="http://w3id.org/CEON/ontology/value/Value"></see></summary>
    let Value = _prefix "Value"
    /// <summary>
    /// Use/Economics value represents how a thing (e.g., a product or service) match some goals or needs of an actor under some circumstances.
    /// <see href="http://w3id.org/CEON/ontology/value/UseValue"></see></summary>
    let UseValue = _prefix "UseValue"
    /// <summary>
    /// Environmental value represents how a thing (e.g., a product or service) match some environmental goals or needs of an actor under some circumstances.
    /// <see href="http://w3id.org/CEON/ontology/value/EnvironmentalValue"></see></summary>
    let EnvironmentalValue = _prefix "EnvironmentalValue"
    /// <summary>
    /// Exchange value represents the worth of a product, resource, service in a exchange setting, i.e., a product, resource, service is traded or sold.
    /// <see href="http://w3id.org/CEON/ontology/value/ExchangeValue"></see></summary>
    let ExchangeValue = _prefix "ExchangeValue"
    /// <summary>
    /// Social value represents how a thing (e.g., a product or service) match some social goals or needs of an actor under some circumstances.
    /// <see href="http://w3id.org/CEON/ontology/value/SocialValue"></see></summary>
    let SocialValue = _prefix "SocialValue"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/value/ValueConsumer"></see>
    /// </summary>
    let ValueConsumer = _prefix "ValueConsumer"
    /// <summary>
    /// A role that a value participant can take.
    /// <see href="http://w3id.org/CEON/ontology/value/ValueParticipationRole"></see></summary>
    let ValueParticipationRole = _prefix "ValueParticipationRole"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/value/ValueContributor"></see>
    /// </summary>
    let ValueContributor = _prefix "ValueContributor"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/value/ValueCreator"></see>
    /// </summary>
    let ValueCreator = _prefix "ValueCreator"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/value/ValueDestroyer"></see>
    /// </summary>
    let ValueDestroyer = _prefix "ValueDestroyer"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/value/ValueDistributor"></see>
    /// </summary>
    let ValueDistributor = _prefix "ValueDistributor"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/value/ValueEvaluator"></see>
    /// </summary>
    let ValueEvaluator = _prefix "ValueEvaluator"
    /// <summary>
    /// A participation that may create/destory/miss value.
    /// <see href="http://w3id.org/CEON/ontology/value/ValueParticipation"></see></summary>
    let ValueParticipation = _prefix "ValueParticipation"
    /// <summary>
    /// A value perception about creating/destoring/missing some value.
    /// <see href="http://w3id.org/CEON/ontology/value/hasAssociatedValue"></see></summary>
    let hasAssociatedValue = _prefix "hasAssociatedValue"
    /// <summary>
    /// Value perception of an actor determines specifc values.
    /// <see href="http://w3id.org/CEON/ontology/value/ValuePerception"></see></summary>
    let ValuePerception = _prefix "ValuePerception"
    /// <summary>
    /// Proposed or intended value outcome of some process, action or collaboration.
    /// <see href="http://w3id.org/CEON/ontology/value/ValueProposition"></see></summary>
    let ValueProposition = _prefix "ValueProposition"
    /// <summary>
    /// A value proposition has specific aimed values.
    /// <see href="http://w3id.org/CEON/ontology/value/hasAimedValue"></see></summary>
    let hasAimedValue = _prefix "hasAimedValue"
    /// <summary>
    /// A value proposition is about some actors.
    /// <see href="http://w3id.org/CEON/ontology/value/targettingActor"></see></summary>
    let targettingActor = _prefix "targettingActor"
    /// <summary>
    /// A value proposition is about some participation.
    /// <see href="http://w3id.org/CEON/ontology/value/targettingValueParticipation"></see></summary>
    let targettingValueParticipation = _prefix "targettingValueParticipation"
    /// <summary>
    /// An actor perceive specific values, or a value proposition is about specific values.
    /// <see href="http://w3id.org/CEON/ontology/value/hasPerception"></see></summary>
    let hasPerception = _prefix "hasPerception"
    /// <summary>
    /// A value proposition is proposed about specific actors, participations or resources.
    /// <see href="http://w3id.org/CEON/ontology/value/hasVPTargets"></see></summary>
    let hasVPTargets = _prefix "hasVPTargets"
    /// <summary>
    /// A value participation has participating resources.
    /// <see href="http://w3id.org/CEON/ontology/value/hasValuableResource"></see></summary>
    let hasValuableResource = _prefix "hasValuableResource"
    /// <summary>
    /// Holds the value of the role of the value participant in this value participation relation.
    /// <see href="http://w3id.org/CEON/ontology/value/hasValueParticipantRole"></see></summary>
    let hasValueParticipantRole = _prefix "hasValueParticipantRole"
    /// <summary>
    /// A perception is on specific value participations.
    /// <see href="http://w3id.org/CEON/ontology/value/onValueParticipation"></see></summary>
    let onValueParticipation = _prefix "onValueParticipation"
    /// <summary>
    /// A value proposition is proposed by specific actors.
    /// <see href="http://w3id.org/CEON/ontology/value/proposedBy"></see></summary>
    let proposedBy = _prefix "proposedBy"
    /// <summary>
    /// A value proposition is about some resources.
    /// <see href="http://w3id.org/CEON/ontology/value/targettingResource"></see></summary>
    let targettingResource = _prefix "targettingResource"
