namespace https.purl.org.cm.onto.apco.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module apco =
    let _namespace_iri = Namespace_Iri apco |> NamespaceIRI
    /// <summary>
    ///   <para>apco:MaitreDOeuvre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Personne physique ou morale de droit public ou privé, chargée par le maître d'ouvrage ou le maître d'ouvrage déléguéde garantir ses intérêts au stade de la définition, de l'élaboration, de la direction de l'exécution et de la reception des prestation objets du marché.</para>
    ///   <para>A natural or legal person governed by public or private law, charged by the contracting authority or the delegated contracting authority to guarantee its interests at the stage of definition, development, management of the execution and acceptance of the provision of market objects.</para>
    /// labels<para>maître d'oeuvre</para><para>Project manager</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#MaitreDOeuvre">https://purl.org/cm/onto/apco#MaitreDOeuvre</seealso>
    let MaitreDOeuvre = Prefixed_Name(apco, "MaitreDOeuvre") |> PrefixedName
    /// <summary>
    ///   <para>apco:Offre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>set of administrative, technical and financial documents constituting the tenderer's proposal</para>
    ///   <para>Ensemble de documents administratifs,  techniques et financiers constituant la proposition du soumissionaire</para>
    /// labels<para>Tender</para><para>Offre</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#Offre">https://purl.org/cm/onto/apco#Offre</seealso>
    let Offre = Prefixed_Name(apco, "Offre") |> PrefixedName
    /// <summary>
    ///   <para>apco:aPourMaitreDOuvrage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>Property indicating the building owner of a public contract</para>
    ///   <para>Proprieté indiquant le maître d'ouvrage d'un marché public</para>
    /// labels<para>a pour maître D'Ouvrage</para><para>has building owner</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#aPourMaitreDOuvrage">https://purl.org/cm/onto/apco#aPourMaitreDOuvrage</seealso>
    let aPourMaitreDOuvrage = Prefixed_Name(apco, "aPourMaitreDOuvrage") |> PrefixedName
    /// <summary>
    ///   <para>apco:Publication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The publication class designates all the documents that are published in the public procurement journal</para>
    ///   <para>La classe publication désigne l'ensemble des documents qui sont publié dans le journal des marchés publics.</para>
    /// labels<para>Publication</para><para>Publication</para><para>Communiqué</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#Publication">https://purl.org/cm/onto/apco#Publication</seealso>
    let Publication = Prefixed_Name(apco, "Publication") |> PrefixedName
    /// <summary>
    ///   <para>apco:Soumissionnaire</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Personne physique aui fait une offre à l'endroit de l'autorité contractante</para>
    ///   <para>Natural person who made a bid to the contracting authority</para>
    /// labels<para>Soumissionnaire</para><para>Tenderer</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#Soumissionnaire">https://purl.org/cm/onto/apco#Soumissionnaire</seealso>
    let Soumissionnaire = Prefixed_Name(apco, "Soumissionnaire") |> PrefixedName

    /// <summary>
    ///   <para>apco:chefDeServiceDuMarche</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>proprieté indiquant le chef de service du marché d'un marché public</para>
    ///   <para>property indicating the head of the market department of a public market</para>
    /// labels<para>Chef du Service du Marché</para><para>market Service Manager</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#chefDeServiceDuMarche">https://purl.org/cm/onto/apco#chefDeServiceDuMarche</seealso>
    let chefDeServiceDuMarche =
        Prefixed_Name(apco, "chefDeServiceDuMarche") |> PrefixedName

    /// <summary>
    ///   <para>apco:dateDeCloture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>proprieté indiquant la date de clôture d'une publication</para><para>property indicating the closing date of a publication</para><para>date de clôture</para><para>closing date</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#dateDeCloture">https://purl.org/cm/onto/apco#dateDeCloture</seealso>
    let dateDeCloture = Prefixed_Name(apco, "dateDeCloture") |> PrefixedName
    /// <summary>
    ///   <para>apco:dateDeSignature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Proprieté indiquant la date de signature d'une publication</para>
    ///   <para>Property indicating the the date of signing of a publication</para>
    /// labels<para>date de signature</para><para>signature date</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#dateDeSignature">https://purl.org/cm/onto/apco#dateDeSignature</seealso>
    let dateDeSignature = Prefixed_Name(apco, "dateDeSignature") |> PrefixedName

    /// <summary>
    ///   <para>apco:designationMaitreDOuvrage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>désignation maître d'ouvrage</para><para>designation building owner</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#designationMaitreDOuvrage">https://purl.org/cm/onto/apco#designationMaitreDOuvrage</seealso>
    let designationMaitreDOuvrage =
        Prefixed_Name(apco, "designationMaitreDOuvrage") |> PrefixedName

    /// <summary>
    ///   <para>apco:attribueA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Proprieté indiquant à qui un maître d'ouvrage attribue un appel d'offre</para>
    ///   <para>Property indicating to whom an owner assigns a tender</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#attribueA">https://purl.org/cm/onto/apco#attribueA</seealso>
    let attribueA = Prefixed_Name(apco, "attribueA") |> PrefixedName
    /// <summary>
    ///   <para>apco:IngenieurDuMarche</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Personne physique ou morale de droit public accréditée par le Maître d'ouvrage ou le Maître d'ouvrage délégué, pour le suivi et le contrôle technique et financier de l'exécution du marché.</para>
    ///   <para>Natural or legal person governed by public law accredited by the Project Owner or the Delegated Project Owner, for the monitoring and technical and financial control of the performance of the contract.</para>
    /// labels<para>Ingénieur du marché</para><para>market engineer</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#IngenieurDuMarche">https://purl.org/cm/onto/apco#IngenieurDuMarche</seealso>
    let IngenieurDuMarche = Prefixed_Name(apco, "IngenieurDuMarche") |> PrefixedName

    /// <summary>
    ///   <para>apco:AutoriteContractante</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Natural person skilled in leading the contracting process and signing the related contracts</para>
    ///   <para>Personne physique ou morale habilelé à conduire le processus de contractualisation et de signer les marchés y relatifs</para>
    /// labels<para>Autorité contractante</para><para>Contracting authority</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#AutoriteContractante">https://purl.org/cm/onto/apco#AutoriteContractante</seealso>
    let AutoriteContractante =
        Prefixed_Name(apco, "AutoriteContractante") |> PrefixedName

    /// <summary>
    ///   <para>apco:AppelAManifestationDInteret</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Call for expressions of interest</para><para>Appel a manifestation d'intérêt</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#AppelAManifestationDInteret">https://purl.org/cm/onto/apco#AppelAManifestationDInteret</seealso>
    let AppelAManifestationDInteret =
        Prefixed_Name(apco, "AppelAManifestationDInteret") |> PrefixedName

    /// <summary>
    ///   <para>apco:naturePrestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>nature of Service</para><para>nature Prestation</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#naturePrestation">https://purl.org/cm/onto/apco#naturePrestation</seealso>
    let naturePrestation = Prefixed_Name(apco, "naturePrestation") |> PrefixedName

    /// <summary>
    ///   <para>apco:sigleAutoriteContractante</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>sigle autorité contractante</para><para>acronym prime contractor</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#sigleAutoriteContractante">https://purl.org/cm/onto/apco#sigleAutoriteContractante</seealso>
    let sigleAutoriteContractante =
        Prefixed_Name(apco, "sigleAutoriteContractante") |> PrefixedName

    /// <summary>
    ///   <para>apco:AppelDOffre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>contrat ecrit par lequel un entrepreneur, un fournisseur ou un prestataire de service s'engage envers l'etat , une collectivité territoriale décentralisée ou un établissement public soit à réaliser des travaux, soit à fournir des biens et des services moyennant un prix</para>
    ///   <para>written contract by which a contractor, a supplier or a service provider undertakes towards the state, a decentralized territorial community or a public establishment either to carry out work, or to provide goods and services for a price</para>
    /// labels<para>Public contract</para><para>Appel d'offre</para><para>Tender</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#AppelDOffre">https://purl.org/cm/onto/apco#AppelDOffre</seealso>
    let AppelDOffre = Prefixed_Name(apco, "AppelDOffre") |> PrefixedName
    /// <summary>
    ///   <para>apco:sigleProcedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#sigleProcedure">https://purl.org/cm/onto/apco#sigleProcedure</seealso>
    let sigleProcedure = Prefixed_Name(apco, "sigleProcedure") |> PrefixedName

    /// <summary>
    ///   <para>apco:AppelDOffreEnDeuxEtapes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Public contract with two steps</para><para>Appel d'offre en deux étapes</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#AppelDOffreEnDeuxEtapes">https://purl.org/cm/onto/apco#AppelDOffreEnDeuxEtapes</seealso>
    let AppelDOffreEnDeuxEtapes =
        Prefixed_Name(apco, "AppelDOffreEnDeuxEtapes") |> PrefixedName

    /// <summary>
    ///   <para>apco:AppelDOffreAvecConcours</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Appel d'offre avec concours</para><para>Public contract with merit</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#AppelDOffreAvecConcours">https://purl.org/cm/onto/apco#AppelDOffreAvecConcours</seealso>
    let AppelDOffreAvecConcours =
        Prefixed_Name(apco, "AppelDOffreAvecConcours") |> PrefixedName

    /// <summary>
    ///   <para>apco:AppelDOffreInternationalRestreint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>La procédure d’appel d’offres international  est recommandée pour la passation des marchés de Services et Prestations Intellectuelles de montant supérieur à cent (100) millions de F CFA ou lorsqu’il n’existe pas de compétence au niveau local pour la réalisation des prestations objet de l’appel d’offres.</para>
    ///   <para>The international competitive bidding procedure is recommended for the award of contracts for Services and Intellectual Benefits of an amount greater than one hundred (100) million CFA francs or when there is no competence at the local level for the performance of the services covered by the call for tenders.</para>
    /// labels<para>Appel d'offre international restreint</para><para>Restricted international tender</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#AppelDOffreInternationalRestreint">https://purl.org/cm/onto/apco#AppelDOffreInternationalRestreint</seealso>
    let AppelDOffreInternationalRestreint =
        Prefixed_Name(apco, "AppelDOffreInternationalRestreint") |> PrefixedName

    /// <summary>
    ///   <para>apco:AppelDOffreNationalOuvert</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>La procédure d’appel d’offres national (AON) est recommandée pour la passation des marchés publics de travaux ou de fournitures qui, en raison de leur nature ou de leur ampleur, ont peu de chance d’intéresser les candidats étrangers du fait que : (1) les montants en jeu sont peu élevés ; (2) les travaux sont dispersés ou étalés dans le temps ; (3) les travaux nécessitent une haute intensité de main d’œuvre ; (4)les biens ou les travaux peuvent être fournis localement à des prix inférieurs à ceux du marché international.</para>
    ///   <para>The National Competitive Bidding (NCB) procedure is recommended for awarding public contracts for works or supplies which, due to their nature or scale, are unlikely to interest foreign candidates because : (1) the amounts involved are low; (2) the work is dispersed or spread over time; (3) the works require a high labor intensity; (4) the goods or works can be supplied locally at prices lower than those on the international market.</para>
    /// labels<para>Appel d'offre national ouvert</para><para>Open national tender</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#AppelDOffreNationalOuvert">https://purl.org/cm/onto/apco#AppelDOffreNationalOuvert</seealso>
    let AppelDOffreNationalOuvert =
        Prefixed_Name(apco, "AppelDOffreNationalOuvert") |> PrefixedName

    /// <summary>
    ///   <para>apco:AppelDOffreInternationalOuvert</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>La procédure d’appel d’offres international  est recommandée pour la passation des marchés de Services et Prestations Intellectuelles de montant supérieur à cent (100) millions de F CFA ou lorsqu’il n’existe pas de compétence au niveau local pour la réalisation des prestations objet de l’appel d’offres.</para>
    ///   <para>The international competitive bidding procedure is recommended for the award of contracts for Services and Intellectual Benefits of an amount greater than one hundred (100) million CFA francs or when there is no competence at the local level for the performance of the services covered by the call for tenders.</para>
    /// labels<para>Appel d'offre international ouvert</para><para>Open international tender</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#AppelDOffreInternationalOuvert">https://purl.org/cm/onto/apco#AppelDOffreInternationalOuvert</seealso>
    let AppelDOffreInternationalOuvert =
        Prefixed_Name(apco, "AppelDOffreInternationalOuvert") |> PrefixedName

    /// <summary>
    ///   <para>apco:AppelDOffreOuvert</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Appel d'offre ouvert</para><para>open tender</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#AppelDOffreOuvert">https://purl.org/cm/onto/apco#AppelDOffreOuvert</seealso>
    let AppelDOffreOuvert = Prefixed_Name(apco, "AppelDOffreOuvert") |> PrefixedName

    /// <summary>
    ///   <para>apco:AppelDOffreRestreint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Restricted call for tenders is now addressed to all candidates selected following a pre-qualification procedure and no longer to a limited number of candidates among those pre-qualified.
    ///
    /// The pre-qualification report, drawn up by the Contracting Authority or the Contracting Authority's Representative and accompanied by the draft tender dossier with the proposal for shortlists, is submitted to the competent procurement commission for examination.
    ///
    /// The restricted tendering procedure may only be used in the following cases: (1) specific works or equipment of great importance or complexity; (2) specialized supplies and services; (3) intellectual services.</para>
    ///   <para>L’appel d’offres restreint s’adresse désormais à l’ensemble des candidats retenus à l’issue d’une procédure de pré-qualification et non plus à un nombre limité de candidats parmi ceux pré-qualifiés.
    ///
    /// Le rapport de pré-qualification, rédigé par le Maître d’Ouvrage ou le Maître d’Ouvrage Délégué et accompagné du projet de dossier d’appel d’offres avec la proposition de listes restreintes, est soumis à la commission des marchés compétente pour examen.
    ///
    /// La procédure d’appel d’offres restreint ne peut être utilisée que dans les cas suivants : (1) travaux ou équipements spécifiques de grande importance ou complexes ; (2) fournitures et services spécialisés ; (3) prestations intellectuelles.</para>
    /// labels<para>Appel d'offre restreint</para><para>Restricted tender</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#AppelDOffreRestreint">https://purl.org/cm/onto/apco#AppelDOffreRestreint</seealso>
    let AppelDOffreRestreint =
        Prefixed_Name(apco, "AppelDOffreRestreint") |> PrefixedName

    /// <summary>
    ///   <para>apco:ChefDeServiceDuMarche</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Natural person under public law accredited by the Project Owner or the Delegated Project Owner for general assistance of an administrative, financial and technical nature at the stage of definition, development, execution and acceptance of the services, market objects.</para>
    ///   <para>Personne physique de droit public accréditée par le Maître d'ouvrage ou le Maître d'ouvrage délégué pour une assistance générale à caractère administratif, financier et technique au stade de la définition, de l'élaboration, de l'exécution et de la réception des prestations, objets du marché.</para>
    /// labels<para>Chef de service du marché</para><para>Market service manager</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#ChefDeServiceDuMarche">https://purl.org/cm/onto/apco#ChefDeServiceDuMarche</seealso>
    let ChefDeServiceDuMarche =
        Prefixed_Name(apco, "ChefDeServiceDuMarche") |> PrefixedName

    /// <summary>
    ///   <para>apco:DemandeDeCotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>simplified procedure for consulting companies for the awarding of certain job orders relating to the supply of goods and services or to any other smaller-scale services that do not require the preparation of technical offers</para>
    ///   <para>Procédure simplifiée de consultation d’entreprises pour la passation de certaines lettres-commandes relatives aux fournitures de biens et services ou à toutes autres prestations de moindre envergure ne nécessitant pas l’élaboration d’offres techniques.</para>
    /// labels<para>DemandeDeCotation</para><para>APriceQuote</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#DemandeDeCotation">https://purl.org/cm/onto/apco#DemandeDeCotation</seealso>
    let DemandeDeCotation = Prefixed_Name(apco, "DemandeDeCotation") |> PrefixedName
    /// <summary>
    ///   <para>apco:Financement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Classe désignant l'organe chargé de financer un marché public</para>
    ///   <para>Class designating the body responsible for financing a public contract</para>
    /// labels<para>Financement</para><para>Funding</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#Financement">https://purl.org/cm/onto/apco#Financement</seealso>
    let Financement = Prefixed_Name(apco, "Financement") |> PrefixedName
    /// <summary>
    ///   <para>apco:estFinancePar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>Property indicating the source of funding for a public contract</para>
    ///   <para>Propriété indiquant la source de financement d'un marché public</para>
    /// labels<para>est financé Par</para><para>is funded By</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#estFinancePar">https://purl.org/cm/onto/apco#estFinancePar</seealso>
    let estFinancePar = Prefixed_Name(apco, "estFinancePar") |> PrefixedName
    /// <summary>
    ///   <para>apco:MaitreDOuvrage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Chef de département ministériel ou assimilé, chef de l'exécutif d'une collectivité territoriale décentralisée, et directeur général d'un établissement public, représentant l'administration bénéficiaire des prestations prévues dans le marché.</para>
    /// labels<para>Maître d'ouvrage</para><para>Building owner</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#MaitreDOuvrage">https://purl.org/cm/onto/apco#MaitreDOuvrage</seealso>
    let MaitreDOuvrage = Prefixed_Name(apco, "MaitreDOuvrage") |> PrefixedName
    /// <summary>
    ///   <para>apco:Prestataire</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Personne physique ou morale, titulaire d'un marché public</para>
    ///   <para>Proprieté indiquant le prestataire d'un marché public</para>
    ///   <para>Property indicating that a tender is awarded to a provider</para>
    /// labels<para>a pour prestataire</para><para>has provider</para><para>Prestataire</para><para>Provider</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#Prestataire">https://purl.org/cm/onto/apco#Prestataire</seealso>
    let Prestataire = Prefixed_Name(apco, "Prestataire") |> PrefixedName
    /// <summary>
    ///   <para>apco:faitUneOffre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>Property indicating the offer made by a bidder. (cardinality 0..1)</para>
    ///   <para>Proprieté indiquant l'offre faite par un soumissionnaire. (cardinalité 0..1)</para>
    /// labels<para>fait ne Offre</para><para>make an Offer</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#faitUneOffre">https://purl.org/cm/onto/apco#faitUneOffre</seealso>
    let faitUneOffre = Prefixed_Name(apco, "faitUneOffre") |> PrefixedName

    /// <summary>
    ///   <para>apco:appelDoffre_national_restreint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>La procédure d’appel d’offres national (AON) est recommandée pour la passation des marchés publics de travaux ou de fournitures qui, en raison de leur nature ou de leur ampleur, ont peu de chance d’intéresser les candidats étrangers du fait que : (1) les montants en jeu sont peu élevés ; (2) les travaux sont dispersés ou étalés dans le temps ; (3) les travaux nécessitent une haute intensité de main d’œuvre ; (4)les biens ou les travaux peuvent être fournis localement à des prix inférieurs à ceux du marché international.</para>
    ///   <para>The National Competitive Bidding (NCB) procedure is recommended for awarding public contracts for works or supplies which, due to their nature or scale, are unlikely to interest foreign candidates because : (1) the amounts involved are low; (2) the work is dispersed or spread over time; (3) the works require a high labor intensity; (4) the goods or works can be supplied locally at prices lower than those on the international market.</para>
    /// labels<para>Appel d'offre national restreint</para><para>Restricted national tender</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#appelDoffre_national_restreint">https://purl.org/cm/onto/apco#appelDoffre_national_restreint</seealso>
    let appelDoffre_national_restreint =
        Prefixed_Name(apco, "appelDoffre_national_restreint") |> PrefixedName

    /// <summary>
    ///   <para>apco:attribue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>Proprieté indiquant qu'un maître d'ouvrage attribue un appel d'offre</para>
    ///   <para>Property indicating that a building owner awards a tender</para>
    /// labels<para>attribue</para><para>assigns</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#attribue">https://purl.org/cm/onto/apco#attribue</seealso>
    let attribue = Prefixed_Name(apco, "attribue") |> PrefixedName
    /// <summary>
    ///   <para>apco:restataire</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#restataire">https://purl.org/cm/onto/apco#restataire</seealso>
    let restataire = Prefixed_Name(apco, "restataire") |> PrefixedName
    /// <summary>
    ///   <para>apco:dateDePublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>proprieté indiquant la date de publication d'une Publication</para>
    ///   <para>property indicating the publication date of a Publication</para>
    /// labels<para>date de publication</para><para>publication date</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#dateDePublication">https://purl.org/cm/onto/apco#dateDePublication</seealso>
    let dateDePublication = Prefixed_Name(apco, "dateDePublication") |> PrefixedName
    /// <summary>
    ///   <para>apco:heureDeCloture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Property indicating the closing time of a publication</para>
    ///   <para>Proprieté indiquant l'heure de clôture d'une publication</para>
    /// labels<para>heure de clôture</para><para>closing time</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#heureDeCloture">https://purl.org/cm/onto/apco#heureDeCloture</seealso>
    let heureDeCloture = Prefixed_Name(apco, "heureDeCloture") |> PrefixedName
    /// <summary>
    ///   <para>apco:idPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>id publication</para><para>publication id</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#idPublication">https://purl.org/cm/onto/apco#idPublication</seealso>
    let idPublication = Prefixed_Name(apco, "idPublication") |> PrefixedName

    /// <summary>
    ///   <para>apco:montantPrevisionnelduMarche</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>montant Prévisionnel du Marché</para><para>estimated Amount</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#montantPrevisionnelduMarche">https://purl.org/cm/onto/apco#montantPrevisionnelduMarche</seealso>
    let montantPrevisionnelduMarche =
        Prefixed_Name(apco, "montantPrevisionnelduMarche") |> PrefixedName

    /// <summary>
    ///   <para>apco:secteurDActivite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>secteur d'activité</para><para>activity area</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#secteurDActivite">https://purl.org/cm/onto/apco#secteurDActivite</seealso>
    let secteurDActivite = Prefixed_Name(apco, "secteurDActivite") |> PrefixedName
    /// <summary>
    ///   <para>apco:sigleMaitreDOuvrage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>acronym building owner</para><para>sigle maître d'ouvrage</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#sigleMaitreDOuvrage">https://purl.org/cm/onto/apco#sigleMaitreDOuvrage</seealso>
    let sigleMaitreDOuvrage = Prefixed_Name(apco, "sigleMaitreDOuvrage") |> PrefixedName
    /// <summary>
    ///   <para>apco:sourceDeFinancement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>source de financement</para><para>source of funding</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#sourceDeFinancement">https://purl.org/cm/onto/apco#sourceDeFinancement</seealso>
    let sourceDeFinancement = Prefixed_Name(apco, "sourceDeFinancement") |> PrefixedName

    /// <summary>
    ///   <para>apco:designationAutoriteContractante</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>désignation autorité contractante</para><para>designation contracting autority</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#designationAutoriteContractante">https://purl.org/cm/onto/apco#designationAutoriteContractante</seealso>
    let designationAutoriteContractante =
        Prefixed_Name(apco, "designationAutoriteContractante") |> PrefixedName

    /// <summary>
    ///   <para>apco:DecisionDAnnulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Procédure d'annulation d'un appel d'offre</para>
    ///   <para>Procedure for canceling a tender</para>
    /// labels<para>Cancellation decision</para><para>Décision d'annulation</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#DecisionDAnnulation">https://purl.org/cm/onto/apco#DecisionDAnnulation</seealso>
    let DecisionDAnnulation = Prefixed_Name(apco, "DecisionDAnnulation") |> PrefixedName

    /// <summary>
    ///   <para>apco:DecisionDAttribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Procedure for awarding a call for tenders</para>
    ///   <para>Procédure d'attribution d'un appel d'offre</para>
    /// labels<para>Décision d'attribution</para><para>Award decision</para></remarks>
    /// <seealso href="https://purl.org/cm/onto/apco#DecisionDAttribution">https://purl.org/cm/onto/apco#DecisionDAttribution</seealso>
    let DecisionDAttribution =
        Prefixed_Name(apco, "DecisionDAttribution") |> PrefixedName
