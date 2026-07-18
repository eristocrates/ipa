namespace https.w3id.org.def.foo.hash

open DoxAletheia.Rdf_Vocabulary

module foo =
    let _namespace_name = "https://w3id.org/def/foo#"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Altitude"></see>
    /// </summary>
    let Altitude = Namespaced_IRI.parse _namespace_name "Altitude" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Latitude"></see>
    /// </summary>
    let Latitude = Namespaced_IRI.parse _namespace_name "Latitude" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Longitude"></see>
    /// </summary>
    let Longitude = Namespaced_IRI.parse _namespace_name "Longitude" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/foo#FeatureOfInterest"></see>
    /// </summary>
    let FeatureOfInterest =
        Namespaced_IRI.parse _namespace_name "FeatureOfInterest" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/foo#ObservableProperty"></see>
    /// </summary>
    let ObservableProperty =
        Namespaced_IRI.parse _namespace_name "ObservableProperty" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Observation"></see>
    /// </summary>
    let Observation =
        Namespaced_IRI.parse _namespace_name "Observation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Sensor"></see>
    /// </summary>
    let Sensor = Namespaced_IRI.parse _namespace_name "Sensor" |> NamespacedName

    /// <summary>
    /// A relation between an Observation and the entity whose quality was observed, or between an Actuation and the entity whose property was modified, or between an act of Sampling and the entity that was sampled.
    /// <see href="https://w3id.org/def/foo#hasFeatureOfInterest"></see></summary>
    let hasFeatureOfInterest =
        Namespaced_IRI.parse _namespace_name "hasFeatureOfInterest" |> NamespacedName

    /// <summary>
    /// Relation between an ObservableProperty and the Sensor able to observe it.
    /// <see href="https://w3id.org/def/foo#isObservedBy"></see></summary>
    let isObservedBy =
        Namespaced_IRI.parse _namespace_name "isObservedBy" |> NamespacedName

    /// <summary>
    /// Relation between an Observation and the Sensor which made the Observation.
    /// <see href="https://w3id.org/def/foo#madeBySensor"></see></summary>
    let madeBySensor =
        Namespaced_IRI.parse _namespace_name "madeBySensor" |> NamespacedName

    /// <summary>
    /// Relation between a Sensor and an Observation made by the Sensor.
    /// <see href="https://w3id.org/def/foo#madeObservation"></see></summary>
    let madeObservation =
        Namespaced_IRI.parse _namespace_name "madeObservation" |> NamespacedName

    /// <summary>
    /// Relation between a Sensor and an ObservableProperty that it is capable of sensing.
    /// <see href="https://w3id.org/def/foo#observes"></see></summary>
    let observes = Namespaced_IRI.parse _namespace_name "observes" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#V2.0"></see>
    /// </summary>
    let ``V2.0`` = Namespaced_IRI.parse _namespace_name "V2.0" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Abaw"></see>
    /// </summary>
    let Abaw = Namespaced_IRI.parse _namespace_name "Abaw" |> NamespacedName

    /// <summary>
    /// Bornean elephants exhibit distinct morphological and behavioural traits compared to mainland Asian elephants, and their genetic uniqueness emphasises their priority for conservation efforts. Although they are considered an evolutionary significant unit requiring tailored conservation measures, their formal recognition as a subspecies awaits further research. Restricted to about 5% of Borneo, primarily in Sabah, Bornean elephants typically form family groups of 5 to 20 individuals, occasionally merging into larger herds of up to 200.
    /// <see href="https://w3id.org/def/foo#ElephasMaximus"></see></summary>
    let ElephasMaximus =
        Namespaced_IRI.parse _namespace_name "ElephasMaximus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/foo#GPSObservation"></see>
    /// </summary>
    let GPSObservation =
        Namespaced_IRI.parse _namespace_name "GPSObservation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Animalia"></see>
    /// </summary>
    let Animalia = Namespaced_IRI.parse _namespace_name "Animalia" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Kingdom"></see>
    /// </summary>
    let Kingdom = Namespaced_IRI.parse _namespace_name "Kingdom" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Aqeela"></see>
    /// </summary>
    let Aqeela = Namespaced_IRI.parse _namespace_name "Aqeela" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Bikang1"></see>
    /// </summary>
    let Bikang1 = Namespaced_IRI.parse _namespace_name "Bikang1" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Bikang2"></see>
    /// </summary>
    let Bikang2 = Namespaced_IRI.parse _namespace_name "Bikang2" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Binbingan"></see>
    /// </summary>
    let Binbingan = Namespaced_IRI.parse _namespace_name "Binbingan" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#CNRatio"></see>
    /// </summary>
    let CNRatio = Namespaced_IRI.parse _namespace_name "CNRatio" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#CameraTrap"></see>
    /// </summary>
    let CameraTrap = Namespaced_IRI.parse _namespace_name "CameraTrap" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Image"></see>
    /// </summary>
    let Image = Namespaced_IRI.parse _namespace_name "Image" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/foo#ImageObservation"></see>
    /// </summary>
    let ImageObservation =
        Namespaced_IRI.parse _namespace_name "ImageObservation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Carnivora"></see>
    /// </summary>
    let Carnivora = Namespaced_IRI.parse _namespace_name "Carnivora" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Order"></see>
    /// </summary>
    let Order = Namespaced_IRI.parse _namespace_name "Order" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Chordata"></see>
    /// </summary>
    let Chordata = Namespaced_IRI.parse _namespace_name "Chordata" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Class"></see>
    /// </summary>
    let Class = Namespaced_IRI.parse _namespace_name "Class" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Clay"></see>
    /// </summary>
    let Clay = Namespaced_IRI.parse _namespace_name "Clay" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Count"></see>
    /// </summary>
    let Count = Namespaced_IRI.parse _namespace_name "Count" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Cov"></see>
    /// </summary>
    let Cov = Namespaced_IRI.parse _namespace_name "Cov" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Dara"></see>
    /// </summary>
    let Dara = Namespaced_IRI.parse _namespace_name "Dara" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Date"></see>
    /// </summary>
    let Date = Namespaced_IRI.parse _namespace_name "Date" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Direction"></see>
    /// </summary>
    let Direction = Namespaced_IRI.parse _namespace_name "Direction" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Distance"></see>
    /// </summary>
    let Distance = Namespaced_IRI.parse _namespace_name "Distance" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Elephantidae"></see>
    /// </summary>
    let Elephantidae =
        Namespaced_IRI.parse _namespace_name "Elephantidae" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Family"></see>
    /// </summary>
    let Family = Namespaced_IRI.parse _namespace_name "Family" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Proboscidea"></see>
    /// </summary>
    let Proboscidea =
        Namespaced_IRI.parse _namespace_name "Proboscidea" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Mammalia"></see>
    /// </summary>
    let Mammalia = Namespaced_IRI.parse _namespace_name "Mammalia" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#GMTDate"></see>
    /// </summary>
    let GMTDate = Namespaced_IRI.parse _namespace_name "GMTDate" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#GMTTime"></see>
    /// </summary>
    let GMTTime = Namespaced_IRI.parse _namespace_name "GMTTime" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#HDOP"></see>
    /// </summary>
    let HDOP = Namespaced_IRI.parse _namespace_name "HDOP" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#ID"></see>
    /// </summary>
    let ID = Namespaced_IRI.parse _namespace_name "ID" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#LocalDate"></see>
    /// </summary>
    let LocalDate = Namespaced_IRI.parse _namespace_name "LocalDate" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#LocalTime"></see>
    /// </summary>
    let LocalTime = Namespaced_IRI.parse _namespace_name "LocalTime" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Speed"></see>
    /// </summary>
    let Speed = Namespaced_IRI.parse _namespace_name "Speed" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Temperature"></see>
    /// </summary>
    let Temperature =
        Namespaced_IRI.parse _namespace_name "Temperature" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Jasper"></see>
    /// </summary>
    let Jasper = Namespaced_IRI.parse _namespace_name "Jasper" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Seri"></see>
    /// </summary>
    let Seri = Namespaced_IRI.parse _namespace_name "Seri" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Liun"></see>
    /// </summary>
    let Liun = Namespaced_IRI.parse _namespace_name "Liun" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Ita"></see>
    /// </summary>
    let Ita = Namespaced_IRI.parse _namespace_name "Ita" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Kuma"></see>
    /// </summary>
    let Kuma = Namespaced_IRI.parse _namespace_name "Kuma" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Tulid"></see>
    /// </summary>
    let Tulid = Namespaced_IRI.parse _namespace_name "Tulid" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Sejati"></see>
    /// </summary>
    let Sejati = Namespaced_IRI.parse _namespace_name "Sejati" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Puteri"></see>
    /// </summary>
    let Puteri = Namespaced_IRI.parse _namespace_name "Puteri" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Maliau"></see>
    /// </summary>
    let Maliau = Namespaced_IRI.parse _namespace_name "Maliau" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Umas2"></see>
    /// </summary>
    let Umas2 = Namespaced_IRI.parse _namespace_name "Umas2" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Merotai"></see>
    /// </summary>
    let Merotai = Namespaced_IRI.parse _namespace_name "Merotai" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Jasmin"></see>
    /// </summary>
    let Jasmin = Namespaced_IRI.parse _namespace_name "Jasmin" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Kasih"></see>
    /// </summary>
    let Kasih = Namespaced_IRI.parse _namespace_name "Kasih" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Tunglap"></see>
    /// </summary>
    let Tunglap = Namespaced_IRI.parse _namespace_name "Tunglap" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Putut"></see>
    /// </summary>
    let Putut = Namespaced_IRI.parse _namespace_name "Putut" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Guli"></see>
    /// </summary>
    let Guli = Namespaced_IRI.parse _namespace_name "Guli" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#resultTime"></see>
    /// </summary>
    let resultTime = Namespaced_IRI.parse _namespace_name "resultTime" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Genus"></see>
    /// </summary>
    let Genus = Namespaced_IRI.parse _namespace_name "Genus" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Horizon"></see>
    /// </summary>
    let Horizon = Namespaced_IRI.parse _namespace_name "Horizon" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Identifier"></see>
    /// </summary>
    let Identifier = Namespaced_IRI.parse _namespace_name "Identifier" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#ImageID"></see>
    /// </summary>
    let ImageID = Namespaced_IRI.parse _namespace_name "ImageID" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Make"></see>
    /// </summary>
    let Make = Namespaced_IRI.parse _namespace_name "Make" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Model"></see>
    /// </summary>
    let Model = Namespaced_IRI.parse _namespace_name "Model" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Time"></see>
    /// </summary>
    let Time = Namespaced_IRI.parse _namespace_name "Time" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#InorganicP"></see>
    /// </summary>
    let InorganicP = Namespaced_IRI.parse _namespace_name "InorganicP" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#LandUse"></see>
    /// </summary>
    let LandUse = Namespaced_IRI.parse _namespace_name "LandUse" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/foo#LianaDBH_cm"></see>
    /// </summary>
    let LianaDBH_cm =
        Namespaced_IRI.parse _namespace_name "LianaDBH_cm" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Lianas"></see>
    /// </summary>
    let Lianas = Namespaced_IRI.parse _namespace_name "Lianas" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#PlotNo"></see>
    /// </summary>
    let PlotNo = Namespaced_IRI.parse _namespace_name "PlotNo" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#SiteName"></see>
    /// </summary>
    let SiteName = Namespaced_IRI.parse _namespace_name "SiteName" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/foo#SitePlotCode"></see>
    /// </summary>
    let SitePlotCode =
        Namespaced_IRI.parse _namespace_name "SitePlotCode" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/foo#TreeObservation"></see>
    /// </summary>
    let TreeObservation =
        Namespaced_IRI.parse _namespace_name "TreeObservation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/foo#MalayopythonReticulatus"></see>
    /// </summary>
    let MalayopythonReticulatus =
        Namespaced_IRI.parse _namespace_name "MalayopythonReticulatus" |> NamespacedName

    /// <summary>
    /// Manis Javanica is a species critically threatened by poaching and habitat loss. It is one of eight pangolin species, all of which are considered Vulnerable, Endangered, or Critically Endangered according to the IUCN Red List and listed in CITES Appendix I. The Sunda pangolin, critically endangered and the only species found in Malaysia, inhabits Peninsular Malaysia and Malaysian Borneo, including Sabah and Sarawak. Despite its high protection status in Sabah, where it is (totally protected) under the Wildlife Conservation Enactment 1997, the species faces severe threats from illegal wildlife trade and habitat degradation. In 2019, authorities in Sabah seized over 30 tonnes of pangolin products, highlighting the extensive illicit trade network. The Sunda pangolin occupies various habitats, from primary and secondary forests to wetlands, mangroves, and grasslands.
    /// <see href="https://w3id.org/def/foo#ManisJavanica"></see></summary>
    let ManisJavanica =
        Namespaced_IRI.parse _namespace_name "ManisJavanica" |> NamespacedName

    /// <summary>
    /// Male proboscis monkeys have notably large noses, which are believed to have evolved due to their sexually competitive social system. Significant correlations exist between nose size, body size, testis size, and the number of females in a male's harem. This suggests that both male competition and female choice have driven the evolution of these enlarged noses.
    /// <see href="https://w3id.org/def/foo#Nasalislarvatus"></see></summary>
    let Nasalislarvatus =
        Namespaced_IRI.parse _namespace_name "Nasalislarvatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Phylum"></see>
    /// </summary>
    let Phylum = Namespaced_IRI.parse _namespace_name "Phylum" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#PlotName"></see>
    /// </summary>
    let PlotName = Namespaced_IRI.parse _namespace_name "PlotName" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Reptilia"></see>
    /// </summary>
    let Reptilia = Namespaced_IRI.parse _namespace_name "Reptilia" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Sand"></see>
    /// </summary>
    let Sand = Namespaced_IRI.parse _namespace_name "Sand" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Silt"></see>
    /// </summary>
    let Silt = Namespaced_IRI.parse _namespace_name "Silt" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Site"></see>
    /// </summary>
    let Site = Namespaced_IRI.parse _namespace_name "Site" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Soil"></see>
    /// </summary>
    let Soil = Namespaced_IRI.parse _namespace_name "Soil" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/foo#SoilObservation"></see>
    /// </summary>
    let SoilObservation =
        Namespaced_IRI.parse _namespace_name "SoilObservation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/foo#SoilPH"></see>
    /// </summary>
    let SoilPH = Namespaced_IRI.parse _namespace_name "SoilPH" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Subplot"></see>
    /// </summary>
    let Subplot = Namespaced_IRI.parse _namespace_name "Subplot" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#TotalC"></see>
    /// </summary>
    let TotalC = Namespaced_IRI.parse _namespace_name "TotalC" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#TotalN"></see>
    /// </summary>
    let TotalN = Namespaced_IRI.parse _namespace_name "TotalN" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#TotalP"></see>
    /// </summary>
    let TotalP = Namespaced_IRI.parse _namespace_name "TotalP" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#SoilSensor"></see>
    /// </summary>
    let SoilSensor = Namespaced_IRI.parse _namespace_name "SoilSensor" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Species"></see>
    /// </summary>
    let Species = Namespaced_IRI.parse _namespace_name "Species" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Squamata"></see>
    /// </summary>
    let Squamata = Namespaced_IRI.parse _namespace_name "Squamata" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/foo#SubplotRadius_m"></see>
    /// </summary>
    let SubplotRadius_m =
        Namespaced_IRI.parse _namespace_name "SubplotRadius_m" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/foo#TaxonRank"></see>
    /// </summary>
    let TaxonRank = Namespaced_IRI.parse _namespace_name "TaxonRank" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#TreeDBH_cm"></see>
    /// </summary>
    let TreeDBH_cm = Namespaced_IRI.parse _namespace_name "TreeDBH_cm" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/foo#TreeHeight_m"></see>
    /// </summary>
    let TreeHeight_m =
        Namespaced_IRI.parse _namespace_name "TreeHeight_m" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/foo#TreeID"></see>
    /// </summary>
    let TreeID = Namespaced_IRI.parse _namespace_name "TreeID" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/foo#TreeIndividualNo"></see>
    /// </summary>
    let TreeIndividualNo =
        Namespaced_IRI.parse _namespace_name "TreeIndividualNo" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/foo#TreeNLianas"></see>
    /// </summary>
    let TreeNLianas =
        Namespaced_IRI.parse _namespace_name "TreeNLianas" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/foo#TreeNotes"></see>
    /// </summary>
    let TreeNotes = Namespaced_IRI.parse _namespace_name "TreeNotes" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Viverridae"></see>
    /// </summary>
    let Viverridae = Namespaced_IRI.parse _namespace_name "Viverridae" |> NamespacedName

    /// <summary>
    /// A relation between a FeatureOfInterest and an Observation about it, an Actuation acting on it, or an act of Sampling that sampled it.
    /// <see href="https://w3id.org/def/foo#isFeatureOfInterestOf"></see></summary>
    let isFeatureOfInterestOf =
        Namespaced_IRI.parse _namespace_name "isFeatureOfInterestOf" |> NamespacedName

    /// <summary>
    /// Relation linking an Observation to the property that was observed. The ObservableProperty should be a property of the FeatureOfInterest (linked by hasFeatureOfInterest) of this Observation.
    /// <see href="https://w3id.org/def/foo#observedProperty"></see></summary>
    let observedProperty =
        Namespaced_IRI.parse _namespace_name "observedProperty" |> NamespacedName
