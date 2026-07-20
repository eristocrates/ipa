namespace http.dati.isprambiente.it.ontology.core.hash

open DoxAletheia

module ispra =
    let _namespace_name = "http://dati.isprambiente.it/ontology/core#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Instrument
    /// <see href="http://dati.isprambiente.it/ontology/core#Accelerometer"></see></summary>
    let Accelerometer = _prefix "Accelerometer"
    /// <summary>
    ///   <see href="http://dati.isprambiente.it/ontology/core#Instrument"></see>
    /// </summary>
    let Instrument = _prefix "Instrument"
    /// <summary>
    /// Meteorological Parameter
    /// <see href="http://dati.isprambiente.it/ontology/core#AirPres"></see></summary>
    let AirPres = _prefix "AirPres"
    /// <summary>
    ///   <see href="http://dati.isprambiente.it/ontology/core#Parameter"></see>
    /// </summary>
    let Parameter = _prefix "Parameter"
    /// <summary>
    /// Meteorological Parameter
    /// <see href="http://dati.isprambiente.it/ontology/core#AirTemp"></see></summary>
    let AirTemp = _prefix "AirTemp"
    /// <summary>
    /// Instrument
    /// <see href="http://dati.isprambiente.it/ontology/core#Anemometer"></see></summary>
    let Anemometer = _prefix "Anemometer"
    /// <summary>
    /// Involved authorities and role played.
    /// <see href="http://dati.isprambiente.it/ontology/core#AuthorityKind"></see></summary>
    let AuthorityKind = _prefix "AuthorityKind"
    /// <summary>
    /// Instrument
    /// <see href="http://dati.isprambiente.it/ontology/core#Barometer"></see></summary>
    let Barometer = _prefix "Barometer"
    /// <summary>
    /// Quality Parameter
    /// <see href="http://dati.isprambiente.it/ontology/core#Conductivity"></see></summary>
    let Conductivity = _prefix "Conductivity"
    /// <summary>
    ///   <see href="http://dati.isprambiente.it/ontology/core#Contract"></see>
    /// </summary>
    let Contract = _prefix "Contract"
    /// <summary>
    /// Parameter of the project economic framework.
    /// <see href="http://dati.isprambiente.it/ontology/core#EconomicIndicator"></see></summary>
    let EconomicIndicator = _prefix "EconomicIndicator"
    /// <summary>
    ///   <see href="http://dati.isprambiente.it/ontology/core#Indicator"></see>
    /// </summary>
    let Indicator = _prefix "Indicator"
    /// <summary>
    ///   <see href="http://dati.isprambiente.it/ontology/core#GeoFeature"></see>
    /// </summary>
    let GeoFeature = _prefix "GeoFeature"
    /// <summary>
    /// Instrument
    /// <see href="http://dati.isprambiente.it/ontology/core#Hydrometer"></see></summary>
    let Hydrometer = _prefix "Hydrometer"
    /// <summary>
    /// Oceanographic Parameter
    /// <see href="http://dati.isprambiente.it/ontology/core#HydrometricLevel"></see></summary>
    let HydrometricLevel = _prefix "HydrometricLevel"
    /// <summary>
    /// Instrument
    /// <see href="http://dati.isprambiente.it/ontology/core#Hygrometer"></see></summary>
    let Hygrometer = _prefix "Hygrometer"
    /// <summary>
    ///   <see href="http://dati.isprambiente.it/ontology/core#IndicatorCollection"></see>
    /// </summary>
    let IndicatorCollection = _prefix "IndicatorCollection"
    /// <summary>
    /// Type of instability phenomenon shown in the drawings or observed by site visit.
    /// <see href="http://dati.isprambiente.it/ontology/core#Instability"></see></summary>
    let Instability = _prefix "Instability"
    /// <summary>
    /// A single action, funded under a plan for hydrogeological risk mitigation. It may consist of one or more related projects.
    /// <see href="http://dati.isprambiente.it/ontology/core#Intervention"></see></summary>
    let Intervention = _prefix "Intervention"
    /// <summary>
    /// Lithology as stated in the project.
    /// <see href="http://dati.isprambiente.it/ontology/core#Lithology"></see></summary>
    let Lithology = _prefix "Lithology"
    /// <summary>
    ///   <see href="http://dati.isprambiente.it/ontology/core#LotStep"></see>
    /// </summary>
    let LotStep = _prefix "LotStep"
    /// <summary>
    ///   <see href="http://dati.isprambiente.it/ontology/core#MarineIndicator"></see>
    /// </summary>
    let MarineIndicator = _prefix "MarineIndicator"
    /// <summary>
    /// Facility with instruments and equipment for monitoring in a given place, for a determined period, relatively to its foundamental parameters.
    /// <see href="http://dati.isprambiente.it/ontology/core#MeasureStation"></see></summary>
    let MeasureStation = _prefix "MeasureStation"
    /// <summary>
    /// Set of measures and metadata in a specified period regarding an observed parameter (eg. Wind, Wave) in a given place
    /// <see href="http://dati.isprambiente.it/ontology/core#MeasurementCollection"></see></summary>
    let MeasurementCollection = _prefix "MeasurementCollection"
    /// <summary>
    /// Type of measuring station (ispra-core: Measure Station) including a set of its main characteristics (size, construction, etc.)
    /// <see href="http://dati.isprambiente.it/ontology/core#Model"></see></summary>
    let Model = _prefix "Model"
    /// <summary>
    /// Instrument
    /// <see href="http://dati.isprambiente.it/ontology/core#MultiParameterProbe"></see></summary>
    let MultiParameterProbe = _prefix "MultiParameterProbe"
    /// <summary>
    /// Quality Parameter
    /// <see href="http://dati.isprambiente.it/ontology/core#PH"></see></summary>
    let PH = _prefix "PH"
    /// <summary>
    /// TBC
    /// <see href="http://dati.isprambiente.it/ontology/core#Place"></see></summary>
    let Place = _prefix "Place"
    /// <summary>
    /// Quality Parameter
    /// <see href="http://dati.isprambiente.it/ontology/core#Redox"></see></summary>
    let Redox = _prefix "Redox"
    /// <summary>
    /// Meteorological Parameter
    /// <see href="http://dati.isprambiente.it/ontology/core#RelativeHumidity"></see></summary>
    let RelativeHumidity = _prefix "RelativeHumidity"
    /// <summary>
    /// Type of protection works.
    /// <see href="http://dati.isprambiente.it/ontology/core#Repair"></see></summary>
    let Repair = _prefix "Repair"
    /// <summary>
    ///   <see href="http://dati.isprambiente.it/ontology/core#SoilUseIndicator"></see>
    /// </summary>
    let SoilUseIndicator = _prefix "SoilUseIndicator"
    /// <summary>
    /// Oceanographic Parameter
    /// <see href="http://dati.isprambiente.it/ontology/core#Sst"></see></summary>
    let Sst = _prefix "Sst"
    /// <summary>
    /// Instrument
    /// <see href="http://dati.isprambiente.it/ontology/core#Termometer"></see></summary>
    let Termometer = _prefix "Termometer"
    /// <summary>
    /// Oceanographic Parameter
    /// <see href="http://dati.isprambiente.it/ontology/core#WaterTemperature"></see></summary>
    let WaterTemperature = _prefix "WaterTemperature"
    /// <summary>
    /// Oceanographic Parameter
    /// <see href="http://dati.isprambiente.it/ontology/core#Wave"></see></summary>
    let Wave = _prefix "Wave"
    /// <summary>
    /// Meteorological Parameter
    /// <see href="http://dati.isprambiente.it/ontology/core#Wind"></see></summary>
    let Wind = _prefix "Wind"
    /// <summary>
    /// Amount financed (in Euros)
    /// <see href="http://dati.isprambiente.it/ontology/core#amountFinanced"></see></summary>
    let amountFinanced = _prefix "amountFinanced"
    /// <summary>
    /// Frequency of final outputs (in Minutes or Hours)
    /// <see href="http://dati.isprambiente.it/ontology/core#averagingPeriod"></see></summary>
    let averagingPeriod = _prefix "averagingPeriod"
    /// <summary>
    ///   <see href="http://dati.isprambiente.it/ontology/core#belongsTo"></see>
    /// </summary>
    let belongsTo = _prefix "belongsTo"
    /// <summary>
    /// Certainty level of the observed data. It is defined as numerical scale starting from 0 (raw data). Eg L0, L1, L2, etc.
    /// <see href="http://dati.isprambiente.it/ontology/core#certainty"></see></summary>
    let certainty = _prefix "certainty"
    /// <summary>
    /// ID code of the measurement station as assigned by national or international organizations.
    /// <see href="http://dati.isprambiente.it/ontology/core#code"></see></summary>
    let code = _prefix "code"
    /// <summary>
    /// This property connects class contract with a generic entity involved, with specific role, in the contract.
    /// <see href="http://dati.isprambiente.it/ontology/core#contractingAuthority"></see></summary>
    let contractingAuthority = _prefix "contractingAuthority"
    /// <summary>
    /// It consists of a string of 15 alphanumeric characters, which accompanies each contract from the stage of formal resource allocation.
    /// <see href="http://dati.isprambiente.it/ontology/core#cup"></see></summary>
    let cup = _prefix "cup"
    /// <summary>
    /// Diameter of the measure station.
    /// <see href="http://dati.isprambiente.it/ontology/core#diameter"></see></summary>
    let diameter = _prefix "diameter"
    /// <summary>
    /// Directional resolution in degrees North (Omni-directional if 360ÃÂ°N).
    /// <see href="http://dati.isprambiente.it/ontology/core#directionalResolution"></see></summary>
    let directionalResolution = _prefix "directionalResolution"
    /// <summary>
    /// This property connects class AuthorityKind with the entity.
    /// <see href="http://dati.isprambiente.it/ontology/core#entity"></see></summary>
    let entity = _prefix "entity"
    /// <summary>
    /// Instruments that generate the measure.
    /// <see href="http://dati.isprambiente.it/ontology/core#generatedBy"></see></summary>
    let generatedBy = _prefix "generatedBy"
    /// <summary>
    /// This property connects the contract with its framework agreement.
    /// <see href="http://dati.isprambiente.it/ontology/core#hasAgreement"></see></summary>
    let hasAgreement = _prefix "hasAgreement"
    /// <summary>
    /// This property connects the Contract to its Economic Indicator
    /// <see href="http://dati.isprambiente.it/ontology/core#hasEconomicIndicator"></see></summary>
    let hasEconomicIndicator = _prefix "hasEconomicIndicator"
    /// <summary>
    /// This property connects the class Contract with its formal procedural steps.
    /// <see href="http://dati.isprambiente.it/ontology/core#hasIter"></see></summary>
    let hasIter = _prefix "hasIter"
    /// <summary>
    /// This property connects the Measure Station with its model.
    /// <see href="http://dati.isprambiente.it/ontology/core#hasModel"></see></summary>
    let hasModel = _prefix "hasModel"
    /// <summary>
    /// This property connects the Concept of the formal procedure with its relative steps.
    /// <see href="http://dati.isprambiente.it/ontology/core#hasStep"></see></summary>
    let hasStep = _prefix "hasStep"
    /// <summary>
    /// Hull type of the measure station.
    /// <see href="http://dati.isprambiente.it/ontology/core#hullType"></see></summary>
    let hullType = _prefix "hullType"
    /// <summary>
    ///   <see href="http://dati.isprambiente.it/ontology/core#instabilityGroup"></see>
    /// </summary>
    let instabilityGroup = _prefix "instabilityGroup"
    /// <summary>
    /// This property connects the class Instability to the contract.
    /// <see href="http://dati.isprambiente.it/ontology/core#instabilityRelatedTo"></see></summary>
    let instabilityRelatedTo = _prefix "instabilityRelatedTo"
    /// <summary>
    /// This property connects the class Instability to the more specific Concept of instability.
    /// <see href="http://dati.isprambiente.it/ontology/core#instabilityType"></see></summary>
    let instabilityType = _prefix "instabilityType"
    /// <summary>
    /// This property connects the measured data in a given period with an observed parameter (eg. Wind, Wave) in a given place.
    /// <see href="http://dati.isprambiente.it/ontology/core#isDataOf"></see></summary>
    let isDataOf = _prefix "isDataOf"
    /// <summary>
    /// Boolean property that states if the authority act as district authority.
    /// <see href="http://dati.isprambiente.it/ontology/core#isDistrictAuthority"></see></summary>
    let isDistrictAuthority = _prefix "isDistrictAuthority"
    /// <summary>
    /// This property connects the Lot to the Contract.
    /// <see href="http://dati.isprambiente.it/ontology/core#isLotOf"></see></summary>
    let isLotOf = _prefix "isLotOf"
    /// <summary>
    /// Boolean value identifing the primary measuring instrument (TRUE) and any secondary instruments (FALSE) used in case of malfunctions or for backup and validation.
    /// <see href="http://dati.isprambiente.it/ontology/core#isPrimary"></see></summary>
    let isPrimary = _prefix "isPrimary"
    /// <summary>
    ///   <see href="http://dati.isprambiente.it/ontology/core#iterStepType"></see>
    /// </summary>
    let iterStepType = _prefix "iterStepType"
    /// <summary>
    /// Levelling activity useful to the definition of the referring level.
    /// <see href="http://dati.isprambiente.it/ontology/core#levelling"></see></summary>
    let levelling = _prefix "levelling"
    /// <summary>
    /// Time (Year) of the levelling activities.
    /// <see href="http://dati.isprambiente.it/ontology/core#levellingTime"></see></summary>
    let levellingTime = _prefix "levellingTime"
    /// <summary>
    /// This property connects the Lithology to the Contract.
    /// <see href="http://dati.isprambiente.it/ontology/core#lithologyRelatedTo"></see></summary>
    let lithologyRelatedTo = _prefix "lithologyRelatedTo"
    /// <summary>
    /// This property connects the Lithology to the specific concept.
    /// <see href="http://dati.isprambiente.it/ontology/core#lithologyType"></see></summary>
    let lithologyType = _prefix "lithologyType"
    /// <summary>
    /// Place in which the station is installed (in the case of tide gauges this place is related to the sea area in front of the station).
    /// <see href="http://dati.isprambiente.it/ontology/core#location"></see></summary>
    let location = _prefix "location"
    /// <summary>
    /// This property connects the class Lot Step to the contract.
    /// <see href="http://dati.isprambiente.it/ontology/core#lot"></see></summary>
    let lot = _prefix "lot"
    /// <summary>
    /// Manufacter and model of the measure station.
    /// <see href="http://dati.isprambiente.it/ontology/core#manufacturer"></see></summary>
    let manufacturer = _prefix "manufacturer"
    /// <summary>
    /// It identifies the instrument located in a station in a given place that measures a parameter (eg. Wind, Wave).
    /// <see href="http://dati.isprambiente.it/ontology/core#measuredBy"></see></summary>
    let measuredBy = _prefix "measuredBy"
    /// <summary>
    /// Instrument height above the reference level.
    /// <see href="http://dati.isprambiente.it/ontology/core#measurementHeight"></see></summary>
    let measurementHeight = _prefix "measurementHeight"
    /// <summary>
    /// Measurement Period related to the measure (Month-Year).
    /// <see href="http://dati.isprambiente.it/ontology/core#measurementPeriod"></see></summary>
    let measurementPeriod = _prefix "measurementPeriod"
    /// <summary>
    /// It connects the measure station with the observed parameter (eg. Wind, Wave) in a given place.
    /// <see href="http://dati.isprambiente.it/ontology/core#measures"></see></summary>
    let measures = _prefix "measures"
    /// <summary>
    /// Mooring type of the measure station.
    /// <see href="http://dati.isprambiente.it/ontology/core#mooringType"></see></summary>
    let mooringType = _prefix "mooringType"
    /// <summary>
    /// Type of instability declared in the decree
    /// <see href="http://dati.isprambiente.it/ontology/core#officialInstabilityType"></see></summary>
    let officialInstabilityType = _prefix "officialInstabilityType"
    /// <summary>
    /// It indicates the operational status of the measure station (Operational, Ceased, etc.).
    /// <see href="http://dati.isprambiente.it/ontology/core#operationalStatus"></see></summary>
    let operationalStatus = _prefix "operationalStatus"
    /// <summary>
    /// Set of parameters measured by the instrument.
    /// <see href="http://dati.isprambiente.it/ontology/core#parameterReported"></see></summary>
    let parameterReported = _prefix "parameterReported"
    /// <summary>
    ///   <see href="http://dati.isprambiente.it/ontology/core#phase"></see>
    /// </summary>
    let phase = _prefix "phase"
    /// <summary>
    /// Measure station that includes the instrument.
    /// <see href="http://dati.isprambiente.it/ontology/core#placedOn"></see></summary>
    let placedOn = _prefix "placedOn"
    /// <summary>
    /// Positioning System installed on the measure station.
    /// <see href="http://dati.isprambiente.it/ontology/core#positioningSystem"></see></summary>
    let positioningSystem = _prefix "positioningSystem"
    /// <summary>
    /// Primary geographical feature of a Contract
    /// <see href="http://dati.isprambiente.it/ontology/core#primaryGeographicalFeature"></see></summary>
    let primaryGeographicalFeature = _prefix "primaryGeographicalFeature"
    /// <summary>
    ///   <see href="http://dati.isprambiente.it/ontology/core#repairCategory"></see>
    /// </summary>
    let repairCategory = _prefix "repairCategory"
    /// <summary>
    ///   <see href="http://dati.isprambiente.it/ontology/core#repairGroup"></see>
    /// </summary>
    let repairGroup = _prefix "repairGroup"
    /// <summary>
    /// This property connects the Repair to the Contract.
    /// <see href="http://dati.isprambiente.it/ontology/core#repairRelatedTo"></see></summary>
    let repairRelatedTo = _prefix "repairRelatedTo"
    /// <summary>
    /// This property connects the Repair to a concept of a specific vocabulary.
    /// <see href="http://dati.isprambiente.it/ontology/core#repairType"></see></summary>
    let repairType = _prefix "repairType"
    /// <summary>
    /// The role of Entity in Authority kind class.
    /// <see href="http://dati.isprambiente.it/ontology/core#role"></see></summary>
    let role = _prefix "role"
    /// <summary>
    /// Secondary geographical feature of a Contract
    /// <see href="http://dati.isprambiente.it/ontology/core#secondaryGeographicalFeature"></see></summary>
    let secondaryGeographicalFeature = _prefix "secondaryGeographicalFeature"
    /// <summary>
    /// Sensor/Instrument Model.
    /// <see href="http://dati.isprambiente.it/ontology/core#sensorModel"></see></summary>
    let sensorModel = _prefix "sensorModel"
    /// <summary>
    /// Observation sampling of the instrumen (in hertz).
    /// <see href="http://dati.isprambiente.it/ontology/core#sensorSamplingFrequency"></see></summary>
    let sensorSamplingFrequency = _prefix "sensorSamplingFrequency"
    /// <summary>
    /// Material or building type of the measure station.
    /// <see href="http://dati.isprambiente.it/ontology/core#structure"></see></summary>
    let structure = _prefix "structure"
    /// <summary>
    /// Type of Data Station.
    /// <see href="http://dati.isprambiente.it/ontology/core#typeOfDataStation"></see></summary>
    let typeOfDataStation = _prefix "typeOfDataStation"
    /// <summary>
    /// Wave height parameters reported by the instrument.
    /// <see href="http://dati.isprambiente.it/ontology/core#waveHeightReported"></see></summary>
    let waveHeightReported = _prefix "waveHeightReported"
    /// <summary>
    /// Wave period parameters reported by the instrument.
    /// <see href="http://dati.isprambiente.it/ontology/core#wavePeriodReported"></see></summary>
    let wavePeriodReported = _prefix "wavePeriodReported"
    /// <summary>
    /// It connects the intrument with the analogous concept as defined by WMO.
    /// <see href="http://dati.isprambiente.it/ontology/core#wmoSensorCode"></see></summary>
    let wmoSensorCode = _prefix "wmoSensorCode"
