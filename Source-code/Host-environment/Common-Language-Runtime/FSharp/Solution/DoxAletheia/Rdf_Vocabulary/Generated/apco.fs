namespace https.purl.org.cm.onto.apco.hash

open DoxAletheia.Rdf_Vocabulary

module apco =
    let _namespace_name = "https://purl.org/cm/onto/apco#"

    /// <summary>
    /// The publication class designates all the documents that are published in the public procurement journal
    /// <see href="https://purl.org/cm/onto/apco#Publication"></see></summary>
    let Publication =
        Namespaced_IRI.parse _namespace_name "Publication" |> NamespacedName

    /// <summary>
    /// Natural person who made a bid to the contracting authority
    /// <see href="https://purl.org/cm/onto/apco#Soumissionnaire"></see></summary>
    let Soumissionnaire =
        Namespaced_IRI.parse _namespace_name "Soumissionnaire" |> NamespacedName

    /// <summary>
    /// Natural person skilled in leading the contracting process and signing the related contracts
    /// <see href="https://purl.org/cm/onto/apco#AutoriteContractante"></see></summary>
    let AutoriteContractante =
        Namespaced_IRI.parse _namespace_name "AutoriteContractante" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cm/onto/apco#AppelAManifestationDInteret"></see>
    /// </summary>
    let AppelAManifestationDInteret =
        Namespaced_IRI.parse _namespace_name "AppelAManifestationDInteret" |> NamespacedName

    /// <summary>
    /// written contract by which a contractor, a supplier or a service provider undertakes towards the state, a decentralized territorial community or a public establishment either to carry out work, or to provide goods and services for a price
    /// <see href="https://purl.org/cm/onto/apco#AppelDOffre"></see></summary>
    let AppelDOffre =
        Namespaced_IRI.parse _namespace_name "AppelDOffre" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cm/onto/apco#AppelDOffreAvecConcours"></see>
    /// </summary>
    let AppelDOffreAvecConcours =
        Namespaced_IRI.parse _namespace_name "AppelDOffreAvecConcours" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cm/onto/apco#AppelDOffreEnDeuxEtapes"></see>
    /// </summary>
    let AppelDOffreEnDeuxEtapes =
        Namespaced_IRI.parse _namespace_name "AppelDOffreEnDeuxEtapes" |> NamespacedName

    /// <summary>
    /// The international competitive bidding procedure is recommended for the award of contracts for Services and Intellectual Benefits of an amount greater than one hundred (100) million CFA francs or when there is no competence at the local level for the performance of the services covered by the call for tenders.
    /// <see href="https://purl.org/cm/onto/apco#AppelDOffreInternationalOuvert"></see></summary>
    let AppelDOffreInternationalOuvert =
        Namespaced_IRI.parse _namespace_name "AppelDOffreInternationalOuvert" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cm/onto/apco#AppelDOffreOuvert"></see>
    /// </summary>
    let AppelDOffreOuvert =
        Namespaced_IRI.parse _namespace_name "AppelDOffreOuvert" |> NamespacedName

    /// <summary>
    /// The international competitive bidding procedure is recommended for the award of contracts for Services and Intellectual Benefits of an amount greater than one hundred (100) million CFA francs or when there is no competence at the local level for the performance of the services covered by the call for tenders.
    /// <see href="https://purl.org/cm/onto/apco#AppelDOffreInternationalRestreint"></see></summary>
    let AppelDOffreInternationalRestreint =
        Namespaced_IRI.parse _namespace_name "AppelDOffreInternationalRestreint" |> NamespacedName

    /// <summary>
    /// Restricted call for tenders is now addressed to all candidates selected following a pre-qualification procedure and no longer to a limited number of candidates among those pre-qualified.
    ///
    /// The pre-qualification report, drawn up by the Contracting Authority or the Contracting Authority's Representative and accompanied by the draft tender dossier with the proposal for shortlists, is submitted to the competent procurement commission for examination.
    ///
    /// The restricted tendering procedure may only be used in the following cases: (1) specific works or equipment of great importance or complexity; (2) specialized supplies and services; (3) intellectual services.
    /// <see href="https://purl.org/cm/onto/apco#AppelDOffreRestreint"></see></summary>
    let AppelDOffreRestreint =
        Namespaced_IRI.parse _namespace_name "AppelDOffreRestreint" |> NamespacedName

    /// <summary>
    /// The National Competitive Bidding (NCB) procedure is recommended for awarding public contracts for works or supplies which, due to their nature or scale, are unlikely to interest foreign candidates because : (1) the amounts involved are low; (2) the work is dispersed or spread over time; (3) the works require a high labor intensity; (4) the goods or works can be supplied locally at prices lower than those on the international market.
    /// <see href="https://purl.org/cm/onto/apco#AppelDOffreNationalOuvert"></see></summary>
    let AppelDOffreNationalOuvert =
        Namespaced_IRI.parse _namespace_name "AppelDOffreNationalOuvert" |> NamespacedName

    /// <summary>
    /// Natural person under public law accredited by the Project Owner or the Delegated Project Owner for general assistance of an administrative, financial and technical nature at the stage of definition, development, execution and acceptance of the services, market objects.
    /// <see href="https://purl.org/cm/onto/apco#ChefDeServiceDuMarche"></see></summary>
    let ChefDeServiceDuMarche =
        Namespaced_IRI.parse _namespace_name "ChefDeServiceDuMarche" |> NamespacedName

    /// <summary>
    /// Procedure for canceling a tender
    /// <see href="https://purl.org/cm/onto/apco#DecisionDAnnulation"></see></summary>
    let DecisionDAnnulation =
        Namespaced_IRI.parse _namespace_name "DecisionDAnnulation" |> NamespacedName

    /// <summary>
    /// Procedure for awarding a call for tenders
    /// <see href="https://purl.org/cm/onto/apco#DecisionDAttribution"></see></summary>
    let DecisionDAttribution =
        Namespaced_IRI.parse _namespace_name "DecisionDAttribution" |> NamespacedName

    /// <summary>
    /// simplified procedure for consulting companies for the awarding of certain job orders relating to the supply of goods and services or to any other smaller-scale services that do not require the preparation of technical offers
    /// <see href="https://purl.org/cm/onto/apco#DemandeDeCotation"></see></summary>
    let DemandeDeCotation =
        Namespaced_IRI.parse _namespace_name "DemandeDeCotation" |> NamespacedName

    /// <summary>
    /// Class designating the body responsible for financing a public contract
    /// <see href="https://purl.org/cm/onto/apco#Financement"></see></summary>
    let Financement =
        Namespaced_IRI.parse _namespace_name "Financement" |> NamespacedName

    /// <summary>
    /// Property indicating the source of funding for a public contract
    /// <see href="https://purl.org/cm/onto/apco#estFinancePar"></see></summary>
    let estFinancePar =
        Namespaced_IRI.parse _namespace_name "estFinancePar" |> NamespacedName

    /// <summary>
    /// Natural or legal person governed by public law accredited by the Project Owner or the Delegated Project Owner, for the monitoring and technical and financial control of the performance of the contract.
    /// <see href="https://purl.org/cm/onto/apco#IngenieurDuMarche"></see></summary>
    let IngenieurDuMarche =
        Namespaced_IRI.parse _namespace_name "IngenieurDuMarche" |> NamespacedName

    /// <summary>
    /// A natural or legal person governed by public or private law, charged by the contracting authority or the delegated contracting authority to guarantee its interests at the stage of definition, development, management of the execution and acceptance of the provision of market objects.
    /// <see href="https://purl.org/cm/onto/apco#MaitreDOeuvre"></see></summary>
    let MaitreDOeuvre =
        Namespaced_IRI.parse _namespace_name "MaitreDOeuvre" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cm/onto/apco#MaitreDOuvrage"></see>
    /// </summary>
    let MaitreDOuvrage =
        Namespaced_IRI.parse _namespace_name "MaitreDOuvrage" |> NamespacedName

    /// <summary>
    /// set of administrative, technical and financial documents constituting the tenderer's proposal
    /// <see href="https://purl.org/cm/onto/apco#Offre"></see></summary>
    let Offre = Namespaced_IRI.parse _namespace_name "Offre" |> NamespacedName

    /// <summary>
    /// Property indicating that a tender is awarded to a provider
    /// <see href="https://purl.org/cm/onto/apco#Prestataire"></see></summary>
    let Prestataire =
        Namespaced_IRI.parse _namespace_name "Prestataire" |> NamespacedName

    /// <summary>
    /// Property indicating the offer made by a bidder. (cardinality 0..1)
    /// <see href="https://purl.org/cm/onto/apco#faitUneOffre"></see></summary>
    let faitUneOffre =
        Namespaced_IRI.parse _namespace_name "faitUneOffre" |> NamespacedName

    /// <summary>
    /// Property indicating the building owner of a public contract
    /// <see href="https://purl.org/cm/onto/apco#aPourMaitreDOuvrage"></see></summary>
    let aPourMaitreDOuvrage =
        Namespaced_IRI.parse _namespace_name "aPourMaitreDOuvrage" |> NamespacedName

    /// <summary>
    /// The National Competitive Bidding (NCB) procedure is recommended for awarding public contracts for works or supplies which, due to their nature or scale, are unlikely to interest foreign candidates because : (1) the amounts involved are low; (2) the work is dispersed or spread over time; (3) the works require a high labor intensity; (4) the goods or works can be supplied locally at prices lower than those on the international market.
    /// <see href="https://purl.org/cm/onto/apco#appelDoffre_national_restreint"></see></summary>
    let appelDoffre_national_restreint =
        Namespaced_IRI.parse _namespace_name "appelDoffre_national_restreint" |> NamespacedName

    /// <summary>
    /// Property indicating that a building owner awards a tender
    /// <see href="https://purl.org/cm/onto/apco#attribue"></see></summary>
    let attribue = Namespaced_IRI.parse _namespace_name "attribue" |> NamespacedName
    /// <summary>
    ///   <see href="https://purl.org/cm/onto/apco#attribueA"></see>
    /// </summary>
    let attribueA = Namespaced_IRI.parse _namespace_name "attribueA" |> NamespacedName
    /// <summary>
    ///   <see href="https://purl.org/cm/onto/apco#restataire"></see>
    /// </summary>
    let restataire = Namespaced_IRI.parse _namespace_name "restataire" |> NamespacedName

    /// <summary>
    /// property indicating the head of the market department of a public market
    /// <see href="https://purl.org/cm/onto/apco#chefDeServiceDuMarche"></see></summary>
    let chefDeServiceDuMarche =
        Namespaced_IRI.parse _namespace_name "chefDeServiceDuMarche" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cm/onto/apco#dateDeCloture"></see>
    /// </summary>
    let dateDeCloture =
        Namespaced_IRI.parse _namespace_name "dateDeCloture" |> NamespacedName

    /// <summary>
    /// property indicating the publication date of a Publication
    /// <see href="https://purl.org/cm/onto/apco#dateDePublication"></see></summary>
    let dateDePublication =
        Namespaced_IRI.parse _namespace_name "dateDePublication" |> NamespacedName

    /// <summary>
    /// Property indicating the the date of signing of a publication
    /// <see href="https://purl.org/cm/onto/apco#dateDeSignature"></see></summary>
    let dateDeSignature =
        Namespaced_IRI.parse _namespace_name "dateDeSignature" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cm/onto/apco#designationAutoriteContractante"></see>
    /// </summary>
    let designationAutoriteContractante =
        Namespaced_IRI.parse _namespace_name "designationAutoriteContractante" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cm/onto/apco#designationMaitreDOuvrage"></see>
    /// </summary>
    let designationMaitreDOuvrage =
        Namespaced_IRI.parse _namespace_name "designationMaitreDOuvrage" |> NamespacedName

    /// <summary>
    /// Property indicating the closing time of a publication
    /// <see href="https://purl.org/cm/onto/apco#heureDeCloture"></see></summary>
    let heureDeCloture =
        Namespaced_IRI.parse _namespace_name "heureDeCloture" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cm/onto/apco#idPublication"></see>
    /// </summary>
    let idPublication =
        Namespaced_IRI.parse _namespace_name "idPublication" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cm/onto/apco#montantPrevisionnelduMarche"></see>
    /// </summary>
    let montantPrevisionnelduMarche =
        Namespaced_IRI.parse _namespace_name "montantPrevisionnelduMarche" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cm/onto/apco#naturePrestation"></see>
    /// </summary>
    let naturePrestation =
        Namespaced_IRI.parse _namespace_name "naturePrestation" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cm/onto/apco#secteurDActivite"></see>
    /// </summary>
    let secteurDActivite =
        Namespaced_IRI.parse _namespace_name "secteurDActivite" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cm/onto/apco#sigleAutoriteContractante"></see>
    /// </summary>
    let sigleAutoriteContractante =
        Namespaced_IRI.parse _namespace_name "sigleAutoriteContractante" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cm/onto/apco#sigleMaitreDOuvrage"></see>
    /// </summary>
    let sigleMaitreDOuvrage =
        Namespaced_IRI.parse _namespace_name "sigleMaitreDOuvrage" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cm/onto/apco#sigleProcedure"></see>
    /// </summary>
    let sigleProcedure =
        Namespaced_IRI.parse _namespace_name "sigleProcedure" |> NamespacedName

    /// <summary>
    ///   <see href="https://purl.org/cm/onto/apco#sourceDeFinancement"></see>
    /// </summary>
    let sourceDeFinancement =
        Namespaced_IRI.parse _namespace_name "sourceDeFinancement" |> NamespacedName
