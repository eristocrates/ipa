#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module gts =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://resource.geosciml.org/ontology/timescale/gts#" "gts"

    let _namespaceIri = _prefixId.prefix ""
    let Age = _prefixId.prefix "Age"
    let Eon = _prefixId.prefix "Eon"
    let Epoch = _prefixId.prefix "Epoch"
    let Era = _prefixId.prefix "Era"
    let EraCode = _prefixId.prefix "EraCode"
    /// <summary>
    ///   <para>rdfs:label : Geochronologic Boundary</para>
    ///   <a href="http://resource.geosciml.org/ontology/timescale/gts#GeochronologicBoundary">gts:GeochronologicBoundary</a>
    /// </summary>
    let GeochronologicBoundary = _prefixId.prefix "GeochronologicBoundary"
    /// <summary>
    ///   <para>rdfs:label : Geochronologic Era</para>
    ///   <a href="http://resource.geosciml.org/ontology/timescale/gts#GeochronologicEra">gts:GeochronologicEra</a>
    /// </summary>
    let GeochronologicEra = _prefixId.prefix "GeochronologicEra"
    /// <summary>
    ///   <para>rdfs:label : Geochronologic Era Rank</para>
    ///   <a href="http://resource.geosciml.org/ontology/timescale/gts#GeochronologicEraRank">gts:GeochronologicEraRank</a>
    /// </summary>
    let GeochronologicEraRank = _prefixId.prefix "GeochronologicEraRank"
    /// <summary>
    ///   <para>rdfs:label : Geologic Timescale</para>
    ///   <a href="http://resource.geosciml.org/ontology/timescale/gts#GeologicTimescale">gts:GeologicTimescale</a>
    /// </summary>
    let GeologicTimescale = _prefixId.prefix "GeologicTimescale"
    /// <summary>
    ///   <para>rdfs:label : Numeric Era Boundary</para>
    ///   <a href="http://resource.geosciml.org/ontology/timescale/gts#NumericEraBoundary">gts:NumericEraBoundary</a>
    /// </summary>
    let NumericEraBoundary = _prefixId.prefix "NumericEraBoundary"
    let Period = _prefixId.prefix "Period"
    /// <summary>
    ///   <para>rdfs:comment : A subclass of Geologic Event (placeholder) ^^xsd:string</para>
    ///   <para>rdfs:label : Stratigraphic Event</para>
    ///   <a href="http://resource.geosciml.org/ontology/timescale/gts#StratigraphicEvent">gts:StratigraphicEvent</a>
    /// </summary>
    let StratigraphicEvent = _prefixId.prefix "StratigraphicEvent"
    /// <summary>
    ///   <para>rdfs:label : Stratigraphic Point</para>
    ///   <a href="http://resource.geosciml.org/ontology/timescale/gts#StratigraphicPoint">gts:StratigraphicPoint</a>
    /// </summary>
    let StratigraphicPoint = _prefixId.prefix "StratigraphicPoint"
    /// <summary>
    ///   <para>rdfs:label : Stratigraphic Section</para>
    ///   <a href="http://resource.geosciml.org/ontology/timescale/gts#StratigraphicSection">gts:StratigraphicSection</a>
    /// </summary>
    let StratigraphicSection = _prefixId.prefix "StratigraphicSection"
    let Sub_Period = _prefixId.prefix "Sub-Period"
    let Super_Eon = _prefixId.prefix "Super-Eon"
    /// <summary>
    ///   <para>rdfs:comment : geochronologic boundary corresponding with this point^^xsd:string</para>
    ///   <para>rdfs:label : geochronologic boundary^^xsd:string</para>
    ///   <a href="http://resource.geosciml.org/ontology/timescale/gts#boundary">gts:boundary</a>
    /// </summary>
    let boundary = _prefixId.prefix "boundary"
    /// <summary>
    ///   <para>rdfs:comment : the level within the section of the point characterizing the boundary^^xsd:string</para>
    ///   <para>rdfs:label : boundary level^^xsd:string</para>
    ///   <a href="http://resource.geosciml.org/ontology/timescale/gts#boundaryLevel">gts:boundaryLevel</a>
    /// </summary>
    let boundaryLevel = _prefixId.prefix "boundaryLevel"
    /// <summary>
    ///   <para>rdfs:comment : This property points from a geologic feature or event to a geochronologic element^^xsd:string</para>
    ///   <para>rdfs:label : correlating boundary or era^^xsd:string</para>
    ///   <a href="http://resource.geosciml.org/ontology/timescale/gts#correlatesWith">gts:correlatesWith</a>
    /// </summary>
    let correlatesWith = _prefixId.prefix "correlatesWith"
    /// <summary>
    ///   <para>rdfs:comment : the stratigraphic event that is intended to be represented by this stratigraphic point^^xsd:string</para>
    ///   <para>rdfs:label : correlation event^^xsd:string</para>
    ///   <a href="http://resource.geosciml.org/ontology/timescale/gts#correlationEvent">gts:correlationEvent</a>
    /// </summary>
    let correlationEvent = _prefixId.prefix "correlationEvent"
    /// <summary>
    ///   <para>rdfs:comment : geochronologic era corresponding with this section^^xsd:string</para>
    ///   <para>rdfs:label : geochronologic era^^xsd:string</para>
    ///   <a href="http://resource.geosciml.org/ontology/timescale/gts#era">gts:era</a>
    /// </summary>
    let era = _prefixId.prefix "era"
    /// <summary>
    ///   <para>rdfs:comment : stratigraphic event corresponding with this boundary or point^^xsd:string</para>
    ///   <para>rdfs:label : stratigraphic event^^xsd:string</para>
    ///   <a href="http://resource.geosciml.org/ontology/timescale/gts#event">gts:event</a>
    /// </summary>
    let event_ = _prefixId.prefix "event"
    /// <summary>
    ///   <para>rdfs:label : geologic description^^xsd:string</para>
    ///   <a href="http://resource.geosciml.org/ontology/timescale/gts#geologicDescription">gts:geologicDescription</a>
    /// </summary>
    let geologicDescription = _prefixId.prefix "geologicDescription"
    /// <summary>
    ///   <para>rdfs:label : geologic setting^^xsd:string</para>
    ///   <a href="http://resource.geosciml.org/ontology/timescale/gts#geologicSetting">gts:geologicSetting</a>
    /// </summary>
    let geologicSetting = _prefixId.prefix "geologicSetting"
    /// <summary>
    ///   <para>rdfs:comment : This property points from a geochronologic element to a geologic feature^^xsd:string</para>
    ///   <para>rdfs:label : geologic manifestation^^xsd:string</para>
    ///   <a href="http://resource.geosciml.org/ontology/timescale/gts#manifestedBy">gts:manifestedBy</a>
    /// </summary>
    let manifestedBy = _prefixId.prefix "manifestedBy"
    /// <summary>
    ///   <para>rdfs:label : Uncertainty in time position^^xsd:string</para>
    ///   <a href="http://resource.geosciml.org/ontology/timescale/gts#positionalUncertainty">gts:positionalUncertainty</a>
    /// </summary>
    let positionalUncertainty = _prefixId.prefix "positionalUncertainty"
    /// <summary>
    ///   <para>rdfs:comment : Elements of all ranks are included in the class 'gts:GeochronologicEra'.
    /// The rank may be indicated by membership of a sub-class, or is indicated using the 'gts:rank' property.^^xsd:string</para>
    ///   <para>rdfs:label : Geochronologic era rank^^xsd:string</para>
    ///   <a href="http://resource.geosciml.org/ontology/timescale/gts#rank">gts:rank</a>
    /// </summary>
    let rank = _prefixId.prefix "rank"
    /// <summary>
    ///   <para>rdfs:comment : 'true' if ratified by ICS^^xsd:string</para>
    ///   <para>rdfs:label : ratified^^xsd:string</para>
    ///   <a href="http://resource.geosciml.org/ontology/timescale/gts#ratifiedGSSP">gts:ratifiedGSSP</a>
    /// </summary>
    let ratifiedGSSP = _prefixId.prefix "ratifiedGSSP"
    /// <summary>
    ///   <para>rdfs:comment : formal ICS status of this boundary and point^^xsd:string</para>
    ///   <para>rdfs:label : status^^xsd:string</para>
    ///   <a href="http://resource.geosciml.org/ontology/timescale/gts#status">gts:status</a>
    /// </summary>
    let status = _prefixId.prefix "status"
    /// <summary>
    ///   <para>rdfs:comment : the characteristic point or section corresponding with a geochronologic concept^^xsd:string</para>
    ///   <para>rdfs:label : stratotype^^xsd:string</para>
    ///   <a href="http://resource.geosciml.org/ontology/timescale/gts#stratotype">gts:stratotype</a>
    /// </summary>
    let stratotype = _prefixId.prefix "stratotype"
