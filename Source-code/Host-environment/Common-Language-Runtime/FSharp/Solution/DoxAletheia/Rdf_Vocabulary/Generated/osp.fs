namespace http.data.lirmm.fr.ontologies.osp.hash

open DoxAletheia.Rdf_Vocabulary

module osp =
    let _namespace_name = "http://data.lirmm.fr/ontologies/osp#"
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/osp#felix"></see>
    /// </summary>
    let felix = Namespaced_IRI.parse _namespace_name "felix" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/osp#fran%C3%A7ois"></see>
    /// </summary>
    let ``fran%C3%A7ois`` =
        Namespaced_IRI.parse _namespace_name "fran%C3%A7ois" |> NamespacedName

    /// <summary>
    /// L'administration est dans le prolongement de l'administration. Elle est chargée de régler les affaires courantes
    /// <see href="http://data.lirmm.fr/ontologies/osp#Administration"></see></summary>
    let Administration =
        Namespaced_IRI.parse _namespace_name "Administration" |> NamespacedName

    /// <summary>
    /// Le pouvoir exécutif a pour charge d'exécuter les décisions de justice issues du pouvoir judiciaire et d'appliquer les lois votées par le pouvoir législatif.
    /// <see href="http://data.lirmm.fr/ontologies/osp#PouvoirExecutif"></see></summary>
    let PouvoirExecutif =
        Namespaced_IRI.parse _namespace_name "PouvoirExecutif" |> NamespacedName

    /// <summary>
    /// Le gouvernement est un des organes issus de la séparation des pouvoirs
    /// <see href="http://data.lirmm.fr/ontologies/osp#Gouvernement"></see></summary>
    let Gouvernement =
        Namespaced_IRI.parse _namespace_name "Gouvernement" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/osp#Adresse"></see>
    /// </summary>
    let Adresse = Namespaced_IRI.parse _namespace_name "Adresse" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/osp#Ambassade"></see>
    /// </summary>
    let Ambassade = Namespaced_IRI.parse _namespace_name "Ambassade" |> NamespacedName
    /// <summary>
    /// Bâtiment officiel de l'Etat français où réside le maire et le conseil municipal. Il fait partit de l'administration décentralisée.
    /// <see href="http://data.lirmm.fr/ontologies/osp#Mairie"></see></summary>
    let Mairie = Namespaced_IRI.parse _namespace_name "Mairie" |> NamespacedName
    /// <summary>
    /// Le tribunal est un bâtiment public où la justice y est rendu par des juges.
    /// <see href="http://data.lirmm.fr/ontologies/osp#Tribunal"></see></summary>
    let Tribunal = Namespaced_IRI.parse _namespace_name "Tribunal" |> NamespacedName
    /// <summary>
    /// Classe décrivant le chef d'Etat. La réalité de son pouvoir n'est pas le critère retenu mais ce qui apparait dans les textes. Ex : La reine d'Angleterre.
    /// <see href="http://data.lirmm.fr/ontologies/osp#ChefDEtat"></see></summary>
    let ChefDEtat = Namespaced_IRI.parse _namespace_name "ChefDEtat" |> NamespacedName

    /// <summary>
    /// Classe décrivant un chef de gouvernement
    /// <see href="http://data.lirmm.fr/ontologies/osp#ChefDuGouvernement"></see></summary>
    let ChefDuGouvernement =
        Namespaced_IRI.parse _namespace_name "ChefDuGouvernement" |> NamespacedName

    /// <summary>
    /// La classe Juge représente la fonction de juge au sein d'un tribunal
    /// <see href="http://data.lirmm.fr/ontologies/osp#Juge"></see></summary>
    let Juge = Namespaced_IRI.parse _namespace_name "Juge" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/osp#LIRMM"></see>
    /// </summary>
    let LIRMM = Namespaced_IRI.parse _namespace_name "LIRMM" |> NamespacedName
    /// <summary>
    /// Classe décrivant une personne ayant un rôle de ministre dans un gouvernement.
    /// <see href="http://data.lirmm.fr/ontologies/osp#Ministre"></see></summary>
    let Ministre = Namespaced_IRI.parse _namespace_name "Ministre" |> NamespacedName

    /// <summary>
    /// La classe stateservice a pour but de différencier un Etat ou une organisation d'Etat d'une entreprise privée.
    /// <see href="http://data.lirmm.fr/ontologies/osp#OrganisationEtatique"></see></summary>
    let OrganisationEtatique =
        Namespaced_IRI.parse _namespace_name "OrganisationEtatique" |> NamespacedName

    /// <summary>
    /// Regroupe les structure qui ne correspondent pas à un niveau étatique mais inter étatique ou extra étatique (ex : les ONG)
    /// <see href="http://data.lirmm.fr/ontologies/osp#OrganisationPublique"></see></summary>
    let OrganisationPublique =
        Namespaced_IRI.parse _namespace_name "OrganisationPublique" |> NamespacedName

    /// <summary>
    /// Branche judiciaire d'une organisation étatique
    /// <see href="http://data.lirmm.fr/ontologies/osp#PouvoirJudiciaire"></see></summary>
    let PouvoirJudiciaire =
        Namespaced_IRI.parse _namespace_name "PouvoirJudiciaire" |> NamespacedName

    /// <summary>
    /// Définie la fonction législative d'un pays
    /// <see href="http://data.lirmm.fr/ontologies/osp#PouvoirLegislatif"></see></summary>
    let PouvoirLegislatif =
        Namespaced_IRI.parse _namespace_name "PouvoirLegislatif" |> NamespacedName

    /// <summary>
    /// Il existe bien un secretary of state dans les autres pays mais n'a rien à voir avec la qualification de secretaire d'Etat en France
    /// <see href="http://data.lirmm.fr/ontologies/osp#SecretairedEtat"></see></summary>
    let SecretairedEtat =
        Namespaced_IRI.parse _namespace_name "SecretairedEtat" |> NamespacedName

    /// <summary>
    /// Propriété liant quelque chose à un département. Inverse de arrondissementDe.
    /// <see href="http://data.lirmm.fr/ontologies/osp#aArrondissement"></see></summary>
    let aArrondissement =
        Namespaced_IRI.parse _namespace_name "aArrondissement" |> NamespacedName

    /// <summary>
    /// Propriété définissant une autorité hiérarchique d'une organization sur une autre. Cette autorité est de préférence issue de textes légaux.
    ///
    /// Ne pas confondre autorité et sous organisme. Ex :
    /// Un ministère a un cabinet (on utilisera suborganization de @org)
    /// Le ministère de l'éducation exerce une autorité sur les écoles.
    /// <see href="http://data.lirmm.fr/ontologies/osp#aAutoriteSur"></see></summary>
    let aAutoriteSur =
        Namespaced_IRI.parse _namespace_name "aAutoriteSur" |> NamespacedName

    /// <summary>
    /// Les chambres divisent un tribunal, souvent de façon thématique (droit de la construction, droit de la co-propriété)
    /// <see href="http://data.lirmm.fr/ontologies/osp#aChambre"></see></summary>
    let aChambre = Namespaced_IRI.parse _namespace_name "aChambre" |> NamespacedName
    /// <summary>
    /// Propriété établissant un lien entre quelque chose et une commune
    /// <see href="http://data.lirmm.fr/ontologies/osp#aCommune"></see></summary>
    let aCommune = Namespaced_IRI.parse _namespace_name "aCommune" |> NamespacedName

    /// <summary>
    /// Propriété permettant la hiérarchisation du terrain couvert par un organisme. Généralement : régional, national, international.
    /// <see href="http://data.lirmm.fr/ontologies/osp#aCompetenceTerritoriale"></see></summary>
    let aCompetenceTerritoriale =
        Namespaced_IRI.parse _namespace_name "aCompetenceTerritoriale" |> NamespacedName

    /// <summary>
    /// Le système juridictionnel français est composé de 2 degrés et d'une haute juridiction. La haute juridiction n'est pas un degre. Nous l'a comptons néanmoins ainsi pour simplifier l'utilisation pour d'autres systèmes. 1er degré, 2nd degré ou haute juridiction
    /// <see href="http://data.lirmm.fr/ontologies/osp#aDegre"></see></summary>
    let aDegre = Namespaced_IRI.parse _namespace_name "aDegre" |> NamespacedName
    /// <summary>
    /// Propriété permettant de lier quelque chose à un évènement tel qu'il est définie dans l'ontologie ical.
    /// <see href="http://data.lirmm.fr/ontologies/osp#aEvenement"></see></summary>
    let aEvenement = Namespaced_IRI.parse _namespace_name "aEvenement" |> NamespacedName
    /// <summary>
    /// propriété décrivant les initials d'une entreprise, d'un pays ... ex : RU, SNCF ...
    /// sameAs hashtag oegov
    /// <see href="http://data.lirmm.fr/ontologies/osp#aInitiales"></see></summary>
    let aInitiales = Namespaced_IRI.parse _namespace_name "aInitiales" |> NamespacedName

    /// <summary>
    /// Propriété apportant la distinction entre ordre administratif ou judiciaire pour un tribunal
    /// <see href="http://data.lirmm.fr/ontologies/osp#aOrdreDeJuridiction"></see></summary>
    let aOrdreDeJuridiction =
        Namespaced_IRI.parse _namespace_name "aOrdreDeJuridiction" |> NamespacedName

    /// <summary>
    /// Propriété liant quelque chose à une région
    /// <see href="http://data.lirmm.fr/ontologies/osp#aRegion"></see></summary>
    let aRegion = Namespaced_IRI.parse _namespace_name "aRegion" |> NamespacedName
    /// <summary>
    /// Les chambres d'un tribunal sont décomposées en section
    /// <see href="http://data.lirmm.fr/ontologies/osp#aSection"></see></summary>
    let aSection = Namespaced_IRI.parse _namespace_name "aSection" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/osp#adresse"></see>
    /// </summary>
    let adresse = Namespaced_IRI.parse _namespace_name "adresse" |> NamespacedName

    /// <summary>
    /// Propriété liant un arrondissement à quelque chose
    /// <see href="http://data.lirmm.fr/ontologies/osp#arrondissementDe"></see></summary>
    let arrondissementDe =
        Namespaced_IRI.parse _namespace_name "arrondissementDe" |> NamespacedName

    /// <summary>
    /// Propriété liant une personne au rôle de chef de l'Etat.
    /// <see href="http://data.lirmm.fr/ontologies/osp#chefDEtat"></see></summary>
    let chefDEtat = Namespaced_IRI.parse _namespace_name "chefDEtat" |> NamespacedName

    /// <summary>
    /// Une personne à la tête du gouvernement
    /// <see href="http://data.lirmm.fr/ontologies/osp#chefDuGouvernement"></see></summary>
    let chefDuGouvernement =
        Namespaced_IRI.parse _namespace_name "chefDuGouvernement" |> NamespacedName

    /// <summary>
    /// Propriété établissant un lien entre une commune et quelque chose.
    /// <see href="http://data.lirmm.fr/ontologies/osp#communeDe"></see></summary>
    let communeDe = Namespaced_IRI.parse _namespace_name "communeDe" |> NamespacedName

    /// <summary>
    /// Propriété liant un juge à sa fonction au sein du tribunal.
    /// <see href="http://data.lirmm.fr/ontologies/osp#competenceJuge"></see></summary>
    let competenceJuge =
        Namespaced_IRI.parse _namespace_name "competenceJuge" |> NamespacedName

    /// <summary>
    /// Propriété liant un département à quelque chose
    /// <see href="http://data.lirmm.fr/ontologies/osp#departementDe"></see></summary>
    let departementDe =
        Namespaced_IRI.parse _namespace_name "departementDe" |> NamespacedName

    /// <summary>
    /// fax number
    /// <see href="http://data.lirmm.fr/ontologies/osp#fax"></see></summary>
    let fax = Namespaced_IRI.parse _namespace_name "fax" |> NamespacedName

    /// <summary>
    /// Compétence d'un juge dans un domaine.
    /// Ex : propriété intellectuelle, mer ...
    /// <see href="http://data.lirmm.fr/ontologies/osp#hasCompetence"></see></summary>
    let hasCompetence =
        Namespaced_IRI.parse _namespace_name "hasCompetence" |> NamespacedName

    /// <summary>
    /// Un service ou un pays à, dans un gouvernement démocratique, un chef de gouvernement
    /// <see href="http://data.lirmm.fr/ontologies/osp#hasHeadOfGov"></see></summary>
    let hasHeadOfGov =
        Namespaced_IRI.parse _namespace_name "hasHeadOfGov" |> NamespacedName

    /// <summary>
    /// Propriété définissant le chef d'Etat d'un pays
    /// <see href="http://data.lirmm.fr/ontologies/osp#hasHeadOfState"></see></summary>
    let hasHeadOfState =
        Namespaced_IRI.parse _namespace_name "hasHeadOfState" |> NamespacedName

    /// <summary>
    /// Propriété désignant la matière civile ou pénale que le tribunal revêt.
    /// <see href="http://data.lirmm.fr/ontologies/osp#hasMatter"></see></summary>
    let hasMatter = Namespaced_IRI.parse _namespace_name "hasMatter" |> NamespacedName

    /// <summary>
    /// Propriété définissant qu'un tribunal a un président
    /// <see href="http://data.lirmm.fr/ontologies/osp#hasPresident"></see></summary>
    let hasPresident =
        Namespaced_IRI.parse _namespace_name "hasPresident" |> NamespacedName

    /// <summary>
    /// Correspond au lien vers un évènement particulier
    /// <see href="http://data.lirmm.fr/ontologies/osp#hyperlienEvenement"></see></summary>
    let hyperlienEvenement =
        Namespaced_IRI.parse _namespace_name "hyperlienEvenement" |> NamespacedName

    /// <summary>
    /// Propriété liant quelque chose à ses initiales.
    /// <see href="http://data.lirmm.fr/ontologies/osp#initialesDe"></see></summary>
    let initialesDe =
        Namespaced_IRI.parse _namespace_name "initialesDe" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/osp#initials"></see>
    /// </summary>
    let initials = Namespaced_IRI.parse _namespace_name "initials" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/osp#ligneAdresse"></see>
    /// </summary>
    let ligneAdresse =
        Namespaced_IRI.parse _namespace_name "ligneAdresse" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/osp#numeroFax"></see>
    /// </summary>
    let numeroFax = Namespaced_IRI.parse _namespace_name "numeroFax" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/osp#ordreDeJuridiction"></see>
    /// </summary>
    let ordreDeJuridiction =
        Namespaced_IRI.parse _namespace_name "ordreDeJuridiction" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/osp#rdf"></see>
    /// </summary>
    let rdf = Namespaced_IRI.parse _namespace_name "rdf" |> NamespacedName
    /// <summary>
    /// Propriété liant une région à quelque chose
    /// <see href="http://data.lirmm.fr/ontologies/osp#regionDe"></see></summary>
    let regionDe = Namespaced_IRI.parse _namespace_name "regionDe" |> NamespacedName

    /// <summary>
    /// propriété instaurant la hiérarchie entre un organisme et un service. Ne pas confondre avec des sous ensemble d'un même service
    /// <see href="http://data.lirmm.fr/ontologies/osp#sousLAutoriteDe"></see></summary>
    let sousLAutoriteDe =
        Namespaced_IRI.parse _namespace_name "sousLAutoriteDe" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.lirmm.fr/ontologies/osp#ttl"></see>
    /// </summary>
    let ttl = Namespaced_IRI.parse _namespace_name "ttl" |> NamespacedName

    /// <summary>
    /// Propriété définissant quel type de tribunal il s'agit. Ex : tribunal d'instance, TGI ...
    /// <see href="http://data.lirmm.fr/ontologies/osp#typeTribunal"></see></summary>
    let typeTribunal =
        Namespaced_IRI.parse _namespace_name "typeTribunal" |> NamespacedName
