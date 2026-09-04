#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``amlo-core`` =
    let _prefixId = PrefixId.fromNamespaceLabel "http://w3id.org/amlo/core#" "amlo-core"
    /// <summary>
    ///   <para>rdfs:comment : identifica un agente come   responsabile di una operatività inattesa</para>
    ///   <a href="http://w3id.org/amlo/core#Accountable">amlo-core:Accountable</a>
    /// </summary>
    let Accountable = _prefixId.prefix "Accountable"
    /// <summary>
    ///   <para>rdfs:comment : identifica un agente preposto alla valutazione di una operatività inattesa</para>
    ///   <a href="http://w3id.org/amlo/core#Analyst">amlo-core:Analyst</a>
    /// </summary>
    let Analyst = _prefixId.prefix "Analyst"
    /// <summary>
    ///   <para>rdfs:comment : identifica un qualsiasi registro usato per annotare record</para>
    ///   <a href="http://w3id.org/amlo/core#Book">amlo-core:Book</a>
    /// </summary>
    let Book = _prefixId.prefix "Book"
    /// <summary>
    ///   <para>rdfs:comment : un ammotare di denaro in banconote o monete</para>
    ///   <a href="http://w3id.org/amlo/core#Cash">amlo-core:Cash</a>
    /// </summary>
    let Cash = _prefixId.prefix "Cash"
    /// <summary>
    ///   <para>rdfs:label : ^^xsd:string</para>
    ///   <para>rdfs:comment : A person Gender^^xsd:string</para>
    ///   <a href="http://w3id.org/amlo/core#Gender">amlo-core:Gender</a>
    /// </summary>
    let Gender = _prefixId.prefix "Gender"
    /// <summary>
    ///   <para>rdfs:comment : qualsiasi bene intangibile che non sia denaro o immobili</para>
    ///   <a href="http://w3id.org/amlo/core#IntangibleAsset">amlo-core:IntangibleAsset</a>
    /// </summary>
    let IntangibleAsset = _prefixId.prefix "IntangibleAsset"
    /// <summary>
    ///   <para>rdfs:comment : identifica un registro  (es. libro mastro) usato  usato per annotare un trasferimento  da parte dell'ordinate</para>
    ///   <a href="http://w3id.org/amlo/core#OriginatorBook">amlo-core:OriginatorBook</a>
    /// </summary>
    let OriginatorBook = _prefixId.prefix "OriginatorBook"
    /// <summary>
    ///   <para>rdfs:comment : identifica  un agente che ordina un trasferimento</para>
    ///   <a href="http://w3id.org/amlo/core#OriginatorParty">amlo-core:OriginatorParty</a>
    /// </summary>
    let OriginatorParty = _prefixId.prefix "OriginatorParty"
    /// <summary>
    ///   <para>rdfs:comment : identifica un un agente che ragionando su dati esistenti inferisce nuove informazioni</para>
    ///   <a href="http://w3id.org/amlo/core#Reasoner">amlo-core:Reasoner</a>
    /// </summary>
    let Reasoner = _prefixId.prefix "Reasoner"
    /// <summary>
    ///   <para>rdfs:comment : identifica un registro  (es. libro mastro) usato  usato per annotare un trasferimento  dala parte del ricevente</para>
    ///   <a href="http://w3id.org/amlo/core#RecipientBook">amlo-core:RecipientBook</a>
    /// </summary>
    let RecipientBook = _prefixId.prefix "RecipientBook"
    /// <summary>
    ///   <para>rdfs:comment : identifica un agente  come destinatario di un trasferimento</para>
    ///   <a href="http://w3id.org/amlo/core#RecipientParty">amlo-core:RecipientParty</a>
    /// </summary>
    let RecipientParty = _prefixId.prefix "RecipientParty"
    let RiskEstimator = _prefixId.prefix "RiskEstimator"
    /// <summary>
    ///   <para>rdfs:comment : un opinione espressa su un rischio</para>
    ///   <a href="http://w3id.org/amlo/core#RiskEvaluation">amlo-core:RiskEvaluation</a>
    /// </summary>
    let RiskEvaluation = _prefixId.prefix "RiskEvaluation"
    /// <summary>
    ///   <para>rdfs:comment : una stima di un  fattore di rischio associato a qualcosa</para>
    ///   <a href="http://w3id.org/amlo/core#RiskRating">amlo-core:RiskRating</a>
    /// </summary>
    let RiskRating = _prefixId.prefix "RiskRating"
    /// <summary>
    ///   <para>rdfs:comment : un dimensionamento del rischio basato su una o più quantità misurabili associato a qualcosa</para>
    ///   <a href="http://w3id.org/amlo/core#RiskSizing">amlo-core:RiskSizing</a>
    /// </summary>
    let RiskSizing = _prefixId.prefix "RiskSizing"
    /// <summary>
    ///   <para>rdfs:comment : rappresenta l'esito di un’attività di investigazione su una operatività inattesa  finalizzata a valutarne il grado di sospetto</para>
    ///   <a href="http://w3id.org/amlo/core#SuspectRating">amlo-core:SuspectRating</a>
    /// </summary>
    let SuspectRating = _prefixId.prefix "SuspectRating"
    /// <summary>
    ///   <para>rdfs:comment : definisce qualitativamente il grado di sospetto che grava su qualcosa</para>
    ///   <a href="http://w3id.org/amlo/core#SuspectRatingScore">amlo-core:SuspectRatingScore</a>
    /// </summary>
    let SuspectRatingScore = _prefixId.prefix "SuspectRatingScore"
    /// <summary>
    ///   <para>rdfs:comment : un trasferimento di denaro o di un altro valore che coinvolge un ordinate, un ricevente e eventuali registri su cui è annotato il trasferimento</para>
    ///   <a href="http://w3id.org/amlo/core#Transfer">amlo-core:Transfer</a>
    /// </summary>
    let Transfer = _prefixId.prefix "Transfer"
    /// <summary>
    ///   <para>rdfs:comment : evidenzia un insieme di movimenti, eventi o azioni non usuali che sono attribuiti ad un agente</para>
    ///   <a href="http://w3id.org/amlo/core#UnexpectedActivity">amlo-core:UnexpectedActivity</a>
    /// </summary>
    let UnexpectedActivity = _prefixId.prefix "UnexpectedActivity"
    /// <summary>
    ///   <para>rdfs:comment : un documento che riporta una operatività inattesa da segnalare ad un agente preposto alla sua valutazione</para>
    ///   <a href="http://w3id.org/amlo/core#UnexpectedActivityReport">amlo-core:UnexpectedActivityReport</a>
    /// </summary>
    let UnexpectedActivityReport = _prefixId.prefix "UnexpectedActivityReport"
    /// <summary>
    ///   <para>rdfs:comment : si riferisce all'oggetto di una valutazione</para>
    ///   <a href="http://w3id.org/amlo/core#assessedOn">amlo-core:assessedOn</a>
    /// </summary>
    let assessedOn = _prefixId.prefix "assessedOn"
    /// <summary>
    ///   <para>rdfs:comment : rileva una operatività inattesa</para>
    ///   <a href="http://w3id.org/amlo/core#detects">amlo-core:detects</a>
    /// </summary>
    let detects = _prefixId.prefix "detects"
    let female = _prefixId.prefix "female"
    /// <summary>
    ///   <para>rdfs:comment : collega un soggetto ad una valutazione</para>
    ///   <a href="http://w3id.org/amlo/core#hasEvaluation">amlo-core:hasEvaluation</a>
    /// </summary>
    let hasEvaluation = _prefixId.prefix "hasEvaluation"
    let hasGender = _prefixId.prefix "hasGender"
    /// <summary>
    ///   <para>rdfs:comment : un valore copreso tra 0 e 1 che rappresenta lo stimatore di un rischio</para>
    ///   <a href="http://w3id.org/amlo/core#hasRiskEstimator">amlo-core:hasRiskEstimator</a>
    /// </summary>
    let hasRiskEstimator = _prefixId.prefix "hasRiskEstimator"
    /// <summary>
    ///   <para>rdfs:comment : collega una stima quantitativa ad un rischio</para>
    ///   <a href="http://w3id.org/amlo/core#hasSizeEstimator">amlo-core:hasSizeEstimator</a>
    /// </summary>
    let hasSizeEstimator = _prefixId.prefix "hasSizeEstimator"
    /// <summary>
    ///   <para>rdfs:comment : collega un valore qualitativo espresso su un rischio</para>
    ///   <a href="http://w3id.org/amlo/core#hasSuspectRatingScore">amlo-core:hasSuspectRatingScore</a>
    /// </summary>
    let hasSuspectRatingScore = _prefixId.prefix "hasSuspectRatingScore"
    /// <summary>
    ///   <para>rdfs:comment : è rilevata da une evento di ricerca operatività sospetta</para>
    ///   <a href="http://w3id.org/amlo/core#isDetectedBy">amlo-core:isDetectedBy</a>
    /// </summary>
    let isDetectedBy = _prefixId.prefix "isDetectedBy"
    /// <summary>
    ///   <para>rdfs:comment : identifica un libro utilizzato per registrare un trasferimento</para>
    ///   <a href="http://w3id.org/amlo/core#isRecordedIn">amlo-core:isRecordedIn</a>
    /// </summary>
    let isRecordedIn = _prefixId.prefix "isRecordedIn"
    let male = _prefixId.prefix "male"
    let not_enough_data = _prefixId.prefix "not-enough-data"
    let not_suspicious = _prefixId.prefix "not-suspicious"
    /// <summary>
    ///   <para>rdfs:comment : collega qualcosa ald un concetto di rischio astratto</para>
    ///   <a href="http://w3id.org/amlo/core#onRiskFactor">amlo-core:onRiskFactor</a>
    /// </summary>
    let onRiskFactor = _prefixId.prefix "onRiskFactor"
    let suspect_codes = _prefixId.prefix "suspect-codes"
    let suspect_rating_scale = _prefixId.prefix "suspect-rating-scale"
    let suspicious = _prefixId.prefix "suspicious"
    let to_be_ignored = _prefixId.prefix "to-be-ignored"
    /// <summary>
    ///   <para>rdfs:comment : trasferisce qualcosa</para>
    ///   <a href="http://w3id.org/amlo/core#transfers">amlo-core:transfers</a>
    /// </summary>
    let transfers = _prefixId.prefix "transfers"
    let unexpected = _prefixId.prefix "unexpected"
