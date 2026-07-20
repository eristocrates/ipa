namespace http.www.w3id.org.def.caso.hash

open DoxAletheia

module caso =
    let _namespace_name = "http://www.w3id.org/def/caso#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// has closed lower boundary - Relation from a State to its lower Boundary. The State is reached when the associated state value is equal or superior to the lower Boundary value.
    /// <see href="http://www.w3id.org/def/caso#hasClosedLowerBoundary"></see></summary>
    let hasClosedLowerBoundary = _prefix "hasClosedLowerBoundary"
    /// <summary>
    /// has closed upper boundary - Relation from a State to its upper Boundary. The State is reached when the associated state value is equal or inferior  to the upper Boundary value.
    /// <see href="http://www.w3id.org/def/caso#hasClosedUpperBoundary"></see></summary>
    let hasClosedUpperBoundary = _prefix "hasClosedUpperBoundary"
    /// <summary>
    /// has open lower boundary - Relation from a State to its lower Boundary. The State is reached when the associated state value is superior to the lower Boundary value.
    /// <see href="http://www.w3id.org/def/caso#hasOpenLowerBoundary"></see></summary>
    let hasOpenLowerBoundary = _prefix "hasOpenLowerBoundary"
    /// <summary>
    /// has open upper boundary - Relation from a State to its upper Boundary. The State is reached when the associated state value is inferior to the upper Boundary value.
    /// <see href="http://www.w3id.org/def/caso#hasOpenUpperBoundary"></see></summary>
    let hasOpenUpperBoundary = _prefix "hasOpenUpperBoundary"
    /// <summary>
    /// Actuation - Act of carrying out an (Actuation) Procedure to change the state of world  using an Actuator. This act is performed during the context exploitation phase of a context aware system. An Actuation links to an Actuator to describe what made the Actuation and how; links to an ActuatableProperty to describe the target that the Actuation change; links to a FeatureOfInterest to detail what that property was associated with; links to a Deduction by the wasInfluencedBy property when the act is performed based on the given Deduction; and links to the Function that is triggered by the Actuation by the triggersFunction property.
    /// <see href="http://www.w3id.org/def/caso#Actuation"></see></summary>
    let Actuation = _prefix "Actuation"
    /// <summary>
    /// Boundary - Limit of a State. The value of the limit could be a quantitative or a qualitative data. To store the value, the boundaryValue data property is used.
    /// <see href="http://www.w3id.org/def/caso#Boundary"></see></summary>
    let Boundary = _prefix "Boundary"
    /// <summary>
    /// Deduction - Act of carrying out an (Observation) Procedure to estimate the State of a Property of a FeatureOfInterest. The Observation may be performed by an inference engine. A Deduction links to a State by the hasResultState property to describe what the result is; links to a TemporalEntity by the hasValidTime property to indicate when the result is valid and for how many time.
    /// <see href="http://www.w3id.org/def/caso#Deduction"></see></summary>
    let Deduction = _prefix "Deduction"
    /// <summary>
    /// Observation - Act of carrying out an (Observation) Procedure to estimate or calculate a value of a Property of a FeatureOfInterest. This act can be performed during the context acquisition or context processing phases of a context aware system. An Observation links to a Sensor to describe what made the Observation and how; links to an ObservableProperty to describe what the result is an estimate of; and links to a FeatureOfInterest to detail what that property was associated with. When the act is made during the context processing phase the entry values of the procedure should be linked to the observation by the wasDerivedFrom property.
    /// <see href="http://www.w3id.org/def/caso#Observation"></see></summary>
    let Observation = _prefix "Observation"
    /// <summary>
    /// Property - A quality of an entity. An aspect of an entity that is intrinsic to and cannot exist without the entity.The possible quality values should be expressed by State. A Property is linked to its possible States using the hasState property.
    /// <see href="http://www.w3id.org/def/caso#Property"></see></summary>
    let Property = _prefix "Property"
    /// <summary>
    /// State - A qualitative value of a Property, summarizing a set of information about that Property. A State links to its Property by the isStateOf property. To delimit the State of a Property, some Boundary may be defined.
    /// <see href="http://www.w3id.org/def/caso#State"></see></summary>
    let State = _prefix "State"
    /// <summary>
    /// boundary value - Numeric value of a Boundary
    /// <see href="http://www.w3id.org/def/caso#boundaryValue"></see></summary>
    let boundaryValue = _prefix "boundaryValue"
    /// <summary>
    /// greater than - Relation between States to define an order. The domain State is greater than the range State.
    /// <see href="http://www.w3id.org/def/caso#greaterThan"></see></summary>
    let greaterThan = _prefix "greaterThan"
    /// <summary>
    /// greater than or equal to - Relation between States to define an order. The domain State is greater than or equal to the range State.
    /// <see href="http://www.w3id.org/def/caso#greaterThanOrEqualTo"></see></summary>
    let greaterThanOrEqualTo = _prefix "greaterThanOrEqualTo"
    /// <summary>
    /// has state result - Relation linking a Deduction and its result that is to say the State that is applied on the Property for a time.
    /// <see href="http://www.w3id.org/def/caso#hasResultState"></see></summary>
    let hasResultState = _prefix "hasResultState"
    /// <summary>
    /// has state - Relation from a Property to one of the possible States of that Property
    /// <see href="http://www.w3id.org/def/caso#hasState"></see></summary>
    let hasState = _prefix "hasState"
    /// <summary>
    /// has valid time - The time that the result of a Deduction (state) applies to the ObservableProperty. Not necessarily the same as the sosa:PhenomenonTime or the sosa:ResultTime. May be an Interval or an Instant, or some other compound TemporalEntity.
    /// <see href="http://www.w3id.org/def/caso#hasValidTime"></see></summary>
    let hasValidTime = _prefix "hasValidTime"
    /// <summary>
    /// less than - Relation between States to define an order. The domain State is lesser than the range State.
    /// <see href="http://www.w3id.org/def/caso#lesserThan"></see></summary>
    let lesserThan = _prefix "lesserThan"
    /// <summary>
    /// lesser than or equal to - Relation between States to define an order. The domain State is lesser than or equal to the range State.
    /// <see href="http://www.w3id.org/def/caso#lesserThanOrEqualTo"></see></summary>
    let lesserThanOrEqualTo = _prefix "lesserThanOrEqualTo"
    /// <summary>
    /// triggers function - Relation from an Actuation to a Function. The Actuation trigger the operation of the Function.
    /// <see href="http://www.w3id.org/def/caso#triggersFunction"></see></summary>
    let triggersFunction = _prefix "triggersFunction"
