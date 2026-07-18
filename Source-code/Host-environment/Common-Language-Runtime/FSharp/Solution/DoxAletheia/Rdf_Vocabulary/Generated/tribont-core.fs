namespace https.w3id.org.tribont.core.hash

open DoxAletheia.Rdf_Vocabulary

module tribont_core =
    let _namespace_name = "https://w3id.org/tribont/core#"

    /// <summary>
    /// Qualifiable or quantifiable attribute, or characteristic of a body.
    /// <see href="https://w3id.org/tribont/core#BodyProperty"></see></summary>
    let BodyProperty =
        Namespaced_IRI.parse _namespace_name "BodyProperty" |> NamespacedName

    /// <summary>
    /// Qualifiable or quantifiable attribute, or characteristic of electrical behaviour of something.
    /// <see href="https://w3id.org/tribont/core#ElectricalProperty"></see></summary>
    let ElectricalProperty =
        Namespaced_IRI.parse _namespace_name "ElectricalProperty" |> NamespacedName

    /// <summary>
    /// Qualifiable or quantifiable attribute, or characteristic of mechanical behaviour of something.
    /// <see href="https://w3id.org/tribont/core#MechanicalProperty"></see></summary>
    let MechanicalProperty =
        Namespaced_IRI.parse _namespace_name "MechanicalProperty" |> NamespacedName

    /// <summary>
    /// Qualifiable or quantifiable physical attribute, or characteristic of a something.
    /// <see href="https://w3id.org/tribont/core#PhysicalProperty"></see></summary>
    let PhysicalProperty =
        Namespaced_IRI.parse _namespace_name "PhysicalProperty" |> NamespacedName

    /// <summary>
    /// Qualifiable or quantifiable  attribute, or characteristic of a surface. .
    /// <see href="https://w3id.org/tribont/core#SurfaceProperty"></see></summary>
    let SurfaceProperty =
        Namespaced_IRI.parse _namespace_name "SurfaceProperty" |> NamespacedName

    /// <summary>
    /// Qualifiable or quantifiable termal attribute, or characteristic of something.
    /// <see href="https://w3id.org/tribont/core#ThermalProperty"></see></summary>
    let ThermalProperty =
        Namespaced_IRI.parse _namespace_name "ThermalProperty" |> NamespacedName

    /// <summary>
    /// Qualifiable or quantifiable tribological attribute, or characteristic of something.
    /// <see href="https://w3id.org/tribont/core#TribologicalProperty"></see></summary>
    let TribologicalProperty =
        Namespaced_IRI.parse _namespace_name "TribologicalProperty" |> NamespacedName

    /// <summary>
    /// Axial load applied to something.
    /// <see href="https://w3id.org/tribont/core#AxialLoad"></see></summary>
    let AxialLoad = Namespaced_IRI.parse _namespace_name "AxialLoad" |> NamespacedName

    /// <summary>
    /// External force applied to something.
    /// <see href="https://w3id.org/tribont/core#ExternalForce"></see></summary>
    let ExternalForce =
        Namespaced_IRI.parse _namespace_name "ExternalForce" |> NamespacedName

    /// <summary>
    /// Friction torque applied to something.
    /// <see href="https://w3id.org/tribont/core#FrictionTorque"></see></summary>
    let FrictionTorque =
        Namespaced_IRI.parse _namespace_name "FrictionTorque" |> NamespacedName

    /// <summary>
    /// Load applied to something.
    /// <see href="https://w3id.org/tribont/core#Load"></see></summary>
    let Load = Namespaced_IRI.parse _namespace_name "Load" |> NamespacedName

    /// <summary>
    /// Load leverlratio of something.
    /// <see href="https://w3id.org/tribont/core#LoadLeverRatio"></see></summary>
    let LoadLeverRatio =
        Namespaced_IRI.parse _namespace_name "LoadLeverRatio" |> NamespacedName

    /// <summary>
    /// Load pressure applied to something.
    /// <see href="https://w3id.org/tribont/core#LoadPressure"></see></summary>
    let LoadPressure =
        Namespaced_IRI.parse _namespace_name "LoadPressure" |> NamespacedName

    /// <summary>
    /// Load rate applied to something.
    /// <see href="https://w3id.org/tribont/core#LoadRate"></see></summary>
    let LoadRate = Namespaced_IRI.parse _namespace_name "LoadRate" |> NamespacedName
    /// <summary>
    /// Torque applied to something.
    /// <see href="https://w3id.org/tribont/core#Torque"></see></summary>
    let Torque = Namespaced_IRI.parse _namespace_name "Torque" |> NamespacedName
    /// <summary>
    /// Arithmetical mean height of the absolute values.
    /// <see href="https://w3id.org/tribont/core#Ra"></see></summary>
    let Ra = Namespaced_IRI.parse _namespace_name "Ra" |> NamespacedName
    /// <summary>
    /// Core height.
    /// <see href="https://w3id.org/tribont/core#Rk"></see></summary>
    let Rk = Namespaced_IRI.parse _namespace_name "Rk" |> NamespacedName
    /// <summary>
    /// Kurtosis
    /// <see href="https://w3id.org/tribont/core#Rku"></see></summary>
    let Rku = Namespaced_IRI.parse _namespace_name "Rku" |> NamespacedName
    /// <summary>
    /// Material ratio of the reduced peak height
    /// <see href="https://w3id.org/tribont/core#Rmk1"></see></summary>
    let Rmk1 = Namespaced_IRI.parse _namespace_name "Rmk1" |> NamespacedName
    /// <summary>
    /// Material ratio of the reduced valley depth
    /// <see href="https://w3id.org/tribont/core#Rmk2"></see></summary>
    let Rmk2 = Namespaced_IRI.parse _namespace_name "Rmk2" |> NamespacedName
    /// <summary>
    /// Mean peak height.
    /// <see href="https://w3id.org/tribont/core#Rp"></see></summary>
    let Rp = Namespaced_IRI.parse _namespace_name "Rp" |> NamespacedName
    /// <summary>
    /// Reduced peak height
    /// <see href="https://w3id.org/tribont/core#Rpk"></see></summary>
    let Rpk = Namespaced_IRI.parse _namespace_name "Rpk" |> NamespacedName
    /// <summary>
    /// Reduced peak height along x
    /// <see href="https://w3id.org/tribont/core#Rpkx"></see></summary>
    let Rpkx = Namespaced_IRI.parse _namespace_name "Rpkx" |> NamespacedName
    /// <summary>
    /// Root mean square height
    /// <see href="https://w3id.org/tribont/core#Rq"></see></summary>
    let Rq = Namespaced_IRI.parse _namespace_name "Rq" |> NamespacedName
    /// <summary>
    /// Skewness
    /// <see href="https://w3id.org/tribont/core#Rsk"></see></summary>
    let Rsk = Namespaced_IRI.parse _namespace_name "Rsk" |> NamespacedName
    /// <summary>
    /// Total height
    /// <see href="https://w3id.org/tribont/core#Rt"></see></summary>
    let Rt = Namespaced_IRI.parse _namespace_name "Rt" |> NamespacedName
    /// <summary>
    /// Mean valley depth
    /// <see href="https://w3id.org/tribont/core#Rv"></see></summary>
    let Rv = Namespaced_IRI.parse _namespace_name "Rv" |> NamespacedName
    /// <summary>
    /// Maximum peak height
    /// <see href="https://w3id.org/tribont/core#Rvkx"></see></summary>
    let Rvkx = Namespaced_IRI.parse _namespace_name "Rvkx" |> NamespacedName
    /// <summary>
    /// Mean total height
    /// <see href="https://w3id.org/tribont/core#Rz"></see></summary>
    let Rz = Namespaced_IRI.parse _namespace_name "Rz" |> NamespacedName
    /// <summary>
    /// Arithmetical mean height
    /// <see href="https://w3id.org/tribont/core#Sa"></see></summary>
    let Sa = Namespaced_IRI.parse _namespace_name "Sa" |> NamespacedName
    /// <summary>
    /// Sdq.
    /// <see href="https://w3id.org/tribont/core#Sdq"></see></summary>
    let Sdq = Namespaced_IRI.parse _namespace_name "Sdq" |> NamespacedName
    /// <summary>
    /// Sdr.
    /// <see href="https://w3id.org/tribont/core#Sdr"></see></summary>
    let Sdr = Namespaced_IRI.parse _namespace_name "Sdr" |> NamespacedName
    /// <summary>
    /// Core height
    /// <see href="https://w3id.org/tribont/core#Sk"></see></summary>
    let Sk = Namespaced_IRI.parse _namespace_name "Sk" |> NamespacedName
    /// <summary>
    /// Kurtosis
    /// <see href="https://w3id.org/tribont/core#Sku"></see></summary>
    let Sku = Namespaced_IRI.parse _namespace_name "Sku" |> NamespacedName
    /// <summary>
    /// Material ratio of the hills
    /// <see href="https://w3id.org/tribont/core#Smk1"></see></summary>
    let Smk1 = Namespaced_IRI.parse _namespace_name "Smk1" |> NamespacedName
    /// <summary>
    /// Material ratio of the dales
    /// <see href="https://w3id.org/tribont/core#Smk2"></see></summary>
    let Smk2 = Namespaced_IRI.parse _namespace_name "Smk2" |> NamespacedName
    /// <summary>
    /// Maximum peak height
    /// <see href="https://w3id.org/tribont/core#Sp"></see></summary>
    let Sp = Namespaced_IRI.parse _namespace_name "Sp" |> NamespacedName
    /// <summary>
    /// Reduced peak height
    /// <see href="https://w3id.org/tribont/core#Spk"></see></summary>
    let Spk = Namespaced_IRI.parse _namespace_name "Spk" |> NamespacedName
    /// <summary>
    /// Maximum peak height
    /// <see href="https://w3id.org/tribont/core#Spkx"></see></summary>
    let Spkx = Namespaced_IRI.parse _namespace_name "Spkx" |> NamespacedName
    /// <summary>
    /// Root mean square height
    /// <see href="https://w3id.org/tribont/core#Sq"></see></summary>
    let Sq = Namespaced_IRI.parse _namespace_name "Sq" |> NamespacedName
    /// <summary>
    /// Skewness
    /// <see href="https://w3id.org/tribont/core#Ssk"></see></summary>
    let Ssk = Namespaced_IRI.parse _namespace_name "Ssk" |> NamespacedName
    /// <summary>
    /// Maximum valley depth
    /// <see href="https://w3id.org/tribont/core#Sv"></see></summary>
    let Sv = Namespaced_IRI.parse _namespace_name "Sv" |> NamespacedName
    /// <summary>
    /// Reduced valley depth
    /// <see href="https://w3id.org/tribont/core#Svk"></see></summary>
    let Svk = Namespaced_IRI.parse _namespace_name "Svk" |> NamespacedName
    /// <summary>
    /// Maximum valley depth
    /// <see href="https://w3id.org/tribont/core#Svkx"></see></summary>
    let Svkx = Namespaced_IRI.parse _namespace_name "Svkx" |> NamespacedName
    /// <summary>
    /// Maximum height z
    /// <see href="https://w3id.org/tribont/core#Sz"></see></summary>
    let Sz = Namespaced_IRI.parse _namespace_name "Sz" |> NamespacedName
    /// <summary>
    /// Core material volume
    /// <see href="https://w3id.org/tribont/core#Vmc"></see></summary>
    let Vmc = Namespaced_IRI.parse _namespace_name "Vmc" |> NamespacedName
    /// <summary>
    /// Peak material volume
    /// <see href="https://w3id.org/tribont/core#Vmp"></see></summary>
    let Vmp = Namespaced_IRI.parse _namespace_name "Vmp" |> NamespacedName
    /// <summary>
    /// Core void volume
    /// <see href="https://w3id.org/tribont/core#Vvc"></see></summary>
    let Vvc = Namespaced_IRI.parse _namespace_name "Vvc" |> NamespacedName
    /// <summary>
    /// Dale void volume
    /// <see href="https://w3id.org/tribont/core#Vvv"></see></summary>
    let Vvv = Namespaced_IRI.parse _namespace_name "Vvv" |> NamespacedName
    /// <summary>
    /// Diameter of something.
    /// <see href="https://w3id.org/tribont/core#Diameter"></see></summary>
    let Diameter = Namespaced_IRI.parse _namespace_name "Diameter" |> NamespacedName
    /// <summary>
    /// Height of something.
    /// <see href="https://w3id.org/tribont/core#Height"></see></summary>
    let Height = Namespaced_IRI.parse _namespace_name "Height" |> NamespacedName
    /// <summary>
    /// Length of something.
    /// <see href="https://w3id.org/tribont/core#Length"></see></summary>
    let Length = Namespaced_IRI.parse _namespace_name "Length" |> NamespacedName

    /// <summary>
    /// Height of a teeth. .
    /// <see href="https://w3id.org/tribont/core#TeethHeight"></see></summary>
    let TeethHeight =
        Namespaced_IRI.parse _namespace_name "TeethHeight" |> NamespacedName

    /// <summary>
    /// Length of a teeth. .
    /// <see href="https://w3id.org/tribont/core#TeethLength"></see></summary>
    let TeethLength =
        Namespaced_IRI.parse _namespace_name "TeethLength" |> NamespacedName

    /// <summary>
    /// Width of something.
    /// <see href="https://w3id.org/tribont/core#Width"></see></summary>
    let Width = Namespaced_IRI.parse _namespace_name "Width" |> NamespacedName

    /// <summary>
    /// Increase in speed or rate.
    /// <see href="https://w3id.org/tribont/core#Acceleration"></see></summary>
    let Acceleration =
        Namespaced_IRI.parse _namespace_name "Acceleration" |> NamespacedName

    /// <summary>
    /// Angular position of something.
    /// <see href="https://w3id.org/tribont/core#AngularPosition"></see></summary>
    let AngularPosition =
        Namespaced_IRI.parse _namespace_name "AngularPosition" |> NamespacedName

    /// <summary>
    /// Decrease in speed or rate.
    /// <see href="https://w3id.org/tribont/core#Decceleration"></see></summary>
    let Decceleration =
        Namespaced_IRI.parse _namespace_name "Decceleration" |> NamespacedName

    /// <summary>
    /// Frequency of something.
    /// <see href="https://w3id.org/tribont/core#Frequency"></see></summary>
    let Frequency = Namespaced_IRI.parse _namespace_name "Frequency" |> NamespacedName

    /// <summary>
    /// Linear speed of something.
    /// <see href="https://w3id.org/tribont/core#LinearSpeed"></see></summary>
    let LinearSpeed =
        Namespaced_IRI.parse _namespace_name "LinearSpeed" |> NamespacedName

    /// <summary>
    /// Normal force applied to something.
    /// <see href="https://w3id.org/tribont/core#NormalForce"></see></summary>
    let NormalForce =
        Namespaced_IRI.parse _namespace_name "NormalForce" |> NamespacedName

    /// <summary>
    /// Rotation speed of something.
    /// <see href="https://w3id.org/tribont/core#RotationSpeed"></see></summary>
    let RotationSpeed =
        Namespaced_IRI.parse _namespace_name "RotationSpeed" |> NamespacedName

    /// <summary>
    /// Sliding speed of something.
    /// <see href="https://w3id.org/tribont/core#SlidingSpeed"></see></summary>
    let SlidingSpeed =
        Namespaced_IRI.parse _namespace_name "SlidingSpeed" |> NamespacedName

    /// <summary>
    /// Slip percentage of something.
    /// <see href="https://w3id.org/tribont/core#SlipPercentage"></see></summary>
    let SlipPercentage =
        Namespaced_IRI.parse _namespace_name "SlipPercentage" |> NamespacedName

    /// <summary>
    /// Stroke amplitude.
    /// <see href="https://w3id.org/tribont/core#StrokeAmplitude"></see></summary>
    let StrokeAmplitude =
        Namespaced_IRI.parse _namespace_name "StrokeAmplitude" |> NamespacedName

    /// <summary>
    /// Stroke diameter.
    /// <see href="https://w3id.org/tribont/core#StrokeDiameter"></see></summary>
    let StrokeDiameter =
        Namespaced_IRI.parse _namespace_name "StrokeDiameter" |> NamespacedName

    /// <summary>
    /// Stroke length.
    /// <see href="https://w3id.org/tribont/core#StrokeLength"></see></summary>
    let StrokeLength =
        Namespaced_IRI.parse _namespace_name "StrokeLength" |> NamespacedName

    /// <summary>
    /// Velocity of something.
    /// <see href="https://w3id.org/tribont/core#Velocity"></see></summary>
    let Velocity = Namespaced_IRI.parse _namespace_name "Velocity" |> NamespacedName

    /// <summary>
    /// Measurement unit for derivative of velocity with respect to time.
    /// <see href="https://w3id.org/tribont/core#AccelerationUnit"></see></summary>
    let AccelerationUnit =
        Namespaced_IRI.parse _namespace_name "AccelerationUnit" |> NamespacedName

    /// <summary>
    /// Measurement unit for angle.
    /// <see href="https://w3id.org/tribont/core#AngleUnit"></see></summary>
    let AngleUnit = Namespaced_IRI.parse _namespace_name "AngleUnit" |> NamespacedName

    /// <summary>
    /// Measurement unit for capacity.
    /// <see href="https://w3id.org/tribont/core#CapacityUnit"></see></summary>
    let CapacityUnit =
        Namespaced_IRI.parse _namespace_name "CapacityUnit" |> NamespacedName

    /// <summary>
    /// Measurement unit for contents.
    /// <see href="https://w3id.org/tribont/core#ContentUnit"></see></summary>
    let ContentUnit =
        Namespaced_IRI.parse _namespace_name "ContentUnit" |> NamespacedName

    /// <summary>
    /// Measurement unit for density.
    /// <see href="https://w3id.org/tribont/core#DensityUnit"></see></summary>
    let DensityUnit =
        Namespaced_IRI.parse _namespace_name "DensityUnit" |> NamespacedName

    /// <summary>
    /// Measurement unit for distance.
    /// <see href="https://w3id.org/tribont/core#DistanceUnit"></see></summary>
    let DistanceUnit =
        Namespaced_IRI.parse _namespace_name "DistanceUnit" |> NamespacedName

    /// <summary>
    /// Measurement unit for expansion coefficient.
    /// <see href="https://w3id.org/tribont/core#ExpansionCOFUnit"></see></summary>
    let ExpansionCOFUnit =
        Namespaced_IRI.parse _namespace_name "ExpansionCOFUnit" |> NamespacedName

    /// <summary>
    /// Measurement unit for force.
    /// <see href="https://w3id.org/tribont/core#ForceUnit"></see></summary>
    let ForceUnit = Namespaced_IRI.parse _namespace_name "ForceUnit" |> NamespacedName

    /// <summary>
    /// Measurement unit for frequency.
    /// <see href="https://w3id.org/tribont/core#FrequencyUnit"></see></summary>
    let FrequencyUnit =
        Namespaced_IRI.parse _namespace_name "FrequencyUnit" |> NamespacedName

    /// <summary>
    /// Measurement unit for hardness.
    /// <see href="https://w3id.org/tribont/core#HardnessUnit"></see></summary>
    let HardnessUnit =
        Namespaced_IRI.parse _namespace_name "HardnessUnit" |> NamespacedName

    /// <summary>
    /// Measurement unit for heat capacity.
    /// <see href="https://w3id.org/tribont/core#HeatCapacityUnit"></see></summary>
    let HeatCapacityUnit =
        Namespaced_IRI.parse _namespace_name "HeatCapacityUnit" |> NamespacedName

    /// <summary>
    /// Measurement unit for load rate.
    /// <see href="https://w3id.org/tribont/core#LoadRateUnit"></see></summary>
    let LoadRateUnit =
        Namespaced_IRI.parse _namespace_name "LoadRateUnit" |> NamespacedName

    /// <summary>
    /// Measurement units for mechanizal properties.
    /// <see href="https://w3id.org/tribont/core#MechanicalUnit"></see></summary>
    let MechanicalUnit =
        Namespaced_IRI.parse _namespace_name "MechanicalUnit" |> NamespacedName

    /// <summary>
    /// Measurement unit for angle.
    /// <see href="https://w3id.org/tribont/core#PercentageUnit"></see></summary>
    let PercentageUnit =
        Namespaced_IRI.parse _namespace_name "PercentageUnit" |> NamespacedName

    /// <summary>
    /// Measurement unit for pressure.
    /// <see href="https://w3id.org/tribont/core#PressureUnit"></see></summary>
    let PressureUnit =
        Namespaced_IRI.parse _namespace_name "PressureUnit" |> NamespacedName

    /// <summary>
    /// Measurement unit for rotational speed.
    /// <see href="https://w3id.org/tribont/core#RotationSpeedUnit"></see></summary>
    let RotationSpeedUnit =
        Namespaced_IRI.parse _namespace_name "RotationSpeedUnit" |> NamespacedName

    /// <summary>
    /// Measurement unit for temperature.
    /// <see href="https://w3id.org/tribont/core#TemperatureUnit"></see></summary>
    let TemperatureUnit =
        Namespaced_IRI.parse _namespace_name "TemperatureUnit" |> NamespacedName

    /// <summary>
    /// Measurement unit for tendency.
    /// <see href="https://w3id.org/tribont/core#TendencyUnit"></see></summary>
    let TendencyUnit =
        Namespaced_IRI.parse _namespace_name "TendencyUnit" |> NamespacedName

    /// <summary>
    /// Measurement unit for tension.
    /// <see href="https://w3id.org/tribont/core#TensionUnit"></see></summary>
    let TensionUnit =
        Namespaced_IRI.parse _namespace_name "TensionUnit" |> NamespacedName

    /// <summary>
    /// Measurement unit for conductivity.
    /// <see href="https://w3id.org/tribont/core#ThermalConductivityUnit"></see></summary>
    let ThermalConductivityUnit =
        Namespaced_IRI.parse _namespace_name "ThermalConductivityUnit" |> NamespacedName

    /// <summary>
    /// Measurement unit for time.
    /// <see href="https://w3id.org/tribont/core#TimeUnit"></see></summary>
    let TimeUnit = Namespaced_IRI.parse _namespace_name "TimeUnit" |> NamespacedName
    /// <summary>
    /// Measurement unit for torque.
    /// <see href="https://w3id.org/tribont/core#TorqueUnit"></see></summary>
    let TorqueUnit = Namespaced_IRI.parse _namespace_name "TorqueUnit" |> NamespacedName

    /// <summary>
    /// Measurement unit for toughness.
    /// <see href="https://w3id.org/tribont/core#ToughnessUnit"></see></summary>
    let ToughnessUnit =
        Namespaced_IRI.parse _namespace_name "ToughnessUnit" |> NamespacedName

    /// <summary>
    /// Measurement unit for velocity.
    /// <see href="https://w3id.org/tribont/core#VelocityUnit"></see></summary>
    let VelocityUnit =
        Namespaced_IRI.parse _namespace_name "VelocityUnit" |> NamespacedName

    /// <summary>
    /// Measurement unit for viscosity.
    /// <see href="https://w3id.org/tribont/core#ViscosityUnit"></see></summary>
    let ViscosityUnit =
        Namespaced_IRI.parse _namespace_name "ViscosityUnit" |> NamespacedName

    /// <summary>
    /// Measurement unit for voltage.
    /// <see href="https://w3id.org/tribont/core#VoltageUnit"></see></summary>
    let VoltageUnit =
        Namespaced_IRI.parse _namespace_name "VoltageUnit" |> NamespacedName

    /// <summary>
    /// Measurement unit for weight.
    /// <see href="https://w3id.org/tribont/core#WeightUnit"></see></summary>
    let WeightUnit = Namespaced_IRI.parse _namespace_name "WeightUnit" |> NamespacedName

    /// <summary>
    /// Quantifiable attribute, or characteristic of the geometry of a body.
    /// <see href="https://w3id.org/tribont/core#GeometricDimension"></see></summary>
    let GeometricDimension =
        Namespaced_IRI.parse _namespace_name "GeometricDimension" |> NamespacedName

    /// <summary>
    /// The form or outline of something
    /// <see href="https://w3id.org/tribont/core#Shape"></see></summary>
    let Shape = Namespaced_IRI.parse _namespace_name "Shape" |> NamespacedName
    /// <summary>
    /// Volume of someting.
    /// <see href="https://w3id.org/tribont/core#Volume"></see></summary>
    let Volume = Namespaced_IRI.parse _namespace_name "Volume" |> NamespacedName
    /// <summary>
    /// Weight of something.
    /// <see href="https://w3id.org/tribont/core#Weight"></see></summary>
    let Weight = Namespaced_IRI.parse _namespace_name "Weight" |> NamespacedName
    /// <summary>
    /// Humidity of something.
    /// <see href="https://w3id.org/tribont/core#Humidity"></see></summary>
    let Humidity = Namespaced_IRI.parse _namespace_name "Humidity" |> NamespacedName

    /// <summary>
    /// Inclination of the camber where the test is carried out.
    /// <see href="https://w3id.org/tribont/core#Inclination"></see></summary>
    let Inclination =
        Namespaced_IRI.parse _namespace_name "Inclination" |> NamespacedName

    /// <summary>
    /// O2 level of something.
    /// <see href="https://w3id.org/tribont/core#O2Level"></see></summary>
    let O2Level = Namespaced_IRI.parse _namespace_name "O2Level" |> NamespacedName
    /// <summary>
    /// Ph level of something.
    /// <see href="https://w3id.org/tribont/core#PhLevel"></see></summary>
    let PhLevel = Namespaced_IRI.parse _namespace_name "PhLevel" |> NamespacedName
    /// <summary>
    /// Pressure applied to soemthing.
    /// <see href="https://w3id.org/tribont/core#Pressure"></see></summary>
    let Pressure = Namespaced_IRI.parse _namespace_name "Pressure" |> NamespacedName

    /// <summary>
    /// Radiation dosage applied to something.
    /// <see href="https://w3id.org/tribont/core#RadiationDosage"></see></summary>
    let RadiationDosage =
        Namespaced_IRI.parse _namespace_name "RadiationDosage" |> NamespacedName

    /// <summary>
    /// Temperature ofsomebody or something.
    /// <see href="https://w3id.org/tribont/core#Temperature"></see></summary>
    let Temperature =
        Namespaced_IRI.parse _namespace_name "Temperature" |> NamespacedName

    /// <summary>
    /// Compressive strength applied to something.
    /// <see href="https://w3id.org/tribont/core#CompressiveStrength"></see></summary>
    let CompressiveStrength =
        Namespaced_IRI.parse _namespace_name "CompressiveStrength" |> NamespacedName

    /// <summary>
    /// Flexural strength of something.
    /// <see href="https://w3id.org/tribont/core#FlexuralStrength"></see></summary>
    let FlexuralStrength =
        Namespaced_IRI.parse _namespace_name "FlexuralStrength" |> NamespacedName

    /// <summary>
    /// Fracture toughness of something.
    /// <see href="https://w3id.org/tribont/core#FractureToughness"></see></summary>
    let FractureToughness =
        Namespaced_IRI.parse _namespace_name "FractureToughness" |> NamespacedName

    /// <summary>
    /// Quantifiable attribute, or characteristic of the hardness of a body.
    /// <see href="https://w3id.org/tribont/core#HardnessProperty"></see></summary>
    let HardnessProperty =
        Namespaced_IRI.parse _namespace_name "HardnessProperty" |> NamespacedName

    /// <summary>
    /// Poissson ratio of something.
    /// <see href="https://w3id.org/tribont/core#PoisssonRatio"></see></summary>
    let PoisssonRatio =
        Namespaced_IRI.parse _namespace_name "PoisssonRatio" |> NamespacedName

    /// <summary>
    /// Tensile strength of something.
    /// <see href="https://w3id.org/tribont/core#TensileStrength"></see></summary>
    let TensileStrength =
        Namespaced_IRI.parse _namespace_name "TensileStrength" |> NamespacedName

    /// <summary>
    /// Weibull modulus of something.
    /// <see href="https://w3id.org/tribont/core#WeibullModulus"></see></summary>
    let WeibullModulus =
        Namespaced_IRI.parse _namespace_name "WeibullModulus" |> NamespacedName

    /// <summary>
    /// Yield strength of something.
    /// <see href="https://w3id.org/tribont/core#YieldStrength"></see></summary>
    let YieldStrength =
        Namespaced_IRI.parse _namespace_name "YieldStrength" |> NamespacedName

    /// <summary>
    /// Young modulus of something.
    /// <see href="https://w3id.org/tribont/core#YoungModulus"></see></summary>
    let YoungModulus =
        Namespaced_IRI.parse _namespace_name "YoungModulus" |> NamespacedName

    /// <summary>
    /// Maximun temperature of operation.
    /// <see href="https://w3id.org/tribont/core#MaximumServiceTemperature"></see></summary>
    let MaximumServiceTemperature =
        Namespaced_IRI.parse _namespace_name "MaximumServiceTemperature" |> NamespacedName

    /// <summary>
    /// Melting point  of something.
    /// <see href="https://w3id.org/tribont/core#MeltingPoint"></see></summary>
    let MeltingPoint =
        Namespaced_IRI.parse _namespace_name "MeltingPoint" |> NamespacedName

    /// <summary>
    /// Specific heat capacity
    /// <see href="https://w3id.org/tribont/core#SpecificHeatCapacity"></see></summary>
    let SpecificHeatCapacity =
        Namespaced_IRI.parse _namespace_name "SpecificHeatCapacity" |> NamespacedName

    /// <summary>
    /// Thermal conductivity of something.
    /// <see href="https://w3id.org/tribont/core#ThermalConductivity"></see></summary>
    let ThermalConductivity =
        Namespaced_IRI.parse _namespace_name "ThermalConductivity" |> NamespacedName

    /// <summary>
    /// Thermal expansion coefficient of something.
    /// <see href="https://w3id.org/tribont/core#ThermalExpansionCoefficient"></see></summary>
    let ThermalExpansionCoefficient =
        Namespaced_IRI.parse _namespace_name "ThermalExpansionCoefficient" |> NamespacedName

    /// <summary>
    /// Brinell hardness of something.
    /// <see href="https://w3id.org/tribont/core#HardnessBrinell"></see></summary>
    let HardnessBrinell =
        Namespaced_IRI.parse _namespace_name "HardnessBrinell" |> NamespacedName

    /// <summary>
    /// Knoop hardness of something.
    /// <see href="https://w3id.org/tribont/core#HardnessKnoop100g"></see></summary>
    let HardnessKnoop100g =
        Namespaced_IRI.parse _namespace_name "HardnessKnoop100g" |> NamespacedName

    /// <summary>
    /// RockwellB hardness of something .
    /// <see href="https://w3id.org/tribont/core#HardnessRockwellB"></see></summary>
    let HardnessRockwellB =
        Namespaced_IRI.parse _namespace_name "HardnessRockwellB" |> NamespacedName

    /// <summary>
    /// RockwellC hardness of something .
    /// <see href="https://w3id.org/tribont/core#HardnessRockwellC"></see></summary>
    let HardnessRockwellC =
        Namespaced_IRI.parse _namespace_name "HardnessRockwellC" |> NamespacedName

    /// <summary>
    /// RockwellM hardnes of somethings .
    /// <see href="https://w3id.org/tribont/core#HardnessRockwellM"></see></summary>
    let HardnessRockwellM =
        Namespaced_IRI.parse _namespace_name "HardnessRockwellM" |> NamespacedName

    /// <summary>
    /// RockwellR hardness of something .
    /// <see href="https://w3id.org/tribont/core#HardnessRockwellR"></see></summary>
    let HardnessRockwellR =
        Namespaced_IRI.parse _namespace_name "HardnessRockwellR" |> NamespacedName

    /// <summary>
    /// ShoreA hardness of something .
    /// <see href="https://w3id.org/tribont/core#HardnessShoreA"></see></summary>
    let HardnessShoreA =
        Namespaced_IRI.parse _namespace_name "HardnessShoreA" |> NamespacedName

    /// <summary>
    /// ShoreD hardness of something .
    /// <see href="https://w3id.org/tribont/core#HardnessShoreD"></see></summary>
    let HardnessShoreD =
        Namespaced_IRI.parse _namespace_name "HardnessShoreD" |> NamespacedName

    /// <summary>
    /// Vickers hardness of something .
    /// <see href="https://w3id.org/tribont/core#HardnessVickers"></see></summary>
    let HardnessVickers =
        Namespaced_IRI.parse _namespace_name "HardnessVickers" |> NamespacedName

    /// <summary>
    /// Indentation hardness micro.
    /// <see href="https://w3id.org/tribont/core#IndentationHardnessMicro"></see></summary>
    let IndentationHardnessMicro =
        Namespaced_IRI.parse _namespace_name "IndentationHardnessMicro" |> NamespacedName

    /// <summary>
    /// Indentation hardness nano.
    /// <see href="https://w3id.org/tribont/core#IndentationHardnessNano"></see></summary>
    let IndentationHardnessNano =
        Namespaced_IRI.parse _namespace_name "IndentationHardnessNano" |> NamespacedName

    /// <summary>
    /// Contact surface type (e.g. line, point,etc. .
    /// <see href="https://w3id.org/tribont/core#ContactSurfaceType"></see></summary>
    let ContactSurfaceType =
        Namespaced_IRI.parse _namespace_name "ContactSurfaceType" |> NamespacedName

    /// <summary>
    /// Geometrical combination of bodies belonging to a tribological system (e.g. ball on disc).
    /// <see href="https://w3id.org/tribont/core#GeometricalArrangement"></see></summary>
    let GeometricalArrangement =
        Namespaced_IRI.parse _namespace_name "GeometricalArrangement" |> NamespacedName

    /// <summary>
    /// Number of contact surfaces of something.
    /// <see href="https://w3id.org/tribont/core#NumberOfContactSurface"></see></summary>
    let NumberOfContactSurface =
        Namespaced_IRI.parse _namespace_name "NumberOfContactSurface" |> NamespacedName

    /// <summary>
    /// Quantifiable operation attribute, or characteristic of something.
    /// <see href="https://w3id.org/tribont/core#OperationProperty"></see></summary>
    let OperationProperty =
        Namespaced_IRI.parse _namespace_name "OperationProperty" |> NamespacedName

    /// <summary>
    /// Qualifiable or quantifiable  attribute, or characteristic of a sample system. .
    /// <see href="https://w3id.org/tribont/core#SystemProperty"></see></summary>
    let SystemProperty =
        Namespaced_IRI.parse _namespace_name "SystemProperty" |> NamespacedName

    /// <summary>
    /// Qualifiable or quantifiable technical attribute, or characteristic of something. .
    /// <see href="https://w3id.org/tribont/core#TechnicalProperty"></see></summary>
    let TechnicalProperty =
        Namespaced_IRI.parse _namespace_name "TechnicalProperty" |> NamespacedName

    /// <summary>
    /// Cloud point.
    /// <see href="https://w3id.org/tribont/core#CloudPoint"></see></summary>
    let CloudPoint = Namespaced_IRI.parse _namespace_name "CloudPoint" |> NamespacedName

    /// <summary>
    /// Cold filter plugging point.
    /// <see href="https://w3id.org/tribont/core#ColdFilterPluggingPoint"></see></summary>
    let ColdFilterPluggingPoint =
        Namespaced_IRI.parse _namespace_name "ColdFilterPluggingPoint" |> NamespacedName

    /// <summary>
    /// Flash point of something.
    /// <see href="https://w3id.org/tribont/core#FlashPoint"></see></summary>
    let FlashPoint = Namespaced_IRI.parse _namespace_name "FlashPoint" |> NamespacedName
    /// <summary>
    /// Pour point of something.
    /// <see href="https://w3id.org/tribont/core#PourPoint"></see></summary>
    let PourPoint = Namespaced_IRI.parse _namespace_name "PourPoint" |> NamespacedName

    /// <summary>
    /// Acid number of something.
    /// <see href="https://w3id.org/tribont/core#AcidNumberAN"></see></summary>
    let AcidNumberAN =
        Namespaced_IRI.parse _namespace_name "AcidNumberAN" |> NamespacedName

    /// <summary>
    /// Air release time for something.
    /// <see href="https://w3id.org/tribont/core#AirReleaseTimeLAV"></see></summary>
    let AirReleaseTimeLAV =
        Namespaced_IRI.parse _namespace_name "AirReleaseTimeLAV" |> NamespacedName

    /// <summary>
    /// Consumption of alkaline additives by something.
    /// <see href="https://w3id.org/tribont/core#AlkalineAdditivesConsumption"></see></summary>
    let AlkalineAdditivesConsumption =
        Namespaced_IRI.parse _namespace_name "AlkalineAdditivesConsumption" |> NamespacedName

    /// <summary>
    /// Colour index  of something.
    /// <see href="https://w3id.org/tribont/core#ColourIndex"></see></summary>
    let ColourIndex =
        Namespaced_IRI.parse _namespace_name "ColourIndex" |> NamespacedName

    /// <summary>
    /// Conductivity  of something.
    /// <see href="https://w3id.org/tribont/core#Conductivity"></see></summary>
    let Conductivity =
        Namespaced_IRI.parse _namespace_name "Conductivity" |> NamespacedName

    /// <summary>
    /// Coradson carbon residue in something .
    /// <see href="https://w3id.org/tribont/core#CoradsonCarbonResidue"></see></summary>
    let CoradsonCarbonResidue =
        Namespaced_IRI.parse _namespace_name "CoradsonCarbonResidue" |> NamespacedName

    /// <summary>
    /// Corrosion level of something.
    /// <see href="https://w3id.org/tribont/core#CorrosionLevel"></see></summary>
    let CorrosionLevel =
        Namespaced_IRI.parse _namespace_name "CorrosionLevel" |> NamespacedName

    /// <summary>
    /// Dispersancy of something.
    /// <see href="https://w3id.org/tribont/core#Dispersancy"></see></summary>
    let Dispersancy =
        Namespaced_IRI.parse _namespace_name "Dispersancy" |> NamespacedName

    /// <summary>
    /// Dissipation factor of something.
    /// <see href="https://w3id.org/tribont/core#DissipationFactor"></see></summary>
    let DissipationFactor =
        Namespaced_IRI.parse _namespace_name "DissipationFactor" |> NamespacedName

    /// <summary>
    /// Dynamic viscosity of something.
    /// <see href="https://w3id.org/tribont/core#DynamicViscosity"></see></summary>
    let DynamicViscosity =
        Namespaced_IRI.parse _namespace_name "DynamicViscosity" |> NamespacedName

    /// <summary>
    /// Electrical breakdown voltage of something.
    /// <see href="https://w3id.org/tribont/core#ElectricalBreakdownVoltage"></see></summary>
    let ElectricalBreakdownVoltage =
        Namespaced_IRI.parse _namespace_name "ElectricalBreakdownVoltage" |> NamespacedName

    /// <summary>
    /// Filterability of something.
    /// <see href="https://w3id.org/tribont/core#Filterability"></see></summary>
    let Filterability =
        Namespaced_IRI.parse _namespace_name "Filterability" |> NamespacedName

    /// <summary>
    /// Foaming tendency of something.
    /// <see href="https://w3id.org/tribont/core#FoamingTendency"></see></summary>
    let FoamingTendency =
        Namespaced_IRI.parse _namespace_name "FoamingTendency" |> NamespacedName

    /// <summary>
    /// Inhibited Hydraulic Fluids Oxidation Stability And Lubricating Oils For High Pressure Loads.
    /// <see href="https://w3id.org/tribont/core#InhibitedHydraulicFluidsOxidationStabilityAndLubricatingOilsForHighPressureLoads"></see></summary>
    let InhibitedHydraulicFluidsOxidationStabilityAndLubricatingOilsForHighPressureLoads =
        Namespaced_IRI.parse _namespace_name "InhibitedHydraulicFluidsOxidationStabilityAndLubricatingOilsForHighPressureLoads" |> NamespacedName

    /// <summary>
    /// Interfacial Tension Between Water Oil
    /// <see href="https://w3id.org/tribont/core#InterfacialTensionBetweenWaterOil"></see></summary>
    let InterfacialTensionBetweenWaterOil =
        Namespaced_IRI.parse _namespace_name "InterfacialTensionBetweenWaterOil" |> NamespacedName

    /// <summary>
    /// Kinematic viscosity of something.
    /// <see href="https://w3id.org/tribont/core#KinematicViscosity"></see></summary>
    let KinematicViscosity =
        Namespaced_IRI.parse _namespace_name "KinematicViscosity" |> NamespacedName

    /// <summary>
    /// Lodine number of something.
    /// <see href="https://w3id.org/tribont/core#LodineNumber"></see></summary>
    let LodineNumber =
        Namespaced_IRI.parse _namespace_name "LodineNumber" |> NamespacedName

    /// <summary>
    /// Lubricants oxidation stability.
    /// <see href="https://w3id.org/tribont/core#LubricantsOxidationStability"></see></summary>
    let LubricantsOxidationStability =
        Namespaced_IRI.parse _namespace_name "LubricantsOxidationStability" |> NamespacedName

    /// <summary>
    /// Neutralisation number of something.
    /// <see href="https://w3id.org/tribont/core#NeutralisationNumberNN"></see></summary>
    let NeutralisationNumberNN =
        Namespaced_IRI.parse _namespace_name "NeutralisationNumberNN" |> NamespacedName

    /// <summary>
    /// PQ index of something.
    /// <see href="https://w3id.org/tribont/core#PQIndex"></see></summary>
    let PQIndex = Namespaced_IRI.parse _namespace_name "PQIndex" |> NamespacedName

    /// <summary>
    /// Relative dielectric constant of something.
    /// <see href="https://w3id.org/tribont/core#RelativeDielectricConstant"></see></summary>
    let RelativeDielectricConstant =
        Namespaced_IRI.parse _namespace_name "RelativeDielectricConstant" |> NamespacedName

    /// <summary>
    /// Rust-Preventing Characteristic In Presence Of Water.
    /// <see href="https://w3id.org/tribont/core#Rust-PreventingCharacteristicInPresenceOfWater"></see></summary>
    let ``Rust-PreventingCharacteristicInPresenceOfWater`` =
        Namespaced_IRI.parse _namespace_name "Rust-PreventingCharacteristicInPresenceOfWater" |> NamespacedName

    /// <summary>
    /// Shear stability.
    /// <see href="https://w3id.org/tribont/core#ShearStability"></see></summary>
    let ShearStability =
        Namespaced_IRI.parse _namespace_name "ShearStability" |> NamespacedName

    /// <summary>
    /// i-phof something.
    /// <see href="https://w3id.org/tribont/core#i-ph"></see></summary>
    let ``i-ph`` = Namespaced_IRI.parse _namespace_name "i-ph" |> NamespacedName
    /// <summary>
    /// A company.
    /// <see href="https://w3id.org/tribont/core#Company"></see></summary>
    let Company = Namespaced_IRI.parse _namespace_name "Company" |> NamespacedName
    /// <summary>
    /// Any document.
    /// <see href="https://w3id.org/tribont/core#Document"></see></summary>
    let Document = Namespaced_IRI.parse _namespace_name "Document" |> NamespacedName
    /// <summary>
    /// The position or purpose that someone or something has in a situation, organization, society, or relationship:.
    /// <see href="https://w3id.org/tribont/core#Role"></see></summary>
    let Role = Namespaced_IRI.parse _namespace_name "Role" |> NamespacedName
    /// <summary>
    /// A reference point against which other things can be evaluated or compared.
    /// <see href="https://w3id.org/tribont/core#Standard"></see></summary>
    let Standard = Namespaced_IRI.parse _namespace_name "Standard" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#%C3%85"></see>
    /// </summary>
    let ``_%C3%85`` = Namespaced_IRI.parse _namespace_name "%C3%85" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ASTMD5706"></see>
    /// </summary>
    let ASTMD5706 = Namespaced_IRI.parse _namespace_name "ASTMD5706" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ASTMD5707"></see>
    /// </summary>
    let ASTMD5707 = Namespaced_IRI.parse _namespace_name "ASTMD5707" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ASTMD6425"></see>
    /// </summary>
    let ASTMD6425 = Namespaced_IRI.parse _namespace_name "ASTMD6425" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ASTMD7421"></see>
    /// </summary>
    let ASTMD7421 = Namespaced_IRI.parse _namespace_name "ASTMD7421" |> NamespacedName

    /// <summary>
    /// Qualifiable or quantifiable attribute, or characteristic of something's movement.
    /// <see href="https://w3id.org/tribont/core#MovementProperty"></see></summary>
    let MovementProperty =
        Namespaced_IRI.parse _namespace_name "MovementProperty" |> NamespacedName

    /// <summary>
    /// Qualifiable or quantifiable physical attribute, or characteristic of a liquid.
    /// <see href="https://w3id.org/tribont/core#LiquidPhysicalProperty"></see></summary>
    let LiquidPhysicalProperty =
        Namespaced_IRI.parse _namespace_name "LiquidPhysicalProperty" |> NamespacedName

    /// <summary>
    /// Qualifiable or quantifiable  attribute, or characteristic of load.
    /// <see href="https://w3id.org/tribont/core#LoadProperty"></see></summary>
    let LoadProperty =
        Namespaced_IRI.parse _namespace_name "LoadProperty" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#BTUhr.ft.degreeF"></see>
    /// </summary>
    let ``BTUhr.ft.degreeF`` =
        Namespaced_IRI.parse _namespace_name "BTUhr.ft.degreeF" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#BTUin2"></see>
    /// </summary>
    let BTUin2 = Namespaced_IRI.parse _namespace_name "BTUin2" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#BTUlb.degreeF"></see>
    /// </summary>
    let ``BTUlb.degreeF`` =
        Namespaced_IRI.parse _namespace_name "BTUlb.degreeF" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#Ba"></see>
    /// </summary>
    let Ba = Namespaced_IRI.parse _namespace_name "Ba" |> NamespacedName
    /// <summary>
    /// A body can be considered as an aggregate of particles to which it is possible to apply a force
    /// <see href="https://w3id.org/tribont/core#Body"></see></summary>
    let Body = Namespaced_IRI.parse _namespace_name "Body" |> NamespacedName
    /// <summary>
    /// Mean value of the coefficient of friction.
    /// <see href="https://w3id.org/tribont/core#COFMean"></see></summary>
    let COFMean = Namespaced_IRI.parse _namespace_name "COFMean" |> NamespacedName

    /// <summary>
    /// Qualifiable or quantifiable attribute, or characteristic of the friction between two or more bodies.
    /// <see href="https://w3id.org/tribont/core#FrictionProperty"></see></summary>
    let FrictionProperty =
        Namespaced_IRI.parse _namespace_name "FrictionProperty" |> NamespacedName

    /// <summary>
    /// Temperature of the chamber where the sample is tested.
    /// <see href="https://w3id.org/tribont/core#ChamberTemperature"></see></summary>
    let ChamberTemperature =
        Namespaced_IRI.parse _namespace_name "ChamberTemperature" |> NamespacedName

    /// <summary>
    /// Temperature of the sample body.
    /// <see href="https://w3id.org/tribont/core#SampleTemperature"></see></summary>
    let SampleTemperature =
        Namespaced_IRI.parse _namespace_name "SampleTemperature" |> NamespacedName

    /// <summary>
    /// Qualifiable or quantifiable thermal attribute, or characteristic of a liquid.
    /// <see href="https://w3id.org/tribont/core#LiquidThermalProperty"></see></summary>
    let LiquidThermalProperty =
        Namespaced_IRI.parse _namespace_name "LiquidThermalProperty" |> NamespacedName

    /// <summary>
    /// Short name of somebody or something.
    /// <see href="https://w3id.org/tribont/core#shortName"></see></summary>
    let shortName = Namespaced_IRI.parse _namespace_name "shortName" |> NamespacedName
    /// <summary>
    /// Name of somebody or something.
    /// <see href="https://w3id.org/tribont/core#name"></see></summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#percentage"></see>
    /// </summary>
    let percentage = Namespaced_IRI.parse _namespace_name "percentage" |> NamespacedName

    /// <summary>
    /// Type of relative motion  between two or more bodies.
    /// <see href="https://w3id.org/tribont/core#CourseOfMovement"></see></summary>
    let CourseOfMovement =
        Namespaced_IRI.parse _namespace_name "CourseOfMovement" |> NamespacedName

    /// <summary>
    /// Density of something.
    /// <see href="https://w3id.org/tribont/core#Density"></see></summary>
    let Density = Namespaced_IRI.parse _namespace_name "Density" |> NamespacedName

    /// <summary>
    /// Qualifiable or quantifiable physical attribute, or characteristic of a solid.
    /// <see href="https://w3id.org/tribont/core#SolidPhysicalProperty"></see></summary>
    let SolidPhysicalProperty =
        Namespaced_IRI.parse _namespace_name "SolidPhysicalProperty" |> NamespacedName

    /// <summary>
    /// Porosity of something.
    /// <see href="https://w3id.org/tribont/core#Porosity"></see></summary>
    let Porosity = Namespaced_IRI.parse _namespace_name "Porosity" |> NamespacedName
    /// <summary>
    /// Amount of time during which an event persists.
    /// <see href="https://w3id.org/tribont/core#Duration"></see></summary>
    let Duration = Namespaced_IRI.parse _namespace_name "Duration" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#EHD"></see>
    /// </summary>
    let EHD = Namespaced_IRI.parse _namespace_name "EHD" |> NamespacedName

    /// <summary>
    /// Lubrication regime applied to a test or process .
    /// <see href="https://w3id.org/tribont/core#LubricationRegime"></see></summary>
    let LubricationRegime =
        Namespaced_IRI.parse _namespace_name "LubricationRegime" |> NamespacedName

    /// <summary>
    /// Electrical conductivity of something.
    /// <see href="https://w3id.org/tribont/core#ElectricalConductivity"></see></summary>
    let ElectricalConductivity =
        Namespaced_IRI.parse _namespace_name "ElectricalConductivity" |> NamespacedName

    /// <summary>
    /// Electrical resistivity of something.
    /// <see href="https://w3id.org/tribont/core#ElectricalResistivity"></see></summary>
    let ElectricalResistivity =
        Namespaced_IRI.parse _namespace_name "ElectricalResistivity" |> NamespacedName

    /// <summary>
    /// Environment medium surrounding something .
    /// <see href="https://w3id.org/tribont/core#EnvironmentMedium"></see></summary>
    let EnvironmentMedium =
        Namespaced_IRI.parse _namespace_name "EnvironmentMedium" |> NamespacedName

    /// <summary>
    /// Qualifiable or quantifiable attribute, or characteristic of the enviroment  in which a test has been / or should be carried out.
    /// <see href="https://w3id.org/tribont/core#EnvironmentProperty"></see></summary>
    let EnvironmentProperty =
        Namespaced_IRI.parse _namespace_name "EnvironmentProperty" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#HV"></see>
    /// </summary>
    let HV = Namespaced_IRI.parse _namespace_name "HV" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#Hz"></see>
    /// </summary>
    let Hz = Namespaced_IRI.parse _namespace_name "Hz" |> NamespacedName

    /// <summary>
    /// Inner diameter of something.
    /// <see href="https://w3id.org/tribont/core#InnerDiameter"></see></summary>
    let InnerDiameter =
        Namespaced_IRI.parse _namespace_name "InnerDiameter" |> NamespacedName

    /// <summary>
    /// Outer diameter.
    /// <see href="https://w3id.org/tribont/core#OuterDiameter"></see></summary>
    let OuterDiameter =
        Namespaced_IRI.parse _namespace_name "OuterDiameter" |> NamespacedName

    /// <summary>
    /// Inner teeth height of something.
    /// <see href="https://w3id.org/tribont/core#InnerTeethHeight"></see></summary>
    let InnerTeethHeight =
        Namespaced_IRI.parse _namespace_name "InnerTeethHeight" |> NamespacedName

    /// <summary>
    /// Outer teeth height of something.
    /// <see href="https://w3id.org/tribont/core#OuterTeethHeight"></see></summary>
    let OuterTeethHeight =
        Namespaced_IRI.parse _namespace_name "OuterTeethHeight" |> NamespacedName

    /// <summary>
    /// Inner teeth length of something.
    /// <see href="https://w3id.org/tribont/core#InnerTeethLength"></see></summary>
    let InnerTeethLength =
        Namespaced_IRI.parse _namespace_name "InnerTeethLength" |> NamespacedName

    /// <summary>
    /// Outer teeth length of something.
    /// <see href="https://w3id.org/tribont/core#OuterTeethLength"></see></summary>
    let OuterTeethLength =
        Namespaced_IRI.parse _namespace_name "OuterTeethLength" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#Jcm3"></see>
    /// </summary>
    let Jcm3 = Namespaced_IRI.parse _namespace_name "Jcm3" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#Jkg.degreeC"></see>
    /// </summary>
    let ``Jkg.degreeC`` =
        Namespaced_IRI.parse _namespace_name "Jkg.degreeC" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#Jm.s.degreeC"></see>
    /// </summary>
    let ``Jm.s.degreeC`` =
        Namespaced_IRI.parse _namespace_name "Jm.s.degreeC" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#Jm2"></see>
    /// </summary>
    let Jm2 = Namespaced_IRI.parse _namespace_name "Jm2" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#Jm3"></see>
    /// </summary>
    let Jm3 = Namespaced_IRI.parse _namespace_name "Jm3" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#Kgf"></see>
    /// </summary>
    let Kgf = Namespaced_IRI.parse _namespace_name "Kgf" |> NamespacedName
    /// <summary>
    /// A laboratory.
    /// <see href="https://w3id.org/tribont/core#Laboratory"></see></summary>
    let Laboratory = Namespaced_IRI.parse _namespace_name "Laboratory" |> NamespacedName

    /// <summary>
    /// Qualifiable or quantifiable thermal attribute, or characteristic of a solid.
    /// <see href="https://w3id.org/tribont/core#SolidThermalProperty"></see></summary>
    let SolidThermalProperty =
        Namespaced_IRI.parse _namespace_name "SolidThermalProperty" |> NamespacedName

    /// <summary>
    /// Lubricant type.
    /// <see href="https://w3id.org/tribont/core#LubricantType"></see></summary>
    let LubricantType =
        Namespaced_IRI.parse _namespace_name "LubricantType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#MGO"></see>
    /// </summary>
    let MGO = Namespaced_IRI.parse _namespace_name "MGO" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#MJm2"></see>
    /// </summary>
    let MJm2 = Namespaced_IRI.parse _namespace_name "MJm2" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#MJm3"></see>
    /// </summary>
    let MJm3 = Namespaced_IRI.parse _namespace_name "MJm3" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#MPa"></see>
    /// </summary>
    let MPa = Namespaced_IRI.parse _namespace_name "MPa" |> NamespacedName

    /// <summary>
    /// MagnificationProperty applyed to something.
    /// <see href="https://w3id.org/tribont/core#MagnificationProperty"></see></summary>
    let MagnificationProperty =
        Namespaced_IRI.parse _namespace_name "MagnificationProperty" |> NamespacedName

    /// <summary>
    /// Maximun load before failure of the material.
    /// <see href="https://w3id.org/tribont/core#MaxLoadWithoutFailure"></see></summary>
    let MaxLoadWithoutFailure =
        Namespaced_IRI.parse _namespace_name "MaxLoadWithoutFailure" |> NamespacedName

    /// <summary>
    /// Type of movement appled to something.
    /// <see href="https://w3id.org/tribont/core#MovementType"></see></summary>
    let MovementType =
        Namespaced_IRI.parse _namespace_name "MovementType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#N"></see>
    /// </summary>
    let N = Namespaced_IRI.parse _namespace_name "N" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#N.m"></see>
    /// </summary>
    let ``N.m`` = Namespaced_IRI.parse _namespace_name "N.m" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#N.mmg.degreeC"></see>
    /// </summary>
    let ``N.mmg.degreeC`` =
        Namespaced_IRI.parse _namespace_name "N.mmg.degreeC" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#N.mmmm2"></see>
    /// </summary>
    let ``N.mmmm2`` = Namespaced_IRI.parse _namespace_name "N.mmmm2" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#N.mmmm3"></see>
    /// </summary>
    let ``N.mmmm3`` = Namespaced_IRI.parse _namespace_name "N.mmmm3" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#N.mmms.mm.degreeC"></see>
    /// </summary>
    let ``N.mmms.mm.degreeC`` =
        Namespaced_IRI.parse _namespace_name "N.mmms.mm.degreeC" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#N.mmsmm.degreeC"></see>
    /// </summary>
    let ``N.mmsmm.degreeC`` =
        Namespaced_IRI.parse _namespace_name "N.mmsmm.degreeC" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#N.mmtonne.degreeC"></see>
    /// </summary>
    let ``N.mmtonne.degreeC`` =
        Namespaced_IRI.parse _namespace_name "N.mmtonne.degreeC" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#N2CO295"></see>
    /// </summary>
    let N2CO295 = Namespaced_IRI.parse _namespace_name "N2CO295" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#Nmm"></see>
    /// </summary>
    let Nmm = Namespaced_IRI.parse _namespace_name "Nmm" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#Nmm2"></see>
    /// </summary>
    let Nmm2 = Namespaced_IRI.parse _namespace_name "Nmm2" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#Ns"></see>
    /// </summary>
    let Ns = Namespaced_IRI.parse _namespace_name "Ns" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#Pa"></see>
    /// </summary>
    let Pa = Namespaced_IRI.parse _namespace_name "Pa" |> NamespacedName

    /// <summary>
    /// Polish grade of something.
    /// <see href="https://w3id.org/tribont/core#PolishGrade"></see></summary>
    let PolishGrade =
        Namespaced_IRI.parse _namespace_name "PolishGrade" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#microm"></see>
    /// </summary>
    let microm = Namespaced_IRI.parse _namespace_name "microm" |> NamespacedName

    /// <summary>
    /// Surface roughness. .
    /// <see href="https://w3id.org/tribont/core#SurfaceRoughness"></see></summary>
    let SurfaceRoughness =
        Namespaced_IRI.parse _namespace_name "SurfaceRoughness" |> NamespacedName

    /// <summary>
    /// Radiation type.
    /// <see href="https://w3id.org/tribont/core#RadiationType"></see></summary>
    let RadiationType =
        Namespaced_IRI.parse _namespace_name "RadiationType" |> NamespacedName

    /// <summary>
    /// Qualifiable or quantifiable wear attribute, or characteristic of something..
    /// <see href="https://w3id.org/tribont/core#WearProperty"></see></summary>
    let WearProperty =
        Namespaced_IRI.parse _namespace_name "WearProperty" |> NamespacedName

    /// <summary>
    ///  Length of wear scar..
    /// <see href="https://w3id.org/tribont/core#WearScarLength"></see></summary>
    let WearScarLength =
        Namespaced_IRI.parse _namespace_name "WearScarLength" |> NamespacedName

    /// <summary>
    ///  Qualifiable or quantifiable  attribute, or characteristic of a wear scar.
    /// <see href="https://w3id.org/tribont/core#WearScarProperty"></see></summary>
    let WearScarProperty =
        Namespaced_IRI.parse _namespace_name "WearScarProperty" |> NamespacedName

    /// <summary>
    ///  Volume of wear scar..
    /// <see href="https://w3id.org/tribont/core#WearScarVolume"></see></summary>
    let WearScarVolume =
        Namespaced_IRI.parse _namespace_name "WearScarVolume" |> NamespacedName

    /// <summary>
    /// Wear type of something.
    /// <see href="https://w3id.org/tribont/core#WearType"></see></summary>
    let WearType = Namespaced_IRI.parse _namespace_name "WearType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#Wm.degreeC"></see>
    /// </summary>
    let ``Wm.degreeC`` =
        Namespaced_IRI.parse _namespace_name "Wm.degreeC" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#abrasive_wear"></see>
    /// </summary>
    let abrasive_wear =
        Namespaced_IRI.parse _namespace_name "abrasive_wear" |> NamespacedName

    /// <summary>
    /// Url to access a specific information content or document.
    /// <see href="https://w3id.org/tribont/core#accessUrl"></see></summary>
    let accessUrl = Namespaced_IRI.parse _namespace_name "accessUrl" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#adhesive_wear"></see>
    /// </summary>
    let adhesive_wear =
        Namespaced_IRI.parse _namespace_name "adhesive_wear" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ambient_air"></see>
    /// </summary>
    let ambient_air =
        Namespaced_IRI.parse _namespace_name "ambient_air" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ambient_humidity"></see>
    /// </summary>
    let ambient_humidity =
        Namespaced_IRI.parse _namespace_name "ambient_humidity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ambient_pressure"></see>
    /// </summary>
    let ambient_pressure =
        Namespaced_IRI.parse _namespace_name "ambient_pressure" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#area"></see>
    /// </summary>
    let area = Namespaced_IRI.parse _namespace_name "area" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#atm"></see>
    /// </summary>
    let atm = Namespaced_IRI.parse _namespace_name "atm" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ball"></see>
    /// </summary>
    let ball = Namespaced_IRI.parse _namespace_name "ball" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ball_on_disc"></see>
    /// </summary>
    let ball_on_disc =
        Namespaced_IRI.parse _namespace_name "ball_on_disc" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ball_on_plate"></see>
    /// </summary>
    let ball_on_plate =
        Namespaced_IRI.parse _namespace_name "ball_on_plate" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#bar"></see>
    /// </summary>
    let bar = Namespaced_IRI.parse _namespace_name "bar" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#boundary_lubrication"></see>
    /// </summary>
    let boundary_lubrication =
        Namespaced_IRI.parse _namespace_name "boundary_lubrication" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#calg.degreeC"></see>
    /// </summary>
    let ``calg.degreeC`` =
        Namespaced_IRI.parse _namespace_name "calg.degreeC" |> NamespacedName

    /// <summary>
    /// Relationship between a specified operation property and the SubjectOfInterest it characterises  (e.g. equipemnt or test)..
    /// <see href="https://w3id.org/tribont/core#characterisesOperationCondition"></see></summary>
    let characterisesOperationCondition =
        Namespaced_IRI.parse _namespace_name "characterisesOperationCondition" |> NamespacedName

    /// <summary>
    /// Relationship between a  SubjectOfInterest it characterises  (e.g. equipemnt or test) and a specified operation property characterisig it..
    /// <see href="https://w3id.org/tribont/core#isCharacterisedByOperationCondition"></see></summary>
    let isCharacterisedByOperationCondition =
        Namespaced_IRI.parse _namespace_name "isCharacterisedByOperationCondition" |> NamespacedName

    /// <summary>
    /// Relationship between a measured operation property and the SubjectOfInterest it characterises  (e.g. equipemnt or test)..
    /// <see href="https://w3id.org/tribont/core#characterisesOperationMeasure"></see></summary>
    let characterisesOperationMeasure =
        Namespaced_IRI.parse _namespace_name "characterisesOperationMeasure" |> NamespacedName

    /// <summary>
    /// Relationship between a  SubjectOfInterest it characterises (e.g. equipemnt or test) and a measured operation property characterisig it..
    /// <see href="https://w3id.org/tribont/core#isCharacterisedByOperationMeasure"></see></summary>
    let isCharacterisedByOperationMeasure =
        Namespaced_IRI.parse _namespace_name "isCharacterisedByOperationMeasure" |> NamespacedName

    /// <summary>
    /// Relationship between a n output technical measure  and the SubjectOfInterest it characterises (e.g. equipemnt or test).
    /// <see href="https://w3id.org/tribont/core#characterisesOutputMeasure"></see></summary>
    let characterisesOutputMeasure =
        Namespaced_IRI.parse _namespace_name "characterisesOutputMeasure" |> NamespacedName

    /// <summary>
    /// Relationship between aSubjectOfInterest it characterises (e.g. equipemnt or test). and an output technical measurecgarcaterisg it.
    /// <see href="https://w3id.org/tribont/core#isCharacterisedByOutputMeasure"></see></summary>
    let isCharacterisedByOutputMeasure =
        Namespaced_IRI.parse _namespace_name "isCharacterisedByOutputMeasure" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#cm"></see>
    /// </summary>
    let cm = Namespaced_IRI.parse _namespace_name "cm" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#cm100m"></see>
    /// </summary>
    let cm100m = Namespaced_IRI.parse _namespace_name "cm100m" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#cm2s"></see>
    /// </summary>
    let cm2s = Namespaced_IRI.parse _namespace_name "cm2s" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#cm3"></see>
    /// </summary>
    let cm3 = Namespaced_IRI.parse _namespace_name "cm3" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#cmcm"></see>
    /// </summary>
    let cmcm = Namespaced_IRI.parse _namespace_name "cmcm" |> NamespacedName

    /// <summary>
    /// Relationship between something and the standard or procedure it complies with.
    /// <see href="https://w3id.org/tribont/core#compliesWith"></see></summary>
    let compliesWith =
        Namespaced_IRI.parse _namespace_name "compliesWith" |> NamespacedName

    /// <summary>
    /// Relationship between a standard or procedure and what it regulates or formalise.
    /// <see href="https://w3id.org/tribont/core#isCompliedBy"></see></summary>
    let isCompliedBy =
        Namespaced_IRI.parse _namespace_name "isCompliedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#corrosive_gas"></see>
    /// </summary>
    let corrosive_gas =
        Namespaced_IRI.parse _namespace_name "corrosive_gas" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#cuboid"></see>
    /// </summary>
    let cuboid = Namespaced_IRI.parse _namespace_name "cuboid" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#cylinder"></see>
    /// </summary>
    let cylinder = Namespaced_IRI.parse _namespace_name "cylinder" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#day"></see>
    /// </summary>
    let day = Namespaced_IRI.parse _namespace_name "day" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#degree"></see>
    /// </summary>
    let degree = Namespaced_IRI.parse _namespace_name "degree" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#degreeC"></see>
    /// </summary>
    let degreeC = Namespaced_IRI.parse _namespace_name "degreeC" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#degreeF"></see>
    /// </summary>
    let degreeF = Namespaced_IRI.parse _namespace_name "degreeF" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#degreeK"></see>
    /// </summary>
    let degreeK = Namespaced_IRI.parse _namespace_name "degreeK" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#degreeR"></see>
    /// </summary>
    let degreeR = Namespaced_IRI.parse _namespace_name "degreeR" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#disc"></see>
    /// </summary>
    let disc = Namespaced_IRI.parse _namespace_name "disc" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#dm3"></see>
    /// </summary>
    let dm3 = Namespaced_IRI.parse _namespace_name "dm3" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#dry"></see>
    /// </summary>
    let dry = Namespaced_IRI.parse _namespace_name "dry" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#dyncm"></see>
    /// </summary>
    let dyncm = Namespaced_IRI.parse _namespace_name "dyncm" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#dyncm1.5"></see>
    /// </summary>
    let ``dyncm1.5`` = Namespaced_IRI.parse _namespace_name "dyncm1.5" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#dyncm2"></see>
    /// </summary>
    let dyncm2 = Namespaced_IRI.parse _namespace_name "dyncm2" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#e-4"></see>
    /// </summary>
    let ``e-4`` = Namespaced_IRI.parse _namespace_name "e-4" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ergcm2"></see>
    /// </summary>
    let ergcm2 = Namespaced_IRI.parse _namespace_name "ergcm2" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ergcm3"></see>
    /// </summary>
    let ergcm3 = Namespaced_IRI.parse _namespace_name "ergcm3" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ergg.degreeC"></see>
    /// </summary>
    let ``ergg.degreeC`` =
        Namespaced_IRI.parse _namespace_name "ergg.degreeC" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ergs.cm.degreeC"></see>
    /// </summary>
    let ``ergs.cm.degreeC`` =
        Namespaced_IRI.parse _namespace_name "ergs.cm.degreeC" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#fl-ozUk"></see>
    /// </summary>
    let ``fl-ozUk`` = Namespaced_IRI.parse _namespace_name "fl-ozUk" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#fl-ozUs"></see>
    /// </summary>
    let ``fl-ozUs`` = Namespaced_IRI.parse _namespace_name "fl-ozUs" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#fretting_wear"></see>
    /// </summary>
    let fretting_wear =
        Namespaced_IRI.parse _namespace_name "fretting_wear" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ft.lbfft2"></see>
    /// </summary>
    let ``ft.lbfft2`` =
        Namespaced_IRI.parse _namespace_name "ft.lbfft2" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ft.lbfft3"></see>
    /// </summary>
    let ``ft.lbfft3`` =
        Namespaced_IRI.parse _namespace_name "ft.lbfft3" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ft.lbfin2"></see>
    /// </summary>
    let ``ft.lbfin2`` =
        Namespaced_IRI.parse _namespace_name "ft.lbfin2" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ft.lbfin3"></see>
    /// </summary>
    let ``ft.lbfin3`` =
        Namespaced_IRI.parse _namespace_name "ft.lbfin3" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ft2hr"></see>
    /// </summary>
    let ft2hr = Namespaced_IRI.parse _namespace_name "ft2hr" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ft2s"></see>
    /// </summary>
    let ft2s = Namespaced_IRI.parse _namespace_name "ft2s" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ft3"></see>
    /// </summary>
    let ft3 = Namespaced_IRI.parse _namespace_name "ft3" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ftft"></see>
    /// </summary>
    let ftft = Namespaced_IRI.parse _namespace_name "ftft" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#g"></see>
    /// </summary>
    let g = Namespaced_IRI.parse _namespace_name "g" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#galUk"></see>
    /// </summary>
    let galUk = Namespaced_IRI.parse _namespace_name "galUk" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#galUs"></see>
    /// </summary>
    let galUs = Namespaced_IRI.parse _namespace_name "galUs" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#gcm3"></see>
    /// </summary>
    let gcm3 = Namespaced_IRI.parse _namespace_name "gcm3" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#gear"></see>
    /// </summary>
    let gear = Namespaced_IRI.parse _namespace_name "gear" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#gmm3"></see>
    /// </summary>
    let gmm3 = Namespaced_IRI.parse _namespace_name "gmm3" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#grease"></see>
    /// </summary>
    let grease = Namespaced_IRI.parse _namespace_name "grease" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#grinded"></see>
    /// </summary>
    let grinded = Namespaced_IRI.parse _namespace_name "grinded" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#h"></see>
    /// </summary>
    let h = Namespaced_IRI.parse _namespace_name "h" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#hPa"></see>
    /// </summary>
    let hPa = Namespaced_IRI.parse _namespace_name "hPa" |> NamespacedName

    /// <summary>
    /// Relationship between something and its related documents
    /// <see href="https://w3id.org/tribont/core#hasDocument"></see></summary>
    let hasDocument =
        Namespaced_IRI.parse _namespace_name "hasDocument" |> NamespacedName

    /// <summary>
    /// Relationship between a document and what it provides information about.
    /// <see href="https://w3id.org/tribont/core#isDocumentFor"></see></summary>
    let isDocumentFor =
        Namespaced_IRI.parse _namespace_name "isDocumentFor" |> NamespacedName

    /// <summary>
    /// Relationship between something and where it is located.
    /// <see href="https://w3id.org/tribont/core#hasLocation"></see></summary>
    let hasLocation =
        Namespaced_IRI.parse _namespace_name "hasLocation" |> NamespacedName

    /// <summary>
    /// Relationship between a physical location and  and something that is located there..
    /// <see href="https://w3id.org/tribont/core#isLocationFor"></see></summary>
    let isLocationFor =
        Namespaced_IRI.parse _namespace_name "isLocationFor" |> NamespacedName

    /// <summary>
    /// Relationship between something and the company producing it.
    /// <see href="https://w3id.org/tribont/core#hasManufacturer"></see></summary>
    let hasManufacturer =
        Namespaced_IRI.parse _namespace_name "hasManufacturer" |> NamespacedName

    /// <summary>
    /// Relationship between between a company and what it produces.
    /// <see href="https://w3id.org/tribont/core#isManufacturerFor"></see></summary>
    let isManufacturerFor =
        Namespaced_IRI.parse _namespace_name "isManufacturerFor" |> NamespacedName

    /// <summary>
    /// Relationship between something and the company that owns it.
    /// <see href="https://w3id.org/tribont/core#hasOwner"></see></summary>
    let hasOwner = Namespaced_IRI.parse _namespace_name "hasOwner" |> NamespacedName
    /// <summary>
    /// Relationship between an company and something it owns..
    /// <see href="https://w3id.org/tribont/core#isOwnerOf"></see></summary>
    let isOwnerOf = Namespaced_IRI.parse _namespace_name "isOwnerOf" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#hb"></see>
    /// </summary>
    let hb = Namespaced_IRI.parse _namespace_name "hb" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#hk"></see>
    /// </summary>
    let hk = Namespaced_IRI.parse _namespace_name "hk" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#hour"></see>
    /// </summary>
    let hour = Namespaced_IRI.parse _namespace_name "hour" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#hrb"></see>
    /// </summary>
    let hrb = Namespaced_IRI.parse _namespace_name "hrb" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#hrc"></see>
    /// </summary>
    let hrc = Namespaced_IRI.parse _namespace_name "hrc" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#hrm"></see>
    /// </summary>
    let hrm = Namespaced_IRI.parse _namespace_name "hrm" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#hrr"></see>
    /// </summary>
    let hrr = Namespaced_IRI.parse _namespace_name "hrr" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#hv"></see>
    /// </summary>
    let hv = Namespaced_IRI.parse _namespace_name "hv" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#in.lbfin2"></see>
    /// </summary>
    let ``in.lbfin2`` =
        Namespaced_IRI.parse _namespace_name "in.lbfin2" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#in.lbfin3"></see>
    /// </summary>
    let ``in.lbfin3`` =
        Namespaced_IRI.parse _namespace_name "in.lbfin3" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#in100ft"></see>
    /// </summary>
    let in100ft = Namespaced_IRI.parse _namespace_name "in100ft" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#in2s"></see>
    /// </summary>
    let in2s = Namespaced_IRI.parse _namespace_name "in2s" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#inHg"></see>
    /// </summary>
    let inHg = Namespaced_IRI.parse _namespace_name "inHg" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#inin"></see>
    /// </summary>
    let inin = Namespaced_IRI.parse _namespace_name "inin" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#inindegreeF"></see>
    /// </summary>
    let inindegreeF =
        Namespaced_IRI.parse _namespace_name "inindegreeF" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#innert_gas"></see>
    /// </summary>
    let innert_gas = Namespaced_IRI.parse _namespace_name "innert_gas" |> NamespacedName
    /// <summary>
    /// Relationship between something and its component parts.
    /// <see href="https://w3id.org/tribont/core#isMadeOf"></see></summary>
    let isMadeOf = Namespaced_IRI.parse _namespace_name "isMadeOf" |> NamespacedName
    /// <summary>
    /// Relationship between a component part and that of which it is a part.
    /// <see href="https://w3id.org/tribont/core#isPartOf"></see></summary>
    let isPartOf = Namespaced_IRI.parse _namespace_name "isPartOf" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#kHz"></see>
    /// </summary>
    let kHz = Namespaced_IRI.parse _namespace_name "kHz" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#kJkg.degreeC"></see>
    /// </summary>
    let ``kJkg.degreeC`` =
        Namespaced_IRI.parse _namespace_name "kJkg.degreeC" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#kJm2"></see>
    /// </summary>
    let kJm2 = Namespaced_IRI.parse _namespace_name "kJm2" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#kJm3"></see>
    /// </summary>
    let kJm3 = Namespaced_IRI.parse _namespace_name "kJm3" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#kNcm2"></see>
    /// </summary>
    let kNcm2 = Namespaced_IRI.parse _namespace_name "kNcm2" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#kNm"></see>
    /// </summary>
    let kNm = Namespaced_IRI.parse _namespace_name "kNm" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#kg"></see>
    /// </summary>
    let kg = Namespaced_IRI.parse _namespace_name "kg" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#kgfmm2"></see>
    /// </summary>
    let kgfmm2 = Namespaced_IRI.parse _namespace_name "kgfmm2" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#kgm3"></see>
    /// </summary>
    let kgm3 = Namespaced_IRI.parse _namespace_name "kgm3" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#kgmm3"></see>
    /// </summary>
    let kgmm3 = Namespaced_IRI.parse _namespace_name "kgmm3" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#km"></see>
    /// </summary>
    let km = Namespaced_IRI.parse _namespace_name "km" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ksi"></see>
    /// </summary>
    let ksi = Namespaced_IRI.parse _namespace_name "ksi" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ksi.in0.5"></see>
    /// </summary>
    let ``ksi.in0.5`` =
        Namespaced_IRI.parse _namespace_name "ksi.in0.5" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#kv"></see>
    /// </summary>
    let kv = Namespaced_IRI.parse _namespace_name "kv" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#lapped"></see>
    /// </summary>
    let lapped = Namespaced_IRI.parse _namespace_name "lapped" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#lbf.ftlb.degreeF"></see>
    /// </summary>
    let ``lbf.ftlb.degreeF`` =
        Namespaced_IRI.parse _namespace_name "lbf.ftlb.degreeF" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#lbf.ftslug.degreeF"></see>
    /// </summary>
    let ``lbf.ftslug.degreeF`` =
        Namespaced_IRI.parse _namespace_name "lbf.ftslug.degreeF" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#lbf.in.inlbf.s2.degreeF"></see>
    /// </summary>
    let ``lbf.in.inlbf.s2.degreeF`` =
        Namespaced_IRI.parse _namespace_name "lbf.in.inlbf.s2.degreeF" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#lbf.inlb.degreeF"></see>
    /// </summary>
    let ``lbf.inlb.degreeF`` =
        Namespaced_IRI.parse _namespace_name "lbf.inlb.degreeF" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#lbf.s2in.in3"></see>
    /// </summary>
    let ``lbf.s2in.in3`` =
        Namespaced_IRI.parse _namespace_name "lbf.s2in.in3" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#lbfft"></see>
    /// </summary>
    let lbfft = Namespaced_IRI.parse _namespace_name "lbfft" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#lbfft1.5"></see>
    /// </summary>
    let ``lbfft1.5`` = Namespaced_IRI.parse _namespace_name "lbfft1.5" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#lbfft2"></see>
    /// </summary>
    let lbfft2 = Namespaced_IRI.parse _namespace_name "lbfft2" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#lbfin"></see>
    /// </summary>
    let lbfin = Namespaced_IRI.parse _namespace_name "lbfin" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#lbfs.degreeF"></see>
    /// </summary>
    let ``lbfs.degreeF`` =
        Namespaced_IRI.parse _namespace_name "lbfs.degreeF" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#lbft3"></see>
    /// </summary>
    let lbft3 = Namespaced_IRI.parse _namespace_name "lbft3" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#lbin3"></see>
    /// </summary>
    let lbin3 = Namespaced_IRI.parse _namespace_name "lbin3" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#line"></see>
    /// </summary>
    let line = Namespaced_IRI.parse _namespace_name "line" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#linear_reciprocating"></see>
    /// </summary>
    let linear_reciprocating =
        Namespaced_IRI.parse _namespace_name "linear_reciprocating" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#linear_unidirectional"></see>
    /// </summary>
    let linear_unidirectional =
        Namespaced_IRI.parse _namespace_name "linear_unidirectional" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#liquid_lubricant"></see>
    /// </summary>
    let liquid_lubricant =
        Namespaced_IRI.parse _namespace_name "liquid_lubricant" |> NamespacedName

    /// <summary>
    /// long name of somebody or something.
    /// <see href="https://w3id.org/tribont/core#longName"></see></summary>
    let longName = Namespaced_IRI.parse _namespace_name "longName" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#m"></see>
    /// </summary>
    let m = Namespaced_IRI.parse _namespace_name "m" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#m2s"></see>
    /// </summary>
    let m2s = Namespaced_IRI.parse _namespace_name "m2s" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#m3"></see>
    /// </summary>
    let m3 = Namespaced_IRI.parse _namespace_name "m3" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#mNm"></see>
    /// </summary>
    let mNm = Namespaced_IRI.parse _namespace_name "mNm" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#mPa"></see>
    /// </summary>
    let mPa = Namespaced_IRI.parse _namespace_name "mPa" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#m_m"></see>
    /// </summary>
    let m_m = Namespaced_IRI.parse _namespace_name "m_m" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#mb"></see>
    /// </summary>
    let mb = Namespaced_IRI.parse _namespace_name "mb" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#mg"></see>
    /// </summary>
    let mg = Namespaced_IRI.parse _namespace_name "mg" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#mgm3"></see>
    /// </summary>
    let mgm3 = Namespaced_IRI.parse _namespace_name "mgm3" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#microHz"></see>
    /// </summary>
    let microHz = Namespaced_IRI.parse _namespace_name "microHz" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#microinche"></see>
    /// </summary>
    let microinche = Namespaced_IRI.parse _namespace_name "microinche" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#microm3"></see>
    /// </summary>
    let microm3 = Namespaced_IRI.parse _namespace_name "microm3" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#microstrain"></see>
    /// </summary>
    let microstrain =
        Namespaced_IRI.parse _namespace_name "microstrain" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#microstraindegreeC"></see>
    /// </summary>
    let microstraindegreeC =
        Namespaced_IRI.parse _namespace_name "microstraindegreeC" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#microstraindegreeF"></see>
    /// </summary>
    let microstraindegreeF =
        Namespaced_IRI.parse _namespace_name "microstraindegreeF" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#mile"></see>
    /// </summary>
    let mile = Namespaced_IRI.parse _namespace_name "mile" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#milisecond"></see>
    /// </summary>
    let milisecond = Namespaced_IRI.parse _namespace_name "milisecond" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#min"></see>
    /// </summary>
    let min = Namespaced_IRI.parse _namespace_name "min" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#minute"></see>
    /// </summary>
    let minute = Namespaced_IRI.parse _namespace_name "minute" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#mixed_lubrication"></see>
    /// </summary>
    let mixed_lubrication =
        Namespaced_IRI.parse _namespace_name "mixed_lubrication" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ml"></see>
    /// </summary>
    let ml = Namespaced_IRI.parse _namespace_name "ml" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#mlml"></see>
    /// </summary>
    let mlml = Namespaced_IRI.parse _namespace_name "mlml" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#mm"></see>
    /// </summary>
    let mm = Namespaced_IRI.parse _namespace_name "mm" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#mm2ms"></see>
    /// </summary>
    let mm2ms = Namespaced_IRI.parse _namespace_name "mm2ms" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#mm2s"></see>
    /// </summary>
    let mm2s = Namespaced_IRI.parse _namespace_name "mm2s" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#mm3"></see>
    /// </summary>
    let mm3 = Namespaced_IRI.parse _namespace_name "mm3" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#mmmm"></see>
    /// </summary>
    let mmmm = Namespaced_IRI.parse _namespace_name "mmmm" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#mms"></see>
    /// </summary>
    let mms = Namespaced_IRI.parse _namespace_name "mms" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#mpa.m0.5"></see>
    /// </summary>
    let ``mpa.m0.5`` = Namespaced_IRI.parse _namespace_name "mpa.m0.5" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#mpa.mm0.5"></see>
    /// </summary>
    let ``mpa.mm0.5`` =
        Namespaced_IRI.parse _namespace_name "mpa.mm0.5" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ms"></see>
    /// </summary>
    let ms = Namespaced_IRI.parse _namespace_name "ms" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#n103mbar"></see>
    /// </summary>
    let n103mbar = Namespaced_IRI.parse _namespace_name "n103mbar" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#n104straindegreeC"></see>
    /// </summary>
    let n104straindegreeC =
        Namespaced_IRI.parse _namespace_name "n104straindegreeC" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#n106m2s"></see>
    /// </summary>
    let n106m2s = Namespaced_IRI.parse _namespace_name "n106m2s" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#n106psi"></see>
    /// </summary>
    let n106psi = Namespaced_IRI.parse _namespace_name "n106psi" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#nitrogen"></see>
    /// </summary>
    let nitrogen = Namespaced_IRI.parse _namespace_name "nitrogen" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#nmile"></see>
    /// </summary>
    let nmile = Namespaced_IRI.parse _namespace_name "nmile" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#nmm1.5"></see>
    /// </summary>
    let ``nmm1.5`` = Namespaced_IRI.parse _namespace_name "nmm1.5" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#no_lubricant"></see>
    /// </summary>
    let no_lubricant =
        Namespaced_IRI.parse _namespace_name "no_lubricant" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#oil"></see>
    /// </summary>
    let oil = Namespaced_IRI.parse _namespace_name "oil" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#pa.m0.5"></see>
    /// </summary>
    let ``pa.m0.5`` = Namespaced_IRI.parse _namespace_name "pa.m0.5" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#percentagestraindegreeF"></see>
    /// </summary>
    let percentagestraindegreeF =
        Namespaced_IRI.parse _namespace_name "percentagestraindegreeF" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#percentangestraindegreeC"></see>
    /// </summary>
    let percentangestraindegreeC =
        Namespaced_IRI.parse _namespace_name "percentangestraindegreeC" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#pin"></see>
    /// </summary>
    let pin = Namespaced_IRI.parse _namespace_name "pin" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#pin_on_disc"></see>
    /// </summary>
    let pin_on_disc =
        Namespaced_IRI.parse _namespace_name "pin_on_disc" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#pintUk"></see>
    /// </summary>
    let pintUk = Namespaced_IRI.parse _namespace_name "pintUk" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#pintUs"></see>
    /// </summary>
    let pintUs = Namespaced_IRI.parse _namespace_name "pintUs" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#plate"></see>
    /// </summary>
    let plate = Namespaced_IRI.parse _namespace_name "plate" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#point"></see>
    /// </summary>
    let point = Namespaced_IRI.parse _namespace_name "point" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#polished"></see>
    /// </summary>
    let polished = Namespaced_IRI.parse _namespace_name "polished" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ppb"></see>
    /// </summary>
    let ppb = Namespaced_IRI.parse _namespace_name "ppb" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#psi"></see>
    /// </summary>
    let psi = Namespaced_IRI.parse _namespace_name "psi" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#psi.in0.5"></see>
    /// </summary>
    let ``psi.in0.5`` =
        Namespaced_IRI.parse _namespace_name "psi.in0.5" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#radian"></see>
    /// </summary>
    let radian = Namespaced_IRI.parse _namespace_name "radian" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ring"></see>
    /// </summary>
    let ring = Namespaced_IRI.parse _namespace_name "ring" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ring_on_cylinder"></see>
    /// </summary>
    let ring_on_cylinder =
        Namespaced_IRI.parse _namespace_name "ring_on_cylinder" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#ring_on_disc"></see>
    /// </summary>
    let ring_on_disc =
        Namespaced_IRI.parse _namespace_name "ring_on_disc" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#rolling"></see>
    /// </summary>
    let rolling = Namespaced_IRI.parse _namespace_name "rolling" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#rotating_reciprocating"></see>
    /// </summary>
    let rotating_reciprocating =
        Namespaced_IRI.parse _namespace_name "rotating_reciprocating" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#rotating_unidirectional"></see>
    /// </summary>
    let rotating_unidirectional =
        Namespaced_IRI.parse _namespace_name "rotating_unidirectional" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#rpm"></see>
    /// </summary>
    let rpm = Namespaced_IRI.parse _namespace_name "rpm" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#seal"></see>
    /// </summary>
    let seal = Namespaced_IRI.parse _namespace_name "seal" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#seal_on_shaft"></see>
    /// </summary>
    let seal_on_shaft =
        Namespaced_IRI.parse _namespace_name "seal_on_shaft" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#second"></see>
    /// </summary>
    let second = Namespaced_IRI.parse _namespace_name "second" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#shaft"></see>
    /// </summary>
    let shaft = Namespaced_IRI.parse _namespace_name "shaft" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#sliding"></see>
    /// </summary>
    let sliding = Namespaced_IRI.parse _namespace_name "sliding" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#sliding_wear"></see>
    /// </summary>
    let sliding_wear =
        Namespaced_IRI.parse _namespace_name "sliding_wear" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#slip"></see>
    /// </summary>
    let slip = Namespaced_IRI.parse _namespace_name "slip" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#slip_rolling_wear"></see>
    /// </summary>
    let slip_rolling_wear =
        Namespaced_IRI.parse _namespace_name "slip_rolling_wear" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#slugft3"></see>
    /// </summary>
    let slugft3 = Namespaced_IRI.parse _namespace_name "slugft3" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#solid_friction"></see>
    /// </summary>
    let solid_friction =
        Namespaced_IRI.parse _namespace_name "solid_friction" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#solid_lubricant"></see>
    /// </summary>
    let solid_lubricant =
        Namespaced_IRI.parse _namespace_name "solid_lubricant" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#sonotrode"></see>
    /// </summary>
    let sonotrode = Namespaced_IRI.parse _namespace_name "sonotrode" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#sp-gr2323degreeC"></see>
    /// </summary>
    let ``sp-gr2323degreeC`` =
        Namespaced_IRI.parse _namespace_name "sp-gr2323degreeC" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#stick_slip"></see>
    /// </summary>
    let stick_slip = Namespaced_IRI.parse _namespace_name "stick_slip" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#strain"></see>
    /// </summary>
    let strain = Namespaced_IRI.parse _namespace_name "strain" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#strain_percentage"></see>
    /// </summary>
    let strain_percentage =
        Namespaced_IRI.parse _namespace_name "strain_percentage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#straindegreeC"></see>
    /// </summary>
    let straindegreeC =
        Namespaced_IRI.parse _namespace_name "straindegreeC" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#straindegreeF"></see>
    /// </summary>
    let straindegreeF =
        Namespaced_IRI.parse _namespace_name "straindegreeF" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#synthetic_air"></see>
    /// </summary>
    let synthetic_air =
        Namespaced_IRI.parse _namespace_name "synthetic_air" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#tonin3"></see>
    /// </summary>
    let tonin3 = Namespaced_IRI.parse _namespace_name "tonin3" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#tonnemm3"></see>
    /// </summary>
    let tonnemm3 = Namespaced_IRI.parse _namespace_name "tonnemm3" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#torr"></see>
    /// </summary>
    let torr = Namespaced_IRI.parse _namespace_name "torr" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#tribocorrosive_wear"></see>
    /// </summary>
    let tribocorrosive_wear =
        Namespaced_IRI.parse _namespace_name "tribocorrosive_wear" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#v"></see>
    /// </summary>
    let v = Namespaced_IRI.parse _namespace_name "v" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#vacuum"></see>
    /// </summary>
    let vacuum = Namespaced_IRI.parse _namespace_name "vacuum" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#week"></see>
    /// </summary>
    let week = Namespaced_IRI.parse _namespace_name "week" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#wt_percentage"></see>
    /// </summary>
    let wt_percentage =
        Namespaced_IRI.parse _namespace_name "wt_percentage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#yd"></see>
    /// </summary>
    let yd = Namespaced_IRI.parse _namespace_name "yd" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/tribont/core#year"></see>
    /// </summary>
    let year = Namespaced_IRI.parse _namespace_name "year" |> NamespacedName
