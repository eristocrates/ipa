#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ocd =
    let _prefixId = PrefixId.fromNamespaceLabel "http://dati.camera.it/ocd/" "ocd"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : la classe contiene i documenti parlamentari stampati dalla Camera dei deputati, i cosiddetti "DOC" in numero romano: documenti e relazioni, trasmessi alla Camera dal Governo o da altri soggetti istituzionali ovvero predisposti da organi della Camera stessa</para>
    ///   <para>rdfs:label : doc^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/DOC">ocd:DOC</a>
    /// </summary>
    let DOC = _prefixId.prefix "DOC"
    /// <summary>
    ///   <para>owl:versionInfo : classe aggiunta nella versione del 2 maggio 2013^^xsd:string</para>
    ///   <para>rdfs:comment : abbinamento di un atto camera con altri atti</para>
    ///   <para>rdfs:label : abbinamento^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/abbinamento">ocd:abbinamento</a>
    /// </summary>
    let abbinamento = _prefixId.prefix "abbinamento"
    /// <summary>
    ///   <para>rdfs:comment : puntamento alla URL dell'atto camera</para>
    ///   <para>rdfs:label : URL dell'atto camera^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/ac">ocd:ac</a>
    /// </summary>
    let ac = _prefixId.prefix "ac"
    /// <summary>
    ///   <para>rdfs:comment : adesione di un deputato ad un gruppo parlamentare</para>
    ///   <para>rdfs:label : aderisce^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/aderisce">ocd:aderisce</a>
    /// </summary>
    let aderisce = _prefixId.prefix "aderisce"
    /// <summary>
    ///   <para>rdfs:comment : questa classe è stata creata per gestire le adesioni dei deputati ai gruppi parlamentari</para>
    ///   <para>rdfs:label : adesione del deputato al Gruppo Parlamentare^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/adesioneGruppo">ocd:adesioneGruppo</a>
    /// </summary>
    let adesioneGruppo = _prefixId.prefix "adesioneGruppo"
    /// <summary>
    ///   <para>rdfs:comment : questa classe è stata creata per gestire le adesioni del Gruppo Misto</para>
    ///   <para>rdfs:label : adesione al Gruppo Misto^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/adesioneGruppoMisto">ocd:adesioneGruppoMisto</a>
    /// </summary>
    let adesioneGruppoMisto = _prefixId.prefix "adesioneGruppoMisto"
    /// <summary>
    ///   <para>rdfs:comment : è la classe che descrive le interrogazioni, domande che i parlamentari rivolgono al Governo per avere informazioni su fatti specifici e le interpellanze, domande che sollecitano chiarimenti sui motivi dell’azione politica del Governo</para>
    ///   <para>rdfs:label : atti di indirizzo e controllo^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/aic">ocd:aic</a>
    /// </summary>
    let aic = _prefixId.prefix "aic"
    /// <summary>
    ///   <para>owl:versionInfo : classe aggiunta nella versione del 2 maggio 2013^^xsd:string</para>
    ///   <para>rdfs:label : allegato ad una discussione^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/allegatoDiscussione">ocd:allegatoDiscussione</a>
    /// </summary>
    let allegatoDiscussione = _prefixId.prefix "allegatoDiscussione"
    /// <summary>
    ///   <para>rdfs:comment : indica gli altri firmatari del documento</para>
    ///   <para>rdfs:label : altro firmatario^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/altro_firmatario">ocd:altro_firmatario</a>
    /// </summary>
    let altro_firmatario = _prefixId.prefix "altro_firmatario"
    /// <summary>
    ///   <para>rdfs:comment : questa classe è stata creata per descrivere i membri di un organo</para>
    ///   <para>rdfs:label : appertenenza di un deputato ad un organo^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/appartenenzaOrgano">ocd:appartenenzaOrgano</a>
    /// </summary>
    let appartenenzaOrgano = _prefixId.prefix "appartenenzaOrgano"
    /// <summary>
    ///   <para>rdfs:label : approvato^^xsd:string</para>
    ///   <para>owl:versionInfo : Questa proprietà è stata inserita nell'ultima versione del 2 maggio 2013^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/approvato">ocd:approvato</a>
    /// </summary>
    let approvato = _prefixId.prefix "approvato"
    /// <summary>
    ///   <para>owl:versionInfo : classe aggiunta nella versione del 2 maggio 2013^^xsd:string</para>
    ///   <para>rdfs:comment : assegnazione dell'atto camera ad un organo</para>
    ///   <para>rdfs:label : assegnazione^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/assegnazione">ocd:assegnazione</a>
    /// </summary>
    let assegnazione = _prefixId.prefix "assegnazione"
    /// <summary>
    ///   <para>rdfs:comment : la classe fa riferimento al  centro dell'attività della Camera,  dove si esercita la funzione legislativa, si concede o si revoca la fiducia al Governo, si discutono gli atti di indirizzo,  le interrogazioni e le interpellanze</para>
    ///   <para>rdfs:label : assemblea^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/assemblea">ocd:assemblea</a>
    /// </summary>
    let assemblea = _prefixId.prefix "assemblea"
    /// <summary>
    ///   <para>rdfs:label : numero astenuti^^xsd:string</para>
    ///   <para>owl:versionInfo : Questa proprietà è stata inserita nell'ultima versione del 2 maggio 2013^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/astenuti">ocd:astenuti</a>
    /// </summary>
    let astenuti = _prefixId.prefix "astenuti"
    /// <summary>
    ///   <para>rdfs:comment : la classe contiene proposte e disegni di legge</para>
    ///   <para>rdfs:label : atto camera^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/atto">ocd:atto</a>
    /// </summary>
    let atto = _prefixId.prefix "atto"
    /// <summary>
    ///   <para>rdfs:comment : è la classe che identifica le persone autori di pubblicazioni presenti in BPR.</para>
    ///   <para>rdfs:label : autore^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/autore">ocd:autore</a>
    /// </summary>
    let autore = _prefixId.prefix "autore"
    /// <summary>
    ///   <para>rdfs:label : bollettino^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/bollettino">ocd:bollettino</a>
    /// </summary>
    let bollettino = _prefixId.prefix "bollettino"
    /// <summary>
    ///   <para>rdfs:comment : questa classe è utilizzata per gestire i cambi di denominazione del Gruppo Parlamentare</para>
    ///   <para>rdfs:label : cambio denominazione del Gruppo Parlamentare^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/cambioDenominazione">ocd:cambioDenominazione</a>
    /// </summary>
    let cambioDenominazione = _prefixId.prefix "cambioDenominazione"
    /// <summary>
    ///   <para>rdfs:comment : identifica la tipologia della carica all'interno dell'Ufficio parlamentare</para>
    ///   <para>rdfs:label : dicastero^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/carica">ocd:carica</a>
    /// </summary>
    let carica = _prefixId.prefix "carica"
    /// <summary>
    ///   <para>rdfs:comment : questa classe è stata creata per gestire la descrizione di tutte le circoscrizione dei plurieletti</para>
    ///   <para>rdfs:label : circoscrizioni per plurieletti^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/circoscrizionePlurieletto">ocd:circoscrizionePlurieletto</a>
    /// </summary>
    let circoscrizionePlurieletto = _prefixId.prefix "circoscrizionePlurieletto"
    /// <summary>
    ///   <para>rdfs:comment : proprietà utilizzata per descrivere l'adesione di un deputato ad una componente del gruppo misto</para>
    ///   <para>rdfs:label : componente^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/componente">ocd:componente</a>
    /// </summary>
    let componente = _prefixId.prefix "componente"
    /// <summary>
    ///   <para>rdfs:comment : componenteGruppoMisto è la classe che identifica le compononeti di cui si compone il Gruppo Misto</para>
    ///   <para>rdfs:label : componente del Gruppo Misto^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/componenteGruppoMisto">ocd:componenteGruppoMisto</a>
    /// </summary>
    let componenteGruppoMisto = _prefixId.prefix "componenteGruppoMisto"
    /// <summary>
    ///   <para>rdfs:comment : questa classe è stata creata per descrivere i membri di un organo</para>
    ///   <para>rdfs:label : composizione di un organo parlamentare^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/composizioneOrgano">ocd:composizioneOrgano</a>
    /// </summary>
    let composizioneOrgano = _prefixId.prefix "composizioneOrgano"
    /// <summary>
    ///   <para>rdfs:comment : per indicare lo status di un atto di indirizzo e controllo</para>
    ///   <para>rdfs:label : costituzionale^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/concluso">ocd:concluso</a>
    /// </summary>
    let concluso = _prefixId.prefix "concluso"
    /// <summary>
    ///   <para>rdfs:label : voti contrari^^xsd:string</para>
    ///   <para>owl:versionInfo : Questa proprietà è stata inserita nell'ultima versione del 2 maggio 2013^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/contrari">ocd:contrari</a>
    /// </summary>
    let contrari = _prefixId.prefix "contrari"
    /// <summary>
    ///   <para>rdfs:comment : data di convalida del mandato camera</para>
    ///   <para>rdfs:label : data di convalida^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/convalida">ocd:convalida</a>
    /// </summary>
    let convalida = _prefixId.prefix "convalida"
    /// <summary>
    ///   <para>rdfs:comment : per indicare se un atto camera è costituzionale o ordinario</para>
    ///   <para>rdfs:label : costituzionale^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/costituzionale">ocd:costituzionale</a>
    /// </summary>
    let costituzionale = _prefixId.prefix "costituzionale"
    /// <summary>
    ///   <para>rdfs:label : cronologia^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/cronologia">ocd:cronologia</a>
    /// </summary>
    let cronologia = _prefixId.prefix "cronologia"
    /// <summary>
    ///   <para>rdfs:comment : proprietà utilizzata per gestire i cambi di denominazione</para>
    ///   <para>rdfs:label : denominazione^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/denominazione">ocd:denominazione</a>
    /// </summary>
    let denominazione = _prefixId.prefix "denominazione"
    /// <summary>
    ///   <para>rdfs:comment : La classe deputati comprende tutte le persone che hanno ricevuto un mandato parlamentare alla Camera</para>
    ///   <para>rdfs:label : deputato^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/deputato">ocd:deputato</a>
    /// </summary>
    let deputato = _prefixId.prefix "deputato"
    /// <summary>
    ///   <para>rdfs:comment : proprietà che designa l'organo di Governo destinatario</para>
    ///   <para>rdfs:label : componente^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/destinatario">ocd:destinatario</a>
    /// </summary>
    let destinatario = _prefixId.prefix "destinatario"
    /// <summary>
    ///   <para>rdfs:label : dibattito^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/dibattito">ocd:dibattito</a>
    /// </summary>
    let dibattito = _prefixId.prefix "dibattito"
    /// <summary>
    ///   <para>rdfs:comment : booleano per indicare se si tratta di un dicastero</para>
    ///   <para>rdfs:label : dicastero^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/dicastero">ocd:dicastero</a>
    /// </summary>
    let dicastero = _prefixId.prefix "dicastero"
    /// <summary>
    ///   <para>rdfs:label : discussione^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/discussione">ocd:discussione</a>
    /// </summary>
    let discussione = _prefixId.prefix "discussione"
    /// <summary>
    ///   <para>rdfs:comment : propreità per gestire le trasformazione dei gruppi parlamentari</para>
    ///   <para>rdfs:label : diventa^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/diventa">ocd:diventa</a>
    /// </summary>
    let diventa = _prefixId.prefix "diventa"
    /// <summary>
    ///   <para>rdfs:comment : puntamento alla URL del DOC</para>
    ///   <para>rdfs:label : URL del DOC^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/doc">ocd:doc</a>
    /// </summary>
    let doc = _prefixId.prefix "doc"
    /// <summary>
    ///   <para>rdfs:label : documentazione^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/documentazione">ocd:documentazione</a>
    /// </summary>
    let documentazione = _prefixId.prefix "documentazione"
    /// <summary>
    ///   <para>rdfs:label : documenti^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/documenti">ocd:documenti</a>
    /// </summary>
    let documenti = _prefixId.prefix "documenti"
    /// <summary>
    ///   <para>rdfs:comment : la classe contiene i dossier di documentazione, analisi e materiali predisposti dai Servizi di documentazione della Camera a supporto dell'attività parlamentare</para>
    ///   <para>rdfs:label : dossier^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/dossier">ocd:dossier</a>
    /// </summary>
    let dossier = _prefixId.prefix "dossier"
    /// <summary>
    ///   <para>rdfs:label : dottrina^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/dottrina">ocd:dottrina</a>
    /// </summary>
    let dottrina = _prefixId.prefix "dottrina"
    /// <summary>
    ///   <para>rdfs:comment : elezione è la classe che identifica i dati di elezione di un sinoglo deputato (collegio, voti, sistema elettorale)</para>
    ///   <para>rdfs:label : elezione^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/elezione">ocd:elezione</a>
    /// </summary>
    let elezione = _prefixId.prefix "elezione"
    /// <summary>
    ///   <para>owl:versionInfo : proprietà aggiunta nella versione del 2 maggio 2013^^xsd:string</para>
    ///   <para>rdfs:comment : estremo finale di un range di date</para>
    ///   <para>rdfs:label : data fine^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/endDate">ocd:endDate</a>
    /// </summary>
    let endDate = _prefixId.prefix "endDate"
    /// <summary>
    ///   <para>rdfs:comment : proprietà che collega una risorsa deputato ad una specifica legislatura</para>
    ///   <para>rdfs:label : appartiene alla legislatura^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/fa_parte_della">ocd:fa_parte_della</a>
    /// </summary>
    let fa_parte_della = _prefixId.prefix "fa_parte_della"
    /// <summary>
    ///   <para>rdfs:label : voti favorevoli^^xsd:string</para>
    ///   <para>owl:versionInfo : Questa proprietà è stata inserita nell'ultima versione del 2 maggio 2013^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/favorevoli">ocd:favorevoli</a>
    /// </summary>
    let favorevoli = _prefixId.prefix "favorevoli"
    /// <summary>
    ///   <para>rdfs:label : giurisprudenza^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/giurisprudenza">ocd:giurisprudenza</a>
    /// </summary>
    let giurisprudenza = _prefixId.prefix "giurisprudenza"
    /// <summary>
    ///   <para>rdfs:comment : La classe fa riferimento all'istituzione cui è affidato dall'ordinamento giuridico l'esercizio della funzione esecutiva</para>
    ///   <para>rdfs:label : governo^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/governo">ocd:governo</a>
    /// </summary>
    let governo = _prefixId.prefix "governo"
    /// <summary>
    ///   <para>rdfs:comment : riferimento ai concetti delle griglie tematiche di TheCa</para>
    ///   <para>rdfs:label : griglia^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/griglia">ocd:griglia</a>
    /// </summary>
    let griglia = _prefixId.prefix "griglia"
    /// <summary>
    ///   <para>rdfs:comment : La classe fa riferimento ai gruppi dei partiti o movimenti politici rappresentati alla Camera. Secondo il Regolamento della Camera ogni deputato deve necessariamente appartenere ad un gruppo</para>
    ///   <para>rdfs:label : gruppo parlamentare^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/gruppoParlamentare">ocd:gruppoParlamentare</a>
    /// </summary>
    let gruppoParlamentare = _prefixId.prefix "gruppoParlamentare"
    /// <summary>
    ///   <para>rdfs:comment : propreità utilizzata per descrivere le composizioni degli organi parlamentari</para>
    ///   <para>rdfs:label : ha membro^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/haMembro">ocd:haMembro</a>
    /// </summary>
    let haMembro = _prefixId.prefix "haMembro"
    /// <summary>
    ///   <para>rdfs:comment : è la classe che identifica gli incarichi all'interno dei gruppi parlamentari</para>
    ///   <para>rdfs:label : incarico^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/incarico">ocd:incarico</a>
    /// </summary>
    let incarico = _prefixId.prefix "incarico"
    /// <summary>
    ///   <para>rdfs:comment : per indicare la qualifica di incarico di Governo ricporta</para>
    ///   <para>rdfs:label : incarico governativo^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/incaricoGovernativo">ocd:incaricoGovernativo</a>
    /// </summary>
    let incaricoGovernativo = _prefixId.prefix "incaricoGovernativo"
    /// <summary>
    ///   <para>owl:versionInfo : Questa classe è deprecata nell'ultima versione del 2 maggio 2013. E' stata sostituita dalla classe membroGoverno^^xsd:string</para>
    ///   <para>rdfs:comment : è la classe che identifica gli incarichi governativi assegnati ai deputati</para>
    ///   <para>rdfs:label : incarico di Governo^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/incaricoGoverno">ocd:incaricoGoverno</a>
    /// </summary>
    let incaricoGoverno = _prefixId.prefix "incaricoGoverno"
    /// <summary>
    ///   <para>rdfs:comment : per indicare se l'atto camera è di iniziativa popolare, parlamentare o mista</para>
    ///   <para>rdfs:label : iniziativa^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/iniziativa">ocd:iniziativa</a>
    /// </summary>
    let iniziativa = _prefixId.prefix "iniziativa"
    /// <summary>
    ///   <para>rdfs:comment : utilizzata per gestire le cariche ad interim</para>
    ///   <para>rdfs:label : interim^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/interim">ocd:interim</a>
    /// </summary>
    let interim = _prefixId.prefix "interim"
    /// <summary>
    ///   <para>owl:versionInfo : classe aggiunta nella versione del 2 maggio 2013^^xsd:string</para>
    ///   <para>rdfs:label : intervento in una discussione^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/intervento">ocd:intervento</a>
    /// </summary>
    let intervento = _prefixId.prefix "intervento"
    /// <summary>
    ///   <para>rdfs:label : lavori^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/lavori">ocd:lavori</a>
    /// </summary>
    let lavori = _prefixId.prefix "lavori"
    /// <summary>
    ///   <para>rdfs:label : lavori preparatori^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/lavoriPreparatori">ocd:lavoriPreparatori</a>
    /// </summary>
    let lavoriPreparatori = _prefixId.prefix "lavoriPreparatori"
    /// <summary>
    ///   <para>rdfs:comment : riferimento ai lavori preparatori di una legge</para>
    ///   <para>rdfs:label : lavori preparatori^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/lavoriPreparatoriLegge">ocd:lavoriPreparatoriLegge</a>
    /// </summary>
    let lavoriPreparatoriLegge = _prefixId.prefix "lavoriPreparatoriLegge"
    /// <summary>
    ///   <para>rdfs:label : legge^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/legge">ocd:legge</a>
    /// </summary>
    let legge = _prefixId.prefix "legge"
    /// <summary>
    ///   <para>rdfs:comment : La classe fa riferimento al  periodo di durata del mandato parlamentare compreso fra le elezioni e lo scioglimento delle Camere. La legislatura si articola in sessioni e sedute</para>
    ///   <para>rdfs:label : legislatura^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/legislatura">ocd:legislatura</a>
    /// </summary>
    let legislatura = _prefixId.prefix "legislatura"
    /// <summary>
    ///   <para>rdfs:comment : riferimento esterno alla norma ufficiale</para>
    ///   <para>rdfs:label : legge^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/lex">ocd:lex</a>
    /// </summary>
    let lex = _prefixId.prefix "lex"
    /// <summary>
    ///   <para>rdfs:comment : Lista di appartenenza</para>
    ///   <para>rdfs:label : lista^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/lista">ocd:lista</a>
    /// </summary>
    let lista = _prefixId.prefix "lista"
    /// <summary>
    ///   <para>owl:versionInfo : classe aggiunta nella versione del 2 maggio 2013^^xsd:string</para>
    ///   <para>rdfs:label : luogo^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/luogo">ocd:luogo</a>
    /// </summary>
    let luogo = _prefixId.prefix "luogo"
    /// <summary>
    ///   <para>rdfs:label : numero maggioranza^^xsd:string</para>
    ///   <para>owl:versionInfo : Questa proprietà è stata inserita nell'ultima versione del 2 maggio 2013^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/maggioranza">ocd:maggioranza</a>
    /// </summary>
    let maggioranza = _prefixId.prefix "maggioranza"
    /// <summary>
    ///   <para>rdfs:comment : La classe fa riferimento allo status di deputato assunto da una persona  - candidato in elezioni politiche -  in seguito ad un voto popolare</para>
    ///   <para>rdfs:label : mandato^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/mandatoCamera">ocd:mandatoCamera</a>
    /// </summary>
    let mandatoCamera = _prefixId.prefix "mandatoCamera"
    /// <summary>
    ///   <para>rdfs:comment : La classe fa riferimento allo status di senatore assunto da una persona  - candidato in elezioni politiche -  in seguito ad un voto popolare</para>
    ///   <para>rdfs:label : mandato^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/mandatoSenato">ocd:mandatoSenato</a>
    /// </summary>
    let mandatoSenato = _prefixId.prefix "mandatoSenato"
    /// <summary>
    ///   <para>rdfs:comment : proprietà che collega un deputato ad un organo</para>
    ///   <para>rdfs:label : membro^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/membro">ocd:membro</a>
    /// </summary>
    let membro = _prefixId.prefix "membro"
    /// <summary>
    ///   <para>rdfs:label : membro^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/membroConsulta">ocd:membroConsulta</a>
    /// </summary>
    let membroConsulta = _prefixId.prefix "membroConsulta"
    /// <summary>
    ///   <para>owl:versionInfo : Questa classe è stata aggiunta nell'ultima versione del 2 maggio 2013^^xsd:string</para>
    ///   <para>rdfs:comment : è la classe che identifica gli incarichi governativi assegnati ai deputati</para>
    ///   <para>rdfs:label : membro di Governo^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/membroGoverno">ocd:membroGoverno</a>
    /// </summary>
    let membroGoverno = _prefixId.prefix "membroGoverno"
    /// <summary>
    ///   <para>rdfs:comment : motivo termine del mandato</para>
    ///   <para>rdfs:label : motivo termine mandato^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/motivoTermine">ocd:motivoTermine</a>
    /// </summary>
    let motivoTermine = _prefixId.prefix "motivoTermine"
    /// <summary>
    ///   <para>rdfs:comment : nome del luogo</para>
    ///   <para>rdfs:label : nome del luogo^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/name">ocd:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>owl:versionInfo : classe aggiunta nella versione del 2 maggio 2013^^xsd:string</para>
    ///   <para>rdfs:comment : natura dell'atto camera</para>
    ///   <para>rdfs:label : natura^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/natura">ocd:natura</a>
    /// </summary>
    let natura = _prefixId.prefix "natura"
    /// <summary>
    ///   <para>rdfs:comment : descrive la relazione tra legislatura e assemblea</para>
    ///   <para>rdfs:label : nomina^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/nomina">ocd:nomina</a>
    /// </summary>
    let nomina = _prefixId.prefix "nomina"
    /// <summary>
    ///   <para>rdfs:comment : la classe contiene le Gazzette ufficiale della Repubblica Italiana e dell'Unione Europea</para>
    ///   <para>rdfs:label : normativa^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/normativa">ocd:normativa</a>
    /// </summary>
    let normativa = _prefixId.prefix "normativa"
    /// <summary>
    ///   <para>rdfs:label : note^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/note">ocd:note</a>
    /// </summary>
    let note = _prefixId.prefix "note"
    /// <summary>
    ///   <para>rdfs:comment : data di opzione in una elezione</para>
    ///   <para>rdfs:label : data di opzione^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/opzione">ocd:opzione</a>
    /// </summary>
    let opzione = _prefixId.prefix "opzione"
    /// <summary>
    ///   <para>rdfs:label : organo^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/organo">ocd:organo</a>
    /// </summary>
    let organo = _prefixId.prefix "organo"
    /// <summary>
    ///   <para>rdfs:comment : la classe fa riferimento agli organi monocratici o collegiali, necessari e non, che costituiscono il governo: Presidente del Consiglio, singoli Ministri,,Consiglio dei Ministri, Consiglio di Gabinetto, Comitati di Ministri e Comitati interministeriali, Vice-presidenti del Consiglio, Ministri senza portafoglio, Sottosegretari di Stato, Vice-ministri e Commissari straordinari</para>
    ///   <para>rdfs:label : organo governativo^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/organoGoverno">ocd:organoGoverno</a>
    /// </summary>
    let organoGoverno = _prefixId.prefix "organoGoverno"
    /// <summary>
    ///   <para>rdfs:comment : primo livello di divisione amministrativa</para>
    ///   <para>rdfs:label : ADM1^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/parentADM1">ocd:parentADM1</a>
    /// </summary>
    let parentADM1 = _prefixId.prefix "parentADM1"
    /// <summary>
    ///   <para>rdfs:comment : secondo livello di divisione amministrativa</para>
    ///   <para>rdfs:label : ADM2^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/parentADM2">ocd:parentADM2</a>
    /// </summary>
    let parentADM2 = _prefixId.prefix "parentADM2"
    /// <summary>
    ///   <para>rdfs:comment : terzo livello di divisione amministrativa</para>
    ///   <para>rdfs:label : ADM3^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/parentADM3">ocd:parentADM3</a>
    /// </summary>
    let parentADM3 = _prefixId.prefix "parentADM3"
    /// <summary>
    ///   <para>rdfs:comment : nazione</para>
    ///   <para>rdfs:label : parentCountry^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/parentCountry">ocd:parentCountry</a>
    /// </summary>
    let parentCountry = _prefixId.prefix "parentCountry"
    /// <summary>
    ///   <para>rdfs:comment : è la classe che identifica la persona che ha svolto qualche ruolo all'interno della Camera dei deputati. La persona che ha un mandato parlamentare è anche un deputato. Ad una persona possono corripondere 0-n deputati.</para>
    ///   <para>rdfs:label : persona^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/persona">ocd:persona</a>
    /// </summary>
    let persona = _prefixId.prefix "persona"
    /// <summary>
    ///   <para>rdfs:comment : proprietà utilizzata per descrivere tutte le circoscrizioni di elezione di un plurieletto</para>
    ///   <para>rdfs:label : plurieletto^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/plurieletto">ocd:plurieletto</a>
    /// </summary>
    let plurieletto = _prefixId.prefix "plurieletto"
    /// <summary>
    ///   <para>rdfs:label : numero presenti^^xsd:string</para>
    ///   <para>owl:versionInfo : Questa proprietà è stata inserita nell'ultima versione del 2 maggio 2013^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/presenti">ocd:presenti</a>
    /// </summary>
    let presenti = _prefixId.prefix "presenti"
    /// <summary>
    ///   <para>rdfs:label : presidente della Camera dei deputati^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/presidenteCamera">ocd:presidenteCamera</a>
    /// </summary>
    let presidenteCamera = _prefixId.prefix "presidenteCamera"
    /// <summary>
    ///   <para>rdfs:label : presidente del Consiglio dei ministri^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/presidenteConsiglioMinistri">ocd:presidenteConsiglioMinistri</a>
    /// </summary>
    let presidenteConsiglioMinistri = _prefixId.prefix "presidenteConsiglioMinistri"
    /// <summary>
    ///   <para>rdfs:label : presidente della Repubblica^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/presidenteRepubblica">ocd:presidenteRepubblica</a>
    /// </summary>
    let presidenteRepubblica = _prefixId.prefix "presidenteRepubblica"
    /// <summary>
    ///   <para>rdfs:comment : indica il primo firmatario del documento</para>
    ///   <para>rdfs:label : primo firmatario^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/primo_firmatario">ocd:primo_firmatario</a>
    /// </summary>
    let primo_firmatario = _prefixId.prefix "primo_firmatario"
    /// <summary>
    ///   <para>rdfs:comment : questa classe è stata creata per gestire subentri e sostituzioni nel mandato camera</para>
    ///   <para>rdfs:label : proclamazione^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/proclamazione">ocd:proclamazione</a>
    /// </summary>
    let proclamazione = _prefixId.prefix "proclamazione"
    /// <summary>
    ///   <para>rdfs:label : pubblicistica^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/pubblicistica">ocd:pubblicistica</a>
    /// </summary>
    let pubblicistica = _prefixId.prefix "pubblicistica"
    /// <summary>
    ///   <para>owl:versionInfo : classe aggiunta nella versione del 2 maggio 2013^^xsd:string</para>
    ///   <para>rdfs:label : relatore di un atto camera^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/relatore">ocd:relatore</a>
    /// </summary>
    let relatore = _prefixId.prefix "relatore"
    /// <summary>
    ///   <para>rdfs:label : richiesta della fiducia^^xsd:string</para>
    ///   <para>owl:versionInfo : Questa proprietà è stata inserita nell'ultima versione del 2 maggio 2013^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/richiestaFiducia">ocd:richiestaFiducia</a>
    /// </summary>
    let richiestaFiducia = _prefixId.prefix "richiestaFiducia"
    /// <summary>
    ///   <para>owl:versionInfo : classe aggiunta nella versione del 2 maggio 2013^^xsd:string</para>
    ///   <para>rdfs:comment : richiesta del parere su un atto camera ad un organo</para>
    ///   <para>rdfs:label : richiesta parere^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/richiestaParere">ocd:richiestaParere</a>
    /// </summary>
    let richiestaParere = _prefixId.prefix "richiestaParere"
    /// <summary>
    ///   <para>owl:versionInfo : proprietà aggiunta nella versione del 2 maggio 2013^^xsd:string</para>
    ///   <para>rdfs:label : riferimento all'abbinamento dell'atto camera con altri atti^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/rif_abbinamento">ocd:rif_abbinamento</a>
    /// </summary>
    let rif_abbinamento = _prefixId.prefix "rif_abbinamento"
    /// <summary>
    ///   <para>owl:versionInfo : proprietà aggiunta nella versione del 2 maggio 2013^^xsd:string</para>
    ///   <para>rdfs:label : riferimento all'allegato di una discussione^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/rif_allegatoDiscussione">ocd:rif_allegatoDiscussione</a>
    /// </summary>
    let rif_allegatoDiscussione = _prefixId.prefix "rif_allegatoDiscussione"
    /// <summary>
    ///   <para>owl:versionInfo : proprietà aggiunta nella versione del 2 maggio 2013^^xsd:string</para>
    ///   <para>rdfs:label : riferimento all'assegnazione dell'atto camera^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/rif_assegnazione">ocd:rif_assegnazione</a>
    /// </summary>
    let rif_assegnazione = _prefixId.prefix "rif_assegnazione"
    /// <summary>
    ///   <para>rdfs:comment : riferimento agli altri atti camera citati</para>
    ///   <para>rdfs:label : riferimento all'atto camera^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/rif_attoCamera">ocd:rif_attoCamera</a>
    /// </summary>
    let rif_attoCamera = _prefixId.prefix "rif_attoCamera"
    /// <summary>
    ///   <para>rdfs:label : riferimento al bollettino^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/rif_bollettino">ocd:rif_bollettino</a>
    /// </summary>
    let rif_bollettino = _prefixId.prefix "rif_bollettino"
    let rif_componente = _prefixId.prefix "rif_componente"
    /// <summary>
    ///   <para>rdfs:comment : proprietà generica utilizzata per puntare alla risorsa deputato in vari punti dell'ontologia</para>
    ///   <para>rdfs:label : rierimento a deputato^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/rif_deputato">ocd:rif_deputato</a>
    /// </summary>
    let rif_deputato = _prefixId.prefix "rif_deputato"
    /// <summary>
    ///   <para>owl:versionInfo : proprietà aggiunta nella versione del 2 maggio 2013^^xsd:string</para>
    ///   <para>rdfs:label : riferimento al dibattito^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/rif_dibattito">ocd:rif_dibattito</a>
    /// </summary>
    let rif_dibattito = _prefixId.prefix "rif_dibattito"
    /// <summary>
    ///   <para>rdfs:comment : un dabattito può avere più discussioni</para>
    ///   <para>rdfs:label : riferimento alla discussione^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/rif_discussione">ocd:rif_discussione</a>
    /// </summary>
    let rif_discussione = _prefixId.prefix "rif_discussione"
    /// <summary>
    ///   <para>rdfs:comment : un doc può fare riferimento ad un altro DOC</para>
    ///   <para>rdfs:label : riferimento al doc^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/rif_doc">ocd:rif_doc</a>
    /// </summary>
    let rif_doc = _prefixId.prefix "rif_doc"
    /// <summary>
    ///   <para>rdfs:comment : riferimento ad un altro dossier citato nell'atto camera</para>
    ///   <para>rdfs:label : riferimento al dossier^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/rif_dossier">ocd:rif_dossier</a>
    /// </summary>
    let rif_dossier = _prefixId.prefix "rif_dossier"
    /// <summary>
    ///   <para>rdfs:label : riferimento all'elezione^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/rif_elezione">ocd:rif_elezione</a>
    /// </summary>
    let rif_elezione = _prefixId.prefix "rif_elezione"
    /// <summary>
    ///   <para>rdfs:comment : riferimento al Governo</para>
    ///   <para>rdfs:label : riferimento al governo^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/rif_governo">ocd:rif_governo</a>
    /// </summary>
    let rif_governo = _prefixId.prefix "rif_governo"
    /// <summary>
    ///   <para>rdfs:comment : riferimento al Gruppo parlamentare</para>
    ///   <para>rdfs:label : riferimento al Gruppo parlamentare^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/rif_gruppoParlamentare">ocd:rif_gruppoParlamentare</a>
    /// </summary>
    let rif_gruppoParlamentare = _prefixId.prefix "rif_gruppoParlamentare"
    /// <summary>
    ///   <para>rdfs:comment : riferimento all'incarico nel Gruppo parlamentare</para>
    ///   <para>rdfs:label : riferimento all'incarico^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/rif_incarico">ocd:rif_incarico</a>
    /// </summary>
    let rif_incarico = _prefixId.prefix "rif_incarico"
    /// <summary>
    ///   <para>owl:versionInfo : Questa proprietà è deprecata nell'ultima versione del 2 maggio 2013^^xsd:string</para>
    ///   <para>rdfs:label : riferimento all'incarico di Governo^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/rif_incaricoGoverno">ocd:rif_incaricoGoverno</a>
    /// </summary>
    let rif_incaricoGoverno = _prefixId.prefix "rif_incaricoGoverno"
    /// <summary>
    ///   <para>owl:versionInfo : proprietà aggiunta nella versione del 2 maggio 2013^^xsd:string</para>
    ///   <para>rdfs:label : riferimento all'intervento del deputato o del membro di governo in una discussione^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/rif_intervento">ocd:rif_intervento</a>
    /// </summary>
    let rif_intervento = _prefixId.prefix "rif_intervento"
    /// <summary>
    ///   <para>rdfs:comment : proprietà generica utilizzata ovunque tra le risorse per specificare l'appartenenza ad una legislatura</para>
    ///   <para>rdfs:label : riferimento alla legislatura^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/rif_leg">ocd:rif_leg</a>
    /// </summary>
    let rif_leg = _prefixId.prefix "rif_leg"
    /// <summary>
    ///   <para>owl:versionInfo : proprietà aggiunta nella versione del 2 maggio 2013^^xsd:string</para>
    ///   <para>rdfs:label : riferimento al luogo^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/rif_luogo">ocd:rif_luogo</a>
    /// </summary>
    let rif_luogo = _prefixId.prefix "rif_luogo"
    /// <summary>
    ///   <para>rdfs:comment : serve a collegare il deputato al mandato elettorale</para>
    ///   <para>rdfs:label : riferimento a mandato camera^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/rif_mandatoCamera">ocd:rif_mandatoCamera</a>
    /// </summary>
    let rif_mandatoCamera = _prefixId.prefix "rif_mandatoCamera"
    /// <summary>
    ///   <para>rdfs:comment : serve a collegare il deputato al mandato di senatore</para>
    ///   <para>rdfs:label : riferimento a mandato senato^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/rif_mandatoSenato">ocd:rif_mandatoSenato</a>
    /// </summary>
    let rif_mandatoSenato = _prefixId.prefix "rif_mandatoSenato"
    /// <summary>
    ///   <para>owl:versionInfo : Questa proprietà è stata aggiunta nell'ultima versione del 2 maggio 2013^^xsd:string</para>
    ///   <para>rdfs:label : riferimento al membro di Governo^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/rif_membroGoverno">ocd:rif_membroGoverno</a>
    /// </summary>
    let rif_membroGoverno = _prefixId.prefix "rif_membroGoverno"
    /// <summary>
    ///   <para>owl:versionInfo : proprietà aggiunta nella versione del 2 maggio 2013^^xsd:string</para>
    ///   <para>rdfs:label : riferimento alla natura dell'atto camera^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/rif_natura">ocd:rif_natura</a>
    /// </summary>
    let rif_natura = _prefixId.prefix "rif_natura"
    /// <summary>
    ///   <para>rdfs:comment : puntamento all'organo parlamentare citato</para>
    ///   <para>rdfs:label : riferimento all'organo^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/rif_organo">ocd:rif_organo</a>
    /// </summary>
    let rif_organo = _prefixId.prefix "rif_organo"
    /// <summary>
    ///   <para>rdfs:comment : proprietà utilizzata all'interno degli incarichi di governo per puntare all'organo di governo</para>
    ///   <para>rdfs:label : riferimento all'organo di governo^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/rif_organoGoverno">ocd:rif_organoGoverno</a>
    /// </summary>
    let rif_organoGoverno = _prefixId.prefix "rif_organoGoverno"
    /// <summary>
    ///   <para>rdfs:comment : propreità generica utilizzata per puntare ad una risorsa persona</para>
    ///   <para>rdfs:label : riferimento a persona^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/rif_persona">ocd:rif_persona</a>
    /// </summary>
    let rif_persona = _prefixId.prefix "rif_persona"

    /// <summary>
    ///   <para>rdfs:label : rierimento al Presidente del Consiglio dei ministri^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/rif_presidenteConsiglioMinistri">ocd:rif_presidenteConsiglioMinistri</a>
    /// </summary>
    let rif_presidenteConsiglioMinistri =
        _prefixId.prefix "rif_presidenteConsiglioMinistri"

    /// <summary>
    ///   <para>owl:versionInfo : proprietà aggiunta nella versione del 2 maggio 2013^^xsd:string</para>
    ///   <para>rdfs:label : riferimento alla richesta dei pareri su un atto camera^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/rif_richiestaParere">ocd:rif_richiestaParere</a>
    /// </summary>
    let rif_richiestaParere = _prefixId.prefix "rif_richiestaParere"
    /// <summary>
    ///   <para>rdfs:comment : in una seduta si svolgono più discussioni</para>
    ///   <para>rdfs:label : riferimento alla seduta^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/rif_seduta">ocd:rif_seduta</a>
    /// </summary>
    let rif_seduta = _prefixId.prefix "rif_seduta"
    /// <summary>
    ///   <para>rdfs:comment : proprietà utilizzata all'interno degli incarichi di governo per puntare all'organo di governo</para>
    ///   <para>rdfs:label : riferimento al senatore^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/rif_senatore">ocd:rif_senatore</a>
    /// </summary>
    let rif_senatore = _prefixId.prefix "rif_senatore"
    /// <summary>
    ///   <para>rdfs:comment : questa proprietà collega ogni legislatura ad un sistema elettorale</para>
    ///   <para>rdfs:label : riferimento al sistema elettorale^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/rif_sistemaElettorale">ocd:rif_sistemaElettorale</a>
    /// </summary>
    let rif_sistemaElettorale = _prefixId.prefix "rif_sistemaElettorale"
    /// <summary>
    ///   <para>owl:versionInfo : proprietà aggiunta nella versione del 2 maggio 2013^^xsd:string</para>
    ///   <para>rdfs:label : riferimento allo stato iter di un atto camera^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/rif_statoIter">ocd:rif_statoIter</a>
    /// </summary>
    let rif_statoIter = _prefixId.prefix "rif_statoIter"
    /// <summary>
    ///   <para>owl:versionInfo : proprietà aggiunta nella versione del 2 maggio 2013^^xsd:string</para>
    ///   <para>rdfs:label : riferimento alla trasmissione di un atto camera all'altro ramo del parlamento^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/rif_trasmissione">ocd:rif_trasmissione</a>
    /// </summary>
    let rif_trasmissione = _prefixId.prefix "rif_trasmissione"
    /// <summary>
    ///   <para>rdfs:comment : propreità che collega un organo agli uffici parlamentari</para>
    ///   <para>rdfs:label : riferimento ufficio parlamentare^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/rif_ufficioParlamentare">ocd:rif_ufficioParlamentare</a>
    /// </summary>
    let rif_ufficioParlamentare = _prefixId.prefix "rif_ufficioParlamentare"
    /// <summary>
    ///   <para>rdfs:comment : puntamento dei documenti ad una unità organizzativa all'interno della struttura camera</para>
    ///   <para>rdfs:label : unità organizzativa^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/rif_unitaOrganizzativa">ocd:rif_unitaOrganizzativa</a>
    /// </summary>
    let rif_unitaOrganizzativa = _prefixId.prefix "rif_unitaOrganizzativa"
    /// <summary>
    ///   <para>owl:versionInfo : proprietà aggiunta nella versione del 2 maggio 2013^^xsd:string</para>
    ///   <para>rdfs:label : riferimento alla versione del testo dell'atto camera^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/rif_versioneTestoAtto">ocd:rif_versioneTestoAtto</a>
    /// </summary>
    let rif_versioneTestoAtto = _prefixId.prefix "rif_versioneTestoAtto"
    /// <summary>
    ///   <para>owl:versionInfo : proprietà aggiunta nella versione del 2 maggio 2013^^xsd:string</para>
    ///   <para>rdfs:label : riferimento alla votazione^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/rif_votazione">ocd:rif_votazione</a>
    /// </summary>
    let rif_votazione = _prefixId.prefix "rif_votazione"
    /// <summary>
    ///   <para>rdfs:label : risorsa_web^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/risorsa_web">ocd:risorsa_web</a>
    /// </summary>
    let risorsa_web = _prefixId.prefix "risorsa_web"
    /// <summary>
    ///   <para>rdfs:label : riferimento alla risposta scritta all'interrogazione^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/risposta">ocd:risposta</a>
    /// </summary>
    let risposta = _prefixId.prefix "risposta"
    /// <summary>
    ///   <para>rdfs:comment : classe usata per individuare le risposte scritte alle interrogazioni parlamentari</para>
    ///   <para>rdfs:label : risposta scritta alle interrogazioni^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/rispostaAIC">ocd:rispostaAIC</a>
    /// </summary>
    let rispostaAIC = _prefixId.prefix "rispostaAIC"
    /// <summary>
    ///   <para>rdfs:comment : ruolo ricoperto</para>
    ///   <para>rdfs:label : ruolo^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/ruolo">ocd:ruolo</a>
    /// </summary>
    let ruolo = _prefixId.prefix "ruolo"
    /// <summary>
    ///   <para>rdfs:label : seduta^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/seduta">ocd:seduta</a>
    /// </summary>
    let seduta = _prefixId.prefix "seduta"
    /// <summary>
    ///   <para>rdfs:label : senatore^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/senatore">ocd:senatore</a>
    /// </summary>
    let senatore = _prefixId.prefix "senatore"
    /// <summary>
    ///   <para>rdfs:comment : proprietà utilizzata per descrivere la composizione dei deputati nell'assemblea e nei gruppi e degli orgnao nelle legislature</para>
    ///   <para>rdfs:label : si compone di^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/siComponeDi">ocd:siComponeDi</a>
    /// </summary>
    let siComponeDi = _prefixId.prefix "siComponeDi"
    /// <summary>
    ///   <para>rdfs:comment : La classe contiene le normative applicate nelle consultazioni elettorali dal regno di Sardegna alla Repubblica: maggioritario uninominale (1848 - 1880); maggioritario: scrutinio di lista (1882 - 1890); maggioritario: uninominale (1892 - 1913); proporzionale (1919 - 1921); lista unica (1929 - 1934);
    /// proporzionale (1946 - 1993); misto: maggioritario e proporzionale (1994-2005); proporzionale con premio di maggioranza (2006-2011)</para>
    ///   <para>rdfs:label : sistema elettorale^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/sistemaElettorale">ocd:sistemaElettorale</a>
    /// </summary>
    let sistemaElettorale = _prefixId.prefix "sistemaElettorale"
    /// <summary>
    ///   <para>owl:versionInfo : proprietà aggiunta nella versione del 2 maggio 2013^^xsd:string</para>
    ///   <para>rdfs:comment : estremo iniziale di un range di date</para>
    ///   <para>rdfs:label : data inizio^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/startDate">ocd:startDate</a>
    /// </summary>
    let startDate = _prefixId.prefix "startDate"
    /// <summary>
    ///   <para>owl:versionInfo : classe aggiunta nella versione del 2 maggio 2013^^xsd:string</para>
    ///   <para>rdfs:comment : stato dell'iter dell'atto camera</para>
    ///   <para>rdfs:label : stato iter^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/statoIter">ocd:statoIter</a>
    /// </summary>
    let statoIter = _prefixId.prefix "statoIter"
    /// <summary>
    ///   <para>owl:versionInfo : classe aggiunta nella versione del 2 maggio 2013^^xsd:string</para>
    ///   <para>rdfs:comment : stralcio di un atto camera</para>
    ///   <para>rdfs:label : stralcio^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/stralcio">ocd:stralcio</a>
    /// </summary>
    let stralcio = _prefixId.prefix "stralcio"
    /// <summary>
    ///   <para>rdfs:label : tipo di elezione^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/tipoElezione">ocd:tipoElezione</a>
    /// </summary>
    let tipoElezione = _prefixId.prefix "tipoElezione"
    /// <summary>
    ///   <para>rdfs:comment : propreità utilizzata per descrivere la tipologia di proclamazione legata ad un mandato elettorale (per sostituzione, subentro, ...)</para>
    ///   <para>rdfs:label : tipologia proclamazione^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/tipoProclamazione">ocd:tipoProclamazione</a>
    /// </summary>
    let tipoProclamazione = _prefixId.prefix "tipoProclamazione"
    /// <summary>
    ///   <para>rdfs:label : tipologia documentaria^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/tipologia">ocd:tipologia</a>
    /// </summary>
    let tipologia = _prefixId.prefix "tipologia"
    /// <summary>
    ///   <para>rdfs:comment : classe per gestire scissioni, accorpamenti, promozioni o riduzione a componente dei Gruppi Parlamentari</para>
    ///   <para>rdfs:label : trasformazione del Gruppo Parlamentare^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/trasformazioneGruppo">ocd:trasformazioneGruppo</a>
    /// </summary>
    let trasformazioneGruppo = _prefixId.prefix "trasformazioneGruppo"
    /// <summary>
    ///   <para>owl:versionInfo : classe aggiunta nella versione del 2 maggio 2013^^xsd:string</para>
    ///   <para>rdfs:label : trasmissione^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/trasmissione">ocd:trasmissione</a>
    /// </summary>
    let trasmissione = _prefixId.prefix "trasmissione"
    /// <summary>
    ///   <para>rdfs:comment : ufficioParlamentare è la classe che identifica tutte le cariche ricoperte dai deputati negli organi parlamentari</para>
    ///   <para>rdfs:label : ufficio Parlamentare^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/ufficioParlamentare">ocd:ufficioParlamentare</a>
    /// </summary>
    let ufficioParlamentare = _prefixId.prefix "ufficioParlamentare"
    /// <summary>
    ///   <para>rdfs:comment : unitaOrganizzativa è la classe che identifica i dipartimenti/uffici in cui si struttura la Camera dei Deputati</para>
    ///   <para>rdfs:label : unità organizzativa^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/unitaOrganizzativa">ocd:unitaOrganizzativa</a>
    /// </summary>
    let unitaOrganizzativa = _prefixId.prefix "unitaOrganizzativa"
    /// <summary>
    ///   <para>owl:versionInfo : classe aggiunta nella versione del 2 maggio 2013^^xsd:string</para>
    ///   <para>rdfs:label : versione testo atto camera^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/versioneTestoAtto">ocd:versioneTestoAtto</a>
    /// </summary>
    let versioneTestoAtto = _prefixId.prefix "versioneTestoAtto"
    /// <summary>
    ///   <para>rdfs:label : numero votanti^^xsd:string</para>
    ///   <para>owl:versionInfo : Questa proprietà è stata inserita nell'ultima versione del 2 maggio 2013^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/votanti">ocd:votanti</a>
    /// </summary>
    let votanti = _prefixId.prefix "votanti"
    /// <summary>
    ///   <para>owl:versionInfo : classe aggiunta nella versione del 2 maggio 2013^^xsd:string</para>
    ///   <para>rdfs:label : votazione^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/votazione">ocd:votazione</a>
    /// </summary>
    let votazione = _prefixId.prefix "votazione"
    /// <summary>
    ///   <para>rdfs:label : votazione finale^^xsd:string</para>
    ///   <para>owl:versionInfo : Questa proprietà è stata inserita nell'ultima versione del 2 maggio 2013^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/votazioneFinale">ocd:votazioneFinale</a>
    /// </summary>
    let votazioneFinale = _prefixId.prefix "votazioneFinale"
    /// <summary>
    ///   <para>rdfs:label : votazione segreta^^xsd:string</para>
    ///   <para>owl:versionInfo : Questa proprietà è stata inserita nell'ultima versione del 2 maggio 2013^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/votazioneSegreta">ocd:votazioneSegreta</a>
    /// </summary>
    let votazioneSegreta = _prefixId.prefix "votazioneSegreta"
    /// <summary>
    ///   <para>owl:versionInfo : classe aggiunta nella versione del 2 maggio 2013^^xsd:string</para>
    ///   <para>rdfs:label : voto del deputato in una votazione^^xsd:string</para>
    ///   <a href="http://dati.camera.it/ocd/voto">ocd:voto</a>
    /// </summary>
    let voto = _prefixId.prefix "voto"
