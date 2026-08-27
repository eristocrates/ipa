namespace http.data.ordnancesurvey.co.uk.id.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module osgb =
    let _namespace_iri = Namespace_Iri osgb |> NamespaceIRI
    /// <summary>
    ///   <para>osgb:ordnancesurvey</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/id/ordnancesurvey">http://data.ordnancesurvey.co.uk/id/ordnancesurvey</seealso>
    let ordnancesurvey = Prefixed_Name(osgb, "ordnancesurvey") |> PrefixedName
