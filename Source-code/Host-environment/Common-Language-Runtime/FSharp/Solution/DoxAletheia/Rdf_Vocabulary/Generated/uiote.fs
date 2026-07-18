namespace http.www.w3id.org.urban_iot.electric.hash

open DoxAletheia.Rdf_Vocabulary

module uiote =
    let _namespace_name = "http://www.w3id.org/urban-iot/electric#"

    /// <summary>
    /// State for Electric Vehicle Supply Equipment.
    /// <see href="http://www.w3id.org/urban-iot/electric#EVSE-state"></see></summary>
    let ``EVSE-state`` =
        Namespaced_IRI.parse _namespace_name "EVSE-state" |> NamespacedName

    /// <summary>
    /// Organization that manages the supply of electricity in the Charging Stations.
    /// <see href="http://www.w3id.org/urban-iot/electric#ChargePointOperator"></see></summary>
    let ChargePointOperator =
        Namespaced_IRI.parse _namespace_name "ChargePointOperator" |> NamespacedName

    /// <summary>
    /// Service operated by an eMobility Service Provider, with the purpose to manage the use of Electric Vehicle Supply Equipments (EVSE).
    /// <see href="http://www.w3id.org/urban-iot/electric#ChargingService"></see></summary>
    let ChargingService =
        Namespaced_IRI.parse _namespace_name "ChargingService" |> NamespacedName

    /// <summary>
    /// Tariff offered to charge services Users.
    /// <see href="http://www.w3id.org/urban-iot/electric#ChargingServiceOffer"></see></summary>
    let ChargingServiceOffer =
        Namespaced_IRI.parse _namespace_name "ChargingServiceOffer" |> NamespacedName

    /// <summary>
    /// Session where a\n user asks to a charge for his vehicle, with all the information related to this activity.
    /// <see href="http://www.w3id.org/urban-iot/electric#ChargingSession"></see></summary>
    let ChargingSession =
        Namespaced_IRI.parse _namespace_name "ChargingSession" |> NamespacedName

    /// <summary>
    /// Place where it is possible to recharge vehicles, that includes both Electric Vehicle Supply Equipments (EVSE) and the parking areas to allow the vehicle stop during the charging activity.
    /// <see href="http://www.w3id.org/urban-iot/electric#ChargingStation"></see></summary>
    let ChargingStation =
        Namespaced_IRI.parse _namespace_name "ChargingStation" |> NamespacedName

    /// <summary>
    /// Connector related to an Electric Vehicle Supply Equipment (EVSE).
    /// <see href="http://www.w3id.org/urban-iot/electric#Connector"></see></summary>
    let Connector = Namespaced_IRI.parse _namespace_name "Connector" |> NamespacedName
    /// <summary>
    /// Electric Vehicle Supply Equipment (EVSE) available for charging vehicles.
    /// <see href="http://www.w3id.org/urban-iot/electric#EVSE"></see></summary>
    let EVSE = Namespaced_IRI.parse _namespace_name "EVSE" |> NamespacedName
    /// <summary>
    /// Registration status for the Electric Vehicle Supply Equipment (EVSE): in charge, available, inoperative, ecc.
    /// <see href="http://www.w3id.org/urban-iot/electric#EVSERecord"></see></summary>
    let EVSERecord = Namespaced_IRI.parse _namespace_name "EVSERecord" |> NamespacedName
    /// <summary>
    /// Connection to possible states for an EVSE (Electric Vehicle Supply Equipment).
    /// <see href="http://www.w3id.org/urban-iot/electric#EVSEState"></see></summary>
    let EVSEState = Namespaced_IRI.parse _namespace_name "EVSEState" |> NamespacedName

    /// <summary>
    /// Charging time during the closure of the service.
    /// <see href="http://www.w3id.org/urban-iot/electric#chargingDuringClosure"></see></summary>
    let chargingDuringClosure =
        Namespaced_IRI.parse _namespace_name "chargingDuringClosure" |> NamespacedName

    /// <summary>
    /// Associates a Charging Station to a Charging Service which enabled it.
    /// <see href="http://www.w3id.org/urban-iot/electric#chargingEnabledBy"></see></summary>
    let chargingEnabledBy =
        Namespaced_IRI.parse _namespace_name "chargingEnabledBy" |> NamespacedName

    /// <summary>
    /// A Charging Service can enable Charging Sessions
    /// <see href="http://www.w3id.org/urban-iot/electric#enablesCharging"></see></summary>
    let enablesCharging =
        Namespaced_IRI.parse _namespace_name "enablesCharging" |> NamespacedName

    /// <summary>
    /// Associates a Charging Session with a Service Private User who performs the Session.
    /// <see href="http://www.w3id.org/urban-iot/electric#chargingPerformedBy"></see></summary>
    let chargingPerformedBy =
        Namespaced_IRI.parse _namespace_name "chargingPerformedBy" |> NamespacedName

    /// <summary>
    /// Associates a Service Private User to a Charging Session, perfrmed by the User.
    /// <see href="http://www.w3id.org/urban-iot/electric#performsCharging"></see></summary>
    let performsCharging =
        Namespaced_IRI.parse _namespace_name "performsCharging" |> NamespacedName

    /// <summary>
    /// Indicates the duration of a Charging Session.
    /// <see href="http://www.w3id.org/urban-iot/electric#chargingSessionDuration"></see></summary>
    let chargingSessionDuration =
        Namespaced_IRI.parse _namespace_name "chargingSessionDuration" |> NamespacedName

    /// <summary>
    /// Associates a Charging Station to a Charging Session where the Station is used.
    /// <see href="http://www.w3id.org/urban-iot/electric#chargingStationUsedIn"></see></summary>
    let chargingStationUsedIn =
        Namespaced_IRI.parse _namespace_name "chargingStationUsedIn" |> NamespacedName

    /// <summary>
    /// Associates a Charging Session to a Charging Station, which is used during the Session.
    /// <see href="http://www.w3id.org/urban-iot/electric#usesChargingStation"></see></summary>
    let usesChargingStation =
        Namespaced_IRI.parse _namespace_name "usesChargingStation" |> NamespacedName

    /// <summary>
    /// Organization which offers the Charging Service
    /// <see href="http://www.w3id.org/urban-iot/electric#eMobilityServiceProvider"></see></summary>
    let eMobilityServiceProvider =
        Namespaced_IRI.parse _namespace_name "eMobilityServiceProvider" |> NamespacedName

    /// <summary>
    /// Floore level where the Electric Vehicle Supply Equimpment (EVSE) is installed.
    /// <see href="http://www.w3id.org/urban-iot/electric#floorLevel"></see></summary>
    let floorLevel = Namespaced_IRI.parse _namespace_name "floorLevel" |> NamespacedName

    /// <summary>
    /// Association for an Electric Vehicle Supply Equipment (EVSE) to possible methods to activate the charge.
    /// <see href="http://www.w3id.org/urban-iot/electric#hasChargeAccessMethod"></see></summary>
    let hasChargeAccessMethod =
        Namespaced_IRI.parse _namespace_name "hasChargeAccessMethod" |> NamespacedName

    /// <summary>
    /// Associates a Charging Station to a Charging Offer.
    /// <see href="http://www.w3id.org/urban-iot/electric#hasChargingServiceOffer"></see></summary>
    let hasChargingServiceOffer =
        Namespaced_IRI.parse _namespace_name "hasChargingServiceOffer" |> NamespacedName

    /// <summary>
    /// Associates an Organization with a Charging Station, where the Organization owns the Station.
    /// <see href="http://www.w3id.org/urban-iot/electric#hasChargingStationOwner"></see></summary>
    let hasChargingStationOwner =
        Namespaced_IRI.parse _namespace_name "hasChargingStationOwner" |> NamespacedName

    /// <summary>
    /// Associates a Connector to an Electric Vehicle Supply Equipment (EVSE).
    /// <see href="http://www.w3id.org/urban-iot/electric#hasConnector"></see></summary>
    let hasConnector =
        Namespaced_IRI.parse _namespace_name "hasConnector" |> NamespacedName

    /// <summary>
    /// Associates a Connector to an Electric Vehicle Supply Equipment (EVSE).
    /// <see href="http://www.w3id.org/urban-iot/electric#isConnectorOf"></see></summary>
    let isConnectorOf =
        Namespaced_IRI.parse _namespace_name "isConnectorOf" |> NamespacedName

    /// <summary>
    /// Associates a Charging Station to an Electric Vehicle Supply Equipment (EVSE).
    /// <see href="http://www.w3id.org/urban-iot/electric#hasEVSE"></see></summary>
    let hasEVSE = Namespaced_IRI.parse _namespace_name "hasEVSE" |> NamespacedName
    /// <summary>
    /// Associates an Electric Vehicle Supply Equipment (EVSE) to a Charging Station.
    /// <see href="http://www.w3id.org/urban-iot/electric#isEVSEOf"></see></summary>
    let isEVSEOf = Namespaced_IRI.parse _namespace_name "isEVSEOf" |> NamespacedName

    /// <summary>
    /// Associates a Electric Vehicle Supply Equipment (EVSE) to the possible charge categories.
    /// <see href="http://www.w3id.org/urban-iot/electric#hasEVSEChargeCategory"></see></summary>
    let hasEVSEChargeCategory =
        Namespaced_IRI.parse _namespace_name "hasEVSEChargeCategory" |> NamespacedName

    /// <summary>
    /// Associates a Charging station with the possible point of interest near by, represented as Place.
    /// <see href="http://www.w3id.org/urban-iot/electric#hasFacilityNearBy"></see></summary>
    let hasFacilityNearBy =
        Namespaced_IRI.parse _namespace_name "hasFacilityNearBy" |> NamespacedName

    /// <summary>
    /// Associates an Electric Vehicle Supply Equipment (EVSE) to possible parking restrictions to use the charging service.
    /// <see href="http://www.w3id.org/urban-iot/electric#hasParkingRestriction"></see></summary>
    let hasParkingRestriction =
        Namespaced_IRI.parse _namespace_name "hasParkingRestriction" |> NamespacedName

    /// <summary>
    /// Associates a Connector to possible power supplies.
    /// <see href="http://www.w3id.org/urban-iot/electric#hasPowerSupply"></see></summary>
    let hasPowerSupply =
        Namespaced_IRI.parse _namespace_name "hasPowerSupply" |> NamespacedName

    /// <summary>
    /// Associates a Connector to possible standard.
    /// <see href="http://www.w3id.org/urban-iot/electric#hasStandard"></see></summary>
    let hasStandard =
        Namespaced_IRI.parse _namespace_name "hasStandard" |> NamespacedName

    /// <summary>
    /// Associates a Charging Station to a possible sub operator, identified as an Organization.
    /// <see href="http://www.w3id.org/urban-iot/electric#hasSubChargePointOperator"></see></summary>
    let hasSubChargePointOperator =
        Namespaced_IRI.parse _namespace_name "hasSubChargePointOperator" |> NamespacedName

    /// <summary>
    /// Indicates if a Charging Station is private or public.
    /// <see href="http://www.w3id.org/urban-iot/electric#isPrivate"></see></summary>
    let isPrivate = Namespaced_IRI.parse _namespace_name "isPrivate" |> NamespacedName

    /// <summary>
    /// Associates a Charging Service to a Charging Station, made available by the Service.
    /// <see href="http://www.w3id.org/urban-iot/electric#makesStationAvailable"></see></summary>
    let makesStationAvailable =
        Namespaced_IRI.parse _namespace_name "makesStationAvailable" |> NamespacedName

    /// <summary>
    /// Connect a specific Charging Station which is made available by a charging service.
    /// <see href="http://www.w3id.org/urban-iot/electric#stationMadeAvailableBy"></see></summary>
    let stationMadeAvailableBy =
        Namespaced_IRI.parse _namespace_name "stationMadeAvailableBy" |> NamespacedName

    /// <summary>
    /// It is the maximum amperage expressed in Ampere for a Connector.
    /// <see href="http://www.w3id.org/urban-iot/electric#maxAmperageInA"></see></summary>
    let maxAmperageInA =
        Namespaced_IRI.parse _namespace_name "maxAmperageInA" |> NamespacedName

    /// <summary>
    /// It is the maximum power expressed in kWatt for a Connector.
    /// <see href="http://www.w3id.org/urban-iot/electric#maxPowerInKW"></see></summary>
    let maxPowerInKW =
        Namespaced_IRI.parse _namespace_name "maxPowerInKW" |> NamespacedName

    /// <summary>
    /// It is the maximum voltage expressed in Volt for a Connector.
    /// <see href="http://www.w3id.org/urban-iot/electric#maxVoltageInV"></see></summary>
    let maxVoltageInV =
        Namespaced_IRI.parse _namespace_name "maxVoltageInV" |> NamespacedName

    /// <summary>
    /// It is the minimum amperage expressed in Ampere for a Connector.
    /// <see href="http://www.w3id.org/urban-iot/electric#minAmperageInA"></see></summary>
    let minAmperageInA =
        Namespaced_IRI.parse _namespace_name "minAmperageInA" |> NamespacedName

    /// <summary>
    /// It is the minimum power expressed in kWatt for a Connector.
    /// <see href="http://www.w3id.org/urban-iot/electric#minPowerInKW"></see></summary>
    let minPowerInKW =
        Namespaced_IRI.parse _namespace_name "minPowerInKW" |> NamespacedName

    /// <summary>
    /// It is the minimum voltage expressed in Volt for a Connector.
    /// <see href="http://www.w3id.org/urban-iot/electric#minVoltageInV"></see></summary>
    let minVoltageInV =
        Namespaced_IRI.parse _namespace_name "minVoltageInV" |> NamespacedName

    /// <summary>
    /// Associates a Charging Station to a Charge Point Operator who operates it allowing the electricity supply.
    /// <see href="http://www.w3id.org/urban-iot/electric#operatedBy"></see></summary>
    let operatedBy = Namespaced_IRI.parse _namespace_name "operatedBy" |> NamespacedName
    /// <summary>
    /// Associates a Chage Point Operator to a Charging Station, which is operated by the Operator.
    /// <see href="http://www.w3id.org/urban-iot/electric#operates"></see></summary>
    let operates = Namespaced_IRI.parse _namespace_name "operates" |> NamespacedName

    /// <summary>
    /// Associates a Charge Point Operator to a Charging Session which involves him.
    /// <see href="http://www.w3id.org/urban-iot/electric#operatesSession"></see></summary>
    let operatesSession =
        Namespaced_IRI.parse _namespace_name "operatesSession" |> NamespacedName

    /// <summary>
    /// Associates a Charging Session to the Charge Point Operator who operates the electricity supply.
    /// <see href="http://www.w3id.org/urban-iot/electric#sessionOperatedBy"></see></summary>
    let sessionOperatedBy =
        Namespaced_IRI.parse _namespace_name "sessionOperatedBy" |> NamespacedName

    /// <summary>
    /// Price expressed per kWh of charge.
    /// <see href="http://www.w3id.org/urban-iot/electric#pricePerKWhCharge"></see></summary>
    let pricePerKWhCharge =
        Namespaced_IRI.parse _namespace_name "pricePerKWhCharge" |> NamespacedName

    /// <summary>
    /// Price expressed per minutes of charge.
    /// <see href="http://www.w3id.org/urban-iot/electric#pricePerMinuteCharge"></see></summary>
    let pricePerMinuteCharge =
        Namespaced_IRI.parse _namespace_name "pricePerMinuteCharge" |> NamespacedName

    /// <summary>
    /// Price expressed per minute of parking.
    /// <see href="http://www.w3id.org/urban-iot/electric#pricePerMinuteParking"></see></summary>
    let pricePerMinuteParking =
        Namespaced_IRI.parse _namespace_name "pricePerMinuteParking" |> NamespacedName

    /// <summary>
    /// Price expressed per month of charge.
    /// <see href="http://www.w3id.org/urban-iot/electric#pricePerMonthCharge"></see></summary>
    let pricePerMonthCharge =
        Namespaced_IRI.parse _namespace_name "pricePerMonthCharge" |> NamespacedName

    /// <summary>
    /// Indicates the presence of a cable for the Connector.
    /// <see href="http://www.w3id.org/urban-iot/electric#providesCable"></see></summary>
    let providesCable =
        Namespaced_IRI.parse _namespace_name "providesCable" |> NamespacedName

    /// <summary>
    /// Associates an eMobility Service Provider to a Charging Service provided by him.
    /// <see href="http://www.w3id.org/urban-iot/electric#providesChargingService"></see></summary>
    let providesChargingService =
        Namespaced_IRI.parse _namespace_name "providesChargingService" |> NamespacedName

    /// <summary>
    /// Indicates the charging time expressed in minutes for a Charging Session.
    /// <see href="http://www.w3id.org/urban-iot/electric#rechargeTimeInMin"></see></summary>
    let rechargeTimeInMin =
        Namespaced_IRI.parse _namespace_name "rechargeTimeInMin" |> NamespacedName

    /// <summary>
    /// Indicates if a Charging Session is performed by a registered user or not.
    /// <see href="http://www.w3id.org/urban-iot/electric#registeredUser"></see></summary>
    let registeredUser =
        Namespaced_IRI.parse _namespace_name "registeredUser" |> NamespacedName

    /// <summary>
    /// Provides information on the usage of renewable sources for a Charging Session.
    /// <see href="http://www.w3id.org/urban-iot/electric#renewableSources"></see></summary>
    let renewableSources =
        Namespaced_IRI.parse _namespace_name "renewableSources" |> NamespacedName

    /// <summary>
    /// Total energy supplied during a Charging Session.
    /// <see href="http://www.w3id.org/urban-iot/electric#totalEnergy"></see></summary>
    let totalEnergy =
        Namespaced_IRI.parse _namespace_name "totalEnergy" |> NamespacedName

    /// <summary>
    /// Associates a Charging Session to a Connector which is used during the Session.
    /// <see href="http://www.w3id.org/urban-iot/electric#usedConnector"></see></summary>
    let usedConnector =
        Namespaced_IRI.parse _namespace_name "usedConnector" |> NamespacedName

    /// <summary>
    /// Associates a Charging Session to an Electric Vehicle Supply Equipment (EVSE) which is used during the Session.
    /// <see href="http://www.w3id.org/urban-iot/electric#usedEVSE"></see></summary>
    let usedEVSE = Namespaced_IRI.parse _namespace_name "usedEVSE" |> NamespacedName
