#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module caso =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3id.org/def/caso#" "caso"
    /// <summary>
    ///   <para>rdfs:label : Actuation</para>
    ///   <para>rdfs:comment : Actuation - Act of carrying out an (Actuation) Procedure to change the state of world  using an Actuator. This act is performed during the context exploitation phase of a context aware system. An Actuation links to an Actuator to describe what made the Actuation and how; links to an ActuatableProperty to describe the target that the Actuation change; links to a FeatureOfInterest to detail what that property was associated with; links to a Deduction by the wasInfluencedBy property when the act is performed based on the given Deduction; and links to the Function that is triggered by the Actuation by the triggersFunction property.</para>
    ///   <a href="http://www.w3id.org/def/caso#Actuation">caso:Actuation</a>
    /// </summary>
    let Actuation = _prefixId.prefix "Actuation"
    /// <summary>
    ///   <para>rdfs:label : Boundary</para>
    ///   <para>rdfs:comment : Boundary - Limit of a State. The value of the limit could be a quantitative or a qualitative data. To store the value, the boundaryValue data property is used.</para>
    ///   <a href="http://www.w3id.org/def/caso#Boundary">caso:Boundary</a>
    /// </summary>
    let Boundary = _prefixId.prefix "Boundary"
    /// <summary>
    ///   <para>rdfs:label : Deduction</para>
    ///   <para>rdfs:comment : Deduction - Act of carrying out an (Observation) Procedure to estimate the State of a Property of a FeatureOfInterest. The Observation may be performed by an inference engine. A Deduction links to a State by the hasResultState property to describe what the result is; links to a TemporalEntity by the hasValidTime property to indicate when the result is valid and for how many time.</para>
    ///   <a href="http://www.w3id.org/def/caso#Deduction">caso:Deduction</a>
    /// </summary>
    let Deduction = _prefixId.prefix "Deduction"
    /// <summary>
    ///   <para>rdfs:label : Observation</para>
    ///   <para>rdfs:comment : Observation - Act of carrying out an (Observation) Procedure to estimate or calculate a value of a Property of a FeatureOfInterest. This act can be performed during the context acquisition or context processing phases of a context aware system. An Observation links to a Sensor to describe what made the Observation and how; links to an ObservableProperty to describe what the result is an estimate of; and links to a FeatureOfInterest to detail what that property was associated with. When the act is made during the context processing phase the entry values of the procedure should be linked to the observation by the wasDerivedFrom property.</para>
    ///   <a href="http://www.w3id.org/def/caso#Observation">caso:Observation</a>
    /// </summary>
    let Observation = _prefixId.prefix "Observation"
    /// <summary>
    ///   <para>rdfs:label : Property</para>
    ///   <para>rdfs:comment : Property - A quality of an entity. An aspect of an entity that is intrinsic to and cannot exist without the entity.The possible quality values should be expressed by State. A Property is linked to its possible States using the hasState property.</para>
    ///   <a href="http://www.w3id.org/def/caso#Property">caso:Property</a>
    /// </summary>
    let Property = _prefixId.prefix "Property"
    /// <summary>
    ///   <para>rdfs:label : State</para>
    ///   <para>rdfs:comment : State - A qualitative value of a Property, summarizing a set of information about that Property. A State links to its Property by the isStateOf property. To delimit the State of a Property, some Boundary may be defined.</para>
    ///   <a href="http://www.w3id.org/def/caso#State">caso:State</a>
    /// </summary>
    let State = _prefixId.prefix "State"
    /// <summary>
    ///   <para>rdfs:label : boundary value</para>
    ///   <para>rdfs:comment : boundary value - Numeric value of a Boundary</para>
    ///   <a href="http://www.w3id.org/def/caso#boundaryValue">caso:boundaryValue</a>
    /// </summary>
    let boundaryValue = _prefixId.prefix "boundaryValue"
    /// <summary>
    ///   <para>rdfs:label : greater than</para>
    ///   <para>rdfs:comment : greater than - Relation between States to define an order. The domain State is greater than the range State.</para>
    ///   <a href="http://www.w3id.org/def/caso#greaterThan">caso:greaterThan</a>
    /// </summary>
    let greaterThan = _prefixId.prefix "greaterThan"
    /// <summary>
    ///   <para>rdfs:label : greater than or equal to</para>
    ///   <para>rdfs:comment : greater than or equal to - Relation between States to define an order. The domain State is greater than or equal to the range State.</para>
    ///   <a href="http://www.w3id.org/def/caso#greaterThanOrEqualTo">caso:greaterThanOrEqualTo</a>
    /// </summary>
    let greaterThanOrEqualTo = _prefixId.prefix "greaterThanOrEqualTo"
    /// <summary>
    ///   <para>rdfs:label : has closed lower boundary</para>
    ///   <para>rdfs:comment : has closed lower boundary - Relation from a State to its lower Boundary. The State is reached when the associated state value is equal or superior to the lower Boundary value.</para>
    ///   <a href="http://www.w3id.org/def/caso#hasClosedLowerBoundary">caso:hasClosedLowerBoundary</a>
    /// </summary>
    let hasClosedLowerBoundary = _prefixId.prefix "hasClosedLowerBoundary"
    /// <summary>
    ///   <para>rdfs:label : has closed upper boundary</para>
    ///   <para>rdfs:comment : has closed upper boundary - Relation from a State to its upper Boundary. The State is reached when the associated state value is equal or inferior  to the upper Boundary value.</para>
    ///   <a href="http://www.w3id.org/def/caso#hasClosedUpperBoundary">caso:hasClosedUpperBoundary</a>
    /// </summary>
    let hasClosedUpperBoundary = _prefixId.prefix "hasClosedUpperBoundary"
    /// <summary>
    ///   <para>rdfs:label : has open lower boundary</para>
    ///   <para>rdfs:comment : has open lower boundary - Relation from a State to its lower Boundary. The State is reached when the associated state value is superior to the lower Boundary value.</para>
    ///   <a href="http://www.w3id.org/def/caso#hasOpenLowerBoundary">caso:hasOpenLowerBoundary</a>
    /// </summary>
    let hasOpenLowerBoundary = _prefixId.prefix "hasOpenLowerBoundary"
    /// <summary>
    ///   <para>rdfs:label : has open upper boundary</para>
    ///   <para>rdfs:comment : has open upper boundary - Relation from a State to its upper Boundary. The State is reached when the associated state value is inferior to the upper Boundary value.</para>
    ///   <a href="http://www.w3id.org/def/caso#hasOpenUpperBoundary">caso:hasOpenUpperBoundary</a>
    /// </summary>
    let hasOpenUpperBoundary = _prefixId.prefix "hasOpenUpperBoundary"
    /// <summary>
    ///   <para>rdfs:label : has result state</para>
    ///   <para>rdfs:comment : has state result - Relation linking a Deduction and its result that is to say the State that is applied on the Property for a time.</para>
    ///   <a href="http://www.w3id.org/def/caso#hasResultState">caso:hasResultState</a>
    /// </summary>
    let hasResultState = _prefixId.prefix "hasResultState"
    /// <summary>
    ///   <para>rdfs:label : has state</para>
    ///   <para>rdfs:comment : has state - Relation from a Property to one of the possible States of that Property</para>
    ///   <a href="http://www.w3id.org/def/caso#hasState">caso:hasState</a>
    /// </summary>
    let hasState = _prefixId.prefix "hasState"
    /// <summary>
    ///   <para>rdfs:label : has valid time</para>
    ///   <para>rdfs:comment : has valid time - The time that the result of a Deduction (state) applies to the ObservableProperty. Not necessarily the same as the sosa:PhenomenonTime or the sosa:ResultTime. May be an Interval or an Instant, or some other compound TemporalEntity.</para>
    ///   <a href="http://www.w3id.org/def/caso#hasValidTime">caso:hasValidTime</a>
    /// </summary>
    let hasValidTime = _prefixId.prefix "hasValidTime"
    /// <summary>
    ///   <para>rdfs:label : lesser than</para>
    ///   <para>rdfs:comment : less than - Relation between States to define an order. The domain State is lesser than the range State.</para>
    ///   <a href="http://www.w3id.org/def/caso#lesserThan">caso:lesserThan</a>
    /// </summary>
    let lesserThan = _prefixId.prefix "lesserThan"
    /// <summary>
    ///   <para>rdfs:label : lesser than or equal to</para>
    ///   <para>rdfs:comment : lesser than or equal to - Relation between States to define an order. The domain State is lesser than or equal to the range State.</para>
    ///   <a href="http://www.w3id.org/def/caso#lesserThanOrEqualTo">caso:lesserThanOrEqualTo</a>
    /// </summary>
    let lesserThanOrEqualTo = _prefixId.prefix "lesserThanOrEqualTo"
    /// <summary>
    ///   <para>rdfs:label : triggers function</para>
    ///   <para>rdfs:comment : triggers function - Relation from an Actuation to a Function. The Actuation trigger the operation of the Function.</para>
    ///   <a href="http://www.w3id.org/def/caso#triggersFunction">caso:triggersFunction</a>
    /// </summary>
    let triggersFunction = _prefixId.prefix "triggersFunction"
