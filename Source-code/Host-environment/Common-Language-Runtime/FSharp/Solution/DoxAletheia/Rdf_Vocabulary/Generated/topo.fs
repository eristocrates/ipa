namespace http.data.ign.fr.def.topo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module topo =
    let _namespace_iri = Namespace_Iri topo |> NamespaceIRI
    /// <summary>
    ///   <para>topo:</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://data.ign.fr/def/topo#">http://data.ign.fr/def/topo#</seealso>
    let _prefix_iri = Prefixed_Name(topo, "") |> PrefixedName
    /// <summary>
    ///   <para>topo:AireDePeage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Emprise de la chaussÃ©e d'une aire de pÃ©age."</para>
    /// labels<para>"Toll-gate area"</para><para>"Aire de pÃ©age"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#AireDePeage">http://data.ign.fr/def/topo#AireDePeage</seealso>
    let AireDePeage = Prefixed_Name(topo, "AireDePeage") |> PrefixedName
    /// <summary>
    ///   <para>topo:AireDeTriage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Surface qui englobe lâ€™ensemble des tronÃ§ons de voies, voies de garage, aiguillages permettant le tri des wagons et la composition des trains. Aire de triage, faisceau de voies."</para>
    /// labels<para>"Aire de triage"</para><para>"Marshalling yard"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#AireDeTriage">http://data.ign.fr/def/topo#AireDeTriage</seealso>
    let AireDeTriage = Prefixed_Name(topo, "AireDeTriage") |> PrefixedName
    /// <summary>
    ///   <para>topo:Bassin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Construction non couverte destinÃ©e Ã  recevoir de l'eau temporairement ou de maniÃ¨re permanente."</para>
    /// labels<para>"Basin"</para><para>"Bassin"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#Bassin">http://data.ign.fr/def/topo#Bassin</seealso>
    let Bassin = Prefixed_Name(topo, "Bassin") |> PrefixedName
    /// <summary>
    ///   <para>topo:Bati</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"BÃ¢timents (indiffÃ©renciÃ©s, industriels et remarquables) et autres constructions."</para>
    /// labels<para>"Buildings and structures"</para><para>"BÃ¢ti"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#Bati">http://data.ign.fr/def/topo#Bati</seealso>
    let Bati = Prefixed_Name(topo, "Bati") |> PrefixedName
    /// <summary>
    ///   <para>topo:Batiment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Construction d'une certaine importance destinÃ©e Ã  abriter des personnes, des choses ou des animaux."</para>
    /// labels<para>"BÃ¢timent"</para><para>"Building"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#Batiment">http://data.ign.fr/def/topo#Batiment</seealso>
    let Batiment = Prefixed_Name(topo, "Batiment") |> PrefixedName
    /// <summary>
    ///   <para>topo:BornePostale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Borne postale situÃ©e Ã  l'extrÃ©mitÃ© d'un tronÃ§on de route."</para>
    /// labels<para>"Civic number marker"</para><para>"Borne postale"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#BornePostale">http://data.ign.fr/def/topo#BornePostale</seealso>
    let BornePostale = Prefixed_Name(topo, "BornePostale") |> PrefixedName
    /// <summary>
    ///   <para>topo:CanalisationDEau</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Canalisation d'eau aÃ©rienne."</para>
    /// labels<para>"Water pipe"</para><para>"Canalisation d'eau"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#CanalisationDEau">http://data.ign.fr/def/topo#CanalisationDEau</seealso>
    let CanalisationDEau = Prefixed_Name(topo, "CanalisationDEau") |> PrefixedName
    /// <summary>
    ///   <para>topo:Cimetiere</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Lieu oÃ¹ lâ€™on enterre les morts."</para>
    /// labels<para>"CimetiÃ¨re"</para><para>"Cemetery"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#Cimetiere">http://data.ign.fr/def/topo#Cimetiere</seealso>
    let Cimetiere = Prefixed_Name(topo, "Cimetiere") |> PrefixedName
    /// <summary>
    ///   <para>topo:Conduite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Conduite (autre que canalisation dâ€™eau) ou tapis roulant utilisÃ©s pour le transport de matiÃ¨re premiÃ¨re (gaz, hydrocarbure, minerai, etc.) ou canalisation de nature inconnue."</para>
    /// labels<para>"Conduite"</para><para>"Pipeline"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#Conduite">http://data.ign.fr/def/topo#Conduite</seealso>
    let Conduite = Prefixed_Name(topo, "Conduite") |> PrefixedName
    /// <summary>
    ///   <para>topo:Construction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Ouvrage de gÃ©nie civil."</para>
    /// labels<para>"Construction"</para><para>"Structure"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#Construction">http://data.ign.fr/def/topo#Construction</seealso>
    let Construction = Prefixed_Name(topo, "Construction") |> PrefixedName
    /// <summary>
    ///   <para>topo:CoursDEau</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Portion de cours d'eau, rÃ©el ou fictif, permanent ou temporaire, naturel ou artificiel, homogÃ¨ne pour l'ensemble des attributs qui la concernent, et qui n'inclut pas de confluent."</para>
    /// labels<para>"Watercourse"</para><para>"Cours d'eau"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#CoursDEau">http://data.ign.fr/def/topo#CoursDEau</seealso>
    let CoursDEau = Prefixed_Name(topo, "CoursDEau") |> PrefixedName
    /// <summary>
    ///   <para>topo:ElementDuRelief</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EntitÃ© topographique correspondant Ã  une rupture de pente artificielle, ou Ã  un Ã©lÃ©ment remarquable du relief nommÃ©."</para>
    /// labels<para>"Ã‰lÃ©ment du relief"</para><para>"Relief feature"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#ElementDuRelief">http://data.ign.fr/def/topo#ElementDuRelief</seealso>
    let ElementDuRelief = Prefixed_Name(topo, "ElementDuRelief") |> PrefixedName

    /// <summary>
    ///   <para>topo:ElementReseauFerroviaire</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Ã‰lÃ©ments du rÃ©seau de transport ferroviaire: voies ferrÃ©es et aires de triage."</para>
    /// labels<para>"Transport by rail feature"</para><para>"Ã‰lÃ©ment du rÃ©seau ferroviaire"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#ElementReseauFerroviaire">http://data.ign.fr/def/topo#ElementReseauFerroviaire</seealso>
    let ElementReseauFerroviaire =
        Prefixed_Name(topo, "ElementReseauFerroviaire") |> PrefixedName

    /// <summary>
    ///   <para>topo:ElementReseauRoutier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Ã‰lÃ©ments du rÃ©seau de transport routier: voies de communication revÃªtues et non revÃªtues, rÃ©seau 'adressÃ©', et une sÃ©lection des chemins et sentiers."</para>
    /// labels<para>"Ã‰lÃ©ment du rÃ©seau routier"</para><para>"Road transport feature"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#ElementReseauRoutier">http://data.ign.fr/def/topo#ElementReseauRoutier</seealso>
    let ElementReseauRoutier =
        Prefixed_Name(topo, "ElementReseauRoutier") |> PrefixedName

    /// <summary>
    ///   <para>topo:EntiteHydrographiqueTerrestre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EntitÃ© topographique relative au rÃ©seau hydrographique terrestre, Ã  la production ou au stockage d'eau."</para>
    /// labels<para>"EntitÃ© hydrographique terrestre"</para><para>"Inland hydrographic feature"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#EntiteHydrographiqueTerrestre">http://data.ign.fr/def/topo#EntiteHydrographiqueTerrestre</seealso>
    let EntiteHydrographiqueTerrestre =
        Prefixed_Name(topo, "EntiteHydrographiqueTerrestre") |> PrefixedName

    /// <summary>
    ///   <para>topo:EntiteTopographique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Un phÃ©nomÃ¨ne du monde rÃ©el qui est associÃ© Ã  une localisation sur la terre"</para>
    /// labels<para>"Topographic entity"</para><para>"Entité topographique"</para><para>"EntitÃ© topographique"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#EntiteTopographique">http://data.ign.fr/def/topo#EntiteTopographique</seealso>
    let EntiteTopographique = Prefixed_Name(topo, "EntiteTopographique") |> PrefixedName

    /// <summary>
    ///   <para>topo:InfrastructureTransportEnergie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Ã‰lÃ©ments du rÃ©seau de transport d'Ã©lectricitÃ© Ã  une haute et trÃ¨s haute tension, et conduites utilisÃ©es pour le transport de matiÃ¨re premiÃ¨re."</para>
    /// labels<para>"Infrastructure de transport d'Ã©nergie"</para><para>"Energy transport infrastructure"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#InfrastructureTransportEnergie">http://data.ign.fr/def/topo#InfrastructureTransportEnergie</seealso>
    let InfrastructureTransportEnergie =
        Prefixed_Name(topo, "InfrastructureTransportEnergie") |> PrefixedName

    /// <summary>
    ///   <para>topo:Laisse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Limite supÃ©rieure ou infÃ©rieure de l'estran."</para>
    /// labels<para>"Tide line"</para><para>"Laisse"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#Laisse">http://data.ign.fr/def/topo#Laisse</seealso>
    let Laisse = Prefixed_Name(topo, "Laisse") |> PrefixedName
    /// <summary>
    ///   <para>topo:LigneElectrique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Portion de ligne Ã©lectrique homogÃ¨ne pour l'ensemble des attributs qui la concernent."</para>
    /// labels<para>"Ligne Ã©lectrique"</para><para>"Electricity transmission line"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#LigneElectrique">http://data.ign.fr/def/topo#LigneElectrique</seealso>
    let LigneElectrique = Prefixed_Name(topo, "LigneElectrique") |> PrefixedName
    /// <summary>
    ///   <para>topo:LigneTransportCable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Moyen de transport constituÃ© d'un ou de plusieurs cÃ¢bles porteurs."</para>
    /// labels<para>"Cableway transport line"</para><para>"Ligne de transport par cÃ¢ble"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#LigneTransportCable">http://data.ign.fr/def/topo#LigneTransportCable</seealso>
    let LigneTransportCable = Prefixed_Name(topo, "LigneTransportCable") |> PrefixedName
    /// <summary>
    ///   <para>topo:Parking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Zone amÃ©nagÃ©e pour le parcage des automobiles. Parking non couvert, public ou privÃ©, aire de stationnement dâ€™environ un demi hectare et plus."</para>
    /// labels<para>"Car park"</para><para>"Parking"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#Parking">http://data.ign.fr/def/topo#Parking</seealso>
    let Parking = Prefixed_Name(topo, "Parking") |> PrefixedName
    /// <summary>
    ///   <para>topo:PisteAerodrome</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Aire situÃ©e sur un aÃ©rodrome, amÃ©nagÃ©e afin de servir au roulement des aÃ©ronefs, au dÃ©collage et Ã  lâ€™atterrissage, en dur ou en herbe."</para>
    /// labels<para>"Taxiway"</para><para>"Piste d'aÃ©rodrome"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#PisteAerodrome">http://data.ign.fr/def/topo#PisteAerodrome</seealso>
    let PisteAerodrome = Prefixed_Name(topo, "PisteAerodrome") |> PrefixedName
    /// <summary>
    ///   <para>topo:Place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Place ou carrefour revÃªtu de grande largeur."</para>
    /// labels<para>"Square"</para><para>"Place"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#Place">http://data.ign.fr/def/topo#Place</seealso>
    let Place = Prefixed_Name(topo, "Place") |> PrefixedName
    /// <summary>
    ///   <para>topo:PointDEau</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Source (captÃ©e ou non), point de production dâ€™eau (pompage, forage, puits,...) ou point de stockage dâ€™eau de petite dimension (citerne, abreuvoir, lavoir, bassin)."</para>
    /// labels<para>"Point d'eau"</para><para>"Waterhole"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#PointDEau">http://data.ign.fr/def/topo#PointDEau</seealso>
    let PointDEau = Prefixed_Name(topo, "PointDEau") |> PrefixedName
    /// <summary>
    ///   <para>topo:PosteTransformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Enceinte Ã  l'intÃ©rieur de laquelle le courant transportÃ© par une ligne Ã©lectrique est transformÃ©."</para>
    /// labels<para>"Transformation sub-station"</para><para>"Poste de transformation"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#PosteTransformation">http://data.ign.fr/def/topo#PosteTransformation</seealso>
    let PosteTransformation = Prefixed_Name(topo, "PosteTransformation") |> PrefixedName
    /// <summary>
    ///   <para>topo:Pylone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Support de ligne Ã©lectrique. PylÃ´ne, portique."</para>
    /// labels<para>"Pylon"</para><para>"PylÃ´ne"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#Pylone">http://data.ign.fr/def/topo#Pylone</seealso>
    let Pylone = Prefixed_Name(topo, "Pylone") |> PrefixedName
    /// <summary>
    ///   <para>topo:Reservoir</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"RÃ©servoir (eau, matiÃ¨res industrielles,...) de plus de 10m de diamÃ¨tre."</para>
    /// labels<para>"Tank"</para><para>"RÃ©servoir"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#Reservoir">http://data.ign.fr/def/topo#Reservoir</seealso>
    let Reservoir = Prefixed_Name(topo, "Reservoir") |> PrefixedName
    /// <summary>
    ///   <para>topo:Route</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Portion de voie de communication destinÃ©e aux automobiles, aux piÃ©tons, aux cycles ou aux animaux, homogÃ¨ne pour l'ensemble des attributs et des relations qui la concerne. Le tronÃ§on de route peut Ãªtre revÃªtu ou non revÃªtu (pas de revÃªtement de surface ou revÃªtement de surface fortement dÃ©gradÃ©)."</para>
    /// labels<para>"Road"</para><para>"Route"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#Route">http://data.ign.fr/def/topo#Route</seealso>
    let Route = Prefixed_Name(topo, "Route") |> PrefixedName
    /// <summary>
    ///   <para>topo:SurfaceDEau</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Surface d'eau non marine : large canal, Ã©tang, large fleuve, lac, mare, large riviÃ¨re."</para>
    /// labels<para>"Surface d'eau"</para><para>"Water surface"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#SurfaceDEau">http://data.ign.fr/def/topo#SurfaceDEau</seealso>
    let SurfaceDEau = Prefixed_Name(topo, "SurfaceDEau") |> PrefixedName
    /// <summary>
    ///   <para>topo:TerrainDeSport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Ã‰quipement sportif de plein air."</para>
    /// labels<para>"Sports ground"</para><para>"Terrain de sport"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#TerrainDeSport">http://data.ign.fr/def/topo#TerrainDeSport</seealso>
    let TerrainDeSport = Prefixed_Name(topo, "TerrainDeSport") |> PrefixedName
    /// <summary>
    ///   <para>topo:TypeDeBatiment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Regroupe l'ensemble des instances dÃ©signant des types de bÃ¢timents."</para>
    /// labels<para>"Type de bÃ¢timent"</para><para>"Type of building "</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#TypeDeBatiment">http://data.ign.fr/def/topo#TypeDeBatiment</seealso>
    let TypeDeBatiment = Prefixed_Name(topo, "TypeDeBatiment") |> PrefixedName
    /// <summary>
    ///   <para>topo:TypeDeConstruction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Regroupe l'ensemble des instances dÃ©signant des types de constructions."</para>
    /// labels<para>"Type de construction"</para><para>"Type of structure"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#TypeDeConstruction">http://data.ign.fr/def/topo#TypeDeConstruction</seealso>
    let TypeDeConstruction = Prefixed_Name(topo, "TypeDeConstruction") |> PrefixedName

    /// <summary>
    ///   <para>topo:TypeDeFranchissement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Regroupe l'ensemble des instances dÃ©signant des types d'ouvrages de franchissement."</para>
    /// labels<para>"Type of crossing"</para><para>"Type de franchissement"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#TypeDeFranchissement">http://data.ign.fr/def/topo#TypeDeFranchissement</seealso>
    let TypeDeFranchissement =
        Prefixed_Name(topo, "TypeDeFranchissement") |> PrefixedName

    /// <summary>
    ///   <para>topo:TypeDeLaisse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Regroupe l'ensemble des instances dÃ©signant des types de laisses."</para>
    /// labels<para>"Type of tide line"</para><para>"Type de laisse"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#TypeDeLaisse">http://data.ign.fr/def/topo#TypeDeLaisse</seealso>
    let TypeDeLaisse = Prefixed_Name(topo, "TypeDeLaisse") |> PrefixedName
    /// <summary>
    ///   <para>topo:TypeDePointDEau</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Regroupe l'ensemble des instances dÃ©signant des types de points d'eau."</para>
    /// labels<para>"Type of waterhole"</para><para>"Type de point d'eau"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#TypeDePointDEau">http://data.ign.fr/def/topo#TypeDePointDEau</seealso>
    let TypeDePointDEau = Prefixed_Name(topo, "TypeDePointDEau") |> PrefixedName
    /// <summary>
    ///   <para>topo:TypeDeRelief</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Regroupe l'ensemble des instances dÃ©signant des types de reliefs."</para>
    /// labels<para>"Type d'Ã©lÃ©ment du relief"</para><para>"Type of relief feature"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#TypeDeRelief">http://data.ign.fr/def/topo#TypeDeRelief</seealso>
    let TypeDeRelief = Prefixed_Name(topo, "TypeDeRelief") |> PrefixedName
    /// <summary>
    ///   <para>topo:TypeDeReservoir</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Regroupe l'ensemble des instances dÃ©signant des types de rÃ©servoirs."</para>
    /// labels<para>"Type de rÃ©servoir"</para><para>"Type of tank"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#TypeDeReservoir">http://data.ign.fr/def/topo#TypeDeReservoir</seealso>
    let TypeDeReservoir = Prefixed_Name(topo, "TypeDeReservoir") |> PrefixedName
    /// <summary>
    ///   <para>topo:TypeDeRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Regroupe l'ensemble des instances dÃ©signant des types de routes."</para>
    /// labels<para>"Type de route"</para><para>"Type of road"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#TypeDeRoute">http://data.ign.fr/def/topo#TypeDeRoute</seealso>
    let TypeDeRoute = Prefixed_Name(topo, "TypeDeRoute") |> PrefixedName

    /// <summary>
    ///   <para>topo:TypeDeTerrainDeSport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Regroupe l'ensemble des instances dÃ©signant des types de terrains de sports."</para>
    /// labels<para>"Type de terrain de sport"</para><para>"Type of sports ground "</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#TypeDeTerrainDeSport">http://data.ign.fr/def/topo#TypeDeTerrainDeSport</seealso>
    let TypeDeTerrainDeSport =
        Prefixed_Name(topo, "TypeDeTerrainDeSport") |> PrefixedName

    /// <summary>
    ///   <para>topo:TypeDeTransportCable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Regroupe l'ensemble des instances dÃ©signant des types d'infrastructures de transport par cÃ¢ble."</para>
    /// labels<para>"Type of cableway transport line"</para><para>"Type de ligne de transport par cÃ¢ble"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#TypeDeTransportCable">http://data.ign.fr/def/topo#TypeDeTransportCable</seealso>
    let TypeDeTransportCable =
        Prefixed_Name(topo, "TypeDeTransportCable") |> PrefixedName

    /// <summary>
    ///   <para>topo:TypeDeVegetation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Regroupe l'ensemble des instances dÃ©signant des types de vÃ©gÃ©tation arborÃ©e."</para>
    /// labels<para>"Type of vegetation "</para><para>"Type de vÃ©gÃ©tation"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#TypeDeVegetation">http://data.ign.fr/def/topo#TypeDeVegetation</seealso>
    let TypeDeVegetation = Prefixed_Name(topo, "TypeDeVegetation") |> PrefixedName
    /// <summary>
    ///   <para>topo:TypeDeVoieFerree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Regroupe l'ensemble des instances dÃ©signant des types de voies ferrÃ©es."</para>
    /// labels<para>"Type de voie ferrÃ©e"</para><para>"Type of railway track"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#TypeDeVoieFerree">http://data.ign.fr/def/topo#TypeDeVoieFerree</seealso>
    let TypeDeVoieFerree = Prefixed_Name(topo, "TypeDeVoieFerree") |> PrefixedName
    /// <summary>
    ///   <para>topo:TypeDeZAI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Regroupe l'ensemble des instances dÃ©signant des types de zones d'activitÃ©s et d'intÃ©rÃªt."</para>
    /// labels<para>"Type de ZAI"</para><para>"Type of Area Of Interest (AOI)"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#TypeDeZAI">http://data.ign.fr/def/topo#TypeDeZAI</seealso>
    let TypeDeZAI = Prefixed_Name(topo, "TypeDeZAI") |> PrefixedName
    /// <summary>
    ///   <para>topo:Voie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Une voie est un ensemble de tronÃ§ons de route associÃ©s Ã  un mÃªme nom. Une voie est identifiÃ©e par son nom dans une commune donnÃ©e. Le nom de voie est celui qui sert Ã  lâ€™adressage."</para>
    /// labels<para>"Named street"</para><para>"Voie nommÃ©e"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#Voie">http://data.ign.fr/def/topo#Voie</seealso>
    let Voie = Prefixed_Name(topo, "Voie") |> PrefixedName
    /// <summary>
    ///   <para>topo:VoieFerree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Portion de voie ferrÃ©e homogÃ¨ne pour l'ensemble des attributs qui la concernent. Dans le cas dâ€™une ligne composÃ©e de deux Ã  quatre voies parallÃ¨les, lâ€™ensemble des voies est modÃ©lisÃ© par un seul objet."</para>
    /// labels<para>"Voie ferrÃ©e"</para><para>"Railway track"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#VoieFerree">http://data.ign.fr/def/topo#VoieFerree</seealso>
    let VoieFerree = Prefixed_Name(topo, "VoieFerree") |> PrefixedName
    /// <summary>
    ///   <para>topo:ZoneActiviteInteret</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"BÃ¢timent ou site ayant une vocation ou un caractÃ¨re particuliers (administratif, religieux, sportif, industriel, etc.)."</para>
    /// labels<para>"Working area or area of interest"</para><para>"Zone d'activitÃ© ou d'intÃ©rÃªt"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#ZoneActiviteInteret">http://data.ign.fr/def/topo#ZoneActiviteInteret</seealso>
    let ZoneActiviteInteret = Prefixed_Name(topo, "ZoneActiviteInteret") |> PrefixedName
    /// <summary>
    ///   <para>topo:ZoneDeVegetation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Espace vÃ©gÃ©tal naturel ou non diffÃ©renciÃ© selon le couvert forestier."</para>
    /// labels<para>"Vegetation area"</para><para>"Zone de vÃ©gÃ©tation"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#ZoneDeVegetation">http://data.ign.fr/def/topo#ZoneDeVegetation</seealso>
    let ZoneDeVegetation = Prefixed_Name(topo, "ZoneDeVegetation") |> PrefixedName
    /// <summary>
    ///   <para>topo:artif</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Permet de distinguer les cours d'eau naturels des cours d'eau artificiels ou artificialisÃ©s."</para>
    /// labels<para>"artificial"</para><para>"artificiel"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#artif">http://data.ign.fr/def/topo#artif</seealso>
    let artif = Prefixed_Name(topo, "artif") |> PrefixedName
    /// <summary>
    ///   <para>topo:borneFin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation entre un tronÃ§on de route et la borne postale correspondant Ã  son point final."</para>
    /// labels<para>"borne finale"</para><para>"final civic number marker"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#borneFin">http://data.ign.fr/def/topo#borneFin</seealso>
    let borneFin = Prefixed_Name(topo, "borneFin") |> PrefixedName
    /// <summary>
    ///   <para>topo:borneIni</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation entre un tronÃ§on de route et la borne postale correspondant Ã  son point initial."</para>
    /// labels<para>"initial civic number marker"</para><para>"borne initiale"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#borneIni">http://data.ign.fr/def/topo#borneIni</seealso>
    let borneIni = Prefixed_Name(topo, "borneIni") |> PrefixedName
    /// <summary>
    ///   <para>topo:clAdmin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Classement administratif. Statut dâ€™une route numÃ©rotÃ©e ou nommÃ©e."</para>
    /// labels<para>"classement administratif"</para><para>"administrative status"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#clAdmin">http://data.ign.fr/def/topo#clAdmin</seealso>
    let clAdmin = Prefixed_Name(topo, "clAdmin") |> PrefixedName
    /// <summary>
    ///   <para>topo:codePostal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"NumÃ©ro de code postal."</para>
    /// labels<para>"postal code"</para><para>"code postal"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#codePostal">http://data.ign.fr/def/topo#codePostal</seealso>
    let codePostal = Prefixed_Name(topo, "codePostal") |> PrefixedName
    /// <summary>
    ///   <para>topo:concerne</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation entre une borne postale et la voie Ã  laquelle elle se rapporte."</para>
    /// labels<para>"related to"</para><para>"concerne"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#concerne">http://data.ign.fr/def/topo#concerne</seealso>
    let concerne = Prefixed_Name(topo, "concerne") |> PrefixedName
    /// <summary>
    ///   <para>topo:electrifie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"DÃ©signe le type d'Ã©nergie servant Ã  la propulsion des locomotives. Prends la valeur 'vrai' s'il s'agit d'une ligne Ã©lectrifiÃ©e."</para>
    /// labels<para>"Ã©lectrifiÃ©"</para><para>"electrified"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#electrifie">http://data.ign.fr/def/topo#electrifie</seealso>
    let electrifie = Prefixed_Name(topo, "electrifie") |> PrefixedName
    /// <summary>
    ///   <para>topo:enConstruction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indique l'Ã©tat d'une entitÃ© topographique artificielle. Renvoie 'vrai' si cette entitÃ© est en cours de construction."</para>
    /// labels<para>"en construction"</para><para>"under construction"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#enConstruction">http://data.ign.fr/def/topo#enConstruction</seealso>
    let enConstruction = Prefixed_Name(topo, "enConstruction") |> PrefixedName
    /// <summary>
    ///   <para>topo:fictif</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"La valeur 'oui' indique que la gÃ©omÃ©trie du tronÃ§on de rÃ©seau n'est pas significative."</para>
    /// labels<para>"dummy"</para><para>"fictif"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#fictif">http://data.ign.fr/def/topo#fictif</seealso>
    let fictif = Prefixed_Name(topo, "fictif") |> PrefixedName
    /// <summary>
    ///   <para>topo:gestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"DÃ©finit le gestionnaire administratif dâ€™une route. Toutes les routes classÃ©es possÃ¨dent un â€˜Gestionnaireâ€™."</para>
    /// labels<para>"manager"</para><para>"gestionnaire"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#gestion">http://data.ign.fr/def/topo#gestion</seealso>
    let gestion = Prefixed_Name(topo, "gestion") |> PrefixedName
    /// <summary>
    ///   <para>topo:gestionVoie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation entre une voie nommÃ©e et la commune dont elle dÃ©pend."</para>
    /// labels<para>"manager of the nammed street"</para><para>"commune gestionnaire de la voie nommÃ©e"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#gestionVoie">http://data.ign.fr/def/topo#gestionVoie</seealso>
    let gestionVoie = Prefixed_Name(topo, "gestionVoie") |> PrefixedName
    /// <summary>
    ///   <para>topo:hauteur</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Hauteur du bÃ¢timent correspondant Ã  la diffÃ©rence entre le Z le plus Ã©levÃ© du pourtour du bÃ¢timent et un point situÃ© au pied du bÃ¢timent."</para>
    /// labels<para>"height"</para><para>"hauteur"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#hauteur">http://data.ign.fr/def/topo#hauteur</seealso>
    let hauteur = Prefixed_Name(topo, "hauteur") |> PrefixedName
    /// <summary>
    ///   <para>topo:importance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DataRange</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Importance du toponyme dans son environnement. Le toponyme de valeur 1 est plus important que le toponyme de valeur 2, lui-mÃªme plus important que le toponyme de valeur 3, etc."</para>
    /// labels<para>"importance"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#importance">http://data.ign.fr/def/topo#importance</seealso>
    let importance = Prefixed_Name(topo, "importance") |> PrefixedName
    /// <summary>
    ///   <para>topo:itEurop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"NumÃ©ro de route europÃ©enne : une route europÃ©enne emprunte en gÃ©nÃ©ral le rÃ©seau autoroutier ou national (exceptionnellement dÃ©partemental ou non classÃ©)."</para>
    /// labels<para>"european itinerary"</para><para>"itinÃ©raire europÃ©en"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#itEurop">http://data.ign.fr/def/topo#itEurop</seealso>
    let itEurop = Prefixed_Name(topo, "itEurop") |> PrefixedName
    /// <summary>
    ///   <para>topo:itVert</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indique lâ€™appartenance ou non dâ€™un tronÃ§on routier au rÃ©seau vert. Le rÃ©seau vert, composÃ© de pÃ´les verts et de liaisons vertes, couvre lâ€™ensemble du territoire franÃ§ais. Les pÃ´les verts sont composÃ©s de communes de plus de 23.000 habitants en province et de 39.000 habitants en Ile-de-France, ainsi que certains pÃ´les dâ€™activitÃ©s administratifs, Ã©conomiques, touristiques ou industriels. On retient seulement le rÃ©seau vert de transit entre pÃ´les verts. Le rÃ©seau vert de rabattement, Ã  lâ€™intÃ©rieur des villes, et le rÃ©seau vert conseillÃ© aux poids lourds ne sont pas retenus."</para>
    /// labels<para>"itinÃ©raire vert"</para><para>"green itinerary"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#itVert">http://data.ign.fr/def/topo#itVert</seealso>
    let itVert = Prefixed_Name(topo, "itVert") |> PrefixedName
    /// <summary>
    ///   <para>topo:largeurChaussee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Largeur de chaussÃ©e (dâ€™accotement Ã  accotement) exprimÃ©e en mÃ¨tres."</para>
    /// labels<para>"carriageway width"</para><para>"largeur de chaussÃ©e"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#largeurChaussee">http://data.ign.fr/def/topo#largeurChaussee</seealso>
    let largeurChaussee = Prefixed_Name(topo, "largeurChaussee") |> PrefixedName
    /// <summary>
    ///   <para>topo:largeurVF</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DataRange</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Attribut permettant de distinguer les voies ferrÃ©es de largeur standard (normale) pour la France (1,435 m), des voies ferrÃ©es plus larges ou plus Ã©troites."</para>
    /// labels<para>"largeur de la voie ferrÃ©e"</para><para>"railway track width"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#largeurVF">http://data.ign.fr/def/topo#largeurVF</seealso>
    let largeurVF = Prefixed_Name(topo, "largeurVF") |> PrefixedName
    /// <summary>
    ///   <para>topo:militaire</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Attribut permettant de distinguer une entitÃ© topographique Ã  vocation militaire ou simplement gÃ©rÃ©e par le ministÃ¨re de la dÃ©fense d'une entitÃ© civile. La valeur Â« vrai Â» est Ã©galement affectÃ©e aux cimetiÃ¨res militaires gÃ©rÃ©s par le MinistÃ¨re des Anciens Combattants ou par des Ã©tats Ã©trangers."</para>
    /// labels<para>"entitÃ© Ã  vocation militaire"</para><para>"military feature"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#militaire">http://data.ign.fr/def/topo#militaire</seealso>
    let militaire = Prefixed_Name(topo, "militaire") |> PrefixedName
    /// <summary>
    ///   <para>topo:miseEnService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"DÃ©finit la date prÃ©vue ou la date effective de mise en service dâ€™un tronÃ§on de route. Cet attribut n'est rempli que pour les tronÃ§ons en construction, il est Ã  â€œNRâ€œ dans les autres cas. Les tronÃ§ons qui possÃ¨dent une date de mise en service sont complÃ¨tement fermÃ©s aux vÃ©hicules avant cette date."</para>
    /// labels<para>"date de mise en service"</para><para>"in service date"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#miseEnService">http://data.ign.fr/def/topo#miseEnService</seealso>
    let miseEnService = Prefixed_Name(topo, "miseEnService") |> PrefixedName
    /// <summary>
    ///   <para>topo:nature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relie une entitÃ© topographique au concept qui prÃ©cise sa nature."</para>
    /// labels<para>"nature"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#nature">http://data.ign.fr/def/topo#nature</seealso>
    let nature = Prefixed_Name(topo, "nature") |> PrefixedName
    /// <summary>
    ///   <para>topo:nbVoiesCirculation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Nombre total de voies dâ€™une route, dâ€™une rue ou dâ€™une chaussÃ©e de route Ã  chaussÃ©es sÃ©parÃ©es."</para>
    /// labels<para>"number of traffic lanes"</para><para>"nombre de voies de circulation"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#nbVoiesCirculation">http://data.ign.fr/def/topo#nbVoiesCirculation</seealso>
    let nbVoiesCirculation = Prefixed_Name(topo, "nbVoiesCirculation") |> PrefixedName
    /// <summary>
    ///   <para>topo:nbVoiesFerrees</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Nombre de voies constituant cette portion de ligne de chemin de fer. La valeur 0 indique que le nombre de voies est inconnu."</para>
    /// labels<para>"nombre de voies ferrÃ©es"</para><para>"number of tracks"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#nbVoiesFerrees">http://data.ign.fr/def/topo#nbVoiesFerrees</seealso>
    let nbVoiesFerrees = Prefixed_Name(topo, "nbVoiesFerrees") |> PrefixedName
    /// <summary>
    ///   <para>topo:nomIti</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"DÃ©finit un parcours routier nommÃ©."</para>
    /// labels<para>"name of itinerary"</para><para>"nom d'itinÃ©raire"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#nomIti">http://data.ign.fr/def/topo#nomIti</seealso>
    let nomIti = Prefixed_Name(topo, "nomIti") |> PrefixedName
    /// <summary>
    ///   <para>topo:numero</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"DÃ©signe le classement administratif d'un tronÃ§on routier."</para>
    /// labels<para>"number"</para><para>"numÃ©ro"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#numero">http://data.ign.fr/def/topo#numero</seealso>
    let numero = Prefixed_Name(topo, "numero") |> PrefixedName
    /// <summary>
    ///   <para>topo:numeroBorne</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"NumÃ©ro de borne postale."</para>
    /// labels<para>"civic number"</para><para>"numÃ©ro de borne postale"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#numeroBorne">http://data.ign.fr/def/topo#numeroBorne</seealso>
    let numeroBorne = Prefixed_Name(topo, "numeroBorne") |> PrefixedName
    /// <summary>
    ///   <para>topo:origine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Source de l'information."</para>
    /// labels<para>"origine"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#origine">http://data.ign.fr/def/topo#origine</seealso>
    let origine = Prefixed_Name(topo, "origine") |> PrefixedName
    /// <summary>
    ///   <para>topo:posSol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Position par rapport au sol. Donne le niveau de lâ€™objet par rapport Ã  la surface du sol (valeur nulle pour un objet au sol, nÃ©gative pour un objet situÃ© au-dessous du niveau du sol et positive pour un objet en sursol)."</para>
    /// labels<para>"position par rapport au sol"</para><para>"position in relation to the ground"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#posSol">http://data.ign.fr/def/topo#posSol</seealso>
    let posSol = Prefixed_Name(topo, "posSol") |> PrefixedName
    /// <summary>
    ///   <para>topo:precAlti</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"PrÃ©cision gÃ©omÃ©trique altimÃ©trique."</para>
    /// labels<para>"altimetric accuracy"</para><para>"prÃ©cision altimÃ©trique"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#precAlti">http://data.ign.fr/def/topo#precAlti</seealso>
    let precAlti = Prefixed_Name(topo, "precAlti") |> PrefixedName
    /// <summary>
    ///   <para>topo:precPlani</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"PrÃ©cision gÃ©omÃ©trique planimÃ©trique."</para>
    /// labels<para>"prÃ©cision planimÃ©trique"</para><para>"planimetric accuracy"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#precPlani">http://data.ign.fr/def/topo#precPlani</seealso>
    let precPlani = Prefixed_Name(topo, "precPlani") |> PrefixedName
    /// <summary>
    ///   <para>topo:regime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DataRange</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Attribut permettant de caractÃ©riser un objet hydrographique en fonction du rÃ©gime des eaux."</para>
    /// labels<para>"water regime"</para><para>"rÃ©gime des eaux"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#regime">http://data.ign.fr/def/topo#regime</seealso>
    let regime = Prefixed_Name(topo, "regime") |> PrefixedName
    /// <summary>
    ///   <para>topo:sens</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DataRange</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Sens de circulation autorisÃ©e pour les automobiles sur les voies."</para>
    /// labels<para>"sens de circulation"</para><para>"direction of traffic"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#sens">http://data.ign.fr/def/topo#sens</seealso>
    let sens = Prefixed_Name(topo, "sens") |> PrefixedName
    /// <summary>
    ///   <para>topo:typAdres</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DataRange</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Renseigne sur le type dâ€™adressage du tronÃ§on."</para>
    /// labels<para>"type dâ€™adressage"</para><para>"type of addressing"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#typAdres">http://data.ign.fr/def/topo#typAdres</seealso>
    let typAdres = Prefixed_Name(topo, "typAdres") |> PrefixedName
    /// <summary>
    ///   <para>topo:typeDeBatiment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relie une instance de bÃ¢timent Ã  une instance de skos:Concept dÃ©finie dans la liste 'bati' qui prÃ©cise sa nature."</para>
    /// labels<para>"type de bÃ¢timent"</para><para>"type of building "</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#typeDeBatiment">http://data.ign.fr/def/topo#typeDeBatiment</seealso>
    let typeDeBatiment = Prefixed_Name(topo, "typeDeBatiment") |> PrefixedName
    /// <summary>
    ///   <para>topo:typeDeConstruction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relie une instance de construction Ã  une instance de skos:Concept dÃ©finie dans la liste 'cnstr' qui prÃ©cise sa nature."</para>
    /// labels<para>"type de construction"</para><para>"type of structure"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#typeDeConstruction">http://data.ign.fr/def/topo#typeDeConstruction</seealso>
    let typeDeConstruction = Prefixed_Name(topo, "typeDeConstruction") |> PrefixedName

    /// <summary>
    ///   <para>topo:typeDeFranchissement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relie les Ã©lÃ©ments de rÃ©seaux de transport au type d'ouvrage de franchissement auquel ils correspondent."</para>
    /// labels<para>"type de franchissement"</para><para>"type of crossing"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#typeDeFranchissement">http://data.ign.fr/def/topo#typeDeFranchissement</seealso>
    let typeDeFranchissement =
        Prefixed_Name(topo, "typeDeFranchissement") |> PrefixedName

    /// <summary>
    ///   <para>topo:typeDeLaisse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relie une instance de laisse Ã  une instance de skos:Concept dÃ©finie dans la liste 'tdl' qui prÃ©cise sa nature."</para>
    /// labels<para>"type of tide line"</para><para>"type de laisse"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#typeDeLaisse">http://data.ign.fr/def/topo#typeDeLaisse</seealso>
    let typeDeLaisse = Prefixed_Name(topo, "typeDeLaisse") |> PrefixedName
    /// <summary>
    ///   <para>topo:typeDePiste</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DataRange</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Attribut permettant de distinguer diffÃ©rentes natures d'aÃ©rodrome."</para>
    /// labels<para>"type of taxiway"</para><para>"type de piste"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#typeDePiste">http://data.ign.fr/def/topo#typeDePiste</seealso>
    let typeDePiste = Prefixed_Name(topo, "typeDePiste") |> PrefixedName
    /// <summary>
    ///   <para>topo:typeDePointDEau</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relie une instance de point d'eau Ã  une instance de skos:Concept dÃ©finie dans la liste 'pte' qui prÃ©cise sa nature."</para>
    /// labels<para>"type de point d'eau"</para><para>"type of waterhole"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#typeDePointDEau">http://data.ign.fr/def/topo#typeDePointDEau</seealso>
    let typeDePointDEau = Prefixed_Name(topo, "typeDePointDEau") |> PrefixedName
    /// <summary>
    ///   <para>topo:typeDeRelief</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relie une instance d'Ã©lÃ©ment du relief Ã  une instance de skos:Concept dÃ©finie dans la liste 'rel' qui prÃ©cise sa nature."</para>
    /// labels<para>"type d'Ã©lÃ©ment du relief"</para><para>"type of relief feature"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#typeDeRelief">http://data.ign.fr/def/topo#typeDeRelief</seealso>
    let typeDeRelief = Prefixed_Name(topo, "typeDeRelief") |> PrefixedName
    /// <summary>
    ///   <para>topo:typeDeReservoir</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relie une instance de rÃ©servoir Ã  une instance de skos:Concept dÃ©finie dans la liste 'rsv' qui prÃ©cise sa nature."</para>
    /// labels<para>"type of tank"</para><para>"type de rÃ©servoir"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#typeDeReservoir">http://data.ign.fr/def/topo#typeDeReservoir</seealso>
    let typeDeReservoir = Prefixed_Name(topo, "typeDeReservoir") |> PrefixedName
    /// <summary>
    ///   <para>topo:typeDeRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relie une instance de route Ã  une instance de skos:Concept dÃ©finie dans la liste 'rte' qui prÃ©cise sa nature."</para>
    /// labels<para>"type of road"</para><para>"type de route"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#typeDeRoute">http://data.ign.fr/def/topo#typeDeRoute</seealso>
    let typeDeRoute = Prefixed_Name(topo, "typeDeRoute") |> PrefixedName

    /// <summary>
    ///   <para>topo:typeDeTerrainDeSport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relie une instance de terrain de sport Ã  une instance de skos:Concept dÃ©finie dans la liste 'tds' qui prÃ©cise sa nature."</para>
    /// labels<para>"type de terrain de sport"</para><para>"type of sports ground"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#typeDeTerrainDeSport">http://data.ign.fr/def/topo#typeDeTerrainDeSport</seealso>
    let typeDeTerrainDeSport =
        Prefixed_Name(topo, "typeDeTerrainDeSport") |> PrefixedName

    /// <summary>
    ///   <para>topo:typeDeTransportCable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relie une instance d'infrastructure de transport par cÃ¢ble Ã  une instance de skos:Concept dÃ©finie dans la liste 'tpc' qui prÃ©cise sa nature."</para>
    /// labels<para>"type of cableway transport line"</para><para>"type de ligne de transport par cÃ¢ble"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#typeDeTransportCable">http://data.ign.fr/def/topo#typeDeTransportCable</seealso>
    let typeDeTransportCable =
        Prefixed_Name(topo, "typeDeTransportCable") |> PrefixedName

    /// <summary>
    ///   <para>topo:typeDeVegetation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relie une instance de zone de vÃ©gÃ©tation Ã  une instance de skos:Concept dÃ©finie dans la liste 'veg' qui prÃ©cise sa nature."</para>
    /// labels<para>"type de vÃ©gÃ©tation"</para><para>"type of vegetation "</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#typeDeVegetation">http://data.ign.fr/def/topo#typeDeVegetation</seealso>
    let typeDeVegetation = Prefixed_Name(topo, "typeDeVegetation") |> PrefixedName
    /// <summary>
    ///   <para>topo:typeDeVoieFerree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relie une instance de voie ferrÃ©e Ã  une instance de skos:Concept dÃ©finie dans la liste 'vfr' qui prÃ©cise sa nature."</para>
    /// labels<para>"type of railway track"</para><para>"type de voie ferrÃ©e"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#typeDeVoieFerree">http://data.ign.fr/def/topo#typeDeVoieFerree</seealso>
    let typeDeVoieFerree = Prefixed_Name(topo, "typeDeVoieFerree") |> PrefixedName
    /// <summary>
    ///   <para>topo:typeDeZAI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relie une instance de zone d'activitÃ© et d'intÃ©rÃªt Ã  une instance de skos:Concept dÃ©finie dans la liste 'zai' qui prÃ©cise sa nature."</para>
    /// labels<para>"type of Area Of Interest (AOI)"</para><para>"type de ZAI"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#typeDeZAI">http://data.ign.fr/def/topo#typeDeZAI</seealso>
    let typeDeZAI = Prefixed_Name(topo, "typeDeZAI") |> PrefixedName
    /// <summary>
    ///   <para>topo:voltage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DataRange</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tension de construction de la ligne Ã©lectrique en kV (kilo Volts)."</para>
    /// labels<para>"voltage"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#voltage">http://data.ign.fr/def/topo#voltage</seealso>
    let voltage = Prefixed_Name(topo, "voltage") |> PrefixedName
    /// <summary>
    ///   <para>topo:zFin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Altitude du sommet final d'une portion d'Ã©lÃ©ment linÃ©aire d'un rÃ©seau."</para>
    /// labels<para>"z final"</para><para>"final z"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#zFin">http://data.ign.fr/def/topo#zFin</seealso>
    let zFin = Prefixed_Name(topo, "zFin") |> PrefixedName
    /// <summary>
    ///   <para>topo:zIni</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Altitude du sommet initial d'une portion d'Ã©lÃ©ment linÃ©aire d'un rÃ©seau."</para>
    /// labels<para>"z initial"</para><para>"initial z"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#zIni">http://data.ign.fr/def/topo#zIni</seealso>
    let zIni = Prefixed_Name(topo, "zIni") |> PrefixedName
    /// <summary>
    ///   <para>topo:zMax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Altitude maximale dâ€™un objet linÃ©aire ou surfacique. Cette information est issue de la saisie photogrammÃ©trique et concerne des objets dont les points initiaux et finaux ne sont pas caractÃ©ristiques de lâ€™altitude de lâ€™objet (objets surfaciques, objets linÃ©aires isolÃ©s). Pour des objets surfaciques comme les bÃ¢timents ou les rÃ©servoirs, il sâ€™agit de lâ€™altitude maximum du pourtour tel quâ€™il est dÃ©fini en planimÃ©trie (gÃ©nÃ©ralement lâ€™altitude aux gouttiÃ¨res) et non de lâ€™altitude maximum absolue (voir schÃ©ma ci-dessus). Dans le cas dâ€™un bÃ¢timent obtenu aprÃ¨s intÃ©gration du bÃ¢ti issu du cadastre, Z_MAX correspond Ã  une altitude toit mÃ©diane calculÃ©e, en prenant en compte les altitudes des contours des bÃ¢timents directement contigus sâ€™ils existent. Dans ce cas Z_MAX et Z_MIN prennent la mÃªme valeur. Lâ€™attribut peut prendre une valeur conventionnelle (9999) lorsque la gÃ©omÃ©trie de lâ€™objet nâ€™est pas issue dâ€™une saisie photogrammÃ©trique (ex. objets numÃ©risÃ©s sur la carte en service). "</para>
    /// labels<para>"z max"</para><para>"max z"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#zMax">http://data.ign.fr/def/topo#zMax</seealso>
    let zMax = Prefixed_Name(topo, "zMax") |> PrefixedName
    /// <summary>
    ///   <para>topo:zMin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Altitude minimale dâ€™un objet linÃ©aire ou surfacique. Cette information est issue de la saisie photogrammÃ©trique et concerne des objets dont les points initiaux et finaux ne sont pas caractÃ©ristiques de lâ€™altitude de lâ€™objet (objets surfaciques, objets linÃ©aires isolÃ©s). Pour des objets surfaciques comme les bÃ¢timents ou les rÃ©servoirs, il sâ€™agit de lâ€™altitude minimum du pourtour tel quâ€™il est dÃ©fini en planimÃ©trie (gÃ©nÃ©ralement lâ€™altitude aux gouttiÃ¨res) et non de lâ€™altitude minimum absolue. Dans le cas dâ€™un bÃ¢timent obtenu aprÃ¨s intÃ©gration du bÃ¢ti issu du cadastre, Z_MIN correspond Ã  une altitude toit mÃ©diane calculÃ©e, en prenant en compte les altitudes des contours des bÃ¢timents directement contigus sâ€™ils existent. Dans ce cas Z_MAX et Z_MIN prennent la mÃªme valeur. Lâ€™attribut peut prendre une valeur conventionnelle (9999) lorsque la gÃ©omÃ©trie de lâ€™objet nâ€™est pas issue dâ€™une saisie photogrammÃ©trique (ex. objets numÃ©risÃ©s sur la carte en service)."</para>
    /// labels<para>"z min"</para><para>"min z"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#zMin">http://data.ign.fr/def/topo#zMin</seealso>
    let zMin = Prefixed_Name(topo, "zMin") |> PrefixedName
    /// <summary>
    ///   <para>topo:zMoyen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Altitude moyenne des points composants la gÃ©omÃ©trie de lâ€™objet telle quâ€™il a Ã©tÃ© saisi Ã  lâ€™origine lorsquâ€™il est issu dâ€™une saisie photogrammÃ©trique. Lâ€™attribut peut prendre une valeur conventionnelle (9999) lorsque la gÃ©omÃ©trie de lâ€™objet nâ€™est pas issue dâ€™une saisie photogrammÃ©trique (ex. objets numÃ©risÃ©s sur la carte en service). "</para>
    /// labels<para>"z moyen"</para><para>"average z"</para></remarks>
    /// <seealso href="http://data.ign.fr/def/topo#zMoyen">http://data.ign.fr/def/topo#zMoyen</seealso>
    let zMoyen = Prefixed_Name(topo, "zMoyen") |> PrefixedName
