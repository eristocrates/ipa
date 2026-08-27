namespace http.sweet.jpl.nasa.gov._2._3.relaSci.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module screla =
    let _namespace_iri = Namespace_Iri screla |> NamespaceIRI
    /// <summary>
    ///   <para>screla:hasBaseUnit</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://sweet.jpl.nasa.gov/2.3/relaSci.owl#hasBaseUnit">http://sweet.jpl.nasa.gov/2.3/relaSci.owl#hasBaseUnit</seealso>
    let hasBaseUnit = Prefixed_Name(screla, "hasBaseUnit") |> PrefixedName
    /// <summary>
    ///   <para>screla:hasNumericValue</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://sweet.jpl.nasa.gov/2.3/relaSci.owl#hasNumericValue">http://sweet.jpl.nasa.gov/2.3/relaSci.owl#hasNumericValue</seealso>
    let hasNumericValue = Prefixed_Name(screla, "hasNumericValue") |> PrefixedName
    /// <summary>
    ///   <para>screla:hasPrefix</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://sweet.jpl.nasa.gov/2.3/relaSci.owl#hasPrefix">http://sweet.jpl.nasa.gov/2.3/relaSci.owl#hasPrefix</seealso>
    let hasPrefix = Prefixed_Name(screla, "hasPrefix") |> PrefixedName
    /// <summary>
    ///   <para>screla:hasSymbol</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://sweet.jpl.nasa.gov/2.3/relaSci.owl#hasSymbol">http://sweet.jpl.nasa.gov/2.3/relaSci.owl#hasSymbol</seealso>
    let hasSymbol = Prefixed_Name(screla, "hasSymbol") |> PrefixedName
