namespace http.data.lirmm.fr.ontologies.osp.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module osp =
    let _namespace_iri = Namespace_Iri osp |> NamespaceIRI
    /// <summary>
    ///   <para>osp:Administration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"L'administration est dans le prolongement de l'administration. Elle est chargée de régler les affaires courantes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Administration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#Administration">http://data.lirmm.fr/ontologies/osp#Administration</seealso>
    let Administration = Prefixed_Name(osp, "Administration") |> PrefixedName
    /// <summary>
    ///   <para>osp:Adresse</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Classe décrivant une adresse postale"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#Adresse">http://data.lirmm.fr/ontologies/osp#Adresse</seealso>
    let Adresse = Prefixed_Name(osp, "Adresse") |> PrefixedName
    /// <summary>
    ///   <para>osp:Ambassade</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Ambassade"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#Ambassade">http://data.lirmm.fr/ontologies/osp#Ambassade</seealso>
    let Ambassade = Prefixed_Name(osp, "Ambassade") |> PrefixedName
    /// <summary>
    ///   <para>osp:ChefDEtat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Classe décrivant le chef d'Etat. La réalité de son pouvoir n'est pas le critère retenu mais ce qui apparait dans les textes. Ex : La reine d'Angleterre."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"chef d'Etat"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#ChefDEtat">http://data.lirmm.fr/ontologies/osp#ChefDEtat</seealso>
    let ChefDEtat = Prefixed_Name(osp, "ChefDEtat") |> PrefixedName
    /// <summary>
    ///   <para>osp:ChefDuGouvernement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Classe décrivant un chef de gouvernement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Chef du gouvernement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#ChefDuGouvernement">http://data.lirmm.fr/ontologies/osp#ChefDuGouvernement</seealso>
    let ChefDuGouvernement = Prefixed_Name(osp, "ChefDuGouvernement") |> PrefixedName
    /// <summary>
    ///   <para>osp:Gouvernement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Le gouvernement est un des organes issus de la séparation des pouvoirs"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Gouvernment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#Gouvernement">http://data.lirmm.fr/ontologies/osp#Gouvernement</seealso>
    let Gouvernement = Prefixed_Name(osp, "Gouvernement") |> PrefixedName
    /// <summary>
    ///   <para>osp:Juge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"La classe Juge représente la fonction de juge au sein d'un tribunal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Juge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#Juge">http://data.lirmm.fr/ontologies/osp#Juge</seealso>
    let Juge = Prefixed_Name(osp, "Juge") |> PrefixedName
    /// <summary>
    ///   <para>osp:LIRMM</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:Agent</para>
    /// </remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#LIRMM">http://data.lirmm.fr/ontologies/osp#LIRMM</seealso>
    let LIRMM = Prefixed_Name(osp, "LIRMM") |> PrefixedName
    /// <summary>
    ///   <para>osp:Mairie</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Bâtiment officiel de l'Etat français où réside le maire et le conseil municipal. Il fait partit de l'administration décentralisée."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mairie"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#Mairie">http://data.lirmm.fr/ontologies/osp#Mairie</seealso>
    let Mairie = Prefixed_Name(osp, "Mairie") |> PrefixedName
    /// <summary>
    ///   <para>osp:Ministre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Classe décrivant une personne ayant un rôle de ministre dans un gouvernement."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ministre"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#Ministre">http://data.lirmm.fr/ontologies/osp#Ministre</seealso>
    let Ministre = Prefixed_Name(osp, "Ministre") |> PrefixedName

    /// <summary>
    ///   <para>osp:OrganisationEtatique</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"La classe stateservice a pour but de différencier un Etat ou une organisation d'Etat d'une entreprise privée."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Organisation Etatique"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#OrganisationEtatique">http://data.lirmm.fr/ontologies/osp#OrganisationEtatique</seealso>
    let OrganisationEtatique =
        Prefixed_Name(osp, "OrganisationEtatique") |> PrefixedName

    /// <summary>
    ///   <para>osp:OrganisationPublique</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Regroupe les structure qui ne correspondent pas à un niveau étatique mais inter étatique ou extra étatique (ex : les ONG)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Organisation publique"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#OrganisationPublique">http://data.lirmm.fr/ontologies/osp#OrganisationPublique</seealso>
    let OrganisationPublique =
        Prefixed_Name(osp, "OrganisationPublique") |> PrefixedName

    /// <summary>
    ///   <para>osp:PouvoirExecutif</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Le pouvoir exécutif a pour charge d'exécuter les décisions de justice issues du pouvoir judiciaire et d'appliquer les lois votées par le pouvoir législatif."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"pouvoir exécutif"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#PouvoirExecutif">http://data.lirmm.fr/ontologies/osp#PouvoirExecutif</seealso>
    let PouvoirExecutif = Prefixed_Name(osp, "PouvoirExecutif") |> PrefixedName
    /// <summary>
    ///   <para>osp:PouvoirJudiciaire</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Branche judiciaire d'une organisation étatique"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Pouvoir judiciaire"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#PouvoirJudiciaire">http://data.lirmm.fr/ontologies/osp#PouvoirJudiciaire</seealso>
    let PouvoirJudiciaire = Prefixed_Name(osp, "PouvoirJudiciaire") |> PrefixedName
    /// <summary>
    ///   <para>osp:PouvoirLegislatif</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Définie la fonction législative d'un pays"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Pouvoir législatif"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#PouvoirLegislatif">http://data.lirmm.fr/ontologies/osp#PouvoirLegislatif</seealso>
    let PouvoirLegislatif = Prefixed_Name(osp, "PouvoirLegislatif") |> PrefixedName
    /// <summary>
    ///   <para>osp:SecretairedEtat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Il existe bien un secretary of state dans les autres pays mais n'a rien à voir avec la qualification de secretaire d'Etat en France"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Secretaire d'Etat"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#SecretairedEtat">http://data.lirmm.fr/ontologies/osp#SecretairedEtat</seealso>
    let SecretairedEtat = Prefixed_Name(osp, "SecretairedEtat") |> PrefixedName
    /// <summary>
    ///   <para>osp:Tribunal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Le tribunal est un bâtiment public où la justice y est rendu par des juges."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"tribunal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#Tribunal">http://data.lirmm.fr/ontologies/osp#Tribunal</seealso>
    let Tribunal = Prefixed_Name(osp, "Tribunal") |> PrefixedName
    /// <summary>
    ///   <para>osp:aArrondissement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Propriété liant quelque chose à un département. Inverse de arrondissementDe."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"aArrondissement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#aArrondissement">http://data.lirmm.fr/ontologies/osp#aArrondissement</seealso>
    let aArrondissement = Prefixed_Name(osp, "aArrondissement") |> PrefixedName
    /// <summary>
    ///   <para>osp:aAutoriteSur</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Propriété définissant une autorité hiérarchique d'une organization sur une autre. Cette autorité est de préférence issue de textes légaux.
    ///
    /// Ne pas confondre autorité et sous organisme. Ex :
    /// Un ministère a un cabinet (on utilisera suborganization de @org)
    /// Le ministère de l'éducation exerce une autorité sur les écoles."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"a autorité sur"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#aAutoriteSur">http://data.lirmm.fr/ontologies/osp#aAutoriteSur</seealso>
    let aAutoriteSur = Prefixed_Name(osp, "aAutoriteSur") |> PrefixedName
    /// <summary>
    ///   <para>osp:aChambre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Les chambres divisent un tribunal, souvent de façon thématique (droit de la construction, droit de la co-propriété)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"a chambre"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#aChambre">http://data.lirmm.fr/ontologies/osp#aChambre</seealso>
    let aChambre = Prefixed_Name(osp, "aChambre") |> PrefixedName
    /// <summary>
    ///   <para>osp:aCommune</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Propriété établissant un lien entre quelque chose et une commune"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"a commune"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#aCommune">http://data.lirmm.fr/ontologies/osp#aCommune</seealso>
    let aCommune = Prefixed_Name(osp, "aCommune") |> PrefixedName

    /// <summary>
    ///   <para>osp:aCompetenceTerritoriale</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Propriété permettant la hiérarchisation du terrain couvert par un organisme. Généralement : régional, national, international."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"A Competence Territoriale"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#aCompetenceTerritoriale">http://data.lirmm.fr/ontologies/osp#aCompetenceTerritoriale</seealso>
    let aCompetenceTerritoriale =
        Prefixed_Name(osp, "aCompetenceTerritoriale") |> PrefixedName

    /// <summary>
    ///   <para>osp:aDegre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Le système juridictionnel français est composé de 2 degrés et d'une haute juridiction. La haute juridiction n'est pas un degre. Nous l'a comptons néanmoins ainsi pour simplifier l'utilisation pour d'autres systèmes. 1er degré, 2nd degré ou haute juridiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"a degre"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#aDegre">http://data.lirmm.fr/ontologies/osp#aDegre</seealso>
    let aDegre = Prefixed_Name(osp, "aDegre") |> PrefixedName
    /// <summary>
    ///   <para>osp:aEvenement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Propriété permettant de lier quelque chose à un évènement tel qu'il est définie dans l'ontologie ical."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"A evenement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#aEvenement">http://data.lirmm.fr/ontologies/osp#aEvenement</seealso>
    let aEvenement = Prefixed_Name(osp, "aEvenement") |> PrefixedName
    /// <summary>
    ///   <para>osp:aInitiales</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"propriété décrivant les initials d'une entreprise, d'un pays ... ex : RU, SNCF ...
    /// sameAs hashtag oegov"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"a initiales"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#aInitiales">http://data.lirmm.fr/ontologies/osp#aInitiales</seealso>
    let aInitiales = Prefixed_Name(osp, "aInitiales") |> PrefixedName
    /// <summary>
    ///   <para>osp:aOrdreDeJuridiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Propriété apportant la distinction entre ordre administratif ou judiciaire pour un tribunal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"A ordre de juridiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#aOrdreDeJuridiction">http://data.lirmm.fr/ontologies/osp#aOrdreDeJuridiction</seealso>
    let aOrdreDeJuridiction = Prefixed_Name(osp, "aOrdreDeJuridiction") |> PrefixedName
    /// <summary>
    ///   <para>osp:aRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Propriété liant quelque chose à une région"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"aRegion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#aRegion">http://data.lirmm.fr/ontologies/osp#aRegion</seealso>
    let aRegion = Prefixed_Name(osp, "aRegion") |> PrefixedName
    /// <summary>
    ///   <para>osp:aSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Les chambres d'un tribunal sont décomposées en section"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"a section"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#aSection">http://data.lirmm.fr/ontologies/osp#aSection</seealso>
    let aSection = Prefixed_Name(osp, "aSection") |> PrefixedName
    /// <summary>
    ///   <para>osp:adresse</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Adresse d'un établissement de service public"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#adresse">http://data.lirmm.fr/ontologies/osp#adresse</seealso>
    let adresse = Prefixed_Name(osp, "adresse") |> PrefixedName
    /// <summary>
    ///   <para>osp:arrondissementDe</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Propriété liant un arrondissement à quelque chose"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"arrondissementDe"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#arrondissementDe">http://data.lirmm.fr/ontologies/osp#arrondissementDe</seealso>
    let arrondissementDe = Prefixed_Name(osp, "arrondissementDe") |> PrefixedName
    /// <summary>
    ///   <para>osp:chefDEtat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Propriété liant une personne au rôle de chef de l'Etat."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"est Chef d'Etat"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#chefDEtat">http://data.lirmm.fr/ontologies/osp#chefDEtat</seealso>
    let chefDEtat = Prefixed_Name(osp, "chefDEtat") |> PrefixedName
    /// <summary>
    ///   <para>osp:chefDuGouvernement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Une personne à la tête du gouvernement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"chef du gouvernement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#chefDuGouvernement">http://data.lirmm.fr/ontologies/osp#chefDuGouvernement</seealso>
    let chefDuGouvernement = Prefixed_Name(osp, "chefDuGouvernement") |> PrefixedName
    /// <summary>
    ///   <para>osp:communeDe</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Propriété établissant un lien entre une commune et quelque chose."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Commune de"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#communeDe">http://data.lirmm.fr/ontologies/osp#communeDe</seealso>
    let communeDe = Prefixed_Name(osp, "communeDe") |> PrefixedName
    /// <summary>
    ///   <para>osp:competenceJuge</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Propriété liant un juge à sa fonction au sein du tribunal."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"compétence d'un juge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#competenceJuge">http://data.lirmm.fr/ontologies/osp#competenceJuge</seealso>
    let competenceJuge = Prefixed_Name(osp, "competenceJuge") |> PrefixedName
    /// <summary>
    ///   <para>osp:departementDe</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Propriété liant un département à quelque chose"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"departementDe"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#departementDe">http://data.lirmm.fr/ontologies/osp#departementDe</seealso>
    let departementDe = Prefixed_Name(osp, "departementDe") |> PrefixedName
    /// <summary>
    ///   <para>osp:fax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"fax number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"fax"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#fax">http://data.lirmm.fr/ontologies/osp#fax</seealso>
    let fax = Prefixed_Name(osp, "fax") |> PrefixedName
    /// <summary>
    ///   <para>osp:felix</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#felix">http://data.lirmm.fr/ontologies/osp#felix</seealso>
    let felix = Prefixed_Name(osp, "felix") |> PrefixedName
    /// <summary>
    ///   <para>osp:fran%C3%A7ois</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#fran%C3%A7ois">http://data.lirmm.fr/ontologies/osp#fran%C3%A7ois</seealso>
    let ``fran%C3%A7ois`` = Prefixed_Name(osp, "fran%C3%A7ois") |> PrefixedName
    /// <summary>
    ///   <para>osp:hasCompetence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Compétence d'un juge dans un domaine.
    /// Ex : propriété intellectuelle, mer ..."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has competence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#hasCompetence">http://data.lirmm.fr/ontologies/osp#hasCompetence</seealso>
    let hasCompetence = Prefixed_Name(osp, "hasCompetence") |> PrefixedName
    /// <summary>
    ///   <para>osp:hasHeadOfGov</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Un service ou un pays à, dans un gouvernement démocratique, un chef de gouvernement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has head of gov"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#hasHeadOfGov">http://data.lirmm.fr/ontologies/osp#hasHeadOfGov</seealso>
    let hasHeadOfGov = Prefixed_Name(osp, "hasHeadOfGov") |> PrefixedName
    /// <summary>
    ///   <para>osp:hasHeadOfState</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Propriété définissant le chef d'Etat d'un pays"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has head of state"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#hasHeadOfState">http://data.lirmm.fr/ontologies/osp#hasHeadOfState</seealso>
    let hasHeadOfState = Prefixed_Name(osp, "hasHeadOfState") |> PrefixedName
    /// <summary>
    ///   <para>osp:hasMatter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Propriété désignant la matière civile ou pénale que le tribunal revêt."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has matter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#hasMatter">http://data.lirmm.fr/ontologies/osp#hasMatter</seealso>
    let hasMatter = Prefixed_Name(osp, "hasMatter") |> PrefixedName
    /// <summary>
    ///   <para>osp:hasPresident</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Propriété définissant qu'un tribunal a un président"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has president of tribunal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#hasPresident">http://data.lirmm.fr/ontologies/osp#hasPresident</seealso>
    let hasPresident = Prefixed_Name(osp, "hasPresident") |> PrefixedName
    /// <summary>
    ///   <para>osp:hyperlienEvenement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Correspond au lien vers un évènement particulier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hyperlien Evenement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#hyperlienEvenement">http://data.lirmm.fr/ontologies/osp#hyperlienEvenement</seealso>
    let hyperlienEvenement = Prefixed_Name(osp, "hyperlienEvenement") |> PrefixedName
    /// <summary>
    ///   <para>osp:initialesDe</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Propriété liant quelque chose à ses initiales."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Initiales de"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#initialesDe">http://data.lirmm.fr/ontologies/osp#initialesDe</seealso>
    let initialesDe = Prefixed_Name(osp, "initialesDe") |> PrefixedName
    /// <summary>
    ///   <para>osp:initials</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"initials"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#initials">http://data.lirmm.fr/ontologies/osp#initials</seealso>
    let initials = Prefixed_Name(osp, "initials") |> PrefixedName
    /// <summary>
    ///   <para>osp:ligneAdresse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Ligne pour une adresse (ex: rue, numéro)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#ligneAdresse">http://data.lirmm.fr/ontologies/osp#ligneAdresse</seealso>
    let ligneAdresse = Prefixed_Name(osp, "ligneAdresse") |> PrefixedName
    /// <summary>
    ///   <para>osp:numeroFax</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Numéro de fax"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#numeroFax">http://data.lirmm.fr/ontologies/osp#numeroFax</seealso>
    let numeroFax = Prefixed_Name(osp, "numeroFax") |> PrefixedName
    /// <summary>
    ///   <para>osp:ordreDeJuridiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"ordre de juridiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#ordreDeJuridiction">http://data.lirmm.fr/ontologies/osp#ordreDeJuridiction</seealso>
    let ordreDeJuridiction = Prefixed_Name(osp, "ordreDeJuridiction") |> PrefixedName
    /// <summary>
    ///   <para>osp:rdf</para>
    /// </summary>
    /// <remarks>
    ///   <para>adms:SemanticDistribution</para>
    /// </remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#rdf">http://data.lirmm.fr/ontologies/osp#rdf</seealso>
    let rdf = Prefixed_Name(osp, "rdf") |> PrefixedName
    /// <summary>
    ///   <para>osp:regionDe</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Propriété liant une région à quelque chose"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"regionDe"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#regionDe">http://data.lirmm.fr/ontologies/osp#regionDe</seealso>
    let regionDe = Prefixed_Name(osp, "regionDe") |> PrefixedName
    /// <summary>
    ///   <para>osp:sousLAutoriteDe</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"propriété instaurant la hiérarchie entre un organisme et un service. Ne pas confondre avec des sous ensemble d'un même service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sous l'autorite de"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#sousLAutoriteDe">http://data.lirmm.fr/ontologies/osp#sousLAutoriteDe</seealso>
    let sousLAutoriteDe = Prefixed_Name(osp, "sousLAutoriteDe") |> PrefixedName
    /// <summary>
    ///   <para>osp:ttl</para>
    /// </summary>
    /// <remarks>
    ///   <para>adms:SemanticDistribution</para>
    /// </remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#ttl">http://data.lirmm.fr/ontologies/osp#ttl</seealso>
    let ttl = Prefixed_Name(osp, "ttl") |> PrefixedName
    /// <summary>
    ///   <para>osp:typeTribunal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Propriété définissant quel type de tribunal il s'agit. Ex : tribunal d'instance, TGI ..."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"type du tribunal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/osp#typeTribunal">http://data.lirmm.fr/ontologies/osp#typeTribunal</seealso>
    let typeTribunal = Prefixed_Name(osp, "typeTribunal") |> PrefixedName
