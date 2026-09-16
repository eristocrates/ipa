#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module cdesc =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/arco/ontology/context-description/" "cdesc"

    let AccompanyingBibliography = _prefixId.prefix "AccompanyingBibliography"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: TU/ACQ^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This class represents a situation in which a cultural property is acquired, passing from an owner to another, and has a particular legal situation.rdfs:comment : Questa classe rappresenta un evento in cui un bene culturale è stato acquisito e si trova in una certa condizione giuridica.</para>
    ///   <para>dc11:description : An example of usage of the class 'Acquisition' is the following:
    ///
    /// resource:Acquisition/1200865053-acquisition-1
    ///         a  cd:Acquisition ;
    ///         rdfs:label  "Acquisition 1 of cultural property: 1200865053"@it ;
    ///         cd:hasAcquisitionType resource:AcquisitionType/donazione ;
    ///         cd:hasPreviousOwner resource:Agent/auriti-giacinto ;
    ///         tiapit:time "1963" .dc11:description : Un esempio d'uso della classe 'Acquisizione' è il seguente:
    ///
    /// resource:Acquisition/1200865053-acquisition-1
    ///         a  cd:Acquisition ;
    ///         rdfs:label  "Acquisizione 1 del bene culturale: 1200865053"@it ;
    ///         cd:hasAcquisitionType resource:AcquisitionType/donazione ;
    ///         cd:hasPreviousOwner resource:Agent/auriti-giacinto ;
    ///         tiapit:time "1963" .</para>
    ///   <para>rdfs:label : Acquisitionrdfs:label : Acquisizione</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/Acquisition">cdesc:Acquisition</a>
    /// </summary>
    let Acquisition = _prefixId.prefix "Acquisition"
    /// <summary>
    ///   <para>rdfs:comment : This class represents the type of acquisition (e.g. purchase, donation, etc.) of a cultural property.rdfs:comment : Questa classe rappresenta il tipo di acquisizione (es.: acquisto, alienazione, confisca, donazione) che ha interessato il bene culturale.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : Tipo di acquisizionerdfs:label : Acquisition type</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: TU/ACQ/ACQT^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/AcquisitionType">cdesc:AcquisitionType</a>
    /// </summary>
    let AcquisitionType = _prefixId.prefix "AcquisitionType"
    let AerialPhotograph = _prefixId.prefix "AerialPhotograph"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Interpretazione dell'età della morterdfs:label : Age of death interpretation</para>
    ///   <para>rdfs:comment : This class represents the interpretation of the age of death of an anthropological material.rdfs:comment : Questa classe rappresenta la stima dell'età della morte di un reperto antropologico.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa AT: DA/SEM^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/AgeOfDeathInterpretation">cdesc:AgeOfDeathInterpretation</a>
    /// </summary>
    let AgeOfDeathInterpretation = _prefixId.prefix "AgeOfDeathInterpretation"

    /// <summary>
    ///   <para>ctlog:iccdNormTag : AU/AAT^^xsd:string</para>
    ///   <para>rdfs:comment : Questa classe rappresenta un'attribuzione di autore superata, alternativa o tradizionale.rdfs:comment : This class represents an authorship attribution alternative to the preferred one.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Attribuzione Alternativa di Autorerdfs:label : Alternative Authorship Attribution</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/AlternativeAuthorshipAttribution">cdesc:AlternativeAuthorshipAttribution</a>
    /// </summary>
    let AlternativeAuthorshipAttribution = _prefixId.prefix "AlternativeAuthorshipAttribution"

    /// <summary>
    ///   <para>rdfs:label : Alternative datingrdfs:label : Datazione alternativa</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This class represents an alternative dating of a cultural property (e.g.: an obsolete dating, a dating based on another method of dating).rdfs:comment : Questa classe rappresenta una eventuale altra datazione che può riguardare un bene culturale (es.: datazione tradizionale, altro metodo di datazione).</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: DT/ADT.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/AlternativeDating">cdesc:AlternativeDating</a>
    /// </summary>
    let AlternativeDating = _prefixId.prefix "AlternativeDating"
    /// <summary>
    ///   <para>rdfs:label : Tipo di datazione alternativardfs:label : Alternative dating type</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa classe rappresenta il tipo di datazione alternativa che può riguardare un bene culturale (es.: altro metodo di datazione, datazione superata)rdfs:comment : This class represents the type of alternative dating of a cultural property (different dating, obsolete dating, other method dating)</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: DT/ADT/ADTT.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/AlternativeDatingType">cdesc:AlternativeDatingType</a>
    /// </summary>
    let AlternativeDatingType = _prefixId.prefix "AlternativeDatingType"
    let AlternativeTitle = _prefixId.prefix "AlternativeTitle"
    /// <summary>
    ///   <para>rdfs:comment : Questa classe rappresenta un'anomalia rilevata nel corso di una fotointerpretazione o fotorestituzione.rdfs:comment : This class represents an anomaly detected during a photo interpretation or rendering.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : Anomaliardfs:label : Anomaly</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RE/FOI/FOIA^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/Anomaly">cdesc:Anomaly</a>
    /// </summary>
    let Anomaly = _prefixId.prefix "Anomaly"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa classe rappresenta l'origine dell'anomalia rilevata nell'indagine di fotointerpretazione o fotorestituzione.rdfs:comment : This class represents the anomaly origin of the photo interpretation rendering.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RE/FOI/FOIA^^xsd:string</para>
    ///   <para>rdfs:label : Origine dell'anomaliardfs:label : Anomaly origin</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/AnomalyOrigin">cdesc:AnomalyOrigin</a>
    /// </summary>
    let AnomalyOrigin = _prefixId.prefix "AnomalyOrigin"
    /// <summary>
    ///   <para>rdfs:label : Anomaly typerdfs:label : Tipo di anomalia</para>
    ///   <para>rdfs:comment : Questa classe rappresenta il tipo di anomalia (puntuale, lineare, areale) rilevata durante una fotointerpretazione o fotorestituzione.rdfs:comment : This class represents the type of anomaly (line anomaly, point anomaly, polygon anomaly) observed during a photo interpretation or rendering survey.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RE/FOI/FOIQ^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/AnomalyType">cdesc:AnomalyType</a>
    /// </summary>
    let AnomalyType = _prefixId.prefix "AnomalyType"
    let AnthropicOrigin = _prefixId.prefix "AnthropicOrigin"
    /// <summary>
    ///   <para>rdfs:label : Archaeological excavationrdfs:label : Scavo archeologico</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This class represents a particular type of survey on a cultural property, that is an archaeological (stratigraphic) excavation.rdfs:comment : Questa classe rappresenta un tipo particolare di indagine su bene culturale, ovvero uno scavo archeologico, inteso come scavo stratigrafico.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RE/DSC^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/ArchaeologicalExcavation">cdesc:ArchaeologicalExcavation</a>
    /// </summary>
    let ArchaeologicalExcavation = _prefixId.prefix "ArchaeologicalExcavation"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This class represents a particular type of survey on a cultural property, that is an archaeological field survey, limited to the surface.rdfs:comment : Questa classe rappresenta un tipo particolare di indagine su bene culturale, ovvero una ricognizione archeologica, intesa come ricognizione di superficie.</para>
    ///   <para>rdfs:label : Archaeological field surveyrdfs:label : Ricognizione archeologica</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RE/RCG^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/ArchaeologicalFieldSurvey">cdesc:ArchaeologicalFieldSurvey</a>
    /// </summary>
    let ArchaeologicalFieldSurvey = _prefixId.prefix "ArchaeologicalFieldSurvey"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This class represents a particular type of survey on a cultural property, that is a survey on anthropological materials (e.g.: chemical analysis, histological analysis, CT scan, etc.).rdfs:comment : Questa classe rappresenta un'indagine su una tipologia particolare di bene archeologico, ovvero i reperti antropologici (es.: analisi istologica, analisi chimica, TC, etc.).</para>
    ///   <para>rdfs:label : Indagine su bene archeologicordfs:label : Archaeological property survey</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa AT 3.01: IN/INI^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/ArchaeologicalPropertySurvey">cdesc:ArchaeologicalPropertySurvey</a>
    /// </summary>
    let ArchaeologicalPropertySurvey = _prefixId.prefix "ArchaeologicalPropertySurvey"

    /// <summary>
    ///   <para>rdfs:comment : This class represents the type of archaeological property survey.rdfs:comment : Questa classe rappresenta il tipo di indagine su bene archeologico.</para>
    ///   <para>rdfs:label : Archaeological property survey typerdfs:label : Tipo di indagine su bene archeologico</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa AT 3.01: IN/INI/INIT^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/ArchaeologicalPropertySurveyType">cdesc:ArchaeologicalPropertySurveyType</a>
    /// </summary>
    let ArchaeologicalPropertySurveyType = _prefixId.prefix "ArchaeologicalPropertySurveyType"

    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Indagine archeometrica e diagnosticardfs:label : Archaeometric and diagnostic survey</para>
    ///   <para>rdfs:comment : This class represents a particular type of survey on a cultural property, that is an archaeometric and diagnostic survey (coring, geophysical prospecting, etc.).rdfs:comment : Questa classe rappresenta un tipo particolare di indagine su bene culturale, ovvero un'indagine archeometrica e diagnostica (carotaggi, prospezioni geofisiche, analisi di vario tipo).</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RE/IND - ICCD normative di versioni precedenti: RE/AIN</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/ArchaeometricDiagnosticSurvey">cdesc:ArchaeometricDiagnosticSurvey</a>
    /// </summary>
    let ArchaeometricDiagnosticSurvey = _prefixId.prefix "ArchaeometricDiagnosticSurvey"

    /// <summary>
    ///   <para>rdfs:label : Tipo di indagine archeometrica e diagnosticardfs:label : Archaeometric diagnostic survey type</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RE/IND/INDI - ICCD normative di versioni precedenti: RE/AIN/AINT</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa classe rappresenta il tipo di indagine archeometrica e diagnostica (es.: analisi della malta, carotaggio, termografia, etc.)rdfs:comment : This class represents the type of archaeometric and diagnostic survey (e.g. coring)</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/ArchaeometricDiagnosticSurveyType">cdesc:ArchaeometricDiagnosticSurveyType</a>
    /// </summary>
    let ArchaeometricDiagnosticSurveyType = _prefixId.prefix "ArchaeometricDiagnosticSurveyType"

    /// <summary>
    ///   <para>rdfs:comment : Questa classe rappresenta un fondo archivistico.rdfs:comment : This class represents an archival fonds.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa F: UB/UBF/UBFP^^xsd:string</para>
    ///   <para>rdfs:label : Archival fondsrdfs:label : Fondo archivistico</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/ArchivalFonds">cdesc:ArchivalFonds</a>
    /// </summary>
    let ArchivalFonds = _prefixId.prefix "ArchivalFonds"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa F: UB/UBF^^xsd:string</para>
    ///   <para>rdfs:comment : Questa classe rappresenta una unità documentaria che fa parte di una unità archivistica complessa.rdfs:comment : This class represents the archival record that is part of an archival record set.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : Archival recordrdfs:label : Unità documentaria</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/ArchivalRecord">cdesc:ArchivalRecord</a>
    /// </summary>
    let ArchivalRecord = _prefixId.prefix "ArchivalRecord"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa F: UB/UBF^^xsd:string</para>
    ///   <para>rdfs:label : Unità archivistica complessardfs:label : Archival record set</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>dc11:description : An example of usage of on of the subclasses of the class 'Archival Record Set' is the following:
    /// resource:ArchivalSubseries/museo-civico-romano
    ///         a           cd:ArchivalSubseries ;
    ///         rdfs:label  "Museo Civico Romano" ;
    ///         cd:isArchivalRecordSetIn resource:ArchivalRecordSetMembership/1201251092 ;
    ///         core:isComponentOf resource:ArchivalSeries/brescia .dc11:description : Un esempio d'uso di una delle sottoclassi di 'Unità archivistica complessa' è il seguente:
    /// resource:ArchivalSubseries/museo-civico-romano
    ///         a           cd:ArchivalSubseries ;
    ///         rdfs:label  "Museo Civico Romano" ;
    ///         cd:isArchivalRecordSetIn resource:ArchivalRecordSetMembership/1201251092 ;
    ///         core:isComponentOf resource:ArchivalSeries/brescia .</para>
    ///   <para>rdfs:comment : Questa classe rappresenta un'unità archivistica complessa (fondo, serie, sottoserie, etc.) di cui un bene culturale può fare parte.rdfs:comment : This class represents an archival record set (fonds, series, subseries) of which a cultural property can be member.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/ArchivalRecordSet">cdesc:ArchivalRecordSet</a>
    /// </summary>
    let ArchivalRecordSet = _prefixId.prefix "ArchivalRecordSet"
    /// <summary>
    ///   <para>rdfs:comment : This class represents the membership of a cultural property in an archival record set.rdfs:comment : Questa classe rappresenta l'appartenenza di un bene culturale a un'unità archivistica complessa (fondo, serie, sottoserie, etc.).</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa F: UB/UBF^^xsd:string</para>
    ///   <para>rdfs:label : Archival record set membershiprdfs:label : Appartenenza a unità archivistica complessa</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/ArchivalRecordSetMembership">cdesc:ArchivalRecordSetMembership</a>
    /// </summary>
    let ArchivalRecordSetMembership = _prefixId.prefix "ArchivalRecordSetMembership"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa F: UB/UBF/UBFS^^xsd:string</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This class represents an archival series.rdfs:comment : Questa classe rappresenta una serie archivistica.</para>
    ///   <para>rdfs:label : Serie archivisticardfs:label : Archival series</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/ArchivalSeries">cdesc:ArchivalSeries</a>
    /// </summary>
    let ArchivalSeries = _prefixId.prefix "ArchivalSeries"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : Sottoserie archivisticardfs:label : Archival subseries</para>
    ///   <para>rdfs:comment : This class represents an archival subseries, that is component of an archival series.rdfs:comment : Questa classe rappresenta una sottoserie archivistica, ovvero una partizione interna alla serie.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa F: UB/UBF/UBFT^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/ArchivalSubseries">cdesc:ArchivalSubseries</a>
    /// </summary>
    let ArchivalSubseries = _prefixId.prefix "ArchivalSubseries"
    let AttachedDocumentation = _prefixId.prefix "AttachedDocumentation"
    let AttributedTitle = _prefixId.prefix "AttributedTitle"
    /// <summary>
    ///   <para>rdfs:comment : Questa classe rappresenta la documentazione audio relativa a un oggetto, per esempio a un bene culturale.rdfs:comment : This class represents the audio documentation of an object, e.g. a cultural property.</para>
    ///   <para>rdfs:label : Audio documentationrdfs:label : Documentazione audio</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : DO/REG</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/AudioDocumentation">cdesc:AudioDocumentation</a>
    /// </summary>
    let AudioDocumentation = _prefixId.prefix "AudioDocumentation"
    /// <summary>
    ///   <para>rdfs:label : Attribuzione di Autore o responsabilitàrdfs:label : Authorship Attribution</para>
    ///   <para>rdfs:comment : Questa classe rappresenta l'attribuzione di un autore o di una responsabilità per la creazione di un bene culturale, cioè le informazioni relative ai soggetti (persone singole o enti collettivi) intervenuti nella realizzazione del bene e/o all'ambito culturale di riferimento.rdfs:comment : This class represents the attribution of authorship or a responsibility for the creation of a cultural property, referring to the agents that played a role in the creation of the cultural property or to the reference cultural scope.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: AU/AAT; AU/ATB; AU/AUT^^xsd:string</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/AuthorshipAttribution">cdesc:AuthorshipAttribution</a>
    /// </summary>
    let AuthorshipAttribution = _prefixId.prefix "AuthorshipAttribution"
    /// <summary>
    ///   <para>rdfs:comment : This class represents the bibliography of an entity, e.g. a cultural property.rdfs:comment : Questa classe rappresenta un riferimento bibliografico che riguarda un'entità, per esempio un bene culturale.</para>
    ///   <para>rdfs:label : Bibliografiardfs:label : Bibliography</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DO/BIB; RE/RCG/RCGS - Normative VeAC e AT 3.01: DO/BIB; DO/BSE.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/Bibliography">cdesc:Bibliography</a>
    /// </summary>
    let Bibliography = _prefixId.prefix "Bibliography"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normative OA-OAC-MI-D-S-RA-TMA-CA-MA-SAS-SI 3.00: DO/BIB/BIBX - Normative VeAC e AT 3.01: DO/BSE/BSEX.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Bibliography categoryrdfs:label : Genere della bibliografia</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la categoria della bibliografia. Nel contesto delle normative per la catalogazione ICCD, questa classe ha associato un vocabolario chiuso definito in tre tipi: bibliografia specifica, bibliografia di confronto e bibliografia di corredo.rdfs:comment : This class represents the category associated to a bibliography (e.g. accompanying bibliography, comparative bibliography, specific bibliography).</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/BibliographyCategory">cdesc:BibliographyCategory</a>
    /// </summary>
    let BibliographyCategory = _prefixId.prefix "BibliographyCategory"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale DO/BIB/BIBF - Normative VeAC e AT 3.01: DO/BSE/BSES.</para>
    ///   <para>rdfs:comment : This class represents the type of bibliography.rdfs:comment : Questa classe rappresenta il tipo di riferimento bibliografico.</para>
    ///   <para>rdfs:label : Bibliography typerdfs:label : Tipo di bibliografia</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/BibliographyType">cdesc:BibliographyType</a>
    /// </summary>
    let BibliographyType = _prefixId.prefix "BibliographyType"
    /// <summary>
    ///   <para>rdfs:comment : This class represents a biological taxon.rdfs:comment : Questa classe rappresenta una tassonomia biologica, ossia i criteri con cui si ordinano gli organismi in un sistema di classificazione.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : Biological taxonrdfs:label : Tassonomia biologica</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa AT: OG/OGS^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/BiologicalTaxon">cdesc:BiologicalTaxon</a>
    /// </summary>
    let BiologicalTaxon = _prefixId.prefix "BiologicalTaxon"
    let BuildingUse = _prefixId.prefix "BuildingUse"
    /// <summary>
    ///   <para>rdfs:comment : Questa classe rappresenta un evento che modifica la disponibilità materiale del bene culturale (es. per distruzione, furto, perdita, recupero)rdfs:comment : This class represents the change of availability of a cultural property (e.g.: theft, distruction, rescue, etc.)</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: TU/ALN^^xsd:string</para>
    ///   <para>rdfs:label : Mutamento condizione materialerdfs:label : Change of availability</para>
    ///   <para>dc11:description : Un esempio d'uso della classe 'Mutamento condizione materiale' è il seguente: resource:ChangeOfAvailability/0900041230-change-of-availability
    ///         a  cd:ChangeOfAvailability ;
    ///         rdfs:label "Mutamento condizione materiale del bene culturale: 0900041230"@it ;
    ///         cd:hasChangeOfAvailabilityType resource:ChangeOfAvailabilityType/furto ;
    ///         tiapit:time "1998/11/15" .dc11:description : An example of usage of the class 'Change of availability' is the following: resource:ChangeOfAvailability/0900041230-change-of-availability
    ///         a  cd:ChangeOfAvailability ;
    ///         rdfs:label "Change of availability of cultural property: 0900041230"@en ;
    ///         cd:hasChangeOfAvailabilityType resource:ChangeOfAvailabilityType/furto ;
    ///         tiapit:time "1998/11/15" .</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/ChangeOfAvailability">cdesc:ChangeOfAvailability</a>
    /// </summary>
    let ChangeOfAvailability = _prefixId.prefix "ChangeOfAvailability"
    /// <summary>
    ///   <para>rdfs:comment : This class represents the type of change of availability of a cultural property (e.g. theft, distruction)rdfs:comment : Questa classe rappresenta il tipo di mutamento di condizione materiale di un bene culturale (es.: furto, distruzione, recupero).</para>
    ///   <para>rdfs:label : Tipo di mutamento condizione materialerdfs:label : Change of availability type</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: TU/ALN/ALNT^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/ChangeOfAvailabilityType">cdesc:ChangeOfAvailabilityType</a>
    /// </summary>
    let ChangeOfAvailabilityType = _prefixId.prefix "ChangeOfAvailabilityType"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: UT/UTU/UTUO - Normativa BDM: UT/UTO; AU/CMM/CMMC - Normativa VeAC: AU/FRU/FRUC - Normativa F: LR/LRO - Normativa BDI: CA^^xsd:string</para>
    ///   <para>rdfs:label : Occasionrdfs:label : Circumstancerdfs:label : Occasione</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This class represents a circumstance that influenced a particular situation, e.g. the circumstance for which a cultural property was commissioned, tha circumstance in which a cultural property was used, etc.rdfs:comment : Questa classe rappresenta un'occasione che ha determinato una certa situazione, per esempio l'occasione per cui è stato commissionato un bene culturale, l'occasione che ha determinato la ripresa di un bene fotografico, l'occasione d'uso di un bene, l'occasione di un bene demoetnoantropologico immateriale.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/Circumstance">cdesc:Circumstance</a>
    /// </summary>
    let Circumstance = _prefixId.prefix "Circumstance"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa BDI: CA/CAR; CA/CAC^^xsd:string</para>
    ///   <para>rdfs:label : Circumstance typerdfs:label : Tipo di circostanza</para>
    ///   <para>rdfs:comment : Questa classe rappresenta il tipo di occasione (es.: civile, religiosa).rdfs:comment : This class represents the circumstance type (e.g.: civil, religious)rdfs:comment : This class represents the type of circumstance (e.g. civil, religious)</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/CircumstanceType">cdesc:CircumstanceType</a>
    /// </summary>
    let CircumstanceType = _prefixId.prefix "CircumstanceType"
    let CivilCircumstance = _prefixId.prefix "CivilCircumstance"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Coin issuancerdfs:label : Emissione di moneta</para>
    ///   <para>rdfs:comment : Questa classe rappresenta l'emissione di una moneta, intesa come un evento collocato nel tempo, cui partecipano diversi agenti con diversi ruoli (Stato emittente, Zecca, Monetiere, etc.)rdfs:comment : This class represents the issuance of a coin, at a particular time and with different agents participanting to it (Mint, Issuing State, etc.)</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa NU: DA/AUE - ICCD Normativa OA (dopo il rilascio della specifica scheda NU nel 2004 la scheda OA non è stata più utilizzata per la catalogazione di monete e medaglie): AU/EDT</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/CoinIssuance">cdesc:CoinIssuance</a>
    /// </summary>
    let CoinIssuance = _prefixId.prefix "CoinIssuance"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : UB/COL^^xsd:string</para>
    ///   <para>rdfs:label : Appartenenza a Collezionerdfs:label : Collection Membership</para>
    ///   <para>rdfs:comment : This class represents the membership of a cultural property in a collection.rdfs:comment : Questa classe rappresenta l'appartenenza di un bene culturale a una collezione, in un certo intervallo di tempo. Uno stesso bene culturale può aver fatto parte di più collezioni nel corso del tempo.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/CollectionMembership">cdesc:CollectionMembership</a>
    /// </summary>
    let CollectionMembership = _prefixId.prefix "CollectionMembership"
    /// <summary>
    ///   <para>rdfs:label : Committenzardfs:label : Commission</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: AU/CMM^^xsd:string</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa classe rappresenta l'individuazione della committenza relativa a un bene culturale.rdfs:comment : This class represents the commission of a cultural property.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/Commission">cdesc:Commission</a>
    /// </summary>
    let Commission = _prefixId.prefix "Commission"
    let ComparativeBibliography = _prefixId.prefix "ComparativeBibliography"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: CO/RST quando RSTI='consolidamento' or 'controllo microclimatico' or 'trattamento biocida-disinfestazione' or 'rimozione di elementi non originali' or 'pulitura meccanica' or 'pulitura chimica' or 'protezione finale' or 'riadesione parti' or 'trattamento parti metalliche' - Normative di versioni precedenti: RS/RST</para>
    ///   <para>rdfs:comment : This class represents a conservation intervention on a cultural property (e.g.: microclimatic inspection, mechanical cleaning or with chemicals, pest control, etc.)rdfs:comment : Questa classe rappresenta un particolare tipo di intervento che ha interessato un bene culturale, cioè un intervento a fini conservativi (termine che sostituisce l'obsoleto "restauro", presente nelle versioni di normativa precedenti alla 4.00). Per esempio: consolidamento, controllo microclimatico, trattamento biocida-disinfestazione, rimozione di elementi non originali, pulitura meccanica, pulitura chimica, protezione finale, riadesione parti, trattamento parti metalliche.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Intervento a fini conservativirdfs:label : Conservation Intervention</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/ConservationIntervention">cdesc:ConservationIntervention</a>
    /// </summary>
    let ConservationIntervention = _prefixId.prefix "ConservationIntervention"
    /// <summary>
    ///   <para>rdfs:label : Copyrdfs:label : Copia</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la copia di un bene culturale, per esempio di una fotografia o di una stampa. Nel caso della fotografia, in questo caso viene esplicitamente dichiarata la responsabilità del fotografo principale.rdfs:comment : This class represents the copy of a cultural property, e.g. a copy of a photography or a print.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa S 3: RO/COP; ICCD Normativa F: RO/CRF/CRFT = 'copia'</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/Copy">cdesc:Copy</a>
    /// </summary>
    let Copy = _prefixId.prefix "Copy"
    /// <summary>
    ///   <para>rdfs:label : Diritti d'autorerdfs:label : Copyright</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This class represents the copyright of an object, e.g. a cultural property.rdfs:comment : Questa classe rappresenta i diritti d'autore detenuti da un agente su un oggetto, per esempio un bene culturale.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa F 4.00 e OAC: TU/CPR^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/Copyright">cdesc:Copyright</a>
    /// </summary>
    let Copyright = _prefixId.prefix "Copyright"
    /// <summary>
    ///   <para>rdfs:comment : This class represents the estimate of a cultural property.rdfs:comment : Questa classe rappresenta una stima di un bene culturale.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: UB/STI^^xsd:string</para>
    ///   <para>rdfs:label : Cultural property estimaterdfs:label : Stima di bene culturale</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/CulturalPropertyEstimate">cdesc:CulturalPropertyEstimate</a>
    /// </summary>
    let CulturalPropertyEstimate = _prefixId.prefix "CulturalPropertyEstimate"
    /// <summary>
    ///   <para>rdfs:label : Stadio del bene culturalerdfs:label : Cultural property stage</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa classe rappresenta lo stadio del bene catalogato in rapporto con l'oggetto che ne costituisce una fase preparatoria o che ne rappresenta la fase finale.rdfs:comment : This class represents the stage of the catalogued cultural property related to the object which constitutes its preparatory or final stage.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normative RA, SMO, PST, S, OAC, OA, MI, D, NU, F: RO/ROF/ROFF</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/CulturalPropertyStage">cdesc:CulturalPropertyStage</a>
    /// </summary>
    let CulturalPropertyStage = _prefixId.prefix "CulturalPropertyStage"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa classe rappresenta l'ambito culturale a cui può essere riferito un bene culturale. Per l'ambito culturale si usano definizioni quali: ambito, cultura, periodo, produzione, scuola, manifattura, ecc.; a questi termini segue la qualificazione geografica o il nome dell'ambito, della cultura, del periodo, della produzione, della scuola, della manifattura, ecc. Nel caso della normativa VeAC, questa classe rappresenta l'ambito sartoriale/di produzione, ovvero il contesto sartoriale (oppure la manifattura, la maestranza, ecc.) a cui può essere ricondotta la realizzazione del bene catalogato.rdfs:comment : This class represents the cultural scope related to a cultural property (e.g.: neoclassical, Milanese manifacturing, etc.)</para>
    ///   <para>rdfs:label : Cultural Scoperdfs:label : Ambito culturale</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: AU/ATB^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/CulturalScope">cdesc:CulturalScope</a>
    /// </summary>
    let CulturalScope = _prefixId.prefix "CulturalScope"
    /// <summary>
    ///   <para>rdfs:comment : This class represents the attribution of a cultural scope, to which the cultural property is related (e.g.: neoclassical, Milanese manifacturing, etc.)rdfs:comment : Questa classe rappresenta l'attribuzione di un ambito culturale a cui può essere riferito il bene culturale. Per l'ambito culturale si usano definizioni quali: ambito, cultura, periodo, produzione, scuola, manifattura, ecc.; a questi termini segue la qualificazione geografica o il nome dell'ambito, della cultura, del periodo, della produzione, della scuola, della manifattura, ecc.</para>
    ///   <para>rdfs:label : Attribuzione di Ambito Culturalerdfs:label : Cultural Scope Attribution</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : AU/ATB^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/CulturalScopeAttribution">cdesc:CulturalScopeAttribution</a>
    /// </summary>
    let CulturalScopeAttribution = _prefixId.prefix "CulturalScopeAttribution"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This class represents the current inventory of a cultural property, e.g. patrimonial informations.rdfs:comment : Questa classe rappresenta un inventario patrimoniale, che registra le informazioni amministrative relative alla situazione patrimoniale del bene.</para>
    ///   <para>rdfs:label : Current Inventoryrdfs:label : Inventario Patrimoniale</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: UB/INP</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/CurrentInventory">cdesc:CurrentInventory</a>
    /// </summary>
    let CurrentInventory = _prefixId.prefix "CurrentInventory"
    let CurrentUse = _prefixId.prefix "CurrentUse"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la cronologia di un'entità, cioè i dati cronologici che riguardano la storia dell'entità (es.: un bene culturale o un'opera collegata a un bene culturale). In relazione alle diverse situazioni, indicheranno un periodo esteso nel tempo oppure una singola data. Per ciascun bene viene fornita la cronologia della sua realizzazione, o, nel caso di immobili che presentano diverse fasi edilizie o diversi momenti di vita, un arco cronologico di riferimento; possono essere fornite anche altre notizie cronologiche relative ad altri eventi che hanno riguardato il bene (demolizione, progettazione, rimaneggiamenti, etc.)rdfs:comment : This class represents the dating of an entity, that is information about the chronology of the entity (e.g.: a cultural property), referring to a particular event (e.g.: the creation of the cultural property, its distruction, etc.)</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DT - ICCD Normative F, RA, SMO, PST, S, OAC, OA, MI, D, NU: RO/ROF/ROFD^^xsd:string</para>
    ///   <para>rdfs:label : Cronologiardfs:label : Dating</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/Dating">cdesc:Dating</a>
    /// </summary>
    let Dating = _prefixId.prefix "Dating"
    let DecentReliability = _prefixId.prefix "DecentReliability"

    let DeliveryConfirmationCertification = _prefixId.prefix "DeliveryConfirmationCertification"

    /// <summary>
    ///   <para>rdfs:label : Derivated workrdfs:label : Opera derivata</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa S 3: RO/COP - Normativa F: RO/CRF - Normative RA, SMO, PST, OAC, OA, MI, D, NU: RO/REI - Normative CA, MA: RO/RIU^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents a derivated work of a cultural property (copy, reuse, facsimile, forgery), created by the same author or by another author.rdfs:comment : Questa classe rappresenta una derivazione del bene catalogato (reimpiego, copia, contraffazione, replica, controtipo) prodotta dallo stesso o da altro autore.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/DerivatedWork">cdesc:DerivatedWork</a>
    /// </summary>
    let DerivatedWork = _prefixId.prefix "DerivatedWork"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa F: RO/CRF/CRFT - Normativa S: RO/ADL/ADLL - Normative RA, SMO, PST, S, OA, MI, D, NU: RO/REI/REIT - Normative CA, MA: RO/RIU/RIUT</para>
    ///   <para>rdfs:label : Tipo di opera derivatardfs:label : Derivated work type</para>
    ///   <para>rdfs:comment : Questa classe rappresenta il tipo di opera derivata da un bene culturale.rdfs:comment : This class represents the type of derivated work of a cultural property.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/DerivatedWorkType">cdesc:DerivatedWorkType</a>
    /// </summary>
    let DerivatedWorkType = _prefixId.prefix "DerivatedWorkType"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: OG/OGM^^xsd:string</para>
    ///   <para>rdfs:label : Detection Methodrdfs:label : Metodo di individuazione</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This class represents the method of detection that allowed the detection of a cultural property and which is indicative of the type and consistency of some information in the catalogue record that describes it (e.g.: coring, archive data, oral sources).rdfs:comment : Questa classe rappresenta la modalità di individuazione che ha consentito l'individuazione di un bene culturale e che è indicativa della tipologia e della consistenza di alcune informazioni presenti nella scheda di catalogo che lo descrive (es.: carotaggio, dati di archivio, fonti orali).</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/DetectionMethod">cdesc:DetectionMethod</a>
    /// </summary>
    let DetectionMethod = _prefixId.prefix "DetectionMethod"
    let DifferentDating = _prefixId.prefix "DifferentDating"
    /// <summary>
    ///   <para>rdfs:label : Documentazionerdfs:label : Documentation</para>
    ///   <para>dc11:description : Un esempio d'uso di una delle sottoclassi della classe 'Documentazione' è il seguente:
    /// resource:AudioDocumentation/1200924650-audio-documentation-1
    ///         a   cd:AudioDocumentation ;
    ///         rdfs:label  "Documentazione audio 1 del bene culturale: 1200924650"@it ;
    ///         cd:documentationIdentifier "New_1401358982589" ;
    ///         cd:hasDocumentationType resource:DocumentationType/cassetta-dat ;
    ///         cd:hasFormat resource:Format/cassetta-dat ;
    ///         core:hasCategory cd:AttachedDocumentation .dc11:description : An example of usage of one of the subclasses of the class 'Documentation' is the following:
    /// resource:AudioDocumentation/1200924650-audio-documentation-1
    ///         a   cd:AudioDocumentation ;
    ///         rdfs:label  "Audio documentation 1 of cultural property: 1200924650"@en ;
    ///         cd:documentationIdentifier "New_1401358982589" ;
    ///         cd:hasDocumentationType resource:DocumentationType/cassetta-dat ;
    ///         cd:hasFormat resource:Format/cassetta-dat ;
    ///         core:hasCategory cd:AttachedDocumentation .</para>
    ///   <para>rdfs:comment : This class represents the documentation, with subclasses for each specific type of documentation (images, drawings, audio, video, etc.)rdfs:comment : Classe che rappresenta la documentazione, specializzata nelle sottoclassi che rappresentano tipi specifici di documentazione di corredo (immagini, disegni e rilievi, cartografia, documenti audio e video, fonti e documenti editi e inediti, referenze bibliografiche).</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DO</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/Documentation">cdesc:Documentation</a>
    /// </summary>
    let Documentation = _prefixId.prefix "Documentation"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : FTAX, DRAX, VDCX, REGX, FNTX, ADMX (solo v. 3.00 e 3.01)</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Documentation categoryrdfs:label : Genere della documentazione</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la categoria della documentazione. Nel contesto delle normative per la catalogazione ICCD, questa classe ha un vocabolario chiuso definito in due tipi: documentazione allegata e documentazione esistente.rdfs:comment : This class represents the category associated to a documentation (e.g. attached documentation, existing documentation).</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/DocumentationCategory">cdesc:DocumentationCategory</a>
    /// </summary>
    let DocumentationCategory = _prefixId.prefix "DocumentationCategory"
    /// <summary>
    ///   <para>rdfs:label : Tipo di documentazionerdfs:label : Documentation type</para>
    ///   <para>ctlog:iccdNormTag : FTAP, DRAT, FNTP (+VDCP, REGP), ADMP (v. 3.00 e 3.01)</para>
    ///   <para>rdfs:comment : Questa classe rappresenta il tipo di documentazione.rdfs:comment : This class represents the type of documentation.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/DocumentationType">cdesc:DocumentationType</a>
    /// </summary>
    let DocumentationType = _prefixId.prefix "DocumentationType"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normative VeAC e AT 3.01: DO/BSE/BSEN - Normativa S 3.00: RO/ADL/ADLE.</para>
    ///   <para>rdfs:comment : Questa classe rappresenta l'edizione di un'entità. Per esempio, l'edizione cartacea o digitale di un bene culturale o di un'opera collegata a un bene culturale (ad es. una pubblicazione contenente una stampa).rdfs:comment : This class represents the edition of an entity (e.g. the print edition of a cultural property).</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/arco/context-description/^^xsd:string</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : Edizionerdfs:label : Edition</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/Edition">cdesc:Edition</a>
    /// </summary>
    let Edition = _prefixId.prefix "Edition"
    /// <summary>
    ///   <para>rdfs:comment : This class represents the intervention considered eligible by a specific urban planning instrument related to a cultural property.rdfs:comment : Questa classe rappresenta il tipo di intervento ammesso da una normativa specifica, ovvero da un piano regolatore generale e particolareggiato o da un piano paesaggistico che interessa un bene culturale.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: TU/STU/STUN^^xsd:string</para>
    ///   <para>rdfs:label : Eligible interventionrdfs:label : Intervento ammesso</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/EligibleIntervention">cdesc:EligibleIntervention</a>
    /// </summary>
    let EligibleIntervention = _prefixId.prefix "EligibleIntervention"
    let EpigraphicUse = _prefixId.prefix "EpigraphicUse"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This class represents the concept of estimate.rdfs:comment : Questa classe rappresenta il concetto di stima di un'entità.</para>
    ///   <para>rdfs:label : Stimardfs:label : Estimate</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/Estimate">cdesc:Estimate</a>
    /// </summary>
    let Estimate = _prefixId.prefix "Estimate"
    let ExcellentReliability = _prefixId.prefix "ExcellentReliability"
    let ExistingDocumentation = _prefixId.prefix "ExistingDocumentation"
    /// <summary>
    ///   <para>rdfs:comment : Questa classe rappresenta i diritti d'autore scaduti, relativi quindi a un oggetto, per esempio un bene culturale, diventato di pubblico dominio.rdfs:comment : This class represents an expired copyright, related to an object, e.g. a cultural property.</para>
    ///   <para>rdfs:label : Diritti d'autore scadutirdfs:label : Expired Copyright</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa F 4.00 e OAC: TU/CPR (if CPRD = 'scaduti' or 'diritti scaduti' or 'in pubblico dominio')^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/ExpiredCopyright">cdesc:ExpiredCopyright</a>
    /// </summary>
    let ExpiredCopyright = _prefixId.prefix "ExpiredCopyright"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This class represents the export/import certification of a cultural property.rdfs:comment : Questa classe rappresenta una certificazione amministrativa per la circolazione e l'esportazione/importazione di un bene culturale.</para>
    ///   <para>rdfs:label : Export import certificationrdfs:label : Certificazione di importazione o esportazione</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: TU/ESP^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/ExportImportCertification">cdesc:ExportImportCertification</a>
    /// </summary>
    let ExportImportCertification = _prefixId.prefix "ExportImportCertification"
    /// <summary>
    ///   <para>rdfs:label : Export import certification typerdfs:label : Tipo di certificazione di esportazione o importazione</para>
    ///   <para>rdfs:comment : This class represents the type of export/import certification of a cultural property (e.g.: temporary movement certification, temporary export license, free movement certification, etc.).rdfs:comment : Questa classe rappresenta il tipo di certificazione amministrativa di circolazione ed esportazione/importazione di un bene culturale (es.: attestato di libera circolazione, licenza di esportazione definitiva, ecc).</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: TU/ESP/ESPT^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/ExportImportCertificationType">cdesc:ExportImportCertificationType</a>
    /// </summary>
    let ExportImportCertificationType = _prefixId.prefix "ExportImportCertificationType"
    /// <summary>
    ///   <para>rdfs:comment : This class represents a facsimile of a cultural property, and in particular of a photography, that has the same format and technique.rdfs:comment : Questa classe rappresenta un controtipo di un bene culturale, specificamente di una fotografia, cioè una duplicazione realizzata nello stesso formato e nella stessa tecnica.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa F: RO/CRF/CRFT = 'controtipo'</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : Facsimilerdfs:label : Controtipo</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/Facsimile">cdesc:Facsimile</a>
    /// </summary>
    let Facsimile = _prefixId.prefix "Facsimile"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa BDI 4.00: CA/CAO/CAOF^^xsd:string</para>
    ///   <para>rdfs:label : Fair market circumstancerdfs:label : Occasione legata a fiere e mercati</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This class represents a circumstance related to fairs, markets, festivals.rdfs:comment : Questa classe rappresenta un'occasione connessa a fiere, mercati, sagre.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/FairMarketCircumstance">cdesc:FairMarketCircumstance</a>
    /// </summary>
    let FairMarketCircumstance = _prefixId.prefix "FairMarketCircumstance"
    /// <summary>
    ///   <para>rdfs:label : Video documentationrdfs:label : Documentazione video-cinematografica</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la documentazione video-cinematografica relativa a un oggetto, per esempio a un bene culturalerdfs:comment : This class represents the film documentation of an object, e.g. a cultural property.</para>
    ///   <para>ctlog:iccdNormTag : VDC</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/FilmDocumentation">cdesc:FilmDocumentation</a>
    /// </summary>
    let FilmDocumentation = _prefixId.prefix "FilmDocumentation"
    /// <summary>
    ///   <para>rdfs:label : Opera finalerdfs:label : Final work</para>
    ///   <para>rdfs:comment : Questa classe rappresenta un'entità collegata a un bene culturale, che ne costituisce la fase finale.rdfs:comment : This class represents an entity related to a cultural property, as its final stage.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normative F, RA, SMO, PST, S, OAC, OA, MI, D, NU: se RO/ROF/ROFF rappresenta uno stadio del bene catalogato riconducibile a una fase preparatoria, per cui è possibile dedurre che l'opera collegata al bene è una sua fase finale.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/FinalWork">cdesc:FinalWork</a>
    /// </summary>
    let FinalWork = _prefixId.prefix "FinalWork"
    /// <summary>
    ///   <para>rdfs:comment : Questa classe rappresenta il contesto di ritrovamento (tipo di contesto, elementi associati) di un bene culturale, e in particolare di un reperto antropologico.rdfs:comment : This class represents the context (type of context, associated objects) in which a cultural property (in particular, an anthropological material) is found.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa AT 3.01: OG/OGC^^xsd:string</para>
    ///   <para>rdfs:label : Contesto di rinvenimentordfs:label : Finding context</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/FindingContext">cdesc:FindingContext</a>
    /// </summary>
    let FindingContext = _prefixId.prefix "FindingContext"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa AT 3.01: OG/OGC/OGCT^^xsd:string</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : Finding context typerdfs:label : Tipo di contesto di rinvenimento</para>
    ///   <para>rdfs:comment : This class represents the type of finding context of a cultural property, and in particular of an anthropological material (e.g.: individual burial, common burial, etc.)rdfs:comment : Questa classe rappresenta il tipo di contesto di rinvenimento di un bene culturale, e in particolare di un reperto antropologico (es.: sepoltura collettiva, sepoltura singola primaria, etc.)</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/FindingContextType">cdesc:FindingContextType</a>
    /// </summary>
    let FindingContextType = _prefixId.prefix "FindingContextType"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa F: RO/CRF/CRFT = 'contraffazione'</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Forgeryrdfs:label : Contraffazione</para>
    ///   <para>rdfs:comment : Questa classe rappresenta una contraffazione di un bene culturale, cioè una riproduzione di un bene culturale da parte di un autore che non dichiari l'autore dell'originale.rdfs:comment : This class represents a forgery of a cultural property, that is a copy of a cultural property for which the author doesn't declare the original author.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/Forgery">cdesc:Forgery</a>
    /// </summary>
    let Forgery = _prefixId.prefix "Forgery"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DO/FTA/FTAF, DO/DRA/DRAF, DO/FNT/FNTR (+ DO/VDC/VDCP, DO/REG/REGP)^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the documentation format (e.g. jpeg, pdf, MP4)rdfs:comment : Questa classe rappresenta il formato della documentazione (es.: jpeg, A0, pdf, audiocassetta, MP4).</para>
    ///   <para>rdfs:label : Formatordfs:label : Format</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/Format">cdesc:Format</a>
    /// </summary>
    let Format = _prefixId.prefix "Format"
    let FreeMovementCertification = _prefixId.prefix "FreeMovementCertification"
    /// <summary>
    ///   <para>rdfs:label : Fruitionrdfs:label : Fruizione</para>
    ///   <para>ctlog:iccdNormTag : Normativa VeAC: AU/FRU^^xsd:string</para>
    ///   <para>rdfs:comment : Questa classe rappresenta un'occasione in cui il capo oggetto di catalogazione è stato indossato da una o più persone, sia perché ad esse destinato sia perché, ad esse pervenuto, hanno potuto riadattarlo a loro nuove esigenze.rdfs:comment : This class represents a circumstance in which a garment, catalogued as a cultural property, was worn by one or more people.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/Fruition">cdesc:Fruition</a>
    /// </summary>
    let Fruition = _prefixId.prefix "Fruition"
    /// <summary>
    ///   <para>rdfs:comment : Questa classe rappresenta uno dei livelli di classificazione di una tassonomia biologica, ovvero il genere.rdfs:comment : This class represents one level of a biological taxon, the genus.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa AT: OG/OGS/OGSG^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Genererdfs:label : Genus</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/Genus">cdesc:Genus</a>
    /// </summary>
    let Genus = _prefixId.prefix "Genus"
    let GoodReliability = _prefixId.prefix "GoodReliability"

    /// <summary>
    ///   <para>rdfs:comment : This class represents the graphic or cartographic documentation of an object, e.g. a cultural property.rdfs:comment : Questa classe rappresenta la documentazione grafica e cartografica relativa a un oggetto, per esempio a un bene culturale.</para>
    ///   <para>rdfs:label : Documentazione grafica e cartograficardfs:label : Graphic and cartographic documentation</para>
    ///   <para>ctlog:iccdNormTag : DRA</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/GraphicOrCartographicDocumentation">cdesc:GraphicOrCartographicDocumentation</a>
    /// </summary>
    let GraphicOrCartographicDocumentation = _prefixId.prefix "GraphicOrCartographicDocumentation"

    let HistoricalUse = _prefixId.prefix "HistoricalUse"
    let HistoricizedTitle = _prefixId.prefix "HistoricizedTitle"

    let ImportConfirmationCertification = _prefixId.prefix "ImportConfirmationCertification"

    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa BDI 4.00: CA/CAO/CAOI^^xsd:string</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This class represents an indeterminate circumstance, when the cultural property is not related to a determinate circumstance, but takes place in an extemporaneous and contingent way (e.g.: a musical performance, a narration, a game).rdfs:comment : Questa classe rappresenta un'occasione indeterminata, cioè quando il bene non è in rapporto con una precisa occasione o scadenza, ma si realizza in modo del tutto estemporaneo e contingente. Occasioni indeterminate possono essere, per esempio, un'esecuzione musicale, una narrazione, un
    /// gioco, etc.</para>
    ///   <para>rdfs:label : Indeterminate circumstancerdfs:label : Occasione indeterminata</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/IndeterminateCircumstance">cdesc:IndeterminateCircumstance</a>
    /// </summary>
    let IndeterminateCircumstance = _prefixId.prefix "IndeterminateCircumstance"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This class represents a particular type of survey on a cultural property, that is an inspection carried out to verify the condition of a cultural property.rdfs:comment : Questa classe rappresenta un tipo particolare di indagine su bene culturale, ovvero un'ispezione effettuata per constatare lo stato del bene.</para>
    ///   <para>rdfs:label : Inspectionrdfs:label : Ispezione</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: CM/ISP^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/Inspection">cdesc:Inspection</a>
    /// </summary>
    let Inspection = _prefixId.prefix "Inspection"
    let InstrumentalUse = _prefixId.prefix "InstrumentalUse"
    let InsufficientReliability = _prefixId.prefix "InsufficientReliability"
    /// <summary>
    ///   <para>rdfs:comment : This class represents a situation in which pieces of information related to an object (e.g.: a cultural property) are detected and recorded by an agent, based on a specific source or motivation (e.g.:ithe authorship attribution, commission, etc.)rdfs:comment : Questa classe rappresenta una situazione in cui viene individuata e registrata da un agente una certa informazione o un gruppo di informazioni relativamente a un oggetto, per esempio a un bene culturale o a una sua parte, supportata da una fonte o motivazione. Per esempio, l'attribuzione di autore, l'individuazione della committenza o delle entità responsabili di fasi successive alla creazione di un bene culturale sono tutte interpretazioni basate su fonti.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Interpretazionerdfs:label : Interpretation</para>
    ///   <para>dc11:description : An example of usage of one of the subclasses of the class 'Interpretation' is the following:
    /// resource:PreferredAuthorshipAttribution/1200865600-1 a           cd:PreferredAuthorshipAttribution ;
    ///         rdfs:label  "Preferred authorship attribution of cultural property: 1200865600"@en ;
    ///         cd:hasAttributedAuthor resource:Agent/cavaceppi-bartolomeo-1717-1799 ;
    ///         cd:hasSource resource:Source/documentation .dc11:description : Un esempio di utilizzo di una delle sottoclassi della classe "Interpretazione" è il seguente:
    /// resource:PreferredAuthorshipAttribution/1200865600-1 a           cd:PreferredAuthorshipAttribution ;
    ///         rdfs:label "Attribuzione di autore preferita, maggiormente accreditata o convincente del bene: 1200865600"@it ;
    ///         cd:hasAttributedAuthor resource:Agent/cavaceppi-bartolomeo-1717-1799 ;
    ///         cd:hasSource resource:Source/documentazione .</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/Interpretation">cdesc:Interpretation</a>
    /// </summary>
    let Interpretation = _prefixId.prefix "Interpretation"
    /// <summary>
    ///   <para>rdfs:comment : This class represents the criterion that motivated an interpretation (e.g. inscription, bibliography, documentation).rdfs:comment : Questa classe rappresenta il criterio o la motivazione che ha determinato una certa interpretazione (es.: bibliografia, documentazione, iscrizione).</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: AU/AUT/AUTM; AU/CMM/CMMF; AU/AAT/AATM; AU/ATB/ATBM; DT/DTM/DTMM; SG/SGT/SGTL - Normativa VeAC: AU/FRU/FRUF - Normativa MI 3.00: AU/DC/DDCF^^xsd:string</para>
    ///   <para>rdfs:label : Interpretation criterionrdfs:label : Criterio interpretativo</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/InterpretationCriterion">cdesc:InterpretationCriterion</a>
    /// </summary>
    let InterpretationCriterion = _prefixId.prefix "InterpretationCriterion"
    /// <summary>
    ///   <para>rdfs:comment : Questa classe rappresenta un intervento che ha interessato un bene culturale, a fini conservativi (per i quali si crea una sottoclasse di "Intervento") oppure di altro tipo: restauri (termine obsoleto che attualmente corrisponde a "intervento a fine conservativo"), rilavorazioni, ripristini, trasformazioni per recuperare aspetto e funzionalità rispondenti ai mutati gusti, ecc. In generale, per interventi si intendono attività che riguardano il bene, effettuate per la sua realizzazione/modifica e conservazione materiale.rdfs:comment : This class represents an intervention on a cultural property, that is an activity carried out for its conservation or for other purposes: conservation interventions, reprocessing, restoring, etc.</para>
    ///   <para>rdfs:label : Interventionrdfs:label : Intervento</para>
    ///   <para>dc11:description : An example of usage of the class 'Intervention' is the following:
    /// resource:Intervention/0800640527-10-intervention-1
    ///         a           cd:Intervention ;
    ///         rdfs:label  "Intervention 1 on cultural property 0800640527-10"@en ;
    ///         cd:hasActivityOperator resource:Agent/tonelli-elvira ;
    ///         cd:hasActivityResponsible resource:Agent/soprintendenza-per-i-beni-ambientali-ed-architettonici-di-bologna-modena-e-reggio-emilia ;
    ///         cd:hasInterventionType resource:InterventionType/restauro ;
    ///         tiapit:atTime resource:TimeInterval/1994 .dc11:description : Un esempio di utilizzo della classe "Intervento" è il seguente:
    /// resource:Intervention/0800640527-10-intervention-1
    ///         a           cd:Intervention ;
    ///         rdfs:label  "Intervento 1 sul bene culturale 0800640527-10"@it ;
    ///         cd:hasActivityOperator resource:Agent/tonelli-elvira ;
    ///         cd:hasActivityResponsible resource:Agent/soprintendenza-per-i-beni-ambientali-ed-architettonici-di-bologna-modena-e-reggio-emilia ;
    ///         cd:hasInterventionType resource:InterventionType/restauro ;
    ///         tiapit:atTime resource:TimeInterval/1994 .</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: CO/RST - normative di versioni precedenti: RS/RST; Normativa VeAC: CO/RIA; Normativa CA: RO/RIS</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/Intervention">cdesc:Intervention</a>
    /// </summary>
    let Intervention = _prefixId.prefix "Intervention"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa classe rappresenta il tipo di intervento (a fini conservativi o di altro tipo) che ha interessato un bene culturale.rdfs:comment : This class represents the type of intervention on a cultural property.</para>
    ///   <para>rdfs:label : Tipo di interventordfs:label : Intervention type</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: valori di CO/RST/RSTI - Normativa VeAC: CO/RIA (riadattamento/modifica) - Normativa CA: RO/RIS (intervento successivo)</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/InterventionType">cdesc:InterventionType</a>
    /// </summary>
    let InterventionType = _prefixId.prefix "InterventionType"
    /// <summary>
    ///   <para>rdfs:label : Inventoryrdfs:label : Inventario</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This class represents an inventory about a cultural property or about an entity or an activity related to the cultural property.rdfs:comment : Questa classe rappresenta un inventario, di vario tipo, relativo a un bene culturale o relativo a una delle entità o attività collegate al bene culturale (per esempio un inventario di scavo archeologico).</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: UB/INV; ICCD Normativa RA 3.00 RE/DSC/DSCI</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/Inventory">cdesc:Inventory</a>
    /// </summary>
    let Inventory = _prefixId.prefix "Inventory"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normative NU, RA, BNB, MA, CA: RS/ALB^^xsd:string</para>
    ///   <para>rdfs:comment : Questa classe rappresenta un tipo particolare di indagine su bene culturale, ovvero un'analisi di laboratorio.rdfs:comment : This class represents a particular type of survey on a cultural property, that is a laboratory test.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Analisi di laboratoriordfs:label : Laboratory test</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/LaboratoryTest">cdesc:LaboratoryTest</a>
    /// </summary>
    let LaboratoryTest = _prefixId.prefix "LaboratoryTest"
    /// <summary>
    ///   <para>rdfs:comment : This class represents the type of laboratory test (es.: chemical analysis)rdfs:comment : Questa classe rappresenta il tipo di analisi di laboratorio (es.: analisi metallurgica, analisi chimica, etc.)</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normative NU, RA, BNB, MA, CA: RS/ALB/ALBT^^xsd:string</para>
    ///   <para>rdfs:label : Laboratory test typerdfs:label : Tipo di analisi di laboratorio</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/LaboratoryTestType">cdesc:LaboratoryTestType</a>
    /// </summary>
    let LaboratoryTestType = _prefixId.prefix "LaboratoryTestType"
    /// <summary>
    ///   <para>rdfs:label : Situazione giuridicardfs:label : Legal situation</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>dc11:description : Un esempio d'uso della classe "Condizione giuridica" è il seguente:
    /// resource:LegalSituation/1400054721-legal-situation-proprieta-stato
    ///         a  cd:LegalSituation ;
    ///         rdfs:label  "Condizione giuridica del bene culturale 1400054721: proprietà Stato"@it ;
    ///         cd:hasOwner resource:Agent/ministero-beni-culturali .dc11:description : An example of usage of the class "Legal situation" is the following:
    /// resource:LegalSituation/1400054721-legal-situation-proprieta-stato
    ///         a  cd:LegalSituation ;
    ///         rdfs:label  "Legal situation of cultural property 1400054721: State property"@en ;
    ///         cd:hasOwner resource:Agent/ministero-beni-culturali .</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: TU/CDG/CDGG^^xsd:string</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la condizione giuridica di un bene culturale, con riferimenti al proprietario, detentore o possessore.rdfs:comment : This class represents the legal situation of a cultural property, related to the owner.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/LegalSituation">cdesc:LegalSituation</a>
    /// </summary>
    let LegalSituation = _prefixId.prefix "LegalSituation"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa BDI 4.00: CA/CAO/CAOV^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents a circumstance related to life cycles (ceremonies, custom, celebration)rdfs:comment : Questa classe rappresenta un'occasione legata ai cicli della vita (cerimonie, riti, feste).</para>
    ///   <para>rdfs:label : Occasione legata al ciclo della vitardfs:label : Life cycle circumstance</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/LifeCycleCircumstance">cdesc:LifeCycleCircumstance</a>
    /// </summary>
    let LifeCycleCircumstance = _prefixId.prefix "LifeCycleCircumstance"
    let LineAnomaly = _prefixId.prefix "LineAnomaly"
    let MainTitle = _prefixId.prefix "MainTitle"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>dc11:description : An example of usage of one of the subclasses of the class 'Membership' is the following: resource:CollectionMembership/0300633618-collection-membership-1
    ///         a    cd:CollectionMembership ;
    ///         rdfs:label  "Collection membership 1 of cultural property: 0300633618"@en ;
    ///         cd:hasCollection resource:CollectionOfCulturalEntities/collezione-mingozzi ;
    ///         cd:hasMemberOfCollection resource:ScientificOrTechnologicalHeritage/0300633618 ;
    ///         tiapit:atTime resource:TimeInterval/1967 .dc11:description : Un esempio d'uso di una delle sottoclassi della classe 'Appartenenza' è il seguente: resource:CollectionMembership/0300633618-collection-membership-1
    ///         a    cd:CollectionMembership ;
    ///         rdfs:label  "Appartenenza a collezione 1 del bene culturale: 0300633618"@it ;
    ///         cd:hasCollection resource:CollectionOfCulturalEntities/collezione-mingozzi ;
    ///         cd:hasMemberOfCollection resource:ScientificOrTechnologicalHeritage/0300633618 ;
    ///         tiapit:atTime resource:TimeInterval/1967 .</para>
    ///   <para>rdfs:comment : Questa classe rappresenta il concetto di appartenenza.rdfs:comment : This class represents the concept of membership.</para>
    ///   <para>rdfs:label : Membershiprdfs:label : Appartenenza</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/Membership">cdesc:Membership</a>
    /// </summary>
    let Membership = _prefixId.prefix "Membership"
    /// <summary>
    ///   <para>rdfs:label : Multimedia documentationrdfs:label : Altra documentazione multimediale</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la documentazione multimediale in formato digitale relativa al un oggetto, per esempio un bene culturale. Nel caso delle Normative per la catalogazione dell'ICCD questa classe riguarda la documentazione multimediale realizzata in formati non compresi dalle norme ICCD, allegata alla scheda di catalogo o esistente e depositata presso l'Ente schedatore o in altre raccolte.rdfs:comment : This class represents the multimedia documentation of an object, e.g. a cultural property.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ADM (solo versioni 3.00 e 3.01)</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/MultimediaDocumentation">cdesc:MultimediaDocumentation</a>
    /// </summary>
    let MultimediaDocumentation = _prefixId.prefix "MultimediaDocumentation"
    let NaturalOrigin = _prefixId.prefix "NaturalOrigin"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa S 3: RO/ADL/ADLS</para>
    ///   <para>rdfs:comment : Questa classe rappresenta una stampa che non è più parte integrante della pubblicazione, ma che lo è stata in passato.rdfs:comment : This class represents a print that is no longer was a part of a publication.</para>
    ///   <para>rdfs:label : Stampa non più in volumerdfs:label : Print no longer in publication</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/NoLongerInPublication">cdesc:NoLongerInPublication</a>
    /// </summary>
    let NoLongerInPublication = _prefixId.prefix "NoLongerInPublication"
    /// <summary>
    ///   <para>rdfs:label : Numismatic seriesrdfs:label : Serie numismatica</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa NU: OG/OGT/OGTR^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the series which a particular coin is part of.rdfs:comment : Questa classe rappresenta la serie della quale una moneta fa parte (es.: Greca, Romana Repubblicana, Barbarica).</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/NumismaticSeries">cdesc:NumismaticSeries</a>
    /// </summary>
    let NumismaticSeries = _prefixId.prefix "NumismaticSeries"
    /// <summary>
    ///   <para>rdfs:label : Indagine di rilevamentordfs:label : Observation survey</para>
    ///   <para>rdfs:comment : Questa classe rappresenta un tipo particolare di indagine, ovvero il rilevamento (l'occasione o l'indagine in occasione della quale è stato rilevato, individuato, osservato il bene) di un bene musicale di interesse etno-organologico o di un bene demoetno-antropologico.rdfs:comment : This class represents a particular type of survey on a cultural property, that is an observation survey: the observation of musical heritage or demoethnoanthropological heritage.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa SM e BDM 4.00: DR^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/ObservationSurvey">cdesc:ObservationSurvey</a>
    /// </summary>
    let ObservationSurvey = _prefixId.prefix "ObservationSurvey"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa BDI 4.00: LA/PRM^^xsd:string</para>
    ///   <para>rdfs:label : Tipo di indagine di rilevamentordfs:label : Observation survey type</para>
    ///   <para>rdfs:comment : Questa classe rappresenta il tipo di indagine di rilevamento (rilevamento nel contesto/ rilevamento decontestualizzato).rdfs:comment : This class represents the type of observation survey (in the context / out of the context).</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/ObservationSurveyType">cdesc:ObservationSurveyType</a>
    /// </summary>
    let ObservationSurveyType = _prefixId.prefix "ObservationSurveyType"
    let ObsoleteDating = _prefixId.prefix "ObsoleteDating"
    let OriginalTitle = _prefixId.prefix "OriginalTitle"
    let OrnamentalUse = _prefixId.prefix "OrnamentalUse"
    let OtherMethodOfDating = _prefixId.prefix "OtherMethodOfDating"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : Indagine su paleopatologiardfs:label : Paleopathology survey</para>
    ///   <para>rdfs:comment : Questa classe rappresenta un'indagine, intesa come attività, in cui viene elaborata una diagnosi di una paleopatologia di un reperto antropologico.rdfs:comment : This class represents a particular type of survey on a cultural property, that is a survey in which is possible to make a diagnosis of a paleopathology of an anthropological material.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa AT: PT^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/PaleopathologySurvey">cdesc:PaleopathologySurvey</a>
    /// </summary>
    let PaleopathologySurvey = _prefixId.prefix "PaleopathologySurvey"
    let ParallelTitle = _prefixId.prefix "ParallelTitle"
    let PermanentExportLicense = _prefixId.prefix "PermanentExportLicense"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa classe rappresenta un tipo particolare di indagine su bene culturale, ovvero una fotointerpretazione e fotorestituzione, intesa come indagine territoriale.rdfs:comment : This class represents a particular type of survey on a cultural property, that is photo interpretation and rendering.</para>
    ///   <para>rdfs:label : Fotointerpretazione e fotorestituzionerdfs:label : Photo interpretation and rendering</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RE/FOI^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/PhotoInterpretationRendering">cdesc:PhotoInterpretationRendering</a>
    /// </summary>
    let PhotoInterpretationRendering = _prefixId.prefix "PhotoInterpretationRendering"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la documentazione fotografica relativa a un oggetto, per esempio a un bene culturale.rdfs:comment : This class represents the photographic documentation of an object, e.g. a cultural property.</para>
    ///   <para>rdfs:label : Photographic documentationrdfs:label : Documentazione fotografica</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DO/FTA</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/PhotographicDocumentation">cdesc:PhotographicDocumentation</a>
    /// </summary>
    let PhotographicDocumentation = _prefixId.prefix "PhotographicDocumentation"
    /// <summary>
    ///   <para>rdfs:comment : This class represents a photographic series, that is a set of photographs created or published as a unit, from a library sciences point of view.rdfs:comment : Questa classe rappresenta una serie editoriale fotografica, ovvero un insieme di immagini ideate o pubblicate come un'unica entità, esplicitamente legate tra di loro da un titolo o da una numerazione progressiva o da altri elementi che ne individuino inequivocabilmente l'unitarietà in senso biblioteconomico.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: PD/SFI^^xsd:string</para>
    ///   <para>rdfs:label : Serie fotograficardfs:label : Photographic series</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/PhotographicSeries">cdesc:PhotographicSeries</a>
    /// </summary>
    let PhotographicSeries = _prefixId.prefix "PhotographicSeries"
    /// <summary>
    ///   <para>rdfs:label : Appartenenza a serie fotograficardfs:label : Photographic series membership</para>
    ///   <para>rdfs:comment : This class represents the membership of photographic heritage in a photographic series, as a unit.rdfs:comment : Questa classe rappresenta l'appartenenza di un bene fotografico a una serie editoriale, esplicitamente indicata da un titolo o da una numerazione progressiva o da altri elementi che ne individuino inequivocabilmente l'appartenenza.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa F: PD/SFI; PD/SSI^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/PhotographicSeriesMembership">cdesc:PhotographicSeriesMembership</a>
    /// </summary>
    let PhotographicSeriesMembership = _prefixId.prefix "PhotographicSeriesMembership"
    /// <summary>
    ///   <para>rdfs:comment : This class represents a photographic subseries, that is a component of a photographic series.rdfs:comment : Questa classe rappresenta una sottoserie di una serie editoriale fotografica, ovvero una partizione interna alla serie.</para>
    ///   <para>rdfs:label : Sottoserie fotograficardfs:label : Photographic subseries</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa F: PD/SSI^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/PhotographicSubseries">cdesc:PhotographicSubseries</a>
    /// </summary>
    let PhotographicSubseries = _prefixId.prefix "PhotographicSubseries"
    let PointAnomaly = _prefixId.prefix "PointAnomaly"
    let PolygonAnomaly = _prefixId.prefix "PolygonAnomaly"

    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : AU/AUT^^xsd:string</para>
    ///   <para>rdfs:comment : Questa classe rappresenta l'attribuzione di autore maggiormente accreditata o convincente.rdfs:comment : This class represents the preferred authorship attribution, most accredited or convincing.</para>
    ///   <para>rdfs:label : Preferred Authorship Attributionrdfs:label : Attribuzione Primaria di Autore</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/PreferredAuthorshipAttribution">cdesc:PreferredAuthorshipAttribution</a>
    /// </summary>
    let PreferredAuthorshipAttribution = _prefixId.prefix "PreferredAuthorshipAttribution"

    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normative F, RA, SMO, PST, S, OAC, OA, MI, D, NU: RO/ROF^^xsd:string</para>
    ///   <para>rdfs:comment : Questa classe rappresenta un'entità collegata a un bene culturale, che ne costituisce una fase preparatoria o una fase finale.rdfs:comment : This class represents an entity related to a cultural property, that is its preparatory or final stage.</para>
    ///   <para>dc11:description : An example of usage of the class 'Preparatory or final work' is the following::
    /// resource:PreparatoryOrFinalWork/0500212038-disegno
    ///         a           cd:PreparatoryOrFinalWork ;
    ///         rdfs:label  "Preparatory or final work 1 of cultural property 0500212038: disegno"@en ;
    ///         cd:hasAuthor resource:Agent/tiziano-vecellio ;
    ///         cd:hasDating resoruce:Dating/0500212038-disegno .dc11:description : Un esempio di utilizzo della classe "Opera preparatoria o finale" è il seguente:
    /// resource:PreparatoryOrFinalWork/0500212038-disegno
    ///         a           cd:PreparatoryOrFinalWork ;
    ///         rdfs:label  "Opera originale o finale 1 del bene culturale 0500212038: disegno"@it ;
    ///         cd:hasAuthor resource:Agent/tiziano-vecellio ;
    ///         cd:hasDating resoruce:Dating/0500212038-disegno .</para>
    ///   <para>rdfs:label : Opera preparatoria o finalerdfs:label : Preparatory or final work</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/PreparatoryOrFinalWork">cdesc:PreparatoryOrFinalWork</a>
    /// </summary>
    let PreparatoryOrFinalWork = _prefixId.prefix "PreparatoryOrFinalWork"
    /// <summary>
    ///   <para>rdfs:label : Preparatory workrdfs:label : Opera preparatoria</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normative F, RA, SMO, PST, S, OAC, OA, MI, D, NU: se RO/ROF/ROFF rappresenta uno stadio del bene catalogato riconducibile a una fase finale, per cui è possibile dedurre che l'opera collegata al bene è una sua fase preparatoria.</para>
    ///   <para>rdfs:comment : This class represents an entity related to a cultural property, as its preparatory stage.rdfs:comment : Questa classe rappresenta un'entità collegata a un bene culturale, che ne costituisce una fase preparatoria.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/PreparatoryWork">cdesc:PreparatoryWork</a>
    /// </summary>
    let PreparatoryWork = _prefixId.prefix "PreparatoryWork"
    let PreviousUse = _prefixId.prefix "PreviousUse"
    /// <summary>
    ///   <para>rdfs:label : Print in publicationrdfs:label : Stampa in pubblicazione</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa S 3: RO/ADL</para>
    ///   <para>rdfs:comment : This class represents a publication of which a print is, or was, part.rdfs:comment : Questa classe rappresenta la pubblicazione di cui una stampa è, o è stata, parte integrante.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/PrintInPublication">cdesc:PrintInPublication</a>
    /// </summary>
    let PrintInPublication = _prefixId.prefix "PrintInPublication"
    /// <summary>
    ///   <para>rdfs:comment : Questa classe rappresenta un'occasione connessa ai cicli produttivi (bachicoltura, cerealicoltura, etc.)rdfs:comment : This class represents a circumstance related to production cycles (sericulture, cereal crop, etc.)</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa BDI 4.00: CA/CAO/CAOP^^xsd:string</para>
    ///   <para>rdfs:label : Production cycle circumstancerdfs:label : Occasione legata al ciclo produttivo</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/ProductionCycleCircumstance">cdesc:ProductionCycleCircumstance</a>
    /// </summary>
    let ProductionCycleCircumstance = _prefixId.prefix "ProductionCycleCircumstance"
    /// <summary>
    ///   <para>rdfs:comment : Questa classe rappresenta il mestiere o la professione dell'utente del bene.rdfs:comment : This class represents the role of a cultural entity's user.</para>
    ///   <para>rdfs:label : Professionerdfs:label : Profession</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa BDM 2: UT/UTN/UTNM</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/Profession">cdesc:Profession</a>
    /// </summary>
    let Profession = _prefixId.prefix "Profession"
    let ProperTitle = _prefixId.prefix "ProperTitle"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Protective measurerdfs:label : Provvedimento di tutela</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: TU/NVC^^xsd:string</para>
    ///   <para>rdfs:comment : Questa classe rappresenta un provvedimento di tutela nazionale o internazionale, che ha interessato un bene culturale.rdfs:comment : This class represents the protective measure, national or international, related to a cultural property.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/ProtectiveMeasure">cdesc:ProtectiveMeasure</a>
    /// </summary>
    let ProtectiveMeasure = _prefixId.prefix "ProtectiveMeasure"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: UB/INP/INPU^^xsd:string</para>
    ///   <para>rdfs:label : RCS reasonrdfs:label : causale RCS</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta il codice della causale RCS (Ragioneria Centrale dello Stato) di aumento o diminuzione del valore del bene.rdfs:comment : This property represents the code of the RCS causal (Central State Accounting Office) of increasing or decreasing property value.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/RCSReason">cdesc:RCSReason</a>
    /// </summary>
    let RCSReason = _prefixId.prefix "RCSReason"
    /// <summary>
    ///   <para>rdfs:label : Reference cataloguerdfs:label : Repertorio</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa S 3: RO/COP/COPR</para>
    ///   <para>rdfs:comment : This class represents the reference catalogue that cites the copy of a print.rdfs:comment : Questa classe rappresenta il repertorio che cita la copia di una stampa.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/ReferenceCatalogue">cdesc:ReferenceCatalogue</a>
    /// </summary>
    let ReferenceCatalogue = _prefixId.prefix "ReferenceCatalogue"
    /// <summary>
    ///   <para>dc11:description : An example of usage of the class 'Related work situation' is the following:
    /// resource:RelatedWorkSituation/0300199368-preparatory-final-work-1
    ///         a  cd:RelatedWorkSituation ;
    ///         rdfs:label  "Relation 1 between the cultural property 0300199368 and preparatory or final work"@en  ;
    ///       cd:hasCulturalPropertyStage resource:CulturalPropertyStage/bozzetto ;
    ///         cd:hasRelatedWork resource:FinalWork/0300199368-dipinto .dc11:description : Un esempio d'uso della classe 'Rapporto con opera collegata' è il seguente:
    /// resource:RelatedWorkSituation/0300199368-preparatory-final-work-1
    ///         a  cd:RelatedWorkSituation ;
    ///         rdfs:label  "Relation 1 between the cultural property 0300199368 and preparatory or final work"@en , "Rapporto 1 tra il bene culturale 0300199368 e opera originale o finale"@it ;
    ///       cd:hasCulturalPropertyStage resource:CulturalPropertyStage/bozzetto ;
    ///         cd:hasRelatedWork resource:FinalWork/0300199368-dipinto .</para>
    ///   <para>rdfs:comment : This class represents a situation in which a cultural property is related to another work, that could even be another cultural property. The cultural property stage is defined referring to this relationship with a related work, that can represent a preparatory, a final phase or a derivation of the cultural property. When the relationship is between two cultural properties, when possible, the nature of the relationship is specified (e.g.: finding location)rdfs:comment : Questa classe rappresenta la relazione, il rapporto, tra il bene culturale in esame e un'altra opera, che può anche essere un bene culturale. In riferimento a questo rapporto, si definisce lo stadio di realizzazione del bene culturale in rapporto con l'oggetto che ne costituisce una fase preparatoria o che ne rappresenta la fase finale o che ne rappresenta una derivazione. Nel caso di una relazione tra un bene culturale e un altro bene culturale, in riferimento a questo rapporto si definisce, se possibile, il tipo di relazione tra i due beni (es.: luogo di realizzazione, luogo di ritrovamento, etc.).</para>
    ///   <para>rdfs:label : Rapporto con opera collegatardfs:label : Related work situation</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/RelatedWorkSituation">cdesc:RelatedWorkSituation</a>
    /// </summary>
    let RelatedWorkSituation = _prefixId.prefix "RelatedWorkSituation"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RE/FOI/FOIO^^xsd:string</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This class represents the reliability level of detected information relative to photo interpretation rendering.rdfs:comment : Questa classe rappresenta il livello di affidabilità delle informazioni rilevate nell'indagine di fotointerpretazione/fotorestituzione.</para>
    ///   <para>rdfs:label : Reliabilityrdfs:label : Affidabilità</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/Reliability">cdesc:Reliability</a>
    /// </summary>
    let Reliability = _prefixId.prefix "Reliability"
    let ReligiousCircumstance = _prefixId.prefix "ReligiousCircumstance"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : Reproductionrdfs:label : Riproduzione</para>
    ///   <para>rdfs:comment : This class represents the reproduction of an image, that is, or was, part of a publication.rdfs:comment : Questa classe rappresenta la riproduzione dell'immagine contenuta nella pubblicazione di cui la stampa è, o è stata, parte integrante.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa S 3: RO/ADL</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/Reproduction">cdesc:Reproduction</a>
    /// </summary>
    let Reproduction = _prefixId.prefix "Reproduction"
    /// <summary>
    ///   <para>rdfs:label : Reproduction positionrdfs:label : Posizione della riproduzione</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa S 3: RO/ADL/ADLP</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la posizione fisica della riproduzione della stampa all'interno della pubblicazione, che rappresenta quindi una derivazione della stampa stessa.rdfs:comment : This class represents the phisical position of a printed reproduction in a publication.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/ReproductionPosition">cdesc:ReproductionPosition</a>
    /// </summary>
    let ReproductionPosition = _prefixId.prefix "ReproductionPosition"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : Ricercardfs:label : Research</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la ricerca nell'ambito della quale è stata redatta la scheda, intendendo con il termine "ricerca" vari e differenziati livelli, fra cui quello della campagna di catalogazione. La ricerca si può collegare al rilevamento di un bene musicale di interesse etno-organologico.rdfs:comment : This class represents the research in which the catalogue record describing a cultural property was recorded (e.g.: a cataloguing campaign). The research can be related to the observation survey on musical heritage.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa SM e BDM 4.00: DR/DRT^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/Research">cdesc:Research</a>
    /// </summary>
    let Research = _prefixId.prefix "Research"
    /// <summary>
    ///   <para>rdfs:comment : Questa classe rappresenta l'individuazione di una responsabilità attribuibile a un agente relativamente ai processi di produzione e di divulgazione che caratterizzano specificamente i beni fotografici, quindi alle diverse personalità responsabili, a vario titolo, del ciclo produttivo del bene in esame, oltre che della sua circolazione, divulgazione, commercializzazione e promozione (committenti, stampatori, ritoccatori, coloritori, editori, distributori, sponsor, curatori e responsabili di edizioni e di serie, dedicanti e dedicatari, responsabili di collezioni e di collazioni, ecc.).rdfs:comment : This class represents the attribution of a responsibility to an agent, relating to the activities of production and dissemination of photographic heritage (e.g.: committent, editor, printer, dedicatee, etc.)</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : Responsibilityrdfs:label : Responsabilità</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normative F e FF: PD/PDF^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/Responsibility">cdesc:Responsibility</a>
    /// </summary>
    let Responsibility = _prefixId.prefix "Responsibility"
    /// <summary>
    ///   <para>rdfs:label : Responsibility typerdfs:label : Tipo di responsabilità</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This class represents the type of responsibility related to the production and dissemination of photographic heritage (e.g.: printer, editor)rdfs:comment : Questa classe rappresenta il tipo di responsabilità individuata relativamente ai processi di produzione e di divulgazione che caratterizzano specificamente i beni fotografici (es.: stampatori, ritoccatori, coloritori, ecc.).</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normative F e FF: PD/PDF/PDFR^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/ResponsibilityType">cdesc:ResponsibilityType</a>
    /// </summary>
    let ResponsibilityType = _prefixId.prefix "ResponsibilityType"
    /// <summary>
    ///   <para>owl:versionInfo : provvisoriaowl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This class represents the reuse of a cultural property or of one of its parts.rdfs:comment : This class represents cultural entity's reuse.rdfs:comment : Questa classe rappresenta il riuso subito dal bene catalogato o da una sua parte.</para>
    ///   <para>rdfs:label : Riusordfs:label : Reuse</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normative RA, SMO, PST,  OAC, OA, MI, NU: RO/REI - ICCD Normative CA, MA: RO/RIU - ICCD Normativa F: ROP/CRF/CRFT = 'reimpiego'^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/Reuse">cdesc:Reuse</a>
    /// </summary>
    let Reuse = _prefixId.prefix "Reuse"
    /// <summary>
    ///   <para>rdfs:comment : This class represents the patrimonial category of a cultural property, referring to the SEC classification 1995.rdfs:comment : Questa classe rappresenta la categoria patrimoniale del bene, con riferimento alla classificazione del Sistema Europeo dei Conti 1995</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : SEC Categoryrdfs:label : Categoria SEC</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: UB/INP/INPZ^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/SECCategory">cdesc:SECCategory</a>
    /// </summary>
    let SECCategory = _prefixId.prefix "SECCategory"
    /// <summary>
    ///   <para>rdfs:comment : Questa classe rappresenta il codice patrimoniale del bene (SEC - Modello 15), con riferimento alla classificazione del Sistema Europeo dei Conti 1995.rdfs:comment : This class represents the patrimonial code of a cultural property, referring to the SEC classification 1995.</para>
    ///   <para>rdfs:label : SEC Identifierrdfs:label : Codice SEC</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: UB/INP/INPS^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/SECIdentifier">cdesc:SECIdentifier</a>
    /// </summary>
    let SECIdentifier = _prefixId.prefix "SECIdentifier"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This class represents a copy of a cultural property created by the same author of the original cultural property.rdfs:comment : Questa classe rappresenta una replica di un bene culturale, cioè una duplicazione dell'originale da parte dello stesso autore.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa F: RO/CRF/CRFT = 'replica'</para>
    ///   <para>rdfs:label : Replicardfs:label : Same author copy</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/SameAuthorCopy">cdesc:SameAuthorCopy</a>
    /// </summary>
    let SameAuthorCopy = _prefixId.prefix "SameAuthorCopy"
    let SatellitePhotograph = _prefixId.prefix "SatellitePhotograph"
    /// <summary>
    ///   <para>rdfs:label : Scalerdfs:label : Scala</para>
    ///   <para>rdfs:comment : Questa classe rappresenta le indicazioni sulla scala di rappresentazione della documentazione grafica e cartografica.rdfs:comment : This class represents the representative scale of a graphic or cartographic documentation.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DO/DRA/DRAS^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/Scale">cdesc:Scale</a>
    /// </summary>
    let Scale = _prefixId.prefix "Scale"
    /// <summary>
    ///   <para>rdfs:label : Season cycle circumstancerdfs:label : Occasione legata al ciclo stagionale</para>
    ///   <para>rdfs:comment : Questa classe rappresenta un'occasione legata ai cicli stagionali, ovvero cicli che si riferiscono a: oggetto di concezioni, credenze, mito, scienza, di elaborazione in poesia, prosa, canto, arte e di culto; riferimento di attività, pratiche, comportamenti, di dati o fenomeni a particolari cicli, giorni, settimane, lunazioni, mesi, stagioni ecc.; giorni e periodi fausti e infausti.rdfs:comment : This class represents a circumstance related to seasonal cycles, referred to: subject of popular belief, myth, science; poetry, prose, songs, art, ritual; practical activities, behaviour, phenomena connected to specific cycles, days, months, seasons; fortunate or unfortunate days and periods.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa BDI 4.00: CA/CAO/CAOS^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/SeasonCycleCircumstance">cdesc:SeasonCycleCircumstance</a>
    /// </summary>
    let SeasonCycleCircumstance = _prefixId.prefix "SeasonCycleCircumstance"
    let SecondaryTitle = _prefixId.prefix "SecondaryTitle"
    /// <summary>
    ///   <para>rdfs:label : Interpretazione del sessordfs:label : Sex interpretation</para>
    ///   <para>rdfs:comment : This class represents the interpretation of the sex of an anthropological material.rdfs:comment : Questa classe rappresenta la stima del sesso di un reperto antropologico.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa AT: DA/STS^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/SexInterpretation">cdesc:SexInterpretation</a>
    /// </summary>
    let SexInterpretation = _prefixId.prefix "SexInterpretation"
    /// <summary>
    ///   <para>rdfs:comment : Questa classe rappresenta un'occasione connessa alla socialità quotidiana (balli, caffè, veglie, osterie)rdfs:comment : This class represents a circumstance related to social interaction (dances, pubs, wakes)</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa BDI 4.00: CA/CAO/CAOQ^^xsd:string</para>
    ///   <para>rdfs:label : Social interaction circumstancerdfs:label : Occasione legata alla socialità quotidiana</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/SocialInteractionCircumstance">cdesc:SocialInteractionCircumstance</a>
    /// </summary>
    let SocialInteractionCircumstance = _prefixId.prefix "SocialInteractionCircumstance"
    /// <summary>
    ///   <para>rdfs:label : Fonti e documentirdfs:label : Source and document</para>
    ///   <para>rdfs:comment : This class represents source and document related to an object, e.g. a cultural property.rdfs:comment : Questa classe rappresenta le fonti e i documenti testuali editi e inediti relativi a un oggetto, per esempio a un bene culturale.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DO/FNT</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/SourceAndDocument">cdesc:SourceAndDocument</a>
    /// </summary>
    let SourceAndDocument = _prefixId.prefix "SourceAndDocument"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This class represents one level of a biological taxon, the species.rdfs:comment : Questa classe rappresenta uno dei livelli di classificazione di una tassonomia biologica, ovvero la specie.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa AT: OG/OGS/OGSN^^xsd:string</para>
    ///   <para>rdfs:label : Specierdfs:label : Species</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/Species">cdesc:Species</a>
    /// </summary>
    let Species = _prefixId.prefix "Species"
    let SpecificBibliography = _prefixId.prefix "SpecificBibliography"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This class represents a stratigraphic unit from which a cultural property may come from.rdfs:comment : Questa classe rappresenta l'unità stratigrafica dalla quale può provenire un bene culturale.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RE/DSC/DSCU^^xsd:string</para>
    ///   <para>rdfs:label : Unità stratigraficardfs:label : Stratigraphic unit</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/StratigraphicUnit">cdesc:StratigraphicUnit</a>
    /// </summary>
    let StratigraphicUnit = _prefixId.prefix "StratigraphicUnit"
    let StructuralUse = _prefixId.prefix "StructuralUse"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: DA/AID/AIDI - Normativa F: SG/SGT/SGTI - Altre normative di versioni precedenti alla 4.00: OG/SGT/SGTI - ICCD Normative F, RA, SMO, PST, S, OAC, OA, MI, D, NU: RO/ROF/ROFS^^xsd:string</para>
    ///   <para>rdfs:label : Soggettordfs:label : Subject</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This class represents the subject of a cultural property, or its ornamental motif.rdfs:comment : Questa classe rappresenta il soggetto rappresentato da un bene culturale o il suo motivo decorativo.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/Subject">cdesc:Subject</a>
    /// </summary>
    let Subject = _prefixId.prefix "Subject"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This class represents one level of a biological taxon, the subspecies.rdfs:comment : Questa classe rappresenta uno dei livelli di classificazione di una tassonomia biologica, ovvero la sottospecie.</para>
    ///   <para>rdfs:label : Sottospecierdfs:label : Subspecies</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa AT: OG/OGS/OGST^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/Subspecies">cdesc:Subspecies</a>
    /// </summary>
    let Subspecies = _prefixId.prefix "Subspecies"
    /// <summary>
    ///   <para>dc11:description : Un esempio d'uso di una delle sottoclassi della classe "Indagine" è il seguente:
    /// resource:ArchaeologicalExcavation/0500590557-survey-1
    ///         a           cd:ArchaeologicalExcavation ;
    ///         rdfs:label  "Scavo archeologico 1 del bene 0500590557: Monselice, via Valli"@it ;
    ///         cd:hasActivityResponsible resource:Agent/sba ;
    ///         cd:hasStratigraphicUnit resource:StratigraphicUnit/325 ;
    ///         cd:hasSurveyMethod resource:SurveyMethod/scavo-stratigrafico ;
    ///         cd:hasSurveyMotivation resource:SurveyMotivation/opere-pubbliche ; cd:hasSurveyScientificDirector resource:Agent/bianchin-citton-elodia ;
    ///         core:hasAgentRole resource:AgentRole/0500590557-archaeological-excavation-1-activity-responsible , resource:AgentRole/0500590557-archaeological-excavation-1-scientific-director ;
    ///         tiapit:time "2004" .dc11:description : An example of usage of one of the subclasses of the class 'Survey' is the following:
    /// resource:ArchaeologicalExcavation/0500590557-survey-1
    ///         a           cd:ArchaeologicalExcavation ;
    ///         rdfs:label  "Archaeological excavation 1 of cultural property 0500590557: Monselice, via Valli"@en ;
    ///         cd:hasActivityResponsible resource:Agent/sba ;
    ///         cd:hasStratigraphicUnit resource:StratigraphicUnit/325 ;
    ///         cd:hasSurveyMethod resource:SurveyMethod/scavo-stratigrafico ;
    ///         cd:hasSurveyMotivation resource:SurveyMotivation/opere-pubbliche ; cd:hasSurveyScientificDirector resource:Agent/bianchin-citton-elodia ;
    ///         core:hasAgentRole resource:AgentRole/0500590557-archaeological-excavation-1-activity-responsible , resource:AgentRole/0500590557-archaeological-excavation-1-scientific-director ;
    ///         tiapit:time "2004" .</para>
    ///   <para>rdfs:label : Indaginerdfs:label : Survey</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This class represents a survey carried out on a cultural property, that is an activity related to a cultural property and carried out for its identification, study or observation of its technical characteristics.rdfs:comment : Questa classe rappresenta un'indagine effettuata su un bene culturale. Per indagine, si intende un'attività che riguarda il bene, effettuata per la sua individuazione (nel caso dei beni archeologici), per il suo studio e per l'approfondimento delle sue caratteristiche tecniche (indagini di scavo, di ricognizione, indagini geognostiche, analisi di vario genere e tipo, etc.). Questa classe viene specializzata in sottoclassi, per la rappresentazione di tipologie di indagini specifiche.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RE; CM/ISP - ICCD Normative NU, RA, BNB, MA, CA: RS/ALB - ICCD Normativa AT 3.00: IN/INI - ICCD Normativa SM: DR^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/Survey">cdesc:Survey</a>
    /// </summary>
    let Survey = _prefixId.prefix "Survey"
    /// <summary>
    ///   <para>rdfs:label : Survey Imagerdfs:label : Immagine di indagine</para>
    ///   <para>rdfs:comment : This class represents the image analysed during a photo interpretation or rendering survey.rdfs:comment : Questa classe rappresenta l'immagine presa in esame nel corso di una fotointerpretazione o fotorestituzione.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RE/FOI/FOIT + FOID^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/SurveyImage">cdesc:SurveyImage</a>
    /// </summary>
    let SurveyImage = _prefixId.prefix "SurveyImage"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Survey image typerdfs:label : Tipo di immagine di indagine</para>
    ///   <para>rdfs:comment : Questa classe rappresenta un tipo di immagine analizzata in una indagine di fotointerpretazione e restituzione (fotografia aerea o fotografia satellitare).rdfs:comment : This class represents the type of image analysed during a photo interpretation or rendering survey (aerial photograph, satellite photograph).</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RE/FOI/FOIT^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/SurveyImageType">cdesc:SurveyImageType</a>
    /// </summary>
    let SurveyImageType = _prefixId.prefix "SurveyImageType"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RE/RCG/RCGM; RE/DSC/DSCM^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the archeological survey method adopted.rdfs:comment : Questa classe rappresenta il metodo di scavo archeologico o di ricognizione archeologica adottato nel corso dell'indagine. (es.: sondaggio, per strati stratigrafici, occasionale, sistematico, etc.)</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Metodo di indaginerdfs:label : Survey method</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/SurveyMethod">cdesc:SurveyMethod</a>
    /// </summary>
    let SurveyMethod = _prefixId.prefix "SurveyMethod"
    /// <summary>
    ///   <para>rdfs:label : Survey Motivationrdfs:label : Motivo di indagine</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This class represents the main motivation of a survey.rdfs:comment : Questa classe rappresenta il motivo principale che ha determinato una ricognizione archeologica o uno scavo archeologico.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/SurveyMotivation">cdesc:SurveyMotivation</a>
    /// </summary>
    let SurveyMotivation = _prefixId.prefix "SurveyMotivation"
    let TemporaryExportLicense = _prefixId.prefix "TemporaryExportLicense"

    let TemporaryMovementCertification = _prefixId.prefix "TemporaryMovementCertification"

    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : Titlerdfs:label : Titolo</para>
    ///   <para>rdfs:comment : Questa classe rappresenta il titolo di un oggetto. Nel caso del dominio dei beni culturali, può rappresentare il titolo del soggetto di un bene culturale o di un'opera collegata a un bene culturale in quanto sua fase preparatoria o finale o in quanto pubblicazione contenente una stampa, oppure il titolo di una serie fotografica, etc.rdfs:comment : This class represents the title of an object, e.g. the title of the subject represented by a cultural property, or the title of a photographic series, etc.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: DA/AID/AIDN (titolo alternativo); DA/AID/AIDT (titolo) - Normativa S e MI: OG/SGT/SGTP (titolo proprio); Normativa F: SG/SGL/SGLA (titolo attribuito); SG/SGL/SGLT (titolo proprio); SG/SGL/SGLL (titolo parallelo); - Altre normative di versioni precedenti alla 4.00: OG/SGT/SGTR (titolo parallelo); OG/SGT/SGTT (titolo); ICCD Normativa S 3: RO/ADL/ADLT</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/Title">cdesc:Title</a>
    /// </summary>
    let Title = _prefixId.prefix "Title"
    /// <summary>
    ///   <para>rdfs:label : Title Typerdfs:label : Tipo di Titolo</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa classe rappresenta il tipo di titolo di un oggetto (es.: originario, alternativo).rdfs:comment : This class represents the type of an object title (e.g. original, alternative)</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: DA/AID/AIDN; DA/AID/AIDT - Normativa S e MI: OG/SGT/SGTP Normativa F: SG/SGL/SGLA; SG/SGL/SGLT; SG/SGL/SGLL - Altre normative di versioni precedenti alla 4.00: OG/SGT/SGTR; OG/SGT/SGTT - Normative VeAC e AT: DO/BSE/BSET e BSEC.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/TitleType">cdesc:TitleType</a>
    /// </summary>
    let TitleType = _prefixId.prefix "TitleType"
    /// <summary>
    ///   <para>rdfs:comment : Questa classe rappresenta una deposizione funeraria.rdfs:comment : This class represents a tomb.</para>
    ///   <para>rdfs:label : Deposizione funerariardfs:label : Tomb</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RE/DSC/DSCS^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/Tomb">cdesc:Tomb</a>
    /// </summary>
    let Tomb = _prefixId.prefix "Tomb"
    let UncertainOrigin = _prefixId.prefix "UncertainOrigin"
    /// <summary>
    ///   <para>rdfs:label : Strumento urbanistico-territorialerdfs:label : Urban planning instrument</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: TU/STU^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa classe rappresenta uno strumento urbanistico-territoriale, ovvero un piano regolatore generale e particolareggiato o un piano paesaggistico che interessa un bene culturale.rdfs:comment : This class represents a urban planning instrument, related to a cultural property.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/UrbanPlanningInstrument">cdesc:UrbanPlanningInstrument</a>
    /// </summary>
    let UrbanPlanningInstrument = _prefixId.prefix "UrbanPlanningInstrument"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa classe rappresenta l'uso del bene, che può variare nel corso del tempo, a seconda delle diverse occasioni e delle parti utilizzate del bene.rdfs:comment : This class represents the use of a cultural property, that can change over time, depending on the circumstances and on which parts of the cultural property are used.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: UT^^xsd:string</para>
    ///   <para>rdfs:label : Usordfs:label : Use</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/Use">cdesc:Use</a>
    /// </summary>
    let Use = _prefixId.prefix "Use"
    /// <summary>
    ///   <para>rdfs:label : Use functionrdfs:label : Funzione d'uso</para>
    ///   <para>rdfs:comment : This class represents the use function of an object.rdfs:comment : Questa classe rappresenta la funzione d'uso che ha un oggetto.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: UT/UTU/UTUF; LC/LDC/LDCF; LA/PRC/PRCF - BDM 2.00:UT/UTF - PST 3.01: DA/UTF^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/UseFunction">cdesc:UseFunction</a>
    /// </summary>
    let UseFunction = _prefixId.prefix "UseFunction"
    /// <summary>
    ///   <para>rdfs:comment : This class represents the type of use of a cultural property (current, previous, historical)rdfs:comment : Questa classe rappresenta il tipo di uso del bene (attuale, precedente, storico o dato non disponibile).</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : Tipo d'usordfs:label : Use type</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: UT/UTU/UTUT^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/UseType">cdesc:UseType</a>
    /// </summary>
    let UseType = _prefixId.prefix "UseType"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This class represents the specification of the type of use of a cultural property (e.g. building, ornamental, structural, instrumental)rdfs:comment : Questa classe rappresenta le specifiche sul tipo di uso del bene (reimpiego, edilizio, epigrafico, ornamentale, strumentale, strutturale).</para>
    ///   <para>rdfs:label : Use type specificationrdfs:label : Specifiche del tipo d'uso</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: UT/UTU/UTUS</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/UseTypeSpecification">cdesc:UseTypeSpecification</a>
    /// </summary>
    let UseTypeSpecification = _prefixId.prefix "UseTypeSpecification"
    let UseTypeUnavailable = _prefixId.prefix "UseTypeUnavailable"
    /// <summary>
    ///   <para>rdfs:comment : This class represents the social category of a user (e.g. of a cultural property)rdfs:comment : Questa classe rappresenta la categoria sociale a cui appartiene l'utente del bene.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normative BDM 2.00: UT/UTN/UTNC</para>
    ///   <para>rdfs:label : User social categoryrdfs:label : Categoria sociale dell'utente</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/UserSocialCategory">cdesc:UserSocialCategory</a>
    /// </summary>
    let UserSocialCategory = _prefixId.prefix "UserSocialCategory"
    /// <summary>
    ///   <para>rdfs:comment : This class represents a circumstance related to work (e.g.: agriculture, bakery)rdfs:comment : Questa classe rappresenta un'occasione connessa al lavoro (es.: panificazione, agricoltura)</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : Occasione legata al lavorordfs:label : Work circumstance</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa BDI 4.00: CA/CAO/CAOL^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/WorkCircumstance">cdesc:WorkCircumstance</a>
    /// </summary>
    let WorkCircumstance = _prefixId.prefix "WorkCircumstance"
    /// <summary>
    ///   <para>rdfs:label : Occasione legata al ciclo dell'annordfs:label : Year cycle circumstance</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa BDI 4.00: CA/CAO/CAOA^^xsd:string</para>
    ///   <para>rdfs:comment : Questa classe rappresenta un'occasione legata ai cicli dell'anno (es.: equinozio autunno, capodanno, Quaresima, Ramadan, carnevale, etc.)rdfs:comment : This class represents a circumstance related to year cycles (e.g.: autumnal equinox, New Year's Eve, Lent, Ramadan, carnival, etc.)</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/YearCycleCircumstance">cdesc:YearCycleCircumstance</a>
    /// </summary>
    let YearCycleCircumstance = _prefixId.prefix "YearCycleCircumstance"
    /// <summary>
    ///   <para>rdfs:label : abbreviationrdfs:label : abbreviazione</para>
    ///   <para>ctlog:iccdNormTag : BIBR</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta l'abbreviazione che identifica il riferimento bibliografico.rdfs:comment : This property represents the abbreviation that identifies the bibliographic reference.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/abbreviation">cdesc:abbreviation</a>
    /// </summary>
    let abbreviation = _prefixId.prefix "abbreviation"
    /// <summary>
    ///   <para>rdfs:comment : This property represents the place where an acquisition event, generally expressed, based on the available data, took place, in the form: "Region / abbreviation province / full name of the Municipality / locality or toponym"rdfs:comment : Questa proprietà rappresenta il luogo in cui è avvenuto un evento di acquisizione, generalmente espresso, in base ai dati disponibili, nella forma: "Regione/sigla provincia/denominazione per esteso del Comune/località o toponimo"</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : luogo di acquisizionerdfs:label : acquisition location</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: TU/ACQ/ACQL^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/acquisitionLocation">cdesc:acquisitionLocation</a>
    /// </summary>
    let acquisitionLocation = _prefixId.prefix "acquisitionLocation"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: TU/CDG/CDGI^^xsd:string</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta l'indirizzo di riferimento di un agente (persona, organizzazione), inteso come un tipo specifico di contatto presso il quale l'agente è reperibile.rdfs:comment : This property represents a specific type of contact at which the agent is available.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : indirizzordfs:label : address</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/address">cdesc:address</a>
    /// </summary>
    let address = _prefixId.prefix "address"
    /// <summary>
    ///   <para>rdfs:label : età della morte stimatardfs:label : estimated age of death</para>
    ///   <para>rdfs:comment : This property represents an anthropological finding estimated age of death.rdfs:comment : Questa proprietà rappresenta l'età della morte stimata nel contesto della stima dell'età della morte di un reperto antropologico.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/ageOfDeath">cdesc:ageOfDeath</a>
    /// </summary>
    let ageOfDeath = _prefixId.prefix "ageOfDeath"
    /// <summary>
    ///   <para>rdfs:label : indicazioni cronologiche relative a un agenterdfs:label : agent date</para>
    ///   <para>rdfs:comment : Questa proprietà permette di associare delle indicazioni cronologiche generiche (le date di nascita e di morte o, quando queste sono ignote, le date di attività), anche sotto forma testuale, a un agente.rdfs:comment : This property allows you to associate generic chronological indications to an agent.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/agentDate">cdesc:agentDate</a>
    /// </summary>
    let agentDate = _prefixId.prefix "agentDate"
    /// <summary>
    ///   <para>rdfs:label : codice identificativo locale dell'agenterdfs:label : agent local identifier</para>
    ///   <para>rdfs:comment : This property represents the identification code, which identifies the author's reference unambiguously in the context of a local repertoire, of an agent.rdfs:comment : Questa proprietà rappresenta il codice identificativo, che individua il riferimento autoriale in modo univoco nell'ambito di un repertorio locale, di un agente, per esempio di un autore di un bene culturale o di un agente che riveste una responsabilità nei confronti del bene (es.: editore, stampatore, etc.).</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: AU/AUT/AUTH - ICCD Normativa F 4.00: RO/CRF/CRFX; PD/PDF/PDFH - ICCD Normativa F 3.00: RO/CRF/CRFH^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/agentLocalIdentifier">cdesc:agentLocalIdentifier</a>
    /// </summary>
    let agentLocalIdentifier = _prefixId.prefix "agentLocalIdentifier"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: DA/AID/AIDN^^xsd:string</para>
    ///   <para>rdfs:label : alternative titlerdfs:label : titolo alternativo</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta un altro titolo noto del soggetto, in alternativa o in aggiunta al titolo più noto o accreditato.rdfs:comment : This property represents an entity's alternative title.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/alternativeTitle">cdesc:alternativeTitle</a>
    /// </summary>
    let alternativeTitle = _prefixId.prefix "alternativeTitle"

    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta il codice, assegnato dall'ICCD, che individua lo scavo archeologico in modo univoco a livello nazionale.rdfs:comment : This property represents the code, assigned by the ICCD, which identifies the archaeological excavation unequivocally at national level.</para>
    ///   <para>rdfs:label : archaeological excavation ICCD identifierrdfs:label : codice univoco ICCD dello scavo archeologico</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RE/DSC/DSCK^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/archaeologicalExcavationICCDIdentifier">cdesc:archaeologicalExcavationICCDIdentifier</a>
    /// </summary>
    let archaeologicalExcavationICCDIdentifier = _prefixId.prefix "archaeologicalExcavationICCDIdentifier"

    /// <summary>
    ///   <para>rdfs:label : archaeological excavation local identifierrdfs:label : codice identificativo locale dello scavo archeologico</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RE/DSC/DSCH^^xsd:string</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property represents the identification code, numeric or alphanumeric, which identifies the archaeological excavation unambiguously in the context of a local repertoire.rdfs:comment : Questa proprietà rappresenta il codice identificativo, numerico o alfanumerico, che individua lo scavo archeologico in modo univoco nell'ambito di un repertorio locale.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/archaeologicalExcavationLocalIdentifier">cdesc:archaeologicalExcavationLocalIdentifier</a>
    /// </summary>
    let archaeologicalExcavationLocalIdentifier = _prefixId.prefix "archaeologicalExcavationLocalIdentifier"

    /// <summary>
    ///   <para>rdfs:comment : This property represents the code, assigned by the ICCD, which identifies the field survey unequivocally at national level.rdfs:comment : Questa proprietà rappresenta il codice, assegnato dall'ICCD, che individua il la ricognizione archeologica in modo univoco a livello nazionale.</para>
    ///   <para>rdfs:label : codice univoco ICCD della ricognizione archeologicardfs:label : archaeological field survey ICCD identifier</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RE/RCG/RCGK^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/archaeologicalFieldSurveyICCDIdentifier">cdesc:archaeologicalFieldSurveyICCDIdentifier</a>
    /// </summary>
    let archaeologicalFieldSurveyICCDIdentifier = _prefixId.prefix "archaeologicalFieldSurveyICCDIdentifier"

    /// <summary>
    ///   <para>rdfs:label : codice identificativo locale della ricognizione archeologicardfs:label : archaeological field survey local identifier</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RE/RCG/RCGH^^xsd:string</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta il codice identificativo, numerico o alfanumerico, che individua la ricognizione archeologica in modo univoco nell'ambito di un repertorio locale.rdfs:comment : This property represents the identification code, numeric or alphanumeric, which identifies the field survey unambiguously in the context of a local repertoire.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/archeologicalFieldSurveyLocalIdentifier">cdesc:archeologicalFieldSurveyLocalIdentifier</a>
    /// </summary>
    let archeologicalFieldSurveyLocalIdentifier = _prefixId.prefix "archeologicalFieldSurveyLocalIdentifier"

    /// <summary>
    ///   <para>rdfs:label : archival record identifierrdfs:label : identificativo di unità documentaria</para>
    ///   <para>rdfs:comment : This property represents the identifier of an archival record.rdfs:comment : Questa proprietà rappresenta l'identificativo di un'unità documentaria.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa FF: PA/PAC/PACI; PA/PAC/PACA^^xsd:string</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/archivalRecordIdentifier">cdesc:archivalRecordIdentifier</a>
    /// </summary>
    let archivalRecordIdentifier = _prefixId.prefix "archivalRecordIdentifier"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta la collocazione di un'unità documentaria all'interno di un'unità archivistica complessa.rdfs:comment : This property represents the location of a documentary unit within a complex archival unit.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa F: UB/UBF/UBFC^^xsd:string</para>
    ///   <para>rdfs:label : archival record locationrdfs:label : collocazione di unità documentaria</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/archivalRecordLocation">cdesc:archivalRecordLocation</a>
    /// </summary>
    let archivalRecordLocation = _prefixId.prefix "archivalRecordLocation"
    /// <summary>
    ///   <para>rdfs:comment : This property represents the identifier of an archival record set.rdfs:comment : Questa proprietà rappresenta l'identificativo di un'unità archivistica complessa.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : archival record set identifierrdfs:label : identificativo di unità archivistica complessa</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa FF: PA/PAC/PACI; PA/PAC/PACA^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/archivalRecordSetIdentifier">cdesc:archivalRecordSetIdentifier</a>
    /// </summary>
    let archivalRecordSetIdentifier = _prefixId.prefix "archivalRecordSetIdentifier"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa F: UB/UBF/UBFU^^xsd:string</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta il titolo dell'unità archivistica complessa (fondo, serie, sottoserie, etc.) in cui si trova un'unità documentaria.rdfs:comment : This property represents the title of the archival record set in which a documentary unit is located.</para>
    ///   <para>rdfs:label : titolo di unità archivistica complessardfs:label : archival record set title</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/archivalRecordSetTitle">cdesc:archivalRecordSetTitle</a>
    /// </summary>
    let archivalRecordSetTitle = _prefixId.prefix "archivalRecordSetTitle"
    /// <summary>
    ///   <para>rdfs:label : settore ambiente quadratordfs:label : area room square</para>
    ///   <para>rdfs:comment : Questa proprietà collega uno scavo archeologico alla successione delle denominazioni, assegnate nell'ambito dello scavo, al settore (o
    /// l'area), all'ambiente e al quadrato da cui proviene il bene.rdfs:comment : This property relates an archaeological excavation to the succession of the denominations, assigned in the excavation, to the sector (or
    /// the area), to the environment and to the square from which the good comes.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RE/DSC/DSCQ^^xsd:string</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/areaRoomSquare">cdesc:areaRoomSquare</a>
    /// </summary>
    let areaRoomSquare = _prefixId.prefix "areaRoomSquare"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta un titolo attribuito di una fotografia, cioè un titolo desunto, se possibile, da fonti archivistiche, bibliografiche, orali o iconografiche (altri esemplari della stessa immagine) oppure creato in base al contenuto dell'immagine (o della serie di immagini; è necessario nei casi in cui siano del tutto assenti titoli sul/nel documento, o su materiali ad esso complementari, e nel caso in cui tali titoli risultino errati.rdfs:comment : This property represents an attributed title of a photograph, that is a title taken from archival, bibliographic, oral or iconographic sources, or created based on picture contents.</para>
    ///   <para>rdfs:label : attributed titlerdfs:label : titolo attribuito</para>
    ///   <para>ctlog:iccdNormTag : Normativa F: SG/SGL/SGLA^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/attributedTitle">cdesc:attributedTitle</a>
    /// </summary>
    let attributedTitle = _prefixId.prefix "attributedTitle"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà permette di associare il codice univoco ICCD a un autore.rdfs:comment : This property allows you to associate the unique ICCD code with an author.</para>
    ///   <para>rdfs:label : codice univoco ICCD dell'autorerdfs:label : author ICCD identifier</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: AU/AUT/AUTK^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/authorICCDIdentifier">cdesc:authorICCDIdentifier</a>
    /// </summary>
    let authorICCDIdentifier = _prefixId.prefix "authorICCDIdentifier"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà rappresenta specifiche relative all'intervento effettuato dall'autore sul bene culturale.rdfs:comment : This property represents specifications relating to the intervention carried out by the author on the cultural property.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : AU/AUT/AUTY^^xsd:string</para>
    ///   <para>rdfs:label : author interventionrdfs:label : intervento dell'autore</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/authorIntervention">cdesc:authorIntervention</a>
    /// </summary>
    let authorIntervention = _prefixId.prefix "authorIntervention"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DO/BIB/BIBK^^xsd:string</para>
    ///   <para>rdfs:label : codice univoco ICCD della bibliografiardfs:label : bibliography ICCD identifier</para>
    ///   <para>rdfs:comment : This property represents the code, assigned by the ICCD, which identifies the bibliographic reference uniquely at national level.rdfs:comment : Questa proprietà rappresenta il codice, assegnato dall'ICCD, che individua il riferimento bibliografico in modo univoco a livello nazionale.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/bibliographyICCDIdentifier">cdesc:bibliographyICCDIdentifier</a>
    /// </summary>
    let bibliographyICCDIdentifier = _prefixId.prefix "bibliographyICCDIdentifier"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta una sequenza numerica o alfanumerica che identifica il riferimento bibliografico in modo univoco nell'ambito di un repertorio locale.rdfs:comment : This property represents a numerical or alphanumeric sequence that uniquely identifies the bibliographic reference within a local repertoire.</para>
    ///   <para>rdfs:label : codice identificativo locale della bibliografiardfs:label : bibliography local identifier</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DO/BIB/BIBH^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/bibliographyLocalIdentifier">cdesc:bibliographyLocalIdentifier</a>
    /// </summary>
    let bibliographyLocalIdentifier = _prefixId.prefix "bibliographyLocalIdentifier"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà rappresenta una sintetica didascalia, se presente e utile alla comprensione di quanto documentato.rdfs:comment : This property represents a synthetic caption, useful for understanding what is documented.</para>
    ///   <para>rdfs:label : captionrdfs:label : didascalia</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : FNTN</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/caption">cdesc:caption</a>
    /// </summary>
    let caption = _prefixId.prefix "caption"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : clay specificationsrdfs:label : specifiche su pasta/argilla</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta le specifiche su eventuali componenti significativi per lo studio del bene, nel caso di analisi su reperti in argilla.rdfs:comment : This property represents specifications on any significant components for the study of the entity, in case of analysis on clay findings.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/claySpecifications">cdesc:claySpecifications</a>
    /// </summary>
    let claySpecifications = _prefixId.prefix "claySpecifications"
    /// <summary>
    ///   <para>rdfs:label : codice della collezionerdfs:label : collection identifier</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property represents the collection identifier.rdfs:comment : Questa proprietà rappresenta il codice identificativo di una collezione.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/collectionIdentifier">cdesc:collectionIdentifier</a>
    /// </summary>
    let collectionIdentifier = _prefixId.prefix "collectionIdentifier"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : UB/COL/COLM^^xsd:string</para>
    ///   <para>rdfs:label : collection leaving reasonrdfs:label : motivo di uscita dalla collezione</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta il motivo che ha determinato l'uscita da una collezione di un bene culturale.rdfs:comment : This property represents the reason that led a cultural entity to the exit from a collection.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/collectionLeavingReason">cdesc:collectionLeavingReason</a>
    /// </summary>
    let collectionLeavingReason = _prefixId.prefix "collectionLeavingReason"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta il codice d'inventario attribuito al bene nella collezione.rdfs:comment : This property represents the inventory code assigned to the cultural entity inside a collection.</para>
    ///   <para>ctlog:iccdNormTag : UB/COL/COLI^^xsd:string</para>
    ///   <para>rdfs:label : collection unit inventory identifierrdfs:label : codice inventario bene in collezione</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/collectionUnitIdentifier">cdesc:collectionUnitIdentifier</a>
    /// </summary>
    let collectionUnitIdentifier = _prefixId.prefix "collectionUnitIdentifier"

    /// <summary>
    ///   <para>rdfs:label : riferimento bibliografico completordfs:label : complete bibliographic reference</para>
    ///   <para>rdfs:comment : This property represents the complete bibliographic reference.rdfs:comment : Questa proprietà rappresenta il riferimento bibliografico completo.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DO/BIB/BIBM; RE/RCG/RCGS - versioni precedenti: DO/BIL</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/completeBibliographicReference">cdesc:completeBibliographicReference</a>
    /// </summary>
    let completeBibliographicReference = _prefixId.prefix "completeBibliographicReference"

    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This property represents contacts of an agent (i.e. email, telephone number...)rdfs:comment : Questa proprietà rappresenta i contatti di riferimento di un agente (persona, organizzazione), es. indirizzo, numeri di telefono e di fax, indirizzi di posta elettronica, ecc.</para>
    ///   <para>rdfs:label : contattirdfs:label : contacts</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa SM 4.00: OS/OSE^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/contacts">cdesc:contacts</a>
    /// </summary>
    let contacts = _prefixId.prefix "contacts"

    /// <summary>
    ///   <para>rdfs:label : cultural property inventory description</para>
    ///   <para>rdfs:comment : This property represents a cultural entity inventory description.rdfs:comment : Questa proprietà rappresenta la descrizione patrimoniale del bene, con riferimento a quanto inserito nel modello 15 RCS a cura dell'ente competente per tutela. Il dato viene richiesto direttamente agli uffici di catalogo/inventario dei relativi Istituti.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: UB/INP/INPD^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/culturalPropertyInventoryDescription">cdesc:culturalPropertyInventoryDescription</a>
    /// </summary>
    let culturalPropertyInventoryDescription = _prefixId.prefix "culturalPropertyInventoryDescription"

    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta la localizzazione geografica e collocazione specifica dell'opera derivata dal bene culturale.rdfs:comment : This property represents derivated work's geographical and specific location.</para>
    ///   <para>rdfs:label : collocazione dell'opera derivatardfs:label : derivated work location</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normative F, RA, SMO, PST, S, OAC, OA, MI, D, NU: RO/ROF/ROFC - Normativa S: RO/COP/COPC - Normativa F: RO/CRF/CRFC</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/derivatedWorkLocation">cdesc:derivatedWorkLocation</a>
    /// </summary>
    let derivatedWorkLocation = _prefixId.prefix "derivatedWorkLocation"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : diagnosirdfs:label : diagnosis</para>
    ///   <para>rdfs:comment : This property represents the diagnosis of an anthropological finding paleopathology.rdfs:comment : Questa proprietà rappresenta la diagnosi di una paleopatologia di un reperto antropologico.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa AT: PT/PTC/PTCD^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/diagnosis">cdesc:diagnosis</a>
    /// </summary>
    let diagnosis = _prefixId.prefix "diagnosis"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta il nome del file digitale che riproduce il documento, nel caso della documentazione allegata alla scheda di catalogo.rdfs:comment : This property represents the name of the digital file that reproduces the document.</para>
    ///   <para>ctlog:iccdNormTag : FTAK, DRAK, VDCK, REGK, FNTK</para>
    ///   <para>rdfs:label : nome del file digitalerdfs:label : digital filename</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/digitalFilename">cdesc:digitalFilename</a>
    /// </summary>
    let digitalFilename = _prefixId.prefix "digitalFilename"
    /// <summary>
    ///   <para>rdfs:label : documentation identifierrdfs:label : codice identificativo della documentazione</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta una sequenza numerica o alfanumerica che identifica la scheda a cui il documento si riferisce.rdfs:comment : This property represents a numeric or alphanumeric sequence that identifies the record to which the document refers.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DO/FTA/FTAN; DO/DRA/DRAN; DO/VDC/VDCN; DO/REG/REGN; DO/FNT/FNTI^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/documentationIdentifier">cdesc:documentationIdentifier</a>
    /// </summary>
    let documentationIdentifier = _prefixId.prefix "documentationIdentifier"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DO/FTA/FTAC, DO/DRA/DRAC, DO/VDC/VDCC, DO/REG/REGC, DO/FNT/FNTS^^xsd:string</para>
    ///   <para>rdfs:label : documentation locationrdfs:label : collocazione della documentazione</para>
    ///   <para>rdfs:comment : This property represents document location, which can also be expressed by inventory location or identifier.rdfs:comment : Questa proprietà rappresenta la collocazione del documento, che può anche essere espressa per mezzo della collocazione inventariale o dell'identificativo (numerico o alfanumerico) della fonte o del documento.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/documentationLocation">cdesc:documentationLocation</a>
    /// </summary>
    let documentationLocation = _prefixId.prefix "documentationLocation"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : FTAM, DRAM, VDCA, REGZ, FNTT</para>
    ///   <para>rdfs:label : titolo della documentazionerdfs:label : documentation title</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta il titolo o la denominazione del documento.rdfs:comment : This property represents document title or denomination.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/documentationTitle">cdesc:documentationTitle</a>
    /// </summary>
    let documentationTitle = _prefixId.prefix "documentationTitle"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normative VeAC e AT 3.01: DO/BSE/BSEL.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : edition locationrdfs:label : luogo dell'edizione</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta il luogo dell'edizione di un'opera.rdfs:comment : This property represents work's edition place.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/editionLocation">cdesc:editionLocation</a>
    /// </summary>
    let editionLocation = _prefixId.prefix "editionLocation"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega una ricognizione archeologica alla situazione ambientale al momento della ricognizione.rdfs:comment : This property relates an archaeological survey to environmental situation.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RE/RCG/RCGT - Versioni precedenti: RE/RCG/RCGU + RE/RCG/RCGC^^xsd:string</para>
    ///   <para>rdfs:label : environmental staterdfs:label : situazione ambientale</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/environmentalState">cdesc:environmentalState</a>
    /// </summary>
    let environmentalState = _prefixId.prefix "environmentalState"

    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : valore del bene culturalerdfs:label : cultural property value</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta il valore economico di un bene culturale. Nel caso di una collezione, questa proprietà rappresenta il valore del bene desunto, quando presente, dall'inventario della collezione o dal suo prezzo di acquisto o vendita. Nel caso di un inventario patrimoniale, questa proprietà rappresenta la stima patrimoniale del bene. Il valore viene preceduto dalla specifica della valuta.rdfs:comment : This property represents cultural entity's economic value.. The value is preceded by the currency specification.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: UB/COL/COLV; UB/INP/INP/INPA; UB/STI^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/estimatedCulturalPropertyValue">cdesc:estimatedCulturalPropertyValue</a>
    /// </summary>
    let estimatedCulturalPropertyValue = _prefixId.prefix "estimatedCulturalPropertyValue"

    /// <summary>
    ///   <para>rdfs:comment : This property represents the value estimated in the context of an estimate process.rdfs:comment : Questa proprietà rappresenta il valore stimato durante il processo di stima di un'entità.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : valore stimatordfs:label : estimated value</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/estimatedValue">cdesc:estimatedValue</a>
    /// </summary>
    let estimatedValue = _prefixId.prefix "estimatedValue"
    /// <summary>
    ///   <para>rdfs:label : data di scadenzardfs:label : expiry date</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa F 4.00 e OAC: TU/CPR/CPRD^^xsd:string</para>
    ///   <para>rdfs:comment : This property represents an expiration date.rdfs:comment : Questa proprietà rappresenta una data di scadenza, per esempio la data di scadenza dei diritti d'autore su un oggetto (come un bene culturale).</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/expiryDate">cdesc:expiryDate</a>
    /// </summary>
    let expiryDate = _prefixId.prefix "expiryDate"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà permette di rappresentare l'interpretazione di un bene culturale, ricavabile dall'osservazione diretta e dai dati conoscitivi disponibili.rdfs:comment : This property represents a cultural asset interpretation.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa CA: DA/INT - ICCD Normativa TMA: DA/DES/DESI - ICCD Normativa SI: DA/NCS^^xsd:string</para>
    ///   <para>rdfs:label : note interpretativerdfs:label : explanation note</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/explanationNote">cdesc:explanationNote</a>
    /// </summary>
    let explanationNote = _prefixId.prefix "explanationNote"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà rappresenta le note relative alle modalità di individuazione e di reperimento del bene in esame, in forma di testo libero. Possono essere integrative rispetto a quanto rappresentato come Scavo Archeologico o Ricognizione Archeologica, oppure possono essere le uniche informazioni registrate sull'individuazione e il reperimento del bene, in quelle situazioni in cui i dati a disposizione non consentono di compilare le schede di Authority file RCG-Ricognizione archeologica e/o DSC-Scavo archeologico. Vengono quindi collegate direttamente al bene.rdfs:comment : This property represents notes relating to methods for identifying and finding the cultural property in question.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : note di reperimentordfs:label : finding note</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RE/RES - ICCD Normativa RA 2.00: RP/SPR; RP/ROC/ROCC; RP/ROC/ROCI^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/findingNote">cdesc:findingNote</a>
    /// </summary>
    let findingNote = _prefixId.prefix "findingNote"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà codifica il numero di foglio o di carta del documento per la classe di documentazione Fonti e documenti.rdfs:comment : This property represent document's folio number.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : fogliordfs:label : folio</para>
    ///   <para>ctlog:iccdNormTag : DO/FNT/FNTF^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/folio">cdesc:folio</a>
    /// </summary>
    let folio = _prefixId.prefix "folio"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà rappresenta la situazione in cui si svolge l'intervento di restauro. Nel caso in cui l’intervento sul bene sia in corso al momento della schedatura e non risulti ancora concluso, il valore di questa proprietà sarà "intervento in corso" con l'eventuale indicazione del luogo presso cui si sta effettuando.rdfs:comment : This property represents the framework in which the restoration is carried out.</para>
    ///   <para>ctlog:iccdNormTag : RS/RST/RSTS^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : frameworkrdfs:label : situazione</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/framework">cdesc:framework</a>
    /// </summary>
    let framework = _prefixId.prefix "framework"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega un bene culturale coinvolto in un evento di acquisizione all'acquisizione stessa.rdfs:comment : This property relates a cultual property involved in an acquisition event to the actual acquisition.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: TU/ACQ^^xsd:string</para>
    ///   <para>rdfs:label : ha acquisizionerdfs:label : has acquisition</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasAcquisition">cdesc:hasAcquisition</a>
    /// </summary>
    let hasAcquisition = _prefixId.prefix "hasAcquisition"
    /// <summary>
    ///   <para>rdfs:label : ha tipo di acquisizionerdfs:label : has acquisition type</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This property relates a cultural entity's acquisition to its acquisition type (i.e. donation, seizure).rdfs:comment : Questa proprietà collega un'acquisizione di un bene culturale al tipo di acquisizione (es.: donazione, alienazione, confisca).</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: TU/ACQ/ACQT^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasAcquisitionType">cdesc:hasAcquisitionType</a>
    /// </summary>
    let hasAcquisitionType = _prefixId.prefix "hasAcquisitionType"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: RE/IND/INDN; CO/RST/RSTN - ICCD Normativa SM e BDM 4.00: DR/DRL - ICCD normative di versioni precedenti: RE/AIN/AINR</para>
    ///   <para>rdfs:label : has activity operatorrdfs:label : ha operatore dell'attività</para>
    ///   <para>rdfs:comment : This property relates an activity to the agent who performed the activity. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.rdfs:comment : Questa proprietà collega un'attività (per esempio, un'indagine o un intervento su un bene culturale) all'operatore dell'attività. La relazione tra il ruolo e l'agente che lo riveste è espressa nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe AgentRole, che permette di collegare l'agente e il suo ruolo.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasActivityOperator">cdesc:hasActivityOperator</a>
    /// </summary>
    let hasActivityOperator = _prefixId.prefix "hasActivityOperator"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RE/RCG/RCGR; RE/DSC/DSCF; RE/IND/INDE; RE/FOI/FOIE - Normativa SM e BDM 4.00: DR/DRV^^xsd:string</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà collega un'attività (per esempio, un'indagine o un intervento su un bene culturale) all'ente o al soggetto responsabile del rilevamento. La relazione tra il ruolo e l'agente che lo riveste è espressa nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe AgentRole, che permette di collegare l'agente e il suo ruolo.rdfs:comment : This property relates an activity to the institution or the survey's responsible entity. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.</para>
    ///   <para>rdfs:label : has activity responsiblerdfs:label : ha responsabile dell'attività</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasActivityResponsible">cdesc:hasActivityResponsible</a>
    /// </summary>
    let hasActivityResponsible = _prefixId.prefix "hasActivityResponsible"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà collega un'attività (per esempio, un'indagine o un intervento su un bene culturale) all'ente o al soggetto che ha finanziato l'attività.rdfs:comment : This property relates an activity to its investor. The investor may be an institution or an agent.</para>
    ///   <para>rdfs:label : has activity sponsorrdfs:label : ha finanziatore dell'attività</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RS/RST/RSTR; RE/IND/INDR^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasActivitySponsor">cdesc:hasActivitySponsor</a>
    /// </summary>
    let hasActivitySponsor = _prefixId.prefix "hasActivitySponsor"
    /// <summary>
    ///   <para>rdfs:label : ha età della morte stimatardfs:label : has age of death interpretation</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà collega un reperto antropologico alla stima dell'età della morte.rdfs:comment : This property relates an antropologic artifact to the interpretation of its age of death.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasAgeOfDeathInterpretation">cdesc:hasAgeOfDeathInterpretation</a>
    /// </summary>
    let hasAgeOfDeathInterpretation = _prefixId.prefix "hasAgeOfDeathInterpretation"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega l'individuazione di una responsabilità relativamente ai processi di produzione e di divulgazione che caratterizzano specificamente i beni fotografici all'agente che ha quella specifica responsabilità.rdfs:comment : This property relates the responsibility's identification to the agent which has that specific responsibility, focusing on the production process and dissemination of the photographic heritage.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : has agent with responsibilityrdfs:label : ha agente con responsabilità</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa F e FF 4.00: PD/PDF/PDFN - ICCD Normativa F 3.00: PD/PDF/PDFN o PD/PDF/PDFB^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasAgentWithResponsibility">cdesc:hasAgentWithResponsibility</a>
    /// </summary>
    let hasAgentWithResponsibility = _prefixId.prefix "hasAgentWithResponsibility"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : has alternative dating typerdfs:label : ha datazione alternativa</para>
    ///   <para>rdfs:comment : This property relates an alternative dating to its type.rdfs:comment : Questa proprietà collega una datazione alternativa con la sua tipologia.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: DT/ADT/ADTT^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasAlternativeDatingType">cdesc:hasAlternativeDatingType</a>
    /// </summary>
    let hasAlternativeDatingType = _prefixId.prefix "hasAlternativeDatingType"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This property relates a photo interepretation rendering to an anomaly revealed by a survey.rdfs:comment : Questa proprietà collega una fotointerpretazione o fotorestituzione a un'anomalia rilevata nel corso dell'indagine.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RE/FOI/FOIA + RE/FOI/FOIQ + RE/FOI/FOIF^^xsd:string</para>
    ///   <para>rdfs:label : ha anomaliardfs:label : has anomaly</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasAnomaly">cdesc:hasAnomaly</a>
    /// </summary>
    let hasAnomaly = _prefixId.prefix "hasAnomaly"
    /// <summary>
    ///   <para>rdfs:label : has anomaly originrdfs:label : ha origine dell'anomalia</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RE/FOI/FOIA^^xsd:string</para>
    ///   <para>rdfs:comment : Questa proprietà collega un'anomalia rilevata durante una fotointerpretazione o fotorestituzione all'origine dell'anomalia (naturale, antropica, incerta).rdfs:comment : This property relates an anomaly detected during a photo interpretation or rendering survey to the origin of the anomaly (e.g. natural, unsure).</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasAnomalyOrigin">cdesc:hasAnomalyOrigin</a>
    /// </summary>
    let hasAnomalyOrigin = _prefixId.prefix "hasAnomalyOrigin"
    /// <summary>
    ///   <para>rdfs:comment : This property relates an anomaly revealed by a photo interpretation rendering to its anomaly type (line, point, poligony anomaly).rdfs:comment : Questa proprietà collega un'anomalia rilevata nel corso di una fotointerpretazione o fotorestituzione al tipo di anomalia (puntuale, lineare, areale).</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RE/FOI/FOIQ^^xsd:string</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : ha tipo di anomaliardfs:label : has anomaly type</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasAnomalyType">cdesc:hasAnomalyType</a>
    /// </summary>
    let hasAnomalyType = _prefixId.prefix "hasAnomalyType"

    /// <summary>
    ///   <para>rdfs:label : ha tipo di indagine su bene archeologicordfs:label : has archaeological property survey type</para>
    ///   <para>rdfs:comment : Questa proprietà collega un'indagine su un bene archeologico al tipo di indagine.rdfs:comment : This property relates a survey on an archaeological property to the type of survey.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa AT 3.00: IN/INI/INIT^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasArchaeologicalPropertySurveyType">cdesc:hasArchaeologicalPropertySurveyType</a>
    /// </summary>
    let hasArchaeologicalPropertySurveyType = _prefixId.prefix "hasArchaeologicalPropertySurveyType"

    /// <summary>
    ///   <para>rdfs:comment : This property relates an arecheometric diagnostic survey to its type (i.e. thermal imaging, coring).rdfs:comment : Questa proprietà collega un'indagine archeometrica e diagnostica al suo tipo (es.: analisi della malta, carotaggio, termografia, etc.)</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RE/IND/INDI - ICCD normative di versioni precedenti: RE/AIN/AINT</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : has archaeometric diagnostic survey typerdfs:label : ha tipo di indagine archeometrica e diagnostica</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasArchaeometricDiagnosticSurveyType">cdesc:hasArchaeometricDiagnosticSurveyType</a>
    /// </summary>
    let hasArchaeometricDiagnosticSurveyType = _prefixId.prefix "hasArchaeometricDiagnosticSurveyType"

    /// <summary>
    ///   <para>rdfs:label : ha unità archivistica complessardfs:label : has archival record set</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà, inversa a "è unità archivistica complessa in", collega il rapporto tra una unità archivistica complessa e un bene culturale che ne fa parte alla unità archivistica stessa.rdfs:comment : This property relates the relationship of an archival set and a one of its belonging cultural entities.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa F: UB/UBF^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasArchivalRecordSet">cdesc:hasArchivalRecordSet</a>
    /// </summary>
    let hasArchivalRecordSet = _prefixId.prefix "hasArchivalRecordSet"
    /// <summary>
    ///   <para>rdfs:comment : This property relates the documentation made of sources and documents to the archive or conservative institution.rdfs:comment : Questa proprietà collega una documentazione costituita da fonti e documenti all'archivio e/o istituzione conservativa.</para>
    ///   <para>rdfs:label : has archiverdfs:label : ha archivio</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DO/FNT/FNTN^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasArchive">cdesc:hasArchive</a>
    /// </summary>
    let hasArchive = _prefixId.prefix "hasArchive"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa AT 3.01: OG/OGC/OGCE^^xsd:string</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà collega il contesto di rinvenimento di un bene culturale (in particolare, un reperto antropologico) a un elemento associato al bene in quel contesto (es.: orecchini, scudo, resti di tessuto).rdfs:comment : This property relates a finding context of a cultural property (in particular, an anthropological material) to an object associated to the cultural property (e.g: earrings, shield, cloth, etc.)</para>
    ///   <para>rdfs:label : ha elemento associatordfs:label : has associated object</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasAssociatedObject">cdesc:hasAssociatedObject</a>
    /// </summary>
    let hasAssociatedObject = _prefixId.prefix "hasAssociatedObject"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega una situazione in cui viene attribuito un autore a un bene culturale all'autore stesso.rdfs:comment : This property relates a situation where an autorship is attributed to a cultural entity's author.</para>
    ///   <para>ctlog:iccdNormTag : AU/AUT/AUTN (+ AU/AUT/AUTS); AU/AAT; AU/AAT/AATN^^xsd:string</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : has attributed authorrdfs:label : ha autore attribuito</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasAttributedAuthor">cdesc:hasAttributedAuthor</a>
    /// </summary>
    let hasAttributedAuthor = _prefixId.prefix "hasAttributedAuthor"
    /// <summary>
    ///   <para>rdfs:comment : This property relates an entity to its author.rdfs:comment : Questa proprietà collega una entità di qualsiasi tipo (documentazione, bene culturale, etc.) con il suo autore.rdfs:comment : This property relates a entity (i.e. documentation, cultural entity, etc.) to its author.</para>
    ///   <para>rdfs:label : ha autorerdfs:label : has author</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: DO/FTA/FTAA, DO/DRA/DRAA, DO/VDC/VDCR, DO/REG/REGA, DO/FNT/FNTA, DO/BIB/BIBA - Normativa S 3: RO/ADL/ADLA - Normative VeAC e AT 3.01: DO/BSE/BSEA - Normativa MI 3.00: AU/DDC/DDCN</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasAuthor">cdesc:hasAuthor</a>
    /// </summary>
    let hasAuthor = _prefixId.prefix "hasAuthor"

    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega un'entità descritta in una scheda di Authority File all'ente schedatore dell'authority file stesso. Per esempio, l'attribuzione di un autore a un bene culturale, uno scavo archeologico, una ricognizione archeologica, una bibliografia. Questa proprietà, esprimendo il significato della relazione nel nome, dà una rappresentazione semplificata della relazione che lega questa entità, l'authority file, e l'ente schedatore dell'authority file.rdfs:comment : This property relates an entity described in a authority file to the file's cataloguing institution.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : ha ente schedatore dell'authority filerdfs:label : has authority file cataloguing agency</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: AU/AUT/AUTJ; DO/BIB/BIBJ; RE/RCG/RCGJ; RE/DSC/DSCJ - ICCD Normativa F: PD/PDF/PDFJ^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasAuthorityFileCataloguingAgency">cdesc:hasAuthorityFileCataloguingAgency</a>
    /// </summary>
    let hasAuthorityFileCataloguingAgency = _prefixId.prefix "hasAuthorityFileCataloguingAgency"

    /// <summary>
    ///   <para>rdfs:comment : Proprietà che lega un oggetto culturale a un'attribuzione di autore o di responsabilità relativa all'oggetto.rdfs:comment : This property relates a cultural entity to an authorship or resposibility attribution of the entity.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: AU/AUT; AU/ATB; AU/AAT^^xsd:string</para>
    ///   <para>rdfs:label : has authorship attributionrdfs:label : ha attribuzione di autore/responsabilità</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasAuthorshipAttribution">cdesc:hasAuthorshipAttribution</a>
    /// </summary>
    let hasAuthorshipAttribution = _prefixId.prefix "hasAuthorshipAttribution"
    /// <summary>
    ///   <para>rdfs:comment : This property relates an entity to its bibliography.rdfs:comment : Questa proprietà collega un'entità alla sua bibliografia. Per esempio, nell'ambito del Catalogo Generale, collega un bene culturale alla bibliografia che riguarda il bene stesso, descritto in una scheda di catalogo.</para>
    ///   <para>rdfs:label : ha bibliografiardfs:label : has bibliography</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DO/BIB; RE/RCG/RCGS^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasBibliography">cdesc:hasBibliography</a>
    /// </summary>
    let hasBibliography = _prefixId.prefix "hasBibliography"
    /// <summary>
    ///   <para>rdfs:label : ha tipo di bibliografiardfs:label : has bibliography type</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà collega la bibliografia al tipo di riferimento bibliografico.rdfs:comment : This property relates a bibliography to its bibliography type.</para>
    ///   <para>ctlog:iccdNormTag : BIB/BIBF^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasBibliographyType">cdesc:hasBibliographyType</a>
    /// </summary>
    let hasBibliographyType = _prefixId.prefix "hasBibliographyType"
    /// <summary>
    ///   <para>rdfs:label : ha tassonomia biologicardfs:label : has biological taxon</para>
    ///   <para>rdfs:comment : Questa proprietà collega un'entità biologica a una tassonomia.rdfs:comment : This property relates a biological entity to a taxon.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa AT: OG/OGS^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasBiologicalTaxon">cdesc:hasBiologicalTaxon</a>
    /// </summary>
    let hasBiologicalTaxon = _prefixId.prefix "hasBiologicalTaxon"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This property relates a cultural enity involved in a change of availability event (i.e. theft, destruction, recovery) to the event.rdfs:comment : Questa proprietà collega un bene culturale coinvolto in un un evento di mutamento di condizione materiale (furto, distruzione, recupero) all'evento stesso.</para>
    ///   <para>rdfs:label : has change of availabilityrdfs:label : ha mutamento condizione materiale</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasChangeOfAvailability">cdesc:hasChangeOfAvailability</a>
    /// </summary>
    let hasChangeOfAvailability = _prefixId.prefix "hasChangeOfAvailability"
    /// <summary>
    ///   <para>rdfs:comment : This property relates a cultural entity's change of availability to the event type (i.e. theft, destruction, recovery).rdfs:comment : Questa proprietà collega il mutamento di condizione materiale di un bene culturale al tipo di evento (es.: furto, distruzione, recupero).</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : has change of availability typerdfs:label : ha tipo di mutamento condizione materiale</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: TU/ALN/ALNT^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasChangeOfAvailabilityType">cdesc:hasChangeOfAvailabilityType</a>
    /// </summary>
    let hasChangeOfAvailabilityType = _prefixId.prefix "hasChangeOfAvailabilityType"
    /// <summary>
    ///   <para>rdfs:label : has circumstancerdfs:label : ha circostanza</para>
    ///   <para>rdfs:comment : Questa proprietà collega una situazione all'occasione che ha determinato quella situazione. Per esempio, può collegare una situazione in cui viene indicata la committenza di un bene culturale all'occasione che ha determinato quella committenza, oppure un luogo di ripresa di un bene fotografico all'occasione che ha determinato il motivo della ripresa, o ancora l'uso di un bene culturale all'occasione d'uso.rdfs:comment : This property relates a situation to the circumstance which led to the situation. For example it can connect a situation where is indicated a cultural entity's committment to its circumstance.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: UT/UTU/UTUO; normativa BDM: UT/UTO; AU/CMM/CMMC; normativa VeAC: AU/FRU/FRUC; normativa F: LR/LRO - ICCD Normativa MI: AU/DDC/DDCC^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasCircumstance">cdesc:hasCircumstance</a>
    /// </summary>
    let hasCircumstance = _prefixId.prefix "hasCircumstance"
    /// <summary>
    ///   <para>rdfs:comment : This property relates the circumstance to its type.rdfs:comment : Questa proprietà collega un'occasione con il tipo di occasione.</para>
    ///   <para>rdfs:label : ha tipo di circostanzardfs:label : has circumstance type</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa BDI: CA/CAR; CA/CAC^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasCircumstanceType">cdesc:hasCircumstanceType</a>
    /// </summary>
    let hasCircumstanceType = _prefixId.prefix "hasCircumstanceType"
    /// <summary>
    ///   <para>rdfs:comment : This property relates a numismatic entity to its issuance.rdfs:comment : Questa proprietà collega un bene numismatico alla sua emissione, o una contromarca a una nuova emissione che sostituisce nominale, autorità emittente, zecca e cronologia della moneta originari.</para>
    ///   <para>rdfs:label : ha emissione di monetardfs:label : has coin issuance</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa NU: DA/AUE; DA/CON/CONN; DA/CON/CONZ; DA/CON/CONA; DA/CON/CONC - ICCD Normativa OA (dopo il rilascio della specifica scheda NU nel 2004 la scheda OA non è stata più utilizzata per la catalogazione di monete e medaglie): AU/EDT</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasCoinIssuance">cdesc:hasCoinIssuance</a>
    /// </summary>
    let hasCoinIssuance = _prefixId.prefix "hasCoinIssuance"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : ha moneta membrordfs:label : has coin member</para>
    ///   <para>rdfs:comment : Questa proprietà collega una serie di monete a una moneta che ne è membro.rdfs:comment : This property relates a numismatic series to a coin that is member of it.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasCoinMember">cdesc:hasCoinMember</a>
    /// </summary>
    let hasCoinMember = _prefixId.prefix "hasCoinMember"
    /// <summary>
    ///   <para>rdfs:label : ha collezionerdfs:label : has collection</para>
    ///   <para>rdfs:comment : Questa proprietà collega l'appartenenza di un bene culturale a una collezione in un intervallo di tempo alla collezione coinvolta nella relazionerdfs:comment : This property relates a cultural property to the collection to which it belongs in a time span.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : UB/COL/COLD^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasCollection">cdesc:hasCollection</a>
    /// </summary>
    let hasCollection = _prefixId.prefix "hasCollection"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega una collezione di beni culturali al collezionista.rdfs:comment : This property relates a collection of cultural properties to its collector.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : UB/COL/COLN^^xsd:string</para>
    ///   <para>rdfs:label : has collectorrdfs:label : ha collezionista</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasCollector">cdesc:hasCollector</a>
    /// </summary>
    let hasCollector = _prefixId.prefix "hasCollector"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega un bene culturale alla sua committenza.rdfs:comment : This property relates a cultural entity to its commission.</para>
    ///   <para>rdfs:label : ha committenzardfs:label : has commission</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/arco/context-description/^^xsd:string</para>
    ///   <para>ctlog:iccdNormTag : AU/CMM^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasCommission">cdesc:hasCommission</a>
    /// </summary>
    let hasCommission = _prefixId.prefix "hasCommission"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : has committentrdfs:label : ha committente</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: AU/CMM/CMMN^^xsd:string</para>
    ///   <para>rdfs:comment : This property relates a situation where it is indicated a cultural entity's commission to the investor agent or institution.rdfs:comment : Questa proprietà collega una situazione in cui viene indicata la committenza di un bene culturale alla persona o istituzione committente.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasCommittent">cdesc:hasCommittent</a>
    /// </summary>
    let hasCommittent = _prefixId.prefix "hasCommittent"
    /// <summary>
    ///   <para>rdfs:label : has copyrightrdfs:label : ha diritti d'autore</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa F 4.00 e OAC: TU/CPR^^xsd:string</para>
    ///   <para>rdfs:comment : This property relates an entity to copiright held by an agent or its "public domain" condition, if it is out of copyright.rdfs:comment : Questa proprietà collega un'entità, per esempio un bene fotografico, ai diritti d'autore detenuti da un agente, o allo stato di "in pubblico dominio" relativo all'entità stessa, qualora i diritti siano scaduti.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasCopyright">cdesc:hasCopyright</a>
    /// </summary>
    let hasCopyright = _prefixId.prefix "hasCopyright"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : ha titolare dei diritti d'autorerdfs:label : has copyright holder</para>
    ///   <para>rdfs:comment : This property relates an entity's copyright to its copyright holder. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.rdfs:comment : Questa proprietà collega i diritti d'autore di un'entità al titolare dei diritti d'autore. Questa proprietà fornisce una rappresentazione semplificata della relazione, il cui valore viene esplicitato nel nome della proprietà. La stessa relazione viene anche modellata nell'ontologia, in maniera più espressiva, per mezzo della classe AgentRole, che permette di collegare un agente al ruolo che ha rivestito (in questo caso, al ruolo di "titolare dei diritti d'autore").</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa F 4.00 e OAC: TU/CPR/CPRN^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasCopyrightHolder">cdesc:hasCopyrightHolder</a>
    /// </summary>
    let hasCopyrightHolder = _prefixId.prefix "hasCopyrightHolder"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : ha luogo di creazionerdfs:label : è stato realizzato inrdfs:label : has creation location</para>
    ///   <para>rdfs:comment : Questa proprietà collega un bene culturale a un altro bene culturale collegato, che ne costituisce la sede di produzione/realizzazione.rdfs:comment : This property relates a cultural entity to a connected cultural entity which constitutes its production site.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RV/RSE/RSER = 'è stato realizzato in' (versioni precedenti: 'sede di realizzazione')</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasCreationLocation">cdesc:hasCreationLocation</a>
    /// </summary>
    let hasCreationLocation = _prefixId.prefix "hasCreationLocation"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : has cultural geographic areardfs:label : ha area geografico-culturale</para>
    ///   <para>rdfs:comment : This property relates a cultural entity's use to its cultural geographical area.rdfs:comment : Questa proprietà collega l'uso del bene con la sua area geografico-culturale.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasCulturalGeographicArea">cdesc:hasCulturalGeographicArea</a>
    /// </summary>
    let hasCulturalGeographicArea = _prefixId.prefix "hasCulturalGeographicArea"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà collega un bene culturale alla stima effettuata sul bene stesso.rdfs:comment : This property relates a cultural property to the estimate of that cultural property.</para>
    ///   <para>rdfs:label : has cultural property estimaterdfs:label : ha stima di bene culturale</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasCulturalPropertyEstimate">cdesc:hasCulturalPropertyEstimate</a>
    /// </summary>
    let hasCulturalPropertyEstimate = _prefixId.prefix "hasCulturalPropertyEstimate"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normative RA, SMO, PST, S, OAC, OA, MI, D, NU, F: RO/ROF/ROFF</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : ha fase di realizzazionerdfs:label : has cultural property stage</para>
    ///   <para>rdfs:comment : Questa proprietà collega il rapporto tra un bene culturale e un'altra entità collegata (opera preparatoria o opera finale) allo stadio di realizzazione del bene stesso in rapporto a questa entità.rdfs:comment : This property relates the relatioship between a cultural property and a related work (preparatory or final work) to the stage of the cultural property referring to this related work.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasCulturalPropertyStage">cdesc:hasCulturalPropertyStage</a>
    /// </summary>
    let hasCulturalPropertyStage = _prefixId.prefix "hasCulturalPropertyStage"
    /// <summary>
    ///   <para>rdfs:comment : This property relates a situation, where a cultural scope is attributed to a cultural entity, to the cultural scope.rdfs:comment : Questa proprietà collega una situazione in cui viene attribuito un ambito culturale di un bene culturale all'ambito culturale stesso.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: AU/ATB^^xsd:string</para>
    ///   <para>rdfs:label : has cultural scoperdfs:label : ha ambito culturale</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasCulturalScope">cdesc:hasCulturalScope</a>
    /// </summary>
    let hasCulturalScope = _prefixId.prefix "hasCulturalScope"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DT - ICCD Normative F, RA, SMO, PST, S, OAC, OA, MI, D, NU: RO/ROF^^xsd:string</para>
    ///   <para>rdfs:comment : Questa proprietà collega un'entità alla sua cronologia.rdfs:comment : This property relates an entity to its dating.</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/arco/context-description/^^xsd:string</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : ha cronologiardfs:label : has dating</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasDating">cdesc:hasDating</a>
    /// </summary>
    let hasDating = _prefixId.prefix "hasDating"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : DTN/DTNS; se non c'è, Event = "realizzazione"</para>
    ///   <para>rdfs:label : ha evento relativo a datazionerdfs:label : has event related to dating</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà collega una cronologia a un evento relativo al bene culturale, cui si riferisce la specifica cronologia.rdfs:comment : This property relates a dating to an event involving the cultural property, which the dating is about.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasDatingEvent">cdesc:hasDatingEvent</a>
    /// </summary>
    let hasDatingEvent = _prefixId.prefix "hasDatingEvent"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega un'opera derivata da un bene culturale al tipo di opera derivata.rdfs:comment : This property relates a work derivated from a cultural entity to its type.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : has derivated work typerdfs:label : ha tipo di opera derivata</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa F: RO/CRF/CRFT - Normativa S: RO/ADL/ADLL - Normative RA, SMO, PST, S, OA, MI, D, NU: RO/REI/REIT - Normative CA, MA: RO/RIU/RIUT</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasDerivatedWorkType">cdesc:hasDerivatedWorkType</a>
    /// </summary>
    let hasDerivatedWorkType = _prefixId.prefix "hasDerivatedWorkType"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: OG/OGM^^xsd:string</para>
    ///   <para>rdfs:label : ha metodo di individuazionerdfs:label : has detection method</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This property relates a cultural property to the detection method that allowed the detection of the cultural property.rdfs:comment : Questa proprietà collega un bene culturale alla modalità di individuazione che ne ha permesso l'individuazione.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasDetectionMethod">cdesc:hasDetectionMethod</a>
    /// </summary>
    let hasDetectionMethod = _prefixId.prefix "hasDetectionMethod"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property relates a cultural entity to the documentation related to the cutultural entity described in a catalogue record.rdfs:comment : Questa proprietà collega un bene culturale alla documentazione che riguarda il bene descritto in una scheda di catalogo.</para>
    ///   <para>rdfs:label : ha documentazionerdfs:label : has documentation</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: tutti i campi strutturati di DO tranne BIB</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasDocumentation">cdesc:hasDocumentation</a>
    /// </summary>
    let hasDocumentation = _prefixId.prefix "hasDocumentation"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : FTAP, DRAT, FNTP (+VDCP, REGP), ADMP (v. 3.00 e 3.01)^^xsd:string</para>
    ///   <para>rdfs:comment : This property relates a documentation to its type.rdfs:comment : Questa proprietà collega una documentazione al tipo di documentazione.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : has documentation typerdfs:label : ha tipo di documentazione</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasDocumentationType">cdesc:hasDocumentationType</a>
    /// </summary>
    let hasDocumentationType = _prefixId.prefix "hasDocumentationType"
    /// <summary>
    ///   <para>rdfs:label : ha edizionerdfs:label : has edition</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà collega un'entità a una sua edizione.rdfs:comment : This property relates an entity to its edition.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normative VeAC e AT 3.01: DO/BSE/BSEN - Normativa S 3.00: RO/ADL/ADLE.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasEdition">cdesc:hasEdition</a>
    /// </summary>
    let hasEdition = _prefixId.prefix "hasEdition"
    /// <summary>
    ///   <para>rdfs:label : has editorrdfs:label : ha editore</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà collega un'edizione all'editore.rdfs:comment : This property relates an edition to its editor.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasEditor">cdesc:hasEditor</a>
    /// </summary>
    let hasEditor = _prefixId.prefix "hasEditor"
    /// <summary>
    ///   <para>rdfs:label : has eligible interventionrdfs:label : ha intervento ammesso</para>
    ///   <para>rdfs:comment : This property relates a urban planning instrument to the eligible intervention (e.g.: conservation intervention/ exceptional maintenance).rdfs:comment : Questa proprietà collega uno strumento urbanistico-territoriale all'intervento ammesso dalla normativa specifica (es.: restauro/ manutenzione straordinaria).</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: TU/STU/STUN^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasEligibleIntervention">cdesc:hasEligibleIntervention</a>
    /// </summary>
    let hasEligibleIntervention = _prefixId.prefix "hasEligibleIntervention"
    /// <summary>
    ///   <para>rdfs:label : ha stimardfs:label : has estimate</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: UB/STI - ICCD Normative di versione 2.00: UB/INV/INVS^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This property relates an entity to its estimate.rdfs:comment : Questa proprietà collega un'entità a una sua stima.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasEstimate">cdesc:hasEstimate</a>
    /// </summary>
    let hasEstimate = _prefixId.prefix "hasEstimate"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega un bene culturale a una certificazione amministrativa per la circolazione e l'esportazione/importazione che riguarda il bene stesso.rdfs:comment : This property relates a cultural entity to its import-export certification.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: TU/ESP^^xsd:string</para>
    ///   <para>rdfs:label : ha certificazione di esportazione/importazionerdfs:label : has export/import certification</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasExportImportCertification">cdesc:hasExportImportCertification</a>
    /// </summary>
    let hasExportImportCertification = _prefixId.prefix "hasExportImportCertification"

    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: TU/ESP/ESPT^^xsd:string</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : has export import certification type</para>
    ///   <para>rdfs:comment : ha tipo di certificazione di esportazione o importazionerdfs:comment : Questa proprietà collega una certificazione amministrativa di circolazione ed esportazione/importazione di un bene culturale alla sua tipologia (es.: attestato di libera circolazione, licenza di esportazione definitiva, ecc).rdfs:comment : This property relates a import-export certification of a cultural entity to its type (i.e. delivery confirmation certification, free movement certification etc).</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasExportImportCertificationType">cdesc:hasExportImportCertificationType</a>
    /// </summary>
    let hasExportImportCertificationType = _prefixId.prefix "hasExportImportCertificationType"

    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: TU/ESP/ESPU^^xsd:string</para>
    ///   <para>rdfs:label : has export officerdfs:label : ha ufficio esportazione</para>
    ///   <para>rdfs:comment : This property relates an export/import certification to the certifying Export Department.rdfs:comment : Questa proprietà collega una certificazione di importazione/esportazione al'Ufficio Esportazione che ha emesso la certificazione.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasExportOffice">cdesc:hasExportOffice</a>
    /// </summary>
    let hasExportOffice = _prefixId.prefix "hasExportOffice"
    /// <summary>
    ///   <para>rdfs:label : has finding contextrdfs:label : ha contesto di rinvenimento</para>
    ///   <para>rdfs:comment : Questa proprietà collega un bene culturale, in particolare un reperto antropologico, al suo contesto di rinvenimento.rdfs:comment : This property relates a cultural property, and in particular an anthropological material, to its finding context.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa AT 3.01: OG/OGC^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasFindingContext">cdesc:hasFindingContext</a>
    /// </summary>
    let hasFindingContext = _prefixId.prefix "hasFindingContext"
    /// <summary>
    ///   <para>rdfs:label : ha tipo di contesto di rinvenimentordfs:label : has finding context type</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa AT 3.01: OG/OGC/OGCT^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà collega il contesto di rinvenimento di un bene culturale, e in particolare di un reperto antropologico, al tipo di contesto.rdfs:comment : This property relates a cultural property (anthropological material) finding context to the type of context.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasFindingContextType">cdesc:hasFindingContextType</a>
    /// </summary>
    let hasFindingContextType = _prefixId.prefix "hasFindingContextType"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property relates a cultural entity to a connected cultural entity which constitutes the site where it was rediscovered.rdfs:comment : Questa proprietà collega un bene culturale a un altro bene culturale collegato, che ne costituisce la sede di rinvenimento archeologico.</para>
    ///   <para>rdfs:label : è stato rinvenuto inrdfs:label : has finding locationrdfs:label : ha sede di rinvenimento</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RV/RSE/RSER = 'è stato rinvenuto in' (versioni precedenti: 'sede di rinvenimento')</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasFindingLocation">cdesc:hasFindingLocation</a>
    /// </summary>
    let hasFindingLocation = _prefixId.prefix "hasFindingLocation"
    /// <summary>
    ///   <para>rdfs:comment : This property relates the documentation to its format.rdfs:comment : Questa proprietà collega la documentazione con il suo formato.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : has formatrdfs:label : ha formato</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: DO/FTA/FTAF, DO/DRA/DRAF, DO/DNT/FNTR^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasFormat">cdesc:hasFormat</a>
    /// </summary>
    let hasFormat = _prefixId.prefix "hasFormat"
    /// <summary>
    ///   <para>rdfs:comment : This property relates garment to the context in which it has been worn.rdfs:comment : Questa proprietà collega un vestimento antico o contemporaneo a un'occasione in cui è stato indossato da una o più persone.</para>
    ///   <para>rdfs:label : has fruitionrdfs:label : ha fruizione</para>
    ///   <para>ctlog:iccdNormTag : Normativa VeAC: AU/FRU^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasFruition">cdesc:hasFruition</a>
    /// </summary>
    let hasFruition = _prefixId.prefix "hasFruition"
    /// <summary>
    ///   <para>rdfs:label : ha genererdfs:label : has genus</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa AT: OG/OGS/OGSG^^xsd:string</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property relates a biological taxon to the genus, that is one of the concept of the taxon.rdfs:comment : Questa proprietà collega una tassonomia biologica al genere, che è uno dei concetti della tassonomia.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasGenus">cdesc:hasGenus</a>
    /// </summary>
    let hasGenus = _prefixId.prefix "hasGenus"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This property relates an authorship, dating, commission, or other interpretation situations, to the reason or criterion which led to that interpretation.rdfs:comment : Questa proprietà associa una attribuzione di autore/responsabilità, una cronologia, una committenza, o altre situazioni che prevedono una interpretazione, alla motivazione o criterio che hanno determinato quella interpretazione.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: AU/AUT/AUTM; AU/CMM/CMMF; AU/AAT/AATM; AU/ATB/ATBM; DT/DTM/DTMM; SG/SGT/SGTL - ICCD Normativa F: PD/PDF/PDFM - ICCD Normativa VeAC: AU/FRU/FRUF - CCD Normative F, RA, SMO, PST, S, OAC, OA, MI, D, NU: RO/ROF/ROFM^^xsd:string</para>
    ///   <para>rdfs:label : ha criterio interpretativordfs:label : has interpretation criterion</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasInterpretationCriterion">cdesc:hasInterpretationCriterion</a>
    /// </summary>
    let hasInterpretationCriterion = _prefixId.prefix "hasInterpretationCriterion"
    /// <summary>
    ///   <para>rdfs:label : has interventionrdfs:label : ha intervento</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: CO/RST; normative di versioni precedenti: RS/RST - Normativa VeAC: CO/RIA - Normativa CA: RO/RIS</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property relates a cultural entity to a intervention on it, for conservational or other purposes.rdfs:comment : Questa proprietà collega un bene culturale con un intervento, a fini conservativi o di altro tipo, che lo ha interessato.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasIntervention">cdesc:hasIntervention</a>
    /// </summary>
    let hasIntervention = _prefixId.prefix "hasIntervention"
    /// <summary>
    ///   <para>rdfs:label : has intervention rolerdfs:label : ha ruolo nell'intervento</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : AU/ATB/ATBR; AU/AUT/AUTR^^xsd:string</para>
    ///   <para>rdfs:comment : This property relates an authorship attribution to the agent's role.rdfs:comment : Questa proprietà associa un'attribuzione di autore/responsabilità al ruolo rivestito dall'autore o dall'ambito culturale.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasInterventionRole">cdesc:hasInterventionRole</a>
    /// </summary>
    let hasInterventionRole = _prefixId.prefix "hasInterventionRole"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : ha tipo di interventordfs:label : has intervention type</para>
    ///   <para>rdfs:comment : This property relates an intervention on a cultural property (i.e. conservation, interventions, reprocessing, restoring, etc.) to its intervention type.rdfs:comment : Questa proprietà collega un intervento, a fini conservativi o di altro tipo, che ha interessato un bene culturale al tipo di intervento.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: valori di CO/RST/RSTI
    /// Normativa VeAC: CO/RIA (riadattamento/modifica)
    /// Normativa CA: RO/RIS (intervento successivo)</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasInterventionType">cdesc:hasInterventionType</a>
    /// </summary>
    let hasInterventionType = _prefixId.prefix "hasInterventionType"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : ha inventariordfs:label : has inventory</para>
    ///   <para>rdfs:comment : This property relates a cultural property or an entity or an activity related to it to an inventory.rdfs:comment : Questa proprietà collega un bene culturale o una delle entità o attività collegate al bene culturale a un inventario che registra informazioni relative al bene culturale.</para>
    ///   <para>ctlog:iccdNormTag : UB/INV; ICCD Normativa Trasversale: UB/INP^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasInventory">cdesc:hasInventory</a>
    /// </summary>
    let hasInventory = _prefixId.prefix "hasInventory"

    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà collega un inventario al contenitore giuridico che conserva attualmente il bene o che lo ha conservato in passato, e che è responsabile dell'assegnazione del numero di inventario.rdfs:comment : This property relates an inventory to the juridical container responsible for the inventory identifier of the cultural property.</para>
    ///   <para>rdfs:label : ha responsabile di numero di inventariordfs:label : has inventory identifier responsible</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: UB/INV/INVG</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasInventoryIdentifierResponsible">cdesc:hasInventoryIdentifierResponsible</a>
    /// </summary>
    let hasInventoryIdentifierResponsible = _prefixId.prefix "hasInventoryIdentifierResponsible"

    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : has issuerrdfs:label : ha soggetto emittente</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa NU: DA/AUE/AUEE - ICCD Normativa OA (dopo il rilascio della specifica scheda NU nel 2004 la scheda OA non è stata più utilizzata per la catalogazione di monete e medaglie): AU/EDT/EDTN</para>
    ///   <para>rdfs:comment : Questa proprietà collega l'emissione della moneta al soggetto emittente. Questa proprietà, esprimendo il significato della relazione nel nome, dà una rappresentazione semplificata della relazione che lega questa entità e l'agente; la stessa relazione è rappresentata attraverso una n-ary relation, arco-core:AgentRole, che permette di collegare l'agente al ruolo che riveste nei confronti dell'entità.rdfs:comment : This property relates to coin's issuance to the issuer agent. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasIssuer">cdesc:hasIssuer</a>
    /// </summary>
    let hasIssuer = _prefixId.prefix "hasIssuer"
    /// <summary>
    ///   <para>rdfs:comment : This property relates an urban-planning instrument to the institution which issued the provision.rdfs:comment : Questa proprietà collega uno strumento urbanistico-territoriale con l'ente o l'amministrazione che ha emanato il provvedimento.</para>
    ///   <para>ctlog:iccdNormTag : TU/STU/STUE^^xsd:string</para>
    ///   <para>rdfs:label : ha ente che ha emanato il provvedimentordfs:label : has issuing agency</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasIssuingAgency">cdesc:hasIssuingAgency</a>
    /// </summary>
    let hasIssuingAgency = _prefixId.prefix "hasIssuingAgency"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa NU: DA/AUE/AUES - ICCD Normativa OA (dopo il rilascio della specifica scheda NU nel 2004 la scheda OA non è stata più utilizzata per la catalogazione di monete e medaglie): AU/EDT/EDTA</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : ha Stato emittenterdfs:label : has issuing State</para>
    ///   <para>rdfs:comment : Questa proprietà collega l'emissione della moneta alla realtà statuale emittente, coeva all'emissione della moneta. Questa proprietà, esprimendo il significato della relazione nel nome, dà una rappresentazione semplificata della relazione che lega questa entità e l'agente; la stessa relazione è rappresentata attraverso una n-ary relation, arco-core:AgentRole, che permette di collegare l'agente al ruolo che riveste nei confronti dell'entità.rdfs:comment : This property relates the coin issuance to the issuing State of that historic period. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasIssuingState">cdesc:hasIssuingState</a>
    /// </summary>
    let hasIssuingState = _prefixId.prefix "hasIssuingState"
    /// <summary>
    ///   <para>rdfs:label : has laboratory test typerdfs:label : ha tipo di analisi di laboratorio</para>
    ///   <para>rdfs:comment : Questa proprietà collega un'analisi di laboratorio con il tipo di analisi (es.: analisi metallurgica, analisi chimica, etc.).rdfs:comment : This property relates a laboratory test to its test type (i.e. chemical or metallurgical analysis).</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normative NU, RA, BNB, MA, CA: RS/ALB/ALBT^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasLaboratoryTestType">cdesc:hasLaboratoryTestType</a>
    /// </summary>
    let hasLaboratoryTestType = _prefixId.prefix "hasLaboratoryTestType"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: TU/CDG^^xsd:string</para>
    ///   <para>rdfs:comment : Questa proprietà collega un'entità, per esempio un bene culturale, alla sua condizione giuridica.rdfs:comment : This property relates an entity, for example a cultural entity, to its legal situation.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : ha condizione giuridicardfs:label : has legal situation</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasLegalSituation">cdesc:hasLegalSituation</a>
    /// </summary>
    let hasLegalSituation = _prefixId.prefix "hasLegalSituation"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà, inversa a "è membro di unità archivistica complessa", collega l'appartenenza di un bene culturale a un'unità archivistica al bene coinvolto nella relazione.rdfs:comment : This property relates the membership of a cultural entity to an archival record set. It is the inverse property of "isMemberofArchivalRecordSet".</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : ha membro di unità archivistica complessardfs:label : has member of archival record set</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa F: UB/UBF^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasMemberOfArchivalRecordSet">cdesc:hasMemberOfArchivalRecordSet</a>
    /// </summary>
    let hasMemberOfArchivalRecordSet = _prefixId.prefix "hasMemberOfArchivalRecordSet"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : UB/COL^^xsd:string</para>
    ///   <para>rdfs:label : has member of collectionrdfs:label : ha membro di collezione</para>
    ///   <para>rdfs:comment : This property relates the membership of a movable cultural entity to a collection in a time interval. It is the inverse property of "isMemberofCollection".rdfs:comment : Questa proprietà, inversa a "è membro di collezione", collega l'appartenenza di un bene culturale a una collezione in un certo intervallo di tempo al bene culturale mobile coinvolto nella relazione.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasMemberOfCollection">cdesc:hasMemberOfCollection</a>
    /// </summary>
    let hasMemberOfCollection = _prefixId.prefix "hasMemberOfCollection"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà, inversa a "è membro di serie", collega l'appartenenza di un bene fotografico a una serie editoriale al bene fotografico coinvolto nella relazione.rdfs:comment : This property relates the membership of a cultural entity (e.g. photographic heritage) to its photographic series. It is the inverse property of "isMemberPhotographicSeries".</para>
    ///   <para>rdfs:label : ha membro di serie fotograficardfs:label : has member of photographic series</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa F: PD/SFI; PD/SSI^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasMemberOfPhotographicSeries">cdesc:hasMemberOfPhotographicSeries</a>
    /// </summary>
    let hasMemberOfPhotographicSeries = _prefixId.prefix "hasMemberOfPhotographicSeries"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega l'emissione della moneta alla Zecca. Questa proprietà, esprimendo il significato della relazione nel nome, dà una rappresentazione semplificata della relazione che lega questa entità e l'agente; la stessa relazione è rappresentata attraverso una n-ary relation, arco-core:AgentRole, che permette di collegare l'agente al ruolo che riveste nei confronti dell'entità.rdfs:comment : This property relates the coin issuance to the Mint. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : has mintrdfs:label : ha zecca</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa NU: DA/ZEC - ICCD Normativa OA (dopo il rilascio della specifica scheda NU nel 2004 la scheda OA non è stata più utilizzata per la catalogazione di monete e medaglie): AU/EDT/EDTZ</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasMint">cdesc:hasMint</a>
    /// </summary>
    let hasMint = _prefixId.prefix "hasMint"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property relates the coin issuance to the minter. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.rdfs:comment : Questa proprietà collega l'emissione della moneta allo zecchiere, monetiere, maestro di zecca. Questa proprietà, esprimendo il significato della relazione nel nome, dà una rappresentazione semplificata della relazione che lega questa entità e l'agente; la stessa relazione è rappresentata attraverso una n-ary relation, arco-core:AgentRole, che permette di collegare l'agente al ruolo che riveste nei confronti dell'entità.</para>
    ///   <para>rdfs:label : ha zecchiererdfs:label : has minter</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa NU: DA/AUE/AUEZ^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasMinter">cdesc:hasMinter</a>
    /// </summary>
    let hasMinter = _prefixId.prefix "hasMinter"
    /// <summary>
    ///   <para>rdfs:label : has musical ensemblerdfs:label : ha organico musicale</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property relates an musical instrument to the musical ensamble where the instument is (or were) played. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.rdfs:comment : Questa proprietà collega uno strumento musicale al gruppo di musicisti (bande, complessi musicali, associazioni corali, ecc.) in cui lo strumento assume, o ha assunto, abitualmente un ruolo esecutivo. Questa relazione è modellata anche, con maggiore potere espressivo, tramite il pattern AgentRole, che collega lo strumento musicale a una situazione in cui un agente ha rivestito un ruolo (in questo caso, organico musicale).</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa SM 4.00: OS/OSD^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasMusicalEnsemble">cdesc:hasMusicalEnsemble</a>
    /// </summary>
    let hasMusicalEnsemble = _prefixId.prefix "hasMusicalEnsemble"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property relates a musical instrument to the person who plays (in the present or past) a certain role as the instrument's exectutor. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.rdfs:comment : Questa proprietà collega uno strumento musicale a una persona che assume - o ha assunto - un ruolo certo come esecutore dello strumento. Questa relazione è modellata anche, con maggiore potere espressivo, tramite il pattern AgentRole, che collega lo strumento musicale a una situazione in cui un agente ha rivestito un ruolo (in questo caso, chitarrista, flautista, pianista, ecc., o genericamente musicista).</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa SM 4.00: MU/MUTN^^xsd:string</para>
    ///   <para>rdfs:label : ha musicistardfs:label : has musician</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasMusician">cdesc:hasMusician</a>
    /// </summary>
    let hasMusician = _prefixId.prefix "hasMusician"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : ha tipo di indagine di rilevamentordfs:label : has observation survey type</para>
    ///   <para>rdfs:comment : Questa proprietà collega un'indagine di rilevamento al tipo di indagine di rilevamento (nel contesto/decontestualizzato).rdfs:comment : This property relates an observation survey to the type of observation survey (in the context, out of context).</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa BDI 4.00: LA/PRM^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasObservationSurveyType">cdesc:hasObservationSurveyType</a>
    /// </summary>
    let hasObservationSurveyType = _prefixId.prefix "hasObservationSurveyType"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà collega una condizione giuridica al proprietario dell'oggetto che si trova in quella condizione.rdfs:comment : This property relates a legal situation to the owner of the object that is in that legal situation.</para>
    ///   <para>rdfs:label : ha proprietariordfs:label : has owner</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: TU/CDG/CDGS^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasOwner">cdesc:hasOwner</a>
    /// </summary>
    let hasOwner = _prefixId.prefix "hasOwner"
    /// <summary>
    ///   <para>rdfs:comment : This property relates a photographic series a the cultural entity which belongs to it.rdfs:comment : Questa proprietà, inversa a "è serie in", collega il rapporto tra una serie e un bene fotografico che ne fa parte alla serie stessa.</para>
    ///   <para>rdfs:label : has photographic seriesrdfs:label : ha serie fotografica</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: PD/SFI; PD/SSI^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasPhotographicSeries">cdesc:hasPhotographicSeries</a>
    /// </summary>
    let hasPhotographicSeries = _prefixId.prefix "hasPhotographicSeries"

    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : has planning environmental relation withrdfs:label : ha relazione urbanistico-ambientale con</para>
    ///   <para>rdfs:comment : This property relates a cultural entity to another cultural entity, in an planning environmental relation.rdfs:comment : Questa proprietà collega un bene culturale a un altro bene culturale collegato, con cui è in relazione urbanistico-ambientale.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RV/RSE/RSER = 'è in relazione urbanistico - ambientale con' (versioni precedenti: 'relazione urbanistico ambientale')</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasPlanningEnvironmentalRelationWith">cdesc:hasPlanningEnvironmentalRelationWith</a>
    /// </summary>
    let hasPlanningEnvironmentalRelationWith = _prefixId.prefix "hasPlanningEnvironmentalRelationWith"

    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega un bene culturale a un altro bene culturale collegato, che ne costituisce la sede di provenienza, prima della sua attuale collocazione.rdfs:comment : This property relates a cultural entity to a connected cultural entity which constitutes its provenance location before its current position.</para>
    ///   <para>rdfs:label : ha sede di provenienzardfs:label : era contenuto inrdfs:label : has previous location</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RV/RSE/RSER = 'era contenuto in' (versioni precedenti: 'sede di provenienza')</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasPreviousLocation">cdesc:hasPreviousLocation</a>
    /// </summary>
    let hasPreviousLocation = _prefixId.prefix "hasPreviousLocation"
    /// <summary>
    ///   <para>rdfs:comment : This property relates the event of a cultural entity's acquisition to the agent which is the source of the acquisition.rdfs:comment : Questa proprietà collega un evento di acquisizione di un bene culturale al soggetto fonte dell'acquisizione.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : has previous ownerrdfs:label : ha soggetto fonte dell'acquisizione</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: TU/ACQ/ACQN^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasPreviousOwner">cdesc:hasPreviousOwner</a>
    /// </summary>
    let hasPreviousOwner = _prefixId.prefix "hasPreviousOwner"
    /// <summary>
    ///   <para>rdfs:comment : This property relates an intangible demoethnoanthropological property to its primary documentation, that is the documentation more representative of the intangible heritage.rdfs:comment : Questa proprietà collega un bene demoetnoantropologico immateriale alla sua documentazione primaria, ovvero la documentazione che restituisce il bene immateriale e ritenuta più rappresentativa.</para>
    ///   <para>rdfs:label : ha documentazione primariardfs:label : has primary documentation</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa BDI 4.00: DU, DV, DF^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasPrimaryDocumentation">cdesc:hasPrimaryDocumentation</a>
    /// </summary>
    let hasPrimaryDocumentation = _prefixId.prefix "hasPrimaryDocumentation"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa BDM 2.00: UT/UTN/UTNM - ICCD Normativa BDM 4.00: AU/AUT/AUTE</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property relates an agent to its job. For example the agent responsible of the production of a cultual entity.rdfs:comment : Questa proprietà collega un agente al suo mestiere o professione, per esempio l'utente del bene oppure il responsabile della fabbricazione di un bene con il suo mestiere o la sua professione.</para>
    ///   <para>rdfs:label : ha professionerdfs:label : has profession</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasProfession">cdesc:hasProfession</a>
    /// </summary>
    let hasProfession = _prefixId.prefix "hasProfession"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: TU/NVC/NVCA; Versioni precedenti: CD/EPR^^xsd:string</para>
    ///   <para>rdfs:label : has proponet agencyrdfs:label : ha ente proponente</para>
    ///   <para>rdfs:comment : Questa proprietà collega un'entità, che può essere direttamente il bene culturale o specificamente il provvedimento di tutela relativo al bene culturale, all'ente proponente, ovvero al soggetto che ha proposto il provvedimento, identificato per mezzo della denominazione per esteso oppure, nel caso di Enti accreditati dall'ICCD, del relativo codice assegnato dall'Istituto. La relazione tra il ruolo e l'agente che lo riveste è espressa, in maniera generica, nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe AgentRole, che permette di collegare l'agente e il suo ruolo.rdfs:comment : This property relates an entity (e.g a cultural entity or a cultual entity's protective measure) to the proposing institution. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasProponentAgency">cdesc:hasProponentAgency</a>
    /// </summary>
    let hasProponentAgency = _prefixId.prefix "hasProponentAgency"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : has protective measurerdfs:label : ha provvedimento di tutela</para>
    ///   <para>rdfs:comment : Questa proprietà collega un bene culturale a un provvedimento di tutela nazionale o internazionale che lo ha interessato.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: TU/NVC^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasProtectiveMeasure">cdesc:hasProtectiveMeasure</a>
    /// </summary>
    let hasProtectiveMeasure = _prefixId.prefix "hasProtectiveMeasure"
    /// <summary>
    ///   <para>rdfs:label : has reference cataloguerdfs:label : ha repertorio</para>
    ///   <para>rdfs:comment : This property relates a print's copy to its reference catalogue.rdfs:comment : Questa proprietà collega la copia della stampa con il suo repertorio.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa S 3: RO/COP/COPR</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasReferenceCatalogue">cdesc:hasReferenceCatalogue</a>
    /// </summary>
    let hasReferenceCatalogue = _prefixId.prefix "hasReferenceCatalogue"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : ha agente correlatordfs:label : has related agent</para>
    ///   <para>rdfs:comment : This property is used to associate an entity of any kind to an agent related to that entity in some way. It is used when it is not possible to express the relation in a more specific way.rdfs:comment : Questa proprietà collega un'entità di qualsiasi tipo a un agente che è collegato in qualche modo a quell'entità. È una relazione generica che viene usata per quei casi in cui non sia possibile definire in maniera più precisa la natura della relazione.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: AU/NMC^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasRelatedAgent">cdesc:hasRelatedAgent</a>
    /// </summary>
    let hasRelatedAgent = _prefixId.prefix "hasRelatedAgent"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà collega un bene culturale a un'altra opera collegata (es.: copia, fase preparatoria, etc.), che può essere essa stessa un bene culturale.rdfs:comment : This property relates a cultural property to a related work (e.g. copy, preparatory work).</para>
    ///   <para>rdfs:label : ha opera collegatardfs:label : has related work</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasRelatedWork">cdesc:hasRelatedWork</a>
    /// </summary>
    let hasRelatedWork = _prefixId.prefix "hasRelatedWork"
    /// <summary>
    ///   <para>rdfs:label : ha rapporto con opera collegatardfs:label : has related work situation</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà collega un bene culturale alla relazione tra il bene stesso e un'altra opera che ne costituisce una fase preparatoria o che ne rappresenta la fase finale, e in riferimento alla quale il bene culturale si trova in un determinato stadio.rdfs:comment : This property relates a cultural property to a situation in which this cultural property is related to another work, that could even be another cultural property, as its preparatory or final phase.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasRelatedWorkSituation">cdesc:hasRelatedWorkSituation</a>
    /// </summary>
    let hasRelatedWorkSituation = _prefixId.prefix "hasRelatedWorkSituation"
    /// <summary>
    ///   <para>rdfs:label : ha affidabilitàrdfs:label : has reliability</para>
    ///   <para>rdfs:comment : Questa proprietà collega una fotointerpretazione o fotorestituzione al livello di affidabilità delle informazioni rilevate nell'indagine.rdfs:comment : This property relates a photo interpretation rendering survey to the reliability of the information collected during the survey.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RE/FOI/FOIO^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasReliability">cdesc:hasReliability</a>
    /// </summary>
    let hasReliability = _prefixId.prefix "hasReliability"
    /// <summary>
    ///   <para>rdfs:comment : This property relates a publication to the print reproduction which is or was part of it.rdfs:comment : Questa proprietà collega la pubblicazione con la riproduzione della stampa che ne è, o è stata, parte integrante.</para>
    ///   <para>rdfs:label : ha riproduzionerdfs:label : has reproduction</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa S 3: RO/ADL</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasReproduction">cdesc:hasReproduction</a>
    /// </summary>
    let hasReproduction = _prefixId.prefix "hasReproduction"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa S 3: RO/ADL/ADLP</para>
    ///   <para>rdfs:label : has reproduction positionrdfs:label : ha posizione della riproduzione</para>
    ///   <para>rdfs:comment : Questa proprietà collega la riproduzione di una stampa all'interno di una pubblicazione con la posizione fisica nella pubblicazione stessa (es.: frontespizio, copertina, colophon, etc.).rdfs:comment : This property relates the print reproduction in a publication to the position in the publication.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasReproductionPosition">cdesc:hasReproductionPosition</a>
    /// </summary>
    let hasReproductionPosition = _prefixId.prefix "hasReproductionPosition"
    /// <summary>
    ///   <para>rdfs:comment : This property relates a culural entity to the research, which is the context where the enity's cataloguing record has been produced.rdfs:comment : Questa proprietà collega un bene culturale alla ricerca nell'ambito della quale è stata redatta la scheda.</para>
    ///   <para>rdfs:label : has researchrdfs:label : ha ricerca</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa SM e BDM 4.00: DR/DRT^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasResearch">cdesc:hasResearch</a>
    /// </summary>
    let hasResearch = _prefixId.prefix "hasResearch"
    /// <summary>
    ///   <para>rdfs:comment : This property relates a research to the research's scientific responsible. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.rdfs:comment : Questa proprietà collega una ricerca al responsabile scientifico della ricerca. La relazione tra il ruolo e l'agente che lo riveste è espressa nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe AgentRole, che permette di collegare l'agente e il suo ruolo.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa SM e BDM 4.00: DR/DRR^^xsd:string</para>
    ///   <para>rdfs:label : ha responsabile scientifico della ricercardfs:label : has research scientific director</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasResearchScientificDirector">cdesc:hasResearchScientificDirector</a>
    /// </summary>
    let hasResearchScientificDirector = _prefixId.prefix "hasResearchScientificDirector"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:isDefinedBy : This property relates a photographic heritage to the the attribution of a responsibility to an agent, relating to the activities of production and dissemination of photographic heritage (e.g.: committent, editor, printer, dedicatee, etc.).</para>
    ///   <para>rdfs:comment : Questa proprietà collega un bene fotografico (fotografia o fondo fotografico) all'individuazione di una responsabilità attribuibile a un agente relativamente ai processi di produzione e di divulgazione che caratterizzano specificamente i beni fotografici, quindi alle diverse personalità responsabili, a vario titolo, del ciclo produttivo del bene in esame, oltre che della sua circolazione, divulgazione, commercializzazione e promozione (committenti, stampatori, ritoccatori, coloritori, editori, distributori, sponsor, curatori e responsabili di edizioni e di serie, dedicanti e dedicatari, responsabili di collezioni e di collazioni, ecc.).rdfs:comment : This property relates a photographic cultural entity (photography or photographic fond) to the responsibility attribution of an agent. The agent is in charge of the production or disclosure process which characterises photographic heritage (i.e. printers, editors, distributors, sposors, collection responsibles etc.)</para>
    ///   <para>rdfs:label : has responsibilityrdfs:label : ha responsabilità</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa F: PD/PDF^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasResponsibility">cdesc:hasResponsibility</a>
    /// </summary>
    let hasResponsibility = _prefixId.prefix "hasResponsibility"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega una responsabilità individuata relativamente ai processi di produzione e di divulgazione che caratterizzano specificamente i beni fotografici al tipo di responsabilità (es.: stampatori, ritoccatori, coloritori, ecc.).rdfs:comment : This property relates a resposibility relative to some production or disclosure process which characterise photographic artefacts, to its responsibility type (i.e. printers, retouchers).</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normative F e FF: PD/PDF/PDFR^^xsd:string</para>
    ///   <para>rdfs:label : ha tipo di responsabilitàrdfs:label : has responsibility type</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasResponsibilityType">cdesc:hasResponsibilityType</a>
    /// </summary>
    let hasResponsibilityType = _prefixId.prefix "hasResponsibilityType"
    /// <summary>
    ///   <para>rdfs:label : ha responsabile dell'immissione in patrimoniordfs:label : has responsible for insertion</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: UB/INP/INPE^^xsd:string</para>
    ///   <para>rdfs:comment : Questa proprietà, rappresentazione semplificata della relazione n-ary Agent Role, che rappresenta una situazione in cui un agente riveste un ruolo, collega un inventario patrimoniale al responsabile dell'inventariazione patrimoniale del bene.rdfs:comment : This property relates a current inventory to the agent responsible for the cultural entity's inventory. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasResponsibleForInsertion">cdesc:hasResponsibleForInsertion</a>
    /// </summary>
    let hasResponsibleForInsertion = _prefixId.prefix "hasResponsibleForInsertion"
    /// <summary>
    ///   <para>rdfs:comment : This property relates a current inventory to the patrimonial category attributed to the cultural property based on the SEC classification.rdfs:comment : Questa proprietà collega un inventario patrimoniale alla categoria SEC attribuita al bene.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : ha categoria SECrdfs:label : has SEC category</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasSECCategory">cdesc:hasSECCategory</a>
    /// </summary>
    let hasSECCategory = _prefixId.prefix "hasSECCategory"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This property relates the current inventory to the patrimonial code of a cultural property, referring to the SEC classification 1995.rdfs:comment : Questa proprietà collega un inventario patrimoniale al codice SEC (modello 15) attribuito al bene.</para>
    ///   <para>rdfs:label : has SEC identifierrdfs:label : ha codice SEC</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: UB/INP/INPS^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasSECIdentifier">cdesc:hasSECIdentifier</a>
    /// </summary>
    let hasSECIdentifier = _prefixId.prefix "hasSECIdentifier"
    /// <summary>
    ///   <para>rdfs:comment : This property relates the graphic or cartographic documentation to its representation scale.rdfs:comment : Questa proprietà collega la documentazione grafica e cartografica alla sua scala di rappresentazione.</para>
    ///   <para>rdfs:label : ha scalardfs:label : has scale</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: DO/DRA/DRAS^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasScale">cdesc:hasScale</a>
    /// </summary>
    let hasScale = _prefixId.prefix "hasScale"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normative VeAC e AT 3.01: DO/BSE/BSER^^xsd:string</para>
    ///   <para>rdfs:label : has secondary authorrdfs:label : ha autore secondario</para>
    ///   <para>rdfs:comment : Questa proprietà collega un'entità al suo autore secondario, come ad esempio l'autore di un contributo o una parte di una pubblicazione.rdfs:comment : This property relates an entity to its secondary authors. For example an author of a publication's contribution or section.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasSecondaryAuthor">cdesc:hasSecondaryAuthor</a>
    /// </summary>
    let hasSecondaryAuthor = _prefixId.prefix "hasSecondaryAuthor"
    /// <summary>
    ///   <para>rdfs:label : ha sesso stimatordfs:label : has sex interpretation</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa AT: DA/STS^^xsd:string</para>
    ///   <para>rdfs:comment : Questa proprietà collega un reperto antropologico alla stima del sesso.rdfs:comment : This property relates an antropologic artifact to its sex estimate.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasSexInterpretation">cdesc:hasSexInterpretation</a>
    /// </summary>
    let hasSexInterpretation = _prefixId.prefix "hasSexInterpretation"
    /// <summary>
    ///   <para>rdfs:label : has speciesrdfs:label : ha specie</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà collega una tassonomia biologica alla specie, che è uno dei concetti della tassonomia.rdfs:comment : This property relates a biological taxon to the subspecies, that is one of the concept of the taxon.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa AT: OG/OGS/OGSN^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasSpecies">cdesc:hasSpecies</a>
    /// </summary>
    let hasSpecies = _prefixId.prefix "hasSpecies"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : has stratigraphic unitrdfs:label : ha unità stratigrafica</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RE/DSC/DSCU^^xsd:string</para>
    ///   <para>rdfs:comment : Questa proprietà collega uno scavo archeologico all'unità stratigrafica dalla quale proviene il bene rinvenuto nello scavo.rdfs:comment : This property relates an archeological excavation to the stratigraphic unit from which a cultural property has been found.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasStratigraphicUnit">cdesc:hasStratigraphicUnit</a>
    /// </summary>
    let hasStratigraphicUnit = _prefixId.prefix "hasStratigraphicUnit"
    /// <summary>
    ///   <para>rdfs:label : has subjectrdfs:label : ha soggetto</para>
    ///   <para>rdfs:comment : Questa proprietà collega un bene culturale, un'opera correlata a un bene culturale in quanto sua fase preparatoria o finale, o un apparato iconografico-decorativo di un bene culturale al suo soggetto o motivo ornamentale.rdfs:comment : This property relates a cultural property or a preparatory or final work of a cultural property to ist subject or ornamental motif.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: DA/AID/AIDI - Normativa F: SG/SGT/SGTI - Altre normative di versioni precedenti alla 4.00: OG/SGT/SGTI - ICCD Normative F, RA, SMO, PST, S, OAC, OA, MI, D, NU: RO/ROF/ROFS^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasSubject">cdesc:hasSubject</a>
    /// </summary>
    let hasSubject = _prefixId.prefix "hasSubject"
    /// <summary>
    ///   <para>rdfs:label : ha sottospecierdfs:label : has subspecies</para>
    ///   <para>rdfs:comment : Questa proprietà collega una tassonomia biologica alla sottospecie, che è uno dei concetti della tassonomia.rdfs:comment : This property relates a biological taxon to the subspecies, that is one of the concept of the taxon.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa AT: OG/OGS/OGST^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasSubspecies">cdesc:hasSubspecies</a>
    /// </summary>
    let hasSubspecies = _prefixId.prefix "hasSubspecies"
    /// <summary>
    ///   <para>rdfs:label : has surveyrdfs:label : ha indagine</para>
    ///   <para>rdfs:comment : This property relates a cultural entity's acquisition to its acquisition type.rdfs:comment : Questa proprietà collega un bene culturale a un'indagine effettuata sul bene stesso, per la sua individuazione, per il suo studio e per l'approfondimento delle sue caratteristiche tecniche.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RE; CM/ISP - ICCD Normative NU, RA, BNB, MA, CA: RS/ALB - ICCD Normativa AT 3.00: IN/INI - Normativa BDM e SM 4.00: DR^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasSurvey">cdesc:hasSurvey</a>
    /// </summary>
    let hasSurvey = _prefixId.prefix "hasSurvey"
    /// <summary>
    ///   <para>rdfs:label : has survey imagerdfs:label : ha immagine di indagine</para>
    ///   <para>rdfs:comment : Questa proprietà collega una fotointerpretazione o fotorestituzione all'immagine presa in esame nel corso dell'indagine.rdfs:comment : This property relates a photo interpretation rendering to the survey image.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RE/FOI/FOIT + FOID^^xsd:string</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasSurveyImage">cdesc:hasSurveyImage</a>
    /// </summary>
    let hasSurveyImage = _prefixId.prefix "hasSurveyImage"
    /// <summary>
    ///   <para>rdfs:comment : This property relates a survey image to its type (i.e. aerial photograph, Satellite photograph).rdfs:comment : Questa proprietà collega una immagine di indagine al suo tipo (fotografia aerea o fotografia satellitare).</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RE/FOI/FOIT^^xsd:string</para>
    ///   <para>rdfs:label : ha tipo di immagine di indaginerdfs:label : has survey image type</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasSurveyImageType">cdesc:hasSurveyImageType</a>
    /// </summary>
    let hasSurveyImageType = _prefixId.prefix "hasSurveyImageType"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà collega un'indagine al metodo adottato nel corso dell'indagine.rdfs:comment : This property relates a survey to the method adopted in the survey.</para>
    ///   <para>rdfs:label : has survey methodrdfs:label : ha metodo di indagine</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RE/RCG/RCGM; RE/DSC/DSCM - ICCD Normativa AT: PT/PTC/PTCM^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasSurveyMethod">cdesc:hasSurveyMethod</a>
    /// </summary>
    let hasSurveyMethod = _prefixId.prefix "hasSurveyMethod"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà collega uno scavo archeologico, una ricognizione archeologica, un'indagine archeometrica e diagnostica o una fotointerpretazione e fotorestituzione al motivo principale che li ha determinati.rdfs:comment : This property relates an archeological, archaeometric or diagnostic survey or a photo interpretation rendering to the the main motivation that led to it.</para>
    ///   <para>rdfs:label : has survey motivationrdfs:label : ha motivo di indagine</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasSurveyMotivation">cdesc:hasSurveyMotivation</a>
    /// </summary>
    let hasSurveyMotivation = _prefixId.prefix "hasSurveyMotivation"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega un'indagine di rilevamento di un bene demo-etno-antropologico al fotografo professionista (diverso dal rilevatore) che ha effettuato la ripresa. La relazione tra il ruolo e l'agente che lo riveste è espressa nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe AgentRole, che permette di collegare l'agente e il suo ruolo.rdfs:comment : This property relates an observation survey of a demo-etno-antropologic entity to the professional photographer who took the shot. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.</para>
    ///   <para>rdfs:label : ha fotografo dell'indaginerdfs:label : has survey photographer</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa BDI 3.00: DR/DRG^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasSurveyPhotographer">cdesc:hasSurveyPhotographer</a>
    /// </summary>
    let hasSurveyPhotographer = _prefixId.prefix "hasSurveyPhotographer"
    /// <summary>
    ///   <para>rdfs:comment : This property relates a survey to its scientific director.rdfs:comment : Questa proprietà collega un'indagine al suo responsabile scientifico.</para>
    ///   <para>rdfs:label : ha responsabile scientifico dell'indaginerdfs:label : has survey scientific director</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RE/RCG/RCGA; RE/DSC/DSCA; RE/FOI/FOIS^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasSurveyScientificDirector">cdesc:hasSurveyScientificDirector</a>
    /// </summary>
    let hasSurveyScientificDirector = _prefixId.prefix "hasSurveyScientificDirector"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa BDI 3.00: DR/DRF^^xsd:string</para>
    ///   <para>rdfs:label : ha fonico dell'indaginerdfs:label : has survey sound engineer</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà collega un'indagine di rilevamento di un bene demo-etno-antropologico al fonico professionista (diverso dal rilevatore) che ha effettuato la registrazione sonora. La relazione tra il ruolo e l'agente che lo riveste è espressa nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe AgentRole, che permette di collegare l'agente e il suo ruolo.rdfs:comment : This property relates an observation survey of a demo-etno-antropologic entity to the sound engineer who recorded it. In the ontology this relationship is modelled also by the class AgentRole which allows more expressiveness.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasSurveySoundEngineer">cdesc:hasSurveySoundEngineer</a>
    /// </summary>
    let hasSurveySoundEngineer = _prefixId.prefix "hasSurveySoundEngineer"
    /// <summary>
    ///   <para>rdfs:label : has titlerdfs:label : ha titolo</para>
    ///   <para>rdfs:comment : Questa proprietà collega un oggetto al suo titolo. Nel caso del dominio dei beni culturali, può collegare un bene culturale o un'opera collegata al bene culturale perché sua fase finale o preparatoria (proprio, attribuito, parallelo, alternativo), oppure un'edizione al suo titolo (principale o secondario), oppure una serie fotografica al suo titolo, etc.rdfs:comment : This property relates an object to its title.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : OG/SGT/SGTP; SG/SGL/SGLT; SG/SGL/SGLL; OG/SGT/SGTR; DA/AID/AIDN; SG/SGL/SGLA; DA/AID/AIDT; OG/SGT/SGTT; RO/ROF/ROFT; DO/BSE/BSET; DO/BSE/BSEC.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasTitle">cdesc:hasTitle</a>
    /// </summary>
    let hasTitle = _prefixId.prefix "hasTitle"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property relates a cultural entity's title to its title type.rdfs:comment : Questa proprietà collega un titolo di un bene culturale al tipo di titolo.</para>
    ///   <para>ctlog:iccdNormTag : OG/SGT/SGTP; SG/SGL/SGLT; SG/SGL/SGLL; OG/SGT/SGTR; DA/AID/AIDN; SG/SGL/SGLA; DA/AID/AIDT; OG/SGT/SGTT^^xsd:string</para>
    ///   <para>rdfs:label : has title typerdfs:label : ha tipo di titolo</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasTitleType">cdesc:hasTitleType</a>
    /// </summary>
    let hasTitleType = _prefixId.prefix "hasTitleType"
    /// <summary>
    ///   <para>rdfs:label : has tombrdfs:label : ha deposizione funeraria</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property relates an archaeological excavation to the tomb detected during the survey.rdfs:comment : Questa proprietà collega uno scavo archeologico alla deposizione funeraria individuata durante l'indagine.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RE/DSC/DSCS^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasTomb">cdesc:hasTomb</a>
    /// </summary>
    let hasTomb = _prefixId.prefix "hasTomb"
    /// <summary>
    ///   <para>rdfs:comment : This class relates a cultural property to the related urban planning instrument.rdfs:comment : Questa proprietà collega un bene culturale a uno strumento urbanistico-territoriale, ovvero a un piano regolatore generale e particolareggiato o a un piano paesaggistico che interessa il bene stesso.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : ha strumento urbanistico-territorialerdfs:label : has urban planning instrument</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: TU/STU^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasUrbanPlanningInstrument">cdesc:hasUrbanPlanningInstrument</a>
    /// </summary>
    let hasUrbanPlanningInstrument = _prefixId.prefix "hasUrbanPlanningInstrument"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : ha usordfs:label : has use</para>
    ///   <para>rdfs:comment : Questa proprietà collega il bene culturale con il suo uso.rdfs:comment : This property relates a cultural entity to its use.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: UT</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasUse">cdesc:hasUse</a>
    /// </summary>
    let hasUse = _prefixId.prefix "hasUse"
    /// <summary>
    ///   <para>rdfs:label : has use functionrdfs:label : ha funzione d'uso</para>
    ///   <para>rdfs:comment : Questa proprietà collega un'entità alla sua funzione d'uso.rdfs:comment : This property relates an entity to its use function.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: UT/UTU/UTUF; LC/LDC/LDCF; LA/PRC/PRCF - BDM 2.00:UT/UTF - PST 3.01: DA/UTF^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasUseFunction">cdesc:hasUseFunction</a>
    /// </summary>
    let hasUseFunction = _prefixId.prefix "hasUseFunction"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : has use typerdfs:label : ha tipo d'uso</para>
    ///   <para>rdfs:comment : Questa proprietà collega l'uso del bene con il suo tipo (attuale, precedente, storico).rdfs:comment : This property relates a cultural entity's use to its use type.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: UT/UTU/UTUT^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasUseType">cdesc:hasUseType</a>
    /// </summary>
    let hasUseType = _prefixId.prefix "hasUseType"
    /// <summary>
    ///   <para>rdfs:label : has use type specificationrdfs:label : ha specifiche del tipo d'uso</para>
    ///   <para>rdfs:comment : This property relates the use of a cultural property to the specification of the type of use.rdfs:comment : Questa proprietà collega l'uso del bene con le specifiche relative al tipo di utilizzo.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: UT/UTUS</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasUseTypeSpecification">cdesc:hasUseTypeSpecification</a>
    /// </summary>
    let hasUseTypeSpecification = _prefixId.prefix "hasUseTypeSpecification"
    /// <summary>
    ///   <para>rdfs:label : ha utenterdfs:label : has user</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: UT/UTU/UTUN; Normativa VeAC: AU/FRU/FRUF^^xsd:string</para>
    ///   <para>rdfs:comment : This property relates an entity to the user, intended as the agent who employed the entity.rdfs:comment : Questa proprietà collega un'entità a un utente, inteso come agente che ha fatto uso di quell'entità. Per esempio, può collegare un'occasione in cui un vestimento antico o contemporaneo è stato indossato da una persona al fruitore stesso, oppure un particolare uso di un bene culturale al tipo di utente coinvolto in quell'uso.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasUser">cdesc:hasUser</a>
    /// </summary>
    let hasUser = _prefixId.prefix "hasUser"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This property relates the user of a cultural property to its social category.rdfs:comment : Questa proprietà collega l'utente di un bene culturale con la sua categoria sociale.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normative BDM 2.00: UT/UTN/UTNC</para>
    ///   <para>rdfs:label : ha categoria sociale dell'utenterdfs:label : has user social category</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/hasUserSocialCategory">cdesc:hasUserSocialCategory</a>
    /// </summary>
    let hasUserSocialCategory = _prefixId.prefix "hasUserSocialCategory"

    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà rappresenta informazioni di natura storico biografica relative a un agente.rdfs:comment : This property represents historical biographical information about an agent.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/historicalBiographicalInformation">cdesc:historicalBiographicalInformation</a>
    /// </summary>
    let historicalBiographicalInformation = _prefixId.prefix "historicalBiographicalInformation"

    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DA/NSC^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : historical informationrdfs:label : informazioni storiche</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/historicalInformation">cdesc:historicalInformation</a>
    /// </summary>
    let historicalInformation = _prefixId.prefix "historicalInformation"
    /// <summary>
    ///   <para>rdfs:label : Iconclass Coderdfs:label : Codifica Iconclass</para>
    ///   <para>rdfs:comment : This property represents the Iconclass code, for describing the subject or ornamental motif represented by the cultural property.rdfs:comment : Questa proprietà rappresenta la codifica iconclass che permette di descrivere, mediante un codice alfanumerico, il soggetto o il motivo decorativo rappresentato su un bene culturale.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/iconclassCode">cdesc:iconclassCode</a>
    /// </summary>
    let iconclassCode = _prefixId.prefix "iconclassCode"
    /// <summary>
    ///   <para>rdfs:label : informazioni raccolte sul luogordfs:label : information gathered on site</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta le informazioni raccolte sul luogo dove si trova il bene o sul luogo dove il bene è stato rilevato.rdfs:comment : This property represents information collected on the place where the cultural entity is located or on the place where it was detected.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DA/NRL^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/informationGatheredOnSite">cdesc:informationGatheredOnSite</a>
    /// </summary>
    let informationGatheredOnSite = _prefixId.prefix "informationGatheredOnSite"
    /// <summary>
    ///   <para>rdfs:comment : This property represents the inventory identifier attributed by a juridical container to a cultural property.rdfs:comment : Questa proprietà rappresenta il codice di inventario nella forma numerica o alfanumerica attribuita dalla struttura conservativa (soprintendenza, museo, galleria, deposito, ecc.) che ha effettuato l'inventariazione del bene.</para>
    ///   <para>rdfs:label : inventory identifierrdfs:label : codice d'inventario</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : UB/INV/INVN^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/inventoryIdentifier">cdesc:inventoryIdentifier</a>
    /// </summary>
    let inventoryIdentifier = _prefixId.prefix "inventoryIdentifier"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property represents the location of the inventory about a cultural property.rdfs:comment : Questa proprietà rappresenta la collocazione dell'inventario, cioè il luogo in cui è attualmente conservato l’inventario.</para>
    ///   <para>ctlog:iccdNormTag : UB/INV/INVC^^xsd:string</para>
    ///   <para>rdfs:label : inventory locationrdfs:label : collocazione dell'inventario</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/inventoryLocation">cdesc:inventoryLocation</a>
    /// </summary>
    let inventoryLocation = _prefixId.prefix "inventoryLocation"
    /// <summary>
    ///   <para>rdfs:label : involvesrdfs:label : coinvolge</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa è la proprietà inversa di 'is involved in', che collega un bene culturale a un altro bene culturale collegato, di tipo immateriale, in cui è coinvolto.rdfs:comment : This is the inverse property of 'is involved in', which relates a cultural entity to another involved cultural entity (e.g. immaterial).</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/involves">cdesc:involves</a>
    /// </summary>
    let involves = _prefixId.prefix "involves"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normative RA, SMO, PST, S, OAC, OA, MI, D, NU, CA, MA, F: RO^^xsd:string</para>
    ///   <para>rdfs:comment : This property relates the situation in which a cultural property is related to another work with the related work itself (e.g.: a preparatory work, a prototype, a copy, a reuse, etc.).rdfs:comment : Questa proprietà collega il rapporto tra un bene culturale e un'opera collegata all'opera collegata stessa (es.: un lavoro preparatorio, un prototipo, una copia, un reimpiego di tutto il bene o di una sua parte, ecc.).</para>
    ///   <para>rdfs:label : involves related workrdfs:label : coinvolge opera collegata</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/involvesRelatedWork">cdesc:involvesRelatedWork</a>
    /// </summary>
    let involvesRelatedWork = _prefixId.prefix "involvesRelatedWork"
    /// <summary>
    ///   <para>rdfs:comment : This property relates an acquisition event to the cultural entity involved in the acquisition.rdfs:comment : Questa proprietà collega un evento di acquisizione al bene culturale coinvolto nell'acquisizione.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : è acquisizione dirdfs:label : is acquisition of</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: TU/ACQ^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isAcquisitionOf">cdesc:isAcquisitionOf</a>
    /// </summary>
    let isAcquisitionOf = _prefixId.prefix "isAcquisitionOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property relates a cultural entity's acquisition type (i.e. donation, seizure) to its acquisition.rdfs:comment : Questa proprietà collega il tipo di acquisizione (es.: donazione, alienazione, confisca) all'acquisizione di un bene culturale.</para>
    ///   <para>rdfs:label : is acquisition type ofrdfs:label : è tipo di acqusizione di</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isAcquisitionTypeOf">cdesc:isAcquisitionTypeOf</a>
    /// </summary>
    let isAcquisitionTypeOf = _prefixId.prefix "isAcquisitionTypeOf"
    /// <summary>
    ///   <para>rdfs:label : is activity operator ofrdfs:label : è operatore dell'attività</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa è la proprietà inversa di "ha operatore dell'attività".rdfs:comment : This is the inverse property of "has activity operator".</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isActivityOperatorOf">cdesc:isActivityOperatorOf</a>
    /// </summary>
    let isActivityOperatorOf = _prefixId.prefix "isActivityOperatorOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This is the inverse property of "has activity responsible".rdfs:comment : Questa è la proprietà inversa di "ha responsabile dell'attività".</para>
    ///   <para>rdfs:label : is activity responsible ofrdfs:label : è responsabile dell'attività</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isActivityResponsibleOf">cdesc:isActivityResponsibleOf</a>
    /// </summary>
    let isActivityResponsibleOf = _prefixId.prefix "isActivityResponsibleOf"
    /// <summary>
    ///   <para>rdfs:comment : Questa è la proprietà inversa a "ha sponsor dell'attività".rdfs:comment : This is the inverse property of "has activity sponsor".</para>
    ///   <para>rdfs:label : è responsabile dell'attivitàrdfs:label : is activity responsible of</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isActivitySponsorOf">cdesc:isActivitySponsorOf</a>
    /// </summary>
    let isActivitySponsorOf = _prefixId.prefix "isActivitySponsorOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : is age of death interpretation ofrdfs:label : è età della morte stimata di</para>
    ///   <para>rdfs:comment : This property relates the age of death interpretation of an antropologic artifact to the its antropologic artifact.</para>
    ///   <para>rdfs:isDefinedBy : Questa proprietà collega la stima della morte di un reperto antropologico al suo reperto archeologico.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isAgeOfDeathInterpretationOf">cdesc:isAgeOfDeathInterpretationOf</a>
    /// </summary>
    let isAgeOfDeathInterpretationOf = _prefixId.prefix "isAgeOfDeathInterpretationOf"
    /// <summary>
    ///   <para>rdfs:label : è agente correlato ardfs:label : is agent related to</para>
    ///   <para>rdfs:comment : This property is used to associate an agent related in some way to an entity of any kind to that entity. It is used when it is not possible to express the relation in a more specific way.rdfs:comment : Questa proprietà collega un agente che è collegato in qualche modo a un'entità di qualsiasi tipo a quell'entità. È una relazione generica che viene usata per quei casi in cui non sia possibile definire in maniera più precisa la natura della relazione.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isAgentRelatedTo">cdesc:isAgentRelatedTo</a>
    /// </summary>
    let isAgentRelatedTo = _prefixId.prefix "isAgentRelatedTo"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa è la proprietà inversa a "ha agente con responsabilità".rdfs:comment : This is the inverse property of "has agent with responsibility".</para>
    ///   <para>rdfs:label : is agent with responsibility inrdfs:label : è agente con responsabilità in</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isAgentWithResponsibilityIn">cdesc:isAgentWithResponsibilityIn</a>
    /// </summary>
    let isAgentWithResponsibilityIn = _prefixId.prefix "isAgentWithResponsibilityIn"
    /// <summary>
    ///   <para>rdfs:label : è datazione alternativa dirdfs:label : is alternative dating type</para>
    ///   <para>rdfs:comment : This property relates the type of an alternative dating to the related dating.rdfs:comment : Questa proprietà collega la tipologia di datazione alternativa con la relativa datazione.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isAlternativeDatingTypeOf">cdesc:isAlternativeDatingTypeOf</a>
    /// </summary>
    let isAlternativeDatingTypeOf = _prefixId.prefix "isAlternativeDatingTypeOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : è anomalia dirdfs:label : is anomaly of</para>
    ///   <para>rdfs:comment : Questa proprietà collega un'anomalia rilevata nel corso dell'indagine tramite fotointerpretazione o fotorestituzione alla relativa indagine.rdfs:comment : This property relates an anomaly revealed by a photo interepretation rendering to the related survey.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isAnomalyOf">cdesc:isAnomalyOf</a>
    /// </summary>
    let isAnomalyOf = _prefixId.prefix "isAnomalyOf"
    /// <summary>
    ///   <para>rdfs:comment : This property relates the origin of the anomaly (e.g. natural, unsure) to an anomaly detected during a photo interpretation or rendering survey.rdfs:comment : Questa proprietà collega l'origine dell'anomalia (naturale, antropica, incerta) all'anomalia rilevata durante una fotointerpretazione o fotorestituzione.</para>
    ///   <para>rdfs:label : is anomaly origin ofrdfs:label : è origine dell'anomalia di</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isAnomalyOriginOf">cdesc:isAnomalyOriginOf</a>
    /// </summary>
    let isAnomalyOriginOf = _prefixId.prefix "isAnomalyOriginOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : è tipo di anomalia dirdfs:label : is anomaly type of</para>
    ///   <para>rdfs:comment : Questa proprietà collega il tipo di anomalia (puntuale, lineare, areale) a un'anomalia rilevata nel corso di una fotointerpretazione o fotorestituzione.rdfs:comment : This property relates the anomaly type (line, point, poligony anomaly) to an anomaly revealed by a photo interpretation rendering.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isAnomalyTypeOf">cdesc:isAnomalyTypeOf</a>
    /// </summary>
    let isAnomalyTypeOf = _prefixId.prefix "isAnomalyTypeOf"

    /// <summary>
    ///   <para>rdfs:comment : This property relates the type of a survey to the related survey on an archaeological property.rdfs:comment : Questa proprietà collega il tipo di indagine alla relativa indagine su un bene archeologico.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : is archaeological property survey type ofrdfs:label : è tipo di indagine su bene archeologico</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isArchaeologicalPropertySurveyTypeOf">cdesc:isArchaeologicalPropertySurveyTypeOf</a>
    /// </summary>
    let isArchaeologicalPropertySurveyTypeOf = _prefixId.prefix "isArchaeologicalPropertySurveyTypeOf"

    /// <summary>
    ///   <para>rdfs:label : è tipo di indagine archeometrica e diagnostica dirdfs:label : is archaeometric diagnostic survey type of</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This property relates the type of an arecheometric diagnostic survey (i.e. thermal imaging, coring) to the survey itself .rdfs:comment : Questa proprietà collega il tipo d'indagine archeometrica e diagnostica (es.: analisi della malta, carotaggio, termografia, etc.) alla relativa indagine.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isArchaeometricDiagnosticSurveyTypeOf">cdesc:isArchaeometricDiagnosticSurveyTypeOf</a>
    /// </summary>
    let isArchaeometricDiagnosticSurveyTypeOf = _prefixId.prefix "isArchaeometricDiagnosticSurveyTypeOf"

    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : è unità archivistica complessa inrdfs:label : is archival record set in</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa F: UB/UBF^^xsd:string</para>
    ///   <para>rdfs:comment : Questa proprietà, inversa a "ha unità archivistica complessa", collega una unità archivistica complessa al rapporto tra l'unità stessa e un bene culturale che ne fa parte.rdfs:comment : This property relates an archival record set to the relationship (membership) between the set itself and a cultural property that is member of it.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isArchivalRecordSetIn">cdesc:isArchivalRecordSetIn</a>
    /// </summary>
    let isArchivalRecordSetIn = _prefixId.prefix "isArchivalRecordSetIn"
    /// <summary>
    ///   <para>rdfs:label : è archiviato inrdfs:label : is archived in</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà collega l'archivio e/o istituzione conservativa con la relativa documentazione costituita da fonti e documenti.rdfs:comment : This property relates the archive or conservative institution to the documentation made of sources and documents.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isArchivedIn">cdesc:isArchivedIn</a>
    /// </summary>
    let isArchivedIn = _prefixId.prefix "isArchivedIn"
    /// <summary>
    ///   <para>rdfs:label : is attributed author inrdfs:label : è autore attribuito in</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa è la proprietà inversa a "ha autore attribuito".rdfs:comment : This is the inverse property of "has attributed author".</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isAttributedAuthorIn">cdesc:isAttributedAuthorIn</a>
    /// </summary>
    let isAttributedAuthorIn = _prefixId.prefix "isAttributedAuthorIn"
    /// <summary>
    ///   <para>rdfs:label : è autore dirdfs:label : is author of</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà collega un agent a una entità di qualsiasi tipo (documentazione, bene culturale, etc.) di cui quell'agente è autore.rdfs:comment : This property relates an agent to an entity the agent is author of.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isAuthorOf">cdesc:isAuthorOf</a>
    /// </summary>
    let isAuthorOf = _prefixId.prefix "isAuthorOf"

    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega l'ente schedatore dell'authority file a un'entità descritta in una scheda di Authority File.rdfs:comment : This property relates the file's cataloguing institution to an entity described in a authority file.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : is authority file cataloguing agency ofrdfs:label : è ente schedatore dell'authority file di</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isAuthorityFileCataloguingAgencyOf">cdesc:isAuthorityFileCataloguingAgencyOf</a>
    /// </summary>
    let isAuthorityFileCataloguingAgencyOf = _prefixId.prefix "isAuthorityFileCataloguingAgencyOf"

    /// <summary>
    ///   <para>rdfs:label : is authorship attribution ofrdfs:label : è attribuzione di autore/responsabilità di</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: AU/AUT; AU/ATB; AU/AAT^^xsd:string</para>
    ///   <para>rdfs:comment : Property that links an authorship attribution referred to a cultural entity to that cultural entity.rdfs:comment : Proprietà che lega un'attribuzione di autore o di responsabilità relativa a un'entità culturale all'entità culturale stessa.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isAuthorshipAttributionOf">cdesc:isAuthorshipAttributionOf</a>
    /// </summary>
    let isAuthorshipAttributionOf = _prefixId.prefix "isAuthorshipAttributionOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà collega una bibliografia all'entità alla quale si riferisce.rdfs:comment : This property relates a bibliography to the entity which is referred to.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DO/BIB; RE/RCG/RCGS^^xsd:string</para>
    ///   <para>rdfs:label : è bibliografia dirdfs:label : is bibliography of</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isBibliographyOf">cdesc:isBibliographyOf</a>
    /// </summary>
    let isBibliographyOf = _prefixId.prefix "isBibliographyOf"
    /// <summary>
    ///   <para>rdfs:label : è tipo di bibliografia dirdfs:label : is bibliography type of</para>
    ///   <para>rdfs:comment : Questa proprietà collega il tipo di riferimento bibliografico alla bibliografia.rdfs:comment : This property relates the bibliography type to its bibliography.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isBibliographyTypeOf">cdesc:isBibliographyTypeOf</a>
    /// </summary>
    let isBibliographyTypeOf = _prefixId.prefix "isBibliographyTypeOf"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : è tassonomia biologica dirdfs:label : is biological taxon of</para>
    ///   <para>rdfs:comment : This property relates a taxon to a biological entity.rdfs:comment : Questa proprietà collega una tassonomia con un'entità biologica.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isBiologicalTaxonOf">cdesc:isBiologicalTaxonOf</a>
    /// </summary>
    let isBiologicalTaxonOf = _prefixId.prefix "isBiologicalTaxonOf"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : è mutamento di condizione materiale dirdfs:label : is change of availability of</para>
    ///   <para>rdfs:comment : This property relates a change of availability to a cultural entity.rdfs:comment : Questa proprietà collega un mutamento di condizione materiale a un'entità culturale.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isChangeOfAvailabilityOf">cdesc:isChangeOfAvailabilityOf</a>
    /// </summary>
    let isChangeOfAvailabilityOf = _prefixId.prefix "isChangeOfAvailabilityOf"
    /// <summary>
    ///   <para>rdfs:label : is change of availability type ofrdfs:label : è tipo di mutamento condizione materiale di</para>
    ///   <para>rdfs:comment : This property relates the event type (i.e. theft, destruction, recovery) of a cultural entity change of availability to the change itself.rdfs:comment : Questa proprietà collega il tipo di evento (es.: furto, distruzione, recupero) di mutamento di condizione materiale di un bene culturale al mutamento stesso.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isChangeOfAvailabilityTypeOf">cdesc:isChangeOfAvailabilityTypeOf</a>
    /// </summary>
    let isChangeOfAvailabilityTypeOf = _prefixId.prefix "isChangeOfAvailabilityTypeOf"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà, inversa di 'ha circostanza', collega l'occasione che ha determinato una situazione (es. la committenza di un bene culturale, l'uso di un bene culturale ecc.) alla relativa situazione.rdfs:comment : This property, inverse of 'has circumstance' relates the circumstance which led to a situation (e.g. a cultural entity committment, a cultural entity use, etc.) to the related situation.</para>
    ///   <para>rdfs:label : is circumstance ofrdfs:label : è circostanza di</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isCircumstanceOf">cdesc:isCircumstanceOf</a>
    /// </summary>
    let isCircumstanceOf = _prefixId.prefix "isCircumstanceOf"
    /// <summary>
    ///   <para>rdfs:comment : This property relates the type of circumstance to the related circumstance.rdfs:comment : Questa proprietà collega il tipo di occasione con la relativa occasione.</para>
    ///   <para>rdfs:label : is circumstance type ofrdfs:label : è tipo di circostanza di</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isCircumstanceTypeOf">cdesc:isCircumstanceTypeOf</a>
    /// </summary>
    let isCircumstanceTypeOf = _prefixId.prefix "isCircumstanceTypeOf"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : è emissione di monetardfs:label : is coin issuance of</para>
    ///   <para>rdfs:comment : Questa è la proprietà inversa a "ha emissione di moneta".rdfs:comment : This is the inverse property of "has coin issuance".</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isCoinIssuanceOf">cdesc:isCoinIssuanceOf</a>
    /// </summary>
    let isCoinIssuanceOf = _prefixId.prefix "isCoinIssuanceOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : is coin member ofrdfs:label : è moneta membro di</para>
    ///   <para>rdfs:comment : Questa proprietà collega una moneta a una serie di monete di cui è membro.rdfs:comment : This property relates a coin to a numismatic series which is member of.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isCoinMemberOf">cdesc:isCoinMemberOf</a>
    /// </summary>
    let isCoinMemberOf = _prefixId.prefix "isCoinMemberOf"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : is collection inrdfs:label : è collezione in</para>
    ///   <para>rdfs:comment : Questa proprietà, inversa a "ha collezione", rappresenta la partecipazione di una collezione nel rapporto tra una collezione e un bene culturale che ne fa parte, in un certo intervallo di tempo.rdfs:comment : This property relates a collection to the relationship (membership) between the collection itself and a cultural property that is member of it.</para>
    ///   <para>ctlog:iccdNormTag : UB/COL/COLD^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isCollectionIn">cdesc:isCollectionIn</a>
    /// </summary>
    let isCollectionIn = _prefixId.prefix "isCollectionIn"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/arco/context-description/</para>
    ///   <para>rdfs:label : è collezionista dirdfs:label : is collector of</para>
    ///   <para>rdfs:comment : Questa proprietà, inversa a "ha collezionista", collega un collezionista alla relativa collezione di beni culturali.rdfs:comment : This property relates a collector to its collection of cultural properties.</para>
    ///   <para>ctlog:iccdNormTag : UB/COL/COLN^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isCollectorOf">cdesc:isCollectorOf</a>
    /// </summary>
    let isCollectorOf = _prefixId.prefix "isCollectorOf"
    /// <summary>
    ///   <para>rdfs:label : è committenza dirdfs:label : is commission of</para>
    ///   <para>rdfs:comment : Questa proprietà collega l'individuazione di una committenza all'entità culturale che è stata commissionata.rdfs:comment : This property relates a commission to the cultural entity that was commissioned.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isCommissionOf">cdesc:isCommissionOf</a>
    /// </summary>
    let isCommissionOf = _prefixId.prefix "isCommissionOf"
    /// <summary>
    ///   <para>rdfs:label : è committente inrdfs:label : is committent in</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property relates an agent that is committent of a cultural property to the identification of the commission of that cultural property.rdfs:comment : Questa proprietà collega una persona o istituzione committente a una situazione in cui viene indicata la committenza di un bene culturale.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: AU/CMM/CMMN^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isCommittentIn">cdesc:isCommittentIn</a>
    /// </summary>
    let isCommittentIn = _prefixId.prefix "isCommittentIn"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : è titolare dei diritti d'autore inrdfs:label : is copyright holder in</para>
    ///   <para>rdfs:comment : This is the inverse property of "has copyright holder".rdfs:comment : Questa è la proprietà inversa di "ha titolare dei diritti d'autore"</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isCopyrightHolderIn">cdesc:isCopyrightHolderIn</a>
    /// </summary>
    let isCopyrightHolderIn = _prefixId.prefix "isCopyrightHolderIn"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : is copyright ofrdfs:label : sono diritti d'autore di</para>
    ///   <para>rdfs:comment : This is the inverse property of "is copyright of".rdfs:comment : Questa è la proprietà inversa di "ha diritti d'autore".</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isCopyrightOf">cdesc:isCopyrightOf</a>
    /// </summary>
    let isCopyrightOf = _prefixId.prefix "isCopyrightOf"
    /// <summary>
    ///   <para>rdfs:comment : Questa è la proprietà inversa di "ha luogo di creazione".rdfs:comment : This is the inverse property of "has creation location".</para>
    ///   <para>rdfs:label : è luogo di realizzazione dirdfs:label : is creation location of</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isCreationLocationOf">cdesc:isCreationLocationOf</a>
    /// </summary>
    let isCreationLocationOf = _prefixId.prefix "isCreationLocationOf"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This property relates a cultural geographical area to the use of the cultural property which is present.rdfs:comment : Questa proprietà collega l'area geografico-culturale con l'uso del bene presente.</para>
    ///   <para>rdfs:label : è area geografico-culturale dirdfs:label : is cultural geographic area of</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isCulturalGeographicAreaOf">cdesc:isCulturalGeographicAreaOf</a>
    /// </summary>
    let isCulturalGeographicAreaOf = _prefixId.prefix "isCulturalGeographicAreaOf"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega una stima di un bene culturale al bene culturale stimato.rdfs:comment : This property relates a cultural property estimate to the estimated cultural property.</para>
    ///   <para>rdfs:label : is cultural property estimate ofrdfs:label : è stima del bene culturale</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isCulturalPropertyEstimateOf">cdesc:isCulturalPropertyEstimateOf</a>
    /// </summary>
    let isCulturalPropertyEstimateOf = _prefixId.prefix "isCulturalPropertyEstimateOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : is cultural property stage inrdfs:label : è stadio del bene culturale in</para>
    ///   <para>rdfs:comment : This cultural property relates the stage of a cultural property referring to another entity (preparatory or final work) to this relationship between the two entities.rdfs:comment : Questa proprietà collega lo stadio di realizzazione del bene culturale in relazione a un'altra entità collegata (opera preparatoria o opera finale) al  rapporto tra il bene culturale stesso e questa entità.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normative RA, SMO, PST, S, OAC, OA, MI, D, NU, F: RO/ROF/ROFF^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isCulturalPropertyStageIn">cdesc:isCulturalPropertyStageIn</a>
    /// </summary>
    let isCulturalPropertyStageIn = _prefixId.prefix "isCulturalPropertyStageIn"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This property relates a cultural scope of a cultural entity to the situation where this cultural scope is attributed.rdfs:comment : Questa proprietà collega l'ambito culturale attribuito a un bene culturale alla situazione in cui è avvenuta tale attribuzione.</para>
    ///   <para>rdfs:label : is cultural scope ofrdfs:label : è ambito culturale di</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isCulturalScopeOf">cdesc:isCulturalScopeOf</a>
    /// </summary>
    let isCulturalScopeOf = _prefixId.prefix "isCulturalScopeOf"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega un evento relativo al bene culturale, cui si riferisce la specifica cronologia a una cronologia.rdfs:comment : This property relates an event involving the cultural property, which the dating is about, to a dating.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : is dating event ofrdfs:label : è evento relativo alla datazione di</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isDatingEventOf">cdesc:isDatingEventOf</a>
    /// </summary>
    let isDatingEventOf = _prefixId.prefix "isDatingEventOf"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega una cronologia all'entità cui si riferisce.rdfs:comment : This property relates a dating to an entity.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : è cronologia dirdfs:label : is dating of</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isDatingOf">cdesc:isDatingOf</a>
    /// </summary>
    let isDatingOf = _prefixId.prefix "isDatingOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property relates the type of a work derivated from a cultural entity to its work derivated.rdfs:comment : Questa proprietà collega il tipo di opera derivata da un bene culturale alla relativa opera derivata.</para>
    ///   <para>rdfs:label : is derivated work type ofrdfs:label : è tipo di opera derivata di</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isDerivatedWorkTypeOf">cdesc:isDerivatedWorkTypeOf</a>
    /// </summary>
    let isDerivatedWorkTypeOf = _prefixId.prefix "isDerivatedWorkTypeOf"
    /// <summary>
    ///   <para>rdfs:label : è metodo di individuazione dirdfs:label : is detection method of</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property relates the detection method of a cultural property to the cultural property itself.rdfs:comment : Questa proprietà collega la modalità di individuazione di un bene culturale al bene culturale stesso.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isDetectionMethodOf">cdesc:isDetectionMethodOf</a>
    /// </summary>
    let isDetectionMethodOf = _prefixId.prefix "isDetectionMethodOf"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This property relates a documentation to an entity. For example, it can relates a documentation concerning a cultural property described in a catalogue record to that cultural property.rdfs:comment : Questa proprietà collega una documentazione a un'entità che viene documentata. Per esempio, può collega una documentazione che riguarda il bene descritto in una scheda di catalogo al bene stesso.</para>
    ///   <para>rdfs:label : è documentazione dirdfs:label : is documentation of</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: tutti i campi strutturati di DO tranne BIB</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isDocumentationOf">cdesc:isDocumentationOf</a>
    /// </summary>
    let isDocumentationOf = _prefixId.prefix "isDocumentationOf"
    /// <summary>
    ///   <para>rdfs:label : is documentation type ofrdfs:label : è tipo di documentazione di</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property relates the type of documentation to its documentation.rdfs:comment : Questa proprietà collega il tipo di documentazione alla sua documetanzione.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isDocumentationTypeOf">cdesc:isDocumentationTypeOf</a>
    /// </summary>
    let isDocumentationTypeOf = _prefixId.prefix "isDocumentationTypeOf"
    /// <summary>
    ///   <para>rdfs:comment : This property relates an entity's edition to the entity.rdfs:comment : Questa proprietà collega un'edizione di un'entità all'entità stessa.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : is edition ofrdfs:label : è edizione di</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normative VeAC e AT 3.01: DO/BSE/BSEN - Normativa S 3.00: RO/ADL/ADLE.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isEditionOf">cdesc:isEditionOf</a>
    /// </summary>
    let isEditionOf = _prefixId.prefix "isEditionOf"
    /// <summary>
    ///   <para>rdfs:label : is editor ofrdfs:label : è editore di</para>
    ///   <para>rdfs:comment : Questa è la proprietà inversa di "ha editore".rdfs:comment : This is the inverse property of "has editor".</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isEditorOf">cdesc:isEditorOf</a>
    /// </summary>
    let isEditorOf = _prefixId.prefix "isEditorOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property relates an estimate of an entity to that entity.rdfs:comment : Questa proprietà collega una stima di un'entità all'entità stimata.</para>
    ///   <para>rdfs:label : è stima dirdfs:label : is estimate of</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isEstimateOf">cdesc:isEstimateOf</a>
    /// </summary>
    let isEstimateOf = _prefixId.prefix "isEstimateOf"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : is export import certification ofrdfs:label : è certificato di importazione/esportazione di</para>
    ///   <para>rdfs:comment : This property relates an export import certification to a cultural entity.rdfs:comment : Questa proprietà collega un certificato di importazione/esportazione a un'entità culturale.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isExportImportCertificationOf">cdesc:isExportImportCertificationOf</a>
    /// </summary>
    let isExportImportCertificationOf = _prefixId.prefix "isExportImportCertificationOf"

    /// <summary>
    ///   <para>rdfs:label : is export import certification type ofrdfs:label : è tipo di certificazione di esportazione o importazione di</para>
    ///   <para>rdfs:comment : This property relates the type (i.e. delivery confirmation certification, free movement certification etc) of an import-export certification of a cultural entity to the rrelated certification.rdfs:comment : Questa proprietà collega la tipologia (es.: attestato di libera circolazione, licenza di esportazione definitiva, ecc) di una certificazione amministrativa di circolazione ed esportazione/importazione di un bene culturale alla relativa certificazione.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isExportImportCertificationTypeOf">cdesc:isExportImportCertificationTypeOf</a>
    /// </summary>
    let isExportImportCertificationTypeOf = _prefixId.prefix "isExportImportCertificationTypeOf"

    /// <summary>
    ///   <para>rdfs:label : è ufficio esportazione dirdfs:label : is export office of</para>
    ///   <para>rdfs:comment : Questa proprietà collega un ufficio di esportazione a un certificazione di esportazione/importazione.rdfs:comment : This property relates an export office to an export/import certification.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: TU/ESP/ESPU^^xsd:string</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isExportOfficeOf">cdesc:isExportOfficeOf</a>
    /// </summary>
    let isExportOfficeOf = _prefixId.prefix "isExportOfficeOf"
    /// <summary>
    ///   <para>rdfs:label : is finding context ofrdfs:label : è contesto di rinvenimento di</para>
    ///   <para>rdfs:comment : Questa proprietà collega il contesto di rinvenimento di un bene culturale, in particolare un reperto antropologico, al bene culturale.rdfs:comment : This property relates the finding context of a cultural property, and in particular an anthropological material, to the related cultural property.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isFindingContextOf">cdesc:isFindingContextOf</a>
    /// </summary>
    let isFindingContextOf = _prefixId.prefix "isFindingContextOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : è tipo di contesto di rinvenimento dirdfs:label : is finding context type of</para>
    ///   <para>rdfs:comment : This property relates a type of cultural property (i.e. anthropological material) finding context to its context.rdfs:comment : Questa proprietà collega il tipo di contesto di rinvenimento di un bene culturale, e in particolare di un reperto antropologico, al suo contesto.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isFindingContextTypeOf">cdesc:isFindingContextTypeOf</a>
    /// </summary>
    let isFindingContextTypeOf = _prefixId.prefix "isFindingContextTypeOf"
    /// <summary>
    ///   <para>rdfs:comment : This is the inverse property of "has finding location".rdfs:comment : Questa è la proprietà inversa di 'ha luogo di ritrovamento'.</para>
    ///   <para>rdfs:label : è luogo di ritrovamento dirdfs:label : is finding location of</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isFindingLocationOf">cdesc:isFindingLocationOf</a>
    /// </summary>
    let isFindingLocationOf = _prefixId.prefix "isFindingLocationOf"
    /// <summary>
    ///   <para>rdfs:label : è formato dirdfs:label : is format of</para>
    ///   <para>rdfs:comment : This property relates the format to the related documentation.rdfs:comment : Questa proprietà collega il formato con la relativa documentazione.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isFormatOf">cdesc:isFormatOf</a>
    /// </summary>
    let isFormatOf = _prefixId.prefix "isFormatOf"
    /// <summary>
    ///   <para>rdfs:label : is fruition ofrdfs:label : è fruizione di</para>
    ///   <para>rdfs:comment : This property relates the fruition of a garment to that garment.rdfs:comment : Questa proprietà collega una fruizione di un vestimento al vestimento stesso.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isFruitionOf">cdesc:isFruitionOf</a>
    /// </summary>
    let isFruitionOf = _prefixId.prefix "isFruitionOf"
    /// <summary>
    ///   <para>rdfs:label : is genus inrdfs:label : è genere in</para>
    ///   <para>rdfs:comment : This property relates a genus to the biological taxon in which it is classified.rdfs:comment : Questa proprietà collega un genere alla tassonomia in cui è classificato.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isGenusIn">cdesc:isGenusIn</a>
    /// </summary>
    let isGenusIn = _prefixId.prefix "isGenusIn"
    /// <summary>
    ///   <para>rdfs:label : is interpretation criterion ofrdfs:label : è criterio interpretativo di</para>
    ///   <para>rdfs:comment : This property relates an interpretation criterion to the interpretation that was based on that criterion.rdfs:comment : Questa proprietà collega un criterio interpretativo all'interpretazione che si è basata su quel criterio.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isInterpretationCriterionOf">cdesc:isInterpretationCriterionOf</a>
    /// </summary>
    let isInterpretationCriterionOf = _prefixId.prefix "isInterpretationCriterionOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà, inversa a "ha intervento ammesso", collega un intervento allo strumento urbanistico-territoriale che ammette quell'intervento.rdfs:comment : This property, inverse of "has eligible intervention", relates an intervention to the urban planning instrument that finds eligible that intervention.</para>
    ///   <para>rdfs:label : è intervento ammesso dardfs:label : is intervention eligible by</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isInterventionEligibleBy">cdesc:isInterventionEligibleBy</a>
    /// </summary>
    let isInterventionEligibleBy = _prefixId.prefix "isInterventionEligibleBy"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: CO/RST; normative di versioni precedenti: RS/RST - Normativa VeAC: CO/RIA - Normativa CA: RO/RIS^^xsd:string</para>
    ///   <para>rdfs:label : è intervento surdfs:label : is intervention on</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà, inversa a "ha intervento", collega un intervento, a fini conservativi o di altro tipo, che ha interessato un bene culturale, al bene stesso.rdfs:comment : This property relates an intervention on a cultural property to that cultural property.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isInterventionOn">cdesc:isInterventionOn</a>
    /// </summary>
    let isInterventionOn = _prefixId.prefix "isInterventionOn"
    /// <summary>
    ///   <para>rdfs:comment : This is the inverse property of "has intervention role".rdfs:comment : Questa è la proprietà inversa di "ha ruolo nell'intervento".</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : è ruolo nell'interventordfs:label : is intervention role in</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isInterventionRoleIn">cdesc:isInterventionRoleIn</a>
    /// </summary>
    let isInterventionRoleIn = _prefixId.prefix "isInterventionRoleIn"
    /// <summary>
    ///   <para>rdfs:label : is intervention type ofrdfs:label : è tipo di intervento di</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà collega il tipo di intervento, a fini conservativi o di altro tipo, che ha interessato un bene culturale al relativo intervento.rdfs:comment : This property relates the type of intervention on a cultural property to the related intervention.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isInterventionTypeOf">cdesc:isInterventionTypeOf</a>
    /// </summary>
    let isInterventionTypeOf = _prefixId.prefix "isInterventionTypeOf"

    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : è responsabile di numero di inventario dirdfs:label : is inventory identifier responsible of</para>
    ///   <para>rdfs:comment : Questa proprietà collega il contenitore giuridico che conserva attualmente il bene, o che lo ha conservato in passato, e che è responsabile dell'assegnazione del numero di inventario all'inventario stesso.rdfs:comment : This property relates the juridical container responsible for the inventory identifier of the cultural property to the inventory itself.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isInventoryIdentifierResponsibleOf">cdesc:isInventoryIdentifierResponsibleOf</a>
    /// </summary>
    let isInventoryIdentifierResponsibleOf = _prefixId.prefix "isInventoryIdentifierResponsibleOf"

    /// <summary>
    ///   <para>rdfs:comment : This property relates an inventory to a cultural property or an entity or an activity related to it.rdfs:comment : Questa proprietà collega un inventario che registra informazioni relative al bene culturale al bene culturale o alle entità o attività collegate al bene culturale.</para>
    ///   <para>rdfs:label : is inventory ofrdfs:label : è inventario di</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isInventoryOf">cdesc:isInventoryOf</a>
    /// </summary>
    let isInventoryOf = _prefixId.prefix "isInventoryOf"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega un bene culturale a un altro bene culturale collegato, di tipo immateriale, in cui è coinvolto.rdfs:comment : This property relates a cultural entity to another involved  cultural entity (e.g. immaterial).</para>
    ///   <para>rdfs:label : is involved inrdfs:label : è coinvolto in</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RV/RSE/RSER = 'è coinvolto in' (versioni precedenti: 'esecuzione/evento di riferimento')^^xsd:string</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isInvolvedIn">cdesc:isInvolvedIn</a>
    /// </summary>
    let isInvolvedIn = _prefixId.prefix "isInvolvedIn"
    /// <summary>
    ///   <para>rdfs:label : is issuer inrdfs:label : è emittente in</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa è la proprietà inversa di "ha emittente".rdfs:comment : This is the inverse property of "has issuer".</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isIssuerIn">cdesc:isIssuerIn</a>
    /// </summary>
    let isIssuerIn = _prefixId.prefix "isIssuerIn"
    /// <summary>
    ///   <para>rdfs:label : è ente che ha emanato il provvedimentordfs:label : is issuing agency of</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa è la proprietà inversa di "ha ente che ha emanato il provvedimento".rdfs:comment : This is the inverse property of "has issuing agency".</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isIssuingAgencyOf">cdesc:isIssuingAgencyOf</a>
    /// </summary>
    let isIssuingAgencyOf = _prefixId.prefix "isIssuingAgencyOf"
    /// <summary>
    ///   <para>rdfs:label : is issuing state inrdfs:label : è stato emittente in</para>
    ///   <para>rdfs:comment : This is the inverse property of "has issuing state".rdfs:comment : Questa è la proprietà inversa di "ha stato emittente".</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isIssuingStateIn">cdesc:isIssuingStateIn</a>
    /// </summary>
    let isIssuingStateIn = _prefixId.prefix "isIssuingStateIn"
    /// <summary>
    ///   <para>rdfs:comment : This property represents the location of the asset in its environment, i.e. the place where it is stored when not in use.rdfs:comment : Questa proprietà rappresenta la collocazione del bene nel suo ambiente, ovvero il luogo dove esso viene riposto quando non viene usato.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : è mantenuto inrdfs:label : is kept in</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa BDM 2.00: UT/UTA</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isKeptIn">cdesc:isKeptIn</a>
    /// </summary>
    let isKeptIn = _prefixId.prefix "isKeptIn"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This property relates the laboratory test type (i.e. chemical or metallurgical analysis) to the related laboratory test.rdfs:comment : Questa proprietà collega il tipo di analisi di laboratorio (es.: analisi metallurgica, analisi chimica, etc.) con la relativa analisi.</para>
    ///   <para>rdfs:label : is laboratory test type ofrdfs:label : è tipo di analisi di laboratorio di</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isLaboratoryTestTypeOf">cdesc:isLaboratoryTestTypeOf</a>
    /// </summary>
    let isLaboratoryTestTypeOf = _prefixId.prefix "isLaboratoryTestTypeOf"
    /// <summary>
    ///   <para>rdfs:comment : This property relates a legal situation to an entity that is in that situation.rdfs:comment : Questa proprietà collega una condizione giuridica a un'entità che si trova in quella condizione.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : è condizione giuridica dirdfs:label : is legal situation of</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isLegalSituationOf">cdesc:isLegalSituationOf</a>
    /// </summary>
    let isLegalSituationOf = _prefixId.prefix "isLegalSituationOf"
    /// <summary>
    ///   <para>rdfs:comment : This property relates a cultural entity to a connected cultural entity which constitutes its location area.rdfs:comment : Questa proprietà collega un bene culturale a un altro bene culturale collegato, che ne costituisce il luogo di collocazione.</para>
    ///   <para>rdfs:label : ha luogo di collocazionerdfs:label : è contenuto inrdfs:label : is located in</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RV/RSE/RSER = 'è contenuto in' (versioni precedenti: 'luogo di collocazione/localizzazione'; 'scheda contenitore')</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isLocatedIn">cdesc:isLocatedIn</a>
    /// </summary>
    let isLocatedIn = _prefixId.prefix "isLocatedIn"
    /// <summary>
    ///   <para>rdfs:label : is location ofrdfs:label : è luogo di collocazione di</para>
    ///   <para>rdfs:comment : Questa proprietà, inversa di 'is located in', collega un bene culturale a un altro bene culturale collegato, che costituisce il luogo di collocazione del primo.rdfs:comment : This property, inverse of 'is located in', relates a cultural entity to a connected cultural entity, which constitutes its location area.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isLocationOf">cdesc:isLocationOf</a>
    /// </summary>
    let isLocationOf = _prefixId.prefix "isLocationOf"
    /// <summary>
    ///   <para>rdfs:comment : This property relates a cultural property to the class that represents the membership relation between this cultural property and an archival record set.rdfs:comment : Questa proprietà collega un bene culturale alla classe che rappresenta l'appartenenza del bene a una unità archivistica complessa.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa F: UB/UBF^^xsd:string</para>
    ///   <para>rdfs:label : is member of archival record set ofrdfs:label : è membro di un'unità archivistica complessa di</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isMemberOfArchivalRecordSetOf">cdesc:isMemberOfArchivalRecordSetOf</a>
    /// </summary>
    let isMemberOfArchivalRecordSetOf = _prefixId.prefix "isMemberOfArchivalRecordSetOf"
    /// <summary>
    ///   <para>rdfs:comment : This property relates a cultural property to the class that represents the membership relation between this cultural property and a collection.rdfs:comment : Questa proprietà collega un bene culturale mobile alla classe che rappresenta l'appartenenza del bene culturale a una collezione in un certo intervallo di tempo.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : UB/COL^^xsd:string</para>
    ///   <para>rdfs:label : è membro di collezione dirdfs:label : is member of collection of</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isMemberOfCollectionOf">cdesc:isMemberOfCollectionOf</a>
    /// </summary>
    let isMemberOfCollectionOf = _prefixId.prefix "isMemberOfCollectionOf"

    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega un bene fotografico alla classe che rappresenta l'appartenenza del bene a una serie editoriale.rdfs:comment : This property relates a cultural property to the class that represents the membership relation between this cultural property and a photographic series.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : is member of photographic series inrdfs:label : è membro di serie fotografica in</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa F: PD/SFI; PD/SSI^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isMemberOfPhotographicSeriesIn">cdesc:isMemberOfPhotographicSeriesIn</a>
    /// </summary>
    let isMemberOfPhotographicSeriesIn = _prefixId.prefix "isMemberOfPhotographicSeriesIn"

    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa è la proprietà inversa di "ha zecca".rdfs:comment : This is the inverse property of "has mint".</para>
    ///   <para>rdfs:label : is mint inrdfs:label : è zecca in</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isMintIn">cdesc:isMintIn</a>
    /// </summary>
    let isMintIn = _prefixId.prefix "isMintIn"
    /// <summary>
    ///   <para>rdfs:label : è zecchiere inrdfs:label : in minter in</para>
    ///   <para>rdfs:comment : This is the inverse property of "has minter".rdfs:comment : Questa è la proprietà inversa di "ha zecchiere".</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isMinterIn">cdesc:isMinterIn</a>
    /// </summary>
    let isMinterIn = _prefixId.prefix "isMinterIn"
    /// <summary>
    ///   <para>rdfs:comment : This property relates the musical ensamble where an instument is (or were) played to the related musical instrument.rdfs:comment : Questa proprietà collega il gruppo di musicisti (bande, complessi musicali, associazioni corali, ecc.) in cui uno strumento assume, o ha assunto, abitualmente un ruolo esecutivo al relativo strumento musicale.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : è organico musicale dirdfs:label : is musical ensemble of</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isMusicalEnsembleOf">cdesc:isMusicalEnsembleOf</a>
    /// </summary>
    let isMusicalEnsembleOf = _prefixId.prefix "isMusicalEnsembleOf"
    /// <summary>
    ///   <para>rdfs:label : è musicista dirdfs:label : is musician of</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property relates the person who plays (in the present or past) a certain role as a musical instrument's exectutor to the related instrument.rdfs:comment : Questa proprietà collega una persona che assume - o ha assunto - un ruolo certo come esecutore di uno strumento musicale al relativo strumento.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isMusicianOf">cdesc:isMusicianOf</a>
    /// </summary>
    let isMusicianOf = _prefixId.prefix "isMusicianOf"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : è oggetto associato ardfs:label : is object associated to</para>
    ///   <para>rdfs:comment : This is the inverse property of "has associated object".rdfs:comment : Questa è la proprietò inversa a "ha oggetto associato".</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isObjectAssociatedTo">cdesc:isObjectAssociatedTo</a>
    /// </summary>
    let isObjectAssociatedTo = _prefixId.prefix "isObjectAssociatedTo"
    /// <summary>
    ///   <para>rdfs:comment : This property relates the type of observation survey (in the context, out of context) to the related observation survey.rdfs:comment : Questa proprietà collega il tipo di indagine di rilevamento (nel contesto/decontestualizzato) alla relativa indagine di rilevamento.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : è tipo di indagine di rilevamento dirdfs:label : is observation survey type of</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isObservationSurveyTypeOf">cdesc:isObservationSurveyTypeOf</a>
    /// </summary>
    let isObservationSurveyTypeOf = _prefixId.prefix "isObservationSurveyTypeOf"
    /// <summary>
    ///   <para>rdfs:label : è proprietario inrdfs:label : is owner in</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: TU/CDG/CDGS^^xsd:string</para>
    ///   <para>rdfs:comment : Questa proprietà, inversa a "ha proprietario", rappresenta la partecipazione di un agente alla condizione giuridica di un bene culturale, di cui l'agente ha la proprietà.rdfs:comment : This class relates an agent, that is the owner of a cultural property, to the legal situation of that cultural property.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isOwnerIn">cdesc:isOwnerIn</a>
    /// </summary>
    let isOwnerIn = _prefixId.prefix "isOwnerIn"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: PD/SFI; PD/SSI^^xsd:string</para>
    ///   <para>rdfs:label : è serie fotografica inrdfs:label : is photographic series in</para>
    ///   <para>rdfs:comment : This property relates a photographic series to the class that represents the membership relation between this photographic series and a cultural property that is member of it.rdfs:comment : Questa proprietà, inversa a "ha serie", collega una serie fotografica editoriale al rapporto tra la serie e un bene fotografico che ne fa parte.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isPhotographicSeriesIn">cdesc:isPhotographicSeriesIn</a>
    /// </summary>
    let isPhotographicSeriesIn = _prefixId.prefix "isPhotographicSeriesIn"
    /// <summary>
    ///   <para>rdfs:label : è sede di provenienza dirdfs:label : is previous location of</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This is the inverse property of "has previous location".rdfs:comment : Questa è la proprietà inversa di "ha sede di provenienza".</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isPreviousLocationOf">cdesc:isPreviousLocationOf</a>
    /// </summary>
    let isPreviousLocationOf = _prefixId.prefix "isPreviousLocationOf"
    /// <summary>
    ///   <para>rdfs:comment : This property relates the previous owner of a cultural property to the acquisition by a new owner.rdfs:comment : Questa proprietà, inversa a "ha soggetto fonte di acquisizione", collega il soggetto fonte dell'acquisizione di un bene all'acquisizione stessa.</para>
    ///   <para>rdfs:label : è soggetto fonte dell'acquisizione dirdfs:label : is previous owner of</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: TU/ACQ/ACQN^^xsd:string</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isPreviousOwnerOf">cdesc:isPreviousOwnerOf</a>
    /// </summary>
    let isPreviousOwnerOf = _prefixId.prefix "isPreviousOwnerOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : is primary documentation ofrdfs:label : è documentazione primaria di</para>
    ///   <para>rdfs:comment : Questa è la proprietà inversa di "ha documentazione primaria".rdfs:comment : This is the inverse property of "has primary documentation".</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isPrimaryDocumentationOf">cdesc:isPrimaryDocumentationOf</a>
    /// </summary>
    let isPrimaryDocumentationOf = _prefixId.prefix "isPrimaryDocumentationOf"
    /// <summary>
    ///   <para>rdfs:label : è professione dirdfs:label : is profession of</para>
    ///   <para>rdfs:comment : This is the inverse property of "has profession".rdfs:comment : Questa è la proprietà inversa di "ha professione".</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isProfessionOf">cdesc:isProfessionOf</a>
    /// </summary>
    let isProfessionOf = _prefixId.prefix "isProfessionOf"
    /// <summary>
    ///   <para>rdfs:label : is proponent agency ofrdfs:label : è ente proponente di</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà collega all'ente proponente, ovvero il soggetto che ha proposto il provvedimento (identificato per mezzo della denominazione per esteso oppure, nel caso di Enti accreditati dall'ICCD, del relativo codice assegnato dall'Istituto) al provvedimento di tutela relativo al bene culturale, oppure direttamente al bene culturale. La relazione tra il ruolo e l'agente che lo riveste è espressa, in maniera generica, nel nome della proprietà, che quindi ne fornisce una rappresentazione semplificata, con ridotta espressività. Nell'ontologia questa relazione è modellata anche, in maniera più espressiva, dalla classe AgentRole, che permette di collegare l'agente e il suo ruolo.rdfs:comment : This property relates an agent that is a proponent agency of a protective measure of a cultural property to the protective measure or to the cultural entity itself. The relation is declared in the name of the property, but within the ontology this relation is also modeled, in a more expressive way, through the class AgentRole.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: TU/NVC/NVCA^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isProponentAgencyOf">cdesc:isProponentAgencyOf</a>
    /// </summary>
    let isProponentAgencyOf = _prefixId.prefix "isProponentAgencyOf"
    /// <summary>
    ///   <para>rdfs:label : is protective measure ofrdfs:label : è provvedimento di tutela di</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property relates an international or national protective measure to the cultural enitity to which it is applied.rdfs:comment : Questa proprietà collega un provvedimento di tutela nazionale o internazionale al bene culturale cui si applica.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: TU/NVC^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isProtectiveMeasureOf">cdesc:isProtectiveMeasureOf</a>
    /// </summary>
    let isProtectiveMeasureOf = _prefixId.prefix "isProtectiveMeasureOf"
    /// <summary>
    ///   <para>rdfs:label : è repertorio di riferimento dirdfs:label : is reference catalogue of</para>
    ///   <para>rdfs:comment : This is the inverse property of "has reference catalogue".rdfs:comment : Questa è la proprietà inversa di "ha repertorio di riferimento".</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isReferenceCatalogueOf">cdesc:isReferenceCatalogueOf</a>
    /// </summary>
    let isReferenceCatalogueOf = _prefixId.prefix "isReferenceCatalogueOf"
    /// <summary>
    ///   <para>rdfs:label : is related to researchrdfs:label : si riferisce a ricerca</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà collega un rilevamento di un bene musicale o demoetnoantropologico alla ricerca nell'ambito della quale è stata redatta la scheda.rdfs:comment : This class relates an observation survey of musical or demoetnoanthropological heritage to the research in which the catalogue record describing a cultural property was recorded (e.g.: a cataloguing campaign)</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa SM 4.00: DR^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isRelatedToResearch">cdesc:isRelatedToResearch</a>
    /// </summary>
    let isRelatedToResearch = _prefixId.prefix "isRelatedToResearch"
    /// <summary>
    ///   <para>rdfs:comment : This property relates a work related to a cultural property (e.g.: a preparatory work, a prototype, a copy, a reuse, etc.) to the situation in which that work is related to the cultural property itself.rdfs:comment : Questa proprietà collega un'opera collegata a un bene culturale al rapporto tra l'opera e il bene culturale (es.: un lavoro preparatorio, un prototipo, una copia, un reimpiego di tutto il bene o di una sua parte, ecc.)</para>
    ///   <para>rdfs:label : è opera collegata coinvolta inrdfs:label : is related work involved in</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isRelatedWorkInvolvedIn">cdesc:isRelatedWorkInvolvedIn</a>
    /// </summary>
    let isRelatedWorkInvolvedIn = _prefixId.prefix "isRelatedWorkInvolvedIn"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : è rapporto con opera collegata dirdfs:label : is related work situation of</para>
    ///   <para>rdfs:comment : This property, inverse of 'has related work situation', relates a situation in which a cultural property is related to another work, that could even be another cultural property, to the cultural property.rdfs:comment : Questa proprietà, inversa di 'ha rapporto con opera collegata', collega la relazione tra il bene culturale e un'altra opera che ne costituisce una fase preparatoria o che ne rappresenta la fase finale al bene culturale stesso.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isRelatedWorkSituationOf">cdesc:isRelatedWorkSituationOf</a>
    /// </summary>
    let isRelatedWorkSituationOf = _prefixId.prefix "isRelatedWorkSituationOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property relates the reliability of the information collected during the survey to a photo interpretation rendering survey.rdfs:comment : Questa proprietà collega il livello di affidabilità delle informazioni rilevate nell'indagine a una fotointerpretazione o fotorestituzione.</para>
    ///   <para>rdfs:label : è affidabilità dirdfs:label : is reliability of</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isReliabilityOf">cdesc:isReliabilityOf</a>
    /// </summary>
    let isReliabilityOf = _prefixId.prefix "isReliabilityOf"
    /// <summary>
    ///   <para>rdfs:comment : This property relates a print to the reproduction of that print in a publication.rdfs:comment : Questa proprietà collega una stampa con la sua riproduzione contenuta in una pubblicazione, di cui la stampa è, o è stata, parte integrante.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : is reproduced byrdfs:label : è riprodotto da</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa S 3: RO/ADL^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isReproducedBy">cdesc:isReproducedBy</a>
    /// </summary>
    let isReproducedBy = _prefixId.prefix "isReproducedBy"
    /// <summary>
    ///   <para>rdfs:label : is reproduction ofrdfs:label : è riproduzione di</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This is the inverse property of "has reproduction".rdfs:comment : Questa è la proprietà inversa di "ha riproduzione".</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isReproductionOf">cdesc:isReproductionOf</a>
    /// </summary>
    let isReproductionOf = _prefixId.prefix "isReproductionOf"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega la posizione fisica della riproduzione di una stampa all'interno di una pubblicazione (es.: frontespizio, copertina, colophon, etc.). con la relativa riproduzione della stampa.rdfs:comment : This property relates the position of the print reproduction in a publication to the print reproduction itself.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : is reproduction position ofrdfs:label : è posizione della riproduzione di</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isReproductionPositionOf">cdesc:isReproductionPositionOf</a>
    /// </summary>
    let isReproductionPositionOf = _prefixId.prefix "isReproductionPositionOf"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa SM e BDM 4.00: DR/DRT^^xsd:string</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property relates a research from which has been produced a cultural entity's catalogue record, to the cultural entity.rdfs:comment : Questa proprietà la ricerca nell'ambito della quale è stata redatta la scheda su un bene culturale al bene stesso.</para>
    ///   <para>rdfs:label : è ricerca surdfs:label : is research on</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isResearchOn">cdesc:isResearchOn</a>
    /// </summary>
    let isResearchOn = _prefixId.prefix "isResearchOn"

    /// <summary>
    ///   <para>rdfs:label : è  responsabile scientifico della ricerca dirdfs:label : is research scientific director of</para>
    ///   <para>rdfs:comment : This property relates the research's scientific responsible to its research.rdfs:comment : Questa proprietà collega il responsabile scientifico di una ricerca alla ricerca.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isResearchScientificDirectorOf">cdesc:isResearchScientificDirectorOf</a>
    /// </summary>
    let isResearchScientificDirectorOf = _prefixId.prefix "isResearchScientificDirectorOf"

    /// <summary>
    ///   <para>rdfs:label : is responsibility forrdfs:label : è responsibilità su</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa F: PD/PDF^^xsd:string</para>
    ///   <para>rdfs:comment : This property relates the attribution of a responsibility to an agent, relating to the activities of production and dissemination of photographic heritage (e.g.: committent, editor, printer, dedicatee, etc.) to photographic heritage.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isResponsibilityFor">cdesc:isResponsibilityFor</a>
    /// </summary>
    let isResponsibilityFor = _prefixId.prefix "isResponsibilityFor"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega al tipo di responsabilità (es.: stampatori, ritoccatori, coloritori, ecc.) alla relativa responsabilità individuata relativamente ai processi di produzione e di divulgazione che caratterizzano specificamente i beni fotografici.rdfs:comment : This property relates the esponsibility type (i.e. printers, retouchers) to the related resposibility relative to some production or disclosure process which characterise photographic artefacts.</para>
    ///   <para>rdfs:label : è tipo di responsabilità dirdfs:label : is responsibility type of</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isResponsibilityTypeOf">cdesc:isResponsibilityTypeOf</a>
    /// </summary>
    let isResponsibilityTypeOf = _prefixId.prefix "isResponsibilityTypeOf"
    /// <summary>
    ///   <para>rdfs:label : is responsible for insertion ofrdfs:label : è responsabile dell'immissione in patrimonio di</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà collega il responsabile dell'inventariazione patrimoniale del bene all'inventario patrimoniale.rdfs:comment : This property relates the agent responsible for the cultural entity's inventory to the current inventory.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isResponsibleForInsertionOf">cdesc:isResponsibleForInsertionOf</a>
    /// </summary>
    let isResponsibleForInsertionOf = _prefixId.prefix "isResponsibleForInsertionOf"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RV/RSE/RSER = 'è riutilizzato in' (versioni precedenti: 'bene composto')</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : è riutilizzato inrdfs:label : is reused by</para>
    ///   <para>rdfs:comment : Questa proprietà collega un bene culturale a un altro bene culturale collegato che lo riutilizza in tutto o in parte.rdfs:comment : This property relates a cultural entity to a connected cultural entity that reuse it or a part of it.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isReusedBy">cdesc:isReusedBy</a>
    /// </summary>
    let isReusedBy = _prefixId.prefix "isReusedBy"
    /// <summary>
    ///   <para>rdfs:label : is scale ofrdfs:label : è scala di</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property relates the representation scale to its graphic or cartographic representation.rdfs:comment : Questa proprietà collega la scala di rappresentazione alla documentazione grafica e cartografica.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isScaleOf">cdesc:isScaleOf</a>
    /// </summary>
    let isScaleOf = _prefixId.prefix "isScaleOf"
    /// <summary>
    ///   <para>rdfs:label : is secondary author ofrdfs:label : è autore secondario di</para>
    ///   <para>rdfs:comment : Questa proprietà collega l'autore secondario di un entità, come ad esempio un contributo o una parte di una pubblicazione, all'entità stessa.rdfs:comment : This property relates the secondary authors of an entity (i.e. a publication's contribution or section) to the related entity.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isSecondaryAuthorOf">cdesc:isSecondaryAuthorOf</a>
    /// </summary>
    let isSecondaryAuthorOf = _prefixId.prefix "isSecondaryAuthorOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : is sex interpretation ofrdfs:label : è interpretazione del sesso di</para>
    ///   <para>rdfs:comment : This property relates the sex estimate of an antropologic artifact to the related artifact.rdfs:comment : Questa proprietà collega la stima del sesso di un reperto antropologico al reperto stesso.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isSexInterpretationOf">cdesc:isSexInterpretationOf</a>
    /// </summary>
    let isSexInterpretationOf = _prefixId.prefix "isSexInterpretationOf"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega una specie alla tassonomia in cui è classificata.rdfs:comment : This property relates a species to the biological taxon in which it is classified.</para>
    ///   <para>rdfs:label : è specie inrdfs:label : is species in</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isSpeciesIn">cdesc:isSpeciesIn</a>
    /// </summary>
    let isSpeciesIn = _prefixId.prefix "isSpeciesIn"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This property relates the stratigraphic unit from which a cultural property has been found to the related archeological excavation.rdfs:comment : Questa proprietà collega l'unità stratigrafica dalla quale proviene il bene rinvenuto nello scavo al relativo scavo archeologico.</para>
    ///   <para>rdfs:label : is stratigraphic unit ofrdfs:label : è unità stratigrafica di</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isStratigraphicUnitOf">cdesc:isStratigraphicUnitOf</a>
    /// </summary>
    let isStratigraphicUnitOf = _prefixId.prefix "isStratigraphicUnitOf"
    /// <summary>
    ///   <para>rdfs:label : è soggetto dirdfs:label : is subject of</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: DA/AID/AIDI - Normativa F: SG/SGT/SGTI - Altre normative di versioni precedenti alla 4.00: OG/SGT/SGTI - ICCD Normative F, RA, SMO, PST, S, OAC, OA, MI, D, NU: RO/ROF/ROFS</para>
    ///   <para>rdfs:comment : This property relates a subject or ornamental motif to the cultural property or to the final or preparatory work of a cultural property.rdfs:comment : Questa proprietà, inversa a "ha soggetto", collega un soggetto o motivo ornamentale al bene culturale o a un'opera correlata a un bene culturale in quanto sua fase preparatoria o finale o a un apparato iconografico-decorativo su cui è rappresentato.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isSubjectOf">cdesc:isSubjectOf</a>
    /// </summary>
    let isSubjectOf = _prefixId.prefix "isSubjectOf"
    /// <summary>
    ///   <para>rdfs:label : è sottospecie inrdfs:label : is subspecies in</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà collega una sottospecie alla tassonomia in cui è classificata.rdfs:comment : This property relates a subspecies to the biological taxon in which it is classified.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isSubspeciesIn">cdesc:isSubspeciesIn</a>
    /// </summary>
    let isSubspeciesIn = _prefixId.prefix "isSubspeciesIn"
    /// <summary>
    ///   <para>rdfs:comment : This is the inverse property of "has survey image".rdfs:comment : Questa è la proprietà inversa di "ha immagine di indagine".</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : is survey image ofrdfs:label : è immagine di indagine</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isSurveyImageOf">cdesc:isSurveyImageOf</a>
    /// </summary>
    let isSurveyImageOf = _prefixId.prefix "isSurveyImageOf"
    /// <summary>
    ///   <para>rdfs:label : is survey image type ofrdfs:label : è tipo di immagine di indagine di</para>
    ///   <para>rdfs:comment : This property relates the type of a survey image (i.e. aerial photograph, Satellite photograph) to the related survey image.rdfs:comment : Questa proprietà collega il tipo una immagine di indagine (fotografia aerea o fotografia satellitare). con la relativa immagine di indagine.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isSurveyImageTypeOf">cdesc:isSurveyImageTypeOf</a>
    /// </summary>
    let isSurveyImageTypeOf = _prefixId.prefix "isSurveyImageTypeOf"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega il metodo adottato nel corso di un'indagine all'indagine stessa.rdfs:comment : This property relates the method adopted in a survey to the survey itself.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : è metodo di indagine dirdfs:label : is survery method of</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isSurveyMethodOf">cdesc:isSurveyMethodOf</a>
    /// </summary>
    let isSurveyMethodOf = _prefixId.prefix "isSurveyMethodOf"
    /// <summary>
    ///   <para>rdfs:comment : This property relates the main motivation that led to an archeological, archaeometric or diagnostic survey or a photo interpretation rendering to each of them.rdfs:comment : Questa proprietà collega il motivo principale che ha determinato uno scavo archeologico, una ricognizione archeologica, un'indagine archeometrica e diagnostica o una fotointerpretazione e fotorestituzione a ciascuno di essi.</para>
    ///   <para>rdfs:label : è motivo di indagine dirdfs:label : is survey motivation of</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isSurveyMotivationOf">cdesc:isSurveyMotivationOf</a>
    /// </summary>
    let isSurveyMotivationOf = _prefixId.prefix "isSurveyMotivationOf"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega un'indagine effettuata su un bene culturale al bene stesso.rdfs:comment : This property relates a cultural entity's survey to the cultural entity.</para>
    ///   <para>rdfs:label : è indagine surdfs:label : is survey on</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RE; CM/ISP - ICCD Normative NU, RA, BNB, MA, CA: RS/ALB - ICCD Normativa AT 3.00: IN/INI - Normativa BDM e SM 4.00: DR^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isSurveyOn">cdesc:isSurveyOn</a>
    /// </summary>
    let isSurveyOn = _prefixId.prefix "isSurveyOn"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega il fotografo professionista (diverso dal rilevatore) che ha effettuato l'indagine all'indagine di rilevamento di un bene demo-etno-antropologico.rdfs:comment : This property relates the professional photographer who took the shot to the observation survey of a demo-etno-antropologic entity.</para>
    ///   <para>rdfs:label : is observation photographer ofrdfs:label : è fotografo dell'indagine di</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isSurveyPhotographerOf">cdesc:isSurveyPhotographerOf</a>
    /// </summary>
    let isSurveyPhotographerOf = _prefixId.prefix "isSurveyPhotographerOf"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega il responsabile scientifico di un'indagine alla relativa indagine.rdfs:comment : This property relates the scientific director of a survey to the related survey.</para>
    ///   <para>rdfs:label : è responsabile scientifico dell'indagine dirdfs:label : is survey scientific director of</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isSurveyScientificDirectorOf">cdesc:isSurveyScientificDirectorOf</a>
    /// </summary>
    let isSurveyScientificDirectorOf = _prefixId.prefix "isSurveyScientificDirectorOf"
    /// <summary>
    ///   <para>rdfs:label : è fonico dell'indagine dirdfs:label : is survey sound engineer of</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà collega il fonico professionista (diverso dal rilevatore) che ha effettuato la registrazione sonora all'indagine di rilevamento di un bene demo-etno-antropologico.rdfs:comment : This property relates the sound engineer who recorded an observation survey to the related observation survey of a demo-etno-antropologic entity.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isSurveySoundEngineerOf">cdesc:isSurveySoundEngineerOf</a>
    /// </summary>
    let isSurveySoundEngineerOf = _prefixId.prefix "isSurveySoundEngineerOf"
    /// <summary>
    ///   <para>rdfs:comment : This property relates a title to the entity to which it is referred.rdfs:comment : Questa proprietà collega un titolo all'entità cui si riferisce.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : is title ofrdfs:label : è titolo di</para>
    ///   <para>ctlog:iccdNormTag : OG/SGT/SGTP; SG/SGL/SGLT; SG/SGL/SGLL; OG/SGT/SGTR; DA/AID/AIDN; SG/SGL/SGLA; DA/AID/AIDT; OG/SGT/SGTT; RO/ROF/ROFT; DO/BSE/BSET; DO/BSE/BSEC.^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isTitleOf">cdesc:isTitleOf</a>
    /// </summary>
    let isTitleOf = _prefixId.prefix "isTitleOf"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega il tipo di titolo di un bene culturale al relativo titolo.rdfs:comment : This property relates the type of a cultural entity title to its title.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : is title type ofrdfs:label : è tipo di titolo di</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isTitleTypeOf">cdesc:isTitleTypeOf</a>
    /// </summary>
    let isTitleTypeOf = _prefixId.prefix "isTitleTypeOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This is the inverse property of "has tomb".rdfs:comment : Questa è la proprietà inversa di "ha deposizione funeraria".</para>
    ///   <para>rdfs:label : è deposizione funeraria dirdfs:label : is tomb of</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isTombOf">cdesc:isTombOf</a>
    /// </summary>
    let isTombOf = _prefixId.prefix "isTombOf"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega uno strumento urbanistico-territoriale, ovvero un piano regolatore generale e particolareggiato o un piano paesaggistico che interessa un bene culturale al bene stesso.rdfs:comment : This class relates a urban planning instrument to the related cultural property.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : è strumento urbanistico-territoriale dirdfs:label : is urban planning instrument of</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: TU/STU^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isUrbanPlanningInstrumentOf">cdesc:isUrbanPlanningInstrumentOf</a>
    /// </summary>
    let isUrbanPlanningInstrumentOf = _prefixId.prefix "isUrbanPlanningInstrumentOf"
    /// <summary>
    ///   <para>rdfs:label : è funzione d'uso dirdfs:label : is use function of</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property relates the use function of an entity to the related entity.rdfs:comment : Questa proprietà collega la funzione d'uso di un'entità alla relativa entità.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isUseFunctionOf">cdesc:isUseFunctionOf</a>
    /// </summary>
    let isUseFunctionOf = _prefixId.prefix "isUseFunctionOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà collega l'uso di un bene culturale con il bene culturale stesso.rdfs:comment : This property relates the use of a cultural entity to the related cultural property.</para>
    ///   <para>rdfs:label : is use ofrdfs:label : è uso di</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isUseOf">cdesc:isUseOf</a>
    /// </summary>
    let isUseOf = _prefixId.prefix "isUseOf"
    /// <summary>
    ///   <para>rdfs:label : is use type ofrdfs:label : è tipo d'uso di</para>
    ///   <para>rdfs:comment : This property relates the type of a cultural entity use to its use.rdfs:comment : Questa proprietà collega il tipo di uso del bene (attuale, precedente, storico) con il suo uso.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isUseTypeOf">cdesc:isUseTypeOf</a>
    /// </summary>
    let isUseTypeOf = _prefixId.prefix "isUseTypeOf"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega le specifiche relative al tipo di utilizzo di un bene con il relativo uso.rdfs:comment : This property relates the specification of the type of a cultural property use to the related use.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : is use type specification ofrdfs:label : è specifica del tipo di uso di</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isUseTypeSpecificationOf">cdesc:isUseTypeSpecificationOf</a>
    /// </summary>
    let isUseTypeSpecificationOf = _prefixId.prefix "isUseTypeSpecificationOf"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega un utente, inteso come agente che ha fatto uso di un'entità, all'entità stessa.rdfs:comment : This property relates the user, intended as the agent who employed an entity, to the related entity.</para>
    ///   <para>rdfs:label : è utente dirdfs:label : is user of</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isUserOf">cdesc:isUserOf</a>
    /// </summary>
    let isUserOf = _prefixId.prefix "isUserOf"
    /// <summary>
    ///   <para>rdfs:comment : Questa è la proprietà inversa a "ha opera collegata".rdfs:comment : This is the inverse property of "has related work".</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : è opera collegata ardfs:label : is work related to</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/isWorkRelatedTo">cdesc:isWorkRelatedTo</a>
    /// </summary>
    let isWorkRelatedTo = _prefixId.prefix "isWorkRelatedTo"
    /// <summary>
    ///   <para>rdfs:label : data di emissionerdfs:label : issue date</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: TU/NVC/NVCE; TU/ESP/ESPD^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta la data di emissione di un provvedimento amministrativo o di una certificazione (es.: per la circolazione, esportazione/importazione di un bene culturale)rdfs:comment : This property represents issue date of an administrative provision or a certification.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/issueDate">cdesc:issueDate</a>
    /// </summary>
    let issueDate = _prefixId.prefix "issueDate"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This property represents how the cultural entity was inserted inside a collection.rdfs:comment : Questa proprietà rappresenta, a testo libero, le modalità di acquisizione del bene nel patrimonio.</para>
    ///   <para>rdfs:label : method of insertionrdfs:label : modalità di acquisizione</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: UB/INP/INPM^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/methodOfInsertion">cdesc:methodOfInsertion</a>
    /// </summary>
    let methodOfInsertion = _prefixId.prefix "methodOfInsertion"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: TU/NVC/NVCD^^xsd:string</para>
    ///   <para>rdfs:comment : This property represents the date of notification of the administrative provision to the owner.rdfs:comment : Questa proprietà rappresenta la data della notifica del provvedimento amministrativo al proprietario.</para>
    ///   <para>rdfs:label : data di notificardfs:label : notice date</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/noticeDate">cdesc:noticeDate</a>
    /// </summary>
    let noticeDate = _prefixId.prefix "noticeDate"
    /// <summary>
    ///   <para>rdfs:label : number in circulationrdfs:label : numero nella tiratura</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta la numerazione dell'esemplare della fotografia o della stampa all'interno della tiratura e il numero complessivo degli esemplari tirati, qualora la fotografia o la stampa risalgano a una tiratura. Nel caso delle fotografie, per tiratura si intende un insieme prestabilito e limitato di esemplari (uguali) tratti dallo stesso negativo o dalla stessa, ovvero non modificata, fotografia digitale (o dalla stessa serie di matrici), numerati progressivamente.rdfs:comment : This property represents photograph copies numbering.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa F: PD/TRT; ICCD Normativa S: PD/TRT/TRTN^^xsd:string</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/numberInCirculation">cdesc:numberInCirculation</a>
    /// </summary>
    let numberInCirculation = _prefixId.prefix "numberInCirculation"
    /// <summary>
    ///   <para>rdfs:label : data di comunicazione di avviordfs:label : opening notice date</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: TU/NVC/NVCI^^xsd:string</para>
    ///   <para>rdfs:comment : This property represents date of interest declaration communication to the owner or holder.rdfs:comment : Questa proprietà rappresenta la data (nella forma “aaaa/mm/gg”) della comunicazione di avvio del procedimento di dichiarazione di interesse al proprietario, possessore o detentore.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/openingNoticeDate">cdesc:openingNoticeDate</a>
    /// </summary>
    let openingNoticeDate = _prefixId.prefix "openingNoticeDate"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà rappresenta le specifiche per effettuare sovrapposizioni con altri documenti utili per la lettura e l'interpretazione dell'immagine analizzata durante uan fotointerpretazione o fotorestituzione.rdfs:comment : This property represents specifications to make overlaps with other documents useful for reading and interpreting image analyzed during a photointerpretation or photo-repayment.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : specifiche sulla sovrapposizionerdfs:label : overlap specifications</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RE/FOI/FOIP^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/overlapSpecifications">cdesc:overlapSpecifications</a>
    /// </summary>
    let overlapSpecifications = _prefixId.prefix "overlapSpecifications"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà rappresenta le informazioni relative al numero della pagina o numero della tavola della pubblicazione in cui compare la stampa.rdfs:comment : This property represents information about page number or table number of publication in which the print appears.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa S 3: RO/ADL/ADLN</para>
    ///   <para>rdfs:label : numero di pagina o tavolardfs:label : page or table number</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/pageOrTableNumber">cdesc:pageOrTableNumber</a>
    /// </summary>
    let pageOrTableNumber = _prefixId.prefix "pageOrTableNumber"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta un titolo parallelo, cioè lo stesso titolo principale tradotto in altre lingue e presentato come equivalente.rdfs:comment : This property represents the parallel title of a cultural property.</para>
    ///   <para>rdfs:label : parallel titlerdfs:label : titolo parallelo</para>
    ///   <para>ctlog:iccdNormTag : Normativa F: SG/SGL/SGLL - Normative S e MI: OG/SGT/SGTR^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/parallelTitle">cdesc:parallelTitle</a>
    /// </summary>
    let parallelTitle = _prefixId.prefix "parallelTitle"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa F: PD/SFI/SFIN^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This property represents numbering of the photograph within editorial photographic series.rdfs:comment : Questa proprietà rappresenta la numerazione della fotografia all'interno della serie fotografica editoriale.</para>
    ///   <para>rdfs:label : series item numberrdfs:label : numero dell'item all'interno della serie</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/photographicSeriesItemNumber">cdesc:photographicSeriesItemNumber</a>
    /// </summary>
    let photographicSeriesItemNumber = _prefixId.prefix "photographicSeriesItemNumber"

    /// <summary>
    ///   <para>rdfs:comment : This property represents numbering of the photograph within the editorial photographic subseries.rdfs:comment : Questa proprietà rappresenta la numerazione della fotografia all'interno della sottoserie fotografica editoriale.</para>
    ///   <para>rdfs:label : numero dell'item all'interno della sottoserie fotograficardfs:label : photographic subseries item number</para>
    ///   <para>owl:versionInfo : unstableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa F: PD/SSI/SSIN^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/photographicSubseriesItemNumber">cdesc:photographicSubseriesItemNumber</a>
    /// </summary>
    let photographicSubseriesItemNumber = _prefixId.prefix "photographicSubseriesItemNumber"

    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normative F, RA, SMO, PST, S, OAC, OA, MI, D, NU: RO/ROF/ROFC - Normativa S: RO/COP/COPC - Normativa F: RO/CRF/CRFC^^xsd:string</para>
    ///   <para>rdfs:label : preparatory or final work locationrdfs:label : collocazione dell'opera preparatoria o finale</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta la localizzazione geografica e collocazione specifica dell'opera derivata dal bene culturale.rdfs:comment : This property represents geographical location and specific location of the work derived from the cultural property.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/preparatoryOrFinalWorkLocation">cdesc:preparatoryOrFinalWorkLocation</a>
    /// </summary>
    let preparatoryOrFinalWorkLocation = _prefixId.prefix "preparatoryOrFinalWorkLocation"

    /// <summary>
    ///   <para>rdfs:label : preparatory or final work previous locationrdfs:label : collocazione precedente dell'opera preparatoria o finale</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normative S, MI 3: RO/ROF/ROFR</para>
    ///   <para>rdfs:comment : This property represents information relating to ancient or previous location of the work from which the matrix or print is ​​drawn.rdfs:comment : Questa proprietà rappresenta le informazioni relative all'antica o precedente l'attuale collocazione dell'opera da cui è tratta la matrice o la stampa presso collezioni, palazzi, chiese, ecc., quando questa è segnalata sulla matrice/stampa o sicuramente deducibile dalle fonti bibliografiche.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/preparatoryOrFinalWorkPreviousLocation">cdesc:preparatoryOrFinalWorkPreviousLocation</a>
    /// </summary>
    let preparatoryOrFinalWorkPreviousLocation = _prefixId.prefix "preparatoryOrFinalWorkPreviousLocation"

    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normative F, RA, SMO, PST, S, OAC, OA, MI, D, NU: RO/ROF/ROFX^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This property represents the code which identifies the record relating to the final or preparatory work in relation with the cultural property.rdfs:comment : Questa proprietà rappresenta il codice, qualora esista, che identifica la scheda relativa all'opera finale o preparatoria in relazione con il bene culturale.</para>
    ///   <para>rdfs:label : preparatory or final work record identifierrdfs:label : codice della scheda dell'opera originale o finale</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/preparatoryOrFinalWorkRecordIdentifier">cdesc:preparatoryOrFinalWorkRecordIdentifier</a>
    /// </summary>
    let preparatoryOrFinalWorkRecordIdentifier = _prefixId.prefix "preparatoryOrFinalWorkRecordIdentifier"

    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : propert titlerdfs:label : titolo proprio</para>
    ///   <para>ctlog:iccdNormTag : Normative S e MI: OG/SGT/SGTP - Normativa F: SG/SGL/SGLT^^xsd:string</para>
    ///   <para>rdfs:comment : Rappresenta il titolo proprio del soggetto di una stampa, di una matrice incisa o di una fotografia. Per titolo proprio di una stampa si intende il titolo principale nella forma in cui appare sulla stampa o sulla matrice stessa. Per titolo proprio (principale) di una fotografia, si intende nella forma in cui appare nell'immagine (o su uno dei suoi supporti, o nelle schede a campi testuali, o nei commenti sonori presenti all'interno del file contenente l'immagine digitale). Per la normativa F, Il titolo proprio include anche ogni eventuale titolo alternativo (altre denominazioni dell'opera che appaiano insieme al titolo principale) e, facoltativamente, i complementi del titolo proprio (ossia sottotitoli od ulteriori indicazioni che contribuiscono a qualificare più specificamente il contenuto dell'immagine).rdfs:comment : This property represents the proper title of a cultural property.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/properTitle">cdesc:properTitle</a>
    /// </summary>
    let properTitle = _prefixId.prefix "properTitle"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: UB/INP/INPP^^xsd:string</para>
    ///   <para>rdfs:comment : This property represents origin of the cultural entity acquired in the heritage.rdfs:comment : Questa proprietà rappresenta, a testo libero, la provenienza del bene acquisito nel patrimonio.</para>
    ///   <para>rdfs:label : provenienzardfs:label : provenance</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/provenance">cdesc:provenance</a>
    /// </summary>
    let provenance = _prefixId.prefix "provenance"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta altre indagini cui fa riferimento un'indagine volta a elaborare una diagnosi di una paleopatologia rilevata in un reperto antropologico.rdfs:comment : This property represents other investigations referred to in a survey aimed at developing a diagnosis of a paleopathology found in an anthropological finding.</para>
    ///   <para>rdfs:label : fa riferimento a indaginirdfs:label : refers to surveys</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa AT: PT/PTC/PTCI^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/refersToSurveys">cdesc:refersToSurveys</a>
    /// </summary>
    let refersToSurveys = _prefixId.prefix "refersToSurveys"
    /// <summary>
    ///   <para>rdfs:label : data di registrazione o gazzetta ufficialerdfs:label : registration date or official journal</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta la data dell'avvenuta trascrizione al registro immobiliare, quando trattasi di vincoli imposti con leggi che richiedano la trascrizione, o il numero della Gazzetta Ufficiale su cui è stato pubblicato il decreto.rdfs:comment : This property represents the date of the registration or the number of the Official Journal on which the decree was published.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: TU/NVC/NVCR^^xsd:string</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/registrationDateOrGU">cdesc:registrationDateOrGU</a>
    /// </summary>
    let registrationDateOrGU = _prefixId.prefix "registrationDateOrGU"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà rappresenta note generali sulle relazioni instaurate fra il bene in esame e altre opere.rdfs:comment : This property represents general notes on the relationships established between the property in question and other works.</para>
    ///   <para>rdfs:label : note su opere collegaterdfs:label : related work note</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RV/REZ^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/relatedWorkNote">cdesc:relatedWorkNote</a>
    /// </summary>
    let relatedWorkNote = _prefixId.prefix "relatedWorkNote"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : relevant legal actrdfs:label : riferimento agli atti</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta, a testo libero, eventuali riferimenti a documenti (atti amministrativi; riproduzioni digitali di registri inventariali, ecc.) che interessano l'acquisizione del bene nel patrimonio. Rappresenta anche i dati relativi ai registri inventariali in vigore, ma comunque dotati di qualità storica.rdfs:comment : This property represents any references to documents that affect cultural entity acquisition.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: IUB/INP/INPO^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/relevantLegalAct">cdesc:relevantLegalAct</a>
    /// </summary>
    let relevantLegalAct = _prefixId.prefix "relevantLegalAct"
    /// <summary>
    ///   <para>rdfs:label : refertordfs:label : report</para>
    ///   <para>rdfs:comment : This property represents the report of a anthropological finding's archaeometric and diagnostic investigation.rdfs:comment : ICCD Normativa Trasversale 4.00: RE/IND/INDT - ICCD Normativa AT 3.00: IN/INI/INIR^^xsd:stringrdfs:comment : Questa proprietà rappresenta il referto di un'indagine archeometrica e diagnostica o di una tipologia particolare di bene archeologico, ovvero i reperti antropologici.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/report">cdesc:report</a>
    /// </summary>
    let report = _prefixId.prefix "report"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : riproducerdfs:label : reproduces</para>
    ///   <para>rdfs:comment : This property relates the reproduction of an print in a publication to the print itself.rdfs:comment : Questa proprietà collega la riproduzione dell'immagine contenuta nella pubblicazione di cui la stampa è, o è stata, parte integrante con la stampa stessa.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa S 3: RO/ADL</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/reproduces">cdesc:reproduces</a>
    /// </summary>
    let reproduces = _prefixId.prefix "reproduces"
    /// <summary>
    ///   <para>rdfs:label : riutilizzardfs:label : reuses</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This is the invers property of 'is reused by', which relates a cultural entity to a connected cultural entity that reuse it or a part of it.rdfs:comment : Questa è la proprietà inversa di 'è riutilizzato da', che collega un bene culturale a un altro bene culturale collegato che lo riutilizza in tutto o in parte.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/reuses">cdesc:reuses</a>
    /// </summary>
    let reuses = _prefixId.prefix "reuses"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DO/FTA/FTAY, DO/DRA/DRAY, DO/VDC/VDCY, DO/REG/REGY, DO/FNT/FNTY, DO/BIB/BIBY - ICCD Normativa MI 3.00: DA/PLC^^xsd:string</para>
    ///   <para>rdfs:comment : This property represents information on rights management.rdfs:comment : Questa proprietà rappresenta le informazioni a testo libero sulla gestione dei diritti. Nel caso di un bene culturale, permette di rappresentare indicazioni sulla presenza dei privilegi, autorizzazioni, licenze, specificando il concedente, eventualmente riportando anche il periodo di tempo della privativa.</para>
    ///   <para>rdfs:label : rightsrdfs:label : gestione diritti</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/rights">cdesc:rights</a>
    /// </summary>
    let rights = _prefixId.prefix "rights"
    /// <summary>
    ///   <para>rdfs:label : estimated sexrdfs:label : sesso stimato</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta il sesso stimato nel contesto della stima del sesso di un reperto antropologico.rdfs:comment : This property represents anthropological finding estimated sex.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/sex">cdesc:sex</a>
    /// </summary>
    let sex = _prefixId.prefix "sex"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: DT/DTS/DTSI + DT/DTS/DTSV + DT/DTS/DTSF + DT/DTS/DTSL^^xsd:string</para>
    ///   <para>rdfs:comment : Questa proprietà collega l'evento (realizzazione, demolizione, etc.) cui si riferisce una specifica cronologia di un bene culturale alla cronologia specifica, cioè la cronologia in anni (anche a cavallo di secoli diversi) o con date precise (nella forma "aaaa/mm/gg"). Nel caso in cui la cronologia corrisponda ad uno specifico anno, l'intervallo di tempo avrà lo stesso valore per data di inizio e data di fine.rdfs:comment : This property relates the event (creation, distruction) to which a dating of a cultural property is related to the "specific time", as the dating expressed in year or as a date yyyy/mm/dd.</para>
    ///   <para>rdfs:label : specific timerdfs:label : cronologia specifica</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/specificTime">cdesc:specificTime</a>
    /// </summary>
    let specificTime = _prefixId.prefix "specificTime"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega la cronologia specifica, cioè la cronologia in anni (anche a cavallo di secoli diversi) o con date precise (nella forma "aaaa/mm/gg") con l'evento (realizzazione, demolizione, etc.) cui si riferisce una specifica cronologia di un bene culturale.rdfs:comment : This property relates the "specific time", as the dating expressed in year or as a date yyyy/mm/dd, with the event (creation, distruction) to which a dating of a cultural property is related to.</para>
    ///   <para>rdfs:label : cronologia specifica dirdfs:label : specific time of</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/specificTimeOf">cdesc:specificTimeOf</a>
    /// </summary>
    let specificTimeOf = _prefixId.prefix "specificTimeOf"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : FTAR</para>
    ///   <para>rdfs:label : strip run/frame numberrdfs:label : strisciata/numero fotogramma</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta, per le foto aeree, le informazioni relative alla strisciata e al fotogramma.rdfs:comment : This property represents aerial photos information about run and frame.</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/stripRunAndFrameNumber">cdesc:stripRunAndFrameNumber</a>
    /// </summary>
    let stripRunAndFrameNumber = _prefixId.prefix "stripRunAndFrameNumber"
    /// <summary>
    ///   <para>rdfs:label : subjectrdfs:label : soggetto</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta il soggetto rappresentato da un bene culturale o il suo motivo decorativo.rdfs:comment : This property represents the subject of a cultural property, or its ornamental motif.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: DA/AID/AIDI - Normativa F: SG/SGT/SGTI - Altre normative di versioni precedenti alla 4.00: OG/SGT/SGTI</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/subject">cdesc:subject</a>
    /// </summary>
    let subject = _prefixId.prefix "subject"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta il codice identificativo che individua l'immagine presa in esame nel corso di un'indagine di fotointerpretazione o fotorestituzione.rdfs:comment : This property represents the identification code that identifies the image examined during a photo-interpretation or photo-restoration investigation.</para>
    ///   <para>rdfs:label : survey image identifierrdfs:label : identificativo immagine di indagine</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: RE/FOI/FOID^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/surveyImageIdentifier">cdesc:surveyImageIdentifier</a>
    /// </summary>
    let surveyImageIdentifier = _prefixId.prefix "surveyImageIdentifier"
    /// <summary>
    ///   <para>rdfs:comment : This property represents the author that described the species and the date of description.rdfs:comment : Questa proprietà rappresenta l'autore che ha descritto la specie e l'anno di descrizione.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa AT: OG/OGS/OGSA^^xsd:string</para>
    ///   <para>rdfs:label : taxon author and daterdfs:label : autore e data della tassonomia</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/taxonAuthorAndDate">cdesc:taxonAuthorAndDate</a>
    /// </summary>
    let taxonAuthorAndDate = _prefixId.prefix "taxonAuthorAndDate"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa AT 3.01: IN/INI/INIZ^^xsd:string</para>
    ///   <para>rdfs:label : technical documentationrdfs:label : documentazione tecnica</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta la documentazione relativa alle informazioni rilevate nel corso dell'indagine su reperto antropologico.rdfs:comment : This property represents documentation relating to information collected during survey on anthropological evidence.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/technicalDocumentation">cdesc:technicalDocumentation</a>
    /// </summary>
    let technicalDocumentation = _prefixId.prefix "technicalDocumentation"
    /// <summary>
    ///   <para>rdfs:label : titlerdfs:label : titolo</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta il titolo del soggetto di un bene culturale. La proprietà viene specificata in sottoproprietà per esprimere tipologie di titolo specifiche. Per la normativa trasversale è il titolo più noto e accreditato; nelle altre normative si specifica che è il titolo dato dall'autore o la denominazione tradizionale del soggetto.rdfs:comment : This property represents the title of a cultural property.</para>
    ///   <para>ctlog:iccdNormTag : Normativa trasversale: DA/AID/AIDT - Altre normative di versioni precedenti alla 4.00: OG/SGT/SGTT</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/title">cdesc:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: UT/UTU/UTUM - BDM 2.00: UT/UTM - SMO, PTS 3.01: DA/UTM^^xsd:string</para>
    ///   <para>rdfs:label : modalità di usordfs:label : use conditions</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/useConditions">cdesc:useConditions</a>
    /// </summary>
    let useConditions = _prefixId.prefix "useConditions"
    /// <summary>
    ///   <para>rdfs:comment : This property represents object function.rdfs:comment : Questa proprietà rappresenta la funzione che l'oggetto ha o ha avuto.</para>
    ///   <para>rdfs:label : use functionrdfs:label : funzione d'uso</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: UT/UTU/UTUF - BDM 2.00:UT/UTF - PST 3.01: DA/UTF^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/context-description/useFunction">cdesc:useFunction</a>
    /// </summary>
    let useFunction = _prefixId.prefix "useFunction"
