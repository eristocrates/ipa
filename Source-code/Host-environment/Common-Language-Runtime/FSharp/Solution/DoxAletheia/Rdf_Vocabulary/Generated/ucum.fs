namespace http.purl.oclc.org.NET.muo.ucum.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ucum =
    let _namespace_iri = Namespace_Iri ucum |> NamespaceIRI
    /// <summary>
    ///   <para>ucum:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/ucum/">http://purl.oclc.org/NET/muo/ucum/</seealso>
    let _prefix_iri = Prefixed_Name(ucum, "") |> PrefixedName
    /// <summary>
    ///   <para>ucum:code1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/ucum/code1">http://purl.oclc.org/NET/muo/ucum/code1</seealso>
    let code1 = Prefixed_Name(ucum, "code1") |> PrefixedName
    /// <summary>
    ///   <para>ucum:code2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/ucum/code2">http://purl.oclc.org/NET/muo/ucum/code2</seealso>
    let code2 = Prefixed_Name(ucum, "code2") |> PrefixedName

    /// <summary>
    ///   <para>ucum:physical-quality/area</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/ucum/physical-quality/area">http://purl.oclc.org/NET/muo/ucum/physical-quality/area</seealso>
    let ``physical_quality/area`` =
        Prefixed_Name(ucum, "physical-quality/area") |> PrefixedName

    /// <summary>
    ///   <para>ucum:physical-quality/length</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/ucum/physical-quality/length">http://purl.oclc.org/NET/muo/ucum/physical-quality/length</seealso>
    let ``physical_quality/length`` =
        Prefixed_Name(ucum, "physical-quality/length") |> PrefixedName

    /// <summary>
    ///   <para>ucum:physical-quality/pressure</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/ucum/physical-quality/pressure">http://purl.oclc.org/NET/muo/ucum/physical-quality/pressure</seealso>
    let ``physical_quality/pressure`` =
        Prefixed_Name(ucum, "physical-quality/pressure") |> PrefixedName

    /// <summary>
    ///   <para>ucum:prefix/hecto</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/ucum/prefix/hecto">http://purl.oclc.org/NET/muo/ucum/prefix/hecto</seealso>
    let ``prefix/hecto`` = Prefixed_Name(ucum, "prefix/hecto") |> PrefixedName
    /// <summary>
    ///   <para>ucum:prefix/milli</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/ucum/prefix/milli">http://purl.oclc.org/NET/muo/ucum/prefix/milli</seealso>
    let ``prefix/milli`` = Prefixed_Name(ucum, "prefix/milli") |> PrefixedName

    /// <summary>
    ///   <para>ucum:unit/fraction/percent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/ucum/unit/fraction/percent">http://purl.oclc.org/NET/muo/ucum/unit/fraction/percent</seealso>
    let ``unit/fraction/percent`` =
        Prefixed_Name(ucum, "unit/fraction/percent") |> PrefixedName

    /// <summary>
    ///   <para>ucum:unit/length/meter</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/ucum/unit/length/meter">http://purl.oclc.org/NET/muo/ucum/unit/length/meter</seealso>
    let ``unit/length/meter`` = Prefixed_Name(ucum, "unit/length/meter") |> PrefixedName

    /// <summary>
    ///   <para>ucum:unit/plane-angle/degree</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/ucum/unit/plane-angle/degree">http://purl.oclc.org/NET/muo/ucum/unit/plane-angle/degree</seealso>
    let ``unit/plane_angle/degree`` =
        Prefixed_Name(ucum, "unit/plane-angle/degree") |> PrefixedName

    /// <summary>
    ///   <para>ucum:unit/power/Watt</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/ucum/unit/power/Watt">http://purl.oclc.org/NET/muo/ucum/unit/power/Watt</seealso>
    let ``unit/power/Watt`` = Prefixed_Name(ucum, "unit/power/Watt") |> PrefixedName

    /// <summary>
    ///   <para>ucum:unit/pressure/Pascal</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/ucum/unit/pressure/Pascal">http://purl.oclc.org/NET/muo/ucum/unit/pressure/Pascal</seealso>
    let ``unit/pressure/Pascal`` =
        Prefixed_Name(ucum, "unit/pressure/Pascal") |> PrefixedName

    /// <summary>
    ///   <para>ucum:unit/temperature/degree-Celsius</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/ucum/unit/temperature/degree-Celsius">http://purl.oclc.org/NET/muo/ucum/unit/temperature/degree-Celsius</seealso>
    let ``unit/temperature/degree_Celsius`` =
        Prefixed_Name(ucum, "unit/temperature/degree-Celsius") |> PrefixedName

    /// <summary>
    ///   <para>ucum:unit/time/hour</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/ucum/unit/time/hour">http://purl.oclc.org/NET/muo/ucum/unit/time/hour</seealso>
    let ``unit/time/hour`` = Prefixed_Name(ucum, "unit/time/hour") |> PrefixedName
    /// <summary>
    ///   <para>ucum:unit/time/second</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.oclc.org/NET/muo/ucum/unit/time/second">http://purl.oclc.org/NET/muo/ucum/unit/time/second</seealso>
    let ``unit/time/second`` = Prefixed_Name(ucum, "unit/time/second") |> PrefixedName
