namespace http.dati.san.beniculturali.it.SAN.slash

open DoxAletheia

module san_lod =
    let _namespace_name = "http://dati.san.beniculturali.it/SAN/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/TesauroSAN/Estensione_data_complesso"></see>
    /// </summary>
    let ``TesauroSAN/Estensione_data_complesso`` =
        _prefix "TesauroSAN/Estensione_data_complesso"

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/TesauroSAN/Status_scheda_provenienza"></see>
    /// </summary>
    let ``TesauroSAN/Status_scheda_provenienza`` =
        _prefix "TesauroSAN/Status_scheda_provenienza"

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/TesauroSAN/Tematismo"></see>
    /// </summary>
    let ``TesauroSAN/Tematismo`` = _prefix "TesauroSAN/Tematismo"

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/TesauroSAN/Tipo_data_esistenza_CPF"></see>
    /// </summary>
    let ``TesauroSAN/Tipo_data_esistenza_CPF`` =
        _prefix "TesauroSAN/Tipo_data_esistenza_CPF"

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/TesauroSAN/natura_giuridica_ente"></see>
    /// </summary>
    let ``TesauroSAN/natura_giuridica_ente`` =
        _prefix "TesauroSAN/natura_giuridica_ente"

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/TesauroSAN/sottotipologia_ente"></see>
    /// </summary>
    let ``TesauroSAN/sottotipologia_ente`` = _prefix "TesauroSAN/sottotipologia_ente"

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/TesauroSAN/tipologia_Conservatore"></see>
    /// </summary>
    let ``TesauroSAN/tipologia_Conservatore`` =
        _prefix "TesauroSAN/tipologia_Conservatore"

    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/description/biogHist/abstract
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/abstract[@langcode]
    /// <see href="http://dati.san.beniculturali.it/SAN/abstract"></see></summary>
    let abstract_ = _prefix "abstract"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/acronimo
    /// <see href="http://dati.san.beniculturali.it/SAN/acronimo"></see></summary>
    let acronimo = _prefix "acronimo"
    /// <summary>
    /// Il soggetto sul quale ricade la responsabilità  della conservazione e valorizzazione dell'archivio
    /// <see href="http://dati.san.beniculturali.it/SAN/conservatore"></see></summary>
    let conservatore = _prefix "conservatore"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/unittitle
    /// <see href="http://dati.san.beniculturali.it/SAN/altraDenominazioneComplarc"></see></summary>
    let altraDenominazioneComplarc = _prefix "altraDenominazioneComplarc"
    /// <summary>
    /// Locuzione generica per indicare un corpus documentale oggetto di descrizione.
    /// <see href="http://dati.san.beniculturali.it/SAN/complessoArchivistico"></see></summary>
    let complessoArchivistico = _prefix "complessoArchivistico"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/identity/nameEntry[@localType='altradenominazione']/part
    /// <see href="http://dati.san.beniculturali.it/SAN/altraDenominazioneProduttore"></see></summary>
    let altraDenominazioneProduttore = _prefix "altraDenominazioneProduttore"
    /// <summary>
    /// Soggetto (ente, famiglia o persona) che ha prodotto o acquisito per finalità  amministrative, familiari o personali il complesso archivistico oggetto di descrizione. Può essere collegato ad altri soggetti produttori con relazioni gerarchiche o temporali.
    /// <see href="http://dati.san.beniculturali.it/SAN/produttore"></see></summary>
    let produttore = _prefix "produttore"

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/altraDenominazioneProfiloIstituzionale"></see>
    /// </summary>
    let altraDenominazioneProfiloIstituzionale =
        _prefix "altraDenominazioneProfiloIstituzionale"

    /// <summary>
    /// Istituzioni, preunitarie o unitarie, descritte una volta per tutte, con riferimento al periodo in cui hanno operato e al contesto storico istituzionale o statuale di appartenenza.
    /// Descrive una volta per tutte un particolare soggetto produttore, e costituisce una chiave di ricerca per tutti i soggetti produttori che appartengono al profilo descritto.
    /// <see href="http://dati.san.beniculturali.it/SAN/profiloIstituzionale"></see></summary>
    let profiloIstituzionale = _prefix "profiloIstituzionale"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/altroaccesso
    /// <see href="http://dati.san.beniculturali.it/SAN/altroAccesso"></see></summary>
    let altroAccesso = _prefix "altroAccesso"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/filedesc/titlestmt/author
    /// <see href="http://dati.san.beniculturali.it/SAN/autore"></see></summary>
    let autore = _prefix "autore"
    /// <summary>
    /// Repertorio - in forma di inventario analitico o sommario, elenco, elenco di versamento, elenco di consistenza, elenco numerico o altro - che descrive in maniera più o meno dettagliata un fondo o parte di esso.
    /// <see href="http://dati.san.beniculturali.it/SAN/strumento"></see></summary>
    let strumento = _prefix "strumento"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/filedesc/publicationstm/publisher
    /// <see href="http://dati.san.beniculturali.it/SAN/casaEditrice"></see></summary>
    let casaEditrice = _prefix "casaEditrice"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/codice_ISIL"></see>
    /// </summary>
    let codice_ISIL = _prefix "codice_ISIL"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/physdesc/extent
    /// <see href="http://dati.san.beniculturali.it/SAN/consistenza"></see></summary>
    let consistenza = _prefix "consistenza"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/consultazione
    /// <see href="http://dati.san.beniculturali.it/SAN/consultazione"></see></summary>
    let consultazione = _prefix "consultazione"
    /// <summary>
    /// Organizzazione istituzionale entro cui ha operato il soggetto produttore. Può trattarsi di uno Stato o di articolazioni territoriali o amministrative di esso. L'entità  statale può essere individuata con la denominazione propria di un determinato periodo storico (per es. “Repubblica di Siena”, “Granducato di Toscana””) o con le denominazioni assunte in un più lungo arco cronologico (es. "Regno d'Italia poi Repubblica italiana").
    /// <see href="http://dati.san.beniculturali.it/SAN/contestoStoricoIstituzionale"></see></summary>
    let contestoStoricoIstituzionale = _prefix "contestoStoricoIstituzionale"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/date"></see>
    /// </summary>
    let date = _prefix "date"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/dateCSI"></see>
    /// </summary>
    let dateCSI = _prefix "dateCSI"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/dateCSITesto"></see>
    /// </summary>
    let dateCSITesto = _prefix "dateCSITesto"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/dateComplarc"></see>
    /// </summary>
    let dateComplarc = _prefix "dateComplarc"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/unitdate[@datechar='principale']/@normal
    /// <see href="http://dati.san.beniculturali.it/SAN/dateComplarcNormal"></see></summary>
    let dateComplarcNormal = _prefix "dateComplarcNormal"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/unitdate[@datechar='principale']
    /// <see href="http://dati.san.beniculturali.it/SAN/dateComplarcTesto"></see></summary>
    let dateComplarcTesto = _prefix "dateComplarcTesto"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/dateEsistenza"></see>
    /// </summary>
    let dateEsistenza = _prefix "dateEsistenza"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/dateEsistenzaNormal"></see>
    /// </summary>
    let dateEsistenzaNormal = _prefix "dateEsistenzaNormal"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/description/existDates/dateSet/date
    /// <see href="http://dati.san.beniculturali.it/SAN/dateEsistenzaTesto"></see></summary>
    let dateEsistenzaTesto = _prefix "dateEsistenzaTesto"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/relations/cpfRelation/date
    /// <see href="http://dati.san.beniculturali.it/SAN/dateQualificazioniRelCpf"></see></summary>
    let dateQualificazioniRelCpf = _prefix "dateQualificazioniRelCpf"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/qualificazioniRelazioniCpf"></see>
    /// </summary>
    let qualificazioniRelazioniCpf = _prefix "qualificazioniRelazioniCpf"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/dateStrumento"></see>
    /// </summary>
    let dateStrumento = _prefix "dateStrumento"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/filedesc/publicationstm/date
    /// <see href="http://dati.san.beniculturali.it/SAN/dateStrumentoTesto"></see></summary>
    let dateStrumentoTesto = _prefix "dateStrumentoTesto"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/denominazioneCSI"></see>
    /// </summary>
    let denominazioneCSI = _prefix "denominazioneCSI"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/filedesc/notestmt/note
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/descrizione
    /// <see href="http://dati.san.beniculturali.it/SAN/descrizione"></see></summary>
    let descrizione = _prefix "descrizione"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/descrizioneCSI"></see>
    /// </summary>
    let descrizioneCSI = _prefix "descrizioneCSI"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/filedesc/notestmt/note/@type
    /// <see href="http://dati.san.beniculturali.it/SAN/edito"></see></summary>
    let edito = _prefix "edito"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/ente"></see>
    /// </summary>
    let ente = _prefix "ente"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/famiglia"></see>
    /// </summary>
    let famiglia = _prefix "famiglia"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/persona"></see>
    /// </summary>
    let persona = _prefix "persona"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/estensioneDateComplarc"></see>
    /// </summary>
    let estensioneDateComplarc = _prefix "estensioneDateComplarc"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/unitdate/@normal
    /// <see href="http://dati.san.beniculturali.it/SAN/estensioneDateNormal"></see></summary>
    let estensioneDateNormal = _prefix "estensioneDateNormal"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/unittitle
    /// <see href="http://dati.san.beniculturali.it/SAN/formaAutorizzataComplarc"></see></summary>
    let formaAutorizzataComplarc = _prefix "formaAutorizzataComplarc"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/formaautorizzata
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/formeparallele
    /// <see href="http://dati.san.beniculturali.it/SAN/formaAutorizzataConservatore"></see></summary>
    let formaAutorizzataConservatore = _prefix "formaAutorizzataConservatore"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/identity/nameEntry/part
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/identity/nameEntryParallel/nameEntry/part[@langcode]
    /// <see href="http://dati.san.beniculturali.it/SAN/formaAutorizzataProduttore"></see></summary>
    let formaAutorizzataProduttore = _prefix "formaAutorizzataProduttore"

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/formaAutorizzataProfiloIstituzionale"></see>
    /// </summary>
    let formaAutorizzataProfiloIstituzionale =
        _prefix "formaAutorizzataProfiloIstituzionale"

    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_CSI"></see>
    /// </summary>
    let has_CSI = _prefix "has_CSI"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_conservatore"></see>
    /// </summary>
    let has_conservatore = _prefix "has_conservatore"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_cpf"></see>
    /// </summary>
    let has_cpf = _prefix "has_cpf"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_dateCSI"></see>
    /// </summary>
    let has_dateCSI = _prefix "has_dateCSI"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_dateComplarc"></see>
    /// </summary>
    let has_dateComplarc = _prefix "has_dateComplarc"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_dateEsistenza"></see>
    /// </summary>
    let has_dateEsistenza = _prefix "has_dateEsistenza"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_dateEsistenzaTipo"></see>
    /// </summary>
    let has_dateEsistenzaTipo = _prefix "has_dateEsistenzaTipo"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_dateStrumento"></see>
    /// </summary>
    let has_dateStrumento = _prefix "has_dateStrumento"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_estensioneDateComplarc"></see>
    /// </summary>
    let has_estensioneDateComplarc = _prefix "has_estensioneDateComplarc"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_estensioneDateTipo"></see>
    /// </summary>
    let has_estensioneDateTipo = _prefix "has_estensioneDateTipo"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_livelloSuperiore"></see>
    /// </summary>
    let has_livelloSuperiore = _prefix "has_livelloSuperiore"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_luogoAmbitoTerritoriale"></see>
    /// </summary>
    let has_luogoAmbitoTerritoriale = _prefix "has_luogoAmbitoTerritoriale"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_luogoProduttore"></see>
    /// </summary>
    let has_luogoProduttore = _prefix "has_luogoProduttore"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_luogoConservatore"></see>
    /// </summary>
    let has_luogoConservatore = _prefix "has_luogoConservatore"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/luogoConservatore"></see>
    /// </summary>
    let luogoConservatore = _prefix "luogoConservatore"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_luogoGiurisdizione"></see>
    /// </summary>
    let has_luogoGiurisdizione = _prefix "has_luogoGiurisdizione"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_luogoMorte"></see>
    /// </summary>
    let has_luogoMorte = _prefix "has_luogoMorte"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_luogoNascita"></see>
    /// </summary>
    let has_luogoNascita = _prefix "has_luogoNascita"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/luogo"></see>
    /// </summary>
    let luogo = _prefix "luogo"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_luogoResidenza"></see>
    /// </summary>
    let has_luogoResidenza = _prefix "has_luogoResidenza"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_luogoSede"></see>
    /// </summary>
    let has_luogoSede = _prefix "has_luogoSede"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_natura_giuridica_ente"></see>
    /// </summary>
    let has_natura_giuridica_ente = _prefix "has_natura_giuridica_ente"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_produttore"></see>
    /// </summary>
    let has_produttore = _prefix "has_produttore"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_qualificazioniRelazioniCpf"></see>
    /// </summary>
    let has_qualificazioniRelazioniCpf = _prefix "has_qualificazioniRelazioniCpf"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_relazionePI"></see>
    /// </summary>
    let has_relazionePI = _prefix "has_relazionePI"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_relazioneProduttore"></see>
    /// </summary>
    let has_relazioneProduttore = _prefix "has_relazioneProduttore"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_sitoWeb"></see>
    /// </summary>
    let has_sitoWeb = _prefix "has_sitoWeb"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/sitoWeb"></see>
    /// </summary>
    let sitoWeb = _prefix "sitoWeb"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_sottotipologia_ente"></see>
    /// </summary>
    let has_sottotipologia_ente = _prefix "has_sottotipologia_ente"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_statusProvenienza"></see>
    /// </summary>
    let has_statusProvenienza = _prefix "has_statusProvenienza"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_strumentoDiRicerca"></see>
    /// </summary>
    let has_strumentoDiRicerca = _prefix "has_strumentoDiRicerca"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_strumentoDigitale"></see>
    /// </summary>
    let has_strumentoDigitale = _prefix "has_strumentoDigitale"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/strumentoDigitale"></see>
    /// </summary>
    let strumentoDigitale = _prefix "strumentoDigitale"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_tematismo"></see>
    /// </summary>
    let has_tematismo = _prefix "has_tematismo"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/has_tipologia"></see>
    /// </summary>
    let has_tipologia = _prefix "has_tipologia"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/indirizzo"></see>
    /// </summary>
    let indirizzo = _prefix "indirizzo"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/isConservatoreOf"></see>
    /// </summary>
    let isConservatoreOf = _prefix "isConservatoreOf"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/isProduttoreOf"></see>
    /// </summary>
    let isProduttoreOf = _prefix "isProduttoreOf"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/isStrumentoDiRicercaOf"></see>
    /// </summary>
    let isStrumentoDiRicercaOf = _prefix "isStrumentoDiRicercaOf"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/localizzazione/@cap
    /// <see href="http://dati.san.beniculturali.it/SAN/luogoCAP"></see></summary>
    let luogoCAP = _prefix "luogoCAP"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/localizzazione/@comune
    /// <see href="http://dati.san.beniculturali.it/SAN/luogoComune"></see></summary>
    let luogoComune = _prefix "luogoComune"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/localizzazione/@paese
    /// <see href="http://dati.san.beniculturali.it/SAN/luogoPaese"></see></summary>
    let luogoPaese = _prefix "luogoPaese"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/localizzazione/@provincia
    /// <see href="http://dati.san.beniculturali.it/SAN/luogoProvincia"></see></summary>
    let luogoProvincia = _prefix "luogoProvincia"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/filedesc/publicationstm/address
    /// <see href="http://dati.san.beniculturali.it/SAN/luogoPubblicazione"></see></summary>
    let luogoPubblicazione = _prefix "luogoPubblicazione"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/placeDates/placeDate/place
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/localizzazione
    /// <see href="http://dati.san.beniculturali.it/SAN/luogoTesto"></see></summary>
    let luogoTesto = _prefix "luogoTesto"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/orario
    /// <see href="http://dati.san.beniculturali.it/SAN/orario"></see></summary>
    let orario = _prefix "orario"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/ordinamento"></see>
    /// </summary>
    let ordinamento = _prefix "ordinamento"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/description/descriptiveEntries/descriptiveEntry/term
    /// <see href="http://dati.san.beniculturali.it/SAN/professione"></see></summary>
    let professione = _prefix "professione"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/unitid
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/control/otherRecordId
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/eadid
    /// <see href="http://dati.san.beniculturali.it/SAN/recordProvenienzaId"></see></summary>
    let recordProvenienzaId = _prefix "recordProvenienzaId"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/unitid/@identifier
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/control/sources/source/@xlink:href
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/eadid/@URL
    /// <see href="http://dati.san.beniculturali.it/SAN/schedaProvenienzaHref"></see></summary>
    let schedaProvenienzaHref = _prefix "schedaProvenienzaHref"
    /// <summary>
    ///   <see href="http://dati.san.beniculturali.it/SAN/schedaSAN"></see>
    /// </summary>
    let schedaSAN = _prefix "schedaSAN"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/servizi
    /// <see href="http://dati.san.beniculturali.it/SAN/servizi"></see></summary>
    let servizi = _prefix "servizi"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/eadid/@identifier
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/unitid/@type
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/control/otherRecordId/@localtype
    /// <see href="http://dati.san.beniculturali.it/SAN/sistemaProvenienza"></see></summary>
    let sistemaProvenienza = _prefix "sistemaProvenienza"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/sitoweb/@href
    /// <see href="http://dati.san.beniculturali.it/SAN/sitoWebHref"></see></summary>
    let sitoWebHref = _prefix "sitoWebHref"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/sitoweb
    /// <see href="http://dati.san.beniculturali.it/SAN/sitoWebTesto"></see></summary>
    let sitoWebTesto = _prefix "sitoWebTesto"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/filedesc/editionstmt/edition/extptr/@href
    /// <see href="http://dati.san.beniculturali.it/SAN/strumentoDigitaleLink"></see></summary>
    let strumentoDigitaleLink = _prefix "strumentoDigitaleLink"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/filedesc/editionstmt/edition/extptr/@title
    /// <see href="http://dati.san.beniculturali.it/SAN/strumentoDigitaleTitolo"></see></summary>
    let strumentoDigitaleTitolo = _prefix "strumentoDigitaleTitolo"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/relations/cpfRelation/@localType
    /// <see href="http://dati.san.beniculturali.it/SAN/tipoQualificazioniRelCpf"></see></summary>
    let tipoQualificazioniRelCpf = _prefix "tipoQualificazioniRelCpf"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc[@level='otherlevel']/@otherlevel
    /// <see href="http://dati.san.beniculturali.it/SAN/tipologiaComplesso"></see></summary>
    let tipologiaComplesso = _prefix "tipologiaComplesso"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/filedesc/titlestmt/titleproper
    /// <see href="http://dati.san.beniculturali.it/SAN/titolo"></see></summary>
    let titolo = _prefix "titolo"
    /// <summary>
    /// Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/description/descriptiveEntries/descriptiveEntry/term
    /// <see href="http://dati.san.beniculturali.it/SAN/titolo_nobiliare"></see></summary>
    let titolo_nobiliare = _prefix "titolo_nobiliare"
