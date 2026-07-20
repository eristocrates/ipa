namespace https.w3id.org.tribont.core.hash

open DoxAletheia

module tribont_core =
    let _namespace_name = "https://w3id.org/tribont/core#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Qualifiable or quantifiable attribute, or characteristic of a body.
    /// <see href="https://w3id.org/tribont/core#BodyProperty"></see></summary>
    let BodyProperty = _prefix "BodyProperty"
    /// <summary>
    /// Qualifiable or quantifiable attribute, or characteristic of electrical behaviour of something.
    /// <see href="https://w3id.org/tribont/core#ElectricalProperty"></see></summary>
    let ElectricalProperty = _prefix "ElectricalProperty"
    /// <summary>
    /// Qualifiable or quantifiable attribute, or characteristic of mechanical behaviour of something.
    /// <see href="https://w3id.org/tribont/core#MechanicalProperty"></see></summary>
    let MechanicalProperty = _prefix "MechanicalProperty"
    /// <summary>
    /// Qualifiable or quantifiable physical attribute, or characteristic of a something.
    /// <see href="https://w3id.org/tribont/core#PhysicalProperty"></see></summary>
    let PhysicalProperty = _prefix "PhysicalProperty"
    /// <summary>
    /// Qualifiable or quantifiable  attribute, or characteristic of a surface. .
    /// <see href="https://w3id.org/tribont/core#SurfaceProperty"></see></summary>
    let SurfaceProperty = _prefix "SurfaceProperty"
    /// <summary>
    /// Qualifiable or quantifiable termal attribute, or characteristic of something.
    /// <see href="https://w3id.org/tribont/core#ThermalProperty"></see></summary>
    let ThermalProperty = _prefix "ThermalProperty"
    /// <summary>
    /// Qualifiable or quantifiable tribological attribute, or characteristic of something.
    /// <see href="https://w3id.org/tribont/core#TribologicalProperty"></see></summary>
    let TribologicalProperty = _prefix "TribologicalProperty"
    /// <summary>
    /// Axial load applied to something.
    /// <see href="https://w3id.org/tribont/core#AxialLoad"></see></summary>
    let AxialLoad = _prefix "AxialLoad"
    /// <summary>
    /// External force applied to something.
    /// <see href="https://w3id.org/tribont/core#ExternalForce"></see></summary>
    let ExternalForce = _prefix "ExternalForce"
    /// <summary>
    /// Friction torque applied to something.
    /// <see href="https://w3id.org/tribont/core#FrictionTorque"></see></summary>
    let FrictionTorque = _prefix "FrictionTorque"
    /// <summary>
    /// Load applied to something.
    /// <see href="https://w3id.org/tribont/core#Load"></see></summary>
    let Load = _prefix "Load"
    /// <summary>
    /// Load leverlratio of something.
    /// <see href="https://w3id.org/tribont/core#LoadLeverRatio"></see></summary>
    let LoadLeverRatio = _prefix "LoadLeverRatio"
    /// <summary>
    /// Load pressure applied to something.
    /// <see href="https://w3id.org/tribont/core#LoadPressure"></see></summary>
    let LoadPressure = _prefix "LoadPressure"
    /// <summary>
    /// Load rate applied to something.
    /// <see href="https://w3id.org/tribont/core#LoadRate"></see></summary>
    let LoadRate = _prefix "LoadRate"
    /// <summary>
    /// Torque applied to something.
    /// <see href="https://w3id.org/tribont/core#Torque"></see></summary>
    let Torque = _prefix "Torque"
    /// <summary>
    /// Arithmetical mean height of the absolute values.
    /// <see href="https://w3id.org/tribont/core#Ra"></see></summary>
    let Ra = _prefix "Ra"
    /// <summary>
    /// Core height.
    /// <see href="https://w3id.org/tribont/core#Rk"></see></summary>
    let Rk = _prefix "Rk"
    /// <summary>
    /// Kurtosis
    /// <see href="https://w3id.org/tribont/core#Rku"></see></summary>
    let Rku = _prefix "Rku"
    /// <summary>
    /// Material ratio of the reduced peak height
    /// <see href="https://w3id.org/tribont/core#Rmk1"></see></summary>
    let Rmk1 = _prefix "Rmk1"
    /// <summary>
    /// Material ratio of the reduced valley depth
    /// <see href="https://w3id.org/tribont/core#Rmk2"></see></summary>
    let Rmk2 = _prefix "Rmk2"
    /// <summary>
    /// Mean peak height.
    /// <see href="https://w3id.org/tribont/core#Rp"></see></summary>
    let Rp = _prefix "Rp"
    /// <summary>
    /// Reduced peak height
    /// <see href="https://w3id.org/tribont/core#Rpk"></see></summary>
    let Rpk = _prefix "Rpk"
    /// <summary>
    /// Reduced peak height along x
    /// <see href="https://w3id.org/tribont/core#Rpkx"></see></summary>
    let Rpkx = _prefix "Rpkx"
    /// <summary>
    /// Root mean square height
    /// <see href="https://w3id.org/tribont/core#Rq"></see></summary>
    let Rq = _prefix "Rq"
    /// <summary>
    /// Skewness
    /// <see href="https://w3id.org/tribont/core#Rsk"></see></summary>
    let Rsk = _prefix "Rsk"
    /// <summary>
    /// Total height
    /// <see href="https://w3id.org/tribont/core#Rt"></see></summary>
    let Rt = _prefix "Rt"
    /// <summary>
    /// Mean valley depth
    /// <see href="https://w3id.org/tribont/core#Rv"></see></summary>
    let Rv = _prefix "Rv"
    /// <summary>
    /// Maximum peak height
    /// <see href="https://w3id.org/tribont/core#Rvkx"></see></summary>
    let Rvkx = _prefix "Rvkx"
    /// <summary>
    /// Mean total height
    /// <see href="https://w3id.org/tribont/core#Rz"></see></summary>
    let Rz = _prefix "Rz"
    /// <summary>
    /// Arithmetical mean height
    /// <see href="https://w3id.org/tribont/core#Sa"></see></summary>
    let Sa = _prefix "Sa"
    /// <summary>
    /// Sdq.
    /// <see href="https://w3id.org/tribont/core#Sdq"></see></summary>
    let Sdq = _prefix "Sdq"
    /// <summary>
    /// Sdr.
    /// <see href="https://w3id.org/tribont/core#Sdr"></see></summary>
    let Sdr = _prefix "Sdr"
    /// <summary>
    /// Core height
    /// <see href="https://w3id.org/tribont/core#Sk"></see></summary>
    let Sk = _prefix "Sk"
    /// <summary>
    /// Kurtosis
    /// <see href="https://w3id.org/tribont/core#Sku"></see></summary>
    let Sku = _prefix "Sku"
    /// <summary>
    /// Material ratio of the hills
    /// <see href="https://w3id.org/tribont/core#Smk1"></see></summary>
    let Smk1 = _prefix "Smk1"
    /// <summary>
    /// Material ratio of the dales
    /// <see href="https://w3id.org/tribont/core#Smk2"></see></summary>
    let Smk2 = _prefix "Smk2"
    /// <summary>
    /// Maximum peak height
    /// <see href="https://w3id.org/tribont/core#Sp"></see></summary>
    let Sp = _prefix "Sp"
    /// <summary>
    /// Reduced peak height
    /// <see href="https://w3id.org/tribont/core#Spk"></see></summary>
    let Spk = _prefix "Spk"
    /// <summary>
    /// Maximum peak height
    /// <see href="https://w3id.org/tribont/core#Spkx"></see></summary>
    let Spkx = _prefix "Spkx"
    /// <summary>
    /// Root mean square height
    /// <see href="https://w3id.org/tribont/core#Sq"></see></summary>
    let Sq = _prefix "Sq"
    /// <summary>
    /// Skewness
    /// <see href="https://w3id.org/tribont/core#Ssk"></see></summary>
    let Ssk = _prefix "Ssk"
    /// <summary>
    /// Maximum valley depth
    /// <see href="https://w3id.org/tribont/core#Sv"></see></summary>
    let Sv = _prefix "Sv"
    /// <summary>
    /// Reduced valley depth
    /// <see href="https://w3id.org/tribont/core#Svk"></see></summary>
    let Svk = _prefix "Svk"
    /// <summary>
    /// Maximum valley depth
    /// <see href="https://w3id.org/tribont/core#Svkx"></see></summary>
    let Svkx = _prefix "Svkx"
    /// <summary>
    /// Maximum height z
    /// <see href="https://w3id.org/tribont/core#Sz"></see></summary>
    let Sz = _prefix "Sz"
    /// <summary>
    /// Core material volume
    /// <see href="https://w3id.org/tribont/core#Vmc"></see></summary>
    let Vmc = _prefix "Vmc"
    /// <summary>
    /// Peak material volume
    /// <see href="https://w3id.org/tribont/core#Vmp"></see></summary>
    let Vmp = _prefix "Vmp"
    /// <summary>
    /// Core void volume
    /// <see href="https://w3id.org/tribont/core#Vvc"></see></summary>
    let Vvc = _prefix "Vvc"
    /// <summary>
    /// Dale void volume
    /// <see href="https://w3id.org/tribont/core#Vvv"></see></summary>
    let Vvv = _prefix "Vvv"
    /// <summary>
    /// Diameter of something.
    /// <see href="https://w3id.org/tribont/core#Diameter"></see></summary>
    let Diameter = _prefix "Diameter"
    /// <summary>
    /// Height of something.
    /// <see href="https://w3id.org/tribont/core#Height"></see></summary>
    let Height = _prefix "Height"
    /// <summary>
    /// Length of something.
    /// <see href="https://w3id.org/tribont/core#Length"></see></summary>
    let Length = _prefix "Length"
    /// <summary>
    /// Height of a teeth. .
    /// <see href="https://w3id.org/tribont/core#TeethHeight"></see></summary>
    let TeethHeight = _prefix "TeethHeight"
    /// <summary>
    /// Length of a teeth. .
    /// <see href="https://w3id.org/tribont/core#TeethLength"></see></summary>
    let TeethLength = _prefix "TeethLength"
    /// <summary>
    /// Width of something.
    /// <see href="https://w3id.org/tribont/core#Width"></see></summary>
    let Width = _prefix "Width"
    /// <summary>
    /// Increase in speed or rate.
    /// <see href="https://w3id.org/tribont/core#Acceleration"></see></summary>
    let Acceleration = _prefix "Acceleration"
    /// <summary>
    /// Angular position of something.
    /// <see href="https://w3id.org/tribont/core#AngularPosition"></see></summary>
    let AngularPosition = _prefix "AngularPosition"
    /// <summary>
    /// Decrease in speed or rate.
    /// <see href="https://w3id.org/tribont/core#Decceleration"></see></summary>
    let Decceleration = _prefix "Decceleration"
    /// <summary>
    /// Frequency of something.
    /// <see href="https://w3id.org/tribont/core#Frequency"></see></summary>
    let Frequency = _prefix "Frequency"
    /// <summary>
    /// Linear speed of something.
    /// <see href="https://w3id.org/tribont/core#LinearSpeed"></see></summary>
    let LinearSpeed = _prefix "LinearSpeed"
    /// <summary>
    /// Normal force applied to something.
    /// <see href="https://w3id.org/tribont/core#NormalForce"></see></summary>
    let NormalForce = _prefix "NormalForce"
    /// <summary>
    /// Rotation speed of something.
    /// <see href="https://w3id.org/tribont/core#RotationSpeed"></see></summary>
    let RotationSpeed = _prefix "RotationSpeed"
    /// <summary>
    /// Sliding speed of something.
    /// <see href="https://w3id.org/tribont/core#SlidingSpeed"></see></summary>
    let SlidingSpeed = _prefix "SlidingSpeed"
    /// <summary>
    /// Slip percentage of something.
    /// <see href="https://w3id.org/tribont/core#SlipPercentage"></see></summary>
    let SlipPercentage = _prefix "SlipPercentage"
    /// <summary>
    /// Stroke amplitude.
    /// <see href="https://w3id.org/tribont/core#StrokeAmplitude"></see></summary>
    let StrokeAmplitude = _prefix "StrokeAmplitude"
    /// <summary>
    /// Stroke diameter.
    /// <see href="https://w3id.org/tribont/core#StrokeDiameter"></see></summary>
    let StrokeDiameter = _prefix "StrokeDiameter"
    /// <summary>
    /// Stroke length.
    /// <see href="https://w3id.org/tribont/core#StrokeLength"></see></summary>
    let StrokeLength = _prefix "StrokeLength"
    /// <summary>
    /// Velocity of something.
    /// <see href="https://w3id.org/tribont/core#Velocity"></see></summary>
    let Velocity = _prefix "Velocity"
    /// <summary>
    /// Measurement unit for derivative of velocity with respect to time.
    /// <see href="https://w3id.org/tribont/core#AccelerationUnit"></see></summary>
    let AccelerationUnit = _prefix "AccelerationUnit"
    /// <summary>
    /// Measurement unit for angle.
    /// <see href="https://w3id.org/tribont/core#AngleUnit"></see></summary>
    let AngleUnit = _prefix "AngleUnit"
    /// <summary>
    /// Measurement unit for capacity.
    /// <see href="https://w3id.org/tribont/core#CapacityUnit"></see></summary>
    let CapacityUnit = _prefix "CapacityUnit"
    /// <summary>
    /// Measurement unit for contents.
    /// <see href="https://w3id.org/tribont/core#ContentUnit"></see></summary>
    let ContentUnit = _prefix "ContentUnit"
    /// <summary>
    /// Measurement unit for density.
    /// <see href="https://w3id.org/tribont/core#DensityUnit"></see></summary>
    let DensityUnit = _prefix "DensityUnit"
    /// <summary>
    /// Measurement unit for distance.
    /// <see href="https://w3id.org/tribont/core#DistanceUnit"></see></summary>
    let DistanceUnit = _prefix "DistanceUnit"
    /// <summary>
    /// Measurement unit for expansion coefficient.
    /// <see href="https://w3id.org/tribont/core#ExpansionCOFUnit"></see></summary>
    let ExpansionCOFUnit = _prefix "ExpansionCOFUnit"
    /// <summary>
    /// Measurement unit for force.
    /// <see href="https://w3id.org/tribont/core#ForceUnit"></see></summary>
    let ForceUnit = _prefix "ForceUnit"
    /// <summary>
    /// Measurement unit for frequency.
    /// <see href="https://w3id.org/tribont/core#FrequencyUnit"></see></summary>
    let FrequencyUnit = _prefix "FrequencyUnit"
    /// <summary>
    /// Measurement unit for hardness.
    /// <see href="https://w3id.org/tribont/core#HardnessUnit"></see></summary>
    let HardnessUnit = _prefix "HardnessUnit"
    /// <summary>
    /// Measurement unit for heat capacity.
    /// <see href="https://w3id.org/tribont/core#HeatCapacityUnit"></see></summary>
    let HeatCapacityUnit = _prefix "HeatCapacityUnit"
    /// <summary>
    /// Measurement unit for load rate.
    /// <see href="https://w3id.org/tribont/core#LoadRateUnit"></see></summary>
    let LoadRateUnit = _prefix "LoadRateUnit"
    /// <summary>
    /// Measurement units for mechanizal properties.
    /// <see href="https://w3id.org/tribont/core#MechanicalUnit"></see></summary>
    let MechanicalUnit = _prefix "MechanicalUnit"
    /// <summary>
    /// Measurement unit for angle.
    /// <see href="https://w3id.org/tribont/core#PercentageUnit"></see></summary>
    let PercentageUnit = _prefix "PercentageUnit"
    /// <summary>
    /// Measurement unit for pressure.
    /// <see href="https://w3id.org/tribont/core#PressureUnit"></see></summary>
    let PressureUnit = _prefix "PressureUnit"
    /// <summary>
    /// Measurement unit for rotational speed.
    /// <see href="https://w3id.org/tribont/core#RotationSpeedUnit"></see></summary>
    let RotationSpeedUnit = _prefix "RotationSpeedUnit"
    /// <summary>
    /// Measurement unit for temperature.
    /// <see href="https://w3id.org/tribont/core#TemperatureUnit"></see></summary>
    let TemperatureUnit = _prefix "TemperatureUnit"
    /// <summary>
    /// Measurement unit for tendency.
    /// <see href="https://w3id.org/tribont/core#TendencyUnit"></see></summary>
    let TendencyUnit = _prefix "TendencyUnit"
    /// <summary>
    /// Measurement unit for tension.
    /// <see href="https://w3id.org/tribont/core#TensionUnit"></see></summary>
    let TensionUnit = _prefix "TensionUnit"
    /// <summary>
    /// Measurement unit for conductivity.
    /// <see href="https://w3id.org/tribont/core#ThermalConductivityUnit"></see></summary>
    let ThermalConductivityUnit = _prefix "ThermalConductivityUnit"
    /// <summary>
    /// Measurement unit for time.
    /// <see href="https://w3id.org/tribont/core#TimeUnit"></see></summary>
    let TimeUnit = _prefix "TimeUnit"
    /// <summary>
    /// Measurement unit for torque.
    /// <see href="https://w3id.org/tribont/core#TorqueUnit"></see></summary>
    let TorqueUnit = _prefix "TorqueUnit"
    /// <summary>
    /// Measurement unit for toughness.
    /// <see href="https://w3id.org/tribont/core#ToughnessUnit"></see></summary>
    let ToughnessUnit = _prefix "ToughnessUnit"
    /// <summary>
    /// Measurement unit for velocity.
    /// <see href="https://w3id.org/tribont/core#VelocityUnit"></see></summary>
    let VelocityUnit = _prefix "VelocityUnit"
    /// <summary>
    /// Measurement unit for viscosity.
    /// <see href="https://w3id.org/tribont/core#ViscosityUnit"></see></summary>
    let ViscosityUnit = _prefix "ViscosityUnit"
    /// <summary>
    /// Measurement unit for voltage.
    /// <see href="https://w3id.org/tribont/core#VoltageUnit"></see></summary>
    let VoltageUnit = _prefix "VoltageUnit"
    /// <summary>
    /// Measurement unit for weight.
    /// <see href="https://w3id.org/tribont/core#WeightUnit"></see></summary>
    let WeightUnit = _prefix "WeightUnit"
    /// <summary>
    /// Quantifiable attribute, or characteristic of the geometry of a body.
    /// <see href="https://w3id.org/tribont/core#GeometricDimension"></see></summary>
    let GeometricDimension = _prefix "GeometricDimension"
    /// <summary>
    /// The form or outline of something
    /// <see href="https://w3id.org/tribont/core#Shape"></see></summary>
    let Shape = _prefix "Shape"
    /// <summary>
    /// Volume of someting.
    /// <see href="https://w3id.org/tribont/core#Volume"></see></summary>
    let Volume = _prefix "Volume"
    /// <summary>
    /// Weight of something.
    /// <see href="https://w3id.org/tribont/core#Weight"></see></summary>
    let Weight = _prefix "Weight"
    /// <summary>
    /// Humidity of something.
    /// <see href="https://w3id.org/tribont/core#Humidity"></see></summary>
    let Humidity = _prefix "Humidity"
    /// <summary>
    /// Inclination of the camber where the test is carried out.
    /// <see href="https://w3id.org/tribont/core#Inclination"></see></summary>
    let Inclination = _prefix "Inclination"
    /// <summary>
    /// O2 level of something.
    /// <see href="https://w3id.org/tribont/core#O2Level"></see></summary>
    let O2Level = _prefix "O2Level"
    /// <summary>
    /// Ph level of something.
    /// <see href="https://w3id.org/tribont/core#PhLevel"></see></summary>
    let PhLevel = _prefix "PhLevel"
    /// <summary>
    /// Pressure applied to soemthing.
    /// <see href="https://w3id.org/tribont/core#Pressure"></see></summary>
    let Pressure = _prefix "Pressure"
    /// <summary>
    /// Radiation dosage applied to something.
    /// <see href="https://w3id.org/tribont/core#RadiationDosage"></see></summary>
    let RadiationDosage = _prefix "RadiationDosage"
    /// <summary>
    /// Temperature ofsomebody or something.
    /// <see href="https://w3id.org/tribont/core#Temperature"></see></summary>
    let Temperature = _prefix "Temperature"
    /// <summary>
    /// Compressive strength applied to something.
    /// <see href="https://w3id.org/tribont/core#CompressiveStrength"></see></summary>
    let CompressiveStrength = _prefix "CompressiveStrength"
    /// <summary>
    /// Flexural strength of something.
    /// <see href="https://w3id.org/tribont/core#FlexuralStrength"></see></summary>
    let FlexuralStrength = _prefix "FlexuralStrength"
    /// <summary>
    /// Fracture toughness of something.
    /// <see href="https://w3id.org/tribont/core#FractureToughness"></see></summary>
    let FractureToughness = _prefix "FractureToughness"
    /// <summary>
    /// Quantifiable attribute, or characteristic of the hardness of a body.
    /// <see href="https://w3id.org/tribont/core#HardnessProperty"></see></summary>
    let HardnessProperty = _prefix "HardnessProperty"
    /// <summary>
    /// Poissson ratio of something.
    /// <see href="https://w3id.org/tribont/core#PoisssonRatio"></see></summary>
    let PoisssonRatio = _prefix "PoisssonRatio"
    /// <summary>
    /// Tensile strength of something.
    /// <see href="https://w3id.org/tribont/core#TensileStrength"></see></summary>
    let TensileStrength = _prefix "TensileStrength"
    /// <summary>
    /// Weibull modulus of something.
    /// <see href="https://w3id.org/tribont/core#WeibullModulus"></see></summary>
    let WeibullModulus = _prefix "WeibullModulus"
    /// <summary>
    /// Yield strength of something.
    /// <see href="https://w3id.org/tribont/core#YieldStrength"></see></summary>
    let YieldStrength = _prefix "YieldStrength"
    /// <summary>
    /// Young modulus of something.
    /// <see href="https://w3id.org/tribont/core#YoungModulus"></see></summary>
    let YoungModulus = _prefix "YoungModulus"
    /// <summary>
    /// Maximun temperature of operation.
    /// <see href="https://w3id.org/tribont/core#MaximumServiceTemperature"></see></summary>
    let MaximumServiceTemperature = _prefix "MaximumServiceTemperature"
    /// <summary>
    /// Melting point  of something.
    /// <see href="https://w3id.org/tribont/core#MeltingPoint"></see></summary>
    let MeltingPoint = _prefix "MeltingPoint"
    /// <summary>
    /// Specific heat capacity
    /// <see href="https://w3id.org/tribont/core#SpecificHeatCapacity"></see></summary>
    let SpecificHeatCapacity = _prefix "SpecificHeatCapacity"
    /// <summary>
    /// Thermal conductivity of something.
    /// <see href="https://w3id.org/tribont/core#ThermalConductivity"></see></summary>
    let ThermalConductivity = _prefix "ThermalConductivity"
    /// <summary>
    /// Thermal expansion coefficient of something.
    /// <see href="https://w3id.org/tribont/core#ThermalExpansionCoefficient"></see></summary>
    let ThermalExpansionCoefficient = _prefix "ThermalExpansionCoefficient"
    /// <summary>
    /// Brinell hardness of something.
    /// <see href="https://w3id.org/tribont/core#HardnessBrinell"></see></summary>
    let HardnessBrinell = _prefix "HardnessBrinell"
    /// <summary>
    /// Knoop hardness of something.
    /// <see href="https://w3id.org/tribont/core#HardnessKnoop100g"></see></summary>
    let HardnessKnoop100g = _prefix "HardnessKnoop100g"
    /// <summary>
    /// RockwellB hardness of something .
    /// <see href="https://w3id.org/tribont/core#HardnessRockwellB"></see></summary>
    let HardnessRockwellB = _prefix "HardnessRockwellB"
    /// <summary>
    /// RockwellC hardness of something .
    /// <see href="https://w3id.org/tribont/core#HardnessRockwellC"></see></summary>
    let HardnessRockwellC = _prefix "HardnessRockwellC"
    /// <summary>
    /// RockwellM hardnes of somethings .
    /// <see href="https://w3id.org/tribont/core#HardnessRockwellM"></see></summary>
    let HardnessRockwellM = _prefix "HardnessRockwellM"
    /// <summary>
    /// RockwellR hardness of something .
    /// <see href="https://w3id.org/tribont/core#HardnessRockwellR"></see></summary>
    let HardnessRockwellR = _prefix "HardnessRockwellR"
    /// <summary>
    /// ShoreA hardness of something .
    /// <see href="https://w3id.org/tribont/core#HardnessShoreA"></see></summary>
    let HardnessShoreA = _prefix "HardnessShoreA"
    /// <summary>
    /// ShoreD hardness of something .
    /// <see href="https://w3id.org/tribont/core#HardnessShoreD"></see></summary>
    let HardnessShoreD = _prefix "HardnessShoreD"
    /// <summary>
    /// Vickers hardness of something .
    /// <see href="https://w3id.org/tribont/core#HardnessVickers"></see></summary>
    let HardnessVickers = _prefix "HardnessVickers"
    /// <summary>
    /// Indentation hardness micro.
    /// <see href="https://w3id.org/tribont/core#IndentationHardnessMicro"></see></summary>
    let IndentationHardnessMicro = _prefix "IndentationHardnessMicro"
    /// <summary>
    /// Indentation hardness nano.
    /// <see href="https://w3id.org/tribont/core#IndentationHardnessNano"></see></summary>
    let IndentationHardnessNano = _prefix "IndentationHardnessNano"
    /// <summary>
    /// Contact surface type (e.g. line, point,etc. .
    /// <see href="https://w3id.org/tribont/core#ContactSurfaceType"></see></summary>
    let ContactSurfaceType = _prefix "ContactSurfaceType"
    /// <summary>
    /// Geometrical combination of bodies belonging to a tribological system (e.g. ball on disc).
    /// <see href="https://w3id.org/tribont/core#GeometricalArrangement"></see></summary>
    let GeometricalArrangement = _prefix "GeometricalArrangement"
    /// <summary>
    /// Number of contact surfaces of something.
    /// <see href="https://w3id.org/tribont/core#NumberOfContactSurface"></see></summary>
    let NumberOfContactSurface = _prefix "NumberOfContactSurface"
    /// <summary>
    /// Quantifiable operation attribute, or characteristic of something.
    /// <see href="https://w3id.org/tribont/core#OperationProperty"></see></summary>
    let OperationProperty = _prefix "OperationProperty"
    /// <summary>
    /// Qualifiable or quantifiable  attribute, or characteristic of a sample system. .
    /// <see href="https://w3id.org/tribont/core#SystemProperty"></see></summary>
    let SystemProperty = _prefix "SystemProperty"
    /// <summary>
    /// Qualifiable or quantifiable technical attribute, or characteristic of something. .
    /// <see href="https://w3id.org/tribont/core#TechnicalProperty"></see></summary>
    let TechnicalProperty = _prefix "TechnicalProperty"
    /// <summary>
    /// Cloud point.
    /// <see href="https://w3id.org/tribont/core#CloudPoint"></see></summary>
    let CloudPoint = _prefix "CloudPoint"
    /// <summary>
    /// Cold filter plugging point.
    /// <see href="https://w3id.org/tribont/core#ColdFilterPluggingPoint"></see></summary>
    let ColdFilterPluggingPoint = _prefix "ColdFilterPluggingPoint"
    /// <summary>
    /// Flash point of something.
    /// <see href="https://w3id.org/tribont/core#FlashPoint"></see></summary>
    let FlashPoint = _prefix "FlashPoint"
    /// <summary>
    /// Pour point of something.
    /// <see href="https://w3id.org/tribont/core#PourPoint"></see></summary>
    let PourPoint = _prefix "PourPoint"
    /// <summary>
    /// Acid number of something.
    /// <see href="https://w3id.org/tribont/core#AcidNumberAN"></see></summary>
    let AcidNumberAN = _prefix "AcidNumberAN"
    /// <summary>
    /// Air release time for something.
    /// <see href="https://w3id.org/tribont/core#AirReleaseTimeLAV"></see></summary>
    let AirReleaseTimeLAV = _prefix "AirReleaseTimeLAV"
    /// <summary>
    /// Consumption of alkaline additives by something.
    /// <see href="https://w3id.org/tribont/core#AlkalineAdditivesConsumption"></see></summary>
    let AlkalineAdditivesConsumption = _prefix "AlkalineAdditivesConsumption"
    /// <summary>
    /// Colour index  of something.
    /// <see href="https://w3id.org/tribont/core#ColourIndex"></see></summary>
    let ColourIndex = _prefix "ColourIndex"
    /// <summary>
    /// Conductivity  of something.
    /// <see href="https://w3id.org/tribont/core#Conductivity"></see></summary>
    let Conductivity = _prefix "Conductivity"
    /// <summary>
    /// Coradson carbon residue in something .
    /// <see href="https://w3id.org/tribont/core#CoradsonCarbonResidue"></see></summary>
    let CoradsonCarbonResidue = _prefix "CoradsonCarbonResidue"
    /// <summary>
    /// Corrosion level of something.
    /// <see href="https://w3id.org/tribont/core#CorrosionLevel"></see></summary>
    let CorrosionLevel = _prefix "CorrosionLevel"
    /// <summary>
    /// Dispersancy of something.
    /// <see href="https://w3id.org/tribont/core#Dispersancy"></see></summary>
    let Dispersancy = _prefix "Dispersancy"
    /// <summary>
    /// Dissipation factor of something.
    /// <see href="https://w3id.org/tribont/core#DissipationFactor"></see></summary>
    let DissipationFactor = _prefix "DissipationFactor"
    /// <summary>
    /// Dynamic viscosity of something.
    /// <see href="https://w3id.org/tribont/core#DynamicViscosity"></see></summary>
    let DynamicViscosity = _prefix "DynamicViscosity"
    /// <summary>
    /// Electrical breakdown voltage of something.
    /// <see href="https://w3id.org/tribont/core#ElectricalBreakdownVoltage"></see></summary>
    let ElectricalBreakdownVoltage = _prefix "ElectricalBreakdownVoltage"
    /// <summary>
    /// Filterability of something.
    /// <see href="https://w3id.org/tribont/core#Filterability"></see></summary>
    let Filterability = _prefix "Filterability"
    /// <summary>
    /// Foaming tendency of something.
    /// <see href="https://w3id.org/tribont/core#FoamingTendency"></see></summary>
    let FoamingTendency = _prefix "FoamingTendency"

    /// <summary>
    /// Inhibited Hydraulic Fluids Oxidation Stability And Lubricating Oils For High Pressure Loads.
    /// <see href="https://w3id.org/tribont/core#InhibitedHydraulicFluidsOxidationStabilityAndLubricatingOilsForHighPressureLoads"></see></summary>
    let InhibitedHydraulicFluidsOxidationStabilityAndLubricatingOilsForHighPressureLoads =
        _prefix "InhibitedHydraulicFluidsOxidationStabilityAndLubricatingOilsForHighPressureLoads"

    /// <summary>
    /// Interfacial Tension Between Water Oil
    /// <see href="https://w3id.org/tribont/core#InterfacialTensionBetweenWaterOil"></see></summary>
    let InterfacialTensionBetweenWaterOil = _prefix "InterfacialTensionBetweenWaterOil"
    /// <summary>
    /// Kinematic viscosity of something.
    /// <see href="https://w3id.org/tribont/core#KinematicViscosity"></see></summary>
    let KinematicViscosity = _prefix "KinematicViscosity"
    /// <summary>
    /// Lodine number of something.
    /// <see href="https://w3id.org/tribont/core#LodineNumber"></see></summary>
    let LodineNumber = _prefix "LodineNumber"
    /// <summary>
    /// Lubricants oxidation stability.
    /// <see href="https://w3id.org/tribont/core#LubricantsOxidationStability"></see></summary>
    let LubricantsOxidationStability = _prefix "LubricantsOxidationStability"
    /// <summary>
    /// Neutralisation number of something.
    /// <see href="https://w3id.org/tribont/core#NeutralisationNumberNN"></see></summary>
    let NeutralisationNumberNN = _prefix "NeutralisationNumberNN"
    /// <summary>
    /// PQ index of something.
    /// <see href="https://w3id.org/tribont/core#PQIndex"></see></summary>
    let PQIndex = _prefix "PQIndex"
    /// <summary>
    /// Relative dielectric constant of something.
    /// <see href="https://w3id.org/tribont/core#RelativeDielectricConstant"></see></summary>
    let RelativeDielectricConstant = _prefix "RelativeDielectricConstant"

    /// <summary>
    /// Rust-Preventing Characteristic In Presence Of Water.
    /// <see href="https://w3id.org/tribont/core#Rust-PreventingCharacteristicInPresenceOfWater"></see></summary>
    let ``Rust-PreventingCharacteristicInPresenceOfWater`` =
        _prefix "Rust-PreventingCharacteristicInPresenceOfWater"

    /// <summary>
    /// Shear stability.
    /// <see href="https://w3id.org/tribont/core#ShearStability"></see></summary>
    let ShearStability = _prefix "ShearStability"
    /// <summary>
    /// i-phof something.
    /// <see href="https://w3id.org/tribont/core#i-ph"></see></summary>
    let ``i-ph`` = _prefix "i-ph"
    /// <summary>
    /// A company.
    /// <see href="https://w3id.org/tribont/core#Company"></see></summary>
    let Company = _prefix "Company"
    /// <summary>
    /// Any document.
    /// <see href="https://w3id.org/tribont/core#Document"></see></summary>
    let Document = _prefix "Document"
    /// <summary>
    /// The position or purpose that someone or something has in a situation, organization, society, or relationship:.
    /// <see href="https://w3id.org/tribont/core#Role"></see></summary>
    let Role = _prefix "Role"
    /// <summary>
    /// A reference point against which other things can be evaluated or compared.
    /// <see href="https://w3id.org/tribont/core#Standard"></see></summary>
    let Standard = _prefix "Standard"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#%C3%85"></see>
    /// </summary>
    let ``_%C3%85`` = _prefix "%C3%85"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ASTMD5706"></see>
    /// </summary>
    let ASTMD5706 = _prefix "ASTMD5706"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ASTMD5707"></see>
    /// </summary>
    let ASTMD5707 = _prefix "ASTMD5707"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ASTMD6425"></see>
    /// </summary>
    let ASTMD6425 = _prefix "ASTMD6425"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ASTMD7421"></see>
    /// </summary>
    let ASTMD7421 = _prefix "ASTMD7421"
    /// <summary>
    /// Qualifiable or quantifiable attribute, or characteristic of something's movement.
    /// <see href="https://w3id.org/tribont/core#MovementProperty"></see></summary>
    let MovementProperty = _prefix "MovementProperty"
    /// <summary>
    /// Qualifiable or quantifiable physical attribute, or characteristic of a liquid.
    /// <see href="https://w3id.org/tribont/core#LiquidPhysicalProperty"></see></summary>
    let LiquidPhysicalProperty = _prefix "LiquidPhysicalProperty"
    /// <summary>
    /// Qualifiable or quantifiable  attribute, or characteristic of load.
    /// <see href="https://w3id.org/tribont/core#LoadProperty"></see></summary>
    let LoadProperty = _prefix "LoadProperty"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#BTUhr.ft.degreeF"></see>
    /// </summary>
    let ``BTUhr.ft.degreeF`` = _prefix "BTUhr.ft.degreeF"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#BTUin2"></see>
    /// </summary>
    let BTUin2 = _prefix "BTUin2"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#BTUlb.degreeF"></see>
    /// </summary>
    let ``BTUlb.degreeF`` = _prefix "BTUlb.degreeF"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#Ba"></see>
    /// </summary>
    let Ba = _prefix "Ba"
    /// <summary>
    /// A body can be considered as an aggregate of particles to which it is possible to apply a force
    /// <see href="https://w3id.org/tribont/core#Body"></see></summary>
    let Body = _prefix "Body"
    /// <summary>
    /// Mean value of the coefficient of friction.
    /// <see href="https://w3id.org/tribont/core#COFMean"></see></summary>
    let COFMean = _prefix "COFMean"
    /// <summary>
    /// Qualifiable or quantifiable attribute, or characteristic of the friction between two or more bodies.
    /// <see href="https://w3id.org/tribont/core#FrictionProperty"></see></summary>
    let FrictionProperty = _prefix "FrictionProperty"
    /// <summary>
    /// Temperature of the chamber where the sample is tested.
    /// <see href="https://w3id.org/tribont/core#ChamberTemperature"></see></summary>
    let ChamberTemperature = _prefix "ChamberTemperature"
    /// <summary>
    /// Temperature of the sample body.
    /// <see href="https://w3id.org/tribont/core#SampleTemperature"></see></summary>
    let SampleTemperature = _prefix "SampleTemperature"
    /// <summary>
    /// Qualifiable or quantifiable thermal attribute, or characteristic of a liquid.
    /// <see href="https://w3id.org/tribont/core#LiquidThermalProperty"></see></summary>
    let LiquidThermalProperty = _prefix "LiquidThermalProperty"
    /// <summary>
    /// Short name of somebody or something.
    /// <see href="https://w3id.org/tribont/core#shortName"></see></summary>
    let shortName = _prefix "shortName"
    /// <summary>
    /// Name of somebody or something.
    /// <see href="https://w3id.org/tribont/core#name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#percentage"></see>
    /// </summary>
    let percentage = _prefix "percentage"
    /// <summary>
    /// Type of relative motion  between two or more bodies.
    /// <see href="https://w3id.org/tribont/core#CourseOfMovement"></see></summary>
    let CourseOfMovement = _prefix "CourseOfMovement"
    /// <summary>
    /// Density of something.
    /// <see href="https://w3id.org/tribont/core#Density"></see></summary>
    let Density = _prefix "Density"
    /// <summary>
    /// Qualifiable or quantifiable physical attribute, or characteristic of a solid.
    /// <see href="https://w3id.org/tribont/core#SolidPhysicalProperty"></see></summary>
    let SolidPhysicalProperty = _prefix "SolidPhysicalProperty"
    /// <summary>
    /// Porosity of something.
    /// <see href="https://w3id.org/tribont/core#Porosity"></see></summary>
    let Porosity = _prefix "Porosity"
    /// <summary>
    /// Amount of time during which an event persists.
    /// <see href="https://w3id.org/tribont/core#Duration"></see></summary>
    let Duration = _prefix "Duration"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#EHD"></see>
    /// </summary>
    let EHD = _prefix "EHD"
    /// <summary>
    /// Lubrication regime applied to a test or process .
    /// <see href="https://w3id.org/tribont/core#LubricationRegime"></see></summary>
    let LubricationRegime = _prefix "LubricationRegime"
    /// <summary>
    /// Electrical conductivity of something.
    /// <see href="https://w3id.org/tribont/core#ElectricalConductivity"></see></summary>
    let ElectricalConductivity = _prefix "ElectricalConductivity"
    /// <summary>
    /// Electrical resistivity of something.
    /// <see href="https://w3id.org/tribont/core#ElectricalResistivity"></see></summary>
    let ElectricalResistivity = _prefix "ElectricalResistivity"
    /// <summary>
    /// Environment medium surrounding something .
    /// <see href="https://w3id.org/tribont/core#EnvironmentMedium"></see></summary>
    let EnvironmentMedium = _prefix "EnvironmentMedium"
    /// <summary>
    /// Qualifiable or quantifiable attribute, or characteristic of the enviroment  in which a test has been / or should be carried out.
    /// <see href="https://w3id.org/tribont/core#EnvironmentProperty"></see></summary>
    let EnvironmentProperty = _prefix "EnvironmentProperty"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#HV"></see>
    /// </summary>
    let HV = _prefix "HV"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#Hz"></see>
    /// </summary>
    let Hz = _prefix "Hz"
    /// <summary>
    /// Inner diameter of something.
    /// <see href="https://w3id.org/tribont/core#InnerDiameter"></see></summary>
    let InnerDiameter = _prefix "InnerDiameter"
    /// <summary>
    /// Outer diameter.
    /// <see href="https://w3id.org/tribont/core#OuterDiameter"></see></summary>
    let OuterDiameter = _prefix "OuterDiameter"
    /// <summary>
    /// Inner teeth height of something.
    /// <see href="https://w3id.org/tribont/core#InnerTeethHeight"></see></summary>
    let InnerTeethHeight = _prefix "InnerTeethHeight"
    /// <summary>
    /// Outer teeth height of something.
    /// <see href="https://w3id.org/tribont/core#OuterTeethHeight"></see></summary>
    let OuterTeethHeight = _prefix "OuterTeethHeight"
    /// <summary>
    /// Inner teeth length of something.
    /// <see href="https://w3id.org/tribont/core#InnerTeethLength"></see></summary>
    let InnerTeethLength = _prefix "InnerTeethLength"
    /// <summary>
    /// Outer teeth length of something.
    /// <see href="https://w3id.org/tribont/core#OuterTeethLength"></see></summary>
    let OuterTeethLength = _prefix "OuterTeethLength"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#Jcm3"></see>
    /// </summary>
    let Jcm3 = _prefix "Jcm3"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#Jkg.degreeC"></see>
    /// </summary>
    let ``Jkg.degreeC`` = _prefix "Jkg.degreeC"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#Jm.s.degreeC"></see>
    /// </summary>
    let ``Jm.s.degreeC`` = _prefix "Jm.s.degreeC"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#Jm2"></see>
    /// </summary>
    let Jm2 = _prefix "Jm2"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#Jm3"></see>
    /// </summary>
    let Jm3 = _prefix "Jm3"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#Kgf"></see>
    /// </summary>
    let Kgf = _prefix "Kgf"
    /// <summary>
    /// A laboratory.
    /// <see href="https://w3id.org/tribont/core#Laboratory"></see></summary>
    let Laboratory = _prefix "Laboratory"
    /// <summary>
    /// Qualifiable or quantifiable thermal attribute, or characteristic of a solid.
    /// <see href="https://w3id.org/tribont/core#SolidThermalProperty"></see></summary>
    let SolidThermalProperty = _prefix "SolidThermalProperty"
    /// <summary>
    /// Lubricant type.
    /// <see href="https://w3id.org/tribont/core#LubricantType"></see></summary>
    let LubricantType = _prefix "LubricantType"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#MGO"></see>
    /// </summary>
    let MGO = _prefix "MGO"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#MJm2"></see>
    /// </summary>
    let MJm2 = _prefix "MJm2"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#MJm3"></see>
    /// </summary>
    let MJm3 = _prefix "MJm3"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#MPa"></see>
    /// </summary>
    let MPa = _prefix "MPa"
    /// <summary>
    /// MagnificationProperty applyed to something.
    /// <see href="https://w3id.org/tribont/core#MagnificationProperty"></see></summary>
    let MagnificationProperty = _prefix "MagnificationProperty"
    /// <summary>
    /// Maximun load before failure of the material.
    /// <see href="https://w3id.org/tribont/core#MaxLoadWithoutFailure"></see></summary>
    let MaxLoadWithoutFailure = _prefix "MaxLoadWithoutFailure"
    /// <summary>
    /// Type of movement appled to something.
    /// <see href="https://w3id.org/tribont/core#MovementType"></see></summary>
    let MovementType = _prefix "MovementType"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#N"></see>
    /// </summary>
    let N = _prefix "N"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#N.m"></see>
    /// </summary>
    let ``N.m`` = _prefix "N.m"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#N.mmg.degreeC"></see>
    /// </summary>
    let ``N.mmg.degreeC`` = _prefix "N.mmg.degreeC"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#N.mmmm2"></see>
    /// </summary>
    let ``N.mmmm2`` = _prefix "N.mmmm2"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#N.mmmm3"></see>
    /// </summary>
    let ``N.mmmm3`` = _prefix "N.mmmm3"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#N.mmms.mm.degreeC"></see>
    /// </summary>
    let ``N.mmms.mm.degreeC`` = _prefix "N.mmms.mm.degreeC"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#N.mmsmm.degreeC"></see>
    /// </summary>
    let ``N.mmsmm.degreeC`` = _prefix "N.mmsmm.degreeC"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#N.mmtonne.degreeC"></see>
    /// </summary>
    let ``N.mmtonne.degreeC`` = _prefix "N.mmtonne.degreeC"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#N2CO295"></see>
    /// </summary>
    let N2CO295 = _prefix "N2CO295"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#Nmm"></see>
    /// </summary>
    let Nmm = _prefix "Nmm"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#Nmm2"></see>
    /// </summary>
    let Nmm2 = _prefix "Nmm2"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#Ns"></see>
    /// </summary>
    let Ns = _prefix "Ns"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#Pa"></see>
    /// </summary>
    let Pa = _prefix "Pa"
    /// <summary>
    /// Polish grade of something.
    /// <see href="https://w3id.org/tribont/core#PolishGrade"></see></summary>
    let PolishGrade = _prefix "PolishGrade"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#microm"></see>
    /// </summary>
    let microm = _prefix "microm"
    /// <summary>
    /// Surface roughness. .
    /// <see href="https://w3id.org/tribont/core#SurfaceRoughness"></see></summary>
    let SurfaceRoughness = _prefix "SurfaceRoughness"
    /// <summary>
    /// Radiation type.
    /// <see href="https://w3id.org/tribont/core#RadiationType"></see></summary>
    let RadiationType = _prefix "RadiationType"
    /// <summary>
    /// Qualifiable or quantifiable wear attribute, or characteristic of something..
    /// <see href="https://w3id.org/tribont/core#WearProperty"></see></summary>
    let WearProperty = _prefix "WearProperty"
    /// <summary>
    ///  Length of wear scar..
    /// <see href="https://w3id.org/tribont/core#WearScarLength"></see></summary>
    let WearScarLength = _prefix "WearScarLength"
    /// <summary>
    ///  Qualifiable or quantifiable  attribute, or characteristic of a wear scar.
    /// <see href="https://w3id.org/tribont/core#WearScarProperty"></see></summary>
    let WearScarProperty = _prefix "WearScarProperty"
    /// <summary>
    ///  Volume of wear scar..
    /// <see href="https://w3id.org/tribont/core#WearScarVolume"></see></summary>
    let WearScarVolume = _prefix "WearScarVolume"
    /// <summary>
    /// Wear type of something.
    /// <see href="https://w3id.org/tribont/core#WearType"></see></summary>
    let WearType = _prefix "WearType"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#Wm.degreeC"></see>
    /// </summary>
    let ``Wm.degreeC`` = _prefix "Wm.degreeC"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#abrasive_wear"></see>
    /// </summary>
    let abrasive_wear = _prefix "abrasive_wear"
    /// <summary>
    /// Url to access a specific information content or document.
    /// <see href="https://w3id.org/tribont/core#accessUrl"></see></summary>
    let accessUrl = _prefix "accessUrl"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#adhesive_wear"></see>
    /// </summary>
    let adhesive_wear = _prefix "adhesive_wear"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ambient_air"></see>
    /// </summary>
    let ambient_air = _prefix "ambient_air"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ambient_humidity"></see>
    /// </summary>
    let ambient_humidity = _prefix "ambient_humidity"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ambient_pressure"></see>
    /// </summary>
    let ambient_pressure = _prefix "ambient_pressure"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#area"></see>
    /// </summary>
    let area = _prefix "area"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#atm"></see>
    /// </summary>
    let atm = _prefix "atm"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ball"></see>
    /// </summary>
    let ball = _prefix "ball"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ball_on_disc"></see>
    /// </summary>
    let ball_on_disc = _prefix "ball_on_disc"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ball_on_plate"></see>
    /// </summary>
    let ball_on_plate = _prefix "ball_on_plate"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#bar"></see>
    /// </summary>
    let bar = _prefix "bar"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#boundary_lubrication"></see>
    /// </summary>
    let boundary_lubrication = _prefix "boundary_lubrication"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#calg.degreeC"></see>
    /// </summary>
    let ``calg.degreeC`` = _prefix "calg.degreeC"
    /// <summary>
    /// Relationship between a specified operation property and the SubjectOfInterest it characterises  (e.g. equipemnt or test)..
    /// <see href="https://w3id.org/tribont/core#characterisesOperationCondition"></see></summary>
    let characterisesOperationCondition = _prefix "characterisesOperationCondition"

    /// <summary>
    /// Relationship between a  SubjectOfInterest it characterises  (e.g. equipemnt or test) and a specified operation property characterisig it..
    /// <see href="https://w3id.org/tribont/core#isCharacterisedByOperationCondition"></see></summary>
    let isCharacterisedByOperationCondition =
        _prefix "isCharacterisedByOperationCondition"

    /// <summary>
    /// Relationship between a measured operation property and the SubjectOfInterest it characterises  (e.g. equipemnt or test)..
    /// <see href="https://w3id.org/tribont/core#characterisesOperationMeasure"></see></summary>
    let characterisesOperationMeasure = _prefix "characterisesOperationMeasure"
    /// <summary>
    /// Relationship between a  SubjectOfInterest it characterises (e.g. equipemnt or test) and a measured operation property characterisig it..
    /// <see href="https://w3id.org/tribont/core#isCharacterisedByOperationMeasure"></see></summary>
    let isCharacterisedByOperationMeasure = _prefix "isCharacterisedByOperationMeasure"
    /// <summary>
    /// Relationship between a n output technical measure  and the SubjectOfInterest it characterises (e.g. equipemnt or test).
    /// <see href="https://w3id.org/tribont/core#characterisesOutputMeasure"></see></summary>
    let characterisesOutputMeasure = _prefix "characterisesOutputMeasure"
    /// <summary>
    /// Relationship between aSubjectOfInterest it characterises (e.g. equipemnt or test). and an output technical measurecgarcaterisg it.
    /// <see href="https://w3id.org/tribont/core#isCharacterisedByOutputMeasure"></see></summary>
    let isCharacterisedByOutputMeasure = _prefix "isCharacterisedByOutputMeasure"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#cm"></see>
    /// </summary>
    let cm = _prefix "cm"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#cm100m"></see>
    /// </summary>
    let cm100m = _prefix "cm100m"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#cm2s"></see>
    /// </summary>
    let cm2s = _prefix "cm2s"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#cm3"></see>
    /// </summary>
    let cm3 = _prefix "cm3"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#cmcm"></see>
    /// </summary>
    let cmcm = _prefix "cmcm"
    /// <summary>
    /// Relationship between something and the standard or procedure it complies with.
    /// <see href="https://w3id.org/tribont/core#compliesWith"></see></summary>
    let compliesWith = _prefix "compliesWith"
    /// <summary>
    /// Relationship between a standard or procedure and what it regulates or formalise.
    /// <see href="https://w3id.org/tribont/core#isCompliedBy"></see></summary>
    let isCompliedBy = _prefix "isCompliedBy"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#corrosive_gas"></see>
    /// </summary>
    let corrosive_gas = _prefix "corrosive_gas"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#cuboid"></see>
    /// </summary>
    let cuboid = _prefix "cuboid"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#cylinder"></see>
    /// </summary>
    let cylinder = _prefix "cylinder"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#day"></see>
    /// </summary>
    let day = _prefix "day"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#degree"></see>
    /// </summary>
    let degree = _prefix "degree"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#degreeC"></see>
    /// </summary>
    let degreeC = _prefix "degreeC"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#degreeF"></see>
    /// </summary>
    let degreeF = _prefix "degreeF"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#degreeK"></see>
    /// </summary>
    let degreeK = _prefix "degreeK"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#degreeR"></see>
    /// </summary>
    let degreeR = _prefix "degreeR"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#disc"></see>
    /// </summary>
    let disc = _prefix "disc"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#dm3"></see>
    /// </summary>
    let dm3 = _prefix "dm3"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#dry"></see>
    /// </summary>
    let dry = _prefix "dry"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#dyncm"></see>
    /// </summary>
    let dyncm = _prefix "dyncm"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#dyncm1.5"></see>
    /// </summary>
    let ``dyncm1.5`` = _prefix "dyncm1.5"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#dyncm2"></see>
    /// </summary>
    let dyncm2 = _prefix "dyncm2"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#e-4"></see>
    /// </summary>
    let ``e-4`` = _prefix "e-4"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ergcm2"></see>
    /// </summary>
    let ergcm2 = _prefix "ergcm2"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ergcm3"></see>
    /// </summary>
    let ergcm3 = _prefix "ergcm3"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ergg.degreeC"></see>
    /// </summary>
    let ``ergg.degreeC`` = _prefix "ergg.degreeC"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ergs.cm.degreeC"></see>
    /// </summary>
    let ``ergs.cm.degreeC`` = _prefix "ergs.cm.degreeC"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#fl-ozUk"></see>
    /// </summary>
    let ``fl-ozUk`` = _prefix "fl-ozUk"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#fl-ozUs"></see>
    /// </summary>
    let ``fl-ozUs`` = _prefix "fl-ozUs"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#fretting_wear"></see>
    /// </summary>
    let fretting_wear = _prefix "fretting_wear"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ft.lbfft2"></see>
    /// </summary>
    let ``ft.lbfft2`` = _prefix "ft.lbfft2"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ft.lbfft3"></see>
    /// </summary>
    let ``ft.lbfft3`` = _prefix "ft.lbfft3"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ft.lbfin2"></see>
    /// </summary>
    let ``ft.lbfin2`` = _prefix "ft.lbfin2"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ft.lbfin3"></see>
    /// </summary>
    let ``ft.lbfin3`` = _prefix "ft.lbfin3"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ft2hr"></see>
    /// </summary>
    let ft2hr = _prefix "ft2hr"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ft2s"></see>
    /// </summary>
    let ft2s = _prefix "ft2s"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ft3"></see>
    /// </summary>
    let ft3 = _prefix "ft3"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ftft"></see>
    /// </summary>
    let ftft = _prefix "ftft"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#g"></see>
    /// </summary>
    let g = _prefix "g"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#galUk"></see>
    /// </summary>
    let galUk = _prefix "galUk"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#galUs"></see>
    /// </summary>
    let galUs = _prefix "galUs"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#gcm3"></see>
    /// </summary>
    let gcm3 = _prefix "gcm3"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#gear"></see>
    /// </summary>
    let gear = _prefix "gear"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#gmm3"></see>
    /// </summary>
    let gmm3 = _prefix "gmm3"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#grease"></see>
    /// </summary>
    let grease = _prefix "grease"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#grinded"></see>
    /// </summary>
    let grinded = _prefix "grinded"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#h"></see>
    /// </summary>
    let h = _prefix "h"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#hPa"></see>
    /// </summary>
    let hPa = _prefix "hPa"
    /// <summary>
    /// Relationship between something and its related documents
    /// <see href="https://w3id.org/tribont/core#hasDocument"></see></summary>
    let hasDocument = _prefix "hasDocument"
    /// <summary>
    /// Relationship between a document and what it provides information about.
    /// <see href="https://w3id.org/tribont/core#isDocumentFor"></see></summary>
    let isDocumentFor = _prefix "isDocumentFor"
    /// <summary>
    /// Relationship between something and where it is located.
    /// <see href="https://w3id.org/tribont/core#hasLocation"></see></summary>
    let hasLocation = _prefix "hasLocation"
    /// <summary>
    /// Relationship between a physical location and  and something that is located there..
    /// <see href="https://w3id.org/tribont/core#isLocationFor"></see></summary>
    let isLocationFor = _prefix "isLocationFor"
    /// <summary>
    /// Relationship between something and the company producing it.
    /// <see href="https://w3id.org/tribont/core#hasManufacturer"></see></summary>
    let hasManufacturer = _prefix "hasManufacturer"
    /// <summary>
    /// Relationship between between a company and what it produces.
    /// <see href="https://w3id.org/tribont/core#isManufacturerFor"></see></summary>
    let isManufacturerFor = _prefix "isManufacturerFor"
    /// <summary>
    /// Relationship between something and the company that owns it.
    /// <see href="https://w3id.org/tribont/core#hasOwner"></see></summary>
    let hasOwner = _prefix "hasOwner"
    /// <summary>
    /// Relationship between an company and something it owns..
    /// <see href="https://w3id.org/tribont/core#isOwnerOf"></see></summary>
    let isOwnerOf = _prefix "isOwnerOf"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#hb"></see>
    /// </summary>
    let hb = _prefix "hb"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#hk"></see>
    /// </summary>
    let hk = _prefix "hk"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#hour"></see>
    /// </summary>
    let hour = _prefix "hour"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#hrb"></see>
    /// </summary>
    let hrb = _prefix "hrb"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#hrc"></see>
    /// </summary>
    let hrc = _prefix "hrc"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#hrm"></see>
    /// </summary>
    let hrm = _prefix "hrm"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#hrr"></see>
    /// </summary>
    let hrr = _prefix "hrr"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#hv"></see>
    /// </summary>
    let hv = _prefix "hv"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#in.lbfin2"></see>
    /// </summary>
    let ``in.lbfin2`` = _prefix "in.lbfin2"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#in.lbfin3"></see>
    /// </summary>
    let ``in.lbfin3`` = _prefix "in.lbfin3"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#in100ft"></see>
    /// </summary>
    let in100ft = _prefix "in100ft"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#in2s"></see>
    /// </summary>
    let in2s = _prefix "in2s"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#inHg"></see>
    /// </summary>
    let inHg = _prefix "inHg"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#inin"></see>
    /// </summary>
    let inin = _prefix "inin"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#inindegreeF"></see>
    /// </summary>
    let inindegreeF = _prefix "inindegreeF"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#innert_gas"></see>
    /// </summary>
    let innert_gas = _prefix "innert_gas"
    /// <summary>
    /// Relationship between something and its component parts.
    /// <see href="https://w3id.org/tribont/core#isMadeOf"></see></summary>
    let isMadeOf = _prefix "isMadeOf"
    /// <summary>
    /// Relationship between a component part and that of which it is a part.
    /// <see href="https://w3id.org/tribont/core#isPartOf"></see></summary>
    let isPartOf = _prefix "isPartOf"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#kHz"></see>
    /// </summary>
    let kHz = _prefix "kHz"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#kJkg.degreeC"></see>
    /// </summary>
    let ``kJkg.degreeC`` = _prefix "kJkg.degreeC"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#kJm2"></see>
    /// </summary>
    let kJm2 = _prefix "kJm2"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#kJm3"></see>
    /// </summary>
    let kJm3 = _prefix "kJm3"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#kNcm2"></see>
    /// </summary>
    let kNcm2 = _prefix "kNcm2"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#kNm"></see>
    /// </summary>
    let kNm = _prefix "kNm"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#kg"></see>
    /// </summary>
    let kg = _prefix "kg"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#kgfmm2"></see>
    /// </summary>
    let kgfmm2 = _prefix "kgfmm2"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#kgm3"></see>
    /// </summary>
    let kgm3 = _prefix "kgm3"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#kgmm3"></see>
    /// </summary>
    let kgmm3 = _prefix "kgmm3"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#km"></see>
    /// </summary>
    let km = _prefix "km"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ksi"></see>
    /// </summary>
    let ksi = _prefix "ksi"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ksi.in0.5"></see>
    /// </summary>
    let ``ksi.in0.5`` = _prefix "ksi.in0.5"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#kv"></see>
    /// </summary>
    let kv = _prefix "kv"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#lapped"></see>
    /// </summary>
    let lapped = _prefix "lapped"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#lbf.ftlb.degreeF"></see>
    /// </summary>
    let ``lbf.ftlb.degreeF`` = _prefix "lbf.ftlb.degreeF"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#lbf.ftslug.degreeF"></see>
    /// </summary>
    let ``lbf.ftslug.degreeF`` = _prefix "lbf.ftslug.degreeF"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#lbf.in.inlbf.s2.degreeF"></see>
    /// </summary>
    let ``lbf.in.inlbf.s2.degreeF`` = _prefix "lbf.in.inlbf.s2.degreeF"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#lbf.inlb.degreeF"></see>
    /// </summary>
    let ``lbf.inlb.degreeF`` = _prefix "lbf.inlb.degreeF"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#lbf.s2in.in3"></see>
    /// </summary>
    let ``lbf.s2in.in3`` = _prefix "lbf.s2in.in3"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#lbfft"></see>
    /// </summary>
    let lbfft = _prefix "lbfft"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#lbfft1.5"></see>
    /// </summary>
    let ``lbfft1.5`` = _prefix "lbfft1.5"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#lbfft2"></see>
    /// </summary>
    let lbfft2 = _prefix "lbfft2"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#lbfin"></see>
    /// </summary>
    let lbfin = _prefix "lbfin"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#lbfs.degreeF"></see>
    /// </summary>
    let ``lbfs.degreeF`` = _prefix "lbfs.degreeF"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#lbft3"></see>
    /// </summary>
    let lbft3 = _prefix "lbft3"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#lbin3"></see>
    /// </summary>
    let lbin3 = _prefix "lbin3"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#line"></see>
    /// </summary>
    let line = _prefix "line"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#linear_reciprocating"></see>
    /// </summary>
    let linear_reciprocating = _prefix "linear_reciprocating"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#linear_unidirectional"></see>
    /// </summary>
    let linear_unidirectional = _prefix "linear_unidirectional"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#liquid_lubricant"></see>
    /// </summary>
    let liquid_lubricant = _prefix "liquid_lubricant"
    /// <summary>
    /// long name of somebody or something.
    /// <see href="https://w3id.org/tribont/core#longName"></see></summary>
    let longName = _prefix "longName"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#m"></see>
    /// </summary>
    let m = _prefix "m"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#m2s"></see>
    /// </summary>
    let m2s = _prefix "m2s"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#m3"></see>
    /// </summary>
    let m3 = _prefix "m3"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#mNm"></see>
    /// </summary>
    let mNm = _prefix "mNm"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#mPa"></see>
    /// </summary>
    let mPa = _prefix "mPa"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#m_m"></see>
    /// </summary>
    let m_m = _prefix "m_m"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#mb"></see>
    /// </summary>
    let mb = _prefix "mb"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#mg"></see>
    /// </summary>
    let mg = _prefix "mg"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#mgm3"></see>
    /// </summary>
    let mgm3 = _prefix "mgm3"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#microHz"></see>
    /// </summary>
    let microHz = _prefix "microHz"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#microinche"></see>
    /// </summary>
    let microinche = _prefix "microinche"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#microm3"></see>
    /// </summary>
    let microm3 = _prefix "microm3"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#microstrain"></see>
    /// </summary>
    let microstrain = _prefix "microstrain"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#microstraindegreeC"></see>
    /// </summary>
    let microstraindegreeC = _prefix "microstraindegreeC"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#microstraindegreeF"></see>
    /// </summary>
    let microstraindegreeF = _prefix "microstraindegreeF"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#mile"></see>
    /// </summary>
    let mile = _prefix "mile"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#milisecond"></see>
    /// </summary>
    let milisecond = _prefix "milisecond"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#min"></see>
    /// </summary>
    let min = _prefix "min"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#minute"></see>
    /// </summary>
    let minute = _prefix "minute"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#mixed_lubrication"></see>
    /// </summary>
    let mixed_lubrication = _prefix "mixed_lubrication"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ml"></see>
    /// </summary>
    let ml = _prefix "ml"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#mlml"></see>
    /// </summary>
    let mlml = _prefix "mlml"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#mm"></see>
    /// </summary>
    let mm = _prefix "mm"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#mm2ms"></see>
    /// </summary>
    let mm2ms = _prefix "mm2ms"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#mm2s"></see>
    /// </summary>
    let mm2s = _prefix "mm2s"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#mm3"></see>
    /// </summary>
    let mm3 = _prefix "mm3"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#mmmm"></see>
    /// </summary>
    let mmmm = _prefix "mmmm"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#mms"></see>
    /// </summary>
    let mms = _prefix "mms"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#mpa.m0.5"></see>
    /// </summary>
    let ``mpa.m0.5`` = _prefix "mpa.m0.5"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#mpa.mm0.5"></see>
    /// </summary>
    let ``mpa.mm0.5`` = _prefix "mpa.mm0.5"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ms"></see>
    /// </summary>
    let ms = _prefix "ms"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#n103mbar"></see>
    /// </summary>
    let n103mbar = _prefix "n103mbar"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#n104straindegreeC"></see>
    /// </summary>
    let n104straindegreeC = _prefix "n104straindegreeC"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#n106m2s"></see>
    /// </summary>
    let n106m2s = _prefix "n106m2s"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#n106psi"></see>
    /// </summary>
    let n106psi = _prefix "n106psi"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#nitrogen"></see>
    /// </summary>
    let nitrogen = _prefix "nitrogen"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#nmile"></see>
    /// </summary>
    let nmile = _prefix "nmile"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#nmm1.5"></see>
    /// </summary>
    let ``nmm1.5`` = _prefix "nmm1.5"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#no_lubricant"></see>
    /// </summary>
    let no_lubricant = _prefix "no_lubricant"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#oil"></see>
    /// </summary>
    let oil = _prefix "oil"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#pa.m0.5"></see>
    /// </summary>
    let ``pa.m0.5`` = _prefix "pa.m0.5"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#percentagestraindegreeF"></see>
    /// </summary>
    let percentagestraindegreeF = _prefix "percentagestraindegreeF"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#percentangestraindegreeC"></see>
    /// </summary>
    let percentangestraindegreeC = _prefix "percentangestraindegreeC"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#pin"></see>
    /// </summary>
    let pin = _prefix "pin"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#pin_on_disc"></see>
    /// </summary>
    let pin_on_disc = _prefix "pin_on_disc"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#pintUk"></see>
    /// </summary>
    let pintUk = _prefix "pintUk"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#pintUs"></see>
    /// </summary>
    let pintUs = _prefix "pintUs"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#plate"></see>
    /// </summary>
    let plate = _prefix "plate"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#point"></see>
    /// </summary>
    let point = _prefix "point"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#polished"></see>
    /// </summary>
    let polished = _prefix "polished"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ppb"></see>
    /// </summary>
    let ppb = _prefix "ppb"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#psi"></see>
    /// </summary>
    let psi = _prefix "psi"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#psi.in0.5"></see>
    /// </summary>
    let ``psi.in0.5`` = _prefix "psi.in0.5"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#radian"></see>
    /// </summary>
    let radian = _prefix "radian"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ring"></see>
    /// </summary>
    let ring = _prefix "ring"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ring_on_cylinder"></see>
    /// </summary>
    let ring_on_cylinder = _prefix "ring_on_cylinder"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ring_on_disc"></see>
    /// </summary>
    let ring_on_disc = _prefix "ring_on_disc"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#rolling"></see>
    /// </summary>
    let rolling = _prefix "rolling"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#rotating_reciprocating"></see>
    /// </summary>
    let rotating_reciprocating = _prefix "rotating_reciprocating"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#rotating_unidirectional"></see>
    /// </summary>
    let rotating_unidirectional = _prefix "rotating_unidirectional"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#rpm"></see>
    /// </summary>
    let rpm = _prefix "rpm"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#seal"></see>
    /// </summary>
    let seal = _prefix "seal"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#seal_on_shaft"></see>
    /// </summary>
    let seal_on_shaft = _prefix "seal_on_shaft"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#second"></see>
    /// </summary>
    let second = _prefix "second"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#shaft"></see>
    /// </summary>
    let shaft = _prefix "shaft"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#sliding"></see>
    /// </summary>
    let sliding = _prefix "sliding"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#sliding_wear"></see>
    /// </summary>
    let sliding_wear = _prefix "sliding_wear"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#slip"></see>
    /// </summary>
    let slip = _prefix "slip"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#slip_rolling_wear"></see>
    /// </summary>
    let slip_rolling_wear = _prefix "slip_rolling_wear"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#slugft3"></see>
    /// </summary>
    let slugft3 = _prefix "slugft3"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#solid_friction"></see>
    /// </summary>
    let solid_friction = _prefix "solid_friction"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#solid_lubricant"></see>
    /// </summary>
    let solid_lubricant = _prefix "solid_lubricant"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#sonotrode"></see>
    /// </summary>
    let sonotrode = _prefix "sonotrode"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#sp-gr2323degreeC"></see>
    /// </summary>
    let ``sp-gr2323degreeC`` = _prefix "sp-gr2323degreeC"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#stick_slip"></see>
    /// </summary>
    let stick_slip = _prefix "stick_slip"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#strain"></see>
    /// </summary>
    let strain = _prefix "strain"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#strain_percentage"></see>
    /// </summary>
    let strain_percentage = _prefix "strain_percentage"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#straindegreeC"></see>
    /// </summary>
    let straindegreeC = _prefix "straindegreeC"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#straindegreeF"></see>
    /// </summary>
    let straindegreeF = _prefix "straindegreeF"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#synthetic_air"></see>
    /// </summary>
    let synthetic_air = _prefix "synthetic_air"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#tonin3"></see>
    /// </summary>
    let tonin3 = _prefix "tonin3"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#tonnemm3"></see>
    /// </summary>
    let tonnemm3 = _prefix "tonnemm3"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#torr"></see>
    /// </summary>
    let torr = _prefix "torr"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#tribocorrosive_wear"></see>
    /// </summary>
    let tribocorrosive_wear = _prefix "tribocorrosive_wear"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#v"></see>
    /// </summary>
    let v = _prefix "v"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#vacuum"></see>
    /// </summary>
    let vacuum = _prefix "vacuum"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#week"></see>
    /// </summary>
    let week = _prefix "week"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#wt_percentage"></see>
    /// </summary>
    let wt_percentage = _prefix "wt_percentage"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#yd"></see>
    /// </summary>
    let yd = _prefix "yd"
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#year"></see>
    /// </summary>
    let year = _prefix "year"
