#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module igeo =
    let _prefixId = PrefixId.fromNamespaceLabel "http://rdf.insee.fr/def/geo#" "igeo"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Aire urbaine</para>
    ///   <a href="http://rdf.insee.fr/def/geo#AireUrbaine">igeo:AireUrbaine</a>
    /// </summary>
    let AireUrbaine = _prefixId.prefix "AireUrbaine"
    /// <summary>
    ///   <para>rdfs:label : Arrondissement</para>
    ///   <a href="http://rdf.insee.fr/def/geo#Arrondissement">igeo:Arrondissement</a>
    /// </summary>
    let Arrondissement = _prefixId.prefix "Arrondissement"
    /// <summary>
    ///   <para>rdfs:label : Arrondissement municipal</para>
    ///   <para>rdfs:comment : Cette classe n'est utilisée que pour les arrondissements de Paris, Lyon et Marseille</para>
    ///   <a href="http://rdf.insee.fr/def/geo#ArrondissementMunicipal">igeo:ArrondissementMunicipal</a>
    /// </summary>
    let ArrondissementMunicipal = _prefixId.prefix "ArrondissementMunicipal"
    /// <summary>
    ///   <para>rdfs:label : Canton</para>
    ///   <para>rdfs:comment : Canton français, circonscription d'élection des conseillers généraux</para>
    ///   <a href="http://rdf.insee.fr/def/geo#Canton">igeo:Canton</a>
    /// </summary>
    let Canton = _prefixId.prefix "Canton"
    /// <summary>
    ///   <para>rdfs:label : Canton-ou-ville</para>
    ///   <para>rdfs:comment : Dit aussi 'pseudo-canton', c'est un regroupement d'une ou plusieurs communes entières</para>
    ///   <a href="http://rdf.insee.fr/def/geo#CantonOuVille">igeo:CantonOuVille</a>
    /// </summary>
    let CantonOuVille = _prefixId.prefix "CantonOuVille"

    /// <summary>
    ///   <para>rdfs:label : Changement de département ou d'arrondissement</para>
    ///   <para>rdfs:comment : Changement de rattachement administratif d'une commune</para>
    ///   <a href="http://rdf.insee.fr/def/geo#ChangementDeDepartementOuArrondissement">igeo:ChangementDeDepartementOuArrondissement</a>
    /// </summary>
    let ChangementDeDepartementOuArrondissement =
        _prefixId.prefix "ChangementDeDepartementOuArrondissement"

    /// <summary>
    ///   <para>rdfs:label : Changement de nom</para>
    ///   <para>rdfs:comment : Changement de l'intitulé du territoire</para>
    ///   <a href="http://rdf.insee.fr/def/geo#ChangementDeNom">igeo:ChangementDeNom</a>
    /// </summary>
    let ChangementDeNom = _prefixId.prefix "ChangementDeNom"
    /// <summary>
    ///   <para>rdfs:label : Collectivité territoriale</para>
    ///   <para>rdfs:comment : Collectivité territoriale d'outre-mer. Inclut les TOM et les territoires à statut particulier.</para>
    ///   <a href="http://rdf.insee.fr/def/geo#CollectiviteTerritoriale">igeo:CollectiviteTerritoriale</a>
    /// </summary>
    let CollectiviteTerritoriale = _prefixId.prefix "CollectiviteTerritoriale"
    /// <summary>
    ///   <para>rdfs:label : Commune</para>
    ///   <a href="http://rdf.insee.fr/def/geo#Commune">igeo:Commune</a>
    /// </summary>
    let Commune = _prefixId.prefix "Commune"
    /// <summary>
    ///   <para>rdfs:label : Création ou rétablissement</para>
    ///   <para>rdfs:comment : Création ou rétablissemnt d'un territoire</para>
    ///   <a href="http://rdf.insee.fr/def/geo#CreationOuRetablissement">igeo:CreationOuRetablissement</a>
    /// </summary>
    let CreationOuRetablissement = _prefixId.prefix "CreationOuRetablissement"
    /// <summary>
    ///   <para>rdfs:label : Département</para>
    ///   <a href="http://rdf.insee.fr/def/geo#Departement">igeo:Departement</a>
    /// </summary>
    let Departement = _prefixId.prefix "Departement"
    /// <summary>
    ///   <para>rdfs:label : Déplacement de limites d'IRIS</para>
    ///   <a href="http://rdf.insee.fr/def/geo#DeplacementDeLimitesDIRIS">igeo:DeplacementDeLimitesDIRIS</a>
    /// </summary>
    let DeplacementDeLimitesDIRIS = _prefixId.prefix "DeplacementDeLimitesDIRIS"
    /// <summary>
    ///   <para>rdfs:label : EPCI</para>
    ///   <para>rdfs:comment : Établissement public de coopération intercommunale</para>
    ///   <a href="http://rdf.insee.fr/def/geo#EPCI">igeo:EPCI</a>
    /// </summary>
    let EPCI = _prefixId.prefix "EPCI"
    /// <summary>
    ///   <para>rdfs:label : Échange de parcelles</para>
    ///   <para>rdfs:comment : Échange de parcelles entre territoires</para>
    ///   <a href="http://rdf.insee.fr/def/geo#EchangeDeParcelles">igeo:EchangeDeParcelles</a>
    /// </summary>
    let EchangeDeParcelles = _prefixId.prefix "EchangeDeParcelles"

    /// <summary>
    ///   <para>rdfs:label : Échange de parcelles entre communes irisées</para>
    ///   <a href="http://rdf.insee.fr/def/geo#EchangeParcellesCommunesIrisees">igeo:EchangeParcellesCommunesIrisees</a>
    /// </summary>
    let EchangeParcellesCommunesIrisees =
        _prefixId.prefix "EchangeParcellesCommunesIrisees"

    /// <summary>
    ///   <para>rdfs:label : Échange de parcelles habitées entre communes irisées et non irisées</para>
    ///   <a href="http://rdf.insee.fr/def/geo#EchangeParcellesHabiteesCommunesIriseesNonIrisees">igeo:EchangeParcellesHabiteesCommunesIriseesNonIrisees</a>
    /// </summary>
    let EchangeParcellesHabiteesCommunesIriseesNonIrisees =
        _prefixId.prefix "EchangeParcellesHabiteesCommunesIriseesNonIrisees"

    /// <summary>
    ///   <para>rdfs:label : Échange de parcelles inhabitées entre communes irisées et non irisées</para>
    ///   <a href="http://rdf.insee.fr/def/geo#EchangeParcellesInhabiteesCommunesIriseesNonIrisees">igeo:EchangeParcellesInhabiteesCommunesIriseesNonIrisees</a>
    /// </summary>
    let EchangeParcellesInhabiteesCommunesIriseesNonIrisees =
        _prefixId.prefix "EchangeParcellesInhabiteesCommunesIriseesNonIrisees"

    /// <summary>
    ///   <para>rdfs:label : Fusion de communes irisées</para>
    ///   <a href="http://rdf.insee.fr/def/geo#FusionDeCommunesIrisees">igeo:FusionDeCommunesIrisees</a>
    /// </summary>
    let FusionDeCommunesIrisees = _prefixId.prefix "FusionDeCommunesIrisees"
    /// <summary>
    ///   <para>rdfs:label : Grand Quartier</para>
    ///   <a href="http://rdf.insee.fr/def/geo#GrandQuartier">igeo:GrandQuartier</a>
    /// </summary>
    let GrandQuartier = _prefixId.prefix "GrandQuartier"
    /// <summary>
    ///   <para>rdfs:label : Groupement de pays</para>
    ///   <para>rdfs:comment : Exemples : Communauté Européenne, OCDE, OTAN, Pays arabes ...</para>
    ///   <a href="http://rdf.insee.fr/def/geo#GroupementDePays">igeo:GroupementDePays</a>
    /// </summary>
    let GroupementDePays = _prefixId.prefix "GroupementDePays"

    /// <summary>
    ///   <para>rdfs:label : Groupement statistique de communes</para>
    ///   <para>rdfs:comment : Modélise des zonages divers d'intérêt statistique</para>
    ///   <a href="http://rdf.insee.fr/def/geo#GroupementStatistiqueDeCommunes">igeo:GroupementStatistiqueDeCommunes</a>
    /// </summary>
    let GroupementStatistiqueDeCommunes =
        _prefixId.prefix "GroupementStatistiqueDeCommunes"

    /// <summary>
    ///   <para>rdfs:label : IRIS</para>
    ///   <para>rdfs:comment : Îlot regroupé pour l'information statistique</para>
    ///   <a href="http://rdf.insee.fr/def/geo#IRIS">igeo:IRIS</a>
    /// </summary>
    let IRIS = _prefixId.prefix "IRIS"
    /// <summary>
    ///   <para>rdfs:label : Unité Administrative Localerdfs:label : Local Administrative Unit</para>
    ///   <a href="http://rdf.insee.fr/def/geo#LAU">igeo:LAU</a>
    /// </summary>
    let LAU = _prefixId.prefix "LAU"
    /// <summary>
    ///   <para>rdfs:label : LAU 1^^xsd:string</para>
    ///   <a href="http://rdf.insee.fr/def/geo#LAU1">igeo:LAU1</a>
    /// </summary>
    let LAU1 = _prefixId.prefix "LAU1"
    /// <summary>
    ///   <para>rdfs:label : LAU 2^^xsd:string</para>
    ///   <a href="http://rdf.insee.fr/def/geo#LAU2">igeo:LAU2</a>
    /// </summary>
    let LAU2 = _prefixId.prefix "LAU2"
    /// <summary>
    ///   <para>rdfs:label : Modification cantonale</para>
    ///   <para>rdfs:comment : Modification de la structure d'un ou plusieurs cantons</para>
    ///   <a href="http://rdf.insee.fr/def/geo#ModificationCantonale">igeo:ModificationCantonale</a>
    /// </summary>
    let ModificationCantonale = _prefixId.prefix "ModificationCantonale"
    /// <summary>
    ///   <para>rdfs:label : Modification IRIS</para>
    ///   <a href="http://rdf.insee.fr/def/geo#ModificationDIRIS">igeo:ModificationDIRIS</a>
    /// </summary>
    let ModificationDIRIS = _prefixId.prefix "ModificationDIRIS"
    /// <summary>
    ///   <para>rdfs:label : Modification de groupement</para>
    ///   <a href="http://rdf.insee.fr/def/geo#ModificationDeGroupement">igeo:ModificationDeGroupement</a>
    /// </summary>
    let ModificationDeGroupement = _prefixId.prefix "ModificationDeGroupement"
    /// <summary>
    ///   <para>rdfs:label : Modification territoriale</para>
    ///   <para>rdfs:comment : Classe générique de tous les événements liés à la création ou à la modification de territoires</para>
    ///   <a href="http://rdf.insee.fr/def/geo#ModificationTerritoriale">igeo:ModificationTerritoriale</a>
    /// </summary>
    let ModificationTerritoriale = _prefixId.prefix "ModificationTerritoriale"
    /// <summary>
    ///   <para>rdfs:label : Unité Territoriale Statistique</para>
    ///   <a href="http://rdf.insee.fr/def/geo#NUTS">igeo:NUTS</a>
    /// </summary>
    let NUTS = _prefixId.prefix "NUTS"
    /// <summary>
    ///   <para>rdfs:label : NUTS 1^^xsd:string</para>
    ///   <a href="http://rdf.insee.fr/def/geo#NUTS1">igeo:NUTS1</a>
    /// </summary>
    let NUTS1 = _prefixId.prefix "NUTS1"
    /// <summary>
    ///   <para>rdfs:label : NUTS 2^^xsd:string</para>
    ///   <a href="http://rdf.insee.fr/def/geo#NUTS2">igeo:NUTS2</a>
    /// </summary>
    let NUTS2 = _prefixId.prefix "NUTS2"
    /// <summary>
    ///   <para>rdfs:label : NUTS 3^^xsd:string</para>
    ///   <a href="http://rdf.insee.fr/def/geo#NUTS3">igeo:NUTS3</a>
    /// </summary>
    let NUTS3 = _prefixId.prefix "NUTS3"
    /// <summary>
    ///   <para>rdfs:label : Pays</para>
    ///   <a href="http://rdf.insee.fr/def/geo#Pays">igeo:Pays</a>
    /// </summary>
    let Pays = _prefixId.prefix "Pays"
    /// <summary>
    ///   <para>rdfs:label : Pays ou territoire</para>
    ///   <para>rdfs:comment : Pays ou subdivision géopolitique d'un pays</para>
    ///   <a href="http://rdf.insee.fr/def/geo#PaysOuTerritoire">igeo:PaysOuTerritoire</a>
    /// </summary>
    let PaysOuTerritoire = _prefixId.prefix "PaysOuTerritoire"
    /// <summary>
    ///   <para>rdfs:label : Région</para>
    ///   <para>rdfs:comment : Région française de métropole ou d'outre-mer</para>
    ///   <a href="http://rdf.insee.fr/def/geo#Region">igeo:Region</a>
    /// </summary>
    let Region = _prefixId.prefix "Region"

    /// <summary>
    ///   <para>rdfs:label : Rétablissement de communes issues de communes irisées</para>
    ///   <a href="http://rdf.insee.fr/def/geo#RetablissementCommunesIssuesDeCommuneIrisees">igeo:RetablissementCommunesIssuesDeCommuneIrisees</a>
    /// </summary>
    let RetablissementCommunesIssuesDeCommuneIrisees =
        _prefixId.prefix "RetablissementCommunesIssuesDeCommuneIrisees"

    /// <summary>
    ///   <para>rdfs:label : Scission d'IRIS</para>
    ///   <a href="http://rdf.insee.fr/def/geo#ScissionDIRIS">igeo:ScissionDIRIS</a>
    /// </summary>
    let ScissionDIRIS = _prefixId.prefix "ScissionDIRIS"
    /// <summary>
    ///   <para>rdfs:label : Suppression-fusion</para>
    ///   <para>rdfs:comment : Suppression ou fusion de territoires</para>
    ///   <a href="http://rdf.insee.fr/def/geo#SuppressionFusion">igeo:SuppressionFusion</a>
    /// </summary>
    let SuppressionFusion = _prefixId.prefix "SuppressionFusion"
    /// <summary>
    ///   <para>rdfs:label : TRIRIS</para>
    ///   <a href="http://rdf.insee.fr/def/geo#TRIRIS">igeo:TRIRIS</a>
    /// </summary>
    let TRIRIS = _prefixId.prefix "TRIRIS"
    /// <summary>
    ///   <para>rdfs:label : Territoire administratif</para>
    ///   <para>rdfs:comment : Subdivision administrative du territoire français</para>
    ///   <a href="http://rdf.insee.fr/def/geo#TerritoireAdministratif">igeo:TerritoireAdministratif</a>
    /// </summary>
    let TerritoireAdministratif = _prefixId.prefix "TerritoireAdministratif"
    /// <summary>
    ///   <para>rdfs:label : Territoire français</para>
    ///   <para>rdfs:comment : Subdivision administrative ou statistique du territoire français</para>
    ///   <a href="http://rdf.insee.fr/def/geo#TerritoireFrancais">igeo:TerritoireFrancais</a>
    /// </summary>
    let TerritoireFrancais = _prefixId.prefix "TerritoireFrancais"
    /// <summary>
    ///   <para>rdfs:label : Territoire statistique</para>
    ///   <para>rdfs:comment : Subdivision du territoire français utilisée pour la production de statistiques</para>
    ///   <a href="http://rdf.insee.fr/def/geo#TerritoireStatistique">igeo:TerritoireStatistique</a>
    /// </summary>
    let TerritoireStatistique = _prefixId.prefix "TerritoireStatistique"
    /// <summary>
    ///   <para>rdfs:label : Transfert de chef-lieu</para>
    ///   <para>rdfs:comment : Changement de la commune chef-lieu d'un territoire</para>
    ///   <a href="http://rdf.insee.fr/def/geo#TransfertDeChefLieu">igeo:TransfertDeChefLieu</a>
    /// </summary>
    let TransfertDeChefLieu = _prefixId.prefix "TransfertDeChefLieu"
    /// <summary>
    ///   <para>rdfs:label : Type d'EPCI</para>
    ///   <a href="http://rdf.insee.fr/def/geo#TypeDEPCI">igeo:TypeDEPCI</a>
    /// </summary>
    let TypeDEPCI = _prefixId.prefix "TypeDEPCI"
    /// <summary>
    ///   <para>rdfs:label : Type d'IRIS</para>
    ///   <a href="http://rdf.insee.fr/def/geo#TypeDIRIS">igeo:TypeDIRIS</a>
    /// </summary>
    let TypeDIRIS = _prefixId.prefix "TypeDIRIS"
    /// <summary>
    ///   <para>rdfs:label : Unité urbaine</para>
    ///   <a href="http://rdf.insee.fr/def/geo#UniteUrbaine">igeo:UniteUrbaine</a>
    /// </summary>
    let UniteUrbaine = _prefixId.prefix "UniteUrbaine"
    /// <summary>
    ///   <para>rdfs:label : Zone d'emploi</para>
    ///   <a href="http://rdf.insee.fr/def/geo#ZoneDEmploi">igeo:ZoneDEmploi</a>
    /// </summary>
    let ZoneDEmploi = _prefixId.prefix "ZoneDEmploi"
    /// <summary>
    ///   <para>rdfs:label : ancien chef-lieu</para>
    ///   <a href="http://rdf.insee.fr/def/geo#ancienChefLieu">igeo:ancienChefLieu</a>
    /// </summary>
    let ancienChefLieu = _prefixId.prefix "ancienChefLieu"
    /// <summary>
    ///   <para>rdfs:label : ancien nom</para>
    ///   <a href="http://rdf.insee.fr/def/geo#ancienNom">igeo:ancienNom</a>
    /// </summary>
    let ancienNom = _prefixId.prefix "ancienNom"
    /// <summary>
    ///   <para>rdfs:label : capitale d'un pays ou d'un territoire</para>
    ///   <a href="http://rdf.insee.fr/def/geo#capitale">igeo:capitale</a>
    /// </summary>
    let capitale = _prefixId.prefix "capitale"
    /// <summary>
    ///   <para>rdfs:label : centroïde</para>
    ///   <a href="http://rdf.insee.fr/def/geo#centroide">igeo:centroide</a>
    /// </summary>
    let centroide = _prefixId.prefix "centroide"
    /// <summary>
    ///   <para>rdfs:label : chef-lieu</para>
    ///   <para>rdfs:comment : La commune siège des institutions administratives du territoire</para>
    ///   <a href="http://rdf.insee.fr/def/geo#chefLieu">igeo:chefLieu</a>
    /// </summary>
    let chefLieu = _prefixId.prefix "chefLieu"
    /// <summary>
    ///   <para>rdfs:label : chef-lieu de canton</para>
    ///   <a href="http://rdf.insee.fr/def/geo#chefLieuDeCanton">igeo:chefLieuDeCanton</a>
    /// </summary>
    let chefLieuDeCanton = _prefixId.prefix "chefLieuDeCanton"
    /// <summary>
    ///   <para>rdfs:label : chef-lieu de commune</para>
    ///   <para>rdfs:comment : Position géographique de la mairie</para>
    ///   <a href="http://rdf.insee.fr/def/geo#chefLieuDeCommune">igeo:chefLieuDeCommune</a>
    /// </summary>
    let chefLieuDeCommune = _prefixId.prefix "chefLieuDeCommune"
    /// <summary>
    ///   <para>rdfs:label : code administratif Geonames</para>
    ///   <a href="http://rdf.insee.fr/def/geo#codeAdministratifGeonames">igeo:codeAdministratifGeonames</a>
    /// </summary>
    let codeAdministratifGeonames = _prefixId.prefix "codeAdministratifGeonames"
    /// <summary>
    ///   <para>rdfs:label : code arrondissement</para>
    ///   <a href="http://rdf.insee.fr/def/geo#codeArrondissement">igeo:codeArrondissement</a>
    /// </summary>
    let codeArrondissement = _prefixId.prefix "codeArrondissement"
    /// <summary>
    ///   <para>rdfs:label : code canton</para>
    ///   <a href="http://rdf.insee.fr/def/geo#codeCanton">igeo:codeCanton</a>
    /// </summary>
    let codeCanton = _prefixId.prefix "codeCanton"
    /// <summary>
    ///   <para>rdfs:label : code commune</para>
    ///   <a href="http://rdf.insee.fr/def/geo#codeCommune">igeo:codeCommune</a>
    /// </summary>
    let codeCommune = _prefixId.prefix "codeCommune"
    /// <summary>
    ///   <para>rdfs:label : code département</para>
    ///   <a href="http://rdf.insee.fr/def/geo#codeDepartement">igeo:codeDepartement</a>
    /// </summary>
    let codeDepartement = _prefixId.prefix "codeDepartement"
    /// <summary>
    ///   <para>rdfs:label : code INSEE</para>
    ///   <para>rdfs:comment : Propriété générique à utiliser pour les types de territoire pour lesquels un type de code plus spécifique n'est pas défini</para>
    ///   <a href="http://rdf.insee.fr/def/geo#codeINSEE">igeo:codeINSEE</a>
    /// </summary>
    let codeINSEE = _prefixId.prefix "codeINSEE"
    /// <summary>
    ///   <para>rdfs:label : code IRIS</para>
    ///   <a href="http://rdf.insee.fr/def/geo#codeIRIS">igeo:codeIRIS</a>
    /// </summary>
    let codeIRIS = _prefixId.prefix "codeIRIS"
    /// <summary>
    ///   <para>rdfs:label : code de pays ISO</para>
    ///   <para>rdfs:comment : Code conforme à la norme ISO 3166-1-alpha-2</para>
    ///   <a href="http://rdf.insee.fr/def/geo#codeISO">igeo:codeISO</a>
    /// </summary>
    let codeISO = _prefixId.prefix "codeISO"
    /// <summary>
    ///   <para>rdfs:label : code pays</para>
    ///   <a href="http://rdf.insee.fr/def/geo#codePays">igeo:codePays</a>
    /// </summary>
    let codePays = _prefixId.prefix "codePays"
    /// <summary>
    ///   <para>rdfs:label : code région</para>
    ///   <a href="http://rdf.insee.fr/def/geo#codeRegion">igeo:codeRegion</a>
    /// </summary>
    let codeRegion = _prefixId.prefix "codeRegion"
    /// <summary>
    ///   <para>rdfs:label : commune déplacée</para>
    ///   <a href="http://rdf.insee.fr/def/geo#communeDeplacee">igeo:communeDeplacee</a>
    /// </summary>
    let communeDeplacee = _prefixId.prefix "communeDeplacee"
    /// <summary>
    ///   <para>rdfs:label : date</para>
    ///   <para>rdfs:comment : Date de la modification</para>
    ///   <a href="http://rdf.insee.fr/def/geo#date">igeo:date</a>
    /// </summary>
    let date = _prefixId.prefix "date"
    /// <summary>
    ///   <para>rdfs:label : description</para>
    ///   <para>rdfs:comment : Description de la modification</para>
    ///   <a href="http://rdf.insee.fr/def/geo#description">igeo:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:label : fraction cantonale</para>
    ///   <para>rdfs:comment : Indique une commune dont une fraction seulement est incluse dans le canton</para>
    ///   <a href="http://rdf.insee.fr/def/geo#fractionCantonale">igeo:fractionCantonale</a>
    /// </summary>
    let fractionCantonale = _prefixId.prefix "fractionCantonale"
    let france = _prefixId.prefix "france"
    /// <summary>
    ///   <para>rdfs:label : groupement modifié</para>
    ///   <a href="http://rdf.insee.fr/def/geo#groupementModifie">igeo:groupementModifie</a>
    /// </summary>
    let groupementModifie = _prefixId.prefix "groupementModifie"
    /// <summary>
    ///   <para>rdfs:label : membre</para>
    ///   <para>rdfs:comment : Le pays ou territoire objet de cette propriété appartient au groupement sujet</para>
    ///   <a href="http://rdf.insee.fr/def/geo#membre">igeo:membre</a>
    /// </summary>
    let membre = _prefixId.prefix "membre"
    /// <summary>
    ///   <para>rdfs:label : modification</para>
    ///   <para>rdfs:comment : Une modification intervenue pour ce territoire</para>
    ///   <a href="http://rdf.insee.fr/def/geo#modification">igeo:modification</a>
    /// </summary>
    let modification = _prefixId.prefix "modification"
    /// <summary>
    ///   <para>rdfs:label : modification induite</para>
    ///   <para>rdfs:comment : La modification objet de cette propriété est provoquée par la modification sujet</para>
    ///   <a href="http://rdf.insee.fr/def/geo#modificationInduite">igeo:modificationInduite</a>
    /// </summary>
    let modificationInduite = _prefixId.prefix "modificationInduite"
    /// <summary>
    ///   <para>rdfs:label : nom</para>
    ///   <a href="http://rdf.insee.fr/def/geo#nom">igeo:nom</a>
    /// </summary>
    let nom = _prefixId.prefix "nom"
    /// <summary>
    ///   <para>rdfs:label : nouveau chef-lieu</para>
    ///   <a href="http://rdf.insee.fr/def/geo#nouveauChefLieu">igeo:nouveauChefLieu</a>
    /// </summary>
    let nouveauChefLieu = _prefixId.prefix "nouveauChefLieu"
    /// <summary>
    ///   <para>rdfs:label : nouveau nom</para>
    ///   <a href="http://rdf.insee.fr/def/geo#nouveauNom">igeo:nouveauNom</a>
    /// </summary>
    let nouveauNom = _prefixId.prefix "nouveauNom"
    /// <summary>
    ///   <para>rdfs:label : pays entrant</para>
    ///   <para>rdfs:comment : Pays entrant</para>
    ///   <a href="http://rdf.insee.fr/def/geo#paysEntrant">igeo:paysEntrant</a>
    /// </summary>
    let paysEntrant = _prefixId.prefix "paysEntrant"
    /// <summary>
    ///   <para>rdfs:label : pays sortant</para>
    ///   <para>rdfs:comment : Pays sortant</para>
    ///   <a href="http://rdf.insee.fr/def/geo#paysSortant">igeo:paysSortant</a>
    /// </summary>
    let paysSortant = _prefixId.prefix "paysSortant"
    /// <summary>
    ///   <para>rdfs:label : préfecture de département</para>
    ///   <a href="http://rdf.insee.fr/def/geo#prefecture">igeo:prefecture</a>
    /// </summary>
    let prefecture = _prefixId.prefix "prefecture"
    /// <summary>
    ///   <para>rdfs:label : préfecture de région</para>
    ///   <a href="http://rdf.insee.fr/def/geo#prefectureDeRegion">igeo:prefectureDeRegion</a>
    /// </summary>
    let prefectureDeRegion = _prefixId.prefix "prefectureDeRegion"
    /// <summary>
    ///   <para>rdfs:label : résultante</para>
    ///   <a href="http://rdf.insee.fr/def/geo#resultante">igeo:resultante</a>
    /// </summary>
    let resultante = _prefixId.prefix "resultante"
    /// <summary>
    ///   <para>rdfs:label : sous-préfecture de département</para>
    ///   <a href="http://rdf.insee.fr/def/geo#sousPrefecture">igeo:sousPrefecture</a>
    /// </summary>
    let sousPrefecture = _prefixId.prefix "sousPrefecture"
    /// <summary>
    ///   <para>rdfs:label : subdivision</para>
    ///   <para>rdfs:comment : Une subdivision du territoire^^xsd:string</para>
    ///   <a href="http://rdf.insee.fr/def/geo#subdivision">igeo:subdivision</a>
    /// </summary>
    let subdivision = _prefixId.prefix "subdivision"
    /// <summary>
    ///   <para>rdfs:label : subdivision de</para>
    ///   <para>rdfs:comment : Un territoire dont le sujet est une subdivision^^xsd:string</para>
    ///   <a href="http://rdf.insee.fr/def/geo#subdivisionDe">igeo:subdivisionDe</a>
    /// </summary>
    let subdivisionDe = _prefixId.prefix "subdivisionDe"
    /// <summary>
    ///   <para>rdfs:label : subdivision directe</para>
    ///   <para>rdfs:comment : L'objet de cette propriété est une subdivision administrative directe du sujet.</para>
    ///   <a href="http://rdf.insee.fr/def/geo#subdivisionDirecte">igeo:subdivisionDirecte</a>
    /// </summary>
    let subdivisionDirecte = _prefixId.prefix "subdivisionDirecte"
    /// <summary>
    ///   <para>rdfs:label : territoire d'origine</para>
    ///   <a href="http://rdf.insee.fr/def/geo#territoireDOrigine">igeo:territoireDOrigine</a>
    /// </summary>
    let territoireDOrigine = _prefixId.prefix "territoireDOrigine"
    /// <summary>
    ///   <para>rdfs:label : territoire de rattachement</para>
    ///   <a href="http://rdf.insee.fr/def/geo#territoireDeRattachement">igeo:territoireDeRattachement</a>
    /// </summary>
    let territoireDeRattachement = _prefixId.prefix "territoireDeRattachement"
    /// <summary>
    ///   <para>rdfs:label : territoire modifié</para>
    ///   <a href="http://rdf.insee.fr/def/geo#territoireModifie">igeo:territoireModifie</a>
    /// </summary>
    let territoireModifie = _prefixId.prefix "territoireModifie"
    /// <summary>
    ///   <para>rdfs:label : type d'EPCI</para>
    ///   <a href="http://rdf.insee.fr/def/geo#typeDEPCI">igeo:typeDEPCI</a>
    /// </summary>
    let typeDEPCI = _prefixId.prefix "typeDEPCI"
    /// <summary>
    ///   <para>rdfs:label : type d'IRIS</para>
    ///   <a href="http://rdf.insee.fr/def/geo#typeDIRIS">igeo:typeDIRIS</a>
    /// </summary>
    let typeDIRIS = _prefixId.prefix "typeDIRIS"
    /// <summary>
    ///   <para>rdfs:label : vivant</para>
    ///   <para>rdfs:comment : La valeur par défaut 'true' indique que le territoire existe actuellement. La valeur 'false' indique un territoire mort suite à un événement de modification.^^xsd:string</para>
    ///   <a href="http://rdf.insee.fr/def/geo#vivant">igeo:vivant</a>
    /// </summary>
    let vivant = _prefixId.prefix "vivant"
    /// <summary>
    ///   <para>rdfs:label : voisin</para>
    ///   <para>rdfs:comment : Un territoire ayant une frontière commune</para>
    ///   <a href="http://rdf.insee.fr/def/geo#voisin">igeo:voisin</a>
    /// </summary>
    let voisin = _prefixId.prefix "voisin"
