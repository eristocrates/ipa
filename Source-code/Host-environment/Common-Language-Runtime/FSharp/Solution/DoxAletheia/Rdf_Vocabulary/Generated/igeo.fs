namespace http.rdf.insee.fr.def.geo.hash

open DoxAletheia

module igeo =
    let _namespace_name = "http://rdf.insee.fr/def/geo#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#TypeDEPCI"></see>
    /// </summary>
    let TypeDEPCI = _prefix "TypeDEPCI"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#TypeDIRIS"></see>
    /// </summary>
    let TypeDIRIS = _prefix "TypeDIRIS"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#AireUrbaine"></see>
    /// </summary>
    let AireUrbaine = _prefix "AireUrbaine"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#GroupementStatistiqueDeCommunes"></see>
    /// </summary>
    let GroupementStatistiqueDeCommunes = _prefix "GroupementStatistiqueDeCommunes"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#Arrondissement"></see>
    /// </summary>
    let Arrondissement = _prefix "Arrondissement"
    /// <summary>
    /// Un territoire dont le sujet est une subdivision
    /// <see href="http://rdf.insee.fr/def/geo#subdivisionDe"></see></summary>
    let subdivisionDe = _prefix "subdivisionDe"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#Departement"></see>
    /// </summary>
    let Departement = _prefix "Departement"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#codeAdministratifGeonames"></see>
    /// </summary>
    let codeAdministratifGeonames = _prefix "codeAdministratifGeonames"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#TerritoireAdministratif"></see>
    /// </summary>
    let TerritoireAdministratif = _prefix "TerritoireAdministratif"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#ArrondissementMunicipal"></see>
    /// </summary>
    let ArrondissementMunicipal = _prefix "ArrondissementMunicipal"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#Canton"></see>
    /// </summary>
    let Canton = _prefix "Canton"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#CantonOuVille"></see>
    /// </summary>
    let CantonOuVille = _prefix "CantonOuVille"
    /// <summary>
    /// Une subdivision du territoire
    /// <see href="http://rdf.insee.fr/def/geo#subdivision"></see></summary>
    let subdivision = _prefix "subdivision"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#Commune"></see>
    /// </summary>
    let Commune = _prefix "Commune"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#TerritoireStatistique"></see>
    /// </summary>
    let TerritoireStatistique = _prefix "TerritoireStatistique"

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#ChangementDeDepartementOuArrondissement"></see>
    /// </summary>
    let ChangementDeDepartementOuArrondissement =
        _prefix "ChangementDeDepartementOuArrondissement"

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#communeDeplacee"></see>
    /// </summary>
    let communeDeplacee = _prefix "communeDeplacee"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#ModificationTerritoriale"></see>
    /// </summary>
    let ModificationTerritoriale = _prefix "ModificationTerritoriale"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#ChangementDeNom"></see>
    /// </summary>
    let ChangementDeNom = _prefix "ChangementDeNom"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#territoireModifie"></see>
    /// </summary>
    let territoireModifie = _prefix "territoireModifie"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#CollectiviteTerritoriale"></see>
    /// </summary>
    let CollectiviteTerritoriale = _prefix "CollectiviteTerritoriale"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#chefLieu"></see>
    /// </summary>
    let chefLieu = _prefix "chefLieu"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#LAU2"></see>
    /// </summary>
    let LAU2 = _prefix "LAU2"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#CreationOuRetablissement"></see>
    /// </summary>
    let CreationOuRetablissement = _prefix "CreationOuRetablissement"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#Region"></see>
    /// </summary>
    let Region = _prefix "Region"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#subdivisionDirecte"></see>
    /// </summary>
    let subdivisionDirecte = _prefix "subdivisionDirecte"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#NUTS3"></see>
    /// </summary>
    let NUTS3 = _prefix "NUTS3"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#DeplacementDeLimitesDIRIS"></see>
    /// </summary>
    let DeplacementDeLimitesDIRIS = _prefix "DeplacementDeLimitesDIRIS"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#ModificationDIRIS"></see>
    /// </summary>
    let ModificationDIRIS = _prefix "ModificationDIRIS"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#EPCI"></see>
    /// </summary>
    let EPCI = _prefix "EPCI"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#membre"></see>
    /// </summary>
    let membre = _prefix "membre"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#EchangeDeParcelles"></see>
    /// </summary>
    let EchangeDeParcelles = _prefix "EchangeDeParcelles"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#EchangeParcellesCommunesIrisees"></see>
    /// </summary>
    let EchangeParcellesCommunesIrisees = _prefix "EchangeParcellesCommunesIrisees"

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#EchangeParcellesHabiteesCommunesIriseesNonIrisees"></see>
    /// </summary>
    let EchangeParcellesHabiteesCommunesIriseesNonIrisees =
        _prefix "EchangeParcellesHabiteesCommunesIriseesNonIrisees"

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#EchangeParcellesInhabiteesCommunesIriseesNonIrisees"></see>
    /// </summary>
    let EchangeParcellesInhabiteesCommunesIriseesNonIrisees =
        _prefix "EchangeParcellesInhabiteesCommunesIriseesNonIrisees"

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#FusionDeCommunesIrisees"></see>
    /// </summary>
    let FusionDeCommunesIrisees = _prefix "FusionDeCommunesIrisees"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#SuppressionFusion"></see>
    /// </summary>
    let SuppressionFusion = _prefix "SuppressionFusion"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#GrandQuartier"></see>
    /// </summary>
    let GrandQuartier = _prefix "GrandQuartier"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#IRIS"></see>
    /// </summary>
    let IRIS = _prefix "IRIS"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#GroupementDePays"></see>
    /// </summary>
    let GroupementDePays = _prefix "GroupementDePays"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#PaysOuTerritoire"></see>
    /// </summary>
    let PaysOuTerritoire = _prefix "PaysOuTerritoire"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#LAU"></see>
    /// </summary>
    let LAU = _prefix "LAU"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#LAU1"></see>
    /// </summary>
    let LAU1 = _prefix "LAU1"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#ModificationCantonale"></see>
    /// </summary>
    let ModificationCantonale = _prefix "ModificationCantonale"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#ModificationDeGroupement"></see>
    /// </summary>
    let ModificationDeGroupement = _prefix "ModificationDeGroupement"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#groupementModifie"></see>
    /// </summary>
    let groupementModifie = _prefix "groupementModifie"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#NUTS"></see>
    /// </summary>
    let NUTS = _prefix "NUTS"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#NUTS1"></see>
    /// </summary>
    let NUTS1 = _prefix "NUTS1"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#NUTS2"></see>
    /// </summary>
    let NUTS2 = _prefix "NUTS2"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#Pays"></see>
    /// </summary>
    let Pays = _prefix "Pays"

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#RetablissementCommunesIssuesDeCommuneIrisees"></see>
    /// </summary>
    let RetablissementCommunesIssuesDeCommuneIrisees =
        _prefix "RetablissementCommunesIssuesDeCommuneIrisees"

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#ScissionDIRIS"></see>
    /// </summary>
    let ScissionDIRIS = _prefix "ScissionDIRIS"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#TRIRIS"></see>
    /// </summary>
    let TRIRIS = _prefix "TRIRIS"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#TerritoireFrancais"></see>
    /// </summary>
    let TerritoireFrancais = _prefix "TerritoireFrancais"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#france"></see>
    /// </summary>
    let france = _prefix "france"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#TransfertDeChefLieu"></see>
    /// </summary>
    let TransfertDeChefLieu = _prefix "TransfertDeChefLieu"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#ancienChefLieu"></see>
    /// </summary>
    let ancienChefLieu = _prefix "ancienChefLieu"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#nouveauChefLieu"></see>
    /// </summary>
    let nouveauChefLieu = _prefix "nouveauChefLieu"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#UniteUrbaine"></see>
    /// </summary>
    let UniteUrbaine = _prefix "UniteUrbaine"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#ZoneDEmploi"></see>
    /// </summary>
    let ZoneDEmploi = _prefix "ZoneDEmploi"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#ancienNom"></see>
    /// </summary>
    let ancienNom = _prefix "ancienNom"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#capitale"></see>
    /// </summary>
    let capitale = _prefix "capitale"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#centroide"></see>
    /// </summary>
    let centroide = _prefix "centroide"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#chefLieuDeCanton"></see>
    /// </summary>
    let chefLieuDeCanton = _prefix "chefLieuDeCanton"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#chefLieuDeCommune"></see>
    /// </summary>
    let chefLieuDeCommune = _prefix "chefLieuDeCommune"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#codeArrondissement"></see>
    /// </summary>
    let codeArrondissement = _prefix "codeArrondissement"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#codeINSEE"></see>
    /// </summary>
    let codeINSEE = _prefix "codeINSEE"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#codeCanton"></see>
    /// </summary>
    let codeCanton = _prefix "codeCanton"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#codeCommune"></see>
    /// </summary>
    let codeCommune = _prefix "codeCommune"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#codeDepartement"></see>
    /// </summary>
    let codeDepartement = _prefix "codeDepartement"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#codeIRIS"></see>
    /// </summary>
    let codeIRIS = _prefix "codeIRIS"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#codeISO"></see>
    /// </summary>
    let codeISO = _prefix "codeISO"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#codePays"></see>
    /// </summary>
    let codePays = _prefix "codePays"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#codeRegion"></see>
    /// </summary>
    let codeRegion = _prefix "codeRegion"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#date"></see>
    /// </summary>
    let date = _prefix "date"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#description"></see>
    /// </summary>
    let description = _prefix "description"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#fractionCantonale"></see>
    /// </summary>
    let fractionCantonale = _prefix "fractionCantonale"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#modification"></see>
    /// </summary>
    let modification = _prefix "modification"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#modificationInduite"></see>
    /// </summary>
    let modificationInduite = _prefix "modificationInduite"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#nom"></see>
    /// </summary>
    let nom = _prefix "nom"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#nouveauNom"></see>
    /// </summary>
    let nouveauNom = _prefix "nouveauNom"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#paysEntrant"></see>
    /// </summary>
    let paysEntrant = _prefix "paysEntrant"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#paysSortant"></see>
    /// </summary>
    let paysSortant = _prefix "paysSortant"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#prefecture"></see>
    /// </summary>
    let prefecture = _prefix "prefecture"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#prefectureDeRegion"></see>
    /// </summary>
    let prefectureDeRegion = _prefix "prefectureDeRegion"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#resultante"></see>
    /// </summary>
    let resultante = _prefix "resultante"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#sousPrefecture"></see>
    /// </summary>
    let sousPrefecture = _prefix "sousPrefecture"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#territoireDOrigine"></see>
    /// </summary>
    let territoireDOrigine = _prefix "territoireDOrigine"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#territoireDeRattachement"></see>
    /// </summary>
    let territoireDeRattachement = _prefix "territoireDeRattachement"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#typeDEPCI"></see>
    /// </summary>
    let typeDEPCI = _prefix "typeDEPCI"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#typeDIRIS"></see>
    /// </summary>
    let typeDIRIS = _prefix "typeDIRIS"
    /// <summary>
    /// La valeur par défaut 'true' indique que le territoire existe actuellement. La valeur 'false' indique un territoire mort suite à un événement de modification.
    /// <see href="http://rdf.insee.fr/def/geo#vivant"></see></summary>
    let vivant = _prefix "vivant"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#voisin"></see>
    /// </summary>
    let voisin = _prefix "voisin"
