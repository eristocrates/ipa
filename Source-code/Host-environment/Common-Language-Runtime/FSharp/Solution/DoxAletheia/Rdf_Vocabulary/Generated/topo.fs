namespace http.data.ign.fr.def.topo.hash

open DoxAletheia.Rdf_Vocabulary

module topo =
    let _namespace_name = "http://data.ign.fr/def/topo#"

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#AireDePeage"></see>
    /// </summary>
    let AireDePeage =
        Namespaced_IRI.parse _namespace_name "AireDePeage" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#ElementReseauRoutier"></see>
    /// </summary>
    let ElementReseauRoutier =
        Namespaced_IRI.parse _namespace_name "ElementReseauRoutier" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#AireDeTriage"></see>
    /// </summary>
    let AireDeTriage =
        Namespaced_IRI.parse _namespace_name "AireDeTriage" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#ElementReseauFerroviaire"></see>
    /// </summary>
    let ElementReseauFerroviaire =
        Namespaced_IRI.parse _namespace_name "ElementReseauFerroviaire" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#Bassin"></see>
    /// </summary>
    let Bassin = Namespaced_IRI.parse _namespace_name "Bassin" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#EntiteHydrographiqueTerrestre"></see>
    /// </summary>
    let EntiteHydrographiqueTerrestre =
        Namespaced_IRI.parse _namespace_name "EntiteHydrographiqueTerrestre" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#Bati"></see>
    /// </summary>
    let Bati = Namespaced_IRI.parse _namespace_name "Bati" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#EntiteTopographique"></see>
    /// </summary>
    let EntiteTopographique =
        Namespaced_IRI.parse _namespace_name "EntiteTopographique" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#Batiment"></see>
    /// </summary>
    let Batiment = Namespaced_IRI.parse _namespace_name "Batiment" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#BornePostale"></see>
    /// </summary>
    let BornePostale =
        Namespaced_IRI.parse _namespace_name "BornePostale" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#CanalisationDEau"></see>
    /// </summary>
    let CanalisationDEau =
        Namespaced_IRI.parse _namespace_name "CanalisationDEau" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#Cimetiere"></see>
    /// </summary>
    let Cimetiere = Namespaced_IRI.parse _namespace_name "Cimetiere" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#Conduite"></see>
    /// </summary>
    let Conduite = Namespaced_IRI.parse _namespace_name "Conduite" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#InfrastructureTransportEnergie"></see>
    /// </summary>
    let InfrastructureTransportEnergie =
        Namespaced_IRI.parse _namespace_name "InfrastructureTransportEnergie" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#Construction"></see>
    /// </summary>
    let Construction =
        Namespaced_IRI.parse _namespace_name "Construction" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#CoursDEau"></see>
    /// </summary>
    let CoursDEau = Namespaced_IRI.parse _namespace_name "CoursDEau" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#ElementDuRelief"></see>
    /// </summary>
    let ElementDuRelief =
        Namespaced_IRI.parse _namespace_name "ElementDuRelief" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#Laisse"></see>
    /// </summary>
    let Laisse = Namespaced_IRI.parse _namespace_name "Laisse" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#LigneElectrique"></see>
    /// </summary>
    let LigneElectrique =
        Namespaced_IRI.parse _namespace_name "LigneElectrique" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#LigneTransportCable"></see>
    /// </summary>
    let LigneTransportCable =
        Namespaced_IRI.parse _namespace_name "LigneTransportCable" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#Parking"></see>
    /// </summary>
    let Parking = Namespaced_IRI.parse _namespace_name "Parking" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#PisteAerodrome"></see>
    /// </summary>
    let PisteAerodrome =
        Namespaced_IRI.parse _namespace_name "PisteAerodrome" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#Place"></see>
    /// </summary>
    let Place = Namespaced_IRI.parse _namespace_name "Place" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#PointDEau"></see>
    /// </summary>
    let PointDEau = Namespaced_IRI.parse _namespace_name "PointDEau" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#PosteTransformation"></see>
    /// </summary>
    let PosteTransformation =
        Namespaced_IRI.parse _namespace_name "PosteTransformation" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#Pylone"></see>
    /// </summary>
    let Pylone = Namespaced_IRI.parse _namespace_name "Pylone" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#Reservoir"></see>
    /// </summary>
    let Reservoir = Namespaced_IRI.parse _namespace_name "Reservoir" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#Route"></see>
    /// </summary>
    let Route = Namespaced_IRI.parse _namespace_name "Route" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#Voie"></see>
    /// </summary>
    let Voie = Namespaced_IRI.parse _namespace_name "Voie" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#SurfaceDEau"></see>
    /// </summary>
    let SurfaceDEau =
        Namespaced_IRI.parse _namespace_name "SurfaceDEau" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#TerrainDeSport"></see>
    /// </summary>
    let TerrainDeSport =
        Namespaced_IRI.parse _namespace_name "TerrainDeSport" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#TypeDeBatiment"></see>
    /// </summary>
    let TypeDeBatiment =
        Namespaced_IRI.parse _namespace_name "TypeDeBatiment" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#TypeDeConstruction"></see>
    /// </summary>
    let TypeDeConstruction =
        Namespaced_IRI.parse _namespace_name "TypeDeConstruction" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#TypeDeFranchissement"></see>
    /// </summary>
    let TypeDeFranchissement =
        Namespaced_IRI.parse _namespace_name "TypeDeFranchissement" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#TypeDeLaisse"></see>
    /// </summary>
    let TypeDeLaisse =
        Namespaced_IRI.parse _namespace_name "TypeDeLaisse" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#TypeDePointDEau"></see>
    /// </summary>
    let TypeDePointDEau =
        Namespaced_IRI.parse _namespace_name "TypeDePointDEau" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#TypeDeRelief"></see>
    /// </summary>
    let TypeDeRelief =
        Namespaced_IRI.parse _namespace_name "TypeDeRelief" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#TypeDeReservoir"></see>
    /// </summary>
    let TypeDeReservoir =
        Namespaced_IRI.parse _namespace_name "TypeDeReservoir" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#TypeDeRoute"></see>
    /// </summary>
    let TypeDeRoute =
        Namespaced_IRI.parse _namespace_name "TypeDeRoute" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#TypeDeTerrainDeSport"></see>
    /// </summary>
    let TypeDeTerrainDeSport =
        Namespaced_IRI.parse _namespace_name "TypeDeTerrainDeSport" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#TypeDeTransportCable"></see>
    /// </summary>
    let TypeDeTransportCable =
        Namespaced_IRI.parse _namespace_name "TypeDeTransportCable" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#TypeDeVegetation"></see>
    /// </summary>
    let TypeDeVegetation =
        Namespaced_IRI.parse _namespace_name "TypeDeVegetation" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#TypeDeVoieFerree"></see>
    /// </summary>
    let TypeDeVoieFerree =
        Namespaced_IRI.parse _namespace_name "TypeDeVoieFerree" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#TypeDeZAI"></see>
    /// </summary>
    let TypeDeZAI = Namespaced_IRI.parse _namespace_name "TypeDeZAI" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#VoieFerree"></see>
    /// </summary>
    let VoieFerree = Namespaced_IRI.parse _namespace_name "VoieFerree" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#ZoneActiviteInteret"></see>
    /// </summary>
    let ZoneActiviteInteret =
        Namespaced_IRI.parse _namespace_name "ZoneActiviteInteret" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#ZoneDeVegetation"></see>
    /// </summary>
    let ZoneDeVegetation =
        Namespaced_IRI.parse _namespace_name "ZoneDeVegetation" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#artif"></see>
    /// </summary>
    let artif = Namespaced_IRI.parse _namespace_name "artif" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#borneFin"></see>
    /// </summary>
    let borneFin = Namespaced_IRI.parse _namespace_name "borneFin" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#borneIni"></see>
    /// </summary>
    let borneIni = Namespaced_IRI.parse _namespace_name "borneIni" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#clAdmin"></see>
    /// </summary>
    let clAdmin = Namespaced_IRI.parse _namespace_name "clAdmin" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#codePostal"></see>
    /// </summary>
    let codePostal = Namespaced_IRI.parse _namespace_name "codePostal" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#concerne"></see>
    /// </summary>
    let concerne = Namespaced_IRI.parse _namespace_name "concerne" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#electrifie"></see>
    /// </summary>
    let electrifie = Namespaced_IRI.parse _namespace_name "electrifie" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#enConstruction"></see>
    /// </summary>
    let enConstruction =
        Namespaced_IRI.parse _namespace_name "enConstruction" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#fictif"></see>
    /// </summary>
    let fictif = Namespaced_IRI.parse _namespace_name "fictif" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#gestion"></see>
    /// </summary>
    let gestion = Namespaced_IRI.parse _namespace_name "gestion" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#gestionVoie"></see>
    /// </summary>
    let gestionVoie =
        Namespaced_IRI.parse _namespace_name "gestionVoie" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#hauteur"></see>
    /// </summary>
    let hauteur = Namespaced_IRI.parse _namespace_name "hauteur" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#importance"></see>
    /// </summary>
    let importance = Namespaced_IRI.parse _namespace_name "importance" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#itEurop"></see>
    /// </summary>
    let itEurop = Namespaced_IRI.parse _namespace_name "itEurop" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#itVert"></see>
    /// </summary>
    let itVert = Namespaced_IRI.parse _namespace_name "itVert" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#largeurChaussee"></see>
    /// </summary>
    let largeurChaussee =
        Namespaced_IRI.parse _namespace_name "largeurChaussee" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#largeurVF"></see>
    /// </summary>
    let largeurVF = Namespaced_IRI.parse _namespace_name "largeurVF" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#militaire"></see>
    /// </summary>
    let militaire = Namespaced_IRI.parse _namespace_name "militaire" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#nature"></see>
    /// </summary>
    let nature = Namespaced_IRI.parse _namespace_name "nature" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#miseEnService"></see>
    /// </summary>
    let miseEnService =
        Namespaced_IRI.parse _namespace_name "miseEnService" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#nbVoiesCirculation"></see>
    /// </summary>
    let nbVoiesCirculation =
        Namespaced_IRI.parse _namespace_name "nbVoiesCirculation" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#nbVoiesFerrees"></see>
    /// </summary>
    let nbVoiesFerrees =
        Namespaced_IRI.parse _namespace_name "nbVoiesFerrees" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#nomIti"></see>
    /// </summary>
    let nomIti = Namespaced_IRI.parse _namespace_name "nomIti" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#numero"></see>
    /// </summary>
    let numero = Namespaced_IRI.parse _namespace_name "numero" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#numeroBorne"></see>
    /// </summary>
    let numeroBorne =
        Namespaced_IRI.parse _namespace_name "numeroBorne" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#origine"></see>
    /// </summary>
    let origine = Namespaced_IRI.parse _namespace_name "origine" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#posSol"></see>
    /// </summary>
    let posSol = Namespaced_IRI.parse _namespace_name "posSol" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#precAlti"></see>
    /// </summary>
    let precAlti = Namespaced_IRI.parse _namespace_name "precAlti" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#precPlani"></see>
    /// </summary>
    let precPlani = Namespaced_IRI.parse _namespace_name "precPlani" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#regime"></see>
    /// </summary>
    let regime = Namespaced_IRI.parse _namespace_name "regime" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#sens"></see>
    /// </summary>
    let sens = Namespaced_IRI.parse _namespace_name "sens" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#typAdres"></see>
    /// </summary>
    let typAdres = Namespaced_IRI.parse _namespace_name "typAdres" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#typeDeBatiment"></see>
    /// </summary>
    let typeDeBatiment =
        Namespaced_IRI.parse _namespace_name "typeDeBatiment" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#typeDeConstruction"></see>
    /// </summary>
    let typeDeConstruction =
        Namespaced_IRI.parse _namespace_name "typeDeConstruction" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#typeDeFranchissement"></see>
    /// </summary>
    let typeDeFranchissement =
        Namespaced_IRI.parse _namespace_name "typeDeFranchissement" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#typeDeLaisse"></see>
    /// </summary>
    let typeDeLaisse =
        Namespaced_IRI.parse _namespace_name "typeDeLaisse" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#typeDePiste"></see>
    /// </summary>
    let typeDePiste =
        Namespaced_IRI.parse _namespace_name "typeDePiste" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#typeDePointDEau"></see>
    /// </summary>
    let typeDePointDEau =
        Namespaced_IRI.parse _namespace_name "typeDePointDEau" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#typeDeRelief"></see>
    /// </summary>
    let typeDeRelief =
        Namespaced_IRI.parse _namespace_name "typeDeRelief" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#typeDeReservoir"></see>
    /// </summary>
    let typeDeReservoir =
        Namespaced_IRI.parse _namespace_name "typeDeReservoir" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#typeDeRoute"></see>
    /// </summary>
    let typeDeRoute =
        Namespaced_IRI.parse _namespace_name "typeDeRoute" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#typeDeTerrainDeSport"></see>
    /// </summary>
    let typeDeTerrainDeSport =
        Namespaced_IRI.parse _namespace_name "typeDeTerrainDeSport" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#typeDeTransportCable"></see>
    /// </summary>
    let typeDeTransportCable =
        Namespaced_IRI.parse _namespace_name "typeDeTransportCable" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#typeDeVegetation"></see>
    /// </summary>
    let typeDeVegetation =
        Namespaced_IRI.parse _namespace_name "typeDeVegetation" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#typeDeVoieFerree"></see>
    /// </summary>
    let typeDeVoieFerree =
        Namespaced_IRI.parse _namespace_name "typeDeVoieFerree" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#typeDeZAI"></see>
    /// </summary>
    let typeDeZAI = Namespaced_IRI.parse _namespace_name "typeDeZAI" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#voltage"></see>
    /// </summary>
    let voltage = Namespaced_IRI.parse _namespace_name "voltage" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#zFin"></see>
    /// </summary>
    let zFin = Namespaced_IRI.parse _namespace_name "zFin" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#zIni"></see>
    /// </summary>
    let zIni = Namespaced_IRI.parse _namespace_name "zIni" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#zMax"></see>
    /// </summary>
    let zMax = Namespaced_IRI.parse _namespace_name "zMax" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#zMin"></see>
    /// </summary>
    let zMin = Namespaced_IRI.parse _namespace_name "zMin" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#zMoyen"></see>
    /// </summary>
    let zMoyen = Namespaced_IRI.parse _namespace_name "zMoyen" |> NamespacedName
