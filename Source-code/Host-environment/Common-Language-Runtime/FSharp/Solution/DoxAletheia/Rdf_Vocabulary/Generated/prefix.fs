namespace http.prefix.cc.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module prefix =
    let _namespace_iri = Namespace_Iri prefix |> NamespaceIRI
    /// <summary>
    ///   <para>prefix:cdm</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://prefix.cc/cdm">http://prefix.cc/cdm</seealso>
    let cdm = Prefixed_Name(prefix, "cdm") |> PrefixedName
    /// <summary>
    ///   <para>prefix:conversion</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://prefix.cc/conversion">http://prefix.cc/conversion</seealso>
    let conversion = Prefixed_Name(prefix, "conversion") |> PrefixedName
    /// <summary>
    ///   <para>prefix:pc</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://prefix.cc/pc">http://prefix.cc/pc</seealso>
    let pc = Prefixed_Name(prefix, "pc") |> PrefixedName
