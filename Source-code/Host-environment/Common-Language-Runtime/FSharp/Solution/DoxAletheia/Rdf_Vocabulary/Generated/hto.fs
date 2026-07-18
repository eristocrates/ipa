namespace http.vcharpenay.github.io.hto.hto.xml.hash

open DoxAletheia.Rdf_Vocabulary

module hto =
    let _namespace_name = "http://vcharpenay.github.io/hto/hto.xml#"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Equipment"></see>
    /// </summary>
    let Equipment = Namespaced_IRI.parse _namespace_name "Equipment" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Point"></see>
    /// </summary>
    let Point = Namespaced_IRI.parse _namespace_name "Point" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Site"></see>
    /// </summary>
    let Site = Namespaced_IRI.parse _namespace_name "Site" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#AHU"></see>
    /// </summary>
    let AHU = Namespaced_IRI.parse _namespace_name "AHU" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#HVAC"></see>
    /// </summary>
    let HVAC = Namespaced_IRI.parse _namespace_name "HVAC" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Air"></see>
    /// </summary>
    let Air = Namespaced_IRI.parse _namespace_name "Air" |> NamespacedName

    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#PhysicalBody"></see>
    /// </summary>
    let PhysicalBody =
        Namespaced_IRI.parse _namespace_name "PhysicalBody" |> NamespacedName

    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Boiler"></see>
    /// </summary>
    let Boiler = Namespaced_IRI.parse _namespace_name "Boiler" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#CO2"></see>
    /// </summary>
    let CO2 = Namespaced_IRI.parse _namespace_name "CO2" |> NamespacedName

    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Measurement"></see>
    /// </summary>
    let Measurement =
        Namespaced_IRI.parse _namespace_name "Measurement" |> NamespacedName

    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#ChilledSystem"></see>
    /// </summary>
    let ChilledSystem =
        Namespaced_IRI.parse _namespace_name "ChilledSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Section"></see>
    /// </summary>
    let Section = Namespaced_IRI.parse _namespace_name "Section" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Chiller"></see>
    /// </summary>
    let Chiller = Namespaced_IRI.parse _namespace_name "Chiller" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Command"></see>
    /// </summary>
    let Command = Namespaced_IRI.parse _namespace_name "Command" |> NamespacedName

    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#CondenserSystem"></see>
    /// </summary>
    let CondenserSystem =
        Namespaced_IRI.parse _namespace_name "CondenserSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#CoolingCoil"></see>
    /// </summary>
    let CoolingCoil =
        Namespaced_IRI.parse _namespace_name "CoolingCoil" |> NamespacedName

    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Discharge"></see>
    /// </summary>
    let Discharge = Namespaced_IRI.parse _namespace_name "Discharge" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Efficiency"></see>
    /// </summary>
    let Efficiency = Namespaced_IRI.parse _namespace_name "Efficiency" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Entering"></see>
    /// </summary>
    let Entering = Namespaced_IRI.parse _namespace_name "Entering" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#HEntity"></see>
    /// </summary>
    let HEntity = Namespaced_IRI.parse _namespace_name "HEntity" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Exhaust"></see>
    /// </summary>
    let Exhaust = Namespaced_IRI.parse _namespace_name "Exhaust" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Fan"></see>
    /// </summary>
    let Fan = Namespaced_IRI.parse _namespace_name "Fan" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Flow"></see>
    /// </summary>
    let Flow = Namespaced_IRI.parse _namespace_name "Flow" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Frequency"></see>
    /// </summary>
    let Frequency = Namespaced_IRI.parse _namespace_name "Frequency" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Gas"></see>
    /// </summary>
    let Gas = Namespaced_IRI.parse _namespace_name "Gas" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#HTag"></see>
    /// </summary>
    let HTag = Namespaced_IRI.parse _namespace_name "HTag" |> NamespacedName

    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#HeatingCoil"></see>
    /// </summary>
    let HeatingCoil =
        Namespaced_IRI.parse _namespace_name "HeatingCoil" |> NamespacedName

    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Historized"></see>
    /// </summary>
    let Historized = Namespaced_IRI.parse _namespace_name "Historized" |> NamespacedName

    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#PointProperty"></see>
    /// </summary>
    let PointProperty =
        Namespaced_IRI.parse _namespace_name "PointProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Humidity"></see>
    /// </summary>
    let Humidity = Namespaced_IRI.parse _namespace_name "Humidity" |> NamespacedName

    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#IsolationValve"></see>
    /// </summary>
    let IsolationValve =
        Namespaced_IRI.parse _namespace_name "IsolationValve" |> NamespacedName

    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Valve"></see>
    /// </summary>
    let Valve = Namespaced_IRI.parse _namespace_name "Valve" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Leaving"></see>
    /// </summary>
    let Leaving = Namespaced_IRI.parse _namespace_name "Leaving" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#LightLevel"></see>
    /// </summary>
    let LightLevel = Namespaced_IRI.parse _namespace_name "LightLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#LightsGroup"></see>
    /// </summary>
    let LightsGroup =
        Namespaced_IRI.parse _namespace_name "LightsGroup" |> NamespacedName

    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Meter"></see>
    /// </summary>
    let Meter = Namespaced_IRI.parse _namespace_name "Meter" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Mixed"></see>
    /// </summary>
    let Mixed = Namespaced_IRI.parse _namespace_name "Mixed" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#OnOff"></see>
    /// </summary>
    let OnOff = Namespaced_IRI.parse _namespace_name "OnOff" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Percentage"></see>
    /// </summary>
    let Percentage = Namespaced_IRI.parse _namespace_name "Percentage" |> NamespacedName

    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#PerimeterHeat"></see>
    /// </summary>
    let PerimeterHeat =
        Namespaced_IRI.parse _namespace_name "PerimeterHeat" |> NamespacedName

    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Power"></see>
    /// </summary>
    let Power = Namespaced_IRI.parse _namespace_name "Power" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Pressure"></see>
    /// </summary>
    let Pressure = Namespaced_IRI.parse _namespace_name "Pressure" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Pump"></see>
    /// </summary>
    let Pump = Namespaced_IRI.parse _namespace_name "Pump" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#VFD"></see>
    /// </summary>
    let VFD = Namespaced_IRI.parse _namespace_name "VFD" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#RTU"></see>
    /// </summary>
    let RTU = Namespaced_IRI.parse _namespace_name "RTU" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#RealTime"></see>
    /// </summary>
    let RealTime = Namespaced_IRI.parse _namespace_name "RealTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#RefrigerantSubstance"></see>
    /// </summary>
    let RefrigerantSubstance =
        Namespaced_IRI.parse _namespace_name "RefrigerantSubstance" |> NamespacedName

    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Return"></see>
    /// </summary>
    let Return = Namespaced_IRI.parse _namespace_name "Return" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Sensor"></see>
    /// </summary>
    let Sensor = Namespaced_IRI.parse _namespace_name "Sensor" |> NamespacedName

    /// <summary>
    /// gives the OWL class defined in the present ontology that should be associated to the individual defined as subject.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#associatedTo"></see></summary>
    let associatedTo =
        Namespaced_IRI.parse _namespace_name "associatedTo" |> NamespacedName

    /// <summary>
    ///   Classifies a `point` as an input, AI/BI, or sensor.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#sensor"></see></summary>
    let sensor = Namespaced_IRI.parse _namespace_name "sensor" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#SetPoint"></see>
    /// </summary>
    let SetPoint = Namespaced_IRI.parse _namespace_name "SetPoint" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Speed"></see>
    /// </summary>
    let Speed = Namespaced_IRI.parse _namespace_name "Speed" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Steam"></see>
    /// </summary>
    let Steam = Namespaced_IRI.parse _namespace_name "Steam" |> NamespacedName

    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Temperature"></see>
    /// </summary>
    let Temperature =
        Namespaced_IRI.parse _namespace_name "Temperature" |> NamespacedName

    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#VAV"></see>
    /// </summary>
    let VAV = Namespaced_IRI.parse _namespace_name "VAV" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#VFDFan"></see>
    /// </summary>
    let VFDFan = Namespaced_IRI.parse _namespace_name "VFDFan" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Water"></see>
    /// </summary>
    let Water = Namespaced_IRI.parse _namespace_name "Water" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Writable"></see>
    /// </summary>
    let Writable = Namespaced_IRI.parse _namespace_name "Writable" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Zone"></see>
    /// </summary>
    let Zone = Namespaced_IRI.parse _namespace_name "Zone" |> NamespacedName
    /// <summary>
    ///   Air Handler Unit which heats and/or cools air.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#ahu"></see></summary>
    let ahu = Namespaced_IRI.parse _namespace_name "ahu" |> NamespacedName
    /// <summary>
    ///   Point associated with the measurement or control of air. In regards to `wetBulb`, points with the 'air' tag are associated with dry bulb.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#air"></see></summary>
    let air = Namespaced_IRI.parse _namespace_name "air" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#belongsTo"></see>
    /// </summary>
    let belongsTo = Namespaced_IRI.parse _namespace_name "belongsTo" |> NamespacedName
    /// <summary>
    /// note: does not fully implement specification (no boilerPlant). However, is still a TODO in project Haystack.
    ///   Boiler `equip` used to generate hot water or steam for heating.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#boiler"></see></summary>
    let boiler = Namespaced_IRI.parse _namespace_name "boiler" |> NamespacedName
    /// <summary>
    ///   If used with `valve` indicates a by-pass in a piping system. If used in combination with the `damper` tag on an `ahu` to indicate a damper in the ductwork to by-pass the VAV boxs and create a direct circuit between the discharge and return of the unit.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#bypass"></see></summary>
    let bypass = Namespaced_IRI.parse _namespace_name "bypass" |> NamespacedName
    /// <summary>
    ///   Marker tag used with `water` for the chilled water system between `chiller` and `ahu`.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#chilled"></see></summary>
    let chilled = Namespaced_IRI.parse _namespace_name "chilled" |> NamespacedName
    /// <summary>
    /// note: does not fully implement specification (no chillerPlant, no CoolingTower).
    ///   Chillers remove heat from a liquid via a vapor compression or an absorption refrigeration cycle.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#chiller"></see></summary>
    let chiller = Namespaced_IRI.parse _namespace_name "chiller" |> NamespacedName
    /// <summary>
    ///   Classifies a `point` as an output, AO/BO, command, or actuator.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#cmd"></see></summary>
    let cmd = Namespaced_IRI.parse _namespace_name "cmd" |> NamespacedName
    /// <summary>
    ///   Carbon dioxide level `point` measured in "ppm".
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#co2"></see></summary>
    let co2 = Namespaced_IRI.parse _namespace_name "co2" |> NamespacedName
    /// <summary>
    ///   When combined with the `water` tag, this indicates points in a condenser water system between a `chiller` and `coolingTower`. When used with the `refrig` tag, this indicates points on the condenser mechanism used to convert a refrigerant from its gaseous to liquid state. If paired with the `cmd` tag this tag indicates the command status of a condensor in a `chiller` modeled as true/false (on/off) or 0% to 100%.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#condenser"></see></summary>
    let condenser = Namespaced_IRI.parse _namespace_name "condenser" |> NamespacedName
    /// <summary>
    ///   Cooling coil as bool or numeric `point` used with `ahu` equip.  If multiple stages are used, then also specify the `stage` tag. If the cooling coil is controlled by a valve, then this point is mesaured from 0% to 100%, otherwise it should be a boolean point.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#cool"></see></summary>
    let cool = Namespaced_IRI.parse _namespace_name "cool" |> NamespacedName
    /// <summary>
    ///   Associated with the cooling mode of an HVAC system.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#cooling"></see></summary>
    let cooling = Namespaced_IRI.parse _namespace_name "cooling" |> NamespacedName
    /// <summary>
    /// note: indicates the measurement of how open the damper of a AHU is (0-100%)
    ///   Damper position measured from 0% (fully closed) to 100% (fully open).
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#damper"></see></summary>
    let damper = Namespaced_IRI.parse _namespace_name "damper" |> NamespacedName
    /// <summary>
    ///   Indicates a differential of `air`, `water`, or `steam` between the `entering` and `leaving` sensors.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#delta"></see></summary>
    let delta = Namespaced_IRI.parse _namespace_name "delta" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#dis"></see>
    /// </summary>
    let dis = Namespaced_IRI.parse _namespace_name "dis" |> NamespacedName
    /// <summary>
    ///   Associated with the discharge air an `ahu` or `vav`.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#discharge"></see></summary>
    let discharge = Namespaced_IRI.parse _namespace_name "discharge" |> NamespacedName
    /// <summary>
    ///   Used to indicate the effective setpoint which takes into account various other mode based setpoints the equip might define.  See [zone setpoints]`Zones#zonePoints` for complete example of how this tag is used.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#effective"></see></summary>
    let effective = Namespaced_IRI.parse _namespace_name "effective" |> NamespacedName
    /// <summary>
    ///   Efficiency point of a `chiller` measured in "COP" or "kW/ton".
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#efficiency"></see></summary>
    let efficiency = Namespaced_IRI.parse _namespace_name "efficiency" |> NamespacedName
    /// <summary>
    /// note: according to the documentation, is assocated to either point or equip
    ///   Used on `point` or `equip` entities relating to electricity. When paried with `meter` indicates a electric meter.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#elec"></see></summary>
    let elec = Namespaced_IRI.parse _namespace_name "elec" |> NamespacedName
    /// <summary>
    ///   Secondary on/off `point` of an `equip` especially used with a `vfd`. Enable is used with Bool points where true indicates on and false indicates off.  Equip with an enable should always also define a `run` point which indicates the primary on/off state of the equipment.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#enable"></see></summary>
    let enable = Namespaced_IRI.parse _namespace_name "enable" |> NamespacedName
    /// <summary>
    ///   Applied to `point` entities which measure energy consumption:   - Electric meters: "kWh"   - Thermal meters: "BTU"   - Gas meters: "mÂ³_gas"   - Chillers: "tonrefh"
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#energy"></see></summary>
    let energy = Namespaced_IRI.parse _namespace_name "energy" |> NamespacedName
    /// <summary>
    ///   Indicates `water` or `steam` entering a piece of equipment like a `boiler` or `chiller`.  Used with `vav` for air flow into the unit from the AHU.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#entering"></see></summary>
    let entering = Namespaced_IRI.parse _namespace_name "entering" |> NamespacedName
    /// <summary>
    ///   Indicates points on the evaporator mechanism used to convert a refrigerant from its liquid to gageous state.  It is often paired with the `refrig` marker tag.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#evaporator"></see></summary>
    let evaporator = Namespaced_IRI.parse _namespace_name "evaporator" |> NamespacedName
    /// <summary>
    ///   Associated with the exhaust air an `ahu`.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#exhaust"></see></summary>
    let exhaust = Namespaced_IRI.parse _namespace_name "exhaust" |> NamespacedName
    /// <summary>
    ///   A `point` of an `ahu` indicating air flow is by-passing the heating/cooling elements. If a boolean point, then true indicates the unit is in by-pass mode and false indicates by-pass is disabled.  If the point is an analog point then 100% indicates full by-pass mode and 0% that by-pass is completely disabled.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#faceBypass"></see></summary>
    let faceBypass = Namespaced_IRI.parse _namespace_name "faceBypass" |> NamespacedName
    /// <summary>
    /// note: according to the documentation, is assocated to either point or equip. Should use reasoning to choose the right one for a given HEntity
    ///   Fan `point` or `equip` associated with an `ahu`, `vav`, or `coolingTower`.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#fan"></see></summary>
    let fan = Namespaced_IRI.parse _namespace_name "fan" |> NamespacedName
    /// <summary>
    ///   Differential pressure across the filter of an `ahu`.  If a boolean point then true indicates successful airflow and false indicates a clogged filter.  If a numeric then the pressure differential should be measured in "inHâ‚‚O" or "kPa"
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#filter"></see></summary>
    let filter = Namespaced_IRI.parse _namespace_name "filter" |> NamespacedName
    /// <summary>
    ///   Marker tag on a `point` which measures rate of volume currently flowing through a flow meter, duct, or pipe .   - Air flow: "cfm" or "L/s"   - Gas/water flow: "gal/min" or "mÂ³/s"
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#flow"></see></summary>
    let flow = Namespaced_IRI.parse _namespace_name "flow" |> NamespacedName
    /// <summary>
    ///   A boolean `point` of an `ahu` indicating a freezing condition which might require a control sequence to protect the equipment. If true then a freeze condition is deteted, or false if not.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#freezeStat"></see></summary>
    let freezeStat = Namespaced_IRI.parse _namespace_name "freezeStat" |> NamespacedName
    /// <summary>
    ///   Electrical A/C frequency `point` measured in "Hz" for `elec` `meter` or a `vfd`.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#freq"></see></summary>
    let freq = Namespaced_IRI.parse _namespace_name "freq" |> NamespacedName
    /// <summary>
    ///   Used on `point` or `equip` entities relating to natural gas. When paried with `meter` indicates a gas meter.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#gas"></see></summary>
    let gas = Namespaced_IRI.parse _namespace_name "gas" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#hasRef"></see>
    /// </summary>
    let hasRef = Namespaced_IRI.parse _namespace_name "hasRef" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#isRefedBy"></see>
    /// </summary>
    let isRefedBy = Namespaced_IRI.parse _namespace_name "isRefedBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#hasSection"></see>
    /// </summary>
    let hasSection = Namespaced_IRI.parse _namespace_name "hasSection" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#hasTag"></see>
    /// </summary>
    let hasTag = Namespaced_IRI.parse _namespace_name "hasTag" |> NamespacedName
    /// <summary>
    ///   Heating coil as bool or float point on an `ahu` or `vav`. If multiple stages are used, then also specify the `stage` tag. If the heating coil is controlled by a valve, then this point is mesaured from 0% to 100%, otherwise it should be a boolean point.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#heat"></see></summary>
    let heat = Namespaced_IRI.parse _namespace_name "heat" |> NamespacedName
    /// <summary>
    ///   Bool `point` which models the on or off state of an `ahu` heat wheel.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#heatWheel"></see></summary>
    let heatWheel = Namespaced_IRI.parse _namespace_name "heatWheel" |> NamespacedName
    /// <summary>
    ///   Associated with the heating mode of an HVAC system.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#heating"></see></summary>
    let heating = Namespaced_IRI.parse _namespace_name "heating" |> NamespacedName
    /// <summary>
    ///   Boolean or numeric `point` of an `ahu` used to indicate if if the humidifier is on or off.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#humidifier"></see></summary>
    let humidifier = Namespaced_IRI.parse _namespace_name "humidifier" |> NamespacedName
    /// <summary>
    ///   Humidity measured from 0% to 100%.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#humidity"></see></summary>
    let humidity = Namespaced_IRI.parse _namespace_name "humidity" |> NamespacedName
    /// <summary>
    ///   Associated with HVAC (Heating, Ventilating, Air Conditioning)
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#hvac"></see></summary>
    let hvac = Namespaced_IRI.parse _namespace_name "hvac" |> NamespacedName
    /// <summary>
    ///   Indicates a `valve` used to isolate a piece of equipment from a piping system.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#isolation"></see></summary>
    let isolation = Namespaced_IRI.parse _namespace_name "isolation" |> NamespacedName
    /// <summary>
    ///   Indicates `water` or `steam` exiting a piece of equipment like a `boiler` or `chiller`.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#leaving"></see></summary>
    let leaving = Namespaced_IRI.parse _namespace_name "leaving" |> NamespacedName
    /// <summary>
    ///   Light level sensor point under `lightsGroup` measured in "lux" or "lumen".
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#lightLevel"></see></summary>
    let lightLevel = Namespaced_IRI.parse _namespace_name "lightLevel" |> NamespacedName
    /// <summary>
    /// note: according to the documentation, subsumes sensor. But associated here to a Measurement type and redundant with the tag lightLevel.
    ///   Lighting on/off status as a boolean or if dimmable a numeric between 0% and 100%.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#lights"></see></summary>
    let lights = Namespaced_IRI.parse _namespace_name "lights" |> NamespacedName

    /// <summary>
    ///   Equip level of the lighting system which is a group of one or more `lights` points.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#lightsGroup"></see></summary>
    let lightsGroup =
        Namespaced_IRI.parse _namespace_name "lightsGroup" |> NamespacedName

    /// <summary>
    ///   Models a `point` on a `chiller` used to command or measure the chiller's load as a percentage from "0%" to "100%".  When paired with `cmd` this models the chiller's load limit.  When paired with `sensor` this models the chiller's current load factor.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#load"></see></summary>
    let load = Namespaced_IRI.parse _namespace_name "load" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#locatedOn"></see>
    /// </summary>
    let locatedOn = Namespaced_IRI.parse _namespace_name "locatedOn" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#measuredOn"></see>
    /// </summary>
    let measuredOn = Namespaced_IRI.parse _namespace_name "measuredOn" |> NamespacedName
    /// <summary>
    ///   Equip which meters usage of `elec` energy, thermal energy, `gas`, `water` or `steam`.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#meter"></see></summary>
    let meter = Namespaced_IRI.parse _namespace_name "meter" |> NamespacedName
    /// <summary>
    ///   Associated with the mixed air of an `ahu`.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#mixed"></see></summary>
    let mixed = Namespaced_IRI.parse _namespace_name "mixed" |> NamespacedName

    /// <summary>
    /// note: according to the documentation, subsumes sensor. But associated here to a Measurement type. Similarly, lights and lightLevel tags both refer to the class LightLevel.
    ///   Occupancy sensor under `lightsGroup`.  Point must be Bool where true indicates occupied and false indicates unoccupied
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#occupancyIndicator"></see></summary>
    let occupancyIndicator =
        Namespaced_IRI.parse _namespace_name "occupancyIndicator" |> NamespacedName

    /// <summary>
    ///   Auxiliary heating points associated with a `vav`.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#perimeterHeat"></see></summary>
    let perimeterHeat =
        Namespaced_IRI.parse _namespace_name "perimeterHeat" |> NamespacedName

    /// <summary>
    ///   Data point such as a sensor or actuator.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#point"></see></summary>
    let point = Namespaced_IRI.parse _namespace_name "point" |> NamespacedName
    /// <summary>
    ///   Applied to `point` entities which measure energy consumed per unit time. For 'elec meter' this is the electrical demand.   - Electric meters: "kW"   - Thermal meters: "BTU/h"   - Chillers: "tonref" or "kW" refrigeration
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#power"></see></summary>
    let power = Namespaced_IRI.parse _namespace_name "power" |> NamespacedName
    /// <summary>
    ///   Static pressure associated with the measurement or control of fluids such as air, oxygen, water, steam, gas, oil, etc.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#pressure"></see></summary>
    let pressure = Namespaced_IRI.parse _namespace_name "pressure" |> NamespacedName
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#quantifies"></see>
    /// </summary>
    let quantifies = Namespaced_IRI.parse _namespace_name "quantifies" |> NamespacedName
    /// <summary>
    ///   Indicates points associated with the measurment or control of the refrigerant substance in a cooling system like a `chiller`.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#refrig"></see></summary>
    let refrig = Namespaced_IRI.parse _namespace_name "refrig" |> NamespacedName
    /// <summary>
    ///   Associated with the return air an `ahu`.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#return"></see></summary>
    let return_ = Namespaced_IRI.parse _namespace_name "return" |> NamespacedName
    /// <summary>
    ///   Used with `ahu` to mark an AHU as a packaged rooftop unit (RTU).
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#rooftop"></see></summary>
    let rooftop = Namespaced_IRI.parse _namespace_name "rooftop" |> NamespacedName
    /// <summary>
    /// note: according to the documentation, subsumes sensor. But associated here to a Measurement type.
    ///   Primary on/off `point` of an `equip` especially used with a `vfd`. Run is used with Bool points where true indicates on and false indicates off. When paired with `cmd` this is the commanded state of the equipment. When paired with `sensor` this is the actual status of the equip.  If the equipment also defines an `enable` point then both must be commanded on in order to run the equipment.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#run"></see></summary>
    let run = Namespaced_IRI.parse _namespace_name "run" |> NamespacedName
    /// <summary>
    ///   Classifies a `point` as a setpoint, soft point, or process control variable.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#sp"></see></summary>
    let sp = Namespaced_IRI.parse _namespace_name "sp" |> NamespacedName
    /// <summary>
    ///   Speed `point` of a `vfd` measured in "%" where 0% is off and 100% is the fastest speed.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#speed"></see></summary>
    let speed = Namespaced_IRI.parse _namespace_name "speed" |> NamespacedName
    /// <summary>
    ///   Point associated with the measurement or control of steam. This tag is often paired with `entering` versus `leaving` versus `delta`. It may also be paired with `meter` to indicate a steam meter.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#steam"></see></summary>
    let steam = Namespaced_IRI.parse _namespace_name "steam" |> NamespacedName
    /// <summary>
    ///   Temperature measured in Â°C or Â°F.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#temp"></see></summary>
    let temp = Namespaced_IRI.parse _namespace_name "temp" |> NamespacedName
    /// <summary>
    ///   Marker tag on `point` which indicates a valve used to regulate or control the flow or pressure of a fluid.  It is used with `cmd` to indicate the valve command: true/false (open/close) or 0% to 100%.  It may also be used with `sensor` to indicate a feedback sensor such as a voltage giving exact position between 0% and 100%.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#valve"></see></summary>
    let valve = Namespaced_IRI.parse _namespace_name "valve" |> NamespacedName
    /// <summary>
    ///   Variable Volume Volume supply duct `equip`.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#vav"></see></summary>
    let vav = Namespaced_IRI.parse _namespace_name "vav" |> NamespacedName
    /// <summary>
    ///   Marker for a motor `equip` with variable frequency drive.  Commonly used in combination with `fan` and `pump`.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#vfd"></see></summary>
    let vfd = Namespaced_IRI.parse _namespace_name "vfd" |> NamespacedName
    /// <summary>
    ///   Point associated with the measurement or control of water.  This tag is often paired:   - `entering` versus `leaving` versus `delta`   - `chilled` versus `condenser` It may also be paired with `meter` to indicate a water meter.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#water"></see></summary>
    let water = Namespaced_IRI.parse _namespace_name "water" |> NamespacedName
    /// <summary>
    ///   Associated with a conditioned [zone]`Zones` of a building.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#zone"></see></summary>
    let zone = Namespaced_IRI.parse _namespace_name "zone" |> NamespacedName
