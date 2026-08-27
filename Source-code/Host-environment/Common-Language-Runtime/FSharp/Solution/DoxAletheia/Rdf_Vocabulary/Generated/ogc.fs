namespace http.www.opengis.net.def.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ogc =
    let _namespace_iri = Namespace_Iri ogc |> NamespaceIRI
    /// <summary>
    ///   <para>ogc:crs/OGC/1.3/CRS84</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.opengis.net/def/crs/OGC/1.3/CRS84">http://www.opengis.net/def/crs/OGC/1.3/CRS84</seealso>
    let ``crs/OGC/1.3/CRS84`` = Prefixed_Name(ogc, "crs/OGC/1.3/CRS84") |> PrefixedName

    /// <summary>
    ///   <para>ogc:uom/ISO-8601/0/Gregorian</para>
    /// </summary>
    /// <remarks>
    ///   <para>"Composite unit (century, year, month, day, hour, minute, second, millisecond) defining the scale for the gregorian calendar used in ISO 8601. Note that this just identifies the scale and can be used with different time reference systems (UTC, UT1, GPS, etc.)."</para>
    /// </remarks>
    /// <seealso href="http://www.opengis.net/def/uom/ISO-8601/0/Gregorian">http://www.opengis.net/def/uom/ISO-8601/0/Gregorian</seealso>
    let ``uom/ISO_8601/0/Gregorian`` =
        Prefixed_Name(ogc, "uom/ISO-8601/0/Gregorian") |> PrefixedName
