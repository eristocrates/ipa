namespace http.purl.oclc.org.NET.UNIS.fiware.iot_lite.hash

open DoxAletheia.Rdf_Vocabulary

module iot_lite =
    let _namespace_name = "http://purl.oclc.org/NET/UNIS/fiware/iot-lite#"

    /// <summary>
    /// Device that can actuate over an object or QuantityKind.
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#ActuatingDevice"></see></summary>
    let ActuatingDevice =
        Namespaced_IRI.parse _namespace_name "ActuatingDevice" |> NamespacedName

    /// <summary>
    /// An attribute of an IoT object that can be exposed by an IoT service (i.e. a room (IoT Object) has a temperature (Attribute), that can be exposed by a temperature sensor (IoT device).
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Attribute"></see></summary>
    let Attribute = Namespaced_IRI.parse _namespace_name "Attribute" |> NamespacedName
    /// <summary>
    /// Circle coverage it needs the location of the sensor as the centre of the circle and the radius as a DataProperty.
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Circle"></see></summary>
    let Circle = Namespaced_IRI.parse _namespace_name "Circle" |> NamespacedName
    /// <summary>
    /// The coverage of an IoT device (i.e. a temperature sensor inside a room has a coverage of that room).
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Coverage"></see></summary>
    let Coverage = Namespaced_IRI.parse _namespace_name "Coverage" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Entity"></see>
    /// </summary>
    let Entity = Namespaced_IRI.parse _namespace_name "Entity" |> NamespacedName
    /// <summary>
    /// IoT entity
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Object"></see></summary>
    let Object = Namespaced_IRI.parse _namespace_name "Object" |> NamespacedName
    /// <summary>
    /// Class used to describe properties that cannot be described by QuantityKind and Units. i.e. the resolution of a sensor.
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Metadata"></see></summary>
    let Metadata = Namespaced_IRI.parse _namespace_name "Metadata" |> NamespacedName
    /// <summary>
    /// The coverage is made up by linking several points by strait lines.
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Polygon"></see></summary>
    let Polygon = Namespaced_IRI.parse _namespace_name "Polygon" |> NamespacedName
    /// <summary>
    /// Teh coverage is made up by giving two points which are the oposite corners of a rentangle.
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Rectangle"></see></summary>
    let Rectangle = Namespaced_IRI.parse _namespace_name "Rectangle" |> NamespacedName
    /// <summary>
    /// Service provided by an IoT Device
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Service"></see></summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName
    /// <summary>
    /// Tag Device such as QR code or bar code.
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#TagDevice"></see></summary>
    let TagDevice = Namespaced_IRI.parse _namespace_name "TagDevice" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#VirtualEntity"></see>
    /// </summary>
    let VirtualEntity =
        Namespaced_IRI.parse _namespace_name "VirtualEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#altRelative"></see>
    /// </summary>
    let altRelative =
        Namespaced_IRI.parse _namespace_name "altRelative" |> NamespacedName

    /// <summary>
    /// Endpoint of the service. It is usually a URL where the service is available.
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#endpoint"></see></summary>
    let endpoint = Namespaced_IRI.parse _namespace_name "endpoint" |> NamespacedName
    /// <summary>
    /// A device is exposed by a service.
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#exposedBy"></see></summary>
    let exposedBy = Namespaced_IRI.parse _namespace_name "exposedBy" |> NamespacedName
    /// <summary>
    /// For service-oriented queries. The inverse of exposedBy.
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#exposes"></see></summary>
    let exposes = Namespaced_IRI.parse _namespace_name "exposes" |> NamespacedName

    /// <summary>
    /// Links the devices with their attributes.
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#hasAttribute"></see></summary>
    let hasAttribute =
        Namespaced_IRI.parse _namespace_name "hasAttribute" |> NamespacedName

    /// <summary>
    /// Links the devices with their coverages.
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#hasCoverage"></see></summary>
    let hasCoverage =
        Namespaced_IRI.parse _namespace_name "hasCoverage" |> NamespacedName

    /// <summary>
    /// Links any concept with metadata about that concept.
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#hasMetadata"></see></summary>
    let hasMetadata =
        Namespaced_IRI.parse _namespace_name "hasMetadata" |> NamespacedName

    /// <summary>
    /// Links a sensor or an attribute with the quantity  kind it measures (e.g. A sensor -sensor1- measures temperature: sensor1 hasQuantityKind temperature).
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#hasQuantityKind"></see></summary>
    let hasQuantityKind =
        Namespaced_IRI.parse _namespace_name "hasQuantityKind" |> NamespacedName

    /// <summary>
    /// Links a sensor with a sensing device the same way as SSN.
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#hasSensingDevice"></see></summary>
    let hasSensingDevice =
        Namespaced_IRI.parse _namespace_name "hasSensingDevice" |> NamespacedName

    /// <summary>
    /// Links the sensor with the units of the quantity kind it measures (e.g. A sensor -sensor1- measures temperature in Celsius: senso1 hasUnit celsius).
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#hasUnit"></see></summary>
    let hasUnit = Namespaced_IRI.parse _namespace_name "hasUnit" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#id"></see>
    /// </summary>
    let id = Namespaced_IRI.parse _namespace_name "id" |> NamespacedName

    /// <summary>
    /// Description of the service.
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#interfaceDescription"></see></summary>
    let interfaceDescription =
        Namespaced_IRI.parse _namespace_name "interfaceDescription" |> NamespacedName

    /// <summary>
    /// Defines the type of interface of the service endpoint.
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#interfaceType"></see></summary>
    let interfaceType =
        Namespaced_IRI.parse _namespace_name "interfaceType" |> NamespacedName

    /// <summary>
    /// Defines the associations between objects and sensors (e.g. A table (object) has an attribute (temperature at the table) which is associated with a sensor (the temperature sensor of the room).
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#isAssociatedWith"></see></summary>
    let isAssociatedWith =
        Namespaced_IRI.parse _namespace_name "isAssociatedWith" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#isMobile"></see>
    /// </summary>
    let isMobile = Namespaced_IRI.parse _namespace_name "isMobile" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#isSubSystemOf"></see>
    /// </summary>
    let isSubSystemOf =
        Namespaced_IRI.parse _namespace_name "isSubSystemOf" |> NamespacedName

    /// <summary>
    /// Defines the type pf the metadata value (e.g. resolution of the sensor).
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#metadataType"></see></summary>
    let metadataType =
        Namespaced_IRI.parse _namespace_name "metadataType" |> NamespacedName

    /// <summary>
    /// Value of the metadata
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#metadataValue"></see></summary>
    let metadataValue =
        Namespaced_IRI.parse _namespace_name "metadataValue" |> NamespacedName

    /// <summary>
    /// Specifies the radius of a circle coverage defined by a point -the center of the circle- and its radius.
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#radius"></see></summary>
    let radius = Namespaced_IRI.parse _namespace_name "radius" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#relativeLocation"></see>
    /// </summary>
    let relativeLocation =
        Namespaced_IRI.parse _namespace_name "relativeLocation" |> NamespacedName
