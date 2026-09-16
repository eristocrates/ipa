#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module topo =
    let _prefixId = PrefixId.fromNamespaceLabel "http://data.ign.fr/def/topo#" "topo"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Toll-gate areardfs:label : Aire de pÃ©age</para>
    ///   <para>rdfs:comment : Emprise de la chaussÃ©e d'une aire de pÃ©age.</para>
    ///   <a href="http://data.ign.fr/def/topo#AireDePeage">topo:AireDePeage</a>
    /// </summary>
    let AireDePeage = _prefixId.prefix "AireDePeage"
    /// <summary>
    ///   <para>rdfs:label : Marshalling yardrdfs:label : Aire de triage</para>
    ///   <para>rdfs:comment : Surface qui englobe lâ€™ensemble des tronÃ§ons de voies, voies de garage, aiguillages permettant le tri des wagons et la composition des trains. Aire de triage, faisceau de voies.</para>
    ///   <a href="http://data.ign.fr/def/topo#AireDeTriage">topo:AireDeTriage</a>
    /// </summary>
    let AireDeTriage = _prefixId.prefix "AireDeTriage"
    /// <summary>
    ///   <para>rdfs:label : Basinrdfs:label : Bassin</para>
    ///   <para>rdfs:comment : Construction non couverte destinÃ©e Ã  recevoir de l'eau temporairement ou de maniÃ¨re permanente.</para>
    ///   <a href="http://data.ign.fr/def/topo#Bassin">topo:Bassin</a>
    /// </summary>
    let Bassin = _prefixId.prefix "Bassin"
    /// <summary>
    ///   <para>rdfs:label : Buildings and structuresrdfs:label : BÃ¢ti</para>
    ///   <para>rdfs:comment : BÃ¢timents (indiffÃ©renciÃ©s, industriels et remarquables) et autres constructions.</para>
    ///   <a href="http://data.ign.fr/def/topo#Bati">topo:Bati</a>
    /// </summary>
    let Bati = _prefixId.prefix "Bati"
    /// <summary>
    ///   <para>rdfs:label : Buildingrdfs:label : BÃ¢timent</para>
    ///   <para>rdfs:comment : Construction d'une certaine importance destinÃ©e Ã  abriter des personnes, des choses ou des animaux.</para>
    ///   <a href="http://data.ign.fr/def/topo#Batiment">topo:Batiment</a>
    /// </summary>
    let Batiment = _prefixId.prefix "Batiment"
    /// <summary>
    ///   <para>rdfs:label : Civic number markerrdfs:label : Borne postale</para>
    ///   <para>rdfs:comment : Borne postale situÃ©e Ã  l'extrÃ©mitÃ© d'un tronÃ§on de route.</para>
    ///   <a href="http://data.ign.fr/def/topo#BornePostale">topo:BornePostale</a>
    /// </summary>
    let BornePostale = _prefixId.prefix "BornePostale"
    /// <summary>
    ///   <para>rdfs:label : Water piperdfs:label : Canalisation d'eau</para>
    ///   <para>rdfs:comment : Canalisation d'eau aÃ©rienne.</para>
    ///   <a href="http://data.ign.fr/def/topo#CanalisationDEau">topo:CanalisationDEau</a>
    /// </summary>
    let CanalisationDEau = _prefixId.prefix "CanalisationDEau"
    /// <summary>
    ///   <para>rdfs:label : Cemeteryrdfs:label : CimetiÃ¨re</para>
    ///   <para>rdfs:comment : Lieu oÃ¹ lâ€™on enterre les morts.</para>
    ///   <a href="http://data.ign.fr/def/topo#Cimetiere">topo:Cimetiere</a>
    /// </summary>
    let Cimetiere = _prefixId.prefix "Cimetiere"
    /// <summary>
    ///   <para>rdfs:label : Pipelinerdfs:label : Conduite</para>
    ///   <para>rdfs:comment : Conduite (autre que canalisation dâ€™eau) ou tapis roulant utilisÃ©s pour le transport de matiÃ¨re premiÃ¨re (gaz, hydrocarbure, minerai, etc.) ou canalisation de nature inconnue.</para>
    ///   <a href="http://data.ign.fr/def/topo#Conduite">topo:Conduite</a>
    /// </summary>
    let Conduite = _prefixId.prefix "Conduite"
    /// <summary>
    ///   <para>rdfs:label : Structurerdfs:label : Construction</para>
    ///   <para>rdfs:comment : Ouvrage de gÃ©nie civil.</para>
    ///   <a href="http://data.ign.fr/def/topo#Construction">topo:Construction</a>
    /// </summary>
    let Construction = _prefixId.prefix "Construction"
    /// <summary>
    ///   <para>rdfs:label : Watercourserdfs:label : Cours d'eau</para>
    ///   <para>rdfs:comment : Portion de cours d'eau, rÃ©el ou fictif, permanent ou temporaire, naturel ou artificiel, homogÃ¨ne pour l'ensemble des attributs qui la concernent, et qui n'inclut pas de confluent.</para>
    ///   <a href="http://data.ign.fr/def/topo#CoursDEau">topo:CoursDEau</a>
    /// </summary>
    let CoursDEau = _prefixId.prefix "CoursDEau"
    /// <summary>
    ///   <para>rdfs:label : Relief featurerdfs:label : Ã‰lÃ©ment du relief</para>
    ///   <para>rdfs:comment : EntitÃ© topographique correspondant Ã  une rupture de pente artificielle, ou Ã  un Ã©lÃ©ment remarquable du relief nommÃ©.</para>
    ///   <a href="http://data.ign.fr/def/topo#ElementDuRelief">topo:ElementDuRelief</a>
    /// </summary>
    let ElementDuRelief = _prefixId.prefix "ElementDuRelief"
    /// <summary>
    ///   <para>rdfs:label : Transport by rail featurerdfs:label : Ã‰lÃ©ment du rÃ©seau ferroviaire</para>
    ///   <para>rdfs:comment : Ã‰lÃ©ments du rÃ©seau de transport ferroviaire: voies ferrÃ©es et aires de triage.</para>
    ///   <a href="http://data.ign.fr/def/topo#ElementReseauFerroviaire">topo:ElementReseauFerroviaire</a>
    /// </summary>
    let ElementReseauFerroviaire = _prefixId.prefix "ElementReseauFerroviaire"
    /// <summary>
    ///   <para>rdfs:label : Road transport featurerdfs:label : Ã‰lÃ©ment du rÃ©seau routier</para>
    ///   <para>rdfs:comment : Ã‰lÃ©ments du rÃ©seau de transport routier: voies de communication revÃªtues et non revÃªtues, rÃ©seau 'adressÃ©', et une sÃ©lection des chemins et sentiers.</para>
    ///   <a href="http://data.ign.fr/def/topo#ElementReseauRoutier">topo:ElementReseauRoutier</a>
    /// </summary>
    let ElementReseauRoutier = _prefixId.prefix "ElementReseauRoutier"
    /// <summary>
    ///   <para>rdfs:label : Inland hydrographic featurerdfs:label : EntitÃ© hydrographique terrestre</para>
    ///   <para>rdfs:comment : EntitÃ© topographique relative au rÃ©seau hydrographique terrestre, Ã  la production ou au stockage d'eau.</para>
    ///   <a href="http://data.ign.fr/def/topo#EntiteHydrographiqueTerrestre">topo:EntiteHydrographiqueTerrestre</a>
    /// </summary>
    let EntiteHydrographiqueTerrestre = _prefixId.prefix "EntiteHydrographiqueTerrestre"
    /// <summary>
    ///   <para>rdfs:label : Topographic entityrdfs:label : EntitÃ© topographique</para>
    ///   <para>rdfs:comment : Un phÃ©nomÃ¨ne du monde rÃ©el qui est associÃ© Ã  une localisation sur la terre</para>
    ///   <a href="http://data.ign.fr/def/topo#EntiteTopographique">topo:EntiteTopographique</a>
    /// </summary>
    let EntiteTopographique = _prefixId.prefix "EntiteTopographique"

    /// <summary>
    ///   <para>rdfs:label : Energy transport infrastructurerdfs:label : Infrastructure de transport d'Ã©nergie</para>
    ///   <para>rdfs:comment : Ã‰lÃ©ments du rÃ©seau de transport d'Ã©lectricitÃ© Ã  une haute et trÃ¨s haute tension, et conduites utilisÃ©es pour le transport de matiÃ¨re premiÃ¨re.</para>
    ///   <a href="http://data.ign.fr/def/topo#InfrastructureTransportEnergie">topo:InfrastructureTransportEnergie</a>
    /// </summary>
    let InfrastructureTransportEnergie = _prefixId.prefix "InfrastructureTransportEnergie"

    /// <summary>
    ///   <para>rdfs:label : Tide linerdfs:label : Laisse</para>
    ///   <para>rdfs:comment : Limite supÃ©rieure ou infÃ©rieure de l'estran.</para>
    ///   <a href="http://data.ign.fr/def/topo#Laisse">topo:Laisse</a>
    /// </summary>
    let Laisse = _prefixId.prefix "Laisse"
    /// <summary>
    ///   <para>rdfs:label : Electricity transmission linerdfs:label : Ligne Ã©lectrique</para>
    ///   <para>rdfs:comment : Portion de ligne Ã©lectrique homogÃ¨ne pour l'ensemble des attributs qui la concernent.</para>
    ///   <a href="http://data.ign.fr/def/topo#LigneElectrique">topo:LigneElectrique</a>
    /// </summary>
    let LigneElectrique = _prefixId.prefix "LigneElectrique"
    /// <summary>
    ///   <para>rdfs:label : Cableway transport linerdfs:label : Ligne de transport par cÃ¢ble</para>
    ///   <para>rdfs:comment : Moyen de transport constituÃ© d'un ou de plusieurs cÃ¢bles porteurs.</para>
    ///   <a href="http://data.ign.fr/def/topo#LigneTransportCable">topo:LigneTransportCable</a>
    /// </summary>
    let LigneTransportCable = _prefixId.prefix "LigneTransportCable"
    /// <summary>
    ///   <para>rdfs:label : Car parkrdfs:label : Parking</para>
    ///   <para>rdfs:comment : Zone amÃ©nagÃ©e pour le parcage des automobiles. Parking non couvert, public ou privÃ©, aire de stationnement dâ€™environ un demi hectare et plus.</para>
    ///   <a href="http://data.ign.fr/def/topo#Parking">topo:Parking</a>
    /// </summary>
    let Parking = _prefixId.prefix "Parking"
    /// <summary>
    ///   <para>rdfs:label : Taxiwayrdfs:label : Piste d'aÃ©rodrome</para>
    ///   <para>rdfs:comment : Aire situÃ©e sur un aÃ©rodrome, amÃ©nagÃ©e afin de servir au roulement des aÃ©ronefs, au dÃ©collage et Ã  lâ€™atterrissage, en dur ou en herbe.</para>
    ///   <a href="http://data.ign.fr/def/topo#PisteAerodrome">topo:PisteAerodrome</a>
    /// </summary>
    let PisteAerodrome = _prefixId.prefix "PisteAerodrome"
    /// <summary>
    ///   <para>rdfs:label : Squarerdfs:label : Place</para>
    ///   <para>rdfs:comment : Place ou carrefour revÃªtu de grande largeur.</para>
    ///   <a href="http://data.ign.fr/def/topo#Place">topo:Place</a>
    /// </summary>
    let Place = _prefixId.prefix "Place"
    /// <summary>
    ///   <para>rdfs:label : Waterholerdfs:label : Point d'eau</para>
    ///   <para>rdfs:comment : Source (captÃ©e ou non), point de production dâ€™eau (pompage, forage, puits,...) ou point de stockage dâ€™eau de petite dimension (citerne, abreuvoir, lavoir, bassin).</para>
    ///   <a href="http://data.ign.fr/def/topo#PointDEau">topo:PointDEau</a>
    /// </summary>
    let PointDEau = _prefixId.prefix "PointDEau"
    /// <summary>
    ///   <para>rdfs:label : Transformation sub-stationrdfs:label : Poste de transformation</para>
    ///   <para>rdfs:comment : Enceinte Ã  l'intÃ©rieur de laquelle le courant transportÃ© par une ligne Ã©lectrique est transformÃ©.</para>
    ///   <a href="http://data.ign.fr/def/topo#PosteTransformation">topo:PosteTransformation</a>
    /// </summary>
    let PosteTransformation = _prefixId.prefix "PosteTransformation"
    /// <summary>
    ///   <para>rdfs:label : Pylonrdfs:label : PylÃ´ne</para>
    ///   <para>rdfs:comment : Support de ligne Ã©lectrique. PylÃ´ne, portique.</para>
    ///   <a href="http://data.ign.fr/def/topo#Pylone">topo:Pylone</a>
    /// </summary>
    let Pylone = _prefixId.prefix "Pylone"
    /// <summary>
    ///   <para>rdfs:label : Tankrdfs:label : RÃ©servoir</para>
    ///   <para>rdfs:comment : RÃ©servoir (eau, matiÃ¨res industrielles,...) de plus de 10m de diamÃ¨tre.</para>
    ///   <a href="http://data.ign.fr/def/topo#Reservoir">topo:Reservoir</a>
    /// </summary>
    let Reservoir = _prefixId.prefix "Reservoir"
    /// <summary>
    ///   <para>rdfs:label : Roadrdfs:label : Route</para>
    ///   <para>rdfs:comment : Portion de voie de communication destinÃ©e aux automobiles, aux piÃ©tons, aux cycles ou aux animaux, homogÃ¨ne pour l'ensemble des attributs et des relations qui la concerne. Le tronÃ§on de route peut Ãªtre revÃªtu ou non revÃªtu (pas de revÃªtement de surface ou revÃªtement de surface fortement dÃ©gradÃ©).</para>
    ///   <a href="http://data.ign.fr/def/topo#Route">topo:Route</a>
    /// </summary>
    let Route = _prefixId.prefix "Route"
    /// <summary>
    ///   <para>rdfs:label : Water surfacerdfs:label : Surface d'eau</para>
    ///   <para>rdfs:comment : Surface d'eau non marine : large canal, Ã©tang, large fleuve, lac, mare, large riviÃ¨re.</para>
    ///   <a href="http://data.ign.fr/def/topo#SurfaceDEau">topo:SurfaceDEau</a>
    /// </summary>
    let SurfaceDEau = _prefixId.prefix "SurfaceDEau"
    /// <summary>
    ///   <para>rdfs:label : Sports groundrdfs:label : Terrain de sport</para>
    ///   <para>rdfs:comment : Ã‰quipement sportif de plein air.</para>
    ///   <a href="http://data.ign.fr/def/topo#TerrainDeSport">topo:TerrainDeSport</a>
    /// </summary>
    let TerrainDeSport = _prefixId.prefix "TerrainDeSport"
    /// <summary>
    ///   <para>rdfs:comment : Regroupe l'ensemble des instances dÃ©signant des types de bÃ¢timents.</para>
    ///   <para>rdfs:label : Type of building rdfs:label : Type de bÃ¢timent</para>
    ///   <a href="http://data.ign.fr/def/topo#TypeDeBatiment">topo:TypeDeBatiment</a>
    /// </summary>
    let TypeDeBatiment = _prefixId.prefix "TypeDeBatiment"
    /// <summary>
    ///   <para>rdfs:comment : Regroupe l'ensemble des instances dÃ©signant des types de constructions.</para>
    ///   <para>rdfs:label : Type of structurerdfs:label : Type de construction</para>
    ///   <a href="http://data.ign.fr/def/topo#TypeDeConstruction">topo:TypeDeConstruction</a>
    /// </summary>
    let TypeDeConstruction = _prefixId.prefix "TypeDeConstruction"
    /// <summary>
    ///   <para>rdfs:comment : Regroupe l'ensemble des instances dÃ©signant des types d'ouvrages de franchissement.</para>
    ///   <para>rdfs:label : Type of crossingrdfs:label : Type de franchissement</para>
    ///   <a href="http://data.ign.fr/def/topo#TypeDeFranchissement">topo:TypeDeFranchissement</a>
    /// </summary>
    let TypeDeFranchissement = _prefixId.prefix "TypeDeFranchissement"
    /// <summary>
    ///   <para>rdfs:comment : Regroupe l'ensemble des instances dÃ©signant des types de laisses.</para>
    ///   <para>rdfs:label : Type of tide linerdfs:label : Type de laisse</para>
    ///   <a href="http://data.ign.fr/def/topo#TypeDeLaisse">topo:TypeDeLaisse</a>
    /// </summary>
    let TypeDeLaisse = _prefixId.prefix "TypeDeLaisse"
    /// <summary>
    ///   <para>rdfs:comment : Regroupe l'ensemble des instances dÃ©signant des types de points d'eau.</para>
    ///   <para>rdfs:label : Type of waterholerdfs:label : Type de point d'eau</para>
    ///   <a href="http://data.ign.fr/def/topo#TypeDePointDEau">topo:TypeDePointDEau</a>
    /// </summary>
    let TypeDePointDEau = _prefixId.prefix "TypeDePointDEau"
    /// <summary>
    ///   <para>rdfs:comment : Regroupe l'ensemble des instances dÃ©signant des types de reliefs.</para>
    ///   <para>rdfs:label : Type of relief featurerdfs:label : Type d'Ã©lÃ©ment du relief</para>
    ///   <a href="http://data.ign.fr/def/topo#TypeDeRelief">topo:TypeDeRelief</a>
    /// </summary>
    let TypeDeRelief = _prefixId.prefix "TypeDeRelief"
    /// <summary>
    ///   <para>rdfs:comment : Regroupe l'ensemble des instances dÃ©signant des types de rÃ©servoirs.</para>
    ///   <para>rdfs:label : Type of tankrdfs:label : Type de rÃ©servoir</para>
    ///   <a href="http://data.ign.fr/def/topo#TypeDeReservoir">topo:TypeDeReservoir</a>
    /// </summary>
    let TypeDeReservoir = _prefixId.prefix "TypeDeReservoir"
    /// <summary>
    ///   <para>rdfs:comment : Regroupe l'ensemble des instances dÃ©signant des types de routes.</para>
    ///   <para>rdfs:label : Type of roadrdfs:label : Type de route</para>
    ///   <a href="http://data.ign.fr/def/topo#TypeDeRoute">topo:TypeDeRoute</a>
    /// </summary>
    let TypeDeRoute = _prefixId.prefix "TypeDeRoute"
    /// <summary>
    ///   <para>rdfs:comment : Regroupe l'ensemble des instances dÃ©signant des types de terrains de sports.</para>
    ///   <para>rdfs:label : Type of sports ground rdfs:label : Type de terrain de sport</para>
    ///   <a href="http://data.ign.fr/def/topo#TypeDeTerrainDeSport">topo:TypeDeTerrainDeSport</a>
    /// </summary>
    let TypeDeTerrainDeSport = _prefixId.prefix "TypeDeTerrainDeSport"
    /// <summary>
    ///   <para>rdfs:comment : Regroupe l'ensemble des instances dÃ©signant des types d'infrastructures de transport par cÃ¢ble.</para>
    ///   <para>rdfs:label : Type of cableway transport linerdfs:label : Type de ligne de transport par cÃ¢ble</para>
    ///   <a href="http://data.ign.fr/def/topo#TypeDeTransportCable">topo:TypeDeTransportCable</a>
    /// </summary>
    let TypeDeTransportCable = _prefixId.prefix "TypeDeTransportCable"
    /// <summary>
    ///   <para>rdfs:comment : Regroupe l'ensemble des instances dÃ©signant des types de vÃ©gÃ©tation arborÃ©e.</para>
    ///   <para>rdfs:label : Type of vegetation rdfs:label : Type de vÃ©gÃ©tation</para>
    ///   <a href="http://data.ign.fr/def/topo#TypeDeVegetation">topo:TypeDeVegetation</a>
    /// </summary>
    let TypeDeVegetation = _prefixId.prefix "TypeDeVegetation"
    /// <summary>
    ///   <para>rdfs:comment : Regroupe l'ensemble des instances dÃ©signant des types de voies ferrÃ©es.</para>
    ///   <para>rdfs:label : Type of railway trackrdfs:label : Type de voie ferrÃ©e</para>
    ///   <a href="http://data.ign.fr/def/topo#TypeDeVoieFerree">topo:TypeDeVoieFerree</a>
    /// </summary>
    let TypeDeVoieFerree = _prefixId.prefix "TypeDeVoieFerree"
    /// <summary>
    ///   <para>rdfs:comment : Regroupe l'ensemble des instances dÃ©signant des types de zones d'activitÃ©s et d'intÃ©rÃªt.</para>
    ///   <para>rdfs:label : Type of Area Of Interest (AOI)rdfs:label : Type de ZAI</para>
    ///   <a href="http://data.ign.fr/def/topo#TypeDeZAI">topo:TypeDeZAI</a>
    /// </summary>
    let TypeDeZAI = _prefixId.prefix "TypeDeZAI"
    /// <summary>
    ///   <para>rdfs:label : Named streetrdfs:label : Voie nommÃ©e</para>
    ///   <para>rdfs:comment : Une voie est un ensemble de tronÃ§ons de route associÃ©s Ã  un mÃªme nom. Une voie est identifiÃ©e par son nom dans une commune donnÃ©e. Le nom de voie est celui qui sert Ã  lâ€™adressage.</para>
    ///   <a href="http://data.ign.fr/def/topo#Voie">topo:Voie</a>
    /// </summary>
    let Voie = _prefixId.prefix "Voie"
    /// <summary>
    ///   <para>rdfs:label : Railway trackrdfs:label : Voie ferrÃ©e</para>
    ///   <para>rdfs:comment : Portion de voie ferrÃ©e homogÃ¨ne pour l'ensemble des attributs qui la concernent. Dans le cas dâ€™une ligne composÃ©e de deux Ã  quatre voies parallÃ¨les, lâ€™ensemble des voies est modÃ©lisÃ© par un seul objet.</para>
    ///   <a href="http://data.ign.fr/def/topo#VoieFerree">topo:VoieFerree</a>
    /// </summary>
    let VoieFerree = _prefixId.prefix "VoieFerree"
    /// <summary>
    ///   <para>rdfs:label : Working area or area of interestrdfs:label : Zone d'activitÃ© ou d'intÃ©rÃªt</para>
    ///   <para>rdfs:comment : BÃ¢timent ou site ayant une vocation ou un caractÃ¨re particuliers (administratif, religieux, sportif, industriel, etc.).</para>
    ///   <a href="http://data.ign.fr/def/topo#ZoneActiviteInteret">topo:ZoneActiviteInteret</a>
    /// </summary>
    let ZoneActiviteInteret = _prefixId.prefix "ZoneActiviteInteret"
    /// <summary>
    ///   <para>rdfs:label : Vegetation areardfs:label : Zone de vÃ©gÃ©tation</para>
    ///   <para>rdfs:comment : Espace vÃ©gÃ©tal naturel ou non diffÃ©renciÃ© selon le couvert forestier.</para>
    ///   <a href="http://data.ign.fr/def/topo#ZoneDeVegetation">topo:ZoneDeVegetation</a>
    /// </summary>
    let ZoneDeVegetation = _prefixId.prefix "ZoneDeVegetation"
    /// <summary>
    ///   <para>rdfs:label : artificialrdfs:label : artificiel</para>
    ///   <para>rdfs:comment : Permet de distinguer les cours d'eau naturels des cours d'eau artificiels ou artificialisÃ©s.</para>
    ///   <a href="http://data.ign.fr/def/topo#artif">topo:artif</a>
    /// </summary>
    let artif = _prefixId.prefix "artif"
    /// <summary>
    ///   <para>rdfs:label : final civic number markerrdfs:label : borne finale</para>
    ///   <para>rdfs:comment : Relation entre un tronÃ§on de route et la borne postale correspondant Ã  son point final.</para>
    ///   <a href="http://data.ign.fr/def/topo#borneFin">topo:borneFin</a>
    /// </summary>
    let borneFin = _prefixId.prefix "borneFin"
    /// <summary>
    ///   <para>rdfs:label : initial civic number markerrdfs:label : borne initiale</para>
    ///   <para>rdfs:comment : Relation entre un tronÃ§on de route et la borne postale correspondant Ã  son point initial.</para>
    ///   <a href="http://data.ign.fr/def/topo#borneIni">topo:borneIni</a>
    /// </summary>
    let borneIni = _prefixId.prefix "borneIni"
    /// <summary>
    ///   <para>rdfs:label : administrative statusrdfs:label : classement administratif</para>
    ///   <para>rdfs:comment : Classement administratif. Statut dâ€™une route numÃ©rotÃ©e ou nommÃ©e.</para>
    ///   <a href="http://data.ign.fr/def/topo#clAdmin">topo:clAdmin</a>
    /// </summary>
    let clAdmin = _prefixId.prefix "clAdmin"
    /// <summary>
    ///   <para>rdfs:label : postal coderdfs:label : code postal</para>
    ///   <para>rdfs:comment : NumÃ©ro de code postal.</para>
    ///   <a href="http://data.ign.fr/def/topo#codePostal">topo:codePostal</a>
    /// </summary>
    let codePostal = _prefixId.prefix "codePostal"
    /// <summary>
    ///   <para>rdfs:label : related tordfs:label : concerne</para>
    ///   <para>rdfs:comment : Relation entre une borne postale et la voie Ã  laquelle elle se rapporte.</para>
    ///   <a href="http://data.ign.fr/def/topo#concerne">topo:concerne</a>
    /// </summary>
    let concerne = _prefixId.prefix "concerne"
    /// <summary>
    ///   <para>rdfs:label : electrifiedrdfs:label : Ã©lectrifiÃ©</para>
    ///   <para>rdfs:comment : DÃ©signe le type d'Ã©nergie servant Ã  la propulsion des locomotives. Prends la valeur 'vrai' s'il s'agit d'une ligne Ã©lectrifiÃ©e.</para>
    ///   <a href="http://data.ign.fr/def/topo#electrifie">topo:electrifie</a>
    /// </summary>
    let electrifie = _prefixId.prefix "electrifie"
    /// <summary>
    ///   <para>rdfs:label : under constructionrdfs:label : en construction</para>
    ///   <para>rdfs:comment : Indique l'Ã©tat d'une entitÃ© topographique artificielle. Renvoie 'vrai' si cette entitÃ© est en cours de construction.</para>
    ///   <a href="http://data.ign.fr/def/topo#enConstruction">topo:enConstruction</a>
    /// </summary>
    let enConstruction = _prefixId.prefix "enConstruction"
    /// <summary>
    ///   <para>rdfs:label : dummyrdfs:label : fictif</para>
    ///   <para>rdfs:comment : La valeur 'oui' indique que la gÃ©omÃ©trie du tronÃ§on de rÃ©seau n'est pas significative.</para>
    ///   <a href="http://data.ign.fr/def/topo#fictif">topo:fictif</a>
    /// </summary>
    let fictif = _prefixId.prefix "fictif"
    /// <summary>
    ///   <para>rdfs:label : managerrdfs:label : gestionnaire</para>
    ///   <para>rdfs:comment : DÃ©finit le gestionnaire administratif dâ€™une route. Toutes les routes classÃ©es possÃ¨dent un â€˜Gestionnaireâ€™.</para>
    ///   <a href="http://data.ign.fr/def/topo#gestion">topo:gestion</a>
    /// </summary>
    let gestion = _prefixId.prefix "gestion"
    /// <summary>
    ///   <para>rdfs:label : manager of the nammed streetrdfs:label : commune gestionnaire de la voie nommÃ©e</para>
    ///   <para>rdfs:comment : Relation entre une voie nommÃ©e et la commune dont elle dÃ©pend.</para>
    ///   <a href="http://data.ign.fr/def/topo#gestionVoie">topo:gestionVoie</a>
    /// </summary>
    let gestionVoie = _prefixId.prefix "gestionVoie"
    /// <summary>
    ///   <para>rdfs:label : heightrdfs:label : hauteur</para>
    ///   <para>rdfs:comment : Hauteur du bÃ¢timent correspondant Ã  la diffÃ©rence entre le Z le plus Ã©levÃ© du pourtour du bÃ¢timent et un point situÃ© au pied du bÃ¢timent.</para>
    ///   <a href="http://data.ign.fr/def/topo#hauteur">topo:hauteur</a>
    /// </summary>
    let hauteur = _prefixId.prefix "hauteur"
    /// <summary>
    ///   <para>rdfs:label : importancerdfs:label : importance</para>
    ///   <para>rdfs:comment : Importance du toponyme dans son environnement. Le toponyme de valeur 1 est plus important que le toponyme de valeur 2, lui-mÃªme plus important que le toponyme de valeur 3, etc.</para>
    ///   <a href="http://data.ign.fr/def/topo#importance">topo:importance</a>
    /// </summary>
    let importance = _prefixId.prefix "importance"
    /// <summary>
    ///   <para>rdfs:label : european itineraryrdfs:label : itinÃ©raire europÃ©en</para>
    ///   <para>rdfs:comment : NumÃ©ro de route europÃ©enne : une route europÃ©enne emprunte en gÃ©nÃ©ral le rÃ©seau autoroutier ou national (exceptionnellement dÃ©partemental ou non classÃ©).</para>
    ///   <a href="http://data.ign.fr/def/topo#itEurop">topo:itEurop</a>
    /// </summary>
    let itEurop = _prefixId.prefix "itEurop"
    /// <summary>
    ///   <para>rdfs:label : green itineraryrdfs:label : itinÃ©raire vert</para>
    ///   <para>rdfs:comment : Indique lâ€™appartenance ou non dâ€™un tronÃ§on routier au rÃ©seau vert. Le rÃ©seau vert, composÃ© de pÃ´les verts et de liaisons vertes, couvre lâ€™ensemble du territoire franÃ§ais. Les pÃ´les verts sont composÃ©s de communes de plus de 23.000 habitants en province et de 39.000 habitants en Ile-de-France, ainsi que certains pÃ´les dâ€™activitÃ©s administratifs, Ã©conomiques, touristiques ou industriels. On retient seulement le rÃ©seau vert de transit entre pÃ´les verts. Le rÃ©seau vert de rabattement, Ã  lâ€™intÃ©rieur des villes, et le rÃ©seau vert conseillÃ© aux poids lourds ne sont pas retenus.</para>
    ///   <a href="http://data.ign.fr/def/topo#itVert">topo:itVert</a>
    /// </summary>
    let itVert = _prefixId.prefix "itVert"
    /// <summary>
    ///   <para>rdfs:label : carriageway widthrdfs:label : largeur de chaussÃ©e</para>
    ///   <para>rdfs:comment : Largeur de chaussÃ©e (dâ€™accotement Ã  accotement) exprimÃ©e en mÃ¨tres.</para>
    ///   <a href="http://data.ign.fr/def/topo#largeurChaussee">topo:largeurChaussee</a>
    /// </summary>
    let largeurChaussee = _prefixId.prefix "largeurChaussee"
    /// <summary>
    ///   <para>rdfs:label : railway track widthrdfs:label : largeur de la voie ferrÃ©e</para>
    ///   <para>rdfs:comment : Attribut permettant de distinguer les voies ferrÃ©es de largeur standard (normale) pour la France (1,435 m), des voies ferrÃ©es plus larges ou plus Ã©troites.</para>
    ///   <a href="http://data.ign.fr/def/topo#largeurVF">topo:largeurVF</a>
    /// </summary>
    let largeurVF = _prefixId.prefix "largeurVF"
    /// <summary>
    ///   <para>rdfs:label : military featurerdfs:label : entitÃ© Ã  vocation militaire</para>
    ///   <para>rdfs:comment : Attribut permettant de distinguer une entitÃ© topographique Ã  vocation militaire ou simplement gÃ©rÃ©e par le ministÃ¨re de la dÃ©fense d'une entitÃ© civile. La valeur Â« vrai Â» est Ã©galement affectÃ©e aux cimetiÃ¨res militaires gÃ©rÃ©s par le MinistÃ¨re des Anciens Combattants ou par des Ã©tats Ã©trangers.</para>
    ///   <a href="http://data.ign.fr/def/topo#militaire">topo:militaire</a>
    /// </summary>
    let militaire = _prefixId.prefix "militaire"
    /// <summary>
    ///   <para>rdfs:label : in service daterdfs:label : date de mise en service</para>
    ///   <para>rdfs:comment : DÃ©finit la date prÃ©vue ou la date effective de mise en service dâ€™un tronÃ§on de route. Cet attribut n'est rempli que pour les tronÃ§ons en construction, il est Ã  â€œNRâ€œ dans les autres cas. Les tronÃ§ons qui possÃ¨dent une date de mise en service sont complÃ¨tement fermÃ©s aux vÃ©hicules avant cette date.</para>
    ///   <a href="http://data.ign.fr/def/topo#miseEnService">topo:miseEnService</a>
    /// </summary>
    let miseEnService = _prefixId.prefix "miseEnService"
    /// <summary>
    ///   <para>rdfs:comment : Relie une entitÃ© topographique au concept qui prÃ©cise sa nature.</para>
    ///   <para>rdfs:label : naturerdfs:label : nature</para>
    ///   <a href="http://data.ign.fr/def/topo#nature">topo:nature</a>
    /// </summary>
    let nature = _prefixId.prefix "nature"
    /// <summary>
    ///   <para>rdfs:label : number of traffic lanesrdfs:label : nombre de voies de circulation</para>
    ///   <para>rdfs:comment : Nombre total de voies dâ€™une route, dâ€™une rue ou dâ€™une chaussÃ©e de route Ã  chaussÃ©es sÃ©parÃ©es.</para>
    ///   <a href="http://data.ign.fr/def/topo#nbVoiesCirculation">topo:nbVoiesCirculation</a>
    /// </summary>
    let nbVoiesCirculation = _prefixId.prefix "nbVoiesCirculation"
    /// <summary>
    ///   <para>rdfs:label : number of tracksrdfs:label : nombre de voies ferrÃ©es</para>
    ///   <para>rdfs:comment : Nombre de voies constituant cette portion de ligne de chemin de fer. La valeur 0 indique que le nombre de voies est inconnu.</para>
    ///   <a href="http://data.ign.fr/def/topo#nbVoiesFerrees">topo:nbVoiesFerrees</a>
    /// </summary>
    let nbVoiesFerrees = _prefixId.prefix "nbVoiesFerrees"
    /// <summary>
    ///   <para>rdfs:label : name of itineraryrdfs:label : nom d'itinÃ©raire</para>
    ///   <para>rdfs:comment : DÃ©finit un parcours routier nommÃ©.</para>
    ///   <a href="http://data.ign.fr/def/topo#nomIti">topo:nomIti</a>
    /// </summary>
    let nomIti = _prefixId.prefix "nomIti"
    /// <summary>
    ///   <para>rdfs:label : numberrdfs:label : numÃ©ro</para>
    ///   <para>rdfs:comment : DÃ©signe le classement administratif d'un tronÃ§on routier.</para>
    ///   <a href="http://data.ign.fr/def/topo#numero">topo:numero</a>
    /// </summary>
    let numero = _prefixId.prefix "numero"
    /// <summary>
    ///   <para>rdfs:label : civic numberrdfs:label : numÃ©ro de borne postale</para>
    ///   <para>rdfs:comment : NumÃ©ro de borne postale.</para>
    ///   <a href="http://data.ign.fr/def/topo#numeroBorne">topo:numeroBorne</a>
    /// </summary>
    let numeroBorne = _prefixId.prefix "numeroBorne"
    /// <summary>
    ///   <para>rdfs:label : originerdfs:label : origine</para>
    ///   <para>rdfs:comment : Source de l'information.</para>
    ///   <a href="http://data.ign.fr/def/topo#origine">topo:origine</a>
    /// </summary>
    let origine = _prefixId.prefix "origine"
    /// <summary>
    ///   <para>rdfs:label : position in relation to the groundrdfs:label : position par rapport au sol</para>
    ///   <para>rdfs:comment : Position par rapport au sol. Donne le niveau de lâ€™objet par rapport Ã  la surface du sol (valeur nulle pour un objet au sol, nÃ©gative pour un objet situÃ© au-dessous du niveau du sol et positive pour un objet en sursol).</para>
    ///   <a href="http://data.ign.fr/def/topo#posSol">topo:posSol</a>
    /// </summary>
    let posSol = _prefixId.prefix "posSol"
    /// <summary>
    ///   <para>rdfs:label : altimetric accuracyrdfs:label : prÃ©cision altimÃ©trique</para>
    ///   <para>rdfs:comment : PrÃ©cision gÃ©omÃ©trique altimÃ©trique.</para>
    ///   <a href="http://data.ign.fr/def/topo#precAlti">topo:precAlti</a>
    /// </summary>
    let precAlti = _prefixId.prefix "precAlti"
    /// <summary>
    ///   <para>rdfs:label : planimetric accuracyrdfs:label : prÃ©cision planimÃ©trique</para>
    ///   <para>rdfs:comment : PrÃ©cision gÃ©omÃ©trique planimÃ©trique.</para>
    ///   <a href="http://data.ign.fr/def/topo#precPlani">topo:precPlani</a>
    /// </summary>
    let precPlani = _prefixId.prefix "precPlani"
    /// <summary>
    ///   <para>rdfs:label : water regimerdfs:label : rÃ©gime des eaux</para>
    ///   <para>rdfs:comment : Attribut permettant de caractÃ©riser un objet hydrographique en fonction du rÃ©gime des eaux.</para>
    ///   <a href="http://data.ign.fr/def/topo#regime">topo:regime</a>
    /// </summary>
    let regime = _prefixId.prefix "regime"
    /// <summary>
    ///   <para>rdfs:label : direction of trafficrdfs:label : sens de circulation</para>
    ///   <para>rdfs:comment : Sens de circulation autorisÃ©e pour les automobiles sur les voies.</para>
    ///   <a href="http://data.ign.fr/def/topo#sens">topo:sens</a>
    /// </summary>
    let sens = _prefixId.prefix "sens"
    /// <summary>
    ///   <para>rdfs:label : type of addressingrdfs:label : type dâ€™adressage</para>
    ///   <para>rdfs:comment : Renseigne sur le type dâ€™adressage du tronÃ§on.</para>
    ///   <a href="http://data.ign.fr/def/topo#typAdres">topo:typAdres</a>
    /// </summary>
    let typAdres = _prefixId.prefix "typAdres"
    /// <summary>
    ///   <para>rdfs:comment : Relie une instance de bÃ¢timent Ã  une instance de skos:Concept dÃ©finie dans la liste 'bati' qui prÃ©cise sa nature.</para>
    ///   <para>rdfs:label : type of building rdfs:label : type de bÃ¢timent</para>
    ///   <a href="http://data.ign.fr/def/topo#typeDeBatiment">topo:typeDeBatiment</a>
    /// </summary>
    let typeDeBatiment = _prefixId.prefix "typeDeBatiment"
    /// <summary>
    ///   <para>rdfs:comment : Relie une instance de construction Ã  une instance de skos:Concept dÃ©finie dans la liste 'cnstr' qui prÃ©cise sa nature.</para>
    ///   <para>rdfs:label : type of structurerdfs:label : type de construction</para>
    ///   <a href="http://data.ign.fr/def/topo#typeDeConstruction">topo:typeDeConstruction</a>
    /// </summary>
    let typeDeConstruction = _prefixId.prefix "typeDeConstruction"
    /// <summary>
    ///   <para>rdfs:label : type of crossingrdfs:label : type de franchissement</para>
    ///   <para>rdfs:comment : Relie les Ã©lÃ©ments de rÃ©seaux de transport au type d'ouvrage de franchissement auquel ils correspondent.</para>
    ///   <a href="http://data.ign.fr/def/topo#typeDeFranchissement">topo:typeDeFranchissement</a>
    /// </summary>
    let typeDeFranchissement = _prefixId.prefix "typeDeFranchissement"
    /// <summary>
    ///   <para>rdfs:comment : Relie une instance de laisse Ã  une instance de skos:Concept dÃ©finie dans la liste 'tdl' qui prÃ©cise sa nature.</para>
    ///   <para>rdfs:label : type of tide linerdfs:label : type de laisse</para>
    ///   <a href="http://data.ign.fr/def/topo#typeDeLaisse">topo:typeDeLaisse</a>
    /// </summary>
    let typeDeLaisse = _prefixId.prefix "typeDeLaisse"
    /// <summary>
    ///   <para>rdfs:label : type of taxiwayrdfs:label : type de piste</para>
    ///   <para>rdfs:comment : Attribut permettant de distinguer diffÃ©rentes natures d'aÃ©rodrome.</para>
    ///   <a href="http://data.ign.fr/def/topo#typeDePiste">topo:typeDePiste</a>
    /// </summary>
    let typeDePiste = _prefixId.prefix "typeDePiste"
    /// <summary>
    ///   <para>rdfs:comment : Relie une instance de point d'eau Ã  une instance de skos:Concept dÃ©finie dans la liste 'pte' qui prÃ©cise sa nature.</para>
    ///   <para>rdfs:label : type of waterholerdfs:label : type de point d'eau</para>
    ///   <a href="http://data.ign.fr/def/topo#typeDePointDEau">topo:typeDePointDEau</a>
    /// </summary>
    let typeDePointDEau = _prefixId.prefix "typeDePointDEau"
    /// <summary>
    ///   <para>rdfs:comment : Relie une instance d'Ã©lÃ©ment du relief Ã  une instance de skos:Concept dÃ©finie dans la liste 'rel' qui prÃ©cise sa nature.</para>
    ///   <para>rdfs:label : type of relief featurerdfs:label : type d'Ã©lÃ©ment du relief</para>
    ///   <a href="http://data.ign.fr/def/topo#typeDeRelief">topo:typeDeRelief</a>
    /// </summary>
    let typeDeRelief = _prefixId.prefix "typeDeRelief"
    /// <summary>
    ///   <para>rdfs:comment : Relie une instance de rÃ©servoir Ã  une instance de skos:Concept dÃ©finie dans la liste 'rsv' qui prÃ©cise sa nature.</para>
    ///   <para>rdfs:label : type of tankrdfs:label : type de rÃ©servoir</para>
    ///   <a href="http://data.ign.fr/def/topo#typeDeReservoir">topo:typeDeReservoir</a>
    /// </summary>
    let typeDeReservoir = _prefixId.prefix "typeDeReservoir"
    /// <summary>
    ///   <para>rdfs:comment : Relie une instance de route Ã  une instance de skos:Concept dÃ©finie dans la liste 'rte' qui prÃ©cise sa nature.</para>
    ///   <para>rdfs:label : type of roadrdfs:label : type de route</para>
    ///   <a href="http://data.ign.fr/def/topo#typeDeRoute">topo:typeDeRoute</a>
    /// </summary>
    let typeDeRoute = _prefixId.prefix "typeDeRoute"
    /// <summary>
    ///   <para>rdfs:comment : Relie une instance de terrain de sport Ã  une instance de skos:Concept dÃ©finie dans la liste 'tds' qui prÃ©cise sa nature.</para>
    ///   <para>rdfs:label : type of sports groundrdfs:label : type de terrain de sport</para>
    ///   <a href="http://data.ign.fr/def/topo#typeDeTerrainDeSport">topo:typeDeTerrainDeSport</a>
    /// </summary>
    let typeDeTerrainDeSport = _prefixId.prefix "typeDeTerrainDeSport"
    /// <summary>
    ///   <para>rdfs:comment : Relie une instance d'infrastructure de transport par cÃ¢ble Ã  une instance de skos:Concept dÃ©finie dans la liste 'tpc' qui prÃ©cise sa nature.</para>
    ///   <para>rdfs:label : type of cableway transport linerdfs:label : type de ligne de transport par cÃ¢ble</para>
    ///   <a href="http://data.ign.fr/def/topo#typeDeTransportCable">topo:typeDeTransportCable</a>
    /// </summary>
    let typeDeTransportCable = _prefixId.prefix "typeDeTransportCable"
    /// <summary>
    ///   <para>rdfs:comment : Relie une instance de zone de vÃ©gÃ©tation Ã  une instance de skos:Concept dÃ©finie dans la liste 'veg' qui prÃ©cise sa nature.</para>
    ///   <para>rdfs:label : type of vegetation rdfs:label : type de vÃ©gÃ©tation</para>
    ///   <a href="http://data.ign.fr/def/topo#typeDeVegetation">topo:typeDeVegetation</a>
    /// </summary>
    let typeDeVegetation = _prefixId.prefix "typeDeVegetation"
    /// <summary>
    ///   <para>rdfs:comment : Relie une instance de voie ferrÃ©e Ã  une instance de skos:Concept dÃ©finie dans la liste 'vfr' qui prÃ©cise sa nature.</para>
    ///   <para>rdfs:label : type of railway trackrdfs:label : type de voie ferrÃ©e</para>
    ///   <a href="http://data.ign.fr/def/topo#typeDeVoieFerree">topo:typeDeVoieFerree</a>
    /// </summary>
    let typeDeVoieFerree = _prefixId.prefix "typeDeVoieFerree"
    /// <summary>
    ///   <para>rdfs:comment : Relie une instance de zone d'activitÃ© et d'intÃ©rÃªt Ã  une instance de skos:Concept dÃ©finie dans la liste 'zai' qui prÃ©cise sa nature.</para>
    ///   <para>rdfs:label : type of Area Of Interest (AOI)rdfs:label : type de ZAI</para>
    ///   <a href="http://data.ign.fr/def/topo#typeDeZAI">topo:typeDeZAI</a>
    /// </summary>
    let typeDeZAI = _prefixId.prefix "typeDeZAI"
    /// <summary>
    ///   <para>rdfs:label : voltagerdfs:label : voltage</para>
    ///   <para>rdfs:comment : Tension de construction de la ligne Ã©lectrique en kV (kilo Volts).</para>
    ///   <a href="http://data.ign.fr/def/topo#voltage">topo:voltage</a>
    /// </summary>
    let voltage = _prefixId.prefix "voltage"
    /// <summary>
    ///   <para>rdfs:label : final zrdfs:label : z final</para>
    ///   <para>rdfs:comment : Altitude du sommet final d'une portion d'Ã©lÃ©ment linÃ©aire d'un rÃ©seau.</para>
    ///   <a href="http://data.ign.fr/def/topo#zFin">topo:zFin</a>
    /// </summary>
    let zFin = _prefixId.prefix "zFin"
    /// <summary>
    ///   <para>rdfs:label : initial zrdfs:label : z initial</para>
    ///   <para>rdfs:comment : Altitude du sommet initial d'une portion d'Ã©lÃ©ment linÃ©aire d'un rÃ©seau.</para>
    ///   <a href="http://data.ign.fr/def/topo#zIni">topo:zIni</a>
    /// </summary>
    let zIni = _prefixId.prefix "zIni"
    /// <summary>
    ///   <para>rdfs:label : max zrdfs:label : z max</para>
    ///   <para>rdfs:comment : Altitude maximale dâ€™un objet linÃ©aire ou surfacique. Cette information est issue de la saisie photogrammÃ©trique et concerne des objets dont les points initiaux et finaux ne sont pas caractÃ©ristiques de lâ€™altitude de lâ€™objet (objets surfaciques, objets linÃ©aires isolÃ©s). Pour des objets surfaciques comme les bÃ¢timents ou les rÃ©servoirs, il sâ€™agit de lâ€™altitude maximum du pourtour tel quâ€™il est dÃ©fini en planimÃ©trie (gÃ©nÃ©ralement lâ€™altitude aux gouttiÃ¨res) et non de lâ€™altitude maximum absolue (voir schÃ©ma ci-dessus). Dans le cas dâ€™un bÃ¢timent obtenu aprÃ¨s intÃ©gration du bÃ¢ti issu du cadastre, Z_MAX correspond Ã  une altitude toit mÃ©diane calculÃ©e, en prenant en compte les altitudes des contours des bÃ¢timents directement contigus sâ€™ils existent. Dans ce cas Z_MAX et Z_MIN prennent la mÃªme valeur. Lâ€™attribut peut prendre une valeur conventionnelle (9999) lorsque la gÃ©omÃ©trie de lâ€™objet nâ€™est pas issue dâ€™une saisie photogrammÃ©trique (ex. objets numÃ©risÃ©s sur la carte en service). </para>
    ///   <a href="http://data.ign.fr/def/topo#zMax">topo:zMax</a>
    /// </summary>
    let zMax = _prefixId.prefix "zMax"
    /// <summary>
    ///   <para>rdfs:label : min zrdfs:label : z min</para>
    ///   <para>rdfs:comment : Altitude minimale dâ€™un objet linÃ©aire ou surfacique. Cette information est issue de la saisie photogrammÃ©trique et concerne des objets dont les points initiaux et finaux ne sont pas caractÃ©ristiques de lâ€™altitude de lâ€™objet (objets surfaciques, objets linÃ©aires isolÃ©s). Pour des objets surfaciques comme les bÃ¢timents ou les rÃ©servoirs, il sâ€™agit de lâ€™altitude minimum du pourtour tel quâ€™il est dÃ©fini en planimÃ©trie (gÃ©nÃ©ralement lâ€™altitude aux gouttiÃ¨res) et non de lâ€™altitude minimum absolue. Dans le cas dâ€™un bÃ¢timent obtenu aprÃ¨s intÃ©gration du bÃ¢ti issu du cadastre, Z_MIN correspond Ã  une altitude toit mÃ©diane calculÃ©e, en prenant en compte les altitudes des contours des bÃ¢timents directement contigus sâ€™ils existent. Dans ce cas Z_MAX et Z_MIN prennent la mÃªme valeur. Lâ€™attribut peut prendre une valeur conventionnelle (9999) lorsque la gÃ©omÃ©trie de lâ€™objet nâ€™est pas issue dâ€™une saisie photogrammÃ©trique (ex. objets numÃ©risÃ©s sur la carte en service).</para>
    ///   <a href="http://data.ign.fr/def/topo#zMin">topo:zMin</a>
    /// </summary>
    let zMin = _prefixId.prefix "zMin"
    /// <summary>
    ///   <para>rdfs:label : average zrdfs:label : z moyen</para>
    ///   <para>rdfs:comment : Altitude moyenne des points composants la gÃ©omÃ©trie de lâ€™objet telle quâ€™il a Ã©tÃ© saisi Ã  lâ€™origine lorsquâ€™il est issu dâ€™une saisie photogrammÃ©trique. Lâ€™attribut peut prendre une valeur conventionnelle (9999) lorsque la gÃ©omÃ©trie de lâ€™objet nâ€™est pas issue dâ€™une saisie photogrammÃ©trique (ex. objets numÃ©risÃ©s sur la carte en service). </para>
    ///   <a href="http://data.ign.fr/def/topo#zMoyen">topo:zMoyen</a>
    /// </summary>
    let zMoyen = _prefixId.prefix "zMoyen"
