namespace https.saref.etsi.org.saref4envi.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module saref4envi =
    let _namespace_iri = Namespace_Iri saref4envi |> NamespaceIRI

    /// <summary>
    ///   <para>saref4envi:CommunicationInterface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An interface defines which primitive operations and services the lower layer makes available to the upper one, when referring to network layers. (Definition adapted from "Tanenbaum, A. S. (2003). Computer networks, 4-th edition. ed: Prentice Hall.")</para>
    /// labels<para>Communication interface</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/CommunicationInterface">https://saref.etsi.org/saref4envi/CommunicationInterface</seealso>
    let CommunicationInterface =
        Prefixed_Name(saref4envi, "CommunicationInterface") |> PrefixedName

    /// <summary>
    ///   <para>saref4envi:CompassDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The four cardinal directions or cardinal points are the directions of north, east, south, and west, commonly denoted by their initials: N, E, S, W. East and west are at right angles to north and south, with east being in the clockwise direction of rotation from north and west being directly opposite east. Intermediate points between the four cardinal directions form the points of the compass. (definition taken from https://en.wikipedia.org/wiki/Cardinal_direction)</para>
    /// labels<para>Compass direction</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/CompassDirection">https://saref.etsi.org/saref4envi/CompassDirection</seealso>
    let CompassDirection = Prefixed_Name(saref4envi, "CompassDirection") |> PrefixedName

    /// <summary>
    ///   <para>saref4envi:CommunicationProtocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A protocol is an agreement between the communicating parties on how communication is to proceed. (Definition taken from "Tanenbaum, A. S. (2003). Computer networks, 4-th edition. ed: Prentice Hall.")</para>
    /// labels<para>Communication protocol</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/CommunicationProtocol">https://saref.etsi.org/saref4envi/CommunicationProtocol</seealso>
    let CommunicationProtocol =
        Prefixed_Name(saref4envi, "CommunicationProtocol") |> PrefixedName

    /// <summary>
    ///   <para>saref4envi:hasIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relationship providing the identifier of an entity (e.g., digital representation)</para>
    /// labels<para>has identifier</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/hasIdentifier">https://saref.etsi.org/saref4envi/hasIdentifier</seealso>
    let hasIdentifier = Prefixed_Name(saref4envi, "hasIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>saref4envi:isAccesibleThrough</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The relation between a digital representation and the service which it is accesible through.</para>
    /// labels<para>is accesible through</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/isAccesibleThrough">https://saref.etsi.org/saref4envi/isAccesibleThrough</seealso>
    let isAccesibleThrough =
        Prefixed_Name(saref4envi, "isAccesibleThrough") |> PrefixedName

    /// <summary>
    ///   <para>saref4envi:LightProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An aspect of light that can be observable by a sensor.</para>
    /// labels<para>Light property</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/LightProperty">https://saref.etsi.org/saref4envi/LightProperty</seealso>
    let LightProperty = Prefixed_Name(saref4envi, "LightProperty") |> PrefixedName
    /// <summary>
    ///   <para>saref4envi:Geometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents the shape of the light emission. It might be instantiated by individuals like "spherical", "cylindrical", etc. even though it is open to more comples representation of geometries using other vocabularies.</para>
    /// labels<para>Geometry</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/Geometry">https://saref.etsi.org/saref4envi/Geometry</seealso>
    let Geometry = Prefixed_Name(saref4envi, "Geometry") |> PrefixedName
    /// <summary>
    ///   <para>saref4envi:Color</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Color of the emitted light. It might be indicated by named colors or using other type of color values like hexadecimal for RGB, color temperature, etc.</para>
    /// labels<para>Color</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/Color">https://saref.etsi.org/saref4envi/Color</seealso>
    let Color = Prefixed_Name(saref4envi, "Color") |> PrefixedName
    /// <summary>
    ///   <para>saref4envi:LengthUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Unit of measure for the quantity lenght.</para>
    /// labels<para>Length unit</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/LengthUnit">https://saref.etsi.org/saref4envi/LengthUnit</seealso>
    let LengthUnit = Prefixed_Name(saref4envi, "LengthUnit") |> PrefixedName
    /// <summary>
    ///   <para>saref4envi:Light</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A light source, which may be a lantern, a street light, a floodlight, a signal lamp or any other device whose primary purpose is the generation of light. (Definition taken from http://wiki.openstreetmap.org/wiki/Proposed_features/Key:light_source#Description)</para>
    /// labels<para>Light</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/Light">https://saref.etsi.org/saref4envi/Light</seealso>
    let Light = Prefixed_Name(saref4envi, "Light") |> PrefixedName
    /// <summary>
    ///   <para>saref4envi:Actuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device that can act over at least one property.</para>
    /// labels<para>Actuator</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/Actuator">https://saref.etsi.org/saref4envi/Actuator</seealso>
    let Actuator = Prefixed_Name(saref4envi, "Actuator") |> PrefixedName

    /// <summary>
    ///   <para>saref4envi:DigitalRepresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A digital representation encapsulates a physical object accessible via Web services</para>
    /// labels<para>Digital representation</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/DigitalRepresentation">https://saref.etsi.org/saref4envi/DigitalRepresentation</seealso>
    let DigitalRepresentation =
        Prefixed_Name(saref4envi, "DigitalRepresentation") |> PrefixedName

    /// <summary>
    ///   <para>saref4envi:Illuminance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>saref4envi:LightProperty</para>
    ///   <para>An individual representing the light property illuminance.</para>
    /// labels<para>Illuminance</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/Illuminance">https://saref.etsi.org/saref4envi/Illuminance</seealso>
    let Illuminance = Prefixed_Name(saref4envi, "Illuminance") |> PrefixedName
    /// <summary>
    ///   <para>saref4envi:Lamppost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A tall pole with a light at the top.</para>
    /// labels<para>Lamppost</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/Lamppost">https://saref.etsi.org/saref4envi/Lamppost</seealso>
    let Lamppost = Prefixed_Name(saref4envi, "Lamppost") |> PrefixedName
    /// <summary>
    ///   <para>saref4envi:hasLightPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between a lamppost and its light points</para>
    /// labels<para>has light point</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/hasLightPoint">https://saref.etsi.org/saref4envi/hasLightPoint</seealso>
    let hasLightPoint = Prefixed_Name(saref4envi, "hasLightPoint") |> PrefixedName
    /// <summary>
    ///   <para>saref4envi:LightPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An spatial point from where a light is projected. It might belong to a lamppost.</para>
    /// labels<para>Light point</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/LightPoint">https://saref.etsi.org/saref4envi/LightPoint</seealso>
    let LightPoint = Prefixed_Name(saref4envi, "LightPoint") |> PrefixedName

    /// <summary>
    ///   <para>saref4envi:isProjectedFromHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between a light and the height measurement from which it is projected.</para>
    /// labels<para>is projected from height</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/isProjectedFromHeight">https://saref.etsi.org/saref4envi/isProjectedFromHeight</seealso>
    let isProjectedFromHeight =
        Prefixed_Name(saref4envi, "isProjectedFromHeight") |> PrefixedName

    /// <summary>
    ///   <para>saref4envi:hasProjectionAngle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>A relationship defining the projection angle of an entity (e.g., a light).</para>
    /// labels<para>has projection angle</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/hasProjectionAngle">https://saref.etsi.org/saref4envi/hasProjectionAngle</seealso>
    let hasProjectionAngle =
        Prefixed_Name(saref4envi, "hasProjectionAngle") |> PrefixedName

    /// <summary>
    ///   <para>saref4envi:LightAbsorption</para>
    /// </summary>
    /// <remarks>
    ///   <para>saref4envi:LightProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>An individual representing the light property light absorption.</para>
    /// labels<para>Light absorption</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/LightAbsorption">https://saref.etsi.org/saref4envi/LightAbsorption</seealso>
    let LightAbsorption = Prefixed_Name(saref4envi, "LightAbsorption") |> PrefixedName
    /// <summary>
    ///   <para>saref4envi:Height</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>saref:Property</para>
    ///   <para>An individual representing the property height.</para>
    /// labels<para>Height</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/Height">https://saref.etsi.org/saref4envi/Height</seealso>
    let Height = Prefixed_Name(saref4envi, "Height") |> PrefixedName

    /// <summary>
    ///   <para>saref4envi:HeightMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents the measured value made over a height property. It is also linked to the height unit of measure in which the value is expressed and the timestamp of the measurement.</para>
    /// labels<para>Height measurement</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/HeightMeasurement">https://saref.etsi.org/saref4envi/HeightMeasurement</seealso>
    let HeightMeasurement =
        Prefixed_Name(saref4envi, "HeightMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>saref4envi:Irradiance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>saref4envi:LightProperty</para>
    ///   <para>An individual representing the light property irradiance.</para>
    /// labels<para>Irradiance</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/Irradiance">https://saref.etsi.org/saref4envi/Irradiance</seealso>
    let Irradiance = Prefixed_Name(saref4envi, "Irradiance") |> PrefixedName
    /// <summary>
    ///   <para>saref4envi:projectsLight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between a lamppost or a light point and the light (or lights) they might project.</para>
    /// labels<para>projects light</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/projectsLight">https://saref.etsi.org/saref4envi/projectsLight</seealso>
    let projectsLight = Prefixed_Name(saref4envi, "projectsLight") |> PrefixedName
    /// <summary>
    ///   <para>saref4envi:hasColor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between a light emitted and its color.</para>
    /// labels<para>has color</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/hasColor">https://saref.etsi.org/saref4envi/hasColor</seealso>
    let hasColor = Prefixed_Name(saref4envi, "hasColor") |> PrefixedName
    /// <summary>
    ///   <para>saref4envi:hasFlash</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>A relationship stating whether a light has flash.</para>
    /// labels<para>has flash</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/hasFlash">https://saref.etsi.org/saref4envi/hasFlash</seealso>
    let hasFlash = Prefixed_Name(saref4envi, "hasFlash") |> PrefixedName
    /// <summary>
    ///   <para>saref4envi:Luminiscence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>saref4envi:LightProperty</para>
    ///   <para>An individual representing the light property luminiscence.</para>
    /// labels<para>Luminiscence</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/Luminiscence">https://saref.etsi.org/saref4envi/Luminiscence</seealso>
    let Luminiscence = Prefixed_Name(saref4envi, "Luminiscence") |> PrefixedName
    /// <summary>
    ///   <para>saref4envi:Period</para>
    /// </summary>
    /// <remarks>
    ///   <para>saref:Property</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>An individual representing the property period.</para>
    /// labels<para>Period</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/Period">https://saref.etsi.org/saref4envi/Period</seealso>
    let Period = Prefixed_Name(saref4envi, "Period") |> PrefixedName
    /// <summary>
    ///   <para>saref4envi:Phosphorescence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>saref4envi:LightProperty</para>
    ///   <para>An individual representing the light property phosphorescence.</para>
    /// labels<para>Phosphorescence</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/Phosphorescence">https://saref.etsi.org/saref4envi/Phosphorescence</seealso>
    let Phosphorescence = Prefixed_Name(saref4envi, "Phosphorescence") |> PrefixedName
    /// <summary>
    ///   <para>saref4envi:Photometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A photometer, generally, is an instrument that measures light intensity or optical properties of solutions or surfaces.</para>
    /// labels<para>Photometer</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/Photometer">https://saref.etsi.org/saref4envi/Photometer</seealso>
    let Photometer = Prefixed_Name(saref4envi, "Photometer") |> PrefixedName

    /// <summary>
    ///   <para>saref4envi:hasDigitalRepresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>A relation between a physical object and the digital representation in which it is encapsulated.</para>
    /// labels<para>has digital representation</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/hasDigitalRepresentation">https://saref.etsi.org/saref4envi/hasDigitalRepresentation</seealso>
    let hasDigitalRepresentation =
        Prefixed_Name(saref4envi, "hasDigitalRepresentation") |> PrefixedName

    /// <summary>
    ///   <para>saref4envi:ReflectionOfLight</para>
    /// </summary>
    /// <remarks>
    ///   <para>saref4envi:LightProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>An individual representing the light property reflection of light.</para>
    /// labels<para>Reflection of light</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/ReflectionOfLight">https://saref.etsi.org/saref4envi/ReflectionOfLight</seealso>
    let ReflectionOfLight =
        Prefixed_Name(saref4envi, "ReflectionOfLight") |> PrefixedName

    /// <summary>
    ///   <para>saref4envi:hasComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>A relation between a system and the system in which it might be decomposed.</para>
    /// labels<para>has component</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/hasComponent">https://saref.etsi.org/saref4envi/hasComponent</seealso>
    let hasComponent = Prefixed_Name(saref4envi, "hasComponent") |> PrefixedName
    /// <summary>
    ///   <para>saref4envi:isComponentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>A relation between a system and the system it belongs to as a component.</para>
    /// labels<para>is component of</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/isComponentOf">https://saref.etsi.org/saref4envi/isComponentOf</seealso>
    let isComponentOf = Prefixed_Name(saref4envi, "isComponentOf") |> PrefixedName
    /// <summary>
    ///   <para>saref4envi:TESS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Telescope Encoder and Sky Sensor (TESS) is a Sky Brightness and Cloud detector developed as a device for a remote observatory. A TESS can observe the light magnitude and other properties as ambient temperature and sky temperature.</para>
    /// labels<para>TESS (Telescope Encoder and Sky Sensor)</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/TESS">https://saref.etsi.org/saref4envi/TESS</seealso>
    let TESS = Prefixed_Name(saref4envi, "TESS") |> PrefixedName
    /// <summary>
    ///   <para>saref4envi:encapsulates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between a digital representation and the physical objects it represents.</para>
    /// labels<para>encapsulates</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/encapsulates">https://saref.etsi.org/saref4envi/encapsulates</seealso>
    let encapsulates = Prefixed_Name(saref4envi, "encapsulates") |> PrefixedName
    /// <summary>
    ///   <para>saref4envi:hasCreationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relationship defining the creation date of an entity (e.g., a digital representation).</para>
    /// labels<para>has creation date</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/hasCreationDate">https://saref.etsi.org/saref4envi/hasCreationDate</seealso>
    let hasCreationDate = Prefixed_Name(saref4envi, "hasCreationDate") |> PrefixedName
    /// <summary>
    ///   <para>saref4envi:Fluorescence</para>
    /// </summary>
    /// <remarks>
    ///   <para>saref4envi:LightProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>An individual representing the light property fluorescence.</para>
    /// labels<para>Fluorescence</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/Fluorescence">https://saref.etsi.org/saref4envi/Fluorescence</seealso>
    let Fluorescence = Prefixed_Name(saref4envi, "Fluorescence") |> PrefixedName
    /// <summary>
    ///   <para>saref4envi:Frequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>saref:Property</para>
    ///   <para>An individual representing the property frequency.</para>
    /// labels<para>Frequency</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/Frequency">https://saref.etsi.org/saref4envi/Frequency</seealso>
    let Frequency = Prefixed_Name(saref4envi, "Frequency") |> PrefixedName
    /// <summary>
    ///   <para>saref4envi:hasShield</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relationship stating whether a lamppost has a shield.</para>
    /// labels<para>has shield</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/hasShield">https://saref.etsi.org/saref4envi/hasShield</seealso>
    let hasShield = Prefixed_Name(saref4envi, "hasShield") |> PrefixedName
    /// <summary>
    ///   <para>saref4envi:hasGeometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between a light emitted and the shape it is projected in.</para>
    /// labels<para>has geometry</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/hasGeometry">https://saref.etsi.org/saref4envi/hasGeometry</seealso>
    let hasGeometry = Prefixed_Name(saref4envi, "hasGeometry") |> PrefixedName

    /// <summary>
    ///   <para>saref4envi:isProjectedInDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between a light and the direction in which it is projected.</para>
    /// labels<para>is projected in direction</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/isProjectedInDirection">https://saref.etsi.org/saref4envi/isProjectedInDirection</seealso>
    let isProjectedInDirection =
        Prefixed_Name(saref4envi, "isProjectedInDirection") |> PrefixedName

    /// <summary>
    ///   <para>saref4envi:LightMagnitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>saref4envi:LightProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>An individual representing the light property light magnitude.</para>
    /// labels<para>Light magnitude</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/LightMagnitude">https://saref.etsi.org/saref4envi/LightMagnitude</seealso>
    let LightMagnitude = Prefixed_Name(saref4envi, "LightMagnitude") |> PrefixedName
    /// <summary>
    ///   <para>saref4envi:FrequencyUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Unit of measure for the quantity frequency.</para>
    /// labels<para>Frequency unit</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/FrequencyUnit">https://saref.etsi.org/saref4envi/FrequencyUnit</seealso>
    let FrequencyUnit = Prefixed_Name(saref4envi, "FrequencyUnit") |> PrefixedName
    /// <summary>
    ///   <para>saref4envi:contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between a physical object and the physical objects that can be contained in it.</para>
    /// labels<para>contains</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/contains">https://saref.etsi.org/saref4envi/contains</seealso>
    let contains = Prefixed_Name(saref4envi, "contains") |> PrefixedName

    /// <summary>
    ///   <para>saref4envi:ScatteringOfLight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>saref4envi:LightProperty</para>
    ///   <para>An individual representing the light property scattering of light.</para>
    /// labels<para>Scattering of light</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/ScatteringOfLight">https://saref.etsi.org/saref4envi/ScatteringOfLight</seealso>
    let ScatteringOfLight =
        Prefixed_Name(saref4envi, "ScatteringOfLight") |> PrefixedName

    /// <summary>
    ///   <para>saref4envi:isConnectedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between a system and the system to which it is connected.</para>
    /// labels<para>is connected to</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/isConnectedTo">https://saref.etsi.org/saref4envi/isConnectedTo</seealso>
    let isConnectedTo = Prefixed_Name(saref4envi, "isConnectedTo") |> PrefixedName

    /// <summary>
    ///   <para>saref4envi:usesCommunicationProtocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between a system and the communication protocol it uses.</para>
    /// labels<para>uses communication protocol</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/usesCommunicationProtocol">https://saref.etsi.org/saref4envi/usesCommunicationProtocol</seealso>
    let usesCommunicationProtocol =
        Prefixed_Name(saref4envi, "usesCommunicationProtocol") |> PrefixedName

    /// <summary>
    ///   <para>saref4envi:usesCommunicationInterface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between a system and the communication interface it uses.</para>
    /// labels<para>uses communication interface</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/usesCommunicationInterface">https://saref.etsi.org/saref4envi/usesCommunicationInterface</seealso>
    let usesCommunicationInterface =
        Prefixed_Name(saref4envi, "usesCommunicationInterface") |> PrefixedName

    /// <summary>
    ///   <para>saref4envi:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>Information about changes compared to version 1.1.1:
    ///  - Updated namespaces for compatibility with SAREF v3.</para>
    /// </remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/">https://saref.etsi.org/saref4envi/</seealso>
    let _prefix_iri = Prefixed_Name(saref4envi, "") |> PrefixedName
    /// <summary>
    ///   <para>saref4envi:Device</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A thing made or adapted for a particular purpose, especially a piece of mechanical or electronic equipment. For example ‘a measuring device’ (definition taken from https://en.oxforddictionaries.com/definition/device). In this ontology it refers to the devices for environmental purposes.</para>
    /// labels<para>Device</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/Device">https://saref.etsi.org/saref4envi/Device</seealso>
    let Device = Prefixed_Name(saref4envi, "Device") |> PrefixedName
    /// <summary>
    ///   <para>saref4envi:affectsProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between an actuator with the property or properties it can act on</para>
    /// labels<para>affects property</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/affectsProperty">https://saref.etsi.org/saref4envi/affectsProperty</seealso>
    let affectsProperty = Prefixed_Name(saref4envi, "affectsProperty") |> PrefixedName
    /// <summary>
    ///   <para>saref4envi:v1.1.2/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/v1.1.2/">https://saref.etsi.org/saref4envi/v1.1.2/</seealso>
    let ``v1.1.2/`` = Prefixed_Name(saref4envi, "v1.1.2/") |> PrefixedName
    /// <summary>
    ///   <para>saref4envi:hasVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>A relationship defining the version  of a certain entity (e.g., a device)</para>
    /// labels<para>has version</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/hasVersion">https://saref.etsi.org/saref4envi/hasVersion</seealso>
    let hasVersion = Prefixed_Name(saref4envi, "hasVersion") |> PrefixedName

    /// <summary>
    ///   <para>saref4envi:hasTransmissionPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The relation between a device and the period in which it transmit information.</para>
    /// labels<para>has transmission period</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/hasTransmissionPeriod">https://saref.etsi.org/saref4envi/hasTransmissionPeriod</seealso>
    let hasTransmissionPeriod =
        Prefixed_Name(saref4envi, "hasTransmissionPeriod") |> PrefixedName

    /// <summary>
    ///   <para>saref4envi:isContainedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between a physical object and the physical object in which it might be contained.</para>
    /// labels<para>is contained in</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/isContainedIn">https://saref.etsi.org/saref4envi/isContainedIn</seealso>
    let isContainedIn = Prefixed_Name(saref4envi, "isContainedIn") |> PrefixedName
    /// <summary>
    ///   <para>saref4envi:PhysicalObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any Object that has a proper space region.  (Definition extracted from DUL ontology)</para>
    /// labels<para>Physical object</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/PhysicalObject">https://saref.etsi.org/saref4envi/PhysicalObject</seealso>
    let PhysicalObject = Prefixed_Name(saref4envi, "PhysicalObject") |> PrefixedName

    /// <summary>
    ///   <para>saref4envi:hasFrequencyMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The relation between a device and the frequency in which it makes measurements.</para>
    /// labels<para>has frequency measurement</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/hasFrequencyMeasurement">https://saref.etsi.org/saref4envi/hasFrequencyMeasurement</seealso>
    let hasFrequencyMeasurement =
        Prefixed_Name(saref4envi, "hasFrequencyMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>saref4envi:FrequencyMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents the measured value made over a frequency property. It is also linked to the frequency unit of measure in which the value is expressed and the timestamp of the measurement.</para>
    /// labels<para>Frequency measurement</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/FrequencyMeasurement">https://saref.etsi.org/saref4envi/FrequencyMeasurement</seealso>
    let FrequencyMeasurement =
        Prefixed_Name(saref4envi, "FrequencyMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>saref4envi:hasTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relationship stating the tags that can be assigned to an entity (e.g., a digital representation).</para>
    /// labels<para>has tag</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/hasTag">https://saref.etsi.org/saref4envi/hasTag</seealso>
    let hasTag = Prefixed_Name(saref4envi, "hasTag") |> PrefixedName

    /// <summary>
    ///   <para>saref4envi:PeriodMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents the measured value over a period property. It is also linked to the period unit of measure in which the value is expressed and the timestamp of the measurement.</para>
    /// labels<para>Period measurement</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/PeriodMeasurement">https://saref.etsi.org/saref4envi/PeriodMeasurement</seealso>
    let PeriodMeasurement =
        Prefixed_Name(saref4envi, "PeriodMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>saref4envi:System</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A group of related hardware units or programs or both, especially when dedicated to a single application. (Definition taken from https://en.oxforddictionaries.com/definition/system)</para>
    /// labels<para>System</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/System">https://saref.etsi.org/saref4envi/System</seealso>
    let System = Prefixed_Name(saref4envi, "System") |> PrefixedName

    /// <summary>
    ///   <para>saref4envi:hasRevisionNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relationship defining the revision number of a certain entity (e.g., a device)</para>
    /// labels<para>has revision number</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4envi/hasRevisionNumber">https://saref.etsi.org/saref4envi/hasRevisionNumber</seealso>
    let hasRevisionNumber =
        Prefixed_Name(saref4envi, "hasRevisionNumber") |> PrefixedName
