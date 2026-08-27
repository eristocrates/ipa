namespace http.www.loa_cnr.it.ontologies.TemporalRelations.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module p3 =
    let _namespace_iri = Namespace_Iri p3 |> NamespaceIRI
    /// <summary>
    ///   <para>p3:concluded-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/TemporalRelations.owl#concluded-by">http://www.loa-cnr.it/ontologies/TemporalRelations.owl#concluded-by</seealso>
    let concluded_by = Prefixed_Name(p3, "concluded-by") |> PrefixedName
    /// <summary>
    ///   <para>p3:concludes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/TemporalRelations.owl#concludes">http://www.loa-cnr.it/ontologies/TemporalRelations.owl#concludes</seealso>
    let concludes = Prefixed_Name(p3, "concludes") |> PrefixedName
    /// <summary>
    ///   <para>p3:e-temporal-location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/TemporalRelations.owl#e-temporal-location">http://www.loa-cnr.it/ontologies/TemporalRelations.owl#e-temporal-location</seealso>
    let e_temporal_location = Prefixed_Name(p3, "e-temporal-location") |> PrefixedName

    /// <summary>
    ///   <para>p3:e-temporal-location-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/TemporalRelations.owl#e-temporal-location-of">http://www.loa-cnr.it/ontologies/TemporalRelations.owl#e-temporal-location-of</seealso>
    let e_temporal_location_of =
        Prefixed_Name(p3, "e-temporal-location-of") |> PrefixedName

    /// <summary>
    ///   <para>p3:follows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/TemporalRelations.owl#follows">http://www.loa-cnr.it/ontologies/TemporalRelations.owl#follows</seealso>
    let follows = Prefixed_Name(p3, "follows") |> PrefixedName
    /// <summary>
    ///   <para>p3:meets</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/TemporalRelations.owl#meets">http://www.loa-cnr.it/ontologies/TemporalRelations.owl#meets</seealso>
    let meets = Prefixed_Name(p3, "meets") |> PrefixedName
    /// <summary>
    ///   <para>p3:met-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/TemporalRelations.owl#met-by">http://www.loa-cnr.it/ontologies/TemporalRelations.owl#met-by</seealso>
    let met_by = Prefixed_Name(p3, "met-by") |> PrefixedName
    /// <summary>
    ///   <para>p3:precedes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/TemporalRelations.owl#precedes">http://www.loa-cnr.it/ontologies/TemporalRelations.owl#precedes</seealso>
    let precedes = Prefixed_Name(p3, "precedes") |> PrefixedName
    /// <summary>
    ///   <para>p3:present-at</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/TemporalRelations.owl#present-at">http://www.loa-cnr.it/ontologies/TemporalRelations.owl#present-at</seealso>
    let present_at = Prefixed_Name(p3, "present-at") |> PrefixedName
    /// <summary>
    ///   <para>p3:started-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/TemporalRelations.owl#started-by">http://www.loa-cnr.it/ontologies/TemporalRelations.owl#started-by</seealso>
    let started_by = Prefixed_Name(p3, "started-by") |> PrefixedName
    /// <summary>
    ///   <para>p3:starts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/TemporalRelations.owl#starts">http://www.loa-cnr.it/ontologies/TemporalRelations.owl#starts</seealso>
    let starts = Prefixed_Name(p3, "starts") |> PrefixedName
    /// <summary>
    ///   <para>p3:temporal-location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/TemporalRelations.owl#temporal-location">http://www.loa-cnr.it/ontologies/TemporalRelations.owl#temporal-location</seealso>
    let temporal_location = Prefixed_Name(p3, "temporal-location") |> PrefixedName
    /// <summary>
    ///   <para>p3:temporal-location-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/TemporalRelations.owl#temporal-location-of">http://www.loa-cnr.it/ontologies/TemporalRelations.owl#temporal-location-of</seealso>
    let temporal_location_of = Prefixed_Name(p3, "temporal-location-of") |> PrefixedName
    /// <summary>
    ///   <para>p3:temporal-relation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/TemporalRelations.owl#temporal-relation">http://www.loa-cnr.it/ontologies/TemporalRelations.owl#temporal-relation</seealso>
    let temporal_relation = Prefixed_Name(p3, "temporal-relation") |> PrefixedName
    /// <summary>
    ///   <para>p3:temporal-relation-i</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/TemporalRelations.owl#temporal-relation-i">http://www.loa-cnr.it/ontologies/TemporalRelations.owl#temporal-relation-i</seealso>
    let temporal_relation_i = Prefixed_Name(p3, "temporal-relation-i") |> PrefixedName
    /// <summary>
    ///   <para>p3:temporally-coincides</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/TemporalRelations.owl#temporally-coincides">http://www.loa-cnr.it/ontologies/TemporalRelations.owl#temporally-coincides</seealso>
    let temporally_coincides = Prefixed_Name(p3, "temporally-coincides") |> PrefixedName
    /// <summary>
    ///   <para>p3:temporally-connected</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/TemporalRelations.owl#temporally-connected">http://www.loa-cnr.it/ontologies/TemporalRelations.owl#temporally-connected</seealso>
    let temporally_connected = Prefixed_Name(p3, "temporally-connected") |> PrefixedName

    /// <summary>
    ///   <para>p3:temporally-included-in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/TemporalRelations.owl#temporally-included-in">http://www.loa-cnr.it/ontologies/TemporalRelations.owl#temporally-included-in</seealso>
    let temporally_included_in =
        Prefixed_Name(p3, "temporally-included-in") |> PrefixedName

    /// <summary>
    ///   <para>p3:temporally-includes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/TemporalRelations.owl#temporally-includes">http://www.loa-cnr.it/ontologies/TemporalRelations.owl#temporally-includes</seealso>
    let temporally_includes = Prefixed_Name(p3, "temporally-includes") |> PrefixedName
    /// <summary>
    ///   <para>p3:temporally-overlaps</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/TemporalRelations.owl#temporally-overlaps">http://www.loa-cnr.it/ontologies/TemporalRelations.owl#temporally-overlaps</seealso>
    let temporally_overlaps = Prefixed_Name(p3, "temporally-overlaps") |> PrefixedName
    /// <summary>
    ///   <para>p3:time-of-presence-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/TemporalRelations.owl#time-of-presence-of">http://www.loa-cnr.it/ontologies/TemporalRelations.owl#time-of-presence-of</seealso>
    let time_of_presence_of = Prefixed_Name(p3, "time-of-presence-of") |> PrefixedName
