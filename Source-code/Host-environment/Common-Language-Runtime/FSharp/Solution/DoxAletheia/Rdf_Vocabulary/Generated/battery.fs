namespace https.w3id.org.emmo.domain.battery.battery.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module battery =
    let _namespace_iri = Namespace_Iri battery |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:emmo/domain/battery/battery#Battery</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/battery/battery#Battery">https://w3id.org/emmo/domain/battery/battery#Battery</seealso>
    let Battery = Prefixed_Name(battery, "Battery") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/battery/battery#BatteryMeasurement</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/battery/battery#BatteryMeasurement">https://w3id.org/emmo/domain/battery/battery#BatteryMeasurement</seealso>
    let BatteryMeasurement =
        Prefixed_Name(battery, "BatteryMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/battery/battery#BatteryTimeSeriesDataSet</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/battery/battery#BatteryTimeSeriesDataSet">https://w3id.org/emmo/domain/battery/battery#BatteryTimeSeriesDataSet</seealso>
    let BatteryTimeSeriesDataSet =
        Prefixed_Name(battery, "BatteryTimeSeriesDataSet") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/battery/battery#battery_6c481323_498b_42c6_915a_53490f409430</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/battery/battery#battery_6c481323_498b_42c6_915a_53490f409430">https://w3id.org/emmo/domain/battery/battery#battery_6c481323_498b_42c6_915a_53490f409430</seealso>
    let battery_6c481323_498b_42c6_915a_53490f409430 =
        Prefixed_Name(battery, "battery_6c481323_498b_42c6_915a_53490f409430") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/battery/battery#battery_74ed2670_657d_4f0b_b0a6_3f13bc2e9c17</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/battery/battery#battery_74ed2670_657d_4f0b_b0a6_3f13bc2e9c17">https://w3id.org/emmo/domain/battery/battery#battery_74ed2670_657d_4f0b_b0a6_3f13bc2e9c17</seealso>
    let battery_74ed2670_657d_4f0b_b0a6_3f13bc2e9c17 =
        Prefixed_Name(battery, "battery_74ed2670_657d_4f0b_b0a6_3f13bc2e9c17") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/battery/battery#battery_d9b99b14_44e8_473b_af8f_2a160429df69</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/battery/battery#battery_d9b99b14_44e8_473b_af8f_2a160429df69">https://w3id.org/emmo/domain/battery/battery#battery_d9b99b14_44e8_473b_af8f_2a160429df69</seealso>
    let battery_d9b99b14_44e8_473b_af8f_2a160429df69 =
        Prefixed_Name(battery, "battery_d9b99b14_44e8_473b_af8f_2a160429df69") |> PrefixedName
