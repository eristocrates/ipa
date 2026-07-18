namespace http.vocab.datex.org.terms.hash

open DoxAletheia.Rdf_Vocabulary

module datex =
    let _namespace_name = "http://vocab.datex.org/terms#"

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AbandonedVehicle"></see>
    /// </summary>
    let AbandonedVehicle =
        Namespaced_IRI.parse _namespace_name "AbandonedVehicle" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AbnormalLoad"></see>
    /// </summary>
    let AbnormalLoad =
        Namespaced_IRI.parse _namespace_name "AbnormalLoad" |> NamespacedName

    /// <summary>
    /// A traffic condition which is not normal.
    /// <see href="http://vocab.datex.org/terms#AbnormalTraffic"></see></summary>
    let AbnormalTraffic =
        Namespaced_IRI.parse _namespace_name "AbnormalTraffic" |> NamespacedName

    /// <summary>
    /// Accidents are events where one or more vehicles are involved in collisions or in leaving the roadway. These include collisions between vehicles or with other road users or obstacles.
    /// <see href="http://vocab.datex.org/terms#Accident"></see></summary>
    let Accident = Namespaced_IRI.parse _namespace_name "Accident" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AccidentInvestigationWork"></see>
    /// </summary>
    let AccidentInvestigationWork =
        Namespaced_IRI.parse _namespace_name "AccidentInvestigationWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AccidentInvolvingBicycles"></see>
    /// </summary>
    let AccidentInvolvingBicycles =
        Namespaced_IRI.parse _namespace_name "AccidentInvolvingBicycles" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AccidentInvolvingBuses"></see>
    /// </summary>
    let AccidentInvolvingBuses =
        Namespaced_IRI.parse _namespace_name "AccidentInvolvingBuses" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AccidentInvolvingHazardousMaterials"></see>
    /// </summary>
    let AccidentInvolvingHazardousMaterials =
        Namespaced_IRI.parse _namespace_name "AccidentInvolvingHazardousMaterials" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AccidentInvolvingHeavyLorries"></see>
    /// </summary>
    let AccidentInvolvingHeavyLorries =
        Namespaced_IRI.parse _namespace_name "AccidentInvolvingHeavyLorries" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AccidentInvolvingMassTransitVehicle"></see>
    /// </summary>
    let AccidentInvolvingMassTransitVehicle =
        Namespaced_IRI.parse _namespace_name "AccidentInvolvingMassTransitVehicle" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AccidentInvolvingMopeds"></see>
    /// </summary>
    let AccidentInvolvingMopeds =
        Namespaced_IRI.parse _namespace_name "AccidentInvolvingMopeds" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AccidentInvolvingMotorcycles"></see>
    /// </summary>
    let AccidentInvolvingMotorcycles =
        Namespaced_IRI.parse _namespace_name "AccidentInvolvingMotorcycles" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AccidentInvolvingRadioactiveMaterial"></see>
    /// </summary>
    let AccidentInvolvingRadioactiveMaterial =
        Namespaced_IRI.parse _namespace_name "AccidentInvolvingRadioactiveMaterial" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AccidentInvolvingTrain"></see>
    /// </summary>
    let AccidentInvolvingTrain =
        Namespaced_IRI.parse _namespace_name "AccidentInvolvingTrain" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#ActiveSpeedControlInOperation"></see>
    /// </summary>
    let ActiveSpeedControlInOperation =
        Namespaced_IRI.parse _namespace_name "ActiveSpeedControlInOperation" |> NamespacedName

    /// <summary>
    /// Deliberate human action external to the traffic stream or roadway which could disrupt traffic.
    /// <see href="http://vocab.datex.org/terms#Activity"></see></summary>
    let Activity = Namespaced_IRI.parse _namespace_name "Activity" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AdverseInfrastructureConditions"></see>
    /// </summary>
    let AdverseInfrastructureConditions =
        Namespaced_IRI.parse _namespace_name "AdverseInfrastructureConditions" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AgriculturalShow"></see>
    /// </summary>
    let AgriculturalShow =
        Namespaced_IRI.parse _namespace_name "AgriculturalShow" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AirAmbulance"></see>
    /// </summary>
    let AirAmbulance =
        Namespaced_IRI.parse _namespace_name "AirAmbulance" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AirRaid"></see>
    /// </summary>
    let AirRaid = Namespaced_IRI.parse _namespace_name "AirRaid" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AirShow"></see>
    /// </summary>
    let AirShow = Namespaced_IRI.parse _namespace_name "AirShow" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AltercationOfVehicleOccupants"></see>
    /// </summary>
    let AltercationOfVehicleOccupants =
        Namespaced_IRI.parse _namespace_name "AltercationOfVehicleOccupants" |> NamespacedName

    /// <summary>
    /// An obstruction on the road resulting from the presence of animals.
    /// <see href="http://vocab.datex.org/terms#AnimalPresenceObstruction"></see></summary>
    let AnimalPresenceObstruction =
        Namespaced_IRI.parse _namespace_name "AnimalPresenceObstruction" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AnimalsOnTheInfrastructure"></see>
    /// </summary>
    let AnimalsOnTheInfrastructure =
        Namespaced_IRI.parse _namespace_name "AnimalsOnTheInfrastructure" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AnprCameraFailure"></see>
    /// </summary>
    let AnprCameraFailure =
        Namespaced_IRI.parse _namespace_name "AnprCameraFailure" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AnprCamerasFault"></see>
    /// </summary>
    let AnprCamerasFault =
        Namespaced_IRI.parse _namespace_name "AnprCamerasFault" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Assault"></see>
    /// </summary>
    let Assault = Namespaced_IRI.parse _namespace_name "Assault" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AssetDestruction"></see>
    /// </summary>
    let AssetDestruction =
        Namespaced_IRI.parse _namespace_name "AssetDestruction" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AthleticsMeeting"></see>
    /// </summary>
    let AthleticsMeeting =
        Namespaced_IRI.parse _namespace_name "AthleticsMeeting" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Attack"></see>
    /// </summary>
    let Attack = Namespaced_IRI.parse _namespace_name "Attack" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AttackOnVehicle"></see>
    /// </summary>
    let AttackOnVehicle =
        Namespaced_IRI.parse _namespace_name "AttackOnVehicle" |> NamespacedName

    /// <summary>
    /// Authority initiated operation or activity that could disrupt traffic.
    /// <see href="http://vocab.datex.org/terms#AuthorityOperation"></see></summary>
    let AuthorityOperation =
        Namespaced_IRI.parse _namespace_name "AuthorityOperation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AutomatedTollSystemFailure"></see>
    /// </summary>
    let AutomatedTollSystemFailure =
        Namespaced_IRI.parse _namespace_name "AutomatedTollSystemFailure" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#AutomatedTollSystemFault"></see>
    /// </summary>
    let AutomatedTollSystemFault =
        Namespaced_IRI.parse _namespace_name "AutomatedTollSystemFault" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Avalanches"></see>
    /// </summary>
    let Avalanches = Namespaced_IRI.parse _namespace_name "Avalanches" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BadWeather"></see>
    /// </summary>
    let BadWeather = Namespaced_IRI.parse _namespace_name "BadWeather" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BallGame"></see>
    /// </summary>
    let BallGame = Namespaced_IRI.parse _namespace_name "BallGame" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BaseballGame"></see>
    /// </summary>
    let BaseballGame =
        Namespaced_IRI.parse _namespace_name "BaseballGame" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BasketballGame"></see>
    /// </summary>
    let BasketballGame =
        Namespaced_IRI.parse _namespace_name "BasketballGame" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BicycleRace"></see>
    /// </summary>
    let BicycleRace =
        Namespaced_IRI.parse _namespace_name "BicycleRace" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BlackIce"></see>
    /// </summary>
    let BlackIce = Namespaced_IRI.parse _namespace_name "BlackIce" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BlastingWork"></see>
    /// </summary>
    let BlastingWork =
        Namespaced_IRI.parse _namespace_name "BlastingWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Blizzard"></see>
    /// </summary>
    let Blizzard = Namespaced_IRI.parse _namespace_name "Blizzard" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BlockadeOrBarrier"></see>
    /// </summary>
    let BlockadeOrBarrier =
        Namespaced_IRI.parse _namespace_name "BlockadeOrBarrier" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BlowingDust"></see>
    /// </summary>
    let BlowingDust =
        Namespaced_IRI.parse _namespace_name "BlowingDust" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BlowingSnow"></see>
    /// </summary>
    let BlowingSnow =
        Namespaced_IRI.parse _namespace_name "BlowingSnow" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BoatRace"></see>
    /// </summary>
    let BoatRace = Namespaced_IRI.parse _namespace_name "BoatRace" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BoatShow"></see>
    /// </summary>
    let BoatShow = Namespaced_IRI.parse _namespace_name "BoatShow" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BombAlert"></see>
    /// </summary>
    let BombAlert = Namespaced_IRI.parse _namespace_name "BombAlert" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BombSquadInAction"></see>
    /// </summary>
    let BombSquadInAction =
        Namespaced_IRI.parse _namespace_name "BombSquadInAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BoxingTournament"></see>
    /// </summary>
    let BoxingTournament =
        Namespaced_IRI.parse _namespace_name "BoxingTournament" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BridgeSwingInOperation"></see>
    /// </summary>
    let BridgeSwingInOperation =
        Namespaced_IRI.parse _namespace_name "BridgeSwingInOperation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BrokenDownBus"></see>
    /// </summary>
    let BrokenDownBus =
        Namespaced_IRI.parse _namespace_name "BrokenDownBus" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BrokenDownHeavyLorry"></see>
    /// </summary>
    let BrokenDownHeavyLorry =
        Namespaced_IRI.parse _namespace_name "BrokenDownHeavyLorry" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BrokenDownVehicle"></see>
    /// </summary>
    let BrokenDownVehicle =
        Namespaced_IRI.parse _namespace_name "BrokenDownVehicle" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BullFight"></see>
    /// </summary>
    let BullFight = Namespaced_IRI.parse _namespace_name "BullFight" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BurstPipe"></see>
    /// </summary>
    let BurstPipe = Namespaced_IRI.parse _namespace_name "BurstPipe" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#BurstWaterMain"></see>
    /// </summary>
    let BurstWaterMain =
        Namespaced_IRI.parse _namespace_name "BurstWaterMain" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#CarPoolLaneInOperation"></see>
    /// </summary>
    let CarPoolLaneInOperation =
        Namespaced_IRI.parse _namespace_name "CarPoolLaneInOperation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#CarriagewayClosures"></see>
    /// </summary>
    let CarriagewayClosures =
        Namespaced_IRI.parse _namespace_name "CarriagewayClosures" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#CctvCamerasFailure"></see>
    /// </summary>
    let CctvCamerasFailure =
        Namespaced_IRI.parse _namespace_name "CctvCamerasFailure" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#CctvCamerasFault"></see>
    /// </summary>
    let CctvCamerasFault =
        Namespaced_IRI.parse _namespace_name "CctvCamerasFault" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#CeremonialEvent"></see>
    /// </summary>
    let CeremonialEvent =
        Namespaced_IRI.parse _namespace_name "CeremonialEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#ChemicalSpillageAccident"></see>
    /// </summary>
    let ChemicalSpillageAccident =
        Namespaced_IRI.parse _namespace_name "ChemicalSpillageAccident" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#CivilEmergency"></see>
    /// </summary>
    let CivilEmergency =
        Namespaced_IRI.parse _namespace_name "CivilEmergency" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#ClearanceWork"></see>
    /// </summary>
    let ClearanceWork =
        Namespaced_IRI.parse _namespace_name "ClearanceWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#ClosedPermanentlyForTheWinter"></see>
    /// </summary>
    let ClosedPermanentlyForTheWinter =
        Namespaced_IRI.parse _namespace_name "ClosedPermanentlyForTheWinter" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#CollapsedSewer"></see>
    /// </summary>
    let CollapsedSewer =
        Namespaced_IRI.parse _namespace_name "CollapsedSewer" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Collision"></see>
    /// </summary>
    let Collision = Namespaced_IRI.parse _namespace_name "Collision" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#CollisionWithAnimal"></see>
    /// </summary>
    let CollisionWithAnimal =
        Namespaced_IRI.parse _namespace_name "CollisionWithAnimal" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#CollisionWithObstruction"></see>
    /// </summary>
    let CollisionWithObstruction =
        Namespaced_IRI.parse _namespace_name "CollisionWithObstruction" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#CollisionWithPerson"></see>
    /// </summary>
    let CollisionWithPerson =
        Namespaced_IRI.parse _namespace_name "CollisionWithPerson" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#CommercialEvent"></see>
    /// </summary>
    let CommercialEvent =
        Namespaced_IRI.parse _namespace_name "CommercialEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Concert"></see>
    /// </summary>
    let Concert = Namespaced_IRI.parse _namespace_name "Concert" |> NamespacedName
    /// <summary>
    /// Any conditions which have the potential to degrade normal driving conditions.
    /// <see href="http://vocab.datex.org/terms#Conditions"></see></summary>
    let Conditions = Namespaced_IRI.parse _namespace_name "Conditions" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#ConstructionWork"></see>
    /// </summary>
    let ConstructionWork =
        Namespaced_IRI.parse _namespace_name "ConstructionWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Contraflow"></see>
    /// </summary>
    let Contraflow = Namespaced_IRI.parse _namespace_name "Contraflow" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#ControlledAvalanche"></see>
    /// </summary>
    let ControlledAvalanche =
        Namespaced_IRI.parse _namespace_name "ControlledAvalanche" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Convoy"></see>
    /// </summary>
    let Convoy = Namespaced_IRI.parse _namespace_name "Convoy" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#ConvoyService"></see>
    /// </summary>
    let ConvoyService =
        Namespaced_IRI.parse _namespace_name "ConvoyService" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#CricketMatch"></see>
    /// </summary>
    let CricketMatch =
        Namespaced_IRI.parse _namespace_name "CricketMatch" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Crosswinds"></see>
    /// </summary>
    let Crosswinds = Namespaced_IRI.parse _namespace_name "Crosswinds" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Crowd"></see>
    /// </summary>
    let Crowd = Namespaced_IRI.parse _namespace_name "Crowd" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#CulturalEvent"></see>
    /// </summary>
    let CulturalEvent =
        Namespaced_IRI.parse _namespace_name "CulturalEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#CustomsOperation"></see>
    /// </summary>
    let CustomsOperation =
        Namespaced_IRI.parse _namespace_name "CustomsOperation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#DamagedBridge"></see>
    /// </summary>
    let DamagedBridge =
        Namespaced_IRI.parse _namespace_name "DamagedBridge" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#DamagedCrashBarrier"></see>
    /// </summary>
    let DamagedCrashBarrier =
        Namespaced_IRI.parse _namespace_name "DamagedCrashBarrier" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#DamagedFlyover"></see>
    /// </summary>
    let DamagedFlyover =
        Namespaced_IRI.parse _namespace_name "DamagedFlyover" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#DamagedGallery"></see>
    /// </summary>
    let DamagedGallery =
        Namespaced_IRI.parse _namespace_name "DamagedGallery" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#DamagedGantry"></see>
    /// </summary>
    let DamagedGantry =
        Namespaced_IRI.parse _namespace_name "DamagedGantry" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#DamagedRoadSurface"></see>
    /// </summary>
    let DamagedRoadSurface =
        Namespaced_IRI.parse _namespace_name "DamagedRoadSurface" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#DamagedTunnel"></see>
    /// </summary>
    let DamagedTunnel =
        Namespaced_IRI.parse _namespace_name "DamagedTunnel" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#DamagedVehicle"></see>
    /// </summary>
    let DamagedVehicle =
        Namespaced_IRI.parse _namespace_name "DamagedVehicle" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#DamagedViaduct"></see>
    /// </summary>
    let DamagedViaduct =
        Namespaced_IRI.parse _namespace_name "DamagedViaduct" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#DamagingHail"></see>
    /// </summary>
    let DamagingHail =
        Namespaced_IRI.parse _namespace_name "DamagingHail" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#DangerousSlowMovingVehicle"></see>
    /// </summary>
    let DangerousSlowMovingVehicle =
        Namespaced_IRI.parse _namespace_name "DangerousSlowMovingVehicle" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#DeepSnow"></see>
    /// </summary>
    let DeepSnow = Namespaced_IRI.parse _namespace_name "DeepSnow" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#DemolitionWork"></see>
    /// </summary>
    let DemolitionWork =
        Namespaced_IRI.parse _namespace_name "DemolitionWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Demonstration"></see>
    /// </summary>
    let Demonstration =
        Namespaced_IRI.parse _namespace_name "Demonstration" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#DenseFog"></see>
    /// </summary>
    let DenseFog = Namespaced_IRI.parse _namespace_name "DenseFog" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#DieselOnInfrastructure"></see>
    /// </summary>
    let DieselOnInfrastructure =
        Namespaced_IRI.parse _namespace_name "DieselOnInfrastructure" |> NamespacedName

    /// <summary>
    /// Deliberate human action of either a public disorder nature or of a situation alert type which could disrupt traffic.
    /// <see href="http://vocab.datex.org/terms#DisturbanceActivity"></see></summary>
    let DisturbanceActivity =
        Namespaced_IRI.parse _namespace_name "DisturbanceActivity" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#DrivingCondition"></see>
    /// </summary>
    let DrivingCondition =
        Namespaced_IRI.parse _namespace_name "DrivingCondition" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Dry"></see>
    /// </summary>
    let Dry = Namespaced_IRI.parse _namespace_name "Dry" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#EarthquakeDamage"></see>
    /// </summary>
    let EarthquakeDamage =
        Namespaced_IRI.parse _namespace_name "EarthquakeDamage" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Eclipse"></see>
    /// </summary>
    let Eclipse = Namespaced_IRI.parse _namespace_name "Eclipse" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#EmergencyRoadsideTelephoneFailure"></see>
    /// </summary>
    let EmergencyRoadsideTelephoneFailure =
        Namespaced_IRI.parse _namespace_name "EmergencyRoadsideTelephoneFailure" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#EmergencyRoadsideTelephoneFault"></see>
    /// </summary>
    let EmergencyRoadsideTelephoneFault =
        Namespaced_IRI.parse _namespace_name "EmergencyRoadsideTelephoneFault" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#EmergencyServices"></see>
    /// </summary>
    let EmergencyServices =
        Namespaced_IRI.parse _namespace_name "EmergencyServices" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#EmergencyVehicle"></see>
    /// </summary>
    let EmergencyVehicle =
        Namespaced_IRI.parse _namespace_name "EmergencyVehicle" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#EnvironmentalConditions"></see>
    /// </summary>
    let EnvironmentalConditions =
        Namespaced_IRI.parse _namespace_name "EnvironmentalConditions" |> NamespacedName

    /// <summary>
    /// An obstruction on the road resulting from an environmental cause.
    /// <see href="http://vocab.datex.org/terms#EnvironmentalObstruction"></see></summary>
    let EnvironmentalObstruction =
        Namespaced_IRI.parse _namespace_name "EnvironmentalObstruction" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Evacuation"></see>
    /// </summary>
    let Evacuation = Namespaced_IRI.parse _namespace_name "Evacuation" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Exhibition"></see>
    /// </summary>
    let Exhibition = Namespaced_IRI.parse _namespace_name "Exhibition" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#ExtremeCold"></see>
    /// </summary>
    let ExtremeCold =
        Namespaced_IRI.parse _namespace_name "ExtremeCold" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#ExtremeHeat"></see>
    /// </summary>
    let ExtremeHeat =
        Namespaced_IRI.parse _namespace_name "ExtremeHeat" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Fair"></see>
    /// </summary>
    let Fair = Namespaced_IRI.parse _namespace_name "Fair" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#FallenPowerCables"></see>
    /// </summary>
    let FallenPowerCables =
        Namespaced_IRI.parse _namespace_name "FallenPowerCables" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#FallenTrees"></see>
    /// </summary>
    let FallenTrees =
        Namespaced_IRI.parse _namespace_name "FallenTrees" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#FallingIce"></see>
    /// </summary>
    let FallingIce = Namespaced_IRI.parse _namespace_name "FallingIce" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#FallingLightIceOrSnow"></see>
    /// </summary>
    let FallingLightIceOrSnow =
        Namespaced_IRI.parse _namespace_name "FallingLightIceOrSnow" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Festival"></see>
    /// </summary>
    let Festival = Namespaced_IRI.parse _namespace_name "Festival" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#FilmTVMaking"></see>
    /// </summary>
    let FilmTVMaking =
        Namespaced_IRI.parse _namespace_name "FilmTVMaking" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#FilterBlockade"></see>
    /// </summary>
    let FilterBlockade =
        Namespaced_IRI.parse _namespace_name "FilterBlockade" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#FirstAid"></see>
    /// </summary>
    let FirstAid = Namespaced_IRI.parse _namespace_name "FirstAid" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#FlashFloods"></see>
    /// </summary>
    let FlashFloods =
        Namespaced_IRI.parse _namespace_name "FlashFloods" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Flooding"></see>
    /// </summary>
    let Flooding = Namespaced_IRI.parse _namespace_name "Flooding" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Fog"></see>
    /// </summary>
    let Fog = Namespaced_IRI.parse _namespace_name "Fog" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#FoodDelivery"></see>
    /// </summary>
    let FoodDelivery =
        Namespaced_IRI.parse _namespace_name "FoodDelivery" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#FootballMatch"></see>
    /// </summary>
    let FootballMatch =
        Namespaced_IRI.parse _namespace_name "FootballMatch" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#ForestFire"></see>
    /// </summary>
    let ForestFire = Namespaced_IRI.parse _namespace_name "ForestFire" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#FreezingFog"></see>
    /// </summary>
    let FreezingFog =
        Namespaced_IRI.parse _namespace_name "FreezingFog" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#FreezingOfWetInfrastructureSurface"></see>
    /// </summary>
    let FreezingOfWetInfrastructureSurface =
        Namespaced_IRI.parse _namespace_name "FreezingOfWetInfrastructureSurface" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#FreezingPavements"></see>
    /// </summary>
    let FreezingPavements =
        Namespaced_IRI.parse _namespace_name "FreezingPavements" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#FreezingRain"></see>
    /// </summary>
    let FreezingRain =
        Namespaced_IRI.parse _namespace_name "FreezingRain" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#FreshSnow"></see>
    /// </summary>
    let FreshSnow = Namespaced_IRI.parse _namespace_name "FreshSnow" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Frost"></see>
    /// </summary>
    let Frost = Namespaced_IRI.parse _namespace_name "Frost" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#FuelSpillageAccident"></see>
    /// </summary>
    let FuelSpillageAccident =
        Namespaced_IRI.parse _namespace_name "FuelSpillageAccident" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Funfair"></see>
    /// </summary>
    let Funfair = Namespaced_IRI.parse _namespace_name "Funfair" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Gales"></see>
    /// </summary>
    let Gales = Namespaced_IRI.parse _namespace_name "Gales" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#GalleryLightsFailure"></see>
    /// </summary>
    let GalleryLightsFailure =
        Namespaced_IRI.parse _namespace_name "GalleryLightsFailure" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#GalleryLightsFault"></see>
    /// </summary>
    let GalleryLightsFault =
        Namespaced_IRI.parse _namespace_name "GalleryLightsFault" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#GardeningOrFlowerShow"></see>
    /// </summary>
    let GardeningOrFlowerShow =
        Namespaced_IRI.parse _namespace_name "GardeningOrFlowerShow" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#GasLeak"></see>
    /// </summary>
    let GasLeak = Namespaced_IRI.parse _namespace_name "GasLeak" |> NamespacedName

    /// <summary>
    /// Network management action that is instigated either manually or automatically by the network/road operator.  Compliance with any resulting control may be advisory or mandatory.
    /// <see href="http://vocab.datex.org/terms#GeneralNetworkManagement"></see></summary>
    let GeneralNetworkManagement =
        Namespaced_IRI.parse _namespace_name "GeneralNetworkManagement" |> NamespacedName

    /// <summary>
    /// Any stationary or moving obstacle of a physical nature, other than of an animal, vehicle, environmental, or damaged equipment nature.
    /// <see href="http://vocab.datex.org/terms#GeneralObstruction"></see></summary>
    let GeneralObstruction =
        Namespaced_IRI.parse _namespace_name "GeneralObstruction" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#GoSlowOperation"></see>
    /// </summary>
    let GoSlowOperation =
        Namespaced_IRI.parse _namespace_name "GoSlowOperation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#GolfTournament"></see>
    /// </summary>
    let GolfTournament =
        Namespaced_IRI.parse _namespace_name "GolfTournament" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#GrassCuttingWork"></see>
    /// </summary>
    let GrassCuttingWork =
        Namespaced_IRI.parse _namespace_name "GrassCuttingWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#GrassFire"></see>
    /// </summary>
    let GrassFire = Namespaced_IRI.parse _namespace_name "GrassFire" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#GunfireOnRoadway"></see>
    /// </summary>
    let GunfireOnRoadway =
        Namespaced_IRI.parse _namespace_name "GunfireOnRoadway" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#GustyWinds"></see>
    /// </summary>
    let GustyWinds = Namespaced_IRI.parse _namespace_name "GustyWinds" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Hail"></see>
    /// </summary>
    let Hail = Namespaced_IRI.parse _namespace_name "Hail" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#HardShoulderRunningInOperation"></see>
    /// </summary>
    let HardShoulderRunningInOperation =
        Namespaced_IRI.parse _namespace_name "HardShoulderRunningInOperation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Hazardous"></see>
    /// </summary>
    let Hazardous = Namespaced_IRI.parse _namespace_name "Hazardous" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#HeadOnCollision"></see>
    /// </summary>
    let HeadOnCollision =
        Namespaced_IRI.parse _namespace_name "HeadOnCollision" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#HeadOnOrSideCollision"></see>
    /// </summary>
    let HeadOnOrSideCollision =
        Namespaced_IRI.parse _namespace_name "HeadOnOrSideCollision" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#HeavyFrost"></see>
    /// </summary>
    let HeavyFrost = Namespaced_IRI.parse _namespace_name "HeavyFrost" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#HeavyRain"></see>
    /// </summary>
    let HeavyRain = Namespaced_IRI.parse _namespace_name "HeavyRain" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#HeavySnowfall"></see>
    /// </summary>
    let HeavySnowfall =
        Namespaced_IRI.parse _namespace_name "HeavySnowfall" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#HeavyTraffic"></see>
    /// </summary>
    let HeavyTraffic =
        Namespaced_IRI.parse _namespace_name "HeavyTraffic" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#HeightRestrictionInOperation"></see>
    /// </summary>
    let HeightRestrictionInOperation =
        Namespaced_IRI.parse _namespace_name "HeightRestrictionInOperation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#HelicopterRescue"></see>
    /// </summary>
    let HelicopterRescue =
        Namespaced_IRI.parse _namespace_name "HelicopterRescue" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#HerdOfAnimalsOnTheInfrastructure"></see>
    /// </summary>
    let HerdOfAnimalsOnTheInfrastructure =
        Namespaced_IRI.parse _namespace_name "HerdOfAnimalsOnTheInfrastructure" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#HighSpeedEmergencyVehicle"></see>
    /// </summary>
    let HighSpeedEmergencyVehicle =
        Namespaced_IRI.parse _namespace_name "HighSpeedEmergencyVehicle" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#HockeyGame"></see>
    /// </summary>
    let HockeyGame = Namespaced_IRI.parse _namespace_name "HockeyGame" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#HorseRaceMeeting"></see>
    /// </summary>
    let HorseRaceMeeting =
        Namespaced_IRI.parse _namespace_name "HorseRaceMeeting" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#HurricaneForceWinds"></see>
    /// </summary>
    let HurricaneForceWinds =
        Namespaced_IRI.parse _namespace_name "HurricaneForceWinds" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Ice"></see>
    /// </summary>
    let Ice = Namespaced_IRI.parse _namespace_name "Ice" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#IceBuildUp"></see>
    /// </summary>
    let IceBuildUp = Namespaced_IRI.parse _namespace_name "IceBuildUp" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#IceWithWheelBarTracks"></see>
    /// </summary>
    let IceWithWheelBarTracks =
        Namespaced_IRI.parse _namespace_name "IceWithWheelBarTracks" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#IcyPatches"></see>
    /// </summary>
    let IcyPatches = Namespaced_IRI.parse _namespace_name "IcyPatches" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#IllVehicleOccupants"></see>
    /// </summary>
    let IllVehicleOccupants =
        Namespaced_IRI.parse _namespace_name "IllVehicleOccupants" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Impossible"></see>
    /// </summary>
    let Impossible = Namespaced_IRI.parse _namespace_name "Impossible" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#InfrastructureConstruction"></see>
    /// </summary>
    let InfrastructureConstruction =
        Namespaced_IRI.parse _namespace_name "InfrastructureConstruction" |> NamespacedName

    /// <summary>
    /// An obstruction on the road resulting from the failure or damage of infrastructure on, under, above or close to the road.
    /// <see href="http://vocab.datex.org/terms#InfrastructureDamageObstruction"></see></summary>
    let InfrastructureDamageObstruction =
        Namespaced_IRI.parse _namespace_name "InfrastructureDamageObstruction" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#InfrastructureFailure"></see>
    /// </summary>
    let InfrastructureFailure =
        Namespaced_IRI.parse _namespace_name "InfrastructureFailure" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#InfrastructureFault"></see>
    /// </summary>
    let InfrastructureFault =
        Namespaced_IRI.parse _namespace_name "InfrastructureFault" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#InfrastructureImprovementOrUpgrading"></see>
    /// </summary>
    let InfrastructureImprovementOrUpgrading =
        Namespaced_IRI.parse _namespace_name "InfrastructureImprovementOrUpgrading" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#InfrastructureMaintenance"></see>
    /// </summary>
    let InfrastructureMaintenance =
        Namespaced_IRI.parse _namespace_name "InfrastructureMaintenance" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#InfrastructureSideAssistance"></see>
    /// </summary>
    let InfrastructureSideAssistance =
        Namespaced_IRI.parse _namespace_name "InfrastructureSideAssistance" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#InfrastructureSideCommunicationsSystemFailure"></see>
    /// </summary>
    let InfrastructureSideCommunicationsSystemFailure =
        Namespaced_IRI.parse _namespace_name "InfrastructureSideCommunicationsSystemFailure" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#InfrastructureSideCommunicationsSystemFault"></see>
    /// </summary>
    let InfrastructureSideCommunicationsSystemFault =
        Namespaced_IRI.parse _namespace_name "InfrastructureSideCommunicationsSystemFault" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#InfrastructureSidePowerSystemFailure"></see>
    /// </summary>
    let InfrastructureSidePowerSystemFailure =
        Namespaced_IRI.parse _namespace_name "InfrastructureSidePowerSystemFailure" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#InfrastructureSidePowerSystemFault"></see>
    /// </summary>
    let InfrastructureSidePowerSystemFault =
        Namespaced_IRI.parse _namespace_name "InfrastructureSidePowerSystemFault" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#InfrastructureSideWork"></see>
    /// </summary>
    let InfrastructureSideWork =
        Namespaced_IRI.parse _namespace_name "InfrastructureSideWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#InfrastructureSurfaceInPoorCondition"></see>
    /// </summary>
    let InfrastructureSurfaceInPoorCondition =
        Namespaced_IRI.parse _namespace_name "InfrastructureSurfaceInPoorCondition" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#InfrastructureWorks"></see>
    /// </summary>
    let InfrastructureWorks =
        Namespaced_IRI.parse _namespace_name "InfrastructureWorks" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#InfrastructureWorksClearance"></see>
    /// </summary>
    let InfrastructureWorksClearance =
        Namespaced_IRI.parse _namespace_name "InfrastructureWorksClearance" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#InstallationWork"></see>
    /// </summary>
    let InstallationWork =
        Namespaced_IRI.parse _namespace_name "InstallationWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#IntermittentShortTermClosures"></see>
    /// </summary>
    let IntermittentShortTermClosures =
        Namespaced_IRI.parse _namespace_name "IntermittentShortTermClosures" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#InternationalSportsMeeting"></see>
    /// </summary>
    let InternationalSportsMeeting =
        Namespaced_IRI.parse _namespace_name "InternationalSportsMeeting" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#JackknifedArticulatedLorry"></see>
    /// </summary>
    let JackknifedArticulatedLorry =
        Namespaced_IRI.parse _namespace_name "JackknifedArticulatedLorry" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#JackknifedCaravan"></see>
    /// </summary>
    let JackknifedCaravan =
        Namespaced_IRI.parse _namespace_name "JackknifedCaravan" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#JackknifedTrailer"></see>
    /// </summary>
    let JackknifedTrailer =
        Namespaced_IRI.parse _namespace_name "JackknifedTrailer" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#JuridicalReconstruction"></see>
    /// </summary>
    let JuridicalReconstruction =
        Namespaced_IRI.parse _namespace_name "JuridicalReconstruction" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Landslips"></see>
    /// </summary>
    let Landslips = Namespaced_IRI.parse _namespace_name "Landslips" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#LaneClosure"></see>
    /// </summary>
    let LaneClosure =
        Namespaced_IRI.parse _namespace_name "LaneClosure" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#LaneControlSignFailure"></see>
    /// </summary>
    let LaneControlSignFailure =
        Namespaced_IRI.parse _namespace_name "LaneControlSignFailure" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#LaneControlSignFault"></see>
    /// </summary>
    let LaneControlSignFault =
        Namespaced_IRI.parse _namespace_name "LaneControlSignFault" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#LanesDeviated"></see>
    /// </summary>
    let LanesDeviated =
        Namespaced_IRI.parse _namespace_name "LanesDeviated" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#LargeAnimalsOnTheInfrastructure"></see>
    /// </summary>
    let LargeAnimalsOnTheInfrastructure =
        Namespaced_IRI.parse _namespace_name "LargeAnimalsOnTheInfrastructure" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#LeavesOnInfrastructure"></see>
    /// </summary>
    let LeavesOnInfrastructure =
        Namespaced_IRI.parse _namespace_name "LeavesOnInfrastructure" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#LevelCrossingFailure"></see>
    /// </summary>
    let LevelCrossingFailure =
        Namespaced_IRI.parse _namespace_name "LevelCrossingFailure" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#LevelCrossingFault"></see>
    /// </summary>
    let LevelCrossingFault =
        Namespaced_IRI.parse _namespace_name "LevelCrossingFault" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#LitterClearance"></see>
    /// </summary>
    let LitterClearance =
        Namespaced_IRI.parse _namespace_name "LitterClearance" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#LongLoad"></see>
    /// </summary>
    let LongLoad = Namespaced_IRI.parse _namespace_name "LongLoad" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#LooseChippings"></see>
    /// </summary>
    let LooseChippings =
        Namespaced_IRI.parse _namespace_name "LooseChippings" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#LooseSandOnInfrastructure"></see>
    /// </summary>
    let LooseSandOnInfrastructure =
        Namespaced_IRI.parse _namespace_name "LooseSandOnInfrastructure" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#LooseSnow"></see>
    /// </summary>
    let LooseSnow = Namespaced_IRI.parse _namespace_name "LooseSnow" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#LowSunGlare"></see>
    /// </summary>
    let LowSunGlare =
        Namespaced_IRI.parse _namespace_name "LowSunGlare" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#MaintenanceWork"></see>
    /// </summary>
    let MaintenanceWork =
        Namespaced_IRI.parse _namespace_name "MaintenanceWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#MajorEvent"></see>
    /// </summary>
    let MajorEvent = Namespaced_IRI.parse _namespace_name "MajorEvent" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Marathon"></see>
    /// </summary>
    let Marathon = Namespaced_IRI.parse _namespace_name "Marathon" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#March"></see>
    /// </summary>
    let March = Namespaced_IRI.parse _namespace_name "March" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Market"></see>
    /// </summary>
    let Market = Namespaced_IRI.parse _namespace_name "Market" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Match"></see>
    /// </summary>
    let Match = Namespaced_IRI.parse _namespace_name "Match" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#MatrixSignFailure"></see>
    /// </summary>
    let MatrixSignFailure =
        Namespaced_IRI.parse _namespace_name "MatrixSignFailure" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#MatrixSignFault"></see>
    /// </summary>
    let MatrixSignFault =
        Namespaced_IRI.parse _namespace_name "MatrixSignFault" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#MilitaryConvoy"></see>
    /// </summary>
    let MilitaryConvoy =
        Namespaced_IRI.parse _namespace_name "MilitaryConvoy" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#ModerateFog"></see>
    /// </summary>
    let ModerateFog =
        Namespaced_IRI.parse _namespace_name "ModerateFog" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#MotorShow"></see>
    /// </summary>
    let MotorShow = Namespaced_IRI.parse _namespace_name "MotorShow" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#MotorSportRaceMeeting"></see>
    /// </summary>
    let MotorSportRaceMeeting =
        Namespaced_IRI.parse _namespace_name "MotorSportRaceMeeting" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#MudOnInfrastructure"></see>
    /// </summary>
    let MudOnInfrastructure =
        Namespaced_IRI.parse _namespace_name "MudOnInfrastructure" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#MudSlide"></see>
    /// </summary>
    let MudSlide = Namespaced_IRI.parse _namespace_name "MudSlide" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#MultipleVehicleCollision"></see>
    /// </summary>
    let MultipleVehicleCollision =
        Namespaced_IRI.parse _namespace_name "MultipleVehicleCollision" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#MultivehicleAccident"></see>
    /// </summary>
    let MultivehicleAccident =
        Namespaced_IRI.parse _namespace_name "MultivehicleAccident" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#NarrowLanes"></see>
    /// </summary>
    let NarrowLanes =
        Namespaced_IRI.parse _namespace_name "NarrowLanes" |> NamespacedName

    /// <summary>
    /// Network management action which is applicable to the road network and its users.
    /// <see href="http://vocab.datex.org/terms#NetworkManagement"></see></summary>
    let NetworkManagement =
        Namespaced_IRI.parse _namespace_name "NetworkManagement" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#NewRoadworksLayout"></see>
    /// </summary>
    let NewRoadworksLayout =
        Namespaced_IRI.parse _namespace_name "NewRoadworksLayout" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Normal"></see>
    /// </summary>
    let Normal = Namespaced_IRI.parse _namespace_name "Normal" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#NormalWinterConditionsForPedestrians"></see>
    /// </summary>
    let NormalWinterConditionsForPedestrians =
        Namespaced_IRI.parse _namespace_name "NormalWinterConditionsForPedestrians" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#ObstacleSignalling"></see>
    /// </summary>
    let ObstacleSignalling =
        Namespaced_IRI.parse _namespace_name "ObstacleSignalling" |> NamespacedName

    /// <summary>
    /// Any stationary or moving obstacle of a physical nature (e.g. obstacles or vehicles from an earlier accident, shed loads on carriageway, rock fall, abnormal or dangerous loads, or animals etc.) which could disrupt or endanger traffic.
    /// <see href="http://vocab.datex.org/terms#Obstruction"></see></summary>
    let Obstruction =
        Namespaced_IRI.parse _namespace_name "Obstruction" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#OilOnInfrastructure"></see>
    /// </summary>
    let OilOnInfrastructure =
        Namespaced_IRI.parse _namespace_name "OilOnInfrastructure" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#OilSpillageAccident"></see>
    /// </summary>
    let OilSpillageAccident =
        Namespaced_IRI.parse _namespace_name "OilSpillageAccident" |> NamespacedName

    /// <summary>
    /// Actions that a traffic operator can decide to implement to prevent or help correct dangerous or poor driving conditions, including maintenance of the road infrastructure.
    /// <see href="http://vocab.datex.org/terms#OperatorAction"></see></summary>
    let OperatorAction =
        Namespaced_IRI.parse _namespace_name "OperatorAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#OverheadWorks"></see>
    /// </summary>
    let OverheadWorks =
        Namespaced_IRI.parse _namespace_name "OverheadWorks" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#OverheightVehicle"></see>
    /// </summary>
    let OverheightVehicle =
        Namespaced_IRI.parse _namespace_name "OverheightVehicle" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#OvernightClosures"></see>
    /// </summary>
    let OvernightClosures =
        Namespaced_IRI.parse _namespace_name "OvernightClosures" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#OverturnedHeavyLorry"></see>
    /// </summary>
    let OverturnedHeavyLorry =
        Namespaced_IRI.parse _namespace_name "OverturnedHeavyLorry" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#OverturnedTrailer"></see>
    /// </summary>
    let OverturnedTrailer =
        Namespaced_IRI.parse _namespace_name "OverturnedTrailer" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#OverturnedVehicle"></see>
    /// </summary>
    let OverturnedVehicle =
        Namespaced_IRI.parse _namespace_name "OverturnedVehicle" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#OzonePollution"></see>
    /// </summary>
    let OzonePollution =
        Namespaced_IRI.parse _namespace_name "OzonePollution" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#PackedSnow"></see>
    /// </summary>
    let PackedSnow = Namespaced_IRI.parse _namespace_name "PackedSnow" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Parade"></see>
    /// </summary>
    let Parade = Namespaced_IRI.parse _namespace_name "Parade" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#PassableWithCare"></see>
    /// </summary>
    let PassableWithCare =
        Namespaced_IRI.parse _namespace_name "PassableWithCare" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#PassengerAssistance"></see>
    /// </summary>
    let PassengerAssistance =
        Namespaced_IRI.parse _namespace_name "PassengerAssistance" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#PatchyFog"></see>
    /// </summary>
    let PatchyFog = Namespaced_IRI.parse _namespace_name "PatchyFog" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#PetrolOnInfrastructure"></see>
    /// </summary>
    let PetrolOnInfrastructure =
        Namespaced_IRI.parse _namespace_name "PetrolOnInfrastructure" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#PoliceCheckPoint"></see>
    /// </summary>
    let PoliceCheckPoint =
        Namespaced_IRI.parse _namespace_name "PoliceCheckPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#PoliceInvestigation"></see>
    /// </summary>
    let PoliceInvestigation =
        Namespaced_IRI.parse _namespace_name "PoliceInvestigation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#PoliceSpeedChecksInOperation"></see>
    /// </summary>
    let PoliceSpeedChecksInOperation =
        Namespaced_IRI.parse _namespace_name "PoliceSpeedChecksInOperation" |> NamespacedName

    /// <summary>
    /// Details of atmospheric pollution.
    /// <see href="http://vocab.datex.org/terms#Pollution"></see></summary>
    let Pollution = Namespaced_IRI.parse _namespace_name "Pollution" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#PrecipitationInTheArea"></see>
    /// </summary>
    let PrecipitationInTheArea =
        Namespaced_IRI.parse _namespace_name "PrecipitationInTheArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Procession"></see>
    /// </summary>
    let Procession = Namespaced_IRI.parse _namespace_name "Procession" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#ProhibitedVehicleOnTheRoadway"></see>
    /// </summary>
    let ProhibitedVehicleOnTheRoadway =
        Namespaced_IRI.parse _namespace_name "ProhibitedVehicleOnTheRoadway" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#PublicDisturbance"></see>
    /// </summary>
    let PublicDisturbance =
        Namespaced_IRI.parse _namespace_name "PublicDisturbance" |> NamespacedName

    /// <summary>
    /// Organised public event which could disrupt traffic.
    /// <see href="http://vocab.datex.org/terms#PublicEvent"></see></summary>
    let PublicEvent =
        Namespaced_IRI.parse _namespace_name "PublicEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#QueuingTraffic"></see>
    /// </summary>
    let QueuingTraffic =
        Namespaced_IRI.parse _namespace_name "QueuingTraffic" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#RaceMeeting"></see>
    /// </summary>
    let RaceMeeting =
        Namespaced_IRI.parse _namespace_name "RaceMeeting" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#RadioactiveLeakAlert"></see>
    /// </summary>
    let RadioactiveLeakAlert =
        Namespaced_IRI.parse _namespace_name "RadioactiveLeakAlert" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Rain"></see>
    /// </summary>
    let Rain = Namespaced_IRI.parse _namespace_name "Rain" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#RainChangingToSnow"></see>
    /// </summary>
    let RainChangingToSnow =
        Namespaced_IRI.parse _namespace_name "RainChangingToSnow" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#RampControlFailure"></see>
    /// </summary>
    let RampControlFailure =
        Namespaced_IRI.parse _namespace_name "RampControlFailure" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#RampControlFault"></see>
    /// </summary>
    let RampControlFault =
        Namespaced_IRI.parse _namespace_name "RampControlFault" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#RampMeteringInOperation"></see>
    /// </summary>
    let RampMeteringInOperation =
        Namespaced_IRI.parse _namespace_name "RampMeteringInOperation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#RearCollision"></see>
    /// </summary>
    let RearCollision =
        Namespaced_IRI.parse _namespace_name "RearCollision" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#RepairWork"></see>
    /// </summary>
    let RepairWork = Namespaced_IRI.parse _namespace_name "RepairWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#ResurfacingWork"></see>
    /// </summary>
    let ResurfacingWork =
        Namespaced_IRI.parse _namespace_name "ResurfacingWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Riot"></see>
    /// </summary>
    let Riot = Namespaced_IRI.parse _namespace_name "Riot" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#RoadCleared"></see>
    /// </summary>
    let RoadCleared =
        Namespaced_IRI.parse _namespace_name "RoadCleared" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#RoadClosure"></see>
    /// </summary>
    let RoadClosure =
        Namespaced_IRI.parse _namespace_name "RoadClosure" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#RoadMarkingWork"></see>
    /// </summary>
    let RoadMarkingWork =
        Namespaced_IRI.parse _namespace_name "RoadMarkingWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#RoadOperatorCheckPoint"></see>
    /// </summary>
    let RoadOperatorCheckPoint =
        Namespaced_IRI.parse _namespace_name "RoadOperatorCheckPoint" |> NamespacedName

    /// <summary>
    /// Road, carriageway or lane management action that is instigated by the network/road operator.
    /// <see href="http://vocab.datex.org/terms#RoadOrCarriagewayOrLaneManagement"></see></summary>
    let RoadOrCarriagewayOrLaneManagement =
        Namespaced_IRI.parse _namespace_name "RoadOrCarriagewayOrLaneManagement" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#RoadSurfaceMelting"></see>
    /// </summary>
    let RoadSurfaceMelting =
        Namespaced_IRI.parse _namespace_name "RoadSurfaceMelting" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#RoadWideningWork"></see>
    /// </summary>
    let RoadWideningWork =
        Namespaced_IRI.parse _namespace_name "RoadWideningWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#RockFallPreventativeMaintenance"></see>
    /// </summary>
    let RockFallPreventativeMaintenance =
        Namespaced_IRI.parse _namespace_name "RockFallPreventativeMaintenance" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Rockfalls"></see>
    /// </summary>
    let Rockfalls = Namespaced_IRI.parse _namespace_name "Rockfalls" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#RollingRoadBlock"></see>
    /// </summary>
    let RollingRoadBlock =
        Namespaced_IRI.parse _namespace_name "RollingRoadBlock" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#RugbyMatch"></see>
    /// </summary>
    let RugbyMatch = Namespaced_IRI.parse _namespace_name "RugbyMatch" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#RushHourLaneInOperation"></see>
    /// </summary>
    let RushHourLaneInOperation =
        Namespaced_IRI.parse _namespace_name "RushHourLaneInOperation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Sabotage"></see>
    /// </summary>
    let Sabotage = Namespaced_IRI.parse _namespace_name "Sabotage" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SaltingInProgress"></see>
    /// </summary>
    let SaltingInProgress =
        Namespaced_IRI.parse _namespace_name "SaltingInProgress" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SaltingOrGrittingVehicleInUse"></see>
    /// </summary>
    let SaltingOrGrittingVehicleInUse =
        Namespaced_IRI.parse _namespace_name "SaltingOrGrittingVehicleInUse" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SandStorms"></see>
    /// </summary>
    let SandStorms = Namespaced_IRI.parse _namespace_name "SandStorms" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SecurityAlert"></see>
    /// </summary>
    let SecurityAlert =
        Namespaced_IRI.parse _namespace_name "SecurityAlert" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SecurityIncident"></see>
    /// </summary>
    let SecurityIncident =
        Namespaced_IRI.parse _namespace_name "SecurityIncident" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SeriousAccident"></see>
    /// </summary>
    let SeriousAccident =
        Namespaced_IRI.parse _namespace_name "SeriousAccident" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SeriousFire"></see>
    /// </summary>
    let SeriousFire =
        Namespaced_IRI.parse _namespace_name "SeriousFire" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SeveralMajorEvents"></see>
    /// </summary>
    let SeveralMajorEvents =
        Namespaced_IRI.parse _namespace_name "SeveralMajorEvents" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SevereExhaustPollution"></see>
    /// </summary>
    let SevereExhaustPollution =
        Namespaced_IRI.parse _namespace_name "SevereExhaustPollution" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SevereSmog"></see>
    /// </summary>
    let SevereSmog = Namespaced_IRI.parse _namespace_name "SevereSmog" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SewerOverflow"></see>
    /// </summary>
    let SewerOverflow =
        Namespaced_IRI.parse _namespace_name "SewerOverflow" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Show"></see>
    /// </summary>
    let Show = Namespaced_IRI.parse _namespace_name "Show" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#ShowJumping"></see>
    /// </summary>
    let ShowJumping =
        Namespaced_IRI.parse _namespace_name "ShowJumping" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Showers"></see>
    /// </summary>
    let Showers = Namespaced_IRI.parse _namespace_name "Showers" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SideCollision"></see>
    /// </summary>
    let SideCollision =
        Namespaced_IRI.parse _namespace_name "SideCollision" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SightseersObstructingAccess"></see>
    /// </summary>
    let SightseersObstructingAccess =
        Namespaced_IRI.parse _namespace_name "SightseersObstructingAccess" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SingleAlternateLineTraffic"></see>
    /// </summary>
    let SingleAlternateLineTraffic =
        Namespaced_IRI.parse _namespace_name "SingleAlternateLineTraffic" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Sleet"></see>
    /// </summary>
    let Sleet = Namespaced_IRI.parse _namespace_name "Sleet" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SlipperyRoad"></see>
    /// </summary>
    let SlipperyRoad =
        Namespaced_IRI.parse _namespace_name "SlipperyRoad" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SlowMovingMaintenanceVehicle"></see>
    /// </summary>
    let SlowMovingMaintenanceVehicle =
        Namespaced_IRI.parse _namespace_name "SlowMovingMaintenanceVehicle" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SlowTraffic"></see>
    /// </summary>
    let SlowTraffic =
        Namespaced_IRI.parse _namespace_name "SlowTraffic" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SlowVehicle"></see>
    /// </summary>
    let SlowVehicle =
        Namespaced_IRI.parse _namespace_name "SlowVehicle" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SlushOnRoad"></see>
    /// </summary>
    let SlushOnRoad =
        Namespaced_IRI.parse _namespace_name "SlushOnRoad" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SlushStrings"></see>
    /// </summary>
    let SlushStrings =
        Namespaced_IRI.parse _namespace_name "SlushStrings" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SmogAlert"></see>
    /// </summary>
    let SmogAlert = Namespaced_IRI.parse _namespace_name "SmogAlert" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SmokeHazard"></see>
    /// </summary>
    let SmokeHazard =
        Namespaced_IRI.parse _namespace_name "SmokeHazard" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SmokeOrFumes"></see>
    /// </summary>
    let SmokeOrFumes =
        Namespaced_IRI.parse _namespace_name "SmokeOrFumes" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SnowChangingToRain"></see>
    /// </summary>
    let SnowChangingToRain =
        Namespaced_IRI.parse _namespace_name "SnowChangingToRain" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SnowDrifts"></see>
    /// </summary>
    let SnowDrifts = Namespaced_IRI.parse _namespace_name "SnowDrifts" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SnowOnPavement"></see>
    /// </summary>
    let SnowOnPavement =
        Namespaced_IRI.parse _namespace_name "SnowOnPavement" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SnowOnTheInfrastructure"></see>
    /// </summary>
    let SnowOnTheInfrastructure =
        Namespaced_IRI.parse _namespace_name "SnowOnTheInfrastructure" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Snowfall"></see>
    /// </summary>
    let Snowfall = Namespaced_IRI.parse _namespace_name "Snowfall" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Snowplough"></see>
    /// </summary>
    let Snowplough = Namespaced_IRI.parse _namespace_name "Snowplough" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SnowploughsInUse"></see>
    /// </summary>
    let SnowploughsInUse =
        Namespaced_IRI.parse _namespace_name "SnowploughsInUse" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SpeedControlSignFailure"></see>
    /// </summary>
    let SpeedControlSignFailure =
        Namespaced_IRI.parse _namespace_name "SpeedControlSignFailure" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SpeedControlSignFault"></see>
    /// </summary>
    let SpeedControlSignFault =
        Namespaced_IRI.parse _namespace_name "SpeedControlSignFault" |> NamespacedName

    /// <summary>
    /// Speed management action that is instigated by the network/road operator.
    /// <see href="http://vocab.datex.org/terms#SpeedManagement"></see></summary>
    let SpeedManagement =
        Namespaced_IRI.parse _namespace_name "SpeedManagement" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SpeedRestriction"></see>
    /// </summary>
    let SpeedRestriction =
        Namespaced_IRI.parse _namespace_name "SpeedRestriction" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SportsMeeting"></see>
    /// </summary>
    let SportsMeeting =
        Namespaced_IRI.parse _namespace_name "SportsMeeting" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SprayHazard"></see>
    /// </summary>
    let SprayHazard =
        Namespaced_IRI.parse _namespace_name "SprayHazard" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#StateOccasion"></see>
    /// </summary>
    let StateOccasion =
        Namespaced_IRI.parse _namespace_name "StateOccasion" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#StationaryTraffic"></see>
    /// </summary>
    let StationaryTraffic =
        Namespaced_IRI.parse _namespace_name "StationaryTraffic" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#StormDamage"></see>
    /// </summary>
    let StormDamage =
        Namespaced_IRI.parse _namespace_name "StormDamage" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#StormForceWinds"></see>
    /// </summary>
    let StormForceWinds =
        Namespaced_IRI.parse _namespace_name "StormForceWinds" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#StreetLightingFailure"></see>
    /// </summary>
    let StreetLightingFailure =
        Namespaced_IRI.parse _namespace_name "StreetLightingFailure" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#StreetLightingFault"></see>
    /// </summary>
    let StreetLightingFault =
        Namespaced_IRI.parse _namespace_name "StreetLightingFault" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Strike"></see>
    /// </summary>
    let Strike = Namespaced_IRI.parse _namespace_name "Strike" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#StrongGustsOfWind"></see>
    /// </summary>
    let StrongGustsOfWind =
        Namespaced_IRI.parse _namespace_name "StrongGustsOfWind" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#StrongWinds"></see>
    /// </summary>
    let StrongWinds =
        Namespaced_IRI.parse _namespace_name "StrongWinds" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Subsidence"></see>
    /// </summary>
    let Subsidence = Namespaced_IRI.parse _namespace_name "Subsidence" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SurfaceWater"></see>
    /// </summary>
    let SurfaceWater =
        Namespaced_IRI.parse _namespace_name "SurfaceWater" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Survey"></see>
    /// </summary>
    let Survey = Namespaced_IRI.parse _namespace_name "Survey" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SwarmsOfInsects"></see>
    /// </summary>
    let SwarmsOfInsects =
        Namespaced_IRI.parse _namespace_name "SwarmsOfInsects" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#SweepingOfRoad"></see>
    /// </summary>
    let SweepingOfRoad =
        Namespaced_IRI.parse _namespace_name "SweepingOfRoad" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TemperatureFalling"></see>
    /// </summary>
    let TemperatureFalling =
        Namespaced_IRI.parse _namespace_name "TemperatureFalling" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TemporaryTrafficLights"></see>
    /// </summary>
    let TemporaryTrafficLights =
        Namespaced_IRI.parse _namespace_name "TemporaryTrafficLights" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TemporaryTrafficLightsFailure"></see>
    /// </summary>
    let TemporaryTrafficLightsFailure =
        Namespaced_IRI.parse _namespace_name "TemporaryTrafficLightsFailure" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TemporaryTrafficLightsFault"></see>
    /// </summary>
    let TemporaryTrafficLightsFault =
        Namespaced_IRI.parse _namespace_name "TemporaryTrafficLightsFault" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TennisTournament"></see>
    /// </summary>
    let TennisTournament =
        Namespaced_IRI.parse _namespace_name "TennisTournament" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TerroristIncident"></see>
    /// </summary>
    let TerroristIncident =
        Namespaced_IRI.parse _namespace_name "TerroristIncident" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Theft"></see>
    /// </summary>
    let Theft = Namespaced_IRI.parse _namespace_name "Theft" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Thunderstorms"></see>
    /// </summary>
    let Thunderstorms =
        Namespaced_IRI.parse _namespace_name "Thunderstorms" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TidalFlowLaneInOperation"></see>
    /// </summary>
    let TidalFlowLaneInOperation =
        Namespaced_IRI.parse _namespace_name "TidalFlowLaneInOperation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TollGatesFailure"></see>
    /// </summary>
    let TollGatesFailure =
        Namespaced_IRI.parse _namespace_name "TollGatesFailure" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TollGatesFault"></see>
    /// </summary>
    let TollGatesFault =
        Namespaced_IRI.parse _namespace_name "TollGatesFault" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TollGatesOpen"></see>
    /// </summary>
    let TollGatesOpen =
        Namespaced_IRI.parse _namespace_name "TollGatesOpen" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Tornadoes"></see>
    /// </summary>
    let Tornadoes = Namespaced_IRI.parse _namespace_name "Tornadoes" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Tournament"></see>
    /// </summary>
    let Tournament = Namespaced_IRI.parse _namespace_name "Tournament" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#ToxicCloudAlert"></see>
    /// </summary>
    let ToxicCloudAlert =
        Namespaced_IRI.parse _namespace_name "ToxicCloudAlert" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TrackLayingVehicle"></see>
    /// </summary>
    let TrackLayingVehicle =
        Namespaced_IRI.parse _namespace_name "TrackLayingVehicle" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TradeFair"></see>
    /// </summary>
    let TradeFair = Namespaced_IRI.parse _namespace_name "TradeFair" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TrafficBeingManuallyDirected"></see>
    /// </summary>
    let TrafficBeingManuallyDirected =
        Namespaced_IRI.parse _namespace_name "TrafficBeingManuallyDirected" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TrafficElementEvent"></see>
    /// </summary>
    let TrafficElementEvent =
        Namespaced_IRI.parse _namespace_name "TrafficElementEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TrafficHeld"></see>
    /// </summary>
    let TrafficHeld =
        Namespaced_IRI.parse _namespace_name "TrafficHeld" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TrafficLightSetFailure"></see>
    /// </summary>
    let TrafficLightSetFailure =
        Namespaced_IRI.parse _namespace_name "TrafficLightSetFailure" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TrafficLightSetFault"></see>
    /// </summary>
    let TrafficLightSetFault =
        Namespaced_IRI.parse _namespace_name "TrafficLightSetFault" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TrafficSignalsFailure"></see>
    /// </summary>
    let TrafficSignalsFailure =
        Namespaced_IRI.parse _namespace_name "TrafficSignalsFailure" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TrafficSignalsFault"></see>
    /// </summary>
    let TrafficSignalsFault =
        Namespaced_IRI.parse _namespace_name "TrafficSignalsFault" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TransportOfVip"></see>
    /// </summary>
    let TransportOfVip =
        Namespaced_IRI.parse _namespace_name "TransportOfVip" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TreeAndVegetationCuttingWork"></see>
    /// </summary>
    let TreeAndVegetationCuttingWork =
        Namespaced_IRI.parse _namespace_name "TreeAndVegetationCuttingWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TunnelLightFailure"></see>
    /// </summary>
    let TunnelLightFailure =
        Namespaced_IRI.parse _namespace_name "TunnelLightFailure" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TunnelLightFault"></see>
    /// </summary>
    let TunnelLightFault =
        Namespaced_IRI.parse _namespace_name "TunnelLightFault" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TunnelVentilationFailure"></see>
    /// </summary>
    let TunnelVentilationFailure =
        Namespaced_IRI.parse _namespace_name "TunnelVentilationFailure" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TunnelVentilationFault"></see>
    /// </summary>
    let TunnelVentilationFault =
        Namespaced_IRI.parse _namespace_name "TunnelVentilationFault" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#TurnAroundInOperation"></see>
    /// </summary>
    let TurnAroundInOperation =
        Namespaced_IRI.parse _namespace_name "TurnAroundInOperation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#UndefinedAuthorityActivity"></see>
    /// </summary>
    let UndefinedAuthorityActivity =
        Namespaced_IRI.parse _namespace_name "UndefinedAuthorityActivity" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Unknown"></see>
    /// </summary>
    let Unknown = Namespaced_IRI.parse _namespace_name "Unknown" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#UnlitVehicleOnTheRoad"></see>
    /// </summary>
    let UnlitVehicleOnTheRoad =
        Namespaced_IRI.parse _namespace_name "UnlitVehicleOnTheRoad" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#UnspecifiedAbnormalTraffic"></see>
    /// </summary>
    let UnspecifiedAbnormalTraffic =
        Namespaced_IRI.parse _namespace_name "UnspecifiedAbnormalTraffic" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#UnspecifiedAlert"></see>
    /// </summary>
    let UnspecifiedAlert =
        Namespaced_IRI.parse _namespace_name "UnspecifiedAlert" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#UseOfSpecifiedLanesOrCarriagewaysAllowed"></see>
    /// </summary>
    let UseOfSpecifiedLanesOrCarriagewaysAllowed =
        Namespaced_IRI.parse _namespace_name "UseOfSpecifiedLanesOrCarriagewaysAllowed" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VariableMessageSignFailure"></see>
    /// </summary>
    let VariableMessageSignFailure =
        Namespaced_IRI.parse _namespace_name "VariableMessageSignFailure" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VariableMessageSignFault"></see>
    /// </summary>
    let VariableMessageSignFault =
        Namespaced_IRI.parse _namespace_name "VariableMessageSignFault" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VehicleCarryingHazardousMaterials"></see>
    /// </summary>
    let VehicleCarryingHazardousMaterials =
        Namespaced_IRI.parse _namespace_name "VehicleCarryingHazardousMaterials" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VehicleInDifficulty"></see>
    /// </summary>
    let VehicleInDifficulty =
        Namespaced_IRI.parse _namespace_name "VehicleInDifficulty" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VehicleInspectionCheckPoint"></see>
    /// </summary>
    let VehicleInspectionCheckPoint =
        Namespaced_IRI.parse _namespace_name "VehicleInspectionCheckPoint" |> NamespacedName

    /// <summary>
    /// An obstruction on the road caused by one or more vehicles.
    /// <see href="http://vocab.datex.org/terms#VehicleObstruction"></see></summary>
    let VehicleObstruction =
        Namespaced_IRI.parse _namespace_name "VehicleObstruction" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VehicleOffRoad"></see>
    /// </summary>
    let VehicleOffRoad =
        Namespaced_IRI.parse _namespace_name "VehicleOffRoad" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VehicleOnFire"></see>
    /// </summary>
    let VehicleOnFire =
        Namespaced_IRI.parse _namespace_name "VehicleOnFire" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VehicleOnWrongCarriageway"></see>
    /// </summary>
    let VehicleOnWrongCarriageway =
        Namespaced_IRI.parse _namespace_name "VehicleOnWrongCarriageway" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VehicleRecovery"></see>
    /// </summary>
    let VehicleRecovery =
        Namespaced_IRI.parse _namespace_name "VehicleRecovery" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VehicleRepair"></see>
    /// </summary>
    let VehicleRepair =
        Namespaced_IRI.parse _namespace_name "VehicleRepair" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VehicleSpunAround"></see>
    /// </summary>
    let VehicleSpunAround =
        Namespaced_IRI.parse _namespace_name "VehicleSpunAround" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VehicleStorageInOperation"></see>
    /// </summary>
    let VehicleStorageInOperation =
        Namespaced_IRI.parse _namespace_name "VehicleStorageInOperation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VehicleStuck"></see>
    /// </summary>
    let VehicleStuck =
        Namespaced_IRI.parse _namespace_name "VehicleStuck" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VehicleStuckUnderBridge"></see>
    /// </summary>
    let VehicleStuckUnderBridge =
        Namespaced_IRI.parse _namespace_name "VehicleStuckUnderBridge" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VehicleWeighing"></see>
    /// </summary>
    let VehicleWeighing =
        Namespaced_IRI.parse _namespace_name "VehicleWeighing" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VehicleWithOverheightLoad"></see>
    /// </summary>
    let VehicleWithOverheightLoad =
        Namespaced_IRI.parse _namespace_name "VehicleWithOverheightLoad" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VehicleWithOverwideLoad"></see>
    /// </summary>
    let VehicleWithOverwideLoad =
        Namespaced_IRI.parse _namespace_name "VehicleWithOverwideLoad" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VeryHazardous"></see>
    /// </summary>
    let VeryHazardous =
        Namespaced_IRI.parse _namespace_name "VeryHazardous" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VeryStrongGustsOfWind"></see>
    /// </summary>
    let VeryStrongGustsOfWind =
        Namespaced_IRI.parse _namespace_name "VeryStrongGustsOfWind" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VisibilityReduced"></see>
    /// </summary>
    let VisibilityReduced =
        Namespaced_IRI.parse _namespace_name "VisibilityReduced" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#WaterSportsMeeting"></see>
    /// </summary>
    let WaterSportsMeeting =
        Namespaced_IRI.parse _namespace_name "WaterSportsMeeting" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#WeakBridge"></see>
    /// </summary>
    let WeakBridge = Namespaced_IRI.parse _namespace_name "WeakBridge" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#WeatherRelatedConditions"></see>
    /// </summary>
    let WeatherRelatedConditions =
        Namespaced_IRI.parse _namespace_name "WeatherRelatedConditions" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#WeighInMotion"></see>
    /// </summary>
    let WeighInMotion =
        Namespaced_IRI.parse _namespace_name "WeighInMotion" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#WeightRestrictionInOperation"></see>
    /// </summary>
    let WeightRestrictionInOperation =
        Namespaced_IRI.parse _namespace_name "WeightRestrictionInOperation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Wet"></see>
    /// </summary>
    let Wet = Namespaced_IRI.parse _namespace_name "Wet" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#WetAndIcyRoad"></see>
    /// </summary>
    let WetAndIcyRoad =
        Namespaced_IRI.parse _namespace_name "WetAndIcyRoad" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#WetIcyPavement"></see>
    /// </summary>
    let WetIcyPavement =
        Namespaced_IRI.parse _namespace_name "WetIcyPavement" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#WhiteOut"></see>
    /// </summary>
    let WhiteOut = Namespaced_IRI.parse _namespace_name "WhiteOut" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#WinterConditions"></see>
    /// </summary>
    let WinterConditions =
        Namespaced_IRI.parse _namespace_name "WinterConditions" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#WinterSportsMeeting"></see>
    /// </summary>
    let WinterSportsMeeting =
        Namespaced_IRI.parse _namespace_name "WinterSportsMeeting" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#WinterStorm"></see>
    /// </summary>
    let WinterStorm =
        Namespaced_IRI.parse _namespace_name "WinterStorm" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Ontology"></see>
    /// </summary>
    let Ontology = Namespaced_IRI.parse _namespace_name "Ontology" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#abnormalTrafficExtension"></see>
    /// </summary>
    let abnormalTrafficExtension =
        Namespaced_IRI.parse _namespace_name "abnormalTrafficExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_ExtensionType"></see>
    /// </summary>
    let _ExtensionType =
        Namespaced_IRI.parse _namespace_name "_ExtensionType" |> NamespacedName

    /// <summary>
    /// A characterization of the nature of abnormal traffic flow, i.e. specifically relating to the nature of the traffic movement.
    /// <see href="http://vocab.datex.org/terms#abnormalTrafficType"></see></summary>
    let abnormalTrafficType =
        Namespaced_IRI.parse _namespace_name "abnormalTrafficType" |> NamespacedName

    /// <summary>
    /// The number of vehicles waiting in a queue.
    /// <see href="http://vocab.datex.org/terms#numberOfVehiclesWaiting"></see></summary>
    let numberOfVehiclesWaiting =
        Namespaced_IRI.parse _namespace_name "numberOfVehiclesWaiting" |> NamespacedName

    /// <summary>
    /// The length of a queue or the average length of queues in separate lanes due to a situation.
    /// <see href="http://vocab.datex.org/terms#queueLength"></see></summary>
    let queueLength =
        Namespaced_IRI.parse _namespace_name "queueLength" |> NamespacedName

    /// <summary>
    /// Assessment of the traffic flow conditions relative to normally expected conditions at this date/time.
    /// <see href="http://vocab.datex.org/terms#relativeTrafficFlow"></see></summary>
    let relativeTrafficFlow =
        Namespaced_IRI.parse _namespace_name "relativeTrafficFlow" |> NamespacedName

    /// <summary>
    /// A characterization of the traffic flow.
    /// <see href="http://vocab.datex.org/terms#trafficFlowCharacteristics"></see></summary>
    let trafficFlowCharacteristics =
        Namespaced_IRI.parse _namespace_name "trafficFlowCharacteristics" |> NamespacedName

    /// <summary>
    /// A characterization of the trend in the traffic conditions at the specified location and direction.
    /// <see href="http://vocab.datex.org/terms#trafficTrendType"></see></summary>
    let trafficTrendType =
        Namespaced_IRI.parse _namespace_name "trafficTrendType" |> NamespacedName

    /// <summary>
    /// An event which is not planned by the traffic operator, which is affecting, or has the potential to affect traffic flow.
    /// <see href="http://vocab.datex.org/terms#TrafficElement"></see></summary>
    let TrafficElement =
        Namespaced_IRI.parse _namespace_name "TrafficElement" |> NamespacedName

    /// <summary>
    /// Use this class to describe details in case acceptedMeansOfPayment is set to 'paymentCard'.
    /// <see href="http://vocab.datex.org/terms#AcceptedPaymentCards"></see></summary>
    let AcceptedPaymentCards =
        Namespaced_IRI.parse _namespace_name "AcceptedPaymentCards" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#acceptedPaymentCardsExtension"></see>
    /// </summary>
    let acceptedPaymentCardsExtension =
        Namespaced_IRI.parse _namespace_name "acceptedPaymentCardsExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#otherPaymentCardBrands"></see>
    /// </summary>
    let otherPaymentCardBrands =
        Namespaced_IRI.parse _namespace_name "otherPaymentCardBrands" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#otherPaymentCards"></see>
    /// </summary>
    let otherPaymentCards =
        Namespaced_IRI.parse _namespace_name "otherPaymentCards" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#paymentCardBrands"></see>
    /// </summary>
    let paymentCardBrands =
        Namespaced_IRI.parse _namespace_name "paymentCardBrands" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#paymentCards"></see>
    /// </summary>
    let paymentCards =
        Namespaced_IRI.parse _namespace_name "paymentCards" |> NamespacedName

    /// <summary>
    /// A descriptor indicating the most significant factor causing an accident.
    /// <see href="http://vocab.datex.org/terms#accidentCause"></see></summary>
    let accidentCause =
        Namespaced_IRI.parse _namespace_name "accidentCause" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#accidentExtension"></see>
    /// </summary>
    let accidentExtension =
        Namespaced_IRI.parse _namespace_name "accidentExtension" |> NamespacedName

    /// <summary>
    /// A characterization of the nature of the accident.
    /// <see href="http://vocab.datex.org/terms#accidentType"></see></summary>
    let accidentType =
        Namespaced_IRI.parse _namespace_name "accidentType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#groupOfPeopleInvolved"></see>
    /// </summary>
    let groupOfPeopleInvolved =
        Namespaced_IRI.parse _namespace_name "groupOfPeopleInvolved" |> NamespacedName

    /// <summary>
    /// Group of people involved in the event having common characteristics and/or status.
    /// <see href="http://vocab.datex.org/terms#GroupOfPeopleInvolved"></see></summary>
    let GroupOfPeopleInvolved =
        Namespaced_IRI.parse _namespace_name "GroupOfPeopleInvolved" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#groupOfVehiclesInvolved"></see>
    /// </summary>
    let groupOfVehiclesInvolved =
        Namespaced_IRI.parse _namespace_name "groupOfVehiclesInvolved" |> NamespacedName

    /// <summary>
    /// Group of the vehicles involved having common characteristics and/or status.
    /// <see href="http://vocab.datex.org/terms#GroupOfVehiclesInvolved"></see></summary>
    let GroupOfVehiclesInvolved =
        Namespaced_IRI.parse _namespace_name "GroupOfVehiclesInvolved" |> NamespacedName

    /// <summary>
    /// The total number of people that are involved.
    /// <see href="http://vocab.datex.org/terms#totalNumberOfPeopleInvolved"></see></summary>
    let totalNumberOfPeopleInvolved =
        Namespaced_IRI.parse _namespace_name "totalNumberOfPeopleInvolved" |> NamespacedName

    /// <summary>
    /// The total number of vehicles that are involved.
    /// <see href="http://vocab.datex.org/terms#totalNumberOfVehiclesInvolved"></see></summary>
    let totalNumberOfVehiclesInvolved =
        Namespaced_IRI.parse _namespace_name "totalNumberOfVehiclesInvolved" |> NamespacedName

    /// <summary>
    /// The vehicle involved in the accident.
    /// <see href="http://vocab.datex.org/terms#vehicleInvolved"></see></summary>
    let vehicleInvolved =
        Namespaced_IRI.parse _namespace_name "vehicleInvolved" |> NamespacedName

    /// <summary>
    /// Details of an individual vehicle.
    /// <see href="http://vocab.datex.org/terms#Vehicle"></see></summary>
    let Vehicle = Namespaced_IRI.parse _namespace_name "Vehicle" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#activityExtension"></see>
    /// </summary>
    let activityExtension =
        Namespaced_IRI.parse _namespace_name "activityExtension" |> NamespacedName

    /// <summary>
    /// Mobility of the activity.
    /// <see href="http://vocab.datex.org/terms#mobilityOfActivity"></see></summary>
    let mobilityOfActivity =
        Namespaced_IRI.parse _namespace_name "mobilityOfActivity" |> NamespacedName

    /// <summary>
    /// An indication of whether the associated instance of a SituationRecord is mobile (e.g. a march or parade moving along a road) or stationary.
    /// <see href="http://vocab.datex.org/terms#Mobility"></see></summary>
    let Mobility = Namespaced_IRI.parse _namespace_name "Mobility" |> NamespacedName

    /// <summary>
    /// Supplementary positional information which details carriageway and lane locations. Several instances may exist where the element being described extends over more than one carriageway.
    /// <see href="http://vocab.datex.org/terms#AffectedCarriagewayAndLanes"></see></summary>
    let AffectedCarriagewayAndLanes =
        Namespaced_IRI.parse _namespace_name "AffectedCarriagewayAndLanes" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#affectedCarriagewayAndLanesExtension"></see>
    /// </summary>
    let affectedCarriagewayAndLanesExtension =
        Namespaced_IRI.parse _namespace_name "affectedCarriagewayAndLanesExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#carriageway"></see>
    /// </summary>
    let carriageway =
        Namespaced_IRI.parse _namespace_name "carriageway" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#footpath"></see>
    /// </summary>
    let footpath = Namespaced_IRI.parse _namespace_name "footpath" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#lane"></see>
    /// </summary>
    let lane = Namespaced_IRI.parse _namespace_name "lane" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#lengthAffected"></see>
    /// </summary>
    let lengthAffected =
        Namespaced_IRI.parse _namespace_name "lengthAffected" |> NamespacedName

    /// <summary>
    /// An area defined by reference to a predefined ALERT-C location table.
    /// <see href="http://vocab.datex.org/terms#AlertCArea"></see></summary>
    let AlertCArea = Namespaced_IRI.parse _namespace_name "AlertCArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCAreaExtension"></see>
    /// </summary>
    let alertCAreaExtension =
        Namespaced_IRI.parse _namespace_name "alertCAreaExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCLocationCountryCode"></see>
    /// </summary>
    let alertCLocationCountryCode =
        Namespaced_IRI.parse _namespace_name "alertCLocationCountryCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCLocationTableNumber"></see>
    /// </summary>
    let alertCLocationTableNumber =
        Namespaced_IRI.parse _namespace_name "alertCLocationTableNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCLocationTableVersion"></see>
    /// </summary>
    let alertCLocationTableVersion =
        Namespaced_IRI.parse _namespace_name "alertCLocationTableVersion" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#areaLocation"></see>
    /// </summary>
    let areaLocation =
        Namespaced_IRI.parse _namespace_name "areaLocation" |> NamespacedName

    /// <summary>
    /// Identification of a specific point, linear or area location in an ALERT-C location table.
    /// <see href="http://vocab.datex.org/terms#AlertCLocation"></see></summary>
    let AlertCLocation =
        Namespaced_IRI.parse _namespace_name "AlertCLocation" |> NamespacedName

    /// <summary>
    /// The direction of traffic flow along the road to which the information relates.
    /// <see href="http://vocab.datex.org/terms#AlertCDirection"></see></summary>
    let AlertCDirection =
        Namespaced_IRI.parse _namespace_name "AlertCDirection" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCDirectionCoded"></see>
    /// </summary>
    let alertCDirectionCoded =
        Namespaced_IRI.parse _namespace_name "alertCDirectionCoded" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCDirectionExtension"></see>
    /// </summary>
    let alertCDirectionExtension =
        Namespaced_IRI.parse _namespace_name "alertCDirectionExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCDirectionNamed"></see>
    /// </summary>
    let alertCDirectionNamed =
        Namespaced_IRI.parse _namespace_name "alertCDirectionNamed" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#MultilingualString"></see>
    /// </summary>
    let MultilingualString =
        Namespaced_IRI.parse _namespace_name "MultilingualString" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCDirectionSense"></see>
    /// </summary>
    let alertCDirectionSense =
        Namespaced_IRI.parse _namespace_name "alertCDirectionSense" |> NamespacedName

    /// <summary>
    /// A linear section along a road defined between two points on the road by reference to a pre-defined ALERT-C location table.
    /// <see href="http://vocab.datex.org/terms#AlertCLinear"></see></summary>
    let AlertCLinear =
        Namespaced_IRI.parse _namespace_name "AlertCLinear" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCLinearExtension"></see>
    /// </summary>
    let alertCLinearExtension =
        Namespaced_IRI.parse _namespace_name "alertCLinearExtension" |> NamespacedName

    /// <summary>
    /// A linear section along a road defined by reference to a linear section in a pre-defined ALERT-C location table.
    /// <see href="http://vocab.datex.org/terms#AlertCLinearByCode"></see></summary>
    let AlertCLinearByCode =
        Namespaced_IRI.parse _namespace_name "AlertCLinearByCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCDirection"></see>
    /// </summary>
    let alertCDirection =
        Namespaced_IRI.parse _namespace_name "alertCDirection" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCLinearByCodeExtension"></see>
    /// </summary>
    let alertCLinearByCodeExtension =
        Namespaced_IRI.parse _namespace_name "alertCLinearByCodeExtension" |> NamespacedName

    /// <summary>
    /// Linear location defined by a specific Alert-C location.
    /// <see href="http://vocab.datex.org/terms#locationCodeForLinearLocation"></see></summary>
    let locationCodeForLinearLocation =
        Namespaced_IRI.parse _namespace_name "locationCodeForLinearLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCLocationExtension"></see>
    /// </summary>
    let alertCLocationExtension =
        Namespaced_IRI.parse _namespace_name "alertCLocationExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCLocationName"></see>
    /// </summary>
    let alertCLocationName =
        Namespaced_IRI.parse _namespace_name "alertCLocationName" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#specificLocation"></see>
    /// </summary>
    let specificLocation =
        Namespaced_IRI.parse _namespace_name "specificLocation" |> NamespacedName

    /// <summary>
    /// A linear section along a road between two points, Primary and Secondary, which are pre-defined in an ALERT-C location table. Direction is FROM the Secondary point TO the Primary point, i.e. the Primary point is downstream of the Secondary point.
    /// <see href="http://vocab.datex.org/terms#AlertCMethod2Linear"></see></summary>
    let AlertCMethod2Linear =
        Namespaced_IRI.parse _namespace_name "AlertCMethod2Linear" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCMethod2LinearExtension"></see>
    /// </summary>
    let alertCMethod2LinearExtension =
        Namespaced_IRI.parse _namespace_name "alertCMethod2LinearExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCMethod2PrimaryPointLocation"></see>
    /// </summary>
    let alertCMethod2PrimaryPointLocation =
        Namespaced_IRI.parse _namespace_name "alertCMethod2PrimaryPointLocation" |> NamespacedName

    /// <summary>
    /// The point (called Primary point) which is either a single point or at the downstream end of a linear road section. The point is specified by a reference to a point in a pre-defined ALERT-C location table.
    /// <see href="http://vocab.datex.org/terms#AlertCMethod2PrimaryPointLocation"></see></summary>
    let AlertCMethod2PrimaryPointLocation =
        Namespaced_IRI.parse _namespace_name "AlertCMethod2PrimaryPointLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCMethod2SecondaryPointLocation"></see>
    /// </summary>
    let alertCMethod2SecondaryPointLocation =
        Namespaced_IRI.parse _namespace_name "alertCMethod2SecondaryPointLocation" |> NamespacedName

    /// <summary>
    /// The point (called Secondary point) which is at the upstream end of a linear road section. The point is specified by a reference to a point in a pre-defined ALERT-C location table.
    /// <see href="http://vocab.datex.org/terms#AlertCMethod2SecondaryPointLocation"></see></summary>
    let AlertCMethod2SecondaryPointLocation =
        Namespaced_IRI.parse _namespace_name "AlertCMethod2SecondaryPointLocation" |> NamespacedName

    /// <summary>
    /// A single point on the road network defined by reference to a point in a pre-defined ALERT-C location table and which has an associated direction of traffic flow.
    /// <see href="http://vocab.datex.org/terms#AlertCMethod2Point"></see></summary>
    let AlertCMethod2Point =
        Namespaced_IRI.parse _namespace_name "AlertCMethod2Point" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCMethod2PointExtension"></see>
    /// </summary>
    let alertCMethod2PointExtension =
        Namespaced_IRI.parse _namespace_name "alertCMethod2PointExtension" |> NamespacedName

    /// <summary>
    /// A single point on the road network defined by reference to a pre-defined ALERT-C location table and which has an associated direction of traffic flow.
    /// <see href="http://vocab.datex.org/terms#AlertCPoint"></see></summary>
    let AlertCPoint =
        Namespaced_IRI.parse _namespace_name "AlertCPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCLocation"></see>
    /// </summary>
    let alertCLocation =
        Namespaced_IRI.parse _namespace_name "alertCLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCMethod2PrimaryPointLocationExtension"></see>
    /// </summary>
    let alertCMethod2PrimaryPointLocationExtension =
        Namespaced_IRI.parse _namespace_name "alertCMethod2PrimaryPointLocationExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCMethod2SecondaryPointLocationExtension"></see>
    /// </summary>
    let alertCMethod2SecondaryPointLocationExtension =
        Namespaced_IRI.parse _namespace_name "alertCMethod2SecondaryPointLocationExtension" |> NamespacedName

    /// <summary>
    /// A linear section along a road between two points, Primary and Secondary, which are pre-defined ALERT-C locations plus offset distance. Direction is FROM the Secondary point TO the Primary point, i.e. the Primary point is downstream of the Secondary point.
    /// <see href="http://vocab.datex.org/terms#AlertCMethod4Linear"></see></summary>
    let AlertCMethod4Linear =
        Namespaced_IRI.parse _namespace_name "AlertCMethod4Linear" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCMethod4LinearExtension"></see>
    /// </summary>
    let alertCMethod4LinearExtension =
        Namespaced_IRI.parse _namespace_name "alertCMethod4LinearExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCMethod4PrimaryPointLocation"></see>
    /// </summary>
    let alertCMethod4PrimaryPointLocation =
        Namespaced_IRI.parse _namespace_name "alertCMethod4PrimaryPointLocation" |> NamespacedName

    /// <summary>
    /// The point (called Primary point) which is either a single point or at the downstream end of a linear road section. The point is specified by a reference to a point in a pre-defined ALERT-C location table plus a non-negative offset distance.
    /// <see href="http://vocab.datex.org/terms#AlertCMethod4PrimaryPointLocation"></see></summary>
    let AlertCMethod4PrimaryPointLocation =
        Namespaced_IRI.parse _namespace_name "AlertCMethod4PrimaryPointLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCMethod4SecondaryPointLocation"></see>
    /// </summary>
    let alertCMethod4SecondaryPointLocation =
        Namespaced_IRI.parse _namespace_name "alertCMethod4SecondaryPointLocation" |> NamespacedName

    /// <summary>
    /// The point (called Secondary point) which is at the upstream end of a linear road section. The point is specified by a reference to a point in a pre-defined Alert-C location table plus a non-negative offset distance.
    /// <see href="http://vocab.datex.org/terms#AlertCMethod4SecondaryPointLocation"></see></summary>
    let AlertCMethod4SecondaryPointLocation =
        Namespaced_IRI.parse _namespace_name "AlertCMethod4SecondaryPointLocation" |> NamespacedName

    /// <summary>
    /// A single point on the road network defined by reference to a point in a pre-defined ALERT-C location table plus an offset distance and which has an associated direction of traffic flow.
    /// <see href="http://vocab.datex.org/terms#AlertCMethod4Point"></see></summary>
    let AlertCMethod4Point =
        Namespaced_IRI.parse _namespace_name "AlertCMethod4Point" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCMethod4PointExtension"></see>
    /// </summary>
    let alertCMethod4PointExtension =
        Namespaced_IRI.parse _namespace_name "alertCMethod4PointExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCMethod4PrimaryPointLocationExtension"></see>
    /// </summary>
    let alertCMethod4PrimaryPointLocationExtension =
        Namespaced_IRI.parse _namespace_name "alertCMethod4PrimaryPointLocationExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#offsetDistance"></see>
    /// </summary>
    let offsetDistance =
        Namespaced_IRI.parse _namespace_name "offsetDistance" |> NamespacedName

    /// <summary>
    /// The non negative offset distance from the ALERT-C referenced point to the actual point.
    /// <see href="http://vocab.datex.org/terms#OffsetDistance"></see></summary>
    let OffsetDistance =
        Namespaced_IRI.parse _namespace_name "OffsetDistance" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCMethod4SecondaryPointLocationExtension"></see>
    /// </summary>
    let alertCMethod4SecondaryPointLocationExtension =
        Namespaced_IRI.parse _namespace_name "alertCMethod4SecondaryPointLocationExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCPointExtension"></see>
    /// </summary>
    let alertCPointExtension =
        Namespaced_IRI.parse _namespace_name "alertCPointExtension" |> NamespacedName

    /// <summary>
    /// Indicates whether the identified animals are dead (immobile) or alive (potentially mobile).
    /// <see href="http://vocab.datex.org/terms#alive"></see></summary>
    let alive = Namespaced_IRI.parse _namespace_name "alive" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#animalPresenceObstructionExtension"></see>
    /// </summary>
    let animalPresenceObstructionExtension =
        Namespaced_IRI.parse _namespace_name "animalPresenceObstructionExtension" |> NamespacedName

    /// <summary>
    /// Indicates the nature of animals present on or near the roadway.
    /// <see href="http://vocab.datex.org/terms#animalPresenceType"></see></summary>
    let animalPresenceType =
        Namespaced_IRI.parse _namespace_name "animalPresenceType" |> NamespacedName

    /// <summary>
    /// A measured or calculated value of the application rate of a substance.
    /// <see href="http://vocab.datex.org/terms#ApplicationRateValue"></see></summary>
    let ApplicationRateValue =
        Namespaced_IRI.parse _namespace_name "ApplicationRateValue" |> NamespacedName

    /// <summary>
    /// A value of the rate of application of a substance expressed in kilogrammes per square metre.
    /// <see href="http://vocab.datex.org/terms#applicationRate"></see></summary>
    let applicationRate =
        Namespaced_IRI.parse _namespace_name "applicationRate" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#applicationRateValueExtension"></see>
    /// </summary>
    let applicationRateValueExtension =
        Namespaced_IRI.parse _namespace_name "applicationRateValueExtension" |> NamespacedName

    /// <summary>
    /// A data value of something that can be measured or calculated. Any provided meta-data values specified in the attributes override any specified generic characteristics such as defined for a specific measurement in the MeasurementSiteTable.
    /// <see href="http://vocab.datex.org/terms#DataValue"></see></summary>
    let DataValue = Namespaced_IRI.parse _namespace_name "DataValue" |> NamespacedName
    /// <summary>
    /// A geographic or geometric defined area which may be qualified by height information to provide additional geospatial discrimination (e.g. for snow in an area but only above a certain altitude).
    /// <see href="http://vocab.datex.org/terms#Area"></see></summary>
    let Area = Namespaced_IRI.parse _namespace_name "Area" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCArea"></see>
    /// </summary>
    let alertCArea = Namespaced_IRI.parse _namespace_name "alertCArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#areaExtension"></see>
    /// </summary>
    let areaExtension =
        Namespaced_IRI.parse _namespace_name "areaExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_AreaExtensionType"></see>
    /// </summary>
    let _AreaExtensionType =
        Namespaced_IRI.parse _namespace_name "_AreaExtensionType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegAreaLocation"></see>
    /// </summary>
    let tpegAreaLocation =
        Namespaced_IRI.parse _namespace_name "tpegAreaLocation" |> NamespacedName

    /// <summary>
    /// A geographic or geometric area defined by a TPEG-Loc structure which may include height information for additional geospatial discrimination.
    /// <see href="http://vocab.datex.org/terms#TpegAreaLocation"></see></summary>
    let TpegAreaLocation =
        Namespaced_IRI.parse _namespace_name "TpegAreaLocation" |> NamespacedName

    /// <summary>
    /// The specification of a location either on a network (as a point or a linear location) or as an area. This may be provided in one or more referencing systems.
    /// <see href="http://vocab.datex.org/terms#Location"></see></summary>
    let Location = Namespaced_IRI.parse _namespace_name "Location" |> NamespacedName

    /// <summary>
    /// The specification of the destination of a defined route or itinerary which is an area.
    /// <see href="http://vocab.datex.org/terms#AreaDestination"></see></summary>
    let AreaDestination =
        Namespaced_IRI.parse _namespace_name "AreaDestination" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#area"></see>
    /// </summary>
    let area = Namespaced_IRI.parse _namespace_name "area" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#areaDestinationExtension"></see>
    /// </summary>
    let areaDestinationExtension =
        Namespaced_IRI.parse _namespace_name "areaDestinationExtension" |> NamespacedName

    /// <summary>
    /// The specification a destination. This may be either a point location or an area location.
    /// <see href="http://vocab.datex.org/terms#Destination"></see></summary>
    let Destination =
        Namespaced_IRI.parse _namespace_name "Destination" |> NamespacedName

    /// <summary>
    /// Extension class for area used in parking publication extension.
    /// <see href="http://vocab.datex.org/terms#AreaExtended"></see></summary>
    let AreaExtended =
        Namespaced_IRI.parse _namespace_name "AreaExtended" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#namedArea"></see>
    /// </summary>
    let namedArea = Namespaced_IRI.parse _namespace_name "namedArea" |> NamespacedName
    /// <summary>
    /// An area defined by a name and/or in terms of known boundaries, such as country or county boundaries or allocated control area of particular authority. The attributes do not form a union; instead, the smallest intersection forms the resulting area.
    /// <see href="http://vocab.datex.org/terms#NamedArea"></see></summary>
    let NamedArea = Namespaced_IRI.parse _namespace_name "NamedArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#polygonArea"></see>
    /// </summary>
    let polygonArea =
        Namespaced_IRI.parse _namespace_name "polygonArea" |> NamespacedName

    /// <summary>
    /// defines points for a closed polygon-shape describing the area
    /// <see href="http://vocab.datex.org/terms#PolygonArea"></see></summary>
    let PolygonArea =
        Namespaced_IRI.parse _namespace_name "PolygonArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#authorityOperationExtension"></see>
    /// </summary>
    let authorityOperationExtension =
        Namespaced_IRI.parse _namespace_name "authorityOperationExtension" |> NamespacedName

    /// <summary>
    /// Type of authority initiated operation or activity that could disrupt traffic.
    /// <see href="http://vocab.datex.org/terms#authorityOperationType"></see></summary>
    let authorityOperationType =
        Namespaced_IRI.parse _namespace_name "authorityOperationType" |> NamespacedName

    /// <summary>
    /// A measured or calculated value of the flow rate of vehicle axles.
    /// <see href="http://vocab.datex.org/terms#AxleFlowValue"></see></summary>
    let AxleFlowValue =
        Namespaced_IRI.parse _namespace_name "AxleFlowValue" |> NamespacedName

    /// <summary>
    /// A value of the flow rate of vehicle axles expressed in axles per hour.
    /// <see href="http://vocab.datex.org/terms#axleFlowRate"></see></summary>
    let axleFlowRate =
        Namespaced_IRI.parse _namespace_name "axleFlowRate" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#axleFlowValueExtension"></see>
    /// </summary>
    let axleFlowValueExtension =
        Namespaced_IRI.parse _namespace_name "axleFlowValueExtension" |> NamespacedName

    /// <summary>
    /// The spacing details between the axle sets of an individual vehicle numbered from the front to the back of the vehicle.
    /// <see href="http://vocab.datex.org/terms#AxleSpacing"></see></summary>
    let AxleSpacing =
        Namespaced_IRI.parse _namespace_name "AxleSpacing" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#axleSpacing"></see>
    /// </summary>
    let axleSpacing =
        Namespaced_IRI.parse _namespace_name "axleSpacing" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#axleSpacingExtension"></see>
    /// </summary>
    let axleSpacingExtension =
        Namespaced_IRI.parse _namespace_name "axleSpacingExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#axleSpacingSequenceIdentifier"></see>
    /// </summary>
    let axleSpacingSequenceIdentifier =
        Namespaced_IRI.parse _namespace_name "axleSpacingSequenceIdentifier" |> NamespacedName

    /// <summary>
    /// The weight details of a specific axle on the vehicle.
    /// <see href="http://vocab.datex.org/terms#AxleWeight"></see></summary>
    let AxleWeight = Namespaced_IRI.parse _namespace_name "AxleWeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#axlePositionIdentifier"></see>
    /// </summary>
    let axlePositionIdentifier =
        Namespaced_IRI.parse _namespace_name "axlePositionIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#axleWeight"></see>
    /// </summary>
    let axleWeight = Namespaced_IRI.parse _namespace_name "axleWeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#axleWeightExtension"></see>
    /// </summary>
    let axleWeightExtension =
        Namespaced_IRI.parse _namespace_name "axleWeightExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maximumPermittedAxleWeight"></see>
    /// </summary>
    let maximumPermittedAxleWeight =
        Namespaced_IRI.parse _namespace_name "maximumPermittedAxleWeight" |> NamespacedName

    /// <summary>
    /// Data that is either measured or calculated (elaborated) at the same time or over the same time period.
    /// <see href="http://vocab.datex.org/terms#BasicData"></see></summary>
    let BasicData = Namespaced_IRI.parse _namespace_name "BasicData" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementOrCalculatedTimePrecision"></see>
    /// </summary>
    let measurementOrCalculatedTimePrecision =
        Namespaced_IRI.parse _namespace_name "measurementOrCalculatedTimePrecision" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#basicDataExtension"></see>
    /// </summary>
    let basicDataExtension =
        Namespaced_IRI.parse _namespace_name "basicDataExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementOrCalculationPeriod"></see>
    /// </summary>
    let measurementOrCalculationPeriod =
        Namespaced_IRI.parse _namespace_name "measurementOrCalculationPeriod" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementOrCalculationTime"></see>
    /// </summary>
    let measurementOrCalculationTime =
        Namespaced_IRI.parse _namespace_name "measurementOrCalculationTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pertinentLocation"></see>
    /// </summary>
    let pertinentLocation =
        Namespaced_IRI.parse _namespace_name "pertinentLocation" |> NamespacedName

    /// <summary>
    /// One or more physically separate locations. Multiple locations may be related, as in an itinerary (or route), or may be unrelated. It is not for identifying the same physical location using different Location objects for different referencing systems.
    /// <see href="http://vocab.datex.org/terms#GroupOfLocations"></see></summary>
    let GroupOfLocations =
        Namespaced_IRI.parse _namespace_name "GroupOfLocations" |> NamespacedName

    /// <summary>
    /// Provides information on the status of one or more car parks.
    /// <see href="http://vocab.datex.org/terms#CarParks"></see></summary>
    let CarParks = Namespaced_IRI.parse _namespace_name "CarParks" |> NamespacedName

    /// <summary>
    /// The configuration/layout of a car park.
    /// <see href="http://vocab.datex.org/terms#carParkConfiguration"></see></summary>
    let carParkConfiguration =
        Namespaced_IRI.parse _namespace_name "carParkConfiguration" |> NamespacedName

    /// <summary>
    /// The identity of one or a group of car parks.
    /// <see href="http://vocab.datex.org/terms#carParkIdentity"></see></summary>
    let carParkIdentity =
        Namespaced_IRI.parse _namespace_name "carParkIdentity" |> NamespacedName

    /// <summary>
    /// The percentage value of car parking spaces occupied.
    /// <see href="http://vocab.datex.org/terms#carParkOccupancy"></see></summary>
    let carParkOccupancy =
        Namespaced_IRI.parse _namespace_name "carParkOccupancy" |> NamespacedName

    /// <summary>
    /// Indicates the status of one or more specified car parks.
    /// <see href="http://vocab.datex.org/terms#carParkStatus"></see></summary>
    let carParkStatus =
        Namespaced_IRI.parse _namespace_name "carParkStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#carParksExtension"></see>
    /// </summary>
    let carParksExtension =
        Namespaced_IRI.parse _namespace_name "carParksExtension" |> NamespacedName

    /// <summary>
    /// The rate at which vehicles are exiting the car park.
    /// <see href="http://vocab.datex.org/terms#exitRate"></see></summary>
    let exitRate = Namespaced_IRI.parse _namespace_name "exitRate" |> NamespacedName
    /// <summary>
    /// The rate at which vehicles are entering the car park.
    /// <see href="http://vocab.datex.org/terms#fillRate"></see></summary>
    let fillRate = Namespaced_IRI.parse _namespace_name "fillRate" |> NamespacedName

    /// <summary>
    /// Indicates the number of vacant parking spaces available in a specified parking area.
    /// <see href="http://vocab.datex.org/terms#numberOfVacantParkingSpaces"></see></summary>
    let numberOfVacantParkingSpaces =
        Namespaced_IRI.parse _namespace_name "numberOfVacantParkingSpaces" |> NamespacedName

    /// <summary>
    /// Number of currently occupied spaces.
    /// <see href="http://vocab.datex.org/terms#occupiedSpaces"></see></summary>
    let occupiedSpaces =
        Namespaced_IRI.parse _namespace_name "occupiedSpaces" |> NamespacedName

    /// <summary>
    /// The current queuing time (duration) for entering the car park.
    /// <see href="http://vocab.datex.org/terms#queuingTime"></see></summary>
    let queuingTime =
        Namespaced_IRI.parse _namespace_name "queuingTime" |> NamespacedName

    /// <summary>
    /// Total number of car parking spaces.
    /// <see href="http://vocab.datex.org/terms#totalCapacity"></see></summary>
    let totalCapacity =
        Namespaced_IRI.parse _namespace_name "totalCapacity" |> NamespacedName

    /// <summary>
    /// Information about an event which is not on the road, but which may influence the behaviour of drivers and hence the characteristics of the traffic flow.
    /// <see href="http://vocab.datex.org/terms#NonRoadEventInformation"></see></summary>
    let NonRoadEventInformation =
        Namespaced_IRI.parse _namespace_name "NonRoadEventInformation" |> NamespacedName

    /// <summary>
    /// Identification of the supplier's data catalogue in a data exchange context.
    /// <see href="http://vocab.datex.org/terms#CatalogueReference"></see></summary>
    let CatalogueReference =
        Namespaced_IRI.parse _namespace_name "CatalogueReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#catalogueReferenceExtension"></see>
    /// </summary>
    let catalogueReferenceExtension =
        Namespaced_IRI.parse _namespace_name "catalogueReferenceExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#keyCatalogueReference"></see>
    /// </summary>
    let keyCatalogueReference =
        Namespaced_IRI.parse _namespace_name "keyCatalogueReference" |> NamespacedName

    /// <summary>
    /// Contains details of the cause of a record within a situation
    /// <see href="http://vocab.datex.org/terms#Cause"></see></summary>
    let Cause = Namespaced_IRI.parse _namespace_name "Cause" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#causeExtension"></see>
    /// </summary>
    let causeExtension =
        Namespaced_IRI.parse _namespace_name "causeExtension" |> NamespacedName

    /// <summary>
    /// A particular charge for a specified interval belonging a charge band.
    /// <see href="http://vocab.datex.org/terms#Charge"></see></summary>
    let Charge = Namespaced_IRI.parse _namespace_name "Charge" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#charge"></see>
    /// </summary>
    let charge = Namespaced_IRI.parse _namespace_name "charge" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#chargeExtension"></see>
    /// </summary>
    let chargeExtension =
        Namespaced_IRI.parse _namespace_name "chargeExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#chargeInterval"></see>
    /// </summary>
    let chargeInterval =
        Namespaced_IRI.parse _namespace_name "chargeInterval" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#chargeOrderIndex"></see>
    /// </summary>
    let chargeOrderIndex =
        Namespaced_IRI.parse _namespace_name "chargeOrderIndex" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#chargeType"></see>
    /// </summary>
    let chargeType = Namespaced_IRI.parse _namespace_name "chargeType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#chargeTypeDescription"></see>
    /// </summary>
    let chargeTypeDescription =
        Namespaced_IRI.parse _namespace_name "chargeTypeDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maxIterationsOfCharge"></see>
    /// </summary>
    let maxIterationsOfCharge =
        Namespaced_IRI.parse _namespace_name "maxIterationsOfCharge" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#minIterationsOfCharge"></see>
    /// </summary>
    let minIterationsOfCharge =
        Namespaced_IRI.parse _namespace_name "minIterationsOfCharge" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#timePeriodOfDay"></see>
    /// </summary>
    let timePeriodOfDay =
        Namespaced_IRI.parse _namespace_name "timePeriodOfDay" |> NamespacedName

    /// <summary>
    /// Specification of a continuous period of time within a 24 hour period.
    /// <see href="http://vocab.datex.org/terms#TimePeriodOfDay"></see></summary>
    let TimePeriodOfDay =
        Namespaced_IRI.parse _namespace_name "TimePeriodOfDay" |> NamespacedName

    /// <summary>
    /// A charge band in accordance with the specified conditions, possibly up to a maximum duration, during a specified period and for a vehicle of specified characteristics (in case of parking).
    /// <see href="http://vocab.datex.org/terms#ChargeBand"></see></summary>
    let ChargeBand = Namespaced_IRI.parse _namespace_name "ChargeBand" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#version"></see>
    /// </summary>
    let version = Namespaced_IRI.parse _namespace_name "version" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#id"></see>
    /// </summary>
    let id = Namespaced_IRI.parse _namespace_name "id" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#applicableForPeriod"></see>
    /// </summary>
    let applicableForPeriod =
        Namespaced_IRI.parse _namespace_name "applicableForPeriod" |> NamespacedName

    /// <summary>
    /// A continuous or discontinuous period of validity defined by overall bounding start and end times and the possible intersection of valid periods (potentially recurring) with the complement of exception periods (also potentially recurring).
    /// <see href="http://vocab.datex.org/terms#OverallPeriod"></see></summary>
    let OverallPeriod =
        Namespaced_IRI.parse _namespace_name "OverallPeriod" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#applicableForUser"></see>
    /// </summary>
    let applicableForUser =
        Namespaced_IRI.parse _namespace_name "applicableForUser" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#applicableForVehicles"></see>
    /// </summary>
    let applicableForVehicles =
        Namespaced_IRI.parse _namespace_name "applicableForVehicles" |> NamespacedName

    /// <summary>
    /// The characteristics of a vehicle, e.g. lorry of gross weight greater than 30 tonnes.
    /// <see href="http://vocab.datex.org/terms#VehicleCharacteristics"></see></summary>
    let VehicleCharacteristics =
        Namespaced_IRI.parse _namespace_name "VehicleCharacteristics" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#chargeBandExtension"></see>
    /// </summary>
    let chargeBandExtension =
        Namespaced_IRI.parse _namespace_name "chargeBandExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#chargeBandName"></see>
    /// </summary>
    let chargeBandName =
        Namespaced_IRI.parse _namespace_name "chargeBandName" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#chargeCurrency"></see>
    /// </summary>
    let chargeCurrency =
        Namespaced_IRI.parse _namespace_name "chargeCurrency" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maximumDuration"></see>
    /// </summary>
    let maximumDuration =
        Namespaced_IRI.parse _namespace_name "maximumDuration" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingPermit"></see>
    /// </summary>
    let parkingPermit =
        Namespaced_IRI.parse _namespace_name "parkingPermit" |> NamespacedName

    /// <summary>
    /// A permission for parking.
    /// <see href="http://vocab.datex.org/terms#ParkingPermit"></see></summary>
    let ParkingPermit =
        Namespaced_IRI.parse _namespace_name "ParkingPermit" |> NamespacedName

    /// <summary>
    /// Using (a) prior defined charge band(s), identified by its reference.
    /// <see href="http://vocab.datex.org/terms#ChargeBandByReference"></see></summary>
    let ChargeBandByReference =
        Namespaced_IRI.parse _namespace_name "ChargeBandByReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#chargeBandByReferenceExtension"></see>
    /// </summary>
    let chargeBandByReferenceExtension =
        Namespaced_IRI.parse _namespace_name "chargeBandByReferenceExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#chargeBandReference"></see>
    /// </summary>
    let chargeBandReference =
        Namespaced_IRI.parse _namespace_name "chargeBandReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_ChargeBandVersionedReference"></see>
    /// </summary>
    let _ChargeBandVersionedReference =
        Namespaced_IRI.parse _namespace_name "_ChargeBandVersionedReference" |> NamespacedName

    /// <summary>
    /// A free text comment with an optional date/time stamp that can be used by the operator to convey un-coded observations/information.
    /// <see href="http://vocab.datex.org/terms#Comment"></see></summary>
    let Comment = Namespaced_IRI.parse _namespace_name "Comment" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#comment"></see>
    /// </summary>
    let comment = Namespaced_IRI.parse _namespace_name "comment" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#commentDateTime"></see>
    /// </summary>
    let commentDateTime =
        Namespaced_IRI.parse _namespace_name "commentDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#commentExtension"></see>
    /// </summary>
    let commentExtension =
        Namespaced_IRI.parse _namespace_name "commentExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#commentType"></see>
    /// </summary>
    let commentType =
        Namespaced_IRI.parse _namespace_name "commentType" |> NamespacedName

    /// <summary>
    /// A measured or calculated value of the concentration of vehicles on a unit stretch of road in a given direction.
    /// <see href="http://vocab.datex.org/terms#ConcentrationOfVehiclesValue"></see></summary>
    let ConcentrationOfVehiclesValue =
        Namespaced_IRI.parse _namespace_name "ConcentrationOfVehiclesValue" |> NamespacedName

    /// <summary>
    /// A value of traffic density expressed in the number of vehicles per kilometre of road.
    /// <see href="http://vocab.datex.org/terms#concentrationOfVehicles"></see></summary>
    let concentrationOfVehicles =
        Namespaced_IRI.parse _namespace_name "concentrationOfVehicles" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#concentrationOfVehiclesValueExtension"></see>
    /// </summary>
    let concentrationOfVehiclesValueExtension =
        Namespaced_IRI.parse _namespace_name "concentrationOfVehiclesValueExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#conditionsExtension"></see>
    /// </summary>
    let conditionsExtension =
        Namespaced_IRI.parse _namespace_name "conditionsExtension" |> NamespacedName

    /// <summary>
    /// Description of the driving conditions at the specified location.
    /// <see href="http://vocab.datex.org/terms#drivingConditionType"></see></summary>
    let drivingConditionType =
        Namespaced_IRI.parse _namespace_name "drivingConditionType" |> NamespacedName

    /// <summary>
    /// Roadworks involving the construction of new infrastructure.
    /// <see href="http://vocab.datex.org/terms#ConstructionWorks"></see></summary>
    let ConstructionWorks =
        Namespaced_IRI.parse _namespace_name "ConstructionWorks" |> NamespacedName

    /// <summary>
    /// The type of construction work being performed.
    /// <see href="http://vocab.datex.org/terms#constructionWorkType"></see></summary>
    let constructionWorkType =
        Namespaced_IRI.parse _namespace_name "constructionWorkType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#constructionWorksExtension"></see>
    /// </summary>
    let constructionWorksExtension =
        Namespaced_IRI.parse _namespace_name "constructionWorksExtension" |> NamespacedName

    /// <summary>
    /// Highway maintenance, installation and construction activities that may potentially affect traffic operations.
    /// <see href="http://vocab.datex.org/terms#Roadworks"></see></summary>
    let Roadworks = Namespaced_IRI.parse _namespace_name "Roadworks" |> NamespacedName
    /// <summary>
    /// Address and contact information about some person, service or the parking site, provided in detail or via reference.
    /// <see href="http://vocab.datex.org/terms#Contact"></see></summary>
    let Contact = Namespaced_IRI.parse _namespace_name "Contact" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#contactExtension"></see>
    /// </summary>
    let contactExtension =
        Namespaced_IRI.parse _namespace_name "contactExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#contactNotDefined"></see>
    /// </summary>
    let contactNotDefined =
        Namespaced_IRI.parse _namespace_name "contactNotDefined" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#contactUnknown"></see>
    /// </summary>
    let contactUnknown =
        Namespaced_IRI.parse _namespace_name "contactUnknown" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#validityOfContact"></see>
    /// </summary>
    let validityOfContact =
        Namespaced_IRI.parse _namespace_name "validityOfContact" |> NamespacedName

    /// <summary>
    /// Contact information that is addressed via a reference.
    /// <see href="http://vocab.datex.org/terms#ContactByReference"></see></summary>
    let ContactByReference =
        Namespaced_IRI.parse _namespace_name "ContactByReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#contactByReferenceExtension"></see>
    /// </summary>
    let contactByReferenceExtension =
        Namespaced_IRI.parse _namespace_name "contactByReferenceExtension" |> NamespacedName

    /// <summary>
    /// Contact information provided by a reference.
    /// <see href="http://vocab.datex.org/terms#contactReference"></see></summary>
    let contactReference =
        Namespaced_IRI.parse _namespace_name "contactReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_ContactDetailsVersionedReference"></see>
    /// </summary>
    let _ContactDetailsVersionedReference =
        Namespaced_IRI.parse _namespace_name "_ContactDetailsVersionedReference" |> NamespacedName

    /// <summary>
    /// Details for some person, service or the parking site itself, especially address information.
    /// <see href="http://vocab.datex.org/terms#ContactDetails"></see></summary>
    let ContactDetails =
        Namespaced_IRI.parse _namespace_name "ContactDetails" |> NamespacedName

    /// <summary>
    /// Specifies if the availability is 24 hours a day. If omitted, this information is unknown or heterogeneous.
    /// <see href="http://vocab.datex.org/terms#available24hours"></see></summary>
    let available24hours =
        Namespaced_IRI.parse _namespace_name "available24hours" |> NamespacedName

    /// <summary>
    /// Complete address of the contact. Alternatively use the separate fields to describe the address.
    /// <see href="http://vocab.datex.org/terms#contactDetailsAddress"></see></summary>
    let contactDetailsAddress =
        Namespaced_IRI.parse _namespace_name "contactDetailsAddress" |> NamespacedName

    /// <summary>
    /// City of the contact.
    /// <see href="http://vocab.datex.org/terms#contactDetailsCity"></see></summary>
    let contactDetailsCity =
        Namespaced_IRI.parse _namespace_name "contactDetailsCity" |> NamespacedName

    /// <summary>
    /// E-Mail address of the contact.
    /// <see href="http://vocab.datex.org/terms#contactDetailsEMail"></see></summary>
    let contactDetailsEMail =
        Namespaced_IRI.parse _namespace_name "contactDetailsEMail" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#contactDetailsExtension"></see>
    /// </summary>
    let contactDetailsExtension =
        Namespaced_IRI.parse _namespace_name "contactDetailsExtension" |> NamespacedName

    /// <summary>
    /// Fax of the contact.
    /// <see href="http://vocab.datex.org/terms#contactDetailsFax"></see></summary>
    let contactDetailsFax =
        Namespaced_IRI.parse _namespace_name "contactDetailsFax" |> NamespacedName

    /// <summary>
    /// House number of the contact. Supports a multiplicity up to two, to specify lower and upper numbers.
    /// <see href="http://vocab.datex.org/terms#contactDetailsHouseNumber"></see></summary>
    let contactDetailsHouseNumber =
        Namespaced_IRI.parse _namespace_name "contactDetailsHouseNumber" |> NamespacedName

    /// <summary>
    /// Language(s) this contact is able to speak resp. understand.
    /// <see href="http://vocab.datex.org/terms#contactDetailsLanguage"></see></summary>
    let contactDetailsLanguage =
        Namespaced_IRI.parse _namespace_name "contactDetailsLanguage" |> NamespacedName

    /// <summary>
    /// Url to define a logo of this contact.
    /// <see href="http://vocab.datex.org/terms#contactDetailsLogoUrl"></see></summary>
    let contactDetailsLogoUrl =
        Namespaced_IRI.parse _namespace_name "contactDetailsLogoUrl" |> NamespacedName

    /// <summary>
    /// Additional information relating to the contact.
    /// <see href="http://vocab.datex.org/terms#contactDetailsMoreInfo"></see></summary>
    let contactDetailsMoreInfo =
        Namespaced_IRI.parse _namespace_name "contactDetailsMoreInfo" |> NamespacedName

    /// <summary>
    /// Information if the contact in question is a private or public institution.
    /// <see href="http://vocab.datex.org/terms#contactDetailsOwnership"></see></summary>
    let contactDetailsOwnership =
        Namespaced_IRI.parse _namespace_name "contactDetailsOwnership" |> NamespacedName

    /// <summary>
    /// Postcode of the contact.
    /// <see href="http://vocab.datex.org/terms#contactDetailsPostcode"></see></summary>
    let contactDetailsPostcode =
        Namespaced_IRI.parse _namespace_name "contactDetailsPostcode" |> NamespacedName

    /// <summary>
    /// Specification of what service or equipment the contact is responsible for.
    /// <see href="http://vocab.datex.org/terms#contactDetailsResponsibility"></see></summary>
    let contactDetailsResponsibility =
        Namespaced_IRI.parse _namespace_name "contactDetailsResponsibility" |> NamespacedName

    /// <summary>
    /// Street of the contact.
    /// <see href="http://vocab.datex.org/terms#contactDetailsStreet"></see></summary>
    let contactDetailsStreet =
        Namespaced_IRI.parse _namespace_name "contactDetailsStreet" |> NamespacedName

    /// <summary>
    /// Telephone Number of contact.
    /// <see href="http://vocab.datex.org/terms#contactDetailsTelephoneNumber"></see></summary>
    let contactDetailsTelephoneNumber =
        Namespaced_IRI.parse _namespace_name "contactDetailsTelephoneNumber" |> NamespacedName

    /// <summary>
    /// Name of the organisation or service. Do not use this attribute in combination with role "parkingSiteAddress".
    /// <see href="http://vocab.datex.org/terms#contactOrganisationName"></see></summary>
    let contactOrganisationName =
        Namespaced_IRI.parse _namespace_name "contactOrganisationName" |> NamespacedName

    /// <summary>
    /// First name of the contact person.
    /// <see href="http://vocab.datex.org/terms#contactPersonFirstName"></see></summary>
    let contactPersonFirstName =
        Namespaced_IRI.parse _namespace_name "contactPersonFirstName" |> NamespacedName

    /// <summary>
    /// Name of the contact person.
    /// <see href="http://vocab.datex.org/terms#contactPersonName"></see></summary>
    let contactPersonName =
        Namespaced_IRI.parse _namespace_name "contactPersonName" |> NamespacedName

    /// <summary>
    /// The position of the contact person.
    /// <see href="http://vocab.datex.org/terms#contactPersonPosition"></see></summary>
    let contactPersonPosition =
        Namespaced_IRI.parse _namespace_name "contactPersonPosition" |> NamespacedName

    /// <summary>
    /// ISO 3166-1 two character country code.
    /// <see href="http://vocab.datex.org/terms#country"></see></summary>
    let country = Namespaced_IRI.parse _namespace_name "country" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#groupOfLocations"></see>
    /// </summary>
    let groupOfLocations =
        Namespaced_IRI.parse _namespace_name "groupOfLocations" |> NamespacedName

    /// <summary>
    /// Indication, whether the contact accepted publishing its contact information.
    /// <see href="http://vocab.datex.org/terms#publishingAgreement"></see></summary>
    let publishingAgreement =
        Namespaced_IRI.parse _namespace_name "publishingAgreement" |> NamespacedName

    /// <summary>
    /// A Uniform Resource Locator (URL) address pointing to a resource available on the Internet from where further relevant information may be obtained.
    /// <see href="http://vocab.datex.org/terms#urlLinkAddress"></see></summary>
    let urlLinkAddress =
        Namespaced_IRI.parse _namespace_name "urlLinkAddress" |> NamespacedName

    /// <summary>
    /// The DATEX II logical model comprising exchange, content payload and management sub-models.
    /// <see href="http://vocab.datex.org/terms#D2LogicalModel"></see></summary>
    let D2LogicalModel =
        Namespaced_IRI.parse _namespace_name "D2LogicalModel" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#modelBaseVersion"></see>
    /// </summary>
    let modelBaseVersion =
        Namespaced_IRI.parse _namespace_name "modelBaseVersion" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#d2LogicalModelExtension"></see>
    /// </summary>
    let d2LogicalModelExtension =
        Namespaced_IRI.parse _namespace_name "d2LogicalModelExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#exchange"></see>
    /// </summary>
    let exchange = Namespaced_IRI.parse _namespace_name "exchange" |> NamespacedName
    /// <summary>
    /// Details associated with the management of the exchange between the supplier and the client.
    /// <see href="http://vocab.datex.org/terms#Exchange"></see></summary>
    let Exchange = Namespaced_IRI.parse _namespace_name "Exchange" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#payloadPublication"></see>
    /// </summary>
    let payloadPublication =
        Namespaced_IRI.parse _namespace_name "payloadPublication" |> NamespacedName

    /// <summary>
    /// A payload publication of traffic related information or associated management information created at a specific point in time that can be exchanged via a DATEX II interface.
    /// <see href="http://vocab.datex.org/terms#PayloadPublication"></see></summary>
    let PayloadPublication =
        Namespaced_IRI.parse _namespace_name "PayloadPublication" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#supplierCalculatedDataQuality"></see>
    /// </summary>
    let supplierCalculatedDataQuality =
        Namespaced_IRI.parse _namespace_name "supplierCalculatedDataQuality" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#numberOfInputValuesUsed"></see>
    /// </summary>
    let numberOfInputValuesUsed =
        Namespaced_IRI.parse _namespace_name "numberOfInputValuesUsed" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#smoothingFactor"></see>
    /// </summary>
    let smoothingFactor =
        Namespaced_IRI.parse _namespace_name "smoothingFactor" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#accuracy"></see>
    /// </summary>
    let accuracy = Namespaced_IRI.parse _namespace_name "accuracy" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#standardDeviation"></see>
    /// </summary>
    let standardDeviation =
        Namespaced_IRI.parse _namespace_name "standardDeviation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#dataError"></see>
    /// </summary>
    let dataError = Namespaced_IRI.parse _namespace_name "dataError" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#dataValueExtension"></see>
    /// </summary>
    let dataValueExtension =
        Namespaced_IRI.parse _namespace_name "dataValueExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#reasonForDataError"></see>
    /// </summary>
    let reasonForDataError =
        Namespaced_IRI.parse _namespace_name "reasonForDataError" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#computationalMethod"></see>
    /// </summary>
    let computationalMethod =
        Namespaced_IRI.parse _namespace_name "computationalMethod" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#numberOfIncompleteInputs"></see>
    /// </summary>
    let numberOfIncompleteInputs =
        Namespaced_IRI.parse _namespace_name "numberOfIncompleteInputs" |> NamespacedName

    /// <summary>
    /// A measured or calculated value of an instance in time.
    /// <see href="http://vocab.datex.org/terms#DateTimeValue"></see></summary>
    let DateTimeValue =
        Namespaced_IRI.parse _namespace_name "DateTimeValue" |> NamespacedName

    /// <summary>
    /// A time stamp defining an instance in time.
    /// <see href="http://vocab.datex.org/terms#dateTime"></see></summary>
    let dateTime = Namespaced_IRI.parse _namespace_name "dateTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#dateTimeValueExtension"></see>
    /// </summary>
    let dateTimeValueExtension =
        Namespaced_IRI.parse _namespace_name "dateTimeValueExtension" |> NamespacedName

    /// <summary>
    /// Specification of periods defined by the intersection of days, weeks and months.
    /// <see href="http://vocab.datex.org/terms#DayWeekMonth"></see></summary>
    let DayWeekMonth =
        Namespaced_IRI.parse _namespace_name "DayWeekMonth" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#applicableDay"></see>
    /// </summary>
    let applicableDay =
        Namespaced_IRI.parse _namespace_name "applicableDay" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#applicableMonth"></see>
    /// </summary>
    let applicableMonth =
        Namespaced_IRI.parse _namespace_name "applicableMonth" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#applicableWeek"></see>
    /// </summary>
    let applicableWeek =
        Namespaced_IRI.parse _namespace_name "applicableWeek" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#dayWeekMonthExtension"></see>
    /// </summary>
    let dayWeekMonthExtension =
        Namespaced_IRI.parse _namespace_name "dayWeekMonthExtension" |> NamespacedName

    /// <summary>
    /// Reference to an access of any type (vehicles, pedestrian, ...).
    /// <see href="http://vocab.datex.org/terms#DedicatedAccess"></see></summary>
    let DedicatedAccess =
        Namespaced_IRI.parse _namespace_name "DedicatedAccess" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#dedicatedAccess"></see>
    /// </summary>
    let dedicatedAccess =
        Namespaced_IRI.parse _namespace_name "dedicatedAccess" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_ParkingAccessReference"></see>
    /// </summary>
    let _ParkingAccessReference =
        Namespaced_IRI.parse _namespace_name "_ParkingAccessReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#dedicatedAccessExtension"></see>
    /// </summary>
    let dedicatedAccessExtension =
        Namespaced_IRI.parse _namespace_name "dedicatedAccessExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#distanceFromParkingSpace"></see>
    /// </summary>
    let distanceFromParkingSpace =
        Namespaced_IRI.parse _namespace_name "distanceFromParkingSpace" |> NamespacedName

    /// <summary>
    /// The details of the delays being caused by the situation element defined in the situation record. It is recommended to only use one of the optional attributes to avoid confusion.
    /// <see href="http://vocab.datex.org/terms#Delays"></see></summary>
    let Delays = Namespaced_IRI.parse _namespace_name "Delays" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#delayBand"></see>
    /// </summary>
    let delayBand = Namespaced_IRI.parse _namespace_name "delayBand" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#delayTimeValue"></see>
    /// </summary>
    let delayTimeValue =
        Namespaced_IRI.parse _namespace_name "delayTimeValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#delaysExtension"></see>
    /// </summary>
    let delaysExtension =
        Namespaced_IRI.parse _namespace_name "delaysExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#delaysType"></see>
    /// </summary>
    let delaysType = Namespaced_IRI.parse _namespace_name "delaysType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#destinationExtension"></see>
    /// </summary>
    let destinationExtension =
        Namespaced_IRI.parse _namespace_name "destinationExtension" |> NamespacedName

    /// <summary>
    /// A component that provides dimension information. The product of width and height must not be necessarily be the square footage (e.g. in multi-storey buildings or when some zones are not part of the square footage).
    /// <see href="http://vocab.datex.org/terms#Dimension"></see></summary>
    let Dimension = Namespaced_IRI.parse _namespace_name "Dimension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#dimensionExtension"></see>
    /// </summary>
    let dimensionExtension =
        Namespaced_IRI.parse _namespace_name "dimensionExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#dimensionHeight"></see>
    /// </summary>
    let dimensionHeight =
        Namespaced_IRI.parse _namespace_name "dimensionHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#dimensionLength"></see>
    /// </summary>
    let dimensionLength =
        Namespaced_IRI.parse _namespace_name "dimensionLength" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#dimensionUsableArea"></see>
    /// </summary>
    let dimensionUsableArea =
        Namespaced_IRI.parse _namespace_name "dimensionUsableArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#dimensionWidth"></see>
    /// </summary>
    let dimensionWidth =
        Namespaced_IRI.parse _namespace_name "dimensionWidth" |> NamespacedName

    /// <summary>
    /// A measured or calculated value of direction as a bearing.
    /// <see href="http://vocab.datex.org/terms#DirectionBearingValue"></see></summary>
    let DirectionBearingValue =
        Namespaced_IRI.parse _namespace_name "DirectionBearingValue" |> NamespacedName

    /// <summary>
    /// A value of direction expressed in terms of a bearing measured in whole degrees. Unless otherwise specified the reference direction corresponding to 0 degrees is North.
    /// <see href="http://vocab.datex.org/terms#directionBearing"></see></summary>
    let directionBearing =
        Namespaced_IRI.parse _namespace_name "directionBearing" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#directionBearingValueExtension"></see>
    /// </summary>
    let directionBearingValueExtension =
        Namespaced_IRI.parse _namespace_name "directionBearingValueExtension" |> NamespacedName

    /// <summary>
    /// A measured or calculated value of direction as a point of the compass.
    /// <see href="http://vocab.datex.org/terms#DirectionCompassValue"></see></summary>
    let DirectionCompassValue =
        Namespaced_IRI.parse _namespace_name "DirectionCompassValue" |> NamespacedName

    /// <summary>
    /// A value of direction expressed in terms of points of the compass.
    /// <see href="http://vocab.datex.org/terms#directionCompass"></see></summary>
    let directionCompass =
        Namespaced_IRI.parse _namespace_name "directionCompass" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#directionCompassValueExtension"></see>
    /// </summary>
    let directionCompassValueExtension =
        Namespaced_IRI.parse _namespace_name "directionCompassValueExtension" |> NamespacedName

    /// <summary>
    /// Distance of a point along a linear element either measured from the start node or a defined referent on that linear element, where the start node is relative to the element definition rather than the direction of traffic flow.
    /// <see href="http://vocab.datex.org/terms#DistanceAlongLinearElement"></see></summary>
    let DistanceAlongLinearElement =
        Namespaced_IRI.parse _namespace_name "DistanceAlongLinearElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#distanceAlongLinearElementExtension"></see>
    /// </summary>
    let distanceAlongLinearElementExtension =
        Namespaced_IRI.parse _namespace_name "distanceAlongLinearElementExtension" |> NamespacedName

    /// <summary>
    /// Distance of a point along a linear element measured from a "from referent" on the linear element, in the sense relative to the linear element definition rather than the direction of traffic flow or optionally towards a "towards referent".
    /// <see href="http://vocab.datex.org/terms#DistanceFromLinearElementReferent"></see></summary>
    let DistanceFromLinearElementReferent =
        Namespaced_IRI.parse _namespace_name "DistanceFromLinearElementReferent" |> NamespacedName

    /// <summary>
    /// A measure of distance along a linear element.
    /// <see href="http://vocab.datex.org/terms#distanceAlong"></see></summary>
    let distanceAlong =
        Namespaced_IRI.parse _namespace_name "distanceAlong" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#distanceFromLinearElementReferentExtension"></see>
    /// </summary>
    let distanceFromLinearElementReferentExtension =
        Namespaced_IRI.parse _namespace_name "distanceFromLinearElementReferentExtension" |> NamespacedName

    /// <summary>
    /// A known location along the linear element from which the distanceAlong is measured, termed the "fromReferent" in ISO 19148.
    /// <see href="http://vocab.datex.org/terms#fromReferent"></see></summary>
    let fromReferent =
        Namespaced_IRI.parse _namespace_name "fromReferent" |> NamespacedName

    /// <summary>
    /// A referent on a linear object that has a known location such as a node, a reference marker (e.g. a markerpost), an intersection etc.
    /// <see href="http://vocab.datex.org/terms#Referent"></see></summary>
    let Referent = Namespaced_IRI.parse _namespace_name "Referent" |> NamespacedName

    /// <summary>
    /// A known location along the linear element towards which the distanceAlong is measured, termed the "towardsReferent" in ISO 19148.
    /// <see href="http://vocab.datex.org/terms#towardsReferent"></see></summary>
    let towardsReferent =
        Namespaced_IRI.parse _namespace_name "towardsReferent" |> NamespacedName

    /// <summary>
    /// Distance of a point along a linear element measured from the start node of the linear element, where start node is relative to the element definition rather than the direction of traffic flow.
    /// <see href="http://vocab.datex.org/terms#DistanceFromLinearElementStart"></see></summary>
    let DistanceFromLinearElementStart =
        Namespaced_IRI.parse _namespace_name "DistanceFromLinearElementStart" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#distanceFromLinearElementStartExtension"></see>
    /// </summary>
    let distanceFromLinearElementStartExtension =
        Namespaced_IRI.parse _namespace_name "distanceFromLinearElementStartExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#disturbanceActivityExtension"></see>
    /// </summary>
    let disturbanceActivityExtension =
        Namespaced_IRI.parse _namespace_name "disturbanceActivityExtension" |> NamespacedName

    /// <summary>
    /// Includes all situations of a public disorder type or of an alert type, with potential to disrupt traffic.
    /// <see href="http://vocab.datex.org/terms#disturbanceActivityType"></see></summary>
    let disturbanceActivityType =
        Namespaced_IRI.parse _namespace_name "disturbanceActivityType" |> NamespacedName

    /// <summary>
    /// A measured or calculated value of a period of time.
    /// <see href="http://vocab.datex.org/terms#DurationValue"></see></summary>
    let DurationValue =
        Namespaced_IRI.parse _namespace_name "DurationValue" |> NamespacedName

    /// <summary>
    /// A period of time expressed in seconds.
    /// <see href="http://vocab.datex.org/terms#duration"></see></summary>
    let duration = Namespaced_IRI.parse _namespace_name "duration" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#durationValueExtension"></see>
    /// </summary>
    let durationValueExtension =
        Namespaced_IRI.parse _namespace_name "durationValueExtension" |> NamespacedName

    /// <summary>
    /// An instance of data which is derived/computed from one or more measurements over a period of time. It may be a current value or a forecast value predicted from historical measurements.
    /// <see href="http://vocab.datex.org/terms#ElaboratedData"></see></summary>
    let ElaboratedData =
        Namespaced_IRI.parse _namespace_name "ElaboratedData" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#basicData"></see>
    /// </summary>
    let basicData = Namespaced_IRI.parse _namespace_name "basicData" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#elaboratedDataExtension"></see>
    /// </summary>
    let elaboratedDataExtension =
        Namespaced_IRI.parse _namespace_name "elaboratedDataExtension" |> NamespacedName

    /// <summary>
    /// The type of fault which is being reported for the specified elaborated data.
    /// <see href="http://vocab.datex.org/terms#elaboratedDataFault"></see></summary>
    let elaboratedDataFault =
        Namespaced_IRI.parse _namespace_name "elaboratedDataFault" |> NamespacedName

    /// <summary>
    /// Details of a fault which is being reported for the related elaborated data.
    /// <see href="http://vocab.datex.org/terms#ElaboratedDataFault"></see></summary>
    let ElaboratedDataFault =
        Namespaced_IRI.parse _namespace_name "ElaboratedDataFault" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#forecast"></see>
    /// </summary>
    let forecast = Namespaced_IRI.parse _namespace_name "forecast" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#source"></see>
    /// </summary>
    let source = Namespaced_IRI.parse _namespace_name "source" |> NamespacedName
    /// <summary>
    /// Details of the source from which the information was obtained.
    /// <see href="http://vocab.datex.org/terms#Source"></see></summary>
    let Source = Namespaced_IRI.parse _namespace_name "Source" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#validity"></see>
    /// </summary>
    let validity = Namespaced_IRI.parse _namespace_name "validity" |> NamespacedName
    /// <summary>
    /// Specification of validity, either explicitly or by a validity time period specification which may be discontinuous.
    /// <see href="http://vocab.datex.org/terms#Validity"></see></summary>
    let Validity = Namespaced_IRI.parse _namespace_name "Validity" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#elaboratedDataFaultExtension"></see>
    /// </summary>
    let elaboratedDataFaultExtension =
        Namespaced_IRI.parse _namespace_name "elaboratedDataFaultExtension" |> NamespacedName

    /// <summary>
    /// Information about a fault relating to a specific piece of equipment or process.
    /// <see href="http://vocab.datex.org/terms#Fault"></see></summary>
    let Fault = Namespaced_IRI.parse _namespace_name "Fault" |> NamespacedName

    /// <summary>
    /// A publication containing one or more elaborated data sets.
    /// <see href="http://vocab.datex.org/terms#ElaboratedDataPublication"></see></summary>
    let ElaboratedDataPublication =
        Namespaced_IRI.parse _namespace_name "ElaboratedDataPublication" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#elaboratedData"></see>
    /// </summary>
    let elaboratedData =
        Namespaced_IRI.parse _namespace_name "elaboratedData" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#elaboratedDataPublicationExtension"></see>
    /// </summary>
    let elaboratedDataPublicationExtension =
        Namespaced_IRI.parse _namespace_name "elaboratedDataPublicationExtension" |> NamespacedName

    /// <summary>
    /// The default value for the publication of whether the elaborated data is a forecast (true = forecast).
    /// <see href="http://vocab.datex.org/terms#forecastDefault"></see></summary>
    let forecastDefault =
        Namespaced_IRI.parse _namespace_name "forecastDefault" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#headerInformation"></see>
    /// </summary>
    let headerInformation =
        Namespaced_IRI.parse _namespace_name "headerInformation" |> NamespacedName

    /// <summary>
    /// Management information relating to the data contained within a publication.
    /// <see href="http://vocab.datex.org/terms#HeaderInformation"></see></summary>
    let HeaderInformation =
        Namespaced_IRI.parse _namespace_name "HeaderInformation" |> NamespacedName

    /// <summary>
    /// The default value for the publication of the time elapsed between the beginning and the end of the sampling or measurement period. This item may differ from the unit attribute; e.g. an hourly flow can be estimated from a 5-minute measurement period.
    /// <see href="http://vocab.datex.org/terms#periodDefault"></see></summary>
    let periodDefault =
        Namespaced_IRI.parse _namespace_name "periodDefault" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#referenceSettings"></see>
    /// </summary>
    let referenceSettings =
        Namespaced_IRI.parse _namespace_name "referenceSettings" |> NamespacedName

    /// <summary>
    /// Specification of the default value for traffic status on a group of predefined locations on the road network. Only when traffic status differs from this value at a location in the group need a value be sent.
    /// <see href="http://vocab.datex.org/terms#ReferenceSettings"></see></summary>
    let ReferenceSettings =
        Namespaced_IRI.parse _namespace_name "ReferenceSettings" |> NamespacedName

    /// <summary>
    /// The default for the publication of the time at which the values have been computed/derived.
    /// <see href="http://vocab.datex.org/terms#timeDefault"></see></summary>
    let timeDefault =
        Namespaced_IRI.parse _namespace_name "timeDefault" |> NamespacedName

    /// <summary>
    /// Additional information for the equipment 'electricChargingStation'. This component refers to the number of charging stations specified in the attribute 'numberOfEquipmentOrServiceFacilities'.
    /// <see href="http://vocab.datex.org/terms#ElectricCharging"></see></summary>
    let ElectricCharging =
        Namespaced_IRI.parse _namespace_name "ElectricCharging" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#chargingStationConnectorType"></see>
    /// </summary>
    let chargingStationConnectorType =
        Namespaced_IRI.parse _namespace_name "chargingStationConnectorType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#chargingStationModelType"></see>
    /// </summary>
    let chargingStationModelType =
        Namespaced_IRI.parse _namespace_name "chargingStationModelType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#chargingStationUsageType"></see>
    /// </summary>
    let chargingStationUsageType =
        Namespaced_IRI.parse _namespace_name "chargingStationUsageType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#electricChargingExtension"></see>
    /// </summary>
    let electricChargingExtension =
        Namespaced_IRI.parse _namespace_name "electricChargingExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maximumCurrent"></see>
    /// </summary>
    let maximumCurrent =
        Namespaced_IRI.parse _namespace_name "maximumCurrent" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#numberOfChargingPoints"></see>
    /// </summary>
    let numberOfChargingPoints =
        Namespaced_IRI.parse _namespace_name "numberOfChargingPoints" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#voltage"></see>
    /// </summary>
    let voltage = Namespaced_IRI.parse _namespace_name "voltage" |> NamespacedName
    /// <summary>
    /// The depth of flooding or of snow on the road.
    /// <see href="http://vocab.datex.org/terms#depth"></see></summary>
    let depth = Namespaced_IRI.parse _namespace_name "depth" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#environmentalObstructionExtension"></see>
    /// </summary>
    let environmentalObstructionExtension =
        Namespaced_IRI.parse _namespace_name "environmentalObstructionExtension" |> NamespacedName

    /// <summary>
    /// Characterization of an obstruction on the road resulting from an environmental cause.
    /// <see href="http://vocab.datex.org/terms#environmentalObstructionType"></see></summary>
    let environmentalObstructionType =
        Namespaced_IRI.parse _namespace_name "environmentalObstructionType" |> NamespacedName

    /// <summary>
    /// One type of equipment, that is available on the parking site.
    /// <see href="http://vocab.datex.org/terms#Equipment"></see></summary>
    let Equipment = Namespaced_IRI.parse _namespace_name "Equipment" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#electricCharging"></see>
    /// </summary>
    let electricCharging =
        Namespaced_IRI.parse _namespace_name "electricCharging" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#equipmentExtension"></see>
    /// </summary>
    let equipmentExtension =
        Namespaced_IRI.parse _namespace_name "equipmentExtension" |> NamespacedName

    /// <summary>
    /// One type of equipment, that is available on the parking site.
    /// <see href="http://vocab.datex.org/terms#equipmentType"></see></summary>
    let equipmentType =
        Namespaced_IRI.parse _namespace_name "equipmentType" |> NamespacedName

    /// <summary>
    /// One type of equipment or additional service facility that is available at the parking site, parking space or group of parking spaces.
    /// <see href="http://vocab.datex.org/terms#ParkingEquipmentOrServiceFacility"></see></summary>
    let ParkingEquipmentOrServiceFacility =
        Namespaced_IRI.parse _namespace_name "ParkingEquipmentOrServiceFacility" |> NamespacedName

    /// <summary>
    /// Equipment or system which is faulty, malfunctioning or not in a fully operational state that may be of interest or concern to road operators and road users.
    /// <see href="http://vocab.datex.org/terms#EquipmentOrSystemFault"></see></summary>
    let EquipmentOrSystemFault =
        Namespaced_IRI.parse _namespace_name "EquipmentOrSystemFault" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#equipmentOrSystemFaultExtension"></see>
    /// </summary>
    let equipmentOrSystemFaultExtension =
        Namespaced_IRI.parse _namespace_name "equipmentOrSystemFaultExtension" |> NamespacedName

    /// <summary>
    /// Failure, malfunction or non operational condition of equipment or system.
    /// <see href="http://vocab.datex.org/terms#equipmentOrSystemFaultType"></see></summary>
    let equipmentOrSystemFaultType =
        Namespaced_IRI.parse _namespace_name "equipmentOrSystemFaultType" |> NamespacedName

    /// <summary>
    /// The type of equipment or system which is faulty, malfunctioning or not in a fully operational state.
    /// <see href="http://vocab.datex.org/terms#faultyEquipmentOrSystemType"></see></summary>
    let faultyEquipmentOrSystemType =
        Namespaced_IRI.parse _namespace_name "faultyEquipmentOrSystemType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#catalogueReference"></see>
    /// </summary>
    let catalogueReference =
        Namespaced_IRI.parse _namespace_name "catalogueReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#changedFlag"></see>
    /// </summary>
    let changedFlag =
        Namespaced_IRI.parse _namespace_name "changedFlag" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#clientIdentification"></see>
    /// </summary>
    let clientIdentification =
        Namespaced_IRI.parse _namespace_name "clientIdentification" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#deliveryBreak"></see>
    /// </summary>
    let deliveryBreak =
        Namespaced_IRI.parse _namespace_name "deliveryBreak" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#denyReason"></see>
    /// </summary>
    let denyReason = Namespaced_IRI.parse _namespace_name "denyReason" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#exchangeExtension"></see>
    /// </summary>
    let exchangeExtension =
        Namespaced_IRI.parse _namespace_name "exchangeExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#filterReference"></see>
    /// </summary>
    let filterReference =
        Namespaced_IRI.parse _namespace_name "filterReference" |> NamespacedName

    /// <summary>
    /// Details of a supplier's filter in a data exchange context.
    /// <see href="http://vocab.datex.org/terms#FilterReference"></see></summary>
    let FilterReference =
        Namespaced_IRI.parse _namespace_name "FilterReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#historicalStartDate"></see>
    /// </summary>
    let historicalStartDate =
        Namespaced_IRI.parse _namespace_name "historicalStartDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#historicalStopDate"></see>
    /// </summary>
    let historicalStopDate =
        Namespaced_IRI.parse _namespace_name "historicalStopDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#keepAlive"></see>
    /// </summary>
    let keepAlive = Namespaced_IRI.parse _namespace_name "keepAlive" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#requestType"></see>
    /// </summary>
    let requestType =
        Namespaced_IRI.parse _namespace_name "requestType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#response"></see>
    /// </summary>
    let response = Namespaced_IRI.parse _namespace_name "response" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#subscription"></see>
    /// </summary>
    let subscription =
        Namespaced_IRI.parse _namespace_name "subscription" |> NamespacedName

    /// <summary>
    /// This item contains all information relating to a customer subscription.
    /// <see href="http://vocab.datex.org/terms#Subscription"></see></summary>
    let Subscription =
        Namespaced_IRI.parse _namespace_name "Subscription" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#subscriptionReference"></see>
    /// </summary>
    let subscriptionReference =
        Namespaced_IRI.parse _namespace_name "subscriptionReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#supplierIdentification"></see>
    /// </summary>
    let supplierIdentification =
        Namespaced_IRI.parse _namespace_name "supplierIdentification" |> NamespacedName

    /// <summary>
    /// An identifier/name whose range is specific to the particular country.
    /// <see href="http://vocab.datex.org/terms#InternationalIdentifier"></see></summary>
    let InternationalIdentifier =
        Namespaced_IRI.parse _namespace_name "InternationalIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#target"></see>
    /// </summary>
    let target = Namespaced_IRI.parse _namespace_name "target" |> NamespacedName
    /// <summary>
    /// The details of a DATEX II target client.
    /// <see href="http://vocab.datex.org/terms#Target"></see></summary>
    let Target = Namespaced_IRI.parse _namespace_name "Target" |> NamespacedName

    /// <summary>
    /// A location defined by reference to an external/other referencing system.
    /// <see href="http://vocab.datex.org/terms#ExternalReferencing"></see></summary>
    let ExternalReferencing =
        Namespaced_IRI.parse _namespace_name "ExternalReferencing" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#externalLocationCode"></see>
    /// </summary>
    let externalLocationCode =
        Namespaced_IRI.parse _namespace_name "externalLocationCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#externalReferencingExtension"></see>
    /// </summary>
    let externalReferencingExtension =
        Namespaced_IRI.parse _namespace_name "externalReferencingExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#externalReferencingSystem"></see>
    /// </summary>
    let externalReferencingSystem =
        Namespaced_IRI.parse _namespace_name "externalReferencingSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#faultCreationTime"></see>
    /// </summary>
    let faultCreationTime =
        Namespaced_IRI.parse _namespace_name "faultCreationTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#faultDescription"></see>
    /// </summary>
    let faultDescription =
        Namespaced_IRI.parse _namespace_name "faultDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#faultExtension"></see>
    /// </summary>
    let faultExtension =
        Namespaced_IRI.parse _namespace_name "faultExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#faultIdentifier"></see>
    /// </summary>
    let faultIdentifier =
        Namespaced_IRI.parse _namespace_name "faultIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#faultLastUpdateTime"></see>
    /// </summary>
    let faultLastUpdateTime =
        Namespaced_IRI.parse _namespace_name "faultLastUpdateTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#faultSeverity"></see>
    /// </summary>
    let faultSeverity =
        Namespaced_IRI.parse _namespace_name "faultSeverity" |> NamespacedName

    /// <summary>
    /// Filter indicators management information.
    /// <see href="http://vocab.datex.org/terms#FilterExitManagement"></see></summary>
    let FilterExitManagement =
        Namespaced_IRI.parse _namespace_name "FilterExitManagement" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#filterEnd"></see>
    /// </summary>
    let filterEnd = Namespaced_IRI.parse _namespace_name "filterEnd" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#filterExitManagementExtension"></see>
    /// </summary>
    let filterExitManagementExtension =
        Namespaced_IRI.parse _namespace_name "filterExitManagementExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#filterOutOfRange"></see>
    /// </summary>
    let filterOutOfRange =
        Namespaced_IRI.parse _namespace_name "filterOutOfRange" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#deleteFilter"></see>
    /// </summary>
    let deleteFilter =
        Namespaced_IRI.parse _namespace_name "deleteFilter" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#filterOperationApproved"></see>
    /// </summary>
    let filterOperationApproved =
        Namespaced_IRI.parse _namespace_name "filterOperationApproved" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#filterReferenceExtension"></see>
    /// </summary>
    let filterReferenceExtension =
        Namespaced_IRI.parse _namespace_name "filterReferenceExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#keyFilterReference"></see>
    /// </summary>
    let keyFilterReference =
        Namespaced_IRI.parse _namespace_name "keyFilterReference" |> NamespacedName

    /// <summary>
    /// A measured or calculated value of distance in metres in a floating point format.
    /// <see href="http://vocab.datex.org/terms#FloatingPointMetreDistanceValue"></see></summary>
    let FloatingPointMetreDistanceValue =
        Namespaced_IRI.parse _namespace_name "FloatingPointMetreDistanceValue" |> NamespacedName

    /// <summary>
    /// A value of distance expressed in metres in a floating point format.
    /// <see href="http://vocab.datex.org/terms#floatingPointMetreDistance"></see></summary>
    let floatingPointMetreDistance =
        Namespaced_IRI.parse _namespace_name "floatingPointMetreDistance" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#floatingPointMetreDistanceValueExtension"></see>
    /// </summary>
    let floatingPointMetreDistanceValueExtension =
        Namespaced_IRI.parse _namespace_name "floatingPointMetreDistanceValueExtension" |> NamespacedName

    /// <summary>
    /// General instruction and/or message that is issued by the network/road operator which is applicable to drivers and sometimes passengers.
    /// <see href="http://vocab.datex.org/terms#GeneralInstructionOrMessageToRoadUsers"></see></summary>
    let GeneralInstructionOrMessageToRoadUsers =
        Namespaced_IRI.parse _namespace_name "GeneralInstructionOrMessageToRoadUsers" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#generalInstructionOrMessageToRoadUsersExtension"></see>
    /// </summary>
    let generalInstructionOrMessageToRoadUsersExtension =
        Namespaced_IRI.parse _namespace_name "generalInstructionOrMessageToRoadUsersExtension" |> NamespacedName

    /// <summary>
    /// General instruction that is issued by the network/road operator which is applicable to drivers and sometimes passengers.
    /// <see href="http://vocab.datex.org/terms#generalInstructionToRoadUsersType"></see></summary>
    let generalInstructionToRoadUsersType =
        Namespaced_IRI.parse _namespace_name "generalInstructionToRoadUsersType" |> NamespacedName

    /// <summary>
    /// General message that is issued by the network/road operator which is applicable to drivers and sometimes passengers, e.g. details about an amber alert (missing or abducted child alert).
    /// <see href="http://vocab.datex.org/terms#generalMessageToRoadUsers"></see></summary>
    let generalMessageToRoadUsers =
        Namespaced_IRI.parse _namespace_name "generalMessageToRoadUsers" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#generalNetworkManagementExtension"></see>
    /// </summary>
    let generalNetworkManagementExtension =
        Namespaced_IRI.parse _namespace_name "generalNetworkManagementExtension" |> NamespacedName

    /// <summary>
    /// The type of traffic management action instigated by the network/road operator.
    /// <see href="http://vocab.datex.org/terms#generalNetworkManagementType"></see></summary>
    let generalNetworkManagementType =
        Namespaced_IRI.parse _namespace_name "generalNetworkManagementType" |> NamespacedName

    /// <summary>
    /// Type of person that is manually directing traffic (applicable if generalNetworkManagementType is set to "trafficBeingManuallyDirected").
    /// <see href="http://vocab.datex.org/terms#trafficManuallyDirectedBy"></see></summary>
    let trafficManuallyDirectedBy =
        Namespaced_IRI.parse _namespace_name "trafficManuallyDirectedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#generalObstructionExtension"></see>
    /// </summary>
    let generalObstructionExtension =
        Namespaced_IRI.parse _namespace_name "generalObstructionExtension" |> NamespacedName

    /// <summary>
    /// Characterization of the type of general obstruction.
    /// <see href="http://vocab.datex.org/terms#obstructionType"></see></summary>
    let obstructionType =
        Namespaced_IRI.parse _namespace_name "obstructionType" |> NamespacedName

    /// <summary>
    /// A publication used to make level B extensions at the publication level.
    /// <see href="http://vocab.datex.org/terms#GenericPublication"></see></summary>
    let GenericPublication =
        Namespaced_IRI.parse _namespace_name "GenericPublication" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#genericPublicationExtension"></see>
    /// </summary>
    let genericPublicationExtension =
        Namespaced_IRI.parse _namespace_name "genericPublicationExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_GenericPublicationExtensionType"></see>
    /// </summary>
    let _GenericPublicationExtensionType =
        Namespaced_IRI.parse _namespace_name "_GenericPublicationExtensionType" |> NamespacedName

    /// <summary>
    /// The name of the generic publication.
    /// <see href="http://vocab.datex.org/terms#genericPublicationName"></see></summary>
    let genericPublicationName =
        Namespaced_IRI.parse _namespace_name "genericPublicationName" |> NamespacedName

    /// <summary>
    /// A generic SituationRecord for use when adding level B extensions at the SituationRecord level.
    /// <see href="http://vocab.datex.org/terms#GenericSituationRecord"></see></summary>
    let GenericSituationRecord =
        Namespaced_IRI.parse _namespace_name "GenericSituationRecord" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#genericSituationRecordExtension"></see>
    /// </summary>
    let genericSituationRecordExtension =
        Namespaced_IRI.parse _namespace_name "genericSituationRecordExtension" |> NamespacedName

    /// <summary>
    /// The name of the GenericSituationRecord.
    /// <see href="http://vocab.datex.org/terms#genericSituationRecordName"></see></summary>
    let genericSituationRecordName =
        Namespaced_IRI.parse _namespace_name "genericSituationRecordName" |> NamespacedName

    /// <summary>
    /// An identifiable versioned instance of a single record/element within a situation.
    /// <see href="http://vocab.datex.org/terms#SituationRecord"></see></summary>
    let SituationRecord =
        Namespaced_IRI.parse _namespace_name "SituationRecord" |> NamespacedName

    /// <summary>
    /// Gross weight characteristic of a vehicle.
    /// <see href="http://vocab.datex.org/terms#GrossWeightCharacteristic"></see></summary>
    let GrossWeightCharacteristic =
        Namespaced_IRI.parse _namespace_name "GrossWeightCharacteristic" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#comparisonOperator"></see>
    /// </summary>
    let comparisonOperator =
        Namespaced_IRI.parse _namespace_name "comparisonOperator" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#grossVehicleWeight"></see>
    /// </summary>
    let grossVehicleWeight =
        Namespaced_IRI.parse _namespace_name "grossVehicleWeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#grossWeightCharacteristicExtension"></see>
    /// </summary>
    let grossWeightCharacteristicExtension =
        Namespaced_IRI.parse _namespace_name "grossWeightCharacteristicExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#groupOfLocationsExtension"></see>
    /// </summary>
    let groupOfLocationsExtension =
        Namespaced_IRI.parse _namespace_name "groupOfLocationsExtension" |> NamespacedName

    /// <summary>
    /// A logical composition of parking sites with aggregated properties (e.g. number of spaces). Examples: Urban parking area "West" or all truck parkings along a motorway. The included parking sites may -but must not- be specified as subcomponents.
    /// <see href="http://vocab.datex.org/terms#GroupOfParkingSites"></see></summary>
    let GroupOfParkingSites =
        Namespaced_IRI.parse _namespace_name "GroupOfParkingSites" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#groupOfParkingSitesExtension"></see>
    /// </summary>
    let groupOfParkingSitesExtension =
        Namespaced_IRI.parse _namespace_name "groupOfParkingSitesExtension" |> NamespacedName

    /// <summary>
    /// The type of this group of parking sites.
    /// <see href="http://vocab.datex.org/terms#groupOfParkingSitesType"></see></summary>
    let groupOfParkingSitesType =
        Namespaced_IRI.parse _namespace_name "groupOfParkingSitesType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSite"></see>
    /// </summary>
    let parkingSite =
        Namespaced_IRI.parse _namespace_name "parkingSite" |> NamespacedName

    /// <summary>
    /// A record containing static details of a parking site. Must be specialised as an 'Urban-' or 'InterUrbanParkingSite' or a 'SpecialLocationParkingSite'.
    /// <see href="http://vocab.datex.org/terms#ParkingSite"></see></summary>
    let ParkingSite =
        Namespaced_IRI.parse _namespace_name "ParkingSite" |> NamespacedName

    /// <summary>
    /// Parking sites of this collection defined by reference.
    /// <see href="http://vocab.datex.org/terms#parkingSiteByReference"></see></summary>
    let parkingSiteByReference =
        Namespaced_IRI.parse _namespace_name "parkingSiteByReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_ParkingRecordVersionedReference"></see>
    /// </summary>
    let _ParkingRecordVersionedReference =
        Namespaced_IRI.parse _namespace_name "_ParkingRecordVersionedReference" |> NamespacedName

    /// <summary>
    /// A container for static parking information. Must be specialised as a parking site or as a group of parking sites.
    /// <see href="http://vocab.datex.org/terms#ParkingRecord"></see></summary>
    let ParkingRecord =
        Namespaced_IRI.parse _namespace_name "ParkingRecord" |> NamespacedName

    /// <summary>
    /// Dynamic status information for the static object 'GroupOfParkingSites'.
    /// <see href="http://vocab.datex.org/terms#GroupOfParkingSitesStatus"></see></summary>
    let GroupOfParkingSitesStatus =
        Namespaced_IRI.parse _namespace_name "GroupOfParkingSitesStatus" |> NamespacedName

    /// <summary>
    /// The status of the group of parking sites (available spaces or not).
    /// <see href="http://vocab.datex.org/terms#groupOfParkingSitesStatus"></see></summary>
    let groupOfParkingSitesStatus =
        Namespaced_IRI.parse _namespace_name "groupOfParkingSitesStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#groupOfParkingSitesStatusExtension"></see>
    /// </summary>
    let groupOfParkingSitesStatusExtension =
        Namespaced_IRI.parse _namespace_name "groupOfParkingSitesStatusExtension" |> NamespacedName

    /// <summary>
    /// Contains the current status of one parking record defined in the static model (i.e. parking site or group of parking sites) or historical or forecasted data for one parking. Only for the second case, 'parkingStatusTime' must be specified.
    /// <see href="http://vocab.datex.org/terms#ParkingRecordStatus"></see></summary>
    let ParkingRecordStatus =
        Namespaced_IRI.parse _namespace_name "ParkingRecordStatus" |> NamespacedName

    /// <summary>
    /// A group of parking spaces. All information provided has to be identical for all places in this group. Can also be used just to give the number of lorry parkings, for example. 'GroupOfParkingSpaces' may be multiple defined or include each other.
    /// <see href="http://vocab.datex.org/terms#GroupOfParkingSpaces"></see></summary>
    let GroupOfParkingSpaces =
        Namespaced_IRI.parse _namespace_name "GroupOfParkingSpaces" |> NamespacedName

    /// <summary>
    /// Dimension of a virtual rectangle encapsulating the group of parking spaces. Use 'dimensionUsableArea' to define the total space available for parking within this group. Do not use 'dimensionHeight'.
    /// <see href="http://vocab.datex.org/terms#dimensionOfGroup"></see></summary>
    let dimensionOfGroup =
        Namespaced_IRI.parse _namespace_name "dimensionOfGroup" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#groupOfParkingSpacesExtension"></see>
    /// </summary>
    let groupOfParkingSpacesExtension =
        Namespaced_IRI.parse _namespace_name "groupOfParkingSpacesExtension" |> NamespacedName

    /// <summary>
    /// Points to another instance of 'GroupOfParkingSpaces', which is identical from a local point of view. To be used when defining mixed parking areas with different time slots.
    /// <see href="http://vocab.datex.org/terms#identicalToGroup"></see></summary>
    let identicalToGroup =
        Namespaced_IRI.parse _namespace_name "identicalToGroup" |> NamespacedName

    /// <summary>
    /// Dimension of the largest space within this group (i.e. there must be at least one space of this dimension). If the comparison of dimension values is not unique, the length is decisive.
    /// <see href="http://vocab.datex.org/terms#maximumParkingSpaceDimension"></see></summary>
    let maximumParkingSpaceDimension =
        Namespaced_IRI.parse _namespace_name "maximumParkingSpaceDimension" |> NamespacedName

    /// <summary>
    /// Lower dimension boundaries for all spaces within the group. Note that there must not exist a space with this dimension, but each space's dimension values must be equal or higher.
    /// <see href="http://vocab.datex.org/terms#minimumParkingSpaceDimension"></see></summary>
    let minimumParkingSpaceDimension =
        Namespaced_IRI.parse _namespace_name "minimumParkingSpaceDimension" |> NamespacedName

    /// <summary>
    /// Number of parking spaces (attribute is used for a parking record as well as for a group of parking spaces).
    /// <see href="http://vocab.datex.org/terms#parkingNumberOfSpaces"></see></summary>
    let parkingNumberOfSpaces =
        Namespaced_IRI.parse _namespace_name "parkingNumberOfSpaces" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSpace"></see>
    /// </summary>
    let parkingSpace =
        Namespaced_IRI.parse _namespace_name "parkingSpace" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_GroupOfParkingSpacesParkingSpaceIndexParkingSpace"></see>
    /// </summary>
    let _GroupOfParkingSpacesParkingSpaceIndexParkingSpace =
        Namespaced_IRI.parse _namespace_name "_GroupOfParkingSpacesParkingSpaceIndexParkingSpace" |> NamespacedName

    /// <summary>
    /// Defines the type of this group specification.
    /// <see href="http://vocab.datex.org/terms#parkingTypeOfGroup"></see></summary>
    let parkingTypeOfGroup =
        Namespaced_IRI.parse _namespace_name "parkingTypeOfGroup" |> NamespacedName

    /// <summary>
    /// Points to another instance of 'GroupOfParkingSpaces', which is a real superset from a local point of view. To be used when defining mixed parking areas with different time slots.
    /// <see href="http://vocab.datex.org/terms#realSubsetOfGroup"></see></summary>
    let realSubsetOfGroup =
        Namespaced_IRI.parse _namespace_name "realSubsetOfGroup" |> NamespacedName

    /// <summary>
    /// Common properties of parking spaces and groups of parking spaces.
    /// <see href="http://vocab.datex.org/terms#ParkingSpaceBasics"></see></summary>
    let ParkingSpaceBasics =
        Namespaced_IRI.parse _namespace_name "ParkingSpaceBasics" |> NamespacedName

    /// <summary>
    /// The status of the assigned parking spaces in the specified parking site, i.e. the status of those spaces assigned for particular types of person or vehicle and/or for specific duration types (e.g. short stay).
    /// <see href="http://vocab.datex.org/terms#GroupOfParkingSpacesStatus"></see></summary>
    let GroupOfParkingSpacesStatus =
        Namespaced_IRI.parse _namespace_name "GroupOfParkingSpacesStatus" |> NamespacedName

    /// <summary>
    /// Override validity of AssignedParkingSpaces: True = Parking space declaration is valid now; False = Parking space declaration is invalid now; Omitted = Static validity information is significant (if static validity is omitted too, declaration is valid).
    /// <see href="http://vocab.datex.org/terms#groupDeclarationValidNow"></see></summary>
    let groupDeclarationValidNow =
        Namespaced_IRI.parse _namespace_name "groupDeclarationValidNow" |> NamespacedName

    /// <summary>
    /// True: The group of parking spaces is closed / not accessible. False or omitted: The group of parking spaces is accessible. This is no statement about its occupation.
    /// <see href="http://vocab.datex.org/terms#groupOfParkingSpacesClosed"></see></summary>
    let groupOfParkingSpacesClosed =
        Namespaced_IRI.parse _namespace_name "groupOfParkingSpacesClosed" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#groupOfParkingSpacesStatusExtension"></see>
    /// </summary>
    let groupOfParkingSpacesStatusExtension =
        Namespaced_IRI.parse _namespace_name "groupOfParkingSpacesStatusExtension" |> NamespacedName

    /// <summary>
    /// Parking capacity information for the parking site as well as for AssignedParkingSpaces.
    /// <see href="http://vocab.datex.org/terms#ParkingOccupancy"></see></summary>
    let ParkingOccupancy =
        Namespaced_IRI.parse _namespace_name "ParkingOccupancy" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#categoryOfPeopleInvolved"></see>
    /// </summary>
    let categoryOfPeopleInvolved =
        Namespaced_IRI.parse _namespace_name "categoryOfPeopleInvolved" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#groupOfPeopleInvolvedExtension"></see>
    /// </summary>
    let groupOfPeopleInvolvedExtension =
        Namespaced_IRI.parse _namespace_name "groupOfPeopleInvolvedExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#injuryStatus"></see>
    /// </summary>
    let injuryStatus =
        Namespaced_IRI.parse _namespace_name "injuryStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#involvementRole"></see>
    /// </summary>
    let involvementRole =
        Namespaced_IRI.parse _namespace_name "involvementRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#numberOfPeople"></see>
    /// </summary>
    let numberOfPeople =
        Namespaced_IRI.parse _namespace_name "numberOfPeople" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#groupOfVehiclesInvolvedExtension"></see>
    /// </summary>
    let groupOfVehiclesInvolvedExtension =
        Namespaced_IRI.parse _namespace_name "groupOfVehiclesInvolvedExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#numberOfVehicles"></see>
    /// </summary>
    let numberOfVehicles =
        Namespaced_IRI.parse _namespace_name "numberOfVehicles" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleCharacteristics"></see>
    /// </summary>
    let vehicleCharacteristics =
        Namespaced_IRI.parse _namespace_name "vehicleCharacteristics" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleStatus"></see>
    /// </summary>
    let vehicleStatus =
        Namespaced_IRI.parse _namespace_name "vehicleStatus" |> NamespacedName

    /// <summary>
    /// Details of hazardous materials.
    /// <see href="http://vocab.datex.org/terms#HazardousMaterials"></see></summary>
    let HazardousMaterials =
        Namespaced_IRI.parse _namespace_name "HazardousMaterials" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#chemicalName"></see>
    /// </summary>
    let chemicalName =
        Namespaced_IRI.parse _namespace_name "chemicalName" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#dangerousGoodsFlashPoint"></see>
    /// </summary>
    let dangerousGoodsFlashPoint =
        Namespaced_IRI.parse _namespace_name "dangerousGoodsFlashPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#dangerousGoodsRegulations"></see>
    /// </summary>
    let dangerousGoodsRegulations =
        Namespaced_IRI.parse _namespace_name "dangerousGoodsRegulations" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#hazardCodeIdentification"></see>
    /// </summary>
    let hazardCodeIdentification =
        Namespaced_IRI.parse _namespace_name "hazardCodeIdentification" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#hazardCodeVersionNumber"></see>
    /// </summary>
    let hazardCodeVersionNumber =
        Namespaced_IRI.parse _namespace_name "hazardCodeVersionNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#hazardSubstanceItemPageNumber"></see>
    /// </summary>
    let hazardSubstanceItemPageNumber =
        Namespaced_IRI.parse _namespace_name "hazardSubstanceItemPageNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#hazardousMaterialsExtension"></see>
    /// </summary>
    let hazardousMaterialsExtension =
        Namespaced_IRI.parse _namespace_name "hazardousMaterialsExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tremCardNumber"></see>
    /// </summary>
    let tremCardNumber =
        Namespaced_IRI.parse _namespace_name "tremCardNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#undgNumber"></see>
    /// </summary>
    let undgNumber = Namespaced_IRI.parse _namespace_name "undgNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#volumeOfDangerousGoods"></see>
    /// </summary>
    let volumeOfDangerousGoods =
        Namespaced_IRI.parse _namespace_name "volumeOfDangerousGoods" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#weightOfDangerousGoods"></see>
    /// </summary>
    let weightOfDangerousGoods =
        Namespaced_IRI.parse _namespace_name "weightOfDangerousGoods" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#areaOfInterest"></see>
    /// </summary>
    let areaOfInterest =
        Namespaced_IRI.parse _namespace_name "areaOfInterest" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#confidentiality"></see>
    /// </summary>
    let confidentiality =
        Namespaced_IRI.parse _namespace_name "confidentiality" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#headerInformationExtension"></see>
    /// </summary>
    let headerInformationExtension =
        Namespaced_IRI.parse _namespace_name "headerInformationExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#informationStatus"></see>
    /// </summary>
    let informationStatus =
        Namespaced_IRI.parse _namespace_name "informationStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#urgency"></see>
    /// </summary>
    let urgency = Namespaced_IRI.parse _namespace_name "urgency" |> NamespacedName

    /// <summary>
    /// Weight characteristic of the heaviest axle on the vehicle.
    /// <see href="http://vocab.datex.org/terms#HeaviestAxleWeightCharacteristic"></see></summary>
    let HeaviestAxleWeightCharacteristic =
        Namespaced_IRI.parse _namespace_name "HeaviestAxleWeightCharacteristic" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#heaviestAxleWeight"></see>
    /// </summary>
    let heaviestAxleWeight =
        Namespaced_IRI.parse _namespace_name "heaviestAxleWeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#heaviestAxleWeightCharacteristicExtension"></see>
    /// </summary>
    let heaviestAxleWeightCharacteristicExtension =
        Namespaced_IRI.parse _namespace_name "heaviestAxleWeightCharacteristicExtension" |> NamespacedName

    /// <summary>
    /// Height characteristic of a vehicle.
    /// <see href="http://vocab.datex.org/terms#HeightCharacteristic"></see></summary>
    let HeightCharacteristic =
        Namespaced_IRI.parse _namespace_name "HeightCharacteristic" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#heightCharacteristicExtension"></see>
    /// </summary>
    let heightCharacteristicExtension =
        Namespaced_IRI.parse _namespace_name "heightCharacteristicExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleHeight"></see>
    /// </summary>
    let vehicleHeight =
        Namespaced_IRI.parse _namespace_name "vehicleHeight" |> NamespacedName

    /// <summary>
    /// Details of atmospheric humidity.
    /// <see href="http://vocab.datex.org/terms#Humidity"></see></summary>
    let Humidity = Namespaced_IRI.parse _namespace_name "Humidity" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#humidityExtension"></see>
    /// </summary>
    let humidityExtension =
        Namespaced_IRI.parse _namespace_name "humidityExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#relativeHumidity"></see>
    /// </summary>
    let relativeHumidity =
        Namespaced_IRI.parse _namespace_name "relativeHumidity" |> NamespacedName

    /// <summary>
    /// A measured or calculated value expressed as a percentage.
    /// <see href="http://vocab.datex.org/terms#PercentageValue"></see></summary>
    let PercentageValue =
        Namespaced_IRI.parse _namespace_name "PercentageValue" |> NamespacedName

    /// <summary>
    /// Measurements of atmospheric humidity.
    /// <see href="http://vocab.datex.org/terms#HumidityInformation"></see></summary>
    let HumidityInformation =
        Namespaced_IRI.parse _namespace_name "HumidityInformation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#humidity"></see>
    /// </summary>
    let humidity = Namespaced_IRI.parse _namespace_name "humidity" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#humidityInformationExtension"></see>
    /// </summary>
    let humidityInformationExtension =
        Namespaced_IRI.parse _namespace_name "humidityInformationExtension" |> NamespacedName

    /// <summary>
    /// Measured or derived values relating to the weather at a specific location or locations.
    /// <see href="http://vocab.datex.org/terms#WeatherData"></see></summary>
    let WeatherData =
        Namespaced_IRI.parse _namespace_name "WeatherData" |> NamespacedName

    /// <summary>
    /// An assessment of the impact that an event or operator action defined by the situation record has on the driving conditions.
    /// <see href="http://vocab.datex.org/terms#Impact"></see></summary>
    let Impact = Namespaced_IRI.parse _namespace_name "Impact" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#capacityRemaining"></see>
    /// </summary>
    let capacityRemaining =
        Namespaced_IRI.parse _namespace_name "capacityRemaining" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#delays"></see>
    /// </summary>
    let delays = Namespaced_IRI.parse _namespace_name "delays" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#impactExtension"></see>
    /// </summary>
    let impactExtension =
        Namespaced_IRI.parse _namespace_name "impactExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#numberOfLanesRestricted"></see>
    /// </summary>
    let numberOfLanesRestricted =
        Namespaced_IRI.parse _namespace_name "numberOfLanesRestricted" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#numberOfOperationalLanes"></see>
    /// </summary>
    let numberOfOperationalLanes =
        Namespaced_IRI.parse _namespace_name "numberOfOperationalLanes" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#originalNumberOfLanes"></see>
    /// </summary>
    let originalNumberOfLanes =
        Namespaced_IRI.parse _namespace_name "originalNumberOfLanes" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#residualRoadWidth"></see>
    /// </summary>
    let residualRoadWidth =
        Namespaced_IRI.parse _namespace_name "residualRoadWidth" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#trafficConstrictionType"></see>
    /// </summary>
    let trafficConstrictionType =
        Namespaced_IRI.parse _namespace_name "trafficConstrictionType" |> NamespacedName

    /// <summary>
    /// Information on the individual charge for parking the specified vehicle.
    /// <see href="http://vocab.datex.org/terms#IndividualCharge"></see></summary>
    let IndividualCharge =
        Namespaced_IRI.parse _namespace_name "IndividualCharge" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#chargePaid"></see>
    /// </summary>
    let chargePaid = Namespaced_IRI.parse _namespace_name "chargePaid" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#individualChargeExtension"></see>
    /// </summary>
    let individualChargeExtension =
        Namespaced_IRI.parse _namespace_name "individualChargeExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#usedMeansOfPayment"></see>
    /// </summary>
    let usedMeansOfPayment =
        Namespaced_IRI.parse _namespace_name "usedMeansOfPayment" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#usedPaymentCard"></see>
    /// </summary>
    let usedPaymentCard =
        Namespaced_IRI.parse _namespace_name "usedPaymentCard" |> NamespacedName

    /// <summary>
    /// The used payment card for this parking vehicle.
    /// <see href="http://vocab.datex.org/terms#UsedPaymentCard"></see></summary>
    let UsedPaymentCard =
        Namespaced_IRI.parse _namespace_name "UsedPaymentCard" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#withReservation"></see>
    /// </summary>
    let withReservation =
        Namespaced_IRI.parse _namespace_name "withReservation" |> NamespacedName

    /// <summary>
    /// Measured or calculated data values relating to individual vehicles derived from detectors at the specified measurement site.
    /// <see href="http://vocab.datex.org/terms#IndividualVehicleDataValues"></see></summary>
    let IndividualVehicleDataValues =
        Namespaced_IRI.parse _namespace_name "IndividualVehicleDataValues" |> NamespacedName

    /// <summary>
    /// The time of the arrival of an individual vehicle in a detection zone.
    /// <see href="http://vocab.datex.org/terms#arrivalTime"></see></summary>
    let arrivalTime =
        Namespaced_IRI.parse _namespace_name "arrivalTime" |> NamespacedName

    /// <summary>
    /// The measured distance between the front of this vehicle and the rear of the preceding one, in metres at the specified measurement site.
    /// <see href="http://vocab.datex.org/terms#distanceGap"></see></summary>
    let distanceGap =
        Namespaced_IRI.parse _namespace_name "distanceGap" |> NamespacedName

    /// <summary>
    /// The measured distance between the front (respectively back) of this vehicle and the front (respectively  back) of the preceding vehicle at the specified measurement site.
    /// <see href="http://vocab.datex.org/terms#distanceHeadway"></see></summary>
    let distanceHeadway =
        Namespaced_IRI.parse _namespace_name "distanceHeadway" |> NamespacedName

    /// <summary>
    /// The time when an individual vehicle leaves a detection zone.
    /// <see href="http://vocab.datex.org/terms#exitTime"></see></summary>
    let exitTime = Namespaced_IRI.parse _namespace_name "exitTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#individualVehicleDataValuesExtension"></see>
    /// </summary>
    let individualVehicleDataValuesExtension =
        Namespaced_IRI.parse _namespace_name "individualVehicleDataValuesExtension" |> NamespacedName

    /// <summary>
    /// The measured speed of the individual vehicle at the specified measurement site.
    /// <see href="http://vocab.datex.org/terms#individualVehicleSpeed"></see></summary>
    let individualVehicleSpeed =
        Namespaced_IRI.parse _namespace_name "individualVehicleSpeed" |> NamespacedName

    /// <summary>
    /// A measured or calculated value of speed.
    /// <see href="http://vocab.datex.org/terms#SpeedValue"></see></summary>
    let SpeedValue = Namespaced_IRI.parse _namespace_name "SpeedValue" |> NamespacedName

    /// <summary>
    /// The time elapsed between an individual vehicle entering a detection zone and exiting the same detection zone as detected by entry and exit sensors.
    /// <see href="http://vocab.datex.org/terms#passageDurationTime"></see></summary>
    let passageDurationTime =
        Namespaced_IRI.parse _namespace_name "passageDurationTime" |> NamespacedName

    /// <summary>
    /// The period of time during which a vehicle activates a presence sensor.
    /// <see href="http://vocab.datex.org/terms#presenceDurationTime"></see></summary>
    let presenceDurationTime =
        Namespaced_IRI.parse _namespace_name "presenceDurationTime" |> NamespacedName

    /// <summary>
    /// The time interval between the arrival of this vehicle's front at a point on the roadway, and that of the departure of the rear of the preceding one.
    /// <see href="http://vocab.datex.org/terms#timeGap"></see></summary>
    let timeGap = Namespaced_IRI.parse _namespace_name "timeGap" |> NamespacedName

    /// <summary>
    /// The measured time interval between this vehicle's arrival at (or departure from) a point on the roadway, and that of the preceding one.
    /// <see href="http://vocab.datex.org/terms#timeHeadway"></see></summary>
    let timeHeadway =
        Namespaced_IRI.parse _namespace_name "timeHeadway" |> NamespacedName

    /// <summary>
    /// Measured or derived values relating to traffic or individual vehicle movements on a specific section or at a specific point on the road network.
    /// <see href="http://vocab.datex.org/terms#TrafficData"></see></summary>
    let TrafficData =
        Namespaced_IRI.parse _namespace_name "TrafficData" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#infrastructureDamageObstructionExtension"></see>
    /// </summary>
    let infrastructureDamageObstructionExtension =
        Namespaced_IRI.parse _namespace_name "infrastructureDamageObstructionExtension" |> NamespacedName

    /// <summary>
    /// Characterization of an obstruction on the road resulting from the failure or damage of infrastructure on, under, above or close to the road.
    /// <see href="http://vocab.datex.org/terms#infrastructureDamageType"></see></summary>
    let infrastructureDamageType =
        Namespaced_IRI.parse _namespace_name "infrastructureDamageType" |> NamespacedName

    /// <summary>
    /// A measured or calculated value of distance in whole metres.
    /// <see href="http://vocab.datex.org/terms#IntegerMetreDistanceValue"></see></summary>
    let IntegerMetreDistanceValue =
        Namespaced_IRI.parse _namespace_name "IntegerMetreDistanceValue" |> NamespacedName

    /// <summary>
    /// A value of distance expressed in metres in a non negative integer format.
    /// <see href="http://vocab.datex.org/terms#integerMetreDistance"></see></summary>
    let integerMetreDistance =
        Namespaced_IRI.parse _namespace_name "integerMetreDistance" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#integerMetreDistanceValueExtension"></see>
    /// </summary>
    let integerMetreDistanceValueExtension =
        Namespaced_IRI.parse _namespace_name "integerMetreDistanceValueExtension" |> NamespacedName

    /// <summary>
    /// A parking site in an interurban context.
    /// <see href="http://vocab.datex.org/terms#InterUrbanParkingSite"></see></summary>
    let InterUrbanParkingSite =
        Namespaced_IRI.parse _namespace_name "InterUrbanParkingSite" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#interUrbanParkingSiteExtension"></see>
    /// </summary>
    let interUrbanParkingSiteExtension =
        Namespaced_IRI.parse _namespace_name "interUrbanParkingSiteExtension" |> NamespacedName

    /// <summary>
    /// Defines whether the interurban parking site is located in or nearby a motorway context, is a layby or on-street parking.
    /// <see href="http://vocab.datex.org/terms#interUrbanParkingSiteLocation"></see></summary>
    let interUrbanParkingSiteLocation =
        Namespaced_IRI.parse _namespace_name "interUrbanParkingSiteLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#internationalIdentifierExtension"></see>
    /// </summary>
    let internationalIdentifierExtension =
        Namespaced_IRI.parse _namespace_name "internationalIdentifierExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#nationalIdentifier"></see>
    /// </summary>
    let nationalIdentifier =
        Namespaced_IRI.parse _namespace_name "nationalIdentifier" |> NamespacedName

    /// <summary>
    /// Multiple (i.e. more than one) physically separate locations arranged as an ordered set that defines an itinerary or route.
    /// <see href="http://vocab.datex.org/terms#Itinerary"></see></summary>
    let Itinerary = Namespaced_IRI.parse _namespace_name "Itinerary" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#itineraryExtension"></see>
    /// </summary>
    let itineraryExtension =
        Namespaced_IRI.parse _namespace_name "itineraryExtension" |> NamespacedName

    /// <summary>
    /// Destination of a route or final location in an itinerary.
    /// <see href="http://vocab.datex.org/terms#routeDestination"></see></summary>
    let routeDestination =
        Namespaced_IRI.parse _namespace_name "routeDestination" |> NamespacedName

    /// <summary>
    /// Multiple physically separate locations arranged as an ordered set that defines an itinerary or route. The index qualifier indicates the order.
    /// <see href="http://vocab.datex.org/terms#ItineraryByIndexedLocations"></see></summary>
    let ItineraryByIndexedLocations =
        Namespaced_IRI.parse _namespace_name "ItineraryByIndexedLocations" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#itineraryByIndexedLocationsExtension"></see>
    /// </summary>
    let itineraryByIndexedLocationsExtension =
        Namespaced_IRI.parse _namespace_name "itineraryByIndexedLocationsExtension" |> NamespacedName

    /// <summary>
    /// A location contained in an itinerary (i.e. an ordered set of locations defining a route or itinerary).
    /// <see href="http://vocab.datex.org/terms#locationContainedInItinerary"></see></summary>
    let locationContainedInItinerary =
        Namespaced_IRI.parse _namespace_name "locationContainedInItinerary" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_LocationContainedInItinerary"></see>
    /// </summary>
    let _LocationContainedInItinerary =
        Namespaced_IRI.parse _namespace_name "_LocationContainedInItinerary" |> NamespacedName

    /// <summary>
    /// Multiple (i.e. more than one) physically separate locations which are ordered that constitute an itinerary or route where they are defined by reference to a predefined itinerary.
    /// <see href="http://vocab.datex.org/terms#ItineraryByReference"></see></summary>
    let ItineraryByReference =
        Namespaced_IRI.parse _namespace_name "ItineraryByReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#itineraryByReferenceExtension"></see>
    /// </summary>
    let itineraryByReferenceExtension =
        Namespaced_IRI.parse _namespace_name "itineraryByReferenceExtension" |> NamespacedName

    /// <summary>
    /// A reference to a versioned instance of a predefined itinerary as specified in a PredefinedLocationsPublication.
    /// <see href="http://vocab.datex.org/terms#predefinedItineraryReference"></see></summary>
    let predefinedItineraryReference =
        Namespaced_IRI.parse _namespace_name "predefinedItineraryReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_PredefinedItineraryVersionedReference"></see>
    /// </summary>
    let _PredefinedItineraryVersionedReference =
        Namespaced_IRI.parse _namespace_name "_PredefinedItineraryVersionedReference" |> NamespacedName

    /// <summary>
    /// Junction (on a highway), can also be an interchange or if applicable also a motorway service station (see junctionClassification).
    /// <see href="http://vocab.datex.org/terms#Junction"></see></summary>
    let Junction = Namespaced_IRI.parse _namespace_name "Junction" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#destinationMotorway"></see>
    /// </summary>
    let destinationMotorway =
        Namespaced_IRI.parse _namespace_name "destinationMotorway" |> NamespacedName

    /// <summary>
    /// Identification of a road by its name, identifier, type ...
    /// <see href="http://vocab.datex.org/terms#Road"></see></summary>
    let Road = Namespaced_IRI.parse _namespace_name "Road" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#junctionClassification"></see>
    /// </summary>
    let junctionClassification =
        Namespaced_IRI.parse _namespace_name "junctionClassification" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#junctionExtension"></see>
    /// </summary>
    let junctionExtension =
        Namespaced_IRI.parse _namespace_name "junctionExtension" |> NamespacedName

    /// <summary>
    /// Name of the junction.
    /// <see href="http://vocab.datex.org/terms#junctionName"></see></summary>
    let junctionName =
        Namespaced_IRI.parse _namespace_name "junctionName" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#junctionNumber"></see>
    /// </summary>
    let junctionNumber =
        Namespaced_IRI.parse _namespace_name "junctionNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#motorway"></see>
    /// </summary>
    let motorway = Namespaced_IRI.parse _namespace_name "motorway" |> NamespacedName

    /// <summary>
    /// A measured or calculated value of concentration of a substance in grams per unit volume.
    /// <see href="http://vocab.datex.org/terms#KilogramsConcentrationValue"></see></summary>
    let KilogramsConcentrationValue =
        Namespaced_IRI.parse _namespace_name "KilogramsConcentrationValue" |> NamespacedName

    /// <summary>
    /// A value defining the amount of a substance in a given volume (concentration) expressed in kilograms per cubic metre.
    /// <see href="http://vocab.datex.org/terms#kilogramsConcentration"></see></summary>
    let kilogramsConcentration =
        Namespaced_IRI.parse _namespace_name "kilogramsConcentration" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#kilogramsConcentrationValueExtension"></see>
    /// </summary>
    let kilogramsConcentrationValueExtension =
        Namespaced_IRI.parse _namespace_name "kilogramsConcentrationValueExtension" |> NamespacedName

    /// <summary>
    /// Length characteristic of a vehicle.
    /// <see href="http://vocab.datex.org/terms#LengthCharacteristic"></see></summary>
    let LengthCharacteristic =
        Namespaced_IRI.parse _namespace_name "LengthCharacteristic" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#lengthCharacteristicExtension"></see>
    /// </summary>
    let lengthCharacteristicExtension =
        Namespaced_IRI.parse _namespace_name "lengthCharacteristicExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleLength"></see>
    /// </summary>
    let vehicleLength =
        Namespaced_IRI.parse _namespace_name "vehicleLength" |> NamespacedName

    /// <summary>
    /// Information relating to the life cycle management of the situation record.
    /// <see href="http://vocab.datex.org/terms#LifeCycleManagement"></see></summary>
    let LifeCycleManagement =
        Namespaced_IRI.parse _namespace_name "LifeCycleManagement" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#cancel"></see>
    /// </summary>
    let cancel = Namespaced_IRI.parse _namespace_name "cancel" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#end"></see>
    /// </summary>
    let end_ = Namespaced_IRI.parse _namespace_name "end" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#lifeCycleManagementExtension"></see>
    /// </summary>
    let lifeCycleManagementExtension =
        Namespaced_IRI.parse _namespace_name "lifeCycleManagementExtension" |> NamespacedName

    /// <summary>
    /// A linear section along a single road with optional directionality defined between two points on the same road.
    /// <see href="http://vocab.datex.org/terms#Linear"></see></summary>
    let Linear = Namespaced_IRI.parse _namespace_name "Linear" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCLinear"></see>
    /// </summary>
    let alertCLinear =
        Namespaced_IRI.parse _namespace_name "alertCLinear" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#linearExtension"></see>
    /// </summary>
    let linearExtension =
        Namespaced_IRI.parse _namespace_name "linearExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_LinearExtensionType"></see>
    /// </summary>
    let _LinearExtensionType =
        Namespaced_IRI.parse _namespace_name "_LinearExtensionType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#linearWithinLinearElement"></see>
    /// </summary>
    let linearWithinLinearElement =
        Namespaced_IRI.parse _namespace_name "linearWithinLinearElement" |> NamespacedName

    /// <summary>
    /// A linear section along a linear element where the linear element is either a part of or the whole of a linear object (i.e. a road), consistent with ISO 19148 definitions.
    /// <see href="http://vocab.datex.org/terms#LinearWithinLinearElement"></see></summary>
    let LinearWithinLinearElement =
        Namespaced_IRI.parse _namespace_name "LinearWithinLinearElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegLinearLocation"></see>
    /// </summary>
    let tpegLinearLocation =
        Namespaced_IRI.parse _namespace_name "tpegLinearLocation" |> NamespacedName

    /// <summary>
    /// A linear section along a single road defined between two points on the same road by a TPEG-Loc structure.
    /// <see href="http://vocab.datex.org/terms#TpegLinearLocation"></see></summary>
    let TpegLinearLocation =
        Namespaced_IRI.parse _namespace_name "TpegLinearLocation" |> NamespacedName

    /// <summary>
    /// The specification of a location on a network (as a point or a linear location).
    /// <see href="http://vocab.datex.org/terms#NetworkLocation"></see></summary>
    let NetworkLocation =
        Namespaced_IRI.parse _namespace_name "NetworkLocation" |> NamespacedName

    /// <summary>
    /// A linear element along a single linear object, consistent with ISO 19148 definitions.
    /// <see href="http://vocab.datex.org/terms#LinearElement"></see></summary>
    let LinearElement =
        Namespaced_IRI.parse _namespace_name "LinearElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#linearElementExtension"></see>
    /// </summary>
    let linearElementExtension =
        Namespaced_IRI.parse _namespace_name "linearElementExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#linearElementNature"></see>
    /// </summary>
    let linearElementNature =
        Namespaced_IRI.parse _namespace_name "linearElementNature" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#linearElementReferenceModel"></see>
    /// </summary>
    let linearElementReferenceModel =
        Namespaced_IRI.parse _namespace_name "linearElementReferenceModel" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#linearElementReferenceModelVersion"></see>
    /// </summary>
    let linearElementReferenceModelVersion =
        Namespaced_IRI.parse _namespace_name "linearElementReferenceModelVersion" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#roadName"></see>
    /// </summary>
    let roadName = Namespaced_IRI.parse _namespace_name "roadName" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#roadNumber"></see>
    /// </summary>
    let roadNumber = Namespaced_IRI.parse _namespace_name "roadNumber" |> NamespacedName

    /// <summary>
    /// A linear element along a single linear object defined by its identifier or code in a road network reference model (specified in LinearElement class) which segments the road network according to specific business rules.
    /// <see href="http://vocab.datex.org/terms#LinearElementByCode"></see></summary>
    let LinearElementByCode =
        Namespaced_IRI.parse _namespace_name "LinearElementByCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#linearElementByCodeExtension"></see>
    /// </summary>
    let linearElementByCodeExtension =
        Namespaced_IRI.parse _namespace_name "linearElementByCodeExtension" |> NamespacedName

    /// <summary>
    /// An identifier or code of a linear element (or link) in the road network reference model that is specified in the LinearElement class.
    /// <see href="http://vocab.datex.org/terms#linearElementIdentifier"></see></summary>
    let linearElementIdentifier =
        Namespaced_IRI.parse _namespace_name "linearElementIdentifier" |> NamespacedName

    /// <summary>
    /// A linear element along a single linear object defined by its start and end points.
    /// <see href="http://vocab.datex.org/terms#LinearElementByPoints"></see></summary>
    let LinearElementByPoints =
        Namespaced_IRI.parse _namespace_name "LinearElementByPoints" |> NamespacedName

    /// <summary>
    /// The referent at a known location on the linear object which defines the end of the linear element.
    /// <see href="http://vocab.datex.org/terms#endPointOfLinearElement"></see></summary>
    let endPointOfLinearElement =
        Namespaced_IRI.parse _namespace_name "endPointOfLinearElement" |> NamespacedName

    /// <summary>
    /// A referent at a known location on the linear object which is neither the start or end of the linear element.
    /// <see href="http://vocab.datex.org/terms#intermediatePointOnLinearElement"></see></summary>
    let intermediatePointOnLinearElement =
        Namespaced_IRI.parse _namespace_name "intermediatePointOnLinearElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_IntermediatePointOnLinearElement"></see>
    /// </summary>
    let _IntermediatePointOnLinearElement =
        Namespaced_IRI.parse _namespace_name "_IntermediatePointOnLinearElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#linearElementByPointsExtension"></see>
    /// </summary>
    let linearElementByPointsExtension =
        Namespaced_IRI.parse _namespace_name "linearElementByPointsExtension" |> NamespacedName

    /// <summary>
    /// The referent at a known location on the linear object which defines the start of the linear element.
    /// <see href="http://vocab.datex.org/terms#startPointOfLinearElement"></see></summary>
    let startPointOfLinearElement =
        Namespaced_IRI.parse _namespace_name "startPointOfLinearElement" |> NamespacedName

    /// <summary>
    /// An identifiable instance of a linear traffic view at a single point in time relating to a linear section of road, comprising one or more traffic view records.
    /// <see href="http://vocab.datex.org/terms#LinearTrafficView"></see></summary>
    let LinearTrafficView =
        Namespaced_IRI.parse _namespace_name "LinearTrafficView" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#linearPredefinedLocationReference"></see>
    /// </summary>
    let linearPredefinedLocationReference =
        Namespaced_IRI.parse _namespace_name "linearPredefinedLocationReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_PredefinedLocationVersionedReference"></see>
    /// </summary>
    let _PredefinedLocationVersionedReference =
        Namespaced_IRI.parse _namespace_name "_PredefinedLocationVersionedReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#linearTrafficViewExtension"></see>
    /// </summary>
    let linearTrafficViewExtension =
        Namespaced_IRI.parse _namespace_name "linearTrafficViewExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#trafficViewRecord"></see>
    /// </summary>
    let trafficViewRecord =
        Namespaced_IRI.parse _namespace_name "trafficViewRecord" |> NamespacedName

    /// <summary>
    /// An identifiable instance of a single record within a traffic view which shall comprise at most one instance of each of the following: OperatorAction, TrafficElement, ElaboratedData and CCTVImages.
    /// <see href="http://vocab.datex.org/terms#TrafficViewRecord"></see></summary>
    let TrafficViewRecord =
        Namespaced_IRI.parse _namespace_name "TrafficViewRecord" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#administrativeAreaOfLinearSection"></see>
    /// </summary>
    let administrativeAreaOfLinearSection =
        Namespaced_IRI.parse _namespace_name "administrativeAreaOfLinearSection" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#directionBoundOnLinearSection"></see>
    /// </summary>
    let directionBoundOnLinearSection =
        Namespaced_IRI.parse _namespace_name "directionBoundOnLinearSection" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#directionRelativeOnLinearSection"></see>
    /// </summary>
    let directionRelativeOnLinearSection =
        Namespaced_IRI.parse _namespace_name "directionRelativeOnLinearSection" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#fromPoint"></see>
    /// </summary>
    let fromPoint = Namespaced_IRI.parse _namespace_name "fromPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#heightGradeOfLinearSection"></see>
    /// </summary>
    let heightGradeOfLinearSection =
        Namespaced_IRI.parse _namespace_name "heightGradeOfLinearSection" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#linearElement"></see>
    /// </summary>
    let linearElement =
        Namespaced_IRI.parse _namespace_name "linearElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#linearWithinLinearElementExtension"></see>
    /// </summary>
    let linearWithinLinearElementExtension =
        Namespaced_IRI.parse _namespace_name "linearWithinLinearElementExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#toPoint"></see>
    /// </summary>
    let toPoint = Namespaced_IRI.parse _namespace_name "toPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#externalReferencing"></see>
    /// </summary>
    let externalReferencing =
        Namespaced_IRI.parse _namespace_name "externalReferencing" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#locationExtension"></see>
    /// </summary>
    let locationExtension =
        Namespaced_IRI.parse _namespace_name "locationExtension" |> NamespacedName

    /// <summary>
    /// A location which may be used by clients for visual display on user interfaces.
    /// <see href="http://vocab.datex.org/terms#locationForDisplay"></see></summary>
    let locationForDisplay =
        Namespaced_IRI.parse _namespace_name "locationForDisplay" |> NamespacedName

    /// <summary>
    /// A pair of coordinates defining the geodetic position of a single point using the European Terrestrial Reference System 1989 (ETRS89).
    /// <see href="http://vocab.datex.org/terms#PointCoordinates"></see></summary>
    let PointCoordinates =
        Namespaced_IRI.parse _namespace_name "PointCoordinates" |> NamespacedName

    /// <summary>
    /// A location defined by reference to a predefined location.
    /// <see href="http://vocab.datex.org/terms#LocationByReference"></see></summary>
    let LocationByReference =
        Namespaced_IRI.parse _namespace_name "LocationByReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#locationByReferenceExtension"></see>
    /// </summary>
    let locationByReferenceExtension =
        Namespaced_IRI.parse _namespace_name "locationByReferenceExtension" |> NamespacedName

    /// <summary>
    /// A reference to a versioned predefined location.
    /// <see href="http://vocab.datex.org/terms#predefinedLocationReference"></see></summary>
    let predefinedLocationReference =
        Namespaced_IRI.parse _namespace_name "predefinedLocationReference" |> NamespacedName

    /// <summary>
    /// Location characteristics which override values set in the referenced measurement point.
    /// <see href="http://vocab.datex.org/terms#LocationCharacteristicsOverride"></see></summary>
    let LocationCharacteristicsOverride =
        Namespaced_IRI.parse _namespace_name "LocationCharacteristicsOverride" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#locationCharacteristicsOverrideExtension"></see>
    /// </summary>
    let locationCharacteristicsOverrideExtension =
        Namespaced_IRI.parse _namespace_name "locationCharacteristicsOverrideExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementLanesOverride"></see>
    /// </summary>
    let measurementLanesOverride =
        Namespaced_IRI.parse _namespace_name "measurementLanesOverride" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#reversedFlow"></see>
    /// </summary>
    let reversedFlow =
        Namespaced_IRI.parse _namespace_name "reversedFlow" |> NamespacedName

    /// <summary>
    /// Details of the maintenance vehicles involved in the roadworks activity.
    /// <see href="http://vocab.datex.org/terms#MaintenanceVehicles"></see></summary>
    let MaintenanceVehicles =
        Namespaced_IRI.parse _namespace_name "MaintenanceVehicles" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maintenanceVehicleActions"></see>
    /// </summary>
    let maintenanceVehicleActions =
        Namespaced_IRI.parse _namespace_name "maintenanceVehicleActions" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maintenanceVehiclesExtension"></see>
    /// </summary>
    let maintenanceVehiclesExtension =
        Namespaced_IRI.parse _namespace_name "maintenanceVehiclesExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#numberOfMaintenanceVehicles"></see>
    /// </summary>
    let numberOfMaintenanceVehicles =
        Namespaced_IRI.parse _namespace_name "numberOfMaintenanceVehicles" |> NamespacedName

    /// <summary>
    /// Roadworks involving the maintenance or installation of infrastructure.
    /// <see href="http://vocab.datex.org/terms#MaintenanceWorks"></see></summary>
    let MaintenanceWorks =
        Namespaced_IRI.parse _namespace_name "MaintenanceWorks" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maintenanceWorksExtension"></see>
    /// </summary>
    let maintenanceWorksExtension =
        Namespaced_IRI.parse _namespace_name "maintenanceWorksExtension" |> NamespacedName

    /// <summary>
    /// The type of road maintenance or installation work at the specified location.
    /// <see href="http://vocab.datex.org/terms#roadMaintenanceType"></see></summary>
    let roadMaintenanceType =
        Namespaced_IRI.parse _namespace_name "roadMaintenanceType" |> NamespacedName

    /// <summary>
    /// A cause of this situation record which is managed by the publication creator, i.e. one which is represented by another situation record produced by the same publication creator.
    /// <see href="http://vocab.datex.org/terms#ManagedCause"></see></summary>
    let ManagedCause =
        Namespaced_IRI.parse _namespace_name "ManagedCause" |> NamespacedName

    /// <summary>
    /// A reference to another situation record produced by the same publication creator which defines a cause of the event defined here.
    /// <see href="http://vocab.datex.org/terms#managedCause"></see></summary>
    let managedCause =
        Namespaced_IRI.parse _namespace_name "managedCause" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_SituationRecordVersionedReference"></see>
    /// </summary>
    let _SituationRecordVersionedReference =
        Namespaced_IRI.parse _namespace_name "_SituationRecordVersionedReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#managedCauseExtension"></see>
    /// </summary>
    let managedCauseExtension =
        Namespaced_IRI.parse _namespace_name "managedCauseExtension" |> NamespacedName

    /// <summary>
    /// Information relating to the management of the situation record.
    /// <see href="http://vocab.datex.org/terms#Management"></see></summary>
    let Management = Namespaced_IRI.parse _namespace_name "Management" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#filterExitManagement"></see>
    /// </summary>
    let filterExitManagement =
        Namespaced_IRI.parse _namespace_name "filterExitManagement" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#lifeCycleManagement"></see>
    /// </summary>
    let lifeCycleManagement =
        Namespaced_IRI.parse _namespace_name "lifeCycleManagement" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#managementExtension"></see>
    /// </summary>
    let managementExtension =
        Namespaced_IRI.parse _namespace_name "managementExtension" |> NamespacedName

    /// <summary>
    /// A publication containing one or more measurement data sets, each set being measured at a single measurement site.
    /// <see href="http://vocab.datex.org/terms#MeasuredDataPublication"></see></summary>
    let MeasuredDataPublication =
        Namespaced_IRI.parse _namespace_name "MeasuredDataPublication" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measuredDataPublicationExtension"></see>
    /// </summary>
    let measuredDataPublicationExtension =
        Namespaced_IRI.parse _namespace_name "measuredDataPublicationExtension" |> NamespacedName

    /// <summary>
    /// A reference to a versioned Measurement Site table.
    /// <see href="http://vocab.datex.org/terms#measurementSiteTableReference"></see></summary>
    let measurementSiteTableReference =
        Namespaced_IRI.parse _namespace_name "measurementSiteTableReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_MeasurementSiteTableVersionedReference"></see>
    /// </summary>
    let _MeasurementSiteTableVersionedReference =
        Namespaced_IRI.parse _namespace_name "_MeasurementSiteTableVersionedReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#siteMeasurements"></see>
    /// </summary>
    let siteMeasurements =
        Namespaced_IRI.parse _namespace_name "siteMeasurements" |> NamespacedName

    /// <summary>
    /// A  measurement data set derived from a specific measurement site.
    /// <see href="http://vocab.datex.org/terms#SiteMeasurements"></see></summary>
    let SiteMeasurements =
        Namespaced_IRI.parse _namespace_name "SiteMeasurements" |> NamespacedName

    /// <summary>
    /// Contains optional characteristics for the specific measured value (indexed to correspond with the defined characteristics of the measurement at the referenced measurement site) which override the static characteristics defined in the MeasurementSiteTable.
    /// <see href="http://vocab.datex.org/terms#MeasuredValue"></see></summary>
    let MeasuredValue =
        Namespaced_IRI.parse _namespace_name "MeasuredValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#locationCharacteristicsOverride"></see>
    /// </summary>
    let locationCharacteristicsOverride =
        Namespaced_IRI.parse _namespace_name "locationCharacteristicsOverride" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measuredValueExtension"></see>
    /// </summary>
    let measuredValueExtension =
        Namespaced_IRI.parse _namespace_name "measuredValueExtension" |> NamespacedName

    /// <summary>
    /// The type of fault which is being reported for the specified measurement equipment.
    /// <see href="http://vocab.datex.org/terms#measurementEquipmentFault"></see></summary>
    let measurementEquipmentFault =
        Namespaced_IRI.parse _namespace_name "measurementEquipmentFault" |> NamespacedName

    /// <summary>
    /// Details of a fault which is being reported for the related measurement equipment.
    /// <see href="http://vocab.datex.org/terms#MeasurementEquipmentFault"></see></summary>
    let MeasurementEquipmentFault =
        Namespaced_IRI.parse _namespace_name "MeasurementEquipmentFault" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementEquipmentTypeUsed"></see>
    /// </summary>
    let measurementEquipmentTypeUsed =
        Namespaced_IRI.parse _namespace_name "measurementEquipmentTypeUsed" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementEquipmentFaultExtension"></see>
    /// </summary>
    let measurementEquipmentFaultExtension =
        Namespaced_IRI.parse _namespace_name "measurementEquipmentFaultExtension" |> NamespacedName

    /// <summary>
    /// An identifiable single measurement site entry/record in the Measurement Site table.
    /// <see href="http://vocab.datex.org/terms#MeasurementSiteRecord"></see></summary>
    let MeasurementSiteRecord =
        Namespaced_IRI.parse _namespace_name "MeasurementSiteRecord" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#computationMethod"></see>
    /// </summary>
    let computationMethod =
        Namespaced_IRI.parse _namespace_name "computationMethod" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementEquipmentReference"></see>
    /// </summary>
    let measurementEquipmentReference =
        Namespaced_IRI.parse _namespace_name "measurementEquipmentReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementSide"></see>
    /// </summary>
    let measurementSide =
        Namespaced_IRI.parse _namespace_name "measurementSide" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementSiteIdentification"></see>
    /// </summary>
    let measurementSiteIdentification =
        Namespaced_IRI.parse _namespace_name "measurementSiteIdentification" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementSiteLocation"></see>
    /// </summary>
    let measurementSiteLocation =
        Namespaced_IRI.parse _namespace_name "measurementSiteLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementSiteName"></see>
    /// </summary>
    let measurementSiteName =
        Namespaced_IRI.parse _namespace_name "measurementSiteName" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementSiteNumberOfLanes"></see>
    /// </summary>
    let measurementSiteNumberOfLanes =
        Namespaced_IRI.parse _namespace_name "measurementSiteNumberOfLanes" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementSiteRecordExtension"></see>
    /// </summary>
    let measurementSiteRecordExtension =
        Namespaced_IRI.parse _namespace_name "measurementSiteRecordExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementSiteRecordVersionTime"></see>
    /// </summary>
    let measurementSiteRecordVersionTime =
        Namespaced_IRI.parse _namespace_name "measurementSiteRecordVersionTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementSpecificCharacteristics"></see>
    /// </summary>
    let measurementSpecificCharacteristics =
        Namespaced_IRI.parse _namespace_name "measurementSpecificCharacteristics" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_MeasurementSiteRecordIndexMeasurementSpecificCharacteristics"></see>
    /// </summary>
    let _MeasurementSiteRecordIndexMeasurementSpecificCharacteristics =
        Namespaced_IRI.parse _namespace_name "_MeasurementSiteRecordIndexMeasurementSpecificCharacteristics" |> NamespacedName

    /// <summary>
    /// A Measurement Site Table comprising a number of sets of data, each describing the location from where a stream of measured data may be derived.  Each location is known as a "measurement site" which can be a point, a linear road section or an area.
    /// <see href="http://vocab.datex.org/terms#MeasurementSiteTable"></see></summary>
    let MeasurementSiteTable =
        Namespaced_IRI.parse _namespace_name "MeasurementSiteTable" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementSiteRecord"></see>
    /// </summary>
    let measurementSiteRecord =
        Namespaced_IRI.parse _namespace_name "measurementSiteRecord" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementSiteTableExtension"></see>
    /// </summary>
    let measurementSiteTableExtension =
        Namespaced_IRI.parse _namespace_name "measurementSiteTableExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementSiteTableIdentification"></see>
    /// </summary>
    let measurementSiteTableIdentification =
        Namespaced_IRI.parse _namespace_name "measurementSiteTableIdentification" |> NamespacedName

    /// <summary>
    /// A publication containing one or more Measurment Site Tables.
    /// <see href="http://vocab.datex.org/terms#MeasurementSiteTablePublication"></see></summary>
    let MeasurementSiteTablePublication =
        Namespaced_IRI.parse _namespace_name "MeasurementSiteTablePublication" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementSiteTable"></see>
    /// </summary>
    let measurementSiteTable =
        Namespaced_IRI.parse _namespace_name "measurementSiteTable" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementSiteTablePublicationExtension"></see>
    /// </summary>
    let measurementSiteTablePublicationExtension =
        Namespaced_IRI.parse _namespace_name "measurementSiteTablePublicationExtension" |> NamespacedName

    /// <summary>
    /// Characteristics which are specific to an individual measurement type (specified in a known order) at the given measurement site.
    /// <see href="http://vocab.datex.org/terms#MeasurementSpecificCharacteristics"></see></summary>
    let MeasurementSpecificCharacteristics =
        Namespaced_IRI.parse _namespace_name "MeasurementSpecificCharacteristics" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementSpecificCharacteristicsExtension"></see>
    /// </summary>
    let measurementSpecificCharacteristicsExtension =
        Namespaced_IRI.parse _namespace_name "measurementSpecificCharacteristicsExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#period"></see>
    /// </summary>
    let period = Namespaced_IRI.parse _namespace_name "period" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#specificLane"></see>
    /// </summary>
    let specificLane =
        Namespaced_IRI.parse _namespace_name "specificLane" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#specificMeasurementValueType"></see>
    /// </summary>
    let specificMeasurementValueType =
        Namespaced_IRI.parse _namespace_name "specificMeasurementValueType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#specificVehicleCharacteristics"></see>
    /// </summary>
    let specificVehicleCharacteristics =
        Namespaced_IRI.parse _namespace_name "specificVehicleCharacteristics" |> NamespacedName

    /// <summary>
    /// A measured or calculated value of concentration of a substance in micrograms per unit volume.
    /// <see href="http://vocab.datex.org/terms#MicrogramsConcentrationValue"></see></summary>
    let MicrogramsConcentrationValue =
        Namespaced_IRI.parse _namespace_name "MicrogramsConcentrationValue" |> NamespacedName

    /// <summary>
    /// A value of the amount of a substance in a given volume (concentration) expressed in µg/m3 (microgrammes/cubic metre).
    /// <see href="http://vocab.datex.org/terms#microgramsConcentration"></see></summary>
    let microgramsConcentration =
        Namespaced_IRI.parse _namespace_name "microgramsConcentration" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#microgramsConcentrationValueExtension"></see>
    /// </summary>
    let microgramsConcentrationValueExtension =
        Namespaced_IRI.parse _namespace_name "microgramsConcentrationValueExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#mobilityExtension"></see>
    /// </summary>
    let mobilityExtension =
        Namespaced_IRI.parse _namespace_name "mobilityExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#mobilityType"></see>
    /// </summary>
    let mobilityType =
        Namespaced_IRI.parse _namespace_name "mobilityType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#values"></see>
    /// </summary>
    let values = Namespaced_IRI.parse _namespace_name "values" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#valuesType"></see>
    /// </summary>
    let valuesType = Namespaced_IRI.parse _namespace_name "valuesType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#MultilingualStringValue"></see>
    /// </summary>
    let MultilingualStringValue =
        Namespaced_IRI.parse _namespace_name "MultilingualStringValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#lang"></see>
    /// </summary>
    let lang = Namespaced_IRI.parse _namespace_name "lang" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#areaName"></see>
    /// </summary>
    let areaName = Namespaced_IRI.parse _namespace_name "areaName" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#county"></see>
    /// </summary>
    let county = Namespaced_IRI.parse _namespace_name "county" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#namedAreaExtension"></see>
    /// </summary>
    let namedAreaExtension =
        Namespaced_IRI.parse _namespace_name "namedAreaExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#nation"></see>
    /// </summary>
    let nation = Namespaced_IRI.parse _namespace_name "nation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#policeForceControlArea"></see>
    /// </summary>
    let policeForceControlArea =
        Namespaced_IRI.parse _namespace_name "policeForceControlArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#roadOperatorControlArea"></see>
    /// </summary>
    let roadOperatorControlArea =
        Namespaced_IRI.parse _namespace_name "roadOperatorControlArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#destination"></see>
    /// </summary>
    let destination =
        Namespaced_IRI.parse _namespace_name "destination" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#networkLocationExtension"></see>
    /// </summary>
    let networkLocationExtension =
        Namespaced_IRI.parse _namespace_name "networkLocationExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#supplementaryPositionalDescription"></see>
    /// </summary>
    let supplementaryPositionalDescription =
        Namespaced_IRI.parse _namespace_name "supplementaryPositionalDescription" |> NamespacedName

    /// <summary>
    /// A collection of supplementary positional information which improves the precision of the location.
    /// <see href="http://vocab.datex.org/terms#SupplementaryPositionalDescription"></see></summary>
    let SupplementaryPositionalDescription =
        Namespaced_IRI.parse _namespace_name "SupplementaryPositionalDescription" |> NamespacedName

    /// <summary>
    /// The ultimate traffic direction to which the network management is applicable.
    /// <see href="http://vocab.datex.org/terms#applicableForTrafficDirection"></see></summary>
    let applicableForTrafficDirection =
        Namespaced_IRI.parse _namespace_name "applicableForTrafficDirection" |> NamespacedName

    /// <summary>
    /// The type of traffic to which the network management is applicable.
    /// <see href="http://vocab.datex.org/terms#applicableForTrafficType"></see></summary>
    let applicableForTrafficType =
        Namespaced_IRI.parse _namespace_name "applicableForTrafficType" |> NamespacedName

    /// <summary>
    /// Defines whether the network management is initiated by an automatic system.
    /// <see href="http://vocab.datex.org/terms#automaticallyInitiated"></see></summary>
    let automaticallyInitiated =
        Namespaced_IRI.parse _namespace_name "automaticallyInitiated" |> NamespacedName

    /// <summary>
    /// Defines whether the network management instruction or the control resulting from a network management action is advisory or mandatory.
    /// <see href="http://vocab.datex.org/terms#complianceOption"></see></summary>
    let complianceOption =
        Namespaced_IRI.parse _namespace_name "complianceOption" |> NamespacedName

    /// <summary>
    /// The characteristics of those vehicles for which the network management is applicable.
    /// Used to define the vehicle characteristics to which the TrafficValue is applicable primarily in Elaborated Data Publications, but may also be used in Measured Data Publications to override vehicle characteristics defined for the measurement site.
    /// <see href="http://vocab.datex.org/terms#forVehiclesWithCharacteristicsOf"></see></summary>
    let forVehiclesWithCharacteristicsOf =
        Namespaced_IRI.parse _namespace_name "forVehiclesWithCharacteristicsOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#networkManagementExtension"></see>
    /// </summary>
    let networkManagementExtension =
        Namespaced_IRI.parse _namespace_name "networkManagementExtension" |> NamespacedName

    /// <summary>
    /// Places, in generic terms, at which the network management applies.
    /// <see href="http://vocab.datex.org/terms#placesAtWhichApplicable"></see></summary>
    let placesAtWhichApplicable =
        Namespaced_IRI.parse _namespace_name "placesAtWhichApplicable" |> NamespacedName

    /// <summary>
    /// A cause of this situation record which is not managed by the publication creator, i.e. one which is not represented by another situation record produced by the same publication creator.
    /// <see href="http://vocab.datex.org/terms#NonManagedCause"></see></summary>
    let NonManagedCause =
        Namespaced_IRI.parse _namespace_name "NonManagedCause" |> NamespacedName

    /// <summary>
    /// Description of a cause which is not managed by the publication creator (e.g. an off network cause).
    /// <see href="http://vocab.datex.org/terms#causeDescription"></see></summary>
    let causeDescription =
        Namespaced_IRI.parse _namespace_name "causeDescription" |> NamespacedName

    /// <summary>
    /// Indicates an external influence that may be the causation of components of a situation.
    /// <see href="http://vocab.datex.org/terms#causeType"></see></summary>
    let causeType = Namespaced_IRI.parse _namespace_name "causeType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#nonManagedCauseExtension"></see>
    /// </summary>
    let nonManagedCauseExtension =
        Namespaced_IRI.parse _namespace_name "nonManagedCauseExtension" |> NamespacedName

    /// <summary>
    /// A group of (i.e. more than one) physically separate locations which have no specific order and where each location is explicitly listed.
    /// <see href="http://vocab.datex.org/terms#NonOrderedLocationGroupByList"></see></summary>
    let NonOrderedLocationGroupByList =
        Namespaced_IRI.parse _namespace_name "NonOrderedLocationGroupByList" |> NamespacedName

    /// <summary>
    /// A location contained in a non ordered group of locations.
    /// <see href="http://vocab.datex.org/terms#locationContainedInGroup"></see></summary>
    let locationContainedInGroup =
        Namespaced_IRI.parse _namespace_name "locationContainedInGroup" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#nonOrderedLocationGroupByListExtension"></see>
    /// </summary>
    let nonOrderedLocationGroupByListExtension =
        Namespaced_IRI.parse _namespace_name "nonOrderedLocationGroupByListExtension" |> NamespacedName

    /// <summary>
    /// Multiple (i.e. more than one) physically separate locations which have no specific order.
    /// <see href="http://vocab.datex.org/terms#NonOrderedLocations"></see></summary>
    let NonOrderedLocations =
        Namespaced_IRI.parse _namespace_name "NonOrderedLocations" |> NamespacedName

    /// <summary>
    /// A group of (i.e. more than one) physically separate locations which have no specific order that are defined by reference to a predefined non ordered location group.
    /// <see href="http://vocab.datex.org/terms#NonOrderedLocationGroupByReference"></see></summary>
    let NonOrderedLocationGroupByReference =
        Namespaced_IRI.parse _namespace_name "NonOrderedLocationGroupByReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#nonOrderedLocationGroupByReferenceExtension"></see>
    /// </summary>
    let nonOrderedLocationGroupByReferenceExtension =
        Namespaced_IRI.parse _namespace_name "nonOrderedLocationGroupByReferenceExtension" |> NamespacedName

    /// <summary>
    /// A reference to a versioned instance of a predefined non ordered location group as specified in a PredefinedLocationsPublication.
    /// <see href="http://vocab.datex.org/terms#predefinedNonOrderedLocationGroupReference"></see></summary>
    let predefinedNonOrderedLocationGroupReference =
        Namespaced_IRI.parse _namespace_name "predefinedNonOrderedLocationGroupReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_PredefinedNonOrderedLocationGroupVersionedReference"></see>
    /// </summary>
    let _PredefinedNonOrderedLocationGroupVersionedReference =
        Namespaced_IRI.parse _namespace_name "_PredefinedNonOrderedLocationGroupVersionedReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#nonOrderedLocationsExtension"></see>
    /// </summary>
    let nonOrderedLocationsExtension =
        Namespaced_IRI.parse _namespace_name "nonOrderedLocationsExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#nonRoadEventInformationExtension"></see>
    /// </summary>
    let nonRoadEventInformationExtension =
        Namespaced_IRI.parse _namespace_name "nonRoadEventInformationExtension" |> NamespacedName

    /// <summary>
    /// Road surface conditions that are not related to the weather but which may affect driving conditions.
    /// <see href="http://vocab.datex.org/terms#NonWeatherRelatedRoadConditions"></see></summary>
    let NonWeatherRelatedRoadConditions =
        Namespaced_IRI.parse _namespace_name "NonWeatherRelatedRoadConditions" |> NamespacedName

    /// <summary>
    /// The type of road conditions which are not related to the weather.
    /// <see href="http://vocab.datex.org/terms#nonWeatherRelatedRoadConditionType"></see></summary>
    let nonWeatherRelatedRoadConditionType =
        Namespaced_IRI.parse _namespace_name "nonWeatherRelatedRoadConditionType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#nonWeatherRelatedRoadConditionsExtension"></see>
    /// </summary>
    let nonWeatherRelatedRoadConditionsExtension =
        Namespaced_IRI.parse _namespace_name "nonWeatherRelatedRoadConditionsExtension" |> NamespacedName

    /// <summary>
    /// Conditions of the road surface which may affect driving conditions. These may be related to the weather (e.g. ice, snow etc.) or to other conditions (e.g. oil, mud, leaves etc. on the road)
    /// <see href="http://vocab.datex.org/terms#RoadConditions"></see></summary>
    let RoadConditions =
        Namespaced_IRI.parse _namespace_name "RoadConditions" |> NamespacedName

    /// <summary>
    /// Number of axles characteristic of a vehicle.
    /// <see href="http://vocab.datex.org/terms#NumberOfAxlesCharacteristic"></see></summary>
    let NumberOfAxlesCharacteristic =
        Namespaced_IRI.parse _namespace_name "NumberOfAxlesCharacteristic" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#numberOfAxles"></see>
    /// </summary>
    let numberOfAxles =
        Namespaced_IRI.parse _namespace_name "numberOfAxles" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#numberOfAxlesCharacteristicExtension"></see>
    /// </summary>
    let numberOfAxlesCharacteristicExtension =
        Namespaced_IRI.parse _namespace_name "numberOfAxlesCharacteristicExtension" |> NamespacedName

    /// <summary>
    /// The mobility of the obstruction.
    /// <see href="http://vocab.datex.org/terms#mobilityOfObstruction"></see></summary>
    let mobilityOfObstruction =
        Namespaced_IRI.parse _namespace_name "mobilityOfObstruction" |> NamespacedName

    /// <summary>
    /// The number of obstructions that are partly or wholly blocking the road.
    /// <see href="http://vocab.datex.org/terms#numberOfObstructions"></see></summary>
    let numberOfObstructions =
        Namespaced_IRI.parse _namespace_name "numberOfObstructions" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#obstructionExtension"></see>
    /// </summary>
    let obstructionExtension =
        Namespaced_IRI.parse _namespace_name "obstructionExtension" |> NamespacedName

    /// <summary>
    /// A measured or calculated value of change of occupied parking spaces expressed as integer.
    /// <see href="http://vocab.datex.org/terms#OccupancyChangeValue"></see></summary>
    let OccupancyChangeValue =
        Namespaced_IRI.parse _namespace_name "OccupancyChangeValue" |> NamespacedName

    /// <summary>
    /// A measured or calculated absolut change of occupied parking spaces within a specified time expressed as integer.
    /// <see href="http://vocab.datex.org/terms#occupancyChange"></see></summary>
    let occupancyChange =
        Namespaced_IRI.parse _namespace_name "occupancyChange" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#occupancyChangeValueExtension"></see>
    /// </summary>
    let occupancyChangeValueExtension =
        Namespaced_IRI.parse _namespace_name "occupancyChangeValueExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#offsetDistanceExtension"></see>
    /// </summary>
    let offsetDistanceExtension =
        Namespaced_IRI.parse _namespace_name "offsetDistanceExtension" |> NamespacedName

    /// <summary>
    /// A specification of opening times (e.g. for a parking site, a service facility, an access or the availability for equipment).
    /// <see href="http://vocab.datex.org/terms#OpeningTimes"></see></summary>
    let OpeningTimes =
        Namespaced_IRI.parse _namespace_name "OpeningTimes" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#lastUpdated"></see>
    /// </summary>
    let lastUpdated =
        Namespaced_IRI.parse _namespace_name "lastUpdated" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openAllYear"></see>
    /// </summary>
    let openAllYear =
        Namespaced_IRI.parse _namespace_name "openAllYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openingTimesExtension"></see>
    /// </summary>
    let openingTimesExtension =
        Namespaced_IRI.parse _namespace_name "openingTimesExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openingTimesNotSpecified"></see>
    /// </summary>
    let openingTimesNotSpecified =
        Namespaced_IRI.parse _namespace_name "openingTimesNotSpecified" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openingTimesUnknown"></see>
    /// </summary>
    let openingTimesUnknown =
        Namespaced_IRI.parse _namespace_name "openingTimesUnknown" |> NamespacedName

    /// <summary>
    /// a two-dimensional part of the surface of the earth which is bounded by a closed curve. An area location may cover parts of the road network but does not necessarily need to. It is represente according to the OpenLR standard for Area Locations
    /// <see href="http://vocab.datex.org/terms#OpenlrAreaLocationReference"></see></summary>
    let OpenlrAreaLocationReference =
        Namespaced_IRI.parse _namespace_name "OpenlrAreaLocationReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrAreaLocationReferenceExtension"></see>
    /// </summary>
    let openlrAreaLocationReferenceExtension =
        Namespaced_IRI.parse _namespace_name "openlrAreaLocationReferenceExtension" |> NamespacedName

    /// <summary>
    /// Base class used to hold data about a reference point.
    /// <see href="http://vocab.datex.org/terms#OpenlrBaseLocationReferencePoint"></see></summary>
    let OpenlrBaseLocationReferencePoint =
        Namespaced_IRI.parse _namespace_name "OpenlrBaseLocationReferencePoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrBaseLocationReferencePointExtension"></see>
    /// </summary>
    let openlrBaseLocationReferencePointExtension =
        Namespaced_IRI.parse _namespace_name "openlrBaseLocationReferencePointExtension" |> NamespacedName

    /// <summary>
    /// The coordinate of the actual point of interest
    /// <see href="http://vocab.datex.org/terms#openlrCoordinate"></see></summary>
    let openlrCoordinate =
        Namespaced_IRI.parse _namespace_name "openlrCoordinate" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrLineAttributes"></see>
    /// </summary>
    let openlrLineAttributes =
        Namespaced_IRI.parse _namespace_name "openlrLineAttributes" |> NamespacedName

    /// <summary>
    /// Line attributes are part of a location reference point and consists of functional road class (FRC),form of way (FOW) and bearing (BEAR) data.
    /// <see href="http://vocab.datex.org/terms#OpenlrLineAttributes"></see></summary>
    let OpenlrLineAttributes =
        Namespaced_IRI.parse _namespace_name "OpenlrLineAttributes" |> NamespacedName

    /// <summary>
    /// Holds common data that are used both in OpenlrPointAccessPoint and OpenlrPointAlongLine.
    /// <see href="http://vocab.datex.org/terms#OpenlrBasePointLocation"></see></summary>
    let OpenlrBasePointLocation =
        Namespaced_IRI.parse _namespace_name "OpenlrBasePointLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrBasePointLocationExtension"></see>
    /// </summary>
    let openlrBasePointLocationExtension =
        Namespaced_IRI.parse _namespace_name "openlrBasePointLocationExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrLastLocationReferencePoint"></see>
    /// </summary>
    let openlrLastLocationReferencePoint =
        Namespaced_IRI.parse _namespace_name "openlrLastLocationReferencePoint" |> NamespacedName

    /// <summary>
    /// The sequence of location reference points is terminated by a last location reference point.
    /// <see href="http://vocab.datex.org/terms#OpenlrLastLocationReferencePoint"></see></summary>
    let OpenlrLastLocationReferencePoint =
        Namespaced_IRI.parse _namespace_name "OpenlrLastLocationReferencePoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrLocationReferencePoint"></see>
    /// </summary>
    let openlrLocationReferencePoint =
        Namespaced_IRI.parse _namespace_name "openlrLocationReferencePoint" |> NamespacedName

    /// <summary>
    /// The basis of a location reference is a sequence of location reference points (LRPs).
    /// <see href="http://vocab.datex.org/terms#OpenlrLocationReferencePoint"></see></summary>
    let OpenlrLocationReferencePoint =
        Namespaced_IRI.parse _namespace_name "OpenlrLocationReferencePoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrOrientation"></see>
    /// </summary>
    let openlrOrientation =
        Namespaced_IRI.parse _namespace_name "openlrOrientation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrPositiveOffset"></see>
    /// </summary>
    let openlrPositiveOffset =
        Namespaced_IRI.parse _namespace_name "openlrPositiveOffset" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrSideOfRoad"></see>
    /// </summary>
    let openlrSideOfRoad =
        Namespaced_IRI.parse _namespace_name "openlrSideOfRoad" |> NamespacedName

    /// <summary>
    /// the openLR method of areadefinition by providing a center position and a radius
    /// <see href="http://vocab.datex.org/terms#OpenlrCircleLocationReference"></see></summary>
    let OpenlrCircleLocationReference =
        Namespaced_IRI.parse _namespace_name "OpenlrCircleLocationReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrCircleLocationReferenceExtension"></see>
    /// </summary>
    let openlrCircleLocationReferenceExtension =
        Namespaced_IRI.parse _namespace_name "openlrCircleLocationReferenceExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrGeoCoordinate"></see>
    /// </summary>
    let openlrGeoCoordinate =
        Namespaced_IRI.parse _namespace_name "openlrGeoCoordinate" |> NamespacedName

    /// <summary>
    /// A geo-coordinate pair is a position in a map defined by its longitude and latitude coordinate values.
    /// <see href="http://vocab.datex.org/terms#OpenlrGeoCoordinate"></see></summary>
    let OpenlrGeoCoordinate =
        Namespaced_IRI.parse _namespace_name "OpenlrGeoCoordinate" |> NamespacedName

    /// <summary>
    /// The radius of the geometric area identified.
    /// <see href="http://vocab.datex.org/terms#radius"></see></summary>
    let radius = Namespaced_IRI.parse _namespace_name "radius" |> NamespacedName

    /// <summary>
    /// the openLR method of areadefinition by providing a closed path (i.e. a circuit) in the road network. The boundary always consists of road segments
    /// <see href="http://vocab.datex.org/terms#OpenlrClosedLineLocationReference"></see></summary>
    let OpenlrClosedLineLocationReference =
        Namespaced_IRI.parse _namespace_name "OpenlrClosedLineLocationReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrClosedLineLocationReferenceExtension"></see>
    /// </summary>
    let openlrClosedLineLocationReferenceExtension =
        Namespaced_IRI.parse _namespace_name "openlrClosedLineLocationReferenceExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrLastLine"></see>
    /// </summary>
    let openlrLastLine =
        Namespaced_IRI.parse _namespace_name "openlrLastLine" |> NamespacedName

    /// <summary>
    /// Extension to provide Area information in openLR format
    /// <see href="http://vocab.datex.org/terms#OpenlrExtendedArea"></see></summary>
    let OpenlrExtendedArea =
        Namespaced_IRI.parse _namespace_name "OpenlrExtendedArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrAreaLocationReference"></see>
    /// </summary>
    let openlrAreaLocationReference =
        Namespaced_IRI.parse _namespace_name "openlrAreaLocationReference" |> NamespacedName

    /// <summary>
    /// Extension class for OpenLR Line location reference
    /// <see href="http://vocab.datex.org/terms#OpenlrExtendedLinear"></see></summary>
    let OpenlrExtendedLinear =
        Namespaced_IRI.parse _namespace_name "OpenlrExtendedLinear" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#firstDirection"></see>
    /// </summary>
    let firstDirection =
        Namespaced_IRI.parse _namespace_name "firstDirection" |> NamespacedName

    /// <summary>
    /// A LineLocationReference is defined by an ordered sequence of location reference points and a terminating last location reference point.
    /// <see href="http://vocab.datex.org/terms#OpenlrLineLocationReference"></see></summary>
    let OpenlrLineLocationReference =
        Namespaced_IRI.parse _namespace_name "OpenlrLineLocationReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#oppositeDirection"></see>
    /// </summary>
    let oppositeDirection =
        Namespaced_IRI.parse _namespace_name "oppositeDirection" |> NamespacedName

    /// <summary>
    /// Extension class for OpenLR point.
    /// <see href="http://vocab.datex.org/terms#OpenlrExtendedPoint"></see></summary>
    let OpenlrExtendedPoint =
        Namespaced_IRI.parse _namespace_name "OpenlrExtendedPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrPointLocationReference"></see>
    /// </summary>
    let openlrPointLocationReference =
        Namespaced_IRI.parse _namespace_name "openlrPointLocationReference" |> NamespacedName

    /// <summary>
    /// A point location is a zero-dimensional element in a map that specifies a geometric location.
    /// <see href="http://vocab.datex.org/terms#OpenlrPointLocationReference"></see></summary>
    let OpenlrPointLocationReference =
        Namespaced_IRI.parse _namespace_name "OpenlrPointLocationReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrGeoCoordinateExtension"></see>
    /// </summary>
    let openlrGeoCoordinateExtension =
        Namespaced_IRI.parse _namespace_name "openlrGeoCoordinateExtension" |> NamespacedName

    /// <summary>
    /// attributes required for the grid method
    /// <see href="http://vocab.datex.org/terms#OpenlrGridAttributes"></see></summary>
    let OpenlrGridAttributes =
        Namespaced_IRI.parse _namespace_name "OpenlrGridAttributes" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrGridAttributesExtension"></see>
    /// </summary>
    let openlrGridAttributesExtension =
        Namespaced_IRI.parse _namespace_name "openlrGridAttributesExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrNumColumns"></see>
    /// </summary>
    let openlrNumColumns =
        Namespaced_IRI.parse _namespace_name "openlrNumColumns" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrNumRows"></see>
    /// </summary>
    let openlrNumRows =
        Namespaced_IRI.parse _namespace_name "openlrNumRows" |> NamespacedName

    /// <summary>
    /// the openLR method of areadefinition by providing repeating rectangles
    /// <see href="http://vocab.datex.org/terms#OpenlrGridLocationReference"></see></summary>
    let OpenlrGridLocationReference =
        Namespaced_IRI.parse _namespace_name "OpenlrGridLocationReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrGridAttributes"></see>
    /// </summary>
    let openlrGridAttributes =
        Namespaced_IRI.parse _namespace_name "openlrGridAttributes" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrGridLocationReferenceExtension"></see>
    /// </summary>
    let openlrGridLocationReferenceExtension =
        Namespaced_IRI.parse _namespace_name "openlrGridLocationReferenceExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrRectangle"></see>
    /// </summary>
    let openlrRectangle =
        Namespaced_IRI.parse _namespace_name "openlrRectangle" |> NamespacedName

    /// <summary>
    /// two geo-coordinate pairs defining the rectangular
    /// <see href="http://vocab.datex.org/terms#OpenlrRectangle"></see></summary>
    let OpenlrRectangle =
        Namespaced_IRI.parse _namespace_name "OpenlrRectangle" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrLastLocationReferencePointExtension"></see>
    /// </summary>
    let openlrLastLocationReferencePointExtension =
        Namespaced_IRI.parse _namespace_name "openlrLastLocationReferencePointExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrBearing"></see>
    /// </summary>
    let openlrBearing =
        Namespaced_IRI.parse _namespace_name "openlrBearing" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrFormOfWay"></see>
    /// </summary>
    let openlrFormOfWay =
        Namespaced_IRI.parse _namespace_name "openlrFormOfWay" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrFunctionalRoadClass"></see>
    /// </summary>
    let openlrFunctionalRoadClass =
        Namespaced_IRI.parse _namespace_name "openlrFunctionalRoadClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrLineAttributesExtension"></see>
    /// </summary>
    let openlrLineAttributesExtension =
        Namespaced_IRI.parse _namespace_name "openlrLineAttributesExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrLineLocationReferenceExtension"></see>
    /// </summary>
    let openlrLineLocationReferenceExtension =
        Namespaced_IRI.parse _namespace_name "openlrLineLocationReferenceExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrOffsets"></see>
    /// </summary>
    let openlrOffsets =
        Namespaced_IRI.parse _namespace_name "openlrOffsets" |> NamespacedName

    /// <summary>
    /// Offsets are used to locate the start and end of a location more precisely than bounding to the nodes in a network.
    /// <see href="http://vocab.datex.org/terms#OpenlrOffsets"></see></summary>
    let OpenlrOffsets =
        Namespaced_IRI.parse _namespace_name "OpenlrOffsets" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrLocationReferencePointExtension"></see>
    /// </summary>
    let openlrLocationReferencePointExtension =
        Namespaced_IRI.parse _namespace_name "openlrLocationReferencePointExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrPathAttributes"></see>
    /// </summary>
    let openlrPathAttributes =
        Namespaced_IRI.parse _namespace_name "openlrPathAttributes" |> NamespacedName

    /// <summary>
    /// The field path attributes is part of a location reference point (except for the last location reference point) and consists of lowest functional road class (LFRCNP) and distance to next point (DNP) data.
    /// <see href="http://vocab.datex.org/terms#OpenlrPathAttributes"></see></summary>
    let OpenlrPathAttributes =
        Namespaced_IRI.parse _namespace_name "OpenlrPathAttributes" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrNegativeOffset"></see>
    /// </summary>
    let openlrNegativeOffset =
        Namespaced_IRI.parse _namespace_name "openlrNegativeOffset" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrOffsetsExtension"></see>
    /// </summary>
    let openlrOffsetsExtension =
        Namespaced_IRI.parse _namespace_name "openlrOffsetsExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrDistanceToNextLRPoint"></see>
    /// </summary>
    let openlrDistanceToNextLRPoint =
        Namespaced_IRI.parse _namespace_name "openlrDistanceToNextLRPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrLowestFRCToNextLRPoint"></see>
    /// </summary>
    let openlrLowestFRCToNextLRPoint =
        Namespaced_IRI.parse _namespace_name "openlrLowestFRCToNextLRPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrPathAttributesExtension"></see>
    /// </summary>
    let openlrPathAttributesExtension =
        Namespaced_IRI.parse _namespace_name "openlrPathAttributesExtension" |> NamespacedName

    /// <summary>
    /// Point along line with access is a point location which is defined by a line,an offset value and a coordinate.
    /// <see href="http://vocab.datex.org/terms#OpenlrPoiWithAccessPoint"></see></summary>
    let OpenlrPoiWithAccessPoint =
        Namespaced_IRI.parse _namespace_name "OpenlrPoiWithAccessPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrPoiWithAccessPointExtension"></see>
    /// </summary>
    let openlrPoiWithAccessPointExtension =
        Namespaced_IRI.parse _namespace_name "openlrPoiWithAccessPointExtension" |> NamespacedName

    /// <summary>
    /// Point along a line
    /// <see href="http://vocab.datex.org/terms#OpenlrPointAlongLine"></see></summary>
    let OpenlrPointAlongLine =
        Namespaced_IRI.parse _namespace_name "OpenlrPointAlongLine" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrPointAlongLineExtension"></see>
    /// </summary>
    let openlrPointAlongLineExtension =
        Namespaced_IRI.parse _namespace_name "openlrPointAlongLineExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrPoiWithAccessPoint"></see>
    /// </summary>
    let openlrPoiWithAccessPoint =
        Namespaced_IRI.parse _namespace_name "openlrPoiWithAccessPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrPointAlongLine"></see>
    /// </summary>
    let openlrPointAlongLine =
        Namespaced_IRI.parse _namespace_name "openlrPointAlongLine" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrPointLocationReferenceExtension"></see>
    /// </summary>
    let openlrPointLocationReferenceExtension =
        Namespaced_IRI.parse _namespace_name "openlrPointLocationReferenceExtension" |> NamespacedName

    /// <summary>
    /// geo-coordinate pairs. The coordinate pairs defining the corners of the underlying geometrical polygon.
    /// <see href="http://vocab.datex.org/terms#OpenlrPolygonCorners"></see></summary>
    let OpenlrPolygonCorners =
        Namespaced_IRI.parse _namespace_name "OpenlrPolygonCorners" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrPolygonCornersExtension"></see>
    /// </summary>
    let openlrPolygonCornersExtension =
        Namespaced_IRI.parse _namespace_name "openlrPolygonCornersExtension" |> NamespacedName

    /// <summary>
    /// the openLR method of areadefinition by providing points that bound the area
    /// <see href="http://vocab.datex.org/terms#OpenlrPolygonLocationReference"></see></summary>
    let OpenlrPolygonLocationReference =
        Namespaced_IRI.parse _namespace_name "OpenlrPolygonLocationReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrPolygonCorners"></see>
    /// </summary>
    let openlrPolygonCorners =
        Namespaced_IRI.parse _namespace_name "openlrPolygonCorners" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrPolygonLocationReferenceExtension"></see>
    /// </summary>
    let openlrPolygonLocationReferenceExtension =
        Namespaced_IRI.parse _namespace_name "openlrPolygonLocationReferenceExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrLowerLeft"></see>
    /// </summary>
    let openlrLowerLeft =
        Namespaced_IRI.parse _namespace_name "openlrLowerLeft" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrRectangleExtension"></see>
    /// </summary>
    let openlrRectangleExtension =
        Namespaced_IRI.parse _namespace_name "openlrRectangleExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrUpperRight"></see>
    /// </summary>
    let openlrUpperRight =
        Namespaced_IRI.parse _namespace_name "openlrUpperRight" |> NamespacedName

    /// <summary>
    /// the openLR method of areadefinition by providing a rectangular shape defined by two geo-coordinate pairs
    /// <see href="http://vocab.datex.org/terms#OpenlrRectangleLocationReference"></see></summary>
    let OpenlrRectangleLocationReference =
        Namespaced_IRI.parse _namespace_name "OpenlrRectangleLocationReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrRectangleLocationReferenceExtension"></see>
    /// </summary>
    let openlrRectangleLocationReferenceExtension =
        Namespaced_IRI.parse _namespace_name "openlrRectangleLocationReferenceExtension" |> NamespacedName

    /// <summary>
    /// Indicates whether the actions to be undertaken by the operator are the result of an internal operation or external influence.
    /// <see href="http://vocab.datex.org/terms#actionOrigin"></see></summary>
    let actionOrigin =
        Namespaced_IRI.parse _namespace_name "actionOrigin" |> NamespacedName

    /// <summary>
    /// The identifier of the traffic management action plan to which this action relates.
    /// <see href="http://vocab.datex.org/terms#actionPlanIdentifier"></see></summary>
    let actionPlanIdentifier =
        Namespaced_IRI.parse _namespace_name "actionPlanIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#operatorActionExtension"></see>
    /// </summary>
    let operatorActionExtension =
        Namespaced_IRI.parse _namespace_name "operatorActionExtension" |> NamespacedName

    /// <summary>
    /// The status of the defined operator action.
    /// <see href="http://vocab.datex.org/terms#operatorActionStatus"></see></summary>
    let operatorActionStatus =
        Namespaced_IRI.parse _namespace_name "operatorActionStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#exceptionPeriod"></see>
    /// </summary>
    let exceptionPeriod =
        Namespaced_IRI.parse _namespace_name "exceptionPeriod" |> NamespacedName

    /// <summary>
    /// A continuous time period or a set of discontinuous time periods defined by the intersection of a set of criteria all within an overall delimiting interval.
    /// <see href="http://vocab.datex.org/terms#Period"></see></summary>
    let Period = Namespaced_IRI.parse _namespace_name "Period" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#overallEndTime"></see>
    /// </summary>
    let overallEndTime =
        Namespaced_IRI.parse _namespace_name "overallEndTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#overallPeriodExtension"></see>
    /// </summary>
    let overallPeriodExtension =
        Namespaced_IRI.parse _namespace_name "overallPeriodExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#overallStartTime"></see>
    /// </summary>
    let overallStartTime =
        Namespaced_IRI.parse _namespace_name "overallStartTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#validPeriod"></see>
    /// </summary>
    let validPeriod =
        Namespaced_IRI.parse _namespace_name "validPeriod" |> NamespacedName

    /// <summary>
    /// Describes one entrance or exit (or both) to a parking site.
    /// <see href="http://vocab.datex.org/terms#ParkingAccess"></see></summary>
    let ParkingAccess =
        Namespaced_IRI.parse _namespace_name "ParkingAccess" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#accessAssignedAmongOthers"></see>
    /// </summary>
    let accessAssignedAmongOthers =
        Namespaced_IRI.parse _namespace_name "accessAssignedAmongOthers" |> NamespacedName

    /// <summary>
    /// One set of prohibited/only allowed/convenient assignment for parking space(s), parking site(s) or an access. Same kind of data forms a union (e.g. lorries OR buses), different kind of data forms an intersection (e.g. residents AND long-term).
    /// <see href="http://vocab.datex.org/terms#ParkingAssignment"></see></summary>
    let ParkingAssignment =
        Namespaced_IRI.parse _namespace_name "ParkingAssignment" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#accessCategory"></see>
    /// </summary>
    let accessCategory =
        Namespaced_IRI.parse _namespace_name "accessCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#accessEquipment"></see>
    /// </summary>
    let accessEquipment =
        Namespaced_IRI.parse _namespace_name "accessEquipment" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#accessName"></see>
    /// </summary>
    let accessName = Namespaced_IRI.parse _namespace_name "accessName" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#accessOnlyAssignedFor"></see>
    /// </summary>
    let accessOnlyAssignedFor =
        Namespaced_IRI.parse _namespace_name "accessOnlyAssignedFor" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#accessProhibitedFor"></see>
    /// </summary>
    let accessProhibitedFor =
        Namespaced_IRI.parse _namespace_name "accessProhibitedFor" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#accessibility"></see>
    /// </summary>
    let accessibility =
        Namespaced_IRI.parse _namespace_name "accessibility" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#location"></see>
    /// </summary>
    let location = Namespaced_IRI.parse _namespace_name "location" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openingTimes"></see>
    /// </summary>
    let openingTimes =
        Namespaced_IRI.parse _namespace_name "openingTimes" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingAccessExtension"></see>
    /// </summary>
    let parkingAccessExtension =
        Namespaced_IRI.parse _namespace_name "parkingAccessExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#photoUrl"></see>
    /// </summary>
    let photoUrl = Namespaced_IRI.parse _namespace_name "photoUrl" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#primaryRoad"></see>
    /// </summary>
    let primaryRoad =
        Namespaced_IRI.parse _namespace_name "primaryRoad" |> NamespacedName

    /// <summary>
    /// The opening and fault status of one access.
    /// <see href="http://vocab.datex.org/terms#ParkingAccessStatus"></see></summary>
    let ParkingAccessStatus =
        Namespaced_IRI.parse _namespace_name "ParkingAccessStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#accessFault"></see>
    /// </summary>
    let accessFault =
        Namespaced_IRI.parse _namespace_name "accessFault" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#accessOpeningStatus"></see>
    /// </summary>
    let accessOpeningStatus =
        Namespaced_IRI.parse _namespace_name "accessOpeningStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#accessReference"></see>
    /// </summary>
    let accessReference =
        Namespaced_IRI.parse _namespace_name "accessReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingAccessStatusExtension"></see>
    /// </summary>
    let parkingAccessStatusExtension =
        Namespaced_IRI.parse _namespace_name "parkingAccessStatusExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#hazardousMaterials"></see>
    /// </summary>
    let hazardousMaterials =
        Namespaced_IRI.parse _namespace_name "hazardousMaterials" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingAssignmentExtension"></see>
    /// </summary>
    let parkingAssignmentExtension =
        Namespaced_IRI.parse _namespace_name "parkingAssignmentExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingDuration"></see>
    /// </summary>
    let parkingDuration =
        Namespaced_IRI.parse _namespace_name "parkingDuration" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#timePeriodByHour"></see>
    /// </summary>
    let timePeriodByHour =
        Namespaced_IRI.parse _namespace_name "timePeriodByHour" |> NamespacedName

    /// <summary>
    /// Specification of a continuous period within a 24 hour period by times.
    /// <see href="http://vocab.datex.org/terms#TimePeriodByHour"></see></summary>
    let TimePeriodByHour =
        Namespaced_IRI.parse _namespace_name "TimePeriodByHour" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#additionalDescription"></see>
    /// </summary>
    let additionalDescription =
        Namespaced_IRI.parse _namespace_name "additionalDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#availability"></see>
    /// </summary>
    let availability =
        Namespaced_IRI.parse _namespace_name "availability" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#availabilityAndOpeningTimes"></see>
    /// </summary>
    let availabilityAndOpeningTimes =
        Namespaced_IRI.parse _namespace_name "availabilityAndOpeningTimes" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#equipmentOrServiceFacilityIdentifier"></see>
    /// </summary>
    let equipmentOrServiceFacilityIdentifier =
        Namespaced_IRI.parse _namespace_name "equipmentOrServiceFacilityIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#nameOrBrand"></see>
    /// </summary>
    let nameOrBrand =
        Namespaced_IRI.parse _namespace_name "nameOrBrand" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#numberOfEquipmentOrServiceFacility"></see>
    /// </summary>
    let numberOfEquipmentOrServiceFacility =
        Namespaced_IRI.parse _namespace_name "numberOfEquipmentOrServiceFacility" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#otherEquipmentOrServiceFacility"></see>
    /// </summary>
    let otherEquipmentOrServiceFacility =
        Namespaced_IRI.parse _namespace_name "otherEquipmentOrServiceFacility" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingEquipmentOrServiceFacilityExtension"></see>
    /// </summary>
    let parkingEquipmentOrServiceFacilityExtension =
        Namespaced_IRI.parse _namespace_name "parkingEquipmentOrServiceFacilityExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tariffsAndPayment"></see>
    /// </summary>
    let tariffsAndPayment =
        Namespaced_IRI.parse _namespace_name "tariffsAndPayment" |> NamespacedName

    /// <summary>
    /// A table of charges under various conditions, primary used for parking.
    /// <see href="http://vocab.datex.org/terms#TariffsAndPayment"></see></summary>
    let TariffsAndPayment =
        Namespaced_IRI.parse _namespace_name "TariffsAndPayment" |> NamespacedName

    /// <summary>
    /// The number of E&amp;S can be overridden here (for example during restoration). Furthermore, the current availability of E&amp;S can be given (for example number of free electric charging stations). The E&amp;S are identified from the static model by an index.
    /// <see href="http://vocab.datex.org/terms#ParkingEquipmentOrServiceFacilityStatus"></see></summary>
    let ParkingEquipmentOrServiceFacilityStatus =
        Namespaced_IRI.parse _namespace_name "ParkingEquipmentOrServiceFacilityStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#equipmentOperationStatus"></see>
    /// </summary>
    let equipmentOperationStatus =
        Namespaced_IRI.parse _namespace_name "equipmentOperationStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#numberOfEquipmentOrServiceFacilityOverride"></see>
    /// </summary>
    let numberOfEquipmentOrServiceFacilityOverride =
        Namespaced_IRI.parse _namespace_name "numberOfEquipmentOrServiceFacilityOverride" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#numberOfSubitemsOverride"></see>
    /// </summary>
    let numberOfSubitemsOverride =
        Namespaced_IRI.parse _namespace_name "numberOfSubitemsOverride" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingEquipmentOrServiceFacilityStatusExtension"></see>
    /// </summary>
    let parkingEquipmentOrServiceFacilityStatusExtension =
        Namespaced_IRI.parse _namespace_name "parkingEquipmentOrServiceFacilityStatusExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#serviceFacilityOpeningStatus"></see>
    /// </summary>
    let serviceFacilityOpeningStatus =
        Namespaced_IRI.parse _namespace_name "serviceFacilityOpeningStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vacantEquipmentOrServiceFacilitySubitems"></see>
    /// </summary>
    let vacantEquipmentOrServiceFacilitySubitems =
        Namespaced_IRI.parse _namespace_name "vacantEquipmentOrServiceFacilitySubitems" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingNotAllowed"></see>
    /// </summary>
    let parkingNotAllowed =
        Namespaced_IRI.parse _namespace_name "parkingNotAllowed" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingNumberOfOccupiedSpaces"></see>
    /// </summary>
    let parkingNumberOfOccupiedSpaces =
        Namespaced_IRI.parse _namespace_name "parkingNumberOfOccupiedSpaces" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingNumberOfSpacesOverride"></see>
    /// </summary>
    let parkingNumberOfSpacesOverride =
        Namespaced_IRI.parse _namespace_name "parkingNumberOfSpacesOverride" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingNumberOfVacantSpaces"></see>
    /// </summary>
    let parkingNumberOfVacantSpaces =
        Namespaced_IRI.parse _namespace_name "parkingNumberOfVacantSpaces" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingNumberOfVacantSpacesGraded"></see>
    /// </summary>
    let parkingNumberOfVacantSpacesGraded =
        Namespaced_IRI.parse _namespace_name "parkingNumberOfVacantSpacesGraded" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingNumberOfVacantSpacesHigherThan"></see>
    /// </summary>
    let parkingNumberOfVacantSpacesHigherThan =
        Namespaced_IRI.parse _namespace_name "parkingNumberOfVacantSpacesHigherThan" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingNumberOfVacantSpacesLowerThan"></see>
    /// </summary>
    let parkingNumberOfVacantSpacesLowerThan =
        Namespaced_IRI.parse _namespace_name "parkingNumberOfVacantSpacesLowerThan" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingNumberOfVehicles"></see>
    /// </summary>
    let parkingNumberOfVehicles =
        Namespaced_IRI.parse _namespace_name "parkingNumberOfVehicles" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingOccupancy"></see>
    /// </summary>
    let parkingOccupancy =
        Namespaced_IRI.parse _namespace_name "parkingOccupancy" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingOccupancyExtension"></see>
    /// </summary>
    let parkingOccupancyExtension =
        Namespaced_IRI.parse _namespace_name "parkingOccupancyExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingOccupancyGraded"></see>
    /// </summary>
    let parkingOccupancyGraded =
        Namespaced_IRI.parse _namespace_name "parkingOccupancyGraded" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingOccupancyTrend"></see>
    /// </summary>
    let parkingOccupancyTrend =
        Namespaced_IRI.parse _namespace_name "parkingOccupancyTrend" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleCountAndRate"></see>
    /// </summary>
    let vehicleCountAndRate =
        Namespaced_IRI.parse _namespace_name "vehicleCountAndRate" |> NamespacedName

    /// <summary>
    /// Vehicle rates can be assigned to a parking site or to assigned parking spaces. Furthermore, they can reference to a measurement site or to an entrance/exit.
    /// <see href="http://vocab.datex.org/terms#VehicleCountAndRate"></see></summary>
    let VehicleCountAndRate =
        Namespaced_IRI.parse _namespace_name "VehicleCountAndRate" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingPermitExtension"></see>
    /// </summary>
    let parkingPermitExtension =
        Namespaced_IRI.parse _namespace_name "parkingPermitExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingPermitIdentifier"></see>
    /// </summary>
    let parkingPermitIdentifier =
        Namespaced_IRI.parse _namespace_name "parkingPermitIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingPermitScheme"></see>
    /// </summary>
    let parkingPermitScheme =
        Namespaced_IRI.parse _namespace_name "parkingPermitScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingPermitType"></see>
    /// </summary>
    let parkingPermitType =
        Namespaced_IRI.parse _namespace_name "parkingPermitType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#assignedParkingAmongOthers"></see>
    /// </summary>
    let assignedParkingAmongOthers =
        Namespaced_IRI.parse _namespace_name "assignedParkingAmongOthers" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#emergencyAssemblyPoint"></see>
    /// </summary>
    let emergencyAssemblyPoint =
        Namespaced_IRI.parse _namespace_name "emergencyAssemblyPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#emergencyContact"></see>
    /// </summary>
    let emergencyContact =
        Namespaced_IRI.parse _namespace_name "emergencyContact" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#entireArea"></see>
    /// </summary>
    let entireArea = Namespaced_IRI.parse _namespace_name "entireArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#groupOfParkingSpaces"></see>
    /// </summary>
    let groupOfParkingSpaces =
        Namespaced_IRI.parse _namespace_name "groupOfParkingSpaces" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_GroupOfParkingSpaces"></see>
    /// </summary>
    let _GroupOfParkingSpaces =
        Namespaced_IRI.parse _namespace_name "_GroupOfParkingSpaces" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maximumParkingDuration"></see>
    /// </summary>
    let maximumParkingDuration =
        Namespaced_IRI.parse _namespace_name "maximumParkingDuration" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#onlyAssignedParking"></see>
    /// </summary>
    let onlyAssignedParking =
        Namespaced_IRI.parse _namespace_name "onlyAssignedParking" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#operator"></see>
    /// </summary>
    let operator = Namespaced_IRI.parse _namespace_name "operator" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#owner"></see>
    /// </summary>
    let owner = Namespaced_IRI.parse _namespace_name "owner" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingAlias"></see>
    /// </summary>
    let parkingAlias =
        Namespaced_IRI.parse _namespace_name "parkingAlias" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingColour"></see>
    /// </summary>
    let parkingColour =
        Namespaced_IRI.parse _namespace_name "parkingColour" |> NamespacedName

    /// <summary>
    /// An RGB colour described by values for red, green and blue (0..255) as well as an optional name.
    /// <see href="http://vocab.datex.org/terms#RGBColour"></see></summary>
    let RGBColour = Namespaced_IRI.parse _namespace_name "RGBColour" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingDescription"></see>
    /// </summary>
    let parkingDescription =
        Namespaced_IRI.parse _namespace_name "parkingDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingEquipmentOrServiceFacility"></see>
    /// </summary>
    let parkingEquipmentOrServiceFacility =
        Namespaced_IRI.parse _namespace_name "parkingEquipmentOrServiceFacility" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_ParkingRecordEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacility"></see>
    /// </summary>
    let _ParkingRecordEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacility =
        Namespaced_IRI.parse _namespace_name "_ParkingRecordEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacility" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingLocation"></see>
    /// </summary>
    let parkingLocation =
        Namespaced_IRI.parse _namespace_name "parkingLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingName"></see>
    /// </summary>
    let parkingName =
        Namespaced_IRI.parse _namespace_name "parkingName" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingOccupanyDetectionType"></see>
    /// </summary>
    let parkingOccupanyDetectionType =
        Namespaced_IRI.parse _namespace_name "parkingOccupanyDetectionType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingPrincipalNumberOfSpaces"></see>
    /// </summary>
    let parkingPrincipalNumberOfSpaces =
        Namespaced_IRI.parse _namespace_name "parkingPrincipalNumberOfSpaces" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingRecordDimension"></see>
    /// </summary>
    let parkingRecordDimension =
        Namespaced_IRI.parse _namespace_name "parkingRecordDimension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingRecordExtension"></see>
    /// </summary>
    let parkingRecordExtension =
        Namespaced_IRI.parse _namespace_name "parkingRecordExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingRecordVersionTime"></see>
    /// </summary>
    let parkingRecordVersionTime =
        Namespaced_IRI.parse _namespace_name "parkingRecordVersionTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingRoute"></see>
    /// </summary>
    let parkingRoute =
        Namespaced_IRI.parse _namespace_name "parkingRoute" |> NamespacedName

    /// <summary>
    /// A parking route, defined by ParkingRouteDetails or by a reference.
    /// <see href="http://vocab.datex.org/terms#ParkingRoute"></see></summary>
    let ParkingRoute =
        Namespaced_IRI.parse _namespace_name "ParkingRoute" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_ParkingSpace"></see>
    /// </summary>
    let _ParkingSpace =
        Namespaced_IRI.parse _namespace_name "_ParkingSpace" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingThresholds"></see>
    /// </summary>
    let parkingThresholds =
        Namespaced_IRI.parse _namespace_name "parkingThresholds" |> NamespacedName

    /// <summary>
    /// Configuration parameters of the parking site, used among others for the dynamic attribute 'parkingStatus'. This component or all elements of it can be overridden in the dynamic model.
    /// <see href="http://vocab.datex.org/terms#ParkingThresholds"></see></summary>
    let ParkingThresholds =
        Namespaced_IRI.parse _namespace_name "ParkingThresholds" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingVMS"></see>
    /// </summary>
    let parkingVMS = Namespaced_IRI.parse _namespace_name "parkingVMS" |> NamespacedName
    /// <summary>
    /// A reference to a record that contains the metadata for a specific VMS unit that may be used to manage the parking site (e.g. to indicate to drivers the current availability of spaces).
    /// <see href="http://vocab.datex.org/terms#ParkingVMS"></see></summary>
    let ParkingVMS = Namespaced_IRI.parse _namespace_name "ParkingVMS" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#permitsAndProhibitions"></see>
    /// </summary>
    let permitsAndProhibitions =
        Namespaced_IRI.parse _namespace_name "permitsAndProhibitions" |> NamespacedName

    /// <summary>
    /// Defines sets of action and regulations to specify permitted and prohibited issues.
    /// <see href="http://vocab.datex.org/terms#PermitsAndProhibitions"></see></summary>
    let PermitsAndProhibitions =
        Namespaced_IRI.parse _namespace_name "PermitsAndProhibitions" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#prohibitedParking"></see>
    /// </summary>
    let prohibitedParking =
        Namespaced_IRI.parse _namespace_name "prohibitedParking" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#responisbleAuthority"></see>
    /// </summary>
    let responisbleAuthority =
        Namespaced_IRI.parse _namespace_name "responisbleAuthority" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#securityService"></see>
    /// </summary>
    let securityService =
        Namespaced_IRI.parse _namespace_name "securityService" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#servicePartner"></see>
    /// </summary>
    let servicePartner =
        Namespaced_IRI.parse _namespace_name "servicePartner" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#blurredAvailability"></see>
    /// </summary>
    let blurredAvailability =
        Namespaced_IRI.parse _namespace_name "blurredAvailability" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#groupOfParkingSpacesStatus"></see>
    /// </summary>
    let groupOfParkingSpacesStatus =
        Namespaced_IRI.parse _namespace_name "groupOfParkingSpacesStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_ParkingRecordStatusGroupIndexGroupOfParkingSpacesStatus"></see>
    /// </summary>
    let _ParkingRecordStatusGroupIndexGroupOfParkingSpacesStatus =
        Namespaced_IRI.parse _namespace_name "_ParkingRecordStatusGroupIndexGroupOfParkingSpacesStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#overrideParkingThresholds"></see>
    /// </summary>
    let overrideParkingThresholds =
        Namespaced_IRI.parse _namespace_name "overrideParkingThresholds" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingAccessStatus"></see>
    /// </summary>
    let parkingAccessStatus =
        Namespaced_IRI.parse _namespace_name "parkingAccessStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingConditions"></see>
    /// </summary>
    let parkingConditions =
        Namespaced_IRI.parse _namespace_name "parkingConditions" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingEquipmentOrServiceFacilityStatus"></see>
    /// </summary>
    let parkingEquipmentOrServiceFacilityStatus =
        Namespaced_IRI.parse _namespace_name "parkingEquipmentOrServiceFacilityStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_ParkingRecordStatusEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacilityStatus"></see>
    /// </summary>
    let _ParkingRecordStatusEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacilityStatus =
        Namespaced_IRI.parse _namespace_name "_ParkingRecordStatusEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacilityStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingFault"></see>
    /// </summary>
    let parkingFault =
        Namespaced_IRI.parse _namespace_name "parkingFault" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingQueueingTime"></see>
    /// </summary>
    let parkingQueueingTime =
        Namespaced_IRI.parse _namespace_name "parkingQueueingTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingRecordReference"></see>
    /// </summary>
    let parkingRecordReference =
        Namespaced_IRI.parse _namespace_name "parkingRecordReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingRecordStatusExtension"></see>
    /// </summary>
    let parkingRecordStatusExtension =
        Namespaced_IRI.parse _namespace_name "parkingRecordStatusExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingRouteStatus"></see>
    /// </summary>
    let parkingRouteStatus =
        Namespaced_IRI.parse _namespace_name "parkingRouteStatus" |> NamespacedName

    /// <summary>
    /// The status of a parking route (active/inactive) defined in the static part of the model.
    /// <see href="http://vocab.datex.org/terms#ParkingRouteStatus"></see></summary>
    let ParkingRouteStatus =
        Namespaced_IRI.parse _namespace_name "ParkingRouteStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSpaceStatus"></see>
    /// </summary>
    let parkingSpaceStatus =
        Namespaced_IRI.parse _namespace_name "parkingSpaceStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_ParkingRecordStatusParkingSpaceIndexParkingSpaceStatus"></see>
    /// </summary>
    let _ParkingRecordStatusParkingSpaceIndexParkingSpaceStatus =
        Namespaced_IRI.parse _namespace_name "_ParkingRecordStatusParkingSpaceIndexParkingSpaceStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingStatusDescription"></see>
    /// </summary>
    let parkingStatusDescription =
        Namespaced_IRI.parse _namespace_name "parkingStatusDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingStatusOriginTime"></see>
    /// </summary>
    let parkingStatusOriginTime =
        Namespaced_IRI.parse _namespace_name "parkingStatusOriginTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingStatusValidity"></see>
    /// </summary>
    let parkingStatusValidity =
        Namespaced_IRI.parse _namespace_name "parkingStatusValidity" |> NamespacedName

    /// <summary>
    /// To be used only for historical or forecasted data. Choose between an explicit point of time, an offset or all points of time within a specified period.
    /// <see href="http://vocab.datex.org/terms#ParkingStatusValidity"></see></summary>
    let ParkingStatusValidity =
        Namespaced_IRI.parse _namespace_name "ParkingStatusValidity" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingUsageScenarioStatus"></see>
    /// </summary>
    let parkingUsageScenarioStatus =
        Namespaced_IRI.parse _namespace_name "parkingUsageScenarioStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_ParkingRecordStatusScenarioIndexParkingUsageScenarioStatus"></see>
    /// </summary>
    let _ParkingRecordStatusScenarioIndexParkingUsageScenarioStatus =
        Namespaced_IRI.parse _namespace_name "_ParkingRecordStatusScenarioIndexParkingUsageScenarioStatus" |> NamespacedName

    /// <summary>
    /// Type of winter equipment management action instigated by operator.
    /// <see href="http://vocab.datex.org/terms#winterEquipmentManagementType"></see></summary>
    let winterEquipmentManagementType =
        Namespaced_IRI.parse _namespace_name "winterEquipmentManagementType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingRouteColour"></see>
    /// </summary>
    let parkingRouteColour =
        Namespaced_IRI.parse _namespace_name "parkingRouteColour" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingRouteExtension"></see>
    /// </summary>
    let parkingRouteExtension =
        Namespaced_IRI.parse _namespace_name "parkingRouteExtension" |> NamespacedName

    /// <summary>
    /// A route defined by a reference to an earlier specified route.
    /// <see href="http://vocab.datex.org/terms#ParkingRouteByReference"></see></summary>
    let ParkingRouteByReference =
        Namespaced_IRI.parse _namespace_name "ParkingRouteByReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingRouteByReferenceExtension"></see>
    /// </summary>
    let parkingRouteByReferenceExtension =
        Namespaced_IRI.parse _namespace_name "parkingRouteByReferenceExtension" |> NamespacedName

    /// <summary>
    /// A reference to a parking route.
    /// <see href="http://vocab.datex.org/terms#parkingRouteReference"></see></summary>
    let parkingRouteReference =
        Namespaced_IRI.parse _namespace_name "parkingRouteReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_ParkingRouteDetailsVersionedReference"></see>
    /// </summary>
    let _ParkingRouteDetailsVersionedReference =
        Namespaced_IRI.parse _namespace_name "_ParkingRouteDetailsVersionedReference" |> NamespacedName

    /// <summary>
    /// Urban context: Defining parking routes leading to the parking site. Truck parking context: Can be used to define a dynamic route management.
    /// <see href="http://vocab.datex.org/terms#ParkingRouteDetails"></see></summary>
    let ParkingRouteDetails =
        Namespaced_IRI.parse _namespace_name "ParkingRouteDetails" |> NamespacedName

    /// <summary>
    /// Indicates that there is dynamic route management for truck parking, i.e. a management system concerning several truck parkings (including this one) along a route.
    /// <see href="http://vocab.datex.org/terms#dynamicRouteManagement"></see></summary>
    let dynamicRouteManagement =
        Namespaced_IRI.parse _namespace_name "dynamicRouteManagement" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingRouteDetailsExtension"></see>
    /// </summary>
    let parkingRouteDetailsExtension =
        Namespaced_IRI.parse _namespace_name "parkingRouteDetailsExtension" |> NamespacedName

    /// <summary>
    /// The direction of traffic, for which the parking route can be used. If not specified, the route can be used in the order of the given locations.
    /// <see href="http://vocab.datex.org/terms#parkingRouteDirection"></see></summary>
    let parkingRouteDirection =
        Namespaced_IRI.parse _namespace_name "parkingRouteDirection" |> NamespacedName

    /// <summary>
    /// Additional directions of traffic, for which the parking route can be used. If not specified, the route can be used in the order of the given locations.
    /// <see href="http://vocab.datex.org/terms#parkingRouteDirection2"></see></summary>
    let parkingRouteDirection2 =
        Namespaced_IRI.parse _namespace_name "parkingRouteDirection2" |> NamespacedName

    /// <summary>
    /// An index, which can identify some icon for visualisation of the route. Note that form and usage of this index as well as the icons itself are not further determined here.
    /// <see href="http://vocab.datex.org/terms#parkingRouteIconIndex"></see></summary>
    let parkingRouteIconIndex =
        Namespaced_IRI.parse _namespace_name "parkingRouteIconIndex" |> NamespacedName

    /// <summary>
    /// Name of the parking route.
    /// <see href="http://vocab.datex.org/terms#parkingRouteName"></see></summary>
    let parkingRouteName =
        Namespaced_IRI.parse _namespace_name "parkingRouteName" |> NamespacedName

    /// <summary>
    /// The type of parking route. If not specified, the route is designed for any type of vehicles.
    /// <see href="http://vocab.datex.org/terms#parkingRouteType"></see></summary>
    let parkingRouteType =
        Namespaced_IRI.parse _namespace_name "parkingRouteType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingRouteActive"></see>
    /// </summary>
    let parkingRouteActive =
        Namespaced_IRI.parse _namespace_name "parkingRouteActive" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingRouteStatusExtension"></see>
    /// </summary>
    let parkingRouteStatusExtension =
        Namespaced_IRI.parse _namespace_name "parkingRouteStatusExtension" |> NamespacedName

    /// <summary>
    /// Highest floor of the parking site. It is possible to have negative values here in case it is underground only. Must be higher or equal than 'lowestFloor'.
    /// <see href="http://vocab.datex.org/terms#highestFloor"></see></summary>
    let highestFloor =
        Namespaced_IRI.parse _namespace_name "highestFloor" |> NamespacedName

    /// <summary>
    /// Lowest floor of the parking site. Positive values may apply in case it is over ground only. Must be lower or equal than 'highestFloor'.
    /// <see href="http://vocab.datex.org/terms#lowestFloor"></see></summary>
    let lowestFloor =
        Namespaced_IRI.parse _namespace_name "lowestFloor" |> NamespacedName

    /// <summary>
    /// An exit from the parking facility onto the road network from any parking space unless separate exits are specified for assigned parking spaces, in which case this is an exit from only the principal parking spaces.
    /// <see href="http://vocab.datex.org/terms#parkingAccess"></see></summary>
    let parkingAccess =
        Namespaced_IRI.parse _namespace_name "parkingAccess" |> NamespacedName

    /// <summary>
    /// Layout of the parking site.
    /// <see href="http://vocab.datex.org/terms#parkingLayout"></see></summary>
    let parkingLayout =
        Namespaced_IRI.parse _namespace_name "parkingLayout" |> NamespacedName

    /// <summary>
    /// Indication of whether a parking reservation service is available and/or mandatory.
    /// <see href="http://vocab.datex.org/terms#parkingReservation"></see></summary>
    let parkingReservation =
        Namespaced_IRI.parse _namespace_name "parkingReservation" |> NamespacedName

    /// <summary>
    /// Information about the parking site itself (address etc.). The 'GroupOfLocations' association must not be used for this role.
    /// <see href="http://vocab.datex.org/terms#parkingSiteAddress"></see></summary>
    let parkingSiteAddress =
        Namespaced_IRI.parse _namespace_name "parkingSiteAddress" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSiteExtension"></see>
    /// </summary>
    let parkingSiteExtension =
        Namespaced_IRI.parse _namespace_name "parkingSiteExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingStandardsAndSecurity"></see>
    /// </summary>
    let parkingStandardsAndSecurity =
        Namespaced_IRI.parse _namespace_name "parkingStandardsAndSecurity" |> NamespacedName

    /// <summary>
    /// Security measures and standards or standard-like categorization for a parking site.
    /// <see href="http://vocab.datex.org/terms#ParkingStandardsAndSecurity"></see></summary>
    let ParkingStandardsAndSecurity =
        Namespaced_IRI.parse _namespace_name "ParkingStandardsAndSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingUsageScenario"></see>
    /// </summary>
    let parkingUsageScenario =
        Namespaced_IRI.parse _namespace_name "parkingUsageScenario" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_ParkingSiteScenarioIndexParkingUsageScenario"></see>
    /// </summary>
    let _ParkingSiteScenarioIndexParkingUsageScenario =
        Namespaced_IRI.parse _namespace_name "_ParkingSiteScenarioIndexParkingUsageScenario" |> NamespacedName

    /// <summary>
    /// Reservation service (for end users). It is recommended to give URL and telephone.
    /// <see href="http://vocab.datex.org/terms#reservationService"></see></summary>
    let reservationService =
        Namespaced_IRI.parse _namespace_name "reservationService" |> NamespacedName

    /// <summary>
    /// Indicates that the parking site is on a temporary basis. It might close permanently within short notice or might only be partial equipped. The physical parking possibilities might be provisional, too.
    /// <see href="http://vocab.datex.org/terms#temporaryParking"></see></summary>
    let temporaryParking =
        Namespaced_IRI.parse _namespace_name "temporaryParking" |> NamespacedName

    /// <summary>
    /// Dynamic status information for the static object 'ParkingSite'.
    /// <see href="http://vocab.datex.org/terms#ParkingSiteStatus"></see></summary>
    let ParkingSiteStatus =
        Namespaced_IRI.parse _namespace_name "ParkingSiteStatus" |> NamespacedName

    /// <summary>
    /// The parking site is full at the specified floor(s).
    /// <see href="http://vocab.datex.org/terms#parkingSiteFullAtFloor"></see></summary>
    let parkingSiteFullAtFloor =
        Namespaced_IRI.parse _namespace_name "parkingSiteFullAtFloor" |> NamespacedName

    /// <summary>
    /// The opening status of the parking site (open or not).
    /// <see href="http://vocab.datex.org/terms#parkingSiteOpeningStatus"></see></summary>
    let parkingSiteOpeningStatus =
        Namespaced_IRI.parse _namespace_name "parkingSiteOpeningStatus" |> NamespacedName

    /// <summary>
    /// The overcrowding status of the parking site. Choose between using a two-stage approach or the more general statement ‘(not) overcrowding’. You can sharpen this information by using the ‘Thresholds’ component.
    /// <see href="http://vocab.datex.org/terms#parkingSiteOvercrowdingStatus"></see></summary>
    let parkingSiteOvercrowdingStatus =
        Namespaced_IRI.parse _namespace_name "parkingSiteOvercrowdingStatus" |> NamespacedName

    /// <summary>
    /// The status of the parking site (spaces available or not).
    /// <see href="http://vocab.datex.org/terms#parkingSiteStatus"></see></summary>
    let parkingSiteStatus =
        Namespaced_IRI.parse _namespace_name "parkingSiteStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSiteStatusExtension"></see>
    /// </summary>
    let parkingSiteStatusExtension =
        Namespaced_IRI.parse _namespace_name "parkingSiteStatusExtension" |> NamespacedName

    /// <summary>
    /// A single parking space. It is possible to define the same parking space more than once with different properties, e.g. when there is a different parking assignment for different times.
    /// <see href="http://vocab.datex.org/terms#ParkingSpace"></see></summary>
    let ParkingSpace =
        Namespaced_IRI.parse _namespace_name "ParkingSpace" |> NamespacedName

    /// <summary>
    /// Points to another instance of 'ParkingSpace', which is identical from a local point of view (i.e. which is the same parking space). To be used when defining mixed parking areas (with using different time slots).
    /// <see href="http://vocab.datex.org/terms#identicalToParkingSpace"></see></summary>
    let identicalToParkingSpace =
        Namespaced_IRI.parse _namespace_name "identicalToParkingSpace" |> NamespacedName

    /// <summary>
    /// Dimension of the parking space (not all dimension attributes need to be provided). If the parking space is not rectangular, its dimension is specified as the smallest rectangle fitting inside its shape.
    /// <see href="http://vocab.datex.org/terms#parkingSpaceDimension"></see></summary>
    let parkingSpaceDimension =
        Namespaced_IRI.parse _namespace_name "parkingSpaceDimension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSpaceExtension"></see>
    /// </summary>
    let parkingSpaceExtension =
        Namespaced_IRI.parse _namespace_name "parkingSpaceExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#distanceFromPrimaryRoad"></see>
    /// </summary>
    let distanceFromPrimaryRoad =
        Namespaced_IRI.parse _namespace_name "distanceFromPrimaryRoad" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_ParkingSpaceBasicsEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacility"></see>
    /// </summary>
    let _ParkingSpaceBasicsEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacility =
        Namespaced_IRI.parse _namespace_name "_ParkingSpaceBasicsEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacility" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingFloorOrLevel"></see>
    /// </summary>
    let parkingFloorOrLevel =
        Namespaced_IRI.parse _namespace_name "parkingFloorOrLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingMode"></see>
    /// </summary>
    let parkingMode =
        Namespaced_IRI.parse _namespace_name "parkingMode" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSecurity"></see>
    /// </summary>
    let parkingSecurity =
        Namespaced_IRI.parse _namespace_name "parkingSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSpaceAccessibility"></see>
    /// </summary>
    let parkingSpaceAccessibility =
        Namespaced_IRI.parse _namespace_name "parkingSpaceAccessibility" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSpaceBasicsExtension"></see>
    /// </summary>
    let parkingSpaceBasicsExtension =
        Namespaced_IRI.parse _namespace_name "parkingSpaceBasicsExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSpaceOrGroupIdentifier"></see>
    /// </summary>
    let parkingSpaceOrGroupIdentifier =
        Namespaced_IRI.parse _namespace_name "parkingSpaceOrGroupIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSpacePhysics"></see>
    /// </summary>
    let parkingSpacePhysics =
        Namespaced_IRI.parse _namespace_name "parkingSpacePhysics" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_ParkingSpaceBasicsScenarioIndexParkingUsageScenario"></see>
    /// </summary>
    let _ParkingSpaceBasicsScenarioIndexParkingUsageScenario =
        Namespaced_IRI.parse _namespace_name "_ParkingSpaceBasicsScenarioIndexParkingUsageScenario" |> NamespacedName

    /// <summary>
    /// Status (occupied or closed) for a single parking space which was defined in the static part of the model.
    /// <see href="http://vocab.datex.org/terms#ParkingSpaceStatus"></see></summary>
    let ParkingSpaceStatus =
        Namespaced_IRI.parse _namespace_name "ParkingSpaceStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#lastCalibration"></see>
    /// </summary>
    let lastCalibration =
        Namespaced_IRI.parse _namespace_name "lastCalibration" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSpaceClosed"></see>
    /// </summary>
    let parkingSpaceClosed =
        Namespaced_IRI.parse _namespace_name "parkingSpaceClosed" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSpaceDeclarationValidNow"></see>
    /// </summary>
    let parkingSpaceDeclarationValidNow =
        Namespaced_IRI.parse _namespace_name "parkingSpaceDeclarationValidNow" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSpaceOccupied"></see>
    /// </summary>
    let parkingSpaceOccupied =
        Namespaced_IRI.parse _namespace_name "parkingSpaceOccupied" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSpaceStatusExtension"></see>
    /// </summary>
    let parkingSpaceStatusExtension =
        Namespaced_IRI.parse _namespace_name "parkingSpaceStatusExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#certifiedSecureParking"></see>
    /// </summary>
    let certifiedSecureParking =
        Namespaced_IRI.parse _namespace_name "certifiedSecureParking" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#dateOfCertification"></see>
    /// </summary>
    let dateOfCertification =
        Namespaced_IRI.parse _namespace_name "dateOfCertification" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#labelSecurityLevel"></see>
    /// </summary>
    let labelSecurityLevel =
        Namespaced_IRI.parse _namespace_name "labelSecurityLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#labelSecurityLevelSelfAssessment"></see>
    /// </summary>
    let labelSecurityLevelSelfAssessment =
        Namespaced_IRI.parse _namespace_name "labelSecurityLevelSelfAssessment" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#labelServiceLevel"></see>
    /// </summary>
    let labelServiceLevel =
        Namespaced_IRI.parse _namespace_name "labelServiceLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#labelServiceLevelSelfAssessment"></see>
    /// </summary>
    let labelServiceLevelSelfAssessment =
        Namespaced_IRI.parse _namespace_name "labelServiceLevelSelfAssessment" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingAdditionalSecurity"></see>
    /// </summary>
    let parkingAdditionalSecurity =
        Namespaced_IRI.parse _namespace_name "parkingAdditionalSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSecurityNationalClassification"></see>
    /// </summary>
    let parkingSecurityNationalClassification =
        Namespaced_IRI.parse _namespace_name "parkingSecurityNationalClassification" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingStandardsAndSecurityExtension"></see>
    /// </summary>
    let parkingStandardsAndSecurityExtension =
        Namespaced_IRI.parse _namespace_name "parkingStandardsAndSecurityExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSupervision"></see>
    /// </summary>
    let parkingSupervision =
        Namespaced_IRI.parse _namespace_name "parkingSupervision" |> NamespacedName

    /// <summary>
    /// Defines a pair of 'parkingSiteStatus' and a corresponding colour.
    /// <see href="http://vocab.datex.org/terms#ParkingStatusColourMapping"></see></summary>
    let ParkingStatusColourMapping =
        Namespaced_IRI.parse _namespace_name "ParkingStatusColourMapping" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingStatusColourMappingExtension"></see>
    /// </summary>
    let parkingStatusColourMappingExtension =
        Namespaced_IRI.parse _namespace_name "parkingStatusColourMappingExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#rgbColour"></see>
    /// </summary>
    let rgbColour = Namespaced_IRI.parse _namespace_name "rgbColour" |> NamespacedName

    /// <summary>
    /// A publication containing the current status of one or more parking sites and/or group of parking sites.
    /// <see href="http://vocab.datex.org/terms#ParkingStatusPublication"></see></summary>
    let ParkingStatusPublication =
        Namespaced_IRI.parse _namespace_name "ParkingStatusPublication" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingRecordStatus"></see>
    /// </summary>
    let parkingRecordStatus =
        Namespaced_IRI.parse _namespace_name "parkingRecordStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingTableReference"></see>
    /// </summary>
    let parkingTableReference =
        Namespaced_IRI.parse _namespace_name "parkingTableReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_ParkingTableVersionedReference"></see>
    /// </summary>
    let _ParkingTableVersionedReference =
        Namespaced_IRI.parse _namespace_name "_ParkingTableVersionedReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingStatusTime"></see>
    /// </summary>
    let parkingStatusTime =
        Namespaced_IRI.parse _namespace_name "parkingStatusTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingStatusTimeOffsetToOrigin"></see>
    /// </summary>
    let parkingStatusTimeOffsetToOrigin =
        Namespaced_IRI.parse _namespace_name "parkingStatusTimeOffsetToOrigin" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingStatusValidityExtension"></see>
    /// </summary>
    let parkingStatusValidityExtension =
        Namespaced_IRI.parse _namespace_name "parkingStatusValidityExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#validityTimeSpecification"></see>
    /// </summary>
    let validityTimeSpecification =
        Namespaced_IRI.parse _namespace_name "validityTimeSpecification" |> NamespacedName

    /// <summary>
    /// A collection of parking records, which can be parking sites or groups of parking sites.
    /// <see href="http://vocab.datex.org/terms#ParkingTable"></see></summary>
    let ParkingTable =
        Namespaced_IRI.parse _namespace_name "ParkingTable" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingRecord"></see>
    /// </summary>
    let parkingRecord =
        Namespaced_IRI.parse _namespace_name "parkingRecord" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingTableExtension"></see>
    /// </summary>
    let parkingTableExtension =
        Namespaced_IRI.parse _namespace_name "parkingTableExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingTableName"></see>
    /// </summary>
    let parkingTableName =
        Namespaced_IRI.parse _namespace_name "parkingTableName" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingTableVersionTime"></see>
    /// </summary>
    let parkingTableVersionTime =
        Namespaced_IRI.parse _namespace_name "parkingTableVersionTime" |> NamespacedName

    /// <summary>
    /// A publication defining one or more tables that have entries of parking sites or groups of them, located in an urban or interurban context.
    /// <see href="http://vocab.datex.org/terms#ParkingTablePublication"></see></summary>
    let ParkingTablePublication =
        Namespaced_IRI.parse _namespace_name "ParkingTablePublication" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingTable"></see>
    /// </summary>
    let parkingTable =
        Namespaced_IRI.parse _namespace_name "parkingTable" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#almostFullDecreasing"></see>
    /// </summary>
    let almostFullDecreasing =
        Namespaced_IRI.parse _namespace_name "almostFullDecreasing" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#almostFullIncreasing"></see>
    /// </summary>
    let almostFullIncreasing =
        Namespaced_IRI.parse _namespace_name "almostFullIncreasing" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#entranceFull"></see>
    /// </summary>
    let entranceFull =
        Namespaced_IRI.parse _namespace_name "entranceFull" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#fullDecreasing"></see>
    /// </summary>
    let fullDecreasing =
        Namespaced_IRI.parse _namespace_name "fullDecreasing" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#fullIncreasing"></see>
    /// </summary>
    let fullIncreasing =
        Namespaced_IRI.parse _namespace_name "fullIncreasing" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#overcrowding"></see>
    /// </summary>
    let overcrowding =
        Namespaced_IRI.parse _namespace_name "overcrowding" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#overcrowdingLevel1"></see>
    /// </summary>
    let overcrowdingLevel1 =
        Namespaced_IRI.parse _namespace_name "overcrowdingLevel1" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#overcrowdingLevel2"></see>
    /// </summary>
    let overcrowdingLevel2 =
        Namespaced_IRI.parse _namespace_name "overcrowdingLevel2" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingLastMaximumOccupancy"></see>
    /// </summary>
    let parkingLastMaximumOccupancy =
        Namespaced_IRI.parse _namespace_name "parkingLastMaximumOccupancy" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingStatusColourMapping"></see>
    /// </summary>
    let parkingStatusColourMapping =
        Namespaced_IRI.parse _namespace_name "parkingStatusColourMapping" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingThresholdsExtension"></see>
    /// </summary>
    let parkingThresholdsExtension =
        Namespaced_IRI.parse _namespace_name "parkingThresholdsExtension" |> NamespacedName

    /// <summary>
    /// A special type of usage available for the parking site or the group of parking spaces. In the 'ParkingStatusPublication', the operation type (in operation or not) can be defined.
    /// <see href="http://vocab.datex.org/terms#ParkingUsageScenario"></see></summary>
    let ParkingUsageScenario =
        Namespaced_IRI.parse _namespace_name "ParkingUsageScenario" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#eventParkingType"></see>
    /// </summary>
    let eventParkingType =
        Namespaced_IRI.parse _namespace_name "eventParkingType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#eventParkingType2"></see>
    /// </summary>
    let eventParkingType2 =
        Namespaced_IRI.parse _namespace_name "eventParkingType2" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingUsageScenarioExtension"></see>
    /// </summary>
    let parkingUsageScenarioExtension =
        Namespaced_IRI.parse _namespace_name "parkingUsageScenarioExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#scenarioAvailability"></see>
    /// </summary>
    let scenarioAvailability =
        Namespaced_IRI.parse _namespace_name "scenarioAvailability" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#truckParkingDynamicManagement"></see>
    /// </summary>
    let truckParkingDynamicManagement =
        Namespaced_IRI.parse _namespace_name "truckParkingDynamicManagement" |> NamespacedName

    /// <summary>
    /// The current status for this parking usage scenario.
    /// <see href="http://vocab.datex.org/terms#ParkingUsageScenarioStatus"></see></summary>
    let ParkingUsageScenarioStatus =
        Namespaced_IRI.parse _namespace_name "ParkingUsageScenarioStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingUsageScenarioStatusExtension"></see>
    /// </summary>
    let parkingUsageScenarioStatusExtension =
        Namespaced_IRI.parse _namespace_name "parkingUsageScenarioStatusExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#usageScenarioOperationStatus"></see>
    /// </summary>
    let usageScenarioOperationStatus =
        Namespaced_IRI.parse _namespace_name "usageScenarioOperationStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingVMSExtension"></see>
    /// </summary>
    let parkingVMSExtension =
        Namespaced_IRI.parse _namespace_name "parkingVMSExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsOperator"></see>
    /// </summary>
    let vmsOperator =
        Namespaced_IRI.parse _namespace_name "vmsOperator" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsUnitUsedToManageParking"></see>
    /// </summary>
    let vmsUnitUsedToManageParking =
        Namespaced_IRI.parse _namespace_name "vmsUnitUsedToManageParking" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_VmsUnitRecordVersionedReference"></see>
    /// </summary>
    let _VmsUnitRecordVersionedReference =
        Namespaced_IRI.parse _namespace_name "_VmsUnitRecordVersionedReference" |> NamespacedName

    /// <summary>
    /// Information about one individual parking vehicle.
    /// <see href="http://vocab.datex.org/terms#ParkingVehicle"></see></summary>
    let ParkingVehicle =
        Namespaced_IRI.parse _namespace_name "ParkingVehicle" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#groupOfParkingSpacesReference"></see>
    /// </summary>
    let groupOfParkingSpacesReference =
        Namespaced_IRI.parse _namespace_name "groupOfParkingSpacesReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#individualCharge"></see>
    /// </summary>
    let individualCharge =
        Namespaced_IRI.parse _namespace_name "individualCharge" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingPeriod"></see>
    /// </summary>
    let parkingPeriod =
        Namespaced_IRI.parse _namespace_name "parkingPeriod" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSpaceReference"></see>
    /// </summary>
    let parkingSpaceReference =
        Namespaced_IRI.parse _namespace_name "parkingSpaceReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingVehicleExtension"></see>
    /// </summary>
    let parkingVehicleExtension =
        Namespaced_IRI.parse _namespace_name "parkingVehicleExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicle"></see>
    /// </summary>
    let vehicle = Namespaced_IRI.parse _namespace_name "vehicle" |> NamespacedName

    /// <summary>
    /// Information about individual parking vehicles.
    /// <see href="http://vocab.datex.org/terms#ParkingVehiclesPublication"></see></summary>
    let ParkingVehiclesPublication =
        Namespaced_IRI.parse _namespace_name "ParkingVehiclesPublication" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingVehicle"></see>
    /// </summary>
    let parkingVehicle =
        Namespaced_IRI.parse _namespace_name "parkingVehicle" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#feedDescription"></see>
    /// </summary>
    let feedDescription =
        Namespaced_IRI.parse _namespace_name "feedDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#feedType"></see>
    /// </summary>
    let feedType = Namespaced_IRI.parse _namespace_name "feedType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#payloadPublicationExtension"></see>
    /// </summary>
    let payloadPublicationExtension =
        Namespaced_IRI.parse _namespace_name "payloadPublicationExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#publicationCreator"></see>
    /// </summary>
    let publicationCreator =
        Namespaced_IRI.parse _namespace_name "publicationCreator" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#publicationTime"></see>
    /// </summary>
    let publicationTime =
        Namespaced_IRI.parse _namespace_name "publicationTime" |> NamespacedName

    /// <summary>
    /// A measured or calculated value of the flow rate of passenger car units.
    /// <see href="http://vocab.datex.org/terms#PcuFlowValue"></see></summary>
    let PcuFlowValue =
        Namespaced_IRI.parse _namespace_name "PcuFlowValue" |> NamespacedName

    /// <summary>
    /// A value of passenger car unit flow rate expressed in passenger car units per hour.
    /// <see href="http://vocab.datex.org/terms#pcuFlowRate"></see></summary>
    let pcuFlowRate =
        Namespaced_IRI.parse _namespace_name "pcuFlowRate" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pcuFlowValueExtension"></see>
    /// </summary>
    let pcuFlowValueExtension =
        Namespaced_IRI.parse _namespace_name "pcuFlowValueExtension" |> NamespacedName

    /// <summary>
    /// Distance of a point along a linear element measured from the start node expressed as a percentage of the whole length of the linear element, where start node is relative to the element definition rather than the direction of traffic flow.
    /// <see href="http://vocab.datex.org/terms#PercentageDistanceAlongLinearElement"></see></summary>
    let PercentageDistanceAlongLinearElement =
        Namespaced_IRI.parse _namespace_name "PercentageDistanceAlongLinearElement" |> NamespacedName

    /// <summary>
    /// A measure of distance along a linear element from the start of the element expressed as a percentage of the total length of the linear object.
    /// <see href="http://vocab.datex.org/terms#percentageDistanceAlong"></see></summary>
    let percentageDistanceAlong =
        Namespaced_IRI.parse _namespace_name "percentageDistanceAlong" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#percentageDistanceAlongLinearElementExtension"></see>
    /// </summary>
    let percentageDistanceAlongLinearElementExtension =
        Namespaced_IRI.parse _namespace_name "percentageDistanceAlongLinearElementExtension" |> NamespacedName

    /// <summary>
    /// A value expressed as a percentage.
    /// <see href="http://vocab.datex.org/terms#percentage"></see></summary>
    let percentage = Namespaced_IRI.parse _namespace_name "percentage" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#percentageValueExtension"></see>
    /// </summary>
    let percentageValueExtension =
        Namespaced_IRI.parse _namespace_name "percentageValueExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#endOfPeriod"></see>
    /// </summary>
    let endOfPeriod =
        Namespaced_IRI.parse _namespace_name "endOfPeriod" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#periodExtension"></see>
    /// </summary>
    let periodExtension =
        Namespaced_IRI.parse _namespace_name "periodExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_PeriodExtensionType"></see>
    /// </summary>
    let _PeriodExtensionType =
        Namespaced_IRI.parse _namespace_name "_PeriodExtensionType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#periodName"></see>
    /// </summary>
    let periodName = Namespaced_IRI.parse _namespace_name "periodName" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#recurringDayWeekMonthPeriod"></see>
    /// </summary>
    let recurringDayWeekMonthPeriod =
        Namespaced_IRI.parse _namespace_name "recurringDayWeekMonthPeriod" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#recurringTimePeriodOfDay"></see>
    /// </summary>
    let recurringTimePeriodOfDay =
        Namespaced_IRI.parse _namespace_name "recurringTimePeriodOfDay" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#startOfPeriod"></see>
    /// </summary>
    let startOfPeriod =
        Namespaced_IRI.parse _namespace_name "startOfPeriod" |> NamespacedName

    /// <summary>
    /// An extension point for Period offering the possibility to describe special days and public holidays.
    /// <see href="http://vocab.datex.org/terms#PeriodExtended"></see></summary>
    let PeriodExtended =
        Namespaced_IRI.parse _namespace_name "PeriodExtended" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#recurringSpecialDay"></see>
    /// </summary>
    let recurringSpecialDay =
        Namespaced_IRI.parse _namespace_name "recurringSpecialDay" |> NamespacedName

    /// <summary>
    /// Specification of a special day, for example schoolDay, electionDay, ...  Gives also the possibility to define a public holiday (country specific).
    /// <see href="http://vocab.datex.org/terms#SpecialDay"></see></summary>
    let SpecialDay = Namespaced_IRI.parse _namespace_name "SpecialDay" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#activity"></see>
    /// </summary>
    let activity = Namespaced_IRI.parse _namespace_name "activity" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#permitsAndProhibitionsExtension"></see>
    /// </summary>
    let permitsAndProhibitionsExtension =
        Namespaced_IRI.parse _namespace_name "permitsAndProhibitionsExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#regulation"></see>
    /// </summary>
    let regulation = Namespaced_IRI.parse _namespace_name "regulation" |> NamespacedName

    /// <summary>
    /// Settings specific to a distinct pictogram display area on the VMS (where pictogramIndex indicates which pictogram area it relates to if there is more than one pictogram display area on the VMS).
    /// <see href="http://vocab.datex.org/terms#PictogramDisplayAreaSettings"></see></summary>
    let PictogramDisplayAreaSettings =
        Namespaced_IRI.parse _namespace_name "PictogramDisplayAreaSettings" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramDisplayAreaSettingsExtension"></see>
    /// </summary>
    let pictogramDisplayAreaSettingsExtension =
        Namespaced_IRI.parse _namespace_name "pictogramDisplayAreaSettingsExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramLanternsOn"></see>
    /// </summary>
    let pictogramLanternsOn =
        Namespaced_IRI.parse _namespace_name "pictogramLanternsOn" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramLuminanceLevel"></see>
    /// </summary>
    let pictogramLuminanceLevel =
        Namespaced_IRI.parse _namespace_name "pictogramLuminanceLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramLuminanceLevelName"></see>
    /// </summary>
    let pictogramLuminanceLevelName =
        Namespaced_IRI.parse _namespace_name "pictogramLuminanceLevelName" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramLuminanceOverride"></see>
    /// </summary>
    let pictogramLuminanceOverride =
        Namespaced_IRI.parse _namespace_name "pictogramLuminanceOverride" |> NamespacedName

    /// <summary>
    /// A single geospatial point.
    /// <see href="http://vocab.datex.org/terms#Point"></see></summary>
    let Point = Namespaced_IRI.parse _namespace_name "Point" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#alertCPoint"></see>
    /// </summary>
    let alertCPoint =
        Namespaced_IRI.parse _namespace_name "alertCPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pointAlongLinearElement"></see>
    /// </summary>
    let pointAlongLinearElement =
        Namespaced_IRI.parse _namespace_name "pointAlongLinearElement" |> NamespacedName

    /// <summary>
    /// A point on a linear element where the linear element is either a part of or the whole of a linear object (i.e. a road), consistent with ISO 19148 definitions.
    /// <see href="http://vocab.datex.org/terms#PointAlongLinearElement"></see></summary>
    let PointAlongLinearElement =
        Namespaced_IRI.parse _namespace_name "PointAlongLinearElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pointByCoordinates"></see>
    /// </summary>
    let pointByCoordinates =
        Namespaced_IRI.parse _namespace_name "pointByCoordinates" |> NamespacedName

    /// <summary>
    /// A single point defined only by a coordinate set with an optional bearing direction.
    /// <see href="http://vocab.datex.org/terms#PointByCoordinates"></see></summary>
    let PointByCoordinates =
        Namespaced_IRI.parse _namespace_name "PointByCoordinates" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pointExtension"></see>
    /// </summary>
    let pointExtension =
        Namespaced_IRI.parse _namespace_name "pointExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_PointExtensionType"></see>
    /// </summary>
    let _PointExtensionType =
        Namespaced_IRI.parse _namespace_name "_PointExtensionType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegPointLocation"></see>
    /// </summary>
    let tpegPointLocation =
        Namespaced_IRI.parse _namespace_name "tpegPointLocation" |> NamespacedName

    /// <summary>
    /// A single point on the road network defined by a TPEG-Loc structure and which has an associated direction of traffic flow.
    /// <see href="http://vocab.datex.org/terms#TpegPointLocation"></see></summary>
    let TpegPointLocation =
        Namespaced_IRI.parse _namespace_name "TpegPointLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#administrativeAreaOfPoint"></see>
    /// </summary>
    let administrativeAreaOfPoint =
        Namespaced_IRI.parse _namespace_name "administrativeAreaOfPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#directionBoundAtPoint"></see>
    /// </summary>
    let directionBoundAtPoint =
        Namespaced_IRI.parse _namespace_name "directionBoundAtPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#directionRelativeAtPoint"></see>
    /// </summary>
    let directionRelativeAtPoint =
        Namespaced_IRI.parse _namespace_name "directionRelativeAtPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#distanceAlongLinearElement"></see>
    /// </summary>
    let distanceAlongLinearElement =
        Namespaced_IRI.parse _namespace_name "distanceAlongLinearElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#heightGradeOfPoint"></see>
    /// </summary>
    let heightGradeOfPoint =
        Namespaced_IRI.parse _namespace_name "heightGradeOfPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pointAlongLinearElementExtension"></see>
    /// </summary>
    let pointAlongLinearElementExtension =
        Namespaced_IRI.parse _namespace_name "pointAlongLinearElementExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#bearing"></see>
    /// </summary>
    let bearing = Namespaced_IRI.parse _namespace_name "bearing" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pointByCoordinatesExtension"></see>
    /// </summary>
    let pointByCoordinatesExtension =
        Namespaced_IRI.parse _namespace_name "pointByCoordinatesExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pointCoordinates"></see>
    /// </summary>
    let pointCoordinates =
        Namespaced_IRI.parse _namespace_name "pointCoordinates" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#latitude"></see>
    /// </summary>
    let latitude = Namespaced_IRI.parse _namespace_name "latitude" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#longitude"></see>
    /// </summary>
    let longitude = Namespaced_IRI.parse _namespace_name "longitude" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pointCoordinatesExtension"></see>
    /// </summary>
    let pointCoordinatesExtension =
        Namespaced_IRI.parse _namespace_name "pointCoordinatesExtension" |> NamespacedName

    /// <summary>
    /// The specification of the destination of a defined route or itinerary which is a point.
    /// <see href="http://vocab.datex.org/terms#PointDestination"></see></summary>
    let PointDestination =
        Namespaced_IRI.parse _namespace_name "PointDestination" |> NamespacedName

    /// <summary>
    /// A single point defined by a coordinate set and TPEG decriptors.
    /// <see href="http://vocab.datex.org/terms#point"></see></summary>
    let point = Namespaced_IRI.parse _namespace_name "point" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pointDestinationExtension"></see>
    /// </summary>
    let pointDestinationExtension =
        Namespaced_IRI.parse _namespace_name "pointDestinationExtension" |> NamespacedName

    /// <summary>
    /// Extension point for 'Point' to support the description of junctions (and other alternative point descriptions).
    /// <see href="http://vocab.datex.org/terms#PointExtended"></see></summary>
    let PointExtended =
        Namespaced_IRI.parse _namespace_name "PointExtended" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#description"></see>
    /// </summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#junction"></see>
    /// </summary>
    let junction = Namespaced_IRI.parse _namespace_name "junction" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pollutantConcentration"></see>
    /// </summary>
    let pollutantConcentration =
        Namespaced_IRI.parse _namespace_name "pollutantConcentration" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pollutantType"></see>
    /// </summary>
    let pollutantType =
        Namespaced_IRI.parse _namespace_name "pollutantType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pollutionExtension"></see>
    /// </summary>
    let pollutionExtension =
        Namespaced_IRI.parse _namespace_name "pollutionExtension" |> NamespacedName

    /// <summary>
    /// Measurements of atmospheric pollution.
    /// <see href="http://vocab.datex.org/terms#PollutionInformation"></see></summary>
    let PollutionInformation =
        Namespaced_IRI.parse _namespace_name "PollutionInformation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pollution"></see>
    /// </summary>
    let pollution = Namespaced_IRI.parse _namespace_name "pollution" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pollutionInformationExtension"></see>
    /// </summary>
    let pollutionInformationExtension =
        Namespaced_IRI.parse _namespace_name "pollutionInformationExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_PolygonAreaIndexPointCoordinates"></see>
    /// </summary>
    let _PolygonAreaIndexPointCoordinates =
        Namespaced_IRI.parse _namespace_name "_PolygonAreaIndexPointCoordinates" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#polygonAreaExtension"></see>
    /// </summary>
    let polygonAreaExtension =
        Namespaced_IRI.parse _namespace_name "polygonAreaExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#sectionName"></see>
    /// </summary>
    let sectionName =
        Namespaced_IRI.parse _namespace_name "sectionName" |> NamespacedName

    /// <summary>
    /// Any environmental conditions which may be affecting the driving conditions on the road.
    /// <see href="http://vocab.datex.org/terms#PoorEnvironmentConditions"></see></summary>
    let PoorEnvironmentConditions =
        Namespaced_IRI.parse _namespace_name "PoorEnvironmentConditions" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#poorEnvironmentConditionsExtension"></see>
    /// </summary>
    let poorEnvironmentConditionsExtension =
        Namespaced_IRI.parse _namespace_name "poorEnvironmentConditionsExtension" |> NamespacedName

    /// <summary>
    /// The type of environment condition which is affecting driving conditions.
    /// <see href="http://vocab.datex.org/terms#poorEnvironmentType"></see></summary>
    let poorEnvironmentType =
        Namespaced_IRI.parse _namespace_name "poorEnvironmentType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#precipitationDetail"></see>
    /// </summary>
    let precipitationDetail =
        Namespaced_IRI.parse _namespace_name "precipitationDetail" |> NamespacedName

    /// <summary>
    /// Details of precipitation (rain, snow etc.).
    /// <see href="http://vocab.datex.org/terms#PrecipitationDetail"></see></summary>
    let PrecipitationDetail =
        Namespaced_IRI.parse _namespace_name "PrecipitationDetail" |> NamespacedName

    /// <summary>
    /// A value of temperature expressed in degrees Celsius.
    /// <see href="http://vocab.datex.org/terms#temperature"></see></summary>
    let temperature =
        Namespaced_IRI.parse _namespace_name "temperature" |> NamespacedName

    /// <summary>
    /// Details of atmospheric temperature.
    /// <see href="http://vocab.datex.org/terms#Temperature"></see></summary>
    let Temperature =
        Namespaced_IRI.parse _namespace_name "Temperature" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#visibility"></see>
    /// </summary>
    let visibility = Namespaced_IRI.parse _namespace_name "visibility" |> NamespacedName
    /// <summary>
    /// Details of atmospheric visibility.
    /// <see href="http://vocab.datex.org/terms#Visibility"></see></summary>
    let Visibility = Namespaced_IRI.parse _namespace_name "Visibility" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#wind"></see>
    /// </summary>
    let wind = Namespaced_IRI.parse _namespace_name "wind" |> NamespacedName
    /// <summary>
    /// Wind conditions on the road.
    /// <see href="http://vocab.datex.org/terms#Wind"></see></summary>
    let Wind = Namespaced_IRI.parse _namespace_name "Wind" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#depositionDepth"></see>
    /// </summary>
    let depositionDepth =
        Namespaced_IRI.parse _namespace_name "depositionDepth" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#precipitationDetailExtension"></see>
    /// </summary>
    let precipitationDetailExtension =
        Namespaced_IRI.parse _namespace_name "precipitationDetailExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#precipitationIntensity"></see>
    /// </summary>
    let precipitationIntensity =
        Namespaced_IRI.parse _namespace_name "precipitationIntensity" |> NamespacedName

    /// <summary>
    /// A measured or calculated value of the accumulation rate of precipitation.
    /// <see href="http://vocab.datex.org/terms#PrecipitationIntensityValue"></see></summary>
    let PrecipitationIntensityValue =
        Namespaced_IRI.parse _namespace_name "PrecipitationIntensityValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#precipitationType"></see>
    /// </summary>
    let precipitationType =
        Namespaced_IRI.parse _namespace_name "precipitationType" |> NamespacedName

    /// <summary>
    /// Measurements of precipitation.
    /// <see href="http://vocab.datex.org/terms#PrecipitationInformation"></see></summary>
    let PrecipitationInformation =
        Namespaced_IRI.parse _namespace_name "PrecipitationInformation" |> NamespacedName

    /// <summary>
    /// Indication of whether precipitation is present or not. True indicates there is no precipitation.
    /// <see href="http://vocab.datex.org/terms#noPrecipitation"></see></summary>
    let noPrecipitation =
        Namespaced_IRI.parse _namespace_name "noPrecipitation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#precipitationInformationExtension"></see>
    /// </summary>
    let precipitationInformationExtension =
        Namespaced_IRI.parse _namespace_name "precipitationInformationExtension" |> NamespacedName

    /// <summary>
    /// A value of precipitation intensity expressed in units of millimetres per hour.
    /// <see href="http://vocab.datex.org/terms#millimetresPerHourIntensity"></see></summary>
    let millimetresPerHourIntensity =
        Namespaced_IRI.parse _namespace_name "millimetresPerHourIntensity" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#precipitationIntensityValueExtension"></see>
    /// </summary>
    let precipitationIntensityValueExtension =
        Namespaced_IRI.parse _namespace_name "precipitationIntensityValueExtension" |> NamespacedName

    /// <summary>
    /// An identifiable versioned instance of a predefined itinerary.
    /// <see href="http://vocab.datex.org/terms#PredefinedItinerary"></see></summary>
    let PredefinedItinerary =
        Namespaced_IRI.parse _namespace_name "PredefinedItinerary" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#predefinedItineraryExtension"></see>
    /// </summary>
    let predefinedItineraryExtension =
        Namespaced_IRI.parse _namespace_name "predefinedItineraryExtension" |> NamespacedName

    /// <summary>
    /// A name assigned to the predefined itinerary.
    /// <see href="http://vocab.datex.org/terms#predefinedItineraryName"></see></summary>
    let predefinedItineraryName =
        Namespaced_IRI.parse _namespace_name "predefinedItineraryName" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#predefinedLocation"></see>
    /// </summary>
    let predefinedLocation =
        Namespaced_IRI.parse _namespace_name "predefinedLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_PredefinedItineraryIndexPredefinedLocation"></see>
    /// </summary>
    let _PredefinedItineraryIndexPredefinedLocation =
        Namespaced_IRI.parse _namespace_name "_PredefinedItineraryIndexPredefinedLocation" |> NamespacedName

    /// <summary>
    /// A container which may comprise the definition of a predefined itinerary, non ordered group of locations or single location.
    /// <see href="http://vocab.datex.org/terms#PredefinedLocationContainer"></see></summary>
    let PredefinedLocationContainer =
        Namespaced_IRI.parse _namespace_name "PredefinedLocationContainer" |> NamespacedName

    /// <summary>
    /// An identifiable versioned instance of a single predefined location.
    /// <see href="http://vocab.datex.org/terms#PredefinedLocation"></see></summary>
    let PredefinedLocation =
        Namespaced_IRI.parse _namespace_name "PredefinedLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#predefinedLocationExtension"></see>
    /// </summary>
    let predefinedLocationExtension =
        Namespaced_IRI.parse _namespace_name "predefinedLocationExtension" |> NamespacedName

    /// <summary>
    /// A name assigned to the predefined location (e.g. extracted out of the network operator's gazetteer).
    /// <see href="http://vocab.datex.org/terms#predefinedLocationName"></see></summary>
    let predefinedLocationName =
        Namespaced_IRI.parse _namespace_name "predefinedLocationName" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#predefinedLocationContainerExtension"></see>
    /// </summary>
    let predefinedLocationContainerExtension =
        Namespaced_IRI.parse _namespace_name "predefinedLocationContainerExtension" |> NamespacedName

    /// <summary>
    /// A publication containing one or more groups of predefined locations organised either as litineraries, non ordered groups or as individual locations.
    /// <see href="http://vocab.datex.org/terms#PredefinedLocationsPublication"></see></summary>
    let PredefinedLocationsPublication =
        Namespaced_IRI.parse _namespace_name "PredefinedLocationsPublication" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#predefinedLocationContainer"></see>
    /// </summary>
    let predefinedLocationContainer =
        Namespaced_IRI.parse _namespace_name "predefinedLocationContainer" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#predefinedLocationsPublicationExtension"></see>
    /// </summary>
    let predefinedLocationsPublicationExtension =
        Namespaced_IRI.parse _namespace_name "predefinedLocationsPublicationExtension" |> NamespacedName

    /// <summary>
    /// An identifiable versioned instance of a predefined group of non ordered locations (i.e. more than one).
    /// <see href="http://vocab.datex.org/terms#PredefinedNonOrderedLocationGroup"></see></summary>
    let PredefinedNonOrderedLocationGroup =
        Namespaced_IRI.parse _namespace_name "PredefinedNonOrderedLocationGroup" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#predefinedNonOrderedLocationGroupExtension"></see>
    /// </summary>
    let predefinedNonOrderedLocationGroupExtension =
        Namespaced_IRI.parse _namespace_name "predefinedNonOrderedLocationGroupExtension" |> NamespacedName

    /// <summary>
    /// A name assigned to the predefined group of non ordered locations.
    /// <see href="http://vocab.datex.org/terms#predefinedNonOrderedLocationGroupName"></see></summary>
    let predefinedNonOrderedLocationGroupName =
        Namespaced_IRI.parse _namespace_name "predefinedNonOrderedLocationGroupName" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#publicEventExtension"></see>
    /// </summary>
    let publicEventExtension =
        Namespaced_IRI.parse _namespace_name "publicEventExtension" |> NamespacedName

    /// <summary>
    /// Type of public event which could disrupt traffic.
    /// <see href="http://vocab.datex.org/terms#publicEventType"></see></summary>
    let publicEventType =
        Namespaced_IRI.parse _namespace_name "publicEventType" |> NamespacedName

    /// <summary>
    /// Specification of the public holiday type in a specific country or region. Use this component only when specialDayType is set to 'publicHoliday' or 'holidays'.
    /// <see href="http://vocab.datex.org/terms#PublicHoliday"></see></summary>
    let PublicHoliday =
        Namespaced_IRI.parse _namespace_name "PublicHoliday" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#countrySubdivision"></see>
    /// </summary>
    let countrySubdivision =
        Namespaced_IRI.parse _namespace_name "countrySubdivision" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#publicHolidayExtension"></see>
    /// </summary>
    let publicHolidayExtension =
        Namespaced_IRI.parse _namespace_name "publicHolidayExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#publicHolidayName"></see>
    /// </summary>
    let publicHolidayName =
        Namespaced_IRI.parse _namespace_name "publicHolidayName" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#publicHolidayType"></see>
    /// </summary>
    let publicHolidayType =
        Namespaced_IRI.parse _namespace_name "publicHolidayType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#region"></see>
    /// </summary>
    let region = Namespaced_IRI.parse _namespace_name "region" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#colourName"></see>
    /// </summary>
    let colourName = Namespaced_IRI.parse _namespace_name "colourName" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#rgbBlueValue"></see>
    /// </summary>
    let rgbBlueValue =
        Namespaced_IRI.parse _namespace_name "rgbBlueValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#rgbColourExtension"></see>
    /// </summary>
    let rgbColourExtension =
        Namespaced_IRI.parse _namespace_name "rgbColourExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#rgbGreenValue"></see>
    /// </summary>
    let rgbGreenValue =
        Namespaced_IRI.parse _namespace_name "rgbGreenValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#rgbRedValue"></see>
    /// </summary>
    let rgbRedValue =
        Namespaced_IRI.parse _namespace_name "rgbRedValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#Reference"></see>
    /// </summary>
    let Reference = Namespaced_IRI.parse _namespace_name "Reference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#referenceSettingsExtension"></see>
    /// </summary>
    let referenceSettingsExtension =
        Namespaced_IRI.parse _namespace_name "referenceSettingsExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#trafficStatusDefault"></see>
    /// </summary>
    let trafficStatusDefault =
        Namespaced_IRI.parse _namespace_name "trafficStatusDefault" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#referentDescription"></see>
    /// </summary>
    let referentDescription =
        Namespaced_IRI.parse _namespace_name "referentDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#referentExtension"></see>
    /// </summary>
    let referentExtension =
        Namespaced_IRI.parse _namespace_name "referentExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#referentIdentifier"></see>
    /// </summary>
    let referentIdentifier =
        Namespaced_IRI.parse _namespace_name "referentIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#referentName"></see>
    /// </summary>
    let referentName =
        Namespaced_IRI.parse _namespace_name "referentName" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#referentType"></see>
    /// </summary>
    let referentType =
        Namespaced_IRI.parse _namespace_name "referentType" |> NamespacedName

    /// <summary>
    /// Rerouting management action that is issued by the network/road operator.
    /// <see href="http://vocab.datex.org/terms#ReroutingManagement"></see></summary>
    let ReroutingManagement =
        Namespaced_IRI.parse _namespace_name "ReroutingManagement" |> NamespacedName

    /// <summary>
    /// The definition of the alternative route (rerouting) specified as an ordered set of locations (itinerary) which may be specific to one or more defined destinations.
    /// <see href="http://vocab.datex.org/terms#alternativeRoute"></see></summary>
    let alternativeRoute =
        Namespaced_IRI.parse _namespace_name "alternativeRoute" |> NamespacedName

    /// <summary>
    /// The specified entry on to another road at which the alternative route commences.
    /// <see href="http://vocab.datex.org/terms#entry"></see></summary>
    let entry = Namespaced_IRI.parse _namespace_name "entry" |> NamespacedName
    /// <summary>
    /// The specified exit from the normal route/road at which the alternative route commences.
    /// <see href="http://vocab.datex.org/terms#exit"></see></summary>
    let exit = Namespaced_IRI.parse _namespace_name "exit" |> NamespacedName

    /// <summary>
    /// A description of the rerouting itinerary.
    /// <see href="http://vocab.datex.org/terms#reroutingItineraryDescription"></see></summary>
    let reroutingItineraryDescription =
        Namespaced_IRI.parse _namespace_name "reroutingItineraryDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#reroutingManagementExtension"></see>
    /// </summary>
    let reroutingManagementExtension =
        Namespaced_IRI.parse _namespace_name "reroutingManagementExtension" |> NamespacedName

    /// <summary>
    /// Type of rerouting management action instigated by operator.
    /// <see href="http://vocab.datex.org/terms#reroutingManagementType"></see></summary>
    let reroutingManagementType =
        Namespaced_IRI.parse _namespace_name "reroutingManagementType" |> NamespacedName

    /// <summary>
    /// The intersecting road or the junction at which the alternative route commences.
    /// <see href="http://vocab.datex.org/terms#roadOrJunctionNumber"></see></summary>
    let roadOrJunctionNumber =
        Namespaced_IRI.parse _namespace_name "roadOrJunctionNumber" |> NamespacedName

    /// <summary>
    /// Indication of whether the rerouting is signed.
    /// <see href="http://vocab.datex.org/terms#signedRerouting"></see></summary>
    let signedRerouting =
        Namespaced_IRI.parse _namespace_name "signedRerouting" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#distanceToThisRoad"></see>
    /// </summary>
    let distanceToThisRoad =
        Namespaced_IRI.parse _namespace_name "distanceToThisRoad" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#nameOfRoad"></see>
    /// </summary>
    let nameOfRoad = Namespaced_IRI.parse _namespace_name "nameOfRoad" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#roadDestination"></see>
    /// </summary>
    let roadDestination =
        Namespaced_IRI.parse _namespace_name "roadDestination" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#roadExtension"></see>
    /// </summary>
    let roadExtension =
        Namespaced_IRI.parse _namespace_name "roadExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#roadIdentifier"></see>
    /// </summary>
    let roadIdentifier =
        Namespaced_IRI.parse _namespace_name "roadIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#roadOrigination"></see>
    /// </summary>
    let roadOrigination =
        Namespaced_IRI.parse _namespace_name "roadOrigination" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#typeOfRoad"></see>
    /// </summary>
    let typeOfRoad = Namespaced_IRI.parse _namespace_name "typeOfRoad" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#roadConditionsExtension"></see>
    /// </summary>
    let roadConditionsExtension =
        Namespaced_IRI.parse _namespace_name "roadConditionsExtension" |> NamespacedName

    /// <summary>
    /// A road node as part of the specialised road identified by the name of a junctionon on this road.
    /// <see href="http://vocab.datex.org/terms#RoadNode"></see></summary>
    let RoadNode = Namespaced_IRI.parse _namespace_name "RoadNode" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#roadNodeExtension"></see>
    /// </summary>
    let roadNodeExtension =
        Namespaced_IRI.parse _namespace_name "roadNodeExtension" |> NamespacedName

    /// <summary>
    /// Details of disruption to normal road operator services
    /// <see href="http://vocab.datex.org/terms#RoadOperatorServiceDisruption"></see></summary>
    let RoadOperatorServiceDisruption =
        Namespaced_IRI.parse _namespace_name "RoadOperatorServiceDisruption" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#roadOperatorServiceDisruptionExtension"></see>
    /// </summary>
    let roadOperatorServiceDisruptionExtension =
        Namespaced_IRI.parse _namespace_name "roadOperatorServiceDisruptionExtension" |> NamespacedName

    /// <summary>
    /// The type of road operator service which is disrupted.
    /// <see href="http://vocab.datex.org/terms#roadOperatorServiceDisruptionType"></see></summary>
    let roadOperatorServiceDisruptionType =
        Namespaced_IRI.parse _namespace_name "roadOperatorServiceDisruptionType" |> NamespacedName

    /// <summary>
    /// The minimum number of persons required in a vehicle in order for it to be allowed to transit the specified road section.
    /// <see href="http://vocab.datex.org/terms#minimumCarOccupancy"></see></summary>
    let minimumCarOccupancy =
        Namespaced_IRI.parse _namespace_name "minimumCarOccupancy" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#roadOrCarriagewayOrLaneManagementExtension"></see>
    /// </summary>
    let roadOrCarriagewayOrLaneManagementExtension =
        Namespaced_IRI.parse _namespace_name "roadOrCarriagewayOrLaneManagementExtension" |> NamespacedName

    /// <summary>
    /// Type of road, carriageway or lane management action instigated by operator.
    /// <see href="http://vocab.datex.org/terms#roadOrCarriagewayOrLaneManagementType"></see></summary>
    let roadOrCarriagewayOrLaneManagementType =
        Namespaced_IRI.parse _namespace_name "roadOrCarriagewayOrLaneManagementType" |> NamespacedName

    /// <summary>
    /// Measurements of road surface conditions which are related to the weather.
    /// <see href="http://vocab.datex.org/terms#RoadSurfaceConditionInformation"></see></summary>
    let RoadSurfaceConditionInformation =
        Namespaced_IRI.parse _namespace_name "RoadSurfaceConditionInformation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#roadSurfaceConditionInformationExtension"></see>
    /// </summary>
    let roadSurfaceConditionInformationExtension =
        Namespaced_IRI.parse _namespace_name "roadSurfaceConditionInformationExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#roadSurfaceConditionMeasurements"></see>
    /// </summary>
    let roadSurfaceConditionMeasurements =
        Namespaced_IRI.parse _namespace_name "roadSurfaceConditionMeasurements" |> NamespacedName

    /// <summary>
    /// Measurements of the road surface condition which relate specifically to the weather.
    /// <see href="http://vocab.datex.org/terms#RoadSurfaceConditionMeasurements"></see></summary>
    let RoadSurfaceConditionMeasurements =
        Namespaced_IRI.parse _namespace_name "RoadSurfaceConditionMeasurements" |> NamespacedName

    /// <summary>
    /// The type of road surface condition that is related to the weather which is affecting the driving conditions.
    /// <see href="http://vocab.datex.org/terms#weatherRelatedRoadConditionType"></see></summary>
    let weatherRelatedRoadConditionType =
        Namespaced_IRI.parse _namespace_name "weatherRelatedRoadConditionType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#deIcingApplicationRate"></see>
    /// </summary>
    let deIcingApplicationRate =
        Namespaced_IRI.parse _namespace_name "deIcingApplicationRate" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#deIcingConcentration"></see>
    /// </summary>
    let deIcingConcentration =
        Namespaced_IRI.parse _namespace_name "deIcingConcentration" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#depthOfSnow"></see>
    /// </summary>
    let depthOfSnow =
        Namespaced_IRI.parse _namespace_name "depthOfSnow" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#protectionTemperature"></see>
    /// </summary>
    let protectionTemperature =
        Namespaced_IRI.parse _namespace_name "protectionTemperature" |> NamespacedName

    /// <summary>
    /// A measured or calculated value of temperature.
    /// <see href="http://vocab.datex.org/terms#TemperatureValue"></see></summary>
    let TemperatureValue =
        Namespaced_IRI.parse _namespace_name "TemperatureValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#roadSurfaceConditionMeasurementsExtension"></see>
    /// </summary>
    let roadSurfaceConditionMeasurementsExtension =
        Namespaced_IRI.parse _namespace_name "roadSurfaceConditionMeasurementsExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#roadSurfaceTemperature"></see>
    /// </summary>
    let roadSurfaceTemperature =
        Namespaced_IRI.parse _namespace_name "roadSurfaceTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#waterFilmThickness"></see>
    /// </summary>
    let waterFilmThickness =
        Namespaced_IRI.parse _namespace_name "waterFilmThickness" |> NamespacedName

    /// <summary>
    /// Details of road side assistance required or being given.
    /// <see href="http://vocab.datex.org/terms#RoadsideAssistance"></see></summary>
    let RoadsideAssistance =
        Namespaced_IRI.parse _namespace_name "RoadsideAssistance" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#roadsideAssistanceExtension"></see>
    /// </summary>
    let roadsideAssistanceExtension =
        Namespaced_IRI.parse _namespace_name "roadsideAssistanceExtension" |> NamespacedName

    /// <summary>
    /// Indicates the nature of the road side assistance that will be, is or has been provided.
    /// <see href="http://vocab.datex.org/terms#roadsideAssistanceType"></see></summary>
    let roadsideAssistanceType =
        Namespaced_IRI.parse _namespace_name "roadsideAssistanceType" |> NamespacedName

    /// <summary>
    /// Details of disruption to normal roadside services (e.g. specific services at a service area).
    /// <see href="http://vocab.datex.org/terms#RoadsideServiceDisruption"></see></summary>
    let RoadsideServiceDisruption =
        Namespaced_IRI.parse _namespace_name "RoadsideServiceDisruption" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#roadsideServiceDisruptionExtension"></see>
    /// </summary>
    let roadsideServiceDisruptionExtension =
        Namespaced_IRI.parse _namespace_name "roadsideServiceDisruptionExtension" |> NamespacedName

    /// <summary>
    /// The type of roadside service which is disrupted.
    /// <see href="http://vocab.datex.org/terms#roadsideServiceDisruptionType"></see></summary>
    let roadsideServiceDisruptionType =
        Namespaced_IRI.parse _namespace_name "roadsideServiceDisruptionType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maintenanceVehicles"></see>
    /// </summary>
    let maintenanceVehicles =
        Namespaced_IRI.parse _namespace_name "maintenanceVehicles" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#mobility"></see>
    /// </summary>
    let mobility = Namespaced_IRI.parse _namespace_name "mobility" |> NamespacedName

    /// <summary>
    /// Indicates in general terms the expected duration of the roadworks.
    /// <see href="http://vocab.datex.org/terms#roadworksDuration"></see></summary>
    let roadworksDuration =
        Namespaced_IRI.parse _namespace_name "roadworksDuration" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#roadworksExtension"></see>
    /// </summary>
    let roadworksExtension =
        Namespaced_IRI.parse _namespace_name "roadworksExtension" |> NamespacedName

    /// <summary>
    /// Indication of the scale of the roadworks in terms of the traffic disruption they are likely to cause.
    /// <see href="http://vocab.datex.org/terms#roadworksScale"></see></summary>
    let roadworksScale =
        Namespaced_IRI.parse _namespace_name "roadworksScale" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#subjects"></see>
    /// </summary>
    let subjects = Namespaced_IRI.parse _namespace_name "subjects" |> NamespacedName
    /// <summary>
    /// The subjects with which the roadworks are associated.
    /// <see href="http://vocab.datex.org/terms#Subjects"></see></summary>
    let Subjects = Namespaced_IRI.parse _namespace_name "Subjects" |> NamespacedName

    /// <summary>
    /// Indicates that the road section where the roadworks are located is under traffic or not under traffic. 'True' indicates the road is under traffic.
    /// <see href="http://vocab.datex.org/terms#underTraffic"></see></summary>
    let underTraffic =
        Namespaced_IRI.parse _namespace_name "underTraffic" |> NamespacedName

    /// <summary>
    /// Indication of whether the roadworks are considered to be urgent whereby emergency work is being, or needs to be, undertaken to mitigate safety concerns. 'True' indicates they are urgent.
    /// <see href="http://vocab.datex.org/terms#urgentRoadworks"></see></summary>
    let urgentRoadworks =
        Namespaced_IRI.parse _namespace_name "urgentRoadworks" |> NamespacedName

    /// <summary>
    /// One type of service facility that is available on the parking site or located next to it. You can specify the number of this service facility type (e.g. 5 restaurants) as well as the number of subitems (e.g. 200 restaurant places).
    /// <see href="http://vocab.datex.org/terms#ServiceFacility"></see></summary>
    let ServiceFacility =
        Namespaced_IRI.parse _namespace_name "ServiceFacility" |> NamespacedName

    /// <summary>
    /// If the service facility is not located on the parking site itself, its distance can be specified here in metres.
    /// <see href="http://vocab.datex.org/terms#distanceFromParkingSite"></see></summary>
    let distanceFromParkingSite =
        Namespaced_IRI.parse _namespace_name "distanceFromParkingSite" |> NamespacedName

    /// <summary>
    /// The quantity of sub items to this service facility type, e.g. the total number of restaurant places or fuel dispensers etc.
    /// <see href="http://vocab.datex.org/terms#numberOfSubitems"></see></summary>
    let numberOfSubitems =
        Namespaced_IRI.parse _namespace_name "numberOfSubitems" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#serviceFacilityExtension"></see>
    /// </summary>
    let serviceFacilityExtension =
        Namespaced_IRI.parse _namespace_name "serviceFacilityExtension" |> NamespacedName

    /// <summary>
    /// One type of service, that is available on the parking site.
    /// <see href="http://vocab.datex.org/terms#serviceFacilityType"></see></summary>
    let serviceFacilityType =
        Namespaced_IRI.parse _namespace_name "serviceFacilityType" |> NamespacedName

    /// <summary>
    /// Provides information on message signs and the information currently displayed.
    /// <see href="http://vocab.datex.org/terms#SignSetting"></see></summary>
    let SignSetting =
        Namespaced_IRI.parse _namespace_name "SignSetting" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#signSettingExtension"></see>
    /// </summary>
    let signSettingExtension =
        Namespaced_IRI.parse _namespace_name "signSettingExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsSetting"></see>
    /// </summary>
    let vmsSetting = Namespaced_IRI.parse _namespace_name "vmsSetting" |> NamespacedName
    /// <summary>
    /// Provides information on variable message signs and the information currently displayed.
    /// <see href="http://vocab.datex.org/terms#VmsSetting"></see></summary>
    let VmsSetting = Namespaced_IRI.parse _namespace_name "VmsSetting" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measuredValue"></see>
    /// </summary>
    let measuredValue =
        Namespaced_IRI.parse _namespace_name "measuredValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_SiteMeasurementsIndexMeasuredValue"></see>
    /// </summary>
    let _SiteMeasurementsIndexMeasuredValue =
        Namespaced_IRI.parse _namespace_name "_SiteMeasurementsIndexMeasuredValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementSiteReference"></see>
    /// </summary>
    let measurementSiteReference =
        Namespaced_IRI.parse _namespace_name "measurementSiteReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_MeasurementSiteRecordVersionedReference"></see>
    /// </summary>
    let _MeasurementSiteRecordVersionedReference =
        Namespaced_IRI.parse _namespace_name "_MeasurementSiteRecordVersionedReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementTimeDefault"></see>
    /// </summary>
    let measurementTimeDefault =
        Namespaced_IRI.parse _namespace_name "measurementTimeDefault" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#siteMeasurementsExtension"></see>
    /// </summary>
    let siteMeasurementsExtension =
        Namespaced_IRI.parse _namespace_name "siteMeasurementsExtension" |> NamespacedName

    /// <summary>
    /// An identifiable instance of a traffic/travel situation comprising one or more traffic/travel circumstances which are linked by one or more causal relationships. Each traffic/travel circumstance is represented by a Situation Record.
    /// <see href="http://vocab.datex.org/terms#Situation"></see></summary>
    let Situation = Namespaced_IRI.parse _namespace_name "Situation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#overallSeverity"></see>
    /// </summary>
    let overallSeverity =
        Namespaced_IRI.parse _namespace_name "overallSeverity" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#relatedSituation"></see>
    /// </summary>
    let relatedSituation =
        Namespaced_IRI.parse _namespace_name "relatedSituation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_SituationVersionedReference"></see>
    /// </summary>
    let _SituationVersionedReference =
        Namespaced_IRI.parse _namespace_name "_SituationVersionedReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#situationExtension"></see>
    /// </summary>
    let situationExtension =
        Namespaced_IRI.parse _namespace_name "situationExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#situationRecord"></see>
    /// </summary>
    let situationRecord =
        Namespaced_IRI.parse _namespace_name "situationRecord" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#situationVersionTime"></see>
    /// </summary>
    let situationVersionTime =
        Namespaced_IRI.parse _namespace_name "situationVersionTime" |> NamespacedName

    /// <summary>
    /// A publication containing zero or more traffic/travel situations.
    /// <see href="http://vocab.datex.org/terms#SituationPublication"></see></summary>
    let SituationPublication =
        Namespaced_IRI.parse _namespace_name "SituationPublication" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#situation"></see>
    /// </summary>
    let situation = Namespaced_IRI.parse _namespace_name "situation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#situationPublicationExtension"></see>
    /// </summary>
    let situationPublicationExtension =
        Namespaced_IRI.parse _namespace_name "situationPublicationExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#cause"></see>
    /// </summary>
    let cause = Namespaced_IRI.parse _namespace_name "cause" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#confidentialityOverride"></see>
    /// </summary>
    let confidentialityOverride =
        Namespaced_IRI.parse _namespace_name "confidentialityOverride" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#generalPublicComment"></see>
    /// </summary>
    let generalPublicComment =
        Namespaced_IRI.parse _namespace_name "generalPublicComment" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#impact"></see>
    /// </summary>
    let impact = Namespaced_IRI.parse _namespace_name "impact" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#management"></see>
    /// </summary>
    let management = Namespaced_IRI.parse _namespace_name "management" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#nonGeneralPublicComment"></see>
    /// </summary>
    let nonGeneralPublicComment =
        Namespaced_IRI.parse _namespace_name "nonGeneralPublicComment" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#probabilityOfOccurrence"></see>
    /// </summary>
    let probabilityOfOccurrence =
        Namespaced_IRI.parse _namespace_name "probabilityOfOccurrence" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#severity"></see>
    /// </summary>
    let severity = Namespaced_IRI.parse _namespace_name "severity" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#situationRecordCreationReference"></see>
    /// </summary>
    let situationRecordCreationReference =
        Namespaced_IRI.parse _namespace_name "situationRecordCreationReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#situationRecordCreationTime"></see>
    /// </summary>
    let situationRecordCreationTime =
        Namespaced_IRI.parse _namespace_name "situationRecordCreationTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#situationRecordExtension"></see>
    /// </summary>
    let situationRecordExtension =
        Namespaced_IRI.parse _namespace_name "situationRecordExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_SituationRecordExtensionType"></see>
    /// </summary>
    let _SituationRecordExtensionType =
        Namespaced_IRI.parse _namespace_name "_SituationRecordExtensionType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#situationRecordFirstSupplierVersionTime"></see>
    /// </summary>
    let situationRecordFirstSupplierVersionTime =
        Namespaced_IRI.parse _namespace_name "situationRecordFirstSupplierVersionTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#situationRecordObservationTime"></see>
    /// </summary>
    let situationRecordObservationTime =
        Namespaced_IRI.parse _namespace_name "situationRecordObservationTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#situationRecordVersionTime"></see>
    /// </summary>
    let situationRecordVersionTime =
        Namespaced_IRI.parse _namespace_name "situationRecordVersionTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#urlLink"></see>
    /// </summary>
    let urlLink = Namespaced_IRI.parse _namespace_name "urlLink" |> NamespacedName
    /// <summary>
    /// Details of a Uniform Resource Locator (URL) address pointing to a resource available on the Internet from where further relevant information may be obtained.
    /// <see href="http://vocab.datex.org/terms#UrlLink"></see></summary>
    let UrlLink = Namespaced_IRI.parse _namespace_name "UrlLink" |> NamespacedName

    /// <summary>
    /// Extension class for SituationRecord.
    /// <see href="http://vocab.datex.org/terms#SituationRecordExtendedApproved"></see></summary>
    let SituationRecordExtendedApproved =
        Namespaced_IRI.parse _namespace_name "SituationRecordExtendedApproved" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#safetyRelatedMessage"></see>
    /// </summary>
    let safetyRelatedMessage =
        Namespaced_IRI.parse _namespace_name "safetyRelatedMessage" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#reliable"></see>
    /// </summary>
    let reliable = Namespaced_IRI.parse _namespace_name "reliable" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#sourceCountry"></see>
    /// </summary>
    let sourceCountry =
        Namespaced_IRI.parse _namespace_name "sourceCountry" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#sourceExtension"></see>
    /// </summary>
    let sourceExtension =
        Namespaced_IRI.parse _namespace_name "sourceExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#sourceIdentification"></see>
    /// </summary>
    let sourceIdentification =
        Namespaced_IRI.parse _namespace_name "sourceIdentification" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#sourceName"></see>
    /// </summary>
    let sourceName = Namespaced_IRI.parse _namespace_name "sourceName" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#sourceType"></see>
    /// </summary>
    let sourceType = Namespaced_IRI.parse _namespace_name "sourceType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#intersectWithApplicableDays"></see>
    /// </summary>
    let intersectWithApplicableDays =
        Namespaced_IRI.parse _namespace_name "intersectWithApplicableDays" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#publicHoliday"></see>
    /// </summary>
    let publicHoliday =
        Namespaced_IRI.parse _namespace_name "publicHoliday" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#specialDayExtension"></see>
    /// </summary>
    let specialDayExtension =
        Namespaced_IRI.parse _namespace_name "specialDayExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#specialDayName"></see>
    /// </summary>
    let specialDayName =
        Namespaced_IRI.parse _namespace_name "specialDayName" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#specialDayType"></see>
    /// </summary>
    let specialDayType =
        Namespaced_IRI.parse _namespace_name "specialDayType" |> NamespacedName

    /// <summary>
    /// A parking site which is located at a special location, often associated with some building.
    /// <see href="http://vocab.datex.org/terms#SpecialLocationParkingSite"></see></summary>
    let SpecialLocationParkingSite =
        Namespaced_IRI.parse _namespace_name "SpecialLocationParkingSite" |> NamespacedName

    /// <summary>
    /// A special location not available in the enumeration. Use literal 'other' in this case.
    /// <see href="http://vocab.datex.org/terms#parkingOtherSpecialLocation"></see></summary>
    let parkingOtherSpecialLocation =
        Namespaced_IRI.parse _namespace_name "parkingOtherSpecialLocation" |> NamespacedName

    /// <summary>
    /// The special location of the parking site.
    /// <see href="http://vocab.datex.org/terms#parkingSpecialLocation"></see></summary>
    let parkingSpecialLocation =
        Namespaced_IRI.parse _namespace_name "parkingSpecialLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#specialLocationParkingSiteExtension"></see>
    /// </summary>
    let specialLocationParkingSiteExtension =
        Namespaced_IRI.parse _namespace_name "specialLocationParkingSiteExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#speedManagementExtension"></see>
    /// </summary>
    let speedManagementExtension =
        Namespaced_IRI.parse _namespace_name "speedManagementExtension" |> NamespacedName

    /// <summary>
    /// Type of speed management action instigated by operator.
    /// <see href="http://vocab.datex.org/terms#speedManagementType"></see></summary>
    let speedManagementType =
        Namespaced_IRI.parse _namespace_name "speedManagementType" |> NamespacedName

    /// <summary>
    /// Temporary limit defining the maximum advisory or mandatory speed of vehicles.
    /// <see href="http://vocab.datex.org/terms#temporarySpeedLimit"></see></summary>
    let temporarySpeedLimit =
        Namespaced_IRI.parse _namespace_name "temporarySpeedLimit" |> NamespacedName

    /// <summary>
    /// Details of percentage (from an observation set) of vehicles whose speeds fall below a stated value.
    /// <see href="http://vocab.datex.org/terms#SpeedPercentile"></see></summary>
    let SpeedPercentile =
        Namespaced_IRI.parse _namespace_name "SpeedPercentile" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#speedPercentile"></see>
    /// </summary>
    let speedPercentile =
        Namespaced_IRI.parse _namespace_name "speedPercentile" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#speedPercentileExtension"></see>
    /// </summary>
    let speedPercentileExtension =
        Namespaced_IRI.parse _namespace_name "speedPercentileExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehiclePercentage"></see>
    /// </summary>
    let vehiclePercentage =
        Namespaced_IRI.parse _namespace_name "vehiclePercentage" |> NamespacedName

    /// <summary>
    /// A value of speed expressed in kilometres per hour.
    /// <see href="http://vocab.datex.org/terms#speed"></see></summary>
    let speed = Namespaced_IRI.parse _namespace_name "speed" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#speedValueExtension"></see>
    /// </summary>
    let speedValueExtension =
        Namespaced_IRI.parse _namespace_name "speedValueExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#numberOfSubjects"></see>
    /// </summary>
    let numberOfSubjects =
        Namespaced_IRI.parse _namespace_name "numberOfSubjects" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#subjectTypeOfWorks"></see>
    /// </summary>
    let subjectTypeOfWorks =
        Namespaced_IRI.parse _namespace_name "subjectTypeOfWorks" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#subjectsExtension"></see>
    /// </summary>
    let subjectsExtension =
        Namespaced_IRI.parse _namespace_name "subjectsExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#deleteSubscription"></see>
    /// </summary>
    let deleteSubscription =
        Namespaced_IRI.parse _namespace_name "deleteSubscription" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#deliveryInterval"></see>
    /// </summary>
    let deliveryInterval =
        Namespaced_IRI.parse _namespace_name "deliveryInterval" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#operatingMode"></see>
    /// </summary>
    let operatingMode =
        Namespaced_IRI.parse _namespace_name "operatingMode" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#subscriptionExtension"></see>
    /// </summary>
    let subscriptionExtension =
        Namespaced_IRI.parse _namespace_name "subscriptionExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#subscriptionStartTime"></see>
    /// </summary>
    let subscriptionStartTime =
        Namespaced_IRI.parse _namespace_name "subscriptionStartTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#subscriptionState"></see>
    /// </summary>
    let subscriptionState =
        Namespaced_IRI.parse _namespace_name "subscriptionState" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#subscriptionStopTime"></see>
    /// </summary>
    let subscriptionStopTime =
        Namespaced_IRI.parse _namespace_name "subscriptionStopTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#updateMethod"></see>
    /// </summary>
    let updateMethod =
        Namespaced_IRI.parse _namespace_name "updateMethod" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#locationPrecision"></see>
    /// </summary>
    let locationPrecision =
        Namespaced_IRI.parse _namespace_name "locationPrecision" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#affectedCarriagewayAndLanes"></see>
    /// </summary>
    let affectedCarriagewayAndLanes =
        Namespaced_IRI.parse _namespace_name "affectedCarriagewayAndLanes" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#locationDescriptor"></see>
    /// </summary>
    let locationDescriptor =
        Namespaced_IRI.parse _namespace_name "locationDescriptor" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#sequentialRampNumber"></see>
    /// </summary>
    let sequentialRampNumber =
        Namespaced_IRI.parse _namespace_name "sequentialRampNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#supplementaryPositionalDescriptionExtension"></see>
    /// </summary>
    let supplementaryPositionalDescriptionExtension =
        Namespaced_IRI.parse _namespace_name "supplementaryPositionalDescriptionExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#address"></see>
    /// </summary>
    let address = Namespaced_IRI.parse _namespace_name "address" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#protocol"></see>
    /// </summary>
    let protocol = Namespaced_IRI.parse _namespace_name "protocol" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#targetExtension"></see>
    /// </summary>
    let targetExtension =
        Namespaced_IRI.parse _namespace_name "targetExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#acceptedMeansOfPayment"></see>
    /// </summary>
    let acceptedMeansOfPayment =
        Namespaced_IRI.parse _namespace_name "acceptedMeansOfPayment" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#acceptedPaymentCards"></see>
    /// </summary>
    let acceptedPaymentCards =
        Namespaced_IRI.parse _namespace_name "acceptedPaymentCards" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#chargeBand"></see>
    /// </summary>
    let chargeBand = Namespaced_IRI.parse _namespace_name "chargeBand" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#chargeBandByReference"></see>
    /// </summary>
    let chargeBandByReference =
        Namespaced_IRI.parse _namespace_name "chargeBandByReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#freeOfCharge"></see>
    /// </summary>
    let freeOfCharge =
        Namespaced_IRI.parse _namespace_name "freeOfCharge" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#paymentAdditionalDescription"></see>
    /// </summary>
    let paymentAdditionalDescription =
        Namespaced_IRI.parse _namespace_name "paymentAdditionalDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#paymentMode"></see>
    /// </summary>
    let paymentMode =
        Namespaced_IRI.parse _namespace_name "paymentMode" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#reservationFee"></see>
    /// </summary>
    let reservationFee =
        Namespaced_IRI.parse _namespace_name "reservationFee" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tariffsAndPaymentExtension"></see>
    /// </summary>
    let tariffsAndPaymentExtension =
        Namespaced_IRI.parse _namespace_name "tariffsAndPaymentExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#airTemperature"></see>
    /// </summary>
    let airTemperature =
        Namespaced_IRI.parse _namespace_name "airTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#dewPointTemperature"></see>
    /// </summary>
    let dewPointTemperature =
        Namespaced_IRI.parse _namespace_name "dewPointTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maximumTemperature"></see>
    /// </summary>
    let maximumTemperature =
        Namespaced_IRI.parse _namespace_name "maximumTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#minimumTemperature"></see>
    /// </summary>
    let minimumTemperature =
        Namespaced_IRI.parse _namespace_name "minimumTemperature" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#temperatureExtension"></see>
    /// </summary>
    let temperatureExtension =
        Namespaced_IRI.parse _namespace_name "temperatureExtension" |> NamespacedName

    /// <summary>
    /// Measurements of atmospheric temperature.
    /// <see href="http://vocab.datex.org/terms#TemperatureInformation"></see></summary>
    let TemperatureInformation =
        Namespaced_IRI.parse _namespace_name "TemperatureInformation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#temperatureInformationExtension"></see>
    /// </summary>
    let temperatureInformationExtension =
        Namespaced_IRI.parse _namespace_name "temperatureInformationExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#temperatureValueExtension"></see>
    /// </summary>
    let temperatureValueExtension =
        Namespaced_IRI.parse _namespace_name "temperatureValueExtension" |> NamespacedName

    /// <summary>
    /// Settings specific to a distinct text display area on the VMS.
    /// <see href="http://vocab.datex.org/terms#TextDisplayAreaSettings"></see></summary>
    let TextDisplayAreaSettings =
        Namespaced_IRI.parse _namespace_name "TextDisplayAreaSettings" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#textDisplayAreaSettingsExtension"></see>
    /// </summary>
    let textDisplayAreaSettingsExtension =
        Namespaced_IRI.parse _namespace_name "textDisplayAreaSettingsExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#textLanternsOn"></see>
    /// </summary>
    let textLanternsOn =
        Namespaced_IRI.parse _namespace_name "textLanternsOn" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#textLuminanceLevel"></see>
    /// </summary>
    let textLuminanceLevel =
        Namespaced_IRI.parse _namespace_name "textLuminanceLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#textLuminanceLevelName"></see>
    /// </summary>
    let textLuminanceLevelName =
        Namespaced_IRI.parse _namespace_name "textLuminanceLevelName" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#textLuminanceOverride"></see>
    /// </summary>
    let textLuminanceOverride =
        Namespaced_IRI.parse _namespace_name "textLuminanceOverride" |> NamespacedName

    /// <summary>
    /// End of time period.
    /// <see href="http://vocab.datex.org/terms#endTimeOfPeriod"></see></summary>
    let endTimeOfPeriod =
        Namespaced_IRI.parse _namespace_name "endTimeOfPeriod" |> NamespacedName

    /// <summary>
    /// Start of time period.
    /// <see href="http://vocab.datex.org/terms#startTimeOfPeriod"></see></summary>
    let startTimeOfPeriod =
        Namespaced_IRI.parse _namespace_name "startTimeOfPeriod" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#timePeriodByHourExtension"></see>
    /// </summary>
    let timePeriodByHourExtension =
        Namespaced_IRI.parse _namespace_name "timePeriodByHourExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#timePeriodOfDayExtension"></see>
    /// </summary>
    let timePeriodOfDayExtension =
        Namespaced_IRI.parse _namespace_name "timePeriodOfDayExtension" |> NamespacedName

    /// <summary>
    /// A descriptor for describing an area location.
    /// <see href="http://vocab.datex.org/terms#TpegAreaDescriptor"></see></summary>
    let TpegAreaDescriptor =
        Namespaced_IRI.parse _namespace_name "TpegAreaDescriptor" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegAreaDescriptorExtension"></see>
    /// </summary>
    let tpegAreaDescriptorExtension =
        Namespaced_IRI.parse _namespace_name "tpegAreaDescriptorExtension" |> NamespacedName

    /// <summary>
    /// The nature of the descriptor used to define the location under consideration (derived from the TPEG Loc table 03).
    /// <see href="http://vocab.datex.org/terms#tpegAreaDescriptorType"></see></summary>
    let tpegAreaDescriptorType =
        Namespaced_IRI.parse _namespace_name "tpegAreaDescriptorType" |> NamespacedName

    /// <summary>
    /// A collection of information providing descriptive references to locations using the TPEG-Loc location referencing approach.
    /// <see href="http://vocab.datex.org/terms#TpegDescriptor"></see></summary>
    let TpegDescriptor =
        Namespaced_IRI.parse _namespace_name "TpegDescriptor" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegAreaLocationExtension"></see>
    /// </summary>
    let tpegAreaLocationExtension =
        Namespaced_IRI.parse _namespace_name "tpegAreaLocationExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegAreaLocationType"></see>
    /// </summary>
    let tpegAreaLocationType =
        Namespaced_IRI.parse _namespace_name "tpegAreaLocationType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegHeight"></see>
    /// </summary>
    let tpegHeight = Namespaced_IRI.parse _namespace_name "tpegHeight" |> NamespacedName
    /// <summary>
    /// Height information which provides additional discrimination for the applicable area.
    /// <see href="http://vocab.datex.org/terms#TpegHeight"></see></summary>
    let TpegHeight = Namespaced_IRI.parse _namespace_name "TpegHeight" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#descriptor"></see>
    /// </summary>
    let descriptor = Namespaced_IRI.parse _namespace_name "descriptor" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegDescriptorExtension"></see>
    /// </summary>
    let tpegDescriptorExtension =
        Namespaced_IRI.parse _namespace_name "tpegDescriptorExtension" |> NamespacedName

    /// <summary>
    /// A point on the road network which is framed between two other points on the same road.
    /// <see href="http://vocab.datex.org/terms#TpegFramedPoint"></see></summary>
    let TpegFramedPoint =
        Namespaced_IRI.parse _namespace_name "TpegFramedPoint" |> NamespacedName

    /// <summary>
    /// A single non junction point on the road network which is framed between two other specified points on the road network.
    /// <see href="http://vocab.datex.org/terms#framedPoint"></see></summary>
    let framedPoint =
        Namespaced_IRI.parse _namespace_name "framedPoint" |> NamespacedName

    /// <summary>
    /// A point on the road network which is not a road junction point.
    /// <see href="http://vocab.datex.org/terms#TpegNonJunctionPoint"></see></summary>
    let TpegNonJunctionPoint =
        Namespaced_IRI.parse _namespace_name "TpegNonJunctionPoint" |> NamespacedName

    /// <summary>
    /// The location at the up stream end of the section of road which frames the TPEGFramedPoint.
    /// <see href="http://vocab.datex.org/terms#from"></see></summary>
    let from = Namespaced_IRI.parse _namespace_name "from" |> NamespacedName
    /// <summary>
    /// A point on the road network which is either a junction point or a non junction point.
    /// <see href="http://vocab.datex.org/terms#TpegPoint"></see></summary>
    let TpegPoint = Namespaced_IRI.parse _namespace_name "TpegPoint" |> NamespacedName
    /// <summary>
    /// The location at the down stream end of the section of road which frames the TPEGFramedPoint.
    /// <see href="http://vocab.datex.org/terms#to"></see></summary>
    let to_ = Namespaced_IRI.parse _namespace_name "to" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegFramedPointExtension"></see>
    /// </summary>
    let tpegFramedPointExtension =
        Namespaced_IRI.parse _namespace_name "tpegFramedPointExtension" |> NamespacedName

    /// <summary>
    /// The type of TPEG location.
    /// <see href="http://vocab.datex.org/terms#tpegFramedPointLocationType"></see></summary>
    let tpegFramedPointLocationType =
        Namespaced_IRI.parse _namespace_name "tpegFramedPointLocationType" |> NamespacedName

    /// <summary>
    /// A geometric area defined by a centre point and a radius.
    /// <see href="http://vocab.datex.org/terms#TpegGeometricArea"></see></summary>
    let TpegGeometricArea =
        Namespaced_IRI.parse _namespace_name "TpegGeometricArea" |> NamespacedName

    /// <summary>
    /// Centre point of a circular geometric area.
    /// <see href="http://vocab.datex.org/terms#centrePoint"></see></summary>
    let centrePoint =
        Namespaced_IRI.parse _namespace_name "centrePoint" |> NamespacedName

    /// <summary>
    /// A descriptive name which helps to identify the non junction point. At least one descriptor must identify the road on which the point is located, i.e. must be of type 'linkName' or 'localLinkName'.
    /// A name which identifies a junction point on the road network
    /// Name of area.
    /// <see href="http://vocab.datex.org/terms#name"></see></summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegGeometricAreaExtension"></see>
    /// </summary>
    let tpegGeometricAreaExtension =
        Namespaced_IRI.parse _namespace_name "tpegGeometricAreaExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#height"></see>
    /// </summary>
    let height = Namespaced_IRI.parse _namespace_name "height" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#heightType"></see>
    /// </summary>
    let heightType = Namespaced_IRI.parse _namespace_name "heightType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegHeightExtension"></see>
    /// </summary>
    let tpegHeightExtension =
        Namespaced_IRI.parse _namespace_name "tpegHeightExtension" |> NamespacedName

    /// <summary>
    /// A descriptor for describing a junction by defining the intersecting roads.
    /// <see href="http://vocab.datex.org/terms#TpegIlcPointDescriptor"></see></summary>
    let TpegIlcPointDescriptor =
        Namespaced_IRI.parse _namespace_name "TpegIlcPointDescriptor" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegIlcPointDescriptorExtension"></see>
    /// </summary>
    let tpegIlcPointDescriptorExtension =
        Namespaced_IRI.parse _namespace_name "tpegIlcPointDescriptorExtension" |> NamespacedName

    /// <summary>
    /// The nature of the descriptor used to define the location under consideration (derived from the TPEG Loc table 03).
    /// <see href="http://vocab.datex.org/terms#tpegIlcPointDescriptorType"></see></summary>
    let tpegIlcPointDescriptorType =
        Namespaced_IRI.parse _namespace_name "tpegIlcPointDescriptorType" |> NamespacedName

    /// <summary>
    /// A descriptor for describing a point location.
    /// <see href="http://vocab.datex.org/terms#TpegPointDescriptor"></see></summary>
    let TpegPointDescriptor =
        Namespaced_IRI.parse _namespace_name "TpegPointDescriptor" |> NamespacedName

    /// <summary>
    /// A point on the road network which is a road junction point.
    /// <see href="http://vocab.datex.org/terms#TpegJunction"></see></summary>
    let TpegJunction =
        Namespaced_IRI.parse _namespace_name "TpegJunction" |> NamespacedName

    /// <summary>
    /// A descriptor for describing a junction by identifying the intersecting roads at a road junction.
    /// <see href="http://vocab.datex.org/terms#ilc"></see></summary>
    let ilc = Namespaced_IRI.parse _namespace_name "ilc" |> NamespacedName

    /// <summary>
    /// A descriptor for describing a point at a junction on a road network.
    /// <see href="http://vocab.datex.org/terms#TpegJunctionPointDescriptor"></see></summary>
    let TpegJunctionPointDescriptor =
        Namespaced_IRI.parse _namespace_name "TpegJunctionPointDescriptor" |> NamespacedName

    /// <summary>
    /// A descriptive name which helps to identify the junction point.
    /// <see href="http://vocab.datex.org/terms#otherName"></see></summary>
    let otherName = Namespaced_IRI.parse _namespace_name "otherName" |> NamespacedName

    /// <summary>
    /// General descriptor for describing a point.
    /// <see href="http://vocab.datex.org/terms#TpegOtherPointDescriptor"></see></summary>
    let TpegOtherPointDescriptor =
        Namespaced_IRI.parse _namespace_name "TpegOtherPointDescriptor" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegJunctionExtension"></see>
    /// </summary>
    let tpegJunctionExtension =
        Namespaced_IRI.parse _namespace_name "tpegJunctionExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegJunctionPointDescriptorExtension"></see>
    /// </summary>
    let tpegJunctionPointDescriptorExtension =
        Namespaced_IRI.parse _namespace_name "tpegJunctionPointDescriptorExtension" |> NamespacedName

    /// <summary>
    /// The nature of the descriptor used to define the location under consideration (derived from the TPEG Loc table 03).
    /// <see href="http://vocab.datex.org/terms#tpegJunctionPointDescriptorType"></see></summary>
    let tpegJunctionPointDescriptorType =
        Namespaced_IRI.parse _namespace_name "tpegJunctionPointDescriptorType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegDirection"></see>
    /// </summary>
    let tpegDirection =
        Namespaced_IRI.parse _namespace_name "tpegDirection" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegLinearLocationExtension"></see>
    /// </summary>
    let tpegLinearLocationExtension =
        Namespaced_IRI.parse _namespace_name "tpegLinearLocationExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegLinearLocationType"></see>
    /// </summary>
    let tpegLinearLocationType =
        Namespaced_IRI.parse _namespace_name "tpegLinearLocationType" |> NamespacedName

    /// <summary>
    /// An area defined by a well-known name.
    /// <see href="http://vocab.datex.org/terms#TpegNamedOnlyArea"></see></summary>
    let TpegNamedOnlyArea =
        Namespaced_IRI.parse _namespace_name "TpegNamedOnlyArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegNamedOnlyAreaExtension"></see>
    /// </summary>
    let tpegNamedOnlyAreaExtension =
        Namespaced_IRI.parse _namespace_name "tpegNamedOnlyAreaExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegNonJunctionPointExtension"></see>
    /// </summary>
    let tpegNonJunctionPointExtension =
        Namespaced_IRI.parse _namespace_name "tpegNonJunctionPointExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegOtherPointDescriptorExtension"></see>
    /// </summary>
    let tpegOtherPointDescriptorExtension =
        Namespaced_IRI.parse _namespace_name "tpegOtherPointDescriptorExtension" |> NamespacedName

    /// <summary>
    /// The nature of the descriptor used to define the location under consideration (derived from the TPEG Loc table 03).
    /// <see href="http://vocab.datex.org/terms#tpegOtherPointDescriptorType"></see></summary>
    let tpegOtherPointDescriptorType =
        Namespaced_IRI.parse _namespace_name "tpegOtherPointDescriptorType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegPointExtension"></see>
    /// </summary>
    let tpegPointExtension =
        Namespaced_IRI.parse _namespace_name "tpegPointExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegPointDescriptorExtension"></see>
    /// </summary>
    let tpegPointDescriptorExtension =
        Namespaced_IRI.parse _namespace_name "tpegPointDescriptorExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegPointLocationExtension"></see>
    /// </summary>
    let tpegPointLocationExtension =
        Namespaced_IRI.parse _namespace_name "tpegPointLocationExtension" |> NamespacedName

    /// <summary>
    /// A point on the road network which is not bounded by any other points on the road network.
    /// <see href="http://vocab.datex.org/terms#TpegSimplePoint"></see></summary>
    let TpegSimplePoint =
        Namespaced_IRI.parse _namespace_name "TpegSimplePoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#tpegSimplePointExtension"></see>
    /// </summary>
    let tpegSimplePointExtension =
        Namespaced_IRI.parse _namespace_name "tpegSimplePointExtension" |> NamespacedName

    /// <summary>
    /// The type of TPEG location.
    /// <see href="http://vocab.datex.org/terms#tpegSimplePointLocationType"></see></summary>
    let tpegSimplePointLocationType =
        Namespaced_IRI.parse _namespace_name "tpegSimplePointLocationType" |> NamespacedName

    /// <summary>
    /// Averaged measurements or calculations of traffic concentration.
    /// <see href="http://vocab.datex.org/terms#TrafficConcentration"></see></summary>
    let TrafficConcentration =
        Namespaced_IRI.parse _namespace_name "TrafficConcentration" |> NamespacedName

    /// <summary>
    /// An averaged measurement or calculation of the concentration of vehicles at the specified measurement site.
    /// <see href="http://vocab.datex.org/terms#concentration"></see></summary>
    let concentration =
        Namespaced_IRI.parse _namespace_name "concentration" |> NamespacedName

    /// <summary>
    /// An averaged measurement or calculation of the percentage of time that a section of road at the specified measurement site is occupied by vehicles.
    /// <see href="http://vocab.datex.org/terms#occupancy"></see></summary>
    let occupancy = Namespaced_IRI.parse _namespace_name "occupancy" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#trafficConcentrationExtension"></see>
    /// </summary>
    let trafficConcentrationExtension =
        Namespaced_IRI.parse _namespace_name "trafficConcentrationExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#trafficDataExtension"></see>
    /// </summary>
    let trafficDataExtension =
        Namespaced_IRI.parse _namespace_name "trafficDataExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#trafficElementExtension"></see>
    /// </summary>
    let trafficElementExtension =
        Namespaced_IRI.parse _namespace_name "trafficElementExtension" |> NamespacedName

    /// <summary>
    /// Averaged measurements or calculations of traffic flow rates.
    /// <see href="http://vocab.datex.org/terms#TrafficFlow"></see></summary>
    let TrafficFlow =
        Namespaced_IRI.parse _namespace_name "TrafficFlow" |> NamespacedName

    /// <summary>
    /// An averaged measurement or calculation of flow rate defined in terms of the number of vehicle axles passing the specified measurement site.
    /// <see href="http://vocab.datex.org/terms#axleFlow"></see></summary>
    let axleFlow = Namespaced_IRI.parse _namespace_name "axleFlow" |> NamespacedName
    /// <summary>
    /// An averaged measurement or calculation of flow rate defined in terms of the number of passenger car units passing the specified measurement site.
    /// <see href="http://vocab.datex.org/terms#pcuFlow"></see></summary>
    let pcuFlow = Namespaced_IRI.parse _namespace_name "pcuFlow" |> NamespacedName

    /// <summary>
    /// An averaged measurement or calculation of the percentage of long vehicles contained in the traffic flow at the specified measurement site.
    /// <see href="http://vocab.datex.org/terms#percentageLongVehicles"></see></summary>
    let percentageLongVehicles =
        Namespaced_IRI.parse _namespace_name "percentageLongVehicles" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#trafficFlowExtension"></see>
    /// </summary>
    let trafficFlowExtension =
        Namespaced_IRI.parse _namespace_name "trafficFlowExtension" |> NamespacedName

    /// <summary>
    /// An averaged measurement of flow rate defined in terms of the number of vehicles passing the specified measurement site.
    /// <see href="http://vocab.datex.org/terms#vehicleFlow"></see></summary>
    let vehicleFlow =
        Namespaced_IRI.parse _namespace_name "vehicleFlow" |> NamespacedName

    /// <summary>
    /// A measured or calculated value of the flow rate of vehicles.
    /// <see href="http://vocab.datex.org/terms#VehicleFlowValue"></see></summary>
    let VehicleFlowValue =
        Namespaced_IRI.parse _namespace_name "VehicleFlowValue" |> NamespacedName

    /// <summary>
    /// Averaged measurements or calculations of traffic headway, i.e. the distance or time interval between vehicles. This measure is measured from the head of one vehicle to the head of the following vehicle.
    /// <see href="http://vocab.datex.org/terms#TrafficHeadway"></see></summary>
    let TrafficHeadway =
        Namespaced_IRI.parse _namespace_name "TrafficHeadway" |> NamespacedName

    /// <summary>
    /// The average distance between the front (respectively back) of this vehicle and the front (respectively  back) of the preceding vehicle, averaged for all vehicles within a defined measurement period at the specified measurement site.
    /// <see href="http://vocab.datex.org/terms#averageDistanceHeadway"></see></summary>
    let averageDistanceHeadway =
        Namespaced_IRI.parse _namespace_name "averageDistanceHeadway" |> NamespacedName

    /// <summary>
    /// The average time gap between the front (respectively back) of this vehicle and the front (respectively  back) of the preceding vehicle, averaged for all vehicles within a defined measurement period at the specified measurement site.
    /// <see href="http://vocab.datex.org/terms#averageTimeHeadway"></see></summary>
    let averageTimeHeadway =
        Namespaced_IRI.parse _namespace_name "averageTimeHeadway" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#trafficHeadwayExtension"></see>
    /// </summary>
    let trafficHeadwayExtension =
        Namespaced_IRI.parse _namespace_name "trafficHeadwayExtension" |> NamespacedName

    /// <summary>
    /// Averaged measurements or calculations of traffic speed.
    /// <see href="http://vocab.datex.org/terms#TrafficSpeed"></see></summary>
    let TrafficSpeed =
        Namespaced_IRI.parse _namespace_name "TrafficSpeed" |> NamespacedName

    /// <summary>
    /// An averaged measurement or calculation of the speed of vehicles at the specified location.
    /// <see href="http://vocab.datex.org/terms#averageVehicleSpeed"></see></summary>
    let averageVehicleSpeed =
        Namespaced_IRI.parse _namespace_name "averageVehicleSpeed" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#trafficSpeedExtension"></see>
    /// </summary>
    let trafficSpeedExtension =
        Namespaced_IRI.parse _namespace_name "trafficSpeedExtension" |> NamespacedName

    /// <summary>
    /// The status of traffic conditions on a specific section or at a specific point on the road network.
    /// <see href="http://vocab.datex.org/terms#TrafficStatus"></see></summary>
    let TrafficStatus =
        Namespaced_IRI.parse _namespace_name "TrafficStatus" |> NamespacedName

    /// <summary>
    /// Status of traffic conditions on the identified section of road in the specified direction.
    /// <see href="http://vocab.datex.org/terms#trafficStatus"></see></summary>
    let trafficStatus =
        Namespaced_IRI.parse _namespace_name "trafficStatus" |> NamespacedName

    /// <summary>
    /// A measured or calculated value of the status of traffic conditions on a section of road in a specified direction.
    /// <see href="http://vocab.datex.org/terms#TrafficStatusValue"></see></summary>
    let TrafficStatusValue =
        Namespaced_IRI.parse _namespace_name "TrafficStatusValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#trafficStatusExtension"></see>
    /// </summary>
    let trafficStatusExtension =
        Namespaced_IRI.parse _namespace_name "trafficStatusExtension" |> NamespacedName

    /// <summary>
    /// A status value of traffic conditions on the identified section of road in the specified direction.
    /// <see href="http://vocab.datex.org/terms#trafficStatusValue"></see></summary>
    let trafficStatusValue =
        Namespaced_IRI.parse _namespace_name "trafficStatusValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#trafficStatusValueExtension"></see>
    /// </summary>
    let trafficStatusValueExtension =
        Namespaced_IRI.parse _namespace_name "trafficStatusValueExtension" |> NamespacedName

    /// <summary>
    /// An identifiable instance of a traffic view at a single point in time relating to a predefined location set, comprising one or more linear traffic views each of which comprise one or more traffic view records.
    /// <see href="http://vocab.datex.org/terms#TrafficView"></see></summary>
    let TrafficView =
        Namespaced_IRI.parse _namespace_name "TrafficView" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#linearTrafficView"></see>
    /// </summary>
    let linearTrafficView =
        Namespaced_IRI.parse _namespace_name "linearTrafficView" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#trafficViewExtension"></see>
    /// </summary>
    let trafficViewExtension =
        Namespaced_IRI.parse _namespace_name "trafficViewExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#trafficViewTime"></see>
    /// </summary>
    let trafficViewTime =
        Namespaced_IRI.parse _namespace_name "trafficViewTime" |> NamespacedName

    /// <summary>
    /// A publication containing one or more traffic views.
    /// <see href="http://vocab.datex.org/terms#TrafficViewPublication"></see></summary>
    let TrafficViewPublication =
        Namespaced_IRI.parse _namespace_name "TrafficViewPublication" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#trafficView"></see>
    /// </summary>
    let trafficView =
        Namespaced_IRI.parse _namespace_name "trafficView" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#trafficViewPublicationExtension"></see>
    /// </summary>
    let trafficViewPublicationExtension =
        Namespaced_IRI.parse _namespace_name "trafficViewPublicationExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#operatorAction"></see>
    /// </summary>
    let operatorAction =
        Namespaced_IRI.parse _namespace_name "operatorAction" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#recordSequenceNumber"></see>
    /// </summary>
    let recordSequenceNumber =
        Namespaced_IRI.parse _namespace_name "recordSequenceNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#trafficElement"></see>
    /// </summary>
    let trafficElement =
        Namespaced_IRI.parse _namespace_name "trafficElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#trafficViewRecordExtension"></see>
    /// </summary>
    let trafficViewRecordExtension =
        Namespaced_IRI.parse _namespace_name "trafficViewRecordExtension" |> NamespacedName

    /// <summary>
    /// The availability of transit services and information relating to their departures. This is limited to those transit services which are of direct relevance to road users, e.g. connecting rail or ferry services.
    /// <see href="http://vocab.datex.org/terms#TransitInformation"></see></summary>
    let TransitInformation =
        Namespaced_IRI.parse _namespace_name "TransitInformation" |> NamespacedName

    /// <summary>
    /// Indicates the stated termination point of the transit journey.
    /// <see href="http://vocab.datex.org/terms#journeyDestination"></see></summary>
    let journeyDestination =
        Namespaced_IRI.parse _namespace_name "journeyDestination" |> NamespacedName

    /// <summary>
    /// Indicates the stated starting point of the transit journey.
    /// <see href="http://vocab.datex.org/terms#journeyOrigin"></see></summary>
    let journeyOrigin =
        Namespaced_IRI.parse _namespace_name "journeyOrigin" |> NamespacedName

    /// <summary>
    /// Indicates a transit service journey number.
    /// <see href="http://vocab.datex.org/terms#journeyReference"></see></summary>
    let journeyReference =
        Namespaced_IRI.parse _namespace_name "journeyReference" |> NamespacedName

    /// <summary>
    /// Indicates the timetabled departure time of a transit service for a specified location.
    /// <see href="http://vocab.datex.org/terms#scheduledDepartureTime"></see></summary>
    let scheduledDepartureTime =
        Namespaced_IRI.parse _namespace_name "scheduledDepartureTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#transitInformationExtension"></see>
    /// </summary>
    let transitInformationExtension =
        Namespaced_IRI.parse _namespace_name "transitInformationExtension" |> NamespacedName

    /// <summary>
    /// Information about transit services.
    /// <see href="http://vocab.datex.org/terms#transitServiceInformation"></see></summary>
    let transitServiceInformation =
        Namespaced_IRI.parse _namespace_name "transitServiceInformation" |> NamespacedName

    /// <summary>
    /// The type of transit service to which the information relates.
    /// <see href="http://vocab.datex.org/terms#transitServiceType"></see></summary>
    let transitServiceType =
        Namespaced_IRI.parse _namespace_name "transitServiceType" |> NamespacedName

    /// <summary>
    /// Derived/computed travel time information relating to a linear section of the road network; forecast = true means a forecast for a vehicle at the start of the specified location, forecast = false means calculation/measurement at the end.
    /// <see href="http://vocab.datex.org/terms#TravelTimeData"></see></summary>
    let TravelTimeData =
        Namespaced_IRI.parse _namespace_name "TravelTimeData" |> NamespacedName

    /// <summary>
    /// The free flow speed expected under ideal conditions, corresponding to the freeFlowTravelTime.
    /// <see href="http://vocab.datex.org/terms#freeFlowSpeed"></see></summary>
    let freeFlowSpeed =
        Namespaced_IRI.parse _namespace_name "freeFlowSpeed" |> NamespacedName

    /// <summary>
    /// The travel time which would be expected under ideal free flow conditions.
    /// <see href="http://vocab.datex.org/terms#freeFlowTravelTime"></see></summary>
    let freeFlowTravelTime =
        Namespaced_IRI.parse _namespace_name "freeFlowTravelTime" |> NamespacedName

    /// <summary>
    /// The travel time which is expected for the given period (e.g. date/time, holiday status etc.) and any known quasi-static conditions (e.g. long term roadworks). This value is derived from historical analysis.
    /// <see href="http://vocab.datex.org/terms#normallyExpectedTravelTime"></see></summary>
    let normallyExpectedTravelTime =
        Namespaced_IRI.parse _namespace_name "normallyExpectedTravelTime" |> NamespacedName

    /// <summary>
    /// Derived/computed travel time information relating to a specific group of locations.
    /// <see href="http://vocab.datex.org/terms#travelTime"></see></summary>
    let travelTime = Namespaced_IRI.parse _namespace_name "travelTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#travelTimeDataExtension"></see>
    /// </summary>
    let travelTimeDataExtension =
        Namespaced_IRI.parse _namespace_name "travelTimeDataExtension" |> NamespacedName

    /// <summary>
    /// The current trend in the travel time between the defined locations in the specified direction.
    /// <see href="http://vocab.datex.org/terms#travelTimeTrendType"></see></summary>
    let travelTimeTrendType =
        Namespaced_IRI.parse _namespace_name "travelTimeTrendType" |> NamespacedName

    /// <summary>
    /// Indication of the way in which the travel time is derived.
    /// <see href="http://vocab.datex.org/terms#travelTimeType"></see></summary>
    let travelTimeType =
        Namespaced_IRI.parse _namespace_name "travelTimeType" |> NamespacedName

    /// <summary>
    /// Vehicle type.
    /// <see href="http://vocab.datex.org/terms#vehicleType"></see></summary>
    let vehicleType =
        Namespaced_IRI.parse _namespace_name "vehicleType" |> NamespacedName

    /// <summary>
    /// A parking site in an urban context.
    /// <see href="http://vocab.datex.org/terms#UrbanParkingSite"></see></summary>
    let UrbanParkingSite =
        Namespaced_IRI.parse _namespace_name "UrbanParkingSite" |> NamespacedName

    /// <summary>
    /// Name or identifier of a parking zone this parking site belongs to. To be filled with the string value 'True', if there is a parking zone with unknown name.
    /// <see href="http://vocab.datex.org/terms#parkingZone"></see></summary>
    let parkingZone =
        Namespaced_IRI.parse _namespace_name "parkingZone" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#urbanParkingSiteExtension"></see>
    /// </summary>
    let urbanParkingSiteExtension =
        Namespaced_IRI.parse _namespace_name "urbanParkingSiteExtension" |> NamespacedName

    /// <summary>
    /// The type of urban parking site.
    /// <see href="http://vocab.datex.org/terms#urbanParkingSiteType"></see></summary>
    let urbanParkingSiteType =
        Namespaced_IRI.parse _namespace_name "urbanParkingSiteType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#urlLinkDescription"></see>
    /// </summary>
    let urlLinkDescription =
        Namespaced_IRI.parse _namespace_name "urlLinkDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#urlLinkExtension"></see>
    /// </summary>
    let urlLinkExtension =
        Namespaced_IRI.parse _namespace_name "urlLinkExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#urlLinkType"></see>
    /// </summary>
    let urlLinkType =
        Namespaced_IRI.parse _namespace_name "urlLinkType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#otherPaymentCard"></see>
    /// </summary>
    let otherPaymentCard =
        Namespaced_IRI.parse _namespace_name "otherPaymentCard" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#otherPaymentCardBrand"></see>
    /// </summary>
    let otherPaymentCardBrand =
        Namespaced_IRI.parse _namespace_name "otherPaymentCardBrand" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#paymentCard"></see>
    /// </summary>
    let paymentCard =
        Namespaced_IRI.parse _namespace_name "paymentCard" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#paymentCardBrand"></see>
    /// </summary>
    let paymentCardBrand =
        Namespaced_IRI.parse _namespace_name "paymentCardBrand" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#usedPaymentCardExtension"></see>
    /// </summary>
    let usedPaymentCardExtension =
        Namespaced_IRI.parse _namespace_name "usedPaymentCardExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#overrunning"></see>
    /// </summary>
    let overrunning =
        Namespaced_IRI.parse _namespace_name "overrunning" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#validityExtension"></see>
    /// </summary>
    let validityExtension =
        Namespaced_IRI.parse _namespace_name "validityExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#validityStatus"></see>
    /// </summary>
    let validityStatus =
        Namespaced_IRI.parse _namespace_name "validityStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#axleSpacingOnVehicle"></see>
    /// </summary>
    let axleSpacingOnVehicle =
        Namespaced_IRI.parse _namespace_name "axleSpacingOnVehicle" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#hazardousGoodsAssociatedWithVehicle"></see>
    /// </summary>
    let hazardousGoodsAssociatedWithVehicle =
        Namespaced_IRI.parse _namespace_name "hazardousGoodsAssociatedWithVehicle" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#specificAxleWeight"></see>
    /// </summary>
    let specificAxleWeight =
        Namespaced_IRI.parse _namespace_name "specificAxleWeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleColour"></see>
    /// </summary>
    let vehicleColour =
        Namespaced_IRI.parse _namespace_name "vehicleColour" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleCountryOfOrigin"></see>
    /// </summary>
    let vehicleCountryOfOrigin =
        Namespaced_IRI.parse _namespace_name "vehicleCountryOfOrigin" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleExtension"></see>
    /// </summary>
    let vehicleExtension =
        Namespaced_IRI.parse _namespace_name "vehicleExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleIdentifier"></see>
    /// </summary>
    let vehicleIdentifier =
        Namespaced_IRI.parse _namespace_name "vehicleIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleManufacturer"></see>
    /// </summary>
    let vehicleManufacturer =
        Namespaced_IRI.parse _namespace_name "vehicleManufacturer" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleModel"></see>
    /// </summary>
    let vehicleModel =
        Namespaced_IRI.parse _namespace_name "vehicleModel" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleRegistrationPlateIdentifier"></see>
    /// </summary>
    let vehicleRegistrationPlateIdentifier =
        Namespaced_IRI.parse _namespace_name "vehicleRegistrationPlateIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#fuelType"></see>
    /// </summary>
    let fuelType = Namespaced_IRI.parse _namespace_name "fuelType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#grossWeightCharacteristic"></see>
    /// </summary>
    let grossWeightCharacteristic =
        Namespaced_IRI.parse _namespace_name "grossWeightCharacteristic" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#heaviestAxleWeightCharacteristic"></see>
    /// </summary>
    let heaviestAxleWeightCharacteristic =
        Namespaced_IRI.parse _namespace_name "heaviestAxleWeightCharacteristic" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#heightCharacteristic"></see>
    /// </summary>
    let heightCharacteristic =
        Namespaced_IRI.parse _namespace_name "heightCharacteristic" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#lengthCharacteristic"></see>
    /// </summary>
    let lengthCharacteristic =
        Namespaced_IRI.parse _namespace_name "lengthCharacteristic" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#loadType"></see>
    /// </summary>
    let loadType = Namespaced_IRI.parse _namespace_name "loadType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#numberOfAxlesCharacteristic"></see>
    /// </summary>
    let numberOfAxlesCharacteristic =
        Namespaced_IRI.parse _namespace_name "numberOfAxlesCharacteristic" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleCharacteristicsExtension"></see>
    /// </summary>
    let vehicleCharacteristicsExtension =
        Namespaced_IRI.parse _namespace_name "vehicleCharacteristicsExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_VehicleCharacteristicsExtensionType"></see>
    /// </summary>
    let _VehicleCharacteristicsExtensionType =
        Namespaced_IRI.parse _namespace_name "_VehicleCharacteristicsExtensionType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleEquipment"></see>
    /// </summary>
    let vehicleEquipment =
        Namespaced_IRI.parse _namespace_name "vehicleEquipment" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleUsage"></see>
    /// </summary>
    let vehicleUsage =
        Namespaced_IRI.parse _namespace_name "vehicleUsage" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#widthCharacteristic"></see>
    /// </summary>
    let widthCharacteristic =
        Namespaced_IRI.parse _namespace_name "widthCharacteristic" |> NamespacedName

    /// <summary>
    /// Width characteristic of a vehicle.
    /// <see href="http://vocab.datex.org/terms#WidthCharacteristic"></see></summary>
    let WidthCharacteristic =
        Namespaced_IRI.parse _namespace_name "WidthCharacteristic" |> NamespacedName

    /// <summary>
    /// Extension point for 'VehicleCharacteristics' to support additional attributes and literals like additional fuel types, load types etc.
    /// <see href="http://vocab.datex.org/terms#VehicleCharacteristicsExtended"></see></summary>
    let VehicleCharacteristicsExtended =
        Namespaced_IRI.parse _namespace_name "VehicleCharacteristicsExtended" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#emissionClassification"></see>
    /// </summary>
    let emissionClassification =
        Namespaced_IRI.parse _namespace_name "emissionClassification" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#fuelType2"></see>
    /// </summary>
    let fuelType2 = Namespaced_IRI.parse _namespace_name "fuelType2" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#loadType2"></see>
    /// </summary>
    let loadType2 = Namespaced_IRI.parse _namespace_name "loadType2" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#operationFreeOfEmission"></see>
    /// </summary>
    let operationFreeOfEmission =
        Namespaced_IRI.parse _namespace_name "operationFreeOfEmission" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleType2"></see>
    /// </summary>
    let vehicleType2 =
        Namespaced_IRI.parse _namespace_name "vehicleType2" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleUsage2"></see>
    /// </summary>
    let vehicleUsage2 =
        Namespaced_IRI.parse _namespace_name "vehicleUsage2" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#coveringPetrolStationArea"></see>
    /// </summary>
    let coveringPetrolStationArea =
        Namespaced_IRI.parse _namespace_name "coveringPetrolStationArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measuredValueIndex"></see>
    /// </summary>
    let measuredValueIndex =
        Namespaced_IRI.parse _namespace_name "measuredValueIndex" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleCountAndRateExtension"></see>
    /// </summary>
    let vehicleCountAndRateExtension =
        Namespaced_IRI.parse _namespace_name "vehicleCountAndRateExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleCountWithinInterval"></see>
    /// </summary>
    let vehicleCountWithinInterval =
        Namespaced_IRI.parse _namespace_name "vehicleCountWithinInterval" |> NamespacedName

    /// <summary>
    /// Gives incoming and/or outgoing vehicles and/or change of occupied spaces within a given interval. The interval is given in positive or negative seconds related to 'measurementOrCalculationTime' or 'measurementDefaultTime'.
    /// <see href="http://vocab.datex.org/terms#VehicleCountWithinInterval"></see></summary>
    let VehicleCountWithinInterval =
        Namespaced_IRI.parse _namespace_name "VehicleCountWithinInterval" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleRate"></see>
    /// </summary>
    let vehicleRate =
        Namespaced_IRI.parse _namespace_name "vehicleRate" |> NamespacedName

    /// <summary>
    /// Gives information about fill and exit rates OR vehicle flow rate (without direction). If the time stamp is omitted, 'measurementTimeDefault' is used.
    /// <see href="http://vocab.datex.org/terms#VehicleRate"></see></summary>
    let VehicleRate =
        Namespaced_IRI.parse _namespace_name "VehicleRate" |> NamespacedName

    /// <summary>
    /// A measured or calculated value of absolute count of vehicles within a specified period of time expressed as non negative integer.
    /// <see href="http://vocab.datex.org/terms#VehicleCountValue"></see></summary>
    let VehicleCountValue =
        Namespaced_IRI.parse _namespace_name "VehicleCountValue" |> NamespacedName

    /// <summary>
    /// A measured or calculated absolute count of vehicles within a specified period of time expressed as non negative integer.
    /// <see href="http://vocab.datex.org/terms#vehicleCount"></see></summary>
    let vehicleCount =
        Namespaced_IRI.parse _namespace_name "vehicleCount" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleCountValueExtension"></see>
    /// </summary>
    let vehicleCountValueExtension =
        Namespaced_IRI.parse _namespace_name "vehicleCountValueExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#changeOfOccupiedSpaces"></see>
    /// </summary>
    let changeOfOccupiedSpaces =
        Namespaced_IRI.parse _namespace_name "changeOfOccupiedSpaces" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#countedVehicles"></see>
    /// </summary>
    let countedVehicles =
        Namespaced_IRI.parse _namespace_name "countedVehicles" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementInterval"></see>
    /// </summary>
    let measurementInterval =
        Namespaced_IRI.parse _namespace_name "measurementInterval" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measurementOrCalcualtionTime"></see>
    /// </summary>
    let measurementOrCalcualtionTime =
        Namespaced_IRI.parse _namespace_name "measurementOrCalcualtionTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#numberOfIncomingVehicles"></see>
    /// </summary>
    let numberOfIncomingVehicles =
        Namespaced_IRI.parse _namespace_name "numberOfIncomingVehicles" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#numberOfOutgoingVehicles"></see>
    /// </summary>
    let numberOfOutgoingVehicles =
        Namespaced_IRI.parse _namespace_name "numberOfOutgoingVehicles" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleCountWithinIntervalExtension"></see>
    /// </summary>
    let vehicleCountWithinIntervalExtension =
        Namespaced_IRI.parse _namespace_name "vehicleCountWithinIntervalExtension" |> NamespacedName

    /// <summary>
    /// A value of vehicle flow rate expressed in vehicles per hour.
    /// <see href="http://vocab.datex.org/terms#vehicleFlowRate"></see></summary>
    let vehicleFlowRate =
        Namespaced_IRI.parse _namespace_name "vehicleFlowRate" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleFlowValueExtension"></see>
    /// </summary>
    let vehicleFlowValueExtension =
        Namespaced_IRI.parse _namespace_name "vehicleFlowValueExtension" |> NamespacedName

    /// <summary>
    /// The obstructing vehicle.
    /// <see href="http://vocab.datex.org/terms#obstructingVehicle"></see></summary>
    let obstructingVehicle =
        Namespaced_IRI.parse _namespace_name "obstructingVehicle" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleObstructionExtension"></see>
    /// </summary>
    let vehicleObstructionExtension =
        Namespaced_IRI.parse _namespace_name "vehicleObstructionExtension" |> NamespacedName

    /// <summary>
    /// Characterization of an obstruction on the road caused by one or more vehicles.
    /// <see href="http://vocab.datex.org/terms#vehicleObstructionType"></see></summary>
    let vehicleObstructionType =
        Namespaced_IRI.parse _namespace_name "vehicleObstructionType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#measuredVehicles"></see>
    /// </summary>
    let measuredVehicles =
        Namespaced_IRI.parse _namespace_name "measuredVehicles" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleRateExtension"></see>
    /// </summary>
    let vehicleRateExtension =
        Namespaced_IRI.parse _namespace_name "vehicleRateExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#VersionedReference"></see>
    /// </summary>
    let VersionedReference =
        Namespaced_IRI.parse _namespace_name "VersionedReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#minimumVisibilityDistance"></see>
    /// </summary>
    let minimumVisibilityDistance =
        Namespaced_IRI.parse _namespace_name "minimumVisibilityDistance" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#visibilityExtension"></see>
    /// </summary>
    let visibilityExtension =
        Namespaced_IRI.parse _namespace_name "visibilityExtension" |> NamespacedName

    /// <summary>
    /// Measurements of atmospheric visibility.
    /// <see href="http://vocab.datex.org/terms#VisibilityInformation"></see></summary>
    let VisibilityInformation =
        Namespaced_IRI.parse _namespace_name "VisibilityInformation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#visibilityInformationExtension"></see>
    /// </summary>
    let visibilityInformationExtension =
        Namespaced_IRI.parse _namespace_name "visibilityInformationExtension" |> NamespacedName

    /// <summary>
    /// Provides the current status and settings of the VMS and the currently displayed information. Where a VMS is displaying a sequence or alternating set of messages these are ordered according to the messageIndex qualifier.
    /// <see href="http://vocab.datex.org/terms#Vms"></see></summary>
    let Vms = Namespaced_IRI.parse _namespace_name "Vms" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#managedLogicalLocationOverride"></see>
    /// </summary>
    let managedLogicalLocationOverride =
        Namespaced_IRI.parse _namespace_name "managedLogicalLocationOverride" |> NamespacedName

    /// <summary>
    /// The logical location (e.g. a car park, a section of road, a junction etc.) which a VMS contributes to the management of.
    /// <see href="http://vocab.datex.org/terms#VmsManagedLogicalLocation"></see></summary>
    let VmsManagedLogicalLocation =
        Namespaced_IRI.parse _namespace_name "VmsManagedLogicalLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramDisplayAreaSettings"></see>
    /// </summary>
    let pictogramDisplayAreaSettings =
        Namespaced_IRI.parse _namespace_name "pictogramDisplayAreaSettings" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_VmsPictogramDisplayAreaIndexPictogramDisplayAreaSettings"></see>
    /// </summary>
    let _VmsPictogramDisplayAreaIndexPictogramDisplayAreaSettings =
        Namespaced_IRI.parse _namespace_name "_VmsPictogramDisplayAreaIndexPictogramDisplayAreaSettings" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#textDisplayAreaSettings"></see>
    /// </summary>
    let textDisplayAreaSettings =
        Namespaced_IRI.parse _namespace_name "textDisplayAreaSettings" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsDynamicCharacteristics"></see>
    /// </summary>
    let vmsDynamicCharacteristics =
        Namespaced_IRI.parse _namespace_name "vmsDynamicCharacteristics" |> NamespacedName

    /// <summary>
    /// Provides the current characteristic settings for the VMS which can be dynamically configured and therefore which override any corresponding characteristics set for the VMS in the relevant VmsUnitPublication.
    /// <see href="http://vocab.datex.org/terms#VmsDynamicCharacteristics"></see></summary>
    let VmsDynamicCharacteristics =
        Namespaced_IRI.parse _namespace_name "VmsDynamicCharacteristics" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsExtension"></see>
    /// </summary>
    let vmsExtension =
        Namespaced_IRI.parse _namespace_name "vmsExtension" |> NamespacedName

    /// <summary>
    /// The type of fault which is being reported for the specified variable message sign panel.
    /// <see href="http://vocab.datex.org/terms#vmsFault"></see></summary>
    let vmsFault = Namespaced_IRI.parse _namespace_name "vmsFault" |> NamespacedName
    /// <summary>
    /// Details of the fault which is being reported for the specified variable message sign panel.
    /// <see href="http://vocab.datex.org/terms#VmsFault"></see></summary>
    let VmsFault = Namespaced_IRI.parse _namespace_name "VmsFault" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsLocationOverride"></see>
    /// </summary>
    let vmsLocationOverride =
        Namespaced_IRI.parse _namespace_name "vmsLocationOverride" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsMessage"></see>
    /// </summary>
    let vmsMessage = Namespaced_IRI.parse _namespace_name "vmsMessage" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_VmsMessageIndexVmsMessage"></see>
    /// </summary>
    let _VmsMessageIndexVmsMessage =
        Namespaced_IRI.parse _namespace_name "_VmsMessageIndexVmsMessage" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsMessageSequencingInterval"></see>
    /// </summary>
    let vmsMessageSequencingInterval =
        Namespaced_IRI.parse _namespace_name "vmsMessageSequencingInterval" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsWorking"></see>
    /// </summary>
    let vmsWorking = Namespaced_IRI.parse _namespace_name "vmsWorking" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#numberOfPictogramDisplayAreas"></see>
    /// </summary>
    let numberOfPictogramDisplayAreas =
        Namespaced_IRI.parse _namespace_name "numberOfPictogramDisplayAreas" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsDynamicCharacteristicsExtension"></see>
    /// </summary>
    let vmsDynamicCharacteristicsExtension =
        Namespaced_IRI.parse _namespace_name "vmsDynamicCharacteristicsExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsPictogramDisplayCharacteristics"></see>
    /// </summary>
    let vmsPictogramDisplayCharacteristics =
        Namespaced_IRI.parse _namespace_name "vmsPictogramDisplayCharacteristics" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_VmsDynamicCharacteristicsPictogramDisplayAreaIndexVmsPictogramDisplayCharacteristics"></see>
    /// </summary>
    let _VmsDynamicCharacteristicsPictogramDisplayAreaIndexVmsPictogramDisplayCharacteristics =
        Namespaced_IRI.parse _namespace_name "_VmsDynamicCharacteristicsPictogramDisplayAreaIndexVmsPictogramDisplayCharacteristics" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsTextDisplayCharacteristics"></see>
    /// </summary>
    let vmsTextDisplayCharacteristics =
        Namespaced_IRI.parse _namespace_name "vmsTextDisplayCharacteristics" |> NamespacedName

    /// <summary>
    /// Characteristics specific to the textual display area on the VMS.
    /// <see href="http://vocab.datex.org/terms#VmsTextDisplayCharacteristics"></see></summary>
    let VmsTextDisplayCharacteristics =
        Namespaced_IRI.parse _namespace_name "VmsTextDisplayCharacteristics" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsFaultExtension"></see>
    /// </summary>
    let vmsFaultExtension =
        Namespaced_IRI.parse _namespace_name "vmsFaultExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#distanceFromLogicalLocation"></see>
    /// </summary>
    let distanceFromLogicalLocation =
        Namespaced_IRI.parse _namespace_name "distanceFromLogicalLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#managedLocation"></see>
    /// </summary>
    let managedLocation =
        Namespaced_IRI.parse _namespace_name "managedLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#managedLogicalLocation"></see>
    /// </summary>
    let managedLogicalLocation =
        Namespaced_IRI.parse _namespace_name "managedLogicalLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsManagedLogicalLocationExtension"></see>
    /// </summary>
    let vmsManagedLogicalLocationExtension =
        Namespaced_IRI.parse _namespace_name "vmsManagedLogicalLocationExtension" |> NamespacedName

    /// <summary>
    /// A message displayed on a VMS which may comprise one or more sequentially displayed text pages and/or pictograms with supplementary details. When in a sequence of displayed messages sequencing of text pages and pictograms within a message are prohibited.
    /// <see href="http://vocab.datex.org/terms#VmsMessage"></see></summary>
    let VmsMessage = Namespaced_IRI.parse _namespace_name "VmsMessage" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#associatedManagementOrDiversionPlan"></see>
    /// </summary>
    let associatedManagementOrDiversionPlan =
        Namespaced_IRI.parse _namespace_name "associatedManagementOrDiversionPlan" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#codedReasonForSetting"></see>
    /// </summary>
    let codedReasonForSetting =
        Namespaced_IRI.parse _namespace_name "codedReasonForSetting" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#distanceFromSituationRecord"></see>
    /// </summary>
    let distanceFromSituationRecord =
        Namespaced_IRI.parse _namespace_name "distanceFromSituationRecord" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#mareNostrumCompliant"></see>
    /// </summary>
    let mareNostrumCompliant =
        Namespaced_IRI.parse _namespace_name "mareNostrumCompliant" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#messageSetBy"></see>
    /// </summary>
    let messageSetBy =
        Namespaced_IRI.parse _namespace_name "messageSetBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#primarySetting"></see>
    /// </summary>
    let primarySetting =
        Namespaced_IRI.parse _namespace_name "primarySetting" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#reasonForSetting"></see>
    /// </summary>
    let reasonForSetting =
        Namespaced_IRI.parse _namespace_name "reasonForSetting" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#requestedBy"></see>
    /// </summary>
    let requestedBy =
        Namespaced_IRI.parse _namespace_name "requestedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#setBySystem"></see>
    /// </summary>
    let setBySystem =
        Namespaced_IRI.parse _namespace_name "setBySystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#situationRecordToWhichMessageIsRelated"></see>
    /// </summary>
    let situationRecordToWhichMessageIsRelated =
        Namespaced_IRI.parse _namespace_name "situationRecordToWhichMessageIsRelated" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#situationToWhichMessageIsRelated"></see>
    /// </summary>
    let situationToWhichMessageIsRelated =
        Namespaced_IRI.parse _namespace_name "situationToWhichMessageIsRelated" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#textPage"></see>
    /// </summary>
    let textPage = Namespaced_IRI.parse _namespace_name "textPage" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_TextPage"></see>
    /// </summary>
    let _TextPage = Namespaced_IRI.parse _namespace_name "_TextPage" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#textPictogramSequencingInterval"></see>
    /// </summary>
    let textPictogramSequencingInterval =
        Namespaced_IRI.parse _namespace_name "textPictogramSequencingInterval" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#timeLastSet"></see>
    /// </summary>
    let timeLastSet =
        Namespaced_IRI.parse _namespace_name "timeLastSet" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsMessageExtension"></see>
    /// </summary>
    let vmsMessageExtension =
        Namespaced_IRI.parse _namespace_name "vmsMessageExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsMessageInformationType"></see>
    /// </summary>
    let vmsMessageInformationType =
        Namespaced_IRI.parse _namespace_name "vmsMessageInformationType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsPictogramDisplayArea"></see>
    /// </summary>
    let vmsPictogramDisplayArea =
        Namespaced_IRI.parse _namespace_name "vmsPictogramDisplayArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_VmsMessagePictogramDisplayAreaIndexVmsPictogramDisplayArea"></see>
    /// </summary>
    let _VmsMessagePictogramDisplayAreaIndexVmsPictogramDisplayArea =
        Namespaced_IRI.parse _namespace_name "_VmsMessagePictogramDisplayAreaIndexVmsPictogramDisplayArea" |> NamespacedName

    /// <summary>
    /// A main pictogram displayable on the VMS panel. Note a main pictogram may have an associated supplementary panel which may itself contain a further pictogram and line of text.
    /// <see href="http://vocab.datex.org/terms#VmsPictogram"></see></summary>
    let VmsPictogram =
        Namespaced_IRI.parse _namespace_name "VmsPictogram" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#additionalPictogramDescription"></see>
    /// </summary>
    let additionalPictogramDescription =
        Namespaced_IRI.parse _namespace_name "additionalPictogramDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#distanceAttribute"></see>
    /// </summary>
    let distanceAttribute =
        Namespaced_IRI.parse _namespace_name "distanceAttribute" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#heightAttribute"></see>
    /// </summary>
    let heightAttribute =
        Namespaced_IRI.parse _namespace_name "heightAttribute" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#lengthAttribute"></see>
    /// </summary>
    let lengthAttribute =
        Namespaced_IRI.parse _namespace_name "lengthAttribute" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramCode"></see>
    /// </summary>
    let pictogramCode =
        Namespaced_IRI.parse _namespace_name "pictogramCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramDescription"></see>
    /// </summary>
    let pictogramDescription =
        Namespaced_IRI.parse _namespace_name "pictogramDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramFlashing"></see>
    /// </summary>
    let pictogramFlashing =
        Namespaced_IRI.parse _namespace_name "pictogramFlashing" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramInInverseColour"></see>
    /// </summary>
    let pictogramInInverseColour =
        Namespaced_IRI.parse _namespace_name "pictogramInInverseColour" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramUrl"></see>
    /// </summary>
    let pictogramUrl =
        Namespaced_IRI.parse _namespace_name "pictogramUrl" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#presenceOfRedTriangle"></see>
    /// </summary>
    let presenceOfRedTriangle =
        Namespaced_IRI.parse _namespace_name "presenceOfRedTriangle" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#speedAttribute"></see>
    /// </summary>
    let speedAttribute =
        Namespaced_IRI.parse _namespace_name "speedAttribute" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#viennaConventionCompliant"></see>
    /// </summary>
    let viennaConventionCompliant =
        Namespaced_IRI.parse _namespace_name "viennaConventionCompliant" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsPictogramExtension"></see>
    /// </summary>
    let vmsPictogramExtension =
        Namespaced_IRI.parse _namespace_name "vmsPictogramExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsSupplementaryPanel"></see>
    /// </summary>
    let vmsSupplementaryPanel =
        Namespaced_IRI.parse _namespace_name "vmsSupplementaryPanel" |> NamespacedName

    /// <summary>
    /// A panel which may display information or a regulatory instruction which is supplemental to the associated pictogram, comprising either an additional line of text or a pictogram or both.
    /// <see href="http://vocab.datex.org/terms#VmsSupplementaryPanel"></see></summary>
    let VmsSupplementaryPanel =
        Namespaced_IRI.parse _namespace_name "VmsSupplementaryPanel" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#weightAttribute"></see>
    /// </summary>
    let weightAttribute =
        Namespaced_IRI.parse _namespace_name "weightAttribute" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#weightPerAxleAttribute"></see>
    /// </summary>
    let weightPerAxleAttribute =
        Namespaced_IRI.parse _namespace_name "weightPerAxleAttribute" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#widthAttribute"></see>
    /// </summary>
    let widthAttribute =
        Namespaced_IRI.parse _namespace_name "widthAttribute" |> NamespacedName

    /// <summary>
    /// An area on a VMS used for the display of pictograms and associated supplemental information or instructions.
    /// <see href="http://vocab.datex.org/terms#VmsPictogramDisplayArea"></see></summary>
    let VmsPictogramDisplayArea =
        Namespaced_IRI.parse _namespace_name "VmsPictogramDisplayArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#synchronizedSequencingWithTextPages"></see>
    /// </summary>
    let synchronizedSequencingWithTextPages =
        Namespaced_IRI.parse _namespace_name "synchronizedSequencingWithTextPages" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsPictogram"></see>
    /// </summary>
    let vmsPictogram =
        Namespaced_IRI.parse _namespace_name "vmsPictogram" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_VmsPictogramDisplayAreaPictogramSequencingIndexVmsPictogram"></see>
    /// </summary>
    let _VmsPictogramDisplayAreaPictogramSequencingIndexVmsPictogram =
        Namespaced_IRI.parse _namespace_name "_VmsPictogramDisplayAreaPictogramSequencingIndexVmsPictogram" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsPictogramDisplayAreaExtension"></see>
    /// </summary>
    let vmsPictogramDisplayAreaExtension =
        Namespaced_IRI.parse _namespace_name "vmsPictogramDisplayAreaExtension" |> NamespacedName

    /// <summary>
    /// Characteristics specific to the pictogram display area(s) on the VMS where pictogramDisplayAreaIndex indicates which pictogram area it relates to.
    /// <see href="http://vocab.datex.org/terms#VmsPictogramDisplayCharacteristics"></see></summary>
    let VmsPictogramDisplayCharacteristics =
        Namespaced_IRI.parse _namespace_name "VmsPictogramDisplayCharacteristics" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maxNumberOfSequentialPictograms"></see>
    /// </summary>
    let maxNumberOfSequentialPictograms =
        Namespaced_IRI.parse _namespace_name "maxNumberOfSequentialPictograms" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maxPictogramLuminanceLevel"></see>
    /// </summary>
    let maxPictogramLuminanceLevel =
        Namespaced_IRI.parse _namespace_name "maxPictogramLuminanceLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramCodeListIdentifier"></see>
    /// </summary>
    let pictogramCodeListIdentifier =
        Namespaced_IRI.parse _namespace_name "pictogramCodeListIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramDisplayHeight"></see>
    /// </summary>
    let pictogramDisplayHeight =
        Namespaced_IRI.parse _namespace_name "pictogramDisplayHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramDisplayWidth"></see>
    /// </summary>
    let pictogramDisplayWidth =
        Namespaced_IRI.parse _namespace_name "pictogramDisplayWidth" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramLanternsPresent"></see>
    /// </summary>
    let pictogramLanternsPresent =
        Namespaced_IRI.parse _namespace_name "pictogramLanternsPresent" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramNumberOfColours"></see>
    /// </summary>
    let pictogramNumberOfColours =
        Namespaced_IRI.parse _namespace_name "pictogramNumberOfColours" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramPixelsAcross"></see>
    /// </summary>
    let pictogramPixelsAcross =
        Namespaced_IRI.parse _namespace_name "pictogramPixelsAcross" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramPixelsDown"></see>
    /// </summary>
    let pictogramPixelsDown =
        Namespaced_IRI.parse _namespace_name "pictogramPixelsDown" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramPositionAbsolute"></see>
    /// </summary>
    let pictogramPositionAbsolute =
        Namespaced_IRI.parse _namespace_name "pictogramPositionAbsolute" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramPositionRelativeToText"></see>
    /// </summary>
    let pictogramPositionRelativeToText =
        Namespaced_IRI.parse _namespace_name "pictogramPositionRelativeToText" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramPositionX"></see>
    /// </summary>
    let pictogramPositionX =
        Namespaced_IRI.parse _namespace_name "pictogramPositionX" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramPositionY"></see>
    /// </summary>
    let pictogramPositionY =
        Namespaced_IRI.parse _namespace_name "pictogramPositionY" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramSequencingCapable"></see>
    /// </summary>
    let pictogramSequencingCapable =
        Namespaced_IRI.parse _namespace_name "pictogramSequencingCapable" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsPictogramDisplayCharacteristicsExtension"></see>
    /// </summary>
    let vmsPictogramDisplayCharacteristicsExtension =
        Namespaced_IRI.parse _namespace_name "vmsPictogramDisplayCharacteristicsExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsSupplementaryPanelCharacteristics"></see>
    /// </summary>
    let vmsSupplementaryPanelCharacteristics =
        Namespaced_IRI.parse _namespace_name "vmsSupplementaryPanelCharacteristics" |> NamespacedName

    /// <summary>
    /// Characteristics of a panel which may display details (sometimes regulatory in nature) that are supplemental to the main pictogram, comprising an additional line of text and/or a pictogram.
    /// <see href="http://vocab.datex.org/terms#VmsSupplementaryPanelCharacteristics"></see></summary>
    let VmsSupplementaryPanelCharacteristics =
        Namespaced_IRI.parse _namespace_name "VmsSupplementaryPanelCharacteristics" |> NamespacedName

    /// <summary>
    /// A publication containing the current status and settings of one or more VMS units, each unit controlling one or more individual variable message signs.
    /// <see href="http://vocab.datex.org/terms#VmsPublication"></see></summary>
    let VmsPublication =
        Namespaced_IRI.parse _namespace_name "VmsPublication" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsPublicationExtension"></see>
    /// </summary>
    let vmsPublicationExtension =
        Namespaced_IRI.parse _namespace_name "vmsPublicationExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsUnit"></see>
    /// </summary>
    let vmsUnit = Namespaced_IRI.parse _namespace_name "vmsUnit" |> NamespacedName
    /// <summary>
    /// Status of a VMS unit which may control one or more variable message signs on a single gantry or on different gantries.
    /// <see href="http://vocab.datex.org/terms#VmsUnit"></see></summary>
    let VmsUnit = Namespaced_IRI.parse _namespace_name "VmsUnit" |> NamespacedName
    /// <summary>
    /// A sub-record in the VMS Unit table defining the characteristics of a single variable message sign that is controlled by a specific VMS unit. Locations are on or adjacent to the road network but may be updated over time if relating to a mobile VMS unit.
    /// <see href="http://vocab.datex.org/terms#VmsRecord"></see></summary>
    let VmsRecord = Namespaced_IRI.parse _namespace_name "VmsRecord" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#backgroundImageUrl"></see>
    /// </summary>
    let backgroundImageUrl =
        Namespaced_IRI.parse _namespace_name "backgroundImageUrl" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#dynamicallyConfigurableDisplayAreas"></see>
    /// </summary>
    let dynamicallyConfigurableDisplayAreas =
        Namespaced_IRI.parse _namespace_name "dynamicallyConfigurableDisplayAreas" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsDescription"></see>
    /// </summary>
    let vmsDescription =
        Namespaced_IRI.parse _namespace_name "vmsDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsDisplayHeight"></see>
    /// </summary>
    let vmsDisplayHeight =
        Namespaced_IRI.parse _namespace_name "vmsDisplayHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsDisplayWidth"></see>
    /// </summary>
    let vmsDisplayWidth =
        Namespaced_IRI.parse _namespace_name "vmsDisplayWidth" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsHeightAboveRoadway"></see>
    /// </summary>
    let vmsHeightAboveRoadway =
        Namespaced_IRI.parse _namespace_name "vmsHeightAboveRoadway" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsLocation"></see>
    /// </summary>
    let vmsLocation =
        Namespaced_IRI.parse _namespace_name "vmsLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsManagedLogicalLocation"></see>
    /// </summary>
    let vmsManagedLogicalLocation =
        Namespaced_IRI.parse _namespace_name "vmsManagedLogicalLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsOwner"></see>
    /// </summary>
    let vmsOwner = Namespaced_IRI.parse _namespace_name "vmsOwner" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsPhysicalMounting"></see>
    /// </summary>
    let vmsPhysicalMounting =
        Namespaced_IRI.parse _namespace_name "vmsPhysicalMounting" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_VmsRecordPictogramDisplayAreaIndexVmsPictogramDisplayCharacteristics"></see>
    /// </summary>
    let _VmsRecordPictogramDisplayAreaIndexVmsPictogramDisplayCharacteristics =
        Namespaced_IRI.parse _namespace_name "_VmsRecordPictogramDisplayAreaIndexVmsPictogramDisplayCharacteristics" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsRecordExtension"></see>
    /// </summary>
    let vmsRecordExtension =
        Namespaced_IRI.parse _namespace_name "vmsRecordExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsType"></see>
    /// </summary>
    let vmsType = Namespaced_IRI.parse _namespace_name "vmsType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsTypeCode"></see>
    /// </summary>
    let vmsTypeCode =
        Namespaced_IRI.parse _namespace_name "vmsTypeCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsSettingExtension"></see>
    /// </summary>
    let vmsSettingExtension =
        Namespaced_IRI.parse _namespace_name "vmsSettingExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#supplementaryMessageDescription"></see>
    /// </summary>
    let supplementaryMessageDescription =
        Namespaced_IRI.parse _namespace_name "supplementaryMessageDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsSupplementaryPanelExtension"></see>
    /// </summary>
    let vmsSupplementaryPanelExtension =
        Namespaced_IRI.parse _namespace_name "vmsSupplementaryPanelExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsSupplementaryPictogram"></see>
    /// </summary>
    let vmsSupplementaryPictogram =
        Namespaced_IRI.parse _namespace_name "vmsSupplementaryPictogram" |> NamespacedName

    /// <summary>
    /// An additional pictogram that is displayed in the panel which is supplemental to the associated pictogram display.
    /// <see href="http://vocab.datex.org/terms#VmsSupplementaryPictogram"></see></summary>
    let VmsSupplementaryPictogram =
        Namespaced_IRI.parse _namespace_name "VmsSupplementaryPictogram" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsSupplementaryText"></see>
    /// </summary>
    let vmsSupplementaryText =
        Namespaced_IRI.parse _namespace_name "vmsSupplementaryText" |> NamespacedName

    /// <summary>
    /// A single line of text on a text display area or supplementary panel.
    /// <see href="http://vocab.datex.org/terms#VmsTextLine"></see></summary>
    let VmsTextLine =
        Namespaced_IRI.parse _namespace_name "VmsTextLine" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#relativePositionToPictogramArea"></see>
    /// </summary>
    let relativePositionToPictogramArea =
        Namespaced_IRI.parse _namespace_name "relativePositionToPictogramArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#supplementaryPanelDisplayHeight"></see>
    /// </summary>
    let supplementaryPanelDisplayHeight =
        Namespaced_IRI.parse _namespace_name "supplementaryPanelDisplayHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#supplementaryPanelDisplayWidth"></see>
    /// </summary>
    let supplementaryPanelDisplayWidth =
        Namespaced_IRI.parse _namespace_name "supplementaryPanelDisplayWidth" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#supplementaryPanelPixelsAcross"></see>
    /// </summary>
    let supplementaryPanelPixelsAcross =
        Namespaced_IRI.parse _namespace_name "supplementaryPanelPixelsAcross" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#supplementaryPanelPixelsDown"></see>
    /// </summary>
    let supplementaryPanelPixelsDown =
        Namespaced_IRI.parse _namespace_name "supplementaryPanelPixelsDown" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#supplementaryPanelPositionX"></see>
    /// </summary>
    let supplementaryPanelPositionX =
        Namespaced_IRI.parse _namespace_name "supplementaryPanelPositionX" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#supplementaryPanelPositionY"></see>
    /// </summary>
    let supplementaryPanelPositionY =
        Namespaced_IRI.parse _namespace_name "supplementaryPanelPositionY" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#supplementaryPictogramCodeListIdentifier"></see>
    /// </summary>
    let supplementaryPictogramCodeListIdentifier =
        Namespaced_IRI.parse _namespace_name "supplementaryPictogramCodeListIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsSupplementaryPanelCharacteristicsExtension"></see>
    /// </summary>
    let vmsSupplementaryPanelCharacteristicsExtension =
        Namespaced_IRI.parse _namespace_name "vmsSupplementaryPanelCharacteristicsExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#additionalSupplementaryPictogramDescription"></see>
    /// </summary>
    let additionalSupplementaryPictogramDescription =
        Namespaced_IRI.parse _namespace_name "additionalSupplementaryPictogramDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#supplementaryPictogramCode"></see>
    /// </summary>
    let supplementaryPictogramCode =
        Namespaced_IRI.parse _namespace_name "supplementaryPictogramCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#supplementaryPictogramDescription"></see>
    /// </summary>
    let supplementaryPictogramDescription =
        Namespaced_IRI.parse _namespace_name "supplementaryPictogramDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#supplementaryPictogramUrl"></see>
    /// </summary>
    let supplementaryPictogramUrl =
        Namespaced_IRI.parse _namespace_name "supplementaryPictogramUrl" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsSupplementaryPictogramExtension"></see>
    /// </summary>
    let vmsSupplementaryPictogramExtension =
        Namespaced_IRI.parse _namespace_name "vmsSupplementaryPictogramExtension" |> NamespacedName

    /// <summary>
    /// A publication containing one or more VMS Unit Tables each comprising a set of records which hold details of VMS units.
    /// <see href="http://vocab.datex.org/terms#VmsTablePublication"></see></summary>
    let VmsTablePublication =
        Namespaced_IRI.parse _namespace_name "VmsTablePublication" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsTablePublicationExtension"></see>
    /// </summary>
    let vmsTablePublicationExtension =
        Namespaced_IRI.parse _namespace_name "vmsTablePublicationExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsUnitTable"></see>
    /// </summary>
    let vmsUnitTable =
        Namespaced_IRI.parse _namespace_name "vmsUnitTable" |> NamespacedName

    /// <summary>
    /// A versioned VMS Unit Table comprising a number of data records, each record defining the characteristics of a specific deployed variable message sign unit.
    /// <see href="http://vocab.datex.org/terms#VmsUnitTable"></see></summary>
    let VmsUnitTable =
        Namespaced_IRI.parse _namespace_name "VmsUnitTable" |> NamespacedName

    /// <summary>
    /// A page of text (comprising one or more ordered lines) that are displayed simultaneously on the VMS. Where more than one page is defined these are sequentially displayed according to their "pageNumber".
    /// <see href="http://vocab.datex.org/terms#VmsText"></see></summary>
    let VmsText = Namespaced_IRI.parse _namespace_name "VmsText" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsLegendCode"></see>
    /// </summary>
    let vmsLegendCode =
        Namespaced_IRI.parse _namespace_name "vmsLegendCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsTextExtension"></see>
    /// </summary>
    let vmsTextExtension =
        Namespaced_IRI.parse _namespace_name "vmsTextExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsTextImageUrl"></see>
    /// </summary>
    let vmsTextImageUrl =
        Namespaced_IRI.parse _namespace_name "vmsTextImageUrl" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsTextLine"></see>
    /// </summary>
    let vmsTextLine =
        Namespaced_IRI.parse _namespace_name "vmsTextLine" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_VmsTextLineIndexVmsTextLine"></see>
    /// </summary>
    let _VmsTextLineIndexVmsTextLine =
        Namespaced_IRI.parse _namespace_name "_VmsTextLineIndexVmsTextLine" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#legendCodeListIdentifier"></see>
    /// </summary>
    let legendCodeListIdentifier =
        Namespaced_IRI.parse _namespace_name "legendCodeListIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maxFontHeight"></see>
    /// </summary>
    let maxFontHeight =
        Namespaced_IRI.parse _namespace_name "maxFontHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maxFontSpacing"></see>
    /// </summary>
    let maxFontSpacing =
        Namespaced_IRI.parse _namespace_name "maxFontSpacing" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maxFontWidth"></see>
    /// </summary>
    let maxFontWidth =
        Namespaced_IRI.parse _namespace_name "maxFontWidth" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maxNumberOfCharacters"></see>
    /// </summary>
    let maxNumberOfCharacters =
        Namespaced_IRI.parse _namespace_name "maxNumberOfCharacters" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maxNumberOfRows"></see>
    /// </summary>
    let maxNumberOfRows =
        Namespaced_IRI.parse _namespace_name "maxNumberOfRows" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maxNumberOfSequentialPages"></see>
    /// </summary>
    let maxNumberOfSequentialPages =
        Namespaced_IRI.parse _namespace_name "maxNumberOfSequentialPages" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maxTextLuminanceLevel"></see>
    /// </summary>
    let maxTextLuminanceLevel =
        Namespaced_IRI.parse _namespace_name "maxTextLuminanceLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#minFontHeight"></see>
    /// </summary>
    let minFontHeight =
        Namespaced_IRI.parse _namespace_name "minFontHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#minFontSpacing"></see>
    /// </summary>
    let minFontSpacing =
        Namespaced_IRI.parse _namespace_name "minFontSpacing" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#minFontWidth"></see>
    /// </summary>
    let minFontWidth =
        Namespaced_IRI.parse _namespace_name "minFontWidth" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#textDisplayHeight"></see>
    /// </summary>
    let textDisplayHeight =
        Namespaced_IRI.parse _namespace_name "textDisplayHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#textDisplayWidth"></see>
    /// </summary>
    let textDisplayWidth =
        Namespaced_IRI.parse _namespace_name "textDisplayWidth" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#textLanternsPresent"></see>
    /// </summary>
    let textLanternsPresent =
        Namespaced_IRI.parse _namespace_name "textLanternsPresent" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#textPageSequencingCapable"></see>
    /// </summary>
    let textPageSequencingCapable =
        Namespaced_IRI.parse _namespace_name "textPageSequencingCapable" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#textPixelsAcross"></see>
    /// </summary>
    let textPixelsAcross =
        Namespaced_IRI.parse _namespace_name "textPixelsAcross" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#textPixelsDown"></see>
    /// </summary>
    let textPixelsDown =
        Namespaced_IRI.parse _namespace_name "textPixelsDown" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#textPositionAbsolute"></see>
    /// </summary>
    let textPositionAbsolute =
        Namespaced_IRI.parse _namespace_name "textPositionAbsolute" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#textPositionX"></see>
    /// </summary>
    let textPositionX =
        Namespaced_IRI.parse _namespace_name "textPositionX" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#textPositionY"></see>
    /// </summary>
    let textPositionY =
        Namespaced_IRI.parse _namespace_name "textPositionY" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsTextDisplayCharacteristicsExtension"></see>
    /// </summary>
    let vmsTextDisplayCharacteristicsExtension =
        Namespaced_IRI.parse _namespace_name "vmsTextDisplayCharacteristicsExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsTextLineColour"></see>
    /// </summary>
    let vmsTextLineColour =
        Namespaced_IRI.parse _namespace_name "vmsTextLineColour" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsTextLineExtension"></see>
    /// </summary>
    let vmsTextLineExtension =
        Namespaced_IRI.parse _namespace_name "vmsTextLineExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsTextLineFlashing"></see>
    /// </summary>
    let vmsTextLineFlashing =
        Namespaced_IRI.parse _namespace_name "vmsTextLineFlashing" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsTextLineHtml"></see>
    /// </summary>
    let vmsTextLineHtml =
        Namespaced_IRI.parse _namespace_name "vmsTextLineHtml" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsTextLineLanguage"></see>
    /// </summary>
    let vmsTextLineLanguage =
        Namespaced_IRI.parse _namespace_name "vmsTextLineLanguage" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vms"></see>
    /// </summary>
    let vms = Namespaced_IRI.parse _namespace_name "vms" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_VmsUnitVmsIndexVms"></see>
    /// </summary>
    let _VmsUnitVmsIndexVms =
        Namespaced_IRI.parse _namespace_name "_VmsUnitVmsIndexVms" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsUnitExtension"></see>
    /// </summary>
    let vmsUnitExtension =
        Namespaced_IRI.parse _namespace_name "vmsUnitExtension" |> NamespacedName

    /// <summary>
    /// The type of fault which is being reported for the VMS unit.
    /// <see href="http://vocab.datex.org/terms#vmsUnitFault"></see></summary>
    let vmsUnitFault =
        Namespaced_IRI.parse _namespace_name "vmsUnitFault" |> NamespacedName

    /// <summary>
    /// Details of the fault which is being reported for the specified variable message sign control unit.
    /// <see href="http://vocab.datex.org/terms#VmsUnitFault"></see></summary>
    let VmsUnitFault =
        Namespaced_IRI.parse _namespace_name "VmsUnitFault" |> NamespacedName

    /// <summary>
    /// A reference to a versioned VMS unit record in a VMS Unit table which defines the characteristics of the VMS unit.
    /// <see href="http://vocab.datex.org/terms#vmsUnitReference"></see></summary>
    let vmsUnitReference =
        Namespaced_IRI.parse _namespace_name "vmsUnitReference" |> NamespacedName

    /// <summary>
    /// A reference to a versioned VMS Unit table.
    /// <see href="http://vocab.datex.org/terms#vmsUnitTableReference"></see></summary>
    let vmsUnitTableReference =
        Namespaced_IRI.parse _namespace_name "vmsUnitTableReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_VmsUnitTableVersionedReference"></see>
    /// </summary>
    let _VmsUnitTableVersionedReference =
        Namespaced_IRI.parse _namespace_name "_VmsUnitTableVersionedReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsUnitFaultExtension"></see>
    /// </summary>
    let vmsUnitFaultExtension =
        Namespaced_IRI.parse _namespace_name "vmsUnitFaultExtension" |> NamespacedName

    /// <summary>
    /// A versioned single VMS unit entry/record in the VMS Unit table that defines the characteristics of the VMS unit.
    /// <see href="http://vocab.datex.org/terms#VmsUnitRecord"></see></summary>
    let VmsUnitRecord =
        Namespaced_IRI.parse _namespace_name "VmsUnitRecord" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#numberOfVms"></see>
    /// </summary>
    let numberOfVms =
        Namespaced_IRI.parse _namespace_name "numberOfVms" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsRecord"></see>
    /// </summary>
    let vmsRecord = Namespaced_IRI.parse _namespace_name "vmsRecord" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#_VmsUnitRecordVmsIndexVmsRecord"></see>
    /// </summary>
    let _VmsUnitRecordVmsIndexVmsRecord =
        Namespaced_IRI.parse _namespace_name "_VmsUnitRecordVmsIndexVmsRecord" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsUnitElectronicAddress"></see>
    /// </summary>
    let vmsUnitElectronicAddress =
        Namespaced_IRI.parse _namespace_name "vmsUnitElectronicAddress" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsUnitIPAddress"></see>
    /// </summary>
    let vmsUnitIPAddress =
        Namespaced_IRI.parse _namespace_name "vmsUnitIPAddress" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsUnitIdentifier"></see>
    /// </summary>
    let vmsUnitIdentifier =
        Namespaced_IRI.parse _namespace_name "vmsUnitIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsUnitRecordExtension"></see>
    /// </summary>
    let vmsUnitRecordExtension =
        Namespaced_IRI.parse _namespace_name "vmsUnitRecordExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsUnitRecord"></see>
    /// </summary>
    let vmsUnitRecord =
        Namespaced_IRI.parse _namespace_name "vmsUnitRecord" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsUnitTableExtension"></see>
    /// </summary>
    let vmsUnitTableExtension =
        Namespaced_IRI.parse _namespace_name "vmsUnitTableExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsUnitTableIdentification"></see>
    /// </summary>
    let vmsUnitTableIdentification =
        Namespaced_IRI.parse _namespace_name "vmsUnitTableIdentification" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#weatherDataExtension"></see>
    /// </summary>
    let weatherDataExtension =
        Namespaced_IRI.parse _namespace_name "weatherDataExtension" |> NamespacedName

    /// <summary>
    /// Road surface conditions that are related to the weather which may affect the driving conditions, such as ice, snow or water.
    /// <see href="http://vocab.datex.org/terms#WeatherRelatedRoadConditions"></see></summary>
    let WeatherRelatedRoadConditions =
        Namespaced_IRI.parse _namespace_name "WeatherRelatedRoadConditions" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#weatherRelatedRoadConditionsExtension"></see>
    /// </summary>
    let weatherRelatedRoadConditionsExtension =
        Namespaced_IRI.parse _namespace_name "weatherRelatedRoadConditionsExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleWidth"></see>
    /// </summary>
    let vehicleWidth =
        Namespaced_IRI.parse _namespace_name "vehicleWidth" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#widthCharacteristicExtension"></see>
    /// </summary>
    let widthCharacteristicExtension =
        Namespaced_IRI.parse _namespace_name "widthCharacteristicExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#maximumWindSpeed"></see>
    /// </summary>
    let maximumWindSpeed =
        Namespaced_IRI.parse _namespace_name "maximumWindSpeed" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#windDirectionBearing"></see>
    /// </summary>
    let windDirectionBearing =
        Namespaced_IRI.parse _namespace_name "windDirectionBearing" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#windDirectionCompass"></see>
    /// </summary>
    let windDirectionCompass =
        Namespaced_IRI.parse _namespace_name "windDirectionCompass" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#windExtension"></see>
    /// </summary>
    let windExtension =
        Namespaced_IRI.parse _namespace_name "windExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#windMeasurementHeight"></see>
    /// </summary>
    let windMeasurementHeight =
        Namespaced_IRI.parse _namespace_name "windMeasurementHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#windSpeed"></see>
    /// </summary>
    let windSpeed = Namespaced_IRI.parse _namespace_name "windSpeed" |> NamespacedName

    /// <summary>
    /// Measurements of wind conditions.
    /// <see href="http://vocab.datex.org/terms#WindInformation"></see></summary>
    let WindInformation =
        Namespaced_IRI.parse _namespace_name "WindInformation" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#windInformationExtension"></see>
    /// </summary>
    let windInformationExtension =
        Namespaced_IRI.parse _namespace_name "windInformationExtension" |> NamespacedName

    /// <summary>
    /// Winter driving management action that is instigated by the network/road operator.
    /// <see href="http://vocab.datex.org/terms#WinterDrivingManagement"></see></summary>
    let WinterDrivingManagement =
        Namespaced_IRI.parse _namespace_name "WinterDrivingManagement" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#winterDrivingManagementExtension"></see>
    /// </summary>
    let winterDrivingManagementExtension =
        Namespaced_IRI.parse _namespace_name "winterDrivingManagementExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#areaExtended"></see>
    /// </summary>
    let areaExtended =
        Namespaced_IRI.parse _namespace_name "areaExtended" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrExtendedArea"></see>
    /// </summary>
    let openlrExtendedArea =
        Namespaced_IRI.parse _namespace_name "openlrExtendedArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#any"></see>
    /// </summary>
    let any = Namespaced_IRI.parse _namespace_name "any" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#targetClass"></see>
    /// </summary>
    let targetClass =
        Namespaced_IRI.parse _namespace_name "targetClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingStatusPublication"></see>
    /// </summary>
    let parkingStatusPublication =
        Namespaced_IRI.parse _namespace_name "parkingStatusPublication" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingTablePublication"></see>
    /// </summary>
    let parkingTablePublication =
        Namespaced_IRI.parse _namespace_name "parkingTablePublication" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingVehiclesPublication"></see>
    /// </summary>
    let parkingVehiclesPublication =
        Namespaced_IRI.parse _namespace_name "parkingVehiclesPublication" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#groupIndex"></see>
    /// </summary>
    let groupIndex = Namespaced_IRI.parse _namespace_name "groupIndex" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSpaceBasics"></see>
    /// </summary>
    let parkingSpaceBasics =
        Namespaced_IRI.parse _namespace_name "parkingSpaceBasics" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#parkingSpaceIndex"></see>
    /// </summary>
    let parkingSpaceIndex =
        Namespaced_IRI.parse _namespace_name "parkingSpaceIndex" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#index"></see>
    /// </summary>
    let index = Namespaced_IRI.parse _namespace_name "index" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#referent"></see>
    /// </summary>
    let referent = Namespaced_IRI.parse _namespace_name "referent" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrExtendedLinear"></see>
    /// </summary>
    let openlrExtendedLinear =
        Namespaced_IRI.parse _namespace_name "openlrExtendedLinear" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#equipmentOrServiceFacilityIndex"></see>
    /// </summary>
    let equipmentOrServiceFacilityIndex =
        Namespaced_IRI.parse _namespace_name "equipmentOrServiceFacilityIndex" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#scenarioIndex"></see>
    /// </summary>
    let scenarioIndex =
        Namespaced_IRI.parse _namespace_name "scenarioIndex" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#periodExtended"></see>
    /// </summary>
    let periodExtended =
        Namespaced_IRI.parse _namespace_name "periodExtended" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#openlrExtendedPoint"></see>
    /// </summary>
    let openlrExtendedPoint =
        Namespaced_IRI.parse _namespace_name "openlrExtendedPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pointExtended"></see>
    /// </summary>
    let pointExtended =
        Namespaced_IRI.parse _namespace_name "pointExtended" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#situationRecordExtendedApproved"></see>
    /// </summary>
    let situationRecordExtendedApproved =
        Namespaced_IRI.parse _namespace_name "situationRecordExtendedApproved" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pageNumber"></see>
    /// </summary>
    let pageNumber = Namespaced_IRI.parse _namespace_name "pageNumber" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsText"></see>
    /// </summary>
    let vmsText = Namespaced_IRI.parse _namespace_name "vmsText" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vehicleCharacteristicsExtended"></see>
    /// </summary>
    let vehicleCharacteristicsExtended =
        Namespaced_IRI.parse _namespace_name "vehicleCharacteristicsExtended" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramDisplayAreaIndex"></see>
    /// </summary>
    let pictogramDisplayAreaIndex =
        Namespaced_IRI.parse _namespace_name "pictogramDisplayAreaIndex" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#messageIndex"></see>
    /// </summary>
    let messageIndex =
        Namespaced_IRI.parse _namespace_name "messageIndex" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#pictogramSequencingIndex"></see>
    /// </summary>
    let pictogramSequencingIndex =
        Namespaced_IRI.parse _namespace_name "pictogramSequencingIndex" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#lineIndex"></see>
    /// </summary>
    let lineIndex = Namespaced_IRI.parse _namespace_name "lineIndex" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#vmsIndex"></see>
    /// </summary>
    let vmsIndex = Namespaced_IRI.parse _namespace_name "vmsIndex" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#d2LogicalModel"></see>
    /// </summary>
    let d2LogicalModel =
        Namespaced_IRI.parse _namespace_name "d2LogicalModel" |> NamespacedName

    /// <summary>
    /// An example mapping of Datex2 to an OWL vocabulary
    /// <see href="http://vocab.datex.org/terms#ontology"></see></summary>
    let ontology = Namespaced_IRI.parse _namespace_name "ontology" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.datex.org/terms#value"></see>
    /// </summary>
    let value = Namespaced_IRI.parse _namespace_name "value" |> NamespacedName
