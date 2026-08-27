namespace http.www.w3id.org.urban_iot.core.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module uiot =
    let _namespace_iri = Namespace_Iri uiot |> NamespaceIRI
    /// <summary>
    ///   <para>uiot:MobilityStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Un Luogo caratterizzato dalla presenza di servizi di mobilità. Può includere altre Stazioni di Mobilità dedicate a specifici servizi per la mobilità (Stazioni di Sharing, Stazioni di Ricarica, etc.)."</para>
    ///   <para>"A Place characterized by mobility services. A Mobility Station can include more specific Mobility Station (Sharing Station, Charging Station, ecc.)."</para>
    /// labels<para>"Mobility Station"</para><para>"Stazione di Mobilità"</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/core#MobilityStation">http://www.w3id.org/urban-iot/core#MobilityStation</seealso>
    let MobilityStation = Prefixed_Name(uiot, "MobilityStation") |> PrefixedName
    /// <summary>
    ///   <para>uiot:SensorRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Sensor Record aggregates a set of observations associated to the same timestamp and the same sensor."</para>
    ///   <para>"Un Record del Sensore aggrega un insieme di campionamenti associati allo stesso timestamp e allo stesso sensore."</para>
    /// labels<para>"Record del Sensore"</para><para>"Sensor Record"</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/core#SensorRecord">http://www.w3id.org/urban-iot/core#SensorRecord</seealso>
    let SensorRecord = Prefixed_Name(uiot, "SensorRecord") |> PrefixedName
    /// <summary>
    ///   <para>uiot:ServiceBusinessUser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Entità Legale con contratto business per accedere al servizio. Un Utente Business non può utilizzare direttamente il servizio ma può abilitare un Utente Privato del Servizio a farlo."</para>
    ///   <para>"Legal Entity with a business contract for the service. A Service Business User can not directly use the service but can enable a Service Private User to do so."</para>
    /// labels<para>"Service Business User"</para><para>"Utente Business del Servizio"</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/core#ServiceBusinessUser">http://www.w3id.org/urban-iot/core#ServiceBusinessUser</seealso>
    let ServiceBusinessUser = Prefixed_Name(uiot, "ServiceBusinessUser") |> PrefixedName
    /// <summary>
    ///   <para>uiot:ServicePrivateUser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Una persona fisica utilizzatore di un servizio."</para>
    ///   <para>"A natural person using a service."</para>
    /// labels<para>"Service Private User"</para><para>"Utente Privato del Servizio"</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/core#ServicePrivateUser">http://www.w3id.org/urban-iot/core#ServicePrivateUser</seealso>
    let ServicePrivateUser = Prefixed_Name(uiot, "ServicePrivateUser") |> PrefixedName
    /// <summary>
    ///   <para>uiot:ServiceResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Risorsa messa a disposizione da un Servizio che può essere utilizzata in una Sessione di Utilizzo."</para>
    ///   <para>"A Resource made available by a Service to be used in a Usage Session."</para>
    /// labels<para>"Service Resource"</para><para>"Risorsa del Servizio"</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/core#ServiceResource">http://www.w3id.org/urban-iot/core#ServiceResource</seealso>
    let ServiceResource = Prefixed_Name(uiot, "ServiceResource") |> PrefixedName
    /// <summary>
    ///   <para>uiot:ServiceUser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A User using a Service."</para>
    ///   <para>"Utente utilizzatore di un Servizio."</para>
    /// labels<para>"Service User"</para><para>"Utente del Servizio"</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/core#ServiceUser">http://www.w3id.org/urban-iot/core#ServiceUser</seealso>
    let ServiceUser = Prefixed_Name(uiot, "ServiceUser") |> PrefixedName
    /// <summary>
    ///   <para>uiot:UsageSession</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Una Sessione di Utilizzo è un Evento associato ad un Servizio e ad una Risorsa del Servizio che rappresenta un utilizzo della risorsa resa disponibile dal Servizio."</para>
    ///   <para>"A Usage Session is an Event associated to a Service and a Service Resource representing a usage of the resource made available by the Service."</para>
    /// labels<para>"Sessione di Utilizzo"</para><para>"Usage Session"</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/core#UsageSession">http://www.w3id.org/urban-iot/core#UsageSession</seealso>
    let UsageSession = Prefixed_Name(uiot, "UsageSession") |> PrefixedName
    /// <summary>
    ///   <para>uiot:associatedBusiness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associa una Sessione di Utilizzo all'Utente Business del Servizio che la abilita."</para>
    ///   <para>"Associates a Usage Session with the Service Business User enabling it."</para>
    /// labels<para>"business associato"</para><para>"associated business"</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/core#associatedBusiness">http://www.w3id.org/urban-iot/core#associatedBusiness</seealso>
    let associatedBusiness = Prefixed_Name(uiot, "associatedBusiness") |> PrefixedName
    /// <summary>
    ///   <para>uiot:birthYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Associates a person with her/his birth year."</para>
    ///   <para>"Associa una persona al suo anno di nascita."</para>
    /// labels<para>"anno di nascita"</para><para>"birth year"</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/core#birthYear">http://www.w3id.org/urban-iot/core#birthYear</seealso>
    let birthYear = Prefixed_Name(uiot, "birthYear") |> PrefixedName
    /// <summary>
    ///   <para>uiot:containsObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associa un Record del Sensore ad un Campionamento contenuto nel record."</para>
    ///   <para>"Associates a Sensor Record with a Observation contained in it."</para>
    /// labels<para>"contains observation"</para><para>"contiene campionamento"</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/core#containsObservation">http://www.w3id.org/urban-iot/core#containsObservation</seealso>
    let containsObservation = Prefixed_Name(uiot, "containsObservation") |> PrefixedName
    /// <summary>
    ///   <para>uiot:deregistrationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Data in cui l'Utente del Servizio ha chiesto la cancellazione della registrazione dal Servizio."</para>
    ///   <para>"Date in which a Service User deregistered from a Service."</para>
    /// labels<para>"data di disdetta"</para><para>"deregistration date"</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/core#deregistrationDate">http://www.w3id.org/urban-iot/core#deregistrationDate</seealso>
    let deregistrationDate = Prefixed_Name(uiot, "deregistrationDate") |> PrefixedName
    /// <summary>
    ///   <para>uiot:enablesSession</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associa un Servizio ad una Sessione di Utilizzo abilitata dal Servizio."</para>
    ///   <para>"Associates a Service with a Usage Session enabled by the service."</para>
    /// labels<para>"enables session"</para><para>"abilita sessione"</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/core#enablesSession">http://www.w3id.org/urban-iot/core#enablesSession</seealso>
    let enablesSession = Prefixed_Name(uiot, "enablesSession") |> PrefixedName
    /// <summary>
    ///   <para>uiot:fixedAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Associates an Offer with a fixed amount required from it."</para>
    ///   <para>"Indica un costo fisso dell'Offerta."</para>
    /// labels<para>"costo fisso"</para><para>"fixed amount"</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/core#fixedAmount">http://www.w3id.org/urban-iot/core#fixedAmount</seealso>
    let fixedAmount = Prefixed_Name(uiot, "fixedAmount") |> PrefixedName
    /// <summary>
    ///   <para>uiot:hasEnabledUser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associates a Service Business User with the Service Private User enabled by that business user."</para>
    ///   <para>"Associa un Utente Business del Servizio ad un Utente Privato abilitato dall'utenza business."</para>
    /// labels<para>"ha utente abilitato"</para><para>"has enabled user"</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/core#hasEnabledUser">http://www.w3id.org/urban-iot/core#hasEnabledUser</seealso>
    let hasEnabledUser = Prefixed_Name(uiot, "hasEnabledUser") |> PrefixedName
    /// <summary>
    ///   <para>uiot:hasUser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associates a Service to a Service User."</para>
    ///   <para>"Associa un Servizio ad un Utente del Servizio."</para>
    /// labels<para>"has user"</para><para>"ha utente"</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/core#hasUser">http://www.w3id.org/urban-iot/core#hasUser</seealso>
    let hasUser = Prefixed_Name(uiot, "hasUser") |> PrefixedName

    /// <summary>
    ///   <para>uiot:includedInMobilityStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associa una Stazione di Mobilità ad una Stazione di Mobilità che la include."</para>
    ///   <para>"Associates a Mobility Station with another Mobility Station including it."</para>
    /// labels<para>"included in mobility station"</para><para>"inclusa nella stazione di mobilità"</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/core#includedInMobilityStation">http://www.w3id.org/urban-iot/core#includedInMobilityStation</seealso>
    let includedInMobilityStation =
        Prefixed_Name(uiot, "includedInMobilityStation") |> PrefixedName

    /// <summary>
    ///   <para>uiot:latestRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associates a Sensor with the latest registered Sensor Record."</para>
    ///   <para>"Associa un Sensore all'ultimo Record del Sensore registrato."</para>
    /// labels<para>"ultimo record"</para><para>"latest record"</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/core#latestRecord">http://www.w3id.org/urban-iot/core#latestRecord</seealso>
    let latestRecord = Prefixed_Name(uiot, "latestRecord") |> PrefixedName
    /// <summary>
    ///   <para>uiot:madeAvailableBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associa una Risorsa del Servizio al Servizio che la rende disponibile."</para>
    ///   <para>"Associates a Service Resource with the Service making it available."</para>
    /// labels<para>"made available by"</para><para>"resa disponibile da"</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/core#madeAvailableBy">http://www.w3id.org/urban-iot/core#madeAvailableBy</seealso>
    let madeAvailableBy = Prefixed_Name(uiot, "madeAvailableBy") |> PrefixedName
    /// <summary>
    ///   <para>uiot:makesAvailable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associa un Servizio ad una risorsa che rende disponibile."</para>
    ///   <para>"Associates a Service with the Service Resource that makes available."</para>
    /// labels<para>"makes available"</para><para>"rende disponibile"</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/core#makesAvailable">http://www.w3id.org/urban-iot/core#makesAvailable</seealso>
    let makesAvailable = Prefixed_Name(uiot, "makesAvailable") |> PrefixedName
    /// <summary>
    ///   <para>uiot:observationIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associates an Observation with the Sensor Record containing it."</para>
    ///   <para>"Associa un Campionamento al Record del Sensore di cui fa parte."</para>
    /// labels<para>"observation in"</para><para>"campionamento in"</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/core#observationIn">http://www.w3id.org/urban-iot/core#observationIn</seealso>
    let observationIn = Prefixed_Name(uiot, "observationIn") |> PrefixedName
    /// <summary>
    ///   <para>uiot:offerAssociated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associates a Usage Session with the tariff (Offer) applied to the specific session."</para>
    ///   <para>"Associa una Sessione di Utilizzo alla tariffa (Offerta) applicata alla specifica sessione."</para>
    /// labels<para>"offerta associata"</para><para>"offer associated"</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/core#offerAssociated">http://www.w3id.org/urban-iot/core#offerAssociated</seealso>
    let offerAssociated = Prefixed_Name(uiot, "offerAssociated") |> PrefixedName
    /// <summary>
    ///   <para>uiot:performsSession</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associa un Utente Privato del Servizio ad una Sessione di Utilizzo effettuata."</para>
    ///   <para>"Associates a Service Private User with a Usage Session performed."</para>
    /// labels<para>"effettua sessione"</para><para>"performs session"</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/core#performsSession">http://www.w3id.org/urban-iot/core#performsSession</seealso>
    let performsSession = Prefixed_Name(uiot, "performsSession") |> PrefixedName
    /// <summary>
    ///   <para>uiot:recordRegisteredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associa un Record del Sensore al Sensore che lo ha registrato."</para>
    ///   <para>"Associates a Sensor Record with the Sensor registering it."</para>
    /// labels<para>"record registrato da"</para><para>"record registered by"</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/core#recordRegisteredBy">http://www.w3id.org/urban-iot/core#recordRegisteredBy</seealso>
    let recordRegisteredBy = Prefixed_Name(uiot, "recordRegisteredBy") |> PrefixedName
    /// <summary>
    ///   <para>uiot:recordTimestamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Timestamp associated with a Sensor Record."</para>
    ///   <para>"Timestamp associato ad un Record del Sensore."</para>
    /// labels<para>"timestamp del record"</para><para>"record timestamp"</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/core#recordTimestamp">http://www.w3id.org/urban-iot/core#recordTimestamp</seealso>
    let recordTimestamp = Prefixed_Name(uiot, "recordTimestamp") |> PrefixedName
    /// <summary>
    ///   <para>uiot:registeredTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associa un Utente al Servizio a cui è registrato."</para>
    ///   <para>"Associates a Service User to the Service to which the user is registered to."</para>
    /// labels<para>"registered to"</para><para>"registrato a"</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/core#registeredTo">http://www.w3id.org/urban-iot/core#registeredTo</seealso>
    let registeredTo = Prefixed_Name(uiot, "registeredTo") |> PrefixedName
    /// <summary>
    ///   <para>uiot:registersRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associates a Sensor with a registered Sensor Record."</para>
    ///   <para>"Associa un Sensore ad un Record del Sensore."</para>
    /// labels<para>"registra record"</para><para>"registers record"</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/core#registersRecord">http://www.w3id.org/urban-iot/core#registersRecord</seealso>
    let registersRecord = Prefixed_Name(uiot, "registersRecord") |> PrefixedName
    /// <summary>
    ///   <para>uiot:registrationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Data di registrazione dell'Utente del Servizio al Servizio."</para>
    ///   <para>"Date in which a Service User registered to the Service."</para>
    /// labels<para>"data di registrazione"</para><para>"registration date"</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/core#registrationDate">http://www.w3id.org/urban-iot/core#registrationDate</seealso>
    let registrationDate = Prefixed_Name(uiot, "registrationDate") |> PrefixedName
    /// <summary>
    ///   <para>uiot:reservationUsed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indica se un meccanismo di prenotazione è stato utilizzato per una Sessione di Utilizzo."</para>
    ///   <para>"Indicates whether a reservation mechanism has been used for a Usage Session."</para>
    /// labels<para>"reservation used"</para><para>"prenotazione utilizzata"</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/core#reservationUsed">http://www.w3id.org/urban-iot/core#reservationUsed</seealso>
    let reservationUsed = Prefixed_Name(uiot, "reservationUsed") |> PrefixedName
    /// <summary>
    ///   <para>uiot:resourceUsedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associates a Service Resource with a Usage Session using it."</para>
    ///   <para>"Associa una Risorsa del Servizio ad una Sessione di Utilizzo in cui è stata utilizzata."</para>
    /// labels<para>"resource used in"</para><para>"risorsa usata in"</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/core#resourceUsedIn">http://www.w3id.org/urban-iot/core#resourceUsedIn</seealso>
    let resourceUsedIn = Prefixed_Name(uiot, "resourceUsedIn") |> PrefixedName
    /// <summary>
    ///   <para>uiot:serialNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indication of the serial number."</para>
    ///   <para>"Indicazione del numero seriale."</para>
    /// labels<para>"serial number"</para><para>"numero seriale"</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/core#serialNumber">http://www.w3id.org/urban-iot/core#serialNumber</seealso>
    let serialNumber = Prefixed_Name(uiot, "serialNumber") |> PrefixedName
    /// <summary>
    ///   <para>uiot:sessionEnabledBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associa una Sessione di Utilizzo al Servizio che la abilita."</para>
    ///   <para>"Associates a Usage Session with the Service enabling it."</para>
    /// labels<para>"sessione abilitata da"</para><para>"session enabled by"</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/core#sessionEnabledBy">http://www.w3id.org/urban-iot/core#sessionEnabledBy</seealso>
    let sessionEnabledBy = Prefixed_Name(uiot, "sessionEnabledBy") |> PrefixedName
    /// <summary>
    ///   <para>uiot:sessionPerformedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associa una Sessione di Utilizzo all'Utente Privato del Servizio che la effettua."</para>
    ///   <para>"Associates a Usage Session with the Service Private User performing it."</para>
    /// labels<para>"session performed by"</para><para>"sessione effettuata da"</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/core#sessionPerformedBy">http://www.w3id.org/urban-iot/core#sessionPerformedBy</seealso>
    let sessionPerformedBy = Prefixed_Name(uiot, "sessionPerformedBy") |> PrefixedName
    /// <summary>
    ///   <para>uiot:userEnabledBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associa un Utente Privato del Servizio all'Utente Business che lo abilita."</para>
    ///   <para>"Associates a Service Private User to the Service Business User enabling it."</para>
    /// labels<para>"user enabled by"</para><para>"utente abilitato da"</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/core#userEnabledBy">http://www.w3id.org/urban-iot/core#userEnabledBy</seealso>
    let userEnabledBy = Prefixed_Name(uiot, "userEnabledBy") |> PrefixedName
    /// <summary>
    ///   <para>uiot:userOfService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associa un Utente del Servizio al Servizio che utilizza."</para>
    ///   <para>"Associates a Service User to the Service used."</para>
    /// labels<para>"utente del servizio"</para><para>"user of service"</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/core#userOfService">http://www.w3id.org/urban-iot/core#userOfService</seealso>
    let userOfService = Prefixed_Name(uiot, "userOfService") |> PrefixedName
    /// <summary>
    ///   <para>uiot:usesResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associates a Usage Session with the Service Resource used in the session."</para>
    ///   <para>"Associa una Sessione di Utilizzo alla Risorsa del Servizio utilizzata."</para>
    /// labels<para>"uses resource"</para><para>"utilizza risorsa"</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/core#usesResource">http://www.w3id.org/urban-iot/core#usesResource</seealso>
    let usesResource = Prefixed_Name(uiot, "usesResource") |> PrefixedName
