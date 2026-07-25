namespace http.dati.camera.it.ocd.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ocd =
    let _namespace_iri = Namespace_Iri ocd |> NamespaceIRI
    /// <summary>
    ///   <para>ocd:organo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>organo</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/organo">http://dati.camera.it/ocd/organo</seealso>
    let organo = Prefixed_Name(ocd, "organo") |> PrefixedName
    /// <summary>
    ///   <para>ocd:organoGoverno</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>la classe fa riferimento agli organi monocratici o collegiali, necessari e non, che costituiscono il governo: Presidente del Consiglio, singoli Ministri,,Consiglio dei Ministri, Consiglio di Gabinetto, Comitati di Ministri e Comitati interministeriali, Vice-presidenti del Consiglio, Ministri senza portafoglio, Sottosegretari di Stato, Vice-ministri e Commissari straordinari</para>
    /// labels<para>organo governativo</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/organoGoverno">http://dati.camera.it/ocd/organoGoverno</seealso>
    let organoGoverno = Prefixed_Name(ocd, "organoGoverno") |> PrefixedName
    /// <summary>
    ///   <para>ocd:dibattito</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>dibattito</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/dibattito">http://dati.camera.it/ocd/dibattito</seealso>
    let dibattito = Prefixed_Name(ocd, "dibattito") |> PrefixedName
    /// <summary>
    ///   <para>ocd:seduta</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>seduta</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/seduta">http://dati.camera.it/ocd/seduta</seealso>
    let seduta = Prefixed_Name(ocd, "seduta") |> PrefixedName
    /// <summary>
    ///   <para>ocd:richiestaParere</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>richiesta del parere su un atto camera ad un organo</para>
    /// labels<para>richiesta parere</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/richiestaParere">http://dati.camera.it/ocd/richiestaParere</seealso>
    let richiestaParere = Prefixed_Name(ocd, "richiestaParere") |> PrefixedName
    /// <summary>
    ///   <para>ocd:stralcio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>stralcio di un atto camera</para>
    /// labels<para>stralcio</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/stralcio">http://dati.camera.it/ocd/stralcio</seealso>
    let stralcio = Prefixed_Name(ocd, "stralcio") |> PrefixedName
    /// <summary>
    ///   <para>ocd:assegnazione</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>assegnazione dell'atto camera ad un organo</para>
    /// labels<para>assegnazione</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/assegnazione">http://dati.camera.it/ocd/assegnazione</seealso>
    let assegnazione = Prefixed_Name(ocd, "assegnazione") |> PrefixedName
    /// <summary>
    ///   <para>ocd:discussione</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>discussione</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/discussione">http://dati.camera.it/ocd/discussione</seealso>
    let discussione = Prefixed_Name(ocd, "discussione") |> PrefixedName
    /// <summary>
    ///   <para>ocd:votazione</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>votazione</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/votazione">http://dati.camera.it/ocd/votazione</seealso>
    let votazione = Prefixed_Name(ocd, "votazione") |> PrefixedName
    /// <summary>
    ///   <para>ocd:sistemaElettorale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>La classe contiene le normative applicate nelle consultazioni elettorali dal regno di Sardegna alla Repubblica: maggioritario uninominale (1848 - 1880); maggioritario: scrutinio di lista (1882 - 1890); maggioritario: uninominale (1892 - 1913); proporzionale (1919 - 1921); lista unica (1929 - 1934);
    /// proporzionale (1946 - 1993); misto: maggioritario e proporzionale (1994-2005); proporzionale con premio di maggioranza (2006-2011)</para>
    /// labels<para>sistema elettorale</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/sistemaElettorale">http://dati.camera.it/ocd/sistemaElettorale</seealso>
    let sistemaElettorale = Prefixed_Name(ocd, "sistemaElettorale") |> PrefixedName
    /// <summary>
    ///   <para>ocd:senatore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>senatore</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/senatore">http://dati.camera.it/ocd/senatore</seealso>
    let senatore = Prefixed_Name(ocd, "senatore") |> PrefixedName
    /// <summary>
    ///   <para>ocd:mandatoSenato</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>La classe fa riferimento allo status di senatore assunto da una persona  - candidato in elezioni politiche -  in seguito ad un voto popolare</para>
    /// labels<para>mandato</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/mandatoSenato">http://dati.camera.it/ocd/mandatoSenato</seealso>
    let mandatoSenato = Prefixed_Name(ocd, "mandatoSenato") |> PrefixedName
    /// <summary>
    ///   <para>ocd:gruppoParlamentare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>La classe fa riferimento ai gruppi dei partiti o movimenti politici rappresentati alla Camera. Secondo il Regolamento della Camera ogni deputato deve necessariamente appartenere ad un gruppo</para>
    /// labels<para>gruppo parlamentare</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/gruppoParlamentare">http://dati.camera.it/ocd/gruppoParlamentare</seealso>
    let gruppoParlamentare = Prefixed_Name(ocd, "gruppoParlamentare") |> PrefixedName
    /// <summary>
    ///   <para>ocd:approvato</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>approvato</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/approvato">http://dati.camera.it/ocd/approvato</seealso>
    let approvato = Prefixed_Name(ocd, "approvato") |> PrefixedName
    /// <summary>
    ///   <para>ocd:autore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>è la classe che identifica le persone autori di pubblicazioni presenti in BPR.</para>
    /// labels<para>autore</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/autore">http://dati.camera.it/ocd/autore</seealso>
    let autore = Prefixed_Name(ocd, "autore") |> PrefixedName
    /// <summary>
    ///   <para>ocd:cambioDenominazione</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>questa classe è utilizzata per gestire i cambi di denominazione del Gruppo Parlamentare</para>
    /// labels<para>cambio denominazione del Gruppo Parlamentare</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/cambioDenominazione">http://dati.camera.it/ocd/cambioDenominazione</seealso>
    let cambioDenominazione = Prefixed_Name(ocd, "cambioDenominazione") |> PrefixedName
    /// <summary>
    ///   <para>ocd:carica</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>identifica la tipologia della carica all'interno dell'Ufficio parlamentare</para>
    /// labels<para>dicastero</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/carica">http://dati.camera.it/ocd/carica</seealso>
    let carica = Prefixed_Name(ocd, "carica") |> PrefixedName

    /// <summary>
    ///   <para>ocd:circoscrizionePlurieletto</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>questa classe è stata creata per gestire la descrizione di tutte le circoscrizione dei plurieletti</para>
    /// labels<para>circoscrizioni per plurieletti</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/circoscrizionePlurieletto">http://dati.camera.it/ocd/circoscrizionePlurieletto</seealso>
    let circoscrizionePlurieletto =
        Prefixed_Name(ocd, "circoscrizionePlurieletto") |> PrefixedName

    /// <summary>
    ///   <para>ocd:componente</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>proprietà utilizzata per descrivere l'adesione di un deputato ad una componente del gruppo misto</para>
    /// labels<para>componente</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/componente">http://dati.camera.it/ocd/componente</seealso>
    let componente = Prefixed_Name(ocd, "componente") |> PrefixedName
    /// <summary>
    ///   <para>ocd:concluso</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>per indicare lo status di un atto di indirizzo e controllo</para>
    /// labels<para>costituzionale</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/concluso">http://dati.camera.it/ocd/concluso</seealso>
    let concluso = Prefixed_Name(ocd, "concluso") |> PrefixedName
    /// <summary>
    ///   <para>ocd:costituzionale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>per indicare se un atto camera è costituzionale o ordinario</para>
    /// labels<para>costituzionale</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/costituzionale">http://dati.camera.it/ocd/costituzionale</seealso>
    let costituzionale = Prefixed_Name(ocd, "costituzionale") |> PrefixedName
    /// <summary>
    ///   <para>ocd:persona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>è la classe che identifica la persona che ha svolto qualche ruolo all'interno della Camera dei deputati. La persona che ha un mandato parlamentare è anche un deputato. Ad una persona possono corripondere 0-n deputati.</para>
    /// labels<para>persona</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/persona">http://dati.camera.it/ocd/persona</seealso>
    let persona = Prefixed_Name(ocd, "persona") |> PrefixedName
    /// <summary>
    ///   <para>ocd:destinatario</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>proprietà che designa l'organo di Governo destinatario</para>
    /// labels<para>componente</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/destinatario">http://dati.camera.it/ocd/destinatario</seealso>
    let destinatario = Prefixed_Name(ocd, "destinatario") |> PrefixedName

    /// <summary>
    ///   <para>ocd:trasformazioneGruppo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>classe per gestire scissioni, accorpamenti, promozioni o riduzione a componente dei Gruppi Parlamentari</para>
    /// labels<para>trasformazione del Gruppo Parlamentare</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/trasformazioneGruppo">http://dati.camera.it/ocd/trasformazioneGruppo</seealso>
    let trasformazioneGruppo =
        Prefixed_Name(ocd, "trasformazioneGruppo") |> PrefixedName

    /// <summary>
    ///   <para>ocd:doc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>puntamento alla URL del DOC</para>
    /// labels<para>URL del DOC</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/doc">http://dati.camera.it/ocd/doc</seealso>
    let doc = Prefixed_Name(ocd, "doc") |> PrefixedName
    /// <summary>
    ///   <para>ocd:endDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>estremo finale di un range di date</para>
    /// labels<para>data fine</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/endDate">http://dati.camera.it/ocd/endDate</seealso>
    let endDate = Prefixed_Name(ocd, "endDate") |> PrefixedName
    /// <summary>
    ///   <para>ocd:fa_parte_della</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>proprietà che collega una risorsa deputato ad una specifica legislatura</para>
    /// labels<para>appartiene alla legislatura</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/fa_parte_della">http://dati.camera.it/ocd/fa_parte_della</seealso>
    let fa_parte_della = Prefixed_Name(ocd, "fa_parte_della") |> PrefixedName
    /// <summary>
    ///   <para>ocd:favorevoli</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>voti favorevoli</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/favorevoli">http://dati.camera.it/ocd/favorevoli</seealso>
    let favorevoli = Prefixed_Name(ocd, "favorevoli") |> PrefixedName
    /// <summary>
    ///   <para>ocd:griglia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>riferimento ai concetti delle griglie tematiche di TheCa</para>
    /// labels<para>griglia</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/griglia">http://dati.camera.it/ocd/griglia</seealso>
    let griglia = Prefixed_Name(ocd, "griglia") |> PrefixedName
    /// <summary>
    ///   <para>ocd:risorsa_web</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>risorsa_web</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/risorsa_web">http://dati.camera.it/ocd/risorsa_web</seealso>
    let risorsa_web = Prefixed_Name(ocd, "risorsa_web") |> PrefixedName
    /// <summary>
    ///   <para>ocd:haMembro</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>propreità utilizzata per descrivere le composizioni degli organi parlamentari</para>
    /// labels<para>ha membro</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/haMembro">http://dati.camera.it/ocd/haMembro</seealso>
    let haMembro = Prefixed_Name(ocd, "haMembro") |> PrefixedName
    /// <summary>
    ///   <para>ocd:incaricoGovernativo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>per indicare la qualifica di incarico di Governo ricporta</para>
    /// labels<para>incarico governativo</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/incaricoGovernativo">http://dati.camera.it/ocd/incaricoGovernativo</seealso>
    let incaricoGovernativo = Prefixed_Name(ocd, "incaricoGovernativo") |> PrefixedName
    /// <summary>
    ///   <para>ocd:incaricoGoverno</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>è la classe che identifica gli incarichi governativi assegnati ai deputati</para>
    /// labels<para>incarico di Governo</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/incaricoGoverno">http://dati.camera.it/ocd/incaricoGoverno</seealso>
    let incaricoGoverno = Prefixed_Name(ocd, "incaricoGoverno") |> PrefixedName
    /// <summary>
    ///   <para>ocd:iniziativa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>per indicare se l'atto camera è di iniziativa popolare, parlamentare o mista</para>
    /// labels<para>iniziativa</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/iniziativa">http://dati.camera.it/ocd/iniziativa</seealso>
    let iniziativa = Prefixed_Name(ocd, "iniziativa") |> PrefixedName
    /// <summary>
    ///   <para>ocd:interim</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>utilizzata per gestire le cariche ad interim</para>
    /// labels<para>interim</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/interim">http://dati.camera.it/ocd/interim</seealso>
    let interim = Prefixed_Name(ocd, "interim") |> PrefixedName
    /// <summary>
    ///   <para>ocd:lavoriPreparatori</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>lavori preparatori</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/lavoriPreparatori">http://dati.camera.it/ocd/lavoriPreparatori</seealso>
    let lavoriPreparatori = Prefixed_Name(ocd, "lavoriPreparatori") |> PrefixedName

    /// <summary>
    ///   <para>ocd:lavoriPreparatoriLegge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>riferimento ai lavori preparatori di una legge</para>
    /// labels<para>lavori preparatori</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/lavoriPreparatoriLegge">http://dati.camera.it/ocd/lavoriPreparatoriLegge</seealso>
    let lavoriPreparatoriLegge =
        Prefixed_Name(ocd, "lavoriPreparatoriLegge") |> PrefixedName

    /// <summary>
    ///   <para>ocd:legge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>legge</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/legge">http://dati.camera.it/ocd/legge</seealso>
    let legge = Prefixed_Name(ocd, "legge") |> PrefixedName
    /// <summary>
    ///   <para>ocd:lex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>riferimento esterno alla norma ufficiale</para>
    /// labels<para>legge</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/lex">http://dati.camera.it/ocd/lex</seealso>
    let lex = Prefixed_Name(ocd, "lex") |> PrefixedName
    /// <summary>
    ///   <para>ocd:lista</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Lista di appartenenza</para>
    /// labels<para>lista</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/lista">http://dati.camera.it/ocd/lista</seealso>
    let lista = Prefixed_Name(ocd, "lista") |> PrefixedName
    /// <summary>
    ///   <para>ocd:maggioranza</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>numero maggioranza</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/maggioranza">http://dati.camera.it/ocd/maggioranza</seealso>
    let maggioranza = Prefixed_Name(ocd, "maggioranza") |> PrefixedName
    /// <summary>
    ///   <para>ocd:membroConsulta</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>membro</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/membroConsulta">http://dati.camera.it/ocd/membroConsulta</seealso>
    let membroConsulta = Prefixed_Name(ocd, "membroConsulta") |> PrefixedName
    /// <summary>
    ///   <para>ocd:motivoTermine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>motivo termine del mandato</para>
    /// labels<para>motivo termine mandato</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/motivoTermine">http://dati.camera.it/ocd/motivoTermine</seealso>
    let motivoTermine = Prefixed_Name(ocd, "motivoTermine") |> PrefixedName
    /// <summary>
    ///   <para>ocd:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>nome del luogo</para>
    /// labels<para>nome del luogo</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/name">http://dati.camera.it/ocd/name</seealso>
    let name = Prefixed_Name(ocd, "name") |> PrefixedName
    /// <summary>
    ///   <para>ocd:nomina</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>descrive la relazione tra legislatura e assemblea</para>
    /// labels<para>nomina</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/nomina">http://dati.camera.it/ocd/nomina</seealso>
    let nomina = Prefixed_Name(ocd, "nomina") |> PrefixedName
    /// <summary>
    ///   <para>ocd:opzione</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>data di opzione in una elezione</para>
    /// labels<para>data di opzione</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/opzione">http://dati.camera.it/ocd/opzione</seealso>
    let opzione = Prefixed_Name(ocd, "opzione") |> PrefixedName
    /// <summary>
    ///   <para>ocd:parentADM1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>primo livello di divisione amministrativa</para>
    /// labels<para>ADM1</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/parentADM1">http://dati.camera.it/ocd/parentADM1</seealso>
    let parentADM1 = Prefixed_Name(ocd, "parentADM1") |> PrefixedName
    /// <summary>
    ///   <para>ocd:parentADM2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>secondo livello di divisione amministrativa</para>
    /// labels<para>ADM2</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/parentADM2">http://dati.camera.it/ocd/parentADM2</seealso>
    let parentADM2 = Prefixed_Name(ocd, "parentADM2") |> PrefixedName
    /// <summary>
    ///   <para>ocd:parentADM3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>terzo livello di divisione amministrativa</para>
    /// labels<para>ADM3</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/parentADM3">http://dati.camera.it/ocd/parentADM3</seealso>
    let parentADM3 = Prefixed_Name(ocd, "parentADM3") |> PrefixedName
    /// <summary>
    ///   <para>ocd:parentCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>nazione</para>
    /// labels<para>parentCountry</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/parentCountry">http://dati.camera.it/ocd/parentCountry</seealso>
    let parentCountry = Prefixed_Name(ocd, "parentCountry") |> PrefixedName
    /// <summary>
    ///   <para>ocd:presenti</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>numero presenti</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/presenti">http://dati.camera.it/ocd/presenti</seealso>
    let presenti = Prefixed_Name(ocd, "presenti") |> PrefixedName

    /// <summary>
    ///   <para>ocd:presidenteRepubblica</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>presidente della Repubblica</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/presidenteRepubblica">http://dati.camera.it/ocd/presidenteRepubblica</seealso>
    let presidenteRepubblica =
        Prefixed_Name(ocd, "presidenteRepubblica") |> PrefixedName

    /// <summary>
    ///   <para>ocd:primo_firmatario</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>indica il primo firmatario del documento</para>
    /// labels<para>primo firmatario</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/primo_firmatario">http://dati.camera.it/ocd/primo_firmatario</seealso>
    let primo_firmatario = Prefixed_Name(ocd, "primo_firmatario") |> PrefixedName
    /// <summary>
    ///   <para>ocd:proclamazione</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>questa classe è stata creata per gestire subentri e sostituzioni nel mandato camera</para>
    /// labels<para>proclamazione</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/proclamazione">http://dati.camera.it/ocd/proclamazione</seealso>
    let proclamazione = Prefixed_Name(ocd, "proclamazione") |> PrefixedName
    /// <summary>
    ///   <para>ocd:relatore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>relatore di un atto camera</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/relatore">http://dati.camera.it/ocd/relatore</seealso>
    let relatore = Prefixed_Name(ocd, "relatore") |> PrefixedName
    /// <summary>
    ///   <para>ocd:richiestaFiducia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>richiesta della fiducia</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/richiestaFiducia">http://dati.camera.it/ocd/richiestaFiducia</seealso>
    let richiestaFiducia = Prefixed_Name(ocd, "richiestaFiducia") |> PrefixedName
    /// <summary>
    ///   <para>ocd:rif_abbinamento</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>riferimento all'abbinamento dell'atto camera con altri atti</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/rif_abbinamento">http://dati.camera.it/ocd/rif_abbinamento</seealso>
    let rif_abbinamento = Prefixed_Name(ocd, "rif_abbinamento") |> PrefixedName

    /// <summary>
    ///   <para>ocd:rif_allegatoDiscussione</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>riferimento all'allegato di una discussione</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/rif_allegatoDiscussione">http://dati.camera.it/ocd/rif_allegatoDiscussione</seealso>
    let rif_allegatoDiscussione =
        Prefixed_Name(ocd, "rif_allegatoDiscussione") |> PrefixedName

    /// <summary>
    ///   <para>ocd:rif_bollettino</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>riferimento al bollettino</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/rif_bollettino">http://dati.camera.it/ocd/rif_bollettino</seealso>
    let rif_bollettino = Prefixed_Name(ocd, "rif_bollettino") |> PrefixedName
    /// <summary>
    ///   <para>ocd:rif_dibattito</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>riferimento al dibattito</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/rif_dibattito">http://dati.camera.it/ocd/rif_dibattito</seealso>
    let rif_dibattito = Prefixed_Name(ocd, "rif_dibattito") |> PrefixedName
    /// <summary>
    ///   <para>ocd:rif_discussione</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>un dabattito può avere più discussioni</para>
    /// labels<para>riferimento alla discussione</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/rif_discussione">http://dati.camera.it/ocd/rif_discussione</seealso>
    let rif_discussione = Prefixed_Name(ocd, "rif_discussione") |> PrefixedName
    /// <summary>
    ///   <para>ocd:rif_doc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>un doc può fare riferimento ad un altro DOC</para>
    /// labels<para>riferimento al doc</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/rif_doc">http://dati.camera.it/ocd/rif_doc</seealso>
    let rif_doc = Prefixed_Name(ocd, "rif_doc") |> PrefixedName
    /// <summary>
    ///   <para>ocd:rif_dossier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>riferimento ad un altro dossier citato nell'atto camera</para>
    /// labels<para>riferimento al dossier</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/rif_dossier">http://dati.camera.it/ocd/rif_dossier</seealso>
    let rif_dossier = Prefixed_Name(ocd, "rif_dossier") |> PrefixedName
    /// <summary>
    ///   <para>ocd:rif_elezione</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>riferimento all'elezione</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/rif_elezione">http://dati.camera.it/ocd/rif_elezione</seealso>
    let rif_elezione = Prefixed_Name(ocd, "rif_elezione") |> PrefixedName
    /// <summary>
    ///   <para>ocd:rif_governo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>riferimento al Governo</para>
    /// labels<para>riferimento al governo</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/rif_governo">http://dati.camera.it/ocd/rif_governo</seealso>
    let rif_governo = Prefixed_Name(ocd, "rif_governo") |> PrefixedName
    /// <summary>
    ///   <para>ocd:rif_incarico</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>riferimento all'incarico nel Gruppo parlamentare</para>
    /// labels<para>riferimento all'incarico</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/rif_incarico">http://dati.camera.it/ocd/rif_incarico</seealso>
    let rif_incarico = Prefixed_Name(ocd, "rif_incarico") |> PrefixedName
    /// <summary>
    ///   <para>ocd:rif_intervento</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>riferimento all'intervento del deputato o del membro di governo in una discussione</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/rif_intervento">http://dati.camera.it/ocd/rif_intervento</seealso>
    let rif_intervento = Prefixed_Name(ocd, "rif_intervento") |> PrefixedName
    /// <summary>
    ///   <para>ocd:rif_leg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>proprietà generica utilizzata ovunque tra le risorse per specificare l'appartenenza ad una legislatura</para>
    /// labels<para>riferimento alla legislatura</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/rif_leg">http://dati.camera.it/ocd/rif_leg</seealso>
    let rif_leg = Prefixed_Name(ocd, "rif_leg") |> PrefixedName
    /// <summary>
    ///   <para>ocd:rif_luogo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>riferimento al luogo</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/rif_luogo">http://dati.camera.it/ocd/rif_luogo</seealso>
    let rif_luogo = Prefixed_Name(ocd, "rif_luogo") |> PrefixedName
    /// <summary>
    ///   <para>ocd:rif_mandatoCamera</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>serve a collegare il deputato al mandato elettorale</para>
    /// labels<para>riferimento a mandato camera</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/rif_mandatoCamera">http://dati.camera.it/ocd/rif_mandatoCamera</seealso>
    let rif_mandatoCamera = Prefixed_Name(ocd, "rif_mandatoCamera") |> PrefixedName
    /// <summary>
    ///   <para>ocd:rif_mandatoSenato</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>serve a collegare il deputato al mandato di senatore</para>
    /// labels<para>riferimento a mandato senato</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/rif_mandatoSenato">http://dati.camera.it/ocd/rif_mandatoSenato</seealso>
    let rif_mandatoSenato = Prefixed_Name(ocd, "rif_mandatoSenato") |> PrefixedName
    /// <summary>
    ///   <para>ocd:rif_membroGoverno</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>riferimento al membro di Governo</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/rif_membroGoverno">http://dati.camera.it/ocd/rif_membroGoverno</seealso>
    let rif_membroGoverno = Prefixed_Name(ocd, "rif_membroGoverno") |> PrefixedName
    /// <summary>
    ///   <para>ocd:rif_natura</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>riferimento alla natura dell'atto camera</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/rif_natura">http://dati.camera.it/ocd/rif_natura</seealso>
    let rif_natura = Prefixed_Name(ocd, "rif_natura") |> PrefixedName
    /// <summary>
    ///   <para>ocd:rif_organoGoverno</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>proprietà utilizzata all'interno degli incarichi di governo per puntare all'organo di governo</para>
    /// labels<para>riferimento all'organo di governo</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/rif_organoGoverno">http://dati.camera.it/ocd/rif_organoGoverno</seealso>
    let rif_organoGoverno = Prefixed_Name(ocd, "rif_organoGoverno") |> PrefixedName
    /// <summary>
    ///   <para>ocd:rif_persona</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>propreità generica utilizzata per puntare ad una risorsa persona</para>
    /// labels<para>riferimento a persona</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/rif_persona">http://dati.camera.it/ocd/rif_persona</seealso>
    let rif_persona = Prefixed_Name(ocd, "rif_persona") |> PrefixedName

    /// <summary>
    ///   <para>ocd:rif_presidenteConsiglioMinistri</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>rierimento al Presidente del Consiglio dei ministri</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/rif_presidenteConsiglioMinistri">http://dati.camera.it/ocd/rif_presidenteConsiglioMinistri</seealso>
    let rif_presidenteConsiglioMinistri =
        Prefixed_Name(ocd, "rif_presidenteConsiglioMinistri") |> PrefixedName

    /// <summary>
    ///   <para>ocd:rif_richiestaParere</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>riferimento alla richesta dei pareri su un atto camera</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/rif_richiestaParere">http://dati.camera.it/ocd/rif_richiestaParere</seealso>
    let rif_richiestaParere = Prefixed_Name(ocd, "rif_richiestaParere") |> PrefixedName
    /// <summary>
    ///   <para>ocd:rif_seduta</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>in una seduta si svolgono più discussioni</para>
    /// labels<para>riferimento alla seduta</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/rif_seduta">http://dati.camera.it/ocd/rif_seduta</seealso>
    let rif_seduta = Prefixed_Name(ocd, "rif_seduta") |> PrefixedName
    /// <summary>
    ///   <para>ocd:rif_senatore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>proprietà utilizzata all'interno degli incarichi di governo per puntare all'organo di governo</para>
    /// labels<para>riferimento al senatore</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/rif_senatore">http://dati.camera.it/ocd/rif_senatore</seealso>
    let rif_senatore = Prefixed_Name(ocd, "rif_senatore") |> PrefixedName

    /// <summary>
    ///   <para>ocd:rif_sistemaElettorale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>questa proprietà collega ogni legislatura ad un sistema elettorale</para>
    /// labels<para>riferimento al sistema elettorale</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/rif_sistemaElettorale">http://dati.camera.it/ocd/rif_sistemaElettorale</seealso>
    let rif_sistemaElettorale =
        Prefixed_Name(ocd, "rif_sistemaElettorale") |> PrefixedName

    /// <summary>
    ///   <para>ocd:rif_statoIter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>riferimento allo stato iter di un atto camera</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/rif_statoIter">http://dati.camera.it/ocd/rif_statoIter</seealso>
    let rif_statoIter = Prefixed_Name(ocd, "rif_statoIter") |> PrefixedName
    /// <summary>
    ///   <para>ocd:rif_trasmissione</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>riferimento alla trasmissione di un atto camera all'altro ramo del parlamento</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/rif_trasmissione">http://dati.camera.it/ocd/rif_trasmissione</seealso>
    let rif_trasmissione = Prefixed_Name(ocd, "rif_trasmissione") |> PrefixedName
    /// <summary>
    ///   <para>ocd:trasmissione</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>trasmissione</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/trasmissione">http://dati.camera.it/ocd/trasmissione</seealso>
    let trasmissione = Prefixed_Name(ocd, "trasmissione") |> PrefixedName

    /// <summary>
    ///   <para>ocd:rif_ufficioParlamentare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>propreità che collega un organo agli uffici parlamentari</para>
    /// labels<para>riferimento ufficio parlamentare</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/rif_ufficioParlamentare">http://dati.camera.it/ocd/rif_ufficioParlamentare</seealso>
    let rif_ufficioParlamentare =
        Prefixed_Name(ocd, "rif_ufficioParlamentare") |> PrefixedName

    /// <summary>
    ///   <para>ocd:rif_unitaOrganizzativa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>puntamento dei documenti ad una unità organizzativa all'interno della struttura camera</para>
    /// labels<para>unità organizzativa</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/rif_unitaOrganizzativa">http://dati.camera.it/ocd/rif_unitaOrganizzativa</seealso>
    let rif_unitaOrganizzativa =
        Prefixed_Name(ocd, "rif_unitaOrganizzativa") |> PrefixedName

    /// <summary>
    ///   <para>ocd:rif_versioneTestoAtto</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>riferimento alla versione del testo dell'atto camera</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/rif_versioneTestoAtto">http://dati.camera.it/ocd/rif_versioneTestoAtto</seealso>
    let rif_versioneTestoAtto =
        Prefixed_Name(ocd, "rif_versioneTestoAtto") |> PrefixedName

    /// <summary>
    ///   <para>ocd:versioneTestoAtto</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>versione testo atto camera</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/versioneTestoAtto">http://dati.camera.it/ocd/versioneTestoAtto</seealso>
    let versioneTestoAtto = Prefixed_Name(ocd, "versioneTestoAtto") |> PrefixedName
    /// <summary>
    ///   <para>ocd:rif_votazione</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>riferimento alla votazione</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/rif_votazione">http://dati.camera.it/ocd/rif_votazione</seealso>
    let rif_votazione = Prefixed_Name(ocd, "rif_votazione") |> PrefixedName
    /// <summary>
    ///   <para>ocd:risposta</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>riferimento alla risposta scritta all'interrogazione</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/risposta">http://dati.camera.it/ocd/risposta</seealso>
    let risposta = Prefixed_Name(ocd, "risposta") |> PrefixedName
    /// <summary>
    ///   <para>ocd:rispostaAIC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>classe usata per individuare le risposte scritte alle interrogazioni parlamentari</para>
    /// labels<para>risposta scritta alle interrogazioni</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/rispostaAIC">http://dati.camera.it/ocd/rispostaAIC</seealso>
    let rispostaAIC = Prefixed_Name(ocd, "rispostaAIC") |> PrefixedName
    /// <summary>
    ///   <para>ocd:ruolo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>ruolo ricoperto</para>
    /// labels<para>ruolo</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/ruolo">http://dati.camera.it/ocd/ruolo</seealso>
    let ruolo = Prefixed_Name(ocd, "ruolo") |> PrefixedName
    /// <summary>
    ///   <para>ocd:siComponeDi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>proprietà utilizzata per descrivere la composizione dei deputati nell'assemblea e nei gruppi e degli orgnao nelle legislature</para>
    /// labels<para>si compone di</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/siComponeDi">http://dati.camera.it/ocd/siComponeDi</seealso>
    let siComponeDi = Prefixed_Name(ocd, "siComponeDi") |> PrefixedName
    /// <summary>
    ///   <para>ocd:ufficioParlamentare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>ufficioParlamentare è la classe che identifica tutte le cariche ricoperte dai deputati negli organi parlamentari</para>
    /// labels<para>ufficio Parlamentare</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/ufficioParlamentare">http://dati.camera.it/ocd/ufficioParlamentare</seealso>
    let ufficioParlamentare = Prefixed_Name(ocd, "ufficioParlamentare") |> PrefixedName
    /// <summary>
    ///   <para>ocd:intervento</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>intervento in una discussione</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/intervento">http://dati.camera.it/ocd/intervento</seealso>
    let intervento = Prefixed_Name(ocd, "intervento") |> PrefixedName
    /// <summary>
    ///   <para>ocd:natura</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>natura dell'atto camera</para>
    /// labels<para>natura</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/natura">http://dati.camera.it/ocd/natura</seealso>
    let natura = Prefixed_Name(ocd, "natura") |> PrefixedName
    /// <summary>
    ///   <para>ocd:elezione</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>elezione è la classe che identifica i dati di elezione di un sinoglo deputato (collegio, voti, sistema elettorale)</para>
    /// labels<para>elezione</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/elezione">http://dati.camera.it/ocd/elezione</seealso>
    let elezione = Prefixed_Name(ocd, "elezione") |> PrefixedName
    /// <summary>
    ///   <para>ocd:presidenteCamera</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>presidente della Camera dei deputati</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/presidenteCamera">http://dati.camera.it/ocd/presidenteCamera</seealso>
    let presidenteCamera = Prefixed_Name(ocd, "presidenteCamera") |> PrefixedName

    /// <summary>
    ///   <para>ocd:presidenteConsiglioMinistri</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>presidente del Consiglio dei ministri</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/presidenteConsiglioMinistri">http://dati.camera.it/ocd/presidenteConsiglioMinistri</seealso>
    let presidenteConsiglioMinistri =
        Prefixed_Name(ocd, "presidenteConsiglioMinistri") |> PrefixedName

    /// <summary>
    ///   <para>ocd:mandatoCamera</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>La classe fa riferimento allo status di deputato assunto da una persona  - candidato in elezioni politiche -  in seguito ad un voto popolare</para>
    /// labels<para>mandato</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/mandatoCamera">http://dati.camera.it/ocd/mandatoCamera</seealso>
    let mandatoCamera = Prefixed_Name(ocd, "mandatoCamera") |> PrefixedName

    /// <summary>
    ///   <para>ocd:componenteGruppoMisto</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>componenteGruppoMisto è la classe che identifica le compononeti di cui si compone il Gruppo Misto</para>
    /// labels<para>componente del Gruppo Misto</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/componenteGruppoMisto">http://dati.camera.it/ocd/componenteGruppoMisto</seealso>
    let componenteGruppoMisto =
        Prefixed_Name(ocd, "componenteGruppoMisto") |> PrefixedName

    /// <summary>
    ///   <para>ocd:aic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>è la classe che descrive le interrogazioni, domande che i parlamentari rivolgono al Governo per avere informazioni su fatti specifici e le interpellanze, domande che sollecitano chiarimenti sui motivi dell’azione politica del Governo</para>
    /// labels<para>atti di indirizzo e controllo</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/aic">http://dati.camera.it/ocd/aic</seealso>
    let aic = Prefixed_Name(ocd, "aic") |> PrefixedName
    /// <summary>
    ///   <para>ocd:luogo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>luogo</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/luogo">http://dati.camera.it/ocd/luogo</seealso>
    let luogo = Prefixed_Name(ocd, "luogo") |> PrefixedName
    /// <summary>
    ///   <para>ocd:composizioneOrgano</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>questa classe è stata creata per descrivere i membri di un organo</para>
    /// labels<para>composizione di un organo parlamentare</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/composizioneOrgano">http://dati.camera.it/ocd/composizioneOrgano</seealso>
    let composizioneOrgano = Prefixed_Name(ocd, "composizioneOrgano") |> PrefixedName
    /// <summary>
    ///   <para>ocd:contrari</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>voti contrari</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/contrari">http://dati.camera.it/ocd/contrari</seealso>
    let contrari = Prefixed_Name(ocd, "contrari") |> PrefixedName
    /// <summary>
    ///   <para>ocd:convalida</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>data di convalida del mandato camera</para>
    /// labels<para>data di convalida</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/convalida">http://dati.camera.it/ocd/convalida</seealso>
    let convalida = Prefixed_Name(ocd, "convalida") |> PrefixedName
    /// <summary>
    ///   <para>ocd:cronologia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>cronologia</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/cronologia">http://dati.camera.it/ocd/cronologia</seealso>
    let cronologia = Prefixed_Name(ocd, "cronologia") |> PrefixedName
    /// <summary>
    ///   <para>ocd:denominazione</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>proprietà utilizzata per gestire i cambi di denominazione</para>
    /// labels<para>denominazione</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/denominazione">http://dati.camera.it/ocd/denominazione</seealso>
    let denominazione = Prefixed_Name(ocd, "denominazione") |> PrefixedName
    /// <summary>
    ///   <para>ocd:dicastero</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>booleano per indicare se si tratta di un dicastero</para>
    /// labels<para>dicastero</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/dicastero">http://dati.camera.it/ocd/dicastero</seealso>
    let dicastero = Prefixed_Name(ocd, "dicastero") |> PrefixedName
    /// <summary>
    ///   <para>ocd:diventa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>propreità per gestire le trasformazione dei gruppi parlamentari</para>
    /// labels<para>diventa</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/diventa">http://dati.camera.it/ocd/diventa</seealso>
    let diventa = Prefixed_Name(ocd, "diventa") |> PrefixedName
    /// <summary>
    ///   <para>ocd:votazioneFinale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>votazione finale</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/votazioneFinale">http://dati.camera.it/ocd/votazioneFinale</seealso>
    let votazioneFinale = Prefixed_Name(ocd, "votazioneFinale") |> PrefixedName
    /// <summary>
    ///   <para>ocd:statoIter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>stato dell'iter dell'atto camera</para>
    /// labels<para>stato iter</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/statoIter">http://dati.camera.it/ocd/statoIter</seealso>
    let statoIter = Prefixed_Name(ocd, "statoIter") |> PrefixedName
    /// <summary>
    ///   <para>ocd:membroGoverno</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>è la classe che identifica gli incarichi governativi assegnati ai deputati</para>
    /// labels<para>membro di Governo</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/membroGoverno">http://dati.camera.it/ocd/membroGoverno</seealso>
    let membroGoverno = Prefixed_Name(ocd, "membroGoverno") |> PrefixedName
    /// <summary>
    ///   <para>ocd:legislatura</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>La classe fa riferimento al  periodo di durata del mandato parlamentare compreso fra le elezioni e lo scioglimento delle Camere. La legislatura si articola in sessioni e sedute</para>
    /// labels<para>legislatura</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/legislatura">http://dati.camera.it/ocd/legislatura</seealso>
    let legislatura = Prefixed_Name(ocd, "legislatura") |> PrefixedName
    /// <summary>
    ///   <para>ocd:rif_organo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>puntamento all'organo parlamentare citato</para>
    /// labels<para>riferimento all'organo</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/rif_organo">http://dati.camera.it/ocd/rif_organo</seealso>
    let rif_organo = Prefixed_Name(ocd, "rif_organo") |> PrefixedName
    /// <summary>
    ///   <para>ocd:assemblea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>la classe fa riferimento al  centro dell'attività della Camera,  dove si esercita la funzione legislativa, si concede o si revoca la fiducia al Governo, si discutono gli atti di indirizzo,  le interrogazioni e le interpellanze</para>
    /// labels<para>assemblea</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/assemblea">http://dati.camera.it/ocd/assemblea</seealso>
    let assemblea = Prefixed_Name(ocd, "assemblea") |> PrefixedName
    /// <summary>
    ///   <para>ocd:astenuti</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>numero astenuti</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/astenuti">http://dati.camera.it/ocd/astenuti</seealso>
    let astenuti = Prefixed_Name(ocd, "astenuti") |> PrefixedName
    /// <summary>
    ///   <para>ocd:documenti</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>documenti</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/documenti">http://dati.camera.it/ocd/documenti</seealso>
    let documenti = Prefixed_Name(ocd, "documenti") |> PrefixedName
    /// <summary>
    ///   <para>ocd:bollettino</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>bollettino</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/bollettino">http://dati.camera.it/ocd/bollettino</seealso>
    let bollettino = Prefixed_Name(ocd, "bollettino") |> PrefixedName
    /// <summary>
    ///   <para>ocd:tipoProclamazione</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>propreità utilizzata per descrivere la tipologia di proclamazione legata ad un mandato elettorale (per sostituzione, subentro, ...)</para>
    /// labels<para>tipologia proclamazione</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/tipoProclamazione">http://dati.camera.it/ocd/tipoProclamazione</seealso>
    let tipoProclamazione = Prefixed_Name(ocd, "tipoProclamazione") |> PrefixedName
    /// <summary>
    ///   <para>ocd:tipologia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>tipologia documentaria</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/tipologia">http://dati.camera.it/ocd/tipologia</seealso>
    let tipologia = Prefixed_Name(ocd, "tipologia") |> PrefixedName
    /// <summary>
    ///   <para>ocd:votanti</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>numero votanti</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/votanti">http://dati.camera.it/ocd/votanti</seealso>
    let votanti = Prefixed_Name(ocd, "votanti") |> PrefixedName
    /// <summary>
    ///   <para>ocd:incarico</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>è la classe che identifica gli incarichi all'interno dei gruppi parlamentari</para>
    /// labels<para>incarico</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/incarico">http://dati.camera.it/ocd/incarico</seealso>
    let incarico = Prefixed_Name(ocd, "incarico") |> PrefixedName
    /// <summary>
    ///   <para>ocd:votazioneSegreta</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>votazione segreta</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/votazioneSegreta">http://dati.camera.it/ocd/votazioneSegreta</seealso>
    let votazioneSegreta = Prefixed_Name(ocd, "votazioneSegreta") |> PrefixedName
    /// <summary>
    ///   <para>ocd:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>&lt;http://labs.mondeca.com/vocab/voaf#Vocabulary&gt;</para>
    /// </remarks>
    /// <seealso href="http://dati.camera.it/ocd/">http://dati.camera.it/ocd/</seealso>
    let _prefix_iri = Prefixed_Name(ocd, "") |> PrefixedName
    /// <summary>
    ///   <para>ocd:tipoElezione</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>tipo di elezione</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/tipoElezione">http://dati.camera.it/ocd/tipoElezione</seealso>
    let tipoElezione = Prefixed_Name(ocd, "tipoElezione") |> PrefixedName
    /// <summary>
    ///   <para>ocd:documentazione</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>documentazione</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/documentazione">http://dati.camera.it/ocd/documentazione</seealso>
    let documentazione = Prefixed_Name(ocd, "documentazione") |> PrefixedName
    /// <summary>
    ///   <para>ocd:rif_assegnazione</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>riferimento all'assegnazione dell'atto camera</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/rif_assegnazione">http://dati.camera.it/ocd/rif_assegnazione</seealso>
    let rif_assegnazione = Prefixed_Name(ocd, "rif_assegnazione") |> PrefixedName
    /// <summary>
    ///   <para>ocd:rif_attoCamera</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>riferimento agli altri atti camera citati</para>
    /// labels<para>riferimento all'atto camera</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/rif_attoCamera">http://dati.camera.it/ocd/rif_attoCamera</seealso>
    let rif_attoCamera = Prefixed_Name(ocd, "rif_attoCamera") |> PrefixedName
    /// <summary>
    ///   <para>ocd:membro</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>proprietà che collega un deputato ad un organo</para>
    /// labels<para>membro</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/membro">http://dati.camera.it/ocd/membro</seealso>
    let membro = Prefixed_Name(ocd, "membro") |> PrefixedName
    /// <summary>
    ///   <para>ocd:plurieletto</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>proprietà utilizzata per descrivere tutte le circoscrizioni di elezione di un plurieletto</para>
    /// labels<para>plurieletto</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/plurieletto">http://dati.camera.it/ocd/plurieletto</seealso>
    let plurieletto = Prefixed_Name(ocd, "plurieletto") |> PrefixedName
    /// <summary>
    ///   <para>ocd:ac</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>puntamento alla URL dell'atto camera</para>
    /// labels<para>URL dell'atto camera</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/ac">http://dati.camera.it/ocd/ac</seealso>
    let ac = Prefixed_Name(ocd, "ac") |> PrefixedName
    /// <summary>
    ///   <para>ocd:dottrina</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>dottrina</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/dottrina">http://dati.camera.it/ocd/dottrina</seealso>
    let dottrina = Prefixed_Name(ocd, "dottrina") |> PrefixedName
    /// <summary>
    ///   <para>ocd:giurisprudenza</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>giurisprudenza</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/giurisprudenza">http://dati.camera.it/ocd/giurisprudenza</seealso>
    let giurisprudenza = Prefixed_Name(ocd, "giurisprudenza") |> PrefixedName
    /// <summary>
    ///   <para>ocd:pubblicistica</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>pubblicistica</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/pubblicistica">http://dati.camera.it/ocd/pubblicistica</seealso>
    let pubblicistica = Prefixed_Name(ocd, "pubblicistica") |> PrefixedName
    /// <summary>
    ///   <para>ocd:deputato</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>La classe deputati comprende tutte le persone che hanno ricevuto un mandato parlamentare alla Camera</para>
    /// labels<para>deputato</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/deputato">http://dati.camera.it/ocd/deputato</seealso>
    let deputato = Prefixed_Name(ocd, "deputato") |> PrefixedName
    /// <summary>
    ///   <para>ocd:rif_componente</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dati.camera.it/ocd/rif_componente">http://dati.camera.it/ocd/rif_componente</seealso>
    let rif_componente = Prefixed_Name(ocd, "rif_componente") |> PrefixedName
    /// <summary>
    ///   <para>ocd:lavori</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>lavori</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/lavori">http://dati.camera.it/ocd/lavori</seealso>
    let lavori = Prefixed_Name(ocd, "lavori") |> PrefixedName
    /// <summary>
    ///   <para>ocd:altro_firmatario</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>indica gli altri firmatari del documento</para>
    /// labels<para>altro firmatario</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/altro_firmatario">http://dati.camera.it/ocd/altro_firmatario</seealso>
    let altro_firmatario = Prefixed_Name(ocd, "altro_firmatario") |> PrefixedName
    /// <summary>
    ///   <para>ocd:note</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>note</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/note">http://dati.camera.it/ocd/note</seealso>
    let note = Prefixed_Name(ocd, "note") |> PrefixedName
    /// <summary>
    ///   <para>ocd:rif_incaricoGoverno</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>riferimento all'incarico di Governo</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/rif_incaricoGoverno">http://dati.camera.it/ocd/rif_incaricoGoverno</seealso>
    let rif_incaricoGoverno = Prefixed_Name(ocd, "rif_incaricoGoverno") |> PrefixedName
    /// <summary>
    ///   <para>ocd:allegatoDiscussione</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>allegato ad una discussione</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/allegatoDiscussione">http://dati.camera.it/ocd/allegatoDiscussione</seealso>
    let allegatoDiscussione = Prefixed_Name(ocd, "allegatoDiscussione") |> PrefixedName
    /// <summary>
    ///   <para>ocd:appartenenzaOrgano</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>questa classe è stata creata per descrivere i membri di un organo</para>
    /// labels<para>appertenenza di un deputato ad un organo</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/appartenenzaOrgano">http://dati.camera.it/ocd/appartenenzaOrgano</seealso>
    let appartenenzaOrgano = Prefixed_Name(ocd, "appartenenzaOrgano") |> PrefixedName
    /// <summary>
    ///   <para>ocd:unitaOrganizzativa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>unitaOrganizzativa è la classe che identifica i dipartimenti/uffici in cui si struttura la Camera dei Deputati</para>
    /// labels<para>unità organizzativa</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/unitaOrganizzativa">http://dati.camera.it/ocd/unitaOrganizzativa</seealso>
    let unitaOrganizzativa = Prefixed_Name(ocd, "unitaOrganizzativa") |> PrefixedName
    /// <summary>
    ///   <para>ocd:rif_deputato</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>proprietà generica utilizzata per puntare alla risorsa deputato in vari punti dell'ontologia</para>
    /// labels<para>rierimento a deputato</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/rif_deputato">http://dati.camera.it/ocd/rif_deputato</seealso>
    let rif_deputato = Prefixed_Name(ocd, "rif_deputato") |> PrefixedName
    /// <summary>
    ///   <para>ocd:startDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>estremo iniziale di un range di date</para>
    /// labels<para>data inizio</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/startDate">http://dati.camera.it/ocd/startDate</seealso>
    let startDate = Prefixed_Name(ocd, "startDate") |> PrefixedName
    /// <summary>
    ///   <para>ocd:atto</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>la classe contiene proposte e disegni di legge</para>
    /// labels<para>atto camera</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/atto">http://dati.camera.it/ocd/atto</seealso>
    let atto = Prefixed_Name(ocd, "atto") |> PrefixedName
    /// <summary>
    ///   <para>ocd:abbinamento</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>abbinamento di un atto camera con altri atti</para>
    /// labels<para>abbinamento</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/abbinamento">http://dati.camera.it/ocd/abbinamento</seealso>
    let abbinamento = Prefixed_Name(ocd, "abbinamento") |> PrefixedName
    /// <summary>
    ///   <para>ocd:voto</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>voto del deputato in una votazione</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/voto">http://dati.camera.it/ocd/voto</seealso>
    let voto = Prefixed_Name(ocd, "voto") |> PrefixedName
    /// <summary>
    ///   <para>ocd:governo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>La classe fa riferimento all'istituzione cui è affidato dall'ordinamento giuridico l'esercizio della funzione esecutiva</para>
    /// labels<para>governo</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/governo">http://dati.camera.it/ocd/governo</seealso>
    let governo = Prefixed_Name(ocd, "governo") |> PrefixedName
    /// <summary>
    ///   <para>ocd:DOC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>la classe contiene i documenti parlamentari stampati dalla Camera dei deputati, i cosiddetti "DOC" in numero romano: documenti e relazioni, trasmessi alla Camera dal Governo o da altri soggetti istituzionali ovvero predisposti da organi della Camera stessa</para>
    /// labels<para>doc</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/DOC">http://dati.camera.it/ocd/DOC</seealso>
    let DOC = Prefixed_Name(ocd, "DOC") |> PrefixedName
    /// <summary>
    ///   <para>ocd:dossier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>la classe contiene i dossier di documentazione, analisi e materiali predisposti dai Servizi di documentazione della Camera a supporto dell'attività parlamentare</para>
    /// labels<para>dossier</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/dossier">http://dati.camera.it/ocd/dossier</seealso>
    let dossier = Prefixed_Name(ocd, "dossier") |> PrefixedName
    /// <summary>
    ///   <para>ocd:normativa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>la classe contiene le Gazzette ufficiale della Repubblica Italiana e dell'Unione Europea</para>
    /// labels<para>normativa</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/normativa">http://dati.camera.it/ocd/normativa</seealso>
    let normativa = Prefixed_Name(ocd, "normativa") |> PrefixedName
    /// <summary>
    ///   <para>ocd:aderisce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>adesione di un deputato ad un gruppo parlamentare</para>
    /// labels<para>aderisce</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/aderisce">http://dati.camera.it/ocd/aderisce</seealso>
    let aderisce = Prefixed_Name(ocd, "aderisce") |> PrefixedName
    /// <summary>
    ///   <para>ocd:adesioneGruppo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>questa classe è stata creata per gestire le adesioni dei deputati ai gruppi parlamentari</para>
    /// labels<para>adesione del deputato al Gruppo Parlamentare</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/adesioneGruppo">http://dati.camera.it/ocd/adesioneGruppo</seealso>
    let adesioneGruppo = Prefixed_Name(ocd, "adesioneGruppo") |> PrefixedName

    /// <summary>
    ///   <para>ocd:rif_gruppoParlamentare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>riferimento al Gruppo parlamentare</para>
    /// labels<para>riferimento al Gruppo parlamentare</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/rif_gruppoParlamentare">http://dati.camera.it/ocd/rif_gruppoParlamentare</seealso>
    let rif_gruppoParlamentare =
        Prefixed_Name(ocd, "rif_gruppoParlamentare") |> PrefixedName

    /// <summary>
    ///   <para>ocd:adesioneGruppoMisto</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>questa classe è stata creata per gestire le adesioni del Gruppo Misto</para>
    /// labels<para>adesione al Gruppo Misto</para></remarks>
    /// <seealso href="http://dati.camera.it/ocd/adesioneGruppoMisto">http://dati.camera.it/ocd/adesioneGruppoMisto</seealso>
    let adesioneGruppoMisto = Prefixed_Name(ocd, "adesioneGruppoMisto") |> PrefixedName
