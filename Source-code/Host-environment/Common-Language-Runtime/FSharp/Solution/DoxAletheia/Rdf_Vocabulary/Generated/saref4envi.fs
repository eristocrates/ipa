namespace https.saref.etsi.org.saref4envi.slash

open DoxAletheia

module saref4envi =
    let _namespace_name = "https://saref.etsi.org/saref4envi/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Represents the shape of the light emission. It might be instantiated by individuals like "spherical", "cylindrical", etc. even though it is open to more comples representation of geometries using other vocabularies.
    /// <see href="https://saref.etsi.org/saref4envi/Geometry"></see></summary>
    let Geometry = _prefix "Geometry"
    /// <summary>
    /// An interface defines which primitive operations and services the lower layer makes available to the upper one, when referring to network layers. (Definition adapted from "Tanenbaum, A. S. (2003). Computer networks, 4-th edition. ed: Prentice Hall.")
    /// <see href="https://saref.etsi.org/saref4envi/CommunicationInterface"></see></summary>
    let CommunicationInterface = _prefix "CommunicationInterface"
    /// <summary>
    /// A digital representation encapsulates a physical object accessible via Web services
    /// <see href="https://saref.etsi.org/saref4envi/DigitalRepresentation"></see></summary>
    let DigitalRepresentation = _prefix "DigitalRepresentation"
    /// <summary>
    /// Color of the emitted light. It might be indicated by named colors or using other type of color values like hexadecimal for RGB, color temperature, etc.
    /// <see href="https://saref.etsi.org/saref4envi/Color"></see></summary>
    let Color = _prefix "Color"
    /// <summary>
    /// The four cardinal directions or cardinal points are the directions of north, east, south, and west, commonly denoted by their initials: N, E, S, W. East and west are at right angles to north and south, with east being in the clockwise direction of rotation from north and west being directly opposite east. Intermediate points between the four cardinal directions form the points of the compass. (definition taken from https://en.wikipedia.org/wiki/Cardinal_direction)
    /// <see href="https://saref.etsi.org/saref4envi/CompassDirection"></see></summary>
    let CompassDirection = _prefix "CompassDirection"
    /// <summary>
    /// A protocol is an agreement between the communicating parties on how communication is to proceed. (Definition taken from "Tanenbaum, A. S. (2003). Computer networks, 4-th edition. ed: Prentice Hall.")
    /// <see href="https://saref.etsi.org/saref4envi/CommunicationProtocol"></see></summary>
    let CommunicationProtocol = _prefix "CommunicationProtocol"
    /// <summary>
    /// Unit of measure for the quantity lenght.
    /// <see href="https://saref.etsi.org/saref4envi/LengthUnit"></see></summary>
    let LengthUnit = _prefix "LengthUnit"
    /// <summary>
    /// Unit of measure for the quantity frequency.
    /// <see href="https://saref.etsi.org/saref4envi/FrequencyUnit"></see></summary>
    let FrequencyUnit = _prefix "FrequencyUnit"
    /// <summary>
    /// A light source, which may be a lantern, a street light, a floodlight, a signal lamp or any other device whose primary purpose is the generation of light. (Definition taken from http://wiki.openstreetmap.org/wiki/Proposed_features/Key:light_source#Description)
    /// <see href="https://saref.etsi.org/saref4envi/Light"></see></summary>
    let Light = _prefix "Light"
    /// <summary>
    ///   <see href="https://saref.etsi.org/saref4envi/v1.1.2/"></see>
    /// </summary>
    let ``v1.1.2/`` = _prefix "v1.1.2/"
    /// <summary>
    /// Device that can act over at least one property.
    /// <see href="https://saref.etsi.org/saref4envi/Actuator"></see></summary>
    let Actuator = _prefix "Actuator"
    /// <summary>
    /// A relation between an actuator with the property or properties it can act on
    /// <see href="https://saref.etsi.org/saref4envi/affectsProperty"></see></summary>
    let affectsProperty = _prefix "affectsProperty"
    /// <summary>
    /// A thing made or adapted for a particular purpose, especially a piece of mechanical or electronic equipment. For example ‘a measuring device’ (definition taken from https://en.oxforddictionaries.com/definition/device). In this ontology it refers to the devices for environmental purposes.
    /// <see href="https://saref.etsi.org/saref4envi/Device"></see></summary>
    let Device = _prefix "Device"
    /// <summary>
    /// A relationship defining the version  of a certain entity (e.g., a device)
    /// <see href="https://saref.etsi.org/saref4envi/hasVersion"></see></summary>
    let hasVersion = _prefix "hasVersion"
    /// <summary>
    /// The relation between a device and the period in which it transmit information.
    /// <see href="https://saref.etsi.org/saref4envi/hasTransmissionPeriod"></see></summary>
    let hasTransmissionPeriod = _prefix "hasTransmissionPeriod"
    /// <summary>
    /// Represents the measured value over a period property. It is also linked to the period unit of measure in which the value is expressed and the timestamp of the measurement.
    /// <see href="https://saref.etsi.org/saref4envi/PeriodMeasurement"></see></summary>
    let PeriodMeasurement = _prefix "PeriodMeasurement"
    /// <summary>
    /// A group of related hardware units or programs or both, especially when dedicated to a single application. (Definition taken from https://en.oxforddictionaries.com/definition/system)
    /// <see href="https://saref.etsi.org/saref4envi/System"></see></summary>
    let System = _prefix "System"
    /// <summary>
    /// A relation between a physical object and the physical object in which it might be contained.
    /// <see href="https://saref.etsi.org/saref4envi/isContainedIn"></see></summary>
    let isContainedIn = _prefix "isContainedIn"
    /// <summary>
    /// Any Object that has a proper space region.  (Definition extracted from DUL ontology)
    /// <see href="https://saref.etsi.org/saref4envi/PhysicalObject"></see></summary>
    let PhysicalObject = _prefix "PhysicalObject"
    /// <summary>
    /// A relationship defining the revision number of a certain entity (e.g., a device)
    /// <see href="https://saref.etsi.org/saref4envi/hasRevisionNumber"></see></summary>
    let hasRevisionNumber = _prefix "hasRevisionNumber"
    /// <summary>
    /// The relation between a device and the frequency in which it makes measurements.
    /// <see href="https://saref.etsi.org/saref4envi/hasFrequencyMeasurement"></see></summary>
    let hasFrequencyMeasurement = _prefix "hasFrequencyMeasurement"
    /// <summary>
    /// Represents the measured value made over a frequency property. It is also linked to the frequency unit of measure in which the value is expressed and the timestamp of the measurement.
    /// <see href="https://saref.etsi.org/saref4envi/FrequencyMeasurement"></see></summary>
    let FrequencyMeasurement = _prefix "FrequencyMeasurement"
    /// <summary>
    /// A relationship stating the tags that can be assigned to an entity (e.g., a digital representation).
    /// <see href="https://saref.etsi.org/saref4envi/hasTag"></see></summary>
    let hasTag = _prefix "hasTag"
    /// <summary>
    /// A relation between a digital representation and the physical objects it represents.
    /// <see href="https://saref.etsi.org/saref4envi/encapsulates"></see></summary>
    let encapsulates = _prefix "encapsulates"
    /// <summary>
    /// A relationship providing the identifier of an entity (e.g., digital representation)
    /// <see href="https://saref.etsi.org/saref4envi/hasIdentifier"></see></summary>
    let hasIdentifier = _prefix "hasIdentifier"
    /// <summary>
    /// A relationship defining the creation date of an entity (e.g., a digital representation).
    /// <see href="https://saref.etsi.org/saref4envi/hasCreationDate"></see></summary>
    let hasCreationDate = _prefix "hasCreationDate"
    /// <summary>
    /// The relation between a digital representation and the service which it is accesible through.
    /// <see href="https://saref.etsi.org/saref4envi/isAccesibleThrough"></see></summary>
    let isAccesibleThrough = _prefix "isAccesibleThrough"
    /// <summary>
    /// An individual representing the light property fluorescence.
    /// <see href="https://saref.etsi.org/saref4envi/Fluorescence"></see></summary>
    let Fluorescence = _prefix "Fluorescence"
    /// <summary>
    /// An aspect of light that can be observable by a sensor.
    /// <see href="https://saref.etsi.org/saref4envi/LightProperty"></see></summary>
    let LightProperty = _prefix "LightProperty"
    /// <summary>
    /// An individual representing the property frequency.
    /// <see href="https://saref.etsi.org/saref4envi/Frequency"></see></summary>
    let Frequency = _prefix "Frequency"
    /// <summary>
    /// An individual representing the property height.
    /// <see href="https://saref.etsi.org/saref4envi/Height"></see></summary>
    let Height = _prefix "Height"
    /// <summary>
    /// Represents the measured value made over a height property. It is also linked to the height unit of measure in which the value is expressed and the timestamp of the measurement.
    /// <see href="https://saref.etsi.org/saref4envi/HeightMeasurement"></see></summary>
    let HeightMeasurement = _prefix "HeightMeasurement"
    /// <summary>
    /// An individual representing the light property illuminance.
    /// <see href="https://saref.etsi.org/saref4envi/Illuminance"></see></summary>
    let Illuminance = _prefix "Illuminance"
    /// <summary>
    /// An individual representing the light property irradiance.
    /// <see href="https://saref.etsi.org/saref4envi/Irradiance"></see></summary>
    let Irradiance = _prefix "Irradiance"
    /// <summary>
    /// A tall pole with a light at the top.
    /// <see href="https://saref.etsi.org/saref4envi/Lamppost"></see></summary>
    let Lamppost = _prefix "Lamppost"
    /// <summary>
    /// A relation between a lamppost and its light points
    /// <see href="https://saref.etsi.org/saref4envi/hasLightPoint"></see></summary>
    let hasLightPoint = _prefix "hasLightPoint"
    /// <summary>
    /// An spatial point from where a light is projected. It might belong to a lamppost.
    /// <see href="https://saref.etsi.org/saref4envi/LightPoint"></see></summary>
    let LightPoint = _prefix "LightPoint"
    /// <summary>
    /// A relation between a lamppost or a light point and the light (or lights) they might project.
    /// <see href="https://saref.etsi.org/saref4envi/projectsLight"></see></summary>
    let projectsLight = _prefix "projectsLight"
    /// <summary>
    /// A relationship stating whether a lamppost has a shield.
    /// <see href="https://saref.etsi.org/saref4envi/hasShield"></see></summary>
    let hasShield = _prefix "hasShield"
    /// <summary>
    /// A relation between a light emitted and its color.
    /// <see href="https://saref.etsi.org/saref4envi/hasColor"></see></summary>
    let hasColor = _prefix "hasColor"
    /// <summary>
    /// A relation between a light emitted and the shape it is projected in.
    /// <see href="https://saref.etsi.org/saref4envi/hasGeometry"></see></summary>
    let hasGeometry = _prefix "hasGeometry"
    /// <summary>
    /// A relation between a light and the height measurement from which it is projected.
    /// <see href="https://saref.etsi.org/saref4envi/isProjectedFromHeight"></see></summary>
    let isProjectedFromHeight = _prefix "isProjectedFromHeight"
    /// <summary>
    /// A relation between a light and the direction in which it is projected.
    /// <see href="https://saref.etsi.org/saref4envi/isProjectedInDirection"></see></summary>
    let isProjectedInDirection = _prefix "isProjectedInDirection"
    /// <summary>
    /// A relationship stating whether a light has flash.
    /// <see href="https://saref.etsi.org/saref4envi/hasFlash"></see></summary>
    let hasFlash = _prefix "hasFlash"
    /// <summary>
    /// A relationship defining the projection angle of an entity (e.g., a light).
    /// <see href="https://saref.etsi.org/saref4envi/hasProjectionAngle"></see></summary>
    let hasProjectionAngle = _prefix "hasProjectionAngle"
    /// <summary>
    /// An individual representing the light property light absorption.
    /// <see href="https://saref.etsi.org/saref4envi/LightAbsorption"></see></summary>
    let LightAbsorption = _prefix "LightAbsorption"
    /// <summary>
    /// An individual representing the light property light magnitude.
    /// <see href="https://saref.etsi.org/saref4envi/LightMagnitude"></see></summary>
    let LightMagnitude = _prefix "LightMagnitude"
    /// <summary>
    /// An individual representing the light property luminiscence.
    /// <see href="https://saref.etsi.org/saref4envi/Luminiscence"></see></summary>
    let Luminiscence = _prefix "Luminiscence"
    /// <summary>
    /// An individual representing the property period.
    /// <see href="https://saref.etsi.org/saref4envi/Period"></see></summary>
    let Period = _prefix "Period"
    /// <summary>
    /// An individual representing the light property phosphorescence.
    /// <see href="https://saref.etsi.org/saref4envi/Phosphorescence"></see></summary>
    let Phosphorescence = _prefix "Phosphorescence"
    /// <summary>
    /// A photometer, generally, is an instrument that measures light intensity or optical properties of solutions or surfaces.
    /// <see href="https://saref.etsi.org/saref4envi/Photometer"></see></summary>
    let Photometer = _prefix "Photometer"
    /// <summary>
    /// A relation between a physical object and the physical objects that can be contained in it.
    /// <see href="https://saref.etsi.org/saref4envi/contains"></see></summary>
    let contains = _prefix "contains"
    /// <summary>
    /// A relation between a physical object and the digital representation in which it is encapsulated.
    /// <see href="https://saref.etsi.org/saref4envi/hasDigitalRepresentation"></see></summary>
    let hasDigitalRepresentation = _prefix "hasDigitalRepresentation"
    /// <summary>
    /// An individual representing the light property reflection of light.
    /// <see href="https://saref.etsi.org/saref4envi/ReflectionOfLight"></see></summary>
    let ReflectionOfLight = _prefix "ReflectionOfLight"
    /// <summary>
    /// An individual representing the light property scattering of light.
    /// <see href="https://saref.etsi.org/saref4envi/ScatteringOfLight"></see></summary>
    let ScatteringOfLight = _prefix "ScatteringOfLight"
    /// <summary>
    /// A relation between a system and the system in which it might be decomposed.
    /// <see href="https://saref.etsi.org/saref4envi/hasComponent"></see></summary>
    let hasComponent = _prefix "hasComponent"
    /// <summary>
    /// A relation between a system and the system it belongs to as a component.
    /// <see href="https://saref.etsi.org/saref4envi/isComponentOf"></see></summary>
    let isComponentOf = _prefix "isComponentOf"
    /// <summary>
    /// A relation between a system and the system to which it is connected.
    /// <see href="https://saref.etsi.org/saref4envi/isConnectedTo"></see></summary>
    let isConnectedTo = _prefix "isConnectedTo"
    /// <summary>
    /// A relation between a system and the communication interface it uses.
    /// <see href="https://saref.etsi.org/saref4envi/usesCommunicationInterface"></see></summary>
    let usesCommunicationInterface = _prefix "usesCommunicationInterface"
    /// <summary>
    /// A relation between a system and the communication protocol it uses.
    /// <see href="https://saref.etsi.org/saref4envi/usesCommunicationProtocol"></see></summary>
    let usesCommunicationProtocol = _prefix "usesCommunicationProtocol"
    /// <summary>
    /// The Telescope Encoder and Sky Sensor (TESS) is a Sky Brightness and Cloud detector developed as a device for a remote observatory. A TESS can observe the light magnitude and other properties as ambient temperature and sky temperature.
    /// <see href="https://saref.etsi.org/saref4envi/TESS"></see></summary>
    let TESS = _prefix "TESS"
