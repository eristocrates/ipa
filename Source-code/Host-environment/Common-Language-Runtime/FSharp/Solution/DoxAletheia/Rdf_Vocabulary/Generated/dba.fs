namespace https.w3id.org.dba.ontology.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dba =
    let _namespace_iri = Namespace_Iri dba |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:dba/ontology/</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>voaf:Vocabulary</para>
    ///
    /// labels<para>"Ontologia per la descrizione delle pratiche bancarie e della documentazione correlata"</para><para>"Description Banking Archives Ontology"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/">https://w3id.org/dba/ontology/</seealso>
    let _prefix_iri = Prefixed_Name(dba, "") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/Alienation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Legal deed by which a property or a right on the goods comprising one’s own assets is transferred to other entities, through sale, donation, mortgage, etc."</para>
    ///   <para>"Atto giuridico con cui si trasferiscono ad altri soggetti una proprietà o un diritto su beni del proprio patrimonio, mediante vendita, donazione, mutuo, ecc."</para>
    /// labels<para>"Alienation"</para><para>"Alienazione"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/Alienation">https://w3id.org/dba/ontology/Alienation</seealso>
    let Alienation = Prefixed_Name(dba, "Alienation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/Application</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Formulation of a request for a service, for example the disbursement of a mortgage or a loan, from a customer to the banking company."</para>
    ///   <para>"Formulazione di una richiesta di un servizio, ad esempio l’erogazione di un mutuo o un finanziamento, da parte di un cliente all’azienda bancaria."</para>
    /// labels<para>"Application"</para><para>"Domanda"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/Application">https://w3id.org/dba/ontology/Application</seealso>
    let Application = Prefixed_Name(dba, "Application") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/Audit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Verification of the formal or substantive regularity of a document, a factual situation or a right. The audit may refer, within the scope of companies, to checks of an economic nature, of a legal nature, of an accounting nature, of a financial nature, of a technical nature, etc."</para>
    ///   <para>"Accertamento della regolarità formale o sostanziale di un documento, di una situazione di fatto o di un diritto. La verifica può riferirsi, nell’ambito delle aziende, a controlli di carattere economico, di natura giuridica, di natura contabile, di natura finanziaria, di carattere tecnico, ecc."</para>
    /// labels<para>"Verifica"</para><para>"Audit"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/Audit">https://w3id.org/dba/ontology/Audit</seealso>
    let Audit = Prefixed_Name(dba, "Audit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/Bank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Company that carries out fundraising transactions and disburses non-transferable loans on the market."</para>
    ///   <para>"Impresa che compie operazioni di raccolta di fondi ed eroga crediti non trasferibili sul mercato"</para>
    /// labels<para>"Banca"</para><para>"Bank"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/Bank">https://w3id.org/dba/ontology/Bank</seealso>
    let Bank = Prefixed_Name(dba, "Bank") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/Conclusion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The act of concluding, that is, finalising a contract, and sometimes the contract itself."</para>
    ///   <para>"L'atto dello stipulare, cioè del concludere un contratto, e talora il contratto stesso."</para>
    /// labels<para>"Stipula"</para><para>"Conclusion"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/Conclusion">https://w3id.org/dba/ontology/Conclusion</seealso>
    let Conclusion = Prefixed_Name(dba, "Conclusion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/Confiscation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"La confisca consiste in una pena accessoria che viene comminata a seguito di condanna e che consiste in una vera e propria espropriazione a favore dello Stato. E’ infatti una misura di sicurezza a carattere patrimoniale consistente nell'espropriazione forzata e gratuita a favore dello Stato ed, in materia urbanistica, a favore del patrimonio del Comune, di tutte le cose che costituiscono il prezzo del reato, che sono servite a commettere il reato, di quelle che ne sono il prodotto e il profitto, nonchè di quelle che sono di per sè criminose. Tale misura può essere facoltativa o obbligatoria."</para>
    ///   <para>"Confiscation consists of an ancillary penalty which is imposed following a conviction and which consists of an actual expropriation in favour of the State. It is therefore a security measure of a patrimonial nature consisting of the forced and free expropriation in favour of the State and, in an urban context, in favour of a Municipality’s assets, of all the things that comprise the price of the crime, which were used to commit the crime, those which constitute the product and the profit of such crime, as well as those which are criminal by nature. This measure can be optional or mandatory."</para>
    /// labels<para>"Confisca"</para><para>"Confiscation"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/Confiscation">https://w3id.org/dba/ontology/Confiscation</seealso>
    let Confiscation = Prefixed_Name(dba, "Confiscation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/ConfiscationEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Esecuzione della confisca"</para>
    ///   <para>"Execution of the confiscation"</para>
    /// labels<para>"Confiscation"</para><para>"Confisca"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/ConfiscationEvent">https://w3id.org/dba/ontology/ConfiscationEvent</seealso>
    let ConfiscationEvent = Prefixed_Name(dba, "ConfiscationEvent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/Contract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The contract is defined by art. 1321 of the Italian Civil Code as “the agreement of two or more parties to establish, govern or terminate a legal patrimonial relationship between them”."</para>
    ///   <para>"Il contratto è definito dall’art. 1321 c.c. come “l’accordo di due o più parti per costituire, regolare o estinguere tra loro un rapporto giuridico patrimoniale”"</para>
    /// labels<para>"Contract"</para><para>"Contratto"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/Contract">https://w3id.org/dba/ontology/Contract</seealso>
    let Contract = Prefixed_Name(dba, "Contract") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/Credit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Advance of resources, in the form of the provision of goods or services or the transfer of sums of money, which an economic agent grants to another against a promise of future restitution in one or more tranches, according to the methods and times specified in the contract. A credit can arise directly from commercial relationships between two companies or between a company (an entrepreneur) and a family, or involve a financial intermediary qualified to trade in the credit sector [for example a bank]."</para>
    ///   <para>"Anticipazione di risorse, nella forma di prestazione di beni o servizi o cessione di somme di denaro, che un agente economico concede ad altro a fronte di una promessa di restituzione futura in una o più soluzioni, secondo modalità e tempi specificati contrattualmente. Il c. può nascere direttamente da rapporti commerciali fra due imprese o fra un’impresa (un imprenditore) e una famiglia, oppure coinvolgere un intermediario finanziario abilitato a operare nel settore del credito [per esempio una banca]."</para>
    /// labels<para>"Credit"</para><para>"Crediti"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/Credit">https://w3id.org/dba/ontology/Credit</seealso>
    let Credit = Prefixed_Name(dba, "Credit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/CreditLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Credit granted by a bank, in any form, to a customer who has requested it, after having ascertained the customer’s income capacity, assets and moral qualities, or, in the case of a company, those of the individuals managing it. The concept must be distinguished from that of a loan."</para>
    ///   <para>"Credito concesso da una banca, sotto qualunque forma, a un cliente che ne abbia fatto richiesta, dopo aver accertato le sue capacità reddituali, la consistenza patrimoniale e le sue doti morali, o, quando si tratti di un’impresa, quelle delle persone che la dirigono. La nozione va distinta da quella di prestito"</para>
    /// labels<para>"Fido"</para><para>"Credit line"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/CreditLine">https://w3id.org/dba/ontology/CreditLine</seealso>
    let CreditLine = Prefixed_Name(dba, "CreditLine") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/DeedOfResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Verbale che documenta la conclusione di un processo decisionale."</para>
    ///   <para>"Minutes documenting the conclusion of a decision-making process."</para>
    /// labels<para>"Deed of resolution"</para><para>"Atto deliberativo"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/DeedOfResolution">https://w3id.org/dba/ontology/DeedOfResolution</seealso>
    let DeedOfResolution = Prefixed_Name(dba, "DeedOfResolution") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A thing that happens or takes place; an action made by the Bank during the banking"</para>
    ///   <para>"Una cosa che succede; un azione fatta dalla banca durante la propria attività"</para>
    /// labels<para>"Evento"</para><para>"Event"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/Event">https://w3id.org/dba/ontology/Event</seealso>
    let Event = Prefixed_Name(dba, "Event") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/File</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The set of deeds or documents required to start and conclude a business, and necessary to request authorisations, concessions and the suchlike. In a concrete sense, the set of papers relating to the individual, to a specific object, and the insert, the file that binds them together."</para>
    ///   <para>"L’insieme degli atti o dei documenti necessari per avviare e portare a termine un affare, e necessari per chiedere autorizzazioni, concessioni e simili. In senso concreto, l’insieme delle carte relative al singolo, a un determinato oggetto, e l’inserto, il fascicolo che le raccoglie."</para>
    /// labels<para>"File"</para><para>"Pratica bancaria"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/File">https://w3id.org/dba/ontology/File</seealso>
    let File = Prefixed_Name(dba, "File") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/Financing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The act of providing the necessary means for the completion of a work, for the performance of an activity, or the sum provided or obtained. In the private sector it is granted by private entities (banks and other financial institutions, large industries, etc.), or even by individual citizens with the underwriting of shares, the purchase of bonds, the granting of credit and guarantees, or with deeds of patronage (e.g. sponsorships), mostly as an aid for the completion of works or for the performance of activities of common interest. The financing of enterprises can take place through the granting of short-term credit for current activities and medium and long-term credit to provide the enterprises with the necessary capital for the initial set-up and their subsequent expansion, or through direct recourse by the same enterprises to the capital market with the issue of bonds, or shares, or even through the intermediation of financial companies."</para>
    ///   <para>"Il fatto di provvedere con i mezzi necessari al compimento di un’opera, allo svolgimento di un’attività, oppure la somma fornita o ottenuta. In ambito privato è concesso da enti privati (banche e altri istituti finanziari, grosse industrie ecc.), o anche da cittadini singoli con la sottoscrizione di azioni, l’acquisto di obbligazioni, la concessione di credito e di garanzie, o con atti di mecenatismo (per es. sponsorizzazioni), per lo più come aiuto per la realizzazione di opere o per lo svolgimento di attività di interesse collettivo. Il finanziamento delle imprese può avvenire tramite concessione di credito a breve termine per l’attività corrente e a medio e lungo termine per fornire alle imprese i capitali necessari per l’impianto iniziale e il suo successivo ampliamento, oppure tramite ricorso diretto delle imprese stesse al mercato dei capitali con l’emissione di obbligazioni, o di azioni, oppure ancora attraverso l’opera di società finanziarie."</para>
    /// labels<para>"Financing"</para><para>"Finanziamento"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/Financing">https://w3id.org/dba/ontology/Financing</seealso>
    let Financing = Prefixed_Name(dba, "Financing") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/Guarantee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Da un punto di vista giuridico, mezzi idonei ad assicurare l’adempimento di un’obbligazione, l’esercizio di una funzione o, in genere, l’osservanza di un precetto legislativo o di un determinato impegno. Da un punto di vista economico, la g. è un trasferimento di rischio: chi la presta si assume un rischio che il beneficiario non sopporta più, sempre che la garanzia venga onorata."</para>
    ///   <para>"From a legal point of view, suitable means to ensure the fulfilment of an obligation, the exercise of a function or, in general, the observance of a legislative precept or a specific commitment. From an economic point of view, the guarantee is a transfer of risk: the lender assumes a risk that the beneficiary no longer bears, provided that the guarantee is honoured."</para>
    /// labels<para>"Guarantee"</para><para>"Garanzia"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/Guarantee">https://w3id.org/dba/ontology/Guarantee</seealso>
    let Guarantee = Prefixed_Name(dba, "Guarantee") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/ImmovableProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"immovable property can be such by nature, by the owner’s intended use and by law. In addition to the ground, property that is fixed into the ground or rests firmly on it is immovable by nature, as are buildings and all constructions fixed into the ground, whether in masonry or otherwise, boats solidly anchored to the shore, such as the decks of boats, piers, ferries, bathing establishments. All those things that are ancillary to the main immovable property are immovable by intended use: these ancillary elements are usually called appurtenances: autonomous things that however are in a relationship of dependence upon the main thing. Appurtenances are divided into rural and urban, civil and industrial or corporate. Rights in rem over immovable property are immovable by law (e.g. rights of use, usufruct, easement...)"</para>
    ///   <para>"I beni immobili possono essere tali per natura, per destinazione del proprietario e per legge. Sono immobili per natura, oltre al suolo, quei beni che sono infissi nel suolo o su di essi poggiano saldamente, sono immobili gli edifici e tutte le costruzioni infisse nel suolo, in muratura o no, i natanti solidamente ancorati alla riva, come ponti di barche, pontili, traghetti, stabilimenti di bagni. Sono immobili per destinazione tutte quelle cose che sono accessorie rispetto alla cosa principale immobile: queste accessioni si sogliono chiamare pertinenze: cose autonome che però si trovano in rapporto di dipendenza alla cosa principale. Le pertinenze si distinguono in rurali e urbane, civili e industriali o aziendali. Sono immobili per determinazione di legge i diritti reali su cose immobili (es. diritti di uso, usufrutto, servitù…)"</para>
    /// labels<para>"Bene immobile"</para><para>"Immovable property"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/ImmovableProperty">https://w3id.org/dba/ontology/ImmovableProperty</seealso>
    let ImmovableProperty = Prefixed_Name(dba, "ImmovableProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/Inspection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"La visita e il complesso delle verifiche compiute da un ispettore."</para>
    ///   <para>"The visit and the set of checks carried out by an inspector."</para>
    /// labels<para>"Inspection"</para><para>"Ispezione"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/Inspection">https://w3id.org/dba/ontology/Inspection</seealso>
    let Inspection = Prefixed_Name(dba, "Inspection") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/Loan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Cessione di un quantitativo di beni presenti contro l’impegno di restituire un quantitativo analogo (p. gratuito) o maggiore (p. a interesse) di beni futuri, secondo modalità diverse. I p. possono essere: in natura o monetari; concessi da privati a privati (p. privati), da banche a privati e ad altre banche (p. bancari), dai privati e dalle banche allo Stato (p. pubblici o nazionali), da altri Stati o da cittadini e banche di altri Stati a uno Stato o a enti e imprese esistenti nello stesso (p. esteri o internazionali). Possono inoltre distinguersi: a seconda della durata, in p. a breve, a medio e a lungo termine; a seconda della garanzia, in p. ipotecari, su pegno, fideiussori, cambiari, fiduciari, allo scoperto; a seconda dell’impiego che ne fa il mutuatario, in p. consuntivi o produttivi."</para>
    ///   <para>"Transfer of a quantity of existing goods against the commitment to return the same quantity (free loan) or a greater quantity (interest-bearing loan) of future goods, according to different methods. Loans can be: in kind or monetary; granted by individuals to individuals (personal loans), by banks to individuals and other banks (bank loans), by individuals and banks to the State (public or national loans), by other States or by citizens and banks of other States to a State or to entities and companies present therein (foreign or international loans). They can also be distinguished: depending on the duration, in short-, medium- and long-term loans; depending on the guarantee, in mortgage loans, pledges, personal guarantee loans, bills of exchange, fiduciary loans, overdrafts; depending on the use made by the borrower, in consumption or commercial loans."</para>
    /// labels<para>"Prestito"</para><para>"Loan"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/Loan">https://w3id.org/dba/ontology/Loan</seealso>
    let Loan = Prefixed_Name(dba, "Loan") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/Minutes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"document drawn up by whoever is vested with this specific function or by a public official, in order to certify and remember - in a concise but complete and exhaustive form as regards the key data - facts, proceedings and events of various kinds and the matters discussed during a meeting or a shareholders’ meeting."</para>
    ///   <para>"Documento redatto da chi è investito di questa specifica funzione o da un pubblico ufficiale, allo scopo di attestare e ricordare, in forma sintetica, ma completa ed esauriente nei dati essenziali, fatti, procedimenti e avvenimenti di varia natura e quanto detto durante una riunione o un'assemblea."</para>
    /// labels<para>"Verbale"</para><para>"Minutes"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/Minutes">https://w3id.org/dba/ontology/Minutes</seealso>
    let Minutes = Prefixed_Name(dba, "Minutes") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/Mortage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Il mutuo (artt. 1813-1822 c.c.) è il contratto con il quale una parte (mutuante) consegna una determinata quantità di danaro o di altre cose fungibili all’altra parte (mutuatario), che ne acquista la proprietà e si obbliga a restituire altrettante cose della stessa specie e qualità. Il mutuo è un contratto reale: per il suo perfezionamento è pertanto necessaria la consegna del danaro o delle cose mutuate (nella pratica, il mutuo ha per oggetto, in genere, una somma di danaro)."</para>
    ///   <para>"A mortgage (articles 1813-1822 of the Italian Civil Code) is the contract with which a party (lender) delivers a certain amount of money or other fungible things to the other party (borrower), who acquires the ownership thereof and undertakes to return as many things of the same kind and quality. The mortgage is a real contract: for its completion it is therefore necessary to deliver the money or the borrowed property (in practice, the mortgage generally has as its object a sum of money)."</para>
    /// labels<para>"Mortage"</para><para>"Mutuo"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/Mortage">https://w3id.org/dba/ontology/Mortage</seealso>
    let Mortage = Prefixed_Name(dba, "Mortage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/MovableProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Movable property can be such by nature or by law. Things that can be transported from one place to another are movable by nature, either by extraneous force or by intrinsic property. The rights in rem on movable property are first and foremost movable by law, then all credit rights. The shares in trading companies are movable, that is, the set of rights that accrue to the shareholder for the entire duration of the company, that is, until closing of the liquidation."</para>
    ///   <para>"I beni mobili possono essere tali per natura o per determinazione di legge. Sono mobili per natura le cose che si possono trasportare da un luogo all’altro, sia per forza estranea che per proprietà intrinseca. Sono mobili per determinazione di legge, anzitutto i diritti reali su cose mobili, poi tutti i diritti di credito. Sono mobili le quote di partecipazione alle società commerciali, cioè il complesso dei diritti che competono al socio finché la società dura, cioè fin quando la liquidazione non è chiusa."</para>
    /// labels<para>"Bene mobile"</para><para>"Movable property"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/MovableProperty">https://w3id.org/dba/ontology/MovableProperty</seealso>
    let MovableProperty = Prefixed_Name(dba, "MovableProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/Outcome</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Method of extinguishing the loan and closing the file"</para>
    ///   <para>"Modalità di estinzione dell’attività creditizia e di chiusura della pratica"</para>
    /// labels<para>"Esito"</para><para>"Outcome"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/Outcome">https://w3id.org/dba/ontology/Outcome</seealso>
    let Outcome = Prefixed_Name(dba, "Outcome") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dba/ontology/PreliminaryAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates the preliminary investigation phase relating to the acquisition of information aimed at defining the possibilities and methods of intervention on the market by a company."</para>
    /// labels<para>"Istruttoria"</para><para>"Preliminary assessment"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/PreliminaryAssessment">https://w3id.org/dba/ontology/PreliminaryAssessment</seealso>
    let PreliminaryAssessment =
        Prefixed_Name(dba, "PreliminaryAssessment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:dba/ontology/Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In the general sense, goods are products or resources that can be destined directly to the satisfaction of needs, or be used to produce other goods. As tangible resources or products, goods are distinguished from services, which are performances rendered over time."</para>
    ///   <para>"Nell’accezione generale, i beni sono prodotti o risorse che possono essere direttamente indirizzati al soddisfacimento di bisogni, oppure venire utilizzati per produrre altri beni. In quanto risorse o prodotti tangibili, i beni si distinguono dai servizi, che sono invece prestazioni erogate nel tempo."</para>
    /// labels<para>"Property"</para><para>"Bene"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/Property">https://w3id.org/dba/ontology/Property</seealso>
    let Property = Prefixed_Name(dba, "Property") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/Report</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"La relazione è un testo che riferisce in modo dettagliato e oggettivo su un'attività, uno studio o una analisi, oppure espone un argomento su cui si è raccolta un'apposita documentazione."</para>
    ///   <para>"A report is a text which reports in detailed and objective manner on an activity, a study or an analysis, or illustrates a topic on which appropriate documentation has been collected."</para>
    /// labels<para>"Report"</para><para>"Relazione"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/Report">https://w3id.org/dba/ontology/Report</seealso>
    let Report = Prefixed_Name(dba, "Report") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/ReportDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Documento riepilogativo o di prospetto"</para>
    ///   <para>"Summary or prospectus document"</para>
    /// labels<para>"Report document"</para><para>"Report"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/ReportDocument">https://w3id.org/dba/ontology/ReportDocument</seealso>
    let ReportDocument = Prefixed_Name(dba, "ReportDocument") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/Resolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Decision of a board and the resulting provision. Term used to indicate the decision taken by a board (e.g. shareholders’ meeting). It expresses the will of the entity. Usually the resolution is documented in a set of minutes, that is, in a public document."</para>
    ///   <para>"Decisione di un organo collegiale e provvedimento che ne scaturisce. Termine con cui si indica la decisione presa da un organo collegiale (es. assemblea). Esprime la volontà dell'ente. Solitamente la delibera è documentata in un verbale, cioè in un atto pubblico."</para>
    /// labels<para>"Delibera"</para><para>"Resolution"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/Resolution">https://w3id.org/dba/ontology/Resolution</seealso>
    let Resolution = Prefixed_Name(dba, "Resolution") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/Restitution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The personal act of restitution is intended to obtain the fulfilment of the obligation to retransfer something that has previously been voluntarily transmitted by the plaintiff to the defendant, by virtue of transactions such as lease, loan, deposit and so on, which do not necessarily require the title of ownership. The restitution aims to obtain the retransfer of an asset previously voluntarily transmitted by the plaintiff to the defendant. The holder of right in rem on an asset (whether movable or immovable) can thus request the restitution of the asset from anyone who has appropriated the asset (exercising mere possession) or from anyone who owns the asset (exercising possession on account of others)."</para>
    ///   <para>"L’azione personale di restituzione è destinata a ottenere l’adempimento dell’obbligazione di ritrasferire una cosa che è stata in precedenza volontariamente trasmessa dall’attore al convenuto, in forza di negozi quali la locazione, il comodato, il deposito e così via, che non presuppongono necessariamente nel tradens la qualità di proprietario, La restituzione mira ad ottenere il ritrasferimento di un bene in precedenza volontariamente trasmesso dall’attore al convenuto. l titolare di un diritto reale su un bene (mobile o immobile) può infatti chiedere la restituzione del bene da parte di chiunque si sia appropriato del bene (esercitando il mero possesso) o da chiunque detiene il bene (esercitando la detenzione per conto altrui)."</para>
    /// labels<para>"Restitution"</para><para>"Restituzione"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/Restitution">https://w3id.org/dba/ontology/Restitution</seealso>
    let Restitution = Prefixed_Name(dba, "Restitution") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/Seizure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In legal jargon, a precautionary measure, which gives rise to a restriction of unavailability on the affected movable or immovable property, in order to ensure a certain factual or legal situation. Provision aimed at removing the free availability of movable and immovable property, of companies and the like, from their holders."</para>
    ///   <para>"Nel linguaggio giuridico, misura cautelare, che fa sorgere un vincolo di indisponibilità sui beni colpiti, mobili o immobili, tendente ad assicurare una certa situazione di fatto o di diritto. Provvedimento diretto a sottrarre la libera disponibilità di beni mobili e immobili, di aziende e simili, ai loro detentori."</para>
    /// labels<para>"Seizure"</para><para>"Sequestro"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/Seizure">https://w3id.org/dba/ontology/Seizure</seealso>
    let Seizure = Prefixed_Name(dba, "Seizure") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/SeizureEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Esecuzione del sequestro"</para>
    ///   <para>"Execution of the seizure"</para>
    /// labels<para>"Seizure"</para><para>"Sequestro"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/SeizureEvent">https://w3id.org/dba/ontology/SeizureEvent</seealso>
    let SeizureEvent = Prefixed_Name(dba, "SeizureEvent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/Sponsorships</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sponsorship contract is defined as the contract by which a party - called the “sponsor” - undertakes to pay a fee in favour of another party - called the “sponsee” - which, in turn, undertakes to disclose the sponsor’s name or brand in the course of its activities, with the aim of obtaining a positive return in terms of notoriety and image, thereby benefiting from the promotional potential of the event itself.
    /// The sponsorship identifies the relationship between a company, or a brand, and a cultural, sporting, musical or ethical initiative, which is financed in whole or in part thanks to an economic agreement of variable duration."</para>
    ///   <para>"Si definisce contratto di sponsorizzazione (o sponsorship) quel contratto con il quale una parte – detta “sponsor” – si obbliga a versare un corrispettivo a favore di un’altra parte – detta “sponsee” o “sponsorizzato” – la quale, a sua volta, si obbliga a divulgare il nome o il marchio dello sponsor nel corso delle proprie attività, nell’intento di ottenere un ritorno positivo in termini di notorietà e immagine, beneficiando delle potenzialità comunicazionali dell’evento stesso.
    /// La sponsorizzazione identifica il rapporto tra un’azienda, o un brand, e un’iniziativa culturale, sportiva, musicale, etica, che viene finanziata in tutto o in parte grazie a un accordo economico di durata variabile."</para>
    /// labels<para>"Sponsorships"</para><para>"Sponsorizzazioni"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/Sponsorships">https://w3id.org/dba/ontology/Sponsorships</seealso>
    let Sponsorships = Prefixed_Name(dba, "Sponsorships") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/Subsidy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Aiuto finanziario concesso a persone, imprese, comunità e istituzioni varie. In generale è complementare e integrativo, e finalizzato alla realizzazione di determinate attività e obiettivi."</para>
    ///   <para>"Financial aid granted to individuals, businesses, communities and miscellaneous institutions. In general, it is complementary and supplementary, and aimed at achieving certain activities and objectives."</para>
    /// labels<para>"Subsidy"</para><para>"Sussidio"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/Subsidy">https://w3id.org/dba/ontology/Subsidy</seealso>
    let Subsidy = Prefixed_Name(dba, "Subsidy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/amount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"importo"</para><para>"amount"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/amount">https://w3id.org/dba/ontology/amount</seealso>
    let amount = Prefixed_Name(dba, "amount") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/appliesFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Proprietà che descrive la relazione tra un agent e un servizio bancario"</para>
    ///   <para>"Property that describes the relationship between an agent and a bank service"</para>
    /// labels<para>"presenta domanda di"</para><para>"applies for"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/appliesFor">https://w3id.org/dba/ontology/appliesFor</seealso>
    let appliesFor = Prefixed_Name(dba, "appliesFor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/approvedAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"importo deliberato"</para><para>"approved amount"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/approvedAmount">https://w3id.org/dba/ontology/approvedAmount</seealso>
    let approvedAmount = Prefixed_Name(dba, "approvedAmount") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/approvedDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"durata deliberata"</para><para>"approval duration"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/approvedDuration">https://w3id.org/dba/ontology/approvedDuration</seealso>
    let approvedDuration = Prefixed_Name(dba, "approvedDuration") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/approves</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Proprietà inversa di "approvato da""</para>
    ///   <para>"Inverse property of "approved by""</para>
    /// labels<para>"approves"</para><para>"approva"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/approves">https://w3id.org/dba/ontology/approves</seealso>
    let approves = Prefixed_Name(dba, "approves") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/consistsOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Proprietà che descrive la relazione tra una pratica bancaria e gli eventi in cui si articola"</para>
    ///   <para>"Property that describes the relationship between a banking file and the events in which it is divided"</para>
    /// labels<para>"consists of"</para><para>"si compone di"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/consistsOf">https://w3id.org/dba/ontology/consistsOf</seealso>
    let consistsOf = Prefixed_Name(dba, "consistsOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/currency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"valuta"</para><para>"currency"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/currency">https://w3id.org/dba/ontology/currency</seealso>
    let currency = Prefixed_Name(dba, "currency") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"durata"</para><para>"duration"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/duration">https://w3id.org/dba/ontology/duration</seealso>
    let duration = Prefixed_Name(dba, "duration") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/endDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"end date"</para><para>"data di fine"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/endDate">https://w3id.org/dba/ontology/endDate</seealso>
    let endDate = Prefixed_Name(dba, "endDate") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/fileNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"numero di pratica"</para><para>"file number"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/fileNumber">https://w3id.org/dba/ontology/fileNumber</seealso>
    let fileNumber = Prefixed_Name(dba, "fileNumber") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/hasFollowingEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An event that starts at some time after this event."</para>
    ///   <para>"Proprietà che desccrive la relazione tra una successione di eventi"</para>
    /// labels<para>"following event"</para><para>"evento successivo"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/hasFollowingEvent">https://w3id.org/dba/ontology/hasFollowingEvent</seealso>
    let hasFollowingEvent = Prefixed_Name(dba, "hasFollowingEvent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/hasSubEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà fornisce un modo per suddividere un evento complesso in eventi più semplici. Descrive la relazione tra più eventi"</para>
    ///   <para>"This property provides a way to split a complex event into simpler ones. It decribes the relationship between more events"</para>
    /// labels<para>"sotto evento"</para><para>"subevent"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/hasSubEvent">https://w3id.org/dba/ontology/hasSubEvent</seealso>
    let hasSubEvent = Prefixed_Name(dba, "hasSubEvent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/hasSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse property of "is subject of""</para>
    ///   <para>"Proprietà inversa di "is subject of""</para>
    /// labels<para>"has subject"</para><para>"ha soggetto"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/hasSubject">https://w3id.org/dba/ontology/hasSubject</seealso>
    let hasSubject = Prefixed_Name(dba, "hasSubject") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/includes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Proprietà che descrive la relazione tra un documento e una garanzia"</para>
    ///   <para>"Property that describes the relationship between a document and a guarantee"</para>
    /// labels<para>"Include o richiede"</para><para>"Includes"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/includes">https://w3id.org/dba/ontology/includes</seealso>
    let includes = Prefixed_Name(dba, "includes") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/interestRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"interest rate"</para><para>"tasso"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/interestRate">https://w3id.org/dba/ontology/interestRate</seealso>
    let interestRate = Prefixed_Name(dba, "interestRate") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/involves</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property that describes the relationship between an event and a property"</para>
    ///   <para>"Proprietà che descrive la relazione tra un evento e un bene"</para>
    /// labels<para>"involves"</para><para>"coinvolge"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/involves">https://w3id.org/dba/ontology/involves</seealso>
    let involves = Prefixed_Name(dba, "involves") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/isApprovedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property used to describe the relationship between an approval and the person who authorizes it"</para>
    ///   <para>"Proprietà utilizzata per descrivere la relazione tra una delibera e il soggetto che la autorizza"</para>
    /// labels<para>"approvato da"</para><para>"is approved by"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/isApprovedBy">https://w3id.org/dba/ontology/isApprovedBy</seealso>
    let isApprovedBy = Prefixed_Name(dba, "isApprovedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/isBasedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Proprietà che descrive la relazione tra un evento e una garanzia che può essere richiesta durante l'evento"</para>
    ///   <para>"Property that describes the relationship between an event and a guarantee that can be requested during the event"</para>
    /// labels<para>"si basa su"</para><para>"based on"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/isBasedOn">https://w3id.org/dba/ontology/isBasedOn</seealso>
    let isBasedOn = Prefixed_Name(dba, "isBasedOn") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/isDocumentedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Proprietà che descrive la relazione tra una pratica bancaria o un evento e una risorsa archivistica"</para>
    ///   <para>"Property that describes the relationship between a banking file or event and an archival instance"</para>
    /// labels<para>"documented by"</para><para>"documentato da"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/isDocumentedBy">https://w3id.org/dba/ontology/isDocumentedBy</seealso>
    let isDocumentedBy = Prefixed_Name(dba, "isDocumentedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/isGuaranteedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property that describes the relationship between a guarantee and an agent"</para>
    ///   <para>"Proprietà che descrive la relazione tra una garanzia e un agent"</para>
    /// labels<para>"is guaranteed by"</para><para>"è garantito da"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/isGuaranteedBy">https://w3id.org/dba/ontology/isGuaranteedBy</seealso>
    let isGuaranteedBy = Prefixed_Name(dba, "isGuaranteedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/isInvolvedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Proprietà inversa di involves"</para>
    ///   <para>"Inverse property of involves"</para>
    /// labels<para>"coinvolto in"</para><para>"involved in"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/isInvolvedIn">https://w3id.org/dba/ontology/isInvolvedIn</seealso>
    let isInvolvedIn = Prefixed_Name(dba, "isInvolvedIn") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/isPreparedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Proprietà che descrive la relazione tra un documento e l'agent che lo ha redatto"</para>
    ///   <para>"Property that describes the relationship between a document and the agent who wrote it"</para>
    /// labels<para>"prepared by"</para><para>"preparato da"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/isPreparedBy">https://w3id.org/dba/ontology/isPreparedBy</seealso>
    let isPreparedBy = Prefixed_Name(dba, "isPreparedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/isSubjectOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Proprietà che descrive la relazione tra un servizio bancario o un bene e una pratica bancaria"</para>
    ///   <para>"Property that describes the relationship between a banking service, suche as loan, receivables mortgage creditline, or a property and a banking file"</para>
    /// labels<para>"soggetto di"</para><para>"subjectOf"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/isSubjectOf">https://w3id.org/dba/ontology/isSubjectOf</seealso>
    let isSubjectOf = Prefixed_Name(dba, "isSubjectOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/isSubjectTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property that describes the relationship between a property and the guarantee to which it is subject"</para>
    ///   <para>"Proprietà che descrive la relazione tra un bene e la garanzia a cui è soggetto"</para>
    /// labels<para>"is subject to"</para><para>"è soggetto a"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/isSubjectTo">https://w3id.org/dba/ontology/isSubjectTo</seealso>
    let isSubjectTo = Prefixed_Name(dba, "isSubjectTo") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/localIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"identificativo locale"</para><para>"local identifier"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/localIdentifier">https://w3id.org/dba/ontology/localIdentifier</seealso>
    let localIdentifier = Prefixed_Name(dba, "localIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/mentions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property used to describe the relationship between a document and the agent mentioned in it"</para>
    ///   <para>"Proprietà utilizzata per descrivere la relazione tra un documento e il soggetto citato in esso"</para>
    /// labels<para>"cita"</para><para>"mentions"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/mentions">https://w3id.org/dba/ontology/mentions</seealso>
    let mentions = Prefixed_Name(dba, "mentions") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/note</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dba/ontology/note">https://w3id.org/dba/ontology/note</seealso>
    let note = Prefixed_Name(dba, "note") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/outcome</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"esito"</para><para>"outcome"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/outcome">https://w3id.org/dba/ontology/outcome</seealso>
    let outcome = Prefixed_Name(dba, "outcome") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/prepares</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property that describes the relationship between a bank and a banking file"</para>
    ///   <para>"Proprietà che descrive la relazione tra una banca e una pratica bancaria"</para>
    /// labels<para>"prepares"</para><para>"istruisce"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/prepares">https://w3id.org/dba/ontology/prepares</seealso>
    let prepares = Prefixed_Name(dba, "prepares") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/purpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"purpose"</para><para>"scopo"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/purpose">https://w3id.org/dba/ontology/purpose</seealso>
    let purpose = Prefixed_Name(dba, "purpose") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/regards</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property that describes the relationship between a document and an agent"</para>
    ///   <para>"Proprietà che descrive la relazione tra un documento e un agent"</para>
    /// labels<para>"riguarda"</para><para>"regards"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/regards">https://w3id.org/dba/ontology/regards</seealso>
    let regards = Prefixed_Name(dba, "regards") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/requiredAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"required amount"</para><para>"importo richiesto"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/requiredAmount">https://w3id.org/dba/ontology/requiredAmount</seealso>
    let requiredAmount = Prefixed_Name(dba, "requiredAmount") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/requiredDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dba/ontology/requiredDuration">https://w3id.org/dba/ontology/requiredDuration</seealso>
    let requiredDuration = Prefixed_Name(dba, "requiredDuration") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/restitutionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"data di restituzione"</para><para>"restitution date"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/restitutionDate">https://w3id.org/dba/ontology/restitutionDate</seealso>
    let restitutionDate = Prefixed_Name(dba, "restitutionDate") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/seizureDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"data di sequestro"</para><para>"seizure date"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/seizureDate">https://w3id.org/dba/ontology/seizureDate</seealso>
    let seizureDate = Prefixed_Name(dba, "seizureDate") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/specifications</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"specifications"</para><para>"specifiche"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/specifications">https://w3id.org/dba/ontology/specifications</seealso>
    let specifications = Prefixed_Name(dba, "specifications") |> PrefixedName
    /// <summary>
    ///   <para>w3id:dba/ontology/startDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"data di inizio"</para><para>"start date"</para></remarks>
    /// <seealso href="https://w3id.org/dba/ontology/startDate">https://w3id.org/dba/ontology/startDate</seealso>
    let startDate = Prefixed_Name(dba, "startDate") |> PrefixedName
