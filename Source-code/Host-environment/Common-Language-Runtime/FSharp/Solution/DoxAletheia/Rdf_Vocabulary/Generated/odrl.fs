namespace http.www.w3.org.ns.odrl._2.slash

open DoxAletheia

module odrl =
    let _namespace_name = "http://www.w3.org/ns/odrl/2/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/Action"></see>
    /// </summary>
    let Action = _prefix "Action"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/includedIn"></see>
    /// </summary>
    let includedIn = _prefix "includedIn"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/use"></see>
    /// </summary>
    let use_ = _prefix "use"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#actionConcepts"></see>
    /// </summary>
    let ``_#actionConcepts`` = _prefix "#actionConcepts"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/implies"></see>
    /// </summary>
    let implies = _prefix "implies"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/action"></see>
    /// </summary>
    let action = _prefix "action"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#actions"></see>
    /// </summary>
    let ``_#actions`` = _prefix "#actions"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/transfer"></see>
    /// </summary>
    let transfer = _prefix "transfer"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#actionsCommon"></see>
    /// </summary>
    let ``_#actionsCommon`` = _prefix "#actionsCommon"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/extract"></see>
    /// </summary>
    let extract = _prefix "extract"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/watermark"></see>
    /// </summary>
    let watermark = _prefix "watermark"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/move"></see>
    /// </summary>
    let move = _prefix "move"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/print"></see>
    /// </summary>
    let print = _prefix "print"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/uninstall"></see>
    /// </summary>
    let uninstall = _prefix "uninstall"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/install"></see>
    /// </summary>
    let install = _prefix "install"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/transform"></see>
    /// </summary>
    let transform = _prefix "transform"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/compensate"></see>
    /// </summary>
    let compensate = _prefix "compensate"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/attribute"></see>
    /// </summary>
    let attribute = _prefix "attribute"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/read"></see>
    /// </summary>
    let read = _prefix "read"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/digitize"></see>
    /// </summary>
    let digitize = _prefix "digitize"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/distribute"></see>
    /// </summary>
    let distribute = _prefix "distribute"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/include"></see>
    /// </summary>
    let include_ = _prefix "include"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/sell"></see>
    /// </summary>
    let sell = _prefix "sell"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/anonymize"></see>
    /// </summary>
    let anonymize = _prefix "anonymize"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/textToSpeech"></see>
    /// </summary>
    let textToSpeech = _prefix "textToSpeech"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/synchronize"></see>
    /// </summary>
    let synchronize = _prefix "synchronize"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/obtainConsent"></see>
    /// </summary>
    let obtainConsent = _prefix "obtainConsent"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/concurrentUse"></see>
    /// </summary>
    let concurrentUse = _prefix "concurrentUse"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/ensureExclusivity"></see>
    /// </summary>
    let ensureExclusivity = _prefix "ensureExclusivity"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/play"></see>
    /// </summary>
    let play = _prefix "play"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/index"></see>
    /// </summary>
    let index = _prefix "index"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/give"></see>
    /// </summary>
    let give = _prefix "give"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/present"></see>
    /// </summary>
    let present = _prefix "present"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/nextPolicy"></see>
    /// </summary>
    let nextPolicy = _prefix "nextPolicy"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/delete"></see>
    /// </summary>
    let delete = _prefix "delete"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/modify"></see>
    /// </summary>
    let modify = _prefix "modify"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/derive"></see>
    /// </summary>
    let derive = _prefix "derive"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/translate"></see>
    /// </summary>
    let translate = _prefix "translate"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/display"></see>
    /// </summary>
    let display = _prefix "display"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/acceptTracking"></see>
    /// </summary>
    let acceptTracking = _prefix "acceptTracking"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/reviewPolicy"></see>
    /// </summary>
    let reviewPolicy = _prefix "reviewPolicy"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/archive"></see>
    /// </summary>
    let archive = _prefix "archive"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/inform"></see>
    /// </summary>
    let inform = _prefix "inform"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/execute"></see>
    /// </summary>
    let execute = _prefix "execute"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/reproduce"></see>
    /// </summary>
    let reproduce = _prefix "reproduce"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/aggregate"></see>
    /// </summary>
    let aggregate = _prefix "aggregate"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/grantUse"></see>
    /// </summary>
    let grantUse = _prefix "grantUse"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/annotate"></see>
    /// </summary>
    let annotate = _prefix "annotate"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/stream"></see>
    /// </summary>
    let stream = _prefix "stream"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#assetConcepts"></see>
    /// </summary>
    let ``_#assetConcepts`` = _prefix "#assetConcepts"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/AssetCollection"></see>
    /// </summary>
    let AssetCollection = _prefix "AssetCollection"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/Asset"></see>
    /// </summary>
    let Asset = _prefix "Asset"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#assetParty"></see>
    /// </summary>
    let ``_#assetParty`` = _prefix "#assetParty"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/source"></see>
    /// </summary>
    let source = _prefix "source"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/partOf"></see>
    /// </summary>
    let partOf = _prefix "partOf"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#assetRelations"></see>
    /// </summary>
    let ``_#assetRelations`` = _prefix "#assetRelations"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/hasPolicy"></see>
    /// </summary>
    let hasPolicy = _prefix "hasPolicy"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/target"></see>
    /// </summary>
    let target = _prefix "target"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#assetRelationsCommon"></see>
    /// </summary>
    let ``_#assetRelationsCommon`` = _prefix "#assetRelationsCommon"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/output"></see>
    /// </summary>
    let output = _prefix "output"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#conflictConcepts"></see>
    /// </summary>
    let ``_#conflictConcepts`` = _prefix "#conflictConcepts"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/invalid"></see>
    /// </summary>
    let invalid = _prefix "invalid"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/prohibit"></see>
    /// </summary>
    let prohibit = _prefix "prohibit"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/perm"></see>
    /// </summary>
    let perm = _prefix "perm"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/conflict"></see>
    /// </summary>
    let conflict = _prefix "conflict"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/ConflictTerm"></see>
    /// </summary>
    let ConflictTerm = _prefix "ConflictTerm"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#constraintLeftOperandCommon"></see>
    /// </summary>
    let ``_#constraintLeftOperandCommon`` = _prefix "#constraintLeftOperandCommon"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/resolution"></see>
    /// </summary>
    let resolution = _prefix "resolution"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/purpose"></see>
    /// </summary>
    let purpose = _prefix "purpose"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/relativeTemporalPosition"></see>
    /// </summary>
    let relativeTemporalPosition = _prefix "relativeTemporalPosition"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/timeInterval"></see>
    /// </summary>
    let timeInterval = _prefix "timeInterval"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/elapsedTime"></see>
    /// </summary>
    let elapsedTime = _prefix "elapsedTime"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/spatialCoordinates"></see>
    /// </summary>
    let spatialCoordinates = _prefix "spatialCoordinates"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/fileFormat"></see>
    /// </summary>
    let fileFormat = _prefix "fileFormat"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/dateTime"></see>
    /// </summary>
    let dateTime = _prefix "dateTime"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/event"></see>
    /// </summary>
    let event_ = _prefix "event"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/systemDevice"></see>
    /// </summary>
    let systemDevice = _prefix "systemDevice"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/absoluteSpatialPosition"></see>
    /// </summary>
    let absoluteSpatialPosition = _prefix "absoluteSpatialPosition"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/payAmount"></see>
    /// </summary>
    let payAmount = _prefix "payAmount"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/absoluteSize"></see>
    /// </summary>
    let absoluteSize = _prefix "absoluteSize"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/spatial"></see>
    /// </summary>
    let spatial = _prefix "spatial"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/deliveryChannel"></see>
    /// </summary>
    let deliveryChannel = _prefix "deliveryChannel"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/absolutePosition"></see>
    /// </summary>
    let absolutePosition = _prefix "absolutePosition"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/virtualLocation"></see>
    /// </summary>
    let virtualLocation = _prefix "virtualLocation"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/percentage"></see>
    /// </summary>
    let percentage = _prefix "percentage"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/relativePosition"></see>
    /// </summary>
    let relativePosition = _prefix "relativePosition"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/product"></see>
    /// </summary>
    let product = _prefix "product"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/relativeSize"></see>
    /// </summary>
    let relativeSize = _prefix "relativeSize"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/relativeSpatialPosition"></see>
    /// </summary>
    let relativeSpatialPosition = _prefix "relativeSpatialPosition"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/count"></see>
    /// </summary>
    let count = _prefix "count"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/media"></see>
    /// </summary>
    let media = _prefix "media"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/language"></see>
    /// </summary>
    let language = _prefix "language"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/industry"></see>
    /// </summary>
    let industry = _prefix "industry"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/unitOfCount"></see>
    /// </summary>
    let unitOfCount = _prefix "unitOfCount"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/delayPeriod"></see>
    /// </summary>
    let delayPeriod = _prefix "delayPeriod"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/version"></see>
    /// </summary>
    let version = _prefix "version"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/meteredTime"></see>
    /// </summary>
    let meteredTime = _prefix "meteredTime"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/recipient"></see>
    /// </summary>
    let recipient = _prefix "recipient"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/absoluteTemporalPosition"></see>
    /// </summary>
    let absoluteTemporalPosition = _prefix "absoluteTemporalPosition"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#constraintLogicalOperands"></see>
    /// </summary>
    let ``_#constraintLogicalOperands`` = _prefix "#constraintLogicalOperands"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/andSequence"></see>
    /// </summary>
    let andSequence = _prefix "andSequence"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/and"></see>
    /// </summary>
    let and_ = _prefix "and"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/xone"></see>
    /// </summary>
    let xone = _prefix "xone"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/or"></see>
    /// </summary>
    let or_ = _prefix "or"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#constraintRelationalOperators"></see>
    /// </summary>
    let ``_#constraintRelationalOperators`` = _prefix "#constraintRelationalOperators"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/gteq"></see>
    /// </summary>
    let gteq = _prefix "gteq"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/isA"></see>
    /// </summary>
    let isA = _prefix "isA"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/lt"></see>
    /// </summary>
    let lt = _prefix "lt"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/hasPart"></see>
    /// </summary>
    let hasPart = _prefix "hasPart"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/eq"></see>
    /// </summary>
    let eq = _prefix "eq"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/lteq"></see>
    /// </summary>
    let lteq = _prefix "lteq"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/isAllOf"></see>
    /// </summary>
    let isAllOf = _prefix "isAllOf"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/isNoneOf"></see>
    /// </summary>
    let isNoneOf = _prefix "isNoneOf"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/neq"></see>
    /// </summary>
    let neq = _prefix "neq"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/isPartOf"></see>
    /// </summary>
    let isPartOf = _prefix "isPartOf"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/gt"></see>
    /// </summary>
    let gt = _prefix "gt"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/isAnyOf"></see>
    /// </summary>
    let isAnyOf = _prefix "isAnyOf"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#constraintRightOpCommon"></see>
    /// </summary>
    let ``_#constraintRightOpCommon`` = _prefix "#constraintRightOpCommon"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/policyUsage"></see>
    /// </summary>
    let policyUsage = _prefix "policyUsage"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#constraints"></see>
    /// </summary>
    let ``_#constraints`` = _prefix "#constraints"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/constraint"></see>
    /// </summary>
    let constraint_ = _prefix "constraint"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/rightOperand"></see>
    /// </summary>
    let rightOperand = _prefix "rightOperand"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/unit"></see>
    /// </summary>
    let unit = _prefix "unit"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/LeftOperand"></see>
    /// </summary>
    let LeftOperand = _prefix "LeftOperand"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/leftOperand"></see>
    /// </summary>
    let leftOperand = _prefix "leftOperand"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/rightOperandReference"></see>
    /// </summary>
    let rightOperandReference = _prefix "rightOperandReference"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/RightOperand"></see>
    /// </summary>
    let RightOperand = _prefix "RightOperand"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/status"></see>
    /// </summary>
    let status = _prefix "status"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/operator"></see>
    /// </summary>
    let operator = _prefix "operator"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/Operator"></see>
    /// </summary>
    let Operator = _prefix "Operator"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/refinement"></see>
    /// </summary>
    let refinement = _prefix "refinement"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/Constraint"></see>
    /// </summary>
    let Constraint = _prefix "Constraint"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/dataType"></see>
    /// </summary>
    let dataType = _prefix "dataType"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#deprecatedTerms"></see>
    /// </summary>
    let ``_#deprecatedTerms`` = _prefix "#deprecatedTerms"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/shareAlike"></see>
    /// </summary>
    let shareAlike = _prefix "shareAlike"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/All"></see>
    /// </summary>
    let All = _prefix "All"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/All2ndConnections"></see>
    /// </summary>
    let All2ndConnections = _prefix "All2ndConnections"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/PartyScope"></see>
    /// </summary>
    let PartyScope = _prefix "PartyScope"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/scope"></see>
    /// </summary>
    let scope = _prefix "scope"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/device"></see>
    /// </summary>
    let device = _prefix "device"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/write"></see>
    /// </summary>
    let write = _prefix "write"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/pay"></see>
    /// </summary>
    let pay = _prefix "pay"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/payeeParty"></see>
    /// </summary>
    let payeeParty = _prefix "payeeParty"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/copy"></see>
    /// </summary>
    let copy = _prefix "copy"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/inheritRelation"></see>
    /// </summary>
    let inheritRelation = _prefix "inheritRelation"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/lend"></see>
    /// </summary>
    let lend = _prefix "lend"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/timedCount"></see>
    /// </summary>
    let timedCount = _prefix "timedCount"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/lease"></see>
    /// </summary>
    let lease = _prefix "lease"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/Group"></see>
    /// </summary>
    let Group = _prefix "Group"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/writeTo"></see>
    /// </summary>
    let writeTo = _prefix "writeTo"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/system"></see>
    /// </summary>
    let system = _prefix "system"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/AssetScope"></see>
    /// </summary>
    let AssetScope = _prefix "AssetScope"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/inheritAllowed"></see>
    /// </summary>
    let inheritAllowed = _prefix "inheritAllowed"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/proximity"></see>
    /// </summary>
    let proximity = _prefix "proximity"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/commercialize"></see>
    /// </summary>
    let commercialize = _prefix "commercialize"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/Individual"></see>
    /// </summary>
    let Individual = _prefix "Individual"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/ignore"></see>
    /// </summary>
    let ignore = _prefix "ignore"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/preview"></see>
    /// </summary>
    let preview = _prefix "preview"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/appendTo"></see>
    /// </summary>
    let appendTo = _prefix "appendTo"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/attachSource"></see>
    /// </summary>
    let attachSource = _prefix "attachSource"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/export"></see>
    /// </summary>
    let export = _prefix "export"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/attachPolicy"></see>
    /// </summary>
    let attachPolicy = _prefix "attachPolicy"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/extractChar"></see>
    /// </summary>
    let extractChar = _prefix "extractChar"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/share"></see>
    /// </summary>
    let share = _prefix "share"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/extractPage"></see>
    /// </summary>
    let extractPage = _prefix "extractPage"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/secondaryUse"></see>
    /// </summary>
    let secondaryUse = _prefix "secondaryUse"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/adHocShare"></see>
    /// </summary>
    let adHocShare = _prefix "adHocShare"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/AllConnections"></see>
    /// </summary>
    let AllConnections = _prefix "AllConnections"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/support"></see>
    /// </summary>
    let support = _prefix "support"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/AllGroups"></see>
    /// </summary>
    let AllGroups = _prefix "AllGroups"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/UndefinedTerm"></see>
    /// </summary>
    let UndefinedTerm = _prefix "UndefinedTerm"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/extractWord"></see>
    /// </summary>
    let extractWord = _prefix "extractWord"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/undefined"></see>
    /// </summary>
    let undefined = _prefix "undefined"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/append"></see>
    /// </summary>
    let append = _prefix "append"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/license"></see>
    /// </summary>
    let license = _prefix "license"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#duties"></see>
    /// </summary>
    let ``_#duties`` = _prefix "#duties"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/remedy"></see>
    /// </summary>
    let remedy = _prefix "remedy"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/consequence"></see>
    /// </summary>
    let consequence = _prefix "consequence"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/duty"></see>
    /// </summary>
    let duty = _prefix "duty"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/obligation"></see>
    /// </summary>
    let obligation = _prefix "obligation"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/Duty"></see>
    /// </summary>
    let Duty = _prefix "Duty"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#logicalConstraints"></see>
    /// </summary>
    let ``_#logicalConstraints`` = _prefix "#logicalConstraints"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/operand"></see>
    /// </summary>
    let operand = _prefix "operand"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/LogicalConstraint"></see>
    /// </summary>
    let LogicalConstraint = _prefix "LogicalConstraint"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#partyConcepts"></see>
    /// </summary>
    let ``_#partyConcepts`` = _prefix "#partyConcepts"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/PartyCollection"></see>
    /// </summary>
    let PartyCollection = _prefix "PartyCollection"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/Party"></see>
    /// </summary>
    let Party = _prefix "Party"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#partyRoles"></see>
    /// </summary>
    let ``_#partyRoles`` = _prefix "#partyRoles"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/assignerOf"></see>
    /// </summary>
    let assignerOf = _prefix "assignerOf"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/assigneeOf"></see>
    /// </summary>
    let assigneeOf = _prefix "assigneeOf"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/assigner"></see>
    /// </summary>
    let assigner = _prefix "assigner"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/assignee"></see>
    /// </summary>
    let assignee = _prefix "assignee"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#partyRolesCommon"></see>
    /// </summary>
    let ``_#partyRolesCommon`` = _prefix "#partyRolesCommon"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/consentingParty"></see>
    /// </summary>
    let consentingParty = _prefix "consentingParty"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/contractingParty"></see>
    /// </summary>
    let contractingParty = _prefix "contractingParty"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/attributedParty"></see>
    /// </summary>
    let attributedParty = _prefix "attributedParty"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/compensatedParty"></see>
    /// </summary>
    let compensatedParty = _prefix "compensatedParty"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/informedParty"></see>
    /// </summary>
    let informedParty = _prefix "informedParty"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/trackingParty"></see>
    /// </summary>
    let trackingParty = _prefix "trackingParty"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/informingParty"></see>
    /// </summary>
    let informingParty = _prefix "informingParty"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/compensatingParty"></see>
    /// </summary>
    let compensatingParty = _prefix "compensatingParty"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/trackedParty"></see>
    /// </summary>
    let trackedParty = _prefix "trackedParty"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/contractedParty"></see>
    /// </summary>
    let contractedParty = _prefix "contractedParty"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/attributingParty"></see>
    /// </summary>
    let attributingParty = _prefix "attributingParty"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/consentedParty"></see>
    /// </summary>
    let consentedParty = _prefix "consentedParty"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#permissions"></see>
    /// </summary>
    let ``_#permissions`` = _prefix "#permissions"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/permission"></see>
    /// </summary>
    let permission = _prefix "permission"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/Permission"></see>
    /// </summary>
    let Permission = _prefix "Permission"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#policyConcepts"></see>
    /// </summary>
    let ``_#policyConcepts`` = _prefix "#policyConcepts"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/inheritFrom"></see>
    /// </summary>
    let inheritFrom = _prefix "inheritFrom"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/profile"></see>
    /// </summary>
    let profile = _prefix "profile"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/uid"></see>
    /// </summary>
    let uid = _prefix "uid"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/Policy"></see>
    /// </summary>
    let Policy = _prefix "Policy"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#policySubClasses"></see>
    /// </summary>
    let ``_#policySubClasses`` = _prefix "#policySubClasses"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/Set"></see>
    /// </summary>
    let Set = _prefix "Set"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/Offer"></see>
    /// </summary>
    let Offer = _prefix "Offer"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/Agreement"></see>
    /// </summary>
    let Agreement = _prefix "Agreement"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#policySubClassesCommon"></see>
    /// </summary>
    let ``_#policySubClassesCommon`` = _prefix "#policySubClassesCommon"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/Ticket"></see>
    /// </summary>
    let Ticket = _prefix "Ticket"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/Request"></see>
    /// </summary>
    let Request = _prefix "Request"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/Privacy"></see>
    /// </summary>
    let Privacy = _prefix "Privacy"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/Assertion"></see>
    /// </summary>
    let Assertion = _prefix "Assertion"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#prohibitions"></see>
    /// </summary>
    let ``_#prohibitions`` = _prefix "#prohibitions"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/prohibition"></see>
    /// </summary>
    let prohibition = _prefix "prohibition"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/Prohibition"></see>
    /// </summary>
    let Prohibition = _prefix "Prohibition"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/#ruleConcepts"></see>
    /// </summary>
    let ``_#ruleConcepts`` = _prefix "#ruleConcepts"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/failure"></see>
    /// </summary>
    let failure = _prefix "failure"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/function"></see>
    /// </summary>
    let function_ = _prefix "function"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/relation"></see>
    /// </summary>
    let relation = _prefix "relation"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/Rule"></see>
    /// </summary>
    let Rule = _prefix "Rule"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/odrl/2/core"></see>
    /// </summary>
    let core = _prefix "core"
