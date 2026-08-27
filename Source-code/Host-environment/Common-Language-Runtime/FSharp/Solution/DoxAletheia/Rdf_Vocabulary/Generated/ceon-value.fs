namespace http.w3id.org.CEON.ontology.value.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ceon_value =
    let _namespace_iri = Namespace_Iri ceon_value |> NamespaceIRI
    /// <summary>
    ///   <para>ceon:ontology/value/</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"A core ODP of the CEON ontology network, defining aspects of the value concept."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/">http://w3id.org/CEON/ontology/value/</seealso>
    let _prefix_iri = Prefixed_Name(ceon_value, "") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/value/0.3/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/0.3/">http://w3id.org/CEON/ontology/value/0.3/</seealso>
    let ``_0.3/`` = Prefixed_Name(ceon_value, "0.3/") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/value/EconomicValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Use/Economics value represents how a thing (e.g., a product or service) match some goals or needs of an actor under some circumstances."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Economic Value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/EconomicValue">http://w3id.org/CEON/ontology/value/EconomicValue</seealso>
    let EconomicValue = Prefixed_Name(ceon_value, "EconomicValue") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/value/EnvironmentalValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Environmental value represents how a thing (e.g., a product or service) match some environmental goals or needs of an actor under some circumstances."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Environmental Value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/EnvironmentalValue">http://w3id.org/CEON/ontology/value/EnvironmentalValue</seealso>
    let EnvironmentalValue =
        Prefixed_Name(ceon_value, "EnvironmentalValue") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/value/ExchangeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Exchange value represents the worth of a product, resource, service in a exchange setting, i.e., a product, resource, service is traded or sold."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Exchange Value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/ExchangeValue">http://w3id.org/CEON/ontology/value/ExchangeValue</seealso>
    let ExchangeValue = Prefixed_Name(ceon_value, "ExchangeValue") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/value/SocialValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Social value represents how a thing (e.g., a product or service) match some social goals or needs of an actor under some circumstances."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Social Value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/SocialValue">http://w3id.org/CEON/ontology/value/SocialValue</seealso>
    let SocialValue = Prefixed_Name(ceon_value, "SocialValue") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/value/UseValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Use/Economics value represents how a thing (e.g., a product or service) match some goals or needs of an actor under some circumstances."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Use Value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/UseValue">http://w3id.org/CEON/ontology/value/UseValue</seealso>
    let UseValue = Prefixed_Name(ceon_value, "UseValue") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/value/Value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Gain(s) or benefit(s) from satisfying needs and expectations,	in relation to the use	and conservation of resources. EXAMPLE: Revenue, savings, productivity, sustainability, satisfaction, empowerment, engagement, experience, public health, trust. Value is relative to, and determined by the perception of, those interested party(ies) able to capture it. Value can be financial or non-financial, e.g. social, environmental, other gains or benefits. Value is dynamic over time."</para>
    /// labels<para>"Value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/Value">http://w3id.org/CEON/ontology/value/Value</seealso>
    let Value = Prefixed_Name(ceon_value, "Value") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/value/ValueConsumer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ceon:ontology/value/ValueParticipationRole</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/ValueConsumer">http://w3id.org/CEON/ontology/value/ValueConsumer</seealso>
    let ValueConsumer = Prefixed_Name(ceon_value, "ValueConsumer") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/value/ValueContributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>ceon:ontology/value/ValueParticipationRole</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/ValueContributor">http://w3id.org/CEON/ontology/value/ValueContributor</seealso>
    let ValueContributor = Prefixed_Name(ceon_value, "ValueContributor") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/value/ValueCreator</para>
    /// </summary>
    /// <remarks>
    ///   <para>ceon:ontology/value/ValueParticipationRole</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/ValueCreator">http://w3id.org/CEON/ontology/value/ValueCreator</seealso>
    let ValueCreator = Prefixed_Name(ceon_value, "ValueCreator") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/value/ValueDestroyer</para>
    /// </summary>
    /// <remarks>
    ///   <para>ceon:ontology/value/ValueParticipationRole</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/ValueDestroyer">http://w3id.org/CEON/ontology/value/ValueDestroyer</seealso>
    let ValueDestroyer = Prefixed_Name(ceon_value, "ValueDestroyer") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/value/ValueDistributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ceon:ontology/value/ValueParticipationRole</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/ValueDistributor">http://w3id.org/CEON/ontology/value/ValueDistributor</seealso>
    let ValueDistributor = Prefixed_Name(ceon_value, "ValueDistributor") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/value/ValueEvaluator</para>
    /// </summary>
    /// <remarks>
    ///   <para>ceon:ontology/value/ValueParticipationRole</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/ValueEvaluator">http://w3id.org/CEON/ontology/value/ValueEvaluator</seealso>
    let ValueEvaluator = Prefixed_Name(ceon_value, "ValueEvaluator") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/value/ValueParticipation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A participation that may create/destory/miss value."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Value Participation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/ValueParticipation">http://w3id.org/CEON/ontology/value/ValueParticipation</seealso>
    let ValueParticipation =
        Prefixed_Name(ceon_value, "ValueParticipation") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/value/ValueParticipationRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A role that a value participant can take."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Value Participation Role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/ValueParticipationRole">http://w3id.org/CEON/ontology/value/ValueParticipationRole</seealso>
    let ValueParticipationRole =
        Prefixed_Name(ceon_value, "ValueParticipationRole") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/value/ValuePerception</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Value perception of an actor determines specifc values."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Value Perception"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/ValuePerception">http://w3id.org/CEON/ontology/value/ValuePerception</seealso>
    let ValuePerception = Prefixed_Name(ceon_value, "ValuePerception") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/value/ValueProposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Proposed or intended value outcome of some process, action or collaboration."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Value Proposition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/ValueProposition">http://w3id.org/CEON/ontology/value/ValueProposition</seealso>
    let ValueProposition = Prefixed_Name(ceon_value, "ValueProposition") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/value/hasAimedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A value proposition has specific aimed values."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has aimed value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/hasAimedValue">http://w3id.org/CEON/ontology/value/hasAimedValue</seealso>
    let hasAimedValue = Prefixed_Name(ceon_value, "hasAimedValue") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/value/hasAssociatedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A value perception about creating/destoring/missing some value."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has associated value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/hasAssociatedValue">http://w3id.org/CEON/ontology/value/hasAssociatedValue</seealso>
    let hasAssociatedValue =
        Prefixed_Name(ceon_value, "hasAssociatedValue") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/value/hasPerception</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An actor perceive specific values, or a value proposition is about specific values."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has perception"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/hasPerception">http://w3id.org/CEON/ontology/value/hasPerception</seealso>
    let hasPerception = Prefixed_Name(ceon_value, "hasPerception") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/value/hasVPTargets</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A value proposition is proposed about specific actors, participations or resources."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has value proposition targets"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/hasVPTargets">http://w3id.org/CEON/ontology/value/hasVPTargets</seealso>
    let hasVPTargets = Prefixed_Name(ceon_value, "hasVPTargets") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/value/hasValuableResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A value participation has participating resources."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has valuable resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/hasValuableResource">http://w3id.org/CEON/ontology/value/hasValuableResource</seealso>
    let hasValuableResource =
        Prefixed_Name(ceon_value, "hasValuableResource") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/value/hasValueParticipantRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Holds the value of the role of the value participant in this value participation relation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has value participant role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/hasValueParticipantRole">http://w3id.org/CEON/ontology/value/hasValueParticipantRole</seealso>
    let hasValueParticipantRole =
        Prefixed_Name(ceon_value, "hasValueParticipantRole") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/value/onValueParticipation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A perception is on specific value participations."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"on value participation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/onValueParticipation">http://w3id.org/CEON/ontology/value/onValueParticipation</seealso>
    let onValueParticipation =
        Prefixed_Name(ceon_value, "onValueParticipation") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/value/proposedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A value proposition is proposed by specific actors."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"proposed by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/proposedBy">http://w3id.org/CEON/ontology/value/proposedBy</seealso>
    let proposedBy = Prefixed_Name(ceon_value, "proposedBy") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/value/targettingActor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A value proposition is about some actors."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"targetting actor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/targettingActor">http://w3id.org/CEON/ontology/value/targettingActor</seealso>
    let targettingActor = Prefixed_Name(ceon_value, "targettingActor") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/value/targettingResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A value proposition is about some resources."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"targetting resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/targettingResource">http://w3id.org/CEON/ontology/value/targettingResource</seealso>
    let targettingResource =
        Prefixed_Name(ceon_value, "targettingResource") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/value/targettingValueParticipation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A value proposition is about some participation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"targetting value participation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/value/targettingValueParticipation">http://w3id.org/CEON/ontology/value/targettingValueParticipation</seealso>
    let targettingValueParticipation =
        Prefixed_Name(ceon_value, "targettingValueParticipation") |> PrefixedName
