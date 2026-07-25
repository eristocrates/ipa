namespace http.w3id.org.amlo.core.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module amlo_core =
    let _namespace_iri = Namespace_Iri amlo_core |> NamespaceIRI
    /// <summary>
    ///   <para>amlo-core:hasEvaluation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>collega un soggetto ad una valutazione</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#hasEvaluation">http://w3id.org/amlo/core#hasEvaluation</seealso>
    let hasEvaluation = Prefixed_Name(amlo_core, "hasEvaluation") |> PrefixedName
    /// <summary>
    ///   <para>amlo-core:detects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rileva una operatività inattesa</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#detects">http://w3id.org/amlo/core#detects</seealso>
    let detects = Prefixed_Name(amlo_core, "detects") |> PrefixedName
    /// <summary>
    ///   <para>amlo-core:not-enough-data</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>amlo-core:SuspectRatingScore</para>
    ///   <para>valutazione non effettuata per mancanza di dati</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#not-enough-data">http://w3id.org/amlo/core#not-enough-data</seealso>
    let not_enough_data = Prefixed_Name(amlo_core, "not-enough-data") |> PrefixedName
    /// <summary>
    ///   <para>amlo-core:Accountable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>identifica un agente come   responsabile di una operatività inattesa</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#Accountable">http://w3id.org/amlo/core#Accountable</seealso>
    let Accountable = Prefixed_Name(amlo_core, "Accountable") |> PrefixedName
    /// <summary>
    ///   <para>amlo-core:Book</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>identifica un qualsiasi registro usato per annotare record</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#Book">http://w3id.org/amlo/core#Book</seealso>
    let Book = Prefixed_Name(amlo_core, "Book") |> PrefixedName
    /// <summary>
    ///   <para>amlo-core:Cash</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>un ammotare di denaro in banconote o monete</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#Cash">http://w3id.org/amlo/core#Cash</seealso>
    let Cash = Prefixed_Name(amlo_core, "Cash") |> PrefixedName
    /// <summary>
    ///   <para>amlo-core:IntangibleAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>qualsiasi bene intangibile che non sia denaro o immobili</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#IntangibleAsset">http://w3id.org/amlo/core#IntangibleAsset</seealso>
    let IntangibleAsset = Prefixed_Name(amlo_core, "IntangibleAsset") |> PrefixedName
    /// <summary>
    ///   <para>amlo-core:RecipientBook</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>identifica un registro  (es. libro mastro) usato  usato per annotare un trasferimento  dala parte del ricevente</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#RecipientBook">http://w3id.org/amlo/core#RecipientBook</seealso>
    let RecipientBook = Prefixed_Name(amlo_core, "RecipientBook") |> PrefixedName
    /// <summary>
    ///   <para>amlo-core:RiskRating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>una stima di un  fattore di rischio associato a qualcosa</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#RiskRating">http://w3id.org/amlo/core#RiskRating</seealso>
    let RiskRating = Prefixed_Name(amlo_core, "RiskRating") |> PrefixedName
    /// <summary>
    ///   <para>amlo-core:OriginatorBook</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>identifica un registro  (es. libro mastro) usato  usato per annotare un trasferimento  da parte dell'ordinate</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#OriginatorBook">http://w3id.org/amlo/core#OriginatorBook</seealso>
    let OriginatorBook = Prefixed_Name(amlo_core, "OriginatorBook") |> PrefixedName
    /// <summary>
    ///   <para>amlo-core:RiskEvaluation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>un opinione espressa su un rischio</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#RiskEvaluation">http://w3id.org/amlo/core#RiskEvaluation</seealso>
    let RiskEvaluation = Prefixed_Name(amlo_core, "RiskEvaluation") |> PrefixedName
    /// <summary>
    ///   <para>amlo-core:onRiskFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>collega qualcosa ald un concetto di rischio astratto</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#onRiskFactor">http://w3id.org/amlo/core#onRiskFactor</seealso>
    let onRiskFactor = Prefixed_Name(amlo_core, "onRiskFactor") |> PrefixedName
    /// <summary>
    ///   <para>amlo-core:RiskSizing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>un dimensionamento del rischio basato su una o più quantità misurabili associato a qualcosa</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#RiskSizing">http://w3id.org/amlo/core#RiskSizing</seealso>
    let RiskSizing = Prefixed_Name(amlo_core, "RiskSizing") |> PrefixedName
    /// <summary>
    ///   <para>amlo-core:Transfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>un trasferimento di denaro o di un altro valore che coinvolge un ordinate, un ricevente e eventuali registri su cui è annotato il trasferimento</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#Transfer">http://w3id.org/amlo/core#Transfer</seealso>
    let Transfer = Prefixed_Name(amlo_core, "Transfer") |> PrefixedName
    /// <summary>
    ///   <para>amlo-core:Gender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A person Gender</para>
    /// labels<para></para></remarks>
    /// <seealso href="http://w3id.org/amlo/core#Gender">http://w3id.org/amlo/core#Gender</seealso>
    let Gender = Prefixed_Name(amlo_core, "Gender") |> PrefixedName
    /// <summary>
    ///   <para>amlo-core:RecipientParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>identifica un agente  come destinatario di un trasferimento</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#RecipientParty">http://w3id.org/amlo/core#RecipientParty</seealso>
    let RecipientParty = Prefixed_Name(amlo_core, "RecipientParty") |> PrefixedName
    /// <summary>
    ///   <para>amlo-core:assessedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>si riferisce all'oggetto di una valutazione</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#assessedOn">http://w3id.org/amlo/core#assessedOn</seealso>
    let assessedOn = Prefixed_Name(amlo_core, "assessedOn") |> PrefixedName
    /// <summary>
    ///   <para>amlo-core:SuspectRating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rappresenta l'esito di un’attività di investigazione su una operatività inattesa  finalizzata a valutarne il grado di sospetto</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#SuspectRating">http://w3id.org/amlo/core#SuspectRating</seealso>
    let SuspectRating = Prefixed_Name(amlo_core, "SuspectRating") |> PrefixedName

    /// <summary>
    ///   <para>amlo-core:hasSuspectRatingScore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>collega un valore qualitativo espresso su un rischio</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#hasSuspectRatingScore">http://w3id.org/amlo/core#hasSuspectRatingScore</seealso>
    let hasSuspectRatingScore =
        Prefixed_Name(amlo_core, "hasSuspectRatingScore") |> PrefixedName

    /// <summary>
    ///   <para>amlo-core:SuspectRatingScore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>definisce qualitativamente il grado di sospetto che grava su qualcosa</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#SuspectRatingScore">http://w3id.org/amlo/core#SuspectRatingScore</seealso>
    let SuspectRatingScore =
        Prefixed_Name(amlo_core, "SuspectRatingScore") |> PrefixedName

    /// <summary>
    ///   <para>amlo-core:transfers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>trasferisce qualcosa</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#transfers">http://w3id.org/amlo/core#transfers</seealso>
    let transfers = Prefixed_Name(amlo_core, "transfers") |> PrefixedName
    /// <summary>
    ///   <para>amlo-core:hasRiskEstimator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>un valore copreso tra 0 e 1 che rappresenta lo stimatore di un rischio</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#hasRiskEstimator">http://w3id.org/amlo/core#hasRiskEstimator</seealso>
    let hasRiskEstimator = Prefixed_Name(amlo_core, "hasRiskEstimator") |> PrefixedName

    /// <summary>
    ///   <para>amlo-core:UnexpectedActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>evidenzia un insieme di movimenti, eventi o azioni non usuali che sono attribuiti ad un agente</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#UnexpectedActivity">http://w3id.org/amlo/core#UnexpectedActivity</seealso>
    let UnexpectedActivity =
        Prefixed_Name(amlo_core, "UnexpectedActivity") |> PrefixedName

    /// <summary>
    ///   <para>amlo-core:UnexpectedActivityReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>un documento che riporta una operatività inattesa da segnalare ad un agente preposto alla sua valutazione</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#UnexpectedActivityReport">http://w3id.org/amlo/core#UnexpectedActivityReport</seealso>
    let UnexpectedActivityReport =
        Prefixed_Name(amlo_core, "UnexpectedActivityReport") |> PrefixedName

    /// <summary>
    ///   <para>amlo-core:female</para>
    /// </summary>
    /// <remarks>
    ///   <para>amlo-core:Gender</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>a female person</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#female">http://w3id.org/amlo/core#female</seealso>
    let female = Prefixed_Name(amlo_core, "female") |> PrefixedName
    /// <summary>
    ///   <para>amlo-core:hasSizeEstimator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>collega una stima quantitativa ad un rischio</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#hasSizeEstimator">http://w3id.org/amlo/core#hasSizeEstimator</seealso>
    let hasSizeEstimator = Prefixed_Name(amlo_core, "hasSizeEstimator") |> PrefixedName
    /// <summary>
    ///   <para>amlo-core:male</para>
    /// </summary>
    /// <remarks>
    ///   <para>amlo-core:Gender</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>a male person</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#male">http://w3id.org/amlo/core#male</seealso>
    let male = Prefixed_Name(amlo_core, "male") |> PrefixedName
    /// <summary>
    ///   <para>amlo-core:not-suspicious</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>amlo-core:SuspectRatingScore</para>
    ///   <para>il soggetto annotato non è sospetto</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#not-suspicious">http://w3id.org/amlo/core#not-suspicious</seealso>
    let not_suspicious = Prefixed_Name(amlo_core, "not-suspicious") |> PrefixedName
    /// <summary>
    ///   <para>amlo-core:to-be-ignored</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>amlo-core:SuspectRatingScore</para>
    ///   <para>il grado di sospetto non è valutato perchè una direttiva impedisce esplicitamente la valutazione del soggetto</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#to-be-ignored">http://w3id.org/amlo/core#to-be-ignored</seealso>
    let to_be_ignored = Prefixed_Name(amlo_core, "to-be-ignored") |> PrefixedName
    /// <summary>
    ///   <para>amlo-core:isDetectedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>è rilevata da une evento di ricerca operatività sospetta</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#isDetectedBy">http://w3id.org/amlo/core#isDetectedBy</seealso>
    let isDetectedBy = Prefixed_Name(amlo_core, "isDetectedBy") |> PrefixedName
    /// <summary>
    ///   <para>amlo-core:hasGender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#hasGender">http://w3id.org/amlo/core#hasGender</seealso>
    let hasGender = Prefixed_Name(amlo_core, "hasGender") |> PrefixedName
    /// <summary>
    ///   <para>amlo-core:isRecordedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>identifica un libro utilizzato per registrare un trasferimento</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#isRecordedIn">http://w3id.org/amlo/core#isRecordedIn</seealso>
    let isRecordedIn = Prefixed_Name(amlo_core, "isRecordedIn") |> PrefixedName
    /// <summary>
    ///   <para>amlo-core:suspicious</para>
    /// </summary>
    /// <remarks>
    ///   <para>amlo-core:SuspectRatingScore</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>il soggetto annotato è sospetto</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#suspicious">http://w3id.org/amlo/core#suspicious</seealso>
    let suspicious = Prefixed_Name(amlo_core, "suspicious") |> PrefixedName
    /// <summary>
    ///   <para>amlo-core:suspect-codes</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Codes/CodeSet&gt;</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>definisce i possibili gradi di sospetto</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#suspect-codes">http://w3id.org/amlo/core#suspect-codes</seealso>
    let suspect_codes = Prefixed_Name(amlo_core, "suspect-codes") |> PrefixedName
    /// <summary>
    ///   <para>amlo-core:unexpected</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>amlo-core:SuspectRatingScore</para>
    ///   <para>il soggetto è potenzialmente sospetto a causa della presenza di indici di anomalia o altri elementi di attenzione</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#unexpected">http://w3id.org/amlo/core#unexpected</seealso>
    let unexpected = Prefixed_Name(amlo_core, "unexpected") |> PrefixedName

    /// <summary>
    ///   <para>amlo-core:suspect-rating-scale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-arr-rt:RatingScale</para>
    ///   <para>la scala di gradazione  gradazione del sospetto</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#suspect-rating-scale">http://w3id.org/amlo/core#suspect-rating-scale</seealso>
    let suspect_rating_scale =
        Prefixed_Name(amlo_core, "suspect-rating-scale") |> PrefixedName

    /// <summary>
    ///   <para>amlo-core:Analyst</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>identifica un agente preposto alla valutazione di una operatività inattesa</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#Analyst">http://w3id.org/amlo/core#Analyst</seealso>
    let Analyst = Prefixed_Name(amlo_core, "Analyst") |> PrefixedName
    /// <summary>
    ///   <para>amlo-core:OriginatorParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>identifica  un agente che ordina un trasferimento</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#OriginatorParty">http://w3id.org/amlo/core#OriginatorParty</seealso>
    let OriginatorParty = Prefixed_Name(amlo_core, "OriginatorParty") |> PrefixedName
    /// <summary>
    ///   <para>amlo-core:Reasoner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>identifica un un agente che ragionando su dati esistenti inferisce nuove informazioni</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#Reasoner">http://w3id.org/amlo/core#Reasoner</seealso>
    let Reasoner = Prefixed_Name(amlo_core, "Reasoner") |> PrefixedName
    /// <summary>
    ///   <para>amlo-core:RiskEstimator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>un valore probabilistico che esclude certezze</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/amlo/core#RiskEstimator">http://w3id.org/amlo/core#RiskEstimator</seealso>
    let RiskEstimator = Prefixed_Name(amlo_core, "RiskEstimator") |> PrefixedName
