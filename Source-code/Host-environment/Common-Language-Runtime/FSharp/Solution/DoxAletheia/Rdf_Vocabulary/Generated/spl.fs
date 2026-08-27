namespace http.spinrdf.org.spl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module spl =
    let _namespace_iri = Namespace_Iri spl |> NamespaceIRI
    /// <summary>
    ///   <para>spl:Argument</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://spinrdf.org/spl#Argument">http://spinrdf.org/spl#Argument</seealso>
    let Argument = Prefixed_Name(spl, "Argument") |> PrefixedName
    /// <summary>
    ///   <para>spl:Attribute</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://spinrdf.org/spl#Attribute">http://spinrdf.org/spl#Attribute</seealso>
    let Attribute = Prefixed_Name(spl, "Attribute") |> PrefixedName

    /// <summary>
    ///   <para>spl:ConstructDefaultValues</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://spinrdf.org/spl#ConstructDefaultValues">http://spinrdf.org/spl#ConstructDefaultValues</seealso>
    let ConstructDefaultValues =
        Prefixed_Name(spl, "ConstructDefaultValues") |> PrefixedName

    /// <summary>
    ///   <para>spl:hasValue</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://spinrdf.org/spl#hasValue">http://spinrdf.org/spl#hasValue</seealso>
    let hasValue = Prefixed_Name(spl, "hasValue") |> PrefixedName
    /// <summary>
    ///   <para>spl:maxCount</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://spinrdf.org/spl#maxCount">http://spinrdf.org/spl#maxCount</seealso>
    let maxCount = Prefixed_Name(spl, "maxCount") |> PrefixedName
    /// <summary>
    ///   <para>spl:minCount</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://spinrdf.org/spl#minCount">http://spinrdf.org/spl#minCount</seealso>
    let minCount = Prefixed_Name(spl, "minCount") |> PrefixedName
    /// <summary>
    ///   <para>spl:predicate</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://spinrdf.org/spl#predicate">http://spinrdf.org/spl#predicate</seealso>
    let predicate = Prefixed_Name(spl, "predicate") |> PrefixedName
    /// <summary>
    ///   <para>spl:valueType</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://spinrdf.org/spl#valueType">http://spinrdf.org/spl#valueType</seealso>
    let valueType = Prefixed_Name(spl, "valueType") |> PrefixedName
