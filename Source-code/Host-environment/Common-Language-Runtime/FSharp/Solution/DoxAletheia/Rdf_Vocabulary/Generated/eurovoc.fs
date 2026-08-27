namespace http.eurovoc.europa.eu.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module eurovoc =
    let _namespace_iri = Namespace_Iri eurovoc |> NamespaceIRI
    /// <summary>
    ///   <para>eurovoc:100142</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://eurovoc.europa.eu/100142">http://eurovoc.europa.eu/100142</seealso>
    let _100142 = Prefixed_Name(eurovoc, "100142") |> PrefixedName
    /// <summary>
    ///   <para>eurovoc:2015</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://eurovoc.europa.eu/2015">http://eurovoc.europa.eu/2015</seealso>
    let _2015 = Prefixed_Name(eurovoc, "2015") |> PrefixedName
    /// <summary>
    ///   <para>eurovoc:259007</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://eurovoc.europa.eu/259007">http://eurovoc.europa.eu/259007</seealso>
    let _259007 = Prefixed_Name(eurovoc, "259007") |> PrefixedName
    /// <summary>
    ///   <para>eurovoc:5438</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://eurovoc.europa.eu/5438">http://eurovoc.europa.eu/5438</seealso>
    let _5438 = Prefixed_Name(eurovoc, "5438") |> PrefixedName
