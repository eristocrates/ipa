namespace http.vocab.datex.org.terms.hash

open DoxAletheia

module datex =
    let _namespace_name = "http://vocab.datex.org/terms#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AbandonedVehicle"></see>
    /// </summary>
    let AbandonedVehicle = _prefix "AbandonedVehicle"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AbnormalLoad"></see>
    /// </summary>
    let AbnormalLoad = _prefix "AbnormalLoad"
    /// <summary>
    /// A traffic condition which is not normal.
    /// <see href="http://vocab.datex.org/terms#AbnormalTraffic"></see></summary>
    let AbnormalTraffic = _prefix "AbnormalTraffic"
    /// <summary>
    /// Accidents are events where one or more vehicles are involved in collisions or in leaving the roadway. These include collisions between vehicles or with other road users or obstacles.
    /// <see href="http://vocab.datex.org/terms#Accident"></see></summary>
    let Accident = _prefix "Accident"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AccidentInvestigationWork"></see>
    /// </summary>
    let AccidentInvestigationWork = _prefix "AccidentInvestigationWork"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AccidentInvolvingBicycles"></see>
    /// </summary>
    let AccidentInvolvingBicycles = _prefix "AccidentInvolvingBicycles"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AccidentInvolvingBuses"></see>
    /// </summary>
    let AccidentInvolvingBuses = _prefix "AccidentInvolvingBuses"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AccidentInvolvingHazardousMaterials"></see>
    /// </summary>
    let AccidentInvolvingHazardousMaterials =
        _prefix "AccidentInvolvingHazardousMaterials"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AccidentInvolvingHeavyLorries"></see>
    /// </summary>
    let AccidentInvolvingHeavyLorries = _prefix "AccidentInvolvingHeavyLorries"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AccidentInvolvingMassTransitVehicle"></see>
    /// </summary>
    let AccidentInvolvingMassTransitVehicle =
        _prefix "AccidentInvolvingMassTransitVehicle"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AccidentInvolvingMopeds"></see>
    /// </summary>
    let AccidentInvolvingMopeds = _prefix "AccidentInvolvingMopeds"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AccidentInvolvingMotorcycles"></see>
    /// </summary>
    let AccidentInvolvingMotorcycles = _prefix "AccidentInvolvingMotorcycles"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AccidentInvolvingRadioactiveMaterial"></see>
    /// </summary>
    let AccidentInvolvingRadioactiveMaterial =
        _prefix "AccidentInvolvingRadioactiveMaterial"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AccidentInvolvingTrain"></see>
    /// </summary>
    let AccidentInvolvingTrain = _prefix "AccidentInvolvingTrain"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#ActiveSpeedControlInOperation"></see>
    /// </summary>
    let ActiveSpeedControlInOperation = _prefix "ActiveSpeedControlInOperation"
    /// <summary>
    /// Deliberate human action external to the traffic stream or roadway which could disrupt traffic.
    /// <see href="http://vocab.datex.org/terms#Activity"></see></summary>
    let Activity = _prefix "Activity"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AdverseInfrastructureConditions"></see>
    /// </summary>
    let AdverseInfrastructureConditions = _prefix "AdverseInfrastructureConditions"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AgriculturalShow"></see>
    /// </summary>
    let AgriculturalShow = _prefix "AgriculturalShow"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AirAmbulance"></see>
    /// </summary>
    let AirAmbulance = _prefix "AirAmbulance"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AirRaid"></see>
    /// </summary>
    let AirRaid = _prefix "AirRaid"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AirShow"></see>
    /// </summary>
    let AirShow = _prefix "AirShow"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AltercationOfVehicleOccupants"></see>
    /// </summary>
    let AltercationOfVehicleOccupants = _prefix "AltercationOfVehicleOccupants"
    /// <summary>
    /// An obstruction on the road resulting from the presence of animals.
    /// <see href="http://vocab.datex.org/terms#AnimalPresenceObstruction"></see></summary>
    let AnimalPresenceObstruction = _prefix "AnimalPresenceObstruction"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AnimalsOnTheInfrastructure"></see>
    /// </summary>
    let AnimalsOnTheInfrastructure = _prefix "AnimalsOnTheInfrastructure"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AnprCameraFailure"></see>
    /// </summary>
    let AnprCameraFailure = _prefix "AnprCameraFailure"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AnprCamerasFault"></see>
    /// </summary>
    let AnprCamerasFault = _prefix "AnprCamerasFault"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Assault"></see>
    /// </summary>
    let Assault = _prefix "Assault"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AssetDestruction"></see>
    /// </summary>
    let AssetDestruction = _prefix "AssetDestruction"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AthleticsMeeting"></see>
    /// </summary>
    let AthleticsMeeting = _prefix "AthleticsMeeting"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Attack"></see>
    /// </summary>
    let Attack = _prefix "Attack"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AttackOnVehicle"></see>
    /// </summary>
    let AttackOnVehicle = _prefix "AttackOnVehicle"
    /// <summary>
    /// Authority initiated operation or activity that could disrupt traffic.
    /// <see href="http://vocab.datex.org/terms#AuthorityOperation"></see></summary>
    let AuthorityOperation = _prefix "AuthorityOperation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AutomatedTollSystemFailure"></see>
    /// </summary>
    let AutomatedTollSystemFailure = _prefix "AutomatedTollSystemFailure"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AutomatedTollSystemFault"></see>
    /// </summary>
    let AutomatedTollSystemFault = _prefix "AutomatedTollSystemFault"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Avalanches"></see>
    /// </summary>
    let Avalanches = _prefix "Avalanches"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BadWeather"></see>
    /// </summary>
    let BadWeather = _prefix "BadWeather"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BallGame"></see>
    /// </summary>
    let BallGame = _prefix "BallGame"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BaseballGame"></see>
    /// </summary>
    let BaseballGame = _prefix "BaseballGame"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BasketballGame"></see>
    /// </summary>
    let BasketballGame = _prefix "BasketballGame"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BicycleRace"></see>
    /// </summary>
    let BicycleRace = _prefix "BicycleRace"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BlackIce"></see>
    /// </summary>
    let BlackIce = _prefix "BlackIce"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BlastingWork"></see>
    /// </summary>
    let BlastingWork = _prefix "BlastingWork"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Blizzard"></see>
    /// </summary>
    let Blizzard = _prefix "Blizzard"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BlockadeOrBarrier"></see>
    /// </summary>
    let BlockadeOrBarrier = _prefix "BlockadeOrBarrier"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BlowingDust"></see>
    /// </summary>
    let BlowingDust = _prefix "BlowingDust"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BlowingSnow"></see>
    /// </summary>
    let BlowingSnow = _prefix "BlowingSnow"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BoatRace"></see>
    /// </summary>
    let BoatRace = _prefix "BoatRace"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BoatShow"></see>
    /// </summary>
    let BoatShow = _prefix "BoatShow"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BombAlert"></see>
    /// </summary>
    let BombAlert = _prefix "BombAlert"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BombSquadInAction"></see>
    /// </summary>
    let BombSquadInAction = _prefix "BombSquadInAction"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BoxingTournament"></see>
    /// </summary>
    let BoxingTournament = _prefix "BoxingTournament"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BridgeSwingInOperation"></see>
    /// </summary>
    let BridgeSwingInOperation = _prefix "BridgeSwingInOperation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BrokenDownBus"></see>
    /// </summary>
    let BrokenDownBus = _prefix "BrokenDownBus"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BrokenDownHeavyLorry"></see>
    /// </summary>
    let BrokenDownHeavyLorry = _prefix "BrokenDownHeavyLorry"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BrokenDownVehicle"></see>
    /// </summary>
    let BrokenDownVehicle = _prefix "BrokenDownVehicle"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BullFight"></see>
    /// </summary>
    let BullFight = _prefix "BullFight"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BurstPipe"></see>
    /// </summary>
    let BurstPipe = _prefix "BurstPipe"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BurstWaterMain"></see>
    /// </summary>
    let BurstWaterMain = _prefix "BurstWaterMain"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#CarPoolLaneInOperation"></see>
    /// </summary>
    let CarPoolLaneInOperation = _prefix "CarPoolLaneInOperation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#CarriagewayClosures"></see>
    /// </summary>
    let CarriagewayClosures = _prefix "CarriagewayClosures"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#CctvCamerasFailure"></see>
    /// </summary>
    let CctvCamerasFailure = _prefix "CctvCamerasFailure"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#CctvCamerasFault"></see>
    /// </summary>
    let CctvCamerasFault = _prefix "CctvCamerasFault"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#CeremonialEvent"></see>
    /// </summary>
    let CeremonialEvent = _prefix "CeremonialEvent"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#ChemicalSpillageAccident"></see>
    /// </summary>
    let ChemicalSpillageAccident = _prefix "ChemicalSpillageAccident"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#CivilEmergency"></see>
    /// </summary>
    let CivilEmergency = _prefix "CivilEmergency"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#ClearanceWork"></see>
    /// </summary>
    let ClearanceWork = _prefix "ClearanceWork"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#ClosedPermanentlyForTheWinter"></see>
    /// </summary>
    let ClosedPermanentlyForTheWinter = _prefix "ClosedPermanentlyForTheWinter"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#CollapsedSewer"></see>
    /// </summary>
    let CollapsedSewer = _prefix "CollapsedSewer"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Collision"></see>
    /// </summary>
    let Collision = _prefix "Collision"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#CollisionWithAnimal"></see>
    /// </summary>
    let CollisionWithAnimal = _prefix "CollisionWithAnimal"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#CollisionWithObstruction"></see>
    /// </summary>
    let CollisionWithObstruction = _prefix "CollisionWithObstruction"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#CollisionWithPerson"></see>
    /// </summary>
    let CollisionWithPerson = _prefix "CollisionWithPerson"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#CommercialEvent"></see>
    /// </summary>
    let CommercialEvent = _prefix "CommercialEvent"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Concert"></see>
    /// </summary>
    let Concert = _prefix "Concert"
    /// <summary>
    /// Any conditions which have the potential to degrade normal driving conditions.
    /// <see href="http://vocab.datex.org/terms#Conditions"></see></summary>
    let Conditions = _prefix "Conditions"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#ConstructionWork"></see>
    /// </summary>
    let ConstructionWork = _prefix "ConstructionWork"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Contraflow"></see>
    /// </summary>
    let Contraflow = _prefix "Contraflow"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#ControlledAvalanche"></see>
    /// </summary>
    let ControlledAvalanche = _prefix "ControlledAvalanche"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Convoy"></see>
    /// </summary>
    let Convoy = _prefix "Convoy"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#ConvoyService"></see>
    /// </summary>
    let ConvoyService = _prefix "ConvoyService"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#CricketMatch"></see>
    /// </summary>
    let CricketMatch = _prefix "CricketMatch"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Crosswinds"></see>
    /// </summary>
    let Crosswinds = _prefix "Crosswinds"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Crowd"></see>
    /// </summary>
    let Crowd = _prefix "Crowd"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#CulturalEvent"></see>
    /// </summary>
    let CulturalEvent = _prefix "CulturalEvent"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#CustomsOperation"></see>
    /// </summary>
    let CustomsOperation = _prefix "CustomsOperation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#DamagedBridge"></see>
    /// </summary>
    let DamagedBridge = _prefix "DamagedBridge"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#DamagedCrashBarrier"></see>
    /// </summary>
    let DamagedCrashBarrier = _prefix "DamagedCrashBarrier"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#DamagedFlyover"></see>
    /// </summary>
    let DamagedFlyover = _prefix "DamagedFlyover"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#DamagedGallery"></see>
    /// </summary>
    let DamagedGallery = _prefix "DamagedGallery"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#DamagedGantry"></see>
    /// </summary>
    let DamagedGantry = _prefix "DamagedGantry"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#DamagedRoadSurface"></see>
    /// </summary>
    let DamagedRoadSurface = _prefix "DamagedRoadSurface"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#DamagedTunnel"></see>
    /// </summary>
    let DamagedTunnel = _prefix "DamagedTunnel"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#DamagedVehicle"></see>
    /// </summary>
    let DamagedVehicle = _prefix "DamagedVehicle"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#DamagedViaduct"></see>
    /// </summary>
    let DamagedViaduct = _prefix "DamagedViaduct"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#DamagingHail"></see>
    /// </summary>
    let DamagingHail = _prefix "DamagingHail"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#DangerousSlowMovingVehicle"></see>
    /// </summary>
    let DangerousSlowMovingVehicle = _prefix "DangerousSlowMovingVehicle"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#DeepSnow"></see>
    /// </summary>
    let DeepSnow = _prefix "DeepSnow"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#DemolitionWork"></see>
    /// </summary>
    let DemolitionWork = _prefix "DemolitionWork"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Demonstration"></see>
    /// </summary>
    let Demonstration = _prefix "Demonstration"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#DenseFog"></see>
    /// </summary>
    let DenseFog = _prefix "DenseFog"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#DieselOnInfrastructure"></see>
    /// </summary>
    let DieselOnInfrastructure = _prefix "DieselOnInfrastructure"
    /// <summary>
    /// Deliberate human action of either a public disorder nature or of a situation alert type which could disrupt traffic.
    /// <see href="http://vocab.datex.org/terms#DisturbanceActivity"></see></summary>
    let DisturbanceActivity = _prefix "DisturbanceActivity"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#DrivingCondition"></see>
    /// </summary>
    let DrivingCondition = _prefix "DrivingCondition"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Dry"></see>
    /// </summary>
    let Dry = _prefix "Dry"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#EarthquakeDamage"></see>
    /// </summary>
    let EarthquakeDamage = _prefix "EarthquakeDamage"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Eclipse"></see>
    /// </summary>
    let Eclipse = _prefix "Eclipse"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#EmergencyRoadsideTelephoneFailure"></see>
    /// </summary>
    let EmergencyRoadsideTelephoneFailure = _prefix "EmergencyRoadsideTelephoneFailure"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#EmergencyRoadsideTelephoneFault"></see>
    /// </summary>
    let EmergencyRoadsideTelephoneFault = _prefix "EmergencyRoadsideTelephoneFault"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#EmergencyServices"></see>
    /// </summary>
    let EmergencyServices = _prefix "EmergencyServices"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#EmergencyVehicle"></see>
    /// </summary>
    let EmergencyVehicle = _prefix "EmergencyVehicle"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#EnvironmentalConditions"></see>
    /// </summary>
    let EnvironmentalConditions = _prefix "EnvironmentalConditions"
    /// <summary>
    /// An obstruction on the road resulting from an environmental cause.
    /// <see href="http://vocab.datex.org/terms#EnvironmentalObstruction"></see></summary>
    let EnvironmentalObstruction = _prefix "EnvironmentalObstruction"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Evacuation"></see>
    /// </summary>
    let Evacuation = _prefix "Evacuation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Exhibition"></see>
    /// </summary>
    let Exhibition = _prefix "Exhibition"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#ExtremeCold"></see>
    /// </summary>
    let ExtremeCold = _prefix "ExtremeCold"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#ExtremeHeat"></see>
    /// </summary>
    let ExtremeHeat = _prefix "ExtremeHeat"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Fair"></see>
    /// </summary>
    let Fair = _prefix "Fair"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#FallenPowerCables"></see>
    /// </summary>
    let FallenPowerCables = _prefix "FallenPowerCables"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#FallenTrees"></see>
    /// </summary>
    let FallenTrees = _prefix "FallenTrees"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#FallingIce"></see>
    /// </summary>
    let FallingIce = _prefix "FallingIce"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#FallingLightIceOrSnow"></see>
    /// </summary>
    let FallingLightIceOrSnow = _prefix "FallingLightIceOrSnow"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Festival"></see>
    /// </summary>
    let Festival = _prefix "Festival"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#FilmTVMaking"></see>
    /// </summary>
    let FilmTVMaking = _prefix "FilmTVMaking"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#FilterBlockade"></see>
    /// </summary>
    let FilterBlockade = _prefix "FilterBlockade"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#FirstAid"></see>
    /// </summary>
    let FirstAid = _prefix "FirstAid"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#FlashFloods"></see>
    /// </summary>
    let FlashFloods = _prefix "FlashFloods"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Flooding"></see>
    /// </summary>
    let Flooding = _prefix "Flooding"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Fog"></see>
    /// </summary>
    let Fog = _prefix "Fog"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#FoodDelivery"></see>
    /// </summary>
    let FoodDelivery = _prefix "FoodDelivery"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#FootballMatch"></see>
    /// </summary>
    let FootballMatch = _prefix "FootballMatch"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#ForestFire"></see>
    /// </summary>
    let ForestFire = _prefix "ForestFire"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#FreezingFog"></see>
    /// </summary>
    let FreezingFog = _prefix "FreezingFog"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#FreezingOfWetInfrastructureSurface"></see>
    /// </summary>
    let FreezingOfWetInfrastructureSurface =
        _prefix "FreezingOfWetInfrastructureSurface"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#FreezingPavements"></see>
    /// </summary>
    let FreezingPavements = _prefix "FreezingPavements"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#FreezingRain"></see>
    /// </summary>
    let FreezingRain = _prefix "FreezingRain"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#FreshSnow"></see>
    /// </summary>
    let FreshSnow = _prefix "FreshSnow"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Frost"></see>
    /// </summary>
    let Frost = _prefix "Frost"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#FuelSpillageAccident"></see>
    /// </summary>
    let FuelSpillageAccident = _prefix "FuelSpillageAccident"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Funfair"></see>
    /// </summary>
    let Funfair = _prefix "Funfair"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Gales"></see>
    /// </summary>
    let Gales = _prefix "Gales"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#GalleryLightsFailure"></see>
    /// </summary>
    let GalleryLightsFailure = _prefix "GalleryLightsFailure"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#GalleryLightsFault"></see>
    /// </summary>
    let GalleryLightsFault = _prefix "GalleryLightsFault"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#GardeningOrFlowerShow"></see>
    /// </summary>
    let GardeningOrFlowerShow = _prefix "GardeningOrFlowerShow"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#GasLeak"></see>
    /// </summary>
    let GasLeak = _prefix "GasLeak"
    /// <summary>
    /// Network management action that is instigated either manually or automatically by the network/road operator.  Compliance with any resulting control may be advisory or mandatory.
    /// <see href="http://vocab.datex.org/terms#GeneralNetworkManagement"></see></summary>
    let GeneralNetworkManagement = _prefix "GeneralNetworkManagement"
    /// <summary>
    /// Any stationary or moving obstacle of a physical nature, other than of an animal, vehicle, environmental, or damaged equipment nature.
    /// <see href="http://vocab.datex.org/terms#GeneralObstruction"></see></summary>
    let GeneralObstruction = _prefix "GeneralObstruction"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#GoSlowOperation"></see>
    /// </summary>
    let GoSlowOperation = _prefix "GoSlowOperation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#GolfTournament"></see>
    /// </summary>
    let GolfTournament = _prefix "GolfTournament"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#GrassCuttingWork"></see>
    /// </summary>
    let GrassCuttingWork = _prefix "GrassCuttingWork"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#GrassFire"></see>
    /// </summary>
    let GrassFire = _prefix "GrassFire"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#GunfireOnRoadway"></see>
    /// </summary>
    let GunfireOnRoadway = _prefix "GunfireOnRoadway"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#GustyWinds"></see>
    /// </summary>
    let GustyWinds = _prefix "GustyWinds"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Hail"></see>
    /// </summary>
    let Hail = _prefix "Hail"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#HardShoulderRunningInOperation"></see>
    /// </summary>
    let HardShoulderRunningInOperation = _prefix "HardShoulderRunningInOperation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Hazardous"></see>
    /// </summary>
    let Hazardous = _prefix "Hazardous"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#HeadOnCollision"></see>
    /// </summary>
    let HeadOnCollision = _prefix "HeadOnCollision"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#HeadOnOrSideCollision"></see>
    /// </summary>
    let HeadOnOrSideCollision = _prefix "HeadOnOrSideCollision"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#HeavyFrost"></see>
    /// </summary>
    let HeavyFrost = _prefix "HeavyFrost"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#HeavyRain"></see>
    /// </summary>
    let HeavyRain = _prefix "HeavyRain"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#HeavySnowfall"></see>
    /// </summary>
    let HeavySnowfall = _prefix "HeavySnowfall"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#HeavyTraffic"></see>
    /// </summary>
    let HeavyTraffic = _prefix "HeavyTraffic"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#HeightRestrictionInOperation"></see>
    /// </summary>
    let HeightRestrictionInOperation = _prefix "HeightRestrictionInOperation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#HelicopterRescue"></see>
    /// </summary>
    let HelicopterRescue = _prefix "HelicopterRescue"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#HerdOfAnimalsOnTheInfrastructure"></see>
    /// </summary>
    let HerdOfAnimalsOnTheInfrastructure = _prefix "HerdOfAnimalsOnTheInfrastructure"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#HighSpeedEmergencyVehicle"></see>
    /// </summary>
    let HighSpeedEmergencyVehicle = _prefix "HighSpeedEmergencyVehicle"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#HockeyGame"></see>
    /// </summary>
    let HockeyGame = _prefix "HockeyGame"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#HorseRaceMeeting"></see>
    /// </summary>
    let HorseRaceMeeting = _prefix "HorseRaceMeeting"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#HurricaneForceWinds"></see>
    /// </summary>
    let HurricaneForceWinds = _prefix "HurricaneForceWinds"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Ice"></see>
    /// </summary>
    let Ice = _prefix "Ice"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#IceBuildUp"></see>
    /// </summary>
    let IceBuildUp = _prefix "IceBuildUp"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#IceWithWheelBarTracks"></see>
    /// </summary>
    let IceWithWheelBarTracks = _prefix "IceWithWheelBarTracks"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#IcyPatches"></see>
    /// </summary>
    let IcyPatches = _prefix "IcyPatches"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#IllVehicleOccupants"></see>
    /// </summary>
    let IllVehicleOccupants = _prefix "IllVehicleOccupants"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Impossible"></see>
    /// </summary>
    let Impossible = _prefix "Impossible"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#InfrastructureConstruction"></see>
    /// </summary>
    let InfrastructureConstruction = _prefix "InfrastructureConstruction"
    /// <summary>
    /// An obstruction on the road resulting from the failure or damage of infrastructure on, under, above or close to the road.
    /// <see href="http://vocab.datex.org/terms#InfrastructureDamageObstruction"></see></summary>
    let InfrastructureDamageObstruction = _prefix "InfrastructureDamageObstruction"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#InfrastructureFailure"></see>
    /// </summary>
    let InfrastructureFailure = _prefix "InfrastructureFailure"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#InfrastructureFault"></see>
    /// </summary>
    let InfrastructureFault = _prefix "InfrastructureFault"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#InfrastructureImprovementOrUpgrading"></see>
    /// </summary>
    let InfrastructureImprovementOrUpgrading =
        _prefix "InfrastructureImprovementOrUpgrading"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#InfrastructureMaintenance"></see>
    /// </summary>
    let InfrastructureMaintenance = _prefix "InfrastructureMaintenance"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#InfrastructureSideAssistance"></see>
    /// </summary>
    let InfrastructureSideAssistance = _prefix "InfrastructureSideAssistance"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#InfrastructureSideCommunicationsSystemFailure"></see>
    /// </summary>
    let InfrastructureSideCommunicationsSystemFailure =
        _prefix "InfrastructureSideCommunicationsSystemFailure"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#InfrastructureSideCommunicationsSystemFault"></see>
    /// </summary>
    let InfrastructureSideCommunicationsSystemFault =
        _prefix "InfrastructureSideCommunicationsSystemFault"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#InfrastructureSidePowerSystemFailure"></see>
    /// </summary>
    let InfrastructureSidePowerSystemFailure =
        _prefix "InfrastructureSidePowerSystemFailure"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#InfrastructureSidePowerSystemFault"></see>
    /// </summary>
    let InfrastructureSidePowerSystemFault =
        _prefix "InfrastructureSidePowerSystemFault"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#InfrastructureSideWork"></see>
    /// </summary>
    let InfrastructureSideWork = _prefix "InfrastructureSideWork"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#InfrastructureSurfaceInPoorCondition"></see>
    /// </summary>
    let InfrastructureSurfaceInPoorCondition =
        _prefix "InfrastructureSurfaceInPoorCondition"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#InfrastructureWorks"></see>
    /// </summary>
    let InfrastructureWorks = _prefix "InfrastructureWorks"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#InfrastructureWorksClearance"></see>
    /// </summary>
    let InfrastructureWorksClearance = _prefix "InfrastructureWorksClearance"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#InstallationWork"></see>
    /// </summary>
    let InstallationWork = _prefix "InstallationWork"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#IntermittentShortTermClosures"></see>
    /// </summary>
    let IntermittentShortTermClosures = _prefix "IntermittentShortTermClosures"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#InternationalSportsMeeting"></see>
    /// </summary>
    let InternationalSportsMeeting = _prefix "InternationalSportsMeeting"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#JackknifedArticulatedLorry"></see>
    /// </summary>
    let JackknifedArticulatedLorry = _prefix "JackknifedArticulatedLorry"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#JackknifedCaravan"></see>
    /// </summary>
    let JackknifedCaravan = _prefix "JackknifedCaravan"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#JackknifedTrailer"></see>
    /// </summary>
    let JackknifedTrailer = _prefix "JackknifedTrailer"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#JuridicalReconstruction"></see>
    /// </summary>
    let JuridicalReconstruction = _prefix "JuridicalReconstruction"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Landslips"></see>
    /// </summary>
    let Landslips = _prefix "Landslips"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#LaneClosure"></see>
    /// </summary>
    let LaneClosure = _prefix "LaneClosure"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#LaneControlSignFailure"></see>
    /// </summary>
    let LaneControlSignFailure = _prefix "LaneControlSignFailure"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#LaneControlSignFault"></see>
    /// </summary>
    let LaneControlSignFault = _prefix "LaneControlSignFault"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#LanesDeviated"></see>
    /// </summary>
    let LanesDeviated = _prefix "LanesDeviated"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#LargeAnimalsOnTheInfrastructure"></see>
    /// </summary>
    let LargeAnimalsOnTheInfrastructure = _prefix "LargeAnimalsOnTheInfrastructure"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#LeavesOnInfrastructure"></see>
    /// </summary>
    let LeavesOnInfrastructure = _prefix "LeavesOnInfrastructure"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#LevelCrossingFailure"></see>
    /// </summary>
    let LevelCrossingFailure = _prefix "LevelCrossingFailure"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#LevelCrossingFault"></see>
    /// </summary>
    let LevelCrossingFault = _prefix "LevelCrossingFault"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#LitterClearance"></see>
    /// </summary>
    let LitterClearance = _prefix "LitterClearance"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#LongLoad"></see>
    /// </summary>
    let LongLoad = _prefix "LongLoad"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#LooseChippings"></see>
    /// </summary>
    let LooseChippings = _prefix "LooseChippings"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#LooseSandOnInfrastructure"></see>
    /// </summary>
    let LooseSandOnInfrastructure = _prefix "LooseSandOnInfrastructure"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#LooseSnow"></see>
    /// </summary>
    let LooseSnow = _prefix "LooseSnow"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#LowSunGlare"></see>
    /// </summary>
    let LowSunGlare = _prefix "LowSunGlare"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#MaintenanceWork"></see>
    /// </summary>
    let MaintenanceWork = _prefix "MaintenanceWork"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#MajorEvent"></see>
    /// </summary>
    let MajorEvent = _prefix "MajorEvent"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Marathon"></see>
    /// </summary>
    let Marathon = _prefix "Marathon"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#March"></see>
    /// </summary>
    let March = _prefix "March"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Market"></see>
    /// </summary>
    let Market = _prefix "Market"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Match"></see>
    /// </summary>
    let Match = _prefix "Match"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#MatrixSignFailure"></see>
    /// </summary>
    let MatrixSignFailure = _prefix "MatrixSignFailure"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#MatrixSignFault"></see>
    /// </summary>
    let MatrixSignFault = _prefix "MatrixSignFault"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#MilitaryConvoy"></see>
    /// </summary>
    let MilitaryConvoy = _prefix "MilitaryConvoy"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#ModerateFog"></see>
    /// </summary>
    let ModerateFog = _prefix "ModerateFog"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#MotorShow"></see>
    /// </summary>
    let MotorShow = _prefix "MotorShow"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#MotorSportRaceMeeting"></see>
    /// </summary>
    let MotorSportRaceMeeting = _prefix "MotorSportRaceMeeting"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#MudOnInfrastructure"></see>
    /// </summary>
    let MudOnInfrastructure = _prefix "MudOnInfrastructure"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#MudSlide"></see>
    /// </summary>
    let MudSlide = _prefix "MudSlide"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#MultipleVehicleCollision"></see>
    /// </summary>
    let MultipleVehicleCollision = _prefix "MultipleVehicleCollision"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#MultivehicleAccident"></see>
    /// </summary>
    let MultivehicleAccident = _prefix "MultivehicleAccident"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#NarrowLanes"></see>
    /// </summary>
    let NarrowLanes = _prefix "NarrowLanes"
    /// <summary>
    /// Network management action which is applicable to the road network and its users.
    /// <see href="http://vocab.datex.org/terms#NetworkManagement"></see></summary>
    let NetworkManagement = _prefix "NetworkManagement"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#NewRoadworksLayout"></see>
    /// </summary>
    let NewRoadworksLayout = _prefix "NewRoadworksLayout"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Normal"></see>
    /// </summary>
    let Normal = _prefix "Normal"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#NormalWinterConditionsForPedestrians"></see>
    /// </summary>
    let NormalWinterConditionsForPedestrians =
        _prefix "NormalWinterConditionsForPedestrians"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#ObstacleSignalling"></see>
    /// </summary>
    let ObstacleSignalling = _prefix "ObstacleSignalling"
    /// <summary>
    /// Any stationary or moving obstacle of a physical nature (e.g. obstacles or vehicles from an earlier accident, shed loads on carriageway, rock fall, abnormal or dangerous loads, or animals etc.) which could disrupt or endanger traffic.
    /// <see href="http://vocab.datex.org/terms#Obstruction"></see></summary>
    let Obstruction = _prefix "Obstruction"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#OilOnInfrastructure"></see>
    /// </summary>
    let OilOnInfrastructure = _prefix "OilOnInfrastructure"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#OilSpillageAccident"></see>
    /// </summary>
    let OilSpillageAccident = _prefix "OilSpillageAccident"
    /// <summary>
    /// Actions that a traffic operator can decide to implement to prevent or help correct dangerous or poor driving conditions, including maintenance of the road infrastructure.
    /// <see href="http://vocab.datex.org/terms#OperatorAction"></see></summary>
    let OperatorAction = _prefix "OperatorAction"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#OverheadWorks"></see>
    /// </summary>
    let OverheadWorks = _prefix "OverheadWorks"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#OverheightVehicle"></see>
    /// </summary>
    let OverheightVehicle = _prefix "OverheightVehicle"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#OvernightClosures"></see>
    /// </summary>
    let OvernightClosures = _prefix "OvernightClosures"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#OverturnedHeavyLorry"></see>
    /// </summary>
    let OverturnedHeavyLorry = _prefix "OverturnedHeavyLorry"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#OverturnedTrailer"></see>
    /// </summary>
    let OverturnedTrailer = _prefix "OverturnedTrailer"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#OverturnedVehicle"></see>
    /// </summary>
    let OverturnedVehicle = _prefix "OverturnedVehicle"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#OzonePollution"></see>
    /// </summary>
    let OzonePollution = _prefix "OzonePollution"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#PackedSnow"></see>
    /// </summary>
    let PackedSnow = _prefix "PackedSnow"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Parade"></see>
    /// </summary>
    let Parade = _prefix "Parade"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#PassableWithCare"></see>
    /// </summary>
    let PassableWithCare = _prefix "PassableWithCare"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#PassengerAssistance"></see>
    /// </summary>
    let PassengerAssistance = _prefix "PassengerAssistance"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#PatchyFog"></see>
    /// </summary>
    let PatchyFog = _prefix "PatchyFog"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#PetrolOnInfrastructure"></see>
    /// </summary>
    let PetrolOnInfrastructure = _prefix "PetrolOnInfrastructure"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#PoliceCheckPoint"></see>
    /// </summary>
    let PoliceCheckPoint = _prefix "PoliceCheckPoint"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#PoliceInvestigation"></see>
    /// </summary>
    let PoliceInvestigation = _prefix "PoliceInvestigation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#PoliceSpeedChecksInOperation"></see>
    /// </summary>
    let PoliceSpeedChecksInOperation = _prefix "PoliceSpeedChecksInOperation"
    /// <summary>
    /// Details of atmospheric pollution.
    /// <see href="http://vocab.datex.org/terms#Pollution"></see></summary>
    let Pollution = _prefix "Pollution"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#PrecipitationInTheArea"></see>
    /// </summary>
    let PrecipitationInTheArea = _prefix "PrecipitationInTheArea"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Procession"></see>
    /// </summary>
    let Procession = _prefix "Procession"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#ProhibitedVehicleOnTheRoadway"></see>
    /// </summary>
    let ProhibitedVehicleOnTheRoadway = _prefix "ProhibitedVehicleOnTheRoadway"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#PublicDisturbance"></see>
    /// </summary>
    let PublicDisturbance = _prefix "PublicDisturbance"
    /// <summary>
    /// Organised public event which could disrupt traffic.
    /// <see href="http://vocab.datex.org/terms#PublicEvent"></see></summary>
    let PublicEvent = _prefix "PublicEvent"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#QueuingTraffic"></see>
    /// </summary>
    let QueuingTraffic = _prefix "QueuingTraffic"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#RaceMeeting"></see>
    /// </summary>
    let RaceMeeting = _prefix "RaceMeeting"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#RadioactiveLeakAlert"></see>
    /// </summary>
    let RadioactiveLeakAlert = _prefix "RadioactiveLeakAlert"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Rain"></see>
    /// </summary>
    let Rain = _prefix "Rain"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#RainChangingToSnow"></see>
    /// </summary>
    let RainChangingToSnow = _prefix "RainChangingToSnow"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#RampControlFailure"></see>
    /// </summary>
    let RampControlFailure = _prefix "RampControlFailure"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#RampControlFault"></see>
    /// </summary>
    let RampControlFault = _prefix "RampControlFault"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#RampMeteringInOperation"></see>
    /// </summary>
    let RampMeteringInOperation = _prefix "RampMeteringInOperation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#RearCollision"></see>
    /// </summary>
    let RearCollision = _prefix "RearCollision"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#RepairWork"></see>
    /// </summary>
    let RepairWork = _prefix "RepairWork"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#ResurfacingWork"></see>
    /// </summary>
    let ResurfacingWork = _prefix "ResurfacingWork"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Riot"></see>
    /// </summary>
    let Riot = _prefix "Riot"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#RoadCleared"></see>
    /// </summary>
    let RoadCleared = _prefix "RoadCleared"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#RoadClosure"></see>
    /// </summary>
    let RoadClosure = _prefix "RoadClosure"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#RoadMarkingWork"></see>
    /// </summary>
    let RoadMarkingWork = _prefix "RoadMarkingWork"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#RoadOperatorCheckPoint"></see>
    /// </summary>
    let RoadOperatorCheckPoint = _prefix "RoadOperatorCheckPoint"
    /// <summary>
    /// Road, carriageway or lane management action that is instigated by the network/road operator.
    /// <see href="http://vocab.datex.org/terms#RoadOrCarriagewayOrLaneManagement"></see></summary>
    let RoadOrCarriagewayOrLaneManagement = _prefix "RoadOrCarriagewayOrLaneManagement"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#RoadSurfaceMelting"></see>
    /// </summary>
    let RoadSurfaceMelting = _prefix "RoadSurfaceMelting"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#RoadWideningWork"></see>
    /// </summary>
    let RoadWideningWork = _prefix "RoadWideningWork"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#RockFallPreventativeMaintenance"></see>
    /// </summary>
    let RockFallPreventativeMaintenance = _prefix "RockFallPreventativeMaintenance"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Rockfalls"></see>
    /// </summary>
    let Rockfalls = _prefix "Rockfalls"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#RollingRoadBlock"></see>
    /// </summary>
    let RollingRoadBlock = _prefix "RollingRoadBlock"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#RugbyMatch"></see>
    /// </summary>
    let RugbyMatch = _prefix "RugbyMatch"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#RushHourLaneInOperation"></see>
    /// </summary>
    let RushHourLaneInOperation = _prefix "RushHourLaneInOperation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Sabotage"></see>
    /// </summary>
    let Sabotage = _prefix "Sabotage"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SaltingInProgress"></see>
    /// </summary>
    let SaltingInProgress = _prefix "SaltingInProgress"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SaltingOrGrittingVehicleInUse"></see>
    /// </summary>
    let SaltingOrGrittingVehicleInUse = _prefix "SaltingOrGrittingVehicleInUse"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SandStorms"></see>
    /// </summary>
    let SandStorms = _prefix "SandStorms"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SecurityAlert"></see>
    /// </summary>
    let SecurityAlert = _prefix "SecurityAlert"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SecurityIncident"></see>
    /// </summary>
    let SecurityIncident = _prefix "SecurityIncident"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SeriousAccident"></see>
    /// </summary>
    let SeriousAccident = _prefix "SeriousAccident"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SeriousFire"></see>
    /// </summary>
    let SeriousFire = _prefix "SeriousFire"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SeveralMajorEvents"></see>
    /// </summary>
    let SeveralMajorEvents = _prefix "SeveralMajorEvents"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SevereExhaustPollution"></see>
    /// </summary>
    let SevereExhaustPollution = _prefix "SevereExhaustPollution"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SevereSmog"></see>
    /// </summary>
    let SevereSmog = _prefix "SevereSmog"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SewerOverflow"></see>
    /// </summary>
    let SewerOverflow = _prefix "SewerOverflow"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Show"></see>
    /// </summary>
    let Show = _prefix "Show"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#ShowJumping"></see>
    /// </summary>
    let ShowJumping = _prefix "ShowJumping"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Showers"></see>
    /// </summary>
    let Showers = _prefix "Showers"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SideCollision"></see>
    /// </summary>
    let SideCollision = _prefix "SideCollision"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SightseersObstructingAccess"></see>
    /// </summary>
    let SightseersObstructingAccess = _prefix "SightseersObstructingAccess"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SingleAlternateLineTraffic"></see>
    /// </summary>
    let SingleAlternateLineTraffic = _prefix "SingleAlternateLineTraffic"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Sleet"></see>
    /// </summary>
    let Sleet = _prefix "Sleet"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SlipperyRoad"></see>
    /// </summary>
    let SlipperyRoad = _prefix "SlipperyRoad"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SlowMovingMaintenanceVehicle"></see>
    /// </summary>
    let SlowMovingMaintenanceVehicle = _prefix "SlowMovingMaintenanceVehicle"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SlowTraffic"></see>
    /// </summary>
    let SlowTraffic = _prefix "SlowTraffic"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SlowVehicle"></see>
    /// </summary>
    let SlowVehicle = _prefix "SlowVehicle"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SlushOnRoad"></see>
    /// </summary>
    let SlushOnRoad = _prefix "SlushOnRoad"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SlushStrings"></see>
    /// </summary>
    let SlushStrings = _prefix "SlushStrings"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SmogAlert"></see>
    /// </summary>
    let SmogAlert = _prefix "SmogAlert"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SmokeHazard"></see>
    /// </summary>
    let SmokeHazard = _prefix "SmokeHazard"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SmokeOrFumes"></see>
    /// </summary>
    let SmokeOrFumes = _prefix "SmokeOrFumes"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SnowChangingToRain"></see>
    /// </summary>
    let SnowChangingToRain = _prefix "SnowChangingToRain"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SnowDrifts"></see>
    /// </summary>
    let SnowDrifts = _prefix "SnowDrifts"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SnowOnPavement"></see>
    /// </summary>
    let SnowOnPavement = _prefix "SnowOnPavement"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SnowOnTheInfrastructure"></see>
    /// </summary>
    let SnowOnTheInfrastructure = _prefix "SnowOnTheInfrastructure"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Snowfall"></see>
    /// </summary>
    let Snowfall = _prefix "Snowfall"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Snowplough"></see>
    /// </summary>
    let Snowplough = _prefix "Snowplough"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SnowploughsInUse"></see>
    /// </summary>
    let SnowploughsInUse = _prefix "SnowploughsInUse"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SpeedControlSignFailure"></see>
    /// </summary>
    let SpeedControlSignFailure = _prefix "SpeedControlSignFailure"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SpeedControlSignFault"></see>
    /// </summary>
    let SpeedControlSignFault = _prefix "SpeedControlSignFault"
    /// <summary>
    /// Speed management action that is instigated by the network/road operator.
    /// <see href="http://vocab.datex.org/terms#SpeedManagement"></see></summary>
    let SpeedManagement = _prefix "SpeedManagement"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SpeedRestriction"></see>
    /// </summary>
    let SpeedRestriction = _prefix "SpeedRestriction"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SportsMeeting"></see>
    /// </summary>
    let SportsMeeting = _prefix "SportsMeeting"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SprayHazard"></see>
    /// </summary>
    let SprayHazard = _prefix "SprayHazard"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#StateOccasion"></see>
    /// </summary>
    let StateOccasion = _prefix "StateOccasion"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#StationaryTraffic"></see>
    /// </summary>
    let StationaryTraffic = _prefix "StationaryTraffic"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#StormDamage"></see>
    /// </summary>
    let StormDamage = _prefix "StormDamage"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#StormForceWinds"></see>
    /// </summary>
    let StormForceWinds = _prefix "StormForceWinds"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#StreetLightingFailure"></see>
    /// </summary>
    let StreetLightingFailure = _prefix "StreetLightingFailure"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#StreetLightingFault"></see>
    /// </summary>
    let StreetLightingFault = _prefix "StreetLightingFault"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Strike"></see>
    /// </summary>
    let Strike = _prefix "Strike"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#StrongGustsOfWind"></see>
    /// </summary>
    let StrongGustsOfWind = _prefix "StrongGustsOfWind"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#StrongWinds"></see>
    /// </summary>
    let StrongWinds = _prefix "StrongWinds"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Subsidence"></see>
    /// </summary>
    let Subsidence = _prefix "Subsidence"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SurfaceWater"></see>
    /// </summary>
    let SurfaceWater = _prefix "SurfaceWater"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Survey"></see>
    /// </summary>
    let Survey = _prefix "Survey"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SwarmsOfInsects"></see>
    /// </summary>
    let SwarmsOfInsects = _prefix "SwarmsOfInsects"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SweepingOfRoad"></see>
    /// </summary>
    let SweepingOfRoad = _prefix "SweepingOfRoad"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TemperatureFalling"></see>
    /// </summary>
    let TemperatureFalling = _prefix "TemperatureFalling"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TemporaryTrafficLights"></see>
    /// </summary>
    let TemporaryTrafficLights = _prefix "TemporaryTrafficLights"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TemporaryTrafficLightsFailure"></see>
    /// </summary>
    let TemporaryTrafficLightsFailure = _prefix "TemporaryTrafficLightsFailure"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TemporaryTrafficLightsFault"></see>
    /// </summary>
    let TemporaryTrafficLightsFault = _prefix "TemporaryTrafficLightsFault"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TennisTournament"></see>
    /// </summary>
    let TennisTournament = _prefix "TennisTournament"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TerroristIncident"></see>
    /// </summary>
    let TerroristIncident = _prefix "TerroristIncident"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Theft"></see>
    /// </summary>
    let Theft = _prefix "Theft"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Thunderstorms"></see>
    /// </summary>
    let Thunderstorms = _prefix "Thunderstorms"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TidalFlowLaneInOperation"></see>
    /// </summary>
    let TidalFlowLaneInOperation = _prefix "TidalFlowLaneInOperation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TollGatesFailure"></see>
    /// </summary>
    let TollGatesFailure = _prefix "TollGatesFailure"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TollGatesFault"></see>
    /// </summary>
    let TollGatesFault = _prefix "TollGatesFault"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TollGatesOpen"></see>
    /// </summary>
    let TollGatesOpen = _prefix "TollGatesOpen"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Tornadoes"></see>
    /// </summary>
    let Tornadoes = _prefix "Tornadoes"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Tournament"></see>
    /// </summary>
    let Tournament = _prefix "Tournament"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#ToxicCloudAlert"></see>
    /// </summary>
    let ToxicCloudAlert = _prefix "ToxicCloudAlert"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TrackLayingVehicle"></see>
    /// </summary>
    let TrackLayingVehicle = _prefix "TrackLayingVehicle"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TradeFair"></see>
    /// </summary>
    let TradeFair = _prefix "TradeFair"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TrafficBeingManuallyDirected"></see>
    /// </summary>
    let TrafficBeingManuallyDirected = _prefix "TrafficBeingManuallyDirected"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TrafficElementEvent"></see>
    /// </summary>
    let TrafficElementEvent = _prefix "TrafficElementEvent"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TrafficHeld"></see>
    /// </summary>
    let TrafficHeld = _prefix "TrafficHeld"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TrafficLightSetFailure"></see>
    /// </summary>
    let TrafficLightSetFailure = _prefix "TrafficLightSetFailure"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TrafficLightSetFault"></see>
    /// </summary>
    let TrafficLightSetFault = _prefix "TrafficLightSetFault"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TrafficSignalsFailure"></see>
    /// </summary>
    let TrafficSignalsFailure = _prefix "TrafficSignalsFailure"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TrafficSignalsFault"></see>
    /// </summary>
    let TrafficSignalsFault = _prefix "TrafficSignalsFault"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TransportOfVip"></see>
    /// </summary>
    let TransportOfVip = _prefix "TransportOfVip"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TreeAndVegetationCuttingWork"></see>
    /// </summary>
    let TreeAndVegetationCuttingWork = _prefix "TreeAndVegetationCuttingWork"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TunnelLightFailure"></see>
    /// </summary>
    let TunnelLightFailure = _prefix "TunnelLightFailure"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TunnelLightFault"></see>
    /// </summary>
    let TunnelLightFault = _prefix "TunnelLightFault"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TunnelVentilationFailure"></see>
    /// </summary>
    let TunnelVentilationFailure = _prefix "TunnelVentilationFailure"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TunnelVentilationFault"></see>
    /// </summary>
    let TunnelVentilationFault = _prefix "TunnelVentilationFault"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TurnAroundInOperation"></see>
    /// </summary>
    let TurnAroundInOperation = _prefix "TurnAroundInOperation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#UndefinedAuthorityActivity"></see>
    /// </summary>
    let UndefinedAuthorityActivity = _prefix "UndefinedAuthorityActivity"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Unknown"></see>
    /// </summary>
    let Unknown = _prefix "Unknown"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#UnlitVehicleOnTheRoad"></see>
    /// </summary>
    let UnlitVehicleOnTheRoad = _prefix "UnlitVehicleOnTheRoad"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#UnspecifiedAbnormalTraffic"></see>
    /// </summary>
    let UnspecifiedAbnormalTraffic = _prefix "UnspecifiedAbnormalTraffic"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#UnspecifiedAlert"></see>
    /// </summary>
    let UnspecifiedAlert = _prefix "UnspecifiedAlert"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#UseOfSpecifiedLanesOrCarriagewaysAllowed"></see>
    /// </summary>
    let UseOfSpecifiedLanesOrCarriagewaysAllowed =
        _prefix "UseOfSpecifiedLanesOrCarriagewaysAllowed"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VariableMessageSignFailure"></see>
    /// </summary>
    let VariableMessageSignFailure = _prefix "VariableMessageSignFailure"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VariableMessageSignFault"></see>
    /// </summary>
    let VariableMessageSignFault = _prefix "VariableMessageSignFault"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VehicleCarryingHazardousMaterials"></see>
    /// </summary>
    let VehicleCarryingHazardousMaterials = _prefix "VehicleCarryingHazardousMaterials"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VehicleInDifficulty"></see>
    /// </summary>
    let VehicleInDifficulty = _prefix "VehicleInDifficulty"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VehicleInspectionCheckPoint"></see>
    /// </summary>
    let VehicleInspectionCheckPoint = _prefix "VehicleInspectionCheckPoint"
    /// <summary>
    /// An obstruction on the road caused by one or more vehicles.
    /// <see href="http://vocab.datex.org/terms#VehicleObstruction"></see></summary>
    let VehicleObstruction = _prefix "VehicleObstruction"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VehicleOffRoad"></see>
    /// </summary>
    let VehicleOffRoad = _prefix "VehicleOffRoad"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VehicleOnFire"></see>
    /// </summary>
    let VehicleOnFire = _prefix "VehicleOnFire"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VehicleOnWrongCarriageway"></see>
    /// </summary>
    let VehicleOnWrongCarriageway = _prefix "VehicleOnWrongCarriageway"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VehicleRecovery"></see>
    /// </summary>
    let VehicleRecovery = _prefix "VehicleRecovery"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VehicleRepair"></see>
    /// </summary>
    let VehicleRepair = _prefix "VehicleRepair"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VehicleSpunAround"></see>
    /// </summary>
    let VehicleSpunAround = _prefix "VehicleSpunAround"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VehicleStorageInOperation"></see>
    /// </summary>
    let VehicleStorageInOperation = _prefix "VehicleStorageInOperation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VehicleStuck"></see>
    /// </summary>
    let VehicleStuck = _prefix "VehicleStuck"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VehicleStuckUnderBridge"></see>
    /// </summary>
    let VehicleStuckUnderBridge = _prefix "VehicleStuckUnderBridge"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VehicleWeighing"></see>
    /// </summary>
    let VehicleWeighing = _prefix "VehicleWeighing"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VehicleWithOverheightLoad"></see>
    /// </summary>
    let VehicleWithOverheightLoad = _prefix "VehicleWithOverheightLoad"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VehicleWithOverwideLoad"></see>
    /// </summary>
    let VehicleWithOverwideLoad = _prefix "VehicleWithOverwideLoad"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VeryHazardous"></see>
    /// </summary>
    let VeryHazardous = _prefix "VeryHazardous"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VeryStrongGustsOfWind"></see>
    /// </summary>
    let VeryStrongGustsOfWind = _prefix "VeryStrongGustsOfWind"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VisibilityReduced"></see>
    /// </summary>
    let VisibilityReduced = _prefix "VisibilityReduced"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#WaterSportsMeeting"></see>
    /// </summary>
    let WaterSportsMeeting = _prefix "WaterSportsMeeting"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#WeakBridge"></see>
    /// </summary>
    let WeakBridge = _prefix "WeakBridge"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#WeatherRelatedConditions"></see>
    /// </summary>
    let WeatherRelatedConditions = _prefix "WeatherRelatedConditions"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#WeighInMotion"></see>
    /// </summary>
    let WeighInMotion = _prefix "WeighInMotion"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#WeightRestrictionInOperation"></see>
    /// </summary>
    let WeightRestrictionInOperation = _prefix "WeightRestrictionInOperation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Wet"></see>
    /// </summary>
    let Wet = _prefix "Wet"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#WetAndIcyRoad"></see>
    /// </summary>
    let WetAndIcyRoad = _prefix "WetAndIcyRoad"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#WetIcyPavement"></see>
    /// </summary>
    let WetIcyPavement = _prefix "WetIcyPavement"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#WhiteOut"></see>
    /// </summary>
    let WhiteOut = _prefix "WhiteOut"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#WinterConditions"></see>
    /// </summary>
    let WinterConditions = _prefix "WinterConditions"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#WinterSportsMeeting"></see>
    /// </summary>
    let WinterSportsMeeting = _prefix "WinterSportsMeeting"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#WinterStorm"></see>
    /// </summary>
    let WinterStorm = _prefix "WinterStorm"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Ontology"></see>
    /// </summary>
    let Ontology = _prefix "Ontology"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#abnormalTrafficExtension"></see>
    /// </summary>
    let abnormalTrafficExtension = _prefix "abnormalTrafficExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_ExtensionType"></see>
    /// </summary>
    let _ExtensionType = _prefix "_ExtensionType"
    /// <summary>
    /// A characterization of the nature of abnormal traffic flow, i.e. specifically relating to the nature of the traffic movement.
    /// <see href="http://vocab.datex.org/terms#abnormalTrafficType"></see></summary>
    let abnormalTrafficType = _prefix "abnormalTrafficType"
    /// <summary>
    /// The number of vehicles waiting in a queue.
    /// <see href="http://vocab.datex.org/terms#numberOfVehiclesWaiting"></see></summary>
    let numberOfVehiclesWaiting = _prefix "numberOfVehiclesWaiting"
    /// <summary>
    /// The length of a queue or the average length of queues in separate lanes due to a situation.
    /// <see href="http://vocab.datex.org/terms#queueLength"></see></summary>
    let queueLength = _prefix "queueLength"
    /// <summary>
    /// Assessment of the traffic flow conditions relative to normally expected conditions at this date/time.
    /// <see href="http://vocab.datex.org/terms#relativeTrafficFlow"></see></summary>
    let relativeTrafficFlow = _prefix "relativeTrafficFlow"
    /// <summary>
    /// A characterization of the traffic flow.
    /// <see href="http://vocab.datex.org/terms#trafficFlowCharacteristics"></see></summary>
    let trafficFlowCharacteristics = _prefix "trafficFlowCharacteristics"
    /// <summary>
    /// A characterization of the trend in the traffic conditions at the specified location and direction.
    /// <see href="http://vocab.datex.org/terms#trafficTrendType"></see></summary>
    let trafficTrendType = _prefix "trafficTrendType"
    /// <summary>
    /// An event which is not planned by the traffic operator, which is affecting, or has the potential to affect traffic flow.
    /// <see href="http://vocab.datex.org/terms#TrafficElement"></see></summary>
    let TrafficElement = _prefix "TrafficElement"
    /// <summary>
    /// Use this class to describe details in case acceptedMeansOfPayment is set to 'paymentCard'.
    /// <see href="http://vocab.datex.org/terms#AcceptedPaymentCards"></see></summary>
    let AcceptedPaymentCards = _prefix "AcceptedPaymentCards"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#acceptedPaymentCardsExtension"></see>
    /// </summary>
    let acceptedPaymentCardsExtension = _prefix "acceptedPaymentCardsExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#otherPaymentCardBrands"></see>
    /// </summary>
    let otherPaymentCardBrands = _prefix "otherPaymentCardBrands"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#otherPaymentCards"></see>
    /// </summary>
    let otherPaymentCards = _prefix "otherPaymentCards"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#paymentCardBrands"></see>
    /// </summary>
    let paymentCardBrands = _prefix "paymentCardBrands"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#paymentCards"></see>
    /// </summary>
    let paymentCards = _prefix "paymentCards"
    /// <summary>
    /// A descriptor indicating the most significant factor causing an accident.
    /// <see href="http://vocab.datex.org/terms#accidentCause"></see></summary>
    let accidentCause = _prefix "accidentCause"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#accidentExtension"></see>
    /// </summary>
    let accidentExtension = _prefix "accidentExtension"
    /// <summary>
    /// A characterization of the nature of the accident.
    /// <see href="http://vocab.datex.org/terms#accidentType"></see></summary>
    let accidentType = _prefix "accidentType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#groupOfPeopleInvolved"></see>
    /// </summary>
    let groupOfPeopleInvolved = _prefix "groupOfPeopleInvolved"
    /// <summary>
    /// Group of people involved in the event having common characteristics and/or status.
    /// <see href="http://vocab.datex.org/terms#GroupOfPeopleInvolved"></see></summary>
    let GroupOfPeopleInvolved = _prefix "GroupOfPeopleInvolved"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#groupOfVehiclesInvolved"></see>
    /// </summary>
    let groupOfVehiclesInvolved = _prefix "groupOfVehiclesInvolved"
    /// <summary>
    /// Group of the vehicles involved having common characteristics and/or status.
    /// <see href="http://vocab.datex.org/terms#GroupOfVehiclesInvolved"></see></summary>
    let GroupOfVehiclesInvolved = _prefix "GroupOfVehiclesInvolved"
    /// <summary>
    /// The total number of people that are involved.
    /// <see href="http://vocab.datex.org/terms#totalNumberOfPeopleInvolved"></see></summary>
    let totalNumberOfPeopleInvolved = _prefix "totalNumberOfPeopleInvolved"
    /// <summary>
    /// The total number of vehicles that are involved.
    /// <see href="http://vocab.datex.org/terms#totalNumberOfVehiclesInvolved"></see></summary>
    let totalNumberOfVehiclesInvolved = _prefix "totalNumberOfVehiclesInvolved"
    /// <summary>
    /// The vehicle involved in the accident.
    /// <see href="http://vocab.datex.org/terms#vehicleInvolved"></see></summary>
    let vehicleInvolved = _prefix "vehicleInvolved"
    /// <summary>
    /// Details of an individual vehicle.
    /// <see href="http://vocab.datex.org/terms#Vehicle"></see></summary>
    let Vehicle = _prefix "Vehicle"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#activityExtension"></see>
    /// </summary>
    let activityExtension = _prefix "activityExtension"
    /// <summary>
    /// Mobility of the activity.
    /// <see href="http://vocab.datex.org/terms#mobilityOfActivity"></see></summary>
    let mobilityOfActivity = _prefix "mobilityOfActivity"
    /// <summary>
    /// An indication of whether the associated instance of a SituationRecord is mobile (e.g. a march or parade moving along a road) or stationary.
    /// <see href="http://vocab.datex.org/terms#Mobility"></see></summary>
    let Mobility = _prefix "Mobility"
    /// <summary>
    /// Supplementary positional information which details carriageway and lane locations. Several instances may exist where the element being described extends over more than one carriageway.
    /// <see href="http://vocab.datex.org/terms#AffectedCarriagewayAndLanes"></see></summary>
    let AffectedCarriagewayAndLanes = _prefix "AffectedCarriagewayAndLanes"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#affectedCarriagewayAndLanesExtension"></see>
    /// </summary>
    let affectedCarriagewayAndLanesExtension =
        _prefix "affectedCarriagewayAndLanesExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#carriageway"></see>
    /// </summary>
    let carriageway = _prefix "carriageway"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#footpath"></see>
    /// </summary>
    let footpath = _prefix "footpath"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#lane"></see>
    /// </summary>
    let lane = _prefix "lane"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#lengthAffected"></see>
    /// </summary>
    let lengthAffected = _prefix "lengthAffected"
    /// <summary>
    /// An area defined by reference to a predefined ALERT-C location table.
    /// <see href="http://vocab.datex.org/terms#AlertCArea"></see></summary>
    let AlertCArea = _prefix "AlertCArea"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCAreaExtension"></see>
    /// </summary>
    let alertCAreaExtension = _prefix "alertCAreaExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCLocationCountryCode"></see>
    /// </summary>
    let alertCLocationCountryCode = _prefix "alertCLocationCountryCode"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCLocationTableNumber"></see>
    /// </summary>
    let alertCLocationTableNumber = _prefix "alertCLocationTableNumber"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCLocationTableVersion"></see>
    /// </summary>
    let alertCLocationTableVersion = _prefix "alertCLocationTableVersion"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#areaLocation"></see>
    /// </summary>
    let areaLocation = _prefix "areaLocation"
    /// <summary>
    /// Identification of a specific point, linear or area location in an ALERT-C location table.
    /// <see href="http://vocab.datex.org/terms#AlertCLocation"></see></summary>
    let AlertCLocation = _prefix "AlertCLocation"
    /// <summary>
    /// The direction of traffic flow along the road to which the information relates.
    /// <see href="http://vocab.datex.org/terms#AlertCDirection"></see></summary>
    let AlertCDirection = _prefix "AlertCDirection"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCDirectionCoded"></see>
    /// </summary>
    let alertCDirectionCoded = _prefix "alertCDirectionCoded"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCDirectionExtension"></see>
    /// </summary>
    let alertCDirectionExtension = _prefix "alertCDirectionExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCDirectionNamed"></see>
    /// </summary>
    let alertCDirectionNamed = _prefix "alertCDirectionNamed"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#MultilingualString"></see>
    /// </summary>
    let MultilingualString = _prefix "MultilingualString"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCDirectionSense"></see>
    /// </summary>
    let alertCDirectionSense = _prefix "alertCDirectionSense"
    /// <summary>
    /// A linear section along a road defined between two points on the road by reference to a pre-defined ALERT-C location table.
    /// <see href="http://vocab.datex.org/terms#AlertCLinear"></see></summary>
    let AlertCLinear = _prefix "AlertCLinear"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCLinearExtension"></see>
    /// </summary>
    let alertCLinearExtension = _prefix "alertCLinearExtension"
    /// <summary>
    /// A linear section along a road defined by reference to a linear section in a pre-defined ALERT-C location table.
    /// <see href="http://vocab.datex.org/terms#AlertCLinearByCode"></see></summary>
    let AlertCLinearByCode = _prefix "AlertCLinearByCode"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCDirection"></see>
    /// </summary>
    let alertCDirection = _prefix "alertCDirection"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCLinearByCodeExtension"></see>
    /// </summary>
    let alertCLinearByCodeExtension = _prefix "alertCLinearByCodeExtension"
    /// <summary>
    /// Linear location defined by a specific Alert-C location.
    /// <see href="http://vocab.datex.org/terms#locationCodeForLinearLocation"></see></summary>
    let locationCodeForLinearLocation = _prefix "locationCodeForLinearLocation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCLocationExtension"></see>
    /// </summary>
    let alertCLocationExtension = _prefix "alertCLocationExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCLocationName"></see>
    /// </summary>
    let alertCLocationName = _prefix "alertCLocationName"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#specificLocation"></see>
    /// </summary>
    let specificLocation = _prefix "specificLocation"
    /// <summary>
    /// A linear section along a road between two points, Primary and Secondary, which are pre-defined in an ALERT-C location table. Direction is FROM the Secondary point TO the Primary point, i.e. the Primary point is downstream of the Secondary point.
    /// <see href="http://vocab.datex.org/terms#AlertCMethod2Linear"></see></summary>
    let AlertCMethod2Linear = _prefix "AlertCMethod2Linear"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCMethod2LinearExtension"></see>
    /// </summary>
    let alertCMethod2LinearExtension = _prefix "alertCMethod2LinearExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCMethod2PrimaryPointLocation"></see>
    /// </summary>
    let alertCMethod2PrimaryPointLocation = _prefix "alertCMethod2PrimaryPointLocation"
    /// <summary>
    /// The point (called Primary point) which is either a single point or at the downstream end of a linear road section. The point is specified by a reference to a point in a pre-defined ALERT-C location table.
    /// <see href="http://vocab.datex.org/terms#AlertCMethod2PrimaryPointLocation"></see></summary>
    let AlertCMethod2PrimaryPointLocation = _prefix "AlertCMethod2PrimaryPointLocation"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCMethod2SecondaryPointLocation"></see>
    /// </summary>
    let alertCMethod2SecondaryPointLocation =
        _prefix "alertCMethod2SecondaryPointLocation"

    /// <summary>
    /// The point (called Secondary point) which is at the upstream end of a linear road section. The point is specified by a reference to a point in a pre-defined ALERT-C location table.
    /// <see href="http://vocab.datex.org/terms#AlertCMethod2SecondaryPointLocation"></see></summary>
    let AlertCMethod2SecondaryPointLocation =
        _prefix "AlertCMethod2SecondaryPointLocation"

    /// <summary>
    /// A single point on the road network defined by reference to a point in a pre-defined ALERT-C location table and which has an associated direction of traffic flow.
    /// <see href="http://vocab.datex.org/terms#AlertCMethod2Point"></see></summary>
    let AlertCMethod2Point = _prefix "AlertCMethod2Point"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCMethod2PointExtension"></see>
    /// </summary>
    let alertCMethod2PointExtension = _prefix "alertCMethod2PointExtension"
    /// <summary>
    /// A single point on the road network defined by reference to a pre-defined ALERT-C location table and which has an associated direction of traffic flow.
    /// <see href="http://vocab.datex.org/terms#AlertCPoint"></see></summary>
    let AlertCPoint = _prefix "AlertCPoint"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCLocation"></see>
    /// </summary>
    let alertCLocation = _prefix "alertCLocation"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCMethod2PrimaryPointLocationExtension"></see>
    /// </summary>
    let alertCMethod2PrimaryPointLocationExtension =
        _prefix "alertCMethod2PrimaryPointLocationExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCMethod2SecondaryPointLocationExtension"></see>
    /// </summary>
    let alertCMethod2SecondaryPointLocationExtension =
        _prefix "alertCMethod2SecondaryPointLocationExtension"

    /// <summary>
    /// A linear section along a road between two points, Primary and Secondary, which are pre-defined ALERT-C locations plus offset distance. Direction is FROM the Secondary point TO the Primary point, i.e. the Primary point is downstream of the Secondary point.
    /// <see href="http://vocab.datex.org/terms#AlertCMethod4Linear"></see></summary>
    let AlertCMethod4Linear = _prefix "AlertCMethod4Linear"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCMethod4LinearExtension"></see>
    /// </summary>
    let alertCMethod4LinearExtension = _prefix "alertCMethod4LinearExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCMethod4PrimaryPointLocation"></see>
    /// </summary>
    let alertCMethod4PrimaryPointLocation = _prefix "alertCMethod4PrimaryPointLocation"
    /// <summary>
    /// The point (called Primary point) which is either a single point or at the downstream end of a linear road section. The point is specified by a reference to a point in a pre-defined ALERT-C location table plus a non-negative offset distance.
    /// <see href="http://vocab.datex.org/terms#AlertCMethod4PrimaryPointLocation"></see></summary>
    let AlertCMethod4PrimaryPointLocation = _prefix "AlertCMethod4PrimaryPointLocation"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCMethod4SecondaryPointLocation"></see>
    /// </summary>
    let alertCMethod4SecondaryPointLocation =
        _prefix "alertCMethod4SecondaryPointLocation"

    /// <summary>
    /// The point (called Secondary point) which is at the upstream end of a linear road section. The point is specified by a reference to a point in a pre-defined Alert-C location table plus a non-negative offset distance.
    /// <see href="http://vocab.datex.org/terms#AlertCMethod4SecondaryPointLocation"></see></summary>
    let AlertCMethod4SecondaryPointLocation =
        _prefix "AlertCMethod4SecondaryPointLocation"

    /// <summary>
    /// A single point on the road network defined by reference to a point in a pre-defined ALERT-C location table plus an offset distance and which has an associated direction of traffic flow.
    /// <see href="http://vocab.datex.org/terms#AlertCMethod4Point"></see></summary>
    let AlertCMethod4Point = _prefix "AlertCMethod4Point"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCMethod4PointExtension"></see>
    /// </summary>
    let alertCMethod4PointExtension = _prefix "alertCMethod4PointExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCMethod4PrimaryPointLocationExtension"></see>
    /// </summary>
    let alertCMethod4PrimaryPointLocationExtension =
        _prefix "alertCMethod4PrimaryPointLocationExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#offsetDistance"></see>
    /// </summary>
    let offsetDistance = _prefix "offsetDistance"
    /// <summary>
    /// The non negative offset distance from the ALERT-C referenced point to the actual point.
    /// <see href="http://vocab.datex.org/terms#OffsetDistance"></see></summary>
    let OffsetDistance = _prefix "OffsetDistance"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCMethod4SecondaryPointLocationExtension"></see>
    /// </summary>
    let alertCMethod4SecondaryPointLocationExtension =
        _prefix "alertCMethod4SecondaryPointLocationExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCPointExtension"></see>
    /// </summary>
    let alertCPointExtension = _prefix "alertCPointExtension"
    /// <summary>
    /// Indicates whether the identified animals are dead (immobile) or alive (potentially mobile).
    /// <see href="http://vocab.datex.org/terms#alive"></see></summary>
    let alive = _prefix "alive"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#animalPresenceObstructionExtension"></see>
    /// </summary>
    let animalPresenceObstructionExtension =
        _prefix "animalPresenceObstructionExtension"

    /// <summary>
    /// Indicates the nature of animals present on or near the roadway.
    /// <see href="http://vocab.datex.org/terms#animalPresenceType"></see></summary>
    let animalPresenceType = _prefix "animalPresenceType"
    /// <summary>
    /// A measured or calculated value of the application rate of a substance.
    /// <see href="http://vocab.datex.org/terms#ApplicationRateValue"></see></summary>
    let ApplicationRateValue = _prefix "ApplicationRateValue"
    /// <summary>
    /// A value of the rate of application of a substance expressed in kilogrammes per square metre.
    /// <see href="http://vocab.datex.org/terms#applicationRate"></see></summary>
    let applicationRate = _prefix "applicationRate"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#applicationRateValueExtension"></see>
    /// </summary>
    let applicationRateValueExtension = _prefix "applicationRateValueExtension"
    /// <summary>
    /// A data value of something that can be measured or calculated. Any provided meta-data values specified in the attributes override any specified generic characteristics such as defined for a specific measurement in the MeasurementSiteTable.
    /// <see href="http://vocab.datex.org/terms#DataValue"></see></summary>
    let DataValue = _prefix "DataValue"
    /// <summary>
    /// A geographic or geometric defined area which may be qualified by height information to provide additional geospatial discrimination (e.g. for snow in an area but only above a certain altitude).
    /// <see href="http://vocab.datex.org/terms#Area"></see></summary>
    let Area = _prefix "Area"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCArea"></see>
    /// </summary>
    let alertCArea = _prefix "alertCArea"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#areaExtension"></see>
    /// </summary>
    let areaExtension = _prefix "areaExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_AreaExtensionType"></see>
    /// </summary>
    let _AreaExtensionType = _prefix "_AreaExtensionType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegAreaLocation"></see>
    /// </summary>
    let tpegAreaLocation = _prefix "tpegAreaLocation"
    /// <summary>
    /// A geographic or geometric area defined by a TPEG-Loc structure which may include height information for additional geospatial discrimination.
    /// <see href="http://vocab.datex.org/terms#TpegAreaLocation"></see></summary>
    let TpegAreaLocation = _prefix "TpegAreaLocation"
    /// <summary>
    /// The specification of a location either on a network (as a point or a linear location) or as an area. This may be provided in one or more referencing systems.
    /// <see href="http://vocab.datex.org/terms#Location"></see></summary>
    let Location = _prefix "Location"
    /// <summary>
    /// The specification of the destination of a defined route or itinerary which is an area.
    /// <see href="http://vocab.datex.org/terms#AreaDestination"></see></summary>
    let AreaDestination = _prefix "AreaDestination"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#area"></see>
    /// </summary>
    let area = _prefix "area"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#areaDestinationExtension"></see>
    /// </summary>
    let areaDestinationExtension = _prefix "areaDestinationExtension"
    /// <summary>
    /// The specification a destination. This may be either a point location or an area location.
    /// <see href="http://vocab.datex.org/terms#Destination"></see></summary>
    let Destination = _prefix "Destination"
    /// <summary>
    /// Extension class for area used in parking publication extension.
    /// <see href="http://vocab.datex.org/terms#AreaExtended"></see></summary>
    let AreaExtended = _prefix "AreaExtended"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#namedArea"></see>
    /// </summary>
    let namedArea = _prefix "namedArea"
    /// <summary>
    /// An area defined by a name and/or in terms of known boundaries, such as country or county boundaries or allocated control area of particular authority. The attributes do not form a union; instead, the smallest intersection forms the resulting area.
    /// <see href="http://vocab.datex.org/terms#NamedArea"></see></summary>
    let NamedArea = _prefix "NamedArea"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#polygonArea"></see>
    /// </summary>
    let polygonArea = _prefix "polygonArea"
    /// <summary>
    /// defines points for a closed polygon-shape describing the area
    /// <see href="http://vocab.datex.org/terms#PolygonArea"></see></summary>
    let PolygonArea = _prefix "PolygonArea"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#authorityOperationExtension"></see>
    /// </summary>
    let authorityOperationExtension = _prefix "authorityOperationExtension"
    /// <summary>
    /// Type of authority initiated operation or activity that could disrupt traffic.
    /// <see href="http://vocab.datex.org/terms#authorityOperationType"></see></summary>
    let authorityOperationType = _prefix "authorityOperationType"
    /// <summary>
    /// A measured or calculated value of the flow rate of vehicle axles.
    /// <see href="http://vocab.datex.org/terms#AxleFlowValue"></see></summary>
    let AxleFlowValue = _prefix "AxleFlowValue"
    /// <summary>
    /// A value of the flow rate of vehicle axles expressed in axles per hour.
    /// <see href="http://vocab.datex.org/terms#axleFlowRate"></see></summary>
    let axleFlowRate = _prefix "axleFlowRate"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#axleFlowValueExtension"></see>
    /// </summary>
    let axleFlowValueExtension = _prefix "axleFlowValueExtension"
    /// <summary>
    /// The spacing details between the axle sets of an individual vehicle numbered from the front to the back of the vehicle.
    /// <see href="http://vocab.datex.org/terms#AxleSpacing"></see></summary>
    let AxleSpacing = _prefix "AxleSpacing"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#axleSpacing"></see>
    /// </summary>
    let axleSpacing = _prefix "axleSpacing"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#axleSpacingExtension"></see>
    /// </summary>
    let axleSpacingExtension = _prefix "axleSpacingExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#axleSpacingSequenceIdentifier"></see>
    /// </summary>
    let axleSpacingSequenceIdentifier = _prefix "axleSpacingSequenceIdentifier"
    /// <summary>
    /// The weight details of a specific axle on the vehicle.
    /// <see href="http://vocab.datex.org/terms#AxleWeight"></see></summary>
    let AxleWeight = _prefix "AxleWeight"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#axlePositionIdentifier"></see>
    /// </summary>
    let axlePositionIdentifier = _prefix "axlePositionIdentifier"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#axleWeight"></see>
    /// </summary>
    let axleWeight = _prefix "axleWeight"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#axleWeightExtension"></see>
    /// </summary>
    let axleWeightExtension = _prefix "axleWeightExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maximumPermittedAxleWeight"></see>
    /// </summary>
    let maximumPermittedAxleWeight = _prefix "maximumPermittedAxleWeight"
    /// <summary>
    /// Data that is either measured or calculated (elaborated) at the same time or over the same time period.
    /// <see href="http://vocab.datex.org/terms#BasicData"></see></summary>
    let BasicData = _prefix "BasicData"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementOrCalculatedTimePrecision"></see>
    /// </summary>
    let measurementOrCalculatedTimePrecision =
        _prefix "measurementOrCalculatedTimePrecision"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#basicDataExtension"></see>
    /// </summary>
    let basicDataExtension = _prefix "basicDataExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementOrCalculationPeriod"></see>
    /// </summary>
    let measurementOrCalculationPeriod = _prefix "measurementOrCalculationPeriod"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementOrCalculationTime"></see>
    /// </summary>
    let measurementOrCalculationTime = _prefix "measurementOrCalculationTime"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pertinentLocation"></see>
    /// </summary>
    let pertinentLocation = _prefix "pertinentLocation"
    /// <summary>
    /// One or more physically separate locations. Multiple locations may be related, as in an itinerary (or route), or may be unrelated. It is not for identifying the same physical location using different Location objects for different referencing systems.
    /// <see href="http://vocab.datex.org/terms#GroupOfLocations"></see></summary>
    let GroupOfLocations = _prefix "GroupOfLocations"
    /// <summary>
    /// Provides information on the status of one or more car parks.
    /// <see href="http://vocab.datex.org/terms#CarParks"></see></summary>
    let CarParks = _prefix "CarParks"
    /// <summary>
    /// The configuration/layout of a car park.
    /// <see href="http://vocab.datex.org/terms#carParkConfiguration"></see></summary>
    let carParkConfiguration = _prefix "carParkConfiguration"
    /// <summary>
    /// The identity of one or a group of car parks.
    /// <see href="http://vocab.datex.org/terms#carParkIdentity"></see></summary>
    let carParkIdentity = _prefix "carParkIdentity"
    /// <summary>
    /// The percentage value of car parking spaces occupied.
    /// <see href="http://vocab.datex.org/terms#carParkOccupancy"></see></summary>
    let carParkOccupancy = _prefix "carParkOccupancy"
    /// <summary>
    /// Indicates the status of one or more specified car parks.
    /// <see href="http://vocab.datex.org/terms#carParkStatus"></see></summary>
    let carParkStatus = _prefix "carParkStatus"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#carParksExtension"></see>
    /// </summary>
    let carParksExtension = _prefix "carParksExtension"
    /// <summary>
    /// The rate at which vehicles are exiting the car park.
    /// <see href="http://vocab.datex.org/terms#exitRate"></see></summary>
    let exitRate = _prefix "exitRate"
    /// <summary>
    /// The rate at which vehicles are entering the car park.
    /// <see href="http://vocab.datex.org/terms#fillRate"></see></summary>
    let fillRate = _prefix "fillRate"
    /// <summary>
    /// Indicates the number of vacant parking spaces available in a specified parking area.
    /// <see href="http://vocab.datex.org/terms#numberOfVacantParkingSpaces"></see></summary>
    let numberOfVacantParkingSpaces = _prefix "numberOfVacantParkingSpaces"
    /// <summary>
    /// Number of currently occupied spaces.
    /// <see href="http://vocab.datex.org/terms#occupiedSpaces"></see></summary>
    let occupiedSpaces = _prefix "occupiedSpaces"
    /// <summary>
    /// The current queuing time (duration) for entering the car park.
    /// <see href="http://vocab.datex.org/terms#queuingTime"></see></summary>
    let queuingTime = _prefix "queuingTime"
    /// <summary>
    /// Total number of car parking spaces.
    /// <see href="http://vocab.datex.org/terms#totalCapacity"></see></summary>
    let totalCapacity = _prefix "totalCapacity"
    /// <summary>
    /// Information about an event which is not on the road, but which may influence the behaviour of drivers and hence the characteristics of the traffic flow.
    /// <see href="http://vocab.datex.org/terms#NonRoadEventInformation"></see></summary>
    let NonRoadEventInformation = _prefix "NonRoadEventInformation"
    /// <summary>
    /// Identification of the supplier's data catalogue in a data exchange context.
    /// <see href="http://vocab.datex.org/terms#CatalogueReference"></see></summary>
    let CatalogueReference = _prefix "CatalogueReference"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#catalogueReferenceExtension"></see>
    /// </summary>
    let catalogueReferenceExtension = _prefix "catalogueReferenceExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#keyCatalogueReference"></see>
    /// </summary>
    let keyCatalogueReference = _prefix "keyCatalogueReference"
    /// <summary>
    /// Contains details of the cause of a record within a situation
    /// <see href="http://vocab.datex.org/terms#Cause"></see></summary>
    let Cause = _prefix "Cause"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#causeExtension"></see>
    /// </summary>
    let causeExtension = _prefix "causeExtension"
    /// <summary>
    /// A particular charge for a specified interval belonging a charge band.
    /// <see href="http://vocab.datex.org/terms#Charge"></see></summary>
    let Charge = _prefix "Charge"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#charge"></see>
    /// </summary>
    let charge = _prefix "charge"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#chargeExtension"></see>
    /// </summary>
    let chargeExtension = _prefix "chargeExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#chargeInterval"></see>
    /// </summary>
    let chargeInterval = _prefix "chargeInterval"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#chargeOrderIndex"></see>
    /// </summary>
    let chargeOrderIndex = _prefix "chargeOrderIndex"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#chargeType"></see>
    /// </summary>
    let chargeType = _prefix "chargeType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#chargeTypeDescription"></see>
    /// </summary>
    let chargeTypeDescription = _prefix "chargeTypeDescription"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maxIterationsOfCharge"></see>
    /// </summary>
    let maxIterationsOfCharge = _prefix "maxIterationsOfCharge"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#minIterationsOfCharge"></see>
    /// </summary>
    let minIterationsOfCharge = _prefix "minIterationsOfCharge"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#timePeriodOfDay"></see>
    /// </summary>
    let timePeriodOfDay = _prefix "timePeriodOfDay"
    /// <summary>
    /// Specification of a continuous period of time within a 24 hour period.
    /// <see href="http://vocab.datex.org/terms#TimePeriodOfDay"></see></summary>
    let TimePeriodOfDay = _prefix "TimePeriodOfDay"
    /// <summary>
    /// A charge band in accordance with the specified conditions, possibly up to a maximum duration, during a specified period and for a vehicle of specified characteristics (in case of parking).
    /// <see href="http://vocab.datex.org/terms#ChargeBand"></see></summary>
    let ChargeBand = _prefix "ChargeBand"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#version"></see>
    /// </summary>
    let version = _prefix "version"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#id"></see>
    /// </summary>
    let id = _prefix "id"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#applicableForPeriod"></see>
    /// </summary>
    let applicableForPeriod = _prefix "applicableForPeriod"
    /// <summary>
    /// A continuous or discontinuous period of validity defined by overall bounding start and end times and the possible intersection of valid periods (potentially recurring) with the complement of exception periods (also potentially recurring).
    /// <see href="http://vocab.datex.org/terms#OverallPeriod"></see></summary>
    let OverallPeriod = _prefix "OverallPeriod"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#applicableForUser"></see>
    /// </summary>
    let applicableForUser = _prefix "applicableForUser"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#applicableForVehicles"></see>
    /// </summary>
    let applicableForVehicles = _prefix "applicableForVehicles"
    /// <summary>
    /// The characteristics of a vehicle, e.g. lorry of gross weight greater than 30 tonnes.
    /// <see href="http://vocab.datex.org/terms#VehicleCharacteristics"></see></summary>
    let VehicleCharacteristics = _prefix "VehicleCharacteristics"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#chargeBandExtension"></see>
    /// </summary>
    let chargeBandExtension = _prefix "chargeBandExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#chargeBandName"></see>
    /// </summary>
    let chargeBandName = _prefix "chargeBandName"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#chargeCurrency"></see>
    /// </summary>
    let chargeCurrency = _prefix "chargeCurrency"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maximumDuration"></see>
    /// </summary>
    let maximumDuration = _prefix "maximumDuration"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingPermit"></see>
    /// </summary>
    let parkingPermit = _prefix "parkingPermit"
    /// <summary>
    /// A permission for parking.
    /// <see href="http://vocab.datex.org/terms#ParkingPermit"></see></summary>
    let ParkingPermit = _prefix "ParkingPermit"
    /// <summary>
    /// Using (a) prior defined charge band(s), identified by its reference.
    /// <see href="http://vocab.datex.org/terms#ChargeBandByReference"></see></summary>
    let ChargeBandByReference = _prefix "ChargeBandByReference"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#chargeBandByReferenceExtension"></see>
    /// </summary>
    let chargeBandByReferenceExtension = _prefix "chargeBandByReferenceExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#chargeBandReference"></see>
    /// </summary>
    let chargeBandReference = _prefix "chargeBandReference"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_ChargeBandVersionedReference"></see>
    /// </summary>
    let _ChargeBandVersionedReference = _prefix "_ChargeBandVersionedReference"
    /// <summary>
    /// A free text comment with an optional date/time stamp that can be used by the operator to convey un-coded observations/information.
    /// <see href="http://vocab.datex.org/terms#Comment"></see></summary>
    let Comment = _prefix "Comment"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#comment"></see>
    /// </summary>
    let comment = _prefix "comment"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#commentDateTime"></see>
    /// </summary>
    let commentDateTime = _prefix "commentDateTime"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#commentExtension"></see>
    /// </summary>
    let commentExtension = _prefix "commentExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#commentType"></see>
    /// </summary>
    let commentType = _prefix "commentType"
    /// <summary>
    /// A measured or calculated value of the concentration of vehicles on a unit stretch of road in a given direction.
    /// <see href="http://vocab.datex.org/terms#ConcentrationOfVehiclesValue"></see></summary>
    let ConcentrationOfVehiclesValue = _prefix "ConcentrationOfVehiclesValue"
    /// <summary>
    /// A value of traffic density expressed in the number of vehicles per kilometre of road.
    /// <see href="http://vocab.datex.org/terms#concentrationOfVehicles"></see></summary>
    let concentrationOfVehicles = _prefix "concentrationOfVehicles"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#concentrationOfVehiclesValueExtension"></see>
    /// </summary>
    let concentrationOfVehiclesValueExtension =
        _prefix "concentrationOfVehiclesValueExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#conditionsExtension"></see>
    /// </summary>
    let conditionsExtension = _prefix "conditionsExtension"
    /// <summary>
    /// Description of the driving conditions at the specified location.
    /// <see href="http://vocab.datex.org/terms#drivingConditionType"></see></summary>
    let drivingConditionType = _prefix "drivingConditionType"
    /// <summary>
    /// Roadworks involving the construction of new infrastructure.
    /// <see href="http://vocab.datex.org/terms#ConstructionWorks"></see></summary>
    let ConstructionWorks = _prefix "ConstructionWorks"
    /// <summary>
    /// The type of construction work being performed.
    /// <see href="http://vocab.datex.org/terms#constructionWorkType"></see></summary>
    let constructionWorkType = _prefix "constructionWorkType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#constructionWorksExtension"></see>
    /// </summary>
    let constructionWorksExtension = _prefix "constructionWorksExtension"
    /// <summary>
    /// Highway maintenance, installation and construction activities that may potentially affect traffic operations.
    /// <see href="http://vocab.datex.org/terms#Roadworks"></see></summary>
    let Roadworks = _prefix "Roadworks"
    /// <summary>
    /// Address and contact information about some person, service or the parking site, provided in detail or via reference.
    /// <see href="http://vocab.datex.org/terms#Contact"></see></summary>
    let Contact = _prefix "Contact"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#contactExtension"></see>
    /// </summary>
    let contactExtension = _prefix "contactExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#contactNotDefined"></see>
    /// </summary>
    let contactNotDefined = _prefix "contactNotDefined"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#contactUnknown"></see>
    /// </summary>
    let contactUnknown = _prefix "contactUnknown"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#validityOfContact"></see>
    /// </summary>
    let validityOfContact = _prefix "validityOfContact"
    /// <summary>
    /// Contact information that is addressed via a reference.
    /// <see href="http://vocab.datex.org/terms#ContactByReference"></see></summary>
    let ContactByReference = _prefix "ContactByReference"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#contactByReferenceExtension"></see>
    /// </summary>
    let contactByReferenceExtension = _prefix "contactByReferenceExtension"
    /// <summary>
    /// Contact information provided by a reference.
    /// <see href="http://vocab.datex.org/terms#contactReference"></see></summary>
    let contactReference = _prefix "contactReference"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_ContactDetailsVersionedReference"></see>
    /// </summary>
    let _ContactDetailsVersionedReference = _prefix "_ContactDetailsVersionedReference"
    /// <summary>
    /// Details for some person, service or the parking site itself, especially address information.
    /// <see href="http://vocab.datex.org/terms#ContactDetails"></see></summary>
    let ContactDetails = _prefix "ContactDetails"
    /// <summary>
    /// Specifies if the availability is 24 hours a day. If omitted, this information is unknown or heterogeneous.
    /// <see href="http://vocab.datex.org/terms#available24hours"></see></summary>
    let available24hours = _prefix "available24hours"
    /// <summary>
    /// Complete address of the contact. Alternatively use the separate fields to describe the address.
    /// <see href="http://vocab.datex.org/terms#contactDetailsAddress"></see></summary>
    let contactDetailsAddress = _prefix "contactDetailsAddress"
    /// <summary>
    /// City of the contact.
    /// <see href="http://vocab.datex.org/terms#contactDetailsCity"></see></summary>
    let contactDetailsCity = _prefix "contactDetailsCity"
    /// <summary>
    /// E-Mail address of the contact.
    /// <see href="http://vocab.datex.org/terms#contactDetailsEMail"></see></summary>
    let contactDetailsEMail = _prefix "contactDetailsEMail"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#contactDetailsExtension"></see>
    /// </summary>
    let contactDetailsExtension = _prefix "contactDetailsExtension"
    /// <summary>
    /// Fax of the contact.
    /// <see href="http://vocab.datex.org/terms#contactDetailsFax"></see></summary>
    let contactDetailsFax = _prefix "contactDetailsFax"
    /// <summary>
    /// House number of the contact. Supports a multiplicity up to two, to specify lower and upper numbers.
    /// <see href="http://vocab.datex.org/terms#contactDetailsHouseNumber"></see></summary>
    let contactDetailsHouseNumber = _prefix "contactDetailsHouseNumber"
    /// <summary>
    /// Language(s) this contact is able to speak resp. understand.
    /// <see href="http://vocab.datex.org/terms#contactDetailsLanguage"></see></summary>
    let contactDetailsLanguage = _prefix "contactDetailsLanguage"
    /// <summary>
    /// Url to define a logo of this contact.
    /// <see href="http://vocab.datex.org/terms#contactDetailsLogoUrl"></see></summary>
    let contactDetailsLogoUrl = _prefix "contactDetailsLogoUrl"
    /// <summary>
    /// Additional information relating to the contact.
    /// <see href="http://vocab.datex.org/terms#contactDetailsMoreInfo"></see></summary>
    let contactDetailsMoreInfo = _prefix "contactDetailsMoreInfo"
    /// <summary>
    /// Information if the contact in question is a private or public institution.
    /// <see href="http://vocab.datex.org/terms#contactDetailsOwnership"></see></summary>
    let contactDetailsOwnership = _prefix "contactDetailsOwnership"
    /// <summary>
    /// Postcode of the contact.
    /// <see href="http://vocab.datex.org/terms#contactDetailsPostcode"></see></summary>
    let contactDetailsPostcode = _prefix "contactDetailsPostcode"
    /// <summary>
    /// Specification of what service or equipment the contact is responsible for.
    /// <see href="http://vocab.datex.org/terms#contactDetailsResponsibility"></see></summary>
    let contactDetailsResponsibility = _prefix "contactDetailsResponsibility"
    /// <summary>
    /// Street of the contact.
    /// <see href="http://vocab.datex.org/terms#contactDetailsStreet"></see></summary>
    let contactDetailsStreet = _prefix "contactDetailsStreet"
    /// <summary>
    /// Telephone Number of contact.
    /// <see href="http://vocab.datex.org/terms#contactDetailsTelephoneNumber"></see></summary>
    let contactDetailsTelephoneNumber = _prefix "contactDetailsTelephoneNumber"
    /// <summary>
    /// Name of the organisation or service. Do not use this attribute in combination with role "parkingSiteAddress".
    /// <see href="http://vocab.datex.org/terms#contactOrganisationName"></see></summary>
    let contactOrganisationName = _prefix "contactOrganisationName"
    /// <summary>
    /// First name of the contact person.
    /// <see href="http://vocab.datex.org/terms#contactPersonFirstName"></see></summary>
    let contactPersonFirstName = _prefix "contactPersonFirstName"
    /// <summary>
    /// Name of the contact person.
    /// <see href="http://vocab.datex.org/terms#contactPersonName"></see></summary>
    let contactPersonName = _prefix "contactPersonName"
    /// <summary>
    /// The position of the contact person.
    /// <see href="http://vocab.datex.org/terms#contactPersonPosition"></see></summary>
    let contactPersonPosition = _prefix "contactPersonPosition"
    /// <summary>
    /// ISO 3166-1 two character country code.
    /// <see href="http://vocab.datex.org/terms#country"></see></summary>
    let country = _prefix "country"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#groupOfLocations"></see>
    /// </summary>
    let groupOfLocations = _prefix "groupOfLocations"
    /// <summary>
    /// Indication, whether the contact accepted publishing its contact information.
    /// <see href="http://vocab.datex.org/terms#publishingAgreement"></see></summary>
    let publishingAgreement = _prefix "publishingAgreement"
    /// <summary>
    /// A Uniform Resource Locator (URL) address pointing to a resource available on the Internet from where further relevant information may be obtained.
    /// <see href="http://vocab.datex.org/terms#urlLinkAddress"></see></summary>
    let urlLinkAddress = _prefix "urlLinkAddress"
    /// <summary>
    /// The DATEX II logical model comprising exchange, content payload and management sub-models.
    /// <see href="http://vocab.datex.org/terms#D2LogicalModel"></see></summary>
    let D2LogicalModel = _prefix "D2LogicalModel"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#modelBaseVersion"></see>
    /// </summary>
    let modelBaseVersion = _prefix "modelBaseVersion"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#d2LogicalModelExtension"></see>
    /// </summary>
    let d2LogicalModelExtension = _prefix "d2LogicalModelExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#exchange"></see>
    /// </summary>
    let exchange = _prefix "exchange"
    /// <summary>
    /// Details associated with the management of the exchange between the supplier and the client.
    /// <see href="http://vocab.datex.org/terms#Exchange"></see></summary>
    let Exchange = _prefix "Exchange"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#payloadPublication"></see>
    /// </summary>
    let payloadPublication = _prefix "payloadPublication"
    /// <summary>
    /// A payload publication of traffic related information or associated management information created at a specific point in time that can be exchanged via a DATEX II interface.
    /// <see href="http://vocab.datex.org/terms#PayloadPublication"></see></summary>
    let PayloadPublication = _prefix "PayloadPublication"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#supplierCalculatedDataQuality"></see>
    /// </summary>
    let supplierCalculatedDataQuality = _prefix "supplierCalculatedDataQuality"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#numberOfInputValuesUsed"></see>
    /// </summary>
    let numberOfInputValuesUsed = _prefix "numberOfInputValuesUsed"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#smoothingFactor"></see>
    /// </summary>
    let smoothingFactor = _prefix "smoothingFactor"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#accuracy"></see>
    /// </summary>
    let accuracy = _prefix "accuracy"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#standardDeviation"></see>
    /// </summary>
    let standardDeviation = _prefix "standardDeviation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#dataError"></see>
    /// </summary>
    let dataError = _prefix "dataError"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#dataValueExtension"></see>
    /// </summary>
    let dataValueExtension = _prefix "dataValueExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#reasonForDataError"></see>
    /// </summary>
    let reasonForDataError = _prefix "reasonForDataError"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#computationalMethod"></see>
    /// </summary>
    let computationalMethod = _prefix "computationalMethod"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#numberOfIncompleteInputs"></see>
    /// </summary>
    let numberOfIncompleteInputs = _prefix "numberOfIncompleteInputs"
    /// <summary>
    /// A measured or calculated value of an instance in time.
    /// <see href="http://vocab.datex.org/terms#DateTimeValue"></see></summary>
    let DateTimeValue = _prefix "DateTimeValue"
    /// <summary>
    /// A time stamp defining an instance in time.
    /// <see href="http://vocab.datex.org/terms#dateTime"></see></summary>
    let dateTime = _prefix "dateTime"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#dateTimeValueExtension"></see>
    /// </summary>
    let dateTimeValueExtension = _prefix "dateTimeValueExtension"
    /// <summary>
    /// Specification of periods defined by the intersection of days, weeks and months.
    /// <see href="http://vocab.datex.org/terms#DayWeekMonth"></see></summary>
    let DayWeekMonth = _prefix "DayWeekMonth"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#applicableDay"></see>
    /// </summary>
    let applicableDay = _prefix "applicableDay"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#applicableMonth"></see>
    /// </summary>
    let applicableMonth = _prefix "applicableMonth"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#applicableWeek"></see>
    /// </summary>
    let applicableWeek = _prefix "applicableWeek"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#dayWeekMonthExtension"></see>
    /// </summary>
    let dayWeekMonthExtension = _prefix "dayWeekMonthExtension"
    /// <summary>
    /// Reference to an access of any type (vehicles, pedestrian, ...).
    /// <see href="http://vocab.datex.org/terms#DedicatedAccess"></see></summary>
    let DedicatedAccess = _prefix "DedicatedAccess"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#dedicatedAccess"></see>
    /// </summary>
    let dedicatedAccess = _prefix "dedicatedAccess"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_ParkingAccessReference"></see>
    /// </summary>
    let _ParkingAccessReference = _prefix "_ParkingAccessReference"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#dedicatedAccessExtension"></see>
    /// </summary>
    let dedicatedAccessExtension = _prefix "dedicatedAccessExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#distanceFromParkingSpace"></see>
    /// </summary>
    let distanceFromParkingSpace = _prefix "distanceFromParkingSpace"
    /// <summary>
    /// The details of the delays being caused by the situation element defined in the situation record. It is recommended to only use one of the optional attributes to avoid confusion.
    /// <see href="http://vocab.datex.org/terms#Delays"></see></summary>
    let Delays = _prefix "Delays"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#delayBand"></see>
    /// </summary>
    let delayBand = _prefix "delayBand"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#delayTimeValue"></see>
    /// </summary>
    let delayTimeValue = _prefix "delayTimeValue"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#delaysExtension"></see>
    /// </summary>
    let delaysExtension = _prefix "delaysExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#delaysType"></see>
    /// </summary>
    let delaysType = _prefix "delaysType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#destinationExtension"></see>
    /// </summary>
    let destinationExtension = _prefix "destinationExtension"
    /// <summary>
    /// A component that provides dimension information. The product of width and height must not be necessarily be the square footage (e.g. in multi-storey buildings or when some zones are not part of the square footage).
    /// <see href="http://vocab.datex.org/terms#Dimension"></see></summary>
    let Dimension = _prefix "Dimension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#dimensionExtension"></see>
    /// </summary>
    let dimensionExtension = _prefix "dimensionExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#dimensionHeight"></see>
    /// </summary>
    let dimensionHeight = _prefix "dimensionHeight"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#dimensionLength"></see>
    /// </summary>
    let dimensionLength = _prefix "dimensionLength"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#dimensionUsableArea"></see>
    /// </summary>
    let dimensionUsableArea = _prefix "dimensionUsableArea"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#dimensionWidth"></see>
    /// </summary>
    let dimensionWidth = _prefix "dimensionWidth"
    /// <summary>
    /// A measured or calculated value of direction as a bearing.
    /// <see href="http://vocab.datex.org/terms#DirectionBearingValue"></see></summary>
    let DirectionBearingValue = _prefix "DirectionBearingValue"
    /// <summary>
    /// A value of direction expressed in terms of a bearing measured in whole degrees. Unless otherwise specified the reference direction corresponding to 0 degrees is North.
    /// <see href="http://vocab.datex.org/terms#directionBearing"></see></summary>
    let directionBearing = _prefix "directionBearing"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#directionBearingValueExtension"></see>
    /// </summary>
    let directionBearingValueExtension = _prefix "directionBearingValueExtension"
    /// <summary>
    /// A measured or calculated value of direction as a point of the compass.
    /// <see href="http://vocab.datex.org/terms#DirectionCompassValue"></see></summary>
    let DirectionCompassValue = _prefix "DirectionCompassValue"
    /// <summary>
    /// A value of direction expressed in terms of points of the compass.
    /// <see href="http://vocab.datex.org/terms#directionCompass"></see></summary>
    let directionCompass = _prefix "directionCompass"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#directionCompassValueExtension"></see>
    /// </summary>
    let directionCompassValueExtension = _prefix "directionCompassValueExtension"
    /// <summary>
    /// Distance of a point along a linear element either measured from the start node or a defined referent on that linear element, where the start node is relative to the element definition rather than the direction of traffic flow.
    /// <see href="http://vocab.datex.org/terms#DistanceAlongLinearElement"></see></summary>
    let DistanceAlongLinearElement = _prefix "DistanceAlongLinearElement"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#distanceAlongLinearElementExtension"></see>
    /// </summary>
    let distanceAlongLinearElementExtension =
        _prefix "distanceAlongLinearElementExtension"

    /// <summary>
    /// Distance of a point along a linear element measured from a "from referent" on the linear element, in the sense relative to the linear element definition rather than the direction of traffic flow or optionally towards a "towards referent".
    /// <see href="http://vocab.datex.org/terms#DistanceFromLinearElementReferent"></see></summary>
    let DistanceFromLinearElementReferent = _prefix "DistanceFromLinearElementReferent"
    /// <summary>
    /// A measure of distance along a linear element.
    /// <see href="http://vocab.datex.org/terms#distanceAlong"></see></summary>
    let distanceAlong = _prefix "distanceAlong"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#distanceFromLinearElementReferentExtension"></see>
    /// </summary>
    let distanceFromLinearElementReferentExtension =
        _prefix "distanceFromLinearElementReferentExtension"

    /// <summary>
    /// A known location along the linear element from which the distanceAlong is measured, termed the "fromReferent" in ISO 19148.
    /// <see href="http://vocab.datex.org/terms#fromReferent"></see></summary>
    let fromReferent = _prefix "fromReferent"
    /// <summary>
    /// A referent on a linear object that has a known location such as a node, a reference marker (e.g. a markerpost), an intersection etc.
    /// <see href="http://vocab.datex.org/terms#Referent"></see></summary>
    let Referent = _prefix "Referent"
    /// <summary>
    /// A known location along the linear element towards which the distanceAlong is measured, termed the "towardsReferent" in ISO 19148.
    /// <see href="http://vocab.datex.org/terms#towardsReferent"></see></summary>
    let towardsReferent = _prefix "towardsReferent"
    /// <summary>
    /// Distance of a point along a linear element measured from the start node of the linear element, where start node is relative to the element definition rather than the direction of traffic flow.
    /// <see href="http://vocab.datex.org/terms#DistanceFromLinearElementStart"></see></summary>
    let DistanceFromLinearElementStart = _prefix "DistanceFromLinearElementStart"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#distanceFromLinearElementStartExtension"></see>
    /// </summary>
    let distanceFromLinearElementStartExtension =
        _prefix "distanceFromLinearElementStartExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#disturbanceActivityExtension"></see>
    /// </summary>
    let disturbanceActivityExtension = _prefix "disturbanceActivityExtension"
    /// <summary>
    /// Includes all situations of a public disorder type or of an alert type, with potential to disrupt traffic.
    /// <see href="http://vocab.datex.org/terms#disturbanceActivityType"></see></summary>
    let disturbanceActivityType = _prefix "disturbanceActivityType"
    /// <summary>
    /// A measured or calculated value of a period of time.
    /// <see href="http://vocab.datex.org/terms#DurationValue"></see></summary>
    let DurationValue = _prefix "DurationValue"
    /// <summary>
    /// A period of time expressed in seconds.
    /// <see href="http://vocab.datex.org/terms#duration"></see></summary>
    let duration = _prefix "duration"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#durationValueExtension"></see>
    /// </summary>
    let durationValueExtension = _prefix "durationValueExtension"
    /// <summary>
    /// An instance of data which is derived/computed from one or more measurements over a period of time. It may be a current value or a forecast value predicted from historical measurements.
    /// <see href="http://vocab.datex.org/terms#ElaboratedData"></see></summary>
    let ElaboratedData = _prefix "ElaboratedData"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#basicData"></see>
    /// </summary>
    let basicData = _prefix "basicData"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#elaboratedDataExtension"></see>
    /// </summary>
    let elaboratedDataExtension = _prefix "elaboratedDataExtension"
    /// <summary>
    /// The type of fault which is being reported for the specified elaborated data.
    /// <see href="http://vocab.datex.org/terms#elaboratedDataFault"></see></summary>
    let elaboratedDataFault = _prefix "elaboratedDataFault"
    /// <summary>
    /// Details of a fault which is being reported for the related elaborated data.
    /// <see href="http://vocab.datex.org/terms#ElaboratedDataFault"></see></summary>
    let ElaboratedDataFault = _prefix "ElaboratedDataFault"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#forecast"></see>
    /// </summary>
    let forecast = _prefix "forecast"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#source"></see>
    /// </summary>
    let source = _prefix "source"
    /// <summary>
    /// Details of the source from which the information was obtained.
    /// <see href="http://vocab.datex.org/terms#Source"></see></summary>
    let Source = _prefix "Source"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#validity"></see>
    /// </summary>
    let validity = _prefix "validity"
    /// <summary>
    /// Specification of validity, either explicitly or by a validity time period specification which may be discontinuous.
    /// <see href="http://vocab.datex.org/terms#Validity"></see></summary>
    let Validity = _prefix "Validity"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#elaboratedDataFaultExtension"></see>
    /// </summary>
    let elaboratedDataFaultExtension = _prefix "elaboratedDataFaultExtension"
    /// <summary>
    /// Information about a fault relating to a specific piece of equipment or process.
    /// <see href="http://vocab.datex.org/terms#Fault"></see></summary>
    let Fault = _prefix "Fault"
    /// <summary>
    /// A publication containing one or more elaborated data sets.
    /// <see href="http://vocab.datex.org/terms#ElaboratedDataPublication"></see></summary>
    let ElaboratedDataPublication = _prefix "ElaboratedDataPublication"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#elaboratedData"></see>
    /// </summary>
    let elaboratedData = _prefix "elaboratedData"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#elaboratedDataPublicationExtension"></see>
    /// </summary>
    let elaboratedDataPublicationExtension =
        _prefix "elaboratedDataPublicationExtension"

    /// <summary>
    /// The default value for the publication of whether the elaborated data is a forecast (true = forecast).
    /// <see href="http://vocab.datex.org/terms#forecastDefault"></see></summary>
    let forecastDefault = _prefix "forecastDefault"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#headerInformation"></see>
    /// </summary>
    let headerInformation = _prefix "headerInformation"
    /// <summary>
    /// Management information relating to the data contained within a publication.
    /// <see href="http://vocab.datex.org/terms#HeaderInformation"></see></summary>
    let HeaderInformation = _prefix "HeaderInformation"
    /// <summary>
    /// The default value for the publication of the time elapsed between the beginning and the end of the sampling or measurement period. This item may differ from the unit attribute; e.g. an hourly flow can be estimated from a 5-minute measurement period.
    /// <see href="http://vocab.datex.org/terms#periodDefault"></see></summary>
    let periodDefault = _prefix "periodDefault"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#referenceSettings"></see>
    /// </summary>
    let referenceSettings = _prefix "referenceSettings"
    /// <summary>
    /// Specification of the default value for traffic status on a group of predefined locations on the road network. Only when traffic status differs from this value at a location in the group need a value be sent.
    /// <see href="http://vocab.datex.org/terms#ReferenceSettings"></see></summary>
    let ReferenceSettings = _prefix "ReferenceSettings"
    /// <summary>
    /// The default for the publication of the time at which the values have been computed/derived.
    /// <see href="http://vocab.datex.org/terms#timeDefault"></see></summary>
    let timeDefault = _prefix "timeDefault"
    /// <summary>
    /// Additional information for the equipment 'electricChargingStation'. This component refers to the number of charging stations specified in the attribute 'numberOfEquipmentOrServiceFacilities'.
    /// <see href="http://vocab.datex.org/terms#ElectricCharging"></see></summary>
    let ElectricCharging = _prefix "ElectricCharging"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#chargingStationConnectorType"></see>
    /// </summary>
    let chargingStationConnectorType = _prefix "chargingStationConnectorType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#chargingStationModelType"></see>
    /// </summary>
    let chargingStationModelType = _prefix "chargingStationModelType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#chargingStationUsageType"></see>
    /// </summary>
    let chargingStationUsageType = _prefix "chargingStationUsageType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#electricChargingExtension"></see>
    /// </summary>
    let electricChargingExtension = _prefix "electricChargingExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maximumCurrent"></see>
    /// </summary>
    let maximumCurrent = _prefix "maximumCurrent"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#numberOfChargingPoints"></see>
    /// </summary>
    let numberOfChargingPoints = _prefix "numberOfChargingPoints"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#voltage"></see>
    /// </summary>
    let voltage = _prefix "voltage"
    /// <summary>
    /// The depth of flooding or of snow on the road.
    /// <see href="http://vocab.datex.org/terms#depth"></see></summary>
    let depth = _prefix "depth"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#environmentalObstructionExtension"></see>
    /// </summary>
    let environmentalObstructionExtension = _prefix "environmentalObstructionExtension"
    /// <summary>
    /// Characterization of an obstruction on the road resulting from an environmental cause.
    /// <see href="http://vocab.datex.org/terms#environmentalObstructionType"></see></summary>
    let environmentalObstructionType = _prefix "environmentalObstructionType"
    /// <summary>
    /// One type of equipment, that is available on the parking site.
    /// <see href="http://vocab.datex.org/terms#Equipment"></see></summary>
    let Equipment = _prefix "Equipment"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#electricCharging"></see>
    /// </summary>
    let electricCharging = _prefix "electricCharging"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#equipmentExtension"></see>
    /// </summary>
    let equipmentExtension = _prefix "equipmentExtension"
    /// <summary>
    /// One type of equipment, that is available on the parking site.
    /// <see href="http://vocab.datex.org/terms#equipmentType"></see></summary>
    let equipmentType = _prefix "equipmentType"
    /// <summary>
    /// One type of equipment or additional service facility that is available at the parking site, parking space or group of parking spaces.
    /// <see href="http://vocab.datex.org/terms#ParkingEquipmentOrServiceFacility"></see></summary>
    let ParkingEquipmentOrServiceFacility = _prefix "ParkingEquipmentOrServiceFacility"
    /// <summary>
    /// Equipment or system which is faulty, malfunctioning or not in a fully operational state that may be of interest or concern to road operators and road users.
    /// <see href="http://vocab.datex.org/terms#EquipmentOrSystemFault"></see></summary>
    let EquipmentOrSystemFault = _prefix "EquipmentOrSystemFault"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#equipmentOrSystemFaultExtension"></see>
    /// </summary>
    let equipmentOrSystemFaultExtension = _prefix "equipmentOrSystemFaultExtension"
    /// <summary>
    /// Failure, malfunction or non operational condition of equipment or system.
    /// <see href="http://vocab.datex.org/terms#equipmentOrSystemFaultType"></see></summary>
    let equipmentOrSystemFaultType = _prefix "equipmentOrSystemFaultType"
    /// <summary>
    /// The type of equipment or system which is faulty, malfunctioning or not in a fully operational state.
    /// <see href="http://vocab.datex.org/terms#faultyEquipmentOrSystemType"></see></summary>
    let faultyEquipmentOrSystemType = _prefix "faultyEquipmentOrSystemType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#catalogueReference"></see>
    /// </summary>
    let catalogueReference = _prefix "catalogueReference"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#changedFlag"></see>
    /// </summary>
    let changedFlag = _prefix "changedFlag"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#clientIdentification"></see>
    /// </summary>
    let clientIdentification = _prefix "clientIdentification"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#deliveryBreak"></see>
    /// </summary>
    let deliveryBreak = _prefix "deliveryBreak"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#denyReason"></see>
    /// </summary>
    let denyReason = _prefix "denyReason"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#exchangeExtension"></see>
    /// </summary>
    let exchangeExtension = _prefix "exchangeExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#filterReference"></see>
    /// </summary>
    let filterReference = _prefix "filterReference"
    /// <summary>
    /// Details of a supplier's filter in a data exchange context.
    /// <see href="http://vocab.datex.org/terms#FilterReference"></see></summary>
    let FilterReference = _prefix "FilterReference"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#historicalStartDate"></see>
    /// </summary>
    let historicalStartDate = _prefix "historicalStartDate"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#historicalStopDate"></see>
    /// </summary>
    let historicalStopDate = _prefix "historicalStopDate"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#keepAlive"></see>
    /// </summary>
    let keepAlive = _prefix "keepAlive"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#requestType"></see>
    /// </summary>
    let requestType = _prefix "requestType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#response"></see>
    /// </summary>
    let response = _prefix "response"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#subscription"></see>
    /// </summary>
    let subscription = _prefix "subscription"
    /// <summary>
    /// This item contains all information relating to a customer subscription.
    /// <see href="http://vocab.datex.org/terms#Subscription"></see></summary>
    let Subscription = _prefix "Subscription"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#subscriptionReference"></see>
    /// </summary>
    let subscriptionReference = _prefix "subscriptionReference"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#supplierIdentification"></see>
    /// </summary>
    let supplierIdentification = _prefix "supplierIdentification"
    /// <summary>
    /// An identifier/name whose range is specific to the particular country.
    /// <see href="http://vocab.datex.org/terms#InternationalIdentifier"></see></summary>
    let InternationalIdentifier = _prefix "InternationalIdentifier"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#target"></see>
    /// </summary>
    let target = _prefix "target"
    /// <summary>
    /// The details of a DATEX II target client.
    /// <see href="http://vocab.datex.org/terms#Target"></see></summary>
    let Target = _prefix "Target"
    /// <summary>
    /// A location defined by reference to an external/other referencing system.
    /// <see href="http://vocab.datex.org/terms#ExternalReferencing"></see></summary>
    let ExternalReferencing = _prefix "ExternalReferencing"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#externalLocationCode"></see>
    /// </summary>
    let externalLocationCode = _prefix "externalLocationCode"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#externalReferencingExtension"></see>
    /// </summary>
    let externalReferencingExtension = _prefix "externalReferencingExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#externalReferencingSystem"></see>
    /// </summary>
    let externalReferencingSystem = _prefix "externalReferencingSystem"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#faultCreationTime"></see>
    /// </summary>
    let faultCreationTime = _prefix "faultCreationTime"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#faultDescription"></see>
    /// </summary>
    let faultDescription = _prefix "faultDescription"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#faultExtension"></see>
    /// </summary>
    let faultExtension = _prefix "faultExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#faultIdentifier"></see>
    /// </summary>
    let faultIdentifier = _prefix "faultIdentifier"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#faultLastUpdateTime"></see>
    /// </summary>
    let faultLastUpdateTime = _prefix "faultLastUpdateTime"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#faultSeverity"></see>
    /// </summary>
    let faultSeverity = _prefix "faultSeverity"
    /// <summary>
    /// Filter indicators management information.
    /// <see href="http://vocab.datex.org/terms#FilterExitManagement"></see></summary>
    let FilterExitManagement = _prefix "FilterExitManagement"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#filterEnd"></see>
    /// </summary>
    let filterEnd = _prefix "filterEnd"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#filterExitManagementExtension"></see>
    /// </summary>
    let filterExitManagementExtension = _prefix "filterExitManagementExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#filterOutOfRange"></see>
    /// </summary>
    let filterOutOfRange = _prefix "filterOutOfRange"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#deleteFilter"></see>
    /// </summary>
    let deleteFilter = _prefix "deleteFilter"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#filterOperationApproved"></see>
    /// </summary>
    let filterOperationApproved = _prefix "filterOperationApproved"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#filterReferenceExtension"></see>
    /// </summary>
    let filterReferenceExtension = _prefix "filterReferenceExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#keyFilterReference"></see>
    /// </summary>
    let keyFilterReference = _prefix "keyFilterReference"
    /// <summary>
    /// A measured or calculated value of distance in metres in a floating point format.
    /// <see href="http://vocab.datex.org/terms#FloatingPointMetreDistanceValue"></see></summary>
    let FloatingPointMetreDistanceValue = _prefix "FloatingPointMetreDistanceValue"
    /// <summary>
    /// A value of distance expressed in metres in a floating point format.
    /// <see href="http://vocab.datex.org/terms#floatingPointMetreDistance"></see></summary>
    let floatingPointMetreDistance = _prefix "floatingPointMetreDistance"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#floatingPointMetreDistanceValueExtension"></see>
    /// </summary>
    let floatingPointMetreDistanceValueExtension =
        _prefix "floatingPointMetreDistanceValueExtension"

    /// <summary>
    /// General instruction and/or message that is issued by the network/road operator which is applicable to drivers and sometimes passengers.
    /// <see href="http://vocab.datex.org/terms#GeneralInstructionOrMessageToRoadUsers"></see></summary>
    let GeneralInstructionOrMessageToRoadUsers =
        _prefix "GeneralInstructionOrMessageToRoadUsers"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#generalInstructionOrMessageToRoadUsersExtension"></see>
    /// </summary>
    let generalInstructionOrMessageToRoadUsersExtension =
        _prefix "generalInstructionOrMessageToRoadUsersExtension"

    /// <summary>
    /// General instruction that is issued by the network/road operator which is applicable to drivers and sometimes passengers.
    /// <see href="http://vocab.datex.org/terms#generalInstructionToRoadUsersType"></see></summary>
    let generalInstructionToRoadUsersType = _prefix "generalInstructionToRoadUsersType"
    /// <summary>
    /// General message that is issued by the network/road operator which is applicable to drivers and sometimes passengers, e.g. details about an amber alert (missing or abducted child alert).
    /// <see href="http://vocab.datex.org/terms#generalMessageToRoadUsers"></see></summary>
    let generalMessageToRoadUsers = _prefix "generalMessageToRoadUsers"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#generalNetworkManagementExtension"></see>
    /// </summary>
    let generalNetworkManagementExtension = _prefix "generalNetworkManagementExtension"
    /// <summary>
    /// The type of traffic management action instigated by the network/road operator.
    /// <see href="http://vocab.datex.org/terms#generalNetworkManagementType"></see></summary>
    let generalNetworkManagementType = _prefix "generalNetworkManagementType"
    /// <summary>
    /// Type of person that is manually directing traffic (applicable if generalNetworkManagementType is set to "trafficBeingManuallyDirected").
    /// <see href="http://vocab.datex.org/terms#trafficManuallyDirectedBy"></see></summary>
    let trafficManuallyDirectedBy = _prefix "trafficManuallyDirectedBy"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#generalObstructionExtension"></see>
    /// </summary>
    let generalObstructionExtension = _prefix "generalObstructionExtension"
    /// <summary>
    /// Characterization of the type of general obstruction.
    /// <see href="http://vocab.datex.org/terms#obstructionType"></see></summary>
    let obstructionType = _prefix "obstructionType"
    /// <summary>
    /// A publication used to make level B extensions at the publication level.
    /// <see href="http://vocab.datex.org/terms#GenericPublication"></see></summary>
    let GenericPublication = _prefix "GenericPublication"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#genericPublicationExtension"></see>
    /// </summary>
    let genericPublicationExtension = _prefix "genericPublicationExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_GenericPublicationExtensionType"></see>
    /// </summary>
    let _GenericPublicationExtensionType = _prefix "_GenericPublicationExtensionType"
    /// <summary>
    /// The name of the generic publication.
    /// <see href="http://vocab.datex.org/terms#genericPublicationName"></see></summary>
    let genericPublicationName = _prefix "genericPublicationName"
    /// <summary>
    /// A generic SituationRecord for use when adding level B extensions at the SituationRecord level.
    /// <see href="http://vocab.datex.org/terms#GenericSituationRecord"></see></summary>
    let GenericSituationRecord = _prefix "GenericSituationRecord"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#genericSituationRecordExtension"></see>
    /// </summary>
    let genericSituationRecordExtension = _prefix "genericSituationRecordExtension"
    /// <summary>
    /// The name of the GenericSituationRecord.
    /// <see href="http://vocab.datex.org/terms#genericSituationRecordName"></see></summary>
    let genericSituationRecordName = _prefix "genericSituationRecordName"
    /// <summary>
    /// An identifiable versioned instance of a single record/element within a situation.
    /// <see href="http://vocab.datex.org/terms#SituationRecord"></see></summary>
    let SituationRecord = _prefix "SituationRecord"
    /// <summary>
    /// Gross weight characteristic of a vehicle.
    /// <see href="http://vocab.datex.org/terms#GrossWeightCharacteristic"></see></summary>
    let GrossWeightCharacteristic = _prefix "GrossWeightCharacteristic"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#comparisonOperator"></see>
    /// </summary>
    let comparisonOperator = _prefix "comparisonOperator"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#grossVehicleWeight"></see>
    /// </summary>
    let grossVehicleWeight = _prefix "grossVehicleWeight"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#grossWeightCharacteristicExtension"></see>
    /// </summary>
    let grossWeightCharacteristicExtension =
        _prefix "grossWeightCharacteristicExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#groupOfLocationsExtension"></see>
    /// </summary>
    let groupOfLocationsExtension = _prefix "groupOfLocationsExtension"
    /// <summary>
    /// A logical composition of parking sites with aggregated properties (e.g. number of spaces). Examples: Urban parking area "West" or all truck parkings along a motorway. The included parking sites may -but must not- be specified as subcomponents.
    /// <see href="http://vocab.datex.org/terms#GroupOfParkingSites"></see></summary>
    let GroupOfParkingSites = _prefix "GroupOfParkingSites"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#groupOfParkingSitesExtension"></see>
    /// </summary>
    let groupOfParkingSitesExtension = _prefix "groupOfParkingSitesExtension"
    /// <summary>
    /// The type of this group of parking sites.
    /// <see href="http://vocab.datex.org/terms#groupOfParkingSitesType"></see></summary>
    let groupOfParkingSitesType = _prefix "groupOfParkingSitesType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSite"></see>
    /// </summary>
    let parkingSite = _prefix "parkingSite"
    /// <summary>
    /// A record containing static details of a parking site. Must be specialised as an 'Urban-' or 'InterUrbanParkingSite' or a 'SpecialLocationParkingSite'.
    /// <see href="http://vocab.datex.org/terms#ParkingSite"></see></summary>
    let ParkingSite = _prefix "ParkingSite"
    /// <summary>
    /// Parking sites of this collection defined by reference.
    /// <see href="http://vocab.datex.org/terms#parkingSiteByReference"></see></summary>
    let parkingSiteByReference = _prefix "parkingSiteByReference"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_ParkingRecordVersionedReference"></see>
    /// </summary>
    let _ParkingRecordVersionedReference = _prefix "_ParkingRecordVersionedReference"
    /// <summary>
    /// A container for static parking information. Must be specialised as a parking site or as a group of parking sites.
    /// <see href="http://vocab.datex.org/terms#ParkingRecord"></see></summary>
    let ParkingRecord = _prefix "ParkingRecord"
    /// <summary>
    /// Dynamic status information for the static object 'GroupOfParkingSites'.
    /// <see href="http://vocab.datex.org/terms#GroupOfParkingSitesStatus"></see></summary>
    let GroupOfParkingSitesStatus = _prefix "GroupOfParkingSitesStatus"
    /// <summary>
    /// The status of the group of parking sites (available spaces or not).
    /// <see href="http://vocab.datex.org/terms#groupOfParkingSitesStatus"></see></summary>
    let groupOfParkingSitesStatus = _prefix "groupOfParkingSitesStatus"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#groupOfParkingSitesStatusExtension"></see>
    /// </summary>
    let groupOfParkingSitesStatusExtension =
        _prefix "groupOfParkingSitesStatusExtension"

    /// <summary>
    /// Contains the current status of one parking record defined in the static model (i.e. parking site or group of parking sites) or historical or forecasted data for one parking. Only for the second case, 'parkingStatusTime' must be specified.
    /// <see href="http://vocab.datex.org/terms#ParkingRecordStatus"></see></summary>
    let ParkingRecordStatus = _prefix "ParkingRecordStatus"
    /// <summary>
    /// A group of parking spaces. All information provided has to be identical for all places in this group. Can also be used just to give the number of lorry parkings, for example. 'GroupOfParkingSpaces' may be multiple defined or include each other.
    /// <see href="http://vocab.datex.org/terms#GroupOfParkingSpaces"></see></summary>
    let GroupOfParkingSpaces = _prefix "GroupOfParkingSpaces"
    /// <summary>
    /// Dimension of a virtual rectangle encapsulating the group of parking spaces. Use 'dimensionUsableArea' to define the total space available for parking within this group. Do not use 'dimensionHeight'.
    /// <see href="http://vocab.datex.org/terms#dimensionOfGroup"></see></summary>
    let dimensionOfGroup = _prefix "dimensionOfGroup"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#groupOfParkingSpacesExtension"></see>
    /// </summary>
    let groupOfParkingSpacesExtension = _prefix "groupOfParkingSpacesExtension"
    /// <summary>
    /// Points to another instance of 'GroupOfParkingSpaces', which is identical from a local point of view. To be used when defining mixed parking areas with different time slots.
    /// <see href="http://vocab.datex.org/terms#identicalToGroup"></see></summary>
    let identicalToGroup = _prefix "identicalToGroup"
    /// <summary>
    /// Dimension of the largest space within this group (i.e. there must be at least one space of this dimension). If the comparison of dimension values is not unique, the length is decisive.
    /// <see href="http://vocab.datex.org/terms#maximumParkingSpaceDimension"></see></summary>
    let maximumParkingSpaceDimension = _prefix "maximumParkingSpaceDimension"
    /// <summary>
    /// Lower dimension boundaries for all spaces within the group. Note that there must not exist a space with this dimension, but each space's dimension values must be equal or higher.
    /// <see href="http://vocab.datex.org/terms#minimumParkingSpaceDimension"></see></summary>
    let minimumParkingSpaceDimension = _prefix "minimumParkingSpaceDimension"
    /// <summary>
    /// Number of parking spaces (attribute is used for a parking record as well as for a group of parking spaces).
    /// <see href="http://vocab.datex.org/terms#parkingNumberOfSpaces"></see></summary>
    let parkingNumberOfSpaces = _prefix "parkingNumberOfSpaces"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSpace"></see>
    /// </summary>
    let parkingSpace = _prefix "parkingSpace"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_GroupOfParkingSpacesParkingSpaceIndexParkingSpace"></see>
    /// </summary>
    let _GroupOfParkingSpacesParkingSpaceIndexParkingSpace =
        _prefix "_GroupOfParkingSpacesParkingSpaceIndexParkingSpace"

    /// <summary>
    /// Defines the type of this group specification.
    /// <see href="http://vocab.datex.org/terms#parkingTypeOfGroup"></see></summary>
    let parkingTypeOfGroup = _prefix "parkingTypeOfGroup"
    /// <summary>
    /// Points to another instance of 'GroupOfParkingSpaces', which is a real superset from a local point of view. To be used when defining mixed parking areas with different time slots.
    /// <see href="http://vocab.datex.org/terms#realSubsetOfGroup"></see></summary>
    let realSubsetOfGroup = _prefix "realSubsetOfGroup"
    /// <summary>
    /// Common properties of parking spaces and groups of parking spaces.
    /// <see href="http://vocab.datex.org/terms#ParkingSpaceBasics"></see></summary>
    let ParkingSpaceBasics = _prefix "ParkingSpaceBasics"
    /// <summary>
    /// The status of the assigned parking spaces in the specified parking site, i.e. the status of those spaces assigned for particular types of person or vehicle and/or for specific duration types (e.g. short stay).
    /// <see href="http://vocab.datex.org/terms#GroupOfParkingSpacesStatus"></see></summary>
    let GroupOfParkingSpacesStatus = _prefix "GroupOfParkingSpacesStatus"
    /// <summary>
    /// Override validity of AssignedParkingSpaces: True = Parking space declaration is valid now; False = Parking space declaration is invalid now; Omitted = Static validity information is significant (if static validity is omitted too, declaration is valid).
    /// <see href="http://vocab.datex.org/terms#groupDeclarationValidNow"></see></summary>
    let groupDeclarationValidNow = _prefix "groupDeclarationValidNow"
    /// <summary>
    /// True: The group of parking spaces is closed / not accessible. False or omitted: The group of parking spaces is accessible. This is no statement about its occupation.
    /// <see href="http://vocab.datex.org/terms#groupOfParkingSpacesClosed"></see></summary>
    let groupOfParkingSpacesClosed = _prefix "groupOfParkingSpacesClosed"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#groupOfParkingSpacesStatusExtension"></see>
    /// </summary>
    let groupOfParkingSpacesStatusExtension =
        _prefix "groupOfParkingSpacesStatusExtension"

    /// <summary>
    /// Parking capacity information for the parking site as well as for AssignedParkingSpaces.
    /// <see href="http://vocab.datex.org/terms#ParkingOccupancy"></see></summary>
    let ParkingOccupancy = _prefix "ParkingOccupancy"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#categoryOfPeopleInvolved"></see>
    /// </summary>
    let categoryOfPeopleInvolved = _prefix "categoryOfPeopleInvolved"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#groupOfPeopleInvolvedExtension"></see>
    /// </summary>
    let groupOfPeopleInvolvedExtension = _prefix "groupOfPeopleInvolvedExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#injuryStatus"></see>
    /// </summary>
    let injuryStatus = _prefix "injuryStatus"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#involvementRole"></see>
    /// </summary>
    let involvementRole = _prefix "involvementRole"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#numberOfPeople"></see>
    /// </summary>
    let numberOfPeople = _prefix "numberOfPeople"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#groupOfVehiclesInvolvedExtension"></see>
    /// </summary>
    let groupOfVehiclesInvolvedExtension = _prefix "groupOfVehiclesInvolvedExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#numberOfVehicles"></see>
    /// </summary>
    let numberOfVehicles = _prefix "numberOfVehicles"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleCharacteristics"></see>
    /// </summary>
    let vehicleCharacteristics = _prefix "vehicleCharacteristics"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleStatus"></see>
    /// </summary>
    let vehicleStatus = _prefix "vehicleStatus"
    /// <summary>
    /// Details of hazardous materials.
    /// <see href="http://vocab.datex.org/terms#HazardousMaterials"></see></summary>
    let HazardousMaterials = _prefix "HazardousMaterials"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#chemicalName"></see>
    /// </summary>
    let chemicalName = _prefix "chemicalName"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#dangerousGoodsFlashPoint"></see>
    /// </summary>
    let dangerousGoodsFlashPoint = _prefix "dangerousGoodsFlashPoint"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#dangerousGoodsRegulations"></see>
    /// </summary>
    let dangerousGoodsRegulations = _prefix "dangerousGoodsRegulations"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#hazardCodeIdentification"></see>
    /// </summary>
    let hazardCodeIdentification = _prefix "hazardCodeIdentification"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#hazardCodeVersionNumber"></see>
    /// </summary>
    let hazardCodeVersionNumber = _prefix "hazardCodeVersionNumber"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#hazardSubstanceItemPageNumber"></see>
    /// </summary>
    let hazardSubstanceItemPageNumber = _prefix "hazardSubstanceItemPageNumber"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#hazardousMaterialsExtension"></see>
    /// </summary>
    let hazardousMaterialsExtension = _prefix "hazardousMaterialsExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tremCardNumber"></see>
    /// </summary>
    let tremCardNumber = _prefix "tremCardNumber"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#undgNumber"></see>
    /// </summary>
    let undgNumber = _prefix "undgNumber"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#volumeOfDangerousGoods"></see>
    /// </summary>
    let volumeOfDangerousGoods = _prefix "volumeOfDangerousGoods"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#weightOfDangerousGoods"></see>
    /// </summary>
    let weightOfDangerousGoods = _prefix "weightOfDangerousGoods"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#areaOfInterest"></see>
    /// </summary>
    let areaOfInterest = _prefix "areaOfInterest"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#confidentiality"></see>
    /// </summary>
    let confidentiality = _prefix "confidentiality"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#headerInformationExtension"></see>
    /// </summary>
    let headerInformationExtension = _prefix "headerInformationExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#informationStatus"></see>
    /// </summary>
    let informationStatus = _prefix "informationStatus"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#urgency"></see>
    /// </summary>
    let urgency = _prefix "urgency"
    /// <summary>
    /// Weight characteristic of the heaviest axle on the vehicle.
    /// <see href="http://vocab.datex.org/terms#HeaviestAxleWeightCharacteristic"></see></summary>
    let HeaviestAxleWeightCharacteristic = _prefix "HeaviestAxleWeightCharacteristic"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#heaviestAxleWeight"></see>
    /// </summary>
    let heaviestAxleWeight = _prefix "heaviestAxleWeight"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#heaviestAxleWeightCharacteristicExtension"></see>
    /// </summary>
    let heaviestAxleWeightCharacteristicExtension =
        _prefix "heaviestAxleWeightCharacteristicExtension"

    /// <summary>
    /// Height characteristic of a vehicle.
    /// <see href="http://vocab.datex.org/terms#HeightCharacteristic"></see></summary>
    let HeightCharacteristic = _prefix "HeightCharacteristic"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#heightCharacteristicExtension"></see>
    /// </summary>
    let heightCharacteristicExtension = _prefix "heightCharacteristicExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleHeight"></see>
    /// </summary>
    let vehicleHeight = _prefix "vehicleHeight"
    /// <summary>
    /// Details of atmospheric humidity.
    /// <see href="http://vocab.datex.org/terms#Humidity"></see></summary>
    let Humidity = _prefix "Humidity"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#humidityExtension"></see>
    /// </summary>
    let humidityExtension = _prefix "humidityExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#relativeHumidity"></see>
    /// </summary>
    let relativeHumidity = _prefix "relativeHumidity"
    /// <summary>
    /// A measured or calculated value expressed as a percentage.
    /// <see href="http://vocab.datex.org/terms#PercentageValue"></see></summary>
    let PercentageValue = _prefix "PercentageValue"
    /// <summary>
    /// Measurements of atmospheric humidity.
    /// <see href="http://vocab.datex.org/terms#HumidityInformation"></see></summary>
    let HumidityInformation = _prefix "HumidityInformation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#humidity"></see>
    /// </summary>
    let humidity = _prefix "humidity"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#humidityInformationExtension"></see>
    /// </summary>
    let humidityInformationExtension = _prefix "humidityInformationExtension"
    /// <summary>
    /// Measured or derived values relating to the weather at a specific location or locations.
    /// <see href="http://vocab.datex.org/terms#WeatherData"></see></summary>
    let WeatherData = _prefix "WeatherData"
    /// <summary>
    /// An assessment of the impact that an event or operator action defined by the situation record has on the driving conditions.
    /// <see href="http://vocab.datex.org/terms#Impact"></see></summary>
    let Impact = _prefix "Impact"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#capacityRemaining"></see>
    /// </summary>
    let capacityRemaining = _prefix "capacityRemaining"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#delays"></see>
    /// </summary>
    let delays = _prefix "delays"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#impactExtension"></see>
    /// </summary>
    let impactExtension = _prefix "impactExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#numberOfLanesRestricted"></see>
    /// </summary>
    let numberOfLanesRestricted = _prefix "numberOfLanesRestricted"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#numberOfOperationalLanes"></see>
    /// </summary>
    let numberOfOperationalLanes = _prefix "numberOfOperationalLanes"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#originalNumberOfLanes"></see>
    /// </summary>
    let originalNumberOfLanes = _prefix "originalNumberOfLanes"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#residualRoadWidth"></see>
    /// </summary>
    let residualRoadWidth = _prefix "residualRoadWidth"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#trafficConstrictionType"></see>
    /// </summary>
    let trafficConstrictionType = _prefix "trafficConstrictionType"
    /// <summary>
    /// Information on the individual charge for parking the specified vehicle.
    /// <see href="http://vocab.datex.org/terms#IndividualCharge"></see></summary>
    let IndividualCharge = _prefix "IndividualCharge"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#chargePaid"></see>
    /// </summary>
    let chargePaid = _prefix "chargePaid"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#individualChargeExtension"></see>
    /// </summary>
    let individualChargeExtension = _prefix "individualChargeExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#usedMeansOfPayment"></see>
    /// </summary>
    let usedMeansOfPayment = _prefix "usedMeansOfPayment"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#usedPaymentCard"></see>
    /// </summary>
    let usedPaymentCard = _prefix "usedPaymentCard"
    /// <summary>
    /// The used payment card for this parking vehicle.
    /// <see href="http://vocab.datex.org/terms#UsedPaymentCard"></see></summary>
    let UsedPaymentCard = _prefix "UsedPaymentCard"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#withReservation"></see>
    /// </summary>
    let withReservation = _prefix "withReservation"
    /// <summary>
    /// Measured or calculated data values relating to individual vehicles derived from detectors at the specified measurement site.
    /// <see href="http://vocab.datex.org/terms#IndividualVehicleDataValues"></see></summary>
    let IndividualVehicleDataValues = _prefix "IndividualVehicleDataValues"
    /// <summary>
    /// The time of the arrival of an individual vehicle in a detection zone.
    /// <see href="http://vocab.datex.org/terms#arrivalTime"></see></summary>
    let arrivalTime = _prefix "arrivalTime"
    /// <summary>
    /// The measured distance between the front of this vehicle and the rear of the preceding one, in metres at the specified measurement site.
    /// <see href="http://vocab.datex.org/terms#distanceGap"></see></summary>
    let distanceGap = _prefix "distanceGap"
    /// <summary>
    /// The measured distance between the front (respectively back) of this vehicle and the front (respectively  back) of the preceding vehicle at the specified measurement site.
    /// <see href="http://vocab.datex.org/terms#distanceHeadway"></see></summary>
    let distanceHeadway = _prefix "distanceHeadway"
    /// <summary>
    /// The time when an individual vehicle leaves a detection zone.
    /// <see href="http://vocab.datex.org/terms#exitTime"></see></summary>
    let exitTime = _prefix "exitTime"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#individualVehicleDataValuesExtension"></see>
    /// </summary>
    let individualVehicleDataValuesExtension =
        _prefix "individualVehicleDataValuesExtension"

    /// <summary>
    /// The measured speed of the individual vehicle at the specified measurement site.
    /// <see href="http://vocab.datex.org/terms#individualVehicleSpeed"></see></summary>
    let individualVehicleSpeed = _prefix "individualVehicleSpeed"
    /// <summary>
    /// A measured or calculated value of speed.
    /// <see href="http://vocab.datex.org/terms#SpeedValue"></see></summary>
    let SpeedValue = _prefix "SpeedValue"
    /// <summary>
    /// The time elapsed between an individual vehicle entering a detection zone and exiting the same detection zone as detected by entry and exit sensors.
    /// <see href="http://vocab.datex.org/terms#passageDurationTime"></see></summary>
    let passageDurationTime = _prefix "passageDurationTime"
    /// <summary>
    /// The period of time during which a vehicle activates a presence sensor.
    /// <see href="http://vocab.datex.org/terms#presenceDurationTime"></see></summary>
    let presenceDurationTime = _prefix "presenceDurationTime"
    /// <summary>
    /// The time interval between the arrival of this vehicle's front at a point on the roadway, and that of the departure of the rear of the preceding one.
    /// <see href="http://vocab.datex.org/terms#timeGap"></see></summary>
    let timeGap = _prefix "timeGap"
    /// <summary>
    /// The measured time interval between this vehicle's arrival at (or departure from) a point on the roadway, and that of the preceding one.
    /// <see href="http://vocab.datex.org/terms#timeHeadway"></see></summary>
    let timeHeadway = _prefix "timeHeadway"
    /// <summary>
    /// Measured or derived values relating to traffic or individual vehicle movements on a specific section or at a specific point on the road network.
    /// <see href="http://vocab.datex.org/terms#TrafficData"></see></summary>
    let TrafficData = _prefix "TrafficData"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#infrastructureDamageObstructionExtension"></see>
    /// </summary>
    let infrastructureDamageObstructionExtension =
        _prefix "infrastructureDamageObstructionExtension"

    /// <summary>
    /// Characterization of an obstruction on the road resulting from the failure or damage of infrastructure on, under, above or close to the road.
    /// <see href="http://vocab.datex.org/terms#infrastructureDamageType"></see></summary>
    let infrastructureDamageType = _prefix "infrastructureDamageType"
    /// <summary>
    /// A measured or calculated value of distance in whole metres.
    /// <see href="http://vocab.datex.org/terms#IntegerMetreDistanceValue"></see></summary>
    let IntegerMetreDistanceValue = _prefix "IntegerMetreDistanceValue"
    /// <summary>
    /// A value of distance expressed in metres in a non negative integer format.
    /// <see href="http://vocab.datex.org/terms#integerMetreDistance"></see></summary>
    let integerMetreDistance = _prefix "integerMetreDistance"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#integerMetreDistanceValueExtension"></see>
    /// </summary>
    let integerMetreDistanceValueExtension =
        _prefix "integerMetreDistanceValueExtension"

    /// <summary>
    /// A parking site in an interurban context.
    /// <see href="http://vocab.datex.org/terms#InterUrbanParkingSite"></see></summary>
    let InterUrbanParkingSite = _prefix "InterUrbanParkingSite"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#interUrbanParkingSiteExtension"></see>
    /// </summary>
    let interUrbanParkingSiteExtension = _prefix "interUrbanParkingSiteExtension"
    /// <summary>
    /// Defines whether the interurban parking site is located in or nearby a motorway context, is a layby or on-street parking.
    /// <see href="http://vocab.datex.org/terms#interUrbanParkingSiteLocation"></see></summary>
    let interUrbanParkingSiteLocation = _prefix "interUrbanParkingSiteLocation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#internationalIdentifierExtension"></see>
    /// </summary>
    let internationalIdentifierExtension = _prefix "internationalIdentifierExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#nationalIdentifier"></see>
    /// </summary>
    let nationalIdentifier = _prefix "nationalIdentifier"
    /// <summary>
    /// Multiple (i.e. more than one) physically separate locations arranged as an ordered set that defines an itinerary or route.
    /// <see href="http://vocab.datex.org/terms#Itinerary"></see></summary>
    let Itinerary = _prefix "Itinerary"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#itineraryExtension"></see>
    /// </summary>
    let itineraryExtension = _prefix "itineraryExtension"
    /// <summary>
    /// Destination of a route or final location in an itinerary.
    /// <see href="http://vocab.datex.org/terms#routeDestination"></see></summary>
    let routeDestination = _prefix "routeDestination"
    /// <summary>
    /// Multiple physically separate locations arranged as an ordered set that defines an itinerary or route. The index qualifier indicates the order.
    /// <see href="http://vocab.datex.org/terms#ItineraryByIndexedLocations"></see></summary>
    let ItineraryByIndexedLocations = _prefix "ItineraryByIndexedLocations"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#itineraryByIndexedLocationsExtension"></see>
    /// </summary>
    let itineraryByIndexedLocationsExtension =
        _prefix "itineraryByIndexedLocationsExtension"

    /// <summary>
    /// A location contained in an itinerary (i.e. an ordered set of locations defining a route or itinerary).
    /// <see href="http://vocab.datex.org/terms#locationContainedInItinerary"></see></summary>
    let locationContainedInItinerary = _prefix "locationContainedInItinerary"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_LocationContainedInItinerary"></see>
    /// </summary>
    let _LocationContainedInItinerary = _prefix "_LocationContainedInItinerary"
    /// <summary>
    /// Multiple (i.e. more than one) physically separate locations which are ordered that constitute an itinerary or route where they are defined by reference to a predefined itinerary.
    /// <see href="http://vocab.datex.org/terms#ItineraryByReference"></see></summary>
    let ItineraryByReference = _prefix "ItineraryByReference"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#itineraryByReferenceExtension"></see>
    /// </summary>
    let itineraryByReferenceExtension = _prefix "itineraryByReferenceExtension"
    /// <summary>
    /// A reference to a versioned instance of a predefined itinerary as specified in a PredefinedLocationsPublication.
    /// <see href="http://vocab.datex.org/terms#predefinedItineraryReference"></see></summary>
    let predefinedItineraryReference = _prefix "predefinedItineraryReference"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_PredefinedItineraryVersionedReference"></see>
    /// </summary>
    let _PredefinedItineraryVersionedReference =
        _prefix "_PredefinedItineraryVersionedReference"

    /// <summary>
    /// Junction (on a highway), can also be an interchange or if applicable also a motorway service station (see junctionClassification).
    /// <see href="http://vocab.datex.org/terms#Junction"></see></summary>
    let Junction = _prefix "Junction"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#destinationMotorway"></see>
    /// </summary>
    let destinationMotorway = _prefix "destinationMotorway"
    /// <summary>
    /// Identification of a road by its name, identifier, type ...
    /// <see href="http://vocab.datex.org/terms#Road"></see></summary>
    let Road = _prefix "Road"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#junctionClassification"></see>
    /// </summary>
    let junctionClassification = _prefix "junctionClassification"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#junctionExtension"></see>
    /// </summary>
    let junctionExtension = _prefix "junctionExtension"
    /// <summary>
    /// Name of the junction.
    /// <see href="http://vocab.datex.org/terms#junctionName"></see></summary>
    let junctionName = _prefix "junctionName"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#junctionNumber"></see>
    /// </summary>
    let junctionNumber = _prefix "junctionNumber"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#motorway"></see>
    /// </summary>
    let motorway = _prefix "motorway"
    /// <summary>
    /// A measured or calculated value of concentration of a substance in grams per unit volume.
    /// <see href="http://vocab.datex.org/terms#KilogramsConcentrationValue"></see></summary>
    let KilogramsConcentrationValue = _prefix "KilogramsConcentrationValue"
    /// <summary>
    /// A value defining the amount of a substance in a given volume (concentration) expressed in kilograms per cubic metre.
    /// <see href="http://vocab.datex.org/terms#kilogramsConcentration"></see></summary>
    let kilogramsConcentration = _prefix "kilogramsConcentration"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#kilogramsConcentrationValueExtension"></see>
    /// </summary>
    let kilogramsConcentrationValueExtension =
        _prefix "kilogramsConcentrationValueExtension"

    /// <summary>
    /// Length characteristic of a vehicle.
    /// <see href="http://vocab.datex.org/terms#LengthCharacteristic"></see></summary>
    let LengthCharacteristic = _prefix "LengthCharacteristic"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#lengthCharacteristicExtension"></see>
    /// </summary>
    let lengthCharacteristicExtension = _prefix "lengthCharacteristicExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleLength"></see>
    /// </summary>
    let vehicleLength = _prefix "vehicleLength"
    /// <summary>
    /// Information relating to the life cycle management of the situation record.
    /// <see href="http://vocab.datex.org/terms#LifeCycleManagement"></see></summary>
    let LifeCycleManagement = _prefix "LifeCycleManagement"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#cancel"></see>
    /// </summary>
    let cancel = _prefix "cancel"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#end"></see>
    /// </summary>
    let end_ = _prefix "end"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#lifeCycleManagementExtension"></see>
    /// </summary>
    let lifeCycleManagementExtension = _prefix "lifeCycleManagementExtension"
    /// <summary>
    /// A linear section along a single road with optional directionality defined between two points on the same road.
    /// <see href="http://vocab.datex.org/terms#Linear"></see></summary>
    let Linear = _prefix "Linear"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCLinear"></see>
    /// </summary>
    let alertCLinear = _prefix "alertCLinear"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#linearExtension"></see>
    /// </summary>
    let linearExtension = _prefix "linearExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_LinearExtensionType"></see>
    /// </summary>
    let _LinearExtensionType = _prefix "_LinearExtensionType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#linearWithinLinearElement"></see>
    /// </summary>
    let linearWithinLinearElement = _prefix "linearWithinLinearElement"
    /// <summary>
    /// A linear section along a linear element where the linear element is either a part of or the whole of a linear object (i.e. a road), consistent with ISO 19148 definitions.
    /// <see href="http://vocab.datex.org/terms#LinearWithinLinearElement"></see></summary>
    let LinearWithinLinearElement = _prefix "LinearWithinLinearElement"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegLinearLocation"></see>
    /// </summary>
    let tpegLinearLocation = _prefix "tpegLinearLocation"
    /// <summary>
    /// A linear section along a single road defined between two points on the same road by a TPEG-Loc structure.
    /// <see href="http://vocab.datex.org/terms#TpegLinearLocation"></see></summary>
    let TpegLinearLocation = _prefix "TpegLinearLocation"
    /// <summary>
    /// The specification of a location on a network (as a point or a linear location).
    /// <see href="http://vocab.datex.org/terms#NetworkLocation"></see></summary>
    let NetworkLocation = _prefix "NetworkLocation"
    /// <summary>
    /// A linear element along a single linear object, consistent with ISO 19148 definitions.
    /// <see href="http://vocab.datex.org/terms#LinearElement"></see></summary>
    let LinearElement = _prefix "LinearElement"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#linearElementExtension"></see>
    /// </summary>
    let linearElementExtension = _prefix "linearElementExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#linearElementNature"></see>
    /// </summary>
    let linearElementNature = _prefix "linearElementNature"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#linearElementReferenceModel"></see>
    /// </summary>
    let linearElementReferenceModel = _prefix "linearElementReferenceModel"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#linearElementReferenceModelVersion"></see>
    /// </summary>
    let linearElementReferenceModelVersion =
        _prefix "linearElementReferenceModelVersion"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#roadName"></see>
    /// </summary>
    let roadName = _prefix "roadName"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#roadNumber"></see>
    /// </summary>
    let roadNumber = _prefix "roadNumber"
    /// <summary>
    /// A linear element along a single linear object defined by its identifier or code in a road network reference model (specified in LinearElement class) which segments the road network according to specific business rules.
    /// <see href="http://vocab.datex.org/terms#LinearElementByCode"></see></summary>
    let LinearElementByCode = _prefix "LinearElementByCode"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#linearElementByCodeExtension"></see>
    /// </summary>
    let linearElementByCodeExtension = _prefix "linearElementByCodeExtension"
    /// <summary>
    /// An identifier or code of a linear element (or link) in the road network reference model that is specified in the LinearElement class.
    /// <see href="http://vocab.datex.org/terms#linearElementIdentifier"></see></summary>
    let linearElementIdentifier = _prefix "linearElementIdentifier"
    /// <summary>
    /// A linear element along a single linear object defined by its start and end points.
    /// <see href="http://vocab.datex.org/terms#LinearElementByPoints"></see></summary>
    let LinearElementByPoints = _prefix "LinearElementByPoints"
    /// <summary>
    /// The referent at a known location on the linear object which defines the end of the linear element.
    /// <see href="http://vocab.datex.org/terms#endPointOfLinearElement"></see></summary>
    let endPointOfLinearElement = _prefix "endPointOfLinearElement"
    /// <summary>
    /// A referent at a known location on the linear object which is neither the start or end of the linear element.
    /// <see href="http://vocab.datex.org/terms#intermediatePointOnLinearElement"></see></summary>
    let intermediatePointOnLinearElement = _prefix "intermediatePointOnLinearElement"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_IntermediatePointOnLinearElement"></see>
    /// </summary>
    let _IntermediatePointOnLinearElement = _prefix "_IntermediatePointOnLinearElement"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#linearElementByPointsExtension"></see>
    /// </summary>
    let linearElementByPointsExtension = _prefix "linearElementByPointsExtension"
    /// <summary>
    /// The referent at a known location on the linear object which defines the start of the linear element.
    /// <see href="http://vocab.datex.org/terms#startPointOfLinearElement"></see></summary>
    let startPointOfLinearElement = _prefix "startPointOfLinearElement"
    /// <summary>
    /// An identifiable instance of a linear traffic view at a single point in time relating to a linear section of road, comprising one or more traffic view records.
    /// <see href="http://vocab.datex.org/terms#LinearTrafficView"></see></summary>
    let LinearTrafficView = _prefix "LinearTrafficView"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#linearPredefinedLocationReference"></see>
    /// </summary>
    let linearPredefinedLocationReference = _prefix "linearPredefinedLocationReference"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_PredefinedLocationVersionedReference"></see>
    /// </summary>
    let _PredefinedLocationVersionedReference =
        _prefix "_PredefinedLocationVersionedReference"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#linearTrafficViewExtension"></see>
    /// </summary>
    let linearTrafficViewExtension = _prefix "linearTrafficViewExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#trafficViewRecord"></see>
    /// </summary>
    let trafficViewRecord = _prefix "trafficViewRecord"
    /// <summary>
    /// An identifiable instance of a single record within a traffic view which shall comprise at most one instance of each of the following: OperatorAction, TrafficElement, ElaboratedData and CCTVImages.
    /// <see href="http://vocab.datex.org/terms#TrafficViewRecord"></see></summary>
    let TrafficViewRecord = _prefix "TrafficViewRecord"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#administrativeAreaOfLinearSection"></see>
    /// </summary>
    let administrativeAreaOfLinearSection = _prefix "administrativeAreaOfLinearSection"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#directionBoundOnLinearSection"></see>
    /// </summary>
    let directionBoundOnLinearSection = _prefix "directionBoundOnLinearSection"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#directionRelativeOnLinearSection"></see>
    /// </summary>
    let directionRelativeOnLinearSection = _prefix "directionRelativeOnLinearSection"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#fromPoint"></see>
    /// </summary>
    let fromPoint = _prefix "fromPoint"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#heightGradeOfLinearSection"></see>
    /// </summary>
    let heightGradeOfLinearSection = _prefix "heightGradeOfLinearSection"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#linearElement"></see>
    /// </summary>
    let linearElement = _prefix "linearElement"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#linearWithinLinearElementExtension"></see>
    /// </summary>
    let linearWithinLinearElementExtension =
        _prefix "linearWithinLinearElementExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#toPoint"></see>
    /// </summary>
    let toPoint = _prefix "toPoint"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#externalReferencing"></see>
    /// </summary>
    let externalReferencing = _prefix "externalReferencing"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#locationExtension"></see>
    /// </summary>
    let locationExtension = _prefix "locationExtension"
    /// <summary>
    /// A location which may be used by clients for visual display on user interfaces.
    /// <see href="http://vocab.datex.org/terms#locationForDisplay"></see></summary>
    let locationForDisplay = _prefix "locationForDisplay"
    /// <summary>
    /// A pair of coordinates defining the geodetic position of a single point using the European Terrestrial Reference System 1989 (ETRS89).
    /// <see href="http://vocab.datex.org/terms#PointCoordinates"></see></summary>
    let PointCoordinates = _prefix "PointCoordinates"
    /// <summary>
    /// A location defined by reference to a predefined location.
    /// <see href="http://vocab.datex.org/terms#LocationByReference"></see></summary>
    let LocationByReference = _prefix "LocationByReference"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#locationByReferenceExtension"></see>
    /// </summary>
    let locationByReferenceExtension = _prefix "locationByReferenceExtension"
    /// <summary>
    /// A reference to a versioned predefined location.
    /// <see href="http://vocab.datex.org/terms#predefinedLocationReference"></see></summary>
    let predefinedLocationReference = _prefix "predefinedLocationReference"
    /// <summary>
    /// Location characteristics which override values set in the referenced measurement point.
    /// <see href="http://vocab.datex.org/terms#LocationCharacteristicsOverride"></see></summary>
    let LocationCharacteristicsOverride = _prefix "LocationCharacteristicsOverride"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#locationCharacteristicsOverrideExtension"></see>
    /// </summary>
    let locationCharacteristicsOverrideExtension =
        _prefix "locationCharacteristicsOverrideExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementLanesOverride"></see>
    /// </summary>
    let measurementLanesOverride = _prefix "measurementLanesOverride"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#reversedFlow"></see>
    /// </summary>
    let reversedFlow = _prefix "reversedFlow"
    /// <summary>
    /// Details of the maintenance vehicles involved in the roadworks activity.
    /// <see href="http://vocab.datex.org/terms#MaintenanceVehicles"></see></summary>
    let MaintenanceVehicles = _prefix "MaintenanceVehicles"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maintenanceVehicleActions"></see>
    /// </summary>
    let maintenanceVehicleActions = _prefix "maintenanceVehicleActions"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maintenanceVehiclesExtension"></see>
    /// </summary>
    let maintenanceVehiclesExtension = _prefix "maintenanceVehiclesExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#numberOfMaintenanceVehicles"></see>
    /// </summary>
    let numberOfMaintenanceVehicles = _prefix "numberOfMaintenanceVehicles"
    /// <summary>
    /// Roadworks involving the maintenance or installation of infrastructure.
    /// <see href="http://vocab.datex.org/terms#MaintenanceWorks"></see></summary>
    let MaintenanceWorks = _prefix "MaintenanceWorks"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maintenanceWorksExtension"></see>
    /// </summary>
    let maintenanceWorksExtension = _prefix "maintenanceWorksExtension"
    /// <summary>
    /// The type of road maintenance or installation work at the specified location.
    /// <see href="http://vocab.datex.org/terms#roadMaintenanceType"></see></summary>
    let roadMaintenanceType = _prefix "roadMaintenanceType"
    /// <summary>
    /// A cause of this situation record which is managed by the publication creator, i.e. one which is represented by another situation record produced by the same publication creator.
    /// <see href="http://vocab.datex.org/terms#ManagedCause"></see></summary>
    let ManagedCause = _prefix "ManagedCause"
    /// <summary>
    /// A reference to another situation record produced by the same publication creator which defines a cause of the event defined here.
    /// <see href="http://vocab.datex.org/terms#managedCause"></see></summary>
    let managedCause = _prefix "managedCause"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_SituationRecordVersionedReference"></see>
    /// </summary>
    let _SituationRecordVersionedReference =
        _prefix "_SituationRecordVersionedReference"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#managedCauseExtension"></see>
    /// </summary>
    let managedCauseExtension = _prefix "managedCauseExtension"
    /// <summary>
    /// Information relating to the management of the situation record.
    /// <see href="http://vocab.datex.org/terms#Management"></see></summary>
    let Management = _prefix "Management"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#filterExitManagement"></see>
    /// </summary>
    let filterExitManagement = _prefix "filterExitManagement"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#lifeCycleManagement"></see>
    /// </summary>
    let lifeCycleManagement = _prefix "lifeCycleManagement"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#managementExtension"></see>
    /// </summary>
    let managementExtension = _prefix "managementExtension"
    /// <summary>
    /// A publication containing one or more measurement data sets, each set being measured at a single measurement site.
    /// <see href="http://vocab.datex.org/terms#MeasuredDataPublication"></see></summary>
    let MeasuredDataPublication = _prefix "MeasuredDataPublication"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measuredDataPublicationExtension"></see>
    /// </summary>
    let measuredDataPublicationExtension = _prefix "measuredDataPublicationExtension"
    /// <summary>
    /// A reference to a versioned Measurement Site table.
    /// <see href="http://vocab.datex.org/terms#measurementSiteTableReference"></see></summary>
    let measurementSiteTableReference = _prefix "measurementSiteTableReference"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_MeasurementSiteTableVersionedReference"></see>
    /// </summary>
    let _MeasurementSiteTableVersionedReference =
        _prefix "_MeasurementSiteTableVersionedReference"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#siteMeasurements"></see>
    /// </summary>
    let siteMeasurements = _prefix "siteMeasurements"
    /// <summary>
    /// A  measurement data set derived from a specific measurement site.
    /// <see href="http://vocab.datex.org/terms#SiteMeasurements"></see></summary>
    let SiteMeasurements = _prefix "SiteMeasurements"
    /// <summary>
    /// Contains optional characteristics for the specific measured value (indexed to correspond with the defined characteristics of the measurement at the referenced measurement site) which override the static characteristics defined in the MeasurementSiteTable.
    /// <see href="http://vocab.datex.org/terms#MeasuredValue"></see></summary>
    let MeasuredValue = _prefix "MeasuredValue"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#locationCharacteristicsOverride"></see>
    /// </summary>
    let locationCharacteristicsOverride = _prefix "locationCharacteristicsOverride"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measuredValueExtension"></see>
    /// </summary>
    let measuredValueExtension = _prefix "measuredValueExtension"
    /// <summary>
    /// The type of fault which is being reported for the specified measurement equipment.
    /// <see href="http://vocab.datex.org/terms#measurementEquipmentFault"></see></summary>
    let measurementEquipmentFault = _prefix "measurementEquipmentFault"
    /// <summary>
    /// Details of a fault which is being reported for the related measurement equipment.
    /// <see href="http://vocab.datex.org/terms#MeasurementEquipmentFault"></see></summary>
    let MeasurementEquipmentFault = _prefix "MeasurementEquipmentFault"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementEquipmentTypeUsed"></see>
    /// </summary>
    let measurementEquipmentTypeUsed = _prefix "measurementEquipmentTypeUsed"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementEquipmentFaultExtension"></see>
    /// </summary>
    let measurementEquipmentFaultExtension =
        _prefix "measurementEquipmentFaultExtension"

    /// <summary>
    /// An identifiable single measurement site entry/record in the Measurement Site table.
    /// <see href="http://vocab.datex.org/terms#MeasurementSiteRecord"></see></summary>
    let MeasurementSiteRecord = _prefix "MeasurementSiteRecord"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#computationMethod"></see>
    /// </summary>
    let computationMethod = _prefix "computationMethod"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementEquipmentReference"></see>
    /// </summary>
    let measurementEquipmentReference = _prefix "measurementEquipmentReference"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementSide"></see>
    /// </summary>
    let measurementSide = _prefix "measurementSide"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementSiteIdentification"></see>
    /// </summary>
    let measurementSiteIdentification = _prefix "measurementSiteIdentification"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementSiteLocation"></see>
    /// </summary>
    let measurementSiteLocation = _prefix "measurementSiteLocation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementSiteName"></see>
    /// </summary>
    let measurementSiteName = _prefix "measurementSiteName"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementSiteNumberOfLanes"></see>
    /// </summary>
    let measurementSiteNumberOfLanes = _prefix "measurementSiteNumberOfLanes"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementSiteRecordExtension"></see>
    /// </summary>
    let measurementSiteRecordExtension = _prefix "measurementSiteRecordExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementSiteRecordVersionTime"></see>
    /// </summary>
    let measurementSiteRecordVersionTime = _prefix "measurementSiteRecordVersionTime"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementSpecificCharacteristics"></see>
    /// </summary>
    let measurementSpecificCharacteristics =
        _prefix "measurementSpecificCharacteristics"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_MeasurementSiteRecordIndexMeasurementSpecificCharacteristics"></see>
    /// </summary>
    let _MeasurementSiteRecordIndexMeasurementSpecificCharacteristics =
        _prefix "_MeasurementSiteRecordIndexMeasurementSpecificCharacteristics"

    /// <summary>
    /// A Measurement Site Table comprising a number of sets of data, each describing the location from where a stream of measured data may be derived.  Each location is known as a "measurement site" which can be a point, a linear road section or an area.
    /// <see href="http://vocab.datex.org/terms#MeasurementSiteTable"></see></summary>
    let MeasurementSiteTable = _prefix "MeasurementSiteTable"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementSiteRecord"></see>
    /// </summary>
    let measurementSiteRecord = _prefix "measurementSiteRecord"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementSiteTableExtension"></see>
    /// </summary>
    let measurementSiteTableExtension = _prefix "measurementSiteTableExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementSiteTableIdentification"></see>
    /// </summary>
    let measurementSiteTableIdentification =
        _prefix "measurementSiteTableIdentification"

    /// <summary>
    /// A publication containing one or more Measurment Site Tables.
    /// <see href="http://vocab.datex.org/terms#MeasurementSiteTablePublication"></see></summary>
    let MeasurementSiteTablePublication = _prefix "MeasurementSiteTablePublication"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementSiteTable"></see>
    /// </summary>
    let measurementSiteTable = _prefix "measurementSiteTable"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementSiteTablePublicationExtension"></see>
    /// </summary>
    let measurementSiteTablePublicationExtension =
        _prefix "measurementSiteTablePublicationExtension"

    /// <summary>
    /// Characteristics which are specific to an individual measurement type (specified in a known order) at the given measurement site.
    /// <see href="http://vocab.datex.org/terms#MeasurementSpecificCharacteristics"></see></summary>
    let MeasurementSpecificCharacteristics =
        _prefix "MeasurementSpecificCharacteristics"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementSpecificCharacteristicsExtension"></see>
    /// </summary>
    let measurementSpecificCharacteristicsExtension =
        _prefix "measurementSpecificCharacteristicsExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#period"></see>
    /// </summary>
    let period = _prefix "period"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#specificLane"></see>
    /// </summary>
    let specificLane = _prefix "specificLane"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#specificMeasurementValueType"></see>
    /// </summary>
    let specificMeasurementValueType = _prefix "specificMeasurementValueType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#specificVehicleCharacteristics"></see>
    /// </summary>
    let specificVehicleCharacteristics = _prefix "specificVehicleCharacteristics"
    /// <summary>
    /// A measured or calculated value of concentration of a substance in micrograms per unit volume.
    /// <see href="http://vocab.datex.org/terms#MicrogramsConcentrationValue"></see></summary>
    let MicrogramsConcentrationValue = _prefix "MicrogramsConcentrationValue"
    /// <summary>
    /// A value of the amount of a substance in a given volume (concentration) expressed in µg/m3 (microgrammes/cubic metre).
    /// <see href="http://vocab.datex.org/terms#microgramsConcentration"></see></summary>
    let microgramsConcentration = _prefix "microgramsConcentration"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#microgramsConcentrationValueExtension"></see>
    /// </summary>
    let microgramsConcentrationValueExtension =
        _prefix "microgramsConcentrationValueExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#mobilityExtension"></see>
    /// </summary>
    let mobilityExtension = _prefix "mobilityExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#mobilityType"></see>
    /// </summary>
    let mobilityType = _prefix "mobilityType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#values"></see>
    /// </summary>
    let values = _prefix "values"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#valuesType"></see>
    /// </summary>
    let valuesType = _prefix "valuesType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#MultilingualStringValue"></see>
    /// </summary>
    let MultilingualStringValue = _prefix "MultilingualStringValue"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#lang"></see>
    /// </summary>
    let lang = _prefix "lang"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#areaName"></see>
    /// </summary>
    let areaName = _prefix "areaName"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#county"></see>
    /// </summary>
    let county = _prefix "county"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#namedAreaExtension"></see>
    /// </summary>
    let namedAreaExtension = _prefix "namedAreaExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#nation"></see>
    /// </summary>
    let nation = _prefix "nation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#policeForceControlArea"></see>
    /// </summary>
    let policeForceControlArea = _prefix "policeForceControlArea"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#roadOperatorControlArea"></see>
    /// </summary>
    let roadOperatorControlArea = _prefix "roadOperatorControlArea"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#destination"></see>
    /// </summary>
    let destination = _prefix "destination"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#networkLocationExtension"></see>
    /// </summary>
    let networkLocationExtension = _prefix "networkLocationExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#supplementaryPositionalDescription"></see>
    /// </summary>
    let supplementaryPositionalDescription =
        _prefix "supplementaryPositionalDescription"

    /// <summary>
    /// A collection of supplementary positional information which improves the precision of the location.
    /// <see href="http://vocab.datex.org/terms#SupplementaryPositionalDescription"></see></summary>
    let SupplementaryPositionalDescription =
        _prefix "SupplementaryPositionalDescription"

    /// <summary>
    /// The ultimate traffic direction to which the network management is applicable.
    /// <see href="http://vocab.datex.org/terms#applicableForTrafficDirection"></see></summary>
    let applicableForTrafficDirection = _prefix "applicableForTrafficDirection"
    /// <summary>
    /// The type of traffic to which the network management is applicable.
    /// <see href="http://vocab.datex.org/terms#applicableForTrafficType"></see></summary>
    let applicableForTrafficType = _prefix "applicableForTrafficType"
    /// <summary>
    /// Defines whether the network management is initiated by an automatic system.
    /// <see href="http://vocab.datex.org/terms#automaticallyInitiated"></see></summary>
    let automaticallyInitiated = _prefix "automaticallyInitiated"
    /// <summary>
    /// Defines whether the network management instruction or the control resulting from a network management action is advisory or mandatory.
    /// <see href="http://vocab.datex.org/terms#complianceOption"></see></summary>
    let complianceOption = _prefix "complianceOption"
    /// <summary>
    /// The characteristics of those vehicles for which the network management is applicable.
    /// Used to define the vehicle characteristics to which the TrafficValue is applicable primarily in Elaborated Data Publications, but may also be used in Measured Data Publications to override vehicle characteristics defined for the measurement site.
    /// <see href="http://vocab.datex.org/terms#forVehiclesWithCharacteristicsOf"></see></summary>
    let forVehiclesWithCharacteristicsOf = _prefix "forVehiclesWithCharacteristicsOf"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#networkManagementExtension"></see>
    /// </summary>
    let networkManagementExtension = _prefix "networkManagementExtension"
    /// <summary>
    /// Places, in generic terms, at which the network management applies.
    /// <see href="http://vocab.datex.org/terms#placesAtWhichApplicable"></see></summary>
    let placesAtWhichApplicable = _prefix "placesAtWhichApplicable"
    /// <summary>
    /// A cause of this situation record which is not managed by the publication creator, i.e. one which is not represented by another situation record produced by the same publication creator.
    /// <see href="http://vocab.datex.org/terms#NonManagedCause"></see></summary>
    let NonManagedCause = _prefix "NonManagedCause"
    /// <summary>
    /// Description of a cause which is not managed by the publication creator (e.g. an off network cause).
    /// <see href="http://vocab.datex.org/terms#causeDescription"></see></summary>
    let causeDescription = _prefix "causeDescription"
    /// <summary>
    /// Indicates an external influence that may be the causation of components of a situation.
    /// <see href="http://vocab.datex.org/terms#causeType"></see></summary>
    let causeType = _prefix "causeType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#nonManagedCauseExtension"></see>
    /// </summary>
    let nonManagedCauseExtension = _prefix "nonManagedCauseExtension"
    /// <summary>
    /// A group of (i.e. more than one) physically separate locations which have no specific order and where each location is explicitly listed.
    /// <see href="http://vocab.datex.org/terms#NonOrderedLocationGroupByList"></see></summary>
    let NonOrderedLocationGroupByList = _prefix "NonOrderedLocationGroupByList"
    /// <summary>
    /// A location contained in a non ordered group of locations.
    /// <see href="http://vocab.datex.org/terms#locationContainedInGroup"></see></summary>
    let locationContainedInGroup = _prefix "locationContainedInGroup"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#nonOrderedLocationGroupByListExtension"></see>
    /// </summary>
    let nonOrderedLocationGroupByListExtension =
        _prefix "nonOrderedLocationGroupByListExtension"

    /// <summary>
    /// Multiple (i.e. more than one) physically separate locations which have no specific order.
    /// <see href="http://vocab.datex.org/terms#NonOrderedLocations"></see></summary>
    let NonOrderedLocations = _prefix "NonOrderedLocations"

    /// <summary>
    /// A group of (i.e. more than one) physically separate locations which have no specific order that are defined by reference to a predefined non ordered location group.
    /// <see href="http://vocab.datex.org/terms#NonOrderedLocationGroupByReference"></see></summary>
    let NonOrderedLocationGroupByReference =
        _prefix "NonOrderedLocationGroupByReference"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#nonOrderedLocationGroupByReferenceExtension"></see>
    /// </summary>
    let nonOrderedLocationGroupByReferenceExtension =
        _prefix "nonOrderedLocationGroupByReferenceExtension"

    /// <summary>
    /// A reference to a versioned instance of a predefined non ordered location group as specified in a PredefinedLocationsPublication.
    /// <see href="http://vocab.datex.org/terms#predefinedNonOrderedLocationGroupReference"></see></summary>
    let predefinedNonOrderedLocationGroupReference =
        _prefix "predefinedNonOrderedLocationGroupReference"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_PredefinedNonOrderedLocationGroupVersionedReference"></see>
    /// </summary>
    let _PredefinedNonOrderedLocationGroupVersionedReference =
        _prefix "_PredefinedNonOrderedLocationGroupVersionedReference"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#nonOrderedLocationsExtension"></see>
    /// </summary>
    let nonOrderedLocationsExtension = _prefix "nonOrderedLocationsExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#nonRoadEventInformationExtension"></see>
    /// </summary>
    let nonRoadEventInformationExtension = _prefix "nonRoadEventInformationExtension"
    /// <summary>
    /// Road surface conditions that are not related to the weather but which may affect driving conditions.
    /// <see href="http://vocab.datex.org/terms#NonWeatherRelatedRoadConditions"></see></summary>
    let NonWeatherRelatedRoadConditions = _prefix "NonWeatherRelatedRoadConditions"

    /// <summary>
    /// The type of road conditions which are not related to the weather.
    /// <see href="http://vocab.datex.org/terms#nonWeatherRelatedRoadConditionType"></see></summary>
    let nonWeatherRelatedRoadConditionType =
        _prefix "nonWeatherRelatedRoadConditionType"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#nonWeatherRelatedRoadConditionsExtension"></see>
    /// </summary>
    let nonWeatherRelatedRoadConditionsExtension =
        _prefix "nonWeatherRelatedRoadConditionsExtension"

    /// <summary>
    /// Conditions of the road surface which may affect driving conditions. These may be related to the weather (e.g. ice, snow etc.) or to other conditions (e.g. oil, mud, leaves etc. on the road)
    /// <see href="http://vocab.datex.org/terms#RoadConditions"></see></summary>
    let RoadConditions = _prefix "RoadConditions"
    /// <summary>
    /// Number of axles characteristic of a vehicle.
    /// <see href="http://vocab.datex.org/terms#NumberOfAxlesCharacteristic"></see></summary>
    let NumberOfAxlesCharacteristic = _prefix "NumberOfAxlesCharacteristic"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#numberOfAxles"></see>
    /// </summary>
    let numberOfAxles = _prefix "numberOfAxles"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#numberOfAxlesCharacteristicExtension"></see>
    /// </summary>
    let numberOfAxlesCharacteristicExtension =
        _prefix "numberOfAxlesCharacteristicExtension"

    /// <summary>
    /// The mobility of the obstruction.
    /// <see href="http://vocab.datex.org/terms#mobilityOfObstruction"></see></summary>
    let mobilityOfObstruction = _prefix "mobilityOfObstruction"
    /// <summary>
    /// The number of obstructions that are partly or wholly blocking the road.
    /// <see href="http://vocab.datex.org/terms#numberOfObstructions"></see></summary>
    let numberOfObstructions = _prefix "numberOfObstructions"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#obstructionExtension"></see>
    /// </summary>
    let obstructionExtension = _prefix "obstructionExtension"
    /// <summary>
    /// A measured or calculated value of change of occupied parking spaces expressed as integer.
    /// <see href="http://vocab.datex.org/terms#OccupancyChangeValue"></see></summary>
    let OccupancyChangeValue = _prefix "OccupancyChangeValue"
    /// <summary>
    /// A measured or calculated absolut change of occupied parking spaces within a specified time expressed as integer.
    /// <see href="http://vocab.datex.org/terms#occupancyChange"></see></summary>
    let occupancyChange = _prefix "occupancyChange"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#occupancyChangeValueExtension"></see>
    /// </summary>
    let occupancyChangeValueExtension = _prefix "occupancyChangeValueExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#offsetDistanceExtension"></see>
    /// </summary>
    let offsetDistanceExtension = _prefix "offsetDistanceExtension"
    /// <summary>
    /// A specification of opening times (e.g. for a parking site, a service facility, an access or the availability for equipment).
    /// <see href="http://vocab.datex.org/terms#OpeningTimes"></see></summary>
    let OpeningTimes = _prefix "OpeningTimes"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#lastUpdated"></see>
    /// </summary>
    let lastUpdated = _prefix "lastUpdated"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openAllYear"></see>
    /// </summary>
    let openAllYear = _prefix "openAllYear"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openingTimesExtension"></see>
    /// </summary>
    let openingTimesExtension = _prefix "openingTimesExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openingTimesNotSpecified"></see>
    /// </summary>
    let openingTimesNotSpecified = _prefix "openingTimesNotSpecified"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openingTimesUnknown"></see>
    /// </summary>
    let openingTimesUnknown = _prefix "openingTimesUnknown"
    /// <summary>
    /// a two-dimensional part of the surface of the earth which is bounded by a closed curve. An area location may cover parts of the road network but does not necessarily need to. It is represente according to the OpenLR standard for Area Locations
    /// <see href="http://vocab.datex.org/terms#OpenlrAreaLocationReference"></see></summary>
    let OpenlrAreaLocationReference = _prefix "OpenlrAreaLocationReference"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrAreaLocationReferenceExtension"></see>
    /// </summary>
    let openlrAreaLocationReferenceExtension =
        _prefix "openlrAreaLocationReferenceExtension"

    /// <summary>
    /// Base class used to hold data about a reference point.
    /// <see href="http://vocab.datex.org/terms#OpenlrBaseLocationReferencePoint"></see></summary>
    let OpenlrBaseLocationReferencePoint = _prefix "OpenlrBaseLocationReferencePoint"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrBaseLocationReferencePointExtension"></see>
    /// </summary>
    let openlrBaseLocationReferencePointExtension =
        _prefix "openlrBaseLocationReferencePointExtension"

    /// <summary>
    /// The coordinate of the actual point of interest
    /// <see href="http://vocab.datex.org/terms#openlrCoordinate"></see></summary>
    let openlrCoordinate = _prefix "openlrCoordinate"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrLineAttributes"></see>
    /// </summary>
    let openlrLineAttributes = _prefix "openlrLineAttributes"
    /// <summary>
    /// Line attributes are part of a location reference point and consists of functional road class (FRC),form of way (FOW) and bearing (BEAR) data.
    /// <see href="http://vocab.datex.org/terms#OpenlrLineAttributes"></see></summary>
    let OpenlrLineAttributes = _prefix "OpenlrLineAttributes"
    /// <summary>
    /// Holds common data that are used both in OpenlrPointAccessPoint and OpenlrPointAlongLine.
    /// <see href="http://vocab.datex.org/terms#OpenlrBasePointLocation"></see></summary>
    let OpenlrBasePointLocation = _prefix "OpenlrBasePointLocation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrBasePointLocationExtension"></see>
    /// </summary>
    let openlrBasePointLocationExtension = _prefix "openlrBasePointLocationExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrLastLocationReferencePoint"></see>
    /// </summary>
    let openlrLastLocationReferencePoint = _prefix "openlrLastLocationReferencePoint"
    /// <summary>
    /// The sequence of location reference points is terminated by a last location reference point.
    /// <see href="http://vocab.datex.org/terms#OpenlrLastLocationReferencePoint"></see></summary>
    let OpenlrLastLocationReferencePoint = _prefix "OpenlrLastLocationReferencePoint"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrLocationReferencePoint"></see>
    /// </summary>
    let openlrLocationReferencePoint = _prefix "openlrLocationReferencePoint"
    /// <summary>
    /// The basis of a location reference is a sequence of location reference points (LRPs).
    /// <see href="http://vocab.datex.org/terms#OpenlrLocationReferencePoint"></see></summary>
    let OpenlrLocationReferencePoint = _prefix "OpenlrLocationReferencePoint"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrOrientation"></see>
    /// </summary>
    let openlrOrientation = _prefix "openlrOrientation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrPositiveOffset"></see>
    /// </summary>
    let openlrPositiveOffset = _prefix "openlrPositiveOffset"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrSideOfRoad"></see>
    /// </summary>
    let openlrSideOfRoad = _prefix "openlrSideOfRoad"
    /// <summary>
    /// the openLR method of areadefinition by providing a center position and a radius
    /// <see href="http://vocab.datex.org/terms#OpenlrCircleLocationReference"></see></summary>
    let OpenlrCircleLocationReference = _prefix "OpenlrCircleLocationReference"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrCircleLocationReferenceExtension"></see>
    /// </summary>
    let openlrCircleLocationReferenceExtension =
        _prefix "openlrCircleLocationReferenceExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrGeoCoordinate"></see>
    /// </summary>
    let openlrGeoCoordinate = _prefix "openlrGeoCoordinate"
    /// <summary>
    /// A geo-coordinate pair is a position in a map defined by its longitude and latitude coordinate values.
    /// <see href="http://vocab.datex.org/terms#OpenlrGeoCoordinate"></see></summary>
    let OpenlrGeoCoordinate = _prefix "OpenlrGeoCoordinate"
    /// <summary>
    /// The radius of the geometric area identified.
    /// <see href="http://vocab.datex.org/terms#radius"></see></summary>
    let radius = _prefix "radius"
    /// <summary>
    /// the openLR method of areadefinition by providing a closed path (i.e. a circuit) in the road network. The boundary always consists of road segments
    /// <see href="http://vocab.datex.org/terms#OpenlrClosedLineLocationReference"></see></summary>
    let OpenlrClosedLineLocationReference = _prefix "OpenlrClosedLineLocationReference"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrClosedLineLocationReferenceExtension"></see>
    /// </summary>
    let openlrClosedLineLocationReferenceExtension =
        _prefix "openlrClosedLineLocationReferenceExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrLastLine"></see>
    /// </summary>
    let openlrLastLine = _prefix "openlrLastLine"
    /// <summary>
    /// Extension to provide Area information in openLR format
    /// <see href="http://vocab.datex.org/terms#OpenlrExtendedArea"></see></summary>
    let OpenlrExtendedArea = _prefix "OpenlrExtendedArea"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrAreaLocationReference"></see>
    /// </summary>
    let openlrAreaLocationReference = _prefix "openlrAreaLocationReference"
    /// <summary>
    /// Extension class for OpenLR Line location reference
    /// <see href="http://vocab.datex.org/terms#OpenlrExtendedLinear"></see></summary>
    let OpenlrExtendedLinear = _prefix "OpenlrExtendedLinear"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#firstDirection"></see>
    /// </summary>
    let firstDirection = _prefix "firstDirection"
    /// <summary>
    /// A LineLocationReference is defined by an ordered sequence of location reference points and a terminating last location reference point.
    /// <see href="http://vocab.datex.org/terms#OpenlrLineLocationReference"></see></summary>
    let OpenlrLineLocationReference = _prefix "OpenlrLineLocationReference"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#oppositeDirection"></see>
    /// </summary>
    let oppositeDirection = _prefix "oppositeDirection"
    /// <summary>
    /// Extension class for OpenLR point.
    /// <see href="http://vocab.datex.org/terms#OpenlrExtendedPoint"></see></summary>
    let OpenlrExtendedPoint = _prefix "OpenlrExtendedPoint"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrPointLocationReference"></see>
    /// </summary>
    let openlrPointLocationReference = _prefix "openlrPointLocationReference"
    /// <summary>
    /// A point location is a zero-dimensional element in a map that specifies a geometric location.
    /// <see href="http://vocab.datex.org/terms#OpenlrPointLocationReference"></see></summary>
    let OpenlrPointLocationReference = _prefix "OpenlrPointLocationReference"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrGeoCoordinateExtension"></see>
    /// </summary>
    let openlrGeoCoordinateExtension = _prefix "openlrGeoCoordinateExtension"
    /// <summary>
    /// attributes required for the grid method
    /// <see href="http://vocab.datex.org/terms#OpenlrGridAttributes"></see></summary>
    let OpenlrGridAttributes = _prefix "OpenlrGridAttributes"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrGridAttributesExtension"></see>
    /// </summary>
    let openlrGridAttributesExtension = _prefix "openlrGridAttributesExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrNumColumns"></see>
    /// </summary>
    let openlrNumColumns = _prefix "openlrNumColumns"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrNumRows"></see>
    /// </summary>
    let openlrNumRows = _prefix "openlrNumRows"
    /// <summary>
    /// the openLR method of areadefinition by providing repeating rectangles
    /// <see href="http://vocab.datex.org/terms#OpenlrGridLocationReference"></see></summary>
    let OpenlrGridLocationReference = _prefix "OpenlrGridLocationReference"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrGridAttributes"></see>
    /// </summary>
    let openlrGridAttributes = _prefix "openlrGridAttributes"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrGridLocationReferenceExtension"></see>
    /// </summary>
    let openlrGridLocationReferenceExtension =
        _prefix "openlrGridLocationReferenceExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrRectangle"></see>
    /// </summary>
    let openlrRectangle = _prefix "openlrRectangle"
    /// <summary>
    /// two geo-coordinate pairs defining the rectangular
    /// <see href="http://vocab.datex.org/terms#OpenlrRectangle"></see></summary>
    let OpenlrRectangle = _prefix "OpenlrRectangle"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrLastLocationReferencePointExtension"></see>
    /// </summary>
    let openlrLastLocationReferencePointExtension =
        _prefix "openlrLastLocationReferencePointExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrBearing"></see>
    /// </summary>
    let openlrBearing = _prefix "openlrBearing"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrFormOfWay"></see>
    /// </summary>
    let openlrFormOfWay = _prefix "openlrFormOfWay"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrFunctionalRoadClass"></see>
    /// </summary>
    let openlrFunctionalRoadClass = _prefix "openlrFunctionalRoadClass"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrLineAttributesExtension"></see>
    /// </summary>
    let openlrLineAttributesExtension = _prefix "openlrLineAttributesExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrLineLocationReferenceExtension"></see>
    /// </summary>
    let openlrLineLocationReferenceExtension =
        _prefix "openlrLineLocationReferenceExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrOffsets"></see>
    /// </summary>
    let openlrOffsets = _prefix "openlrOffsets"
    /// <summary>
    /// Offsets are used to locate the start and end of a location more precisely than bounding to the nodes in a network.
    /// <see href="http://vocab.datex.org/terms#OpenlrOffsets"></see></summary>
    let OpenlrOffsets = _prefix "OpenlrOffsets"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrLocationReferencePointExtension"></see>
    /// </summary>
    let openlrLocationReferencePointExtension =
        _prefix "openlrLocationReferencePointExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrPathAttributes"></see>
    /// </summary>
    let openlrPathAttributes = _prefix "openlrPathAttributes"
    /// <summary>
    /// The field path attributes is part of a location reference point (except for the last location reference point) and consists of lowest functional road class (LFRCNP) and distance to next point (DNP) data.
    /// <see href="http://vocab.datex.org/terms#OpenlrPathAttributes"></see></summary>
    let OpenlrPathAttributes = _prefix "OpenlrPathAttributes"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrNegativeOffset"></see>
    /// </summary>
    let openlrNegativeOffset = _prefix "openlrNegativeOffset"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrOffsetsExtension"></see>
    /// </summary>
    let openlrOffsetsExtension = _prefix "openlrOffsetsExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrDistanceToNextLRPoint"></see>
    /// </summary>
    let openlrDistanceToNextLRPoint = _prefix "openlrDistanceToNextLRPoint"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrLowestFRCToNextLRPoint"></see>
    /// </summary>
    let openlrLowestFRCToNextLRPoint = _prefix "openlrLowestFRCToNextLRPoint"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrPathAttributesExtension"></see>
    /// </summary>
    let openlrPathAttributesExtension = _prefix "openlrPathAttributesExtension"
    /// <summary>
    /// Point along line with access is a point location which is defined by a line,an offset value and a coordinate.
    /// <see href="http://vocab.datex.org/terms#OpenlrPoiWithAccessPoint"></see></summary>
    let OpenlrPoiWithAccessPoint = _prefix "OpenlrPoiWithAccessPoint"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrPoiWithAccessPointExtension"></see>
    /// </summary>
    let openlrPoiWithAccessPointExtension = _prefix "openlrPoiWithAccessPointExtension"
    /// <summary>
    /// Point along a line
    /// <see href="http://vocab.datex.org/terms#OpenlrPointAlongLine"></see></summary>
    let OpenlrPointAlongLine = _prefix "OpenlrPointAlongLine"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrPointAlongLineExtension"></see>
    /// </summary>
    let openlrPointAlongLineExtension = _prefix "openlrPointAlongLineExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrPoiWithAccessPoint"></see>
    /// </summary>
    let openlrPoiWithAccessPoint = _prefix "openlrPoiWithAccessPoint"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrPointAlongLine"></see>
    /// </summary>
    let openlrPointAlongLine = _prefix "openlrPointAlongLine"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrPointLocationReferenceExtension"></see>
    /// </summary>
    let openlrPointLocationReferenceExtension =
        _prefix "openlrPointLocationReferenceExtension"

    /// <summary>
    /// geo-coordinate pairs. The coordinate pairs defining the corners of the underlying geometrical polygon.
    /// <see href="http://vocab.datex.org/terms#OpenlrPolygonCorners"></see></summary>
    let OpenlrPolygonCorners = _prefix "OpenlrPolygonCorners"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrPolygonCornersExtension"></see>
    /// </summary>
    let openlrPolygonCornersExtension = _prefix "openlrPolygonCornersExtension"
    /// <summary>
    /// the openLR method of areadefinition by providing points that bound the area
    /// <see href="http://vocab.datex.org/terms#OpenlrPolygonLocationReference"></see></summary>
    let OpenlrPolygonLocationReference = _prefix "OpenlrPolygonLocationReference"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrPolygonCorners"></see>
    /// </summary>
    let openlrPolygonCorners = _prefix "openlrPolygonCorners"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrPolygonLocationReferenceExtension"></see>
    /// </summary>
    let openlrPolygonLocationReferenceExtension =
        _prefix "openlrPolygonLocationReferenceExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrLowerLeft"></see>
    /// </summary>
    let openlrLowerLeft = _prefix "openlrLowerLeft"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrRectangleExtension"></see>
    /// </summary>
    let openlrRectangleExtension = _prefix "openlrRectangleExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrUpperRight"></see>
    /// </summary>
    let openlrUpperRight = _prefix "openlrUpperRight"
    /// <summary>
    /// the openLR method of areadefinition by providing a rectangular shape defined by two geo-coordinate pairs
    /// <see href="http://vocab.datex.org/terms#OpenlrRectangleLocationReference"></see></summary>
    let OpenlrRectangleLocationReference = _prefix "OpenlrRectangleLocationReference"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrRectangleLocationReferenceExtension"></see>
    /// </summary>
    let openlrRectangleLocationReferenceExtension =
        _prefix "openlrRectangleLocationReferenceExtension"

    /// <summary>
    /// Indicates whether the actions to be undertaken by the operator are the result of an internal operation or external influence.
    /// <see href="http://vocab.datex.org/terms#actionOrigin"></see></summary>
    let actionOrigin = _prefix "actionOrigin"
    /// <summary>
    /// The identifier of the traffic management action plan to which this action relates.
    /// <see href="http://vocab.datex.org/terms#actionPlanIdentifier"></see></summary>
    let actionPlanIdentifier = _prefix "actionPlanIdentifier"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#operatorActionExtension"></see>
    /// </summary>
    let operatorActionExtension = _prefix "operatorActionExtension"
    /// <summary>
    /// The status of the defined operator action.
    /// <see href="http://vocab.datex.org/terms#operatorActionStatus"></see></summary>
    let operatorActionStatus = _prefix "operatorActionStatus"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#exceptionPeriod"></see>
    /// </summary>
    let exceptionPeriod = _prefix "exceptionPeriod"
    /// <summary>
    /// A continuous time period or a set of discontinuous time periods defined by the intersection of a set of criteria all within an overall delimiting interval.
    /// <see href="http://vocab.datex.org/terms#Period"></see></summary>
    let Period = _prefix "Period"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#overallEndTime"></see>
    /// </summary>
    let overallEndTime = _prefix "overallEndTime"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#overallPeriodExtension"></see>
    /// </summary>
    let overallPeriodExtension = _prefix "overallPeriodExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#overallStartTime"></see>
    /// </summary>
    let overallStartTime = _prefix "overallStartTime"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#validPeriod"></see>
    /// </summary>
    let validPeriod = _prefix "validPeriod"
    /// <summary>
    /// Describes one entrance or exit (or both) to a parking site.
    /// <see href="http://vocab.datex.org/terms#ParkingAccess"></see></summary>
    let ParkingAccess = _prefix "ParkingAccess"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#accessAssignedAmongOthers"></see>
    /// </summary>
    let accessAssignedAmongOthers = _prefix "accessAssignedAmongOthers"
    /// <summary>
    /// One set of prohibited/only allowed/convenient assignment for parking space(s), parking site(s) or an access. Same kind of data forms a union (e.g. lorries OR buses), different kind of data forms an intersection (e.g. residents AND long-term).
    /// <see href="http://vocab.datex.org/terms#ParkingAssignment"></see></summary>
    let ParkingAssignment = _prefix "ParkingAssignment"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#accessCategory"></see>
    /// </summary>
    let accessCategory = _prefix "accessCategory"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#accessEquipment"></see>
    /// </summary>
    let accessEquipment = _prefix "accessEquipment"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#accessName"></see>
    /// </summary>
    let accessName = _prefix "accessName"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#accessOnlyAssignedFor"></see>
    /// </summary>
    let accessOnlyAssignedFor = _prefix "accessOnlyAssignedFor"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#accessProhibitedFor"></see>
    /// </summary>
    let accessProhibitedFor = _prefix "accessProhibitedFor"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#accessibility"></see>
    /// </summary>
    let accessibility = _prefix "accessibility"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#location"></see>
    /// </summary>
    let location = _prefix "location"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openingTimes"></see>
    /// </summary>
    let openingTimes = _prefix "openingTimes"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingAccessExtension"></see>
    /// </summary>
    let parkingAccessExtension = _prefix "parkingAccessExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#photoUrl"></see>
    /// </summary>
    let photoUrl = _prefix "photoUrl"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#primaryRoad"></see>
    /// </summary>
    let primaryRoad = _prefix "primaryRoad"
    /// <summary>
    /// The opening and fault status of one access.
    /// <see href="http://vocab.datex.org/terms#ParkingAccessStatus"></see></summary>
    let ParkingAccessStatus = _prefix "ParkingAccessStatus"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#accessFault"></see>
    /// </summary>
    let accessFault = _prefix "accessFault"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#accessOpeningStatus"></see>
    /// </summary>
    let accessOpeningStatus = _prefix "accessOpeningStatus"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#accessReference"></see>
    /// </summary>
    let accessReference = _prefix "accessReference"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingAccessStatusExtension"></see>
    /// </summary>
    let parkingAccessStatusExtension = _prefix "parkingAccessStatusExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#hazardousMaterials"></see>
    /// </summary>
    let hazardousMaterials = _prefix "hazardousMaterials"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingAssignmentExtension"></see>
    /// </summary>
    let parkingAssignmentExtension = _prefix "parkingAssignmentExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingDuration"></see>
    /// </summary>
    let parkingDuration = _prefix "parkingDuration"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#timePeriodByHour"></see>
    /// </summary>
    let timePeriodByHour = _prefix "timePeriodByHour"
    /// <summary>
    /// Specification of a continuous period within a 24 hour period by times.
    /// <see href="http://vocab.datex.org/terms#TimePeriodByHour"></see></summary>
    let TimePeriodByHour = _prefix "TimePeriodByHour"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#additionalDescription"></see>
    /// </summary>
    let additionalDescription = _prefix "additionalDescription"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#availability"></see>
    /// </summary>
    let availability = _prefix "availability"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#availabilityAndOpeningTimes"></see>
    /// </summary>
    let availabilityAndOpeningTimes = _prefix "availabilityAndOpeningTimes"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#equipmentOrServiceFacilityIdentifier"></see>
    /// </summary>
    let equipmentOrServiceFacilityIdentifier =
        _prefix "equipmentOrServiceFacilityIdentifier"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#nameOrBrand"></see>
    /// </summary>
    let nameOrBrand = _prefix "nameOrBrand"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#numberOfEquipmentOrServiceFacility"></see>
    /// </summary>
    let numberOfEquipmentOrServiceFacility =
        _prefix "numberOfEquipmentOrServiceFacility"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#otherEquipmentOrServiceFacility"></see>
    /// </summary>
    let otherEquipmentOrServiceFacility = _prefix "otherEquipmentOrServiceFacility"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingEquipmentOrServiceFacilityExtension"></see>
    /// </summary>
    let parkingEquipmentOrServiceFacilityExtension =
        _prefix "parkingEquipmentOrServiceFacilityExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tariffsAndPayment"></see>
    /// </summary>
    let tariffsAndPayment = _prefix "tariffsAndPayment"
    /// <summary>
    /// A table of charges under various conditions, primary used for parking.
    /// <see href="http://vocab.datex.org/terms#TariffsAndPayment"></see></summary>
    let TariffsAndPayment = _prefix "TariffsAndPayment"

    /// <summary>
    /// The number of E&amp;S can be overridden here (for example during restoration). Furthermore, the current availability of E&amp;S can be given (for example number of free electric charging stations). The E&amp;S are identified from the static model by an index.
    /// <see href="http://vocab.datex.org/terms#ParkingEquipmentOrServiceFacilityStatus"></see></summary>
    let ParkingEquipmentOrServiceFacilityStatus =
        _prefix "ParkingEquipmentOrServiceFacilityStatus"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#equipmentOperationStatus"></see>
    /// </summary>
    let equipmentOperationStatus = _prefix "equipmentOperationStatus"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#numberOfEquipmentOrServiceFacilityOverride"></see>
    /// </summary>
    let numberOfEquipmentOrServiceFacilityOverride =
        _prefix "numberOfEquipmentOrServiceFacilityOverride"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#numberOfSubitemsOverride"></see>
    /// </summary>
    let numberOfSubitemsOverride = _prefix "numberOfSubitemsOverride"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingEquipmentOrServiceFacilityStatusExtension"></see>
    /// </summary>
    let parkingEquipmentOrServiceFacilityStatusExtension =
        _prefix "parkingEquipmentOrServiceFacilityStatusExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#serviceFacilityOpeningStatus"></see>
    /// </summary>
    let serviceFacilityOpeningStatus = _prefix "serviceFacilityOpeningStatus"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vacantEquipmentOrServiceFacilitySubitems"></see>
    /// </summary>
    let vacantEquipmentOrServiceFacilitySubitems =
        _prefix "vacantEquipmentOrServiceFacilitySubitems"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingNotAllowed"></see>
    /// </summary>
    let parkingNotAllowed = _prefix "parkingNotAllowed"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingNumberOfOccupiedSpaces"></see>
    /// </summary>
    let parkingNumberOfOccupiedSpaces = _prefix "parkingNumberOfOccupiedSpaces"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingNumberOfSpacesOverride"></see>
    /// </summary>
    let parkingNumberOfSpacesOverride = _prefix "parkingNumberOfSpacesOverride"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingNumberOfVacantSpaces"></see>
    /// </summary>
    let parkingNumberOfVacantSpaces = _prefix "parkingNumberOfVacantSpaces"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingNumberOfVacantSpacesGraded"></see>
    /// </summary>
    let parkingNumberOfVacantSpacesGraded = _prefix "parkingNumberOfVacantSpacesGraded"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingNumberOfVacantSpacesHigherThan"></see>
    /// </summary>
    let parkingNumberOfVacantSpacesHigherThan =
        _prefix "parkingNumberOfVacantSpacesHigherThan"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingNumberOfVacantSpacesLowerThan"></see>
    /// </summary>
    let parkingNumberOfVacantSpacesLowerThan =
        _prefix "parkingNumberOfVacantSpacesLowerThan"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingNumberOfVehicles"></see>
    /// </summary>
    let parkingNumberOfVehicles = _prefix "parkingNumberOfVehicles"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingOccupancy"></see>
    /// </summary>
    let parkingOccupancy = _prefix "parkingOccupancy"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingOccupancyExtension"></see>
    /// </summary>
    let parkingOccupancyExtension = _prefix "parkingOccupancyExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingOccupancyGraded"></see>
    /// </summary>
    let parkingOccupancyGraded = _prefix "parkingOccupancyGraded"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingOccupancyTrend"></see>
    /// </summary>
    let parkingOccupancyTrend = _prefix "parkingOccupancyTrend"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleCountAndRate"></see>
    /// </summary>
    let vehicleCountAndRate = _prefix "vehicleCountAndRate"
    /// <summary>
    /// Vehicle rates can be assigned to a parking site or to assigned parking spaces. Furthermore, they can reference to a measurement site or to an entrance/exit.
    /// <see href="http://vocab.datex.org/terms#VehicleCountAndRate"></see></summary>
    let VehicleCountAndRate = _prefix "VehicleCountAndRate"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingPermitExtension"></see>
    /// </summary>
    let parkingPermitExtension = _prefix "parkingPermitExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingPermitIdentifier"></see>
    /// </summary>
    let parkingPermitIdentifier = _prefix "parkingPermitIdentifier"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingPermitScheme"></see>
    /// </summary>
    let parkingPermitScheme = _prefix "parkingPermitScheme"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingPermitType"></see>
    /// </summary>
    let parkingPermitType = _prefix "parkingPermitType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#assignedParkingAmongOthers"></see>
    /// </summary>
    let assignedParkingAmongOthers = _prefix "assignedParkingAmongOthers"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#emergencyAssemblyPoint"></see>
    /// </summary>
    let emergencyAssemblyPoint = _prefix "emergencyAssemblyPoint"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#emergencyContact"></see>
    /// </summary>
    let emergencyContact = _prefix "emergencyContact"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#entireArea"></see>
    /// </summary>
    let entireArea = _prefix "entireArea"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#groupOfParkingSpaces"></see>
    /// </summary>
    let groupOfParkingSpaces = _prefix "groupOfParkingSpaces"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_GroupOfParkingSpaces"></see>
    /// </summary>
    let _GroupOfParkingSpaces = _prefix "_GroupOfParkingSpaces"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maximumParkingDuration"></see>
    /// </summary>
    let maximumParkingDuration = _prefix "maximumParkingDuration"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#onlyAssignedParking"></see>
    /// </summary>
    let onlyAssignedParking = _prefix "onlyAssignedParking"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#operator"></see>
    /// </summary>
    let operator = _prefix "operator"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#owner"></see>
    /// </summary>
    let owner = _prefix "owner"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingAlias"></see>
    /// </summary>
    let parkingAlias = _prefix "parkingAlias"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingColour"></see>
    /// </summary>
    let parkingColour = _prefix "parkingColour"
    /// <summary>
    /// An RGB colour described by values for red, green and blue (0..255) as well as an optional name.
    /// <see href="http://vocab.datex.org/terms#RGBColour"></see></summary>
    let RGBColour = _prefix "RGBColour"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingDescription"></see>
    /// </summary>
    let parkingDescription = _prefix "parkingDescription"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingEquipmentOrServiceFacility"></see>
    /// </summary>
    let parkingEquipmentOrServiceFacility = _prefix "parkingEquipmentOrServiceFacility"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_ParkingRecordEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacility"></see>
    /// </summary>
    let _ParkingRecordEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacility =
        _prefix "_ParkingRecordEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacility"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingLocation"></see>
    /// </summary>
    let parkingLocation = _prefix "parkingLocation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingName"></see>
    /// </summary>
    let parkingName = _prefix "parkingName"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingOccupanyDetectionType"></see>
    /// </summary>
    let parkingOccupanyDetectionType = _prefix "parkingOccupanyDetectionType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingPrincipalNumberOfSpaces"></see>
    /// </summary>
    let parkingPrincipalNumberOfSpaces = _prefix "parkingPrincipalNumberOfSpaces"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingRecordDimension"></see>
    /// </summary>
    let parkingRecordDimension = _prefix "parkingRecordDimension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingRecordExtension"></see>
    /// </summary>
    let parkingRecordExtension = _prefix "parkingRecordExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingRecordVersionTime"></see>
    /// </summary>
    let parkingRecordVersionTime = _prefix "parkingRecordVersionTime"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingRoute"></see>
    /// </summary>
    let parkingRoute = _prefix "parkingRoute"
    /// <summary>
    /// A parking route, defined by ParkingRouteDetails or by a reference.
    /// <see href="http://vocab.datex.org/terms#ParkingRoute"></see></summary>
    let ParkingRoute = _prefix "ParkingRoute"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_ParkingSpace"></see>
    /// </summary>
    let _ParkingSpace = _prefix "_ParkingSpace"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingThresholds"></see>
    /// </summary>
    let parkingThresholds = _prefix "parkingThresholds"
    /// <summary>
    /// Configuration parameters of the parking site, used among others for the dynamic attribute 'parkingStatus'. This component or all elements of it can be overridden in the dynamic model.
    /// <see href="http://vocab.datex.org/terms#ParkingThresholds"></see></summary>
    let ParkingThresholds = _prefix "ParkingThresholds"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingVMS"></see>
    /// </summary>
    let parkingVMS = _prefix "parkingVMS"
    /// <summary>
    /// A reference to a record that contains the metadata for a specific VMS unit that may be used to manage the parking site (e.g. to indicate to drivers the current availability of spaces).
    /// <see href="http://vocab.datex.org/terms#ParkingVMS"></see></summary>
    let ParkingVMS = _prefix "ParkingVMS"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#permitsAndProhibitions"></see>
    /// </summary>
    let permitsAndProhibitions = _prefix "permitsAndProhibitions"
    /// <summary>
    /// Defines sets of action and regulations to specify permitted and prohibited issues.
    /// <see href="http://vocab.datex.org/terms#PermitsAndProhibitions"></see></summary>
    let PermitsAndProhibitions = _prefix "PermitsAndProhibitions"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#prohibitedParking"></see>
    /// </summary>
    let prohibitedParking = _prefix "prohibitedParking"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#responisbleAuthority"></see>
    /// </summary>
    let responisbleAuthority = _prefix "responisbleAuthority"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#securityService"></see>
    /// </summary>
    let securityService = _prefix "securityService"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#servicePartner"></see>
    /// </summary>
    let servicePartner = _prefix "servicePartner"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#blurredAvailability"></see>
    /// </summary>
    let blurredAvailability = _prefix "blurredAvailability"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#groupOfParkingSpacesStatus"></see>
    /// </summary>
    let groupOfParkingSpacesStatus = _prefix "groupOfParkingSpacesStatus"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_ParkingRecordStatusGroupIndexGroupOfParkingSpacesStatus"></see>
    /// </summary>
    let _ParkingRecordStatusGroupIndexGroupOfParkingSpacesStatus =
        _prefix "_ParkingRecordStatusGroupIndexGroupOfParkingSpacesStatus"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#overrideParkingThresholds"></see>
    /// </summary>
    let overrideParkingThresholds = _prefix "overrideParkingThresholds"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingAccessStatus"></see>
    /// </summary>
    let parkingAccessStatus = _prefix "parkingAccessStatus"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingConditions"></see>
    /// </summary>
    let parkingConditions = _prefix "parkingConditions"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingEquipmentOrServiceFacilityStatus"></see>
    /// </summary>
    let parkingEquipmentOrServiceFacilityStatus =
        _prefix "parkingEquipmentOrServiceFacilityStatus"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_ParkingRecordStatusEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacilityStatus"></see>
    /// </summary>
    let _ParkingRecordStatusEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacilityStatus =
        _prefix "_ParkingRecordStatusEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacilityStatus"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingFault"></see>
    /// </summary>
    let parkingFault = _prefix "parkingFault"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingQueueingTime"></see>
    /// </summary>
    let parkingQueueingTime = _prefix "parkingQueueingTime"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingRecordReference"></see>
    /// </summary>
    let parkingRecordReference = _prefix "parkingRecordReference"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingRecordStatusExtension"></see>
    /// </summary>
    let parkingRecordStatusExtension = _prefix "parkingRecordStatusExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingRouteStatus"></see>
    /// </summary>
    let parkingRouteStatus = _prefix "parkingRouteStatus"
    /// <summary>
    /// The status of a parking route (active/inactive) defined in the static part of the model.
    /// <see href="http://vocab.datex.org/terms#ParkingRouteStatus"></see></summary>
    let ParkingRouteStatus = _prefix "ParkingRouteStatus"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSpaceStatus"></see>
    /// </summary>
    let parkingSpaceStatus = _prefix "parkingSpaceStatus"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_ParkingRecordStatusParkingSpaceIndexParkingSpaceStatus"></see>
    /// </summary>
    let _ParkingRecordStatusParkingSpaceIndexParkingSpaceStatus =
        _prefix "_ParkingRecordStatusParkingSpaceIndexParkingSpaceStatus"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingStatusDescription"></see>
    /// </summary>
    let parkingStatusDescription = _prefix "parkingStatusDescription"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingStatusOriginTime"></see>
    /// </summary>
    let parkingStatusOriginTime = _prefix "parkingStatusOriginTime"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingStatusValidity"></see>
    /// </summary>
    let parkingStatusValidity = _prefix "parkingStatusValidity"
    /// <summary>
    /// To be used only for historical or forecasted data. Choose between an explicit point of time, an offset or all points of time within a specified period.
    /// <see href="http://vocab.datex.org/terms#ParkingStatusValidity"></see></summary>
    let ParkingStatusValidity = _prefix "ParkingStatusValidity"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingUsageScenarioStatus"></see>
    /// </summary>
    let parkingUsageScenarioStatus = _prefix "parkingUsageScenarioStatus"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_ParkingRecordStatusScenarioIndexParkingUsageScenarioStatus"></see>
    /// </summary>
    let _ParkingRecordStatusScenarioIndexParkingUsageScenarioStatus =
        _prefix "_ParkingRecordStatusScenarioIndexParkingUsageScenarioStatus"

    /// <summary>
    /// Type of winter equipment management action instigated by operator.
    /// <see href="http://vocab.datex.org/terms#winterEquipmentManagementType"></see></summary>
    let winterEquipmentManagementType = _prefix "winterEquipmentManagementType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingRouteColour"></see>
    /// </summary>
    let parkingRouteColour = _prefix "parkingRouteColour"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingRouteExtension"></see>
    /// </summary>
    let parkingRouteExtension = _prefix "parkingRouteExtension"
    /// <summary>
    /// A route defined by a reference to an earlier specified route.
    /// <see href="http://vocab.datex.org/terms#ParkingRouteByReference"></see></summary>
    let ParkingRouteByReference = _prefix "ParkingRouteByReference"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingRouteByReferenceExtension"></see>
    /// </summary>
    let parkingRouteByReferenceExtension = _prefix "parkingRouteByReferenceExtension"
    /// <summary>
    /// A reference to a parking route.
    /// <see href="http://vocab.datex.org/terms#parkingRouteReference"></see></summary>
    let parkingRouteReference = _prefix "parkingRouteReference"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_ParkingRouteDetailsVersionedReference"></see>
    /// </summary>
    let _ParkingRouteDetailsVersionedReference =
        _prefix "_ParkingRouteDetailsVersionedReference"

    /// <summary>
    /// Urban context: Defining parking routes leading to the parking site. Truck parking context: Can be used to define a dynamic route management.
    /// <see href="http://vocab.datex.org/terms#ParkingRouteDetails"></see></summary>
    let ParkingRouteDetails = _prefix "ParkingRouteDetails"
    /// <summary>
    /// Indicates that there is dynamic route management for truck parking, i.e. a management system concerning several truck parkings (including this one) along a route.
    /// <see href="http://vocab.datex.org/terms#dynamicRouteManagement"></see></summary>
    let dynamicRouteManagement = _prefix "dynamicRouteManagement"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingRouteDetailsExtension"></see>
    /// </summary>
    let parkingRouteDetailsExtension = _prefix "parkingRouteDetailsExtension"
    /// <summary>
    /// The direction of traffic, for which the parking route can be used. If not specified, the route can be used in the order of the given locations.
    /// <see href="http://vocab.datex.org/terms#parkingRouteDirection"></see></summary>
    let parkingRouteDirection = _prefix "parkingRouteDirection"
    /// <summary>
    /// Additional directions of traffic, for which the parking route can be used. If not specified, the route can be used in the order of the given locations.
    /// <see href="http://vocab.datex.org/terms#parkingRouteDirection2"></see></summary>
    let parkingRouteDirection2 = _prefix "parkingRouteDirection2"
    /// <summary>
    /// An index, which can identify some icon for visualisation of the route. Note that form and usage of this index as well as the icons itself are not further determined here.
    /// <see href="http://vocab.datex.org/terms#parkingRouteIconIndex"></see></summary>
    let parkingRouteIconIndex = _prefix "parkingRouteIconIndex"
    /// <summary>
    /// Name of the parking route.
    /// <see href="http://vocab.datex.org/terms#parkingRouteName"></see></summary>
    let parkingRouteName = _prefix "parkingRouteName"
    /// <summary>
    /// The type of parking route. If not specified, the route is designed for any type of vehicles.
    /// <see href="http://vocab.datex.org/terms#parkingRouteType"></see></summary>
    let parkingRouteType = _prefix "parkingRouteType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingRouteActive"></see>
    /// </summary>
    let parkingRouteActive = _prefix "parkingRouteActive"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingRouteStatusExtension"></see>
    /// </summary>
    let parkingRouteStatusExtension = _prefix "parkingRouteStatusExtension"
    /// <summary>
    /// Highest floor of the parking site. It is possible to have negative values here in case it is underground only. Must be higher or equal than 'lowestFloor'.
    /// <see href="http://vocab.datex.org/terms#highestFloor"></see></summary>
    let highestFloor = _prefix "highestFloor"
    /// <summary>
    /// Lowest floor of the parking site. Positive values may apply in case it is over ground only. Must be lower or equal than 'highestFloor'.
    /// <see href="http://vocab.datex.org/terms#lowestFloor"></see></summary>
    let lowestFloor = _prefix "lowestFloor"
    /// <summary>
    /// An exit from the parking facility onto the road network from any parking space unless separate exits are specified for assigned parking spaces, in which case this is an exit from only the principal parking spaces.
    /// <see href="http://vocab.datex.org/terms#parkingAccess"></see></summary>
    let parkingAccess = _prefix "parkingAccess"
    /// <summary>
    /// Layout of the parking site.
    /// <see href="http://vocab.datex.org/terms#parkingLayout"></see></summary>
    let parkingLayout = _prefix "parkingLayout"
    /// <summary>
    /// Indication of whether a parking reservation service is available and/or mandatory.
    /// <see href="http://vocab.datex.org/terms#parkingReservation"></see></summary>
    let parkingReservation = _prefix "parkingReservation"
    /// <summary>
    /// Information about the parking site itself (address etc.). The 'GroupOfLocations' association must not be used for this role.
    /// <see href="http://vocab.datex.org/terms#parkingSiteAddress"></see></summary>
    let parkingSiteAddress = _prefix "parkingSiteAddress"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSiteExtension"></see>
    /// </summary>
    let parkingSiteExtension = _prefix "parkingSiteExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingStandardsAndSecurity"></see>
    /// </summary>
    let parkingStandardsAndSecurity = _prefix "parkingStandardsAndSecurity"
    /// <summary>
    /// Security measures and standards or standard-like categorization for a parking site.
    /// <see href="http://vocab.datex.org/terms#ParkingStandardsAndSecurity"></see></summary>
    let ParkingStandardsAndSecurity = _prefix "ParkingStandardsAndSecurity"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingUsageScenario"></see>
    /// </summary>
    let parkingUsageScenario = _prefix "parkingUsageScenario"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_ParkingSiteScenarioIndexParkingUsageScenario"></see>
    /// </summary>
    let _ParkingSiteScenarioIndexParkingUsageScenario =
        _prefix "_ParkingSiteScenarioIndexParkingUsageScenario"

    /// <summary>
    /// Reservation service (for end users). It is recommended to give URL and telephone.
    /// <see href="http://vocab.datex.org/terms#reservationService"></see></summary>
    let reservationService = _prefix "reservationService"
    /// <summary>
    /// Indicates that the parking site is on a temporary basis. It might close permanently within short notice or might only be partial equipped. The physical parking possibilities might be provisional, too.
    /// <see href="http://vocab.datex.org/terms#temporaryParking"></see></summary>
    let temporaryParking = _prefix "temporaryParking"
    /// <summary>
    /// Dynamic status information for the static object 'ParkingSite'.
    /// <see href="http://vocab.datex.org/terms#ParkingSiteStatus"></see></summary>
    let ParkingSiteStatus = _prefix "ParkingSiteStatus"
    /// <summary>
    /// The parking site is full at the specified floor(s).
    /// <see href="http://vocab.datex.org/terms#parkingSiteFullAtFloor"></see></summary>
    let parkingSiteFullAtFloor = _prefix "parkingSiteFullAtFloor"
    /// <summary>
    /// The opening status of the parking site (open or not).
    /// <see href="http://vocab.datex.org/terms#parkingSiteOpeningStatus"></see></summary>
    let parkingSiteOpeningStatus = _prefix "parkingSiteOpeningStatus"
    /// <summary>
    /// The overcrowding status of the parking site. Choose between using a two-stage approach or the more general statement ‘(not) overcrowding’. You can sharpen this information by using the ‘Thresholds’ component.
    /// <see href="http://vocab.datex.org/terms#parkingSiteOvercrowdingStatus"></see></summary>
    let parkingSiteOvercrowdingStatus = _prefix "parkingSiteOvercrowdingStatus"
    /// <summary>
    /// The status of the parking site (spaces available or not).
    /// <see href="http://vocab.datex.org/terms#parkingSiteStatus"></see></summary>
    let parkingSiteStatus = _prefix "parkingSiteStatus"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSiteStatusExtension"></see>
    /// </summary>
    let parkingSiteStatusExtension = _prefix "parkingSiteStatusExtension"
    /// <summary>
    /// A single parking space. It is possible to define the same parking space more than once with different properties, e.g. when there is a different parking assignment for different times.
    /// <see href="http://vocab.datex.org/terms#ParkingSpace"></see></summary>
    let ParkingSpace = _prefix "ParkingSpace"
    /// <summary>
    /// Points to another instance of 'ParkingSpace', which is identical from a local point of view (i.e. which is the same parking space). To be used when defining mixed parking areas (with using different time slots).
    /// <see href="http://vocab.datex.org/terms#identicalToParkingSpace"></see></summary>
    let identicalToParkingSpace = _prefix "identicalToParkingSpace"
    /// <summary>
    /// Dimension of the parking space (not all dimension attributes need to be provided). If the parking space is not rectangular, its dimension is specified as the smallest rectangle fitting inside its shape.
    /// <see href="http://vocab.datex.org/terms#parkingSpaceDimension"></see></summary>
    let parkingSpaceDimension = _prefix "parkingSpaceDimension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSpaceExtension"></see>
    /// </summary>
    let parkingSpaceExtension = _prefix "parkingSpaceExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#distanceFromPrimaryRoad"></see>
    /// </summary>
    let distanceFromPrimaryRoad = _prefix "distanceFromPrimaryRoad"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_ParkingSpaceBasicsEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacility"></see>
    /// </summary>
    let _ParkingSpaceBasicsEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacility =
        _prefix "_ParkingSpaceBasicsEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacility"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingFloorOrLevel"></see>
    /// </summary>
    let parkingFloorOrLevel = _prefix "parkingFloorOrLevel"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingMode"></see>
    /// </summary>
    let parkingMode = _prefix "parkingMode"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSecurity"></see>
    /// </summary>
    let parkingSecurity = _prefix "parkingSecurity"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSpaceAccessibility"></see>
    /// </summary>
    let parkingSpaceAccessibility = _prefix "parkingSpaceAccessibility"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSpaceBasicsExtension"></see>
    /// </summary>
    let parkingSpaceBasicsExtension = _prefix "parkingSpaceBasicsExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSpaceOrGroupIdentifier"></see>
    /// </summary>
    let parkingSpaceOrGroupIdentifier = _prefix "parkingSpaceOrGroupIdentifier"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSpacePhysics"></see>
    /// </summary>
    let parkingSpacePhysics = _prefix "parkingSpacePhysics"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_ParkingSpaceBasicsScenarioIndexParkingUsageScenario"></see>
    /// </summary>
    let _ParkingSpaceBasicsScenarioIndexParkingUsageScenario =
        _prefix "_ParkingSpaceBasicsScenarioIndexParkingUsageScenario"

    /// <summary>
    /// Status (occupied or closed) for a single parking space which was defined in the static part of the model.
    /// <see href="http://vocab.datex.org/terms#ParkingSpaceStatus"></see></summary>
    let ParkingSpaceStatus = _prefix "ParkingSpaceStatus"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#lastCalibration"></see>
    /// </summary>
    let lastCalibration = _prefix "lastCalibration"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSpaceClosed"></see>
    /// </summary>
    let parkingSpaceClosed = _prefix "parkingSpaceClosed"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSpaceDeclarationValidNow"></see>
    /// </summary>
    let parkingSpaceDeclarationValidNow = _prefix "parkingSpaceDeclarationValidNow"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSpaceOccupied"></see>
    /// </summary>
    let parkingSpaceOccupied = _prefix "parkingSpaceOccupied"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSpaceStatusExtension"></see>
    /// </summary>
    let parkingSpaceStatusExtension = _prefix "parkingSpaceStatusExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#certifiedSecureParking"></see>
    /// </summary>
    let certifiedSecureParking = _prefix "certifiedSecureParking"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#dateOfCertification"></see>
    /// </summary>
    let dateOfCertification = _prefix "dateOfCertification"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#labelSecurityLevel"></see>
    /// </summary>
    let labelSecurityLevel = _prefix "labelSecurityLevel"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#labelSecurityLevelSelfAssessment"></see>
    /// </summary>
    let labelSecurityLevelSelfAssessment = _prefix "labelSecurityLevelSelfAssessment"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#labelServiceLevel"></see>
    /// </summary>
    let labelServiceLevel = _prefix "labelServiceLevel"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#labelServiceLevelSelfAssessment"></see>
    /// </summary>
    let labelServiceLevelSelfAssessment = _prefix "labelServiceLevelSelfAssessment"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingAdditionalSecurity"></see>
    /// </summary>
    let parkingAdditionalSecurity = _prefix "parkingAdditionalSecurity"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSecurityNationalClassification"></see>
    /// </summary>
    let parkingSecurityNationalClassification =
        _prefix "parkingSecurityNationalClassification"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingStandardsAndSecurityExtension"></see>
    /// </summary>
    let parkingStandardsAndSecurityExtension =
        _prefix "parkingStandardsAndSecurityExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSupervision"></see>
    /// </summary>
    let parkingSupervision = _prefix "parkingSupervision"
    /// <summary>
    /// Defines a pair of 'parkingSiteStatus' and a corresponding colour.
    /// <see href="http://vocab.datex.org/terms#ParkingStatusColourMapping"></see></summary>
    let ParkingStatusColourMapping = _prefix "ParkingStatusColourMapping"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingStatusColourMappingExtension"></see>
    /// </summary>
    let parkingStatusColourMappingExtension =
        _prefix "parkingStatusColourMappingExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#rgbColour"></see>
    /// </summary>
    let rgbColour = _prefix "rgbColour"
    /// <summary>
    /// A publication containing the current status of one or more parking sites and/or group of parking sites.
    /// <see href="http://vocab.datex.org/terms#ParkingStatusPublication"></see></summary>
    let ParkingStatusPublication = _prefix "ParkingStatusPublication"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingRecordStatus"></see>
    /// </summary>
    let parkingRecordStatus = _prefix "parkingRecordStatus"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingTableReference"></see>
    /// </summary>
    let parkingTableReference = _prefix "parkingTableReference"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_ParkingTableVersionedReference"></see>
    /// </summary>
    let _ParkingTableVersionedReference = _prefix "_ParkingTableVersionedReference"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingStatusTime"></see>
    /// </summary>
    let parkingStatusTime = _prefix "parkingStatusTime"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingStatusTimeOffsetToOrigin"></see>
    /// </summary>
    let parkingStatusTimeOffsetToOrigin = _prefix "parkingStatusTimeOffsetToOrigin"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingStatusValidityExtension"></see>
    /// </summary>
    let parkingStatusValidityExtension = _prefix "parkingStatusValidityExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#validityTimeSpecification"></see>
    /// </summary>
    let validityTimeSpecification = _prefix "validityTimeSpecification"
    /// <summary>
    /// A collection of parking records, which can be parking sites or groups of parking sites.
    /// <see href="http://vocab.datex.org/terms#ParkingTable"></see></summary>
    let ParkingTable = _prefix "ParkingTable"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingRecord"></see>
    /// </summary>
    let parkingRecord = _prefix "parkingRecord"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingTableExtension"></see>
    /// </summary>
    let parkingTableExtension = _prefix "parkingTableExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingTableName"></see>
    /// </summary>
    let parkingTableName = _prefix "parkingTableName"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingTableVersionTime"></see>
    /// </summary>
    let parkingTableVersionTime = _prefix "parkingTableVersionTime"
    /// <summary>
    /// A publication defining one or more tables that have entries of parking sites or groups of them, located in an urban or interurban context.
    /// <see href="http://vocab.datex.org/terms#ParkingTablePublication"></see></summary>
    let ParkingTablePublication = _prefix "ParkingTablePublication"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingTable"></see>
    /// </summary>
    let parkingTable = _prefix "parkingTable"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#almostFullDecreasing"></see>
    /// </summary>
    let almostFullDecreasing = _prefix "almostFullDecreasing"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#almostFullIncreasing"></see>
    /// </summary>
    let almostFullIncreasing = _prefix "almostFullIncreasing"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#entranceFull"></see>
    /// </summary>
    let entranceFull = _prefix "entranceFull"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#fullDecreasing"></see>
    /// </summary>
    let fullDecreasing = _prefix "fullDecreasing"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#fullIncreasing"></see>
    /// </summary>
    let fullIncreasing = _prefix "fullIncreasing"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#overcrowding"></see>
    /// </summary>
    let overcrowding = _prefix "overcrowding"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#overcrowdingLevel1"></see>
    /// </summary>
    let overcrowdingLevel1 = _prefix "overcrowdingLevel1"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#overcrowdingLevel2"></see>
    /// </summary>
    let overcrowdingLevel2 = _prefix "overcrowdingLevel2"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingLastMaximumOccupancy"></see>
    /// </summary>
    let parkingLastMaximumOccupancy = _prefix "parkingLastMaximumOccupancy"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingStatusColourMapping"></see>
    /// </summary>
    let parkingStatusColourMapping = _prefix "parkingStatusColourMapping"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingThresholdsExtension"></see>
    /// </summary>
    let parkingThresholdsExtension = _prefix "parkingThresholdsExtension"
    /// <summary>
    /// A special type of usage available for the parking site or the group of parking spaces. In the 'ParkingStatusPublication', the operation type (in operation or not) can be defined.
    /// <see href="http://vocab.datex.org/terms#ParkingUsageScenario"></see></summary>
    let ParkingUsageScenario = _prefix "ParkingUsageScenario"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#eventParkingType"></see>
    /// </summary>
    let eventParkingType = _prefix "eventParkingType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#eventParkingType2"></see>
    /// </summary>
    let eventParkingType2 = _prefix "eventParkingType2"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingUsageScenarioExtension"></see>
    /// </summary>
    let parkingUsageScenarioExtension = _prefix "parkingUsageScenarioExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#scenarioAvailability"></see>
    /// </summary>
    let scenarioAvailability = _prefix "scenarioAvailability"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#truckParkingDynamicManagement"></see>
    /// </summary>
    let truckParkingDynamicManagement = _prefix "truckParkingDynamicManagement"
    /// <summary>
    /// The current status for this parking usage scenario.
    /// <see href="http://vocab.datex.org/terms#ParkingUsageScenarioStatus"></see></summary>
    let ParkingUsageScenarioStatus = _prefix "ParkingUsageScenarioStatus"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingUsageScenarioStatusExtension"></see>
    /// </summary>
    let parkingUsageScenarioStatusExtension =
        _prefix "parkingUsageScenarioStatusExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#usageScenarioOperationStatus"></see>
    /// </summary>
    let usageScenarioOperationStatus = _prefix "usageScenarioOperationStatus"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingVMSExtension"></see>
    /// </summary>
    let parkingVMSExtension = _prefix "parkingVMSExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsOperator"></see>
    /// </summary>
    let vmsOperator = _prefix "vmsOperator"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsUnitUsedToManageParking"></see>
    /// </summary>
    let vmsUnitUsedToManageParking = _prefix "vmsUnitUsedToManageParking"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_VmsUnitRecordVersionedReference"></see>
    /// </summary>
    let _VmsUnitRecordVersionedReference = _prefix "_VmsUnitRecordVersionedReference"
    /// <summary>
    /// Information about one individual parking vehicle.
    /// <see href="http://vocab.datex.org/terms#ParkingVehicle"></see></summary>
    let ParkingVehicle = _prefix "ParkingVehicle"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#groupOfParkingSpacesReference"></see>
    /// </summary>
    let groupOfParkingSpacesReference = _prefix "groupOfParkingSpacesReference"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#individualCharge"></see>
    /// </summary>
    let individualCharge = _prefix "individualCharge"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingPeriod"></see>
    /// </summary>
    let parkingPeriod = _prefix "parkingPeriod"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSpaceReference"></see>
    /// </summary>
    let parkingSpaceReference = _prefix "parkingSpaceReference"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingVehicleExtension"></see>
    /// </summary>
    let parkingVehicleExtension = _prefix "parkingVehicleExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicle"></see>
    /// </summary>
    let vehicle = _prefix "vehicle"
    /// <summary>
    /// Information about individual parking vehicles.
    /// <see href="http://vocab.datex.org/terms#ParkingVehiclesPublication"></see></summary>
    let ParkingVehiclesPublication = _prefix "ParkingVehiclesPublication"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingVehicle"></see>
    /// </summary>
    let parkingVehicle = _prefix "parkingVehicle"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#feedDescription"></see>
    /// </summary>
    let feedDescription = _prefix "feedDescription"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#feedType"></see>
    /// </summary>
    let feedType = _prefix "feedType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#payloadPublicationExtension"></see>
    /// </summary>
    let payloadPublicationExtension = _prefix "payloadPublicationExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#publicationCreator"></see>
    /// </summary>
    let publicationCreator = _prefix "publicationCreator"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#publicationTime"></see>
    /// </summary>
    let publicationTime = _prefix "publicationTime"
    /// <summary>
    /// A measured or calculated value of the flow rate of passenger car units.
    /// <see href="http://vocab.datex.org/terms#PcuFlowValue"></see></summary>
    let PcuFlowValue = _prefix "PcuFlowValue"
    /// <summary>
    /// A value of passenger car unit flow rate expressed in passenger car units per hour.
    /// <see href="http://vocab.datex.org/terms#pcuFlowRate"></see></summary>
    let pcuFlowRate = _prefix "pcuFlowRate"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pcuFlowValueExtension"></see>
    /// </summary>
    let pcuFlowValueExtension = _prefix "pcuFlowValueExtension"

    /// <summary>
    /// Distance of a point along a linear element measured from the start node expressed as a percentage of the whole length of the linear element, where start node is relative to the element definition rather than the direction of traffic flow.
    /// <see href="http://vocab.datex.org/terms#PercentageDistanceAlongLinearElement"></see></summary>
    let PercentageDistanceAlongLinearElement =
        _prefix "PercentageDistanceAlongLinearElement"

    /// <summary>
    /// A measure of distance along a linear element from the start of the element expressed as a percentage of the total length of the linear object.
    /// <see href="http://vocab.datex.org/terms#percentageDistanceAlong"></see></summary>
    let percentageDistanceAlong = _prefix "percentageDistanceAlong"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#percentageDistanceAlongLinearElementExtension"></see>
    /// </summary>
    let percentageDistanceAlongLinearElementExtension =
        _prefix "percentageDistanceAlongLinearElementExtension"

    /// <summary>
    /// A value expressed as a percentage.
    /// <see href="http://vocab.datex.org/terms#percentage"></see></summary>
    let percentage = _prefix "percentage"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#percentageValueExtension"></see>
    /// </summary>
    let percentageValueExtension = _prefix "percentageValueExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#endOfPeriod"></see>
    /// </summary>
    let endOfPeriod = _prefix "endOfPeriod"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#periodExtension"></see>
    /// </summary>
    let periodExtension = _prefix "periodExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_PeriodExtensionType"></see>
    /// </summary>
    let _PeriodExtensionType = _prefix "_PeriodExtensionType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#periodName"></see>
    /// </summary>
    let periodName = _prefix "periodName"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#recurringDayWeekMonthPeriod"></see>
    /// </summary>
    let recurringDayWeekMonthPeriod = _prefix "recurringDayWeekMonthPeriod"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#recurringTimePeriodOfDay"></see>
    /// </summary>
    let recurringTimePeriodOfDay = _prefix "recurringTimePeriodOfDay"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#startOfPeriod"></see>
    /// </summary>
    let startOfPeriod = _prefix "startOfPeriod"
    /// <summary>
    /// An extension point for Period offering the possibility to describe special days and public holidays.
    /// <see href="http://vocab.datex.org/terms#PeriodExtended"></see></summary>
    let PeriodExtended = _prefix "PeriodExtended"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#recurringSpecialDay"></see>
    /// </summary>
    let recurringSpecialDay = _prefix "recurringSpecialDay"
    /// <summary>
    /// Specification of a special day, for example schoolDay, electionDay, ...  Gives also the possibility to define a public holiday (country specific).
    /// <see href="http://vocab.datex.org/terms#SpecialDay"></see></summary>
    let SpecialDay = _prefix "SpecialDay"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#activity"></see>
    /// </summary>
    let activity = _prefix "activity"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#permitsAndProhibitionsExtension"></see>
    /// </summary>
    let permitsAndProhibitionsExtension = _prefix "permitsAndProhibitionsExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#regulation"></see>
    /// </summary>
    let regulation = _prefix "regulation"
    /// <summary>
    /// Settings specific to a distinct pictogram display area on the VMS (where pictogramIndex indicates which pictogram area it relates to if there is more than one pictogram display area on the VMS).
    /// <see href="http://vocab.datex.org/terms#PictogramDisplayAreaSettings"></see></summary>
    let PictogramDisplayAreaSettings = _prefix "PictogramDisplayAreaSettings"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramDisplayAreaSettingsExtension"></see>
    /// </summary>
    let pictogramDisplayAreaSettingsExtension =
        _prefix "pictogramDisplayAreaSettingsExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramLanternsOn"></see>
    /// </summary>
    let pictogramLanternsOn = _prefix "pictogramLanternsOn"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramLuminanceLevel"></see>
    /// </summary>
    let pictogramLuminanceLevel = _prefix "pictogramLuminanceLevel"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramLuminanceLevelName"></see>
    /// </summary>
    let pictogramLuminanceLevelName = _prefix "pictogramLuminanceLevelName"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramLuminanceOverride"></see>
    /// </summary>
    let pictogramLuminanceOverride = _prefix "pictogramLuminanceOverride"
    /// <summary>
    /// A single geospatial point.
    /// <see href="http://vocab.datex.org/terms#Point"></see></summary>
    let Point = _prefix "Point"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCPoint"></see>
    /// </summary>
    let alertCPoint = _prefix "alertCPoint"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pointAlongLinearElement"></see>
    /// </summary>
    let pointAlongLinearElement = _prefix "pointAlongLinearElement"
    /// <summary>
    /// A point on a linear element where the linear element is either a part of or the whole of a linear object (i.e. a road), consistent with ISO 19148 definitions.
    /// <see href="http://vocab.datex.org/terms#PointAlongLinearElement"></see></summary>
    let PointAlongLinearElement = _prefix "PointAlongLinearElement"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pointByCoordinates"></see>
    /// </summary>
    let pointByCoordinates = _prefix "pointByCoordinates"
    /// <summary>
    /// A single point defined only by a coordinate set with an optional bearing direction.
    /// <see href="http://vocab.datex.org/terms#PointByCoordinates"></see></summary>
    let PointByCoordinates = _prefix "PointByCoordinates"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pointExtension"></see>
    /// </summary>
    let pointExtension = _prefix "pointExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_PointExtensionType"></see>
    /// </summary>
    let _PointExtensionType = _prefix "_PointExtensionType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegPointLocation"></see>
    /// </summary>
    let tpegPointLocation = _prefix "tpegPointLocation"
    /// <summary>
    /// A single point on the road network defined by a TPEG-Loc structure and which has an associated direction of traffic flow.
    /// <see href="http://vocab.datex.org/terms#TpegPointLocation"></see></summary>
    let TpegPointLocation = _prefix "TpegPointLocation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#administrativeAreaOfPoint"></see>
    /// </summary>
    let administrativeAreaOfPoint = _prefix "administrativeAreaOfPoint"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#directionBoundAtPoint"></see>
    /// </summary>
    let directionBoundAtPoint = _prefix "directionBoundAtPoint"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#directionRelativeAtPoint"></see>
    /// </summary>
    let directionRelativeAtPoint = _prefix "directionRelativeAtPoint"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#distanceAlongLinearElement"></see>
    /// </summary>
    let distanceAlongLinearElement = _prefix "distanceAlongLinearElement"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#heightGradeOfPoint"></see>
    /// </summary>
    let heightGradeOfPoint = _prefix "heightGradeOfPoint"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pointAlongLinearElementExtension"></see>
    /// </summary>
    let pointAlongLinearElementExtension = _prefix "pointAlongLinearElementExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#bearing"></see>
    /// </summary>
    let bearing = _prefix "bearing"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pointByCoordinatesExtension"></see>
    /// </summary>
    let pointByCoordinatesExtension = _prefix "pointByCoordinatesExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pointCoordinates"></see>
    /// </summary>
    let pointCoordinates = _prefix "pointCoordinates"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#latitude"></see>
    /// </summary>
    let latitude = _prefix "latitude"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#longitude"></see>
    /// </summary>
    let longitude = _prefix "longitude"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pointCoordinatesExtension"></see>
    /// </summary>
    let pointCoordinatesExtension = _prefix "pointCoordinatesExtension"
    /// <summary>
    /// The specification of the destination of a defined route or itinerary which is a point.
    /// <see href="http://vocab.datex.org/terms#PointDestination"></see></summary>
    let PointDestination = _prefix "PointDestination"
    /// <summary>
    /// A single point defined by a coordinate set and TPEG decriptors.
    /// <see href="http://vocab.datex.org/terms#point"></see></summary>
    let point = _prefix "point"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pointDestinationExtension"></see>
    /// </summary>
    let pointDestinationExtension = _prefix "pointDestinationExtension"
    /// <summary>
    /// Extension point for 'Point' to support the description of junctions (and other alternative point descriptions).
    /// <see href="http://vocab.datex.org/terms#PointExtended"></see></summary>
    let PointExtended = _prefix "PointExtended"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#description"></see>
    /// </summary>
    let description = _prefix "description"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#junction"></see>
    /// </summary>
    let junction = _prefix "junction"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pollutantConcentration"></see>
    /// </summary>
    let pollutantConcentration = _prefix "pollutantConcentration"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pollutantType"></see>
    /// </summary>
    let pollutantType = _prefix "pollutantType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pollutionExtension"></see>
    /// </summary>
    let pollutionExtension = _prefix "pollutionExtension"
    /// <summary>
    /// Measurements of atmospheric pollution.
    /// <see href="http://vocab.datex.org/terms#PollutionInformation"></see></summary>
    let PollutionInformation = _prefix "PollutionInformation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pollution"></see>
    /// </summary>
    let pollution = _prefix "pollution"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pollutionInformationExtension"></see>
    /// </summary>
    let pollutionInformationExtension = _prefix "pollutionInformationExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_PolygonAreaIndexPointCoordinates"></see>
    /// </summary>
    let _PolygonAreaIndexPointCoordinates = _prefix "_PolygonAreaIndexPointCoordinates"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#polygonAreaExtension"></see>
    /// </summary>
    let polygonAreaExtension = _prefix "polygonAreaExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#sectionName"></see>
    /// </summary>
    let sectionName = _prefix "sectionName"
    /// <summary>
    /// Any environmental conditions which may be affecting the driving conditions on the road.
    /// <see href="http://vocab.datex.org/terms#PoorEnvironmentConditions"></see></summary>
    let PoorEnvironmentConditions = _prefix "PoorEnvironmentConditions"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#poorEnvironmentConditionsExtension"></see>
    /// </summary>
    let poorEnvironmentConditionsExtension =
        _prefix "poorEnvironmentConditionsExtension"

    /// <summary>
    /// The type of environment condition which is affecting driving conditions.
    /// <see href="http://vocab.datex.org/terms#poorEnvironmentType"></see></summary>
    let poorEnvironmentType = _prefix "poorEnvironmentType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#precipitationDetail"></see>
    /// </summary>
    let precipitationDetail = _prefix "precipitationDetail"
    /// <summary>
    /// Details of precipitation (rain, snow etc.).
    /// <see href="http://vocab.datex.org/terms#PrecipitationDetail"></see></summary>
    let PrecipitationDetail = _prefix "PrecipitationDetail"
    /// <summary>
    /// A value of temperature expressed in degrees Celsius.
    /// <see href="http://vocab.datex.org/terms#temperature"></see></summary>
    let temperature = _prefix "temperature"
    /// <summary>
    /// Details of atmospheric temperature.
    /// <see href="http://vocab.datex.org/terms#Temperature"></see></summary>
    let Temperature = _prefix "Temperature"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#visibility"></see>
    /// </summary>
    let visibility = _prefix "visibility"
    /// <summary>
    /// Details of atmospheric visibility.
    /// <see href="http://vocab.datex.org/terms#Visibility"></see></summary>
    let Visibility = _prefix "Visibility"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#wind"></see>
    /// </summary>
    let wind = _prefix "wind"
    /// <summary>
    /// Wind conditions on the road.
    /// <see href="http://vocab.datex.org/terms#Wind"></see></summary>
    let Wind = _prefix "Wind"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#depositionDepth"></see>
    /// </summary>
    let depositionDepth = _prefix "depositionDepth"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#precipitationDetailExtension"></see>
    /// </summary>
    let precipitationDetailExtension = _prefix "precipitationDetailExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#precipitationIntensity"></see>
    /// </summary>
    let precipitationIntensity = _prefix "precipitationIntensity"
    /// <summary>
    /// A measured or calculated value of the accumulation rate of precipitation.
    /// <see href="http://vocab.datex.org/terms#PrecipitationIntensityValue"></see></summary>
    let PrecipitationIntensityValue = _prefix "PrecipitationIntensityValue"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#precipitationType"></see>
    /// </summary>
    let precipitationType = _prefix "precipitationType"
    /// <summary>
    /// Measurements of precipitation.
    /// <see href="http://vocab.datex.org/terms#PrecipitationInformation"></see></summary>
    let PrecipitationInformation = _prefix "PrecipitationInformation"
    /// <summary>
    /// Indication of whether precipitation is present or not. True indicates there is no precipitation.
    /// <see href="http://vocab.datex.org/terms#noPrecipitation"></see></summary>
    let noPrecipitation = _prefix "noPrecipitation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#precipitationInformationExtension"></see>
    /// </summary>
    let precipitationInformationExtension = _prefix "precipitationInformationExtension"
    /// <summary>
    /// A value of precipitation intensity expressed in units of millimetres per hour.
    /// <see href="http://vocab.datex.org/terms#millimetresPerHourIntensity"></see></summary>
    let millimetresPerHourIntensity = _prefix "millimetresPerHourIntensity"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#precipitationIntensityValueExtension"></see>
    /// </summary>
    let precipitationIntensityValueExtension =
        _prefix "precipitationIntensityValueExtension"

    /// <summary>
    /// An identifiable versioned instance of a predefined itinerary.
    /// <see href="http://vocab.datex.org/terms#PredefinedItinerary"></see></summary>
    let PredefinedItinerary = _prefix "PredefinedItinerary"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#predefinedItineraryExtension"></see>
    /// </summary>
    let predefinedItineraryExtension = _prefix "predefinedItineraryExtension"
    /// <summary>
    /// A name assigned to the predefined itinerary.
    /// <see href="http://vocab.datex.org/terms#predefinedItineraryName"></see></summary>
    let predefinedItineraryName = _prefix "predefinedItineraryName"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#predefinedLocation"></see>
    /// </summary>
    let predefinedLocation = _prefix "predefinedLocation"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_PredefinedItineraryIndexPredefinedLocation"></see>
    /// </summary>
    let _PredefinedItineraryIndexPredefinedLocation =
        _prefix "_PredefinedItineraryIndexPredefinedLocation"

    /// <summary>
    /// A container which may comprise the definition of a predefined itinerary, non ordered group of locations or single location.
    /// <see href="http://vocab.datex.org/terms#PredefinedLocationContainer"></see></summary>
    let PredefinedLocationContainer = _prefix "PredefinedLocationContainer"
    /// <summary>
    /// An identifiable versioned instance of a single predefined location.
    /// <see href="http://vocab.datex.org/terms#PredefinedLocation"></see></summary>
    let PredefinedLocation = _prefix "PredefinedLocation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#predefinedLocationExtension"></see>
    /// </summary>
    let predefinedLocationExtension = _prefix "predefinedLocationExtension"
    /// <summary>
    /// A name assigned to the predefined location (e.g. extracted out of the network operator's gazetteer).
    /// <see href="http://vocab.datex.org/terms#predefinedLocationName"></see></summary>
    let predefinedLocationName = _prefix "predefinedLocationName"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#predefinedLocationContainerExtension"></see>
    /// </summary>
    let predefinedLocationContainerExtension =
        _prefix "predefinedLocationContainerExtension"

    /// <summary>
    /// A publication containing one or more groups of predefined locations organised either as litineraries, non ordered groups or as individual locations.
    /// <see href="http://vocab.datex.org/terms#PredefinedLocationsPublication"></see></summary>
    let PredefinedLocationsPublication = _prefix "PredefinedLocationsPublication"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#predefinedLocationContainer"></see>
    /// </summary>
    let predefinedLocationContainer = _prefix "predefinedLocationContainer"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#predefinedLocationsPublicationExtension"></see>
    /// </summary>
    let predefinedLocationsPublicationExtension =
        _prefix "predefinedLocationsPublicationExtension"

    /// <summary>
    /// An identifiable versioned instance of a predefined group of non ordered locations (i.e. more than one).
    /// <see href="http://vocab.datex.org/terms#PredefinedNonOrderedLocationGroup"></see></summary>
    let PredefinedNonOrderedLocationGroup = _prefix "PredefinedNonOrderedLocationGroup"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#predefinedNonOrderedLocationGroupExtension"></see>
    /// </summary>
    let predefinedNonOrderedLocationGroupExtension =
        _prefix "predefinedNonOrderedLocationGroupExtension"

    /// <summary>
    /// A name assigned to the predefined group of non ordered locations.
    /// <see href="http://vocab.datex.org/terms#predefinedNonOrderedLocationGroupName"></see></summary>
    let predefinedNonOrderedLocationGroupName =
        _prefix "predefinedNonOrderedLocationGroupName"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#publicEventExtension"></see>
    /// </summary>
    let publicEventExtension = _prefix "publicEventExtension"
    /// <summary>
    /// Type of public event which could disrupt traffic.
    /// <see href="http://vocab.datex.org/terms#publicEventType"></see></summary>
    let publicEventType = _prefix "publicEventType"
    /// <summary>
    /// Specification of the public holiday type in a specific country or region. Use this component only when specialDayType is set to 'publicHoliday' or 'holidays'.
    /// <see href="http://vocab.datex.org/terms#PublicHoliday"></see></summary>
    let PublicHoliday = _prefix "PublicHoliday"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#countrySubdivision"></see>
    /// </summary>
    let countrySubdivision = _prefix "countrySubdivision"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#publicHolidayExtension"></see>
    /// </summary>
    let publicHolidayExtension = _prefix "publicHolidayExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#publicHolidayName"></see>
    /// </summary>
    let publicHolidayName = _prefix "publicHolidayName"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#publicHolidayType"></see>
    /// </summary>
    let publicHolidayType = _prefix "publicHolidayType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#region"></see>
    /// </summary>
    let region = _prefix "region"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#colourName"></see>
    /// </summary>
    let colourName = _prefix "colourName"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#rgbBlueValue"></see>
    /// </summary>
    let rgbBlueValue = _prefix "rgbBlueValue"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#rgbColourExtension"></see>
    /// </summary>
    let rgbColourExtension = _prefix "rgbColourExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#rgbGreenValue"></see>
    /// </summary>
    let rgbGreenValue = _prefix "rgbGreenValue"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#rgbRedValue"></see>
    /// </summary>
    let rgbRedValue = _prefix "rgbRedValue"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Reference"></see>
    /// </summary>
    let Reference = _prefix "Reference"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#referenceSettingsExtension"></see>
    /// </summary>
    let referenceSettingsExtension = _prefix "referenceSettingsExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#trafficStatusDefault"></see>
    /// </summary>
    let trafficStatusDefault = _prefix "trafficStatusDefault"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#referentDescription"></see>
    /// </summary>
    let referentDescription = _prefix "referentDescription"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#referentExtension"></see>
    /// </summary>
    let referentExtension = _prefix "referentExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#referentIdentifier"></see>
    /// </summary>
    let referentIdentifier = _prefix "referentIdentifier"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#referentName"></see>
    /// </summary>
    let referentName = _prefix "referentName"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#referentType"></see>
    /// </summary>
    let referentType = _prefix "referentType"
    /// <summary>
    /// Rerouting management action that is issued by the network/road operator.
    /// <see href="http://vocab.datex.org/terms#ReroutingManagement"></see></summary>
    let ReroutingManagement = _prefix "ReroutingManagement"
    /// <summary>
    /// The definition of the alternative route (rerouting) specified as an ordered set of locations (itinerary) which may be specific to one or more defined destinations.
    /// <see href="http://vocab.datex.org/terms#alternativeRoute"></see></summary>
    let alternativeRoute = _prefix "alternativeRoute"
    /// <summary>
    /// The specified entry on to another road at which the alternative route commences.
    /// <see href="http://vocab.datex.org/terms#entry"></see></summary>
    let entry = _prefix "entry"
    /// <summary>
    /// The specified exit from the normal route/road at which the alternative route commences.
    /// <see href="http://vocab.datex.org/terms#exit"></see></summary>
    let exit = _prefix "exit"
    /// <summary>
    /// A description of the rerouting itinerary.
    /// <see href="http://vocab.datex.org/terms#reroutingItineraryDescription"></see></summary>
    let reroutingItineraryDescription = _prefix "reroutingItineraryDescription"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#reroutingManagementExtension"></see>
    /// </summary>
    let reroutingManagementExtension = _prefix "reroutingManagementExtension"
    /// <summary>
    /// Type of rerouting management action instigated by operator.
    /// <see href="http://vocab.datex.org/terms#reroutingManagementType"></see></summary>
    let reroutingManagementType = _prefix "reroutingManagementType"
    /// <summary>
    /// The intersecting road or the junction at which the alternative route commences.
    /// <see href="http://vocab.datex.org/terms#roadOrJunctionNumber"></see></summary>
    let roadOrJunctionNumber = _prefix "roadOrJunctionNumber"
    /// <summary>
    /// Indication of whether the rerouting is signed.
    /// <see href="http://vocab.datex.org/terms#signedRerouting"></see></summary>
    let signedRerouting = _prefix "signedRerouting"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#distanceToThisRoad"></see>
    /// </summary>
    let distanceToThisRoad = _prefix "distanceToThisRoad"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#nameOfRoad"></see>
    /// </summary>
    let nameOfRoad = _prefix "nameOfRoad"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#roadDestination"></see>
    /// </summary>
    let roadDestination = _prefix "roadDestination"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#roadExtension"></see>
    /// </summary>
    let roadExtension = _prefix "roadExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#roadIdentifier"></see>
    /// </summary>
    let roadIdentifier = _prefix "roadIdentifier"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#roadOrigination"></see>
    /// </summary>
    let roadOrigination = _prefix "roadOrigination"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#typeOfRoad"></see>
    /// </summary>
    let typeOfRoad = _prefix "typeOfRoad"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#roadConditionsExtension"></see>
    /// </summary>
    let roadConditionsExtension = _prefix "roadConditionsExtension"
    /// <summary>
    /// A road node as part of the specialised road identified by the name of a junctionon on this road.
    /// <see href="http://vocab.datex.org/terms#RoadNode"></see></summary>
    let RoadNode = _prefix "RoadNode"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#roadNodeExtension"></see>
    /// </summary>
    let roadNodeExtension = _prefix "roadNodeExtension"
    /// <summary>
    /// Details of disruption to normal road operator services
    /// <see href="http://vocab.datex.org/terms#RoadOperatorServiceDisruption"></see></summary>
    let RoadOperatorServiceDisruption = _prefix "RoadOperatorServiceDisruption"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#roadOperatorServiceDisruptionExtension"></see>
    /// </summary>
    let roadOperatorServiceDisruptionExtension =
        _prefix "roadOperatorServiceDisruptionExtension"

    /// <summary>
    /// The type of road operator service which is disrupted.
    /// <see href="http://vocab.datex.org/terms#roadOperatorServiceDisruptionType"></see></summary>
    let roadOperatorServiceDisruptionType = _prefix "roadOperatorServiceDisruptionType"
    /// <summary>
    /// The minimum number of persons required in a vehicle in order for it to be allowed to transit the specified road section.
    /// <see href="http://vocab.datex.org/terms#minimumCarOccupancy"></see></summary>
    let minimumCarOccupancy = _prefix "minimumCarOccupancy"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#roadOrCarriagewayOrLaneManagementExtension"></see>
    /// </summary>
    let roadOrCarriagewayOrLaneManagementExtension =
        _prefix "roadOrCarriagewayOrLaneManagementExtension"

    /// <summary>
    /// Type of road, carriageway or lane management action instigated by operator.
    /// <see href="http://vocab.datex.org/terms#roadOrCarriagewayOrLaneManagementType"></see></summary>
    let roadOrCarriagewayOrLaneManagementType =
        _prefix "roadOrCarriagewayOrLaneManagementType"

    /// <summary>
    /// Measurements of road surface conditions which are related to the weather.
    /// <see href="http://vocab.datex.org/terms#RoadSurfaceConditionInformation"></see></summary>
    let RoadSurfaceConditionInformation = _prefix "RoadSurfaceConditionInformation"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#roadSurfaceConditionInformationExtension"></see>
    /// </summary>
    let roadSurfaceConditionInformationExtension =
        _prefix "roadSurfaceConditionInformationExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#roadSurfaceConditionMeasurements"></see>
    /// </summary>
    let roadSurfaceConditionMeasurements = _prefix "roadSurfaceConditionMeasurements"
    /// <summary>
    /// Measurements of the road surface condition which relate specifically to the weather.
    /// <see href="http://vocab.datex.org/terms#RoadSurfaceConditionMeasurements"></see></summary>
    let RoadSurfaceConditionMeasurements = _prefix "RoadSurfaceConditionMeasurements"
    /// <summary>
    /// The type of road surface condition that is related to the weather which is affecting the driving conditions.
    /// <see href="http://vocab.datex.org/terms#weatherRelatedRoadConditionType"></see></summary>
    let weatherRelatedRoadConditionType = _prefix "weatherRelatedRoadConditionType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#deIcingApplicationRate"></see>
    /// </summary>
    let deIcingApplicationRate = _prefix "deIcingApplicationRate"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#deIcingConcentration"></see>
    /// </summary>
    let deIcingConcentration = _prefix "deIcingConcentration"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#depthOfSnow"></see>
    /// </summary>
    let depthOfSnow = _prefix "depthOfSnow"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#protectionTemperature"></see>
    /// </summary>
    let protectionTemperature = _prefix "protectionTemperature"
    /// <summary>
    /// A measured or calculated value of temperature.
    /// <see href="http://vocab.datex.org/terms#TemperatureValue"></see></summary>
    let TemperatureValue = _prefix "TemperatureValue"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#roadSurfaceConditionMeasurementsExtension"></see>
    /// </summary>
    let roadSurfaceConditionMeasurementsExtension =
        _prefix "roadSurfaceConditionMeasurementsExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#roadSurfaceTemperature"></see>
    /// </summary>
    let roadSurfaceTemperature = _prefix "roadSurfaceTemperature"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#waterFilmThickness"></see>
    /// </summary>
    let waterFilmThickness = _prefix "waterFilmThickness"
    /// <summary>
    /// Details of road side assistance required or being given.
    /// <see href="http://vocab.datex.org/terms#RoadsideAssistance"></see></summary>
    let RoadsideAssistance = _prefix "RoadsideAssistance"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#roadsideAssistanceExtension"></see>
    /// </summary>
    let roadsideAssistanceExtension = _prefix "roadsideAssistanceExtension"
    /// <summary>
    /// Indicates the nature of the road side assistance that will be, is or has been provided.
    /// <see href="http://vocab.datex.org/terms#roadsideAssistanceType"></see></summary>
    let roadsideAssistanceType = _prefix "roadsideAssistanceType"
    /// <summary>
    /// Details of disruption to normal roadside services (e.g. specific services at a service area).
    /// <see href="http://vocab.datex.org/terms#RoadsideServiceDisruption"></see></summary>
    let RoadsideServiceDisruption = _prefix "RoadsideServiceDisruption"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#roadsideServiceDisruptionExtension"></see>
    /// </summary>
    let roadsideServiceDisruptionExtension =
        _prefix "roadsideServiceDisruptionExtension"

    /// <summary>
    /// The type of roadside service which is disrupted.
    /// <see href="http://vocab.datex.org/terms#roadsideServiceDisruptionType"></see></summary>
    let roadsideServiceDisruptionType = _prefix "roadsideServiceDisruptionType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maintenanceVehicles"></see>
    /// </summary>
    let maintenanceVehicles = _prefix "maintenanceVehicles"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#mobility"></see>
    /// </summary>
    let mobility = _prefix "mobility"
    /// <summary>
    /// Indicates in general terms the expected duration of the roadworks.
    /// <see href="http://vocab.datex.org/terms#roadworksDuration"></see></summary>
    let roadworksDuration = _prefix "roadworksDuration"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#roadworksExtension"></see>
    /// </summary>
    let roadworksExtension = _prefix "roadworksExtension"
    /// <summary>
    /// Indication of the scale of the roadworks in terms of the traffic disruption they are likely to cause.
    /// <see href="http://vocab.datex.org/terms#roadworksScale"></see></summary>
    let roadworksScale = _prefix "roadworksScale"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#subjects"></see>
    /// </summary>
    let subjects = _prefix "subjects"
    /// <summary>
    /// The subjects with which the roadworks are associated.
    /// <see href="http://vocab.datex.org/terms#Subjects"></see></summary>
    let Subjects = _prefix "Subjects"
    /// <summary>
    /// Indicates that the road section where the roadworks are located is under traffic or not under traffic. 'True' indicates the road is under traffic.
    /// <see href="http://vocab.datex.org/terms#underTraffic"></see></summary>
    let underTraffic = _prefix "underTraffic"
    /// <summary>
    /// Indication of whether the roadworks are considered to be urgent whereby emergency work is being, or needs to be, undertaken to mitigate safety concerns. 'True' indicates they are urgent.
    /// <see href="http://vocab.datex.org/terms#urgentRoadworks"></see></summary>
    let urgentRoadworks = _prefix "urgentRoadworks"
    /// <summary>
    /// One type of service facility that is available on the parking site or located next to it. You can specify the number of this service facility type (e.g. 5 restaurants) as well as the number of subitems (e.g. 200 restaurant places).
    /// <see href="http://vocab.datex.org/terms#ServiceFacility"></see></summary>
    let ServiceFacility = _prefix "ServiceFacility"
    /// <summary>
    /// If the service facility is not located on the parking site itself, its distance can be specified here in metres.
    /// <see href="http://vocab.datex.org/terms#distanceFromParkingSite"></see></summary>
    let distanceFromParkingSite = _prefix "distanceFromParkingSite"
    /// <summary>
    /// The quantity of sub items to this service facility type, e.g. the total number of restaurant places or fuel dispensers etc.
    /// <see href="http://vocab.datex.org/terms#numberOfSubitems"></see></summary>
    let numberOfSubitems = _prefix "numberOfSubitems"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#serviceFacilityExtension"></see>
    /// </summary>
    let serviceFacilityExtension = _prefix "serviceFacilityExtension"
    /// <summary>
    /// One type of service, that is available on the parking site.
    /// <see href="http://vocab.datex.org/terms#serviceFacilityType"></see></summary>
    let serviceFacilityType = _prefix "serviceFacilityType"
    /// <summary>
    /// Provides information on message signs and the information currently displayed.
    /// <see href="http://vocab.datex.org/terms#SignSetting"></see></summary>
    let SignSetting = _prefix "SignSetting"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#signSettingExtension"></see>
    /// </summary>
    let signSettingExtension = _prefix "signSettingExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsSetting"></see>
    /// </summary>
    let vmsSetting = _prefix "vmsSetting"
    /// <summary>
    /// Provides information on variable message signs and the information currently displayed.
    /// <see href="http://vocab.datex.org/terms#VmsSetting"></see></summary>
    let VmsSetting = _prefix "VmsSetting"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measuredValue"></see>
    /// </summary>
    let measuredValue = _prefix "measuredValue"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_SiteMeasurementsIndexMeasuredValue"></see>
    /// </summary>
    let _SiteMeasurementsIndexMeasuredValue =
        _prefix "_SiteMeasurementsIndexMeasuredValue"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementSiteReference"></see>
    /// </summary>
    let measurementSiteReference = _prefix "measurementSiteReference"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_MeasurementSiteRecordVersionedReference"></see>
    /// </summary>
    let _MeasurementSiteRecordVersionedReference =
        _prefix "_MeasurementSiteRecordVersionedReference"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementTimeDefault"></see>
    /// </summary>
    let measurementTimeDefault = _prefix "measurementTimeDefault"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#siteMeasurementsExtension"></see>
    /// </summary>
    let siteMeasurementsExtension = _prefix "siteMeasurementsExtension"
    /// <summary>
    /// An identifiable instance of a traffic/travel situation comprising one or more traffic/travel circumstances which are linked by one or more causal relationships. Each traffic/travel circumstance is represented by a Situation Record.
    /// <see href="http://vocab.datex.org/terms#Situation"></see></summary>
    let Situation = _prefix "Situation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#overallSeverity"></see>
    /// </summary>
    let overallSeverity = _prefix "overallSeverity"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#relatedSituation"></see>
    /// </summary>
    let relatedSituation = _prefix "relatedSituation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_SituationVersionedReference"></see>
    /// </summary>
    let _SituationVersionedReference = _prefix "_SituationVersionedReference"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#situationExtension"></see>
    /// </summary>
    let situationExtension = _prefix "situationExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#situationRecord"></see>
    /// </summary>
    let situationRecord = _prefix "situationRecord"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#situationVersionTime"></see>
    /// </summary>
    let situationVersionTime = _prefix "situationVersionTime"
    /// <summary>
    /// A publication containing zero or more traffic/travel situations.
    /// <see href="http://vocab.datex.org/terms#SituationPublication"></see></summary>
    let SituationPublication = _prefix "SituationPublication"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#situation"></see>
    /// </summary>
    let situation = _prefix "situation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#situationPublicationExtension"></see>
    /// </summary>
    let situationPublicationExtension = _prefix "situationPublicationExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#cause"></see>
    /// </summary>
    let cause = _prefix "cause"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#confidentialityOverride"></see>
    /// </summary>
    let confidentialityOverride = _prefix "confidentialityOverride"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#generalPublicComment"></see>
    /// </summary>
    let generalPublicComment = _prefix "generalPublicComment"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#impact"></see>
    /// </summary>
    let impact = _prefix "impact"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#management"></see>
    /// </summary>
    let management = _prefix "management"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#nonGeneralPublicComment"></see>
    /// </summary>
    let nonGeneralPublicComment = _prefix "nonGeneralPublicComment"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#probabilityOfOccurrence"></see>
    /// </summary>
    let probabilityOfOccurrence = _prefix "probabilityOfOccurrence"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#severity"></see>
    /// </summary>
    let severity = _prefix "severity"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#situationRecordCreationReference"></see>
    /// </summary>
    let situationRecordCreationReference = _prefix "situationRecordCreationReference"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#situationRecordCreationTime"></see>
    /// </summary>
    let situationRecordCreationTime = _prefix "situationRecordCreationTime"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#situationRecordExtension"></see>
    /// </summary>
    let situationRecordExtension = _prefix "situationRecordExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_SituationRecordExtensionType"></see>
    /// </summary>
    let _SituationRecordExtensionType = _prefix "_SituationRecordExtensionType"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#situationRecordFirstSupplierVersionTime"></see>
    /// </summary>
    let situationRecordFirstSupplierVersionTime =
        _prefix "situationRecordFirstSupplierVersionTime"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#situationRecordObservationTime"></see>
    /// </summary>
    let situationRecordObservationTime = _prefix "situationRecordObservationTime"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#situationRecordVersionTime"></see>
    /// </summary>
    let situationRecordVersionTime = _prefix "situationRecordVersionTime"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#urlLink"></see>
    /// </summary>
    let urlLink = _prefix "urlLink"
    /// <summary>
    /// Details of a Uniform Resource Locator (URL) address pointing to a resource available on the Internet from where further relevant information may be obtained.
    /// <see href="http://vocab.datex.org/terms#UrlLink"></see></summary>
    let UrlLink = _prefix "UrlLink"
    /// <summary>
    /// Extension class for SituationRecord.
    /// <see href="http://vocab.datex.org/terms#SituationRecordExtendedApproved"></see></summary>
    let SituationRecordExtendedApproved = _prefix "SituationRecordExtendedApproved"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#safetyRelatedMessage"></see>
    /// </summary>
    let safetyRelatedMessage = _prefix "safetyRelatedMessage"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#reliable"></see>
    /// </summary>
    let reliable = _prefix "reliable"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#sourceCountry"></see>
    /// </summary>
    let sourceCountry = _prefix "sourceCountry"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#sourceExtension"></see>
    /// </summary>
    let sourceExtension = _prefix "sourceExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#sourceIdentification"></see>
    /// </summary>
    let sourceIdentification = _prefix "sourceIdentification"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#sourceName"></see>
    /// </summary>
    let sourceName = _prefix "sourceName"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#sourceType"></see>
    /// </summary>
    let sourceType = _prefix "sourceType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#intersectWithApplicableDays"></see>
    /// </summary>
    let intersectWithApplicableDays = _prefix "intersectWithApplicableDays"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#publicHoliday"></see>
    /// </summary>
    let publicHoliday = _prefix "publicHoliday"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#specialDayExtension"></see>
    /// </summary>
    let specialDayExtension = _prefix "specialDayExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#specialDayName"></see>
    /// </summary>
    let specialDayName = _prefix "specialDayName"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#specialDayType"></see>
    /// </summary>
    let specialDayType = _prefix "specialDayType"
    /// <summary>
    /// A parking site which is located at a special location, often associated with some building.
    /// <see href="http://vocab.datex.org/terms#SpecialLocationParkingSite"></see></summary>
    let SpecialLocationParkingSite = _prefix "SpecialLocationParkingSite"
    /// <summary>
    /// A special location not available in the enumeration. Use literal 'other' in this case.
    /// <see href="http://vocab.datex.org/terms#parkingOtherSpecialLocation"></see></summary>
    let parkingOtherSpecialLocation = _prefix "parkingOtherSpecialLocation"
    /// <summary>
    /// The special location of the parking site.
    /// <see href="http://vocab.datex.org/terms#parkingSpecialLocation"></see></summary>
    let parkingSpecialLocation = _prefix "parkingSpecialLocation"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#specialLocationParkingSiteExtension"></see>
    /// </summary>
    let specialLocationParkingSiteExtension =
        _prefix "specialLocationParkingSiteExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#speedManagementExtension"></see>
    /// </summary>
    let speedManagementExtension = _prefix "speedManagementExtension"
    /// <summary>
    /// Type of speed management action instigated by operator.
    /// <see href="http://vocab.datex.org/terms#speedManagementType"></see></summary>
    let speedManagementType = _prefix "speedManagementType"
    /// <summary>
    /// Temporary limit defining the maximum advisory or mandatory speed of vehicles.
    /// <see href="http://vocab.datex.org/terms#temporarySpeedLimit"></see></summary>
    let temporarySpeedLimit = _prefix "temporarySpeedLimit"
    /// <summary>
    /// Details of percentage (from an observation set) of vehicles whose speeds fall below a stated value.
    /// <see href="http://vocab.datex.org/terms#SpeedPercentile"></see></summary>
    let SpeedPercentile = _prefix "SpeedPercentile"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#speedPercentile"></see>
    /// </summary>
    let speedPercentile = _prefix "speedPercentile"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#speedPercentileExtension"></see>
    /// </summary>
    let speedPercentileExtension = _prefix "speedPercentileExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehiclePercentage"></see>
    /// </summary>
    let vehiclePercentage = _prefix "vehiclePercentage"
    /// <summary>
    /// A value of speed expressed in kilometres per hour.
    /// <see href="http://vocab.datex.org/terms#speed"></see></summary>
    let speed = _prefix "speed"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#speedValueExtension"></see>
    /// </summary>
    let speedValueExtension = _prefix "speedValueExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#numberOfSubjects"></see>
    /// </summary>
    let numberOfSubjects = _prefix "numberOfSubjects"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#subjectTypeOfWorks"></see>
    /// </summary>
    let subjectTypeOfWorks = _prefix "subjectTypeOfWorks"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#subjectsExtension"></see>
    /// </summary>
    let subjectsExtension = _prefix "subjectsExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#deleteSubscription"></see>
    /// </summary>
    let deleteSubscription = _prefix "deleteSubscription"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#deliveryInterval"></see>
    /// </summary>
    let deliveryInterval = _prefix "deliveryInterval"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#operatingMode"></see>
    /// </summary>
    let operatingMode = _prefix "operatingMode"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#subscriptionExtension"></see>
    /// </summary>
    let subscriptionExtension = _prefix "subscriptionExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#subscriptionStartTime"></see>
    /// </summary>
    let subscriptionStartTime = _prefix "subscriptionStartTime"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#subscriptionState"></see>
    /// </summary>
    let subscriptionState = _prefix "subscriptionState"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#subscriptionStopTime"></see>
    /// </summary>
    let subscriptionStopTime = _prefix "subscriptionStopTime"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#updateMethod"></see>
    /// </summary>
    let updateMethod = _prefix "updateMethod"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#locationPrecision"></see>
    /// </summary>
    let locationPrecision = _prefix "locationPrecision"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#affectedCarriagewayAndLanes"></see>
    /// </summary>
    let affectedCarriagewayAndLanes = _prefix "affectedCarriagewayAndLanes"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#locationDescriptor"></see>
    /// </summary>
    let locationDescriptor = _prefix "locationDescriptor"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#sequentialRampNumber"></see>
    /// </summary>
    let sequentialRampNumber = _prefix "sequentialRampNumber"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#supplementaryPositionalDescriptionExtension"></see>
    /// </summary>
    let supplementaryPositionalDescriptionExtension =
        _prefix "supplementaryPositionalDescriptionExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#address"></see>
    /// </summary>
    let address = _prefix "address"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#protocol"></see>
    /// </summary>
    let protocol = _prefix "protocol"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#targetExtension"></see>
    /// </summary>
    let targetExtension = _prefix "targetExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#acceptedMeansOfPayment"></see>
    /// </summary>
    let acceptedMeansOfPayment = _prefix "acceptedMeansOfPayment"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#acceptedPaymentCards"></see>
    /// </summary>
    let acceptedPaymentCards = _prefix "acceptedPaymentCards"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#chargeBand"></see>
    /// </summary>
    let chargeBand = _prefix "chargeBand"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#chargeBandByReference"></see>
    /// </summary>
    let chargeBandByReference = _prefix "chargeBandByReference"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#freeOfCharge"></see>
    /// </summary>
    let freeOfCharge = _prefix "freeOfCharge"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#paymentAdditionalDescription"></see>
    /// </summary>
    let paymentAdditionalDescription = _prefix "paymentAdditionalDescription"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#paymentMode"></see>
    /// </summary>
    let paymentMode = _prefix "paymentMode"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#reservationFee"></see>
    /// </summary>
    let reservationFee = _prefix "reservationFee"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tariffsAndPaymentExtension"></see>
    /// </summary>
    let tariffsAndPaymentExtension = _prefix "tariffsAndPaymentExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#airTemperature"></see>
    /// </summary>
    let airTemperature = _prefix "airTemperature"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#dewPointTemperature"></see>
    /// </summary>
    let dewPointTemperature = _prefix "dewPointTemperature"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maximumTemperature"></see>
    /// </summary>
    let maximumTemperature = _prefix "maximumTemperature"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#minimumTemperature"></see>
    /// </summary>
    let minimumTemperature = _prefix "minimumTemperature"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#temperatureExtension"></see>
    /// </summary>
    let temperatureExtension = _prefix "temperatureExtension"
    /// <summary>
    /// Measurements of atmospheric temperature.
    /// <see href="http://vocab.datex.org/terms#TemperatureInformation"></see></summary>
    let TemperatureInformation = _prefix "TemperatureInformation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#temperatureInformationExtension"></see>
    /// </summary>
    let temperatureInformationExtension = _prefix "temperatureInformationExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#temperatureValueExtension"></see>
    /// </summary>
    let temperatureValueExtension = _prefix "temperatureValueExtension"
    /// <summary>
    /// Settings specific to a distinct text display area on the VMS.
    /// <see href="http://vocab.datex.org/terms#TextDisplayAreaSettings"></see></summary>
    let TextDisplayAreaSettings = _prefix "TextDisplayAreaSettings"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#textDisplayAreaSettingsExtension"></see>
    /// </summary>
    let textDisplayAreaSettingsExtension = _prefix "textDisplayAreaSettingsExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#textLanternsOn"></see>
    /// </summary>
    let textLanternsOn = _prefix "textLanternsOn"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#textLuminanceLevel"></see>
    /// </summary>
    let textLuminanceLevel = _prefix "textLuminanceLevel"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#textLuminanceLevelName"></see>
    /// </summary>
    let textLuminanceLevelName = _prefix "textLuminanceLevelName"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#textLuminanceOverride"></see>
    /// </summary>
    let textLuminanceOverride = _prefix "textLuminanceOverride"
    /// <summary>
    /// End of time period.
    /// <see href="http://vocab.datex.org/terms#endTimeOfPeriod"></see></summary>
    let endTimeOfPeriod = _prefix "endTimeOfPeriod"
    /// <summary>
    /// Start of time period.
    /// <see href="http://vocab.datex.org/terms#startTimeOfPeriod"></see></summary>
    let startTimeOfPeriod = _prefix "startTimeOfPeriod"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#timePeriodByHourExtension"></see>
    /// </summary>
    let timePeriodByHourExtension = _prefix "timePeriodByHourExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#timePeriodOfDayExtension"></see>
    /// </summary>
    let timePeriodOfDayExtension = _prefix "timePeriodOfDayExtension"
    /// <summary>
    /// A descriptor for describing an area location.
    /// <see href="http://vocab.datex.org/terms#TpegAreaDescriptor"></see></summary>
    let TpegAreaDescriptor = _prefix "TpegAreaDescriptor"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegAreaDescriptorExtension"></see>
    /// </summary>
    let tpegAreaDescriptorExtension = _prefix "tpegAreaDescriptorExtension"
    /// <summary>
    /// The nature of the descriptor used to define the location under consideration (derived from the TPEG Loc table 03).
    /// <see href="http://vocab.datex.org/terms#tpegAreaDescriptorType"></see></summary>
    let tpegAreaDescriptorType = _prefix "tpegAreaDescriptorType"
    /// <summary>
    /// A collection of information providing descriptive references to locations using the TPEG-Loc location referencing approach.
    /// <see href="http://vocab.datex.org/terms#TpegDescriptor"></see></summary>
    let TpegDescriptor = _prefix "TpegDescriptor"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegAreaLocationExtension"></see>
    /// </summary>
    let tpegAreaLocationExtension = _prefix "tpegAreaLocationExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegAreaLocationType"></see>
    /// </summary>
    let tpegAreaLocationType = _prefix "tpegAreaLocationType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegHeight"></see>
    /// </summary>
    let tpegHeight = _prefix "tpegHeight"
    /// <summary>
    /// Height information which provides additional discrimination for the applicable area.
    /// <see href="http://vocab.datex.org/terms#TpegHeight"></see></summary>
    let TpegHeight = _prefix "TpegHeight"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#descriptor"></see>
    /// </summary>
    let descriptor = _prefix "descriptor"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegDescriptorExtension"></see>
    /// </summary>
    let tpegDescriptorExtension = _prefix "tpegDescriptorExtension"
    /// <summary>
    /// A point on the road network which is framed between two other points on the same road.
    /// <see href="http://vocab.datex.org/terms#TpegFramedPoint"></see></summary>
    let TpegFramedPoint = _prefix "TpegFramedPoint"
    /// <summary>
    /// A single non junction point on the road network which is framed between two other specified points on the road network.
    /// <see href="http://vocab.datex.org/terms#framedPoint"></see></summary>
    let framedPoint = _prefix "framedPoint"
    /// <summary>
    /// A point on the road network which is not a road junction point.
    /// <see href="http://vocab.datex.org/terms#TpegNonJunctionPoint"></see></summary>
    let TpegNonJunctionPoint = _prefix "TpegNonJunctionPoint"
    /// <summary>
    /// The location at the up stream end of the section of road which frames the TPEGFramedPoint.
    /// <see href="http://vocab.datex.org/terms#from"></see></summary>
    let from = _prefix "from"
    /// <summary>
    /// A point on the road network which is either a junction point or a non junction point.
    /// <see href="http://vocab.datex.org/terms#TpegPoint"></see></summary>
    let TpegPoint = _prefix "TpegPoint"
    /// <summary>
    /// The location at the down stream end of the section of road which frames the TPEGFramedPoint.
    /// <see href="http://vocab.datex.org/terms#to"></see></summary>
    let to_ = _prefix "to"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegFramedPointExtension"></see>
    /// </summary>
    let tpegFramedPointExtension = _prefix "tpegFramedPointExtension"
    /// <summary>
    /// The type of TPEG location.
    /// <see href="http://vocab.datex.org/terms#tpegFramedPointLocationType"></see></summary>
    let tpegFramedPointLocationType = _prefix "tpegFramedPointLocationType"
    /// <summary>
    /// A geometric area defined by a centre point and a radius.
    /// <see href="http://vocab.datex.org/terms#TpegGeometricArea"></see></summary>
    let TpegGeometricArea = _prefix "TpegGeometricArea"
    /// <summary>
    /// Centre point of a circular geometric area.
    /// <see href="http://vocab.datex.org/terms#centrePoint"></see></summary>
    let centrePoint = _prefix "centrePoint"
    /// <summary>
    /// A descriptive name which helps to identify the non junction point. At least one descriptor must identify the road on which the point is located, i.e. must be of type 'linkName' or 'localLinkName'.
    /// A name which identifies a junction point on the road network
    /// Name of area.
    /// <see href="http://vocab.datex.org/terms#name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegGeometricAreaExtension"></see>
    /// </summary>
    let tpegGeometricAreaExtension = _prefix "tpegGeometricAreaExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#height"></see>
    /// </summary>
    let height = _prefix "height"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#heightType"></see>
    /// </summary>
    let heightType = _prefix "heightType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegHeightExtension"></see>
    /// </summary>
    let tpegHeightExtension = _prefix "tpegHeightExtension"
    /// <summary>
    /// A descriptor for describing a junction by defining the intersecting roads.
    /// <see href="http://vocab.datex.org/terms#TpegIlcPointDescriptor"></see></summary>
    let TpegIlcPointDescriptor = _prefix "TpegIlcPointDescriptor"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegIlcPointDescriptorExtension"></see>
    /// </summary>
    let tpegIlcPointDescriptorExtension = _prefix "tpegIlcPointDescriptorExtension"
    /// <summary>
    /// The nature of the descriptor used to define the location under consideration (derived from the TPEG Loc table 03).
    /// <see href="http://vocab.datex.org/terms#tpegIlcPointDescriptorType"></see></summary>
    let tpegIlcPointDescriptorType = _prefix "tpegIlcPointDescriptorType"
    /// <summary>
    /// A descriptor for describing a point location.
    /// <see href="http://vocab.datex.org/terms#TpegPointDescriptor"></see></summary>
    let TpegPointDescriptor = _prefix "TpegPointDescriptor"
    /// <summary>
    /// A point on the road network which is a road junction point.
    /// <see href="http://vocab.datex.org/terms#TpegJunction"></see></summary>
    let TpegJunction = _prefix "TpegJunction"
    /// <summary>
    /// A descriptor for describing a junction by identifying the intersecting roads at a road junction.
    /// <see href="http://vocab.datex.org/terms#ilc"></see></summary>
    let ilc = _prefix "ilc"
    /// <summary>
    /// A descriptor for describing a point at a junction on a road network.
    /// <see href="http://vocab.datex.org/terms#TpegJunctionPointDescriptor"></see></summary>
    let TpegJunctionPointDescriptor = _prefix "TpegJunctionPointDescriptor"
    /// <summary>
    /// A descriptive name which helps to identify the junction point.
    /// <see href="http://vocab.datex.org/terms#otherName"></see></summary>
    let otherName = _prefix "otherName"
    /// <summary>
    /// General descriptor for describing a point.
    /// <see href="http://vocab.datex.org/terms#TpegOtherPointDescriptor"></see></summary>
    let TpegOtherPointDescriptor = _prefix "TpegOtherPointDescriptor"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegJunctionExtension"></see>
    /// </summary>
    let tpegJunctionExtension = _prefix "tpegJunctionExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegJunctionPointDescriptorExtension"></see>
    /// </summary>
    let tpegJunctionPointDescriptorExtension =
        _prefix "tpegJunctionPointDescriptorExtension"

    /// <summary>
    /// The nature of the descriptor used to define the location under consideration (derived from the TPEG Loc table 03).
    /// <see href="http://vocab.datex.org/terms#tpegJunctionPointDescriptorType"></see></summary>
    let tpegJunctionPointDescriptorType = _prefix "tpegJunctionPointDescriptorType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegDirection"></see>
    /// </summary>
    let tpegDirection = _prefix "tpegDirection"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegLinearLocationExtension"></see>
    /// </summary>
    let tpegLinearLocationExtension = _prefix "tpegLinearLocationExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegLinearLocationType"></see>
    /// </summary>
    let tpegLinearLocationType = _prefix "tpegLinearLocationType"
    /// <summary>
    /// An area defined by a well-known name.
    /// <see href="http://vocab.datex.org/terms#TpegNamedOnlyArea"></see></summary>
    let TpegNamedOnlyArea = _prefix "TpegNamedOnlyArea"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegNamedOnlyAreaExtension"></see>
    /// </summary>
    let tpegNamedOnlyAreaExtension = _prefix "tpegNamedOnlyAreaExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegNonJunctionPointExtension"></see>
    /// </summary>
    let tpegNonJunctionPointExtension = _prefix "tpegNonJunctionPointExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegOtherPointDescriptorExtension"></see>
    /// </summary>
    let tpegOtherPointDescriptorExtension = _prefix "tpegOtherPointDescriptorExtension"
    /// <summary>
    /// The nature of the descriptor used to define the location under consideration (derived from the TPEG Loc table 03).
    /// <see href="http://vocab.datex.org/terms#tpegOtherPointDescriptorType"></see></summary>
    let tpegOtherPointDescriptorType = _prefix "tpegOtherPointDescriptorType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegPointExtension"></see>
    /// </summary>
    let tpegPointExtension = _prefix "tpegPointExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegPointDescriptorExtension"></see>
    /// </summary>
    let tpegPointDescriptorExtension = _prefix "tpegPointDescriptorExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegPointLocationExtension"></see>
    /// </summary>
    let tpegPointLocationExtension = _prefix "tpegPointLocationExtension"
    /// <summary>
    /// A point on the road network which is not bounded by any other points on the road network.
    /// <see href="http://vocab.datex.org/terms#TpegSimplePoint"></see></summary>
    let TpegSimplePoint = _prefix "TpegSimplePoint"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegSimplePointExtension"></see>
    /// </summary>
    let tpegSimplePointExtension = _prefix "tpegSimplePointExtension"
    /// <summary>
    /// The type of TPEG location.
    /// <see href="http://vocab.datex.org/terms#tpegSimplePointLocationType"></see></summary>
    let tpegSimplePointLocationType = _prefix "tpegSimplePointLocationType"
    /// <summary>
    /// Averaged measurements or calculations of traffic concentration.
    /// <see href="http://vocab.datex.org/terms#TrafficConcentration"></see></summary>
    let TrafficConcentration = _prefix "TrafficConcentration"
    /// <summary>
    /// An averaged measurement or calculation of the concentration of vehicles at the specified measurement site.
    /// <see href="http://vocab.datex.org/terms#concentration"></see></summary>
    let concentration = _prefix "concentration"
    /// <summary>
    /// An averaged measurement or calculation of the percentage of time that a section of road at the specified measurement site is occupied by vehicles.
    /// <see href="http://vocab.datex.org/terms#occupancy"></see></summary>
    let occupancy = _prefix "occupancy"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#trafficConcentrationExtension"></see>
    /// </summary>
    let trafficConcentrationExtension = _prefix "trafficConcentrationExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#trafficDataExtension"></see>
    /// </summary>
    let trafficDataExtension = _prefix "trafficDataExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#trafficElementExtension"></see>
    /// </summary>
    let trafficElementExtension = _prefix "trafficElementExtension"
    /// <summary>
    /// Averaged measurements or calculations of traffic flow rates.
    /// <see href="http://vocab.datex.org/terms#TrafficFlow"></see></summary>
    let TrafficFlow = _prefix "TrafficFlow"
    /// <summary>
    /// An averaged measurement or calculation of flow rate defined in terms of the number of vehicle axles passing the specified measurement site.
    /// <see href="http://vocab.datex.org/terms#axleFlow"></see></summary>
    let axleFlow = _prefix "axleFlow"
    /// <summary>
    /// An averaged measurement or calculation of flow rate defined in terms of the number of passenger car units passing the specified measurement site.
    /// <see href="http://vocab.datex.org/terms#pcuFlow"></see></summary>
    let pcuFlow = _prefix "pcuFlow"
    /// <summary>
    /// An averaged measurement or calculation of the percentage of long vehicles contained in the traffic flow at the specified measurement site.
    /// <see href="http://vocab.datex.org/terms#percentageLongVehicles"></see></summary>
    let percentageLongVehicles = _prefix "percentageLongVehicles"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#trafficFlowExtension"></see>
    /// </summary>
    let trafficFlowExtension = _prefix "trafficFlowExtension"
    /// <summary>
    /// An averaged measurement of flow rate defined in terms of the number of vehicles passing the specified measurement site.
    /// <see href="http://vocab.datex.org/terms#vehicleFlow"></see></summary>
    let vehicleFlow = _prefix "vehicleFlow"
    /// <summary>
    /// A measured or calculated value of the flow rate of vehicles.
    /// <see href="http://vocab.datex.org/terms#VehicleFlowValue"></see></summary>
    let VehicleFlowValue = _prefix "VehicleFlowValue"
    /// <summary>
    /// Averaged measurements or calculations of traffic headway, i.e. the distance or time interval between vehicles. This measure is measured from the head of one vehicle to the head of the following vehicle.
    /// <see href="http://vocab.datex.org/terms#TrafficHeadway"></see></summary>
    let TrafficHeadway = _prefix "TrafficHeadway"
    /// <summary>
    /// The average distance between the front (respectively back) of this vehicle and the front (respectively  back) of the preceding vehicle, averaged for all vehicles within a defined measurement period at the specified measurement site.
    /// <see href="http://vocab.datex.org/terms#averageDistanceHeadway"></see></summary>
    let averageDistanceHeadway = _prefix "averageDistanceHeadway"
    /// <summary>
    /// The average time gap between the front (respectively back) of this vehicle and the front (respectively  back) of the preceding vehicle, averaged for all vehicles within a defined measurement period at the specified measurement site.
    /// <see href="http://vocab.datex.org/terms#averageTimeHeadway"></see></summary>
    let averageTimeHeadway = _prefix "averageTimeHeadway"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#trafficHeadwayExtension"></see>
    /// </summary>
    let trafficHeadwayExtension = _prefix "trafficHeadwayExtension"
    /// <summary>
    /// Averaged measurements or calculations of traffic speed.
    /// <see href="http://vocab.datex.org/terms#TrafficSpeed"></see></summary>
    let TrafficSpeed = _prefix "TrafficSpeed"
    /// <summary>
    /// An averaged measurement or calculation of the speed of vehicles at the specified location.
    /// <see href="http://vocab.datex.org/terms#averageVehicleSpeed"></see></summary>
    let averageVehicleSpeed = _prefix "averageVehicleSpeed"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#trafficSpeedExtension"></see>
    /// </summary>
    let trafficSpeedExtension = _prefix "trafficSpeedExtension"
    /// <summary>
    /// The status of traffic conditions on a specific section or at a specific point on the road network.
    /// <see href="http://vocab.datex.org/terms#TrafficStatus"></see></summary>
    let TrafficStatus = _prefix "TrafficStatus"
    /// <summary>
    /// Status of traffic conditions on the identified section of road in the specified direction.
    /// <see href="http://vocab.datex.org/terms#trafficStatus"></see></summary>
    let trafficStatus = _prefix "trafficStatus"
    /// <summary>
    /// A measured or calculated value of the status of traffic conditions on a section of road in a specified direction.
    /// <see href="http://vocab.datex.org/terms#TrafficStatusValue"></see></summary>
    let TrafficStatusValue = _prefix "TrafficStatusValue"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#trafficStatusExtension"></see>
    /// </summary>
    let trafficStatusExtension = _prefix "trafficStatusExtension"
    /// <summary>
    /// A status value of traffic conditions on the identified section of road in the specified direction.
    /// <see href="http://vocab.datex.org/terms#trafficStatusValue"></see></summary>
    let trafficStatusValue = _prefix "trafficStatusValue"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#trafficStatusValueExtension"></see>
    /// </summary>
    let trafficStatusValueExtension = _prefix "trafficStatusValueExtension"
    /// <summary>
    /// An identifiable instance of a traffic view at a single point in time relating to a predefined location set, comprising one or more linear traffic views each of which comprise one or more traffic view records.
    /// <see href="http://vocab.datex.org/terms#TrafficView"></see></summary>
    let TrafficView = _prefix "TrafficView"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#linearTrafficView"></see>
    /// </summary>
    let linearTrafficView = _prefix "linearTrafficView"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#trafficViewExtension"></see>
    /// </summary>
    let trafficViewExtension = _prefix "trafficViewExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#trafficViewTime"></see>
    /// </summary>
    let trafficViewTime = _prefix "trafficViewTime"
    /// <summary>
    /// A publication containing one or more traffic views.
    /// <see href="http://vocab.datex.org/terms#TrafficViewPublication"></see></summary>
    let TrafficViewPublication = _prefix "TrafficViewPublication"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#trafficView"></see>
    /// </summary>
    let trafficView = _prefix "trafficView"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#trafficViewPublicationExtension"></see>
    /// </summary>
    let trafficViewPublicationExtension = _prefix "trafficViewPublicationExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#operatorAction"></see>
    /// </summary>
    let operatorAction = _prefix "operatorAction"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#recordSequenceNumber"></see>
    /// </summary>
    let recordSequenceNumber = _prefix "recordSequenceNumber"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#trafficElement"></see>
    /// </summary>
    let trafficElement = _prefix "trafficElement"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#trafficViewRecordExtension"></see>
    /// </summary>
    let trafficViewRecordExtension = _prefix "trafficViewRecordExtension"
    /// <summary>
    /// The availability of transit services and information relating to their departures. This is limited to those transit services which are of direct relevance to road users, e.g. connecting rail or ferry services.
    /// <see href="http://vocab.datex.org/terms#TransitInformation"></see></summary>
    let TransitInformation = _prefix "TransitInformation"
    /// <summary>
    /// Indicates the stated termination point of the transit journey.
    /// <see href="http://vocab.datex.org/terms#journeyDestination"></see></summary>
    let journeyDestination = _prefix "journeyDestination"
    /// <summary>
    /// Indicates the stated starting point of the transit journey.
    /// <see href="http://vocab.datex.org/terms#journeyOrigin"></see></summary>
    let journeyOrigin = _prefix "journeyOrigin"
    /// <summary>
    /// Indicates a transit service journey number.
    /// <see href="http://vocab.datex.org/terms#journeyReference"></see></summary>
    let journeyReference = _prefix "journeyReference"
    /// <summary>
    /// Indicates the timetabled departure time of a transit service for a specified location.
    /// <see href="http://vocab.datex.org/terms#scheduledDepartureTime"></see></summary>
    let scheduledDepartureTime = _prefix "scheduledDepartureTime"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#transitInformationExtension"></see>
    /// </summary>
    let transitInformationExtension = _prefix "transitInformationExtension"
    /// <summary>
    /// Information about transit services.
    /// <see href="http://vocab.datex.org/terms#transitServiceInformation"></see></summary>
    let transitServiceInformation = _prefix "transitServiceInformation"
    /// <summary>
    /// The type of transit service to which the information relates.
    /// <see href="http://vocab.datex.org/terms#transitServiceType"></see></summary>
    let transitServiceType = _prefix "transitServiceType"
    /// <summary>
    /// Derived/computed travel time information relating to a linear section of the road network; forecast = true means a forecast for a vehicle at the start of the specified location, forecast = false means calculation/measurement at the end.
    /// <see href="http://vocab.datex.org/terms#TravelTimeData"></see></summary>
    let TravelTimeData = _prefix "TravelTimeData"
    /// <summary>
    /// The free flow speed expected under ideal conditions, corresponding to the freeFlowTravelTime.
    /// <see href="http://vocab.datex.org/terms#freeFlowSpeed"></see></summary>
    let freeFlowSpeed = _prefix "freeFlowSpeed"
    /// <summary>
    /// The travel time which would be expected under ideal free flow conditions.
    /// <see href="http://vocab.datex.org/terms#freeFlowTravelTime"></see></summary>
    let freeFlowTravelTime = _prefix "freeFlowTravelTime"
    /// <summary>
    /// The travel time which is expected for the given period (e.g. date/time, holiday status etc.) and any known quasi-static conditions (e.g. long term roadworks). This value is derived from historical analysis.
    /// <see href="http://vocab.datex.org/terms#normallyExpectedTravelTime"></see></summary>
    let normallyExpectedTravelTime = _prefix "normallyExpectedTravelTime"
    /// <summary>
    /// Derived/computed travel time information relating to a specific group of locations.
    /// <see href="http://vocab.datex.org/terms#travelTime"></see></summary>
    let travelTime = _prefix "travelTime"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#travelTimeDataExtension"></see>
    /// </summary>
    let travelTimeDataExtension = _prefix "travelTimeDataExtension"
    /// <summary>
    /// The current trend in the travel time between the defined locations in the specified direction.
    /// <see href="http://vocab.datex.org/terms#travelTimeTrendType"></see></summary>
    let travelTimeTrendType = _prefix "travelTimeTrendType"
    /// <summary>
    /// Indication of the way in which the travel time is derived.
    /// <see href="http://vocab.datex.org/terms#travelTimeType"></see></summary>
    let travelTimeType = _prefix "travelTimeType"
    /// <summary>
    /// Vehicle type.
    /// <see href="http://vocab.datex.org/terms#vehicleType"></see></summary>
    let vehicleType = _prefix "vehicleType"
    /// <summary>
    /// A parking site in an urban context.
    /// <see href="http://vocab.datex.org/terms#UrbanParkingSite"></see></summary>
    let UrbanParkingSite = _prefix "UrbanParkingSite"
    /// <summary>
    /// Name or identifier of a parking zone this parking site belongs to. To be filled with the string value 'True', if there is a parking zone with unknown name.
    /// <see href="http://vocab.datex.org/terms#parkingZone"></see></summary>
    let parkingZone = _prefix "parkingZone"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#urbanParkingSiteExtension"></see>
    /// </summary>
    let urbanParkingSiteExtension = _prefix "urbanParkingSiteExtension"
    /// <summary>
    /// The type of urban parking site.
    /// <see href="http://vocab.datex.org/terms#urbanParkingSiteType"></see></summary>
    let urbanParkingSiteType = _prefix "urbanParkingSiteType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#urlLinkDescription"></see>
    /// </summary>
    let urlLinkDescription = _prefix "urlLinkDescription"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#urlLinkExtension"></see>
    /// </summary>
    let urlLinkExtension = _prefix "urlLinkExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#urlLinkType"></see>
    /// </summary>
    let urlLinkType = _prefix "urlLinkType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#otherPaymentCard"></see>
    /// </summary>
    let otherPaymentCard = _prefix "otherPaymentCard"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#otherPaymentCardBrand"></see>
    /// </summary>
    let otherPaymentCardBrand = _prefix "otherPaymentCardBrand"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#paymentCard"></see>
    /// </summary>
    let paymentCard = _prefix "paymentCard"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#paymentCardBrand"></see>
    /// </summary>
    let paymentCardBrand = _prefix "paymentCardBrand"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#usedPaymentCardExtension"></see>
    /// </summary>
    let usedPaymentCardExtension = _prefix "usedPaymentCardExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#overrunning"></see>
    /// </summary>
    let overrunning = _prefix "overrunning"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#validityExtension"></see>
    /// </summary>
    let validityExtension = _prefix "validityExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#validityStatus"></see>
    /// </summary>
    let validityStatus = _prefix "validityStatus"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#axleSpacingOnVehicle"></see>
    /// </summary>
    let axleSpacingOnVehicle = _prefix "axleSpacingOnVehicle"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#hazardousGoodsAssociatedWithVehicle"></see>
    /// </summary>
    let hazardousGoodsAssociatedWithVehicle =
        _prefix "hazardousGoodsAssociatedWithVehicle"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#specificAxleWeight"></see>
    /// </summary>
    let specificAxleWeight = _prefix "specificAxleWeight"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleColour"></see>
    /// </summary>
    let vehicleColour = _prefix "vehicleColour"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleCountryOfOrigin"></see>
    /// </summary>
    let vehicleCountryOfOrigin = _prefix "vehicleCountryOfOrigin"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleExtension"></see>
    /// </summary>
    let vehicleExtension = _prefix "vehicleExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleIdentifier"></see>
    /// </summary>
    let vehicleIdentifier = _prefix "vehicleIdentifier"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleManufacturer"></see>
    /// </summary>
    let vehicleManufacturer = _prefix "vehicleManufacturer"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleModel"></see>
    /// </summary>
    let vehicleModel = _prefix "vehicleModel"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleRegistrationPlateIdentifier"></see>
    /// </summary>
    let vehicleRegistrationPlateIdentifier =
        _prefix "vehicleRegistrationPlateIdentifier"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#fuelType"></see>
    /// </summary>
    let fuelType = _prefix "fuelType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#grossWeightCharacteristic"></see>
    /// </summary>
    let grossWeightCharacteristic = _prefix "grossWeightCharacteristic"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#heaviestAxleWeightCharacteristic"></see>
    /// </summary>
    let heaviestAxleWeightCharacteristic = _prefix "heaviestAxleWeightCharacteristic"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#heightCharacteristic"></see>
    /// </summary>
    let heightCharacteristic = _prefix "heightCharacteristic"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#lengthCharacteristic"></see>
    /// </summary>
    let lengthCharacteristic = _prefix "lengthCharacteristic"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#loadType"></see>
    /// </summary>
    let loadType = _prefix "loadType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#numberOfAxlesCharacteristic"></see>
    /// </summary>
    let numberOfAxlesCharacteristic = _prefix "numberOfAxlesCharacteristic"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleCharacteristicsExtension"></see>
    /// </summary>
    let vehicleCharacteristicsExtension = _prefix "vehicleCharacteristicsExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_VehicleCharacteristicsExtensionType"></see>
    /// </summary>
    let _VehicleCharacteristicsExtensionType =
        _prefix "_VehicleCharacteristicsExtensionType"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleEquipment"></see>
    /// </summary>
    let vehicleEquipment = _prefix "vehicleEquipment"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleUsage"></see>
    /// </summary>
    let vehicleUsage = _prefix "vehicleUsage"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#widthCharacteristic"></see>
    /// </summary>
    let widthCharacteristic = _prefix "widthCharacteristic"
    /// <summary>
    /// Width characteristic of a vehicle.
    /// <see href="http://vocab.datex.org/terms#WidthCharacteristic"></see></summary>
    let WidthCharacteristic = _prefix "WidthCharacteristic"
    /// <summary>
    /// Extension point for 'VehicleCharacteristics' to support additional attributes and literals like additional fuel types, load types etc.
    /// <see href="http://vocab.datex.org/terms#VehicleCharacteristicsExtended"></see></summary>
    let VehicleCharacteristicsExtended = _prefix "VehicleCharacteristicsExtended"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#emissionClassification"></see>
    /// </summary>
    let emissionClassification = _prefix "emissionClassification"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#fuelType2"></see>
    /// </summary>
    let fuelType2 = _prefix "fuelType2"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#loadType2"></see>
    /// </summary>
    let loadType2 = _prefix "loadType2"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#operationFreeOfEmission"></see>
    /// </summary>
    let operationFreeOfEmission = _prefix "operationFreeOfEmission"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleType2"></see>
    /// </summary>
    let vehicleType2 = _prefix "vehicleType2"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleUsage2"></see>
    /// </summary>
    let vehicleUsage2 = _prefix "vehicleUsage2"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#coveringPetrolStationArea"></see>
    /// </summary>
    let coveringPetrolStationArea = _prefix "coveringPetrolStationArea"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measuredValueIndex"></see>
    /// </summary>
    let measuredValueIndex = _prefix "measuredValueIndex"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleCountAndRateExtension"></see>
    /// </summary>
    let vehicleCountAndRateExtension = _prefix "vehicleCountAndRateExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleCountWithinInterval"></see>
    /// </summary>
    let vehicleCountWithinInterval = _prefix "vehicleCountWithinInterval"
    /// <summary>
    /// Gives incoming and/or outgoing vehicles and/or change of occupied spaces within a given interval. The interval is given in positive or negative seconds related to 'measurementOrCalculationTime' or 'measurementDefaultTime'.
    /// <see href="http://vocab.datex.org/terms#VehicleCountWithinInterval"></see></summary>
    let VehicleCountWithinInterval = _prefix "VehicleCountWithinInterval"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleRate"></see>
    /// </summary>
    let vehicleRate = _prefix "vehicleRate"
    /// <summary>
    /// Gives information about fill and exit rates OR vehicle flow rate (without direction). If the time stamp is omitted, 'measurementTimeDefault' is used.
    /// <see href="http://vocab.datex.org/terms#VehicleRate"></see></summary>
    let VehicleRate = _prefix "VehicleRate"
    /// <summary>
    /// A measured or calculated value of absolute count of vehicles within a specified period of time expressed as non negative integer.
    /// <see href="http://vocab.datex.org/terms#VehicleCountValue"></see></summary>
    let VehicleCountValue = _prefix "VehicleCountValue"
    /// <summary>
    /// A measured or calculated absolute count of vehicles within a specified period of time expressed as non negative integer.
    /// <see href="http://vocab.datex.org/terms#vehicleCount"></see></summary>
    let vehicleCount = _prefix "vehicleCount"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleCountValueExtension"></see>
    /// </summary>
    let vehicleCountValueExtension = _prefix "vehicleCountValueExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#changeOfOccupiedSpaces"></see>
    /// </summary>
    let changeOfOccupiedSpaces = _prefix "changeOfOccupiedSpaces"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#countedVehicles"></see>
    /// </summary>
    let countedVehicles = _prefix "countedVehicles"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementInterval"></see>
    /// </summary>
    let measurementInterval = _prefix "measurementInterval"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementOrCalcualtionTime"></see>
    /// </summary>
    let measurementOrCalcualtionTime = _prefix "measurementOrCalcualtionTime"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#numberOfIncomingVehicles"></see>
    /// </summary>
    let numberOfIncomingVehicles = _prefix "numberOfIncomingVehicles"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#numberOfOutgoingVehicles"></see>
    /// </summary>
    let numberOfOutgoingVehicles = _prefix "numberOfOutgoingVehicles"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleCountWithinIntervalExtension"></see>
    /// </summary>
    let vehicleCountWithinIntervalExtension =
        _prefix "vehicleCountWithinIntervalExtension"

    /// <summary>
    /// A value of vehicle flow rate expressed in vehicles per hour.
    /// <see href="http://vocab.datex.org/terms#vehicleFlowRate"></see></summary>
    let vehicleFlowRate = _prefix "vehicleFlowRate"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleFlowValueExtension"></see>
    /// </summary>
    let vehicleFlowValueExtension = _prefix "vehicleFlowValueExtension"
    /// <summary>
    /// The obstructing vehicle.
    /// <see href="http://vocab.datex.org/terms#obstructingVehicle"></see></summary>
    let obstructingVehicle = _prefix "obstructingVehicle"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleObstructionExtension"></see>
    /// </summary>
    let vehicleObstructionExtension = _prefix "vehicleObstructionExtension"
    /// <summary>
    /// Characterization of an obstruction on the road caused by one or more vehicles.
    /// <see href="http://vocab.datex.org/terms#vehicleObstructionType"></see></summary>
    let vehicleObstructionType = _prefix "vehicleObstructionType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measuredVehicles"></see>
    /// </summary>
    let measuredVehicles = _prefix "measuredVehicles"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleRateExtension"></see>
    /// </summary>
    let vehicleRateExtension = _prefix "vehicleRateExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VersionedReference"></see>
    /// </summary>
    let VersionedReference = _prefix "VersionedReference"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#minimumVisibilityDistance"></see>
    /// </summary>
    let minimumVisibilityDistance = _prefix "minimumVisibilityDistance"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#visibilityExtension"></see>
    /// </summary>
    let visibilityExtension = _prefix "visibilityExtension"
    /// <summary>
    /// Measurements of atmospheric visibility.
    /// <see href="http://vocab.datex.org/terms#VisibilityInformation"></see></summary>
    let VisibilityInformation = _prefix "VisibilityInformation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#visibilityInformationExtension"></see>
    /// </summary>
    let visibilityInformationExtension = _prefix "visibilityInformationExtension"
    /// <summary>
    /// Provides the current status and settings of the VMS and the currently displayed information. Where a VMS is displaying a sequence or alternating set of messages these are ordered according to the messageIndex qualifier.
    /// <see href="http://vocab.datex.org/terms#Vms"></see></summary>
    let Vms = _prefix "Vms"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#managedLogicalLocationOverride"></see>
    /// </summary>
    let managedLogicalLocationOverride = _prefix "managedLogicalLocationOverride"
    /// <summary>
    /// The logical location (e.g. a car park, a section of road, a junction etc.) which a VMS contributes to the management of.
    /// <see href="http://vocab.datex.org/terms#VmsManagedLogicalLocation"></see></summary>
    let VmsManagedLogicalLocation = _prefix "VmsManagedLogicalLocation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramDisplayAreaSettings"></see>
    /// </summary>
    let pictogramDisplayAreaSettings = _prefix "pictogramDisplayAreaSettings"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_VmsPictogramDisplayAreaIndexPictogramDisplayAreaSettings"></see>
    /// </summary>
    let _VmsPictogramDisplayAreaIndexPictogramDisplayAreaSettings =
        _prefix "_VmsPictogramDisplayAreaIndexPictogramDisplayAreaSettings"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#textDisplayAreaSettings"></see>
    /// </summary>
    let textDisplayAreaSettings = _prefix "textDisplayAreaSettings"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsDynamicCharacteristics"></see>
    /// </summary>
    let vmsDynamicCharacteristics = _prefix "vmsDynamicCharacteristics"
    /// <summary>
    /// Provides the current characteristic settings for the VMS which can be dynamically configured and therefore which override any corresponding characteristics set for the VMS in the relevant VmsUnitPublication.
    /// <see href="http://vocab.datex.org/terms#VmsDynamicCharacteristics"></see></summary>
    let VmsDynamicCharacteristics = _prefix "VmsDynamicCharacteristics"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsExtension"></see>
    /// </summary>
    let vmsExtension = _prefix "vmsExtension"
    /// <summary>
    /// The type of fault which is being reported for the specified variable message sign panel.
    /// <see href="http://vocab.datex.org/terms#vmsFault"></see></summary>
    let vmsFault = _prefix "vmsFault"
    /// <summary>
    /// Details of the fault which is being reported for the specified variable message sign panel.
    /// <see href="http://vocab.datex.org/terms#VmsFault"></see></summary>
    let VmsFault = _prefix "VmsFault"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsLocationOverride"></see>
    /// </summary>
    let vmsLocationOverride = _prefix "vmsLocationOverride"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsMessage"></see>
    /// </summary>
    let vmsMessage = _prefix "vmsMessage"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_VmsMessageIndexVmsMessage"></see>
    /// </summary>
    let _VmsMessageIndexVmsMessage = _prefix "_VmsMessageIndexVmsMessage"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsMessageSequencingInterval"></see>
    /// </summary>
    let vmsMessageSequencingInterval = _prefix "vmsMessageSequencingInterval"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsWorking"></see>
    /// </summary>
    let vmsWorking = _prefix "vmsWorking"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#numberOfPictogramDisplayAreas"></see>
    /// </summary>
    let numberOfPictogramDisplayAreas = _prefix "numberOfPictogramDisplayAreas"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsDynamicCharacteristicsExtension"></see>
    /// </summary>
    let vmsDynamicCharacteristicsExtension =
        _prefix "vmsDynamicCharacteristicsExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsPictogramDisplayCharacteristics"></see>
    /// </summary>
    let vmsPictogramDisplayCharacteristics =
        _prefix "vmsPictogramDisplayCharacteristics"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_VmsDynamicCharacteristicsPictogramDisplayAreaIndexVmsPictogramDisplayCharacteristics"></see>
    /// </summary>
    let _VmsDynamicCharacteristicsPictogramDisplayAreaIndexVmsPictogramDisplayCharacteristics =
        _prefix "_VmsDynamicCharacteristicsPictogramDisplayAreaIndexVmsPictogramDisplayCharacteristics"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsTextDisplayCharacteristics"></see>
    /// </summary>
    let vmsTextDisplayCharacteristics = _prefix "vmsTextDisplayCharacteristics"
    /// <summary>
    /// Characteristics specific to the textual display area on the VMS.
    /// <see href="http://vocab.datex.org/terms#VmsTextDisplayCharacteristics"></see></summary>
    let VmsTextDisplayCharacteristics = _prefix "VmsTextDisplayCharacteristics"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsFaultExtension"></see>
    /// </summary>
    let vmsFaultExtension = _prefix "vmsFaultExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#distanceFromLogicalLocation"></see>
    /// </summary>
    let distanceFromLogicalLocation = _prefix "distanceFromLogicalLocation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#managedLocation"></see>
    /// </summary>
    let managedLocation = _prefix "managedLocation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#managedLogicalLocation"></see>
    /// </summary>
    let managedLogicalLocation = _prefix "managedLogicalLocation"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsManagedLogicalLocationExtension"></see>
    /// </summary>
    let vmsManagedLogicalLocationExtension =
        _prefix "vmsManagedLogicalLocationExtension"

    /// <summary>
    /// A message displayed on a VMS which may comprise one or more sequentially displayed text pages and/or pictograms with supplementary details. When in a sequence of displayed messages sequencing of text pages and pictograms within a message are prohibited.
    /// <see href="http://vocab.datex.org/terms#VmsMessage"></see></summary>
    let VmsMessage = _prefix "VmsMessage"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#associatedManagementOrDiversionPlan"></see>
    /// </summary>
    let associatedManagementOrDiversionPlan =
        _prefix "associatedManagementOrDiversionPlan"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#codedReasonForSetting"></see>
    /// </summary>
    let codedReasonForSetting = _prefix "codedReasonForSetting"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#distanceFromSituationRecord"></see>
    /// </summary>
    let distanceFromSituationRecord = _prefix "distanceFromSituationRecord"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#mareNostrumCompliant"></see>
    /// </summary>
    let mareNostrumCompliant = _prefix "mareNostrumCompliant"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#messageSetBy"></see>
    /// </summary>
    let messageSetBy = _prefix "messageSetBy"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#primarySetting"></see>
    /// </summary>
    let primarySetting = _prefix "primarySetting"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#reasonForSetting"></see>
    /// </summary>
    let reasonForSetting = _prefix "reasonForSetting"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#requestedBy"></see>
    /// </summary>
    let requestedBy = _prefix "requestedBy"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#setBySystem"></see>
    /// </summary>
    let setBySystem = _prefix "setBySystem"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#situationRecordToWhichMessageIsRelated"></see>
    /// </summary>
    let situationRecordToWhichMessageIsRelated =
        _prefix "situationRecordToWhichMessageIsRelated"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#situationToWhichMessageIsRelated"></see>
    /// </summary>
    let situationToWhichMessageIsRelated = _prefix "situationToWhichMessageIsRelated"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#textPage"></see>
    /// </summary>
    let textPage = _prefix "textPage"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_TextPage"></see>
    /// </summary>
    let _TextPage = _prefix "_TextPage"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#textPictogramSequencingInterval"></see>
    /// </summary>
    let textPictogramSequencingInterval = _prefix "textPictogramSequencingInterval"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#timeLastSet"></see>
    /// </summary>
    let timeLastSet = _prefix "timeLastSet"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsMessageExtension"></see>
    /// </summary>
    let vmsMessageExtension = _prefix "vmsMessageExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsMessageInformationType"></see>
    /// </summary>
    let vmsMessageInformationType = _prefix "vmsMessageInformationType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsPictogramDisplayArea"></see>
    /// </summary>
    let vmsPictogramDisplayArea = _prefix "vmsPictogramDisplayArea"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_VmsMessagePictogramDisplayAreaIndexVmsPictogramDisplayArea"></see>
    /// </summary>
    let _VmsMessagePictogramDisplayAreaIndexVmsPictogramDisplayArea =
        _prefix "_VmsMessagePictogramDisplayAreaIndexVmsPictogramDisplayArea"

    /// <summary>
    /// A main pictogram displayable on the VMS panel. Note a main pictogram may have an associated supplementary panel which may itself contain a further pictogram and line of text.
    /// <see href="http://vocab.datex.org/terms#VmsPictogram"></see></summary>
    let VmsPictogram = _prefix "VmsPictogram"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#additionalPictogramDescription"></see>
    /// </summary>
    let additionalPictogramDescription = _prefix "additionalPictogramDescription"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#distanceAttribute"></see>
    /// </summary>
    let distanceAttribute = _prefix "distanceAttribute"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#heightAttribute"></see>
    /// </summary>
    let heightAttribute = _prefix "heightAttribute"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#lengthAttribute"></see>
    /// </summary>
    let lengthAttribute = _prefix "lengthAttribute"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramCode"></see>
    /// </summary>
    let pictogramCode = _prefix "pictogramCode"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramDescription"></see>
    /// </summary>
    let pictogramDescription = _prefix "pictogramDescription"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramFlashing"></see>
    /// </summary>
    let pictogramFlashing = _prefix "pictogramFlashing"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramInInverseColour"></see>
    /// </summary>
    let pictogramInInverseColour = _prefix "pictogramInInverseColour"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramUrl"></see>
    /// </summary>
    let pictogramUrl = _prefix "pictogramUrl"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#presenceOfRedTriangle"></see>
    /// </summary>
    let presenceOfRedTriangle = _prefix "presenceOfRedTriangle"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#speedAttribute"></see>
    /// </summary>
    let speedAttribute = _prefix "speedAttribute"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#viennaConventionCompliant"></see>
    /// </summary>
    let viennaConventionCompliant = _prefix "viennaConventionCompliant"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsPictogramExtension"></see>
    /// </summary>
    let vmsPictogramExtension = _prefix "vmsPictogramExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsSupplementaryPanel"></see>
    /// </summary>
    let vmsSupplementaryPanel = _prefix "vmsSupplementaryPanel"
    /// <summary>
    /// A panel which may display information or a regulatory instruction which is supplemental to the associated pictogram, comprising either an additional line of text or a pictogram or both.
    /// <see href="http://vocab.datex.org/terms#VmsSupplementaryPanel"></see></summary>
    let VmsSupplementaryPanel = _prefix "VmsSupplementaryPanel"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#weightAttribute"></see>
    /// </summary>
    let weightAttribute = _prefix "weightAttribute"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#weightPerAxleAttribute"></see>
    /// </summary>
    let weightPerAxleAttribute = _prefix "weightPerAxleAttribute"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#widthAttribute"></see>
    /// </summary>
    let widthAttribute = _prefix "widthAttribute"
    /// <summary>
    /// An area on a VMS used for the display of pictograms and associated supplemental information or instructions.
    /// <see href="http://vocab.datex.org/terms#VmsPictogramDisplayArea"></see></summary>
    let VmsPictogramDisplayArea = _prefix "VmsPictogramDisplayArea"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#synchronizedSequencingWithTextPages"></see>
    /// </summary>
    let synchronizedSequencingWithTextPages =
        _prefix "synchronizedSequencingWithTextPages"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsPictogram"></see>
    /// </summary>
    let vmsPictogram = _prefix "vmsPictogram"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_VmsPictogramDisplayAreaPictogramSequencingIndexVmsPictogram"></see>
    /// </summary>
    let _VmsPictogramDisplayAreaPictogramSequencingIndexVmsPictogram =
        _prefix "_VmsPictogramDisplayAreaPictogramSequencingIndexVmsPictogram"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsPictogramDisplayAreaExtension"></see>
    /// </summary>
    let vmsPictogramDisplayAreaExtension = _prefix "vmsPictogramDisplayAreaExtension"

    /// <summary>
    /// Characteristics specific to the pictogram display area(s) on the VMS where pictogramDisplayAreaIndex indicates which pictogram area it relates to.
    /// <see href="http://vocab.datex.org/terms#VmsPictogramDisplayCharacteristics"></see></summary>
    let VmsPictogramDisplayCharacteristics =
        _prefix "VmsPictogramDisplayCharacteristics"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maxNumberOfSequentialPictograms"></see>
    /// </summary>
    let maxNumberOfSequentialPictograms = _prefix "maxNumberOfSequentialPictograms"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maxPictogramLuminanceLevel"></see>
    /// </summary>
    let maxPictogramLuminanceLevel = _prefix "maxPictogramLuminanceLevel"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramCodeListIdentifier"></see>
    /// </summary>
    let pictogramCodeListIdentifier = _prefix "pictogramCodeListIdentifier"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramDisplayHeight"></see>
    /// </summary>
    let pictogramDisplayHeight = _prefix "pictogramDisplayHeight"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramDisplayWidth"></see>
    /// </summary>
    let pictogramDisplayWidth = _prefix "pictogramDisplayWidth"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramLanternsPresent"></see>
    /// </summary>
    let pictogramLanternsPresent = _prefix "pictogramLanternsPresent"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramNumberOfColours"></see>
    /// </summary>
    let pictogramNumberOfColours = _prefix "pictogramNumberOfColours"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramPixelsAcross"></see>
    /// </summary>
    let pictogramPixelsAcross = _prefix "pictogramPixelsAcross"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramPixelsDown"></see>
    /// </summary>
    let pictogramPixelsDown = _prefix "pictogramPixelsDown"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramPositionAbsolute"></see>
    /// </summary>
    let pictogramPositionAbsolute = _prefix "pictogramPositionAbsolute"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramPositionRelativeToText"></see>
    /// </summary>
    let pictogramPositionRelativeToText = _prefix "pictogramPositionRelativeToText"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramPositionX"></see>
    /// </summary>
    let pictogramPositionX = _prefix "pictogramPositionX"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramPositionY"></see>
    /// </summary>
    let pictogramPositionY = _prefix "pictogramPositionY"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramSequencingCapable"></see>
    /// </summary>
    let pictogramSequencingCapable = _prefix "pictogramSequencingCapable"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsPictogramDisplayCharacteristicsExtension"></see>
    /// </summary>
    let vmsPictogramDisplayCharacteristicsExtension =
        _prefix "vmsPictogramDisplayCharacteristicsExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsSupplementaryPanelCharacteristics"></see>
    /// </summary>
    let vmsSupplementaryPanelCharacteristics =
        _prefix "vmsSupplementaryPanelCharacteristics"

    /// <summary>
    /// Characteristics of a panel which may display details (sometimes regulatory in nature) that are supplemental to the main pictogram, comprising an additional line of text and/or a pictogram.
    /// <see href="http://vocab.datex.org/terms#VmsSupplementaryPanelCharacteristics"></see></summary>
    let VmsSupplementaryPanelCharacteristics =
        _prefix "VmsSupplementaryPanelCharacteristics"

    /// <summary>
    /// A publication containing the current status and settings of one or more VMS units, each unit controlling one or more individual variable message signs.
    /// <see href="http://vocab.datex.org/terms#VmsPublication"></see></summary>
    let VmsPublication = _prefix "VmsPublication"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsPublicationExtension"></see>
    /// </summary>
    let vmsPublicationExtension = _prefix "vmsPublicationExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsUnit"></see>
    /// </summary>
    let vmsUnit = _prefix "vmsUnit"
    /// <summary>
    /// Status of a VMS unit which may control one or more variable message signs on a single gantry or on different gantries.
    /// <see href="http://vocab.datex.org/terms#VmsUnit"></see></summary>
    let VmsUnit = _prefix "VmsUnit"
    /// <summary>
    /// A sub-record in the VMS Unit table defining the characteristics of a single variable message sign that is controlled by a specific VMS unit. Locations are on or adjacent to the road network but may be updated over time if relating to a mobile VMS unit.
    /// <see href="http://vocab.datex.org/terms#VmsRecord"></see></summary>
    let VmsRecord = _prefix "VmsRecord"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#backgroundImageUrl"></see>
    /// </summary>
    let backgroundImageUrl = _prefix "backgroundImageUrl"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#dynamicallyConfigurableDisplayAreas"></see>
    /// </summary>
    let dynamicallyConfigurableDisplayAreas =
        _prefix "dynamicallyConfigurableDisplayAreas"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsDescription"></see>
    /// </summary>
    let vmsDescription = _prefix "vmsDescription"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsDisplayHeight"></see>
    /// </summary>
    let vmsDisplayHeight = _prefix "vmsDisplayHeight"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsDisplayWidth"></see>
    /// </summary>
    let vmsDisplayWidth = _prefix "vmsDisplayWidth"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsHeightAboveRoadway"></see>
    /// </summary>
    let vmsHeightAboveRoadway = _prefix "vmsHeightAboveRoadway"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsLocation"></see>
    /// </summary>
    let vmsLocation = _prefix "vmsLocation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsManagedLogicalLocation"></see>
    /// </summary>
    let vmsManagedLogicalLocation = _prefix "vmsManagedLogicalLocation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsOwner"></see>
    /// </summary>
    let vmsOwner = _prefix "vmsOwner"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsPhysicalMounting"></see>
    /// </summary>
    let vmsPhysicalMounting = _prefix "vmsPhysicalMounting"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_VmsRecordPictogramDisplayAreaIndexVmsPictogramDisplayCharacteristics"></see>
    /// </summary>
    let _VmsRecordPictogramDisplayAreaIndexVmsPictogramDisplayCharacteristics =
        _prefix "_VmsRecordPictogramDisplayAreaIndexVmsPictogramDisplayCharacteristics"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsRecordExtension"></see>
    /// </summary>
    let vmsRecordExtension = _prefix "vmsRecordExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsType"></see>
    /// </summary>
    let vmsType = _prefix "vmsType"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsTypeCode"></see>
    /// </summary>
    let vmsTypeCode = _prefix "vmsTypeCode"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsSettingExtension"></see>
    /// </summary>
    let vmsSettingExtension = _prefix "vmsSettingExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#supplementaryMessageDescription"></see>
    /// </summary>
    let supplementaryMessageDescription = _prefix "supplementaryMessageDescription"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsSupplementaryPanelExtension"></see>
    /// </summary>
    let vmsSupplementaryPanelExtension = _prefix "vmsSupplementaryPanelExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsSupplementaryPictogram"></see>
    /// </summary>
    let vmsSupplementaryPictogram = _prefix "vmsSupplementaryPictogram"
    /// <summary>
    /// An additional pictogram that is displayed in the panel which is supplemental to the associated pictogram display.
    /// <see href="http://vocab.datex.org/terms#VmsSupplementaryPictogram"></see></summary>
    let VmsSupplementaryPictogram = _prefix "VmsSupplementaryPictogram"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsSupplementaryText"></see>
    /// </summary>
    let vmsSupplementaryText = _prefix "vmsSupplementaryText"
    /// <summary>
    /// A single line of text on a text display area or supplementary panel.
    /// <see href="http://vocab.datex.org/terms#VmsTextLine"></see></summary>
    let VmsTextLine = _prefix "VmsTextLine"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#relativePositionToPictogramArea"></see>
    /// </summary>
    let relativePositionToPictogramArea = _prefix "relativePositionToPictogramArea"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#supplementaryPanelDisplayHeight"></see>
    /// </summary>
    let supplementaryPanelDisplayHeight = _prefix "supplementaryPanelDisplayHeight"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#supplementaryPanelDisplayWidth"></see>
    /// </summary>
    let supplementaryPanelDisplayWidth = _prefix "supplementaryPanelDisplayWidth"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#supplementaryPanelPixelsAcross"></see>
    /// </summary>
    let supplementaryPanelPixelsAcross = _prefix "supplementaryPanelPixelsAcross"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#supplementaryPanelPixelsDown"></see>
    /// </summary>
    let supplementaryPanelPixelsDown = _prefix "supplementaryPanelPixelsDown"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#supplementaryPanelPositionX"></see>
    /// </summary>
    let supplementaryPanelPositionX = _prefix "supplementaryPanelPositionX"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#supplementaryPanelPositionY"></see>
    /// </summary>
    let supplementaryPanelPositionY = _prefix "supplementaryPanelPositionY"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#supplementaryPictogramCodeListIdentifier"></see>
    /// </summary>
    let supplementaryPictogramCodeListIdentifier =
        _prefix "supplementaryPictogramCodeListIdentifier"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsSupplementaryPanelCharacteristicsExtension"></see>
    /// </summary>
    let vmsSupplementaryPanelCharacteristicsExtension =
        _prefix "vmsSupplementaryPanelCharacteristicsExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#additionalSupplementaryPictogramDescription"></see>
    /// </summary>
    let additionalSupplementaryPictogramDescription =
        _prefix "additionalSupplementaryPictogramDescription"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#supplementaryPictogramCode"></see>
    /// </summary>
    let supplementaryPictogramCode = _prefix "supplementaryPictogramCode"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#supplementaryPictogramDescription"></see>
    /// </summary>
    let supplementaryPictogramDescription = _prefix "supplementaryPictogramDescription"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#supplementaryPictogramUrl"></see>
    /// </summary>
    let supplementaryPictogramUrl = _prefix "supplementaryPictogramUrl"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsSupplementaryPictogramExtension"></see>
    /// </summary>
    let vmsSupplementaryPictogramExtension =
        _prefix "vmsSupplementaryPictogramExtension"

    /// <summary>
    /// A publication containing one or more VMS Unit Tables each comprising a set of records which hold details of VMS units.
    /// <see href="http://vocab.datex.org/terms#VmsTablePublication"></see></summary>
    let VmsTablePublication = _prefix "VmsTablePublication"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsTablePublicationExtension"></see>
    /// </summary>
    let vmsTablePublicationExtension = _prefix "vmsTablePublicationExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsUnitTable"></see>
    /// </summary>
    let vmsUnitTable = _prefix "vmsUnitTable"
    /// <summary>
    /// A versioned VMS Unit Table comprising a number of data records, each record defining the characteristics of a specific deployed variable message sign unit.
    /// <see href="http://vocab.datex.org/terms#VmsUnitTable"></see></summary>
    let VmsUnitTable = _prefix "VmsUnitTable"
    /// <summary>
    /// A page of text (comprising one or more ordered lines) that are displayed simultaneously on the VMS. Where more than one page is defined these are sequentially displayed according to their "pageNumber".
    /// <see href="http://vocab.datex.org/terms#VmsText"></see></summary>
    let VmsText = _prefix "VmsText"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsLegendCode"></see>
    /// </summary>
    let vmsLegendCode = _prefix "vmsLegendCode"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsTextExtension"></see>
    /// </summary>
    let vmsTextExtension = _prefix "vmsTextExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsTextImageUrl"></see>
    /// </summary>
    let vmsTextImageUrl = _prefix "vmsTextImageUrl"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsTextLine"></see>
    /// </summary>
    let vmsTextLine = _prefix "vmsTextLine"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_VmsTextLineIndexVmsTextLine"></see>
    /// </summary>
    let _VmsTextLineIndexVmsTextLine = _prefix "_VmsTextLineIndexVmsTextLine"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#legendCodeListIdentifier"></see>
    /// </summary>
    let legendCodeListIdentifier = _prefix "legendCodeListIdentifier"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maxFontHeight"></see>
    /// </summary>
    let maxFontHeight = _prefix "maxFontHeight"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maxFontSpacing"></see>
    /// </summary>
    let maxFontSpacing = _prefix "maxFontSpacing"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maxFontWidth"></see>
    /// </summary>
    let maxFontWidth = _prefix "maxFontWidth"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maxNumberOfCharacters"></see>
    /// </summary>
    let maxNumberOfCharacters = _prefix "maxNumberOfCharacters"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maxNumberOfRows"></see>
    /// </summary>
    let maxNumberOfRows = _prefix "maxNumberOfRows"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maxNumberOfSequentialPages"></see>
    /// </summary>
    let maxNumberOfSequentialPages = _prefix "maxNumberOfSequentialPages"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maxTextLuminanceLevel"></see>
    /// </summary>
    let maxTextLuminanceLevel = _prefix "maxTextLuminanceLevel"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#minFontHeight"></see>
    /// </summary>
    let minFontHeight = _prefix "minFontHeight"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#minFontSpacing"></see>
    /// </summary>
    let minFontSpacing = _prefix "minFontSpacing"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#minFontWidth"></see>
    /// </summary>
    let minFontWidth = _prefix "minFontWidth"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#textDisplayHeight"></see>
    /// </summary>
    let textDisplayHeight = _prefix "textDisplayHeight"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#textDisplayWidth"></see>
    /// </summary>
    let textDisplayWidth = _prefix "textDisplayWidth"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#textLanternsPresent"></see>
    /// </summary>
    let textLanternsPresent = _prefix "textLanternsPresent"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#textPageSequencingCapable"></see>
    /// </summary>
    let textPageSequencingCapable = _prefix "textPageSequencingCapable"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#textPixelsAcross"></see>
    /// </summary>
    let textPixelsAcross = _prefix "textPixelsAcross"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#textPixelsDown"></see>
    /// </summary>
    let textPixelsDown = _prefix "textPixelsDown"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#textPositionAbsolute"></see>
    /// </summary>
    let textPositionAbsolute = _prefix "textPositionAbsolute"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#textPositionX"></see>
    /// </summary>
    let textPositionX = _prefix "textPositionX"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#textPositionY"></see>
    /// </summary>
    let textPositionY = _prefix "textPositionY"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsTextDisplayCharacteristicsExtension"></see>
    /// </summary>
    let vmsTextDisplayCharacteristicsExtension =
        _prefix "vmsTextDisplayCharacteristicsExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsTextLineColour"></see>
    /// </summary>
    let vmsTextLineColour = _prefix "vmsTextLineColour"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsTextLineExtension"></see>
    /// </summary>
    let vmsTextLineExtension = _prefix "vmsTextLineExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsTextLineFlashing"></see>
    /// </summary>
    let vmsTextLineFlashing = _prefix "vmsTextLineFlashing"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsTextLineHtml"></see>
    /// </summary>
    let vmsTextLineHtml = _prefix "vmsTextLineHtml"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsTextLineLanguage"></see>
    /// </summary>
    let vmsTextLineLanguage = _prefix "vmsTextLineLanguage"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vms"></see>
    /// </summary>
    let vms = _prefix "vms"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_VmsUnitVmsIndexVms"></see>
    /// </summary>
    let _VmsUnitVmsIndexVms = _prefix "_VmsUnitVmsIndexVms"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsUnitExtension"></see>
    /// </summary>
    let vmsUnitExtension = _prefix "vmsUnitExtension"
    /// <summary>
    /// The type of fault which is being reported for the VMS unit.
    /// <see href="http://vocab.datex.org/terms#vmsUnitFault"></see></summary>
    let vmsUnitFault = _prefix "vmsUnitFault"
    /// <summary>
    /// Details of the fault which is being reported for the specified variable message sign control unit.
    /// <see href="http://vocab.datex.org/terms#VmsUnitFault"></see></summary>
    let VmsUnitFault = _prefix "VmsUnitFault"
    /// <summary>
    /// A reference to a versioned VMS unit record in a VMS Unit table which defines the characteristics of the VMS unit.
    /// <see href="http://vocab.datex.org/terms#vmsUnitReference"></see></summary>
    let vmsUnitReference = _prefix "vmsUnitReference"
    /// <summary>
    /// A reference to a versioned VMS Unit table.
    /// <see href="http://vocab.datex.org/terms#vmsUnitTableReference"></see></summary>
    let vmsUnitTableReference = _prefix "vmsUnitTableReference"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_VmsUnitTableVersionedReference"></see>
    /// </summary>
    let _VmsUnitTableVersionedReference = _prefix "_VmsUnitTableVersionedReference"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsUnitFaultExtension"></see>
    /// </summary>
    let vmsUnitFaultExtension = _prefix "vmsUnitFaultExtension"
    /// <summary>
    /// A versioned single VMS unit entry/record in the VMS Unit table that defines the characteristics of the VMS unit.
    /// <see href="http://vocab.datex.org/terms#VmsUnitRecord"></see></summary>
    let VmsUnitRecord = _prefix "VmsUnitRecord"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#numberOfVms"></see>
    /// </summary>
    let numberOfVms = _prefix "numberOfVms"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsRecord"></see>
    /// </summary>
    let vmsRecord = _prefix "vmsRecord"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_VmsUnitRecordVmsIndexVmsRecord"></see>
    /// </summary>
    let _VmsUnitRecordVmsIndexVmsRecord = _prefix "_VmsUnitRecordVmsIndexVmsRecord"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsUnitElectronicAddress"></see>
    /// </summary>
    let vmsUnitElectronicAddress = _prefix "vmsUnitElectronicAddress"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsUnitIPAddress"></see>
    /// </summary>
    let vmsUnitIPAddress = _prefix "vmsUnitIPAddress"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsUnitIdentifier"></see>
    /// </summary>
    let vmsUnitIdentifier = _prefix "vmsUnitIdentifier"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsUnitRecordExtension"></see>
    /// </summary>
    let vmsUnitRecordExtension = _prefix "vmsUnitRecordExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsUnitRecord"></see>
    /// </summary>
    let vmsUnitRecord = _prefix "vmsUnitRecord"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsUnitTableExtension"></see>
    /// </summary>
    let vmsUnitTableExtension = _prefix "vmsUnitTableExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsUnitTableIdentification"></see>
    /// </summary>
    let vmsUnitTableIdentification = _prefix "vmsUnitTableIdentification"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#weatherDataExtension"></see>
    /// </summary>
    let weatherDataExtension = _prefix "weatherDataExtension"
    /// <summary>
    /// Road surface conditions that are related to the weather which may affect the driving conditions, such as ice, snow or water.
    /// <see href="http://vocab.datex.org/terms#WeatherRelatedRoadConditions"></see></summary>
    let WeatherRelatedRoadConditions = _prefix "WeatherRelatedRoadConditions"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#weatherRelatedRoadConditionsExtension"></see>
    /// </summary>
    let weatherRelatedRoadConditionsExtension =
        _prefix "weatherRelatedRoadConditionsExtension"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleWidth"></see>
    /// </summary>
    let vehicleWidth = _prefix "vehicleWidth"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#widthCharacteristicExtension"></see>
    /// </summary>
    let widthCharacteristicExtension = _prefix "widthCharacteristicExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maximumWindSpeed"></see>
    /// </summary>
    let maximumWindSpeed = _prefix "maximumWindSpeed"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#windDirectionBearing"></see>
    /// </summary>
    let windDirectionBearing = _prefix "windDirectionBearing"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#windDirectionCompass"></see>
    /// </summary>
    let windDirectionCompass = _prefix "windDirectionCompass"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#windExtension"></see>
    /// </summary>
    let windExtension = _prefix "windExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#windMeasurementHeight"></see>
    /// </summary>
    let windMeasurementHeight = _prefix "windMeasurementHeight"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#windSpeed"></see>
    /// </summary>
    let windSpeed = _prefix "windSpeed"
    /// <summary>
    /// Measurements of wind conditions.
    /// <see href="http://vocab.datex.org/terms#WindInformation"></see></summary>
    let WindInformation = _prefix "WindInformation"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#windInformationExtension"></see>
    /// </summary>
    let windInformationExtension = _prefix "windInformationExtension"
    /// <summary>
    /// Winter driving management action that is instigated by the network/road operator.
    /// <see href="http://vocab.datex.org/terms#WinterDrivingManagement"></see></summary>
    let WinterDrivingManagement = _prefix "WinterDrivingManagement"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#winterDrivingManagementExtension"></see>
    /// </summary>
    let winterDrivingManagementExtension = _prefix "winterDrivingManagementExtension"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#areaExtended"></see>
    /// </summary>
    let areaExtended = _prefix "areaExtended"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrExtendedArea"></see>
    /// </summary>
    let openlrExtendedArea = _prefix "openlrExtendedArea"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#any"></see>
    /// </summary>
    let any = _prefix "any"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#targetClass"></see>
    /// </summary>
    let targetClass = _prefix "targetClass"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingStatusPublication"></see>
    /// </summary>
    let parkingStatusPublication = _prefix "parkingStatusPublication"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingTablePublication"></see>
    /// </summary>
    let parkingTablePublication = _prefix "parkingTablePublication"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingVehiclesPublication"></see>
    /// </summary>
    let parkingVehiclesPublication = _prefix "parkingVehiclesPublication"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#groupIndex"></see>
    /// </summary>
    let groupIndex = _prefix "groupIndex"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSpaceBasics"></see>
    /// </summary>
    let parkingSpaceBasics = _prefix "parkingSpaceBasics"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSpaceIndex"></see>
    /// </summary>
    let parkingSpaceIndex = _prefix "parkingSpaceIndex"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#index"></see>
    /// </summary>
    let index = _prefix "index"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#referent"></see>
    /// </summary>
    let referent = _prefix "referent"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrExtendedLinear"></see>
    /// </summary>
    let openlrExtendedLinear = _prefix "openlrExtendedLinear"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#equipmentOrServiceFacilityIndex"></see>
    /// </summary>
    let equipmentOrServiceFacilityIndex = _prefix "equipmentOrServiceFacilityIndex"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#scenarioIndex"></see>
    /// </summary>
    let scenarioIndex = _prefix "scenarioIndex"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#periodExtended"></see>
    /// </summary>
    let periodExtended = _prefix "periodExtended"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrExtendedPoint"></see>
    /// </summary>
    let openlrExtendedPoint = _prefix "openlrExtendedPoint"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pointExtended"></see>
    /// </summary>
    let pointExtended = _prefix "pointExtended"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#situationRecordExtendedApproved"></see>
    /// </summary>
    let situationRecordExtendedApproved = _prefix "situationRecordExtendedApproved"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pageNumber"></see>
    /// </summary>
    let pageNumber = _prefix "pageNumber"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsText"></see>
    /// </summary>
    let vmsText = _prefix "vmsText"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleCharacteristicsExtended"></see>
    /// </summary>
    let vehicleCharacteristicsExtended = _prefix "vehicleCharacteristicsExtended"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramDisplayAreaIndex"></see>
    /// </summary>
    let pictogramDisplayAreaIndex = _prefix "pictogramDisplayAreaIndex"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#messageIndex"></see>
    /// </summary>
    let messageIndex = _prefix "messageIndex"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramSequencingIndex"></see>
    /// </summary>
    let pictogramSequencingIndex = _prefix "pictogramSequencingIndex"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#lineIndex"></see>
    /// </summary>
    let lineIndex = _prefix "lineIndex"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsIndex"></see>
    /// </summary>
    let vmsIndex = _prefix "vmsIndex"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#d2LogicalModel"></see>
    /// </summary>
    let d2LogicalModel = _prefix "d2LogicalModel"
    /// <summary>
    /// An example mapping of Datex2 to an OWL vocabulary
    /// <see href="http://vocab.datex.org/terms#ontology"></see></summary>
    let ontology = _prefix "ontology"
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#value"></see>
    /// </summary>
    let value = _prefix "value"
