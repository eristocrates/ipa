namespace http.www.w3.org._2003._11.swrlb.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swrlb =
    let _namespace_iri = Namespace_Iri swrlb |> NamespaceIRI
    /// <summary>
    ///   <para>swrlb:add</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2003/11/swrlb#add">http://www.w3.org/2003/11/swrlb#add</seealso>
    let add = Prefixed_Name(swrlb, "add") |> PrefixedName
    /// <summary>
    ///   <para>swrlb:equal</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2003/11/swrlb#equal">http://www.w3.org/2003/11/swrlb#equal</seealso>
    let equal = Prefixed_Name(swrlb, "equal") |> PrefixedName
    /// <summary>
    ///   <para>swrlb:greaterThan</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2003/11/swrlb#greaterThan">http://www.w3.org/2003/11/swrlb#greaterThan</seealso>
    let greaterThan = Prefixed_Name(swrlb, "greaterThan") |> PrefixedName
    /// <summary>
    ///   <para>swrlb:lessThanOrEqual</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2003/11/swrlb#lessThanOrEqual">http://www.w3.org/2003/11/swrlb#lessThanOrEqual</seealso>
    let lessThanOrEqual = Prefixed_Name(swrlb, "lessThanOrEqual") |> PrefixedName
    /// <summary>
    ///   <para>swrlb:notEqual</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2003/11/swrlb#notEqual">http://www.w3.org/2003/11/swrlb#notEqual</seealso>
    let notEqual = Prefixed_Name(swrlb, "notEqual") |> PrefixedName
