#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``tribont-core`` =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/tribont/core#" "tribont-core"

    let ASTMD5706 = _prefixId.prefix "ASTMD5706"
    let ASTMD5707 = _prefixId.prefix "ASTMD5707"
    let ASTMD6425 = _prefixId.prefix "ASTMD6425"
    let ASTMD7421 = _prefixId.prefix "ASTMD7421"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Acceleration^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Increase in speed or rate.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Acceleration">tribont-core:Acceleration</a>
    /// </summary>
    let Acceleration = _prefixId.prefix "Acceleration"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : AccelerationUnit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Measurement unit for derivative of velocity with respect to time.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#AccelerationUnit">tribont-core:AccelerationUnit</a>
    /// </summary>
    let AccelerationUnit = _prefixId.prefix "AccelerationUnit"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : AcidNumberAN^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Acid number of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#AcidNumberAN">tribont-core:AcidNumberAN</a>
    /// </summary>
    let AcidNumberAN = _prefixId.prefix "AcidNumberAN"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : AirReleaseTimeLAV^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Air release time for something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#AirReleaseTimeLAV">tribont-core:AirReleaseTimeLAV</a>
    /// </summary>
    let AirReleaseTimeLAV = _prefixId.prefix "AirReleaseTimeLAV"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : AlkalineAdditivesConsumption^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Consumption of alkaline additives by something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#AlkalineAdditivesConsumption">tribont-core:AlkalineAdditivesConsumption</a>
    /// </summary>
    let AlkalineAdditivesConsumption = _prefixId.prefix "AlkalineAdditivesConsumption"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : AngleUnit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Measurement unit for angle.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#AngleUnit">tribont-core:AngleUnit</a>
    /// </summary>
    let AngleUnit = _prefixId.prefix "AngleUnit"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : AngularPosition^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Angular position of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#AngularPosition">tribont-core:AngularPosition</a>
    /// </summary>
    let AngularPosition = _prefixId.prefix "AngularPosition"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : AxialLoad^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Axial load applied to something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#AxialLoad">tribont-core:AxialLoad</a>
    /// </summary>
    let AxialLoad = _prefixId.prefix "AxialLoad"
    let BTUhr'_period_'ft'_period_'degreeF = _prefixId.prefix "BTUhr.ft.degreeF"
    let BTUin2 = _prefixId.prefix "BTUin2"
    let BTUlb'_period_'degreeF = _prefixId.prefix "BTUlb.degreeF"
    let Ba = _prefixId.prefix "Ba"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : A body can be considered as an aggregate of particles to which it is possible to apply a force^^xsd:string</para>
    ///   <para>rdfs:label : Body^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Body">tribont-core:Body</a>
    /// </summary>
    let Body = _prefixId.prefix "Body"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : BodyProperty^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Qualifiable or quantifiable attribute, or characteristic of a body.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#BodyProperty">tribont-core:BodyProperty</a>
    /// </summary>
    let BodyProperty = _prefixId.prefix "BodyProperty"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : COFMean^^xsd:string</para>
    ///   <para>rdfs:comment : Mean value of the coefficient of friction.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#COFMean">tribont-core:COFMean</a>
    /// </summary>
    let COFMean = _prefixId.prefix "COFMean"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : CapacityUnit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Measurement unit for capacity.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#CapacityUnit">tribont-core:CapacityUnit</a>
    /// </summary>
    let CapacityUnit = _prefixId.prefix "CapacityUnit"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : ChamberTemperature^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Temperature of the chamber where the sample is tested.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#ChamberTemperature">tribont-core:ChamberTemperature</a>
    /// </summary>
    let ChamberTemperature = _prefixId.prefix "ChamberTemperature"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:label : CloudPoint^^xsd:string</para>
    ///   <para>rdfs:comment : Cloud point.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#CloudPoint">tribont-core:CloudPoint</a>
    /// </summary>
    let CloudPoint = _prefixId.prefix "CloudPoint"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:label : ColdFilterPluggingPoint^^xsd:string</para>
    ///   <para>rdfs:comment : Cold filter plugging point.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#ColdFilterPluggingPoint">tribont-core:ColdFilterPluggingPoint</a>
    /// </summary>
    let ColdFilterPluggingPoint = _prefixId.prefix "ColdFilterPluggingPoint"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : ColourIndex^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Colour index  of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#ColourIndex">tribont-core:ColourIndex</a>
    /// </summary>
    let ColourIndex = _prefixId.prefix "ColourIndex"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Company^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : A company.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Company">tribont-core:Company</a>
    /// </summary>
    let Company = _prefixId.prefix "Company"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : CompressiveStrength^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Compressive strength applied to something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#CompressiveStrength">tribont-core:CompressiveStrength</a>
    /// </summary>
    let CompressiveStrength = _prefixId.prefix "CompressiveStrength"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Conductivity^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Conductivity  of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Conductivity">tribont-core:Conductivity</a>
    /// </summary>
    let Conductivity = _prefixId.prefix "Conductivity"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : ContactSurfaceType^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Contact surface type (e.g. line, point,etc. .^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#ContactSurfaceType">tribont-core:ContactSurfaceType</a>
    /// </summary>
    let ContactSurfaceType = _prefixId.prefix "ContactSurfaceType"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : ContentUnit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Measurement unit for contents.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#ContentUnit">tribont-core:ContentUnit</a>
    /// </summary>
    let ContentUnit = _prefixId.prefix "ContentUnit"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : CoradsonCarbonResidue^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Coradson carbon residue in something .^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#CoradsonCarbonResidue">tribont-core:CoradsonCarbonResidue</a>
    /// </summary>
    let CoradsonCarbonResidue = _prefixId.prefix "CoradsonCarbonResidue"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : CorrosionLevel^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Corrosion level of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#CorrosionLevel">tribont-core:CorrosionLevel</a>
    /// </summary>
    let CorrosionLevel = _prefixId.prefix "CorrosionLevel"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : CourseOfMovement^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Type of relative motion  between two or more bodies.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#CourseOfMovement">tribont-core:CourseOfMovement</a>
    /// </summary>
    let CourseOfMovement = _prefixId.prefix "CourseOfMovement"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Decceleration^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Decrease in speed or rate.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Decceleration">tribont-core:Decceleration</a>
    /// </summary>
    let Decceleration = _prefixId.prefix "Decceleration"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Density^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Density of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Density">tribont-core:Density</a>
    /// </summary>
    let Density = _prefixId.prefix "Density"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : DensityUnit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Measurement unit for density.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#DensityUnit">tribont-core:DensityUnit</a>
    /// </summary>
    let DensityUnit = _prefixId.prefix "DensityUnit"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Diameter^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Diameter of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Diameter">tribont-core:Diameter</a>
    /// </summary>
    let Diameter = _prefixId.prefix "Diameter"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Dispersancy^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Dispersancy of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Dispersancy">tribont-core:Dispersancy</a>
    /// </summary>
    let Dispersancy = _prefixId.prefix "Dispersancy"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : DissipationFactor^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Dissipation factor of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#DissipationFactor">tribont-core:DissipationFactor</a>
    /// </summary>
    let DissipationFactor = _prefixId.prefix "DissipationFactor"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : DistanceUnit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Measurement unit for distance.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#DistanceUnit">tribont-core:DistanceUnit</a>
    /// </summary>
    let DistanceUnit = _prefixId.prefix "DistanceUnit"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Document^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Any document.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Document">tribont-core:Document</a>
    /// </summary>
    let Document = _prefixId.prefix "Document"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Duration^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Amount of time during which an event persists.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Duration">tribont-core:Duration</a>
    /// </summary>
    let Duration = _prefixId.prefix "Duration"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : DynamicViscosity^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Dynamic viscosity of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#DynamicViscosity">tribont-core:DynamicViscosity</a>
    /// </summary>
    let DynamicViscosity = _prefixId.prefix "DynamicViscosity"
    let EHD = _prefixId.prefix "EHD"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : ElectricalBreakdownVoltage^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Electrical breakdown voltage of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#ElectricalBreakdownVoltage">tribont-core:ElectricalBreakdownVoltage</a>
    /// </summary>
    let ElectricalBreakdownVoltage = _prefixId.prefix "ElectricalBreakdownVoltage"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : ElectricalConductivity^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Electrical conductivity of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#ElectricalConductivity">tribont-core:ElectricalConductivity</a>
    /// </summary>
    let ElectricalConductivity = _prefixId.prefix "ElectricalConductivity"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : ElectricalProperty^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Qualifiable or quantifiable attribute, or characteristic of electrical behaviour of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#ElectricalProperty">tribont-core:ElectricalProperty</a>
    /// </summary>
    let ElectricalProperty = _prefixId.prefix "ElectricalProperty"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : ElectricalResistivity^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Electrical resistivity of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#ElectricalResistivity">tribont-core:ElectricalResistivity</a>
    /// </summary>
    let ElectricalResistivity = _prefixId.prefix "ElectricalResistivity"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : EnvironmentMedium^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Environment medium surrounding something .^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#EnvironmentMedium">tribont-core:EnvironmentMedium</a>
    /// </summary>
    let EnvironmentMedium = _prefixId.prefix "EnvironmentMedium"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : EnvironmentProperty^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Qualifiable or quantifiable attribute, or characteristic of the enviroment  in which a test has been / or should be carried out.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#EnvironmentProperty">tribont-core:EnvironmentProperty</a>
    /// </summary>
    let EnvironmentProperty = _prefixId.prefix "EnvironmentProperty"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : ExpansionCOFUnit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Measurement unit for expansion coefficient.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#ExpansionCOFUnit">tribont-core:ExpansionCOFUnit</a>
    /// </summary>
    let ExpansionCOFUnit = _prefixId.prefix "ExpansionCOFUnit"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : ExternalForce^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : External force applied to something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#ExternalForce">tribont-core:ExternalForce</a>
    /// </summary>
    let ExternalForce = _prefixId.prefix "ExternalForce"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Filterability^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Filterability of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Filterability">tribont-core:Filterability</a>
    /// </summary>
    let Filterability = _prefixId.prefix "Filterability"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:label : FlashPoint^^xsd:string</para>
    ///   <para>rdfs:comment : Flash point of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#FlashPoint">tribont-core:FlashPoint</a>
    /// </summary>
    let FlashPoint = _prefixId.prefix "FlashPoint"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : FlexuralStrength^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Flexural strength of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#FlexuralStrength">tribont-core:FlexuralStrength</a>
    /// </summary>
    let FlexuralStrength = _prefixId.prefix "FlexuralStrength"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : FoamingTendency^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Foaming tendency of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#FoamingTendency">tribont-core:FoamingTendency</a>
    /// </summary>
    let FoamingTendency = _prefixId.prefix "FoamingTendency"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : ForceUnit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Measurement unit for force.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#ForceUnit">tribont-core:ForceUnit</a>
    /// </summary>
    let ForceUnit = _prefixId.prefix "ForceUnit"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : FractureToughness^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Fracture toughness of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#FractureToughness">tribont-core:FractureToughness</a>
    /// </summary>
    let FractureToughness = _prefixId.prefix "FractureToughness"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Frequency^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Frequency of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Frequency">tribont-core:Frequency</a>
    /// </summary>
    let Frequency = _prefixId.prefix "Frequency"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : FrequencyUnit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Measurement unit for frequency.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#FrequencyUnit">tribont-core:FrequencyUnit</a>
    /// </summary>
    let FrequencyUnit = _prefixId.prefix "FrequencyUnit"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : FrictionProperty^^xsd:string</para>
    ///   <para>rdfs:comment : Qualifiable or quantifiable attribute, or characteristic of the friction between two or more bodies.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#FrictionProperty">tribont-core:FrictionProperty</a>
    /// </summary>
    let FrictionProperty = _prefixId.prefix "FrictionProperty"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : FrictionTorque^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Friction torque applied to something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#FrictionTorque">tribont-core:FrictionTorque</a>
    /// </summary>
    let FrictionTorque = _prefixId.prefix "FrictionTorque"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : GeometricDimension^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Quantifiable attribute, or characteristic of the geometry of a body.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#GeometricDimension">tribont-core:GeometricDimension</a>
    /// </summary>
    let GeometricDimension = _prefixId.prefix "GeometricDimension"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : GeometricalArrangement^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Geometrical combination of bodies belonging to a tribological system (e.g. ball on disc).^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#GeometricalArrangement">tribont-core:GeometricalArrangement</a>
    /// </summary>
    let GeometricalArrangement = _prefixId.prefix "GeometricalArrangement"
    let HV = _prefixId.prefix "HV"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : HardnessBrinell^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Brinell hardness of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#HardnessBrinell">tribont-core:HardnessBrinell</a>
    /// </summary>
    let HardnessBrinell = _prefixId.prefix "HardnessBrinell"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : HardnessKnoop100g^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Knoop hardness of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#HardnessKnoop100g">tribont-core:HardnessKnoop100g</a>
    /// </summary>
    let HardnessKnoop100g = _prefixId.prefix "HardnessKnoop100g"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : HardnessProperty^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Quantifiable attribute, or characteristic of the hardness of a body.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#HardnessProperty">tribont-core:HardnessProperty</a>
    /// </summary>
    let HardnessProperty = _prefixId.prefix "HardnessProperty"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : HardnessRockwellB^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : RockwellB hardness of something .^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#HardnessRockwellB">tribont-core:HardnessRockwellB</a>
    /// </summary>
    let HardnessRockwellB = _prefixId.prefix "HardnessRockwellB"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : HardnessRockwellC^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : RockwellC hardness of something .^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#HardnessRockwellC">tribont-core:HardnessRockwellC</a>
    /// </summary>
    let HardnessRockwellC = _prefixId.prefix "HardnessRockwellC"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : HardnessRockwellM^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : RockwellM hardnes of somethings .^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#HardnessRockwellM">tribont-core:HardnessRockwellM</a>
    /// </summary>
    let HardnessRockwellM = _prefixId.prefix "HardnessRockwellM"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : HardnessRockwellR^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : RockwellR hardness of something .^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#HardnessRockwellR">tribont-core:HardnessRockwellR</a>
    /// </summary>
    let HardnessRockwellR = _prefixId.prefix "HardnessRockwellR"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : HardnessShoreA^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : ShoreA hardness of something .^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#HardnessShoreA">tribont-core:HardnessShoreA</a>
    /// </summary>
    let HardnessShoreA = _prefixId.prefix "HardnessShoreA"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : HardnessShoreD^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : ShoreD hardness of something .^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#HardnessShoreD">tribont-core:HardnessShoreD</a>
    /// </summary>
    let HardnessShoreD = _prefixId.prefix "HardnessShoreD"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : HardnessUnit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Measurement unit for hardness.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#HardnessUnit">tribont-core:HardnessUnit</a>
    /// </summary>
    let HardnessUnit = _prefixId.prefix "HardnessUnit"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : HardnessVickers^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Vickers hardness of something .^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#HardnessVickers">tribont-core:HardnessVickers</a>
    /// </summary>
    let HardnessVickers = _prefixId.prefix "HardnessVickers"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : HeatCapacityUnit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Measurement unit for heat capacity.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#HeatCapacityUnit">tribont-core:HeatCapacityUnit</a>
    /// </summary>
    let HeatCapacityUnit = _prefixId.prefix "HeatCapacityUnit"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Height^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Height of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Height">tribont-core:Height</a>
    /// </summary>
    let Height = _prefixId.prefix "Height"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Humidity^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Humidity of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Humidity">tribont-core:Humidity</a>
    /// </summary>
    let Humidity = _prefixId.prefix "Humidity"
    let Hz = _prefixId.prefix "Hz"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Inclination^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Inclination of the camber where the test is carried out.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Inclination">tribont-core:Inclination</a>
    /// </summary>
    let Inclination = _prefixId.prefix "Inclination"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : IndentationHardnessMicro^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Indentation hardness micro.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#IndentationHardnessMicro">tribont-core:IndentationHardnessMicro</a>
    /// </summary>
    let IndentationHardnessMicro = _prefixId.prefix "IndentationHardnessMicro"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : IndentationHardnessNano^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Indentation hardness nano.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#IndentationHardnessNano">tribont-core:IndentationHardnessNano</a>
    /// </summary>
    let IndentationHardnessNano = _prefixId.prefix "IndentationHardnessNano"

    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : InhibitedHydraulicFluidsOxidationStabilityAndLubricatingOilsForHighPressureLoads^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Inhibited Hydraulic Fluids Oxidation Stability And Lubricating Oils For High Pressure Loads.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#InhibitedHydraulicFluidsOxidationStabilityAndLubricatingOilsForHighPressureLoads">tribont-core:InhibitedHydraulicFluidsOxidationStabilityAndLubricatingOilsForHighPressureLoads</a>
    /// </summary>
    let InhibitedHydraulicFluidsOxidationStabilityAndLubricatingOilsForHighPressureLoads =
        _prefixId.prefix "InhibitedHydraulicFluidsOxidationStabilityAndLubricatingOilsForHighPressureLoads"

    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : InnerDiameter^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Inner diameter of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#InnerDiameter">tribont-core:InnerDiameter</a>
    /// </summary>
    let InnerDiameter = _prefixId.prefix "InnerDiameter"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : InnerTeethHeight^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Inner teeth height of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#InnerTeethHeight">tribont-core:InnerTeethHeight</a>
    /// </summary>
    let InnerTeethHeight = _prefixId.prefix "InnerTeethHeight"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : InnerTeethLength^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Inner teeth length of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#InnerTeethLength">tribont-core:InnerTeethLength</a>
    /// </summary>
    let InnerTeethLength = _prefixId.prefix "InnerTeethLength"

    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : InterfacialTensionBetweenWaterOil^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Interfacial Tension Between Water Oil^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#InterfacialTensionBetweenWaterOil">tribont-core:InterfacialTensionBetweenWaterOil</a>
    /// </summary>
    let InterfacialTensionBetweenWaterOil = _prefixId.prefix "InterfacialTensionBetweenWaterOil"

    let Jcm3 = _prefixId.prefix "Jcm3"
    let Jkg'_period_'degreeC = _prefixId.prefix "Jkg.degreeC"
    let Jm'_period_'s'_period_'degreeC = _prefixId.prefix "Jm.s.degreeC"
    let Jm2 = _prefixId.prefix "Jm2"
    let Jm3 = _prefixId.prefix "Jm3"
    let Kgf = _prefixId.prefix "Kgf"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : KinematicViscosity^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Kinematic viscosity of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#KinematicViscosity">tribont-core:KinematicViscosity</a>
    /// </summary>
    let KinematicViscosity = _prefixId.prefix "KinematicViscosity"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Laboratory^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : A laboratory.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Laboratory">tribont-core:Laboratory</a>
    /// </summary>
    let Laboratory = _prefixId.prefix "Laboratory"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Length^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Length of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Length">tribont-core:Length</a>
    /// </summary>
    let Length = _prefixId.prefix "Length"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : LinearSpeed^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Linear speed of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#LinearSpeed">tribont-core:LinearSpeed</a>
    /// </summary>
    let LinearSpeed = _prefixId.prefix "LinearSpeed"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : LiquidPhysicalProperty^^xsd:string</para>
    ///   <para>rdfs:comment : Qualifiable or quantifiable physical attribute, or characteristic of a liquid.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#LiquidPhysicalProperty">tribont-core:LiquidPhysicalProperty</a>
    /// </summary>
    let LiquidPhysicalProperty = _prefixId.prefix "LiquidPhysicalProperty"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:label : LiquidThermalProperty^^xsd:string</para>
    ///   <para>rdfs:comment : Qualifiable or quantifiable thermal attribute, or characteristic of a liquid.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#LiquidThermalProperty">tribont-core:LiquidThermalProperty</a>
    /// </summary>
    let LiquidThermalProperty = _prefixId.prefix "LiquidThermalProperty"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Load^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Load applied to something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Load">tribont-core:Load</a>
    /// </summary>
    let Load = _prefixId.prefix "Load"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : LoadLevelRatio^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Load leverlratio of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#LoadLeverRatio">tribont-core:LoadLeverRatio</a>
    /// </summary>
    let LoadLeverRatio = _prefixId.prefix "LoadLeverRatio"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : LoadPressure^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Load pressure applied to something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#LoadPressure">tribont-core:LoadPressure</a>
    /// </summary>
    let LoadPressure = _prefixId.prefix "LoadPressure"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : LoadProperty^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Qualifiable or quantifiable  attribute, or characteristic of load.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#LoadProperty">tribont-core:LoadProperty</a>
    /// </summary>
    let LoadProperty = _prefixId.prefix "LoadProperty"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : LoadRate^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Load rate applied to something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#LoadRate">tribont-core:LoadRate</a>
    /// </summary>
    let LoadRate = _prefixId.prefix "LoadRate"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : LoadRateUnit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Measurement unit for load rate.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#LoadRateUnit">tribont-core:LoadRateUnit</a>
    /// </summary>
    let LoadRateUnit = _prefixId.prefix "LoadRateUnit"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : LodineNumber^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Lodine number of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#LodineNumber">tribont-core:LodineNumber</a>
    /// </summary>
    let LodineNumber = _prefixId.prefix "LodineNumber"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : LubricantType^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Lubricant type.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#LubricantType">tribont-core:LubricantType</a>
    /// </summary>
    let LubricantType = _prefixId.prefix "LubricantType"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : LubricantsOxidationStability^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Lubricants oxidation stability.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#LubricantsOxidationStability">tribont-core:LubricantsOxidationStability</a>
    /// </summary>
    let LubricantsOxidationStability = _prefixId.prefix "LubricantsOxidationStability"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : LubricationRegime^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Lubrication regime applied to a test or process .^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#LubricationRegime">tribont-core:LubricationRegime</a>
    /// </summary>
    let LubricationRegime = _prefixId.prefix "LubricationRegime"
    let MGO = _prefixId.prefix "MGO"
    let MJm2 = _prefixId.prefix "MJm2"
    let MJm3 = _prefixId.prefix "MJm3"
    let MPa = _prefixId.prefix "MPa"
    /// <summary>
    ///   <para>vs:term_status : resting^^xsd:string</para>
    ///   <para>rdfs:label : MagnificationProperty^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : MagnificationProperty applyed to something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#MagnificationProperty">tribont-core:MagnificationProperty</a>
    /// </summary>
    let MagnificationProperty = _prefixId.prefix "MagnificationProperty"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : MaxLoadWithoutFailure^^xsd:string</para>
    ///   <para>rdfs:comment : Maximun load before failure of the material.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#MaxLoadWithoutFailure">tribont-core:MaxLoadWithoutFailure</a>
    /// </summary>
    let MaxLoadWithoutFailure = _prefixId.prefix "MaxLoadWithoutFailure"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : MaximumServiceTemperature^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Maximun temperature of operation.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#MaximumServiceTemperature">tribont-core:MaximumServiceTemperature</a>
    /// </summary>
    let MaximumServiceTemperature = _prefixId.prefix "MaximumServiceTemperature"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : MechanicalProperty^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Qualifiable or quantifiable attribute, or characteristic of mechanical behaviour of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#MechanicalProperty">tribont-core:MechanicalProperty</a>
    /// </summary>
    let MechanicalProperty = _prefixId.prefix "MechanicalProperty"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : MechanicalUnit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Measurement units for mechanizal properties.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#MechanicalUnit">tribont-core:MechanicalUnit</a>
    /// </summary>
    let MechanicalUnit = _prefixId.prefix "MechanicalUnit"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : MeltingPoint^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Melting point  of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#MeltingPoint">tribont-core:MeltingPoint</a>
    /// </summary>
    let MeltingPoint = _prefixId.prefix "MeltingPoint"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : MovementProperty^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Qualifiable or quantifiable attribute, or characteristic of something's movement.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#MovementProperty">tribont-core:MovementProperty</a>
    /// </summary>
    let MovementProperty = _prefixId.prefix "MovementProperty"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : MovementType^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Type of movement appled to something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#MovementType">tribont-core:MovementType</a>
    /// </summary>
    let MovementType = _prefixId.prefix "MovementType"
    let N = _prefixId.prefix "N"
    let N'_period_'m = _prefixId.prefix "N.m"
    let N'_period_'mmg'_period_'degreeC = _prefixId.prefix "N.mmg.degreeC"
    let N'_period_'mmmm2 = _prefixId.prefix "N.mmmm2"
    let N'_period_'mmmm3 = _prefixId.prefix "N.mmmm3"

    let N'_period_'mmms'_period_'mm'_period_'degreeC = _prefixId.prefix "N.mmms.mm.degreeC"

    let N'_period_'mmsmm'_period_'degreeC = _prefixId.prefix "N.mmsmm.degreeC"
    let N'_period_'mmtonne'_period_'degreeC = _prefixId.prefix "N.mmtonne.degreeC"
    let N2CO295 = _prefixId.prefix "N2CO295"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : NeutralisationNumberNN^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Neutralisation number of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#NeutralisationNumberNN">tribont-core:NeutralisationNumberNN</a>
    /// </summary>
    let NeutralisationNumberNN = _prefixId.prefix "NeutralisationNumberNN"
    let Nmm = _prefixId.prefix "Nmm"
    let Nmm2 = _prefixId.prefix "Nmm2"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : NormalForce^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Normal force applied to something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#NormalForce">tribont-core:NormalForce</a>
    /// </summary>
    let NormalForce = _prefixId.prefix "NormalForce"
    let Ns = _prefixId.prefix "Ns"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : NumberOfContactSurface^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Number of contact surfaces of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#NumberOfContactSurface">tribont-core:NumberOfContactSurface</a>
    /// </summary>
    let NumberOfContactSurface = _prefixId.prefix "NumberOfContactSurface"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : O2Level^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : O2 level of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#O2Level">tribont-core:O2Level</a>
    /// </summary>
    let O2Level = _prefixId.prefix "O2Level"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : OperationProperty^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Quantifiable operation attribute, or characteristic of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#OperationProperty">tribont-core:OperationProperty</a>
    /// </summary>
    let OperationProperty = _prefixId.prefix "OperationProperty"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : OuterDiameter^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Outer diameter.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#OuterDiameter">tribont-core:OuterDiameter</a>
    /// </summary>
    let OuterDiameter = _prefixId.prefix "OuterDiameter"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : OuterTeethHeight^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Outer teeth height of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#OuterTeethHeight">tribont-core:OuterTeethHeight</a>
    /// </summary>
    let OuterTeethHeight = _prefixId.prefix "OuterTeethHeight"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : OuterTeethLength^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Outer teeth length of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#OuterTeethLength">tribont-core:OuterTeethLength</a>
    /// </summary>
    let OuterTeethLength = _prefixId.prefix "OuterTeethLength"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : PQIndex^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : PQ index of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#PQIndex">tribont-core:PQIndex</a>
    /// </summary>
    let PQIndex = _prefixId.prefix "PQIndex"
    let Pa = _prefixId.prefix "Pa"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : PercentageUnit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Measurement unit for angle.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#PercentageUnit">tribont-core:PercentageUnit</a>
    /// </summary>
    let PercentageUnit = _prefixId.prefix "PercentageUnit"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : PhLevel^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Ph level of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#PhLevel">tribont-core:PhLevel</a>
    /// </summary>
    let PhLevel = _prefixId.prefix "PhLevel"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : PhysicalProperty^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Qualifiable or quantifiable physical attribute, or characteristic of a something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#PhysicalProperty">tribont-core:PhysicalProperty</a>
    /// </summary>
    let PhysicalProperty = _prefixId.prefix "PhysicalProperty"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : PoisssonRatio^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Poissson ratio of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#PoisssonRatio">tribont-core:PoisssonRatio</a>
    /// </summary>
    let PoisssonRatio = _prefixId.prefix "PoisssonRatio"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : PolishGrade^^xsd:string</para>
    ///   <para>rdfs:comment : Polish grade of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#PolishGrade">tribont-core:PolishGrade</a>
    /// </summary>
    let PolishGrade = _prefixId.prefix "PolishGrade"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Porosity^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Porosity of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Porosity">tribont-core:Porosity</a>
    /// </summary>
    let Porosity = _prefixId.prefix "Porosity"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : PourPoint^^xsd:string</para>
    ///   <para>rdfs:comment : Pour point of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#PourPoint">tribont-core:PourPoint</a>
    /// </summary>
    let PourPoint = _prefixId.prefix "PourPoint"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Pressure^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Pressure applied to soemthing.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Pressure">tribont-core:Pressure</a>
    /// </summary>
    let Pressure = _prefixId.prefix "Pressure"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : PressureUnit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Measurement unit for pressure.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#PressureUnit">tribont-core:PressureUnit</a>
    /// </summary>
    let PressureUnit = _prefixId.prefix "PressureUnit"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Ra^^xsd:string</para>
    ///   <para>rdfs:comment : Arithmetical mean height of the absolute values.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Ra">tribont-core:Ra</a>
    /// </summary>
    let Ra = _prefixId.prefix "Ra"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : RadiationDosage^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Radiation dosage applied to something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#RadiationDosage">tribont-core:RadiationDosage</a>
    /// </summary>
    let RadiationDosage = _prefixId.prefix "RadiationDosage"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : RadiationType^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Radiation type.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#RadiationType">tribont-core:RadiationType</a>
    /// </summary>
    let RadiationType = _prefixId.prefix "RadiationType"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : RelativeDielectricConstant^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Relative dielectric constant of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#RelativeDielectricConstant">tribont-core:RelativeDielectricConstant</a>
    /// </summary>
    let RelativeDielectricConstant = _prefixId.prefix "RelativeDielectricConstant"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Rk^^xsd:string</para>
    ///   <para>rdfs:comment : Core height.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Rk">tribont-core:Rk</a>
    /// </summary>
    let Rk = _prefixId.prefix "Rk"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Rku^^xsd:string</para>
    ///   <para>rdfs:comment : Kurtosis^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Rku">tribont-core:Rku</a>
    /// </summary>
    let Rku = _prefixId.prefix "Rku"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Rmk1^^xsd:string</para>
    ///   <para>rdfs:comment : Material ratio of the reduced peak height^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Rmk1">tribont-core:Rmk1</a>
    /// </summary>
    let Rmk1 = _prefixId.prefix "Rmk1"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Rmk2^^xsd:string</para>
    ///   <para>rdfs:comment : Material ratio of the reduced valley depth^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Rmk2">tribont-core:Rmk2</a>
    /// </summary>
    let Rmk2 = _prefixId.prefix "Rmk2"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Role^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : The position or purpose that someone or something has in a situation, organization, society, or relationship:.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Role">tribont-core:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : RotationSpeed^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Rotation speed of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#RotationSpeed">tribont-core:RotationSpeed</a>
    /// </summary>
    let RotationSpeed = _prefixId.prefix "RotationSpeed"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : RotationSpeedUnit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Measurement unit for rotational speed.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#RotationSpeedUnit">tribont-core:RotationSpeedUnit</a>
    /// </summary>
    let RotationSpeedUnit = _prefixId.prefix "RotationSpeedUnit"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Rp^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Mean peak height.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Rp">tribont-core:Rp</a>
    /// </summary>
    let Rp = _prefixId.prefix "Rp"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Rpk^^xsd:string</para>
    ///   <para>rdfs:comment : Reduced peak height^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Rpk">tribont-core:Rpk</a>
    /// </summary>
    let Rpk = _prefixId.prefix "Rpk"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Rpkx^^xsd:string</para>
    ///   <para>rdfs:comment : Reduced peak height along x^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Rpkx">tribont-core:Rpkx</a>
    /// </summary>
    let Rpkx = _prefixId.prefix "Rpkx"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Rq^^xsd:string</para>
    ///   <para>rdfs:comment : Root mean square height^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Rq">tribont-core:Rq</a>
    /// </summary>
    let Rq = _prefixId.prefix "Rq"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Rsk^^xsd:string</para>
    ///   <para>rdfs:comment : Skewness^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Rsk">tribont-core:Rsk</a>
    /// </summary>
    let Rsk = _prefixId.prefix "Rsk"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Rt^^xsd:string</para>
    ///   <para>rdfs:comment : Total height^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Rt">tribont-core:Rt</a>
    /// </summary>
    let Rt = _prefixId.prefix "Rt"

    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Rust-PreventingCharacteristicInPresenceOfWater^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Rust-Preventing Characteristic In Presence Of Water.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Rust-PreventingCharacteristicInPresenceOfWater">tribont-core:Rust-PreventingCharacteristicInPresenceOfWater</a>
    /// </summary>
    let Rust_PreventingCharacteristicInPresenceOfWater = _prefixId.prefix "Rust-PreventingCharacteristicInPresenceOfWater"

    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Rv^^xsd:string</para>
    ///   <para>rdfs:comment : Mean valley depth^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Rv">tribont-core:Rv</a>
    /// </summary>
    let Rv = _prefixId.prefix "Rv"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Rvkx^^xsd:string</para>
    ///   <para>rdfs:comment : Maximum peak height^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Rvkx">tribont-core:Rvkx</a>
    /// </summary>
    let Rvkx = _prefixId.prefix "Rvkx"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Rz^^xsd:string</para>
    ///   <para>rdfs:comment : Mean total height^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Rz">tribont-core:Rz</a>
    /// </summary>
    let Rz = _prefixId.prefix "Rz"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Sa^^xsd:string</para>
    ///   <para>rdfs:comment : Arithmetical mean height^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Sa">tribont-core:Sa</a>
    /// </summary>
    let Sa = _prefixId.prefix "Sa"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : SampleTemperature^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Temperature of the sample body.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#SampleTemperature">tribont-core:SampleTemperature</a>
    /// </summary>
    let SampleTemperature = _prefixId.prefix "SampleTemperature"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Sdq^^xsd:string</para>
    ///   <para>rdfs:comment : Sdq.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Sdq">tribont-core:Sdq</a>
    /// </summary>
    let Sdq = _prefixId.prefix "Sdq"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Sdr^^xsd:string</para>
    ///   <para>rdfs:comment : Sdr.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Sdr">tribont-core:Sdr</a>
    /// </summary>
    let Sdr = _prefixId.prefix "Sdr"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Shape^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : The form or outline of something^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Shape">tribont-core:Shape</a>
    /// </summary>
    let Shape = _prefixId.prefix "Shape"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : ShearStability^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Shear stability.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#ShearStability">tribont-core:ShearStability</a>
    /// </summary>
    let ShearStability = _prefixId.prefix "ShearStability"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Sk^^xsd:string</para>
    ///   <para>rdfs:comment : Core height^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Sk">tribont-core:Sk</a>
    /// </summary>
    let Sk = _prefixId.prefix "Sk"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Sku^^xsd:string</para>
    ///   <para>rdfs:comment : Kurtosis^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Sku">tribont-core:Sku</a>
    /// </summary>
    let Sku = _prefixId.prefix "Sku"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : SlidingSpeed^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Sliding speed of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#SlidingSpeed">tribont-core:SlidingSpeed</a>
    /// </summary>
    let SlidingSpeed = _prefixId.prefix "SlidingSpeed"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : SlipPercentage^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Slip percentage of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#SlipPercentage">tribont-core:SlipPercentage</a>
    /// </summary>
    let SlipPercentage = _prefixId.prefix "SlipPercentage"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Smk1^^xsd:string</para>
    ///   <para>rdfs:comment : Material ratio of the hills^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Smk1">tribont-core:Smk1</a>
    /// </summary>
    let Smk1 = _prefixId.prefix "Smk1"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Smk2^^xsd:string</para>
    ///   <para>rdfs:comment : Material ratio of the dales^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Smk2">tribont-core:Smk2</a>
    /// </summary>
    let Smk2 = _prefixId.prefix "Smk2"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : SolidPhysicalProperty^^xsd:string</para>
    ///   <para>rdfs:comment : Qualifiable or quantifiable physical attribute, or characteristic of a solid.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#SolidPhysicalProperty">tribont-core:SolidPhysicalProperty</a>
    /// </summary>
    let SolidPhysicalProperty = _prefixId.prefix "SolidPhysicalProperty"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:label : SolidThermalProperty^^xsd:string</para>
    ///   <para>rdfs:comment : Qualifiable or quantifiable thermal attribute, or characteristic of a solid.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#SolidThermalProperty">tribont-core:SolidThermalProperty</a>
    /// </summary>
    let SolidThermalProperty = _prefixId.prefix "SolidThermalProperty"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Sp^^xsd:string</para>
    ///   <para>rdfs:comment : Maximum peak height^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Sp">tribont-core:Sp</a>
    /// </summary>
    let Sp = _prefixId.prefix "Sp"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : SpecificHeatCapacity^^xsd:string</para>
    ///   <para>rdfs:comment : Specific heat capacity^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#SpecificHeatCapacity">tribont-core:SpecificHeatCapacity</a>
    /// </summary>
    let SpecificHeatCapacity = _prefixId.prefix "SpecificHeatCapacity"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Spk^^xsd:string</para>
    ///   <para>rdfs:comment : Reduced peak height^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Spk">tribont-core:Spk</a>
    /// </summary>
    let Spk = _prefixId.prefix "Spk"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Spkx^^xsd:string</para>
    ///   <para>rdfs:comment : Maximum peak height^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Spkx">tribont-core:Spkx</a>
    /// </summary>
    let Spkx = _prefixId.prefix "Spkx"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Sq^^xsd:string</para>
    ///   <para>rdfs:comment : Root mean square height^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Sq">tribont-core:Sq</a>
    /// </summary>
    let Sq = _prefixId.prefix "Sq"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Ssk^^xsd:string</para>
    ///   <para>rdfs:comment : Skewness^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Ssk">tribont-core:Ssk</a>
    /// </summary>
    let Ssk = _prefixId.prefix "Ssk"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Standard^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : A reference point against which other things can be evaluated or compared.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Standard">tribont-core:Standard</a>
    /// </summary>
    let Standard = _prefixId.prefix "Standard"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : StrokeAmplitude^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Stroke amplitude.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#StrokeAmplitude">tribont-core:StrokeAmplitude</a>
    /// </summary>
    let StrokeAmplitude = _prefixId.prefix "StrokeAmplitude"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : StrokeDiameter^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Stroke diameter.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#StrokeDiameter">tribont-core:StrokeDiameter</a>
    /// </summary>
    let StrokeDiameter = _prefixId.prefix "StrokeDiameter"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : StrokeLength^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Stroke length.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#StrokeLength">tribont-core:StrokeLength</a>
    /// </summary>
    let StrokeLength = _prefixId.prefix "StrokeLength"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : SurfaceProperty^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Qualifiable or quantifiable  attribute, or characteristic of a surface. .^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#SurfaceProperty">tribont-core:SurfaceProperty</a>
    /// </summary>
    let SurfaceProperty = _prefixId.prefix "SurfaceProperty"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : SurfaceRoughness^^xsd:string</para>
    ///   <para>rdfs:comment : Surface roughness. .^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#SurfaceRoughness">tribont-core:SurfaceRoughness</a>
    /// </summary>
    let SurfaceRoughness = _prefixId.prefix "SurfaceRoughness"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Sv^^xsd:string</para>
    ///   <para>rdfs:comment : Maximum valley depth^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Sv">tribont-core:Sv</a>
    /// </summary>
    let Sv = _prefixId.prefix "Sv"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Svk^^xsd:string</para>
    ///   <para>rdfs:comment : Reduced valley depth^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Svk">tribont-core:Svk</a>
    /// </summary>
    let Svk = _prefixId.prefix "Svk"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Svkx^^xsd:string</para>
    ///   <para>rdfs:comment : Maximum valley depth^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Svkx">tribont-core:Svkx</a>
    /// </summary>
    let Svkx = _prefixId.prefix "Svkx"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : SystemProperty^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Qualifiable or quantifiable  attribute, or characteristic of a sample system. .^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#SystemProperty">tribont-core:SystemProperty</a>
    /// </summary>
    let SystemProperty = _prefixId.prefix "SystemProperty"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Sz^^xsd:string</para>
    ///   <para>rdfs:comment : Maximum height z^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Sz">tribont-core:Sz</a>
    /// </summary>
    let Sz = _prefixId.prefix "Sz"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : TechnicalProperty^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Qualifiable or quantifiable technical attribute, or characteristic of something. .^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#TechnicalProperty">tribont-core:TechnicalProperty</a>
    /// </summary>
    let TechnicalProperty = _prefixId.prefix "TechnicalProperty"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : TeethHeight^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Height of a teeth. .^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#TeethHeight">tribont-core:TeethHeight</a>
    /// </summary>
    let TeethHeight = _prefixId.prefix "TeethHeight"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : TeethLength^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Length of a teeth. .^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#TeethLength">tribont-core:TeethLength</a>
    /// </summary>
    let TeethLength = _prefixId.prefix "TeethLength"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Temperature^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Temperature ofsomebody or something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Temperature">tribont-core:Temperature</a>
    /// </summary>
    let Temperature = _prefixId.prefix "Temperature"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : TemperatureUni^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Measurement unit for temperature.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#TemperatureUnit">tribont-core:TemperatureUnit</a>
    /// </summary>
    let TemperatureUnit = _prefixId.prefix "TemperatureUnit"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : TendencyUnit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Measurement unit for tendency.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#TendencyUnit">tribont-core:TendencyUnit</a>
    /// </summary>
    let TendencyUnit = _prefixId.prefix "TendencyUnit"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : TensileStrength^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Tensile strength of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#TensileStrength">tribont-core:TensileStrength</a>
    /// </summary>
    let TensileStrength = _prefixId.prefix "TensileStrength"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : TensionUnit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Measurement unit for tension.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#TensionUnit">tribont-core:TensionUnit</a>
    /// </summary>
    let TensionUnit = _prefixId.prefix "TensionUnit"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : ThermalConductivity^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Thermal conductivity of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#ThermalConductivity">tribont-core:ThermalConductivity</a>
    /// </summary>
    let ThermalConductivity = _prefixId.prefix "ThermalConductivity"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : ThermalConductivityUnit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Measurement unit for conductivity.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#ThermalConductivityUnit">tribont-core:ThermalConductivityUnit</a>
    /// </summary>
    let ThermalConductivityUnit = _prefixId.prefix "ThermalConductivityUnit"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : ThermalExpansionCoefficient^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Thermal expansion coefficient of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#ThermalExpansionCoefficient">tribont-core:ThermalExpansionCoefficient</a>
    /// </summary>
    let ThermalExpansionCoefficient = _prefixId.prefix "ThermalExpansionCoefficient"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : ThermalProperty^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Qualifiable or quantifiable termal attribute, or characteristic of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#ThermalProperty">tribont-core:ThermalProperty</a>
    /// </summary>
    let ThermalProperty = _prefixId.prefix "ThermalProperty"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : TimeUnit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Measurement unit for time.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#TimeUnit">tribont-core:TimeUnit</a>
    /// </summary>
    let TimeUnit = _prefixId.prefix "TimeUnit"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Torque^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Torque applied to something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Torque">tribont-core:Torque</a>
    /// </summary>
    let Torque = _prefixId.prefix "Torque"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : TorqueUnit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Measurement unit for torque.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#TorqueUnit">tribont-core:TorqueUnit</a>
    /// </summary>
    let TorqueUnit = _prefixId.prefix "TorqueUnit"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : ToughnessUnit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Measurement unit for toughness.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#ToughnessUnit">tribont-core:ToughnessUnit</a>
    /// </summary>
    let ToughnessUnit = _prefixId.prefix "ToughnessUnit"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : TribologicalProperty^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Qualifiable or quantifiable tribological attribute, or characteristic of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#TribologicalProperty">tribont-core:TribologicalProperty</a>
    /// </summary>
    let TribologicalProperty = _prefixId.prefix "TribologicalProperty"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Velocity^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Velocity of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Velocity">tribont-core:Velocity</a>
    /// </summary>
    let Velocity = _prefixId.prefix "Velocity"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : VelocityUnit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Measurement unit for velocity.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#VelocityUnit">tribont-core:VelocityUnit</a>
    /// </summary>
    let VelocityUnit = _prefixId.prefix "VelocityUnit"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : ViscosityUnit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Measurement unit for viscosity.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#ViscosityUnit">tribont-core:ViscosityUnit</a>
    /// </summary>
    let ViscosityUnit = _prefixId.prefix "ViscosityUnit"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Vmc^^xsd:string</para>
    ///   <para>rdfs:comment : Core material volume^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Vmc">tribont-core:Vmc</a>
    /// </summary>
    let Vmc = _prefixId.prefix "Vmc"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Vmp^^xsd:string</para>
    ///   <para>rdfs:comment : Peak material volume^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Vmp">tribont-core:Vmp</a>
    /// </summary>
    let Vmp = _prefixId.prefix "Vmp"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : VoltageUnit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Measurement unit for voltage.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#VoltageUnit">tribont-core:VoltageUnit</a>
    /// </summary>
    let VoltageUnit = _prefixId.prefix "VoltageUnit"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Volume^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Volume of someting.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Volume">tribont-core:Volume</a>
    /// </summary>
    let Volume = _prefixId.prefix "Volume"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Vvc^^xsd:string</para>
    ///   <para>rdfs:comment : Core void volume^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Vvc">tribont-core:Vvc</a>
    /// </summary>
    let Vvc = _prefixId.prefix "Vvc"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Vvv^^xsd:string</para>
    ///   <para>rdfs:comment : Dale void volume^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Vvv">tribont-core:Vvv</a>
    /// </summary>
    let Vvv = _prefixId.prefix "Vvv"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : WearProperty^^xsd:string</para>
    ///   <para>rdfs:comment : Qualifiable or quantifiable wear attribute, or characteristic of something..^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#WearProperty">tribont-core:WearProperty</a>
    /// </summary>
    let WearProperty = _prefixId.prefix "WearProperty"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : WearScarLength^^xsd:string</para>
    ///   <para>rdfs:comment :  Length of wear scar..^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#WearScarLength">tribont-core:WearScarLength</a>
    /// </summary>
    let WearScarLength = _prefixId.prefix "WearScarLength"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : WearScarProperty^^xsd:string</para>
    ///   <para>rdfs:comment :  Qualifiable or quantifiable  attribute, or characteristic of a wear scar.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#WearScarProperty">tribont-core:WearScarProperty</a>
    /// </summary>
    let WearScarProperty = _prefixId.prefix "WearScarProperty"
    /// <summary>
    ///   <para>vs:term_status : https://w3id.org/tribont/core^^xsd:stringvs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : WearScarVolume^^xsd:string</para>
    ///   <para>rdfs:comment :  Volume of wear scar..^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#WearScarVolume">tribont-core:WearScarVolume</a>
    /// </summary>
    let WearScarVolume = _prefixId.prefix "WearScarVolume"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : WearType^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Wear type of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#WearType">tribont-core:WearType</a>
    /// </summary>
    let WearType = _prefixId.prefix "WearType"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : WeibullModulus^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Weibull modulus of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#WeibullModulus">tribont-core:WeibullModulus</a>
    /// </summary>
    let WeibullModulus = _prefixId.prefix "WeibullModulus"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Weight^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Weight of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Weight">tribont-core:Weight</a>
    /// </summary>
    let Weight = _prefixId.prefix "Weight"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : WeightUnit^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Measurement unit for weight.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#WeightUnit">tribont-core:WeightUnit</a>
    /// </summary>
    let WeightUnit = _prefixId.prefix "WeightUnit"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Width^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Width of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#Width">tribont-core:Width</a>
    /// </summary>
    let Width = _prefixId.prefix "Width"
    let Wm'_period_'degreeC = _prefixId.prefix "Wm.degreeC"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : YieldStrength^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Yield strength of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#YieldStrength">tribont-core:YieldStrength</a>
    /// </summary>
    let YieldStrength = _prefixId.prefix "YieldStrength"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : YoungModulus^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Young modulus of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#YoungModulus">tribont-core:YoungModulus</a>
    /// </summary>
    let YoungModulus = _prefixId.prefix "YoungModulus"
    let abrasive_wear = _prefixId.prefix "abrasive_wear"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : accessUrl^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Url to access a specific information content or document.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#accessUrl">tribont-core:accessUrl</a>
    /// </summary>
    let accessUrl = _prefixId.prefix "accessUrl"
    let adhesive_wear = _prefixId.prefix "adhesive_wear"
    let ambient_air = _prefixId.prefix "ambient_air"
    let ambient_humidity = _prefixId.prefix "ambient_humidity"
    let ambient_pressure = _prefixId.prefix "ambient_pressure"
    let area = _prefixId.prefix "area"
    let atm = _prefixId.prefix "atm"
    let ball = _prefixId.prefix "ball"
    let ball_on_disc = _prefixId.prefix "ball_on_disc"
    let ball_on_plate = _prefixId.prefix "ball_on_plate"
    let bar = _prefixId.prefix "bar"
    let boundary_lubrication = _prefixId.prefix "boundary_lubrication"
    let calg'_period_'degreeC = _prefixId.prefix "calg.degreeC"

    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : characterisesOperationCondition^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between a specified operation property and the SubjectOfInterest it characterises  (e.g. equipemnt or test)..^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#characterisesOperationCondition">tribont-core:characterisesOperationCondition</a>
    /// </summary>
    let characterisesOperationCondition = _prefixId.prefix "characterisesOperationCondition"

    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : characterisesOperationMeasure^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between a measured operation property and the SubjectOfInterest it characterises  (e.g. equipemnt or test)..^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#characterisesOperationMeasure">tribont-core:characterisesOperationMeasure</a>
    /// </summary>
    let characterisesOperationMeasure = _prefixId.prefix "characterisesOperationMeasure"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : characterisesOutputMeasure^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between a n output technical measure  and the SubjectOfInterest it characterises (e.g. equipemnt or test).^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#characterisesOutputMeasure">tribont-core:characterisesOutputMeasure</a>
    /// </summary>
    let characterisesOutputMeasure = _prefixId.prefix "characterisesOutputMeasure"
    let cm = _prefixId.prefix "cm"
    let cm100m = _prefixId.prefix "cm100m"
    let cm2s = _prefixId.prefix "cm2s"
    let cm3 = _prefixId.prefix "cm3"
    let cmcm = _prefixId.prefix "cmcm"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : compliesWith^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between something and the standard or procedure it complies with.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#compliesWith">tribont-core:compliesWith</a>
    /// </summary>
    let compliesWith = _prefixId.prefix "compliesWith"
    let corrosive_gas = _prefixId.prefix "corrosive_gas"
    let cuboid = _prefixId.prefix "cuboid"
    let cylinder = _prefixId.prefix "cylinder"
    let day = _prefixId.prefix "day"
    let degree = _prefixId.prefix "degree"
    let degreeC = _prefixId.prefix "degreeC"
    let degreeF = _prefixId.prefix "degreeF"
    let degreeK = _prefixId.prefix "degreeK"
    let degreeR = _prefixId.prefix "degreeR"
    let disc = _prefixId.prefix "disc"
    let dm3 = _prefixId.prefix "dm3"
    let dry = _prefixId.prefix "dry"
    let dyncm = _prefixId.prefix "dyncm"
    let dyncm1'_period_'5 = _prefixId.prefix "dyncm1.5"
    let dyncm2 = _prefixId.prefix "dyncm2"
    let e_4 = _prefixId.prefix "e-4"
    let ergcm2 = _prefixId.prefix "ergcm2"
    let ergcm3 = _prefixId.prefix "ergcm3"
    let ergg'_period_'degreeC = _prefixId.prefix "ergg.degreeC"
    let ergs'_period_'cm'_period_'degreeC = _prefixId.prefix "ergs.cm.degreeC"
    let fl_ozUk = _prefixId.prefix "fl-ozUk"
    let fl_ozUs = _prefixId.prefix "fl-ozUs"
    let fretting_wear = _prefixId.prefix "fretting_wear"
    let ft'_period_'lbfft2 = _prefixId.prefix "ft.lbfft2"
    let ft'_period_'lbfft3 = _prefixId.prefix "ft.lbfft3"
    let ft'_period_'lbfin2 = _prefixId.prefix "ft.lbfin2"
    let ft'_period_'lbfin3 = _prefixId.prefix "ft.lbfin3"
    let ft2hr = _prefixId.prefix "ft2hr"
    let ft2s = _prefixId.prefix "ft2s"
    let ft3 = _prefixId.prefix "ft3"
    let ftft = _prefixId.prefix "ftft"
    let g = _prefixId.prefix "g"
    let galUk = _prefixId.prefix "galUk"
    let galUs = _prefixId.prefix "galUs"
    let gcm3 = _prefixId.prefix "gcm3"
    let gear = _prefixId.prefix "gear"
    let gmm3 = _prefixId.prefix "gmm3"
    let grease = _prefixId.prefix "grease"
    let grinded = _prefixId.prefix "grinded"
    let h = _prefixId.prefix "h"
    let hPa = _prefixId.prefix "hPa"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : hasDocument^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between something and its related documents^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#hasDocument">tribont-core:hasDocument</a>
    /// </summary>
    let hasDocument = _prefixId.prefix "hasDocument"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : hasLocation^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/isCharacterisedBy^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between something and where it is located.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#hasLocation">tribont-core:hasLocation</a>
    /// </summary>
    let hasLocation = _prefixId.prefix "hasLocation"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : hasManufacturer^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between something and the company producing it.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#hasManufacturer">tribont-core:hasManufacturer</a>
    /// </summary>
    let hasManufacturer = _prefixId.prefix "hasManufacturer"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : hasOwner^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between something and the company that owns it.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#hasOwner">tribont-core:hasOwner</a>
    /// </summary>
    let hasOwner = _prefixId.prefix "hasOwner"
    let hb = _prefixId.prefix "hb"
    let hk = _prefixId.prefix "hk"
    let hour = _prefixId.prefix "hour"
    let hrb = _prefixId.prefix "hrb"
    let hrc = _prefixId.prefix "hrc"
    let hrm = _prefixId.prefix "hrm"
    let hrr = _prefixId.prefix "hrr"
    let hv = _prefixId.prefix "hv"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : i-ph^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : i-phof something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#i-ph">tribont-core:i-ph</a>
    /// </summary>
    let i_ph = _prefixId.prefix "i-ph"
    let in'_period_'lbfin2 = _prefixId.prefix "in.lbfin2"
    let in'_period_'lbfin3 = _prefixId.prefix "in.lbfin3"
    let in100ft = _prefixId.prefix "in100ft"
    let in2s = _prefixId.prefix "in2s"
    let inHg = _prefixId.prefix "inHg"
    let inin = _prefixId.prefix "inin"
    let inindegreeF = _prefixId.prefix "inindegreeF"
    let innert_gas = _prefixId.prefix "innert_gas"

    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : isCharacterisedByOperationCondition^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between a  SubjectOfInterest it characterises  (e.g. equipemnt or test) and a specified operation property characterisig it..^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#isCharacterisedByOperationCondition">tribont-core:isCharacterisedByOperationCondition</a>
    /// </summary>
    let isCharacterisedByOperationCondition = _prefixId.prefix "isCharacterisedByOperationCondition"

    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : isCharacterisedByOperationMeasure^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between a  SubjectOfInterest it characterises (e.g. equipemnt or test) and a measured operation property characterisig it..^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#isCharacterisedByOperationMeasure">tribont-core:isCharacterisedByOperationMeasure</a>
    /// </summary>
    let isCharacterisedByOperationMeasure = _prefixId.prefix "isCharacterisedByOperationMeasure"

    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : isCharacterisedByOutputMeasure^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between aSubjectOfInterest it characterises (e.g. equipemnt or test). and an output technical measurecgarcaterisg it.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#isCharacterisedByOutputMeasure">tribont-core:isCharacterisedByOutputMeasure</a>
    /// </summary>
    let isCharacterisedByOutputMeasure = _prefixId.prefix "isCharacterisedByOutputMeasure"

    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : isCompliedBy^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between a standard or procedure and what it regulates or formalise.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#isCompliedBy">tribont-core:isCompliedBy</a>
    /// </summary>
    let isCompliedBy = _prefixId.prefix "isCompliedBy"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : isDocumentFor^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between a document and what it provides information about.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#isDocumentFor">tribont-core:isDocumentFor</a>
    /// </summary>
    let isDocumentFor = _prefixId.prefix "isDocumentFor"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : isLocationFor^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/isCharacterisedBy^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between a physical location and  and something that is located there..^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#isLocationFor">tribont-core:isLocationFor</a>
    /// </summary>
    let isLocationFor = _prefixId.prefix "isLocationFor"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : isMadeOf^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between something and its component parts.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#isMadeOf">tribont-core:isMadeOf</a>
    /// </summary>
    let isMadeOf = _prefixId.prefix "isMadeOf"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : isManufacturerFor^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between between a company and what it produces.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#isManufacturerFor">tribont-core:isManufacturerFor</a>
    /// </summary>
    let isManufacturerFor = _prefixId.prefix "isManufacturerFor"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : isOwnerOf^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between an company and something it owns..^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#isOwnerOf">tribont-core:isOwnerOf</a>
    /// </summary>
    let isOwnerOf = _prefixId.prefix "isOwnerOf"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : isPartOf^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between a component part and that of which it is a part.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#isPartOf">tribont-core:isPartOf</a>
    /// </summary>
    let isPartOf = _prefixId.prefix "isPartOf"
    let kHz = _prefixId.prefix "kHz"
    let kJkg'_period_'degreeC = _prefixId.prefix "kJkg.degreeC"
    let kJm2 = _prefixId.prefix "kJm2"
    let kJm3 = _prefixId.prefix "kJm3"
    let kNcm2 = _prefixId.prefix "kNcm2"
    let kNm = _prefixId.prefix "kNm"
    let kg = _prefixId.prefix "kg"
    let kgfmm2 = _prefixId.prefix "kgfmm2"
    let kgm3 = _prefixId.prefix "kgm3"
    let kgmm3 = _prefixId.prefix "kgmm3"
    let km = _prefixId.prefix "km"
    let ksi = _prefixId.prefix "ksi"
    let ksi'_period_'in0'_period_'5 = _prefixId.prefix "ksi.in0.5"
    let kv = _prefixId.prefix "kv"
    let lapped = _prefixId.prefix "lapped"
    let lbf'_period_'ftlb'_period_'degreeF = _prefixId.prefix "lbf.ftlb.degreeF"
    let lbf'_period_'ftslug'_period_'degreeF = _prefixId.prefix "lbf.ftslug.degreeF"

    let lbf'_period_'in'_period_'inlbf'_period_'s2'_period_'degreeF = _prefixId.prefix "lbf.in.inlbf.s2.degreeF"

    let lbf'_period_'inlb'_period_'degreeF = _prefixId.prefix "lbf.inlb.degreeF"
    let lbf'_period_'s2in'_period_'in3 = _prefixId.prefix "lbf.s2in.in3"
    let lbfft = _prefixId.prefix "lbfft"
    let lbfft1'_period_'5 = _prefixId.prefix "lbfft1.5"
    let lbfft2 = _prefixId.prefix "lbfft2"
    let lbfin = _prefixId.prefix "lbfin"
    let lbfs'_period_'degreeF = _prefixId.prefix "lbfs.degreeF"
    let lbft3 = _prefixId.prefix "lbft3"
    let lbin3 = _prefixId.prefix "lbin3"
    let line = _prefixId.prefix "line"
    let linear_reciprocating = _prefixId.prefix "linear_reciprocating"
    let linear_unidirectional = _prefixId.prefix "linear_unidirectional"
    let liquid_lubricant = _prefixId.prefix "liquid_lubricant"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : longName^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : long name of somebody or something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#longName">tribont-core:longName</a>
    /// </summary>
    let longName = _prefixId.prefix "longName"
    let m = _prefixId.prefix "m"
    let m2s = _prefixId.prefix "m2s"
    let m3 = _prefixId.prefix "m3"
    let mNm = _prefixId.prefix "mNm"
    let mPa = _prefixId.prefix "mPa"
    let m_m = _prefixId.prefix "m_m"
    let mb = _prefixId.prefix "mb"
    let mg = _prefixId.prefix "mg"
    let mgm3 = _prefixId.prefix "mgm3"
    let microHz = _prefixId.prefix "microHz"
    let microinche = _prefixId.prefix "microinche"
    let microm = _prefixId.prefix "microm"
    let microm3 = _prefixId.prefix "microm3"
    let microstrain = _prefixId.prefix "microstrain"
    let microstraindegreeC = _prefixId.prefix "microstraindegreeC"
    let microstraindegreeF = _prefixId.prefix "microstraindegreeF"
    let mile = _prefixId.prefix "mile"
    let milisecond = _prefixId.prefix "milisecond"
    let min = _prefixId.prefix "min"
    let minute = _prefixId.prefix "minute"
    let mixed_lubrication = _prefixId.prefix "mixed_lubrication"
    let ml = _prefixId.prefix "ml"
    let mlml = _prefixId.prefix "mlml"
    let mm = _prefixId.prefix "mm"
    let mm2ms = _prefixId.prefix "mm2ms"
    let mm2s = _prefixId.prefix "mm2s"
    let mm3 = _prefixId.prefix "mm3"
    let mmmm = _prefixId.prefix "mmmm"
    let mms = _prefixId.prefix "mms"
    let mpa'_period_'m0'_period_'5 = _prefixId.prefix "mpa.m0.5"
    let mpa'_period_'mm0'_period_'5 = _prefixId.prefix "mpa.mm0.5"
    let ms = _prefixId.prefix "ms"
    let n103mbar = _prefixId.prefix "n103mbar"
    let n104straindegreeC = _prefixId.prefix "n104straindegreeC"
    let n106m2s = _prefixId.prefix "n106m2s"
    let n106psi = _prefixId.prefix "n106psi"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : name^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Name of somebody or something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#name">tribont-core:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    let nitrogen = _prefixId.prefix "nitrogen"
    let nmile = _prefixId.prefix "nmile"
    let nmm1'_period_'5 = _prefixId.prefix "nmm1.5"
    let no_lubricant = _prefixId.prefix "no_lubricant"
    let oil = _prefixId.prefix "oil"
    let pa'_period_'m0'_period_'5 = _prefixId.prefix "pa.m0.5"
    let percentage = _prefixId.prefix "percentage"
    let percentagestraindegreeF = _prefixId.prefix "percentagestraindegreeF"
    let percentangestraindegreeC = _prefixId.prefix "percentangestraindegreeC"
    let pin = _prefixId.prefix "pin"
    let pin_on_disc = _prefixId.prefix "pin_on_disc"
    let pintUk = _prefixId.prefix "pintUk"
    let pintUs = _prefixId.prefix "pintUs"
    let plate = _prefixId.prefix "plate"
    let point = _prefixId.prefix "point"
    let polished = _prefixId.prefix "polished"
    let ppb = _prefixId.prefix "ppb"
    let psi = _prefixId.prefix "psi"
    let psi'_period_'in0'_period_'5 = _prefixId.prefix "psi.in0.5"
    let radian = _prefixId.prefix "radian"
    let ring = _prefixId.prefix "ring"
    let ring_on_cylinder = _prefixId.prefix "ring_on_cylinder"
    let ring_on_disc = _prefixId.prefix "ring_on_disc"
    let rolling = _prefixId.prefix "rolling"
    let rotating_reciprocating = _prefixId.prefix "rotating_reciprocating"
    let rotating_unidirectional = _prefixId.prefix "rotating_unidirectional"
    let rpm = _prefixId.prefix "rpm"
    let seal = _prefixId.prefix "seal"
    let seal_on_shaft = _prefixId.prefix "seal_on_shaft"
    let second = _prefixId.prefix "second"
    let shaft = _prefixId.prefix "shaft"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : shortName^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/core^^xsd:string</para>
    ///   <para>rdfs:comment : Short name of somebody or something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/core#shortName">tribont-core:shortName</a>
    /// </summary>
    let shortName = _prefixId.prefix "shortName"
    let sliding = _prefixId.prefix "sliding"
    let sliding_wear = _prefixId.prefix "sliding_wear"
    let slip = _prefixId.prefix "slip"
    let slip_rolling_wear = _prefixId.prefix "slip_rolling_wear"
    let slugft3 = _prefixId.prefix "slugft3"
    let solid_friction = _prefixId.prefix "solid_friction"
    let solid_lubricant = _prefixId.prefix "solid_lubricant"
    let sonotrode = _prefixId.prefix "sonotrode"
    let sp_gr2323degreeC = _prefixId.prefix "sp-gr2323degreeC"
    let stick_slip = _prefixId.prefix "stick_slip"
    let strain = _prefixId.prefix "strain"
    let strain_percentage = _prefixId.prefix "strain_percentage"
    let straindegreeC = _prefixId.prefix "straindegreeC"
    let straindegreeF = _prefixId.prefix "straindegreeF"
    let synthetic_air = _prefixId.prefix "synthetic_air"
    let tonin3 = _prefixId.prefix "tonin3"
    let tonnemm3 = _prefixId.prefix "tonnemm3"
    let torr = _prefixId.prefix "torr"
    let tribocorrosive_wear = _prefixId.prefix "tribocorrosive_wear"
    let v = _prefixId.prefix "v"
    let vacuum = _prefixId.prefix "vacuum"
    let week = _prefixId.prefix "week"
    let wt_percentage = _prefixId.prefix "wt_percentage"
    let yd = _prefixId.prefix "yd"
    let year = _prefixId.prefix "year"
    let Å = _prefixId.prefix "Å"
