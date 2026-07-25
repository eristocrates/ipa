namespace https.w3id.org.tribont.core.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tribont_core =
    let _namespace_iri = Namespace_Iri tribont_core |> NamespaceIRI
    /// <summary>
    ///   <para>tribont-core:BodyProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Qualifiable or quantifiable attribute, or characteristic of a body.</para>
    /// labels<para>BodyProperty</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#BodyProperty">https://w3id.org/tribont/core#BodyProperty</seealso>
    let BodyProperty = Prefixed_Name(tribont_core, "BodyProperty") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Vvv</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Dale void volume</para>
    /// labels<para>Vvv</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Vvv">https://w3id.org/tribont/core#Vvv</seealso>
    let Vvv = Prefixed_Name(tribont_core, "Vvv") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:PhysicalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Qualifiable or quantifiable physical attribute, or characteristic of a something.</para>
    /// labels<para>PhysicalProperty</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#PhysicalProperty">https://w3id.org/tribont/core#PhysicalProperty</seealso>
    let PhysicalProperty =
        Prefixed_Name(tribont_core, "PhysicalProperty") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:RotationSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Rotation speed of something.</para>
    /// labels<para>RotationSpeed</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#RotationSpeed">https://w3id.org/tribont/core#RotationSpeed</seealso>
    let RotationSpeed = Prefixed_Name(tribont_core, "RotationSpeed") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:StrokeDiameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Stroke diameter.</para>
    /// labels<para>StrokeDiameter</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#StrokeDiameter">https://w3id.org/tribont/core#StrokeDiameter</seealso>
    let StrokeDiameter = Prefixed_Name(tribont_core, "StrokeDiameter") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:AngleUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurement unit for angle.</para>
    /// labels<para>AngleUnit</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#AngleUnit">https://w3id.org/tribont/core#AngleUnit</seealso>
    let AngleUnit = Prefixed_Name(tribont_core, "AngleUnit") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:DistanceUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurement unit for distance.</para>
    /// labels<para>DistanceUnit</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#DistanceUnit">https://w3id.org/tribont/core#DistanceUnit</seealso>
    let DistanceUnit = Prefixed_Name(tribont_core, "DistanceUnit") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:HardnessUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurement unit for hardness.</para>
    /// labels<para>HardnessUnit</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#HardnessUnit">https://w3id.org/tribont/core#HardnessUnit</seealso>
    let HardnessUnit = Prefixed_Name(tribont_core, "HardnessUnit") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:MechanicalUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurement units for mechanizal properties.</para>
    /// labels<para>MechanicalUnit</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#MechanicalUnit">https://w3id.org/tribont/core#MechanicalUnit</seealso>
    let MechanicalUnit = Prefixed_Name(tribont_core, "MechanicalUnit") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:PressureUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurement unit for pressure.</para>
    /// labels<para>PressureUnit</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#PressureUnit">https://w3id.org/tribont/core#PressureUnit</seealso>
    let PressureUnit = Prefixed_Name(tribont_core, "PressureUnit") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:TensionUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurement unit for tension.</para>
    /// labels<para>TensionUnit</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#TensionUnit">https://w3id.org/tribont/core#TensionUnit</seealso>
    let TensionUnit = Prefixed_Name(tribont_core, "TensionUnit") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:TorqueUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurement unit for torque.</para>
    /// labels<para>TorqueUnit</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#TorqueUnit">https://w3id.org/tribont/core#TorqueUnit</seealso>
    let TorqueUnit = Prefixed_Name(tribont_core, "TorqueUnit") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:ViscosityUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurement unit for viscosity.</para>
    /// labels<para>ViscosityUnit</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ViscosityUnit">https://w3id.org/tribont/core#ViscosityUnit</seealso>
    let ViscosityUnit = Prefixed_Name(tribont_core, "ViscosityUnit") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Pa</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#PressureUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Pa</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Pa">https://w3id.org/tribont/core#Pa</seealso>
    let Pa = Prefixed_Name(tribont_core, "Pa") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:PolishGrade</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Polish grade of something.</para>
    /// labels<para>PolishGrade</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#PolishGrade">https://w3id.org/tribont/core#PolishGrade</seealso>
    let PolishGrade = Prefixed_Name(tribont_core, "PolishGrade") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:isDocumentFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a document and what it provides information about.</para>
    /// labels<para>isDocumentFor</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#isDocumentFor">https://w3id.org/tribont/core#isDocumentFor</seealso>
    let isDocumentFor = Prefixed_Name(tribont_core, "isDocumentFor") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:hasLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between something and where it is located.</para>
    /// labels<para>hasLocation</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#hasLocation">https://w3id.org/tribont/core#hasLocation</seealso>
    let hasLocation = Prefixed_Name(tribont_core, "hasLocation") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:LoadPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Load pressure applied to something.</para>
    /// labels<para>LoadPressure</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#LoadPressure">https://w3id.org/tribont/core#LoadPressure</seealso>
    let LoadPressure = Prefixed_Name(tribont_core, "LoadPressure") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:HardnessRockwellM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>RockwellM hardnes of somethings .</para>
    /// labels<para>HardnessRockwellM</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#HardnessRockwellM">https://w3id.org/tribont/core#HardnessRockwellM</seealso>
    let HardnessRockwellM =
        Prefixed_Name(tribont_core, "HardnessRockwellM") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:IndentationHardnessMicro</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Indentation hardness micro.</para>
    /// labels<para>IndentationHardnessMicro</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#IndentationHardnessMicro">https://w3id.org/tribont/core#IndentationHardnessMicro</seealso>
    let IndentationHardnessMicro =
        Prefixed_Name(tribont_core, "IndentationHardnessMicro") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:IndentationHardnessNano</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Indentation hardness nano.</para>
    /// labels<para>IndentationHardnessNano</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#IndentationHardnessNano">https://w3id.org/tribont/core#IndentationHardnessNano</seealso>
    let IndentationHardnessNano =
        Prefixed_Name(tribont_core, "IndentationHardnessNano") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:kJkg.degreeC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#HeatCapacityUnit</para>
    ///
    /// labels<para>kJ/kg.°C</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#kJkg.degreeC">https://w3id.org/tribont/core#kJkg.degreeC</seealso>
    let ``kJkg.degreeC`` = Prefixed_Name(tribont_core, "kJkg.degreeC") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:SurfaceProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Qualifiable or quantifiable  attribute, or characteristic of a surface. .</para>
    /// labels<para>SurfaceProperty</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#SurfaceProperty">https://w3id.org/tribont/core#SurfaceProperty</seealso>
    let SurfaceProperty = Prefixed_Name(tribont_core, "SurfaceProperty") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Humidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Humidity of something.</para>
    /// labels<para>Humidity</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Humidity">https://w3id.org/tribont/core#Humidity</seealso>
    let Humidity = Prefixed_Name(tribont_core, "Humidity") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:FractureToughness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Fracture toughness of something.</para>
    /// labels<para>FractureToughness</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#FractureToughness">https://w3id.org/tribont/core#FractureToughness</seealso>
    let FractureToughness =
        Prefixed_Name(tribont_core, "FractureToughness") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:YieldStrength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Yield strength of something.</para>
    /// labels<para>YieldStrength</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#YieldStrength">https://w3id.org/tribont/core#YieldStrength</seealso>
    let YieldStrength = Prefixed_Name(tribont_core, "YieldStrength") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:TribologicalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Qualifiable or quantifiable tribological attribute, or characteristic of something.</para>
    /// labels<para>TribologicalProperty</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#TribologicalProperty">https://w3id.org/tribont/core#TribologicalProperty</seealso>
    let TribologicalProperty =
        Prefixed_Name(tribont_core, "TribologicalProperty") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:ExternalForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>External force applied to something.</para>
    /// labels<para>ExternalForce</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ExternalForce">https://w3id.org/tribont/core#ExternalForce</seealso>
    let ExternalForce = Prefixed_Name(tribont_core, "ExternalForce") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:LoadLeverRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Load leverlratio of something.</para>
    /// labels<para>LoadLevelRatio</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#LoadLeverRatio">https://w3id.org/tribont/core#LoadLeverRatio</seealso>
    let LoadLeverRatio = Prefixed_Name(tribont_core, "LoadLeverRatio") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:microm</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#DistanceUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>µm</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#microm">https://w3id.org/tribont/core#microm</seealso>
    let microm = Prefixed_Name(tribont_core, "microm") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:SurfaceRoughness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Surface roughness. .</para>
    /// labels<para>SurfaceRoughness</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#SurfaceRoughness">https://w3id.org/tribont/core#SurfaceRoughness</seealso>
    let SurfaceRoughness =
        Prefixed_Name(tribont_core, "SurfaceRoughness") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:RadiationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Radiation type.</para>
    /// labels<para>RadiationType</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#RadiationType">https://w3id.org/tribont/core#RadiationType</seealso>
    let RadiationType = Prefixed_Name(tribont_core, "RadiationType") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:in2s</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#ViscosityUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>in2/s</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#in2s">https://w3id.org/tribont/core#in2s</seealso>
    let in2s = Prefixed_Name(tribont_core, "in2s") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:inHg</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#MechanicalUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>inHg</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#inHg">https://w3id.org/tribont/core#inHg</seealso>
    let inHg = Prefixed_Name(tribont_core, "inHg") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:ThermalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Qualifiable or quantifiable termal attribute, or characteristic of something.</para>
    /// labels<para>ThermalProperty</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ThermalProperty">https://w3id.org/tribont/core#ThermalProperty</seealso>
    let ThermalProperty = Prefixed_Name(tribont_core, "ThermalProperty") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:GeometricDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Quantifiable attribute, or characteristic of the geometry of a body.</para>
    /// labels<para>GeometricDimension</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#GeometricDimension">https://w3id.org/tribont/core#GeometricDimension</seealso>
    let GeometricDimension =
        Prefixed_Name(tribont_core, "GeometricDimension") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:Weight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Weight of something.</para>
    /// labels<para>Weight</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Weight">https://w3id.org/tribont/core#Weight</seealso>
    let Weight = Prefixed_Name(tribont_core, "Weight") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:PhLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Ph level of something.</para>
    /// labels<para>PhLevel</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#PhLevel">https://w3id.org/tribont/core#PhLevel</seealso>
    let PhLevel = Prefixed_Name(tribont_core, "PhLevel") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:hPa</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#MechanicalUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>hPa</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#hPa">https://w3id.org/tribont/core#hPa</seealso>
    let hPa = Prefixed_Name(tribont_core, "hPa") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:hasDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between something and its related documents</para>
    /// labels<para>hasDocument</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#hasDocument">https://w3id.org/tribont/core#hasDocument</seealso>
    let hasDocument = Prefixed_Name(tribont_core, "hasDocument") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:AxialLoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Axial load applied to something.</para>
    /// labels<para>AxialLoad</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#AxialLoad">https://w3id.org/tribont/core#AxialLoad</seealso>
    let AxialLoad = Prefixed_Name(tribont_core, "AxialLoad") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Load</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Load applied to something.</para>
    /// labels<para>Load</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Load">https://w3id.org/tribont/core#Load</seealso>
    let Load = Prefixed_Name(tribont_core, "Load") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:LoadRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Load rate applied to something.</para>
    /// labels<para>LoadRate</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#LoadRate">https://w3id.org/tribont/core#LoadRate</seealso>
    let LoadRate = Prefixed_Name(tribont_core, "LoadRate") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:YoungModulus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Young modulus of something.</para>
    /// labels<para>YoungModulus</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#YoungModulus">https://w3id.org/tribont/core#YoungModulus</seealso>
    let YoungModulus = Prefixed_Name(tribont_core, "YoungModulus") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:SpecificHeatCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Specific heat capacity</para>
    /// labels<para>SpecificHeatCapacity</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#SpecificHeatCapacity">https://w3id.org/tribont/core#SpecificHeatCapacity</seealso>
    let SpecificHeatCapacity =
        Prefixed_Name(tribont_core, "SpecificHeatCapacity") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:WearProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Qualifiable or quantifiable wear attribute, or characteristic of something..</para>
    /// labels<para>WearProperty</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#WearProperty">https://w3id.org/tribont/core#WearProperty</seealso>
    let WearProperty = Prefixed_Name(tribont_core, "WearProperty") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:WearScarLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para> Length of wear scar..</para>
    /// labels<para>WearScarLength</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#WearScarLength">https://w3id.org/tribont/core#WearScarLength</seealso>
    let WearScarLength = Prefixed_Name(tribont_core, "WearScarLength") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:WearScarProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para> Qualifiable or quantifiable  attribute, or characteristic of a wear scar.</para>
    /// labels<para>WearScarProperty</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#WearScarProperty">https://w3id.org/tribont/core#WearScarProperty</seealso>
    let WearScarProperty =
        Prefixed_Name(tribont_core, "WearScarProperty") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:WearScarVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para> Volume of wear scar..</para>
    /// labels<para>WearScarVolume</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#WearScarVolume">https://w3id.org/tribont/core#WearScarVolume</seealso>
    let WearScarVolume = Prefixed_Name(tribont_core, "WearScarVolume") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:WearType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Wear type of something.</para>
    /// labels<para>WearType</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#WearType">https://w3id.org/tribont/core#WearType</seealso>
    let WearType = Prefixed_Name(tribont_core, "WearType") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Wm.degreeC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#ThermalConductivityUnit</para>
    ///
    /// labels<para>W/m.°C</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Wm.degreeC">https://w3id.org/tribont/core#Wm.degreeC</seealso>
    let ``Wm.degreeC`` = Prefixed_Name(tribont_core, "Wm.degreeC") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:abrasive_wear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#WearType</para>
    ///
    /// labels<para>abrasive_wear</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#abrasive_wear">https://w3id.org/tribont/core#abrasive_wear</seealso>
    let abrasive_wear = Prefixed_Name(tribont_core, "abrasive_wear") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:accessUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Url to access a specific information content or document.</para>
    /// labels<para>accessUrl</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#accessUrl">https://w3id.org/tribont/core#accessUrl</seealso>
    let accessUrl = Prefixed_Name(tribont_core, "accessUrl") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:adhesive_wear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#WearType</para>
    ///
    /// labels<para>adhesive_wear</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#adhesive_wear">https://w3id.org/tribont/core#adhesive_wear</seealso>
    let adhesive_wear = Prefixed_Name(tribont_core, "adhesive_wear") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:ambient_air</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#EnvironmentMedium</para>
    ///
    /// labels<para>ambient_air</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ambient_air">https://w3id.org/tribont/core#ambient_air</seealso>
    let ambient_air = Prefixed_Name(tribont_core, "ambient_air") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:ambient_pressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#Pressure</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>ambient_pressure</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ambient_pressure">https://w3id.org/tribont/core#ambient_pressure</seealso>
    let ambient_pressure =
        Prefixed_Name(tribont_core, "ambient_pressure") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:area</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#ContactSurfaceType</para>
    ///
    /// labels<para>area</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#area">https://w3id.org/tribont/core#area</seealso>
    let area = Prefixed_Name(tribont_core, "area") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:atm</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#MechanicalUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>atm</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#atm">https://w3id.org/tribont/core#atm</seealso>
    let atm = Prefixed_Name(tribont_core, "atm") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:ball</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#Shape</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>ball</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ball">https://w3id.org/tribont/core#ball</seealso>
    let ball = Prefixed_Name(tribont_core, "ball") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:ball_on_disc</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#GeometricalArrangement</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>ball_on_disc</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ball_on_disc">https://w3id.org/tribont/core#ball_on_disc</seealso>
    let ball_on_disc = Prefixed_Name(tribont_core, "ball_on_disc") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:ball_on_plate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#GeometricalArrangement</para>
    ///
    /// labels<para>ball_on_plate</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ball_on_plate">https://w3id.org/tribont/core#ball_on_plate</seealso>
    let ball_on_plate = Prefixed_Name(tribont_core, "ball_on_plate") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:bar</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#PressureUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>bar</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#bar">https://w3id.org/tribont/core#bar</seealso>
    let bar = Prefixed_Name(tribont_core, "bar") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:boundary_lubrication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#LubricationRegime</para>
    ///
    /// labels<para>boundary_lubrication</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#boundary_lubrication">https://w3id.org/tribont/core#boundary_lubrication</seealso>
    let boundary_lubrication =
        Prefixed_Name(tribont_core, "boundary_lubrication") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:characterisesOperationCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a specified operation property and the SubjectOfInterest it characterises  (e.g. equipemnt or test)..</para>
    /// labels<para>characterisesOperationCondition</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#characterisesOperationCondition">https://w3id.org/tribont/core#characterisesOperationCondition</seealso>
    let characterisesOperationCondition =
        Prefixed_Name(tribont_core, "characterisesOperationCondition") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:isCharacterisedByOperationCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a  SubjectOfInterest it characterises  (e.g. equipemnt or test) and a specified operation property characterisig it..</para>
    /// labels<para>isCharacterisedByOperationCondition</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#isCharacterisedByOperationCondition">https://w3id.org/tribont/core#isCharacterisedByOperationCondition</seealso>
    let isCharacterisedByOperationCondition =
        Prefixed_Name(tribont_core, "isCharacterisedByOperationCondition") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:characterisesOperationMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a measured operation property and the SubjectOfInterest it characterises  (e.g. equipemnt or test)..</para>
    /// labels<para>characterisesOperationMeasure</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#characterisesOperationMeasure">https://w3id.org/tribont/core#characterisesOperationMeasure</seealso>
    let characterisesOperationMeasure =
        Prefixed_Name(tribont_core, "characterisesOperationMeasure") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:isCharacterisedByOperationMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a  SubjectOfInterest it characterises (e.g. equipemnt or test) and a measured operation property characterisig it..</para>
    /// labels<para>isCharacterisedByOperationMeasure</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#isCharacterisedByOperationMeasure">https://w3id.org/tribont/core#isCharacterisedByOperationMeasure</seealso>
    let isCharacterisedByOperationMeasure =
        Prefixed_Name(tribont_core, "isCharacterisedByOperationMeasure") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:characterisesOutputMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a n output technical measure  and the SubjectOfInterest it characterises (e.g. equipemnt or test).</para>
    /// labels<para>characterisesOutputMeasure</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#characterisesOutputMeasure">https://w3id.org/tribont/core#characterisesOutputMeasure</seealso>
    let characterisesOutputMeasure =
        Prefixed_Name(tribont_core, "characterisesOutputMeasure") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:isCharacterisedByOutputMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between aSubjectOfInterest it characterises (e.g. equipemnt or test). and an output technical measurecgarcaterisg it.</para>
    /// labels<para>isCharacterisedByOutputMeasure</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#isCharacterisedByOutputMeasure">https://w3id.org/tribont/core#isCharacterisedByOutputMeasure</seealso>
    let isCharacterisedByOutputMeasure =
        Prefixed_Name(tribont_core, "isCharacterisedByOutputMeasure") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:cm</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#DistanceUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>cm</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#cm">https://w3id.org/tribont/core#cm</seealso>
    let cm = Prefixed_Name(tribont_core, "cm") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:cm100m</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#TendencyUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>cm/100m</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#cm100m">https://w3id.org/tribont/core#cm100m</seealso>
    let cm100m = Prefixed_Name(tribont_core, "cm100m") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:cm2s</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#ViscosityUnit</para>
    ///
    /// labels<para>cm2/s</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#cm2s">https://w3id.org/tribont/core#cm2s</seealso>
    let cm2s = Prefixed_Name(tribont_core, "cm2s") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:cm3</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#CapacityUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>cm3</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#cm3">https://w3id.org/tribont/core#cm3</seealso>
    let cm3 = Prefixed_Name(tribont_core, "cm3") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:cmcm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#TendencyUnit</para>
    ///
    /// labels<para>cm/cm</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#cmcm">https://w3id.org/tribont/core#cmcm</seealso>
    let cmcm = Prefixed_Name(tribont_core, "cmcm") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:compliesWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between something and the standard or procedure it complies with.</para>
    /// labels<para>compliesWith</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#compliesWith">https://w3id.org/tribont/core#compliesWith</seealso>
    let compliesWith = Prefixed_Name(tribont_core, "compliesWith") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:isCompliedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a standard or procedure and what it regulates or formalise.</para>
    /// labels<para>isCompliedBy</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#isCompliedBy">https://w3id.org/tribont/core#isCompliedBy</seealso>
    let isCompliedBy = Prefixed_Name(tribont_core, "isCompliedBy") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:corrosive_gas</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#EnvironmentMedium</para>
    ///
    /// labels<para>corrosive_gas</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#corrosive_gas">https://w3id.org/tribont/core#corrosive_gas</seealso>
    let corrosive_gas = Prefixed_Name(tribont_core, "corrosive_gas") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:cuboid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#Shape</para>
    ///
    /// labels<para>cuboid</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#cuboid">https://w3id.org/tribont/core#cuboid</seealso>
    let cuboid = Prefixed_Name(tribont_core, "cuboid") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:degreeC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#TemperatureUnit</para>
    ///
    /// labels<para>°C</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#degreeC">https://w3id.org/tribont/core#degreeC</seealso>
    let degreeC = Prefixed_Name(tribont_core, "degreeC") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:degreeF</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#TemperatureUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>°F</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#degreeF">https://w3id.org/tribont/core#degreeF</seealso>
    let degreeF = Prefixed_Name(tribont_core, "degreeF") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:degreeK</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#TemperatureUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>°K</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#degreeK">https://w3id.org/tribont/core#degreeK</seealso>
    let degreeK = Prefixed_Name(tribont_core, "degreeK") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:degreeR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#TemperatureUnit</para>
    ///
    /// labels<para>°R</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#degreeR">https://w3id.org/tribont/core#degreeR</seealso>
    let degreeR = Prefixed_Name(tribont_core, "degreeR") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:disc</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#Shape</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>disc</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#disc">https://w3id.org/tribont/core#disc</seealso>
    let disc = Prefixed_Name(tribont_core, "disc") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:dm3</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#CapacityUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>dm3</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#dm3">https://w3id.org/tribont/core#dm3</seealso>
    let dm3 = Prefixed_Name(tribont_core, "dm3") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:dry</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#LubricationRegime</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>dry</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#dry">https://w3id.org/tribont/core#dry</seealso>
    let dry = Prefixed_Name(tribont_core, "dry") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:dyncm</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#TensionUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>dyn/cm</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#dyncm">https://w3id.org/tribont/core#dyncm</seealso>
    let dyncm = Prefixed_Name(tribont_core, "dyncm") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:dyncm1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#ToughnessUnit</para>
    ///
    /// labels<para>dyn/cm1.5</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#dyncm1.5">https://w3id.org/tribont/core#dyncm1.5</seealso>
    let ``dyncm1.5`` = Prefixed_Name(tribont_core, "dyncm1.5") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:dyncm2</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#MechanicalUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>dyn/cm2</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#dyncm2">https://w3id.org/tribont/core#dyncm2</seealso>
    let dyncm2 = Prefixed_Name(tribont_core, "dyncm2") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:e-4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#PercentageUnit</para>
    ///
    /// labels<para>e-4</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#e-4">https://w3id.org/tribont/core#e-4</seealso>
    let e_4 = Prefixed_Name(tribont_core, "e-4") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:ergcm2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#TensionUnit</para>
    ///
    /// labels<para>erg/cm2</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ergcm2">https://w3id.org/tribont/core#ergcm2</seealso>
    let ergcm2 = Prefixed_Name(tribont_core, "ergcm2") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:ergcm3</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#MechanicalUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>erg/cm3</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ergcm3">https://w3id.org/tribont/core#ergcm3</seealso>
    let ergcm3 = Prefixed_Name(tribont_core, "ergcm3") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:ergg.degreeC</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#HeatCapacityUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>erg/g.°C</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ergg.degreeC">https://w3id.org/tribont/core#ergg.degreeC</seealso>
    let ``ergg.degreeC`` = Prefixed_Name(tribont_core, "ergg.degreeC") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:ergs.cm.degreeC</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#ThermalConductivityUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>s.cm.°C"</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ergs.cm.degreeC">https://w3id.org/tribont/core#ergs.cm.degreeC</seealso>
    let ``ergs.cm.degreeC`` =
        Prefixed_Name(tribont_core, "ergs.cm.degreeC") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:fl-ozUk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#CapacityUnit</para>
    ///
    /// labels<para>fl-ozUk</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#fl-ozUk">https://w3id.org/tribont/core#fl-ozUk</seealso>
    let fl_ozUk = Prefixed_Name(tribont_core, "fl-ozUk") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:ft.lbfft3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#MechanicalUnit</para>
    ///
    /// labels<para>ft.lbf/ft3</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ft.lbfft3">https://w3id.org/tribont/core#ft.lbfft3</seealso>
    let ``ft.lbfft3`` = Prefixed_Name(tribont_core, "ft.lbfft3") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:ft.lbfin2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#TensionUnit</para>
    ///
    /// labels<para>ft.lbf/in2</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ft.lbfin2">https://w3id.org/tribont/core#ft.lbfin2</seealso>
    let ``ft.lbfin2`` = Prefixed_Name(tribont_core, "ft.lbfin2") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:ft.lbfin3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#MechanicalUnit</para>
    ///
    /// labels<para>ft.lbf/in3</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ft.lbfin3">https://w3id.org/tribont/core#ft.lbfin3</seealso>
    let ``ft.lbfin3`` = Prefixed_Name(tribont_core, "ft.lbfin3") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:ft2hr</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#ViscosityUnit</para>
    ///
    /// labels<para>ft2/hr</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ft2hr">https://w3id.org/tribont/core#ft2hr</seealso>
    let ft2hr = Prefixed_Name(tribont_core, "ft2hr") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:ft2s</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#ViscosityUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>ft2/s</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ft2s">https://w3id.org/tribont/core#ft2s</seealso>
    let ft2s = Prefixed_Name(tribont_core, "ft2s") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:ft3</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#CapacityUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>ft3</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ft3">https://w3id.org/tribont/core#ft3</seealso>
    let ft3 = Prefixed_Name(tribont_core, "ft3") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:ftft</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#TendencyUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>ft/ft</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ftft">https://w3id.org/tribont/core#ftft</seealso>
    let ftft = Prefixed_Name(tribont_core, "ftft") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#WeightUnit</para>
    ///
    /// labels<para>g</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#g">https://w3id.org/tribont/core#g</seealso>
    let g = Prefixed_Name(tribont_core, "g") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:galUk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#CapacityUnit</para>
    ///
    /// labels<para>galUk</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#galUk">https://w3id.org/tribont/core#galUk</seealso>
    let galUk = Prefixed_Name(tribont_core, "galUk") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:galUs</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#CapacityUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>galUs</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#galUs">https://w3id.org/tribont/core#galUs</seealso>
    let galUs = Prefixed_Name(tribont_core, "galUs") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:gcm3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#DensityUnit</para>
    ///
    /// labels<para>g/cm3</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#gcm3">https://w3id.org/tribont/core#gcm3</seealso>
    let gcm3 = Prefixed_Name(tribont_core, "gcm3") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:gear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#Shape</para>
    ///
    /// labels<para>gear</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#gear">https://w3id.org/tribont/core#gear</seealso>
    let gear = Prefixed_Name(tribont_core, "gear") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:gmm3</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#DensityUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>g/mm3</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#gmm3">https://w3id.org/tribont/core#gmm3</seealso>
    let gmm3 = Prefixed_Name(tribont_core, "gmm3") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:grease</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#LubricantType</para>
    ///
    /// labels<para>grease</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#grease">https://w3id.org/tribont/core#grease</seealso>
    let grease = Prefixed_Name(tribont_core, "grease") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:grinded</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#PolishGrade</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>grinded</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#grinded">https://w3id.org/tribont/core#grinded</seealso>
    let grinded = Prefixed_Name(tribont_core, "grinded") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:h</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#HardnessUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>h</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#h">https://w3id.org/tribont/core#h</seealso>
    let h = Prefixed_Name(tribont_core, "h") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:isLocationFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a physical location and  and something that is located there..</para>
    /// labels<para>isLocationFor</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#isLocationFor">https://w3id.org/tribont/core#isLocationFor</seealso>
    let isLocationFor = Prefixed_Name(tribont_core, "isLocationFor") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:hasManufacturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between something and the company producing it.</para>
    /// labels<para>hasManufacturer</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#hasManufacturer">https://w3id.org/tribont/core#hasManufacturer</seealso>
    let hasManufacturer = Prefixed_Name(tribont_core, "hasManufacturer") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:isManufacturerFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between between a company and what it produces.</para>
    /// labels<para>isManufacturerFor</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#isManufacturerFor">https://w3id.org/tribont/core#isManufacturerFor</seealso>
    let isManufacturerFor =
        Prefixed_Name(tribont_core, "isManufacturerFor") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:hasOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between something and the company that owns it.</para>
    /// labels<para>hasOwner</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#hasOwner">https://w3id.org/tribont/core#hasOwner</seealso>
    let hasOwner = Prefixed_Name(tribont_core, "hasOwner") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:isOwnerOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between an company and something it owns..</para>
    /// labels<para>isOwnerOf</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#isOwnerOf">https://w3id.org/tribont/core#isOwnerOf</seealso>
    let isOwnerOf = Prefixed_Name(tribont_core, "isOwnerOf") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:hb</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#HardnessUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>hb</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#hb">https://w3id.org/tribont/core#hb</seealso>
    let hb = Prefixed_Name(tribont_core, "hb") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:hk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#HardnessUnit</para>
    ///
    /// labels<para>hk</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#hk">https://w3id.org/tribont/core#hk</seealso>
    let hk = Prefixed_Name(tribont_core, "hk") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:hour</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#TimeUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>hour</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#hour">https://w3id.org/tribont/core#hour</seealso>
    let hour = Prefixed_Name(tribont_core, "hour") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:hrb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#HardnessUnit</para>
    ///
    /// labels<para>hrb</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#hrb">https://w3id.org/tribont/core#hrb</seealso>
    let hrb = Prefixed_Name(tribont_core, "hrb") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:hrc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#HardnessUnit</para>
    ///
    /// labels<para>hrc</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#hrc">https://w3id.org/tribont/core#hrc</seealso>
    let hrc = Prefixed_Name(tribont_core, "hrc") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:hrm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#HardnessUnit</para>
    ///
    /// labels<para>hrm</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#hrm">https://w3id.org/tribont/core#hrm</seealso>
    let hrm = Prefixed_Name(tribont_core, "hrm") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:hrr</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#HardnessUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>hrr</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#hrr">https://w3id.org/tribont/core#hrr</seealso>
    let hrr = Prefixed_Name(tribont_core, "hrr") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:hv</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#HardnessUnit</para>
    ///
    /// labels<para>hv</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#hv">https://w3id.org/tribont/core#hv</seealso>
    let hv = Prefixed_Name(tribont_core, "hv") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:in.lbfin2</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#TensionUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>in.lbf/in2</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#in.lbfin2">https://w3id.org/tribont/core#in.lbfin2</seealso>
    let ``in.lbfin2`` = Prefixed_Name(tribont_core, "in.lbfin2") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:in.lbfin3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#MechanicalUnit</para>
    ///
    /// labels<para>in.lbf/in3</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#in.lbfin3">https://w3id.org/tribont/core#in.lbfin3</seealso>
    let ``in.lbfin3`` = Prefixed_Name(tribont_core, "in.lbfin3") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:inin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#TendencyUnit</para>
    ///
    /// labels<para>in/in</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#inin">https://w3id.org/tribont/core#inin</seealso>
    let inin = Prefixed_Name(tribont_core, "inin") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:inindegreeF</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#ExpansionCOFUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>in/in/°F</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#inindegreeF">https://w3id.org/tribont/core#inindegreeF</seealso>
    let inindegreeF = Prefixed_Name(tribont_core, "inindegreeF") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:innert_gas</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#EnvironmentMedium</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>innert_gas</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#innert_gas">https://w3id.org/tribont/core#innert_gas</seealso>
    let innert_gas = Prefixed_Name(tribont_core, "innert_gas") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:isMadeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between something and its component parts.</para>
    /// labels<para>isMadeOf</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#isMadeOf">https://w3id.org/tribont/core#isMadeOf</seealso>
    let isMadeOf = Prefixed_Name(tribont_core, "isMadeOf") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:isPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a component part and that of which it is a part.</para>
    /// labels<para>isPartOf</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#isPartOf">https://w3id.org/tribont/core#isPartOf</seealso>
    let isPartOf = Prefixed_Name(tribont_core, "isPartOf") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:kHz</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#FrequencyUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>kHz</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#kHz">https://w3id.org/tribont/core#kHz</seealso>
    let kHz = Prefixed_Name(tribont_core, "kHz") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:kJm2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#TensionUnit</para>
    ///
    /// labels<para>kJ/m2</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#kJm2">https://w3id.org/tribont/core#kJm2</seealso>
    let kJm2 = Prefixed_Name(tribont_core, "kJm2") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:kJm3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#MechanicalUnit</para>
    ///
    /// labels<para>kJ/m3</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#kJm3">https://w3id.org/tribont/core#kJm3</seealso>
    let kJm3 = Prefixed_Name(tribont_core, "kJm3") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:kNcm2</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#MechanicalUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>kN/cm2</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#kNcm2">https://w3id.org/tribont/core#kNcm2</seealso>
    let kNcm2 = Prefixed_Name(tribont_core, "kNcm2") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:kNm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#TensionUnit</para>
    ///
    /// labels<para>kN/m</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#kNm">https://w3id.org/tribont/core#kNm</seealso>
    let kNm = Prefixed_Name(tribont_core, "kNm") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:kg</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#WeightUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>kg</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#kg">https://w3id.org/tribont/core#kg</seealso>
    let kg = Prefixed_Name(tribont_core, "kg") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:kgfmm2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#MechanicalUnit</para>
    ///
    /// labels<para>kgf/mm2</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#kgfmm2">https://w3id.org/tribont/core#kgfmm2</seealso>
    let kgfmm2 = Prefixed_Name(tribont_core, "kgfmm2") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:kgm3</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#DensityUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>kg/m3</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#kgm3">https://w3id.org/tribont/core#kgm3</seealso>
    let kgm3 = Prefixed_Name(tribont_core, "kgm3") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:kgmm3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#DensityUnit</para>
    ///
    /// labels<para>kg/mm3</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#kgmm3">https://w3id.org/tribont/core#kgmm3</seealso>
    let kgmm3 = Prefixed_Name(tribont_core, "kgmm3") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:km</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#DistanceUnit</para>
    ///
    /// labels<para>km</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#km">https://w3id.org/tribont/core#km</seealso>
    let km = Prefixed_Name(tribont_core, "km") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:ksi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#MechanicalUnit</para>
    ///
    /// labels<para>ksi</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ksi">https://w3id.org/tribont/core#ksi</seealso>
    let ksi = Prefixed_Name(tribont_core, "ksi") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:ksi.in0.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#ToughnessUnit</para>
    ///
    /// labels<para>ksi.in0.5</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ksi.in0.5">https://w3id.org/tribont/core#ksi.in0.5</seealso>
    let ``ksi.in0.5`` = Prefixed_Name(tribont_core, "ksi.in0.5") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:kv</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#VoltageUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>kv</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#kv">https://w3id.org/tribont/core#kv</seealso>
    let kv = Prefixed_Name(tribont_core, "kv") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:lapped</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#PolishGrade</para>
    ///
    /// labels<para>lapped</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#lapped">https://w3id.org/tribont/core#lapped</seealso>
    let lapped = Prefixed_Name(tribont_core, "lapped") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:lbf.ftlb.degreeF</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#HeatCapacityUnit</para>
    ///
    /// labels<para>lbf.ft/lb.°F</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#lbf.ftlb.degreeF">https://w3id.org/tribont/core#lbf.ftlb.degreeF</seealso>
    let ``lbf.ftlb.degreeF`` =
        Prefixed_Name(tribont_core, "lbf.ftlb.degreeF") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:lbf.ftslug.degreeF</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#HeatCapacityUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>lbf.ft/slug.°F</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#lbf.ftslug.degreeF">https://w3id.org/tribont/core#lbf.ftslug.degreeF</seealso>
    let ``lbf.ftslug.degreeF`` =
        Prefixed_Name(tribont_core, "lbf.ftslug.degreeF") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:lbf.in.inlbf.s2.degreeF</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#HeatCapacityUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>lbf.in.in/lbf.s2.°F</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#lbf.in.inlbf.s2.degreeF">https://w3id.org/tribont/core#lbf.in.inlbf.s2.degreeF</seealso>
    let ``lbf.in.inlbf.s2.degreeF`` =
        Prefixed_Name(tribont_core, "lbf.in.inlbf.s2.degreeF") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:lbfft1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#ToughnessUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>lbf/ft1.5</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#lbfft1.5">https://w3id.org/tribont/core#lbfft1.5</seealso>
    let ``lbfft1.5`` = Prefixed_Name(tribont_core, "lbfft1.5") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:lbfft2</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#MechanicalUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>lbf/ft2</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#lbfft2">https://w3id.org/tribont/core#lbfft2</seealso>
    let lbfft2 = Prefixed_Name(tribont_core, "lbfft2") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:lbfin</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#TensionUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>lbf/in</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#lbfin">https://w3id.org/tribont/core#lbfin</seealso>
    let lbfin = Prefixed_Name(tribont_core, "lbfin") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:lbfs.degreeF</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#ThermalConductivityUnit</para>
    ///
    /// labels<para>lbf/s.°F</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#lbfs.degreeF">https://w3id.org/tribont/core#lbfs.degreeF</seealso>
    let ``lbfs.degreeF`` = Prefixed_Name(tribont_core, "lbfs.degreeF") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:lbft3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#DensityUnit</para>
    ///
    /// labels<para>lb/ft3</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#lbft3">https://w3id.org/tribont/core#lbft3</seealso>
    let lbft3 = Prefixed_Name(tribont_core, "lbft3") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:lbin3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#DensityUnit</para>
    ///
    /// labels<para>lb/in3</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#lbin3">https://w3id.org/tribont/core#lbin3</seealso>
    let lbin3 = Prefixed_Name(tribont_core, "lbin3") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:line</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#ContactSurfaceType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>line</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#line">https://w3id.org/tribont/core#line</seealso>
    let line = Prefixed_Name(tribont_core, "line") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:linear_reciprocating</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#CourseOfMovement</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>linear_reciprocating</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#linear_reciprocating">https://w3id.org/tribont/core#linear_reciprocating</seealso>
    let linear_reciprocating =
        Prefixed_Name(tribont_core, "linear_reciprocating") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:linear_unidirectional</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#CourseOfMovement</para>
    ///
    /// labels<para>linear_unidirectional</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#linear_unidirectional">https://w3id.org/tribont/core#linear_unidirectional</seealso>
    let linear_unidirectional =
        Prefixed_Name(tribont_core, "linear_unidirectional") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:liquid_lubricant</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#LubricantType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>liquid_lubricant</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#liquid_lubricant">https://w3id.org/tribont/core#liquid_lubricant</seealso>
    let liquid_lubricant =
        Prefixed_Name(tribont_core, "liquid_lubricant") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:longName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>long name of somebody or something.</para>
    /// labels<para>longName</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#longName">https://w3id.org/tribont/core#longName</seealso>
    let longName = Prefixed_Name(tribont_core, "longName") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:m</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#DistanceUnit</para>
    ///
    /// labels<para>m</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#m">https://w3id.org/tribont/core#m</seealso>
    let m = Prefixed_Name(tribont_core, "m") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:m2s</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#ViscosityUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>m2/s</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#m2s">https://w3id.org/tribont/core#m2s</seealso>
    let m2s = Prefixed_Name(tribont_core, "m2s") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:m3</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#CapacityUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>m3</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#m3">https://w3id.org/tribont/core#m3</seealso>
    let m3 = Prefixed_Name(tribont_core, "m3") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:mNm</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#TensionUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>mN/m</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#mNm">https://w3id.org/tribont/core#mNm</seealso>
    let mNm = Prefixed_Name(tribont_core, "mNm") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:mg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#WeightUnit</para>
    ///
    /// labels<para>mg</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#mg">https://w3id.org/tribont/core#mg</seealso>
    let mg = Prefixed_Name(tribont_core, "mg") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:mgm3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#DensityUnit</para>
    ///
    /// labels<para>mg/m3</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#mgm3">https://w3id.org/tribont/core#mgm3</seealso>
    let mgm3 = Prefixed_Name(tribont_core, "mgm3") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:microHz</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#FrequencyUnit</para>
    ///
    /// labels<para>µHz</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#microHz">https://w3id.org/tribont/core#microHz</seealso>
    let microHz = Prefixed_Name(tribont_core, "microHz") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:microinche</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#DistanceUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>microinche</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#microinche">https://w3id.org/tribont/core#microinche</seealso>
    let microinche = Prefixed_Name(tribont_core, "microinche") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:microm3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#CapacityUnit</para>
    ///
    /// labels<para>µm3</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#microm3">https://w3id.org/tribont/core#microm3</seealso>
    let microm3 = Prefixed_Name(tribont_core, "microm3") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:microstrain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#TendencyUnit</para>
    ///
    /// labels<para>µstrain</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#microstrain">https://w3id.org/tribont/core#microstrain</seealso>
    let microstrain = Prefixed_Name(tribont_core, "microstrain") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:microstraindegreeC</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#ExpansionCOFUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>µstrain/°C</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#microstraindegreeC">https://w3id.org/tribont/core#microstraindegreeC</seealso>
    let microstraindegreeC =
        Prefixed_Name(tribont_core, "microstraindegreeC") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:microstraindegreeF</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#ExpansionCOFUnit</para>
    ///
    /// labels<para>µstrain/°F</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#microstraindegreeF">https://w3id.org/tribont/core#microstraindegreeF</seealso>
    let microstraindegreeF =
        Prefixed_Name(tribont_core, "microstraindegreeF") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:mile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#DistanceUnit</para>
    ///
    /// labels<para>mile</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#mile">https://w3id.org/tribont/core#mile</seealso>
    let mile = Prefixed_Name(tribont_core, "mile") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:milisecond</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#TimeUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>milisecond</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#milisecond">https://w3id.org/tribont/core#milisecond</seealso>
    let milisecond = Prefixed_Name(tribont_core, "milisecond") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:min</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#RotationSpeedUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>/min</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#min">https://w3id.org/tribont/core#min</seealso>
    let min = Prefixed_Name(tribont_core, "min") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:minute</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#TimeUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>minute</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#minute">https://w3id.org/tribont/core#minute</seealso>
    let minute = Prefixed_Name(tribont_core, "minute") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:mixed_lubrication</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#LubricationRegime</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>mixed_lubrication</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#mixed_lubrication">https://w3id.org/tribont/core#mixed_lubrication</seealso>
    let mixed_lubrication =
        Prefixed_Name(tribont_core, "mixed_lubrication") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:ml</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#CapacityUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>ml</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ml">https://w3id.org/tribont/core#ml</seealso>
    let ml = Prefixed_Name(tribont_core, "ml") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:mlml</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#TendencyUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>ml/ml</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#mlml">https://w3id.org/tribont/core#mlml</seealso>
    let mlml = Prefixed_Name(tribont_core, "mlml") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:mm3</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#CapacityUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>mm3</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#mm3">https://w3id.org/tribont/core#mm3</seealso>
    let mm3 = Prefixed_Name(tribont_core, "mm3") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:mmmm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#TendencyUnit</para>
    ///
    /// labels<para>mm/mm</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#mmmm">https://w3id.org/tribont/core#mmmm</seealso>
    let mmmm = Prefixed_Name(tribont_core, "mmmm") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:mms</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#VelocityUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>mm/s</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#mms">https://w3id.org/tribont/core#mms</seealso>
    let mms = Prefixed_Name(tribont_core, "mms") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:mpa.m0.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#ToughnessUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>mpa.m0.5</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#mpa.m0.5">https://w3id.org/tribont/core#mpa.m0.5</seealso>
    let ``mpa.m0.5`` = Prefixed_Name(tribont_core, "mpa.m0.5") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:mpa.mm0.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#ToughnessUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>mpa.mm0.5</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#mpa.mm0.5">https://w3id.org/tribont/core#mpa.mm0.5</seealso>
    let ``mpa.mm0.5`` = Prefixed_Name(tribont_core, "mpa.mm0.5") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:ms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#VelocityUnit</para>
    ///
    /// labels<para>m/s</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ms">https://w3id.org/tribont/core#ms</seealso>
    let ms = Prefixed_Name(tribont_core, "ms") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:n103mbar</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#MechanicalUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>10-3_mbar</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#n103mbar">https://w3id.org/tribont/core#n103mbar</seealso>
    let n103mbar = Prefixed_Name(tribont_core, "n103mbar") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:n104straindegreeC</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#ExpansionCOFUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>10-4_strain/°C</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#n104straindegreeC">https://w3id.org/tribont/core#n104straindegreeC</seealso>
    let n104straindegreeC =
        Prefixed_Name(tribont_core, "n104straindegreeC") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:n106m2s</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#ViscosityUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>10-6m2/s</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#n106m2s">https://w3id.org/tribont/core#n106m2s</seealso>
    let n106m2s = Prefixed_Name(tribont_core, "n106m2s") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:n106psi</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#MechanicalUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>106psi</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#n106psi">https://w3id.org/tribont/core#n106psi</seealso>
    let n106psi = Prefixed_Name(tribont_core, "n106psi") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:nitrogen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#EnvironmentMedium</para>
    ///
    /// labels<para>nitrogen</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#nitrogen">https://w3id.org/tribont/core#nitrogen</seealso>
    let nitrogen = Prefixed_Name(tribont_core, "nitrogen") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:nmile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#DistanceUnit</para>
    ///
    /// labels<para>nmile</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#nmile">https://w3id.org/tribont/core#nmile</seealso>
    let nmile = Prefixed_Name(tribont_core, "nmile") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:nmm1.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#ToughnessUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>n/mm1.5</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#nmm1.5">https://w3id.org/tribont/core#nmm1.5</seealso>
    let ``nmm1.5`` = Prefixed_Name(tribont_core, "nmm1.5") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:no_lubricant</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#LubricantType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>no_lubricant</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#no_lubricant">https://w3id.org/tribont/core#no_lubricant</seealso>
    let no_lubricant = Prefixed_Name(tribont_core, "no_lubricant") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:oil</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#LubricantType</para>
    ///
    /// labels<para>oil</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#oil">https://w3id.org/tribont/core#oil</seealso>
    let oil = Prefixed_Name(tribont_core, "oil") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:pa.m0.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#ToughnessUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>pa.m0.5</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#pa.m0.5">https://w3id.org/tribont/core#pa.m0.5</seealso>
    let ``pa.m0.5`` = Prefixed_Name(tribont_core, "pa.m0.5") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:percentagestraindegreeF</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#ExpansionCOFUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>percentagestrain/°F</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#percentagestraindegreeF">https://w3id.org/tribont/core#percentagestraindegreeF</seealso>
    let percentagestraindegreeF =
        Prefixed_Name(tribont_core, "percentagestraindegreeF") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:percentangestraindegreeC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#ExpansionCOFUnit</para>
    ///
    /// labels<para>percentangestrain/°C</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#percentangestraindegreeC">https://w3id.org/tribont/core#percentangestraindegreeC</seealso>
    let percentangestraindegreeC =
        Prefixed_Name(tribont_core, "percentangestraindegreeC") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:pin</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#Shape</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>pin</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#pin">https://w3id.org/tribont/core#pin</seealso>
    let pin = Prefixed_Name(tribont_core, "pin") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:pin_on_disc</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#GeometricalArrangement</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>pin_on_disc</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#pin_on_disc">https://w3id.org/tribont/core#pin_on_disc</seealso>
    let pin_on_disc = Prefixed_Name(tribont_core, "pin_on_disc") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:pintUk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#CapacityUnit</para>
    ///
    /// labels<para>pintUk</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#pintUk">https://w3id.org/tribont/core#pintUk</seealso>
    let pintUk = Prefixed_Name(tribont_core, "pintUk") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:pintUs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#CapacityUnit</para>
    ///
    /// labels<para>pintUs</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#pintUs">https://w3id.org/tribont/core#pintUs</seealso>
    let pintUs = Prefixed_Name(tribont_core, "pintUs") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:plate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#Shape</para>
    ///
    /// labels<para>plate</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#plate">https://w3id.org/tribont/core#plate</seealso>
    let plate = Prefixed_Name(tribont_core, "plate") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:point</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#ContactSurfaceType</para>
    ///
    /// labels<para>point</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#point">https://w3id.org/tribont/core#point</seealso>
    let point = Prefixed_Name(tribont_core, "point") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:polished</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#PolishGrade</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>polished</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#polished">https://w3id.org/tribont/core#polished</seealso>
    let polished = Prefixed_Name(tribont_core, "polished") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:ppb</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#ContentUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>ppb</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ppb">https://w3id.org/tribont/core#ppb</seealso>
    let ppb = Prefixed_Name(tribont_core, "ppb") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:psi</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#MechanicalUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>psi</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#psi">https://w3id.org/tribont/core#psi</seealso>
    let psi = Prefixed_Name(tribont_core, "psi") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:psi.in0.5</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#ToughnessUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>psi.in0.5</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#psi.in0.5">https://w3id.org/tribont/core#psi.in0.5</seealso>
    let ``psi.in0.5`` = Prefixed_Name(tribont_core, "psi.in0.5") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:radian</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#AngleUnit</para>
    ///
    /// labels<para>radian</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#radian">https://w3id.org/tribont/core#radian</seealso>
    let radian = Prefixed_Name(tribont_core, "radian") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:ring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#Shape</para>
    ///
    /// labels<para>ring</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ring">https://w3id.org/tribont/core#ring</seealso>
    let ring = Prefixed_Name(tribont_core, "ring") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:ring_on_cylinder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#GeometricalArrangement</para>
    ///
    /// labels<para>ring_on_cylinder</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ring_on_cylinder">https://w3id.org/tribont/core#ring_on_cylinder</seealso>
    let ring_on_cylinder =
        Prefixed_Name(tribont_core, "ring_on_cylinder") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:second</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#TimeUnit</para>
    ///
    /// labels<para>second</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#second">https://w3id.org/tribont/core#second</seealso>
    let second = Prefixed_Name(tribont_core, "second") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:shaft</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#Shape</para>
    ///
    /// labels<para>shaft</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#shaft">https://w3id.org/tribont/core#shaft</seealso>
    let shaft = Prefixed_Name(tribont_core, "shaft") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:sliding</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#MovementType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>sliding</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#sliding">https://w3id.org/tribont/core#sliding</seealso>
    let sliding = Prefixed_Name(tribont_core, "sliding") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:sliding_wear</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#WearType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>sliding_wear</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#sliding_wear">https://w3id.org/tribont/core#sliding_wear</seealso>
    let sliding_wear = Prefixed_Name(tribont_core, "sliding_wear") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:slip</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#MovementType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>slip</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#slip">https://w3id.org/tribont/core#slip</seealso>
    let slip = Prefixed_Name(tribont_core, "slip") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:slip_rolling_wear</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#WearType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>slip_rolling_wear</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#slip_rolling_wear">https://w3id.org/tribont/core#slip_rolling_wear</seealso>
    let slip_rolling_wear =
        Prefixed_Name(tribont_core, "slip_rolling_wear") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:slugft3</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#DensityUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>slug/ft3</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#slugft3">https://w3id.org/tribont/core#slugft3</seealso>
    let slugft3 = Prefixed_Name(tribont_core, "slugft3") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:solid_friction</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#LubricationRegime</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>solid_friction</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#solid_friction">https://w3id.org/tribont/core#solid_friction</seealso>
    let solid_friction = Prefixed_Name(tribont_core, "solid_friction") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:solid_lubricant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#LubricantType</para>
    ///
    /// labels<para>solid_lubricant</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#solid_lubricant">https://w3id.org/tribont/core#solid_lubricant</seealso>
    let solid_lubricant = Prefixed_Name(tribont_core, "solid_lubricant") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:sonotrode</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#Shape</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>sonotrode</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#sonotrode">https://w3id.org/tribont/core#sonotrode</seealso>
    let sonotrode = Prefixed_Name(tribont_core, "sonotrode") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:sp-gr2323degreeC</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#DensityUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>sp-gr23/23°C</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#sp-gr2323degreeC">https://w3id.org/tribont/core#sp-gr2323degreeC</seealso>
    let sp_gr2323degreeC =
        Prefixed_Name(tribont_core, "sp-gr2323degreeC") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:stick_slip</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#MovementType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>stick_slip</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#stick_slip">https://w3id.org/tribont/core#stick_slip</seealso>
    let stick_slip = Prefixed_Name(tribont_core, "stick_slip") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:strain</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#TendencyUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>strain</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#strain">https://w3id.org/tribont/core#strain</seealso>
    let strain = Prefixed_Name(tribont_core, "strain") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:strain_percentage</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#TendencyUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>strain_percentage</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#strain_percentage">https://w3id.org/tribont/core#strain_percentage</seealso>
    let strain_percentage =
        Prefixed_Name(tribont_core, "strain_percentage") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:straindegreeC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#ExpansionCOFUnit</para>
    ///
    /// labels<para>strain/°C</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#straindegreeC">https://w3id.org/tribont/core#straindegreeC</seealso>
    let straindegreeC = Prefixed_Name(tribont_core, "straindegreeC") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:straindegreeF</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#ExpansionCOFUnit</para>
    ///
    /// labels<para>strain/°F</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#straindegreeF">https://w3id.org/tribont/core#straindegreeF</seealso>
    let straindegreeF = Prefixed_Name(tribont_core, "straindegreeF") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:synthetic_air</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#EnvironmentMedium</para>
    ///
    /// labels<para>synthetic_air</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#synthetic_air">https://w3id.org/tribont/core#synthetic_air</seealso>
    let synthetic_air = Prefixed_Name(tribont_core, "synthetic_air") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:tonin3</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#DensityUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>ton/in3</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#tonin3">https://w3id.org/tribont/core#tonin3</seealso>
    let tonin3 = Prefixed_Name(tribont_core, "tonin3") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:tonnemm3</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#DensityUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>tonne/mm3</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#tonnemm3">https://w3id.org/tribont/core#tonnemm3</seealso>
    let tonnemm3 = Prefixed_Name(tribont_core, "tonnemm3") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:torr</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#MechanicalUnit</para>
    ///
    /// labels<para>torr</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#torr">https://w3id.org/tribont/core#torr</seealso>
    let torr = Prefixed_Name(tribont_core, "torr") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:tribocorrosive_wear</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#WearType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>tribocorrosive_wear</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#tribocorrosive_wear">https://w3id.org/tribont/core#tribocorrosive_wear</seealso>
    let tribocorrosive_wear =
        Prefixed_Name(tribont_core, "tribocorrosive_wear") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:v</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#VoltageUnit</para>
    ///
    /// labels<para>-v</para><para>v</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#v">https://w3id.org/tribont/core#v</seealso>
    let v = Prefixed_Name(tribont_core, "v") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:vacuum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#EnvironmentMedium</para>
    ///
    /// labels<para>vacuum</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#vacuum">https://w3id.org/tribont/core#vacuum</seealso>
    let vacuum = Prefixed_Name(tribont_core, "vacuum") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:week</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#TimeUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>week</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#week">https://w3id.org/tribont/core#week</seealso>
    let week = Prefixed_Name(tribont_core, "week") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:wt_percentage</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#HardnessUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>wt_percentage</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#wt_percentage">https://w3id.org/tribont/core#wt_percentage</seealso>
    let wt_percentage = Prefixed_Name(tribont_core, "wt_percentage") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:yd</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#DistanceUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>yd</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#yd">https://w3id.org/tribont/core#yd</seealso>
    let yd = Prefixed_Name(tribont_core, "yd") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:year</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#TimeUnit</para>
    ///
    /// labels<para>year</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#year">https://w3id.org/tribont/core#year</seealso>
    let year = Prefixed_Name(tribont_core, "year") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:FrictionTorque</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Friction torque applied to something.</para>
    /// labels<para>FrictionTorque</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#FrictionTorque">https://w3id.org/tribont/core#FrictionTorque</seealso>
    let FrictionTorque = Prefixed_Name(tribont_core, "FrictionTorque") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:in100ft</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#TendencyUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>in/100ft</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#in100ft">https://w3id.org/tribont/core#in100ft</seealso>
    let in100ft = Prefixed_Name(tribont_core, "in100ft") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Rku</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Kurtosis</para>
    /// labels<para>Rku</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Rku">https://w3id.org/tribont/core#Rku</seealso>
    let Rku = Prefixed_Name(tribont_core, "Rku") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Rpk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Reduced peak height</para>
    /// labels<para>Rpk</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Rpk">https://w3id.org/tribont/core#Rpk</seealso>
    let Rpk = Prefixed_Name(tribont_core, "Rpk") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:lbf.s2in.in3</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#DensityUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>lbf.s2/in.in3</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#lbf.s2in.in3">https://w3id.org/tribont/core#lbf.s2in.in3</seealso>
    let ``lbf.s2in.in3`` = Prefixed_Name(tribont_core, "lbf.s2in.in3") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Torque</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Torque applied to something.</para>
    /// labels<para>Torque</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Torque">https://w3id.org/tribont/core#Torque</seealso>
    let Torque = Prefixed_Name(tribont_core, "Torque") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Ra</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Arithmetical mean height of the absolute values.</para>
    /// labels<para>Ra</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Ra">https://w3id.org/tribont/core#Ra</seealso>
    let Ra = Prefixed_Name(tribont_core, "Ra") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Rk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Core height.</para>
    /// labels<para>Rk</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Rk">https://w3id.org/tribont/core#Rk</seealso>
    let Rk = Prefixed_Name(tribont_core, "Rk") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Rmk1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Material ratio of the reduced peak height</para>
    /// labels<para>Rmk1</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Rmk1">https://w3id.org/tribont/core#Rmk1</seealso>
    let Rmk1 = Prefixed_Name(tribont_core, "Rmk1") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:ContactSurfaceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Contact surface type (e.g. line, point,etc. .</para>
    /// labels<para>ContactSurfaceType</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ContactSurfaceType">https://w3id.org/tribont/core#ContactSurfaceType</seealso>
    let ContactSurfaceType =
        Prefixed_Name(tribont_core, "ContactSurfaceType") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:Rmk2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Material ratio of the reduced valley depth</para>
    /// labels<para>Rmk2</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Rmk2">https://w3id.org/tribont/core#Rmk2</seealso>
    let Rmk2 = Prefixed_Name(tribont_core, "Rmk2") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Rpkx</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Reduced peak height along x</para>
    /// labels<para>Rpkx</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Rpkx">https://w3id.org/tribont/core#Rpkx</seealso>
    let Rpkx = Prefixed_Name(tribont_core, "Rpkx") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Rt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Total height</para>
    /// labels<para>Rt</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Rt">https://w3id.org/tribont/core#Rt</seealso>
    let Rt = Prefixed_Name(tribont_core, "Rt") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Rz</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Mean total height</para>
    /// labels<para>Rz</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Rz">https://w3id.org/tribont/core#Rz</seealso>
    let Rz = Prefixed_Name(tribont_core, "Rz") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Sku</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Kurtosis</para>
    /// labels<para>Sku</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Sku">https://w3id.org/tribont/core#Sku</seealso>
    let Sku = Prefixed_Name(tribont_core, "Sku") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:CoradsonCarbonResidue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Coradson carbon residue in something .</para>
    /// labels<para>CoradsonCarbonResidue</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#CoradsonCarbonResidue">https://w3id.org/tribont/core#CoradsonCarbonResidue</seealso>
    let CoradsonCarbonResidue =
        Prefixed_Name(tribont_core, "CoradsonCarbonResidue") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:InterfacialTensionBetweenWaterOil</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Interfacial Tension Between Water Oil</para>
    /// labels<para>InterfacialTensionBetweenWaterOil</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#InterfacialTensionBetweenWaterOil">https://w3id.org/tribont/core#InterfacialTensionBetweenWaterOil</seealso>
    let InterfacialTensionBetweenWaterOil =
        Prefixed_Name(tribont_core, "InterfacialTensionBetweenWaterOil") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:KinematicViscosity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Kinematic viscosity of something.</para>
    /// labels<para>KinematicViscosity</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#KinematicViscosity">https://w3id.org/tribont/core#KinematicViscosity</seealso>
    let KinematicViscosity =
        Prefixed_Name(tribont_core, "KinematicViscosity") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:LodineNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Lodine number of something.</para>
    /// labels<para>LodineNumber</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#LodineNumber">https://w3id.org/tribont/core#LodineNumber</seealso>
    let LodineNumber = Prefixed_Name(tribont_core, "LodineNumber") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:LubricantsOxidationStability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Lubricants oxidation stability.</para>
    /// labels<para>LubricantsOxidationStability</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#LubricantsOxidationStability">https://w3id.org/tribont/core#LubricantsOxidationStability</seealso>
    let LubricantsOxidationStability =
        Prefixed_Name(tribont_core, "LubricantsOxidationStability") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:Company</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A company.</para>
    /// labels<para>Company</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Company">https://w3id.org/tribont/core#Company</seealso>
    let Company = Prefixed_Name(tribont_core, "Company") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Document</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any document.</para>
    /// labels<para>Document</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Document">https://w3id.org/tribont/core#Document</seealso>
    let Document = Prefixed_Name(tribont_core, "Document") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:m_m</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#TendencyUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>m/m</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#m_m">https://w3id.org/tribont/core#m_m</seealso>
    let m_m = Prefixed_Name(tribont_core, "m_m") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:mb</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#MechanicalUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>mb</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#mb">https://w3id.org/tribont/core#mb</seealso>
    let mb = Prefixed_Name(tribont_core, "mb") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:lbf.inlb.degreeF</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#HeatCapacityUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>lbf.in/lb.°F</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#lbf.inlb.degreeF">https://w3id.org/tribont/core#lbf.inlb.degreeF</seealso>
    let ``lbf.inlb.degreeF`` =
        Prefixed_Name(tribont_core, "lbf.inlb.degreeF") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:lbfft</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#TensionUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>lbf/ft</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#lbfft">https://w3id.org/tribont/core#lbfft</seealso>
    let lbfft = Prefixed_Name(tribont_core, "lbfft") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Rp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Mean peak height.</para>
    /// labels<para>Rp</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Rp">https://w3id.org/tribont/core#Rp</seealso>
    let Rp = Prefixed_Name(tribont_core, "Rp") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Rsk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Skewness</para>
    /// labels<para>Rsk</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Rsk">https://w3id.org/tribont/core#Rsk</seealso>
    let Rsk = Prefixed_Name(tribont_core, "Rsk") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Rv</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Mean valley depth</para>
    /// labels<para>Rv</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Rv">https://w3id.org/tribont/core#Rv</seealso>
    let Rv = Prefixed_Name(tribont_core, "Rv") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Sa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Arithmetical mean height</para>
    /// labels<para>Sa</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Sa">https://w3id.org/tribont/core#Sa</seealso>
    let Sa = Prefixed_Name(tribont_core, "Sa") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Sdr</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sdr.</para>
    /// labels<para>Sdr</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Sdr">https://w3id.org/tribont/core#Sdr</seealso>
    let Sdr = Prefixed_Name(tribont_core, "Sdr") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Smk2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Material ratio of the dales</para>
    /// labels<para>Smk2</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Smk2">https://w3id.org/tribont/core#Smk2</seealso>
    let Smk2 = Prefixed_Name(tribont_core, "Smk2") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Spkx</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Maximum peak height</para>
    /// labels<para>Spkx</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Spkx">https://w3id.org/tribont/core#Spkx</seealso>
    let Spkx = Prefixed_Name(tribont_core, "Spkx") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:mm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#DistanceUnit</para>
    ///
    /// labels<para>mm</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#mm">https://w3id.org/tribont/core#mm</seealso>
    let mm = Prefixed_Name(tribont_core, "mm") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:mm2s</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#ViscosityUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>mm2/s</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#mm2s">https://w3id.org/tribont/core#mm2s</seealso>
    let mm2s = Prefixed_Name(tribont_core, "mm2s") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Rq</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Root mean square height</para>
    /// labels<para>Rq</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Rq">https://w3id.org/tribont/core#Rq</seealso>
    let Rq = Prefixed_Name(tribont_core, "Rq") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Rvkx</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Maximum peak height</para>
    /// labels<para>Rvkx</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Rvkx">https://w3id.org/tribont/core#Rvkx</seealso>
    let Rvkx = Prefixed_Name(tribont_core, "Rvkx") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Sdq</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sdq.</para>
    /// labels<para>Sdq</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Sdq">https://w3id.org/tribont/core#Sdq</seealso>
    let Sdq = Prefixed_Name(tribont_core, "Sdq") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Smk1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Material ratio of the hills</para>
    /// labels<para>Smk1</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Smk1">https://w3id.org/tribont/core#Smk1</seealso>
    let Smk1 = Prefixed_Name(tribont_core, "Smk1") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Spk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Reduced peak height</para>
    /// labels<para>Spk</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Spk">https://w3id.org/tribont/core#Spk</seealso>
    let Spk = Prefixed_Name(tribont_core, "Spk") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The position or purpose that someone or something has in a situation, organization, society, or relationship:.</para>
    /// labels<para>Role</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Role">https://w3id.org/tribont/core#Role</seealso>
    let Role = Prefixed_Name(tribont_core, "Role") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:mm2ms</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#ViscosityUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>mm2/ms</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#mm2ms">https://w3id.org/tribont/core#mm2ms</seealso>
    let mm2ms = Prefixed_Name(tribont_core, "mm2ms") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Conductivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Conductivity  of something.</para>
    /// labels<para>Conductivity</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Conductivity">https://w3id.org/tribont/core#Conductivity</seealso>
    let Conductivity = Prefixed_Name(tribont_core, "Conductivity") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Sk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Core height</para>
    /// labels<para>Sk</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Sk">https://w3id.org/tribont/core#Sk</seealso>
    let Sk = Prefixed_Name(tribont_core, "Sk") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Sp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Maximum peak height</para>
    /// labels<para>Sp</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Sp">https://w3id.org/tribont/core#Sp</seealso>
    let Sp = Prefixed_Name(tribont_core, "Sp") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Sq</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Root mean square height</para>
    /// labels<para>Sq</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Sq">https://w3id.org/tribont/core#Sq</seealso>
    let Sq = Prefixed_Name(tribont_core, "Sq") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Svk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Reduced valley depth</para>
    /// labels<para>Svk</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Svk">https://w3id.org/tribont/core#Svk</seealso>
    let Svk = Prefixed_Name(tribont_core, "Svk") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Svkx</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Maximum valley depth</para>
    /// labels<para>Svkx</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Svkx">https://w3id.org/tribont/core#Svkx</seealso>
    let Svkx = Prefixed_Name(tribont_core, "Svkx") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Vmc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Core material volume</para>
    /// labels<para>Vmc</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Vmc">https://w3id.org/tribont/core#Vmc</seealso>
    let Vmc = Prefixed_Name(tribont_core, "Vmc") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Vvc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Core void volume</para>
    /// labels<para>Vvc</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Vvc">https://w3id.org/tribont/core#Vvc</seealso>
    let Vvc = Prefixed_Name(tribont_core, "Vvc") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:mPa</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#PressureUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>mPa</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#mPa">https://w3id.org/tribont/core#mPa</seealso>
    let mPa = Prefixed_Name(tribont_core, "mPa") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Sv</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Maximum valley depth</para>
    /// labels<para>Sv</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Sv">https://w3id.org/tribont/core#Sv</seealso>
    let Sv = Prefixed_Name(tribont_core, "Sv") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:ring_on_disc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#GeometricalArrangement</para>
    ///
    /// labels<para>ring_on_disc</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ring_on_disc">https://w3id.org/tribont/core#ring_on_disc</seealso>
    let ring_on_disc = Prefixed_Name(tribont_core, "ring_on_disc") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:rolling</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#MovementType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>rolling</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#rolling">https://w3id.org/tribont/core#rolling</seealso>
    let rolling = Prefixed_Name(tribont_core, "rolling") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:rotating_unidirectional</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#CourseOfMovement</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>rotating_unidirectional</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#rotating_unidirectional">https://w3id.org/tribont/core#rotating_unidirectional</seealso>
    let rotating_unidirectional =
        Prefixed_Name(tribont_core, "rotating_unidirectional") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:Ssk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Skewness</para>
    /// labels<para>Ssk</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Ssk">https://w3id.org/tribont/core#Ssk</seealso>
    let Ssk = Prefixed_Name(tribont_core, "Ssk") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:MovementProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Qualifiable or quantifiable attribute, or characteristic of something's movement.</para>
    /// labels<para>MovementProperty</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#MovementProperty">https://w3id.org/tribont/core#MovementProperty</seealso>
    let MovementProperty =
        Prefixed_Name(tribont_core, "MovementProperty") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:rotating_reciprocating</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#CourseOfMovement</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>rotating_reciprocating</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#rotating_reciprocating">https://w3id.org/tribont/core#rotating_reciprocating</seealso>
    let rotating_reciprocating =
        Prefixed_Name(tribont_core, "rotating_reciprocating") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:rpm</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#RotationSpeedUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>rpm</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#rpm">https://w3id.org/tribont/core#rpm</seealso>
    let rpm = Prefixed_Name(tribont_core, "rpm") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:seal</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#Shape</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>seal</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#seal">https://w3id.org/tribont/core#seal</seealso>
    let seal = Prefixed_Name(tribont_core, "seal") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Sz</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Maximum height z</para>
    /// labels<para>Sz</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Sz">https://w3id.org/tribont/core#Sz</seealso>
    let Sz = Prefixed_Name(tribont_core, "Sz") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Vmp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Peak material volume</para>
    /// labels<para>Vmp</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Vmp">https://w3id.org/tribont/core#Vmp</seealso>
    let Vmp = Prefixed_Name(tribont_core, "Vmp") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Diameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Diameter of something.</para>
    /// labels<para>Diameter</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Diameter">https://w3id.org/tribont/core#Diameter</seealso>
    let Diameter = Prefixed_Name(tribont_core, "Diameter") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Length</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Length of something.</para>
    /// labels<para>Length</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Length">https://w3id.org/tribont/core#Length</seealso>
    let Length = Prefixed_Name(tribont_core, "Length") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:TeethHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Height of a teeth. .</para>
    /// labels<para>TeethHeight</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#TeethHeight">https://w3id.org/tribont/core#TeethHeight</seealso>
    let TeethHeight = Prefixed_Name(tribont_core, "TeethHeight") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:AngularPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Angular position of something.</para>
    /// labels<para>AngularPosition</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#AngularPosition">https://w3id.org/tribont/core#AngularPosition</seealso>
    let AngularPosition = Prefixed_Name(tribont_core, "AngularPosition") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:ambient_humidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#Humidity</para>
    ///
    /// labels<para>ambient_humidity</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ambient_humidity">https://w3id.org/tribont/core#ambient_humidity</seealso>
    let ambient_humidity =
        Prefixed_Name(tribont_core, "ambient_humidity") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:seal_on_shaft</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#GeometricalArrangement</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>seal_on_shaft</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#seal_on_shaft">https://w3id.org/tribont/core#seal_on_shaft</seealso>
    let seal_on_shaft = Prefixed_Name(tribont_core, "seal_on_shaft") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:TeethLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Length of a teeth. .</para>
    /// labels<para>TeethLength</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#TeethLength">https://w3id.org/tribont/core#TeethLength</seealso>
    let TeethLength = Prefixed_Name(tribont_core, "TeethLength") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Frequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Frequency of something.</para>
    /// labels<para>Frequency</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Frequency">https://w3id.org/tribont/core#Frequency</seealso>
    let Frequency = Prefixed_Name(tribont_core, "Frequency") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:SlidingSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sliding speed of something.</para>
    /// labels<para>SlidingSpeed</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#SlidingSpeed">https://w3id.org/tribont/core#SlidingSpeed</seealso>
    let SlidingSpeed = Prefixed_Name(tribont_core, "SlidingSpeed") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:StrokeAmplitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Stroke amplitude.</para>
    /// labels<para>StrokeAmplitude</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#StrokeAmplitude">https://w3id.org/tribont/core#StrokeAmplitude</seealso>
    let StrokeAmplitude = Prefixed_Name(tribont_core, "StrokeAmplitude") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Velocity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Velocity of something.</para>
    /// labels<para>Velocity</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Velocity">https://w3id.org/tribont/core#Velocity</seealso>
    let Velocity = Prefixed_Name(tribont_core, "Velocity") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:CapacityUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurement unit for capacity.</para>
    /// labels<para>CapacityUnit</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#CapacityUnit">https://w3id.org/tribont/core#CapacityUnit</seealso>
    let CapacityUnit = Prefixed_Name(tribont_core, "CapacityUnit") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:ContentUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurement unit for contents.</para>
    /// labels<para>ContentUnit</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ContentUnit">https://w3id.org/tribont/core#ContentUnit</seealso>
    let ContentUnit = Prefixed_Name(tribont_core, "ContentUnit") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:ExpansionCOFUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurement unit for expansion coefficient.</para>
    /// labels<para>ExpansionCOFUnit</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ExpansionCOFUnit">https://w3id.org/tribont/core#ExpansionCOFUnit</seealso>
    let ExpansionCOFUnit =
        Prefixed_Name(tribont_core, "ExpansionCOFUnit") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:FrequencyUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurement unit for frequency.</para>
    /// labels<para>FrequencyUnit</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#FrequencyUnit">https://w3id.org/tribont/core#FrequencyUnit</seealso>
    let FrequencyUnit = Prefixed_Name(tribont_core, "FrequencyUnit") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:HeatCapacityUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurement unit for heat capacity.</para>
    /// labels<para>HeatCapacityUnit</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#HeatCapacityUnit">https://w3id.org/tribont/core#HeatCapacityUnit</seealso>
    let HeatCapacityUnit =
        Prefixed_Name(tribont_core, "HeatCapacityUnit") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:PercentageUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurement unit for angle.</para>
    /// labels<para>PercentageUnit</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#PercentageUnit">https://w3id.org/tribont/core#PercentageUnit</seealso>
    let PercentageUnit = Prefixed_Name(tribont_core, "PercentageUnit") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:RotationSpeedUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurement unit for rotational speed.</para>
    /// labels<para>RotationSpeedUnit</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#RotationSpeedUnit">https://w3id.org/tribont/core#RotationSpeedUnit</seealso>
    let RotationSpeedUnit =
        Prefixed_Name(tribont_core, "RotationSpeedUnit") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:TemperatureUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurement unit for temperature.</para>
    /// labels<para>TemperatureUni</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#TemperatureUnit">https://w3id.org/tribont/core#TemperatureUnit</seealso>
    let TemperatureUnit = Prefixed_Name(tribont_core, "TemperatureUnit") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:ThermalConductivityUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurement unit for conductivity.</para>
    /// labels<para>ThermalConductivityUnit</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ThermalConductivityUnit">https://w3id.org/tribont/core#ThermalConductivityUnit</seealso>
    let ThermalConductivityUnit =
        Prefixed_Name(tribont_core, "ThermalConductivityUnit") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:TimeUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurement unit for time.</para>
    /// labels<para>TimeUnit</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#TimeUnit">https://w3id.org/tribont/core#TimeUnit</seealso>
    let TimeUnit = Prefixed_Name(tribont_core, "TimeUnit") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:ToughnessUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurement unit for toughness.</para>
    /// labels<para>ToughnessUnit</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ToughnessUnit">https://w3id.org/tribont/core#ToughnessUnit</seealso>
    let ToughnessUnit = Prefixed_Name(tribont_core, "ToughnessUnit") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:VelocityUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurement unit for velocity.</para>
    /// labels<para>VelocityUnit</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#VelocityUnit">https://w3id.org/tribont/core#VelocityUnit</seealso>
    let VelocityUnit = Prefixed_Name(tribont_core, "VelocityUnit") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:VoltageUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurement unit for voltage.</para>
    /// labels<para>VoltageUnit</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#VoltageUnit">https://w3id.org/tribont/core#VoltageUnit</seealso>
    let VoltageUnit = Prefixed_Name(tribont_core, "VoltageUnit") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:WeightUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurement unit for weight.</para>
    /// labels<para>WeightUnit</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#WeightUnit">https://w3id.org/tribont/core#WeightUnit</seealso>
    let WeightUnit = Prefixed_Name(tribont_core, "WeightUnit") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Shape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The form or outline of something</para>
    /// labels<para>Shape</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Shape">https://w3id.org/tribont/core#Shape</seealso>
    let Shape = Prefixed_Name(tribont_core, "Shape") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Volume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Volume of someting.</para>
    /// labels<para>Volume</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Volume">https://w3id.org/tribont/core#Volume</seealso>
    let Volume = Prefixed_Name(tribont_core, "Volume") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Inclination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Inclination of the camber where the test is carried out.</para>
    /// labels<para>Inclination</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Inclination">https://w3id.org/tribont/core#Inclination</seealso>
    let Inclination = Prefixed_Name(tribont_core, "Inclination") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:O2Level</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>O2 level of something.</para>
    /// labels<para>O2Level</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#O2Level">https://w3id.org/tribont/core#O2Level</seealso>
    let O2Level = Prefixed_Name(tribont_core, "O2Level") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Pressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Pressure applied to soemthing.</para>
    /// labels<para>Pressure</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Pressure">https://w3id.org/tribont/core#Pressure</seealso>
    let Pressure = Prefixed_Name(tribont_core, "Pressure") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:RadiationDosage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Radiation dosage applied to something.</para>
    /// labels<para>RadiationDosage</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#RadiationDosage">https://w3id.org/tribont/core#RadiationDosage</seealso>
    let RadiationDosage = Prefixed_Name(tribont_core, "RadiationDosage") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Temperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Temperature ofsomebody or something.</para>
    /// labels<para>Temperature</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Temperature">https://w3id.org/tribont/core#Temperature</seealso>
    let Temperature = Prefixed_Name(tribont_core, "Temperature") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:CompressiveStrength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Compressive strength applied to something.</para>
    /// labels<para>CompressiveStrength</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#CompressiveStrength">https://w3id.org/tribont/core#CompressiveStrength</seealso>
    let CompressiveStrength =
        Prefixed_Name(tribont_core, "CompressiveStrength") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:FlexuralStrength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Flexural strength of something.</para>
    /// labels<para>FlexuralStrength</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#FlexuralStrength">https://w3id.org/tribont/core#FlexuralStrength</seealso>
    let FlexuralStrength =
        Prefixed_Name(tribont_core, "FlexuralStrength") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:HardnessProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Quantifiable attribute, or characteristic of the hardness of a body.</para>
    /// labels<para>HardnessProperty</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#HardnessProperty">https://w3id.org/tribont/core#HardnessProperty</seealso>
    let HardnessProperty =
        Prefixed_Name(tribont_core, "HardnessProperty") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:PoisssonRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Poissson ratio of something.</para>
    /// labels<para>PoisssonRatio</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#PoisssonRatio">https://w3id.org/tribont/core#PoisssonRatio</seealso>
    let PoisssonRatio = Prefixed_Name(tribont_core, "PoisssonRatio") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:TensileStrength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Tensile strength of something.</para>
    /// labels<para>TensileStrength</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#TensileStrength">https://w3id.org/tribont/core#TensileStrength</seealso>
    let TensileStrength = Prefixed_Name(tribont_core, "TensileStrength") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:WeibullModulus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Weibull modulus of something.</para>
    /// labels<para>WeibullModulus</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#WeibullModulus">https://w3id.org/tribont/core#WeibullModulus</seealso>
    let WeibullModulus = Prefixed_Name(tribont_core, "WeibullModulus") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:MaximumServiceTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Maximun temperature of operation.</para>
    /// labels<para>MaximumServiceTemperature</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#MaximumServiceTemperature">https://w3id.org/tribont/core#MaximumServiceTemperature</seealso>
    let MaximumServiceTemperature =
        Prefixed_Name(tribont_core, "MaximumServiceTemperature") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:MeltingPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Melting point  of something.</para>
    /// labels<para>MeltingPoint</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#MeltingPoint">https://w3id.org/tribont/core#MeltingPoint</seealso>
    let MeltingPoint = Prefixed_Name(tribont_core, "MeltingPoint") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:ThermalConductivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Thermal conductivity of something.</para>
    /// labels<para>ThermalConductivity</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ThermalConductivity">https://w3id.org/tribont/core#ThermalConductivity</seealso>
    let ThermalConductivity =
        Prefixed_Name(tribont_core, "ThermalConductivity") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:ThermalExpansionCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Thermal expansion coefficient of something.</para>
    /// labels<para>ThermalExpansionCoefficient</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ThermalExpansionCoefficient">https://w3id.org/tribont/core#ThermalExpansionCoefficient</seealso>
    let ThermalExpansionCoefficient =
        Prefixed_Name(tribont_core, "ThermalExpansionCoefficient") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:HardnessBrinell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Brinell hardness of something.</para>
    /// labels<para>HardnessBrinell</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#HardnessBrinell">https://w3id.org/tribont/core#HardnessBrinell</seealso>
    let HardnessBrinell = Prefixed_Name(tribont_core, "HardnessBrinell") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:HardnessKnoop100g</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Knoop hardness of something.</para>
    /// labels<para>HardnessKnoop100g</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#HardnessKnoop100g">https://w3id.org/tribont/core#HardnessKnoop100g</seealso>
    let HardnessKnoop100g =
        Prefixed_Name(tribont_core, "HardnessKnoop100g") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:HardnessRockwellB</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>RockwellB hardness of something .</para>
    /// labels<para>HardnessRockwellB</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#HardnessRockwellB">https://w3id.org/tribont/core#HardnessRockwellB</seealso>
    let HardnessRockwellB =
        Prefixed_Name(tribont_core, "HardnessRockwellB") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:HardnessRockwellC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>RockwellC hardness of something .</para>
    /// labels<para>HardnessRockwellC</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#HardnessRockwellC">https://w3id.org/tribont/core#HardnessRockwellC</seealso>
    let HardnessRockwellC =
        Prefixed_Name(tribont_core, "HardnessRockwellC") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:HardnessRockwellR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>RockwellR hardness of something .</para>
    /// labels<para>HardnessRockwellR</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#HardnessRockwellR">https://w3id.org/tribont/core#HardnessRockwellR</seealso>
    let HardnessRockwellR =
        Prefixed_Name(tribont_core, "HardnessRockwellR") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:HardnessShoreA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>ShoreA hardness of something .</para>
    /// labels<para>HardnessShoreA</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#HardnessShoreA">https://w3id.org/tribont/core#HardnessShoreA</seealso>
    let HardnessShoreA = Prefixed_Name(tribont_core, "HardnessShoreA") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:HardnessShoreD</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>ShoreD hardness of something .</para>
    /// labels<para>HardnessShoreD</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#HardnessShoreD">https://w3id.org/tribont/core#HardnessShoreD</seealso>
    let HardnessShoreD = Prefixed_Name(tribont_core, "HardnessShoreD") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:HardnessVickers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Vickers hardness of something .</para>
    /// labels<para>HardnessVickers</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#HardnessVickers">https://w3id.org/tribont/core#HardnessVickers</seealso>
    let HardnessVickers = Prefixed_Name(tribont_core, "HardnessVickers") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:GeometricalArrangement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Geometrical combination of bodies belonging to a tribological system (e.g. ball on disc).</para>
    /// labels<para>GeometricalArrangement</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#GeometricalArrangement">https://w3id.org/tribont/core#GeometricalArrangement</seealso>
    let GeometricalArrangement =
        Prefixed_Name(tribont_core, "GeometricalArrangement") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:NumberOfContactSurface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Number of contact surfaces of something.</para>
    /// labels<para>NumberOfContactSurface</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#NumberOfContactSurface">https://w3id.org/tribont/core#NumberOfContactSurface</seealso>
    let NumberOfContactSurface =
        Prefixed_Name(tribont_core, "NumberOfContactSurface") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:OperationProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Quantifiable operation attribute, or characteristic of something.</para>
    /// labels<para>OperationProperty</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#OperationProperty">https://w3id.org/tribont/core#OperationProperty</seealso>
    let OperationProperty =
        Prefixed_Name(tribont_core, "OperationProperty") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:SystemProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Qualifiable or quantifiable  attribute, or characteristic of a sample system. .</para>
    /// labels<para>SystemProperty</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#SystemProperty">https://w3id.org/tribont/core#SystemProperty</seealso>
    let SystemProperty = Prefixed_Name(tribont_core, "SystemProperty") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:TechnicalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Qualifiable or quantifiable technical attribute, or characteristic of something. .</para>
    /// labels<para>TechnicalProperty</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#TechnicalProperty">https://w3id.org/tribont/core#TechnicalProperty</seealso>
    let TechnicalProperty =
        Prefixed_Name(tribont_core, "TechnicalProperty") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:CloudPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Cloud point.</para>
    /// labels<para>CloudPoint</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#CloudPoint">https://w3id.org/tribont/core#CloudPoint</seealso>
    let CloudPoint = Prefixed_Name(tribont_core, "CloudPoint") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:ColdFilterPluggingPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Cold filter plugging point.</para>
    /// labels<para>ColdFilterPluggingPoint</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ColdFilterPluggingPoint">https://w3id.org/tribont/core#ColdFilterPluggingPoint</seealso>
    let ColdFilterPluggingPoint =
        Prefixed_Name(tribont_core, "ColdFilterPluggingPoint") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:FlashPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Flash point of something.</para>
    /// labels<para>FlashPoint</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#FlashPoint">https://w3id.org/tribont/core#FlashPoint</seealso>
    let FlashPoint = Prefixed_Name(tribont_core, "FlashPoint") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:PourPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Pour point of something.</para>
    /// labels<para>PourPoint</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#PourPoint">https://w3id.org/tribont/core#PourPoint</seealso>
    let PourPoint = Prefixed_Name(tribont_core, "PourPoint") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:AcidNumberAN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Acid number of something.</para>
    /// labels<para>AcidNumberAN</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#AcidNumberAN">https://w3id.org/tribont/core#AcidNumberAN</seealso>
    let AcidNumberAN = Prefixed_Name(tribont_core, "AcidNumberAN") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:AirReleaseTimeLAV</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Air release time for something.</para>
    /// labels<para>AirReleaseTimeLAV</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#AirReleaseTimeLAV">https://w3id.org/tribont/core#AirReleaseTimeLAV</seealso>
    let AirReleaseTimeLAV =
        Prefixed_Name(tribont_core, "AirReleaseTimeLAV") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:AlkalineAdditivesConsumption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Consumption of alkaline additives by something.</para>
    /// labels<para>AlkalineAdditivesConsumption</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#AlkalineAdditivesConsumption">https://w3id.org/tribont/core#AlkalineAdditivesConsumption</seealso>
    let AlkalineAdditivesConsumption =
        Prefixed_Name(tribont_core, "AlkalineAdditivesConsumption") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:ColourIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Colour index  of something.</para>
    /// labels<para>ColourIndex</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ColourIndex">https://w3id.org/tribont/core#ColourIndex</seealso>
    let ColourIndex = Prefixed_Name(tribont_core, "ColourIndex") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:CorrosionLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Corrosion level of something.</para>
    /// labels<para>CorrosionLevel</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#CorrosionLevel">https://w3id.org/tribont/core#CorrosionLevel</seealso>
    let CorrosionLevel = Prefixed_Name(tribont_core, "CorrosionLevel") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Dispersancy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Dispersancy of something.</para>
    /// labels<para>Dispersancy</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Dispersancy">https://w3id.org/tribont/core#Dispersancy</seealso>
    let Dispersancy = Prefixed_Name(tribont_core, "Dispersancy") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:DissipationFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Dissipation factor of something.</para>
    /// labels<para>DissipationFactor</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#DissipationFactor">https://w3id.org/tribont/core#DissipationFactor</seealso>
    let DissipationFactor =
        Prefixed_Name(tribont_core, "DissipationFactor") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:DynamicViscosity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Dynamic viscosity of something.</para>
    /// labels<para>DynamicViscosity</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#DynamicViscosity">https://w3id.org/tribont/core#DynamicViscosity</seealso>
    let DynamicViscosity =
        Prefixed_Name(tribont_core, "DynamicViscosity") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:ElectricalBreakdownVoltage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Electrical breakdown voltage of something.</para>
    /// labels<para>ElectricalBreakdownVoltage</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ElectricalBreakdownVoltage">https://w3id.org/tribont/core#ElectricalBreakdownVoltage</seealso>
    let ElectricalBreakdownVoltage =
        Prefixed_Name(tribont_core, "ElectricalBreakdownVoltage") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:Filterability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Filterability of something.</para>
    /// labels<para>Filterability</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Filterability">https://w3id.org/tribont/core#Filterability</seealso>
    let Filterability = Prefixed_Name(tribont_core, "Filterability") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:FoamingTendency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Foaming tendency of something.</para>
    /// labels<para>FoamingTendency</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#FoamingTendency">https://w3id.org/tribont/core#FoamingTendency</seealso>
    let FoamingTendency = Prefixed_Name(tribont_core, "FoamingTendency") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:InhibitedHydraulicFluidsOxidationStabilityAndLubricatingOilsForHighPressureLoads</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Inhibited Hydraulic Fluids Oxidation Stability And Lubricating Oils For High Pressure Loads.</para>
    /// labels<para>InhibitedHydraulicFluidsOxidationStabilityAndLubricatingOilsForHighPressureLoads</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#InhibitedHydraulicFluidsOxidationStabilityAndLubricatingOilsForHighPressureLoads">https://w3id.org/tribont/core#InhibitedHydraulicFluidsOxidationStabilityAndLubricatingOilsForHighPressureLoads</seealso>
    let InhibitedHydraulicFluidsOxidationStabilityAndLubricatingOilsForHighPressureLoads =
        Prefixed_Name(tribont_core, "InhibitedHydraulicFluidsOxidationStabilityAndLubricatingOilsForHighPressureLoads") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:NeutralisationNumberNN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Neutralisation number of something.</para>
    /// labels<para>NeutralisationNumberNN</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#NeutralisationNumberNN">https://w3id.org/tribont/core#NeutralisationNumberNN</seealso>
    let NeutralisationNumberNN =
        Prefixed_Name(tribont_core, "NeutralisationNumberNN") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:PQIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>PQ index of something.</para>
    /// labels<para>PQIndex</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#PQIndex">https://w3id.org/tribont/core#PQIndex</seealso>
    let PQIndex = Prefixed_Name(tribont_core, "PQIndex") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:RelativeDielectricConstant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Relative dielectric constant of something.</para>
    /// labels<para>RelativeDielectricConstant</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#RelativeDielectricConstant">https://w3id.org/tribont/core#RelativeDielectricConstant</seealso>
    let RelativeDielectricConstant =
        Prefixed_Name(tribont_core, "RelativeDielectricConstant") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:Rust-PreventingCharacteristicInPresenceOfWater</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Rust-Preventing Characteristic In Presence Of Water.</para>
    /// labels<para>Rust-PreventingCharacteristicInPresenceOfWater</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Rust-PreventingCharacteristicInPresenceOfWater">https://w3id.org/tribont/core#Rust-PreventingCharacteristicInPresenceOfWater</seealso>
    let Rust_PreventingCharacteristicInPresenceOfWater =
        Prefixed_Name(tribont_core, "Rust-PreventingCharacteristicInPresenceOfWater") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:ShearStability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Shear stability.</para>
    /// labels<para>ShearStability</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ShearStability">https://w3id.org/tribont/core#ShearStability</seealso>
    let ShearStability = Prefixed_Name(tribont_core, "ShearStability") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:i-ph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>i-phof something.</para>
    /// labels<para>i-ph</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#i-ph">https://w3id.org/tribont/core#i-ph</seealso>
    let i_ph = Prefixed_Name(tribont_core, "i-ph") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Standard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A reference point against which other things can be evaluated or compared.</para>
    /// labels<para>Standard</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Standard">https://w3id.org/tribont/core#Standard</seealso>
    let Standard = Prefixed_Name(tribont_core, "Standard") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:%C3%85</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#DistanceUnit</para>
    ///
    /// labels<para>Å</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#%C3%85">https://w3id.org/tribont/core#%C3%85</seealso>
    let ``_%C3%85`` = Prefixed_Name(tribont_core, "%C3%85") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:ASTMD5706</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>ASTMD5706</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ASTMD5706">https://w3id.org/tribont/core#ASTMD5706</seealso>
    let ASTMD5706 = Prefixed_Name(tribont_core, "ASTMD5706") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:ASTMD5707</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>ASTMD5707</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ASTMD5707">https://w3id.org/tribont/core#ASTMD5707</seealso>
    let ASTMD5707 = Prefixed_Name(tribont_core, "ASTMD5707") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:ASTMD6425</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>ASTMD6425</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ASTMD6425">https://w3id.org/tribont/core#ASTMD6425</seealso>
    let ASTMD6425 = Prefixed_Name(tribont_core, "ASTMD6425") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:ASTMD7421</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>ASTMD7421</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ASTMD7421">https://w3id.org/tribont/core#ASTMD7421</seealso>
    let ASTMD7421 = Prefixed_Name(tribont_core, "ASTMD7421") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:LiquidPhysicalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Qualifiable or quantifiable physical attribute, or characteristic of a liquid.</para>
    /// labels<para>LiquidPhysicalProperty</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#LiquidPhysicalProperty">https://w3id.org/tribont/core#LiquidPhysicalProperty</seealso>
    let LiquidPhysicalProperty =
        Prefixed_Name(tribont_core, "LiquidPhysicalProperty") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:LoadProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Qualifiable or quantifiable  attribute, or characteristic of load.</para>
    /// labels<para>LoadProperty</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#LoadProperty">https://w3id.org/tribont/core#LoadProperty</seealso>
    let LoadProperty = Prefixed_Name(tribont_core, "LoadProperty") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:BTUhr.ft.degreeF</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#ThermalConductivityUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>BTU/hr.ft.°F</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#BTUhr.ft.degreeF">https://w3id.org/tribont/core#BTUhr.ft.degreeF</seealso>
    let ``BTUhr.ft.degreeF`` =
        Prefixed_Name(tribont_core, "BTUhr.ft.degreeF") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:BTUin2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#TensionUnit</para>
    ///
    /// labels<para>BTU/in2</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#BTUin2">https://w3id.org/tribont/core#BTUin2</seealso>
    let BTUin2 = Prefixed_Name(tribont_core, "BTUin2") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:BTUlb.degreeF</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#HeatCapacityUnit</para>
    ///
    /// labels<para>BTU/lb.°F</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#BTUlb.degreeF">https://w3id.org/tribont/core#BTUlb.degreeF</seealso>
    let ``BTUlb.degreeF`` = Prefixed_Name(tribont_core, "BTUlb.degreeF") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Ba</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#MechanicalUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Ba</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Ba">https://w3id.org/tribont/core#Ba</seealso>
    let Ba = Prefixed_Name(tribont_core, "Ba") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Body</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A body can be considered as an aggregate of particles to which it is possible to apply a force</para>
    /// labels<para>Body</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Body">https://w3id.org/tribont/core#Body</seealso>
    let Body = Prefixed_Name(tribont_core, "Body") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:COFMean</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Mean value of the coefficient of friction.</para>
    /// labels<para>COFMean</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#COFMean">https://w3id.org/tribont/core#COFMean</seealso>
    let COFMean = Prefixed_Name(tribont_core, "COFMean") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:FrictionProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Qualifiable or quantifiable attribute, or characteristic of the friction between two or more bodies.</para>
    /// labels<para>FrictionProperty</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#FrictionProperty">https://w3id.org/tribont/core#FrictionProperty</seealso>
    let FrictionProperty =
        Prefixed_Name(tribont_core, "FrictionProperty") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:ChamberTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Temperature of the chamber where the sample is tested.</para>
    /// labels<para>ChamberTemperature</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ChamberTemperature">https://w3id.org/tribont/core#ChamberTemperature</seealso>
    let ChamberTemperature =
        Prefixed_Name(tribont_core, "ChamberTemperature") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:SampleTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Temperature of the sample body.</para>
    /// labels<para>SampleTemperature</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#SampleTemperature">https://w3id.org/tribont/core#SampleTemperature</seealso>
    let SampleTemperature =
        Prefixed_Name(tribont_core, "SampleTemperature") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:LiquidThermalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Qualifiable or quantifiable thermal attribute, or characteristic of a liquid.</para>
    /// labels<para>LiquidThermalProperty</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#LiquidThermalProperty">https://w3id.org/tribont/core#LiquidThermalProperty</seealso>
    let LiquidThermalProperty =
        Prefixed_Name(tribont_core, "LiquidThermalProperty") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:shortName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Short name of somebody or something.</para>
    /// labels<para>shortName</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#shortName">https://w3id.org/tribont/core#shortName</seealso>
    let shortName = Prefixed_Name(tribont_core, "shortName") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Name of somebody or something.</para>
    /// labels<para>name</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#name">https://w3id.org/tribont/core#name</seealso>
    let name = Prefixed_Name(tribont_core, "name") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:percentage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#PercentageUnit</para>
    ///
    /// labels<para>percentage</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#percentage">https://w3id.org/tribont/core#percentage</seealso>
    let percentage = Prefixed_Name(tribont_core, "percentage") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:CourseOfMovement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Type of relative motion  between two or more bodies.</para>
    /// labels<para>CourseOfMovement</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#CourseOfMovement">https://w3id.org/tribont/core#CourseOfMovement</seealso>
    let CourseOfMovement =
        Prefixed_Name(tribont_core, "CourseOfMovement") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:Density</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Density of something.</para>
    /// labels<para>Density</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Density">https://w3id.org/tribont/core#Density</seealso>
    let Density = Prefixed_Name(tribont_core, "Density") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:SolidPhysicalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Qualifiable or quantifiable physical attribute, or characteristic of a solid.</para>
    /// labels<para>SolidPhysicalProperty</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#SolidPhysicalProperty">https://w3id.org/tribont/core#SolidPhysicalProperty</seealso>
    let SolidPhysicalProperty =
        Prefixed_Name(tribont_core, "SolidPhysicalProperty") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:Porosity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Porosity of something.</para>
    /// labels<para>Porosity</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Porosity">https://w3id.org/tribont/core#Porosity</seealso>
    let Porosity = Prefixed_Name(tribont_core, "Porosity") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Amount of time during which an event persists.</para>
    /// labels<para>Duration</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Duration">https://w3id.org/tribont/core#Duration</seealso>
    let Duration = Prefixed_Name(tribont_core, "Duration") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:EHD</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#LubricationRegime</para>
    ///
    /// labels<para>EHD</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#EHD">https://w3id.org/tribont/core#EHD</seealso>
    let EHD = Prefixed_Name(tribont_core, "EHD") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:LubricationRegime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Lubrication regime applied to a test or process .</para>
    /// labels<para>LubricationRegime</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#LubricationRegime">https://w3id.org/tribont/core#LubricationRegime</seealso>
    let LubricationRegime =
        Prefixed_Name(tribont_core, "LubricationRegime") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:ElectricalConductivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Electrical conductivity of something.</para>
    /// labels<para>ElectricalConductivity</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ElectricalConductivity">https://w3id.org/tribont/core#ElectricalConductivity</seealso>
    let ElectricalConductivity =
        Prefixed_Name(tribont_core, "ElectricalConductivity") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:ElectricalResistivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Electrical resistivity of something.</para>
    /// labels<para>ElectricalResistivity</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ElectricalResistivity">https://w3id.org/tribont/core#ElectricalResistivity</seealso>
    let ElectricalResistivity =
        Prefixed_Name(tribont_core, "ElectricalResistivity") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:EnvironmentMedium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Environment medium surrounding something .</para>
    /// labels<para>EnvironmentMedium</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#EnvironmentMedium">https://w3id.org/tribont/core#EnvironmentMedium</seealso>
    let EnvironmentMedium =
        Prefixed_Name(tribont_core, "EnvironmentMedium") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:EnvironmentProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Qualifiable or quantifiable attribute, or characteristic of the enviroment  in which a test has been / or should be carried out.</para>
    /// labels<para>EnvironmentProperty</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#EnvironmentProperty">https://w3id.org/tribont/core#EnvironmentProperty</seealso>
    let EnvironmentProperty =
        Prefixed_Name(tribont_core, "EnvironmentProperty") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:HV</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#MechanicalUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>HV</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#HV">https://w3id.org/tribont/core#HV</seealso>
    let HV = Prefixed_Name(tribont_core, "HV") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Hz</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#FrequencyUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Hz</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Hz">https://w3id.org/tribont/core#Hz</seealso>
    let Hz = Prefixed_Name(tribont_core, "Hz") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:InnerDiameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Inner diameter of something.</para>
    /// labels<para>InnerDiameter</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#InnerDiameter">https://w3id.org/tribont/core#InnerDiameter</seealso>
    let InnerDiameter = Prefixed_Name(tribont_core, "InnerDiameter") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:OuterDiameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Outer diameter.</para>
    /// labels<para>OuterDiameter</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#OuterDiameter">https://w3id.org/tribont/core#OuterDiameter</seealso>
    let OuterDiameter = Prefixed_Name(tribont_core, "OuterDiameter") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:InnerTeethHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Inner teeth height of something.</para>
    /// labels<para>InnerTeethHeight</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#InnerTeethHeight">https://w3id.org/tribont/core#InnerTeethHeight</seealso>
    let InnerTeethHeight =
        Prefixed_Name(tribont_core, "InnerTeethHeight") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:OuterTeethHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Outer teeth height of something.</para>
    /// labels<para>OuterTeethHeight</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#OuterTeethHeight">https://w3id.org/tribont/core#OuterTeethHeight</seealso>
    let OuterTeethHeight =
        Prefixed_Name(tribont_core, "OuterTeethHeight") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:InnerTeethLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Inner teeth length of something.</para>
    /// labels<para>InnerTeethLength</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#InnerTeethLength">https://w3id.org/tribont/core#InnerTeethLength</seealso>
    let InnerTeethLength =
        Prefixed_Name(tribont_core, "InnerTeethLength") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:OuterTeethLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Outer teeth length of something.</para>
    /// labels<para>OuterTeethLength</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#OuterTeethLength">https://w3id.org/tribont/core#OuterTeethLength</seealso>
    let OuterTeethLength =
        Prefixed_Name(tribont_core, "OuterTeethLength") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:Jcm3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#MechanicalUnit</para>
    ///
    /// labels<para>cm3</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Jcm3">https://w3id.org/tribont/core#Jcm3</seealso>
    let Jcm3 = Prefixed_Name(tribont_core, "Jcm3") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Jkg.degreeC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#HeatCapacityUnit</para>
    ///
    /// labels<para>J/kg.°C</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Jkg.degreeC">https://w3id.org/tribont/core#Jkg.degreeC</seealso>
    let ``Jkg.degreeC`` = Prefixed_Name(tribont_core, "Jkg.degreeC") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Jm.s.degreeC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#ThermalConductivityUnit</para>
    ///
    /// labels<para>J/m.s.°C</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Jm.s.degreeC">https://w3id.org/tribont/core#Jm.s.degreeC</seealso>
    let ``Jm.s.degreeC`` = Prefixed_Name(tribont_core, "Jm.s.degreeC") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Jm3</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#MechanicalUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>J/m3</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Jm3">https://w3id.org/tribont/core#Jm3</seealso>
    let Jm3 = Prefixed_Name(tribont_core, "Jm3") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Kgf</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#ForceUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Kgf</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Kgf">https://w3id.org/tribont/core#Kgf</seealso>
    let Kgf = Prefixed_Name(tribont_core, "Kgf") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Laboratory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A laboratory.</para>
    /// labels<para>Laboratory</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Laboratory">https://w3id.org/tribont/core#Laboratory</seealso>
    let Laboratory = Prefixed_Name(tribont_core, "Laboratory") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:SolidThermalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Qualifiable or quantifiable thermal attribute, or characteristic of a solid.</para>
    /// labels<para>SolidThermalProperty</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#SolidThermalProperty">https://w3id.org/tribont/core#SolidThermalProperty</seealso>
    let SolidThermalProperty =
        Prefixed_Name(tribont_core, "SolidThermalProperty") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:LubricantType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Lubricant type.</para>
    /// labels<para>LubricantType</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#LubricantType">https://w3id.org/tribont/core#LubricantType</seealso>
    let LubricantType = Prefixed_Name(tribont_core, "LubricantType") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:MGO</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#MechanicalUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>MGO</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#MGO">https://w3id.org/tribont/core#MGO</seealso>
    let MGO = Prefixed_Name(tribont_core, "MGO") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:MJm2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#TensionUnit</para>
    ///
    /// labels<para>MJ/m2</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#MJm2">https://w3id.org/tribont/core#MJm2</seealso>
    let MJm2 = Prefixed_Name(tribont_core, "MJm2") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:MJm3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#MechanicalUnit</para>
    ///
    /// labels<para>MJ/m3</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#MJm3">https://w3id.org/tribont/core#MJm3</seealso>
    let MJm3 = Prefixed_Name(tribont_core, "MJm3") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:MPa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#MechanicalUnit</para>
    ///
    /// labels<para>MPa</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#MPa">https://w3id.org/tribont/core#MPa</seealso>
    let MPa = Prefixed_Name(tribont_core, "MPa") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:MaxLoadWithoutFailure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Maximun load before failure of the material.</para>
    /// labels<para>MaxLoadWithoutFailure</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#MaxLoadWithoutFailure">https://w3id.org/tribont/core#MaxLoadWithoutFailure</seealso>
    let MaxLoadWithoutFailure =
        Prefixed_Name(tribont_core, "MaxLoadWithoutFailure") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:MovementType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Type of movement appled to something.</para>
    /// labels<para>MovementType</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#MovementType">https://w3id.org/tribont/core#MovementType</seealso>
    let MovementType = Prefixed_Name(tribont_core, "MovementType") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:N</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#ForceUnit</para>
    ///
    /// labels<para>N</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#N">https://w3id.org/tribont/core#N</seealso>
    let N = Prefixed_Name(tribont_core, "N") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:N.m</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#TorqueUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>N.m</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#N.m">https://w3id.org/tribont/core#N.m</seealso>
    let ``N.m`` = Prefixed_Name(tribont_core, "N.m") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:N.mmg.degreeC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#HeatCapacityUnit</para>
    ///
    /// labels<para>N.mm/g.°C</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#N.mmg.degreeC">https://w3id.org/tribont/core#N.mmg.degreeC</seealso>
    let ``N.mmg.degreeC`` = Prefixed_Name(tribont_core, "N.mmg.degreeC") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:N.mmmm2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#TensionUnit</para>
    ///
    /// labels<para>N.mm/mm2</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#N.mmmm2">https://w3id.org/tribont/core#N.mmmm2</seealso>
    let ``N.mmmm2`` = Prefixed_Name(tribont_core, "N.mmmm2") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:N.mmmm3</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#MechanicalUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>N.mm/mm3</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#N.mmmm3">https://w3id.org/tribont/core#N.mmmm3</seealso>
    let ``N.mmmm3`` = Prefixed_Name(tribont_core, "N.mmmm3") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:N.mmms.mm.degreeC</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#ThermalConductivityUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>N.mm/ms.mm.°C</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#N.mmms.mm.degreeC">https://w3id.org/tribont/core#N.mmms.mm.degreeC</seealso>
    let ``N.mmms.mm.degreeC`` =
        Prefixed_Name(tribont_core, "N.mmms.mm.degreeC") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:N.mmsmm.degreeC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#ThermalConductivityUnit</para>
    ///
    /// labels<para>N.mm/s/mm.°C</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#N.mmsmm.degreeC">https://w3id.org/tribont/core#N.mmsmm.degreeC</seealso>
    let ``N.mmsmm.degreeC`` =
        Prefixed_Name(tribont_core, "N.mmsmm.degreeC") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:N.mmtonne.degreeC</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#HeatCapacityUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>N.mm/tonne.°C</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#N.mmtonne.degreeC">https://w3id.org/tribont/core#N.mmtonne.degreeC</seealso>
    let ``N.mmtonne.degreeC`` =
        Prefixed_Name(tribont_core, "N.mmtonne.degreeC") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:N2CO295</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#EnvironmentMedium</para>
    ///
    /// labels<para>N2CO295</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#N2CO295">https://w3id.org/tribont/core#N2CO295</seealso>
    let N2CO295 = Prefixed_Name(tribont_core, "N2CO295") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Nmm</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#TensionUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>N/mm</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Nmm">https://w3id.org/tribont/core#Nmm</seealso>
    let Nmm = Prefixed_Name(tribont_core, "Nmm") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Nmm2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#MechanicalUnit</para>
    ///
    /// labels<para>N/mm2</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Nmm2">https://w3id.org/tribont/core#Nmm2</seealso>
    let Nmm2 = Prefixed_Name(tribont_core, "Nmm2") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Ns</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#LoadRateUnit</para>
    ///
    /// labels<para>N/s</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Ns">https://w3id.org/tribont/core#Ns</seealso>
    let Ns = Prefixed_Name(tribont_core, "Ns") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Width</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Width of something.</para>
    /// labels<para>Width</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Width">https://w3id.org/tribont/core#Width</seealso>
    let Width = Prefixed_Name(tribont_core, "Width") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Decceleration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Decrease in speed or rate.</para>
    /// labels<para>Decceleration</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Decceleration">https://w3id.org/tribont/core#Decceleration</seealso>
    let Decceleration = Prefixed_Name(tribont_core, "Decceleration") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:NormalForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Normal force applied to something.</para>
    /// labels<para>NormalForce</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#NormalForce">https://w3id.org/tribont/core#NormalForce</seealso>
    let NormalForce = Prefixed_Name(tribont_core, "NormalForce") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:SlipPercentage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Slip percentage of something.</para>
    /// labels<para>SlipPercentage</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#SlipPercentage">https://w3id.org/tribont/core#SlipPercentage</seealso>
    let SlipPercentage = Prefixed_Name(tribont_core, "SlipPercentage") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:StrokeLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Stroke length.</para>
    /// labels<para>StrokeLength</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#StrokeLength">https://w3id.org/tribont/core#StrokeLength</seealso>
    let StrokeLength = Prefixed_Name(tribont_core, "StrokeLength") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Jm2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#TensionUnit</para>
    ///
    /// labels<para>J/m2</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Jm2">https://w3id.org/tribont/core#Jm2</seealso>
    let Jm2 = Prefixed_Name(tribont_core, "Jm2") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:day</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#TimeUnit</para>
    ///
    /// labels<para>day</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#day">https://w3id.org/tribont/core#day</seealso>
    let day = Prefixed_Name(tribont_core, "day") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:degree</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#AngleUnit</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>degree</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#degree">https://w3id.org/tribont/core#degree</seealso>
    let degree = Prefixed_Name(tribont_core, "degree") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:Acceleration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Increase in speed or rate.</para>
    /// labels<para>Acceleration</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Acceleration">https://w3id.org/tribont/core#Acceleration</seealso>
    let Acceleration = Prefixed_Name(tribont_core, "Acceleration") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:LinearSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Linear speed of something.</para>
    /// labels<para>LinearSpeed</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#LinearSpeed">https://w3id.org/tribont/core#LinearSpeed</seealso>
    let LinearSpeed = Prefixed_Name(tribont_core, "LinearSpeed") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:calg.degreeC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#HeatCapacityUnit</para>
    ///
    /// labels<para>cal/g.°C</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#calg.degreeC">https://w3id.org/tribont/core#calg.degreeC</seealso>
    let ``calg.degreeC`` = Prefixed_Name(tribont_core, "calg.degreeC") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:AccelerationUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurement unit for derivative of velocity with respect to time.</para>
    /// labels<para>AccelerationUnit</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#AccelerationUnit">https://w3id.org/tribont/core#AccelerationUnit</seealso>
    let AccelerationUnit =
        Prefixed_Name(tribont_core, "AccelerationUnit") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:cylinder</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:tribont/core#Shape</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>cylinder</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#cylinder">https://w3id.org/tribont/core#cylinder</seealso>
    let cylinder = Prefixed_Name(tribont_core, "cylinder") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:DensityUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurement unit for density.</para>
    /// labels<para>DensityUnit</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#DensityUnit">https://w3id.org/tribont/core#DensityUnit</seealso>
    let DensityUnit = Prefixed_Name(tribont_core, "DensityUnit") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:LoadRateUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurement unit for load rate.</para>
    /// labels<para>LoadRateUnit</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#LoadRateUnit">https://w3id.org/tribont/core#LoadRateUnit</seealso>
    let LoadRateUnit = Prefixed_Name(tribont_core, "LoadRateUnit") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:TendencyUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurement unit for tendency.</para>
    /// labels<para>TendencyUnit</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#TendencyUnit">https://w3id.org/tribont/core#TendencyUnit</seealso>
    let TendencyUnit = Prefixed_Name(tribont_core, "TendencyUnit") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:fl-ozUs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#CapacityUnit</para>
    ///
    /// labels<para>fl-ozUs</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#fl-ozUs">https://w3id.org/tribont/core#fl-ozUs</seealso>
    let fl_ozUs = Prefixed_Name(tribont_core, "fl-ozUs") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:fretting_wear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#WearType</para>
    ///
    /// labels<para>fretting_wear</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#fretting_wear">https://w3id.org/tribont/core#fretting_wear</seealso>
    let fretting_wear = Prefixed_Name(tribont_core, "fretting_wear") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:ft.lbfft2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:tribont/core#TensionUnit</para>
    ///
    /// labels<para>ft.lbf/ft2</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ft.lbfft2">https://w3id.org/tribont/core#ft.lbfft2</seealso>
    let ``ft.lbfft2`` = Prefixed_Name(tribont_core, "ft.lbfft2") |> PrefixedName
    /// <summary>
    ///   <para>tribont-core:ForceUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurement unit for force.</para>
    /// labels<para>ForceUnit</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ForceUnit">https://w3id.org/tribont/core#ForceUnit</seealso>
    let ForceUnit = Prefixed_Name(tribont_core, "ForceUnit") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:MagnificationProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>MagnificationProperty applyed to something.</para>
    /// labels<para>MagnificationProperty</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#MagnificationProperty">https://w3id.org/tribont/core#MagnificationProperty</seealso>
    let MagnificationProperty =
        Prefixed_Name(tribont_core, "MagnificationProperty") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:ElectricalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Qualifiable or quantifiable attribute, or characteristic of electrical behaviour of something.</para>
    /// labels<para>ElectricalProperty</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#ElectricalProperty">https://w3id.org/tribont/core#ElectricalProperty</seealso>
    let ElectricalProperty =
        Prefixed_Name(tribont_core, "ElectricalProperty") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:MechanicalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Qualifiable or quantifiable attribute, or characteristic of mechanical behaviour of something.</para>
    /// labels<para>MechanicalProperty</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#MechanicalProperty">https://w3id.org/tribont/core#MechanicalProperty</seealso>
    let MechanicalProperty =
        Prefixed_Name(tribont_core, "MechanicalProperty") |> PrefixedName

    /// <summary>
    ///   <para>tribont-core:Height</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Height of something.</para>
    /// labels<para>Height</para></remarks>
    /// <seealso href="https://w3id.org/tribont/core#Height">https://w3id.org/tribont/core#Height</seealso>
    let Height = Prefixed_Name(tribont_core, "Height") |> PrefixedName
