namespace http.www.w3id.org.def.caso.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module caso =
    let _namespace_iri = Namespace_Iri caso |> NamespaceIRI

    /// <summary>
    ///   <para>caso:hasClosedLowerBoundary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>has closed lower boundary - Relation from a State to its lower Boundary. The State is reached when the associated state value is equal or superior to the lower Boundary value.</para>
    /// labels<para>has closed lower boundary</para></remarks>
    /// <seealso href="http://www.w3id.org/def/caso#hasClosedLowerBoundary">http://www.w3id.org/def/caso#hasClosedLowerBoundary</seealso>
    let hasClosedLowerBoundary =
        Prefixed_Name(caso, "hasClosedLowerBoundary") |> PrefixedName

    /// <summary>
    ///   <para>caso:hasOpenLowerBoundary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>has open lower boundary - Relation from a State to its lower Boundary. The State is reached when the associated state value is superior to the lower Boundary value.</para>
    /// labels<para>has open lower boundary</para></remarks>
    /// <seealso href="http://www.w3id.org/def/caso#hasOpenLowerBoundary">http://www.w3id.org/def/caso#hasOpenLowerBoundary</seealso>
    let hasOpenLowerBoundary =
        Prefixed_Name(caso, "hasOpenLowerBoundary") |> PrefixedName

    /// <summary>
    ///   <para>caso:hasResultState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>has state result - Relation linking a Deduction and its result that is to say the State that is applied on the Property for a time.</para>
    /// labels<para>has result state</para></remarks>
    /// <seealso href="http://www.w3id.org/def/caso#hasResultState">http://www.w3id.org/def/caso#hasResultState</seealso>
    let hasResultState = Prefixed_Name(caso, "hasResultState") |> PrefixedName
    /// <summary>
    ///   <para>caso:hasValidTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>has valid time - The time that the result of a Deduction (state) applies to the ObservableProperty. Not necessarily the same as the sosa:PhenomenonTime or the sosa:ResultTime. May be an Interval or an Instant, or some other compound TemporalEntity.</para>
    /// labels<para>has valid time</para></remarks>
    /// <seealso href="http://www.w3id.org/def/caso#hasValidTime">http://www.w3id.org/def/caso#hasValidTime</seealso>
    let hasValidTime = Prefixed_Name(caso, "hasValidTime") |> PrefixedName
    /// <summary>
    ///   <para>caso:triggersFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>triggers function - Relation from an Actuation to a Function. The Actuation trigger the operation of the Function.</para>
    /// labels<para>triggers function</para></remarks>
    /// <seealso href="http://www.w3id.org/def/caso#triggersFunction">http://www.w3id.org/def/caso#triggersFunction</seealso>
    let triggersFunction = Prefixed_Name(caso, "triggersFunction") |> PrefixedName
    /// <summary>
    ///   <para>caso:lesserThanOrEqualTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>lesser than or equal to - Relation between States to define an order. The domain State is lesser than or equal to the range State.</para>
    /// labels<para>lesser than or equal to</para></remarks>
    /// <seealso href="http://www.w3id.org/def/caso#lesserThanOrEqualTo">http://www.w3id.org/def/caso#lesserThanOrEqualTo</seealso>
    let lesserThanOrEqualTo = Prefixed_Name(caso, "lesserThanOrEqualTo") |> PrefixedName
    /// <summary>
    ///   <para>caso:Boundary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Boundary - Limit of a State. The value of the limit could be a quantitative or a qualitative data. To store the value, the boundaryValue data property is used.</para>
    /// labels<para>Boundary</para></remarks>
    /// <seealso href="http://www.w3id.org/def/caso#Boundary">http://www.w3id.org/def/caso#Boundary</seealso>
    let Boundary = Prefixed_Name(caso, "Boundary") |> PrefixedName
    /// <summary>
    ///   <para>caso:Deduction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Deduction - Act of carrying out an (Observation) Procedure to estimate the State of a Property of a FeatureOfInterest. The Observation may be performed by an inference engine. A Deduction links to a State by the hasResultState property to describe what the result is; links to a TemporalEntity by the hasValidTime property to indicate when the result is valid and for how many time.</para>
    /// labels<para>Deduction</para></remarks>
    /// <seealso href="http://www.w3id.org/def/caso#Deduction">http://www.w3id.org/def/caso#Deduction</seealso>
    let Deduction = Prefixed_Name(caso, "Deduction") |> PrefixedName
    /// <summary>
    ///   <para>caso:Actuation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Actuation - Act of carrying out an (Actuation) Procedure to change the state of world  using an Actuator. This act is performed during the context exploitation phase of a context aware system. An Actuation links to an Actuator to describe what made the Actuation and how; links to an ActuatableProperty to describe the target that the Actuation change; links to a FeatureOfInterest to detail what that property was associated with; links to a Deduction by the wasInfluencedBy property when the act is performed based on the given Deduction; and links to the Function that is triggered by the Actuation by the triggersFunction property.</para>
    /// labels<para>Actuation</para></remarks>
    /// <seealso href="http://www.w3id.org/def/caso#Actuation">http://www.w3id.org/def/caso#Actuation</seealso>
    let Actuation = Prefixed_Name(caso, "Actuation") |> PrefixedName
    /// <summary>
    ///   <para>caso:Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Observation - Act of carrying out an (Observation) Procedure to estimate or calculate a value of a Property of a FeatureOfInterest. This act can be performed during the context acquisition or context processing phases of a context aware system. An Observation links to a Sensor to describe what made the Observation and how; links to an ObservableProperty to describe what the result is an estimate of; and links to a FeatureOfInterest to detail what that property was associated with. When the act is made during the context processing phase the entry values of the procedure should be linked to the observation by the wasDerivedFrom property.</para>
    /// labels<para>Observation</para></remarks>
    /// <seealso href="http://www.w3id.org/def/caso#Observation">http://www.w3id.org/def/caso#Observation</seealso>
    let Observation = Prefixed_Name(caso, "Observation") |> PrefixedName
    /// <summary>
    ///   <para>caso:State</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>State - A qualitative value of a Property, summarizing a set of information about that Property. A State links to its Property by the isStateOf property. To delimit the State of a Property, some Boundary may be defined.</para>
    /// labels<para>State</para></remarks>
    /// <seealso href="http://www.w3id.org/def/caso#State">http://www.w3id.org/def/caso#State</seealso>
    let State = Prefixed_Name(caso, "State") |> PrefixedName
    /// <summary>
    ///   <para>caso:Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Property - A quality of an entity. An aspect of an entity that is intrinsic to and cannot exist without the entity.The possible quality values should be expressed by State. A Property is linked to its possible States using the hasState property.</para>
    /// labels<para>Property</para></remarks>
    /// <seealso href="http://www.w3id.org/def/caso#Property">http://www.w3id.org/def/caso#Property</seealso>
    let Property = Prefixed_Name(caso, "Property") |> PrefixedName
    /// <summary>
    ///   <para>caso:boundaryValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>boundary value - Numeric value of a Boundary</para>
    /// labels<para>boundary value</para></remarks>
    /// <seealso href="http://www.w3id.org/def/caso#boundaryValue">http://www.w3id.org/def/caso#boundaryValue</seealso>
    let boundaryValue = Prefixed_Name(caso, "boundaryValue") |> PrefixedName
    /// <summary>
    ///   <para>caso:greaterThan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>greater than - Relation between States to define an order. The domain State is greater than the range State.</para>
    /// labels<para>greater than</para></remarks>
    /// <seealso href="http://www.w3id.org/def/caso#greaterThan">http://www.w3id.org/def/caso#greaterThan</seealso>
    let greaterThan = Prefixed_Name(caso, "greaterThan") |> PrefixedName

    /// <summary>
    ///   <para>caso:greaterThanOrEqualTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>greater than or equal to - Relation between States to define an order. The domain State is greater than or equal to the range State.</para>
    /// labels<para>greater than or equal to</para></remarks>
    /// <seealso href="http://www.w3id.org/def/caso#greaterThanOrEqualTo">http://www.w3id.org/def/caso#greaterThanOrEqualTo</seealso>
    let greaterThanOrEqualTo =
        Prefixed_Name(caso, "greaterThanOrEqualTo") |> PrefixedName

    /// <summary>
    ///   <para>caso:hasState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>has state - Relation from a Property to one of the possible States of that Property</para>
    /// labels<para>has state</para></remarks>
    /// <seealso href="http://www.w3id.org/def/caso#hasState">http://www.w3id.org/def/caso#hasState</seealso>
    let hasState = Prefixed_Name(caso, "hasState") |> PrefixedName
    /// <summary>
    ///   <para>caso:lesserThan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>less than - Relation between States to define an order. The domain State is lesser than the range State.</para>
    /// labels<para>lesser than</para></remarks>
    /// <seealso href="http://www.w3id.org/def/caso#lesserThan">http://www.w3id.org/def/caso#lesserThan</seealso>
    let lesserThan = Prefixed_Name(caso, "lesserThan") |> PrefixedName

    /// <summary>
    ///   <para>caso:hasClosedUpperBoundary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>has closed upper boundary - Relation from a State to its upper Boundary. The State is reached when the associated state value is equal or inferior  to the upper Boundary value.</para>
    /// labels<para>has closed upper boundary</para></remarks>
    /// <seealso href="http://www.w3id.org/def/caso#hasClosedUpperBoundary">http://www.w3id.org/def/caso#hasClosedUpperBoundary</seealso>
    let hasClosedUpperBoundary =
        Prefixed_Name(caso, "hasClosedUpperBoundary") |> PrefixedName

    /// <summary>
    ///   <para>caso:hasOpenUpperBoundary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>has open upper boundary - Relation from a State to its upper Boundary. The State is reached when the associated state value is inferior to the upper Boundary value.</para>
    /// labels<para>has open upper boundary</para></remarks>
    /// <seealso href="http://www.w3id.org/def/caso#hasOpenUpperBoundary">http://www.w3id.org/def/caso#hasOpenUpperBoundary</seealso>
    let hasOpenUpperBoundary =
        Prefixed_Name(caso, "hasOpenUpperBoundary") |> PrefixedName
