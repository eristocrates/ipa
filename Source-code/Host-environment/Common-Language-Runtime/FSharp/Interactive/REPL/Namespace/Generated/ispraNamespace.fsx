#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ispra =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://dati.isprambiente.it/ontology/core#" "ispra"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Accelerometrordfs:label : Accelerometer</para>
    ///   <para>rdfs:comment : Strumentordfs:comment : Instrument</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#Accelerometer">ispra:Accelerometer</a>
    /// </summary>
    let Accelerometer = _prefixId.prefix "Accelerometer"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Pressione atmosfericardfs:label : Atmospheric Pressure</para>
    ///   <para>rdfs:comment : Parametro Meteorologicordfs:comment : Meteorological Parameter</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#AirPres">ispra:AirPres</a>
    /// </summary>
    let AirPres = _prefixId.prefix "AirPres"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Temperatura dell'ariardfs:label : Air Temperature</para>
    ///   <para>rdfs:comment : Parametro Meteorologicordfs:comment : Meteorological Parameter</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#AirTemp">ispra:AirTemp</a>
    /// </summary>
    let AirTemp = _prefixId.prefix "AirTemp"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Anemometrordfs:label : Anemometer</para>
    ///   <para>rdfs:comment : Strumentordfs:comment : Instrument</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#Anemometer">ispra:Anemometer</a>
    /// </summary>
    let Anemometer = _prefixId.prefix "Anemometer"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Autoritàrdfs:label : Authority kind</para>
    ///   <para>rdfs:comment : Ente coinvolto e funzione svolta.rdfs:comment : Involved authorities and role played.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#AuthorityKind">ispra:AuthorityKind</a>
    /// </summary>
    let AuthorityKind = _prefixId.prefix "AuthorityKind"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Barometrordfs:label : Barometer</para>
    ///   <para>rdfs:comment : Strumentordfs:comment : Instrument</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#Barometer">ispra:Barometer</a>
    /// </summary>
    let Barometer = _prefixId.prefix "Barometer"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Conducibilitàrdfs:label : Conductivity</para>
    ///   <para>rdfs:comment : Parametro  di Qualitàrdfs:comment : Quality Parameter</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#Conductivity">ispra:Conductivity</a>
    /// </summary>
    let Conductivity = _prefixId.prefix "Conductivity"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Lottordfs:label : Contract</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#Contract">ispra:Contract</a>
    /// </summary>
    let Contract = _prefixId.prefix "Contract"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Indicatore economicordfs:label : Economic Indicator</para>
    ///   <para>rdfs:comment : Parametro del quadro economico del lotto.rdfs:comment : Parameter of the project economic framework.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#EconomicIndicator">ispra:EconomicIndicator</a>
    /// </summary>
    let EconomicIndicator = _prefixId.prefix "EconomicIndicator"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Elemento geograficordfs:label : Geographical feature</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#GeoFeature">ispra:GeoFeature</a>
    /// </summary>
    let GeoFeature = _prefixId.prefix "GeoFeature"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Idrometrordfs:label : Hydrometer</para>
    ///   <para>rdfs:comment : Strumentordfs:comment : Instrument</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#Hydrometer">ispra:Hydrometer</a>
    /// </summary>
    let Hydrometer = _prefixId.prefix "Hydrometer"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Livello idrometricordfs:label : Hydrometric Level</para>
    ///   <para>rdfs:comment : Parametro Oceanograficordfs:comment : Oceanographic Parameter</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#HydrometricLevel">ispra:HydrometricLevel</a>
    /// </summary>
    let HydrometricLevel = _prefixId.prefix "HydrometricLevel"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Igrometrordfs:label : Hygrometer</para>
    ///   <para>rdfs:comment : Strumentordfs:comment : Instrument</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#Hygrometer">ispra:Hygrometer</a>
    /// </summary>
    let Hygrometer = _prefixId.prefix "Hygrometer"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Indicatorerdfs:label : Indicator</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#Indicator">ispra:Indicator</a>
    /// </summary>
    let Indicator = _prefixId.prefix "Indicator"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Collezione di indicatorirdfs:label : Indicator Collection</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#IndicatorCollection">ispra:IndicatorCollection</a>
    /// </summary>
    let IndicatorCollection = _prefixId.prefix "IndicatorCollection"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Dissestordfs:label : Instability</para>
    ///   <para>rdfs:comment : Tipologia di dissesto indicata in progetto o rilevata in sito.rdfs:comment : Type of instability phenomenon shown in the drawings or observed by site visit.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#Instability">ispra:Instability</a>
    /// </summary>
    let Instability = _prefixId.prefix "Instability"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Strumentordfs:label : Instrument</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#Instrument">ispra:Instrument</a>
    /// </summary>
    let Instrument = _prefixId.prefix "Instrument"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Interventordfs:label : Action</para>
    ///   <para>rdfs:comment : Intervento per la mitigazione del rischio idrogeologico a cui è assegnato uno specifico finanziamento. Può essere costituito da uno più lotti.rdfs:comment : A single action, funded under a plan for hydrogeological risk mitigation. It may consist of one or more related projects.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#Intervention">ispra:Intervention</a>
    /// </summary>
    let Intervention = _prefixId.prefix "Intervention"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Litologiardfs:label : Lithology</para>
    ///   <para>rdfs:comment : Tipi litologici indicati in progetto.rdfs:comment : Lithology as stated in the project.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#Lithology">ispra:Lithology</a>
    /// </summary>
    let Lithology = _prefixId.prefix "Lithology"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Passi del lottordfs:label : Lot step</para>
    ///   <para>rdfs:comment : Passo dell'iter di attuazione del progetto.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#LotStep">ispra:LotStep</a>
    /// </summary>
    let LotStep = _prefixId.prefix "LotStep"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Indicatore marinordfs:label : Marine Indicator</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#MarineIndicator">ispra:MarineIndicator</a>
    /// </summary>
    let MarineIndicator = _prefixId.prefix "MarineIndicator"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Stazione di Misurardfs:label : Measure Station</para>
    ///   <para>rdfs:comment : Insieme di strumenti di misura che permettono il monitoraggio in un dato luogo, per un determinato tempo, relativamente ai suoi parametri fondamentali.rdfs:comment : Facility with instruments and equipment for monitoring in a given place, for a determined period, relatively to its foundamental parameters.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#MeasureStation">ispra:MeasureStation</a>
    /// </summary>
    let MeasureStation = _prefixId.prefix "MeasureStation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Set di Misurerdfs:label : Measurement Collection</para>
    ///   <para>rdfs:comment : Costituisce l'insieme di misure e metadati in un determinato periodo inerenti una grandezza osservata (es. Wind, Wave) in un dato luogo.rdfs:comment : Set of measures and metadata in a specified period regarding an observed parameter (eg. Wind, Wave) in a given place</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#MeasurementCollection">ispra:MeasurementCollection</a>
    /// </summary>
    let MeasurementCollection = _prefixId.prefix "MeasurementCollection"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Modellordfs:label : Model</para>
    ///   <para>rdfs:comment : Tipologia di stazione di misura (ispra-core:MeasureStation) in funzione delle sua caratteristiche principali (grandezza, costruzione, ecc.)rdfs:comment : Type of measuring station (ispra-core: Measure Station) including a set of its main characteristics (size, construction, etc.)</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#Model">ispra:Model</a>
    /// </summary>
    let Model = _prefixId.prefix "Model"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Sonda Multiparametricardfs:label : Multi Parameter Probe</para>
    ///   <para>rdfs:comment : Strumentordfs:comment : Instrument</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#MultiParameterProbe">ispra:MultiParameterProbe</a>
    /// </summary>
    let MultiParameterProbe = _prefixId.prefix "MultiParameterProbe"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : PHrdfs:label : PH</para>
    ///   <para>rdfs:comment : Parametro di Qualitàrdfs:comment : Quality Parameter</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#PH">ispra:PH</a>
    /// </summary>
    let PH = _prefixId.prefix "PH"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Parametrordfs:label : Parameter</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#Parameter">ispra:Parameter</a>
    /// </summary>
    let Parameter = _prefixId.prefix "Parameter"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Luogordfs:label : Place</para>
    ///   <para>rdfs:comment : TBCrdfs:comment : TBC</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#Place">ispra:Place</a>
    /// </summary>
    let Place = _prefixId.prefix "Place"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Redoxrdfs:label : Redox</para>
    ///   <para>rdfs:comment : Parametro di Qualitàrdfs:comment : Quality Parameter</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#Redox">ispra:Redox</a>
    /// </summary>
    let Redox = _prefixId.prefix "Redox"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Umidità relativardfs:label : Relative Humidity</para>
    ///   <para>rdfs:comment : Parametro Meteorologicordfs:comment : Meteorological Parameter</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#RelativeHumidity">ispra:RelativeHumidity</a>
    /// </summary>
    let RelativeHumidity = _prefixId.prefix "RelativeHumidity"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Operardfs:label : Repair</para>
    ///   <para>rdfs:comment : Type of protection works.rdfs:comment : Tipologia di opere definite nel progetto .</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#Repair">ispra:Repair</a>
    /// </summary>
    let Repair = _prefixId.prefix "Repair"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Indicatore di uso del suolordfs:label : Use soil Indicator</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#SoilUseIndicator">ispra:SoilUseIndicator</a>
    /// </summary>
    let SoilUseIndicator = _prefixId.prefix "SoilUseIndicator"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Temperatura Superficiale dell'acquardfs:label : Sea Surface Temperature</para>
    ///   <para>rdfs:comment : Parametro Oceanograficordfs:comment : Oceanographic Parameter</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#Sst">ispra:Sst</a>
    /// </summary>
    let Sst = _prefixId.prefix "Sst"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Termometrordfs:label : Termometer</para>
    ///   <para>rdfs:comment : Strumentordfs:comment : Instrument</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#Termometer">ispra:Termometer</a>
    /// </summary>
    let Termometer = _prefixId.prefix "Termometer"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Temperatura dell'acquardfs:label : Water Temperature</para>
    ///   <para>rdfs:comment : Parametro Oceanograficordfs:comment : Oceanographic Parameter</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#WaterTemperature">ispra:WaterTemperature</a>
    /// </summary>
    let WaterTemperature = _prefixId.prefix "WaterTemperature"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Ondardfs:label : Wave</para>
    ///   <para>rdfs:comment : Parametro Oceanograficordfs:comment : Oceanographic Parameter</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#Wave">ispra:Wave</a>
    /// </summary>
    let Wave = _prefixId.prefix "Wave"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Ventordfs:label : Wind</para>
    ///   <para>rdfs:comment : Parametro Meteorologicordfs:comment : Meteorological Parameter</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#Wind">ispra:Wind</a>
    /// </summary>
    let Wind = _prefixId.prefix "Wind"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Importo finanziatordfs:label : Amount financed</para>
    ///   <para>rdfs:comment : Importo finanziato (in euro)rdfs:comment : Amount financed (in Euros)</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#amountFinanced">ispra:amountFinanced</a>
    /// </summary>
    let amountFinanced = _prefixId.prefix "amountFinanced"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Restituzionerdfs:label : Averaging Period</para>
    ///   <para>rdfs:comment : Frequenza di restituzione del dato (in Minuti o Ore)rdfs:comment : Frequency of final outputs (in Minutes or Hours)</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#averagingPeriod">ispra:averagingPeriod</a>
    /// </summary>
    let averagingPeriod = _prefixId.prefix "averagingPeriod"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Appartiene ardfs:label : Belongs to</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#belongsTo">ispra:belongsTo</a>
    /// </summary>
    let belongsTo = _prefixId.prefix "belongsTo"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Validazionerdfs:label : Certainty</para>
    ///   <para>rdfs:comment : Livello di validazione del dato. Vengono definiti su scala numerica a partire da 0 (dati grezzi). Es. L0, L1, L2, ecc.rdfs:comment : Certainty level of the observed data. It is defined as numerical scale starting from 0 (raw data). Eg L0, L1, L2, etc.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#certainty">ispra:certainty</a>
    /// </summary>
    let certainty = _prefixId.prefix "certainty"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Codicerdfs:label : Code</para>
    ///   <para>rdfs:comment : Codice identificativo della stazione individuato da organismi nazionali o internazionali.rdfs:comment : ID code of the measurement station as assigned by national or international organizations.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#code">ispra:code</a>
    /// </summary>
    let code = _prefixId.prefix "code"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Ente legato all'interventordfs:label : Contracting authority</para>
    ///   <para>rdfs:comment : Questa proprietà associa il contratto con un'entità generica coinvolta (con un ruolo definito) nel contratto stesso.rdfs:comment : This property connects class contract with a generic entity involved, with specific role, in the contract.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#contractingAuthority">ispra:contractingAuthority</a>
    /// </summary>
    let contractingAuthority = _prefixId.prefix "contractingAuthority"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Codice Unico di Progettordfs:label : Project Unit Code</para>
    ///   <para>rdfs:comment : E' costituito da una stringa alfanumerica di 15 caratteri, che accompagna ciascun progetto di investimento pubblico a partire dalla fase formale di assegnazione delle risorse.rdfs:comment : It consists of a string of 15 alphanumeric characters, which accompanies each contract from the stage of formal resource allocation.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#cup">ispra:cup</a>
    /// </summary>
    let cup = _prefixId.prefix "cup"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Diametrordfs:label : Diameter</para>
    ///   <para>rdfs:comment : Diametro della stazione di misura.rdfs:comment : Diameter of the measure station.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#diameter">ispra:diameter</a>
    /// </summary>
    let diameter = _prefixId.prefix "diameter"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Risoluzione direzionalerdfs:label : Directional resolution</para>
    ///   <para>rdfs:comment : Range di osservazione dei parametri direzionali in gradi Nord ("Omi-directional" se pari a 360ÃÂ°N).rdfs:comment : Directional resolution in degrees North (Omni-directional if 360ÃÂ°N).</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#directionalResolution">ispra:directionalResolution</a>
    /// </summary>
    let directionalResolution = _prefixId.prefix "directionalResolution"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Entitàrdfs:label : Entity</para>
    ///   <para>rdfs:comment : Questa proprietà associa la classe AuthorityKind con l'entità.rdfs:comment : This property connects class AuthorityKind with the entity.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#entity">ispra:entity</a>
    /// </summary>
    let entity = _prefixId.prefix "entity"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Generato dardfs:label : Generated by</para>
    ///   <para>rdfs:comment : Individua lo strumento che ha generato la misura.rdfs:comment : Instruments that generate the measure.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#generatedBy">ispra:generatedBy</a>
    /// </summary>
    let generatedBy = _prefixId.prefix "generatedBy"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Has agreementrdfs:label : Ha un accordo quadro</para>
    ///   <para>rdfs:comment : Proprietà che collega il contratto con il decreto di attuazione.rdfs:comment : This property connects the contract with its framework agreement.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#hasAgreement">ispra:hasAgreement</a>
    /// </summary>
    let hasAgreement = _prefixId.prefix "hasAgreement"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Ha indicatori economicirdfs:label : Has economic indicator</para>
    ///   <para>rdfs:comment : Questa proprietà collega il contratto agli indicatori economici.rdfs:comment : This property connects the Contract to its Economic Indicator</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#hasEconomicIndicator">ispra:hasEconomicIndicator</a>
    /// </summary>
    let hasEconomicIndicator = _prefixId.prefix "hasEconomicIndicator"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Ha iterrdfs:label : Has iter</para>
    ///   <para>rdfs:comment : Questa proprietà collega il Contratto con il suo iter burocratico.rdfs:comment : This property connects the class Contract with its formal procedural steps.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#hasIter">ispra:hasIter</a>
    /// </summary>
    let hasIter = _prefixId.prefix "hasIter"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Ha modello di stazione di misurardfs:label : Has measure station model</para>
    ///   <para>rdfs:comment : Questa proprietà collega la Stazione di misura al suo modello.rdfs:comment : This property connects the Measure Station with its model.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#hasModel">ispra:hasModel</a>
    /// </summary>
    let hasModel = _prefixId.prefix "hasModel"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Ha passo di iterrdfs:label : Has step</para>
    ///   <para>rdfs:comment : Questa proprietà collega il concetto di Iter con i passi relativirdfs:comment : This property connects the Concept of the formal procedure with its relative steps.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#hasStep">ispra:hasStep</a>
    /// </summary>
    let hasStep = _prefixId.prefix "hasStep"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Scafordfs:label : Hull Type</para>
    ///   <para>rdfs:comment : Tipologia dello scafo  della stazione di misura.rdfs:comment : Hull type of the measure station.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#hullType">ispra:hullType</a>
    /// </summary>
    let hullType = _prefixId.prefix "hullType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Raggruppamento di dissestordfs:label : Instability group</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#instabilityGroup">ispra:instabilityGroup</a>
    /// </summary>
    let instabilityGroup = _prefixId.prefix "instabilityGroup"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Dissesto relativo ardfs:label : Instability related to</para>
    ///   <para>rdfs:comment : Questa proprietà collega la classe Dissesto al contratto di finanziamento relativo.rdfs:comment : This property connects the class Instability to the contract.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#instabilityRelatedTo">ispra:instabilityRelatedTo</a>
    /// </summary>
    let instabilityRelatedTo = _prefixId.prefix "instabilityRelatedTo"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Tipo di dissestordfs:label : Instability type</para>
    ///   <para>rdfs:comment : Questa proprietà collega la classe Dissesto ad un concetto più specifico di dissesto.rdfs:comment : This property connects the class Instability to the more specific Concept of instability.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#instabilityType">ispra:instabilityType</a>
    /// </summary>
    let instabilityType = _prefixId.prefix "instabilityType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Grandezza osservatardfs:label : Observed Parameter</para>
    ///   <para>rdfs:comment : Associa i dati misurati in un determinato periodo a una grandezza (es. Wind, Wave) osservata in un determinato luogo.rdfs:comment : This property connects the measured data in a given period with an observed parameter (eg. Wind, Wave) in a given place.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#isDataOf">ispra:isDataOf</a>
    /// </summary>
    let isDataOf = _prefixId.prefix "isDataOf"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : E' autorità di distrettordfs:label : Is district authority</para>
    ///   <para>rdfs:comment : Booleano che indica se l'autorità svolge anche il ruolo di autorità di distretto.rdfs:comment : Boolean property that states if the authority act as district authority.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#isDistrictAuthority">ispra:isDistrictAuthority</a>
    /// </summary>
    let isDistrictAuthority = _prefixId.prefix "isDistrictAuthority"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : E' lotto dirdfs:label : Is lot of</para>
    ///   <para>rdfs:comment : Questa proprietà collega i lotti al contratto.rdfs:comment : This property connects the Lot to the Contract.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#isLotOf">ispra:isLotOf</a>
    /// </summary>
    let isLotOf = _prefixId.prefix "isLotOf"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : E' strumento primariordfs:label : Is primary instruments</para>
    ///   <para>rdfs:comment : Proprietà booleana che individua lo strumento primario (TRUE) che restituisce la misura e gli eventuali strumenti secondari (FALSE) utilizzati in caso di malfunzionamenti o per backup e validazione.rdfs:comment : Boolean value identifing the primary measuring instrument (TRUE) and any secondary instruments (FALSE) used in case of malfunctions or for backup and validation.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#isPrimary">ispra:isPrimary</a>
    /// </summary>
    let isPrimary = _prefixId.prefix "isPrimary"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Passi dell'iterrdfs:label : Iter step type</para>
    ///   <para>rdfs:comment : Elenco dei passi dell'iter previsti per l'attuazione dell'intervento.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#iterStepType">ispra:iterStepType</a>
    /// </summary>
    let iterStepType = _prefixId.prefix "iterStepType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Livellazionerdfs:label : Levelling</para>
    ///   <para>rdfs:comment : Tipologia di operazioni di livellazione utilizzati per la definizione del livello di riferimento.rdfs:comment : Levelling activity useful to the definition of the referring level.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#levelling">ispra:levelling</a>
    /// </summary>
    let levelling = _prefixId.prefix "levelling"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Anno di livellazionerdfs:label : Levelling Time</para>
    ///   <para>rdfs:comment : Anno in cui è stata effettuata l'operazione di livellazione.rdfs:comment : Time (Year) of the levelling activities.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#levellingTime">ispra:levellingTime</a>
    /// </summary>
    let levellingTime = _prefixId.prefix "levellingTime"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Litologia collegata ardfs:label : Lithology related to</para>
    ///   <para>rdfs:comment : Questa proprietà collega la litologia al contratto.rdfs:comment : This property connects the Lithology to the Contract.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#lithologyRelatedTo">ispra:lithologyRelatedTo</a>
    /// </summary>
    let lithologyRelatedTo = _prefixId.prefix "lithologyRelatedTo"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Tipo di litologiardfs:label : Lithology type</para>
    ///   <para>rdfs:comment : Questa proprietà collega la litologia allo specifico concetto.rdfs:comment : This property connects the Lithology to the specific concept.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#lithologyType">ispra:lithologyType</a>
    /// </summary>
    let lithologyType = _prefixId.prefix "lithologyType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Localizzazionerdfs:label : Location</para>
    ///   <para>rdfs:comment : Localizzazione della stazione di misura (nel caso di mareografi è da intendersi in relazione allo spazio di mare antistante).rdfs:comment : Place in which the station is installed (in the case of tide gauges this place is related to the sea area in front of the station).</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#location">ispra:location</a>
    /// </summary>
    let location = _prefixId.prefix "location"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Lottordfs:label : Lot</para>
    ///   <para>rdfs:comment : Questa proprietà collega i singoli passi del contratto al lotto relativo.rdfs:comment : This property connects the class Lot Step to the contract.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#lot">ispra:lot</a>
    /// </summary>
    let lot = _prefixId.prefix "lot"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Produttorerdfs:label : Manufacturer</para>
    ///   <para>rdfs:comment : Produttore e modello della stazione di misura.rdfs:comment : Manufacter and model of the measure station.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#manufacturer">ispra:manufacturer</a>
    /// </summary>
    let manufacturer = _prefixId.prefix "manufacturer"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Misurato dardfs:label : Measured by</para>
    ///   <para>rdfs:comment : Individua lo strumento presente nella stazione di misura in un determinato luogo che è in grado di misurare una grandezza (es. Wind, Wave) .rdfs:comment : It identifies the instrument located in a station in a given place that measures a parameter (eg. Wind, Wave).</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#measuredBy">ispra:measuredBy</a>
    /// </summary>
    let measuredBy = _prefixId.prefix "measuredBy"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Altezza di misurazionerdfs:label : Measurement Height</para>
    ///   <para>rdfs:comment : Altezza dello strumento rispetto al livello di riferimento.rdfs:comment : Instrument height above the reference level.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#measurementHeight">ispra:measurementHeight</a>
    /// </summary>
    let measurementHeight = _prefixId.prefix "measurementHeight"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Periodo di misurazionerdfs:label : Measurement Period</para>
    ///   <para>rdfs:comment : Intervallo di tempo associato alla misura (Mese-Anno).rdfs:comment : Measurement Period related to the measure (Month-Year).</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#measurementPeriod">ispra:measurementPeriod</a>
    /// </summary>
    let measurementPeriod = _prefixId.prefix "measurementPeriod"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Misurardfs:label : Measures</para>
    ///   <para>rdfs:comment : Proprietà che collega la stazione di misura con la grandezza  (es. Wind, Wave) osservata in un determinato luogo.rdfs:comment : It connects the measure station with the observed parameter (eg. Wind, Wave) in a given place.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#measures">ispra:measures</a>
    /// </summary>
    let measures = _prefixId.prefix "measures"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Ormeggiordfs:label : Mooring Type</para>
    ///   <para>rdfs:comment : Tipologia di ormeggio della stazione di misura.rdfs:comment : Mooring type of the measure station.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#mooringType">ispra:mooringType</a>
    /// </summary>
    let mooringType = _prefixId.prefix "mooringType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Dissesto indicato nel decretordfs:label : Official instability type</para>
    ///   <para>rdfs:comment : Tipologia di dissesto indicata nel decreto di finanziamento.rdfs:comment : Type of instability declared in the decree</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#officialInstabilityType">ispra:officialInstabilityType</a>
    /// </summary>
    let officialInstabilityType = _prefixId.prefix "officialInstabilityType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Stato Operativordfs:label : Operational Status</para>
    ///   <para>rdfs:comment : Indica lo stato operativo della stazione di misura (es. Operational, Ceased, ecc.).rdfs:comment : It indicates the operational status of the measure station (Operational, Ceased, etc.).</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#operationalStatus">ispra:operationalStatus</a>
    /// </summary>
    let operationalStatus = _prefixId.prefix "operationalStatus"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Parametri riportatirdfs:label : Parameters reported</para>
    ///   <para>rdfs:comment : Insieme di grandezze osservate dallo strumento.rdfs:comment : Set of parameters measured by the instrument.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#parameterReported">ispra:parameterReported</a>
    /// </summary>
    let parameterReported = _prefixId.prefix "parameterReported"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Faserdfs:label : Phase</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#phase">ispra:phase</a>
    /// </summary>
    let phase = _prefixId.prefix "phase"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Situato in rdfs:label : Placed on</para>
    ///   <para>rdfs:comment : Stazione di misura in cui è presente lo strumentordfs:comment : Measure station that includes the instrument.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#placedOn">ispra:placedOn</a>
    /// </summary>
    let placedOn = _prefixId.prefix "placedOn"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Georeferenziazionerdfs:label : Positioning System</para>
    ///   <para>rdfs:comment : Positioning System installed on the measure station.rdfs:comment : Sistemi di georeferenziazione presenti nella stazione di misura.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#positioningSystem">ispra:positioningSystem</a>
    /// </summary>
    let positioningSystem = _prefixId.prefix "positioningSystem"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Luogo primariordfs:label : Primary geographical feature</para>
    ///   <para>rdfs:comment : Luogo primario legato ad un intervento di dissesto.rdfs:comment : Primary geographical feature of a Contract</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#primaryGeographicalFeature">ispra:primaryGeographicalFeature</a>
    /// </summary>
    let primaryGeographicalFeature = _prefixId.prefix "primaryGeographicalFeature"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Categoria di operardfs:label : Repair category</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#repairCategory">ispra:repairCategory</a>
    /// </summary>
    let repairCategory = _prefixId.prefix "repairCategory"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Gruppo di operardfs:label : Repair group</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#repairGroup">ispra:repairGroup</a>
    /// </summary>
    let repairGroup = _prefixId.prefix "repairGroup"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Opera collegata ardfs:label : Repair related to</para>
    ///   <para>rdfs:comment : Questa proprietà collega l'opera al contratto.rdfs:comment : This property connects the Repair to the Contract.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#repairRelatedTo">ispra:repairRelatedTo</a>
    /// </summary>
    let repairRelatedTo = _prefixId.prefix "repairRelatedTo"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Tipologia di operardfs:label : Repair type</para>
    ///   <para>rdfs:comment : Questa proprietà collega l'opera al concetto del vocabolario controllato.rdfs:comment : This property connects the Repair to a concept of a specific vocabulary.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#repairType">ispra:repairType</a>
    /// </summary>
    let repairType = _prefixId.prefix "repairType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Ruolordfs:label : Role</para>
    ///   <para>rdfs:comment : Ruolo dell'ente nella classe Authority kindrdfs:comment : The role of Entity in Authority kind class.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#role">ispra:role</a>
    /// </summary>
    let role = _prefixId.prefix "role"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Luogo secondariordfs:label : Secondary geographical feature</para>
    ///   <para>rdfs:comment : Luogo secondario legato ad un intervento di dissesto.rdfs:comment : Secondary geographical feature of a Contract</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#secondaryGeographicalFeature">ispra:secondaryGeographicalFeature</a>
    /// </summary>
    let secondaryGeographicalFeature = _prefixId.prefix "secondaryGeographicalFeature"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Modello del sensorerdfs:label : Sensor Model</para>
    ///   <para>rdfs:comment : Sensor/Instrument Model.rdfs:comment : Modello del sensore/strumento.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#sensorModel">ispra:sensorModel</a>
    /// </summary>
    let sensorModel = _prefixId.prefix "sensorModel"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Frequenza di campionamentordfs:label : Sensor Sampling Frequency</para>
    ///   <para>rdfs:comment : Frequenza di campionamento dello strumento (in hertz).rdfs:comment : Observation sampling of the instrumen (in hertz).</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#sensorSamplingFrequency">ispra:sensorSamplingFrequency</a>
    /// </summary>
    let sensorSamplingFrequency = _prefixId.prefix "sensorSamplingFrequency"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Strutturardfs:label : Structure</para>
    ///   <para>rdfs:comment : Material or building type of the measure station.rdfs:comment : Materiale o tipologia costruttiva della stazione di misura.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#structure">ispra:structure</a>
    /// </summary>
    let structure = _prefixId.prefix "structure"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Tipo di stazione di misurardfs:label : Type of Data Station</para>
    ///   <para>rdfs:comment : Tipologia di stazione di misura.rdfs:comment : Type of Data Station.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#typeOfDataStation">ispra:typeOfDataStation</a>
    /// </summary>
    let typeOfDataStation = _prefixId.prefix "typeOfDataStation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Output di Altezza d'ondardfs:label : Wave Height Reported</para>
    ///   <para>rdfs:comment : Parametri di altezza d'onda restituiti dallo strumento.rdfs:comment : Wave height parameters reported by the instrument.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#waveHeightReported">ispra:waveHeightReported</a>
    /// </summary>
    let waveHeightReported = _prefixId.prefix "waveHeightReported"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Output di Periodo dell'ondardfs:label : Wave Period Reported</para>
    ///   <para>rdfs:comment : Parametri di periodo dell'onda restituiti dallo strumento.rdfs:comment : Wave period parameters reported by the instrument.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#wavePeriodReported">ispra:wavePeriodReported</a>
    /// </summary>
    let wavePeriodReported = _prefixId.prefix "wavePeriodReported"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Wmo Sensor Coderdfs:label : Wmo Sensor Code</para>
    ///   <para>rdfs:comment : Associa lo strumento al relativo concept definito da WMO.rdfs:comment : It connects the intrument with the analogous concept as defined by WMO.</para>
    ///   <a href="http://dati.isprambiente.it/ontology/core#wmoSensorCode">ispra:wmoSensorCode</a>
    /// </summary>
    let wmoSensorCode = _prefixId.prefix "wmoSensorCode"
