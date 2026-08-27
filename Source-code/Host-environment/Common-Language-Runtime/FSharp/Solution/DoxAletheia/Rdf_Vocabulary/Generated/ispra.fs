namespace http.dati.isprambiente.it.ontology.core.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ispra =
    let _namespace_iri = Namespace_Iri ispra |> NamespaceIRI
    /// <summary>
    ///   <para>ispra:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Ispra Ontology"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#">http://dati.isprambiente.it/ontology/core#</seealso>
    let _prefix_iri = Prefixed_Name(ispra, "") |> PrefixedName
    /// <summary>
    ///   <para>ispra:Accelerometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Strumento"</para>
    ///   <para>"Instrument"</para>
    /// labels<para>"Accelerometer"</para><para>"Accelerometro"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#Accelerometer">http://dati.isprambiente.it/ontology/core#Accelerometer</seealso>
    let Accelerometer = Prefixed_Name(ispra, "Accelerometer") |> PrefixedName
    /// <summary>
    ///   <para>ispra:AirPres</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Parametro Meteorologico"</para>
    ///   <para>"Meteorological Parameter"</para>
    /// labels<para>"Atmospheric Pressure"</para><para>"Pressione atmosferica"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#AirPres">http://dati.isprambiente.it/ontology/core#AirPres</seealso>
    let AirPres = Prefixed_Name(ispra, "AirPres") |> PrefixedName
    /// <summary>
    ///   <para>ispra:AirTemp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Parametro Meteorologico"</para>
    ///   <para>"Meteorological Parameter"</para>
    /// labels<para>"Air Temperature"</para><para>"Temperatura dell'aria"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#AirTemp">http://dati.isprambiente.it/ontology/core#AirTemp</seealso>
    let AirTemp = Prefixed_Name(ispra, "AirTemp") |> PrefixedName
    /// <summary>
    ///   <para>ispra:Anemometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Instrument"</para>
    ///   <para>"Strumento"</para>
    /// labels<para>"Anemometer"</para><para>"Anemometro"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#Anemometer">http://dati.isprambiente.it/ontology/core#Anemometer</seealso>
    let Anemometer = Prefixed_Name(ispra, "Anemometer") |> PrefixedName
    /// <summary>
    ///   <para>ispra:AuthorityKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Involved authorities and role played."</para>
    ///   <para>"Ente coinvolto e funzione svolta."</para>
    /// labels<para>"Authority kind"</para><para>"Autorità"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#AuthorityKind">http://dati.isprambiente.it/ontology/core#AuthorityKind</seealso>
    let AuthorityKind = Prefixed_Name(ispra, "AuthorityKind") |> PrefixedName
    /// <summary>
    ///   <para>ispra:Barometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Instrument"</para>
    ///   <para>"Strumento"</para>
    /// labels<para>"Barometer"</para><para>"Barometro"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#Barometer">http://dati.isprambiente.it/ontology/core#Barometer</seealso>
    let Barometer = Prefixed_Name(ispra, "Barometer") |> PrefixedName
    /// <summary>
    ///   <para>ispra:Conductivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Parametro  di Qualità"</para>
    ///   <para>"Quality Parameter"</para>
    /// labels<para>"Conductivity"</para><para>"Conducibilità"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#Conductivity">http://dati.isprambiente.it/ontology/core#Conductivity</seealso>
    let Conductivity = Prefixed_Name(ispra, "Conductivity") |> PrefixedName
    /// <summary>
    ///   <para>ispra:Contract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Lotto"</para><para>"Contract"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#Contract">http://dati.isprambiente.it/ontology/core#Contract</seealso>
    let Contract = Prefixed_Name(ispra, "Contract") |> PrefixedName
    /// <summary>
    ///   <para>ispra:EconomicIndicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Parameter of the project economic framework."</para>
    ///   <para>"Parametro del quadro economico del lotto."</para>
    /// labels<para>"Indicatore economico"</para><para>"Economic Indicator"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#EconomicIndicator">http://dati.isprambiente.it/ontology/core#EconomicIndicator</seealso>
    let EconomicIndicator = Prefixed_Name(ispra, "EconomicIndicator") |> PrefixedName
    /// <summary>
    ///   <para>ispra:GeoFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Geographical feature"</para><para>"Elemento geografico"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#GeoFeature">http://dati.isprambiente.it/ontology/core#GeoFeature</seealso>
    let GeoFeature = Prefixed_Name(ispra, "GeoFeature") |> PrefixedName
    /// <summary>
    ///   <para>ispra:Hydrometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Strumento"</para>
    ///   <para>"Instrument"</para>
    /// labels<para>"Hydrometer"</para><para>"Idrometro"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#Hydrometer">http://dati.isprambiente.it/ontology/core#Hydrometer</seealso>
    let Hydrometer = Prefixed_Name(ispra, "Hydrometer") |> PrefixedName
    /// <summary>
    ///   <para>ispra:HydrometricLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Oceanographic Parameter"</para>
    ///   <para>"Parametro Oceanografico"</para>
    /// labels<para>"Livello idrometrico"</para><para>"Hydrometric Level"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#HydrometricLevel">http://dati.isprambiente.it/ontology/core#HydrometricLevel</seealso>
    let HydrometricLevel = Prefixed_Name(ispra, "HydrometricLevel") |> PrefixedName
    /// <summary>
    ///   <para>ispra:Hygrometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Strumento"</para>
    ///   <para>"Instrument"</para>
    /// labels<para>"Igrometro"</para><para>"Hygrometer"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#Hygrometer">http://dati.isprambiente.it/ontology/core#Hygrometer</seealso>
    let Hygrometer = Prefixed_Name(ispra, "Hygrometer") |> PrefixedName
    /// <summary>
    ///   <para>ispra:Indicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Indicator"</para><para>"Indicatore"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#Indicator">http://dati.isprambiente.it/ontology/core#Indicator</seealso>
    let Indicator = Prefixed_Name(ispra, "Indicator") |> PrefixedName

    /// <summary>
    ///   <para>ispra:IndicatorCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Indicator Collection"</para><para>"Collezione di indicatori"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#IndicatorCollection">http://dati.isprambiente.it/ontology/core#IndicatorCollection</seealso>
    let IndicatorCollection =
        Prefixed_Name(ispra, "IndicatorCollection") |> PrefixedName

    /// <summary>
    ///   <para>ispra:Instability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Type of instability phenomenon shown in the drawings or observed by site visit."</para>
    ///   <para>"Tipologia di dissesto indicata in progetto o rilevata in sito."</para>
    /// labels<para>"Dissesto"</para><para>"Instability"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#Instability">http://dati.isprambiente.it/ontology/core#Instability</seealso>
    let Instability = Prefixed_Name(ispra, "Instability") |> PrefixedName
    /// <summary>
    ///   <para>ispra:Instrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Instrument"</para><para>"Strumento"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#Instrument">http://dati.isprambiente.it/ontology/core#Instrument</seealso>
    let Instrument = Prefixed_Name(ispra, "Instrument") |> PrefixedName
    /// <summary>
    ///   <para>ispra:Intervention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Intervento per la mitigazione del rischio idrogeologico a cui è assegnato uno specifico finanziamento. Può essere costituito da uno più lotti."</para>
    ///   <para>"A single action, funded under a plan for hydrogeological risk mitigation. It may consist of one or more related projects."</para>
    /// labels<para>"Action"</para><para>"Intervento"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#Intervention">http://dati.isprambiente.it/ontology/core#Intervention</seealso>
    let Intervention = Prefixed_Name(ispra, "Intervention") |> PrefixedName
    /// <summary>
    ///   <para>ispra:Lithology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Tipi litologici indicati in progetto."</para>
    ///   <para>"Lithology as stated in the project."</para>
    /// labels<para>"Lithology"</para><para>"Litologia"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#Lithology">http://dati.isprambiente.it/ontology/core#Lithology</seealso>
    let Lithology = Prefixed_Name(ispra, "Lithology") |> PrefixedName
    /// <summary>
    ///   <para>ispra:LotStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Passo dell'iter di attuazione del progetto."</para>
    /// labels<para>"Lot step"</para><para>"Passi del lotto"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#LotStep">http://dati.isprambiente.it/ontology/core#LotStep</seealso>
    let LotStep = Prefixed_Name(ispra, "LotStep") |> PrefixedName
    /// <summary>
    ///   <para>ispra:MarineIndicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Indicatore marino"</para><para>"Marine Indicator"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#MarineIndicator">http://dati.isprambiente.it/ontology/core#MarineIndicator</seealso>
    let MarineIndicator = Prefixed_Name(ispra, "MarineIndicator") |> PrefixedName
    /// <summary>
    ///   <para>ispra:MeasureStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Insieme di strumenti di misura che permettono il monitoraggio in un dato luogo, per un determinato tempo, relativamente ai suoi parametri fondamentali."</para>
    ///   <para>"Facility with instruments and equipment for monitoring in a given place, for a determined period, relatively to its foundamental parameters."</para>
    /// labels<para>"Measure Station"</para><para>"Stazione di Misura"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#MeasureStation">http://dati.isprambiente.it/ontology/core#MeasureStation</seealso>
    let MeasureStation = Prefixed_Name(ispra, "MeasureStation") |> PrefixedName

    /// <summary>
    ///   <para>ispra:MeasurementCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Costituisce l'insieme di misure e metadati in un determinato periodo inerenti una grandezza osservata (es. Wind, Wave) in un dato luogo."</para>
    ///   <para>"Set of measures and metadata in a specified period regarding an observed parameter (eg. Wind, Wave) in a given place"</para>
    /// labels<para>"Set di Misure"</para><para>"Measurement Collection"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#MeasurementCollection">http://dati.isprambiente.it/ontology/core#MeasurementCollection</seealso>
    let MeasurementCollection =
        Prefixed_Name(ispra, "MeasurementCollection") |> PrefixedName

    /// <summary>
    ///   <para>ispra:Model</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Type of measuring station (ispra-core: Measure Station) including a set of its main characteristics (size, construction, etc.)"</para>
    ///   <para>"Tipologia di stazione di misura (ispra-core:MeasureStation) in funzione delle sua caratteristiche principali (grandezza, costruzione, ecc.)"</para>
    /// labels<para>"Modello"</para><para>"Model"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#Model">http://dati.isprambiente.it/ontology/core#Model</seealso>
    let Model = Prefixed_Name(ispra, "Model") |> PrefixedName

    /// <summary>
    ///   <para>ispra:MultiParameterProbe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Strumento"</para>
    ///   <para>"Instrument"</para>
    /// labels<para>"Sonda Multiparametrica"</para><para>"Multi Parameter Probe"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#MultiParameterProbe">http://dati.isprambiente.it/ontology/core#MultiParameterProbe</seealso>
    let MultiParameterProbe =
        Prefixed_Name(ispra, "MultiParameterProbe") |> PrefixedName

    /// <summary>
    ///   <para>ispra:PH</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Parametro di Qualità"</para>
    ///   <para>"Quality Parameter"</para>
    /// labels<para>"PH"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#PH">http://dati.isprambiente.it/ontology/core#PH</seealso>
    let PH = Prefixed_Name(ispra, "PH") |> PrefixedName
    /// <summary>
    ///   <para>ispra:Parameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Parameter"</para><para>"Parametro"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#Parameter">http://dati.isprambiente.it/ontology/core#Parameter</seealso>
    let Parameter = Prefixed_Name(ispra, "Parameter") |> PrefixedName
    /// <summary>
    ///   <para>ispra:Place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"TBC"</para>
    /// labels<para>"Place"</para><para>"Luogo"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#Place">http://dati.isprambiente.it/ontology/core#Place</seealso>
    let Place = Prefixed_Name(ispra, "Place") |> PrefixedName
    /// <summary>
    ///   <para>ispra:Redox</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Parametro di Qualità"</para>
    ///   <para>"Quality Parameter"</para>
    /// labels<para>"Redox"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#Redox">http://dati.isprambiente.it/ontology/core#Redox</seealso>
    let Redox = Prefixed_Name(ispra, "Redox") |> PrefixedName
    /// <summary>
    ///   <para>ispra:RelativeHumidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Meteorological Parameter"</para>
    ///   <para>"Parametro Meteorologico"</para>
    /// labels<para>"Umidità relativa"</para><para>"Relative Humidity"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#RelativeHumidity">http://dati.isprambiente.it/ontology/core#RelativeHumidity</seealso>
    let RelativeHumidity = Prefixed_Name(ispra, "RelativeHumidity") |> PrefixedName
    /// <summary>
    ///   <para>ispra:Repair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Type of protection works."</para>
    ///   <para>"Tipologia di opere definite nel progetto ."</para>
    /// labels<para>"Opera"</para><para>"Repair"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#Repair">http://dati.isprambiente.it/ontology/core#Repair</seealso>
    let Repair = Prefixed_Name(ispra, "Repair") |> PrefixedName
    /// <summary>
    ///   <para>ispra:SoilUseIndicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Use soil Indicator"</para><para>"Indicatore di uso del suolo"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#SoilUseIndicator">http://dati.isprambiente.it/ontology/core#SoilUseIndicator</seealso>
    let SoilUseIndicator = Prefixed_Name(ispra, "SoilUseIndicator") |> PrefixedName
    /// <summary>
    ///   <para>ispra:Sst</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Oceanographic Parameter"</para>
    ///   <para>"Parametro Oceanografico"</para>
    /// labels<para>"Sea Surface Temperature"</para><para>"Temperatura Superficiale dell'acqua"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#Sst">http://dati.isprambiente.it/ontology/core#Sst</seealso>
    let Sst = Prefixed_Name(ispra, "Sst") |> PrefixedName
    /// <summary>
    ///   <para>ispra:Termometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Instrument"</para>
    ///   <para>"Strumento"</para>
    /// labels<para>"Termometro"</para><para>"Termometer"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#Termometer">http://dati.isprambiente.it/ontology/core#Termometer</seealso>
    let Termometer = Prefixed_Name(ispra, "Termometer") |> PrefixedName
    /// <summary>
    ///   <para>ispra:WaterTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Parametro Oceanografico"</para>
    ///   <para>"Oceanographic Parameter"</para>
    /// labels<para>"Water Temperature"</para><para>"Temperatura dell'acqua"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#WaterTemperature">http://dati.isprambiente.it/ontology/core#WaterTemperature</seealso>
    let WaterTemperature = Prefixed_Name(ispra, "WaterTemperature") |> PrefixedName
    /// <summary>
    ///   <para>ispra:Wave</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Oceanographic Parameter"</para>
    ///   <para>"Parametro Oceanografico"</para>
    /// labels<para>"Wave"</para><para>"Onda"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#Wave">http://dati.isprambiente.it/ontology/core#Wave</seealso>
    let Wave = Prefixed_Name(ispra, "Wave") |> PrefixedName
    /// <summary>
    ///   <para>ispra:Wind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Parametro Meteorologico"</para>
    ///   <para>"Meteorological Parameter"</para>
    /// labels<para>"Wind"</para><para>"Vento"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#Wind">http://dati.isprambiente.it/ontology/core#Wind</seealso>
    let Wind = Prefixed_Name(ispra, "Wind") |> PrefixedName
    /// <summary>
    ///   <para>ispra:amountFinanced</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Amount financed (in Euros)"</para>
    ///   <para>"Importo finanziato (in euro)"</para>
    /// labels<para>"Amount financed"</para><para>"Importo finanziato"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#amountFinanced">http://dati.isprambiente.it/ontology/core#amountFinanced</seealso>
    let amountFinanced = Prefixed_Name(ispra, "amountFinanced") |> PrefixedName
    /// <summary>
    ///   <para>ispra:averagingPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Frequenza di restituzione del dato (in Minuti o Ore)"</para>
    ///   <para>"Frequency of final outputs (in Minutes or Hours)"</para>
    /// labels<para>"Restituzione"</para><para>"Averaging Period"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#averagingPeriod">http://dati.isprambiente.it/ontology/core#averagingPeriod</seealso>
    let averagingPeriod = Prefixed_Name(ispra, "averagingPeriod") |> PrefixedName
    /// <summary>
    ///   <para>ispra:belongsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"Belongs to"</para><para>"Appartiene a"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#belongsTo">http://dati.isprambiente.it/ontology/core#belongsTo</seealso>
    let belongsTo = Prefixed_Name(ispra, "belongsTo") |> PrefixedName
    /// <summary>
    ///   <para>ispra:certainty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Livello di validazione del dato. Vengono definiti su scala numerica a partire da 0 (dati grezzi). Es. L0, L1, L2, ecc."</para>
    ///   <para>"Certainty level of the observed data. It is defined as numerical scale starting from 0 (raw data). Eg L0, L1, L2, etc."</para>
    /// labels<para>"Validazione"</para><para>"Certainty"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#certainty">http://dati.isprambiente.it/ontology/core#certainty</seealso>
    let certainty = Prefixed_Name(ispra, "certainty") |> PrefixedName
    /// <summary>
    ///   <para>ispra:code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Codice identificativo della stazione individuato da organismi nazionali o internazionali."</para>
    ///   <para>"ID code of the measurement station as assigned by national or international organizations."</para>
    /// labels<para>"Code"</para><para>"Codice"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#code">http://dati.isprambiente.it/ontology/core#code</seealso>
    let code = Prefixed_Name(ispra, "code") |> PrefixedName

    /// <summary>
    ///   <para>ispra:contractingAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà associa il contratto con un'entità generica coinvolta (con un ruolo definito) nel contratto stesso."</para>
    ///   <para>"This property connects class contract with a generic entity involved, with specific role, in the contract."</para>
    /// labels<para>"Contracting authority"</para><para>"Ente legato all'intervento"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#contractingAuthority">http://dati.isprambiente.it/ontology/core#contractingAuthority</seealso>
    let contractingAuthority =
        Prefixed_Name(ispra, "contractingAuthority") |> PrefixedName

    /// <summary>
    ///   <para>ispra:cup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"It consists of a string of 15 alphanumeric characters, which accompanies each contract from the stage of formal resource allocation."</para>
    ///   <para>"E' costituito da una stringa alfanumerica di 15 caratteri, che accompagna ciascun progetto di investimento pubblico a partire dalla fase formale di assegnazione delle risorse."</para>
    /// labels<para>"Codice Unico di Progetto"</para><para>"Project Unit Code"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#cup">http://dati.isprambiente.it/ontology/core#cup</seealso>
    let cup = Prefixed_Name(ispra, "cup") |> PrefixedName
    /// <summary>
    ///   <para>ispra:diameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Diameter of the measure station."</para>
    ///   <para>"Diametro della stazione di misura."</para>
    /// labels<para>"Diametro"</para><para>"Diameter"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#diameter">http://dati.isprambiente.it/ontology/core#diameter</seealso>
    let diameter = Prefixed_Name(ispra, "diameter") |> PrefixedName

    /// <summary>
    ///   <para>ispra:directionalResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Range di osservazione dei parametri direzionali in gradi Nord ("Omi-directional" se pari a 360ÃÂ°N)."</para>
    ///   <para>"Directional resolution in degrees North (Omni-directional if 360ÃÂ°N)."</para>
    /// labels<para>"Risoluzione direzionale"</para><para>"Directional resolution"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#directionalResolution">http://dati.isprambiente.it/ontology/core#directionalResolution</seealso>
    let directionalResolution =
        Prefixed_Name(ispra, "directionalResolution") |> PrefixedName

    /// <summary>
    ///   <para>ispra:entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property connects class AuthorityKind with the entity."</para>
    ///   <para>"Questa proprietà associa la classe AuthorityKind con l'entità."</para>
    /// labels<para>"Entity"</para><para>"Entità"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#entity">http://dati.isprambiente.it/ontology/core#entity</seealso>
    let entity = Prefixed_Name(ispra, "entity") |> PrefixedName
    /// <summary>
    ///   <para>ispra:generatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Instruments that generate the measure."</para>
    ///   <para>"Individua lo strumento che ha generato la misura."</para>
    /// labels<para>"Generato da"</para><para>"Generated by"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#generatedBy">http://dati.isprambiente.it/ontology/core#generatedBy</seealso>
    let generatedBy = Prefixed_Name(ispra, "generatedBy") |> PrefixedName
    /// <summary>
    ///   <para>ispra:hasAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property connects the contract with its framework agreement."</para>
    ///   <para>"Proprietà che collega il contratto con il decreto di attuazione."</para>
    /// labels<para>"Has agreement"</para><para>"Ha un accordo quadro"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#hasAgreement">http://dati.isprambiente.it/ontology/core#hasAgreement</seealso>
    let hasAgreement = Prefixed_Name(ispra, "hasAgreement") |> PrefixedName

    /// <summary>
    ///   <para>ispra:hasEconomicIndicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega il contratto agli indicatori economici."</para>
    ///   <para>"This property connects the Contract to its Economic Indicator"</para>
    /// labels<para>"Ha indicatori economici"</para><para>"Has economic indicator"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#hasEconomicIndicator">http://dati.isprambiente.it/ontology/core#hasEconomicIndicator</seealso>
    let hasEconomicIndicator =
        Prefixed_Name(ispra, "hasEconomicIndicator") |> PrefixedName

    /// <summary>
    ///   <para>ispra:hasIter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property connects the class Contract with its formal procedural steps."</para>
    ///   <para>"Questa proprietà collega il Contratto con il suo iter burocratico."</para>
    /// labels<para>"Ha iter"</para><para>"Has iter"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#hasIter">http://dati.isprambiente.it/ontology/core#hasIter</seealso>
    let hasIter = Prefixed_Name(ispra, "hasIter") |> PrefixedName
    /// <summary>
    ///   <para>ispra:hasModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property connects the Measure Station with its model."</para>
    ///   <para>"Questa proprietà collega la Stazione di misura al suo modello."</para>
    /// labels<para>"Ha modello di stazione di misura"</para><para>"Has measure station model"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#hasModel">http://dati.isprambiente.it/ontology/core#hasModel</seealso>
    let hasModel = Prefixed_Name(ispra, "hasModel") |> PrefixedName
    /// <summary>
    ///   <para>ispra:hasStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property connects the Concept of the formal procedure with its relative steps."</para>
    ///   <para>"Questa proprietà collega il concetto di Iter con i passi relativi"</para>
    /// labels<para>"Has step"</para><para>"Ha passo di iter"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#hasStep">http://dati.isprambiente.it/ontology/core#hasStep</seealso>
    let hasStep = Prefixed_Name(ispra, "hasStep") |> PrefixedName
    /// <summary>
    ///   <para>ispra:hullType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Hull type of the measure station."</para>
    ///   <para>"Tipologia dello scafo  della stazione di misura."</para>
    /// labels<para>"Hull Type"</para><para>"Scafo"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#hullType">http://dati.isprambiente.it/ontology/core#hullType</seealso>
    let hullType = Prefixed_Name(ispra, "hullType") |> PrefixedName
    /// <summary>
    ///   <para>ispra:instabilityGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Instability group"</para><para>"Raggruppamento di dissesto"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#instabilityGroup">http://dati.isprambiente.it/ontology/core#instabilityGroup</seealso>
    let instabilityGroup = Prefixed_Name(ispra, "instabilityGroup") |> PrefixedName

    /// <summary>
    ///   <para>ispra:instabilityRelatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega la classe Dissesto al contratto di finanziamento relativo."</para>
    ///   <para>"This property connects the class Instability to the contract."</para>
    /// labels<para>"Instability related to"</para><para>"Dissesto relativo a"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#instabilityRelatedTo">http://dati.isprambiente.it/ontology/core#instabilityRelatedTo</seealso>
    let instabilityRelatedTo =
        Prefixed_Name(ispra, "instabilityRelatedTo") |> PrefixedName

    /// <summary>
    ///   <para>ispra:instabilityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property connects the class Instability to the more specific Concept of instability."</para>
    ///   <para>"Questa proprietà collega la classe Dissesto ad un concetto più specifico di dissesto."</para>
    /// labels<para>"Tipo di dissesto"</para><para>"Instability type"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#instabilityType">http://dati.isprambiente.it/ontology/core#instabilityType</seealso>
    let instabilityType = Prefixed_Name(ispra, "instabilityType") |> PrefixedName
    /// <summary>
    ///   <para>ispra:isDataOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associa i dati misurati in un determinato periodo a una grandezza (es. Wind, Wave) osservata in un determinato luogo."</para>
    ///   <para>"This property connects the measured data in a given period with an observed parameter (eg. Wind, Wave) in a given place."</para>
    /// labels<para>"Observed Parameter"</para><para>"Grandezza osservata"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#isDataOf">http://dati.isprambiente.it/ontology/core#isDataOf</seealso>
    let isDataOf = Prefixed_Name(ispra, "isDataOf") |> PrefixedName

    /// <summary>
    ///   <para>ispra:isDistrictAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Boolean property that states if the authority act as district authority."</para>
    ///   <para>"Booleano che indica se l'autorità svolge anche il ruolo di autorità di distretto."</para>
    /// labels<para>"Is district authority"</para><para>"E' autorità di distretto"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#isDistrictAuthority">http://dati.isprambiente.it/ontology/core#isDistrictAuthority</seealso>
    let isDistrictAuthority =
        Prefixed_Name(ispra, "isDistrictAuthority") |> PrefixedName

    /// <summary>
    ///   <para>ispra:isLotOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega i lotti al contratto."</para>
    ///   <para>"This property connects the Lot to the Contract."</para>
    /// labels<para>"Is lot of"</para><para>"E' lotto di"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#isLotOf">http://dati.isprambiente.it/ontology/core#isLotOf</seealso>
    let isLotOf = Prefixed_Name(ispra, "isLotOf") |> PrefixedName
    /// <summary>
    ///   <para>ispra:isPrimary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Proprietà booleana che individua lo strumento primario (TRUE) che restituisce la misura e gli eventuali strumenti secondari (FALSE) utilizzati in caso di malfunzionamenti o per backup e validazione."</para>
    ///   <para>"Boolean value identifing the primary measuring instrument (TRUE) and any secondary instruments (FALSE) used in case of malfunctions or for backup and validation."</para>
    /// labels<para>"E' strumento primario"</para><para>"Is primary instruments"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#isPrimary">http://dati.isprambiente.it/ontology/core#isPrimary</seealso>
    let isPrimary = Prefixed_Name(ispra, "isPrimary") |> PrefixedName
    /// <summary>
    ///   <para>ispra:iterStepType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Elenco dei passi dell'iter previsti per l'attuazione dell'intervento."</para>
    /// labels<para>"Iter step type"</para><para>"Passi dell'iter"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#iterStepType">http://dati.isprambiente.it/ontology/core#iterStepType</seealso>
    let iterStepType = Prefixed_Name(ispra, "iterStepType") |> PrefixedName
    /// <summary>
    ///   <para>ispra:levelling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tipologia di operazioni di livellazione utilizzati per la definizione del livello di riferimento."</para>
    ///   <para>"Levelling activity useful to the definition of the referring level."</para>
    /// labels<para>"Livellazione"</para><para>"Levelling"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#levelling">http://dati.isprambiente.it/ontology/core#levelling</seealso>
    let levelling = Prefixed_Name(ispra, "levelling") |> PrefixedName
    /// <summary>
    ///   <para>ispra:levellingTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Time (Year) of the levelling activities."</para>
    ///   <para>"Anno in cui è stata effettuata l'operazione di livellazione."</para>
    /// labels<para>"Levelling Time"</para><para>"Anno di livellazione"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#levellingTime">http://dati.isprambiente.it/ontology/core#levellingTime</seealso>
    let levellingTime = Prefixed_Name(ispra, "levellingTime") |> PrefixedName
    /// <summary>
    ///   <para>ispra:lithologyRelatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega la litologia al contratto."</para>
    ///   <para>"This property connects the Lithology to the Contract."</para>
    /// labels<para>"Lithology related to"</para><para>"Litologia collegata a"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#lithologyRelatedTo">http://dati.isprambiente.it/ontology/core#lithologyRelatedTo</seealso>
    let lithologyRelatedTo = Prefixed_Name(ispra, "lithologyRelatedTo") |> PrefixedName
    /// <summary>
    ///   <para>ispra:lithologyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega la litologia allo specifico concetto."</para>
    ///   <para>"This property connects the Lithology to the specific concept."</para>
    /// labels<para>"Lithology type"</para><para>"Tipo di litologia"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#lithologyType">http://dati.isprambiente.it/ontology/core#lithologyType</seealso>
    let lithologyType = Prefixed_Name(ispra, "lithologyType") |> PrefixedName
    /// <summary>
    ///   <para>ispra:location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Place in which the station is installed (in the case of tide gauges this place is related to the sea area in front of the station)."</para>
    ///   <para>"Localizzazione della stazione di misura (nel caso di mareografi è da intendersi in relazione allo spazio di mare antistante)."</para>
    /// labels<para>"Location"</para><para>"Localizzazione"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#location">http://dati.isprambiente.it/ontology/core#location</seealso>
    let location = Prefixed_Name(ispra, "location") |> PrefixedName
    /// <summary>
    ///   <para>ispra:lot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega i singoli passi del contratto al lotto relativo."</para>
    ///   <para>"This property connects the class Lot Step to the contract."</para>
    /// labels<para>"Lot"</para><para>"Lotto"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#lot">http://dati.isprambiente.it/ontology/core#lot</seealso>
    let lot = Prefixed_Name(ispra, "lot") |> PrefixedName
    /// <summary>
    ///   <para>ispra:manufacturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Manufacter and model of the measure station."</para>
    ///   <para>"Produttore e modello della stazione di misura."</para>
    /// labels<para>"Produttore"</para><para>"Manufacturer"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#manufacturer">http://dati.isprambiente.it/ontology/core#manufacturer</seealso>
    let manufacturer = Prefixed_Name(ispra, "manufacturer") |> PrefixedName
    /// <summary>
    ///   <para>ispra:measuredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Individua lo strumento presente nella stazione di misura in un determinato luogo che è in grado di misurare una grandezza (es. Wind, Wave) ."</para>
    ///   <para>"It identifies the instrument located in a station in a given place that measures a parameter (eg. Wind, Wave)."</para>
    /// labels<para>"Misurato da"</para><para>"Measured by"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#measuredBy">http://dati.isprambiente.it/ontology/core#measuredBy</seealso>
    let measuredBy = Prefixed_Name(ispra, "measuredBy") |> PrefixedName
    /// <summary>
    ///   <para>ispra:measurementHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Instrument height above the reference level."</para>
    ///   <para>"Altezza dello strumento rispetto al livello di riferimento."</para>
    /// labels<para>"Measurement Height"</para><para>"Altezza di misurazione"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#measurementHeight">http://dati.isprambiente.it/ontology/core#measurementHeight</seealso>
    let measurementHeight = Prefixed_Name(ispra, "measurementHeight") |> PrefixedName
    /// <summary>
    ///   <para>ispra:measurementPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Measurement Period related to the measure (Month-Year)."</para>
    ///   <para>"Intervallo di tempo associato alla misura (Mese-Anno)."</para>
    /// labels<para>"Periodo di misurazione"</para><para>"Measurement Period"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#measurementPeriod">http://dati.isprambiente.it/ontology/core#measurementPeriod</seealso>
    let measurementPeriod = Prefixed_Name(ispra, "measurementPeriod") |> PrefixedName
    /// <summary>
    ///   <para>ispra:measures</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Proprietà che collega la stazione di misura con la grandezza  (es. Wind, Wave) osservata in un determinato luogo."</para>
    ///   <para>"It connects the measure station with the observed parameter (eg. Wind, Wave) in a given place."</para>
    /// labels<para>"Misura"</para><para>"Measures"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#measures">http://dati.isprambiente.it/ontology/core#measures</seealso>
    let measures = Prefixed_Name(ispra, "measures") |> PrefixedName
    /// <summary>
    ///   <para>ispra:mooringType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tipologia di ormeggio della stazione di misura."</para>
    ///   <para>"Mooring type of the measure station."</para>
    /// labels<para>"Ormeggio"</para><para>"Mooring Type"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#mooringType">http://dati.isprambiente.it/ontology/core#mooringType</seealso>
    let mooringType = Prefixed_Name(ispra, "mooringType") |> PrefixedName

    /// <summary>
    ///   <para>ispra:officialInstabilityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tipologia di dissesto indicata nel decreto di finanziamento."</para>
    ///   <para>"Type of instability declared in the decree"</para>
    /// labels<para>"Dissesto indicato nel decreto"</para><para>"Official instability type"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#officialInstabilityType">http://dati.isprambiente.it/ontology/core#officialInstabilityType</seealso>
    let officialInstabilityType =
        Prefixed_Name(ispra, "officialInstabilityType") |> PrefixedName

    /// <summary>
    ///   <para>ispra:operationalStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"It indicates the operational status of the measure station (Operational, Ceased, etc.)."</para>
    ///   <para>"Indica lo stato operativo della stazione di misura (es. Operational, Ceased, ecc.)."</para>
    /// labels<para>"Stato Operativo"</para><para>"Operational Status"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#operationalStatus">http://dati.isprambiente.it/ontology/core#operationalStatus</seealso>
    let operationalStatus = Prefixed_Name(ispra, "operationalStatus") |> PrefixedName
    /// <summary>
    ///   <para>ispra:parameterReported</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Insieme di grandezze osservate dallo strumento."</para>
    ///   <para>"Set of parameters measured by the instrument."</para>
    /// labels<para>"Parameters reported"</para><para>"Parametri riportati"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#parameterReported">http://dati.isprambiente.it/ontology/core#parameterReported</seealso>
    let parameterReported = Prefixed_Name(ispra, "parameterReported") |> PrefixedName
    /// <summary>
    ///   <para>ispra:phase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Fase"</para><para>"Phase"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#phase">http://dati.isprambiente.it/ontology/core#phase</seealso>
    let phase = Prefixed_Name(ispra, "phase") |> PrefixedName
    /// <summary>
    ///   <para>ispra:placedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Measure station that includes the instrument."</para>
    ///   <para>"Stazione di misura in cui è presente lo strumento"</para>
    /// labels<para>"Situato in "</para><para>"Placed on"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#placedOn">http://dati.isprambiente.it/ontology/core#placedOn</seealso>
    let placedOn = Prefixed_Name(ispra, "placedOn") |> PrefixedName
    /// <summary>
    ///   <para>ispra:positioningSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Positioning System installed on the measure station."</para>
    ///   <para>"Sistemi di georeferenziazione presenti nella stazione di misura."</para>
    /// labels<para>"Positioning System"</para><para>"Georeferenziazione"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#positioningSystem">http://dati.isprambiente.it/ontology/core#positioningSystem</seealso>
    let positioningSystem = Prefixed_Name(ispra, "positioningSystem") |> PrefixedName

    /// <summary>
    ///   <para>ispra:primaryGeographicalFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Primary geographical feature of a Contract"</para>
    ///   <para>"Luogo primario legato ad un intervento di dissesto."</para>
    /// labels<para>"Primary geographical feature"</para><para>"Luogo primario"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#primaryGeographicalFeature">http://dati.isprambiente.it/ontology/core#primaryGeographicalFeature</seealso>
    let primaryGeographicalFeature =
        Prefixed_Name(ispra, "primaryGeographicalFeature") |> PrefixedName

    /// <summary>
    ///   <para>ispra:repairCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Repair category"</para><para>"Categoria di opera"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#repairCategory">http://dati.isprambiente.it/ontology/core#repairCategory</seealso>
    let repairCategory = Prefixed_Name(ispra, "repairCategory") |> PrefixedName
    /// <summary>
    ///   <para>ispra:repairGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Repair group"</para><para>"Gruppo di opera"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#repairGroup">http://dati.isprambiente.it/ontology/core#repairGroup</seealso>
    let repairGroup = Prefixed_Name(ispra, "repairGroup") |> PrefixedName
    /// <summary>
    ///   <para>ispra:repairRelatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega l'opera al contratto."</para>
    ///   <para>"This property connects the Repair to the Contract."</para>
    /// labels<para>"Repair related to"</para><para>"Opera collegata a"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#repairRelatedTo">http://dati.isprambiente.it/ontology/core#repairRelatedTo</seealso>
    let repairRelatedTo = Prefixed_Name(ispra, "repairRelatedTo") |> PrefixedName
    /// <summary>
    ///   <para>ispra:repairType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega l'opera al concetto del vocabolario controllato."</para>
    ///   <para>"This property connects the Repair to a concept of a specific vocabulary."</para>
    /// labels<para>"Tipologia di opera"</para><para>"Repair type"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#repairType">http://dati.isprambiente.it/ontology/core#repairType</seealso>
    let repairType = Prefixed_Name(ispra, "repairType") |> PrefixedName
    /// <summary>
    ///   <para>ispra:role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The role of Entity in Authority kind class."</para>
    ///   <para>"Ruolo dell'ente nella classe Authority kind"</para>
    /// labels<para>"Ruolo"</para><para>"Role"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#role">http://dati.isprambiente.it/ontology/core#role</seealso>
    let role = Prefixed_Name(ispra, "role") |> PrefixedName

    /// <summary>
    ///   <para>ispra:secondaryGeographicalFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Secondary geographical feature of a Contract"</para>
    ///   <para>"Luogo secondario legato ad un intervento di dissesto."</para>
    /// labels<para>"Secondary geographical feature"</para><para>"Luogo secondario"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#secondaryGeographicalFeature">http://dati.isprambiente.it/ontology/core#secondaryGeographicalFeature</seealso>
    let secondaryGeographicalFeature =
        Prefixed_Name(ispra, "secondaryGeographicalFeature") |> PrefixedName

    /// <summary>
    ///   <para>ispra:sensorModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Modello del sensore/strumento."</para>
    ///   <para>"Sensor/Instrument Model."</para>
    /// labels<para>"Modello del sensore"</para><para>"Sensor Model"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#sensorModel">http://dati.isprambiente.it/ontology/core#sensorModel</seealso>
    let sensorModel = Prefixed_Name(ispra, "sensorModel") |> PrefixedName

    /// <summary>
    ///   <para>ispra:sensorSamplingFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Frequenza di campionamento dello strumento (in hertz)."</para>
    ///   <para>"Observation sampling of the instrumen (in hertz)."</para>
    /// labels<para>"Frequenza di campionamento"</para><para>"Sensor Sampling Frequency"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#sensorSamplingFrequency">http://dati.isprambiente.it/ontology/core#sensorSamplingFrequency</seealso>
    let sensorSamplingFrequency =
        Prefixed_Name(ispra, "sensorSamplingFrequency") |> PrefixedName

    /// <summary>
    ///   <para>ispra:structure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Materiale o tipologia costruttiva della stazione di misura."</para>
    ///   <para>"Material or building type of the measure station."</para>
    /// labels<para>"Structure"</para><para>"Struttura"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#structure">http://dati.isprambiente.it/ontology/core#structure</seealso>
    let structure = Prefixed_Name(ispra, "structure") |> PrefixedName
    /// <summary>
    ///   <para>ispra:typeOfDataStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Tipologia di stazione di misura."</para>
    ///   <para>"Type of Data Station."</para>
    /// labels<para>"Type of Data Station"</para><para>"Tipo di stazione di misura"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#typeOfDataStation">http://dati.isprambiente.it/ontology/core#typeOfDataStation</seealso>
    let typeOfDataStation = Prefixed_Name(ispra, "typeOfDataStation") |> PrefixedName
    /// <summary>
    ///   <para>ispra:waveHeightReported</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Parametri di altezza d'onda restituiti dallo strumento."</para>
    ///   <para>"Wave height parameters reported by the instrument."</para>
    /// labels<para>"Output di Altezza d'onda"</para><para>"Wave Height Reported"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#waveHeightReported">http://dati.isprambiente.it/ontology/core#waveHeightReported</seealso>
    let waveHeightReported = Prefixed_Name(ispra, "waveHeightReported") |> PrefixedName
    /// <summary>
    ///   <para>ispra:wavePeriodReported</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Wave period parameters reported by the instrument."</para>
    ///   <para>"Parametri di periodo dell'onda restituiti dallo strumento."</para>
    /// labels<para>"Output di Periodo dell'onda"</para><para>"Wave Period Reported"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#wavePeriodReported">http://dati.isprambiente.it/ontology/core#wavePeriodReported</seealso>
    let wavePeriodReported = Prefixed_Name(ispra, "wavePeriodReported") |> PrefixedName
    /// <summary>
    ///   <para>ispra:wmoSensorCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"It connects the intrument with the analogous concept as defined by WMO."</para>
    ///   <para>"Associa lo strumento al relativo concept definito da WMO."</para>
    /// labels<para>"Wmo Sensor Code"</para></remarks>
    /// <seealso href="http://dati.isprambiente.it/ontology/core#wmoSensorCode">http://dati.isprambiente.it/ontology/core#wmoSensorCode</seealso>
    let wmoSensorCode = Prefixed_Name(ispra, "wmoSensorCode") |> PrefixedName
