namespace https.w3id.org.arco.ontology.context_description.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cdesc =
    let _namespace_iri = Namespace_Iri cdesc |> NamespaceIRI

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/AccompanyingBibliography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/context-description/BibliographyCategory</para>
    ///   <para>"This individual represents the definition relative to the genre of bibliography."</para>
    ///   <para>"Questo individuo rappresenta la definizione (vocabolario chiuso) relativa al genere di bibliografia che riguarda in modo più generico il contesto in cui si è venuto a trovare il bene nel corso della sua storia."</para>
    /// labels<para>"Accompanying bibliography"</para><para>"Bibliografia di corredo"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/AccompanyingBibliography">https://w3id.org/arco/ontology/context-description/AccompanyingBibliography</seealso>
    let AccompanyingBibliography =
        Prefixed_Name(cdesc, "AccompanyingBibliography") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/Acquisition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a situation in which a cultural property is acquired, passing from an owner to another, and has a particular legal situation."</para>
    ///   <para>"Questa classe rappresenta un evento in cui un bene culturale è stato acquisito e si trova in una certa condizione giuridica."</para>
    /// labels<para>"Acquisition"</para><para>"Acquisizione"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/Acquisition">https://w3id.org/arco/ontology/context-description/Acquisition</seealso>
    let Acquisition = Prefixed_Name(cdesc, "Acquisition") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/AcquisitionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta il tipo di acquisizione (es.: acquisto, alienazione, confisca, donazione) che ha interessato il bene culturale."</para>
    ///   <para>"This class represents the type of acquisition (e.g. purchase, donation, etc.) of a cultural property."</para>
    /// labels<para>"Tipo di acquisizione"</para><para>"Acquisition type"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/AcquisitionType">https://w3id.org/arco/ontology/context-description/AcquisitionType</seealso>
    let AcquisitionType = Prefixed_Name(cdesc, "AcquisitionType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/AerialPhotograph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/context-description/SurveyImageType</para>
    ///
    /// labels<para>"Aerial photograph"</para><para>"Fotografia aerea"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/AerialPhotograph">https://w3id.org/arco/ontology/context-description/AerialPhotograph</seealso>
    let AerialPhotograph = Prefixed_Name(cdesc, "AerialPhotograph") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/AgeOfDeathEstimate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/AgeOfDeathEstimate">https://w3id.org/arco/ontology/context-description/AgeOfDeathEstimate</seealso>
    let AgeOfDeathEstimate = Prefixed_Name(cdesc, "AgeOfDeathEstimate") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/AgeOfDeathInterpretation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the interpretation of the age of death of an anthropological material."</para>
    ///   <para>"Questa classe rappresenta la stima dell'età della morte di un reperto antropologico."</para>
    /// labels<para>"Age of death interpretation"</para><para>"Interpretazione dell'età della morte"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/AgeOfDeathInterpretation">https://w3id.org/arco/ontology/context-description/AgeOfDeathInterpretation</seealso>
    let AgeOfDeathInterpretation =
        Prefixed_Name(cdesc, "AgeOfDeathInterpretation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/AlternativeAuthorshipAttribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta un'attribuzione di autore superata, alternativa o tradizionale."</para>
    ///   <para>"This class represents an authorship attribution alternative to the preferred one."</para>
    /// labels<para>"Attribuzione Alternativa di Autore"</para><para>"Alternative Authorship Attribution"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/AlternativeAuthorshipAttribution">https://w3id.org/arco/ontology/context-description/AlternativeAuthorshipAttribution</seealso>
    let AlternativeAuthorshipAttribution =
        Prefixed_Name(cdesc, "AlternativeAuthorshipAttribution") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/AlternativeDating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents an alternative dating of a cultural property (e.g.: an obsolete dating, a dating based on another method of dating)."</para>
    ///   <para>"Questa classe rappresenta una eventuale altra datazione che può riguardare un bene culturale (es.: datazione tradizionale, altro metodo di datazione)."</para>
    /// labels<para>"Datazione alternativa"</para><para>"Alternative dating"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/AlternativeDating">https://w3id.org/arco/ontology/context-description/AlternativeDating</seealso>
    let AlternativeDating = Prefixed_Name(cdesc, "AlternativeDating") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/AlternativeDatingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta il tipo di datazione alternativa che può riguardare un bene culturale (es.: altro metodo di datazione, datazione superata)"</para>
    ///   <para>"This class represents the type of alternative dating of a cultural property (different dating, obsolete dating, other method dating)"</para>
    /// labels<para>"Alternative dating type"</para><para>"Tipo di datazione alternativa"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/AlternativeDatingType">https://w3id.org/arco/ontology/context-description/AlternativeDatingType</seealso>
    let AlternativeDatingType =
        Prefixed_Name(cdesc, "AlternativeDatingType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/AlternativeTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/context-description/TitleType</para>
    ///   <para>"Represents subject's alternative title."</para>
    ///   <para>"Rappresenta un altro titolo noto del soggetto, in alternativa o in aggiunta al titolo più noto o accreditato."</para>
    /// labels<para>"Alternative title"</para><para>"Titolo alternativo"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/AlternativeTitle">https://w3id.org/arco/ontology/context-description/AlternativeTitle</seealso>
    let AlternativeTitle = Prefixed_Name(cdesc, "AlternativeTitle") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/Anomaly</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta un'anomalia rilevata nel corso di una fotointerpretazione o fotorestituzione."</para>
    ///   <para>"This class represents an anomaly detected during a photo interpretation or rendering."</para>
    /// labels<para>"Anomaly"</para><para>"Anomalia"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/Anomaly">https://w3id.org/arco/ontology/context-description/Anomaly</seealso>
    let Anomaly = Prefixed_Name(cdesc, "Anomaly") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/AnomalyOrigin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the anomaly origin of the photo interpretation rendering."</para>
    ///   <para>"Questa classe rappresenta l'origine dell'anomalia rilevata nell'indagine di fotointerpretazione o fotorestituzione."</para>
    /// labels<para>"Anomaly origin"</para><para>"Origine dell'anomalia"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/AnomalyOrigin">https://w3id.org/arco/ontology/context-description/AnomalyOrigin</seealso>
    let AnomalyOrigin = Prefixed_Name(cdesc, "AnomalyOrigin") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/AnomalyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta il tipo di anomalia (puntuale, lineare, areale) rilevata durante una fotointerpretazione o fotorestituzione."</para>
    ///   <para>"This class represents the type of anomaly (line anomaly, point anomaly, polygon anomaly) observed during a photo interpretation or rendering survey."</para>
    /// labels<para>"Tipo di anomalia"</para><para>"Anomaly type"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/AnomalyType">https://w3id.org/arco/ontology/context-description/AnomalyType</seealso>
    let AnomalyType = Prefixed_Name(cdesc, "AnomalyType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/AnthropicOrigin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/context-description/AnomalyOrigin</para>
    ///
    /// labels<para>"Origine antropica"</para><para>"Anthropic origin"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/AnthropicOrigin">https://w3id.org/arco/ontology/context-description/AnthropicOrigin</seealso>
    let AnthropicOrigin = Prefixed_Name(cdesc, "AnthropicOrigin") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/ArchaeologicalExcavation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a particular type of survey on a cultural property, that is an archaeological (stratigraphic) excavation."</para>
    ///   <para>"Questa classe rappresenta un tipo particolare di indagine su bene culturale, ovvero uno scavo archeologico, inteso come scavo stratigrafico."</para>
    /// labels<para>"Archaeological excavation"</para><para>"Scavo archeologico"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/ArchaeologicalExcavation">https://w3id.org/arco/ontology/context-description/ArchaeologicalExcavation</seealso>
    let ArchaeologicalExcavation =
        Prefixed_Name(cdesc, "ArchaeologicalExcavation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/ArchaeologicalFieldSurvey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a particular type of survey on a cultural property, that is an archaeological field survey, limited to the surface."</para>
    ///   <para>"Questa classe rappresenta un tipo particolare di indagine su bene culturale, ovvero una ricognizione archeologica, intesa come ricognizione di superficie."</para>
    /// labels<para>"Archaeological field survey"</para><para>"Ricognizione archeologica"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/ArchaeologicalFieldSurvey">https://w3id.org/arco/ontology/context-description/ArchaeologicalFieldSurvey</seealso>
    let ArchaeologicalFieldSurvey =
        Prefixed_Name(cdesc, "ArchaeologicalFieldSurvey") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/ArchaeologicalPropertySurvey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta un'indagine su una tipologia particolare di bene archeologico, ovvero i reperti antropologici (es.: analisi istologica, analisi chimica, TC, etc.)."</para>
    ///   <para>"This class represents a particular type of survey on a cultural property, that is a survey on anthropological materials (e.g.: chemical analysis, histological analysis, CT scan, etc.)."</para>
    /// labels<para>"Indagine su bene archeologico"</para><para>"Archaeological property survey"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/ArchaeologicalPropertySurvey">https://w3id.org/arco/ontology/context-description/ArchaeologicalPropertySurvey</seealso>
    let ArchaeologicalPropertySurvey =
        Prefixed_Name(cdesc, "ArchaeologicalPropertySurvey") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/ArchaeologicalPropertySurveyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta il tipo di indagine su bene archeologico."</para>
    ///   <para>"This class represents the type of archaeological property survey."</para>
    /// labels<para>"Archaeological property survey type"</para><para>"Tipo di indagine su bene archeologico"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/ArchaeologicalPropertySurveyType">https://w3id.org/arco/ontology/context-description/ArchaeologicalPropertySurveyType</seealso>
    let ArchaeologicalPropertySurveyType =
        Prefixed_Name(cdesc, "ArchaeologicalPropertySurveyType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/ArchaeometricDiagnosticSurvey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a particular type of survey on a cultural property, that is an archaeometric and diagnostic survey (coring, geophysical prospecting, etc.)."</para>
    ///   <para>"Questa classe rappresenta un tipo particolare di indagine su bene culturale, ovvero un'indagine archeometrica e diagnostica (carotaggi, prospezioni geofisiche, analisi di vario tipo)."</para>
    /// labels<para>"Indagine archeometrica e diagnostica"</para><para>"Archaeometric and diagnostic survey"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/ArchaeometricDiagnosticSurvey">https://w3id.org/arco/ontology/context-description/ArchaeometricDiagnosticSurvey</seealso>
    let ArchaeometricDiagnosticSurvey =
        Prefixed_Name(cdesc, "ArchaeometricDiagnosticSurvey") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/ArchaeometricDiagnosticSurveyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta il tipo di indagine archeometrica e diagnostica (es.: analisi della malta, carotaggio, termografia, etc.)"</para>
    ///   <para>"This class represents the type of archaeometric and diagnostic survey (e.g. coring)"</para>
    /// labels<para>"Archaeometric diagnostic survey type"</para><para>"Tipo di indagine archeometrica e diagnostica"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/ArchaeometricDiagnosticSurveyType">https://w3id.org/arco/ontology/context-description/ArchaeometricDiagnosticSurveyType</seealso>
    let ArchaeometricDiagnosticSurveyType =
        Prefixed_Name(cdesc, "ArchaeometricDiagnosticSurveyType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/ArchivalFonds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta un fondo archivistico."</para>
    ///   <para>"This class represents an archival fonds."</para>
    /// labels<para>"Fondo archivistico"</para><para>"Archival fonds"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/ArchivalFonds">https://w3id.org/arco/ontology/context-description/ArchivalFonds</seealso>
    let ArchivalFonds = Prefixed_Name(cdesc, "ArchivalFonds") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/ArchivalRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the archival record that is part of an archival record set."</para>
    ///   <para>"Questa classe rappresenta una unità documentaria che fa parte di una unità archivistica complessa."</para>
    /// labels<para>"Unità documentaria"</para><para>"Archival record"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/ArchivalRecord">https://w3id.org/arco/ontology/context-description/ArchivalRecord</seealso>
    let ArchivalRecord = Prefixed_Name(cdesc, "ArchivalRecord") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/ArchivalRecordSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents an archival record set (fonds, series, subseries) of which a cultural property can be member."</para>
    ///   <para>"Questa classe rappresenta un'unità archivistica complessa (fondo, serie, sottoserie, etc.) di cui un bene culturale può fare parte."</para>
    /// labels<para>"Archival record set"</para><para>"Unità archivistica complessa"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/ArchivalRecordSet">https://w3id.org/arco/ontology/context-description/ArchivalRecordSet</seealso>
    let ArchivalRecordSet = Prefixed_Name(cdesc, "ArchivalRecordSet") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/ArchivalRecordSetMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the membership of a cultural property in an archival record set."</para>
    ///   <para>"Questa classe rappresenta l'appartenenza di un bene culturale a un'unità archivistica complessa (fondo, serie, sottoserie, etc.)."</para>
    /// labels<para>"Appartenenza a unità archivistica complessa"</para><para>"Archival record set membership"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/ArchivalRecordSetMembership">https://w3id.org/arco/ontology/context-description/ArchivalRecordSetMembership</seealso>
    let ArchivalRecordSetMembership =
        Prefixed_Name(cdesc, "ArchivalRecordSetMembership") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/ArchivalSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents an archival series."</para>
    ///   <para>"Questa classe rappresenta una serie archivistica."</para>
    /// labels<para>"Archival series"</para><para>"Serie archivistica"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/ArchivalSeries">https://w3id.org/arco/ontology/context-description/ArchivalSeries</seealso>
    let ArchivalSeries = Prefixed_Name(cdesc, "ArchivalSeries") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/ArchivalSubseries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta una sottoserie archivistica, ovvero una partizione interna alla serie."</para>
    ///   <para>"This class represents an archival subseries, that is component of an archival series."</para>
    /// labels<para>"Sottoserie archivistica"</para><para>"Archival subseries"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/ArchivalSubseries">https://w3id.org/arco/ontology/context-description/ArchivalSubseries</seealso>
    let ArchivalSubseries = Prefixed_Name(cdesc, "ArchivalSubseries") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/AttachedDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/context-description/DocumentationCategory</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"This individual represents documenation definition included inside catalog."</para>
    ///   <para>"Questo individuo rappresenta la definizione (vocabolario chiuso) della documentazione acclusa alla scheda di catalogo."</para>
    /// labels<para>"Attached documentation"</para><para>"Documentazione allegata"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/AttachedDocumentation">https://w3id.org/arco/ontology/context-description/AttachedDocumentation</seealso>
    let AttachedDocumentation =
        Prefixed_Name(cdesc, "AttachedDocumentation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/AttributedTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/context-description/TitleType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Represents an attributed title of a photograph, that is a title taken from archival, bibliographic, oral or iconographic sources, or created based on picture contents."</para>
    ///   <para>"Rappresenta un titolo attribuito di una fotografia, cioè un titolo desunto, se possibile, da fonti archivistiche, bibliografiche, orali o iconografiche (altri esemplari della stessa immagine) oppure creato in base al contenuto dell'immagine (o della serie di immagini; è necessario nei casi in cui siano del tutto assenti titoli sul/nel documento, o su materiali ad esso complementari, e nel caso in cui tali titoli risultino errati."</para>
    /// labels<para>"Attributed title"</para><para>"Titolo attribuito"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/AttributedTitle">https://w3id.org/arco/ontology/context-description/AttributedTitle</seealso>
    let AttributedTitle = Prefixed_Name(cdesc, "AttributedTitle") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/AudioDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta la documentazione audio relativa a un oggetto, per esempio a un bene culturale."</para>
    ///   <para>"This class represents the audio documentation of an object, e.g. a cultural property."</para>
    /// labels<para>"Documentazione audio"</para><para>"Audio documentation"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/AudioDocumentation">https://w3id.org/arco/ontology/context-description/AudioDocumentation</seealso>
    let AudioDocumentation = Prefixed_Name(cdesc, "AudioDocumentation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/AuthorshipAttribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the attribution of authorship or a responsibility for the creation of a cultural property, referring to the agents that played a role in the creation of the cultural property or to the reference cultural scope."</para>
    ///   <para>"Questa classe rappresenta l'attribuzione di un autore o di una responsabilità per la creazione di un bene culturale, cioè le informazioni relative ai soggetti (persone singole o enti collettivi) intervenuti nella realizzazione del bene e/o all'ambito culturale di riferimento."</para>
    /// labels<para>"Attribuzione di Autore o responsabilità"</para><para>"Authorship Attribution"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/AuthorshipAttribution">https://w3id.org/arco/ontology/context-description/AuthorshipAttribution</seealso>
    let AuthorshipAttribution =
        Prefixed_Name(cdesc, "AuthorshipAttribution") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/Bibliography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the bibliography of an entity, e.g. a cultural property."</para>
    ///   <para>"Questa classe rappresenta un riferimento bibliografico che riguarda un'entità, per esempio un bene culturale."</para>
    /// labels<para>"Bibliografia"</para><para>"Bibliography"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/Bibliography">https://w3id.org/arco/ontology/context-description/Bibliography</seealso>
    let Bibliography = Prefixed_Name(cdesc, "Bibliography") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/BibliographyCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the category associated to a bibliography (e.g. accompanying bibliography, comparative bibliography, specific bibliography)."</para>
    ///   <para>"Questa classe rappresenta la categoria della bibliografia. Nel contesto delle normative per la catalogazione ICCD, questa classe ha associato un vocabolario chiuso definito in tre tipi: bibliografia specifica, bibliografia di confronto e bibliografia di corredo."</para>
    /// labels<para>"Genere della bibliografia"</para><para>"Bibliography category"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/BibliographyCategory">https://w3id.org/arco/ontology/context-description/BibliographyCategory</seealso>
    let BibliographyCategory =
        Prefixed_Name(cdesc, "BibliographyCategory") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/BibliographyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta il tipo di riferimento bibliografico."</para>
    ///   <para>"This class represents the type of bibliography."</para>
    /// labels<para>"Bibliography type"</para><para>"Tipo di bibliografia"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/BibliographyType">https://w3id.org/arco/ontology/context-description/BibliographyType</seealso>
    let BibliographyType = Prefixed_Name(cdesc, "BibliographyType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/BiologicalTaxon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta una tassonomia biologica, ossia i criteri con cui si ordinano gli organismi in un sistema di classificazione."</para>
    ///   <para>"This class represents a biological taxon."</para>
    /// labels<para>"Biological taxon"</para><para>"Tassonomia biologica"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/BiologicalTaxon">https://w3id.org/arco/ontology/context-description/BiologicalTaxon</seealso>
    let BiologicalTaxon = Prefixed_Name(cdesc, "BiologicalTaxon") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/BiologicalTaxonomy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/BiologicalTaxonomy">https://w3id.org/arco/ontology/context-description/BiologicalTaxonomy</seealso>
    let BiologicalTaxonomy = Prefixed_Name(cdesc, "BiologicalTaxonomy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/BuildingUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/context-description/UseTypeSpecification</para>
    ///   <para>"Questo individuo rappresenta le specifiche d'uso edilizio di un bene."</para>
    ///   <para>"This individual represents cultural entity  building use specifications."</para>
    /// labels<para>"Uso edilizio"</para><para>"Building use"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/BuildingUse">https://w3id.org/arco/ontology/context-description/BuildingUse</seealso>
    let BuildingUse = Prefixed_Name(cdesc, "BuildingUse") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/ChangeOfAvailability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta un evento che modifica la disponibilità materiale del bene culturale (es. per distruzione, furto, perdita, recupero)"</para>
    ///   <para>"This class represents the change of availability of a cultural property (e.g.: theft, distruction, rescue, etc.)"</para>
    /// labels<para>"Change of availability"</para><para>"Mutamento condizione materiale"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/ChangeOfAvailability">https://w3id.org/arco/ontology/context-description/ChangeOfAvailability</seealso>
    let ChangeOfAvailability =
        Prefixed_Name(cdesc, "ChangeOfAvailability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/ChangeOfAvailabilityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta il tipo di mutamento di condizione materiale di un bene culturale (es.: furto, distruzione, recupero)."</para>
    ///   <para>"This class represents the type of change of availability of a cultural property (e.g. theft, distruction)"</para>
    /// labels<para>"Tipo di mutamento condizione materiale"</para><para>"Change of availability type"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/ChangeOfAvailabilityType">https://w3id.org/arco/ontology/context-description/ChangeOfAvailabilityType</seealso>
    let ChangeOfAvailabilityType =
        Prefixed_Name(cdesc, "ChangeOfAvailabilityType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/Circumstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta un'occasione che ha determinato una certa situazione, per esempio l'occasione per cui è stato commissionato un bene culturale, l'occasione che ha determinato la ripresa di un bene fotografico, l'occasione d'uso di un bene, l'occasione di un bene demoetnoantropologico immateriale."</para>
    ///   <para>"This class represents a circumstance that influenced a particular situation, e.g. the circumstance for which a cultural property was commissioned, tha circumstance in which a cultural property was used, etc."</para>
    /// labels<para>"Occasione"</para><para>"Circumstance"</para><para>"Occasion"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/Circumstance">https://w3id.org/arco/ontology/context-description/Circumstance</seealso>
    let Circumstance = Prefixed_Name(cdesc, "Circumstance") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/CircumstanceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta il tipo di occasione (es.: civile, religiosa)."</para>
    ///   <para>"This class represents the circumstance type (e.g.: civil, religious)"</para>
    ///   <para>"This class represents the type of circumstance (e.g. civil, religious)"</para>
    /// labels<para>"Circumstance type"</para><para>"Tipo di circostanza"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/CircumstanceType">https://w3id.org/arco/ontology/context-description/CircumstanceType</seealso>
    let CircumstanceType = Prefixed_Name(cdesc, "CircumstanceType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/CivilCircumstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/context-description/CircumstanceType</para>
    ///
    /// labels<para>"Occasione civile"</para><para>"Civil circumstance"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/CivilCircumstance">https://w3id.org/arco/ontology/context-description/CivilCircumstance</seealso>
    let CivilCircumstance = Prefixed_Name(cdesc, "CivilCircumstance") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/CoinIssuance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta l'emissione di una moneta, intesa come un evento collocato nel tempo, cui partecipano diversi agenti con diversi ruoli (Stato emittente, Zecca, Monetiere, etc.)"</para>
    ///   <para>"This class represents the issuance of a coin, at a particular time and with different agents participanting to it (Mint, Issuing State, etc.)"</para>
    /// labels<para>"Emissione di moneta"</para><para>"Coin issuance"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/CoinIssuance">https://w3id.org/arco/ontology/context-description/CoinIssuance</seealso>
    let CoinIssuance = Prefixed_Name(cdesc, "CoinIssuance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/CollectionMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta l'appartenenza di un bene culturale a una collezione, in un certo intervallo di tempo. Uno stesso bene culturale può aver fatto parte di più collezioni nel corso del tempo."</para>
    ///   <para>"This class represents the membership of a cultural property in a collection."</para>
    /// labels<para>"Collection Membership"</para><para>"Appartenenza a Collezione"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/CollectionMembership">https://w3id.org/arco/ontology/context-description/CollectionMembership</seealso>
    let CollectionMembership =
        Prefixed_Name(cdesc, "CollectionMembership") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/Commission</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta l'individuazione della committenza relativa a un bene culturale."</para>
    ///   <para>"This class represents the commission of a cultural property."</para>
    /// labels<para>"Committenza"</para><para>"Commission"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/Commission">https://w3id.org/arco/ontology/context-description/Commission</seealso>
    let Commission = Prefixed_Name(cdesc, "Commission") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/ComparativeBibliography</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/context-description/BibliographyCategory</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"This individual represents the definition relative to the kind of bibliography used for comparisons."</para>
    ///   <para>"Questo individuo rappresenta la definizione (vocabolario chiuso) relativa al genere di bibliografia utilizzata per confronti (stilistici, tipologici, ecc.)."</para>
    /// labels<para>"Comparative bibliography"</para><para>"Bibliografia di confronto"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/ComparativeBibliography">https://w3id.org/arco/ontology/context-description/ComparativeBibliography</seealso>
    let ComparativeBibliography =
        Prefixed_Name(cdesc, "ComparativeBibliography") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/ConservationIntervention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a conservation intervention on a cultural property (e.g.: microclimatic inspection, mechanical cleaning or with chemicals, pest control, etc.)"</para>
    ///   <para>"Questa classe rappresenta un particolare tipo di intervento che ha interessato un bene culturale, cioè un intervento a fini conservativi (termine che sostituisce l'obsoleto "restauro", presente nelle versioni di normativa precedenti alla 4.00). Per esempio: consolidamento, controllo microclimatico, trattamento biocida-disinfestazione, rimozione di elementi non originali, pulitura meccanica, pulitura chimica, protezione finale, riadesione parti, trattamento parti metalliche."</para>
    /// labels<para>"Intervento a fini conservativi"</para><para>"Conservation Intervention"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/ConservationIntervention">https://w3id.org/arco/ontology/context-description/ConservationIntervention</seealso>
    let ConservationIntervention =
        Prefixed_Name(cdesc, "ConservationIntervention") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/Copy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the copy of a cultural property, e.g. a copy of a photography or a print."</para>
    ///   <para>"Questa classe rappresenta la copia di un bene culturale, per esempio di una fotografia o di una stampa. Nel caso della fotografia, in questo caso viene esplicitamente dichiarata la responsabilità del fotografo principale."</para>
    /// labels<para>"Copy"</para><para>"Copia"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/Copy">https://w3id.org/arco/ontology/context-description/Copy</seealso>
    let Copy = Prefixed_Name(cdesc, "Copy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/Copyright</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the copyright of an object, e.g. a cultural property."</para>
    ///   <para>"Questa classe rappresenta i diritti d'autore detenuti da un agente su un oggetto, per esempio un bene culturale."</para>
    /// labels<para>"Diritti d'autore"</para><para>"Copyright"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/Copyright">https://w3id.org/arco/ontology/context-description/Copyright</seealso>
    let Copyright = Prefixed_Name(cdesc, "Copyright") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/CulturalPropertyEstimate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta una stima di un bene culturale."</para>
    ///   <para>"This class represents the estimate of a cultural property."</para>
    /// labels<para>"Cultural property estimate"</para><para>"Stima di bene culturale"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/CulturalPropertyEstimate">https://w3id.org/arco/ontology/context-description/CulturalPropertyEstimate</seealso>
    let CulturalPropertyEstimate =
        Prefixed_Name(cdesc, "CulturalPropertyEstimate") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/CulturalPropertyStage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta lo stadio del bene catalogato in rapporto con l'oggetto che ne costituisce una fase preparatoria o che ne rappresenta la fase finale."</para>
    ///   <para>"This class represents the stage of the catalogued cultural property related to the object which constitutes its preparatory or final stage."</para>
    /// labels<para>"Cultural property stage"</para><para>"Stadio del bene culturale"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/CulturalPropertyStage">https://w3id.org/arco/ontology/context-description/CulturalPropertyStage</seealso>
    let CulturalPropertyStage =
        Prefixed_Name(cdesc, "CulturalPropertyStage") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/CulturalScope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the cultural scope related to a cultural property (e.g.: neoclassical, Milanese manifacturing, etc.)"</para>
    ///   <para>"Questa classe rappresenta l'ambito culturale a cui può essere riferito un bene culturale. Per l'ambito culturale si usano definizioni quali: ambito, cultura, periodo, produzione, scuola, manifattura, ecc.; a questi termini segue la qualificazione geografica o il nome dell'ambito, della cultura, del periodo, della produzione, della scuola, della manifattura, ecc. Nel caso della normativa VeAC, questa classe rappresenta l'ambito sartoriale/di produzione, ovvero il contesto sartoriale (oppure la manifattura, la maestranza, ecc.) a cui può essere ricondotta la realizzazione del bene catalogato."</para>
    /// labels<para>"Cultural Scope"</para><para>"Ambito culturale"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/CulturalScope">https://w3id.org/arco/ontology/context-description/CulturalScope</seealso>
    let CulturalScope = Prefixed_Name(cdesc, "CulturalScope") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/CulturalScopeAttribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the attribution of a cultural scope, to which the cultural property is related (e.g.: neoclassical, Milanese manifacturing, etc.)"</para>
    ///   <para>"Questa classe rappresenta l'attribuzione di un ambito culturale a cui può essere riferito il bene culturale. Per l'ambito culturale si usano definizioni quali: ambito, cultura, periodo, produzione, scuola, manifattura, ecc.; a questi termini segue la qualificazione geografica o il nome dell'ambito, della cultura, del periodo, della produzione, della scuola, della manifattura, ecc."</para>
    /// labels<para>"Cultural Scope Attribution"</para><para>"Attribuzione di Ambito Culturale"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/CulturalScopeAttribution">https://w3id.org/arco/ontology/context-description/CulturalScopeAttribution</seealso>
    let CulturalScopeAttribution =
        Prefixed_Name(cdesc, "CulturalScopeAttribution") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/CurrentInventory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the current inventory of a cultural property, e.g. patrimonial informations."</para>
    ///   <para>"Questa classe rappresenta un inventario patrimoniale, che registra le informazioni amministrative relative alla situazione patrimoniale del bene."</para>
    /// labels<para>"Current Inventory"</para><para>"Inventario Patrimoniale"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/CurrentInventory">https://w3id.org/arco/ontology/context-description/CurrentInventory</seealso>
    let CurrentInventory = Prefixed_Name(cdesc, "CurrentInventory") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/CurrentUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/context-description/UseType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"This individual represents cultural entity current use."</para>
    ///   <para>"Questo individuo rappresenta l'uso attuale di un bene."</para>
    /// labels<para>"Uso attuale"</para><para>"Current use"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/CurrentUse">https://w3id.org/arco/ontology/context-description/CurrentUse</seealso>
    let CurrentUse = Prefixed_Name(cdesc, "CurrentUse") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/Dating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta la cronologia di un'entità, cioè i dati cronologici che riguardano la storia dell'entità (es.: un bene culturale o un'opera collegata a un bene culturale). In relazione alle diverse situazioni, indicheranno un periodo esteso nel tempo oppure una singola data. Per ciascun bene viene fornita la cronologia della sua realizzazione, o, nel caso di immobili che presentano diverse fasi edilizie o diversi momenti di vita, un arco cronologico di riferimento; possono essere fornite anche altre notizie cronologiche relative ad altri eventi che hanno riguardato il bene (demolizione, progettazione, rimaneggiamenti, etc.)"</para>
    ///   <para>"This class represents the dating of an entity, that is information about the chronology of the entity (e.g.: a cultural property), referring to a particular event (e.g.: the creation of the cultural property, its distruction, etc.)"</para>
    /// labels<para>"Dating"</para><para>"Cronologia"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/Dating">https://w3id.org/arco/ontology/context-description/Dating</seealso>
    let Dating = Prefixed_Name(cdesc, "Dating") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/DecentReliability</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/context-description/Reliability</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Discreta affidabilità"</para><para>"Decent reliability"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/DecentReliability">https://w3id.org/arco/ontology/context-description/DecentReliability</seealso>
    let DecentReliability = Prefixed_Name(cdesc, "DecentReliability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/DeliveryConfirmationCertification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/context-description/ExportImportCertificationType</para>
    ///
    /// labels<para>"Conferma di avvenuta spedizione"</para><para>"Delivery confirmation certification"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/DeliveryConfirmationCertification">https://w3id.org/arco/ontology/context-description/DeliveryConfirmationCertification</seealso>
    let DeliveryConfirmationCertification =
        Prefixed_Name(cdesc, "DeliveryConfirmationCertification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/DerivatedWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a derivated work of a cultural property (copy, reuse, facsimile, forgery), created by the same author or by another author."</para>
    ///   <para>"Questa classe rappresenta una derivazione del bene catalogato (reimpiego, copia, contraffazione, replica, controtipo) prodotta dallo stesso o da altro autore."</para>
    /// labels<para>"Opera derivata"</para><para>"Derivated work"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/DerivatedWork">https://w3id.org/arco/ontology/context-description/DerivatedWork</seealso>
    let DerivatedWork = Prefixed_Name(cdesc, "DerivatedWork") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/DerivatedWorkType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the type of derivated work of a cultural property."</para>
    ///   <para>"Questa classe rappresenta il tipo di opera derivata da un bene culturale."</para>
    /// labels<para>"Derivated work type"</para><para>"Tipo di opera derivata"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/DerivatedWorkType">https://w3id.org/arco/ontology/context-description/DerivatedWorkType</seealso>
    let DerivatedWorkType = Prefixed_Name(cdesc, "DerivatedWorkType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/DetectionMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta la modalità di individuazione che ha consentito l'individuazione di un bene culturale e che è indicativa della tipologia e della consistenza di alcune informazioni presenti nella scheda di catalogo che lo descrive (es.: carotaggio, dati di archivio, fonti orali)."</para>
    ///   <para>"This class represents the method of detection that allowed the detection of a cultural property and which is indicative of the type and consistency of some information in the catalogue record that describes it (e.g.: coring, archive data, oral sources)."</para>
    /// labels<para>"Metodo di individuazione"</para><para>"Detection Method"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/DetectionMethod">https://w3id.org/arco/ontology/context-description/DetectionMethod</seealso>
    let DetectionMethod = Prefixed_Name(cdesc, "DetectionMethod") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/DifferentDating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/context-description/AlternativeDatingType</para>
    ///   <para>"Questo individuo rappresenta un tipo di datazione differente rispetto a quella presente nelle informazioni della cronologia del bene in esame."</para>
    ///   <para>"This individual represents a different type of dating than the one present in cultural entity's chronological information."</para>
    /// labels<para>"Different dating"</para><para>"Datazione diversa"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/DifferentDating">https://w3id.org/arco/ontology/context-description/DifferentDating</seealso>
    let DifferentDating = Prefixed_Name(cdesc, "DifferentDating") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/Documentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Classe che rappresenta la documentazione, specializzata nelle sottoclassi che rappresentano tipi specifici di documentazione di corredo (immagini, disegni e rilievi, cartografia, documenti audio e video, fonti e documenti editi e inediti, referenze bibliografiche)."</para>
    ///   <para>"This class represents the documentation, with subclasses for each specific type of documentation (images, drawings, audio, video, etc.)"</para>
    /// labels<para>"Documentation"</para><para>"Documentazione"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/Documentation">https://w3id.org/arco/ontology/context-description/Documentation</seealso>
    let Documentation = Prefixed_Name(cdesc, "Documentation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/DocumentationCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta la categoria della documentazione. Nel contesto delle normative per la catalogazione ICCD, questa classe ha un vocabolario chiuso definito in due tipi: documentazione allegata e documentazione esistente."</para>
    ///   <para>"This class represents the category associated to a documentation (e.g. attached documentation, existing documentation)."</para>
    /// labels<para>"Genere della documentazione"</para><para>"Documentation category"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/DocumentationCategory">https://w3id.org/arco/ontology/context-description/DocumentationCategory</seealso>
    let DocumentationCategory =
        Prefixed_Name(cdesc, "DocumentationCategory") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/DocumentationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the type of documentation."</para>
    ///   <para>"Questa classe rappresenta il tipo di documentazione."</para>
    /// labels<para>"Documentation type"</para><para>"Tipo di documentazione"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/DocumentationType">https://w3id.org/arco/ontology/context-description/DocumentationType</seealso>
    let DocumentationType = Prefixed_Name(cdesc, "DocumentationType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/Edition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the edition of an entity (e.g. the print edition of a cultural property)."</para>
    ///   <para>"Questa classe rappresenta l'edizione di un'entità. Per esempio, l'edizione cartacea o digitale di un bene culturale o di un'opera collegata a un bene culturale (ad es. una pubblicazione contenente una stampa)."</para>
    /// labels<para>"Edizione"</para><para>"Edition"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/Edition">https://w3id.org/arco/ontology/context-description/Edition</seealso>
    let Edition = Prefixed_Name(cdesc, "Edition") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/EligibleIntervention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta il tipo di intervento ammesso da una normativa specifica, ovvero da un piano regolatore generale e particolareggiato o da un piano paesaggistico che interessa un bene culturale."</para>
    ///   <para>"This class represents the intervention considered eligible by a specific urban planning instrument related to a cultural property."</para>
    /// labels<para>"Intervento ammesso"</para><para>"Eligible intervention"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/EligibleIntervention">https://w3id.org/arco/ontology/context-description/EligibleIntervention</seealso>
    let EligibleIntervention =
        Prefixed_Name(cdesc, "EligibleIntervention") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/EpigraphicUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/context-description/UseTypeSpecification</para>
    ///   <para>"This individual represents cultural entity's epigraphic use."</para>
    ///   <para>"Questo individuo rappresenta le specifiche d'uso epigrafico di un bene."</para>
    /// labels<para>"Epigraphic"</para><para>"Epigrafico"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/EpigraphicUse">https://w3id.org/arco/ontology/context-description/EpigraphicUse</seealso>
    let EpigraphicUse = Prefixed_Name(cdesc, "EpigraphicUse") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/Estimate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the concept of estimate."</para>
    ///   <para>"Questa classe rappresenta il concetto di stima di un'entità."</para>
    /// labels<para>"Estimate"</para><para>"Stima"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/Estimate">https://w3id.org/arco/ontology/context-description/Estimate</seealso>
    let Estimate = Prefixed_Name(cdesc, "Estimate") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/ExcellentReliability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/context-description/Reliability</para>
    ///
    /// labels<para>"Ottima affidabilità"</para><para>"Excellent reliability"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/ExcellentReliability">https://w3id.org/arco/ontology/context-description/ExcellentReliability</seealso>
    let ExcellentReliability =
        Prefixed_Name(cdesc, "ExcellentReliability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/ExistingDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/context-description/DocumentationCategory</para>
    ///   <para>"This individual represents documentation definition that is only mentioned."</para>
    ///   <para>"Questo individuo rappresenta la definizione (vocabolario chiuso) della documentazione che viene solo citata: non è acclusa alla scheda di catalogo, ma si trova presso un luogo di conservazione (Archivio, Biblioteca, ecc.), anche “virtuale”, come nel caso delle risorse disponibili sul web e consultabili on line."</para>
    /// labels<para>"Existing documentation"</para><para>"Documentazione esistente"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/ExistingDocumentation">https://w3id.org/arco/ontology/context-description/ExistingDocumentation</seealso>
    let ExistingDocumentation =
        Prefixed_Name(cdesc, "ExistingDocumentation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/ExpiredCopyright</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta i diritti d'autore scaduti, relativi quindi a un oggetto, per esempio un bene culturale, diventato di pubblico dominio."</para>
    ///   <para>"This class represents an expired copyright, related to an object, e.g. a cultural property."</para>
    /// labels<para>"Diritti d'autore scaduti"</para><para>"Expired Copyright"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/ExpiredCopyright">https://w3id.org/arco/ontology/context-description/ExpiredCopyright</seealso>
    let ExpiredCopyright = Prefixed_Name(cdesc, "ExpiredCopyright") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/ExportImportCertification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta una certificazione amministrativa per la circolazione e l'esportazione/importazione di un bene culturale."</para>
    ///   <para>"This class represents the export/import certification of a cultural property."</para>
    /// labels<para>"Certificazione di importazione o esportazione"</para><para>"Export import certification"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/ExportImportCertification">https://w3id.org/arco/ontology/context-description/ExportImportCertification</seealso>
    let ExportImportCertification =
        Prefixed_Name(cdesc, "ExportImportCertification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/ExportImportCertificationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the type of export/import certification of a cultural property (e.g.: temporary movement certification, temporary export license, free movement certification, etc.)."</para>
    ///   <para>"Questa classe rappresenta il tipo di certificazione amministrativa di circolazione ed esportazione/importazione di un bene culturale (es.: attestato di libera circolazione, licenza di esportazione definitiva, ecc)."</para>
    /// labels<para>"Tipo di certificazione di esportazione o importazione"</para><para>"Export import certification type"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/ExportImportCertificationType">https://w3id.org/arco/ontology/context-description/ExportImportCertificationType</seealso>
    let ExportImportCertificationType =
        Prefixed_Name(cdesc, "ExportImportCertificationType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/Facsimile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a facsimile of a cultural property, and in particular of a photography, that has the same format and technique."</para>
    ///   <para>"Questa classe rappresenta un controtipo di un bene culturale, specificamente di una fotografia, cioè una duplicazione realizzata nello stesso formato e nella stessa tecnica."</para>
    /// labels<para>"Facsimile"</para><para>"Controtipo"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/Facsimile">https://w3id.org/arco/ontology/context-description/Facsimile</seealso>
    let Facsimile = Prefixed_Name(cdesc, "Facsimile") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/FairMarketCircumstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a circumstance related to fairs, markets, festivals."</para>
    ///   <para>"Questa classe rappresenta un'occasione connessa a fiere, mercati, sagre."</para>
    /// labels<para>"Fair market circumstance"</para><para>"Occasione legata a fiere e mercati"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/FairMarketCircumstance">https://w3id.org/arco/ontology/context-description/FairMarketCircumstance</seealso>
    let FairMarketCircumstance =
        Prefixed_Name(cdesc, "FairMarketCircumstance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/FilmDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta la documentazione video-cinematografica relativa a un oggetto, per esempio a un bene culturale"</para>
    ///   <para>"This class represents the film documentation of an object, e.g. a cultural property."</para>
    /// labels<para>"Documentazione video-cinematografica"</para><para>"Video documentation"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/FilmDocumentation">https://w3id.org/arco/ontology/context-description/FilmDocumentation</seealso>
    let FilmDocumentation = Prefixed_Name(cdesc, "FilmDocumentation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/FinalWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta un'entità collegata a un bene culturale, che ne costituisce la fase finale."</para>
    ///   <para>"This class represents an entity related to a cultural property, as its final stage."</para>
    /// labels<para>"Final work"</para><para>"Opera finale"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/FinalWork">https://w3id.org/arco/ontology/context-description/FinalWork</seealso>
    let FinalWork = Prefixed_Name(cdesc, "FinalWork") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/FindingContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta il contesto di ritrovamento (tipo di contesto, elementi associati) di un bene culturale, e in particolare di un reperto antropologico."</para>
    ///   <para>"This class represents the context (type of context, associated objects) in which a cultural property (in particular, an anthropological material) is found."</para>
    /// labels<para>"Contesto di rinvenimento"</para><para>"Finding context"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/FindingContext">https://w3id.org/arco/ontology/context-description/FindingContext</seealso>
    let FindingContext = Prefixed_Name(cdesc, "FindingContext") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/FindingContextType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta il tipo di contesto di rinvenimento di un bene culturale, e in particolare di un reperto antropologico (es.: sepoltura collettiva, sepoltura singola primaria, etc.)"</para>
    ///   <para>"This class represents the type of finding context of a cultural property, and in particular of an anthropological material (e.g.: individual burial, common burial, etc.)"</para>
    /// labels<para>"Finding context type"</para><para>"Tipo di contesto di rinvenimento"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/FindingContextType">https://w3id.org/arco/ontology/context-description/FindingContextType</seealso>
    let FindingContextType = Prefixed_Name(cdesc, "FindingContextType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/Forgery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta una contraffazione di un bene culturale, cioè una riproduzione di un bene culturale da parte di un autore che non dichiari l'autore dell'originale."</para>
    ///   <para>"This class represents a forgery of a cultural property, that is a copy of a cultural property for which the author doesn't declare the original author."</para>
    /// labels<para>"Contraffazione"</para><para>"Forgery"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/Forgery">https://w3id.org/arco/ontology/context-description/Forgery</seealso>
    let Forgery = Prefixed_Name(cdesc, "Forgery") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/Format</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta il formato della documentazione (es.: jpeg, A0, pdf, audiocassetta, MP4)."</para>
    ///   <para>"This class represents the documentation format (e.g. jpeg, pdf, MP4)"</para>
    /// labels<para>"Formato"</para><para>"Format"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/Format">https://w3id.org/arco/ontology/context-description/Format</seealso>
    let Format = Prefixed_Name(cdesc, "Format") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/FreeMovementCertification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/context-description/ExportImportCertificationType</para>
    ///
    /// labels<para>"Attestato di libera circolazione"</para><para>"Free movement certification"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/FreeMovementCertification">https://w3id.org/arco/ontology/context-description/FreeMovementCertification</seealso>
    let FreeMovementCertification =
        Prefixed_Name(cdesc, "FreeMovementCertification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/Fruition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a circumstance in which a garment, catalogued as a cultural property, was worn by one or more people."</para>
    ///   <para>"Questa classe rappresenta un'occasione in cui il capo oggetto di catalogazione è stato indossato da una o più persone, sia perché ad esse destinato sia perché, ad esse pervenuto, hanno potuto riadattarlo a loro nuove esigenze."</para>
    /// labels<para>"Fruition"</para><para>"Fruizione"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/Fruition">https://w3id.org/arco/ontology/context-description/Fruition</seealso>
    let Fruition = Prefixed_Name(cdesc, "Fruition") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/Genus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents one level of a biological taxon, the genus."</para>
    ///   <para>"Questa classe rappresenta uno dei livelli di classificazione di una tassonomia biologica, ovvero il genere."</para>
    /// labels<para>"Genus"</para><para>"Genere"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/Genus">https://w3id.org/arco/ontology/context-description/Genus</seealso>
    let Genus = Prefixed_Name(cdesc, "Genus") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/GoodReliability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/context-description/Reliability</para>
    ///
    /// labels<para>"Good reliability"</para><para>"Buona affidabilità"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/GoodReliability">https://w3id.org/arco/ontology/context-description/GoodReliability</seealso>
    let GoodReliability = Prefixed_Name(cdesc, "GoodReliability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/GraphicOrCartographicDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta la documentazione grafica e cartografica relativa a un oggetto, per esempio a un bene culturale."</para>
    ///   <para>"This class represents the graphic or cartographic documentation of an object, e.g. a cultural property."</para>
    /// labels<para>"Graphic and cartographic documentation"</para><para>"Documentazione grafica e cartografica"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/GraphicOrCartographicDocumentation">https://w3id.org/arco/ontology/context-description/GraphicOrCartographicDocumentation</seealso>
    let GraphicOrCartographicDocumentation =
        Prefixed_Name(cdesc, "GraphicOrCartographicDocumentation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/HistoricalUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/context-description/UseType</para>
    ///   <para>"This individual represents cultural enity's historical use."</para>
    ///   <para>"Questo individuo rappresenta l'uso storico di un bene."</para>
    /// labels<para>"Historical use"</para><para>"Uso storico"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/HistoricalUse">https://w3id.org/arco/ontology/context-description/HistoricalUse</seealso>
    let HistoricalUse = Prefixed_Name(cdesc, "HistoricalUse") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/HistoricizedTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/context-description/TitleType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Titolo storicizzato"</para><para>"Historicized title"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/HistoricizedTitle">https://w3id.org/arco/ontology/context-description/HistoricizedTitle</seealso>
    let HistoricizedTitle = Prefixed_Name(cdesc, "HistoricizedTitle") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/ImportConfirmationCertification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/context-description/ExportImportCertificationType</para>
    ///
    /// labels<para>"Import confirmation certification"</para><para>"Certificato di avvenuta importazione"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/ImportConfirmationCertification">https://w3id.org/arco/ontology/context-description/ImportConfirmationCertification</seealso>
    let ImportConfirmationCertification =
        Prefixed_Name(cdesc, "ImportConfirmationCertification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/IndeterminateCircumstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents an indeterminate circumstance, when the cultural property is not related to a determinate circumstance, but takes place in an extemporaneous and contingent way (e.g.: a musical performance, a narration, a game)."</para>
    ///   <para>"Questa classe rappresenta un'occasione indeterminata, cioè quando il bene non è in rapporto con una precisa occasione o scadenza, ma si realizza in modo del tutto estemporaneo e contingente. Occasioni indeterminate possono essere, per esempio, un'esecuzione musicale, una narrazione, un
    /// gioco, etc."</para>
    /// labels<para>"Indeterminate circumstance"</para><para>"Occasione indeterminata"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/IndeterminateCircumstance">https://w3id.org/arco/ontology/context-description/IndeterminateCircumstance</seealso>
    let IndeterminateCircumstance =
        Prefixed_Name(cdesc, "IndeterminateCircumstance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/Inspection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a particular type of survey on a cultural property, that is an inspection carried out to verify the condition of a cultural property."</para>
    ///   <para>"Questa classe rappresenta un tipo particolare di indagine su bene culturale, ovvero un'ispezione effettuata per constatare lo stato del bene."</para>
    /// labels<para>"Ispezione"</para><para>"Inspection"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/Inspection">https://w3id.org/arco/ontology/context-description/Inspection</seealso>
    let Inspection = Prefixed_Name(cdesc, "Inspection") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/InstrumentalUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/context-description/UseTypeSpecification</para>
    ///   <para>"Questo individuo rappresenta le specifiche d'uso strumentale di un bene."</para>
    ///   <para>"This individual represents cultural entity instrumental use specifications."</para>
    /// labels<para>"Strumentale"</para><para>"Instrumental"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/InstrumentalUse">https://w3id.org/arco/ontology/context-description/InstrumentalUse</seealso>
    let InstrumentalUse = Prefixed_Name(cdesc, "InstrumentalUse") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/InsufficientReliability</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/context-description/Reliability</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Scarsa affidabilità"</para><para>"Insufficient reliability"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/InsufficientReliability">https://w3id.org/arco/ontology/context-description/InsufficientReliability</seealso>
    let InsufficientReliability =
        Prefixed_Name(cdesc, "InsufficientReliability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/Interpretation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a situation in which pieces of information related to an object (e.g.: a cultural property) are detected and recorded by an agent, based on a specific source or motivation (e.g.:ithe authorship attribution, commission, etc.)"</para>
    ///   <para>"Questa classe rappresenta una situazione in cui viene individuata e registrata da un agente una certa informazione o un gruppo di informazioni relativamente a un oggetto, per esempio a un bene culturale o a una sua parte, supportata da una fonte o motivazione. Per esempio, l'attribuzione di autore, l'individuazione della committenza o delle entità responsabili di fasi successive alla creazione di un bene culturale sono tutte interpretazioni basate su fonti."</para>
    /// labels<para>"Interpretation"</para><para>"Interpretazione"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/Interpretation">https://w3id.org/arco/ontology/context-description/Interpretation</seealso>
    let Interpretation = Prefixed_Name(cdesc, "Interpretation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/InterpretationCriterion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the criterion that motivated an interpretation (e.g. inscription, bibliography, documentation)."</para>
    ///   <para>"Questa classe rappresenta il criterio o la motivazione che ha determinato una certa interpretazione (es.: bibliografia, documentazione, iscrizione)."</para>
    /// labels<para>"Criterio interpretativo"</para><para>"Interpretation criterion"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/InterpretationCriterion">https://w3id.org/arco/ontology/context-description/InterpretationCriterion</seealso>
    let InterpretationCriterion =
        Prefixed_Name(cdesc, "InterpretationCriterion") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/Intervention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents an intervention on a cultural property, that is an activity carried out for its conservation or for other purposes: conservation interventions, reprocessing, restoring, etc."</para>
    ///   <para>"Questa classe rappresenta un intervento che ha interessato un bene culturale, a fini conservativi (per i quali si crea una sottoclasse di "Intervento") oppure di altro tipo: restauri (termine obsoleto che attualmente corrisponde a "intervento a fine conservativo"), rilavorazioni, ripristini, trasformazioni per recuperare aspetto e funzionalità rispondenti ai mutati gusti, ecc. In generale, per interventi si intendono attività che riguardano il bene, effettuate per la sua realizzazione/modifica e conservazione materiale."</para>
    /// labels<para>"Intervento"</para><para>"Intervention"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/Intervention">https://w3id.org/arco/ontology/context-description/Intervention</seealso>
    let Intervention = Prefixed_Name(cdesc, "Intervention") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/InterventionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta il tipo di intervento (a fini conservativi o di altro tipo) che ha interessato un bene culturale."</para>
    ///   <para>"This class represents the type of intervention on a cultural property."</para>
    /// labels<para>"Intervention type"</para><para>"Tipo di intervento"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/InterventionType">https://w3id.org/arco/ontology/context-description/InterventionType</seealso>
    let InterventionType = Prefixed_Name(cdesc, "InterventionType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/Inventory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents an inventory about a cultural property or about an entity or an activity related to the cultural property."</para>
    ///   <para>"Questa classe rappresenta un inventario, di vario tipo, relativo a un bene culturale o relativo a una delle entità o attività collegate al bene culturale (per esempio un inventario di scavo archeologico)."</para>
    /// labels<para>"Inventory"</para><para>"Inventario"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/Inventory">https://w3id.org/arco/ontology/context-description/Inventory</seealso>
    let Inventory = Prefixed_Name(cdesc, "Inventory") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/LaboratoryTest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta un tipo particolare di indagine su bene culturale, ovvero un'analisi di laboratorio."</para>
    ///   <para>"This class represents a particular type of survey on a cultural property, that is a laboratory test."</para>
    /// labels<para>"Laboratory test"</para><para>"Analisi di laboratorio"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/LaboratoryTest">https://w3id.org/arco/ontology/context-description/LaboratoryTest</seealso>
    let LaboratoryTest = Prefixed_Name(cdesc, "LaboratoryTest") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/LaboratoryTestType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the type of laboratory test (es.: chemical analysis)"</para>
    ///   <para>"Questa classe rappresenta il tipo di analisi di laboratorio (es.: analisi metallurgica, analisi chimica, etc.)"</para>
    /// labels<para>"Laboratory test type"</para><para>"Tipo di analisi di laboratorio"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/LaboratoryTestType">https://w3id.org/arco/ontology/context-description/LaboratoryTestType</seealso>
    let LaboratoryTestType = Prefixed_Name(cdesc, "LaboratoryTestType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/LegalSituation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the legal situation of a cultural property, related to the owner."</para>
    ///   <para>"Questa classe rappresenta la condizione giuridica di un bene culturale, con riferimenti al proprietario, detentore o possessore."</para>
    /// labels<para>"Legal situation"</para><para>"Situazione giuridica"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/LegalSituation">https://w3id.org/arco/ontology/context-description/LegalSituation</seealso>
    let LegalSituation = Prefixed_Name(cdesc, "LegalSituation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/LifeCycleCircumstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta un'occasione legata ai cicli della vita (cerimonie, riti, feste)."</para>
    ///   <para>"This class represents a circumstance related to life cycles (ceremonies, custom, celebration)"</para>
    /// labels<para>"Occasione legata al ciclo della vita"</para><para>"Life cycle circumstance"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/LifeCycleCircumstance">https://w3id.org/arco/ontology/context-description/LifeCycleCircumstance</seealso>
    let LifeCycleCircumstance =
        Prefixed_Name(cdesc, "LifeCycleCircumstance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/LineAnomaly</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/context-description/AnomalyType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Anomalia lineare"</para><para>"Line anomaly"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/LineAnomaly">https://w3id.org/arco/ontology/context-description/LineAnomaly</seealso>
    let LineAnomaly = Prefixed_Name(cdesc, "LineAnomaly") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/MainTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/context-description/TitleType</para>
    ///   <para>"Questo individuo rappresenta il titolo principale di una pubblicazione."</para>
    ///   <para>"This individual represents publication main title."</para>
    /// labels<para>"Main title"</para><para>"Titolo principale"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/MainTitle">https://w3id.org/arco/ontology/context-description/MainTitle</seealso>
    let MainTitle = Prefixed_Name(cdesc, "MainTitle") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/Membership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta il concetto di appartenenza."</para>
    ///   <para>"This class represents the concept of membership."</para>
    /// labels<para>"Appartenenza"</para><para>"Membership"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/Membership">https://w3id.org/arco/ontology/context-description/Membership</seealso>
    let Membership = Prefixed_Name(cdesc, "Membership") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/MultimediaDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the multimedia documentation of an object, e.g. a cultural property."</para>
    ///   <para>"Questa classe rappresenta la documentazione multimediale in formato digitale relativa al un oggetto, per esempio un bene culturale. Nel caso delle Normative per la catalogazione dell'ICCD questa classe riguarda la documentazione multimediale realizzata in formati non compresi dalle norme ICCD, allegata alla scheda di catalogo o esistente e depositata presso l'Ente schedatore o in altre raccolte."</para>
    /// labels<para>"Altra documentazione multimediale"</para><para>"Multimedia documentation"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/MultimediaDocumentation">https://w3id.org/arco/ontology/context-description/MultimediaDocumentation</seealso>
    let MultimediaDocumentation =
        Prefixed_Name(cdesc, "MultimediaDocumentation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/NaturalOrigin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/context-description/AnomalyOrigin</para>
    ///
    /// labels<para>"Origine naturale"</para><para>"Natural origin"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/NaturalOrigin">https://w3id.org/arco/ontology/context-description/NaturalOrigin</seealso>
    let NaturalOrigin = Prefixed_Name(cdesc, "NaturalOrigin") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/NoLongerInPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta una stampa che non è più parte integrante della pubblicazione, ma che lo è stata in passato."</para>
    ///   <para>"This class represents a print that is no longer was a part of a publication."</para>
    /// labels<para>"Stampa non più in volume"</para><para>"Print no longer in publication"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/NoLongerInPublication">https://w3id.org/arco/ontology/context-description/NoLongerInPublication</seealso>
    let NoLongerInPublication =
        Prefixed_Name(cdesc, "NoLongerInPublication") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/NumismaticSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the series which a particular coin is part of."</para>
    ///   <para>"Questa classe rappresenta la serie della quale una moneta fa parte (es.: Greca, Romana Repubblicana, Barbarica)."</para>
    /// labels<para>"Numismatic series"</para><para>"Serie numismatica"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/NumismaticSeries">https://w3id.org/arco/ontology/context-description/NumismaticSeries</seealso>
    let NumismaticSeries = Prefixed_Name(cdesc, "NumismaticSeries") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/ObservationSurvey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta un tipo particolare di indagine, ovvero il rilevamento (l'occasione o l'indagine in occasione della quale è stato rilevato, individuato, osservato il bene) di un bene musicale di interesse etno-organologico o di un bene demoetno-antropologico."</para>
    ///   <para>"This class represents a particular type of survey on a cultural property, that is an observation survey: the observation of musical heritage or demoethnoanthropological heritage."</para>
    /// labels<para>"Observation survey"</para><para>"Indagine di rilevamento"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/ObservationSurvey">https://w3id.org/arco/ontology/context-description/ObservationSurvey</seealso>
    let ObservationSurvey = Prefixed_Name(cdesc, "ObservationSurvey") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/ObservationSurveyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the type of observation survey (in the context / out of the context)."</para>
    ///   <para>"Questa classe rappresenta il tipo di indagine di rilevamento (rilevamento nel contesto/ rilevamento decontestualizzato)."</para>
    /// labels<para>"Tipo di indagine di rilevamento"</para><para>"Observation survey type"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/ObservationSurveyType">https://w3id.org/arco/ontology/context-description/ObservationSurveyType</seealso>
    let ObservationSurveyType =
        Prefixed_Name(cdesc, "ObservationSurveyType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/ObsoleteDating</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/context-description/AlternativeDatingType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"This individual represents an obsolete dating."</para>
    ///   <para>"Questo individuo rappresenta il tipo di datazione superata rispetto a quella presente nelle informazioni relative alla cronologia del bene in esame."</para>
    /// labels<para>"Datazione superata"</para><para>"Obsolete dating"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/ObsoleteDating">https://w3id.org/arco/ontology/context-description/ObsoleteDating</seealso>
    let ObsoleteDating = Prefixed_Name(cdesc, "ObsoleteDating") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/OriginalTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/context-description/TitleType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Original title"</para><para>"Titolo originario"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/OriginalTitle">https://w3id.org/arco/ontology/context-description/OriginalTitle</seealso>
    let OriginalTitle = Prefixed_Name(cdesc, "OriginalTitle") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/OrnamentalUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/context-description/UseTypeSpecification</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"This individual represents cultural entity's ornamental use specifications."</para>
    ///   <para>"Questo individuo rappresenta le specifiche d'uso ornamentale di un bene."</para>
    /// labels<para>"Ornamental"</para><para>"Ornamentale"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/OrnamentalUse">https://w3id.org/arco/ontology/context-description/OrnamentalUse</seealso>
    let OrnamentalUse = Prefixed_Name(cdesc, "OrnamentalUse") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/OtherMethodOfDating</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/context-description/AlternativeDatingType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Questo individuo rappresenta un tipo di metodo diverso di datazione rispetto a quella presente nelle informazioni della cronologia del bene in esame."</para>
    ///   <para>"This individual represents a different type of dating method than the one present in cultural entity's chronological information."</para>
    /// labels<para>"Altro metodo di datazione"</para><para>"Other method of dating"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/OtherMethodOfDating">https://w3id.org/arco/ontology/context-description/OtherMethodOfDating</seealso>
    let OtherMethodOfDating =
        Prefixed_Name(cdesc, "OtherMethodOfDating") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/PaleopathologySurvey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta un'indagine, intesa come attività, in cui viene elaborata una diagnosi di una paleopatologia di un reperto antropologico."</para>
    ///   <para>"This class represents a particular type of survey on a cultural property, that is a survey in which is possible to make a diagnosis of a paleopathology of an anthropological material."</para>
    /// labels<para>"Indagine su paleopatologia"</para><para>"Paleopathology survey"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/PaleopathologySurvey">https://w3id.org/arco/ontology/context-description/PaleopathologySurvey</seealso>
    let PaleopathologySurvey =
        Prefixed_Name(cdesc, "PaleopathologySurvey") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/ParallelTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/context-description/TitleType</para>
    ///   <para>"I represents a parallel title, that is main title translated into other languages and presented as equivalent."</para>
    ///   <para>"Rappresenta un titolo parallelo, cioè lo stesso titolo principale tradotto in altre lingue e presentato come equivalente."</para>
    /// labels<para>"Parallel title"</para><para>"Titolo parallelo"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/ParallelTitle">https://w3id.org/arco/ontology/context-description/ParallelTitle</seealso>
    let ParallelTitle = Prefixed_Name(cdesc, "ParallelTitle") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/PermanentExportLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/context-description/ExportImportCertificationType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Licenza di esportazione definitiva"</para><para>"Permanent export license"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/PermanentExportLicense">https://w3id.org/arco/ontology/context-description/PermanentExportLicense</seealso>
    let PermanentExportLicense =
        Prefixed_Name(cdesc, "PermanentExportLicense") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/PhotoInterpretationRendering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a particular type of survey on a cultural property, that is photo interpretation and rendering."</para>
    ///   <para>"Questa classe rappresenta un tipo particolare di indagine su bene culturale, ovvero una fotointerpretazione e fotorestituzione, intesa come indagine territoriale."</para>
    /// labels<para>"Photo interpretation and rendering"</para><para>"Fotointerpretazione e fotorestituzione"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/PhotoInterpretationRendering">https://w3id.org/arco/ontology/context-description/PhotoInterpretationRendering</seealso>
    let PhotoInterpretationRendering =
        Prefixed_Name(cdesc, "PhotoInterpretationRendering") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/PhotographicDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the photographic documentation of an object, e.g. a cultural property."</para>
    ///   <para>"Questa classe rappresenta la documentazione fotografica relativa a un oggetto, per esempio a un bene culturale."</para>
    /// labels<para>"Documentazione fotografica"</para><para>"Photographic documentation"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/PhotographicDocumentation">https://w3id.org/arco/ontology/context-description/PhotographicDocumentation</seealso>
    let PhotographicDocumentation =
        Prefixed_Name(cdesc, "PhotographicDocumentation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/PhotographicSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta una serie editoriale fotografica, ovvero un insieme di immagini ideate o pubblicate come un'unica entità, esplicitamente legate tra di loro da un titolo o da una numerazione progressiva o da altri elementi che ne individuino inequivocabilmente l'unitarietà in senso biblioteconomico."</para>
    ///   <para>"This class represents a photographic series, that is a set of photographs created or published as a unit, from a library sciences point of view."</para>
    /// labels<para>"Photographic series"</para><para>"Serie fotografica"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/PhotographicSeries">https://w3id.org/arco/ontology/context-description/PhotographicSeries</seealso>
    let PhotographicSeries = Prefixed_Name(cdesc, "PhotographicSeries") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/PhotographicSeriesMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta l'appartenenza di un bene fotografico a una serie editoriale, esplicitamente indicata da un titolo o da una numerazione progressiva o da altri elementi che ne individuino inequivocabilmente l'appartenenza."</para>
    ///   <para>"This class represents the membership of photographic heritage in a photographic series, as a unit."</para>
    /// labels<para>"Appartenenza a serie fotografica"</para><para>"Photographic series membership"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/PhotographicSeriesMembership">https://w3id.org/arco/ontology/context-description/PhotographicSeriesMembership</seealso>
    let PhotographicSeriesMembership =
        Prefixed_Name(cdesc, "PhotographicSeriesMembership") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/PhotographicSubseries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta una sottoserie di una serie editoriale fotografica, ovvero una partizione interna alla serie."</para>
    ///   <para>"This class represents a photographic subseries, that is a component of a photographic series."</para>
    /// labels<para>"Sottoserie fotografica"</para><para>"Photographic subseries"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/PhotographicSubseries">https://w3id.org/arco/ontology/context-description/PhotographicSubseries</seealso>
    let PhotographicSubseries =
        Prefixed_Name(cdesc, "PhotographicSubseries") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/PointAnomaly</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/context-description/AnomalyType</para>
    ///
    /// labels<para>"Anomalia puntuale"</para><para>"Point anomaly"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/PointAnomaly">https://w3id.org/arco/ontology/context-description/PointAnomaly</seealso>
    let PointAnomaly = Prefixed_Name(cdesc, "PointAnomaly") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/PolygonAnomaly</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/context-description/AnomalyType</para>
    ///
    /// labels<para>"Anomalia areale"</para><para>"Polygon anomaly"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/PolygonAnomaly">https://w3id.org/arco/ontology/context-description/PolygonAnomaly</seealso>
    let PolygonAnomaly = Prefixed_Name(cdesc, "PolygonAnomaly") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/PreferredAuthorshipAttribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta l'attribuzione di autore maggiormente accreditata o convincente."</para>
    ///   <para>"This class represents the preferred authorship attribution, most accredited or convincing."</para>
    /// labels<para>"Attribuzione Primaria di Autore"</para><para>"Preferred Authorship Attribution"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/PreferredAuthorshipAttribution">https://w3id.org/arco/ontology/context-description/PreferredAuthorshipAttribution</seealso>
    let PreferredAuthorshipAttribution =
        Prefixed_Name(cdesc, "PreferredAuthorshipAttribution") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/PreparatoryOrFinalWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta un'entità collegata a un bene culturale, che ne costituisce una fase preparatoria o una fase finale."</para>
    ///   <para>"This class represents an entity related to a cultural property, that is its preparatory or final stage."</para>
    /// labels<para>"Opera preparatoria o finale"</para><para>"Preparatory or final work"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/PreparatoryOrFinalWork">https://w3id.org/arco/ontology/context-description/PreparatoryOrFinalWork</seealso>
    let PreparatoryOrFinalWork =
        Prefixed_Name(cdesc, "PreparatoryOrFinalWork") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/PreparatoryWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta un'entità collegata a un bene culturale, che ne costituisce una fase preparatoria."</para>
    ///   <para>"This class represents an entity related to a cultural property, as its preparatory stage."</para>
    /// labels<para>"Opera preparatoria"</para><para>"Preparatory work"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/PreparatoryWork">https://w3id.org/arco/ontology/context-description/PreparatoryWork</seealso>
    let PreparatoryWork = Prefixed_Name(cdesc, "PreparatoryWork") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/PreviousUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/context-description/UseType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Questo individuo rappresenta l'uso precedente di un bene."</para>
    ///   <para>"This individual represents cultural enity's previous use."</para>
    /// labels<para>"Previous use"</para><para>"Uso precedente"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/PreviousUse">https://w3id.org/arco/ontology/context-description/PreviousUse</seealso>
    let PreviousUse = Prefixed_Name(cdesc, "PreviousUse") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/PrintInPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta la pubblicazione di cui una stampa è, o è stata, parte integrante."</para>
    ///   <para>"This class represents a publication of which a print is, or was, part."</para>
    /// labels<para>"Stampa in pubblicazione"</para><para>"Print in publication"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/PrintInPublication">https://w3id.org/arco/ontology/context-description/PrintInPublication</seealso>
    let PrintInPublication = Prefixed_Name(cdesc, "PrintInPublication") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/ProductionCycleCircumstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a circumstance related to production cycles (sericulture, cereal crop, etc.)"</para>
    ///   <para>"Questa classe rappresenta un'occasione connessa ai cicli produttivi (bachicoltura, cerealicoltura, etc.)"</para>
    /// labels<para>"Production cycle circumstance"</para><para>"Occasione legata al ciclo produttivo"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/ProductionCycleCircumstance">https://w3id.org/arco/ontology/context-description/ProductionCycleCircumstance</seealso>
    let ProductionCycleCircumstance =
        Prefixed_Name(cdesc, "ProductionCycleCircumstance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/Profession</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta il mestiere o la professione dell'utente del bene."</para>
    ///   <para>"This class represents the role of a cultural entity's user."</para>
    /// labels<para>"Professione"</para><para>"Profession"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/Profession">https://w3id.org/arco/ontology/context-description/Profession</seealso>
    let Profession = Prefixed_Name(cdesc, "Profession") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/ProperTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/context-description/TitleType</para>
    ///   <para>"It represents the title proper to subject of a print, an engraved matrix or a photograph."</para>
    ///   <para>"Rappresenta il titolo proprio del soggetto di una stampa, di una matrice incisa o di una fotografia. Per titolo proprio di una stampa si intende il titolo principale nella forma in cui appare sulla stampa o sulla matrice stessa. Per titolo proprio (principale) di una fotografia, si intende nella forma in cui appare nell'immagine (o su uno dei suoi supporti, o nelle schede a campi testuali, o nei commenti sonori presenti all'interno del file contenente l'immagine digitale). Per la normativa F, Il titolo proprio include anche ogni eventuale titolo alternativo (altre denominazioni dell'opera che appaiano insieme al titolo principale) e, facoltativamente, i complementi del titolo proprio (ossia sottotitoli od ulteriori indicazioni che contribuiscono a qualificare più specificamente il contenuto dell'immagine)."</para>
    /// labels<para>"Proper title"</para><para>"Titolo proprio"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/ProperTitle">https://w3id.org/arco/ontology/context-description/ProperTitle</seealso>
    let ProperTitle = Prefixed_Name(cdesc, "ProperTitle") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/ProtectiveMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the protective measure, national or international, related to a cultural property."</para>
    ///   <para>"Questa classe rappresenta un provvedimento di tutela nazionale o internazionale, che ha interessato un bene culturale."</para>
    /// labels<para>"Protective measure"</para><para>"Provvedimento di tutela"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/ProtectiveMeasure">https://w3id.org/arco/ontology/context-description/ProtectiveMeasure</seealso>
    let ProtectiveMeasure = Prefixed_Name(cdesc, "ProtectiveMeasure") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/RCSReason</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà rappresenta il codice della causale RCS (Ragioneria Centrale dello Stato) di aumento o diminuzione del valore del bene."</para>
    ///   <para>"This property represents the code of the RCS causal (Central State Accounting Office) of increasing or decreasing property value."</para>
    /// labels<para>"causale RCS"</para><para>"RCS reason"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/RCSReason">https://w3id.org/arco/ontology/context-description/RCSReason</seealso>
    let RCSReason = Prefixed_Name(cdesc, "RCSReason") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/ReferenceCatalogue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta il repertorio che cita la copia di una stampa."</para>
    ///   <para>"This class represents the reference catalogue that cites the copy of a print."</para>
    /// labels<para>"Repertorio"</para><para>"Reference catalogue"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/ReferenceCatalogue">https://w3id.org/arco/ontology/context-description/ReferenceCatalogue</seealso>
    let ReferenceCatalogue = Prefixed_Name(cdesc, "ReferenceCatalogue") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/RelatedWorkSituation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta la relazione, il rapporto, tra il bene culturale in esame e un'altra opera, che può anche essere un bene culturale. In riferimento a questo rapporto, si definisce lo stadio di realizzazione del bene culturale in rapporto con l'oggetto che ne costituisce una fase preparatoria o che ne rappresenta la fase finale o che ne rappresenta una derivazione. Nel caso di una relazione tra un bene culturale e un altro bene culturale, in riferimento a questo rapporto si definisce, se possibile, il tipo di relazione tra i due beni (es.: luogo di realizzazione, luogo di ritrovamento, etc.)."</para>
    ///   <para>"This class represents a situation in which a cultural property is related to another work, that could even be another cultural property. The cultural property stage is defined referring to this relationship with a related work, that can represent a preparatory, a final phase or a derivation of the cultural property. When the relationship is between two cultural properties, when possible, the nature of the relationship is specified (e.g.: finding location)"</para>
    /// labels<para>"Related work situation"</para><para>"Rapporto con opera collegata"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/RelatedWorkSituation">https://w3id.org/arco/ontology/context-description/RelatedWorkSituation</seealso>
    let RelatedWorkSituation =
        Prefixed_Name(cdesc, "RelatedWorkSituation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/Reliability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the reliability level of detected information relative to photo interpretation rendering."</para>
    ///   <para>"Questa classe rappresenta il livello di affidabilità delle informazioni rilevate nell'indagine di fotointerpretazione/fotorestituzione."</para>
    /// labels<para>"Reliability"</para><para>"Affidabilità"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/Reliability">https://w3id.org/arco/ontology/context-description/Reliability</seealso>
    let Reliability = Prefixed_Name(cdesc, "Reliability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/ReligiousCircumstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/context-description/CircumstanceType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Religious circumstance"</para><para>"Occasione religiosa"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/ReligiousCircumstance">https://w3id.org/arco/ontology/context-description/ReligiousCircumstance</seealso>
    let ReligiousCircumstance =
        Prefixed_Name(cdesc, "ReligiousCircumstance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/Reproduction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the reproduction of an image, that is, or was, part of a publication."</para>
    ///   <para>"Questa classe rappresenta la riproduzione dell'immagine contenuta nella pubblicazione di cui la stampa è, o è stata, parte integrante."</para>
    /// labels<para>"Riproduzione"</para><para>"Reproduction"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/Reproduction">https://w3id.org/arco/ontology/context-description/Reproduction</seealso>
    let Reproduction = Prefixed_Name(cdesc, "Reproduction") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/ReproductionPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta la posizione fisica della riproduzione della stampa all'interno della pubblicazione, che rappresenta quindi una derivazione della stampa stessa."</para>
    ///   <para>"This class represents the phisical position of a printed reproduction in a publication."</para>
    /// labels<para>"Reproduction position"</para><para>"Posizione della riproduzione"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/ReproductionPosition">https://w3id.org/arco/ontology/context-description/ReproductionPosition</seealso>
    let ReproductionPosition =
        Prefixed_Name(cdesc, "ReproductionPosition") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/Research</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta la ricerca nell'ambito della quale è stata redatta la scheda, intendendo con il termine "ricerca" vari e differenziati livelli, fra cui quello della campagna di catalogazione. La ricerca si può collegare al rilevamento di un bene musicale di interesse etno-organologico."</para>
    ///   <para>"This class represents the research in which the catalogue record describing a cultural property was recorded (e.g.: a cataloguing campaign). The research can be related to the observation survey on musical heritage."</para>
    /// labels<para>"Ricerca"</para><para>"Research"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/Research">https://w3id.org/arco/ontology/context-description/Research</seealso>
    let Research = Prefixed_Name(cdesc, "Research") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/Responsibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta l'individuazione di una responsabilità attribuibile a un agente relativamente ai processi di produzione e di divulgazione che caratterizzano specificamente i beni fotografici, quindi alle diverse personalità responsabili, a vario titolo, del ciclo produttivo del bene in esame, oltre che della sua circolazione, divulgazione, commercializzazione e promozione (committenti, stampatori, ritoccatori, coloritori, editori, distributori, sponsor, curatori e responsabili di edizioni e di serie, dedicanti e dedicatari, responsabili di collezioni e di collazioni, ecc.)."</para>
    ///   <para>"This class represents the attribution of a responsibility to an agent, relating to the activities of production and dissemination of photographic heritage (e.g.: committent, editor, printer, dedicatee, etc.)"</para>
    /// labels<para>"Responsibility"</para><para>"Responsabilità"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/Responsibility">https://w3id.org/arco/ontology/context-description/Responsibility</seealso>
    let Responsibility = Prefixed_Name(cdesc, "Responsibility") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/ResponsibilityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the type of responsibility related to the production and dissemination of photographic heritage (e.g.: printer, editor)"</para>
    ///   <para>"Questa classe rappresenta il tipo di responsabilità individuata relativamente ai processi di produzione e di divulgazione che caratterizzano specificamente i beni fotografici (es.: stampatori, ritoccatori, coloritori, ecc.)."</para>
    /// labels<para>"Responsibility type"</para><para>"Tipo di responsabilità"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/ResponsibilityType">https://w3id.org/arco/ontology/context-description/ResponsibilityType</seealso>
    let ResponsibilityType = Prefixed_Name(cdesc, "ResponsibilityType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/Reuse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/context-description/UseTypeSpecification</para>
    ///   <para>"This class represents cultural entity's reuse."</para>
    ///   <para>"Questa classe rappresenta il riuso subito dal bene catalogato o da una sua parte."</para>
    ///   <para>"This class represents the reuse of a cultural property or of one of its parts."</para>
    /// labels<para>"Reuse"</para><para>"Riuso"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/Reuse">https://w3id.org/arco/ontology/context-description/Reuse</seealso>
    let Reuse = Prefixed_Name(cdesc, "Reuse") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/SECCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta la categoria patrimoniale del bene, con riferimento alla classificazione del Sistema Europeo dei Conti 1995"</para>
    ///   <para>"This class represents the patrimonial category of a cultural property, referring to the SEC classification 1995."</para>
    /// labels<para>"Categoria SEC"</para><para>"SEC Category"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/SECCategory">https://w3id.org/arco/ontology/context-description/SECCategory</seealso>
    let SECCategory = Prefixed_Name(cdesc, "SECCategory") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/SECIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta il codice patrimoniale del bene (SEC - Modello 15), con riferimento alla classificazione del Sistema Europeo dei Conti 1995."</para>
    ///   <para>"This class represents the patrimonial code of a cultural property, referring to the SEC classification 1995."</para>
    /// labels<para>"Codice SEC"</para><para>"SEC Identifier"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/SECIdentifier">https://w3id.org/arco/ontology/context-description/SECIdentifier</seealso>
    let SECIdentifier = Prefixed_Name(cdesc, "SECIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/SameAuthorCopy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta una replica di un bene culturale, cioè una duplicazione dell'originale da parte dello stesso autore."</para>
    ///   <para>"This class represents a copy of a cultural property created by the same author of the original cultural property."</para>
    /// labels<para>"Replica"</para><para>"Same author copy"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/SameAuthorCopy">https://w3id.org/arco/ontology/context-description/SameAuthorCopy</seealso>
    let SameAuthorCopy = Prefixed_Name(cdesc, "SameAuthorCopy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/SatellitePhotograph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/context-description/SurveyImageType</para>
    ///
    /// labels<para>"Fotografia satellitare"</para><para>"Satellite photograph"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/SatellitePhotograph">https://w3id.org/arco/ontology/context-description/SatellitePhotograph</seealso>
    let SatellitePhotograph =
        Prefixed_Name(cdesc, "SatellitePhotograph") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/Scale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta le indicazioni sulla scala di rappresentazione della documentazione grafica e cartografica."</para>
    ///   <para>"This class represents the representative scale of a graphic or cartographic documentation."</para>
    /// labels<para>"Scale"</para><para>"Scala"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/Scale">https://w3id.org/arco/ontology/context-description/Scale</seealso>
    let Scale = Prefixed_Name(cdesc, "Scale") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/SeasonCycleCircumstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta un'occasione legata ai cicli stagionali, ovvero cicli che si riferiscono a: oggetto di concezioni, credenze, mito, scienza, di elaborazione in poesia, prosa, canto, arte e di culto; riferimento di attività, pratiche, comportamenti, di dati o fenomeni a particolari cicli, giorni, settimane, lunazioni, mesi, stagioni ecc.; giorni e periodi fausti e infausti."</para>
    ///   <para>"This class represents a circumstance related to seasonal cycles, referred to: subject of popular belief, myth, science; poetry, prose, songs, art, ritual; practical activities, behaviour, phenomena connected to specific cycles, days, months, seasons; fortunate or unfortunate days and periods."</para>
    /// labels<para>"Occasione legata al ciclo stagionale"</para><para>"Season cycle circumstance"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/SeasonCycleCircumstance">https://w3id.org/arco/ontology/context-description/SeasonCycleCircumstance</seealso>
    let SeasonCycleCircumstance =
        Prefixed_Name(cdesc, "SeasonCycleCircumstance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/SecondaryTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/context-description/TitleType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Questo individuo rappresenta il tipo di titolo secondario di una pubblicazione."</para>
    ///   <para>"This individual represents publication's secondary title."</para>
    /// labels<para>"Titolo secondario"</para><para>"Secondary title"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/SecondaryTitle">https://w3id.org/arco/ontology/context-description/SecondaryTitle</seealso>
    let SecondaryTitle = Prefixed_Name(cdesc, "SecondaryTitle") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/SexEstimate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/SexEstimate">https://w3id.org/arco/ontology/context-description/SexEstimate</seealso>
    let SexEstimate = Prefixed_Name(cdesc, "SexEstimate") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/SexInterpretation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta la stima del sesso di un reperto antropologico."</para>
    ///   <para>"This class represents the interpretation of the sex of an anthropological material."</para>
    /// labels<para>"Sex interpretation"</para><para>"Interpretazione del sesso"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/SexInterpretation">https://w3id.org/arco/ontology/context-description/SexInterpretation</seealso>
    let SexInterpretation = Prefixed_Name(cdesc, "SexInterpretation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/SocialInteractionCircumstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta un'occasione connessa alla socialità quotidiana (balli, caffè, veglie, osterie)"</para>
    ///   <para>"This class represents a circumstance related to social interaction (dances, pubs, wakes)"</para>
    /// labels<para>"Social interaction circumstance"</para><para>"Occasione legata alla socialità quotidiana"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/SocialInteractionCircumstance">https://w3id.org/arco/ontology/context-description/SocialInteractionCircumstance</seealso>
    let SocialInteractionCircumstance =
        Prefixed_Name(cdesc, "SocialInteractionCircumstance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/Source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/Source">https://w3id.org/arco/ontology/context-description/Source</seealso>
    let Source = Prefixed_Name(cdesc, "Source") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/SourceAndDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta le fonti e i documenti testuali editi e inediti relativi a un oggetto, per esempio a un bene culturale."</para>
    ///   <para>"This class represents source and document related to an object, e.g. a cultural property."</para>
    /// labels<para>"Fonti e documenti"</para><para>"Source and document"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/SourceAndDocument">https://w3id.org/arco/ontology/context-description/SourceAndDocument</seealso>
    let SourceAndDocument = Prefixed_Name(cdesc, "SourceAndDocument") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/Species</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta uno dei livelli di classificazione di una tassonomia biologica, ovvero la specie."</para>
    ///   <para>"This class represents one level of a biological taxon, the species."</para>
    /// labels<para>"Specie"</para><para>"Species"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/Species">https://w3id.org/arco/ontology/context-description/Species</seealso>
    let Species = Prefixed_Name(cdesc, "Species") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/SpecificBibliography</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/context-description/BibliographyCategory</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"This individual represents the definition related to the kind of bibliography that specifically concerns the subject under examination."</para>
    ///   <para>"Questo individuo rappresenta la definizione relativa al genere di bibliografia che riguarda in modo specifico il bene in esame."</para>
    /// labels<para>"Specific bibliography"</para><para>"Bibliografia specifica"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/SpecificBibliography">https://w3id.org/arco/ontology/context-description/SpecificBibliography</seealso>
    let SpecificBibliography =
        Prefixed_Name(cdesc, "SpecificBibliography") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/StratigraphicUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta l'unità stratigrafica dalla quale può provenire un bene culturale."</para>
    ///   <para>"This class represents a stratigraphic unit from which a cultural property may come from."</para>
    /// labels<para>"Unità stratigrafica"</para><para>"Stratigraphic unit"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/StratigraphicUnit">https://w3id.org/arco/ontology/context-description/StratigraphicUnit</seealso>
    let StratigraphicUnit = Prefixed_Name(cdesc, "StratigraphicUnit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/StructuralUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/context-description/UseTypeSpecification</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Questo individuo rappresenta le specifiche d'uso strutturale di un bene."</para>
    ///   <para>"This individual represents cultural entity's structural use specifications."</para>
    /// labels<para>"Structural use"</para><para>"Uso strutturale"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/StructuralUse">https://w3id.org/arco/ontology/context-description/StructuralUse</seealso>
    let StructuralUse = Prefixed_Name(cdesc, "StructuralUse") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/Subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta il soggetto rappresentato da un bene culturale o il suo motivo decorativo."</para>
    ///   <para>"This class represents the subject of a cultural property, or its ornamental motif."</para>
    /// labels<para>"Subject"</para><para>"Soggetto"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/Subject">https://w3id.org/arco/ontology/context-description/Subject</seealso>
    let Subject = Prefixed_Name(cdesc, "Subject") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/Subspecies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta uno dei livelli di classificazione di una tassonomia biologica, ovvero la sottospecie."</para>
    ///   <para>"This class represents one level of a biological taxon, the subspecies."</para>
    /// labels<para>"Sottospecie"</para><para>"Subspecies"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/Subspecies">https://w3id.org/arco/ontology/context-description/Subspecies</seealso>
    let Subspecies = Prefixed_Name(cdesc, "Subspecies") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/Survey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta un'indagine effettuata su un bene culturale. Per indagine, si intende un'attività che riguarda il bene, effettuata per la sua individuazione (nel caso dei beni archeologici), per il suo studio e per l'approfondimento delle sue caratteristiche tecniche (indagini di scavo, di ricognizione, indagini geognostiche, analisi di vario genere e tipo, etc.). Questa classe viene specializzata in sottoclassi, per la rappresentazione di tipologie di indagini specifiche."</para>
    ///   <para>"This class represents a survey carried out on a cultural property, that is an activity related to a cultural property and carried out for its identification, study or observation of its technical characteristics."</para>
    /// labels<para>"Survey"</para><para>"Indagine"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/Survey">https://w3id.org/arco/ontology/context-description/Survey</seealso>
    let Survey = Prefixed_Name(cdesc, "Survey") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/SurveyImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta l'immagine presa in esame nel corso di una fotointerpretazione o fotorestituzione."</para>
    ///   <para>"This class represents the image analysed during a photo interpretation or rendering survey."</para>
    /// labels<para>"Immagine di indagine"</para><para>"Survey Image"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/SurveyImage">https://w3id.org/arco/ontology/context-description/SurveyImage</seealso>
    let SurveyImage = Prefixed_Name(cdesc, "SurveyImage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/SurveyImageType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta un tipo di immagine analizzata in una indagine di fotointerpretazione e restituzione (fotografia aerea o fotografia satellitare)."</para>
    ///   <para>"This class represents the type of image analysed during a photo interpretation or rendering survey (aerial photograph, satellite photograph)."</para>
    /// labels<para>"Tipo di immagine di indagine"</para><para>"Survey image type"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/SurveyImageType">https://w3id.org/arco/ontology/context-description/SurveyImageType</seealso>
    let SurveyImageType = Prefixed_Name(cdesc, "SurveyImageType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/SurveyMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the archeological survey method adopted."</para>
    ///   <para>"Questa classe rappresenta il metodo di scavo archeologico o di ricognizione archeologica adottato nel corso dell'indagine. (es.: sondaggio, per strati stratigrafici, occasionale, sistematico, etc.)"</para>
    /// labels<para>"Metodo di indagine"</para><para>"Survey method"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/SurveyMethod">https://w3id.org/arco/ontology/context-description/SurveyMethod</seealso>
    let SurveyMethod = Prefixed_Name(cdesc, "SurveyMethod") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/SurveyMotivation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the main motivation of a survey."</para>
    ///   <para>"Questa classe rappresenta il motivo principale che ha determinato una ricognizione archeologica o uno scavo archeologico."</para>
    /// labels<para>"Motivo di indagine"</para><para>"Survey Motivation"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/SurveyMotivation">https://w3id.org/arco/ontology/context-description/SurveyMotivation</seealso>
    let SurveyMotivation = Prefixed_Name(cdesc, "SurveyMotivation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/TemporaryExportLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/context-description/ExportImportCertificationType</para>
    ///
    /// labels<para>"Licenza di esportazione temporanea"</para><para>"Temporary export license"</para><para>"provvisoria"</para><para>"unstable"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/TemporaryExportLicense">https://w3id.org/arco/ontology/context-description/TemporaryExportLicense</seealso>
    let TemporaryExportLicense =
        Prefixed_Name(cdesc, "TemporaryExportLicense") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/TemporaryMovementCertification</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/context-description/ExportImportCertificationType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Attestato di circolazione temporanea"</para><para>"Temporary movement certification"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/TemporaryMovementCertification">https://w3id.org/arco/ontology/context-description/TemporaryMovementCertification</seealso>
    let TemporaryMovementCertification =
        Prefixed_Name(cdesc, "TemporaryMovementCertification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/Title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the title of an object, e.g. the title of the subject represented by a cultural property, or the title of a photographic series, etc."</para>
    ///   <para>"Questa classe rappresenta il titolo di un oggetto. Nel caso del dominio dei beni culturali, può rappresentare il titolo del soggetto di un bene culturale o di un'opera collegata a un bene culturale in quanto sua fase preparatoria o finale o in quanto pubblicazione contenente una stampa, oppure il titolo di una serie fotografica, etc."</para>
    /// labels<para>"Title"</para><para>"Titolo"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/Title">https://w3id.org/arco/ontology/context-description/Title</seealso>
    let Title = Prefixed_Name(cdesc, "Title") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/TitleType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta il tipo di titolo di un oggetto (es.: originario, alternativo)."</para>
    ///   <para>"This class represents the type of an object title (e.g. original, alternative)"</para>
    /// labels<para>"Tipo di Titolo"</para><para>"Title Type"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/TitleType">https://w3id.org/arco/ontology/context-description/TitleType</seealso>
    let TitleType = Prefixed_Name(cdesc, "TitleType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/Tomb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a tomb."</para>
    ///   <para>"Questa classe rappresenta una deposizione funeraria."</para>
    /// labels<para>"Deposizione funeraria"</para><para>"Tomb"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/Tomb">https://w3id.org/arco/ontology/context-description/Tomb</seealso>
    let Tomb = Prefixed_Name(cdesc, "Tomb") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/UncertainOrigin</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/context-description/AnomalyOrigin</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Uncertain origin"</para><para>"Origine incerta"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/UncertainOrigin">https://w3id.org/arco/ontology/context-description/UncertainOrigin</seealso>
    let UncertainOrigin = Prefixed_Name(cdesc, "UncertainOrigin") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/UrbanPlanningInstrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta uno strumento urbanistico-territoriale, ovvero un piano regolatore generale e particolareggiato o un piano paesaggistico che interessa un bene culturale."</para>
    ///   <para>"This class represents a urban planning instrument, related to a cultural property."</para>
    /// labels<para>"Urban planning instrument"</para><para>"Strumento urbanistico-territoriale"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/UrbanPlanningInstrument">https://w3id.org/arco/ontology/context-description/UrbanPlanningInstrument</seealso>
    let UrbanPlanningInstrument =
        Prefixed_Name(cdesc, "UrbanPlanningInstrument") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/Use</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta l'uso del bene, che può variare nel corso del tempo, a seconda delle diverse occasioni e delle parti utilizzate del bene."</para>
    ///   <para>"This class represents the use of a cultural property, that can change over time, depending on the circumstances and on which parts of the cultural property are used."</para>
    /// labels<para>"Use"</para><para>"Uso"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/Use">https://w3id.org/arco/ontology/context-description/Use</seealso>
    let Use = Prefixed_Name(cdesc, "Use") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/UseFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the use function of an object."</para>
    ///   <para>"Questa classe rappresenta la funzione d'uso che ha un oggetto."</para>
    /// labels<para>"Use function"</para><para>"Funzione d'uso"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/UseFunction">https://w3id.org/arco/ontology/context-description/UseFunction</seealso>
    let UseFunction = Prefixed_Name(cdesc, "UseFunction") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/UseType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta il tipo di uso del bene (attuale, precedente, storico o dato non disponibile)."</para>
    ///   <para>"This class represents the type of use of a cultural property (current, previous, historical)"</para>
    /// labels<para>"Use type"</para><para>"Tipo d'uso"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/UseType">https://w3id.org/arco/ontology/context-description/UseType</seealso>
    let UseType = Prefixed_Name(cdesc, "UseType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/UseTypeSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the specification of the type of use of a cultural property (e.g. building, ornamental, structural, instrumental)"</para>
    ///   <para>"Questa classe rappresenta le specifiche sul tipo di uso del bene (reimpiego, edilizio, epigrafico, ornamentale, strumentale, strutturale)."</para>
    /// labels<para>"Use type specification"</para><para>"Specifiche del tipo d'uso"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/UseTypeSpecification">https://w3id.org/arco/ontology/context-description/UseTypeSpecification</seealso>
    let UseTypeSpecification =
        Prefixed_Name(cdesc, "UseTypeSpecification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/UseTypeUnavailable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/context-description/UseType</para>
    ///   <para>"Questo individuo rappresenta la mancanza di dati disponibili relativamente al tipo di uso di un bene."</para>
    ///   <para>"This individual represents the lack of available data regarding the type of use of a cultural entity."</para>
    /// labels<para>"Use type unavailable"</para><para>"Tipo di uso non disponibile"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/UseTypeUnavailable">https://w3id.org/arco/ontology/context-description/UseTypeUnavailable</seealso>
    let UseTypeUnavailable = Prefixed_Name(cdesc, "UseTypeUnavailable") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/UserSocialCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta la categoria sociale a cui appartiene l'utente del bene."</para>
    ///   <para>"This class represents the social category of a user (e.g. of a cultural property)"</para>
    /// labels<para>"User social category"</para><para>"Categoria sociale dell'utente"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/UserSocialCategory">https://w3id.org/arco/ontology/context-description/UserSocialCategory</seealso>
    let UserSocialCategory = Prefixed_Name(cdesc, "UserSocialCategory") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/WorkCircumstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a circumstance related to work (e.g.: agriculture, bakery)"</para>
    ///   <para>"Questa classe rappresenta un'occasione connessa al lavoro (es.: panificazione, agricoltura)"</para>
    /// labels<para>"Work circumstance"</para><para>"Occasione legata al lavoro"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/WorkCircumstance">https://w3id.org/arco/ontology/context-description/WorkCircumstance</seealso>
    let WorkCircumstance = Prefixed_Name(cdesc, "WorkCircumstance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/YearCycleCircumstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a circumstance related to year cycles (e.g.: autumnal equinox, New Year's Eve, Lent, Ramadan, carnival, etc.)"</para>
    ///   <para>"Questa classe rappresenta un'occasione legata ai cicli dell'anno (es.: equinozio autunno, capodanno, Quaresima, Ramadan, carnevale, etc.)"</para>
    /// labels<para>"Year cycle circumstance"</para><para>"Occasione legata al ciclo dell'anno"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/YearCycleCircumstance">https://w3id.org/arco/ontology/context-description/YearCycleCircumstance</seealso>
    let YearCycleCircumstance =
        Prefixed_Name(cdesc, "YearCycleCircumstance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/abbreviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà rappresenta l'abbreviazione che identifica il riferimento bibliografico."</para>
    ///   <para>"This property represents the abbreviation that identifies the bibliographic reference."</para>
    /// labels<para>"abbreviazione"</para><para>"abbreviation"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/abbreviation">https://w3id.org/arco/ontology/context-description/abbreviation</seealso>
    let abbreviation = Prefixed_Name(cdesc, "abbreviation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/acquisitionLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà rappresenta il luogo in cui è avvenuto un evento di acquisizione, generalmente espresso, in base ai dati disponibili, nella forma: "Regione/sigla provincia/denominazione per esteso del Comune/località o toponimo""</para>
    ///   <para>"This property represents the place where an acquisition event, generally expressed, based on the available data, took place, in the form: "Region / abbreviation province / full name of the Municipality / locality or toponym""</para>
    /// labels<para>"acquisition location"</para><para>"luogo di acquisizione"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/acquisitionLocation">https://w3id.org/arco/ontology/context-description/acquisitionLocation</seealso>
    let acquisitionLocation =
        Prefixed_Name(cdesc, "acquisitionLocation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/address</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà rappresenta l'indirizzo di riferimento di un agente (persona, organizzazione), inteso come un tipo specifico di contatto presso il quale l'agente è reperibile."</para>
    ///   <para>"This property represents a specific type of contact at which the agent is available."</para>
    /// labels<para>"indirizzo"</para><para>"address"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/address">https://w3id.org/arco/ontology/context-description/address</seealso>
    let address = Prefixed_Name(cdesc, "address") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/ageOfDeath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This property represents an anthropological finding estimated age of death."</para>
    ///   <para>"Questa proprietà rappresenta l'età della morte stimata nel contesto della stima dell'età della morte di un reperto antropologico."</para>
    /// labels<para>"estimated age of death"</para><para>"età della morte stimata"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/ageOfDeath">https://w3id.org/arco/ontology/context-description/ageOfDeath</seealso>
    let ageOfDeath = Prefixed_Name(cdesc, "ageOfDeath") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/agentDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property allows you to associate generic chronological indications to an agent."</para>
    ///   <para>"Questa proprietà permette di associare delle indicazioni cronologiche generiche (le date di nascita e di morte o, quando queste sono ignote, le date di attività), anche sotto forma testuale, a un agente."</para>
    /// labels<para>"indicazioni cronologiche relative a un agente"</para><para>"agent date"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/agentDate">https://w3id.org/arco/ontology/context-description/agentDate</seealso>
    let agentDate = Prefixed_Name(cdesc, "agentDate") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/agentLocalIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents the identification code, which identifies the author's reference unambiguously in the context of a local repertoire, of an agent."</para>
    ///   <para>"Questa proprietà rappresenta il codice identificativo, che individua il riferimento autoriale in modo univoco nell'ambito di un repertorio locale, di un agente, per esempio di un autore di un bene culturale o di un agente che riveste una responsabilità nei confronti del bene (es.: editore, stampatore, etc.)."</para>
    /// labels<para>"codice identificativo locale dell'agente"</para><para>"agent local identifier"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/agentLocalIdentifier">https://w3id.org/arco/ontology/context-description/agentLocalIdentifier</seealso>
    let agentLocalIdentifier =
        Prefixed_Name(cdesc, "agentLocalIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/alternativeTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents an entity's alternative title."</para>
    ///   <para>"Questa proprietà rappresenta un altro titolo noto del soggetto, in alternativa o in aggiunta al titolo più noto o accreditato."</para>
    /// labels<para>"alternative title"</para><para>"titolo alternativo"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/alternativeTitle">https://w3id.org/arco/ontology/context-description/alternativeTitle</seealso>
    let alternativeTitle = Prefixed_Name(cdesc, "alternativeTitle") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/archaeologicalExcavationICCDIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents the code, assigned by the ICCD, which identifies the archaeological excavation unequivocally at national level."</para>
    ///   <para>"Questa proprietà rappresenta il codice, assegnato dall'ICCD, che individua lo scavo archeologico in modo univoco a livello nazionale."</para>
    /// labels<para>"codice univoco ICCD dello scavo archeologico"</para><para>"archaeological excavation ICCD identifier"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/archaeologicalExcavationICCDIdentifier">https://w3id.org/arco/ontology/context-description/archaeologicalExcavationICCDIdentifier</seealso>
    let archaeologicalExcavationICCDIdentifier =
        Prefixed_Name(cdesc, "archaeologicalExcavationICCDIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/archaeologicalExcavationLocalIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà rappresenta il codice identificativo, numerico o alfanumerico, che individua lo scavo archeologico in modo univoco nell'ambito di un repertorio locale."</para>
    ///   <para>"This property represents the identification code, numeric or alphanumeric, which identifies the archaeological excavation unambiguously in the context of a local repertoire."</para>
    /// labels<para>"archaeological excavation local identifier"</para><para>"codice identificativo locale dello scavo archeologico"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/archaeologicalExcavationLocalIdentifier">https://w3id.org/arco/ontology/context-description/archaeologicalExcavationLocalIdentifier</seealso>
    let archaeologicalExcavationLocalIdentifier =
        Prefixed_Name(cdesc, "archaeologicalExcavationLocalIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/archaeologicalFieldSurveyICCDIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This property represents the code, assigned by the ICCD, which identifies the field survey unequivocally at national level."</para>
    ///   <para>"Questa proprietà rappresenta il codice, assegnato dall'ICCD, che individua il la ricognizione archeologica in modo univoco a livello nazionale."</para>
    /// labels<para>"archaeological field survey ICCD identifier"</para><para>"codice univoco ICCD della ricognizione archeologica"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/archaeologicalFieldSurveyICCDIdentifier">https://w3id.org/arco/ontology/context-description/archaeologicalFieldSurveyICCDIdentifier</seealso>
    let archaeologicalFieldSurveyICCDIdentifier =
        Prefixed_Name(cdesc, "archaeologicalFieldSurveyICCDIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/archeologicalFieldSurveyLocalIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Questa proprietà rappresenta il codice identificativo, numerico o alfanumerico, che individua la ricognizione archeologica in modo univoco nell'ambito di un repertorio locale."</para>
    ///   <para>"This property represents the identification code, numeric or alphanumeric, which identifies the field survey unambiguously in the context of a local repertoire."</para>
    /// labels<para>"codice identificativo locale della ricognizione archeologica"</para><para>"archaeological field survey local identifier"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/archeologicalFieldSurveyLocalIdentifier">https://w3id.org/arco/ontology/context-description/archeologicalFieldSurveyLocalIdentifier</seealso>
    let archeologicalFieldSurveyLocalIdentifier =
        Prefixed_Name(cdesc, "archeologicalFieldSurveyLocalIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/archivalRecordIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents the identifier of an archival record."</para>
    ///   <para>"Questa proprietà rappresenta l'identificativo di un'unità documentaria."</para>
    /// labels<para>"identificativo di unità documentaria"</para><para>"archival record identifier"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/archivalRecordIdentifier">https://w3id.org/arco/ontology/context-description/archivalRecordIdentifier</seealso>
    let archivalRecordIdentifier =
        Prefixed_Name(cdesc, "archivalRecordIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/archivalRecordLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents the location of a documentary unit within a complex archival unit."</para>
    ///   <para>"Questa proprietà rappresenta la collocazione di un'unità documentaria all'interno di un'unità archivistica complessa."</para>
    /// labels<para>"collocazione di unità documentaria"</para><para>"archival record location"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/archivalRecordLocation">https://w3id.org/arco/ontology/context-description/archivalRecordLocation</seealso>
    let archivalRecordLocation =
        Prefixed_Name(cdesc, "archivalRecordLocation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/archivalRecordSetIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This property represents the identifier of an archival record set."</para>
    ///   <para>"Questa proprietà rappresenta l'identificativo di un'unità archivistica complessa."</para>
    /// labels<para>"archival record set identifier"</para><para>"identificativo di unità archivistica complessa"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/archivalRecordSetIdentifier">https://w3id.org/arco/ontology/context-description/archivalRecordSetIdentifier</seealso>
    let archivalRecordSetIdentifier =
        Prefixed_Name(cdesc, "archivalRecordSetIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/archivalRecordSetTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents the title of the archival record set in which a documentary unit is located."</para>
    ///   <para>"Questa proprietà rappresenta il titolo dell'unità archivistica complessa (fondo, serie, sottoserie, etc.) in cui si trova un'unità documentaria."</para>
    /// labels<para>"archival record set title"</para><para>"titolo di unità archivistica complessa"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/archivalRecordSetTitle">https://w3id.org/arco/ontology/context-description/archivalRecordSetTitle</seealso>
    let archivalRecordSetTitle =
        Prefixed_Name(cdesc, "archivalRecordSetTitle") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/areaRoomSquare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà collega uno scavo archeologico alla successione delle denominazioni, assegnate nell'ambito dello scavo, al settore (o
    /// l'area), all'ambiente e al quadrato da cui proviene il bene."</para>
    ///   <para>"This property relates an archaeological excavation to the succession of the denominations, assigned in the excavation, to the sector (or
    /// the area), to the environment and to the square from which the good comes."</para>
    /// labels<para>"area room square"</para><para>"settore ambiente quadrato"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/areaRoomSquare">https://w3id.org/arco/ontology/context-description/areaRoomSquare</seealso>
    let areaRoomSquare = Prefixed_Name(cdesc, "areaRoomSquare") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/attributedTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà rappresenta un titolo attribuito di una fotografia, cioè un titolo desunto, se possibile, da fonti archivistiche, bibliografiche, orali o iconografiche (altri esemplari della stessa immagine) oppure creato in base al contenuto dell'immagine (o della serie di immagini; è necessario nei casi in cui siano del tutto assenti titoli sul/nel documento, o su materiali ad esso complementari, e nel caso in cui tali titoli risultino errati."</para>
    ///   <para>"This property represents an attributed title of a photograph, that is a title taken from archival, bibliographic, oral or iconographic sources, or created based on picture contents."</para>
    /// labels<para>"attributed title"</para><para>"titolo attribuito"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/attributedTitle">https://w3id.org/arco/ontology/context-description/attributedTitle</seealso>
    let attributedTitle = Prefixed_Name(cdesc, "attributedTitle") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/authorICCDIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property allows you to associate the unique ICCD code with an author."</para>
    ///   <para>"Questa proprietà permette di associare il codice univoco ICCD a un autore."</para>
    /// labels<para>"author ICCD identifier"</para><para>"codice univoco ICCD dell'autore"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/authorICCDIdentifier">https://w3id.org/arco/ontology/context-description/authorICCDIdentifier</seealso>
    let authorICCDIdentifier =
        Prefixed_Name(cdesc, "authorICCDIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/authorIntervention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This property represents specifications relating to the intervention carried out by the author on the cultural property."</para>
    ///   <para>"Questa proprietà rappresenta specifiche relative all'intervento effettuato dall'autore sul bene culturale."</para>
    /// labels<para>"author intervention"</para><para>"intervento dell'autore"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/authorIntervention">https://w3id.org/arco/ontology/context-description/authorIntervention</seealso>
    let authorIntervention = Prefixed_Name(cdesc, "authorIntervention") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/bibliographyICCDIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà rappresenta il codice, assegnato dall'ICCD, che individua il riferimento bibliografico in modo univoco a livello nazionale."</para>
    ///   <para>"This property represents the code, assigned by the ICCD, which identifies the bibliographic reference uniquely at national level."</para>
    /// labels<para>"codice univoco ICCD della bibliografia"</para><para>"bibliography ICCD identifier"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/bibliographyICCDIdentifier">https://w3id.org/arco/ontology/context-description/bibliographyICCDIdentifier</seealso>
    let bibliographyICCDIdentifier =
        Prefixed_Name(cdesc, "bibliographyICCDIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/bibliographyLocalIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà rappresenta una sequenza numerica o alfanumerica che identifica il riferimento bibliografico in modo univoco nell'ambito di un repertorio locale."</para>
    ///   <para>"This property represents a numerical or alphanumeric sequence that uniquely identifies the bibliographic reference within a local repertoire."</para>
    /// labels<para>"bibliography local identifier"</para><para>"codice identificativo locale della bibliografia"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/bibliographyLocalIdentifier">https://w3id.org/arco/ontology/context-description/bibliographyLocalIdentifier</seealso>
    let bibliographyLocalIdentifier =
        Prefixed_Name(cdesc, "bibliographyLocalIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/caption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà rappresenta una sintetica didascalia, se presente e utile alla comprensione di quanto documentato."</para>
    ///   <para>"This property represents a synthetic caption, useful for understanding what is documented."</para>
    /// labels<para>"didascalia"</para><para>"caption"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/caption">https://w3id.org/arco/ontology/context-description/caption</seealso>
    let caption = Prefixed_Name(cdesc, "caption") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/claySpecifications</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà rappresenta le specifiche su eventuali componenti significativi per lo studio del bene, nel caso di analisi su reperti in argilla."</para>
    ///   <para>"This property represents specifications on any significant components for the study of the entity, in case of analysis on clay findings."</para>
    /// labels<para>"specifiche su pasta/argilla"</para><para>"clay specifications"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/claySpecifications">https://w3id.org/arco/ontology/context-description/claySpecifications</seealso>
    let claySpecifications = Prefixed_Name(cdesc, "claySpecifications") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/collectionIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This property represents the collection identifier."</para>
    ///   <para>"Questa proprietà rappresenta il codice identificativo di una collezione."</para>
    /// labels<para>"codice della collezione"</para><para>"collection identifier"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/collectionIdentifier">https://w3id.org/arco/ontology/context-description/collectionIdentifier</seealso>
    let collectionIdentifier =
        Prefixed_Name(cdesc, "collectionIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/collectionLeavingReason</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents the reason that led a cultural entity to the exit from a collection."</para>
    ///   <para>"Questa proprietà rappresenta il motivo che ha determinato l'uscita da una collezione di un bene culturale."</para>
    /// labels<para>"motivo di uscita dalla collezione"</para><para>"collection leaving reason"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/collectionLeavingReason">https://w3id.org/arco/ontology/context-description/collectionLeavingReason</seealso>
    let collectionLeavingReason =
        Prefixed_Name(cdesc, "collectionLeavingReason") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/collectionUnitIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà rappresenta il codice d'inventario attribuito al bene nella collezione."</para>
    ///   <para>"This property represents the inventory code assigned to the cultural entity inside a collection."</para>
    /// labels<para>"codice inventario bene in collezione"</para><para>"collection unit inventory identifier"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/collectionUnitIdentifier">https://w3id.org/arco/ontology/context-description/collectionUnitIdentifier</seealso>
    let collectionUnitIdentifier =
        Prefixed_Name(cdesc, "collectionUnitIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/completeBibliographicReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Questa proprietà rappresenta il riferimento bibliografico completo."</para>
    ///   <para>"This property represents the complete bibliographic reference."</para>
    /// labels<para>"complete bibliographic reference"</para><para>"riferimento bibliografico completo"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/completeBibliographicReference">https://w3id.org/arco/ontology/context-description/completeBibliographicReference</seealso>
    let completeBibliographicReference =
        Prefixed_Name(cdesc, "completeBibliographicReference") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/contacts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà rappresenta i contatti di riferimento di un agente (persona, organizzazione), es. indirizzo, numeri di telefono e di fax, indirizzi di posta elettronica, ecc."</para>
    ///   <para>"This property represents contacts of an agent (i.e. email, telephone number...)"</para>
    /// labels<para>"contacts"</para><para>"contatti"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/contacts">https://w3id.org/arco/ontology/context-description/contacts</seealso>
    let contacts = Prefixed_Name(cdesc, "contacts") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/culturalPropertyInventoryDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents a cultural entity inventory description."</para>
    ///   <para>"Questa proprietà rappresenta la descrizione patrimoniale del bene, con riferimento a quanto inserito nel modello 15 RCS a cura dell'ente competente per tutela. Il dato viene richiesto direttamente agli uffici di catalogo/inventario dei relativi Istituti."</para>
    /// labels<para>"cultural property inventory description"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/culturalPropertyInventoryDescription">https://w3id.org/arco/ontology/context-description/culturalPropertyInventoryDescription</seealso>
    let culturalPropertyInventoryDescription =
        Prefixed_Name(cdesc, "culturalPropertyInventoryDescription") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/derivatedWorkLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà rappresenta la localizzazione geografica e collocazione specifica dell'opera derivata dal bene culturale."</para>
    ///   <para>"This property represents derivated work's geographical and specific location."</para>
    /// labels<para>"derivated work location"</para><para>"collocazione dell'opera derivata"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/derivatedWorkLocation">https://w3id.org/arco/ontology/context-description/derivatedWorkLocation</seealso>
    let derivatedWorkLocation =
        Prefixed_Name(cdesc, "derivatedWorkLocation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/diagnosis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents the diagnosis of an anthropological finding paleopathology."</para>
    ///   <para>"Questa proprietà rappresenta la diagnosi di una paleopatologia di un reperto antropologico."</para>
    /// labels<para>"diagnosis"</para><para>"diagnosi"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/diagnosis">https://w3id.org/arco/ontology/context-description/diagnosis</seealso>
    let diagnosis = Prefixed_Name(cdesc, "diagnosis") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/digitalFilename</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents the name of the digital file that reproduces the document."</para>
    ///   <para>"Questa proprietà rappresenta il nome del file digitale che riproduce il documento, nel caso della documentazione allegata alla scheda di catalogo."</para>
    /// labels<para>"nome del file digitale"</para><para>"digital filename"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/digitalFilename">https://w3id.org/arco/ontology/context-description/digitalFilename</seealso>
    let digitalFilename = Prefixed_Name(cdesc, "digitalFilename") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/documentationIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà rappresenta una sequenza numerica o alfanumerica che identifica la scheda a cui il documento si riferisce."</para>
    ///   <para>"This property represents a numeric or alphanumeric sequence that identifies the record to which the document refers."</para>
    /// labels<para>"documentation identifier"</para><para>"codice identificativo della documentazione"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/documentationIdentifier">https://w3id.org/arco/ontology/context-description/documentationIdentifier</seealso>
    let documentationIdentifier =
        Prefixed_Name(cdesc, "documentationIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/documentationLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà rappresenta la collocazione del documento, che può anche essere espressa per mezzo della collocazione inventariale o dell'identificativo (numerico o alfanumerico) della fonte o del documento."</para>
    ///   <para>"This property represents document location, which can also be expressed by inventory location or identifier."</para>
    /// labels<para>"collocazione della documentazione"</para><para>"documentation location"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/documentationLocation">https://w3id.org/arco/ontology/context-description/documentationLocation</seealso>
    let documentationLocation =
        Prefixed_Name(cdesc, "documentationLocation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/documentationTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents document title or denomination."</para>
    ///   <para>"Questa proprietà rappresenta il titolo o la denominazione del documento."</para>
    /// labels<para>"titolo della documentazione"</para><para>"documentation title"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/documentationTitle">https://w3id.org/arco/ontology/context-description/documentationTitle</seealso>
    let documentationTitle = Prefixed_Name(cdesc, "documentationTitle") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/editionLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents work's edition place."</para>
    ///   <para>"Questa proprietà rappresenta il luogo dell'edizione di un'opera."</para>
    /// labels<para>"luogo dell'edizione"</para><para>"edition location"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/editionLocation">https://w3id.org/arco/ontology/context-description/editionLocation</seealso>
    let editionLocation = Prefixed_Name(cdesc, "editionLocation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/environmentalState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà collega una ricognizione archeologica alla situazione ambientale al momento della ricognizione."</para>
    ///   <para>"This property relates an archaeological survey to environmental situation."</para>
    /// labels<para>"situazione ambientale"</para><para>"environmental state"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/environmentalState">https://w3id.org/arco/ontology/context-description/environmentalState</seealso>
    let environmentalState = Prefixed_Name(cdesc, "environmentalState") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/estimatedCulturalPropertyValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents cultural entity's economic value.. The value is preceded by the currency specification."</para>
    ///   <para>"Questa proprietà rappresenta il valore economico di un bene culturale. Nel caso di una collezione, questa proprietà rappresenta il valore del bene desunto, quando presente, dall'inventario della collezione o dal suo prezzo di acquisto o vendita. Nel caso di un inventario patrimoniale, questa proprietà rappresenta la stima patrimoniale del bene. Il valore viene preceduto dalla specifica della valuta."</para>
    /// labels<para>"valore del bene culturale"</para><para>"cultural property value"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/estimatedCulturalPropertyValue">https://w3id.org/arco/ontology/context-description/estimatedCulturalPropertyValue</seealso>
    let estimatedCulturalPropertyValue =
        Prefixed_Name(cdesc, "estimatedCulturalPropertyValue") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/estimatedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà rappresenta il valore stimato durante il processo di stima di un'entità."</para>
    ///   <para>"This property represents the value estimated in the context of an estimate process."</para>
    /// labels<para>"estimated value"</para><para>"valore stimato"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/estimatedValue">https://w3id.org/arco/ontology/context-description/estimatedValue</seealso>
    let estimatedValue = Prefixed_Name(cdesc, "estimatedValue") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/expiryDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents an expiration date."</para>
    ///   <para>"Questa proprietà rappresenta una data di scadenza, per esempio la data di scadenza dei diritti d'autore su un oggetto (come un bene culturale)."</para>
    /// labels<para>"expiry date"</para><para>"data di scadenza"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/expiryDate">https://w3id.org/arco/ontology/context-description/expiryDate</seealso>
    let expiryDate = Prefixed_Name(cdesc, "expiryDate") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/explanationNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà permette di rappresentare l'interpretazione di un bene culturale, ricavabile dall'osservazione diretta e dai dati conoscitivi disponibili."</para>
    ///   <para>"This property represents a cultural asset interpretation."</para>
    /// labels<para>"note interpretative"</para><para>"explanation note"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/explanationNote">https://w3id.org/arco/ontology/context-description/explanationNote</seealso>
    let explanationNote = Prefixed_Name(cdesc, "explanationNote") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/findingNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà rappresenta le note relative alle modalità di individuazione e di reperimento del bene in esame, in forma di testo libero. Possono essere integrative rispetto a quanto rappresentato come Scavo Archeologico o Ricognizione Archeologica, oppure possono essere le uniche informazioni registrate sull'individuazione e il reperimento del bene, in quelle situazioni in cui i dati a disposizione non consentono di compilare le schede di Authority file RCG-Ricognizione archeologica e/o DSC-Scavo archeologico. Vengono quindi collegate direttamente al bene."</para>
    ///   <para>"This property represents notes relating to methods for identifying and finding the cultural property in question."</para>
    /// labels<para>"finding note"</para><para>"note di reperimento"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/findingNote">https://w3id.org/arco/ontology/context-description/findingNote</seealso>
    let findingNote = Prefixed_Name(cdesc, "findingNote") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/folio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà codifica il numero di foglio o di carta del documento per la classe di documentazione Fonti e documenti."</para>
    ///   <para>"This property represent document's folio number."</para>
    /// labels<para>"folio"</para><para>"foglio"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/folio">https://w3id.org/arco/ontology/context-description/folio</seealso>
    let folio = Prefixed_Name(cdesc, "folio") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/framework</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà rappresenta la situazione in cui si svolge l'intervento di restauro. Nel caso in cui l’intervento sul bene sia in corso al momento della schedatura e non risulti ancora concluso, il valore di questa proprietà sarà "intervento in corso" con l'eventuale indicazione del luogo presso cui si sta effettuando."</para>
    ///   <para>"This property represents the framework in which the restoration is carried out."</para>
    /// labels<para>"situazione"</para><para>"framework"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/framework">https://w3id.org/arco/ontology/context-description/framework</seealso>
    let framework = Prefixed_Name(cdesc, "framework") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasAcquisition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a cultual property involved in an acquisition event to the actual acquisition."</para>
    ///   <para>"Questa proprietà collega un bene culturale coinvolto in un evento di acquisizione all'acquisizione stessa."</para>
    /// labels<para>"ha acquisizione"</para><para>"has acquisition"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasAcquisition">https://w3id.org/arco/ontology/context-description/hasAcquisition</seealso>
    let hasAcquisition = Prefixed_Name(cdesc, "hasAcquisition") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasAcquisitionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Questa proprietà collega un'acquisizione di un bene culturale al tipo di acquisizione (es.: donazione, alienazione, confisca)."</para>
    ///   <para>"This property relates a cultural entity's acquisition to its acquisition type (i.e. donation, seizure)."</para>
    /// labels<para>"ha tipo di acquisizione"</para><para>"has acquisition type"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasAcquisitionType">https://w3id.org/arco/ontology/context-description/hasAcquisitionType</seealso>
    let hasAcquisitionType = Prefixed_Name(cdesc, "hasAcquisitionType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasActivityOperator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates an activity to the agent who performed the activity. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness."</para>
    ///   <para>"Questa proprietà collega un'attività (per esempio, un'indagine o un intervento su un bene culturale) all'operatore dell'attività. La relazione tra il ruolo e l'agente che lo riveste è espressa nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe AgentRole, che permette di collegare l'agente e il suo ruolo."</para>
    /// labels<para>"ha operatore dell'attività"</para><para>"has activity operator"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasActivityOperator">https://w3id.org/arco/ontology/context-description/hasActivityOperator</seealso>
    let hasActivityOperator =
        Prefixed_Name(cdesc, "hasActivityOperator") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasActivityResponsible</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un'attività (per esempio, un'indagine o un intervento su un bene culturale) all'ente o al soggetto responsabile del rilevamento. La relazione tra il ruolo e l'agente che lo riveste è espressa nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe AgentRole, che permette di collegare l'agente e il suo ruolo."</para>
    ///   <para>"This property relates an activity to the institution or the survey's responsible entity. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness."</para>
    /// labels<para>"ha responsabile dell'attività"</para><para>"has activity responsible"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasActivityResponsible">https://w3id.org/arco/ontology/context-description/hasActivityResponsible</seealso>
    let hasActivityResponsible =
        Prefixed_Name(cdesc, "hasActivityResponsible") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasActivitySponsor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates an activity to its investor. The investor may be an institution or an agent."</para>
    ///   <para>"Questa proprietà collega un'attività (per esempio, un'indagine o un intervento su un bene culturale) all'ente o al soggetto che ha finanziato l'attività."</para>
    /// labels<para>"ha finanziatore dell'attività"</para><para>"has activity sponsor"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasActivitySponsor">https://w3id.org/arco/ontology/context-description/hasActivitySponsor</seealso>
    let hasActivitySponsor = Prefixed_Name(cdesc, "hasActivitySponsor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasAgeOfDeathEstimate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasAgeOfDeathEstimate">https://w3id.org/arco/ontology/context-description/hasAgeOfDeathEstimate</seealso>
    let hasAgeOfDeathEstimate =
        Prefixed_Name(cdesc, "hasAgeOfDeathEstimate") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasAgeOfDeathInterpretation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un reperto antropologico alla stima dell'età della morte."</para>
    ///   <para>"This property relates an antropologic artifact to the interpretation of its age of death."</para>
    /// labels<para>"ha età della morte stimata"</para><para>"has age of death interpretation"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasAgeOfDeathInterpretation">https://w3id.org/arco/ontology/context-description/hasAgeOfDeathInterpretation</seealso>
    let hasAgeOfDeathInterpretation =
        Prefixed_Name(cdesc, "hasAgeOfDeathInterpretation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasAgentWithResponsibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega l'individuazione di una responsabilità relativamente ai processi di produzione e di divulgazione che caratterizzano specificamente i beni fotografici all'agente che ha quella specifica responsabilità."</para>
    ///   <para>"This property relates the responsibility's identification to the agent which has that specific responsibility, focusing on the production process and dissemination of the photographic heritage."</para>
    /// labels<para>"ha agente con responsabilità"</para><para>"has agent with responsibility"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasAgentWithResponsibility">https://w3id.org/arco/ontology/context-description/hasAgentWithResponsibility</seealso>
    let hasAgentWithResponsibility =
        Prefixed_Name(cdesc, "hasAgentWithResponsibility") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasAlternativeDatingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega una datazione alternativa con la sua tipologia."</para>
    ///   <para>"This property relates an alternative dating to its type."</para>
    /// labels<para>"has alternative dating type"</para><para>"ha datazione alternativa"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasAlternativeDatingType">https://w3id.org/arco/ontology/context-description/hasAlternativeDatingType</seealso>
    let hasAlternativeDatingType =
        Prefixed_Name(cdesc, "hasAlternativeDatingType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasAnomaly</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega una fotointerpretazione o fotorestituzione a un'anomalia rilevata nel corso dell'indagine."</para>
    ///   <para>"This property relates a photo interepretation rendering to an anomaly revealed by a survey."</para>
    /// labels<para>"has anomaly"</para><para>"ha anomalia"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasAnomaly">https://w3id.org/arco/ontology/context-description/hasAnomaly</seealso>
    let hasAnomaly = Prefixed_Name(cdesc, "hasAnomaly") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasAnomalyOrigin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates an anomaly detected during a photo interpretation or rendering survey to the origin of the anomaly (e.g. natural, unsure)."</para>
    ///   <para>"Questa proprietà collega un'anomalia rilevata durante una fotointerpretazione o fotorestituzione all'origine dell'anomalia (naturale, antropica, incerta)."</para>
    /// labels<para>"has anomaly origin"</para><para>"ha origine dell'anomalia"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasAnomalyOrigin">https://w3id.org/arco/ontology/context-description/hasAnomalyOrigin</seealso>
    let hasAnomalyOrigin = Prefixed_Name(cdesc, "hasAnomalyOrigin") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasAnomalyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un'anomalia rilevata nel corso di una fotointerpretazione o fotorestituzione al tipo di anomalia (puntuale, lineare, areale)."</para>
    ///   <para>"This property relates an anomaly revealed by a photo interpretation rendering to its anomaly type (line, point, poligony anomaly)."</para>
    /// labels<para>"ha tipo di anomalia"</para><para>"has anomaly type"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasAnomalyType">https://w3id.org/arco/ontology/context-description/hasAnomalyType</seealso>
    let hasAnomalyType = Prefixed_Name(cdesc, "hasAnomalyType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasArchaeologicalPropertySurveyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un'indagine su un bene archeologico al tipo di indagine."</para>
    ///   <para>"This property relates a survey on an archaeological property to the type of survey."</para>
    /// labels<para>"ha tipo di indagine su bene archeologico"</para><para>"has archaeological property survey type"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasArchaeologicalPropertySurveyType">https://w3id.org/arco/ontology/context-description/hasArchaeologicalPropertySurveyType</seealso>
    let hasArchaeologicalPropertySurveyType =
        Prefixed_Name(cdesc, "hasArchaeologicalPropertySurveyType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasArchaeometricDiagnosticSurveyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un'indagine archeometrica e diagnostica al suo tipo (es.: analisi della malta, carotaggio, termografia, etc.)"</para>
    ///   <para>"This property relates an arecheometric diagnostic survey to its type (i.e. thermal imaging, coring)."</para>
    /// labels<para>"has archaeometric diagnostic survey type"</para><para>"ha tipo di indagine archeometrica e diagnostica"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasArchaeometricDiagnosticSurveyType">https://w3id.org/arco/ontology/context-description/hasArchaeometricDiagnosticSurveyType</seealso>
    let hasArchaeometricDiagnosticSurveyType =
        Prefixed_Name(cdesc, "hasArchaeometricDiagnosticSurveyType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasArchivalRecordSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates the relationship of an archival set and a one of its belonging cultural entities."</para>
    ///   <para>"Questa proprietà, inversa a "è unità archivistica complessa in", collega il rapporto tra una unità archivistica complessa e un bene culturale che ne fa parte alla unità archivistica stessa."</para>
    /// labels<para>"has archival record set"</para><para>"ha unità archivistica complessa"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasArchivalRecordSet">https://w3id.org/arco/ontology/context-description/hasArchivalRecordSet</seealso>
    let hasArchivalRecordSet =
        Prefixed_Name(cdesc, "hasArchivalRecordSet") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasArchive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega una documentazione costituita da fonti e documenti all'archivio e/o istituzione conservativa."</para>
    ///   <para>"This property relates the documentation made of sources and documents to the archive or conservative institution."</para>
    /// labels<para>"has archive"</para><para>"ha archivio"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasArchive">https://w3id.org/arco/ontology/context-description/hasArchive</seealso>
    let hasArchive = Prefixed_Name(cdesc, "hasArchive") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasAssociatedObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a finding context of a cultural property (in particular, an anthropological material) to an object associated to the cultural property (e.g: earrings, shield, cloth, etc.)"</para>
    ///   <para>"Questa proprietà collega il contesto di rinvenimento di un bene culturale (in particolare, un reperto antropologico) a un elemento associato al bene in quel contesto (es.: orecchini, scudo, resti di tessuto)."</para>
    /// labels<para>"has associated object"</para><para>"ha elemento associato"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasAssociatedObject">https://w3id.org/arco/ontology/context-description/hasAssociatedObject</seealso>
    let hasAssociatedObject =
        Prefixed_Name(cdesc, "hasAssociatedObject") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasAttributedAuthor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a situation where an autorship is attributed to a cultural entity's author."</para>
    ///   <para>"Questa proprietà collega una situazione in cui viene attribuito un autore a un bene culturale all'autore stesso."</para>
    /// labels<para>"has attributed author"</para><para>"ha autore attribuito"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasAttributedAuthor">https://w3id.org/arco/ontology/context-description/hasAttributedAuthor</seealso>
    let hasAttributedAuthor =
        Prefixed_Name(cdesc, "hasAttributedAuthor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasAuthor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a entity (i.e. documentation, cultural entity, etc.) to its author."</para>
    ///   <para>"Questa proprietà collega una entità di qualsiasi tipo (documentazione, bene culturale, etc.) con il suo autore."</para>
    ///   <para>"This property relates an entity to its author."</para>
    /// labels<para>"ha autore"</para><para>"has author"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasAuthor">https://w3id.org/arco/ontology/context-description/hasAuthor</seealso>
    let hasAuthor = Prefixed_Name(cdesc, "hasAuthor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasAuthorityFileCataloguingAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un'entità descritta in una scheda di Authority File all'ente schedatore dell'authority file stesso. Per esempio, l'attribuzione di un autore a un bene culturale, uno scavo archeologico, una ricognizione archeologica, una bibliografia. Questa proprietà, esprimendo il significato della relazione nel nome, dà una rappresentazione semplificata della relazione che lega questa entità, l'authority file, e l'ente schedatore dell'authority file."</para>
    ///   <para>"This property relates an entity described in a authority file to the file's cataloguing institution."</para>
    /// labels<para>"has authority file cataloguing agency"</para><para>"ha ente schedatore dell'authority file"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasAuthorityFileCataloguingAgency">https://w3id.org/arco/ontology/context-description/hasAuthorityFileCataloguingAgency</seealso>
    let hasAuthorityFileCataloguingAgency =
        Prefixed_Name(cdesc, "hasAuthorityFileCataloguingAgency") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasAuthorshipAttribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Proprietà che lega un oggetto culturale a un'attribuzione di autore o di responsabilità relativa all'oggetto."</para>
    ///   <para>"This property relates a cultural entity to an authorship or resposibility attribution of the entity."</para>
    /// labels<para>"ha attribuzione di autore/responsabilità"</para><para>"has authorship attribution"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasAuthorshipAttribution">https://w3id.org/arco/ontology/context-description/hasAuthorshipAttribution</seealso>
    let hasAuthorshipAttribution =
        Prefixed_Name(cdesc, "hasAuthorshipAttribution") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasBibliography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates an entity to its bibliography."</para>
    ///   <para>"Questa proprietà collega un'entità alla sua bibliografia. Per esempio, nell'ambito del Catalogo Generale, collega un bene culturale alla bibliografia che riguarda il bene stesso, descritto in una scheda di catalogo."</para>
    /// labels<para>"has bibliography"</para><para>"ha bibliografia"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasBibliography">https://w3id.org/arco/ontology/context-description/hasBibliography</seealso>
    let hasBibliography = Prefixed_Name(cdesc, "hasBibliography") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasBibliographyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a bibliography to its bibliography type."</para>
    ///   <para>"Questa proprietà collega la bibliografia al tipo di riferimento bibliografico."</para>
    /// labels<para>"ha tipo di bibliografia"</para><para>"has bibliography type"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasBibliographyType">https://w3id.org/arco/ontology/context-description/hasBibliographyType</seealso>
    let hasBibliographyType =
        Prefixed_Name(cdesc, "hasBibliographyType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasBiologicalTaxon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a biological entity to a taxon."</para>
    ///   <para>"Questa proprietà collega un'entità biologica a una tassonomia."</para>
    /// labels<para>"has biological taxon"</para><para>"ha tassonomia biologica"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasBiologicalTaxon">https://w3id.org/arco/ontology/context-description/hasBiologicalTaxon</seealso>
    let hasBiologicalTaxon = Prefixed_Name(cdesc, "hasBiologicalTaxon") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasBiologicalTaxonomy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasBiologicalTaxonomy">https://w3id.org/arco/ontology/context-description/hasBiologicalTaxonomy</seealso>
    let hasBiologicalTaxonomy =
        Prefixed_Name(cdesc, "hasBiologicalTaxonomy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasChangeOfAvailability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un bene culturale coinvolto in un un evento di mutamento di condizione materiale (furto, distruzione, recupero) all'evento stesso."</para>
    ///   <para>"This property relates a cultural enity involved in a change of availability event (i.e. theft, destruction, recovery) to the event."</para>
    /// labels<para>"has change of availability"</para><para>"ha mutamento condizione materiale"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasChangeOfAvailability">https://w3id.org/arco/ontology/context-description/hasChangeOfAvailability</seealso>
    let hasChangeOfAvailability =
        Prefixed_Name(cdesc, "hasChangeOfAvailability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasChangeOfAvailabilityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a cultural entity's change of availability to the event type (i.e. theft, destruction, recovery)."</para>
    ///   <para>"Questa proprietà collega il mutamento di condizione materiale di un bene culturale al tipo di evento (es.: furto, distruzione, recupero)."</para>
    /// labels<para>"has change of availability type"</para><para>"ha tipo di mutamento condizione materiale"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasChangeOfAvailabilityType">https://w3id.org/arco/ontology/context-description/hasChangeOfAvailabilityType</seealso>
    let hasChangeOfAvailabilityType =
        Prefixed_Name(cdesc, "hasChangeOfAvailabilityType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasCircumstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega una situazione all'occasione che ha determinato quella situazione. Per esempio, può collegare una situazione in cui viene indicata la committenza di un bene culturale all'occasione che ha determinato quella committenza, oppure un luogo di ripresa di un bene fotografico all'occasione che ha determinato il motivo della ripresa, o ancora l'uso di un bene culturale all'occasione d'uso."</para>
    ///   <para>"This property relates a situation to the circumstance which led to the situation. For example it can connect a situation where is indicated a cultural entity's committment to its circumstance."</para>
    /// labels<para>"ha circostanza"</para><para>"has circumstance"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasCircumstance">https://w3id.org/arco/ontology/context-description/hasCircumstance</seealso>
    let hasCircumstance = Prefixed_Name(cdesc, "hasCircumstance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasCircumstanceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates the circumstance to its type."</para>
    ///   <para>"Questa proprietà collega un'occasione con il tipo di occasione."</para>
    /// labels<para>"has circumstance type"</para><para>"ha tipo di circostanza"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasCircumstanceType">https://w3id.org/arco/ontology/context-description/hasCircumstanceType</seealso>
    let hasCircumstanceType =
        Prefixed_Name(cdesc, "hasCircumstanceType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasCoinIssuance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Questa proprietà collega un bene numismatico alla sua emissione, o una contromarca a una nuova emissione che sostituisce nominale, autorità emittente, zecca e cronologia della moneta originari."</para>
    ///   <para>"This property relates a numismatic entity to its issuance."</para>
    /// labels<para>"has coin issuance"</para><para>"ha emissione di moneta"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasCoinIssuance">https://w3id.org/arco/ontology/context-description/hasCoinIssuance</seealso>
    let hasCoinIssuance = Prefixed_Name(cdesc, "hasCoinIssuance") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasCoinMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega una serie di monete a una moneta che ne è membro."</para>
    ///   <para>"This property relates a numismatic series to a coin that is member of it."</para>
    /// labels<para>"has coin member"</para><para>"ha moneta membro"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasCoinMember">https://w3id.org/arco/ontology/context-description/hasCoinMember</seealso>
    let hasCoinMember = Prefixed_Name(cdesc, "hasCoinMember") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega l'appartenenza di un bene culturale a una collezione in un intervallo di tempo alla collezione coinvolta nella relazione"</para>
    ///   <para>"This property relates a cultural property to the collection to which it belongs in a time span."</para>
    /// labels<para>"ha collezione"</para><para>"has collection"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasCollection">https://w3id.org/arco/ontology/context-description/hasCollection</seealso>
    let hasCollection = Prefixed_Name(cdesc, "hasCollection") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasCollector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a collection of cultural properties to its collector."</para>
    ///   <para>"Questa proprietà collega una collezione di beni culturali al collezionista."</para>
    /// labels<para>"ha collezionista"</para><para>"has collector"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasCollector">https://w3id.org/arco/ontology/context-description/hasCollector</seealso>
    let hasCollector = Prefixed_Name(cdesc, "hasCollector") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasCommission</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a cultural entity to its commission."</para>
    ///   <para>"Questa proprietà collega un bene culturale alla sua committenza."</para>
    /// labels<para>"has commission"</para><para>"ha committenza"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasCommission">https://w3id.org/arco/ontology/context-description/hasCommission</seealso>
    let hasCommission = Prefixed_Name(cdesc, "hasCommission") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasCommittent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega una situazione in cui viene indicata la committenza di un bene culturale alla persona o istituzione committente."</para>
    ///   <para>"This property relates a situation where it is indicated a cultural entity's commission to the investor agent or institution."</para>
    /// labels<para>"ha committente"</para><para>"has committent"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasCommittent">https://w3id.org/arco/ontology/context-description/hasCommittent</seealso>
    let hasCommittent = Prefixed_Name(cdesc, "hasCommittent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasCopyright</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un'entità, per esempio un bene fotografico, ai diritti d'autore detenuti da un agente, o allo stato di "in pubblico dominio" relativo all'entità stessa, qualora i diritti siano scaduti."</para>
    ///   <para>"This property relates an entity to copiright held by an agent or its "public domain" condition, if it is out of copyright."</para>
    /// labels<para>"ha diritti d'autore"</para><para>"has copyright"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasCopyright">https://w3id.org/arco/ontology/context-description/hasCopyright</seealso>
    let hasCopyright = Prefixed_Name(cdesc, "hasCopyright") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasCopyrightHolder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega i diritti d'autore di un'entità al titolare dei diritti d'autore. Questa proprietà fornisce una rappresentazione semplificata della relazione, il cui valore viene esplicitato nel nome della proprietà. La stessa relazione viene anche modellata nell'ontologia, in maniera più espressiva, per mezzo della classe AgentRole, che permette di collegare un agente al ruolo che ha rivestito (in questo caso, al ruolo di "titolare dei diritti d'autore")."</para>
    ///   <para>"This property relates an entity's copyright to its copyright holder. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness."</para>
    /// labels<para>"has copyright holder"</para><para>"ha titolare dei diritti d'autore"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasCopyrightHolder">https://w3id.org/arco/ontology/context-description/hasCopyrightHolder</seealso>
    let hasCopyrightHolder = Prefixed_Name(cdesc, "hasCopyrightHolder") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasCreationLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a cultural entity to a connected cultural entity which constitutes its production site."</para>
    ///   <para>"Questa proprietà collega un bene culturale a un altro bene culturale collegato, che ne costituisce la sede di produzione/realizzazione."</para>
    /// labels<para>"è stato realizzato in"</para><para>"has creation location"</para><para>"ha luogo di creazione"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasCreationLocation">https://w3id.org/arco/ontology/context-description/hasCreationLocation</seealso>
    let hasCreationLocation =
        Prefixed_Name(cdesc, "hasCreationLocation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasCulturalGeographicArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a cultural entity's use to its cultural geographical area."</para>
    ///   <para>"Questa proprietà collega l'uso del bene con la sua area geografico-culturale."</para>
    /// labels<para>"has cultural geographic area"</para><para>"ha area geografico-culturale"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasCulturalGeographicArea">https://w3id.org/arco/ontology/context-description/hasCulturalGeographicArea</seealso>
    let hasCulturalGeographicArea =
        Prefixed_Name(cdesc, "hasCulturalGeographicArea") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasCulturalPropertyEstimate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un bene culturale alla stima effettuata sul bene stesso."</para>
    ///   <para>"This property relates a cultural property to the estimate of that cultural property."</para>
    /// labels<para>"ha stima di bene culturale"</para><para>"has cultural property estimate"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasCulturalPropertyEstimate">https://w3id.org/arco/ontology/context-description/hasCulturalPropertyEstimate</seealso>
    let hasCulturalPropertyEstimate =
        Prefixed_Name(cdesc, "hasCulturalPropertyEstimate") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasCulturalPropertyStage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates the relatioship between a cultural property and a related work (preparatory or final work) to the stage of the cultural property referring to this related work."</para>
    ///   <para>"Questa proprietà collega il rapporto tra un bene culturale e un'altra entità collegata (opera preparatoria o opera finale) allo stadio di realizzazione del bene stesso in rapporto a questa entità."</para>
    /// labels<para>"ha fase di realizzazione"</para><para>"has cultural property stage"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasCulturalPropertyStage">https://w3id.org/arco/ontology/context-description/hasCulturalPropertyStage</seealso>
    let hasCulturalPropertyStage =
        Prefixed_Name(cdesc, "hasCulturalPropertyStage") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasCulturalScope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a situation, where a cultural scope is attributed to a cultural entity, to the cultural scope."</para>
    ///   <para>"Questa proprietà collega una situazione in cui viene attribuito un ambito culturale di un bene culturale all'ambito culturale stesso."</para>
    /// labels<para>"ha ambito culturale"</para><para>"has cultural scope"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasCulturalScope">https://w3id.org/arco/ontology/context-description/hasCulturalScope</seealso>
    let hasCulturalScope = Prefixed_Name(cdesc, "hasCulturalScope") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasDating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un'entità alla sua cronologia."</para>
    ///   <para>"This property relates an entity to its dating."</para>
    /// labels<para>"ha cronologia"</para><para>"has dating"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasDating">https://w3id.org/arco/ontology/context-description/hasDating</seealso>
    let hasDating = Prefixed_Name(cdesc, "hasDating") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasDatingEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a dating to an event involving the cultural property, which the dating is about."</para>
    ///   <para>"Questa proprietà collega una cronologia a un evento relativo al bene culturale, cui si riferisce la specifica cronologia."</para>
    /// labels<para>"ha evento relativo a datazione"</para><para>"has event related to dating"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasDatingEvent">https://w3id.org/arco/ontology/context-description/hasDatingEvent</seealso>
    let hasDatingEvent = Prefixed_Name(cdesc, "hasDatingEvent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasDerivatedWorkType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a work derivated from a cultural entity to its type."</para>
    ///   <para>"Questa proprietà collega un'opera derivata da un bene culturale al tipo di opera derivata."</para>
    /// labels<para>"has derivated work type"</para><para>"ha tipo di opera derivata"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasDerivatedWorkType">https://w3id.org/arco/ontology/context-description/hasDerivatedWorkType</seealso>
    let hasDerivatedWorkType =
        Prefixed_Name(cdesc, "hasDerivatedWorkType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasDetectionMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a cultural property to the detection method that allowed the detection of the cultural property."</para>
    ///   <para>"Questa proprietà collega un bene culturale alla modalità di individuazione che ne ha permesso l'individuazione."</para>
    /// labels<para>"ha metodo di individuazione"</para><para>"has detection method"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasDetectionMethod">https://w3id.org/arco/ontology/context-description/hasDetectionMethod</seealso>
    let hasDetectionMethod = Prefixed_Name(cdesc, "hasDetectionMethod") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un bene culturale alla documentazione che riguarda il bene descritto in una scheda di catalogo."</para>
    ///   <para>"This property relates a cultural entity to the documentation related to the cutultural entity described in a catalogue record."</para>
    /// labels<para>"ha documentazione"</para><para>"has documentation"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasDocumentation">https://w3id.org/arco/ontology/context-description/hasDocumentation</seealso>
    let hasDocumentation = Prefixed_Name(cdesc, "hasDocumentation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasDocumentationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a documentation to its type."</para>
    ///   <para>"Questa proprietà collega una documentazione al tipo di documentazione."</para>
    /// labels<para>"has documentation type"</para><para>"ha tipo di documentazione"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasDocumentationType">https://w3id.org/arco/ontology/context-description/hasDocumentationType</seealso>
    let hasDocumentationType =
        Prefixed_Name(cdesc, "hasDocumentationType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasEdition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un'entità a una sua edizione."</para>
    ///   <para>"This property relates an entity to its edition."</para>
    /// labels<para>"has edition"</para><para>"ha edizione"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasEdition">https://w3id.org/arco/ontology/context-description/hasEdition</seealso>
    let hasEdition = Prefixed_Name(cdesc, "hasEdition") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasEditor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates an edition to its editor."</para>
    ///   <para>"Questa proprietà collega un'edizione all'editore."</para>
    /// labels<para>"ha editore"</para><para>"has editor"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasEditor">https://w3id.org/arco/ontology/context-description/hasEditor</seealso>
    let hasEditor = Prefixed_Name(cdesc, "hasEditor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasEligibleIntervention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a urban planning instrument to the eligible intervention (e.g.: conservation intervention/ exceptional maintenance)."</para>
    ///   <para>"Questa proprietà collega uno strumento urbanistico-territoriale all'intervento ammesso dalla normativa specifica (es.: restauro/ manutenzione straordinaria)."</para>
    /// labels<para>"has eligible intervention"</para><para>"ha intervento ammesso"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasEligibleIntervention">https://w3id.org/arco/ontology/context-description/hasEligibleIntervention</seealso>
    let hasEligibleIntervention =
        Prefixed_Name(cdesc, "hasEligibleIntervention") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasEstimate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates an entity to its estimate."</para>
    ///   <para>"Questa proprietà collega un'entità a una sua stima."</para>
    /// labels<para>"has estimate"</para><para>"ha stima"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasEstimate">https://w3id.org/arco/ontology/context-description/hasEstimate</seealso>
    let hasEstimate = Prefixed_Name(cdesc, "hasEstimate") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasExportImportCertification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a cultural entity to its import-export certification."</para>
    ///   <para>"Questa proprietà collega un bene culturale a una certificazione amministrativa per la circolazione e l'esportazione/importazione che riguarda il bene stesso."</para>
    /// labels<para>"ha certificazione di esportazione/importazione"</para><para>"has export/import certification"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasExportImportCertification">https://w3id.org/arco/ontology/context-description/hasExportImportCertification</seealso>
    let hasExportImportCertification =
        Prefixed_Name(cdesc, "hasExportImportCertification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasExportImportCertificationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega una certificazione amministrativa di circolazione ed esportazione/importazione di un bene culturale alla sua tipologia (es.: attestato di libera circolazione, licenza di esportazione definitiva, ecc)."</para>
    ///   <para>"This property relates a import-export certification of a cultural entity to its type (i.e. delivery confirmation certification, free movement certification etc)."</para>
    ///   <para>"ha tipo di certificazione di esportazione o importazione"</para>
    /// labels<para>"has export import certification type"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasExportImportCertificationType">https://w3id.org/arco/ontology/context-description/hasExportImportCertificationType</seealso>
    let hasExportImportCertificationType =
        Prefixed_Name(cdesc, "hasExportImportCertificationType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasExportOffice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega una certificazione di importazione/esportazione al'Ufficio Esportazione che ha emesso la certificazione."</para>
    ///   <para>"This property relates an export/import certification to the certifying Export Department."</para>
    /// labels<para>"has export office"</para><para>"ha ufficio esportazione"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasExportOffice">https://w3id.org/arco/ontology/context-description/hasExportOffice</seealso>
    let hasExportOffice = Prefixed_Name(cdesc, "hasExportOffice") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasFindingContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a cultural property, and in particular an anthropological material, to its finding context."</para>
    ///   <para>"Questa proprietà collega un bene culturale, in particolare un reperto antropologico, al suo contesto di rinvenimento."</para>
    /// labels<para>"has finding context"</para><para>"ha contesto di rinvenimento"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasFindingContext">https://w3id.org/arco/ontology/context-description/hasFindingContext</seealso>
    let hasFindingContext = Prefixed_Name(cdesc, "hasFindingContext") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasFindingContextType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega il contesto di rinvenimento di un bene culturale, e in particolare di un reperto antropologico, al tipo di contesto."</para>
    ///   <para>"This property relates a cultural property (anthropological material) finding context to the type of context."</para>
    /// labels<para>"ha tipo di contesto di rinvenimento"</para><para>"has finding context type"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasFindingContextType">https://w3id.org/arco/ontology/context-description/hasFindingContextType</seealso>
    let hasFindingContextType =
        Prefixed_Name(cdesc, "hasFindingContextType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasFindingLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un bene culturale a un altro bene culturale collegato, che ne costituisce la sede di rinvenimento archeologico."</para>
    ///   <para>"This property relates a cultural entity to a connected cultural entity which constitutes the site where it was rediscovered."</para>
    /// labels<para>"has finding location"</para><para>"è stato rinvenuto in"</para><para>"ha sede di rinvenimento"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasFindingLocation">https://w3id.org/arco/ontology/context-description/hasFindingLocation</seealso>
    let hasFindingLocation = Prefixed_Name(cdesc, "hasFindingLocation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega la documentazione con il suo formato."</para>
    ///   <para>"This property relates the documentation to its format."</para>
    /// labels<para>"ha formato"</para><para>"has format"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasFormat">https://w3id.org/arco/ontology/context-description/hasFormat</seealso>
    let hasFormat = Prefixed_Name(cdesc, "hasFormat") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasFruition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates garment to the context in which it has been worn."</para>
    ///   <para>"Questa proprietà collega un vestimento antico o contemporaneo a un'occasione in cui è stato indossato da una o più persone."</para>
    /// labels<para>"ha fruizione"</para><para>"has fruition"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasFruition">https://w3id.org/arco/ontology/context-description/hasFruition</seealso>
    let hasFruition = Prefixed_Name(cdesc, "hasFruition") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasGenus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This property relates a biological taxon to the genus, that is one of the concept of the taxon."</para>
    ///   <para>"Questa proprietà collega una tassonomia biologica al genere, che è uno dei concetti della tassonomia."</para>
    /// labels<para>"ha genere"</para><para>"has genus"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasGenus">https://w3id.org/arco/ontology/context-description/hasGenus</seealso>
    let hasGenus = Prefixed_Name(cdesc, "hasGenus") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasInterpretationCriterion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà associa una attribuzione di autore/responsabilità, una cronologia, una committenza, o altre situazioni che prevedono una interpretazione, alla motivazione o criterio che hanno determinato quella interpretazione."</para>
    ///   <para>"This property relates an authorship, dating, commission, or other interpretation situations, to the reason or criterion which led to that interpretation."</para>
    /// labels<para>"ha criterio interpretativo"</para><para>"has interpretation criterion"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasInterpretationCriterion">https://w3id.org/arco/ontology/context-description/hasInterpretationCriterion</seealso>
    let hasInterpretationCriterion =
        Prefixed_Name(cdesc, "hasInterpretationCriterion") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasIntervention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un bene culturale con un intervento, a fini conservativi o di altro tipo, che lo ha interessato."</para>
    ///   <para>"This property relates a cultural entity to a intervention on it, for conservational or other purposes."</para>
    /// labels<para>"ha intervento"</para><para>"has intervention"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasIntervention">https://w3id.org/arco/ontology/context-description/hasIntervention</seealso>
    let hasIntervention = Prefixed_Name(cdesc, "hasIntervention") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasInterventionRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates an authorship attribution to the agent's role."</para>
    ///   <para>"Questa proprietà associa un'attribuzione di autore/responsabilità al ruolo rivestito dall'autore o dall'ambito culturale."</para>
    /// labels<para>"has intervention role"</para><para>"ha ruolo nell'intervento"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasInterventionRole">https://w3id.org/arco/ontology/context-description/hasInterventionRole</seealso>
    let hasInterventionRole =
        Prefixed_Name(cdesc, "hasInterventionRole") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasInterventionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un intervento, a fini conservativi o di altro tipo, che ha interessato un bene culturale al tipo di intervento."</para>
    ///   <para>"This property relates an intervention on a cultural property (i.e. conservation, interventions, reprocessing, restoring, etc.) to its intervention type."</para>
    /// labels<para>"has intervention type"</para><para>"ha tipo di intervento"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasInterventionType">https://w3id.org/arco/ontology/context-description/hasInterventionType</seealso>
    let hasInterventionType =
        Prefixed_Name(cdesc, "hasInterventionType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasInventory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un bene culturale o una delle entità o attività collegate al bene culturale a un inventario che registra informazioni relative al bene culturale."</para>
    ///   <para>"This property relates a cultural property or an entity or an activity related to it to an inventory."</para>
    /// labels<para>"has inventory"</para><para>"ha inventario"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasInventory">https://w3id.org/arco/ontology/context-description/hasInventory</seealso>
    let hasInventory = Prefixed_Name(cdesc, "hasInventory") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasInventoryIdentifierResponsible</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un inventario al contenitore giuridico che conserva attualmente il bene o che lo ha conservato in passato, e che è responsabile dell'assegnazione del numero di inventario."</para>
    ///   <para>"This property relates an inventory to the juridical container responsible for the inventory identifier of the cultural property."</para>
    /// labels<para>"has inventory identifier responsible"</para><para>"ha responsabile di numero di inventario"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasInventoryIdentifierResponsible">https://w3id.org/arco/ontology/context-description/hasInventoryIdentifierResponsible</seealso>
    let hasInventoryIdentifierResponsible =
        Prefixed_Name(cdesc, "hasInventoryIdentifierResponsible") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasIssuer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega l'emissione della moneta al soggetto emittente. Questa proprietà, esprimendo il significato della relazione nel nome, dà una rappresentazione semplificata della relazione che lega questa entità e l'agente; la stessa relazione è rappresentata attraverso una n-ary relation, arco-core:AgentRole, che permette di collegare l'agente al ruolo che riveste nei confronti dell'entità."</para>
    ///   <para>"This property relates to coin's issuance to the issuer agent. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness."</para>
    /// labels<para>"has issuer"</para><para>"ha soggetto emittente"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasIssuer">https://w3id.org/arco/ontology/context-description/hasIssuer</seealso>
    let hasIssuer = Prefixed_Name(cdesc, "hasIssuer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasIssuingAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega uno strumento urbanistico-territoriale con l'ente o l'amministrazione che ha emanato il provvedimento."</para>
    ///   <para>"This property relates an urban-planning instrument to the institution which issued the provision."</para>
    /// labels<para>"ha ente che ha emanato il provvedimento"</para><para>"has issuing agency"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasIssuingAgency">https://w3id.org/arco/ontology/context-description/hasIssuingAgency</seealso>
    let hasIssuingAgency = Prefixed_Name(cdesc, "hasIssuingAgency") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasIssuingState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates the coin issuance to the issuing State of that historic period. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness."</para>
    ///   <para>"Questa proprietà collega l'emissione della moneta alla realtà statuale emittente, coeva all'emissione della moneta. Questa proprietà, esprimendo il significato della relazione nel nome, dà una rappresentazione semplificata della relazione che lega questa entità e l'agente; la stessa relazione è rappresentata attraverso una n-ary relation, arco-core:AgentRole, che permette di collegare l'agente al ruolo che riveste nei confronti dell'entità."</para>
    /// labels<para>"ha Stato emittente"</para><para>"has issuing State"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasIssuingState">https://w3id.org/arco/ontology/context-description/hasIssuingState</seealso>
    let hasIssuingState = Prefixed_Name(cdesc, "hasIssuingState") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasLaboratoryTestType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a laboratory test to its test type (i.e. chemical or metallurgical analysis)."</para>
    ///   <para>"Questa proprietà collega un'analisi di laboratorio con il tipo di analisi (es.: analisi metallurgica, analisi chimica, etc.)."</para>
    /// labels<para>"ha tipo di analisi di laboratorio"</para><para>"has laboratory test type"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasLaboratoryTestType">https://w3id.org/arco/ontology/context-description/hasLaboratoryTestType</seealso>
    let hasLaboratoryTestType =
        Prefixed_Name(cdesc, "hasLaboratoryTestType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasLegalSituation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un'entità, per esempio un bene culturale, alla sua condizione giuridica."</para>
    ///   <para>"This property relates an entity, for example a cultural entity, to its legal situation."</para>
    /// labels<para>"has legal situation"</para><para>"ha condizione giuridica"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasLegalSituation">https://w3id.org/arco/ontology/context-description/hasLegalSituation</seealso>
    let hasLegalSituation = Prefixed_Name(cdesc, "hasLegalSituation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasMemberOfArchivalRecordSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates the membership of a cultural entity to an archival record set. It is the inverse property of "isMemberofArchivalRecordSet"."</para>
    ///   <para>"Questa proprietà, inversa a "è membro di unità archivistica complessa", collega l'appartenenza di un bene culturale a un'unità archivistica al bene coinvolto nella relazione."</para>
    /// labels<para>"ha membro di unità archivistica complessa"</para><para>"has member of archival record set"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasMemberOfArchivalRecordSet">https://w3id.org/arco/ontology/context-description/hasMemberOfArchivalRecordSet</seealso>
    let hasMemberOfArchivalRecordSet =
        Prefixed_Name(cdesc, "hasMemberOfArchivalRecordSet") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasMemberOfCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates the membership of a movable cultural entity to a collection in a time interval. It is the inverse property of "isMemberofCollection"."</para>
    ///   <para>"Questa proprietà, inversa a "è membro di collezione", collega l'appartenenza di un bene culturale a una collezione in un certo intervallo di tempo al bene culturale mobile coinvolto nella relazione."</para>
    /// labels<para>"has member of collection"</para><para>"ha membro di collezione"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasMemberOfCollection">https://w3id.org/arco/ontology/context-description/hasMemberOfCollection</seealso>
    let hasMemberOfCollection =
        Prefixed_Name(cdesc, "hasMemberOfCollection") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasMemberOfPhotographicSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà, inversa a "è membro di serie", collega l'appartenenza di un bene fotografico a una serie editoriale al bene fotografico coinvolto nella relazione."</para>
    ///   <para>"This property relates the membership of a cultural entity (e.g. photographic heritage) to its photographic series. It is the inverse property of "isMemberPhotographicSeries"."</para>
    /// labels<para>"ha membro di serie fotografica"</para><para>"has member of photographic series"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasMemberOfPhotographicSeries">https://w3id.org/arco/ontology/context-description/hasMemberOfPhotographicSeries</seealso>
    let hasMemberOfPhotographicSeries =
        Prefixed_Name(cdesc, "hasMemberOfPhotographicSeries") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasMint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates the coin issuance to the Mint. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness."</para>
    ///   <para>"Questa proprietà collega l'emissione della moneta alla Zecca. Questa proprietà, esprimendo il significato della relazione nel nome, dà una rappresentazione semplificata della relazione che lega questa entità e l'agente; la stessa relazione è rappresentata attraverso una n-ary relation, arco-core:AgentRole, che permette di collegare l'agente al ruolo che riveste nei confronti dell'entità."</para>
    /// labels<para>"has mint"</para><para>"ha zecca"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasMint">https://w3id.org/arco/ontology/context-description/hasMint</seealso>
    let hasMint = Prefixed_Name(cdesc, "hasMint") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasMinter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega l'emissione della moneta allo zecchiere, monetiere, maestro di zecca. Questa proprietà, esprimendo il significato della relazione nel nome, dà una rappresentazione semplificata della relazione che lega questa entità e l'agente; la stessa relazione è rappresentata attraverso una n-ary relation, arco-core:AgentRole, che permette di collegare l'agente al ruolo che riveste nei confronti dell'entità."</para>
    ///   <para>"This property relates the coin issuance to the minter. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness."</para>
    /// labels<para>"ha zecchiere"</para><para>"has minter"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasMinter">https://w3id.org/arco/ontology/context-description/hasMinter</seealso>
    let hasMinter = Prefixed_Name(cdesc, "hasMinter") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasMusicalEnsemble</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates an musical instrument to the musical ensamble where the instument is (or were) played. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness."</para>
    ///   <para>"Questa proprietà collega uno strumento musicale al gruppo di musicisti (bande, complessi musicali, associazioni corali, ecc.) in cui lo strumento assume, o ha assunto, abitualmente un ruolo esecutivo. Questa relazione è modellata anche, con maggiore potere espressivo, tramite il pattern AgentRole, che collega lo strumento musicale a una situazione in cui un agente ha rivestito un ruolo (in questo caso, organico musicale)."</para>
    /// labels<para>"ha organico musicale"</para><para>"has musical ensemble"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasMusicalEnsemble">https://w3id.org/arco/ontology/context-description/hasMusicalEnsemble</seealso>
    let hasMusicalEnsemble = Prefixed_Name(cdesc, "hasMusicalEnsemble") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasMusician</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a musical instrument to the person who plays (in the present or past) a certain role as the instrument's exectutor. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness."</para>
    ///   <para>"Questa proprietà collega uno strumento musicale a una persona che assume - o ha assunto - un ruolo certo come esecutore dello strumento. Questa relazione è modellata anche, con maggiore potere espressivo, tramite il pattern AgentRole, che collega lo strumento musicale a una situazione in cui un agente ha rivestito un ruolo (in questo caso, chitarrista, flautista, pianista, ecc., o genericamente musicista)."</para>
    /// labels<para>"has musician"</para><para>"ha musicista"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasMusician">https://w3id.org/arco/ontology/context-description/hasMusician</seealso>
    let hasMusician = Prefixed_Name(cdesc, "hasMusician") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasObservationSurveyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates an observation survey to the type of observation survey (in the context, out of context)."</para>
    ///   <para>"Questa proprietà collega un'indagine di rilevamento al tipo di indagine di rilevamento (nel contesto/decontestualizzato)."</para>
    /// labels<para>"has observation survey type"</para><para>"ha tipo di indagine di rilevamento"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasObservationSurveyType">https://w3id.org/arco/ontology/context-description/hasObservationSurveyType</seealso>
    let hasObservationSurveyType =
        Prefixed_Name(cdesc, "hasObservationSurveyType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega una condizione giuridica al proprietario dell'oggetto che si trova in quella condizione."</para>
    ///   <para>"This property relates a legal situation to the owner of the object that is in that legal situation."</para>
    /// labels<para>"ha proprietario"</para><para>"has owner"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasOwner">https://w3id.org/arco/ontology/context-description/hasOwner</seealso>
    let hasOwner = Prefixed_Name(cdesc, "hasOwner") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasPhotographicSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà, inversa a "è serie in", collega il rapporto tra una serie e un bene fotografico che ne fa parte alla serie stessa."</para>
    ///   <para>"This property relates a photographic series a the cultural entity which belongs to it."</para>
    /// labels<para>"has photographic series"</para><para>"ha serie fotografica"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasPhotographicSeries">https://w3id.org/arco/ontology/context-description/hasPhotographicSeries</seealso>
    let hasPhotographicSeries =
        Prefixed_Name(cdesc, "hasPhotographicSeries") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasPlanningEnvironmentalRelationWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a cultural entity to another cultural entity, in an planning environmental relation."</para>
    ///   <para>"Questa proprietà collega un bene culturale a un altro bene culturale collegato, con cui è in relazione urbanistico-ambientale."</para>
    /// labels<para>"ha relazione urbanistico-ambientale con"</para><para>"has planning environmental relation with"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasPlanningEnvironmentalRelationWith">https://w3id.org/arco/ontology/context-description/hasPlanningEnvironmentalRelationWith</seealso>
    let hasPlanningEnvironmentalRelationWith =
        Prefixed_Name(cdesc, "hasPlanningEnvironmentalRelationWith") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasPreviousLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a cultural entity to a connected cultural entity which constitutes its provenance location before its current position."</para>
    ///   <para>"Questa proprietà collega un bene culturale a un altro bene culturale collegato, che ne costituisce la sede di provenienza, prima della sua attuale collocazione."</para>
    /// labels<para>"has previous location"</para><para>"ha sede di provenienza"</para><para>"era contenuto in"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasPreviousLocation">https://w3id.org/arco/ontology/context-description/hasPreviousLocation</seealso>
    let hasPreviousLocation =
        Prefixed_Name(cdesc, "hasPreviousLocation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasPreviousOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un evento di acquisizione di un bene culturale al soggetto fonte dell'acquisizione."</para>
    ///   <para>"This property relates the event of a cultural entity's acquisition to the agent which is the source of the acquisition."</para>
    /// labels<para>"has previous owner"</para><para>"ha soggetto fonte dell'acquisizione"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasPreviousOwner">https://w3id.org/arco/ontology/context-description/hasPreviousOwner</seealso>
    let hasPreviousOwner = Prefixed_Name(cdesc, "hasPreviousOwner") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasPrimaryDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un bene demoetnoantropologico immateriale alla sua documentazione primaria, ovvero la documentazione che restituisce il bene immateriale e ritenuta più rappresentativa."</para>
    ///   <para>"This property relates an intangible demoethnoanthropological property to its primary documentation, that is the documentation more representative of the intangible heritage."</para>
    /// labels<para>"has primary documentation"</para><para>"ha documentazione primaria"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasPrimaryDocumentation">https://w3id.org/arco/ontology/context-description/hasPrimaryDocumentation</seealso>
    let hasPrimaryDocumentation =
        Prefixed_Name(cdesc, "hasPrimaryDocumentation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasProfession</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates an agent to its job. For example the agent responsible of the production of a cultual entity."</para>
    ///   <para>"Questa proprietà collega un agente al suo mestiere o professione, per esempio l'utente del bene oppure il responsabile della fabbricazione di un bene con il suo mestiere o la sua professione."</para>
    /// labels<para>"has profession"</para><para>"ha professione"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasProfession">https://w3id.org/arco/ontology/context-description/hasProfession</seealso>
    let hasProfession = Prefixed_Name(cdesc, "hasProfession") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasProponentAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates an entity (e.g a cultural entity or a cultual entity's protective measure) to the proposing institution. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness."</para>
    ///   <para>"Questa proprietà collega un'entità, che può essere direttamente il bene culturale o specificamente il provvedimento di tutela relativo al bene culturale, all'ente proponente, ovvero al soggetto che ha proposto il provvedimento, identificato per mezzo della denominazione per esteso oppure, nel caso di Enti accreditati dall'ICCD, del relativo codice assegnato dall'Istituto. La relazione tra il ruolo e l'agente che lo riveste è espressa, in maniera generica, nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe AgentRole, che permette di collegare l'agente e il suo ruolo."</para>
    /// labels<para>"has proponet agency"</para><para>"ha ente proponente"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasProponentAgency">https://w3id.org/arco/ontology/context-description/hasProponentAgency</seealso>
    let hasProponentAgency = Prefixed_Name(cdesc, "hasProponentAgency") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasProtectiveMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un bene culturale a un provvedimento di tutela nazionale o internazionale che lo ha interessato."</para>
    /// labels<para>"ha provvedimento di tutela"</para><para>"has protective measure"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasProtectiveMeasure">https://w3id.org/arco/ontology/context-description/hasProtectiveMeasure</seealso>
    let hasProtectiveMeasure =
        Prefixed_Name(cdesc, "hasProtectiveMeasure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasReferenceCatalogue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega la copia della stampa con il suo repertorio."</para>
    ///   <para>"This property relates a print's copy to its reference catalogue."</para>
    /// labels<para>"ha repertorio"</para><para>"has reference catalogue"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasReferenceCatalogue">https://w3id.org/arco/ontology/context-description/hasReferenceCatalogue</seealso>
    let hasReferenceCatalogue =
        Prefixed_Name(cdesc, "hasReferenceCatalogue") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasRelatedAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is used to associate an entity of any kind to an agent related to that entity in some way. It is used when it is not possible to express the relation in a more specific way."</para>
    ///   <para>"Questa proprietà collega un'entità di qualsiasi tipo a un agente che è collegato in qualche modo a quell'entità. È una relazione generica che viene usata per quei casi in cui non sia possibile definire in maniera più precisa la natura della relazione."</para>
    /// labels<para>"ha agente correlato"</para><para>"has related agent"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasRelatedAgent">https://w3id.org/arco/ontology/context-description/hasRelatedAgent</seealso>
    let hasRelatedAgent = Prefixed_Name(cdesc, "hasRelatedAgent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasRelatedWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un bene culturale a un'altra opera collegata (es.: copia, fase preparatoria, etc.), che può essere essa stessa un bene culturale."</para>
    ///   <para>"This property relates a cultural property to a related work (e.g. copy, preparatory work)."</para>
    /// labels<para>"ha opera collegata"</para><para>"has related work"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasRelatedWork">https://w3id.org/arco/ontology/context-description/hasRelatedWork</seealso>
    let hasRelatedWork = Prefixed_Name(cdesc, "hasRelatedWork") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasRelatedWorkSituation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un bene culturale alla relazione tra il bene stesso e un'altra opera che ne costituisce una fase preparatoria o che ne rappresenta la fase finale, e in riferimento alla quale il bene culturale si trova in un determinato stadio."</para>
    ///   <para>"This property relates a cultural property to a situation in which this cultural property is related to another work, that could even be another cultural property, as its preparatory or final phase."</para>
    /// labels<para>"ha rapporto con opera collegata"</para><para>"has related work situation"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasRelatedWorkSituation">https://w3id.org/arco/ontology/context-description/hasRelatedWorkSituation</seealso>
    let hasRelatedWorkSituation =
        Prefixed_Name(cdesc, "hasRelatedWorkSituation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasReliability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega una fotointerpretazione o fotorestituzione al livello di affidabilità delle informazioni rilevate nell'indagine."</para>
    ///   <para>"This property relates a photo interpretation rendering survey to the reliability of the information collected during the survey."</para>
    /// labels<para>"has reliability"</para><para>"ha affidabilità"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasReliability">https://w3id.org/arco/ontology/context-description/hasReliability</seealso>
    let hasReliability = Prefixed_Name(cdesc, "hasReliability") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasReproduction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega la pubblicazione con la riproduzione della stampa che ne è, o è stata, parte integrante."</para>
    ///   <para>"This property relates a publication to the print reproduction which is or was part of it."</para>
    /// labels<para>"ha riproduzione"</para><para>"has reproduction"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasReproduction">https://w3id.org/arco/ontology/context-description/hasReproduction</seealso>
    let hasReproduction = Prefixed_Name(cdesc, "hasReproduction") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasReproductionPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega la riproduzione di una stampa all'interno di una pubblicazione con la posizione fisica nella pubblicazione stessa (es.: frontespizio, copertina, colophon, etc.)."</para>
    ///   <para>"This property relates the print reproduction in a publication to the position in the publication."</para>
    /// labels<para>"has reproduction position"</para><para>"ha posizione della riproduzione"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasReproductionPosition">https://w3id.org/arco/ontology/context-description/hasReproductionPosition</seealso>
    let hasReproductionPosition =
        Prefixed_Name(cdesc, "hasReproductionPosition") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasResearch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un bene culturale alla ricerca nell'ambito della quale è stata redatta la scheda."</para>
    ///   <para>"This property relates a culural entity to the research, which is the context where the enity's cataloguing record has been produced."</para>
    /// labels<para>"ha ricerca"</para><para>"has research"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasResearch">https://w3id.org/arco/ontology/context-description/hasResearch</seealso>
    let hasResearch = Prefixed_Name(cdesc, "hasResearch") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasResearchScientificDirector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a research to the research's scientific responsible. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness."</para>
    ///   <para>"Questa proprietà collega una ricerca al responsabile scientifico della ricerca. La relazione tra il ruolo e l'agente che lo riveste è espressa nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe AgentRole, che permette di collegare l'agente e il suo ruolo."</para>
    /// labels<para>"has research scientific director"</para><para>"ha responsabile scientifico della ricerca"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasResearchScientificDirector">https://w3id.org/arco/ontology/context-description/hasResearchScientificDirector</seealso>
    let hasResearchScientificDirector =
        Prefixed_Name(cdesc, "hasResearchScientificDirector") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasResponsibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a photographic cultural entity (photography or photographic fond) to the responsibility attribution of an agent. The agent is in charge of the production or disclosure process which characterises photographic heritage (i.e. printers, editors, distributors, sposors, collection responsibles etc.)"</para>
    ///   <para>"Questa proprietà collega un bene fotografico (fotografia o fondo fotografico) all'individuazione di una responsabilità attribuibile a un agente relativamente ai processi di produzione e di divulgazione che caratterizzano specificamente i beni fotografici, quindi alle diverse personalità responsabili, a vario titolo, del ciclo produttivo del bene in esame, oltre che della sua circolazione, divulgazione, commercializzazione e promozione (committenti, stampatori, ritoccatori, coloritori, editori, distributori, sponsor, curatori e responsabili di edizioni e di serie, dedicanti e dedicatari, responsabili di collezioni e di collazioni, ecc.)."</para>
    /// labels<para>"ha responsabilità"</para><para>"has responsibility"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasResponsibility">https://w3id.org/arco/ontology/context-description/hasResponsibility</seealso>
    let hasResponsibility = Prefixed_Name(cdesc, "hasResponsibility") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasResponsibilityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a resposibility relative to some production or disclosure process which characterise photographic artefacts, to its responsibility type (i.e. printers, retouchers)."</para>
    ///   <para>"Questa proprietà collega una responsabilità individuata relativamente ai processi di produzione e di divulgazione che caratterizzano specificamente i beni fotografici al tipo di responsabilità (es.: stampatori, ritoccatori, coloritori, ecc.)."</para>
    /// labels<para>"ha tipo di responsabilità"</para><para>"has responsibility type"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasResponsibilityType">https://w3id.org/arco/ontology/context-description/hasResponsibilityType</seealso>
    let hasResponsibilityType =
        Prefixed_Name(cdesc, "hasResponsibilityType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasResponsibleForInsertion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà, rappresentazione semplificata della relazione n-ary Agent Role, che rappresenta una situazione in cui un agente riveste un ruolo, collega un inventario patrimoniale al responsabile dell'inventariazione patrimoniale del bene."</para>
    ///   <para>"This property relates a current inventory to the agent responsible for the cultural entity's inventory. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness."</para>
    /// labels<para>"ha responsabile dell'immissione in patrimonio"</para><para>"has responsible for insertion"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasResponsibleForInsertion">https://w3id.org/arco/ontology/context-description/hasResponsibleForInsertion</seealso>
    let hasResponsibleForInsertion =
        Prefixed_Name(cdesc, "hasResponsibleForInsertion") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasSECCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un inventario patrimoniale alla categoria SEC attribuita al bene."</para>
    ///   <para>"This property relates a current inventory to the patrimonial category attributed to the cultural property based on the SEC classification."</para>
    /// labels<para>"has SEC category"</para><para>"ha categoria SEC"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasSECCategory">https://w3id.org/arco/ontology/context-description/hasSECCategory</seealso>
    let hasSECCategory = Prefixed_Name(cdesc, "hasSECCategory") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasSECIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un inventario patrimoniale al codice SEC (modello 15) attribuito al bene."</para>
    ///   <para>"This property relates the current inventory to the patrimonial code of a cultural property, referring to the SEC classification 1995."</para>
    /// labels<para>"ha codice SEC"</para><para>"has SEC identifier"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasSECIdentifier">https://w3id.org/arco/ontology/context-description/hasSECIdentifier</seealso>
    let hasSECIdentifier = Prefixed_Name(cdesc, "hasSECIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates the graphic or cartographic documentation to its representation scale."</para>
    ///   <para>"Questa proprietà collega la documentazione grafica e cartografica alla sua scala di rappresentazione."</para>
    /// labels<para>"has scale"</para><para>"ha scala"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasScale">https://w3id.org/arco/ontology/context-description/hasScale</seealso>
    let hasScale = Prefixed_Name(cdesc, "hasScale") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasSecondaryAuthor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un'entità al suo autore secondario, come ad esempio l'autore di un contributo o una parte di una pubblicazione."</para>
    ///   <para>"This property relates an entity to its secondary authors. For example an author of a publication's contribution or section."</para>
    /// labels<para>"ha autore secondario"</para><para>"has secondary author"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasSecondaryAuthor">https://w3id.org/arco/ontology/context-description/hasSecondaryAuthor</seealso>
    let hasSecondaryAuthor = Prefixed_Name(cdesc, "hasSecondaryAuthor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasSexEstimate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasSexEstimate">https://w3id.org/arco/ontology/context-description/hasSexEstimate</seealso>
    let hasSexEstimate = Prefixed_Name(cdesc, "hasSexEstimate") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasSexInterpretation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates an antropologic artifact to its sex estimate."</para>
    ///   <para>"Questa proprietà collega un reperto antropologico alla stima del sesso."</para>
    /// labels<para>"ha sesso stimato"</para><para>"has sex interpretation"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasSexInterpretation">https://w3id.org/arco/ontology/context-description/hasSexInterpretation</seealso>
    let hasSexInterpretation =
        Prefixed_Name(cdesc, "hasSexInterpretation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasSource">https://w3id.org/arco/ontology/context-description/hasSource</seealso>
    let hasSource = Prefixed_Name(cdesc, "hasSource") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasSpecies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a biological taxon to the subspecies, that is one of the concept of the taxon."</para>
    ///   <para>"Questa proprietà collega una tassonomia biologica alla specie, che è uno dei concetti della tassonomia."</para>
    /// labels<para>"ha specie"</para><para>"has species"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasSpecies">https://w3id.org/arco/ontology/context-description/hasSpecies</seealso>
    let hasSpecies = Prefixed_Name(cdesc, "hasSpecies") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasStratigraphicUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega uno scavo archeologico all'unità stratigrafica dalla quale proviene il bene rinvenuto nello scavo."</para>
    ///   <para>"This property relates an archeological excavation to the stratigraphic unit from which a cultural property has been found."</para>
    /// labels<para>"ha unità stratigrafica"</para><para>"has stratigraphic unit"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasStratigraphicUnit">https://w3id.org/arco/ontology/context-description/hasStratigraphicUnit</seealso>
    let hasStratigraphicUnit =
        Prefixed_Name(cdesc, "hasStratigraphicUnit") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a cultural property or a preparatory or final work of a cultural property to ist subject or ornamental motif."</para>
    ///   <para>"Questa proprietà collega un bene culturale, un'opera correlata a un bene culturale in quanto sua fase preparatoria o finale, o un apparato iconografico-decorativo di un bene culturale al suo soggetto o motivo ornamentale."</para>
    /// labels<para>"has subject"</para><para>"ha soggetto"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasSubject">https://w3id.org/arco/ontology/context-description/hasSubject</seealso>
    let hasSubject = Prefixed_Name(cdesc, "hasSubject") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasSubspecies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Questa proprietà collega una tassonomia biologica alla sottospecie, che è uno dei concetti della tassonomia."</para>
    ///   <para>"This property relates a biological taxon to the subspecies, that is one of the concept of the taxon."</para>
    /// labels<para>"has subspecies"</para><para>"ha sottospecie"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasSubspecies">https://w3id.org/arco/ontology/context-description/hasSubspecies</seealso>
    let hasSubspecies = Prefixed_Name(cdesc, "hasSubspecies") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasSurvey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un bene culturale a un'indagine effettuata sul bene stesso, per la sua individuazione, per il suo studio e per l'approfondimento delle sue caratteristiche tecniche."</para>
    ///   <para>"This property relates a cultural entity's acquisition to its acquisition type."</para>
    /// labels<para>"has survey"</para><para>"ha indagine"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasSurvey">https://w3id.org/arco/ontology/context-description/hasSurvey</seealso>
    let hasSurvey = Prefixed_Name(cdesc, "hasSurvey") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasSurveyImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a photo interpretation rendering to the survey image."</para>
    ///   <para>"Questa proprietà collega una fotointerpretazione o fotorestituzione all'immagine presa in esame nel corso dell'indagine."</para>
    /// labels<para>"has survey image"</para><para>"ha immagine di indagine"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasSurveyImage">https://w3id.org/arco/ontology/context-description/hasSurveyImage</seealso>
    let hasSurveyImage = Prefixed_Name(cdesc, "hasSurveyImage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasSurveyImageType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a survey image to its type (i.e. aerial photograph, Satellite photograph)."</para>
    ///   <para>"Questa proprietà collega una immagine di indagine al suo tipo (fotografia aerea o fotografia satellitare)."</para>
    /// labels<para>"ha tipo di immagine di indagine"</para><para>"has survey image type"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasSurveyImageType">https://w3id.org/arco/ontology/context-description/hasSurveyImageType</seealso>
    let hasSurveyImageType = Prefixed_Name(cdesc, "hasSurveyImageType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasSurveyMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un'indagine al metodo adottato nel corso dell'indagine."</para>
    ///   <para>"This property relates a survey to the method adopted in the survey."</para>
    /// labels<para>"ha metodo di indagine"</para><para>"has survey method"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasSurveyMethod">https://w3id.org/arco/ontology/context-description/hasSurveyMethod</seealso>
    let hasSurveyMethod = Prefixed_Name(cdesc, "hasSurveyMethod") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasSurveyMotivation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Questa proprietà collega uno scavo archeologico, una ricognizione archeologica, un'indagine archeometrica e diagnostica o una fotointerpretazione e fotorestituzione al motivo principale che li ha determinati."</para>
    ///   <para>"This property relates an archeological, archaeometric or diagnostic survey or a photo interpretation rendering to the the main motivation that led to it."</para>
    /// labels<para>"ha motivo di indagine"</para><para>"has survey motivation"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasSurveyMotivation">https://w3id.org/arco/ontology/context-description/hasSurveyMotivation</seealso>
    let hasSurveyMotivation =
        Prefixed_Name(cdesc, "hasSurveyMotivation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasSurveyPhotographer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un'indagine di rilevamento di un bene demo-etno-antropologico al fotografo professionista (diverso dal rilevatore) che ha effettuato la ripresa. La relazione tra il ruolo e l'agente che lo riveste è espressa nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe AgentRole, che permette di collegare l'agente e il suo ruolo."</para>
    ///   <para>"This property relates an observation survey of a demo-etno-antropologic entity to the professional photographer who took the shot. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness."</para>
    /// labels<para>"has survey photographer"</para><para>"ha fotografo dell'indagine"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasSurveyPhotographer">https://w3id.org/arco/ontology/context-description/hasSurveyPhotographer</seealso>
    let hasSurveyPhotographer =
        Prefixed_Name(cdesc, "hasSurveyPhotographer") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasSurveyScientificDirector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a survey to its scientific director."</para>
    ///   <para>"Questa proprietà collega un'indagine al suo responsabile scientifico."</para>
    /// labels<para>"has survey scientific director"</para><para>"ha responsabile scientifico dell'indagine"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasSurveyScientificDirector">https://w3id.org/arco/ontology/context-description/hasSurveyScientificDirector</seealso>
    let hasSurveyScientificDirector =
        Prefixed_Name(cdesc, "hasSurveyScientificDirector") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasSurveySoundEngineer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un'indagine di rilevamento di un bene demo-etno-antropologico al fonico professionista (diverso dal rilevatore) che ha effettuato la registrazione sonora. La relazione tra il ruolo e l'agente che lo riveste è espressa nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe AgentRole, che permette di collegare l'agente e il suo ruolo."</para>
    ///   <para>"This property relates an observation survey of a demo-etno-antropologic entity to the sound engineer who recorded it. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness."</para>
    /// labels<para>"has survey sound engineer"</para><para>"ha fonico dell'indagine"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasSurveySoundEngineer">https://w3id.org/arco/ontology/context-description/hasSurveySoundEngineer</seealso>
    let hasSurveySoundEngineer =
        Prefixed_Name(cdesc, "hasSurveySoundEngineer") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un oggetto al suo titolo. Nel caso del dominio dei beni culturali, può collegare un bene culturale o un'opera collegata al bene culturale perché sua fase finale o preparatoria (proprio, attribuito, parallelo, alternativo), oppure un'edizione al suo titolo (principale o secondario), oppure una serie fotografica al suo titolo, etc."</para>
    ///   <para>"This property relates an object to its title."</para>
    /// labels<para>"ha titolo"</para><para>"has title"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasTitle">https://w3id.org/arco/ontology/context-description/hasTitle</seealso>
    let hasTitle = Prefixed_Name(cdesc, "hasTitle") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasTitleType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a cultural entity's title to its title type."</para>
    ///   <para>"Questa proprietà collega un titolo di un bene culturale al tipo di titolo."</para>
    /// labels<para>"ha tipo di titolo"</para><para>"has title type"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasTitleType">https://w3id.org/arco/ontology/context-description/hasTitleType</seealso>
    let hasTitleType = Prefixed_Name(cdesc, "hasTitleType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasTomb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega uno scavo archeologico alla deposizione funeraria individuata durante l'indagine."</para>
    ///   <para>"This property relates an archaeological excavation to the tomb detected during the survey."</para>
    /// labels<para>"ha deposizione funeraria"</para><para>"has tomb"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasTomb">https://w3id.org/arco/ontology/context-description/hasTomb</seealso>
    let hasTomb = Prefixed_Name(cdesc, "hasTomb") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasUrbanPlanningInstrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This class relates a cultural property to the related urban planning instrument."</para>
    ///   <para>"Questa proprietà collega un bene culturale a uno strumento urbanistico-territoriale, ovvero a un piano regolatore generale e particolareggiato o a un piano paesaggistico che interessa il bene stesso."</para>
    /// labels<para>"ha strumento urbanistico-territoriale"</para><para>"has urban planning instrument"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasUrbanPlanningInstrument">https://w3id.org/arco/ontology/context-description/hasUrbanPlanningInstrument</seealso>
    let hasUrbanPlanningInstrument =
        Prefixed_Name(cdesc, "hasUrbanPlanningInstrument") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega il bene culturale con il suo uso."</para>
    ///   <para>"This property relates a cultural entity to its use."</para>
    /// labels<para>"has use"</para><para>"ha uso"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasUse">https://w3id.org/arco/ontology/context-description/hasUse</seealso>
    let hasUse = Prefixed_Name(cdesc, "hasUse") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasUseFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates an entity to its use function."</para>
    ///   <para>"Questa proprietà collega un'entità alla sua funzione d'uso."</para>
    /// labels<para>"has use function"</para><para>"ha funzione d'uso"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasUseFunction">https://w3id.org/arco/ontology/context-description/hasUseFunction</seealso>
    let hasUseFunction = Prefixed_Name(cdesc, "hasUseFunction") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasUseType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a cultural entity's use to its use type."</para>
    ///   <para>"Questa proprietà collega l'uso del bene con il suo tipo (attuale, precedente, storico)."</para>
    /// labels<para>"has use type"</para><para>"ha tipo d'uso"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasUseType">https://w3id.org/arco/ontology/context-description/hasUseType</seealso>
    let hasUseType = Prefixed_Name(cdesc, "hasUseType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasUseTypeSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega l'uso del bene con le specifiche relative al tipo di utilizzo."</para>
    ///   <para>"This property relates the use of a cultural property to the specification of the type of use."</para>
    /// labels<para>"ha specifiche del tipo d'uso"</para><para>"has use type specification"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasUseTypeSpecification">https://w3id.org/arco/ontology/context-description/hasUseTypeSpecification</seealso>
    let hasUseTypeSpecification =
        Prefixed_Name(cdesc, "hasUseTypeSpecification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasUser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates an entity to the user, intended as the agent who employed the entity."</para>
    ///   <para>"Questa proprietà collega un'entità a un utente, inteso come agente che ha fatto uso di quell'entità. Per esempio, può collegare un'occasione in cui un vestimento antico o contemporaneo è stato indossato da una persona al fruitore stesso, oppure un particolare uso di un bene culturale al tipo di utente coinvolto in quell'uso."</para>
    /// labels<para>"has user"</para><para>"ha utente"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasUser">https://w3id.org/arco/ontology/context-description/hasUser</seealso>
    let hasUser = Prefixed_Name(cdesc, "hasUser") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/hasUserSocialCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega l'utente di un bene culturale con la sua categoria sociale."</para>
    ///   <para>"This property relates the user of a cultural property to its social category."</para>
    /// labels<para>"ha categoria sociale dell'utente"</para><para>"has user social category"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/hasUserSocialCategory">https://w3id.org/arco/ontology/context-description/hasUserSocialCategory</seealso>
    let hasUserSocialCategory =
        Prefixed_Name(cdesc, "hasUserSocialCategory") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/historicalBiographicalInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà rappresenta informazioni di natura storico biografica relative a un agente."</para>
    ///   <para>"This property represents historical biographical information about an agent."</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/historicalBiographicalInformation">https://w3id.org/arco/ontology/context-description/historicalBiographicalInformation</seealso>
    let historicalBiographicalInformation =
        Prefixed_Name(cdesc, "historicalBiographicalInformation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/historicalInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"historical information"</para><para>"informazioni storiche"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/historicalInformation">https://w3id.org/arco/ontology/context-description/historicalInformation</seealso>
    let historicalInformation =
        Prefixed_Name(cdesc, "historicalInformation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/iconclassCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents the Iconclass code, for describing the subject or ornamental motif represented by the cultural property."</para>
    ///   <para>"Questa proprietà rappresenta la codifica iconclass che permette di descrivere, mediante un codice alfanumerico, il soggetto o il motivo decorativo rappresentato su un bene culturale."</para>
    /// labels<para>"Iconclass Code"</para><para>"Codifica Iconclass"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/iconclassCode">https://w3id.org/arco/ontology/context-description/iconclassCode</seealso>
    let iconclassCode = Prefixed_Name(cdesc, "iconclassCode") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/informationGatheredOnSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà rappresenta le informazioni raccolte sul luogo dove si trova il bene o sul luogo dove il bene è stato rilevato."</para>
    ///   <para>"This property represents information collected on the place where the cultural entity is located or on the place where it was detected."</para>
    /// labels<para>"informazioni raccolte sul luogo"</para><para>"information gathered on site"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/informationGatheredOnSite">https://w3id.org/arco/ontology/context-description/informationGatheredOnSite</seealso>
    let informationGatheredOnSite =
        Prefixed_Name(cdesc, "informationGatheredOnSite") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/inventoryIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents the inventory identifier attributed by a juridical container to a cultural property."</para>
    ///   <para>"Questa proprietà rappresenta il codice di inventario nella forma numerica o alfanumerica attribuita dalla struttura conservativa (soprintendenza, museo, galleria, deposito, ecc.) che ha effettuato l'inventariazione del bene."</para>
    /// labels<para>"inventory identifier"</para><para>"codice d'inventario"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/inventoryIdentifier">https://w3id.org/arco/ontology/context-description/inventoryIdentifier</seealso>
    let inventoryIdentifier =
        Prefixed_Name(cdesc, "inventoryIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/inventoryLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents the location of the inventory about a cultural property."</para>
    ///   <para>"Questa proprietà rappresenta la collocazione dell'inventario, cioè il luogo in cui è attualmente conservato l’inventario."</para>
    /// labels<para>"inventory location"</para><para>"collocazione dell'inventario"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/inventoryLocation">https://w3id.org/arco/ontology/context-description/inventoryLocation</seealso>
    let inventoryLocation = Prefixed_Name(cdesc, "inventoryLocation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/involves</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of 'is involved in', which relates a cultural entity to another involved cultural entity (e.g. immaterial)."</para>
    ///   <para>"Questa è la proprietà inversa di 'is involved in', che collega un bene culturale a un altro bene culturale collegato, di tipo immateriale, in cui è coinvolto."</para>
    /// labels<para>"involves"</para><para>"coinvolge"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/involves">https://w3id.org/arco/ontology/context-description/involves</seealso>
    let involves = Prefixed_Name(cdesc, "involves") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/involvesRelatedWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega il rapporto tra un bene culturale e un'opera collegata all'opera collegata stessa (es.: un lavoro preparatorio, un prototipo, una copia, un reimpiego di tutto il bene o di una sua parte, ecc.)."</para>
    ///   <para>"This property relates the situation in which a cultural property is related to another work with the related work itself (e.g.: a preparatory work, a prototype, a copy, a reuse, etc.)."</para>
    /// labels<para>"involves related work"</para><para>"coinvolge opera collegata"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/involvesRelatedWork">https://w3id.org/arco/ontology/context-description/involvesRelatedWork</seealso>
    let involvesRelatedWork =
        Prefixed_Name(cdesc, "involvesRelatedWork") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isAcquisitionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates an acquisition event to the cultural entity involved in the acquisition."</para>
    ///   <para>"Questa proprietà collega un evento di acquisizione al bene culturale coinvolto nell'acquisizione."</para>
    /// labels<para>"è acquisizione di"</para><para>"is acquisition of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isAcquisitionOf">https://w3id.org/arco/ontology/context-description/isAcquisitionOf</seealso>
    let isAcquisitionOf = Prefixed_Name(cdesc, "isAcquisitionOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isAcquisitionTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a cultural entity's acquisition type (i.e. donation, seizure) to its acquisition."</para>
    ///   <para>"Questa proprietà collega il tipo di acquisizione (es.: donazione, alienazione, confisca) all'acquisizione di un bene culturale."</para>
    /// labels<para>"è tipo di acqusizione di"</para><para>"is acquisition type of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isAcquisitionTypeOf">https://w3id.org/arco/ontology/context-description/isAcquisitionTypeOf</seealso>
    let isAcquisitionTypeOf =
        Prefixed_Name(cdesc, "isAcquisitionTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isActivityOperatorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has activity operator"."</para>
    ///   <para>"Questa è la proprietà inversa di "ha operatore dell'attività"."</para>
    /// labels<para>"è operatore dell'attività"</para><para>"is activity operator of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isActivityOperatorOf">https://w3id.org/arco/ontology/context-description/isActivityOperatorOf</seealso>
    let isActivityOperatorOf =
        Prefixed_Name(cdesc, "isActivityOperatorOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isActivityResponsibleOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di "ha responsabile dell'attività"."</para>
    ///   <para>"This is the inverse property of "has activity responsible"."</para>
    /// labels<para>"è responsabile dell'attività"</para><para>"is activity responsible of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isActivityResponsibleOf">https://w3id.org/arco/ontology/context-description/isActivityResponsibleOf</seealso>
    let isActivityResponsibleOf =
        Prefixed_Name(cdesc, "isActivityResponsibleOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isActivitySponsorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa a "ha sponsor dell'attività"."</para>
    ///   <para>"This is the inverse property of "has activity sponsor"."</para>
    /// labels<para>"è responsabile dell'attività"</para><para>"is activity responsible of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isActivitySponsorOf">https://w3id.org/arco/ontology/context-description/isActivitySponsorOf</seealso>
    let isActivitySponsorOf =
        Prefixed_Name(cdesc, "isActivitySponsorOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isAgeOfDeathInterpretationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates the age of death interpretation of an antropologic artifact to the its antropologic artifact."</para>
    /// labels<para>"è età della morte stimata di"</para><para>"is age of death interpretation of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isAgeOfDeathInterpretationOf">https://w3id.org/arco/ontology/context-description/isAgeOfDeathInterpretationOf</seealso>
    let isAgeOfDeathInterpretationOf =
        Prefixed_Name(cdesc, "isAgeOfDeathInterpretationOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isAgentRelatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is used to associate an agent related in some way to an entity of any kind to that entity. It is used when it is not possible to express the relation in a more specific way."</para>
    ///   <para>"Questa proprietà collega un agente che è collegato in qualche modo a un'entità di qualsiasi tipo a quell'entità. È una relazione generica che viene usata per quei casi in cui non sia possibile definire in maniera più precisa la natura della relazione."</para>
    /// labels<para>"is agent related to"</para><para>"è agente correlato a"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isAgentRelatedTo">https://w3id.org/arco/ontology/context-description/isAgentRelatedTo</seealso>
    let isAgentRelatedTo = Prefixed_Name(cdesc, "isAgentRelatedTo") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isAgentWithResponsibilityIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has agent with responsibility"."</para>
    ///   <para>"Questa è la proprietà inversa a "ha agente con responsabilità"."</para>
    /// labels<para>"è agente con responsabilità in"</para><para>"is agent with responsibility in"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isAgentWithResponsibilityIn">https://w3id.org/arco/ontology/context-description/isAgentWithResponsibilityIn</seealso>
    let isAgentWithResponsibilityIn =
        Prefixed_Name(cdesc, "isAgentWithResponsibilityIn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isAlternativeDatingTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega la tipologia di datazione alternativa con la relativa datazione."</para>
    ///   <para>"This property relates the type of an alternative dating to the related dating."</para>
    /// labels<para>"is alternative dating type"</para><para>"è datazione alternativa di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isAlternativeDatingTypeOf">https://w3id.org/arco/ontology/context-description/isAlternativeDatingTypeOf</seealso>
    let isAlternativeDatingTypeOf =
        Prefixed_Name(cdesc, "isAlternativeDatingTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isAnomalyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un'anomalia rilevata nel corso dell'indagine tramite fotointerpretazione o fotorestituzione alla relativa indagine."</para>
    ///   <para>"This property relates an anomaly revealed by a photo interepretation rendering to the related survey."</para>
    /// labels<para>"è anomalia di"</para><para>"is anomaly of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isAnomalyOf">https://w3id.org/arco/ontology/context-description/isAnomalyOf</seealso>
    let isAnomalyOf = Prefixed_Name(cdesc, "isAnomalyOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isAnomalyOriginOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega l'origine dell'anomalia (naturale, antropica, incerta) all'anomalia rilevata durante una fotointerpretazione o fotorestituzione."</para>
    ///   <para>"This property relates the origin of the anomaly (e.g. natural, unsure) to an anomaly detected during a photo interpretation or rendering survey."</para>
    /// labels<para>"è origine dell'anomalia di"</para><para>"is anomaly origin of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isAnomalyOriginOf">https://w3id.org/arco/ontology/context-description/isAnomalyOriginOf</seealso>
    let isAnomalyOriginOf = Prefixed_Name(cdesc, "isAnomalyOriginOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isAnomalyTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega il tipo di anomalia (puntuale, lineare, areale) a un'anomalia rilevata nel corso di una fotointerpretazione o fotorestituzione."</para>
    ///   <para>"This property relates the anomaly type (line, point, poligony anomaly) to an anomaly revealed by a photo interpretation rendering."</para>
    /// labels<para>"is anomaly type of"</para><para>"è tipo di anomalia di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isAnomalyTypeOf">https://w3id.org/arco/ontology/context-description/isAnomalyTypeOf</seealso>
    let isAnomalyTypeOf = Prefixed_Name(cdesc, "isAnomalyTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isArchaeologicalPropertySurveyTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates the type of a survey to the related survey on an archaeological property."</para>
    ///   <para>"Questa proprietà collega il tipo di indagine alla relativa indagine su un bene archeologico."</para>
    /// labels<para>"is archaeological property survey type of"</para><para>"è tipo di indagine su bene archeologico"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isArchaeologicalPropertySurveyTypeOf">https://w3id.org/arco/ontology/context-description/isArchaeologicalPropertySurveyTypeOf</seealso>
    let isArchaeologicalPropertySurveyTypeOf =
        Prefixed_Name(cdesc, "isArchaeologicalPropertySurveyTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isArchaeometricDiagnosticSurveyTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates the type of an arecheometric diagnostic survey (i.e. thermal imaging, coring) to the survey itself ."</para>
    ///   <para>"Questa proprietà collega il tipo d'indagine archeometrica e diagnostica (es.: analisi della malta, carotaggio, termografia, etc.) alla relativa indagine."</para>
    /// labels<para>"is archaeometric diagnostic survey type of"</para><para>"è tipo di indagine archeometrica e diagnostica di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isArchaeometricDiagnosticSurveyTypeOf">https://w3id.org/arco/ontology/context-description/isArchaeometricDiagnosticSurveyTypeOf</seealso>
    let isArchaeometricDiagnosticSurveyTypeOf =
        Prefixed_Name(cdesc, "isArchaeometricDiagnosticSurveyTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isArchivalRecordSetIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates an archival record set to the relationship (membership) between the set itself and a cultural property that is member of it."</para>
    ///   <para>"Questa proprietà, inversa a "ha unità archivistica complessa", collega una unità archivistica complessa al rapporto tra l'unità stessa e un bene culturale che ne fa parte."</para>
    /// labels<para>"è unità archivistica complessa in"</para><para>"is archival record set in"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isArchivalRecordSetIn">https://w3id.org/arco/ontology/context-description/isArchivalRecordSetIn</seealso>
    let isArchivalRecordSetIn =
        Prefixed_Name(cdesc, "isArchivalRecordSetIn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isArchivedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates the archive or conservative institution to the documentation made of sources and documents."</para>
    ///   <para>"Questa proprietà collega l'archivio e/o istituzione conservativa con la relativa documentazione costituita da fonti e documenti."</para>
    /// labels<para>"è archiviato in"</para><para>"is archived in"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isArchivedIn">https://w3id.org/arco/ontology/context-description/isArchivedIn</seealso>
    let isArchivedIn = Prefixed_Name(cdesc, "isArchivedIn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isAttributedAuthorIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has attributed author"."</para>
    ///   <para>"Questa è la proprietà inversa a "ha autore attribuito"."</para>
    /// labels<para>"è autore attribuito in"</para><para>"is attributed author in"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isAttributedAuthorIn">https://w3id.org/arco/ontology/context-description/isAttributedAuthorIn</seealso>
    let isAttributedAuthorIn =
        Prefixed_Name(cdesc, "isAttributedAuthorIn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isAuthorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates an agent to an entity the agent is author of."</para>
    ///   <para>"Questa proprietà collega un agent a una entità di qualsiasi tipo (documentazione, bene culturale, etc.) di cui quell'agente è autore."</para>
    /// labels<para>"is author of"</para><para>"è autore di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isAuthorOf">https://w3id.org/arco/ontology/context-description/isAuthorOf</seealso>
    let isAuthorOf = Prefixed_Name(cdesc, "isAuthorOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isAuthorityFileCataloguingAgencyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates the file's cataloguing institution to an entity described in a authority file."</para>
    ///   <para>"Questa proprietà collega l'ente schedatore dell'authority file a un'entità descritta in una scheda di Authority File."</para>
    /// labels<para>"is authority file cataloguing agency of"</para><para>"è ente schedatore dell'authority file di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isAuthorityFileCataloguingAgencyOf">https://w3id.org/arco/ontology/context-description/isAuthorityFileCataloguingAgencyOf</seealso>
    let isAuthorityFileCataloguingAgencyOf =
        Prefixed_Name(cdesc, "isAuthorityFileCataloguingAgencyOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isAuthorshipAttributionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property that links an authorship attribution referred to a cultural entity to that cultural entity."</para>
    ///   <para>"Proprietà che lega un'attribuzione di autore o di responsabilità relativa a un'entità culturale all'entità culturale stessa."</para>
    /// labels<para>"è attribuzione di autore/responsabilità di"</para><para>"is authorship attribution of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isAuthorshipAttributionOf">https://w3id.org/arco/ontology/context-description/isAuthorshipAttributionOf</seealso>
    let isAuthorshipAttributionOf =
        Prefixed_Name(cdesc, "isAuthorshipAttributionOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isBibliographyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a bibliography to the entity which is referred to."</para>
    ///   <para>"Questa proprietà collega una bibliografia all'entità alla quale si riferisce."</para>
    /// labels<para>"è bibliografia di"</para><para>"is bibliography of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isBibliographyOf">https://w3id.org/arco/ontology/context-description/isBibliographyOf</seealso>
    let isBibliographyOf = Prefixed_Name(cdesc, "isBibliographyOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isBibliographyTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega il tipo di riferimento bibliografico alla bibliografia."</para>
    ///   <para>"This property relates the bibliography type to its bibliography."</para>
    /// labels<para>"is bibliography type of"</para><para>"è tipo di bibliografia di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isBibliographyTypeOf">https://w3id.org/arco/ontology/context-description/isBibliographyTypeOf</seealso>
    let isBibliographyTypeOf =
        Prefixed_Name(cdesc, "isBibliographyTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isBiologicalTaxonOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a taxon to a biological entity."</para>
    ///   <para>"Questa proprietà collega una tassonomia con un'entità biologica."</para>
    /// labels<para>"è tassonomia biologica di"</para><para>"is biological taxon of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isBiologicalTaxonOf">https://w3id.org/arco/ontology/context-description/isBiologicalTaxonOf</seealso>
    let isBiologicalTaxonOf =
        Prefixed_Name(cdesc, "isBiologicalTaxonOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isChangeOfAvailabilityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a change of availability to a cultural entity."</para>
    ///   <para>"Questa proprietà collega un mutamento di condizione materiale a un'entità culturale."</para>
    /// labels<para>"è mutamento di condizione materiale di"</para><para>"is change of availability of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isChangeOfAvailabilityOf">https://w3id.org/arco/ontology/context-description/isChangeOfAvailabilityOf</seealso>
    let isChangeOfAvailabilityOf =
        Prefixed_Name(cdesc, "isChangeOfAvailabilityOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isChangeOfAvailabilityTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega il tipo di evento (es.: furto, distruzione, recupero) di mutamento di condizione materiale di un bene culturale al mutamento stesso."</para>
    ///   <para>"This property relates the event type (i.e. theft, destruction, recovery) of a cultural entity change of availability to the change itself."</para>
    /// labels<para>"is change of availability type of"</para><para>"è tipo di mutamento condizione materiale di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isChangeOfAvailabilityTypeOf">https://w3id.org/arco/ontology/context-description/isChangeOfAvailabilityTypeOf</seealso>
    let isChangeOfAvailabilityTypeOf =
        Prefixed_Name(cdesc, "isChangeOfAvailabilityTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isCircumstanceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà, inversa di 'ha circostanza', collega l'occasione che ha determinato una situazione (es. la committenza di un bene culturale, l'uso di un bene culturale ecc.) alla relativa situazione."</para>
    ///   <para>"This property, inverse of 'has circumstance' relates the circumstance which led to a situation (e.g. a cultural entity committment, a cultural entity use, etc.) to the related situation."</para>
    /// labels<para>"is circumstance of"</para><para>"è circostanza di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isCircumstanceOf">https://w3id.org/arco/ontology/context-description/isCircumstanceOf</seealso>
    let isCircumstanceOf = Prefixed_Name(cdesc, "isCircumstanceOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isCircumstanceTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega il tipo di occasione con la relativa occasione."</para>
    ///   <para>"This property relates the type of circumstance to the related circumstance."</para>
    /// labels<para>"è tipo di circostanza di"</para><para>"is circumstance type of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isCircumstanceTypeOf">https://w3id.org/arco/ontology/context-description/isCircumstanceTypeOf</seealso>
    let isCircumstanceTypeOf =
        Prefixed_Name(cdesc, "isCircumstanceTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isCoinIssuanceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has coin issuance"."</para>
    ///   <para>"Questa è la proprietà inversa a "ha emissione di moneta"."</para>
    /// labels<para>"is coin issuance of"</para><para>"è emissione di moneta"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isCoinIssuanceOf">https://w3id.org/arco/ontology/context-description/isCoinIssuanceOf</seealso>
    let isCoinIssuanceOf = Prefixed_Name(cdesc, "isCoinIssuanceOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isCoinMemberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega una moneta a una serie di monete di cui è membro."</para>
    ///   <para>"This property relates a coin to a numismatic series which is member of."</para>
    /// labels<para>"è moneta membro di"</para><para>"is coin member of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isCoinMemberOf">https://w3id.org/arco/ontology/context-description/isCoinMemberOf</seealso>
    let isCoinMemberOf = Prefixed_Name(cdesc, "isCoinMemberOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isCollectionIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a collection to the relationship (membership) between the collection itself and a cultural property that is member of it."</para>
    ///   <para>"Questa proprietà, inversa a "ha collezione", rappresenta la partecipazione di una collezione nel rapporto tra una collezione e un bene culturale che ne fa parte, in un certo intervallo di tempo."</para>
    /// labels<para>"è collezione in"</para><para>"is collection in"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isCollectionIn">https://w3id.org/arco/ontology/context-description/isCollectionIn</seealso>
    let isCollectionIn = Prefixed_Name(cdesc, "isCollectionIn") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isCollectorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a collector to its collection of cultural properties."</para>
    ///   <para>"Questa proprietà, inversa a "ha collezionista", collega un collezionista alla relativa collezione di beni culturali."</para>
    /// labels<para>"is collector of"</para><para>"è collezionista di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isCollectorOf">https://w3id.org/arco/ontology/context-description/isCollectorOf</seealso>
    let isCollectorOf = Prefixed_Name(cdesc, "isCollectorOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isCommissionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega l'individuazione di una committenza all'entità culturale che è stata commissionata."</para>
    ///   <para>"This property relates a commission to the cultural entity that was commissioned."</para>
    /// labels<para>"è committenza di"</para><para>"is commission of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isCommissionOf">https://w3id.org/arco/ontology/context-description/isCommissionOf</seealso>
    let isCommissionOf = Prefixed_Name(cdesc, "isCommissionOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isCommittentIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates an agent that is committent of a cultural property to the identification of the commission of that cultural property."</para>
    ///   <para>"Questa proprietà collega una persona o istituzione committente a una situazione in cui viene indicata la committenza di un bene culturale."</para>
    /// labels<para>"is committent in"</para><para>"è committente in"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isCommittentIn">https://w3id.org/arco/ontology/context-description/isCommittentIn</seealso>
    let isCommittentIn = Prefixed_Name(cdesc, "isCommittentIn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isCopyrightHolderIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di "ha titolare dei diritti d'autore""</para>
    ///   <para>"This is the inverse property of "has copyright holder"."</para>
    /// labels<para>"is copyright holder in"</para><para>"è titolare dei diritti d'autore in"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isCopyrightHolderIn">https://w3id.org/arco/ontology/context-description/isCopyrightHolderIn</seealso>
    let isCopyrightHolderIn =
        Prefixed_Name(cdesc, "isCopyrightHolderIn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isCopyrightOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di "ha diritti d'autore"."</para>
    ///   <para>"This is the inverse property of "is copyright of"."</para>
    /// labels<para>"sono diritti d'autore di"</para><para>"is copyright of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isCopyrightOf">https://w3id.org/arco/ontology/context-description/isCopyrightOf</seealso>
    let isCopyrightOf = Prefixed_Name(cdesc, "isCopyrightOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isCreationLocationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has creation location"."</para>
    ///   <para>"Questa è la proprietà inversa di "ha luogo di creazione"."</para>
    /// labels<para>"è luogo di realizzazione di"</para><para>"is creation location of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isCreationLocationOf">https://w3id.org/arco/ontology/context-description/isCreationLocationOf</seealso>
    let isCreationLocationOf =
        Prefixed_Name(cdesc, "isCreationLocationOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isCulturalGeographicAreaOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega l'area geografico-culturale con l'uso del bene presente."</para>
    ///   <para>"This property relates a cultural geographical area to the use of the cultural property which is present."</para>
    /// labels<para>"è area geografico-culturale di"</para><para>"is cultural geographic area of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isCulturalGeographicAreaOf">https://w3id.org/arco/ontology/context-description/isCulturalGeographicAreaOf</seealso>
    let isCulturalGeographicAreaOf =
        Prefixed_Name(cdesc, "isCulturalGeographicAreaOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isCulturalPropertyEstimateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a cultural property estimate to the estimated cultural property."</para>
    ///   <para>"Questa proprietà collega una stima di un bene culturale al bene culturale stimato."</para>
    /// labels<para>"is cultural property estimate of"</para><para>"è stima del bene culturale"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isCulturalPropertyEstimateOf">https://w3id.org/arco/ontology/context-description/isCulturalPropertyEstimateOf</seealso>
    let isCulturalPropertyEstimateOf =
        Prefixed_Name(cdesc, "isCulturalPropertyEstimateOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isCulturalPropertyStageIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This cultural property relates the stage of a cultural property referring to another entity (preparatory or final work) to this relationship between the two entities."</para>
    ///   <para>"Questa proprietà collega lo stadio di realizzazione del bene culturale in relazione a un'altra entità collegata (opera preparatoria o opera finale) al  rapporto tra il bene culturale stesso e questa entità."</para>
    /// labels<para>"is cultural property stage in"</para><para>"è stadio del bene culturale in"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isCulturalPropertyStageIn">https://w3id.org/arco/ontology/context-description/isCulturalPropertyStageIn</seealso>
    let isCulturalPropertyStageIn =
        Prefixed_Name(cdesc, "isCulturalPropertyStageIn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isCulturalScopeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega l'ambito culturale attribuito a un bene culturale alla situazione in cui è avvenuta tale attribuzione."</para>
    ///   <para>"This property relates a cultural scope of a cultural entity to the situation where this cultural scope is attributed."</para>
    /// labels<para>"è ambito culturale di"</para><para>"is cultural scope of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isCulturalScopeOf">https://w3id.org/arco/ontology/context-description/isCulturalScopeOf</seealso>
    let isCulturalScopeOf = Prefixed_Name(cdesc, "isCulturalScopeOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isDatingEventOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates an event involving the cultural property, which the dating is about, to a dating."</para>
    ///   <para>"Questa proprietà collega un evento relativo al bene culturale, cui si riferisce la specifica cronologia a una cronologia."</para>
    /// labels<para>"è evento relativo alla datazione di"</para><para>"is dating event of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isDatingEventOf">https://w3id.org/arco/ontology/context-description/isDatingEventOf</seealso>
    let isDatingEventOf = Prefixed_Name(cdesc, "isDatingEventOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isDatingOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega una cronologia all'entità cui si riferisce."</para>
    ///   <para>"This property relates a dating to an entity."</para>
    /// labels<para>"is dating of"</para><para>"è cronologia di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isDatingOf">https://w3id.org/arco/ontology/context-description/isDatingOf</seealso>
    let isDatingOf = Prefixed_Name(cdesc, "isDatingOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isDerivatedWorkTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega il tipo di opera derivata da un bene culturale alla relativa opera derivata."</para>
    ///   <para>"This property relates the type of a work derivated from a cultural entity to its work derivated."</para>
    /// labels<para>"è tipo di opera derivata di"</para><para>"is derivated work type of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isDerivatedWorkTypeOf">https://w3id.org/arco/ontology/context-description/isDerivatedWorkTypeOf</seealso>
    let isDerivatedWorkTypeOf =
        Prefixed_Name(cdesc, "isDerivatedWorkTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isDetectionMethodOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega la modalità di individuazione di un bene culturale al bene culturale stesso."</para>
    ///   <para>"This property relates the detection method of a cultural property to the cultural property itself."</para>
    /// labels<para>"is detection method of"</para><para>"è metodo di individuazione di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isDetectionMethodOf">https://w3id.org/arco/ontology/context-description/isDetectionMethodOf</seealso>
    let isDetectionMethodOf =
        Prefixed_Name(cdesc, "isDetectionMethodOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isDocumentationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a documentation to an entity. For example, it can relates a documentation concerning a cultural property described in a catalogue record to that cultural property."</para>
    ///   <para>"Questa proprietà collega una documentazione a un'entità che viene documentata. Per esempio, può collega una documentazione che riguarda il bene descritto in una scheda di catalogo al bene stesso."</para>
    /// labels<para>"è documentazione di"</para><para>"is documentation of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isDocumentationOf">https://w3id.org/arco/ontology/context-description/isDocumentationOf</seealso>
    let isDocumentationOf = Prefixed_Name(cdesc, "isDocumentationOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isDocumentationTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega il tipo di documentazione alla sua documetanzione."</para>
    ///   <para>"This property relates the type of documentation to its documentation."</para>
    /// labels<para>"è tipo di documentazione di"</para><para>"is documentation type of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isDocumentationTypeOf">https://w3id.org/arco/ontology/context-description/isDocumentationTypeOf</seealso>
    let isDocumentationTypeOf =
        Prefixed_Name(cdesc, "isDocumentationTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isEditionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates an entity's edition to the entity."</para>
    ///   <para>"Questa proprietà collega un'edizione di un'entità all'entità stessa."</para>
    /// labels<para>"è edizione di"</para><para>"is edition of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isEditionOf">https://w3id.org/arco/ontology/context-description/isEditionOf</seealso>
    let isEditionOf = Prefixed_Name(cdesc, "isEditionOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isEditorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has editor"."</para>
    ///   <para>"Questa è la proprietà inversa di "ha editore"."</para>
    /// labels<para>"is editor of"</para><para>"è editore di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isEditorOf">https://w3id.org/arco/ontology/context-description/isEditorOf</seealso>
    let isEditorOf = Prefixed_Name(cdesc, "isEditorOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isEstimateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega una stima di un'entità all'entità stimata."</para>
    ///   <para>"This property relates an estimate of an entity to that entity."</para>
    /// labels<para>"is estimate of"</para><para>"è stima di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isEstimateOf">https://w3id.org/arco/ontology/context-description/isEstimateOf</seealso>
    let isEstimateOf = Prefixed_Name(cdesc, "isEstimateOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isExportImportCertificationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un certificato di importazione/esportazione a un'entità culturale."</para>
    ///   <para>"This property relates an export import certification to a cultural entity."</para>
    /// labels<para>"è certificato di importazione/esportazione di"</para><para>"is export import certification of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isExportImportCertificationOf">https://w3id.org/arco/ontology/context-description/isExportImportCertificationOf</seealso>
    let isExportImportCertificationOf =
        Prefixed_Name(cdesc, "isExportImportCertificationOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isExportImportCertificationTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates the type (i.e. delivery confirmation certification, free movement certification etc) of an import-export certification of a cultural entity to the rrelated certification."</para>
    ///   <para>"Questa proprietà collega la tipologia (es.: attestato di libera circolazione, licenza di esportazione definitiva, ecc) di una certificazione amministrativa di circolazione ed esportazione/importazione di un bene culturale alla relativa certificazione."</para>
    /// labels<para>"is export import certification type of"</para><para>"è tipo di certificazione di esportazione o importazione di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isExportImportCertificationTypeOf">https://w3id.org/arco/ontology/context-description/isExportImportCertificationTypeOf</seealso>
    let isExportImportCertificationTypeOf =
        Prefixed_Name(cdesc, "isExportImportCertificationTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isExportOfficeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates an export office to an export/import certification."</para>
    ///   <para>"Questa proprietà collega un ufficio di esportazione a un certificazione di esportazione/importazione."</para>
    /// labels<para>"è ufficio esportazione di"</para><para>"is export office of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isExportOfficeOf">https://w3id.org/arco/ontology/context-description/isExportOfficeOf</seealso>
    let isExportOfficeOf = Prefixed_Name(cdesc, "isExportOfficeOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isFindingContextOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates the finding context of a cultural property, and in particular an anthropological material, to the related cultural property."</para>
    ///   <para>"Questa proprietà collega il contesto di rinvenimento di un bene culturale, in particolare un reperto antropologico, al bene culturale."</para>
    /// labels<para>"è contesto di rinvenimento di"</para><para>"is finding context of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isFindingContextOf">https://w3id.org/arco/ontology/context-description/isFindingContextOf</seealso>
    let isFindingContextOf = Prefixed_Name(cdesc, "isFindingContextOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isFindingContextTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega il tipo di contesto di rinvenimento di un bene culturale, e in particolare di un reperto antropologico, al suo contesto."</para>
    ///   <para>"This property relates a type of cultural property (i.e. anthropological material) finding context to its context."</para>
    /// labels<para>"is finding context type of"</para><para>"è tipo di contesto di rinvenimento di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isFindingContextTypeOf">https://w3id.org/arco/ontology/context-description/isFindingContextTypeOf</seealso>
    let isFindingContextTypeOf =
        Prefixed_Name(cdesc, "isFindingContextTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isFindingLocationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di 'ha luogo di ritrovamento'."</para>
    ///   <para>"This is the inverse property of "has finding location"."</para>
    /// labels<para>"is finding location of"</para><para>"è luogo di ritrovamento di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isFindingLocationOf">https://w3id.org/arco/ontology/context-description/isFindingLocationOf</seealso>
    let isFindingLocationOf =
        Prefixed_Name(cdesc, "isFindingLocationOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isFormatOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega il formato con la relativa documentazione."</para>
    ///   <para>"This property relates the format to the related documentation."</para>
    /// labels<para>"è formato di"</para><para>"is format of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isFormatOf">https://w3id.org/arco/ontology/context-description/isFormatOf</seealso>
    let isFormatOf = Prefixed_Name(cdesc, "isFormatOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isFruitionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates the fruition of a garment to that garment."</para>
    ///   <para>"Questa proprietà collega una fruizione di un vestimento al vestimento stesso."</para>
    /// labels<para>"è fruizione di"</para><para>"is fruition of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isFruitionOf">https://w3id.org/arco/ontology/context-description/isFruitionOf</seealso>
    let isFruitionOf = Prefixed_Name(cdesc, "isFruitionOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isGenusIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a genus to the biological taxon in which it is classified."</para>
    ///   <para>"Questa proprietà collega un genere alla tassonomia in cui è classificato."</para>
    /// labels<para>"è genere in"</para><para>"is genus in"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isGenusIn">https://w3id.org/arco/ontology/context-description/isGenusIn</seealso>
    let isGenusIn = Prefixed_Name(cdesc, "isGenusIn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isInterpretationCriterionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates an interpretation criterion to the interpretation that was based on that criterion."</para>
    ///   <para>"Questa proprietà collega un criterio interpretativo all'interpretazione che si è basata su quel criterio."</para>
    /// labels<para>"is interpretation criterion of"</para><para>"è criterio interpretativo di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isInterpretationCriterionOf">https://w3id.org/arco/ontology/context-description/isInterpretationCriterionOf</seealso>
    let isInterpretationCriterionOf =
        Prefixed_Name(cdesc, "isInterpretationCriterionOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isInterventionEligibleBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà, inversa a "ha intervento ammesso", collega un intervento allo strumento urbanistico-territoriale che ammette quell'intervento."</para>
    ///   <para>"This property, inverse of "has eligible intervention", relates an intervention to the urban planning instrument that finds eligible that intervention."</para>
    /// labels<para>"è intervento ammesso da"</para><para>"is intervention eligible by"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isInterventionEligibleBy">https://w3id.org/arco/ontology/context-description/isInterventionEligibleBy</seealso>
    let isInterventionEligibleBy =
        Prefixed_Name(cdesc, "isInterventionEligibleBy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isInterventionOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates an intervention on a cultural property to that cultural property."</para>
    ///   <para>"Questa proprietà, inversa a "ha intervento", collega un intervento, a fini conservativi o di altro tipo, che ha interessato un bene culturale, al bene stesso."</para>
    /// labels<para>"è intervento su"</para><para>"is intervention on"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isInterventionOn">https://w3id.org/arco/ontology/context-description/isInterventionOn</seealso>
    let isInterventionOn = Prefixed_Name(cdesc, "isInterventionOn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isInterventionRoleIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has intervention role"."</para>
    ///   <para>"Questa è la proprietà inversa di "ha ruolo nell'intervento"."</para>
    /// labels<para>"is intervention role in"</para><para>"è ruolo nell'intervento"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isInterventionRoleIn">https://w3id.org/arco/ontology/context-description/isInterventionRoleIn</seealso>
    let isInterventionRoleIn =
        Prefixed_Name(cdesc, "isInterventionRoleIn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isInterventionTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates the type of intervention on a cultural property to the related intervention."</para>
    ///   <para>"Questa proprietà collega il tipo di intervento, a fini conservativi o di altro tipo, che ha interessato un bene culturale al relativo intervento."</para>
    /// labels<para>"è tipo di intervento di"</para><para>"is intervention type of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isInterventionTypeOf">https://w3id.org/arco/ontology/context-description/isInterventionTypeOf</seealso>
    let isInterventionTypeOf =
        Prefixed_Name(cdesc, "isInterventionTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isInventoryIdentifierResponsibleOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega il contenitore giuridico che conserva attualmente il bene, o che lo ha conservato in passato, e che è responsabile dell'assegnazione del numero di inventario all'inventario stesso."</para>
    ///   <para>"This property relates the juridical container responsible for the inventory identifier of the cultural property to the inventory itself."</para>
    /// labels<para>"is inventory identifier responsible of"</para><para>"è responsabile di numero di inventario di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isInventoryIdentifierResponsibleOf">https://w3id.org/arco/ontology/context-description/isInventoryIdentifierResponsibleOf</seealso>
    let isInventoryIdentifierResponsibleOf =
        Prefixed_Name(cdesc, "isInventoryIdentifierResponsibleOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isInventoryOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates an inventory to a cultural property or an entity or an activity related to it."</para>
    ///   <para>"Questa proprietà collega un inventario che registra informazioni relative al bene culturale al bene culturale o alle entità o attività collegate al bene culturale."</para>
    /// labels<para>"è inventario di"</para><para>"is inventory of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isInventoryOf">https://w3id.org/arco/ontology/context-description/isInventoryOf</seealso>
    let isInventoryOf = Prefixed_Name(cdesc, "isInventoryOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isInvolvedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a cultural entity to another involved  cultural entity (e.g. immaterial)."</para>
    ///   <para>"Questa proprietà collega un bene culturale a un altro bene culturale collegato, di tipo immateriale, in cui è coinvolto."</para>
    /// labels<para>"è coinvolto in"</para><para>"is involved in"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isInvolvedIn">https://w3id.org/arco/ontology/context-description/isInvolvedIn</seealso>
    let isInvolvedIn = Prefixed_Name(cdesc, "isInvolvedIn") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isIssuerIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di "ha emittente"."</para>
    ///   <para>"This is the inverse property of "has issuer"."</para>
    /// labels<para>"è emittente in"</para><para>"is issuer in"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isIssuerIn">https://w3id.org/arco/ontology/context-description/isIssuerIn</seealso>
    let isIssuerIn = Prefixed_Name(cdesc, "isIssuerIn") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isIssuingAgencyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di "ha ente che ha emanato il provvedimento"."</para>
    ///   <para>"This is the inverse property of "has issuing agency"."</para>
    /// labels<para>"è ente che ha emanato il provvedimento"</para><para>"is issuing agency of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isIssuingAgencyOf">https://w3id.org/arco/ontology/context-description/isIssuingAgencyOf</seealso>
    let isIssuingAgencyOf = Prefixed_Name(cdesc, "isIssuingAgencyOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isIssuingStateIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has issuing state"."</para>
    ///   <para>"Questa è la proprietà inversa di "ha stato emittente"."</para>
    /// labels<para>"is issuing state in"</para><para>"è stato emittente in"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isIssuingStateIn">https://w3id.org/arco/ontology/context-description/isIssuingStateIn</seealso>
    let isIssuingStateIn = Prefixed_Name(cdesc, "isIssuingStateIn") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isKeptIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents the location of the asset in its environment, i.e. the place where it is stored when not in use."</para>
    ///   <para>"Questa proprietà rappresenta la collocazione del bene nel suo ambiente, ovvero il luogo dove esso viene riposto quando non viene usato."</para>
    /// labels<para>"è mantenuto in"</para><para>"is kept in"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isKeptIn">https://w3id.org/arco/ontology/context-description/isKeptIn</seealso>
    let isKeptIn = Prefixed_Name(cdesc, "isKeptIn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isLaboratoryTestTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega il tipo di analisi di laboratorio (es.: analisi metallurgica, analisi chimica, etc.) con la relativa analisi."</para>
    ///   <para>"This property relates the laboratory test type (i.e. chemical or metallurgical analysis) to the related laboratory test."</para>
    /// labels<para>"è tipo di analisi di laboratorio di"</para><para>"is laboratory test type of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isLaboratoryTestTypeOf">https://w3id.org/arco/ontology/context-description/isLaboratoryTestTypeOf</seealso>
    let isLaboratoryTestTypeOf =
        Prefixed_Name(cdesc, "isLaboratoryTestTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isLegalSituationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega una condizione giuridica a un'entità che si trova in quella condizione."</para>
    ///   <para>"This property relates a legal situation to an entity that is in that situation."</para>
    /// labels<para>"is legal situation of"</para><para>"è condizione giuridica di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isLegalSituationOf">https://w3id.org/arco/ontology/context-description/isLegalSituationOf</seealso>
    let isLegalSituationOf = Prefixed_Name(cdesc, "isLegalSituationOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isLocatedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a cultural entity to a connected cultural entity which constitutes its location area."</para>
    ///   <para>"Questa proprietà collega un bene culturale a un altro bene culturale collegato, che ne costituisce il luogo di collocazione."</para>
    /// labels<para>"is located in"</para><para>"è contenuto in"</para><para>"ha luogo di collocazione"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isLocatedIn">https://w3id.org/arco/ontology/context-description/isLocatedIn</seealso>
    let isLocatedIn = Prefixed_Name(cdesc, "isLocatedIn") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isLocationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà, inversa di 'is located in', collega un bene culturale a un altro bene culturale collegato, che costituisce il luogo di collocazione del primo."</para>
    ///   <para>"This property, inverse of 'is located in', relates a cultural entity to a connected cultural entity, which constitutes its location area."</para>
    /// labels<para>"è luogo di collocazione di"</para><para>"is location of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isLocationOf">https://w3id.org/arco/ontology/context-description/isLocationOf</seealso>
    let isLocationOf = Prefixed_Name(cdesc, "isLocationOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isMemberOfArchivalRecordSetOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a cultural property to the class that represents the membership relation between this cultural property and an archival record set."</para>
    ///   <para>"Questa proprietà collega un bene culturale alla classe che rappresenta l'appartenenza del bene a una unità archivistica complessa."</para>
    /// labels<para>"is member of archival record set of"</para><para>"è membro di un'unità archivistica complessa di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isMemberOfArchivalRecordSetOf">https://w3id.org/arco/ontology/context-description/isMemberOfArchivalRecordSetOf</seealso>
    let isMemberOfArchivalRecordSetOf =
        Prefixed_Name(cdesc, "isMemberOfArchivalRecordSetOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isMemberOfCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isMemberOfCollection">https://w3id.org/arco/ontology/context-description/isMemberOfCollection</seealso>
    let isMemberOfCollection =
        Prefixed_Name(cdesc, "isMemberOfCollection") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isMemberOfCollectionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un bene culturale mobile alla classe che rappresenta l'appartenenza del bene culturale a una collezione in un certo intervallo di tempo."</para>
    ///   <para>"This property relates a cultural property to the class that represents the membership relation between this cultural property and a collection."</para>
    /// labels<para>"is member of collection of"</para><para>"è membro di collezione di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isMemberOfCollectionOf">https://w3id.org/arco/ontology/context-description/isMemberOfCollectionOf</seealso>
    let isMemberOfCollectionOf =
        Prefixed_Name(cdesc, "isMemberOfCollectionOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isMemberOfPhotographicSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isMemberOfPhotographicSeries">https://w3id.org/arco/ontology/context-description/isMemberOfPhotographicSeries</seealso>
    let isMemberOfPhotographicSeries =
        Prefixed_Name(cdesc, "isMemberOfPhotographicSeries") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isMemberOfPhotographicSeriesIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un bene fotografico alla classe che rappresenta l'appartenenza del bene a una serie editoriale."</para>
    ///   <para>"This property relates a cultural property to the class that represents the membership relation between this cultural property and a photographic series."</para>
    /// labels<para>"is member of photographic series in"</para><para>"è membro di serie fotografica in"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isMemberOfPhotographicSeriesIn">https://w3id.org/arco/ontology/context-description/isMemberOfPhotographicSeriesIn</seealso>
    let isMemberOfPhotographicSeriesIn =
        Prefixed_Name(cdesc, "isMemberOfPhotographicSeriesIn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isMintIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has mint"."</para>
    ///   <para>"Questa è la proprietà inversa di "ha zecca"."</para>
    /// labels<para>"is mint in"</para><para>"è zecca in"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isMintIn">https://w3id.org/arco/ontology/context-description/isMintIn</seealso>
    let isMintIn = Prefixed_Name(cdesc, "isMintIn") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isMinterIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has minter"."</para>
    ///   <para>"Questa è la proprietà inversa di "ha zecchiere"."</para>
    /// labels<para>"in minter in"</para><para>"è zecchiere in"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isMinterIn">https://w3id.org/arco/ontology/context-description/isMinterIn</seealso>
    let isMinterIn = Prefixed_Name(cdesc, "isMinterIn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isMusicalEnsembleOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates the musical ensamble where an instument is (or were) played to the related musical instrument."</para>
    ///   <para>"Questa proprietà collega il gruppo di musicisti (bande, complessi musicali, associazioni corali, ecc.) in cui uno strumento assume, o ha assunto, abitualmente un ruolo esecutivo al relativo strumento musicale."</para>
    /// labels<para>"is musical ensemble of"</para><para>"è organico musicale di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isMusicalEnsembleOf">https://w3id.org/arco/ontology/context-description/isMusicalEnsembleOf</seealso>
    let isMusicalEnsembleOf =
        Prefixed_Name(cdesc, "isMusicalEnsembleOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isMusicianOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega una persona che assume - o ha assunto - un ruolo certo come esecutore di uno strumento musicale al relativo strumento."</para>
    ///   <para>"This property relates the person who plays (in the present or past) a certain role as a musical instrument's exectutor to the related instrument."</para>
    /// labels<para>"è musicista di"</para><para>"is musician of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isMusicianOf">https://w3id.org/arco/ontology/context-description/isMusicianOf</seealso>
    let isMusicianOf = Prefixed_Name(cdesc, "isMusicianOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isObjectAssociatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has associated object"."</para>
    ///   <para>"Questa è la proprietò inversa a "ha oggetto associato"."</para>
    /// labels<para>"is object associated to"</para><para>"è oggetto associato a"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isObjectAssociatedTo">https://w3id.org/arco/ontology/context-description/isObjectAssociatedTo</seealso>
    let isObjectAssociatedTo =
        Prefixed_Name(cdesc, "isObjectAssociatedTo") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isObservationSurveyTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates the type of observation survey (in the context, out of context) to the related observation survey."</para>
    ///   <para>"Questa proprietà collega il tipo di indagine di rilevamento (nel contesto/decontestualizzato) alla relativa indagine di rilevamento."</para>
    /// labels<para>"is observation survey type of"</para><para>"è tipo di indagine di rilevamento di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isObservationSurveyTypeOf">https://w3id.org/arco/ontology/context-description/isObservationSurveyTypeOf</seealso>
    let isObservationSurveyTypeOf =
        Prefixed_Name(cdesc, "isObservationSurveyTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isOwnerIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This class relates an agent, that is the owner of a cultural property, to the legal situation of that cultural property."</para>
    ///   <para>"Questa proprietà, inversa a "ha proprietario", rappresenta la partecipazione di un agente alla condizione giuridica di un bene culturale, di cui l'agente ha la proprietà."</para>
    /// labels<para>"is owner in"</para><para>"è proprietario in"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isOwnerIn">https://w3id.org/arco/ontology/context-description/isOwnerIn</seealso>
    let isOwnerIn = Prefixed_Name(cdesc, "isOwnerIn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isPhotographicSeriesIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a photographic series to the class that represents the membership relation between this photographic series and a cultural property that is member of it."</para>
    ///   <para>"Questa proprietà, inversa a "ha serie", collega una serie fotografica editoriale al rapporto tra la serie e un bene fotografico che ne fa parte."</para>
    /// labels<para>"is photographic series in"</para><para>"è serie fotografica in"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isPhotographicSeriesIn">https://w3id.org/arco/ontology/context-description/isPhotographicSeriesIn</seealso>
    let isPhotographicSeriesIn =
        Prefixed_Name(cdesc, "isPhotographicSeriesIn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isPreviousLocationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has previous location"."</para>
    ///   <para>"Questa è la proprietà inversa di "ha sede di provenienza"."</para>
    /// labels<para>"è sede di provenienza di"</para><para>"is previous location of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isPreviousLocationOf">https://w3id.org/arco/ontology/context-description/isPreviousLocationOf</seealso>
    let isPreviousLocationOf =
        Prefixed_Name(cdesc, "isPreviousLocationOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isPreviousOwnerOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà, inversa a "ha soggetto fonte di acquisizione", collega il soggetto fonte dell'acquisizione di un bene all'acquisizione stessa."</para>
    ///   <para>"This property relates the previous owner of a cultural property to the acquisition by a new owner."</para>
    /// labels<para>"is previous owner of"</para><para>"è soggetto fonte dell'acquisizione di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isPreviousOwnerOf">https://w3id.org/arco/ontology/context-description/isPreviousOwnerOf</seealso>
    let isPreviousOwnerOf = Prefixed_Name(cdesc, "isPreviousOwnerOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isPrimaryDocumentationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di "ha documentazione primaria"."</para>
    ///   <para>"This is the inverse property of "has primary documentation"."</para>
    /// labels<para>"è documentazione primaria di"</para><para>"is primary documentation of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isPrimaryDocumentationOf">https://w3id.org/arco/ontology/context-description/isPrimaryDocumentationOf</seealso>
    let isPrimaryDocumentationOf =
        Prefixed_Name(cdesc, "isPrimaryDocumentationOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isProfessionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has profession"."</para>
    ///   <para>"Questa è la proprietà inversa di "ha professione"."</para>
    /// labels<para>"is profession of"</para><para>"è professione di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isProfessionOf">https://w3id.org/arco/ontology/context-description/isProfessionOf</seealso>
    let isProfessionOf = Prefixed_Name(cdesc, "isProfessionOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isProponentAgencyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This property relates an agent that is a proponent agency of a protective measure of a cultural property to the protective measure or to the cultural entity itself. The relation is declared in the name of the property, but within the ontology this relation is also modeled, in a more expressive way, through the class AgentRole."</para>
    ///   <para>"Questa proprietà collega all'ente proponente, ovvero il soggetto che ha proposto il provvedimento (identificato per mezzo della denominazione per esteso oppure, nel caso di Enti accreditati dall'ICCD, del relativo codice assegnato dall'Istituto) al provvedimento di tutela relativo al bene culturale, oppure direttamente al bene culturale. La relazione tra il ruolo e l'agente che lo riveste è espressa, in maniera generica, nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe AgentRole, che permette di collegare l'agente e il suo ruolo."</para>
    /// labels<para>"è ente proponente di"</para><para>"is proponent agency of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isProponentAgencyOf">https://w3id.org/arco/ontology/context-description/isProponentAgencyOf</seealso>
    let isProponentAgencyOf =
        Prefixed_Name(cdesc, "isProponentAgencyOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isProtectiveMeasureOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates an international or national protective measure to the cultural enitity to which it is applied."</para>
    ///   <para>"Questa proprietà collega un provvedimento di tutela nazionale o internazionale al bene culturale cui si applica."</para>
    /// labels<para>"is protective measure of"</para><para>"è provvedimento di tutela di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isProtectiveMeasureOf">https://w3id.org/arco/ontology/context-description/isProtectiveMeasureOf</seealso>
    let isProtectiveMeasureOf =
        Prefixed_Name(cdesc, "isProtectiveMeasureOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isReferenceCatalogueOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di "ha repertorio di riferimento"."</para>
    ///   <para>"This is the inverse property of "has reference catalogue"."</para>
    /// labels<para>"is reference catalogue of"</para><para>"è repertorio di riferimento di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isReferenceCatalogueOf">https://w3id.org/arco/ontology/context-description/isReferenceCatalogueOf</seealso>
    let isReferenceCatalogueOf =
        Prefixed_Name(cdesc, "isReferenceCatalogueOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isRelatedToResearch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This class relates an observation survey of musical or demoetnoanthropological heritage to the research in which the catalogue record describing a cultural property was recorded (e.g.: a cataloguing campaign)"</para>
    ///   <para>"Questa proprietà collega un rilevamento di un bene musicale o demoetnoantropologico alla ricerca nell'ambito della quale è stata redatta la scheda."</para>
    /// labels<para>"is related to research"</para><para>"si riferisce a ricerca"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isRelatedToResearch">https://w3id.org/arco/ontology/context-description/isRelatedToResearch</seealso>
    let isRelatedToResearch =
        Prefixed_Name(cdesc, "isRelatedToResearch") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isRelatedWorkInvolvedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a work related to a cultural property (e.g.: a preparatory work, a prototype, a copy, a reuse, etc.) to the situation in which that work is related to the cultural property itself."</para>
    ///   <para>"Questa proprietà collega un'opera collegata a un bene culturale al rapporto tra l'opera e il bene culturale (es.: un lavoro preparatorio, un prototipo, una copia, un reimpiego di tutto il bene o di una sua parte, ecc.)"</para>
    /// labels<para>"is related work involved in"</para><para>"è opera collegata coinvolta in"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isRelatedWorkInvolvedIn">https://w3id.org/arco/ontology/context-description/isRelatedWorkInvolvedIn</seealso>
    let isRelatedWorkInvolvedIn =
        Prefixed_Name(cdesc, "isRelatedWorkInvolvedIn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isRelatedWorkSituationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property, inverse of 'has related work situation', relates a situation in which a cultural property is related to another work, that could even be another cultural property, to the cultural property."</para>
    ///   <para>"Questa proprietà, inversa di 'ha rapporto con opera collegata', collega la relazione tra il bene culturale e un'altra opera che ne costituisce una fase preparatoria o che ne rappresenta la fase finale al bene culturale stesso."</para>
    /// labels<para>"is related work situation of"</para><para>"è rapporto con opera collegata di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isRelatedWorkSituationOf">https://w3id.org/arco/ontology/context-description/isRelatedWorkSituationOf</seealso>
    let isRelatedWorkSituationOf =
        Prefixed_Name(cdesc, "isRelatedWorkSituationOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isReliabilityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates the reliability of the information collected during the survey to a photo interpretation rendering survey."</para>
    ///   <para>"Questa proprietà collega il livello di affidabilità delle informazioni rilevate nell'indagine a una fotointerpretazione o fotorestituzione."</para>
    /// labels<para>"è affidabilità di"</para><para>"is reliability of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isReliabilityOf">https://w3id.org/arco/ontology/context-description/isReliabilityOf</seealso>
    let isReliabilityOf = Prefixed_Name(cdesc, "isReliabilityOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isReproducedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega una stampa con la sua riproduzione contenuta in una pubblicazione, di cui la stampa è, o è stata, parte integrante."</para>
    ///   <para>"This property relates a print to the reproduction of that print in a publication."</para>
    /// labels<para>"is reproduced by"</para><para>"è riprodotto da"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isReproducedBy">https://w3id.org/arco/ontology/context-description/isReproducedBy</seealso>
    let isReproducedBy = Prefixed_Name(cdesc, "isReproducedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isReproductionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has reproduction"."</para>
    ///   <para>"Questa è la proprietà inversa di "ha riproduzione"."</para>
    /// labels<para>"è riproduzione di"</para><para>"is reproduction of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isReproductionOf">https://w3id.org/arco/ontology/context-description/isReproductionOf</seealso>
    let isReproductionOf = Prefixed_Name(cdesc, "isReproductionOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isReproductionPositionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega la posizione fisica della riproduzione di una stampa all'interno di una pubblicazione (es.: frontespizio, copertina, colophon, etc.). con la relativa riproduzione della stampa."</para>
    ///   <para>"This property relates the position of the print reproduction in a publication to the print reproduction itself."</para>
    /// labels<para>"is reproduction position of"</para><para>"è posizione della riproduzione di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isReproductionPositionOf">https://w3id.org/arco/ontology/context-description/isReproductionPositionOf</seealso>
    let isReproductionPositionOf =
        Prefixed_Name(cdesc, "isReproductionPositionOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isResearchOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a research from which has been produced a cultural entity's catalogue record, to the cultural entity."</para>
    ///   <para>"Questa proprietà la ricerca nell'ambito della quale è stata redatta la scheda su un bene culturale al bene stesso."</para>
    /// labels<para>"è ricerca su"</para><para>"is research on"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isResearchOn">https://w3id.org/arco/ontology/context-description/isResearchOn</seealso>
    let isResearchOn = Prefixed_Name(cdesc, "isResearchOn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isResearchScientificDirectorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega il responsabile scientifico di una ricerca alla ricerca."</para>
    ///   <para>"This property relates the research's scientific responsible to its research."</para>
    /// labels<para>"is research scientific director of"</para><para>"è  responsabile scientifico della ricerca di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isResearchScientificDirectorOf">https://w3id.org/arco/ontology/context-description/isResearchScientificDirectorOf</seealso>
    let isResearchScientificDirectorOf =
        Prefixed_Name(cdesc, "isResearchScientificDirectorOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isResponsibilityFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates the attribution of a responsibility to an agent, relating to the activities of production and dissemination of photographic heritage (e.g.: committent, editor, printer, dedicatee, etc.) to photographic heritage."</para>
    /// labels<para>"è responsibilità su"</para><para>"is responsibility for"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isResponsibilityFor">https://w3id.org/arco/ontology/context-description/isResponsibilityFor</seealso>
    let isResponsibilityFor =
        Prefixed_Name(cdesc, "isResponsibilityFor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isResponsibilityTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega al tipo di responsabilità (es.: stampatori, ritoccatori, coloritori, ecc.) alla relativa responsabilità individuata relativamente ai processi di produzione e di divulgazione che caratterizzano specificamente i beni fotografici."</para>
    ///   <para>"This property relates the esponsibility type (i.e. printers, retouchers) to the related resposibility relative to some production or disclosure process which characterise photographic artefacts."</para>
    /// labels<para>"è tipo di responsabilità di"</para><para>"is responsibility type of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isResponsibilityTypeOf">https://w3id.org/arco/ontology/context-description/isResponsibilityTypeOf</seealso>
    let isResponsibilityTypeOf =
        Prefixed_Name(cdesc, "isResponsibilityTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isResponsibleForInsertionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates the agent responsible for the cultural entity's inventory to the current inventory."</para>
    ///   <para>"Questa proprietà collega il responsabile dell'inventariazione patrimoniale del bene all'inventario patrimoniale."</para>
    /// labels<para>"is responsible for insertion of"</para><para>"è responsabile dell'immissione in patrimonio di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isResponsibleForInsertionOf">https://w3id.org/arco/ontology/context-description/isResponsibleForInsertionOf</seealso>
    let isResponsibleForInsertionOf =
        Prefixed_Name(cdesc, "isResponsibleForInsertionOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isReusedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a cultural entity to a connected cultural entity that reuse it or a part of it."</para>
    ///   <para>"Questa proprietà collega un bene culturale a un altro bene culturale collegato che lo riutilizza in tutto o in parte."</para>
    /// labels<para>"is reused by"</para><para>"è riutilizzato in"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isReusedBy">https://w3id.org/arco/ontology/context-description/isReusedBy</seealso>
    let isReusedBy = Prefixed_Name(cdesc, "isReusedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isScaleOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates the representation scale to its graphic or cartographic representation."</para>
    ///   <para>"Questa proprietà collega la scala di rappresentazione alla documentazione grafica e cartografica."</para>
    /// labels<para>"è scala di"</para><para>"is scale of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isScaleOf">https://w3id.org/arco/ontology/context-description/isScaleOf</seealso>
    let isScaleOf = Prefixed_Name(cdesc, "isScaleOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isSecondaryAuthorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates the secondary authors of an entity (i.e. a publication's contribution or section) to the related entity."</para>
    ///   <para>"Questa proprietà collega l'autore secondario di un entità, come ad esempio un contributo o una parte di una pubblicazione, all'entità stessa."</para>
    /// labels<para>"is secondary author of"</para><para>"è autore secondario di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isSecondaryAuthorOf">https://w3id.org/arco/ontology/context-description/isSecondaryAuthorOf</seealso>
    let isSecondaryAuthorOf =
        Prefixed_Name(cdesc, "isSecondaryAuthorOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isSexInterpretationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates the sex estimate of an antropologic artifact to the related artifact."</para>
    ///   <para>"Questa proprietà collega la stima del sesso di un reperto antropologico al reperto stesso."</para>
    /// labels<para>"is sex interpretation of"</para><para>"è interpretazione del sesso di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isSexInterpretationOf">https://w3id.org/arco/ontology/context-description/isSexInterpretationOf</seealso>
    let isSexInterpretationOf =
        Prefixed_Name(cdesc, "isSexInterpretationOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isSpeciesIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a species to the biological taxon in which it is classified."</para>
    ///   <para>"Questa proprietà collega una specie alla tassonomia in cui è classificata."</para>
    /// labels<para>"è specie in"</para><para>"is species in"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isSpeciesIn">https://w3id.org/arco/ontology/context-description/isSpeciesIn</seealso>
    let isSpeciesIn = Prefixed_Name(cdesc, "isSpeciesIn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isStratigraphicUnitOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega l'unità stratigrafica dalla quale proviene il bene rinvenuto nello scavo al relativo scavo archeologico."</para>
    ///   <para>"This property relates the stratigraphic unit from which a cultural property has been found to the related archeological excavation."</para>
    /// labels<para>"is stratigraphic unit of"</para><para>"è unità stratigrafica di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isStratigraphicUnitOf">https://w3id.org/arco/ontology/context-description/isStratigraphicUnitOf</seealso>
    let isStratigraphicUnitOf =
        Prefixed_Name(cdesc, "isStratigraphicUnitOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isSubjectOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà, inversa a "ha soggetto", collega un soggetto o motivo ornamentale al bene culturale o a un'opera correlata a un bene culturale in quanto sua fase preparatoria o finale o a un apparato iconografico-decorativo su cui è rappresentato."</para>
    ///   <para>"This property relates a subject or ornamental motif to the cultural property or to the final or preparatory work of a cultural property."</para>
    /// labels<para>"è soggetto di"</para><para>"is subject of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isSubjectOf">https://w3id.org/arco/ontology/context-description/isSubjectOf</seealso>
    let isSubjectOf = Prefixed_Name(cdesc, "isSubjectOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isSubspeciesIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a subspecies to the biological taxon in which it is classified."</para>
    ///   <para>"Questa proprietà collega una sottospecie alla tassonomia in cui è classificata."</para>
    /// labels<para>"is subspecies in"</para><para>"è sottospecie in"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isSubspeciesIn">https://w3id.org/arco/ontology/context-description/isSubspeciesIn</seealso>
    let isSubspeciesIn = Prefixed_Name(cdesc, "isSubspeciesIn") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isSurveyImageOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di "ha immagine di indagine"."</para>
    ///   <para>"This is the inverse property of "has survey image"."</para>
    /// labels<para>"è immagine di indagine"</para><para>"is survey image of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isSurveyImageOf">https://w3id.org/arco/ontology/context-description/isSurveyImageOf</seealso>
    let isSurveyImageOf = Prefixed_Name(cdesc, "isSurveyImageOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isSurveyImageTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega il tipo una immagine di indagine (fotografia aerea o fotografia satellitare). con la relativa immagine di indagine."</para>
    ///   <para>"This property relates the type of a survey image (i.e. aerial photograph, Satellite photograph) to the related survey image."</para>
    /// labels<para>"is survey image type of"</para><para>"è tipo di immagine di indagine di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isSurveyImageTypeOf">https://w3id.org/arco/ontology/context-description/isSurveyImageTypeOf</seealso>
    let isSurveyImageTypeOf =
        Prefixed_Name(cdesc, "isSurveyImageTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isSurveyMethodOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega il metodo adottato nel corso di un'indagine all'indagine stessa."</para>
    ///   <para>"This property relates the method adopted in a survey to the survey itself."</para>
    /// labels<para>"è metodo di indagine di"</para><para>"is survery method of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isSurveyMethodOf">https://w3id.org/arco/ontology/context-description/isSurveyMethodOf</seealso>
    let isSurveyMethodOf = Prefixed_Name(cdesc, "isSurveyMethodOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isSurveyMotivationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega il motivo principale che ha determinato uno scavo archeologico, una ricognizione archeologica, un'indagine archeometrica e diagnostica o una fotointerpretazione e fotorestituzione a ciascuno di essi."</para>
    ///   <para>"This property relates the main motivation that led to an archeological, archaeometric or diagnostic survey or a photo interpretation rendering to each of them."</para>
    /// labels<para>"is survey motivation of"</para><para>"è motivo di indagine di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isSurveyMotivationOf">https://w3id.org/arco/ontology/context-description/isSurveyMotivationOf</seealso>
    let isSurveyMotivationOf =
        Prefixed_Name(cdesc, "isSurveyMotivationOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isSurveyOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a cultural entity's survey to the cultural entity."</para>
    ///   <para>"Questa proprietà collega un'indagine effettuata su un bene culturale al bene stesso."</para>
    /// labels<para>"è indagine su"</para><para>"is survey on"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isSurveyOn">https://w3id.org/arco/ontology/context-description/isSurveyOn</seealso>
    let isSurveyOn = Prefixed_Name(cdesc, "isSurveyOn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isSurveyPhotographerOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates the professional photographer who took the shot to the observation survey of a demo-etno-antropologic entity."</para>
    ///   <para>"Questa proprietà collega il fotografo professionista (diverso dal rilevatore) che ha effettuato l'indagine all'indagine di rilevamento di un bene demo-etno-antropologico."</para>
    /// labels<para>"is observation photographer of"</para><para>"è fotografo dell'indagine di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isSurveyPhotographerOf">https://w3id.org/arco/ontology/context-description/isSurveyPhotographerOf</seealso>
    let isSurveyPhotographerOf =
        Prefixed_Name(cdesc, "isSurveyPhotographerOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isSurveyScientificDirectorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega il responsabile scientifico di un'indagine alla relativa indagine."</para>
    ///   <para>"This property relates the scientific director of a survey to the related survey."</para>
    /// labels<para>"is survey scientific director of"</para><para>"è responsabile scientifico dell'indagine di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isSurveyScientificDirectorOf">https://w3id.org/arco/ontology/context-description/isSurveyScientificDirectorOf</seealso>
    let isSurveyScientificDirectorOf =
        Prefixed_Name(cdesc, "isSurveyScientificDirectorOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isSurveySoundEngineerOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega il fonico professionista (diverso dal rilevatore) che ha effettuato la registrazione sonora all'indagine di rilevamento di un bene demo-etno-antropologico."</para>
    ///   <para>"This property relates the sound engineer who recorded an observation survey to the related observation survey of a demo-etno-antropologic entity."</para>
    /// labels<para>"è fonico dell'indagine di"</para><para>"is survey sound engineer of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isSurveySoundEngineerOf">https://w3id.org/arco/ontology/context-description/isSurveySoundEngineerOf</seealso>
    let isSurveySoundEngineerOf =
        Prefixed_Name(cdesc, "isSurveySoundEngineerOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isTitleOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a title to the entity to which it is referred."</para>
    ///   <para>"Questa proprietà collega un titolo all'entità cui si riferisce."</para>
    /// labels<para>"is title of"</para><para>"è titolo di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isTitleOf">https://w3id.org/arco/ontology/context-description/isTitleOf</seealso>
    let isTitleOf = Prefixed_Name(cdesc, "isTitleOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isTitleTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates the type of a cultural entity title to its title."</para>
    ///   <para>"Questa proprietà collega il tipo di titolo di un bene culturale al relativo titolo."</para>
    /// labels<para>"è tipo di titolo di"</para><para>"is title type of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isTitleTypeOf">https://w3id.org/arco/ontology/context-description/isTitleTypeOf</seealso>
    let isTitleTypeOf = Prefixed_Name(cdesc, "isTitleTypeOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isTombOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di "ha deposizione funeraria"."</para>
    ///   <para>"This is the inverse property of "has tomb"."</para>
    /// labels<para>"è deposizione funeraria di"</para><para>"is tomb of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isTombOf">https://w3id.org/arco/ontology/context-description/isTombOf</seealso>
    let isTombOf = Prefixed_Name(cdesc, "isTombOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isUrbanPlanningInstrumentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This class relates a urban planning instrument to the related cultural property."</para>
    ///   <para>"Questa proprietà collega uno strumento urbanistico-territoriale, ovvero un piano regolatore generale e particolareggiato o un piano paesaggistico che interessa un bene culturale al bene stesso."</para>
    /// labels<para>"è strumento urbanistico-territoriale di"</para><para>"is urban planning instrument of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isUrbanPlanningInstrumentOf">https://w3id.org/arco/ontology/context-description/isUrbanPlanningInstrumentOf</seealso>
    let isUrbanPlanningInstrumentOf =
        Prefixed_Name(cdesc, "isUrbanPlanningInstrumentOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isUseFunctionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates the use function of an entity to the related entity."</para>
    ///   <para>"Questa proprietà collega la funzione d'uso di un'entità alla relativa entità."</para>
    /// labels<para>"è funzione d'uso di"</para><para>"is use function of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isUseFunctionOf">https://w3id.org/arco/ontology/context-description/isUseFunctionOf</seealso>
    let isUseFunctionOf = Prefixed_Name(cdesc, "isUseFunctionOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isUseOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates the use of a cultural entity to the related cultural property."</para>
    ///   <para>"Questa proprietà collega l'uso di un bene culturale con il bene culturale stesso."</para>
    /// labels<para>"è uso di"</para><para>"is use of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isUseOf">https://w3id.org/arco/ontology/context-description/isUseOf</seealso>
    let isUseOf = Prefixed_Name(cdesc, "isUseOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isUseTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates the type of a cultural entity use to its use."</para>
    ///   <para>"Questa proprietà collega il tipo di uso del bene (attuale, precedente, storico) con il suo uso."</para>
    /// labels<para>"is use type of"</para><para>"è tipo d'uso di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isUseTypeOf">https://w3id.org/arco/ontology/context-description/isUseTypeOf</seealso>
    let isUseTypeOf = Prefixed_Name(cdesc, "isUseTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isUseTypeSpecificationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega le specifiche relative al tipo di utilizzo di un bene con il relativo uso."</para>
    ///   <para>"This property relates the specification of the type of a cultural property use to the related use."</para>
    /// labels<para>"è specifica del tipo di uso di"</para><para>"is use type specification of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isUseTypeSpecificationOf">https://w3id.org/arco/ontology/context-description/isUseTypeSpecificationOf</seealso>
    let isUseTypeSpecificationOf =
        Prefixed_Name(cdesc, "isUseTypeSpecificationOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isUserOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un utente, inteso come agente che ha fatto uso di un'entità, all'entità stessa."</para>
    ///   <para>"This property relates the user, intended as the agent who employed an entity, to the related entity."</para>
    /// labels<para>"è utente di"</para><para>"is user of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isUserOf">https://w3id.org/arco/ontology/context-description/isUserOf</seealso>
    let isUserOf = Prefixed_Name(cdesc, "isUserOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/isWorkRelatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa a "ha opera collegata"."</para>
    ///   <para>"This is the inverse property of "has related work"."</para>
    /// labels<para>"è opera collegata a"</para><para>"is work related to"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/isWorkRelatedTo">https://w3id.org/arco/ontology/context-description/isWorkRelatedTo</seealso>
    let isWorkRelatedTo = Prefixed_Name(cdesc, "isWorkRelatedTo") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/issueDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This property represents issue date of an administrative provision or a certification."</para>
    ///   <para>"Questa proprietà rappresenta la data di emissione di un provvedimento amministrativo o di una certificazione (es.: per la circolazione, esportazione/importazione di un bene culturale)"</para>
    /// labels<para>"data di emissione"</para><para>"issue date"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/issueDate">https://w3id.org/arco/ontology/context-description/issueDate</seealso>
    let issueDate = Prefixed_Name(cdesc, "issueDate") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/methodOfInsertion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà rappresenta, a testo libero, le modalità di acquisizione del bene nel patrimonio."</para>
    ///   <para>"This property represents how the cultural entity was inserted inside a collection."</para>
    /// labels<para>"method of insertion"</para><para>"modalità di acquisizione"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/methodOfInsertion">https://w3id.org/arco/ontology/context-description/methodOfInsertion</seealso>
    let methodOfInsertion = Prefixed_Name(cdesc, "methodOfInsertion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/noticeDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Questa proprietà rappresenta la data della notifica del provvedimento amministrativo al proprietario."</para>
    ///   <para>"This property represents the date of notification of the administrative provision to the owner."</para>
    /// labels<para>"data di notifica"</para><para>"notice date"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/noticeDate">https://w3id.org/arco/ontology/context-description/noticeDate</seealso>
    let noticeDate = Prefixed_Name(cdesc, "noticeDate") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/numberInCirculation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Questa proprietà rappresenta la numerazione dell'esemplare della fotografia o della stampa all'interno della tiratura e il numero complessivo degli esemplari tirati, qualora la fotografia o la stampa risalgano a una tiratura. Nel caso delle fotografie, per tiratura si intende un insieme prestabilito e limitato di esemplari (uguali) tratti dallo stesso negativo o dalla stessa, ovvero non modificata, fotografia digitale (o dalla stessa serie di matrici), numerati progressivamente."</para>
    ///   <para>"This property represents photograph copies numbering."</para>
    /// labels<para>"number in circulation"</para><para>"numero nella tiratura"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/numberInCirculation">https://w3id.org/arco/ontology/context-description/numberInCirculation</seealso>
    let numberInCirculation =
        Prefixed_Name(cdesc, "numberInCirculation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/openingNoticeDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Questa proprietà rappresenta la data (nella forma “aaaa/mm/gg”) della comunicazione di avvio del procedimento di dichiarazione di interesse al proprietario, possessore o detentore."</para>
    ///   <para>"This property represents date of interest declaration communication to the owner or holder."</para>
    /// labels<para>"data di comunicazione di avvio"</para><para>"opening notice date"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/openingNoticeDate">https://w3id.org/arco/ontology/context-description/openingNoticeDate</seealso>
    let openingNoticeDate = Prefixed_Name(cdesc, "openingNoticeDate") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/overlapSpecifications</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà rappresenta le specifiche per effettuare sovrapposizioni con altri documenti utili per la lettura e l'interpretazione dell'immagine analizzata durante uan fotointerpretazione o fotorestituzione."</para>
    ///   <para>"This property represents specifications to make overlaps with other documents useful for reading and interpreting image analyzed during a photointerpretation or photo-repayment."</para>
    /// labels<para>"overlap specifications"</para><para>"specifiche sulla sovrapposizione"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/overlapSpecifications">https://w3id.org/arco/ontology/context-description/overlapSpecifications</seealso>
    let overlapSpecifications =
        Prefixed_Name(cdesc, "overlapSpecifications") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/pageOrTableNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà rappresenta le informazioni relative al numero della pagina o numero della tavola della pubblicazione in cui compare la stampa."</para>
    ///   <para>"This property represents information about page number or table number of publication in which the print appears."</para>
    /// labels<para>"numero di pagina o tavola"</para><para>"page or table number"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/pageOrTableNumber">https://w3id.org/arco/ontology/context-description/pageOrTableNumber</seealso>
    let pageOrTableNumber = Prefixed_Name(cdesc, "pageOrTableNumber") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/parallelTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents the parallel title of a cultural property."</para>
    ///   <para>"Questa proprietà rappresenta un titolo parallelo, cioè lo stesso titolo principale tradotto in altre lingue e presentato come equivalente."</para>
    /// labels<para>"titolo parallelo"</para><para>"parallel title"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/parallelTitle">https://w3id.org/arco/ontology/context-description/parallelTitle</seealso>
    let parallelTitle = Prefixed_Name(cdesc, "parallelTitle") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/photographicSeriesItemNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Questa proprietà rappresenta la numerazione della fotografia all'interno della serie fotografica editoriale."</para>
    ///   <para>"This property represents numbering of the photograph within editorial photographic series."</para>
    /// labels<para>"series item number"</para><para>"numero dell'item all'interno della serie"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/photographicSeriesItemNumber">https://w3id.org/arco/ontology/context-description/photographicSeriesItemNumber</seealso>
    let photographicSeriesItemNumber =
        Prefixed_Name(cdesc, "photographicSeriesItemNumber") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/photographicSubseriesItemNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents numbering of the photograph within the editorial photographic subseries."</para>
    ///   <para>"Questa proprietà rappresenta la numerazione della fotografia all'interno della sottoserie fotografica editoriale."</para>
    /// labels<para>"photographic subseries item number"</para><para>"numero dell'item all'interno della sottoserie fotografica"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/photographicSubseriesItemNumber">https://w3id.org/arco/ontology/context-description/photographicSubseriesItemNumber</seealso>
    let photographicSubseriesItemNumber =
        Prefixed_Name(cdesc, "photographicSubseriesItemNumber") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/preparatoryOrFinalWorkLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents geographical location and specific location of the work derived from the cultural property."</para>
    ///   <para>"Questa proprietà rappresenta la localizzazione geografica e collocazione specifica dell'opera derivata dal bene culturale."</para>
    /// labels<para>"preparatory or final work location"</para><para>"collocazione dell'opera preparatoria o finale"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/preparatoryOrFinalWorkLocation">https://w3id.org/arco/ontology/context-description/preparatoryOrFinalWorkLocation</seealso>
    let preparatoryOrFinalWorkLocation =
        Prefixed_Name(cdesc, "preparatoryOrFinalWorkLocation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/preparatoryOrFinalWorkPreviousLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà rappresenta le informazioni relative all'antica o precedente l'attuale collocazione dell'opera da cui è tratta la matrice o la stampa presso collezioni, palazzi, chiese, ecc., quando questa è segnalata sulla matrice/stampa o sicuramente deducibile dalle fonti bibliografiche."</para>
    ///   <para>"This property represents information relating to ancient or previous location of the work from which the matrix or print is ​​drawn."</para>
    /// labels<para>"preparatory or final work previous location"</para><para>"collocazione precedente dell'opera preparatoria o finale"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/preparatoryOrFinalWorkPreviousLocation">https://w3id.org/arco/ontology/context-description/preparatoryOrFinalWorkPreviousLocation</seealso>
    let preparatoryOrFinalWorkPreviousLocation =
        Prefixed_Name(cdesc, "preparatoryOrFinalWorkPreviousLocation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/preparatoryOrFinalWorkRecordIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents the code which identifies the record relating to the final or preparatory work in relation with the cultural property."</para>
    ///   <para>"Questa proprietà rappresenta il codice, qualora esista, che identifica la scheda relativa all'opera finale o preparatoria in relazione con il bene culturale."</para>
    /// labels<para>"preparatory or final work record identifier"</para><para>"codice della scheda dell'opera originale o finale"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/preparatoryOrFinalWorkRecordIdentifier">https://w3id.org/arco/ontology/context-description/preparatoryOrFinalWorkRecordIdentifier</seealso>
    let preparatoryOrFinalWorkRecordIdentifier =
        Prefixed_Name(cdesc, "preparatoryOrFinalWorkRecordIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/properTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents the proper title of a cultural property."</para>
    ///   <para>"Rappresenta il titolo proprio del soggetto di una stampa, di una matrice incisa o di una fotografia. Per titolo proprio di una stampa si intende il titolo principale nella forma in cui appare sulla stampa o sulla matrice stessa. Per titolo proprio (principale) di una fotografia, si intende nella forma in cui appare nell'immagine (o su uno dei suoi supporti, o nelle schede a campi testuali, o nei commenti sonori presenti all'interno del file contenente l'immagine digitale). Per la normativa F, Il titolo proprio include anche ogni eventuale titolo alternativo (altre denominazioni dell'opera che appaiano insieme al titolo principale) e, facoltativamente, i complementi del titolo proprio (ossia sottotitoli od ulteriori indicazioni che contribuiscono a qualificare più specificamente il contenuto dell'immagine)."</para>
    /// labels<para>"propert title"</para><para>"titolo proprio"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/properTitle">https://w3id.org/arco/ontology/context-description/properTitle</seealso>
    let properTitle = Prefixed_Name(cdesc, "properTitle") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/provenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà rappresenta, a testo libero, la provenienza del bene acquisito nel patrimonio."</para>
    ///   <para>"This property represents origin of the cultural entity acquired in the heritage."</para>
    /// labels<para>"provenienza"</para><para>"provenance"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/provenance">https://w3id.org/arco/ontology/context-description/provenance</seealso>
    let provenance = Prefixed_Name(cdesc, "provenance") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/refersToSurveys</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà rappresenta altre indagini cui fa riferimento un'indagine volta a elaborare una diagnosi di una paleopatologia rilevata in un reperto antropologico."</para>
    ///   <para>"This property represents other investigations referred to in a survey aimed at developing a diagnosis of a paleopathology found in an anthropological finding."</para>
    /// labels<para>"fa riferimento a indagini"</para><para>"refers to surveys"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/refersToSurveys">https://w3id.org/arco/ontology/context-description/refersToSurveys</seealso>
    let refersToSurveys = Prefixed_Name(cdesc, "refersToSurveys") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/registrationDateOrGU</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents the date of the registration or the number of the Official Journal on which the decree was published."</para>
    ///   <para>"Questa proprietà rappresenta la data dell'avvenuta trascrizione al registro immobiliare, quando trattasi di vincoli imposti con leggi che richiedano la trascrizione, o il numero della Gazzetta Ufficiale su cui è stato pubblicato il decreto."</para>
    /// labels<para>"data di registrazione o gazzetta ufficiale"</para><para>"registration date or official journal"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/registrationDateOrGU">https://w3id.org/arco/ontology/context-description/registrationDateOrGU</seealso>
    let registrationDateOrGU =
        Prefixed_Name(cdesc, "registrationDateOrGU") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/relatedWorkNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà rappresenta note generali sulle relazioni instaurate fra il bene in esame e altre opere."</para>
    ///   <para>"This property represents general notes on the relationships established between the property in question and other works."</para>
    /// labels<para>"related work note"</para><para>"note su opere collegate"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/relatedWorkNote">https://w3id.org/arco/ontology/context-description/relatedWorkNote</seealso>
    let relatedWorkNote = Prefixed_Name(cdesc, "relatedWorkNote") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/relevantLegalAct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents any references to documents that affect cultural entity acquisition."</para>
    ///   <para>"Questa proprietà rappresenta, a testo libero, eventuali riferimenti a documenti (atti amministrativi; riproduzioni digitali di registri inventariali, ecc.) che interessano l'acquisizione del bene nel patrimonio. Rappresenta anche i dati relativi ai registri inventariali in vigore, ma comunque dotati di qualità storica."</para>
    /// labels<para>"relevant legal act"</para><para>"riferimento agli atti"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/relevantLegalAct">https://w3id.org/arco/ontology/context-description/relevantLegalAct</seealso>
    let relevantLegalAct = Prefixed_Name(cdesc, "relevantLegalAct") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/report</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Questa proprietà rappresenta il referto di un'indagine archeometrica e diagnostica o di una tipologia particolare di bene archeologico, ovvero i reperti antropologici."</para>
    ///   <para>"ICCD Normativa Trasversale 4.00: RE/IND/INDT - ICCD Normativa AT 3.00: IN/INI/INIR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"This property represents the report of a anthropological finding's archaeometric and diagnostic investigation."</para>
    /// labels<para>"referto"</para><para>"report"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/report">https://w3id.org/arco/ontology/context-description/report</seealso>
    let report = Prefixed_Name(cdesc, "report") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/reproduces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega la riproduzione dell'immagine contenuta nella pubblicazione di cui la stampa è, o è stata, parte integrante con la stampa stessa."</para>
    ///   <para>"This property relates the reproduction of an print in a publication to the print itself."</para>
    /// labels<para>"riproduce"</para><para>"reproduces"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/reproduces">https://w3id.org/arco/ontology/context-description/reproduces</seealso>
    let reproduces = Prefixed_Name(cdesc, "reproduces") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/reuses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di 'è riutilizzato da', che collega un bene culturale a un altro bene culturale collegato che lo riutilizza in tutto o in parte."</para>
    ///   <para>"This is the invers property of 'is reused by', which relates a cultural entity to a connected cultural entity that reuse it or a part of it."</para>
    /// labels<para>"riutilizza"</para><para>"reuses"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/reuses">https://w3id.org/arco/ontology/context-description/reuses</seealso>
    let reuses = Prefixed_Name(cdesc, "reuses") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/rights</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This property represents information on rights management."</para>
    ///   <para>"Questa proprietà rappresenta le informazioni a testo libero sulla gestione dei diritti. Nel caso di un bene culturale, permette di rappresentare indicazioni sulla presenza dei privilegi, autorizzazioni, licenze, specificando il concedente, eventualmente riportando anche il periodo di tempo della privativa."</para>
    /// labels<para>"gestione diritti"</para><para>"rights"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/rights">https://w3id.org/arco/ontology/context-description/rights</seealso>
    let rights = Prefixed_Name(cdesc, "rights") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/sex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents anthropological finding estimated sex."</para>
    ///   <para>"Questa proprietà rappresenta il sesso stimato nel contesto della stima del sesso di un reperto antropologico."</para>
    /// labels<para>"sesso stimato"</para><para>"estimated sex"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/sex">https://w3id.org/arco/ontology/context-description/sex</seealso>
    let sex = Prefixed_Name(cdesc, "sex") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/specificTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates the event (creation, distruction) to which a dating of a cultural property is related to the "specific time", as the dating expressed in year or as a date yyyy/mm/dd."</para>
    ///   <para>"Questa proprietà collega l'evento (realizzazione, demolizione, etc.) cui si riferisce una specifica cronologia di un bene culturale alla cronologia specifica, cioè la cronologia in anni (anche a cavallo di secoli diversi) o con date precise (nella forma "aaaa/mm/gg"). Nel caso in cui la cronologia corrisponda ad uno specifico anno, l'intervallo di tempo avrà lo stesso valore per data di inizio e data di fine."</para>
    /// labels<para>"specific time"</para><para>"cronologia specifica"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/specificTime">https://w3id.org/arco/ontology/context-description/specificTime</seealso>
    let specificTime = Prefixed_Name(cdesc, "specificTime") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/specificTimeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates the "specific time", as the dating expressed in year or as a date yyyy/mm/dd, with the event (creation, distruction) to which a dating of a cultural property is related to."</para>
    ///   <para>"Questa proprietà collega la cronologia specifica, cioè la cronologia in anni (anche a cavallo di secoli diversi) o con date precise (nella forma "aaaa/mm/gg") con l'evento (realizzazione, demolizione, etc.) cui si riferisce una specifica cronologia di un bene culturale."</para>
    /// labels<para>"cronologia specifica di"</para><para>"specific time of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/specificTimeOf">https://w3id.org/arco/ontology/context-description/specificTimeOf</seealso>
    let specificTimeOf = Prefixed_Name(cdesc, "specificTimeOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/stripRunAndFrameNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents aerial photos information about run and frame."</para>
    ///   <para>"Questa proprietà rappresenta, per le foto aeree, le informazioni relative alla strisciata e al fotogramma."</para>
    /// labels<para>"strisciata/numero fotogramma"</para><para>"strip run/frame number"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/stripRunAndFrameNumber">https://w3id.org/arco/ontology/context-description/stripRunAndFrameNumber</seealso>
    let stripRunAndFrameNumber =
        Prefixed_Name(cdesc, "stripRunAndFrameNumber") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà rappresenta il soggetto rappresentato da un bene culturale o il suo motivo decorativo."</para>
    ///   <para>"This property represents the subject of a cultural property, or its ornamental motif."</para>
    /// labels<para>"soggetto"</para><para>"subject"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/subject">https://w3id.org/arco/ontology/context-description/subject</seealso>
    let subject = Prefixed_Name(cdesc, "subject") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/surveyImageIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This property represents the identification code that identifies the image examined during a photo-interpretation or photo-restoration investigation."</para>
    ///   <para>"Questa proprietà rappresenta il codice identificativo che individua l'immagine presa in esame nel corso di un'indagine di fotointerpretazione o fotorestituzione."</para>
    /// labels<para>"identificativo immagine di indagine"</para><para>"survey image identifier"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/surveyImageIdentifier">https://w3id.org/arco/ontology/context-description/surveyImageIdentifier</seealso>
    let surveyImageIdentifier =
        Prefixed_Name(cdesc, "surveyImageIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/taxonAuthorAndDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents the author that described the species and the date of description."</para>
    ///   <para>"Questa proprietà rappresenta l'autore che ha descritto la specie e l'anno di descrizione."</para>
    /// labels<para>"taxon author and date"</para><para>"autore e data della tassonomia"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/taxonAuthorAndDate">https://w3id.org/arco/ontology/context-description/taxonAuthorAndDate</seealso>
    let taxonAuthorAndDate = Prefixed_Name(cdesc, "taxonAuthorAndDate") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/technicalDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà rappresenta la documentazione relativa alle informazioni rilevate nel corso dell'indagine su reperto antropologico."</para>
    ///   <para>"This property represents documentation relating to information collected during survey on anthropological evidence."</para>
    /// labels<para>"documentazione tecnica"</para><para>"technical documentation"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/technicalDocumentation">https://w3id.org/arco/ontology/context-description/technicalDocumentation</seealso>
    let technicalDocumentation =
        Prefixed_Name(cdesc, "technicalDocumentation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà rappresenta il titolo del soggetto di un bene culturale. La proprietà viene specificata in sottoproprietà per esprimere tipologie di titolo specifiche. Per la normativa trasversale è il titolo più noto e accreditato; nelle altre normative si specifica che è il titolo dato dall'autore o la denominazione tradizionale del soggetto."</para>
    ///   <para>"This property represents the title of a cultural property."</para>
    /// labels<para>"title"</para><para>"titolo"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/title">https://w3id.org/arco/ontology/context-description/title</seealso>
    let title = Prefixed_Name(cdesc, "title") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/useConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"use conditions"</para><para>"modalità di uso"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/useConditions">https://w3id.org/arco/ontology/context-description/useConditions</seealso>
    let useConditions = Prefixed_Name(cdesc, "useConditions") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/context-description/useFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents object function."</para>
    ///   <para>"Questa proprietà rappresenta la funzione che l'oggetto ha o ha avuto."</para>
    /// labels<para>"funzione d'uso"</para><para>"use function"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/context-description/useFunction">https://w3id.org/arco/ontology/context-description/useFunction</seealso>
    let useFunction = Prefixed_Name(cdesc, "useFunction") |> PrefixedName
