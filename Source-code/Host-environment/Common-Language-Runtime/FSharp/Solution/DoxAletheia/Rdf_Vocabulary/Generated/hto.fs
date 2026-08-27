namespace http.vcharpenay.github.io.hto.hto.xml.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module hto =
    let _namespace_iri = Namespace_Iri hto |> NamespaceIRI
    /// <summary>
    ///   <para>hto:AHU</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"AHU"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#AHU">http://vcharpenay.github.io/hto/hto.xml#AHU</seealso>
    let AHU = Prefixed_Name(hto, "AHU") |> PrefixedName
    /// <summary>
    ///   <para>hto:Air</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Air"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#Air">http://vcharpenay.github.io/hto/hto.xml#Air</seealso>
    let Air = Prefixed_Name(hto, "Air") |> PrefixedName
    /// <summary>
    ///   <para>hto:Boiler</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Boiler"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#Boiler">http://vcharpenay.github.io/hto/hto.xml#Boiler</seealso>
    let Boiler = Prefixed_Name(hto, "Boiler") |> PrefixedName
    /// <summary>
    ///   <para>hto:CO2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"CO2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#CO2">http://vcharpenay.github.io/hto/hto.xml#CO2</seealso>
    let CO2 = Prefixed_Name(hto, "CO2") |> PrefixedName
    /// <summary>
    ///   <para>hto:ChilledSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Chilled System"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#ChilledSystem">http://vcharpenay.github.io/hto/hto.xml#ChilledSystem</seealso>
    let ChilledSystem = Prefixed_Name(hto, "ChilledSystem") |> PrefixedName
    /// <summary>
    ///   <para>hto:Chiller</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Chiller"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#Chiller">http://vcharpenay.github.io/hto/hto.xml#Chiller</seealso>
    let Chiller = Prefixed_Name(hto, "Chiller") |> PrefixedName
    /// <summary>
    ///   <para>hto:Command</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Command"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#Command">http://vcharpenay.github.io/hto/hto.xml#Command</seealso>
    let Command = Prefixed_Name(hto, "Command") |> PrefixedName
    /// <summary>
    ///   <para>hto:CondenserSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Condenser System"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#CondenserSystem">http://vcharpenay.github.io/hto/hto.xml#CondenserSystem</seealso>
    let CondenserSystem = Prefixed_Name(hto, "CondenserSystem") |> PrefixedName
    /// <summary>
    ///   <para>hto:CoolingCoil</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Cooling Coil"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#CoolingCoil">http://vcharpenay.github.io/hto/hto.xml#CoolingCoil</seealso>
    let CoolingCoil = Prefixed_Name(hto, "CoolingCoil") |> PrefixedName
    /// <summary>
    ///   <para>hto:Discharge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Discharge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#Discharge">http://vcharpenay.github.io/hto/hto.xml#Discharge</seealso>
    let Discharge = Prefixed_Name(hto, "Discharge") |> PrefixedName
    /// <summary>
    ///   <para>hto:Efficiency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Efficiency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#Efficiency">http://vcharpenay.github.io/hto/hto.xml#Efficiency</seealso>
    let Efficiency = Prefixed_Name(hto, "Efficiency") |> PrefixedName
    /// <summary>
    ///   <para>hto:Entering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Entering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#Entering">http://vcharpenay.github.io/hto/hto.xml#Entering</seealso>
    let Entering = Prefixed_Name(hto, "Entering") |> PrefixedName
    /// <summary>
    ///   <para>hto:Equipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Equipment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#Equipment">http://vcharpenay.github.io/hto/hto.xml#Equipment</seealso>
    let Equipment = Prefixed_Name(hto, "Equipment") |> PrefixedName
    /// <summary>
    ///   <para>hto:Exhaust</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Exhaust"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#Exhaust">http://vcharpenay.github.io/hto/hto.xml#Exhaust</seealso>
    let Exhaust = Prefixed_Name(hto, "Exhaust") |> PrefixedName
    /// <summary>
    ///   <para>hto:Fan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Fan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#Fan">http://vcharpenay.github.io/hto/hto.xml#Fan</seealso>
    let Fan = Prefixed_Name(hto, "Fan") |> PrefixedName
    /// <summary>
    ///   <para>hto:Flow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Flow"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#Flow">http://vcharpenay.github.io/hto/hto.xml#Flow</seealso>
    let Flow = Prefixed_Name(hto, "Flow") |> PrefixedName
    /// <summary>
    ///   <para>hto:Frequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Frequency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#Frequency">http://vcharpenay.github.io/hto/hto.xml#Frequency</seealso>
    let Frequency = Prefixed_Name(hto, "Frequency") |> PrefixedName
    /// <summary>
    ///   <para>hto:Gas</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Gas"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#Gas">http://vcharpenay.github.io/hto/hto.xml#Gas</seealso>
    let Gas = Prefixed_Name(hto, "Gas") |> PrefixedName
    /// <summary>
    ///   <para>hto:HEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"HEntity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#HEntity">http://vcharpenay.github.io/hto/hto.xml#HEntity</seealso>
    let HEntity = Prefixed_Name(hto, "HEntity") |> PrefixedName
    /// <summary>
    ///   <para>hto:HTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"HTag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#HTag">http://vcharpenay.github.io/hto/hto.xml#HTag</seealso>
    let HTag = Prefixed_Name(hto, "HTag") |> PrefixedName
    /// <summary>
    ///   <para>hto:HVAC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"HVAC"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#HVAC">http://vcharpenay.github.io/hto/hto.xml#HVAC</seealso>
    let HVAC = Prefixed_Name(hto, "HVAC") |> PrefixedName
    /// <summary>
    ///   <para>hto:HeatingCoil</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Heating Coil"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#HeatingCoil">http://vcharpenay.github.io/hto/hto.xml#HeatingCoil</seealso>
    let HeatingCoil = Prefixed_Name(hto, "HeatingCoil") |> PrefixedName
    /// <summary>
    ///   <para>hto:Historized</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Historized"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#Historized">http://vcharpenay.github.io/hto/hto.xml#Historized</seealso>
    let Historized = Prefixed_Name(hto, "Historized") |> PrefixedName
    /// <summary>
    ///   <para>hto:Humidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Humidity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#Humidity">http://vcharpenay.github.io/hto/hto.xml#Humidity</seealso>
    let Humidity = Prefixed_Name(hto, "Humidity") |> PrefixedName
    /// <summary>
    ///   <para>hto:IsolationValve</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Isolation Valve"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#IsolationValve">http://vcharpenay.github.io/hto/hto.xml#IsolationValve</seealso>
    let IsolationValve = Prefixed_Name(hto, "IsolationValve") |> PrefixedName
    /// <summary>
    ///   <para>hto:Leaving</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Leaving"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#Leaving">http://vcharpenay.github.io/hto/hto.xml#Leaving</seealso>
    let Leaving = Prefixed_Name(hto, "Leaving") |> PrefixedName
    /// <summary>
    ///   <para>hto:LightLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Light Level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#LightLevel">http://vcharpenay.github.io/hto/hto.xml#LightLevel</seealso>
    let LightLevel = Prefixed_Name(hto, "LightLevel") |> PrefixedName
    /// <summary>
    ///   <para>hto:LightsGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Lights Group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#LightsGroup">http://vcharpenay.github.io/hto/hto.xml#LightsGroup</seealso>
    let LightsGroup = Prefixed_Name(hto, "LightsGroup") |> PrefixedName
    /// <summary>
    ///   <para>hto:Measurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measurement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#Measurement">http://vcharpenay.github.io/hto/hto.xml#Measurement</seealso>
    let Measurement = Prefixed_Name(hto, "Measurement") |> PrefixedName
    /// <summary>
    ///   <para>hto:Meter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Meter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#Meter">http://vcharpenay.github.io/hto/hto.xml#Meter</seealso>
    let Meter = Prefixed_Name(hto, "Meter") |> PrefixedName
    /// <summary>
    ///   <para>hto:Mixed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Mixed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#Mixed">http://vcharpenay.github.io/hto/hto.xml#Mixed</seealso>
    let Mixed = Prefixed_Name(hto, "Mixed") |> PrefixedName
    /// <summary>
    ///   <para>hto:OnOff</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"On/Off"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#OnOff">http://vcharpenay.github.io/hto/hto.xml#OnOff</seealso>
    let OnOff = Prefixed_Name(hto, "OnOff") |> PrefixedName
    /// <summary>
    ///   <para>hto:Percentage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Percentage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#Percentage">http://vcharpenay.github.io/hto/hto.xml#Percentage</seealso>
    let Percentage = Prefixed_Name(hto, "Percentage") |> PrefixedName
    /// <summary>
    ///   <para>hto:PerimeterHeat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Perimeter Heat"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#PerimeterHeat">http://vcharpenay.github.io/hto/hto.xml#PerimeterHeat</seealso>
    let PerimeterHeat = Prefixed_Name(hto, "PerimeterHeat") |> PrefixedName
    /// <summary>
    ///   <para>hto:PhysicalBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Physical Body"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#PhysicalBody">http://vcharpenay.github.io/hto/hto.xml#PhysicalBody</seealso>
    let PhysicalBody = Prefixed_Name(hto, "PhysicalBody") |> PrefixedName
    /// <summary>
    ///   <para>hto:Point</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Point"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#Point">http://vcharpenay.github.io/hto/hto.xml#Point</seealso>
    let Point = Prefixed_Name(hto, "Point") |> PrefixedName
    /// <summary>
    ///   <para>hto:PointProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Point Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#PointProperty">http://vcharpenay.github.io/hto/hto.xml#PointProperty</seealso>
    let PointProperty = Prefixed_Name(hto, "PointProperty") |> PrefixedName
    /// <summary>
    ///   <para>hto:Power</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Power"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#Power">http://vcharpenay.github.io/hto/hto.xml#Power</seealso>
    let Power = Prefixed_Name(hto, "Power") |> PrefixedName
    /// <summary>
    ///   <para>hto:Pressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Pressure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#Pressure">http://vcharpenay.github.io/hto/hto.xml#Pressure</seealso>
    let Pressure = Prefixed_Name(hto, "Pressure") |> PrefixedName
    /// <summary>
    ///   <para>hto:Pump</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Pump"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#Pump">http://vcharpenay.github.io/hto/hto.xml#Pump</seealso>
    let Pump = Prefixed_Name(hto, "Pump") |> PrefixedName
    /// <summary>
    ///   <para>hto:RTU</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"RTU"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#RTU">http://vcharpenay.github.io/hto/hto.xml#RTU</seealso>
    let RTU = Prefixed_Name(hto, "RTU") |> PrefixedName
    /// <summary>
    ///   <para>hto:RealTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Real time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#RealTime">http://vcharpenay.github.io/hto/hto.xml#RealTime</seealso>
    let RealTime = Prefixed_Name(hto, "RealTime") |> PrefixedName

    /// <summary>
    ///   <para>hto:RefrigerantSubstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Refrigirant Substance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#RefrigerantSubstance">http://vcharpenay.github.io/hto/hto.xml#RefrigerantSubstance</seealso>
    let RefrigerantSubstance =
        Prefixed_Name(hto, "RefrigerantSubstance") |> PrefixedName

    /// <summary>
    ///   <para>hto:Return</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Return"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#Return">http://vcharpenay.github.io/hto/hto.xml#Return</seealso>
    let Return = Prefixed_Name(hto, "Return") |> PrefixedName
    /// <summary>
    ///   <para>hto:Section</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Section"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#Section">http://vcharpenay.github.io/hto/hto.xml#Section</seealso>
    let Section = Prefixed_Name(hto, "Section") |> PrefixedName
    /// <summary>
    ///   <para>hto:Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sensor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#Sensor">http://vcharpenay.github.io/hto/hto.xml#Sensor</seealso>
    let Sensor = Prefixed_Name(hto, "Sensor") |> PrefixedName
    /// <summary>
    ///   <para>hto:SetPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Set Point"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#SetPoint">http://vcharpenay.github.io/hto/hto.xml#SetPoint</seealso>
    let SetPoint = Prefixed_Name(hto, "SetPoint") |> PrefixedName
    /// <summary>
    ///   <para>hto:Site</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Site"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#Site">http://vcharpenay.github.io/hto/hto.xml#Site</seealso>
    let Site = Prefixed_Name(hto, "Site") |> PrefixedName
    /// <summary>
    ///   <para>hto:Speed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Speed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#Speed">http://vcharpenay.github.io/hto/hto.xml#Speed</seealso>
    let Speed = Prefixed_Name(hto, "Speed") |> PrefixedName
    /// <summary>
    ///   <para>hto:Steam</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Steam"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#Steam">http://vcharpenay.github.io/hto/hto.xml#Steam</seealso>
    let Steam = Prefixed_Name(hto, "Steam") |> PrefixedName
    /// <summary>
    ///   <para>hto:Temperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Temperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#Temperature">http://vcharpenay.github.io/hto/hto.xml#Temperature</seealso>
    let Temperature = Prefixed_Name(hto, "Temperature") |> PrefixedName
    /// <summary>
    ///   <para>hto:VAV</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"VAV"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#VAV">http://vcharpenay.github.io/hto/hto.xml#VAV</seealso>
    let VAV = Prefixed_Name(hto, "VAV") |> PrefixedName
    /// <summary>
    ///   <para>hto:VFD</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"VFD"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#VFD">http://vcharpenay.github.io/hto/hto.xml#VFD</seealso>
    let VFD = Prefixed_Name(hto, "VFD") |> PrefixedName
    /// <summary>
    ///   <para>hto:VFDFan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"VFD Fan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#VFDFan">http://vcharpenay.github.io/hto/hto.xml#VFDFan</seealso>
    let VFDFan = Prefixed_Name(hto, "VFDFan") |> PrefixedName
    /// <summary>
    ///   <para>hto:Valve</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Valve"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#Valve">http://vcharpenay.github.io/hto/hto.xml#Valve</seealso>
    let Valve = Prefixed_Name(hto, "Valve") |> PrefixedName
    /// <summary>
    ///   <para>hto:Water</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Water"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#Water">http://vcharpenay.github.io/hto/hto.xml#Water</seealso>
    let Water = Prefixed_Name(hto, "Water") |> PrefixedName
    /// <summary>
    ///   <para>hto:Writable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Writable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#Writable">http://vcharpenay.github.io/hto/hto.xml#Writable</seealso>
    let Writable = Prefixed_Name(hto, "Writable") |> PrefixedName
    /// <summary>
    ///   <para>hto:Zone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Zone"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#Zone">http://vcharpenay.github.io/hto/hto.xml#Zone</seealso>
    let Zone = Prefixed_Name(hto, "Zone") |> PrefixedName
    /// <summary>
    ///   <para>hto:ahu</para>
    /// </summary>
    /// <remarks>
    ///   <para>hto:HTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"  Air Handler Unit which heats and/or cools air."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#ahu">http://vcharpenay.github.io/hto/hto.xml#ahu</seealso>
    let ahu = Prefixed_Name(hto, "ahu") |> PrefixedName
    /// <summary>
    ///   <para>hto:air</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>hto:HTag</para>
    ///   <para>"  Point associated with the measurement or control of air. In regards to `wetBulb`, points with the 'air' tag are associated with dry bulb."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#air">http://vcharpenay.github.io/hto/hto.xml#air</seealso>
    let air = Prefixed_Name(hto, "air") |> PrefixedName
    /// <summary>
    ///   <para>hto:associatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"gives the OWL class defined in the present ontology that should be associated to the individual defined as subject."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#associatedTo">http://vcharpenay.github.io/hto/hto.xml#associatedTo</seealso>
    let associatedTo = Prefixed_Name(hto, "associatedTo") |> PrefixedName
    /// <summary>
    ///   <para>hto:belongsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#belongsTo">http://vcharpenay.github.io/hto/hto.xml#belongsTo</seealso>
    let belongsTo = Prefixed_Name(hto, "belongsTo") |> PrefixedName
    /// <summary>
    ///   <para>hto:boiler</para>
    /// </summary>
    /// <remarks>
    ///   <para>hto:HTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"  Boiler `equip` used to generate hot water or steam for heating."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"note: does not fully implement specification (no boilerPlant). However, is still a TODO in project Haystack."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#boiler">http://vcharpenay.github.io/hto/hto.xml#boiler</seealso>
    let boiler = Prefixed_Name(hto, "boiler") |> PrefixedName
    /// <summary>
    ///   <para>hto:bypass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>hto:HTag</para>
    ///   <para>"  If used with `valve` indicates a by-pass in a piping system. If used in combination with the `damper` tag on an `ahu` to indicate a damper in the ductwork to by-pass the VAV boxs and create a direct circuit between the discharge and return of the unit."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#bypass">http://vcharpenay.github.io/hto/hto.xml#bypass</seealso>
    let bypass = Prefixed_Name(hto, "bypass") |> PrefixedName
    /// <summary>
    ///   <para>hto:chilled</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>hto:HTag</para>
    ///   <para>"  Marker tag used with `water` for the chilled water system between `chiller` and `ahu`."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#chilled">http://vcharpenay.github.io/hto/hto.xml#chilled</seealso>
    let chilled = Prefixed_Name(hto, "chilled") |> PrefixedName
    /// <summary>
    ///   <para>hto:chiller</para>
    /// </summary>
    /// <remarks>
    ///   <para>hto:HTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"  Chillers remove heat from a liquid via a vapor compression or an absorption refrigeration cycle."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"note: does not fully implement specification (no chillerPlant, no CoolingTower)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#chiller">http://vcharpenay.github.io/hto/hto.xml#chiller</seealso>
    let chiller = Prefixed_Name(hto, "chiller") |> PrefixedName
    /// <summary>
    ///   <para>hto:cmd</para>
    /// </summary>
    /// <remarks>
    ///   <para>hto:HTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"  Classifies a `point` as an output, AO/BO, command, or actuator."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#cmd">http://vcharpenay.github.io/hto/hto.xml#cmd</seealso>
    let cmd = Prefixed_Name(hto, "cmd") |> PrefixedName
    /// <summary>
    ///   <para>hto:co2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>hto:HTag</para>
    ///   <para>"  Carbon dioxide level `point` measured in "ppm"."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#co2">http://vcharpenay.github.io/hto/hto.xml#co2</seealso>
    let co2 = Prefixed_Name(hto, "co2") |> PrefixedName
    /// <summary>
    ///   <para>hto:condenser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>hto:HTag</para>
    ///   <para>"  When combined with the `water` tag, this indicates points in a condenser water system between a `chiller` and `coolingTower`. When used with the `refrig` tag, this indicates points on the condenser mechanism used to convert a refrigerant from its gaseous to liquid state. If paired with the `cmd` tag this tag indicates the command status of a condensor in a `chiller` modeled as true/false (on/off) or 0% to 100%."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#condenser">http://vcharpenay.github.io/hto/hto.xml#condenser</seealso>
    let condenser = Prefixed_Name(hto, "condenser") |> PrefixedName
    /// <summary>
    ///   <para>hto:cool</para>
    /// </summary>
    /// <remarks>
    ///   <para>hto:HTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"  Cooling coil as bool or numeric `point` used with `ahu` equip.  If multiple stages are used, then also specify the `stage` tag. If the cooling coil is controlled by a valve, then this point is mesaured from 0% to 100%, otherwise it should be a boolean point."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#cool">http://vcharpenay.github.io/hto/hto.xml#cool</seealso>
    let cool = Prefixed_Name(hto, "cool") |> PrefixedName
    /// <summary>
    ///   <para>hto:cooling</para>
    /// </summary>
    /// <remarks>
    ///   <para>hto:HTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"  Associated with the cooling mode of an HVAC system."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#cooling">http://vcharpenay.github.io/hto/hto.xml#cooling</seealso>
    let cooling = Prefixed_Name(hto, "cooling") |> PrefixedName
    /// <summary>
    ///   <para>hto:damper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>hto:HTag</para>
    ///   <para>"note: indicates the measurement of how open the damper of a AHU is (0-100%)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"  Damper position measured from 0% (fully closed) to 100% (fully open)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#damper">http://vcharpenay.github.io/hto/hto.xml#damper</seealso>
    let damper = Prefixed_Name(hto, "damper") |> PrefixedName
    /// <summary>
    ///   <para>hto:delta</para>
    /// </summary>
    /// <remarks>
    ///   <para>hto:HTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"  Indicates a differential of `air`, `water`, or `steam` between the `entering` and `leaving` sensors."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#delta">http://vcharpenay.github.io/hto/hto.xml#delta</seealso>
    let delta = Prefixed_Name(hto, "delta") |> PrefixedName
    /// <summary>
    ///   <para>hto:dis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#dis">http://vcharpenay.github.io/hto/hto.xml#dis</seealso>
    let dis = Prefixed_Name(hto, "dis") |> PrefixedName
    /// <summary>
    ///   <para>hto:discharge</para>
    /// </summary>
    /// <remarks>
    ///   <para>hto:HTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"  Associated with the discharge air an `ahu` or `vav`."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#discharge">http://vcharpenay.github.io/hto/hto.xml#discharge</seealso>
    let discharge = Prefixed_Name(hto, "discharge") |> PrefixedName
    /// <summary>
    ///   <para>hto:effective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>hto:HTag</para>
    ///   <para>"  Used to indicate the effective setpoint which takes into account various other mode based setpoints the equip might define.  See [zone setpoints]`Zones#zonePoints` for complete example of how this tag is used."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#effective">http://vcharpenay.github.io/hto/hto.xml#effective</seealso>
    let effective = Prefixed_Name(hto, "effective") |> PrefixedName
    /// <summary>
    ///   <para>hto:efficiency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>hto:HTag</para>
    ///   <para>"  Efficiency point of a `chiller` measured in "COP" or "kW/ton"."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#efficiency">http://vcharpenay.github.io/hto/hto.xml#efficiency</seealso>
    let efficiency = Prefixed_Name(hto, "efficiency") |> PrefixedName
    /// <summary>
    ///   <para>hto:elec</para>
    /// </summary>
    /// <remarks>
    ///   <para>hto:HTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"note: according to the documentation, is assocated to either point or equip"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"  Used on `point` or `equip` entities relating to electricity. When paried with `meter` indicates a electric meter."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#elec">http://vcharpenay.github.io/hto/hto.xml#elec</seealso>
    let elec = Prefixed_Name(hto, "elec") |> PrefixedName
    /// <summary>
    ///   <para>hto:enable</para>
    /// </summary>
    /// <remarks>
    ///   <para>hto:HTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"  Secondary on/off `point` of an `equip` especially used with a `vfd`. Enable is used with Bool points where true indicates on and false indicates off.  Equip with an enable should always also define a `run` point which indicates the primary on/off state of the equipment."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#enable">http://vcharpenay.github.io/hto/hto.xml#enable</seealso>
    let enable = Prefixed_Name(hto, "enable") |> PrefixedName
    /// <summary>
    ///   <para>hto:energy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>hto:HTag</para>
    ///   <para>"  Applied to `point` entities which measure energy consumption:   - Electric meters: "kWh"   - Thermal meters: "BTU"   - Gas meters: "mÂ³_gas"   - Chillers: "tonrefh""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#energy">http://vcharpenay.github.io/hto/hto.xml#energy</seealso>
    let energy = Prefixed_Name(hto, "energy") |> PrefixedName
    /// <summary>
    ///   <para>hto:entering</para>
    /// </summary>
    /// <remarks>
    ///   <para>hto:HTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"  Indicates `water` or `steam` entering a piece of equipment like a `boiler` or `chiller`.  Used with `vav` for air flow into the unit from the AHU."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#entering">http://vcharpenay.github.io/hto/hto.xml#entering</seealso>
    let entering = Prefixed_Name(hto, "entering") |> PrefixedName
    /// <summary>
    ///   <para>hto:evaporator</para>
    /// </summary>
    /// <remarks>
    ///   <para>hto:HTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"  Indicates points on the evaporator mechanism used to convert a refrigerant from its liquid to gageous state.  It is often paired with the `refrig` marker tag."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#evaporator">http://vcharpenay.github.io/hto/hto.xml#evaporator</seealso>
    let evaporator = Prefixed_Name(hto, "evaporator") |> PrefixedName
    /// <summary>
    ///   <para>hto:exhaust</para>
    /// </summary>
    /// <remarks>
    ///   <para>hto:HTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"  Associated with the exhaust air an `ahu`."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#exhaust">http://vcharpenay.github.io/hto/hto.xml#exhaust</seealso>
    let exhaust = Prefixed_Name(hto, "exhaust") |> PrefixedName
    /// <summary>
    ///   <para>hto:faceBypass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>hto:HTag</para>
    ///   <para>"  A `point` of an `ahu` indicating air flow is by-passing the heating/cooling elements. If a boolean point, then true indicates the unit is in by-pass mode and false indicates by-pass is disabled.  If the point is an analog point then 100% indicates full by-pass mode and 0% that by-pass is completely disabled."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#faceBypass">http://vcharpenay.github.io/hto/hto.xml#faceBypass</seealso>
    let faceBypass = Prefixed_Name(hto, "faceBypass") |> PrefixedName
    /// <summary>
    ///   <para>hto:fan</para>
    /// </summary>
    /// <remarks>
    ///   <para>hto:HTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"note: according to the documentation, is assocated to either point or equip. Should use reasoning to choose the right one for a given HEntity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"  Fan `point` or `equip` associated with an `ahu`, `vav`, or `coolingTower`."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#fan">http://vcharpenay.github.io/hto/hto.xml#fan</seealso>
    let fan = Prefixed_Name(hto, "fan") |> PrefixedName
    /// <summary>
    ///   <para>hto:filter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>hto:HTag</para>
    ///   <para>"  Differential pressure across the filter of an `ahu`.  If a boolean point then true indicates successful airflow and false indicates a clogged filter.  If a numeric then the pressure differential should be measured in "inHâ‚‚O" or "kPa""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#filter">http://vcharpenay.github.io/hto/hto.xml#filter</seealso>
    let filter = Prefixed_Name(hto, "filter") |> PrefixedName
    /// <summary>
    ///   <para>hto:flow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>hto:HTag</para>
    ///   <para>"  Marker tag on a `point` which measures rate of volume currently flowing through a flow meter, duct, or pipe .   - Air flow: "cfm" or "L/s"   - Gas/water flow: "gal/min" or "mÂ³/s""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#flow">http://vcharpenay.github.io/hto/hto.xml#flow</seealso>
    let flow = Prefixed_Name(hto, "flow") |> PrefixedName
    /// <summary>
    ///   <para>hto:freezeStat</para>
    /// </summary>
    /// <remarks>
    ///   <para>hto:HTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"  A boolean `point` of an `ahu` indicating a freezing condition which might require a control sequence to protect the equipment. If true then a freeze condition is deteted, or false if not."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#freezeStat">http://vcharpenay.github.io/hto/hto.xml#freezeStat</seealso>
    let freezeStat = Prefixed_Name(hto, "freezeStat") |> PrefixedName
    /// <summary>
    ///   <para>hto:freq</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>hto:HTag</para>
    ///   <para>"  Electrical A/C frequency `point` measured in "Hz" for `elec` `meter` or a `vfd`."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#freq">http://vcharpenay.github.io/hto/hto.xml#freq</seealso>
    let freq = Prefixed_Name(hto, "freq") |> PrefixedName
    /// <summary>
    ///   <para>hto:gas</para>
    /// </summary>
    /// <remarks>
    ///   <para>hto:HTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"  Used on `point` or `equip` entities relating to natural gas. When paried with `meter` indicates a gas meter."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#gas">http://vcharpenay.github.io/hto/hto.xml#gas</seealso>
    let gas = Prefixed_Name(hto, "gas") |> PrefixedName
    /// <summary>
    ///   <para>hto:hasRef</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#hasRef">http://vcharpenay.github.io/hto/hto.xml#hasRef</seealso>
    let hasRef = Prefixed_Name(hto, "hasRef") |> PrefixedName
    /// <summary>
    ///   <para>hto:hasSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#hasSection">http://vcharpenay.github.io/hto/hto.xml#hasSection</seealso>
    let hasSection = Prefixed_Name(hto, "hasSection") |> PrefixedName
    /// <summary>
    ///   <para>hto:hasTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#hasTag">http://vcharpenay.github.io/hto/hto.xml#hasTag</seealso>
    let hasTag = Prefixed_Name(hto, "hasTag") |> PrefixedName
    /// <summary>
    ///   <para>hto:heat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>hto:HTag</para>
    ///   <para>"  Heating coil as bool or float point on an `ahu` or `vav`. If multiple stages are used, then also specify the `stage` tag. If the heating coil is controlled by a valve, then this point is mesaured from 0% to 100%, otherwise it should be a boolean point."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#heat">http://vcharpenay.github.io/hto/hto.xml#heat</seealso>
    let heat = Prefixed_Name(hto, "heat") |> PrefixedName
    /// <summary>
    ///   <para>hto:heatWheel</para>
    /// </summary>
    /// <remarks>
    ///   <para>hto:HTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"  Bool `point` which models the on or off state of an `ahu` heat wheel."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#heatWheel">http://vcharpenay.github.io/hto/hto.xml#heatWheel</seealso>
    let heatWheel = Prefixed_Name(hto, "heatWheel") |> PrefixedName
    /// <summary>
    ///   <para>hto:heating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>hto:HTag</para>
    ///   <para>"  Associated with the heating mode of an HVAC system."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#heating">http://vcharpenay.github.io/hto/hto.xml#heating</seealso>
    let heating = Prefixed_Name(hto, "heating") |> PrefixedName
    /// <summary>
    ///   <para>hto:humidifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>hto:HTag</para>
    ///   <para>"  Boolean or numeric `point` of an `ahu` used to indicate if if the humidifier is on or off."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#humidifier">http://vcharpenay.github.io/hto/hto.xml#humidifier</seealso>
    let humidifier = Prefixed_Name(hto, "humidifier") |> PrefixedName
    /// <summary>
    ///   <para>hto:humidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>hto:HTag</para>
    ///   <para>"  Humidity measured from 0% to 100%."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#humidity">http://vcharpenay.github.io/hto/hto.xml#humidity</seealso>
    let humidity = Prefixed_Name(hto, "humidity") |> PrefixedName
    /// <summary>
    ///   <para>hto:hvac</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>hto:HTag</para>
    ///   <para>"  Associated with HVAC (Heating, Ventilating, Air Conditioning)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#hvac">http://vcharpenay.github.io/hto/hto.xml#hvac</seealso>
    let hvac = Prefixed_Name(hto, "hvac") |> PrefixedName
    /// <summary>
    ///   <para>hto:isRefedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#isRefedBy">http://vcharpenay.github.io/hto/hto.xml#isRefedBy</seealso>
    let isRefedBy = Prefixed_Name(hto, "isRefedBy") |> PrefixedName
    /// <summary>
    ///   <para>hto:isolation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>hto:HTag</para>
    ///   <para>"  Indicates a `valve` used to isolate a piece of equipment from a piping system."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#isolation">http://vcharpenay.github.io/hto/hto.xml#isolation</seealso>
    let isolation = Prefixed_Name(hto, "isolation") |> PrefixedName
    /// <summary>
    ///   <para>hto:leaving</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>hto:HTag</para>
    ///   <para>"  Indicates `water` or `steam` exiting a piece of equipment like a `boiler` or `chiller`."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#leaving">http://vcharpenay.github.io/hto/hto.xml#leaving</seealso>
    let leaving = Prefixed_Name(hto, "leaving") |> PrefixedName
    /// <summary>
    ///   <para>hto:lightLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>hto:HTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"  Light level sensor point under `lightsGroup` measured in "lux" or "lumen"."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#lightLevel">http://vcharpenay.github.io/hto/hto.xml#lightLevel</seealso>
    let lightLevel = Prefixed_Name(hto, "lightLevel") |> PrefixedName
    /// <summary>
    ///   <para>hto:lights</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>hto:HTag</para>
    ///   <para>"  Lighting on/off status as a boolean or if dimmable a numeric between 0% and 100%."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"note: according to the documentation, subsumes sensor. But associated here to a Measurement type and redundant with the tag lightLevel."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#lights">http://vcharpenay.github.io/hto/hto.xml#lights</seealso>
    let lights = Prefixed_Name(hto, "lights") |> PrefixedName
    /// <summary>
    ///   <para>hto:lightsGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>hto:HTag</para>
    ///   <para>"  Equip level of the lighting system which is a group of one or more `lights` points."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#lightsGroup">http://vcharpenay.github.io/hto/hto.xml#lightsGroup</seealso>
    let lightsGroup = Prefixed_Name(hto, "lightsGroup") |> PrefixedName
    /// <summary>
    ///   <para>hto:load</para>
    /// </summary>
    /// <remarks>
    ///   <para>hto:HTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"  Models a `point` on a `chiller` used to command or measure the chiller's load as a percentage from "0%" to "100%".  When paired with `cmd` this models the chiller's load limit.  When paired with `sensor` this models the chiller's current load factor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#load">http://vcharpenay.github.io/hto/hto.xml#load</seealso>
    let load = Prefixed_Name(hto, "load") |> PrefixedName
    /// <summary>
    ///   <para>hto:locatedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#locatedOn">http://vcharpenay.github.io/hto/hto.xml#locatedOn</seealso>
    let locatedOn = Prefixed_Name(hto, "locatedOn") |> PrefixedName
    /// <summary>
    ///   <para>hto:measuredOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#measuredOn">http://vcharpenay.github.io/hto/hto.xml#measuredOn</seealso>
    let measuredOn = Prefixed_Name(hto, "measuredOn") |> PrefixedName
    /// <summary>
    ///   <para>hto:meter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>hto:HTag</para>
    ///   <para>"  Equip which meters usage of `elec` energy, thermal energy, `gas`, `water` or `steam`."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#meter">http://vcharpenay.github.io/hto/hto.xml#meter</seealso>
    let meter = Prefixed_Name(hto, "meter") |> PrefixedName
    /// <summary>
    ///   <para>hto:mixed</para>
    /// </summary>
    /// <remarks>
    ///   <para>hto:HTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"  Associated with the mixed air of an `ahu`."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#mixed">http://vcharpenay.github.io/hto/hto.xml#mixed</seealso>
    let mixed = Prefixed_Name(hto, "mixed") |> PrefixedName
    /// <summary>
    ///   <para>hto:occupancyIndicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>hto:HTag</para>
    ///   <para>"  Occupancy sensor under `lightsGroup`.  Point must be Bool where true indicates occupied and false indicates unoccupied"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"note: according to the documentation, subsumes sensor. But associated here to a Measurement type. Similarly, lights and lightLevel tags both refer to the class LightLevel."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#occupancyIndicator">http://vcharpenay.github.io/hto/hto.xml#occupancyIndicator</seealso>
    let occupancyIndicator = Prefixed_Name(hto, "occupancyIndicator") |> PrefixedName
    /// <summary>
    ///   <para>hto:perimeterHeat</para>
    /// </summary>
    /// <remarks>
    ///   <para>hto:HTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"  Auxiliary heating points associated with a `vav`."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#perimeterHeat">http://vcharpenay.github.io/hto/hto.xml#perimeterHeat</seealso>
    let perimeterHeat = Prefixed_Name(hto, "perimeterHeat") |> PrefixedName
    /// <summary>
    ///   <para>hto:point</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>hto:HTag</para>
    ///   <para>"  Data point such as a sensor or actuator."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#point">http://vcharpenay.github.io/hto/hto.xml#point</seealso>
    let point = Prefixed_Name(hto, "point") |> PrefixedName
    /// <summary>
    ///   <para>hto:power</para>
    /// </summary>
    /// <remarks>
    ///   <para>hto:HTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"  Applied to `point` entities which measure energy consumed per unit time. For 'elec meter' this is the electrical demand.   - Electric meters: "kW"   - Thermal meters: "BTU/h"   - Chillers: "tonref" or "kW" refrigeration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#power">http://vcharpenay.github.io/hto/hto.xml#power</seealso>
    let power = Prefixed_Name(hto, "power") |> PrefixedName
    /// <summary>
    ///   <para>hto:pressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>hto:HTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"  Static pressure associated with the measurement or control of fluids such as air, oxygen, water, steam, gas, oil, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#pressure">http://vcharpenay.github.io/hto/hto.xml#pressure</seealso>
    let pressure = Prefixed_Name(hto, "pressure") |> PrefixedName
    /// <summary>
    ///   <para>hto:quantifies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#quantifies">http://vcharpenay.github.io/hto/hto.xml#quantifies</seealso>
    let quantifies = Prefixed_Name(hto, "quantifies") |> PrefixedName
    /// <summary>
    ///   <para>hto:refrig</para>
    /// </summary>
    /// <remarks>
    ///   <para>hto:HTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"  Indicates points associated with the measurment or control of the refrigerant substance in a cooling system like a `chiller`."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#refrig">http://vcharpenay.github.io/hto/hto.xml#refrig</seealso>
    let refrig = Prefixed_Name(hto, "refrig") |> PrefixedName
    /// <summary>
    ///   <para>hto:return</para>
    /// </summary>
    /// <remarks>
    ///   <para>hto:HTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"  Associated with the return air an `ahu`."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#return">http://vcharpenay.github.io/hto/hto.xml#return</seealso>
    let return_ = Prefixed_Name(hto, "return") |> PrefixedName
    /// <summary>
    ///   <para>hto:rooftop</para>
    /// </summary>
    /// <remarks>
    ///   <para>hto:HTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"  Used with `ahu` to mark an AHU as a packaged rooftop unit (RTU)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#rooftop">http://vcharpenay.github.io/hto/hto.xml#rooftop</seealso>
    let rooftop = Prefixed_Name(hto, "rooftop") |> PrefixedName
    /// <summary>
    ///   <para>hto:run</para>
    /// </summary>
    /// <remarks>
    ///   <para>hto:HTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"  Primary on/off `point` of an `equip` especially used with a `vfd`. Run is used with Bool points where true indicates on and false indicates off. When paired with `cmd` this is the commanded state of the equipment. When paired with `sensor` this is the actual status of the equip.  If the equipment also defines an `enable` point then both must be commanded on in order to run the equipment."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"note: according to the documentation, subsumes sensor. But associated here to a Measurement type."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#run">http://vcharpenay.github.io/hto/hto.xml#run</seealso>
    let run = Prefixed_Name(hto, "run") |> PrefixedName
    /// <summary>
    ///   <para>hto:sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>hto:HTag</para>
    ///   <para>"  Classifies a `point` as an input, AI/BI, or sensor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#sensor">http://vcharpenay.github.io/hto/hto.xml#sensor</seealso>
    let sensor = Prefixed_Name(hto, "sensor") |> PrefixedName
    /// <summary>
    ///   <para>hto:sp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>hto:HTag</para>
    ///   <para>"  Classifies a `point` as a setpoint, soft point, or process control variable."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#sp">http://vcharpenay.github.io/hto/hto.xml#sp</seealso>
    let sp = Prefixed_Name(hto, "sp") |> PrefixedName
    /// <summary>
    ///   <para>hto:speed</para>
    /// </summary>
    /// <remarks>
    ///   <para>hto:HTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"  Speed `point` of a `vfd` measured in "%" where 0% is off and 100% is the fastest speed."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#speed">http://vcharpenay.github.io/hto/hto.xml#speed</seealso>
    let speed = Prefixed_Name(hto, "speed") |> PrefixedName
    /// <summary>
    ///   <para>hto:steam</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>hto:HTag</para>
    ///   <para>"  Point associated with the measurement or control of steam. This tag is often paired with `entering` versus `leaving` versus `delta`. It may also be paired with `meter` to indicate a steam meter."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#steam">http://vcharpenay.github.io/hto/hto.xml#steam</seealso>
    let steam = Prefixed_Name(hto, "steam") |> PrefixedName
    /// <summary>
    ///   <para>hto:temp</para>
    /// </summary>
    /// <remarks>
    ///   <para>hto:HTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"  Temperature measured in Â°C or Â°F."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#temp">http://vcharpenay.github.io/hto/hto.xml#temp</seealso>
    let temp = Prefixed_Name(hto, "temp") |> PrefixedName
    /// <summary>
    ///   <para>hto:valve</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>hto:HTag</para>
    ///   <para>"  Marker tag on `point` which indicates a valve used to regulate or control the flow or pressure of a fluid.  It is used with `cmd` to indicate the valve command: true/false (open/close) or 0% to 100%.  It may also be used with `sensor` to indicate a feedback sensor such as a voltage giving exact position between 0% and 100%."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#valve">http://vcharpenay.github.io/hto/hto.xml#valve</seealso>
    let valve = Prefixed_Name(hto, "valve") |> PrefixedName
    /// <summary>
    ///   <para>hto:vav</para>
    /// </summary>
    /// <remarks>
    ///   <para>hto:HTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"  Variable Volume Volume supply duct `equip`."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#vav">http://vcharpenay.github.io/hto/hto.xml#vav</seealso>
    let vav = Prefixed_Name(hto, "vav") |> PrefixedName
    /// <summary>
    ///   <para>hto:vfd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>hto:HTag</para>
    ///   <para>"  Marker for a motor `equip` with variable frequency drive.  Commonly used in combination with `fan` and `pump`."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#vfd">http://vcharpenay.github.io/hto/hto.xml#vfd</seealso>
    let vfd = Prefixed_Name(hto, "vfd") |> PrefixedName
    /// <summary>
    ///   <para>hto:water</para>
    /// </summary>
    /// <remarks>
    ///   <para>hto:HTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"  Point associated with the measurement or control of water.  This tag is often paired:   - `entering` versus `leaving` versus `delta`   - `chilled` versus `condenser` It may also be paired with `meter` to indicate a water meter."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#water">http://vcharpenay.github.io/hto/hto.xml#water</seealso>
    let water = Prefixed_Name(hto, "water") |> PrefixedName
    /// <summary>
    ///   <para>hto:zone</para>
    /// </summary>
    /// <remarks>
    ///   <para>hto:HTag</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"  Associated with a conditioned [zone]`Zones` of a building."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://vcharpenay.github.io/hto/hto.xml#zone">http://vcharpenay.github.io/hto/hto.xml#zone</seealso>
    let zone = Prefixed_Name(hto, "zone") |> PrefixedName
