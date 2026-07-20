namespace http.purl.oclc.org.NET.UNIS.fiware.iot_lite.hash

open DoxAletheia

module iot_lite =
    let _namespace_name = "http://purl.oclc.org/NET/UNIS/fiware/iot-lite#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Device that can actuate over an object or QuantityKind.
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#ActuatingDevice"></see></summary>
    let ActuatingDevice = _prefix "ActuatingDevice"
    /// <summary>
    /// An attribute of an IoT object that can be exposed by an IoT service (i.e. a room (IoT Object) has a temperature (Attribute), that can be exposed by a temperature sensor (IoT device).
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Attribute"></see></summary>
    let Attribute = _prefix "Attribute"
    /// <summary>
    /// Circle coverage it needs the location of the sensor as the centre of the circle and the radius as a DataProperty.
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Circle"></see></summary>
    let Circle = _prefix "Circle"
    /// <summary>
    /// The coverage of an IoT device (i.e. a temperature sensor inside a room has a coverage of that room).
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Coverage"></see></summary>
    let Coverage = _prefix "Coverage"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Entity"></see>
    /// </summary>
    let Entity = _prefix "Entity"
    /// <summary>
    /// IoT entity
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Object"></see></summary>
    let Object = _prefix "Object"
    /// <summary>
    /// Class used to describe properties that cannot be described by QuantityKind and Units. i.e. the resolution of a sensor.
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Metadata"></see></summary>
    let Metadata = _prefix "Metadata"
    /// <summary>
    /// The coverage is made up by linking several points by strait lines.
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Polygon"></see></summary>
    let Polygon = _prefix "Polygon"
    /// <summary>
    /// Teh coverage is made up by giving two points which are the oposite corners of a rentangle.
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Rectangle"></see></summary>
    let Rectangle = _prefix "Rectangle"
    /// <summary>
    /// Service provided by an IoT Device
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Service"></see></summary>
    let Service = _prefix "Service"
    /// <summary>
    /// Tag Device such as QR code or bar code.
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#TagDevice"></see></summary>
    let TagDevice = _prefix "TagDevice"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#VirtualEntity"></see>
    /// </summary>
    let VirtualEntity = _prefix "VirtualEntity"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#altRelative"></see>
    /// </summary>
    let altRelative = _prefix "altRelative"
    /// <summary>
    /// Endpoint of the service. It is usually a URL where the service is available.
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#endpoint"></see></summary>
    let endpoint = _prefix "endpoint"
    /// <summary>
    /// A device is exposed by a service.
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#exposedBy"></see></summary>
    let exposedBy = _prefix "exposedBy"
    /// <summary>
    /// For service-oriented queries. The inverse of exposedBy.
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#exposes"></see></summary>
    let exposes = _prefix "exposes"
    /// <summary>
    /// Links the devices with their attributes.
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#hasAttribute"></see></summary>
    let hasAttribute = _prefix "hasAttribute"
    /// <summary>
    /// Links the devices with their coverages.
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#hasCoverage"></see></summary>
    let hasCoverage = _prefix "hasCoverage"
    /// <summary>
    /// Links any concept with metadata about that concept.
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#hasMetadata"></see></summary>
    let hasMetadata = _prefix "hasMetadata"
    /// <summary>
    /// Links a sensor or an attribute with the quantity  kind it measures (e.g. A sensor -sensor1- measures temperature: sensor1 hasQuantityKind temperature).
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#hasQuantityKind"></see></summary>
    let hasQuantityKind = _prefix "hasQuantityKind"
    /// <summary>
    /// Links a sensor with a sensing device the same way as SSN.
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#hasSensingDevice"></see></summary>
    let hasSensingDevice = _prefix "hasSensingDevice"
    /// <summary>
    /// Links the sensor with the units of the quantity kind it measures (e.g. A sensor -sensor1- measures temperature in Celsius: senso1 hasUnit celsius).
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#hasUnit"></see></summary>
    let hasUnit = _prefix "hasUnit"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#id"></see>
    /// </summary>
    let id = _prefix "id"
    /// <summary>
    /// Description of the service.
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#interfaceDescription"></see></summary>
    let interfaceDescription = _prefix "interfaceDescription"
    /// <summary>
    /// Defines the type of interface of the service endpoint.
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#interfaceType"></see></summary>
    let interfaceType = _prefix "interfaceType"
    /// <summary>
    /// Defines the associations between objects and sensors (e.g. A table (object) has an attribute (temperature at the table) which is associated with a sensor (the temperature sensor of the room).
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#isAssociatedWith"></see></summary>
    let isAssociatedWith = _prefix "isAssociatedWith"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#isMobile"></see>
    /// </summary>
    let isMobile = _prefix "isMobile"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#isSubSystemOf"></see>
    /// </summary>
    let isSubSystemOf = _prefix "isSubSystemOf"
    /// <summary>
    /// Defines the type pf the metadata value (e.g. resolution of the sensor).
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#metadataType"></see></summary>
    let metadataType = _prefix "metadataType"
    /// <summary>
    /// Value of the metadata
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#metadataValue"></see></summary>
    let metadataValue = _prefix "metadataValue"
    /// <summary>
    /// Specifies the radius of a circle coverage defined by a point -the center of the circle- and its radius.
    /// <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#radius"></see></summary>
    let radius = _prefix "radius"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#relativeLocation"></see>
    /// </summary>
    let relativeLocation = _prefix "relativeLocation"
