namespace http.w3id.org.CEON.ontology.value.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ceon_value =
    let _namespace_iri = Namespace_Iri ceon_value |> NamespaceIRI
    /// <summary>
    ///   <para>ceon-value:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>A core ODP of the CEON ontology network, defining aspects of the value concept.</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/">http://w3id.org/CEON/ontology/value/</seealso>
    let _prefix_iri = Prefixed_Name(ceon_value, "") |> PrefixedName
    /// <summary>
    ///   <para>ceon-value:Value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Gain(s) or benefit(s) from satisfying needs and expectations,	in relation to the use	and conservation of resources. EXAMPLE: Revenue, savings, productivity, sustainability, satisfaction, empowerment, engagement, experience, public health, trust. Value is relative to, and determined by the perception of, those interested party(ies) able to capture it. Value can be financial or non-financial, e.g. social, environmental, other gains or benefits. Value is dynamic over time.</para>
    /// labels<para>Value</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/Value">http://w3id.org/CEON/ontology/value/Value</seealso>
    let Value = Prefixed_Name(ceon_value, "Value") |> PrefixedName
    /// <summary>
    ///   <para>ceon-value:SocialValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Social value represents how a thing (e.g., a product or service) match some social goals or needs of an actor under some circumstances.</para>
    /// labels<para>Social Value</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/SocialValue">http://w3id.org/CEON/ontology/value/SocialValue</seealso>
    let SocialValue = Prefixed_Name(ceon_value, "SocialValue") |> PrefixedName
    /// <summary>
    ///   <para>ceon-value:ValueConsumer</para>
    /// </summary>
    /// <remarks>
    ///   <para>ceon:ontology/value/ValueParticipationRole</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/ValueConsumer">http://w3id.org/CEON/ontology/value/ValueConsumer</seealso>
    let ValueConsumer = Prefixed_Name(ceon_value, "ValueConsumer") |> PrefixedName
    /// <summary>
    ///   <para>ceon-value:ValueDistributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>ceon:ontology/value/ValueParticipationRole</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/ValueDistributor">http://w3id.org/CEON/ontology/value/ValueDistributor</seealso>
    let ValueDistributor = Prefixed_Name(ceon_value, "ValueDistributor") |> PrefixedName
    /// <summary>
    ///   <para>ceon-value:ValueEvaluator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ceon:ontology/value/ValueParticipationRole</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/ValueEvaluator">http://w3id.org/CEON/ontology/value/ValueEvaluator</seealso>
    let ValueEvaluator = Prefixed_Name(ceon_value, "ValueEvaluator") |> PrefixedName
    /// <summary>
    ///   <para>ceon-value:ValuePerception</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Value perception of an actor determines specifc values.</para>
    /// labels<para>Value Perception</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/ValuePerception">http://w3id.org/CEON/ontology/value/ValuePerception</seealso>
    let ValuePerception = Prefixed_Name(ceon_value, "ValuePerception") |> PrefixedName
    /// <summary>
    ///   <para>ceon-value:targettingActor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A value proposition is about some actors.</para>
    /// labels<para>targetting actor</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/targettingActor">http://w3id.org/CEON/ontology/value/targettingActor</seealso>
    let targettingActor = Prefixed_Name(ceon_value, "targettingActor") |> PrefixedName
    /// <summary>
    ///   <para>ceon-value:hasVPTargets</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A value proposition is proposed about specific actors, participations or resources.</para>
    /// labels<para>has value proposition targets</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/hasVPTargets">http://w3id.org/CEON/ontology/value/hasVPTargets</seealso>
    let hasVPTargets = Prefixed_Name(ceon_value, "hasVPTargets") |> PrefixedName

    /// <summary>
    ///   <para>ceon-value:onValueParticipation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A perception is on specific value participations.</para>
    /// labels<para>on value participation</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/onValueParticipation">http://w3id.org/CEON/ontology/value/onValueParticipation</seealso>
    let onValueParticipation =
        Prefixed_Name(ceon_value, "onValueParticipation") |> PrefixedName

    /// <summary>
    ///   <para>ceon-value:EconomicValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Use/Economics value represents how a thing (e.g., a product or service) match some goals or needs of an actor under some circumstances.</para>
    /// labels<para>Economic Value</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/EconomicValue">http://w3id.org/CEON/ontology/value/EconomicValue</seealso>
    let EconomicValue = Prefixed_Name(ceon_value, "EconomicValue") |> PrefixedName
    /// <summary>
    ///   <para>ceon-value:UseValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Use/Economics value represents how a thing (e.g., a product or service) match some goals or needs of an actor under some circumstances.</para>
    /// labels<para>Use Value</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/UseValue">http://w3id.org/CEON/ontology/value/UseValue</seealso>
    let UseValue = Prefixed_Name(ceon_value, "UseValue") |> PrefixedName
    /// <summary>
    ///   <para>ceon-value:ValueProposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Proposed or intended value outcome of some process, action or collaboration.</para>
    /// labels<para>Value Proposition</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/ValueProposition">http://w3id.org/CEON/ontology/value/ValueProposition</seealso>
    let ValueProposition = Prefixed_Name(ceon_value, "ValueProposition") |> PrefixedName

    /// <summary>
    ///   <para>ceon-value:targettingValueParticipation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A value proposition is about some participation.</para>
    /// labels<para>targetting value participation</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/targettingValueParticipation">http://w3id.org/CEON/ontology/value/targettingValueParticipation</seealso>
    let targettingValueParticipation =
        Prefixed_Name(ceon_value, "targettingValueParticipation") |> PrefixedName

    /// <summary>
    ///   <para>ceon-value:hasValueParticipantRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Holds the value of the role of the value participant in this value participation relation.</para>
    /// labels<para>has value participant role</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/hasValueParticipantRole">http://w3id.org/CEON/ontology/value/hasValueParticipantRole</seealso>
    let hasValueParticipantRole =
        Prefixed_Name(ceon_value, "hasValueParticipantRole") |> PrefixedName

    /// <summary>
    ///   <para>ceon-value:targettingResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A value proposition is about some resources.</para>
    /// labels<para>targetting resource</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/targettingResource">http://w3id.org/CEON/ontology/value/targettingResource</seealso>
    let targettingResource =
        Prefixed_Name(ceon_value, "targettingResource") |> PrefixedName

    /// <summary>
    ///   <para>ceon-value:ValueParticipation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A participation that may create/destory/miss value.</para>
    /// labels<para>Value Participation</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/ValueParticipation">http://w3id.org/CEON/ontology/value/ValueParticipation</seealso>
    let ValueParticipation =
        Prefixed_Name(ceon_value, "ValueParticipation") |> PrefixedName

    /// <summary>
    ///   <para>ceon-value:hasAimedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A value proposition has specific aimed values.</para>
    /// labels<para>has aimed value</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/hasAimedValue">http://w3id.org/CEON/ontology/value/hasAimedValue</seealso>
    let hasAimedValue = Prefixed_Name(ceon_value, "hasAimedValue") |> PrefixedName

    /// <summary>
    ///   <para>ceon-value:hasValuableResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A value participation has participating resources.</para>
    /// labels<para>has valuable resource</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/hasValuableResource">http://w3id.org/CEON/ontology/value/hasValuableResource</seealso>
    let hasValuableResource =
        Prefixed_Name(ceon_value, "hasValuableResource") |> PrefixedName

    /// <summary>
    ///   <para>ceon-value:proposedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A value proposition is proposed by specific actors.</para>
    /// labels<para>proposed by</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/proposedBy">http://w3id.org/CEON/ontology/value/proposedBy</seealso>
    let proposedBy = Prefixed_Name(ceon_value, "proposedBy") |> PrefixedName
    /// <summary>
    ///   <para>ceon-value:hasPerception</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An actor perceive specific values, or a value proposition is about specific values.</para>
    /// labels<para>has perception</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/hasPerception">http://w3id.org/CEON/ontology/value/hasPerception</seealso>
    let hasPerception = Prefixed_Name(ceon_value, "hasPerception") |> PrefixedName
    /// <summary>
    ///   <para>ceon-value:0.3/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/0.3/">http://w3id.org/CEON/ontology/value/0.3/</seealso>
    let ``_0.3/`` = Prefixed_Name(ceon_value, "0.3/") |> PrefixedName

    /// <summary>
    ///   <para>ceon-value:EnvironmentalValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Environmental value represents how a thing (e.g., a product or service) match some environmental goals or needs of an actor under some circumstances.</para>
    /// labels<para>Environmental Value</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/EnvironmentalValue">http://w3id.org/CEON/ontology/value/EnvironmentalValue</seealso>
    let EnvironmentalValue =
        Prefixed_Name(ceon_value, "EnvironmentalValue") |> PrefixedName

    /// <summary>
    ///   <para>ceon-value:ExchangeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Exchange value represents the worth of a product, resource, service in a exchange setting, i.e., a product, resource, service is traded or sold.</para>
    /// labels<para>Exchange Value</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/ExchangeValue">http://w3id.org/CEON/ontology/value/ExchangeValue</seealso>
    let ExchangeValue = Prefixed_Name(ceon_value, "ExchangeValue") |> PrefixedName

    /// <summary>
    ///   <para>ceon-value:ValueParticipationRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A role that a value participant can take.</para>
    /// labels<para>Value Participation Role</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/ValueParticipationRole">http://w3id.org/CEON/ontology/value/ValueParticipationRole</seealso>
    let ValueParticipationRole =
        Prefixed_Name(ceon_value, "ValueParticipationRole") |> PrefixedName

    /// <summary>
    ///   <para>ceon-value:ValueContributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>ceon:ontology/value/ValueParticipationRole</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/ValueContributor">http://w3id.org/CEON/ontology/value/ValueContributor</seealso>
    let ValueContributor = Prefixed_Name(ceon_value, "ValueContributor") |> PrefixedName
    /// <summary>
    ///   <para>ceon-value:ValueCreator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ceon:ontology/value/ValueParticipationRole</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/ValueCreator">http://w3id.org/CEON/ontology/value/ValueCreator</seealso>
    let ValueCreator = Prefixed_Name(ceon_value, "ValueCreator") |> PrefixedName
    /// <summary>
    ///   <para>ceon-value:ValueDestroyer</para>
    /// </summary>
    /// <remarks>
    ///   <para>ceon:ontology/value/ValueParticipationRole</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/ValueDestroyer">http://w3id.org/CEON/ontology/value/ValueDestroyer</seealso>
    let ValueDestroyer = Prefixed_Name(ceon_value, "ValueDestroyer") |> PrefixedName

    /// <summary>
    ///   <para>ceon-value:hasAssociatedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A value perception about creating/destoring/missing some value.</para>
    /// labels<para>has associated value</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/hasAssociatedValue">http://w3id.org/CEON/ontology/value/hasAssociatedValue</seealso>
    let hasAssociatedValue =
        Prefixed_Name(ceon_value, "hasAssociatedValue") |> PrefixedName
