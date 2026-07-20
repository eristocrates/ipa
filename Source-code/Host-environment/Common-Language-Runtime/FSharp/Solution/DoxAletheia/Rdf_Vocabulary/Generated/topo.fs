namespace http.data.ign.fr.def.topo.hash

open DoxAletheia

module topo =
    let _namespace_name = "http://data.ign.fr/def/topo#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#AireDePeage"></see>
    /// </summary>
    let AireDePeage = _prefix "AireDePeage"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#ElementReseauRoutier"></see>
    /// </summary>
    let ElementReseauRoutier = _prefix "ElementReseauRoutier"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#AireDeTriage"></see>
    /// </summary>
    let AireDeTriage = _prefix "AireDeTriage"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#ElementReseauFerroviaire"></see>
    /// </summary>
    let ElementReseauFerroviaire = _prefix "ElementReseauFerroviaire"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#Bassin"></see>
    /// </summary>
    let Bassin = _prefix "Bassin"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#EntiteHydrographiqueTerrestre"></see>
    /// </summary>
    let EntiteHydrographiqueTerrestre = _prefix "EntiteHydrographiqueTerrestre"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#Bati"></see>
    /// </summary>
    let Bati = _prefix "Bati"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#EntiteTopographique"></see>
    /// </summary>
    let EntiteTopographique = _prefix "EntiteTopographique"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#Batiment"></see>
    /// </summary>
    let Batiment = _prefix "Batiment"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#BornePostale"></see>
    /// </summary>
    let BornePostale = _prefix "BornePostale"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#CanalisationDEau"></see>
    /// </summary>
    let CanalisationDEau = _prefix "CanalisationDEau"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#Cimetiere"></see>
    /// </summary>
    let Cimetiere = _prefix "Cimetiere"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#Conduite"></see>
    /// </summary>
    let Conduite = _prefix "Conduite"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#InfrastructureTransportEnergie"></see>
    /// </summary>
    let InfrastructureTransportEnergie = _prefix "InfrastructureTransportEnergie"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#Construction"></see>
    /// </summary>
    let Construction = _prefix "Construction"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#CoursDEau"></see>
    /// </summary>
    let CoursDEau = _prefix "CoursDEau"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#ElementDuRelief"></see>
    /// </summary>
    let ElementDuRelief = _prefix "ElementDuRelief"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#Laisse"></see>
    /// </summary>
    let Laisse = _prefix "Laisse"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#LigneElectrique"></see>
    /// </summary>
    let LigneElectrique = _prefix "LigneElectrique"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#LigneTransportCable"></see>
    /// </summary>
    let LigneTransportCable = _prefix "LigneTransportCable"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#Parking"></see>
    /// </summary>
    let Parking = _prefix "Parking"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#PisteAerodrome"></see>
    /// </summary>
    let PisteAerodrome = _prefix "PisteAerodrome"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#Place"></see>
    /// </summary>
    let Place = _prefix "Place"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#PointDEau"></see>
    /// </summary>
    let PointDEau = _prefix "PointDEau"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#PosteTransformation"></see>
    /// </summary>
    let PosteTransformation = _prefix "PosteTransformation"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#Pylone"></see>
    /// </summary>
    let Pylone = _prefix "Pylone"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#Reservoir"></see>
    /// </summary>
    let Reservoir = _prefix "Reservoir"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#Route"></see>
    /// </summary>
    let Route = _prefix "Route"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#Voie"></see>
    /// </summary>
    let Voie = _prefix "Voie"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#SurfaceDEau"></see>
    /// </summary>
    let SurfaceDEau = _prefix "SurfaceDEau"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#TerrainDeSport"></see>
    /// </summary>
    let TerrainDeSport = _prefix "TerrainDeSport"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#TypeDeBatiment"></see>
    /// </summary>
    let TypeDeBatiment = _prefix "TypeDeBatiment"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#TypeDeConstruction"></see>
    /// </summary>
    let TypeDeConstruction = _prefix "TypeDeConstruction"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#TypeDeFranchissement"></see>
    /// </summary>
    let TypeDeFranchissement = _prefix "TypeDeFranchissement"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#TypeDeLaisse"></see>
    /// </summary>
    let TypeDeLaisse = _prefix "TypeDeLaisse"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#TypeDePointDEau"></see>
    /// </summary>
    let TypeDePointDEau = _prefix "TypeDePointDEau"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#TypeDeRelief"></see>
    /// </summary>
    let TypeDeRelief = _prefix "TypeDeRelief"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#TypeDeReservoir"></see>
    /// </summary>
    let TypeDeReservoir = _prefix "TypeDeReservoir"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#TypeDeRoute"></see>
    /// </summary>
    let TypeDeRoute = _prefix "TypeDeRoute"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#TypeDeTerrainDeSport"></see>
    /// </summary>
    let TypeDeTerrainDeSport = _prefix "TypeDeTerrainDeSport"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#TypeDeTransportCable"></see>
    /// </summary>
    let TypeDeTransportCable = _prefix "TypeDeTransportCable"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#TypeDeVegetation"></see>
    /// </summary>
    let TypeDeVegetation = _prefix "TypeDeVegetation"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#TypeDeVoieFerree"></see>
    /// </summary>
    let TypeDeVoieFerree = _prefix "TypeDeVoieFerree"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#TypeDeZAI"></see>
    /// </summary>
    let TypeDeZAI = _prefix "TypeDeZAI"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#VoieFerree"></see>
    /// </summary>
    let VoieFerree = _prefix "VoieFerree"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#ZoneActiviteInteret"></see>
    /// </summary>
    let ZoneActiviteInteret = _prefix "ZoneActiviteInteret"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#ZoneDeVegetation"></see>
    /// </summary>
    let ZoneDeVegetation = _prefix "ZoneDeVegetation"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#artif"></see>
    /// </summary>
    let artif = _prefix "artif"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#borneFin"></see>
    /// </summary>
    let borneFin = _prefix "borneFin"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#borneIni"></see>
    /// </summary>
    let borneIni = _prefix "borneIni"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#clAdmin"></see>
    /// </summary>
    let clAdmin = _prefix "clAdmin"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#codePostal"></see>
    /// </summary>
    let codePostal = _prefix "codePostal"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#concerne"></see>
    /// </summary>
    let concerne = _prefix "concerne"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#electrifie"></see>
    /// </summary>
    let electrifie = _prefix "electrifie"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#enConstruction"></see>
    /// </summary>
    let enConstruction = _prefix "enConstruction"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#fictif"></see>
    /// </summary>
    let fictif = _prefix "fictif"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#gestion"></see>
    /// </summary>
    let gestion = _prefix "gestion"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#gestionVoie"></see>
    /// </summary>
    let gestionVoie = _prefix "gestionVoie"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#hauteur"></see>
    /// </summary>
    let hauteur = _prefix "hauteur"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#importance"></see>
    /// </summary>
    let importance = _prefix "importance"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#itEurop"></see>
    /// </summary>
    let itEurop = _prefix "itEurop"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#itVert"></see>
    /// </summary>
    let itVert = _prefix "itVert"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#largeurChaussee"></see>
    /// </summary>
    let largeurChaussee = _prefix "largeurChaussee"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#largeurVF"></see>
    /// </summary>
    let largeurVF = _prefix "largeurVF"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#militaire"></see>
    /// </summary>
    let militaire = _prefix "militaire"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#nature"></see>
    /// </summary>
    let nature = _prefix "nature"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#miseEnService"></see>
    /// </summary>
    let miseEnService = _prefix "miseEnService"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#nbVoiesCirculation"></see>
    /// </summary>
    let nbVoiesCirculation = _prefix "nbVoiesCirculation"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#nbVoiesFerrees"></see>
    /// </summary>
    let nbVoiesFerrees = _prefix "nbVoiesFerrees"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#nomIti"></see>
    /// </summary>
    let nomIti = _prefix "nomIti"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#numero"></see>
    /// </summary>
    let numero = _prefix "numero"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#numeroBorne"></see>
    /// </summary>
    let numeroBorne = _prefix "numeroBorne"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#origine"></see>
    /// </summary>
    let origine = _prefix "origine"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#posSol"></see>
    /// </summary>
    let posSol = _prefix "posSol"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#precAlti"></see>
    /// </summary>
    let precAlti = _prefix "precAlti"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#precPlani"></see>
    /// </summary>
    let precPlani = _prefix "precPlani"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#regime"></see>
    /// </summary>
    let regime = _prefix "regime"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#sens"></see>
    /// </summary>
    let sens = _prefix "sens"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#typAdres"></see>
    /// </summary>
    let typAdres = _prefix "typAdres"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#typeDeBatiment"></see>
    /// </summary>
    let typeDeBatiment = _prefix "typeDeBatiment"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#typeDeConstruction"></see>
    /// </summary>
    let typeDeConstruction = _prefix "typeDeConstruction"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#typeDeFranchissement"></see>
    /// </summary>
    let typeDeFranchissement = _prefix "typeDeFranchissement"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#typeDeLaisse"></see>
    /// </summary>
    let typeDeLaisse = _prefix "typeDeLaisse"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#typeDePiste"></see>
    /// </summary>
    let typeDePiste = _prefix "typeDePiste"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#typeDePointDEau"></see>
    /// </summary>
    let typeDePointDEau = _prefix "typeDePointDEau"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#typeDeRelief"></see>
    /// </summary>
    let typeDeRelief = _prefix "typeDeRelief"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#typeDeReservoir"></see>
    /// </summary>
    let typeDeReservoir = _prefix "typeDeReservoir"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#typeDeRoute"></see>
    /// </summary>
    let typeDeRoute = _prefix "typeDeRoute"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#typeDeTerrainDeSport"></see>
    /// </summary>
    let typeDeTerrainDeSport = _prefix "typeDeTerrainDeSport"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#typeDeTransportCable"></see>
    /// </summary>
    let typeDeTransportCable = _prefix "typeDeTransportCable"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#typeDeVegetation"></see>
    /// </summary>
    let typeDeVegetation = _prefix "typeDeVegetation"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#typeDeVoieFerree"></see>
    /// </summary>
    let typeDeVoieFerree = _prefix "typeDeVoieFerree"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#typeDeZAI"></see>
    /// </summary>
    let typeDeZAI = _prefix "typeDeZAI"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#voltage"></see>
    /// </summary>
    let voltage = _prefix "voltage"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#zFin"></see>
    /// </summary>
    let zFin = _prefix "zFin"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#zIni"></see>
    /// </summary>
    let zIni = _prefix "zIni"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#zMax"></see>
    /// </summary>
    let zMax = _prefix "zMax"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#zMin"></see>
    /// </summary>
    let zMin = _prefix "zMin"
    /// <summary>
    ///   <see href="http://data.ign.fr/def/topo#zMoyen"></see>
    /// </summary>
    let zMoyen = _prefix "zMoyen"
