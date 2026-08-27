namespace https.spec.edmcouncil.org.fibo.ontology.DER.DerivativesContracts.ExoticOptions.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_der_drc_exo =
    let _namespace_iri = Namespace_Iri fibo_der_drc_exo |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-der-drc-exo:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Exotic Options Ontology"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_der_drc_exo, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-exo:ArithmeticCalculationStrategy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-der-drc-exo:AveragingStrategy</para>
    ///
    /// labels<para>"arithmetic calculation strategy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/ArithmeticCalculationStrategy">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/ArithmeticCalculationStrategy</seealso>
    let ArithmeticCalculationStrategy =
        Prefixed_Name(fibo_der_drc_exo, "ArithmeticCalculationStrategy") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-exo:AsianOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Asian option"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/AsianOption">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/AsianOption</seealso>
    let AsianOption = Prefixed_Name(fibo_der_drc_exo, "AsianOption") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-exo:AsianOptionClassifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Asian option classifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/AsianOptionClassifier">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/AsianOptionClassifier</seealso>
    let AsianOptionClassifier =
        Prefixed_Name(fibo_der_drc_exo, "AsianOptionClassifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-exo:AverageRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-der-drc-exo:AsianOptionClassifier</para>
    ///
    /// labels<para>"average rate classification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/AverageRate">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/AverageRate</seealso>
    let AverageRate = Prefixed_Name(fibo_der_drc_exo, "AverageRate") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-exo:AverageStrike</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-der-drc-exo:AsianOptionClassifier</para>
    ///
    /// labels<para>"average strike classification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/AverageStrike">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/AverageStrike</seealso>
    let AverageStrike = Prefixed_Name(fibo_der_drc_exo, "AverageStrike") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-exo:AveragingStrategy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"averaging strategy"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/AveragingStrategy">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/AveragingStrategy</seealso>
    let AveragingStrategy =
        Prefixed_Name(fibo_der_drc_exo, "AveragingStrategy") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-exo:BarrierOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"barrier option"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/BarrierOption">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/BarrierOption</seealso>
    let BarrierOption = Prefixed_Name(fibo_der_drc_exo, "BarrierOption") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-exo:ChooserOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chooser option"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/ChooserOption">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/ChooserOption</seealso>
    let ChooserOption = Prefixed_Name(fibo_der_drc_exo, "ChooserOption") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-exo:CliquetOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cliquet option"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/CliquetOption">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/CliquetOption</seealso>
    let CliquetOption = Prefixed_Name(fibo_der_drc_exo, "CliquetOption") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-exo:CommodoreOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"commodore option"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/CommodoreOption">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/CommodoreOption</seealso>
    let CommodoreOption =
        Prefixed_Name(fibo_der_drc_exo, "CommodoreOption") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-exo:CompoundOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"compound option"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/CompoundOption">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/CompoundOption</seealso>
    let CompoundOption =
        Prefixed_Name(fibo_der_drc_exo, "CompoundOption") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-exo:DigitalOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"digital option"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/DigitalOption">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/DigitalOption</seealso>
    let DigitalOption = Prefixed_Name(fibo_der_drc_exo, "DigitalOption") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-exo:DoubleBarrierOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"double barrier option"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/DoubleBarrierOption">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/DoubleBarrierOption</seealso>
    let DoubleBarrierOption =
        Prefixed_Name(fibo_der_drc_exo, "DoubleBarrierOption") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-exo:FixedLookbackStrikeExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fixed lookback strike expression"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/FixedLookbackStrikeExpression">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/FixedLookbackStrikeExpression</seealso>
    let FixedLookbackStrikeExpression =
        Prefixed_Name(fibo_der_drc_exo, "FixedLookbackStrikeExpression") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-exo:FloatingLookbackStrikeExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"floating lookback strike expression"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/FloatingLookbackStrikeExpression">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/FloatingLookbackStrikeExpression</seealso>
    let FloatingLookbackStrikeExpression =
        Prefixed_Name(fibo_der_drc_exo, "FloatingLookbackStrikeExpression") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-exo:ForwardStartOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"forward start option"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/ForwardStartOption">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/ForwardStartOption</seealso>
    let ForwardStartOption =
        Prefixed_Name(fibo_der_drc_exo, "ForwardStartOption") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-exo:GeometricCalculationStrategy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-der-drc-exo:AveragingStrategy</para>
    ///
    /// labels<para>"geometric calculation strategy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/GeometricCalculationStrategy">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/GeometricCalculationStrategy</seealso>
    let GeometricCalculationStrategy =
        Prefixed_Name(fibo_der_drc_exo, "GeometricCalculationStrategy") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-exo:InterestRateCapOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interest rate cap option"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/InterestRateCapOption">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/InterestRateCapOption</seealso>
    let InterestRateCapOption =
        Prefixed_Name(fibo_der_drc_exo, "InterestRateCapOption") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-exo:InterestRateFloorOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interest rate floor option"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/InterestRateFloorOption">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/InterestRateFloorOption</seealso>
    let InterestRateFloorOption =
        Prefixed_Name(fibo_der_drc_exo, "InterestRateFloorOption") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-exo:KnockInOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"knock-in option"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/KnockInOption">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/KnockInOption</seealso>
    let KnockInOption = Prefixed_Name(fibo_der_drc_exo, "KnockInOption") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-exo:KnockOutOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"knock-out option"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/KnockOutOption">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/KnockOutOption</seealso>
    let KnockOutOption =
        Prefixed_Name(fibo_der_drc_exo, "KnockOutOption") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-exo:LookbackOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"lookback option"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/LookbackOption">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/LookbackOption</seealso>
    let LookbackOption =
        Prefixed_Name(fibo_der_drc_exo, "LookbackOption") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-exo:LookbackStrikeTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"lookback strike terms"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/LookbackStrikeTerms">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/LookbackStrikeTerms</seealso>
    let LookbackStrikeTerms =
        Prefixed_Name(fibo_der_drc_exo, "LookbackStrikeTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-exo:LowExercisePriceOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"low exercise price option"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/LowExercisePriceOption">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/LowExercisePriceOption</seealso>
    let LowExercisePriceOption =
        Prefixed_Name(fibo_der_drc_exo, "LowExercisePriceOption") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-exo:MountainRangeOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mountain range option"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/MountainRangeOption">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/MountainRangeOption</seealso>
    let MountainRangeOption =
        Prefixed_Name(fibo_der_drc_exo, "MountainRangeOption") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-exo:ObservedBestValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"observed best value"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/ObservedBestValue">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/ObservedBestValue</seealso>
    let ObservedBestValue =
        Prefixed_Name(fibo_der_drc_exo, "ObservedBestValue") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-exo:ProjectedValueAtMaturity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"projected value at maturity"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/ProjectedValueAtMaturity">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/ProjectedValueAtMaturity</seealso>
    let ProjectedValueAtMaturity =
        Prefixed_Name(fibo_der_drc_exo, "ProjectedValueAtMaturity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-exo:RainbowOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"rainbow option"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/RainbowOption">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/RainbowOption</seealso>
    let RainbowOption = Prefixed_Name(fibo_der_drc_exo, "RainbowOption") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-exo:Swaption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"swaption"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/Swaption">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/Swaption</seealso>
    let Swaption = Prefixed_Name(fibo_der_drc_exo, "Swaption") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-exo:hasAsianTailPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has Asian tail period"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/hasAsianTailPeriod">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/hasAsianTailPeriod</seealso>
    let hasAsianTailPeriod =
        Prefixed_Name(fibo_der_drc_exo, "hasAsianTailPeriod") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-exo:hasFirstBarrierPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has first barrier price"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/hasFirstBarrierPrice">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/hasFirstBarrierPrice</seealso>
    let hasFirstBarrierPrice =
        Prefixed_Name(fibo_der_drc_exo, "hasFirstBarrierPrice") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-exo:hasFirstRebateAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has first rebate amount"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/hasFirstRebateAmount">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/hasFirstRebateAmount</seealso>
    let hasFirstRebateAmount =
        Prefixed_Name(fibo_der_drc_exo, "hasFirstRebateAmount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-exo:hasLookbackPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has lookback period"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/hasLookbackPeriod">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/hasLookbackPeriod</seealso>
    let hasLookbackPeriod =
        Prefixed_Name(fibo_der_drc_exo, "hasLookbackPeriod") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-exo:hasMonitoringFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has monitoring frequency"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/hasMonitoringFrequency">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/hasMonitoringFrequency</seealso>
    let hasMonitoringFrequency =
        Prefixed_Name(fibo_der_drc_exo, "hasMonitoringFrequency") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-exo:hasMonitoringPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has monitoring period"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/hasMonitoringPeriod">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/hasMonitoringPeriod</seealso>
    let hasMonitoringPeriod =
        Prefixed_Name(fibo_der_drc_exo, "hasMonitoringPeriod") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-exo:hasOptionTypeElectionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has option type election date"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/hasOptionTypeElectionDate">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/hasOptionTypeElectionDate</seealso>
    let hasOptionTypeElectionDate =
        Prefixed_Name(fibo_der_drc_exo, "hasOptionTypeElectionDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-exo:hasSecondBarrierPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has second barrier price"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/hasSecondBarrierPrice">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/hasSecondBarrierPrice</seealso>
    let hasSecondBarrierPrice =
        Prefixed_Name(fibo_der_drc_exo, "hasSecondBarrierPrice") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-exo:hasSecondRebateAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has second rebate amount"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/hasSecondRebateAmount">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/hasSecondRebateAmount</seealso>
    let hasSecondRebateAmount =
        Prefixed_Name(fibo_der_drc_exo, "hasSecondRebateAmount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-exo:isAboveStrikePrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is above strike price"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/isAboveStrikePrice">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/isAboveStrikePrice</seealso>
    let isAboveStrikePrice =
        Prefixed_Name(fibo_der_drc_exo, "isAboveStrikePrice") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-exo:usesCurrencyInAveraging</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"uses currency in averaging"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/usesCurrencyInAveraging">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/usesCurrencyInAveraging</seealso>
    let usesCurrencyInAveraging =
        Prefixed_Name(fibo_der_drc_exo, "usesCurrencyInAveraging") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-exo:usesWeightedAverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"uses weighted average"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/usesWeightedAverage">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/usesWeightedAverage</seealso>
    let usesWeightedAverage =
        Prefixed_Name(fibo_der_drc_exo, "usesWeightedAverage") |> PrefixedName
