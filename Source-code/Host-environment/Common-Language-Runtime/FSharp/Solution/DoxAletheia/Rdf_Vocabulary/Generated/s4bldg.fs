namespace https.saref.etsi.org.saref4bldg.slash

open DoxAletheia

module s4bldg =
    let _namespace_name = "https://saref.etsi.org/saref4bldg/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A building represents a structure that provides shelter for its occupants or contents and stands in one place. The building is also used to provide a basic element within the spatial structure hierarchy for the components of a building project (together with site, storey, and space).
    /// <see href="https://saref.etsi.org/saref4bldg/Building"></see></summary>
    let Building = _prefix "Building"
    /// <summary>
    /// An entity used to define the physical spaces of the building. A building space contains devices or building objects.
    /// <see href="https://saref.etsi.org/saref4bldg/BuildingSpace"></see></summary>
    let BuildingSpace = _prefix "BuildingSpace"
    /// <summary>
    /// Any Object that has a proper space region.  (Definition extracted from DUL ontology)
    /// <see href="https://saref.etsi.org/saref4bldg/PhysicalObject"></see></summary>
    let PhysicalObject = _prefix "PhysicalObject"
    /// <summary>
    ///   <see href="https://saref.etsi.org/saref4bldg/v1.1.2/"></see>
    /// </summary>
    let ``v1.1.2/`` = _prefix "v1.1.2/"
    /// <summary>
    /// An actuator is a mechanical device for moving or controlling a mechanism or system. An actuator takes energy, usually created by air, electricity, or liquid, and converts that into some kind of motion.
    /// <see href="https://saref.etsi.org/saref4bldg/Actuator"></see></summary>
    let Actuator = _prefix "Actuator"
    /// <summary>
    /// Identifies whether hand-operated operation is provided as an override (= TRUE) or not (= FALSE). Note that this value should be set to FALSE by default in the case of a Hand Operated Actuator.
    /// <see href="https://saref.etsi.org/saref4bldg/manualOverride"></see></summary>
    let manualOverride = _prefix "manualOverride"
    /// <summary>
    /// Specifies the required fail-safe position of the actuator.
    /// <see href="https://saref.etsi.org/saref4bldg/failPosition"></see></summary>
    let failPosition = _prefix "failPosition"
    /// <summary>
    /// Represents devices of a building automation control system that are used to impart control over elements of a distribution system. (Definition adapated from http://www.buildingsmart-tech.org/ifc/IFC4/Add1/html/schema/ifcsharedbldgserviceelements/lexical/ifcdistributioncontrolelement.htm)
    /// <see href="https://saref.etsi.org/saref4bldg/DistributionControlDevice"></see></summary>
    let DistributionControlDevice = _prefix "DistributionControlDevice"
    /// <summary>
    /// An air-to-air heat recovery device employs a counter-flow heat exchanger between inbound and outbound air flow. It is typically used to transfer heat from warmer air in one chamber to cooler air in the second chamber (i.e., typically used to recover heat from the conditioned air being exhausted and the outside air being supplied to a building), resulting in energy savings from reduced heating (or cooling) requirements.
    /// <see href="https://saref.etsi.org/saref4bldg/AirToAirHeatRecovery"></see></summary>
    let AirToAirHeatRecovery = _prefix "AirToAirHeatRecovery"
    /// <summary>
    /// Maximum secondary airflow that can be delivered. Usually measured in Pascals (Pa, N/m2).
    /// <see href="https://saref.etsi.org/saref4bldg/secondaryAirFlowRateMin"></see></summary>
    let secondaryAirFlowRateMin = _prefix "secondaryAirFlowRateMin"
    /// <summary>
    /// Whether the heat exchanger has defrost function or not.
    /// <see href="https://saref.etsi.org/saref4bldg/hasDefrost"></see></summary>
    let hasDefrost = _prefix "hasDefrost"
    /// <summary>
    /// Minimum primary airflow that can be delivered. Usually measured in m3/s.
    /// <see href="https://saref.etsi.org/saref4bldg/primaryAirFlowRateMin"></see></summary>
    let primaryAirFlowRateMin = _prefix "primaryAirFlowRateMin"
    /// <summary>
    /// Maximum primary airflow that can be delivered. Usually measured in m3/s.
    /// <see href="https://saref.etsi.org/saref4bldg/primaryAirFlowRateMax"></see></summary>
    let primaryAirFlowRateMax = _prefix "primaryAirFlowRateMax"
    /// <summary>
    /// Maximum secondary airflow that can be delivered. Usually measured in Pascals (Pa, N/m2).
    /// <see href="https://saref.etsi.org/saref4bldg/secondaryAirFlowRateMax"></see></summary>
    let secondaryAirFlowRateMax = _prefix "secondaryAirFlowRateMax"
    /// <summary>
    /// Allowable operation ambient (air, fluid) temperature range. Usually measured in degrees Kelvin (K).
    /// <see href="https://saref.etsi.org/saref4bldg/operationTemperatureMin"></see></summary>
    let operationTemperatureMin = _prefix "operationTemperatureMin"
    /// <summary>
    /// The distribution flow element EnergyConversionDevice defines the occurrence of a device used to perform energy conversion or heat transfer and typically participates in a flow distribution system.
    /// <see href="https://saref.etsi.org/saref4bldg/EnergyConversionDevice"></see></summary>
    let EnergyConversionDevice = _prefix "EnergyConversionDevice"
    /// <summary>
    /// Allowable operation ambient (air, fluid) temperature range. Usually measured in degrees Kelvin (K).
    /// <see href="https://saref.etsi.org/saref4bldg/operationTemperatureMax"></see></summary>
    let operationTemperatureMax = _prefix "operationTemperatureMax"
    /// <summary>
    /// Type of heat transfer between the two air streams.
    /// <see href="https://saref.etsi.org/saref4bldg/heatTransferTypeEnum"></see></summary>
    let heatTransferTypeEnum = _prefix "heatTransferTypeEnum"
    /// <summary>
    /// An alarm is a device that signals the existence of a condition or situation that is outside the boundaries of normal expectation or that activates such a device.
    ///
    /// Alarms include the provision of break glass buttons and manual pull boxes that are used to activate alarms.
    /// <see href="https://saref.etsi.org/saref4bldg/Alarm"></see></summary>
    let Alarm = _prefix "Alarm"
    /// <summary>
    /// An audio-visual appliance is a device that displays, captures, transmits, or receives audio or video.
    ///
    /// Audio-visual appliances may be fixed in place or may be able to be moved from one space to another. They may require an electrical supply that may be supplied either by an electrical circuit or provided from a local battery source. Audio-visual appliances may be connected to data circuits including specialist circuits for audio visual purposes only.
    /// <see href="https://saref.etsi.org/saref4bldg/AudioVisualAppliance"></see></summary>
    let AudioVisualAppliance = _prefix "AudioVisualAppliance"
    /// <summary>
    /// Indicates media sources and corresponding names of ports (DistributionPort with FlowDirection=SINK and PredefinedType=AUDIOVISUAL) or aggregated audio/video components (AudioVisualAppliance).
    /// <see href="https://saref.etsi.org/saref4bldg/mediaSource"></see></summary>
    let mediaSource = _prefix "mediaSource"
    /// <summary>
    /// Indicates discrete audio volume levels and corresponding sound power offsets, if applicable. Missing values may be interpolated. Measured in watts.
    /// <see href="https://saref.etsi.org/saref4bldg/audioVolume"></see></summary>
    let audioVolume = _prefix "audioVolume"
    /// <summary>
    /// The distribution flow element FlowTerminal defines the occurrence of a permanently attached element that acts as a terminus or beginning of a distribution system (such as an air outlet, drain, water closet, or sink). A terminal is typically a point at which a system interfaces with an external environment.
    /// <see href="https://saref.etsi.org/saref4bldg/FlowTerminal"></see></summary>
    let FlowTerminal = _prefix "FlowTerminal"
    /// <summary>
    /// A boiler is a closed, pressure-rated vessel in which water or other fluid is heated using an energy source such as natural gas, heating oil, or electricity. The fluid in the vessel is then circulated out of the boiler for use in various processes or heating applications.
    /// <see href="https://saref.etsi.org/saref4bldg/Boiler"></see></summary>
    let Boiler = _prefix "Boiler"
    /// <summary>
    /// Allowable outlet temperature of either the water or the steam. Usually measured in degrees Kelvin (K).
    /// <see href="https://saref.etsi.org/saref4bldg/outletTemperatureMax"></see></summary>
    let outletTemperatureMax = _prefix "outletTemperatureMax"
    /// <summary>
    /// Allowable water inlet temperature range. Usually measured in degrees Kelvin (K).
    /// <see href="https://saref.etsi.org/saref4bldg/waterInletTemperatureMax"></see></summary>
    let waterInletTemperatureMax = _prefix "waterInletTemperatureMax"
    /// <summary>
    /// Total heat transfer area of the vessel. Usually measured in square metre (m2).
    /// <see href="https://saref.etsi.org/saref4bldg/heatTransferSurfaceArea"></see></summary>
    let heatTransferSurfaceArea = _prefix "heatTransferSurfaceArea"
    /// <summary>
    /// Nominal fuel consumption rate required to produce the total boiler heat output. Usually measured in Watts (W, J/s).
    /// <see href="https://saref.etsi.org/saref4bldg/nominalEnergyConsumption"></see></summary>
    let nominalEnergyConsumption = _prefix "nominalEnergyConsumption"
    /// <summary>
    /// The source of energy.
    /// Enumeration defining the energy source or fuel cumbusted to generate heat.
    /// <see href="https://saref.etsi.org/saref4bldg/energySource"></see></summary>
    let energySource = _prefix "energySource"
    /// <summary>
    /// Allowable water inlet temperature range. Usually measured in degrees Kelvin (K).
    /// <see href="https://saref.etsi.org/saref4bldg/waterInletTemperatureMin"></see></summary>
    let waterInletTemperatureMin = _prefix "waterInletTemperatureMin"
    /// <summary>
    /// This is used to identify if the boiler has storage capacity (TRUE). If FALSE, then there is no storage capacity built into the boiler, such as an instantaneous hot water heater.
    /// <see href="https://saref.etsi.org/saref4bldg/isWaterStorageHeater"></see></summary>
    let isWaterStorageHeater = _prefix "isWaterStorageHeater"
    /// <summary>
    /// Water storage capacity. Usually measured in cubic metre (m3).
    /// <see href="https://saref.etsi.org/saref4bldg/waterStorageCapacity"></see></summary>
    let waterStorageCapacity = _prefix "waterStorageCapacity"
    /// <summary>
    /// Nominal pressure rating of the boiler as rated by the agency having jurisdiction. Usually measured in Pascals (Pa, N/m2).
    /// <see href="https://saref.etsi.org/saref4bldg/pressureRating"></see></summary>
    let pressureRating = _prefix "pressureRating"
    /// <summary>
    /// Identifies the operating mode of the boiler.
    /// <see href="https://saref.etsi.org/saref4bldg/operatingMode"></see></summary>
    let operatingMode = _prefix "operatingMode"
    /// <summary>
    /// Allowable part load ratio range.
    /// <see href="https://saref.etsi.org/saref4bldg/nominalPartLoadRatio"></see></summary>
    let nominalPartLoadRatio = _prefix "nominalPartLoadRatio"
    /// <summary>
    /// Allowable outlet temperature of either the water or the steam. Usually measured in degrees Kelvin (K).
    /// <see href="https://saref.etsi.org/saref4bldg/outletTemperatureMin"></see></summary>
    let outletTemperatureMin = _prefix "outletTemperatureMin"
    /// <summary>
    /// Relation between a building or a building space and the spaces it can be divided into.
    /// <see href="https://saref.etsi.org/saref4bldg/hasSpace"></see></summary>
    let hasSpace = _prefix "hasSpace"
    /// <summary>
    /// A tangible object designed to accomplish a particular task in a building.
    /// <see href="https://saref.etsi.org/saref4bldg/BuildingDevice"></see></summary>
    let BuildingDevice = _prefix "BuildingDevice"
    /// <summary>
    /// An object in the building that can be controlled by devices, such as a door or a window that can be automatically opened or closed by an actuator.  (Definition taken from SAREF 1.0)
    /// <see href="https://saref.etsi.org/saref4bldg/BuildingObject"></see></summary>
    let BuildingObject = _prefix "BuildingObject"
    /// <summary>
    /// Relation between a building space and the building or building space it belongs to.
    /// <see href="https://saref.etsi.org/saref4bldg/isSpaceOf"></see></summary>
    let isSpaceOf = _prefix "isSpaceOf"
    /// <summary>
    /// A relation between a physical space and the objects located in such space.
    /// <see href="https://saref.etsi.org/saref4bldg/contains"></see></summary>
    let contains = _prefix "contains"
    /// <summary>
    /// A burner is a device that converts fuel into heat through combustion. It includes gas, oil, and wood burners.
    /// <see href="https://saref.etsi.org/saref4bldg/Burner"></see></summary>
    let Burner = _prefix "Burner"
    /// <summary>
    /// A chiller is a device used to remove heat from a liquid via a vapor-compression or absorption refrigeration cycle to cool a fluid, typically water or a mixture of water and glycol. The chilled fluid is then used to cool and dehumidify air in a building.
    /// <see href="https://saref.etsi.org/saref4bldg/Chiller"></see></summary>
    let Chiller = _prefix "Chiller"
    /// <summary>
    /// Chiller evaporating temperature.Usually measured in degrees Kelvin (K).
    /// <see href="https://saref.etsi.org/saref4bldg/nominalEvaporatingTemmperature"></see></summary>
    let nominalEvaporatingTemmperature = _prefix "nominalEvaporatingTemmperature"
    /// <summary>
    /// Nominal chiller efficiency under nominal conditions.
    /// <see href="https://saref.etsi.org/saref4bldg/nominalEfficiency"></see></summary>
    let nominalEfficiency = _prefix "nominalEfficiency"
    /// <summary>
    /// Chiller condensing temperature. Usually measured in degrees Kelvin (K).
    /// <see href="https://saref.etsi.org/saref4bldg/nominalCondensingTemperature"></see></summary>
    let nominalCondensingTemperature = _prefix "nominalCondensingTemperature"
    /// <summary>
    /// Nominal capacity. Usually measured in Watts (W, J/s).
    /// <see href="https://saref.etsi.org/saref4bldg/nominalCapacity"></see></summary>
    let nominalCapacity = _prefix "nominalCapacity"
    /// <summary>
    /// Nominal total power consumption. Usually measured in Watts (W, J/s).
    /// <see href="https://saref.etsi.org/saref4bldg/nominalPowerConsumption"></see></summary>
    let nominalPowerConsumption = _prefix "nominalPowerConsumption"
    /// <summary>
    /// Sum of the refrigeration effect and the heat equivalent of the power input to the compressor. Usually measured in Watts (W, J/s).
    /// <see href="https://saref.etsi.org/saref4bldg/nominalHeatRejectionRate"></see></summary>
    let nominalHeatRejectionRate = _prefix "nominalHeatRejectionRate"
    /// <summary>
    /// A coil is a device used to provide heat transfer between non-mixing media. A common example is a cooling coil, which utilizes a finned coil in which circulates chilled water, antifreeze, or refrigerant that is used to remove heat from air moving across the surface of the coil. A coil may be used either for heating or cooling purposes by placing a series of tubes (the coil) carrying a heating or cooling fluid into an airstream. The coil may be constructed from tubes bundled in a serpentine form or from finned tubes that give a extended heat transfer surface.
    ///
    /// Coils may also be used for non-airflow cases such as embedded in a floor slab.
    /// <see href="https://saref.etsi.org/saref4bldg/Coil"></see></summary>
    let Coil = _prefix "Coil"
    /// <summary>
    /// Minimum allowable air flow rate. Usually measured in m3/s.
    /// <see href="https://saref.etsi.org/saref4bldg/airFlowRateMin"></see></summary>
    let airFlowRateMin = _prefix "airFlowRateMin"
    /// <summary>
    /// Maximum allowable air flow rate. Usually measured in m3/s.
    /// <see href="https://saref.etsi.org/saref4bldg/airFlowRateMax"></see></summary>
    let airFlowRateMax = _prefix "airFlowRateMax"
    /// <summary>
    /// Nominal sensible capacity. Usually measured in Watts (W, J/s).
    /// <see href="https://saref.etsi.org/saref4bldg/nominalSensibleCapacity"></see></summary>
    let nominalSensibleCapacity = _prefix "nominalSensibleCapacity"
    /// <summary>
    /// Indicates how the device is designed to be placed.
    /// <see href="https://saref.etsi.org/saref4bldg/placementType"></see></summary>
    let placementType = _prefix "placementType"
    /// <summary>
    /// Nominal UA value.
    /// <see href="https://saref.etsi.org/saref4bldg/nominalUa"></see></summary>
    let nominalUa = _prefix "nominalUa"
    /// <summary>
    /// Nominal latent capacity. Usually measured in Watts (W, J/s).
    /// <see href="https://saref.etsi.org/saref4bldg/nominalLatentCapacity"></see></summary>
    let nominalLatentCapacity = _prefix "nominalLatentCapacity"
    /// <summary>
    /// A communications appliance transmits and receives electronic or digital information as data or sound.
    ///
    /// Communication appliances may be fixed in place or may be able to be moved from one space to another. Communication appliances require an electrical supply that may be supplied either by an electrical circuit or provided from a local battery source.
    /// <see href="https://saref.etsi.org/saref4bldg/CommunicationAppliance"></see></summary>
    let CommunicationAppliance = _prefix "CommunicationAppliance"
    /// <summary>
    /// A compressor is a device that compresses a fluid typically used in a refrigeration circuit.
    /// <see href="https://saref.etsi.org/saref4bldg/Compressor"></see></summary>
    let Compressor = _prefix "Compressor"
    /// <summary>
    /// Diameter of compressor impeller - used to scale performance of geometrically similar compressors. Usually measured in millimeters (mm).
    /// <see href="https://saref.etsi.org/saref4bldg/impellerDiameter"></see></summary>
    let impellerDiameter = _prefix "impellerDiameter"
    /// <summary>
    /// Whether or not hot gas bypass is provided for the compressor. TRUE = Yes, FALSE = No.
    /// <see href="https://saref.etsi.org/saref4bldg/hasHotGasBypass"></see></summary>
    let hasHotGasBypass = _prefix "hasHotGasBypass"
    /// <summary>
    /// Refrigerant class used by the compressor. CFC: Chlorofluorocarbons. HCFC: Hydrochlorofluorocarbons. HFC: Hydrofluorocarbons.
    /// <see href="https://saref.etsi.org/saref4bldg/refrigerantClass"></see></summary>
    let refrigerantClass = _prefix "refrigerantClass"
    /// <summary>
    /// Type of power driving the compressor.
    /// <see href="https://saref.etsi.org/saref4bldg/powerSource"></see></summary>
    let powerSource = _prefix "powerSource"
    /// <summary>
    /// Minimum part load ratio as a fraction of nominal capacity.
    /// <see href="https://saref.etsi.org/saref4bldg/partLoadRatioMin"></see></summary>
    let partLoadRatioMin = _prefix "partLoadRatioMin"
    /// <summary>
    /// Compressor speed. Usually measured in cycles/s.
    /// <see href="https://saref.etsi.org/saref4bldg/compressorSpeed"></see></summary>
    let compressorSpeed = _prefix "compressorSpeed"
    /// <summary>
    /// Compressor capacity under ideal conditions. Usually measured in Watts (W, J/s).
    /// <see href="https://saref.etsi.org/saref4bldg/idealCapacity"></see></summary>
    let idealCapacity = _prefix "idealCapacity"
    /// <summary>
    /// Maximum part load ratio as a fraction of nominal capacity.
    /// <see href="https://saref.etsi.org/saref4bldg/partLoadRatioMax"></see></summary>
    let partLoadRatioMax = _prefix "partLoadRatioMax"
    /// <summary>
    /// The distribution flow element FlowMovingDevice defines the occurrence of an apparatus used to distribute, circulate or perform conveyance of fluids, including liquids and gases (such as a pump or fan), and typically participates in a flow distribution system.
    /// <see href="https://saref.etsi.org/saref4bldg/FlowMovingDevice"></see></summary>
    let FlowMovingDevice = _prefix "FlowMovingDevice"
    /// <summary>
    /// Compressor shaft power under ideal conditions. Usually measured in Watts (W, J/s).
    /// <see href="https://saref.etsi.org/saref4bldg/idealShaftPower"></see></summary>
    let idealShaftPower = _prefix "idealShaftPower"
    /// <summary>
    /// A condenser is a device that is used to dissipate heat, typically by condensing a substance such as a refrigerant from its gaseous to its liquid state.
    /// <see href="https://saref.etsi.org/saref4bldg/Condenser"></see></summary>
    let Condenser = _prefix "Condenser"
    /// <summary>
    /// External surface area (both primary and secondary area). Usually measured in square metre (m2).
    /// <see href="https://saref.etsi.org/saref4bldg/externalSurfaceArea"></see></summary>
    let externalSurfaceArea = _prefix "externalSurfaceArea"
    /// <summary>
    /// Internal surface area. Usually measured in square metre (m2).
    /// <see href="https://saref.etsi.org/saref4bldg/internalSurfaceArea"></see></summary>
    let internalSurfaceArea = _prefix "internalSurfaceArea"
    /// <summary>
    /// Internal volume of evaporator (water side). Usually measured in cubic metre (m3).
    /// <see href="https://saref.etsi.org/saref4bldg/internalWaterVolume"></see></summary>
    let internalWaterVolume = _prefix "internalWaterVolume"
    /// <summary>
    /// Internal volume of evaporator (refrigerant side). Usually measured in cubic metre (m3).
    /// <see href="https://saref.etsi.org/saref4bldg/internalRefrigerantVolume"></see></summary>
    let internalRefrigerantVolume = _prefix "internalRefrigerantVolume"
    /// <summary>
    /// Nominal overall heat transfer coefficient associated with nominal heat transfer area. Usually measured in Watts/m2 Kelvin.
    /// <see href="https://saref.etsi.org/saref4bldg/nominalHeatTransferCoefficient"></see></summary>
    let nominalHeatTransferCoefficient = _prefix "nominalHeatTransferCoefficient"
    /// <summary>
    /// Nominal heat transfer surface area associated with nominal overall heat transfer coefficient. Usually measured in square metre (m2).
    /// <see href="https://saref.etsi.org/saref4bldg/nominalHeatTransferArea"></see></summary>
    let nominalHeatTransferArea = _prefix "nominalHeatTransferArea"
    /// <summary>
    /// A controller is a device that monitors inputs and controls outputs within a building automation system.
    ///
    /// A controller may be physical (having placement within a spatial structure) or logical (a software interface or aggregated within a programmable physical controller).
    /// <see href="https://saref.etsi.org/saref4bldg/Controller"></see></summary>
    let Controller = _prefix "Controller"
    /// <summary>
    /// A cooled beam (or chilled beam) is a device typically used to cool air by circulating a fluid such as chilled water through exposed finned tubes above a space. Typically mounted overhead near or within a ceiling, the cooled beam uses convection to cool the space below it by acting as a heat sink for the naturally rising warm air of the space. Once cooled, the air naturally drops back to the floor where the cycle begins again.
    /// <see href="https://saref.etsi.org/saref4bldg/CooledBeam"></see></summary>
    let CooledBeam = _prefix "CooledBeam"
    /// <summary>
    /// Is it free hanging type (not mounted in a false ceiling)?
    /// <see href="https://saref.etsi.org/saref4bldg/isFreeHanging"></see></summary>
    let isFreeHanging = _prefix "isFreeHanging"
    /// <summary>
    /// Nominal surrounding humidity (refers to nominal cooling capacity). Usually measured in degrees Kelvin (K).
    /// <see href="https://saref.etsi.org/saref4bldg/nominalSorroundingHumidityCooling"></see></summary>
    let nominalSorroundingHumidityCooling = _prefix "nominalSorroundingHumidityCooling"
    /// <summary>
    /// Nominal cooling capacity. Usually measured in Watts (W, J/s).
    /// <see href="https://saref.etsi.org/saref4bldg/nominalCoolingCapacity"></see></summary>
    let nominalCoolingCapacity = _prefix "nominalCoolingCapacity"
    /// <summary>
    /// Nominal water flow (refers to nominal cooling capacity). Usually measured in m3/s.
    /// <see href="https://saref.etsi.org/saref4bldg/nominalWaterFlowCooling"></see></summary>
    let nominalWaterFlowCooling = _prefix "nominalWaterFlowCooling"
    /// <summary>
    /// Allowable water circuit working pressure range. Usually measured in Pascals (Pa, N/m2).
    /// <see href="https://saref.etsi.org/saref4bldg/waterPressureMax"></see></summary>
    let waterPressureMax = _prefix "waterPressureMax"
    /// <summary>
    /// Integrated lighting in cooled beam.
    /// <see href="https://saref.etsi.org/saref4bldg/integratedLightingType"></see></summary>
    let integratedLightingType = _prefix "integratedLightingType"
    /// <summary>
    /// Factory fitted waterflow control system.
    /// <see href="https://saref.etsi.org/saref4bldg/waterFlowControlSystemType"></see></summary>
    let waterFlowControlSystemType = _prefix "waterFlowControlSystemType"
    /// <summary>
    /// Nominal heating capacity. Usually measured in Watts (W, J/s).
    /// <see href="https://saref.etsi.org/saref4bldg/nominalHeatingCapacity"></see></summary>
    let nominalHeatingCapacity = _prefix "nominalHeatingCapacity"
    /// <summary>
    /// Allowable water circuit working pressure range. Usually measured in Pascals (Pa, N/m2).
    /// <see href="https://saref.etsi.org/saref4bldg/waterPressureMin"></see></summary>
    let waterPressureMin = _prefix "waterPressureMin"
    /// <summary>
    /// Finish color for cooled beam.
    /// <see href="https://saref.etsi.org/saref4bldg/finishColor"></see></summary>
    let finishColor = _prefix "finishColor"

    /// <summary>
    /// Nominal return water temperature (refers to nominal cooling capacity). Usually measured in degrees Kelvin (K).
    /// <see href="https://saref.etsi.org/saref4bldg/nominalReturnWaterTemperatureCooling"></see></summary>
    let nominalReturnWaterTemperatureCooling =
        _prefix "nominalReturnWaterTemperatureCooling"

    /// <summary>
    /// Length of coil. Usually measured in millimeters (mm).
    /// <see href="https://saref.etsi.org/saref4bldg/coilLength"></see></summary>
    let coilLength = _prefix "coilLength"
    /// <summary>
    /// Width of coil. Usually measured in millimeters (mm
    /// <see href="https://saref.etsi.org/saref4bldg/coilWidth"></see></summary>
    let coilWidth = _prefix "coilWidth"

    /// <summary>
    /// Nominal return water temperature (refers to nominal heating capacity). Usually measured in degrees Kelvin (K).
    /// <see href="https://saref.etsi.org/saref4bldg/nominalReturnWaterTemperatureHeating"></see></summary>
    let nominalReturnWaterTemperatureHeating =
        _prefix "nominalReturnWaterTemperatureHeating"

    /// <summary>
    /// Nominal supply water temperature (refers to nominal heating capacity). Usually measured in degrees Kelvin (K).
    /// <see href="https://saref.etsi.org/saref4bldg/nominalSupplyWaterTemperatureHeating"></see></summary>
    let nominalSupplyWaterTemperatureHeating =
        _prefix "nominalSupplyWaterTemperatureHeating"

    /// <summary>
    /// Nominal surrounding temperature (refers to nominal cooling capacity). Usually measured in degrees Kelvin (K).
    /// <see href="https://saref.etsi.org/saref4bldg/nominalSorroundingTemperatureCooling"></see></summary>
    let nominalSorroundingTemperatureCooling =
        _prefix "nominalSorroundingTemperatureCooling"

    /// <summary>
    /// The manner in which the pipe connection is made to the cooled beam.
    /// <see href="https://saref.etsi.org/saref4bldg/pipeConnectionEnum"></see></summary>
    let pipeConnectionEnum = _prefix "pipeConnectionEnum"

    /// <summary>
    /// Nominal supply water temperature (refers to nominal cooling capacity). Usually measured in degrees Kelvin (K).
    /// <see href="https://saref.etsi.org/saref4bldg/nominalSupplyWaterTemperatureCooling"></see></summary>
    let nominalSupplyWaterTemperatureCooling =
        _prefix "nominalSupplyWaterTemperatureCooling"

    /// <summary>
    /// Nominal surrounding temperature (refers to nominal heating capacity). Usually measured in degrees Kelvin (K).
    /// <see href="https://saref.etsi.org/saref4bldg/nominalSorroundingTemperatureHeating"></see></summary>
    let nominalSorroundingTemperatureHeating =
        _prefix "nominalSorroundingTemperatureHeating"

    /// <summary>
    /// Nominal water flow (refers to nominal heating capacity). Usually measured in m3/s.
    /// <see href="https://saref.etsi.org/saref4bldg/nominalWaterFlowHeating"></see></summary>
    let nominalWaterFlowHeating = _prefix "nominalWaterFlowHeating"
    /// <summary>
    /// A cooling tower is a device which rejects heat to ambient air by circulating a fluid such as water through it to reduce its temperature by partial evaporation.
    /// <see href="https://saref.etsi.org/saref4bldg/CoolingTower"></see></summary>
    let CoolingTower = _prefix "CoolingTower"
    /// <summary>
    /// FixedExitingWaterTemp: The capacity is controlled to maintain a fixed exiting water temperature. WetBulbTempReset: The set-point is reset based on the wet-bulb temperature.
    /// <see href="https://saref.etsi.org/saref4bldg/controlStrategy"></see></summary>
    let controlStrategy = _prefix "controlStrategy"
    /// <summary>
    /// Ambient design dry bulb temperature used for selecting the cooling tower. Usually measured in degrees Kelvin (K).
    /// <see href="https://saref.etsi.org/saref4bldg/ambientDesignDryBulbTemperature"></see></summary>
    let ambientDesignDryBulbTemperature = _prefix "ambientDesignDryBulbTemperature"
    /// <summary>
    /// Ambient design wet bulb temperature used for selecting the cooling tower. Usually measured in degrees Kelvin (K).
    /// <see href="https://saref.etsi.org/saref4bldg/ambientDesignWetBulbTemperature"></see></summary>
    let ambientDesignWetBulbTemperature = _prefix "ambientDesignWetBulbTemperature"
    /// <summary>
    /// Number of cells in one cooling tower unit.
    /// <see href="https://saref.etsi.org/saref4bldg/numberOfCells"></see></summary>
    let numberOfCells = _prefix "numberOfCells"
    /// <summary>
    /// Elevation difference between cooling tower sump and the top of the tower. Usually measured in millimeters (mm).
    /// <see href="https://saref.etsi.org/saref4bldg/liftElevationDifference"></see></summary>
    let liftElevationDifference = _prefix "liftElevationDifference"
    /// <summary>
    /// FanCycling: Fan is cycled on and off to control duty. TwoSpeedFan: Fan is switched between low and high speed to control duty. VariableSpeedFan: Fan speed is varied to control duty. DampersControl: Dampers modulate the air flow to control duty. BypassValveControl: Bypass valve modulates the water flow to control duty. MultipleSeriesPumps: Turn on/off multiple series pump to control duty. TwoSpeedPump: Switch between high/low pump speed to control duty. VariableSpeedPump: vary pump speed to control duty.
    /// <see href="https://saref.etsi.org/saref4bldg/capacityControl"></see></summary>
    let capacityControl = _prefix "capacityControl"
    /// <summary>
    /// SprayFilled: Water is sprayed into airflow. SplashTypeFill: water cascades over successive rows of splash bars. FilmTypeFill: water flows in a thin layer over closely spaced sheets.
    /// <see href="https://saref.etsi.org/saref4bldg/sprayType"></see></summary>
    let sprayType = _prefix "sprayType"
    /// <summary>
    /// OpenCircuit: Exposes water directly to the cooling atmosphere. CloseCircuit: The fluid is separated from the atmosphere by a heat exchanger. Wet: The air stream or the heat exchange surface is evaporatively cooled. Dry: No evaporation into the air stream. DryWet: A combination of a dry tower and a wet tower.
    /// <see href="https://saref.etsi.org/saref4bldg/circuitType"></see></summary>
    let circuitType = _prefix "circuitType"
    /// <summary>
    /// CounterFlow: Air and water flow enter in different directions. CrossFlow: Air and water flow are perpendicular. ParallelFlow: air and water flow enter in same directions.
    /// <see href="https://saref.etsi.org/saref4bldg/flowArrangement"></see></summary>
    let flowArrangement = _prefix "flowArrangement"
    /// <summary>
    /// Volume between operating and overflow levels in cooling tower basin. Usually measured in cubic metre (m3).
    /// <see href="https://saref.etsi.org/saref4bldg/basinReserveVolume"></see></summary>
    let basinReserveVolume = _prefix "basinReserveVolume"
    /// <summary>
    /// Make-up water requirement. Usually measured in m3/s.
    /// <see href="https://saref.etsi.org/saref4bldg/waterRequirement"></see></summary>
    let waterRequirement = _prefix "waterRequirement"
    /// <summary>
    /// A damper typically participates in an HVAC duct distribution system and is used to control or modulate the flow of air.
    /// <see href="https://saref.etsi.org/saref4bldg/Damper"></see></summary>
    let Damper = _prefix "Damper"
    /// <summary>
    /// Total pressure drop across damper. Usually measured in Pascals (Pa, N/m2).
    /// <see href="https://saref.etsi.org/saref4bldg/openPressureDrop"></see></summary>
    let openPressureDrop = _prefix "openPressureDrop"
    /// <summary>
    /// Leakage when fully closed. Usually measured in m3/s.
    /// <see href="https://saref.etsi.org/saref4bldg/leakageFullyClosed"></see></summary>
    let leakageFullyClosed = _prefix "leakageFullyClosed"
    /// <summary>
    /// Temperature rating. Usually measured in degrees Kelvin (K).
    /// <see href="https://saref.etsi.org/saref4bldg/temperatureRating"></see></summary>
    let temperatureRating = _prefix "temperatureRating"
    /// <summary>
    /// The type of frame used by the damper (e.g., Standard, Single Flange, Single Reversed Flange, Double Flange, etc.).
    /// <see href="https://saref.etsi.org/saref4bldg/frameType"></see></summary>
    let frameType = _prefix "frameType"
    /// <summary>
    /// Number of blades.
    /// <see href="https://saref.etsi.org/saref4bldg/numberOfBlades"></see></summary>
    let numberOfBlades = _prefix "numberOfBlades"
    /// <summary>
    /// The thickness of the damper blade. Usually measured in millimeters (mm).
    /// <see href="https://saref.etsi.org/saref4bldg/bladeThickness"></see></summary>
    let bladeThickness = _prefix "bladeThickness"
    /// <summary>
    /// The distribution flow element FlowController defines the occurrence of elements of a distribution system that are used to regulate flow through a distribution system. Examples include dampers, valves, switches, and relays.
    /// <see href="https://saref.etsi.org/saref4bldg/FlowController"></see></summary>
    let FlowController = _prefix "FlowController"
    /// <summary>
    /// The thickness of the damper frame material. Usually measured in millimeters (mm).
    /// <see href="https://saref.etsi.org/saref4bldg/frameThickness"></see></summary>
    let frameThickness = _prefix "frameThickness"
    /// <summary>
    /// The intended orientation for the damper as specified by the manufacturer.
    /// <see href="https://saref.etsi.org/saref4bldg/orientation"></see></summary>
    let orientation = _prefix "orientation"
    /// <summary>
    /// Maximum working pressure. Usually measured in Pascals (Pa, N/m2).
    /// <see href="https://saref.etsi.org/saref4bldg/workingPressureMax"></see></summary>
    let workingPressureMax = _prefix "workingPressureMax"
    /// <summary>
    /// Face area open to the airstream. Usually measured in square metre (m2).
    /// <see href="https://saref.etsi.org/saref4bldg/faceArea"></see></summary>
    let faceArea = _prefix "faceArea"
    /// <summary>
    /// The operational mechanism for the damper operation.
    /// <see href="https://saref.etsi.org/saref4bldg/operation"></see></summary>
    let operation = _prefix "operation"
    /// <summary>
    /// Nominal rate of air flow. Usually measured in m3/s.
    /// <see href="https://saref.etsi.org/saref4bldg/nominalAirFlowRate"></see></summary>
    let nominalAirFlowRate = _prefix "nominalAirFlowRate"
    /// <summary>
    /// The length (or depth) of the damper frame. Usually measured in millimeters (mm).
    /// <see href="https://saref.etsi.org/saref4bldg/frameDepth"></see></summary>
    let frameDepth = _prefix "frameDepth"
    /// <summary>
    /// Blade edge.
    /// <see href="https://saref.etsi.org/saref4bldg/bladeEdge"></see></summary>
    let bladeEdge = _prefix "bladeEdge"
    /// <summary>
    /// Blade shape. Flat means triple V-groove.
    /// <see href="https://saref.etsi.org/saref4bldg/bladeShape"></see></summary>
    let bladeShape = _prefix "bladeShape"
    /// <summary>
    /// Close off rating. Usually measured in Pascals (Pa, N/m2).
    /// <see href="https://saref.etsi.org/saref4bldg/closeOffRating"></see></summary>
    let closeOffRating = _prefix "closeOffRating"
    /// <summary>
    /// Blade action.
    /// <see href="https://saref.etsi.org/saref4bldg/bladeAction"></see></summary>
    let bladeAction = _prefix "bladeAction"
    /// <summary>
    /// Generalization of all devices that participate in a distribution system. (Definition adapated from http://www.buildingsmart-tech.org/ifc/IFC4/Add1/html/schema/ifcproductextension/lexical/ifcdistributionelement.htm)
    /// <see href="https://saref.etsi.org/saref4bldg/DistributionDevice"></see></summary>
    let DistributionDevice = _prefix "DistributionDevice"
    /// <summary>
    /// Represents devices of a distribution system that facilitate the distribution of energy or matter, such as air, water or power. (Definition adapated from http://www.buildingsmart-tech.org/ifc/IFC4/Add1/html/schema/ifcsharedbldgserviceelements/lexical/ifcdistributionflowelement.htm)
    /// <see href="https://saref.etsi.org/saref4bldg/DistributionFlowDevice"></see></summary>
    let DistributionFlowDevice = _prefix "DistributionFlowDevice"
    /// <summary>
    /// A duct silencer is a device that is typically installed inside a duct distribution system for the purpose of reducing the noise levels from air movement, fan noise, etc. in the adjacent space or downstream of the duct silencer device.
    /// <see href="https://saref.etsi.org/saref4bldg/DuctSilencer"></see></summary>
    let DuctSilencer = _prefix "DuctSilencer"
    /// <summary>
    /// The weight of the device. Usually measured in kilograms (kg) or grams (g).
    /// <see href="https://saref.etsi.org/saref4bldg/weight"></see></summary>
    let weight = _prefix "weight"
    /// <summary>
    /// TRUE if the silencer has exterior insulation. FALSE if it does not.
    /// <see href="https://saref.etsi.org/saref4bldg/hasExteriorInsulation"></see></summary>
    let hasExteriorInsulation = _prefix "hasExteriorInsulation"
    /// <summary>
    /// The finished length of the device. Usually measured in millimeters (mm).
    /// <see href="https://saref.etsi.org/saref4bldg/length"></see></summary>
    let length = _prefix "length"
    /// <summary>
    /// The distribution flow element FlowTreatmentDevice defines the occurrence of a device typically used to remove unwanted matter from a fluid, either liquid or gas, and typically participates in a flow distribution system.
    /// <see href="https://saref.etsi.org/saref4bldg/FlowTreatmentDevice"></see></summary>
    let FlowTreatmentDevice = _prefix "FlowTreatmentDevice"
    /// <summary>
    /// Hydraulic diameter. Usually measured in millimeters (mm).
    /// <see href="https://saref.etsi.org/saref4bldg/hydraulicDiameter"></see></summary>
    let hydraulicDiameter = _prefix "hydraulicDiameter"
    /// <summary>
    /// Allowable minimum working pressure (relative to ambient pressure). Usually measured in Pascals (Pa, N/m2).
    /// <see href="https://saref.etsi.org/saref4bldg/workingPressureMin"></see></summary>
    let workingPressureMin = _prefix "workingPressureMin"
    /// <summary>
    /// An electric appliance is a device intended for consumer usage that is powered by electricity.
    ///
    /// Electric appliances may be fixed in place or may be able to be moved from one space to another. Electric appliances require an electrical supply that may be supplied either by an electrical circuit or provided from a local battery source.
    /// <see href="https://saref.etsi.org/saref4bldg/ElectricAppliance"></see></summary>
    let ElectricAppliance = _prefix "ElectricAppliance"
    /// <summary>
    /// An electric flow storage device is a device in which electrical energy is stored and from which energy may be progressively released.
    /// <see href="https://saref.etsi.org/saref4bldg/ElectricFlowStorageDevice"></see></summary>
    let ElectricFlowStorageDevice = _prefix "ElectricFlowStorageDevice"
    /// <summary>
    /// The distribution flow element FlowStorageDevice defines the occurrence of a device that participates in a distribution system and is used for temporary storage (such as a tank).
    /// <see href="https://saref.etsi.org/saref4bldg/FlowStorageDevice"></see></summary>
    let FlowStorageDevice = _prefix "FlowStorageDevice"
    /// <summary>
    /// The nominal frequency of the supply. Usually measured in cycles/s or Hertz (Hz).
    /// <see href="https://saref.etsi.org/saref4bldg/nominalFrequency"></see></summary>
    let nominalFrequency = _prefix "nominalFrequency"
    /// <summary>
    /// The nominal voltage of the supply. Usually measured in Volts (V, W/A).
    /// <see href="https://saref.etsi.org/saref4bldg/nominalSupplyVoltage"></see></summary>
    let nominalSupplyVoltage = _prefix "nominalSupplyVoltage"
    /// <summary>
    /// The maximum and minimum allowed voltage of the supply e.g. boundaries of 380V/440V may be applied for a nominal voltage of 400V.
    /// <see href="https://saref.etsi.org/saref4bldg/nominalSupplyVoltageMin"></see></summary>
    let nominalSupplyVoltageMin = _prefix "nominalSupplyVoltageMin"
    /// <summary>
    /// An electric generator is an engine that is a machine for converting mechanical energy into electrical energy.
    /// <see href="https://saref.etsi.org/saref4bldg/ElectricGenerator"></see></summary>
    let ElectricGenerator = _prefix "ElectricGenerator"
    /// <summary>
    /// The maximum output power rating of the engine. Usually measured in Watts (W, J/s).
    /// <see href="https://saref.etsi.org/saref4bldg/powerOutputMax"></see></summary>
    let powerOutputMax = _prefix "powerOutputMax"
    /// <summary>
    /// IEC. Start current factor defines how large the peek starting current will become on the engine. StartCurrentFactor is multiplied to NominalCurrent and we get the start current.
    /// <see href="https://saref.etsi.org/saref4bldg/startCurrentFactor"></see></summary>
    let startCurrentFactor = _prefix "startCurrentFactor"
    /// <summary>
    /// The ratio of output capacity to intake capacity.
    /// <see href="https://saref.etsi.org/saref4bldg/electricGeneratorEfficiency"></see></summary>
    let electricGeneratorEfficiency = _prefix "electricGeneratorEfficiency"
    /// <summary>
    /// An electric motor is an engine that is a machine for converting electrical energy into mechanical energy.
    /// <see href="https://saref.etsi.org/saref4bldg/ElectricMotor"></see></summary>
    let ElectricMotor = _prefix "ElectricMotor"
    /// <summary>
    /// Indication of whether the motor is single speed, i.e. has a single winding (= FALSE) or multi-speed i.e.has part winding (= TRUE) .
    /// <see href="https://saref.etsi.org/saref4bldg/hasPartWinding"></see></summary>
    let hasPartWinding = _prefix "hasPartWinding"
    /// <summary>
    /// Indication of whether the motor enclosure is guarded (= TRUE) or not (= FALSE).
    /// <see href="https://saref.etsi.org/saref4bldg/isGuarded"></see></summary>
    let isGuarded = _prefix "isGuarded"
    /// <summary>
    /// A list of the available types of motor enclosure from which that required may be selected.
    /// <see href="https://saref.etsi.org/saref4bldg/motorEnclosureType"></see></summary>
    let motorEnclosureType = _prefix "motorEnclosureType"
    /// <summary>
    /// The ratio of output capacity to intake capacity.
    /// <see href="https://saref.etsi.org/saref4bldg/electricMotorEfficiency"></see></summary>
    let electricMotorEfficiency = _prefix "electricMotorEfficiency"
    /// <summary>
    /// The maximum time (in s) at which the motor could run with locked rotor when the motor is used in an EX-environment. The time indicates that a protective device should trip before this time when the starting current of the motor is slowing through the device.
    /// <see href="https://saref.etsi.org/saref4bldg/teTime"></see></summary>
    let teTime = _prefix "teTime"
    /// <summary>
    /// Designation of the frame size according to the named range of frame sizes designated at the place of use or according to a given standard.
    /// <see href="https://saref.etsi.org/saref4bldg/frameSize"></see></summary>
    let frameSize = _prefix "frameSize"
    /// <summary>
    /// Input current when a motor armature is energized but not rotating. Usually measured in Ampere (A).
    /// <see href="https://saref.etsi.org/saref4bldg/lockedRotorCurrent"></see></summary>
    let lockedRotorCurrent = _prefix "lockedRotorCurrent"
    /// <summary>
    /// The time (in s) needed for the motor to reach its rated speed with its driven equipment attached, starting from standstill and at the nominal voltage applied at its terminals.
    /// <see href="https://saref.etsi.org/saref4bldg/startingTime"></see></summary>
    let startingTime = _prefix "startingTime"
    /// <summary>
    /// An electric time control is a device that applies control to the provision or flow of electrical energy over time.
    /// <see href="https://saref.etsi.org/saref4bldg/ElectricTimeControl"></see></summary>
    let ElectricTimeControl = _prefix "ElectricTimeControl"
    /// <summary>
    /// An engine is a device that converts fuel into mechanical energy through combustion.
    /// <see href="https://saref.etsi.org/saref4bldg/Engine"></see></summary>
    let Engine = _prefix "Engine"
    /// <summary>
    /// An evaporative cooler is a device that cools air by saturating it with water vapor.
    /// <see href="https://saref.etsi.org/saref4bldg/EvaporativeCooler"></see></summary>
    let EvaporativeCooler = _prefix "EvaporativeCooler"
    /// <summary>
    /// Heat exchange area. Usually measured in square metre (m2).
    /// <see href="https://saref.etsi.org/saref4bldg/heatExchangeArea"></see></summary>
    let heatExchangeArea = _prefix "heatExchangeArea"
    /// <summary>
    /// An evaporator is a device in which a liquid refrigerent is vaporized and absorbs heat from the surrounding fluid.
    /// <see href="https://saref.etsi.org/saref4bldg/Evaporator"></see></summary>
    let Evaporator = _prefix "Evaporator"
    /// <summary>
    /// The fluid used for the coolant in the evaporator.
    /// <see href="https://saref.etsi.org/saref4bldg/evaporationCoolant"></see></summary>
    let evaporationCoolant = _prefix "evaporationCoolant"
    /// <summary>
    /// ColdLiquid: Evaporator is using liquid type of fluid to exchange heat with refrigerant. ColdAir: Evaporator is using air to exchange heat with refrigerant.
    /// <see href="https://saref.etsi.org/saref4bldg/evaporationMediumType"></see></summary>
    let evaporationMediumType = _prefix "evaporationMediumType"
    /// <summary>
    /// A fan is a device which imparts mechanical work on a gas. A typical usage of a fan is to induce airflow in a building services air distribution system.
    /// <see href="https://saref.etsi.org/saref4bldg/Fan"></see></summary>
    let Fan = _prefix "Fan"
    /// <summary>
    /// Nominal fan wheel speed. Usually measured in cycles/s.
    /// <see href="https://saref.etsi.org/saref4bldg/nominalRotationSpeed"></see></summary>
    let nominalRotationSpeed = _prefix "nominalRotationSpeed"
    /// <summary>
    /// Time of operation at maximum operational ambient air temperature. Measured in seconds (s) or days (d) or other units of time.
    /// <see href="https://saref.etsi.org/saref4bldg/operationalRiterial"></see></summary>
    let operationalRiterial = _prefix "operationalRiterial"
    /// <summary>
    /// Motor drive type: DIRECTDRIVE: Direct drive. BELTDRIVE: Belt drive. COUPLING: Coupling. OTHER: Other type of motor drive. UNKNOWN: Unknown motor drive type.
    /// <see href="https://saref.etsi.org/saref4bldg/motorDriveType"></see></summary>
    let motorDriveType = _prefix "motorDriveType"
    /// <summary>
    /// InletVane: Control by adjusting inlet vane. VariableSpeedDrive: Control by variable speed drive. BladePitchAngle: Control by adjusting blade pitch angle. TwoSpeed: Control by switch between high and low speed. DischargeDamper: Control by modulating discharge damper.
    /// <see href="https://saref.etsi.org/saref4bldg/capacityControlType"></see></summary>
    let capacityControlType = _prefix "capacityControlType"
    /// <summary>
    /// The static pressure within the air stream that the fan must overcome to insure designed circulation of air. Usually measured in Pascals (Pa, N/m2).
    /// <see href="https://saref.etsi.org/saref4bldg/nominalStaticPressure"></see></summary>
    let nominalStaticPressure = _prefix "nominalStaticPressure"
    /// <summary>
    /// Nominal fan power rate.Usually measured in Watts (W, J/s).
    /// <see href="https://saref.etsi.org/saref4bldg/nominalPowerRate"></see></summary>
    let nominalPowerRate = _prefix "nominalPowerRate"
    /// <summary>
    /// Nominal total pressure rise across the fan. Usually measured in Pascals (Pa, N/m2).
    /// <see href="https://saref.etsi.org/saref4bldg/nominalTotalPressure"></see></summary>
    let nominalTotalPressure = _prefix "nominalTotalPressure"
    /// <summary>
    /// A filter is an apparatus used to remove particulate or gaseous matter from fluids and gases.
    /// <see href="https://saref.etsi.org/saref4bldg/Filter"></see></summary>
    let Filter = _prefix "Filter"
    /// <summary>
    /// Total pressure drop across the filter. Usually measured in Pascals (Pa, N/m2).
    /// <see href="https://saref.etsi.org/saref4bldg/nominalPressureDrop"></see></summary>
    let nominalPressureDrop = _prefix "nominalPressureDrop"
    /// <summary>
    /// Possible range of fluid flowrate that can be delivered. Usually measured in m3/s.
    /// <see href="https://saref.etsi.org/saref4bldg/fluidFlowRateMin"></see></summary>
    let fluidFlowRateMin = _prefix "fluidFlowRateMin"
    /// <summary>
    /// Filter face velocity. Usually measured in m/s.
    /// <see href="https://saref.etsi.org/saref4bldg/nominalFilterFaceVelocity"></see></summary>
    let nominalFilterFaceVelocity = _prefix "nominalFilterFaceVelocity"
    /// <summary>
    /// Nominal fluid flow rate through the filter. Usually measured in m3/s.
    /// <see href="https://saref.etsi.org/saref4bldg/nominalFlowRate"></see></summary>
    let nominalFlowRate = _prefix "nominalFlowRate"
    /// <summary>
    /// Average fluid velocity at the media surface. Usually measured in m/s.
    /// <see href="https://saref.etsi.org/saref4bldg/nominalMediaSurfaceVelocity"></see></summary>
    let nominalMediaSurfaceVelocity = _prefix "nominalMediaSurfaceVelocity"
    /// <summary>
    /// Possible range of fluid flowrate that can be delivered. Usually measured in m3/s.
    /// <see href="https://saref.etsi.org/saref4bldg/fluidFlowRateMax"></see></summary>
    let fluidFlowRateMax = _prefix "fluidFlowRateMax"

    /// <summary>
    /// Particle geometric mean diameter associated with nominal efficiency. Usually measured in millimeters (mm).
    /// <see href="https://saref.etsi.org/saref4bldg/nominalParticleGeometricMeanDiameter"></see></summary>
    let nominalParticleGeometricMeanDiameter =
        _prefix "nominalParticleGeometricMeanDiameter"

    /// <summary>
    /// Particle geometric standard deviation associated with nominal efficiency.
    /// <see href="https://saref.etsi.org/saref4bldg/nominalParticleGeometricStandardDeviation"></see></summary>
    let nominalParticleGeometricStandardDeviation =
        _prefix "nominalParticleGeometricStandardDeviation"

    /// <summary>
    /// Initial new filter fluid resistance (i.e., pressure drop at the maximum air flowrate across the filter when the filter is new per ASHRAE Standard 52.1). Usually measured in Pascals (Pa, N/m2).
    /// <see href="https://saref.etsi.org/saref4bldg/initialResistance"></see></summary>
    let initialResistance = _prefix "initialResistance"
    /// <summary>
    /// Filter fluid resistance when replacement is required (i.e., Pressure drop at the maximum air flowrate across the filter when the filter needs replacement per ASHRAE Standard 52.1). Usually measured in Pascals (Pa, N/m2).
    /// <see href="https://saref.etsi.org/saref4bldg/finalResistance"></see></summary>
    let finalResistance = _prefix "finalResistance"
    /// <summary>
    /// A fire suppression terminal has the purpose of delivering a fluid (gas or liquid) that will suppress a fire.
    ///
    /// A fire suppression terminal provides for all forms of sprinkler, spreader and other form of terminal that is connected to a pipework system and intended to act in the role of suppressing a fire.
    /// <see href="https://saref.etsi.org/saref4bldg/FireSuppressionTerminal"></see></summary>
    let FireSuppressionTerminal = _prefix "FireSuppressionTerminal"
    /// <summary>
    /// A flow instrument reads and displays the value of a particular property of a system at a point, or displays the difference in the value of a property between two points.
    ///
    /// Instrumentation is typically for the purpose of determining the value of the property at a point in time. It is not the purpose of an instrument to record or integrate the values over time (although they may be connected to recording devices that do perform such a function). This entity provides for all forms of mechanical flow instrument (thermometers, pressure gauges etc.) and electrical flow instruments (ammeters, voltmeters etc.)
    /// <see href="https://saref.etsi.org/saref4bldg/FlowInstrument"></see></summary>
    let FlowInstrument = _prefix "FlowInstrument"
    /// <summary>
    /// A flow meter is a device that is used to measure the flow rate in a system.
    /// <see href="https://saref.etsi.org/saref4bldg/FlowMeter"></see></summary>
    let FlowMeter = _prefix "FlowMeter"
    /// <summary>
    /// Indicates whether the meter has a connection for remote reading through connection of a communication device (set TRUE) or not (set FALSE).
    /// <see href="https://saref.etsi.org/saref4bldg/remoteReading"></see></summary>
    let remoteReading = _prefix "remoteReading"
    /// <summary>
    /// Indication of the form that readout from the meter takes. In the case of a dial read out, this may comprise multiple dials that give a cumulative reading and/or a mechanical odometer.
    /// <see href="https://saref.etsi.org/saref4bldg/readOutType"></see></summary>
    let readOutType = _prefix "readOutType"
    /// <summary>
    /// A heat exchanger is a device used to provide heat transfer between non-mixing media such as plate and shell and tube heat exchangers. HeatExchanger is commonly used on water-side distribution systems to recover energy from a liquid to another liquid (typically water-based), whereas AirToAirHeatRecovery is commonly used on air-side distribution systems to recover energy from a gas to a gas (usually air).
    /// <see href="https://saref.etsi.org/saref4bldg/HeatExchanger"></see></summary>
    let HeatExchanger = _prefix "HeatExchanger"
    /// <summary>
    /// Defines the basic flow arrangements for the heat exchanger: COUNTERFLOW: Counterflow heat exchanger arrangement. CROSSFLOW: Crossflow heat exchanger arrangement. PARALLELFLOW: Parallel flow heat exchanger arrangement. MULTIPASS: Multipass flow heat exchanger arrangement. OTHER: Other type of heat exchanger flow arrangement not defined above.
    /// <see href="https://saref.etsi.org/saref4bldg/arrangement"></see></summary>
    let arrangement = _prefix "arrangement"
    /// <summary>
    /// A humidifier is a device that adds moisture into the air.
    /// <see href="https://saref.etsi.org/saref4bldg/Humidifier"></see></summary>
    let Humidifier = _prefix "Humidifier"
    /// <summary>
    /// Humidifier application. Fixed: Humidifier installed in a ducted flow distribution system. Portable: Humidifier is not installed in a ducted flow distribution system.
    /// <see href="https://saref.etsi.org/saref4bldg/application"></see></summary>
    let application = _prefix "application"
    /// <summary>
    /// Internal modulation control.
    /// <see href="https://saref.etsi.org/saref4bldg/internalControl"></see></summary>
    let internalControl = _prefix "internalControl"
    /// <summary>
    /// Nominal rate of water vapor added into the airstream. Usually measured in kg/s.
    /// <see href="https://saref.etsi.org/saref4bldg/nominalMoistureGain"></see></summary>
    let nominalMoistureGain = _prefix "nominalMoistureGain"
    /// <summary>
    /// An interceptor is a device designed and installed in order to separate and retain deleterious, hazardous or undesirable matter while permitting normal sewage or liquids to discharge into a collection system by gravity.
    /// <see href="https://saref.etsi.org/saref4bldg/Interceptor"></see></summary>
    let Interceptor = _prefix "Interceptor"
    /// <summary>
    /// Nominal or quoted =length, measured along the z-axis of the local coordinate system of the object, of the body of the object. Usually measured in millimeters (mm).
    /// <see href="https://saref.etsi.org/saref4bldg/nominalBodyDepth"></see></summary>
    let nominalBodyDepth = _prefix "nominalBodyDepth"
    /// <summary>
    /// The length measured along the x-axis in the local coordinate system of the cover of the oil interceptor. Usually measured in millimeters (mm).
    /// <see href="https://saref.etsi.org/saref4bldg/coverWidth"></see></summary>
    let coverWidth = _prefix "coverWidth"
    /// <summary>
    /// Size of the outlet connection. Usually measured in millimeters (mm).
    /// <see href="https://saref.etsi.org/saref4bldg/outletConnectionSize"></see></summary>
    let outletConnectionSize = _prefix "outletConnectionSize"
    /// <summary>
    /// The length measured along the x-axis in the local coordinate system or the radius (in the case of a circular shape in plan) of the cover of the oil interceptor. Usually measured in millimeters (mm).
    /// <see href="https://saref.etsi.org/saref4bldg/coverLength"></see></summary>
    let coverLength = _prefix "coverLength"
    /// <summary>
    /// Nominal or quoted length, measured along the x-axis of the local coordinate system of the object, of the body of the object. Usually measured in millimeters (mm).
    /// <see href="https://saref.etsi.org/saref4bldg/nominalBodyLength"></see></summary>
    let nominalBodyLength = _prefix "nominalBodyLength"
    /// <summary>
    /// Size of the inlet connection. Usually measured in millimeters (mm).
    /// <see href="https://saref.etsi.org/saref4bldg/inletConnectionSize"></see></summary>
    let inletConnectionSize = _prefix "inletConnectionSize"
    /// <summary>
    /// Size of the ventilating pipe(s). Usually measured in millimeters (mm).
    /// <see href="https://saref.etsi.org/saref4bldg/ventilatingPipeSize"></see></summary>
    let ventilatingPipeSize = _prefix "ventilatingPipeSize"
    /// <summary>
    /// Nominal or quoted length, measured along the y-axis of the local coordinate system of the object, of the body of the object. Usually measured in millimeters (mm).
    /// <see href="https://saref.etsi.org/saref4bldg/nominalBodyWidth"></see></summary>
    let nominalBodyWidth = _prefix "nominalBodyWidth"
    /// <summary>
    /// A lamp is an artificial light source such as a light bulb or tube.
    /// <see href="https://saref.etsi.org/saref4bldg/Lamp"></see></summary>
    let Lamp = _prefix "Lamp"
    /// <summary>
    /// The CRI indicates how well a light source renders eight standard colors compared to perfect reference lamp with the same color temperature. The CRI scale ranges from 1 to 100, with 100 representing perfect rendering properties.
    /// <see href="https://saref.etsi.org/saref4bldg/colorRenderingIndex"></see></summary>
    let colorRenderingIndex = _prefix "colorRenderingIndex"
    /// <summary>
    /// Non recoverable losses of luminous flux of a lamp due to lamp depreciation i.e. the decreasing of light output of a luminaire due to aging and dirt.
    /// <see href="https://saref.etsi.org/saref4bldg/lampMaintenanceFactor"></see></summary>
    let lampMaintenanceFactor = _prefix "lampMaintenanceFactor"
    /// <summary>
    /// The type of ballast used to stabilise gas discharge by limiting the current during operation and to deliver the necessary striking voltage for starting. Ballasts are needed to operate Discharge Lamps such as Fluorescent, Compact Fluorescent, High-pressure Mercury, Metal Halide and High-pressure Sodium Lamps. Magnetic ballasts are chokes which limit the current passing through a lamp connected in series on the principle of self-induction. The resultant current and power are decisive for the efficient operation of the lamp. A specially designed ballast is required for every type of lamp to comply with lamp rating in terms of Luminous Flux, Color Appearance and service life. The two types of magnetic ballasts for fluorescent lamps are KVG Conventional (EC-A series) and VVG Low-loss ballasts (EC-B series). Low-loss ballasts have a higher efficiency, which means reduced ballast losses and a lower thermal load. Electronic ballasts are used to run fluorescent lamps at high frequencies (approx. 35 - 40 kHz).
    /// <see href="https://saref.etsi.org/saref4bldg/lampBallastType"></see></summary>
    let lampBallastType = _prefix "lampBallastType"
    /// <summary>
    /// Identifies the form of compensation used for power factor correction and radio suppression.
    /// <see href="https://saref.etsi.org/saref4bldg/lampCompensationType"></see></summary>
    let lampCompensationType = _prefix "lampCompensationType"
    /// <summary>
    /// Luminous flux is a photometric measure of radiant flux, i.e. the volume of light emitted from a light source. Luminous flux is measured either for the interior as a whole or for a part of the interior (partial luminous flux for a solid angle). All other photometric parameters are derivatives of luminous flux. Luminous flux is measured in lumens (lm). The luminous flux is given as a nominal value for each lamp. Usually measured in Lumen (lm, Candela Steradian).
    /// <see href="https://saref.etsi.org/saref4bldg/contributedLuminousFlux"></see></summary>
    let contributedLuminousFlux = _prefix "contributedLuminousFlux"
    /// <summary>
    /// The spectrum of radiation describes its composition with regard to wavelength. Light, for example, as the portion of electromagnetic radiation that is visible to the human eye, is radiation with wavelengths in the range of approx. 380 to 780 nm (1 nm = 10 m). The corresponding range of colours varies from violet to indigo, blue, green, yellow, orange, and red. These colours form a continuous spectrum, in which the various spectral sectors merge into each other.
    /// <see href="https://saref.etsi.org/saref4bldg/spectrumMax"></see></summary>
    let spectrumMax = _prefix "spectrumMax"
    /// <summary>
    /// The spectrum of radiation describes its composition with regard to wavelength. Light, for example, as the portion of electromagnetic radiation that is visible to the human eye, is radiation with wavelengths in the range of approx. 380 to 780 nm (1 nm = 10 m). The corresponding range of colours varies from violet to indigo, blue, green, yellow, orange, and red. These colours form a continuous spectrum, in which the various spectral sectors merge into each other.
    /// <see href="https://saref.etsi.org/saref4bldg/spectrumMin"></see></summary>
    let spectrumMin = _prefix "spectrumMin"
    /// <summary>
    /// The color temperature of any source of radiation is defined as the temperature (in Kelvin) of a black-body or Planckian radiator whose radiation has the same chromaticity as the source of radiation. Often the values are only approximate color temperatures as the black-body radiator cannot emit radiation of every chromaticity value. The color temperatures of the commonest artificial light sources range from less than 3000K (warm white) to 4000K (intermediate) and over 5000K (daylight). Usually measured in degrees Kelvin (K).
    /// <see href="https://saref.etsi.org/saref4bldg/colorTemperature"></see></summary>
    let colorTemperature = _prefix "colorTemperature"
    /// <summary>
    /// In both the DIN and CIE standards, artificial light sources are classified in terms of their color appearance. To the human eye they all appear to be white the difference can only be detected by direct comparison. Visual performance is not directly affected by differences in color appearance.
    /// <see href="https://saref.etsi.org/saref4bldg/colorAppearance"></see></summary>
    let colorAppearance = _prefix "colorAppearance"
    /// <summary>
    /// Light emitter nominal power. Usually measured in Watts (W, J/s).
    /// <see href="https://saref.etsi.org/saref4bldg/lightEmitterNominalPower"></see></summary>
    let lightEmitterNominalPower = _prefix "lightEmitterNominalPower"
    /// <summary>
    /// A medical device is attached to a medical piping system and operates upon medical gases to perform a specific function. Medical gases include medical air, medical vacuum, oxygen, carbon dioxide, nitrogen, and nitrous oxide.
    /// <see href="https://saref.etsi.org/saref4bldg/MedicalDevice"></see></summary>
    let MedicalDevice = _prefix "MedicalDevice"
    /// <summary>
    /// An outlet is a device installed at a point to receive one or more inserted plugs for electrical power or communications.
    ///
    /// Power outlets are commonly connected within a junction box; data outlets may be directly connected to a wall. For power outlets sharing the same circuit within a junction box, the ports should indicate the logical wiring relationship to the enclosing junction box, even though they may be physically connected to a cable going to another outlet, switch, or fixture.
    /// <see href="https://saref.etsi.org/saref4bldg/Outlet"></see></summary>
    let Outlet = _prefix "Outlet"
    /// <summary>
    /// The number of sockets that may be connected. In case of inconsistency, sockets defined on ports take precedence.
    /// <see href="https://saref.etsi.org/saref4bldg/numberOsSockets"></see></summary>
    let numberOsSockets = _prefix "numberOsSockets"
    /// <summary>
    /// Indication of whether the outlet accepts a loose plug connection (= TRUE) or whether it is directly connected (= FALSE) or whether the form of connection has not yet been determined (= UNKNOWN).
    /// <see href="https://saref.etsi.org/saref4bldg/isPluggableOutlet"></see></summary>
    let isPluggableOutlet = _prefix "isPluggableOutlet"
    /// <summary>
    /// A relation between an object and the physical space in which it is located.
    /// <see href="https://saref.etsi.org/saref4bldg/isContainedIn"></see></summary>
    let isContainedIn = _prefix "isContainedIn"
    /// <summary>
    /// A protective device breaks an electrical circuit when a stated electric current that passes through it is exceeded.
    ///
    /// A protective device provides protection against electrical current only (not as a general protective device). It may be used to represent the complete set of elements including both the tripping unit and the breaking unit that provide the protection. This may be particularly useful at earlier stages of design where the approach to breaking the electrical supply may be determined but the method of tripping may not. Alternatively, this entity may be used to specifically represent the breaking unit alone (in which case the tripping unit will also be specifically identified). This entity is specific to dedicated protective devices and excludes electrical outlets that may have circuit protection.
    /// <see href="https://saref.etsi.org/saref4bldg/ProtectiveDevice"></see></summary>
    let ProtectiveDevice = _prefix "ProtectiveDevice"
    /// <summary>
    /// A protective device tripping unit breaks an electrical circuit at a separate breaking unit when a stated electric current that passes through the unit is exceeded.
    /// <see href="https://saref.etsi.org/saref4bldg/ProtectiveDeviceTrippingUnit"></see></summary>
    let ProtectiveDeviceTrippingUnit = _prefix "ProtectiveDeviceTrippingUnit"
    /// <summary>
    /// The designation of the standard applicable for the definition of the characteristics of the unit.
    /// <see href="https://saref.etsi.org/saref4bldg/standard"></see></summary>
    let standard = _prefix "standard"
    /// <summary>
    /// The maximum terminal size capacity of the device. Usually measured in square metre (m2).
    /// <see href="https://saref.etsi.org/saref4bldg/limitingTerminalSize"></see></summary>
    let limitingTerminalSize = _prefix "limitingTerminalSize"
    /// <summary>
    /// A pump is a device which imparts mechanical work on fluids or slurries to move them through a channel or pipeline. A typical use of a pump is to circulate chilled water or heating hot water in a building services distribution system.
    /// <see href="https://saref.etsi.org/saref4bldg/Pump"></see></summary>
    let Pump = _prefix "Pump"
    /// <summary>
    /// Allowable range of frictional resistance against which the fluid is being pumped. Usually measured in Pascals (Pa, N/m2).
    /// <see href="https://saref.etsi.org/saref4bldg/flowResistanceMax"></see></summary>
    let flowResistanceMax = _prefix "flowResistanceMax"
    /// <summary>
    /// Allowable range of volume of fluid being pumped against the resistance specified. Usually measured in kg/s.
    /// <see href="https://saref.etsi.org/saref4bldg/pumpFlowRateMin"></see></summary>
    let pumpFlowRateMin = _prefix "pumpFlowRateMin"
    /// <summary>
    /// Pump rotational speed under nominal conditions. Usually measured in cycles/s.
    /// <see href="https://saref.etsi.org/saref4bldg/nomminalRotationSpeed"></see></summary>
    let nomminalRotationSpeed = _prefix "nomminalRotationSpeed"
    /// <summary>
    /// Allowable range of volume of fluid being pumped against the resistance specified. Usually measured in kg/s.
    /// <see href="https://saref.etsi.org/saref4bldg/pumpFlowRateMax"></see></summary>
    let pumpFlowRateMax = _prefix "pumpFlowRateMax"
    /// <summary>
    /// Minimum liquid pressure at the pump inlet to prevent cavitation. Usually measured in Pascals (Pa, N/m2).
    /// <see href="https://saref.etsi.org/saref4bldg/netPositiveSuctionHead"></see></summary>
    let netPositiveSuctionHead = _prefix "netPositiveSuctionHead"
    /// <summary>
    /// Allowable range of frictional resistance against which the fluid is being pumped. Usually measured in Pascals (Pa, N/m2).
    /// <see href="https://saref.etsi.org/saref4bldg/flowResistanceMin"></see></summary>
    let flowResistanceMin = _prefix "flowResistanceMin"
    /// <summary>
    /// The connection size of the to and from the pump. Usually measured in millimeters (mm).
    /// <see href="https://saref.etsi.org/saref4bldg/connectionSize"></see></summary>
    let connectionSize = _prefix "connectionSize"
    /// <summary>
    /// A sanitary terminal is a fixed appliance or terminal usually supplied with water and used for drinking, cleaning or foul water disposal or that is an item of equipment directly used with such an appliance or terminal.
    /// <see href="https://saref.etsi.org/saref4bldg/SanitaryTerminal"></see></summary>
    let SanitaryTerminal = _prefix "SanitaryTerminal"
    /// <summary>
    /// A sensor is a device that measures a physical quantity and converts it into a signal which can be read by an observer or by an instrument.
    /// <see href="https://saref.etsi.org/saref4bldg/Sensor"></see></summary>
    let Sensor = _prefix "Sensor"
    /// <summary>
    /// Shading devices are purpose built devices to protect from the sunlight, from natural light, or screening them from view. Shading devices can form part of the facade or can be mounted inside the building, they can be fixed or operable.
    /// <see href="https://saref.etsi.org/saref4bldg/ShadingDevice"></see></summary>
    let ShadingDevice = _prefix "ShadingDevice"
    /// <summary>
    /// A measure of the vertical deviations of the surface.
    /// <see href="https://saref.etsi.org/saref4bldg/roughness"></see></summary>
    let roughness = _prefix "roughness"
    /// <summary>
    /// Indication whether the element is operated machanically (TRUE) or not, i.e. manually (FALSE).
    /// <see href="https://saref.etsi.org/saref4bldg/mechanicalOperated"></see></summary>
    let mechanicalOperated = _prefix "mechanicalOperated"
    /// <summary>
    /// Fraction of the visible light that passes the shading system at normal incidence. It is a value without unit.
    /// <see href="https://saref.etsi.org/saref4bldg/visibleLightTransmittance"></see></summary>
    let visibleLightTransmittance = _prefix "visibleLightTransmittance"
    /// <summary>
    /// (Rsol): The ratio of incident solar radiation that is reflected by a shading system (also named _e). Note the following equation Asol + Rsol + Tsol = 1
    /// <see href="https://saref.etsi.org/saref4bldg/solarReflectance"></see></summary>
    let solarReflectance = _prefix "solarReflectance"
    /// <summary>
    /// Fraction of the visible light that is reflected by the glazing at normal incidence. It is a value without unit.
    /// <see href="https://saref.etsi.org/saref4bldg/visibleLightReflectance"></see></summary>
    let visibleLightReflectance = _prefix "visibleLightReflectance"
    /// <summary>
    /// Specifies the type of shading device.
    /// <see href="https://saref.etsi.org/saref4bldg/shadingDeviceType"></see></summary>
    let shadingDeviceType = _prefix "shadingDeviceType"
    /// <summary>
    /// (Tsol) The ratio of incident solar radiation that directly passes through a shading system (also named _e). Note the following equation Asol + Rsol + Tsol = 1
    /// <see href="https://saref.etsi.org/saref4bldg/solarTransmittance"></see></summary>
    let solarTransmittance = _prefix "solarTransmittance"
    /// <summary>
    /// Indication whether the element is designed for use in the exterior (TRUE) or not (FALSE). If (TRUE) it is an external element and faces the outside of the building.
    /// <see href="https://saref.etsi.org/saref4bldg/isExternal"></see></summary>
    let isExternal = _prefix "isExternal"
    /// <summary>
    /// Rate at which energy is transmitted through a body. Usually measured in Watts/m2 Kelvin.
    /// <see href="https://saref.etsi.org/saref4bldg/thermalTransmittance"></see></summary>
    let thermalTransmittance = _prefix "thermalTransmittance"
    /// <summary>
    /// A solar device converts solar radiation into other energy such as electric current or thermal energy.
    /// <see href="https://saref.etsi.org/saref4bldg/SolarDevice"></see></summary>
    let SolarDevice = _prefix "SolarDevice"
    /// <summary>
    /// Space heaters utilize a combination of radiation and/or natural convection using a heating source such as electricity, steam or hot water to heat a limited space or area. Examples of space heaters include radiators, convectors, baseboard and finned-tube heaters.
    ///
    /// UnitaryEquipment should be used for packaged units supporting a combination of heating, cooling, and/or dehumidification; Coil should be used for coil-based floor heating.
    /// <see href="https://saref.etsi.org/saref4bldg/SpaceHeater"></see></summary>
    let SpaceHeater = _prefix "SpaceHeater"
    /// <summary>
    /// Number of sections used.
    /// <see href="https://saref.etsi.org/saref4bldg/numberOfSections"></see></summary>
    let numberOfSections = _prefix "numberOfSections"
    /// <summary>
    /// Product of component mass and specific heat.
    /// <see href="https://saref.etsi.org/saref4bldg/thermalMassHeatCapacity"></see></summary>
    let thermalMassHeatCapacity = _prefix "thermalMassHeatCapacity"
    /// <summary>
    /// Indicates how heat is transmitted according to the shape of the space heater.
    /// <see href="https://saref.etsi.org/saref4bldg/heatTransferDimension"></see></summary>
    let heatTransferDimension = _prefix "heatTransferDimension"
    /// <summary>
    /// Total nominal heat output as listed by the manufacturer. Usually measured in Watts (W, J/s).
    /// <see href="https://saref.etsi.org/saref4bldg/outputCapacity"></see></summary>
    let outputCapacity = _prefix "outputCapacity"
    /// <summary>
    /// Overall Thermal Efficiency is defined as gross energy output of the heat transfer device divided by the energy input.
    /// <see href="https://saref.etsi.org/saref4bldg/thermalEfficiency"></see></summary>
    let thermalEfficiency = _prefix "thermalEfficiency"
    /// <summary>
    /// Overall body mass of the heater. Usually measured in kilograms (kg) or grams (g).
    /// <see href="https://saref.etsi.org/saref4bldg/bodyMass"></see></summary>
    let bodyMass = _prefix "bodyMass"
    /// <summary>
    /// Enumeration defining the temperature classification of the space heater surface temperature. low temperature - surface temperature is relatively low, usually heated by hot water or electricity. high temperature - surface temperature is relatively high, usually heated by gas or steam.
    /// <see href="https://saref.etsi.org/saref4bldg/temperatureClassification"></see></summary>
    let temperatureClassification = _prefix "temperatureClassification"
    /// <summary>
    /// Number of panels.
    /// <see href="https://saref.etsi.org/saref4bldg/numberOfPanels"></see></summary>
    let numberOfPanels = _prefix "numberOfPanels"
    /// <summary>
    /// Enumeration defining the heat transfer medium if applicable.
    /// <see href="https://saref.etsi.org/saref4bldg/heatTransferMedium"></see></summary>
    let heatTransferMedium = _prefix "heatTransferMedium"
    /// <summary>
    /// A switch is used in a cable distribution system (electrical circuit) to control or modulate the flow of electricity.
    ///
    /// Switches include those used for electrical power, communications, audio-visual, or other distribution system types as determined by the available ports.
    /// <see href="https://saref.etsi.org/saref4bldg/SwitchingDevice"></see></summary>
    let SwitchingDevice = _prefix "SwitchingDevice"
    /// <summary>
    /// Number of gangs/buttons on this switch.
    /// <see href="https://saref.etsi.org/saref4bldg/numberOfGangs"></see></summary>
    let numberOfGangs = _prefix "numberOfGangs"
    /// <summary>
    /// Indicates types of switches which differs in functionality.
    /// <see href="https://saref.etsi.org/saref4bldg/switchFunction"></see></summary>
    let switchFunction = _prefix "switchFunction"
    /// <summary>
    /// A text inscribed or applied to the switch as a legend to indicate purpose or function.
    /// <see href="https://saref.etsi.org/saref4bldg/legend"></see></summary>
    let legend = _prefix "legend"
    /// <summary>
    /// Indication of whether a switching device has a key operated lock (=TRUE) or not (= FALSE).
    /// <see href="https://saref.etsi.org/saref4bldg/hasLock"></see></summary>
    let hasLock = _prefix "hasLock"
    /// <summary>
    /// An indication of whether there is an illuminated indicator to show that the switch is on (=TRUE) or not (= FALSE).
    /// <see href="https://saref.etsi.org/saref4bldg/isIlluminated"></see></summary>
    let isIlluminated = _prefix "isIlluminated"
    /// <summary>
    /// A tank is a vessel or container in which a fluid or gas is stored for later use.
    /// <see href="https://saref.etsi.org/saref4bldg/Tank"></see></summary>
    let Tank = _prefix "Tank"
    /// <summary>
    /// SecondCurvatureRadius should be defined as the top or right side radius of curvature value. Usually measured in millimeters (mm).
    /// <see href="https://saref.etsi.org/saref4bldg/secondCurvatureRadius"></see></summary>
    let secondCurvatureRadius = _prefix "secondCurvatureRadius"
    /// <summary>
    /// Defines the types of end shapes that can be used for preformed tanks. The convention for reading these enumerated values is that for a vertical cylinder, the first value is the base and the second is the top for a horizontal cylinder, the order of reading should be left to right. For a speherical tank, the value UNSET should be used.B5
    /// <see href="https://saref.etsi.org/saref4bldg/endShapeType"></see></summary>
    let endShapeType = _prefix "endShapeType"
    /// <summary>
    /// The nominal length or, in the case of a vertical cylindrical tank, the nominal diameter of the tank. Usually measured in millimeters (mm).
    /// <see href="https://saref.etsi.org/saref4bldg/nominalLengthOrDiameter"></see></summary>
    let nominalLengthOrDiameter = _prefix "nominalLengthOrDiameter"
    /// <summary>
    /// The nominal width or, in the case of a horizontal cylindrical tank, the nominal diameter of the tank. Note: Not required for a vertical cylindrical tank. Usually measured in millimeters (mm).
    /// <see href="https://saref.etsi.org/saref4bldg/nominalWidthOrDiameter"></see></summary>
    let nominalWidthOrDiameter = _prefix "nominalWidthOrDiameter"
    /// <summary>
    /// Defines the general material category intended to be stored.
    /// <see href="https://saref.etsi.org/saref4bldg/storageType"></see></summary>
    let storageType = _prefix "storageType"
    /// <summary>
    /// Defines the types of pattern (or shape of a tank that may be specified.
    /// <see href="https://saref.etsi.org/saref4bldg/patternType"></see></summary>
    let patternType = _prefix "patternType"
    /// <summary>
    /// Operating weight of the tank including all of its contents. Usually measured in kilograms (kg) or grams (g).
    /// <see href="https://saref.etsi.org/saref4bldg/operatingWeight"></see></summary>
    let operatingWeight = _prefix "operatingWeight"
    /// <summary>
    /// The total effective or actual volumetric capacity of the tank. Usually measured in cubic metre (m3).B3
    /// <see href="https://saref.etsi.org/saref4bldg/effectiveCapacity"></see></summary>
    let effectiveCapacity = _prefix "effectiveCapacity"
    /// <summary>
    /// Defines the types of access (or cover) to a tank that may be specified. Note that covers are generally specified for rectangular tanks. For cylindrical tanks, access will normally be via a manhole.
    /// <see href="https://saref.etsi.org/saref4bldg/accessType"></see></summary>
    let accessType = _prefix "accessType"
    /// <summary>
    /// The total nominal or design volumetric capacity of the tank. Usually measured in cubic metre (m3).
    /// <see href="https://saref.etsi.org/saref4bldg/nominalVolumetricCapacity"></see></summary>
    let nominalVolumetricCapacity = _prefix "nominalVolumetricCapacity"
    /// <summary>
    /// The nominal depth of the tank. Note: Not required for a horizontal cylindrical tank. Usually measured in millimeters (mm).
    /// <see href="https://saref.etsi.org/saref4bldg/nominalDepth"></see></summary>
    let nominalDepth = _prefix "nominalDepth"
    /// <summary>
    /// FirstCurvatureRadius should be defined as the base or left side radius of curvature value. Usually measured in millimeters (mm).
    /// <see href="https://saref.etsi.org/saref4bldg/firstCurvatureRadius"></see></summary>
    let firstCurvatureRadius = _prefix "firstCurvatureRadius"
    /// <summary>
    /// A transformer is an inductive stationary device that transfers electrical energy from one circuit to another.
    ///
    /// Transformer is used to transform electric power; conversion of electric signals for other purposes is handled at other entities: Controller converts arbitrary signals, AudioVisualAppliance converts signals for audio or video streams, and CommunicationsAppliance converts signals for data or other communications usage.
    /// <see href="https://saref.etsi.org/saref4bldg/Transformer"></see></summary>
    let Transformer = _prefix "Transformer"
    /// <summary>
    /// The current that has been transformed and is running out of the transformer on the secondary side. Usually measured in Ampere (A).
    /// <see href="https://saref.etsi.org/saref4bldg/secondaryCurrent"></see></summary>
    let secondaryCurrent = _prefix "secondaryCurrent"
    /// <summary>
    /// Maximum apparent power/capacity in VA (volt ampere). Usually measured in Watts (W, J/s).
    /// <see href="https://saref.etsi.org/saref4bldg/apparentPowerMax"></see></summary>
    let apparentPowerMax = _prefix "apparentPowerMax"
    /// <summary>
    /// List of the possible vector groups for the transformer from which that required may be set. Values in the enumeration list follow a standard international code where the first letter describes how the primary windings are connected, the second letter describes how the secondary windings are connected, and the numbers describe the rotation of voltages and currents from the primary to the secondary side in multiples of 30 degrees. D: means that the windings are delta-connected. Y: means that the windings are star-connected. Z: means that the windings are zig-zag connected (a special start-connected providing low reactance of the transformer). The connectivity is only relevant for three-phase transformers.
    /// <see href="https://saref.etsi.org/saref4bldg/transformerVectorGroup"></see></summary>
    let transformerVectorGroup = _prefix "transformerVectorGroup"
    /// <summary>
    /// The voltage that is going to be transformed and that runs into the transformer on the primary side. Usually measured in Volts (V, W/A).
    /// <see href="https://saref.etsi.org/saref4bldg/primaryVoltage"></see></summary>
    let primaryVoltage = _prefix "primaryVoltage"
    /// <summary>
    /// The ratio between the real part of the zero sequence impedance and the real part of the positive impedance (i.e. real part of the short-circuit voltage) of the transformer. Used for three-phase transformer which includes a N-conductor.
    /// <see href="https://saref.etsi.org/saref4bldg/realImpedanceRatio"></see></summary>
    let realImpedanceRatio = _prefix "realImpedanceRatio"
    /// <summary>
    /// The power in VA (volt ampere) that has been transformed and that runs into the transformer on the primary side. Usually measured in Watts (W, J/s).
    /// <see href="https://saref.etsi.org/saref4bldg/primaryApparentPower"></see></summary>
    let primaryApparentPower = _prefix "primaryApparentPower"
    /// <summary>
    /// The voltage that has been transformed and is running out of the transformer on the secondary side. Usually measured in Volts (V, W/A).
    /// <see href="https://saref.etsi.org/saref4bldg/secondaryVoltage"></see></summary>
    let secondaryVoltage = _prefix "secondaryVoltage"

    /// <summary>
    /// An indication of whether the neutral point of the secondary winding is available as a terminal (=TRUE) or not (= FALSE).
    /// <see href="https://saref.etsi.org/saref4bldg/isNeutralSecondaryTerminalAvailable"></see></summary>
    let isNeutralSecondaryTerminalAvailable =
        _prefix "isNeutralSecondaryTerminalAvailable"

    /// <summary>
    /// The current that is going to be transformed and that runs into the transformer on the primary side. Usually measured in Ampere (A).
    /// <see href="https://saref.etsi.org/saref4bldg/primaryCurrent"></see></summary>
    let primaryCurrent = _prefix "primaryCurrent"
    /// <summary>
    /// The ratio between the imaginary part of the zero sequence impedance and the imaginary part of the positive impedance (i.e. imaginary part of the short-circuit voltage) of the transformer. Used for three-phase transformer which includes a N-conductor.
    /// <see href="https://saref.etsi.org/saref4bldg/imaginaryImpedanceRatio"></see></summary>
    let imaginaryImpedanceRatio = _prefix "imaginaryImpedanceRatio"
    /// <summary>
    /// The frequency that has been transformed and is running out of the transformer on the secondary side. Usually measured in cycles/s or Hertz (Hz).
    /// <see href="https://saref.etsi.org/saref4bldg/secondaryFrequency"></see></summary>
    let secondaryFrequency = _prefix "secondaryFrequency"
    /// <summary>
    /// The frequency that is going to be transformed and that runs into the transformer on the primary side. Usually measured in cycles/s or Hertz (Hz).
    /// <see href="https://saref.etsi.org/saref4bldg/primaryFrequency"></see></summary>
    let primaryFrequency = _prefix "primaryFrequency"
    /// <summary>
    /// An indication of whether the neutral point of the primary winding is available as a terminal (=TRUE) or not (= FALSE).
    /// <see href="https://saref.etsi.org/saref4bldg/isNeutralPrimaryTerminalAvailable"></see></summary>
    let isNeutralPrimaryTerminalAvailable = _prefix "isNeutralPrimaryTerminalAvailable"
    /// <summary>
    /// A list of the secondary current types that can result from transformer output.
    /// <see href="https://saref.etsi.org/saref4bldg/secondaryCurrentType"></see></summary>
    let secondaryCurrentType = _prefix "secondaryCurrentType"
    /// <summary>
    /// The power in VA (volt ampere) that has been transformed and is running out of the transformer on the secondary side. Usually measured in Watts (W, J/s).
    /// <see href="https://saref.etsi.org/saref4bldg/secondaryApparentPower"></see></summary>
    let secondaryApparentPower = _prefix "secondaryApparentPower"
    /// <summary>
    /// A transport element is a generalization of all transport related objects that move people, animals or goods within a building or building complex. The TransportElement defines the occurrence of a transport element.
    /// <see href="https://saref.etsi.org/saref4bldg/TransportElement"></see></summary>
    let TransportElement = _prefix "TransportElement"
    /// <summary>
    /// Capacity of the transportation element measured in numbers of person.
    /// <see href="https://saref.etsi.org/saref4bldg/capacityPeople"></see></summary>
    let capacityPeople = _prefix "capacityPeople"
    /// <summary>
    /// Indication whether this object is designed to serve as an exit in the case of fire (TRUE) or not (FALSE). Here whether the transport element (in case of e.g., a lift) is designed to serve as a fire exit, e.g., for fire escape purposes.
    /// <see href="https://saref.etsi.org/saref4bldg/fireExit"></see></summary>
    let fireExit = _prefix "fireExit"
    /// <summary>
    /// Capacity of the transport element measured by weight. Usually measured in kilograms (kg) or grams (g).
    /// <see href="https://saref.etsi.org/saref4bldg/capacityWeight"></see></summary>
    let capacityWeight = _prefix "capacityWeight"
    /// <summary>
    /// A tube bundle is a device consisting of tubes and bundles of tubes used for heat transfer and contained typically within other energy conversion devices, such as a chiller or coil.
    /// <see href="https://saref.etsi.org/saref4bldg/TubeBundle"></see></summary>
    let TubeBundle = _prefix "TubeBundle"
    /// <summary>
    /// Total volume of fluid in the tubes and their headers. Usually measured in cubic metre (m3).
    /// <see href="https://saref.etsi.org/saref4bldg/volumen"></see></summary>
    let volumen = _prefix "volumen"
    /// <summary>
    /// Actual outside diameter of the tube in the tube bundle. Usually measured in millimeters (mm).
    /// <see href="https://saref.etsi.org/saref4bldg/outsideDiameter"></see></summary>
    let outsideDiameter = _prefix "outsideDiameter"
    /// <summary>
    /// Horizontal spacing between tubes in the tube bundle. Usually measured in millimeters (mm).
    /// <see href="https://saref.etsi.org/saref4bldg/horizontalSpacing"></see></summary>
    let horizontalSpacing = _prefix "horizontalSpacing"
    /// <summary>
    /// In-line tube row spacing. Usually measured in millimeters (mm).
    /// <see href="https://saref.etsi.org/saref4bldg/inLineRowSpacing"></see></summary>
    let inLineRowSpacing = _prefix "inLineRowSpacing"
    /// <summary>
    /// Vertical spacing between tubes in the tube bundle.Usually measured in millimeters (mm).
    /// <see href="https://saref.etsi.org/saref4bldg/verticalSpacing"></see></summary>
    let verticalSpacing = _prefix "verticalSpacing"
    /// <summary>
    /// TRUE if the tube has a turbulator, FALSE if it does not.
    /// <see href="https://saref.etsi.org/saref4bldg/hasTurbulator"></see></summary>
    let hasTurbulator = _prefix "hasTurbulator"
    /// <summary>
    /// Fouling factor of the tubes in the tube bundle. Usually measured in m2 Kelvin/Watt.
    /// <see href="https://saref.etsi.org/saref4bldg/foulingFactor"></see></summary>
    let foulingFactor = _prefix "foulingFactor"
    /// <summary>
    /// Nominal diameter or width of the tubes in the tube bundle. Usually measured in millimeters (mm).
    /// <see href="https://saref.etsi.org/saref4bldg/nominalDiameter"></see></summary>
    let nominalDiameter = _prefix "nominalDiameter"
    /// <summary>
    /// Fouling factor of the tubes in the tube bundle. Usually measured in m2 Kelvin/Watt.
    /// <see href="https://saref.etsi.org/saref4bldg/thermalConductivity"></see></summary>
    let thermalConductivity = _prefix "thermalConductivity"
    /// <summary>
    /// Staggered tube row spacing. Usually measured in millimeters (mm).
    /// <see href="https://saref.etsi.org/saref4bldg/staggeredRowSpacing"></see></summary>
    let staggeredRowSpacing = _prefix "staggeredRowSpacing"
    /// <summary>
    /// Number of parallel fluid tube circuits.
    /// <see href="https://saref.etsi.org/saref4bldg/numberOfCircuits"></see></summary>
    let numberOfCircuits = _prefix "numberOfCircuits"
    /// <summary>
    /// Actual inner diameter of the tube in the tube bundle. Usually measured in millimeters (mm).
    /// <see href="https://saref.etsi.org/saref4bldg/insideDiameter"></see></summary>
    let insideDiameter = _prefix "insideDiameter"
    /// <summary>
    /// Number of tube rows in the tube bundle assembly.
    /// <see href="https://saref.etsi.org/saref4bldg/numberOfRows"></see></summary>
    let numberOfRows = _prefix "numberOfRows"
    /// <summary>
    /// A unitary control element combines a number of control components into a single product, such as a thermostat or humidistat.
    ///
    /// A unitary control element provides a housing for an aggregation of control or electrical distribution elements that, in combination, perform a singular (unitary) purpose. Each item in the aggregation may have its own geometric representation and location.
    /// <see href="https://saref.etsi.org/saref4bldg/UnitaryControlElement"></see></summary>
    let UnitaryControlElement = _prefix "UnitaryControlElement"
    /// <summary>
    /// A valve is used in a building services piping distribution system to control or modulate the flow of the fluid.
    /// <see href="https://saref.etsi.org/saref4bldg/Valve"></see></summary>
    let Valve = _prefix "Valve"
    /// <summary>
    /// The normally expected maximum working pressure of the valve. Usually measured in Pascals (Pa, N/m2).
    /// <see href="https://saref.etsi.org/saref4bldg/workingPressure"></see></summary>
    let workingPressure = _prefix "workingPressure"
    /// <summary>
    /// The size of the connection to the valve (or to each connection for faucets, mixing valves, etc.). Usually measured in millimeters (mm).
    /// <see href="https://saref.etsi.org/saref4bldg/size"></see></summary>
    let size = _prefix "size"
    /// <summary>
    /// The maximum pressure to which the valve has been subjected under test. Usually measured in Pascals (Pa, N/m2).
    /// <see href="https://saref.etsi.org/saref4bldg/testPressure"></see></summary>
    let testPressure = _prefix "testPressure"
    /// <summary>
    /// The method of valve operation where: DROPWEIGHT: A valve that is closed by the action of a weighted lever being released, the weight normally being prevented from dropping by being held by a wire, the closure normally being made by the action of heat on a fusible link in the wire FLOAT: A valve that is opened and closed by the action of a float that rises and falls with water level. The float may be a ball attached to a lever or other mechanism HYDRAULIC: A valve that is opened and closed by hydraulic actuation LEVER: A valve that is opened and closed by the action of a lever rotating the gate within the valve. LOCKSHIELD: A valve that requires the use of a special lockshield key for opening and closing, the operating mechanism being protected by a shroud during normal operation. MOTORIZED: A valve that is opened and closed by the action of an electric motor on an actuator PNEUMATIC: A valve that is opened and closed by pneumatic actuation SOLENOID: A valve that is normally held open by a magnetic field in a coil acting on the gate but that is closed immediately if the electrical current generating the magnetic field is removed. SPRING: A valve that is normally held in position by the pressure of a spring on a plate but that may be caused to open if the pressure of the fluid is sufficient to overcome the spring pressure. THERMOSTATIC: A valve in which the ports are opened or closed to maintain a required predetermined temperature. WHEEL: A valve that is opened and closed by the action of a wheel moving the gate within the valve.
    /// <see href="https://saref.etsi.org/saref4bldg/valveOperation"></see></summary>
    let valveOperation = _prefix "valveOperation"
    /// <summary>
    /// The mechanism by which the valve function is achieved where: BALL: Valve that has a ported ball that can be turned relative to the body seat ports. BUTTERFLY: Valve in which a streamlined disc pivots about a diametric axis. CONFIGUREDGATE: Screwdown valve in which the closing gate is shaped in a configured manner to have a more precise control of pressure and flow change across the valve. GLAND: Valve with a tapered seating, in which a rotatable plug is retained by means of a gland and gland packing. GLOBE: Screwdown valve that has a spherical body. LUBRICATEDPLUG: Plug valve in which a lubricant is injected under pressure between the plug face and the body. NEEDLE: Valve for regulating the flow in or from a pipe, in which a slender cone moves along the axis of flow to close against a fixed conical seat. PARALLELSLIDE: Screwdown valve that has a machined plate that slides in formed grooves to form a seal. PLUG: Valve that has a ported plug that can be turned relative to the body seat ports. WEDGEGATE: Screwdown valve that has a wedge shaped plate fitting into tapered guides to form a seal.
    /// <see href="https://saref.etsi.org/saref4bldg/valveMechanism"></see></summary>
    let valveMechanism = _prefix "valveMechanism"
    /// <summary>
    /// Flow coefficient (the quantity of fluid that passes through a fully open valve at unit pressure drop), typically expressed as the Kv or Cv value for the valve.
    /// <see href="https://saref.etsi.org/saref4bldg/flowCoefficient"></see></summary>
    let flowCoefficient = _prefix "flowCoefficient"
    /// <summary>
    /// The configuration of the ports of a valve according to either the linear route taken by a fluid flowing through the valve or by the number of ports where: SINGLEPORT: Valve that has a single entry port from the system that it serves, the exit port being to the surrounding environment. ANGLED_2_PORT: Valve in which the direction of flow is changed through 90 degrees. STRAIGHT_2_PORT: Valve in which the flow is straight through. STRAIGHT_3_PORT: Valve with three separate ports. CROSSOVER_4_PORT: Valve with 4 separate ports.
    /// <see href="https://saref.etsi.org/saref4bldg/valvePattern"></see></summary>
    let valvePattern = _prefix "valvePattern"
    /// <summary>
    /// A vibration isolator is a device used to minimize the effects of vibration transmissibility in a building.
    /// <see href="https://saref.etsi.org/saref4bldg/VibrationIsolator"></see></summary>
    let VibrationIsolator = _prefix "VibrationIsolator"
    /// <summary>
    /// The maximum weight that can be carried by the vibration isolator. Usually measured in kilograms (kg) or grams (g).
    /// <see href="https://saref.etsi.org/saref4bldg/supportedWeightMax"></see></summary>
    let supportedWeightMax = _prefix "supportedWeightMax"
    /// <summary>
    /// Static deflection of the vibration isolator. Usually measured in millimeters (mm).
    /// <see href="https://saref.etsi.org/saref4bldg/isolatorStaticDeflection"></see></summary>
    let isolatorStaticDeflection = _prefix "isolatorStaticDeflection"
    /// <summary>
    /// Height of the vibration isolator before tha application of load. Usually measured in millimeters (mm).
    /// <see href="https://saref.etsi.org/saref4bldg/height"></see></summary>
    let height = _prefix "height"
    /// <summary>
    /// The vibration transmissibility percentage.
    /// <see href="https://saref.etsi.org/saref4bldg/vibrationTransmissibility"></see></summary>
    let vibrationTransmissibility = _prefix "vibrationTransmissibility"
    /// <summary>
    /// The compressibility of the vibration isolator.
    /// <see href="https://saref.etsi.org/saref4bldg/isolatorCompressibility"></see></summary>
    let isolatorCompressibility = _prefix "isolatorCompressibility"
    /// <summary>
    /// The maximum and minimum allowed voltage of the supply e.g. boundaries of 380V/440V may be applied for a nominal voltage of 400V.
    /// <see href="https://saref.etsi.org/saref4bldg/nominalSupplyVoltageMax"></see></summary>
    let nominalSupplyVoltageMax = _prefix "nominalSupplyVoltageMax"
    /// <summary>
    /// A complex number that specifies the real and imaginary parts of the short-circuit voltage at rated current of a transformer given in %.
    /// <see href="https://saref.etsi.org/saref4bldg/shortCircuitVoltage"></see></summary>
    let shortCircuitVoltage = _prefix "shortCircuitVoltage"
