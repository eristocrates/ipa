#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module uiot =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.w3id.org/urban-iot/core#" "uiot"

    /// <summary>
    ///   <para>rdfs:label : Mobility Stationrdfs:label : Stazione di Mobilità</para>
    ///   <para>rdfs:comment : A Place characterized by mobility services. A Mobility Station can include more specific Mobility Station (Sharing Station, Charging Station, ecc.).rdfs:comment : Un Luogo caratterizzato dalla presenza di servizi di mobilità. Può includere altre Stazioni di Mobilità dedicate a specifici servizi per la mobilità (Stazioni di Sharing, Stazioni di Ricarica, etc.).</para>
    ///   <a href="http://www.w3id.org/urban-iot/core#MobilityStation">uiot:MobilityStation</a>
    /// </summary>
    let MobilityStation = _prefixId.prefix "MobilityStation"
    /// <summary>
    ///   <para>rdfs:label : Record del Sensorerdfs:label : Sensor Record</para>
    ///   <para>rdfs:comment : A Sensor Record aggregates a set of observations associated to the same timestamp and the same sensor.rdfs:comment : Un Record del Sensore aggrega un insieme di campionamenti associati allo stesso timestamp e allo stesso sensore.</para>
    ///   <a href="http://www.w3id.org/urban-iot/core#SensorRecord">uiot:SensorRecord</a>
    /// </summary>
    let SensorRecord = _prefixId.prefix "SensorRecord"
    /// <summary>
    ///   <para>rdfs:label : Service Business Userrdfs:label : Utente Business del Servizio</para>
    ///   <para>rdfs:comment : Entità Legale con contratto business per accedere al servizio. Un Utente Business non può utilizzare direttamente il servizio ma può abilitare un Utente Privato del Servizio a farlo.rdfs:comment : Legal Entity with a business contract for the service. A Service Business User can not directly use the service but can enable a Service Private User to do so.</para>
    ///   <a href="http://www.w3id.org/urban-iot/core#ServiceBusinessUser">uiot:ServiceBusinessUser</a>
    /// </summary>
    let ServiceBusinessUser = _prefixId.prefix "ServiceBusinessUser"
    /// <summary>
    ///   <para>rdfs:label : Service Private Userrdfs:label : Utente Privato del Servizio</para>
    ///   <para>rdfs:comment : A natural person using a service.rdfs:comment : Una persona fisica utilizzatore di un servizio.</para>
    ///   <a href="http://www.w3id.org/urban-iot/core#ServicePrivateUser">uiot:ServicePrivateUser</a>
    /// </summary>
    let ServicePrivateUser = _prefixId.prefix "ServicePrivateUser"
    /// <summary>
    ///   <para>rdfs:label : Risorsa del Serviziordfs:label : Service Resource</para>
    ///   <para>rdfs:comment : A Resource made available by a Service to be used in a Usage Session.rdfs:comment : Risorsa messa a disposizione da un Servizio che può essere utilizzata in una Sessione di Utilizzo.</para>
    ///   <a href="http://www.w3id.org/urban-iot/core#ServiceResource">uiot:ServiceResource</a>
    /// </summary>
    let ServiceResource = _prefixId.prefix "ServiceResource"
    /// <summary>
    ///   <para>rdfs:label : Service Userrdfs:label : Utente del Servizio</para>
    ///   <para>rdfs:comment : A User using a Service.rdfs:comment : Utente utilizzatore di un Servizio.</para>
    ///   <a href="http://www.w3id.org/urban-iot/core#ServiceUser">uiot:ServiceUser</a>
    /// </summary>
    let ServiceUser = _prefixId.prefix "ServiceUser"
    /// <summary>
    ///   <para>rdfs:label : Sessione di Utilizzordfs:label : Usage Session</para>
    ///   <para>rdfs:comment : A Usage Session is an Event associated to a Service and a Service Resource representing a usage of the resource made available by the Service.rdfs:comment : Una Sessione di Utilizzo è un Evento associato ad un Servizio e ad una Risorsa del Servizio che rappresenta un utilizzo della risorsa resa disponibile dal Servizio.</para>
    ///   <a href="http://www.w3id.org/urban-iot/core#UsageSession">uiot:UsageSession</a>
    /// </summary>
    let UsageSession = _prefixId.prefix "UsageSession"
    /// <summary>
    ///   <para>rdfs:label : associated businessrdfs:label : business associato</para>
    ///   <para>rdfs:comment : Associa una Sessione di Utilizzo all'Utente Business del Servizio che la abilita.rdfs:comment : Associates a Usage Session with the Service Business User enabling it.</para>
    ///   <a href="http://www.w3id.org/urban-iot/core#associatedBusiness">uiot:associatedBusiness</a>
    /// </summary>
    let associatedBusiness = _prefixId.prefix "associatedBusiness"
    /// <summary>
    ///   <para>rdfs:label : anno di nascitardfs:label : birth year</para>
    ///   <para>rdfs:comment : Associa una persona al suo anno di nascita.rdfs:comment : Associates a person with her/his birth year.</para>
    ///   <a href="http://www.w3id.org/urban-iot/core#birthYear">uiot:birthYear</a>
    /// </summary>
    let birthYear = _prefixId.prefix "birthYear"
    /// <summary>
    ///   <para>rdfs:label : contains observationrdfs:label : contiene campionamento</para>
    ///   <para>rdfs:comment : Associa un Record del Sensore ad un Campionamento contenuto nel record.rdfs:comment : Associates a Sensor Record with a Observation contained in it.</para>
    ///   <a href="http://www.w3id.org/urban-iot/core#containsObservation">uiot:containsObservation</a>
    /// </summary>
    let containsObservation = _prefixId.prefix "containsObservation"
    /// <summary>
    ///   <para>rdfs:label : data di disdettardfs:label : deregistration date</para>
    ///   <para>rdfs:comment : Data in cui l'Utente del Servizio ha chiesto la cancellazione della registrazione dal Servizio.rdfs:comment : Date in which a Service User deregistered from a Service.</para>
    ///   <a href="http://www.w3id.org/urban-iot/core#deregistrationDate">uiot:deregistrationDate</a>
    /// </summary>
    let deregistrationDate = _prefixId.prefix "deregistrationDate"
    /// <summary>
    ///   <para>rdfs:label : abilita sessionerdfs:label : enables session</para>
    ///   <para>rdfs:comment : Associa un Servizio ad una Sessione di Utilizzo abilitata dal Servizio.rdfs:comment : Associates a Service with a Usage Session enabled by the service.</para>
    ///   <a href="http://www.w3id.org/urban-iot/core#enablesSession">uiot:enablesSession</a>
    /// </summary>
    let enablesSession = _prefixId.prefix "enablesSession"
    /// <summary>
    ///   <para>rdfs:label : costo fissordfs:label : fixed amount</para>
    ///   <para>rdfs:comment : Associates an Offer with a fixed amount required from it.rdfs:comment : Indica un costo fisso dell'Offerta.</para>
    ///   <a href="http://www.w3id.org/urban-iot/core#fixedAmount">uiot:fixedAmount</a>
    /// </summary>
    let fixedAmount = _prefixId.prefix "fixedAmount"
    /// <summary>
    ///   <para>rdfs:label : ha utente abilitatordfs:label : has enabled user</para>
    ///   <para>rdfs:comment : Associa un Utente Business del Servizio ad un Utente Privato abilitato dall'utenza business.rdfs:comment : Associates a Service Business User with the Service Private User enabled by that business user.</para>
    ///   <a href="http://www.w3id.org/urban-iot/core#hasEnabledUser">uiot:hasEnabledUser</a>
    /// </summary>
    let hasEnabledUser = _prefixId.prefix "hasEnabledUser"
    /// <summary>
    ///   <para>rdfs:label : ha utenterdfs:label : has user</para>
    ///   <para>rdfs:comment : Associa un Servizio ad un Utente del Servizio.rdfs:comment : Associates a Service to a Service User.</para>
    ///   <a href="http://www.w3id.org/urban-iot/core#hasUser">uiot:hasUser</a>
    /// </summary>
    let hasUser = _prefixId.prefix "hasUser"
    /// <summary>
    ///   <para>rdfs:label : included in mobility stationrdfs:label : inclusa nella stazione di mobilità</para>
    ///   <para>rdfs:comment : Associa una Stazione di Mobilità ad una Stazione di Mobilità che la include.rdfs:comment : Associates a Mobility Station with another Mobility Station including it.</para>
    ///   <a href="http://www.w3id.org/urban-iot/core#includedInMobilityStation">uiot:includedInMobilityStation</a>
    /// </summary>
    let includedInMobilityStation = _prefixId.prefix "includedInMobilityStation"
    /// <summary>
    ///   <para>rdfs:label : latest recordrdfs:label : ultimo record</para>
    ///   <para>rdfs:comment : Associa un Sensore all'ultimo Record del Sensore registrato.rdfs:comment : Associates a Sensor with the latest registered Sensor Record.</para>
    ///   <a href="http://www.w3id.org/urban-iot/core#latestRecord">uiot:latestRecord</a>
    /// </summary>
    let latestRecord = _prefixId.prefix "latestRecord"
    /// <summary>
    ///   <para>rdfs:label : made available byrdfs:label : resa disponibile da</para>
    ///   <para>rdfs:comment : Associa una Risorsa del Servizio al Servizio che la rende disponibile.rdfs:comment : Associates a Service Resource with the Service making it available.</para>
    ///   <a href="http://www.w3id.org/urban-iot/core#madeAvailableBy">uiot:madeAvailableBy</a>
    /// </summary>
    let madeAvailableBy = _prefixId.prefix "madeAvailableBy"
    /// <summary>
    ///   <para>rdfs:label : makes availablerdfs:label : rende disponibile</para>
    ///   <para>rdfs:comment : Associa un Servizio ad una risorsa che rende disponibile.rdfs:comment : Associates a Service with the Service Resource that makes available.</para>
    ///   <a href="http://www.w3id.org/urban-iot/core#makesAvailable">uiot:makesAvailable</a>
    /// </summary>
    let makesAvailable = _prefixId.prefix "makesAvailable"
    /// <summary>
    ///   <para>rdfs:label : campionamento inrdfs:label : observation in</para>
    ///   <para>rdfs:comment : Associa un Campionamento al Record del Sensore di cui fa parte.rdfs:comment : Associates an Observation with the Sensor Record containing it.</para>
    ///   <a href="http://www.w3id.org/urban-iot/core#observationIn">uiot:observationIn</a>
    /// </summary>
    let observationIn = _prefixId.prefix "observationIn"
    /// <summary>
    ///   <para>rdfs:label : offer associatedrdfs:label : offerta associata</para>
    ///   <para>rdfs:comment : Associa una Sessione di Utilizzo alla tariffa (Offerta) applicata alla specifica sessione.rdfs:comment : Associates a Usage Session with the tariff (Offer) applied to the specific session.</para>
    ///   <a href="http://www.w3id.org/urban-iot/core#offerAssociated">uiot:offerAssociated</a>
    /// </summary>
    let offerAssociated = _prefixId.prefix "offerAssociated"
    /// <summary>
    ///   <para>rdfs:label : effettua sessionerdfs:label : performs session</para>
    ///   <para>rdfs:comment : Associa un Utente Privato del Servizio ad una Sessione di Utilizzo effettuata.rdfs:comment : Associates a Service Private User with a Usage Session performed.</para>
    ///   <a href="http://www.w3id.org/urban-iot/core#performsSession">uiot:performsSession</a>
    /// </summary>
    let performsSession = _prefixId.prefix "performsSession"
    /// <summary>
    ///   <para>rdfs:label : record registered byrdfs:label : record registrato da</para>
    ///   <para>rdfs:comment : Associa un Record del Sensore al Sensore che lo ha registrato.rdfs:comment : Associates a Sensor Record with the Sensor registering it.</para>
    ///   <a href="http://www.w3id.org/urban-iot/core#recordRegisteredBy">uiot:recordRegisteredBy</a>
    /// </summary>
    let recordRegisteredBy = _prefixId.prefix "recordRegisteredBy"
    /// <summary>
    ///   <para>rdfs:label : record timestamprdfs:label : timestamp del record</para>
    ///   <para>rdfs:comment : Timestamp associated with a Sensor Record.rdfs:comment : Timestamp associato ad un Record del Sensore.</para>
    ///   <a href="http://www.w3id.org/urban-iot/core#recordTimestamp">uiot:recordTimestamp</a>
    /// </summary>
    let recordTimestamp = _prefixId.prefix "recordTimestamp"
    /// <summary>
    ///   <para>rdfs:label : registered tordfs:label : registrato a</para>
    ///   <para>rdfs:comment : Associa un Utente al Servizio a cui è registrato.rdfs:comment : Associates a Service User to the Service to which the user is registered to.</para>
    ///   <a href="http://www.w3id.org/urban-iot/core#registeredTo">uiot:registeredTo</a>
    /// </summary>
    let registeredTo = _prefixId.prefix "registeredTo"
    /// <summary>
    ///   <para>rdfs:label : registers recordrdfs:label : registra record</para>
    ///   <para>rdfs:comment : Associa un Sensore ad un Record del Sensore.rdfs:comment : Associates a Sensor with a registered Sensor Record.</para>
    ///   <a href="http://www.w3id.org/urban-iot/core#registersRecord">uiot:registersRecord</a>
    /// </summary>
    let registersRecord = _prefixId.prefix "registersRecord"
    /// <summary>
    ///   <para>rdfs:label : data di registrazionerdfs:label : registration date</para>
    ///   <para>rdfs:comment : Data di registrazione dell'Utente del Servizio al Servizio.rdfs:comment : Date in which a Service User registered to the Service.</para>
    ///   <a href="http://www.w3id.org/urban-iot/core#registrationDate">uiot:registrationDate</a>
    /// </summary>
    let registrationDate = _prefixId.prefix "registrationDate"
    /// <summary>
    ///   <para>rdfs:label : prenotazione utilizzatardfs:label : reservation used</para>
    ///   <para>rdfs:comment : Indica se un meccanismo di prenotazione è stato utilizzato per una Sessione di Utilizzo.rdfs:comment : Indicates whether a reservation mechanism has been used for a Usage Session.</para>
    ///   <a href="http://www.w3id.org/urban-iot/core#reservationUsed">uiot:reservationUsed</a>
    /// </summary>
    let reservationUsed = _prefixId.prefix "reservationUsed"
    /// <summary>
    ///   <para>rdfs:label : resource used inrdfs:label : risorsa usata in</para>
    ///   <para>rdfs:comment : Associa una Risorsa del Servizio ad una Sessione di Utilizzo in cui è stata utilizzata.rdfs:comment : Associates a Service Resource with a Usage Session using it.</para>
    ///   <a href="http://www.w3id.org/urban-iot/core#resourceUsedIn">uiot:resourceUsedIn</a>
    /// </summary>
    let resourceUsedIn = _prefixId.prefix "resourceUsedIn"
    /// <summary>
    ///   <para>rdfs:label : numero serialerdfs:label : serial number</para>
    ///   <para>rdfs:comment : Indication of the serial number.rdfs:comment : Indicazione del numero seriale.</para>
    ///   <a href="http://www.w3id.org/urban-iot/core#serialNumber">uiot:serialNumber</a>
    /// </summary>
    let serialNumber = _prefixId.prefix "serialNumber"
    /// <summary>
    ///   <para>rdfs:label : session enabled byrdfs:label : sessione abilitata da</para>
    ///   <para>rdfs:comment : Associa una Sessione di Utilizzo al Servizio che la abilita.rdfs:comment : Associates a Usage Session with the Service enabling it.</para>
    ///   <a href="http://www.w3id.org/urban-iot/core#sessionEnabledBy">uiot:sessionEnabledBy</a>
    /// </summary>
    let sessionEnabledBy = _prefixId.prefix "sessionEnabledBy"
    /// <summary>
    ///   <para>rdfs:label : session performed byrdfs:label : sessione effettuata da</para>
    ///   <para>rdfs:comment : Associa una Sessione di Utilizzo all'Utente Privato del Servizio che la effettua.rdfs:comment : Associates a Usage Session with the Service Private User performing it.</para>
    ///   <a href="http://www.w3id.org/urban-iot/core#sessionPerformedBy">uiot:sessionPerformedBy</a>
    /// </summary>
    let sessionPerformedBy = _prefixId.prefix "sessionPerformedBy"
    /// <summary>
    ///   <para>rdfs:label : user enabled byrdfs:label : utente abilitato da</para>
    ///   <para>rdfs:comment : Associa un Utente Privato del Servizio all'Utente Business che lo abilita.rdfs:comment : Associates a Service Private User to the Service Business User enabling it.</para>
    ///   <a href="http://www.w3id.org/urban-iot/core#userEnabledBy">uiot:userEnabledBy</a>
    /// </summary>
    let userEnabledBy = _prefixId.prefix "userEnabledBy"
    /// <summary>
    ///   <para>rdfs:label : user of servicerdfs:label : utente del servizio</para>
    ///   <para>rdfs:comment : Associa un Utente del Servizio al Servizio che utilizza.rdfs:comment : Associates a Service User to the Service used.</para>
    ///   <a href="http://www.w3id.org/urban-iot/core#userOfService">uiot:userOfService</a>
    /// </summary>
    let userOfService = _prefixId.prefix "userOfService"
    /// <summary>
    ///   <para>rdfs:label : uses resourcerdfs:label : utilizza risorsa</para>
    ///   <para>rdfs:comment : Associa una Sessione di Utilizzo alla Risorsa del Servizio utilizzata.rdfs:comment : Associates a Usage Session with the Service Resource used in the session.</para>
    ///   <a href="http://www.w3id.org/urban-iot/core#usesResource">uiot:usesResource</a>
    /// </summary>
    let usesResource = _prefixId.prefix "usesResource"
