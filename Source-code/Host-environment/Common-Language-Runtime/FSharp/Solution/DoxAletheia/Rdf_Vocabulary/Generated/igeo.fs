namespace http.rdf.insee.fr.def.geo.hash

open DoxAletheia.Rdf_Vocabulary

module igeo =
    let _namespace_name = "http://rdf.insee.fr/def/geo#"
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#TypeDEPCI"></see>
    /// </summary>
    let TypeDEPCI = Namespaced_IRI.parse _namespace_name "TypeDEPCI" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#TypeDIRIS"></see>
    /// </summary>
    let TypeDIRIS = Namespaced_IRI.parse _namespace_name "TypeDIRIS" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#AireUrbaine"></see>
    /// </summary>
    let AireUrbaine =
        Namespaced_IRI.parse _namespace_name "AireUrbaine" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#GroupementStatistiqueDeCommunes"></see>
    /// </summary>
    let GroupementStatistiqueDeCommunes =
        Namespaced_IRI.parse _namespace_name "GroupementStatistiqueDeCommunes" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#Arrondissement"></see>
    /// </summary>
    let Arrondissement =
        Namespaced_IRI.parse _namespace_name "Arrondissement" |> NamespacedName

    /// <summary>
    /// Un territoire dont le sujet est une subdivision
    /// <see href="http://rdf.insee.fr/def/geo#subdivisionDe"></see></summary>
    let subdivisionDe =
        Namespaced_IRI.parse _namespace_name "subdivisionDe" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#Departement"></see>
    /// </summary>
    let Departement =
        Namespaced_IRI.parse _namespace_name "Departement" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#codeAdministratifGeonames"></see>
    /// </summary>
    let codeAdministratifGeonames =
        Namespaced_IRI.parse _namespace_name "codeAdministratifGeonames" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#TerritoireAdministratif"></see>
    /// </summary>
    let TerritoireAdministratif =
        Namespaced_IRI.parse _namespace_name "TerritoireAdministratif" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#ArrondissementMunicipal"></see>
    /// </summary>
    let ArrondissementMunicipal =
        Namespaced_IRI.parse _namespace_name "ArrondissementMunicipal" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#Canton"></see>
    /// </summary>
    let Canton = Namespaced_IRI.parse _namespace_name "Canton" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#CantonOuVille"></see>
    /// </summary>
    let CantonOuVille =
        Namespaced_IRI.parse _namespace_name "CantonOuVille" |> NamespacedName

    /// <summary>
    /// Une subdivision du territoire
    /// <see href="http://rdf.insee.fr/def/geo#subdivision"></see></summary>
    let subdivision =
        Namespaced_IRI.parse _namespace_name "subdivision" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#Commune"></see>
    /// </summary>
    let Commune = Namespaced_IRI.parse _namespace_name "Commune" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#TerritoireStatistique"></see>
    /// </summary>
    let TerritoireStatistique =
        Namespaced_IRI.parse _namespace_name "TerritoireStatistique" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#ChangementDeDepartementOuArrondissement"></see>
    /// </summary>
    let ChangementDeDepartementOuArrondissement =
        Namespaced_IRI.parse _namespace_name "ChangementDeDepartementOuArrondissement" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#communeDeplacee"></see>
    /// </summary>
    let communeDeplacee =
        Namespaced_IRI.parse _namespace_name "communeDeplacee" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#ModificationTerritoriale"></see>
    /// </summary>
    let ModificationTerritoriale =
        Namespaced_IRI.parse _namespace_name "ModificationTerritoriale" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#ChangementDeNom"></see>
    /// </summary>
    let ChangementDeNom =
        Namespaced_IRI.parse _namespace_name "ChangementDeNom" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#territoireModifie"></see>
    /// </summary>
    let territoireModifie =
        Namespaced_IRI.parse _namespace_name "territoireModifie" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#CollectiviteTerritoriale"></see>
    /// </summary>
    let CollectiviteTerritoriale =
        Namespaced_IRI.parse _namespace_name "CollectiviteTerritoriale" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#chefLieu"></see>
    /// </summary>
    let chefLieu = Namespaced_IRI.parse _namespace_name "chefLieu" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#LAU2"></see>
    /// </summary>
    let LAU2 = Namespaced_IRI.parse _namespace_name "LAU2" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#CreationOuRetablissement"></see>
    /// </summary>
    let CreationOuRetablissement =
        Namespaced_IRI.parse _namespace_name "CreationOuRetablissement" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#Region"></see>
    /// </summary>
    let Region = Namespaced_IRI.parse _namespace_name "Region" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#subdivisionDirecte"></see>
    /// </summary>
    let subdivisionDirecte =
        Namespaced_IRI.parse _namespace_name "subdivisionDirecte" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#NUTS3"></see>
    /// </summary>
    let NUTS3 = Namespaced_IRI.parse _namespace_name "NUTS3" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#DeplacementDeLimitesDIRIS"></see>
    /// </summary>
    let DeplacementDeLimitesDIRIS =
        Namespaced_IRI.parse _namespace_name "DeplacementDeLimitesDIRIS" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#ModificationDIRIS"></see>
    /// </summary>
    let ModificationDIRIS =
        Namespaced_IRI.parse _namespace_name "ModificationDIRIS" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#EPCI"></see>
    /// </summary>
    let EPCI = Namespaced_IRI.parse _namespace_name "EPCI" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#membre"></see>
    /// </summary>
    let membre = Namespaced_IRI.parse _namespace_name "membre" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#EchangeDeParcelles"></see>
    /// </summary>
    let EchangeDeParcelles =
        Namespaced_IRI.parse _namespace_name "EchangeDeParcelles" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#EchangeParcellesCommunesIrisees"></see>
    /// </summary>
    let EchangeParcellesCommunesIrisees =
        Namespaced_IRI.parse _namespace_name "EchangeParcellesCommunesIrisees" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#EchangeParcellesHabiteesCommunesIriseesNonIrisees"></see>
    /// </summary>
    let EchangeParcellesHabiteesCommunesIriseesNonIrisees =
        Namespaced_IRI.parse _namespace_name "EchangeParcellesHabiteesCommunesIriseesNonIrisees" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#EchangeParcellesInhabiteesCommunesIriseesNonIrisees"></see>
    /// </summary>
    let EchangeParcellesInhabiteesCommunesIriseesNonIrisees =
        Namespaced_IRI.parse _namespace_name "EchangeParcellesInhabiteesCommunesIriseesNonIrisees" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#FusionDeCommunesIrisees"></see>
    /// </summary>
    let FusionDeCommunesIrisees =
        Namespaced_IRI.parse _namespace_name "FusionDeCommunesIrisees" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#SuppressionFusion"></see>
    /// </summary>
    let SuppressionFusion =
        Namespaced_IRI.parse _namespace_name "SuppressionFusion" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#GrandQuartier"></see>
    /// </summary>
    let GrandQuartier =
        Namespaced_IRI.parse _namespace_name "GrandQuartier" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#IRIS"></see>
    /// </summary>
    let IRIS = Namespaced_IRI.parse _namespace_name "IRIS" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#GroupementDePays"></see>
    /// </summary>
    let GroupementDePays =
        Namespaced_IRI.parse _namespace_name "GroupementDePays" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#PaysOuTerritoire"></see>
    /// </summary>
    let PaysOuTerritoire =
        Namespaced_IRI.parse _namespace_name "PaysOuTerritoire" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#LAU"></see>
    /// </summary>
    let LAU = Namespaced_IRI.parse _namespace_name "LAU" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#LAU1"></see>
    /// </summary>
    let LAU1 = Namespaced_IRI.parse _namespace_name "LAU1" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#ModificationCantonale"></see>
    /// </summary>
    let ModificationCantonale =
        Namespaced_IRI.parse _namespace_name "ModificationCantonale" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#ModificationDeGroupement"></see>
    /// </summary>
    let ModificationDeGroupement =
        Namespaced_IRI.parse _namespace_name "ModificationDeGroupement" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#groupementModifie"></see>
    /// </summary>
    let groupementModifie =
        Namespaced_IRI.parse _namespace_name "groupementModifie" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#NUTS"></see>
    /// </summary>
    let NUTS = Namespaced_IRI.parse _namespace_name "NUTS" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#NUTS1"></see>
    /// </summary>
    let NUTS1 = Namespaced_IRI.parse _namespace_name "NUTS1" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#NUTS2"></see>
    /// </summary>
    let NUTS2 = Namespaced_IRI.parse _namespace_name "NUTS2" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#Pays"></see>
    /// </summary>
    let Pays = Namespaced_IRI.parse _namespace_name "Pays" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#RetablissementCommunesIssuesDeCommuneIrisees"></see>
    /// </summary>
    let RetablissementCommunesIssuesDeCommuneIrisees =
        Namespaced_IRI.parse _namespace_name "RetablissementCommunesIssuesDeCommuneIrisees" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#ScissionDIRIS"></see>
    /// </summary>
    let ScissionDIRIS =
        Namespaced_IRI.parse _namespace_name "ScissionDIRIS" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#TRIRIS"></see>
    /// </summary>
    let TRIRIS = Namespaced_IRI.parse _namespace_name "TRIRIS" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#TerritoireFrancais"></see>
    /// </summary>
    let TerritoireFrancais =
        Namespaced_IRI.parse _namespace_name "TerritoireFrancais" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#france"></see>
    /// </summary>
    let france = Namespaced_IRI.parse _namespace_name "france" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#TransfertDeChefLieu"></see>
    /// </summary>
    let TransfertDeChefLieu =
        Namespaced_IRI.parse _namespace_name "TransfertDeChefLieu" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#ancienChefLieu"></see>
    /// </summary>
    let ancienChefLieu =
        Namespaced_IRI.parse _namespace_name "ancienChefLieu" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#nouveauChefLieu"></see>
    /// </summary>
    let nouveauChefLieu =
        Namespaced_IRI.parse _namespace_name "nouveauChefLieu" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#UniteUrbaine"></see>
    /// </summary>
    let UniteUrbaine =
        Namespaced_IRI.parse _namespace_name "UniteUrbaine" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#ZoneDEmploi"></see>
    /// </summary>
    let ZoneDEmploi =
        Namespaced_IRI.parse _namespace_name "ZoneDEmploi" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#ancienNom"></see>
    /// </summary>
    let ancienNom = Namespaced_IRI.parse _namespace_name "ancienNom" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#capitale"></see>
    /// </summary>
    let capitale = Namespaced_IRI.parse _namespace_name "capitale" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#centroide"></see>
    /// </summary>
    let centroide = Namespaced_IRI.parse _namespace_name "centroide" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#chefLieuDeCanton"></see>
    /// </summary>
    let chefLieuDeCanton =
        Namespaced_IRI.parse _namespace_name "chefLieuDeCanton" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#chefLieuDeCommune"></see>
    /// </summary>
    let chefLieuDeCommune =
        Namespaced_IRI.parse _namespace_name "chefLieuDeCommune" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#codeArrondissement"></see>
    /// </summary>
    let codeArrondissement =
        Namespaced_IRI.parse _namespace_name "codeArrondissement" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#codeINSEE"></see>
    /// </summary>
    let codeINSEE = Namespaced_IRI.parse _namespace_name "codeINSEE" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#codeCanton"></see>
    /// </summary>
    let codeCanton = Namespaced_IRI.parse _namespace_name "codeCanton" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#codeCommune"></see>
    /// </summary>
    let codeCommune =
        Namespaced_IRI.parse _namespace_name "codeCommune" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#codeDepartement"></see>
    /// </summary>
    let codeDepartement =
        Namespaced_IRI.parse _namespace_name "codeDepartement" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#codeIRIS"></see>
    /// </summary>
    let codeIRIS = Namespaced_IRI.parse _namespace_name "codeIRIS" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#codeISO"></see>
    /// </summary>
    let codeISO = Namespaced_IRI.parse _namespace_name "codeISO" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#codePays"></see>
    /// </summary>
    let codePays = Namespaced_IRI.parse _namespace_name "codePays" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#codeRegion"></see>
    /// </summary>
    let codeRegion = Namespaced_IRI.parse _namespace_name "codeRegion" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#date"></see>
    /// </summary>
    let date = Namespaced_IRI.parse _namespace_name "date" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#description"></see>
    /// </summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#fractionCantonale"></see>
    /// </summary>
    let fractionCantonale =
        Namespaced_IRI.parse _namespace_name "fractionCantonale" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#modification"></see>
    /// </summary>
    let modification =
        Namespaced_IRI.parse _namespace_name "modification" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#modificationInduite"></see>
    /// </summary>
    let modificationInduite =
        Namespaced_IRI.parse _namespace_name "modificationInduite" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#nom"></see>
    /// </summary>
    let nom = Namespaced_IRI.parse _namespace_name "nom" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#nouveauNom"></see>
    /// </summary>
    let nouveauNom = Namespaced_IRI.parse _namespace_name "nouveauNom" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#paysEntrant"></see>
    /// </summary>
    let paysEntrant =
        Namespaced_IRI.parse _namespace_name "paysEntrant" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#paysSortant"></see>
    /// </summary>
    let paysSortant =
        Namespaced_IRI.parse _namespace_name "paysSortant" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#prefecture"></see>
    /// </summary>
    let prefecture = Namespaced_IRI.parse _namespace_name "prefecture" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#prefectureDeRegion"></see>
    /// </summary>
    let prefectureDeRegion =
        Namespaced_IRI.parse _namespace_name "prefectureDeRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#resultante"></see>
    /// </summary>
    let resultante = Namespaced_IRI.parse _namespace_name "resultante" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#sousPrefecture"></see>
    /// </summary>
    let sousPrefecture =
        Namespaced_IRI.parse _namespace_name "sousPrefecture" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#territoireDOrigine"></see>
    /// </summary>
    let territoireDOrigine =
        Namespaced_IRI.parse _namespace_name "territoireDOrigine" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#territoireDeRattachement"></see>
    /// </summary>
    let territoireDeRattachement =
        Namespaced_IRI.parse _namespace_name "territoireDeRattachement" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#typeDEPCI"></see>
    /// </summary>
    let typeDEPCI = Namespaced_IRI.parse _namespace_name "typeDEPCI" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#typeDIRIS"></see>
    /// </summary>
    let typeDIRIS = Namespaced_IRI.parse _namespace_name "typeDIRIS" |> NamespacedName
    /// <summary>
    /// La valeur par défaut 'true' indique que le territoire existe actuellement. La valeur 'false' indique un territoire mort suite à un événement de modification.
    /// <see href="http://rdf.insee.fr/def/geo#vivant"></see></summary>
    let vivant = Namespaced_IRI.parse _namespace_name "vivant" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.insee.fr/def/geo#voisin"></see>
    /// </summary>
    let voisin = Namespaced_IRI.parse _namespace_name "voisin" |> NamespacedName
