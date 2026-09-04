#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module s4envi =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://saref.etsi.org/saref4envi/" "s4envi"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Actuator</para>
    ///   <para>rdfs:comment : Device that can act over at least one property.</para>
    ///   <a href="https://saref.etsi.org/saref4envi/Actuator">s4envi:Actuator</a>
    /// </summary>
    let Actuator = _prefixId.prefix "Actuator"
    /// <summary>
    ///   <para>rdfs:label : Color</para>
    ///   <para>rdfs:comment : Color of the emitted light. It might be indicated by named colors or using other type of color values like hexadecimal for RGB, color temperature, etc.</para>
    ///   <a href="https://saref.etsi.org/saref4envi/Color">s4envi:Color</a>
    /// </summary>
    let Color = _prefixId.prefix "Color"
    /// <summary>
    ///   <para>rdfs:label : Communication interface</para>
    ///   <para>rdfs:comment : An interface defines which primitive operations and services the lower layer makes available to the upper one, when referring to network layers. (Definition adapted from "Tanenbaum, A. S. (2003). Computer networks, 4-th edition. ed: Prentice Hall.")</para>
    ///   <a href="https://saref.etsi.org/saref4envi/CommunicationInterface">s4envi:CommunicationInterface</a>
    /// </summary>
    let CommunicationInterface = _prefixId.prefix "CommunicationInterface"
    /// <summary>
    ///   <para>rdfs:label : Communication protocol</para>
    ///   <para>rdfs:comment : A protocol is an agreement between the communicating parties on how communication is to proceed. (Definition taken from "Tanenbaum, A. S. (2003). Computer networks, 4-th edition. ed: Prentice Hall.")</para>
    ///   <a href="https://saref.etsi.org/saref4envi/CommunicationProtocol">s4envi:CommunicationProtocol</a>
    /// </summary>
    let CommunicationProtocol = _prefixId.prefix "CommunicationProtocol"
    /// <summary>
    ///   <para>rdfs:label : Compass direction</para>
    ///   <para>rdfs:comment : The four cardinal directions or cardinal points are the directions of north, east, south, and west, commonly denoted by their initials: N, E, S, W. East and west are at right angles to north and south, with east being in the clockwise direction of rotation from north and west being directly opposite east. Intermediate points between the four cardinal directions form the points of the compass. (definition taken from https://en.wikipedia.org/wiki/Cardinal_direction)</para>
    ///   <a href="https://saref.etsi.org/saref4envi/CompassDirection">s4envi:CompassDirection</a>
    /// </summary>
    let CompassDirection = _prefixId.prefix "CompassDirection"
    /// <summary>
    ///   <para>rdfs:comment : A thing made or adapted for a particular purpose, especially a piece of mechanical or electronic equipment. For example ‘a measuring device’ (definition taken from https://en.oxforddictionaries.com/definition/device). In this ontology it refers to the devices for environmental purposes.</para>
    ///   <para>rdfs:label : Device</para>
    ///   <a href="https://saref.etsi.org/saref4envi/Device">s4envi:Device</a>
    /// </summary>
    let Device = _prefixId.prefix "Device"
    /// <summary>
    ///   <para>rdfs:comment : A digital representation encapsulates a physical object accessible via Web services</para>
    ///   <para>rdfs:label : Digital representation</para>
    ///   <a href="https://saref.etsi.org/saref4envi/DigitalRepresentation">s4envi:DigitalRepresentation</a>
    /// </summary>
    let DigitalRepresentation = _prefixId.prefix "DigitalRepresentation"
    let Fluorescence = _prefixId.prefix "Fluorescence"
    let Frequency = _prefixId.prefix "Frequency"
    /// <summary>
    ///   <para>rdfs:label : Frequency measurement</para>
    ///   <para>rdfs:comment : Represents the measured value made over a frequency property. It is also linked to the frequency unit of measure in which the value is expressed and the timestamp of the measurement.</para>
    ///   <a href="https://saref.etsi.org/saref4envi/FrequencyMeasurement">s4envi:FrequencyMeasurement</a>
    /// </summary>
    let FrequencyMeasurement = _prefixId.prefix "FrequencyMeasurement"
    /// <summary>
    ///   <para>rdfs:label : Frequency unit</para>
    ///   <para>rdfs:comment : Unit of measure for the quantity frequency.</para>
    ///   <a href="https://saref.etsi.org/saref4envi/FrequencyUnit">s4envi:FrequencyUnit</a>
    /// </summary>
    let FrequencyUnit = _prefixId.prefix "FrequencyUnit"
    /// <summary>
    ///   <para>rdfs:label : Geometry</para>
    ///   <para>rdfs:comment : Represents the shape of the light emission. It might be instantiated by individuals like "spherical", "cylindrical", etc. even though it is open to more comples representation of geometries using other vocabularies.</para>
    ///   <a href="https://saref.etsi.org/saref4envi/Geometry">s4envi:Geometry</a>
    /// </summary>
    let Geometry = _prefixId.prefix "Geometry"
    let Height = _prefixId.prefix "Height"
    /// <summary>
    ///   <para>rdfs:label : Height measurement</para>
    ///   <para>rdfs:comment : Represents the measured value made over a height property. It is also linked to the height unit of measure in which the value is expressed and the timestamp of the measurement.</para>
    ///   <a href="https://saref.etsi.org/saref4envi/HeightMeasurement">s4envi:HeightMeasurement</a>
    /// </summary>
    let HeightMeasurement = _prefixId.prefix "HeightMeasurement"
    let Illuminance = _prefixId.prefix "Illuminance"
    let Irradiance = _prefixId.prefix "Irradiance"
    /// <summary>
    ///   <para>rdfs:label : Lamppost</para>
    ///   <para>rdfs:comment : A tall pole with a light at the top.</para>
    ///   <a href="https://saref.etsi.org/saref4envi/Lamppost">s4envi:Lamppost</a>
    /// </summary>
    let Lamppost = _prefixId.prefix "Lamppost"
    /// <summary>
    ///   <para>rdfs:label : Length unit</para>
    ///   <para>rdfs:comment : Unit of measure for the quantity lenght.</para>
    ///   <a href="https://saref.etsi.org/saref4envi/LengthUnit">s4envi:LengthUnit</a>
    /// </summary>
    let LengthUnit = _prefixId.prefix "LengthUnit"
    /// <summary>
    ///   <para>rdfs:label : Light</para>
    ///   <para>rdfs:comment : A light source, which may be a lantern, a street light, a floodlight, a signal lamp or any other device whose primary purpose is the generation of light. (Definition taken from http://wiki.openstreetmap.org/wiki/Proposed_features/Key:light_source#Description)</para>
    ///   <a href="https://saref.etsi.org/saref4envi/Light">s4envi:Light</a>
    /// </summary>
    let Light = _prefixId.prefix "Light"
    let LightAbsorption = _prefixId.prefix "LightAbsorption"
    let LightMagnitude = _prefixId.prefix "LightMagnitude"
    /// <summary>
    ///   <para>rdfs:label : Light point</para>
    ///   <para>rdfs:comment : An spatial point from where a light is projected. It might belong to a lamppost.</para>
    ///   <a href="https://saref.etsi.org/saref4envi/LightPoint">s4envi:LightPoint</a>
    /// </summary>
    let LightPoint = _prefixId.prefix "LightPoint"
    /// <summary>
    ///   <para>rdfs:label : Light property</para>
    ///   <para>rdfs:comment : An aspect of light that can be observable by a sensor.</para>
    ///   <a href="https://saref.etsi.org/saref4envi/LightProperty">s4envi:LightProperty</a>
    /// </summary>
    let LightProperty = _prefixId.prefix "LightProperty"
    let Luminiscence = _prefixId.prefix "Luminiscence"
    let Period = _prefixId.prefix "Period"
    /// <summary>
    ///   <para>rdfs:label : Period measurement</para>
    ///   <para>rdfs:comment : Represents the measured value over a period property. It is also linked to the period unit of measure in which the value is expressed and the timestamp of the measurement.</para>
    ///   <a href="https://saref.etsi.org/saref4envi/PeriodMeasurement">s4envi:PeriodMeasurement</a>
    /// </summary>
    let PeriodMeasurement = _prefixId.prefix "PeriodMeasurement"
    let Phosphorescence = _prefixId.prefix "Phosphorescence"
    /// <summary>
    ///   <para>rdfs:label : Photometer</para>
    ///   <para>rdfs:comment : A photometer, generally, is an instrument that measures light intensity or optical properties of solutions or surfaces.</para>
    ///   <a href="https://saref.etsi.org/saref4envi/Photometer">s4envi:Photometer</a>
    /// </summary>
    let Photometer = _prefixId.prefix "Photometer"
    /// <summary>
    ///   <para>rdfs:label : Physical object</para>
    ///   <para>rdfs:comment : Any Object that has a proper space region.  (Definition extracted from DUL ontology)</para>
    ///   <a href="https://saref.etsi.org/saref4envi/PhysicalObject">s4envi:PhysicalObject</a>
    /// </summary>
    let PhysicalObject = _prefixId.prefix "PhysicalObject"
    let ReflectionOfLight = _prefixId.prefix "ReflectionOfLight"
    let ScatteringOfLight = _prefixId.prefix "ScatteringOfLight"
    /// <summary>
    ///   <para>rdfs:label : System</para>
    ///   <para>rdfs:comment : A group of related hardware units or programs or both, especially when dedicated to a single application. (Definition taken from https://en.oxforddictionaries.com/definition/system)</para>
    ///   <a href="https://saref.etsi.org/saref4envi/System">s4envi:System</a>
    /// </summary>
    let System = _prefixId.prefix "System"
    /// <summary>
    ///   <para>rdfs:label : TESS (Telescope Encoder and Sky Sensor)</para>
    ///   <para>rdfs:comment : The Telescope Encoder and Sky Sensor (TESS) is a Sky Brightness and Cloud detector developed as a device for a remote observatory. A TESS can observe the light magnitude and other properties as ambient temperature and sky temperature.</para>
    ///   <a href="https://saref.etsi.org/saref4envi/TESS">s4envi:TESS</a>
    /// </summary>
    let TESS = _prefixId.prefix "TESS"
    /// <summary>
    ///   <para>rdfs:label : affects property</para>
    ///   <para>rdfs:comment : A relation between an actuator with the property or properties it can act on</para>
    ///   <a href="https://saref.etsi.org/saref4envi/affectsProperty">s4envi:affectsProperty</a>
    /// </summary>
    let affectsProperty = _prefixId.prefix "affectsProperty"
    /// <summary>
    ///   <para>rdfs:label : contains</para>
    ///   <para>rdfs:comment : A relation between a physical object and the physical objects that can be contained in it.</para>
    ///   <a href="https://saref.etsi.org/saref4envi/contains">s4envi:contains</a>
    /// </summary>
    let contains = _prefixId.prefix "contains"
    /// <summary>
    ///   <para>rdfs:label : encapsulates</para>
    ///   <para>rdfs:comment : A relation between a digital representation and the physical objects it represents.</para>
    ///   <a href="https://saref.etsi.org/saref4envi/encapsulates">s4envi:encapsulates</a>
    /// </summary>
    let encapsulates = _prefixId.prefix "encapsulates"
    /// <summary>
    ///   <para>rdfs:label : has color</para>
    ///   <para>rdfs:comment : A relation between a light emitted and its color.</para>
    ///   <a href="https://saref.etsi.org/saref4envi/hasColor">s4envi:hasColor</a>
    /// </summary>
    let hasColor = _prefixId.prefix "hasColor"
    /// <summary>
    ///   <para>rdfs:label : has component</para>
    ///   <para>rdfs:comment : A relation between a system and the system in which it might be decomposed.</para>
    ///   <a href="https://saref.etsi.org/saref4envi/hasComponent">s4envi:hasComponent</a>
    /// </summary>
    let hasComponent = _prefixId.prefix "hasComponent"
    /// <summary>
    ///   <para>rdfs:label : has creation date</para>
    ///   <para>rdfs:comment : A relationship defining the creation date of an entity (e.g., a digital representation).</para>
    ///   <a href="https://saref.etsi.org/saref4envi/hasCreationDate">s4envi:hasCreationDate</a>
    /// </summary>
    let hasCreationDate = _prefixId.prefix "hasCreationDate"
    /// <summary>
    ///   <para>rdfs:label : has digital representation</para>
    ///   <para>rdfs:comment : A relation between a physical object and the digital representation in which it is encapsulated.</para>
    ///   <a href="https://saref.etsi.org/saref4envi/hasDigitalRepresentation">s4envi:hasDigitalRepresentation</a>
    /// </summary>
    let hasDigitalRepresentation = _prefixId.prefix "hasDigitalRepresentation"
    /// <summary>
    ///   <para>rdfs:label : has flash</para>
    ///   <para>rdfs:comment : A relationship stating whether a light has flash.</para>
    ///   <a href="https://saref.etsi.org/saref4envi/hasFlash">s4envi:hasFlash</a>
    /// </summary>
    let hasFlash = _prefixId.prefix "hasFlash"
    /// <summary>
    ///   <para>rdfs:label : has frequency measurement</para>
    ///   <para>rdfs:comment : The relation between a device and the frequency in which it makes measurements.</para>
    ///   <a href="https://saref.etsi.org/saref4envi/hasFrequencyMeasurement">s4envi:hasFrequencyMeasurement</a>
    /// </summary>
    let hasFrequencyMeasurement = _prefixId.prefix "hasFrequencyMeasurement"
    /// <summary>
    ///   <para>rdfs:label : has geometry</para>
    ///   <para>rdfs:comment : A relation between a light emitted and the shape it is projected in.</para>
    ///   <a href="https://saref.etsi.org/saref4envi/hasGeometry">s4envi:hasGeometry</a>
    /// </summary>
    let hasGeometry = _prefixId.prefix "hasGeometry"
    /// <summary>
    ///   <para>rdfs:label : has identifier</para>
    ///   <para>rdfs:comment : A relationship providing the identifier of an entity (e.g., digital representation)</para>
    ///   <a href="https://saref.etsi.org/saref4envi/hasIdentifier">s4envi:hasIdentifier</a>
    /// </summary>
    let hasIdentifier = _prefixId.prefix "hasIdentifier"
    /// <summary>
    ///   <para>rdfs:label : has light point</para>
    ///   <para>rdfs:comment : A relation between a lamppost and its light points</para>
    ///   <a href="https://saref.etsi.org/saref4envi/hasLightPoint">s4envi:hasLightPoint</a>
    /// </summary>
    let hasLightPoint = _prefixId.prefix "hasLightPoint"
    /// <summary>
    ///   <para>rdfs:label : has projection angle</para>
    ///   <para>rdfs:comment : A relationship defining the projection angle of an entity (e.g., a light).</para>
    ///   <a href="https://saref.etsi.org/saref4envi/hasProjectionAngle">s4envi:hasProjectionAngle</a>
    /// </summary>
    let hasProjectionAngle = _prefixId.prefix "hasProjectionAngle"
    /// <summary>
    ///   <para>rdfs:label : has revision number</para>
    ///   <para>rdfs:comment : A relationship defining the revision number of a certain entity (e.g., a device)</para>
    ///   <a href="https://saref.etsi.org/saref4envi/hasRevisionNumber">s4envi:hasRevisionNumber</a>
    /// </summary>
    let hasRevisionNumber = _prefixId.prefix "hasRevisionNumber"
    /// <summary>
    ///   <para>rdfs:label : has shield</para>
    ///   <para>rdfs:comment : A relationship stating whether a lamppost has a shield.</para>
    ///   <a href="https://saref.etsi.org/saref4envi/hasShield">s4envi:hasShield</a>
    /// </summary>
    let hasShield = _prefixId.prefix "hasShield"
    /// <summary>
    ///   <para>rdfs:label : has tag</para>
    ///   <para>rdfs:comment : A relationship stating the tags that can be assigned to an entity (e.g., a digital representation).</para>
    ///   <a href="https://saref.etsi.org/saref4envi/hasTag">s4envi:hasTag</a>
    /// </summary>
    let hasTag = _prefixId.prefix "hasTag"
    /// <summary>
    ///   <para>rdfs:label : has transmission period</para>
    ///   <para>rdfs:comment : The relation between a device and the period in which it transmit information.</para>
    ///   <a href="https://saref.etsi.org/saref4envi/hasTransmissionPeriod">s4envi:hasTransmissionPeriod</a>
    /// </summary>
    let hasTransmissionPeriod = _prefixId.prefix "hasTransmissionPeriod"
    /// <summary>
    ///   <para>rdfs:label : has version</para>
    ///   <para>rdfs:comment : A relationship defining the version  of a certain entity (e.g., a device)</para>
    ///   <a href="https://saref.etsi.org/saref4envi/hasVersion">s4envi:hasVersion</a>
    /// </summary>
    let hasVersion = _prefixId.prefix "hasVersion"
    /// <summary>
    ///   <para>rdfs:label : is accesible through</para>
    ///   <para>rdfs:comment : The relation between a digital representation and the service which it is accesible through.</para>
    ///   <a href="https://saref.etsi.org/saref4envi/isAccesibleThrough">s4envi:isAccesibleThrough</a>
    /// </summary>
    let isAccesibleThrough = _prefixId.prefix "isAccesibleThrough"
    /// <summary>
    ///   <para>rdfs:label : is component of</para>
    ///   <para>rdfs:comment : A relation between a system and the system it belongs to as a component.</para>
    ///   <a href="https://saref.etsi.org/saref4envi/isComponentOf">s4envi:isComponentOf</a>
    /// </summary>
    let isComponentOf = _prefixId.prefix "isComponentOf"
    /// <summary>
    ///   <para>rdfs:label : is connected to</para>
    ///   <para>rdfs:comment : A relation between a system and the system to which it is connected.</para>
    ///   <a href="https://saref.etsi.org/saref4envi/isConnectedTo">s4envi:isConnectedTo</a>
    /// </summary>
    let isConnectedTo = _prefixId.prefix "isConnectedTo"
    /// <summary>
    ///   <para>rdfs:label : is contained in</para>
    ///   <para>rdfs:comment : A relation between a physical object and the physical object in which it might be contained.</para>
    ///   <a href="https://saref.etsi.org/saref4envi/isContainedIn">s4envi:isContainedIn</a>
    /// </summary>
    let isContainedIn = _prefixId.prefix "isContainedIn"
    /// <summary>
    ///   <para>rdfs:label : is projected from height</para>
    ///   <para>rdfs:comment : A relation between a light and the height measurement from which it is projected.</para>
    ///   <a href="https://saref.etsi.org/saref4envi/isProjectedFromHeight">s4envi:isProjectedFromHeight</a>
    /// </summary>
    let isProjectedFromHeight = _prefixId.prefix "isProjectedFromHeight"
    /// <summary>
    ///   <para>rdfs:label : is projected in direction</para>
    ///   <para>rdfs:comment : A relation between a light and the direction in which it is projected.</para>
    ///   <a href="https://saref.etsi.org/saref4envi/isProjectedInDirection">s4envi:isProjectedInDirection</a>
    /// </summary>
    let isProjectedInDirection = _prefixId.prefix "isProjectedInDirection"
    /// <summary>
    ///   <para>rdfs:label : projects light</para>
    ///   <para>rdfs:comment : A relation between a lamppost or a light point and the light (or lights) they might project.</para>
    ///   <a href="https://saref.etsi.org/saref4envi/projectsLight">s4envi:projectsLight</a>
    /// </summary>
    let projectsLight = _prefixId.prefix "projectsLight"
    /// <summary>
    ///   <para>rdfs:label : uses communication interface</para>
    ///   <para>rdfs:comment : A relation between a system and the communication interface it uses.</para>
    ///   <a href="https://saref.etsi.org/saref4envi/usesCommunicationInterface">s4envi:usesCommunicationInterface</a>
    /// </summary>
    let usesCommunicationInterface = _prefixId.prefix "usesCommunicationInterface"
    /// <summary>
    ///   <para>rdfs:label : uses communication protocol</para>
    ///   <para>rdfs:comment : A relation between a system and the communication protocol it uses.</para>
    ///   <a href="https://saref.etsi.org/saref4envi/usesCommunicationProtocol">s4envi:usesCommunicationProtocol</a>
    /// </summary>
    let usesCommunicationProtocol = _prefixId.prefix "usesCommunicationProtocol"
