namespace http.www.loa_cnr.it.ontologies.SpatialRelations.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module p2 =
    let _namespace_iri = Namespace_Iri p2 |> NamespaceIRI
    /// <summary>
    ///   <para>p2:approximate-location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/SpatialRelations.owl#approximate-location">http://www.loa-cnr.it/ontologies/SpatialRelations.owl#approximate-location</seealso>
    let approximate_location = Prefixed_Name(p2, "approximate-location") |> PrefixedName

    /// <summary>
    ///   <para>p2:approximate-location-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/SpatialRelations.owl#approximate-location-of">http://www.loa-cnr.it/ontologies/SpatialRelations.owl#approximate-location-of</seealso>
    let approximate_location_of =
        Prefixed_Name(p2, "approximate-location-of") |> PrefixedName

    /// <summary>
    ///   <para>p2:d-spatial-location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/SpatialRelations.owl#d-spatial-location">http://www.loa-cnr.it/ontologies/SpatialRelations.owl#d-spatial-location</seealso>
    let d_spatial_location = Prefixed_Name(p2, "d-spatial-location") |> PrefixedName

    /// <summary>
    ///   <para>p2:d-spatial-location-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/SpatialRelations.owl#d-spatial-location-of">http://www.loa-cnr.it/ontologies/SpatialRelations.owl#d-spatial-location-of</seealso>
    let d_spatial_location_of =
        Prefixed_Name(p2, "d-spatial-location-of") |> PrefixedName

    /// <summary>
    ///   <para>p2:descriptive-origin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/SpatialRelations.owl#descriptive-origin">http://www.loa-cnr.it/ontologies/SpatialRelations.owl#descriptive-origin</seealso>
    let descriptive_origin = Prefixed_Name(p2, "descriptive-origin") |> PrefixedName

    /// <summary>
    ///   <para>p2:descriptive-origin-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/SpatialRelations.owl#descriptive-origin-of">http://www.loa-cnr.it/ontologies/SpatialRelations.owl#descriptive-origin-of</seealso>
    let descriptive_origin_of =
        Prefixed_Name(p2, "descriptive-origin-of") |> PrefixedName

    /// <summary>
    ///   <para>p2:descriptive-place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/SpatialRelations.owl#descriptive-place">http://www.loa-cnr.it/ontologies/SpatialRelations.owl#descriptive-place</seealso>
    let descriptive_place = Prefixed_Name(p2, "descriptive-place") |> PrefixedName
    /// <summary>
    ///   <para>p2:descriptive-place-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/SpatialRelations.owl#descriptive-place-of">http://www.loa-cnr.it/ontologies/SpatialRelations.owl#descriptive-place-of</seealso>
    let descriptive_place_of = Prefixed_Name(p2, "descriptive-place-of") |> PrefixedName
    /// <summary>
    ///   <para>p2:material-place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/SpatialRelations.owl#material-place">http://www.loa-cnr.it/ontologies/SpatialRelations.owl#material-place</seealso>
    let material_place = Prefixed_Name(p2, "material-place") |> PrefixedName
    /// <summary>
    ///   <para>p2:material-place-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/SpatialRelations.owl#material-place-of">http://www.loa-cnr.it/ontologies/SpatialRelations.owl#material-place-of</seealso>
    let material_place_of = Prefixed_Name(p2, "material-place-of") |> PrefixedName
    /// <summary>
    ///   <para>p2:origin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/SpatialRelations.owl#origin">http://www.loa-cnr.it/ontologies/SpatialRelations.owl#origin</seealso>
    let origin = Prefixed_Name(p2, "origin") |> PrefixedName
    /// <summary>
    ///   <para>p2:origin-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/SpatialRelations.owl#origin-of">http://www.loa-cnr.it/ontologies/SpatialRelations.owl#origin-of</seealso>
    let origin_of = Prefixed_Name(p2, "origin-of") |> PrefixedName
    /// <summary>
    ///   <para>p2:p-spatial-location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/SpatialRelations.owl#p-spatial-location">http://www.loa-cnr.it/ontologies/SpatialRelations.owl#p-spatial-location</seealso>
    let p_spatial_location = Prefixed_Name(p2, "p-spatial-location") |> PrefixedName

    /// <summary>
    ///   <para>p2:p-spatial-location-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/SpatialRelations.owl#p-spatial-location-of">http://www.loa-cnr.it/ontologies/SpatialRelations.owl#p-spatial-location-of</seealso>
    let p_spatial_location_of =
        Prefixed_Name(p2, "p-spatial-location-of") |> PrefixedName

    /// <summary>
    ///   <para>p2:participant-place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/SpatialRelations.owl#participant-place">http://www.loa-cnr.it/ontologies/SpatialRelations.owl#participant-place</seealso>
    let participant_place = Prefixed_Name(p2, "participant-place") |> PrefixedName
    /// <summary>
    ///   <para>p2:participant-place-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/SpatialRelations.owl#participant-place-of">http://www.loa-cnr.it/ontologies/SpatialRelations.owl#participant-place-of</seealso>
    let participant_place_of = Prefixed_Name(p2, "participant-place-of") |> PrefixedName
    /// <summary>
    ///   <para>p2:place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/SpatialRelations.owl#place">http://www.loa-cnr.it/ontologies/SpatialRelations.owl#place</seealso>
    let place = Prefixed_Name(p2, "place") |> PrefixedName
    /// <summary>
    ///   <para>p2:place-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/SpatialRelations.owl#place-of">http://www.loa-cnr.it/ontologies/SpatialRelations.owl#place-of</seealso>
    let place_of = Prefixed_Name(p2, "place-of") |> PrefixedName
    /// <summary>
    ///   <para>p2:spatial-location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/SpatialRelations.owl#spatial-location">http://www.loa-cnr.it/ontologies/SpatialRelations.owl#spatial-location</seealso>
    let spatial_location = Prefixed_Name(p2, "spatial-location") |> PrefixedName
    /// <summary>
    ///   <para>p2:spatial-location-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/SpatialRelations.owl#spatial-location-of">http://www.loa-cnr.it/ontologies/SpatialRelations.owl#spatial-location-of</seealso>
    let spatial_location_of = Prefixed_Name(p2, "spatial-location-of") |> PrefixedName
