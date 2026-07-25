namespace https.w3id.org.arco.ontology.cultural_event.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cevent =
    let _namespace_iri = Namespace_Iri cevent |> NamespaceIRI

    /// <summary>
    ///   <para>cevent:isTimePeriodMeasurementUnitOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa è la proprietà inversa a "ha unità di misura di periodo di tempo".</para>
    ///   <para>This is the inverse property of "has time period measurement unit".</para>
    /// labels<para>è unità di misura di periodo di tempo</para><para>is time period measurement unit of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/cultural-event/isTimePeriodMeasurementUnitOf">https://w3id.org/arco/ontology/cultural-event/isTimePeriodMeasurementUnitOf</seealso>
    let isTimePeriodMeasurementUnitOf =
        Prefixed_Name(cevent, "isTimePeriodMeasurementUnitOf") |> PrefixedName

    /// <summary>
    ///   <para>cevent:Week</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/cultural-event/TimePeriodMeasurementUnit</para>
    ///
    /// labels<para>Settimana</para><para>Week</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/cultural-event/Week">https://w3id.org/arco/ontology/cultural-event/Week</seealso>
    let Week = Prefixed_Name(cevent, "Week") |> PrefixedName
    /// <summary>
    ///   <para>cevent:Exhibition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Questa classe rappresenta una mostra, come sottocategoria di un generico evento culturale.</para>
    ///   <para>This class represents an exhibition, as a particular type of cultural event.</para>
    /// labels<para>Exhibition</para><para>Mostra</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/cultural-event/Exhibition">https://w3id.org/arco/ontology/cultural-event/Exhibition</seealso>
    let Exhibition = Prefixed_Name(cevent, "Exhibition") |> PrefixedName
    /// <summary>
    ///   <para>cevent:Minute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/cultural-event/TimePeriodMeasurementUnit</para>
    ///
    /// labels<para>Minuto</para><para>Minute</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/cultural-event/Minute">https://w3id.org/arco/ontology/cultural-event/Minute</seealso>
    let Minute = Prefixed_Name(cevent, "Minute") |> PrefixedName

    /// <summary>
    ///   <para>cevent:hasRecurrentTimePeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega un evento ricorrente al periodo di tempo che intercorre tra uno dei suoi eventi membri e quello successivo.</para>
    ///   <para>This property relates a recurrent event to the time period that elapses between one of its member events and the next one.</para>
    /// labels<para>ha periodo ricorrente di tempo</para><para>has recurrent time period</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/cultural-event/hasRecurrentTimePeriod">https://w3id.org/arco/ontology/cultural-event/hasRecurrentTimePeriod</seealso>
    let hasRecurrentTimePeriod =
        Prefixed_Name(cevent, "hasRecurrentTimePeriod") |> PrefixedName

    /// <summary>
    ///   <para>cevent:hasNextEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>Questa proprietà collega un evento che è membro di un evento ricorrente, inteso come collezione, a uno degli eventi successivi.</para>
    ///   <para>This property relates an event that is member of a recurrent event, as a collection, to one of the next events.</para>
    /// labels<para>ha evento successivo</para><para>has next event</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/cultural-event/hasNextEvent">https://w3id.org/arco/ontology/cultural-event/hasNextEvent</seealso>
    let hasNextEvent = Prefixed_Name(cevent, "hasNextEvent") |> PrefixedName
    /// <summary>
    ///   <para>cevent:hasPreviousEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega un evento che è membro di un evento ricorrente, inteso come collezione, a uno degli eventi precedenti.</para>
    ///   <para>This property relates an event that is member of a recurrent event, as a collection, to one of the previous events.</para>
    /// labels<para>ha evento precedente</para><para>has previous event</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/cultural-event/hasPreviousEvent">https://w3id.org/arco/ontology/cultural-event/hasPreviousEvent</seealso>
    let hasPreviousEvent = Prefixed_Name(cevent, "hasPreviousEvent") |> PrefixedName
    /// <summary>
    ///   <para>cevent:timePeriodValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Questa proprietà rappresenta il valore del periodo di tempo che intercorre tra il verificarsi di due eventi membri di un evento ricorrente.</para>
    ///   <para>This property represents the value associated to the time period that elapses between one of the member events of a recurrent event, as a collection of events, and the next one.</para>
    /// labels<para>valore del periodo di tempo</para><para>time period value</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/cultural-event/timePeriodValue">https://w3id.org/arco/ontology/cultural-event/timePeriodValue</seealso>
    let timePeriodValue = Prefixed_Name(cevent, "timePeriodValue") |> PrefixedName

    /// <summary>
    ///   <para>cevent:isRecurrentTimePeriodOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega il periodo di tempo massimo che intercorre tra uno degli eventi membri di un evento ricorrente e l'evento successivo.</para>
    ///   <para>This property relates the maximum time period that elapses between one of the member events of a recurrent event and the next one.</para>
    /// labels<para>is recurrent time period of</para><para>è periodo di tempo di</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/cultural-event/isRecurrentTimePeriodOf">https://w3id.org/arco/ontology/cultural-event/isRecurrentTimePeriodOf</seealso>
    let isRecurrentTimePeriodOf =
        Prefixed_Name(cevent, "isRecurrentTimePeriodOf") |> PrefixedName

    /// <summary>
    ///   <para>cevent:Second</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/cultural-event/TimePeriodMeasurementUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Secondo</para><para>Second</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/cultural-event/Second">https://w3id.org/arco/ontology/cultural-event/Second</seealso>
    let Second = Prefixed_Name(cevent, "Second") |> PrefixedName

    /// <summary>
    ///   <para>cevent:TimePeriodMeasurementUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Questa classe rappresenta l'unità di misura associata al periodo di tempo massimo che intercorre tra un evento membro di un evento ricorrente, inteso come collezione di eventi, e un evento membro successivo.</para>
    ///   <para>This class represents the unit of measurement associated to the maximum time period that elapses between one of the member events of a recurrent event, as a collection of events, and the next one.</para>
    /// labels<para>Unità di misura del periodo di tempo</para><para>Time period measurement unit</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/cultural-event/TimePeriodMeasurementUnit">https://w3id.org/arco/ontology/cultural-event/TimePeriodMeasurementUnit</seealso>
    let TimePeriodMeasurementUnit =
        Prefixed_Name(cevent, "TimePeriodMeasurementUnit") |> PrefixedName

    /// <summary>
    ///   <para>cevent:Hour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/cultural-event/TimePeriodMeasurementUnit</para>
    ///
    /// labels<para>Hour</para><para>Ora</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/cultural-event/Hour">https://w3id.org/arco/ontology/cultural-event/Hour</seealso>
    let Hour = Prefixed_Name(cevent, "Hour") |> PrefixedName
    /// <summary>
    ///   <para>cevent:RecurrentEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a recurrent event, that is an event as a collection of sequential events and identified by at least one unifying factor (e.g.: topic, place).</para>
    ///   <para>Questa classe rappresenta un evento ricorrente, ovvero un evento inteso come collezione di eventi, posti in una sequenza temporale, e caratterizzato da almeno un fattore unificante (es.: il topic, il luogo).</para>
    /// labels<para>Evento ricorrente</para><para>Recurrent event</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/cultural-event/RecurrentEvent">https://w3id.org/arco/ontology/cultural-event/RecurrentEvent</seealso>
    let RecurrentEvent = Prefixed_Name(cevent, "RecurrentEvent") |> PrefixedName

    /// <summary>
    ///   <para>cevent:RecurrentTimePeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Questa classe rappresenta il periodo di tempo che intercorre tra un evento membro di un evento ricorrente, inteso come collezione di eventi, e un evento membro successivo.</para>
    ///   <para>This class represents the time period that elapses between one of the member events of a recurrent event, as a collection of events, and the next one.</para>
    /// labels<para>Periodo di tempo ricorrente</para><para>Recurrent time period</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/cultural-event/RecurrentTimePeriod">https://w3id.org/arco/ontology/cultural-event/RecurrentTimePeriod</seealso>
    let RecurrentTimePeriod =
        Prefixed_Name(cevent, "RecurrentTimePeriod") |> PrefixedName

    /// <summary>
    ///   <para>cevent:hasMemberEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega un evento ricorrente, inteso come collezione di eventi, a uno degli eventi membri della collezione.</para>
    ///   <para>This property relates a recurrent event, as a collection of events, to one of its member events.</para>
    /// labels<para>ha evento membro</para><para>has member event</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/cultural-event/hasMemberEvent">https://w3id.org/arco/ontology/cultural-event/hasMemberEvent</seealso>
    let hasMemberEvent = Prefixed_Name(cevent, "hasMemberEvent") |> PrefixedName
    /// <summary>
    ///   <para>cevent:UnifyingFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Questa classe rappresenta un fattore unificante, ovvero un fattore che rappresenta un invariante comune a tutti gli eventi che sono membri dell'evento ricorrente.</para>
    ///   <para>This class represents a unifying factor, that is a factor that represents an invariant common to all the events that are members of the recurrent event.</para>
    /// labels<para>Fattore unificante</para><para>Unifying factor</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/cultural-event/UnifyingFactor">https://w3id.org/arco/ontology/cultural-event/UnifyingFactor</seealso>
    let UnifyingFactor = Prefixed_Name(cevent, "UnifyingFactor") |> PrefixedName
    /// <summary>
    ///   <para>cevent:Month</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/cultural-event/TimePeriodMeasurementUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Month</para><para>Mese</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/cultural-event/Month">https://w3id.org/arco/ontology/cultural-event/Month</seealso>
    let Month = Prefixed_Name(cevent, "Month") |> PrefixedName
    /// <summary>
    ///   <para>cevent:hasUnifyingFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega un evento ricorrente a un fattore unificante.</para>
    ///   <para>This property relates a recurrent event to a unifying factor.</para>
    /// labels<para>ha fattore unificante</para><para>has unifying factor</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/cultural-event/hasUnifyingFactor">https://w3id.org/arco/ontology/cultural-event/hasUnifyingFactor</seealso>
    let hasUnifyingFactor = Prefixed_Name(cevent, "hasUnifyingFactor") |> PrefixedName

    /// <summary>
    ///   <para>cevent:hasTimePeriodMeasurementUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates the maximum time period that elapses between one of the member events of a recurrent event, as a collection of events, and the next one, to the unit of measurement associated to it.</para>
    ///   <para>Questa proprietà collega il periodo di tempo massimo che intercorre tra un evento membro di un evento ricorrente, inteso come collezione di eventi, e un evento membro successivo alla sua unità di misura.</para>
    /// labels<para>ha unità di misura di periodo di tempo</para><para>has time period measurement unit</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/cultural-event/hasTimePeriodMeasurementUnit">https://w3id.org/arco/ontology/cultural-event/hasTimePeriodMeasurementUnit</seealso>
    let hasTimePeriodMeasurementUnit =
        Prefixed_Name(cevent, "hasTimePeriodMeasurementUnit") |> PrefixedName

    /// <summary>
    ///   <para>cevent:TimePeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>La classe che rappresenta un periodo di tempo.</para>
    ///   <para>The class that represents a time period.</para>
    /// labels<para>Periodo di tempo</para><para>Time period</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/cultural-event/TimePeriod">https://w3id.org/arco/ontology/cultural-event/TimePeriod</seealso>
    let TimePeriod = Prefixed_Name(cevent, "TimePeriod") |> PrefixedName
    /// <summary>
    ///   <para>cevent:isUnifyingFactorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates a unifying factor to a recurrent event.</para>
    ///   <para>Questa proprietà collega un fattore unificante a un evento ricorrente.</para>
    /// labels<para>è fattore unificante di</para><para>is unifying factor of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/cultural-event/isUnifyingFactorOf">https://w3id.org/arco/ontology/cultural-event/isUnifyingFactorOf</seealso>
    let isUnifyingFactorOf = Prefixed_Name(cevent, "isUnifyingFactorOf") |> PrefixedName
    /// <summary>
    ///   <para>cevent:Year</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/cultural-event/TimePeriodMeasurementUnit</para>
    ///
    /// labels<para>Anno</para><para>Year</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/cultural-event/Year">https://w3id.org/arco/ontology/cultural-event/Year</seealso>
    let Year = Prefixed_Name(cevent, "Year") |> PrefixedName

    /// <summary>
    ///   <para>cevent:hasAgentRelatedToCulturalEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà rappresenta la relazione che collega un evento culturale a un agente che riveste un ruolo relativo all'evento. La relazione tra il ruolo e l’agente che lo riveste è espressa, in maniera generica, nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. La relazione è poi specializzata da sottoproprietà. Nell’ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe TimeIndexedRole, che permette di collegare l’ente, il suo ruolo e la sua corrispondente estensione temporale.</para>
    ///   <para>This class relates a cultural event to an agent playing a role related to that cultural event.</para>
    /// labels<para>ha agente collegato a evento culturale</para><para>has agent related to cultural event</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/cultural-event/hasAgentRelatedToCulturalEvent">https://w3id.org/arco/ontology/cultural-event/hasAgentRelatedToCulturalEvent</seealso>
    let hasAgentRelatedToCulturalEvent =
        Prefixed_Name(cevent, "hasAgentRelatedToCulturalEvent") |> PrefixedName

    /// <summary>
    ///   <para>cevent:hasEventOrganiser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega un evento culturale all'ente o soggetto che ha organizzato quell'evento.</para>
    ///   <para>This property relates a cultural evento to the agency or person that is the organiser of that event.</para>
    /// labels<para>ha ente o soggetto organizzatore</para><para>has event organiser</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/cultural-event/hasEventOrganiser">https://w3id.org/arco/ontology/cultural-event/hasEventOrganiser</seealso>
    let hasEventOrganiser = Prefixed_Name(cevent, "hasEventOrganiser") |> PrefixedName

    /// <summary>
    ///   <para>cevent:hasImmediateNextEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates an event that is member of a recurrent event, as a collection, to the immediate next event.</para>
    ///   <para>Questa proprietà collega un evento che è membro di un evento ricorrente, inteso come collezione, all'evento immediatamente successivo.</para>
    /// labels<para>ha evento immediatamente successivo</para><para>has immediate next event</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/cultural-event/hasImmediateNextEvent">https://w3id.org/arco/ontology/cultural-event/hasImmediateNextEvent</seealso>
    let hasImmediateNextEvent =
        Prefixed_Name(cevent, "hasImmediateNextEvent") |> PrefixedName

    /// <summary>
    ///   <para>cevent:isEventOrganiserOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This is the inverse property of "has event organiser".</para>
    ///   <para>Questa è la proprietà inversa a "ha ente o soggetto organizzatore".</para>
    /// labels<para>è organizzatore di evento</para><para>is event organiser of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/cultural-event/isEventOrganiserOf">https://w3id.org/arco/ontology/cultural-event/isEventOrganiserOf</seealso>
    let isEventOrganiserOf = Prefixed_Name(cevent, "isEventOrganiserOf") |> PrefixedName

    /// <summary>
    ///   <para>cevent:hasImmediatePreviousEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega un evento che è membro di un evento ricorrente, inteso come collezione, all'evento immediatamente precedente.</para>
    ///   <para>This property relates an event that is member of a recurrent event, as a collection, to the immediate previous event.</para>
    /// labels<para>ha evento immediatamente precedente</para><para>has immediate previous event</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/cultural-event/hasImmediatePreviousEvent">https://w3id.org/arco/ontology/cultural-event/hasImmediatePreviousEvent</seealso>
    let hasImmediatePreviousEvent =
        Prefixed_Name(cevent, "hasImmediatePreviousEvent") |> PrefixedName

    /// <summary>
    ///   <para>cevent:isEventMemberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>è evento membro di</para><para>is event member of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/cultural-event/isEventMemberOf">https://w3id.org/arco/ontology/cultural-event/isEventMemberOf</seealso>
    let isEventMemberOf = Prefixed_Name(cevent, "isEventMemberOf") |> PrefixedName

    /// <summary>
    ///   <para>cevent:hasTimePeriodBeforeNextEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates an event, member of a recurrent event as a collection of events, to the time period that is between that event and the next one.</para>
    ///   <para>Questa proprietà collega un evento, membro di un evento ricorrente inteso come collezione di eventi, al periodo di tempo che intercorre tra l'evento stesso e l'evento successivo.</para>
    /// labels<para>ha periodo di tempo prima di evento successivo</para><para>has time period before next event</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/cultural-event/hasTimePeriodBeforeNextEvent">https://w3id.org/arco/ontology/cultural-event/hasTimePeriodBeforeNextEvent</seealso>
    let hasTimePeriodBeforeNextEvent =
        Prefixed_Name(cevent, "hasTimePeriodBeforeNextEvent") |> PrefixedName

    /// <summary>
    ///   <para>cevent:isTimePeriodBeforeNextEventOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa è la proprietà inversa a "ha periodo di tempo prima di evento successivo".</para>
    ///   <para>This is the inverse property of "has time period before next event".</para>
    /// labels<para>è periodo di tempo prima di evento successivo di</para><para>is time period before next event of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/cultural-event/isTimePeriodBeforeNextEventOf">https://w3id.org/arco/ontology/cultural-event/isTimePeriodBeforeNextEventOf</seealso>
    let isTimePeriodBeforeNextEventOf =
        Prefixed_Name(cevent, "isTimePeriodBeforeNextEventOf") |> PrefixedName

    /// <summary>
    ///   <para>cevent:eventTimeLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Questa proprietà rappresenta il luogo e il tempo di un evento culturale, quando espressi unitamente.</para>
    ///   <para>This property represents the time and location of a cultural event, when they are recorded together.</para>
    /// labels<para>tempo e luogo dell'evento</para><para>event time and location</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/cultural-event/eventTimeLocation">https://w3id.org/arco/ontology/cultural-event/eventTimeLocation</seealso>
    let eventTimeLocation = Prefixed_Name(cevent, "eventTimeLocation") |> PrefixedName

    /// <summary>
    ///   <para>cevent:isAgentRelatedToCulturalEventOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa è la proprietà inversa a "ha agente collegato a evento culturale".</para>
    ///   <para>This is the inverse property of "has agent related to cultural event".</para>
    /// labels<para>is agent related to cultural event of</para><para>è agente collegato a evento culturale</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/cultural-event/isAgentRelatedToCulturalEventOf">https://w3id.org/arco/ontology/cultural-event/isAgentRelatedToCulturalEventOf</seealso>
    let isAgentRelatedToCulturalEventOf =
        Prefixed_Name(cevent, "isAgentRelatedToCulturalEventOf") |> PrefixedName
