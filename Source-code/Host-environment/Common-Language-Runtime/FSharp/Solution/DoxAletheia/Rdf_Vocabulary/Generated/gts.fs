namespace http.resource.geosciml.org.ontology.timescale.gts.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module gts =
    let _namespace_iri = Namespace_Iri gts |> NamespaceIRI
    /// <summary>
    ///   <para>gts:GeochronologicEra</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Geochronologic Era</para></remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/gts#GeochronologicEra">http://resource.geosciml.org/ontology/timescale/gts#GeochronologicEra</seealso>
    let GeochronologicEra = Prefixed_Name(gts, "GeochronologicEra") |> PrefixedName
    /// <summary>
    ///   <para>gts:boundaryLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>the level within the section of the point characterizing the boundary</para>
    /// labels<para>boundary level</para></remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/gts#boundaryLevel">http://resource.geosciml.org/ontology/timescale/gts#boundaryLevel</seealso>
    let boundaryLevel = Prefixed_Name(gts, "boundaryLevel") |> PrefixedName
    /// <summary>
    ///   <para>gts:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/gts#">http://resource.geosciml.org/ontology/timescale/gts#</seealso>
    let _prefix_iri = Prefixed_Name(gts, "") |> PrefixedName
    /// <summary>
    ///   <para>gts:Eon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/gts#Eon">http://resource.geosciml.org/ontology/timescale/gts#Eon</seealso>
    let Eon = Prefixed_Name(gts, "Eon") |> PrefixedName
    /// <summary>
    ///   <para>gts:GeologicTimescale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Geologic Timescale</para></remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/gts#GeologicTimescale">http://resource.geosciml.org/ontology/timescale/gts#GeologicTimescale</seealso>
    let GeologicTimescale = Prefixed_Name(gts, "GeologicTimescale") |> PrefixedName
    /// <summary>
    ///   <para>gts:Epoch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/gts#Epoch">http://resource.geosciml.org/ontology/timescale/gts#Epoch</seealso>
    let Epoch = Prefixed_Name(gts, "Epoch") |> PrefixedName
    /// <summary>
    ///   <para>gts:correlationEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>the stratigraphic event that is intended to be represented by this stratigraphic point</para>
    /// labels<para>correlation event</para></remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/gts#correlationEvent">http://resource.geosciml.org/ontology/timescale/gts#correlationEvent</seealso>
    let correlationEvent = Prefixed_Name(gts, "correlationEvent") |> PrefixedName
    /// <summary>
    ///   <para>gts:geologicDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>geologic description</para></remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/gts#geologicDescription">http://resource.geosciml.org/ontology/timescale/gts#geologicDescription</seealso>
    let geologicDescription = Prefixed_Name(gts, "geologicDescription") |> PrefixedName
    /// <summary>
    ///   <para>gts:Sub-Period</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/gts#Sub-Period">http://resource.geosciml.org/ontology/timescale/gts#Sub-Period</seealso>
    let Sub_Period = Prefixed_Name(gts, "Sub-Period") |> PrefixedName
    /// <summary>
    ///   <para>gts:StratigraphicPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Stratigraphic Point</para></remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/gts#StratigraphicPoint">http://resource.geosciml.org/ontology/timescale/gts#StratigraphicPoint</seealso>
    let StratigraphicPoint = Prefixed_Name(gts, "StratigraphicPoint") |> PrefixedName
    /// <summary>
    ///   <para>gts:era</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>geochronologic era corresponding with this section</para>
    /// labels<para>geochronologic era</para></remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/gts#era">http://resource.geosciml.org/ontology/timescale/gts#era</seealso>
    let era = Prefixed_Name(gts, "era") |> PrefixedName
    /// <summary>
    ///   <para>gts:manifestedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property points from a geochronologic element to a geologic feature</para>
    /// labels<para>geologic manifestation</para></remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/gts#manifestedBy">http://resource.geosciml.org/ontology/timescale/gts#manifestedBy</seealso>
    let manifestedBy = Prefixed_Name(gts, "manifestedBy") |> PrefixedName

    /// <summary>
    ///   <para>gts:StratigraphicSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Stratigraphic Section</para></remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/gts#StratigraphicSection">http://resource.geosciml.org/ontology/timescale/gts#StratigraphicSection</seealso>
    let StratigraphicSection =
        Prefixed_Name(gts, "StratigraphicSection") |> PrefixedName

    /// <summary>
    ///   <para>gts:status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>formal ICS status of this boundary and point</para>
    /// labels<para>status</para></remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/gts#status">http://resource.geosciml.org/ontology/timescale/gts#status</seealso>
    let status = Prefixed_Name(gts, "status") |> PrefixedName
    /// <summary>
    ///   <para>gts:StratigraphicEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A subclass of Geologic Event (placeholder) </para>
    /// labels<para>Stratigraphic Event</para></remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/gts#StratigraphicEvent">http://resource.geosciml.org/ontology/timescale/gts#StratigraphicEvent</seealso>
    let StratigraphicEvent = Prefixed_Name(gts, "StratigraphicEvent") |> PrefixedName
    /// <summary>
    ///   <para>gts:Period</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/gts#Period">http://resource.geosciml.org/ontology/timescale/gts#Period</seealso>
    let Period = Prefixed_Name(gts, "Period") |> PrefixedName
    /// <summary>
    ///   <para>gts:Super-Eon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/gts#Super-Eon">http://resource.geosciml.org/ontology/timescale/gts#Super-Eon</seealso>
    let Super_Eon = Prefixed_Name(gts, "Super-Eon") |> PrefixedName
    /// <summary>
    ///   <para>gts:boundary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>geochronologic boundary corresponding with this point</para>
    /// labels<para>geochronologic boundary</para></remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/gts#boundary">http://resource.geosciml.org/ontology/timescale/gts#boundary</seealso>
    let boundary = Prefixed_Name(gts, "boundary") |> PrefixedName
    /// <summary>
    ///   <para>gts:ratifiedGSSP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>'true' if ratified by ICS</para>
    /// labels<para>ratified</para></remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/gts#ratifiedGSSP">http://resource.geosciml.org/ontology/timescale/gts#ratifiedGSSP</seealso>
    let ratifiedGSSP = Prefixed_Name(gts, "ratifiedGSSP") |> PrefixedName
    /// <summary>
    ///   <para>gts:geologicSetting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>geologic setting</para></remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/gts#geologicSetting">http://resource.geosciml.org/ontology/timescale/gts#geologicSetting</seealso>
    let geologicSetting = Prefixed_Name(gts, "geologicSetting") |> PrefixedName
    /// <summary>
    ///   <para>gts:correlatesWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property points from a geologic feature or event to a geochronologic element</para>
    /// labels<para>correlating boundary or era</para></remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/gts#correlatesWith">http://resource.geosciml.org/ontology/timescale/gts#correlatesWith</seealso>
    let correlatesWith = Prefixed_Name(gts, "correlatesWith") |> PrefixedName
    /// <summary>
    ///   <para>gts:event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>stratigraphic event corresponding with this boundary or point</para>
    /// labels<para>stratigraphic event</para></remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/gts#event">http://resource.geosciml.org/ontology/timescale/gts#event</seealso>
    let event_ = Prefixed_Name(gts, "event") |> PrefixedName

    /// <summary>
    ///   <para>gts:positionalUncertainty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Uncertainty in time position</para></remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/gts#positionalUncertainty">http://resource.geosciml.org/ontology/timescale/gts#positionalUncertainty</seealso>
    let positionalUncertainty =
        Prefixed_Name(gts, "positionalUncertainty") |> PrefixedName

    /// <summary>
    ///   <para>gts:rank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Elements of all ranks are included in the class 'gts:GeochronologicEra'.
    /// The rank may be indicated by membership of a sub-class, or is indicated using the 'gts:rank' property.</para>
    /// labels<para>Geochronologic era rank</para></remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/gts#rank">http://resource.geosciml.org/ontology/timescale/gts#rank</seealso>
    let rank = Prefixed_Name(gts, "rank") |> PrefixedName
    /// <summary>
    ///   <para>gts:Age</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/gts#Age">http://resource.geosciml.org/ontology/timescale/gts#Age</seealso>
    let Age = Prefixed_Name(gts, "Age") |> PrefixedName
    /// <summary>
    ///   <para>gts:Era</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/gts#Era">http://resource.geosciml.org/ontology/timescale/gts#Era</seealso>
    let Era = Prefixed_Name(gts, "Era") |> PrefixedName
    /// <summary>
    ///   <para>gts:EraCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>Era code</para></remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/gts#EraCode">http://resource.geosciml.org/ontology/timescale/gts#EraCode</seealso>
    let EraCode = Prefixed_Name(gts, "EraCode") |> PrefixedName

    /// <summary>
    ///   <para>gts:GeochronologicBoundary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Geochronologic Boundary</para></remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/gts#GeochronologicBoundary">http://resource.geosciml.org/ontology/timescale/gts#GeochronologicBoundary</seealso>
    let GeochronologicBoundary =
        Prefixed_Name(gts, "GeochronologicBoundary") |> PrefixedName

    /// <summary>
    ///   <para>gts:stratotype</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>the characteristic point or section corresponding with a geochronologic concept</para>
    /// labels<para>stratotype</para></remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/gts#stratotype">http://resource.geosciml.org/ontology/timescale/gts#stratotype</seealso>
    let stratotype = Prefixed_Name(gts, "stratotype") |> PrefixedName
    /// <summary>
    ///   <para>gts:NumericEraBoundary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Numeric Era Boundary</para></remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/gts#NumericEraBoundary">http://resource.geosciml.org/ontology/timescale/gts#NumericEraBoundary</seealso>
    let NumericEraBoundary = Prefixed_Name(gts, "NumericEraBoundary") |> PrefixedName

    /// <summary>
    ///   <para>gts:GeochronologicEraRank</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Geochronologic Era Rank</para></remarks>
    /// <seealso href="http://resource.geosciml.org/ontology/timescale/gts#GeochronologicEraRank">http://resource.geosciml.org/ontology/timescale/gts#GeochronologicEraRank</seealso>
    let GeochronologicEraRank =
        Prefixed_Name(gts, "GeochronologicEraRank") |> PrefixedName
