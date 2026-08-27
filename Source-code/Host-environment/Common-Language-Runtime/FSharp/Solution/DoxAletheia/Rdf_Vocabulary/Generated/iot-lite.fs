namespace http.purl.oclc.org.NET.UNIS.fiware.iot_lite.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module iot_lite =
    let _namespace_iri = Namespace_Iri iot_lite |> NamespaceIRI
    /// <summary>
    ///   <para>iot-lite:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"iot-lite is a lightweight ontology based on SSN to describe Internet of Things (IoT) concepts and relationships."</para>
    /// labels<para>"iot-lite"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#">http://purl.oclc.org/NET/UNIS/fiware/iot-lite#</seealso>
    let _prefix_iri = Prefixed_Name(iot_lite, "") |> PrefixedName
    /// <summary>
    ///   <para>iot-lite:ActuatingDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device that can actuate over an object or QuantityKind."</para>
    ///   <para>"Device that can actuate over an object or QuantityKind (e.g., switch on/off the light)."</para>
    /// labels<para>"Actuating Device"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#ActuatingDevice">http://purl.oclc.org/NET/UNIS/fiware/iot-lite#ActuatingDevice</seealso>
    let ActuatingDevice = Prefixed_Name(iot_lite, "ActuatingDevice") |> PrefixedName
    /// <summary>
    ///   <para>iot-lite:Attribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An attribute of an IoT object that can be exposed by an IoT service (i.e. a room (IoT Object) has a temperature (Attribute), that can be exposed by a temperature sensor (IoT device)."</para>
    /// labels<para>"Attribute"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Attribute">http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Attribute</seealso>
    let Attribute = Prefixed_Name(iot_lite, "Attribute") |> PrefixedName
    /// <summary>
    ///   <para>iot-lite:Circle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Circle coverage it needs the location of the sensor as the centre of the circle and the radius as a DataProperty."</para>
    /// labels<para>"Circle"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Circle">http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Circle</seealso>
    let Circle = Prefixed_Name(iot_lite, "Circle") |> PrefixedName
    /// <summary>
    ///   <para>iot-lite:Coverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The coverage of an IoT device (i.e. a temperature sensor inside a room has a coverage of that room)."</para>
    /// labels<para>"Coverage"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Coverage">http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Coverage</seealso>
    let Coverage = Prefixed_Name(iot_lite, "Coverage") |> PrefixedName
    /// <summary>
    ///   <para>iot-lite:Entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An IoT Object"</para>
    /// labels<para>"Entity"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Entity">http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Entity</seealso>
    let Entity = Prefixed_Name(iot_lite, "Entity") |> PrefixedName
    /// <summary>
    ///   <para>iot-lite:Metadata</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class used to describe properties that cannot be described by QuantityKind and Units. i.e. the resolution of a sensor."</para>
    /// labels<para>"Metadata"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Metadata">http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Metadata</seealso>
    let Metadata = Prefixed_Name(iot_lite, "Metadata") |> PrefixedName
    /// <summary>
    ///   <para>iot-lite:Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"IoT entity"</para>
    /// labels<para>"IoT Entity or Object"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Object">http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Object</seealso>
    let Object = Prefixed_Name(iot_lite, "Object") |> PrefixedName
    /// <summary>
    ///   <para>iot-lite:Polygon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The coverage is made up by linking several points by strait lines."</para>
    /// labels<para>"Polygon"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Polygon">http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Polygon</seealso>
    let Polygon = Prefixed_Name(iot_lite, "Polygon") |> PrefixedName
    /// <summary>
    ///   <para>iot-lite:Rectangle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Teh coverage is made up by giving two points which are the oposite corners of a rentangle."</para>
    /// labels<para>"Rectangle"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Rectangle">http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Rectangle</seealso>
    let Rectangle = Prefixed_Name(iot_lite, "Rectangle") |> PrefixedName
    /// <summary>
    ///   <para>iot-lite:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Service provided by an IoT Device"</para>
    /// labels<para>"Service"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Service">http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Service</seealso>
    let Service = Prefixed_Name(iot_lite, "Service") |> PrefixedName
    /// <summary>
    ///   <para>iot-lite:Tag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"
    ///         Device that can redirect to a resource with information (i.e. RFID, NFC, QR-codes, bar-codes).
    ///         "</para>
    /// labels<para>"Tagging Device"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Tag">http://purl.oclc.org/NET/UNIS/fiware/iot-lite#Tag</seealso>
    let Tag = Prefixed_Name(iot_lite, "Tag") |> PrefixedName
    /// <summary>
    ///   <para>iot-lite:TagDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device that can redirect to a resource with information (i.e. RFID, NFC, QR-codes, bar-codes)."</para>
    ///   <para>"Tag Device such as QR code or bar code."</para>
    /// labels<para>"Tagging Device"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#TagDevice">http://purl.oclc.org/NET/UNIS/fiware/iot-lite#TagDevice</seealso>
    let TagDevice = Prefixed_Name(iot_lite, "TagDevice") |> PrefixedName
    /// <summary>
    ///   <para>iot-lite:VirtualEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Virtual Entity"</para>
    /// labels<para>"Virtual Entity"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#VirtualEntity">http://purl.oclc.org/NET/UNIS/fiware/iot-lite#VirtualEntity</seealso>
    let VirtualEntity = Prefixed_Name(iot_lite, "VirtualEntity") |> PrefixedName
    /// <summary>
    ///   <para>iot-lite:altRelative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#altRelative">http://purl.oclc.org/NET/UNIS/fiware/iot-lite#altRelative</seealso>
    let altRelative = Prefixed_Name(iot_lite, "altRelative") |> PrefixedName
    /// <summary>
    ///   <para>iot-lite:endpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Endpoint of the service. It is usually a URL where the service is available."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Endpoint"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#endpoint">http://purl.oclc.org/NET/UNIS/fiware/iot-lite#endpoint</seealso>
    let endpoint = Prefixed_Name(iot_lite, "endpoint") |> PrefixedName
    /// <summary>
    ///   <para>iot-lite:exposedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A device is exposed by a service."</para>
    ///   <para>"A device is exposed by a service."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Exposed By"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#exposedBy">http://purl.oclc.org/NET/UNIS/fiware/iot-lite#exposedBy</seealso>
    let exposedBy = Prefixed_Name(iot_lite, "exposedBy") |> PrefixedName
    /// <summary>
    ///   <para>iot-lite:exposes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"For service-oriented queries. The inverse of exposedBy."</para>
    ///   <para>"For service-oriented queries. The inverse of exposedBy."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Exposes"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#exposes">http://purl.oclc.org/NET/UNIS/fiware/iot-lite#exposes</seealso>
    let exposes = Prefixed_Name(iot_lite, "exposes") |> PrefixedName
    /// <summary>
    ///   <para>iot-lite:hasAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links the devices with their attributes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Links the devices with their attributes."</para>
    /// labels<para>"Has Attribute"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#hasAttribute">http://purl.oclc.org/NET/UNIS/fiware/iot-lite#hasAttribute</seealso>
    let hasAttribute = Prefixed_Name(iot_lite, "hasAttribute") |> PrefixedName
    /// <summary>
    ///   <para>iot-lite:hasCoverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links the devices with their coverages."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Links the devices with their coverages."</para>
    /// labels<para>"Has Coverage"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#hasCoverage">http://purl.oclc.org/NET/UNIS/fiware/iot-lite#hasCoverage</seealso>
    let hasCoverage = Prefixed_Name(iot_lite, "hasCoverage") |> PrefixedName
    /// <summary>
    ///   <para>iot-lite:hasMetadata</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links any concept with metadata about that concept."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Links any concept with metadata about that concept."</para>
    /// labels<para>"Has Metadata"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#hasMetadata">http://purl.oclc.org/NET/UNIS/fiware/iot-lite#hasMetadata</seealso>
    let hasMetadata = Prefixed_Name(iot_lite, "hasMetadata") |> PrefixedName
    /// <summary>
    ///   <para>iot-lite:hasQuantityKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a sensor or an attribute with the quantity  kind it measures (e.g. A sensor -sensor1- measures temperature: sensor1 hasQuantityKind temperature)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Links a sensor or an attribute with the quantity  kind it measures (e.g. A sensor -sensor1- measures temperature: sensor1 hasQuantityKind temperature)."</para>
    /// labels<para>"Has Quantity Kind"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#hasQuantityKind">http://purl.oclc.org/NET/UNIS/fiware/iot-lite#hasQuantityKind</seealso>
    let hasQuantityKind = Prefixed_Name(iot_lite, "hasQuantityKind") |> PrefixedName
    /// <summary>
    ///   <para>iot-lite:hasSensingDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a sensor with a sensing device the same way as SSN."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#hasSensingDevice">http://purl.oclc.org/NET/UNIS/fiware/iot-lite#hasSensingDevice</seealso>
    let hasSensingDevice = Prefixed_Name(iot_lite, "hasSensingDevice") |> PrefixedName
    /// <summary>
    ///   <para>iot-lite:hasUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links the sensor with the units of the quantity kind it measures (e.g. A sensor -sensor1- measures temperature in Celsius: senso1 hasUnit celsius)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Has Unit"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#hasUnit">http://purl.oclc.org/NET/UNIS/fiware/iot-lite#hasUnit</seealso>
    let hasUnit = Prefixed_Name(iot_lite, "hasUnit") |> PrefixedName
    /// <summary>
    ///   <para>iot-lite:id</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Defines the ID of the Object or Device"</para>
    /// labels<para>"ID"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#id">http://purl.oclc.org/NET/UNIS/fiware/iot-lite#id</seealso>
    let id = Prefixed_Name(iot_lite, "id") |> PrefixedName

    /// <summary>
    ///   <para>iot-lite:interfaceDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Description of the service."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Interface Description"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#interfaceDescription">http://purl.oclc.org/NET/UNIS/fiware/iot-lite#interfaceDescription</seealso>
    let interfaceDescription =
        Prefixed_Name(iot_lite, "interfaceDescription") |> PrefixedName

    /// <summary>
    ///   <para>iot-lite:interfaceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Defines the type of interface of the service endpoint."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Interface Type"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#interfaceType">http://purl.oclc.org/NET/UNIS/fiware/iot-lite#interfaceType</seealso>
    let interfaceType = Prefixed_Name(iot_lite, "interfaceType") |> PrefixedName
    /// <summary>
    ///   <para>iot-lite:isAssociatedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Defines the associations between objects and sensors (e.g. A table (object) has an attribute (temperature at the table) which is associated with a sensor (the temperature sensor of the room). "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Is Associated With"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#isAssociatedWith">http://purl.oclc.org/NET/UNIS/fiware/iot-lite#isAssociatedWith</seealso>
    let isAssociatedWith = Prefixed_Name(iot_lite, "isAssociatedWith") |> PrefixedName
    /// <summary>
    ///   <para>iot-lite:isMobile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"It is the property to identify is the platform is mobile or not."</para>
    /// labels<para>"Is Mobile"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#isMobile">http://purl.oclc.org/NET/UNIS/fiware/iot-lite#isMobile</seealso>
    let isMobile = Prefixed_Name(iot_lite, "isMobile") |> PrefixedName
    /// <summary>
    ///   <para>iot-lite:isSubSystemOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Defines if a system is a subsystem of another system."</para>
    /// labels<para>"Is Sub System Of"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#isSubSystemOf">http://purl.oclc.org/NET/UNIS/fiware/iot-lite#isSubSystemOf</seealso>
    let isSubSystemOf = Prefixed_Name(iot_lite, "isSubSystemOf") |> PrefixedName
    /// <summary>
    ///   <para>iot-lite:metadataType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Defines the type pf the metadata value (e.g. resolution of the sensor)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Metadata Type"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#metadataType">http://purl.oclc.org/NET/UNIS/fiware/iot-lite#metadataType</seealso>
    let metadataType = Prefixed_Name(iot_lite, "metadataType") |> PrefixedName
    /// <summary>
    ///   <para>iot-lite:metadataValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Value of the metadata"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Metadata Value"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#metadataValue">http://purl.oclc.org/NET/UNIS/fiware/iot-lite#metadataValue</seealso>
    let metadataValue = Prefixed_Name(iot_lite, "metadataValue") |> PrefixedName
    /// <summary>
    ///   <para>iot-lite:radius</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies the radius of a circle coverage defined by a point -the center of the circle- and its radius."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Radius"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#radius">http://purl.oclc.org/NET/UNIS/fiware/iot-lite#radius</seealso>
    let radius = Prefixed_Name(iot_lite, "radius") |> PrefixedName
    /// <summary>
    ///   <para>iot-lite:relativeLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.oclc.org/NET/UNIS/fiware/iot-lite#relativeLocation">http://purl.oclc.org/NET/UNIS/fiware/iot-lite#relativeLocation</seealso>
    let relativeLocation = Prefixed_Name(iot_lite, "relativeLocation") |> PrefixedName
