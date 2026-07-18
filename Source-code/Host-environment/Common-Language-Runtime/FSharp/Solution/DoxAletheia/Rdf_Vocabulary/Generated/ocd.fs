namespace http.dati.camera.it.ocd.slash

open DoxAletheia.Rdf_Vocabulary

module ocd =
    let _namespace_name = "http://dati.camera.it/ocd/"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/organo"></see>
    /// </summary>
    let organo = Namespaced_IRI.parse _namespace_name "organo" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/organoGoverno"></see>
    /// </summary>
    let organoGoverno =
        Namespaced_IRI.parse _namespace_name "organoGoverno" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/dibattito"></see>
    /// </summary>
    let dibattito = Namespaced_IRI.parse _namespace_name "dibattito" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/discussione"></see>
    /// </summary>
    let discussione =
        Namespaced_IRI.parse _namespace_name "discussione" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/seduta"></see>
    /// </summary>
    let seduta = Namespaced_IRI.parse _namespace_name "seduta" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/intervento"></see>
    /// </summary>
    let intervento = Namespaced_IRI.parse _namespace_name "intervento" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/atto"></see>
    /// </summary>
    let atto = Namespaced_IRI.parse _namespace_name "atto" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/richiestaParere"></see>
    /// </summary>
    let richiestaParere =
        Namespaced_IRI.parse _namespace_name "richiestaParere" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/stralcio"></see>
    /// </summary>
    let stralcio = Namespaced_IRI.parse _namespace_name "stralcio" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/statoIter"></see>
    /// </summary>
    let statoIter = Namespaced_IRI.parse _namespace_name "statoIter" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/abbinamento"></see>
    /// </summary>
    let abbinamento =
        Namespaced_IRI.parse _namespace_name "abbinamento" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/assegnazione"></see>
    /// </summary>
    let assegnazione =
        Namespaced_IRI.parse _namespace_name "assegnazione" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/natura"></see>
    /// </summary>
    let natura = Namespaced_IRI.parse _namespace_name "natura" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/votazione"></see>
    /// </summary>
    let votazione = Namespaced_IRI.parse _namespace_name "votazione" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/voto"></see>
    /// </summary>
    let voto = Namespaced_IRI.parse _namespace_name "voto" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/membroGoverno"></see>
    /// </summary>
    let membroGoverno =
        Namespaced_IRI.parse _namespace_name "membroGoverno" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/governo"></see>
    /// </summary>
    let governo = Namespaced_IRI.parse _namespace_name "governo" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/elezione"></see>
    /// </summary>
    let elezione = Namespaced_IRI.parse _namespace_name "elezione" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/sistemaElettorale"></see>
    /// </summary>
    let sistemaElettorale =
        Namespaced_IRI.parse _namespace_name "sistemaElettorale" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/legislatura"></see>
    /// </summary>
    let legislatura =
        Namespaced_IRI.parse _namespace_name "legislatura" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/presidenteCamera"></see>
    /// </summary>
    let presidenteCamera =
        Namespaced_IRI.parse _namespace_name "presidenteCamera" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/presidenteConsiglioMinistri"></see>
    /// </summary>
    let presidenteConsiglioMinistri =
        Namespaced_IRI.parse _namespace_name "presidenteConsiglioMinistri" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/senatore"></see>
    /// </summary>
    let senatore = Namespaced_IRI.parse _namespace_name "senatore" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/mandatoCamera"></see>
    /// </summary>
    let mandatoCamera =
        Namespaced_IRI.parse _namespace_name "mandatoCamera" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/mandatoSenato"></see>
    /// </summary>
    let mandatoSenato =
        Namespaced_IRI.parse _namespace_name "mandatoSenato" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/ufficioParlamentare"></see>
    /// </summary>
    let ufficioParlamentare =
        Namespaced_IRI.parse _namespace_name "ufficioParlamentare" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/gruppoParlamentare"></see>
    /// </summary>
    let gruppoParlamentare =
        Namespaced_IRI.parse _namespace_name "gruppoParlamentare" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/componenteGruppoMisto"></see>
    /// </summary>
    let componenteGruppoMisto =
        Namespaced_IRI.parse _namespace_name "componenteGruppoMisto" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/incarico"></see>
    /// </summary>
    let incarico = Namespaced_IRI.parse _namespace_name "incarico" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/aic"></see>
    /// </summary>
    let aic = Namespaced_IRI.parse _namespace_name "aic" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/luogo"></see>
    /// </summary>
    let luogo = Namespaced_IRI.parse _namespace_name "luogo" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/DOC"></see>
    /// </summary>
    let DOC = Namespaced_IRI.parse _namespace_name "DOC" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/ac"></see>
    /// </summary>
    let ac = Namespaced_IRI.parse _namespace_name "ac" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/documentazione"></see>
    /// </summary>
    let documentazione =
        Namespaced_IRI.parse _namespace_name "documentazione" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/dossier"></see>
    /// </summary>
    let dossier = Namespaced_IRI.parse _namespace_name "dossier" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/dottrina"></see>
    /// </summary>
    let dottrina = Namespaced_IRI.parse _namespace_name "dottrina" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/giurisprudenza"></see>
    /// </summary>
    let giurisprudenza =
        Namespaced_IRI.parse _namespace_name "giurisprudenza" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/normativa"></see>
    /// </summary>
    let normativa = Namespaced_IRI.parse _namespace_name "normativa" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/note"></see>
    /// </summary>
    let note = Namespaced_IRI.parse _namespace_name "note" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/pubblicistica"></see>
    /// </summary>
    let pubblicistica =
        Namespaced_IRI.parse _namespace_name "pubblicistica" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/aderisce"></see>
    /// </summary>
    let aderisce = Namespaced_IRI.parse _namespace_name "aderisce" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/deputato"></see>
    /// </summary>
    let deputato = Namespaced_IRI.parse _namespace_name "deputato" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/adesioneGruppo"></see>
    /// </summary>
    let adesioneGruppo =
        Namespaced_IRI.parse _namespace_name "adesioneGruppo" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_gruppoParlamentare"></see>
    /// </summary>
    let rif_gruppoParlamentare =
        Namespaced_IRI.parse _namespace_name "rif_gruppoParlamentare" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/adesioneGruppoMisto"></see>
    /// </summary>
    let adesioneGruppoMisto =
        Namespaced_IRI.parse _namespace_name "adesioneGruppoMisto" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_componente"></see>
    /// </summary>
    let rif_componente =
        Namespaced_IRI.parse _namespace_name "rif_componente" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/lavori"></see>
    /// </summary>
    let lavori = Namespaced_IRI.parse _namespace_name "lavori" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/allegatoDiscussione"></see>
    /// </summary>
    let allegatoDiscussione =
        Namespaced_IRI.parse _namespace_name "allegatoDiscussione" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/altro_firmatario"></see>
    /// </summary>
    let altro_firmatario =
        Namespaced_IRI.parse _namespace_name "altro_firmatario" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/appartenenzaOrgano"></see>
    /// </summary>
    let appartenenzaOrgano =
        Namespaced_IRI.parse _namespace_name "appartenenzaOrgano" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_deputato"></see>
    /// </summary>
    let rif_deputato =
        Namespaced_IRI.parse _namespace_name "rif_deputato" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_organo"></see>
    /// </summary>
    let rif_organo = Namespaced_IRI.parse _namespace_name "rif_organo" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/approvato"></see>
    /// </summary>
    let approvato = Namespaced_IRI.parse _namespace_name "approvato" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/assemblea"></see>
    /// </summary>
    let assemblea = Namespaced_IRI.parse _namespace_name "assemblea" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/astenuti"></see>
    /// </summary>
    let astenuti = Namespaced_IRI.parse _namespace_name "astenuti" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/documenti"></see>
    /// </summary>
    let documenti = Namespaced_IRI.parse _namespace_name "documenti" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/autore"></see>
    /// </summary>
    let autore = Namespaced_IRI.parse _namespace_name "autore" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/bollettino"></see>
    /// </summary>
    let bollettino = Namespaced_IRI.parse _namespace_name "bollettino" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/cambioDenominazione"></see>
    /// </summary>
    let cambioDenominazione =
        Namespaced_IRI.parse _namespace_name "cambioDenominazione" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/carica"></see>
    /// </summary>
    let carica = Namespaced_IRI.parse _namespace_name "carica" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/circoscrizionePlurieletto"></see>
    /// </summary>
    let circoscrizionePlurieletto =
        Namespaced_IRI.parse _namespace_name "circoscrizionePlurieletto" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/componente"></see>
    /// </summary>
    let componente = Namespaced_IRI.parse _namespace_name "componente" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/composizioneOrgano"></see>
    /// </summary>
    let composizioneOrgano =
        Namespaced_IRI.parse _namespace_name "composizioneOrgano" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/concluso"></see>
    /// </summary>
    let concluso = Namespaced_IRI.parse _namespace_name "concluso" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/contrari"></see>
    /// </summary>
    let contrari = Namespaced_IRI.parse _namespace_name "contrari" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/convalida"></see>
    /// </summary>
    let convalida = Namespaced_IRI.parse _namespace_name "convalida" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/costituzionale"></see>
    /// </summary>
    let costituzionale =
        Namespaced_IRI.parse _namespace_name "costituzionale" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/cronologia"></see>
    /// </summary>
    let cronologia = Namespaced_IRI.parse _namespace_name "cronologia" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/denominazione"></see>
    /// </summary>
    let denominazione =
        Namespaced_IRI.parse _namespace_name "denominazione" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/persona"></see>
    /// </summary>
    let persona = Namespaced_IRI.parse _namespace_name "persona" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/destinatario"></see>
    /// </summary>
    let destinatario =
        Namespaced_IRI.parse _namespace_name "destinatario" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/dicastero"></see>
    /// </summary>
    let dicastero = Namespaced_IRI.parse _namespace_name "dicastero" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/diventa"></see>
    /// </summary>
    let diventa = Namespaced_IRI.parse _namespace_name "diventa" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/trasformazioneGruppo"></see>
    /// </summary>
    let trasformazioneGruppo =
        Namespaced_IRI.parse _namespace_name "trasformazioneGruppo" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/doc"></see>
    /// </summary>
    let doc = Namespaced_IRI.parse _namespace_name "doc" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/endDate"></see>
    /// </summary>
    let endDate = Namespaced_IRI.parse _namespace_name "endDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/fa_parte_della"></see>
    /// </summary>
    let fa_parte_della =
        Namespaced_IRI.parse _namespace_name "fa_parte_della" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/favorevoli"></see>
    /// </summary>
    let favorevoli = Namespaced_IRI.parse _namespace_name "favorevoli" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/griglia"></see>
    /// </summary>
    let griglia = Namespaced_IRI.parse _namespace_name "griglia" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/risorsa_web"></see>
    /// </summary>
    let risorsa_web =
        Namespaced_IRI.parse _namespace_name "risorsa_web" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/haMembro"></see>
    /// </summary>
    let haMembro = Namespaced_IRI.parse _namespace_name "haMembro" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/incaricoGovernativo"></see>
    /// </summary>
    let incaricoGovernativo =
        Namespaced_IRI.parse _namespace_name "incaricoGovernativo" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/incaricoGoverno"></see>
    /// </summary>
    let incaricoGoverno =
        Namespaced_IRI.parse _namespace_name "incaricoGoverno" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/iniziativa"></see>
    /// </summary>
    let iniziativa = Namespaced_IRI.parse _namespace_name "iniziativa" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/interim"></see>
    /// </summary>
    let interim = Namespaced_IRI.parse _namespace_name "interim" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/lavoriPreparatori"></see>
    /// </summary>
    let lavoriPreparatori =
        Namespaced_IRI.parse _namespace_name "lavoriPreparatori" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/lavoriPreparatoriLegge"></see>
    /// </summary>
    let lavoriPreparatoriLegge =
        Namespaced_IRI.parse _namespace_name "lavoriPreparatoriLegge" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/legge"></see>
    /// </summary>
    let legge = Namespaced_IRI.parse _namespace_name "legge" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/lex"></see>
    /// </summary>
    let lex = Namespaced_IRI.parse _namespace_name "lex" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/lista"></see>
    /// </summary>
    let lista = Namespaced_IRI.parse _namespace_name "lista" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/maggioranza"></see>
    /// </summary>
    let maggioranza =
        Namespaced_IRI.parse _namespace_name "maggioranza" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/membro"></see>
    /// </summary>
    let membro = Namespaced_IRI.parse _namespace_name "membro" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/membroConsulta"></see>
    /// </summary>
    let membroConsulta =
        Namespaced_IRI.parse _namespace_name "membroConsulta" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/motivoTermine"></see>
    /// </summary>
    let motivoTermine =
        Namespaced_IRI.parse _namespace_name "motivoTermine" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/name"></see>
    /// </summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/nomina"></see>
    /// </summary>
    let nomina = Namespaced_IRI.parse _namespace_name "nomina" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/opzione"></see>
    /// </summary>
    let opzione = Namespaced_IRI.parse _namespace_name "opzione" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/parentADM1"></see>
    /// </summary>
    let parentADM1 = Namespaced_IRI.parse _namespace_name "parentADM1" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/parentADM2"></see>
    /// </summary>
    let parentADM2 = Namespaced_IRI.parse _namespace_name "parentADM2" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/parentADM3"></see>
    /// </summary>
    let parentADM3 = Namespaced_IRI.parse _namespace_name "parentADM3" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/parentCountry"></see>
    /// </summary>
    let parentCountry =
        Namespaced_IRI.parse _namespace_name "parentCountry" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/plurieletto"></see>
    /// </summary>
    let plurieletto =
        Namespaced_IRI.parse _namespace_name "plurieletto" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/presenti"></see>
    /// </summary>
    let presenti = Namespaced_IRI.parse _namespace_name "presenti" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/presidenteRepubblica"></see>
    /// </summary>
    let presidenteRepubblica =
        Namespaced_IRI.parse _namespace_name "presidenteRepubblica" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/primo_firmatario"></see>
    /// </summary>
    let primo_firmatario =
        Namespaced_IRI.parse _namespace_name "primo_firmatario" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/proclamazione"></see>
    /// </summary>
    let proclamazione =
        Namespaced_IRI.parse _namespace_name "proclamazione" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/relatore"></see>
    /// </summary>
    let relatore = Namespaced_IRI.parse _namespace_name "relatore" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/richiestaFiducia"></see>
    /// </summary>
    let richiestaFiducia =
        Namespaced_IRI.parse _namespace_name "richiestaFiducia" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_abbinamento"></see>
    /// </summary>
    let rif_abbinamento =
        Namespaced_IRI.parse _namespace_name "rif_abbinamento" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_allegatoDiscussione"></see>
    /// </summary>
    let rif_allegatoDiscussione =
        Namespaced_IRI.parse _namespace_name "rif_allegatoDiscussione" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_assegnazione"></see>
    /// </summary>
    let rif_assegnazione =
        Namespaced_IRI.parse _namespace_name "rif_assegnazione" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_attoCamera"></see>
    /// </summary>
    let rif_attoCamera =
        Namespaced_IRI.parse _namespace_name "rif_attoCamera" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_bollettino"></see>
    /// </summary>
    let rif_bollettino =
        Namespaced_IRI.parse _namespace_name "rif_bollettino" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_dibattito"></see>
    /// </summary>
    let rif_dibattito =
        Namespaced_IRI.parse _namespace_name "rif_dibattito" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_discussione"></see>
    /// </summary>
    let rif_discussione =
        Namespaced_IRI.parse _namespace_name "rif_discussione" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_doc"></see>
    /// </summary>
    let rif_doc = Namespaced_IRI.parse _namespace_name "rif_doc" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_dossier"></see>
    /// </summary>
    let rif_dossier =
        Namespaced_IRI.parse _namespace_name "rif_dossier" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_elezione"></see>
    /// </summary>
    let rif_elezione =
        Namespaced_IRI.parse _namespace_name "rif_elezione" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_governo"></see>
    /// </summary>
    let rif_governo =
        Namespaced_IRI.parse _namespace_name "rif_governo" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_incarico"></see>
    /// </summary>
    let rif_incarico =
        Namespaced_IRI.parse _namespace_name "rif_incarico" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_incaricoGoverno"></see>
    /// </summary>
    let rif_incaricoGoverno =
        Namespaced_IRI.parse _namespace_name "rif_incaricoGoverno" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_intervento"></see>
    /// </summary>
    let rif_intervento =
        Namespaced_IRI.parse _namespace_name "rif_intervento" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_leg"></see>
    /// </summary>
    let rif_leg = Namespaced_IRI.parse _namespace_name "rif_leg" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_luogo"></see>
    /// </summary>
    let rif_luogo = Namespaced_IRI.parse _namespace_name "rif_luogo" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_mandatoCamera"></see>
    /// </summary>
    let rif_mandatoCamera =
        Namespaced_IRI.parse _namespace_name "rif_mandatoCamera" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_mandatoSenato"></see>
    /// </summary>
    let rif_mandatoSenato =
        Namespaced_IRI.parse _namespace_name "rif_mandatoSenato" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_membroGoverno"></see>
    /// </summary>
    let rif_membroGoverno =
        Namespaced_IRI.parse _namespace_name "rif_membroGoverno" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_natura"></see>
    /// </summary>
    let rif_natura = Namespaced_IRI.parse _namespace_name "rif_natura" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_organoGoverno"></see>
    /// </summary>
    let rif_organoGoverno =
        Namespaced_IRI.parse _namespace_name "rif_organoGoverno" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_persona"></see>
    /// </summary>
    let rif_persona =
        Namespaced_IRI.parse _namespace_name "rif_persona" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_presidenteConsiglioMinistri"></see>
    /// </summary>
    let rif_presidenteConsiglioMinistri =
        Namespaced_IRI.parse _namespace_name "rif_presidenteConsiglioMinistri" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_richiestaParere"></see>
    /// </summary>
    let rif_richiestaParere =
        Namespaced_IRI.parse _namespace_name "rif_richiestaParere" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_seduta"></see>
    /// </summary>
    let rif_seduta = Namespaced_IRI.parse _namespace_name "rif_seduta" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_senatore"></see>
    /// </summary>
    let rif_senatore =
        Namespaced_IRI.parse _namespace_name "rif_senatore" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_sistemaElettorale"></see>
    /// </summary>
    let rif_sistemaElettorale =
        Namespaced_IRI.parse _namespace_name "rif_sistemaElettorale" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_statoIter"></see>
    /// </summary>
    let rif_statoIter =
        Namespaced_IRI.parse _namespace_name "rif_statoIter" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_trasmissione"></see>
    /// </summary>
    let rif_trasmissione =
        Namespaced_IRI.parse _namespace_name "rif_trasmissione" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/trasmissione"></see>
    /// </summary>
    let trasmissione =
        Namespaced_IRI.parse _namespace_name "trasmissione" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_ufficioParlamentare"></see>
    /// </summary>
    let rif_ufficioParlamentare =
        Namespaced_IRI.parse _namespace_name "rif_ufficioParlamentare" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_unitaOrganizzativa"></see>
    /// </summary>
    let rif_unitaOrganizzativa =
        Namespaced_IRI.parse _namespace_name "rif_unitaOrganizzativa" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/unitaOrganizzativa"></see>
    /// </summary>
    let unitaOrganizzativa =
        Namespaced_IRI.parse _namespace_name "unitaOrganizzativa" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_versioneTestoAtto"></see>
    /// </summary>
    let rif_versioneTestoAtto =
        Namespaced_IRI.parse _namespace_name "rif_versioneTestoAtto" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/versioneTestoAtto"></see>
    /// </summary>
    let versioneTestoAtto =
        Namespaced_IRI.parse _namespace_name "versioneTestoAtto" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_votazione"></see>
    /// </summary>
    let rif_votazione =
        Namespaced_IRI.parse _namespace_name "rif_votazione" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/risposta"></see>
    /// </summary>
    let risposta = Namespaced_IRI.parse _namespace_name "risposta" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rispostaAIC"></see>
    /// </summary>
    let rispostaAIC =
        Namespaced_IRI.parse _namespace_name "rispostaAIC" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/ruolo"></see>
    /// </summary>
    let ruolo = Namespaced_IRI.parse _namespace_name "ruolo" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/siComponeDi"></see>
    /// </summary>
    let siComponeDi =
        Namespaced_IRI.parse _namespace_name "siComponeDi" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/startDate"></see>
    /// </summary>
    let startDate = Namespaced_IRI.parse _namespace_name "startDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/tipoElezione"></see>
    /// </summary>
    let tipoElezione =
        Namespaced_IRI.parse _namespace_name "tipoElezione" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/tipoProclamazione"></see>
    /// </summary>
    let tipoProclamazione =
        Namespaced_IRI.parse _namespace_name "tipoProclamazione" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/tipologia"></see>
    /// </summary>
    let tipologia = Namespaced_IRI.parse _namespace_name "tipologia" |> NamespacedName
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/votanti"></see>
    /// </summary>
    let votanti = Namespaced_IRI.parse _namespace_name "votanti" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/votazioneFinale"></see>
    /// </summary>
    let votazioneFinale =
        Namespaced_IRI.parse _namespace_name "votazioneFinale" |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/votazioneSegreta"></see>
    /// </summary>
    let votazioneSegreta =
        Namespaced_IRI.parse _namespace_name "votazioneSegreta" |> NamespacedName
