namespace http.resource.geosciml.org.ontology.timescale.gts.hash

open DoxAletheia

module gts =
    let _namespace_name = "http://resource.geosciml.org/ontology/timescale/gts#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/gts#Age"></see>
    /// </summary>
    let Age = _prefix "Age"
    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/gts#GeochronologicEra"></see>
    /// </summary>
    let GeochronologicEra = _prefix "GeochronologicEra"
    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/gts#Eon"></see>
    /// </summary>
    let Eon = _prefix "Eon"
    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/gts#Epoch"></see>
    /// </summary>
    let Epoch = _prefix "Epoch"
    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/gts#Era"></see>
    /// </summary>
    let Era = _prefix "Era"
    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/gts#EraCode"></see>
    /// </summary>
    let EraCode = _prefix "EraCode"
    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/gts#GeochronologicBoundary"></see>
    /// </summary>
    let GeochronologicBoundary = _prefix "GeochronologicBoundary"
    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/gts#StratigraphicPoint"></see>
    /// </summary>
    let StratigraphicPoint = _prefix "StratigraphicPoint"
    /// <summary>
    /// the characteristic point or section corresponding with a geochronologic concept
    /// <see href="http://resource.geosciml.org/ontology/timescale/gts#stratotype"></see></summary>
    let stratotype = _prefix "stratotype"
    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/gts#NumericEraBoundary"></see>
    /// </summary>
    let NumericEraBoundary = _prefix "NumericEraBoundary"
    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/gts#StratigraphicSection"></see>
    /// </summary>
    let StratigraphicSection = _prefix "StratigraphicSection"
    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/gts#GeochronologicEraRank"></see>
    /// </summary>
    let GeochronologicEraRank = _prefix "GeochronologicEraRank"
    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/gts#GeologicTimescale"></see>
    /// </summary>
    let GeologicTimescale = _prefix "GeologicTimescale"
    /// <summary>
    /// formal ICS status of this boundary and point
    /// <see href="http://resource.geosciml.org/ontology/timescale/gts#status"></see></summary>
    let status = _prefix "status"
    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/gts#Period"></see>
    /// </summary>
    let Period = _prefix "Period"
    /// <summary>
    /// A subclass of Geologic Event (placeholder)
    /// <see href="http://resource.geosciml.org/ontology/timescale/gts#StratigraphicEvent"></see></summary>
    let StratigraphicEvent = _prefix "StratigraphicEvent"
    /// <summary>
    /// the stratigraphic event that is intended to be represented by this stratigraphic point
    /// <see href="http://resource.geosciml.org/ontology/timescale/gts#correlationEvent"></see></summary>
    let correlationEvent = _prefix "correlationEvent"
    /// <summary>
    /// 'true' if ratified by ICS
    /// <see href="http://resource.geosciml.org/ontology/timescale/gts#ratifiedGSSP"></see></summary>
    let ratifiedGSSP = _prefix "ratifiedGSSP"
    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/gts#geologicDescription"></see>
    /// </summary>
    let geologicDescription = _prefix "geologicDescription"
    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/gts#geologicSetting"></see>
    /// </summary>
    let geologicSetting = _prefix "geologicSetting"
    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/gts#Sub-Period"></see>
    /// </summary>
    let ``Sub-Period`` = _prefix "Sub-Period"
    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/gts#Super-Eon"></see>
    /// </summary>
    let ``Super-Eon`` = _prefix "Super-Eon"
    /// <summary>
    /// geochronologic boundary corresponding with this point
    /// <see href="http://resource.geosciml.org/ontology/timescale/gts#boundary"></see></summary>
    let boundary = _prefix "boundary"
    /// <summary>
    /// the level within the section of the point characterizing the boundary
    /// <see href="http://resource.geosciml.org/ontology/timescale/gts#boundaryLevel"></see></summary>
    let boundaryLevel = _prefix "boundaryLevel"
    /// <summary>
    /// This property points from a geologic feature or event to a geochronologic element
    /// <see href="http://resource.geosciml.org/ontology/timescale/gts#correlatesWith"></see></summary>
    let correlatesWith = _prefix "correlatesWith"
    /// <summary>
    /// geochronologic era corresponding with this section
    /// <see href="http://resource.geosciml.org/ontology/timescale/gts#era"></see></summary>
    let era = _prefix "era"
    /// <summary>
    /// stratigraphic event corresponding with this boundary or point
    /// <see href="http://resource.geosciml.org/ontology/timescale/gts#event"></see></summary>
    let event_ = _prefix "event"
    /// <summary>
    /// This property points from a geochronologic element to a geologic feature
    /// <see href="http://resource.geosciml.org/ontology/timescale/gts#manifestedBy"></see></summary>
    let manifestedBy = _prefix "manifestedBy"
    /// <summary>
    ///   <see href="http://resource.geosciml.org/ontology/timescale/gts#positionalUncertainty"></see>
    /// </summary>
    let positionalUncertainty = _prefix "positionalUncertainty"
    /// <summary>
    /// Elements of all ranks are included in the class 'gts:GeochronologicEra'.
    /// The rank may be indicated by membership of a sub-class, or is indicated using the 'gts:rank' property.
    /// <see href="http://resource.geosciml.org/ontology/timescale/gts#rank"></see></summary>
    let rank = _prefix "rank"
