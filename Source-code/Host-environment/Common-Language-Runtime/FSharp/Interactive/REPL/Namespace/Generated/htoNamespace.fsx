#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module hto =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://vcharpenay.github.io/hto/hto.xml#" "hto"

    /// <summary>
    ///   <para>rdfs:label : AHU^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#AHU">hto:AHU</a>
    /// </summary>
    let AHU = _prefixId.prefix "AHU"
    /// <summary>
    ///   <para>rdfs:label : Air^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#Air">hto:Air</a>
    /// </summary>
    let Air = _prefixId.prefix "Air"
    /// <summary>
    ///   <para>rdfs:label : Boiler^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#Boiler">hto:Boiler</a>
    /// </summary>
    let Boiler = _prefixId.prefix "Boiler"
    /// <summary>
    ///   <para>rdfs:label : CO2^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#CO2">hto:CO2</a>
    /// </summary>
    let CO2 = _prefixId.prefix "CO2"
    /// <summary>
    ///   <para>rdfs:label : Chilled System^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#ChilledSystem">hto:ChilledSystem</a>
    /// </summary>
    let ChilledSystem = _prefixId.prefix "ChilledSystem"
    /// <summary>
    ///   <para>rdfs:label : Chiller^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#Chiller">hto:Chiller</a>
    /// </summary>
    let Chiller = _prefixId.prefix "Chiller"
    /// <summary>
    ///   <para>rdfs:label : Command^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#Command">hto:Command</a>
    /// </summary>
    let Command = _prefixId.prefix "Command"
    /// <summary>
    ///   <para>rdfs:label : Condenser System^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#CondenserSystem">hto:CondenserSystem</a>
    /// </summary>
    let CondenserSystem = _prefixId.prefix "CondenserSystem"
    /// <summary>
    ///   <para>rdfs:label : Cooling Coil^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#CoolingCoil">hto:CoolingCoil</a>
    /// </summary>
    let CoolingCoil = _prefixId.prefix "CoolingCoil"
    /// <summary>
    ///   <para>rdfs:label : Discharge^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#Discharge">hto:Discharge</a>
    /// </summary>
    let Discharge = _prefixId.prefix "Discharge"
    /// <summary>
    ///   <para>rdfs:label : Efficiency^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#Efficiency">hto:Efficiency</a>
    /// </summary>
    let Efficiency = _prefixId.prefix "Efficiency"
    /// <summary>
    ///   <para>rdfs:label : Entering^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#Entering">hto:Entering</a>
    /// </summary>
    let Entering = _prefixId.prefix "Entering"
    /// <summary>
    ///   <para>rdfs:label : Equipment^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#Equipment">hto:Equipment</a>
    /// </summary>
    let Equipment = _prefixId.prefix "Equipment"
    /// <summary>
    ///   <para>rdfs:label : Exhaust^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#Exhaust">hto:Exhaust</a>
    /// </summary>
    let Exhaust = _prefixId.prefix "Exhaust"
    /// <summary>
    ///   <para>rdfs:label : Fan^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#Fan">hto:Fan</a>
    /// </summary>
    let Fan = _prefixId.prefix "Fan"
    /// <summary>
    ///   <para>rdfs:label : Flow^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#Flow">hto:Flow</a>
    /// </summary>
    let Flow = _prefixId.prefix "Flow"
    /// <summary>
    ///   <para>rdfs:label : Frequency^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#Frequency">hto:Frequency</a>
    /// </summary>
    let Frequency = _prefixId.prefix "Frequency"
    /// <summary>
    ///   <para>rdfs:label : Gas^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#Gas">hto:Gas</a>
    /// </summary>
    let Gas = _prefixId.prefix "Gas"
    /// <summary>
    ///   <para>rdfs:label : HEntity^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#HEntity">hto:HEntity</a>
    /// </summary>
    let HEntity = _prefixId.prefix "HEntity"
    /// <summary>
    ///   <para>rdfs:label : HTag^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#HTag">hto:HTag</a>
    /// </summary>
    let HTag = _prefixId.prefix "HTag"
    /// <summary>
    ///   <para>rdfs:label : HVAC^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#HVAC">hto:HVAC</a>
    /// </summary>
    let HVAC = _prefixId.prefix "HVAC"
    /// <summary>
    ///   <para>rdfs:label : Heating Coil^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#HeatingCoil">hto:HeatingCoil</a>
    /// </summary>
    let HeatingCoil = _prefixId.prefix "HeatingCoil"
    /// <summary>
    ///   <para>rdfs:label : Historized^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#Historized">hto:Historized</a>
    /// </summary>
    let Historized = _prefixId.prefix "Historized"
    /// <summary>
    ///   <para>rdfs:label : Humidity^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#Humidity">hto:Humidity</a>
    /// </summary>
    let Humidity = _prefixId.prefix "Humidity"
    /// <summary>
    ///   <para>rdfs:label : Isolation Valve^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#IsolationValve">hto:IsolationValve</a>
    /// </summary>
    let IsolationValve = _prefixId.prefix "IsolationValve"
    /// <summary>
    ///   <para>rdfs:label : Leaving^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#Leaving">hto:Leaving</a>
    /// </summary>
    let Leaving = _prefixId.prefix "Leaving"
    /// <summary>
    ///   <para>rdfs:label : Light Level^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#LightLevel">hto:LightLevel</a>
    /// </summary>
    let LightLevel = _prefixId.prefix "LightLevel"
    /// <summary>
    ///   <para>rdfs:label : Lights Group^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#LightsGroup">hto:LightsGroup</a>
    /// </summary>
    let LightsGroup = _prefixId.prefix "LightsGroup"
    /// <summary>
    ///   <para>rdfs:label : Measurement^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#Measurement">hto:Measurement</a>
    /// </summary>
    let Measurement = _prefixId.prefix "Measurement"
    /// <summary>
    ///   <para>rdfs:label : Meter^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#Meter">hto:Meter</a>
    /// </summary>
    let Meter = _prefixId.prefix "Meter"
    /// <summary>
    ///   <para>rdfs:label : Mixed^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#Mixed">hto:Mixed</a>
    /// </summary>
    let Mixed = _prefixId.prefix "Mixed"
    /// <summary>
    ///   <para>rdfs:label : On/Off^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#OnOff">hto:OnOff</a>
    /// </summary>
    let OnOff = _prefixId.prefix "OnOff"
    /// <summary>
    ///   <para>rdfs:label : Percentage^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#Percentage">hto:Percentage</a>
    /// </summary>
    let Percentage = _prefixId.prefix "Percentage"
    /// <summary>
    ///   <para>rdfs:label : Perimeter Heat^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#PerimeterHeat">hto:PerimeterHeat</a>
    /// </summary>
    let PerimeterHeat = _prefixId.prefix "PerimeterHeat"
    /// <summary>
    ///   <para>rdfs:label : Physical Body^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#PhysicalBody">hto:PhysicalBody</a>
    /// </summary>
    let PhysicalBody = _prefixId.prefix "PhysicalBody"
    /// <summary>
    ///   <para>rdfs:label : Point^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#Point">hto:Point</a>
    /// </summary>
    let Point = _prefixId.prefix "Point"
    /// <summary>
    ///   <para>rdfs:label : Point Property^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#PointProperty">hto:PointProperty</a>
    /// </summary>
    let PointProperty = _prefixId.prefix "PointProperty"
    /// <summary>
    ///   <para>rdfs:label : Power^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#Power">hto:Power</a>
    /// </summary>
    let Power = _prefixId.prefix "Power"
    /// <summary>
    ///   <para>rdfs:label : Pressure^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#Pressure">hto:Pressure</a>
    /// </summary>
    let Pressure = _prefixId.prefix "Pressure"
    /// <summary>
    ///   <para>rdfs:label : Pump^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#Pump">hto:Pump</a>
    /// </summary>
    let Pump = _prefixId.prefix "Pump"
    /// <summary>
    ///   <para>rdfs:label : RTU^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#RTU">hto:RTU</a>
    /// </summary>
    let RTU = _prefixId.prefix "RTU"
    /// <summary>
    ///   <para>rdfs:label : Real time^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#RealTime">hto:RealTime</a>
    /// </summary>
    let RealTime = _prefixId.prefix "RealTime"
    /// <summary>
    ///   <para>rdfs:label : Refrigirant Substance^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#RefrigerantSubstance">hto:RefrigerantSubstance</a>
    /// </summary>
    let RefrigerantSubstance = _prefixId.prefix "RefrigerantSubstance"
    /// <summary>
    ///   <para>rdfs:label : Return^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#Return">hto:Return</a>
    /// </summary>
    let Return = _prefixId.prefix "Return"
    /// <summary>
    ///   <para>rdfs:label : Section^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#Section">hto:Section</a>
    /// </summary>
    let Section = _prefixId.prefix "Section"
    /// <summary>
    ///   <para>rdfs:label : Sensor^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#Sensor">hto:Sensor</a>
    /// </summary>
    let Sensor = _prefixId.prefix "Sensor"
    /// <summary>
    ///   <para>rdfs:label : Set Point^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#SetPoint">hto:SetPoint</a>
    /// </summary>
    let SetPoint = _prefixId.prefix "SetPoint"
    /// <summary>
    ///   <para>rdfs:label : Site^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#Site">hto:Site</a>
    /// </summary>
    let Site = _prefixId.prefix "Site"
    /// <summary>
    ///   <para>rdfs:label : Speed^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#Speed">hto:Speed</a>
    /// </summary>
    let Speed = _prefixId.prefix "Speed"
    /// <summary>
    ///   <para>rdfs:label : Steam^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#Steam">hto:Steam</a>
    /// </summary>
    let Steam = _prefixId.prefix "Steam"
    /// <summary>
    ///   <para>rdfs:label : Temperature^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#Temperature">hto:Temperature</a>
    /// </summary>
    let Temperature = _prefixId.prefix "Temperature"
    /// <summary>
    ///   <para>rdfs:label : VAV^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#VAV">hto:VAV</a>
    /// </summary>
    let VAV = _prefixId.prefix "VAV"
    /// <summary>
    ///   <para>rdfs:label : VFD^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#VFD">hto:VFD</a>
    /// </summary>
    let VFD = _prefixId.prefix "VFD"
    /// <summary>
    ///   <para>rdfs:label : VFD Fan^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#VFDFan">hto:VFDFan</a>
    /// </summary>
    let VFDFan = _prefixId.prefix "VFDFan"
    /// <summary>
    ///   <para>rdfs:label : Valve^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#Valve">hto:Valve</a>
    /// </summary>
    let Valve = _prefixId.prefix "Valve"
    /// <summary>
    ///   <para>rdfs:label : Water^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#Water">hto:Water</a>
    /// </summary>
    let Water = _prefixId.prefix "Water"
    /// <summary>
    ///   <para>rdfs:label : Writable^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#Writable">hto:Writable</a>
    /// </summary>
    let Writable = _prefixId.prefix "Writable"
    /// <summary>
    ///   <para>rdfs:label : Zone^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#Zone">hto:Zone</a>
    /// </summary>
    let Zone = _prefixId.prefix "Zone"
    let ahu = _prefixId.prefix "ahu"
    let air = _prefixId.prefix "air"
    /// <summary>
    ///   <para>rdfs:comment : gives the OWL class defined in the present ontology that should be associated to the individual defined as subject.^^xsd:string</para>
    ///   <a href="http://vcharpenay.github.io/hto/hto.xml#associatedTo">hto:associatedTo</a>
    /// </summary>
    let associatedTo = _prefixId.prefix "associatedTo"
    let belongsTo = _prefixId.prefix "belongsTo"
    let boiler = _prefixId.prefix "boiler"
    let bypass = _prefixId.prefix "bypass"
    let chilled = _prefixId.prefix "chilled"
    let chiller = _prefixId.prefix "chiller"
    let cmd = _prefixId.prefix "cmd"
    let co2 = _prefixId.prefix "co2"
    let condenser = _prefixId.prefix "condenser"
    let cool = _prefixId.prefix "cool"
    let cooling = _prefixId.prefix "cooling"
    let damper = _prefixId.prefix "damper"
    let delta = _prefixId.prefix "delta"
    let dis = _prefixId.prefix "dis"
    let discharge = _prefixId.prefix "discharge"
    let effective = _prefixId.prefix "effective"
    let efficiency = _prefixId.prefix "efficiency"
    let elec = _prefixId.prefix "elec"
    let enable = _prefixId.prefix "enable"
    let energy = _prefixId.prefix "energy"
    let entering = _prefixId.prefix "entering"
    let evaporator = _prefixId.prefix "evaporator"
    let exhaust = _prefixId.prefix "exhaust"
    let faceBypass = _prefixId.prefix "faceBypass"
    let fan = _prefixId.prefix "fan"
    let filter = _prefixId.prefix "filter"
    let flow = _prefixId.prefix "flow"
    let freezeStat = _prefixId.prefix "freezeStat"
    let freq = _prefixId.prefix "freq"
    let gas = _prefixId.prefix "gas"
    let hasRef = _prefixId.prefix "hasRef"
    let hasSection = _prefixId.prefix "hasSection"
    let hasTag = _prefixId.prefix "hasTag"
    let heat = _prefixId.prefix "heat"
    let heatWheel = _prefixId.prefix "heatWheel"
    let heating = _prefixId.prefix "heating"
    let humidifier = _prefixId.prefix "humidifier"
    let humidity = _prefixId.prefix "humidity"
    let hvac = _prefixId.prefix "hvac"
    let isRefedBy = _prefixId.prefix "isRefedBy"
    let isolation = _prefixId.prefix "isolation"
    let leaving = _prefixId.prefix "leaving"
    let lightLevel = _prefixId.prefix "lightLevel"
    let lights = _prefixId.prefix "lights"
    let lightsGroup = _prefixId.prefix "lightsGroup"
    let load = _prefixId.prefix "load"
    let locatedOn = _prefixId.prefix "locatedOn"
    let measuredOn = _prefixId.prefix "measuredOn"
    let meter = _prefixId.prefix "meter"
    let mixed = _prefixId.prefix "mixed"
    let occupancyIndicator = _prefixId.prefix "occupancyIndicator"
    let perimeterHeat = _prefixId.prefix "perimeterHeat"
    let point = _prefixId.prefix "point"
    let power = _prefixId.prefix "power"
    let pressure = _prefixId.prefix "pressure"
    let quantifies = _prefixId.prefix "quantifies"
    let refrig = _prefixId.prefix "refrig"
    let return_ = _prefixId.prefix "return"
    let rooftop = _prefixId.prefix "rooftop"
    let run = _prefixId.prefix "run"
    let sensor = _prefixId.prefix "sensor"
    let sp = _prefixId.prefix "sp"
    let speed = _prefixId.prefix "speed"
    let steam = _prefixId.prefix "steam"
    let temp = _prefixId.prefix "temp"
    let valve = _prefixId.prefix "valve"
    let vav = _prefixId.prefix "vav"
    let vfd = _prefixId.prefix "vfd"
    let water = _prefixId.prefix "water"
    let zone = _prefixId.prefix "zone"
