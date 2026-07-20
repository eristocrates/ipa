namespace https.purl.org.cm.onto.apco.hash

open DoxAletheia

module apco =
    let _namespace_name = "https://purl.org/cm/onto/apco#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The publication class designates all the documents that are published in the public procurement journal
    /// <see href="https://purl.org/cm/onto/apco#Publication"></see></summary>
    let Publication = _prefix "Publication"
    /// <summary>
    /// Natural person who made a bid to the contracting authority
    /// <see href="https://purl.org/cm/onto/apco#Soumissionnaire"></see></summary>
    let Soumissionnaire = _prefix "Soumissionnaire"
    /// <summary>
    /// Natural person skilled in leading the contracting process and signing the related contracts
    /// <see href="https://purl.org/cm/onto/apco#AutoriteContractante"></see></summary>
    let AutoriteContractante = _prefix "AutoriteContractante"
    /// <summary>
    ///   <see href="https://purl.org/cm/onto/apco#AppelAManifestationDInteret"></see>
    /// </summary>
    let AppelAManifestationDInteret = _prefix "AppelAManifestationDInteret"
    /// <summary>
    /// written contract by which a contractor, a supplier or a service provider undertakes towards the state, a decentralized territorial community or a public establishment either to carry out work, or to provide goods and services for a price
    /// <see href="https://purl.org/cm/onto/apco#AppelDOffre"></see></summary>
    let AppelDOffre = _prefix "AppelDOffre"
    /// <summary>
    ///   <see href="https://purl.org/cm/onto/apco#AppelDOffreAvecConcours"></see>
    /// </summary>
    let AppelDOffreAvecConcours = _prefix "AppelDOffreAvecConcours"
    /// <summary>
    ///   <see href="https://purl.org/cm/onto/apco#AppelDOffreEnDeuxEtapes"></see>
    /// </summary>
    let AppelDOffreEnDeuxEtapes = _prefix "AppelDOffreEnDeuxEtapes"
    /// <summary>
    /// The international competitive bidding procedure is recommended for the award of contracts for Services and Intellectual Benefits of an amount greater than one hundred (100) million CFA francs or when there is no competence at the local level for the performance of the services covered by the call for tenders.
    /// <see href="https://purl.org/cm/onto/apco#AppelDOffreInternationalOuvert"></see></summary>
    let AppelDOffreInternationalOuvert = _prefix "AppelDOffreInternationalOuvert"
    /// <summary>
    ///   <see href="https://purl.org/cm/onto/apco#AppelDOffreOuvert"></see>
    /// </summary>
    let AppelDOffreOuvert = _prefix "AppelDOffreOuvert"
    /// <summary>
    /// The international competitive bidding procedure is recommended for the award of contracts for Services and Intellectual Benefits of an amount greater than one hundred (100) million CFA francs or when there is no competence at the local level for the performance of the services covered by the call for tenders.
    /// <see href="https://purl.org/cm/onto/apco#AppelDOffreInternationalRestreint"></see></summary>
    let AppelDOffreInternationalRestreint = _prefix "AppelDOffreInternationalRestreint"
    /// <summary>
    /// Restricted call for tenders is now addressed to all candidates selected following a pre-qualification procedure and no longer to a limited number of candidates among those pre-qualified.
    ///
    /// The pre-qualification report, drawn up by the Contracting Authority or the Contracting Authority's Representative and accompanied by the draft tender dossier with the proposal for shortlists, is submitted to the competent procurement commission for examination.
    ///
    /// The restricted tendering procedure may only be used in the following cases: (1) specific works or equipment of great importance or complexity; (2) specialized supplies and services; (3) intellectual services.
    /// <see href="https://purl.org/cm/onto/apco#AppelDOffreRestreint"></see></summary>
    let AppelDOffreRestreint = _prefix "AppelDOffreRestreint"
    /// <summary>
    /// The National Competitive Bidding (NCB) procedure is recommended for awarding public contracts for works or supplies which, due to their nature or scale, are unlikely to interest foreign candidates because : (1) the amounts involved are low; (2) the work is dispersed or spread over time; (3) the works require a high labor intensity; (4) the goods or works can be supplied locally at prices lower than those on the international market.
    /// <see href="https://purl.org/cm/onto/apco#AppelDOffreNationalOuvert"></see></summary>
    let AppelDOffreNationalOuvert = _prefix "AppelDOffreNationalOuvert"
    /// <summary>
    /// Natural person under public law accredited by the Project Owner or the Delegated Project Owner for general assistance of an administrative, financial and technical nature at the stage of definition, development, execution and acceptance of the services, market objects.
    /// <see href="https://purl.org/cm/onto/apco#ChefDeServiceDuMarche"></see></summary>
    let ChefDeServiceDuMarche = _prefix "ChefDeServiceDuMarche"
    /// <summary>
    /// Procedure for canceling a tender
    /// <see href="https://purl.org/cm/onto/apco#DecisionDAnnulation"></see></summary>
    let DecisionDAnnulation = _prefix "DecisionDAnnulation"
    /// <summary>
    /// Procedure for awarding a call for tenders
    /// <see href="https://purl.org/cm/onto/apco#DecisionDAttribution"></see></summary>
    let DecisionDAttribution = _prefix "DecisionDAttribution"
    /// <summary>
    /// simplified procedure for consulting companies for the awarding of certain job orders relating to the supply of goods and services or to any other smaller-scale services that do not require the preparation of technical offers
    /// <see href="https://purl.org/cm/onto/apco#DemandeDeCotation"></see></summary>
    let DemandeDeCotation = _prefix "DemandeDeCotation"
    /// <summary>
    /// Class designating the body responsible for financing a public contract
    /// <see href="https://purl.org/cm/onto/apco#Financement"></see></summary>
    let Financement = _prefix "Financement"
    /// <summary>
    /// Property indicating the source of funding for a public contract
    /// <see href="https://purl.org/cm/onto/apco#estFinancePar"></see></summary>
    let estFinancePar = _prefix "estFinancePar"
    /// <summary>
    /// Natural or legal person governed by public law accredited by the Project Owner or the Delegated Project Owner, for the monitoring and technical and financial control of the performance of the contract.
    /// <see href="https://purl.org/cm/onto/apco#IngenieurDuMarche"></see></summary>
    let IngenieurDuMarche = _prefix "IngenieurDuMarche"
    /// <summary>
    /// A natural or legal person governed by public or private law, charged by the contracting authority or the delegated contracting authority to guarantee its interests at the stage of definition, development, management of the execution and acceptance of the provision of market objects.
    /// <see href="https://purl.org/cm/onto/apco#MaitreDOeuvre"></see></summary>
    let MaitreDOeuvre = _prefix "MaitreDOeuvre"
    /// <summary>
    ///   <see href="https://purl.org/cm/onto/apco#MaitreDOuvrage"></see>
    /// </summary>
    let MaitreDOuvrage = _prefix "MaitreDOuvrage"
    /// <summary>
    /// set of administrative, technical and financial documents constituting the tenderer's proposal
    /// <see href="https://purl.org/cm/onto/apco#Offre"></see></summary>
    let Offre = _prefix "Offre"
    /// <summary>
    /// Property indicating that a tender is awarded to a provider
    /// <see href="https://purl.org/cm/onto/apco#Prestataire"></see></summary>
    let Prestataire = _prefix "Prestataire"
    /// <summary>
    /// Property indicating the offer made by a bidder. (cardinality 0..1)
    /// <see href="https://purl.org/cm/onto/apco#faitUneOffre"></see></summary>
    let faitUneOffre = _prefix "faitUneOffre"
    /// <summary>
    /// Property indicating the building owner of a public contract
    /// <see href="https://purl.org/cm/onto/apco#aPourMaitreDOuvrage"></see></summary>
    let aPourMaitreDOuvrage = _prefix "aPourMaitreDOuvrage"
    /// <summary>
    /// The National Competitive Bidding (NCB) procedure is recommended for awarding public contracts for works or supplies which, due to their nature or scale, are unlikely to interest foreign candidates because : (1) the amounts involved are low; (2) the work is dispersed or spread over time; (3) the works require a high labor intensity; (4) the goods or works can be supplied locally at prices lower than those on the international market.
    /// <see href="https://purl.org/cm/onto/apco#appelDoffre_national_restreint"></see></summary>
    let appelDoffre_national_restreint = _prefix "appelDoffre_national_restreint"
    /// <summary>
    /// Property indicating that a building owner awards a tender
    /// <see href="https://purl.org/cm/onto/apco#attribue"></see></summary>
    let attribue = _prefix "attribue"
    /// <summary>
    ///   <see href="https://purl.org/cm/onto/apco#attribueA"></see>
    /// </summary>
    let attribueA = _prefix "attribueA"
    /// <summary>
    ///   <see href="https://purl.org/cm/onto/apco#restataire"></see>
    /// </summary>
    let restataire = _prefix "restataire"
    /// <summary>
    /// property indicating the head of the market department of a public market
    /// <see href="https://purl.org/cm/onto/apco#chefDeServiceDuMarche"></see></summary>
    let chefDeServiceDuMarche = _prefix "chefDeServiceDuMarche"
    /// <summary>
    ///   <see href="https://purl.org/cm/onto/apco#dateDeCloture"></see>
    /// </summary>
    let dateDeCloture = _prefix "dateDeCloture"
    /// <summary>
    /// property indicating the publication date of a Publication
    /// <see href="https://purl.org/cm/onto/apco#dateDePublication"></see></summary>
    let dateDePublication = _prefix "dateDePublication"
    /// <summary>
    /// Property indicating the the date of signing of a publication
    /// <see href="https://purl.org/cm/onto/apco#dateDeSignature"></see></summary>
    let dateDeSignature = _prefix "dateDeSignature"
    /// <summary>
    ///   <see href="https://purl.org/cm/onto/apco#designationAutoriteContractante"></see>
    /// </summary>
    let designationAutoriteContractante = _prefix "designationAutoriteContractante"
    /// <summary>
    ///   <see href="https://purl.org/cm/onto/apco#designationMaitreDOuvrage"></see>
    /// </summary>
    let designationMaitreDOuvrage = _prefix "designationMaitreDOuvrage"
    /// <summary>
    /// Property indicating the closing time of a publication
    /// <see href="https://purl.org/cm/onto/apco#heureDeCloture"></see></summary>
    let heureDeCloture = _prefix "heureDeCloture"
    /// <summary>
    ///   <see href="https://purl.org/cm/onto/apco#idPublication"></see>
    /// </summary>
    let idPublication = _prefix "idPublication"
    /// <summary>
    ///   <see href="https://purl.org/cm/onto/apco#montantPrevisionnelduMarche"></see>
    /// </summary>
    let montantPrevisionnelduMarche = _prefix "montantPrevisionnelduMarche"
    /// <summary>
    ///   <see href="https://purl.org/cm/onto/apco#naturePrestation"></see>
    /// </summary>
    let naturePrestation = _prefix "naturePrestation"
    /// <summary>
    ///   <see href="https://purl.org/cm/onto/apco#secteurDActivite"></see>
    /// </summary>
    let secteurDActivite = _prefix "secteurDActivite"
    /// <summary>
    ///   <see href="https://purl.org/cm/onto/apco#sigleAutoriteContractante"></see>
    /// </summary>
    let sigleAutoriteContractante = _prefix "sigleAutoriteContractante"
    /// <summary>
    ///   <see href="https://purl.org/cm/onto/apco#sigleMaitreDOuvrage"></see>
    /// </summary>
    let sigleMaitreDOuvrage = _prefix "sigleMaitreDOuvrage"
    /// <summary>
    ///   <see href="https://purl.org/cm/onto/apco#sigleProcedure"></see>
    /// </summary>
    let sigleProcedure = _prefix "sigleProcedure"
    /// <summary>
    ///   <see href="https://purl.org/cm/onto/apco#sourceDeFinancement"></see>
    /// </summary>
    let sourceDeFinancement = _prefix "sourceDeFinancement"
