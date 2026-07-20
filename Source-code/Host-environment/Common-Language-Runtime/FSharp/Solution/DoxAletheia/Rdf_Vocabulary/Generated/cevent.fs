namespace https.w3id.org.arco.ontology.cultural_event.slash

open DoxAletheia

module cevent =
    let _namespace_name = "https://w3id.org/arco/ontology/cultural-event/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// This class represents an exhibition, as a particular type of cultural event.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/Exhibition"></see></summary>
    let Exhibition = _prefix "Exhibition"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/cultural-event/Hour"></see>
    /// </summary>
    let Hour = _prefix "Hour"
    /// <summary>
    /// This class represents the unit of measurement associated to the maximum time period that elapses between one of the member events of a recurrent event, as a collection of events, and the next one.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/TimePeriodMeasurementUnit"></see></summary>
    let TimePeriodMeasurementUnit = _prefix "TimePeriodMeasurementUnit"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/cultural-event/Minute"></see>
    /// </summary>
    let Minute = _prefix "Minute"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/cultural-event/Month"></see>
    /// </summary>
    let Month = _prefix "Month"
    /// <summary>
    /// This class represents a recurrent event, that is an event as a collection of sequential events and identified by at least one unifying factor (e.g.: topic, place).
    /// <see href="https://w3id.org/arco/ontology/cultural-event/RecurrentEvent"></see></summary>
    let RecurrentEvent = _prefix "RecurrentEvent"
    /// <summary>
    /// This class represents the time period that elapses between one of the member events of a recurrent event, as a collection of events, and the next one.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/RecurrentTimePeriod"></see></summary>
    let RecurrentTimePeriod = _prefix "RecurrentTimePeriod"
    /// <summary>
    /// This property relates a recurrent event to the time period that elapses between one of its member events and the next one.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/hasRecurrentTimePeriod"></see></summary>
    let hasRecurrentTimePeriod = _prefix "hasRecurrentTimePeriod"
    /// <summary>
    /// This property relates a recurrent event, as a collection of events, to one of its member events.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/hasMemberEvent"></see></summary>
    let hasMemberEvent = _prefix "hasMemberEvent"
    /// <summary>
    /// This class represents a unifying factor, that is a factor that represents an invariant common to all the events that are members of the recurrent event.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/UnifyingFactor"></see></summary>
    let UnifyingFactor = _prefix "UnifyingFactor"
    /// <summary>
    /// This property relates a recurrent event to a unifying factor.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/hasUnifyingFactor"></see></summary>
    let hasUnifyingFactor = _prefix "hasUnifyingFactor"
    /// <summary>
    /// This property relates an event that is member of a recurrent event, as a collection, to one of the next events.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/hasNextEvent"></see></summary>
    let hasNextEvent = _prefix "hasNextEvent"
    /// <summary>
    /// This property relates an event that is member of a recurrent event, as a collection, to one of the previous events.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/hasPreviousEvent"></see></summary>
    let hasPreviousEvent = _prefix "hasPreviousEvent"
    /// <summary>
    /// This property represents the value associated to the time period that elapses between one of the member events of a recurrent event, as a collection of events, and the next one.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/timePeriodValue"></see></summary>
    let timePeriodValue = _prefix "timePeriodValue"
    /// <summary>
    /// This property relates the maximum time period that elapses between one of the member events of a recurrent event, as a collection of events, and the next one, to the unit of measurement associated to it.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/hasTimePeriodMeasurementUnit"></see></summary>
    let hasTimePeriodMeasurementUnit = _prefix "hasTimePeriodMeasurementUnit"
    /// <summary>
    /// This property relates the maximum time period that elapses between one of the member events of a recurrent event and the next one.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/isRecurrentTimePeriodOf"></see></summary>
    let isRecurrentTimePeriodOf = _prefix "isRecurrentTimePeriodOf"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/cultural-event/Second"></see>
    /// </summary>
    let Second = _prefix "Second"
    /// <summary>
    /// The class that represents a time period.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/TimePeriod"></see></summary>
    let TimePeriod = _prefix "TimePeriod"
    /// <summary>
    /// This is the inverse property of "has time period measurement unit".
    /// <see href="https://w3id.org/arco/ontology/cultural-event/isTimePeriodMeasurementUnitOf"></see></summary>
    let isTimePeriodMeasurementUnitOf = _prefix "isTimePeriodMeasurementUnitOf"
    /// <summary>
    /// This property relates a unifying factor to a recurrent event.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/isUnifyingFactorOf"></see></summary>
    let isUnifyingFactorOf = _prefix "isUnifyingFactorOf"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/cultural-event/Week"></see>
    /// </summary>
    let Week = _prefix "Week"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/cultural-event/Year"></see>
    /// </summary>
    let Year = _prefix "Year"
    /// <summary>
    /// This property represents the time and location of a cultural event, when they are recorded together.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/eventTimeLocation"></see></summary>
    let eventTimeLocation = _prefix "eventTimeLocation"
    /// <summary>
    /// This class relates a cultural event to an agent playing a role related to that cultural event.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/hasAgentRelatedToCulturalEvent"></see></summary>
    let hasAgentRelatedToCulturalEvent = _prefix "hasAgentRelatedToCulturalEvent"
    /// <summary>
    /// This is the inverse property of "has agent related to cultural event".
    /// <see href="https://w3id.org/arco/ontology/cultural-event/isAgentRelatedToCulturalEventOf"></see></summary>
    let isAgentRelatedToCulturalEventOf = _prefix "isAgentRelatedToCulturalEventOf"
    /// <summary>
    /// This property relates a cultural evento to the agency or person that is the organiser of that event.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/hasEventOrganiser"></see></summary>
    let hasEventOrganiser = _prefix "hasEventOrganiser"
    /// <summary>
    /// This is the inverse property of "has event organiser".
    /// <see href="https://w3id.org/arco/ontology/cultural-event/isEventOrganiserOf"></see></summary>
    let isEventOrganiserOf = _prefix "isEventOrganiserOf"
    /// <summary>
    /// This property relates an event that is member of a recurrent event, as a collection, to the immediate next event.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/hasImmediateNextEvent"></see></summary>
    let hasImmediateNextEvent = _prefix "hasImmediateNextEvent"
    /// <summary>
    /// This property relates an event that is member of a recurrent event, as a collection, to the immediate previous event.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/hasImmediatePreviousEvent"></see></summary>
    let hasImmediatePreviousEvent = _prefix "hasImmediatePreviousEvent"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/cultural-event/isEventMemberOf"></see>
    /// </summary>
    let isEventMemberOf = _prefix "isEventMemberOf"
    /// <summary>
    /// This property relates an event, member of a recurrent event as a collection of events, to the time period that is between that event and the next one.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/hasTimePeriodBeforeNextEvent"></see></summary>
    let hasTimePeriodBeforeNextEvent = _prefix "hasTimePeriodBeforeNextEvent"
    /// <summary>
    /// This is the inverse property of "has time period before next event".
    /// <see href="https://w3id.org/arco/ontology/cultural-event/isTimePeriodBeforeNextEventOf"></see></summary>
    let isTimePeriodBeforeNextEventOf = _prefix "isTimePeriodBeforeNextEventOf"
