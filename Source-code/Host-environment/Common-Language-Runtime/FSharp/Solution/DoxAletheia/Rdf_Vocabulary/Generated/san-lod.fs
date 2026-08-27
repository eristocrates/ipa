namespace http.dati.san.beniculturali.it.SAN.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module san_lod =
    let _namespace_iri = Namespace_Iri san_lod |> NamespaceIRI
    /// <summary>
    ///   <para>san-lod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/">http://dati.san.beniculturali.it/SAN/</seealso>
    let _prefix_iri = Prefixed_Name(san_lod, "") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:TesauroSAN/Estensione_data_complesso</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/TesauroSAN/Estensione_data_complesso">http://dati.san.beniculturali.it/SAN/TesauroSAN/Estensione_data_complesso</seealso>
    let ``TesauroSAN/Estensione_data_complesso`` =
        Prefixed_Name(san_lod, "TesauroSAN/Estensione_data_complesso") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:TesauroSAN/Status_scheda_provenienza</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/TesauroSAN/Status_scheda_provenienza">http://dati.san.beniculturali.it/SAN/TesauroSAN/Status_scheda_provenienza</seealso>
    let ``TesauroSAN/Status_scheda_provenienza`` =
        Prefixed_Name(san_lod, "TesauroSAN/Status_scheda_provenienza") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:TesauroSAN/Tematismo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/TesauroSAN/Tematismo">http://dati.san.beniculturali.it/SAN/TesauroSAN/Tematismo</seealso>
    let ``TesauroSAN/Tematismo`` =
        Prefixed_Name(san_lod, "TesauroSAN/Tematismo") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:TesauroSAN/Tipo_data_esistenza_CPF</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/TesauroSAN/Tipo_data_esistenza_CPF">http://dati.san.beniculturali.it/SAN/TesauroSAN/Tipo_data_esistenza_CPF</seealso>
    let ``TesauroSAN/Tipo_data_esistenza_CPF`` =
        Prefixed_Name(san_lod, "TesauroSAN/Tipo_data_esistenza_CPF") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:TesauroSAN/natura_giuridica_ente</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/TesauroSAN/natura_giuridica_ente">http://dati.san.beniculturali.it/SAN/TesauroSAN/natura_giuridica_ente</seealso>
    let ``TesauroSAN/natura_giuridica_ente`` =
        Prefixed_Name(san_lod, "TesauroSAN/natura_giuridica_ente") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:TesauroSAN/sottotipologia_ente</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/TesauroSAN/sottotipologia_ente">http://dati.san.beniculturali.it/SAN/TesauroSAN/sottotipologia_ente</seealso>
    let ``TesauroSAN/sottotipologia_ente`` =
        Prefixed_Name(san_lod, "TesauroSAN/sottotipologia_ente") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:TesauroSAN/tipologia_Conservatore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/TesauroSAN/tipologia_Conservatore">http://dati.san.beniculturali.it/SAN/TesauroSAN/tipologia_Conservatore</seealso>
    let ``TesauroSAN/tipologia_Conservatore`` =
        Prefixed_Name(san_lod, "TesauroSAN/tipologia_Conservatore") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:abstract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/abstract[@langcode]"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/description/biogHist/abstract"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"abstract"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/abstract">http://dati.san.beniculturali.it/SAN/abstract</seealso>
    let abstract_ = Prefixed_Name(san_lod, "abstract") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:acronimo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/acronimo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"acronimo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/acronimo">http://dati.san.beniculturali.it/SAN/acronimo</seealso>
    let acronimo = Prefixed_Name(san_lod, "acronimo") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:altraDenominazioneComplarc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/unittitle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"altra denominazione complesso archivistico"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/altraDenominazioneComplarc">http://dati.san.beniculturali.it/SAN/altraDenominazioneComplarc</seealso>
    let altraDenominazioneComplarc =
        Prefixed_Name(san_lod, "altraDenominazioneComplarc") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:altraDenominazioneProduttore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/identity/nameEntry[@localType='altradenominazione']/part"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"altra denominazione produttore"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/altraDenominazioneProduttore">http://dati.san.beniculturali.it/SAN/altraDenominazioneProduttore</seealso>
    let altraDenominazioneProduttore =
        Prefixed_Name(san_lod, "altraDenominazioneProduttore") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:altraDenominazioneProfiloIstituzionale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"altra denominazione profilo istituzionale"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/altraDenominazioneProfiloIstituzionale">http://dati.san.beniculturali.it/SAN/altraDenominazioneProfiloIstituzionale</seealso>
    let altraDenominazioneProfiloIstituzionale =
        Prefixed_Name(san_lod, "altraDenominazioneProfiloIstituzionale") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:altroAccesso</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/altroaccesso"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"altro accesso"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/altroAccesso">http://dati.san.beniculturali.it/SAN/altroAccesso</seealso>
    let altroAccesso = Prefixed_Name(san_lod, "altroAccesso") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:autore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/filedesc/titlestmt/author"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"autore"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/autore">http://dati.san.beniculturali.it/SAN/autore</seealso>
    let autore = Prefixed_Name(san_lod, "autore") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:casaEditrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/filedesc/publicationstm/publisher"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"casa editrice"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/casaEditrice">http://dati.san.beniculturali.it/SAN/casaEditrice</seealso>
    let casaEditrice = Prefixed_Name(san_lod, "casaEditrice") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:codice_ISIL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"codice ISIL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/codice_ISIL">http://dati.san.beniculturali.it/SAN/codice_ISIL</seealso>
    let codice_ISIL = Prefixed_Name(san_lod, "codice_ISIL") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:complessoArchivistico</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Locuzione generica per indicare un corpus documentale oggetto di descrizione."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"complesso archivistico"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/complessoArchivistico">http://dati.san.beniculturali.it/SAN/complessoArchivistico</seealso>
    let complessoArchivistico =
        Prefixed_Name(san_lod, "complessoArchivistico") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:conservatore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Il soggetto sul quale ricade la responsabilità  della conservazione e valorizzazione dell'archivio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"soggetto conservatore"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/conservatore">http://dati.san.beniculturali.it/SAN/conservatore</seealso>
    let conservatore = Prefixed_Name(san_lod, "conservatore") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:consistenza</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/physdesc/extent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"consistenza"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/consistenza">http://dati.san.beniculturali.it/SAN/consistenza</seealso>
    let consistenza = Prefixed_Name(san_lod, "consistenza") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:consultazione</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/consultazione"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"consultazione"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/consultazione">http://dati.san.beniculturali.it/SAN/consultazione</seealso>
    let consultazione = Prefixed_Name(san_lod, "consultazione") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:contestoStoricoIstituzionale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Organizzazione istituzionale entro cui ha operato il soggetto produttore. Può trattarsi di uno Stato o di articolazioni territoriali o amministrative di esso. L'entità  statale può essere individuata con la denominazione propria di un determinato periodo storico (per es. “Repubblica di Siena”, “Granducato di Toscana””) o con le denominazioni assunte in un più lungo arco cronologico (es. "Regno d'Italia poi Repubblica italiana")."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"contesto storico istituzionale"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/contestoStoricoIstituzionale">http://dati.san.beniculturali.it/SAN/contestoStoricoIstituzionale</seealso>
    let contestoStoricoIstituzionale =
        Prefixed_Name(san_lod, "contestoStoricoIstituzionale") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/date">http://dati.san.beniculturali.it/SAN/date</seealso>
    let date = Prefixed_Name(san_lod, "date") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:dateCSI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"date contesto storico istituzionale"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/dateCSI">http://dati.san.beniculturali.it/SAN/dateCSI</seealso>
    let dateCSI = Prefixed_Name(san_lod, "dateCSI") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:dateCSITesto</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"date contesto storico istituzionale testo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/dateCSITesto">http://dati.san.beniculturali.it/SAN/dateCSITesto</seealso>
    let dateCSITesto = Prefixed_Name(san_lod, "dateCSITesto") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:dateComplarc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"date complesso archivistico"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/dateComplarc">http://dati.san.beniculturali.it/SAN/dateComplarc</seealso>
    let dateComplarc = Prefixed_Name(san_lod, "dateComplarc") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:dateComplarcNormal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/unitdate[@datechar='principale']/@normal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"date complesso archivistico normal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/dateComplarcNormal">http://dati.san.beniculturali.it/SAN/dateComplarcNormal</seealso>
    let dateComplarcNormal =
        Prefixed_Name(san_lod, "dateComplarcNormal") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:dateComplarcTesto</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/unitdate[@datechar='principale']"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"date complesso archivistico testo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/dateComplarcTesto">http://dati.san.beniculturali.it/SAN/dateComplarcTesto</seealso>
    let dateComplarcTesto = Prefixed_Name(san_lod, "dateComplarcTesto") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:dateEsistenza</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"date esistenza"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/dateEsistenza">http://dati.san.beniculturali.it/SAN/dateEsistenza</seealso>
    let dateEsistenza = Prefixed_Name(san_lod, "dateEsistenza") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:dateEsistenzaNormal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"date esistenza normal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/dateEsistenzaNormal">http://dati.san.beniculturali.it/SAN/dateEsistenzaNormal</seealso>
    let dateEsistenzaNormal =
        Prefixed_Name(san_lod, "dateEsistenzaNormal") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:dateEsistenzaTesto</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/description/existDates/dateSet/date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"date esistenza testo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/dateEsistenzaTesto">http://dati.san.beniculturali.it/SAN/dateEsistenzaTesto</seealso>
    let dateEsistenzaTesto =
        Prefixed_Name(san_lod, "dateEsistenzaTesto") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:dateQualificazioniRelCpf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/relations/cpfRelation/date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"date qualificazioni relazioni Cpf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/dateQualificazioniRelCpf">http://dati.san.beniculturali.it/SAN/dateQualificazioniRelCpf</seealso>
    let dateQualificazioniRelCpf =
        Prefixed_Name(san_lod, "dateQualificazioniRelCpf") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:dateStrumento</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"date strumento"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/dateStrumento">http://dati.san.beniculturali.it/SAN/dateStrumento</seealso>
    let dateStrumento = Prefixed_Name(san_lod, "dateStrumento") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:dateStrumentoTesto</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/filedesc/publicationstm/date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"date strumento testo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/dateStrumentoTesto">http://dati.san.beniculturali.it/SAN/dateStrumentoTesto</seealso>
    let dateStrumentoTesto =
        Prefixed_Name(san_lod, "dateStrumentoTesto") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:denominazioneCSI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"denominazione contesto storico istituzionale"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/denominazioneCSI">http://dati.san.beniculturali.it/SAN/denominazioneCSI</seealso>
    let denominazioneCSI = Prefixed_Name(san_lod, "denominazioneCSI") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:descrizione</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/descrizione"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/filedesc/notestmt/note"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"descrizione"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/descrizione">http://dati.san.beniculturali.it/SAN/descrizione</seealso>
    let descrizione = Prefixed_Name(san_lod, "descrizione") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:descrizioneCSI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"descrizione contesto storico istituzionale"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/descrizioneCSI">http://dati.san.beniculturali.it/SAN/descrizioneCSI</seealso>
    let descrizioneCSI = Prefixed_Name(san_lod, "descrizioneCSI") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:edito</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/filedesc/notestmt/note/@type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"edito"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/edito">http://dati.san.beniculturali.it/SAN/edito</seealso>
    let edito = Prefixed_Name(san_lod, "edito") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:ente</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ente"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/ente">http://dati.san.beniculturali.it/SAN/ente</seealso>
    let ente = Prefixed_Name(san_lod, "ente") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:estensioneDateComplarc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"estensione date complesso archivistico"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/estensioneDateComplarc">http://dati.san.beniculturali.it/SAN/estensioneDateComplarc</seealso>
    let estensioneDateComplarc =
        Prefixed_Name(san_lod, "estensioneDateComplarc") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:estensioneDateNormal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/unitdate/@normal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"estensione date normal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/estensioneDateNormal">http://dati.san.beniculturali.it/SAN/estensioneDateNormal</seealso>
    let estensioneDateNormal =
        Prefixed_Name(san_lod, "estensioneDateNormal") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:famiglia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"famiglia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/famiglia">http://dati.san.beniculturali.it/SAN/famiglia</seealso>
    let famiglia = Prefixed_Name(san_lod, "famiglia") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:formaAutorizzataComplarc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/unittitle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"forma autorizzata complesso archivistico"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/formaAutorizzataComplarc">http://dati.san.beniculturali.it/SAN/formaAutorizzataComplarc</seealso>
    let formaAutorizzataComplarc =
        Prefixed_Name(san_lod, "formaAutorizzataComplarc") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:formaAutorizzataConservatore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/formeparallele"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/formaautorizzata"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"forma autorizzata conservatore"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/formaAutorizzataConservatore">http://dati.san.beniculturali.it/SAN/formaAutorizzataConservatore</seealso>
    let formaAutorizzataConservatore =
        Prefixed_Name(san_lod, "formaAutorizzataConservatore") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:formaAutorizzataProduttore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/identity/nameEntryParallel/nameEntry/part[@langcode]"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/identity/nameEntry/part"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"forma autorizzata produttore"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/formaAutorizzataProduttore">http://dati.san.beniculturali.it/SAN/formaAutorizzataProduttore</seealso>
    let formaAutorizzataProduttore =
        Prefixed_Name(san_lod, "formaAutorizzataProduttore") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:formaAutorizzataProfiloIstituzionale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"forma autorizzata profilo istituzionale"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/formaAutorizzataProfiloIstituzionale">http://dati.san.beniculturali.it/SAN/formaAutorizzataProfiloIstituzionale</seealso>
    let formaAutorizzataProfiloIstituzionale =
        Prefixed_Name(san_lod, "formaAutorizzataProfiloIstituzionale") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:has_CSI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ha contesto storico istituzionale"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/has_CSI">http://dati.san.beniculturali.it/SAN/has_CSI</seealso>
    let has_CSI = Prefixed_Name(san_lod, "has_CSI") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:has_conservatore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ha conservatore"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/has_conservatore">http://dati.san.beniculturali.it/SAN/has_conservatore</seealso>
    let has_conservatore = Prefixed_Name(san_lod, "has_conservatore") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:has_cpf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ha cpf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/has_cpf">http://dati.san.beniculturali.it/SAN/has_cpf</seealso>
    let has_cpf = Prefixed_Name(san_lod, "has_cpf") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:has_dateCSI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ha date contesto storico istituzionale"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/has_dateCSI">http://dati.san.beniculturali.it/SAN/has_dateCSI</seealso>
    let has_dateCSI = Prefixed_Name(san_lod, "has_dateCSI") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:has_dateComplarc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ha date complesso archivistico"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/has_dateComplarc">http://dati.san.beniculturali.it/SAN/has_dateComplarc</seealso>
    let has_dateComplarc = Prefixed_Name(san_lod, "has_dateComplarc") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:has_dateEsistenza</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ha date esistenza"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/has_dateEsistenza">http://dati.san.beniculturali.it/SAN/has_dateEsistenza</seealso>
    let has_dateEsistenza = Prefixed_Name(san_lod, "has_dateEsistenza") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:has_dateEsistenzaTipo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ha tipo date di esistenza"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/has_dateEsistenzaTipo">http://dati.san.beniculturali.it/SAN/has_dateEsistenzaTipo</seealso>
    let has_dateEsistenzaTipo =
        Prefixed_Name(san_lod, "has_dateEsistenzaTipo") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:has_dateStrumento</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ha date strumento"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/has_dateStrumento">http://dati.san.beniculturali.it/SAN/has_dateStrumento</seealso>
    let has_dateStrumento = Prefixed_Name(san_lod, "has_dateStrumento") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:has_estensioneDateComplarc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ha estensione date complesso archivistico"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/has_estensioneDateComplarc">http://dati.san.beniculturali.it/SAN/has_estensioneDateComplarc</seealso>
    let has_estensioneDateComplarc =
        Prefixed_Name(san_lod, "has_estensioneDateComplarc") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:has_estensioneDateTipo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ha estensione date tipo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/has_estensioneDateTipo">http://dati.san.beniculturali.it/SAN/has_estensioneDateTipo</seealso>
    let has_estensioneDateTipo =
        Prefixed_Name(san_lod, "has_estensioneDateTipo") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:has_livelloSuperiore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ha livelloSuperiore"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/has_livelloSuperiore">http://dati.san.beniculturali.it/SAN/has_livelloSuperiore</seealso>
    let has_livelloSuperiore =
        Prefixed_Name(san_lod, "has_livelloSuperiore") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:has_luogoAmbitoTerritoriale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ha luogo Ambito Territoriale"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/has_luogoAmbitoTerritoriale">http://dati.san.beniculturali.it/SAN/has_luogoAmbitoTerritoriale</seealso>
    let has_luogoAmbitoTerritoriale =
        Prefixed_Name(san_lod, "has_luogoAmbitoTerritoriale") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:has_luogoConservatore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ha luogoConservatore"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/has_luogoConservatore">http://dati.san.beniculturali.it/SAN/has_luogoConservatore</seealso>
    let has_luogoConservatore =
        Prefixed_Name(san_lod, "has_luogoConservatore") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:has_luogoGiurisdizione</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ha luogo Giurisdizione"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/has_luogoGiurisdizione">http://dati.san.beniculturali.it/SAN/has_luogoGiurisdizione</seealso>
    let has_luogoGiurisdizione =
        Prefixed_Name(san_lod, "has_luogoGiurisdizione") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:has_luogoMorte</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ha luogo morte"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/has_luogoMorte">http://dati.san.beniculturali.it/SAN/has_luogoMorte</seealso>
    let has_luogoMorte = Prefixed_Name(san_lod, "has_luogoMorte") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:has_luogoNascita</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ha luogo nascita"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/has_luogoNascita">http://dati.san.beniculturali.it/SAN/has_luogoNascita</seealso>
    let has_luogoNascita = Prefixed_Name(san_lod, "has_luogoNascita") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:has_luogoProduttore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ha luogoProduttore"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/has_luogoProduttore">http://dati.san.beniculturali.it/SAN/has_luogoProduttore</seealso>
    let has_luogoProduttore =
        Prefixed_Name(san_lod, "has_luogoProduttore") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:has_luogoResidenza</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ha luogo Residenza"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/has_luogoResidenza">http://dati.san.beniculturali.it/SAN/has_luogoResidenza</seealso>
    let has_luogoResidenza =
        Prefixed_Name(san_lod, "has_luogoResidenza") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:has_luogoSede</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ha luogo Sede"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/has_luogoSede">http://dati.san.beniculturali.it/SAN/has_luogoSede</seealso>
    let has_luogoSede = Prefixed_Name(san_lod, "has_luogoSede") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:has_natura_giuridica_ente</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ha natura giuridica ente"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/has_natura_giuridica_ente">http://dati.san.beniculturali.it/SAN/has_natura_giuridica_ente</seealso>
    let has_natura_giuridica_ente =
        Prefixed_Name(san_lod, "has_natura_giuridica_ente") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:has_produttore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ha produttore"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/has_produttore">http://dati.san.beniculturali.it/SAN/has_produttore</seealso>
    let has_produttore = Prefixed_Name(san_lod, "has_produttore") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:has_qualificazioniRelazioniCpf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ha qualificazioni relazioni Cpf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/has_qualificazioniRelazioniCpf">http://dati.san.beniculturali.it/SAN/has_qualificazioniRelazioniCpf</seealso>
    let has_qualificazioniRelazioniCpf =
        Prefixed_Name(san_lod, "has_qualificazioniRelazioniCpf") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:has_relazionePI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ha relazione con Profilo Istituzionale"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/has_relazionePI">http://dati.san.beniculturali.it/SAN/has_relazionePI</seealso>
    let has_relazionePI = Prefixed_Name(san_lod, "has_relazionePI") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:has_relazioneProduttore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ha relazione con Soggetto Produttore"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/has_relazioneProduttore">http://dati.san.beniculturali.it/SAN/has_relazioneProduttore</seealso>
    let has_relazioneProduttore =
        Prefixed_Name(san_lod, "has_relazioneProduttore") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:has_sitoWeb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ha sito web"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/has_sitoWeb">http://dati.san.beniculturali.it/SAN/has_sitoWeb</seealso>
    let has_sitoWeb = Prefixed_Name(san_lod, "has_sitoWeb") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:has_sottotipologia_ente</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ha sottotipologia ente"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/has_sottotipologia_ente">http://dati.san.beniculturali.it/SAN/has_sottotipologia_ente</seealso>
    let has_sottotipologia_ente =
        Prefixed_Name(san_lod, "has_sottotipologia_ente") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:has_statusProvenienza</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ha statusProvenienza"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/has_statusProvenienza">http://dati.san.beniculturali.it/SAN/has_statusProvenienza</seealso>
    let has_statusProvenienza =
        Prefixed_Name(san_lod, "has_statusProvenienza") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:has_strumentoDiRicerca</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ha strumento di ricerca"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/has_strumentoDiRicerca">http://dati.san.beniculturali.it/SAN/has_strumentoDiRicerca</seealso>
    let has_strumentoDiRicerca =
        Prefixed_Name(san_lod, "has_strumentoDiRicerca") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:has_strumentoDigitale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ha strumento digitale"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/has_strumentoDigitale">http://dati.san.beniculturali.it/SAN/has_strumentoDigitale</seealso>
    let has_strumentoDigitale =
        Prefixed_Name(san_lod, "has_strumentoDigitale") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:has_tematismo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ha tematismo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/has_tematismo">http://dati.san.beniculturali.it/SAN/has_tematismo</seealso>
    let has_tematismo = Prefixed_Name(san_lod, "has_tematismo") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:has_tipologia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ha tipologia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/has_tipologia">http://dati.san.beniculturali.it/SAN/has_tipologia</seealso>
    let has_tipologia = Prefixed_Name(san_lod, "has_tipologia") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:indirizzo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"indirizzo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/indirizzo">http://dati.san.beniculturali.it/SAN/indirizzo</seealso>
    let indirizzo = Prefixed_Name(san_lod, "indirizzo") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:isConservatoreOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"è conservatore di"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/isConservatoreOf">http://dati.san.beniculturali.it/SAN/isConservatoreOf</seealso>
    let isConservatoreOf = Prefixed_Name(san_lod, "isConservatoreOf") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:isProduttoreOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"è produttore di"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/isProduttoreOf">http://dati.san.beniculturali.it/SAN/isProduttoreOf</seealso>
    let isProduttoreOf = Prefixed_Name(san_lod, "isProduttoreOf") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:isStrumentoDiRicercaOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"è strumento di ricerca di"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/isStrumentoDiRicercaOf">http://dati.san.beniculturali.it/SAN/isStrumentoDiRicercaOf</seealso>
    let isStrumentoDiRicercaOf =
        Prefixed_Name(san_lod, "isStrumentoDiRicercaOf") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:luogo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"luogo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/luogo">http://dati.san.beniculturali.it/SAN/luogo</seealso>
    let luogo = Prefixed_Name(san_lod, "luogo") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:luogoCAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/localizzazione/@cap"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"luogo CAP"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/luogoCAP">http://dati.san.beniculturali.it/SAN/luogoCAP</seealso>
    let luogoCAP = Prefixed_Name(san_lod, "luogoCAP") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:luogoComune</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/localizzazione/@comune"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"luogo comune"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/luogoComune">http://dati.san.beniculturali.it/SAN/luogoComune</seealso>
    let luogoComune = Prefixed_Name(san_lod, "luogoComune") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:luogoConservatore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"luogo conservatore"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/luogoConservatore">http://dati.san.beniculturali.it/SAN/luogoConservatore</seealso>
    let luogoConservatore = Prefixed_Name(san_lod, "luogoConservatore") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:luogoPaese</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/localizzazione/@paese"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"luogo paese"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/luogoPaese">http://dati.san.beniculturali.it/SAN/luogoPaese</seealso>
    let luogoPaese = Prefixed_Name(san_lod, "luogoPaese") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:luogoProvincia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/localizzazione/@provincia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"luogo provincia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/luogoProvincia">http://dati.san.beniculturali.it/SAN/luogoProvincia</seealso>
    let luogoProvincia = Prefixed_Name(san_lod, "luogoProvincia") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:luogoPubblicazione</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/filedesc/publicationstm/address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"luogo pubblicazione"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/luogoPubblicazione">http://dati.san.beniculturali.it/SAN/luogoPubblicazione</seealso>
    let luogoPubblicazione =
        Prefixed_Name(san_lod, "luogoPubblicazione") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:luogoTesto</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/placeDates/placeDate/place"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/localizzazione"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"luogo testo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/luogoTesto">http://dati.san.beniculturali.it/SAN/luogoTesto</seealso>
    let luogoTesto = Prefixed_Name(san_lod, "luogoTesto") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:orario</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/orario"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"orario"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/orario">http://dati.san.beniculturali.it/SAN/orario</seealso>
    let orario = Prefixed_Name(san_lod, "orario") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:ordinamento</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"ordinamento"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/ordinamento">http://dati.san.beniculturali.it/SAN/ordinamento</seealso>
    let ordinamento = Prefixed_Name(san_lod, "ordinamento") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:persona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"persona"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/persona">http://dati.san.beniculturali.it/SAN/persona</seealso>
    let persona = Prefixed_Name(san_lod, "persona") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:produttore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Soggetto (ente, famiglia o persona) che ha prodotto o acquisito per finalità  amministrative, familiari o personali il complesso archivistico oggetto di descrizione. Può essere collegato ad altri soggetti produttori con relazioni gerarchiche o temporali."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"soggetto produttore"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/produttore">http://dati.san.beniculturali.it/SAN/produttore</seealso>
    let produttore = Prefixed_Name(san_lod, "produttore") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:professione</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/description/descriptiveEntries/descriptiveEntry/term"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"professione"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/professione">http://dati.san.beniculturali.it/SAN/professione</seealso>
    let professione = Prefixed_Name(san_lod, "professione") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:profiloIstituzionale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Istituzioni, preunitarie o unitarie, descritte una volta per tutte, con riferimento al periodo in cui hanno operato e al contesto storico istituzionale o statuale di appartenenza.
    /// Descrive una volta per tutte un particolare soggetto produttore, e costituisce una chiave di ricerca per tutti i soggetti produttori che appartengono al profilo descritto."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"profilo istituzionale"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/profiloIstituzionale">http://dati.san.beniculturali.it/SAN/profiloIstituzionale</seealso>
    let profiloIstituzionale =
        Prefixed_Name(san_lod, "profiloIstituzionale") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:qualificazioniRelazioniCpf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"qualificazioni relazioni Cpf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/qualificazioniRelazioniCpf">http://dati.san.beniculturali.it/SAN/qualificazioniRelazioniCpf</seealso>
    let qualificazioniRelazioniCpf =
        Prefixed_Name(san_lod, "qualificazioniRelazioniCpf") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:recordProvenienzaId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/unitid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/control/otherRecordId"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/eadid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"record provenienza id"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/recordProvenienzaId">http://dati.san.beniculturali.it/SAN/recordProvenienzaId</seealso>
    let recordProvenienzaId =
        Prefixed_Name(san_lod, "recordProvenienzaId") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:schedaProvenienzaHref</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/unitid/@identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/control/sources/source/@xlink:href"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/eadid/@URL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"scheda provenienza href"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/schedaProvenienzaHref">http://dati.san.beniculturali.it/SAN/schedaProvenienzaHref</seealso>
    let schedaProvenienzaHref =
        Prefixed_Name(san_lod, "schedaProvenienzaHref") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:schedaSAN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"scheda SAN"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/schedaSAN">http://dati.san.beniculturali.it/SAN/schedaSAN</seealso>
    let schedaSAN = Prefixed_Name(san_lod, "schedaSAN") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:servizi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/servizi"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"servizi"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/servizi">http://dati.san.beniculturali.it/SAN/servizi</seealso>
    let servizi = Prefixed_Name(san_lod, "servizi") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:sistemaProvenienza</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/control/otherRecordId/@localtype"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/eadid/@identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/unitid/@type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"sistema provenienza"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/sistemaProvenienza">http://dati.san.beniculturali.it/SAN/sistemaProvenienza</seealso>
    let sistemaProvenienza =
        Prefixed_Name(san_lod, "sistemaProvenienza") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:sitoWeb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sito web"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/sitoWeb">http://dati.san.beniculturali.it/SAN/sitoWeb</seealso>
    let sitoWeb = Prefixed_Name(san_lod, "sitoWeb") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:sitoWebHref</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/sitoweb/@href"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"sito web href"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/sitoWebHref">http://dati.san.beniculturali.it/SAN/sitoWebHref</seealso>
    let sitoWebHref = Prefixed_Name(san_lod, "sitoWebHref") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:sitoWebTesto</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/sitoweb"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"sito web testo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/sitoWebTesto">http://dati.san.beniculturali.it/SAN/sitoWebTesto</seealso>
    let sitoWebTesto = Prefixed_Name(san_lod, "sitoWebTesto") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:strumento</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Repertorio - in forma di inventario analitico o sommario, elenco, elenco di versamento, elenco di consistenza, elenco numerico o altro - che descrive in maniera più o meno dettagliata un fondo o parte di esso."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"strumento di ricerca"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/strumento">http://dati.san.beniculturali.it/SAN/strumento</seealso>
    let strumento = Prefixed_Name(san_lod, "strumento") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:strumentoDigitale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"strumento digitale"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/strumentoDigitale">http://dati.san.beniculturali.it/SAN/strumentoDigitale</seealso>
    let strumentoDigitale = Prefixed_Name(san_lod, "strumentoDigitale") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:strumentoDigitaleLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/filedesc/editionstmt/edition/extptr/@href"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"strumento digitale link"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/strumentoDigitaleLink">http://dati.san.beniculturali.it/SAN/strumentoDigitaleLink</seealso>
    let strumentoDigitaleLink =
        Prefixed_Name(san_lod, "strumentoDigitaleLink") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:strumentoDigitaleTitolo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/filedesc/editionstmt/edition/extptr/@title"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"strumento digitale titolo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/strumentoDigitaleTitolo">http://dati.san.beniculturali.it/SAN/strumentoDigitaleTitolo</seealso>
    let strumentoDigitaleTitolo =
        Prefixed_Name(san_lod, "strumentoDigitaleTitolo") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:tipoQualificazioniRelCpf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/relations/cpfRelation/@localType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"tipo qualificazioni relazioni Cpf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/tipoQualificazioniRelCpf">http://dati.san.beniculturali.it/SAN/tipoQualificazioniRelCpf</seealso>
    let tipoQualificazioniRelCpf =
        Prefixed_Name(san_lod, "tipoQualificazioniRelCpf") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:tipologiaComplesso</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc[@level='otherlevel']/@otherlevel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"tipologia complesso"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/tipologiaComplesso">http://dati.san.beniculturali.it/SAN/tipologiaComplesso</seealso>
    let tipologiaComplesso =
        Prefixed_Name(san_lod, "tipologiaComplesso") |> PrefixedName

    /// <summary>
    ///   <para>san-lod:titolo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/filedesc/titlestmt/titleproper"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"titolo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/titolo">http://dati.san.beniculturali.it/SAN/titolo</seealso>
    let titolo = Prefixed_Name(san_lod, "titolo") |> PrefixedName
    /// <summary>
    ///   <para>san-lod:titolo_nobiliare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/description/descriptiveEntries/descriptiveEntry/term"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"titolo nobiliare"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dati.san.beniculturali.it/SAN/titolo_nobiliare">http://dati.san.beniculturali.it/SAN/titolo_nobiliare</seealso>
    let titolo_nobiliare = Prefixed_Name(san_lod, "titolo_nobiliare") |> PrefixedName
