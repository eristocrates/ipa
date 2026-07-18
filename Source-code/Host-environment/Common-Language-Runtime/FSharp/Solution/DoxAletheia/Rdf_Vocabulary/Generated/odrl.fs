namespace http.www.w3.org.ns.odrl._2.slash

open DoxAletheia.Rdf_Vocabulary

module odrl =
    let _namespace_name = "http://www.w3.org/ns/odrl/2/"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/Action"></see>
    /// </summary>
    let Action = Namespaced_IRI.parse _namespace_name "Action" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/includedIn"></see>
    /// </summary>
    let includedIn = Namespaced_IRI.parse _namespace_name "includedIn" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/use"></see>
    /// </summary>
    let use_ = Namespaced_IRI.parse _namespace_name "use" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#actionConcepts"></see>
    /// </summary>
    let ``_#actionConcepts`` =
        Namespaced_IRI.parse _namespace_name "#actionConcepts" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/implies"></see>
    /// </summary>
    let implies = Namespaced_IRI.parse _namespace_name "implies" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/action"></see>
    /// </summary>
    let action = Namespaced_IRI.parse _namespace_name "action" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#actions"></see>
    /// </summary>
    let ``_#actions`` =
        Namespaced_IRI.parse _namespace_name "#actions" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/transfer"></see>
    /// </summary>
    let transfer = Namespaced_IRI.parse _namespace_name "transfer" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#actionsCommon"></see>
    /// </summary>
    let ``_#actionsCommon`` =
        Namespaced_IRI.parse _namespace_name "#actionsCommon" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/extract"></see>
    /// </summary>
    let extract = Namespaced_IRI.parse _namespace_name "extract" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/watermark"></see>
    /// </summary>
    let watermark = Namespaced_IRI.parse _namespace_name "watermark" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/move"></see>
    /// </summary>
    let move = Namespaced_IRI.parse _namespace_name "move" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/print"></see>
    /// </summary>
    let print = Namespaced_IRI.parse _namespace_name "print" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/uninstall"></see>
    /// </summary>
    let uninstall = Namespaced_IRI.parse _namespace_name "uninstall" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/install"></see>
    /// </summary>
    let install = Namespaced_IRI.parse _namespace_name "install" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/transform"></see>
    /// </summary>
    let transform = Namespaced_IRI.parse _namespace_name "transform" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/compensate"></see>
    /// </summary>
    let compensate = Namespaced_IRI.parse _namespace_name "compensate" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/attribute"></see>
    /// </summary>
    let attribute = Namespaced_IRI.parse _namespace_name "attribute" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/read"></see>
    /// </summary>
    let read = Namespaced_IRI.parse _namespace_name "read" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/digitize"></see>
    /// </summary>
    let digitize = Namespaced_IRI.parse _namespace_name "digitize" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/distribute"></see>
    /// </summary>
    let distribute = Namespaced_IRI.parse _namespace_name "distribute" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/include"></see>
    /// </summary>
    let include_ = Namespaced_IRI.parse _namespace_name "include" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/sell"></see>
    /// </summary>
    let sell = Namespaced_IRI.parse _namespace_name "sell" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/anonymize"></see>
    /// </summary>
    let anonymize = Namespaced_IRI.parse _namespace_name "anonymize" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/textToSpeech"></see>
    /// </summary>
    let textToSpeech =
        Namespaced_IRI.parse _namespace_name "textToSpeech" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/synchronize"></see>
    /// </summary>
    let synchronize =
        Namespaced_IRI.parse _namespace_name "synchronize" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/obtainConsent"></see>
    /// </summary>
    let obtainConsent =
        Namespaced_IRI.parse _namespace_name "obtainConsent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/concurrentUse"></see>
    /// </summary>
    let concurrentUse =
        Namespaced_IRI.parse _namespace_name "concurrentUse" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/ensureExclusivity"></see>
    /// </summary>
    let ensureExclusivity =
        Namespaced_IRI.parse _namespace_name "ensureExclusivity" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/play"></see>
    /// </summary>
    let play = Namespaced_IRI.parse _namespace_name "play" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/index"></see>
    /// </summary>
    let index = Namespaced_IRI.parse _namespace_name "index" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/give"></see>
    /// </summary>
    let give = Namespaced_IRI.parse _namespace_name "give" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/present"></see>
    /// </summary>
    let present = Namespaced_IRI.parse _namespace_name "present" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/nextPolicy"></see>
    /// </summary>
    let nextPolicy = Namespaced_IRI.parse _namespace_name "nextPolicy" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/delete"></see>
    /// </summary>
    let delete = Namespaced_IRI.parse _namespace_name "delete" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/modify"></see>
    /// </summary>
    let modify = Namespaced_IRI.parse _namespace_name "modify" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/derive"></see>
    /// </summary>
    let derive = Namespaced_IRI.parse _namespace_name "derive" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/translate"></see>
    /// </summary>
    let translate = Namespaced_IRI.parse _namespace_name "translate" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/display"></see>
    /// </summary>
    let display = Namespaced_IRI.parse _namespace_name "display" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/acceptTracking"></see>
    /// </summary>
    let acceptTracking =
        Namespaced_IRI.parse _namespace_name "acceptTracking" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/reviewPolicy"></see>
    /// </summary>
    let reviewPolicy =
        Namespaced_IRI.parse _namespace_name "reviewPolicy" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/archive"></see>
    /// </summary>
    let archive = Namespaced_IRI.parse _namespace_name "archive" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/inform"></see>
    /// </summary>
    let inform = Namespaced_IRI.parse _namespace_name "inform" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/execute"></see>
    /// </summary>
    let execute = Namespaced_IRI.parse _namespace_name "execute" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/reproduce"></see>
    /// </summary>
    let reproduce = Namespaced_IRI.parse _namespace_name "reproduce" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/aggregate"></see>
    /// </summary>
    let aggregate = Namespaced_IRI.parse _namespace_name "aggregate" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/grantUse"></see>
    /// </summary>
    let grantUse = Namespaced_IRI.parse _namespace_name "grantUse" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/annotate"></see>
    /// </summary>
    let annotate = Namespaced_IRI.parse _namespace_name "annotate" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/stream"></see>
    /// </summary>
    let stream = Namespaced_IRI.parse _namespace_name "stream" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#assetConcepts"></see>
    /// </summary>
    let ``_#assetConcepts`` =
        Namespaced_IRI.parse _namespace_name "#assetConcepts" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/AssetCollection"></see>
    /// </summary>
    let AssetCollection =
        Namespaced_IRI.parse _namespace_name "AssetCollection" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/Asset"></see>
    /// </summary>
    let Asset = Namespaced_IRI.parse _namespace_name "Asset" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#assetParty"></see>
    /// </summary>
    let ``_#assetParty`` =
        Namespaced_IRI.parse _namespace_name "#assetParty" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/source"></see>
    /// </summary>
    let source = Namespaced_IRI.parse _namespace_name "source" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/partOf"></see>
    /// </summary>
    let partOf = Namespaced_IRI.parse _namespace_name "partOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#assetRelations"></see>
    /// </summary>
    let ``_#assetRelations`` =
        Namespaced_IRI.parse _namespace_name "#assetRelations" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/hasPolicy"></see>
    /// </summary>
    let hasPolicy = Namespaced_IRI.parse _namespace_name "hasPolicy" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/target"></see>
    /// </summary>
    let target = Namespaced_IRI.parse _namespace_name "target" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#assetRelationsCommon"></see>
    /// </summary>
    let ``_#assetRelationsCommon`` =
        Namespaced_IRI.parse _namespace_name "#assetRelationsCommon" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/output"></see>
    /// </summary>
    let output = Namespaced_IRI.parse _namespace_name "output" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#conflictConcepts"></see>
    /// </summary>
    let ``_#conflictConcepts`` =
        Namespaced_IRI.parse _namespace_name "#conflictConcepts" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/invalid"></see>
    /// </summary>
    let invalid = Namespaced_IRI.parse _namespace_name "invalid" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/prohibit"></see>
    /// </summary>
    let prohibit = Namespaced_IRI.parse _namespace_name "prohibit" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/perm"></see>
    /// </summary>
    let perm = Namespaced_IRI.parse _namespace_name "perm" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/conflict"></see>
    /// </summary>
    let conflict = Namespaced_IRI.parse _namespace_name "conflict" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/ConflictTerm"></see>
    /// </summary>
    let ConflictTerm =
        Namespaced_IRI.parse _namespace_name "ConflictTerm" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#constraintLeftOperandCommon"></see>
    /// </summary>
    let ``_#constraintLeftOperandCommon`` =
        Namespaced_IRI.parse _namespace_name "#constraintLeftOperandCommon" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/resolution"></see>
    /// </summary>
    let resolution = Namespaced_IRI.parse _namespace_name "resolution" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/purpose"></see>
    /// </summary>
    let purpose = Namespaced_IRI.parse _namespace_name "purpose" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/relativeTemporalPosition"></see>
    /// </summary>
    let relativeTemporalPosition =
        Namespaced_IRI.parse _namespace_name "relativeTemporalPosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/timeInterval"></see>
    /// </summary>
    let timeInterval =
        Namespaced_IRI.parse _namespace_name "timeInterval" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/elapsedTime"></see>
    /// </summary>
    let elapsedTime =
        Namespaced_IRI.parse _namespace_name "elapsedTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/spatialCoordinates"></see>
    /// </summary>
    let spatialCoordinates =
        Namespaced_IRI.parse _namespace_name "spatialCoordinates" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/fileFormat"></see>
    /// </summary>
    let fileFormat = Namespaced_IRI.parse _namespace_name "fileFormat" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/dateTime"></see>
    /// </summary>
    let dateTime = Namespaced_IRI.parse _namespace_name "dateTime" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/event"></see>
    /// </summary>
    let event_ = Namespaced_IRI.parse _namespace_name "event" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/systemDevice"></see>
    /// </summary>
    let systemDevice =
        Namespaced_IRI.parse _namespace_name "systemDevice" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/absoluteSpatialPosition"></see>
    /// </summary>
    let absoluteSpatialPosition =
        Namespaced_IRI.parse _namespace_name "absoluteSpatialPosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/payAmount"></see>
    /// </summary>
    let payAmount = Namespaced_IRI.parse _namespace_name "payAmount" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/absoluteSize"></see>
    /// </summary>
    let absoluteSize =
        Namespaced_IRI.parse _namespace_name "absoluteSize" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/spatial"></see>
    /// </summary>
    let spatial = Namespaced_IRI.parse _namespace_name "spatial" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/deliveryChannel"></see>
    /// </summary>
    let deliveryChannel =
        Namespaced_IRI.parse _namespace_name "deliveryChannel" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/absolutePosition"></see>
    /// </summary>
    let absolutePosition =
        Namespaced_IRI.parse _namespace_name "absolutePosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/virtualLocation"></see>
    /// </summary>
    let virtualLocation =
        Namespaced_IRI.parse _namespace_name "virtualLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/percentage"></see>
    /// </summary>
    let percentage = Namespaced_IRI.parse _namespace_name "percentage" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/relativePosition"></see>
    /// </summary>
    let relativePosition =
        Namespaced_IRI.parse _namespace_name "relativePosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/product"></see>
    /// </summary>
    let product = Namespaced_IRI.parse _namespace_name "product" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/relativeSize"></see>
    /// </summary>
    let relativeSize =
        Namespaced_IRI.parse _namespace_name "relativeSize" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/relativeSpatialPosition"></see>
    /// </summary>
    let relativeSpatialPosition =
        Namespaced_IRI.parse _namespace_name "relativeSpatialPosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/count"></see>
    /// </summary>
    let count = Namespaced_IRI.parse _namespace_name "count" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/media"></see>
    /// </summary>
    let media = Namespaced_IRI.parse _namespace_name "media" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/language"></see>
    /// </summary>
    let language = Namespaced_IRI.parse _namespace_name "language" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/industry"></see>
    /// </summary>
    let industry = Namespaced_IRI.parse _namespace_name "industry" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/unitOfCount"></see>
    /// </summary>
    let unitOfCount =
        Namespaced_IRI.parse _namespace_name "unitOfCount" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/delayPeriod"></see>
    /// </summary>
    let delayPeriod =
        Namespaced_IRI.parse _namespace_name "delayPeriod" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/version"></see>
    /// </summary>
    let version = Namespaced_IRI.parse _namespace_name "version" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/meteredTime"></see>
    /// </summary>
    let meteredTime =
        Namespaced_IRI.parse _namespace_name "meteredTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/recipient"></see>
    /// </summary>
    let recipient = Namespaced_IRI.parse _namespace_name "recipient" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/absoluteTemporalPosition"></see>
    /// </summary>
    let absoluteTemporalPosition =
        Namespaced_IRI.parse _namespace_name "absoluteTemporalPosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#constraintLogicalOperands"></see>
    /// </summary>
    let ``_#constraintLogicalOperands`` =
        Namespaced_IRI.parse _namespace_name "#constraintLogicalOperands" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/andSequence"></see>
    /// </summary>
    let andSequence =
        Namespaced_IRI.parse _namespace_name "andSequence" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/and"></see>
    /// </summary>
    let and_ = Namespaced_IRI.parse _namespace_name "and" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/xone"></see>
    /// </summary>
    let xone = Namespaced_IRI.parse _namespace_name "xone" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/or"></see>
    /// </summary>
    let or_ = Namespaced_IRI.parse _namespace_name "or" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#constraintRelationalOperators"></see>
    /// </summary>
    let ``_#constraintRelationalOperators`` =
        Namespaced_IRI.parse _namespace_name "#constraintRelationalOperators" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/gteq"></see>
    /// </summary>
    let gteq = Namespaced_IRI.parse _namespace_name "gteq" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/isA"></see>
    /// </summary>
    let isA = Namespaced_IRI.parse _namespace_name "isA" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/lt"></see>
    /// </summary>
    let lt = Namespaced_IRI.parse _namespace_name "lt" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/hasPart"></see>
    /// </summary>
    let hasPart = Namespaced_IRI.parse _namespace_name "hasPart" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/eq"></see>
    /// </summary>
    let eq = Namespaced_IRI.parse _namespace_name "eq" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/lteq"></see>
    /// </summary>
    let lteq = Namespaced_IRI.parse _namespace_name "lteq" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/isAllOf"></see>
    /// </summary>
    let isAllOf = Namespaced_IRI.parse _namespace_name "isAllOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/isNoneOf"></see>
    /// </summary>
    let isNoneOf = Namespaced_IRI.parse _namespace_name "isNoneOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/neq"></see>
    /// </summary>
    let neq = Namespaced_IRI.parse _namespace_name "neq" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/isPartOf"></see>
    /// </summary>
    let isPartOf = Namespaced_IRI.parse _namespace_name "isPartOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/gt"></see>
    /// </summary>
    let gt = Namespaced_IRI.parse _namespace_name "gt" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/isAnyOf"></see>
    /// </summary>
    let isAnyOf = Namespaced_IRI.parse _namespace_name "isAnyOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#constraintRightOpCommon"></see>
    /// </summary>
    let ``_#constraintRightOpCommon`` =
        Namespaced_IRI.parse _namespace_name "#constraintRightOpCommon" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/policyUsage"></see>
    /// </summary>
    let policyUsage =
        Namespaced_IRI.parse _namespace_name "policyUsage" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#constraints"></see>
    /// </summary>
    let ``_#constraints`` =
        Namespaced_IRI.parse _namespace_name "#constraints" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/constraint"></see>
    /// </summary>
    let constraint_ =
        Namespaced_IRI.parse _namespace_name "constraint" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/rightOperand"></see>
    /// </summary>
    let rightOperand =
        Namespaced_IRI.parse _namespace_name "rightOperand" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/unit"></see>
    /// </summary>
    let unit = Namespaced_IRI.parse _namespace_name "unit" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/LeftOperand"></see>
    /// </summary>
    let LeftOperand =
        Namespaced_IRI.parse _namespace_name "LeftOperand" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/leftOperand"></see>
    /// </summary>
    let leftOperand =
        Namespaced_IRI.parse _namespace_name "leftOperand" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/rightOperandReference"></see>
    /// </summary>
    let rightOperandReference =
        Namespaced_IRI.parse _namespace_name "rightOperandReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/RightOperand"></see>
    /// </summary>
    let RightOperand =
        Namespaced_IRI.parse _namespace_name "RightOperand" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/status"></see>
    /// </summary>
    let status = Namespaced_IRI.parse _namespace_name "status" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/operator"></see>
    /// </summary>
    let operator = Namespaced_IRI.parse _namespace_name "operator" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/Operator"></see>
    /// </summary>
    let Operator = Namespaced_IRI.parse _namespace_name "Operator" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/refinement"></see>
    /// </summary>
    let refinement = Namespaced_IRI.parse _namespace_name "refinement" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/Constraint"></see>
    /// </summary>
    let Constraint = Namespaced_IRI.parse _namespace_name "Constraint" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/dataType"></see>
    /// </summary>
    let dataType = Namespaced_IRI.parse _namespace_name "dataType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#deprecatedTerms"></see>
    /// </summary>
    let ``_#deprecatedTerms`` =
        Namespaced_IRI.parse _namespace_name "#deprecatedTerms" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/shareAlike"></see>
    /// </summary>
    let shareAlike = Namespaced_IRI.parse _namespace_name "shareAlike" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/All"></see>
    /// </summary>
    let All = Namespaced_IRI.parse _namespace_name "All" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/All2ndConnections"></see>
    /// </summary>
    let All2ndConnections =
        Namespaced_IRI.parse _namespace_name "All2ndConnections" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/PartyScope"></see>
    /// </summary>
    let PartyScope = Namespaced_IRI.parse _namespace_name "PartyScope" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/scope"></see>
    /// </summary>
    let scope = Namespaced_IRI.parse _namespace_name "scope" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/device"></see>
    /// </summary>
    let device = Namespaced_IRI.parse _namespace_name "device" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/write"></see>
    /// </summary>
    let write = Namespaced_IRI.parse _namespace_name "write" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/pay"></see>
    /// </summary>
    let pay = Namespaced_IRI.parse _namespace_name "pay" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/payeeParty"></see>
    /// </summary>
    let payeeParty = Namespaced_IRI.parse _namespace_name "payeeParty" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/copy"></see>
    /// </summary>
    let copy = Namespaced_IRI.parse _namespace_name "copy" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/inheritRelation"></see>
    /// </summary>
    let inheritRelation =
        Namespaced_IRI.parse _namespace_name "inheritRelation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/lend"></see>
    /// </summary>
    let lend = Namespaced_IRI.parse _namespace_name "lend" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/timedCount"></see>
    /// </summary>
    let timedCount = Namespaced_IRI.parse _namespace_name "timedCount" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/lease"></see>
    /// </summary>
    let lease = Namespaced_IRI.parse _namespace_name "lease" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/Group"></see>
    /// </summary>
    let Group = Namespaced_IRI.parse _namespace_name "Group" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/writeTo"></see>
    /// </summary>
    let writeTo = Namespaced_IRI.parse _namespace_name "writeTo" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/system"></see>
    /// </summary>
    let system = Namespaced_IRI.parse _namespace_name "system" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/AssetScope"></see>
    /// </summary>
    let AssetScope = Namespaced_IRI.parse _namespace_name "AssetScope" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/inheritAllowed"></see>
    /// </summary>
    let inheritAllowed =
        Namespaced_IRI.parse _namespace_name "inheritAllowed" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/proximity"></see>
    /// </summary>
    let proximity = Namespaced_IRI.parse _namespace_name "proximity" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/commercialize"></see>
    /// </summary>
    let commercialize =
        Namespaced_IRI.parse _namespace_name "commercialize" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/Individual"></see>
    /// </summary>
    let Individual = Namespaced_IRI.parse _namespace_name "Individual" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/ignore"></see>
    /// </summary>
    let ignore = Namespaced_IRI.parse _namespace_name "ignore" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/preview"></see>
    /// </summary>
    let preview = Namespaced_IRI.parse _namespace_name "preview" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/appendTo"></see>
    /// </summary>
    let appendTo = Namespaced_IRI.parse _namespace_name "appendTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/attachSource"></see>
    /// </summary>
    let attachSource =
        Namespaced_IRI.parse _namespace_name "attachSource" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/export"></see>
    /// </summary>
    let export = Namespaced_IRI.parse _namespace_name "export" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/attachPolicy"></see>
    /// </summary>
    let attachPolicy =
        Namespaced_IRI.parse _namespace_name "attachPolicy" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/extractChar"></see>
    /// </summary>
    let extractChar =
        Namespaced_IRI.parse _namespace_name "extractChar" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/share"></see>
    /// </summary>
    let share = Namespaced_IRI.parse _namespace_name "share" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/extractPage"></see>
    /// </summary>
    let extractPage =
        Namespaced_IRI.parse _namespace_name "extractPage" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/secondaryUse"></see>
    /// </summary>
    let secondaryUse =
        Namespaced_IRI.parse _namespace_name "secondaryUse" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/adHocShare"></see>
    /// </summary>
    let adHocShare = Namespaced_IRI.parse _namespace_name "adHocShare" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/AllConnections"></see>
    /// </summary>
    let AllConnections =
        Namespaced_IRI.parse _namespace_name "AllConnections" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/support"></see>
    /// </summary>
    let support = Namespaced_IRI.parse _namespace_name "support" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/AllGroups"></see>
    /// </summary>
    let AllGroups = Namespaced_IRI.parse _namespace_name "AllGroups" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/UndefinedTerm"></see>
    /// </summary>
    let UndefinedTerm =
        Namespaced_IRI.parse _namespace_name "UndefinedTerm" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/extractWord"></see>
    /// </summary>
    let extractWord =
        Namespaced_IRI.parse _namespace_name "extractWord" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/undefined"></see>
    /// </summary>
    let undefined = Namespaced_IRI.parse _namespace_name "undefined" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/append"></see>
    /// </summary>
    let append = Namespaced_IRI.parse _namespace_name "append" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/license"></see>
    /// </summary>
    let license = Namespaced_IRI.parse _namespace_name "license" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#duties"></see>
    /// </summary>
    let ``_#duties`` = Namespaced_IRI.parse _namespace_name "#duties" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/remedy"></see>
    /// </summary>
    let remedy = Namespaced_IRI.parse _namespace_name "remedy" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/consequence"></see>
    /// </summary>
    let consequence =
        Namespaced_IRI.parse _namespace_name "consequence" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/duty"></see>
    /// </summary>
    let duty = Namespaced_IRI.parse _namespace_name "duty" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/obligation"></see>
    /// </summary>
    let obligation = Namespaced_IRI.parse _namespace_name "obligation" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/Duty"></see>
    /// </summary>
    let Duty = Namespaced_IRI.parse _namespace_name "Duty" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#logicalConstraints"></see>
    /// </summary>
    let ``_#logicalConstraints`` =
        Namespaced_IRI.parse _namespace_name "#logicalConstraints" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/operand"></see>
    /// </summary>
    let operand = Namespaced_IRI.parse _namespace_name "operand" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/LogicalConstraint"></see>
    /// </summary>
    let LogicalConstraint =
        Namespaced_IRI.parse _namespace_name "LogicalConstraint" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#partyConcepts"></see>
    /// </summary>
    let ``_#partyConcepts`` =
        Namespaced_IRI.parse _namespace_name "#partyConcepts" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/PartyCollection"></see>
    /// </summary>
    let PartyCollection =
        Namespaced_IRI.parse _namespace_name "PartyCollection" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/Party"></see>
    /// </summary>
    let Party = Namespaced_IRI.parse _namespace_name "Party" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#partyRoles"></see>
    /// </summary>
    let ``_#partyRoles`` =
        Namespaced_IRI.parse _namespace_name "#partyRoles" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/assignerOf"></see>
    /// </summary>
    let assignerOf = Namespaced_IRI.parse _namespace_name "assignerOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/assigneeOf"></see>
    /// </summary>
    let assigneeOf = Namespaced_IRI.parse _namespace_name "assigneeOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/assigner"></see>
    /// </summary>
    let assigner = Namespaced_IRI.parse _namespace_name "assigner" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/assignee"></see>
    /// </summary>
    let assignee = Namespaced_IRI.parse _namespace_name "assignee" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#partyRolesCommon"></see>
    /// </summary>
    let ``_#partyRolesCommon`` =
        Namespaced_IRI.parse _namespace_name "#partyRolesCommon" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/consentingParty"></see>
    /// </summary>
    let consentingParty =
        Namespaced_IRI.parse _namespace_name "consentingParty" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/contractingParty"></see>
    /// </summary>
    let contractingParty =
        Namespaced_IRI.parse _namespace_name "contractingParty" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/attributedParty"></see>
    /// </summary>
    let attributedParty =
        Namespaced_IRI.parse _namespace_name "attributedParty" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/compensatedParty"></see>
    /// </summary>
    let compensatedParty =
        Namespaced_IRI.parse _namespace_name "compensatedParty" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/informedParty"></see>
    /// </summary>
    let informedParty =
        Namespaced_IRI.parse _namespace_name "informedParty" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/trackingParty"></see>
    /// </summary>
    let trackingParty =
        Namespaced_IRI.parse _namespace_name "trackingParty" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/informingParty"></see>
    /// </summary>
    let informingParty =
        Namespaced_IRI.parse _namespace_name "informingParty" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/compensatingParty"></see>
    /// </summary>
    let compensatingParty =
        Namespaced_IRI.parse _namespace_name "compensatingParty" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/trackedParty"></see>
    /// </summary>
    let trackedParty =
        Namespaced_IRI.parse _namespace_name "trackedParty" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/contractedParty"></see>
    /// </summary>
    let contractedParty =
        Namespaced_IRI.parse _namespace_name "contractedParty" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/attributingParty"></see>
    /// </summary>
    let attributingParty =
        Namespaced_IRI.parse _namespace_name "attributingParty" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/consentedParty"></see>
    /// </summary>
    let consentedParty =
        Namespaced_IRI.parse _namespace_name "consentedParty" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#permissions"></see>
    /// </summary>
    let ``_#permissions`` =
        Namespaced_IRI.parse _namespace_name "#permissions" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/permission"></see>
    /// </summary>
    let permission = Namespaced_IRI.parse _namespace_name "permission" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/Permission"></see>
    /// </summary>
    let Permission = Namespaced_IRI.parse _namespace_name "Permission" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#policyConcepts"></see>
    /// </summary>
    let ``_#policyConcepts`` =
        Namespaced_IRI.parse _namespace_name "#policyConcepts" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/inheritFrom"></see>
    /// </summary>
    let inheritFrom =
        Namespaced_IRI.parse _namespace_name "inheritFrom" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/profile"></see>
    /// </summary>
    let profile = Namespaced_IRI.parse _namespace_name "profile" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/uid"></see>
    /// </summary>
    let uid = Namespaced_IRI.parse _namespace_name "uid" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/Policy"></see>
    /// </summary>
    let Policy = Namespaced_IRI.parse _namespace_name "Policy" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#policySubClasses"></see>
    /// </summary>
    let ``_#policySubClasses`` =
        Namespaced_IRI.parse _namespace_name "#policySubClasses" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/Set"></see>
    /// </summary>
    let Set = Namespaced_IRI.parse _namespace_name "Set" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/Offer"></see>
    /// </summary>
    let Offer = Namespaced_IRI.parse _namespace_name "Offer" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/Agreement"></see>
    /// </summary>
    let Agreement = Namespaced_IRI.parse _namespace_name "Agreement" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#policySubClassesCommon"></see>
    /// </summary>
    let ``_#policySubClassesCommon`` =
        Namespaced_IRI.parse _namespace_name "#policySubClassesCommon" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/Ticket"></see>
    /// </summary>
    let Ticket = Namespaced_IRI.parse _namespace_name "Ticket" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/Request"></see>
    /// </summary>
    let Request = Namespaced_IRI.parse _namespace_name "Request" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/Privacy"></see>
    /// </summary>
    let Privacy = Namespaced_IRI.parse _namespace_name "Privacy" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/Assertion"></see>
    /// </summary>
    let Assertion = Namespaced_IRI.parse _namespace_name "Assertion" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#prohibitions"></see>
    /// </summary>
    let ``_#prohibitions`` =
        Namespaced_IRI.parse _namespace_name "#prohibitions" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/prohibition"></see>
    /// </summary>
    let prohibition =
        Namespaced_IRI.parse _namespace_name "prohibition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/Prohibition"></see>
    /// </summary>
    let Prohibition =
        Namespaced_IRI.parse _namespace_name "Prohibition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#ruleConcepts"></see>
    /// </summary>
    let ``_#ruleConcepts`` =
        Namespaced_IRI.parse _namespace_name "#ruleConcepts" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/failure"></see>
    /// </summary>
    let failure = Namespaced_IRI.parse _namespace_name "failure" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/function"></see>
    /// </summary>
    let function_ = Namespaced_IRI.parse _namespace_name "function" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/relation"></see>
    /// </summary>
    let relation = Namespaced_IRI.parse _namespace_name "relation" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/Rule"></see>
    /// </summary>
    let Rule = Namespaced_IRI.parse _namespace_name "Rule" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/core"></see>
    /// </summary>
    let core = Namespaced_IRI.parse _namespace_name "core" |> NamespacedName
