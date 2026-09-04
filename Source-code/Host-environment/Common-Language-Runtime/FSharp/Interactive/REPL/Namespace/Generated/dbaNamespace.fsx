#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dba =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/dba/ontology/" "dba"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Alienazionerdfs:label : Alienation</para>
    ///   <para>rdfs:comment : Atto giuridico con cui si trasferiscono ad altri soggetti una proprietà o un diritto su beni del proprio patrimonio, mediante vendita, donazione, mutuo, ecc.rdfs:comment : Legal deed by which a property or a right on the goods comprising one’s own assets is transferred to other entities, through sale, donation, mortgage, etc.</para>
    ///   <a href="https://w3id.org/dba/ontology/Alienation">dba:Alienation</a>
    /// </summary>
    let Alienation = _prefixId.prefix "Alienation"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Domandardfs:label : Application</para>
    ///   <para>rdfs:comment : Formulazione di una richiesta di un servizio, ad esempio l’erogazione di un mutuo o un finanziamento, da parte di un cliente all’azienda bancaria.rdfs:comment : Formulation of a request for a service, for example the disbursement of a mortgage or a loan, from a customer to the banking company.</para>
    ///   <a href="https://w3id.org/dba/ontology/Application">dba:Application</a>
    /// </summary>
    let Application = _prefixId.prefix "Application"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Verificardfs:label : Audit</para>
    ///   <para>rdfs:comment : Accertamento della regolarità formale o sostanziale di un documento, di una situazione di fatto o di un diritto. La verifica può riferirsi, nell’ambito delle aziende, a controlli di carattere economico, di natura giuridica, di natura contabile, di natura finanziaria, di carattere tecnico, ecc.rdfs:comment : Verification of the formal or substantive regularity of a document, a factual situation or a right. The audit may refer, within the scope of companies, to checks of an economic nature, of a legal nature, of an accounting nature, of a financial nature, of a technical nature, etc.</para>
    ///   <a href="https://w3id.org/dba/ontology/Audit">dba:Audit</a>
    /// </summary>
    let Audit = _prefixId.prefix "Audit"
    /// <summary>
    ///   <para>rdfs:label : Bancardfs:label : Bank</para>
    ///   <para>rdfs:comment : Impresa che compie operazioni di raccolta di fondi ed eroga crediti non trasferibili sul mercatordfs:comment : Company that carries out fundraising transactions and disburses non-transferable loans on the market.</para>
    ///   <a href="https://w3id.org/dba/ontology/Bank">dba:Bank</a>
    /// </summary>
    let Bank = _prefixId.prefix "Bank"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Stipulardfs:label : Conclusion</para>
    ///   <para>rdfs:comment : L'atto dello stipulare, cioè del concludere un contratto, e talora il contratto stesso.rdfs:comment : The act of concluding, that is, finalising a contract, and sometimes the contract itself.</para>
    ///   <a href="https://w3id.org/dba/ontology/Conclusion">dba:Conclusion</a>
    /// </summary>
    let Conclusion = _prefixId.prefix "Conclusion"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Confiscardfs:label : Confiscation</para>
    ///   <para>rdfs:comment : La confisca consiste in una pena accessoria che viene comminata a seguito di condanna e che consiste in una vera e propria espropriazione a favore dello Stato. E’ infatti una misura di sicurezza a carattere patrimoniale consistente nell'espropriazione forzata e gratuita a favore dello Stato ed, in materia urbanistica, a favore del patrimonio del Comune, di tutte le cose che costituiscono il prezzo del reato, che sono servite a commettere il reato, di quelle che ne sono il prodotto e il profitto, nonchè di quelle che sono di per sè criminose. Tale misura può essere facoltativa o obbligatoria.rdfs:comment : Confiscation consists of an ancillary penalty which is imposed following a conviction and which consists of an actual expropriation in favour of the State. It is therefore a security measure of a patrimonial nature consisting of the forced and free expropriation in favour of the State and, in an urban context, in favour of a Municipality’s assets, of all the things that comprise the price of the crime, which were used to commit the crime, those which constitute the product and the profit of such crime, as well as those which are criminal by nature. This measure can be optional or mandatory.</para>
    ///   <a href="https://w3id.org/dba/ontology/Confiscation">dba:Confiscation</a>
    /// </summary>
    let Confiscation = _prefixId.prefix "Confiscation"
    /// <summary>
    ///   <para>vs:term_status : Unstable</para>
    ///   <para>rdfs:label : Confiscardfs:label : Confiscation</para>
    ///   <para>rdfs:comment : Esecuzione della confiscardfs:comment : Execution of the confiscation</para>
    ///   <a href="https://w3id.org/dba/ontology/ConfiscationEvent">dba:ConfiscationEvent</a>
    /// </summary>
    let ConfiscationEvent = _prefixId.prefix "ConfiscationEvent"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Contrattordfs:label : Contract</para>
    ///   <para>rdfs:comment : Il contratto è definito dall’art. 1321 c.c. come “l’accordo di due o più parti per costituire, regolare o estinguere tra loro un rapporto giuridico patrimoniale”rdfs:comment : The contract is defined by art. 1321 of the Italian Civil Code as “the agreement of two or more parties to establish, govern or terminate a legal patrimonial relationship between them”.</para>
    ///   <a href="https://w3id.org/dba/ontology/Contract">dba:Contract</a>
    /// </summary>
    let Contract = _prefixId.prefix "Contract"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Creditirdfs:label : Credit</para>
    ///   <para>rdfs:comment : Anticipazione di risorse, nella forma di prestazione di beni o servizi o cessione di somme di denaro, che un agente economico concede ad altro a fronte di una promessa di restituzione futura in una o più soluzioni, secondo modalità e tempi specificati contrattualmente. Il c. può nascere direttamente da rapporti commerciali fra due imprese o fra un’impresa (un imprenditore) e una famiglia, oppure coinvolgere un intermediario finanziario abilitato a operare nel settore del credito [per esempio una banca].rdfs:comment : Advance of resources, in the form of the provision of goods or services or the transfer of sums of money, which an economic agent grants to another against a promise of future restitution in one or more tranches, according to the methods and times specified in the contract. A credit can arise directly from commercial relationships between two companies or between a company (an entrepreneur) and a family, or involve a financial intermediary qualified to trade in the credit sector [for example a bank].</para>
    ///   <a href="https://w3id.org/dba/ontology/Credit">dba:Credit</a>
    /// </summary>
    let Credit = _prefixId.prefix "Credit"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Fidordfs:label : Credit line</para>
    ///   <para>rdfs:comment : Credito concesso da una banca, sotto qualunque forma, a un cliente che ne abbia fatto richiesta, dopo aver accertato le sue capacità reddituali, la consistenza patrimoniale e le sue doti morali, o, quando si tratti di un’impresa, quelle delle persone che la dirigono. La nozione va distinta da quella di prestitordfs:comment : Credit granted by a bank, in any form, to a customer who has requested it, after having ascertained the customer’s income capacity, assets and moral qualities, or, in the case of a company, those of the individuals managing it. The concept must be distinguished from that of a loan.</para>
    ///   <a href="https://w3id.org/dba/ontology/CreditLine">dba:CreditLine</a>
    /// </summary>
    let CreditLine = _prefixId.prefix "CreditLine"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Atto deliberativordfs:label : Deed of resolution</para>
    ///   <para>rdfs:comment : Verbale che documenta la conclusione di un processo decisionale.rdfs:comment : Minutes documenting the conclusion of a decision-making process.</para>
    ///   <a href="https://w3id.org/dba/ontology/DeedOfResolution">dba:DeedOfResolution</a>
    /// </summary>
    let DeedOfResolution = _prefixId.prefix "DeedOfResolution"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Eventordfs:label : Event</para>
    ///   <para>rdfs:comment : Una cosa che succede; un azione fatta dalla banca durante la propria attivitàrdfs:comment : A thing that happens or takes place; an action made by the Bank during the banking</para>
    ///   <a href="https://w3id.org/dba/ontology/Event">dba:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Pratica bancariardfs:label : File</para>
    ///   <para>rdfs:comment : L’insieme degli atti o dei documenti necessari per avviare e portare a termine un affare, e necessari per chiedere autorizzazioni, concessioni e simili. In senso concreto, l’insieme delle carte relative al singolo, a un determinato oggetto, e l’inserto, il fascicolo che le raccoglie.rdfs:comment : The set of deeds or documents required to start and conclude a business, and necessary to request authorisations, concessions and the suchlike. In a concrete sense, the set of papers relating to the individual, to a specific object, and the insert, the file that binds them together.</para>
    ///   <a href="https://w3id.org/dba/ontology/File">dba:File</a>
    /// </summary>
    let File = _prefixId.prefix "File"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Finanziamentordfs:label : Financing</para>
    ///   <para>rdfs:comment : Il fatto di provvedere con i mezzi necessari al compimento di un’opera, allo svolgimento di un’attività, oppure la somma fornita o ottenuta. In ambito privato è concesso da enti privati (banche e altri istituti finanziari, grosse industrie ecc.), o anche da cittadini singoli con la sottoscrizione di azioni, l’acquisto di obbligazioni, la concessione di credito e di garanzie, o con atti di mecenatismo (per es. sponsorizzazioni), per lo più come aiuto per la realizzazione di opere o per lo svolgimento di attività di interesse collettivo. Il finanziamento delle imprese può avvenire tramite concessione di credito a breve termine per l’attività corrente e a medio e lungo termine per fornire alle imprese i capitali necessari per l’impianto iniziale e il suo successivo ampliamento, oppure tramite ricorso diretto delle imprese stesse al mercato dei capitali con l’emissione di obbligazioni, o di azioni, oppure ancora attraverso l’opera di società finanziarie.rdfs:comment : The act of providing the necessary means for the completion of a work, for the performance of an activity, or the sum provided or obtained. In the private sector it is granted by private entities (banks and other financial institutions, large industries, etc.), or even by individual citizens with the underwriting of shares, the purchase of bonds, the granting of credit and guarantees, or with deeds of patronage (e.g. sponsorships), mostly as an aid for the completion of works or for the performance of activities of common interest. The financing of enterprises can take place through the granting of short-term credit for current activities and medium and long-term credit to provide the enterprises with the necessary capital for the initial set-up and their subsequent expansion, or through direct recourse by the same enterprises to the capital market with the issue of bonds, or shares, or even through the intermediation of financial companies.</para>
    ///   <a href="https://w3id.org/dba/ontology/Financing">dba:Financing</a>
    /// </summary>
    let Financing = _prefixId.prefix "Financing"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Garanziardfs:label : Guarantee</para>
    ///   <para>rdfs:comment : Da un punto di vista giuridico, mezzi idonei ad assicurare l’adempimento di un’obbligazione, l’esercizio di una funzione o, in genere, l’osservanza di un precetto legislativo o di un determinato impegno. Da un punto di vista economico, la g. è un trasferimento di rischio: chi la presta si assume un rischio che il beneficiario non sopporta più, sempre che la garanzia venga onorata.rdfs:comment : From a legal point of view, suitable means to ensure the fulfilment of an obligation, the exercise of a function or, in general, the observance of a legislative precept or a specific commitment. From an economic point of view, the guarantee is a transfer of risk: the lender assumes a risk that the beneficiary no longer bears, provided that the guarantee is honoured.</para>
    ///   <a href="https://w3id.org/dba/ontology/Guarantee">dba:Guarantee</a>
    /// </summary>
    let Guarantee = _prefixId.prefix "Guarantee"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Bene immobilerdfs:label : Immovable property</para>
    ///   <para>rdfs:comment : I beni immobili possono essere tali per natura, per destinazione del proprietario e per legge. Sono immobili per natura, oltre al suolo, quei beni che sono infissi nel suolo o su di essi poggiano saldamente, sono immobili gli edifici e tutte le costruzioni infisse nel suolo, in muratura o no, i natanti solidamente ancorati alla riva, come ponti di barche, pontili, traghetti, stabilimenti di bagni. Sono immobili per destinazione tutte quelle cose che sono accessorie rispetto alla cosa principale immobile: queste accessioni si sogliono chiamare pertinenze: cose autonome che però si trovano in rapporto di dipendenza alla cosa principale. Le pertinenze si distinguono in rurali e urbane, civili e industriali o aziendali. Sono immobili per determinazione di legge i diritti reali su cose immobili (es. diritti di uso, usufrutto, servitù…)rdfs:comment : immovable property can be such by nature, by the owner’s intended use and by law. In addition to the ground, property that is fixed into the ground or rests firmly on it is immovable by nature, as are buildings and all constructions fixed into the ground, whether in masonry or otherwise, boats solidly anchored to the shore, such as the decks of boats, piers, ferries, bathing establishments. All those things that are ancillary to the main immovable property are immovable by intended use: these ancillary elements are usually called appurtenances: autonomous things that however are in a relationship of dependence upon the main thing. Appurtenances are divided into rural and urban, civil and industrial or corporate. Rights in rem over immovable property are immovable by law (e.g. rights of use, usufruct, easement...)</para>
    ///   <a href="https://w3id.org/dba/ontology/ImmovableProperty">dba:ImmovableProperty</a>
    /// </summary>
    let ImmovableProperty = _prefixId.prefix "ImmovableProperty"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Ispezionerdfs:label : Inspection</para>
    ///   <para>rdfs:comment : La visita e il complesso delle verifiche compiute da un ispettore.rdfs:comment : The visit and the set of checks carried out by an inspector.</para>
    ///   <a href="https://w3id.org/dba/ontology/Inspection">dba:Inspection</a>
    /// </summary>
    let Inspection = _prefixId.prefix "Inspection"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Prestitordfs:label : Loan</para>
    ///   <para>rdfs:comment : Cessione di un quantitativo di beni presenti contro l’impegno di restituire un quantitativo analogo (p. gratuito) o maggiore (p. a interesse) di beni futuri, secondo modalità diverse. I p. possono essere: in natura o monetari; concessi da privati a privati (p. privati), da banche a privati e ad altre banche (p. bancari), dai privati e dalle banche allo Stato (p. pubblici o nazionali), da altri Stati o da cittadini e banche di altri Stati a uno Stato o a enti e imprese esistenti nello stesso (p. esteri o internazionali). Possono inoltre distinguersi: a seconda della durata, in p. a breve, a medio e a lungo termine; a seconda della garanzia, in p. ipotecari, su pegno, fideiussori, cambiari, fiduciari, allo scoperto; a seconda dell’impiego che ne fa il mutuatario, in p. consuntivi o produttivi.rdfs:comment : Transfer of a quantity of existing goods against the commitment to return the same quantity (free loan) or a greater quantity (interest-bearing loan) of future goods, according to different methods. Loans can be: in kind or monetary; granted by individuals to individuals (personal loans), by banks to individuals and other banks (bank loans), by individuals and banks to the State (public or national loans), by other States or by citizens and banks of other States to a State or to entities and companies present therein (foreign or international loans). They can also be distinguished: depending on the duration, in short-, medium- and long-term loans; depending on the guarantee, in mortgage loans, pledges, personal guarantee loans, bills of exchange, fiduciary loans, overdrafts; depending on the use made by the borrower, in consumption or commercial loans.</para>
    ///   <a href="https://w3id.org/dba/ontology/Loan">dba:Loan</a>
    /// </summary>
    let Loan = _prefixId.prefix "Loan"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Verbalerdfs:label : Minutes</para>
    ///   <para>rdfs:comment : Documento redatto da chi è investito di questa specifica funzione o da un pubblico ufficiale, allo scopo di attestare e ricordare, in forma sintetica, ma completa ed esauriente nei dati essenziali, fatti, procedimenti e avvenimenti di varia natura e quanto detto durante una riunione o un'assemblea.rdfs:comment : document drawn up by whoever is vested with this specific function or by a public official, in order to certify and remember - in a concise but complete and exhaustive form as regards the key data - facts, proceedings and events of various kinds and the matters discussed during a meeting or a shareholders’ meeting.</para>
    ///   <a href="https://w3id.org/dba/ontology/Minutes">dba:Minutes</a>
    /// </summary>
    let Minutes = _prefixId.prefix "Minutes"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Mutuordfs:label : Mortage</para>
    ///   <para>rdfs:comment : Il mutuo (artt. 1813-1822 c.c.) è il contratto con il quale una parte (mutuante) consegna una determinata quantità di danaro o di altre cose fungibili all’altra parte (mutuatario), che ne acquista la proprietà e si obbliga a restituire altrettante cose della stessa specie e qualità. Il mutuo è un contratto reale: per il suo perfezionamento è pertanto necessaria la consegna del danaro o delle cose mutuate (nella pratica, il mutuo ha per oggetto, in genere, una somma di danaro).rdfs:comment : A mortgage (articles 1813-1822 of the Italian Civil Code) is the contract with which a party (lender) delivers a certain amount of money or other fungible things to the other party (borrower), who acquires the ownership thereof and undertakes to return as many things of the same kind and quality. The mortgage is a real contract: for its completion it is therefore necessary to deliver the money or the borrowed property (in practice, the mortgage generally has as its object a sum of money).</para>
    ///   <a href="https://w3id.org/dba/ontology/Mortage">dba:Mortage</a>
    /// </summary>
    let Mortage = _prefixId.prefix "Mortage"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Bene mobilerdfs:label : Movable property</para>
    ///   <para>rdfs:comment : I beni mobili possono essere tali per natura o per determinazione di legge. Sono mobili per natura le cose che si possono trasportare da un luogo all’altro, sia per forza estranea che per proprietà intrinseca. Sono mobili per determinazione di legge, anzitutto i diritti reali su cose mobili, poi tutti i diritti di credito. Sono mobili le quote di partecipazione alle società commerciali, cioè il complesso dei diritti che competono al socio finché la società dura, cioè fin quando la liquidazione non è chiusa.rdfs:comment : Movable property can be such by nature or by law. Things that can be transported from one place to another are movable by nature, either by extraneous force or by intrinsic property. The rights in rem on movable property are first and foremost movable by law, then all credit rights. The shares in trading companies are movable, that is, the set of rights that accrue to the shareholder for the entire duration of the company, that is, until closing of the liquidation.</para>
    ///   <a href="https://w3id.org/dba/ontology/MovableProperty">dba:MovableProperty</a>
    /// </summary>
    let MovableProperty = _prefixId.prefix "MovableProperty"
    /// <summary>
    ///   <para>vs:term_status : Unstable</para>
    ///   <para>rdfs:label : Esitordfs:label : Outcome</para>
    ///   <para>rdfs:comment : Modalità di estinzione dell’attività creditizia e di chiusura della praticardfs:comment : Method of extinguishing the loan and closing the file</para>
    ///   <a href="https://w3id.org/dba/ontology/Outcome">dba:Outcome</a>
    /// </summary>
    let Outcome = _prefixId.prefix "Outcome"
    /// <summary>
    ///   <para>vs:term_status : Indica la fase di indagine preliminare relativa all’acquisizione di informazioni atte a definire possibilità e modalità di intervento sul mercato da parte di un’azienda.vs:term_status : unstable</para>
    ///   <para>rdfs:label : Istruttoriardfs:label : Preliminary assessment</para>
    ///   <para>rdfs:comment : Indicates the preliminary investigation phase relating to the acquisition of information aimed at defining the possibilities and methods of intervention on the market by a company.</para>
    ///   <a href="https://w3id.org/dba/ontology/PreliminaryAssessment">dba:PreliminaryAssessment</a>
    /// </summary>
    let PreliminaryAssessment = _prefixId.prefix "PreliminaryAssessment"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Benerdfs:label : Property</para>
    ///   <para>rdfs:comment : Nell’accezione generale, i beni sono prodotti o risorse che possono essere direttamente indirizzati al soddisfacimento di bisogni, oppure venire utilizzati per produrre altri beni. In quanto risorse o prodotti tangibili, i beni si distinguono dai servizi, che sono invece prestazioni erogate nel tempo.rdfs:comment : In the general sense, goods are products or resources that can be destined directly to the satisfaction of needs, or be used to produce other goods. As tangible resources or products, goods are distinguished from services, which are performances rendered over time.</para>
    ///   <a href="https://w3id.org/dba/ontology/Property">dba:Property</a>
    /// </summary>
    let Property = _prefixId.prefix "Property"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Relazionerdfs:label : Report</para>
    ///   <para>rdfs:comment : La relazione è un testo che riferisce in modo dettagliato e oggettivo su un'attività, uno studio o una analisi, oppure espone un argomento su cui si è raccolta un'apposita documentazione.rdfs:comment : A report is a text which reports in detailed and objective manner on an activity, a study or an analysis, or illustrates a topic on which appropriate documentation has been collected.</para>
    ///   <a href="https://w3id.org/dba/ontology/Report">dba:Report</a>
    /// </summary>
    let Report = _prefixId.prefix "Report"
    /// <summary>
    ///   <para>rdfs:label : Reportrdfs:label : Report document</para>
    ///   <para>rdfs:comment : Documento riepilogativo o di prospettordfs:comment : Summary or prospectus document</para>
    ///   <a href="https://w3id.org/dba/ontology/ReportDocument">dba:ReportDocument</a>
    /// </summary>
    let ReportDocument = _prefixId.prefix "ReportDocument"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Deliberardfs:label : Resolution</para>
    ///   <para>rdfs:comment : Decisione di un organo collegiale e provvedimento che ne scaturisce. Termine con cui si indica la decisione presa da un organo collegiale (es. assemblea). Esprime la volontà dell'ente. Solitamente la delibera è documentata in un verbale, cioè in un atto pubblico.rdfs:comment : Decision of a board and the resulting provision. Term used to indicate the decision taken by a board (e.g. shareholders’ meeting). It expresses the will of the entity. Usually the resolution is documented in a set of minutes, that is, in a public document.</para>
    ///   <a href="https://w3id.org/dba/ontology/Resolution">dba:Resolution</a>
    /// </summary>
    let Resolution = _prefixId.prefix "Resolution"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Restituzionerdfs:label : Restitution</para>
    ///   <para>rdfs:comment : L’azione personale di restituzione è destinata a ottenere l’adempimento dell’obbligazione di ritrasferire una cosa che è stata in precedenza volontariamente trasmessa dall’attore al convenuto, in forza di negozi quali la locazione, il comodato, il deposito e così via, che non presuppongono necessariamente nel tradens la qualità di proprietario, La restituzione mira ad ottenere il ritrasferimento di un bene in precedenza volontariamente trasmesso dall’attore al convenuto. l titolare di un diritto reale su un bene (mobile o immobile) può infatti chiedere la restituzione del bene da parte di chiunque si sia appropriato del bene (esercitando il mero possesso) o da chiunque detiene il bene (esercitando la detenzione per conto altrui).rdfs:comment : The personal act of restitution is intended to obtain the fulfilment of the obligation to retransfer something that has previously been voluntarily transmitted by the plaintiff to the defendant, by virtue of transactions such as lease, loan, deposit and so on, which do not necessarily require the title of ownership. The restitution aims to obtain the retransfer of an asset previously voluntarily transmitted by the plaintiff to the defendant. The holder of right in rem on an asset (whether movable or immovable) can thus request the restitution of the asset from anyone who has appropriated the asset (exercising mere possession) or from anyone who owns the asset (exercising possession on account of others).</para>
    ///   <a href="https://w3id.org/dba/ontology/Restitution">dba:Restitution</a>
    /// </summary>
    let Restitution = _prefixId.prefix "Restitution"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Sequestrordfs:label : Seizure</para>
    ///   <para>rdfs:comment : Nel linguaggio giuridico, misura cautelare, che fa sorgere un vincolo di indisponibilità sui beni colpiti, mobili o immobili, tendente ad assicurare una certa situazione di fatto o di diritto. Provvedimento diretto a sottrarre la libera disponibilità di beni mobili e immobili, di aziende e simili, ai loro detentori.rdfs:comment : In legal jargon, a precautionary measure, which gives rise to a restriction of unavailability on the affected movable or immovable property, in order to ensure a certain factual or legal situation. Provision aimed at removing the free availability of movable and immovable property, of companies and the like, from their holders.</para>
    ///   <a href="https://w3id.org/dba/ontology/Seizure">dba:Seizure</a>
    /// </summary>
    let Seizure = _prefixId.prefix "Seizure"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Sequestrordfs:label : Seizure</para>
    ///   <para>rdfs:comment : Esecuzione del sequestrordfs:comment : Execution of the seizure</para>
    ///   <a href="https://w3id.org/dba/ontology/SeizureEvent">dba:SeizureEvent</a>
    /// </summary>
    let SeizureEvent = _prefixId.prefix "SeizureEvent"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Sponsorizzazionirdfs:label : Sponsorships</para>
    ///   <para>rdfs:comment : Si definisce contratto di sponsorizzazione (o sponsorship) quel contratto con il quale una parte – detta “sponsor” – si obbliga a versare un corrispettivo a favore di un’altra parte – detta “sponsee” o “sponsorizzato” – la quale, a sua volta, si obbliga a divulgare il nome o il marchio dello sponsor nel corso delle proprie attività, nell’intento di ottenere un ritorno positivo in termini di notorietà e immagine, beneficiando delle potenzialità comunicazionali dell’evento stesso.
    /// La sponsorizzazione identifica il rapporto tra un’azienda, o un brand, e un’iniziativa culturale, sportiva, musicale, etica, che viene finanziata in tutto o in parte grazie a un accordo economico di durata variabile.rdfs:comment : A sponsorship contract is defined as the contract by which a party - called the “sponsor” - undertakes to pay a fee in favour of another party - called the “sponsee” - which, in turn, undertakes to disclose the sponsor’s name or brand in the course of its activities, with the aim of obtaining a positive return in terms of notoriety and image, thereby benefiting from the promotional potential of the event itself.
    /// The sponsorship identifies the relationship between a company, or a brand, and a cultural, sporting, musical or ethical initiative, which is financed in whole or in part thanks to an economic agreement of variable duration.</para>
    ///   <a href="https://w3id.org/dba/ontology/Sponsorships">dba:Sponsorships</a>
    /// </summary>
    let Sponsorships = _prefixId.prefix "Sponsorships"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Sussidiordfs:label : Subsidy</para>
    ///   <para>rdfs:comment : Aiuto finanziario concesso a persone, imprese, comunità e istituzioni varie. In generale è complementare e integrativo, e finalizzato alla realizzazione di determinate attività e obiettivi.rdfs:comment : Financial aid granted to individuals, businesses, communities and miscellaneous institutions. In general, it is complementary and supplementary, and aimed at achieving certain activities and objectives.</para>
    ///   <a href="https://w3id.org/dba/ontology/Subsidy">dba:Subsidy</a>
    /// </summary>
    let Subsidy = _prefixId.prefix "Subsidy"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : importordfs:label : amount</para>
    ///   <a href="https://w3id.org/dba/ontology/amount">dba:amount</a>
    /// </summary>
    let amount = _prefixId.prefix "amount"
    /// <summary>
    ///   <para>rdfs:comment : Property that describes the relationship between an agent and a bank servicerdfs:comment : Proprietà che descrive la relazione tra un agent e un servizio bancario</para>
    ///   <para>rdfs:label : applies forrdfs:label : presenta domanda di</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <a href="https://w3id.org/dba/ontology/appliesFor">dba:appliesFor</a>
    /// </summary>
    let appliesFor = _prefixId.prefix "appliesFor"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : importo deliberatordfs:label : approved amount</para>
    ///   <a href="https://w3id.org/dba/ontology/approvedAmount">dba:approvedAmount</a>
    /// </summary>
    let approvedAmount = _prefixId.prefix "approvedAmount"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : durata deliberatardfs:label : approval duration</para>
    ///   <a href="https://w3id.org/dba/ontology/approvedDuration">dba:approvedDuration</a>
    /// </summary>
    let approvedDuration = _prefixId.prefix "approvedDuration"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : approvardfs:label : approves</para>
    ///   <para>rdfs:comment : Proprietà inversa di "approvato da"rdfs:comment : Inverse property of "approved by"</para>
    ///   <a href="https://w3id.org/dba/ontology/approves">dba:approves</a>
    /// </summary>
    let approves = _prefixId.prefix "approves"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : si compone dirdfs:label : consists of</para>
    ///   <para>rdfs:comment : Proprietà che descrive la relazione tra una pratica bancaria e gli eventi in cui si articolardfs:comment : Property that describes the relationship between a banking file and the events in which it is divided</para>
    ///   <a href="https://w3id.org/dba/ontology/consistsOf">dba:consistsOf</a>
    /// </summary>
    let consistsOf = _prefixId.prefix "consistsOf"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : valutardfs:label : currency</para>
    ///   <a href="https://w3id.org/dba/ontology/currency">dba:currency</a>
    /// </summary>
    let currency = _prefixId.prefix "currency"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : duratardfs:label : duration</para>
    ///   <a href="https://w3id.org/dba/ontology/duration">dba:duration</a>
    /// </summary>
    let duration = _prefixId.prefix "duration"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : data di finerdfs:label : end date</para>
    ///   <a href="https://w3id.org/dba/ontology/endDate">dba:endDate</a>
    /// </summary>
    let endDate = _prefixId.prefix "endDate"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : numero di praticardfs:label : file number</para>
    ///   <a href="https://w3id.org/dba/ontology/fileNumber">dba:fileNumber</a>
    /// </summary>
    let fileNumber = _prefixId.prefix "fileNumber"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : evento successivordfs:label : following event</para>
    ///   <para>rdfs:comment : Proprietà che desccrive la relazione tra una successione di eventirdfs:comment : An event that starts at some time after this event.</para>
    ///   <a href="https://w3id.org/dba/ontology/hasFollowingEvent">dba:hasFollowingEvent</a>
    /// </summary>
    let hasFollowingEvent = _prefixId.prefix "hasFollowingEvent"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : sotto eventordfs:label : subevent</para>
    ///   <para>rdfs:comment : Questa proprietà fornisce un modo per suddividere un evento complesso in eventi più semplici. Descrive la relazione tra più eventirdfs:comment : This property provides a way to split a complex event into simpler ones. It decribes the relationship between more events</para>
    ///   <a href="https://w3id.org/dba/ontology/hasSubEvent">dba:hasSubEvent</a>
    /// </summary>
    let hasSubEvent = _prefixId.prefix "hasSubEvent"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : ha soggettordfs:label : has subject</para>
    ///   <para>rdfs:comment : Proprietà inversa di "is subject of"rdfs:comment : Inverse property of "is subject of"</para>
    ///   <a href="https://w3id.org/dba/ontology/hasSubject">dba:hasSubject</a>
    /// </summary>
    let hasSubject = _prefixId.prefix "hasSubject"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Include o richiederdfs:label : Includes</para>
    ///   <para>rdfs:comment : Proprietà che descrive la relazione tra un documento e una garanziardfs:comment : Property that describes the relationship between a document and a guarantee</para>
    ///   <a href="https://w3id.org/dba/ontology/includes">dba:includes</a>
    /// </summary>
    let includes = _prefixId.prefix "includes"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : tassordfs:label : interest rate</para>
    ///   <a href="https://w3id.org/dba/ontology/interestRate">dba:interestRate</a>
    /// </summary>
    let interestRate = _prefixId.prefix "interestRate"
    /// <summary>
    ///   <para>rdfs:label : coinvolgerdfs:label : involves</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:comment : Property that describes the relationship between an event and a propertyrdfs:comment : Proprietà che descrive la relazione tra un evento e un bene</para>
    ///   <a href="https://w3id.org/dba/ontology/involves">dba:involves</a>
    /// </summary>
    let involves = _prefixId.prefix "involves"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : approvato dardfs:label : is approved by</para>
    ///   <para>rdfs:comment : Proprietà utilizzata per descrivere la relazione tra una delibera e il soggetto che la autorizzardfs:comment : Property used to describe the relationship between an approval and the person who authorizes it</para>
    ///   <a href="https://w3id.org/dba/ontology/isApprovedBy">dba:isApprovedBy</a>
    /// </summary>
    let isApprovedBy = _prefixId.prefix "isApprovedBy"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : si basa surdfs:label : based on</para>
    ///   <para>rdfs:comment : Proprietà che descrive la relazione tra un evento e una garanzia che può essere richiesta durante l'eventordfs:comment : Property that describes the relationship between an event and a guarantee that can be requested during the event</para>
    ///   <a href="https://w3id.org/dba/ontology/isBasedOn">dba:isBasedOn</a>
    /// </summary>
    let isBasedOn = _prefixId.prefix "isBasedOn"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : documentato dardfs:label : documented by</para>
    ///   <para>rdfs:comment : Proprietà che descrive la relazione tra una pratica bancaria o un evento e una risorsa archivisticardfs:comment : Property that describes the relationship between a banking file or event and an archival instance</para>
    ///   <a href="https://w3id.org/dba/ontology/isDocumentedBy">dba:isDocumentedBy</a>
    /// </summary>
    let isDocumentedBy = _prefixId.prefix "isDocumentedBy"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : è garantito dardfs:label : is guaranteed by</para>
    ///   <para>rdfs:comment : Proprietà che descrive la relazione tra una garanzia e un agentrdfs:comment : Property that describes the relationship between a guarantee and an agent</para>
    ///   <a href="https://w3id.org/dba/ontology/isGuaranteedBy">dba:isGuaranteedBy</a>
    /// </summary>
    let isGuaranteedBy = _prefixId.prefix "isGuaranteedBy"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : coinvolto inrdfs:label : involved in</para>
    ///   <para>rdfs:comment : Proprietà inversa di involvesrdfs:comment : Inverse property of involves</para>
    ///   <a href="https://w3id.org/dba/ontology/isInvolvedIn">dba:isInvolvedIn</a>
    /// </summary>
    let isInvolvedIn = _prefixId.prefix "isInvolvedIn"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : preparato dardfs:label : prepared by</para>
    ///   <para>rdfs:comment : Proprietà che descrive la relazione tra un documento e l'agent che lo ha redattordfs:comment : Property that describes the relationship between a document and the agent who wrote it</para>
    ///   <a href="https://w3id.org/dba/ontology/isPreparedBy">dba:isPreparedBy</a>
    /// </summary>
    let isPreparedBy = _prefixId.prefix "isPreparedBy"
    /// <summary>
    ///   <para>rdfs:label : soggetto dirdfs:label : subjectOf</para>
    ///   <para>rdfs:comment : Property that describes the relationship between a banking service, suche as loan, receivables mortgage creditline, or a property and a banking filerdfs:comment : Proprietà che descrive la relazione tra un servizio bancario o un bene e una pratica bancaria</para>
    ///   <para>vs:term_status : unstable</para>
    ///   <a href="https://w3id.org/dba/ontology/isSubjectOf">dba:isSubjectOf</a>
    /// </summary>
    let isSubjectOf = _prefixId.prefix "isSubjectOf"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : è soggetto ardfs:label : is subject to</para>
    ///   <para>rdfs:comment : Proprietà che descrive la relazione tra un bene e la garanzia a cui è soggettordfs:comment : Property that describes the relationship between a property and the guarantee to which it is subject</para>
    ///   <a href="https://w3id.org/dba/ontology/isSubjectTo">dba:isSubjectTo</a>
    /// </summary>
    let isSubjectTo = _prefixId.prefix "isSubjectTo"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : identificativo localerdfs:label : local identifier</para>
    ///   <a href="https://w3id.org/dba/ontology/localIdentifier">dba:localIdentifier</a>
    /// </summary>
    let localIdentifier = _prefixId.prefix "localIdentifier"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : citardfs:label : mentions</para>
    ///   <para>rdfs:comment : Proprietà utilizzata per descrivere la relazione tra un documento e il soggetto citato in essordfs:comment : Property used to describe the relationship between a document and the agent mentioned in it</para>
    ///   <a href="https://w3id.org/dba/ontology/mentions">dba:mentions</a>
    /// </summary>
    let mentions = _prefixId.prefix "mentions"
    let note = _prefixId.prefix "note"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : esitordfs:label : outcome</para>
    ///   <a href="https://w3id.org/dba/ontology/outcome">dba:outcome</a>
    /// </summary>
    let outcome = _prefixId.prefix "outcome"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : istruiscerdfs:label : prepares</para>
    ///   <para>rdfs:comment : Proprietà che descrive la relazione tra una banca e una pratica bancariardfs:comment : Property that describes the relationship between a bank and a banking file</para>
    ///   <a href="https://w3id.org/dba/ontology/prepares">dba:prepares</a>
    /// </summary>
    let prepares = _prefixId.prefix "prepares"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : scopordfs:label : purpose</para>
    ///   <a href="https://w3id.org/dba/ontology/purpose">dba:purpose</a>
    /// </summary>
    let purpose = _prefixId.prefix "purpose"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : riguardardfs:label : regards</para>
    ///   <para>rdfs:comment : Proprietà che descrive la relazione tra un documento e un agentrdfs:comment : Property that describes the relationship between a document and an agent</para>
    ///   <a href="https://w3id.org/dba/ontology/regards">dba:regards</a>
    /// </summary>
    let regards = _prefixId.prefix "regards"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : importo richiestordfs:label : required amount</para>
    ///   <a href="https://w3id.org/dba/ontology/requiredAmount">dba:requiredAmount</a>
    /// </summary>
    let requiredAmount = _prefixId.prefix "requiredAmount"
    /// <summary>
    ///   <para>vs:term_status : durata richiestavs:term_status : unstablevs:term_status : required duration</para>
    ///   <a href="https://w3id.org/dba/ontology/requiredDuration">dba:requiredDuration</a>
    /// </summary>
    let requiredDuration = _prefixId.prefix "requiredDuration"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : data di restituzionerdfs:label : restitution date</para>
    ///   <a href="https://w3id.org/dba/ontology/restitutionDate">dba:restitutionDate</a>
    /// </summary>
    let restitutionDate = _prefixId.prefix "restitutionDate"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : data di sequestrordfs:label : seizure date</para>
    ///   <a href="https://w3id.org/dba/ontology/seizureDate">dba:seizureDate</a>
    /// </summary>
    let seizureDate = _prefixId.prefix "seizureDate"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : specificherdfs:label : specifications</para>
    ///   <a href="https://w3id.org/dba/ontology/specifications">dba:specifications</a>
    /// </summary>
    let specifications = _prefixId.prefix "specifications"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : data di iniziordfs:label : start date</para>
    ///   <a href="https://w3id.org/dba/ontology/startDate">dba:startDate</a>
    /// </summary>
    let startDate = _prefixId.prefix "startDate"
