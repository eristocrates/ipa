namespace https.w3id.org.dco.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module w3dco =
    let _namespace_iri = Namespace_Iri w3dco |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:dco#Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Action"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#Action">https://w3id.org/dco#Action</seealso>
    let Action = Prefixed_Name(w3dco, "Action") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#ActiveEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Active energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#ActiveEnergy">https://w3id.org/dco#ActiveEnergy</seealso>
    let ActiveEnergy = Prefixed_Name(w3dco, "ActiveEnergy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#ActiveEnergyExport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ActiveEnergyExport"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#ActiveEnergyExport">https://w3id.org/dco#ActiveEnergyExport</seealso>
    let ActiveEnergyExport = Prefixed_Name(w3dco, "ActiveEnergyExport") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#ActiveEnergyImport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Active energy import"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#ActiveEnergyImport">https://w3id.org/dco#ActiveEnergyImport</seealso>
    let ActiveEnergyImport = Prefixed_Name(w3dco, "ActiveEnergyImport") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#ActivePower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Active power"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#ActivePower">https://w3id.org/dco#ActivePower</seealso>
    let ActivePower = Prefixed_Name(w3dco, "ActivePower") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#ActivePowerExport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Active power export"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#ActivePowerExport">https://w3id.org/dco#ActivePowerExport</seealso>
    let ActivePowerExport = Prefixed_Name(w3dco, "ActivePowerExport") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#ActivePowerImport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Active power import"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#ActivePowerImport">https://w3id.org/dco#ActivePowerImport</seealso>
    let ActivePowerImport = Prefixed_Name(w3dco, "ActivePowerImport") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#ActualPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Actual Power"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#ActualPower">https://w3id.org/dco#ActualPower</seealso>
    let ActualPower = Prefixed_Name(w3dco, "ActualPower") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#Actuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Actuator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#Actuator">https://w3id.org/dco#Actuator</seealso>
    let Actuator = Prefixed_Name(w3dco, "Actuator") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#AmbientHumidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Ambient Humidity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#AmbientHumidity">https://w3id.org/dco#AmbientHumidity</seealso>
    let AmbientHumidity = Prefixed_Name(w3dco, "AmbientHumidity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#AmbientSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Ambient Sensor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#AmbientSensor">https://w3id.org/dco#AmbientSensor</seealso>
    let AmbientSensor = Prefixed_Name(w3dco, "AmbientSensor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#AmbientTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Ambient temperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#AmbientTemperature">https://w3id.org/dco#AmbientTemperature</seealso>
    let AmbientTemperature = Prefixed_Name(w3dco, "AmbientTemperature") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#Amperage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Amperage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#Amperage">https://w3id.org/dco#Amperage</seealso>
    let Amperage = Prefixed_Name(w3dco, "Amperage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#AmperageClamp1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Amperage clamp 1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#AmperageClamp1">https://w3id.org/dco#AmperageClamp1</seealso>
    let AmperageClamp1 = Prefixed_Name(w3dco, "AmperageClamp1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#AmperageClamp2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Amperage clamp 2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#AmperageClamp2">https://w3id.org/dco#AmperageClamp2</seealso>
    let AmperageClamp2 = Prefixed_Name(w3dco, "AmperageClamp2") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#AmperageClamp3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Amperage clamp 3"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#AmperageClamp3">https://w3id.org/dco#AmperageClamp3</seealso>
    let AmperageClamp3 = Prefixed_Name(w3dco, "AmperageClamp3") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#AmperageProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Amperage property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#AmperageProperty">https://w3id.org/dco#AmperageProperty</seealso>
    let AmperageProperty = Prefixed_Name(w3dco, "AmperageProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#Ampere</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Ampere"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#Ampere">https://w3id.org/dco#Ampere</seealso>
    let Ampere = Prefixed_Name(w3dco, "Ampere") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#Apartment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Apartment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#Apartment">https://w3id.org/dco#Apartment</seealso>
    let Apartment = Prefixed_Name(w3dco, "Apartment") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#Appliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Appliance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#Appliance">https://w3id.org/dco#Appliance</seealso>
    let Appliance = Prefixed_Name(w3dco, "Appliance") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#AreaUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Area unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#AreaUnit">https://w3id.org/dco#AreaUnit</seealso>
    let AreaUnit = Prefixed_Name(w3dco, "AreaUnit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#Bathroom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Bathroom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#Bathroom">https://w3id.org/dco#Bathroom</seealso>
    let Bathroom = Prefixed_Name(w3dco, "Bathroom") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#BatteryLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Battery level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#BatteryLevel">https://w3id.org/dco#BatteryLevel</seealso>
    let BatteryLevel = Prefixed_Name(w3dco, "BatteryLevel") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#BatteryProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Battery Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#BatteryProperty">https://w3id.org/dco#BatteryProperty</seealso>
    let BatteryProperty = Prefixed_Name(w3dco, "BatteryProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#Bedroom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Bedroom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#Bedroom">https://w3id.org/dco#Bedroom</seealso>
    let Bedroom = Prefixed_Name(w3dco, "Bedroom") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#Building</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Building"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#Building">https://w3id.org/dco#Building</seealso>
    let Building = Prefixed_Name(w3dco, "Building") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#BuildingAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Building address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#BuildingAddress">https://w3id.org/dco#BuildingAddress</seealso>
    let BuildingAddress = Prefixed_Name(w3dco, "BuildingAddress") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#BuildingCity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Building city"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#BuildingCity">https://w3id.org/dco#BuildingCity</seealso>
    let BuildingCity = Prefixed_Name(w3dco, "BuildingCity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#BuildingConstructionYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Building construction year"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#BuildingConstructionYear">https://w3id.org/dco#BuildingConstructionYear</seealso>
    let BuildingConstructionYear =
        Prefixed_Name(w3dco, "BuildingConstructionYear") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#BuildingHeatedSurface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Building heated surface"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#BuildingHeatedSurface">https://w3id.org/dco#BuildingHeatedSurface</seealso>
    let BuildingHeatedSurface =
        Prefixed_Name(w3dco, "BuildingHeatedSurface") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#BuildingLivingArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Building living area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#BuildingLivingArea">https://w3id.org/dco#BuildingLivingArea</seealso>
    let BuildingLivingArea = Prefixed_Name(w3dco, "BuildingLivingArea") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#BuildingMetadata</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Building metadata"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#BuildingMetadata">https://w3id.org/dco#BuildingMetadata</seealso>
    let BuildingMetadata = Prefixed_Name(w3dco, "BuildingMetadata") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#BuildingModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Building model"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#BuildingModel">https://w3id.org/dco#BuildingModel</seealso>
    let BuildingModel = Prefixed_Name(w3dco, "BuildingModel") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#BuildingName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Building Name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#BuildingName">https://w3id.org/dco#BuildingName</seealso>
    let BuildingName = Prefixed_Name(w3dco, "BuildingName") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#BuildingNumberOfInhabitants</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Building number of inhabitants"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#BuildingNumberOfInhabitants">https://w3id.org/dco#BuildingNumberOfInhabitants</seealso>
    let BuildingNumberOfInhabitants =
        Prefixed_Name(w3dco, "BuildingNumberOfInhabitants") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#BuildingRenovationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Building renovation date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#BuildingRenovationDate">https://w3id.org/dco#BuildingRenovationDate</seealso>
    let BuildingRenovationDate =
        Prefixed_Name(w3dco, "BuildingRenovationDate") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#BuildingTopology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Building topology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#BuildingTopology">https://w3id.org/dco#BuildingTopology</seealso>
    let BuildingTopology = Prefixed_Name(w3dco, "BuildingTopology") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#BuildingTotalSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Building total space"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#BuildingTotalSpace">https://w3id.org/dco#BuildingTotalSpace</seealso>
    let BuildingTotalSpace = Prefixed_Name(w3dco, "BuildingTotalSpace") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#BuildingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Building type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#BuildingType">https://w3id.org/dco#BuildingType</seealso>
    let BuildingType = Prefixed_Name(w3dco, "BuildingType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#BusinessBuilding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Business building"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#BusinessBuilding">https://w3id.org/dco#BusinessBuilding</seealso>
    let BusinessBuilding = Prefixed_Name(w3dco, "BusinessBuilding") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#CO2Concentration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"CO2 concentration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#CO2Concentration">https://w3id.org/dco#CO2Concentration</seealso>
    let CO2Concentration = Prefixed_Name(w3dco, "CO2Concentration") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#CarbonDioxideProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Carbon dioxide property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#CarbonDioxideProperty">https://w3id.org/dco#CarbonDioxideProperty</seealso>
    let CarbonDioxideProperty =
        Prefixed_Name(w3dco, "CarbonDioxideProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#Celsius</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Celsius"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#Celsius">https://w3id.org/dco#Celsius</seealso>
    let Celsius = Prefixed_Name(w3dco, "Celsius") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#CloseState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Close state"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#CloseState">https://w3id.org/dco#CloseState</seealso>
    let CloseState = Prefixed_Name(w3dco, "CloseState") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#ClosedLoopEnergyEfficiencyService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Closed loop energy efficiency service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#ClosedLoopEnergyEfficiencyService">https://w3id.org/dco#ClosedLoopEnergyEfficiencyService</seealso>
    let ClosedLoopEnergyEfficiencyService =
        Prefixed_Name(w3dco, "ClosedLoopEnergyEfficiencyService") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#Controller</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Controller"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#Controller">https://w3id.org/dco#Controller</seealso>
    let Controller = Prefixed_Name(w3dco, "Controller") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#CubicMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Cubic meter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#CubicMeter">https://w3id.org/dco#CubicMeter</seealso>
    let CubicMeter = Prefixed_Name(w3dco, "CubicMeter") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#CubicMeterPerHour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Cubic meter per hour"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#CubicMeterPerHour">https://w3id.org/dco#CubicMeterPerHour</seealso>
    let CubicMeterPerHour = Prefixed_Name(w3dco, "CubicMeterPerHour") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#DefineTemperatureSetpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Define temperature setpoint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#DefineTemperatureSetpoint">https://w3id.org/dco#DefineTemperatureSetpoint</seealso>
    let DefineTemperatureSetpoint =
        Prefixed_Name(w3dco, "DefineTemperatureSetpoint") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#DesiredValveOpening</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Desired Valve opening"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#DesiredValveOpening">https://w3id.org/dco#DesiredValveOpening</seealso>
    let DesiredValveOpening =
        Prefixed_Name(w3dco, "DesiredValveOpening") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#DeviceIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Device identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#DeviceIdentifier">https://w3id.org/dco#DeviceIdentifier</seealso>
    let DeviceIdentifier = Prefixed_Name(w3dco, "DeviceIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#DeviceManifucturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Device Metadata"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#DeviceManifucturer">https://w3id.org/dco#DeviceManifucturer</seealso>
    let DeviceManifucturer = Prefixed_Name(w3dco, "DeviceManifucturer") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#DeviceMaximumDisabledTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Device maximum disabled time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#DeviceMaximumDisabledTime">https://w3id.org/dco#DeviceMaximumDisabledTime</seealso>
    let DeviceMaximumDisabledTime =
        Prefixed_Name(w3dco, "DeviceMaximumDisabledTime") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#DeviceMaximumPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Device maximum power"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#DeviceMaximumPower">https://w3id.org/dco#DeviceMaximumPower</seealso>
    let DeviceMaximumPower = Prefixed_Name(w3dco, "DeviceMaximumPower") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#DeviceMetadata</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Device metadata"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#DeviceMetadata">https://w3id.org/dco#DeviceMetadata</seealso>
    let DeviceMetadata = Prefixed_Name(w3dco, "DeviceMetadata") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#DeviceMinimumEnabledTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Device minimum enabled time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#DeviceMinimumEnabledTime">https://w3id.org/dco#DeviceMinimumEnabledTime</seealso>
    let DeviceMinimumEnabledTime =
        Prefixed_Name(w3dco, "DeviceMinimumEnabledTime") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#DeviceSerialNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Device serial number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#DeviceSerialNumber">https://w3id.org/dco#DeviceSerialNumber</seealso>
    let DeviceSerialNumber = Prefixed_Name(w3dco, "DeviceSerialNumber") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#DeviceSoftwareVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DeviceSoftwareVersion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#DeviceSoftwareVersion">https://w3id.org/dco#DeviceSoftwareVersion</seealso>
    let DeviceSoftwareVersion =
        Prefixed_Name(w3dco, "DeviceSoftwareVersion") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#EVChargingAppliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EV charging appliance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#EVChargingAppliance">https://w3id.org/dco#EVChargingAppliance</seealso>
    let EVChargingAppliance =
        Prefixed_Name(w3dco, "EVChargingAppliance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#ElectricUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Electric unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#ElectricUnit">https://w3id.org/dco#ElectricUnit</seealso>
    let ElectricUnit = Prefixed_Name(w3dco, "ElectricUnit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#EnergyClamp1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Energy clamp 1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#EnergyClamp1">https://w3id.org/dco#EnergyClamp1</seealso>
    let EnergyClamp1 = Prefixed_Name(w3dco, "EnergyClamp1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#EnergyClamp2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Energy clamp 2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#EnergyClamp2">https://w3id.org/dco#EnergyClamp2</seealso>
    let EnergyClamp2 = Prefixed_Name(w3dco, "EnergyClamp2") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#EnergyClamp3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Energy Clamp 3"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#EnergyClamp3">https://w3id.org/dco#EnergyClamp3</seealso>
    let EnergyClamp3 = Prefixed_Name(w3dco, "EnergyClamp3") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#EnergyFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Energy flow"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#EnergyFlow">https://w3id.org/dco#EnergyFlow</seealso>
    let EnergyFlow = Prefixed_Name(w3dco, "EnergyFlow") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#EnergyMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Energy meter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#EnergyMeter">https://w3id.org/dco#EnergyMeter</seealso>
    let EnergyMeter = Prefixed_Name(w3dco, "EnergyMeter") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#EnergyProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Energy property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#EnergyProperty">https://w3id.org/dco#EnergyProperty</seealso>
    let EnergyProperty = Prefixed_Name(w3dco, "EnergyProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#EnergyQuadrant1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Energy quadrant 1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#EnergyQuadrant1">https://w3id.org/dco#EnergyQuadrant1</seealso>
    let EnergyQuadrant1 = Prefixed_Name(w3dco, "EnergyQuadrant1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#EnergyQuadrant2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Energy quadrant 2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#EnergyQuadrant2">https://w3id.org/dco#EnergyQuadrant2</seealso>
    let EnergyQuadrant2 = Prefixed_Name(w3dco, "EnergyQuadrant2") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#EnergyQuadrant3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Energy quadrant 3"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#EnergyQuadrant3">https://w3id.org/dco#EnergyQuadrant3</seealso>
    let EnergyQuadrant3 = Prefixed_Name(w3dco, "EnergyQuadrant3") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#EnergyQuadrant4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Energy quadrant 4"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#EnergyQuadrant4">https://w3id.org/dco#EnergyQuadrant4</seealso>
    let EnergyQuadrant4 = Prefixed_Name(w3dco, "EnergyQuadrant4") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#EnergyUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Energy unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#EnergyUnit">https://w3id.org/dco#EnergyUnit</seealso>
    let EnergyUnit = Prefixed_Name(w3dco, "EnergyUnit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#Event">https://w3id.org/dco#Event</seealso>
    let Event = Prefixed_Name(w3dco, "Event") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#ExportedEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Exported energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#ExportedEnergy">https://w3id.org/dco#ExportedEnergy</seealso>
    let ExportedEnergy = Prefixed_Name(w3dco, "ExportedEnergy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#ExportedEnergyWithPricing1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Exported energy with pricing 1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#ExportedEnergyWithPricing1">https://w3id.org/dco#ExportedEnergyWithPricing1</seealso>
    let ExportedEnergyWithPricing1 =
        Prefixed_Name(w3dco, "ExportedEnergyWithPricing1") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#ExportedEnergyWithPricing2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Exported energy with pricing 2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#ExportedEnergyWithPricing2">https://w3id.org/dco#ExportedEnergyWithPricing2</seealso>
    let ExportedEnergyWithPricing2 =
        Prefixed_Name(w3dco, "ExportedEnergyWithPricing2") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#FeatureOfInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Feature of interest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#FeatureOfInterest">https://w3id.org/dco#FeatureOfInterest</seealso>
    let FeatureOfInterest = Prefixed_Name(w3dco, "FeatureOfInterest") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#FeatureProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Feature property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#FeatureProperty">https://w3id.org/dco#FeatureProperty</seealso>
    let FeatureProperty = Prefixed_Name(w3dco, "FeatureProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#FlexibilityService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Flexibility service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#FlexibilityService">https://w3id.org/dco#FlexibilityService</seealso>
    let FlexibilityService = Prefixed_Name(w3dco, "FlexibilityService") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#Floor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Floor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#Floor">https://w3id.org/dco#Floor</seealso>
    let Floor = Prefixed_Name(w3dco, "Floor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#GasBoiler</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Gas boiler"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#GasBoiler">https://w3id.org/dco#GasBoiler</seealso>
    let GasBoiler = Prefixed_Name(w3dco, "GasBoiler") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#GasBoilerActuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Gas boiler actuator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#GasBoilerActuator">https://w3id.org/dco#GasBoilerActuator</seealso>
    let GasBoilerActuator = Prefixed_Name(w3dco, "GasBoilerActuator") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#GasMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Gas meter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#GasMeter">https://w3id.org/dco#GasMeter</seealso>
    let GasMeter = Prefixed_Name(w3dco, "GasMeter") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#Gateway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Gateway"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#Gateway">https://w3id.org/dco#Gateway</seealso>
    let Gateway = Prefixed_Name(w3dco, "Gateway") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#GetTemperatureSetpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Get temperature setpoint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#GetTemperatureSetpoint">https://w3id.org/dco#GetTemperatureSetpoint</seealso>
    let GetTemperatureSetpoint =
        Prefixed_Name(w3dco, "GetTemperatureSetpoint") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#GetValveOpeningPercentage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Get valve opening percentage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#GetValveOpeningPercentage">https://w3id.org/dco#GetValveOpeningPercentage</seealso>
    let GetValveOpeningPercentage =
        Prefixed_Name(w3dco, "GetValveOpeningPercentage") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#HeatMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Heat meter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#HeatMeter">https://w3id.org/dco#HeatMeter</seealso>
    let HeatMeter = Prefixed_Name(w3dco, "HeatMeter") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#HeatPumpAppliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Heat pump appliance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#HeatPumpAppliance">https://w3id.org/dco#HeatPumpAppliance</seealso>
    let HeatPumpAppliance = Prefixed_Name(w3dco, "HeatPumpAppliance") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#HeatPumpRelay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Heat pump relay"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#HeatPumpRelay">https://w3id.org/dco#HeatPumpRelay</seealso>
    let HeatPumpRelay = Prefixed_Name(w3dco, "HeatPumpRelay") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#HeaterMaximalPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Heater maximal power"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#HeaterMaximalPower">https://w3id.org/dco#HeaterMaximalPower</seealso>
    let HeaterMaximalPower = Prefixed_Name(w3dco, "HeaterMaximalPower") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#HeaterMinimumPower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Heater minimum power"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#HeaterMinimumPower">https://w3id.org/dco#HeaterMinimumPower</seealso>
    let HeaterMinimumPower = Prefixed_Name(w3dco, "HeaterMinimumPower") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#HeatingActuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Heating actuator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#HeatingActuator">https://w3id.org/dco#HeatingActuator</seealso>
    let HeatingActuator = Prefixed_Name(w3dco, "HeatingActuator") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#HeatingService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Heating service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#HeatingService">https://w3id.org/dco#HeatingService</seealso>
    let HeatingService = Prefixed_Name(w3dco, "HeatingService") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#HotWaterProductionService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Hot water production service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#HotWaterProductionService">https://w3id.org/dco#HotWaterProductionService</seealso>
    let HotWaterProductionService =
        Prefixed_Name(w3dco, "HotWaterProductionService") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#HouseholdType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Household type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#HouseholdType">https://w3id.org/dco#HouseholdType</seealso>
    let HouseholdType = Prefixed_Name(w3dco, "HouseholdType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#HumidityProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Humidity property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#HumidityProperty">https://w3id.org/dco#HumidityProperty</seealso>
    let HumidityProperty = Prefixed_Name(w3dco, "HumidityProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#HumiditySensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Humidity sensor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#HumiditySensor">https://w3id.org/dco#HumiditySensor</seealso>
    let HumiditySensor = Prefixed_Name(w3dco, "HumiditySensor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#ImportedEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Imported energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#ImportedEnergy">https://w3id.org/dco#ImportedEnergy</seealso>
    let ImportedEnergy = Prefixed_Name(w3dco, "ImportedEnergy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#ImportedEnergyWithPricing1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Imported energy with pricing 1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#ImportedEnergyWithPricing1">https://w3id.org/dco#ImportedEnergyWithPricing1</seealso>
    let ImportedEnergyWithPricing1 =
        Prefixed_Name(w3dco, "ImportedEnergyWithPricing1") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#ImportedEnergyWithPricing2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Imported energy with pricing 2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#ImportedEnergyWithPricing2">https://w3id.org/dco#ImportedEnergyWithPricing2</seealso>
    let ImportedEnergyWithPricing2 =
        Prefixed_Name(w3dco, "ImportedEnergyWithPricing2") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#IndustrialBuilding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Industrial building"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#IndustrialBuilding">https://w3id.org/dco#IndustrialBuilding</seealso>
    let IndustrialBuilding = Prefixed_Name(w3dco, "IndustrialBuilding") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#IntelTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Intel temperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#IntelTemperature">https://w3id.org/dco#IntelTemperature</seealso>
    let IntelTemperature = Prefixed_Name(w3dco, "IntelTemperature") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#InteractionAffordance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Interaction Affordance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#InteractionAffordance">https://w3id.org/dco#InteractionAffordance</seealso>
    let InteractionAffordance =
        Prefixed_Name(w3dco, "InteractionAffordance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#Kitchen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Kitchen"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#Kitchen">https://w3id.org/dco#Kitchen</seealso>
    let Kitchen = Prefixed_Name(w3dco, "Kitchen") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#LivingRoom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Living room"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#LivingRoom">https://w3id.org/dco#LivingRoom</seealso>
    let LivingRoom = Prefixed_Name(w3dco, "LivingRoom") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#Lobby</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Lobby"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#Lobby">https://w3id.org/dco#Lobby</seealso>
    let Lobby = Prefixed_Name(w3dco, "Lobby") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#MagnetSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Magnet sensor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#MagnetSensor">https://w3id.org/dco#MagnetSensor</seealso>
    let MagnetSensor = Prefixed_Name(w3dco, "MagnetSensor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#MeasureTimeStamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measure time stamp"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#MeasureTimeStamp">https://w3id.org/dco#MeasureTimeStamp</seealso>
    let MeasureTimeStamp = Prefixed_Name(w3dco, "MeasureTimeStamp") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#MeasuredValveOpening</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measured valve opening"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#MeasuredValveOpening">https://w3id.org/dco#MeasuredValveOpening</seealso>
    let MeasuredValveOpening =
        Prefixed_Name(w3dco, "MeasuredValveOpening") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#Meter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Meter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#Meter">https://w3id.org/dco#Meter</seealso>
    let Meter = Prefixed_Name(w3dco, "Meter") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#MultiFamilyHouse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Multi family house"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#MultiFamilyHouse">https://w3id.org/dco#MultiFamilyHouse</seealso>
    let MultiFamilyHouse = Prefixed_Name(w3dco, "MultiFamilyHouse") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#OffAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Off action"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#OffAction">https://w3id.org/dco#OffAction</seealso>
    let OffAction = Prefixed_Name(w3dco, "OffAction") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#OffState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Off state"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#OffState">https://w3id.org/dco#OffState</seealso>
    let OffState = Prefixed_Name(w3dco, "OffState") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#OnAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"On action"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#OnAction">https://w3id.org/dco#OnAction</seealso>
    let OnAction = Prefixed_Name(w3dco, "OnAction") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#OnOffState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"On Off state"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#OnOffState">https://w3id.org/dco#OnOffState</seealso>
    let OnOffState = Prefixed_Name(w3dco, "OnOffState") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#OnState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"On state"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#OnState">https://w3id.org/dco#OnState</seealso>
    let OnState = Prefixed_Name(w3dco, "OnState") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#OpenCloseState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Open Close State"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#OpenCloseState">https://w3id.org/dco#OpenCloseState</seealso>
    let OpenCloseState = Prefixed_Name(w3dco, "OpenCloseState") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#OpenState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Open state"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#OpenState">https://w3id.org/dco#OpenState</seealso>
    let OpenState = Prefixed_Name(w3dco, "OpenState") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#OutdoorTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Outdoor temperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#OutdoorTemperature">https://w3id.org/dco#OutdoorTemperature</seealso>
    let OutdoorTemperature = Prefixed_Name(w3dco, "OutdoorTemperature") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#PartsPerMillion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Parts per million"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#PartsPerMillion">https://w3id.org/dco#PartsPerMillion</seealso>
    let PartsPerMillion = Prefixed_Name(w3dco, "PartsPerMillion") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#PartsPerNotationUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Parts per notation unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#PartsPerNotationUnit">https://w3id.org/dco#PartsPerNotationUnit</seealso>
    let PartsPerNotationUnit =
        Prefixed_Name(w3dco, "PartsPerNotationUnit") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#Percentage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Percentage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#Percentage">https://w3id.org/dco#Percentage</seealso>
    let Percentage = Prefixed_Name(w3dco, "Percentage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#PercentageUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Percentage unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#PercentageUnit">https://w3id.org/dco#PercentageUnit</seealso>
    let PercentageUnit = Prefixed_Name(w3dco, "PercentageUnit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#PipeTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Pipe temperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#PipeTemperature">https://w3id.org/dco#PipeTemperature</seealso>
    let PipeTemperature = Prefixed_Name(w3dco, "PipeTemperature") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#PowerMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Power meter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#PowerMeter">https://w3id.org/dco#PowerMeter</seealso>
    let PowerMeter = Prefixed_Name(w3dco, "PowerMeter") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#PowerProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Power property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#PowerProperty">https://w3id.org/dco#PowerProperty</seealso>
    let PowerProperty = Prefixed_Name(w3dco, "PowerProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#PowerUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Power unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#PowerUnit">https://w3id.org/dco#PowerUnit</seealso>
    let PowerUnit = Prefixed_Name(w3dco, "PowerUnit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#Property">https://w3id.org/dco#Property</seealso>
    let Property = Prefixed_Name(w3dco, "Property") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#ReactiveEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Reactive energy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#ReactiveEnergy">https://w3id.org/dco#ReactiveEnergy</seealso>
    let ReactiveEnergy = Prefixed_Name(w3dco, "ReactiveEnergy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#ReactivePower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Reactive power"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#ReactivePower">https://w3id.org/dco#ReactivePower</seealso>
    let ReactivePower = Prefixed_Name(w3dco, "ReactivePower") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#ReactivePowerExport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Reactive power export"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#ReactivePowerExport">https://w3id.org/dco#ReactivePowerExport</seealso>
    let ReactivePowerExport =
        Prefixed_Name(w3dco, "ReactivePowerExport") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#ReactivePowerImport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Reactive power Import"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#ReactivePowerImport">https://w3id.org/dco#ReactivePowerImport</seealso>
    let ReactivePowerImport =
        Prefixed_Name(w3dco, "ReactivePowerImport") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#Relay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Relay"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#Relay">https://w3id.org/dco#Relay</seealso>
    let Relay = Prefixed_Name(w3dco, "Relay") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#ResidentialBuilding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Residential building"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#ResidentialBuilding">https://w3id.org/dco#ResidentialBuilding</seealso>
    let ResidentialBuilding =
        Prefixed_Name(w3dco, "ResidentialBuilding") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#ReturnTemperatureSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Return temperature sensor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#ReturnTemperatureSensor">https://w3id.org/dco#ReturnTemperatureSensor</seealso>
    let ReturnTemperatureSensor =
        Prefixed_Name(w3dco, "ReturnTemperatureSensor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#Room</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Room"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#Room">https://w3id.org/dco#Room</seealso>
    let Room = Prefixed_Name(w3dco, "Room") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sensor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#Sensor">https://w3id.org/dco#Sensor</seealso>
    let Sensor = Prefixed_Name(w3dco, "Sensor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#Setpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Setpoint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#Setpoint">https://w3id.org/dco#Setpoint</seealso>
    let Setpoint = Prefixed_Name(w3dco, "Setpoint") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#SingleFamilyHouse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Single family house"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#SingleFamilyHouse">https://w3id.org/dco#SingleFamilyHouse</seealso>
    let SingleFamilyHouse = Prefixed_Name(w3dco, "SingleFamilyHouse") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#Site</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Site"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#Site">https://w3id.org/dco#Site</seealso>
    let Site = Prefixed_Name(w3dco, "Site") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#SmartMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SmartMeter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#SmartMeter">https://w3id.org/dco#SmartMeter</seealso>
    let SmartMeter = Prefixed_Name(w3dco, "SmartMeter") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#SolarPanelsAppliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Solar panels appliance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#SolarPanelsAppliance">https://w3id.org/dco#SolarPanelsAppliance</seealso>
    let SolarPanelsAppliance =
        Prefixed_Name(w3dco, "SolarPanelsAppliance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#Space</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Space"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#Space">https://w3id.org/dco#Space</seealso>
    let Space = Prefixed_Name(w3dco, "Space") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#SquareMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Square meter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#SquareMeter">https://w3id.org/dco#SquareMeter</seealso>
    let SquareMeter = Prefixed_Name(w3dco, "SquareMeter") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#StartState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Start state"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#StartState">https://w3id.org/dco#StartState</seealso>
    let StartState = Prefixed_Name(w3dco, "StartState") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#StartStopState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Start Stop state"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#StartStopState">https://w3id.org/dco#StartStopState</seealso>
    let StartStopState = Prefixed_Name(w3dco, "StartStopState") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#State</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"State"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#State">https://w3id.org/dco#State</seealso>
    let State = Prefixed_Name(w3dco, "State") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#StopState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Stop state"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#StopState">https://w3id.org/dco#StopState</seealso>
    let StopState = Prefixed_Name(w3dco, "StopState") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#SupplyTemperatureSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Supply temperature sensor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#SupplyTemperatureSensor">https://w3id.org/dco#SupplyTemperatureSensor</seealso>
    let SupplyTemperatureSensor =
        Prefixed_Name(w3dco, "SupplyTemperatureSensor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#TankTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Tank temperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#TankTemperature">https://w3id.org/dco#TankTemperature</seealso>
    let TankTemperature = Prefixed_Name(w3dco, "TankTemperature") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#TemperatureProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Temperature Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#TemperatureProperty">https://w3id.org/dco#TemperatureProperty</seealso>
    let TemperatureProperty =
        Prefixed_Name(w3dco, "TemperatureProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#TemperatureSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Temperature Sensor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#TemperatureSensor">https://w3id.org/dco#TemperatureSensor</seealso>
    let TemperatureSensor = Prefixed_Name(w3dco, "TemperatureSensor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#TemperatureSetpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Temperature setpoint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#TemperatureSetpoint">https://w3id.org/dco#TemperatureSetpoint</seealso>
    let TemperatureSetpoint =
        Prefixed_Name(w3dco, "TemperatureSetpoint") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#TemperatureUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Temperature unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#TemperatureUnit">https://w3id.org/dco#TemperatureUnit</seealso>
    let TemperatureUnit = Prefixed_Name(w3dco, "TemperatureUnit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#TertiaryBuilding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Tertiary building"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#TertiaryBuilding">https://w3id.org/dco#TertiaryBuilding</seealso>
    let TertiaryBuilding = Prefixed_Name(w3dco, "TertiaryBuilding") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#Thermostat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Thermostat"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#Thermostat">https://w3id.org/dco#Thermostat</seealso>
    let Thermostat = Prefixed_Name(w3dco, "Thermostat") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#ThermostaticValveActuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Thermostatic valve actuator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#ThermostaticValveActuator">https://w3id.org/dco#ThermostaticValveActuator</seealso>
    let ThermostaticValveActuator =
        Prefixed_Name(w3dco, "ThermostaticValveActuator") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#ThingDescriptionModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Thing description model"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#ThingDescriptionModel">https://w3id.org/dco#ThingDescriptionModel</seealso>
    let ThingDescriptionModel =
        Prefixed_Name(w3dco, "ThingDescriptionModel") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#ToggleAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Toggle action"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#ToggleAction">https://w3id.org/dco#ToggleAction</seealso>
    let ToggleAction = Prefixed_Name(w3dco, "ToggleAction") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#UnitsOfMeasurements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Units of measurements"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#UnitsOfMeasurements">https://w3id.org/dco#UnitsOfMeasurements</seealso>
    let UnitsOfMeasurements =
        Prefixed_Name(w3dco, "UnitsOfMeasurements") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#ValveActuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Valve actuator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#ValveActuator">https://w3id.org/dco#ValveActuator</seealso>
    let ValveActuator = Prefixed_Name(w3dco, "ValveActuator") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#ValveController</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Valve controller"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#ValveController">https://w3id.org/dco#ValveController</seealso>
    let ValveController = Prefixed_Name(w3dco, "ValveController") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#ValveMaximumOpening</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Valve maximum opening"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#ValveMaximumOpening">https://w3id.org/dco#ValveMaximumOpening</seealso>
    let ValveMaximumOpening =
        Prefixed_Name(w3dco, "ValveMaximumOpening") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#ValveMaximumTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Valve maximum temperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#ValveMaximumTemperature">https://w3id.org/dco#ValveMaximumTemperature</seealso>
    let ValveMaximumTemperature =
        Prefixed_Name(w3dco, "ValveMaximumTemperature") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#ValveMinimumOpening</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Valve minimum opening"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#ValveMinimumOpening">https://w3id.org/dco#ValveMinimumOpening</seealso>
    let ValveMinimumOpening =
        Prefixed_Name(w3dco, "ValveMinimumOpening") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#ValveMinimumTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Valve minimum temperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#ValveMinimumTemperature">https://w3id.org/dco#ValveMinimumTemperature</seealso>
    let ValveMinimumTemperature =
        Prefixed_Name(w3dco, "ValveMinimumTemperature") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#ValvePosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Valve position"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#ValvePosition">https://w3id.org/dco#ValvePosition</seealso>
    let ValvePosition = Prefixed_Name(w3dco, "ValvePosition") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#ValveProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Valve property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#ValveProperty">https://w3id.org/dco#ValveProperty</seealso>
    let ValveProperty = Prefixed_Name(w3dco, "ValveProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#Volt-ampereReactive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Volt-ampere reactive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#Volt-ampereReactive">https://w3id.org/dco#Volt-ampereReactive</seealso>
    let Volt_ampereReactive =
        Prefixed_Name(w3dco, "Volt-ampereReactive") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#Voltage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Voltage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#Voltage">https://w3id.org/dco#Voltage</seealso>
    let Voltage = Prefixed_Name(w3dco, "Voltage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#VoltageClamp1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Voltage clamp 1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#VoltageClamp1">https://w3id.org/dco#VoltageClamp1</seealso>
    let VoltageClamp1 = Prefixed_Name(w3dco, "VoltageClamp1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#VoltageClamp2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Voltage clamp 2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#VoltageClamp2">https://w3id.org/dco#VoltageClamp2</seealso>
    let VoltageClamp2 = Prefixed_Name(w3dco, "VoltageClamp2") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#VoltageClamp3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Voltage clamp 3"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#VoltageClamp3">https://w3id.org/dco#VoltageClamp3</seealso>
    let VoltageClamp3 = Prefixed_Name(w3dco, "VoltageClamp3") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#VoltageProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Voltage property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#VoltageProperty">https://w3id.org/dco#VoltageProperty</seealso>
    let VoltageProperty = Prefixed_Name(w3dco, "VoltageProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#VolumeUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Volume unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#VolumeUnit">https://w3id.org/dco#VolumeUnit</seealso>
    let VolumeUnit = Prefixed_Name(w3dco, "VolumeUnit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#WaterFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Water flow"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#WaterFlow">https://w3id.org/dco#WaterFlow</seealso>
    let WaterFlow = Prefixed_Name(w3dco, "WaterFlow") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#WaterFlowMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Water flow meter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#WaterFlowMeter">https://w3id.org/dco#WaterFlowMeter</seealso>
    let WaterFlowMeter = Prefixed_Name(w3dco, "WaterFlowMeter") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#WaterProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Water property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#WaterProperty">https://w3id.org/dco#WaterProperty</seealso>
    let WaterProperty = Prefixed_Name(w3dco, "WaterProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#WaterTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Water temperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#WaterTemperature">https://w3id.org/dco#WaterTemperature</seealso>
    let WaterTemperature = Prefixed_Name(w3dco, "WaterTemperature") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#WaterTemperatureSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Water temperature sensor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#WaterTemperatureSensor">https://w3id.org/dco#WaterTemperatureSensor</seealso>
    let WaterTemperatureSensor =
        Prefixed_Name(w3dco, "WaterTemperatureSensor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#WaterVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Water volume"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#WaterVolume">https://w3id.org/dco#WaterVolume</seealso>
    let WaterVolume = Prefixed_Name(w3dco, "WaterVolume") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#Watt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Watt"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#Watt">https://w3id.org/dco#Watt</seealso>
    let Watt = Prefixed_Name(w3dco, "Watt") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#WattHourBasedUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Watt hour based unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#WattHourBasedUnit">https://w3id.org/dco#WattHourBasedUnit</seealso>
    let WattHourBasedUnit = Prefixed_Name(w3dco, "WattHourBasedUnit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#WoTThing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"WoT Thing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#WoTThing">https://w3id.org/dco#WoTThing</seealso>
    let WoTThing = Prefixed_Name(w3dco, "WoTThing") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#Zone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Zone"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#Zone">https://w3id.org/dco#Zone</seealso>
    let Zone = Prefixed_Name(w3dco, "Zone") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#buildingZipCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"building zip code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#buildingZipCode">https://w3id.org/dco#buildingZipCode</seealso>
    let buildingZipCode = Prefixed_Name(w3dco, "buildingZipCode") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#consitsOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"consitsOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#consitsOf">https://w3id.org/dco#consitsOf</seealso>
    let consitsOf = Prefixed_Name(w3dco, "consitsOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#containsDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"contains device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#containsDevice">https://w3id.org/dco#containsDevice</seealso>
    let containsDevice = Prefixed_Name(w3dco, "containsDevice") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#dCOCoreModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dCO core model"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#dCOCoreModel">https://w3id.org/dco#dCOCoreModel</seealso>
    let dCOCoreModel = Prefixed_Name(w3dco, "dCOCoreModel") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#hasAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasAddress"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#hasAddress">https://w3id.org/dco#hasAddress</seealso>
    let hasAddress = Prefixed_Name(w3dco, "hasAddress") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#hasApartment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasApartment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#hasApartment">https://w3id.org/dco#hasApartment</seealso>
    let hasApartment = Prefixed_Name(w3dco, "hasApartment") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#hasBuilding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasBuilding"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#hasBuilding">https://w3id.org/dco#hasBuilding</seealso>
    let hasBuilding = Prefixed_Name(w3dco, "hasBuilding") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#hasCity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasCity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#hasCity">https://w3id.org/dco#hasCity</seealso>
    let hasCity = Prefixed_Name(w3dco, "hasCity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#hasConstructionYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasConstructionYear"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#hasConstructionYear">https://w3id.org/dco#hasConstructionYear</seealso>
    let hasConstructionYear =
        Prefixed_Name(w3dco, "hasConstructionYear") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#hasFloor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasFloor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#hasFloor">https://w3id.org/dco#hasFloor</seealso>
    let hasFloor = Prefixed_Name(w3dco, "hasFloor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#hasID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#hasID">https://w3id.org/dco#hasID</seealso>
    let hasID = Prefixed_Name(w3dco, "hasID") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#hasName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#hasName">https://w3id.org/dco#hasName</seealso>
    let hasName = Prefixed_Name(w3dco, "hasName") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#hasNumberOfInhabitants</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasNumberOfInhabitants"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#hasNumberOfInhabitants">https://w3id.org/dco#hasNumberOfInhabitants</seealso>
    let hasNumberOfInhabitants =
        Prefixed_Name(w3dco, "hasNumberOfInhabitants") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#hasRenovationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasRenovationDate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#hasRenovationDate">https://w3id.org/dco#hasRenovationDate</seealso>
    let hasRenovationDate = Prefixed_Name(w3dco, "hasRenovationDate") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#hasSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasSite"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#hasSite">https://w3id.org/dco#hasSite</seealso>
    let hasSite = Prefixed_Name(w3dco, "hasSite") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#hasSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"hasSpace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#hasSpace">https://w3id.org/dco#hasSpace</seealso>
    let hasSpace = Prefixed_Name(w3dco, "hasSpace") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#hasThingDescriptionAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasThingDescriptionAction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#hasThingDescriptionAction">https://w3id.org/dco#hasThingDescriptionAction</seealso>
    let hasThingDescriptionAction =
        Prefixed_Name(w3dco, "hasThingDescriptionAction") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#hasThingDescriptionEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasThingDescriptionEvent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#hasThingDescriptionEvent">https://w3id.org/dco#hasThingDescriptionEvent</seealso>
    let hasThingDescriptionEvent =
        Prefixed_Name(w3dco, "hasThingDescriptionEvent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#hasThingDescriptionProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasThingDescriptionProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#hasThingDescriptionProperty">https://w3id.org/dco#hasThingDescriptionProperty</seealso>
    let hasThingDescriptionProperty =
        Prefixed_Name(w3dco, "hasThingDescriptionProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#hasTotalSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasTotalSpace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#hasTotalSpace">https://w3id.org/dco#hasTotalSpace</seealso>
    let hasTotalSpace = Prefixed_Name(w3dco, "hasTotalSpace") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#hasZipCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasZipCode"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#hasZipCode">https://w3id.org/dco#hasZipCode</seealso>
    let hasZipCode = Prefixed_Name(w3dco, "hasZipCode") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#isActionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is action of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#isActionOf">https://w3id.org/dco#isActionOf</seealso>
    let isActionOf = Prefixed_Name(w3dco, "isActionOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#isApartmentOF</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is apartment of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#isApartmentOF">https://w3id.org/dco#isApartmentOF</seealso>
    let isApartmentOF = Prefixed_Name(w3dco, "isApartmentOF") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#isEventOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is event of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#isEventOf">https://w3id.org/dco#isEventOf</seealso>
    let isEventOf = Prefixed_Name(w3dco, "isEventOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#isFloorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is floor of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#isFloorOf">https://w3id.org/dco#isFloorOf</seealso>
    let isFloorOf = Prefixed_Name(w3dco, "isFloorOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#isLocatedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is located at"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#isLocatedAt">https://w3id.org/dco#isLocatedAt</seealso>
    let isLocatedAt = Prefixed_Name(w3dco, "isLocatedAt") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#isMeasuredIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isMeasuredIn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#isMeasuredIn">https://w3id.org/dco#isMeasuredIn</seealso>
    let isMeasuredIn = Prefixed_Name(w3dco, "isMeasuredIn") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#isPropertyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is property of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#isPropertyOf">https://w3id.org/dco#isPropertyOf</seealso>
    let isPropertyOf = Prefixed_Name(w3dco, "isPropertyOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#isUnitOfMeasurementOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is unit of measurement of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#isUnitOfMeasurementOf">https://w3id.org/dco#isUnitOfMeasurementOf</seealso>
    let isUnitOfMeasurementOf =
        Prefixed_Name(w3dco, "isUnitOfMeasurementOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dco#kilowatt-hour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"kilowatt-hour"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#kilowatt-hour">https://w3id.org/dco#kilowatt-hour</seealso>
    let kilowatt_hour = Prefixed_Name(w3dco, "kilowatt-hour") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#makesMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"makes measurement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#makesMeasurement">https://w3id.org/dco#makesMeasurement</seealso>
    let makesMeasurement = Prefixed_Name(w3dco, "makesMeasurement") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#measurementMadeBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"measurement made by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#measurementMadeBy">https://w3id.org/dco#measurementMadeBy</seealso>
    let measurementMadeBy = Prefixed_Name(w3dco, "measurementMadeBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#offersService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"offers service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#offersService">https://w3id.org/dco#offersService</seealso>
    let offersService = Prefixed_Name(w3dco, "offersService") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#serviceOfferedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"service offered by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#serviceOfferedBy">https://w3id.org/dco#serviceOfferedBy</seealso>
    let serviceOfferedBy = Prefixed_Name(w3dco, "serviceOfferedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dco#watt-hour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"watt-hour"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/dco#watt-hour">https://w3id.org/dco#watt-hour</seealso>
    let watt_hour = Prefixed_Name(w3dco, "watt-hour") |> PrefixedName
