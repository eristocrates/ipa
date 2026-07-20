namespace http.dati.camera.it.ocd.slash

open DoxAletheia

module ocd =
    let _namespace_name = "http://dati.camera.it/ocd/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/organo"></see>
    /// </summary>
    let organo = _prefix "organo"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/organoGoverno"></see>
    /// </summary>
    let organoGoverno = _prefix "organoGoverno"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/dibattito"></see>
    /// </summary>
    let dibattito = _prefix "dibattito"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/discussione"></see>
    /// </summary>
    let discussione = _prefix "discussione"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/seduta"></see>
    /// </summary>
    let seduta = _prefix "seduta"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/intervento"></see>
    /// </summary>
    let intervento = _prefix "intervento"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/atto"></see>
    /// </summary>
    let atto = _prefix "atto"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/richiestaParere"></see>
    /// </summary>
    let richiestaParere = _prefix "richiestaParere"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/stralcio"></see>
    /// </summary>
    let stralcio = _prefix "stralcio"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/statoIter"></see>
    /// </summary>
    let statoIter = _prefix "statoIter"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/abbinamento"></see>
    /// </summary>
    let abbinamento = _prefix "abbinamento"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/assegnazione"></see>
    /// </summary>
    let assegnazione = _prefix "assegnazione"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/natura"></see>
    /// </summary>
    let natura = _prefix "natura"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/votazione"></see>
    /// </summary>
    let votazione = _prefix "votazione"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/voto"></see>
    /// </summary>
    let voto = _prefix "voto"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/membroGoverno"></see>
    /// </summary>
    let membroGoverno = _prefix "membroGoverno"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/governo"></see>
    /// </summary>
    let governo = _prefix "governo"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/elezione"></see>
    /// </summary>
    let elezione = _prefix "elezione"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/sistemaElettorale"></see>
    /// </summary>
    let sistemaElettorale = _prefix "sistemaElettorale"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/legislatura"></see>
    /// </summary>
    let legislatura = _prefix "legislatura"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/presidenteCamera"></see>
    /// </summary>
    let presidenteCamera = _prefix "presidenteCamera"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/presidenteConsiglioMinistri"></see>
    /// </summary>
    let presidenteConsiglioMinistri = _prefix "presidenteConsiglioMinistri"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/senatore"></see>
    /// </summary>
    let senatore = _prefix "senatore"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/mandatoCamera"></see>
    /// </summary>
    let mandatoCamera = _prefix "mandatoCamera"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/mandatoSenato"></see>
    /// </summary>
    let mandatoSenato = _prefix "mandatoSenato"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/ufficioParlamentare"></see>
    /// </summary>
    let ufficioParlamentare = _prefix "ufficioParlamentare"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/gruppoParlamentare"></see>
    /// </summary>
    let gruppoParlamentare = _prefix "gruppoParlamentare"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/componenteGruppoMisto"></see>
    /// </summary>
    let componenteGruppoMisto = _prefix "componenteGruppoMisto"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/incarico"></see>
    /// </summary>
    let incarico = _prefix "incarico"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/aic"></see>
    /// </summary>
    let aic = _prefix "aic"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/luogo"></see>
    /// </summary>
    let luogo = _prefix "luogo"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/DOC"></see>
    /// </summary>
    let DOC = _prefix "DOC"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/ac"></see>
    /// </summary>
    let ac = _prefix "ac"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/documentazione"></see>
    /// </summary>
    let documentazione = _prefix "documentazione"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/dossier"></see>
    /// </summary>
    let dossier = _prefix "dossier"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/dottrina"></see>
    /// </summary>
    let dottrina = _prefix "dottrina"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/giurisprudenza"></see>
    /// </summary>
    let giurisprudenza = _prefix "giurisprudenza"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/normativa"></see>
    /// </summary>
    let normativa = _prefix "normativa"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/note"></see>
    /// </summary>
    let note = _prefix "note"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/pubblicistica"></see>
    /// </summary>
    let pubblicistica = _prefix "pubblicistica"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/aderisce"></see>
    /// </summary>
    let aderisce = _prefix "aderisce"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/deputato"></see>
    /// </summary>
    let deputato = _prefix "deputato"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/adesioneGruppo"></see>
    /// </summary>
    let adesioneGruppo = _prefix "adesioneGruppo"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_gruppoParlamentare"></see>
    /// </summary>
    let rif_gruppoParlamentare = _prefix "rif_gruppoParlamentare"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/adesioneGruppoMisto"></see>
    /// </summary>
    let adesioneGruppoMisto = _prefix "adesioneGruppoMisto"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_componente"></see>
    /// </summary>
    let rif_componente = _prefix "rif_componente"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/lavori"></see>
    /// </summary>
    let lavori = _prefix "lavori"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/allegatoDiscussione"></see>
    /// </summary>
    let allegatoDiscussione = _prefix "allegatoDiscussione"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/altro_firmatario"></see>
    /// </summary>
    let altro_firmatario = _prefix "altro_firmatario"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/appartenenzaOrgano"></see>
    /// </summary>
    let appartenenzaOrgano = _prefix "appartenenzaOrgano"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_deputato"></see>
    /// </summary>
    let rif_deputato = _prefix "rif_deputato"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_organo"></see>
    /// </summary>
    let rif_organo = _prefix "rif_organo"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/approvato"></see>
    /// </summary>
    let approvato = _prefix "approvato"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/assemblea"></see>
    /// </summary>
    let assemblea = _prefix "assemblea"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/astenuti"></see>
    /// </summary>
    let astenuti = _prefix "astenuti"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/documenti"></see>
    /// </summary>
    let documenti = _prefix "documenti"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/autore"></see>
    /// </summary>
    let autore = _prefix "autore"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/bollettino"></see>
    /// </summary>
    let bollettino = _prefix "bollettino"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/cambioDenominazione"></see>
    /// </summary>
    let cambioDenominazione = _prefix "cambioDenominazione"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/carica"></see>
    /// </summary>
    let carica = _prefix "carica"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/circoscrizionePlurieletto"></see>
    /// </summary>
    let circoscrizionePlurieletto = _prefix "circoscrizionePlurieletto"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/componente"></see>
    /// </summary>
    let componente = _prefix "componente"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/composizioneOrgano"></see>
    /// </summary>
    let composizioneOrgano = _prefix "composizioneOrgano"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/concluso"></see>
    /// </summary>
    let concluso = _prefix "concluso"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/contrari"></see>
    /// </summary>
    let contrari = _prefix "contrari"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/convalida"></see>
    /// </summary>
    let convalida = _prefix "convalida"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/costituzionale"></see>
    /// </summary>
    let costituzionale = _prefix "costituzionale"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/cronologia"></see>
    /// </summary>
    let cronologia = _prefix "cronologia"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/denominazione"></see>
    /// </summary>
    let denominazione = _prefix "denominazione"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/persona"></see>
    /// </summary>
    let persona = _prefix "persona"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/destinatario"></see>
    /// </summary>
    let destinatario = _prefix "destinatario"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/dicastero"></see>
    /// </summary>
    let dicastero = _prefix "dicastero"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/diventa"></see>
    /// </summary>
    let diventa = _prefix "diventa"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/trasformazioneGruppo"></see>
    /// </summary>
    let trasformazioneGruppo = _prefix "trasformazioneGruppo"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/doc"></see>
    /// </summary>
    let doc = _prefix "doc"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/endDate"></see>
    /// </summary>
    let endDate = _prefix "endDate"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/fa_parte_della"></see>
    /// </summary>
    let fa_parte_della = _prefix "fa_parte_della"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/favorevoli"></see>
    /// </summary>
    let favorevoli = _prefix "favorevoli"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/griglia"></see>
    /// </summary>
    let griglia = _prefix "griglia"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/risorsa_web"></see>
    /// </summary>
    let risorsa_web = _prefix "risorsa_web"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/haMembro"></see>
    /// </summary>
    let haMembro = _prefix "haMembro"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/incaricoGovernativo"></see>
    /// </summary>
    let incaricoGovernativo = _prefix "incaricoGovernativo"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/incaricoGoverno"></see>
    /// </summary>
    let incaricoGoverno = _prefix "incaricoGoverno"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/iniziativa"></see>
    /// </summary>
    let iniziativa = _prefix "iniziativa"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/interim"></see>
    /// </summary>
    let interim = _prefix "interim"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/lavoriPreparatori"></see>
    /// </summary>
    let lavoriPreparatori = _prefix "lavoriPreparatori"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/lavoriPreparatoriLegge"></see>
    /// </summary>
    let lavoriPreparatoriLegge = _prefix "lavoriPreparatoriLegge"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/legge"></see>
    /// </summary>
    let legge = _prefix "legge"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/lex"></see>
    /// </summary>
    let lex = _prefix "lex"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/lista"></see>
    /// </summary>
    let lista = _prefix "lista"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/maggioranza"></see>
    /// </summary>
    let maggioranza = _prefix "maggioranza"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/membro"></see>
    /// </summary>
    let membro = _prefix "membro"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/membroConsulta"></see>
    /// </summary>
    let membroConsulta = _prefix "membroConsulta"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/motivoTermine"></see>
    /// </summary>
    let motivoTermine = _prefix "motivoTermine"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/name"></see>
    /// </summary>
    let name = _prefix "name"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/nomina"></see>
    /// </summary>
    let nomina = _prefix "nomina"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/opzione"></see>
    /// </summary>
    let opzione = _prefix "opzione"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/parentADM1"></see>
    /// </summary>
    let parentADM1 = _prefix "parentADM1"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/parentADM2"></see>
    /// </summary>
    let parentADM2 = _prefix "parentADM2"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/parentADM3"></see>
    /// </summary>
    let parentADM3 = _prefix "parentADM3"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/parentCountry"></see>
    /// </summary>
    let parentCountry = _prefix "parentCountry"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/plurieletto"></see>
    /// </summary>
    let plurieletto = _prefix "plurieletto"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/presenti"></see>
    /// </summary>
    let presenti = _prefix "presenti"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/presidenteRepubblica"></see>
    /// </summary>
    let presidenteRepubblica = _prefix "presidenteRepubblica"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/primo_firmatario"></see>
    /// </summary>
    let primo_firmatario = _prefix "primo_firmatario"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/proclamazione"></see>
    /// </summary>
    let proclamazione = _prefix "proclamazione"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/relatore"></see>
    /// </summary>
    let relatore = _prefix "relatore"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/richiestaFiducia"></see>
    /// </summary>
    let richiestaFiducia = _prefix "richiestaFiducia"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_abbinamento"></see>
    /// </summary>
    let rif_abbinamento = _prefix "rif_abbinamento"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_allegatoDiscussione"></see>
    /// </summary>
    let rif_allegatoDiscussione = _prefix "rif_allegatoDiscussione"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_assegnazione"></see>
    /// </summary>
    let rif_assegnazione = _prefix "rif_assegnazione"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_attoCamera"></see>
    /// </summary>
    let rif_attoCamera = _prefix "rif_attoCamera"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_bollettino"></see>
    /// </summary>
    let rif_bollettino = _prefix "rif_bollettino"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_dibattito"></see>
    /// </summary>
    let rif_dibattito = _prefix "rif_dibattito"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_discussione"></see>
    /// </summary>
    let rif_discussione = _prefix "rif_discussione"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_doc"></see>
    /// </summary>
    let rif_doc = _prefix "rif_doc"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_dossier"></see>
    /// </summary>
    let rif_dossier = _prefix "rif_dossier"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_elezione"></see>
    /// </summary>
    let rif_elezione = _prefix "rif_elezione"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_governo"></see>
    /// </summary>
    let rif_governo = _prefix "rif_governo"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_incarico"></see>
    /// </summary>
    let rif_incarico = _prefix "rif_incarico"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_incaricoGoverno"></see>
    /// </summary>
    let rif_incaricoGoverno = _prefix "rif_incaricoGoverno"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_intervento"></see>
    /// </summary>
    let rif_intervento = _prefix "rif_intervento"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_leg"></see>
    /// </summary>
    let rif_leg = _prefix "rif_leg"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_luogo"></see>
    /// </summary>
    let rif_luogo = _prefix "rif_luogo"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_mandatoCamera"></see>
    /// </summary>
    let rif_mandatoCamera = _prefix "rif_mandatoCamera"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_mandatoSenato"></see>
    /// </summary>
    let rif_mandatoSenato = _prefix "rif_mandatoSenato"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_membroGoverno"></see>
    /// </summary>
    let rif_membroGoverno = _prefix "rif_membroGoverno"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_natura"></see>
    /// </summary>
    let rif_natura = _prefix "rif_natura"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_organoGoverno"></see>
    /// </summary>
    let rif_organoGoverno = _prefix "rif_organoGoverno"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_persona"></see>
    /// </summary>
    let rif_persona = _prefix "rif_persona"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_presidenteConsiglioMinistri"></see>
    /// </summary>
    let rif_presidenteConsiglioMinistri = _prefix "rif_presidenteConsiglioMinistri"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_richiestaParere"></see>
    /// </summary>
    let rif_richiestaParere = _prefix "rif_richiestaParere"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_seduta"></see>
    /// </summary>
    let rif_seduta = _prefix "rif_seduta"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_senatore"></see>
    /// </summary>
    let rif_senatore = _prefix "rif_senatore"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_sistemaElettorale"></see>
    /// </summary>
    let rif_sistemaElettorale = _prefix "rif_sistemaElettorale"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_statoIter"></see>
    /// </summary>
    let rif_statoIter = _prefix "rif_statoIter"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_trasmissione"></see>
    /// </summary>
    let rif_trasmissione = _prefix "rif_trasmissione"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/trasmissione"></see>
    /// </summary>
    let trasmissione = _prefix "trasmissione"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_ufficioParlamentare"></see>
    /// </summary>
    let rif_ufficioParlamentare = _prefix "rif_ufficioParlamentare"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_unitaOrganizzativa"></see>
    /// </summary>
    let rif_unitaOrganizzativa = _prefix "rif_unitaOrganizzativa"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/unitaOrganizzativa"></see>
    /// </summary>
    let unitaOrganizzativa = _prefix "unitaOrganizzativa"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_versioneTestoAtto"></see>
    /// </summary>
    let rif_versioneTestoAtto = _prefix "rif_versioneTestoAtto"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/versioneTestoAtto"></see>
    /// </summary>
    let versioneTestoAtto = _prefix "versioneTestoAtto"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rif_votazione"></see>
    /// </summary>
    let rif_votazione = _prefix "rif_votazione"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/risposta"></see>
    /// </summary>
    let risposta = _prefix "risposta"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/rispostaAIC"></see>
    /// </summary>
    let rispostaAIC = _prefix "rispostaAIC"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/ruolo"></see>
    /// </summary>
    let ruolo = _prefix "ruolo"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/siComponeDi"></see>
    /// </summary>
    let siComponeDi = _prefix "siComponeDi"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/startDate"></see>
    /// </summary>
    let startDate = _prefix "startDate"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/tipoElezione"></see>
    /// </summary>
    let tipoElezione = _prefix "tipoElezione"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/tipoProclamazione"></see>
    /// </summary>
    let tipoProclamazione = _prefix "tipoProclamazione"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/tipologia"></see>
    /// </summary>
    let tipologia = _prefix "tipologia"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/votanti"></see>
    /// </summary>
    let votanti = _prefix "votanti"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/votazioneFinale"></see>
    /// </summary>
    let votazioneFinale = _prefix "votazioneFinale"
    /// <summary>
    ///   <see href="http://dati.camera.it/ocd/votazioneSegreta"></see>
    /// </summary>
    let votazioneSegreta = _prefix "votazioneSegreta"
