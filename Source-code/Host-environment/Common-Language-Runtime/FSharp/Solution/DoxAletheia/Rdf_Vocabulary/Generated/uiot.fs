namespace http.www.w3id.org.urban_iot.core.hash

open DoxAletheia.Rdf_Vocabulary

module uiot =
    let _namespace_name = "http://www.w3id.org/urban-iot/core#"

    /// <summary>
    /// A Place characterized by mobility services. A Mobility Station can include more specific Mobility Station (Sharing Station, Charging Station, ecc.).
    /// <see href="http://www.w3id.org/urban-iot/core#MobilityStation"></see></summary>
    let MobilityStation =
        Namespaced_IRI.parse _namespace_name "MobilityStation" |> NamespacedName

    /// <summary>
    /// A Sensor Record aggregates a set of observations associated to the same timestamp and the same sensor.
    /// <see href="http://www.w3id.org/urban-iot/core#SensorRecord"></see></summary>
    let SensorRecord =
        Namespaced_IRI.parse _namespace_name "SensorRecord" |> NamespacedName

    /// <summary>
    /// Legal Entity with a business contract for the service. A Service Business User can not directly use the service but can enable a Service Private User to do so.
    /// <see href="http://www.w3id.org/urban-iot/core#ServiceBusinessUser"></see></summary>
    let ServiceBusinessUser =
        Namespaced_IRI.parse _namespace_name "ServiceBusinessUser" |> NamespacedName

    /// <summary>
    /// A User using a Service.
    /// <see href="http://www.w3id.org/urban-iot/core#ServiceUser"></see></summary>
    let ServiceUser =
        Namespaced_IRI.parse _namespace_name "ServiceUser" |> NamespacedName

    /// <summary>
    /// A natural person using a service.
    /// <see href="http://www.w3id.org/urban-iot/core#ServicePrivateUser"></see></summary>
    let ServicePrivateUser =
        Namespaced_IRI.parse _namespace_name "ServicePrivateUser" |> NamespacedName

    /// <summary>
    /// A Resource made available by a Service to be used in a Usage Session.
    /// <see href="http://www.w3id.org/urban-iot/core#ServiceResource"></see></summary>
    let ServiceResource =
        Namespaced_IRI.parse _namespace_name "ServiceResource" |> NamespacedName

    /// <summary>
    /// A Usage Session is an Event associated to a Service and a Service Resource representing a usage of the resource made available by the Service.
    /// <see href="http://www.w3id.org/urban-iot/core#UsageSession"></see></summary>
    let UsageSession =
        Namespaced_IRI.parse _namespace_name "UsageSession" |> NamespacedName

    /// <summary>
    /// Associates a Usage Session with the Service Business User enabling it.
    /// <see href="http://www.w3id.org/urban-iot/core#associatedBusiness"></see></summary>
    let associatedBusiness =
        Namespaced_IRI.parse _namespace_name "associatedBusiness" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3id.org/urban-iot/core#birthYear"></see>
    /// </summary>
    let birthYear = Namespaced_IRI.parse _namespace_name "birthYear" |> NamespacedName

    /// <summary>
    /// Associates a Sensor Record with a Observation contained in it.
    /// <see href="http://www.w3id.org/urban-iot/core#containsObservation"></see></summary>
    let containsObservation =
        Namespaced_IRI.parse _namespace_name "containsObservation" |> NamespacedName

    /// <summary>
    /// Associates an Observation with the Sensor Record containing it.
    /// <see href="http://www.w3id.org/urban-iot/core#observationIn"></see></summary>
    let observationIn =
        Namespaced_IRI.parse _namespace_name "observationIn" |> NamespacedName

    /// <summary>
    /// Date in which a Service User deregistered from a Service.
    /// <see href="http://www.w3id.org/urban-iot/core#deregistrationDate"></see></summary>
    let deregistrationDate =
        Namespaced_IRI.parse _namespace_name "deregistrationDate" |> NamespacedName

    /// <summary>
    /// Associates a Service with a Usage Session enabled by the service.
    /// <see href="http://www.w3id.org/urban-iot/core#enablesSession"></see></summary>
    let enablesSession =
        Namespaced_IRI.parse _namespace_name "enablesSession" |> NamespacedName

    /// <summary>
    /// Associates a Usage Session with the Service enabling it.
    /// <see href="http://www.w3id.org/urban-iot/core#sessionEnabledBy"></see></summary>
    let sessionEnabledBy =
        Namespaced_IRI.parse _namespace_name "sessionEnabledBy" |> NamespacedName

    /// <summary>
    /// Associates an Offer with a fixed amount required from it.
    /// <see href="http://www.w3id.org/urban-iot/core#fixedAmount"></see></summary>
    let fixedAmount =
        Namespaced_IRI.parse _namespace_name "fixedAmount" |> NamespacedName

    /// <summary>
    /// Associates a Service Business User with the Service Private User enabled by that business user.
    /// <see href="http://www.w3id.org/urban-iot/core#hasEnabledUser"></see></summary>
    let hasEnabledUser =
        Namespaced_IRI.parse _namespace_name "hasEnabledUser" |> NamespacedName

    /// <summary>
    /// Associates a Service Private User to the Service Business User enabling it.
    /// <see href="http://www.w3id.org/urban-iot/core#userEnabledBy"></see></summary>
    let userEnabledBy =
        Namespaced_IRI.parse _namespace_name "userEnabledBy" |> NamespacedName

    /// <summary>
    /// Associates a Service to a Service User.
    /// <see href="http://www.w3id.org/urban-iot/core#hasUser"></see></summary>
    let hasUser = Namespaced_IRI.parse _namespace_name "hasUser" |> NamespacedName

    /// <summary>
    /// Associates a Service User to the Service used.
    /// <see href="http://www.w3id.org/urban-iot/core#userOfService"></see></summary>
    let userOfService =
        Namespaced_IRI.parse _namespace_name "userOfService" |> NamespacedName

    /// <summary>
    /// Associates a Mobility Station with another Mobility Station including it.
    /// <see href="http://www.w3id.org/urban-iot/core#includedInMobilityStation"></see></summary>
    let includedInMobilityStation =
        Namespaced_IRI.parse _namespace_name "includedInMobilityStation" |> NamespacedName

    /// <summary>
    /// Associates a Sensor with the latest registered Sensor Record.
    /// <see href="http://www.w3id.org/urban-iot/core#latestRecord"></see></summary>
    let latestRecord =
        Namespaced_IRI.parse _namespace_name "latestRecord" |> NamespacedName

    /// <summary>
    /// Associates a Sensor with a registered Sensor Record.
    /// <see href="http://www.w3id.org/urban-iot/core#registersRecord"></see></summary>
    let registersRecord =
        Namespaced_IRI.parse _namespace_name "registersRecord" |> NamespacedName

    /// <summary>
    /// Associates a Service Resource with the Service making it available.
    /// <see href="http://www.w3id.org/urban-iot/core#madeAvailableBy"></see></summary>
    let madeAvailableBy =
        Namespaced_IRI.parse _namespace_name "madeAvailableBy" |> NamespacedName

    /// <summary>
    /// Associates a Service with the Service Resource that makes available.
    /// <see href="http://www.w3id.org/urban-iot/core#makesAvailable"></see></summary>
    let makesAvailable =
        Namespaced_IRI.parse _namespace_name "makesAvailable" |> NamespacedName

    /// <summary>
    /// Associates a Usage Session with the tariff (Offer) applied to the specific session.
    /// <see href="http://www.w3id.org/urban-iot/core#offerAssociated"></see></summary>
    let offerAssociated =
        Namespaced_IRI.parse _namespace_name "offerAssociated" |> NamespacedName

    /// <summary>
    /// Associates a Service Private User with a Usage Session performed.
    /// <see href="http://www.w3id.org/urban-iot/core#performsSession"></see></summary>
    let performsSession =
        Namespaced_IRI.parse _namespace_name "performsSession" |> NamespacedName

    /// <summary>
    /// Associates a Usage Session with the Service Private User performing it.
    /// <see href="http://www.w3id.org/urban-iot/core#sessionPerformedBy"></see></summary>
    let sessionPerformedBy =
        Namespaced_IRI.parse _namespace_name "sessionPerformedBy" |> NamespacedName

    /// <summary>
    /// Associates a Sensor Record with the Sensor registering it.
    /// <see href="http://www.w3id.org/urban-iot/core#recordRegisteredBy"></see></summary>
    let recordRegisteredBy =
        Namespaced_IRI.parse _namespace_name "recordRegisteredBy" |> NamespacedName

    /// <summary>
    /// Timestamp associated with a Sensor Record.
    /// <see href="http://www.w3id.org/urban-iot/core#recordTimestamp"></see></summary>
    let recordTimestamp =
        Namespaced_IRI.parse _namespace_name "recordTimestamp" |> NamespacedName

    /// <summary>
    /// Associates a Service User to the Service to which the user is registered to.
    /// <see href="http://www.w3id.org/urban-iot/core#registeredTo"></see></summary>
    let registeredTo =
        Namespaced_IRI.parse _namespace_name "registeredTo" |> NamespacedName

    /// <summary>
    /// Date in which a Service User registered to the Service.
    /// <see href="http://www.w3id.org/urban-iot/core#registrationDate"></see></summary>
    let registrationDate =
        Namespaced_IRI.parse _namespace_name "registrationDate" |> NamespacedName

    /// <summary>
    /// Indicates whether a reservation mechanism has been used for a Usage Session.
    /// <see href="http://www.w3id.org/urban-iot/core#reservationUsed"></see></summary>
    let reservationUsed =
        Namespaced_IRI.parse _namespace_name "reservationUsed" |> NamespacedName

    /// <summary>
    /// Associates a Service Resource with a Usage Session using it.
    /// <see href="http://www.w3id.org/urban-iot/core#resourceUsedIn"></see></summary>
    let resourceUsedIn =
        Namespaced_IRI.parse _namespace_name "resourceUsedIn" |> NamespacedName

    /// <summary>
    /// Associates a Usage Session with the Service Resource used in the session.
    /// <see href="http://www.w3id.org/urban-iot/core#usesResource"></see></summary>
    let usesResource =
        Namespaced_IRI.parse _namespace_name "usesResource" |> NamespacedName

    /// <summary>
    /// Indication of the serial number.
    /// <see href="http://www.w3id.org/urban-iot/core#serialNumber"></see></summary>
    let serialNumber =
        Namespaced_IRI.parse _namespace_name "serialNumber" |> NamespacedName
