namespace https.saref.etsi.org.saref4envi.slash

open DoxAletheia.Rdf_Vocabulary

module saref4envi =
    let _namespace_name = "https://saref.etsi.org/saref4envi/"
    /// <summary>
    /// Represents the shape of the light emission. It might be instantiated by individuals like "spherical", "cylindrical", etc. even though it is open to more comples representation of geometries using other vocabularies.
    /// <see href="https://saref.etsi.org/saref4envi/Geometry"></see></summary>
    let Geometry = Namespaced_IRI.parse _namespace_name "Geometry" |> NamespacedName

    /// <summary>
    /// An interface defines which primitive operations and services the lower layer makes available to the upper one, when referring to network layers. (Definition adapted from "Tanenbaum, A. S. (2003). Computer networks, 4-th edition. ed: Prentice Hall.")
    /// <see href="https://saref.etsi.org/saref4envi/CommunicationInterface"></see></summary>
    let CommunicationInterface =
        Namespaced_IRI.parse _namespace_name "CommunicationInterface" |> NamespacedName

    /// <summary>
    /// A digital representation encapsulates a physical object accessible via Web services
    /// <see href="https://saref.etsi.org/saref4envi/DigitalRepresentation"></see></summary>
    let DigitalRepresentation =
        Namespaced_IRI.parse _namespace_name "DigitalRepresentation" |> NamespacedName

    /// <summary>
    /// Color of the emitted light. It might be indicated by named colors or using other type of color values like hexadecimal for RGB, color temperature, etc.
    /// <see href="https://saref.etsi.org/saref4envi/Color"></see></summary>
    let Color = Namespaced_IRI.parse _namespace_name "Color" |> NamespacedName

    /// <summary>
    /// The four cardinal directions or cardinal points are the directions of north, east, south, and west, commonly denoted by their initials: N, E, S, W. East and west are at right angles to north and south, with east being in the clockwise direction of rotation from north and west being directly opposite east. Intermediate points between the four cardinal directions form the points of the compass. (definition taken from https://en.wikipedia.org/wiki/Cardinal_direction)
    /// <see href="https://saref.etsi.org/saref4envi/CompassDirection"></see></summary>
    let CompassDirection =
        Namespaced_IRI.parse _namespace_name "CompassDirection" |> NamespacedName

    /// <summary>
    /// A protocol is an agreement between the communicating parties on how communication is to proceed. (Definition taken from "Tanenbaum, A. S. (2003). Computer networks, 4-th edition. ed: Prentice Hall.")
    /// <see href="https://saref.etsi.org/saref4envi/CommunicationProtocol"></see></summary>
    let CommunicationProtocol =
        Namespaced_IRI.parse _namespace_name "CommunicationProtocol" |> NamespacedName

    /// <summary>
    /// Unit of measure for the quantity lenght.
    /// <see href="https://saref.etsi.org/saref4envi/LengthUnit"></see></summary>
    let LengthUnit = Namespaced_IRI.parse _namespace_name "LengthUnit" |> NamespacedName

    /// <summary>
    /// Unit of measure for the quantity frequency.
    /// <see href="https://saref.etsi.org/saref4envi/FrequencyUnit"></see></summary>
    let FrequencyUnit =
        Namespaced_IRI.parse _namespace_name "FrequencyUnit" |> NamespacedName

    /// <summary>
    /// A light source, which may be a lantern, a street light, a floodlight, a signal lamp or any other device whose primary purpose is the generation of light. (Definition taken from http://wiki.openstreetmap.org/wiki/Proposed_features/Key:light_source#Description)
    /// <see href="https://saref.etsi.org/saref4envi/Light"></see></summary>
    let Light = Namespaced_IRI.parse _namespace_name "Light" |> NamespacedName
    /// <summary>
    ///   <see href="https://saref.etsi.org/saref4envi/v1.1.2/"></see>
    /// </summary>
    let ``v1.1.2/`` = Namespaced_IRI.parse _namespace_name "v1.1.2/" |> NamespacedName
    /// <summary>
    /// Device that can act over at least one property.
    /// <see href="https://saref.etsi.org/saref4envi/Actuator"></see></summary>
    let Actuator = Namespaced_IRI.parse _namespace_name "Actuator" |> NamespacedName

    /// <summary>
    /// A relation between an actuator with the property or properties it can act on
    /// <see href="https://saref.etsi.org/saref4envi/affectsProperty"></see></summary>
    let affectsProperty =
        Namespaced_IRI.parse _namespace_name "affectsProperty" |> NamespacedName

    /// <summary>
    /// A thing made or adapted for a particular purpose, especially a piece of mechanical or electronic equipment. For example ‘a measuring device’ (definition taken from https://en.oxforddictionaries.com/definition/device). In this ontology it refers to the devices for environmental purposes.
    /// <see href="https://saref.etsi.org/saref4envi/Device"></see></summary>
    let Device = Namespaced_IRI.parse _namespace_name "Device" |> NamespacedName
    /// <summary>
    /// A relationship defining the version  of a certain entity (e.g., a device)
    /// <see href="https://saref.etsi.org/saref4envi/hasVersion"></see></summary>
    let hasVersion = Namespaced_IRI.parse _namespace_name "hasVersion" |> NamespacedName

    /// <summary>
    /// The relation between a device and the period in which it transmit information.
    /// <see href="https://saref.etsi.org/saref4envi/hasTransmissionPeriod"></see></summary>
    let hasTransmissionPeriod =
        Namespaced_IRI.parse _namespace_name "hasTransmissionPeriod" |> NamespacedName

    /// <summary>
    /// Represents the measured value over a period property. It is also linked to the period unit of measure in which the value is expressed and the timestamp of the measurement.
    /// <see href="https://saref.etsi.org/saref4envi/PeriodMeasurement"></see></summary>
    let PeriodMeasurement =
        Namespaced_IRI.parse _namespace_name "PeriodMeasurement" |> NamespacedName

    /// <summary>
    /// A group of related hardware units or programs or both, especially when dedicated to a single application. (Definition taken from https://en.oxforddictionaries.com/definition/system)
    /// <see href="https://saref.etsi.org/saref4envi/System"></see></summary>
    let System = Namespaced_IRI.parse _namespace_name "System" |> NamespacedName

    /// <summary>
    /// A relation between a physical object and the physical object in which it might be contained.
    /// <see href="https://saref.etsi.org/saref4envi/isContainedIn"></see></summary>
    let isContainedIn =
        Namespaced_IRI.parse _namespace_name "isContainedIn" |> NamespacedName

    /// <summary>
    /// Any Object that has a proper space region.  (Definition extracted from DUL ontology)
    /// <see href="https://saref.etsi.org/saref4envi/PhysicalObject"></see></summary>
    let PhysicalObject =
        Namespaced_IRI.parse _namespace_name "PhysicalObject" |> NamespacedName

    /// <summary>
    /// A relationship defining the revision number of a certain entity (e.g., a device)
    /// <see href="https://saref.etsi.org/saref4envi/hasRevisionNumber"></see></summary>
    let hasRevisionNumber =
        Namespaced_IRI.parse _namespace_name "hasRevisionNumber" |> NamespacedName

    /// <summary>
    /// The relation between a device and the frequency in which it makes measurements.
    /// <see href="https://saref.etsi.org/saref4envi/hasFrequencyMeasurement"></see></summary>
    let hasFrequencyMeasurement =
        Namespaced_IRI.parse _namespace_name "hasFrequencyMeasurement" |> NamespacedName

    /// <summary>
    /// Represents the measured value made over a frequency property. It is also linked to the frequency unit of measure in which the value is expressed and the timestamp of the measurement.
    /// <see href="https://saref.etsi.org/saref4envi/FrequencyMeasurement"></see></summary>
    let FrequencyMeasurement =
        Namespaced_IRI.parse _namespace_name "FrequencyMeasurement" |> NamespacedName

    /// <summary>
    /// A relationship stating the tags that can be assigned to an entity (e.g., a digital representation).
    /// <see href="https://saref.etsi.org/saref4envi/hasTag"></see></summary>
    let hasTag = Namespaced_IRI.parse _namespace_name "hasTag" |> NamespacedName

    /// <summary>
    /// A relation between a digital representation and the physical objects it represents.
    /// <see href="https://saref.etsi.org/saref4envi/encapsulates"></see></summary>
    let encapsulates =
        Namespaced_IRI.parse _namespace_name "encapsulates" |> NamespacedName

    /// <summary>
    /// A relationship providing the identifier of an entity (e.g., digital representation)
    /// <see href="https://saref.etsi.org/saref4envi/hasIdentifier"></see></summary>
    let hasIdentifier =
        Namespaced_IRI.parse _namespace_name "hasIdentifier" |> NamespacedName

    /// <summary>
    /// A relationship defining the creation date of an entity (e.g., a digital representation).
    /// <see href="https://saref.etsi.org/saref4envi/hasCreationDate"></see></summary>
    let hasCreationDate =
        Namespaced_IRI.parse _namespace_name "hasCreationDate" |> NamespacedName

    /// <summary>
    /// The relation between a digital representation and the service which it is accesible through.
    /// <see href="https://saref.etsi.org/saref4envi/isAccesibleThrough"></see></summary>
    let isAccesibleThrough =
        Namespaced_IRI.parse _namespace_name "isAccesibleThrough" |> NamespacedName

    /// <summary>
    /// An individual representing the light property fluorescence.
    /// <see href="https://saref.etsi.org/saref4envi/Fluorescence"></see></summary>
    let Fluorescence =
        Namespaced_IRI.parse _namespace_name "Fluorescence" |> NamespacedName

    /// <summary>
    /// An aspect of light that can be observable by a sensor.
    /// <see href="https://saref.etsi.org/saref4envi/LightProperty"></see></summary>
    let LightProperty =
        Namespaced_IRI.parse _namespace_name "LightProperty" |> NamespacedName

    /// <summary>
    /// An individual representing the property frequency.
    /// <see href="https://saref.etsi.org/saref4envi/Frequency"></see></summary>
    let Frequency = Namespaced_IRI.parse _namespace_name "Frequency" |> NamespacedName
    /// <summary>
    /// An individual representing the property height.
    /// <see href="https://saref.etsi.org/saref4envi/Height"></see></summary>
    let Height = Namespaced_IRI.parse _namespace_name "Height" |> NamespacedName

    /// <summary>
    /// Represents the measured value made over a height property. It is also linked to the height unit of measure in which the value is expressed and the timestamp of the measurement.
    /// <see href="https://saref.etsi.org/saref4envi/HeightMeasurement"></see></summary>
    let HeightMeasurement =
        Namespaced_IRI.parse _namespace_name "HeightMeasurement" |> NamespacedName

    /// <summary>
    /// An individual representing the light property illuminance.
    /// <see href="https://saref.etsi.org/saref4envi/Illuminance"></see></summary>
    let Illuminance =
        Namespaced_IRI.parse _namespace_name "Illuminance" |> NamespacedName

    /// <summary>
    /// An individual representing the light property irradiance.
    /// <see href="https://saref.etsi.org/saref4envi/Irradiance"></see></summary>
    let Irradiance = Namespaced_IRI.parse _namespace_name "Irradiance" |> NamespacedName
    /// <summary>
    /// A tall pole with a light at the top.
    /// <see href="https://saref.etsi.org/saref4envi/Lamppost"></see></summary>
    let Lamppost = Namespaced_IRI.parse _namespace_name "Lamppost" |> NamespacedName

    /// <summary>
    /// A relation between a lamppost and its light points
    /// <see href="https://saref.etsi.org/saref4envi/hasLightPoint"></see></summary>
    let hasLightPoint =
        Namespaced_IRI.parse _namespace_name "hasLightPoint" |> NamespacedName

    /// <summary>
    /// An spatial point from where a light is projected. It might belong to a lamppost.
    /// <see href="https://saref.etsi.org/saref4envi/LightPoint"></see></summary>
    let LightPoint = Namespaced_IRI.parse _namespace_name "LightPoint" |> NamespacedName

    /// <summary>
    /// A relation between a lamppost or a light point and the light (or lights) they might project.
    /// <see href="https://saref.etsi.org/saref4envi/projectsLight"></see></summary>
    let projectsLight =
        Namespaced_IRI.parse _namespace_name "projectsLight" |> NamespacedName

    /// <summary>
    /// A relationship stating whether a lamppost has a shield.
    /// <see href="https://saref.etsi.org/saref4envi/hasShield"></see></summary>
    let hasShield = Namespaced_IRI.parse _namespace_name "hasShield" |> NamespacedName
    /// <summary>
    /// A relation between a light emitted and its color.
    /// <see href="https://saref.etsi.org/saref4envi/hasColor"></see></summary>
    let hasColor = Namespaced_IRI.parse _namespace_name "hasColor" |> NamespacedName

    /// <summary>
    /// A relation between a light emitted and the shape it is projected in.
    /// <see href="https://saref.etsi.org/saref4envi/hasGeometry"></see></summary>
    let hasGeometry =
        Namespaced_IRI.parse _namespace_name "hasGeometry" |> NamespacedName

    /// <summary>
    /// A relation between a light and the height measurement from which it is projected.
    /// <see href="https://saref.etsi.org/saref4envi/isProjectedFromHeight"></see></summary>
    let isProjectedFromHeight =
        Namespaced_IRI.parse _namespace_name "isProjectedFromHeight" |> NamespacedName

    /// <summary>
    /// A relation between a light and the direction in which it is projected.
    /// <see href="https://saref.etsi.org/saref4envi/isProjectedInDirection"></see></summary>
    let isProjectedInDirection =
        Namespaced_IRI.parse _namespace_name "isProjectedInDirection" |> NamespacedName

    /// <summary>
    /// A relationship stating whether a light has flash.
    /// <see href="https://saref.etsi.org/saref4envi/hasFlash"></see></summary>
    let hasFlash = Namespaced_IRI.parse _namespace_name "hasFlash" |> NamespacedName

    /// <summary>
    /// A relationship defining the projection angle of an entity (e.g., a light).
    /// <see href="https://saref.etsi.org/saref4envi/hasProjectionAngle"></see></summary>
    let hasProjectionAngle =
        Namespaced_IRI.parse _namespace_name "hasProjectionAngle" |> NamespacedName

    /// <summary>
    /// An individual representing the light property light absorption.
    /// <see href="https://saref.etsi.org/saref4envi/LightAbsorption"></see></summary>
    let LightAbsorption =
        Namespaced_IRI.parse _namespace_name "LightAbsorption" |> NamespacedName

    /// <summary>
    /// An individual representing the light property light magnitude.
    /// <see href="https://saref.etsi.org/saref4envi/LightMagnitude"></see></summary>
    let LightMagnitude =
        Namespaced_IRI.parse _namespace_name "LightMagnitude" |> NamespacedName

    /// <summary>
    /// An individual representing the light property luminiscence.
    /// <see href="https://saref.etsi.org/saref4envi/Luminiscence"></see></summary>
    let Luminiscence =
        Namespaced_IRI.parse _namespace_name "Luminiscence" |> NamespacedName

    /// <summary>
    /// An individual representing the property period.
    /// <see href="https://saref.etsi.org/saref4envi/Period"></see></summary>
    let Period = Namespaced_IRI.parse _namespace_name "Period" |> NamespacedName

    /// <summary>
    /// An individual representing the light property phosphorescence.
    /// <see href="https://saref.etsi.org/saref4envi/Phosphorescence"></see></summary>
    let Phosphorescence =
        Namespaced_IRI.parse _namespace_name "Phosphorescence" |> NamespacedName

    /// <summary>
    /// A photometer, generally, is an instrument that measures light intensity or optical properties of solutions or surfaces.
    /// <see href="https://saref.etsi.org/saref4envi/Photometer"></see></summary>
    let Photometer = Namespaced_IRI.parse _namespace_name "Photometer" |> NamespacedName
    /// <summary>
    /// A relation between a physical object and the physical objects that can be contained in it.
    /// <see href="https://saref.etsi.org/saref4envi/contains"></see></summary>
    let contains = Namespaced_IRI.parse _namespace_name "contains" |> NamespacedName

    /// <summary>
    /// A relation between a physical object and the digital representation in which it is encapsulated.
    /// <see href="https://saref.etsi.org/saref4envi/hasDigitalRepresentation"></see></summary>
    let hasDigitalRepresentation =
        Namespaced_IRI.parse _namespace_name "hasDigitalRepresentation" |> NamespacedName

    /// <summary>
    /// An individual representing the light property reflection of light.
    /// <see href="https://saref.etsi.org/saref4envi/ReflectionOfLight"></see></summary>
    let ReflectionOfLight =
        Namespaced_IRI.parse _namespace_name "ReflectionOfLight" |> NamespacedName

    /// <summary>
    /// An individual representing the light property scattering of light.
    /// <see href="https://saref.etsi.org/saref4envi/ScatteringOfLight"></see></summary>
    let ScatteringOfLight =
        Namespaced_IRI.parse _namespace_name "ScatteringOfLight" |> NamespacedName

    /// <summary>
    /// A relation between a system and the system in which it might be decomposed.
    /// <see href="https://saref.etsi.org/saref4envi/hasComponent"></see></summary>
    let hasComponent =
        Namespaced_IRI.parse _namespace_name "hasComponent" |> NamespacedName

    /// <summary>
    /// A relation between a system and the system it belongs to as a component.
    /// <see href="https://saref.etsi.org/saref4envi/isComponentOf"></see></summary>
    let isComponentOf =
        Namespaced_IRI.parse _namespace_name "isComponentOf" |> NamespacedName

    /// <summary>
    /// A relation between a system and the system to which it is connected.
    /// <see href="https://saref.etsi.org/saref4envi/isConnectedTo"></see></summary>
    let isConnectedTo =
        Namespaced_IRI.parse _namespace_name "isConnectedTo" |> NamespacedName

    /// <summary>
    /// A relation between a system and the communication interface it uses.
    /// <see href="https://saref.etsi.org/saref4envi/usesCommunicationInterface"></see></summary>
    let usesCommunicationInterface =
        Namespaced_IRI.parse _namespace_name "usesCommunicationInterface" |> NamespacedName

    /// <summary>
    /// A relation between a system and the communication protocol it uses.
    /// <see href="https://saref.etsi.org/saref4envi/usesCommunicationProtocol"></see></summary>
    let usesCommunicationProtocol =
        Namespaced_IRI.parse _namespace_name "usesCommunicationProtocol" |> NamespacedName

    /// <summary>
    /// The Telescope Encoder and Sky Sensor (TESS) is a Sky Brightness and Cloud detector developed as a device for a remote observatory. A TESS can observe the light magnitude and other properties as ambient temperature and sky temperature.
    /// <see href="https://saref.etsi.org/saref4envi/TESS"></see></summary>
    let TESS = Namespaced_IRI.parse _namespace_name "TESS" |> NamespacedName
