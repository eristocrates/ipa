#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``san-lod`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://dati.san.beniculturali.it/SAN/" "san-lod"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : abstract^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/description/biogHist/abstract^^xsd:stringrdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/abstract[@langcode]^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/abstract">san-lod:abstract</a>
    /// </summary>
    let abstract_ = _prefixId.prefix "abstract"
    /// <summary>
    ///   <para>rdfs:label : acronimo^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/acronimo^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/acronimo">san-lod:acronimo</a>
    /// </summary>
    let acronimo = _prefixId.prefix "acronimo"
    /// <summary>
    ///   <para>rdfs:label : altra denominazione complesso archivistico^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/unittitle^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/altraDenominazioneComplarc">san-lod:altraDenominazioneComplarc</a>
    /// </summary>
    let altraDenominazioneComplarc = _prefixId.prefix "altraDenominazioneComplarc"
    /// <summary>
    ///   <para>rdfs:label : altra denominazione produttore^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/identity/nameEntry[@localType='altradenominazione']/part^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/altraDenominazioneProduttore">san-lod:altraDenominazioneProduttore</a>
    /// </summary>
    let altraDenominazioneProduttore = _prefixId.prefix "altraDenominazioneProduttore"

    /// <summary>
    ///   <para>rdfs:label : altra denominazione profilo istituzionale^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/altraDenominazioneProfiloIstituzionale">san-lod:altraDenominazioneProfiloIstituzionale</a>
    /// </summary>
    let altraDenominazioneProfiloIstituzionale =
        _prefixId.prefix "altraDenominazioneProfiloIstituzionale"

    /// <summary>
    ///   <para>rdfs:label : altro accesso^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/altroaccesso^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/altroAccesso">san-lod:altroAccesso</a>
    /// </summary>
    let altroAccesso = _prefixId.prefix "altroAccesso"
    /// <summary>
    ///   <para>rdfs:label : autore^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/filedesc/titlestmt/author^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/autore">san-lod:autore</a>
    /// </summary>
    let autore = _prefixId.prefix "autore"
    /// <summary>
    ///   <para>rdfs:label : casa editrice^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/filedesc/publicationstm/publisher^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/casaEditrice">san-lod:casaEditrice</a>
    /// </summary>
    let casaEditrice = _prefixId.prefix "casaEditrice"
    /// <summary>
    ///   <para>rdfs:label : codice ISIL^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/codice_ISIL">san-lod:codice_ISIL</a>
    /// </summary>
    let codice_ISIL = _prefixId.prefix "codice_ISIL"
    /// <summary>
    ///   <para>rdfs:label : complesso archivistico^^xsd:string</para>
    ///   <para>rdfs:comment : Locuzione generica per indicare un corpus documentale oggetto di descrizione.^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/complessoArchivistico">san-lod:complessoArchivistico</a>
    /// </summary>
    let complessoArchivistico = _prefixId.prefix "complessoArchivistico"
    /// <summary>
    ///   <para>rdfs:label : soggetto conservatore^^xsd:string</para>
    ///   <para>rdfs:comment : Il soggetto sul quale ricade la responsabilità  della conservazione e valorizzazione dell'archivio^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/conservatore">san-lod:conservatore</a>
    /// </summary>
    let conservatore = _prefixId.prefix "conservatore"
    /// <summary>
    ///   <para>rdfs:label : consistenza^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/physdesc/extent^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/consistenza">san-lod:consistenza</a>
    /// </summary>
    let consistenza = _prefixId.prefix "consistenza"
    /// <summary>
    ///   <para>rdfs:label : consultazione^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/consultazione^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/consultazione">san-lod:consultazione</a>
    /// </summary>
    let consultazione = _prefixId.prefix "consultazione"
    /// <summary>
    ///   <para>rdfs:label : contesto storico istituzionale^^xsd:string</para>
    ///   <para>rdfs:comment : Organizzazione istituzionale entro cui ha operato il soggetto produttore. Può trattarsi di uno Stato o di articolazioni territoriali o amministrative di esso. L'entità  statale può essere individuata con la denominazione propria di un determinato periodo storico (per es. “Repubblica di Siena”, “Granducato di Toscana””) o con le denominazioni assunte in un più lungo arco cronologico (es. "Regno d'Italia poi Repubblica italiana").^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/contestoStoricoIstituzionale">san-lod:contestoStoricoIstituzionale</a>
    /// </summary>
    let contestoStoricoIstituzionale = _prefixId.prefix "contestoStoricoIstituzionale"
    /// <summary>
    ///   <para>rdfs:label : date^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/date">san-lod:date</a>
    /// </summary>
    let date = _prefixId.prefix "date"
    /// <summary>
    ///   <para>rdfs:label : date contesto storico istituzionale^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/dateCSI">san-lod:dateCSI</a>
    /// </summary>
    let dateCSI = _prefixId.prefix "dateCSI"
    /// <summary>
    ///   <para>dcterms:description : Date contesto storico istituzionale testuali^^xsd:string</para>
    ///   <para>rdfs:label : date contesto storico istituzionale testo^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/dateCSITesto">san-lod:dateCSITesto</a>
    /// </summary>
    let dateCSITesto = _prefixId.prefix "dateCSITesto"
    /// <summary>
    ///   <para>rdfs:label : date complesso archivistico^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/dateComplarc">san-lod:dateComplarc</a>
    /// </summary>
    let dateComplarc = _prefixId.prefix "dateComplarc"
    /// <summary>
    ///   <para>rdfs:label : date complesso archivistico normal^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/unitdate[@datechar='principale']/@normal^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/dateComplarcNormal">san-lod:dateComplarcNormal</a>
    /// </summary>
    let dateComplarcNormal = _prefixId.prefix "dateComplarcNormal"
    /// <summary>
    ///   <para>rdfs:label : date complesso archivistico testo^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/unitdate[@datechar='principale']^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/dateComplarcTesto">san-lod:dateComplarcTesto</a>
    /// </summary>
    let dateComplarcTesto = _prefixId.prefix "dateComplarcTesto"
    /// <summary>
    ///   <para>rdfs:label : date esistenza^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/dateEsistenza">san-lod:dateEsistenza</a>
    /// </summary>
    let dateEsistenza = _prefixId.prefix "dateEsistenza"
    /// <summary>
    ///   <para>rdfs:label : date esistenza normal^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/dateEsistenzaNormal">san-lod:dateEsistenzaNormal</a>
    /// </summary>
    let dateEsistenzaNormal = _prefixId.prefix "dateEsistenzaNormal"
    /// <summary>
    ///   <para>rdfs:label : date esistenza testo^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/description/existDates/dateSet/date^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/dateEsistenzaTesto">san-lod:dateEsistenzaTesto</a>
    /// </summary>
    let dateEsistenzaTesto = _prefixId.prefix "dateEsistenzaTesto"
    /// <summary>
    ///   <para>rdfs:label : date qualificazioni relazioni Cpf^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/relations/cpfRelation/date^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/dateQualificazioniRelCpf">san-lod:dateQualificazioniRelCpf</a>
    /// </summary>
    let dateQualificazioniRelCpf = _prefixId.prefix "dateQualificazioniRelCpf"
    /// <summary>
    ///   <para>rdfs:label : date strumento^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/dateStrumento">san-lod:dateStrumento</a>
    /// </summary>
    let dateStrumento = _prefixId.prefix "dateStrumento"
    /// <summary>
    ///   <para>rdfs:label : date strumento testo^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/filedesc/publicationstm/date^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/dateStrumentoTesto">san-lod:dateStrumentoTesto</a>
    /// </summary>
    let dateStrumentoTesto = _prefixId.prefix "dateStrumentoTesto"
    /// <summary>
    ///   <para>rdfs:label : denominazione contesto storico istituzionale^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/denominazioneCSI">san-lod:denominazioneCSI</a>
    /// </summary>
    let denominazioneCSI = _prefixId.prefix "denominazioneCSI"
    /// <summary>
    ///   <para>rdfs:label : descrizione^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/filedesc/notestmt/note^^xsd:stringrdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/descrizione^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/descrizione">san-lod:descrizione</a>
    /// </summary>
    let descrizione = _prefixId.prefix "descrizione"
    /// <summary>
    ///   <para>rdfs:label : descrizione contesto storico istituzionale^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/descrizioneCSI">san-lod:descrizioneCSI</a>
    /// </summary>
    let descrizioneCSI = _prefixId.prefix "descrizioneCSI"
    /// <summary>
    ///   <para>rdfs:label : edito^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/filedesc/notestmt/note/@type^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/edito">san-lod:edito</a>
    /// </summary>
    let edito = _prefixId.prefix "edito"
    /// <summary>
    ///   <para>rdfs:label : ente^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/ente">san-lod:ente</a>
    /// </summary>
    let ente = _prefixId.prefix "ente"
    /// <summary>
    ///   <para>rdfs:label : estensione date complesso archivistico^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/estensioneDateComplarc">san-lod:estensioneDateComplarc</a>
    /// </summary>
    let estensioneDateComplarc = _prefixId.prefix "estensioneDateComplarc"
    /// <summary>
    ///   <para>rdfs:label : estensione date normal^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/unitdate/@normal^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/estensioneDateNormal">san-lod:estensioneDateNormal</a>
    /// </summary>
    let estensioneDateNormal = _prefixId.prefix "estensioneDateNormal"
    /// <summary>
    ///   <para>rdfs:label : famiglia^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/famiglia">san-lod:famiglia</a>
    /// </summary>
    let famiglia = _prefixId.prefix "famiglia"
    /// <summary>
    ///   <para>rdfs:label : forma autorizzata complesso archivistico^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/unittitle^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/formaAutorizzataComplarc">san-lod:formaAutorizzataComplarc</a>
    /// </summary>
    let formaAutorizzataComplarc = _prefixId.prefix "formaAutorizzataComplarc"
    /// <summary>
    ///   <para>rdfs:label : forma autorizzata conservatore^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/formaautorizzata^^xsd:stringrdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/formeparallele^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/formaAutorizzataConservatore">san-lod:formaAutorizzataConservatore</a>
    /// </summary>
    let formaAutorizzataConservatore = _prefixId.prefix "formaAutorizzataConservatore"
    /// <summary>
    ///   <para>rdfs:label : forma autorizzata produttore^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/identity/nameEntry/part^^xsd:stringrdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/identity/nameEntryParallel/nameEntry/part[@langcode]^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/formaAutorizzataProduttore">san-lod:formaAutorizzataProduttore</a>
    /// </summary>
    let formaAutorizzataProduttore = _prefixId.prefix "formaAutorizzataProduttore"

    /// <summary>
    ///   <para>rdfs:label : forma autorizzata profilo istituzionale^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/formaAutorizzataProfiloIstituzionale">san-lod:formaAutorizzataProfiloIstituzionale</a>
    /// </summary>
    let formaAutorizzataProfiloIstituzionale =
        _prefixId.prefix "formaAutorizzataProfiloIstituzionale"

    /// <summary>
    ///   <para>rdfs:label : ha contesto storico istituzionale^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/has_CSI">san-lod:has_CSI</a>
    /// </summary>
    let has_CSI = _prefixId.prefix "has_CSI"
    /// <summary>
    ///   <para>rdfs:label : ha conservatore^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/has_conservatore">san-lod:has_conservatore</a>
    /// </summary>
    let has_conservatore = _prefixId.prefix "has_conservatore"
    /// <summary>
    ///   <para>rdfs:label : ha cpf^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/has_cpf">san-lod:has_cpf</a>
    /// </summary>
    let has_cpf = _prefixId.prefix "has_cpf"
    /// <summary>
    ///   <para>rdfs:label : ha date contesto storico istituzionale^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/has_dateCSI">san-lod:has_dateCSI</a>
    /// </summary>
    let has_dateCSI = _prefixId.prefix "has_dateCSI"
    /// <summary>
    ///   <para>rdfs:label : ha date complesso archivistico^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/has_dateComplarc">san-lod:has_dateComplarc</a>
    /// </summary>
    let has_dateComplarc = _prefixId.prefix "has_dateComplarc"
    /// <summary>
    ///   <para>rdfs:label : ha date esistenza^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/has_dateEsistenza">san-lod:has_dateEsistenza</a>
    /// </summary>
    let has_dateEsistenza = _prefixId.prefix "has_dateEsistenza"
    /// <summary>
    ///   <para>rdfs:label : ha tipo date di esistenza^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/has_dateEsistenzaTipo">san-lod:has_dateEsistenzaTipo</a>
    /// </summary>
    let has_dateEsistenzaTipo = _prefixId.prefix "has_dateEsistenzaTipo"
    /// <summary>
    ///   <para>rdfs:label : ha date strumento^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/has_dateStrumento">san-lod:has_dateStrumento</a>
    /// </summary>
    let has_dateStrumento = _prefixId.prefix "has_dateStrumento"
    /// <summary>
    ///   <para>rdfs:label : ha estensione date complesso archivistico^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/has_estensioneDateComplarc">san-lod:has_estensioneDateComplarc</a>
    /// </summary>
    let has_estensioneDateComplarc = _prefixId.prefix "has_estensioneDateComplarc"
    /// <summary>
    ///   <para>rdfs:label : ha estensione date tipo^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/has_estensioneDateTipo">san-lod:has_estensioneDateTipo</a>
    /// </summary>
    let has_estensioneDateTipo = _prefixId.prefix "has_estensioneDateTipo"
    /// <summary>
    ///   <para>rdfs:label : ha livelloSuperiore^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/has_livelloSuperiore">san-lod:has_livelloSuperiore</a>
    /// </summary>
    let has_livelloSuperiore = _prefixId.prefix "has_livelloSuperiore"
    /// <summary>
    ///   <para>rdfs:label : ha luogo Ambito Territoriale^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/has_luogoAmbitoTerritoriale">san-lod:has_luogoAmbitoTerritoriale</a>
    /// </summary>
    let has_luogoAmbitoTerritoriale = _prefixId.prefix "has_luogoAmbitoTerritoriale"
    /// <summary>
    ///   <para>rdfs:label : ha luogoConservatore^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/has_luogoConservatore">san-lod:has_luogoConservatore</a>
    /// </summary>
    let has_luogoConservatore = _prefixId.prefix "has_luogoConservatore"
    /// <summary>
    ///   <para>rdfs:label : ha luogo Giurisdizione^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/has_luogoGiurisdizione">san-lod:has_luogoGiurisdizione</a>
    /// </summary>
    let has_luogoGiurisdizione = _prefixId.prefix "has_luogoGiurisdizione"
    /// <summary>
    ///   <para>rdfs:label : ha luogo morte^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/has_luogoMorte">san-lod:has_luogoMorte</a>
    /// </summary>
    let has_luogoMorte = _prefixId.prefix "has_luogoMorte"
    /// <summary>
    ///   <para>rdfs:label : ha luogo nascita^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/has_luogoNascita">san-lod:has_luogoNascita</a>
    /// </summary>
    let has_luogoNascita = _prefixId.prefix "has_luogoNascita"
    /// <summary>
    ///   <para>rdfs:label : ha luogoProduttore^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/has_luogoProduttore">san-lod:has_luogoProduttore</a>
    /// </summary>
    let has_luogoProduttore = _prefixId.prefix "has_luogoProduttore"
    /// <summary>
    ///   <para>rdfs:label : ha luogo Residenza^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/has_luogoResidenza">san-lod:has_luogoResidenza</a>
    /// </summary>
    let has_luogoResidenza = _prefixId.prefix "has_luogoResidenza"
    /// <summary>
    ///   <para>rdfs:label : ha luogo Sede^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/has_luogoSede">san-lod:has_luogoSede</a>
    /// </summary>
    let has_luogoSede = _prefixId.prefix "has_luogoSede"
    /// <summary>
    ///   <para>rdfs:label : ha natura giuridica ente^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/has_natura_giuridica_ente">san-lod:has_natura_giuridica_ente</a>
    /// </summary>
    let has_natura_giuridica_ente = _prefixId.prefix "has_natura_giuridica_ente"
    /// <summary>
    ///   <para>rdfs:label : ha produttore^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/has_produttore">san-lod:has_produttore</a>
    /// </summary>
    let has_produttore = _prefixId.prefix "has_produttore"

    /// <summary>
    ///   <para>rdfs:label : ha qualificazioni relazioni Cpf^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/has_qualificazioniRelazioniCpf">san-lod:has_qualificazioniRelazioniCpf</a>
    /// </summary>
    let has_qualificazioniRelazioniCpf =
        _prefixId.prefix "has_qualificazioniRelazioniCpf"

    /// <summary>
    ///   <para>rdfs:label : ha relazione con Profilo Istituzionale^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/has_relazionePI">san-lod:has_relazionePI</a>
    /// </summary>
    let has_relazionePI = _prefixId.prefix "has_relazionePI"
    /// <summary>
    ///   <para>rdfs:label : ha relazione con Soggetto Produttore^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/has_relazioneProduttore">san-lod:has_relazioneProduttore</a>
    /// </summary>
    let has_relazioneProduttore = _prefixId.prefix "has_relazioneProduttore"
    /// <summary>
    ///   <para>rdfs:label : ha sito web^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/has_sitoWeb">san-lod:has_sitoWeb</a>
    /// </summary>
    let has_sitoWeb = _prefixId.prefix "has_sitoWeb"
    /// <summary>
    ///   <para>rdfs:label : ha sottotipologia ente^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/has_sottotipologia_ente">san-lod:has_sottotipologia_ente</a>
    /// </summary>
    let has_sottotipologia_ente = _prefixId.prefix "has_sottotipologia_ente"
    /// <summary>
    ///   <para>rdfs:label : ha statusProvenienza^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/has_statusProvenienza">san-lod:has_statusProvenienza</a>
    /// </summary>
    let has_statusProvenienza = _prefixId.prefix "has_statusProvenienza"
    /// <summary>
    ///   <para>rdfs:label : ha strumento di ricerca^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/has_strumentoDiRicerca">san-lod:has_strumentoDiRicerca</a>
    /// </summary>
    let has_strumentoDiRicerca = _prefixId.prefix "has_strumentoDiRicerca"
    /// <summary>
    ///   <para>rdfs:label : ha strumento digitale^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/has_strumentoDigitale">san-lod:has_strumentoDigitale</a>
    /// </summary>
    let has_strumentoDigitale = _prefixId.prefix "has_strumentoDigitale"
    /// <summary>
    ///   <para>rdfs:label : ha tematismo^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/has_tematismo">san-lod:has_tematismo</a>
    /// </summary>
    let has_tematismo = _prefixId.prefix "has_tematismo"
    /// <summary>
    ///   <para>rdfs:label : ha tipologia^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/has_tipologia">san-lod:has_tipologia</a>
    /// </summary>
    let has_tipologia = _prefixId.prefix "has_tipologia"
    /// <summary>
    ///   <para>rdfs:label : indirizzo^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/indirizzo">san-lod:indirizzo</a>
    /// </summary>
    let indirizzo = _prefixId.prefix "indirizzo"
    /// <summary>
    ///   <para>rdfs:label : è conservatore di^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/isConservatoreOf">san-lod:isConservatoreOf</a>
    /// </summary>
    let isConservatoreOf = _prefixId.prefix "isConservatoreOf"
    /// <summary>
    ///   <para>rdfs:label : è produttore di^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/isProduttoreOf">san-lod:isProduttoreOf</a>
    /// </summary>
    let isProduttoreOf = _prefixId.prefix "isProduttoreOf"
    /// <summary>
    ///   <para>rdfs:label : è strumento di ricerca di^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/isStrumentoDiRicercaOf">san-lod:isStrumentoDiRicercaOf</a>
    /// </summary>
    let isStrumentoDiRicercaOf = _prefixId.prefix "isStrumentoDiRicercaOf"
    /// <summary>
    ///   <para>rdfs:label : luogo^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/luogo">san-lod:luogo</a>
    /// </summary>
    let luogo = _prefixId.prefix "luogo"
    /// <summary>
    ///   <para>rdfs:label : luogo CAP^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/localizzazione/@cap^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/luogoCAP">san-lod:luogoCAP</a>
    /// </summary>
    let luogoCAP = _prefixId.prefix "luogoCAP"
    /// <summary>
    ///   <para>rdfs:label : luogo comune^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/localizzazione/@comune^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/luogoComune">san-lod:luogoComune</a>
    /// </summary>
    let luogoComune = _prefixId.prefix "luogoComune"
    /// <summary>
    ///   <para>rdfs:label : luogo conservatore^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/luogoConservatore">san-lod:luogoConservatore</a>
    /// </summary>
    let luogoConservatore = _prefixId.prefix "luogoConservatore"
    /// <summary>
    ///   <para>rdfs:label : luogo paese^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/localizzazione/@paese^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/luogoPaese">san-lod:luogoPaese</a>
    /// </summary>
    let luogoPaese = _prefixId.prefix "luogoPaese"
    /// <summary>
    ///   <para>rdfs:label : luogo provincia^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/localizzazione/@provincia^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/luogoProvincia">san-lod:luogoProvincia</a>
    /// </summary>
    let luogoProvincia = _prefixId.prefix "luogoProvincia"
    /// <summary>
    ///   <para>rdfs:label : luogo pubblicazione^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/filedesc/publicationstm/address^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/luogoPubblicazione">san-lod:luogoPubblicazione</a>
    /// </summary>
    let luogoPubblicazione = _prefixId.prefix "luogoPubblicazione"
    /// <summary>
    ///   <para>rdfs:label : luogo testo^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/placeDates/placeDate/place^^xsd:stringrdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/localizzazione^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/luogoTesto">san-lod:luogoTesto</a>
    /// </summary>
    let luogoTesto = _prefixId.prefix "luogoTesto"
    /// <summary>
    ///   <para>rdfs:label : orario^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/orario^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/orario">san-lod:orario</a>
    /// </summary>
    let orario = _prefixId.prefix "orario"
    /// <summary>
    ///   <para>rdfs:label : ordinamento^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/ordinamento">san-lod:ordinamento</a>
    /// </summary>
    let ordinamento = _prefixId.prefix "ordinamento"
    /// <summary>
    ///   <para>rdfs:label : persona^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/persona">san-lod:persona</a>
    /// </summary>
    let persona = _prefixId.prefix "persona"
    /// <summary>
    ///   <para>rdfs:comment : Soggetto (ente, famiglia o persona) che ha prodotto o acquisito per finalità  amministrative, familiari o personali il complesso archivistico oggetto di descrizione. Può essere collegato ad altri soggetti produttori con relazioni gerarchiche o temporali.^^xsd:string</para>
    ///   <para>rdfs:label : soggetto produttore^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/produttore">san-lod:produttore</a>
    /// </summary>
    let produttore = _prefixId.prefix "produttore"
    /// <summary>
    ///   <para>rdfs:label : professione^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/description/descriptiveEntries/descriptiveEntry/term^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/professione">san-lod:professione</a>
    /// </summary>
    let professione = _prefixId.prefix "professione"
    /// <summary>
    ///   <para>rdfs:comment : Istituzioni, preunitarie o unitarie, descritte una volta per tutte, con riferimento al periodo in cui hanno operato e al contesto storico istituzionale o statuale di appartenenza.
    /// Descrive una volta per tutte un particolare soggetto produttore, e costituisce una chiave di ricerca per tutti i soggetti produttori che appartengono al profilo descritto.^^xsd:string</para>
    ///   <para>rdfs:label : profilo istituzionale^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/profiloIstituzionale">san-lod:profiloIstituzionale</a>
    /// </summary>
    let profiloIstituzionale = _prefixId.prefix "profiloIstituzionale"
    /// <summary>
    ///   <para>rdfs:label : qualificazioni relazioni Cpf^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/qualificazioniRelazioniCpf">san-lod:qualificazioniRelazioniCpf</a>
    /// </summary>
    let qualificazioniRelazioniCpf = _prefixId.prefix "qualificazioniRelazioniCpf"
    /// <summary>
    ///   <para>rdfs:label : record provenienza id^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/unitid^^xsd:stringrdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/control/otherRecordId^^xsd:stringrdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/eadid^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/recordProvenienzaId">san-lod:recordProvenienzaId</a>
    /// </summary>
    let recordProvenienzaId = _prefixId.prefix "recordProvenienzaId"
    /// <summary>
    ///   <para>rdfs:label : scheda provenienza href^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/unitid/@identifier^^xsd:stringrdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/control/sources/source/@xlink:href^^xsd:stringrdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/eadid/@URL^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/schedaProvenienzaHref">san-lod:schedaProvenienzaHref</a>
    /// </summary>
    let schedaProvenienzaHref = _prefixId.prefix "schedaProvenienzaHref"
    /// <summary>
    ///   <para>rdfs:label : scheda SAN^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/schedaSAN">san-lod:schedaSAN</a>
    /// </summary>
    let schedaSAN = _prefixId.prefix "schedaSAN"
    /// <summary>
    ///   <para>rdfs:label : servizi^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/servizi^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/servizi">san-lod:servizi</a>
    /// </summary>
    let servizi = _prefixId.prefix "servizi"
    /// <summary>
    ///   <para>rdfs:label : sistema provenienza^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/eadid/@identifier^^xsd:stringrdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc/did/unitid/@type^^xsd:stringrdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/control/otherRecordId/@localtype^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/sistemaProvenienza">san-lod:sistemaProvenienza</a>
    /// </summary>
    let sistemaProvenienza = _prefixId.prefix "sistemaProvenienza"
    /// <summary>
    ///   <para>rdfs:label : sito web^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/sitoWeb">san-lod:sitoWeb</a>
    /// </summary>
    let sitoWeb = _prefixId.prefix "sitoWeb"
    /// <summary>
    ///   <para>rdfs:label : sito web href^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/sitoweb/@href^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/sitoWebHref">san-lod:sitoWebHref</a>
    /// </summary>
    let sitoWebHref = _prefixId.prefix "sitoWebHref"
    /// <summary>
    ///   <para>rdfs:label : sito web testo^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/scons.xsd//scons/sitoweb^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/sitoWebTesto">san-lod:sitoWebTesto</a>
    /// </summary>
    let sitoWebTesto = _prefixId.prefix "sitoWebTesto"
    /// <summary>
    ///   <para>rdfs:label : strumento di ricerca^^xsd:string</para>
    ///   <para>rdfs:comment : Repertorio - in forma di inventario analitico o sommario, elenco, elenco di versamento, elenco di consistenza, elenco numerico o altro - che descrive in maniera più o meno dettagliata un fondo o parte di esso.^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/strumento">san-lod:strumento</a>
    /// </summary>
    let strumento = _prefixId.prefix "strumento"
    /// <summary>
    ///   <para>rdfs:label : strumento digitale^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/strumentoDigitale">san-lod:strumentoDigitale</a>
    /// </summary>
    let strumentoDigitale = _prefixId.prefix "strumentoDigitale"
    /// <summary>
    ///   <para>rdfs:label : strumento digitale link^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/filedesc/editionstmt/edition/extptr/@href^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/strumentoDigitaleLink">san-lod:strumentoDigitaleLink</a>
    /// </summary>
    let strumentoDigitaleLink = _prefixId.prefix "strumentoDigitaleLink"
    /// <summary>
    ///   <para>rdfs:label : strumento digitale titolo^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/filedesc/editionstmt/edition/extptr/@title^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/strumentoDigitaleTitolo">san-lod:strumentoDigitaleTitolo</a>
    /// </summary>
    let strumentoDigitaleTitolo = _prefixId.prefix "strumentoDigitaleTitolo"
    /// <summary>
    ///   <para>rdfs:label : tipo qualificazioni relazioni Cpf^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/relations/cpfRelation/@localType^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/tipoQualificazioniRelCpf">san-lod:tipoQualificazioniRelCpf</a>
    /// </summary>
    let tipoQualificazioniRelCpf = _prefixId.prefix "tipoQualificazioniRelCpf"
    /// <summary>
    ///   <para>rdfs:label : tipologia complesso^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaead.xsd//ead/archdesc[@level='otherlevel']/@otherlevel^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/tipologiaComplesso">san-lod:tipologiaComplesso</a>
    /// </summary>
    let tipologiaComplesso = _prefixId.prefix "tipologiaComplesso"
    /// <summary>
    ///   <para>rdfs:label : titolo^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/strumenti.xsd//ead/eadheader/filedesc/titlestmt/titleproper^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/titolo">san-lod:titolo</a>
    /// </summary>
    let titolo = _prefixId.prefix "titolo"
    /// <summary>
    ///   <para>rdfs:label : titolo nobiliare^^xsd:string</para>
    ///   <para>rdfs:comment : Tracciato schema SAN: http://www.san.beniculturali.it/tracciato/schemaeac.xsd//eac-cpf/cpfDescription/description/descriptiveEntries/descriptiveEntry/term^^xsd:string</para>
    ///   <a href="http://dati.san.beniculturali.it/SAN/titolo_nobiliare">san-lod:titolo_nobiliare</a>
    /// </summary>
    let titolo_nobiliare = _prefixId.prefix "titolo_nobiliare"
