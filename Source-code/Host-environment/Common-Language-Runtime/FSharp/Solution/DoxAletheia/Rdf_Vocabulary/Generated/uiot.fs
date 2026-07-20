namespace http.www.w3id.org.urban_iot.core.hash

open DoxAletheia

module uiot =
    let _namespace_name = "http://www.w3id.org/urban-iot/core#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A Place characterized by mobility services. A Mobility Station can include more specific Mobility Station (Sharing Station, Charging Station, ecc.).
    /// <see href="http://www.w3id.org/urban-iot/core#MobilityStation"></see></summary>
    let MobilityStation = _prefix "MobilityStation"
    /// <summary>
    /// A Sensor Record aggregates a set of observations associated to the same timestamp and the same sensor.
    /// <see href="http://www.w3id.org/urban-iot/core#SensorRecord"></see></summary>
    let SensorRecord = _prefix "SensorRecord"
    /// <summary>
    /// Legal Entity with a business contract for the service. A Service Business User can not directly use the service but can enable a Service Private User to do so.
    /// <see href="http://www.w3id.org/urban-iot/core#ServiceBusinessUser"></see></summary>
    let ServiceBusinessUser = _prefix "ServiceBusinessUser"
    /// <summary>
    /// A User using a Service.
    /// <see href="http://www.w3id.org/urban-iot/core#ServiceUser"></see></summary>
    let ServiceUser = _prefix "ServiceUser"
    /// <summary>
    /// A natural person using a service.
    /// <see href="http://www.w3id.org/urban-iot/core#ServicePrivateUser"></see></summary>
    let ServicePrivateUser = _prefix "ServicePrivateUser"
    /// <summary>
    /// A Resource made available by a Service to be used in a Usage Session.
    /// <see href="http://www.w3id.org/urban-iot/core#ServiceResource"></see></summary>
    let ServiceResource = _prefix "ServiceResource"
    /// <summary>
    /// A Usage Session is an Event associated to a Service and a Service Resource representing a usage of the resource made available by the Service.
    /// <see href="http://www.w3id.org/urban-iot/core#UsageSession"></see></summary>
    let UsageSession = _prefix "UsageSession"
    /// <summary>
    /// Associates a Usage Session with the Service Business User enabling it.
    /// <see href="http://www.w3id.org/urban-iot/core#associatedBusiness"></see></summary>
    let associatedBusiness = _prefix "associatedBusiness"
    /// <summary>
    ///   <see href="http://www.w3id.org/urban-iot/core#birthYear"></see>
    /// </summary>
    let birthYear = _prefix "birthYear"
    /// <summary>
    /// Associates a Sensor Record with a Observation contained in it.
    /// <see href="http://www.w3id.org/urban-iot/core#containsObservation"></see></summary>
    let containsObservation = _prefix "containsObservation"
    /// <summary>
    /// Associates an Observation with the Sensor Record containing it.
    /// <see href="http://www.w3id.org/urban-iot/core#observationIn"></see></summary>
    let observationIn = _prefix "observationIn"
    /// <summary>
    /// Date in which a Service User deregistered from a Service.
    /// <see href="http://www.w3id.org/urban-iot/core#deregistrationDate"></see></summary>
    let deregistrationDate = _prefix "deregistrationDate"
    /// <summary>
    /// Associates a Service with a Usage Session enabled by the service.
    /// <see href="http://www.w3id.org/urban-iot/core#enablesSession"></see></summary>
    let enablesSession = _prefix "enablesSession"
    /// <summary>
    /// Associates a Usage Session with the Service enabling it.
    /// <see href="http://www.w3id.org/urban-iot/core#sessionEnabledBy"></see></summary>
    let sessionEnabledBy = _prefix "sessionEnabledBy"
    /// <summary>
    /// Associates an Offer with a fixed amount required from it.
    /// <see href="http://www.w3id.org/urban-iot/core#fixedAmount"></see></summary>
    let fixedAmount = _prefix "fixedAmount"
    /// <summary>
    /// Associates a Service Business User with the Service Private User enabled by that business user.
    /// <see href="http://www.w3id.org/urban-iot/core#hasEnabledUser"></see></summary>
    let hasEnabledUser = _prefix "hasEnabledUser"
    /// <summary>
    /// Associates a Service Private User to the Service Business User enabling it.
    /// <see href="http://www.w3id.org/urban-iot/core#userEnabledBy"></see></summary>
    let userEnabledBy = _prefix "userEnabledBy"
    /// <summary>
    /// Associates a Service to a Service User.
    /// <see href="http://www.w3id.org/urban-iot/core#hasUser"></see></summary>
    let hasUser = _prefix "hasUser"
    /// <summary>
    /// Associates a Service User to the Service used.
    /// <see href="http://www.w3id.org/urban-iot/core#userOfService"></see></summary>
    let userOfService = _prefix "userOfService"
    /// <summary>
    /// Associates a Mobility Station with another Mobility Station including it.
    /// <see href="http://www.w3id.org/urban-iot/core#includedInMobilityStation"></see></summary>
    let includedInMobilityStation = _prefix "includedInMobilityStation"
    /// <summary>
    /// Associates a Sensor with the latest registered Sensor Record.
    /// <see href="http://www.w3id.org/urban-iot/core#latestRecord"></see></summary>
    let latestRecord = _prefix "latestRecord"
    /// <summary>
    /// Associates a Sensor with a registered Sensor Record.
    /// <see href="http://www.w3id.org/urban-iot/core#registersRecord"></see></summary>
    let registersRecord = _prefix "registersRecord"
    /// <summary>
    /// Associates a Service Resource with the Service making it available.
    /// <see href="http://www.w3id.org/urban-iot/core#madeAvailableBy"></see></summary>
    let madeAvailableBy = _prefix "madeAvailableBy"
    /// <summary>
    /// Associates a Service with the Service Resource that makes available.
    /// <see href="http://www.w3id.org/urban-iot/core#makesAvailable"></see></summary>
    let makesAvailable = _prefix "makesAvailable"
    /// <summary>
    /// Associates a Usage Session with the tariff (Offer) applied to the specific session.
    /// <see href="http://www.w3id.org/urban-iot/core#offerAssociated"></see></summary>
    let offerAssociated = _prefix "offerAssociated"
    /// <summary>
    /// Associates a Service Private User with a Usage Session performed.
    /// <see href="http://www.w3id.org/urban-iot/core#performsSession"></see></summary>
    let performsSession = _prefix "performsSession"
    /// <summary>
    /// Associates a Usage Session with the Service Private User performing it.
    /// <see href="http://www.w3id.org/urban-iot/core#sessionPerformedBy"></see></summary>
    let sessionPerformedBy = _prefix "sessionPerformedBy"
    /// <summary>
    /// Associates a Sensor Record with the Sensor registering it.
    /// <see href="http://www.w3id.org/urban-iot/core#recordRegisteredBy"></see></summary>
    let recordRegisteredBy = _prefix "recordRegisteredBy"
    /// <summary>
    /// Timestamp associated with a Sensor Record.
    /// <see href="http://www.w3id.org/urban-iot/core#recordTimestamp"></see></summary>
    let recordTimestamp = _prefix "recordTimestamp"
    /// <summary>
    /// Associates a Service User to the Service to which the user is registered to.
    /// <see href="http://www.w3id.org/urban-iot/core#registeredTo"></see></summary>
    let registeredTo = _prefix "registeredTo"
    /// <summary>
    /// Date in which a Service User registered to the Service.
    /// <see href="http://www.w3id.org/urban-iot/core#registrationDate"></see></summary>
    let registrationDate = _prefix "registrationDate"
    /// <summary>
    /// Indicates whether a reservation mechanism has been used for a Usage Session.
    /// <see href="http://www.w3id.org/urban-iot/core#reservationUsed"></see></summary>
    let reservationUsed = _prefix "reservationUsed"
    /// <summary>
    /// Associates a Service Resource with a Usage Session using it.
    /// <see href="http://www.w3id.org/urban-iot/core#resourceUsedIn"></see></summary>
    let resourceUsedIn = _prefix "resourceUsedIn"
    /// <summary>
    /// Associates a Usage Session with the Service Resource used in the session.
    /// <see href="http://www.w3id.org/urban-iot/core#usesResource"></see></summary>
    let usesResource = _prefix "usesResource"
    /// <summary>
    /// Indication of the serial number.
    /// <see href="http://www.w3id.org/urban-iot/core#serialNumber"></see></summary>
    let serialNumber = _prefix "serialNumber"
