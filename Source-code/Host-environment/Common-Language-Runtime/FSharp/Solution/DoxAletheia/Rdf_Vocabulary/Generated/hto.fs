namespace http.vcharpenay.github.io.hto.hto.xml.hash

open DoxAletheia

module hto =
    let _namespace_name = "http://vcharpenay.github.io/hto/hto.xml#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Equipment"></see>
    /// </summary>
    let Equipment = _prefix "Equipment"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Point"></see>
    /// </summary>
    let Point = _prefix "Point"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Site"></see>
    /// </summary>
    let Site = _prefix "Site"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#AHU"></see>
    /// </summary>
    let AHU = _prefix "AHU"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#HVAC"></see>
    /// </summary>
    let HVAC = _prefix "HVAC"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Air"></see>
    /// </summary>
    let Air = _prefix "Air"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#PhysicalBody"></see>
    /// </summary>
    let PhysicalBody = _prefix "PhysicalBody"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Boiler"></see>
    /// </summary>
    let Boiler = _prefix "Boiler"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#CO2"></see>
    /// </summary>
    let CO2 = _prefix "CO2"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Measurement"></see>
    /// </summary>
    let Measurement = _prefix "Measurement"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#ChilledSystem"></see>
    /// </summary>
    let ChilledSystem = _prefix "ChilledSystem"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Section"></see>
    /// </summary>
    let Section = _prefix "Section"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Chiller"></see>
    /// </summary>
    let Chiller = _prefix "Chiller"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Command"></see>
    /// </summary>
    let Command = _prefix "Command"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#CondenserSystem"></see>
    /// </summary>
    let CondenserSystem = _prefix "CondenserSystem"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#CoolingCoil"></see>
    /// </summary>
    let CoolingCoil = _prefix "CoolingCoil"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Discharge"></see>
    /// </summary>
    let Discharge = _prefix "Discharge"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Efficiency"></see>
    /// </summary>
    let Efficiency = _prefix "Efficiency"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Entering"></see>
    /// </summary>
    let Entering = _prefix "Entering"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#HEntity"></see>
    /// </summary>
    let HEntity = _prefix "HEntity"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Exhaust"></see>
    /// </summary>
    let Exhaust = _prefix "Exhaust"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Fan"></see>
    /// </summary>
    let Fan = _prefix "Fan"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Flow"></see>
    /// </summary>
    let Flow = _prefix "Flow"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Frequency"></see>
    /// </summary>
    let Frequency = _prefix "Frequency"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Gas"></see>
    /// </summary>
    let Gas = _prefix "Gas"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#HTag"></see>
    /// </summary>
    let HTag = _prefix "HTag"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#HeatingCoil"></see>
    /// </summary>
    let HeatingCoil = _prefix "HeatingCoil"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Historized"></see>
    /// </summary>
    let Historized = _prefix "Historized"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#PointProperty"></see>
    /// </summary>
    let PointProperty = _prefix "PointProperty"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Humidity"></see>
    /// </summary>
    let Humidity = _prefix "Humidity"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#IsolationValve"></see>
    /// </summary>
    let IsolationValve = _prefix "IsolationValve"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Valve"></see>
    /// </summary>
    let Valve = _prefix "Valve"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Leaving"></see>
    /// </summary>
    let Leaving = _prefix "Leaving"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#LightLevel"></see>
    /// </summary>
    let LightLevel = _prefix "LightLevel"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#LightsGroup"></see>
    /// </summary>
    let LightsGroup = _prefix "LightsGroup"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Meter"></see>
    /// </summary>
    let Meter = _prefix "Meter"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Mixed"></see>
    /// </summary>
    let Mixed = _prefix "Mixed"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#OnOff"></see>
    /// </summary>
    let OnOff = _prefix "OnOff"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Percentage"></see>
    /// </summary>
    let Percentage = _prefix "Percentage"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#PerimeterHeat"></see>
    /// </summary>
    let PerimeterHeat = _prefix "PerimeterHeat"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Power"></see>
    /// </summary>
    let Power = _prefix "Power"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Pressure"></see>
    /// </summary>
    let Pressure = _prefix "Pressure"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Pump"></see>
    /// </summary>
    let Pump = _prefix "Pump"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#VFD"></see>
    /// </summary>
    let VFD = _prefix "VFD"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#RTU"></see>
    /// </summary>
    let RTU = _prefix "RTU"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#RealTime"></see>
    /// </summary>
    let RealTime = _prefix "RealTime"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#RefrigerantSubstance"></see>
    /// </summary>
    let RefrigerantSubstance = _prefix "RefrigerantSubstance"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Return"></see>
    /// </summary>
    let Return = _prefix "Return"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Sensor"></see>
    /// </summary>
    let Sensor = _prefix "Sensor"
    /// <summary>
    /// gives the OWL class defined in the present ontology that should be associated to the individual defined as subject.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#associatedTo"></see></summary>
    let associatedTo = _prefix "associatedTo"
    /// <summary>
    ///   Classifies a `point` as an input, AI/BI, or sensor.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#sensor"></see></summary>
    let sensor = _prefix "sensor"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#SetPoint"></see>
    /// </summary>
    let SetPoint = _prefix "SetPoint"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Speed"></see>
    /// </summary>
    let Speed = _prefix "Speed"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Steam"></see>
    /// </summary>
    let Steam = _prefix "Steam"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Temperature"></see>
    /// </summary>
    let Temperature = _prefix "Temperature"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#VAV"></see>
    /// </summary>
    let VAV = _prefix "VAV"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#VFDFan"></see>
    /// </summary>
    let VFDFan = _prefix "VFDFan"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Water"></see>
    /// </summary>
    let Water = _prefix "Water"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Writable"></see>
    /// </summary>
    let Writable = _prefix "Writable"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#Zone"></see>
    /// </summary>
    let Zone = _prefix "Zone"
    /// <summary>
    ///   Air Handler Unit which heats and/or cools air.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#ahu"></see></summary>
    let ahu = _prefix "ahu"
    /// <summary>
    ///   Point associated with the measurement or control of air. In regards to `wetBulb`, points with the 'air' tag are associated with dry bulb.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#air"></see></summary>
    let air = _prefix "air"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#belongsTo"></see>
    /// </summary>
    let belongsTo = _prefix "belongsTo"
    /// <summary>
    /// note: does not fully implement specification (no boilerPlant). However, is still a TODO in project Haystack.
    ///   Boiler `equip` used to generate hot water or steam for heating.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#boiler"></see></summary>
    let boiler = _prefix "boiler"
    /// <summary>
    ///   If used with `valve` indicates a by-pass in a piping system. If used in combination with the `damper` tag on an `ahu` to indicate a damper in the ductwork to by-pass the VAV boxs and create a direct circuit between the discharge and return of the unit.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#bypass"></see></summary>
    let bypass = _prefix "bypass"
    /// <summary>
    ///   Marker tag used with `water` for the chilled water system between `chiller` and `ahu`.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#chilled"></see></summary>
    let chilled = _prefix "chilled"
    /// <summary>
    /// note: does not fully implement specification (no chillerPlant, no CoolingTower).
    ///   Chillers remove heat from a liquid via a vapor compression or an absorption refrigeration cycle.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#chiller"></see></summary>
    let chiller = _prefix "chiller"
    /// <summary>
    ///   Classifies a `point` as an output, AO/BO, command, or actuator.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#cmd"></see></summary>
    let cmd = _prefix "cmd"
    /// <summary>
    ///   Carbon dioxide level `point` measured in "ppm".
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#co2"></see></summary>
    let co2 = _prefix "co2"
    /// <summary>
    ///   When combined with the `water` tag, this indicates points in a condenser water system between a `chiller` and `coolingTower`. When used with the `refrig` tag, this indicates points on the condenser mechanism used to convert a refrigerant from its gaseous to liquid state. If paired with the `cmd` tag this tag indicates the command status of a condensor in a `chiller` modeled as true/false (on/off) or 0% to 100%.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#condenser"></see></summary>
    let condenser = _prefix "condenser"
    /// <summary>
    ///   Cooling coil as bool or numeric `point` used with `ahu` equip.  If multiple stages are used, then also specify the `stage` tag. If the cooling coil is controlled by a valve, then this point is mesaured from 0% to 100%, otherwise it should be a boolean point.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#cool"></see></summary>
    let cool = _prefix "cool"
    /// <summary>
    ///   Associated with the cooling mode of an HVAC system.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#cooling"></see></summary>
    let cooling = _prefix "cooling"
    /// <summary>
    /// note: indicates the measurement of how open the damper of a AHU is (0-100%)
    ///   Damper position measured from 0% (fully closed) to 100% (fully open).
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#damper"></see></summary>
    let damper = _prefix "damper"
    /// <summary>
    ///   Indicates a differential of `air`, `water`, or `steam` between the `entering` and `leaving` sensors.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#delta"></see></summary>
    let delta = _prefix "delta"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#dis"></see>
    /// </summary>
    let dis = _prefix "dis"
    /// <summary>
    ///   Associated with the discharge air an `ahu` or `vav`.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#discharge"></see></summary>
    let discharge = _prefix "discharge"
    /// <summary>
    ///   Used to indicate the effective setpoint which takes into account various other mode based setpoints the equip might define.  See [zone setpoints]`Zones#zonePoints` for complete example of how this tag is used.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#effective"></see></summary>
    let effective = _prefix "effective"
    /// <summary>
    ///   Efficiency point of a `chiller` measured in "COP" or "kW/ton".
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#efficiency"></see></summary>
    let efficiency = _prefix "efficiency"
    /// <summary>
    /// note: according to the documentation, is assocated to either point or equip
    ///   Used on `point` or `equip` entities relating to electricity. When paried with `meter` indicates a electric meter.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#elec"></see></summary>
    let elec = _prefix "elec"
    /// <summary>
    ///   Secondary on/off `point` of an `equip` especially used with a `vfd`. Enable is used with Bool points where true indicates on and false indicates off.  Equip with an enable should always also define a `run` point which indicates the primary on/off state of the equipment.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#enable"></see></summary>
    let enable = _prefix "enable"
    /// <summary>
    ///   Applied to `point` entities which measure energy consumption:   - Electric meters: "kWh"   - Thermal meters: "BTU"   - Gas meters: "mÂ³_gas"   - Chillers: "tonrefh"
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#energy"></see></summary>
    let energy = _prefix "energy"
    /// <summary>
    ///   Indicates `water` or `steam` entering a piece of equipment like a `boiler` or `chiller`.  Used with `vav` for air flow into the unit from the AHU.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#entering"></see></summary>
    let entering = _prefix "entering"
    /// <summary>
    ///   Indicates points on the evaporator mechanism used to convert a refrigerant from its liquid to gageous state.  It is often paired with the `refrig` marker tag.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#evaporator"></see></summary>
    let evaporator = _prefix "evaporator"
    /// <summary>
    ///   Associated with the exhaust air an `ahu`.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#exhaust"></see></summary>
    let exhaust = _prefix "exhaust"
    /// <summary>
    ///   A `point` of an `ahu` indicating air flow is by-passing the heating/cooling elements. If a boolean point, then true indicates the unit is in by-pass mode and false indicates by-pass is disabled.  If the point is an analog point then 100% indicates full by-pass mode and 0% that by-pass is completely disabled.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#faceBypass"></see></summary>
    let faceBypass = _prefix "faceBypass"
    /// <summary>
    /// note: according to the documentation, is assocated to either point or equip. Should use reasoning to choose the right one for a given HEntity
    ///   Fan `point` or `equip` associated with an `ahu`, `vav`, or `coolingTower`.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#fan"></see></summary>
    let fan = _prefix "fan"
    /// <summary>
    ///   Differential pressure across the filter of an `ahu`.  If a boolean point then true indicates successful airflow and false indicates a clogged filter.  If a numeric then the pressure differential should be measured in "inHâ‚‚O" or "kPa"
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#filter"></see></summary>
    let filter = _prefix "filter"
    /// <summary>
    ///   Marker tag on a `point` which measures rate of volume currently flowing through a flow meter, duct, or pipe .   - Air flow: "cfm" or "L/s"   - Gas/water flow: "gal/min" or "mÂ³/s"
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#flow"></see></summary>
    let flow = _prefix "flow"
    /// <summary>
    ///   A boolean `point` of an `ahu` indicating a freezing condition which might require a control sequence to protect the equipment. If true then a freeze condition is deteted, or false if not.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#freezeStat"></see></summary>
    let freezeStat = _prefix "freezeStat"
    /// <summary>
    ///   Electrical A/C frequency `point` measured in "Hz" for `elec` `meter` or a `vfd`.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#freq"></see></summary>
    let freq = _prefix "freq"
    /// <summary>
    ///   Used on `point` or `equip` entities relating to natural gas. When paried with `meter` indicates a gas meter.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#gas"></see></summary>
    let gas = _prefix "gas"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#hasRef"></see>
    /// </summary>
    let hasRef = _prefix "hasRef"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#isRefedBy"></see>
    /// </summary>
    let isRefedBy = _prefix "isRefedBy"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#hasSection"></see>
    /// </summary>
    let hasSection = _prefix "hasSection"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#hasTag"></see>
    /// </summary>
    let hasTag = _prefix "hasTag"
    /// <summary>
    ///   Heating coil as bool or float point on an `ahu` or `vav`. If multiple stages are used, then also specify the `stage` tag. If the heating coil is controlled by a valve, then this point is mesaured from 0% to 100%, otherwise it should be a boolean point.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#heat"></see></summary>
    let heat = _prefix "heat"
    /// <summary>
    ///   Bool `point` which models the on or off state of an `ahu` heat wheel.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#heatWheel"></see></summary>
    let heatWheel = _prefix "heatWheel"
    /// <summary>
    ///   Associated with the heating mode of an HVAC system.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#heating"></see></summary>
    let heating = _prefix "heating"
    /// <summary>
    ///   Boolean or numeric `point` of an `ahu` used to indicate if if the humidifier is on or off.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#humidifier"></see></summary>
    let humidifier = _prefix "humidifier"
    /// <summary>
    ///   Humidity measured from 0% to 100%.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#humidity"></see></summary>
    let humidity = _prefix "humidity"
    /// <summary>
    ///   Associated with HVAC (Heating, Ventilating, Air Conditioning)
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#hvac"></see></summary>
    let hvac = _prefix "hvac"
    /// <summary>
    ///   Indicates a `valve` used to isolate a piece of equipment from a piping system.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#isolation"></see></summary>
    let isolation = _prefix "isolation"
    /// <summary>
    ///   Indicates `water` or `steam` exiting a piece of equipment like a `boiler` or `chiller`.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#leaving"></see></summary>
    let leaving = _prefix "leaving"
    /// <summary>
    ///   Light level sensor point under `lightsGroup` measured in "lux" or "lumen".
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#lightLevel"></see></summary>
    let lightLevel = _prefix "lightLevel"
    /// <summary>
    /// note: according to the documentation, subsumes sensor. But associated here to a Measurement type and redundant with the tag lightLevel.
    ///   Lighting on/off status as a boolean or if dimmable a numeric between 0% and 100%.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#lights"></see></summary>
    let lights = _prefix "lights"
    /// <summary>
    ///   Equip level of the lighting system which is a group of one or more `lights` points.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#lightsGroup"></see></summary>
    let lightsGroup = _prefix "lightsGroup"
    /// <summary>
    ///   Models a `point` on a `chiller` used to command or measure the chiller's load as a percentage from "0%" to "100%".  When paired with `cmd` this models the chiller's load limit.  When paired with `sensor` this models the chiller's current load factor.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#load"></see></summary>
    let load = _prefix "load"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#locatedOn"></see>
    /// </summary>
    let locatedOn = _prefix "locatedOn"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#measuredOn"></see>
    /// </summary>
    let measuredOn = _prefix "measuredOn"
    /// <summary>
    ///   Equip which meters usage of `elec` energy, thermal energy, `gas`, `water` or `steam`.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#meter"></see></summary>
    let meter = _prefix "meter"
    /// <summary>
    ///   Associated with the mixed air of an `ahu`.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#mixed"></see></summary>
    let mixed = _prefix "mixed"
    /// <summary>
    /// note: according to the documentation, subsumes sensor. But associated here to a Measurement type. Similarly, lights and lightLevel tags both refer to the class LightLevel.
    ///   Occupancy sensor under `lightsGroup`.  Point must be Bool where true indicates occupied and false indicates unoccupied
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#occupancyIndicator"></see></summary>
    let occupancyIndicator = _prefix "occupancyIndicator"
    /// <summary>
    ///   Auxiliary heating points associated with a `vav`.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#perimeterHeat"></see></summary>
    let perimeterHeat = _prefix "perimeterHeat"
    /// <summary>
    ///   Data point such as a sensor or actuator.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#point"></see></summary>
    let point = _prefix "point"
    /// <summary>
    ///   Applied to `point` entities which measure energy consumed per unit time. For 'elec meter' this is the electrical demand.   - Electric meters: "kW"   - Thermal meters: "BTU/h"   - Chillers: "tonref" or "kW" refrigeration
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#power"></see></summary>
    let power = _prefix "power"
    /// <summary>
    ///   Static pressure associated with the measurement or control of fluids such as air, oxygen, water, steam, gas, oil, etc.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#pressure"></see></summary>
    let pressure = _prefix "pressure"
    /// <summary>
    ///   <see href="http://vcharpenay.github.io/hto/hto.xml#quantifies"></see>
    /// </summary>
    let quantifies = _prefix "quantifies"
    /// <summary>
    ///   Indicates points associated with the measurment or control of the refrigerant substance in a cooling system like a `chiller`.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#refrig"></see></summary>
    let refrig = _prefix "refrig"
    /// <summary>
    ///   Associated with the return air an `ahu`.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#return"></see></summary>
    let return_ = _prefix "return"
    /// <summary>
    ///   Used with `ahu` to mark an AHU as a packaged rooftop unit (RTU).
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#rooftop"></see></summary>
    let rooftop = _prefix "rooftop"
    /// <summary>
    /// note: according to the documentation, subsumes sensor. But associated here to a Measurement type.
    ///   Primary on/off `point` of an `equip` especially used with a `vfd`. Run is used with Bool points where true indicates on and false indicates off. When paired with `cmd` this is the commanded state of the equipment. When paired with `sensor` this is the actual status of the equip.  If the equipment also defines an `enable` point then both must be commanded on in order to run the equipment.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#run"></see></summary>
    let run = _prefix "run"
    /// <summary>
    ///   Classifies a `point` as a setpoint, soft point, or process control variable.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#sp"></see></summary>
    let sp = _prefix "sp"
    /// <summary>
    ///   Speed `point` of a `vfd` measured in "%" where 0% is off and 100% is the fastest speed.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#speed"></see></summary>
    let speed = _prefix "speed"
    /// <summary>
    ///   Point associated with the measurement or control of steam. This tag is often paired with `entering` versus `leaving` versus `delta`. It may also be paired with `meter` to indicate a steam meter.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#steam"></see></summary>
    let steam = _prefix "steam"
    /// <summary>
    ///   Temperature measured in Â°C or Â°F.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#temp"></see></summary>
    let temp = _prefix "temp"
    /// <summary>
    ///   Marker tag on `point` which indicates a valve used to regulate or control the flow or pressure of a fluid.  It is used with `cmd` to indicate the valve command: true/false (open/close) or 0% to 100%.  It may also be used with `sensor` to indicate a feedback sensor such as a voltage giving exact position between 0% and 100%.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#valve"></see></summary>
    let valve = _prefix "valve"
    /// <summary>
    ///   Variable Volume Volume supply duct `equip`.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#vav"></see></summary>
    let vav = _prefix "vav"
    /// <summary>
    ///   Marker for a motor `equip` with variable frequency drive.  Commonly used in combination with `fan` and `pump`.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#vfd"></see></summary>
    let vfd = _prefix "vfd"
    /// <summary>
    ///   Point associated with the measurement or control of water.  This tag is often paired:   - `entering` versus `leaving` versus `delta`   - `chilled` versus `condenser` It may also be paired with `meter` to indicate a water meter.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#water"></see></summary>
    let water = _prefix "water"
    /// <summary>
    ///   Associated with a conditioned [zone]`Zones` of a building.
    /// <see href="http://vcharpenay.github.io/hto/hto.xml#zone"></see></summary>
    let zone = _prefix "zone"
