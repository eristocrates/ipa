namespace http.qudt.org._1._1.schema.qudt.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module qud =
    let _namespace_iri = Namespace_Iri qud |> NamespaceIRI
    /// <summary>
    ///   <para>qud:AngleUnit</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://qudt.org/1.1/schema/qudt#AngleUnit">http://qudt.org/1.1/schema/qudt#AngleUnit</seealso>
    let AngleUnit = Prefixed_Name(qud, "AngleUnit") |> PrefixedName
    /// <summary>
    ///   <para>qud:CountingUnit</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://qudt.org/1.1/schema/qudt#CountingUnit">http://qudt.org/1.1/schema/qudt#CountingUnit</seealso>
    let CountingUnit = Prefixed_Name(qud, "CountingUnit") |> PrefixedName
    /// <summary>
    ///   <para>qud:LengthUnit</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://qudt.org/1.1/schema/qudt#LengthUnit">http://qudt.org/1.1/schema/qudt#LengthUnit</seealso>
    let LengthUnit = Prefixed_Name(qud, "LengthUnit") |> PrefixedName
    /// <summary>
    ///   <para>qud:QuantityValue</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://qudt.org/1.1/schema/qudt#QuantityValue">http://qudt.org/1.1/schema/qudt#QuantityValue</seealso>
    let QuantityValue = Prefixed_Name(qud, "QuantityValue") |> PrefixedName
    /// <summary>
    ///   <para>qud:unit</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://qudt.org/1.1/schema/qudt#unit">http://qudt.org/1.1/schema/qudt#unit</seealso>
    let unit = Prefixed_Name(qud, "unit") |> PrefixedName
