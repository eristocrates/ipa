#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module cevent =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://w3id.org/arco/ontology/cultural-event/" "cevent"

    /// <summary>
    ///   <para>rdfs:comment : This class represents an exhibition, as a particular type of cultural event.rdfs:comment : Questa classe rappresenta una mostra, come sottocategoria di un generico evento culturale.</para>
    ///   <para>rdfs:label : Mostrardfs:label : Exhibition</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale e altre normative di versione 4.00: se MS/MST/MSTI= "mostra"</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/cultural-event/Exhibition">cevent:Exhibition</a>
    /// </summary>
    let Exhibition = _prefixId.prefix "Exhibition"
    let Hour = _prefixId.prefix "Hour"
    let Minute = _prefixId.prefix "Minute"
    let Month = _prefixId.prefix "Month"
    /// <summary>
    ///   <para>rdfs:label : Evento ricorrenterdfs:label : Recurrent event</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa BDI 4.00: RC^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents a recurrent event, that is an event as a collection of sequential events and identified by at least one unifying factor (e.g.: topic, place).rdfs:comment : Questa classe rappresenta un evento ricorrente, ovvero un evento inteso come collezione di eventi, posti in una sequenza temporale, e caratterizzato da almeno un fattore unificante (es.: il topic, il luogo).</para>
    ///   <a href="https://w3id.org/arco/ontology/cultural-event/RecurrentEvent">cevent:RecurrentEvent</a>
    /// </summary>
    let RecurrentEvent = _prefixId.prefix "RecurrentEvent"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : Recurrent time periodrdfs:label : Periodo di tempo ricorrente</para>
    ///   <para>rdfs:comment : This class represents the time period that elapses between one of the member events of a recurrent event, as a collection of events, and the next one.rdfs:comment : Questa classe rappresenta il periodo di tempo che intercorre tra un evento membro di un evento ricorrente, inteso come collezione di eventi, e un evento membro successivo.</para>
    ///   <a href="https://w3id.org/arco/ontology/cultural-event/RecurrentTimePeriod">cevent:RecurrentTimePeriod</a>
    /// </summary>
    let RecurrentTimePeriod = _prefixId.prefix "RecurrentTimePeriod"
    let Second = _prefixId.prefix "Second"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Periodo di tempordfs:label : Time period</para>
    ///   <para>rdfs:comment : La classe che rappresenta un periodo di tempo.rdfs:comment : The class that represents a time period.</para>
    ///   <a href="https://w3id.org/arco/ontology/cultural-event/TimePeriod">cevent:TimePeriod</a>
    /// </summary>
    let TimePeriod = _prefixId.prefix "TimePeriod"
    /// <summary>
    ///   <para>rdfs:comment : Questa classe rappresenta l'unità di misura associata al periodo di tempo massimo che intercorre tra un evento membro di un evento ricorrente, inteso come collezione di eventi, e un evento membro successivo.rdfs:comment : This class represents the unit of measurement associated to the maximum time period that elapses between one of the member events of a recurrent event, as a collection of events, and the next one.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Unità di misura del periodo di tempordfs:label : Time period measurement unit</para>
    ///   <a href="https://w3id.org/arco/ontology/cultural-event/TimePeriodMeasurementUnit">cevent:TimePeriodMeasurementUnit</a>
    /// </summary>
    let TimePeriodMeasurementUnit = _prefixId.prefix "TimePeriodMeasurementUnit"
    /// <summary>
    ///   <para>rdfs:label : Unifying factorrdfs:label : Fattore unificante</para>
    ///   <para>rdfs:comment : Questa classe rappresenta un fattore unificante, ovvero un fattore che rappresenta un invariante comune a tutti gli eventi che sono membri dell'evento ricorrente.rdfs:comment : This class represents a unifying factor, that is a factor that represents an invariant common to all the events that are members of the recurrent event.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/cultural-event/UnifyingFactor">cevent:UnifyingFactor</a>
    /// </summary>
    let UnifyingFactor = _prefixId.prefix "UnifyingFactor"
    let Week = _prefixId.prefix "Week"
    let Year = _prefixId.prefix "Year"
    /// <summary>
    ///   <para>rdfs:comment : This property represents the time and location of a cultural event, when they are recorded together.rdfs:comment : Questa proprietà rappresenta il luogo e il tempo di un evento culturale, quando espressi unitamente.</para>
    ///   <para>rdfs:label : tempo e luogo dell'eventordfs:label : event time and location</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale e normative di versione 4.00: MS/MST/MSTL</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/cultural-event/eventTimeLocation">cevent:eventTimeLocation</a>
    /// </summary>
    let eventTimeLocation = _prefixId.prefix "eventTimeLocation"

    /// <summary>
    ///   <para>rdfs:label : ha agente collegato a evento culturalerdfs:label : has agent related to cultural event</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This class relates a cultural event to an agent playing a role related to that cultural event.rdfs:comment : Questa proprietà rappresenta la relazione che collega un evento culturale a un agente che riveste un ruolo relativo all'evento. La relazione tra il ruolo e l’agente che lo riveste è espressa, in maniera generica, nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. La relazione è poi specializzata da sottoproprietà. Nell’ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe TimeIndexedRole, che permette di collegare l’ente, il suo ruolo e la sua corrispondente estensione temporale.</para>
    ///   <a href="https://w3id.org/arco/ontology/cultural-event/hasAgentRelatedToCulturalEvent">cevent:hasAgentRelatedToCulturalEvent</a>
    /// </summary>
    let hasAgentRelatedToCulturalEvent =
        _prefixId.prefix "hasAgentRelatedToCulturalEvent"

    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega un evento culturale all'ente o soggetto che ha organizzato quell'evento.rdfs:comment : This property relates a cultural evento to the agency or person that is the organiser of that event.</para>
    ///   <para>ctlog:iccdNormTag : Versioni 4.00 e ICCD Normativa Trasversale: MS/MST/MSTE - Versioni precedenti a 4.00: DO/MST/MSTO</para>
    ///   <para>rdfs:label : has event organiserrdfs:label : ha ente o soggetto organizzatore</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/cultural-event/hasEventOrganiser">cevent:hasEventOrganiser</a>
    /// </summary>
    let hasEventOrganiser = _prefixId.prefix "hasEventOrganiser"
    /// <summary>
    ///   <para>rdfs:label : ha evento immediatamente successivordfs:label : has immediate next event</para>
    ///   <para>rdfs:comment : Questa proprietà collega un evento che è membro di un evento ricorrente, inteso come collezione, all'evento immediatamente successivo.rdfs:comment : This property relates an event that is member of a recurrent event, as a collection, to the immediate next event.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/cultural-event/hasImmediateNextEvent">cevent:hasImmediateNextEvent</a>
    /// </summary>
    let hasImmediateNextEvent = _prefixId.prefix "hasImmediateNextEvent"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà collega un evento che è membro di un evento ricorrente, inteso come collezione, all'evento immediatamente precedente.rdfs:comment : This property relates an event that is member of a recurrent event, as a collection, to the immediate previous event.</para>
    ///   <para>rdfs:label : ha evento immediatamente precedenterdfs:label : has immediate previous event</para>
    ///   <a href="https://w3id.org/arco/ontology/cultural-event/hasImmediatePreviousEvent">cevent:hasImmediatePreviousEvent</a>
    /// </summary>
    let hasImmediatePreviousEvent = _prefixId.prefix "hasImmediatePreviousEvent"
    /// <summary>
    ///   <para>rdfs:label : has member eventrdfs:label : ha evento membro</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà collega un evento ricorrente, inteso come collezione di eventi, a uno degli eventi membri della collezione.rdfs:comment : This property relates a recurrent event, as a collection of events, to one of its member events.</para>
    ///   <a href="https://w3id.org/arco/ontology/cultural-event/hasMemberEvent">cevent:hasMemberEvent</a>
    /// </summary>
    let hasMemberEvent = _prefixId.prefix "hasMemberEvent"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : has next eventrdfs:label : ha evento successivo</para>
    ///   <para>rdfs:comment : This property relates an event that is member of a recurrent event, as a collection, to one of the next events.rdfs:comment : Questa proprietà collega un evento che è membro di un evento ricorrente, inteso come collezione, a uno degli eventi successivi.</para>
    ///   <a href="https://w3id.org/arco/ontology/cultural-event/hasNextEvent">cevent:hasNextEvent</a>
    /// </summary>
    let hasNextEvent = _prefixId.prefix "hasNextEvent"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà collega un evento che è membro di un evento ricorrente, inteso come collezione, a uno degli eventi precedenti.rdfs:comment : This property relates an event that is member of a recurrent event, as a collection, to one of the previous events.</para>
    ///   <para>rdfs:label : ha evento precedenterdfs:label : has previous event</para>
    ///   <a href="https://w3id.org/arco/ontology/cultural-event/hasPreviousEvent">cevent:hasPreviousEvent</a>
    /// </summary>
    let hasPreviousEvent = _prefixId.prefix "hasPreviousEvent"
    /// <summary>
    ///   <para>rdfs:comment : This property relates a recurrent event to the time period that elapses between one of its member events and the next one.rdfs:comment : Questa proprietà collega un evento ricorrente al periodo di tempo che intercorre tra uno dei suoi eventi membri e quello successivo.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : ha periodo ricorrente di tempordfs:label : has recurrent time period</para>
    ///   <a href="https://w3id.org/arco/ontology/cultural-event/hasRecurrentTimePeriod">cevent:hasRecurrentTimePeriod</a>
    /// </summary>
    let hasRecurrentTimePeriod = _prefixId.prefix "hasRecurrentTimePeriod"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This property relates an event, member of a recurrent event as a collection of events, to the time period that is between that event and the next one.rdfs:comment : Questa proprietà collega un evento, membro di un evento ricorrente inteso come collezione di eventi, al periodo di tempo che intercorre tra l'evento stesso e l'evento successivo.</para>
    ///   <para>rdfs:label : has time period before next eventrdfs:label : ha periodo di tempo prima di evento successivo</para>
    ///   <a href="https://w3id.org/arco/ontology/cultural-event/hasTimePeriodBeforeNextEvent">cevent:hasTimePeriodBeforeNextEvent</a>
    /// </summary>
    let hasTimePeriodBeforeNextEvent = _prefixId.prefix "hasTimePeriodBeforeNextEvent"
    /// <summary>
    ///   <para>rdfs:comment : This property relates the maximum time period that elapses between one of the member events of a recurrent event, as a collection of events, and the next one, to the unit of measurement associated to it.rdfs:comment : Questa proprietà collega il periodo di tempo massimo che intercorre tra un evento membro di un evento ricorrente, inteso come collezione di eventi, e un evento membro successivo alla sua unità di misura.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : has time period measurement unitrdfs:label : ha unità di misura di periodo di tempo</para>
    ///   <a href="https://w3id.org/arco/ontology/cultural-event/hasTimePeriodMeasurementUnit">cevent:hasTimePeriodMeasurementUnit</a>
    /// </summary>
    let hasTimePeriodMeasurementUnit = _prefixId.prefix "hasTimePeriodMeasurementUnit"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : has unifying factorrdfs:label : ha fattore unificante</para>
    ///   <para>rdfs:comment : This property relates a recurrent event to a unifying factor.rdfs:comment : Questa proprietà collega un evento ricorrente a un fattore unificante.</para>
    ///   <a href="https://w3id.org/arco/ontology/cultural-event/hasUnifyingFactor">cevent:hasUnifyingFactor</a>
    /// </summary>
    let hasUnifyingFactor = _prefixId.prefix "hasUnifyingFactor"

    /// <summary>
    ///   <para>rdfs:label : is agent related to cultural event ofrdfs:label : è agente collegato a evento culturale</para>
    ///   <para>rdfs:comment : Questa è la proprietà inversa a "ha agente collegato a evento culturale".rdfs:comment : This is the inverse property of "has agent related to cultural event".</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/cultural-event/isAgentRelatedToCulturalEventOf">cevent:isAgentRelatedToCulturalEventOf</a>
    /// </summary>
    let isAgentRelatedToCulturalEventOf =
        _prefixId.prefix "isAgentRelatedToCulturalEventOf"

    /// <summary>
    ///   <para>rdfs:isDefinedBy : Questa proprietà collega un evento, membro di un evento ricorrente inteso come una collezione di eventi, all'evento ricorrente di cui è membro.rdfs:isDefinedBy : This property relates an event, member of a recurrent event as a collection of events, to the recurrent event that is member of.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : is event member ofrdfs:label : è evento membro di</para>
    ///   <a href="https://w3id.org/arco/ontology/cultural-event/isEventMemberOf">cevent:isEventMemberOf</a>
    /// </summary>
    let isEventMemberOf = _prefixId.prefix "isEventMemberOf"
    /// <summary>
    ///   <para>rdfs:comment : This is the inverse property of "has event organiser".rdfs:comment : Questa è la proprietà inversa a "ha ente o soggetto organizzatore".</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : is event organiser ofrdfs:label : è organizzatore di evento</para>
    ///   <a href="https://w3id.org/arco/ontology/cultural-event/isEventOrganiserOf">cevent:isEventOrganiserOf</a>
    /// </summary>
    let isEventOrganiserOf = _prefixId.prefix "isEventOrganiserOf"
    /// <summary>
    ///   <para>rdfs:comment : This property relates the maximum time period that elapses between one of the member events of a recurrent event and the next one.rdfs:comment : Questa proprietà collega il periodo di tempo massimo che intercorre tra uno degli eventi membri di un evento ricorrente e l'evento successivo.</para>
    ///   <para>rdfs:label : è periodo di tempo dirdfs:label : is recurrent time period of</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/cultural-event/isRecurrentTimePeriodOf">cevent:isRecurrentTimePeriodOf</a>
    /// </summary>
    let isRecurrentTimePeriodOf = _prefixId.prefix "isRecurrentTimePeriodOf"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa è la proprietà inversa a "ha periodo di tempo prima di evento successivo".rdfs:comment : This is the inverse property of "has time period before next event".</para>
    ///   <para>rdfs:label : è periodo di tempo prima di evento successivo dirdfs:label : is time period before next event of</para>
    ///   <a href="https://w3id.org/arco/ontology/cultural-event/isTimePeriodBeforeNextEventOf">cevent:isTimePeriodBeforeNextEventOf</a>
    /// </summary>
    let isTimePeriodBeforeNextEventOf = _prefixId.prefix "isTimePeriodBeforeNextEventOf"
    /// <summary>
    ///   <para>rdfs:comment : Questa è la proprietà inversa a "ha unità di misura di periodo di tempo".rdfs:comment : This is the inverse property of "has time period measurement unit".</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : is time period measurement unit ofrdfs:label : è unità di misura di periodo di tempo</para>
    ///   <a href="https://w3id.org/arco/ontology/cultural-event/isTimePeriodMeasurementUnitOf">cevent:isTimePeriodMeasurementUnitOf</a>
    /// </summary>
    let isTimePeriodMeasurementUnitOf = _prefixId.prefix "isTimePeriodMeasurementUnitOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property relates a unifying factor to a recurrent event.rdfs:comment : Questa proprietà collega un fattore unificante a un evento ricorrente.</para>
    ///   <para>rdfs:label : is unifying factor ofrdfs:label : è fattore unificante di</para>
    ///   <a href="https://w3id.org/arco/ontology/cultural-event/isUnifyingFactorOf">cevent:isUnifyingFactorOf</a>
    /// </summary>
    let isUnifyingFactorOf = _prefixId.prefix "isUnifyingFactorOf"
    /// <summary>
    ///   <para>rdfs:label : valore del periodo di tempordfs:label : time period value</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property represents the value associated to the time period that elapses between one of the member events of a recurrent event, as a collection of events, and the next one.rdfs:comment : Questa proprietà rappresenta il valore del periodo di tempo che intercorre tra il verificarsi di due eventi membri di un evento ricorrente.</para>
    ///   <a href="https://w3id.org/arco/ontology/cultural-event/timePeriodValue">cevent:timePeriodValue</a>
    /// </summary>
    let timePeriodValue = _prefixId.prefix "timePeriodValue"
