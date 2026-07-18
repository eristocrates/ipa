namespace https.w3id.org.arco.ontology.cultural_event.slash

open DoxAletheia.Rdf_Vocabulary

module cevent =
    let _namespace_name = "https://w3id.org/arco/ontology/cultural-event/"
    /// <summary>
    /// This class represents an exhibition, as a particular type of cultural event.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/Exhibition"></see></summary>
    let Exhibition = Namespaced_IRI.parse _namespace_name "Exhibition" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/cultural-event/Hour"></see>
    /// </summary>
    let Hour = Namespaced_IRI.parse _namespace_name "Hour" |> NamespacedName

    /// <summary>
    /// This class represents the unit of measurement associated to the maximum time period that elapses between one of the member events of a recurrent event, as a collection of events, and the next one.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/TimePeriodMeasurementUnit"></see></summary>
    let TimePeriodMeasurementUnit =
        Namespaced_IRI.parse _namespace_name "TimePeriodMeasurementUnit" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/cultural-event/Minute"></see>
    /// </summary>
    let Minute = Namespaced_IRI.parse _namespace_name "Minute" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/cultural-event/Month"></see>
    /// </summary>
    let Month = Namespaced_IRI.parse _namespace_name "Month" |> NamespacedName

    /// <summary>
    /// This class represents a recurrent event, that is an event as a collection of sequential events and identified by at least one unifying factor (e.g.: topic, place).
    /// <see href="https://w3id.org/arco/ontology/cultural-event/RecurrentEvent"></see></summary>
    let RecurrentEvent =
        Namespaced_IRI.parse _namespace_name "RecurrentEvent" |> NamespacedName

    /// <summary>
    /// This class represents the time period that elapses between one of the member events of a recurrent event, as a collection of events, and the next one.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/RecurrentTimePeriod"></see></summary>
    let RecurrentTimePeriod =
        Namespaced_IRI.parse _namespace_name "RecurrentTimePeriod" |> NamespacedName

    /// <summary>
    /// This property relates a recurrent event to the time period that elapses between one of its member events and the next one.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/hasRecurrentTimePeriod"></see></summary>
    let hasRecurrentTimePeriod =
        Namespaced_IRI.parse _namespace_name "hasRecurrentTimePeriod" |> NamespacedName

    /// <summary>
    /// This property relates a recurrent event, as a collection of events, to one of its member events.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/hasMemberEvent"></see></summary>
    let hasMemberEvent =
        Namespaced_IRI.parse _namespace_name "hasMemberEvent" |> NamespacedName

    /// <summary>
    /// This class represents a unifying factor, that is a factor that represents an invariant common to all the events that are members of the recurrent event.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/UnifyingFactor"></see></summary>
    let UnifyingFactor =
        Namespaced_IRI.parse _namespace_name "UnifyingFactor" |> NamespacedName

    /// <summary>
    /// This property relates a recurrent event to a unifying factor.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/hasUnifyingFactor"></see></summary>
    let hasUnifyingFactor =
        Namespaced_IRI.parse _namespace_name "hasUnifyingFactor" |> NamespacedName

    /// <summary>
    /// This property relates an event that is member of a recurrent event, as a collection, to one of the next events.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/hasNextEvent"></see></summary>
    let hasNextEvent =
        Namespaced_IRI.parse _namespace_name "hasNextEvent" |> NamespacedName

    /// <summary>
    /// This property relates an event that is member of a recurrent event, as a collection, to one of the previous events.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/hasPreviousEvent"></see></summary>
    let hasPreviousEvent =
        Namespaced_IRI.parse _namespace_name "hasPreviousEvent" |> NamespacedName

    /// <summary>
    /// This property represents the value associated to the time period that elapses between one of the member events of a recurrent event, as a collection of events, and the next one.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/timePeriodValue"></see></summary>
    let timePeriodValue =
        Namespaced_IRI.parse _namespace_name "timePeriodValue" |> NamespacedName

    /// <summary>
    /// This property relates the maximum time period that elapses between one of the member events of a recurrent event, as a collection of events, and the next one, to the unit of measurement associated to it.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/hasTimePeriodMeasurementUnit"></see></summary>
    let hasTimePeriodMeasurementUnit =
        Namespaced_IRI.parse _namespace_name "hasTimePeriodMeasurementUnit" |> NamespacedName

    /// <summary>
    /// This property relates the maximum time period that elapses between one of the member events of a recurrent event and the next one.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/isRecurrentTimePeriodOf"></see></summary>
    let isRecurrentTimePeriodOf =
        Namespaced_IRI.parse _namespace_name "isRecurrentTimePeriodOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/cultural-event/Second"></see>
    /// </summary>
    let Second = Namespaced_IRI.parse _namespace_name "Second" |> NamespacedName
    /// <summary>
    /// The class that represents a time period.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/TimePeriod"></see></summary>
    let TimePeriod = Namespaced_IRI.parse _namespace_name "TimePeriod" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has time period measurement unit".
    /// <see href="https://w3id.org/arco/ontology/cultural-event/isTimePeriodMeasurementUnitOf"></see></summary>
    let isTimePeriodMeasurementUnitOf =
        Namespaced_IRI.parse _namespace_name "isTimePeriodMeasurementUnitOf" |> NamespacedName

    /// <summary>
    /// This property relates a unifying factor to a recurrent event.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/isUnifyingFactorOf"></see></summary>
    let isUnifyingFactorOf =
        Namespaced_IRI.parse _namespace_name "isUnifyingFactorOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/cultural-event/Week"></see>
    /// </summary>
    let Week = Namespaced_IRI.parse _namespace_name "Week" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/cultural-event/Year"></see>
    /// </summary>
    let Year = Namespaced_IRI.parse _namespace_name "Year" |> NamespacedName

    /// <summary>
    /// This property represents the time and location of a cultural event, when they are recorded together.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/eventTimeLocation"></see></summary>
    let eventTimeLocation =
        Namespaced_IRI.parse _namespace_name "eventTimeLocation" |> NamespacedName

    /// <summary>
    /// This class relates a cultural event to an agent playing a role related to that cultural event.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/hasAgentRelatedToCulturalEvent"></see></summary>
    let hasAgentRelatedToCulturalEvent =
        Namespaced_IRI.parse _namespace_name "hasAgentRelatedToCulturalEvent" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has agent related to cultural event".
    /// <see href="https://w3id.org/arco/ontology/cultural-event/isAgentRelatedToCulturalEventOf"></see></summary>
    let isAgentRelatedToCulturalEventOf =
        Namespaced_IRI.parse _namespace_name "isAgentRelatedToCulturalEventOf" |> NamespacedName

    /// <summary>
    /// This property relates a cultural evento to the agency or person that is the organiser of that event.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/hasEventOrganiser"></see></summary>
    let hasEventOrganiser =
        Namespaced_IRI.parse _namespace_name "hasEventOrganiser" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has event organiser".
    /// <see href="https://w3id.org/arco/ontology/cultural-event/isEventOrganiserOf"></see></summary>
    let isEventOrganiserOf =
        Namespaced_IRI.parse _namespace_name "isEventOrganiserOf" |> NamespacedName

    /// <summary>
    /// This property relates an event that is member of a recurrent event, as a collection, to the immediate next event.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/hasImmediateNextEvent"></see></summary>
    let hasImmediateNextEvent =
        Namespaced_IRI.parse _namespace_name "hasImmediateNextEvent" |> NamespacedName

    /// <summary>
    /// This property relates an event that is member of a recurrent event, as a collection, to the immediate previous event.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/hasImmediatePreviousEvent"></see></summary>
    let hasImmediatePreviousEvent =
        Namespaced_IRI.parse _namespace_name "hasImmediatePreviousEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/cultural-event/isEventMemberOf"></see>
    /// </summary>
    let isEventMemberOf =
        Namespaced_IRI.parse _namespace_name "isEventMemberOf" |> NamespacedName

    /// <summary>
    /// This property relates an event, member of a recurrent event as a collection of events, to the time period that is between that event and the next one.
    /// <see href="https://w3id.org/arco/ontology/cultural-event/hasTimePeriodBeforeNextEvent"></see></summary>
    let hasTimePeriodBeforeNextEvent =
        Namespaced_IRI.parse _namespace_name "hasTimePeriodBeforeNextEvent" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has time period before next event".
    /// <see href="https://w3id.org/arco/ontology/cultural-event/isTimePeriodBeforeNextEventOf"></see></summary>
    let isTimePeriodBeforeNextEventOf =
        Namespaced_IRI.parse _namespace_name "isTimePeriodBeforeNextEventOf" |> NamespacedName
