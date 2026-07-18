namespace http.resource.geosciml.org.ontology.timescale.gts.hash

open DoxAletheia.Rdf_Vocabulary

module gts =
    let _namespace_name = "http://resource.geosciml.org/ontology/timescale/gts#"
    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/gts#Age"></see>
    /// </summary>
    let Age = Namespaced_IRI.parse _namespace_name "Age" |> NamespacedName

    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/gts#GeochronologicEra"></see>
    /// </summary>
    let GeochronologicEra =
        Namespaced_IRI.parse _namespace_name "GeochronologicEra" |> NamespacedName

    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/gts#Eon"></see>
    /// </summary>
    let Eon = Namespaced_IRI.parse _namespace_name "Eon" |> NamespacedName
    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/gts#Epoch"></see>
    /// </summary>
    let Epoch = Namespaced_IRI.parse _namespace_name "Epoch" |> NamespacedName
    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/gts#Era"></see>
    /// </summary>
    let Era = Namespaced_IRI.parse _namespace_name "Era" |> NamespacedName
    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/gts#EraCode"></see>
    /// </summary>
    let EraCode = Namespaced_IRI.parse _namespace_name "EraCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/gts#GeochronologicBoundary"></see>
    /// </summary>
    let GeochronologicBoundary =
        Namespaced_IRI.parse _namespace_name "GeochronologicBoundary" |> NamespacedName

    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/gts#StratigraphicPoint"></see>
    /// </summary>
    let StratigraphicPoint =
        Namespaced_IRI.parse _namespace_name "StratigraphicPoint" |> NamespacedName

    /// <summary>
    /// the characteristic point or section corresponding with a geochronologic concept
    /// <see href="http://resource.geosciml.org/ontology/timescale/gts#stratotype"></see></summary>
    let stratotype = Namespaced_IRI.parse _namespace_name "stratotype" |> NamespacedName

    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/gts#NumericEraBoundary"></see>
    /// </summary>
    let NumericEraBoundary =
        Namespaced_IRI.parse _namespace_name "NumericEraBoundary" |> NamespacedName

    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/gts#StratigraphicSection"></see>
    /// </summary>
    let StratigraphicSection =
        Namespaced_IRI.parse _namespace_name "StratigraphicSection" |> NamespacedName

    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/gts#GeochronologicEraRank"></see>
    /// </summary>
    let GeochronologicEraRank =
        Namespaced_IRI.parse _namespace_name "GeochronologicEraRank" |> NamespacedName

    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/gts#GeologicTimescale"></see>
    /// </summary>
    let GeologicTimescale =
        Namespaced_IRI.parse _namespace_name "GeologicTimescale" |> NamespacedName

    /// <summary>
    /// formal ICS status of this boundary and point
    /// <see href="http://resource.geosciml.org/ontology/timescale/gts#status"></see></summary>
    let status = Namespaced_IRI.parse _namespace_name "status" |> NamespacedName
    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/gts#Period"></see>
    /// </summary>
    let Period = Namespaced_IRI.parse _namespace_name "Period" |> NamespacedName

    /// <summary>
    /// A subclass of Geologic Event (placeholder)
    /// <see href="http://resource.geosciml.org/ontology/timescale/gts#StratigraphicEvent"></see></summary>
    let StratigraphicEvent =
        Namespaced_IRI.parse _namespace_name "StratigraphicEvent" |> NamespacedName

    /// <summary>
    /// the stratigraphic event that is intended to be represented by this stratigraphic point
    /// <see href="http://resource.geosciml.org/ontology/timescale/gts#correlationEvent"></see></summary>
    let correlationEvent =
        Namespaced_IRI.parse _namespace_name "correlationEvent" |> NamespacedName

    /// <summary>
    /// 'true' if ratified by ICS
    /// <see href="http://resource.geosciml.org/ontology/timescale/gts#ratifiedGSSP"></see></summary>
    let ratifiedGSSP =
        Namespaced_IRI.parse _namespace_name "ratifiedGSSP" |> NamespacedName

    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/gts#geologicDescription"></see>
    /// </summary>
    let geologicDescription =
        Namespaced_IRI.parse _namespace_name "geologicDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/gts#geologicSetting"></see>
    /// </summary>
    let geologicSetting =
        Namespaced_IRI.parse _namespace_name "geologicSetting" |> NamespacedName

    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/gts#Sub-Period"></see>
    /// </summary>
    let ``Sub-Period`` =
        Namespaced_IRI.parse _namespace_name "Sub-Period" |> NamespacedName

    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/gts#Super-Eon"></see>
    /// </summary>
    let ``Super-Eon`` =
        Namespaced_IRI.parse _namespace_name "Super-Eon" |> NamespacedName

    /// <summary>
    /// geochronologic boundary corresponding with this point
    /// <see href="http://resource.geosciml.org/ontology/timescale/gts#boundary"></see></summary>
    let boundary = Namespaced_IRI.parse _namespace_name "boundary" |> NamespacedName

    /// <summary>
    /// the level within the section of the point characterizing the boundary
    /// <see href="http://resource.geosciml.org/ontology/timescale/gts#boundaryLevel"></see></summary>
    let boundaryLevel =
        Namespaced_IRI.parse _namespace_name "boundaryLevel" |> NamespacedName

    /// <summary>
    /// This property points from a geologic feature or event to a geochronologic element
    /// <see href="http://resource.geosciml.org/ontology/timescale/gts#correlatesWith"></see></summary>
    let correlatesWith =
        Namespaced_IRI.parse _namespace_name "correlatesWith" |> NamespacedName

    /// <summary>
    /// geochronologic era corresponding with this section
    /// <see href="http://resource.geosciml.org/ontology/timescale/gts#era"></see></summary>
    let era = Namespaced_IRI.parse _namespace_name "era" |> NamespacedName
    /// <summary>
    /// stratigraphic event corresponding with this boundary or point
    /// <see href="http://resource.geosciml.org/ontology/timescale/gts#event"></see></summary>
    let event_ = Namespaced_IRI.parse _namespace_name "event" |> NamespacedName

    /// <summary>
    /// This property points from a geochronologic element to a geologic feature
    /// <see href="http://resource.geosciml.org/ontology/timescale/gts#manifestedBy"></see></summary>
    let manifestedBy =
        Namespaced_IRI.parse _namespace_name "manifestedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/gts#positionalUncertainty"></see>
    /// </summary>
    let positionalUncertainty =
        Namespaced_IRI.parse _namespace_name "positionalUncertainty" |> NamespacedName

    /// <summary>
    /// Elements of all ranks are included in the class 'gts:GeochronologicEra'.
    /// The rank may be indicated by membership of a sub-class, or is indicated using the 'gts:rank' property.
    /// <see href="http://resource.geosciml.org/ontology/timescale/gts#rank"></see></summary>
    let rank = Namespaced_IRI.parse _namespace_name "rank" |> NamespacedName
