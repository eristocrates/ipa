#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module uiote =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.w3id.org/urban-iot/electric#" "uiote"

    /// <summary>
    ///   <para>rdfs:label : Operatore del Punto di Ricaricardfs:label : Charge Point Operator</para>
    ///   <para>rdfs:comment : Organizzazione che gestisce l'erogazione di corrente presso le Stazioni di Ricarica.rdfs:comment : Organization that manages the supply of electricity in the Charging Stations.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#ChargePointOperator">uiote:ChargePointOperator</a>
    /// </summary>
    let ChargePointOperator = _prefixId.prefix "ChargePointOperator"
    /// <summary>
    ///   <para>rdfs:label : Servizio di Ricaricardfs:label : Charging Service</para>
    ///   <para>rdfs:comment : Servizio operato da un Gestore di Servizi per la ricarica elettrica, con il fine di gestire l'utilizzo di Colonnine di Ricarica (EVSE).rdfs:comment : Service operated by an eMobility Service Provider, with the purpose to manage the use of Electric Vehicle Supply Equipments (EVSE).</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#ChargingService">uiote:ChargingService</a>
    /// </summary>
    let ChargingService = _prefixId.prefix "ChargingService"
    /// <summary>
    ///   <para>rdfs:label : Tariffa per Servizi di Ricaricardfs:label : Charging Service Offer</para>
    ///   <para>rdfs:comment : Tariffa offerta agli Utenti dei Servizi di Ricarica.rdfs:comment : Tariff offered to charge services Users.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#ChargingServiceOffer">uiote:ChargingServiceOffer</a>
    /// </summary>
    let ChargingServiceOffer = _prefixId.prefix "ChargingServiceOffer"
    /// <summary>
    ///   <para>rdfs:label : Sessione di Ricaricardfs:label : Charging Session</para>
    ///   <para>rdfs:comment : Sessione dove un utente richiede la carica del proprio veicolo, con tutte le informazioni collegate a questa attività.rdfs:comment : Session where a\n user asks to a charge for his vehicle, with all the information related to this activity.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#ChargingSession">uiote:ChargingSession</a>
    /// </summary>
    let ChargingSession = _prefixId.prefix "ChargingSession"
    /// <summary>
    ///   <para>rdfs:label : Stazione di Ricaricardfs:label : Charging Station</para>
    ///   <para>rdfs:comment : Place where it is possible to recharge vehicles, that includes both Electric Vehicle Supply Equipments (EVSE) and the parking areas to allow the vehicle stop during the charging activity.rdfs:comment : Luogo dove si possono ricaricare veicoli elettrici, comprensivo sia di Colonnine di Ricarica per Veicoli Elettrici (EVSE) che delle aree di sosta per lasciare il veicolo durante la ricarica.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#ChargingStation">uiote:ChargingStation</a>
    /// </summary>
    let ChargingStation = _prefixId.prefix "ChargingStation"
    /// <summary>
    ///   <para>rdfs:label : Connettorerdfs:label : Connector</para>
    ///   <para>rdfs:comment : Connettore collegato a una Colonnina di Ricarica per Veicoli Elettrici (EVSE).rdfs:comment : Connector related to an Electric Vehicle Supply Equipment (EVSE).</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#Connector">uiote:Connector</a>
    /// </summary>
    let Connector = _prefixId.prefix "Connector"
    /// <summary>
    ///   <para>rdfs:label : Electric Vehicle Supply Equipment (EVSE)rdfs:label : Colonnina di Ricarica per Veicoli Elettrici (EVSE)</para>
    ///   <para>rdfs:comment : Electric Vehicle Supply Equipment (EVSE) available for charging vehicles.rdfs:comment : Colonnina di Ricarica (EVSE) messa a disposizione per la ricarica di veicoli elettrici.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#EVSE">uiote:EVSE</a>
    /// </summary>
    let EVSE = _prefixId.prefix "EVSE"
    let EVSE_state = _prefixId.prefix "EVSE-state"
    /// <summary>
    ///   <para>rdfs:label : Stato della Colonnina di Ricaricardfs:label : Electric Vehicle Supply Equipment Record</para>
    ///   <para>rdfs:comment : Registrazione dello stato in cui si trova nei vari momenti la Colonnina di Ricarica (EVSE): in carica, disponibile, inattiva, etc.rdfs:comment : Registration status for the Electric Vehicle Supply Equipment (EVSE): in charge, available, inoperative, ecc.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#EVSERecord">uiote:EVSERecord</a>
    /// </summary>
    let EVSERecord = _prefixId.prefix "EVSERecord"
    /// <summary>
    ///   <para>rdfs:label : stato dell'EVSErdfs:label : EVSE state</para>
    ///   <para>rdfs:comment : Connection to possible states for an EVSE (Electric Vehicle Supply Equipment).rdfs:comment : Associazioni a possibili stati  in cui una Colonnina per la Ricarica Veicoli Elettrici (EVSE) può trovarsi.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#EVSEState">uiote:EVSEState</a>
    /// </summary>
    let EVSEState = _prefixId.prefix "EVSEState"
    /// <summary>
    ///   <para>rdfs:label : ricarica durante la chiusurardfs:label : charging during closure</para>
    ///   <para>rdfs:comment : Tempo di ricarica trascorso durante la chiusura del servizio.rdfs:comment : Charging time during the closure of the service.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#chargingDuringClosure">uiote:chargingDuringClosure</a>
    /// </summary>
    let chargingDuringClosure = _prefixId.prefix "chargingDuringClosure"
    /// <summary>
    ///   <para>rdfs:label : ricarica abilitata dardfs:label : charging enabled by</para>
    ///   <para>rdfs:comment : Associates a Charging Station to a Charging Service which enabled it.rdfs:comment : Associa una Stazione di Ricarica ad un Servizio di Ricarica che l'abilita.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#chargingEnabledBy">uiote:chargingEnabledBy</a>
    /// </summary>
    let chargingEnabledBy = _prefixId.prefix "chargingEnabledBy"
    /// <summary>
    ///   <para>rdfs:label : ricarica effettuata dardfs:label : charging performed by</para>
    ///   <para>rdfs:comment : Associates a Charging Session with a Service Private User who performs the Session.rdfs:comment : Associa una Sessione di Ricarica all'Utente Privato del Servizio che la esegue.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#chargingPerformedBy">uiote:chargingPerformedBy</a>
    /// </summary>
    let chargingPerformedBy = _prefixId.prefix "chargingPerformedBy"
    /// <summary>
    ///   <para>rdfs:label : durata sessione di ricaricardfs:label : charging session duration</para>
    ///   <para>rdfs:comment : Indicates the duration of a Charging Session.rdfs:comment : Indica la durata di una determinata Sessione di Ricarica.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#chargingSessionDuration">uiote:chargingSessionDuration</a>
    /// </summary>
    let chargingSessionDuration = _prefixId.prefix "chargingSessionDuration"
    /// <summary>
    ///   <para>rdfs:label : stazione di ricarica usata inrdfs:label : charging station used in</para>
    ///   <para>rdfs:comment : Associates a Charging Station to a Charging Session where the Station is used.rdfs:comment : Associa una Stazione di Ricarica ad una Sessione di Ricarica che la utilizza.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#chargingStationUsedIn">uiote:chargingStationUsedIn</a>
    /// </summary>
    let chargingStationUsedIn = _prefixId.prefix "chargingStationUsedIn"
    /// <summary>
    ///   <para>rdfs:label : eMobility Service Providerrdfs:label : Gestore di Servizi per la Ricarica Elettica</para>
    ///   <para>rdfs:comment : Organizzazione che fornisce il Servizio di Ricarica.rdfs:comment : Organization which offers the Charging Service</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#eMobilityServiceProvider">uiote:eMobilityServiceProvider</a>
    /// </summary>
    let eMobilityServiceProvider = _prefixId.prefix "eMobilityServiceProvider"
    /// <summary>
    ///   <para>rdfs:label : enables chargingrdfs:label : abilita la ricarica</para>
    ///   <para>rdfs:comment : Un Servizio di Ricarica abilita Sessioni di Ricarica.rdfs:comment : A Charging Service can enable Charging Sessions</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#enablesCharging">uiote:enablesCharging</a>
    /// </summary>
    let enablesCharging = _prefixId.prefix "enablesCharging"
    /// <summary>
    ///   <para>rdfs:label : numero di pianordfs:label : floor level</para>
    ///   <para>rdfs:comment : Piano al quale è installata la colonnina di ricarica per veicoli elettrici (EVSE).rdfs:comment : Floore level where the Electric Vehicle Supply Equimpment (EVSE) is installed.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#floorLevel">uiote:floorLevel</a>
    /// </summary>
    let floorLevel = _prefixId.prefix "floorLevel"
    /// <summary>
    ///   <para>rdfs:label : has charge access methodrdfs:label : ha un metodo di accesso alla ricarica</para>
    ///   <para>rdfs:comment : Associazione di una Colonnina di Ricarica per Veicoli Elettrici (EVSE) a possibili metodi per attivare la ricarica.rdfs:comment : Association for an Electric Vehicle Supply Equipment (EVSE) to possible methods to activate the charge.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#hasChargeAccessMethod">uiote:hasChargeAccessMethod</a>
    /// </summary>
    let hasChargeAccessMethod = _prefixId.prefix "hasChargeAccessMethod"
    /// <summary>
    ///   <para>rdfs:label : has charging service offerrdfs:label : ha un'offerta di ricarica</para>
    ///   <para>rdfs:comment : Associazine tra una Stazione di Ricarica e un'Offerta di Ricarica.rdfs:comment : Associates a Charging Station to a Charging Offer.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#hasChargingServiceOffer">uiote:hasChargingServiceOffer</a>
    /// </summary>
    let hasChargingServiceOffer = _prefixId.prefix "hasChargingServiceOffer"
    /// <summary>
    ///   <para>rdfs:label : possiede una stazione di ricaricardfs:label : has charging station owner</para>
    ///   <para>rdfs:comment : Associates an Organization with a Charging Station, where the Organization owns the Station.rdfs:comment : Associa una Organizzazione a una Stazione di Ricarica, dove l'Organizzazione possiede la Stazione.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#hasChargingStationOwner">uiote:hasChargingStationOwner</a>
    /// </summary>
    let hasChargingStationOwner = _prefixId.prefix "hasChargingStationOwner"
    /// <summary>
    ///   <para>rdfs:label : has connectorrdfs:label : ha un connettore</para>
    ///   <para>rdfs:comment : Associates a Connector to an Electric Vehicle Supply Equipment (EVSE).rdfs:comment : Associa un Connettore ad una Colonnina di Ricarica per Veicoli Elettrici (EVSE).</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#hasConnector">uiote:hasConnector</a>
    /// </summary>
    let hasConnector = _prefixId.prefix "hasConnector"
    /// <summary>
    ///   <para>rdfs:label : has EVSErdfs:label : ha un EVSE</para>
    ///   <para>rdfs:comment : Associates a Charging Station to an Electric Vehicle Supply Equipment (EVSE).rdfs:comment : Associa una Stazione di Ricarica a una Colonnina per la Ricarica di Veicoli Elettrici (EVSE).</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#hasEVSE">uiote:hasEVSE</a>
    /// </summary>
    let hasEVSE = _prefixId.prefix "hasEVSE"
    /// <summary>
    ///   <para>rdfs:label : has EVSE Charge Categoryrdfs:label : ha una categoria di ricarica per EVSE</para>
    ///   <para>rdfs:comment : Associates a Electric Vehicle Supply Equipment (EVSE) to the possible charge categories.rdfs:comment : Associa una Colonnina di Ricarica per Veicoli Elettirci (EVSE) alle possibili categorie di ricarica.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#hasEVSEChargeCategory">uiote:hasEVSEChargeCategory</a>
    /// </summary>
    let hasEVSEChargeCategory = _prefixId.prefix "hasEVSEChargeCategory"
    /// <summary>
    ///   <para>rdfs:label : has facility near byrdfs:label : ha punti di interesse vicini</para>
    ///   <para>rdfs:comment : Associates a Charging station with the possible point of interest near by, represented as Place.rdfs:comment : Associa una Stazione di Ricarica ai possibili punti di interesse in zona, rappresentati come Luogo.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#hasFacilityNearBy">uiote:hasFacilityNearBy</a>
    /// </summary>
    let hasFacilityNearBy = _prefixId.prefix "hasFacilityNearBy"
    /// <summary>
    ///   <para>rdfs:label : has parking restrictionrdfs:label : ha restrizioni di parcheggio</para>
    ///   <para>rdfs:comment : Associates an Electric Vehicle Supply Equipment (EVSE) to possible parking restrictions to use the charging service.rdfs:comment : Associa una Colonnina di Ricarica per Veicoli Elettrici (EVSE) a possibili restrizioni di sosta per poter sfruttare il servizio.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#hasParkingRestriction">uiote:hasParkingRestriction</a>
    /// </summary>
    let hasParkingRestriction = _prefixId.prefix "hasParkingRestriction"
    /// <summary>
    ///   <para>rdfs:label : has power supplyrdfs:label : ha tipi di alimentazione</para>
    ///   <para>rdfs:comment : Associates a Connector to possible power supplies.rdfs:comment : Associa un Connettore ai possibili tipi di alimentazione.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#hasPowerSupply">uiote:hasPowerSupply</a>
    /// </summary>
    let hasPowerSupply = _prefixId.prefix "hasPowerSupply"
    /// <summary>
    ///   <para>rdfs:label : has standardrdfs:label : ha standard</para>
    ///   <para>rdfs:comment : Associates a Connector to possible standard.rdfs:comment : Associa un Connettore ai possibili standard di prese.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#hasStandard">uiote:hasStandard</a>
    /// </summary>
    let hasStandard = _prefixId.prefix "hasStandard"
    /// <summary>
    ///   <para>rdfs:label : has sub charge point operatorrdfs:label : ha un sub operatore di ricarica</para>
    ///   <para>rdfs:comment : Associates a Charging Station to a possible sub operator, identified as an Organization.rdfs:comment : Associa una Stazione di Ricarica a un possibile sub operatore, identificato come Organizzazione.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#hasSubChargePointOperator">uiote:hasSubChargePointOperator</a>
    /// </summary>
    let hasSubChargePointOperator = _prefixId.prefix "hasSubChargePointOperator"
    /// <summary>
    ///   <para>rdfs:label : è connettore dirdfs:label : is connector of</para>
    ///   <para>rdfs:comment : Associates a Connector to an Electric Vehicle Supply Equipment (EVSE).rdfs:comment : Associa un Connettore ad una Colonnina di Ricarica per Veicoli Elettrici (EVSE).</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#isConnectorOf">uiote:isConnectorOf</a>
    /// </summary>
    let isConnectorOf = _prefixId.prefix "isConnectorOf"
    /// <summary>
    ///   <para>rdfs:label : è EVSE dirdfs:label : is EVSE of</para>
    ///   <para>rdfs:comment : Associates an Electric Vehicle Supply Equipment (EVSE) to a Charging Station.rdfs:comment : Associa una Colonnina di Ricarica per Veicoli Elettrici (EVSE) ad una Stazione di Ricarica.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#isEVSEOf">uiote:isEVSEOf</a>
    /// </summary>
    let isEVSEOf = _prefixId.prefix "isEVSEOf"
    /// <summary>
    ///   <para>rdfs:label : è privatardfs:label : is private</para>
    ///   <para>rdfs:comment : Indicates if a Charging Station is private or public.rdfs:comment : Indica se una Stazione di Ricarica sia privata o pubblica.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#isPrivate">uiote:isPrivate</a>
    /// </summary>
    let isPrivate = _prefixId.prefix "isPrivate"
    /// <summary>
    ///   <para>rdfs:label : rende la stazione disponibilerdfs:label : makes station available</para>
    ///   <para>rdfs:comment : Associates a Charging Service to a Charging Station, made available by the Service.rdfs:comment : Associa un Servizio di Ricarica ad una Stazione di Ricarica, resa disponibile dal servizio.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#makesStationAvailable">uiote:makesStationAvailable</a>
    /// </summary>
    let makesStationAvailable = _prefixId.prefix "makesStationAvailable"
    /// <summary>
    ///   <para>rdfs:label : max amperage in Ardfs:label : massimo amperaggio in A</para>
    ///   <para>rdfs:comment : It is the maximum amperage expressed in Ampere for a Connector.rdfs:comment : Indica il massimo amperaggio in Ampere per un Connettore.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#maxAmperageInA">uiote:maxAmperageInA</a>
    /// </summary>
    let maxAmperageInA = _prefixId.prefix "maxAmperageInA"
    /// <summary>
    ///   <para>rdfs:label : max power in kWrdfs:label : massima potenza in kW</para>
    ///   <para>rdfs:comment : It is the maximum power expressed in kWatt for a Connector.rdfs:comment : Indica la massima potenza in kWatt per un Connettore.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#maxPowerInKW">uiote:maxPowerInKW</a>
    /// </summary>
    let maxPowerInKW = _prefixId.prefix "maxPowerInKW"
    /// <summary>
    ///   <para>rdfs:label : max voltage in Vrdfs:label : massimo voltaggio in V</para>
    ///   <para>rdfs:comment : It is the maximum voltage expressed in Volt for a Connector.rdfs:comment : Indica il massimo voltaggio in Volt per un Connettore.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#maxVoltageInV">uiote:maxVoltageInV</a>
    /// </summary>
    let maxVoltageInV = _prefixId.prefix "maxVoltageInV"
    /// <summary>
    ///   <para>rdfs:label : minimo amperaggio in Ardfs:label : min amperage in A</para>
    ///   <para>rdfs:comment : It is the minimum amperage expressed in Ampere for a Connector.rdfs:comment : Indica il minimo amperaggio in Ampere per un Connettore.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#minAmperageInA">uiote:minAmperageInA</a>
    /// </summary>
    let minAmperageInA = _prefixId.prefix "minAmperageInA"
    /// <summary>
    ///   <para>rdfs:label : minima potenza in kWrdfs:label : min power in kW</para>
    ///   <para>rdfs:comment : It is the minimum power expressed in kWatt for a Connector.rdfs:comment : Indica la minima potenza in kWatt per un Connettore.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#minPowerInKW">uiote:minPowerInKW</a>
    /// </summary>
    let minPowerInKW = _prefixId.prefix "minPowerInKW"
    /// <summary>
    ///   <para>rdfs:label : minimo voltaggio in Vrdfs:label : min voltage in V</para>
    ///   <para>rdfs:comment : It is the minimum voltage expressed in Volt for a Connector.rdfs:comment : Indica il minimo voltaggio in Volt per un Connettore.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#minVoltageInV">uiote:minVoltageInV</a>
    /// </summary>
    let minVoltageInV = _prefixId.prefix "minVoltageInV"
    /// <summary>
    ///   <para>rdfs:label : operato dardfs:label : operated by</para>
    ///   <para>rdfs:comment : Associates a Charging Station to a Charge Point Operator who operates it allowing the electricity supply.rdfs:comment : Associa una Stazione di Ricarica all'Operatore del Punto di Ricarica che l'aziona dal punto di vista dell'erogazione di elettricità.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#operatedBy">uiote:operatedBy</a>
    /// </summary>
    let operatedBy = _prefixId.prefix "operatedBy"
    /// <summary>
    ///   <para>rdfs:label : operatesrdfs:label : opera</para>
    ///   <para>rdfs:comment : Associates a Chage Point Operator to a Charging Station, which is operated by the Operator.rdfs:comment : Associa un Operatore del Punto di Ricarica ad una Stazione di Ricarica, che viene azionata dall'Operatore.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#operates">uiote:operates</a>
    /// </summary>
    let operates = _prefixId.prefix "operates"
    /// <summary>
    ///   <para>rdfs:label : operates sessionrdfs:label : opera sessione</para>
    ///   <para>rdfs:comment : Associates a Charge Point Operator to a Charging Session which involves him.rdfs:comment : Associa un Operatore Punto del Ricarica ad una Sessione di Ricarica che lo coinvolge.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#operatesSession">uiote:operatesSession</a>
    /// </summary>
    let operatesSession = _prefixId.prefix "operatesSession"
    /// <summary>
    ///   <para>rdfs:label : performs chargingrdfs:label : opera ricarica</para>
    ///   <para>rdfs:comment : Associates a Service Private User to a Charging Session, perfrmed by the User.rdfs:comment : Associa un Utente Privato del Servizio ad una Sessione di Ricarica, eseguita dall'Utente stesso.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#performsCharging">uiote:performsCharging</a>
    /// </summary>
    let performsCharging = _prefixId.prefix "performsCharging"
    /// <summary>
    ///   <para>rdfs:label : price per kWh chargerdfs:label : prezzo al kWh di ricarica</para>
    ///   <para>rdfs:comment : Price expressed per kWh of charge.rdfs:comment : Prezzo espresso in base ai kWh di ricarica.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#pricePerKWhCharge">uiote:pricePerKWhCharge</a>
    /// </summary>
    let pricePerKWhCharge = _prefixId.prefix "pricePerKWhCharge"
    /// <summary>
    ///   <para>rdfs:label : price per minute chargerdfs:label : prezzo al minuto di ricarica</para>
    ///   <para>rdfs:comment : Price expressed per minutes of charge.rdfs:comment : Prezzo espresso in base ai minuti di ricarica.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#pricePerMinuteCharge">uiote:pricePerMinuteCharge</a>
    /// </summary>
    let pricePerMinuteCharge = _prefixId.prefix "pricePerMinuteCharge"
    /// <summary>
    ///   <para>rdfs:label : price per minute parkingrdfs:label : prezzo al minuto di parcheggio</para>
    ///   <para>rdfs:comment : Price expressed per minute of parking.rdfs:comment : Prezzo espresso in base ai minuti di parcheggio.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#pricePerMinuteParking">uiote:pricePerMinuteParking</a>
    /// </summary>
    let pricePerMinuteParking = _prefixId.prefix "pricePerMinuteParking"
    /// <summary>
    ///   <para>rdfs:label : price per month chargerdfs:label : prezzo per mese di ricarica</para>
    ///   <para>rdfs:comment : Price expressed per month of charge.rdfs:comment : Prezzo espresso in base al mese per ricarica.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#pricePerMonthCharge">uiote:pricePerMonthCharge</a>
    /// </summary>
    let pricePerMonthCharge = _prefixId.prefix "pricePerMonthCharge"
    /// <summary>
    ///   <para>rdfs:label : provides cablerdfs:label : fornisce cavo</para>
    ///   <para>rdfs:comment : Indicates the presence of a cable for the Connector.rdfs:comment : Indica la presenza di cavo o meno, per un Connettore.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#providesCable">uiote:providesCable</a>
    /// </summary>
    let providesCable = _prefixId.prefix "providesCable"
    /// <summary>
    ///   <para>rdfs:label : provides charging servicerdfs:label : offre servizio di ricarica</para>
    ///   <para>rdfs:comment : Associates an eMobility Service Provider to a Charging Service provided by him.rdfs:comment : Associa un Gestore di Servizi per la Mobilità Elettrica ad un Servizio di Ricarica che fornisce.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#providesChargingService">uiote:providesChargingService</a>
    /// </summary>
    let providesChargingService = _prefixId.prefix "providesChargingService"
    /// <summary>
    ///   <para>rdfs:label : tempo di ricarica in minutirdfs:label : recharge time in min</para>
    ///   <para>rdfs:comment : Indicates the charging time expressed in minutes for a Charging Session.rdfs:comment : Indica il tempo di ricarica in minuti per una Sessione di Ricarica.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#rechargeTimeInMin">uiote:rechargeTimeInMin</a>
    /// </summary>
    let rechargeTimeInMin = _prefixId.prefix "rechargeTimeInMin"
    /// <summary>
    ///   <para>rdfs:label : utente registratordfs:label : registered user</para>
    ///   <para>rdfs:comment : Indicates if a Charging Session is performed by a registered user or not.rdfs:comment : Indica se la Sessione di Ricarica è stata eseguita da un utente registrato o meno.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#registeredUser">uiote:registeredUser</a>
    /// </summary>
    let registeredUser = _prefixId.prefix "registeredUser"
    /// <summary>
    ///   <para>rdfs:label : sorgenti rinnovabilirdfs:label : renewable sources</para>
    ///   <para>rdfs:comment : Provides information on the usage of renewable sources for a Charging Session.rdfs:comment : Informa rispetto all'uitilizzo di sorgenti di elettricità rinnovabili per una data Sessione di Ricarica.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#renewableSources">uiote:renewableSources</a>
    /// </summary>
    let renewableSources = _prefixId.prefix "renewableSources"
    /// <summary>
    ///   <para>rdfs:label : sessione operata dardfs:label : session operated by</para>
    ///   <para>rdfs:comment : Associates a Charging Session to the Charge Point Operator who operates the electricity supply.rdfs:comment : Associa una Sessione di Ricarica all'Operatore del Punto di Ricarica che aziona l'erogazione di corrente.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#sessionOperatedBy">uiote:sessionOperatedBy</a>
    /// </summary>
    let sessionOperatedBy = _prefixId.prefix "sessionOperatedBy"
    /// <summary>
    ///   <para>rdfs:label : stazione resa disponibile dardfs:label : station made available by</para>
    ///   <para>rdfs:comment : Connect a specific Charging Station which is made available by a charging service.rdfs:comment : Associa una determinata Stazione di Ricarica che è stata resa disponibile da un determinato Servizio di Ricarica.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#stationMadeAvailableBy">uiote:stationMadeAvailableBy</a>
    /// </summary>
    let stationMadeAvailableBy = _prefixId.prefix "stationMadeAvailableBy"
    /// <summary>
    ///   <para>rdfs:label : total energyrdfs:label : energia totale</para>
    ///   <para>rdfs:comment : Total energy supplied during a Charging Session.rdfs:comment : Energia totale erogata durante una Sessione di Ricarica.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#totalEnergy">uiote:totalEnergy</a>
    /// </summary>
    let totalEnergy = _prefixId.prefix "totalEnergy"
    /// <summary>
    ///   <para>rdfs:label : used connectorrdfs:label : connettore utilizzato</para>
    ///   <para>rdfs:comment : Associates a Charging Session to a Connector which is used during the Session.rdfs:comment : Associa una Sessione di Ricarica ad un Connettore che viene utilizzato durante la Sessione.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#usedConnector">uiote:usedConnector</a>
    /// </summary>
    let usedConnector = _prefixId.prefix "usedConnector"
    /// <summary>
    ///   <para>rdfs:label : used EVSErdfs:label : EVSE utilizzato</para>
    ///   <para>rdfs:comment : Associates a Charging Session to an Electric Vehicle Supply Equipment (EVSE) which is used during the Session.rdfs:comment : Associa una Sessione di Ricarica ad una Colonnina di Ricarica per Veicoli Elettrici (EVSE), che viene utilizzata durante la Sessione.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#usedEVSE">uiote:usedEVSE</a>
    /// </summary>
    let usedEVSE = _prefixId.prefix "usedEVSE"
    /// <summary>
    ///   <para>rdfs:label : uses charging stationrdfs:label : stazione di ricarica utilizzata</para>
    ///   <para>rdfs:comment : Associates a Charging Session to a Charging Station, which is used during the Session.rdfs:comment : Associa una Sessione di Ricarica ad una Stazione di Ricarica, utilizzata durante la Sessione.</para>
    ///   <a href="http://www.w3id.org/urban-iot/electric#usesChargingStation">uiote:usesChargingStation</a>
    /// </summary>
    let usesChargingStation = _prefixId.prefix "usesChargingStation"
