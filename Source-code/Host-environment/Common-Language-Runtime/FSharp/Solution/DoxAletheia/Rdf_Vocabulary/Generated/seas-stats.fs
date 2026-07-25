namespace https.w3id.org.seas.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module seas_stats =
    let _namespace_iri = Namespace_Iri seas_stats |> NamespaceIRI

    /// <summary>
    ///   <para>seas-stats:StatisticsOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/StatisticsOntology-1.0">https://w3id.org/seas/StatisticsOntology-1.0</seealso>
    let ``StatisticsOntology_1.0`` =
        Prefixed_Name(seas_stats, "StatisticsOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>seas-stats:EnergyFormOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/EnergyFormOntology-1.0">https://w3id.org/seas/EnergyFormOntology-1.0</seealso>
    let ``EnergyFormOntology_1.0`` =
        Prefixed_Name(seas_stats, "EnergyFormOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>seas-stats:OptimizationOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/OptimizationOntology-1.0">https://w3id.org/seas/OptimizationOntology-1.0</seealso>
    let ``OptimizationOntology_1.0`` =
        Prefixed_Name(seas_stats, "OptimizationOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>seas-stats:DeviceOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/DeviceOntology-1.0">https://w3id.org/seas/DeviceOntology-1.0</seealso>
    let ``DeviceOntology_1.0`` =
        Prefixed_Name(seas_stats, "DeviceOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>seas-stats:seas-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/seas-1.0">https://w3id.org/seas/seas-1.0</seealso>
    let ``seas_1.0`` = Prefixed_Name(seas_stats, "seas-1.0") |> PrefixedName
    /// <summary>
    ///   <para>seas-stats:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>voaf:Vocabulary</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/seas/">https://w3id.org/seas/</seealso>
    let _prefix_iri = Prefixed_Name(seas_stats, "") |> PrefixedName

    /// <summary>
    ///   <para>seas-stats:TimeOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/TimeOntology-1.0">https://w3id.org/seas/TimeOntology-1.0</seealso>
    let ``TimeOntology_1.0`` =
        Prefixed_Name(seas_stats, "TimeOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>seas-stats:FeatureOfInterestOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/FeatureOfInterestOntology-1.0">https://w3id.org/seas/FeatureOfInterestOntology-1.0</seealso>
    let ``FeatureOfInterestOntology_1.0`` =
        Prefixed_Name(seas_stats, "FeatureOfInterestOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>seas-stats:OfferingOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/OfferingOntology-1.0">https://w3id.org/seas/OfferingOntology-1.0</seealso>
    let ``OfferingOntology_1.0`` =
        Prefixed_Name(seas_stats, "OfferingOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>seas-stats:BooleanPropertyOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/BooleanPropertyOntology-1.0">https://w3id.org/seas/BooleanPropertyOntology-1.0</seealso>
    let ``BooleanPropertyOntology_1.0`` =
        Prefixed_Name(seas_stats, "BooleanPropertyOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>seas-stats:PlayerOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/PlayerOntology-1.0">https://w3id.org/seas/PlayerOntology-1.0</seealso>
    let ``PlayerOntology_1.0`` =
        Prefixed_Name(seas_stats, "PlayerOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>seas-stats:ZoneLightingOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/ZoneLightingOntology-1.0">https://w3id.org/seas/ZoneLightingOntology-1.0</seealso>
    let ``ZoneLightingOntology_1.0`` =
        Prefixed_Name(seas_stats, "ZoneLightingOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>seas-stats:ThermodynamicSystemOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/ThermodynamicSystemOntology-1.0">https://w3id.org/seas/ThermodynamicSystemOntology-1.0</seealso>
    let ``ThermodynamicSystemOntology_1.0`` =
        Prefixed_Name(seas_stats, "ThermodynamicSystemOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>seas-stats:ComfortOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/ComfortOntology-1.0">https://w3id.org/seas/ComfortOntology-1.0</seealso>
    let ``ComfortOntology_1.0`` =
        Prefixed_Name(seas_stats, "ComfortOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>seas-stats:ZoneOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/ZoneOntology-1.0">https://w3id.org/seas/ZoneOntology-1.0</seealso>
    let ``ZoneOntology_1.0`` =
        Prefixed_Name(seas_stats, "ZoneOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>seas-stats:BuildingOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/BuildingOntology-1.0">https://w3id.org/seas/BuildingOntology-1.0</seealso>
    let ``BuildingOntology_1.0`` =
        Prefixed_Name(seas_stats, "BuildingOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>seas-stats:OperatingOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/OperatingOntology-1.0">https://w3id.org/seas/OperatingOntology-1.0</seealso>
    let ``OperatingOntology_1.0`` =
        Prefixed_Name(seas_stats, "OperatingOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>seas-stats:GreenKPIOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/GreenKPIOntology-1.0">https://w3id.org/seas/GreenKPIOntology-1.0</seealso>
    let ``GreenKPIOntology_1.0`` =
        Prefixed_Name(seas_stats, "GreenKPIOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>seas-stats:FlexibilityOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/FlexibilityOntology-1.0">https://w3id.org/seas/FlexibilityOntology-1.0</seealso>
    let ``FlexibilityOntology_1.0`` =
        Prefixed_Name(seas_stats, "FlexibilityOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>seas-stats:ComplexOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/ComplexOntology-1.0">https://w3id.org/seas/ComplexOntology-1.0</seealso>
    let ``ComplexOntology_1.0`` =
        Prefixed_Name(seas_stats, "ComplexOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>seas-stats:TradingOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/TradingOntology-1.0">https://w3id.org/seas/TradingOntology-1.0</seealso>
    let ``TradingOntology_1.0`` =
        Prefixed_Name(seas_stats, "TradingOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>seas-stats:PeriodicSignalOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/PeriodicSignalOntology-1.0">https://w3id.org/seas/PeriodicSignalOntology-1.0</seealso>
    let ``PeriodicSignalOntology_1.0`` =
        Prefixed_Name(seas_stats, "PeriodicSignalOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>seas-stats:BatteryOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/BatteryOntology-1.0">https://w3id.org/seas/BatteryOntology-1.0</seealso>
    let ``BatteryOntology_1.0`` =
        Prefixed_Name(seas_stats, "BatteryOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>seas-stats:ElectricVehicleOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/ElectricVehicleOntology-1.0">https://w3id.org/seas/ElectricVehicleOntology-1.0</seealso>
    let ``ElectricVehicleOntology_1.0`` =
        Prefixed_Name(seas_stats, "ElectricVehicleOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>seas-stats:ForecastingOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/ForecastingOntology-1.0">https://w3id.org/seas/ForecastingOntology-1.0</seealso>
    let ``ForecastingOntology_1.0`` =
        Prefixed_Name(seas_stats, "ForecastingOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>seas-stats:PhotovoltaicOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/PhotovoltaicOntology-1.0">https://w3id.org/seas/PhotovoltaicOntology-1.0</seealso>
    let ``PhotovoltaicOntology_1.0`` =
        Prefixed_Name(seas_stats, "PhotovoltaicOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>seas-stats:ArchitectureOntology-2.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/ArchitectureOntology-2.0">https://w3id.org/seas/ArchitectureOntology-2.0</seealso>
    let ``ArchitectureOntology_2.0`` =
        Prefixed_Name(seas_stats, "ArchitectureOntology-2.0") |> PrefixedName

    /// <summary>
    ///   <para>seas-stats:FailableSystemOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/FailableSystemOntology-1.0">https://w3id.org/seas/FailableSystemOntology-1.0</seealso>
    let ``FailableSystemOntology_1.0`` =
        Prefixed_Name(seas_stats, "FailableSystemOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>seas-stats:SystemOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/SystemOntology-1.0">https://w3id.org/seas/SystemOntology-1.0</seealso>
    let ``SystemOntology_1.0`` =
        Prefixed_Name(seas_stats, "SystemOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>seas-stats:ElectricPowerSystemOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/ElectricPowerSystemOntology-1.0">https://w3id.org/seas/ElectricPowerSystemOntology-1.0</seealso>
    let ``ElectricPowerSystemOntology_1.0`` =
        Prefixed_Name(seas_stats, "ElectricPowerSystemOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>seas-stats:EvaluationOntology-1.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/EvaluationOntology-1.0">https://w3id.org/seas/EvaluationOntology-1.0</seealso>
    let ``EvaluationOntology_1.0`` =
        Prefixed_Name(seas_stats, "EvaluationOntology-1.0") |> PrefixedName

    /// <summary>
    ///   <para>seas-stats:seas-0.9</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/seas/seas-0.9">https://w3id.org/seas/seas-0.9</seealso>
    let ``seas_0.9`` = Prefixed_Name(seas_stats, "seas-0.9") |> PrefixedName
