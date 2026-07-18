namespace http.www.europeana.eu.schemas.edm.slash

open DoxAletheia.Rdf_Vocabulary

module edm =
    let _namespace_name = "http://www.europeana.eu/schemas/edm/"
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/hasMet"></see>
    /// </summary>
    let hasMet = Namespaced_IRI.parse _namespace_name "hasMet" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/hasType"></see>
    /// </summary>
    let hasType = Namespaced_IRI.parse _namespace_name "hasType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/isRelatedTo"></see>
    /// </summary>
    let isRelatedTo =
        Namespaced_IRI.parse _namespace_name "isRelatedTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/isDerivativeOf"></see>
    /// </summary>
    let isDerivativeOf =
        Namespaced_IRI.parse _namespace_name "isDerivativeOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/hasView"></see>
    /// </summary>
    let hasView = Namespaced_IRI.parse _namespace_name "hasView" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/begin"></see>
    /// </summary>
    let begin_ = Namespaced_IRI.parse _namespace_name "begin" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/end"></see>
    /// </summary>
    let end_ = Namespaced_IRI.parse _namespace_name "end" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/Agent"></see>
    /// </summary>
    let Agent = Namespaced_IRI.parse _namespace_name "Agent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/NonInformationResource"></see>
    /// </summary>
    let NonInformationResource =
        Namespaced_IRI.parse _namespace_name "NonInformationResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/EuropeanaAggregation"></see>
    /// </summary>
    let EuropeanaAggregation =
        Namespaced_IRI.parse _namespace_name "EuropeanaAggregation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/EuropeanaObject"></see>
    /// </summary>
    let EuropeanaObject =
        Namespaced_IRI.parse _namespace_name "EuropeanaObject" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/aggregatedCHO"></see>
    /// </summary>
    let aggregatedCHO =
        Namespaced_IRI.parse _namespace_name "aggregatedCHO" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/WebResource"></see>
    /// </summary>
    let WebResource =
        Namespaced_IRI.parse _namespace_name "WebResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/Event"></see>
    /// </summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/happenedAt"></see>
    /// </summary>
    let happenedAt = Namespaced_IRI.parse _namespace_name "happenedAt" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/InformationResource"></see>
    /// </summary>
    let InformationResource =
        Namespaced_IRI.parse _namespace_name "InformationResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/PhysicalThing"></see>
    /// </summary>
    let PhysicalThing =
        Namespaced_IRI.parse _namespace_name "PhysicalThing" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/Place"></see>
    /// </summary>
    let Place = Namespaced_IRI.parse _namespace_name "Place" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/ProvidedCHO"></see>
    /// </summary>
    let ProvidedCHO =
        Namespaced_IRI.parse _namespace_name "ProvidedCHO" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/TimeSpan"></see>
    /// </summary>
    let TimeSpan = Namespaced_IRI.parse _namespace_name "TimeSpan" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/country"></see>
    /// </summary>
    let country = Namespaced_IRI.parse _namespace_name "country" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/currentLocation"></see>
    /// </summary>
    let currentLocation =
        Namespaced_IRI.parse _namespace_name "currentLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/dataProvider"></see>
    /// </summary>
    let dataProvider =
        Namespaced_IRI.parse _namespace_name "dataProvider" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/incorporates"></see>
    /// </summary>
    let incorporates =
        Namespaced_IRI.parse _namespace_name "incorporates" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/isSimilarTo"></see>
    /// </summary>
    let isSimilarTo =
        Namespaced_IRI.parse _namespace_name "isSimilarTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/isAnnotationOf"></see>
    /// </summary>
    let isAnnotationOf =
        Namespaced_IRI.parse _namespace_name "isAnnotationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/isNextInSequence"></see>
    /// </summary>
    let isNextInSequence =
        Namespaced_IRI.parse _namespace_name "isNextInSequence" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/isRepresentationOf"></see>
    /// </summary>
    let isRepresentationOf =
        Namespaced_IRI.parse _namespace_name "isRepresentationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/isShownAt"></see>
    /// </summary>
    let isShownAt = Namespaced_IRI.parse _namespace_name "isShownAt" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/isShownBy"></see>
    /// </summary>
    let isShownBy = Namespaced_IRI.parse _namespace_name "isShownBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/isSuccessorOf"></see>
    /// </summary>
    let isSuccessorOf =
        Namespaced_IRI.parse _namespace_name "isSuccessorOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/landingPage"></see>
    /// </summary>
    let landingPage =
        Namespaced_IRI.parse _namespace_name "landingPage" |> NamespacedName

    /// <summary>
    /// The recommended best practice is to use a controlled vocabulary such as
    /// RFC 4646 (http://www.rfc-archive.org/getrfc.php?rfc=4646) which, in
    /// conjunction with ISO 639, defines two- and three-letter primary language tags. Either a coded value or text string can be represented here.
    /// <see href="http://www.europeana.eu/schemas/edm/language"></see></summary>
    let language = Namespaced_IRI.parse _namespace_name "language" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/object"></see>
    /// </summary>
    let object = Namespaced_IRI.parse _namespace_name "object" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/occurredAt"></see>
    /// </summary>
    let occurredAt = Namespaced_IRI.parse _namespace_name "occurredAt" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/preview"></see>
    /// </summary>
    let preview = Namespaced_IRI.parse _namespace_name "preview" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/provider"></see>
    /// </summary>
    let provider = Namespaced_IRI.parse _namespace_name "provider" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/realizes"></see>
    /// </summary>
    let realizes = Namespaced_IRI.parse _namespace_name "realizes" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/rights"></see>
    /// </summary>
    let rights = Namespaced_IRI.parse _namespace_name "rights" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/type"></see>
    /// </summary>
    let type_ = Namespaced_IRI.parse _namespace_name "type" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/ugc"></see>
    /// </summary>
    let ugc = Namespaced_IRI.parse _namespace_name "ugc" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/unstored"></see>
    /// </summary>
    let unstored = Namespaced_IRI.parse _namespace_name "unstored" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/uri"></see>
    /// </summary>
    let uri = Namespaced_IRI.parse _namespace_name "uri" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/userTag"></see>
    /// </summary>
    let userTag = Namespaced_IRI.parse _namespace_name "userTag" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/wasPresentAt"></see>
    /// </summary>
    let wasPresentAt =
        Namespaced_IRI.parse _namespace_name "wasPresentAt" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.europeana.eu/schemas/edm/year"></see>
    /// </summary>
    let year = Namespaced_IRI.parse _namespace_name "year" |> NamespacedName
