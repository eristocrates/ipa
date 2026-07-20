namespace http.data.lirmm.fr.ontologies.osp.hash

open DoxAletheia

module osp =
    let _namespace_name = "http://data.lirmm.fr/ontologies/osp#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/osp#felix"></see>
    /// </summary>
    let felix = _prefix "felix"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/osp#fran%C3%A7ois"></see>
    /// </summary>
    let ``fran%C3%A7ois`` = _prefix "fran%C3%A7ois"
    /// <summary>
    /// L'administration est dans le prolongement de l'administration. Elle est chargée de régler les affaires courantes
    /// <see href="http://data.lirmm.fr/ontologies/osp#Administration"></see></summary>
    let Administration = _prefix "Administration"
    /// <summary>
    /// Le pouvoir exécutif a pour charge d'exécuter les décisions de justice issues du pouvoir judiciaire et d'appliquer les lois votées par le pouvoir législatif.
    /// <see href="http://data.lirmm.fr/ontologies/osp#PouvoirExecutif"></see></summary>
    let PouvoirExecutif = _prefix "PouvoirExecutif"
    /// <summary>
    /// Le gouvernement est un des organes issus de la séparation des pouvoirs
    /// <see href="http://data.lirmm.fr/ontologies/osp#Gouvernement"></see></summary>
    let Gouvernement = _prefix "Gouvernement"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/osp#Adresse"></see>
    /// </summary>
    let Adresse = _prefix "Adresse"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/osp#Ambassade"></see>
    /// </summary>
    let Ambassade = _prefix "Ambassade"
    /// <summary>
    /// Bâtiment officiel de l'Etat français où réside le maire et le conseil municipal. Il fait partit de l'administration décentralisée.
    /// <see href="http://data.lirmm.fr/ontologies/osp#Mairie"></see></summary>
    let Mairie = _prefix "Mairie"
    /// <summary>
    /// Le tribunal est un bâtiment public où la justice y est rendu par des juges.
    /// <see href="http://data.lirmm.fr/ontologies/osp#Tribunal"></see></summary>
    let Tribunal = _prefix "Tribunal"
    /// <summary>
    /// Classe décrivant le chef d'Etat. La réalité de son pouvoir n'est pas le critère retenu mais ce qui apparait dans les textes. Ex : La reine d'Angleterre.
    /// <see href="http://data.lirmm.fr/ontologies/osp#ChefDEtat"></see></summary>
    let ChefDEtat = _prefix "ChefDEtat"
    /// <summary>
    /// Classe décrivant un chef de gouvernement
    /// <see href="http://data.lirmm.fr/ontologies/osp#ChefDuGouvernement"></see></summary>
    let ChefDuGouvernement = _prefix "ChefDuGouvernement"
    /// <summary>
    /// La classe Juge représente la fonction de juge au sein d'un tribunal
    /// <see href="http://data.lirmm.fr/ontologies/osp#Juge"></see></summary>
    let Juge = _prefix "Juge"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/osp#LIRMM"></see>
    /// </summary>
    let LIRMM = _prefix "LIRMM"
    /// <summary>
    /// Classe décrivant une personne ayant un rôle de ministre dans un gouvernement.
    /// <see href="http://data.lirmm.fr/ontologies/osp#Ministre"></see></summary>
    let Ministre = _prefix "Ministre"
    /// <summary>
    /// La classe stateservice a pour but de différencier un Etat ou une organisation d'Etat d'une entreprise privée.
    /// <see href="http://data.lirmm.fr/ontologies/osp#OrganisationEtatique"></see></summary>
    let OrganisationEtatique = _prefix "OrganisationEtatique"
    /// <summary>
    /// Regroupe les structure qui ne correspondent pas à un niveau étatique mais inter étatique ou extra étatique (ex : les ONG)
    /// <see href="http://data.lirmm.fr/ontologies/osp#OrganisationPublique"></see></summary>
    let OrganisationPublique = _prefix "OrganisationPublique"
    /// <summary>
    /// Branche judiciaire d'une organisation étatique
    /// <see href="http://data.lirmm.fr/ontologies/osp#PouvoirJudiciaire"></see></summary>
    let PouvoirJudiciaire = _prefix "PouvoirJudiciaire"
    /// <summary>
    /// Définie la fonction législative d'un pays
    /// <see href="http://data.lirmm.fr/ontologies/osp#PouvoirLegislatif"></see></summary>
    let PouvoirLegislatif = _prefix "PouvoirLegislatif"
    /// <summary>
    /// Il existe bien un secretary of state dans les autres pays mais n'a rien à voir avec la qualification de secretaire d'Etat en France
    /// <see href="http://data.lirmm.fr/ontologies/osp#SecretairedEtat"></see></summary>
    let SecretairedEtat = _prefix "SecretairedEtat"
    /// <summary>
    /// Propriété liant quelque chose à un département. Inverse de arrondissementDe.
    /// <see href="http://data.lirmm.fr/ontologies/osp#aArrondissement"></see></summary>
    let aArrondissement = _prefix "aArrondissement"
    /// <summary>
    /// Propriété définissant une autorité hiérarchique d'une organization sur une autre. Cette autorité est de préférence issue de textes légaux.
    ///
    /// Ne pas confondre autorité et sous organisme. Ex :
    /// Un ministère a un cabinet (on utilisera suborganization de @org)
    /// Le ministère de l'éducation exerce une autorité sur les écoles.
    /// <see href="http://data.lirmm.fr/ontologies/osp#aAutoriteSur"></see></summary>
    let aAutoriteSur = _prefix "aAutoriteSur"
    /// <summary>
    /// Les chambres divisent un tribunal, souvent de façon thématique (droit de la construction, droit de la co-propriété)
    /// <see href="http://data.lirmm.fr/ontologies/osp#aChambre"></see></summary>
    let aChambre = _prefix "aChambre"
    /// <summary>
    /// Propriété établissant un lien entre quelque chose et une commune
    /// <see href="http://data.lirmm.fr/ontologies/osp#aCommune"></see></summary>
    let aCommune = _prefix "aCommune"
    /// <summary>
    /// Propriété permettant la hiérarchisation du terrain couvert par un organisme. Généralement : régional, national, international.
    /// <see href="http://data.lirmm.fr/ontologies/osp#aCompetenceTerritoriale"></see></summary>
    let aCompetenceTerritoriale = _prefix "aCompetenceTerritoriale"
    /// <summary>
    /// Le système juridictionnel français est composé de 2 degrés et d'une haute juridiction. La haute juridiction n'est pas un degre. Nous l'a comptons néanmoins ainsi pour simplifier l'utilisation pour d'autres systèmes. 1er degré, 2nd degré ou haute juridiction
    /// <see href="http://data.lirmm.fr/ontologies/osp#aDegre"></see></summary>
    let aDegre = _prefix "aDegre"
    /// <summary>
    /// Propriété permettant de lier quelque chose à un évènement tel qu'il est définie dans l'ontologie ical.
    /// <see href="http://data.lirmm.fr/ontologies/osp#aEvenement"></see></summary>
    let aEvenement = _prefix "aEvenement"
    /// <summary>
    /// propriété décrivant les initials d'une entreprise, d'un pays ... ex : RU, SNCF ...
    /// sameAs hashtag oegov
    /// <see href="http://data.lirmm.fr/ontologies/osp#aInitiales"></see></summary>
    let aInitiales = _prefix "aInitiales"
    /// <summary>
    /// Propriété apportant la distinction entre ordre administratif ou judiciaire pour un tribunal
    /// <see href="http://data.lirmm.fr/ontologies/osp#aOrdreDeJuridiction"></see></summary>
    let aOrdreDeJuridiction = _prefix "aOrdreDeJuridiction"
    /// <summary>
    /// Propriété liant quelque chose à une région
    /// <see href="http://data.lirmm.fr/ontologies/osp#aRegion"></see></summary>
    let aRegion = _prefix "aRegion"
    /// <summary>
    /// Les chambres d'un tribunal sont décomposées en section
    /// <see href="http://data.lirmm.fr/ontologies/osp#aSection"></see></summary>
    let aSection = _prefix "aSection"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/osp#adresse"></see>
    /// </summary>
    let adresse = _prefix "adresse"
    /// <summary>
    /// Propriété liant un arrondissement à quelque chose
    /// <see href="http://data.lirmm.fr/ontologies/osp#arrondissementDe"></see></summary>
    let arrondissementDe = _prefix "arrondissementDe"
    /// <summary>
    /// Propriété liant une personne au rôle de chef de l'Etat.
    /// <see href="http://data.lirmm.fr/ontologies/osp#chefDEtat"></see></summary>
    let chefDEtat = _prefix "chefDEtat"
    /// <summary>
    /// Une personne à la tête du gouvernement
    /// <see href="http://data.lirmm.fr/ontologies/osp#chefDuGouvernement"></see></summary>
    let chefDuGouvernement = _prefix "chefDuGouvernement"
    /// <summary>
    /// Propriété établissant un lien entre une commune et quelque chose.
    /// <see href="http://data.lirmm.fr/ontologies/osp#communeDe"></see></summary>
    let communeDe = _prefix "communeDe"
    /// <summary>
    /// Propriété liant un juge à sa fonction au sein du tribunal.
    /// <see href="http://data.lirmm.fr/ontologies/osp#competenceJuge"></see></summary>
    let competenceJuge = _prefix "competenceJuge"
    /// <summary>
    /// Propriété liant un département à quelque chose
    /// <see href="http://data.lirmm.fr/ontologies/osp#departementDe"></see></summary>
    let departementDe = _prefix "departementDe"
    /// <summary>
    /// fax number
    /// <see href="http://data.lirmm.fr/ontologies/osp#fax"></see></summary>
    let fax = _prefix "fax"
    /// <summary>
    /// Compétence d'un juge dans un domaine.
    /// Ex : propriété intellectuelle, mer ...
    /// <see href="http://data.lirmm.fr/ontologies/osp#hasCompetence"></see></summary>
    let hasCompetence = _prefix "hasCompetence"
    /// <summary>
    /// Un service ou un pays à, dans un gouvernement démocratique, un chef de gouvernement
    /// <see href="http://data.lirmm.fr/ontologies/osp#hasHeadOfGov"></see></summary>
    let hasHeadOfGov = _prefix "hasHeadOfGov"
    /// <summary>
    /// Propriété définissant le chef d'Etat d'un pays
    /// <see href="http://data.lirmm.fr/ontologies/osp#hasHeadOfState"></see></summary>
    let hasHeadOfState = _prefix "hasHeadOfState"
    /// <summary>
    /// Propriété désignant la matière civile ou pénale que le tribunal revêt.
    /// <see href="http://data.lirmm.fr/ontologies/osp#hasMatter"></see></summary>
    let hasMatter = _prefix "hasMatter"
    /// <summary>
    /// Propriété définissant qu'un tribunal a un président
    /// <see href="http://data.lirmm.fr/ontologies/osp#hasPresident"></see></summary>
    let hasPresident = _prefix "hasPresident"
    /// <summary>
    /// Correspond au lien vers un évènement particulier
    /// <see href="http://data.lirmm.fr/ontologies/osp#hyperlienEvenement"></see></summary>
    let hyperlienEvenement = _prefix "hyperlienEvenement"
    /// <summary>
    /// Propriété liant quelque chose à ses initiales.
    /// <see href="http://data.lirmm.fr/ontologies/osp#initialesDe"></see></summary>
    let initialesDe = _prefix "initialesDe"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/osp#initials"></see>
    /// </summary>
    let initials = _prefix "initials"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/osp#ligneAdresse"></see>
    /// </summary>
    let ligneAdresse = _prefix "ligneAdresse"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/osp#numeroFax"></see>
    /// </summary>
    let numeroFax = _prefix "numeroFax"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/osp#ordreDeJuridiction"></see>
    /// </summary>
    let ordreDeJuridiction = _prefix "ordreDeJuridiction"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/osp#rdf"></see>
    /// </summary>
    let rdf = _prefix "rdf"
    /// <summary>
    /// Propriété liant une région à quelque chose
    /// <see href="http://data.lirmm.fr/ontologies/osp#regionDe"></see></summary>
    let regionDe = _prefix "regionDe"
    /// <summary>
    /// propriété instaurant la hiérarchie entre un organisme et un service. Ne pas confondre avec des sous ensemble d'un même service
    /// <see href="http://data.lirmm.fr/ontologies/osp#sousLAutoriteDe"></see></summary>
    let sousLAutoriteDe = _prefix "sousLAutoriteDe"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/osp#ttl"></see>
    /// </summary>
    let ttl = _prefix "ttl"
    /// <summary>
    /// Propriété définissant quel type de tribunal il s'agit. Ex : tribunal d'instance, TGI ...
    /// <see href="http://data.lirmm.fr/ontologies/osp#typeTribunal"></see></summary>
    let typeTribunal = _prefix "typeTribunal"
