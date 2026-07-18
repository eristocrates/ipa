namespace http.dati.san.beniculturali.it.SAN.slash

open DoxAletheia.Rdf_Vocabulary

module san_lod =
    let _namespace_name = "http://dati.san.beniculturali.it/SAN/"

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/TesauroSAN/Estensione_data_complesso"></see>
    /// </summary>
    let ``TesauroSAN/Estensione_data_complesso`` =
        Namespaced_IRI.parse _namespace_name "TesauroSAN/Estensione_data_complesso" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/TesauroSAN/Status_scheda_provenienza"></see>
    /// </summary>
    let ``TesauroSAN/Status_scheda_provenienza`` =
        Namespaced_IRI.parse _namespace_name "TesauroSAN/Status_scheda_provenienza" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/TesauroSAN/Tematismo"></see>
    /// </summary>
    let ``TesauroSAN/Tematismo`` =
        Namespaced_IRI.parse _namespace_name "TesauroSAN/Tematismo" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/TesauroSAN/Tipo_data_esistenza_CPF"></see>
    /// </summary>
    let ``TesauroSAN/Tipo_data_esistenza_CPF`` =
        Namespaced_IRI.parse _namespace_name "TesauroSAN/Tipo_data_esistenza_CPF" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/TesauroSAN/natura_giuridica_ente"></see>
    /// </summary>
    let ``TesauroSAN/natura_giuridica_ente`` =
        Namespaced_IRI.parse _namespace_name "TesauroSAN/natura_giuridica_ente" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/TesauroSAN/sottotipologia_ente"></see>
    /// </summary>
    let ``TesauroSAN/sottotipologia_ente`` =
        Namespaced_IRI.parse _namespace_name "TesauroSAN/sottotipologia_ente" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/TesauroSAN/tipologia_Conservatore"></see>
    /// </summary>
    let ``TesauroSAN/tipologia_Conservatore`` =
        Namespaced_IRI.parse _namespace_name "TesauroSAN/tipologia_Conservatore" |> NamespacedName

    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/description/biogHist/abstract
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/abstract[@langcode]
    /// <see href="http://dati.san.beniculturali.it/SAN/abstract"></see></summary>
    let abstract_ = Namespaced_IRI.parse _namespace_name "abstract" |> NamespacedName
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/acronimo
    /// <see href="http://dati.san.beniculturali.it/SAN/acronimo"></see></summary>
    let acronimo = Namespaced_IRI.parse _namespace_name "acronimo" |> NamespacedName

    /// <summary>
    /// Il soggetto sul quale ricade la responsabilità  della conservazione e valorizzazione dell'archivio
    /// <see href="http://dati.san.beniculturali.it/SAN/conservatore"></see></summary>
    let conservatore =
        Namespaced_IRI.parse _namespace_name "conservatore" |> NamespacedName

    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/unittitle
    /// <see href="http://dati.san.beniculturali.it/SAN/altraDenominazioneComplarc"></see></summary>
    let altraDenominazioneComplarc =
        Namespaced_IRI.parse _namespace_name "altraDenominazioneComplarc" |> NamespacedName

    /// <summary>
    /// Locuzione generica per indicare un corpus documentale oggetto di descrizione.
    /// <see href="http://dati.san.beniculturali.it/SAN/complessoArchivistico"></see></summary>
    let complessoArchivistico =
        Namespaced_IRI.parse _namespace_name "complessoArchivistico" |> NamespacedName

    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/identity/nameEntry[@localType='altradenominazione']/part
    /// <see href="http://dati.san.beniculturali.it/SAN/altraDenominazioneProduttore"></see></summary>
    let altraDenominazioneProduttore =
        Namespaced_IRI.parse _namespace_name "altraDenominazioneProduttore" |> NamespacedName

    /// <summary>
    /// Soggetto (ente, famiglia o persona) che ha prodotto o acquisito per finalità  amministrative, familiari o personali il complesso archivistico oggetto di descrizione. Può essere collegato ad altri soggetti produttori con relazioni gerarchiche o temporali.
    /// <see href="http://dati.san.beniculturali.it/SAN/produttore"></see></summary>
    let produttore = Namespaced_IRI.parse _namespace_name "produttore" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/altraDenominazioneProfiloIstituzionale"></see>
    /// </summary>
    let altraDenominazioneProfiloIstituzionale =
        Namespaced_IRI.parse _namespace_name "altraDenominazioneProfiloIstituzionale" |> NamespacedName

    /// <summary>
    /// Istituzioni, preunitarie o unitarie, descritte una volta per tutte, con riferimento al periodo in cui hanno operato e al contesto storico istituzionale o statuale di appartenenza.
    /// Descrive una volta per tutte un particolare soggetto produttore, e costituisce una chiave di ricerca per tutti i soggetti produttori che appartengono al profilo descritto.
    /// <see href="http://dati.san.beniculturali.it/SAN/profiloIstituzionale"></see></summary>
    let profiloIstituzionale =
        Namespaced_IRI.parse _namespace_name "profiloIstituzionale" |> NamespacedName

    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/altroaccesso
    /// <see href="http://dati.san.beniculturali.it/SAN/altroAccesso"></see></summary>
    let altroAccesso =
        Namespaced_IRI.parse _namespace_name "altroAccesso" |> NamespacedName

    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/filedesc/titlestmt/author
    /// <see href="http://dati.san.beniculturali.it/SAN/autore"></see></summary>
    let autore = Namespaced_IRI.parse _namespace_name "autore" |> NamespacedName
    /// <summary>
    /// Repertorio - in forma di inventario analitico o sommario, elenco, elenco di versamento, elenco di consistenza, elenco numerico o altro - che descrive in maniera più o meno dettagliata un fondo o parte di esso.
    /// <see href="http://dati.san.beniculturali.it/SAN/strumento"></see></summary>
    let strumento = Namespaced_IRI.parse _namespace_name "strumento" |> NamespacedName

    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/filedesc/publicationstm/publisher
    /// <see href="http://dati.san.beniculturali.it/SAN/casaEditrice"></see></summary>
    let casaEditrice =
        Namespaced_IRI.parse _namespace_name "casaEditrice" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/codice_ISIL"></see>
    /// </summary>
    let codice_ISIL =
        Namespaced_IRI.parse _namespace_name "codice_ISIL" |> NamespacedName

    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/physdesc/extent
    /// <see href="http://dati.san.beniculturali.it/SAN/consistenza"></see></summary>
    let consistenza =
        Namespaced_IRI.parse _namespace_name "consistenza" |> NamespacedName

    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/consultazione
    /// <see href="http://dati.san.beniculturali.it/SAN/consultazione"></see></summary>
    let consultazione =
        Namespaced_IRI.parse _namespace_name "consultazione" |> NamespacedName

    /// <summary>
    /// Organizzazione istituzionale entro cui ha operato il soggetto produttore. Può trattarsi di uno Stato o di articolazioni territoriali o amministrative di esso. L'entità  statale può essere individuata con la denominazione propria di un determinato periodo storico (per es. “Repubblica di Siena”, “Granducato di Toscana””) o con le denominazioni assunte in un più lungo arco cronologico (es. "Regno d'Italia poi Repubblica italiana").
    /// <see href="http://dati.san.beniculturali.it/SAN/contestoStoricoIstituzionale"></see></summary>
    let contestoStoricoIstituzionale =
        Namespaced_IRI.parse _namespace_name "contestoStoricoIstituzionale" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/date"></see>
    /// </summary>
    let date = Namespaced_IRI.parse _namespace_name "date" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/dateCSI"></see>
    /// </summary>
    let dateCSI = Namespaced_IRI.parse _namespace_name "dateCSI" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/dateCSITesto"></see>
    /// </summary>
    let dateCSITesto =
        Namespaced_IRI.parse _namespace_name "dateCSITesto" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/dateComplarc"></see>
    /// </summary>
    let dateComplarc =
        Namespaced_IRI.parse _namespace_name "dateComplarc" |> NamespacedName

    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/unitdate[@datechar='principale']/@normal
    /// <see href="http://dati.san.beniculturali.it/SAN/dateComplarcNormal"></see></summary>
    let dateComplarcNormal =
        Namespaced_IRI.parse _namespace_name "dateComplarcNormal" |> NamespacedName

    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/unitdate[@datechar='principale']
    /// <see href="http://dati.san.beniculturali.it/SAN/dateComplarcTesto"></see></summary>
    let dateComplarcTesto =
        Namespaced_IRI.parse _namespace_name "dateComplarcTesto" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/dateEsistenza"></see>
    /// </summary>
    let dateEsistenza =
        Namespaced_IRI.parse _namespace_name "dateEsistenza" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/dateEsistenzaNormal"></see>
    /// </summary>
    let dateEsistenzaNormal =
        Namespaced_IRI.parse _namespace_name "dateEsistenzaNormal" |> NamespacedName

    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/description/existDates/dateSet/date
    /// <see href="http://dati.san.beniculturali.it/SAN/dateEsistenzaTesto"></see></summary>
    let dateEsistenzaTesto =
        Namespaced_IRI.parse _namespace_name "dateEsistenzaTesto" |> NamespacedName

    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/relations/cpfRelation/date
    /// <see href="http://dati.san.beniculturali.it/SAN/dateQualificazioniRelCpf"></see></summary>
    let dateQualificazioniRelCpf =
        Namespaced_IRI.parse _namespace_name "dateQualificazioniRelCpf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/qualificazioniRelazioniCpf"></see>
    /// </summary>
    let qualificazioniRelazioniCpf =
        Namespaced_IRI.parse _namespace_name "qualificazioniRelazioniCpf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/dateStrumento"></see>
    /// </summary>
    let dateStrumento =
        Namespaced_IRI.parse _namespace_name "dateStrumento" |> NamespacedName

    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/filedesc/publicationstm/date
    /// <see href="http://dati.san.beniculturali.it/SAN/dateStrumentoTesto"></see></summary>
    let dateStrumentoTesto =
        Namespaced_IRI.parse _namespace_name "dateStrumentoTesto" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/denominazioneCSI"></see>
    /// </summary>
    let denominazioneCSI =
        Namespaced_IRI.parse _namespace_name "denominazioneCSI" |> NamespacedName

    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/filedesc/notestmt/note
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/descrizione
    /// <see href="http://dati.san.beniculturali.it/SAN/descrizione"></see></summary>
    let descrizione =
        Namespaced_IRI.parse _namespace_name "descrizione" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/descrizioneCSI"></see>
    /// </summary>
    let descrizioneCSI =
        Namespaced_IRI.parse _namespace_name "descrizioneCSI" |> NamespacedName

    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/filedesc/notestmt/note/@type
    /// <see href="http://dati.san.beniculturali.it/SAN/edito"></see></summary>
    let edito = Namespaced_IRI.parse _namespace_name "edito" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/ente"></see>
    /// </summary>
    let ente = Namespaced_IRI.parse _namespace_name "ente" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/famiglia"></see>
    /// </summary>
    let famiglia = Namespaced_IRI.parse _namespace_name "famiglia" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/persona"></see>
    /// </summary>
    let persona = Namespaced_IRI.parse _namespace_name "persona" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/estensioneDateComplarc"></see>
    /// </summary>
    let estensioneDateComplarc =
        Namespaced_IRI.parse _namespace_name "estensioneDateComplarc" |> NamespacedName

    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/unitdate/@normal
    /// <see href="http://dati.san.beniculturali.it/SAN/estensioneDateNormal"></see></summary>
    let estensioneDateNormal =
        Namespaced_IRI.parse _namespace_name "estensioneDateNormal" |> NamespacedName

    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/unittitle
    /// <see href="http://dati.san.beniculturali.it/SAN/formaAutorizzataComplarc"></see></summary>
    let formaAutorizzataComplarc =
        Namespaced_IRI.parse _namespace_name "formaAutorizzataComplarc" |> NamespacedName

    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/formaautorizzata
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/formeparallele
    /// <see href="http://dati.san.beniculturali.it/SAN/formaAutorizzataConservatore"></see></summary>
    let formaAutorizzataConservatore =
        Namespaced_IRI.parse _namespace_name "formaAutorizzataConservatore" |> NamespacedName

    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/identity/nameEntry/part
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/identity/nameEntryParallel/nameEntry/part[@langcode]
    /// <see href="http://dati.san.beniculturali.it/SAN/formaAutorizzataProduttore"></see></summary>
    let formaAutorizzataProduttore =
        Namespaced_IRI.parse _namespace_name "formaAutorizzataProduttore" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/formaAutorizzataProfiloIstituzionale"></see>
    /// </summary>
    let formaAutorizzataProfiloIstituzionale =
        Namespaced_IRI.parse _namespace_name "formaAutorizzataProfiloIstituzionale" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_CSI"></see>
    /// </summary>
    let has_CSI = Namespaced_IRI.parse _namespace_name "has_CSI" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_conservatore"></see>
    /// </summary>
    let has_conservatore =
        Namespaced_IRI.parse _namespace_name "has_conservatore" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_cpf"></see>
    /// </summary>
    let has_cpf = Namespaced_IRI.parse _namespace_name "has_cpf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_dateCSI"></see>
    /// </summary>
    let has_dateCSI =
        Namespaced_IRI.parse _namespace_name "has_dateCSI" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_dateComplarc"></see>
    /// </summary>
    let has_dateComplarc =
        Namespaced_IRI.parse _namespace_name "has_dateComplarc" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_dateEsistenza"></see>
    /// </summary>
    let has_dateEsistenza =
        Namespaced_IRI.parse _namespace_name "has_dateEsistenza" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_dateEsistenzaTipo"></see>
    /// </summary>
    let has_dateEsistenzaTipo =
        Namespaced_IRI.parse _namespace_name "has_dateEsistenzaTipo" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_dateStrumento"></see>
    /// </summary>
    let has_dateStrumento =
        Namespaced_IRI.parse _namespace_name "has_dateStrumento" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_estensioneDateComplarc"></see>
    /// </summary>
    let has_estensioneDateComplarc =
        Namespaced_IRI.parse _namespace_name "has_estensioneDateComplarc" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_estensioneDateTipo"></see>
    /// </summary>
    let has_estensioneDateTipo =
        Namespaced_IRI.parse _namespace_name "has_estensioneDateTipo" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_livelloSuperiore"></see>
    /// </summary>
    let has_livelloSuperiore =
        Namespaced_IRI.parse _namespace_name "has_livelloSuperiore" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_luogoAmbitoTerritoriale"></see>
    /// </summary>
    let has_luogoAmbitoTerritoriale =
        Namespaced_IRI.parse _namespace_name "has_luogoAmbitoTerritoriale" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_luogoProduttore"></see>
    /// </summary>
    let has_luogoProduttore =
        Namespaced_IRI.parse _namespace_name "has_luogoProduttore" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_luogoConservatore"></see>
    /// </summary>
    let has_luogoConservatore =
        Namespaced_IRI.parse _namespace_name "has_luogoConservatore" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/luogoConservatore"></see>
    /// </summary>
    let luogoConservatore =
        Namespaced_IRI.parse _namespace_name "luogoConservatore" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_luogoGiurisdizione"></see>
    /// </summary>
    let has_luogoGiurisdizione =
        Namespaced_IRI.parse _namespace_name "has_luogoGiurisdizione" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_luogoMorte"></see>
    /// </summary>
    let has_luogoMorte =
        Namespaced_IRI.parse _namespace_name "has_luogoMorte" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_luogoNascita"></see>
    /// </summary>
    let has_luogoNascita =
        Namespaced_IRI.parse _namespace_name "has_luogoNascita" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/luogo"></see>
    /// </summary>
    let luogo = Namespaced_IRI.parse _namespace_name "luogo" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_luogoResidenza"></see>
    /// </summary>
    let has_luogoResidenza =
        Namespaced_IRI.parse _namespace_name "has_luogoResidenza" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_luogoSede"></see>
    /// </summary>
    let has_luogoSede =
        Namespaced_IRI.parse _namespace_name "has_luogoSede" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_natura_giuridica_ente"></see>
    /// </summary>
    let has_natura_giuridica_ente =
        Namespaced_IRI.parse _namespace_name "has_natura_giuridica_ente" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_produttore"></see>
    /// </summary>
    let has_produttore =
        Namespaced_IRI.parse _namespace_name "has_produttore" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_qualificazioniRelazioniCpf"></see>
    /// </summary>
    let has_qualificazioniRelazioniCpf =
        Namespaced_IRI.parse _namespace_name "has_qualificazioniRelazioniCpf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_relazionePI"></see>
    /// </summary>
    let has_relazionePI =
        Namespaced_IRI.parse _namespace_name "has_relazionePI" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_relazioneProduttore"></see>
    /// </summary>
    let has_relazioneProduttore =
        Namespaced_IRI.parse _namespace_name "has_relazioneProduttore" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_sitoWeb"></see>
    /// </summary>
    let has_sitoWeb =
        Namespaced_IRI.parse _namespace_name "has_sitoWeb" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/sitoWeb"></see>
    /// </summary>
    let sitoWeb = Namespaced_IRI.parse _namespace_name "sitoWeb" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_sottotipologia_ente"></see>
    /// </summary>
    let has_sottotipologia_ente =
        Namespaced_IRI.parse _namespace_name "has_sottotipologia_ente" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_statusProvenienza"></see>
    /// </summary>
    let has_statusProvenienza =
        Namespaced_IRI.parse _namespace_name "has_statusProvenienza" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_strumentoDiRicerca"></see>
    /// </summary>
    let has_strumentoDiRicerca =
        Namespaced_IRI.parse _namespace_name "has_strumentoDiRicerca" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_strumentoDigitale"></see>
    /// </summary>
    let has_strumentoDigitale =
        Namespaced_IRI.parse _namespace_name "has_strumentoDigitale" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/strumentoDigitale"></see>
    /// </summary>
    let strumentoDigitale =
        Namespaced_IRI.parse _namespace_name "strumentoDigitale" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_tematismo"></see>
    /// </summary>
    let has_tematismo =
        Namespaced_IRI.parse _namespace_name "has_tematismo" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_tipologia"></see>
    /// </summary>
    let has_tipologia =
        Namespaced_IRI.parse _namespace_name "has_tipologia" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/indirizzo"></see>
    /// </summary>
    let indirizzo = Namespaced_IRI.parse _namespace_name "indirizzo" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/isConservatoreOf"></see>
    /// </summary>
    let isConservatoreOf =
        Namespaced_IRI.parse _namespace_name "isConservatoreOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/isProduttoreOf"></see>
    /// </summary>
    let isProduttoreOf =
        Namespaced_IRI.parse _namespace_name "isProduttoreOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/isStrumentoDiRicercaOf"></see>
    /// </summary>
    let isStrumentoDiRicercaOf =
        Namespaced_IRI.parse _namespace_name "isStrumentoDiRicercaOf" |> NamespacedName

    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/localizzazione/@cap
    /// <see href="http://dati.san.beniculturali.it/SAN/luogoCAP"></see></summary>
    let luogoCAP = Namespaced_IRI.parse _namespace_name "luogoCAP" |> NamespacedName

    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/localizzazione/@comune
    /// <see href="http://dati.san.beniculturali.it/SAN/luogoComune"></see></summary>
    let luogoComune =
        Namespaced_IRI.parse _namespace_name "luogoComune" |> NamespacedName

    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/localizzazione/@paese
    /// <see href="http://dati.san.beniculturali.it/SAN/luogoPaese"></see></summary>
    let luogoPaese = Namespaced_IRI.parse _namespace_name "luogoPaese" |> NamespacedName

    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/localizzazione/@provincia
    /// <see href="http://dati.san.beniculturali.it/SAN/luogoProvincia"></see></summary>
    let luogoProvincia =
        Namespaced_IRI.parse _namespace_name "luogoProvincia" |> NamespacedName

    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/filedesc/publicationstm/address
    /// <see href="http://dati.san.beniculturali.it/SAN/luogoPubblicazione"></see></summary>
    let luogoPubblicazione =
        Namespaced_IRI.parse _namespace_name "luogoPubblicazione" |> NamespacedName

    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/placeDates/placeDate/place
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/localizzazione
    /// <see href="http://dati.san.beniculturali.it/SAN/luogoTesto"></see></summary>
    let luogoTesto = Namespaced_IRI.parse _namespace_name "luogoTesto" |> NamespacedName
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/orario
    /// <see href="http://dati.san.beniculturali.it/SAN/orario"></see></summary>
    let orario = Namespaced_IRI.parse _namespace_name "orario" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/ordinamento"></see>
    /// </summary>
    let ordinamento =
        Namespaced_IRI.parse _namespace_name "ordinamento" |> NamespacedName

    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/description/descriptiveEntries/descriptiveEntry/term
    /// <see href="http://dati.san.beniculturali.it/SAN/professione"></see></summary>
    let professione =
        Namespaced_IRI.parse _namespace_name "professione" |> NamespacedName

    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/unitid
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/control/otherRecordId
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/eadid
    /// <see href="http://dati.san.beniculturali.it/SAN/recordProvenienzaId"></see></summary>
    let recordProvenienzaId =
        Namespaced_IRI.parse _namespace_name "recordProvenienzaId" |> NamespacedName

    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/unitid/@identifier
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/control/sources/source/@xlink:href
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/eadid/@URL
    /// <see href="http://dati.san.beniculturali.it/SAN/schedaProvenienzaHref"></see></summary>
    let schedaProvenienzaHref =
        Namespaced_IRI.parse _namespace_name "schedaProvenienzaHref" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/schedaSAN"></see>
    /// </summary>
    let schedaSAN = Namespaced_IRI.parse _namespace_name "schedaSAN" |> NamespacedName
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/servizi
    /// <see href="http://dati.san.beniculturali.it/SAN/servizi"></see></summary>
    let servizi = Namespaced_IRI.parse _namespace_name "servizi" |> NamespacedName

    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/eadid/@identifier
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/unitid/@type
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/control/otherRecordId/@localtype
    /// <see href="http://dati.san.beniculturali.it/SAN/sistemaProvenienza"></see></summary>
    let sistemaProvenienza =
        Namespaced_IRI.parse _namespace_name "sistemaProvenienza" |> NamespacedName

    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/sitoweb/@href
    /// <see href="http://dati.san.beniculturali.it/SAN/sitoWebHref"></see></summary>
    let sitoWebHref =
        Namespaced_IRI.parse _namespace_name "sitoWebHref" |> NamespacedName

    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/sitoweb
    /// <see href="http://dati.san.beniculturali.it/SAN/sitoWebTesto"></see></summary>
    let sitoWebTesto =
        Namespaced_IRI.parse _namespace_name "sitoWebTesto" |> NamespacedName

    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/filedesc/editionstmt/edition/extptr/@href
    /// <see href="http://dati.san.beniculturali.it/SAN/strumentoDigitaleLink"></see></summary>
    let strumentoDigitaleLink =
        Namespaced_IRI.parse _namespace_name "strumentoDigitaleLink" |> NamespacedName

    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/filedesc/editionstmt/edition/extptr/@title
    /// <see href="http://dati.san.beniculturali.it/SAN/strumentoDigitaleTitolo"></see></summary>
    let strumentoDigitaleTitolo =
        Namespaced_IRI.parse _namespace_name "strumentoDigitaleTitolo" |> NamespacedName

    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/relations/cpfRelation/@localType
    /// <see href="http://dati.san.beniculturali.it/SAN/tipoQualificazioniRelCpf"></see></summary>
    let tipoQualificazioniRelCpf =
        Namespaced_IRI.parse _namespace_name "tipoQualificazioniRelCpf" |> NamespacedName

    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc[@level='otherlevel']/@otherlevel
    /// <see href="http://dati.san.beniculturali.it/SAN/tipologiaComplesso"></see></summary>
    let tipologiaComplesso =
        Namespaced_IRI.parse _namespace_name "tipologiaComplesso" |> NamespacedName

    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/filedesc/titlestmt/titleproper
    /// <see href="http://dati.san.beniculturali.it/SAN/titolo"></see></summary>
    let titolo = Namespaced_IRI.parse _namespace_name "titolo" |> NamespacedName

    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/description/descriptiveEntries/descriptiveEntry/term
    /// <see href="http://dati.san.beniculturali.it/SAN/titolo_nobiliare"></see></summary>
    let titolo_nobiliare =
        Namespaced_IRI.parse _namespace_name "titolo_nobiliare" |> NamespacedName
