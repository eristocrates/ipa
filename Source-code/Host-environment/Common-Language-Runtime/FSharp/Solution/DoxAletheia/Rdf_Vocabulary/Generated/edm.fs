namespace http.www.europeana.eu.schemas.edm.slash

open DoxAletheia

module edm =
    let _namespace_name = "http://www.europeana.eu/schemas/edm/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/hasMet"></see>
    /// </summary>
    let hasMet = _prefix "hasMet"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/hasType"></see>
    /// </summary>
    let hasType = _prefix "hasType"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/isRelatedTo"></see>
    /// </summary>
    let isRelatedTo = _prefix "isRelatedTo"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/isDerivativeOf"></see>
    /// </summary>
    let isDerivativeOf = _prefix "isDerivativeOf"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/hasView"></see>
    /// </summary>
    let hasView = _prefix "hasView"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/begin"></see>
    /// </summary>
    let begin_ = _prefix "begin"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/end"></see>
    /// </summary>
    let end_ = _prefix "end"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/Agent"></see>
    /// </summary>
    let Agent = _prefix "Agent"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/NonInformationResource"></see>
    /// </summary>
    let NonInformationResource = _prefix "NonInformationResource"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/EuropeanaAggregation"></see>
    /// </summary>
    let EuropeanaAggregation = _prefix "EuropeanaAggregation"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/EuropeanaObject"></see>
    /// </summary>
    let EuropeanaObject = _prefix "EuropeanaObject"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/aggregatedCHO"></see>
    /// </summary>
    let aggregatedCHO = _prefix "aggregatedCHO"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/WebResource"></see>
    /// </summary>
    let WebResource = _prefix "WebResource"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/Event"></see>
    /// </summary>
    let Event = _prefix "Event"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/happenedAt"></see>
    /// </summary>
    let happenedAt = _prefix "happenedAt"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/InformationResource"></see>
    /// </summary>
    let InformationResource = _prefix "InformationResource"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/PhysicalThing"></see>
    /// </summary>
    let PhysicalThing = _prefix "PhysicalThing"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/Place"></see>
    /// </summary>
    let Place = _prefix "Place"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/ProvidedCHO"></see>
    /// </summary>
    let ProvidedCHO = _prefix "ProvidedCHO"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/TimeSpan"></see>
    /// </summary>
    let TimeSpan = _prefix "TimeSpan"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/country"></see>
    /// </summary>
    let country = _prefix "country"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/currentLocation"></see>
    /// </summary>
    let currentLocation = _prefix "currentLocation"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/dataProvider"></see>
    /// </summary>
    let dataProvider = _prefix "dataProvider"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/incorporates"></see>
    /// </summary>
    let incorporates = _prefix "incorporates"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/isSimilarTo"></see>
    /// </summary>
    let isSimilarTo = _prefix "isSimilarTo"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/isAnnotationOf"></see>
    /// </summary>
    let isAnnotationOf = _prefix "isAnnotationOf"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/isNextInSequence"></see>
    /// </summary>
    let isNextInSequence = _prefix "isNextInSequence"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/isRepresentationOf"></see>
    /// </summary>
    let isRepresentationOf = _prefix "isRepresentationOf"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/isShownAt"></see>
    /// </summary>
    let isShownAt = _prefix "isShownAt"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/isShownBy"></see>
    /// </summary>
    let isShownBy = _prefix "isShownBy"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/isSuccessorOf"></see>
    /// </summary>
    let isSuccessorOf = _prefix "isSuccessorOf"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/landingPage"></see>
    /// </summary>
    let landingPage = _prefix "landingPage"
    /// <summary>
    /// The recommended best practice is to use a controlled vocabulary such as
    /// RFC 4646 (http://www.rfc-archive.org/getrfc.php?rfc=4646) which, in
    /// conjunction with ISO 639, defines two- and three-letter primary language tags. Either a coded value or text string can be represented here.
    /// <see href="http://www.europeana.eu/schemas/edm/language"></see></summary>
    let language = _prefix "language"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/object"></see>
    /// </summary>
    let object = _prefix "object"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/occurredAt"></see>
    /// </summary>
    let occurredAt = _prefix "occurredAt"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/preview"></see>
    /// </summary>
    let preview = _prefix "preview"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/provider"></see>
    /// </summary>
    let provider = _prefix "provider"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/realizes"></see>
    /// </summary>
    let realizes = _prefix "realizes"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/rights"></see>
    /// </summary>
    let rights = _prefix "rights"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/type"></see>
    /// </summary>
    let type_ = _prefix "type"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/ugc"></see>
    /// </summary>
    let ugc = _prefix "ugc"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/unstored"></see>
    /// </summary>
    let unstored = _prefix "unstored"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/uri"></see>
    /// </summary>
    let uri = _prefix "uri"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/userTag"></see>
    /// </summary>
    let userTag = _prefix "userTag"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/wasPresentAt"></see>
    /// </summary>
    let wasPresentAt = _prefix "wasPresentAt"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/year"></see>
    /// </summary>
    let year = _prefix "year"
