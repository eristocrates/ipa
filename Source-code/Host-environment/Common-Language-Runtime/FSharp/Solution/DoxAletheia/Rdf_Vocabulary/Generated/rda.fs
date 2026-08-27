namespace http.www.rdaregistry.info.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rda =
    let _namespace_iri = Namespace_Iri rda |> NamespaceIRI
    /// <summary>
    ///   <para>rda:Elements/a/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.rdaregistry.info/Elements/a/">http://www.rdaregistry.info/Elements/a/</seealso>
    let ``Elements/a/`` = Prefixed_Name(rda, "Elements/a/") |> PrefixedName
    /// <summary>
    ///   <para>rda:Elements/c/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.rdaregistry.info/Elements/c/">http://www.rdaregistry.info/Elements/c/</seealso>
    let ``Elements/c/`` = Prefixed_Name(rda, "Elements/c/") |> PrefixedName

    /// <summary>
    ///   <para>rda:Elements/e/#P20059</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has manifestation of expression"</para></remarks>
    /// <seealso href="http://www.rdaregistry.info/Elements/e/#P20059">http://www.rdaregistry.info/Elements/e/#P20059</seealso>
    let ``Elements/e/#P20059`` =
        Prefixed_Name(rda, "Elements/e/#P20059") |> PrefixedName

    /// <summary>
    ///   <para>rda:Elements/e/#P20231</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has work expressed"</para></remarks>
    /// <seealso href="http://www.rdaregistry.info/Elements/e/#P20231">http://www.rdaregistry.info/Elements/e/#P20231</seealso>
    let ``Elements/e/#P20231`` =
        Prefixed_Name(rda, "Elements/e/#P20231") |> PrefixedName

    /// <summary>
    ///   <para>rda:Elements/i/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.rdaregistry.info/Elements/i/">http://www.rdaregistry.info/Elements/i/</seealso>
    let ``Elements/i/`` = Prefixed_Name(rda, "Elements/i/") |> PrefixedName
    /// <summary>
    ///   <para>rda:Elements/m/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.rdaregistry.info/Elements/m/">http://www.rdaregistry.info/Elements/m/</seealso>
    let ``Elements/m/`` = Prefixed_Name(rda, "Elements/m/") |> PrefixedName

    /// <summary>
    ///   <para>rda:Elements/m/#P30139</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has expression manifested"</para></remarks>
    /// <seealso href="http://www.rdaregistry.info/Elements/m/#P30139">http://www.rdaregistry.info/Elements/m/#P30139</seealso>
    let ``Elements/m/#P30139`` =
        Prefixed_Name(rda, "Elements/m/#P30139") |> PrefixedName

    /// <summary>
    ///   <para>rda:Elements/u/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.rdaregistry.info/Elements/u/">http://www.rdaregistry.info/Elements/u/</seealso>
    let ``Elements/u/`` = Prefixed_Name(rda, "Elements/u/") |> PrefixedName
    /// <summary>
    ///   <para>rda:Elements/w/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.rdaregistry.info/Elements/w/">http://www.rdaregistry.info/Elements/w/</seealso>
    let ``Elements/w/`` = Prefixed_Name(rda, "Elements/w/") |> PrefixedName

    /// <summary>
    ///   <para>rda:Elements/w/#P10078</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has expression of work"</para></remarks>
    /// <seealso href="http://www.rdaregistry.info/Elements/w/#P10078">http://www.rdaregistry.info/Elements/w/#P10078</seealso>
    let ``Elements/w/#P10078`` =
        Prefixed_Name(rda, "Elements/w/#P10078") |> PrefixedName
