namespace https.w3id.org.def.foo.hash

open DoxAletheia

module foo =
    let _namespace_name = "https://w3id.org/def/foo#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Altitude"></see>
    /// </summary>
    let Altitude = _prefix "Altitude"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Latitude"></see>
    /// </summary>
    let Latitude = _prefix "Latitude"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Longitude"></see>
    /// </summary>
    let Longitude = _prefix "Longitude"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#FeatureOfInterest"></see>
    /// </summary>
    let FeatureOfInterest = _prefix "FeatureOfInterest"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#ObservableProperty"></see>
    /// </summary>
    let ObservableProperty = _prefix "ObservableProperty"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Observation"></see>
    /// </summary>
    let Observation = _prefix "Observation"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Sensor"></see>
    /// </summary>
    let Sensor = _prefix "Sensor"
    /// <summary>
    /// A relation between an Observation and the entity whose quality was observed, or between an Actuation and the entity whose property was modified, or between an act of Sampling and the entity that was sampled.
    /// <see href="https://w3id.org/def/foo#hasFeatureOfInterest"></see></summary>
    let hasFeatureOfInterest = _prefix "hasFeatureOfInterest"
    /// <summary>
    /// Relation between an ObservableProperty and the Sensor able to observe it.
    /// <see href="https://w3id.org/def/foo#isObservedBy"></see></summary>
    let isObservedBy = _prefix "isObservedBy"
    /// <summary>
    /// Relation between an Observation and the Sensor which made the Observation.
    /// <see href="https://w3id.org/def/foo#madeBySensor"></see></summary>
    let madeBySensor = _prefix "madeBySensor"
    /// <summary>
    /// Relation between a Sensor and an Observation made by the Sensor.
    /// <see href="https://w3id.org/def/foo#madeObservation"></see></summary>
    let madeObservation = _prefix "madeObservation"
    /// <summary>
    /// Relation between a Sensor and an ObservableProperty that it is capable of sensing.
    /// <see href="https://w3id.org/def/foo#observes"></see></summary>
    let observes = _prefix "observes"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#V2.0"></see>
    /// </summary>
    let ``V2.0`` = _prefix "V2.0"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Abaw"></see>
    /// </summary>
    let Abaw = _prefix "Abaw"
    /// <summary>
    /// Bornean elephants exhibit distinct morphological and behavioural traits compared to mainland Asian elephants, and their genetic uniqueness emphasises their priority for conservation efforts. Although they are considered an evolutionary significant unit requiring tailored conservation measures, their formal recognition as a subspecies awaits further research. Restricted to about 5% of Borneo, primarily in Sabah, Bornean elephants typically form family groups of 5 to 20 individuals, occasionally merging into larger herds of up to 200.
    /// <see href="https://w3id.org/def/foo#ElephasMaximus"></see></summary>
    let ElephasMaximus = _prefix "ElephasMaximus"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#GPSObservation"></see>
    /// </summary>
    let GPSObservation = _prefix "GPSObservation"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Animalia"></see>
    /// </summary>
    let Animalia = _prefix "Animalia"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Kingdom"></see>
    /// </summary>
    let Kingdom = _prefix "Kingdom"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Aqeela"></see>
    /// </summary>
    let Aqeela = _prefix "Aqeela"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Bikang1"></see>
    /// </summary>
    let Bikang1 = _prefix "Bikang1"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Bikang2"></see>
    /// </summary>
    let Bikang2 = _prefix "Bikang2"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Binbingan"></see>
    /// </summary>
    let Binbingan = _prefix "Binbingan"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#CNRatio"></see>
    /// </summary>
    let CNRatio = _prefix "CNRatio"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#CameraTrap"></see>
    /// </summary>
    let CameraTrap = _prefix "CameraTrap"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Image"></see>
    /// </summary>
    let Image = _prefix "Image"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#ImageObservation"></see>
    /// </summary>
    let ImageObservation = _prefix "ImageObservation"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Carnivora"></see>
    /// </summary>
    let Carnivora = _prefix "Carnivora"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Order"></see>
    /// </summary>
    let Order = _prefix "Order"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Chordata"></see>
    /// </summary>
    let Chordata = _prefix "Chordata"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Class"></see>
    /// </summary>
    let Class = _prefix "Class"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Clay"></see>
    /// </summary>
    let Clay = _prefix "Clay"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Count"></see>
    /// </summary>
    let Count = _prefix "Count"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Cov"></see>
    /// </summary>
    let Cov = _prefix "Cov"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Dara"></see>
    /// </summary>
    let Dara = _prefix "Dara"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Date"></see>
    /// </summary>
    let Date = _prefix "Date"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Direction"></see>
    /// </summary>
    let Direction = _prefix "Direction"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Distance"></see>
    /// </summary>
    let Distance = _prefix "Distance"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Elephantidae"></see>
    /// </summary>
    let Elephantidae = _prefix "Elephantidae"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Family"></see>
    /// </summary>
    let Family = _prefix "Family"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Proboscidea"></see>
    /// </summary>
    let Proboscidea = _prefix "Proboscidea"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Mammalia"></see>
    /// </summary>
    let Mammalia = _prefix "Mammalia"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#GMTDate"></see>
    /// </summary>
    let GMTDate = _prefix "GMTDate"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#GMTTime"></see>
    /// </summary>
    let GMTTime = _prefix "GMTTime"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#HDOP"></see>
    /// </summary>
    let HDOP = _prefix "HDOP"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#ID"></see>
    /// </summary>
    let ID = _prefix "ID"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#LocalDate"></see>
    /// </summary>
    let LocalDate = _prefix "LocalDate"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#LocalTime"></see>
    /// </summary>
    let LocalTime = _prefix "LocalTime"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Speed"></see>
    /// </summary>
    let Speed = _prefix "Speed"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Temperature"></see>
    /// </summary>
    let Temperature = _prefix "Temperature"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Jasper"></see>
    /// </summary>
    let Jasper = _prefix "Jasper"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Seri"></see>
    /// </summary>
    let Seri = _prefix "Seri"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Liun"></see>
    /// </summary>
    let Liun = _prefix "Liun"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Ita"></see>
    /// </summary>
    let Ita = _prefix "Ita"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Kuma"></see>
    /// </summary>
    let Kuma = _prefix "Kuma"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Tulid"></see>
    /// </summary>
    let Tulid = _prefix "Tulid"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Sejati"></see>
    /// </summary>
    let Sejati = _prefix "Sejati"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Puteri"></see>
    /// </summary>
    let Puteri = _prefix "Puteri"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Maliau"></see>
    /// </summary>
    let Maliau = _prefix "Maliau"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Umas2"></see>
    /// </summary>
    let Umas2 = _prefix "Umas2"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Merotai"></see>
    /// </summary>
    let Merotai = _prefix "Merotai"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Jasmin"></see>
    /// </summary>
    let Jasmin = _prefix "Jasmin"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Kasih"></see>
    /// </summary>
    let Kasih = _prefix "Kasih"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Tunglap"></see>
    /// </summary>
    let Tunglap = _prefix "Tunglap"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Putut"></see>
    /// </summary>
    let Putut = _prefix "Putut"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Guli"></see>
    /// </summary>
    let Guli = _prefix "Guli"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#resultTime"></see>
    /// </summary>
    let resultTime = _prefix "resultTime"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Genus"></see>
    /// </summary>
    let Genus = _prefix "Genus"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Horizon"></see>
    /// </summary>
    let Horizon = _prefix "Horizon"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Identifier"></see>
    /// </summary>
    let Identifier = _prefix "Identifier"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#ImageID"></see>
    /// </summary>
    let ImageID = _prefix "ImageID"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Make"></see>
    /// </summary>
    let Make = _prefix "Make"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Model"></see>
    /// </summary>
    let Model = _prefix "Model"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Time"></see>
    /// </summary>
    let Time = _prefix "Time"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#InorganicP"></see>
    /// </summary>
    let InorganicP = _prefix "InorganicP"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#LandUse"></see>
    /// </summary>
    let LandUse = _prefix "LandUse"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#LianaDBH_cm"></see>
    /// </summary>
    let LianaDBH_cm = _prefix "LianaDBH_cm"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Lianas"></see>
    /// </summary>
    let Lianas = _prefix "Lianas"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#PlotNo"></see>
    /// </summary>
    let PlotNo = _prefix "PlotNo"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#SiteName"></see>
    /// </summary>
    let SiteName = _prefix "SiteName"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#SitePlotCode"></see>
    /// </summary>
    let SitePlotCode = _prefix "SitePlotCode"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#TreeObservation"></see>
    /// </summary>
    let TreeObservation = _prefix "TreeObservation"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#MalayopythonReticulatus"></see>
    /// </summary>
    let MalayopythonReticulatus = _prefix "MalayopythonReticulatus"
    /// <summary>
    /// Manis Javanica is a species critically threatened by poaching and habitat loss. It is one of eight pangolin species, all of which are considered Vulnerable, Endangered, or Critically Endangered according to the IUCN Red List and listed in CITES Appendix I. The Sunda pangolin, critically endangered and the only species found in Malaysia, inhabits Peninsular Malaysia and Malaysian Borneo, including Sabah and Sarawak. Despite its high protection status in Sabah, where it is (totally protected) under the Wildlife Conservation Enactment 1997, the species faces severe threats from illegal wildlife trade and habitat degradation. In 2019, authorities in Sabah seized over 30 tonnes of pangolin products, highlighting the extensive illicit trade network. The Sunda pangolin occupies various habitats, from primary and secondary forests to wetlands, mangroves, and grasslands.
    /// <see href="https://w3id.org/def/foo#ManisJavanica"></see></summary>
    let ManisJavanica = _prefix "ManisJavanica"
    /// <summary>
    /// Male proboscis monkeys have notably large noses, which are believed to have evolved due to their sexually competitive social system. Significant correlations exist between nose size, body size, testis size, and the number of females in a male's harem. This suggests that both male competition and female choice have driven the evolution of these enlarged noses.
    /// <see href="https://w3id.org/def/foo#Nasalislarvatus"></see></summary>
    let Nasalislarvatus = _prefix "Nasalislarvatus"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Phylum"></see>
    /// </summary>
    let Phylum = _prefix "Phylum"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#PlotName"></see>
    /// </summary>
    let PlotName = _prefix "PlotName"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Reptilia"></see>
    /// </summary>
    let Reptilia = _prefix "Reptilia"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Sand"></see>
    /// </summary>
    let Sand = _prefix "Sand"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Silt"></see>
    /// </summary>
    let Silt = _prefix "Silt"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Site"></see>
    /// </summary>
    let Site = _prefix "Site"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Soil"></see>
    /// </summary>
    let Soil = _prefix "Soil"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#SoilObservation"></see>
    /// </summary>
    let SoilObservation = _prefix "SoilObservation"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#SoilPH"></see>
    /// </summary>
    let SoilPH = _prefix "SoilPH"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Subplot"></see>
    /// </summary>
    let Subplot = _prefix "Subplot"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#TotalC"></see>
    /// </summary>
    let TotalC = _prefix "TotalC"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#TotalN"></see>
    /// </summary>
    let TotalN = _prefix "TotalN"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#TotalP"></see>
    /// </summary>
    let TotalP = _prefix "TotalP"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#SoilSensor"></see>
    /// </summary>
    let SoilSensor = _prefix "SoilSensor"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Species"></see>
    /// </summary>
    let Species = _prefix "Species"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Squamata"></see>
    /// </summary>
    let Squamata = _prefix "Squamata"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#SubplotRadius_m"></see>
    /// </summary>
    let SubplotRadius_m = _prefix "SubplotRadius_m"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#TaxonRank"></see>
    /// </summary>
    let TaxonRank = _prefix "TaxonRank"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#TreeDBH_cm"></see>
    /// </summary>
    let TreeDBH_cm = _prefix "TreeDBH_cm"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#TreeHeight_m"></see>
    /// </summary>
    let TreeHeight_m = _prefix "TreeHeight_m"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#TreeID"></see>
    /// </summary>
    let TreeID = _prefix "TreeID"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#TreeIndividualNo"></see>
    /// </summary>
    let TreeIndividualNo = _prefix "TreeIndividualNo"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#TreeNLianas"></see>
    /// </summary>
    let TreeNLianas = _prefix "TreeNLianas"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#TreeNotes"></see>
    /// </summary>
    let TreeNotes = _prefix "TreeNotes"
    /// <summary>
    ///   <see href="https://w3id.org/def/foo#Viverridae"></see>
    /// </summary>
    let Viverridae = _prefix "Viverridae"
    /// <summary>
    /// A relation between a FeatureOfInterest and an Observation about it, an Actuation acting on it, or an act of Sampling that sampled it.
    /// <see href="https://w3id.org/def/foo#isFeatureOfInterestOf"></see></summary>
    let isFeatureOfInterestOf = _prefix "isFeatureOfInterestOf"
    /// <summary>
    /// Relation linking an Observation to the property that was observed. The ObservableProperty should be a property of the FeatureOfInterest (linked by hasFeatureOfInterest) of this Observation.
    /// <see href="https://w3id.org/def/foo#observedProperty"></see></summary>
    let observedProperty = _prefix "observedProperty"
