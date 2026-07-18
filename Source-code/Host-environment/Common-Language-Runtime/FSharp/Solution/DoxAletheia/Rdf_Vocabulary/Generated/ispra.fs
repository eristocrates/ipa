namespace http.dati.isprambiente.it.ontology.core.hash

open DoxAletheia.Rdf_Vocabulary

module ispra =
    let _namespace_name = "http://dati.isprambiente.it/ontology/core#"

    /// <summary>
    /// Instrument
    /// <see href="http://dati.isprambiente.it/ontology/core#Accelerometer"></see></summary>
    let Accelerometer =
        Namespaced_IRI.parse _namespace_name "Accelerometer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.isprambiente.it/ontology/core#Instrument"></see>
    /// </summary>
    let Instrument = Namespaced_IRI.parse _namespace_name "Instrument" |> NamespacedName
    /// <summary>
    /// Meteorological Parameter
    /// <see href="http://dati.isprambiente.it/ontology/core#AirPres"></see></summary>
    let AirPres = Namespaced_IRI.parse _namespace_name "AirPres" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.isprambiente.it/ontology/core#Parameter"></see>
    /// </summary>
    let Parameter = Namespaced_IRI.parse _namespace_name "Parameter" |> NamespacedName
    /// <summary>
    /// Meteorological Parameter
    /// <see href="http://dati.isprambiente.it/ontology/core#AirTemp"></see></summary>
    let AirTemp = Namespaced_IRI.parse _namespace_name "AirTemp" |> NamespacedName
    /// <summary>
    /// Instrument
    /// <see href="http://dati.isprambiente.it/ontology/core#Anemometer"></see></summary>
    let Anemometer = Namespaced_IRI.parse _namespace_name "Anemometer" |> NamespacedName

    /// <summary>
    /// Involved authorities and role played.
    /// <see href="http://dati.isprambiente.it/ontology/core#AuthorityKind"></see></summary>
    let AuthorityKind =
        Namespaced_IRI.parse _namespace_name "AuthorityKind" |> NamespacedName

    /// <summary>
    /// Instrument
    /// <see href="http://dati.isprambiente.it/ontology/core#Barometer"></see></summary>
    let Barometer = Namespaced_IRI.parse _namespace_name "Barometer" |> NamespacedName

    /// <summary>
    /// Quality Parameter
    /// <see href="http://dati.isprambiente.it/ontology/core#Conductivity"></see></summary>
    let Conductivity =
        Namespaced_IRI.parse _namespace_name "Conductivity" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.isprambiente.it/ontology/core#Contract"></see>
    /// </summary>
    let Contract = Namespaced_IRI.parse _namespace_name "Contract" |> NamespacedName

    /// <summary>
    /// Parameter of the project economic framework.
    /// <see href="http://dati.isprambiente.it/ontology/core#EconomicIndicator"></see></summary>
    let EconomicIndicator =
        Namespaced_IRI.parse _namespace_name "EconomicIndicator" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.isprambiente.it/ontology/core#Indicator"></see>
    /// </summary>
    let Indicator = Namespaced_IRI.parse _namespace_name "Indicator" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.isprambiente.it/ontology/core#GeoFeature"></see>
    /// </summary>
    let GeoFeature = Namespaced_IRI.parse _namespace_name "GeoFeature" |> NamespacedName
    /// <summary>
    /// Instrument
    /// <see href="http://dati.isprambiente.it/ontology/core#Hydrometer"></see></summary>
    let Hydrometer = Namespaced_IRI.parse _namespace_name "Hydrometer" |> NamespacedName

    /// <summary>
    /// Oceanographic Parameter
    /// <see href="http://dati.isprambiente.it/ontology/core#HydrometricLevel"></see></summary>
    let HydrometricLevel =
        Namespaced_IRI.parse _namespace_name "HydrometricLevel" |> NamespacedName

    /// <summary>
    /// Instrument
    /// <see href="http://dati.isprambiente.it/ontology/core#Hygrometer"></see></summary>
    let Hygrometer = Namespaced_IRI.parse _namespace_name "Hygrometer" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.isprambiente.it/ontology/core#IndicatorCollection"></see>
    /// </summary>
    let IndicatorCollection =
        Namespaced_IRI.parse _namespace_name "IndicatorCollection" |> NamespacedName

    /// <summary>
    /// Type of instability phenomenon shown in the drawings or observed by site visit.
    /// <see href="http://dati.isprambiente.it/ontology/core#Instability"></see></summary>
    let Instability =
        Namespaced_IRI.parse _namespace_name "Instability" |> NamespacedName

    /// <summary>
    /// A single action, funded under a plan for hydrogeological risk mitigation. It may consist of one or more related projects.
    /// <see href="http://dati.isprambiente.it/ontology/core#Intervention"></see></summary>
    let Intervention =
        Namespaced_IRI.parse _namespace_name "Intervention" |> NamespacedName

    /// <summary>
    /// Lithology as stated in the project.
    /// <see href="http://dati.isprambiente.it/ontology/core#Lithology"></see></summary>
    let Lithology = Namespaced_IRI.parse _namespace_name "Lithology" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.isprambiente.it/ontology/core#LotStep"></see>
    /// </summary>
    let LotStep = Namespaced_IRI.parse _namespace_name "LotStep" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.isprambiente.it/ontology/core#MarineIndicator"></see>
    /// </summary>
    let MarineIndicator =
        Namespaced_IRI.parse _namespace_name "MarineIndicator" |> NamespacedName

    /// <summary>
    /// Facility with instruments and equipment for monitoring in a given place, for a determined period, relatively to its foundamental parameters.
    /// <see href="http://dati.isprambiente.it/ontology/core#MeasureStation"></see></summary>
    let MeasureStation =
        Namespaced_IRI.parse _namespace_name "MeasureStation" |> NamespacedName

    /// <summary>
    /// Set of measures and metadata in a specified period regarding an observed parameter (eg. Wind, Wave) in a given place
    /// <see href="http://dati.isprambiente.it/ontology/core#MeasurementCollection"></see></summary>
    let MeasurementCollection =
        Namespaced_IRI.parse _namespace_name "MeasurementCollection" |> NamespacedName

    /// <summary>
    /// Type of measuring station (ispra-core: Measure Station) including a set of its main characteristics (size, construction, etc.)
    /// <see href="http://dati.isprambiente.it/ontology/core#Model"></see></summary>
    let Model = Namespaced_IRI.parse _namespace_name "Model" |> NamespacedName

    /// <summary>
    /// Instrument
    /// <see href="http://dati.isprambiente.it/ontology/core#MultiParameterProbe"></see></summary>
    let MultiParameterProbe =
        Namespaced_IRI.parse _namespace_name "MultiParameterProbe" |> NamespacedName

    /// <summary>
    /// Quality Parameter
    /// <see href="http://dati.isprambiente.it/ontology/core#PH"></see></summary>
    let PH = Namespaced_IRI.parse _namespace_name "PH" |> NamespacedName
    /// <summary>
    /// TBC
    /// <see href="http://dati.isprambiente.it/ontology/core#Place"></see></summary>
    let Place = Namespaced_IRI.parse _namespace_name "Place" |> NamespacedName
    /// <summary>
    /// Quality Parameter
    /// <see href="http://dati.isprambiente.it/ontology/core#Redox"></see></summary>
    let Redox = Namespaced_IRI.parse _namespace_name "Redox" |> NamespacedName

    /// <summary>
    /// Meteorological Parameter
    /// <see href="http://dati.isprambiente.it/ontology/core#RelativeHumidity"></see></summary>
    let RelativeHumidity =
        Namespaced_IRI.parse _namespace_name "RelativeHumidity" |> NamespacedName

    /// <summary>
    /// Type of protection works.
    /// <see href="http://dati.isprambiente.it/ontology/core#Repair"></see></summary>
    let Repair = Namespaced_IRI.parse _namespace_name "Repair" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.isprambiente.it/ontology/core#SoilUseIndicator"></see>
    /// </summary>
    let SoilUseIndicator =
        Namespaced_IRI.parse _namespace_name "SoilUseIndicator" |> NamespacedName

    /// <summary>
    /// Oceanographic Parameter
    /// <see href="http://dati.isprambiente.it/ontology/core#Sst"></see></summary>
    let Sst = Namespaced_IRI.parse _namespace_name "Sst" |> NamespacedName
    /// <summary>
    /// Instrument
    /// <see href="http://dati.isprambiente.it/ontology/core#Termometer"></see></summary>
    let Termometer = Namespaced_IRI.parse _namespace_name "Termometer" |> NamespacedName

    /// <summary>
    /// Oceanographic Parameter
    /// <see href="http://dati.isprambiente.it/ontology/core#WaterTemperature"></see></summary>
    let WaterTemperature =
        Namespaced_IRI.parse _namespace_name "WaterTemperature" |> NamespacedName

    /// <summary>
    /// Oceanographic Parameter
    /// <see href="http://dati.isprambiente.it/ontology/core#Wave"></see></summary>
    let Wave = Namespaced_IRI.parse _namespace_name "Wave" |> NamespacedName
    /// <summary>
    /// Meteorological Parameter
    /// <see href="http://dati.isprambiente.it/ontology/core#Wind"></see></summary>
    let Wind = Namespaced_IRI.parse _namespace_name "Wind" |> NamespacedName

    /// <summary>
    /// Amount financed (in Euros)
    /// <see href="http://dati.isprambiente.it/ontology/core#amountFinanced"></see></summary>
    let amountFinanced =
        Namespaced_IRI.parse _namespace_name "amountFinanced" |> NamespacedName

    /// <summary>
    /// Frequency of final outputs (in Minutes or Hours)
    /// <see href="http://dati.isprambiente.it/ontology/core#averagingPeriod"></see></summary>
    let averagingPeriod =
        Namespaced_IRI.parse _namespace_name "averagingPeriod" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.isprambiente.it/ontology/core#belongsTo"></see>
    /// </summary>
    let belongsTo = Namespaced_IRI.parse _namespace_name "belongsTo" |> NamespacedName
    /// <summary>
    /// Certainty level of the observed data. It is defined as numerical scale starting from 0 (raw data). Eg L0, L1, L2, etc.
    /// <see href="http://dati.isprambiente.it/ontology/core#certainty"></see></summary>
    let certainty = Namespaced_IRI.parse _namespace_name "certainty" |> NamespacedName
    /// <summary>
    /// ID code of the measurement station as assigned by national or international organizations.
    /// <see href="http://dati.isprambiente.it/ontology/core#code"></see></summary>
    let code = Namespaced_IRI.parse _namespace_name "code" |> NamespacedName

    /// <summary>
    /// This property connects class contract with a generic entity involved, with specific role, in the contract.
    /// <see href="http://dati.isprambiente.it/ontology/core#contractingAuthority"></see></summary>
    let contractingAuthority =
        Namespaced_IRI.parse _namespace_name "contractingAuthority" |> NamespacedName

    /// <summary>
    /// It consists of a string of 15 alphanumeric characters, which accompanies each contract from the stage of formal resource allocation.
    /// <see href="http://dati.isprambiente.it/ontology/core#cup"></see></summary>
    let cup = Namespaced_IRI.parse _namespace_name "cup" |> NamespacedName
    /// <summary>
    /// Diameter of the measure station.
    /// <see href="http://dati.isprambiente.it/ontology/core#diameter"></see></summary>
    let diameter = Namespaced_IRI.parse _namespace_name "diameter" |> NamespacedName

    /// <summary>
    /// Directional resolution in degrees North (Omni-directional if 360ÃÂ°N).
    /// <see href="http://dati.isprambiente.it/ontology/core#directionalResolution"></see></summary>
    let directionalResolution =
        Namespaced_IRI.parse _namespace_name "directionalResolution" |> NamespacedName

    /// <summary>
    /// This property connects class AuthorityKind with the entity.
    /// <see href="http://dati.isprambiente.it/ontology/core#entity"></see></summary>
    let entity = Namespaced_IRI.parse _namespace_name "entity" |> NamespacedName

    /// <summary>
    /// Instruments that generate the measure.
    /// <see href="http://dati.isprambiente.it/ontology/core#generatedBy"></see></summary>
    let generatedBy =
        Namespaced_IRI.parse _namespace_name "generatedBy" |> NamespacedName

    /// <summary>
    /// This property connects the contract with its framework agreement.
    /// <see href="http://dati.isprambiente.it/ontology/core#hasAgreement"></see></summary>
    let hasAgreement =
        Namespaced_IRI.parse _namespace_name "hasAgreement" |> NamespacedName

    /// <summary>
    /// This property connects the Contract to its Economic Indicator
    /// <see href="http://dati.isprambiente.it/ontology/core#hasEconomicIndicator"></see></summary>
    let hasEconomicIndicator =
        Namespaced_IRI.parse _namespace_name "hasEconomicIndicator" |> NamespacedName

    /// <summary>
    /// This property connects the class Contract with its formal procedural steps.
    /// <see href="http://dati.isprambiente.it/ontology/core#hasIter"></see></summary>
    let hasIter = Namespaced_IRI.parse _namespace_name "hasIter" |> NamespacedName
    /// <summary>
    /// This property connects the Measure Station with its model.
    /// <see href="http://dati.isprambiente.it/ontology/core#hasModel"></see></summary>
    let hasModel = Namespaced_IRI.parse _namespace_name "hasModel" |> NamespacedName
    /// <summary>
    /// This property connects the Concept of the formal procedure with its relative steps.
    /// <see href="http://dati.isprambiente.it/ontology/core#hasStep"></see></summary>
    let hasStep = Namespaced_IRI.parse _namespace_name "hasStep" |> NamespacedName
    /// <summary>
    /// Hull type of the measure station.
    /// <see href="http://dati.isprambiente.it/ontology/core#hullType"></see></summary>
    let hullType = Namespaced_IRI.parse _namespace_name "hullType" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.isprambiente.it/ontology/core#instabilityGroup"></see>
    /// </summary>
    let instabilityGroup =
        Namespaced_IRI.parse _namespace_name "instabilityGroup" |> NamespacedName

    /// <summary>
    /// This property connects the class Instability to the contract.
    /// <see href="http://dati.isprambiente.it/ontology/core#instabilityRelatedTo"></see></summary>
    let instabilityRelatedTo =
        Namespaced_IRI.parse _namespace_name "instabilityRelatedTo" |> NamespacedName

    /// <summary>
    /// This property connects the class Instability to the more specific Concept of instability.
    /// <see href="http://dati.isprambiente.it/ontology/core#instabilityType"></see></summary>
    let instabilityType =
        Namespaced_IRI.parse _namespace_name "instabilityType" |> NamespacedName

    /// <summary>
    /// This property connects the measured data in a given period with an observed parameter (eg. Wind, Wave) in a given place.
    /// <see href="http://dati.isprambiente.it/ontology/core#isDataOf"></see></summary>
    let isDataOf = Namespaced_IRI.parse _namespace_name "isDataOf" |> NamespacedName

    /// <summary>
    /// Boolean property that states if the authority act as district authority.
    /// <see href="http://dati.isprambiente.it/ontology/core#isDistrictAuthority"></see></summary>
    let isDistrictAuthority =
        Namespaced_IRI.parse _namespace_name "isDistrictAuthority" |> NamespacedName

    /// <summary>
    /// This property connects the Lot to the Contract.
    /// <see href="http://dati.isprambiente.it/ontology/core#isLotOf"></see></summary>
    let isLotOf = Namespaced_IRI.parse _namespace_name "isLotOf" |> NamespacedName
    /// <summary>
    /// Boolean value identifing the primary measuring instrument (TRUE) and any secondary instruments (FALSE) used in case of malfunctions or for backup and validation.
    /// <see href="http://dati.isprambiente.it/ontology/core#isPrimary"></see></summary>
    let isPrimary = Namespaced_IRI.parse _namespace_name "isPrimary" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.isprambiente.it/ontology/core#iterStepType"></see>
    /// </summary>
    let iterStepType =
        Namespaced_IRI.parse _namespace_name "iterStepType" |> NamespacedName

    /// <summary>
    /// Levelling activity useful to the definition of the referring level.
    /// <see href="http://dati.isprambiente.it/ontology/core#levelling"></see></summary>
    let levelling = Namespaced_IRI.parse _namespace_name "levelling" |> NamespacedName

    /// <summary>
    /// Time (Year) of the levelling activities.
    /// <see href="http://dati.isprambiente.it/ontology/core#levellingTime"></see></summary>
    let levellingTime =
        Namespaced_IRI.parse _namespace_name "levellingTime" |> NamespacedName

    /// <summary>
    /// This property connects the Lithology to the Contract.
    /// <see href="http://dati.isprambiente.it/ontology/core#lithologyRelatedTo"></see></summary>
    let lithologyRelatedTo =
        Namespaced_IRI.parse _namespace_name "lithologyRelatedTo" |> NamespacedName

    /// <summary>
    /// This property connects the Lithology to the specific concept.
    /// <see href="http://dati.isprambiente.it/ontology/core#lithologyType"></see></summary>
    let lithologyType =
        Namespaced_IRI.parse _namespace_name "lithologyType" |> NamespacedName

    /// <summary>
    /// Place in which the station is installed (in the case of tide gauges this place is related to the sea area in front of the station).
    /// <see href="http://dati.isprambiente.it/ontology/core#location"></see></summary>
    let location = Namespaced_IRI.parse _namespace_name "location" |> NamespacedName
    /// <summary>
    /// This property connects the class Lot Step to the contract.
    /// <see href="http://dati.isprambiente.it/ontology/core#lot"></see></summary>
    let lot = Namespaced_IRI.parse _namespace_name "lot" |> NamespacedName

    /// <summary>
    /// Manufacter and model of the measure station.
    /// <see href="http://dati.isprambiente.it/ontology/core#manufacturer"></see></summary>
    let manufacturer =
        Namespaced_IRI.parse _namespace_name "manufacturer" |> NamespacedName

    /// <summary>
    /// It identifies the instrument located in a station in a given place that measures a parameter (eg. Wind, Wave).
    /// <see href="http://dati.isprambiente.it/ontology/core#measuredBy"></see></summary>
    let measuredBy = Namespaced_IRI.parse _namespace_name "measuredBy" |> NamespacedName

    /// <summary>
    /// Instrument height above the reference level.
    /// <see href="http://dati.isprambiente.it/ontology/core#measurementHeight"></see></summary>
    let measurementHeight =
        Namespaced_IRI.parse _namespace_name "measurementHeight" |> NamespacedName

    /// <summary>
    /// Measurement Period related to the measure (Month-Year).
    /// <see href="http://dati.isprambiente.it/ontology/core#measurementPeriod"></see></summary>
    let measurementPeriod =
        Namespaced_IRI.parse _namespace_name "measurementPeriod" |> NamespacedName

    /// <summary>
    /// It connects the measure station with the observed parameter (eg. Wind, Wave) in a given place.
    /// <see href="http://dati.isprambiente.it/ontology/core#measures"></see></summary>
    let measures = Namespaced_IRI.parse _namespace_name "measures" |> NamespacedName

    /// <summary>
    /// Mooring type of the measure station.
    /// <see href="http://dati.isprambiente.it/ontology/core#mooringType"></see></summary>
    let mooringType =
        Namespaced_IRI.parse _namespace_name "mooringType" |> NamespacedName

    /// <summary>
    /// Type of instability declared in the decree
    /// <see href="http://dati.isprambiente.it/ontology/core#officialInstabilityType"></see></summary>
    let officialInstabilityType =
        Namespaced_IRI.parse _namespace_name "officialInstabilityType" |> NamespacedName

    /// <summary>
    /// It indicates the operational status of the measure station (Operational, Ceased, etc.).
    /// <see href="http://dati.isprambiente.it/ontology/core#operationalStatus"></see></summary>
    let operationalStatus =
        Namespaced_IRI.parse _namespace_name "operationalStatus" |> NamespacedName

    /// <summary>
    /// Set of parameters measured by the instrument.
    /// <see href="http://dati.isprambiente.it/ontology/core#parameterReported"></see></summary>
    let parameterReported =
        Namespaced_IRI.parse _namespace_name "parameterReported" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.isprambiente.it/ontology/core#phase"></see>
    /// </summary>
    let phase = Namespaced_IRI.parse _namespace_name "phase" |> NamespacedName
    /// <summary>
    /// Measure station that includes the instrument.
    /// <see href="http://dati.isprambiente.it/ontology/core#placedOn"></see></summary>
    let placedOn = Namespaced_IRI.parse _namespace_name "placedOn" |> NamespacedName

    /// <summary>
    /// Positioning System installed on the measure station.
    /// <see href="http://dati.isprambiente.it/ontology/core#positioningSystem"></see></summary>
    let positioningSystem =
        Namespaced_IRI.parse _namespace_name "positioningSystem" |> NamespacedName

    /// <summary>
    /// Primary geographical feature of a Contract
    /// <see href="http://dati.isprambiente.it/ontology/core#primaryGeographicalFeature"></see></summary>
    let primaryGeographicalFeature =
        Namespaced_IRI.parse _namespace_name "primaryGeographicalFeature" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.isprambiente.it/ontology/core#repairCategory"></see>
    /// </summary>
    let repairCategory =
        Namespaced_IRI.parse _namespace_name "repairCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.isprambiente.it/ontology/core#repairGroup"></see>
    /// </summary>
    let repairGroup =
        Namespaced_IRI.parse _namespace_name "repairGroup" |> NamespacedName

    /// <summary>
    /// This property connects the Repair to the Contract.
    /// <see href="http://dati.isprambiente.it/ontology/core#repairRelatedTo"></see></summary>
    let repairRelatedTo =
        Namespaced_IRI.parse _namespace_name "repairRelatedTo" |> NamespacedName

    /// <summary>
    /// This property connects the Repair to a concept of a specific vocabulary.
    /// <see href="http://dati.isprambiente.it/ontology/core#repairType"></see></summary>
    let repairType = Namespaced_IRI.parse _namespace_name "repairType" |> NamespacedName
    /// <summary>
    /// The role of Entity in Authority kind class.
    /// <see href="http://dati.isprambiente.it/ontology/core#role"></see></summary>
    let role = Namespaced_IRI.parse _namespace_name "role" |> NamespacedName

    /// <summary>
    /// Secondary geographical feature of a Contract
    /// <see href="http://dati.isprambiente.it/ontology/core#secondaryGeographicalFeature"></see></summary>
    let secondaryGeographicalFeature =
        Namespaced_IRI.parse _namespace_name "secondaryGeographicalFeature" |> NamespacedName

    /// <summary>
    /// Sensor/Instrument Model.
    /// <see href="http://dati.isprambiente.it/ontology/core#sensorModel"></see></summary>
    let sensorModel =
        Namespaced_IRI.parse _namespace_name "sensorModel" |> NamespacedName

    /// <summary>
    /// Observation sampling of the instrumen (in hertz).
    /// <see href="http://dati.isprambiente.it/ontology/core#sensorSamplingFrequency"></see></summary>
    let sensorSamplingFrequency =
        Namespaced_IRI.parse _namespace_name "sensorSamplingFrequency" |> NamespacedName

    /// <summary>
    /// Material or building type of the measure station.
    /// <see href="http://dati.isprambiente.it/ontology/core#structure"></see></summary>
    let structure = Namespaced_IRI.parse _namespace_name "structure" |> NamespacedName

    /// <summary>
    /// Type of Data Station.
    /// <see href="http://dati.isprambiente.it/ontology/core#typeOfDataStation"></see></summary>
    let typeOfDataStation =
        Namespaced_IRI.parse _namespace_name "typeOfDataStation" |> NamespacedName

    /// <summary>
    /// Wave height parameters reported by the instrument.
    /// <see href="http://dati.isprambiente.it/ontology/core#waveHeightReported"></see></summary>
    let waveHeightReported =
        Namespaced_IRI.parse _namespace_name "waveHeightReported" |> NamespacedName

    /// <summary>
    /// Wave period parameters reported by the instrument.
    /// <see href="http://dati.isprambiente.it/ontology/core#wavePeriodReported"></see></summary>
    let wavePeriodReported =
        Namespaced_IRI.parse _namespace_name "wavePeriodReported" |> NamespacedName

    /// <summary>
    /// It connects the intrument with the analogous concept as defined by WMO.
    /// <see href="http://dati.isprambiente.it/ontology/core#wmoSensorCode"></see></summary>
    let wmoSensorCode =
        Namespaced_IRI.parse _namespace_name "wmoSensorCode" |> NamespacedName
