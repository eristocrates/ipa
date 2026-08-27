namespace https.www.omg.org.spec.Commons.QuantitiesAndUnits.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module QuantitiesAndUnits =
    let _namespace_iri = Namespace_Iri QuantitiesAndUnits |> NamespaceIRI
    /// <summary>
    ///   <para>QuantitiesAndUnits:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/">https://www.omg.org/spec/Commons/QuantitiesAndUnits/</seealso>
    let _prefix_iri = Prefixed_Name(QuantitiesAndUnits, "") |> PrefixedName
    /// <summary>
    ///   <para>QuantitiesAndUnits:Expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/Expression">https://www.omg.org/spec/Commons/QuantitiesAndUnits/Expression</seealso>
    let Expression = Prefixed_Name(QuantitiesAndUnits, "Expression") |> PrefixedName
    /// <summary>
    ///   <para>QuantitiesAndUnits:Measure</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/Measure">https://www.omg.org/spec/Commons/QuantitiesAndUnits/Measure</seealso>
    let Measure = Prefixed_Name(QuantitiesAndUnits, "Measure") |> PrefixedName

    /// <summary>
    ///   <para>QuantitiesAndUnits:MeasurementUnit</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/MeasurementUnit">https://www.omg.org/spec/Commons/QuantitiesAndUnits/MeasurementUnit</seealso>
    let MeasurementUnit =
        Prefixed_Name(QuantitiesAndUnits, "MeasurementUnit") |> PrefixedName

    /// <summary>
    ///   <para>QuantitiesAndUnits:Percentage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/Percentage">https://www.omg.org/spec/Commons/QuantitiesAndUnits/Percentage</seealso>
    let Percentage = Prefixed_Name(QuantitiesAndUnits, "Percentage") |> PrefixedName
    /// <summary>
    ///   <para>QuantitiesAndUnits:QuantityKind</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/QuantityKind">https://www.omg.org/spec/Commons/QuantitiesAndUnits/QuantityKind</seealso>
    let QuantityKind = Prefixed_Name(QuantitiesAndUnits, "QuantityKind") |> PrefixedName
    /// <summary>
    ///   <para>QuantitiesAndUnits:Ratio</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/Ratio">https://www.omg.org/spec/Commons/QuantitiesAndUnits/Ratio</seealso>
    let Ratio = Prefixed_Name(QuantitiesAndUnits, "Ratio") |> PrefixedName

    /// <summary>
    ///   <para>QuantitiesAndUnits:ScalarQuantityValue</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/ScalarQuantityValue">https://www.omg.org/spec/Commons/QuantitiesAndUnits/ScalarQuantityValue</seealso>
    let ScalarQuantityValue =
        Prefixed_Name(QuantitiesAndUnits, "ScalarQuantityValue") |> PrefixedName

    /// <summary>
    ///   <para>QuantitiesAndUnits:ScalarQuantityValueRange</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/ScalarQuantityValueRange">https://www.omg.org/spec/Commons/QuantitiesAndUnits/ScalarQuantityValueRange</seealso>
    let ScalarQuantityValueRange =
        Prefixed_Name(QuantitiesAndUnits, "ScalarQuantityValueRange") |> PrefixedName

    /// <summary>
    ///   <para>QuantitiesAndUnits:Variable</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/Variable">https://www.omg.org/spec/Commons/QuantitiesAndUnits/Variable</seealso>
    let Variable = Prefixed_Name(QuantitiesAndUnits, "Variable") |> PrefixedName

    /// <summary>
    ///   <para>QuantitiesAndUnits:describesActualExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/describesActualExpression">https://www.omg.org/spec/Commons/QuantitiesAndUnits/describesActualExpression</seealso>
    let describesActualExpression =
        Prefixed_Name(QuantitiesAndUnits, "describesActualExpression") |> PrefixedName

    /// <summary>
    ///   <para>QuantitiesAndUnits:hasArgument</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/hasArgument">https://www.omg.org/spec/Commons/QuantitiesAndUnits/hasArgument</seealso>
    let hasArgument = Prefixed_Name(QuantitiesAndUnits, "hasArgument") |> PrefixedName

    /// <summary>
    ///   <para>QuantitiesAndUnits:hasExpression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/hasExpression">https://www.omg.org/spec/Commons/QuantitiesAndUnits/hasExpression</seealso>
    let hasExpression =
        Prefixed_Name(QuantitiesAndUnits, "hasExpression") |> PrefixedName

    /// <summary>
    ///   <para>QuantitiesAndUnits:hasMeasurementUnit</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/hasMeasurementUnit">https://www.omg.org/spec/Commons/QuantitiesAndUnits/hasMeasurementUnit</seealso>
    let hasMeasurementUnit =
        Prefixed_Name(QuantitiesAndUnits, "hasMeasurementUnit") |> PrefixedName

    /// <summary>
    ///   <para>QuantitiesAndUnits:hasNumericValue</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/hasNumericValue">https://www.omg.org/spec/Commons/QuantitiesAndUnits/hasNumericValue</seealso>
    let hasNumericValue =
        Prefixed_Name(QuantitiesAndUnits, "hasNumericValue") |> PrefixedName

    /// <summary>
    ///   <para>QuantitiesAndUnits:hasQuantityKind</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/hasQuantityKind">https://www.omg.org/spec/Commons/QuantitiesAndUnits/hasQuantityKind</seealso>
    let hasQuantityKind =
        Prefixed_Name(QuantitiesAndUnits, "hasQuantityKind") |> PrefixedName

    /// <summary>
    ///   <para>QuantitiesAndUnits:hasQuantityValue</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/hasQuantityValue">https://www.omg.org/spec/Commons/QuantitiesAndUnits/hasQuantityValue</seealso>
    let hasQuantityValue =
        Prefixed_Name(QuantitiesAndUnits, "hasQuantityValue") |> PrefixedName

    /// <summary>
    ///   <para>QuantitiesAndUnits:hasQuantityValueRange</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/hasQuantityValueRange">https://www.omg.org/spec/Commons/QuantitiesAndUnits/hasQuantityValueRange</seealso>
    let hasQuantityValueRange =
        Prefixed_Name(QuantitiesAndUnits, "hasQuantityValueRange") |> PrefixedName

    /// <summary>
    ///   <para>QuantitiesAndUnits:isValueOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/QuantitiesAndUnits/isValueOf">https://www.omg.org/spec/Commons/QuantitiesAndUnits/isValueOf</seealso>
    let isValueOf = Prefixed_Name(QuantitiesAndUnits, "isValueOf") |> PrefixedName
