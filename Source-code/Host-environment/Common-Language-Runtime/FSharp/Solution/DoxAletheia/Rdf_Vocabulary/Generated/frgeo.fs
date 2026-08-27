namespace http.rdf.insee.fr.geo.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module frgeo =
    let _namespace_iri = Namespace_Iri frgeo |> NamespaceIRI

    /// <summary>
    ///   <para>frgeo:ontologie-geo-2006.rdf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.insee.fr/geo/ontologie-geo-2006.rdf">http://rdf.insee.fr/geo/ontologie-geo-2006.rdf</seealso>
    let ``ontologie_geo_2006.rdf`` =
        Prefixed_Name(frgeo, "ontologie-geo-2006.rdf") |> PrefixedName
