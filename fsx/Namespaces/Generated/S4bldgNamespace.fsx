#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module s4bldg =
    let _prefixId = PrefixId.fromNamespaceLabel "https://saref.etsi.org/saref4bldg/" "s4bldg"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcActuator^^xsd:string</para>
    ///   <para>rdfs:label : Actuator</para>
    ///   <para>rdfs:comment : An actuator is a mechanical device for moving or controlling a mechanism or system. An actuator takes energy, usually created by air, electricity, or liquid, and converts that into some kind of motion.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/Actuator">s4bldg:Actuator</a>
    /// </summary>
    let Actuator = _prefixId.prefix "Actuator"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcAirToAirHeatRecovery^^xsd:string</para>
    ///   <para>rdfs:comment : An air-to-air heat recovery device employs a counter-flow heat exchanger between inbound and outbound air flow. It is typically used to transfer heat from warmer air in one chamber to cooler air in the second chamber (i.e., typically used to recover heat from the conditioned air being exhausted and the outside air being supplied to a building), resulting in energy savings from reduced heating (or cooling) requirements.</para>
    ///   <para>rdfs:label : Air to air heat recovery</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/AirToAirHeatRecovery">s4bldg:AirToAirHeatRecovery</a>
    /// </summary>
    let AirToAirHeatRecovery = _prefixId.prefix "AirToAirHeatRecovery"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcAlarm^^xsd:string</para>
    ///   <para>rdfs:label : Alarm</para>
    ///   <para>rdfs:comment : An alarm is a device that signals the existence of a condition or situation that is outside the boundaries of normal expectation or that activates such a device.
    ///
    /// Alarms include the provision of break glass buttons and manual pull boxes that are used to activate alarms.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/Alarm">s4bldg:Alarm</a>
    /// </summary>
    let Alarm = _prefixId.prefix "Alarm"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcAudioVisualApplicance^^xsd:string</para>
    ///   <para>rdfs:label : Audio visual appliance</para>
    ///   <para>rdfs:comment : An audio-visual appliance is a device that displays, captures, transmits, or receives audio or video.
    ///
    /// Audio-visual appliances may be fixed in place or may be able to be moved from one space to another. They may require an electrical supply that may be supplied either by an electrical circuit or provided from a local battery source. Audio-visual appliances may be connected to data circuits including specialist circuits for audio visual purposes only.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/AudioVisualAppliance">s4bldg:AudioVisualAppliance</a>
    /// </summary>
    let AudioVisualAppliance = _prefixId.prefix "AudioVisualAppliance"
    /// <summary>
    ///   <para>rdfs:comment : A boiler is a closed, pressure-rated vessel in which water or other fluid is heated using an energy source such as natural gas, heating oil, or electricity. The fluid in the vessel is then circulated out of the boiler for use in various processes or heating applications.</para>
    ///   <para>rdfs:label : Boiler</para>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcBoiler^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/Boiler">s4bldg:Boiler</a>
    /// </summary>
    let Boiler = _prefixId.prefix "Boiler"
    /// <summary>
    ///   <para>rdfs:label : Building</para>
    ///   <para>rdfs:comment : A building represents a structure that provides shelter for its occupants or contents and stands in one place. The building is also used to provide a basic element within the spatial structure hierarchy for the components of a building project (together with site, storey, and space).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/Building">s4bldg:Building</a>
    /// </summary>
    let Building = _prefixId.prefix "Building"
    /// <summary>
    ///   <para>rdfs:label : Building device</para>
    ///   <para>rdfs:comment : A tangible object designed to accomplish a particular task in a building.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/BuildingDevice">s4bldg:BuildingDevice</a>
    /// </summary>
    let BuildingDevice = _prefixId.prefix "BuildingDevice"
    /// <summary>
    ///   <para>rdfs:label : Building object</para>
    ///   <para>rdfs:comment : An object in the building that can be controlled by devices, such as a door or a window that can be automatically opened or closed by an actuator.  (Definition taken from SAREF 1.0)</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/BuildingObject">s4bldg:BuildingObject</a>
    /// </summary>
    let BuildingObject = _prefixId.prefix "BuildingObject"
    /// <summary>
    ///   <para>rdfs:label : Building space</para>
    ///   <para>rdfs:comment : An entity used to define the physical spaces of the building. A building space contains devices or building objects.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/BuildingSpace">s4bldg:BuildingSpace</a>
    /// </summary>
    let BuildingSpace = _prefixId.prefix "BuildingSpace"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcBurner^^xsd:string</para>
    ///   <para>rdfs:label : Burner</para>
    ///   <para>rdfs:comment : A burner is a device that converts fuel into heat through combustion. It includes gas, oil, and wood burners.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/Burner">s4bldg:Burner</a>
    /// </summary>
    let Burner = _prefixId.prefix "Burner"
    /// <summary>
    ///   <para>rdfs:label : Chiller</para>
    ///   <para>rdfs:comment : A chiller is a device used to remove heat from a liquid via a vapor-compression or absorption refrigeration cycle to cool a fluid, typically water or a mixture of water and glycol. The chilled fluid is then used to cool and dehumidify air in a building.</para>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcChiller^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/Chiller">s4bldg:Chiller</a>
    /// </summary>
    let Chiller = _prefixId.prefix "Chiller"
    /// <summary>
    ///   <para>rdfs:label : Coil</para>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcCoil^^xsd:string</para>
    ///   <para>rdfs:comment : A coil is a device used to provide heat transfer between non-mixing media. A common example is a cooling coil, which utilizes a finned coil in which circulates chilled water, antifreeze, or refrigerant that is used to remove heat from air moving across the surface of the coil. A coil may be used either for heating or cooling purposes by placing a series of tubes (the coil) carrying a heating or cooling fluid into an airstream. The coil may be constructed from tubes bundled in a serpentine form or from finned tubes that give a extended heat transfer surface.
    ///
    /// Coils may also be used for non-airflow cases such as embedded in a floor slab.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/Coil">s4bldg:Coil</a>
    /// </summary>
    let Coil = _prefixId.prefix "Coil"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcCommunicationAppliance^^xsd:string</para>
    ///   <para>rdfs:label : Communication appliance</para>
    ///   <para>rdfs:comment : A communications appliance transmits and receives electronic or digital information as data or sound.
    ///
    /// Communication appliances may be fixed in place or may be able to be moved from one space to another. Communication appliances require an electrical supply that may be supplied either by an electrical circuit or provided from a local battery source.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/CommunicationAppliance">s4bldg:CommunicationAppliance</a>
    /// </summary>
    let CommunicationAppliance = _prefixId.prefix "CommunicationAppliance"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcCompressor^^xsd:string</para>
    ///   <para>rdfs:comment : A compressor is a device that compresses a fluid typically used in a refrigeration circuit.</para>
    ///   <para>rdfs:label : Compressor</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/Compressor">s4bldg:Compressor</a>
    /// </summary>
    let Compressor = _prefixId.prefix "Compressor"
    /// <summary>
    ///   <para>rdfs:comment : A condenser is a device that is used to dissipate heat, typically by condensing a substance such as a refrigerant from its gaseous to its liquid state.</para>
    ///   <para>rdfs:label : Condenser</para>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcCondenser^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/Condenser">s4bldg:Condenser</a>
    /// </summary>
    let Condenser = _prefixId.prefix "Condenser"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcController^^xsd:string</para>
    ///   <para>rdfs:label : Controller</para>
    ///   <para>rdfs:comment : A controller is a device that monitors inputs and controls outputs within a building automation system.
    ///
    /// A controller may be physical (having placement within a spatial structure) or logical (a software interface or aggregated within a programmable physical controller).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/Controller">s4bldg:Controller</a>
    /// </summary>
    let Controller = _prefixId.prefix "Controller"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcCooledBeam^^xsd:string</para>
    ///   <para>rdfs:comment : A cooled beam (or chilled beam) is a device typically used to cool air by circulating a fluid such as chilled water through exposed finned tubes above a space. Typically mounted overhead near or within a ceiling, the cooled beam uses convection to cool the space below it by acting as a heat sink for the naturally rising warm air of the space. Once cooled, the air naturally drops back to the floor where the cycle begins again.</para>
    ///   <para>rdfs:label : Cooled beam</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/CooledBeam">s4bldg:CooledBeam</a>
    /// </summary>
    let CooledBeam = _prefixId.prefix "CooledBeam"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcCoolingTower^^xsd:string</para>
    ///   <para>rdfs:comment : A cooling tower is a device which rejects heat to ambient air by circulating a fluid such as water through it to reduce its temperature by partial evaporation.</para>
    ///   <para>rdfs:label : Cooling tower</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/CoolingTower">s4bldg:CoolingTower</a>
    /// </summary>
    let CoolingTower = _prefixId.prefix "CoolingTower"
    /// <summary>
    ///   <para>rdfs:label : Damper</para>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcDamper^^xsd:string</para>
    ///   <para>rdfs:comment : A damper typically participates in an HVAC duct distribution system and is used to control or modulate the flow of air.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/Damper">s4bldg:Damper</a>
    /// </summary>
    let Damper = _prefixId.prefix "Damper"
    /// <summary>
    ///   <para>rdfs:label : Distribution control device</para>
    ///   <para>rdfs:comment : Represents devices of a building automation control system that are used to impart control over elements of a distribution system. (Definition adapated from http://www.buildingsmart-tech.org/ifc/IFC4/Add1/html/schema/ifcsharedbldgserviceelements/lexical/ifcdistributioncontrolelement.htm)</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/DistributionControlDevice">s4bldg:DistributionControlDevice</a>
    /// </summary>
    let DistributionControlDevice = _prefixId.prefix "DistributionControlDevice"
    /// <summary>
    ///   <para>rdfs:label : Distribution device</para>
    ///   <para>rdfs:comment : Generalization of all devices that participate in a distribution system. (Definition adapated from http://www.buildingsmart-tech.org/ifc/IFC4/Add1/html/schema/ifcproductextension/lexical/ifcdistributionelement.htm)</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/DistributionDevice">s4bldg:DistributionDevice</a>
    /// </summary>
    let DistributionDevice = _prefixId.prefix "DistributionDevice"
    /// <summary>
    ///   <para>rdfs:label : DistributionFlowDevice</para>
    ///   <para>rdfs:comment : Represents devices of a distribution system that facilitate the distribution of energy or matter, such as air, water or power. (Definition adapated from http://www.buildingsmart-tech.org/ifc/IFC4/Add1/html/schema/ifcsharedbldgserviceelements/lexical/ifcdistributionflowelement.htm)</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/DistributionFlowDevice">s4bldg:DistributionFlowDevice</a>
    /// </summary>
    let DistributionFlowDevice = _prefixId.prefix "DistributionFlowDevice"
    /// <summary>
    ///   <para>rdfs:label : Duct silencer</para>
    ///   <para>rdfs:comment : A duct silencer is a device that is typically installed inside a duct distribution system for the purpose of reducing the noise levels from air movement, fan noise, etc. in the adjacent space or downstream of the duct silencer device.</para>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcDuctSilencer^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/DuctSilencer">s4bldg:DuctSilencer</a>
    /// </summary>
    let DuctSilencer = _prefixId.prefix "DuctSilencer"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcElectricAppliance^^xsd:string</para>
    ///   <para>rdfs:label : Electric appliance</para>
    ///   <para>rdfs:comment : An electric appliance is a device intended for consumer usage that is powered by electricity.
    ///
    /// Electric appliances may be fixed in place or may be able to be moved from one space to another. Electric appliances require an electrical supply that may be supplied either by an electrical circuit or provided from a local battery source.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/ElectricAppliance">s4bldg:ElectricAppliance</a>
    /// </summary>
    let ElectricAppliance = _prefixId.prefix "ElectricAppliance"
    /// <summary>
    ///   <para>rdfs:label : Electric flow storage device</para>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcElectricFlowStorageDevice^^xsd:string</para>
    ///   <para>rdfs:comment : An electric flow storage device is a device in which electrical energy is stored and from which energy may be progressively released.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/ElectricFlowStorageDevice">s4bldg:ElectricFlowStorageDevice</a>
    /// </summary>
    let ElectricFlowStorageDevice = _prefixId.prefix "ElectricFlowStorageDevice"
    /// <summary>
    ///   <para>rdfs:label : Electric generator</para>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcElectricGenerator^^xsd:string</para>
    ///   <para>rdfs:comment : An electric generator is an engine that is a machine for converting mechanical energy into electrical energy.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/ElectricGenerator">s4bldg:ElectricGenerator</a>
    /// </summary>
    let ElectricGenerator = _prefixId.prefix "ElectricGenerator"
    /// <summary>
    ///   <para>rdfs:comment : An electric motor is an engine that is a machine for converting electrical energy into mechanical energy.</para>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcElectricMotor^^xsd:string</para>
    ///   <para>rdfs:label : Electric motor</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/ElectricMotor">s4bldg:ElectricMotor</a>
    /// </summary>
    let ElectricMotor = _prefixId.prefix "ElectricMotor"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcElectricTimeControl^^xsd:string</para>
    ///   <para>rdfs:label : Electric time control</para>
    ///   <para>rdfs:comment : An electric time control is a device that applies control to the provision or flow of electrical energy over time.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/ElectricTimeControl">s4bldg:ElectricTimeControl</a>
    /// </summary>
    let ElectricTimeControl = _prefixId.prefix "ElectricTimeControl"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcEnergyConversionDevice^^xsd:string</para>
    ///   <para>rdfs:label : Energy conversion device</para>
    ///   <para>rdfs:comment : The distribution flow element EnergyConversionDevice defines the occurrence of a device used to perform energy conversion or heat transfer and typically participates in a flow distribution system.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/EnergyConversionDevice">s4bldg:EnergyConversionDevice</a>
    /// </summary>
    let EnergyConversionDevice = _prefixId.prefix "EnergyConversionDevice"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcEngine^^xsd:string</para>
    ///   <para>rdfs:label : Engine</para>
    ///   <para>rdfs:comment : An engine is a device that converts fuel into mechanical energy through combustion.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/Engine">s4bldg:Engine</a>
    /// </summary>
    let Engine = _prefixId.prefix "Engine"
    /// <summary>
    ///   <para>rdfs:label : Evaporative cooler</para>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcEvaporativeCooler^^xsd:string</para>
    ///   <para>rdfs:comment : An evaporative cooler is a device that cools air by saturating it with water vapor.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/EvaporativeCooler">s4bldg:EvaporativeCooler</a>
    /// </summary>
    let EvaporativeCooler = _prefixId.prefix "EvaporativeCooler"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcEvaporator^^xsd:string</para>
    ///   <para>rdfs:label : Evaporator</para>
    ///   <para>rdfs:comment : An evaporator is a device in which a liquid refrigerent is vaporized and absorbs heat from the surrounding fluid.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/Evaporator">s4bldg:Evaporator</a>
    /// </summary>
    let Evaporator = _prefixId.prefix "Evaporator"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcFan^^xsd:string</para>
    ///   <para>rdfs:label : Fan</para>
    ///   <para>rdfs:comment : A fan is a device which imparts mechanical work on a gas. A typical usage of a fan is to induce airflow in a building services air distribution system.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/Fan">s4bldg:Fan</a>
    /// </summary>
    let Fan = _prefixId.prefix "Fan"
    /// <summary>
    ///   <para>rdfs:label : Filter</para>
    ///   <para>rdfs:comment : A filter is an apparatus used to remove particulate or gaseous matter from fluids and gases.</para>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcFilter^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/Filter">s4bldg:Filter</a>
    /// </summary>
    let Filter = _prefixId.prefix "Filter"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcFireSuppressionTerminal^^xsd:string</para>
    ///   <para>rdfs:label : Fire suppression terminal</para>
    ///   <para>rdfs:comment : A fire suppression terminal has the purpose of delivering a fluid (gas or liquid) that will suppress a fire.
    ///
    /// A fire suppression terminal provides for all forms of sprinkler, spreader and other form of terminal that is connected to a pipework system and intended to act in the role of suppressing a fire.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/FireSuppressionTerminal">s4bldg:FireSuppressionTerminal</a>
    /// </summary>
    let FireSuppressionTerminal = _prefixId.prefix "FireSuppressionTerminal"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcFlowController^^xsd:string</para>
    ///   <para>rdfs:label : Flow controller</para>
    ///   <para>rdfs:comment : The distribution flow element FlowController defines the occurrence of elements of a distribution system that are used to regulate flow through a distribution system. Examples include dampers, valves, switches, and relays.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/FlowController">s4bldg:FlowController</a>
    /// </summary>
    let FlowController = _prefixId.prefix "FlowController"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcFlowInstrument^^xsd:string</para>
    ///   <para>rdfs:label : Flow instrument</para>
    ///   <para>rdfs:comment : A flow instrument reads and displays the value of a particular property of a system at a point, or displays the difference in the value of a property between two points.
    ///
    /// Instrumentation is typically for the purpose of determining the value of the property at a point in time. It is not the purpose of an instrument to record or integrate the values over time (although they may be connected to recording devices that do perform such a function). This entity provides for all forms of mechanical flow instrument (thermometers, pressure gauges etc.) and electrical flow instruments (ammeters, voltmeters etc.)</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/FlowInstrument">s4bldg:FlowInstrument</a>
    /// </summary>
    let FlowInstrument = _prefixId.prefix "FlowInstrument"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcFlowMeter^^xsd:string</para>
    ///   <para>rdfs:label : Flow meter</para>
    ///   <para>rdfs:comment : A flow meter is a device that is used to measure the flow rate in a system.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/FlowMeter">s4bldg:FlowMeter</a>
    /// </summary>
    let FlowMeter = _prefixId.prefix "FlowMeter"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcFlowMovingDevice^^xsd:string</para>
    ///   <para>rdfs:label : Flow moving device</para>
    ///   <para>rdfs:comment : The distribution flow element FlowMovingDevice defines the occurrence of an apparatus used to distribute, circulate or perform conveyance of fluids, including liquids and gases (such as a pump or fan), and typically participates in a flow distribution system.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/FlowMovingDevice">s4bldg:FlowMovingDevice</a>
    /// </summary>
    let FlowMovingDevice = _prefixId.prefix "FlowMovingDevice"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcFlowStorageDevice^^xsd:string</para>
    ///   <para>rdfs:label : Flow storage device</para>
    ///   <para>rdfs:comment : The distribution flow element FlowStorageDevice defines the occurrence of a device that participates in a distribution system and is used for temporary storage (such as a tank).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/FlowStorageDevice">s4bldg:FlowStorageDevice</a>
    /// </summary>
    let FlowStorageDevice = _prefixId.prefix "FlowStorageDevice"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcFlowTerminal^^xsd:string</para>
    ///   <para>rdfs:label : Flow terminal</para>
    ///   <para>rdfs:comment : The distribution flow element FlowTerminal defines the occurrence of a permanently attached element that acts as a terminus or beginning of a distribution system (such as an air outlet, drain, water closet, or sink). A terminal is typically a point at which a system interfaces with an external environment.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/FlowTerminal">s4bldg:FlowTerminal</a>
    /// </summary>
    let FlowTerminal = _prefixId.prefix "FlowTerminal"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcFlowTreatmentDevice^^xsd:string</para>
    ///   <para>rdfs:label : Flow treatment device</para>
    ///   <para>rdfs:comment : The distribution flow element FlowTreatmentDevice defines the occurrence of a device typically used to remove unwanted matter from a fluid, either liquid or gas, and typically participates in a flow distribution system.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/FlowTreatmentDevice">s4bldg:FlowTreatmentDevice</a>
    /// </summary>
    let FlowTreatmentDevice = _prefixId.prefix "FlowTreatmentDevice"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcHeatExchanger^^xsd:string</para>
    ///   <para>rdfs:label : Heat exchanger</para>
    ///   <para>rdfs:comment : A heat exchanger is a device used to provide heat transfer between non-mixing media such as plate and shell and tube heat exchangers. HeatExchanger is commonly used on water-side distribution systems to recover energy from a liquid to another liquid (typically water-based), whereas AirToAirHeatRecovery is commonly used on air-side distribution systems to recover energy from a gas to a gas (usually air).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/HeatExchanger">s4bldg:HeatExchanger</a>
    /// </summary>
    let HeatExchanger = _prefixId.prefix "HeatExchanger"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcHumidifier^^xsd:string</para>
    ///   <para>rdfs:comment : A humidifier is a device that adds moisture into the air.</para>
    ///   <para>rdfs:label : Humidifier</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/Humidifier">s4bldg:Humidifier</a>
    /// </summary>
    let Humidifier = _prefixId.prefix "Humidifier"
    /// <summary>
    ///   <para>rdfs:comment : An interceptor is a device designed and installed in order to separate and retain deleterious, hazardous or undesirable matter while permitting normal sewage or liquids to discharge into a collection system by gravity.</para>
    ///   <para>rdfs:label : Interceptor</para>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcInterceptor^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/Interceptor">s4bldg:Interceptor</a>
    /// </summary>
    let Interceptor = _prefixId.prefix "Interceptor"
    /// <summary>
    ///   <para>rdfs:comment : A lamp is an artificial light source such as a light bulb or tube.</para>
    ///   <para>rdfs:label : Lamp</para>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcLamp^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/Lamp">s4bldg:Lamp</a>
    /// </summary>
    let Lamp = _prefixId.prefix "Lamp"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcMedicalDevice^^xsd:string</para>
    ///   <para>rdfs:label : Medical device</para>
    ///   <para>rdfs:comment : A medical device is attached to a medical piping system and operates upon medical gases to perform a specific function. Medical gases include medical air, medical vacuum, oxygen, carbon dioxide, nitrogen, and nitrous oxide.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/MedicalDevice">s4bldg:MedicalDevice</a>
    /// </summary>
    let MedicalDevice = _prefixId.prefix "MedicalDevice"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcOutlet^^xsd:string</para>
    ///   <para>rdfs:label : Outlet</para>
    ///   <para>rdfs:comment : An outlet is a device installed at a point to receive one or more inserted plugs for electrical power or communications.
    ///
    /// Power outlets are commonly connected within a junction box; data outlets may be directly connected to a wall. For power outlets sharing the same circuit within a junction box, the ports should indicate the logical wiring relationship to the enclosing junction box, even though they may be physically connected to a cable going to another outlet, switch, or fixture.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/Outlet">s4bldg:Outlet</a>
    /// </summary>
    let Outlet = _prefixId.prefix "Outlet"
    /// <summary>
    ///   <para>rdfs:label : Physical object</para>
    ///   <para>rdfs:comment : Any Object that has a proper space region.  (Definition extracted from DUL ontology)</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/PhysicalObject">s4bldg:PhysicalObject</a>
    /// </summary>
    let PhysicalObject = _prefixId.prefix "PhysicalObject"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcProtectiveDevice^^xsd:string</para>
    ///   <para>rdfs:label : Protective device</para>
    ///   <para>rdfs:comment : A protective device breaks an electrical circuit when a stated electric current that passes through it is exceeded.
    ///
    /// A protective device provides protection against electrical current only (not as a general protective device). It may be used to represent the complete set of elements including both the tripping unit and the breaking unit that provide the protection. This may be particularly useful at earlier stages of design where the approach to breaking the electrical supply may be determined but the method of tripping may not. Alternatively, this entity may be used to specifically represent the breaking unit alone (in which case the tripping unit will also be specifically identified). This entity is specific to dedicated protective devices and excludes electrical outlets that may have circuit protection.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/ProtectiveDevice">s4bldg:ProtectiveDevice</a>
    /// </summary>
    let ProtectiveDevice = _prefixId.prefix "ProtectiveDevice"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcProtectiveDeviceTrippingUnit^^xsd:string</para>
    ///   <para>rdfs:label : Protective device tripping unit</para>
    ///   <para>rdfs:comment : A protective device tripping unit breaks an electrical circuit at a separate breaking unit when a stated electric current that passes through the unit is exceeded.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/ProtectiveDeviceTrippingUnit">s4bldg:ProtectiveDeviceTrippingUnit</a>
    /// </summary>
    let ProtectiveDeviceTrippingUnit = _prefixId.prefix "ProtectiveDeviceTrippingUnit"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcPump^^xsd:string</para>
    ///   <para>rdfs:comment : A pump is a device which imparts mechanical work on fluids or slurries to move them through a channel or pipeline. A typical use of a pump is to circulate chilled water or heating hot water in a building services distribution system.</para>
    ///   <para>rdfs:label : Pump</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/Pump">s4bldg:Pump</a>
    /// </summary>
    let Pump = _prefixId.prefix "Pump"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcSanitaryTerminal^^xsd:string</para>
    ///   <para>rdfs:label : Sanitary terminal</para>
    ///   <para>rdfs:comment : A sanitary terminal is a fixed appliance or terminal usually supplied with water and used for drinking, cleaning or foul water disposal or that is an item of equipment directly used with such an appliance or terminal.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/SanitaryTerminal">s4bldg:SanitaryTerminal</a>
    /// </summary>
    let SanitaryTerminal = _prefixId.prefix "SanitaryTerminal"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcSensor^^xsd:string</para>
    ///   <para>rdfs:label : Sensor</para>
    ///   <para>rdfs:comment : A sensor is a device that measures a physical quantity and converts it into a signal which can be read by an observer or by an instrument.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/Sensor">s4bldg:Sensor</a>
    /// </summary>
    let Sensor = _prefixId.prefix "Sensor"
    /// <summary>
    ///   <para>rdfs:label : Shading device</para>
    ///   <para>rdfs:comment : Shading devices are purpose built devices to protect from the sunlight, from natural light, or screening them from view. Shading devices can form part of the facade or can be mounted inside the building, they can be fixed or operable.</para>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcShadingDevice^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/ShadingDevice">s4bldg:ShadingDevice</a>
    /// </summary>
    let ShadingDevice = _prefixId.prefix "ShadingDevice"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcSolarDevice^^xsd:string</para>
    ///   <para>rdfs:label : Solar device</para>
    ///   <para>rdfs:comment : A solar device converts solar radiation into other energy such as electric current or thermal energy.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/SolarDevice">s4bldg:SolarDevice</a>
    /// </summary>
    let SolarDevice = _prefixId.prefix "SolarDevice"
    /// <summary>
    ///   <para>rdfs:label : Space heater</para>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcSpaceHeater^^xsd:string</para>
    ///   <para>rdfs:comment : Space heaters utilize a combination of radiation and/or natural convection using a heating source such as electricity, steam or hot water to heat a limited space or area. Examples of space heaters include radiators, convectors, baseboard and finned-tube heaters.
    ///
    /// UnitaryEquipment should be used for packaged units supporting a combination of heating, cooling, and/or dehumidification; Coil should be used for coil-based floor heating.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/SpaceHeater">s4bldg:SpaceHeater</a>
    /// </summary>
    let SpaceHeater = _prefixId.prefix "SpaceHeater"
    /// <summary>
    ///   <para>rdfs:label : Switching device</para>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcSwitchingDevice^^xsd:string</para>
    ///   <para>rdfs:comment : A switch is used in a cable distribution system (electrical circuit) to control or modulate the flow of electricity.
    ///
    /// Switches include those used for electrical power, communications, audio-visual, or other distribution system types as determined by the available ports.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/SwitchingDevice">s4bldg:SwitchingDevice</a>
    /// </summary>
    let SwitchingDevice = _prefixId.prefix "SwitchingDevice"
    /// <summary>
    ///   <para>rdfs:label : Tank</para>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcTank^^xsd:string</para>
    ///   <para>rdfs:comment : A tank is a vessel or container in which a fluid or gas is stored for later use.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/Tank">s4bldg:Tank</a>
    /// </summary>
    let Tank = _prefixId.prefix "Tank"
    /// <summary>
    ///   <para>rdfs:label : Transformer</para>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcTransformer^^xsd:string</para>
    ///   <para>rdfs:comment : A transformer is an inductive stationary device that transfers electrical energy from one circuit to another.
    ///
    /// Transformer is used to transform electric power; conversion of electric signals for other purposes is handled at other entities: Controller converts arbitrary signals, AudioVisualAppliance converts signals for audio or video streams, and CommunicationsAppliance converts signals for data or other communications usage.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/Transformer">s4bldg:Transformer</a>
    /// </summary>
    let Transformer = _prefixId.prefix "Transformer"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcTransportElement^^xsd:string</para>
    ///   <para>rdfs:label : Transport element</para>
    ///   <para>rdfs:comment : A transport element is a generalization of all transport related objects that move people, animals or goods within a building or building complex. The TransportElement defines the occurrence of a transport element. </para>
    ///   <a href="https://saref.etsi.org/saref4bldg/TransportElement">s4bldg:TransportElement</a>
    /// </summary>
    let TransportElement = _prefixId.prefix "TransportElement"
    /// <summary>
    ///   <para>rdfs:comment : A tube bundle is a device consisting of tubes and bundles of tubes used for heat transfer and contained typically within other energy conversion devices, such as a chiller or coil.</para>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcTubeBundle^^xsd:string</para>
    ///   <para>rdfs:label : Tube bundle</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/TubeBundle">s4bldg:TubeBundle</a>
    /// </summary>
    let TubeBundle = _prefixId.prefix "TubeBundle"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcUnitaryControlElement^^xsd:string</para>
    ///   <para>rdfs:label : Unitary control element</para>
    ///   <para>rdfs:comment : A unitary control element combines a number of control components into a single product, such as a thermostat or humidistat.
    ///
    /// A unitary control element provides a housing for an aggregation of control or electrical distribution elements that, in combination, perform a singular (unitary) purpose. Each item in the aggregation may have its own geometric representation and location.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/UnitaryControlElement">s4bldg:UnitaryControlElement</a>
    /// </summary>
    let UnitaryControlElement = _prefixId.prefix "UnitaryControlElement"
    /// <summary>
    ///   <para>rdfs:comment : A valve is used in a building services piping distribution system to control or modulate the flow of the fluid.</para>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcValve^^xsd:string</para>
    ///   <para>rdfs:label : Valve</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/Valve">s4bldg:Valve</a>
    /// </summary>
    let Valve = _prefixId.prefix "Valve"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://w3id.org/ifc/IFC4_ADD1#IfcVibrationIsolator^^xsd:string</para>
    ///   <para>rdfs:label : Vibration isolator</para>
    ///   <para>rdfs:comment : A vibration isolator is a device used to minimize the effects of vibration transmissibility in a building.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/VibrationIsolator">s4bldg:VibrationIsolator</a>
    /// </summary>
    let VibrationIsolator = _prefixId.prefix "VibrationIsolator"
    /// <summary>
    ///   <para>rdfs:label : access type</para>
    ///   <para>rdfs:comment : Defines the types of access (or cover) to a tank that may be specified. Note that covers are generally specified for rectangular tanks. For cylindrical tanks, access will normally be via a manhole.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/accessType">s4bldg:accessType</a>
    /// </summary>
    let accessType = _prefixId.prefix "accessType"
    /// <summary>
    ///   <para>rdfs:label : air flow rate range max</para>
    ///   <para>rdfs:comment : Maximum allowable air flow rate. Usually measured in m3/s.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/airFlowRateMax">s4bldg:airFlowRateMax</a>
    /// </summary>
    let airFlowRateMax = _prefixId.prefix "airFlowRateMax"
    /// <summary>
    ///   <para>rdfs:label : air flow rate range min</para>
    ///   <para>rdfs:comment : Minimum allowable air flow rate. Usually measured in m3/s.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/airFlowRateMin">s4bldg:airFlowRateMin</a>
    /// </summary>
    let airFlowRateMin = _prefixId.prefix "airFlowRateMin"

    /// <summary>
    ///   <para>rdfs:label : ambient design dry bulb temperature</para>
    ///   <para>rdfs:comment : Ambient design dry bulb temperature used for selecting the cooling tower. Usually measured in degrees Kelvin (K).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/ambientDesignDryBulbTemperature">s4bldg:ambientDesignDryBulbTemperature</a>
    /// </summary>
    let ambientDesignDryBulbTemperature = _prefixId.prefix "ambientDesignDryBulbTemperature"

    /// <summary>
    ///   <para>rdfs:label : ambient design wet bulb temperature</para>
    ///   <para>rdfs:comment : Ambient design wet bulb temperature used for selecting the cooling tower. Usually measured in degrees Kelvin (K).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/ambientDesignWetBulbTemperature">s4bldg:ambientDesignWetBulbTemperature</a>
    /// </summary>
    let ambientDesignWetBulbTemperature = _prefixId.prefix "ambientDesignWetBulbTemperature"

    /// <summary>
    ///   <para>rdfs:label : maximum apparent power</para>
    ///   <para>rdfs:comment : Maximum apparent power/capacity in VA (volt ampere). Usually measured in Watts (W, J/s).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/apparentPowerMax">s4bldg:apparentPowerMax</a>
    /// </summary>
    let apparentPowerMax = _prefixId.prefix "apparentPowerMax"
    /// <summary>
    ///   <para>rdfs:label : application</para>
    ///   <para>rdfs:comment : Humidifier application. Fixed: Humidifier installed in a ducted flow distribution system. Portable: Humidifier is not installed in a ducted flow distribution system.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/application">s4bldg:application</a>
    /// </summary>
    let application = _prefixId.prefix "application"
    /// <summary>
    ///   <para>rdfs:label : arrangement</para>
    ///   <para>rdfs:comment : Defines the basic flow arrangements for the heat exchanger: COUNTERFLOW: Counterflow heat exchanger arrangement. CROSSFLOW: Crossflow heat exchanger arrangement. PARALLELFLOW: Parallel flow heat exchanger arrangement. MULTIPASS: Multipass flow heat exchanger arrangement. OTHER: Other type of heat exchanger flow arrangement not defined above.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/arrangement">s4bldg:arrangement</a>
    /// </summary>
    let arrangement = _prefixId.prefix "arrangement"
    /// <summary>
    ///   <para>rdfs:label : audio volume</para>
    ///   <para>rdfs:comment : Indicates discrete audio volume levels and corresponding sound power offsets, if applicable. Missing values may be interpolated. Measured in watts.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/audioVolume">s4bldg:audioVolume</a>
    /// </summary>
    let audioVolume = _prefixId.prefix "audioVolume"
    /// <summary>
    ///   <para>rdfs:label : basin reserve volume</para>
    ///   <para>rdfs:comment : Volume between operating and overflow levels in cooling tower basin. Usually measured in cubic metre (m3).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/basinReserveVolume">s4bldg:basinReserveVolume</a>
    /// </summary>
    let basinReserveVolume = _prefixId.prefix "basinReserveVolume"
    /// <summary>
    ///   <para>rdfs:label : blade action</para>
    ///   <para>rdfs:comment : Blade action.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/bladeAction">s4bldg:bladeAction</a>
    /// </summary>
    let bladeAction = _prefixId.prefix "bladeAction"
    /// <summary>
    ///   <para>rdfs:label : blade edge</para>
    ///   <para>rdfs:comment : Blade edge.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/bladeEdge">s4bldg:bladeEdge</a>
    /// </summary>
    let bladeEdge = _prefixId.prefix "bladeEdge"
    /// <summary>
    ///   <para>rdfs:label : blade shape</para>
    ///   <para>rdfs:comment : Blade shape. Flat means triple V-groove.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/bladeShape">s4bldg:bladeShape</a>
    /// </summary>
    let bladeShape = _prefixId.prefix "bladeShape"
    /// <summary>
    ///   <para>rdfs:label : blade thickness</para>
    ///   <para>rdfs:comment : The thickness of the damper blade. Usually measured in millimeters (mm).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/bladeThickness">s4bldg:bladeThickness</a>
    /// </summary>
    let bladeThickness = _prefixId.prefix "bladeThickness"
    /// <summary>
    ///   <para>rdfs:label : body mass</para>
    ///   <para>rdfs:comment : Overall body mass of the heater. Usually measured in kilograms (kg) or grams (g).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/bodyMass">s4bldg:bodyMass</a>
    /// </summary>
    let bodyMass = _prefixId.prefix "bodyMass"
    /// <summary>
    ///   <para>rdfs:label : capacity control</para>
    ///   <para>rdfs:comment : FanCycling: Fan is cycled on and off to control duty. TwoSpeedFan: Fan is switched between low and high speed to control duty. VariableSpeedFan: Fan speed is varied to control duty. DampersControl: Dampers modulate the air flow to control duty. BypassValveControl: Bypass valve modulates the water flow to control duty. MultipleSeriesPumps: Turn on/off multiple series pump to control duty. TwoSpeedPump: Switch between high/low pump speed to control duty. VariableSpeedPump: vary pump speed to control duty.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/capacityControl">s4bldg:capacityControl</a>
    /// </summary>
    let capacityControl = _prefixId.prefix "capacityControl"
    /// <summary>
    ///   <para>rdfs:label : capacity control type</para>
    ///   <para>rdfs:comment : InletVane: Control by adjusting inlet vane. VariableSpeedDrive: Control by variable speed drive. BladePitchAngle: Control by adjusting blade pitch angle. TwoSpeed: Control by switch between high and low speed. DischargeDamper: Control by modulating discharge damper.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/capacityControlType">s4bldg:capacityControlType</a>
    /// </summary>
    let capacityControlType = _prefixId.prefix "capacityControlType"
    /// <summary>
    ///   <para>rdfs:label : capacity people</para>
    ///   <para>rdfs:comment : Capacity of the transportation element measured in numbers of person.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/capacityPeople">s4bldg:capacityPeople</a>
    /// </summary>
    let capacityPeople = _prefixId.prefix "capacityPeople"
    /// <summary>
    ///   <para>rdfs:label : capacity weight</para>
    ///   <para>rdfs:comment : Capacity of the transport element measured by weight. Usually measured in kilograms (kg) or grams (g).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/capacityWeight">s4bldg:capacityWeight</a>
    /// </summary>
    let capacityWeight = _prefixId.prefix "capacityWeight"
    /// <summary>
    ///   <para>rdfs:label : circuit type</para>
    ///   <para>rdfs:comment : OpenCircuit: Exposes water directly to the cooling atmosphere. CloseCircuit: The fluid is separated from the atmosphere by a heat exchanger. Wet: The air stream or the heat exchange surface is evaporatively cooled. Dry: No evaporation into the air stream. DryWet: A combination of a dry tower and a wet tower.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/circuitType">s4bldg:circuitType</a>
    /// </summary>
    let circuitType = _prefixId.prefix "circuitType"
    /// <summary>
    ///   <para>rdfs:label : close off rating</para>
    ///   <para>rdfs:comment : Close off rating. Usually measured in Pascals (Pa, N/m2).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/closeOffRating">s4bldg:closeOffRating</a>
    /// </summary>
    let closeOffRating = _prefixId.prefix "closeOffRating"
    /// <summary>
    ///   <para>rdfs:label : coil length</para>
    ///   <para>rdfs:comment : Length of coil. Usually measured in millimeters (mm).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/coilLength">s4bldg:coilLength</a>
    /// </summary>
    let coilLength = _prefixId.prefix "coilLength"
    /// <summary>
    ///   <para>rdfs:label : coil width</para>
    ///   <para>rdfs:comment : Width of coil. Usually measured in millimeters (mm</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/coilWidth">s4bldg:coilWidth</a>
    /// </summary>
    let coilWidth = _prefixId.prefix "coilWidth"
    /// <summary>
    ///   <para>rdfs:label : color appearance</para>
    ///   <para>rdfs:comment : In both the DIN and CIE standards, artificial light sources are classified in terms of their color appearance. To the human eye they all appear to be white the difference can only be detected by direct comparison. Visual performance is not directly affected by differences in color appearance.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/colorAppearance">s4bldg:colorAppearance</a>
    /// </summary>
    let colorAppearance = _prefixId.prefix "colorAppearance"
    /// <summary>
    ///   <para>rdfs:label : color rendering index</para>
    ///   <para>rdfs:comment : The CRI indicates how well a light source renders eight standard colors compared to perfect reference lamp with the same color temperature. The CRI scale ranges from 1 to 100, with 100 representing perfect rendering properties.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/colorRenderingIndex">s4bldg:colorRenderingIndex</a>
    /// </summary>
    let colorRenderingIndex = _prefixId.prefix "colorRenderingIndex"
    /// <summary>
    ///   <para>rdfs:label : color temperature</para>
    ///   <para>rdfs:comment : The color temperature of any source of radiation is defined as the temperature (in Kelvin) of a black-body or Planckian radiator whose radiation has the same chromaticity as the source of radiation. Often the values are only approximate color temperatures as the black-body radiator cannot emit radiation of every chromaticity value. The color temperatures of the commonest artificial light sources range from less than 3000K (warm white) to 4000K (intermediate) and over 5000K (daylight). Usually measured in degrees Kelvin (K).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/colorTemperature">s4bldg:colorTemperature</a>
    /// </summary>
    let colorTemperature = _prefixId.prefix "colorTemperature"
    /// <summary>
    ///   <para>rdfs:label : compressor speed</para>
    ///   <para>rdfs:comment : Compressor speed. Usually measured in cycles/s.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/compressorSpeed">s4bldg:compressorSpeed</a>
    /// </summary>
    let compressorSpeed = _prefixId.prefix "compressorSpeed"
    /// <summary>
    ///   <para>rdfs:label : connection size</para>
    ///   <para>rdfs:comment : The connection size of the to and from the pump. Usually measured in millimeters (mm).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/connectionSize">s4bldg:connectionSize</a>
    /// </summary>
    let connectionSize = _prefixId.prefix "connectionSize"
    /// <summary>
    ///   <para>rdfs:label : contains</para>
    ///   <para>rdfs:comment : A relation between a physical space and the objects located in such space.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/contains">s4bldg:contains</a>
    /// </summary>
    let contains = _prefixId.prefix "contains"
    /// <summary>
    ///   <para>rdfs:label : contributed luminous flux</para>
    ///   <para>rdfs:comment : Luminous flux is a photometric measure of radiant flux, i.e. the volume of light emitted from a light source. Luminous flux is measured either for the interior as a whole or for a part of the interior (partial luminous flux for a solid angle). All other photometric parameters are derivatives of luminous flux. Luminous flux is measured in lumens (lm). The luminous flux is given as a nominal value for each lamp. Usually measured in Lumen (lm, Candela Steradian).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/contributedLuminousFlux">s4bldg:contributedLuminousFlux</a>
    /// </summary>
    let contributedLuminousFlux = _prefixId.prefix "contributedLuminousFlux"
    /// <summary>
    ///   <para>rdfs:label : control strategy</para>
    ///   <para>rdfs:comment : FixedExitingWaterTemp: The capacity is controlled to maintain a fixed exiting water temperature. WetBulbTempReset: The set-point is reset based on the wet-bulb temperature.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/controlStrategy">s4bldg:controlStrategy</a>
    /// </summary>
    let controlStrategy = _prefixId.prefix "controlStrategy"
    /// <summary>
    ///   <para>rdfs:label : cover length</para>
    ///   <para>rdfs:comment : The length measured along the x-axis in the local coordinate system or the radius (in the case of a circular shape in plan) of the cover of the oil interceptor. Usually measured in millimeters (mm).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/coverLength">s4bldg:coverLength</a>
    /// </summary>
    let coverLength = _prefixId.prefix "coverLength"
    /// <summary>
    ///   <para>rdfs:label : cover width</para>
    ///   <para>rdfs:comment : The length measured along the x-axis in the local coordinate system of the cover of the oil interceptor. Usually measured in millimeters (mm).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/coverWidth">s4bldg:coverWidth</a>
    /// </summary>
    let coverWidth = _prefixId.prefix "coverWidth"
    /// <summary>
    ///   <para>rdfs:label : effective capacity</para>
    ///   <para>rdfs:comment : The total effective or actual volumetric capacity of the tank. Usually measured in cubic metre (m3).B3</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/effectiveCapacity">s4bldg:effectiveCapacity</a>
    /// </summary>
    let effectiveCapacity = _prefixId.prefix "effectiveCapacity"
    /// <summary>
    ///   <para>rdfs:label : electric generator efficiency</para>
    ///   <para>rdfs:comment : The ratio of output capacity to intake capacity.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/electricGeneratorEfficiency">s4bldg:electricGeneratorEfficiency</a>
    /// </summary>
    let electricGeneratorEfficiency = _prefixId.prefix "electricGeneratorEfficiency"
    /// <summary>
    ///   <para>rdfs:label : electric motor efficiency</para>
    ///   <para>rdfs:comment : The ratio of output capacity to intake capacity.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/electricMotorEfficiency">s4bldg:electricMotorEfficiency</a>
    /// </summary>
    let electricMotorEfficiency = _prefixId.prefix "electricMotorEfficiency"
    /// <summary>
    ///   <para>rdfs:label : end shape type</para>
    ///   <para>rdfs:comment : Defines the types of end shapes that can be used for preformed tanks. The convention for reading these enumerated values is that for a vertical cylinder, the first value is the base and the second is the top for a horizontal cylinder, the order of reading should be left to right. For a speherical tank, the value UNSET should be used.B5</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/endShapeType">s4bldg:endShapeType</a>
    /// </summary>
    let endShapeType = _prefixId.prefix "endShapeType"
    /// <summary>
    ///   <para>rdfs:label : energy source</para>
    ///   <para>rdfs:comment : The source of energy.rdfs:comment : Enumeration defining the energy source or fuel cumbusted to generate heat.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/energySource">s4bldg:energySource</a>
    /// </summary>
    let energySource = _prefixId.prefix "energySource"
    /// <summary>
    ///   <para>rdfs:label : evaporation coolant</para>
    ///   <para>rdfs:comment : The fluid used for the coolant in the evaporator.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/evaporationCoolant">s4bldg:evaporationCoolant</a>
    /// </summary>
    let evaporationCoolant = _prefixId.prefix "evaporationCoolant"
    /// <summary>
    ///   <para>rdfs:label : evaporation medium type</para>
    ///   <para>rdfs:comment : ColdLiquid: Evaporator is using liquid type of fluid to exchange heat with refrigerant. ColdAir: Evaporator is using air to exchange heat with refrigerant.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/evaporationMediumType">s4bldg:evaporationMediumType</a>
    /// </summary>
    let evaporationMediumType = _prefixId.prefix "evaporationMediumType"
    /// <summary>
    ///   <para>rdfs:label : external surface area</para>
    ///   <para>rdfs:comment : External surface area (both primary and secondary area). Usually measured in square metre (m2).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/externalSurfaceArea">s4bldg:externalSurfaceArea</a>
    /// </summary>
    let externalSurfaceArea = _prefixId.prefix "externalSurfaceArea"
    /// <summary>
    ///   <para>rdfs:label : face area</para>
    ///   <para>rdfs:comment : Face area open to the airstream. Usually measured in square metre (m2).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/faceArea">s4bldg:faceArea</a>
    /// </summary>
    let faceArea = _prefixId.prefix "faceArea"
    /// <summary>
    ///   <para>rdfs:label : fail position</para>
    ///   <para>rdfs:comment : Specifies the required fail-safe position of the actuator.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/failPosition">s4bldg:failPosition</a>
    /// </summary>
    let failPosition = _prefixId.prefix "failPosition"
    /// <summary>
    ///   <para>rdfs:label : final resistance</para>
    ///   <para>rdfs:comment : Filter fluid resistance when replacement is required (i.e., Pressure drop at the maximum air flowrate across the filter when the filter needs replacement per ASHRAE Standard 52.1). Usually measured in Pascals (Pa, N/m2).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/finalResistance">s4bldg:finalResistance</a>
    /// </summary>
    let finalResistance = _prefixId.prefix "finalResistance"
    /// <summary>
    ///   <para>rdfs:label : finish color</para>
    ///   <para>rdfs:comment : Finish color for cooled beam.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/finishColor">s4bldg:finishColor</a>
    /// </summary>
    let finishColor = _prefixId.prefix "finishColor"
    /// <summary>
    ///   <para>rdfs:label : fire exit</para>
    ///   <para>rdfs:comment : Indication whether this object is designed to serve as an exit in the case of fire (TRUE) or not (FALSE). Here whether the transport element (in case of e.g., a lift) is designed to serve as a fire exit, e.g., for fire escape purposes.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/fireExit">s4bldg:fireExit</a>
    /// </summary>
    let fireExit = _prefixId.prefix "fireExit"
    /// <summary>
    ///   <para>rdfs:label : first curvature radius</para>
    ///   <para>rdfs:comment : FirstCurvatureRadius should be defined as the base or left side radius of curvature value. Usually measured in millimeters (mm).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/firstCurvatureRadius">s4bldg:firstCurvatureRadius</a>
    /// </summary>
    let firstCurvatureRadius = _prefixId.prefix "firstCurvatureRadius"
    /// <summary>
    ///   <para>rdfs:label : flow arrangement</para>
    ///   <para>rdfs:comment : CounterFlow: Air and water flow enter in different directions. CrossFlow: Air and water flow are perpendicular. ParallelFlow: air and water flow enter in same directions.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/flowArrangement">s4bldg:flowArrangement</a>
    /// </summary>
    let flowArrangement = _prefixId.prefix "flowArrangement"
    /// <summary>
    ///   <para>rdfs:label : flow coefficient</para>
    ///   <para>rdfs:comment : Flow coefficient (the quantity of fluid that passes through a fully open valve at unit pressure drop), typically expressed as the Kv or Cv value for the valve.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/flowCoefficient">s4bldg:flowCoefficient</a>
    /// </summary>
    let flowCoefficient = _prefixId.prefix "flowCoefficient"
    /// <summary>
    ///   <para>rdfs:label : flow resistance range</para>
    ///   <para>rdfs:comment : Allowable range of frictional resistance against which the fluid is being pumped. Usually measured in Pascals (Pa, N/m2).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/flowResistanceMax">s4bldg:flowResistanceMax</a>
    /// </summary>
    let flowResistanceMax = _prefixId.prefix "flowResistanceMax"
    /// <summary>
    ///   <para>rdfs:label : flow resistance range</para>
    ///   <para>rdfs:comment : Allowable range of frictional resistance against which the fluid is being pumped. Usually measured in Pascals (Pa, N/m2).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/flowResistanceMin">s4bldg:flowResistanceMin</a>
    /// </summary>
    let flowResistanceMin = _prefixId.prefix "flowResistanceMin"
    /// <summary>
    ///   <para>rdfs:label : fluid flow rate range</para>
    ///   <para>rdfs:comment : Possible range of fluid flowrate that can be delivered. Usually measured in m3/s.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/fluidFlowRateMax">s4bldg:fluidFlowRateMax</a>
    /// </summary>
    let fluidFlowRateMax = _prefixId.prefix "fluidFlowRateMax"
    /// <summary>
    ///   <para>rdfs:label : fluid flow rate range</para>
    ///   <para>rdfs:comment : Possible range of fluid flowrate that can be delivered. Usually measured in m3/s.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/fluidFlowRateMin">s4bldg:fluidFlowRateMin</a>
    /// </summary>
    let fluidFlowRateMin = _prefixId.prefix "fluidFlowRateMin"
    /// <summary>
    ///   <para>rdfs:label : fouling factor</para>
    ///   <para>rdfs:comment : Fouling factor of the tubes in the tube bundle. Usually measured in m2 Kelvin/Watt.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/foulingFactor">s4bldg:foulingFactor</a>
    /// </summary>
    let foulingFactor = _prefixId.prefix "foulingFactor"
    /// <summary>
    ///   <para>rdfs:label : frame depth</para>
    ///   <para>rdfs:comment : The length (or depth) of the damper frame. Usually measured in millimeters (mm).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/frameDepth">s4bldg:frameDepth</a>
    /// </summary>
    let frameDepth = _prefixId.prefix "frameDepth"
    /// <summary>
    ///   <para>rdfs:label : frame size</para>
    ///   <para>rdfs:comment : Designation of the frame size according to the named range of frame sizes designated at the place of use or according to a given standard.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/frameSize">s4bldg:frameSize</a>
    /// </summary>
    let frameSize = _prefixId.prefix "frameSize"
    /// <summary>
    ///   <para>rdfs:label : frame thickness</para>
    ///   <para>rdfs:comment : The thickness of the damper frame material. Usually measured in millimeters (mm).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/frameThickness">s4bldg:frameThickness</a>
    /// </summary>
    let frameThickness = _prefixId.prefix "frameThickness"
    /// <summary>
    ///   <para>rdfs:label : frame type</para>
    ///   <para>rdfs:comment : The type of frame used by the damper (e.g., Standard, Single Flange, Single Reversed Flange, Double Flange, etc.).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/frameType">s4bldg:frameType</a>
    /// </summary>
    let frameType = _prefixId.prefix "frameType"
    /// <summary>
    ///   <para>rdfs:label : has defrost</para>
    ///   <para>rdfs:comment : Whether the heat exchanger has defrost function or not.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/hasDefrost">s4bldg:hasDefrost</a>
    /// </summary>
    let hasDefrost = _prefixId.prefix "hasDefrost"
    /// <summary>
    ///   <para>rdfs:label : has exterior insulation</para>
    ///   <para>rdfs:comment : TRUE if the silencer has exterior insulation. FALSE if it does not.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/hasExteriorInsulation">s4bldg:hasExteriorInsulation</a>
    /// </summary>
    let hasExteriorInsulation = _prefixId.prefix "hasExteriorInsulation"
    /// <summary>
    ///   <para>rdfs:label : has hot gas bypass</para>
    ///   <para>rdfs:comment : Whether or not hot gas bypass is provided for the compressor. TRUE = Yes, FALSE = No.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/hasHotGasBypass">s4bldg:hasHotGasBypass</a>
    /// </summary>
    let hasHotGasBypass = _prefixId.prefix "hasHotGasBypass"
    /// <summary>
    ///   <para>rdfs:label : has lock</para>
    ///   <para>rdfs:comment : Indication of whether a switching device has a key operated lock (=TRUE) or not (= FALSE).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/hasLock">s4bldg:hasLock</a>
    /// </summary>
    let hasLock = _prefixId.prefix "hasLock"
    /// <summary>
    ///   <para>rdfs:label : has part winding</para>
    ///   <para>rdfs:comment : Indication of whether the motor is single speed, i.e. has a single winding (= FALSE) or multi-speed i.e.has part winding (= TRUE) .</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/hasPartWinding">s4bldg:hasPartWinding</a>
    /// </summary>
    let hasPartWinding = _prefixId.prefix "hasPartWinding"
    /// <summary>
    ///   <para>rdfs:label : has space</para>
    ///   <para>rdfs:comment : Relation between a building or a building space and the spaces it can be divided into.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/hasSpace">s4bldg:hasSpace</a>
    /// </summary>
    let hasSpace = _prefixId.prefix "hasSpace"
    /// <summary>
    ///   <para>rdfs:label : has turbulator</para>
    ///   <para>rdfs:comment : TRUE if the tube has a turbulator, FALSE if it does not.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/hasTurbulator">s4bldg:hasTurbulator</a>
    /// </summary>
    let hasTurbulator = _prefixId.prefix "hasTurbulator"
    /// <summary>
    ///   <para>rdfs:label : heat exchange area</para>
    ///   <para>rdfs:comment : Heat exchange area. Usually measured in square metre (m2).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/heatExchangeArea">s4bldg:heatExchangeArea</a>
    /// </summary>
    let heatExchangeArea = _prefixId.prefix "heatExchangeArea"
    /// <summary>
    ///   <para>rdfs:label : heat transfer dimension</para>
    ///   <para>rdfs:comment : Indicates how heat is transmitted according to the shape of the space heater.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/heatTransferDimension">s4bldg:heatTransferDimension</a>
    /// </summary>
    let heatTransferDimension = _prefixId.prefix "heatTransferDimension"
    /// <summary>
    ///   <para>rdfs:label : heat transfer medium</para>
    ///   <para>rdfs:comment : Enumeration defining the heat transfer medium if applicable.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/heatTransferMedium">s4bldg:heatTransferMedium</a>
    /// </summary>
    let heatTransferMedium = _prefixId.prefix "heatTransferMedium"
    /// <summary>
    ///   <para>rdfs:label : heat transfer surface area</para>
    ///   <para>rdfs:comment : Total heat transfer area of the vessel. Usually measured in square metre (m2).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/heatTransferSurfaceArea">s4bldg:heatTransferSurfaceArea</a>
    /// </summary>
    let heatTransferSurfaceArea = _prefixId.prefix "heatTransferSurfaceArea"
    /// <summary>
    ///   <para>rdfs:label : heat transfer type enum</para>
    ///   <para>rdfs:comment : Type of heat transfer between the two air streams.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/heatTransferTypeEnum">s4bldg:heatTransferTypeEnum</a>
    /// </summary>
    let heatTransferTypeEnum = _prefixId.prefix "heatTransferTypeEnum"
    /// <summary>
    ///   <para>rdfs:label : height</para>
    ///   <para>rdfs:comment : Height of the vibration isolator before tha application of load. Usually measured in millimeters (mm).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/height">s4bldg:height</a>
    /// </summary>
    let height = _prefixId.prefix "height"
    /// <summary>
    ///   <para>rdfs:label : horizontal spacing</para>
    ///   <para>rdfs:comment : Horizontal spacing between tubes in the tube bundle. Usually measured in millimeters (mm).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/horizontalSpacing">s4bldg:horizontalSpacing</a>
    /// </summary>
    let horizontalSpacing = _prefixId.prefix "horizontalSpacing"
    /// <summary>
    ///   <para>rdfs:label : hydraulic diameter</para>
    ///   <para>rdfs:comment : Hydraulic diameter. Usually measured in millimeters (mm).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/hydraulicDiameter">s4bldg:hydraulicDiameter</a>
    /// </summary>
    let hydraulicDiameter = _prefixId.prefix "hydraulicDiameter"
    /// <summary>
    ///   <para>rdfs:label : ideal capacity</para>
    ///   <para>rdfs:comment : Compressor capacity under ideal conditions. Usually measured in Watts (W, J/s).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/idealCapacity">s4bldg:idealCapacity</a>
    /// </summary>
    let idealCapacity = _prefixId.prefix "idealCapacity"
    /// <summary>
    ///   <para>rdfs:label : ideal shaft power</para>
    ///   <para>rdfs:comment : Compressor shaft power under ideal conditions. Usually measured in Watts (W, J/s).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/idealShaftPower">s4bldg:idealShaftPower</a>
    /// </summary>
    let idealShaftPower = _prefixId.prefix "idealShaftPower"
    /// <summary>
    ///   <para>rdfs:label : imaginary impedance ratio</para>
    ///   <para>rdfs:comment : The ratio between the imaginary part of the zero sequence impedance and the imaginary part of the positive impedance (i.e. imaginary part of the short-circuit voltage) of the transformer. Used for three-phase transformer which includes a N-conductor.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/imaginaryImpedanceRatio">s4bldg:imaginaryImpedanceRatio</a>
    /// </summary>
    let imaginaryImpedanceRatio = _prefixId.prefix "imaginaryImpedanceRatio"
    /// <summary>
    ///   <para>rdfs:label : impeller diameter</para>
    ///   <para>rdfs:comment : Diameter of compressor impeller - used to scale performance of geometrically similar compressors. Usually measured in millimeters (mm).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/impellerDiameter">s4bldg:impellerDiameter</a>
    /// </summary>
    let impellerDiameter = _prefixId.prefix "impellerDiameter"
    /// <summary>
    ///   <para>rdfs:label : in line row spacing</para>
    ///   <para>rdfs:comment : In-line tube row spacing. Usually measured in millimeters (mm).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/inLineRowSpacing">s4bldg:inLineRowSpacing</a>
    /// </summary>
    let inLineRowSpacing = _prefixId.prefix "inLineRowSpacing"
    /// <summary>
    ///   <para>rdfs:label : initial resistance</para>
    ///   <para>rdfs:comment : Initial new filter fluid resistance (i.e., pressure drop at the maximum air flowrate across the filter when the filter is new per ASHRAE Standard 52.1). Usually measured in Pascals (Pa, N/m2).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/initialResistance">s4bldg:initialResistance</a>
    /// </summary>
    let initialResistance = _prefixId.prefix "initialResistance"
    /// <summary>
    ///   <para>rdfs:label : inlet connection size</para>
    ///   <para>rdfs:comment : Size of the inlet connection. Usually measured in millimeters (mm).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/inletConnectionSize">s4bldg:inletConnectionSize</a>
    /// </summary>
    let inletConnectionSize = _prefixId.prefix "inletConnectionSize"
    /// <summary>
    ///   <para>rdfs:label : inside diameter</para>
    ///   <para>rdfs:comment : Actual inner diameter of the tube in the tube bundle. Usually measured in millimeters (mm).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/insideDiameter">s4bldg:insideDiameter</a>
    /// </summary>
    let insideDiameter = _prefixId.prefix "insideDiameter"
    /// <summary>
    ///   <para>rdfs:label : integrated lighting type</para>
    ///   <para>rdfs:comment : Integrated lighting in cooled beam.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/integratedLightingType">s4bldg:integratedLightingType</a>
    /// </summary>
    let integratedLightingType = _prefixId.prefix "integratedLightingType"
    /// <summary>
    ///   <para>rdfs:label : internal control</para>
    ///   <para>rdfs:comment : Internal modulation control.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/internalControl">s4bldg:internalControl</a>
    /// </summary>
    let internalControl = _prefixId.prefix "internalControl"
    /// <summary>
    ///   <para>rdfs:label : internal refrigerant volume</para>
    ///   <para>rdfs:comment : Internal volume of evaporator (refrigerant side). Usually measured in cubic metre (m3).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/internalRefrigerantVolume">s4bldg:internalRefrigerantVolume</a>
    /// </summary>
    let internalRefrigerantVolume = _prefixId.prefix "internalRefrigerantVolume"
    /// <summary>
    ///   <para>rdfs:label : internal surface area</para>
    ///   <para>rdfs:comment : Internal surface area. Usually measured in square metre (m2).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/internalSurfaceArea">s4bldg:internalSurfaceArea</a>
    /// </summary>
    let internalSurfaceArea = _prefixId.prefix "internalSurfaceArea"
    /// <summary>
    ///   <para>rdfs:label : internal water volume</para>
    ///   <para>rdfs:comment : Internal volume of evaporator (water side). Usually measured in cubic metre (m3).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/internalWaterVolume">s4bldg:internalWaterVolume</a>
    /// </summary>
    let internalWaterVolume = _prefixId.prefix "internalWaterVolume"
    /// <summary>
    ///   <para>rdfs:label : is contained in</para>
    ///   <para>rdfs:comment : A relation between an object and the physical space in which it is located.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/isContainedIn">s4bldg:isContainedIn</a>
    /// </summary>
    let isContainedIn = _prefixId.prefix "isContainedIn"
    /// <summary>
    ///   <para>rdfs:label : is external</para>
    ///   <para>rdfs:comment : Indication whether the element is designed for use in the exterior (TRUE) or not (FALSE). If (TRUE) it is an external element and faces the outside of the building.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/isExternal">s4bldg:isExternal</a>
    /// </summary>
    let isExternal = _prefixId.prefix "isExternal"
    /// <summary>
    ///   <para>rdfs:label : is free hanging</para>
    ///   <para>rdfs:comment : Is it free hanging type (not mounted in a false ceiling)?</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/isFreeHanging">s4bldg:isFreeHanging</a>
    /// </summary>
    let isFreeHanging = _prefixId.prefix "isFreeHanging"
    /// <summary>
    ///   <para>rdfs:label : is guarded</para>
    ///   <para>rdfs:comment : Indication of whether the motor enclosure is guarded (= TRUE) or not (= FALSE).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/isGuarded">s4bldg:isGuarded</a>
    /// </summary>
    let isGuarded = _prefixId.prefix "isGuarded"
    /// <summary>
    ///   <para>rdfs:label : is illuminated</para>
    ///   <para>rdfs:comment : An indication of whether there is an illuminated indicator to show that the switch is on (=TRUE) or not (= FALSE).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/isIlluminated">s4bldg:isIlluminated</a>
    /// </summary>
    let isIlluminated = _prefixId.prefix "isIlluminated"

    /// <summary>
    ///   <para>rdfs:label : is neutral primary terminal available</para>
    ///   <para>rdfs:comment : An indication of whether the neutral point of the primary winding is available as a terminal (=TRUE) or not (= FALSE).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/isNeutralPrimaryTerminalAvailable">s4bldg:isNeutralPrimaryTerminalAvailable</a>
    /// </summary>
    let isNeutralPrimaryTerminalAvailable = _prefixId.prefix "isNeutralPrimaryTerminalAvailable"

    /// <summary>
    ///   <para>rdfs:label : is neutral secondary terminal available</para>
    ///   <para>rdfs:comment : An indication of whether the neutral point of the secondary winding is available as a terminal (=TRUE) or not (= FALSE).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/isNeutralSecondaryTerminalAvailable">s4bldg:isNeutralSecondaryTerminalAvailable</a>
    /// </summary>
    let isNeutralSecondaryTerminalAvailable = _prefixId.prefix "isNeutralSecondaryTerminalAvailable"

    /// <summary>
    ///   <para>rdfs:label : is pluggable outlet</para>
    ///   <para>rdfs:comment : Indication of whether the outlet accepts a loose plug connection (= TRUE) or whether it is directly connected (= FALSE) or whether the form of connection has not yet been determined (= UNKNOWN).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/isPluggableOutlet">s4bldg:isPluggableOutlet</a>
    /// </summary>
    let isPluggableOutlet = _prefixId.prefix "isPluggableOutlet"
    /// <summary>
    ///   <para>rdfs:label : isSpaceOf</para>
    ///   <para>rdfs:comment : Relation between a building space and the building or building space it belongs to.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/isSpaceOf">s4bldg:isSpaceOf</a>
    /// </summary>
    let isSpaceOf = _prefixId.prefix "isSpaceOf"
    /// <summary>
    ///   <para>rdfs:label : is water storage heater</para>
    ///   <para>rdfs:comment : This is used to identify if the boiler has storage capacity (TRUE). If FALSE, then there is no storage capacity built into the boiler, such as an instantaneous hot water heater.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/isWaterStorageHeater">s4bldg:isWaterStorageHeater</a>
    /// </summary>
    let isWaterStorageHeater = _prefixId.prefix "isWaterStorageHeater"
    /// <summary>
    ///   <para>rdfs:label : isolator compressibility</para>
    ///   <para>rdfs:comment : The compressibility of the vibration isolator.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/isolatorCompressibility">s4bldg:isolatorCompressibility</a>
    /// </summary>
    let isolatorCompressibility = _prefixId.prefix "isolatorCompressibility"
    /// <summary>
    ///   <para>rdfs:label : isolator static deflection</para>
    ///   <para>rdfs:comment : Static deflection of the vibration isolator. Usually measured in millimeters (mm).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/isolatorStaticDeflection">s4bldg:isolatorStaticDeflection</a>
    /// </summary>
    let isolatorStaticDeflection = _prefixId.prefix "isolatorStaticDeflection"
    /// <summary>
    ///   <para>rdfs:label : lamp ballast type</para>
    ///   <para>rdfs:comment : The type of ballast used to stabilise gas discharge by limiting the current during operation and to deliver the necessary striking voltage for starting. Ballasts are needed to operate Discharge Lamps such as Fluorescent, Compact Fluorescent, High-pressure Mercury, Metal Halide and High-pressure Sodium Lamps. Magnetic ballasts are chokes which limit the current passing through a lamp connected in series on the principle of self-induction. The resultant current and power are decisive for the efficient operation of the lamp. A specially designed ballast is required for every type of lamp to comply with lamp rating in terms of Luminous Flux, Color Appearance and service life. The two types of magnetic ballasts for fluorescent lamps are KVG Conventional (EC-A series) and VVG Low-loss ballasts (EC-B series). Low-loss ballasts have a higher efficiency, which means reduced ballast losses and a lower thermal load. Electronic ballasts are used to run fluorescent lamps at high frequencies (approx. 35 - 40 kHz).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/lampBallastType">s4bldg:lampBallastType</a>
    /// </summary>
    let lampBallastType = _prefixId.prefix "lampBallastType"
    /// <summary>
    ///   <para>rdfs:label : lamp compensation type</para>
    ///   <para>rdfs:comment : Identifies the form of compensation used for power factor correction and radio suppression.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/lampCompensationType">s4bldg:lampCompensationType</a>
    /// </summary>
    let lampCompensationType = _prefixId.prefix "lampCompensationType"
    /// <summary>
    ///   <para>rdfs:label : lamp maintenance factor</para>
    ///   <para>rdfs:comment : Non recoverable losses of luminous flux of a lamp due to lamp depreciation i.e. the decreasing of light output of a luminaire due to aging and dirt.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/lampMaintenanceFactor">s4bldg:lampMaintenanceFactor</a>
    /// </summary>
    let lampMaintenanceFactor = _prefixId.prefix "lampMaintenanceFactor"
    /// <summary>
    ///   <para>rdfs:label : leakage fully closed</para>
    ///   <para>rdfs:comment : Leakage when fully closed. Usually measured in m3/s.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/leakageFullyClosed">s4bldg:leakageFullyClosed</a>
    /// </summary>
    let leakageFullyClosed = _prefixId.prefix "leakageFullyClosed"
    /// <summary>
    ///   <para>rdfs:label : legend</para>
    ///   <para>rdfs:comment : A text inscribed or applied to the switch as a legend to indicate purpose or function.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/legend">s4bldg:legend</a>
    /// </summary>
    let legend = _prefixId.prefix "legend"
    /// <summary>
    ///   <para>rdfs:label : length</para>
    ///   <para>rdfs:comment : The finished length of the device. Usually measured in millimeters (mm).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/length">s4bldg:length</a>
    /// </summary>
    let length = _prefixId.prefix "length"
    /// <summary>
    ///   <para>rdfs:label : lift elevation difference</para>
    ///   <para>rdfs:comment : Elevation difference between cooling tower sump and the top of the tower. Usually measured in millimeters (mm).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/liftElevationDifference">s4bldg:liftElevationDifference</a>
    /// </summary>
    let liftElevationDifference = _prefixId.prefix "liftElevationDifference"
    /// <summary>
    ///   <para>rdfs:label : light emitter nominal power</para>
    ///   <para>rdfs:comment : Light emitter nominal power. Usually measured in Watts (W, J/s).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/lightEmitterNominalPower">s4bldg:lightEmitterNominalPower</a>
    /// </summary>
    let lightEmitterNominalPower = _prefixId.prefix "lightEmitterNominalPower"
    /// <summary>
    ///   <para>rdfs:label : limiting terminal size</para>
    ///   <para>rdfs:comment : The maximum terminal size capacity of the device. Usually measured in square metre (m2).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/limitingTerminalSize">s4bldg:limitingTerminalSize</a>
    /// </summary>
    let limitingTerminalSize = _prefixId.prefix "limitingTerminalSize"
    /// <summary>
    ///   <para>rdfs:label : locked rotor current</para>
    ///   <para>rdfs:comment : Input current when a motor armature is energized but not rotating. Usually measured in Ampere (A).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/lockedRotorCurrent">s4bldg:lockedRotorCurrent</a>
    /// </summary>
    let lockedRotorCurrent = _prefixId.prefix "lockedRotorCurrent"
    /// <summary>
    ///   <para>rdfs:label : manual override</para>
    ///   <para>rdfs:comment : Identifies whether hand-operated operation is provided as an override (= TRUE) or not (= FALSE). Note that this value should be set to FALSE by default in the case of a Hand Operated Actuator.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/manualOverride">s4bldg:manualOverride</a>
    /// </summary>
    let manualOverride = _prefixId.prefix "manualOverride"
    /// <summary>
    ///   <para>rdfs:label : mechanical operated</para>
    ///   <para>rdfs:comment : Indication whether the element is operated machanically (TRUE) or not, i.e. manually (FALSE).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/mechanicalOperated">s4bldg:mechanicalOperated</a>
    /// </summary>
    let mechanicalOperated = _prefixId.prefix "mechanicalOperated"
    /// <summary>
    ///   <para>rdfs:label : media source</para>
    ///   <para>rdfs:comment : Indicates media sources and corresponding names of ports (DistributionPort with FlowDirection=SINK and PredefinedType=AUDIOVISUAL) or aggregated audio/video components (AudioVisualAppliance).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/mediaSource">s4bldg:mediaSource</a>
    /// </summary>
    let mediaSource = _prefixId.prefix "mediaSource"
    /// <summary>
    ///   <para>rdfs:label : motor drive type</para>
    ///   <para>rdfs:comment : Motor drive type: DIRECTDRIVE: Direct drive. BELTDRIVE: Belt drive. COUPLING: Coupling. OTHER: Other type of motor drive. UNKNOWN: Unknown motor drive type. </para>
    ///   <a href="https://saref.etsi.org/saref4bldg/motorDriveType">s4bldg:motorDriveType</a>
    /// </summary>
    let motorDriveType = _prefixId.prefix "motorDriveType"
    /// <summary>
    ///   <para>rdfs:label : motor enclosure type</para>
    ///   <para>rdfs:comment : A list of the available types of motor enclosure from which that required may be selected.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/motorEnclosureType">s4bldg:motorEnclosureType</a>
    /// </summary>
    let motorEnclosureType = _prefixId.prefix "motorEnclosureType"
    /// <summary>
    ///   <para>rdfs:label : net positive suction head</para>
    ///   <para>rdfs:comment : Minimum liquid pressure at the pump inlet to prevent cavitation. Usually measured in Pascals (Pa, N/m2).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/netPositiveSuctionHead">s4bldg:netPositiveSuctionHead</a>
    /// </summary>
    let netPositiveSuctionHead = _prefixId.prefix "netPositiveSuctionHead"
    /// <summary>
    ///   <para>rdfs:label : nominal air flow rate</para>
    ///   <para>rdfs:comment : Nominal rate of air flow. Usually measured in m3/s.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalAirFlowRate">s4bldg:nominalAirFlowRate</a>
    /// </summary>
    let nominalAirFlowRate = _prefixId.prefix "nominalAirFlowRate"
    /// <summary>
    ///   <para>rdfs:label : nominal body depth</para>
    ///   <para>rdfs:comment : Nominal or quoted =length, measured along the z-axis of the local coordinate system of the object, of the body of the object. Usually measured in millimeters (mm).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalBodyDepth">s4bldg:nominalBodyDepth</a>
    /// </summary>
    let nominalBodyDepth = _prefixId.prefix "nominalBodyDepth"
    /// <summary>
    ///   <para>rdfs:label : nominal body length</para>
    ///   <para>rdfs:comment : Nominal or quoted length, measured along the x-axis of the local coordinate system of the object, of the body of the object. Usually measured in millimeters (mm).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalBodyLength">s4bldg:nominalBodyLength</a>
    /// </summary>
    let nominalBodyLength = _prefixId.prefix "nominalBodyLength"
    /// <summary>
    ///   <para>rdfs:label : nominal body width</para>
    ///   <para>rdfs:comment : Nominal or quoted length, measured along the y-axis of the local coordinate system of the object, of the body of the object. Usually measured in millimeters (mm).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalBodyWidth">s4bldg:nominalBodyWidth</a>
    /// </summary>
    let nominalBodyWidth = _prefixId.prefix "nominalBodyWidth"
    /// <summary>
    ///   <para>rdfs:label : nominal capacity</para>
    ///   <para>rdfs:comment : Nominal capacity. Usually measured in Watts (W, J/s).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalCapacity">s4bldg:nominalCapacity</a>
    /// </summary>
    let nominalCapacity = _prefixId.prefix "nominalCapacity"
    /// <summary>
    ///   <para>rdfs:label : nominal condensing temperature</para>
    ///   <para>rdfs:comment : Chiller condensing temperature. Usually measured in degrees Kelvin (K).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalCondensingTemperature">s4bldg:nominalCondensingTemperature</a>
    /// </summary>
    let nominalCondensingTemperature = _prefixId.prefix "nominalCondensingTemperature"
    /// <summary>
    ///   <para>rdfs:label : nominal cooling capacity</para>
    ///   <para>rdfs:comment : Nominal cooling capacity. Usually measured in Watts (W, J/s).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalCoolingCapacity">s4bldg:nominalCoolingCapacity</a>
    /// </summary>
    let nominalCoolingCapacity = _prefixId.prefix "nominalCoolingCapacity"
    /// <summary>
    ///   <para>rdfs:label : nominal depth</para>
    ///   <para>rdfs:comment : The nominal depth of the tank. Note: Not required for a horizontal cylindrical tank. Usually measured in millimeters (mm).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalDepth">s4bldg:nominalDepth</a>
    /// </summary>
    let nominalDepth = _prefixId.prefix "nominalDepth"
    /// <summary>
    ///   <para>rdfs:label : nominal diameter</para>
    ///   <para>rdfs:comment : Nominal diameter or width of the tubes in the tube bundle. Usually measured in millimeters (mm).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalDiameter">s4bldg:nominalDiameter</a>
    /// </summary>
    let nominalDiameter = _prefixId.prefix "nominalDiameter"
    /// <summary>
    ///   <para>rdfs:label : nominal efficiency</para>
    ///   <para>rdfs:comment : Nominal chiller efficiency under nominal conditions. </para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalEfficiency">s4bldg:nominalEfficiency</a>
    /// </summary>
    let nominalEfficiency = _prefixId.prefix "nominalEfficiency"
    /// <summary>
    ///   <para>rdfs:label : nominal energy consumption</para>
    ///   <para>rdfs:comment : Nominal fuel consumption rate required to produce the total boiler heat output. Usually measured in Watts (W, J/s).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalEnergyConsumption">s4bldg:nominalEnergyConsumption</a>
    /// </summary>
    let nominalEnergyConsumption = _prefixId.prefix "nominalEnergyConsumption"

    /// <summary>
    ///   <para>rdfs:label : nominal evaporating temmperature</para>
    ///   <para>rdfs:comment : Chiller evaporating temperature.Usually measured in degrees Kelvin (K).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalEvaporatingTemmperature">s4bldg:nominalEvaporatingTemmperature</a>
    /// </summary>
    let nominalEvaporatingTemmperature = _prefixId.prefix "nominalEvaporatingTemmperature"

    /// <summary>
    ///   <para>rdfs:label : nominal filter face velocity</para>
    ///   <para>rdfs:comment : Filter face velocity. Usually measured in m/s.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalFilterFaceVelocity">s4bldg:nominalFilterFaceVelocity</a>
    /// </summary>
    let nominalFilterFaceVelocity = _prefixId.prefix "nominalFilterFaceVelocity"
    /// <summary>
    ///   <para>rdfs:label : nominal flow rate</para>
    ///   <para>rdfs:comment : Nominal fluid flow rate through the filter. Usually measured in m3/s.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalFlowRate">s4bldg:nominalFlowRate</a>
    /// </summary>
    let nominalFlowRate = _prefixId.prefix "nominalFlowRate"
    /// <summary>
    ///   <para>rdfs:label : nominal frequency</para>
    ///   <para>rdfs:comment : The nominal frequency of the supply. Usually measured in cycles/s or Hertz (Hz).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalFrequency">s4bldg:nominalFrequency</a>
    /// </summary>
    let nominalFrequency = _prefixId.prefix "nominalFrequency"
    /// <summary>
    ///   <para>rdfs:label : nominal heat rejection rate</para>
    ///   <para>rdfs:comment : Sum of the refrigeration effect and the heat equivalent of the power input to the compressor. Usually measured in Watts (W, J/s).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalHeatRejectionRate">s4bldg:nominalHeatRejectionRate</a>
    /// </summary>
    let nominalHeatRejectionRate = _prefixId.prefix "nominalHeatRejectionRate"
    /// <summary>
    ///   <para>rdfs:label : nominal heat transfer area</para>
    ///   <para>rdfs:comment : Nominal heat transfer surface area associated with nominal overall heat transfer coefficient. Usually measured in square metre (m2).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalHeatTransferArea">s4bldg:nominalHeatTransferArea</a>
    /// </summary>
    let nominalHeatTransferArea = _prefixId.prefix "nominalHeatTransferArea"

    /// <summary>
    ///   <para>rdfs:label : nominal heat transfer coefficient</para>
    ///   <para>rdfs:comment : Nominal overall heat transfer coefficient associated with nominal heat transfer area. Usually measured in Watts/m2 Kelvin.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalHeatTransferCoefficient">s4bldg:nominalHeatTransferCoefficient</a>
    /// </summary>
    let nominalHeatTransferCoefficient = _prefixId.prefix "nominalHeatTransferCoefficient"

    /// <summary>
    ///   <para>rdfs:label : nominal heating capacity</para>
    ///   <para>rdfs:comment : Nominal heating capacity. Usually measured in Watts (W, J/s).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalHeatingCapacity">s4bldg:nominalHeatingCapacity</a>
    /// </summary>
    let nominalHeatingCapacity = _prefixId.prefix "nominalHeatingCapacity"
    /// <summary>
    ///   <para>rdfs:label : nominal latent capacity</para>
    ///   <para>rdfs:comment : Nominal latent capacity. Usually measured in Watts (W, J/s).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalLatentCapacity">s4bldg:nominalLatentCapacity</a>
    /// </summary>
    let nominalLatentCapacity = _prefixId.prefix "nominalLatentCapacity"
    /// <summary>
    ///   <para>rdfs:label : nominal length or diameter</para>
    ///   <para>rdfs:comment : The nominal length or, in the case of a vertical cylindrical tank, the nominal diameter of the tank. Usually measured in millimeters (mm).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalLengthOrDiameter">s4bldg:nominalLengthOrDiameter</a>
    /// </summary>
    let nominalLengthOrDiameter = _prefixId.prefix "nominalLengthOrDiameter"
    /// <summary>
    ///   <para>rdfs:label : nominal media surface velocity</para>
    ///   <para>rdfs:comment : Average fluid velocity at the media surface. Usually measured in m/s.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalMediaSurfaceVelocity">s4bldg:nominalMediaSurfaceVelocity</a>
    /// </summary>
    let nominalMediaSurfaceVelocity = _prefixId.prefix "nominalMediaSurfaceVelocity"
    /// <summary>
    ///   <para>rdfs:label : nominal moisture gain</para>
    ///   <para>rdfs:comment : Nominal rate of water vapor added into the airstream. Usually measured in kg/s.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalMoistureGain">s4bldg:nominalMoistureGain</a>
    /// </summary>
    let nominalMoistureGain = _prefixId.prefix "nominalMoistureGain"
    /// <summary>
    ///   <para>rdfs:label : nominal part load ratio</para>
    ///   <para>rdfs:comment : Allowable part load ratio range.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalPartLoadRatio">s4bldg:nominalPartLoadRatio</a>
    /// </summary>
    let nominalPartLoadRatio = _prefixId.prefix "nominalPartLoadRatio"

    /// <summary>
    ///   <para>rdfs:label : nominal particle geometric mean diameter</para>
    ///   <para>rdfs:comment : Particle geometric mean diameter associated with nominal efficiency. Usually measured in millimeters (mm).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalParticleGeometricMeanDiameter">s4bldg:nominalParticleGeometricMeanDiameter</a>
    /// </summary>
    let nominalParticleGeometricMeanDiameter = _prefixId.prefix "nominalParticleGeometricMeanDiameter"

    /// <summary>
    ///   <para>rdfs:label : nominal particle geometric standard deviation</para>
    ///   <para>rdfs:comment : Particle geometric standard deviation associated with nominal efficiency. </para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalParticleGeometricStandardDeviation">s4bldg:nominalParticleGeometricStandardDeviation</a>
    /// </summary>
    let nominalParticleGeometricStandardDeviation = _prefixId.prefix "nominalParticleGeometricStandardDeviation"

    /// <summary>
    ///   <para>rdfs:label : nominal power consumption</para>
    ///   <para>rdfs:comment : Nominal total power consumption. Usually measured in Watts (W, J/s).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalPowerConsumption">s4bldg:nominalPowerConsumption</a>
    /// </summary>
    let nominalPowerConsumption = _prefixId.prefix "nominalPowerConsumption"
    /// <summary>
    ///   <para>rdfs:label : nominal power rate</para>
    ///   <para>rdfs:comment : Nominal fan power rate.Usually measured in Watts (W, J/s).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalPowerRate">s4bldg:nominalPowerRate</a>
    /// </summary>
    let nominalPowerRate = _prefixId.prefix "nominalPowerRate"
    /// <summary>
    ///   <para>rdfs:label : nominal pressure drop</para>
    ///   <para>rdfs:comment : Total pressure drop across the filter. Usually measured in Pascals (Pa, N/m2).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalPressureDrop">s4bldg:nominalPressureDrop</a>
    /// </summary>
    let nominalPressureDrop = _prefixId.prefix "nominalPressureDrop"

    /// <summary>
    ///   <para>rdfs:label : nominal return water temperature cooling</para>
    ///   <para>rdfs:comment : Nominal return water temperature (refers to nominal cooling capacity). Usually measured in degrees Kelvin (K).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalReturnWaterTemperatureCooling">s4bldg:nominalReturnWaterTemperatureCooling</a>
    /// </summary>
    let nominalReturnWaterTemperatureCooling = _prefixId.prefix "nominalReturnWaterTemperatureCooling"

    /// <summary>
    ///   <para>rdfs:label : nominal return water temperature heating</para>
    ///   <para>rdfs:comment : Nominal return water temperature (refers to nominal heating capacity). Usually measured in degrees Kelvin (K).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalReturnWaterTemperatureHeating">s4bldg:nominalReturnWaterTemperatureHeating</a>
    /// </summary>
    let nominalReturnWaterTemperatureHeating = _prefixId.prefix "nominalReturnWaterTemperatureHeating"

    /// <summary>
    ///   <para>rdfs:label : nominal rotation speed</para>
    ///   <para>rdfs:comment : Nominal fan wheel speed. Usually measured in cycles/s.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalRotationSpeed">s4bldg:nominalRotationSpeed</a>
    /// </summary>
    let nominalRotationSpeed = _prefixId.prefix "nominalRotationSpeed"
    /// <summary>
    ///   <para>rdfs:label : nominal sensible capacity</para>
    ///   <para>rdfs:comment : Nominal sensible capacity. Usually measured in Watts (W, J/s).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalSensibleCapacity">s4bldg:nominalSensibleCapacity</a>
    /// </summary>
    let nominalSensibleCapacity = _prefixId.prefix "nominalSensibleCapacity"

    /// <summary>
    ///   <para>rdfs:label : nominal sorrounding humidity cooling</para>
    ///   <para>rdfs:comment : Nominal surrounding humidity (refers to nominal cooling capacity). Usually measured in degrees Kelvin (K).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalSorroundingHumidityCooling">s4bldg:nominalSorroundingHumidityCooling</a>
    /// </summary>
    let nominalSorroundingHumidityCooling = _prefixId.prefix "nominalSorroundingHumidityCooling"

    /// <summary>
    ///   <para>rdfs:label : nominal sorrounding temperature cooling</para>
    ///   <para>rdfs:comment : Nominal surrounding temperature (refers to nominal cooling capacity). Usually measured in degrees Kelvin (K).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalSorroundingTemperatureCooling">s4bldg:nominalSorroundingTemperatureCooling</a>
    /// </summary>
    let nominalSorroundingTemperatureCooling = _prefixId.prefix "nominalSorroundingTemperatureCooling"

    /// <summary>
    ///   <para>rdfs:label : nominal sorrounding temperature heating</para>
    ///   <para>rdfs:comment : Nominal surrounding temperature (refers to nominal heating capacity). Usually measured in degrees Kelvin (K).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalSorroundingTemperatureHeating">s4bldg:nominalSorroundingTemperatureHeating</a>
    /// </summary>
    let nominalSorroundingTemperatureHeating = _prefixId.prefix "nominalSorroundingTemperatureHeating"

    /// <summary>
    ///   <para>rdfs:label : nominal static pressure</para>
    ///   <para>rdfs:comment : The static pressure within the air stream that the fan must overcome to insure designed circulation of air. Usually measured in Pascals (Pa, N/m2).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalStaticPressure">s4bldg:nominalStaticPressure</a>
    /// </summary>
    let nominalStaticPressure = _prefixId.prefix "nominalStaticPressure"
    /// <summary>
    ///   <para>rdfs:label : nominal supply voltage</para>
    ///   <para>rdfs:comment : The nominal voltage of the supply. Usually measured in Volts (V, W/A).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalSupplyVoltage">s4bldg:nominalSupplyVoltage</a>
    /// </summary>
    let nominalSupplyVoltage = _prefixId.prefix "nominalSupplyVoltage"
    /// <summary>
    ///   <para>rdfs:label : nominal supply voltage offset</para>
    ///   <para>rdfs:comment : The maximum and minimum allowed voltage of the supply e.g. boundaries of 380V/440V may be applied for a nominal voltage of 400V.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalSupplyVoltageMax">s4bldg:nominalSupplyVoltageMax</a>
    /// </summary>
    let nominalSupplyVoltageMax = _prefixId.prefix "nominalSupplyVoltageMax"
    /// <summary>
    ///   <para>rdfs:label : nominal supply voltage offset</para>
    ///   <para>rdfs:comment : The maximum and minimum allowed voltage of the supply e.g. boundaries of 380V/440V may be applied for a nominal voltage of 400V.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalSupplyVoltageMin">s4bldg:nominalSupplyVoltageMin</a>
    /// </summary>
    let nominalSupplyVoltageMin = _prefixId.prefix "nominalSupplyVoltageMin"

    /// <summary>
    ///   <para>rdfs:label : nominal supply water temperature cooling</para>
    ///   <para>rdfs:comment : Nominal supply water temperature (refers to nominal cooling capacity). Usually measured in degrees Kelvin (K).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalSupplyWaterTemperatureCooling">s4bldg:nominalSupplyWaterTemperatureCooling</a>
    /// </summary>
    let nominalSupplyWaterTemperatureCooling = _prefixId.prefix "nominalSupplyWaterTemperatureCooling"

    /// <summary>
    ///   <para>rdfs:label : nominal supply water temperature heating</para>
    ///   <para>rdfs:comment : Nominal supply water temperature (refers to nominal heating capacity). Usually measured in degrees Kelvin (K).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalSupplyWaterTemperatureHeating">s4bldg:nominalSupplyWaterTemperatureHeating</a>
    /// </summary>
    let nominalSupplyWaterTemperatureHeating = _prefixId.prefix "nominalSupplyWaterTemperatureHeating"

    /// <summary>
    ///   <para>rdfs:label : nominal total pressure</para>
    ///   <para>rdfs:comment : Nominal total pressure rise across the fan. Usually measured in Pascals (Pa, N/m2).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalTotalPressure">s4bldg:nominalTotalPressure</a>
    /// </summary>
    let nominalTotalPressure = _prefixId.prefix "nominalTotalPressure"
    /// <summary>
    ///   <para>rdfs:label : nominal ua</para>
    ///   <para>rdfs:comment : Nominal UA value.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalUa">s4bldg:nominalUa</a>
    /// </summary>
    let nominalUa = _prefixId.prefix "nominalUa"
    /// <summary>
    ///   <para>rdfs:label : nominal volumetric capacity</para>
    ///   <para>rdfs:comment : The total nominal or design volumetric capacity of the tank. Usually measured in cubic metre (m3).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalVolumetricCapacity">s4bldg:nominalVolumetricCapacity</a>
    /// </summary>
    let nominalVolumetricCapacity = _prefixId.prefix "nominalVolumetricCapacity"
    /// <summary>
    ///   <para>rdfs:label : nominal water flow cooling</para>
    ///   <para>rdfs:comment : Nominal water flow (refers to nominal cooling capacity). Usually measured in m3/s.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalWaterFlowCooling">s4bldg:nominalWaterFlowCooling</a>
    /// </summary>
    let nominalWaterFlowCooling = _prefixId.prefix "nominalWaterFlowCooling"
    /// <summary>
    ///   <para>rdfs:label : nominal water flow heating</para>
    ///   <para>rdfs:comment : Nominal water flow (refers to nominal heating capacity). Usually measured in m3/s.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalWaterFlowHeating">s4bldg:nominalWaterFlowHeating</a>
    /// </summary>
    let nominalWaterFlowHeating = _prefixId.prefix "nominalWaterFlowHeating"
    /// <summary>
    ///   <para>rdfs:label : nominal width or diameter</para>
    ///   <para>rdfs:comment : The nominal width or, in the case of a horizontal cylindrical tank, the nominal diameter of the tank. Note: Not required for a vertical cylindrical tank. Usually measured in millimeters (mm).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nominalWidthOrDiameter">s4bldg:nominalWidthOrDiameter</a>
    /// </summary>
    let nominalWidthOrDiameter = _prefixId.prefix "nominalWidthOrDiameter"
    /// <summary>
    ///   <para>rdfs:label : nomminal rotation speed</para>
    ///   <para>rdfs:comment : Pump rotational speed under nominal conditions. Usually measured in cycles/s.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/nomminalRotationSpeed">s4bldg:nomminalRotationSpeed</a>
    /// </summary>
    let nomminalRotationSpeed = _prefixId.prefix "nomminalRotationSpeed"
    /// <summary>
    ///   <para>rdfs:label : number of blades</para>
    ///   <para>rdfs:comment : Number of blades.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/numberOfBlades">s4bldg:numberOfBlades</a>
    /// </summary>
    let numberOfBlades = _prefixId.prefix "numberOfBlades"
    /// <summary>
    ///   <para>rdfs:label : number of cells</para>
    ///   <para>rdfs:comment : Number of cells in one cooling tower unit.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/numberOfCells">s4bldg:numberOfCells</a>
    /// </summary>
    let numberOfCells = _prefixId.prefix "numberOfCells"
    /// <summary>
    ///   <para>rdfs:label : number of circuits</para>
    ///   <para>rdfs:comment : Number of parallel fluid tube circuits.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/numberOfCircuits">s4bldg:numberOfCircuits</a>
    /// </summary>
    let numberOfCircuits = _prefixId.prefix "numberOfCircuits"
    /// <summary>
    ///   <para>rdfs:label : number of gangs</para>
    ///   <para>rdfs:comment : Number of gangs/buttons on this switch.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/numberOfGangs">s4bldg:numberOfGangs</a>
    /// </summary>
    let numberOfGangs = _prefixId.prefix "numberOfGangs"
    /// <summary>
    ///   <para>rdfs:label : number of panels</para>
    ///   <para>rdfs:comment : Number of panels.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/numberOfPanels">s4bldg:numberOfPanels</a>
    /// </summary>
    let numberOfPanels = _prefixId.prefix "numberOfPanels"
    /// <summary>
    ///   <para>rdfs:label : number of rows</para>
    ///   <para>rdfs:comment : Number of tube rows in the tube bundle assembly.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/numberOfRows">s4bldg:numberOfRows</a>
    /// </summary>
    let numberOfRows = _prefixId.prefix "numberOfRows"
    /// <summary>
    ///   <para>rdfs:label : number of sections</para>
    ///   <para>rdfs:comment : Number of sections used.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/numberOfSections">s4bldg:numberOfSections</a>
    /// </summary>
    let numberOfSections = _prefixId.prefix "numberOfSections"
    /// <summary>
    ///   <para>rdfs:label : number os sockets</para>
    ///   <para>rdfs:comment : The number of sockets that may be connected. In case of inconsistency, sockets defined on ports take precedence.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/numberOsSockets">s4bldg:numberOsSockets</a>
    /// </summary>
    let numberOsSockets = _prefixId.prefix "numberOsSockets"
    /// <summary>
    ///   <para>rdfs:label : open pressure drop</para>
    ///   <para>rdfs:comment : Total pressure drop across damper. Usually measured in Pascals (Pa, N/m2).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/openPressureDrop">s4bldg:openPressureDrop</a>
    /// </summary>
    let openPressureDrop = _prefixId.prefix "openPressureDrop"
    /// <summary>
    ///   <para>rdfs:label : operating mode</para>
    ///   <para>rdfs:comment : Identifies the operating mode of the boiler.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/operatingMode">s4bldg:operatingMode</a>
    /// </summary>
    let operatingMode = _prefixId.prefix "operatingMode"
    /// <summary>
    ///   <para>rdfs:label : operating weight</para>
    ///   <para>rdfs:comment : Operating weight of the tank including all of its contents. Usually measured in kilograms (kg) or grams (g).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/operatingWeight">s4bldg:operatingWeight</a>
    /// </summary>
    let operatingWeight = _prefixId.prefix "operatingWeight"
    /// <summary>
    ///   <para>rdfs:label : operation</para>
    ///   <para>rdfs:comment : The operational mechanism for the damper operation.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/operation">s4bldg:operation</a>
    /// </summary>
    let operation = _prefixId.prefix "operation"
    /// <summary>
    ///   <para>rdfs:label : operation temperature range</para>
    ///   <para>rdfs:comment : Allowable operation ambient (air, fluid) temperature range. Usually measured in degrees Kelvin (K).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/operationTemperatureMax">s4bldg:operationTemperatureMax</a>
    /// </summary>
    let operationTemperatureMax = _prefixId.prefix "operationTemperatureMax"
    /// <summary>
    ///   <para>rdfs:label : operation temperature range</para>
    ///   <para>rdfs:comment : Allowable operation ambient (air, fluid) temperature range. Usually measured in degrees Kelvin (K).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/operationTemperatureMin">s4bldg:operationTemperatureMin</a>
    /// </summary>
    let operationTemperatureMin = _prefixId.prefix "operationTemperatureMin"
    /// <summary>
    ///   <para>rdfs:label : operational riterial</para>
    ///   <para>rdfs:comment : Time of operation at maximum operational ambient air temperature. Measured in seconds (s) or days (d) or other units of time.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/operationalRiterial">s4bldg:operationalRiterial</a>
    /// </summary>
    let operationalRiterial = _prefixId.prefix "operationalRiterial"
    /// <summary>
    ///   <para>rdfs:label : orientation</para>
    ///   <para>rdfs:comment : The intended orientation for the damper as specified by the manufacturer.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/orientation">s4bldg:orientation</a>
    /// </summary>
    let orientation = _prefixId.prefix "orientation"
    /// <summary>
    ///   <para>rdfs:label : outlet connection size</para>
    ///   <para>rdfs:comment : Size of the outlet connection. Usually measured in millimeters (mm).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/outletConnectionSize">s4bldg:outletConnectionSize</a>
    /// </summary>
    let outletConnectionSize = _prefixId.prefix "outletConnectionSize"
    /// <summary>
    ///   <para>rdfs:label : outlet temperature range</para>
    ///   <para>rdfs:comment : Allowable outlet temperature of either the water or the steam. Usually measured in degrees Kelvin (K).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/outletTemperatureMax">s4bldg:outletTemperatureMax</a>
    /// </summary>
    let outletTemperatureMax = _prefixId.prefix "outletTemperatureMax"
    /// <summary>
    ///   <para>rdfs:label : outlet temperature range</para>
    ///   <para>rdfs:comment : Allowable outlet temperature of either the water or the steam. Usually measured in degrees Kelvin (K).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/outletTemperatureMin">s4bldg:outletTemperatureMin</a>
    /// </summary>
    let outletTemperatureMin = _prefixId.prefix "outletTemperatureMin"
    /// <summary>
    ///   <para>rdfs:label : output capacity</para>
    ///   <para>rdfs:comment : Total nominal heat output as listed by the manufacturer. Usually measured in Watts (W, J/s).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/outputCapacity">s4bldg:outputCapacity</a>
    /// </summary>
    let outputCapacity = _prefixId.prefix "outputCapacity"
    /// <summary>
    ///   <para>rdfs:label : outside diameter</para>
    ///   <para>rdfs:comment : Actual outside diameter of the tube in the tube bundle. Usually measured in millimeters (mm).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/outsideDiameter">s4bldg:outsideDiameter</a>
    /// </summary>
    let outsideDiameter = _prefixId.prefix "outsideDiameter"
    /// <summary>
    ///   <para>rdfs:label : maximum part load ratio</para>
    ///   <para>rdfs:comment : Maximum part load ratio as a fraction of nominal capacity.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/partLoadRatioMax">s4bldg:partLoadRatioMax</a>
    /// </summary>
    let partLoadRatioMax = _prefixId.prefix "partLoadRatioMax"
    /// <summary>
    ///   <para>rdfs:label : minimum part load ratio</para>
    ///   <para>rdfs:comment : Minimum part load ratio as a fraction of nominal capacity.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/partLoadRatioMin">s4bldg:partLoadRatioMin</a>
    /// </summary>
    let partLoadRatioMin = _prefixId.prefix "partLoadRatioMin"
    /// <summary>
    ///   <para>rdfs:label : pattern type</para>
    ///   <para>rdfs:comment : Defines the types of pattern (or shape of a tank that may be specified.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/patternType">s4bldg:patternType</a>
    /// </summary>
    let patternType = _prefixId.prefix "patternType"
    /// <summary>
    ///   <para>rdfs:label : pipe connection enum</para>
    ///   <para>rdfs:comment : The manner in which the pipe connection is made to the cooled beam.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/pipeConnectionEnum">s4bldg:pipeConnectionEnum</a>
    /// </summary>
    let pipeConnectionEnum = _prefixId.prefix "pipeConnectionEnum"
    /// <summary>
    ///   <para>rdfs:label : placement type</para>
    ///   <para>rdfs:comment : Indicates how the device is designed to be placed.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/placementType">s4bldg:placementType</a>
    /// </summary>
    let placementType = _prefixId.prefix "placementType"
    /// <summary>
    ///   <para>rdfs:label : maximum power output</para>
    ///   <para>rdfs:comment : The maximum output power rating of the engine. Usually measured in Watts (W, J/s).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/powerOutputMax">s4bldg:powerOutputMax</a>
    /// </summary>
    let powerOutputMax = _prefixId.prefix "powerOutputMax"
    /// <summary>
    ///   <para>rdfs:label : power source</para>
    ///   <para>rdfs:comment : Type of power driving the compressor.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/powerSource">s4bldg:powerSource</a>
    /// </summary>
    let powerSource = _prefixId.prefix "powerSource"
    /// <summary>
    ///   <para>rdfs:label : pressure rating</para>
    ///   <para>rdfs:comment : Nominal pressure rating of the boiler as rated by the agency having jurisdiction. Usually measured in Pascals (Pa, N/m2).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/pressureRating">s4bldg:pressureRating</a>
    /// </summary>
    let pressureRating = _prefixId.prefix "pressureRating"
    /// <summary>
    ///   <para>rdfs:label : primary air flow rate range</para>
    ///   <para>rdfs:comment : Maximum primary airflow that can be delivered. Usually measured in m3/s.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/primaryAirFlowRateMax">s4bldg:primaryAirFlowRateMax</a>
    /// </summary>
    let primaryAirFlowRateMax = _prefixId.prefix "primaryAirFlowRateMax"
    /// <summary>
    ///   <para>rdfs:label : primary air flow rate range</para>
    ///   <para>rdfs:comment : Minimum primary airflow that can be delivered. Usually measured in m3/s.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/primaryAirFlowRateMin">s4bldg:primaryAirFlowRateMin</a>
    /// </summary>
    let primaryAirFlowRateMin = _prefixId.prefix "primaryAirFlowRateMin"
    /// <summary>
    ///   <para>rdfs:label : primary apparent power</para>
    ///   <para>rdfs:comment : The power in VA (volt ampere) that has been transformed and that runs into the transformer on the primary side. Usually measured in Watts (W, J/s).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/primaryApparentPower">s4bldg:primaryApparentPower</a>
    /// </summary>
    let primaryApparentPower = _prefixId.prefix "primaryApparentPower"
    /// <summary>
    ///   <para>rdfs:label : primary current</para>
    ///   <para>rdfs:comment : The current that is going to be transformed and that runs into the transformer on the primary side. Usually measured in Ampere (A).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/primaryCurrent">s4bldg:primaryCurrent</a>
    /// </summary>
    let primaryCurrent = _prefixId.prefix "primaryCurrent"
    /// <summary>
    ///   <para>rdfs:label : primary frequency</para>
    ///   <para>rdfs:comment : The frequency that is going to be transformed and that runs into the transformer on the primary side. Usually measured in cycles/s or Hertz (Hz).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/primaryFrequency">s4bldg:primaryFrequency</a>
    /// </summary>
    let primaryFrequency = _prefixId.prefix "primaryFrequency"
    /// <summary>
    ///   <para>rdfs:label : primary voltage</para>
    ///   <para>rdfs:comment : The voltage that is going to be transformed and that runs into the transformer on the primary side. Usually measured in Volts (V, W/A).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/primaryVoltage">s4bldg:primaryVoltage</a>
    /// </summary>
    let primaryVoltage = _prefixId.prefix "primaryVoltage"
    /// <summary>
    ///   <para>rdfs:label : pump flow rate range</para>
    ///   <para>rdfs:comment : Allowable range of volume of fluid being pumped against the resistance specified. Usually measured in kg/s.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/pumpFlowRateMax">s4bldg:pumpFlowRateMax</a>
    /// </summary>
    let pumpFlowRateMax = _prefixId.prefix "pumpFlowRateMax"
    /// <summary>
    ///   <para>rdfs:label : pump flow rate range</para>
    ///   <para>rdfs:comment : Allowable range of volume of fluid being pumped against the resistance specified. Usually measured in kg/s.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/pumpFlowRateMin">s4bldg:pumpFlowRateMin</a>
    /// </summary>
    let pumpFlowRateMin = _prefixId.prefix "pumpFlowRateMin"
    /// <summary>
    ///   <para>rdfs:label : read out type</para>
    ///   <para>rdfs:comment : Indication of the form that readout from the meter takes. In the case of a dial read out, this may comprise multiple dials that give a cumulative reading and/or a mechanical odometer.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/readOutType">s4bldg:readOutType</a>
    /// </summary>
    let readOutType = _prefixId.prefix "readOutType"
    /// <summary>
    ///   <para>rdfs:label : real impedance ratio</para>
    ///   <para>rdfs:comment : The ratio between the real part of the zero sequence impedance and the real part of the positive impedance (i.e. real part of the short-circuit voltage) of the transformer. Used for three-phase transformer which includes a N-conductor.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/realImpedanceRatio">s4bldg:realImpedanceRatio</a>
    /// </summary>
    let realImpedanceRatio = _prefixId.prefix "realImpedanceRatio"
    /// <summary>
    ///   <para>rdfs:label : refrigerant class</para>
    ///   <para>rdfs:comment : Refrigerant class used by the compressor. CFC: Chlorofluorocarbons. HCFC: Hydrochlorofluorocarbons. HFC: Hydrofluorocarbons.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/refrigerantClass">s4bldg:refrigerantClass</a>
    /// </summary>
    let refrigerantClass = _prefixId.prefix "refrigerantClass"
    /// <summary>
    ///   <para>rdfs:label : remote reading</para>
    ///   <para>rdfs:comment : Indicates whether the meter has a connection for remote reading through connection of a communication device (set TRUE) or not (set FALSE).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/remoteReading">s4bldg:remoteReading</a>
    /// </summary>
    let remoteReading = _prefixId.prefix "remoteReading"
    /// <summary>
    ///   <para>rdfs:label : roughness</para>
    ///   <para>rdfs:comment : A measure of the vertical deviations of the surface.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/roughness">s4bldg:roughness</a>
    /// </summary>
    let roughness = _prefixId.prefix "roughness"
    /// <summary>
    ///   <para>rdfs:label : second curvature radius</para>
    ///   <para>rdfs:comment : SecondCurvatureRadius should be defined as the top or right side radius of curvature value. Usually measured in millimeters (mm).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/secondCurvatureRadius">s4bldg:secondCurvatureRadius</a>
    /// </summary>
    let secondCurvatureRadius = _prefixId.prefix "secondCurvatureRadius"
    /// <summary>
    ///   <para>rdfs:label : secondary air flow rate range</para>
    ///   <para>rdfs:comment : Maximum secondary airflow that can be delivered. Usually measured in Pascals (Pa, N/m2).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/secondaryAirFlowRateMax">s4bldg:secondaryAirFlowRateMax</a>
    /// </summary>
    let secondaryAirFlowRateMax = _prefixId.prefix "secondaryAirFlowRateMax"
    /// <summary>
    ///   <para>rdfs:label : secondary air flow rate range</para>
    ///   <para>rdfs:comment : Maximum secondary airflow that can be delivered. Usually measured in Pascals (Pa, N/m2).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/secondaryAirFlowRateMin">s4bldg:secondaryAirFlowRateMin</a>
    /// </summary>
    let secondaryAirFlowRateMin = _prefixId.prefix "secondaryAirFlowRateMin"
    /// <summary>
    ///   <para>rdfs:label : secondary apparent power</para>
    ///   <para>rdfs:comment : The power in VA (volt ampere) that has been transformed and is running out of the transformer on the secondary side. Usually measured in Watts (W, J/s).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/secondaryApparentPower">s4bldg:secondaryApparentPower</a>
    /// </summary>
    let secondaryApparentPower = _prefixId.prefix "secondaryApparentPower"
    /// <summary>
    ///   <para>rdfs:label : secondary current</para>
    ///   <para>rdfs:comment : The current that has been transformed and is running out of the transformer on the secondary side. Usually measured in Ampere (A).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/secondaryCurrent">s4bldg:secondaryCurrent</a>
    /// </summary>
    let secondaryCurrent = _prefixId.prefix "secondaryCurrent"
    /// <summary>
    ///   <para>rdfs:label : secondary current type</para>
    ///   <para>rdfs:comment : A list of the secondary current types that can result from transformer output.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/secondaryCurrentType">s4bldg:secondaryCurrentType</a>
    /// </summary>
    let secondaryCurrentType = _prefixId.prefix "secondaryCurrentType"
    /// <summary>
    ///   <para>rdfs:label : secondary frequency</para>
    ///   <para>rdfs:comment : The frequency that has been transformed and is running out of the transformer on the secondary side. Usually measured in cycles/s or Hertz (Hz).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/secondaryFrequency">s4bldg:secondaryFrequency</a>
    /// </summary>
    let secondaryFrequency = _prefixId.prefix "secondaryFrequency"
    /// <summary>
    ///   <para>rdfs:label : secondary voltage</para>
    ///   <para>rdfs:comment : The voltage that has been transformed and is running out of the transformer on the secondary side. Usually measured in Volts (V, W/A).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/secondaryVoltage">s4bldg:secondaryVoltage</a>
    /// </summary>
    let secondaryVoltage = _prefixId.prefix "secondaryVoltage"
    /// <summary>
    ///   <para>rdfs:label : shading device type</para>
    ///   <para>rdfs:comment : Specifies the type of shading device.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/shadingDeviceType">s4bldg:shadingDeviceType</a>
    /// </summary>
    let shadingDeviceType = _prefixId.prefix "shadingDeviceType"
    /// <summary>
    ///   <para>rdfs:label : short circuit voltage</para>
    ///   <para>rdfs:comment : A complex number that specifies the real and imaginary parts of the short-circuit voltage at rated current of a transformer given in %.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/shortCircuitVoltage">s4bldg:shortCircuitVoltage</a>
    /// </summary>
    let shortCircuitVoltage = _prefixId.prefix "shortCircuitVoltage"
    /// <summary>
    ///   <para>rdfs:label : size</para>
    ///   <para>rdfs:comment : The size of the connection to the valve (or to each connection for faucets, mixing valves, etc.). Usually measured in millimeters (mm).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/size">s4bldg:size</a>
    /// </summary>
    let size = _prefixId.prefix "size"
    /// <summary>
    ///   <para>rdfs:label : solar reflectance</para>
    ///   <para>rdfs:comment : (Rsol): The ratio of incident solar radiation that is reflected by a shading system (also named _e). Note the following equation Asol + Rsol + Tsol = 1</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/solarReflectance">s4bldg:solarReflectance</a>
    /// </summary>
    let solarReflectance = _prefixId.prefix "solarReflectance"
    /// <summary>
    ///   <para>rdfs:label : solar transmittance</para>
    ///   <para>rdfs:comment : (Tsol) The ratio of incident solar radiation that directly passes through a shading system (also named _e). Note the following equation Asol + Rsol + Tsol = 1</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/solarTransmittance">s4bldg:solarTransmittance</a>
    /// </summary>
    let solarTransmittance = _prefixId.prefix "solarTransmittance"
    /// <summary>
    ///   <para>rdfs:label : maximum spectrum</para>
    ///   <para>rdfs:comment : The spectrum of radiation describes its composition with regard to wavelength. Light, for example, as the portion of electromagnetic radiation that is visible to the human eye, is radiation with wavelengths in the range of approx. 380 to 780 nm (1 nm = 10 m). The corresponding range of colours varies from violet to indigo, blue, green, yellow, orange, and red. These colours form a continuous spectrum, in which the various spectral sectors merge into each other.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/spectrumMax">s4bldg:spectrumMax</a>
    /// </summary>
    let spectrumMax = _prefixId.prefix "spectrumMax"
    /// <summary>
    ///   <para>rdfs:label : minimum spectrum</para>
    ///   <para>rdfs:comment : The spectrum of radiation describes its composition with regard to wavelength. Light, for example, as the portion of electromagnetic radiation that is visible to the human eye, is radiation with wavelengths in the range of approx. 380 to 780 nm (1 nm = 10 m). The corresponding range of colours varies from violet to indigo, blue, green, yellow, orange, and red. These colours form a continuous spectrum, in which the various spectral sectors merge into each other.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/spectrumMin">s4bldg:spectrumMin</a>
    /// </summary>
    let spectrumMin = _prefixId.prefix "spectrumMin"
    /// <summary>
    ///   <para>rdfs:label : spray type</para>
    ///   <para>rdfs:comment : SprayFilled: Water is sprayed into airflow. SplashTypeFill: water cascades over successive rows of splash bars. FilmTypeFill: water flows in a thin layer over closely spaced sheets.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/sprayType">s4bldg:sprayType</a>
    /// </summary>
    let sprayType = _prefixId.prefix "sprayType"
    /// <summary>
    ///   <para>rdfs:label : staggered row spacing</para>
    ///   <para>rdfs:comment : Staggered tube row spacing. Usually measured in millimeters (mm).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/staggeredRowSpacing">s4bldg:staggeredRowSpacing</a>
    /// </summary>
    let staggeredRowSpacing = _prefixId.prefix "staggeredRowSpacing"
    /// <summary>
    ///   <para>rdfs:label : standard</para>
    ///   <para>rdfs:comment : The designation of the standard applicable for the definition of the characteristics of the unit.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/standard">s4bldg:standard</a>
    /// </summary>
    let standard = _prefixId.prefix "standard"
    /// <summary>
    ///   <para>rdfs:label : start current factor</para>
    ///   <para>rdfs:comment : IEC. Start current factor defines how large the peek starting current will become on the engine. StartCurrentFactor is multiplied to NominalCurrent and we get the start current.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/startCurrentFactor">s4bldg:startCurrentFactor</a>
    /// </summary>
    let startCurrentFactor = _prefixId.prefix "startCurrentFactor"
    /// <summary>
    ///   <para>rdfs:label : starting time</para>
    ///   <para>rdfs:comment : The time (in s) needed for the motor to reach its rated speed with its driven equipment attached, starting from standstill and at the nominal voltage applied at its terminals.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/startingTime">s4bldg:startingTime</a>
    /// </summary>
    let startingTime = _prefixId.prefix "startingTime"
    /// <summary>
    ///   <para>rdfs:label : storage type</para>
    ///   <para>rdfs:comment : Defines the general material category intended to be stored.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/storageType">s4bldg:storageType</a>
    /// </summary>
    let storageType = _prefixId.prefix "storageType"
    /// <summary>
    ///   <para>rdfs:label : maximum supported weight</para>
    ///   <para>rdfs:comment : The maximum weight that can be carried by the vibration isolator. Usually measured in kilograms (kg) or grams (g).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/supportedWeightMax">s4bldg:supportedWeightMax</a>
    /// </summary>
    let supportedWeightMax = _prefixId.prefix "supportedWeightMax"
    /// <summary>
    ///   <para>rdfs:label : switch function</para>
    ///   <para>rdfs:comment : Indicates types of switches which differs in functionality.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/switchFunction">s4bldg:switchFunction</a>
    /// </summary>
    let switchFunction = _prefixId.prefix "switchFunction"
    /// <summary>
    ///   <para>rdfs:label : te time</para>
    ///   <para>rdfs:comment : The maximum time (in s) at which the motor could run with locked rotor when the motor is used in an EX-environment. The time indicates that a protective device should trip before this time when the starting current of the motor is slowing through the device.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/teTime">s4bldg:teTime</a>
    /// </summary>
    let teTime = _prefixId.prefix "teTime"
    /// <summary>
    ///   <para>rdfs:label : temperature classification</para>
    ///   <para>rdfs:comment : Enumeration defining the temperature classification of the space heater surface temperature. low temperature - surface temperature is relatively low, usually heated by hot water or electricity. high temperature - surface temperature is relatively high, usually heated by gas or steam.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/temperatureClassification">s4bldg:temperatureClassification</a>
    /// </summary>
    let temperatureClassification = _prefixId.prefix "temperatureClassification"
    /// <summary>
    ///   <para>rdfs:label : temperature rating</para>
    ///   <para>rdfs:comment : Temperature rating. Usually measured in degrees Kelvin (K).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/temperatureRating">s4bldg:temperatureRating</a>
    /// </summary>
    let temperatureRating = _prefixId.prefix "temperatureRating"
    /// <summary>
    ///   <para>rdfs:label : test pressure</para>
    ///   <para>rdfs:comment : The maximum pressure to which the valve has been subjected under test. Usually measured in Pascals (Pa, N/m2).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/testPressure">s4bldg:testPressure</a>
    /// </summary>
    let testPressure = _prefixId.prefix "testPressure"
    /// <summary>
    ///   <para>rdfs:label : thermal conductivity</para>
    ///   <para>rdfs:comment : Fouling factor of the tubes in the tube bundle. Usually measured in m2 Kelvin/Watt.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/thermalConductivity">s4bldg:thermalConductivity</a>
    /// </summary>
    let thermalConductivity = _prefixId.prefix "thermalConductivity"
    /// <summary>
    ///   <para>rdfs:label : thermal efficiency</para>
    ///   <para>rdfs:comment : Overall Thermal Efficiency is defined as gross energy output of the heat transfer device divided by the energy input.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/thermalEfficiency">s4bldg:thermalEfficiency</a>
    /// </summary>
    let thermalEfficiency = _prefixId.prefix "thermalEfficiency"
    /// <summary>
    ///   <para>rdfs:label : thermal mass heat capacity</para>
    ///   <para>rdfs:comment : Product of component mass and specific heat.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/thermalMassHeatCapacity">s4bldg:thermalMassHeatCapacity</a>
    /// </summary>
    let thermalMassHeatCapacity = _prefixId.prefix "thermalMassHeatCapacity"
    /// <summary>
    ///   <para>rdfs:label : thermal transmittance</para>
    ///   <para>rdfs:comment : Rate at which energy is transmitted through a body. Usually measured in Watts/m2 Kelvin.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/thermalTransmittance">s4bldg:thermalTransmittance</a>
    /// </summary>
    let thermalTransmittance = _prefixId.prefix "thermalTransmittance"
    /// <summary>
    ///   <para>rdfs:label : transformer vector group</para>
    ///   <para>rdfs:comment : List of the possible vector groups for the transformer from which that required may be set. Values in the enumeration list follow a standard international code where the first letter describes how the primary windings are connected, the second letter describes how the secondary windings are connected, and the numbers describe the rotation of voltages and currents from the primary to the secondary side in multiples of 30 degrees. D: means that the windings are delta-connected. Y: means that the windings are star-connected. Z: means that the windings are zig-zag connected (a special start-connected providing low reactance of the transformer). The connectivity is only relevant for three-phase transformers.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/transformerVectorGroup">s4bldg:transformerVectorGroup</a>
    /// </summary>
    let transformerVectorGroup = _prefixId.prefix "transformerVectorGroup"
    /// <summary>
    ///   <para>rdfs:label : valve mechanism</para>
    ///   <para>rdfs:comment : The mechanism by which the valve function is achieved where: BALL: Valve that has a ported ball that can be turned relative to the body seat ports. BUTTERFLY: Valve in which a streamlined disc pivots about a diametric axis. CONFIGUREDGATE: Screwdown valve in which the closing gate is shaped in a configured manner to have a more precise control of pressure and flow change across the valve. GLAND: Valve with a tapered seating, in which a rotatable plug is retained by means of a gland and gland packing. GLOBE: Screwdown valve that has a spherical body. LUBRICATEDPLUG: Plug valve in which a lubricant is injected under pressure between the plug face and the body. NEEDLE: Valve for regulating the flow in or from a pipe, in which a slender cone moves along the axis of flow to close against a fixed conical seat. PARALLELSLIDE: Screwdown valve that has a machined plate that slides in formed grooves to form a seal. PLUG: Valve that has a ported plug that can be turned relative to the body seat ports. WEDGEGATE: Screwdown valve that has a wedge shaped plate fitting into tapered guides to form a seal.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/valveMechanism">s4bldg:valveMechanism</a>
    /// </summary>
    let valveMechanism = _prefixId.prefix "valveMechanism"
    /// <summary>
    ///   <para>rdfs:label : valve operation</para>
    ///   <para>rdfs:comment : The method of valve operation where: DROPWEIGHT: A valve that is closed by the action of a weighted lever being released, the weight normally being prevented from dropping by being held by a wire, the closure normally being made by the action of heat on a fusible link in the wire FLOAT: A valve that is opened and closed by the action of a float that rises and falls with water level. The float may be a ball attached to a lever or other mechanism HYDRAULIC: A valve that is opened and closed by hydraulic actuation LEVER: A valve that is opened and closed by the action of a lever rotating the gate within the valve. LOCKSHIELD: A valve that requires the use of a special lockshield key for opening and closing, the operating mechanism being protected by a shroud during normal operation. MOTORIZED: A valve that is opened and closed by the action of an electric motor on an actuator PNEUMATIC: A valve that is opened and closed by pneumatic actuation SOLENOID: A valve that is normally held open by a magnetic field in a coil acting on the gate but that is closed immediately if the electrical current generating the magnetic field is removed. SPRING: A valve that is normally held in position by the pressure of a spring on a plate but that may be caused to open if the pressure of the fluid is sufficient to overcome the spring pressure. THERMOSTATIC: A valve in which the ports are opened or closed to maintain a required predetermined temperature. WHEEL: A valve that is opened and closed by the action of a wheel moving the gate within the valve.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/valveOperation">s4bldg:valveOperation</a>
    /// </summary>
    let valveOperation = _prefixId.prefix "valveOperation"
    /// <summary>
    ///   <para>rdfs:label : valve pattern</para>
    ///   <para>rdfs:comment : The configuration of the ports of a valve according to either the linear route taken by a fluid flowing through the valve or by the number of ports where: SINGLEPORT: Valve that has a single entry port from the system that it serves, the exit port being to the surrounding environment. ANGLED_2_PORT: Valve in which the direction of flow is changed through 90 degrees. STRAIGHT_2_PORT: Valve in which the flow is straight through. STRAIGHT_3_PORT: Valve with three separate ports. CROSSOVER_4_PORT: Valve with 4 separate ports.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/valvePattern">s4bldg:valvePattern</a>
    /// </summary>
    let valvePattern = _prefixId.prefix "valvePattern"
    /// <summary>
    ///   <para>rdfs:label : ventilating pipe size</para>
    ///   <para>rdfs:comment : Size of the ventilating pipe(s). Usually measured in millimeters (mm).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/ventilatingPipeSize">s4bldg:ventilatingPipeSize</a>
    /// </summary>
    let ventilatingPipeSize = _prefixId.prefix "ventilatingPipeSize"
    /// <summary>
    ///   <para>rdfs:label : vertical spacing</para>
    ///   <para>rdfs:comment : Vertical spacing between tubes in the tube bundle.Usually measured in millimeters (mm).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/verticalSpacing">s4bldg:verticalSpacing</a>
    /// </summary>
    let verticalSpacing = _prefixId.prefix "verticalSpacing"
    /// <summary>
    ///   <para>rdfs:label : vibration transmissibility</para>
    ///   <para>rdfs:comment : The vibration transmissibility percentage.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/vibrationTransmissibility">s4bldg:vibrationTransmissibility</a>
    /// </summary>
    let vibrationTransmissibility = _prefixId.prefix "vibrationTransmissibility"
    /// <summary>
    ///   <para>rdfs:label : visible light reflectance</para>
    ///   <para>rdfs:comment : Fraction of the visible light that is reflected by the glazing at normal incidence. It is a value without unit.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/visibleLightReflectance">s4bldg:visibleLightReflectance</a>
    /// </summary>
    let visibleLightReflectance = _prefixId.prefix "visibleLightReflectance"
    /// <summary>
    ///   <para>rdfs:label : visible light transmittance</para>
    ///   <para>rdfs:comment : Fraction of the visible light that passes the shading system at normal incidence. It is a value without unit.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/visibleLightTransmittance">s4bldg:visibleLightTransmittance</a>
    /// </summary>
    let visibleLightTransmittance = _prefixId.prefix "visibleLightTransmittance"
    /// <summary>
    ///   <para>rdfs:label : volumen</para>
    ///   <para>rdfs:comment : Total volume of fluid in the tubes and their headers. Usually measured in cubic metre (m3).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/volumen">s4bldg:volumen</a>
    /// </summary>
    let volumen = _prefixId.prefix "volumen"
    /// <summary>
    ///   <para>rdfs:label : water flow control system type</para>
    ///   <para>rdfs:comment : Factory fitted waterflow control system.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/waterFlowControlSystemType">s4bldg:waterFlowControlSystemType</a>
    /// </summary>
    let waterFlowControlSystemType = _prefixId.prefix "waterFlowControlSystemType"
    /// <summary>
    ///   <para>rdfs:label : water inlet temperature range</para>
    ///   <para>rdfs:comment : Allowable water inlet temperature range. Usually measured in degrees Kelvin (K).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/waterInletTemperatureMax">s4bldg:waterInletTemperatureMax</a>
    /// </summary>
    let waterInletTemperatureMax = _prefixId.prefix "waterInletTemperatureMax"
    /// <summary>
    ///   <para>rdfs:label : water inlet temperature range</para>
    ///   <para>rdfs:comment : Allowable water inlet temperature range. Usually measured in degrees Kelvin (K).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/waterInletTemperatureMin">s4bldg:waterInletTemperatureMin</a>
    /// </summary>
    let waterInletTemperatureMin = _prefixId.prefix "waterInletTemperatureMin"
    /// <summary>
    ///   <para>rdfs:label : water pressure range</para>
    ///   <para>rdfs:comment : Allowable water circuit working pressure range. Usually measured in Pascals (Pa, N/m2).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/waterPressureMax">s4bldg:waterPressureMax</a>
    /// </summary>
    let waterPressureMax = _prefixId.prefix "waterPressureMax"
    /// <summary>
    ///   <para>rdfs:label : water pressure range</para>
    ///   <para>rdfs:comment : Allowable water circuit working pressure range. Usually measured in Pascals (Pa, N/m2).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/waterPressureMin">s4bldg:waterPressureMin</a>
    /// </summary>
    let waterPressureMin = _prefixId.prefix "waterPressureMin"
    /// <summary>
    ///   <para>rdfs:label : water requirement</para>
    ///   <para>rdfs:comment : Make-up water requirement. Usually measured in m3/s.</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/waterRequirement">s4bldg:waterRequirement</a>
    /// </summary>
    let waterRequirement = _prefixId.prefix "waterRequirement"
    /// <summary>
    ///   <para>rdfs:label : water storage capacity</para>
    ///   <para>rdfs:comment : Water storage capacity. Usually measured in cubic metre (m3).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/waterStorageCapacity">s4bldg:waterStorageCapacity</a>
    /// </summary>
    let waterStorageCapacity = _prefixId.prefix "waterStorageCapacity"
    /// <summary>
    ///   <para>rdfs:label : weight</para>
    ///   <para>rdfs:comment : The weight of the device. Usually measured in kilograms (kg) or grams (g).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/weight">s4bldg:weight</a>
    /// </summary>
    let weight = _prefixId.prefix "weight"
    /// <summary>
    ///   <para>rdfs:label : working pressure</para>
    ///   <para>rdfs:comment : The normally expected maximum working pressure of the valve. Usually measured in Pascals (Pa, N/m2).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/workingPressure">s4bldg:workingPressure</a>
    /// </summary>
    let workingPressure = _prefixId.prefix "workingPressure"
    /// <summary>
    ///   <para>rdfs:label : maximum working pressure</para>
    ///   <para>rdfs:comment : Maximum working pressure. Usually measured in Pascals (Pa, N/m2).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/workingPressureMax">s4bldg:workingPressureMax</a>
    /// </summary>
    let workingPressureMax = _prefixId.prefix "workingPressureMax"
    /// <summary>
    ///   <para>rdfs:label : minimum working pressure</para>
    ///   <para>rdfs:comment : Allowable minimum working pressure (relative to ambient pressure). Usually measured in Pascals (Pa, N/m2).</para>
    ///   <a href="https://saref.etsi.org/saref4bldg/workingPressureMin">s4bldg:workingPressureMin</a>
    /// </summary>
    let workingPressureMin = _prefixId.prefix "workingPressureMin"
