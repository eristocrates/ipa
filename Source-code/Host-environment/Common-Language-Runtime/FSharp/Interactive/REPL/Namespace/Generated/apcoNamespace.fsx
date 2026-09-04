#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module apco =
    let _prefixId = PrefixId.fromNamespaceLabel "https://purl.org/cm/onto/apco#" "apco"
    /// <summary>
    ///   <para>rdfs:label : Appel a manifestation d'intérêtrdfs:label : Call for expressions of interest</para>
    ///   <a href="https://purl.org/cm/onto/apco#AppelAManifestationDInteret">apco:AppelAManifestationDInteret</a>
    /// </summary>
    let AppelAManifestationDInteret = _prefixId.prefix "AppelAManifestationDInteret"
    /// <summary>
    ///   <para>rdfs:label : Appel d'offrerdfs:label : Public contractrdfs:label : Tender</para>
    ///   <para>rdfs:comment : contrat ecrit par lequel un entrepreneur, un fournisseur ou un prestataire de service s'engage envers l'etat , une collectivité territoriale décentralisée ou un établissement public soit à réaliser des travaux, soit à fournir des biens et des services moyennant un prixrdfs:comment : written contract by which a contractor, a supplier or a service provider undertakes towards the state, a decentralized territorial community or a public establishment either to carry out work, or to provide goods and services for a price</para>
    ///   <a href="https://purl.org/cm/onto/apco#AppelDOffre">apco:AppelDOffre</a>
    /// </summary>
    let AppelDOffre = _prefixId.prefix "AppelDOffre"
    /// <summary>
    ///   <para>rdfs:label : Appel d'offre avec concoursrdfs:label : Public contract with merit</para>
    ///   <a href="https://purl.org/cm/onto/apco#AppelDOffreAvecConcours">apco:AppelDOffreAvecConcours</a>
    /// </summary>
    let AppelDOffreAvecConcours = _prefixId.prefix "AppelDOffreAvecConcours"
    /// <summary>
    ///   <para>rdfs:label : Appel d'offre en deux étapesrdfs:label : Public contract with two steps</para>
    ///   <a href="https://purl.org/cm/onto/apco#AppelDOffreEnDeuxEtapes">apco:AppelDOffreEnDeuxEtapes</a>
    /// </summary>
    let AppelDOffreEnDeuxEtapes = _prefixId.prefix "AppelDOffreEnDeuxEtapes"

    /// <summary>
    ///   <para>rdfs:label : Appel d'offre international ouvertrdfs:label : Open international tender</para>
    ///   <para>rdfs:comment : La procédure d’appel d’offres international  est recommandée pour la passation des marchés de Services et Prestations Intellectuelles de montant supérieur à cent (100) millions de F CFA ou lorsqu’il n’existe pas de compétence au niveau local pour la réalisation des prestations objet de l’appel d’offres.rdfs:comment : The international competitive bidding procedure is recommended for the award of contracts for Services and Intellectual Benefits of an amount greater than one hundred (100) million CFA francs or when there is no competence at the local level for the performance of the services covered by the call for tenders.</para>
    ///   <a href="https://purl.org/cm/onto/apco#AppelDOffreInternationalOuvert">apco:AppelDOffreInternationalOuvert</a>
    /// </summary>
    let AppelDOffreInternationalOuvert =
        _prefixId.prefix "AppelDOffreInternationalOuvert"

    /// <summary>
    ///   <para>rdfs:label : Appel d'offre international restreintrdfs:label : Restricted international tender</para>
    ///   <para>rdfs:comment : La procédure d’appel d’offres international  est recommandée pour la passation des marchés de Services et Prestations Intellectuelles de montant supérieur à cent (100) millions de F CFA ou lorsqu’il n’existe pas de compétence au niveau local pour la réalisation des prestations objet de l’appel d’offres.rdfs:comment : The international competitive bidding procedure is recommended for the award of contracts for Services and Intellectual Benefits of an amount greater than one hundred (100) million CFA francs or when there is no competence at the local level for the performance of the services covered by the call for tenders.</para>
    ///   <a href="https://purl.org/cm/onto/apco#AppelDOffreInternationalRestreint">apco:AppelDOffreInternationalRestreint</a>
    /// </summary>
    let AppelDOffreInternationalRestreint =
        _prefixId.prefix "AppelDOffreInternationalRestreint"

    /// <summary>
    ///   <para>rdfs:label : Appel d'offre national ouvertrdfs:label : Open national tender</para>
    ///   <para>rdfs:comment : La procédure d’appel d’offres national (AON) est recommandée pour la passation des marchés publics de travaux ou de fournitures qui, en raison de leur nature ou de leur ampleur, ont peu de chance d’intéresser les candidats étrangers du fait que : (1) les montants en jeu sont peu élevés ; (2) les travaux sont dispersés ou étalés dans le temps ; (3) les travaux nécessitent une haute intensité de main d’œuvre ; (4)les biens ou les travaux peuvent être fournis localement à des prix inférieurs à ceux du marché international.rdfs:comment : The National Competitive Bidding (NCB) procedure is recommended for awarding public contracts for works or supplies which, due to their nature or scale, are unlikely to interest foreign candidates because : (1) the amounts involved are low; (2) the work is dispersed or spread over time; (3) the works require a high labor intensity; (4) the goods or works can be supplied locally at prices lower than those on the international market.</para>
    ///   <a href="https://purl.org/cm/onto/apco#AppelDOffreNationalOuvert">apco:AppelDOffreNationalOuvert</a>
    /// </summary>
    let AppelDOffreNationalOuvert = _prefixId.prefix "AppelDOffreNationalOuvert"
    /// <summary>
    ///   <para>rdfs:label : Appel d'offre ouvertrdfs:label : open tender</para>
    ///   <a href="https://purl.org/cm/onto/apco#AppelDOffreOuvert">apco:AppelDOffreOuvert</a>
    /// </summary>
    let AppelDOffreOuvert = _prefixId.prefix "AppelDOffreOuvert"
    /// <summary>
    ///   <para>rdfs:label : Appel d'offre restreintrdfs:label : Restricted tender</para>
    ///   <para>rdfs:comment : L’appel d’offres restreint s’adresse désormais à l’ensemble des candidats retenus à l’issue d’une procédure de pré-qualification et non plus à un nombre limité de candidats parmi ceux pré-qualifiés.
    ///
    /// Le rapport de pré-qualification, rédigé par le Maître d’Ouvrage ou le Maître d’Ouvrage Délégué et accompagné du projet de dossier d’appel d’offres avec la proposition de listes restreintes, est soumis à la commission des marchés compétente pour examen.
    ///
    /// La procédure d’appel d’offres restreint ne peut être utilisée que dans les cas suivants : (1) travaux ou équipements spécifiques de grande importance ou complexes ; (2) fournitures et services spécialisés ; (3) prestations intellectuelles.rdfs:comment : Restricted call for tenders is now addressed to all candidates selected following a pre-qualification procedure and no longer to a limited number of candidates among those pre-qualified.
    ///
    /// The pre-qualification report, drawn up by the Contracting Authority or the Contracting Authority's Representative and accompanied by the draft tender dossier with the proposal for shortlists, is submitted to the competent procurement commission for examination.
    ///
    /// The restricted tendering procedure may only be used in the following cases: (1) specific works or equipment of great importance or complexity; (2) specialized supplies and services; (3) intellectual services.</para>
    ///   <a href="https://purl.org/cm/onto/apco#AppelDOffreRestreint">apco:AppelDOffreRestreint</a>
    /// </summary>
    let AppelDOffreRestreint = _prefixId.prefix "AppelDOffreRestreint"
    /// <summary>
    ///   <para>rdfs:label : Autorité contractanterdfs:label : Contracting authority</para>
    ///   <para>rdfs:comment : Natural person skilled in leading the contracting process and signing the related contractsrdfs:comment : Personne physique ou morale habilelé à conduire le processus de contractualisation et de signer les marchés y relatifs</para>
    ///   <a href="https://purl.org/cm/onto/apco#AutoriteContractante">apco:AutoriteContractante</a>
    /// </summary>
    let AutoriteContractante = _prefixId.prefix "AutoriteContractante"
    /// <summary>
    ///   <para>rdfs:label : Chef de service du marchérdfs:label : Market service manager</para>
    ///   <para>rdfs:comment : Natural person under public law accredited by the Project Owner or the Delegated Project Owner for general assistance of an administrative, financial and technical nature at the stage of definition, development, execution and acceptance of the services, market objects.rdfs:comment : Personne physique de droit public accréditée par le Maître d'ouvrage ou le Maître d'ouvrage délégué pour une assistance générale à caractère administratif, financier et technique au stade de la définition, de l'élaboration, de l'exécution et de la réception des prestations, objets du marché.</para>
    ///   <a href="https://purl.org/cm/onto/apco#ChefDeServiceDuMarche">apco:ChefDeServiceDuMarche</a>
    /// </summary>
    let ChefDeServiceDuMarche = _prefixId.prefix "ChefDeServiceDuMarche"
    /// <summary>
    ///   <para>rdfs:label : Cancellation decisionrdfs:label : Décision d'annulation</para>
    ///   <para>rdfs:comment : Procedure for canceling a tenderrdfs:comment : Procédure d'annulation d'un appel d'offre</para>
    ///   <a href="https://purl.org/cm/onto/apco#DecisionDAnnulation">apco:DecisionDAnnulation</a>
    /// </summary>
    let DecisionDAnnulation = _prefixId.prefix "DecisionDAnnulation"
    /// <summary>
    ///   <para>rdfs:label : Award decisionrdfs:label : Décision d'attribution</para>
    ///   <para>rdfs:comment : Procedure for awarding a call for tendersrdfs:comment : Procédure d'attribution d'un appel d'offre</para>
    ///   <a href="https://purl.org/cm/onto/apco#DecisionDAttribution">apco:DecisionDAttribution</a>
    /// </summary>
    let DecisionDAttribution = _prefixId.prefix "DecisionDAttribution"
    /// <summary>
    ///   <para>rdfs:label : APriceQuoterdfs:label : DemandeDeCotation</para>
    ///   <para>rdfs:comment : Procédure simplifiée de consultation d’entreprises pour la passation de certaines lettres-commandes relatives aux fournitures de biens et services ou à toutes autres prestations de moindre envergure ne nécessitant pas l’élaboration d’offres techniques.rdfs:comment : simplified procedure for consulting companies for the awarding of certain job orders relating to the supply of goods and services or to any other smaller-scale services that do not require the preparation of technical offers</para>
    ///   <a href="https://purl.org/cm/onto/apco#DemandeDeCotation">apco:DemandeDeCotation</a>
    /// </summary>
    let DemandeDeCotation = _prefixId.prefix "DemandeDeCotation"
    /// <summary>
    ///   <para>rdfs:label : Financementrdfs:label : Funding</para>
    ///   <para>rdfs:comment : Class designating the body responsible for financing a public contractrdfs:comment : Classe désignant l'organe chargé de financer un marché public</para>
    ///   <a href="https://purl.org/cm/onto/apco#Financement">apco:Financement</a>
    /// </summary>
    let Financement = _prefixId.prefix "Financement"
    /// <summary>
    ///   <para>rdfs:label : Ingénieur du marchérdfs:label : market engineer</para>
    ///   <para>rdfs:comment : Natural or legal person governed by public law accredited by the Project Owner or the Delegated Project Owner, for the monitoring and technical and financial control of the performance of the contract.rdfs:comment : Personne physique ou morale de droit public accréditée par le Maître d'ouvrage ou le Maître d'ouvrage délégué, pour le suivi et le contrôle technique et financier de l'exécution du marché.</para>
    ///   <a href="https://purl.org/cm/onto/apco#IngenieurDuMarche">apco:IngenieurDuMarche</a>
    /// </summary>
    let IngenieurDuMarche = _prefixId.prefix "IngenieurDuMarche"
    /// <summary>
    ///   <para>rdfs:label : maître d'oeuvrerdfs:label : Project manager</para>
    ///   <para>rdfs:comment : A natural or legal person governed by public or private law, charged by the contracting authority or the delegated contracting authority to guarantee its interests at the stage of definition, development, management of the execution and acceptance of the provision of market objects.rdfs:comment : Personne physique ou morale de droit public ou privé, chargée par le maître d'ouvrage ou le maître d'ouvrage déléguéde garantir ses intérêts au stade de la définition, de l'élaboration, de la direction de l'exécution et de la reception des prestation objets du marché.</para>
    ///   <a href="https://purl.org/cm/onto/apco#MaitreDOeuvre">apco:MaitreDOeuvre</a>
    /// </summary>
    let MaitreDOeuvre = _prefixId.prefix "MaitreDOeuvre"
    /// <summary>
    ///   <para>rdfs:label : Building ownerrdfs:label : Maître d'ouvrage</para>
    ///   <para>rdfs:comment : Chef de département ministériel ou assimilé, chef de l'exécutif d'une collectivité territoriale décentralisée, et directeur général d'un établissement public, représentant l'administration bénéficiaire des prestations prévues dans le marché.</para>
    ///   <a href="https://purl.org/cm/onto/apco#MaitreDOuvrage">apco:MaitreDOuvrage</a>
    /// </summary>
    let MaitreDOuvrage = _prefixId.prefix "MaitreDOuvrage"
    /// <summary>
    ///   <para>rdfs:label : Offrerdfs:label : Tender</para>
    ///   <para>rdfs:comment : Ensemble de documents administratifs,  techniques et financiers constituant la proposition du soumissionairerdfs:comment : set of administrative, technical and financial documents constituting the tenderer's proposal</para>
    ///   <a href="https://purl.org/cm/onto/apco#Offre">apco:Offre</a>
    /// </summary>
    let Offre = _prefixId.prefix "Offre"
    /// <summary>
    ///   <para>rdfs:label : a pour prestatairerdfs:label : has providerrdfs:label : Providerrdfs:label : Prestataire</para>
    ///   <para>rdfs:comment : Property indicating that a tender is awarded to a providerrdfs:comment : Personne physique ou morale, titulaire d'un marché publicrdfs:comment : Proprieté indiquant le prestataire d'un marché public</para>
    ///   <a href="https://purl.org/cm/onto/apco#Prestataire">apco:Prestataire</a>
    /// </summary>
    let Prestataire = _prefixId.prefix "Prestataire"
    /// <summary>
    ///   <para>rdfs:label : Communiquérdfs:label : Publicationrdfs:label : Publication</para>
    ///   <para>rdfs:comment : La classe publication désigne l'ensemble des documents qui sont publié dans le journal des marchés publics.rdfs:comment : The publication class designates all the documents that are published in the public procurement journal</para>
    ///   <a href="https://purl.org/cm/onto/apco#Publication">apco:Publication</a>
    /// </summary>
    let Publication = _prefixId.prefix "Publication"
    /// <summary>
    ///   <para>rdfs:label : Soumissionnairerdfs:label : Tenderer</para>
    ///   <para>rdfs:comment : Natural person who made a bid to the contracting authorityrdfs:comment : Personne physique aui fait une offre à l'endroit de l'autorité contractante</para>
    ///   <a href="https://purl.org/cm/onto/apco#Soumissionnaire">apco:Soumissionnaire</a>
    /// </summary>
    let Soumissionnaire = _prefixId.prefix "Soumissionnaire"
    /// <summary>
    ///   <para>rdfs:label : a pour maître D'Ouvragerdfs:label : has building owner</para>
    ///   <para>rdfs:comment : Property indicating the building owner of a public contractrdfs:comment : Proprieté indiquant le maître d'ouvrage d'un marché public</para>
    ///   <a href="https://purl.org/cm/onto/apco#aPourMaitreDOuvrage">apco:aPourMaitreDOuvrage</a>
    /// </summary>
    let aPourMaitreDOuvrage = _prefixId.prefix "aPourMaitreDOuvrage"

    /// <summary>
    ///   <para>rdfs:label : Appel d'offre national restreintrdfs:label : Restricted national tender</para>
    ///   <para>rdfs:comment : La procédure d’appel d’offres national (AON) est recommandée pour la passation des marchés publics de travaux ou de fournitures qui, en raison de leur nature ou de leur ampleur, ont peu de chance d’intéresser les candidats étrangers du fait que : (1) les montants en jeu sont peu élevés ; (2) les travaux sont dispersés ou étalés dans le temps ; (3) les travaux nécessitent une haute intensité de main d’œuvre ; (4)les biens ou les travaux peuvent être fournis localement à des prix inférieurs à ceux du marché international.rdfs:comment : The National Competitive Bidding (NCB) procedure is recommended for awarding public contracts for works or supplies which, due to their nature or scale, are unlikely to interest foreign candidates because : (1) the amounts involved are low; (2) the work is dispersed or spread over time; (3) the works require a high labor intensity; (4) the goods or works can be supplied locally at prices lower than those on the international market.</para>
    ///   <a href="https://purl.org/cm/onto/apco#appelDoffre_national_restreint">apco:appelDoffre_national_restreint</a>
    /// </summary>
    let appelDoffre_national_restreint =
        _prefixId.prefix "appelDoffre_national_restreint"

    /// <summary>
    ///   <para>rdfs:label : assignsrdfs:label : attribue</para>
    ///   <para>rdfs:comment : Property indicating that a building owner awards a tenderrdfs:comment : Proprieté indiquant qu'un maître d'ouvrage attribue un appel d'offre</para>
    ///   <a href="https://purl.org/cm/onto/apco#attribue">apco:attribue</a>
    /// </summary>
    let attribue = _prefixId.prefix "attribue"
    /// <summary>
    ///   <para>rdfs:comment : Property indicating to whom an owner assigns a tenderrdfs:comment : Proprieté indiquant à qui un maître d'ouvrage attribue un appel d'offre</para>
    ///   <a href="https://purl.org/cm/onto/apco#attribueA">apco:attribueA</a>
    /// </summary>
    let attribueA = _prefixId.prefix "attribueA"
    /// <summary>
    ///   <para>rdfs:label : Chef du Service du Marchérdfs:label : market Service Manager</para>
    ///   <para>rdfs:comment : property indicating the head of the market department of a public marketrdfs:comment : proprieté indiquant le chef de service du marché d'un marché public</para>
    ///   <a href="https://purl.org/cm/onto/apco#chefDeServiceDuMarche">apco:chefDeServiceDuMarche</a>
    /// </summary>
    let chefDeServiceDuMarche = _prefixId.prefix "chefDeServiceDuMarche"
    /// <summary>
    ///   <para>rdfs:label : closing daterdfs:label : date de clôturerdfs:label : property indicating the closing date of a publicationrdfs:label : proprieté indiquant la date de clôture d'une publication</para>
    ///   <a href="https://purl.org/cm/onto/apco#dateDeCloture">apco:dateDeCloture</a>
    /// </summary>
    let dateDeCloture = _prefixId.prefix "dateDeCloture"
    /// <summary>
    ///   <para>rdfs:label : date de publicationrdfs:label : publication date</para>
    ///   <para>rdfs:comment : property indicating the publication date of a Publicationrdfs:comment : proprieté indiquant la date de publication d'une Publication</para>
    ///   <a href="https://purl.org/cm/onto/apco#dateDePublication">apco:dateDePublication</a>
    /// </summary>
    let dateDePublication = _prefixId.prefix "dateDePublication"
    /// <summary>
    ///   <para>rdfs:label : date de signaturerdfs:label : signature date</para>
    ///   <para>rdfs:comment : Property indicating the the date of signing of a publicationrdfs:comment : Proprieté indiquant la date de signature d'une publication</para>
    ///   <a href="https://purl.org/cm/onto/apco#dateDeSignature">apco:dateDeSignature</a>
    /// </summary>
    let dateDeSignature = _prefixId.prefix "dateDeSignature"

    /// <summary>
    ///   <para>rdfs:label : designation contracting autorityrdfs:label : désignation autorité contractante</para>
    ///   <a href="https://purl.org/cm/onto/apco#designationAutoriteContractante">apco:designationAutoriteContractante</a>
    /// </summary>
    let designationAutoriteContractante =
        _prefixId.prefix "designationAutoriteContractante"

    /// <summary>
    ///   <para>rdfs:label : designation building ownerrdfs:label : désignation maître d'ouvrage</para>
    ///   <a href="https://purl.org/cm/onto/apco#designationMaitreDOuvrage">apco:designationMaitreDOuvrage</a>
    /// </summary>
    let designationMaitreDOuvrage = _prefixId.prefix "designationMaitreDOuvrage"
    /// <summary>
    ///   <para>rdfs:label : est financé Parrdfs:label : is funded By</para>
    ///   <para>rdfs:comment : Property indicating the source of funding for a public contractrdfs:comment : Propriété indiquant la source de financement d'un marché public</para>
    ///   <a href="https://purl.org/cm/onto/apco#estFinancePar">apco:estFinancePar</a>
    /// </summary>
    let estFinancePar = _prefixId.prefix "estFinancePar"
    /// <summary>
    ///   <para>rdfs:label : fait ne Offrerdfs:label : make an Offer</para>
    ///   <para>rdfs:comment : Property indicating the offer made by a bidder. (cardinality 0..1)rdfs:comment : Proprieté indiquant l'offre faite par un soumissionnaire. (cardinalité 0..1)</para>
    ///   <a href="https://purl.org/cm/onto/apco#faitUneOffre">apco:faitUneOffre</a>
    /// </summary>
    let faitUneOffre = _prefixId.prefix "faitUneOffre"
    /// <summary>
    ///   <para>rdfs:label : closing timerdfs:label : heure de clôture</para>
    ///   <para>rdfs:comment : Property indicating the closing time of a publicationrdfs:comment : Proprieté indiquant l'heure de clôture d'une publication</para>
    ///   <a href="https://purl.org/cm/onto/apco#heureDeCloture">apco:heureDeCloture</a>
    /// </summary>
    let heureDeCloture = _prefixId.prefix "heureDeCloture"
    /// <summary>
    ///   <para>rdfs:label : id publicationrdfs:label : publication id</para>
    ///   <a href="https://purl.org/cm/onto/apco#idPublication">apco:idPublication</a>
    /// </summary>
    let idPublication = _prefixId.prefix "idPublication"
    /// <summary>
    ///   <para>rdfs:label : estimated Amountrdfs:label : montant Prévisionnel du Marché</para>
    ///   <a href="https://purl.org/cm/onto/apco#montantPrevisionnelduMarche">apco:montantPrevisionnelduMarche</a>
    /// </summary>
    let montantPrevisionnelduMarche = _prefixId.prefix "montantPrevisionnelduMarche"
    /// <summary>
    ///   <para>rdfs:label : nature Prestationrdfs:label : nature of Service</para>
    ///   <a href="https://purl.org/cm/onto/apco#naturePrestation">apco:naturePrestation</a>
    /// </summary>
    let naturePrestation = _prefixId.prefix "naturePrestation"
    let restataire = _prefixId.prefix "restataire"
    /// <summary>
    ///   <para>rdfs:label : activity areardfs:label : secteur d'activité</para>
    ///   <a href="https://purl.org/cm/onto/apco#secteurDActivite">apco:secteurDActivite</a>
    /// </summary>
    let secteurDActivite = _prefixId.prefix "secteurDActivite"
    /// <summary>
    ///   <para>rdfs:label : acronym prime contractorrdfs:label : sigle autorité contractante</para>
    ///   <a href="https://purl.org/cm/onto/apco#sigleAutoriteContractante">apco:sigleAutoriteContractante</a>
    /// </summary>
    let sigleAutoriteContractante = _prefixId.prefix "sigleAutoriteContractante"
    /// <summary>
    ///   <para>rdfs:label : acronym building ownerrdfs:label : sigle maître d'ouvrage</para>
    ///   <a href="https://purl.org/cm/onto/apco#sigleMaitreDOuvrage">apco:sigleMaitreDOuvrage</a>
    /// </summary>
    let sigleMaitreDOuvrage = _prefixId.prefix "sigleMaitreDOuvrage"
    let sigleProcedure = _prefixId.prefix "sigleProcedure"
    /// <summary>
    ///   <para>rdfs:label : source de financementrdfs:label : source of funding</para>
    ///   <a href="https://purl.org/cm/onto/apco#sourceDeFinancement">apco:sourceDeFinancement</a>
    /// </summary>
    let sourceDeFinancement = _prefixId.prefix "sourceDeFinancement"
