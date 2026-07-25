namespace http.www.w3id.org.urban_iot.electric.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module uiote =
    let _namespace_iri = Namespace_Iri uiote |> NamespaceIRI
    /// <summary>
    ///   <para>uiote:sessionOperatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associa una Sessione di Ricarica all'Operatore del Punto di Ricarica che aziona l'erogazione di corrente.</para>
    ///   <para>Associates a Charging Session to the Charge Point Operator who operates the electricity supply.</para>
    /// labels<para>session operated by</para><para>sessione operata da</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#sessionOperatedBy">http://www.w3id.org/urban-iot/electric#sessionOperatedBy</seealso>
    let sessionOperatedBy = Prefixed_Name(uiote, "sessionOperatedBy") |> PrefixedName
    /// <summary>
    ///   <para>uiote:pricePerKWhCharge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Price expressed per kWh of charge.</para>
    ///   <para>Prezzo espresso in base ai kWh di ricarica.</para>
    /// labels<para>prezzo al kWh di ricarica</para><para>price per kWh charge</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#pricePerKWhCharge">http://www.w3id.org/urban-iot/electric#pricePerKWhCharge</seealso>
    let pricePerKWhCharge = Prefixed_Name(uiote, "pricePerKWhCharge") |> PrefixedName

    /// <summary>
    ///   <para>uiote:pricePerMinuteCharge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Price expressed per minutes of charge.</para>
    ///   <para>Prezzo espresso in base ai minuti di ricarica.</para>
    /// labels<para>prezzo al minuto di ricarica</para><para>price per minute charge</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#pricePerMinuteCharge">http://www.w3id.org/urban-iot/electric#pricePerMinuteCharge</seealso>
    let pricePerMinuteCharge =
        Prefixed_Name(uiote, "pricePerMinuteCharge") |> PrefixedName

    /// <summary>
    ///   <para>uiote:providesCable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indica la presenza di cavo o meno, per un Connettore.</para>
    ///   <para>Indicates the presence of a cable for the Connector.</para>
    /// labels<para>provides cable</para><para>fornisce cavo</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#providesCable">http://www.w3id.org/urban-iot/electric#providesCable</seealso>
    let providesCable = Prefixed_Name(uiote, "providesCable") |> PrefixedName
    /// <summary>
    ///   <para>uiote:renewableSources</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Informa rispetto all'uitilizzo di sorgenti di elettricità rinnovabili per una data Sessione di Ricarica.</para>
    ///   <para>Provides information on the usage of renewable sources for a Charging Session.</para>
    /// labels<para>sorgenti rinnovabili</para><para>renewable sources</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#renewableSources">http://www.w3id.org/urban-iot/electric#renewableSources</seealso>
    let renewableSources = Prefixed_Name(uiote, "renewableSources") |> PrefixedName
    /// <summary>
    ///   <para>uiote:totalEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Total energy supplied during a Charging Session.</para>
    ///   <para>Energia totale erogata durante una Sessione di Ricarica.</para>
    /// labels<para>energia totale</para><para>total energy</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#totalEnergy">http://www.w3id.org/urban-iot/electric#totalEnergy</seealso>
    let totalEnergy = Prefixed_Name(uiote, "totalEnergy") |> PrefixedName
    /// <summary>
    ///   <para>uiote:floorLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Piano al quale è installata la colonnina di ricarica per veicoli elettrici (EVSE).</para>
    ///   <para>Floore level where the Electric Vehicle Supply Equimpment (EVSE) is installed.</para>
    /// labels<para>numero di piano</para><para>floor level</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#floorLevel">http://www.w3id.org/urban-iot/electric#floorLevel</seealso>
    let floorLevel = Prefixed_Name(uiote, "floorLevel") |> PrefixedName

    /// <summary>
    ///   <para>uiote:hasChargingServiceOffer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a Charging Station to a Charging Offer.</para>
    ///   <para>Associazine tra una Stazione di Ricarica e un'Offerta di Ricarica.</para>
    /// labels<para>has charging service offer</para><para>ha un'offerta di ricarica</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#hasChargingServiceOffer">http://www.w3id.org/urban-iot/electric#hasChargingServiceOffer</seealso>
    let hasChargingServiceOffer =
        Prefixed_Name(uiote, "hasChargingServiceOffer") |> PrefixedName

    /// <summary>
    ///   <para>uiote:hasConnector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associa un Connettore ad una Colonnina di Ricarica per Veicoli Elettrici (EVSE).</para>
    ///   <para>Associates a Connector to an Electric Vehicle Supply Equipment (EVSE).</para>
    /// labels<para>ha un connettore</para><para>has connector</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#hasConnector">http://www.w3id.org/urban-iot/electric#hasConnector</seealso>
    let hasConnector = Prefixed_Name(uiote, "hasConnector") |> PrefixedName
    /// <summary>
    ///   <para>uiote:hasFacilityNearBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associa una Stazione di Ricarica ai possibili punti di interesse in zona, rappresentati come Luogo.</para>
    ///   <para>Associates a Charging station with the possible point of interest near by, represented as Place.</para>
    /// labels<para>ha punti di interesse vicini</para><para>has facility near by</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#hasFacilityNearBy">http://www.w3id.org/urban-iot/electric#hasFacilityNearBy</seealso>
    let hasFacilityNearBy = Prefixed_Name(uiote, "hasFacilityNearBy") |> PrefixedName
    /// <summary>
    ///   <para>uiote:hasPowerSupply</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a Connector to possible power supplies.</para>
    ///   <para>Associa un Connettore ai possibili tipi di alimentazione.</para>
    /// labels<para>ha tipi di alimentazione</para><para>has power supply</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#hasPowerSupply">http://www.w3id.org/urban-iot/electric#hasPowerSupply</seealso>
    let hasPowerSupply = Prefixed_Name(uiote, "hasPowerSupply") |> PrefixedName

    /// <summary>
    ///   <para>uiote:hasSubChargePointOperator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associa una Stazione di Ricarica a un possibile sub operatore, identificato come Organizzazione.</para>
    ///   <para>Associates a Charging Station to a possible sub operator, identified as an Organization.</para>
    /// labels<para>ha un sub operatore di ricarica</para><para>has sub charge point operator</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#hasSubChargePointOperator">http://www.w3id.org/urban-iot/electric#hasSubChargePointOperator</seealso>
    let hasSubChargePointOperator =
        Prefixed_Name(uiote, "hasSubChargePointOperator") |> PrefixedName

    /// <summary>
    ///   <para>uiote:isPrivate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates if a Charging Station is private or public.</para>
    ///   <para>Indica se una Stazione di Ricarica sia privata o pubblica.</para>
    /// labels<para>is private</para><para>è privata</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#isPrivate">http://www.w3id.org/urban-iot/electric#isPrivate</seealso>
    let isPrivate = Prefixed_Name(uiote, "isPrivate") |> PrefixedName

    /// <summary>
    ///   <para>uiote:makesStationAvailable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a Charging Service to a Charging Station, made available by the Service.</para>
    ///   <para>Associa un Servizio di Ricarica ad una Stazione di Ricarica, resa disponibile dal servizio.</para>
    /// labels<para>rende la stazione disponibile</para><para>makes station available</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#makesStationAvailable">http://www.w3id.org/urban-iot/electric#makesStationAvailable</seealso>
    let makesStationAvailable =
        Prefixed_Name(uiote, "makesStationAvailable") |> PrefixedName

    /// <summary>
    ///   <para>uiote:stationMadeAvailableBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associa una determinata Stazione di Ricarica che è stata resa disponibile da un determinato Servizio di Ricarica.</para>
    ///   <para>Connect a specific Charging Station which is made available by a charging service.</para>
    /// labels<para>stazione resa disponibile da</para><para>station made available by</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#stationMadeAvailableBy">http://www.w3id.org/urban-iot/electric#stationMadeAvailableBy</seealso>
    let stationMadeAvailableBy =
        Prefixed_Name(uiote, "stationMadeAvailableBy") |> PrefixedName

    /// <summary>
    ///   <para>uiote:maxPowerInKW</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>It is the maximum power expressed in kWatt for a Connector.</para>
    ///   <para>Indica la massima potenza in kWatt per un Connettore.</para>
    /// labels<para>massima potenza in kW</para><para>max power in kW</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#maxPowerInKW">http://www.w3id.org/urban-iot/electric#maxPowerInKW</seealso>
    let maxPowerInKW = Prefixed_Name(uiote, "maxPowerInKW") |> PrefixedName
    /// <summary>
    ///   <para>uiote:minAmperageInA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indica il minimo amperaggio in Ampere per un Connettore.</para>
    ///   <para>It is the minimum amperage expressed in Ampere for a Connector.</para>
    /// labels<para>minimo amperaggio in A</para><para>min amperage in A</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#minAmperageInA">http://www.w3id.org/urban-iot/electric#minAmperageInA</seealso>
    let minAmperageInA = Prefixed_Name(uiote, "minAmperageInA") |> PrefixedName

    /// <summary>
    ///   <para>uiote:hasParkingRestriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates an Electric Vehicle Supply Equipment (EVSE) to possible parking restrictions to use the charging service.</para>
    ///   <para>Associa una Colonnina di Ricarica per Veicoli Elettrici (EVSE) a possibili restrizioni di sosta per poter sfruttare il servizio.</para>
    /// labels<para>ha restrizioni di parcheggio</para><para>has parking restriction</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#hasParkingRestriction">http://www.w3id.org/urban-iot/electric#hasParkingRestriction</seealso>
    let hasParkingRestriction =
        Prefixed_Name(uiote, "hasParkingRestriction") |> PrefixedName

    /// <summary>
    ///   <para>uiote:EVSE-state</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Stato della Colonnina di Ricarica per Veicoli Elettrici.</para>
    ///   <para>State for Electric Vehicle Supply Equipment.</para>
    /// labels<para>Stato Colonnina di Ricarica</para><para>EVSE state</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#EVSE-state">http://www.w3id.org/urban-iot/electric#EVSE-state</seealso>
    let EVSE_state = Prefixed_Name(uiote, "EVSE-state") |> PrefixedName
    /// <summary>
    ///   <para>uiote:hasStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associa un Connettore ai possibili standard di prese.</para>
    ///   <para>Associates a Connector to possible standard.</para>
    /// labels<para>has standard</para><para>ha standard</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#hasStandard">http://www.w3id.org/urban-iot/electric#hasStandard</seealso>
    let hasStandard = Prefixed_Name(uiote, "hasStandard") |> PrefixedName
    /// <summary>
    ///   <para>uiote:maxAmperageInA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>It is the maximum amperage expressed in Ampere for a Connector.</para>
    ///   <para>Indica il massimo amperaggio in Ampere per un Connettore.</para>
    /// labels<para>massimo amperaggio in A</para><para>max amperage in A</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#maxAmperageInA">http://www.w3id.org/urban-iot/electric#maxAmperageInA</seealso>
    let maxAmperageInA = Prefixed_Name(uiote, "maxAmperageInA") |> PrefixedName
    /// <summary>
    ///   <para>uiote:operates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a Chage Point Operator to a Charging Station, which is operated by the Operator.</para>
    ///   <para>Associa un Operatore del Punto di Ricarica ad una Stazione di Ricarica, che viene azionata dall'Operatore.</para>
    /// labels<para>operates</para><para>opera</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#operates">http://www.w3id.org/urban-iot/electric#operates</seealso>
    let operates = Prefixed_Name(uiote, "operates") |> PrefixedName
    /// <summary>
    ///   <para>uiote:maxVoltageInV</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indica il massimo voltaggio in Volt per un Connettore.</para>
    ///   <para>It is the maximum voltage expressed in Volt for a Connector.</para>
    /// labels<para>massimo voltaggio in V</para><para>max voltage in V</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#maxVoltageInV">http://www.w3id.org/urban-iot/electric#maxVoltageInV</seealso>
    let maxVoltageInV = Prefixed_Name(uiote, "maxVoltageInV") |> PrefixedName
    /// <summary>
    ///   <para>uiote:minPowerInKW</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>It is the minimum power expressed in kWatt for a Connector.</para>
    ///   <para>Indica la minima potenza in kWatt per un Connettore.</para>
    /// labels<para>minima potenza in kW</para><para>min power in kW</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#minPowerInKW">http://www.w3id.org/urban-iot/electric#minPowerInKW</seealso>
    let minPowerInKW = Prefixed_Name(uiote, "minPowerInKW") |> PrefixedName
    /// <summary>
    ///   <para>uiote:minVoltageInV</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>It is the minimum voltage expressed in Volt for a Connector.</para>
    ///   <para>Indica il minimo voltaggio in Volt per un Connettore.</para>
    /// labels<para>minimo voltaggio in V</para><para>min voltage in V</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#minVoltageInV">http://www.w3id.org/urban-iot/electric#minVoltageInV</seealso>
    let minVoltageInV = Prefixed_Name(uiote, "minVoltageInV") |> PrefixedName
    /// <summary>
    ///   <para>uiote:operatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a Charging Station to a Charge Point Operator who operates it allowing the electricity supply.</para>
    ///   <para>Associa una Stazione di Ricarica all'Operatore del Punto di Ricarica che l'aziona dal punto di vista dell'erogazione di elettricità.</para>
    /// labels<para>operated by</para><para>operato da</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#operatedBy">http://www.w3id.org/urban-iot/electric#operatedBy</seealso>
    let operatedBy = Prefixed_Name(uiote, "operatedBy") |> PrefixedName
    /// <summary>
    ///   <para>uiote:operatesSession</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associa un Operatore Punto del Ricarica ad una Sessione di Ricarica che lo coinvolge.</para>
    ///   <para>Associates a Charge Point Operator to a Charging Session which involves him.</para>
    /// labels<para>operates session</para><para>opera sessione</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#operatesSession">http://www.w3id.org/urban-iot/electric#operatesSession</seealso>
    let operatesSession = Prefixed_Name(uiote, "operatesSession") |> PrefixedName

    /// <summary>
    ///   <para>uiote:pricePerMinuteParking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Price expressed per minute of parking.</para>
    ///   <para>Prezzo espresso in base ai minuti di parcheggio.</para>
    /// labels<para>prezzo al minuto di parcheggio</para><para>price per minute parking</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#pricePerMinuteParking">http://www.w3id.org/urban-iot/electric#pricePerMinuteParking</seealso>
    let pricePerMinuteParking =
        Prefixed_Name(uiote, "pricePerMinuteParking") |> PrefixedName

    /// <summary>
    ///   <para>uiote:pricePerMonthCharge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Price expressed per month of charge.</para>
    ///   <para>Prezzo espresso in base al mese per ricarica.</para>
    /// labels<para>prezzo per mese di ricarica</para><para>price per month charge</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#pricePerMonthCharge">http://www.w3id.org/urban-iot/electric#pricePerMonthCharge</seealso>
    let pricePerMonthCharge =
        Prefixed_Name(uiote, "pricePerMonthCharge") |> PrefixedName

    /// <summary>
    ///   <para>uiote:providesChargingService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associa un Gestore di Servizi per la Mobilità Elettrica ad un Servizio di Ricarica che fornisce.</para>
    ///   <para>Associates an eMobility Service Provider to a Charging Service provided by him.</para>
    /// labels<para>offre servizio di ricarica</para><para>provides charging service</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#providesChargingService">http://www.w3id.org/urban-iot/electric#providesChargingService</seealso>
    let providesChargingService =
        Prefixed_Name(uiote, "providesChargingService") |> PrefixedName

    /// <summary>
    ///   <para>uiote:rechargeTimeInMin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates the charging time expressed in minutes for a Charging Session.</para>
    ///   <para>Indica il tempo di ricarica in minuti per una Sessione di Ricarica.</para>
    /// labels<para>tempo di ricarica in minuti</para><para>recharge time in min</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#rechargeTimeInMin">http://www.w3id.org/urban-iot/electric#rechargeTimeInMin</seealso>
    let rechargeTimeInMin = Prefixed_Name(uiote, "rechargeTimeInMin") |> PrefixedName
    /// <summary>
    ///   <para>uiote:registeredUser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indica se la Sessione di Ricarica è stata eseguita da un utente registrato o meno.</para>
    ///   <para>Indicates if a Charging Session is performed by a registered user or not.</para>
    /// labels<para>utente registrato</para><para>registered user</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#registeredUser">http://www.w3id.org/urban-iot/electric#registeredUser</seealso>
    let registeredUser = Prefixed_Name(uiote, "registeredUser") |> PrefixedName
    /// <summary>
    ///   <para>uiote:usedConnector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a Charging Session to a Connector which is used during the Session.</para>
    ///   <para>Associa una Sessione di Ricarica ad un Connettore che viene utilizzato durante la Sessione.</para>
    /// labels<para>connettore utilizzato</para><para>used connector</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#usedConnector">http://www.w3id.org/urban-iot/electric#usedConnector</seealso>
    let usedConnector = Prefixed_Name(uiote, "usedConnector") |> PrefixedName
    /// <summary>
    ///   <para>uiote:usedEVSE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associa una Sessione di Ricarica ad una Colonnina di Ricarica per Veicoli Elettrici (EVSE), che viene utilizzata durante la Sessione.</para>
    ///   <para>Associates a Charging Session to an Electric Vehicle Supply Equipment (EVSE) which is used during the Session.</para>
    /// labels<para>EVSE utilizzato</para><para>used EVSE</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#usedEVSE">http://www.w3id.org/urban-iot/electric#usedEVSE</seealso>
    let usedEVSE = Prefixed_Name(uiote, "usedEVSE") |> PrefixedName
    /// <summary>
    ///   <para>uiote:ChargingService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Servizio operato da un Gestore di Servizi per la ricarica elettrica, con il fine di gestire l'utilizzo di Colonnine di Ricarica (EVSE).</para>
    ///   <para>Service operated by an eMobility Service Provider, with the purpose to manage the use of Electric Vehicle Supply Equipments (EVSE).</para>
    /// labels<para>Servizio di Ricarica</para><para>Charging Service</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#ChargingService">http://www.w3id.org/urban-iot/electric#ChargingService</seealso>
    let ChargingService = Prefixed_Name(uiote, "ChargingService") |> PrefixedName
    /// <summary>
    ///   <para>uiote:ChargingSession</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Session where a\n user asks to a charge for his vehicle, with all the information related to this activity.</para>
    ///   <para>Sessione dove un utente richiede la carica del proprio veicolo, con tutte le informazioni collegate a questa attività.</para>
    /// labels<para>Sessione di Ricarica</para><para>Charging Session</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#ChargingSession">http://www.w3id.org/urban-iot/electric#ChargingSession</seealso>
    let ChargingSession = Prefixed_Name(uiote, "ChargingSession") |> PrefixedName
    /// <summary>
    ///   <para>uiote:ChargingStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Luogo dove si possono ricaricare veicoli elettrici, comprensivo sia di Colonnine di Ricarica per Veicoli Elettrici (EVSE) che delle aree di sosta per lasciare il veicolo durante la ricarica.</para>
    ///   <para>Place where it is possible to recharge vehicles, that includes both Electric Vehicle Supply Equipments (EVSE) and the parking areas to allow the vehicle stop during the charging activity.</para>
    /// labels<para>Stazione di Ricarica</para><para>Charging Station</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#ChargingStation">http://www.w3id.org/urban-iot/electric#ChargingStation</seealso>
    let ChargingStation = Prefixed_Name(uiote, "ChargingStation") |> PrefixedName

    /// <summary>
    ///   <para>uiote:ChargePointOperator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Organization that manages the supply of electricity in the Charging Stations.</para>
    ///   <para>Organizzazione che gestisce l'erogazione di corrente presso le Stazioni di Ricarica.</para>
    /// labels<para>Operatore del Punto di Ricarica</para><para>Charge Point Operator</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#ChargePointOperator">http://www.w3id.org/urban-iot/electric#ChargePointOperator</seealso>
    let ChargePointOperator =
        Prefixed_Name(uiote, "ChargePointOperator") |> PrefixedName

    /// <summary>
    ///   <para>uiote:ChargingServiceOffer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Tariffa offerta agli Utenti dei Servizi di Ricarica.</para>
    ///   <para>Tariff offered to charge services Users.</para>
    /// labels<para>Tariffa per Servizi di Ricarica</para><para>Charging Service Offer</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#ChargingServiceOffer">http://www.w3id.org/urban-iot/electric#ChargingServiceOffer</seealso>
    let ChargingServiceOffer =
        Prefixed_Name(uiote, "ChargingServiceOffer") |> PrefixedName

    /// <summary>
    ///   <para>uiote:Connector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Connettore collegato a una Colonnina di Ricarica per Veicoli Elettrici (EVSE).</para>
    ///   <para>Connector related to an Electric Vehicle Supply Equipment (EVSE).</para>
    /// labels<para>Connettore</para><para>Connector</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#Connector">http://www.w3id.org/urban-iot/electric#Connector</seealso>
    let Connector = Prefixed_Name(uiote, "Connector") |> PrefixedName
    /// <summary>
    ///   <para>uiote:EVSE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Electric Vehicle Supply Equipment (EVSE) available for charging vehicles.</para>
    ///   <para>Colonnina di Ricarica (EVSE) messa a disposizione per la ricarica di veicoli elettrici.</para>
    /// labels<para>Colonnina di Ricarica per Veicoli Elettrici (EVSE)</para><para>Electric Vehicle Supply Equipment (EVSE)</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#EVSE">http://www.w3id.org/urban-iot/electric#EVSE</seealso>
    let EVSE = Prefixed_Name(uiote, "EVSE") |> PrefixedName
    /// <summary>
    ///   <para>uiote:EVSERecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Registration status for the Electric Vehicle Supply Equipment (EVSE): in charge, available, inoperative, ecc.</para>
    ///   <para>Registrazione dello stato in cui si trova nei vari momenti la Colonnina di Ricarica (EVSE): in carica, disponibile, inattiva, etc.</para>
    /// labels<para>Electric Vehicle Supply Equipment Record</para><para>Stato della Colonnina di Ricarica</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#EVSERecord">http://www.w3id.org/urban-iot/electric#EVSERecord</seealso>
    let EVSERecord = Prefixed_Name(uiote, "EVSERecord") |> PrefixedName
    /// <summary>
    ///   <para>uiote:EVSEState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Connection to possible states for an EVSE (Electric Vehicle Supply Equipment).</para>
    ///   <para>Associazioni a possibili stati  in cui una Colonnina per la Ricarica Veicoli Elettrici (EVSE) può trovarsi.</para>
    /// labels<para>stato dell'EVSE</para><para>EVSE state</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#EVSEState">http://www.w3id.org/urban-iot/electric#EVSEState</seealso>
    let EVSEState = Prefixed_Name(uiote, "EVSEState") |> PrefixedName

    /// <summary>
    ///   <para>uiote:eMobilityServiceProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Organization which offers the Charging Service</para>
    ///   <para>Organizzazione che fornisce il Servizio di Ricarica.</para>
    /// labels<para>Gestore di Servizi per la Ricarica Elettica</para><para>eMobility Service Provider</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#eMobilityServiceProvider">http://www.w3id.org/urban-iot/electric#eMobilityServiceProvider</seealso>
    let eMobilityServiceProvider =
        Prefixed_Name(uiote, "eMobilityServiceProvider") |> PrefixedName

    /// <summary>
    ///   <para>uiote:hasChargeAccessMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Association for an Electric Vehicle Supply Equipment (EVSE) to possible methods to activate the charge.</para>
    ///   <para>Associazione di una Colonnina di Ricarica per Veicoli Elettrici (EVSE) a possibili metodi per attivare la ricarica.</para>
    /// labels<para>ha un metodo di accesso alla ricarica</para><para>has charge access method</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#hasChargeAccessMethod">http://www.w3id.org/urban-iot/electric#hasChargeAccessMethod</seealso>
    let hasChargeAccessMethod =
        Prefixed_Name(uiote, "hasChargeAccessMethod") |> PrefixedName

    /// <summary>
    ///   <para>uiote:hasChargingStationOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates an Organization with a Charging Station, where the Organization owns the Station.</para>
    ///   <para>Associa una Organizzazione a una Stazione di Ricarica, dove l'Organizzazione possiede la Stazione.</para>
    /// labels<para>possiede una stazione di ricarica</para><para>has charging station owner</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#hasChargingStationOwner">http://www.w3id.org/urban-iot/electric#hasChargingStationOwner</seealso>
    let hasChargingStationOwner =
        Prefixed_Name(uiote, "hasChargingStationOwner") |> PrefixedName

    /// <summary>
    ///   <para>uiote:isConnectorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a Connector to an Electric Vehicle Supply Equipment (EVSE).</para>
    ///   <para>Associa un Connettore ad una Colonnina di Ricarica per Veicoli Elettrici (EVSE).</para>
    /// labels<para>è connettore di</para><para>is connector of</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#isConnectorOf">http://www.w3id.org/urban-iot/electric#isConnectorOf</seealso>
    let isConnectorOf = Prefixed_Name(uiote, "isConnectorOf") |> PrefixedName
    /// <summary>
    ///   <para>uiote:hasEVSE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associa una Stazione di Ricarica a una Colonnina per la Ricarica di Veicoli Elettrici (EVSE).</para>
    ///   <para>Associates a Charging Station to an Electric Vehicle Supply Equipment (EVSE).</para>
    /// labels<para>ha un EVSE</para><para>has EVSE</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#hasEVSE">http://www.w3id.org/urban-iot/electric#hasEVSE</seealso>
    let hasEVSE = Prefixed_Name(uiote, "hasEVSE") |> PrefixedName
    /// <summary>
    ///   <para>uiote:isEVSEOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates an Electric Vehicle Supply Equipment (EVSE) to a Charging Station.</para>
    ///   <para>Associa una Colonnina di Ricarica per Veicoli Elettrici (EVSE) ad una Stazione di Ricarica.</para>
    /// labels<para>is EVSE of</para><para>è EVSE di</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#isEVSEOf">http://www.w3id.org/urban-iot/electric#isEVSEOf</seealso>
    let isEVSEOf = Prefixed_Name(uiote, "isEVSEOf") |> PrefixedName

    /// <summary>
    ///   <para>uiote:hasEVSEChargeCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associa una Colonnina di Ricarica per Veicoli Elettirci (EVSE) alle possibili categorie di ricarica.</para>
    ///   <para>Associates a Electric Vehicle Supply Equipment (EVSE) to the possible charge categories.</para>
    /// labels<para>ha una categoria di ricarica per EVSE</para><para>has EVSE Charge Category</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#hasEVSEChargeCategory">http://www.w3id.org/urban-iot/electric#hasEVSEChargeCategory</seealso>
    let hasEVSEChargeCategory =
        Prefixed_Name(uiote, "hasEVSEChargeCategory") |> PrefixedName

    /// <summary>
    ///   <para>uiote:chargingDuringClosure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Tempo di ricarica trascorso durante la chiusura del servizio.</para>
    ///   <para>Charging time during the closure of the service.</para>
    /// labels<para>ricarica durante la chiusura</para><para>charging during closure</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#chargingDuringClosure">http://www.w3id.org/urban-iot/electric#chargingDuringClosure</seealso>
    let chargingDuringClosure =
        Prefixed_Name(uiote, "chargingDuringClosure") |> PrefixedName

    /// <summary>
    ///   <para>uiote:chargingPerformedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associa una Sessione di Ricarica all'Utente Privato del Servizio che la esegue.</para>
    ///   <para>Associates a Charging Session with a Service Private User who performs the Session.</para>
    /// labels<para>ricarica effettuata da</para><para>charging performed by</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#chargingPerformedBy">http://www.w3id.org/urban-iot/electric#chargingPerformedBy</seealso>
    let chargingPerformedBy =
        Prefixed_Name(uiote, "chargingPerformedBy") |> PrefixedName

    /// <summary>
    ///   <para>uiote:chargingSessionDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indica la durata di una determinata Sessione di Ricarica.</para>
    ///   <para>Indicates the duration of a Charging Session.</para>
    /// labels<para>durata sessione di ricarica</para><para>charging session duration</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#chargingSessionDuration">http://www.w3id.org/urban-iot/electric#chargingSessionDuration</seealso>
    let chargingSessionDuration =
        Prefixed_Name(uiote, "chargingSessionDuration") |> PrefixedName

    /// <summary>
    ///   <para>uiote:chargingStationUsedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associa una Stazione di Ricarica ad una Sessione di Ricarica che la utilizza.</para>
    ///   <para>Associates a Charging Station to a Charging Session where the Station is used.</para>
    /// labels<para>stazione di ricarica usata in</para><para>charging station used in</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#chargingStationUsedIn">http://www.w3id.org/urban-iot/electric#chargingStationUsedIn</seealso>
    let chargingStationUsedIn =
        Prefixed_Name(uiote, "chargingStationUsedIn") |> PrefixedName

    /// <summary>
    ///   <para>uiote:usesChargingStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a Charging Session to a Charging Station, which is used during the Session.</para>
    ///   <para>Associa una Sessione di Ricarica ad una Stazione di Ricarica, utilizzata durante la Sessione.</para>
    /// labels<para>stazione di ricarica utilizzata</para><para>uses charging station</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#usesChargingStation">http://www.w3id.org/urban-iot/electric#usesChargingStation</seealso>
    let usesChargingStation =
        Prefixed_Name(uiote, "usesChargingStation") |> PrefixedName

    /// <summary>
    ///   <para>uiote:enablesCharging</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Un Servizio di Ricarica abilita Sessioni di Ricarica.</para>
    ///   <para>A Charging Service can enable Charging Sessions</para>
    /// labels<para>abilita la ricarica</para><para>enables charging</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#enablesCharging">http://www.w3id.org/urban-iot/electric#enablesCharging</seealso>
    let enablesCharging = Prefixed_Name(uiote, "enablesCharging") |> PrefixedName
    /// <summary>
    ///   <para>uiote:performsCharging</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a Service Private User to a Charging Session, perfrmed by the User.</para>
    ///   <para>Associa un Utente Privato del Servizio ad una Sessione di Ricarica, eseguita dall'Utente stesso.</para>
    /// labels<para>performs charging</para><para>opera ricarica</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#performsCharging">http://www.w3id.org/urban-iot/electric#performsCharging</seealso>
    let performsCharging = Prefixed_Name(uiote, "performsCharging") |> PrefixedName
    /// <summary>
    ///   <para>uiote:chargingEnabledBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a Charging Station to a Charging Service which enabled it.</para>
    ///   <para>Associa una Stazione di Ricarica ad un Servizio di Ricarica che l'abilita.</para>
    /// labels<para>ricarica abilitata da</para><para>charging enabled by</para></remarks>
    /// <seealso href="http://www.w3id.org/urban-iot/electric#chargingEnabledBy">http://www.w3id.org/urban-iot/electric#chargingEnabledBy</seealso>
    let chargingEnabledBy = Prefixed_Name(uiote, "chargingEnabledBy") |> PrefixedName
