#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module osp =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://data.lirmm.fr/ontologies/osp#" "osp"

    /// <summary>
    ///   <para>rdfs:label : Administration^^xsd:string</para>
    ///   <para>rdfs:comment : L'administration est dans le prolongement de l'administration. Elle est chargée de régler les affaires courantes^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#Administration">osp:Administration</a>
    /// </summary>
    let Administration = _prefixId.prefix "Administration"
    /// <summary>
    ///   <para>rdfs:label : Classe décrivant une adresse postale^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#Adresse">osp:Adresse</a>
    /// </summary>
    let Adresse = _prefixId.prefix "Adresse"
    /// <summary>
    ///   <para>rdfs:label : Ambassade^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#Ambassade">osp:Ambassade</a>
    /// </summary>
    let Ambassade = _prefixId.prefix "Ambassade"
    /// <summary>
    ///   <para>rdfs:label : chef d'Etat^^xsd:string</para>
    ///   <para>rdfs:comment : Classe décrivant le chef d'Etat. La réalité de son pouvoir n'est pas le critère retenu mais ce qui apparait dans les textes. Ex : La reine d'Angleterre.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#ChefDEtat">osp:ChefDEtat</a>
    /// </summary>
    let ChefDEtat = _prefixId.prefix "ChefDEtat"
    /// <summary>
    ///   <para>rdfs:label : Chef du gouvernement^^xsd:string</para>
    ///   <para>rdfs:comment : Classe décrivant un chef de gouvernement^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#ChefDuGouvernement">osp:ChefDuGouvernement</a>
    /// </summary>
    let ChefDuGouvernement = _prefixId.prefix "ChefDuGouvernement"
    /// <summary>
    ///   <para>rdfs:label : Gouvernment^^xsd:string</para>
    ///   <para>rdfs:comment : Le gouvernement est un des organes issus de la séparation des pouvoirs^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#Gouvernement">osp:Gouvernement</a>
    /// </summary>
    let Gouvernement = _prefixId.prefix "Gouvernement"
    /// <summary>
    ///   <para>rdfs:label : Juge^^xsd:string</para>
    ///   <para>rdfs:comment : La classe Juge représente la fonction de juge au sein d'un tribunal^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#Juge">osp:Juge</a>
    /// </summary>
    let Juge = _prefixId.prefix "Juge"
    let LIRMM = _prefixId.prefix "LIRMM"
    /// <summary>
    ///   <para>rdfs:label : Mairie^^xsd:string</para>
    ///   <para>rdfs:comment : Bâtiment officiel de l'Etat français où réside le maire et le conseil municipal. Il fait partit de l'administration décentralisée.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#Mairie">osp:Mairie</a>
    /// </summary>
    let Mairie = _prefixId.prefix "Mairie"
    /// <summary>
    ///   <para>rdfs:label : Ministre^^xsd:string</para>
    ///   <para>rdfs:comment : Classe décrivant une personne ayant un rôle de ministre dans un gouvernement.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#Ministre">osp:Ministre</a>
    /// </summary>
    let Ministre = _prefixId.prefix "Ministre"
    /// <summary>
    ///   <para>rdfs:label : Organisation Etatique^^xsd:string</para>
    ///   <para>rdfs:comment : La classe stateservice a pour but de différencier un Etat ou une organisation d'Etat d'une entreprise privée.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#OrganisationEtatique">osp:OrganisationEtatique</a>
    /// </summary>
    let OrganisationEtatique = _prefixId.prefix "OrganisationEtatique"
    /// <summary>
    ///   <para>rdfs:label : Organisation publique^^xsd:string</para>
    ///   <para>rdfs:comment : Regroupe les structure qui ne correspondent pas à un niveau étatique mais inter étatique ou extra étatique (ex : les ONG)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#OrganisationPublique">osp:OrganisationPublique</a>
    /// </summary>
    let OrganisationPublique = _prefixId.prefix "OrganisationPublique"
    /// <summary>
    ///   <para>rdfs:label : pouvoir exécutif^^xsd:string</para>
    ///   <para>rdfs:comment : Le pouvoir exécutif a pour charge d'exécuter les décisions de justice issues du pouvoir judiciaire et d'appliquer les lois votées par le pouvoir législatif.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#PouvoirExecutif">osp:PouvoirExecutif</a>
    /// </summary>
    let PouvoirExecutif = _prefixId.prefix "PouvoirExecutif"
    /// <summary>
    ///   <para>rdfs:label : Pouvoir judiciaire^^xsd:string</para>
    ///   <para>rdfs:comment : Branche judiciaire d'une organisation étatique^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#PouvoirJudiciaire">osp:PouvoirJudiciaire</a>
    /// </summary>
    let PouvoirJudiciaire = _prefixId.prefix "PouvoirJudiciaire"
    /// <summary>
    ///   <para>rdfs:label : Pouvoir législatif^^xsd:string</para>
    ///   <para>rdfs:comment : Définie la fonction législative d'un pays^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#PouvoirLegislatif">osp:PouvoirLegislatif</a>
    /// </summary>
    let PouvoirLegislatif = _prefixId.prefix "PouvoirLegislatif"
    /// <summary>
    ///   <para>rdfs:label : Secretaire d'Etat^^xsd:string</para>
    ///   <para>rdfs:comment : Il existe bien un secretary of state dans les autres pays mais n'a rien à voir avec la qualification de secretaire d'Etat en France^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#SecretairedEtat">osp:SecretairedEtat</a>
    /// </summary>
    let SecretairedEtat = _prefixId.prefix "SecretairedEtat"
    /// <summary>
    ///   <para>rdfs:label : tribunal^^xsd:string</para>
    ///   <para>rdfs:comment : Le tribunal est un bâtiment public où la justice y est rendu par des juges.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#Tribunal">osp:Tribunal</a>
    /// </summary>
    let Tribunal = _prefixId.prefix "Tribunal"
    /// <summary>
    ///   <para>rdfs:label : aArrondissement^^xsd:string</para>
    ///   <para>rdfs:comment : Propriété liant quelque chose à un département. Inverse de arrondissementDe.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#aArrondissement">osp:aArrondissement</a>
    /// </summary>
    let aArrondissement = _prefixId.prefix "aArrondissement"
    /// <summary>
    ///   <para>rdfs:label : a autorité sur^^xsd:string</para>
    ///   <para>rdfs:comment : Propriété définissant une autorité hiérarchique d'une organization sur une autre. Cette autorité est de préférence issue de textes légaux.
    ///
    /// Ne pas confondre autorité et sous organisme. Ex :
    /// Un ministère a un cabinet (on utilisera suborganization de @org)
    /// Le ministère de l'éducation exerce une autorité sur les écoles.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#aAutoriteSur">osp:aAutoriteSur</a>
    /// </summary>
    let aAutoriteSur = _prefixId.prefix "aAutoriteSur"
    /// <summary>
    ///   <para>rdfs:label : a chambre^^xsd:string</para>
    ///   <para>rdfs:comment : Les chambres divisent un tribunal, souvent de façon thématique (droit de la construction, droit de la co-propriété)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#aChambre">osp:aChambre</a>
    /// </summary>
    let aChambre = _prefixId.prefix "aChambre"
    /// <summary>
    ///   <para>rdfs:label : a commune^^xsd:string</para>
    ///   <para>rdfs:comment : Propriété établissant un lien entre quelque chose et une commune^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#aCommune">osp:aCommune</a>
    /// </summary>
    let aCommune = _prefixId.prefix "aCommune"
    /// <summary>
    ///   <para>rdfs:label : A Competence Territoriale^^xsd:string</para>
    ///   <para>rdfs:comment : Propriété permettant la hiérarchisation du terrain couvert par un organisme. Généralement : régional, national, international.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#aCompetenceTerritoriale">osp:aCompetenceTerritoriale</a>
    /// </summary>
    let aCompetenceTerritoriale = _prefixId.prefix "aCompetenceTerritoriale"
    /// <summary>
    ///   <para>rdfs:label : a degre^^xsd:string</para>
    ///   <para>rdfs:comment : Le système juridictionnel français est composé de 2 degrés et d'une haute juridiction. La haute juridiction n'est pas un degre. Nous l'a comptons néanmoins ainsi pour simplifier l'utilisation pour d'autres systèmes. 1er degré, 2nd degré ou haute juridiction^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#aDegre">osp:aDegre</a>
    /// </summary>
    let aDegre = _prefixId.prefix "aDegre"
    /// <summary>
    ///   <para>rdfs:label : A evenement^^xsd:string</para>
    ///   <para>rdfs:comment : Propriété permettant de lier quelque chose à un évènement tel qu'il est définie dans l'ontologie ical.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#aEvenement">osp:aEvenement</a>
    /// </summary>
    let aEvenement = _prefixId.prefix "aEvenement"
    /// <summary>
    ///   <para>rdfs:label : a initiales^^xsd:string</para>
    ///   <para>rdfs:comment : propriété décrivant les initials d'une entreprise, d'un pays ... ex : RU, SNCF ...
    /// sameAs hashtag oegov^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#aInitiales">osp:aInitiales</a>
    /// </summary>
    let aInitiales = _prefixId.prefix "aInitiales"
    /// <summary>
    ///   <para>rdfs:label : A ordre de juridiction^^xsd:string</para>
    ///   <para>rdfs:comment : Propriété apportant la distinction entre ordre administratif ou judiciaire pour un tribunal^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#aOrdreDeJuridiction">osp:aOrdreDeJuridiction</a>
    /// </summary>
    let aOrdreDeJuridiction = _prefixId.prefix "aOrdreDeJuridiction"
    /// <summary>
    ///   <para>rdfs:label : aRegion^^xsd:string</para>
    ///   <para>rdfs:comment : Propriété liant quelque chose à une région^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#aRegion">osp:aRegion</a>
    /// </summary>
    let aRegion = _prefixId.prefix "aRegion"
    /// <summary>
    ///   <para>rdfs:label : a section^^xsd:string</para>
    ///   <para>rdfs:comment : Les chambres d'un tribunal sont décomposées en section^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#aSection">osp:aSection</a>
    /// </summary>
    let aSection = _prefixId.prefix "aSection"
    /// <summary>
    ///   <para>rdfs:label : Adresse d'un établissement de service public^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#adresse">osp:adresse</a>
    /// </summary>
    let adresse = _prefixId.prefix "adresse"
    /// <summary>
    ///   <para>rdfs:label : arrondissementDe^^xsd:string</para>
    ///   <para>rdfs:comment : Propriété liant un arrondissement à quelque chose^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#arrondissementDe">osp:arrondissementDe</a>
    /// </summary>
    let arrondissementDe = _prefixId.prefix "arrondissementDe"
    /// <summary>
    ///   <para>rdfs:label : est Chef d'Etat^^xsd:string</para>
    ///   <para>rdfs:comment : Propriété liant une personne au rôle de chef de l'Etat.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#chefDEtat">osp:chefDEtat</a>
    /// </summary>
    let chefDEtat = _prefixId.prefix "chefDEtat"
    /// <summary>
    ///   <para>rdfs:label : chef du gouvernement^^xsd:string</para>
    ///   <para>rdfs:comment : Une personne à la tête du gouvernement^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#chefDuGouvernement">osp:chefDuGouvernement</a>
    /// </summary>
    let chefDuGouvernement = _prefixId.prefix "chefDuGouvernement"
    /// <summary>
    ///   <para>rdfs:label : Commune de^^xsd:string</para>
    ///   <para>rdfs:comment : Propriété établissant un lien entre une commune et quelque chose.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#communeDe">osp:communeDe</a>
    /// </summary>
    let communeDe = _prefixId.prefix "communeDe"
    /// <summary>
    ///   <para>rdfs:label : compétence d'un juge^^xsd:string</para>
    ///   <para>rdfs:comment : Propriété liant un juge à sa fonction au sein du tribunal.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#competenceJuge">osp:competenceJuge</a>
    /// </summary>
    let competenceJuge = _prefixId.prefix "competenceJuge"
    /// <summary>
    ///   <para>rdfs:label : departementDe^^xsd:string</para>
    ///   <para>rdfs:comment : Propriété liant un département à quelque chose^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#departementDe">osp:departementDe</a>
    /// </summary>
    let departementDe = _prefixId.prefix "departementDe"
    /// <summary>
    ///   <para>rdfs:label : fax^^xsd:string</para>
    ///   <para>rdfs:comment : fax number^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#fax">osp:fax</a>
    /// </summary>
    let fax = _prefixId.prefix "fax"
    let felix = _prefixId.prefix "felix"
    let ``fran%C3%A7ois`` = _prefixId.prefix "fran%C3%A7ois"
    /// <summary>
    ///   <para>rdfs:label : has competence^^xsd:string</para>
    ///   <para>rdfs:comment : Compétence d'un juge dans un domaine.
    /// Ex : propriété intellectuelle, mer ...^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#hasCompetence">osp:hasCompetence</a>
    /// </summary>
    let hasCompetence = _prefixId.prefix "hasCompetence"
    /// <summary>
    ///   <para>rdfs:label : has head of gov^^xsd:string</para>
    ///   <para>rdfs:comment : Un service ou un pays à, dans un gouvernement démocratique, un chef de gouvernement^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#hasHeadOfGov">osp:hasHeadOfGov</a>
    /// </summary>
    let hasHeadOfGov = _prefixId.prefix "hasHeadOfGov"
    /// <summary>
    ///   <para>rdfs:label : has head of state^^xsd:string</para>
    ///   <para>rdfs:comment : Propriété définissant le chef d'Etat d'un pays^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#hasHeadOfState">osp:hasHeadOfState</a>
    /// </summary>
    let hasHeadOfState = _prefixId.prefix "hasHeadOfState"
    /// <summary>
    ///   <para>rdfs:label : has matter^^xsd:string</para>
    ///   <para>rdfs:comment : Propriété désignant la matière civile ou pénale que le tribunal revêt.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#hasMatter">osp:hasMatter</a>
    /// </summary>
    let hasMatter = _prefixId.prefix "hasMatter"
    /// <summary>
    ///   <para>rdfs:label : has president of tribunal^^xsd:string</para>
    ///   <para>rdfs:comment : Propriété définissant qu'un tribunal a un président^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#hasPresident">osp:hasPresident</a>
    /// </summary>
    let hasPresident = _prefixId.prefix "hasPresident"
    /// <summary>
    ///   <para>rdfs:label : hyperlien Evenement^^xsd:string</para>
    ///   <para>rdfs:comment : Correspond au lien vers un évènement particulier^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#hyperlienEvenement">osp:hyperlienEvenement</a>
    /// </summary>
    let hyperlienEvenement = _prefixId.prefix "hyperlienEvenement"
    /// <summary>
    ///   <para>rdfs:label : Initiales de^^xsd:string</para>
    ///   <para>rdfs:comment : Propriété liant quelque chose à ses initiales.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#initialesDe">osp:initialesDe</a>
    /// </summary>
    let initialesDe = _prefixId.prefix "initialesDe"
    /// <summary>
    ///   <para>rdfs:label : initials^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#initials">osp:initials</a>
    /// </summary>
    let initials = _prefixId.prefix "initials"
    /// <summary>
    ///   <para>rdfs:label : Ligne pour une adresse (ex: rue, numéro)^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#ligneAdresse">osp:ligneAdresse</a>
    /// </summary>
    let ligneAdresse = _prefixId.prefix "ligneAdresse"
    /// <summary>
    ///   <para>rdfs:label : Numéro de fax^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#numeroFax">osp:numeroFax</a>
    /// </summary>
    let numeroFax = _prefixId.prefix "numeroFax"
    /// <summary>
    ///   <para>rdfs:label : ordre de juridiction^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#ordreDeJuridiction">osp:ordreDeJuridiction</a>
    /// </summary>
    let ordreDeJuridiction = _prefixId.prefix "ordreDeJuridiction"
    let rdf = _prefixId.prefix "rdf"
    /// <summary>
    ///   <para>rdfs:label : regionDe^^xsd:string</para>
    ///   <para>rdfs:comment : Propriété liant une région à quelque chose^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#regionDe">osp:regionDe</a>
    /// </summary>
    let regionDe = _prefixId.prefix "regionDe"
    /// <summary>
    ///   <para>rdfs:label : Sous l'autorite de^^xsd:string</para>
    ///   <para>rdfs:comment : propriété instaurant la hiérarchie entre un organisme et un service. Ne pas confondre avec des sous ensemble d'un même service^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#sousLAutoriteDe">osp:sousLAutoriteDe</a>
    /// </summary>
    let sousLAutoriteDe = _prefixId.prefix "sousLAutoriteDe"
    let ttl = _prefixId.prefix "ttl"
    /// <summary>
    ///   <para>rdfs:label : type du tribunal^^xsd:string</para>
    ///   <para>rdfs:comment : Propriété définissant quel type de tribunal il s'agit. Ex : tribunal d'instance, TGI ...^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/osp#typeTribunal">osp:typeTribunal</a>
    /// </summary>
    let typeTribunal = _prefixId.prefix "typeTribunal"
