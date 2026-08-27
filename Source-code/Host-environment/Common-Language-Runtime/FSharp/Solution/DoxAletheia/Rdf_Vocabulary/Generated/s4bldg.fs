namespace https.saref.etsi.org.saref4bldg.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module s4bldg =
    let _namespace_iri = Namespace_Iri s4bldg |> NamespaceIRI
    /// <summary>
    ///   <para>s4bldg:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"Information about changes compared to version 1.1.1:
    ///  - Updated namespaces for compatibility with SAREF v3."</para>
    /// </remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/">https://saref.etsi.org/saref4bldg/</seealso>
    let _prefix_iri = Prefixed_Name(s4bldg, "") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:Actuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An actuator is a mechanical device for moving or controlling a mechanism or system. An actuator takes energy, usually created by air, electricity, or liquid, and converts that into some kind of motion."</para>
    /// labels<para>"Actuator"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/Actuator">https://saref.etsi.org/saref4bldg/Actuator</seealso>
    let Actuator = Prefixed_Name(s4bldg, "Actuator") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:AirToAirHeatRecovery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An air-to-air heat recovery device employs a counter-flow heat exchanger between inbound and outbound air flow. It is typically used to transfer heat from warmer air in one chamber to cooler air in the second chamber (i.e., typically used to recover heat from the conditioned air being exhausted and the outside air being supplied to a building), resulting in energy savings from reduced heating (or cooling) requirements."</para>
    /// labels<para>"Air to air heat recovery"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/AirToAirHeatRecovery">https://saref.etsi.org/saref4bldg/AirToAirHeatRecovery</seealso>
    let AirToAirHeatRecovery =
        Prefixed_Name(s4bldg, "AirToAirHeatRecovery") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:Alarm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An alarm is a device that signals the existence of a condition or situation that is outside the boundaries of normal expectation or that activates such a device.
    ///
    /// Alarms include the provision of break glass buttons and manual pull boxes that are used to activate alarms."</para>
    /// labels<para>"Alarm"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/Alarm">https://saref.etsi.org/saref4bldg/Alarm</seealso>
    let Alarm = Prefixed_Name(s4bldg, "Alarm") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:AudioVisualAppliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An audio-visual appliance is a device that displays, captures, transmits, or receives audio or video.
    ///
    /// Audio-visual appliances may be fixed in place or may be able to be moved from one space to another. They may require an electrical supply that may be supplied either by an electrical circuit or provided from a local battery source. Audio-visual appliances may be connected to data circuits including specialist circuits for audio visual purposes only."</para>
    /// labels<para>"Audio visual appliance"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/AudioVisualAppliance">https://saref.etsi.org/saref4bldg/AudioVisualAppliance</seealso>
    let AudioVisualAppliance =
        Prefixed_Name(s4bldg, "AudioVisualAppliance") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:Boiler</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A boiler is a closed, pressure-rated vessel in which water or other fluid is heated using an energy source such as natural gas, heating oil, or electricity. The fluid in the vessel is then circulated out of the boiler for use in various processes or heating applications."</para>
    /// labels<para>"Boiler"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/Boiler">https://saref.etsi.org/saref4bldg/Boiler</seealso>
    let Boiler = Prefixed_Name(s4bldg, "Boiler") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:Building</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A building represents a structure that provides shelter for its occupants or contents and stands in one place. The building is also used to provide a basic element within the spatial structure hierarchy for the components of a building project (together with site, storey, and space)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A building represents a structure that provides shelter for its occupants or contents and stands in one place. The building is also used to provide a basic element within the spatial structure hierarchy for the components of a building project (together with site, storey, and space)."</para>
    /// labels<para>"Building"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/Building">https://saref.etsi.org/saref4bldg/Building</seealso>
    let Building = Prefixed_Name(s4bldg, "Building") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:BuildingDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A tangible object designed to accomplish a particular task in a building."</para>
    /// labels<para>"Building device"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/BuildingDevice">https://saref.etsi.org/saref4bldg/BuildingDevice</seealso>
    let BuildingDevice = Prefixed_Name(s4bldg, "BuildingDevice") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:BuildingObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An object in the building that can be controlled by devices, such as a door or a window that can be automatically opened or closed by an actuator.  (Definition taken from SAREF 1.0)"</para>
    /// labels<para>"Building object"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/BuildingObject">https://saref.etsi.org/saref4bldg/BuildingObject</seealso>
    let BuildingObject = Prefixed_Name(s4bldg, "BuildingObject") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:BuildingSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An entity used to define the physical spaces of the building. A building space contains devices or building objects."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"An entity used to define the physical spaces of the building. A building space contains devices or building objects."</para>
    /// labels<para>"Building space"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/BuildingSpace">https://saref.etsi.org/saref4bldg/BuildingSpace</seealso>
    let BuildingSpace = Prefixed_Name(s4bldg, "BuildingSpace") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:Burner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A burner is a device that converts fuel into heat through combustion. It includes gas, oil, and wood burners."</para>
    /// labels<para>"Burner"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/Burner">https://saref.etsi.org/saref4bldg/Burner</seealso>
    let Burner = Prefixed_Name(s4bldg, "Burner") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:Chiller</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A chiller is a device used to remove heat from a liquid via a vapor-compression or absorption refrigeration cycle to cool a fluid, typically water or a mixture of water and glycol. The chilled fluid is then used to cool and dehumidify air in a building."</para>
    /// labels<para>"Chiller"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/Chiller">https://saref.etsi.org/saref4bldg/Chiller</seealso>
    let Chiller = Prefixed_Name(s4bldg, "Chiller") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:Coil</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A coil is a device used to provide heat transfer between non-mixing media. A common example is a cooling coil, which utilizes a finned coil in which circulates chilled water, antifreeze, or refrigerant that is used to remove heat from air moving across the surface of the coil. A coil may be used either for heating or cooling purposes by placing a series of tubes (the coil) carrying a heating or cooling fluid into an airstream. The coil may be constructed from tubes bundled in a serpentine form or from finned tubes that give a extended heat transfer surface.
    ///
    /// Coils may also be used for non-airflow cases such as embedded in a floor slab."</para>
    /// labels<para>"Coil"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/Coil">https://saref.etsi.org/saref4bldg/Coil</seealso>
    let Coil = Prefixed_Name(s4bldg, "Coil") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:CommunicationAppliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A communications appliance transmits and receives electronic or digital information as data or sound.
    ///
    /// Communication appliances may be fixed in place or may be able to be moved from one space to another. Communication appliances require an electrical supply that may be supplied either by an electrical circuit or provided from a local battery source."</para>
    /// labels<para>"Communication appliance"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/CommunicationAppliance">https://saref.etsi.org/saref4bldg/CommunicationAppliance</seealso>
    let CommunicationAppliance =
        Prefixed_Name(s4bldg, "CommunicationAppliance") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:Compressor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A compressor is a device that compresses a fluid typically used in a refrigeration circuit."</para>
    /// labels<para>"Compressor"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/Compressor">https://saref.etsi.org/saref4bldg/Compressor</seealso>
    let Compressor = Prefixed_Name(s4bldg, "Compressor") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:Condenser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A condenser is a device that is used to dissipate heat, typically by condensing a substance such as a refrigerant from its gaseous to its liquid state."</para>
    /// labels<para>"Condenser"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/Condenser">https://saref.etsi.org/saref4bldg/Condenser</seealso>
    let Condenser = Prefixed_Name(s4bldg, "Condenser") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:Controller</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A controller is a device that monitors inputs and controls outputs within a building automation system.
    ///
    /// A controller may be physical (having placement within a spatial structure) or logical (a software interface or aggregated within a programmable physical controller)."</para>
    /// labels<para>"Controller"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/Controller">https://saref.etsi.org/saref4bldg/Controller</seealso>
    let Controller = Prefixed_Name(s4bldg, "Controller") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:CooledBeam</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A cooled beam (or chilled beam) is a device typically used to cool air by circulating a fluid such as chilled water through exposed finned tubes above a space. Typically mounted overhead near or within a ceiling, the cooled beam uses convection to cool the space below it by acting as a heat sink for the naturally rising warm air of the space. Once cooled, the air naturally drops back to the floor where the cycle begins again."</para>
    /// labels<para>"Cooled beam"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/CooledBeam">https://saref.etsi.org/saref4bldg/CooledBeam</seealso>
    let CooledBeam = Prefixed_Name(s4bldg, "CooledBeam") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:CoolingTower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A cooling tower is a device which rejects heat to ambient air by circulating a fluid such as water through it to reduce its temperature by partial evaporation."</para>
    /// labels<para>"Cooling tower"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/CoolingTower">https://saref.etsi.org/saref4bldg/CoolingTower</seealso>
    let CoolingTower = Prefixed_Name(s4bldg, "CoolingTower") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:Damper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A damper typically participates in an HVAC duct distribution system and is used to control or modulate the flow of air."</para>
    /// labels<para>"Damper"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/Damper">https://saref.etsi.org/saref4bldg/Damper</seealso>
    let Damper = Prefixed_Name(s4bldg, "Damper") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:DistributionControlDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents devices of a building automation control system that are used to impart control over elements of a distribution system. (Definition adapated from http://www.buildingsmart-tech.org/ifc/IFC4/Add1/html/schema/ifcsharedbldgserviceelements/lexical/ifcdistributioncontrolelement.htm)"</para>
    /// labels<para>"Distribution control device"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/DistributionControlDevice">https://saref.etsi.org/saref4bldg/DistributionControlDevice</seealso>
    let DistributionControlDevice =
        Prefixed_Name(s4bldg, "DistributionControlDevice") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:DistributionDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Generalization of all devices that participate in a distribution system. (Definition adapated from http://www.buildingsmart-tech.org/ifc/IFC4/Add1/html/schema/ifcproductextension/lexical/ifcdistributionelement.htm)"</para>
    /// labels<para>"Distribution device"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/DistributionDevice">https://saref.etsi.org/saref4bldg/DistributionDevice</seealso>
    let DistributionDevice = Prefixed_Name(s4bldg, "DistributionDevice") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:DistributionFlowDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents devices of a distribution system that facilitate the distribution of energy or matter, such as air, water or power. (Definition adapated from http://www.buildingsmart-tech.org/ifc/IFC4/Add1/html/schema/ifcsharedbldgserviceelements/lexical/ifcdistributionflowelement.htm)"</para>
    /// labels<para>"DistributionFlowDevice"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/DistributionFlowDevice">https://saref.etsi.org/saref4bldg/DistributionFlowDevice</seealso>
    let DistributionFlowDevice =
        Prefixed_Name(s4bldg, "DistributionFlowDevice") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:DuctSilencer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A duct silencer is a device that is typically installed inside a duct distribution system for the purpose of reducing the noise levels from air movement, fan noise, etc. in the adjacent space or downstream of the duct silencer device."</para>
    /// labels<para>"Duct silencer"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/DuctSilencer">https://saref.etsi.org/saref4bldg/DuctSilencer</seealso>
    let DuctSilencer = Prefixed_Name(s4bldg, "DuctSilencer") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:ElectricAppliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An electric appliance is a device intended for consumer usage that is powered by electricity.
    ///
    /// Electric appliances may be fixed in place or may be able to be moved from one space to another. Electric appliances require an electrical supply that may be supplied either by an electrical circuit or provided from a local battery source."</para>
    /// labels<para>"Electric appliance"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/ElectricAppliance">https://saref.etsi.org/saref4bldg/ElectricAppliance</seealso>
    let ElectricAppliance = Prefixed_Name(s4bldg, "ElectricAppliance") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:ElectricFlowStorageDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An electric flow storage device is a device in which electrical energy is stored and from which energy may be progressively released."</para>
    /// labels<para>"Electric flow storage device"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/ElectricFlowStorageDevice">https://saref.etsi.org/saref4bldg/ElectricFlowStorageDevice</seealso>
    let ElectricFlowStorageDevice =
        Prefixed_Name(s4bldg, "ElectricFlowStorageDevice") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:ElectricGenerator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An electric generator is an engine that is a machine for converting mechanical energy into electrical energy."</para>
    /// labels<para>"Electric generator"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/ElectricGenerator">https://saref.etsi.org/saref4bldg/ElectricGenerator</seealso>
    let ElectricGenerator = Prefixed_Name(s4bldg, "ElectricGenerator") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:ElectricMotor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An electric motor is an engine that is a machine for converting electrical energy into mechanical energy."</para>
    /// labels<para>"Electric motor"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/ElectricMotor">https://saref.etsi.org/saref4bldg/ElectricMotor</seealso>
    let ElectricMotor = Prefixed_Name(s4bldg, "ElectricMotor") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:ElectricTimeControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An electric time control is a device that applies control to the provision or flow of electrical energy over time."</para>
    /// labels<para>"Electric time control"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/ElectricTimeControl">https://saref.etsi.org/saref4bldg/ElectricTimeControl</seealso>
    let ElectricTimeControl =
        Prefixed_Name(s4bldg, "ElectricTimeControl") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:EnergyConversionDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The distribution flow element EnergyConversionDevice defines the occurrence of a device used to perform energy conversion or heat transfer and typically participates in a flow distribution system."</para>
    /// labels<para>"Energy conversion device"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/EnergyConversionDevice">https://saref.etsi.org/saref4bldg/EnergyConversionDevice</seealso>
    let EnergyConversionDevice =
        Prefixed_Name(s4bldg, "EnergyConversionDevice") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:Engine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An engine is a device that converts fuel into mechanical energy through combustion."</para>
    /// labels<para>"Engine"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/Engine">https://saref.etsi.org/saref4bldg/Engine</seealso>
    let Engine = Prefixed_Name(s4bldg, "Engine") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:EvaporativeCooler</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An evaporative cooler is a device that cools air by saturating it with water vapor."</para>
    /// labels<para>"Evaporative cooler"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/EvaporativeCooler">https://saref.etsi.org/saref4bldg/EvaporativeCooler</seealso>
    let EvaporativeCooler = Prefixed_Name(s4bldg, "EvaporativeCooler") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:Evaporator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An evaporator is a device in which a liquid refrigerent is vaporized and absorbs heat from the surrounding fluid."</para>
    /// labels<para>"Evaporator"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/Evaporator">https://saref.etsi.org/saref4bldg/Evaporator</seealso>
    let Evaporator = Prefixed_Name(s4bldg, "Evaporator") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:Fan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A fan is a device which imparts mechanical work on a gas. A typical usage of a fan is to induce airflow in a building services air distribution system."</para>
    /// labels<para>"Fan"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/Fan">https://saref.etsi.org/saref4bldg/Fan</seealso>
    let Fan = Prefixed_Name(s4bldg, "Fan") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:Filter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A filter is an apparatus used to remove particulate or gaseous matter from fluids and gases."</para>
    /// labels<para>"Filter"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/Filter">https://saref.etsi.org/saref4bldg/Filter</seealso>
    let Filter = Prefixed_Name(s4bldg, "Filter") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:FireSuppressionTerminal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A fire suppression terminal has the purpose of delivering a fluid (gas or liquid) that will suppress a fire.
    ///
    /// A fire suppression terminal provides for all forms of sprinkler, spreader and other form of terminal that is connected to a pipework system and intended to act in the role of suppressing a fire."</para>
    /// labels<para>"Fire suppression terminal"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/FireSuppressionTerminal">https://saref.etsi.org/saref4bldg/FireSuppressionTerminal</seealso>
    let FireSuppressionTerminal =
        Prefixed_Name(s4bldg, "FireSuppressionTerminal") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:FlowController</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The distribution flow element FlowController defines the occurrence of elements of a distribution system that are used to regulate flow through a distribution system. Examples include dampers, valves, switches, and relays."</para>
    /// labels<para>"Flow controller"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/FlowController">https://saref.etsi.org/saref4bldg/FlowController</seealso>
    let FlowController = Prefixed_Name(s4bldg, "FlowController") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:FlowInstrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A flow instrument reads and displays the value of a particular property of a system at a point, or displays the difference in the value of a property between two points.
    ///
    /// Instrumentation is typically for the purpose of determining the value of the property at a point in time. It is not the purpose of an instrument to record or integrate the values over time (although they may be connected to recording devices that do perform such a function). This entity provides for all forms of mechanical flow instrument (thermometers, pressure gauges etc.) and electrical flow instruments (ammeters, voltmeters etc.)"</para>
    /// labels<para>"Flow instrument"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/FlowInstrument">https://saref.etsi.org/saref4bldg/FlowInstrument</seealso>
    let FlowInstrument = Prefixed_Name(s4bldg, "FlowInstrument") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:FlowMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A flow meter is a device that is used to measure the flow rate in a system."</para>
    /// labels<para>"Flow meter"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/FlowMeter">https://saref.etsi.org/saref4bldg/FlowMeter</seealso>
    let FlowMeter = Prefixed_Name(s4bldg, "FlowMeter") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:FlowMovingDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The distribution flow element FlowMovingDevice defines the occurrence of an apparatus used to distribute, circulate or perform conveyance of fluids, including liquids and gases (such as a pump or fan), and typically participates in a flow distribution system."</para>
    /// labels<para>"Flow moving device"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/FlowMovingDevice">https://saref.etsi.org/saref4bldg/FlowMovingDevice</seealso>
    let FlowMovingDevice = Prefixed_Name(s4bldg, "FlowMovingDevice") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:FlowStorageDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The distribution flow element FlowStorageDevice defines the occurrence of a device that participates in a distribution system and is used for temporary storage (such as a tank)."</para>
    /// labels<para>"Flow storage device"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/FlowStorageDevice">https://saref.etsi.org/saref4bldg/FlowStorageDevice</seealso>
    let FlowStorageDevice = Prefixed_Name(s4bldg, "FlowStorageDevice") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:FlowTerminal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The distribution flow element FlowTerminal defines the occurrence of a permanently attached element that acts as a terminus or beginning of a distribution system (such as an air outlet, drain, water closet, or sink). A terminal is typically a point at which a system interfaces with an external environment."</para>
    /// labels<para>"Flow terminal"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/FlowTerminal">https://saref.etsi.org/saref4bldg/FlowTerminal</seealso>
    let FlowTerminal = Prefixed_Name(s4bldg, "FlowTerminal") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:FlowTreatmentDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The distribution flow element FlowTreatmentDevice defines the occurrence of a device typically used to remove unwanted matter from a fluid, either liquid or gas, and typically participates in a flow distribution system."</para>
    /// labels<para>"Flow treatment device"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/FlowTreatmentDevice">https://saref.etsi.org/saref4bldg/FlowTreatmentDevice</seealso>
    let FlowTreatmentDevice =
        Prefixed_Name(s4bldg, "FlowTreatmentDevice") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:HeatExchanger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A heat exchanger is a device used to provide heat transfer between non-mixing media such as plate and shell and tube heat exchangers. HeatExchanger is commonly used on water-side distribution systems to recover energy from a liquid to another liquid (typically water-based), whereas AirToAirHeatRecovery is commonly used on air-side distribution systems to recover energy from a gas to a gas (usually air)."</para>
    /// labels<para>"Heat exchanger"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/HeatExchanger">https://saref.etsi.org/saref4bldg/HeatExchanger</seealso>
    let HeatExchanger = Prefixed_Name(s4bldg, "HeatExchanger") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:Humidifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A humidifier is a device that adds moisture into the air."</para>
    /// labels<para>"Humidifier"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/Humidifier">https://saref.etsi.org/saref4bldg/Humidifier</seealso>
    let Humidifier = Prefixed_Name(s4bldg, "Humidifier") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:Interceptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An interceptor is a device designed and installed in order to separate and retain deleterious, hazardous or undesirable matter while permitting normal sewage or liquids to discharge into a collection system by gravity."</para>
    /// labels<para>"Interceptor"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/Interceptor">https://saref.etsi.org/saref4bldg/Interceptor</seealso>
    let Interceptor = Prefixed_Name(s4bldg, "Interceptor") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:Lamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A lamp is an artificial light source such as a light bulb or tube."</para>
    /// labels<para>"Lamp"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/Lamp">https://saref.etsi.org/saref4bldg/Lamp</seealso>
    let Lamp = Prefixed_Name(s4bldg, "Lamp") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:MedicalDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A medical device is attached to a medical piping system and operates upon medical gases to perform a specific function. Medical gases include medical air, medical vacuum, oxygen, carbon dioxide, nitrogen, and nitrous oxide."</para>
    /// labels<para>"Medical device"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/MedicalDevice">https://saref.etsi.org/saref4bldg/MedicalDevice</seealso>
    let MedicalDevice = Prefixed_Name(s4bldg, "MedicalDevice") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:Outlet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An outlet is a device installed at a point to receive one or more inserted plugs for electrical power or communications.
    ///
    /// Power outlets are commonly connected within a junction box; data outlets may be directly connected to a wall. For power outlets sharing the same circuit within a junction box, the ports should indicate the logical wiring relationship to the enclosing junction box, even though they may be physically connected to a cable going to another outlet, switch, or fixture."</para>
    /// labels<para>"Outlet"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/Outlet">https://saref.etsi.org/saref4bldg/Outlet</seealso>
    let Outlet = Prefixed_Name(s4bldg, "Outlet") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:PhysicalObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Object that has a proper space region.  (Definition extracted from DUL ontology)"</para>
    ///   <para>"Any Object that has a proper space region.  (Definition extracted from DUL ontology)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Physical object"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/PhysicalObject">https://saref.etsi.org/saref4bldg/PhysicalObject</seealso>
    let PhysicalObject = Prefixed_Name(s4bldg, "PhysicalObject") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:ProtectiveDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A protective device breaks an electrical circuit when a stated electric current that passes through it is exceeded.
    ///
    /// A protective device provides protection against electrical current only (not as a general protective device). It may be used to represent the complete set of elements including both the tripping unit and the breaking unit that provide the protection. This may be particularly useful at earlier stages of design where the approach to breaking the electrical supply may be determined but the method of tripping may not. Alternatively, this entity may be used to specifically represent the breaking unit alone (in which case the tripping unit will also be specifically identified). This entity is specific to dedicated protective devices and excludes electrical outlets that may have circuit protection."</para>
    /// labels<para>"Protective device"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/ProtectiveDevice">https://saref.etsi.org/saref4bldg/ProtectiveDevice</seealso>
    let ProtectiveDevice = Prefixed_Name(s4bldg, "ProtectiveDevice") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:ProtectiveDeviceTrippingUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A protective device tripping unit breaks an electrical circuit at a separate breaking unit when a stated electric current that passes through the unit is exceeded."</para>
    /// labels<para>"Protective device tripping unit"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/ProtectiveDeviceTrippingUnit">https://saref.etsi.org/saref4bldg/ProtectiveDeviceTrippingUnit</seealso>
    let ProtectiveDeviceTrippingUnit =
        Prefixed_Name(s4bldg, "ProtectiveDeviceTrippingUnit") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:Pump</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A pump is a device which imparts mechanical work on fluids or slurries to move them through a channel or pipeline. A typical use of a pump is to circulate chilled water or heating hot water in a building services distribution system."</para>
    /// labels<para>"Pump"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/Pump">https://saref.etsi.org/saref4bldg/Pump</seealso>
    let Pump = Prefixed_Name(s4bldg, "Pump") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:SanitaryTerminal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sanitary terminal is a fixed appliance or terminal usually supplied with water and used for drinking, cleaning or foul water disposal or that is an item of equipment directly used with such an appliance or terminal."</para>
    /// labels<para>"Sanitary terminal"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/SanitaryTerminal">https://saref.etsi.org/saref4bldg/SanitaryTerminal</seealso>
    let SanitaryTerminal = Prefixed_Name(s4bldg, "SanitaryTerminal") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sensor is a device that measures a physical quantity and converts it into a signal which can be read by an observer or by an instrument."</para>
    /// labels<para>"Sensor"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/Sensor">https://saref.etsi.org/saref4bldg/Sensor</seealso>
    let Sensor = Prefixed_Name(s4bldg, "Sensor") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:ShadingDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Shading devices are purpose built devices to protect from the sunlight, from natural light, or screening them from view. Shading devices can form part of the facade or can be mounted inside the building, they can be fixed or operable."</para>
    /// labels<para>"Shading device"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/ShadingDevice">https://saref.etsi.org/saref4bldg/ShadingDevice</seealso>
    let ShadingDevice = Prefixed_Name(s4bldg, "ShadingDevice") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:SolarDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A solar device converts solar radiation into other energy such as electric current or thermal energy."</para>
    /// labels<para>"Solar device"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/SolarDevice">https://saref.etsi.org/saref4bldg/SolarDevice</seealso>
    let SolarDevice = Prefixed_Name(s4bldg, "SolarDevice") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:SpaceHeater</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Space heaters utilize a combination of radiation and/or natural convection using a heating source such as electricity, steam or hot water to heat a limited space or area. Examples of space heaters include radiators, convectors, baseboard and finned-tube heaters.
    ///
    /// UnitaryEquipment should be used for packaged units supporting a combination of heating, cooling, and/or dehumidification; Coil should be used for coil-based floor heating."</para>
    /// labels<para>"Space heater"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/SpaceHeater">https://saref.etsi.org/saref4bldg/SpaceHeater</seealso>
    let SpaceHeater = Prefixed_Name(s4bldg, "SpaceHeater") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:SwitchingDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A switch is used in a cable distribution system (electrical circuit) to control or modulate the flow of electricity.
    ///
    /// Switches include those used for electrical power, communications, audio-visual, or other distribution system types as determined by the available ports."</para>
    /// labels<para>"Switching device"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/SwitchingDevice">https://saref.etsi.org/saref4bldg/SwitchingDevice</seealso>
    let SwitchingDevice = Prefixed_Name(s4bldg, "SwitchingDevice") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:Tank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A tank is a vessel or container in which a fluid or gas is stored for later use."</para>
    /// labels<para>"Tank"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/Tank">https://saref.etsi.org/saref4bldg/Tank</seealso>
    let Tank = Prefixed_Name(s4bldg, "Tank") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:Transformer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A transformer is an inductive stationary device that transfers electrical energy from one circuit to another.
    ///
    /// Transformer is used to transform electric power; conversion of electric signals for other purposes is handled at other entities: Controller converts arbitrary signals, AudioVisualAppliance converts signals for audio or video streams, and CommunicationsAppliance converts signals for data or other communications usage."</para>
    /// labels<para>"Transformer"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/Transformer">https://saref.etsi.org/saref4bldg/Transformer</seealso>
    let Transformer = Prefixed_Name(s4bldg, "Transformer") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:TransportElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A transport element is a generalization of all transport related objects that move people, animals or goods within a building or building complex. The TransportElement defines the occurrence of a transport element. "</para>
    /// labels<para>"Transport element"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/TransportElement">https://saref.etsi.org/saref4bldg/TransportElement</seealso>
    let TransportElement = Prefixed_Name(s4bldg, "TransportElement") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:TubeBundle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A tube bundle is a device consisting of tubes and bundles of tubes used for heat transfer and contained typically within other energy conversion devices, such as a chiller or coil."</para>
    /// labels<para>"Tube bundle"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/TubeBundle">https://saref.etsi.org/saref4bldg/TubeBundle</seealso>
    let TubeBundle = Prefixed_Name(s4bldg, "TubeBundle") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:UnitaryControlElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A unitary control element combines a number of control components into a single product, such as a thermostat or humidistat.
    ///
    /// A unitary control element provides a housing for an aggregation of control or electrical distribution elements that, in combination, perform a singular (unitary) purpose. Each item in the aggregation may have its own geometric representation and location."</para>
    /// labels<para>"Unitary control element"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/UnitaryControlElement">https://saref.etsi.org/saref4bldg/UnitaryControlElement</seealso>
    let UnitaryControlElement =
        Prefixed_Name(s4bldg, "UnitaryControlElement") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:Valve</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A valve is used in a building services piping distribution system to control or modulate the flow of the fluid."</para>
    /// labels<para>"Valve"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/Valve">https://saref.etsi.org/saref4bldg/Valve</seealso>
    let Valve = Prefixed_Name(s4bldg, "Valve") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:VibrationIsolator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A vibration isolator is a device used to minimize the effects of vibration transmissibility in a building."</para>
    /// labels<para>"Vibration isolator"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/VibrationIsolator">https://saref.etsi.org/saref4bldg/VibrationIsolator</seealso>
    let VibrationIsolator = Prefixed_Name(s4bldg, "VibrationIsolator") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:accessType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Defines the types of access (or cover) to a tank that may be specified. Note that covers are generally specified for rectangular tanks. For cylindrical tanks, access will normally be via a manhole."</para>
    /// labels<para>"access type"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/accessType">https://saref.etsi.org/saref4bldg/accessType</seealso>
    let accessType = Prefixed_Name(s4bldg, "accessType") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:airFlowRateMax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Maximum allowable air flow rate. Usually measured in m3/s."</para>
    /// labels<para>"air flow rate range max"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/airFlowRateMax">https://saref.etsi.org/saref4bldg/airFlowRateMax</seealso>
    let airFlowRateMax = Prefixed_Name(s4bldg, "airFlowRateMax") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:airFlowRateMin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Minimum allowable air flow rate. Usually measured in m3/s."</para>
    /// labels<para>"air flow rate range min"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/airFlowRateMin">https://saref.etsi.org/saref4bldg/airFlowRateMin</seealso>
    let airFlowRateMin = Prefixed_Name(s4bldg, "airFlowRateMin") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:ambientDesignDryBulbTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Ambient design dry bulb temperature used for selecting the cooling tower. Usually measured in degrees Kelvin (K)."</para>
    /// labels<para>"ambient design dry bulb temperature"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/ambientDesignDryBulbTemperature">https://saref.etsi.org/saref4bldg/ambientDesignDryBulbTemperature</seealso>
    let ambientDesignDryBulbTemperature =
        Prefixed_Name(s4bldg, "ambientDesignDryBulbTemperature") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:ambientDesignWetBulbTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Ambient design wet bulb temperature used for selecting the cooling tower. Usually measured in degrees Kelvin (K)."</para>
    /// labels<para>"ambient design wet bulb temperature"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/ambientDesignWetBulbTemperature">https://saref.etsi.org/saref4bldg/ambientDesignWetBulbTemperature</seealso>
    let ambientDesignWetBulbTemperature =
        Prefixed_Name(s4bldg, "ambientDesignWetBulbTemperature") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:apparentPowerMax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Maximum apparent power/capacity in VA (volt ampere). Usually measured in Watts (W, J/s)."</para>
    /// labels<para>"maximum apparent power"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/apparentPowerMax">https://saref.etsi.org/saref4bldg/apparentPowerMax</seealso>
    let apparentPowerMax = Prefixed_Name(s4bldg, "apparentPowerMax") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:application</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Humidifier application. Fixed: Humidifier installed in a ducted flow distribution system. Portable: Humidifier is not installed in a ducted flow distribution system."</para>
    /// labels<para>"application"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/application">https://saref.etsi.org/saref4bldg/application</seealso>
    let application = Prefixed_Name(s4bldg, "application") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:arrangement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Defines the basic flow arrangements for the heat exchanger: COUNTERFLOW: Counterflow heat exchanger arrangement. CROSSFLOW: Crossflow heat exchanger arrangement. PARALLELFLOW: Parallel flow heat exchanger arrangement. MULTIPASS: Multipass flow heat exchanger arrangement. OTHER: Other type of heat exchanger flow arrangement not defined above."</para>
    /// labels<para>"arrangement"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/arrangement">https://saref.etsi.org/saref4bldg/arrangement</seealso>
    let arrangement = Prefixed_Name(s4bldg, "arrangement") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:audioVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates discrete audio volume levels and corresponding sound power offsets, if applicable. Missing values may be interpolated. Measured in watts."</para>
    /// labels<para>"audio volume"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/audioVolume">https://saref.etsi.org/saref4bldg/audioVolume</seealso>
    let audioVolume = Prefixed_Name(s4bldg, "audioVolume") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:basinReserveVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Volume between operating and overflow levels in cooling tower basin. Usually measured in cubic metre (m3)."</para>
    /// labels<para>"basin reserve volume"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/basinReserveVolume">https://saref.etsi.org/saref4bldg/basinReserveVolume</seealso>
    let basinReserveVolume = Prefixed_Name(s4bldg, "basinReserveVolume") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:bladeAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Blade action."</para>
    /// labels<para>"blade action"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/bladeAction">https://saref.etsi.org/saref4bldg/bladeAction</seealso>
    let bladeAction = Prefixed_Name(s4bldg, "bladeAction") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:bladeEdge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Blade edge."</para>
    /// labels<para>"blade edge"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/bladeEdge">https://saref.etsi.org/saref4bldg/bladeEdge</seealso>
    let bladeEdge = Prefixed_Name(s4bldg, "bladeEdge") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:bladeShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Blade shape. Flat means triple V-groove."</para>
    /// labels<para>"blade shape"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/bladeShape">https://saref.etsi.org/saref4bldg/bladeShape</seealso>
    let bladeShape = Prefixed_Name(s4bldg, "bladeShape") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:bladeThickness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The thickness of the damper blade. Usually measured in millimeters (mm)."</para>
    /// labels<para>"blade thickness"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/bladeThickness">https://saref.etsi.org/saref4bldg/bladeThickness</seealso>
    let bladeThickness = Prefixed_Name(s4bldg, "bladeThickness") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:bodyMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Overall body mass of the heater. Usually measured in kilograms (kg) or grams (g)."</para>
    /// labels<para>"body mass"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/bodyMass">https://saref.etsi.org/saref4bldg/bodyMass</seealso>
    let bodyMass = Prefixed_Name(s4bldg, "bodyMass") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:capacityControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"FanCycling: Fan is cycled on and off to control duty. TwoSpeedFan: Fan is switched between low and high speed to control duty. VariableSpeedFan: Fan speed is varied to control duty. DampersControl: Dampers modulate the air flow to control duty. BypassValveControl: Bypass valve modulates the water flow to control duty. MultipleSeriesPumps: Turn on/off multiple series pump to control duty. TwoSpeedPump: Switch between high/low pump speed to control duty. VariableSpeedPump: vary pump speed to control duty."</para>
    /// labels<para>"capacity control"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/capacityControl">https://saref.etsi.org/saref4bldg/capacityControl</seealso>
    let capacityControl = Prefixed_Name(s4bldg, "capacityControl") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:capacityControlType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"InletVane: Control by adjusting inlet vane. VariableSpeedDrive: Control by variable speed drive. BladePitchAngle: Control by adjusting blade pitch angle. TwoSpeed: Control by switch between high and low speed. DischargeDamper: Control by modulating discharge damper."</para>
    /// labels<para>"capacity control type"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/capacityControlType">https://saref.etsi.org/saref4bldg/capacityControlType</seealso>
    let capacityControlType =
        Prefixed_Name(s4bldg, "capacityControlType") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:capacityPeople</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Capacity of the transportation element measured in numbers of person."</para>
    /// labels<para>"capacity people"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/capacityPeople">https://saref.etsi.org/saref4bldg/capacityPeople</seealso>
    let capacityPeople = Prefixed_Name(s4bldg, "capacityPeople") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:capacityWeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Capacity of the transport element measured by weight. Usually measured in kilograms (kg) or grams (g)."</para>
    /// labels<para>"capacity weight"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/capacityWeight">https://saref.etsi.org/saref4bldg/capacityWeight</seealso>
    let capacityWeight = Prefixed_Name(s4bldg, "capacityWeight") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:circuitType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"OpenCircuit: Exposes water directly to the cooling atmosphere. CloseCircuit: The fluid is separated from the atmosphere by a heat exchanger. Wet: The air stream or the heat exchange surface is evaporatively cooled. Dry: No evaporation into the air stream. DryWet: A combination of a dry tower and a wet tower."</para>
    /// labels<para>"circuit type"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/circuitType">https://saref.etsi.org/saref4bldg/circuitType</seealso>
    let circuitType = Prefixed_Name(s4bldg, "circuitType") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:closeOffRating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Close off rating. Usually measured in Pascals (Pa, N/m2)."</para>
    /// labels<para>"close off rating"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/closeOffRating">https://saref.etsi.org/saref4bldg/closeOffRating</seealso>
    let closeOffRating = Prefixed_Name(s4bldg, "closeOffRating") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:coilLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Length of coil. Usually measured in millimeters (mm)."</para>
    /// labels<para>"coil length"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/coilLength">https://saref.etsi.org/saref4bldg/coilLength</seealso>
    let coilLength = Prefixed_Name(s4bldg, "coilLength") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:coilWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Width of coil. Usually measured in millimeters (mm"</para>
    /// labels<para>"coil width"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/coilWidth">https://saref.etsi.org/saref4bldg/coilWidth</seealso>
    let coilWidth = Prefixed_Name(s4bldg, "coilWidth") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:colorAppearance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"In both the DIN and CIE standards, artificial light sources are classified in terms of their color appearance. To the human eye they all appear to be white the difference can only be detected by direct comparison. Visual performance is not directly affected by differences in color appearance."</para>
    /// labels<para>"color appearance"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/colorAppearance">https://saref.etsi.org/saref4bldg/colorAppearance</seealso>
    let colorAppearance = Prefixed_Name(s4bldg, "colorAppearance") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:colorRenderingIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The CRI indicates how well a light source renders eight standard colors compared to perfect reference lamp with the same color temperature. The CRI scale ranges from 1 to 100, with 100 representing perfect rendering properties."</para>
    /// labels<para>"color rendering index"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/colorRenderingIndex">https://saref.etsi.org/saref4bldg/colorRenderingIndex</seealso>
    let colorRenderingIndex =
        Prefixed_Name(s4bldg, "colorRenderingIndex") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:colorTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The color temperature of any source of radiation is defined as the temperature (in Kelvin) of a black-body or Planckian radiator whose radiation has the same chromaticity as the source of radiation. Often the values are only approximate color temperatures as the black-body radiator cannot emit radiation of every chromaticity value. The color temperatures of the commonest artificial light sources range from less than 3000K (warm white) to 4000K (intermediate) and over 5000K (daylight). Usually measured in degrees Kelvin (K)."</para>
    /// labels<para>"color temperature"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/colorTemperature">https://saref.etsi.org/saref4bldg/colorTemperature</seealso>
    let colorTemperature = Prefixed_Name(s4bldg, "colorTemperature") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:compressorSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Compressor speed. Usually measured in cycles/s."</para>
    /// labels<para>"compressor speed"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/compressorSpeed">https://saref.etsi.org/saref4bldg/compressorSpeed</seealso>
    let compressorSpeed = Prefixed_Name(s4bldg, "compressorSpeed") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:connectionSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The connection size of the to and from the pump. Usually measured in millimeters (mm)."</para>
    /// labels<para>"connection size"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/connectionSize">https://saref.etsi.org/saref4bldg/connectionSize</seealso>
    let connectionSize = Prefixed_Name(s4bldg, "connectionSize") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between a physical space and the objects located in such space."</para>
    /// labels<para>"contains"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/contains">https://saref.etsi.org/saref4bldg/contains</seealso>
    let contains = Prefixed_Name(s4bldg, "contains") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:contributedLuminousFlux</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Luminous flux is a photometric measure of radiant flux, i.e. the volume of light emitted from a light source. Luminous flux is measured either for the interior as a whole or for a part of the interior (partial luminous flux for a solid angle). All other photometric parameters are derivatives of luminous flux. Luminous flux is measured in lumens (lm). The luminous flux is given as a nominal value for each lamp. Usually measured in Lumen (lm, Candela Steradian)."</para>
    /// labels<para>"contributed luminous flux"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/contributedLuminousFlux">https://saref.etsi.org/saref4bldg/contributedLuminousFlux</seealso>
    let contributedLuminousFlux =
        Prefixed_Name(s4bldg, "contributedLuminousFlux") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:controlStrategy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"FixedExitingWaterTemp: The capacity is controlled to maintain a fixed exiting water temperature. WetBulbTempReset: The set-point is reset based on the wet-bulb temperature."</para>
    /// labels<para>"control strategy"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/controlStrategy">https://saref.etsi.org/saref4bldg/controlStrategy</seealso>
    let controlStrategy = Prefixed_Name(s4bldg, "controlStrategy") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:coverLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The length measured along the x-axis in the local coordinate system or the radius (in the case of a circular shape in plan) of the cover of the oil interceptor. Usually measured in millimeters (mm)."</para>
    /// labels<para>"cover length"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/coverLength">https://saref.etsi.org/saref4bldg/coverLength</seealso>
    let coverLength = Prefixed_Name(s4bldg, "coverLength") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:coverWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The length measured along the x-axis in the local coordinate system of the cover of the oil interceptor. Usually measured in millimeters (mm)."</para>
    /// labels<para>"cover width"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/coverWidth">https://saref.etsi.org/saref4bldg/coverWidth</seealso>
    let coverWidth = Prefixed_Name(s4bldg, "coverWidth") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:effectiveCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The total effective or actual volumetric capacity of the tank. Usually measured in cubic metre (m3).B3"</para>
    /// labels<para>"effective capacity"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/effectiveCapacity">https://saref.etsi.org/saref4bldg/effectiveCapacity</seealso>
    let effectiveCapacity = Prefixed_Name(s4bldg, "effectiveCapacity") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:electricGeneratorEfficiency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The ratio of output capacity to intake capacity."</para>
    /// labels<para>"electric generator efficiency"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/electricGeneratorEfficiency">https://saref.etsi.org/saref4bldg/electricGeneratorEfficiency</seealso>
    let electricGeneratorEfficiency =
        Prefixed_Name(s4bldg, "electricGeneratorEfficiency") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:electricMotorEfficiency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The ratio of output capacity to intake capacity."</para>
    /// labels<para>"electric motor efficiency"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/electricMotorEfficiency">https://saref.etsi.org/saref4bldg/electricMotorEfficiency</seealso>
    let electricMotorEfficiency =
        Prefixed_Name(s4bldg, "electricMotorEfficiency") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:endShapeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Defines the types of end shapes that can be used for preformed tanks. The convention for reading these enumerated values is that for a vertical cylinder, the first value is the base and the second is the top for a horizontal cylinder, the order of reading should be left to right. For a speherical tank, the value UNSET should be used.B5"</para>
    /// labels<para>"end shape type"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/endShapeType">https://saref.etsi.org/saref4bldg/endShapeType</seealso>
    let endShapeType = Prefixed_Name(s4bldg, "endShapeType") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:energySource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The source of energy."</para>
    ///   <para>"Enumeration defining the energy source or fuel cumbusted to generate heat."</para>
    /// labels<para>"energy source"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/energySource">https://saref.etsi.org/saref4bldg/energySource</seealso>
    let energySource = Prefixed_Name(s4bldg, "energySource") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:evaporationCoolant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The fluid used for the coolant in the evaporator."</para>
    /// labels<para>"evaporation coolant"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/evaporationCoolant">https://saref.etsi.org/saref4bldg/evaporationCoolant</seealso>
    let evaporationCoolant = Prefixed_Name(s4bldg, "evaporationCoolant") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:evaporationMediumType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"ColdLiquid: Evaporator is using liquid type of fluid to exchange heat with refrigerant. ColdAir: Evaporator is using air to exchange heat with refrigerant."</para>
    /// labels<para>"evaporation medium type"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/evaporationMediumType">https://saref.etsi.org/saref4bldg/evaporationMediumType</seealso>
    let evaporationMediumType =
        Prefixed_Name(s4bldg, "evaporationMediumType") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:externalSurfaceArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"External surface area (both primary and secondary area). Usually measured in square metre (m2)."</para>
    /// labels<para>"external surface area"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/externalSurfaceArea">https://saref.etsi.org/saref4bldg/externalSurfaceArea</seealso>
    let externalSurfaceArea =
        Prefixed_Name(s4bldg, "externalSurfaceArea") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:faceArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Face area open to the airstream. Usually measured in square metre (m2)."</para>
    /// labels<para>"face area"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/faceArea">https://saref.etsi.org/saref4bldg/faceArea</seealso>
    let faceArea = Prefixed_Name(s4bldg, "faceArea") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:failPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies the required fail-safe position of the actuator."</para>
    /// labels<para>"fail position"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/failPosition">https://saref.etsi.org/saref4bldg/failPosition</seealso>
    let failPosition = Prefixed_Name(s4bldg, "failPosition") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:finalResistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Filter fluid resistance when replacement is required (i.e., Pressure drop at the maximum air flowrate across the filter when the filter needs replacement per ASHRAE Standard 52.1). Usually measured in Pascals (Pa, N/m2)."</para>
    /// labels<para>"final resistance"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/finalResistance">https://saref.etsi.org/saref4bldg/finalResistance</seealso>
    let finalResistance = Prefixed_Name(s4bldg, "finalResistance") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:finishColor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Finish color for cooled beam."</para>
    /// labels<para>"finish color"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/finishColor">https://saref.etsi.org/saref4bldg/finishColor</seealso>
    let finishColor = Prefixed_Name(s4bldg, "finishColor") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:fireExit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indication whether this object is designed to serve as an exit in the case of fire (TRUE) or not (FALSE). Here whether the transport element (in case of e.g., a lift) is designed to serve as a fire exit, e.g., for fire escape purposes."</para>
    /// labels<para>"fire exit"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/fireExit">https://saref.etsi.org/saref4bldg/fireExit</seealso>
    let fireExit = Prefixed_Name(s4bldg, "fireExit") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:firstCurvatureRadius</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"FirstCurvatureRadius should be defined as the base or left side radius of curvature value. Usually measured in millimeters (mm)."</para>
    /// labels<para>"first curvature radius"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/firstCurvatureRadius">https://saref.etsi.org/saref4bldg/firstCurvatureRadius</seealso>
    let firstCurvatureRadius =
        Prefixed_Name(s4bldg, "firstCurvatureRadius") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:flowArrangement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"CounterFlow: Air and water flow enter in different directions. CrossFlow: Air and water flow are perpendicular. ParallelFlow: air and water flow enter in same directions."</para>
    /// labels<para>"flow arrangement"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/flowArrangement">https://saref.etsi.org/saref4bldg/flowArrangement</seealso>
    let flowArrangement = Prefixed_Name(s4bldg, "flowArrangement") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:flowCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Flow coefficient (the quantity of fluid that passes through a fully open valve at unit pressure drop), typically expressed as the Kv or Cv value for the valve."</para>
    /// labels<para>"flow coefficient"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/flowCoefficient">https://saref.etsi.org/saref4bldg/flowCoefficient</seealso>
    let flowCoefficient = Prefixed_Name(s4bldg, "flowCoefficient") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:flowResistanceMax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Allowable range of frictional resistance against which the fluid is being pumped. Usually measured in Pascals (Pa, N/m2)."</para>
    /// labels<para>"flow resistance range"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/flowResistanceMax">https://saref.etsi.org/saref4bldg/flowResistanceMax</seealso>
    let flowResistanceMax = Prefixed_Name(s4bldg, "flowResistanceMax") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:flowResistanceMin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Allowable range of frictional resistance against which the fluid is being pumped. Usually measured in Pascals (Pa, N/m2)."</para>
    /// labels<para>"flow resistance range"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/flowResistanceMin">https://saref.etsi.org/saref4bldg/flowResistanceMin</seealso>
    let flowResistanceMin = Prefixed_Name(s4bldg, "flowResistanceMin") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:fluidFlowRateMax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Possible range of fluid flowrate that can be delivered. Usually measured in m3/s."</para>
    /// labels<para>"fluid flow rate range"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/fluidFlowRateMax">https://saref.etsi.org/saref4bldg/fluidFlowRateMax</seealso>
    let fluidFlowRateMax = Prefixed_Name(s4bldg, "fluidFlowRateMax") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:fluidFlowRateMin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Possible range of fluid flowrate that can be delivered. Usually measured in m3/s."</para>
    /// labels<para>"fluid flow rate range"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/fluidFlowRateMin">https://saref.etsi.org/saref4bldg/fluidFlowRateMin</seealso>
    let fluidFlowRateMin = Prefixed_Name(s4bldg, "fluidFlowRateMin") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:foulingFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Fouling factor of the tubes in the tube bundle. Usually measured in m2 Kelvin/Watt."</para>
    /// labels<para>"fouling factor"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/foulingFactor">https://saref.etsi.org/saref4bldg/foulingFactor</seealso>
    let foulingFactor = Prefixed_Name(s4bldg, "foulingFactor") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:frameDepth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The length (or depth) of the damper frame. Usually measured in millimeters (mm)."</para>
    /// labels<para>"frame depth"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/frameDepth">https://saref.etsi.org/saref4bldg/frameDepth</seealso>
    let frameDepth = Prefixed_Name(s4bldg, "frameDepth") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:frameSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Designation of the frame size according to the named range of frame sizes designated at the place of use or according to a given standard."</para>
    /// labels<para>"frame size"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/frameSize">https://saref.etsi.org/saref4bldg/frameSize</seealso>
    let frameSize = Prefixed_Name(s4bldg, "frameSize") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:frameThickness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The thickness of the damper frame material. Usually measured in millimeters (mm)."</para>
    /// labels<para>"frame thickness"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/frameThickness">https://saref.etsi.org/saref4bldg/frameThickness</seealso>
    let frameThickness = Prefixed_Name(s4bldg, "frameThickness") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:frameType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The type of frame used by the damper (e.g., Standard, Single Flange, Single Reversed Flange, Double Flange, etc.)."</para>
    /// labels<para>"frame type"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/frameType">https://saref.etsi.org/saref4bldg/frameType</seealso>
    let frameType = Prefixed_Name(s4bldg, "frameType") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:hasDefrost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Whether the heat exchanger has defrost function or not."</para>
    /// labels<para>"has defrost"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/hasDefrost">https://saref.etsi.org/saref4bldg/hasDefrost</seealso>
    let hasDefrost = Prefixed_Name(s4bldg, "hasDefrost") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:hasExteriorInsulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"TRUE if the silencer has exterior insulation. FALSE if it does not."</para>
    /// labels<para>"has exterior insulation"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/hasExteriorInsulation">https://saref.etsi.org/saref4bldg/hasExteriorInsulation</seealso>
    let hasExteriorInsulation =
        Prefixed_Name(s4bldg, "hasExteriorInsulation") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:hasHotGasBypass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Whether or not hot gas bypass is provided for the compressor. TRUE = Yes, FALSE = No."</para>
    /// labels<para>"has hot gas bypass"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/hasHotGasBypass">https://saref.etsi.org/saref4bldg/hasHotGasBypass</seealso>
    let hasHotGasBypass = Prefixed_Name(s4bldg, "hasHotGasBypass") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:hasLock</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indication of whether a switching device has a key operated lock (=TRUE) or not (= FALSE)."</para>
    /// labels<para>"has lock"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/hasLock">https://saref.etsi.org/saref4bldg/hasLock</seealso>
    let hasLock = Prefixed_Name(s4bldg, "hasLock") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:hasPartWinding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indication of whether the motor is single speed, i.e. has a single winding (= FALSE) or multi-speed i.e.has part winding (= TRUE) ."</para>
    /// labels<para>"has part winding"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/hasPartWinding">https://saref.etsi.org/saref4bldg/hasPartWinding</seealso>
    let hasPartWinding = Prefixed_Name(s4bldg, "hasPartWinding") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:hasSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"Relation between a building or a building space and the spaces it can be divided into."</para>
    /// labels<para>"has space"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/hasSpace">https://saref.etsi.org/saref4bldg/hasSpace</seealso>
    let hasSpace = Prefixed_Name(s4bldg, "hasSpace") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:hasTurbulator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"TRUE if the tube has a turbulator, FALSE if it does not."</para>
    /// labels<para>"has turbulator"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/hasTurbulator">https://saref.etsi.org/saref4bldg/hasTurbulator</seealso>
    let hasTurbulator = Prefixed_Name(s4bldg, "hasTurbulator") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:heatExchangeArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Heat exchange area. Usually measured in square metre (m2)."</para>
    /// labels<para>"heat exchange area"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/heatExchangeArea">https://saref.etsi.org/saref4bldg/heatExchangeArea</seealso>
    let heatExchangeArea = Prefixed_Name(s4bldg, "heatExchangeArea") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:heatTransferDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates how heat is transmitted according to the shape of the space heater."</para>
    /// labels<para>"heat transfer dimension"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/heatTransferDimension">https://saref.etsi.org/saref4bldg/heatTransferDimension</seealso>
    let heatTransferDimension =
        Prefixed_Name(s4bldg, "heatTransferDimension") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:heatTransferMedium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Enumeration defining the heat transfer medium if applicable."</para>
    /// labels<para>"heat transfer medium"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/heatTransferMedium">https://saref.etsi.org/saref4bldg/heatTransferMedium</seealso>
    let heatTransferMedium = Prefixed_Name(s4bldg, "heatTransferMedium") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:heatTransferSurfaceArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Total heat transfer area of the vessel. Usually measured in square metre (m2)."</para>
    /// labels<para>"heat transfer surface area"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/heatTransferSurfaceArea">https://saref.etsi.org/saref4bldg/heatTransferSurfaceArea</seealso>
    let heatTransferSurfaceArea =
        Prefixed_Name(s4bldg, "heatTransferSurfaceArea") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:heatTransferTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Type of heat transfer between the two air streams."</para>
    /// labels<para>"heat transfer type enum"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/heatTransferTypeEnum">https://saref.etsi.org/saref4bldg/heatTransferTypeEnum</seealso>
    let heatTransferTypeEnum =
        Prefixed_Name(s4bldg, "heatTransferTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:height</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Height of the vibration isolator before tha application of load. Usually measured in millimeters (mm)."</para>
    /// labels<para>"height"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/height">https://saref.etsi.org/saref4bldg/height</seealso>
    let height = Prefixed_Name(s4bldg, "height") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:horizontalSpacing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Horizontal spacing between tubes in the tube bundle. Usually measured in millimeters (mm)."</para>
    /// labels<para>"horizontal spacing"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/horizontalSpacing">https://saref.etsi.org/saref4bldg/horizontalSpacing</seealso>
    let horizontalSpacing = Prefixed_Name(s4bldg, "horizontalSpacing") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:hydraulicDiameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Hydraulic diameter. Usually measured in millimeters (mm)."</para>
    /// labels<para>"hydraulic diameter"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/hydraulicDiameter">https://saref.etsi.org/saref4bldg/hydraulicDiameter</seealso>
    let hydraulicDiameter = Prefixed_Name(s4bldg, "hydraulicDiameter") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:idealCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Compressor capacity under ideal conditions. Usually measured in Watts (W, J/s)."</para>
    /// labels<para>"ideal capacity"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/idealCapacity">https://saref.etsi.org/saref4bldg/idealCapacity</seealso>
    let idealCapacity = Prefixed_Name(s4bldg, "idealCapacity") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:idealShaftPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Compressor shaft power under ideal conditions. Usually measured in Watts (W, J/s)."</para>
    /// labels<para>"ideal shaft power"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/idealShaftPower">https://saref.etsi.org/saref4bldg/idealShaftPower</seealso>
    let idealShaftPower = Prefixed_Name(s4bldg, "idealShaftPower") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:imaginaryImpedanceRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The ratio between the imaginary part of the zero sequence impedance and the imaginary part of the positive impedance (i.e. imaginary part of the short-circuit voltage) of the transformer. Used for three-phase transformer which includes a N-conductor."</para>
    /// labels<para>"imaginary impedance ratio"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/imaginaryImpedanceRatio">https://saref.etsi.org/saref4bldg/imaginaryImpedanceRatio</seealso>
    let imaginaryImpedanceRatio =
        Prefixed_Name(s4bldg, "imaginaryImpedanceRatio") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:impellerDiameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Diameter of compressor impeller - used to scale performance of geometrically similar compressors. Usually measured in millimeters (mm)."</para>
    /// labels<para>"impeller diameter"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/impellerDiameter">https://saref.etsi.org/saref4bldg/impellerDiameter</seealso>
    let impellerDiameter = Prefixed_Name(s4bldg, "impellerDiameter") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:inLineRowSpacing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In-line tube row spacing. Usually measured in millimeters (mm)."</para>
    /// labels<para>"in line row spacing"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/inLineRowSpacing">https://saref.etsi.org/saref4bldg/inLineRowSpacing</seealso>
    let inLineRowSpacing = Prefixed_Name(s4bldg, "inLineRowSpacing") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:initialResistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Initial new filter fluid resistance (i.e., pressure drop at the maximum air flowrate across the filter when the filter is new per ASHRAE Standard 52.1). Usually measured in Pascals (Pa, N/m2)."</para>
    /// labels<para>"initial resistance"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/initialResistance">https://saref.etsi.org/saref4bldg/initialResistance</seealso>
    let initialResistance = Prefixed_Name(s4bldg, "initialResistance") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:inletConnectionSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Size of the inlet connection. Usually measured in millimeters (mm)."</para>
    /// labels<para>"inlet connection size"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/inletConnectionSize">https://saref.etsi.org/saref4bldg/inletConnectionSize</seealso>
    let inletConnectionSize =
        Prefixed_Name(s4bldg, "inletConnectionSize") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:insideDiameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Actual inner diameter of the tube in the tube bundle. Usually measured in millimeters (mm)."</para>
    /// labels<para>"inside diameter"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/insideDiameter">https://saref.etsi.org/saref4bldg/insideDiameter</seealso>
    let insideDiameter = Prefixed_Name(s4bldg, "insideDiameter") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:integratedLightingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Integrated lighting in cooled beam."</para>
    /// labels<para>"integrated lighting type"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/integratedLightingType">https://saref.etsi.org/saref4bldg/integratedLightingType</seealso>
    let integratedLightingType =
        Prefixed_Name(s4bldg, "integratedLightingType") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:internalControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Internal modulation control."</para>
    /// labels<para>"internal control"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/internalControl">https://saref.etsi.org/saref4bldg/internalControl</seealso>
    let internalControl = Prefixed_Name(s4bldg, "internalControl") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:internalRefrigerantVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Internal volume of evaporator (refrigerant side). Usually measured in cubic metre (m3)."</para>
    /// labels<para>"internal refrigerant volume"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/internalRefrigerantVolume">https://saref.etsi.org/saref4bldg/internalRefrigerantVolume</seealso>
    let internalRefrigerantVolume =
        Prefixed_Name(s4bldg, "internalRefrigerantVolume") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:internalSurfaceArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Internal surface area. Usually measured in square metre (m2)."</para>
    /// labels<para>"internal surface area"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/internalSurfaceArea">https://saref.etsi.org/saref4bldg/internalSurfaceArea</seealso>
    let internalSurfaceArea =
        Prefixed_Name(s4bldg, "internalSurfaceArea") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:internalWaterVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Internal volume of evaporator (water side). Usually measured in cubic metre (m3)."</para>
    /// labels<para>"internal water volume"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/internalWaterVolume">https://saref.etsi.org/saref4bldg/internalWaterVolume</seealso>
    let internalWaterVolume =
        Prefixed_Name(s4bldg, "internalWaterVolume") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:isContainedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between an object and the physical space in which it is located."</para>
    /// labels<para>"is contained in"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/isContainedIn">https://saref.etsi.org/saref4bldg/isContainedIn</seealso>
    let isContainedIn = Prefixed_Name(s4bldg, "isContainedIn") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:isExternal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indication whether the element is designed for use in the exterior (TRUE) or not (FALSE). If (TRUE) it is an external element and faces the outside of the building."</para>
    /// labels<para>"is external"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/isExternal">https://saref.etsi.org/saref4bldg/isExternal</seealso>
    let isExternal = Prefixed_Name(s4bldg, "isExternal") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:isFreeHanging</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Is it free hanging type (not mounted in a false ceiling)?"</para>
    /// labels<para>"is free hanging"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/isFreeHanging">https://saref.etsi.org/saref4bldg/isFreeHanging</seealso>
    let isFreeHanging = Prefixed_Name(s4bldg, "isFreeHanging") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:isGuarded</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indication of whether the motor enclosure is guarded (= TRUE) or not (= FALSE)."</para>
    /// labels<para>"is guarded"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/isGuarded">https://saref.etsi.org/saref4bldg/isGuarded</seealso>
    let isGuarded = Prefixed_Name(s4bldg, "isGuarded") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:isIlluminated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An indication of whether there is an illuminated indicator to show that the switch is on (=TRUE) or not (= FALSE)."</para>
    /// labels<para>"is illuminated"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/isIlluminated">https://saref.etsi.org/saref4bldg/isIlluminated</seealso>
    let isIlluminated = Prefixed_Name(s4bldg, "isIlluminated") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:isNeutralPrimaryTerminalAvailable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An indication of whether the neutral point of the primary winding is available as a terminal (=TRUE) or not (= FALSE)."</para>
    /// labels<para>"is neutral primary terminal available"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/isNeutralPrimaryTerminalAvailable">https://saref.etsi.org/saref4bldg/isNeutralPrimaryTerminalAvailable</seealso>
    let isNeutralPrimaryTerminalAvailable =
        Prefixed_Name(s4bldg, "isNeutralPrimaryTerminalAvailable") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:isNeutralSecondaryTerminalAvailable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An indication of whether the neutral point of the secondary winding is available as a terminal (=TRUE) or not (= FALSE)."</para>
    /// labels<para>"is neutral secondary terminal available"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/isNeutralSecondaryTerminalAvailable">https://saref.etsi.org/saref4bldg/isNeutralSecondaryTerminalAvailable</seealso>
    let isNeutralSecondaryTerminalAvailable =
        Prefixed_Name(s4bldg, "isNeutralSecondaryTerminalAvailable") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:isPluggableOutlet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indication of whether the outlet accepts a loose plug connection (= TRUE) or whether it is directly connected (= FALSE) or whether the form of connection has not yet been determined (= UNKNOWN)."</para>
    /// labels<para>"is pluggable outlet"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/isPluggableOutlet">https://saref.etsi.org/saref4bldg/isPluggableOutlet</seealso>
    let isPluggableOutlet = Prefixed_Name(s4bldg, "isPluggableOutlet") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:isSpaceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation between a building space and the building or building space it belongs to."</para>
    /// labels<para>"isSpaceOf"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/isSpaceOf">https://saref.etsi.org/saref4bldg/isSpaceOf</seealso>
    let isSpaceOf = Prefixed_Name(s4bldg, "isSpaceOf") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:isWaterStorageHeater</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This is used to identify if the boiler has storage capacity (TRUE). If FALSE, then there is no storage capacity built into the boiler, such as an instantaneous hot water heater."</para>
    /// labels<para>"is water storage heater"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/isWaterStorageHeater">https://saref.etsi.org/saref4bldg/isWaterStorageHeater</seealso>
    let isWaterStorageHeater =
        Prefixed_Name(s4bldg, "isWaterStorageHeater") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:isolatorCompressibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The compressibility of the vibration isolator."</para>
    /// labels<para>"isolator compressibility"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/isolatorCompressibility">https://saref.etsi.org/saref4bldg/isolatorCompressibility</seealso>
    let isolatorCompressibility =
        Prefixed_Name(s4bldg, "isolatorCompressibility") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:isolatorStaticDeflection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Static deflection of the vibration isolator. Usually measured in millimeters (mm)."</para>
    /// labels<para>"isolator static deflection"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/isolatorStaticDeflection">https://saref.etsi.org/saref4bldg/isolatorStaticDeflection</seealso>
    let isolatorStaticDeflection =
        Prefixed_Name(s4bldg, "isolatorStaticDeflection") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:lampBallastType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The type of ballast used to stabilise gas discharge by limiting the current during operation and to deliver the necessary striking voltage for starting. Ballasts are needed to operate Discharge Lamps such as Fluorescent, Compact Fluorescent, High-pressure Mercury, Metal Halide and High-pressure Sodium Lamps. Magnetic ballasts are chokes which limit the current passing through a lamp connected in series on the principle of self-induction. The resultant current and power are decisive for the efficient operation of the lamp. A specially designed ballast is required for every type of lamp to comply with lamp rating in terms of Luminous Flux, Color Appearance and service life. The two types of magnetic ballasts for fluorescent lamps are KVG Conventional (EC-A series) and VVG Low-loss ballasts (EC-B series). Low-loss ballasts have a higher efficiency, which means reduced ballast losses and a lower thermal load. Electronic ballasts are used to run fluorescent lamps at high frequencies (approx. 35 - 40 kHz)."</para>
    /// labels<para>"lamp ballast type"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/lampBallastType">https://saref.etsi.org/saref4bldg/lampBallastType</seealso>
    let lampBallastType = Prefixed_Name(s4bldg, "lampBallastType") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:lampCompensationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Identifies the form of compensation used for power factor correction and radio suppression."</para>
    /// labels<para>"lamp compensation type"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/lampCompensationType">https://saref.etsi.org/saref4bldg/lampCompensationType</seealso>
    let lampCompensationType =
        Prefixed_Name(s4bldg, "lampCompensationType") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:lampMaintenanceFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Non recoverable losses of luminous flux of a lamp due to lamp depreciation i.e. the decreasing of light output of a luminaire due to aging and dirt."</para>
    /// labels<para>"lamp maintenance factor"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/lampMaintenanceFactor">https://saref.etsi.org/saref4bldg/lampMaintenanceFactor</seealso>
    let lampMaintenanceFactor =
        Prefixed_Name(s4bldg, "lampMaintenanceFactor") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:leakageFullyClosed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Leakage when fully closed. Usually measured in m3/s."</para>
    /// labels<para>"leakage fully closed"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/leakageFullyClosed">https://saref.etsi.org/saref4bldg/leakageFullyClosed</seealso>
    let leakageFullyClosed = Prefixed_Name(s4bldg, "leakageFullyClosed") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:legend</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A text inscribed or applied to the switch as a legend to indicate purpose or function."</para>
    /// labels<para>"legend"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/legend">https://saref.etsi.org/saref4bldg/legend</seealso>
    let legend = Prefixed_Name(s4bldg, "legend") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:length</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The finished length of the device. Usually measured in millimeters (mm)."</para>
    /// labels<para>"length"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/length">https://saref.etsi.org/saref4bldg/length</seealso>
    let length = Prefixed_Name(s4bldg, "length") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:liftElevationDifference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Elevation difference between cooling tower sump and the top of the tower. Usually measured in millimeters (mm)."</para>
    /// labels<para>"lift elevation difference"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/liftElevationDifference">https://saref.etsi.org/saref4bldg/liftElevationDifference</seealso>
    let liftElevationDifference =
        Prefixed_Name(s4bldg, "liftElevationDifference") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:lightEmitterNominalPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Light emitter nominal power. Usually measured in Watts (W, J/s)."</para>
    /// labels<para>"light emitter nominal power"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/lightEmitterNominalPower">https://saref.etsi.org/saref4bldg/lightEmitterNominalPower</seealso>
    let lightEmitterNominalPower =
        Prefixed_Name(s4bldg, "lightEmitterNominalPower") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:limitingTerminalSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The maximum terminal size capacity of the device. Usually measured in square metre (m2)."</para>
    /// labels<para>"limiting terminal size"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/limitingTerminalSize">https://saref.etsi.org/saref4bldg/limitingTerminalSize</seealso>
    let limitingTerminalSize =
        Prefixed_Name(s4bldg, "limitingTerminalSize") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:lockedRotorCurrent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Input current when a motor armature is energized but not rotating. Usually measured in Ampere (A)."</para>
    /// labels<para>"locked rotor current"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/lockedRotorCurrent">https://saref.etsi.org/saref4bldg/lockedRotorCurrent</seealso>
    let lockedRotorCurrent = Prefixed_Name(s4bldg, "lockedRotorCurrent") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:manualOverride</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Identifies whether hand-operated operation is provided as an override (= TRUE) or not (= FALSE). Note that this value should be set to FALSE by default in the case of a Hand Operated Actuator."</para>
    /// labels<para>"manual override"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/manualOverride">https://saref.etsi.org/saref4bldg/manualOverride</seealso>
    let manualOverride = Prefixed_Name(s4bldg, "manualOverride") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:mechanicalOperated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indication whether the element is operated machanically (TRUE) or not, i.e. manually (FALSE)."</para>
    /// labels<para>"mechanical operated"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/mechanicalOperated">https://saref.etsi.org/saref4bldg/mechanicalOperated</seealso>
    let mechanicalOperated = Prefixed_Name(s4bldg, "mechanicalOperated") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:mediaSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates media sources and corresponding names of ports (DistributionPort with FlowDirection=SINK and PredefinedType=AUDIOVISUAL) or aggregated audio/video components (AudioVisualAppliance)."</para>
    /// labels<para>"media source"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/mediaSource">https://saref.etsi.org/saref4bldg/mediaSource</seealso>
    let mediaSource = Prefixed_Name(s4bldg, "mediaSource") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:motorDriveType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Motor drive type: DIRECTDRIVE: Direct drive. BELTDRIVE: Belt drive. COUPLING: Coupling. OTHER: Other type of motor drive. UNKNOWN: Unknown motor drive type. "</para>
    /// labels<para>"motor drive type"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/motorDriveType">https://saref.etsi.org/saref4bldg/motorDriveType</seealso>
    let motorDriveType = Prefixed_Name(s4bldg, "motorDriveType") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:motorEnclosureType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A list of the available types of motor enclosure from which that required may be selected."</para>
    /// labels<para>"motor enclosure type"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/motorEnclosureType">https://saref.etsi.org/saref4bldg/motorEnclosureType</seealso>
    let motorEnclosureType = Prefixed_Name(s4bldg, "motorEnclosureType") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:netPositiveSuctionHead</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Minimum liquid pressure at the pump inlet to prevent cavitation. Usually measured in Pascals (Pa, N/m2)."</para>
    /// labels<para>"net positive suction head"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/netPositiveSuctionHead">https://saref.etsi.org/saref4bldg/netPositiveSuctionHead</seealso>
    let netPositiveSuctionHead =
        Prefixed_Name(s4bldg, "netPositiveSuctionHead") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalAirFlowRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Nominal rate of air flow. Usually measured in m3/s."</para>
    /// labels<para>"nominal air flow rate"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalAirFlowRate">https://saref.etsi.org/saref4bldg/nominalAirFlowRate</seealso>
    let nominalAirFlowRate = Prefixed_Name(s4bldg, "nominalAirFlowRate") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:nominalBodyDepth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Nominal or quoted =length, measured along the z-axis of the local coordinate system of the object, of the body of the object. Usually measured in millimeters (mm)."</para>
    /// labels<para>"nominal body depth"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalBodyDepth">https://saref.etsi.org/saref4bldg/nominalBodyDepth</seealso>
    let nominalBodyDepth = Prefixed_Name(s4bldg, "nominalBodyDepth") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:nominalBodyLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Nominal or quoted length, measured along the x-axis of the local coordinate system of the object, of the body of the object. Usually measured in millimeters (mm)."</para>
    /// labels<para>"nominal body length"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalBodyLength">https://saref.etsi.org/saref4bldg/nominalBodyLength</seealso>
    let nominalBodyLength = Prefixed_Name(s4bldg, "nominalBodyLength") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:nominalBodyWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Nominal or quoted length, measured along the y-axis of the local coordinate system of the object, of the body of the object. Usually measured in millimeters (mm)."</para>
    /// labels<para>"nominal body width"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalBodyWidth">https://saref.etsi.org/saref4bldg/nominalBodyWidth</seealso>
    let nominalBodyWidth = Prefixed_Name(s4bldg, "nominalBodyWidth") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:nominalCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Nominal capacity. Usually measured in Watts (W, J/s)."</para>
    /// labels<para>"nominal capacity"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalCapacity">https://saref.etsi.org/saref4bldg/nominalCapacity</seealso>
    let nominalCapacity = Prefixed_Name(s4bldg, "nominalCapacity") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalCondensingTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Chiller condensing temperature. Usually measured in degrees Kelvin (K)."</para>
    /// labels<para>"nominal condensing temperature"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalCondensingTemperature">https://saref.etsi.org/saref4bldg/nominalCondensingTemperature</seealso>
    let nominalCondensingTemperature =
        Prefixed_Name(s4bldg, "nominalCondensingTemperature") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalCoolingCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Nominal cooling capacity. Usually measured in Watts (W, J/s)."</para>
    /// labels<para>"nominal cooling capacity"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalCoolingCapacity">https://saref.etsi.org/saref4bldg/nominalCoolingCapacity</seealso>
    let nominalCoolingCapacity =
        Prefixed_Name(s4bldg, "nominalCoolingCapacity") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalDepth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The nominal depth of the tank. Note: Not required for a horizontal cylindrical tank. Usually measured in millimeters (mm)."</para>
    /// labels<para>"nominal depth"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalDepth">https://saref.etsi.org/saref4bldg/nominalDepth</seealso>
    let nominalDepth = Prefixed_Name(s4bldg, "nominalDepth") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:nominalDiameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Nominal diameter or width of the tubes in the tube bundle. Usually measured in millimeters (mm)."</para>
    /// labels<para>"nominal diameter"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalDiameter">https://saref.etsi.org/saref4bldg/nominalDiameter</seealso>
    let nominalDiameter = Prefixed_Name(s4bldg, "nominalDiameter") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:nominalEfficiency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Nominal chiller efficiency under nominal conditions. "</para>
    /// labels<para>"nominal efficiency"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalEfficiency">https://saref.etsi.org/saref4bldg/nominalEfficiency</seealso>
    let nominalEfficiency = Prefixed_Name(s4bldg, "nominalEfficiency") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalEnergyConsumption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Nominal fuel consumption rate required to produce the total boiler heat output. Usually measured in Watts (W, J/s)."</para>
    /// labels<para>"nominal energy consumption"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalEnergyConsumption">https://saref.etsi.org/saref4bldg/nominalEnergyConsumption</seealso>
    let nominalEnergyConsumption =
        Prefixed_Name(s4bldg, "nominalEnergyConsumption") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalEvaporatingTemmperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Chiller evaporating temperature.Usually measured in degrees Kelvin (K)."</para>
    /// labels<para>"nominal evaporating temmperature"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalEvaporatingTemmperature">https://saref.etsi.org/saref4bldg/nominalEvaporatingTemmperature</seealso>
    let nominalEvaporatingTemmperature =
        Prefixed_Name(s4bldg, "nominalEvaporatingTemmperature") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalFilterFaceVelocity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Filter face velocity. Usually measured in m/s."</para>
    /// labels<para>"nominal filter face velocity"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalFilterFaceVelocity">https://saref.etsi.org/saref4bldg/nominalFilterFaceVelocity</seealso>
    let nominalFilterFaceVelocity =
        Prefixed_Name(s4bldg, "nominalFilterFaceVelocity") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalFlowRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Nominal fluid flow rate through the filter. Usually measured in m3/s."</para>
    /// labels<para>"nominal flow rate"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalFlowRate">https://saref.etsi.org/saref4bldg/nominalFlowRate</seealso>
    let nominalFlowRate = Prefixed_Name(s4bldg, "nominalFlowRate") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:nominalFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The nominal frequency of the supply. Usually measured in cycles/s or Hertz (Hz)."</para>
    /// labels<para>"nominal frequency"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalFrequency">https://saref.etsi.org/saref4bldg/nominalFrequency</seealso>
    let nominalFrequency = Prefixed_Name(s4bldg, "nominalFrequency") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalHeatRejectionRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Sum of the refrigeration effect and the heat equivalent of the power input to the compressor. Usually measured in Watts (W, J/s)."</para>
    /// labels<para>"nominal heat rejection rate"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalHeatRejectionRate">https://saref.etsi.org/saref4bldg/nominalHeatRejectionRate</seealso>
    let nominalHeatRejectionRate =
        Prefixed_Name(s4bldg, "nominalHeatRejectionRate") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalHeatTransferArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Nominal heat transfer surface area associated with nominal overall heat transfer coefficient. Usually measured in square metre (m2)."</para>
    /// labels<para>"nominal heat transfer area"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalHeatTransferArea">https://saref.etsi.org/saref4bldg/nominalHeatTransferArea</seealso>
    let nominalHeatTransferArea =
        Prefixed_Name(s4bldg, "nominalHeatTransferArea") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalHeatTransferCoefficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Nominal overall heat transfer coefficient associated with nominal heat transfer area. Usually measured in Watts/m2 Kelvin."</para>
    /// labels<para>"nominal heat transfer coefficient"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalHeatTransferCoefficient">https://saref.etsi.org/saref4bldg/nominalHeatTransferCoefficient</seealso>
    let nominalHeatTransferCoefficient =
        Prefixed_Name(s4bldg, "nominalHeatTransferCoefficient") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalHeatingCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Nominal heating capacity. Usually measured in Watts (W, J/s)."</para>
    /// labels<para>"nominal heating capacity"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalHeatingCapacity">https://saref.etsi.org/saref4bldg/nominalHeatingCapacity</seealso>
    let nominalHeatingCapacity =
        Prefixed_Name(s4bldg, "nominalHeatingCapacity") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalLatentCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Nominal latent capacity. Usually measured in Watts (W, J/s)."</para>
    /// labels<para>"nominal latent capacity"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalLatentCapacity">https://saref.etsi.org/saref4bldg/nominalLatentCapacity</seealso>
    let nominalLatentCapacity =
        Prefixed_Name(s4bldg, "nominalLatentCapacity") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalLengthOrDiameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The nominal length or, in the case of a vertical cylindrical tank, the nominal diameter of the tank. Usually measured in millimeters (mm)."</para>
    /// labels<para>"nominal length or diameter"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalLengthOrDiameter">https://saref.etsi.org/saref4bldg/nominalLengthOrDiameter</seealso>
    let nominalLengthOrDiameter =
        Prefixed_Name(s4bldg, "nominalLengthOrDiameter") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalMediaSurfaceVelocity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Average fluid velocity at the media surface. Usually measured in m/s."</para>
    /// labels<para>"nominal media surface velocity"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalMediaSurfaceVelocity">https://saref.etsi.org/saref4bldg/nominalMediaSurfaceVelocity</seealso>
    let nominalMediaSurfaceVelocity =
        Prefixed_Name(s4bldg, "nominalMediaSurfaceVelocity") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalMoistureGain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Nominal rate of water vapor added into the airstream. Usually measured in kg/s."</para>
    /// labels<para>"nominal moisture gain"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalMoistureGain">https://saref.etsi.org/saref4bldg/nominalMoistureGain</seealso>
    let nominalMoistureGain =
        Prefixed_Name(s4bldg, "nominalMoistureGain") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalPartLoadRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Allowable part load ratio range."</para>
    /// labels<para>"nominal part load ratio"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalPartLoadRatio">https://saref.etsi.org/saref4bldg/nominalPartLoadRatio</seealso>
    let nominalPartLoadRatio =
        Prefixed_Name(s4bldg, "nominalPartLoadRatio") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalParticleGeometricMeanDiameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Particle geometric mean diameter associated with nominal efficiency. Usually measured in millimeters (mm)."</para>
    /// labels<para>"nominal particle geometric mean diameter"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalParticleGeometricMeanDiameter">https://saref.etsi.org/saref4bldg/nominalParticleGeometricMeanDiameter</seealso>
    let nominalParticleGeometricMeanDiameter =
        Prefixed_Name(s4bldg, "nominalParticleGeometricMeanDiameter") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalParticleGeometricStandardDeviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Particle geometric standard deviation associated with nominal efficiency. "</para>
    /// labels<para>"nominal particle geometric standard deviation"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalParticleGeometricStandardDeviation">https://saref.etsi.org/saref4bldg/nominalParticleGeometricStandardDeviation</seealso>
    let nominalParticleGeometricStandardDeviation =
        Prefixed_Name(s4bldg, "nominalParticleGeometricStandardDeviation") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalPowerConsumption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Nominal total power consumption. Usually measured in Watts (W, J/s)."</para>
    /// labels<para>"nominal power consumption"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalPowerConsumption">https://saref.etsi.org/saref4bldg/nominalPowerConsumption</seealso>
    let nominalPowerConsumption =
        Prefixed_Name(s4bldg, "nominalPowerConsumption") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalPowerRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Nominal fan power rate.Usually measured in Watts (W, J/s)."</para>
    /// labels<para>"nominal power rate"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalPowerRate">https://saref.etsi.org/saref4bldg/nominalPowerRate</seealso>
    let nominalPowerRate = Prefixed_Name(s4bldg, "nominalPowerRate") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalPressureDrop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Total pressure drop across the filter. Usually measured in Pascals (Pa, N/m2)."</para>
    /// labels<para>"nominal pressure drop"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalPressureDrop">https://saref.etsi.org/saref4bldg/nominalPressureDrop</seealso>
    let nominalPressureDrop =
        Prefixed_Name(s4bldg, "nominalPressureDrop") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalReturnWaterTemperatureCooling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Nominal return water temperature (refers to nominal cooling capacity). Usually measured in degrees Kelvin (K)."</para>
    /// labels<para>"nominal return water temperature cooling"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalReturnWaterTemperatureCooling">https://saref.etsi.org/saref4bldg/nominalReturnWaterTemperatureCooling</seealso>
    let nominalReturnWaterTemperatureCooling =
        Prefixed_Name(s4bldg, "nominalReturnWaterTemperatureCooling") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalReturnWaterTemperatureHeating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Nominal return water temperature (refers to nominal heating capacity). Usually measured in degrees Kelvin (K)."</para>
    /// labels<para>"nominal return water temperature heating"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalReturnWaterTemperatureHeating">https://saref.etsi.org/saref4bldg/nominalReturnWaterTemperatureHeating</seealso>
    let nominalReturnWaterTemperatureHeating =
        Prefixed_Name(s4bldg, "nominalReturnWaterTemperatureHeating") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalRotationSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Nominal fan wheel speed. Usually measured in cycles/s."</para>
    /// labels<para>"nominal rotation speed"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalRotationSpeed">https://saref.etsi.org/saref4bldg/nominalRotationSpeed</seealso>
    let nominalRotationSpeed =
        Prefixed_Name(s4bldg, "nominalRotationSpeed") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalSensibleCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Nominal sensible capacity. Usually measured in Watts (W, J/s)."</para>
    /// labels<para>"nominal sensible capacity"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalSensibleCapacity">https://saref.etsi.org/saref4bldg/nominalSensibleCapacity</seealso>
    let nominalSensibleCapacity =
        Prefixed_Name(s4bldg, "nominalSensibleCapacity") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalSorroundingHumidityCooling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Nominal surrounding humidity (refers to nominal cooling capacity). Usually measured in degrees Kelvin (K)."</para>
    /// labels<para>"nominal sorrounding humidity cooling"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalSorroundingHumidityCooling">https://saref.etsi.org/saref4bldg/nominalSorroundingHumidityCooling</seealso>
    let nominalSorroundingHumidityCooling =
        Prefixed_Name(s4bldg, "nominalSorroundingHumidityCooling") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalSorroundingTemperatureCooling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Nominal surrounding temperature (refers to nominal cooling capacity). Usually measured in degrees Kelvin (K)."</para>
    /// labels<para>"nominal sorrounding temperature cooling"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalSorroundingTemperatureCooling">https://saref.etsi.org/saref4bldg/nominalSorroundingTemperatureCooling</seealso>
    let nominalSorroundingTemperatureCooling =
        Prefixed_Name(s4bldg, "nominalSorroundingTemperatureCooling") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalSorroundingTemperatureHeating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Nominal surrounding temperature (refers to nominal heating capacity). Usually measured in degrees Kelvin (K)."</para>
    /// labels<para>"nominal sorrounding temperature heating"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalSorroundingTemperatureHeating">https://saref.etsi.org/saref4bldg/nominalSorroundingTemperatureHeating</seealso>
    let nominalSorroundingTemperatureHeating =
        Prefixed_Name(s4bldg, "nominalSorroundingTemperatureHeating") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalStaticPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The static pressure within the air stream that the fan must overcome to insure designed circulation of air. Usually measured in Pascals (Pa, N/m2)."</para>
    /// labels<para>"nominal static pressure"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalStaticPressure">https://saref.etsi.org/saref4bldg/nominalStaticPressure</seealso>
    let nominalStaticPressure =
        Prefixed_Name(s4bldg, "nominalStaticPressure") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalSupplyVoltage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The nominal voltage of the supply. Usually measured in Volts (V, W/A)."</para>
    /// labels<para>"nominal supply voltage"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalSupplyVoltage">https://saref.etsi.org/saref4bldg/nominalSupplyVoltage</seealso>
    let nominalSupplyVoltage =
        Prefixed_Name(s4bldg, "nominalSupplyVoltage") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalSupplyVoltageMax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The maximum and minimum allowed voltage of the supply e.g. boundaries of 380V/440V may be applied for a nominal voltage of 400V."</para>
    /// labels<para>"nominal supply voltage offset"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalSupplyVoltageMax">https://saref.etsi.org/saref4bldg/nominalSupplyVoltageMax</seealso>
    let nominalSupplyVoltageMax =
        Prefixed_Name(s4bldg, "nominalSupplyVoltageMax") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalSupplyVoltageMin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The maximum and minimum allowed voltage of the supply e.g. boundaries of 380V/440V may be applied for a nominal voltage of 400V."</para>
    /// labels<para>"nominal supply voltage offset"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalSupplyVoltageMin">https://saref.etsi.org/saref4bldg/nominalSupplyVoltageMin</seealso>
    let nominalSupplyVoltageMin =
        Prefixed_Name(s4bldg, "nominalSupplyVoltageMin") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalSupplyWaterTemperatureCooling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Nominal supply water temperature (refers to nominal cooling capacity). Usually measured in degrees Kelvin (K)."</para>
    /// labels<para>"nominal supply water temperature cooling"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalSupplyWaterTemperatureCooling">https://saref.etsi.org/saref4bldg/nominalSupplyWaterTemperatureCooling</seealso>
    let nominalSupplyWaterTemperatureCooling =
        Prefixed_Name(s4bldg, "nominalSupplyWaterTemperatureCooling") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalSupplyWaterTemperatureHeating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Nominal supply water temperature (refers to nominal heating capacity). Usually measured in degrees Kelvin (K)."</para>
    /// labels<para>"nominal supply water temperature heating"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalSupplyWaterTemperatureHeating">https://saref.etsi.org/saref4bldg/nominalSupplyWaterTemperatureHeating</seealso>
    let nominalSupplyWaterTemperatureHeating =
        Prefixed_Name(s4bldg, "nominalSupplyWaterTemperatureHeating") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalTotalPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Nominal total pressure rise across the fan. Usually measured in Pascals (Pa, N/m2)."</para>
    /// labels<para>"nominal total pressure"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalTotalPressure">https://saref.etsi.org/saref4bldg/nominalTotalPressure</seealso>
    let nominalTotalPressure =
        Prefixed_Name(s4bldg, "nominalTotalPressure") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalUa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Nominal UA value."</para>
    /// labels<para>"nominal ua"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalUa">https://saref.etsi.org/saref4bldg/nominalUa</seealso>
    let nominalUa = Prefixed_Name(s4bldg, "nominalUa") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalVolumetricCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The total nominal or design volumetric capacity of the tank. Usually measured in cubic metre (m3)."</para>
    /// labels<para>"nominal volumetric capacity"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalVolumetricCapacity">https://saref.etsi.org/saref4bldg/nominalVolumetricCapacity</seealso>
    let nominalVolumetricCapacity =
        Prefixed_Name(s4bldg, "nominalVolumetricCapacity") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalWaterFlowCooling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Nominal water flow (refers to nominal cooling capacity). Usually measured in m3/s."</para>
    /// labels<para>"nominal water flow cooling"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalWaterFlowCooling">https://saref.etsi.org/saref4bldg/nominalWaterFlowCooling</seealso>
    let nominalWaterFlowCooling =
        Prefixed_Name(s4bldg, "nominalWaterFlowCooling") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalWaterFlowHeating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Nominal water flow (refers to nominal heating capacity). Usually measured in m3/s."</para>
    /// labels<para>"nominal water flow heating"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalWaterFlowHeating">https://saref.etsi.org/saref4bldg/nominalWaterFlowHeating</seealso>
    let nominalWaterFlowHeating =
        Prefixed_Name(s4bldg, "nominalWaterFlowHeating") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nominalWidthOrDiameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The nominal width or, in the case of a horizontal cylindrical tank, the nominal diameter of the tank. Note: Not required for a vertical cylindrical tank. Usually measured in millimeters (mm)."</para>
    /// labels<para>"nominal width or diameter"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nominalWidthOrDiameter">https://saref.etsi.org/saref4bldg/nominalWidthOrDiameter</seealso>
    let nominalWidthOrDiameter =
        Prefixed_Name(s4bldg, "nominalWidthOrDiameter") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:nomminalRotationSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Pump rotational speed under nominal conditions. Usually measured in cycles/s."</para>
    /// labels<para>"nomminal rotation speed"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/nomminalRotationSpeed">https://saref.etsi.org/saref4bldg/nomminalRotationSpeed</seealso>
    let nomminalRotationSpeed =
        Prefixed_Name(s4bldg, "nomminalRotationSpeed") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:numberOfBlades</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Number of blades."</para>
    /// labels<para>"number of blades"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/numberOfBlades">https://saref.etsi.org/saref4bldg/numberOfBlades</seealso>
    let numberOfBlades = Prefixed_Name(s4bldg, "numberOfBlades") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:numberOfCells</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Number of cells in one cooling tower unit."</para>
    /// labels<para>"number of cells"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/numberOfCells">https://saref.etsi.org/saref4bldg/numberOfCells</seealso>
    let numberOfCells = Prefixed_Name(s4bldg, "numberOfCells") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:numberOfCircuits</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Number of parallel fluid tube circuits."</para>
    /// labels<para>"number of circuits"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/numberOfCircuits">https://saref.etsi.org/saref4bldg/numberOfCircuits</seealso>
    let numberOfCircuits = Prefixed_Name(s4bldg, "numberOfCircuits") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:numberOfGangs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Number of gangs/buttons on this switch."</para>
    /// labels<para>"number of gangs"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/numberOfGangs">https://saref.etsi.org/saref4bldg/numberOfGangs</seealso>
    let numberOfGangs = Prefixed_Name(s4bldg, "numberOfGangs") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:numberOfPanels</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Number of panels."</para>
    /// labels<para>"number of panels"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/numberOfPanels">https://saref.etsi.org/saref4bldg/numberOfPanels</seealso>
    let numberOfPanels = Prefixed_Name(s4bldg, "numberOfPanels") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:numberOfRows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Number of tube rows in the tube bundle assembly."</para>
    /// labels<para>"number of rows"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/numberOfRows">https://saref.etsi.org/saref4bldg/numberOfRows</seealso>
    let numberOfRows = Prefixed_Name(s4bldg, "numberOfRows") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:numberOfSections</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Number of sections used."</para>
    /// labels<para>"number of sections"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/numberOfSections">https://saref.etsi.org/saref4bldg/numberOfSections</seealso>
    let numberOfSections = Prefixed_Name(s4bldg, "numberOfSections") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:numberOsSockets</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The number of sockets that may be connected. In case of inconsistency, sockets defined on ports take precedence."</para>
    /// labels<para>"number os sockets"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/numberOsSockets">https://saref.etsi.org/saref4bldg/numberOsSockets</seealso>
    let numberOsSockets = Prefixed_Name(s4bldg, "numberOsSockets") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:openPressureDrop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Total pressure drop across damper. Usually measured in Pascals (Pa, N/m2)."</para>
    /// labels<para>"open pressure drop"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/openPressureDrop">https://saref.etsi.org/saref4bldg/openPressureDrop</seealso>
    let openPressureDrop = Prefixed_Name(s4bldg, "openPressureDrop") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:operatingMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Identifies the operating mode of the boiler."</para>
    /// labels<para>"operating mode"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/operatingMode">https://saref.etsi.org/saref4bldg/operatingMode</seealso>
    let operatingMode = Prefixed_Name(s4bldg, "operatingMode") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:operatingWeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Operating weight of the tank including all of its contents. Usually measured in kilograms (kg) or grams (g)."</para>
    /// labels<para>"operating weight"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/operatingWeight">https://saref.etsi.org/saref4bldg/operatingWeight</seealso>
    let operatingWeight = Prefixed_Name(s4bldg, "operatingWeight") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:operation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The operational mechanism for the damper operation."</para>
    /// labels<para>"operation"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/operation">https://saref.etsi.org/saref4bldg/operation</seealso>
    let operation = Prefixed_Name(s4bldg, "operation") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:operationTemperatureMax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Allowable operation ambient (air, fluid) temperature range. Usually measured in degrees Kelvin (K)."</para>
    /// labels<para>"operation temperature range"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/operationTemperatureMax">https://saref.etsi.org/saref4bldg/operationTemperatureMax</seealso>
    let operationTemperatureMax =
        Prefixed_Name(s4bldg, "operationTemperatureMax") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:operationTemperatureMin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Allowable operation ambient (air, fluid) temperature range. Usually measured in degrees Kelvin (K)."</para>
    /// labels<para>"operation temperature range"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/operationTemperatureMin">https://saref.etsi.org/saref4bldg/operationTemperatureMin</seealso>
    let operationTemperatureMin =
        Prefixed_Name(s4bldg, "operationTemperatureMin") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:operationalRiterial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Time of operation at maximum operational ambient air temperature. Measured in seconds (s) or days (d) or other units of time."</para>
    /// labels<para>"operational riterial"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/operationalRiterial">https://saref.etsi.org/saref4bldg/operationalRiterial</seealso>
    let operationalRiterial =
        Prefixed_Name(s4bldg, "operationalRiterial") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:orientation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The intended orientation for the damper as specified by the manufacturer."</para>
    /// labels<para>"orientation"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/orientation">https://saref.etsi.org/saref4bldg/orientation</seealso>
    let orientation = Prefixed_Name(s4bldg, "orientation") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:outletConnectionSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Size of the outlet connection. Usually measured in millimeters (mm)."</para>
    /// labels<para>"outlet connection size"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/outletConnectionSize">https://saref.etsi.org/saref4bldg/outletConnectionSize</seealso>
    let outletConnectionSize =
        Prefixed_Name(s4bldg, "outletConnectionSize") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:outletTemperatureMax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Allowable outlet temperature of either the water or the steam. Usually measured in degrees Kelvin (K)."</para>
    /// labels<para>"outlet temperature range"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/outletTemperatureMax">https://saref.etsi.org/saref4bldg/outletTemperatureMax</seealso>
    let outletTemperatureMax =
        Prefixed_Name(s4bldg, "outletTemperatureMax") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:outletTemperatureMin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Allowable outlet temperature of either the water or the steam. Usually measured in degrees Kelvin (K)."</para>
    /// labels<para>"outlet temperature range"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/outletTemperatureMin">https://saref.etsi.org/saref4bldg/outletTemperatureMin</seealso>
    let outletTemperatureMin =
        Prefixed_Name(s4bldg, "outletTemperatureMin") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:outputCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Total nominal heat output as listed by the manufacturer. Usually measured in Watts (W, J/s)."</para>
    /// labels<para>"output capacity"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/outputCapacity">https://saref.etsi.org/saref4bldg/outputCapacity</seealso>
    let outputCapacity = Prefixed_Name(s4bldg, "outputCapacity") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:outsideDiameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Actual outside diameter of the tube in the tube bundle. Usually measured in millimeters (mm)."</para>
    /// labels<para>"outside diameter"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/outsideDiameter">https://saref.etsi.org/saref4bldg/outsideDiameter</seealso>
    let outsideDiameter = Prefixed_Name(s4bldg, "outsideDiameter") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:partLoadRatioMax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Maximum part load ratio as a fraction of nominal capacity."</para>
    /// labels<para>"maximum part load ratio"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/partLoadRatioMax">https://saref.etsi.org/saref4bldg/partLoadRatioMax</seealso>
    let partLoadRatioMax = Prefixed_Name(s4bldg, "partLoadRatioMax") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:partLoadRatioMin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Minimum part load ratio as a fraction of nominal capacity."</para>
    /// labels<para>"minimum part load ratio"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/partLoadRatioMin">https://saref.etsi.org/saref4bldg/partLoadRatioMin</seealso>
    let partLoadRatioMin = Prefixed_Name(s4bldg, "partLoadRatioMin") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:patternType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Defines the types of pattern (or shape of a tank that may be specified."</para>
    /// labels<para>"pattern type"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/patternType">https://saref.etsi.org/saref4bldg/patternType</seealso>
    let patternType = Prefixed_Name(s4bldg, "patternType") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:pipeConnectionEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The manner in which the pipe connection is made to the cooled beam."</para>
    /// labels<para>"pipe connection enum"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/pipeConnectionEnum">https://saref.etsi.org/saref4bldg/pipeConnectionEnum</seealso>
    let pipeConnectionEnum = Prefixed_Name(s4bldg, "pipeConnectionEnum") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:placementType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates how the device is designed to be placed."</para>
    /// labels<para>"placement type"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/placementType">https://saref.etsi.org/saref4bldg/placementType</seealso>
    let placementType = Prefixed_Name(s4bldg, "placementType") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:powerOutputMax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The maximum output power rating of the engine. Usually measured in Watts (W, J/s)."</para>
    /// labels<para>"maximum power output"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/powerOutputMax">https://saref.etsi.org/saref4bldg/powerOutputMax</seealso>
    let powerOutputMax = Prefixed_Name(s4bldg, "powerOutputMax") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:powerSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Type of power driving the compressor."</para>
    /// labels<para>"power source"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/powerSource">https://saref.etsi.org/saref4bldg/powerSource</seealso>
    let powerSource = Prefixed_Name(s4bldg, "powerSource") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:pressureRating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Nominal pressure rating of the boiler as rated by the agency having jurisdiction. Usually measured in Pascals (Pa, N/m2)."</para>
    /// labels<para>"pressure rating"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/pressureRating">https://saref.etsi.org/saref4bldg/pressureRating</seealso>
    let pressureRating = Prefixed_Name(s4bldg, "pressureRating") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:primaryAirFlowRateMax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Maximum primary airflow that can be delivered. Usually measured in m3/s."</para>
    /// labels<para>"primary air flow rate range"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/primaryAirFlowRateMax">https://saref.etsi.org/saref4bldg/primaryAirFlowRateMax</seealso>
    let primaryAirFlowRateMax =
        Prefixed_Name(s4bldg, "primaryAirFlowRateMax") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:primaryAirFlowRateMin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Minimum primary airflow that can be delivered. Usually measured in m3/s."</para>
    /// labels<para>"primary air flow rate range"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/primaryAirFlowRateMin">https://saref.etsi.org/saref4bldg/primaryAirFlowRateMin</seealso>
    let primaryAirFlowRateMin =
        Prefixed_Name(s4bldg, "primaryAirFlowRateMin") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:primaryApparentPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The power in VA (volt ampere) that has been transformed and that runs into the transformer on the primary side. Usually measured in Watts (W, J/s)."</para>
    /// labels<para>"primary apparent power"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/primaryApparentPower">https://saref.etsi.org/saref4bldg/primaryApparentPower</seealso>
    let primaryApparentPower =
        Prefixed_Name(s4bldg, "primaryApparentPower") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:primaryCurrent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The current that is going to be transformed and that runs into the transformer on the primary side. Usually measured in Ampere (A)."</para>
    /// labels<para>"primary current"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/primaryCurrent">https://saref.etsi.org/saref4bldg/primaryCurrent</seealso>
    let primaryCurrent = Prefixed_Name(s4bldg, "primaryCurrent") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:primaryFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The frequency that is going to be transformed and that runs into the transformer on the primary side. Usually measured in cycles/s or Hertz (Hz)."</para>
    /// labels<para>"primary frequency"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/primaryFrequency">https://saref.etsi.org/saref4bldg/primaryFrequency</seealso>
    let primaryFrequency = Prefixed_Name(s4bldg, "primaryFrequency") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:primaryVoltage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The voltage that is going to be transformed and that runs into the transformer on the primary side. Usually measured in Volts (V, W/A)."</para>
    /// labels<para>"primary voltage"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/primaryVoltage">https://saref.etsi.org/saref4bldg/primaryVoltage</seealso>
    let primaryVoltage = Prefixed_Name(s4bldg, "primaryVoltage") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:pumpFlowRateMax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Allowable range of volume of fluid being pumped against the resistance specified. Usually measured in kg/s."</para>
    /// labels<para>"pump flow rate range"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/pumpFlowRateMax">https://saref.etsi.org/saref4bldg/pumpFlowRateMax</seealso>
    let pumpFlowRateMax = Prefixed_Name(s4bldg, "pumpFlowRateMax") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:pumpFlowRateMin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Allowable range of volume of fluid being pumped against the resistance specified. Usually measured in kg/s."</para>
    /// labels<para>"pump flow rate range"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/pumpFlowRateMin">https://saref.etsi.org/saref4bldg/pumpFlowRateMin</seealso>
    let pumpFlowRateMin = Prefixed_Name(s4bldg, "pumpFlowRateMin") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:readOutType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indication of the form that readout from the meter takes. In the case of a dial read out, this may comprise multiple dials that give a cumulative reading and/or a mechanical odometer."</para>
    /// labels<para>"read out type"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/readOutType">https://saref.etsi.org/saref4bldg/readOutType</seealso>
    let readOutType = Prefixed_Name(s4bldg, "readOutType") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:realImpedanceRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The ratio between the real part of the zero sequence impedance and the real part of the positive impedance (i.e. real part of the short-circuit voltage) of the transformer. Used for three-phase transformer which includes a N-conductor."</para>
    /// labels<para>"real impedance ratio"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/realImpedanceRatio">https://saref.etsi.org/saref4bldg/realImpedanceRatio</seealso>
    let realImpedanceRatio = Prefixed_Name(s4bldg, "realImpedanceRatio") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:refrigerantClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Refrigerant class used by the compressor. CFC: Chlorofluorocarbons. HCFC: Hydrochlorofluorocarbons. HFC: Hydrofluorocarbons."</para>
    /// labels<para>"refrigerant class"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/refrigerantClass">https://saref.etsi.org/saref4bldg/refrigerantClass</seealso>
    let refrigerantClass = Prefixed_Name(s4bldg, "refrigerantClass") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:remoteReading</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates whether the meter has a connection for remote reading through connection of a communication device (set TRUE) or not (set FALSE)."</para>
    /// labels<para>"remote reading"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/remoteReading">https://saref.etsi.org/saref4bldg/remoteReading</seealso>
    let remoteReading = Prefixed_Name(s4bldg, "remoteReading") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:roughness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A measure of the vertical deviations of the surface."</para>
    /// labels<para>"roughness"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/roughness">https://saref.etsi.org/saref4bldg/roughness</seealso>
    let roughness = Prefixed_Name(s4bldg, "roughness") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:secondCurvatureRadius</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"SecondCurvatureRadius should be defined as the top or right side radius of curvature value. Usually measured in millimeters (mm)."</para>
    /// labels<para>"second curvature radius"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/secondCurvatureRadius">https://saref.etsi.org/saref4bldg/secondCurvatureRadius</seealso>
    let secondCurvatureRadius =
        Prefixed_Name(s4bldg, "secondCurvatureRadius") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:secondaryAirFlowRateMax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Maximum secondary airflow that can be delivered. Usually measured in Pascals (Pa, N/m2)."</para>
    /// labels<para>"secondary air flow rate range"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/secondaryAirFlowRateMax">https://saref.etsi.org/saref4bldg/secondaryAirFlowRateMax</seealso>
    let secondaryAirFlowRateMax =
        Prefixed_Name(s4bldg, "secondaryAirFlowRateMax") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:secondaryAirFlowRateMin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Maximum secondary airflow that can be delivered. Usually measured in Pascals (Pa, N/m2)."</para>
    /// labels<para>"secondary air flow rate range"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/secondaryAirFlowRateMin">https://saref.etsi.org/saref4bldg/secondaryAirFlowRateMin</seealso>
    let secondaryAirFlowRateMin =
        Prefixed_Name(s4bldg, "secondaryAirFlowRateMin") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:secondaryApparentPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The power in VA (volt ampere) that has been transformed and is running out of the transformer on the secondary side. Usually measured in Watts (W, J/s)."</para>
    /// labels<para>"secondary apparent power"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/secondaryApparentPower">https://saref.etsi.org/saref4bldg/secondaryApparentPower</seealso>
    let secondaryApparentPower =
        Prefixed_Name(s4bldg, "secondaryApparentPower") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:secondaryCurrent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The current that has been transformed and is running out of the transformer on the secondary side. Usually measured in Ampere (A)."</para>
    /// labels<para>"secondary current"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/secondaryCurrent">https://saref.etsi.org/saref4bldg/secondaryCurrent</seealso>
    let secondaryCurrent = Prefixed_Name(s4bldg, "secondaryCurrent") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:secondaryCurrentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A list of the secondary current types that can result from transformer output."</para>
    /// labels<para>"secondary current type"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/secondaryCurrentType">https://saref.etsi.org/saref4bldg/secondaryCurrentType</seealso>
    let secondaryCurrentType =
        Prefixed_Name(s4bldg, "secondaryCurrentType") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:secondaryFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The frequency that has been transformed and is running out of the transformer on the secondary side. Usually measured in cycles/s or Hertz (Hz)."</para>
    /// labels<para>"secondary frequency"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/secondaryFrequency">https://saref.etsi.org/saref4bldg/secondaryFrequency</seealso>
    let secondaryFrequency = Prefixed_Name(s4bldg, "secondaryFrequency") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:secondaryVoltage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The voltage that has been transformed and is running out of the transformer on the secondary side. Usually measured in Volts (V, W/A)."</para>
    /// labels<para>"secondary voltage"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/secondaryVoltage">https://saref.etsi.org/saref4bldg/secondaryVoltage</seealso>
    let secondaryVoltage = Prefixed_Name(s4bldg, "secondaryVoltage") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:shadingDeviceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies the type of shading device."</para>
    /// labels<para>"shading device type"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/shadingDeviceType">https://saref.etsi.org/saref4bldg/shadingDeviceType</seealso>
    let shadingDeviceType = Prefixed_Name(s4bldg, "shadingDeviceType") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:shortCircuitVoltage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A complex number that specifies the real and imaginary parts of the short-circuit voltage at rated current of a transformer given in %."</para>
    /// labels<para>"short circuit voltage"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/shortCircuitVoltage">https://saref.etsi.org/saref4bldg/shortCircuitVoltage</seealso>
    let shortCircuitVoltage =
        Prefixed_Name(s4bldg, "shortCircuitVoltage") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:size</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The size of the connection to the valve (or to each connection for faucets, mixing valves, etc.). Usually measured in millimeters (mm)."</para>
    /// labels<para>"size"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/size">https://saref.etsi.org/saref4bldg/size</seealso>
    let size = Prefixed_Name(s4bldg, "size") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:solarReflectance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"(Rsol): The ratio of incident solar radiation that is reflected by a shading system (also named _e). Note the following equation Asol + Rsol + Tsol = 1"</para>
    /// labels<para>"solar reflectance"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/solarReflectance">https://saref.etsi.org/saref4bldg/solarReflectance</seealso>
    let solarReflectance = Prefixed_Name(s4bldg, "solarReflectance") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:solarTransmittance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"(Tsol) The ratio of incident solar radiation that directly passes through a shading system (also named _e). Note the following equation Asol + Rsol + Tsol = 1"</para>
    /// labels<para>"solar transmittance"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/solarTransmittance">https://saref.etsi.org/saref4bldg/solarTransmittance</seealso>
    let solarTransmittance = Prefixed_Name(s4bldg, "solarTransmittance") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:spectrumMax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The spectrum of radiation describes its composition with regard to wavelength. Light, for example, as the portion of electromagnetic radiation that is visible to the human eye, is radiation with wavelengths in the range of approx. 380 to 780 nm (1 nm = 10 m). The corresponding range of colours varies from violet to indigo, blue, green, yellow, orange, and red. These colours form a continuous spectrum, in which the various spectral sectors merge into each other."</para>
    /// labels<para>"maximum spectrum"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/spectrumMax">https://saref.etsi.org/saref4bldg/spectrumMax</seealso>
    let spectrumMax = Prefixed_Name(s4bldg, "spectrumMax") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:spectrumMin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The spectrum of radiation describes its composition with regard to wavelength. Light, for example, as the portion of electromagnetic radiation that is visible to the human eye, is radiation with wavelengths in the range of approx. 380 to 780 nm (1 nm = 10 m). The corresponding range of colours varies from violet to indigo, blue, green, yellow, orange, and red. These colours form a continuous spectrum, in which the various spectral sectors merge into each other."</para>
    /// labels<para>"minimum spectrum"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/spectrumMin">https://saref.etsi.org/saref4bldg/spectrumMin</seealso>
    let spectrumMin = Prefixed_Name(s4bldg, "spectrumMin") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:sprayType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"SprayFilled: Water is sprayed into airflow. SplashTypeFill: water cascades over successive rows of splash bars. FilmTypeFill: water flows in a thin layer over closely spaced sheets."</para>
    /// labels<para>"spray type"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/sprayType">https://saref.etsi.org/saref4bldg/sprayType</seealso>
    let sprayType = Prefixed_Name(s4bldg, "sprayType") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:staggeredRowSpacing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Staggered tube row spacing. Usually measured in millimeters (mm)."</para>
    /// labels<para>"staggered row spacing"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/staggeredRowSpacing">https://saref.etsi.org/saref4bldg/staggeredRowSpacing</seealso>
    let staggeredRowSpacing =
        Prefixed_Name(s4bldg, "staggeredRowSpacing") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:standard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The designation of the standard applicable for the definition of the characteristics of the unit."</para>
    /// labels<para>"standard"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/standard">https://saref.etsi.org/saref4bldg/standard</seealso>
    let standard = Prefixed_Name(s4bldg, "standard") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:startCurrentFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"IEC. Start current factor defines how large the peek starting current will become on the engine. StartCurrentFactor is multiplied to NominalCurrent and we get the start current."</para>
    /// labels<para>"start current factor"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/startCurrentFactor">https://saref.etsi.org/saref4bldg/startCurrentFactor</seealso>
    let startCurrentFactor = Prefixed_Name(s4bldg, "startCurrentFactor") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:startingTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The time (in s) needed for the motor to reach its rated speed with its driven equipment attached, starting from standstill and at the nominal voltage applied at its terminals."</para>
    /// labels<para>"starting time"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/startingTime">https://saref.etsi.org/saref4bldg/startingTime</seealso>
    let startingTime = Prefixed_Name(s4bldg, "startingTime") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:storageType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Defines the general material category intended to be stored."</para>
    /// labels<para>"storage type"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/storageType">https://saref.etsi.org/saref4bldg/storageType</seealso>
    let storageType = Prefixed_Name(s4bldg, "storageType") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:supportedWeightMax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The maximum weight that can be carried by the vibration isolator. Usually measured in kilograms (kg) or grams (g)."</para>
    /// labels<para>"maximum supported weight"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/supportedWeightMax">https://saref.etsi.org/saref4bldg/supportedWeightMax</seealso>
    let supportedWeightMax = Prefixed_Name(s4bldg, "supportedWeightMax") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:switchFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates types of switches which differs in functionality."</para>
    /// labels<para>"switch function"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/switchFunction">https://saref.etsi.org/saref4bldg/switchFunction</seealso>
    let switchFunction = Prefixed_Name(s4bldg, "switchFunction") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:teTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The maximum time (in s) at which the motor could run with locked rotor when the motor is used in an EX-environment. The time indicates that a protective device should trip before this time when the starting current of the motor is slowing through the device."</para>
    /// labels<para>"te time"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/teTime">https://saref.etsi.org/saref4bldg/teTime</seealso>
    let teTime = Prefixed_Name(s4bldg, "teTime") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:temperatureClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Enumeration defining the temperature classification of the space heater surface temperature. low temperature - surface temperature is relatively low, usually heated by hot water or electricity. high temperature - surface temperature is relatively high, usually heated by gas or steam."</para>
    /// labels<para>"temperature classification"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/temperatureClassification">https://saref.etsi.org/saref4bldg/temperatureClassification</seealso>
    let temperatureClassification =
        Prefixed_Name(s4bldg, "temperatureClassification") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:temperatureRating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Temperature rating. Usually measured in degrees Kelvin (K)."</para>
    /// labels<para>"temperature rating"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/temperatureRating">https://saref.etsi.org/saref4bldg/temperatureRating</seealso>
    let temperatureRating = Prefixed_Name(s4bldg, "temperatureRating") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:testPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The maximum pressure to which the valve has been subjected under test. Usually measured in Pascals (Pa, N/m2)."</para>
    /// labels<para>"test pressure"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/testPressure">https://saref.etsi.org/saref4bldg/testPressure</seealso>
    let testPressure = Prefixed_Name(s4bldg, "testPressure") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:thermalConductivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Fouling factor of the tubes in the tube bundle. Usually measured in m2 Kelvin/Watt."</para>
    /// labels<para>"thermal conductivity"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/thermalConductivity">https://saref.etsi.org/saref4bldg/thermalConductivity</seealso>
    let thermalConductivity =
        Prefixed_Name(s4bldg, "thermalConductivity") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:thermalEfficiency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Overall Thermal Efficiency is defined as gross energy output of the heat transfer device divided by the energy input."</para>
    /// labels<para>"thermal efficiency"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/thermalEfficiency">https://saref.etsi.org/saref4bldg/thermalEfficiency</seealso>
    let thermalEfficiency = Prefixed_Name(s4bldg, "thermalEfficiency") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:thermalMassHeatCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Product of component mass and specific heat."</para>
    /// labels<para>"thermal mass heat capacity"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/thermalMassHeatCapacity">https://saref.etsi.org/saref4bldg/thermalMassHeatCapacity</seealso>
    let thermalMassHeatCapacity =
        Prefixed_Name(s4bldg, "thermalMassHeatCapacity") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:thermalTransmittance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Rate at which energy is transmitted through a body. Usually measured in Watts/m2 Kelvin."</para>
    /// labels<para>"thermal transmittance"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/thermalTransmittance">https://saref.etsi.org/saref4bldg/thermalTransmittance</seealso>
    let thermalTransmittance =
        Prefixed_Name(s4bldg, "thermalTransmittance") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:transformerVectorGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"List of the possible vector groups for the transformer from which that required may be set. Values in the enumeration list follow a standard international code where the first letter describes how the primary windings are connected, the second letter describes how the secondary windings are connected, and the numbers describe the rotation of voltages and currents from the primary to the secondary side in multiples of 30 degrees. D: means that the windings are delta-connected. Y: means that the windings are star-connected. Z: means that the windings are zig-zag connected (a special start-connected providing low reactance of the transformer). The connectivity is only relevant for three-phase transformers."</para>
    /// labels<para>"transformer vector group"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/transformerVectorGroup">https://saref.etsi.org/saref4bldg/transformerVectorGroup</seealso>
    let transformerVectorGroup =
        Prefixed_Name(s4bldg, "transformerVectorGroup") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:v1.1.2/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/v1.1.2/">https://saref.etsi.org/saref4bldg/v1.1.2/</seealso>
    let ``v1.1.2/`` = Prefixed_Name(s4bldg, "v1.1.2/") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:valveMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The mechanism by which the valve function is achieved where: BALL: Valve that has a ported ball that can be turned relative to the body seat ports. BUTTERFLY: Valve in which a streamlined disc pivots about a diametric axis. CONFIGUREDGATE: Screwdown valve in which the closing gate is shaped in a configured manner to have a more precise control of pressure and flow change across the valve. GLAND: Valve with a tapered seating, in which a rotatable plug is retained by means of a gland and gland packing. GLOBE: Screwdown valve that has a spherical body. LUBRICATEDPLUG: Plug valve in which a lubricant is injected under pressure between the plug face and the body. NEEDLE: Valve for regulating the flow in or from a pipe, in which a slender cone moves along the axis of flow to close against a fixed conical seat. PARALLELSLIDE: Screwdown valve that has a machined plate that slides in formed grooves to form a seal. PLUG: Valve that has a ported plug that can be turned relative to the body seat ports. WEDGEGATE: Screwdown valve that has a wedge shaped plate fitting into tapered guides to form a seal."</para>
    /// labels<para>"valve mechanism"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/valveMechanism">https://saref.etsi.org/saref4bldg/valveMechanism</seealso>
    let valveMechanism = Prefixed_Name(s4bldg, "valveMechanism") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:valveOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The method of valve operation where: DROPWEIGHT: A valve that is closed by the action of a weighted lever being released, the weight normally being prevented from dropping by being held by a wire, the closure normally being made by the action of heat on a fusible link in the wire FLOAT: A valve that is opened and closed by the action of a float that rises and falls with water level. The float may be a ball attached to a lever or other mechanism HYDRAULIC: A valve that is opened and closed by hydraulic actuation LEVER: A valve that is opened and closed by the action of a lever rotating the gate within the valve. LOCKSHIELD: A valve that requires the use of a special lockshield key for opening and closing, the operating mechanism being protected by a shroud during normal operation. MOTORIZED: A valve that is opened and closed by the action of an electric motor on an actuator PNEUMATIC: A valve that is opened and closed by pneumatic actuation SOLENOID: A valve that is normally held open by a magnetic field in a coil acting on the gate but that is closed immediately if the electrical current generating the magnetic field is removed. SPRING: A valve that is normally held in position by the pressure of a spring on a plate but that may be caused to open if the pressure of the fluid is sufficient to overcome the spring pressure. THERMOSTATIC: A valve in which the ports are opened or closed to maintain a required predetermined temperature. WHEEL: A valve that is opened and closed by the action of a wheel moving the gate within the valve."</para>
    /// labels<para>"valve operation"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/valveOperation">https://saref.etsi.org/saref4bldg/valveOperation</seealso>
    let valveOperation = Prefixed_Name(s4bldg, "valveOperation") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:valvePattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The configuration of the ports of a valve according to either the linear route taken by a fluid flowing through the valve or by the number of ports where: SINGLEPORT: Valve that has a single entry port from the system that it serves, the exit port being to the surrounding environment. ANGLED_2_PORT: Valve in which the direction of flow is changed through 90 degrees. STRAIGHT_2_PORT: Valve in which the flow is straight through. STRAIGHT_3_PORT: Valve with three separate ports. CROSSOVER_4_PORT: Valve with 4 separate ports."</para>
    /// labels<para>"valve pattern"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/valvePattern">https://saref.etsi.org/saref4bldg/valvePattern</seealso>
    let valvePattern = Prefixed_Name(s4bldg, "valvePattern") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:ventilatingPipeSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Size of the ventilating pipe(s). Usually measured in millimeters (mm)."</para>
    /// labels<para>"ventilating pipe size"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/ventilatingPipeSize">https://saref.etsi.org/saref4bldg/ventilatingPipeSize</seealso>
    let ventilatingPipeSize =
        Prefixed_Name(s4bldg, "ventilatingPipeSize") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:verticalSpacing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Vertical spacing between tubes in the tube bundle.Usually measured in millimeters (mm)."</para>
    /// labels<para>"vertical spacing"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/verticalSpacing">https://saref.etsi.org/saref4bldg/verticalSpacing</seealso>
    let verticalSpacing = Prefixed_Name(s4bldg, "verticalSpacing") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:vibrationTransmissibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The vibration transmissibility percentage."</para>
    /// labels<para>"vibration transmissibility"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/vibrationTransmissibility">https://saref.etsi.org/saref4bldg/vibrationTransmissibility</seealso>
    let vibrationTransmissibility =
        Prefixed_Name(s4bldg, "vibrationTransmissibility") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:visibleLightReflectance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Fraction of the visible light that is reflected by the glazing at normal incidence. It is a value without unit."</para>
    /// labels<para>"visible light reflectance"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/visibleLightReflectance">https://saref.etsi.org/saref4bldg/visibleLightReflectance</seealso>
    let visibleLightReflectance =
        Prefixed_Name(s4bldg, "visibleLightReflectance") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:visibleLightTransmittance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Fraction of the visible light that passes the shading system at normal incidence. It is a value without unit."</para>
    /// labels<para>"visible light transmittance"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/visibleLightTransmittance">https://saref.etsi.org/saref4bldg/visibleLightTransmittance</seealso>
    let visibleLightTransmittance =
        Prefixed_Name(s4bldg, "visibleLightTransmittance") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:volumen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Total volume of fluid in the tubes and their headers. Usually measured in cubic metre (m3)."</para>
    /// labels<para>"volumen"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/volumen">https://saref.etsi.org/saref4bldg/volumen</seealso>
    let volumen = Prefixed_Name(s4bldg, "volumen") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:waterFlowControlSystemType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Factory fitted waterflow control system."</para>
    /// labels<para>"water flow control system type"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/waterFlowControlSystemType">https://saref.etsi.org/saref4bldg/waterFlowControlSystemType</seealso>
    let waterFlowControlSystemType =
        Prefixed_Name(s4bldg, "waterFlowControlSystemType") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:waterInletTemperatureMax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Allowable water inlet temperature range. Usually measured in degrees Kelvin (K)."</para>
    /// labels<para>"water inlet temperature range"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/waterInletTemperatureMax">https://saref.etsi.org/saref4bldg/waterInletTemperatureMax</seealso>
    let waterInletTemperatureMax =
        Prefixed_Name(s4bldg, "waterInletTemperatureMax") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:waterInletTemperatureMin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Allowable water inlet temperature range. Usually measured in degrees Kelvin (K)."</para>
    /// labels<para>"water inlet temperature range"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/waterInletTemperatureMin">https://saref.etsi.org/saref4bldg/waterInletTemperatureMin</seealso>
    let waterInletTemperatureMin =
        Prefixed_Name(s4bldg, "waterInletTemperatureMin") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:waterPressureMax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Allowable water circuit working pressure range. Usually measured in Pascals (Pa, N/m2)."</para>
    /// labels<para>"water pressure range"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/waterPressureMax">https://saref.etsi.org/saref4bldg/waterPressureMax</seealso>
    let waterPressureMax = Prefixed_Name(s4bldg, "waterPressureMax") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:waterPressureMin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Allowable water circuit working pressure range. Usually measured in Pascals (Pa, N/m2)."</para>
    /// labels<para>"water pressure range"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/waterPressureMin">https://saref.etsi.org/saref4bldg/waterPressureMin</seealso>
    let waterPressureMin = Prefixed_Name(s4bldg, "waterPressureMin") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:waterRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Make-up water requirement. Usually measured in m3/s."</para>
    /// labels<para>"water requirement"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/waterRequirement">https://saref.etsi.org/saref4bldg/waterRequirement</seealso>
    let waterRequirement = Prefixed_Name(s4bldg, "waterRequirement") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:waterStorageCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Water storage capacity. Usually measured in cubic metre (m3)."</para>
    /// labels<para>"water storage capacity"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/waterStorageCapacity">https://saref.etsi.org/saref4bldg/waterStorageCapacity</seealso>
    let waterStorageCapacity =
        Prefixed_Name(s4bldg, "waterStorageCapacity") |> PrefixedName

    /// <summary>
    ///   <para>s4bldg:weight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The weight of the device. Usually measured in kilograms (kg) or grams (g)."</para>
    /// labels<para>"weight"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/weight">https://saref.etsi.org/saref4bldg/weight</seealso>
    let weight = Prefixed_Name(s4bldg, "weight") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:workingPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The normally expected maximum working pressure of the valve. Usually measured in Pascals (Pa, N/m2)."</para>
    /// labels<para>"working pressure"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/workingPressure">https://saref.etsi.org/saref4bldg/workingPressure</seealso>
    let workingPressure = Prefixed_Name(s4bldg, "workingPressure") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:workingPressureMax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Maximum working pressure. Usually measured in Pascals (Pa, N/m2)."</para>
    /// labels<para>"maximum working pressure"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/workingPressureMax">https://saref.etsi.org/saref4bldg/workingPressureMax</seealso>
    let workingPressureMax = Prefixed_Name(s4bldg, "workingPressureMax") |> PrefixedName
    /// <summary>
    ///   <para>s4bldg:workingPressureMin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Allowable minimum working pressure (relative to ambient pressure). Usually measured in Pascals (Pa, N/m2)."</para>
    /// labels<para>"minimum working pressure"</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4bldg/workingPressureMin">https://saref.etsi.org/saref4bldg/workingPressureMin</seealso>
    let workingPressureMin = Prefixed_Name(s4bldg, "workingPressureMin") |> PrefixedName
