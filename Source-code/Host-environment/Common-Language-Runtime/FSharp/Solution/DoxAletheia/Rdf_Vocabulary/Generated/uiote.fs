namespace http.www.w3id.org.urban_iot.electric.hash

open DoxAletheia

module uiote =
    let _namespace_name = "http://www.w3id.org/urban-iot/electric#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// State for Electric Vehicle Supply Equipment.
    /// <see href="http://www.w3id.org/urban-iot/electric#EVSE-state"></see></summary>
    let ``EVSE-state`` = _prefix "EVSE-state"
    /// <summary>
    /// Organization that manages the supply of electricity in the Charging Stations.
    /// <see href="http://www.w3id.org/urban-iot/electric#ChargePointOperator"></see></summary>
    let ChargePointOperator = _prefix "ChargePointOperator"
    /// <summary>
    /// Service operated by an eMobility Service Provider, with the purpose to manage the use of Electric Vehicle Supply Equipments (EVSE).
    /// <see href="http://www.w3id.org/urban-iot/electric#ChargingService"></see></summary>
    let ChargingService = _prefix "ChargingService"
    /// <summary>
    /// Tariff offered to charge services Users.
    /// <see href="http://www.w3id.org/urban-iot/electric#ChargingServiceOffer"></see></summary>
    let ChargingServiceOffer = _prefix "ChargingServiceOffer"
    /// <summary>
    /// Session where a\n user asks to a charge for his vehicle, with all the information related to this activity.
    /// <see href="http://www.w3id.org/urban-iot/electric#ChargingSession"></see></summary>
    let ChargingSession = _prefix "ChargingSession"
    /// <summary>
    /// Place where it is possible to recharge vehicles, that includes both Electric Vehicle Supply Equipments (EVSE) and the parking areas to allow the vehicle stop during the charging activity.
    /// <see href="http://www.w3id.org/urban-iot/electric#ChargingStation"></see></summary>
    let ChargingStation = _prefix "ChargingStation"
    /// <summary>
    /// Connector related to an Electric Vehicle Supply Equipment (EVSE).
    /// <see href="http://www.w3id.org/urban-iot/electric#Connector"></see></summary>
    let Connector = _prefix "Connector"
    /// <summary>
    /// Electric Vehicle Supply Equipment (EVSE) available for charging vehicles.
    /// <see href="http://www.w3id.org/urban-iot/electric#EVSE"></see></summary>
    let EVSE = _prefix "EVSE"
    /// <summary>
    /// Registration status for the Electric Vehicle Supply Equipment (EVSE): in charge, available, inoperative, ecc.
    /// <see href="http://www.w3id.org/urban-iot/electric#EVSERecord"></see></summary>
    let EVSERecord = _prefix "EVSERecord"
    /// <summary>
    /// Connection to possible states for an EVSE (Electric Vehicle Supply Equipment).
    /// <see href="http://www.w3id.org/urban-iot/electric#EVSEState"></see></summary>
    let EVSEState = _prefix "EVSEState"
    /// <summary>
    /// Charging time during the closure of the service.
    /// <see href="http://www.w3id.org/urban-iot/electric#chargingDuringClosure"></see></summary>
    let chargingDuringClosure = _prefix "chargingDuringClosure"
    /// <summary>
    /// Associates a Charging Station to a Charging Service which enabled it.
    /// <see href="http://www.w3id.org/urban-iot/electric#chargingEnabledBy"></see></summary>
    let chargingEnabledBy = _prefix "chargingEnabledBy"
    /// <summary>
    /// A Charging Service can enable Charging Sessions
    /// <see href="http://www.w3id.org/urban-iot/electric#enablesCharging"></see></summary>
    let enablesCharging = _prefix "enablesCharging"
    /// <summary>
    /// Associates a Charging Session with a Service Private User who performs the Session.
    /// <see href="http://www.w3id.org/urban-iot/electric#chargingPerformedBy"></see></summary>
    let chargingPerformedBy = _prefix "chargingPerformedBy"
    /// <summary>
    /// Associates a Service Private User to a Charging Session, perfrmed by the User.
    /// <see href="http://www.w3id.org/urban-iot/electric#performsCharging"></see></summary>
    let performsCharging = _prefix "performsCharging"
    /// <summary>
    /// Indicates the duration of a Charging Session.
    /// <see href="http://www.w3id.org/urban-iot/electric#chargingSessionDuration"></see></summary>
    let chargingSessionDuration = _prefix "chargingSessionDuration"
    /// <summary>
    /// Associates a Charging Station to a Charging Session where the Station is used.
    /// <see href="http://www.w3id.org/urban-iot/electric#chargingStationUsedIn"></see></summary>
    let chargingStationUsedIn = _prefix "chargingStationUsedIn"
    /// <summary>
    /// Associates a Charging Session to a Charging Station, which is used during the Session.
    /// <see href="http://www.w3id.org/urban-iot/electric#usesChargingStation"></see></summary>
    let usesChargingStation = _prefix "usesChargingStation"
    /// <summary>
    /// Organization which offers the Charging Service
    /// <see href="http://www.w3id.org/urban-iot/electric#eMobilityServiceProvider"></see></summary>
    let eMobilityServiceProvider = _prefix "eMobilityServiceProvider"
    /// <summary>
    /// Floore level where the Electric Vehicle Supply Equimpment (EVSE) is installed.
    /// <see href="http://www.w3id.org/urban-iot/electric#floorLevel"></see></summary>
    let floorLevel = _prefix "floorLevel"
    /// <summary>
    /// Association for an Electric Vehicle Supply Equipment (EVSE) to possible methods to activate the charge.
    /// <see href="http://www.w3id.org/urban-iot/electric#hasChargeAccessMethod"></see></summary>
    let hasChargeAccessMethod = _prefix "hasChargeAccessMethod"
    /// <summary>
    /// Associates a Charging Station to a Charging Offer.
    /// <see href="http://www.w3id.org/urban-iot/electric#hasChargingServiceOffer"></see></summary>
    let hasChargingServiceOffer = _prefix "hasChargingServiceOffer"
    /// <summary>
    /// Associates an Organization with a Charging Station, where the Organization owns the Station.
    /// <see href="http://www.w3id.org/urban-iot/electric#hasChargingStationOwner"></see></summary>
    let hasChargingStationOwner = _prefix "hasChargingStationOwner"
    /// <summary>
    /// Associates a Connector to an Electric Vehicle Supply Equipment (EVSE).
    /// <see href="http://www.w3id.org/urban-iot/electric#hasConnector"></see></summary>
    let hasConnector = _prefix "hasConnector"
    /// <summary>
    /// Associates a Connector to an Electric Vehicle Supply Equipment (EVSE).
    /// <see href="http://www.w3id.org/urban-iot/electric#isConnectorOf"></see></summary>
    let isConnectorOf = _prefix "isConnectorOf"
    /// <summary>
    /// Associates a Charging Station to an Electric Vehicle Supply Equipment (EVSE).
    /// <see href="http://www.w3id.org/urban-iot/electric#hasEVSE"></see></summary>
    let hasEVSE = _prefix "hasEVSE"
    /// <summary>
    /// Associates an Electric Vehicle Supply Equipment (EVSE) to a Charging Station.
    /// <see href="http://www.w3id.org/urban-iot/electric#isEVSEOf"></see></summary>
    let isEVSEOf = _prefix "isEVSEOf"
    /// <summary>
    /// Associates a Electric Vehicle Supply Equipment (EVSE) to the possible charge categories.
    /// <see href="http://www.w3id.org/urban-iot/electric#hasEVSEChargeCategory"></see></summary>
    let hasEVSEChargeCategory = _prefix "hasEVSEChargeCategory"
    /// <summary>
    /// Associates a Charging station with the possible point of interest near by, represented as Place.
    /// <see href="http://www.w3id.org/urban-iot/electric#hasFacilityNearBy"></see></summary>
    let hasFacilityNearBy = _prefix "hasFacilityNearBy"
    /// <summary>
    /// Associates an Electric Vehicle Supply Equipment (EVSE) to possible parking restrictions to use the charging service.
    /// <see href="http://www.w3id.org/urban-iot/electric#hasParkingRestriction"></see></summary>
    let hasParkingRestriction = _prefix "hasParkingRestriction"
    /// <summary>
    /// Associates a Connector to possible power supplies.
    /// <see href="http://www.w3id.org/urban-iot/electric#hasPowerSupply"></see></summary>
    let hasPowerSupply = _prefix "hasPowerSupply"
    /// <summary>
    /// Associates a Connector to possible standard.
    /// <see href="http://www.w3id.org/urban-iot/electric#hasStandard"></see></summary>
    let hasStandard = _prefix "hasStandard"
    /// <summary>
    /// Associates a Charging Station to a possible sub operator, identified as an Organization.
    /// <see href="http://www.w3id.org/urban-iot/electric#hasSubChargePointOperator"></see></summary>
    let hasSubChargePointOperator = _prefix "hasSubChargePointOperator"
    /// <summary>
    /// Indicates if a Charging Station is private or public.
    /// <see href="http://www.w3id.org/urban-iot/electric#isPrivate"></see></summary>
    let isPrivate = _prefix "isPrivate"
    /// <summary>
    /// Associates a Charging Service to a Charging Station, made available by the Service.
    /// <see href="http://www.w3id.org/urban-iot/electric#makesStationAvailable"></see></summary>
    let makesStationAvailable = _prefix "makesStationAvailable"
    /// <summary>
    /// Connect a specific Charging Station which is made available by a charging service.
    /// <see href="http://www.w3id.org/urban-iot/electric#stationMadeAvailableBy"></see></summary>
    let stationMadeAvailableBy = _prefix "stationMadeAvailableBy"
    /// <summary>
    /// It is the maximum amperage expressed in Ampere for a Connector.
    /// <see href="http://www.w3id.org/urban-iot/electric#maxAmperageInA"></see></summary>
    let maxAmperageInA = _prefix "maxAmperageInA"
    /// <summary>
    /// It is the maximum power expressed in kWatt for a Connector.
    /// <see href="http://www.w3id.org/urban-iot/electric#maxPowerInKW"></see></summary>
    let maxPowerInKW = _prefix "maxPowerInKW"
    /// <summary>
    /// It is the maximum voltage expressed in Volt for a Connector.
    /// <see href="http://www.w3id.org/urban-iot/electric#maxVoltageInV"></see></summary>
    let maxVoltageInV = _prefix "maxVoltageInV"
    /// <summary>
    /// It is the minimum amperage expressed in Ampere for a Connector.
    /// <see href="http://www.w3id.org/urban-iot/electric#minAmperageInA"></see></summary>
    let minAmperageInA = _prefix "minAmperageInA"
    /// <summary>
    /// It is the minimum power expressed in kWatt for a Connector.
    /// <see href="http://www.w3id.org/urban-iot/electric#minPowerInKW"></see></summary>
    let minPowerInKW = _prefix "minPowerInKW"
    /// <summary>
    /// It is the minimum voltage expressed in Volt for a Connector.
    /// <see href="http://www.w3id.org/urban-iot/electric#minVoltageInV"></see></summary>
    let minVoltageInV = _prefix "minVoltageInV"
    /// <summary>
    /// Associates a Charging Station to a Charge Point Operator who operates it allowing the electricity supply.
    /// <see href="http://www.w3id.org/urban-iot/electric#operatedBy"></see></summary>
    let operatedBy = _prefix "operatedBy"
    /// <summary>
    /// Associates a Chage Point Operator to a Charging Station, which is operated by the Operator.
    /// <see href="http://www.w3id.org/urban-iot/electric#operates"></see></summary>
    let operates = _prefix "operates"
    /// <summary>
    /// Associates a Charge Point Operator to a Charging Session which involves him.
    /// <see href="http://www.w3id.org/urban-iot/electric#operatesSession"></see></summary>
    let operatesSession = _prefix "operatesSession"
    /// <summary>
    /// Associates a Charging Session to the Charge Point Operator who operates the electricity supply.
    /// <see href="http://www.w3id.org/urban-iot/electric#sessionOperatedBy"></see></summary>
    let sessionOperatedBy = _prefix "sessionOperatedBy"
    /// <summary>
    /// Price expressed per kWh of charge.
    /// <see href="http://www.w3id.org/urban-iot/electric#pricePerKWhCharge"></see></summary>
    let pricePerKWhCharge = _prefix "pricePerKWhCharge"
    /// <summary>
    /// Price expressed per minutes of charge.
    /// <see href="http://www.w3id.org/urban-iot/electric#pricePerMinuteCharge"></see></summary>
    let pricePerMinuteCharge = _prefix "pricePerMinuteCharge"
    /// <summary>
    /// Price expressed per minute of parking.
    /// <see href="http://www.w3id.org/urban-iot/electric#pricePerMinuteParking"></see></summary>
    let pricePerMinuteParking = _prefix "pricePerMinuteParking"
    /// <summary>
    /// Price expressed per month of charge.
    /// <see href="http://www.w3id.org/urban-iot/electric#pricePerMonthCharge"></see></summary>
    let pricePerMonthCharge = _prefix "pricePerMonthCharge"
    /// <summary>
    /// Indicates the presence of a cable for the Connector.
    /// <see href="http://www.w3id.org/urban-iot/electric#providesCable"></see></summary>
    let providesCable = _prefix "providesCable"
    /// <summary>
    /// Associates an eMobility Service Provider to a Charging Service provided by him.
    /// <see href="http://www.w3id.org/urban-iot/electric#providesChargingService"></see></summary>
    let providesChargingService = _prefix "providesChargingService"
    /// <summary>
    /// Indicates the charging time expressed in minutes for a Charging Session.
    /// <see href="http://www.w3id.org/urban-iot/electric#rechargeTimeInMin"></see></summary>
    let rechargeTimeInMin = _prefix "rechargeTimeInMin"
    /// <summary>
    /// Indicates if a Charging Session is performed by a registered user or not.
    /// <see href="http://www.w3id.org/urban-iot/electric#registeredUser"></see></summary>
    let registeredUser = _prefix "registeredUser"
    /// <summary>
    /// Provides information on the usage of renewable sources for a Charging Session.
    /// <see href="http://www.w3id.org/urban-iot/electric#renewableSources"></see></summary>
    let renewableSources = _prefix "renewableSources"
    /// <summary>
    /// Total energy supplied during a Charging Session.
    /// <see href="http://www.w3id.org/urban-iot/electric#totalEnergy"></see></summary>
    let totalEnergy = _prefix "totalEnergy"
    /// <summary>
    /// Associates a Charging Session to a Connector which is used during the Session.
    /// <see href="http://www.w3id.org/urban-iot/electric#usedConnector"></see></summary>
    let usedConnector = _prefix "usedConnector"
    /// <summary>
    /// Associates a Charging Session to an Electric Vehicle Supply Equipment (EVSE) which is used during the Session.
    /// <see href="http://www.w3id.org/urban-iot/electric#usedEVSE"></see></summary>
    let usedEVSE = _prefix "usedEVSE"
