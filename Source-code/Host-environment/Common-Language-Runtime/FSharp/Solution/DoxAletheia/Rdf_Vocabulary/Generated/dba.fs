namespace https.w3id.org.dba.ontology.slash

open DoxAletheia

module dba =
    let _namespace_name = "https://w3id.org/dba/ontology/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// document drawn up by whoever is vested with this specific function or by a public official, in order to certify and remember - in a concise but complete and exhaustive form as regards the key data - facts, proceedings and events of various kinds and the matters discussed during a meeting or a shareholders’ meeting.
    /// <see href="https://w3id.org/dba/ontology/Minutes"></see></summary>
    let Minutes = _prefix "Minutes"
    /// <summary>
    /// Decision of a board and the resulting provision. Term used to indicate the decision taken by a board (e.g. shareholders’ meeting). It expresses the will of the entity. Usually the resolution is documented in a set of minutes, that is, in a public document.
    /// <see href="https://w3id.org/dba/ontology/Resolution"></see></summary>
    let Resolution = _prefix "Resolution"
    /// <summary>
    /// Method of extinguishing the loan and closing the file
    /// <see href="https://w3id.org/dba/ontology/Outcome"></see></summary>
    let Outcome = _prefix "Outcome"
    /// <summary>
    /// Formulation of a request for a service, for example the disbursement of a mortgage or a loan, from a customer to the banking company.
    /// <see href="https://w3id.org/dba/ontology/Application"></see></summary>
    let Application = _prefix "Application"
    /// <summary>
    /// The personal act of restitution is intended to obtain the fulfilment of the obligation to retransfer something that has previously been voluntarily transmitted by the plaintiff to the defendant, by virtue of transactions such as lease, loan, deposit and so on, which do not necessarily require the title of ownership. The restitution aims to obtain the retransfer of an asset previously voluntarily transmitted by the plaintiff to the defendant. The holder of right in rem on an asset (whether movable or immovable) can thus request the restitution of the asset from anyone who has appropriated the asset (exercising mere possession) or from anyone who owns the asset (exercising possession on account of others).
    /// <see href="https://w3id.org/dba/ontology/Restitution"></see></summary>
    let Restitution = _prefix "Restitution"
    /// <summary>
    /// Execution of the confiscation
    /// <see href="https://w3id.org/dba/ontology/ConfiscationEvent"></see></summary>
    let ConfiscationEvent = _prefix "ConfiscationEvent"
    /// <summary>
    /// Minutes documenting the conclusion of a decision-making process.
    /// <see href="https://w3id.org/dba/ontology/DeedOfResolution"></see></summary>
    let DeedOfResolution = _prefix "DeedOfResolution"
    /// <summary>
    /// From a legal point of view, suitable means to ensure the fulfilment of an obligation, the exercise of a function or, in general, the observance of a legislative precept or a specific commitment. From an economic point of view, the guarantee is a transfer of risk: the lender assumes a risk that the beneficiary no longer bears, provided that the guarantee is honoured.
    /// <see href="https://w3id.org/dba/ontology/Guarantee"></see></summary>
    let Guarantee = _prefix "Guarantee"
    /// <summary>
    /// Indicates the preliminary investigation phase relating to the acquisition of information aimed at defining the possibilities and methods of intervention on the market by a company.
    /// <see href="https://w3id.org/dba/ontology/PreliminaryAssessment"></see></summary>
    let PreliminaryAssessment = _prefix "PreliminaryAssessment"
    /// <summary>
    /// A report is a text which reports in detailed and objective manner on an activity, a study or an analysis, or illustrates a topic on which appropriate documentation has been collected.
    /// <see href="https://w3id.org/dba/ontology/Report"></see></summary>
    let Report = _prefix "Report"
    /// <summary>
    /// Legal deed by which a property or a right on the goods comprising one’s own assets is transferred to other entities, through sale, donation, mortgage, etc.
    /// <see href="https://w3id.org/dba/ontology/Alienation"></see></summary>
    let Alienation = _prefix "Alienation"
    /// <summary>
    /// The contract is defined by art. 1321 of the Italian Civil Code as “the agreement of two or more parties to establish, govern or terminate a legal patrimonial relationship between them”.
    /// <see href="https://w3id.org/dba/ontology/Contract"></see></summary>
    let Contract = _prefix "Contract"
    /// <summary>
    /// Verification of the formal or substantive regularity of a document, a factual situation or a right. The audit may refer, within the scope of companies, to checks of an economic nature, of a legal nature, of an accounting nature, of a financial nature, of a technical nature, etc.
    /// <see href="https://w3id.org/dba/ontology/Audit"></see></summary>
    let Audit = _prefix "Audit"
    /// <summary>
    /// The set of deeds or documents required to start and conclude a business, and necessary to request authorisations, concessions and the suchlike. In a concrete sense, the set of papers relating to the individual, to a specific object, and the insert, the file that binds them together.
    /// <see href="https://w3id.org/dba/ontology/File"></see></summary>
    let File = _prefix "File"
    /// <summary>
    /// Execution of the seizure
    /// <see href="https://w3id.org/dba/ontology/SeizureEvent"></see></summary>
    let SeizureEvent = _prefix "SeizureEvent"
    /// <summary>
    /// The visit and the set of checks carried out by an inspector.
    /// <see href="https://w3id.org/dba/ontology/Inspection"></see></summary>
    let Inspection = _prefix "Inspection"
    /// <summary>
    /// A thing that happens or takes place; an action made by the Bank during the banking
    /// <see href="https://w3id.org/dba/ontology/Event"></see></summary>
    let Event = _prefix "Event"
    /// <summary>
    /// Company that carries out fundraising transactions and disburses non-transferable loans on the market.
    /// <see href="https://w3id.org/dba/ontology/Bank"></see></summary>
    let Bank = _prefix "Bank"
    /// <summary>
    /// The act of concluding, that is, finalising a contract, and sometimes the contract itself.
    /// <see href="https://w3id.org/dba/ontology/Conclusion"></see></summary>
    let Conclusion = _prefix "Conclusion"
    /// <summary>
    /// Confiscation consists of an ancillary penalty which is imposed following a conviction and which consists of an actual expropriation in favour of the State. It is therefore a security measure of a patrimonial nature consisting of the forced and free expropriation in favour of the State and, in an urban context, in favour of a Municipality’s assets, of all the things that comprise the price of the crime, which were used to commit the crime, those which constitute the product and the profit of such crime, as well as those which are criminal by nature. This measure can be optional or mandatory.
    /// <see href="https://w3id.org/dba/ontology/Confiscation"></see></summary>
    let Confiscation = _prefix "Confiscation"
    /// <summary>
    /// Advance of resources, in the form of the provision of goods or services or the transfer of sums of money, which an economic agent grants to another against a promise of future restitution in one or more tranches, according to the methods and times specified in the contract. A credit can arise directly from commercial relationships between two companies or between a company (an entrepreneur) and a family, or involve a financial intermediary qualified to trade in the credit sector [for example a bank].
    /// <see href="https://w3id.org/dba/ontology/Credit"></see></summary>
    let Credit = _prefix "Credit"
    /// <summary>
    /// The act of providing the necessary means for the completion of a work, for the performance of an activity, or the sum provided or obtained. In the private sector it is granted by private entities (banks and other financial institutions, large industries, etc.), or even by individual citizens with the underwriting of shares, the purchase of bonds, the granting of credit and guarantees, or with deeds of patronage (e.g. sponsorships), mostly as an aid for the completion of works or for the performance of activities of common interest. The financing of enterprises can take place through the granting of short-term credit for current activities and medium and long-term credit to provide the enterprises with the necessary capital for the initial set-up and their subsequent expansion, or through direct recourse by the same enterprises to the capital market with the issue of bonds, or shares, or even through the intermediation of financial companies.
    /// <see href="https://w3id.org/dba/ontology/Financing"></see></summary>
    let Financing = _prefix "Financing"
    /// <summary>
    /// Credit granted by a bank, in any form, to a customer who has requested it, after having ascertained the customer’s income capacity, assets and moral qualities, or, in the case of a company, those of the individuals managing it. The concept must be distinguished from that of a loan.
    /// <see href="https://w3id.org/dba/ontology/CreditLine"></see></summary>
    let CreditLine = _prefix "CreditLine"
    /// <summary>
    /// immovable property can be such by nature, by the owner’s intended use and by law. In addition to the ground, property that is fixed into the ground or rests firmly on it is immovable by nature, as are buildings and all constructions fixed into the ground, whether in masonry or otherwise, boats solidly anchored to the shore, such as the decks of boats, piers, ferries, bathing establishments. All those things that are ancillary to the main immovable property are immovable by intended use: these ancillary elements are usually called appurtenances: autonomous things that however are in a relationship of dependence upon the main thing. Appurtenances are divided into rural and urban, civil and industrial or corporate. Rights in rem over immovable property are immovable by law (e.g. rights of use, usufruct, easement...)
    /// <see href="https://w3id.org/dba/ontology/ImmovableProperty"></see></summary>
    let ImmovableProperty = _prefix "ImmovableProperty"
    /// <summary>
    /// In the general sense, goods are products or resources that can be destined directly to the satisfaction of needs, or be used to produce other goods. As tangible resources or products, goods are distinguished from services, which are performances rendered over time.
    /// <see href="https://w3id.org/dba/ontology/Property"></see></summary>
    let Property = _prefix "Property"
    /// <summary>
    /// Transfer of a quantity of existing goods against the commitment to return the same quantity (free loan) or a greater quantity (interest-bearing loan) of future goods, according to different methods. Loans can be: in kind or monetary; granted by individuals to individuals (personal loans), by banks to individuals and other banks (bank loans), by individuals and banks to the State (public or national loans), by other States or by citizens and banks of other States to a State or to entities and companies present therein (foreign or international loans). They can also be distinguished: depending on the duration, in short-, medium- and long-term loans; depending on the guarantee, in mortgage loans, pledges, personal guarantee loans, bills of exchange, fiduciary loans, overdrafts; depending on the use made by the borrower, in consumption or commercial loans.
    /// <see href="https://w3id.org/dba/ontology/Loan"></see></summary>
    let Loan = _prefix "Loan"
    /// <summary>
    /// A mortgage (articles 1813-1822 of the Italian Civil Code) is the contract with which a party (lender) delivers a certain amount of money or other fungible things to the other party (borrower), who acquires the ownership thereof and undertakes to return as many things of the same kind and quality. The mortgage is a real contract: for its completion it is therefore necessary to deliver the money or the borrowed property (in practice, the mortgage generally has as its object a sum of money).
    /// <see href="https://w3id.org/dba/ontology/Mortage"></see></summary>
    let Mortage = _prefix "Mortage"
    /// <summary>
    /// Movable property can be such by nature or by law. Things that can be transported from one place to another are movable by nature, either by extraneous force or by intrinsic property. The rights in rem on movable property are first and foremost movable by law, then all credit rights. The shares in trading companies are movable, that is, the set of rights that accrue to the shareholder for the entire duration of the company, that is, until closing of the liquidation.
    /// <see href="https://w3id.org/dba/ontology/MovableProperty"></see></summary>
    let MovableProperty = _prefix "MovableProperty"
    /// <summary>
    /// Summary or prospectus document
    /// <see href="https://w3id.org/dba/ontology/ReportDocument"></see></summary>
    let ReportDocument = _prefix "ReportDocument"
    /// <summary>
    /// In legal jargon, a precautionary measure, which gives rise to a restriction of unavailability on the affected movable or immovable property, in order to ensure a certain factual or legal situation. Provision aimed at removing the free availability of movable and immovable property, of companies and the like, from their holders.
    /// <see href="https://w3id.org/dba/ontology/Seizure"></see></summary>
    let Seizure = _prefix "Seizure"
    /// <summary>
    /// A sponsorship contract is defined as the contract by which a party - called the “sponsor” - undertakes to pay a fee in favour of another party - called the “sponsee” - which, in turn, undertakes to disclose the sponsor’s name or brand in the course of its activities, with the aim of obtaining a positive return in terms of notoriety and image, thereby benefiting from the promotional potential of the event itself.
    /// The sponsorship identifies the relationship between a company, or a brand, and a cultural, sporting, musical or ethical initiative, which is financed in whole or in part thanks to an economic agreement of variable duration.
    /// <see href="https://w3id.org/dba/ontology/Sponsorships"></see></summary>
    let Sponsorships = _prefix "Sponsorships"
    /// <summary>
    /// Financial aid granted to individuals, businesses, communities and miscellaneous institutions. In general, it is complementary and supplementary, and aimed at achieving certain activities and objectives.
    /// <see href="https://w3id.org/dba/ontology/Subsidy"></see></summary>
    let Subsidy = _prefix "Subsidy"
    /// <summary>
    ///   <see href="https://w3id.org/dba/ontology/amount"></see>
    /// </summary>
    let amount = _prefix "amount"
    /// <summary>
    /// Property that describes the relationship between an agent and a bank service
    /// <see href="https://w3id.org/dba/ontology/appliesFor"></see></summary>
    let appliesFor = _prefix "appliesFor"
    /// <summary>
    ///   <see href="https://w3id.org/dba/ontology/approvedAmount"></see>
    /// </summary>
    let approvedAmount = _prefix "approvedAmount"
    /// <summary>
    ///   <see href="https://w3id.org/dba/ontology/approvedDuration"></see>
    /// </summary>
    let approvedDuration = _prefix "approvedDuration"
    /// <summary>
    ///   <see href="https://w3id.org/dba/ontology/duration"></see>
    /// </summary>
    let duration = _prefix "duration"
    /// <summary>
    /// Inverse property of "approved by"
    /// <see href="https://w3id.org/dba/ontology/approves"></see></summary>
    let approves = _prefix "approves"
    /// <summary>
    /// Property used to describe the relationship between an approval and the person who authorizes it
    /// <see href="https://w3id.org/dba/ontology/isApprovedBy"></see></summary>
    let isApprovedBy = _prefix "isApprovedBy"
    /// <summary>
    /// Property that describes the relationship between a banking file and the events in which it is divided
    /// <see href="https://w3id.org/dba/ontology/consistsOf"></see></summary>
    let consistsOf = _prefix "consistsOf"
    /// <summary>
    ///   <see href="https://w3id.org/dba/ontology/currency"></see>
    /// </summary>
    let currency = _prefix "currency"
    /// <summary>
    ///   <see href="https://w3id.org/dba/ontology/endDate"></see>
    /// </summary>
    let endDate = _prefix "endDate"
    /// <summary>
    ///   <see href="https://w3id.org/dba/ontology/fileNumber"></see>
    /// </summary>
    let fileNumber = _prefix "fileNumber"
    /// <summary>
    /// An event that starts at some time after this event.
    /// <see href="https://w3id.org/dba/ontology/hasFollowingEvent"></see></summary>
    let hasFollowingEvent = _prefix "hasFollowingEvent"
    /// <summary>
    /// This property provides a way to split a complex event into simpler ones. It decribes the relationship between more events
    /// <see href="https://w3id.org/dba/ontology/hasSubEvent"></see></summary>
    let hasSubEvent = _prefix "hasSubEvent"
    /// <summary>
    /// Inverse property of "is subject of"
    /// <see href="https://w3id.org/dba/ontology/hasSubject"></see></summary>
    let hasSubject = _prefix "hasSubject"
    /// <summary>
    /// Property that describes the relationship between a banking service, suche as loan, receivables mortgage creditline, or a property and a banking file
    /// <see href="https://w3id.org/dba/ontology/isSubjectOf"></see></summary>
    let isSubjectOf = _prefix "isSubjectOf"
    /// <summary>
    /// Property that describes the relationship between a document and a guarantee
    /// <see href="https://w3id.org/dba/ontology/includes"></see></summary>
    let includes = _prefix "includes"
    /// <summary>
    ///   <see href="https://w3id.org/dba/ontology/interestRate"></see>
    /// </summary>
    let interestRate = _prefix "interestRate"
    /// <summary>
    /// Property that describes the relationship between an event and a property
    /// <see href="https://w3id.org/dba/ontology/involves"></see></summary>
    let involves = _prefix "involves"
    /// <summary>
    /// Inverse property of involves
    /// <see href="https://w3id.org/dba/ontology/isInvolvedIn"></see></summary>
    let isInvolvedIn = _prefix "isInvolvedIn"
    /// <summary>
    /// Property that describes the relationship between an event and a guarantee that can be requested during the event
    /// <see href="https://w3id.org/dba/ontology/isBasedOn"></see></summary>
    let isBasedOn = _prefix "isBasedOn"
    /// <summary>
    /// Property that describes the relationship between a banking file or event and an archival instance
    /// <see href="https://w3id.org/dba/ontology/isDocumentedBy"></see></summary>
    let isDocumentedBy = _prefix "isDocumentedBy"
    /// <summary>
    /// Property that describes the relationship between a guarantee and an agent
    /// <see href="https://w3id.org/dba/ontology/isGuaranteedBy"></see></summary>
    let isGuaranteedBy = _prefix "isGuaranteedBy"
    /// <summary>
    /// Property that describes the relationship between a document and the agent who wrote it
    /// <see href="https://w3id.org/dba/ontology/isPreparedBy"></see></summary>
    let isPreparedBy = _prefix "isPreparedBy"
    /// <summary>
    /// Property that describes the relationship between a bank and a banking file
    /// <see href="https://w3id.org/dba/ontology/prepares"></see></summary>
    let prepares = _prefix "prepares"
    /// <summary>
    /// Property that describes the relationship between a property and the guarantee to which it is subject
    /// <see href="https://w3id.org/dba/ontology/isSubjectTo"></see></summary>
    let isSubjectTo = _prefix "isSubjectTo"
    /// <summary>
    ///   <see href="https://w3id.org/dba/ontology/localIdentifier"></see>
    /// </summary>
    let localIdentifier = _prefix "localIdentifier"
    /// <summary>
    /// Property used to describe the relationship between a document and the agent mentioned in it
    /// <see href="https://w3id.org/dba/ontology/mentions"></see></summary>
    let mentions = _prefix "mentions"
    /// <summary>
    ///   <see href="https://w3id.org/dba/ontology/note"></see>
    /// </summary>
    let note = _prefix "note"
    /// <summary>
    ///   <see href="https://w3id.org/dba/ontology/outcome"></see>
    /// </summary>
    let outcome = _prefix "outcome"
    /// <summary>
    ///   <see href="https://w3id.org/dba/ontology/purpose"></see>
    /// </summary>
    let purpose = _prefix "purpose"
    /// <summary>
    /// Property that describes the relationship between a document and an agent
    /// <see href="https://w3id.org/dba/ontology/regards"></see></summary>
    let regards = _prefix "regards"
    /// <summary>
    ///   <see href="https://w3id.org/dba/ontology/requiredAmount"></see>
    /// </summary>
    let requiredAmount = _prefix "requiredAmount"
    /// <summary>
    ///   <see href="https://w3id.org/dba/ontology/requiredDuration"></see>
    /// </summary>
    let requiredDuration = _prefix "requiredDuration"
    /// <summary>
    ///   <see href="https://w3id.org/dba/ontology/restitutionDate"></see>
    /// </summary>
    let restitutionDate = _prefix "restitutionDate"
    /// <summary>
    ///   <see href="https://w3id.org/dba/ontology/seizureDate"></see>
    /// </summary>
    let seizureDate = _prefix "seizureDate"
    /// <summary>
    ///   <see href="https://w3id.org/dba/ontology/specifications"></see>
    /// </summary>
    let specifications = _prefix "specifications"
    /// <summary>
    ///   <see href="https://w3id.org/dba/ontology/startDate"></see>
    /// </summary>
    let startDate = _prefix "startDate"
