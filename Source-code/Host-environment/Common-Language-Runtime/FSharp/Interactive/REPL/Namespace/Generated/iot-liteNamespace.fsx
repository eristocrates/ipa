#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``iot-lite`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.oclc.org/NET/UNIS/fiware/iot-lite#" "iot-lite"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : Device that can actuate over an object or QuantityKind.</para>
    ///   <a href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#ActuatingDevice">iot-lite:ActuatingDevice</a>
    /// </summary>
    let ActuatingDevice = _prefixId.prefix "ActuatingDevice"
    /// <summary>
    ///   <para>rdfs:comment : An attribute of an IoT object that can be exposed by an IoT service (i.e. a room (IoT Object) has a temperature (Attribute), that can be exposed by a temperature sensor (IoT device).</para>
    ///   <a href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Attribute">iot-lite:Attribute</a>
    /// </summary>
    let Attribute = _prefixId.prefix "Attribute"
    /// <summary>
    ///   <para>rdfs:comment : Circle coverage it needs the location of the sensor as the centre of the circle and the radius as a DataProperty.</para>
    ///   <a href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Circle">iot-lite:Circle</a>
    /// </summary>
    let Circle = _prefixId.prefix "Circle"
    /// <summary>
    ///   <para>rdfs:comment : The coverage of an IoT device (i.e. a temperature sensor inside a room has a coverage of that room).</para>
    ///   <a href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Coverage">iot-lite:Coverage</a>
    /// </summary>
    let Coverage = _prefixId.prefix "Coverage"
    let Entity = _prefixId.prefix "Entity"
    /// <summary>
    ///   <para>rdfs:comment : Class used to describe properties that cannot be described by QuantityKind and Units. i.e. the resolution of a sensor.</para>
    ///   <a href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Metadata">iot-lite:Metadata</a>
    /// </summary>
    let Metadata = _prefixId.prefix "Metadata"
    /// <summary>
    ///   <para>rdfs:comment : IoT entity</para>
    ///   <a href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Object">iot-lite:Object</a>
    /// </summary>
    let Object = _prefixId.prefix "Object"
    /// <summary>
    ///   <para>rdfs:comment : The coverage is made up by linking several points by strait lines.</para>
    ///   <a href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Polygon">iot-lite:Polygon</a>
    /// </summary>
    let Polygon = _prefixId.prefix "Polygon"
    /// <summary>
    ///   <para>rdfs:comment : Teh coverage is made up by giving two points which are the oposite corners of a rentangle.</para>
    ///   <a href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Rectangle">iot-lite:Rectangle</a>
    /// </summary>
    let Rectangle = _prefixId.prefix "Rectangle"
    /// <summary>
    ///   <para>rdfs:comment : Service provided by an IoT Device</para>
    ///   <a href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Service">iot-lite:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    /// <summary>
    ///   <para>rdfs:comment : Tag Device such as QR code or bar code.</para>
    ///   <a href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#TagDevice">iot-lite:TagDevice</a>
    /// </summary>
    let TagDevice = _prefixId.prefix "TagDevice"
    let VirtualEntity = _prefixId.prefix "VirtualEntity"
    let altRelative = _prefixId.prefix "altRelative"
    /// <summary>
    ///   <para>rdfs:comment : Endpoint of the service. It is usually a URL where the service is available.^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#endpoint">iot-lite:endpoint</a>
    /// </summary>
    let endpoint = _prefixId.prefix "endpoint"
    /// <summary>
    ///   <para>rdfs:comment : A device is exposed by a service.^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#exposedBy">iot-lite:exposedBy</a>
    /// </summary>
    let exposedBy = _prefixId.prefix "exposedBy"
    /// <summary>
    ///   <para>rdfs:comment : For service-oriented queries. The inverse of exposedBy.^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#exposes">iot-lite:exposes</a>
    /// </summary>
    let exposes = _prefixId.prefix "exposes"
    /// <summary>
    ///   <para>rdfs:comment : Links the devices with their attributes.^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#hasAttribute">iot-lite:hasAttribute</a>
    /// </summary>
    let hasAttribute = _prefixId.prefix "hasAttribute"
    /// <summary>
    ///   <para>rdfs:comment : Links the devices with their coverages.^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#hasCoverage">iot-lite:hasCoverage</a>
    /// </summary>
    let hasCoverage = _prefixId.prefix "hasCoverage"
    /// <summary>
    ///   <para>rdfs:comment : Links any concept with metadata about that concept.^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#hasMetadata">iot-lite:hasMetadata</a>
    /// </summary>
    let hasMetadata = _prefixId.prefix "hasMetadata"
    /// <summary>
    ///   <para>rdfs:comment : Links a sensor or an attribute with the quantity  kind it measures (e.g. A sensor -sensor1- measures temperature: sensor1 hasQuantityKind temperature).^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#hasQuantityKind">iot-lite:hasQuantityKind</a>
    /// </summary>
    let hasQuantityKind = _prefixId.prefix "hasQuantityKind"
    /// <summary>
    ///   <para>rdfs:comment : Links a sensor with a sensing device the same way as SSN.^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#hasSensingDevice">iot-lite:hasSensingDevice</a>
    /// </summary>
    let hasSensingDevice = _prefixId.prefix "hasSensingDevice"
    /// <summary>
    ///   <para>rdfs:comment : Links the sensor with the units of the quantity kind it measures (e.g. A sensor -sensor1- measures temperature in Celsius: senso1 hasUnit celsius).^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#hasUnit">iot-lite:hasUnit</a>
    /// </summary>
    let hasUnit = _prefixId.prefix "hasUnit"
    let id = _prefixId.prefix "id"
    /// <summary>
    ///   <para>rdfs:comment : Description of the service.^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#interfaceDescription">iot-lite:interfaceDescription</a>
    /// </summary>
    let interfaceDescription = _prefixId.prefix "interfaceDescription"
    /// <summary>
    ///   <para>rdfs:comment : Defines the type of interface of the service endpoint.^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#interfaceType">iot-lite:interfaceType</a>
    /// </summary>
    let interfaceType = _prefixId.prefix "interfaceType"
    /// <summary>
    ///   <para>rdfs:comment : Defines the associations between objects and sensors (e.g. A table (object) has an attribute (temperature at the table) which is associated with a sensor (the temperature sensor of the room). ^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#isAssociatedWith">iot-lite:isAssociatedWith</a>
    /// </summary>
    let isAssociatedWith = _prefixId.prefix "isAssociatedWith"
    let isMobile = _prefixId.prefix "isMobile"
    let isSubSystemOf = _prefixId.prefix "isSubSystemOf"
    /// <summary>
    ///   <para>rdfs:comment : Defines the type pf the metadata value (e.g. resolution of the sensor).^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#metadataType">iot-lite:metadataType</a>
    /// </summary>
    let metadataType = _prefixId.prefix "metadataType"
    /// <summary>
    ///   <para>rdfs:comment : Value of the metadata^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#metadataValue">iot-lite:metadataValue</a>
    /// </summary>
    let metadataValue = _prefixId.prefix "metadataValue"
    /// <summary>
    ///   <para>rdfs:comment : Specifies the radius of a circle coverage defined by a point -the center of the circle- and its radius.^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#radius">iot-lite:radius</a>
    /// </summary>
    let radius = _prefixId.prefix "radius"
    let relativeLocation = _prefixId.prefix "relativeLocation"
