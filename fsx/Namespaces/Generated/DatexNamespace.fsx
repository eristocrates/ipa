#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module datex =
    let _prefixId = PrefixId.fromNamespaceLabel "http://vocab.datex.org/terms#" "datex"
    let AbandonedVehicle = _prefixId.prefix "AbandonedVehicle"
    let AbnormalLoad = _prefixId.prefix "AbnormalLoad"
    /// <summary>
    ///   <para>rdfs:comment : A traffic condition which is not normal.</para>
    ///   <a href="http://vocab.datex.org/terms#AbnormalTraffic">datex:AbnormalTraffic</a>
    /// </summary>
    let AbnormalTraffic = _prefixId.prefix "AbnormalTraffic"
    /// <summary>
    ///   <para>rdfs:comment : Use this class to describe details in case acceptedMeansOfPayment is set to 'paymentCard'.</para>
    ///   <a href="http://vocab.datex.org/terms#AcceptedPaymentCards">datex:AcceptedPaymentCards</a>
    /// </summary>
    let AcceptedPaymentCards = _prefixId.prefix "AcceptedPaymentCards"
    /// <summary>
    ///   <para>rdfs:comment : Accidents are events where one or more vehicles are involved in collisions or in leaving the roadway. These include collisions between vehicles or with other road users or obstacles.</para>
    ///   <a href="http://vocab.datex.org/terms#Accident">datex:Accident</a>
    /// </summary>
    let Accident = _prefixId.prefix "Accident"
    let AccidentInvestigationWork = _prefixId.prefix "AccidentInvestigationWork"
    let AccidentInvolvingBicycles = _prefixId.prefix "AccidentInvolvingBicycles"
    let AccidentInvolvingBuses = _prefixId.prefix "AccidentInvolvingBuses"

    let AccidentInvolvingHazardousMaterials = _prefixId.prefix "AccidentInvolvingHazardousMaterials"

    let AccidentInvolvingHeavyLorries = _prefixId.prefix "AccidentInvolvingHeavyLorries"

    let AccidentInvolvingMassTransitVehicle = _prefixId.prefix "AccidentInvolvingMassTransitVehicle"

    let AccidentInvolvingMopeds = _prefixId.prefix "AccidentInvolvingMopeds"
    let AccidentInvolvingMotorcycles = _prefixId.prefix "AccidentInvolvingMotorcycles"

    let AccidentInvolvingRadioactiveMaterial = _prefixId.prefix "AccidentInvolvingRadioactiveMaterial"

    let AccidentInvolvingTrain = _prefixId.prefix "AccidentInvolvingTrain"
    let ActiveSpeedControlInOperation = _prefixId.prefix "ActiveSpeedControlInOperation"
    /// <summary>
    ///   <para>rdfs:comment : Deliberate human action external to the traffic stream or roadway which could disrupt traffic.</para>
    ///   <a href="http://vocab.datex.org/terms#Activity">datex:Activity</a>
    /// </summary>
    let Activity = _prefixId.prefix "Activity"

    let AdverseInfrastructureConditions = _prefixId.prefix "AdverseInfrastructureConditions"

    /// <summary>
    ///   <para>rdfs:comment : Supplementary positional information which details carriageway and lane locations. Several instances may exist where the element being described extends over more than one carriageway.</para>
    ///   <a href="http://vocab.datex.org/terms#AffectedCarriagewayAndLanes">datex:AffectedCarriagewayAndLanes</a>
    /// </summary>
    let AffectedCarriagewayAndLanes = _prefixId.prefix "AffectedCarriagewayAndLanes"
    let AgriculturalShow = _prefixId.prefix "AgriculturalShow"
    let AirAmbulance = _prefixId.prefix "AirAmbulance"
    let AirRaid = _prefixId.prefix "AirRaid"
    let AirShow = _prefixId.prefix "AirShow"
    /// <summary>
    ///   <para>rdfs:comment : An area defined by reference to a predefined ALERT-C location table.</para>
    ///   <a href="http://vocab.datex.org/terms#AlertCArea">datex:AlertCArea</a>
    /// </summary>
    let AlertCArea = _prefixId.prefix "AlertCArea"
    /// <summary>
    ///   <para>rdfs:comment : The direction of traffic flow along the road to which the information relates.</para>
    ///   <a href="http://vocab.datex.org/terms#AlertCDirection">datex:AlertCDirection</a>
    /// </summary>
    let AlertCDirection = _prefixId.prefix "AlertCDirection"
    /// <summary>
    ///   <para>rdfs:comment : A linear section along a road defined between two points on the road by reference to a pre-defined ALERT-C location table.</para>
    ///   <a href="http://vocab.datex.org/terms#AlertCLinear">datex:AlertCLinear</a>
    /// </summary>
    let AlertCLinear = _prefixId.prefix "AlertCLinear"
    /// <summary>
    ///   <para>rdfs:comment : A linear section along a road defined by reference to a linear section in a pre-defined ALERT-C location table.</para>
    ///   <a href="http://vocab.datex.org/terms#AlertCLinearByCode">datex:AlertCLinearByCode</a>
    /// </summary>
    let AlertCLinearByCode = _prefixId.prefix "AlertCLinearByCode"
    /// <summary>
    ///   <para>rdfs:comment : Identification of a specific point, linear or area location in an ALERT-C location table.</para>
    ///   <a href="http://vocab.datex.org/terms#AlertCLocation">datex:AlertCLocation</a>
    /// </summary>
    let AlertCLocation = _prefixId.prefix "AlertCLocation"
    /// <summary>
    ///   <para>rdfs:comment : A linear section along a road between two points, Primary and Secondary, which are pre-defined in an ALERT-C location table. Direction is FROM the Secondary point TO the Primary point, i.e. the Primary point is downstream of the Secondary point.</para>
    ///   <a href="http://vocab.datex.org/terms#AlertCMethod2Linear">datex:AlertCMethod2Linear</a>
    /// </summary>
    let AlertCMethod2Linear = _prefixId.prefix "AlertCMethod2Linear"
    /// <summary>
    ///   <para>rdfs:comment : A single point on the road network defined by reference to a point in a pre-defined ALERT-C location table and which has an associated direction of traffic flow.</para>
    ///   <a href="http://vocab.datex.org/terms#AlertCMethod2Point">datex:AlertCMethod2Point</a>
    /// </summary>
    let AlertCMethod2Point = _prefixId.prefix "AlertCMethod2Point"

    /// <summary>
    ///   <para>rdfs:comment : The point (called Primary point) which is either a single point or at the downstream end of a linear road section. The point is specified by a reference to a point in a pre-defined ALERT-C location table.</para>
    ///   <a href="http://vocab.datex.org/terms#AlertCMethod2PrimaryPointLocation">datex:AlertCMethod2PrimaryPointLocation</a>
    /// </summary>
    let AlertCMethod2PrimaryPointLocation = _prefixId.prefix "AlertCMethod2PrimaryPointLocation"

    /// <summary>
    ///   <para>rdfs:comment : The point (called Secondary point) which is at the upstream end of a linear road section. The point is specified by a reference to a point in a pre-defined ALERT-C location table.</para>
    ///   <a href="http://vocab.datex.org/terms#AlertCMethod2SecondaryPointLocation">datex:AlertCMethod2SecondaryPointLocation</a>
    /// </summary>
    let AlertCMethod2SecondaryPointLocation = _prefixId.prefix "AlertCMethod2SecondaryPointLocation"

    /// <summary>
    ///   <para>rdfs:comment : A linear section along a road between two points, Primary and Secondary, which are pre-defined ALERT-C locations plus offset distance. Direction is FROM the Secondary point TO the Primary point, i.e. the Primary point is downstream of the Secondary point.</para>
    ///   <a href="http://vocab.datex.org/terms#AlertCMethod4Linear">datex:AlertCMethod4Linear</a>
    /// </summary>
    let AlertCMethod4Linear = _prefixId.prefix "AlertCMethod4Linear"
    /// <summary>
    ///   <para>rdfs:comment : A single point on the road network defined by reference to a point in a pre-defined ALERT-C location table plus an offset distance and which has an associated direction of traffic flow.</para>
    ///   <a href="http://vocab.datex.org/terms#AlertCMethod4Point">datex:AlertCMethod4Point</a>
    /// </summary>
    let AlertCMethod4Point = _prefixId.prefix "AlertCMethod4Point"

    /// <summary>
    ///   <para>rdfs:comment : The point (called Primary point) which is either a single point or at the downstream end of a linear road section. The point is specified by a reference to a point in a pre-defined ALERT-C location table plus a non-negative offset distance.</para>
    ///   <a href="http://vocab.datex.org/terms#AlertCMethod4PrimaryPointLocation">datex:AlertCMethod4PrimaryPointLocation</a>
    /// </summary>
    let AlertCMethod4PrimaryPointLocation = _prefixId.prefix "AlertCMethod4PrimaryPointLocation"

    /// <summary>
    ///   <para>rdfs:comment : The point (called Secondary point) which is at the upstream end of a linear road section. The point is specified by a reference to a point in a pre-defined Alert-C location table plus a non-negative offset distance.</para>
    ///   <a href="http://vocab.datex.org/terms#AlertCMethod4SecondaryPointLocation">datex:AlertCMethod4SecondaryPointLocation</a>
    /// </summary>
    let AlertCMethod4SecondaryPointLocation = _prefixId.prefix "AlertCMethod4SecondaryPointLocation"

    /// <summary>
    ///   <para>rdfs:comment : A single point on the road network defined by reference to a pre-defined ALERT-C location table and which has an associated direction of traffic flow.</para>
    ///   <a href="http://vocab.datex.org/terms#AlertCPoint">datex:AlertCPoint</a>
    /// </summary>
    let AlertCPoint = _prefixId.prefix "AlertCPoint"
    let AltercationOfVehicleOccupants = _prefixId.prefix "AltercationOfVehicleOccupants"
    /// <summary>
    ///   <para>rdfs:comment : An obstruction on the road resulting from the presence of animals.</para>
    ///   <a href="http://vocab.datex.org/terms#AnimalPresenceObstruction">datex:AnimalPresenceObstruction</a>
    /// </summary>
    let AnimalPresenceObstruction = _prefixId.prefix "AnimalPresenceObstruction"
    let AnimalsOnTheInfrastructure = _prefixId.prefix "AnimalsOnTheInfrastructure"
    let AnprCameraFailure = _prefixId.prefix "AnprCameraFailure"
    let AnprCamerasFault = _prefixId.prefix "AnprCamerasFault"
    /// <summary>
    ///   <para>rdfs:comment : A measured or calculated value of the application rate of a substance.</para>
    ///   <a href="http://vocab.datex.org/terms#ApplicationRateValue">datex:ApplicationRateValue</a>
    /// </summary>
    let ApplicationRateValue = _prefixId.prefix "ApplicationRateValue"
    /// <summary>
    ///   <para>rdfs:comment : A geographic or geometric defined area which may be qualified by height information to provide additional geospatial discrimination (e.g. for snow in an area but only above a certain altitude).</para>
    ///   <a href="http://vocab.datex.org/terms#Area">datex:Area</a>
    /// </summary>
    let Area = _prefixId.prefix "Area"
    /// <summary>
    ///   <para>rdfs:comment : The specification of the destination of a defined route or itinerary which is an area.</para>
    ///   <a href="http://vocab.datex.org/terms#AreaDestination">datex:AreaDestination</a>
    /// </summary>
    let AreaDestination = _prefixId.prefix "AreaDestination"
    /// <summary>
    ///   <para>rdfs:comment : Extension class for area used in parking publication extension.</para>
    ///   <a href="http://vocab.datex.org/terms#AreaExtended">datex:AreaExtended</a>
    /// </summary>
    let AreaExtended = _prefixId.prefix "AreaExtended"
    let Assault = _prefixId.prefix "Assault"
    let AssetDestruction = _prefixId.prefix "AssetDestruction"
    let AthleticsMeeting = _prefixId.prefix "AthleticsMeeting"
    let Attack = _prefixId.prefix "Attack"
    let AttackOnVehicle = _prefixId.prefix "AttackOnVehicle"
    /// <summary>
    ///   <para>rdfs:comment : Authority initiated operation or activity that could disrupt traffic.</para>
    ///   <a href="http://vocab.datex.org/terms#AuthorityOperation">datex:AuthorityOperation</a>
    /// </summary>
    let AuthorityOperation = _prefixId.prefix "AuthorityOperation"
    let AutomatedTollSystemFailure = _prefixId.prefix "AutomatedTollSystemFailure"
    let AutomatedTollSystemFault = _prefixId.prefix "AutomatedTollSystemFault"
    let Avalanches = _prefixId.prefix "Avalanches"
    /// <summary>
    ///   <para>rdfs:comment : A measured or calculated value of the flow rate of vehicle axles.</para>
    ///   <a href="http://vocab.datex.org/terms#AxleFlowValue">datex:AxleFlowValue</a>
    /// </summary>
    let AxleFlowValue = _prefixId.prefix "AxleFlowValue"
    /// <summary>
    ///   <para>rdfs:comment : The spacing details between the axle sets of an individual vehicle numbered from the front to the back of the vehicle. </para>
    ///   <a href="http://vocab.datex.org/terms#AxleSpacing">datex:AxleSpacing</a>
    /// </summary>
    let AxleSpacing = _prefixId.prefix "AxleSpacing"
    /// <summary>
    ///   <para>rdfs:comment : The weight details of a specific axle on the vehicle. </para>
    ///   <a href="http://vocab.datex.org/terms#AxleWeight">datex:AxleWeight</a>
    /// </summary>
    let AxleWeight = _prefixId.prefix "AxleWeight"
    let BadWeather = _prefixId.prefix "BadWeather"
    let BallGame = _prefixId.prefix "BallGame"
    let BaseballGame = _prefixId.prefix "BaseballGame"
    /// <summary>
    ///   <para>rdfs:comment : Data that is either measured or calculated (elaborated) at the same time or over the same time period.</para>
    ///   <a href="http://vocab.datex.org/terms#BasicData">datex:BasicData</a>
    /// </summary>
    let BasicData = _prefixId.prefix "BasicData"
    let BasketballGame = _prefixId.prefix "BasketballGame"
    let BicycleRace = _prefixId.prefix "BicycleRace"
    let BlackIce = _prefixId.prefix "BlackIce"
    let BlastingWork = _prefixId.prefix "BlastingWork"
    let Blizzard = _prefixId.prefix "Blizzard"
    let BlockadeOrBarrier = _prefixId.prefix "BlockadeOrBarrier"
    let BlowingDust = _prefixId.prefix "BlowingDust"
    let BlowingSnow = _prefixId.prefix "BlowingSnow"
    let BoatRace = _prefixId.prefix "BoatRace"
    let BoatShow = _prefixId.prefix "BoatShow"
    let BombAlert = _prefixId.prefix "BombAlert"
    let BombSquadInAction = _prefixId.prefix "BombSquadInAction"
    let BoxingTournament = _prefixId.prefix "BoxingTournament"
    let BridgeSwingInOperation = _prefixId.prefix "BridgeSwingInOperation"
    let BrokenDownBus = _prefixId.prefix "BrokenDownBus"
    let BrokenDownHeavyLorry = _prefixId.prefix "BrokenDownHeavyLorry"
    let BrokenDownVehicle = _prefixId.prefix "BrokenDownVehicle"
    let BullFight = _prefixId.prefix "BullFight"
    let BurstPipe = _prefixId.prefix "BurstPipe"
    let BurstWaterMain = _prefixId.prefix "BurstWaterMain"
    /// <summary>
    ///   <para>rdfs:comment : Provides information on the status of one or more car parks.</para>
    ///   <a href="http://vocab.datex.org/terms#CarParks">datex:CarParks</a>
    /// </summary>
    let CarParks = _prefixId.prefix "CarParks"
    let CarPoolLaneInOperation = _prefixId.prefix "CarPoolLaneInOperation"
    let CarriagewayClosures = _prefixId.prefix "CarriagewayClosures"
    /// <summary>
    ///   <para>rdfs:comment : Identification of the supplier's data catalogue in a data exchange context.</para>
    ///   <a href="http://vocab.datex.org/terms#CatalogueReference">datex:CatalogueReference</a>
    /// </summary>
    let CatalogueReference = _prefixId.prefix "CatalogueReference"
    /// <summary>
    ///   <para>rdfs:comment : Contains details of the cause of a record within a situation</para>
    ///   <a href="http://vocab.datex.org/terms#Cause">datex:Cause</a>
    /// </summary>
    let Cause = _prefixId.prefix "Cause"
    let CctvCamerasFailure = _prefixId.prefix "CctvCamerasFailure"
    let CctvCamerasFault = _prefixId.prefix "CctvCamerasFault"
    let CeremonialEvent = _prefixId.prefix "CeremonialEvent"
    /// <summary>
    ///   <para>rdfs:comment : A particular charge for a specified interval belonging a charge band.</para>
    ///   <a href="http://vocab.datex.org/terms#Charge">datex:Charge</a>
    /// </summary>
    let Charge = _prefixId.prefix "Charge"
    /// <summary>
    ///   <para>rdfs:comment : A charge band in accordance with the specified conditions, possibly up to a maximum duration, during a specified period and for a vehicle of specified characteristics (in case of parking).</para>
    ///   <a href="http://vocab.datex.org/terms#ChargeBand">datex:ChargeBand</a>
    /// </summary>
    let ChargeBand = _prefixId.prefix "ChargeBand"
    /// <summary>
    ///   <para>rdfs:comment : Using (a) prior defined charge band(s), identified by its reference.</para>
    ///   <a href="http://vocab.datex.org/terms#ChargeBandByReference">datex:ChargeBandByReference</a>
    /// </summary>
    let ChargeBandByReference = _prefixId.prefix "ChargeBandByReference"
    let ChemicalSpillageAccident = _prefixId.prefix "ChemicalSpillageAccident"
    let CivilEmergency = _prefixId.prefix "CivilEmergency"
    let ClearanceWork = _prefixId.prefix "ClearanceWork"
    let ClosedPermanentlyForTheWinter = _prefixId.prefix "ClosedPermanentlyForTheWinter"
    let CollapsedSewer = _prefixId.prefix "CollapsedSewer"
    let Collision = _prefixId.prefix "Collision"
    let CollisionWithAnimal = _prefixId.prefix "CollisionWithAnimal"
    let CollisionWithObstruction = _prefixId.prefix "CollisionWithObstruction"
    let CollisionWithPerson = _prefixId.prefix "CollisionWithPerson"
    /// <summary>
    ///   <para>rdfs:comment : A free text comment with an optional date/time stamp that can be used by the operator to convey un-coded observations/information.</para>
    ///   <a href="http://vocab.datex.org/terms#Comment">datex:Comment</a>
    /// </summary>
    let Comment = _prefixId.prefix "Comment"
    let CommercialEvent = _prefixId.prefix "CommercialEvent"
    /// <summary>
    ///   <para>rdfs:comment : A measured or calculated value of the concentration of vehicles on a unit stretch of road in a given direction.</para>
    ///   <a href="http://vocab.datex.org/terms#ConcentrationOfVehiclesValue">datex:ConcentrationOfVehiclesValue</a>
    /// </summary>
    let ConcentrationOfVehiclesValue = _prefixId.prefix "ConcentrationOfVehiclesValue"
    let Concert = _prefixId.prefix "Concert"
    /// <summary>
    ///   <para>rdfs:comment : Any conditions which have the potential to degrade normal driving conditions.</para>
    ///   <a href="http://vocab.datex.org/terms#Conditions">datex:Conditions</a>
    /// </summary>
    let Conditions = _prefixId.prefix "Conditions"
    let ConstructionWork = _prefixId.prefix "ConstructionWork"
    /// <summary>
    ///   <para>rdfs:comment : Roadworks involving the construction of new infrastructure.</para>
    ///   <a href="http://vocab.datex.org/terms#ConstructionWorks">datex:ConstructionWorks</a>
    /// </summary>
    let ConstructionWorks = _prefixId.prefix "ConstructionWorks"
    /// <summary>
    ///   <para>rdfs:comment : Address and contact information about some person, service or the parking site, provided in detail or via reference.</para>
    ///   <a href="http://vocab.datex.org/terms#Contact">datex:Contact</a>
    /// </summary>
    let Contact = _prefixId.prefix "Contact"
    /// <summary>
    ///   <para>rdfs:comment : Contact information that is addressed via a reference.</para>
    ///   <a href="http://vocab.datex.org/terms#ContactByReference">datex:ContactByReference</a>
    /// </summary>
    let ContactByReference = _prefixId.prefix "ContactByReference"
    /// <summary>
    ///   <para>rdfs:comment : Details for some person, service or the parking site itself, especially address information.</para>
    ///   <a href="http://vocab.datex.org/terms#ContactDetails">datex:ContactDetails</a>
    /// </summary>
    let ContactDetails = _prefixId.prefix "ContactDetails"
    let Contraflow = _prefixId.prefix "Contraflow"
    let ControlledAvalanche = _prefixId.prefix "ControlledAvalanche"
    let Convoy = _prefixId.prefix "Convoy"
    let ConvoyService = _prefixId.prefix "ConvoyService"
    let CricketMatch = _prefixId.prefix "CricketMatch"
    let Crosswinds = _prefixId.prefix "Crosswinds"
    let Crowd = _prefixId.prefix "Crowd"
    let CulturalEvent = _prefixId.prefix "CulturalEvent"
    let CustomsOperation = _prefixId.prefix "CustomsOperation"
    /// <summary>
    ///   <para>rdfs:comment : The DATEX II logical model comprising exchange, content payload and management sub-models.</para>
    ///   <a href="http://vocab.datex.org/terms#D2LogicalModel">datex:D2LogicalModel</a>
    /// </summary>
    let D2LogicalModel = _prefixId.prefix "D2LogicalModel"
    let DamagedBridge = _prefixId.prefix "DamagedBridge"
    let DamagedCrashBarrier = _prefixId.prefix "DamagedCrashBarrier"
    let DamagedFlyover = _prefixId.prefix "DamagedFlyover"
    let DamagedGallery = _prefixId.prefix "DamagedGallery"
    let DamagedGantry = _prefixId.prefix "DamagedGantry"
    let DamagedRoadSurface = _prefixId.prefix "DamagedRoadSurface"
    let DamagedTunnel = _prefixId.prefix "DamagedTunnel"
    let DamagedVehicle = _prefixId.prefix "DamagedVehicle"
    let DamagedViaduct = _prefixId.prefix "DamagedViaduct"
    let DamagingHail = _prefixId.prefix "DamagingHail"
    let DangerousSlowMovingVehicle = _prefixId.prefix "DangerousSlowMovingVehicle"
    /// <summary>
    ///   <para>rdfs:comment : A data value of something that can be measured or calculated. Any provided meta-data values specified in the attributes override any specified generic characteristics such as defined for a specific measurement in the MeasurementSiteTable. </para>
    ///   <a href="http://vocab.datex.org/terms#DataValue">datex:DataValue</a>
    /// </summary>
    let DataValue = _prefixId.prefix "DataValue"
    /// <summary>
    ///   <para>rdfs:comment : A measured or calculated value of an instance in time.</para>
    ///   <a href="http://vocab.datex.org/terms#DateTimeValue">datex:DateTimeValue</a>
    /// </summary>
    let DateTimeValue = _prefixId.prefix "DateTimeValue"
    /// <summary>
    ///   <para>rdfs:comment : Specification of periods defined by the intersection of days, weeks and months.</para>
    ///   <a href="http://vocab.datex.org/terms#DayWeekMonth">datex:DayWeekMonth</a>
    /// </summary>
    let DayWeekMonth = _prefixId.prefix "DayWeekMonth"
    /// <summary>
    ///   <para>rdfs:comment : Reference to an access of any type (vehicles, pedestrian, ...).</para>
    ///   <a href="http://vocab.datex.org/terms#DedicatedAccess">datex:DedicatedAccess</a>
    /// </summary>
    let DedicatedAccess = _prefixId.prefix "DedicatedAccess"
    let DeepSnow = _prefixId.prefix "DeepSnow"
    /// <summary>
    ///   <para>rdfs:comment : The details of the delays being caused by the situation element defined in the situation record. It is recommended to only use one of the optional attributes to avoid confusion.</para>
    ///   <a href="http://vocab.datex.org/terms#Delays">datex:Delays</a>
    /// </summary>
    let Delays = _prefixId.prefix "Delays"
    let DemolitionWork = _prefixId.prefix "DemolitionWork"
    let Demonstration = _prefixId.prefix "Demonstration"
    let DenseFog = _prefixId.prefix "DenseFog"
    /// <summary>
    ///   <para>rdfs:comment : The specification a destination. This may be either a point location or an area location.</para>
    ///   <a href="http://vocab.datex.org/terms#Destination">datex:Destination</a>
    /// </summary>
    let Destination = _prefixId.prefix "Destination"
    let DieselOnInfrastructure = _prefixId.prefix "DieselOnInfrastructure"
    /// <summary>
    ///   <para>rdfs:comment : A component that provides dimension information. The product of width and height must not be necessarily be the square footage (e.g. in multi-storey buildings or when some zones are not part of the square footage).</para>
    ///   <a href="http://vocab.datex.org/terms#Dimension">datex:Dimension</a>
    /// </summary>
    let Dimension = _prefixId.prefix "Dimension"
    /// <summary>
    ///   <para>rdfs:comment : A measured or calculated value of direction as a bearing.</para>
    ///   <a href="http://vocab.datex.org/terms#DirectionBearingValue">datex:DirectionBearingValue</a>
    /// </summary>
    let DirectionBearingValue = _prefixId.prefix "DirectionBearingValue"
    /// <summary>
    ///   <para>rdfs:comment : A measured or calculated value of direction as a point of the compass.</para>
    ///   <a href="http://vocab.datex.org/terms#DirectionCompassValue">datex:DirectionCompassValue</a>
    /// </summary>
    let DirectionCompassValue = _prefixId.prefix "DirectionCompassValue"
    /// <summary>
    ///   <para>rdfs:comment : Distance of a point along a linear element either measured from the start node or a defined referent on that linear element, where the start node is relative to the element definition rather than the direction of traffic flow.</para>
    ///   <a href="http://vocab.datex.org/terms#DistanceAlongLinearElement">datex:DistanceAlongLinearElement</a>
    /// </summary>
    let DistanceAlongLinearElement = _prefixId.prefix "DistanceAlongLinearElement"

    /// <summary>
    ///   <para>rdfs:comment : Distance of a point along a linear element measured from a "from referent" on the linear element, in the sense relative to the linear element definition rather than the direction of traffic flow or optionally towards a "towards referent".</para>
    ///   <a href="http://vocab.datex.org/terms#DistanceFromLinearElementReferent">datex:DistanceFromLinearElementReferent</a>
    /// </summary>
    let DistanceFromLinearElementReferent = _prefixId.prefix "DistanceFromLinearElementReferent"

    /// <summary>
    ///   <para>rdfs:comment : Distance of a point along a linear element measured from the start node of the linear element, where start node is relative to the element definition rather than the direction of traffic flow.</para>
    ///   <a href="http://vocab.datex.org/terms#DistanceFromLinearElementStart">datex:DistanceFromLinearElementStart</a>
    /// </summary>
    let DistanceFromLinearElementStart = _prefixId.prefix "DistanceFromLinearElementStart"

    /// <summary>
    ///   <para>rdfs:comment : Deliberate human action of either a public disorder nature or of a situation alert type which could disrupt traffic.</para>
    ///   <a href="http://vocab.datex.org/terms#DisturbanceActivity">datex:DisturbanceActivity</a>
    /// </summary>
    let DisturbanceActivity = _prefixId.prefix "DisturbanceActivity"
    let DrivingCondition = _prefixId.prefix "DrivingCondition"
    let Dry = _prefixId.prefix "Dry"
    /// <summary>
    ///   <para>rdfs:comment : A measured or calculated value of a period of time.</para>
    ///   <a href="http://vocab.datex.org/terms#DurationValue">datex:DurationValue</a>
    /// </summary>
    let DurationValue = _prefixId.prefix "DurationValue"
    let EarthquakeDamage = _prefixId.prefix "EarthquakeDamage"
    let Eclipse = _prefixId.prefix "Eclipse"
    /// <summary>
    ///   <para>rdfs:comment : An instance of data which is derived/computed from one or more measurements over a period of time. It may be a current value or a forecast value predicted from historical measurements.</para>
    ///   <a href="http://vocab.datex.org/terms#ElaboratedData">datex:ElaboratedData</a>
    /// </summary>
    let ElaboratedData = _prefixId.prefix "ElaboratedData"
    /// <summary>
    ///   <para>rdfs:comment : Details of a fault which is being reported for the related elaborated data.</para>
    ///   <a href="http://vocab.datex.org/terms#ElaboratedDataFault">datex:ElaboratedDataFault</a>
    /// </summary>
    let ElaboratedDataFault = _prefixId.prefix "ElaboratedDataFault"
    /// <summary>
    ///   <para>rdfs:comment : A publication containing one or more elaborated data sets.</para>
    ///   <a href="http://vocab.datex.org/terms#ElaboratedDataPublication">datex:ElaboratedDataPublication</a>
    /// </summary>
    let ElaboratedDataPublication = _prefixId.prefix "ElaboratedDataPublication"
    /// <summary>
    ///   <para>rdfs:comment : Additional information for the equipment 'electricChargingStation'. This component refers to the number of charging stations specified in the attribute 'numberOfEquipmentOrServiceFacilities'.</para>
    ///   <a href="http://vocab.datex.org/terms#ElectricCharging">datex:ElectricCharging</a>
    /// </summary>
    let ElectricCharging = _prefixId.prefix "ElectricCharging"

    let EmergencyRoadsideTelephoneFailure = _prefixId.prefix "EmergencyRoadsideTelephoneFailure"

    let EmergencyRoadsideTelephoneFault = _prefixId.prefix "EmergencyRoadsideTelephoneFault"

    let EmergencyServices = _prefixId.prefix "EmergencyServices"
    let EmergencyVehicle = _prefixId.prefix "EmergencyVehicle"
    let EnvironmentalConditions = _prefixId.prefix "EnvironmentalConditions"
    /// <summary>
    ///   <para>rdfs:comment : An obstruction on the road resulting from an environmental cause.</para>
    ///   <a href="http://vocab.datex.org/terms#EnvironmentalObstruction">datex:EnvironmentalObstruction</a>
    /// </summary>
    let EnvironmentalObstruction = _prefixId.prefix "EnvironmentalObstruction"
    /// <summary>
    ///   <para>rdfs:comment : One type of equipment, that is available on the parking site.</para>
    ///   <a href="http://vocab.datex.org/terms#Equipment">datex:Equipment</a>
    /// </summary>
    let Equipment = _prefixId.prefix "Equipment"
    /// <summary>
    ///   <para>rdfs:comment : Equipment or system which is faulty, malfunctioning or not in a fully operational state that may be of interest or concern to road operators and road users.</para>
    ///   <a href="http://vocab.datex.org/terms#EquipmentOrSystemFault">datex:EquipmentOrSystemFault</a>
    /// </summary>
    let EquipmentOrSystemFault = _prefixId.prefix "EquipmentOrSystemFault"
    let Evacuation = _prefixId.prefix "Evacuation"
    /// <summary>
    ///   <para>rdfs:comment : Details associated with the management of the exchange between the supplier and the client.</para>
    ///   <a href="http://vocab.datex.org/terms#Exchange">datex:Exchange</a>
    /// </summary>
    let Exchange = _prefixId.prefix "Exchange"
    let Exhibition = _prefixId.prefix "Exhibition"
    /// <summary>
    ///   <para>rdfs:comment : A location defined by reference to an external/other referencing system.</para>
    ///   <a href="http://vocab.datex.org/terms#ExternalReferencing">datex:ExternalReferencing</a>
    /// </summary>
    let ExternalReferencing = _prefixId.prefix "ExternalReferencing"
    let ExtremeCold = _prefixId.prefix "ExtremeCold"
    let ExtremeHeat = _prefixId.prefix "ExtremeHeat"
    let Fair = _prefixId.prefix "Fair"
    let FallenPowerCables = _prefixId.prefix "FallenPowerCables"
    let FallenTrees = _prefixId.prefix "FallenTrees"
    let FallingIce = _prefixId.prefix "FallingIce"
    let FallingLightIceOrSnow = _prefixId.prefix "FallingLightIceOrSnow"
    /// <summary>
    ///   <para>rdfs:comment : Information about a fault relating to a specific piece of equipment or process.</para>
    ///   <a href="http://vocab.datex.org/terms#Fault">datex:Fault</a>
    /// </summary>
    let Fault = _prefixId.prefix "Fault"
    let Festival = _prefixId.prefix "Festival"
    let FilmTVMaking = _prefixId.prefix "FilmTVMaking"
    let FilterBlockade = _prefixId.prefix "FilterBlockade"
    /// <summary>
    ///   <para>rdfs:comment : Filter indicators management information.</para>
    ///   <a href="http://vocab.datex.org/terms#FilterExitManagement">datex:FilterExitManagement</a>
    /// </summary>
    let FilterExitManagement = _prefixId.prefix "FilterExitManagement"
    /// <summary>
    ///   <para>rdfs:comment : Details of a supplier's filter in a data exchange context.</para>
    ///   <a href="http://vocab.datex.org/terms#FilterReference">datex:FilterReference</a>
    /// </summary>
    let FilterReference = _prefixId.prefix "FilterReference"
    let FirstAid = _prefixId.prefix "FirstAid"
    let FlashFloods = _prefixId.prefix "FlashFloods"

    /// <summary>
    ///   <para>rdfs:comment : A measured or calculated value of distance in metres in a floating point format.</para>
    ///   <a href="http://vocab.datex.org/terms#FloatingPointMetreDistanceValue">datex:FloatingPointMetreDistanceValue</a>
    /// </summary>
    let FloatingPointMetreDistanceValue = _prefixId.prefix "FloatingPointMetreDistanceValue"

    let Flooding = _prefixId.prefix "Flooding"
    let Fog = _prefixId.prefix "Fog"
    let FoodDelivery = _prefixId.prefix "FoodDelivery"
    let FootballMatch = _prefixId.prefix "FootballMatch"
    let ForestFire = _prefixId.prefix "ForestFire"
    let FreezingFog = _prefixId.prefix "FreezingFog"

    let FreezingOfWetInfrastructureSurface = _prefixId.prefix "FreezingOfWetInfrastructureSurface"

    let FreezingPavements = _prefixId.prefix "FreezingPavements"
    let FreezingRain = _prefixId.prefix "FreezingRain"
    let FreshSnow = _prefixId.prefix "FreshSnow"
    let Frost = _prefixId.prefix "Frost"
    let FuelSpillageAccident = _prefixId.prefix "FuelSpillageAccident"
    let Funfair = _prefixId.prefix "Funfair"
    let Gales = _prefixId.prefix "Gales"
    let GalleryLightsFailure = _prefixId.prefix "GalleryLightsFailure"
    let GalleryLightsFault = _prefixId.prefix "GalleryLightsFault"
    let GardeningOrFlowerShow = _prefixId.prefix "GardeningOrFlowerShow"
    let GasLeak = _prefixId.prefix "GasLeak"

    /// <summary>
    ///   <para>rdfs:comment : General instruction and/or message that is issued by the network/road operator which is applicable to drivers and sometimes passengers.</para>
    ///   <a href="http://vocab.datex.org/terms#GeneralInstructionOrMessageToRoadUsers">datex:GeneralInstructionOrMessageToRoadUsers</a>
    /// </summary>
    let GeneralInstructionOrMessageToRoadUsers = _prefixId.prefix "GeneralInstructionOrMessageToRoadUsers"

    /// <summary>
    ///   <para>rdfs:comment : Network management action that is instigated either manually or automatically by the network/road operator.  Compliance with any resulting control may be advisory or mandatory.</para>
    ///   <a href="http://vocab.datex.org/terms#GeneralNetworkManagement">datex:GeneralNetworkManagement</a>
    /// </summary>
    let GeneralNetworkManagement = _prefixId.prefix "GeneralNetworkManagement"
    /// <summary>
    ///   <para>rdfs:comment : Any stationary or moving obstacle of a physical nature, other than of an animal, vehicle, environmental, or damaged equipment nature.</para>
    ///   <a href="http://vocab.datex.org/terms#GeneralObstruction">datex:GeneralObstruction</a>
    /// </summary>
    let GeneralObstruction = _prefixId.prefix "GeneralObstruction"
    /// <summary>
    ///   <para>rdfs:comment : A publication used to make level B extensions at the publication level.</para>
    ///   <a href="http://vocab.datex.org/terms#GenericPublication">datex:GenericPublication</a>
    /// </summary>
    let GenericPublication = _prefixId.prefix "GenericPublication"
    /// <summary>
    ///   <para>rdfs:comment : A generic SituationRecord for use when adding level B extensions at the SituationRecord level.</para>
    ///   <a href="http://vocab.datex.org/terms#GenericSituationRecord">datex:GenericSituationRecord</a>
    /// </summary>
    let GenericSituationRecord = _prefixId.prefix "GenericSituationRecord"
    let GoSlowOperation = _prefixId.prefix "GoSlowOperation"
    let GolfTournament = _prefixId.prefix "GolfTournament"
    let GrassCuttingWork = _prefixId.prefix "GrassCuttingWork"
    let GrassFire = _prefixId.prefix "GrassFire"
    /// <summary>
    ///   <para>rdfs:comment : Gross weight characteristic of a vehicle.</para>
    ///   <a href="http://vocab.datex.org/terms#GrossWeightCharacteristic">datex:GrossWeightCharacteristic</a>
    /// </summary>
    let GrossWeightCharacteristic = _prefixId.prefix "GrossWeightCharacteristic"
    /// <summary>
    ///   <para>rdfs:comment : One or more physically separate locations. Multiple locations may be related, as in an itinerary (or route), or may be unrelated. It is not for identifying the same physical location using different Location objects for different referencing systems.</para>
    ///   <a href="http://vocab.datex.org/terms#GroupOfLocations">datex:GroupOfLocations</a>
    /// </summary>
    let GroupOfLocations = _prefixId.prefix "GroupOfLocations"
    /// <summary>
    ///   <para>rdfs:comment : A logical composition of parking sites with aggregated properties (e.g. number of spaces). Examples: Urban parking area "West" or all truck parkings along a motorway. The included parking sites may -but must not- be specified as subcomponents.</para>
    ///   <a href="http://vocab.datex.org/terms#GroupOfParkingSites">datex:GroupOfParkingSites</a>
    /// </summary>
    let GroupOfParkingSites = _prefixId.prefix "GroupOfParkingSites"
    /// <summary>
    ///   <para>rdfs:comment : Dynamic status information for the static object 'GroupOfParkingSites'.</para>
    ///   <a href="http://vocab.datex.org/terms#GroupOfParkingSitesStatus">datex:GroupOfParkingSitesStatus</a>
    /// </summary>
    let GroupOfParkingSitesStatus = _prefixId.prefix "GroupOfParkingSitesStatus"
    /// <summary>
    ///   <para>rdfs:comment : A group of parking spaces. All information provided has to be identical for all places in this group. Can also be used just to give the number of lorry parkings, for example. 'GroupOfParkingSpaces' may be multiple defined or include each other.</para>
    ///   <a href="http://vocab.datex.org/terms#GroupOfParkingSpaces">datex:GroupOfParkingSpaces</a>
    /// </summary>
    let GroupOfParkingSpaces = _prefixId.prefix "GroupOfParkingSpaces"
    /// <summary>
    ///   <para>rdfs:comment : The status of the assigned parking spaces in the specified parking site, i.e. the status of those spaces assigned for particular types of person or vehicle and/or for specific duration types (e.g. short stay).</para>
    ///   <a href="http://vocab.datex.org/terms#GroupOfParkingSpacesStatus">datex:GroupOfParkingSpacesStatus</a>
    /// </summary>
    let GroupOfParkingSpacesStatus = _prefixId.prefix "GroupOfParkingSpacesStatus"
    /// <summary>
    ///   <para>rdfs:comment : Group of people involved in the event having common characteristics and/or status.</para>
    ///   <a href="http://vocab.datex.org/terms#GroupOfPeopleInvolved">datex:GroupOfPeopleInvolved</a>
    /// </summary>
    let GroupOfPeopleInvolved = _prefixId.prefix "GroupOfPeopleInvolved"
    /// <summary>
    ///   <para>rdfs:comment : Group of the vehicles involved having common characteristics and/or status.</para>
    ///   <a href="http://vocab.datex.org/terms#GroupOfVehiclesInvolved">datex:GroupOfVehiclesInvolved</a>
    /// </summary>
    let GroupOfVehiclesInvolved = _prefixId.prefix "GroupOfVehiclesInvolved"
    let GunfireOnRoadway = _prefixId.prefix "GunfireOnRoadway"
    let GustyWinds = _prefixId.prefix "GustyWinds"
    let Hail = _prefixId.prefix "Hail"

    let HardShoulderRunningInOperation = _prefixId.prefix "HardShoulderRunningInOperation"

    let Hazardous = _prefixId.prefix "Hazardous"
    /// <summary>
    ///   <para>rdfs:comment : Details of hazardous materials.</para>
    ///   <a href="http://vocab.datex.org/terms#HazardousMaterials">datex:HazardousMaterials</a>
    /// </summary>
    let HazardousMaterials = _prefixId.prefix "HazardousMaterials"
    let HeadOnCollision = _prefixId.prefix "HeadOnCollision"
    let HeadOnOrSideCollision = _prefixId.prefix "HeadOnOrSideCollision"
    /// <summary>
    ///   <para>rdfs:comment : Management information relating to the data contained within a publication.</para>
    ///   <a href="http://vocab.datex.org/terms#HeaderInformation">datex:HeaderInformation</a>
    /// </summary>
    let HeaderInformation = _prefixId.prefix "HeaderInformation"

    /// <summary>
    ///   <para>rdfs:comment : Weight characteristic of the heaviest axle on the vehicle.</para>
    ///   <a href="http://vocab.datex.org/terms#HeaviestAxleWeightCharacteristic">datex:HeaviestAxleWeightCharacteristic</a>
    /// </summary>
    let HeaviestAxleWeightCharacteristic = _prefixId.prefix "HeaviestAxleWeightCharacteristic"

    let HeavyFrost = _prefixId.prefix "HeavyFrost"
    let HeavyRain = _prefixId.prefix "HeavyRain"
    let HeavySnowfall = _prefixId.prefix "HeavySnowfall"
    let HeavyTraffic = _prefixId.prefix "HeavyTraffic"
    /// <summary>
    ///   <para>rdfs:comment : Height characteristic of a vehicle.</para>
    ///   <a href="http://vocab.datex.org/terms#HeightCharacteristic">datex:HeightCharacteristic</a>
    /// </summary>
    let HeightCharacteristic = _prefixId.prefix "HeightCharacteristic"
    let HeightRestrictionInOperation = _prefixId.prefix "HeightRestrictionInOperation"
    let HelicopterRescue = _prefixId.prefix "HelicopterRescue"

    let HerdOfAnimalsOnTheInfrastructure = _prefixId.prefix "HerdOfAnimalsOnTheInfrastructure"

    let HighSpeedEmergencyVehicle = _prefixId.prefix "HighSpeedEmergencyVehicle"
    let HockeyGame = _prefixId.prefix "HockeyGame"
    let HorseRaceMeeting = _prefixId.prefix "HorseRaceMeeting"
    /// <summary>
    ///   <para>rdfs:comment : Details of atmospheric humidity.</para>
    ///   <a href="http://vocab.datex.org/terms#Humidity">datex:Humidity</a>
    /// </summary>
    let Humidity = _prefixId.prefix "Humidity"
    /// <summary>
    ///   <para>rdfs:comment : Measurements of atmospheric humidity.</para>
    ///   <a href="http://vocab.datex.org/terms#HumidityInformation">datex:HumidityInformation</a>
    /// </summary>
    let HumidityInformation = _prefixId.prefix "HumidityInformation"
    let HurricaneForceWinds = _prefixId.prefix "HurricaneForceWinds"
    let Ice = _prefixId.prefix "Ice"
    let IceBuildUp = _prefixId.prefix "IceBuildUp"
    let IceWithWheelBarTracks = _prefixId.prefix "IceWithWheelBarTracks"
    let IcyPatches = _prefixId.prefix "IcyPatches"
    let IllVehicleOccupants = _prefixId.prefix "IllVehicleOccupants"
    /// <summary>
    ///   <para>rdfs:comment : An assessment of the impact that an event or operator action defined by the situation record has on the driving conditions.</para>
    ///   <a href="http://vocab.datex.org/terms#Impact">datex:Impact</a>
    /// </summary>
    let Impact = _prefixId.prefix "Impact"
    let Impossible = _prefixId.prefix "Impossible"
    /// <summary>
    ///   <para>rdfs:comment : Information on the individual charge for parking the specified vehicle.</para>
    ///   <a href="http://vocab.datex.org/terms#IndividualCharge">datex:IndividualCharge</a>
    /// </summary>
    let IndividualCharge = _prefixId.prefix "IndividualCharge"
    /// <summary>
    ///   <para>rdfs:comment : Measured or calculated data values relating to individual vehicles derived from detectors at the specified measurement site.</para>
    ///   <a href="http://vocab.datex.org/terms#IndividualVehicleDataValues">datex:IndividualVehicleDataValues</a>
    /// </summary>
    let IndividualVehicleDataValues = _prefixId.prefix "IndividualVehicleDataValues"
    let InfrastructureConstruction = _prefixId.prefix "InfrastructureConstruction"

    /// <summary>
    ///   <para>rdfs:comment : An obstruction on the road resulting from the failure or damage of infrastructure on, under, above or close to the road.</para>
    ///   <a href="http://vocab.datex.org/terms#InfrastructureDamageObstruction">datex:InfrastructureDamageObstruction</a>
    /// </summary>
    let InfrastructureDamageObstruction = _prefixId.prefix "InfrastructureDamageObstruction"

    let InfrastructureFailure = _prefixId.prefix "InfrastructureFailure"
    let InfrastructureFault = _prefixId.prefix "InfrastructureFault"

    let InfrastructureImprovementOrUpgrading = _prefixId.prefix "InfrastructureImprovementOrUpgrading"

    let InfrastructureMaintenance = _prefixId.prefix "InfrastructureMaintenance"
    let InfrastructureSideAssistance = _prefixId.prefix "InfrastructureSideAssistance"

    let InfrastructureSideCommunicationsSystemFailure = _prefixId.prefix "InfrastructureSideCommunicationsSystemFailure"

    let InfrastructureSideCommunicationsSystemFault = _prefixId.prefix "InfrastructureSideCommunicationsSystemFault"

    let InfrastructureSidePowerSystemFailure = _prefixId.prefix "InfrastructureSidePowerSystemFailure"

    let InfrastructureSidePowerSystemFault = _prefixId.prefix "InfrastructureSidePowerSystemFault"

    let InfrastructureSideWork = _prefixId.prefix "InfrastructureSideWork"

    let InfrastructureSurfaceInPoorCondition = _prefixId.prefix "InfrastructureSurfaceInPoorCondition"

    let InfrastructureWorks = _prefixId.prefix "InfrastructureWorks"
    let InfrastructureWorksClearance = _prefixId.prefix "InfrastructureWorksClearance"
    let InstallationWork = _prefixId.prefix "InstallationWork"
    /// <summary>
    ///   <para>rdfs:comment : A measured or calculated value of distance in whole metres.</para>
    ///   <a href="http://vocab.datex.org/terms#IntegerMetreDistanceValue">datex:IntegerMetreDistanceValue</a>
    /// </summary>
    let IntegerMetreDistanceValue = _prefixId.prefix "IntegerMetreDistanceValue"
    /// <summary>
    ///   <para>rdfs:comment : A parking site in an interurban context.</para>
    ///   <a href="http://vocab.datex.org/terms#InterUrbanParkingSite">datex:InterUrbanParkingSite</a>
    /// </summary>
    let InterUrbanParkingSite = _prefixId.prefix "InterUrbanParkingSite"
    let IntermittentShortTermClosures = _prefixId.prefix "IntermittentShortTermClosures"
    /// <summary>
    ///   <para>rdfs:comment : An identifier/name whose range is specific to the particular country.</para>
    ///   <a href="http://vocab.datex.org/terms#InternationalIdentifier">datex:InternationalIdentifier</a>
    /// </summary>
    let InternationalIdentifier = _prefixId.prefix "InternationalIdentifier"
    let InternationalSportsMeeting = _prefixId.prefix "InternationalSportsMeeting"
    /// <summary>
    ///   <para>rdfs:comment : Multiple (i.e. more than one) physically separate locations arranged as an ordered set that defines an itinerary or route.</para>
    ///   <a href="http://vocab.datex.org/terms#Itinerary">datex:Itinerary</a>
    /// </summary>
    let Itinerary = _prefixId.prefix "Itinerary"
    /// <summary>
    ///   <para>rdfs:comment : Multiple physically separate locations arranged as an ordered set that defines an itinerary or route. The index qualifier indicates the order.</para>
    ///   <a href="http://vocab.datex.org/terms#ItineraryByIndexedLocations">datex:ItineraryByIndexedLocations</a>
    /// </summary>
    let ItineraryByIndexedLocations = _prefixId.prefix "ItineraryByIndexedLocations"
    /// <summary>
    ///   <para>rdfs:comment : Multiple (i.e. more than one) physically separate locations which are ordered that constitute an itinerary or route where they are defined by reference to a predefined itinerary.</para>
    ///   <a href="http://vocab.datex.org/terms#ItineraryByReference">datex:ItineraryByReference</a>
    /// </summary>
    let ItineraryByReference = _prefixId.prefix "ItineraryByReference"
    let JackknifedArticulatedLorry = _prefixId.prefix "JackknifedArticulatedLorry"
    let JackknifedCaravan = _prefixId.prefix "JackknifedCaravan"
    let JackknifedTrailer = _prefixId.prefix "JackknifedTrailer"
    /// <summary>
    ///   <para>rdfs:comment : Junction (on a highway), can also be an interchange or if applicable also a motorway service station (see junctionClassification).</para>
    ///   <a href="http://vocab.datex.org/terms#Junction">datex:Junction</a>
    /// </summary>
    let Junction = _prefixId.prefix "Junction"
    let JuridicalReconstruction = _prefixId.prefix "JuridicalReconstruction"
    /// <summary>
    ///   <para>rdfs:comment : A measured or calculated value of concentration of a substance in grams per unit volume.</para>
    ///   <a href="http://vocab.datex.org/terms#KilogramsConcentrationValue">datex:KilogramsConcentrationValue</a>
    /// </summary>
    let KilogramsConcentrationValue = _prefixId.prefix "KilogramsConcentrationValue"
    let Landslips = _prefixId.prefix "Landslips"
    let LaneClosure = _prefixId.prefix "LaneClosure"
    let LaneControlSignFailure = _prefixId.prefix "LaneControlSignFailure"
    let LaneControlSignFault = _prefixId.prefix "LaneControlSignFault"
    let LanesDeviated = _prefixId.prefix "LanesDeviated"

    let LargeAnimalsOnTheInfrastructure = _prefixId.prefix "LargeAnimalsOnTheInfrastructure"

    let LeavesOnInfrastructure = _prefixId.prefix "LeavesOnInfrastructure"
    /// <summary>
    ///   <para>rdfs:comment : Length characteristic of a vehicle.</para>
    ///   <a href="http://vocab.datex.org/terms#LengthCharacteristic">datex:LengthCharacteristic</a>
    /// </summary>
    let LengthCharacteristic = _prefixId.prefix "LengthCharacteristic"
    let LevelCrossingFailure = _prefixId.prefix "LevelCrossingFailure"
    let LevelCrossingFault = _prefixId.prefix "LevelCrossingFault"
    /// <summary>
    ///   <para>rdfs:comment : Information relating to the life cycle management of the situation record.</para>
    ///   <a href="http://vocab.datex.org/terms#LifeCycleManagement">datex:LifeCycleManagement</a>
    /// </summary>
    let LifeCycleManagement = _prefixId.prefix "LifeCycleManagement"
    /// <summary>
    ///   <para>rdfs:comment : A linear section along a single road with optional directionality defined between two points on the same road. </para>
    ///   <a href="http://vocab.datex.org/terms#Linear">datex:Linear</a>
    /// </summary>
    let Linear = _prefixId.prefix "Linear"
    /// <summary>
    ///   <para>rdfs:comment : A linear element along a single linear object, consistent with ISO 19148 definitions. </para>
    ///   <a href="http://vocab.datex.org/terms#LinearElement">datex:LinearElement</a>
    /// </summary>
    let LinearElement = _prefixId.prefix "LinearElement"
    /// <summary>
    ///   <para>rdfs:comment : A linear element along a single linear object defined by its identifier or code in a road network reference model (specified in LinearElement class) which segments the road network according to specific business rules.</para>
    ///   <a href="http://vocab.datex.org/terms#LinearElementByCode">datex:LinearElementByCode</a>
    /// </summary>
    let LinearElementByCode = _prefixId.prefix "LinearElementByCode"
    /// <summary>
    ///   <para>rdfs:comment : A linear element along a single linear object defined by its start and end points.</para>
    ///   <a href="http://vocab.datex.org/terms#LinearElementByPoints">datex:LinearElementByPoints</a>
    /// </summary>
    let LinearElementByPoints = _prefixId.prefix "LinearElementByPoints"
    /// <summary>
    ///   <para>rdfs:comment : An identifiable instance of a linear traffic view at a single point in time relating to a linear section of road, comprising one or more traffic view records.</para>
    ///   <a href="http://vocab.datex.org/terms#LinearTrafficView">datex:LinearTrafficView</a>
    /// </summary>
    let LinearTrafficView = _prefixId.prefix "LinearTrafficView"
    /// <summary>
    ///   <para>rdfs:comment : A linear section along a linear element where the linear element is either a part of or the whole of a linear object (i.e. a road), consistent with ISO 19148 definitions. </para>
    ///   <a href="http://vocab.datex.org/terms#LinearWithinLinearElement">datex:LinearWithinLinearElement</a>
    /// </summary>
    let LinearWithinLinearElement = _prefixId.prefix "LinearWithinLinearElement"
    let LitterClearance = _prefixId.prefix "LitterClearance"
    /// <summary>
    ///   <para>rdfs:comment : The specification of a location either on a network (as a point or a linear location) or as an area. This may be provided in one or more referencing systems.</para>
    ///   <a href="http://vocab.datex.org/terms#Location">datex:Location</a>
    /// </summary>
    let Location = _prefixId.prefix "Location"
    /// <summary>
    ///   <para>rdfs:comment : A location defined by reference to a predefined location.</para>
    ///   <a href="http://vocab.datex.org/terms#LocationByReference">datex:LocationByReference</a>
    /// </summary>
    let LocationByReference = _prefixId.prefix "LocationByReference"

    /// <summary>
    ///   <para>rdfs:comment : Location characteristics which override values set in the referenced measurement point.</para>
    ///   <a href="http://vocab.datex.org/terms#LocationCharacteristicsOverride">datex:LocationCharacteristicsOverride</a>
    /// </summary>
    let LocationCharacteristicsOverride = _prefixId.prefix "LocationCharacteristicsOverride"

    let LongLoad = _prefixId.prefix "LongLoad"
    let LooseChippings = _prefixId.prefix "LooseChippings"
    let LooseSandOnInfrastructure = _prefixId.prefix "LooseSandOnInfrastructure"
    let LooseSnow = _prefixId.prefix "LooseSnow"
    let LowSunGlare = _prefixId.prefix "LowSunGlare"
    /// <summary>
    ///   <para>rdfs:comment : Details of the maintenance vehicles involved in the roadworks activity.</para>
    ///   <a href="http://vocab.datex.org/terms#MaintenanceVehicles">datex:MaintenanceVehicles</a>
    /// </summary>
    let MaintenanceVehicles = _prefixId.prefix "MaintenanceVehicles"
    let MaintenanceWork = _prefixId.prefix "MaintenanceWork"
    /// <summary>
    ///   <para>rdfs:comment : Roadworks involving the maintenance or installation of infrastructure.</para>
    ///   <a href="http://vocab.datex.org/terms#MaintenanceWorks">datex:MaintenanceWorks</a>
    /// </summary>
    let MaintenanceWorks = _prefixId.prefix "MaintenanceWorks"
    let MajorEvent = _prefixId.prefix "MajorEvent"
    /// <summary>
    ///   <para>rdfs:comment : A cause of this situation record which is managed by the publication creator, i.e. one which is represented by another situation record produced by the same publication creator.</para>
    ///   <a href="http://vocab.datex.org/terms#ManagedCause">datex:ManagedCause</a>
    /// </summary>
    let ManagedCause = _prefixId.prefix "ManagedCause"
    /// <summary>
    ///   <para>rdfs:comment : Information relating to the management of the situation record.</para>
    ///   <a href="http://vocab.datex.org/terms#Management">datex:Management</a>
    /// </summary>
    let Management = _prefixId.prefix "Management"
    let Marathon = _prefixId.prefix "Marathon"
    let March = _prefixId.prefix "March"
    let Market = _prefixId.prefix "Market"
    let Match = _prefixId.prefix "Match"
    let MatrixSignFailure = _prefixId.prefix "MatrixSignFailure"
    let MatrixSignFault = _prefixId.prefix "MatrixSignFault"
    /// <summary>
    ///   <para>rdfs:comment : A publication containing one or more measurement data sets, each set being measured at a single measurement site.</para>
    ///   <a href="http://vocab.datex.org/terms#MeasuredDataPublication">datex:MeasuredDataPublication</a>
    /// </summary>
    let MeasuredDataPublication = _prefixId.prefix "MeasuredDataPublication"
    /// <summary>
    ///   <para>rdfs:comment : Contains optional characteristics for the specific measured value (indexed to correspond with the defined characteristics of the measurement at the referenced measurement site) which override the static characteristics defined in the MeasurementSiteTable.</para>
    ///   <a href="http://vocab.datex.org/terms#MeasuredValue">datex:MeasuredValue</a>
    /// </summary>
    let MeasuredValue = _prefixId.prefix "MeasuredValue"
    /// <summary>
    ///   <para>rdfs:comment : Details of a fault which is being reported for the related measurement equipment.</para>
    ///   <a href="http://vocab.datex.org/terms#MeasurementEquipmentFault">datex:MeasurementEquipmentFault</a>
    /// </summary>
    let MeasurementEquipmentFault = _prefixId.prefix "MeasurementEquipmentFault"
    /// <summary>
    ///   <para>rdfs:comment : An identifiable single measurement site entry/record in the Measurement Site table.</para>
    ///   <a href="http://vocab.datex.org/terms#MeasurementSiteRecord">datex:MeasurementSiteRecord</a>
    /// </summary>
    let MeasurementSiteRecord = _prefixId.prefix "MeasurementSiteRecord"
    /// <summary>
    ///   <para>rdfs:comment : A Measurement Site Table comprising a number of sets of data, each describing the location from where a stream of measured data may be derived.  Each location is known as a "measurement site" which can be a point, a linear road section or an area.</para>
    ///   <a href="http://vocab.datex.org/terms#MeasurementSiteTable">datex:MeasurementSiteTable</a>
    /// </summary>
    let MeasurementSiteTable = _prefixId.prefix "MeasurementSiteTable"

    /// <summary>
    ///   <para>rdfs:comment : A publication containing one or more Measurment Site Tables.</para>
    ///   <a href="http://vocab.datex.org/terms#MeasurementSiteTablePublication">datex:MeasurementSiteTablePublication</a>
    /// </summary>
    let MeasurementSiteTablePublication = _prefixId.prefix "MeasurementSiteTablePublication"

    /// <summary>
    ///   <para>rdfs:comment : Characteristics which are specific to an individual measurement type (specified in a known order) at the given measurement site.</para>
    ///   <a href="http://vocab.datex.org/terms#MeasurementSpecificCharacteristics">datex:MeasurementSpecificCharacteristics</a>
    /// </summary>
    let MeasurementSpecificCharacteristics = _prefixId.prefix "MeasurementSpecificCharacteristics"

    /// <summary>
    ///   <para>rdfs:comment : A measured or calculated value of concentration of a substance in micrograms per unit volume.</para>
    ///   <a href="http://vocab.datex.org/terms#MicrogramsConcentrationValue">datex:MicrogramsConcentrationValue</a>
    /// </summary>
    let MicrogramsConcentrationValue = _prefixId.prefix "MicrogramsConcentrationValue"
    let MilitaryConvoy = _prefixId.prefix "MilitaryConvoy"
    /// <summary>
    ///   <para>rdfs:comment : An indication of whether the associated instance of a SituationRecord is mobile (e.g. a march or parade moving along a road) or stationary.</para>
    ///   <a href="http://vocab.datex.org/terms#Mobility">datex:Mobility</a>
    /// </summary>
    let Mobility = _prefixId.prefix "Mobility"
    let ModerateFog = _prefixId.prefix "ModerateFog"
    let MotorShow = _prefixId.prefix "MotorShow"
    let MotorSportRaceMeeting = _prefixId.prefix "MotorSportRaceMeeting"
    let MudOnInfrastructure = _prefixId.prefix "MudOnInfrastructure"
    let MudSlide = _prefixId.prefix "MudSlide"
    let MultilingualString = _prefixId.prefix "MultilingualString"
    let MultilingualStringValue = _prefixId.prefix "MultilingualStringValue"
    let MultipleVehicleCollision = _prefixId.prefix "MultipleVehicleCollision"
    let MultivehicleAccident = _prefixId.prefix "MultivehicleAccident"
    /// <summary>
    ///   <para>rdfs:comment : An area defined by a name and/or in terms of known boundaries, such as country or county boundaries or allocated control area of particular authority. The attributes do not form a union; instead, the smallest intersection forms the resulting area.</para>
    ///   <a href="http://vocab.datex.org/terms#NamedArea">datex:NamedArea</a>
    /// </summary>
    let NamedArea = _prefixId.prefix "NamedArea"
    let NarrowLanes = _prefixId.prefix "NarrowLanes"
    /// <summary>
    ///   <para>rdfs:comment : The specification of a location on a network (as a point or a linear location).</para>
    ///   <a href="http://vocab.datex.org/terms#NetworkLocation">datex:NetworkLocation</a>
    /// </summary>
    let NetworkLocation = _prefixId.prefix "NetworkLocation"
    /// <summary>
    ///   <para>rdfs:comment : Network management action which is applicable to the road network and its users.</para>
    ///   <a href="http://vocab.datex.org/terms#NetworkManagement">datex:NetworkManagement</a>
    /// </summary>
    let NetworkManagement = _prefixId.prefix "NetworkManagement"
    let NewRoadworksLayout = _prefixId.prefix "NewRoadworksLayout"
    /// <summary>
    ///   <para>rdfs:comment : A cause of this situation record which is not managed by the publication creator, i.e. one which is not represented by another situation record produced by the same publication creator.</para>
    ///   <a href="http://vocab.datex.org/terms#NonManagedCause">datex:NonManagedCause</a>
    /// </summary>
    let NonManagedCause = _prefixId.prefix "NonManagedCause"
    /// <summary>
    ///   <para>rdfs:comment : A group of (i.e. more than one) physically separate locations which have no specific order and where each location is explicitly listed.</para>
    ///   <a href="http://vocab.datex.org/terms#NonOrderedLocationGroupByList">datex:NonOrderedLocationGroupByList</a>
    /// </summary>
    let NonOrderedLocationGroupByList = _prefixId.prefix "NonOrderedLocationGroupByList"

    /// <summary>
    ///   <para>rdfs:comment : A group of (i.e. more than one) physically separate locations which have no specific order that are defined by reference to a predefined non ordered location group.</para>
    ///   <a href="http://vocab.datex.org/terms#NonOrderedLocationGroupByReference">datex:NonOrderedLocationGroupByReference</a>
    /// </summary>
    let NonOrderedLocationGroupByReference = _prefixId.prefix "NonOrderedLocationGroupByReference"

    /// <summary>
    ///   <para>rdfs:comment : Multiple (i.e. more than one) physically separate locations which have no specific order.</para>
    ///   <a href="http://vocab.datex.org/terms#NonOrderedLocations">datex:NonOrderedLocations</a>
    /// </summary>
    let NonOrderedLocations = _prefixId.prefix "NonOrderedLocations"
    /// <summary>
    ///   <para>rdfs:comment : Information about an event which is not on the road, but which may influence the behaviour of drivers and hence the characteristics of the traffic flow.</para>
    ///   <a href="http://vocab.datex.org/terms#NonRoadEventInformation">datex:NonRoadEventInformation</a>
    /// </summary>
    let NonRoadEventInformation = _prefixId.prefix "NonRoadEventInformation"

    /// <summary>
    ///   <para>rdfs:comment : Road surface conditions that are not related to the weather but which may affect driving conditions.</para>
    ///   <a href="http://vocab.datex.org/terms#NonWeatherRelatedRoadConditions">datex:NonWeatherRelatedRoadConditions</a>
    /// </summary>
    let NonWeatherRelatedRoadConditions = _prefixId.prefix "NonWeatherRelatedRoadConditions"

    let Normal = _prefixId.prefix "Normal"

    let NormalWinterConditionsForPedestrians = _prefixId.prefix "NormalWinterConditionsForPedestrians"

    /// <summary>
    ///   <para>rdfs:comment : Number of axles characteristic of a vehicle.</para>
    ///   <a href="http://vocab.datex.org/terms#NumberOfAxlesCharacteristic">datex:NumberOfAxlesCharacteristic</a>
    /// </summary>
    let NumberOfAxlesCharacteristic = _prefixId.prefix "NumberOfAxlesCharacteristic"
    let ObstacleSignalling = _prefixId.prefix "ObstacleSignalling"
    /// <summary>
    ///   <para>rdfs:comment : Any stationary or moving obstacle of a physical nature (e.g. obstacles or vehicles from an earlier accident, shed loads on carriageway, rock fall, abnormal or dangerous loads, or animals etc.) which could disrupt or endanger traffic.</para>
    ///   <a href="http://vocab.datex.org/terms#Obstruction">datex:Obstruction</a>
    /// </summary>
    let Obstruction = _prefixId.prefix "Obstruction"
    /// <summary>
    ///   <para>rdfs:comment : A measured or calculated value of change of occupied parking spaces expressed as integer.</para>
    ///   <a href="http://vocab.datex.org/terms#OccupancyChangeValue">datex:OccupancyChangeValue</a>
    /// </summary>
    let OccupancyChangeValue = _prefixId.prefix "OccupancyChangeValue"
    /// <summary>
    ///   <para>rdfs:comment : The non negative offset distance from the ALERT-C referenced point to the actual point.</para>
    ///   <a href="http://vocab.datex.org/terms#OffsetDistance">datex:OffsetDistance</a>
    /// </summary>
    let OffsetDistance = _prefixId.prefix "OffsetDistance"
    let OilOnInfrastructure = _prefixId.prefix "OilOnInfrastructure"
    let OilSpillageAccident = _prefixId.prefix "OilSpillageAccident"
    let Ontology = _prefixId.prefix "Ontology"
    /// <summary>
    ///   <para>rdfs:comment : A specification of opening times (e.g. for a parking site, a service facility, an access or the availability for equipment).</para>
    ///   <a href="http://vocab.datex.org/terms#OpeningTimes">datex:OpeningTimes</a>
    /// </summary>
    let OpeningTimes = _prefixId.prefix "OpeningTimes"
    /// <summary>
    ///   <para>rdfs:comment : a two-dimensional part of the surface of the earth which is bounded by a closed curve. An area location may cover parts of the road network but does not necessarily need to. It is represente according to the OpenLR standard for Area Locations</para>
    ///   <a href="http://vocab.datex.org/terms#OpenlrAreaLocationReference">datex:OpenlrAreaLocationReference</a>
    /// </summary>
    let OpenlrAreaLocationReference = _prefixId.prefix "OpenlrAreaLocationReference"

    /// <summary>
    ///   <para>rdfs:comment : Base class used to hold data about a reference point.</para>
    ///   <a href="http://vocab.datex.org/terms#OpenlrBaseLocationReferencePoint">datex:OpenlrBaseLocationReferencePoint</a>
    /// </summary>
    let OpenlrBaseLocationReferencePoint = _prefixId.prefix "OpenlrBaseLocationReferencePoint"

    /// <summary>
    ///   <para>rdfs:comment : Holds common data that are used both in OpenlrPointAccessPoint and OpenlrPointAlongLine.</para>
    ///   <a href="http://vocab.datex.org/terms#OpenlrBasePointLocation">datex:OpenlrBasePointLocation</a>
    /// </summary>
    let OpenlrBasePointLocation = _prefixId.prefix "OpenlrBasePointLocation"
    /// <summary>
    ///   <para>rdfs:comment : the openLR method of areadefinition by providing a center position and a radius</para>
    ///   <a href="http://vocab.datex.org/terms#OpenlrCircleLocationReference">datex:OpenlrCircleLocationReference</a>
    /// </summary>
    let OpenlrCircleLocationReference = _prefixId.prefix "OpenlrCircleLocationReference"

    /// <summary>
    ///   <para>rdfs:comment : the openLR method of areadefinition by providing a closed path (i.e. a circuit) in the road network. The boundary always consists of road segments</para>
    ///   <a href="http://vocab.datex.org/terms#OpenlrClosedLineLocationReference">datex:OpenlrClosedLineLocationReference</a>
    /// </summary>
    let OpenlrClosedLineLocationReference = _prefixId.prefix "OpenlrClosedLineLocationReference"

    /// <summary>
    ///   <para>rdfs:comment : Extension to provide Area information in openLR format</para>
    ///   <a href="http://vocab.datex.org/terms#OpenlrExtendedArea">datex:OpenlrExtendedArea</a>
    /// </summary>
    let OpenlrExtendedArea = _prefixId.prefix "OpenlrExtendedArea"
    /// <summary>
    ///   <para>rdfs:comment : Extension class for OpenLR Line location reference</para>
    ///   <a href="http://vocab.datex.org/terms#OpenlrExtendedLinear">datex:OpenlrExtendedLinear</a>
    /// </summary>
    let OpenlrExtendedLinear = _prefixId.prefix "OpenlrExtendedLinear"
    /// <summary>
    ///   <para>rdfs:comment : Extension class for OpenLR point.</para>
    ///   <a href="http://vocab.datex.org/terms#OpenlrExtendedPoint">datex:OpenlrExtendedPoint</a>
    /// </summary>
    let OpenlrExtendedPoint = _prefixId.prefix "OpenlrExtendedPoint"
    /// <summary>
    ///   <para>rdfs:comment : A geo-coordinate pair is a position in a map defined by its longitude and latitude coordinate values.</para>
    ///   <a href="http://vocab.datex.org/terms#OpenlrGeoCoordinate">datex:OpenlrGeoCoordinate</a>
    /// </summary>
    let OpenlrGeoCoordinate = _prefixId.prefix "OpenlrGeoCoordinate"
    /// <summary>
    ///   <para>rdfs:comment : attributes required for the grid method</para>
    ///   <a href="http://vocab.datex.org/terms#OpenlrGridAttributes">datex:OpenlrGridAttributes</a>
    /// </summary>
    let OpenlrGridAttributes = _prefixId.prefix "OpenlrGridAttributes"
    /// <summary>
    ///   <para>rdfs:comment : the openLR method of areadefinition by providing repeating rectangles</para>
    ///   <a href="http://vocab.datex.org/terms#OpenlrGridLocationReference">datex:OpenlrGridLocationReference</a>
    /// </summary>
    let OpenlrGridLocationReference = _prefixId.prefix "OpenlrGridLocationReference"

    /// <summary>
    ///   <para>rdfs:comment : The sequence of location reference points is terminated by a last location reference point.</para>
    ///   <a href="http://vocab.datex.org/terms#OpenlrLastLocationReferencePoint">datex:OpenlrLastLocationReferencePoint</a>
    /// </summary>
    let OpenlrLastLocationReferencePoint = _prefixId.prefix "OpenlrLastLocationReferencePoint"

    /// <summary>
    ///   <para>rdfs:comment : Line attributes are part of a location reference point and consists of functional road class (FRC),form of way (FOW) and bearing (BEAR) data.</para>
    ///   <a href="http://vocab.datex.org/terms#OpenlrLineAttributes">datex:OpenlrLineAttributes</a>
    /// </summary>
    let OpenlrLineAttributes = _prefixId.prefix "OpenlrLineAttributes"
    /// <summary>
    ///   <para>rdfs:comment : A LineLocationReference is defined by an ordered sequence of location reference points and a terminating last location reference point.</para>
    ///   <a href="http://vocab.datex.org/terms#OpenlrLineLocationReference">datex:OpenlrLineLocationReference</a>
    /// </summary>
    let OpenlrLineLocationReference = _prefixId.prefix "OpenlrLineLocationReference"
    /// <summary>
    ///   <para>rdfs:comment : The basis of a location reference is a sequence of location reference points (LRPs).</para>
    ///   <a href="http://vocab.datex.org/terms#OpenlrLocationReferencePoint">datex:OpenlrLocationReferencePoint</a>
    /// </summary>
    let OpenlrLocationReferencePoint = _prefixId.prefix "OpenlrLocationReferencePoint"
    /// <summary>
    ///   <para>rdfs:comment : Offsets are used to locate the start and end of a location more precisely than bounding to the nodes in a network.</para>
    ///   <a href="http://vocab.datex.org/terms#OpenlrOffsets">datex:OpenlrOffsets</a>
    /// </summary>
    let OpenlrOffsets = _prefixId.prefix "OpenlrOffsets"
    /// <summary>
    ///   <para>rdfs:comment : The field path attributes is part of a location reference point (except for the last location reference point) and consists of lowest functional road class (LFRCNP) and distance to next point (DNP) data.</para>
    ///   <a href="http://vocab.datex.org/terms#OpenlrPathAttributes">datex:OpenlrPathAttributes</a>
    /// </summary>
    let OpenlrPathAttributes = _prefixId.prefix "OpenlrPathAttributes"
    /// <summary>
    ///   <para>rdfs:comment : Point along line with access is a point location which is defined by a line,an offset value and a coordinate.</para>
    ///   <a href="http://vocab.datex.org/terms#OpenlrPoiWithAccessPoint">datex:OpenlrPoiWithAccessPoint</a>
    /// </summary>
    let OpenlrPoiWithAccessPoint = _prefixId.prefix "OpenlrPoiWithAccessPoint"
    /// <summary>
    ///   <para>rdfs:comment : Point along a line</para>
    ///   <a href="http://vocab.datex.org/terms#OpenlrPointAlongLine">datex:OpenlrPointAlongLine</a>
    /// </summary>
    let OpenlrPointAlongLine = _prefixId.prefix "OpenlrPointAlongLine"
    /// <summary>
    ///   <para>rdfs:comment : A point location is a zero-dimensional element in a map that specifies a geometric location.</para>
    ///   <a href="http://vocab.datex.org/terms#OpenlrPointLocationReference">datex:OpenlrPointLocationReference</a>
    /// </summary>
    let OpenlrPointLocationReference = _prefixId.prefix "OpenlrPointLocationReference"
    /// <summary>
    ///   <para>rdfs:comment : geo-coordinate pairs. The coordinate pairs defining the corners of the underlying geometrical polygon.</para>
    ///   <a href="http://vocab.datex.org/terms#OpenlrPolygonCorners">datex:OpenlrPolygonCorners</a>
    /// </summary>
    let OpenlrPolygonCorners = _prefixId.prefix "OpenlrPolygonCorners"

    /// <summary>
    ///   <para>rdfs:comment : the openLR method of areadefinition by providing points that bound the area</para>
    ///   <a href="http://vocab.datex.org/terms#OpenlrPolygonLocationReference">datex:OpenlrPolygonLocationReference</a>
    /// </summary>
    let OpenlrPolygonLocationReference = _prefixId.prefix "OpenlrPolygonLocationReference"

    /// <summary>
    ///   <para>rdfs:comment : two geo-coordinate pairs defining the rectangular</para>
    ///   <a href="http://vocab.datex.org/terms#OpenlrRectangle">datex:OpenlrRectangle</a>
    /// </summary>
    let OpenlrRectangle = _prefixId.prefix "OpenlrRectangle"

    /// <summary>
    ///   <para>rdfs:comment : the openLR method of areadefinition by providing a rectangular shape defined by two geo-coordinate pairs</para>
    ///   <a href="http://vocab.datex.org/terms#OpenlrRectangleLocationReference">datex:OpenlrRectangleLocationReference</a>
    /// </summary>
    let OpenlrRectangleLocationReference = _prefixId.prefix "OpenlrRectangleLocationReference"

    /// <summary>
    ///   <para>rdfs:comment : Actions that a traffic operator can decide to implement to prevent or help correct dangerous or poor driving conditions, including maintenance of the road infrastructure.</para>
    ///   <a href="http://vocab.datex.org/terms#OperatorAction">datex:OperatorAction</a>
    /// </summary>
    let OperatorAction = _prefixId.prefix "OperatorAction"
    /// <summary>
    ///   <para>rdfs:comment : A continuous or discontinuous period of validity defined by overall bounding start and end times and the possible intersection of valid periods (potentially recurring) with the complement of exception periods (also potentially recurring).</para>
    ///   <a href="http://vocab.datex.org/terms#OverallPeriod">datex:OverallPeriod</a>
    /// </summary>
    let OverallPeriod = _prefixId.prefix "OverallPeriod"
    let OverheadWorks = _prefixId.prefix "OverheadWorks"
    let OverheightVehicle = _prefixId.prefix "OverheightVehicle"
    let OvernightClosures = _prefixId.prefix "OvernightClosures"
    let OverturnedHeavyLorry = _prefixId.prefix "OverturnedHeavyLorry"
    let OverturnedTrailer = _prefixId.prefix "OverturnedTrailer"
    let OverturnedVehicle = _prefixId.prefix "OverturnedVehicle"
    let OzonePollution = _prefixId.prefix "OzonePollution"
    let PackedSnow = _prefixId.prefix "PackedSnow"
    let Parade = _prefixId.prefix "Parade"
    /// <summary>
    ///   <para>rdfs:comment : Describes one entrance or exit (or both) to a parking site.</para>
    ///   <a href="http://vocab.datex.org/terms#ParkingAccess">datex:ParkingAccess</a>
    /// </summary>
    let ParkingAccess = _prefixId.prefix "ParkingAccess"
    /// <summary>
    ///   <para>rdfs:comment : The opening and fault status of one access.</para>
    ///   <a href="http://vocab.datex.org/terms#ParkingAccessStatus">datex:ParkingAccessStatus</a>
    /// </summary>
    let ParkingAccessStatus = _prefixId.prefix "ParkingAccessStatus"
    /// <summary>
    ///   <para>rdfs:comment : One set of prohibited/only allowed/convenient assignment for parking space(s), parking site(s) or an access. Same kind of data forms a union (e.g. lorries OR buses), different kind of data forms an intersection (e.g. residents AND long-term).</para>
    ///   <a href="http://vocab.datex.org/terms#ParkingAssignment">datex:ParkingAssignment</a>
    /// </summary>
    let ParkingAssignment = _prefixId.prefix "ParkingAssignment"

    /// <summary>
    ///   <para>rdfs:comment : One type of equipment or additional service facility that is available at the parking site, parking space or group of parking spaces.</para>
    ///   <a href="http://vocab.datex.org/terms#ParkingEquipmentOrServiceFacility">datex:ParkingEquipmentOrServiceFacility</a>
    /// </summary>
    let ParkingEquipmentOrServiceFacility = _prefixId.prefix "ParkingEquipmentOrServiceFacility"

    /// <summary>
    ///   <para>rdfs:comment : The number of E&amp;S can be overridden here (for example during restoration). Furthermore, the current availability of E&amp;S can be given (for example number of free electric charging stations). The E&amp;S are identified from the static model by an index.</para>
    ///   <a href="http://vocab.datex.org/terms#ParkingEquipmentOrServiceFacilityStatus">datex:ParkingEquipmentOrServiceFacilityStatus</a>
    /// </summary>
    let ParkingEquipmentOrServiceFacilityStatus = _prefixId.prefix "ParkingEquipmentOrServiceFacilityStatus"

    /// <summary>
    ///   <para>rdfs:comment : Parking capacity information for the parking site as well as for AssignedParkingSpaces.</para>
    ///   <a href="http://vocab.datex.org/terms#ParkingOccupancy">datex:ParkingOccupancy</a>
    /// </summary>
    let ParkingOccupancy = _prefixId.prefix "ParkingOccupancy"
    /// <summary>
    ///   <para>rdfs:comment : A permission for parking.</para>
    ///   <a href="http://vocab.datex.org/terms#ParkingPermit">datex:ParkingPermit</a>
    /// </summary>
    let ParkingPermit = _prefixId.prefix "ParkingPermit"
    /// <summary>
    ///   <para>rdfs:comment : A container for static parking information. Must be specialised as a parking site or as a group of parking sites.</para>
    ///   <a href="http://vocab.datex.org/terms#ParkingRecord">datex:ParkingRecord</a>
    /// </summary>
    let ParkingRecord = _prefixId.prefix "ParkingRecord"
    /// <summary>
    ///   <para>rdfs:comment : Contains the current status of one parking record defined in the static model (i.e. parking site or group of parking sites) or historical or forecasted data for one parking. Only for the second case, 'parkingStatusTime' must be specified.</para>
    ///   <a href="http://vocab.datex.org/terms#ParkingRecordStatus">datex:ParkingRecordStatus</a>
    /// </summary>
    let ParkingRecordStatus = _prefixId.prefix "ParkingRecordStatus"
    /// <summary>
    ///   <para>rdfs:comment : A parking route, defined by ParkingRouteDetails or by a reference.</para>
    ///   <a href="http://vocab.datex.org/terms#ParkingRoute">datex:ParkingRoute</a>
    /// </summary>
    let ParkingRoute = _prefixId.prefix "ParkingRoute"
    /// <summary>
    ///   <para>rdfs:comment : A route defined by a reference to an earlier specified route.</para>
    ///   <a href="http://vocab.datex.org/terms#ParkingRouteByReference">datex:ParkingRouteByReference</a>
    /// </summary>
    let ParkingRouteByReference = _prefixId.prefix "ParkingRouteByReference"
    /// <summary>
    ///   <para>rdfs:comment : Urban context: Defining parking routes leading to the parking site. Truck parking context: Can be used to define a dynamic route management.</para>
    ///   <a href="http://vocab.datex.org/terms#ParkingRouteDetails">datex:ParkingRouteDetails</a>
    /// </summary>
    let ParkingRouteDetails = _prefixId.prefix "ParkingRouteDetails"
    /// <summary>
    ///   <para>rdfs:comment : The status of a parking route (active/inactive) defined in the static part of the model.</para>
    ///   <a href="http://vocab.datex.org/terms#ParkingRouteStatus">datex:ParkingRouteStatus</a>
    /// </summary>
    let ParkingRouteStatus = _prefixId.prefix "ParkingRouteStatus"
    /// <summary>
    ///   <para>rdfs:comment : A record containing static details of a parking site. Must be specialised as an 'Urban-' or 'InterUrbanParkingSite' or a 'SpecialLocationParkingSite'.</para>
    ///   <a href="http://vocab.datex.org/terms#ParkingSite">datex:ParkingSite</a>
    /// </summary>
    let ParkingSite = _prefixId.prefix "ParkingSite"
    /// <summary>
    ///   <para>rdfs:comment : Dynamic status information for the static object 'ParkingSite'.</para>
    ///   <a href="http://vocab.datex.org/terms#ParkingSiteStatus">datex:ParkingSiteStatus</a>
    /// </summary>
    let ParkingSiteStatus = _prefixId.prefix "ParkingSiteStatus"
    /// <summary>
    ///   <para>rdfs:comment : A single parking space. It is possible to define the same parking space more than once with different properties, e.g. when there is a different parking assignment for different times.</para>
    ///   <a href="http://vocab.datex.org/terms#ParkingSpace">datex:ParkingSpace</a>
    /// </summary>
    let ParkingSpace = _prefixId.prefix "ParkingSpace"
    /// <summary>
    ///   <para>rdfs:comment : Common properties of parking spaces and groups of parking spaces.</para>
    ///   <a href="http://vocab.datex.org/terms#ParkingSpaceBasics">datex:ParkingSpaceBasics</a>
    /// </summary>
    let ParkingSpaceBasics = _prefixId.prefix "ParkingSpaceBasics"
    /// <summary>
    ///   <para>rdfs:comment : Status (occupied or closed) for a single parking space which was defined in the static part of the model.</para>
    ///   <a href="http://vocab.datex.org/terms#ParkingSpaceStatus">datex:ParkingSpaceStatus</a>
    /// </summary>
    let ParkingSpaceStatus = _prefixId.prefix "ParkingSpaceStatus"
    /// <summary>
    ///   <para>rdfs:comment : Security measures and standards or standard-like categorization for a parking site.</para>
    ///   <a href="http://vocab.datex.org/terms#ParkingStandardsAndSecurity">datex:ParkingStandardsAndSecurity</a>
    /// </summary>
    let ParkingStandardsAndSecurity = _prefixId.prefix "ParkingStandardsAndSecurity"
    /// <summary>
    ///   <para>rdfs:comment : Defines a pair of 'parkingSiteStatus' and a corresponding colour.</para>
    ///   <a href="http://vocab.datex.org/terms#ParkingStatusColourMapping">datex:ParkingStatusColourMapping</a>
    /// </summary>
    let ParkingStatusColourMapping = _prefixId.prefix "ParkingStatusColourMapping"
    /// <summary>
    ///   <para>rdfs:comment : A publication containing the current status of one or more parking sites and/or group of parking sites.</para>
    ///   <a href="http://vocab.datex.org/terms#ParkingStatusPublication">datex:ParkingStatusPublication</a>
    /// </summary>
    let ParkingStatusPublication = _prefixId.prefix "ParkingStatusPublication"
    /// <summary>
    ///   <para>rdfs:comment : To be used only for historical or forecasted data. Choose between an explicit point of time, an offset or all points of time within a specified period.</para>
    ///   <a href="http://vocab.datex.org/terms#ParkingStatusValidity">datex:ParkingStatusValidity</a>
    /// </summary>
    let ParkingStatusValidity = _prefixId.prefix "ParkingStatusValidity"
    /// <summary>
    ///   <para>rdfs:comment : A collection of parking records, which can be parking sites or groups of parking sites.</para>
    ///   <a href="http://vocab.datex.org/terms#ParkingTable">datex:ParkingTable</a>
    /// </summary>
    let ParkingTable = _prefixId.prefix "ParkingTable"
    /// <summary>
    ///   <para>rdfs:comment : A publication defining one or more tables that have entries of parking sites or groups of them, located in an urban or interurban context.</para>
    ///   <a href="http://vocab.datex.org/terms#ParkingTablePublication">datex:ParkingTablePublication</a>
    /// </summary>
    let ParkingTablePublication = _prefixId.prefix "ParkingTablePublication"
    /// <summary>
    ///   <para>rdfs:comment : Configuration parameters of the parking site, used among others for the dynamic attribute 'parkingStatus'. This component or all elements of it can be overridden in the dynamic model.</para>
    ///   <a href="http://vocab.datex.org/terms#ParkingThresholds">datex:ParkingThresholds</a>
    /// </summary>
    let ParkingThresholds = _prefixId.prefix "ParkingThresholds"
    /// <summary>
    ///   <para>rdfs:comment : A special type of usage available for the parking site or the group of parking spaces. In the 'ParkingStatusPublication', the operation type (in operation or not) can be defined.</para>
    ///   <a href="http://vocab.datex.org/terms#ParkingUsageScenario">datex:ParkingUsageScenario</a>
    /// </summary>
    let ParkingUsageScenario = _prefixId.prefix "ParkingUsageScenario"
    /// <summary>
    ///   <para>rdfs:comment : The current status for this parking usage scenario.</para>
    ///   <a href="http://vocab.datex.org/terms#ParkingUsageScenarioStatus">datex:ParkingUsageScenarioStatus</a>
    /// </summary>
    let ParkingUsageScenarioStatus = _prefixId.prefix "ParkingUsageScenarioStatus"
    /// <summary>
    ///   <para>rdfs:comment : A reference to a record that contains the metadata for a specific VMS unit that may be used to manage the parking site (e.g. to indicate to drivers the current availability of spaces).</para>
    ///   <a href="http://vocab.datex.org/terms#ParkingVMS">datex:ParkingVMS</a>
    /// </summary>
    let ParkingVMS = _prefixId.prefix "ParkingVMS"
    /// <summary>
    ///   <para>rdfs:comment : Information about one individual parking vehicle.</para>
    ///   <a href="http://vocab.datex.org/terms#ParkingVehicle">datex:ParkingVehicle</a>
    /// </summary>
    let ParkingVehicle = _prefixId.prefix "ParkingVehicle"
    /// <summary>
    ///   <para>rdfs:comment : Information about individual parking vehicles.</para>
    ///   <a href="http://vocab.datex.org/terms#ParkingVehiclesPublication">datex:ParkingVehiclesPublication</a>
    /// </summary>
    let ParkingVehiclesPublication = _prefixId.prefix "ParkingVehiclesPublication"
    let PassableWithCare = _prefixId.prefix "PassableWithCare"
    let PassengerAssistance = _prefixId.prefix "PassengerAssistance"
    let PatchyFog = _prefixId.prefix "PatchyFog"
    /// <summary>
    ///   <para>rdfs:comment : A payload publication of traffic related information or associated management information created at a specific point in time that can be exchanged via a DATEX II interface.</para>
    ///   <a href="http://vocab.datex.org/terms#PayloadPublication">datex:PayloadPublication</a>
    /// </summary>
    let PayloadPublication = _prefixId.prefix "PayloadPublication"
    /// <summary>
    ///   <para>rdfs:comment : A measured or calculated value of the flow rate of passenger car units.</para>
    ///   <a href="http://vocab.datex.org/terms#PcuFlowValue">datex:PcuFlowValue</a>
    /// </summary>
    let PcuFlowValue = _prefixId.prefix "PcuFlowValue"

    /// <summary>
    ///   <para>rdfs:comment : Distance of a point along a linear element measured from the start node expressed as a percentage of the whole length of the linear element, where start node is relative to the element definition rather than the direction of traffic flow.</para>
    ///   <a href="http://vocab.datex.org/terms#PercentageDistanceAlongLinearElement">datex:PercentageDistanceAlongLinearElement</a>
    /// </summary>
    let PercentageDistanceAlongLinearElement = _prefixId.prefix "PercentageDistanceAlongLinearElement"

    /// <summary>
    ///   <para>rdfs:comment : A measured or calculated value expressed as a percentage.</para>
    ///   <a href="http://vocab.datex.org/terms#PercentageValue">datex:PercentageValue</a>
    /// </summary>
    let PercentageValue = _prefixId.prefix "PercentageValue"
    /// <summary>
    ///   <para>rdfs:comment : A continuous time period or a set of discontinuous time periods defined by the intersection of a set of criteria all within an overall delimiting interval.</para>
    ///   <a href="http://vocab.datex.org/terms#Period">datex:Period</a>
    /// </summary>
    let Period = _prefixId.prefix "Period"
    /// <summary>
    ///   <para>rdfs:comment : An extension point for Period offering the possibility to describe special days and public holidays.</para>
    ///   <a href="http://vocab.datex.org/terms#PeriodExtended">datex:PeriodExtended</a>
    /// </summary>
    let PeriodExtended = _prefixId.prefix "PeriodExtended"
    /// <summary>
    ///   <para>rdfs:comment : Defines sets of action and regulations to specify permitted and prohibited issues.</para>
    ///   <a href="http://vocab.datex.org/terms#PermitsAndProhibitions">datex:PermitsAndProhibitions</a>
    /// </summary>
    let PermitsAndProhibitions = _prefixId.prefix "PermitsAndProhibitions"
    let PetrolOnInfrastructure = _prefixId.prefix "PetrolOnInfrastructure"
    /// <summary>
    ///   <para>rdfs:comment : Settings specific to a distinct pictogram display area on the VMS (where pictogramIndex indicates which pictogram area it relates to if there is more than one pictogram display area on the VMS).</para>
    ///   <a href="http://vocab.datex.org/terms#PictogramDisplayAreaSettings">datex:PictogramDisplayAreaSettings</a>
    /// </summary>
    let PictogramDisplayAreaSettings = _prefixId.prefix "PictogramDisplayAreaSettings"
    /// <summary>
    ///   <para>rdfs:comment : A single geospatial point.</para>
    ///   <a href="http://vocab.datex.org/terms#Point">datex:Point</a>
    /// </summary>
    let Point = _prefixId.prefix "Point"
    /// <summary>
    ///   <para>rdfs:comment : A point on a linear element where the linear element is either a part of or the whole of a linear object (i.e. a road), consistent with ISO 19148 definitions. </para>
    ///   <a href="http://vocab.datex.org/terms#PointAlongLinearElement">datex:PointAlongLinearElement</a>
    /// </summary>
    let PointAlongLinearElement = _prefixId.prefix "PointAlongLinearElement"
    /// <summary>
    ///   <para>rdfs:comment : A single point defined only by a coordinate set with an optional bearing direction.</para>
    ///   <a href="http://vocab.datex.org/terms#PointByCoordinates">datex:PointByCoordinates</a>
    /// </summary>
    let PointByCoordinates = _prefixId.prefix "PointByCoordinates"
    /// <summary>
    ///   <para>rdfs:comment : A pair of coordinates defining the geodetic position of a single point using the European Terrestrial Reference System 1989 (ETRS89).</para>
    ///   <a href="http://vocab.datex.org/terms#PointCoordinates">datex:PointCoordinates</a>
    /// </summary>
    let PointCoordinates = _prefixId.prefix "PointCoordinates"
    /// <summary>
    ///   <para>rdfs:comment : The specification of the destination of a defined route or itinerary which is a point.</para>
    ///   <a href="http://vocab.datex.org/terms#PointDestination">datex:PointDestination</a>
    /// </summary>
    let PointDestination = _prefixId.prefix "PointDestination"
    /// <summary>
    ///   <para>rdfs:comment : Extension point for 'Point' to support the description of junctions (and other alternative point descriptions).</para>
    ///   <a href="http://vocab.datex.org/terms#PointExtended">datex:PointExtended</a>
    /// </summary>
    let PointExtended = _prefixId.prefix "PointExtended"
    let PoliceCheckPoint = _prefixId.prefix "PoliceCheckPoint"
    let PoliceInvestigation = _prefixId.prefix "PoliceInvestigation"
    let PoliceSpeedChecksInOperation = _prefixId.prefix "PoliceSpeedChecksInOperation"
    /// <summary>
    ///   <para>rdfs:comment : Details of atmospheric pollution.</para>
    ///   <a href="http://vocab.datex.org/terms#Pollution">datex:Pollution</a>
    /// </summary>
    let Pollution = _prefixId.prefix "Pollution"
    /// <summary>
    ///   <para>rdfs:comment : Measurements of atmospheric pollution.</para>
    ///   <a href="http://vocab.datex.org/terms#PollutionInformation">datex:PollutionInformation</a>
    /// </summary>
    let PollutionInformation = _prefixId.prefix "PollutionInformation"
    /// <summary>
    ///   <para>rdfs:comment : defines points for a closed polygon-shape describing the area</para>
    ///   <a href="http://vocab.datex.org/terms#PolygonArea">datex:PolygonArea</a>
    /// </summary>
    let PolygonArea = _prefixId.prefix "PolygonArea"
    /// <summary>
    ///   <para>rdfs:comment : Any environmental conditions which may be affecting the driving conditions on the road.</para>
    ///   <a href="http://vocab.datex.org/terms#PoorEnvironmentConditions">datex:PoorEnvironmentConditions</a>
    /// </summary>
    let PoorEnvironmentConditions = _prefixId.prefix "PoorEnvironmentConditions"
    /// <summary>
    ///   <para>rdfs:comment : Details of precipitation (rain, snow etc.).</para>
    ///   <a href="http://vocab.datex.org/terms#PrecipitationDetail">datex:PrecipitationDetail</a>
    /// </summary>
    let PrecipitationDetail = _prefixId.prefix "PrecipitationDetail"
    let PrecipitationInTheArea = _prefixId.prefix "PrecipitationInTheArea"
    /// <summary>
    ///   <para>rdfs:comment : Measurements of precipitation.</para>
    ///   <a href="http://vocab.datex.org/terms#PrecipitationInformation">datex:PrecipitationInformation</a>
    /// </summary>
    let PrecipitationInformation = _prefixId.prefix "PrecipitationInformation"
    /// <summary>
    ///   <para>rdfs:comment : A measured or calculated value of the accumulation rate of precipitation.</para>
    ///   <a href="http://vocab.datex.org/terms#PrecipitationIntensityValue">datex:PrecipitationIntensityValue</a>
    /// </summary>
    let PrecipitationIntensityValue = _prefixId.prefix "PrecipitationIntensityValue"
    /// <summary>
    ///   <para>rdfs:comment : An identifiable versioned instance of a predefined itinerary.</para>
    ///   <a href="http://vocab.datex.org/terms#PredefinedItinerary">datex:PredefinedItinerary</a>
    /// </summary>
    let PredefinedItinerary = _prefixId.prefix "PredefinedItinerary"
    /// <summary>
    ///   <para>rdfs:comment : An identifiable versioned instance of a single predefined location.</para>
    ///   <a href="http://vocab.datex.org/terms#PredefinedLocation">datex:PredefinedLocation</a>
    /// </summary>
    let PredefinedLocation = _prefixId.prefix "PredefinedLocation"
    /// <summary>
    ///   <para>rdfs:comment : A container which may comprise the definition of a predefined itinerary, non ordered group of locations or single location.</para>
    ///   <a href="http://vocab.datex.org/terms#PredefinedLocationContainer">datex:PredefinedLocationContainer</a>
    /// </summary>
    let PredefinedLocationContainer = _prefixId.prefix "PredefinedLocationContainer"

    /// <summary>
    ///   <para>rdfs:comment : A publication containing one or more groups of predefined locations organised either as litineraries, non ordered groups or as individual locations.</para>
    ///   <a href="http://vocab.datex.org/terms#PredefinedLocationsPublication">datex:PredefinedLocationsPublication</a>
    /// </summary>
    let PredefinedLocationsPublication = _prefixId.prefix "PredefinedLocationsPublication"

    /// <summary>
    ///   <para>rdfs:comment : An identifiable versioned instance of a predefined group of non ordered locations (i.e. more than one).</para>
    ///   <a href="http://vocab.datex.org/terms#PredefinedNonOrderedLocationGroup">datex:PredefinedNonOrderedLocationGroup</a>
    /// </summary>
    let PredefinedNonOrderedLocationGroup = _prefixId.prefix "PredefinedNonOrderedLocationGroup"

    let Procession = _prefixId.prefix "Procession"
    let ProhibitedVehicleOnTheRoadway = _prefixId.prefix "ProhibitedVehicleOnTheRoadway"
    let PublicDisturbance = _prefixId.prefix "PublicDisturbance"
    /// <summary>
    ///   <para>rdfs:comment : Organised public event which could disrupt traffic.</para>
    ///   <a href="http://vocab.datex.org/terms#PublicEvent">datex:PublicEvent</a>
    /// </summary>
    let PublicEvent = _prefixId.prefix "PublicEvent"
    /// <summary>
    ///   <para>rdfs:comment : Specification of the public holiday type in a specific country or region. Use this component only when specialDayType is set to 'publicHoliday' or 'holidays'.</para>
    ///   <a href="http://vocab.datex.org/terms#PublicHoliday">datex:PublicHoliday</a>
    /// </summary>
    let PublicHoliday = _prefixId.prefix "PublicHoliday"
    let QueuingTraffic = _prefixId.prefix "QueuingTraffic"
    /// <summary>
    ///   <para>rdfs:comment : An RGB colour described by values for red, green and blue (0..255) as well as an optional name.</para>
    ///   <a href="http://vocab.datex.org/terms#RGBColour">datex:RGBColour</a>
    /// </summary>
    let RGBColour = _prefixId.prefix "RGBColour"
    let RaceMeeting = _prefixId.prefix "RaceMeeting"
    let RadioactiveLeakAlert = _prefixId.prefix "RadioactiveLeakAlert"
    let Rain = _prefixId.prefix "Rain"
    let RainChangingToSnow = _prefixId.prefix "RainChangingToSnow"
    let RampControlFailure = _prefixId.prefix "RampControlFailure"
    let RampControlFault = _prefixId.prefix "RampControlFault"
    let RampMeteringInOperation = _prefixId.prefix "RampMeteringInOperation"
    let RearCollision = _prefixId.prefix "RearCollision"
    let Reference = _prefixId.prefix "Reference"
    /// <summary>
    ///   <para>rdfs:comment : Specification of the default value for traffic status on a group of predefined locations on the road network. Only when traffic status differs from this value at a location in the group need a value be sent.</para>
    ///   <a href="http://vocab.datex.org/terms#ReferenceSettings">datex:ReferenceSettings</a>
    /// </summary>
    let ReferenceSettings = _prefixId.prefix "ReferenceSettings"
    /// <summary>
    ///   <para>rdfs:comment : A referent on a linear object that has a known location such as a node, a reference marker (e.g. a markerpost), an intersection etc.</para>
    ///   <a href="http://vocab.datex.org/terms#Referent">datex:Referent</a>
    /// </summary>
    let Referent = _prefixId.prefix "Referent"
    let RepairWork = _prefixId.prefix "RepairWork"
    /// <summary>
    ///   <para>rdfs:comment : Rerouting management action that is issued by the network/road operator.</para>
    ///   <a href="http://vocab.datex.org/terms#ReroutingManagement">datex:ReroutingManagement</a>
    /// </summary>
    let ReroutingManagement = _prefixId.prefix "ReroutingManagement"
    let ResurfacingWork = _prefixId.prefix "ResurfacingWork"
    let Riot = _prefixId.prefix "Riot"
    /// <summary>
    ///   <para>rdfs:comment : Identification of a road by its name, identifier, type ...</para>
    ///   <a href="http://vocab.datex.org/terms#Road">datex:Road</a>
    /// </summary>
    let Road = _prefixId.prefix "Road"
    let RoadCleared = _prefixId.prefix "RoadCleared"
    let RoadClosure = _prefixId.prefix "RoadClosure"
    /// <summary>
    ///   <para>rdfs:comment : Conditions of the road surface which may affect driving conditions. These may be related to the weather (e.g. ice, snow etc.) or to other conditions (e.g. oil, mud, leaves etc. on the road)</para>
    ///   <a href="http://vocab.datex.org/terms#RoadConditions">datex:RoadConditions</a>
    /// </summary>
    let RoadConditions = _prefixId.prefix "RoadConditions"
    let RoadMarkingWork = _prefixId.prefix "RoadMarkingWork"
    /// <summary>
    ///   <para>rdfs:comment : A road node as part of the specialised road identified by the name of a junctionon on this road.</para>
    ///   <a href="http://vocab.datex.org/terms#RoadNode">datex:RoadNode</a>
    /// </summary>
    let RoadNode = _prefixId.prefix "RoadNode"
    let RoadOperatorCheckPoint = _prefixId.prefix "RoadOperatorCheckPoint"
    /// <summary>
    ///   <para>rdfs:comment : Details of disruption to normal road operator services</para>
    ///   <a href="http://vocab.datex.org/terms#RoadOperatorServiceDisruption">datex:RoadOperatorServiceDisruption</a>
    /// </summary>
    let RoadOperatorServiceDisruption = _prefixId.prefix "RoadOperatorServiceDisruption"

    /// <summary>
    ///   <para>rdfs:comment : Road, carriageway or lane management action that is instigated by the network/road operator.</para>
    ///   <a href="http://vocab.datex.org/terms#RoadOrCarriagewayOrLaneManagement">datex:RoadOrCarriagewayOrLaneManagement</a>
    /// </summary>
    let RoadOrCarriagewayOrLaneManagement = _prefixId.prefix "RoadOrCarriagewayOrLaneManagement"

    /// <summary>
    ///   <para>rdfs:comment : Measurements of road surface conditions which are related to the weather.</para>
    ///   <a href="http://vocab.datex.org/terms#RoadSurfaceConditionInformation">datex:RoadSurfaceConditionInformation</a>
    /// </summary>
    let RoadSurfaceConditionInformation = _prefixId.prefix "RoadSurfaceConditionInformation"

    /// <summary>
    ///   <para>rdfs:comment : Measurements of the road surface condition which relate specifically to the weather.</para>
    ///   <a href="http://vocab.datex.org/terms#RoadSurfaceConditionMeasurements">datex:RoadSurfaceConditionMeasurements</a>
    /// </summary>
    let RoadSurfaceConditionMeasurements = _prefixId.prefix "RoadSurfaceConditionMeasurements"

    let RoadSurfaceMelting = _prefixId.prefix "RoadSurfaceMelting"
    let RoadWideningWork = _prefixId.prefix "RoadWideningWork"
    /// <summary>
    ///   <para>rdfs:comment : Details of road side assistance required or being given.</para>
    ///   <a href="http://vocab.datex.org/terms#RoadsideAssistance">datex:RoadsideAssistance</a>
    /// </summary>
    let RoadsideAssistance = _prefixId.prefix "RoadsideAssistance"
    /// <summary>
    ///   <para>rdfs:comment : Details of disruption to normal roadside services (e.g. specific services at a service area).</para>
    ///   <a href="http://vocab.datex.org/terms#RoadsideServiceDisruption">datex:RoadsideServiceDisruption</a>
    /// </summary>
    let RoadsideServiceDisruption = _prefixId.prefix "RoadsideServiceDisruption"
    /// <summary>
    ///   <para>rdfs:comment : Highway maintenance, installation and construction activities that may potentially affect traffic operations.</para>
    ///   <a href="http://vocab.datex.org/terms#Roadworks">datex:Roadworks</a>
    /// </summary>
    let Roadworks = _prefixId.prefix "Roadworks"

    let RockFallPreventativeMaintenance = _prefixId.prefix "RockFallPreventativeMaintenance"

    let Rockfalls = _prefixId.prefix "Rockfalls"
    let RollingRoadBlock = _prefixId.prefix "RollingRoadBlock"
    let RugbyMatch = _prefixId.prefix "RugbyMatch"
    let RushHourLaneInOperation = _prefixId.prefix "RushHourLaneInOperation"
    let Sabotage = _prefixId.prefix "Sabotage"
    let SaltingInProgress = _prefixId.prefix "SaltingInProgress"
    let SaltingOrGrittingVehicleInUse = _prefixId.prefix "SaltingOrGrittingVehicleInUse"
    let SandStorms = _prefixId.prefix "SandStorms"
    let SecurityAlert = _prefixId.prefix "SecurityAlert"
    let SecurityIncident = _prefixId.prefix "SecurityIncident"
    let SeriousAccident = _prefixId.prefix "SeriousAccident"
    let SeriousFire = _prefixId.prefix "SeriousFire"
    /// <summary>
    ///   <para>rdfs:comment : One type of service facility that is available on the parking site or located next to it. You can specify the number of this service facility type (e.g. 5 restaurants) as well as the number of subitems (e.g. 200 restaurant places).</para>
    ///   <a href="http://vocab.datex.org/terms#ServiceFacility">datex:ServiceFacility</a>
    /// </summary>
    let ServiceFacility = _prefixId.prefix "ServiceFacility"
    let SeveralMajorEvents = _prefixId.prefix "SeveralMajorEvents"
    let SevereExhaustPollution = _prefixId.prefix "SevereExhaustPollution"
    let SevereSmog = _prefixId.prefix "SevereSmog"
    let SewerOverflow = _prefixId.prefix "SewerOverflow"
    let Show = _prefixId.prefix "Show"
    let ShowJumping = _prefixId.prefix "ShowJumping"
    let Showers = _prefixId.prefix "Showers"
    let SideCollision = _prefixId.prefix "SideCollision"
    let SightseersObstructingAccess = _prefixId.prefix "SightseersObstructingAccess"
    /// <summary>
    ///   <para>rdfs:comment : Provides information on message signs and the information currently displayed.</para>
    ///   <a href="http://vocab.datex.org/terms#SignSetting">datex:SignSetting</a>
    /// </summary>
    let SignSetting = _prefixId.prefix "SignSetting"
    let SingleAlternateLineTraffic = _prefixId.prefix "SingleAlternateLineTraffic"
    /// <summary>
    ///   <para>rdfs:comment : A  measurement data set derived from a specific measurement site.</para>
    ///   <a href="http://vocab.datex.org/terms#SiteMeasurements">datex:SiteMeasurements</a>
    /// </summary>
    let SiteMeasurements = _prefixId.prefix "SiteMeasurements"
    /// <summary>
    ///   <para>rdfs:comment : An identifiable instance of a traffic/travel situation comprising one or more traffic/travel circumstances which are linked by one or more causal relationships. Each traffic/travel circumstance is represented by a Situation Record.</para>
    ///   <a href="http://vocab.datex.org/terms#Situation">datex:Situation</a>
    /// </summary>
    let Situation = _prefixId.prefix "Situation"
    /// <summary>
    ///   <para>rdfs:comment : A publication containing zero or more traffic/travel situations.</para>
    ///   <a href="http://vocab.datex.org/terms#SituationPublication">datex:SituationPublication</a>
    /// </summary>
    let SituationPublication = _prefixId.prefix "SituationPublication"
    /// <summary>
    ///   <para>rdfs:comment : An identifiable versioned instance of a single record/element within a situation.</para>
    ///   <a href="http://vocab.datex.org/terms#SituationRecord">datex:SituationRecord</a>
    /// </summary>
    let SituationRecord = _prefixId.prefix "SituationRecord"

    /// <summary>
    ///   <para>rdfs:comment : Extension class for SituationRecord.</para>
    ///   <a href="http://vocab.datex.org/terms#SituationRecordExtendedApproved">datex:SituationRecordExtendedApproved</a>
    /// </summary>
    let SituationRecordExtendedApproved = _prefixId.prefix "SituationRecordExtendedApproved"

    let Sleet = _prefixId.prefix "Sleet"
    let SlipperyRoad = _prefixId.prefix "SlipperyRoad"
    let SlowMovingMaintenanceVehicle = _prefixId.prefix "SlowMovingMaintenanceVehicle"
    let SlowTraffic = _prefixId.prefix "SlowTraffic"
    let SlowVehicle = _prefixId.prefix "SlowVehicle"
    let SlushOnRoad = _prefixId.prefix "SlushOnRoad"
    let SlushStrings = _prefixId.prefix "SlushStrings"
    let SmogAlert = _prefixId.prefix "SmogAlert"
    let SmokeHazard = _prefixId.prefix "SmokeHazard"
    let SmokeOrFumes = _prefixId.prefix "SmokeOrFumes"
    let SnowChangingToRain = _prefixId.prefix "SnowChangingToRain"
    let SnowDrifts = _prefixId.prefix "SnowDrifts"
    let SnowOnPavement = _prefixId.prefix "SnowOnPavement"
    let SnowOnTheInfrastructure = _prefixId.prefix "SnowOnTheInfrastructure"
    let Snowfall = _prefixId.prefix "Snowfall"
    let Snowplough = _prefixId.prefix "Snowplough"
    let SnowploughsInUse = _prefixId.prefix "SnowploughsInUse"
    /// <summary>
    ///   <para>rdfs:comment : Details of the source from which the information was obtained.</para>
    ///   <a href="http://vocab.datex.org/terms#Source">datex:Source</a>
    /// </summary>
    let Source = _prefixId.prefix "Source"
    /// <summary>
    ///   <para>rdfs:comment : Specification of a special day, for example schoolDay, electionDay, ...  Gives also the possibility to define a public holiday (country specific).</para>
    ///   <a href="http://vocab.datex.org/terms#SpecialDay">datex:SpecialDay</a>
    /// </summary>
    let SpecialDay = _prefixId.prefix "SpecialDay"
    /// <summary>
    ///   <para>rdfs:comment : A parking site which is located at a special location, often associated with some building.</para>
    ///   <a href="http://vocab.datex.org/terms#SpecialLocationParkingSite">datex:SpecialLocationParkingSite</a>
    /// </summary>
    let SpecialLocationParkingSite = _prefixId.prefix "SpecialLocationParkingSite"
    let SpeedControlSignFailure = _prefixId.prefix "SpeedControlSignFailure"
    let SpeedControlSignFault = _prefixId.prefix "SpeedControlSignFault"
    /// <summary>
    ///   <para>rdfs:comment : Speed management action that is instigated by the network/road operator.</para>
    ///   <a href="http://vocab.datex.org/terms#SpeedManagement">datex:SpeedManagement</a>
    /// </summary>
    let SpeedManagement = _prefixId.prefix "SpeedManagement"
    /// <summary>
    ///   <para>rdfs:comment : Details of percentage (from an observation set) of vehicles whose speeds fall below a stated value.</para>
    ///   <a href="http://vocab.datex.org/terms#SpeedPercentile">datex:SpeedPercentile</a>
    /// </summary>
    let SpeedPercentile = _prefixId.prefix "SpeedPercentile"
    let SpeedRestriction = _prefixId.prefix "SpeedRestriction"
    /// <summary>
    ///   <para>rdfs:comment : A measured or calculated value of speed.</para>
    ///   <a href="http://vocab.datex.org/terms#SpeedValue">datex:SpeedValue</a>
    /// </summary>
    let SpeedValue = _prefixId.prefix "SpeedValue"
    let SportsMeeting = _prefixId.prefix "SportsMeeting"
    let SprayHazard = _prefixId.prefix "SprayHazard"
    let StateOccasion = _prefixId.prefix "StateOccasion"
    let StationaryTraffic = _prefixId.prefix "StationaryTraffic"
    let StormDamage = _prefixId.prefix "StormDamage"
    let StormForceWinds = _prefixId.prefix "StormForceWinds"
    let StreetLightingFailure = _prefixId.prefix "StreetLightingFailure"
    let StreetLightingFault = _prefixId.prefix "StreetLightingFault"
    let Strike = _prefixId.prefix "Strike"
    let StrongGustsOfWind = _prefixId.prefix "StrongGustsOfWind"
    let StrongWinds = _prefixId.prefix "StrongWinds"
    /// <summary>
    ///   <para>rdfs:comment : The subjects with which the roadworks are associated.</para>
    ///   <a href="http://vocab.datex.org/terms#Subjects">datex:Subjects</a>
    /// </summary>
    let Subjects = _prefixId.prefix "Subjects"
    /// <summary>
    ///   <para>rdfs:comment : This item contains all information relating to a customer subscription.</para>
    ///   <a href="http://vocab.datex.org/terms#Subscription">datex:Subscription</a>
    /// </summary>
    let Subscription = _prefixId.prefix "Subscription"
    let Subsidence = _prefixId.prefix "Subsidence"

    /// <summary>
    ///   <para>rdfs:comment : A collection of supplementary positional information which improves the precision of the location.</para>
    ///   <a href="http://vocab.datex.org/terms#SupplementaryPositionalDescription">datex:SupplementaryPositionalDescription</a>
    /// </summary>
    let SupplementaryPositionalDescription = _prefixId.prefix "SupplementaryPositionalDescription"

    let SurfaceWater = _prefixId.prefix "SurfaceWater"
    let Survey = _prefixId.prefix "Survey"
    let SwarmsOfInsects = _prefixId.prefix "SwarmsOfInsects"
    let SweepingOfRoad = _prefixId.prefix "SweepingOfRoad"
    /// <summary>
    ///   <para>rdfs:comment : The details of a DATEX II target client.</para>
    ///   <a href="http://vocab.datex.org/terms#Target">datex:Target</a>
    /// </summary>
    let Target = _prefixId.prefix "Target"
    /// <summary>
    ///   <para>rdfs:comment : A table of charges under various conditions, primary used for parking. </para>
    ///   <a href="http://vocab.datex.org/terms#TariffsAndPayment">datex:TariffsAndPayment</a>
    /// </summary>
    let TariffsAndPayment = _prefixId.prefix "TariffsAndPayment"
    /// <summary>
    ///   <para>rdfs:comment : Details of atmospheric temperature.</para>
    ///   <a href="http://vocab.datex.org/terms#Temperature">datex:Temperature</a>
    /// </summary>
    let Temperature = _prefixId.prefix "Temperature"
    let TemperatureFalling = _prefixId.prefix "TemperatureFalling"
    /// <summary>
    ///   <para>rdfs:comment : Measurements of atmospheric temperature.</para>
    ///   <a href="http://vocab.datex.org/terms#TemperatureInformation">datex:TemperatureInformation</a>
    /// </summary>
    let TemperatureInformation = _prefixId.prefix "TemperatureInformation"
    /// <summary>
    ///   <para>rdfs:comment : A measured or calculated value of temperature.</para>
    ///   <a href="http://vocab.datex.org/terms#TemperatureValue">datex:TemperatureValue</a>
    /// </summary>
    let TemperatureValue = _prefixId.prefix "TemperatureValue"
    let TemporaryTrafficLights = _prefixId.prefix "TemporaryTrafficLights"
    let TemporaryTrafficLightsFailure = _prefixId.prefix "TemporaryTrafficLightsFailure"
    let TemporaryTrafficLightsFault = _prefixId.prefix "TemporaryTrafficLightsFault"
    let TennisTournament = _prefixId.prefix "TennisTournament"
    let TerroristIncident = _prefixId.prefix "TerroristIncident"
    /// <summary>
    ///   <para>rdfs:comment : Settings specific to a distinct text display area on the VMS.</para>
    ///   <a href="http://vocab.datex.org/terms#TextDisplayAreaSettings">datex:TextDisplayAreaSettings</a>
    /// </summary>
    let TextDisplayAreaSettings = _prefixId.prefix "TextDisplayAreaSettings"
    let Theft = _prefixId.prefix "Theft"
    let Thunderstorms = _prefixId.prefix "Thunderstorms"
    let TidalFlowLaneInOperation = _prefixId.prefix "TidalFlowLaneInOperation"
    /// <summary>
    ///   <para>rdfs:comment : Specification of a continuous period within a 24 hour period by times.</para>
    ///   <a href="http://vocab.datex.org/terms#TimePeriodByHour">datex:TimePeriodByHour</a>
    /// </summary>
    let TimePeriodByHour = _prefixId.prefix "TimePeriodByHour"
    /// <summary>
    ///   <para>rdfs:comment : Specification of a continuous period of time within a 24 hour period.</para>
    ///   <a href="http://vocab.datex.org/terms#TimePeriodOfDay">datex:TimePeriodOfDay</a>
    /// </summary>
    let TimePeriodOfDay = _prefixId.prefix "TimePeriodOfDay"
    let TollGatesFailure = _prefixId.prefix "TollGatesFailure"
    let TollGatesFault = _prefixId.prefix "TollGatesFault"
    let TollGatesOpen = _prefixId.prefix "TollGatesOpen"
    let Tornadoes = _prefixId.prefix "Tornadoes"
    let Tournament = _prefixId.prefix "Tournament"
    let ToxicCloudAlert = _prefixId.prefix "ToxicCloudAlert"
    /// <summary>
    ///   <para>rdfs:comment : A descriptor for describing an area location.</para>
    ///   <a href="http://vocab.datex.org/terms#TpegAreaDescriptor">datex:TpegAreaDescriptor</a>
    /// </summary>
    let TpegAreaDescriptor = _prefixId.prefix "TpegAreaDescriptor"
    /// <summary>
    ///   <para>rdfs:comment : A geographic or geometric area defined by a TPEG-Loc structure which may include height information for additional geospatial discrimination.</para>
    ///   <a href="http://vocab.datex.org/terms#TpegAreaLocation">datex:TpegAreaLocation</a>
    /// </summary>
    let TpegAreaLocation = _prefixId.prefix "TpegAreaLocation"
    /// <summary>
    ///   <para>rdfs:comment : A collection of information providing descriptive references to locations using the TPEG-Loc location referencing approach.</para>
    ///   <a href="http://vocab.datex.org/terms#TpegDescriptor">datex:TpegDescriptor</a>
    /// </summary>
    let TpegDescriptor = _prefixId.prefix "TpegDescriptor"
    /// <summary>
    ///   <para>rdfs:comment : A point on the road network which is framed between two other points on the same road.</para>
    ///   <a href="http://vocab.datex.org/terms#TpegFramedPoint">datex:TpegFramedPoint</a>
    /// </summary>
    let TpegFramedPoint = _prefixId.prefix "TpegFramedPoint"
    /// <summary>
    ///   <para>rdfs:comment : A geometric area defined by a centre point and a radius.</para>
    ///   <a href="http://vocab.datex.org/terms#TpegGeometricArea">datex:TpegGeometricArea</a>
    /// </summary>
    let TpegGeometricArea = _prefixId.prefix "TpegGeometricArea"
    /// <summary>
    ///   <para>rdfs:comment : Height information which provides additional discrimination for the applicable area.</para>
    ///   <a href="http://vocab.datex.org/terms#TpegHeight">datex:TpegHeight</a>
    /// </summary>
    let TpegHeight = _prefixId.prefix "TpegHeight"
    /// <summary>
    ///   <para>rdfs:comment : A descriptor for describing a junction by defining the intersecting roads.</para>
    ///   <a href="http://vocab.datex.org/terms#TpegIlcPointDescriptor">datex:TpegIlcPointDescriptor</a>
    /// </summary>
    let TpegIlcPointDescriptor = _prefixId.prefix "TpegIlcPointDescriptor"
    /// <summary>
    ///   <para>rdfs:comment : A point on the road network which is a road junction point.</para>
    ///   <a href="http://vocab.datex.org/terms#TpegJunction">datex:TpegJunction</a>
    /// </summary>
    let TpegJunction = _prefixId.prefix "TpegJunction"
    /// <summary>
    ///   <para>rdfs:comment : A descriptor for describing a point at a junction on a road network.</para>
    ///   <a href="http://vocab.datex.org/terms#TpegJunctionPointDescriptor">datex:TpegJunctionPointDescriptor</a>
    /// </summary>
    let TpegJunctionPointDescriptor = _prefixId.prefix "TpegJunctionPointDescriptor"
    /// <summary>
    ///   <para>rdfs:comment : A linear section along a single road defined between two points on the same road by a TPEG-Loc structure.</para>
    ///   <a href="http://vocab.datex.org/terms#TpegLinearLocation">datex:TpegLinearLocation</a>
    /// </summary>
    let TpegLinearLocation = _prefixId.prefix "TpegLinearLocation"
    /// <summary>
    ///   <para>rdfs:comment : An area defined by a well-known name.</para>
    ///   <a href="http://vocab.datex.org/terms#TpegNamedOnlyArea">datex:TpegNamedOnlyArea</a>
    /// </summary>
    let TpegNamedOnlyArea = _prefixId.prefix "TpegNamedOnlyArea"
    /// <summary>
    ///   <para>rdfs:comment : A point on the road network which is not a road junction point.</para>
    ///   <a href="http://vocab.datex.org/terms#TpegNonJunctionPoint">datex:TpegNonJunctionPoint</a>
    /// </summary>
    let TpegNonJunctionPoint = _prefixId.prefix "TpegNonJunctionPoint"
    /// <summary>
    ///   <para>rdfs:comment : General descriptor for describing a point.</para>
    ///   <a href="http://vocab.datex.org/terms#TpegOtherPointDescriptor">datex:TpegOtherPointDescriptor</a>
    /// </summary>
    let TpegOtherPointDescriptor = _prefixId.prefix "TpegOtherPointDescriptor"
    /// <summary>
    ///   <para>rdfs:comment : A point on the road network which is either a junction point or a non junction point.</para>
    ///   <a href="http://vocab.datex.org/terms#TpegPoint">datex:TpegPoint</a>
    /// </summary>
    let TpegPoint = _prefixId.prefix "TpegPoint"
    /// <summary>
    ///   <para>rdfs:comment : A descriptor for describing a point location.</para>
    ///   <a href="http://vocab.datex.org/terms#TpegPointDescriptor">datex:TpegPointDescriptor</a>
    /// </summary>
    let TpegPointDescriptor = _prefixId.prefix "TpegPointDescriptor"
    /// <summary>
    ///   <para>rdfs:comment : A single point on the road network defined by a TPEG-Loc structure and which has an associated direction of traffic flow.</para>
    ///   <a href="http://vocab.datex.org/terms#TpegPointLocation">datex:TpegPointLocation</a>
    /// </summary>
    let TpegPointLocation = _prefixId.prefix "TpegPointLocation"
    /// <summary>
    ///   <para>rdfs:comment : A point on the road network which is not bounded by any other points on the road network.</para>
    ///   <a href="http://vocab.datex.org/terms#TpegSimplePoint">datex:TpegSimplePoint</a>
    /// </summary>
    let TpegSimplePoint = _prefixId.prefix "TpegSimplePoint"
    let TrackLayingVehicle = _prefixId.prefix "TrackLayingVehicle"
    let TradeFair = _prefixId.prefix "TradeFair"
    let TrafficBeingManuallyDirected = _prefixId.prefix "TrafficBeingManuallyDirected"
    /// <summary>
    ///   <para>rdfs:comment : Averaged measurements or calculations of traffic concentration.</para>
    ///   <a href="http://vocab.datex.org/terms#TrafficConcentration">datex:TrafficConcentration</a>
    /// </summary>
    let TrafficConcentration = _prefixId.prefix "TrafficConcentration"
    /// <summary>
    ///   <para>rdfs:comment : Measured or derived values relating to traffic or individual vehicle movements on a specific section or at a specific point on the road network.</para>
    ///   <a href="http://vocab.datex.org/terms#TrafficData">datex:TrafficData</a>
    /// </summary>
    let TrafficData = _prefixId.prefix "TrafficData"
    /// <summary>
    ///   <para>rdfs:comment : An event which is not planned by the traffic operator, which is affecting, or has the potential to affect traffic flow.</para>
    ///   <a href="http://vocab.datex.org/terms#TrafficElement">datex:TrafficElement</a>
    /// </summary>
    let TrafficElement = _prefixId.prefix "TrafficElement"
    let TrafficElementEvent = _prefixId.prefix "TrafficElementEvent"
    /// <summary>
    ///   <para>rdfs:comment : Averaged measurements or calculations of traffic flow rates.</para>
    ///   <a href="http://vocab.datex.org/terms#TrafficFlow">datex:TrafficFlow</a>
    /// </summary>
    let TrafficFlow = _prefixId.prefix "TrafficFlow"
    /// <summary>
    ///   <para>rdfs:comment : Averaged measurements or calculations of traffic headway, i.e. the distance or time interval between vehicles. This measure is measured from the head of one vehicle to the head of the following vehicle.</para>
    ///   <a href="http://vocab.datex.org/terms#TrafficHeadway">datex:TrafficHeadway</a>
    /// </summary>
    let TrafficHeadway = _prefixId.prefix "TrafficHeadway"
    let TrafficHeld = _prefixId.prefix "TrafficHeld"
    let TrafficLightSetFailure = _prefixId.prefix "TrafficLightSetFailure"
    let TrafficLightSetFault = _prefixId.prefix "TrafficLightSetFault"
    let TrafficSignalsFailure = _prefixId.prefix "TrafficSignalsFailure"
    let TrafficSignalsFault = _prefixId.prefix "TrafficSignalsFault"
    /// <summary>
    ///   <para>rdfs:comment : Averaged measurements or calculations of traffic speed.</para>
    ///   <a href="http://vocab.datex.org/terms#TrafficSpeed">datex:TrafficSpeed</a>
    /// </summary>
    let TrafficSpeed = _prefixId.prefix "TrafficSpeed"
    /// <summary>
    ///   <para>rdfs:comment : The status of traffic conditions on a specific section or at a specific point on the road network.</para>
    ///   <a href="http://vocab.datex.org/terms#TrafficStatus">datex:TrafficStatus</a>
    /// </summary>
    let TrafficStatus = _prefixId.prefix "TrafficStatus"
    /// <summary>
    ///   <para>rdfs:comment : A measured or calculated value of the status of traffic conditions on a section of road in a specified direction.</para>
    ///   <a href="http://vocab.datex.org/terms#TrafficStatusValue">datex:TrafficStatusValue</a>
    /// </summary>
    let TrafficStatusValue = _prefixId.prefix "TrafficStatusValue"
    /// <summary>
    ///   <para>rdfs:comment : An identifiable instance of a traffic view at a single point in time relating to a predefined location set, comprising one or more linear traffic views each of which comprise one or more traffic view records.</para>
    ///   <a href="http://vocab.datex.org/terms#TrafficView">datex:TrafficView</a>
    /// </summary>
    let TrafficView = _prefixId.prefix "TrafficView"
    /// <summary>
    ///   <para>rdfs:comment : A publication containing one or more traffic views.</para>
    ///   <a href="http://vocab.datex.org/terms#TrafficViewPublication">datex:TrafficViewPublication</a>
    /// </summary>
    let TrafficViewPublication = _prefixId.prefix "TrafficViewPublication"
    /// <summary>
    ///   <para>rdfs:comment : An identifiable instance of a single record within a traffic view which shall comprise at most one instance of each of the following: OperatorAction, TrafficElement, ElaboratedData and CCTVImages.</para>
    ///   <a href="http://vocab.datex.org/terms#TrafficViewRecord">datex:TrafficViewRecord</a>
    /// </summary>
    let TrafficViewRecord = _prefixId.prefix "TrafficViewRecord"
    /// <summary>
    ///   <para>rdfs:comment : The availability of transit services and information relating to their departures. This is limited to those transit services which are of direct relevance to road users, e.g. connecting rail or ferry services.</para>
    ///   <a href="http://vocab.datex.org/terms#TransitInformation">datex:TransitInformation</a>
    /// </summary>
    let TransitInformation = _prefixId.prefix "TransitInformation"
    let TransportOfVip = _prefixId.prefix "TransportOfVip"
    /// <summary>
    ///   <para>rdfs:comment : Derived/computed travel time information relating to a linear section of the road network; forecast = true means a forecast for a vehicle at the start of the specified location, forecast = false means calculation/measurement at the end.</para>
    ///   <a href="http://vocab.datex.org/terms#TravelTimeData">datex:TravelTimeData</a>
    /// </summary>
    let TravelTimeData = _prefixId.prefix "TravelTimeData"
    let TreeAndVegetationCuttingWork = _prefixId.prefix "TreeAndVegetationCuttingWork"
    let TunnelLightFailure = _prefixId.prefix "TunnelLightFailure"
    let TunnelLightFault = _prefixId.prefix "TunnelLightFault"
    let TunnelVentilationFailure = _prefixId.prefix "TunnelVentilationFailure"
    let TunnelVentilationFault = _prefixId.prefix "TunnelVentilationFault"
    let TurnAroundInOperation = _prefixId.prefix "TurnAroundInOperation"
    let UndefinedAuthorityActivity = _prefixId.prefix "UndefinedAuthorityActivity"
    let Unknown = _prefixId.prefix "Unknown"
    let UnlitVehicleOnTheRoad = _prefixId.prefix "UnlitVehicleOnTheRoad"
    let UnspecifiedAbnormalTraffic = _prefixId.prefix "UnspecifiedAbnormalTraffic"
    let UnspecifiedAlert = _prefixId.prefix "UnspecifiedAlert"
    /// <summary>
    ///   <para>rdfs:comment : A parking site in an urban context.</para>
    ///   <a href="http://vocab.datex.org/terms#UrbanParkingSite">datex:UrbanParkingSite</a>
    /// </summary>
    let UrbanParkingSite = _prefixId.prefix "UrbanParkingSite"
    /// <summary>
    ///   <para>rdfs:comment : Details of a Uniform Resource Locator (URL) address pointing to a resource available on the Internet from where further relevant information may be obtained.</para>
    ///   <a href="http://vocab.datex.org/terms#UrlLink">datex:UrlLink</a>
    /// </summary>
    let UrlLink = _prefixId.prefix "UrlLink"

    let UseOfSpecifiedLanesOrCarriagewaysAllowed = _prefixId.prefix "UseOfSpecifiedLanesOrCarriagewaysAllowed"

    /// <summary>
    ///   <para>rdfs:comment : The used payment card for this parking vehicle.</para>
    ///   <a href="http://vocab.datex.org/terms#UsedPaymentCard">datex:UsedPaymentCard</a>
    /// </summary>
    let UsedPaymentCard = _prefixId.prefix "UsedPaymentCard"
    /// <summary>
    ///   <para>rdfs:comment : Specification of validity, either explicitly or by a validity time period specification which may be discontinuous.</para>
    ///   <a href="http://vocab.datex.org/terms#Validity">datex:Validity</a>
    /// </summary>
    let Validity = _prefixId.prefix "Validity"
    let VariableMessageSignFailure = _prefixId.prefix "VariableMessageSignFailure"
    let VariableMessageSignFault = _prefixId.prefix "VariableMessageSignFault"
    /// <summary>
    ///   <para>rdfs:comment : Details of an individual vehicle.</para>
    ///   <a href="http://vocab.datex.org/terms#Vehicle">datex:Vehicle</a>
    /// </summary>
    let Vehicle = _prefixId.prefix "Vehicle"

    let VehicleCarryingHazardousMaterials = _prefixId.prefix "VehicleCarryingHazardousMaterials"

    /// <summary>
    ///   <para>rdfs:comment : The characteristics of a vehicle, e.g. lorry of gross weight greater than 30 tonnes.</para>
    ///   <a href="http://vocab.datex.org/terms#VehicleCharacteristics">datex:VehicleCharacteristics</a>
    /// </summary>
    let VehicleCharacteristics = _prefixId.prefix "VehicleCharacteristics"

    /// <summary>
    ///   <para>rdfs:comment : Extension point for 'VehicleCharacteristics' to support additional attributes and literals like additional fuel types, load types etc.</para>
    ///   <a href="http://vocab.datex.org/terms#VehicleCharacteristicsExtended">datex:VehicleCharacteristicsExtended</a>
    /// </summary>
    let VehicleCharacteristicsExtended = _prefixId.prefix "VehicleCharacteristicsExtended"

    /// <summary>
    ///   <para>rdfs:comment : Vehicle rates can be assigned to a parking site or to assigned parking spaces. Furthermore, they can reference to a measurement site or to an entrance/exit.</para>
    ///   <a href="http://vocab.datex.org/terms#VehicleCountAndRate">datex:VehicleCountAndRate</a>
    /// </summary>
    let VehicleCountAndRate = _prefixId.prefix "VehicleCountAndRate"
    /// <summary>
    ///   <para>rdfs:comment : A measured or calculated value of absolute count of vehicles within a specified period of time expressed as non negative integer.</para>
    ///   <a href="http://vocab.datex.org/terms#VehicleCountValue">datex:VehicleCountValue</a>
    /// </summary>
    let VehicleCountValue = _prefixId.prefix "VehicleCountValue"
    /// <summary>
    ///   <para>rdfs:comment : Gives incoming and/or outgoing vehicles and/or change of occupied spaces within a given interval. The interval is given in positive or negative seconds related to 'measurementOrCalculationTime' or 'measurementDefaultTime'.</para>
    ///   <a href="http://vocab.datex.org/terms#VehicleCountWithinInterval">datex:VehicleCountWithinInterval</a>
    /// </summary>
    let VehicleCountWithinInterval = _prefixId.prefix "VehicleCountWithinInterval"
    /// <summary>
    ///   <para>rdfs:comment : A measured or calculated value of the flow rate of vehicles.</para>
    ///   <a href="http://vocab.datex.org/terms#VehicleFlowValue">datex:VehicleFlowValue</a>
    /// </summary>
    let VehicleFlowValue = _prefixId.prefix "VehicleFlowValue"
    let VehicleInDifficulty = _prefixId.prefix "VehicleInDifficulty"
    let VehicleInspectionCheckPoint = _prefixId.prefix "VehicleInspectionCheckPoint"
    /// <summary>
    ///   <para>rdfs:comment : An obstruction on the road caused by one or more vehicles.</para>
    ///   <a href="http://vocab.datex.org/terms#VehicleObstruction">datex:VehicleObstruction</a>
    /// </summary>
    let VehicleObstruction = _prefixId.prefix "VehicleObstruction"
    let VehicleOffRoad = _prefixId.prefix "VehicleOffRoad"
    let VehicleOnFire = _prefixId.prefix "VehicleOnFire"
    let VehicleOnWrongCarriageway = _prefixId.prefix "VehicleOnWrongCarriageway"
    /// <summary>
    ///   <para>rdfs:comment : Gives information about fill and exit rates OR vehicle flow rate (without direction). If the time stamp is omitted, 'measurementTimeDefault' is used.</para>
    ///   <a href="http://vocab.datex.org/terms#VehicleRate">datex:VehicleRate</a>
    /// </summary>
    let VehicleRate = _prefixId.prefix "VehicleRate"
    let VehicleRecovery = _prefixId.prefix "VehicleRecovery"
    let VehicleRepair = _prefixId.prefix "VehicleRepair"
    let VehicleSpunAround = _prefixId.prefix "VehicleSpunAround"
    let VehicleStorageInOperation = _prefixId.prefix "VehicleStorageInOperation"
    let VehicleStuck = _prefixId.prefix "VehicleStuck"
    let VehicleStuckUnderBridge = _prefixId.prefix "VehicleStuckUnderBridge"
    let VehicleWeighing = _prefixId.prefix "VehicleWeighing"
    let VehicleWithOverheightLoad = _prefixId.prefix "VehicleWithOverheightLoad"
    let VehicleWithOverwideLoad = _prefixId.prefix "VehicleWithOverwideLoad"
    let VersionedReference = _prefixId.prefix "VersionedReference"
    let VeryHazardous = _prefixId.prefix "VeryHazardous"
    let VeryStrongGustsOfWind = _prefixId.prefix "VeryStrongGustsOfWind"
    /// <summary>
    ///   <para>rdfs:comment : Details of atmospheric visibility.</para>
    ///   <a href="http://vocab.datex.org/terms#Visibility">datex:Visibility</a>
    /// </summary>
    let Visibility = _prefixId.prefix "Visibility"
    /// <summary>
    ///   <para>rdfs:comment : Measurements of atmospheric visibility.</para>
    ///   <a href="http://vocab.datex.org/terms#VisibilityInformation">datex:VisibilityInformation</a>
    /// </summary>
    let VisibilityInformation = _prefixId.prefix "VisibilityInformation"
    let VisibilityReduced = _prefixId.prefix "VisibilityReduced"
    /// <summary>
    ///   <para>rdfs:comment : Provides the current status and settings of the VMS and the currently displayed information. Where a VMS is displaying a sequence or alternating set of messages these are ordered according to the messageIndex qualifier.</para>
    ///   <a href="http://vocab.datex.org/terms#Vms">datex:Vms</a>
    /// </summary>
    let Vms = _prefixId.prefix "Vms"
    /// <summary>
    ///   <para>rdfs:comment : Provides the current characteristic settings for the VMS which can be dynamically configured and therefore which override any corresponding characteristics set for the VMS in the relevant VmsUnitPublication.</para>
    ///   <a href="http://vocab.datex.org/terms#VmsDynamicCharacteristics">datex:VmsDynamicCharacteristics</a>
    /// </summary>
    let VmsDynamicCharacteristics = _prefixId.prefix "VmsDynamicCharacteristics"
    /// <summary>
    ///   <para>rdfs:comment : Details of the fault which is being reported for the specified variable message sign panel.</para>
    ///   <a href="http://vocab.datex.org/terms#VmsFault">datex:VmsFault</a>
    /// </summary>
    let VmsFault = _prefixId.prefix "VmsFault"
    /// <summary>
    ///   <para>rdfs:comment : The logical location (e.g. a car park, a section of road, a junction etc.) which a VMS contributes to the management of.</para>
    ///   <a href="http://vocab.datex.org/terms#VmsManagedLogicalLocation">datex:VmsManagedLogicalLocation</a>
    /// </summary>
    let VmsManagedLogicalLocation = _prefixId.prefix "VmsManagedLogicalLocation"
    /// <summary>
    ///   <para>rdfs:comment : A message displayed on a VMS which may comprise one or more sequentially displayed text pages and/or pictograms with supplementary details. When in a sequence of displayed messages sequencing of text pages and pictograms within a message are prohibited.</para>
    ///   <a href="http://vocab.datex.org/terms#VmsMessage">datex:VmsMessage</a>
    /// </summary>
    let VmsMessage = _prefixId.prefix "VmsMessage"
    /// <summary>
    ///   <para>rdfs:comment : A main pictogram displayable on the VMS panel. Note a main pictogram may have an associated supplementary panel which may itself contain a further pictogram and line of text.</para>
    ///   <a href="http://vocab.datex.org/terms#VmsPictogram">datex:VmsPictogram</a>
    /// </summary>
    let VmsPictogram = _prefixId.prefix "VmsPictogram"
    /// <summary>
    ///   <para>rdfs:comment : An area on a VMS used for the display of pictograms and associated supplemental information or instructions.</para>
    ///   <a href="http://vocab.datex.org/terms#VmsPictogramDisplayArea">datex:VmsPictogramDisplayArea</a>
    /// </summary>
    let VmsPictogramDisplayArea = _prefixId.prefix "VmsPictogramDisplayArea"

    /// <summary>
    ///   <para>rdfs:comment : Characteristics specific to the pictogram display area(s) on the VMS where pictogramDisplayAreaIndex indicates which pictogram area it relates to.</para>
    ///   <a href="http://vocab.datex.org/terms#VmsPictogramDisplayCharacteristics">datex:VmsPictogramDisplayCharacteristics</a>
    /// </summary>
    let VmsPictogramDisplayCharacteristics = _prefixId.prefix "VmsPictogramDisplayCharacteristics"

    /// <summary>
    ///   <para>rdfs:comment : A publication containing the current status and settings of one or more VMS units, each unit controlling one or more individual variable message signs.</para>
    ///   <a href="http://vocab.datex.org/terms#VmsPublication">datex:VmsPublication</a>
    /// </summary>
    let VmsPublication = _prefixId.prefix "VmsPublication"
    /// <summary>
    ///   <para>rdfs:comment : A sub-record in the VMS Unit table defining the characteristics of a single variable message sign that is controlled by a specific VMS unit. Locations are on or adjacent to the road network but may be updated over time if relating to a mobile VMS unit.</para>
    ///   <a href="http://vocab.datex.org/terms#VmsRecord">datex:VmsRecord</a>
    /// </summary>
    let VmsRecord = _prefixId.prefix "VmsRecord"
    /// <summary>
    ///   <para>rdfs:comment : Provides information on variable message signs and the information currently displayed.</para>
    ///   <a href="http://vocab.datex.org/terms#VmsSetting">datex:VmsSetting</a>
    /// </summary>
    let VmsSetting = _prefixId.prefix "VmsSetting"
    /// <summary>
    ///   <para>rdfs:comment : A panel which may display information or a regulatory instruction which is supplemental to the associated pictogram, comprising either an additional line of text or a pictogram or both.</para>
    ///   <a href="http://vocab.datex.org/terms#VmsSupplementaryPanel">datex:VmsSupplementaryPanel</a>
    /// </summary>
    let VmsSupplementaryPanel = _prefixId.prefix "VmsSupplementaryPanel"

    /// <summary>
    ///   <para>rdfs:comment : Characteristics of a panel which may display details (sometimes regulatory in nature) that are supplemental to the main pictogram, comprising an additional line of text and/or a pictogram.</para>
    ///   <a href="http://vocab.datex.org/terms#VmsSupplementaryPanelCharacteristics">datex:VmsSupplementaryPanelCharacteristics</a>
    /// </summary>
    let VmsSupplementaryPanelCharacteristics = _prefixId.prefix "VmsSupplementaryPanelCharacteristics"

    /// <summary>
    ///   <para>rdfs:comment : An additional pictogram that is displayed in the panel which is supplemental to the associated pictogram display.</para>
    ///   <a href="http://vocab.datex.org/terms#VmsSupplementaryPictogram">datex:VmsSupplementaryPictogram</a>
    /// </summary>
    let VmsSupplementaryPictogram = _prefixId.prefix "VmsSupplementaryPictogram"
    /// <summary>
    ///   <para>rdfs:comment : A publication containing one or more VMS Unit Tables each comprising a set of records which hold details of VMS units.</para>
    ///   <a href="http://vocab.datex.org/terms#VmsTablePublication">datex:VmsTablePublication</a>
    /// </summary>
    let VmsTablePublication = _prefixId.prefix "VmsTablePublication"
    /// <summary>
    ///   <para>rdfs:comment : A page of text (comprising one or more ordered lines) that are displayed simultaneously on the VMS. Where more than one page is defined these are sequentially displayed according to their "pageNumber".</para>
    ///   <a href="http://vocab.datex.org/terms#VmsText">datex:VmsText</a>
    /// </summary>
    let VmsText = _prefixId.prefix "VmsText"
    /// <summary>
    ///   <para>rdfs:comment : Characteristics specific to the textual display area on the VMS.</para>
    ///   <a href="http://vocab.datex.org/terms#VmsTextDisplayCharacteristics">datex:VmsTextDisplayCharacteristics</a>
    /// </summary>
    let VmsTextDisplayCharacteristics = _prefixId.prefix "VmsTextDisplayCharacteristics"
    /// <summary>
    ///   <para>rdfs:comment : A single line of text on a text display area or supplementary panel.</para>
    ///   <a href="http://vocab.datex.org/terms#VmsTextLine">datex:VmsTextLine</a>
    /// </summary>
    let VmsTextLine = _prefixId.prefix "VmsTextLine"
    /// <summary>
    ///   <para>rdfs:comment : Status of a VMS unit which may control one or more variable message signs on a single gantry or on different gantries.</para>
    ///   <a href="http://vocab.datex.org/terms#VmsUnit">datex:VmsUnit</a>
    /// </summary>
    let VmsUnit = _prefixId.prefix "VmsUnit"
    /// <summary>
    ///   <para>rdfs:comment : Details of the fault which is being reported for the specified variable message sign control unit.</para>
    ///   <a href="http://vocab.datex.org/terms#VmsUnitFault">datex:VmsUnitFault</a>
    /// </summary>
    let VmsUnitFault = _prefixId.prefix "VmsUnitFault"
    /// <summary>
    ///   <para>rdfs:comment : A versioned single VMS unit entry/record in the VMS Unit table that defines the characteristics of the VMS unit.</para>
    ///   <a href="http://vocab.datex.org/terms#VmsUnitRecord">datex:VmsUnitRecord</a>
    /// </summary>
    let VmsUnitRecord = _prefixId.prefix "VmsUnitRecord"
    /// <summary>
    ///   <para>rdfs:comment : A versioned VMS Unit Table comprising a number of data records, each record defining the characteristics of a specific deployed variable message sign unit.</para>
    ///   <a href="http://vocab.datex.org/terms#VmsUnitTable">datex:VmsUnitTable</a>
    /// </summary>
    let VmsUnitTable = _prefixId.prefix "VmsUnitTable"
    let WaterSportsMeeting = _prefixId.prefix "WaterSportsMeeting"
    let WeakBridge = _prefixId.prefix "WeakBridge"
    /// <summary>
    ///   <para>rdfs:comment : Measured or derived values relating to the weather at a specific location or locations.</para>
    ///   <a href="http://vocab.datex.org/terms#WeatherData">datex:WeatherData</a>
    /// </summary>
    let WeatherData = _prefixId.prefix "WeatherData"
    let WeatherRelatedConditions = _prefixId.prefix "WeatherRelatedConditions"
    /// <summary>
    ///   <para>rdfs:comment : Road surface conditions that are related to the weather which may affect the driving conditions, such as ice, snow or water.</para>
    ///   <a href="http://vocab.datex.org/terms#WeatherRelatedRoadConditions">datex:WeatherRelatedRoadConditions</a>
    /// </summary>
    let WeatherRelatedRoadConditions = _prefixId.prefix "WeatherRelatedRoadConditions"
    let WeighInMotion = _prefixId.prefix "WeighInMotion"
    let WeightRestrictionInOperation = _prefixId.prefix "WeightRestrictionInOperation"
    let Wet = _prefixId.prefix "Wet"
    let WetAndIcyRoad = _prefixId.prefix "WetAndIcyRoad"
    let WetIcyPavement = _prefixId.prefix "WetIcyPavement"
    let WhiteOut = _prefixId.prefix "WhiteOut"
    /// <summary>
    ///   <para>rdfs:comment : Width characteristic of a vehicle.</para>
    ///   <a href="http://vocab.datex.org/terms#WidthCharacteristic">datex:WidthCharacteristic</a>
    /// </summary>
    let WidthCharacteristic = _prefixId.prefix "WidthCharacteristic"
    /// <summary>
    ///   <para>rdfs:comment : Wind conditions on the road. </para>
    ///   <a href="http://vocab.datex.org/terms#Wind">datex:Wind</a>
    /// </summary>
    let Wind = _prefixId.prefix "Wind"
    /// <summary>
    ///   <para>rdfs:comment : Measurements of wind conditions.</para>
    ///   <a href="http://vocab.datex.org/terms#WindInformation">datex:WindInformation</a>
    /// </summary>
    let WindInformation = _prefixId.prefix "WindInformation"
    let WinterConditions = _prefixId.prefix "WinterConditions"
    /// <summary>
    ///   <para>rdfs:comment : Winter driving management action that is instigated by the network/road operator.</para>
    ///   <a href="http://vocab.datex.org/terms#WinterDrivingManagement">datex:WinterDrivingManagement</a>
    /// </summary>
    let WinterDrivingManagement = _prefixId.prefix "WinterDrivingManagement"
    let WinterSportsMeeting = _prefixId.prefix "WinterSportsMeeting"
    let WinterStorm = _prefixId.prefix "WinterStorm"
    let _AreaExtensionType = _prefixId.prefix "_AreaExtensionType"
    let _ChargeBandVersionedReference = _prefixId.prefix "_ChargeBandVersionedReference"

    let _ContactDetailsVersionedReference = _prefixId.prefix "_ContactDetailsVersionedReference"

    let _ExtensionType = _prefixId.prefix "_ExtensionType"

    let _GenericPublicationExtensionType = _prefixId.prefix "_GenericPublicationExtensionType"

    let _GroupOfParkingSpaces = _prefixId.prefix "_GroupOfParkingSpaces"

    let _GroupOfParkingSpacesParkingSpaceIndexParkingSpace = _prefixId.prefix "_GroupOfParkingSpacesParkingSpaceIndexParkingSpace"

    let _IntermediatePointOnLinearElement = _prefixId.prefix "_IntermediatePointOnLinearElement"

    let _LinearExtensionType = _prefixId.prefix "_LinearExtensionType"
    let _LocationContainedInItinerary = _prefixId.prefix "_LocationContainedInItinerary"

    let _MeasurementSiteRecordIndexMeasurementSpecificCharacteristics = _prefixId.prefix "_MeasurementSiteRecordIndexMeasurementSpecificCharacteristics"

    let _MeasurementSiteRecordVersionedReference = _prefixId.prefix "_MeasurementSiteRecordVersionedReference"

    let _MeasurementSiteTableVersionedReference = _prefixId.prefix "_MeasurementSiteTableVersionedReference"

    let _ParkingAccessReference = _prefixId.prefix "_ParkingAccessReference"

    let _ParkingRecordEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacility =
        _prefixId.prefix "_ParkingRecordEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacility"

    let _ParkingRecordStatusEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacilityStatus =
        _prefixId.prefix "_ParkingRecordStatusEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacilityStatus"

    let _ParkingRecordStatusGroupIndexGroupOfParkingSpacesStatus = _prefixId.prefix "_ParkingRecordStatusGroupIndexGroupOfParkingSpacesStatus"

    let _ParkingRecordStatusParkingSpaceIndexParkingSpaceStatus = _prefixId.prefix "_ParkingRecordStatusParkingSpaceIndexParkingSpaceStatus"

    let _ParkingRecordStatusScenarioIndexParkingUsageScenarioStatus = _prefixId.prefix "_ParkingRecordStatusScenarioIndexParkingUsageScenarioStatus"

    let _ParkingRecordVersionedReference = _prefixId.prefix "_ParkingRecordVersionedReference"

    let _ParkingRouteDetailsVersionedReference = _prefixId.prefix "_ParkingRouteDetailsVersionedReference"

    let _ParkingSiteScenarioIndexParkingUsageScenario = _prefixId.prefix "_ParkingSiteScenarioIndexParkingUsageScenario"

    let _ParkingSpace = _prefixId.prefix "_ParkingSpace"

    let _ParkingSpaceBasicsEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacility =
        _prefixId.prefix "_ParkingSpaceBasicsEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacility"

    let _ParkingSpaceBasicsScenarioIndexParkingUsageScenario = _prefixId.prefix "_ParkingSpaceBasicsScenarioIndexParkingUsageScenario"

    let _ParkingTableVersionedReference = _prefixId.prefix "_ParkingTableVersionedReference"

    let _PeriodExtensionType = _prefixId.prefix "_PeriodExtensionType"
    let _PointExtensionType = _prefixId.prefix "_PointExtensionType"

    let _PolygonAreaIndexPointCoordinates = _prefixId.prefix "_PolygonAreaIndexPointCoordinates"

    let _PredefinedItineraryIndexPredefinedLocation = _prefixId.prefix "_PredefinedItineraryIndexPredefinedLocation"

    let _PredefinedItineraryVersionedReference = _prefixId.prefix "_PredefinedItineraryVersionedReference"

    let _PredefinedLocationVersionedReference = _prefixId.prefix "_PredefinedLocationVersionedReference"

    let _PredefinedNonOrderedLocationGroupVersionedReference = _prefixId.prefix "_PredefinedNonOrderedLocationGroupVersionedReference"

    let _SiteMeasurementsIndexMeasuredValue = _prefixId.prefix "_SiteMeasurementsIndexMeasuredValue"

    let _SituationRecordExtensionType = _prefixId.prefix "_SituationRecordExtensionType"

    let _SituationRecordVersionedReference = _prefixId.prefix "_SituationRecordVersionedReference"

    let _SituationVersionedReference = _prefixId.prefix "_SituationVersionedReference"
    let _TextPage = _prefixId.prefix "_TextPage"

    let _VehicleCharacteristicsExtensionType = _prefixId.prefix "_VehicleCharacteristicsExtensionType"

    let _VmsDynamicCharacteristicsPictogramDisplayAreaIndexVmsPictogramDisplayCharacteristics =
        _prefixId.prefix "_VmsDynamicCharacteristicsPictogramDisplayAreaIndexVmsPictogramDisplayCharacteristics"

    let _VmsMessageIndexVmsMessage = _prefixId.prefix "_VmsMessageIndexVmsMessage"

    let _VmsMessagePictogramDisplayAreaIndexVmsPictogramDisplayArea = _prefixId.prefix "_VmsMessagePictogramDisplayAreaIndexVmsPictogramDisplayArea"

    let _VmsPictogramDisplayAreaIndexPictogramDisplayAreaSettings = _prefixId.prefix "_VmsPictogramDisplayAreaIndexPictogramDisplayAreaSettings"

    let _VmsPictogramDisplayAreaPictogramSequencingIndexVmsPictogram = _prefixId.prefix "_VmsPictogramDisplayAreaPictogramSequencingIndexVmsPictogram"

    let _VmsRecordPictogramDisplayAreaIndexVmsPictogramDisplayCharacteristics = _prefixId.prefix "_VmsRecordPictogramDisplayAreaIndexVmsPictogramDisplayCharacteristics"

    let _VmsTextLineIndexVmsTextLine = _prefixId.prefix "_VmsTextLineIndexVmsTextLine"

    let _VmsUnitRecordVersionedReference = _prefixId.prefix "_VmsUnitRecordVersionedReference"

    let _VmsUnitRecordVmsIndexVmsRecord = _prefixId.prefix "_VmsUnitRecordVmsIndexVmsRecord"

    let _VmsUnitTableVersionedReference = _prefixId.prefix "_VmsUnitTableVersionedReference"

    let _VmsUnitVmsIndexVms = _prefixId.prefix "_VmsUnitVmsIndexVms"
    let abnormalTrafficExtension = _prefixId.prefix "abnormalTrafficExtension"
    /// <summary>
    ///   <para>rdfs:comment : A characterization of the nature of abnormal traffic flow, i.e. specifically relating to the nature of the traffic movement.</para>
    ///   <a href="http://vocab.datex.org/terms#abnormalTrafficType">datex:abnormalTrafficType</a>
    /// </summary>
    let abnormalTrafficType = _prefixId.prefix "abnormalTrafficType"
    let acceptedMeansOfPayment = _prefixId.prefix "acceptedMeansOfPayment"
    let acceptedPaymentCards = _prefixId.prefix "acceptedPaymentCards"
    let acceptedPaymentCardsExtension = _prefixId.prefix "acceptedPaymentCardsExtension"
    let accessAssignedAmongOthers = _prefixId.prefix "accessAssignedAmongOthers"
    let accessCategory = _prefixId.prefix "accessCategory"
    let accessEquipment = _prefixId.prefix "accessEquipment"
    let accessFault = _prefixId.prefix "accessFault"
    let accessName = _prefixId.prefix "accessName"
    let accessOnlyAssignedFor = _prefixId.prefix "accessOnlyAssignedFor"
    let accessOpeningStatus = _prefixId.prefix "accessOpeningStatus"
    let accessProhibitedFor = _prefixId.prefix "accessProhibitedFor"
    let accessReference = _prefixId.prefix "accessReference"
    let accessibility = _prefixId.prefix "accessibility"
    /// <summary>
    ///   <para>rdfs:comment : A descriptor indicating the most significant factor causing an accident.</para>
    ///   <a href="http://vocab.datex.org/terms#accidentCause">datex:accidentCause</a>
    /// </summary>
    let accidentCause = _prefixId.prefix "accidentCause"
    let accidentExtension = _prefixId.prefix "accidentExtension"
    /// <summary>
    ///   <para>rdfs:comment : A characterization of the nature of the accident.</para>
    ///   <a href="http://vocab.datex.org/terms#accidentType">datex:accidentType</a>
    /// </summary>
    let accidentType = _prefixId.prefix "accidentType"
    let accuracy = _prefixId.prefix "accuracy"
    /// <summary>
    ///   <para>rdfs:comment : Indicates whether the actions to be undertaken by the operator are the result of an internal operation or external influence.</para>
    ///   <a href="http://vocab.datex.org/terms#actionOrigin">datex:actionOrigin</a>
    /// </summary>
    let actionOrigin = _prefixId.prefix "actionOrigin"
    /// <summary>
    ///   <para>rdfs:comment : The identifier of the traffic management action plan to which this action relates.</para>
    ///   <a href="http://vocab.datex.org/terms#actionPlanIdentifier">datex:actionPlanIdentifier</a>
    /// </summary>
    let actionPlanIdentifier = _prefixId.prefix "actionPlanIdentifier"
    let activity = _prefixId.prefix "activity"
    let activityExtension = _prefixId.prefix "activityExtension"
    let additionalDescription = _prefixId.prefix "additionalDescription"

    let additionalPictogramDescription = _prefixId.prefix "additionalPictogramDescription"

    let additionalSupplementaryPictogramDescription = _prefixId.prefix "additionalSupplementaryPictogramDescription"

    let address = _prefixId.prefix "address"

    let administrativeAreaOfLinearSection = _prefixId.prefix "administrativeAreaOfLinearSection"

    let administrativeAreaOfPoint = _prefixId.prefix "administrativeAreaOfPoint"
    let affectedCarriagewayAndLanes = _prefixId.prefix "affectedCarriagewayAndLanes"

    let affectedCarriagewayAndLanesExtension = _prefixId.prefix "affectedCarriagewayAndLanesExtension"

    let airTemperature = _prefixId.prefix "airTemperature"
    let alertCArea = _prefixId.prefix "alertCArea"
    let alertCAreaExtension = _prefixId.prefix "alertCAreaExtension"
    let alertCDirection = _prefixId.prefix "alertCDirection"
    let alertCDirectionCoded = _prefixId.prefix "alertCDirectionCoded"
    let alertCDirectionExtension = _prefixId.prefix "alertCDirectionExtension"
    let alertCDirectionNamed = _prefixId.prefix "alertCDirectionNamed"
    let alertCDirectionSense = _prefixId.prefix "alertCDirectionSense"
    let alertCLinear = _prefixId.prefix "alertCLinear"
    let alertCLinearByCodeExtension = _prefixId.prefix "alertCLinearByCodeExtension"
    let alertCLinearExtension = _prefixId.prefix "alertCLinearExtension"
    let alertCLocation = _prefixId.prefix "alertCLocation"
    let alertCLocationCountryCode = _prefixId.prefix "alertCLocationCountryCode"
    let alertCLocationExtension = _prefixId.prefix "alertCLocationExtension"
    let alertCLocationName = _prefixId.prefix "alertCLocationName"
    let alertCLocationTableNumber = _prefixId.prefix "alertCLocationTableNumber"
    let alertCLocationTableVersion = _prefixId.prefix "alertCLocationTableVersion"
    let alertCMethod2LinearExtension = _prefixId.prefix "alertCMethod2LinearExtension"
    let alertCMethod2PointExtension = _prefixId.prefix "alertCMethod2PointExtension"

    let alertCMethod2PrimaryPointLocation = _prefixId.prefix "alertCMethod2PrimaryPointLocation"

    let alertCMethod2PrimaryPointLocationExtension = _prefixId.prefix "alertCMethod2PrimaryPointLocationExtension"

    let alertCMethod2SecondaryPointLocation = _prefixId.prefix "alertCMethod2SecondaryPointLocation"

    let alertCMethod2SecondaryPointLocationExtension = _prefixId.prefix "alertCMethod2SecondaryPointLocationExtension"

    let alertCMethod4LinearExtension = _prefixId.prefix "alertCMethod4LinearExtension"
    let alertCMethod4PointExtension = _prefixId.prefix "alertCMethod4PointExtension"

    let alertCMethod4PrimaryPointLocation = _prefixId.prefix "alertCMethod4PrimaryPointLocation"

    let alertCMethod4PrimaryPointLocationExtension = _prefixId.prefix "alertCMethod4PrimaryPointLocationExtension"

    let alertCMethod4SecondaryPointLocation = _prefixId.prefix "alertCMethod4SecondaryPointLocation"

    let alertCMethod4SecondaryPointLocationExtension = _prefixId.prefix "alertCMethod4SecondaryPointLocationExtension"

    let alertCPoint = _prefixId.prefix "alertCPoint"
    let alertCPointExtension = _prefixId.prefix "alertCPointExtension"
    /// <summary>
    ///   <para>rdfs:comment : Indicates whether the identified animals are dead (immobile) or alive (potentially mobile).</para>
    ///   <a href="http://vocab.datex.org/terms#alive">datex:alive</a>
    /// </summary>
    let alive = _prefixId.prefix "alive"
    let almostFullDecreasing = _prefixId.prefix "almostFullDecreasing"
    let almostFullIncreasing = _prefixId.prefix "almostFullIncreasing"
    /// <summary>
    ///   <para>rdfs:comment : The definition of the alternative route (rerouting) specified as an ordered set of locations (itinerary) which may be specific to one or more defined destinations.</para>
    ///   <a href="http://vocab.datex.org/terms#alternativeRoute">datex:alternativeRoute</a>
    /// </summary>
    let alternativeRoute = _prefixId.prefix "alternativeRoute"

    let animalPresenceObstructionExtension = _prefixId.prefix "animalPresenceObstructionExtension"

    /// <summary>
    ///   <para>rdfs:comment : Indicates the nature of animals present on or near the roadway.</para>
    ///   <a href="http://vocab.datex.org/terms#animalPresenceType">datex:animalPresenceType</a>
    /// </summary>
    let animalPresenceType = _prefixId.prefix "animalPresenceType"
    let any = _prefixId.prefix "any"
    let applicableDay = _prefixId.prefix "applicableDay"
    let applicableForPeriod = _prefixId.prefix "applicableForPeriod"
    /// <summary>
    ///   <para>rdfs:comment : The ultimate traffic direction to which the network management is applicable.</para>
    ///   <a href="http://vocab.datex.org/terms#applicableForTrafficDirection">datex:applicableForTrafficDirection</a>
    /// </summary>
    let applicableForTrafficDirection = _prefixId.prefix "applicableForTrafficDirection"
    /// <summary>
    ///   <para>rdfs:comment : The type of traffic to which the network management is applicable.</para>
    ///   <a href="http://vocab.datex.org/terms#applicableForTrafficType">datex:applicableForTrafficType</a>
    /// </summary>
    let applicableForTrafficType = _prefixId.prefix "applicableForTrafficType"
    let applicableForUser = _prefixId.prefix "applicableForUser"
    let applicableForVehicles = _prefixId.prefix "applicableForVehicles"
    let applicableMonth = _prefixId.prefix "applicableMonth"
    let applicableWeek = _prefixId.prefix "applicableWeek"
    /// <summary>
    ///   <para>rdfs:comment : A value of the rate of application of a substance expressed in kilogrammes per square metre.</para>
    ///   <a href="http://vocab.datex.org/terms#applicationRate">datex:applicationRate</a>
    /// </summary>
    let applicationRate = _prefixId.prefix "applicationRate"
    let applicationRateValueExtension = _prefixId.prefix "applicationRateValueExtension"
    let area = _prefixId.prefix "area"
    let areaDestinationExtension = _prefixId.prefix "areaDestinationExtension"
    let areaExtended = _prefixId.prefix "areaExtended"
    let areaExtension = _prefixId.prefix "areaExtension"
    let areaLocation = _prefixId.prefix "areaLocation"
    let areaName = _prefixId.prefix "areaName"
    let areaOfInterest = _prefixId.prefix "areaOfInterest"
    /// <summary>
    ///   <para>rdfs:comment : The time of the arrival of an individual vehicle in a detection zone.</para>
    ///   <a href="http://vocab.datex.org/terms#arrivalTime">datex:arrivalTime</a>
    /// </summary>
    let arrivalTime = _prefixId.prefix "arrivalTime"
    let assignedParkingAmongOthers = _prefixId.prefix "assignedParkingAmongOthers"

    let associatedManagementOrDiversionPlan = _prefixId.prefix "associatedManagementOrDiversionPlan"

    let authorityOperationExtension = _prefixId.prefix "authorityOperationExtension"
    /// <summary>
    ///   <para>rdfs:comment : Type of authority initiated operation or activity that could disrupt traffic. </para>
    ///   <a href="http://vocab.datex.org/terms#authorityOperationType">datex:authorityOperationType</a>
    /// </summary>
    let authorityOperationType = _prefixId.prefix "authorityOperationType"
    /// <summary>
    ///   <para>rdfs:comment : Defines whether the network management is initiated by an automatic system.</para>
    ///   <a href="http://vocab.datex.org/terms#automaticallyInitiated">datex:automaticallyInitiated</a>
    /// </summary>
    let automaticallyInitiated = _prefixId.prefix "automaticallyInitiated"
    let availability = _prefixId.prefix "availability"
    let availabilityAndOpeningTimes = _prefixId.prefix "availabilityAndOpeningTimes"
    /// <summary>
    ///   <para>rdfs:comment : Specifies if the availability is 24 hours a day. If omitted, this information is unknown or heterogeneous.</para>
    ///   <a href="http://vocab.datex.org/terms#available24hours">datex:available24hours</a>
    /// </summary>
    let available24hours = _prefixId.prefix "available24hours"
    /// <summary>
    ///   <para>rdfs:comment : The average distance between the front (respectively back) of this vehicle and the front (respectively  back) of the preceding vehicle, averaged for all vehicles within a defined measurement period at the specified measurement site.</para>
    ///   <a href="http://vocab.datex.org/terms#averageDistanceHeadway">datex:averageDistanceHeadway</a>
    /// </summary>
    let averageDistanceHeadway = _prefixId.prefix "averageDistanceHeadway"
    /// <summary>
    ///   <para>rdfs:comment : The average time gap between the front (respectively back) of this vehicle and the front (respectively  back) of the preceding vehicle, averaged for all vehicles within a defined measurement period at the specified measurement site.</para>
    ///   <a href="http://vocab.datex.org/terms#averageTimeHeadway">datex:averageTimeHeadway</a>
    /// </summary>
    let averageTimeHeadway = _prefixId.prefix "averageTimeHeadway"
    /// <summary>
    ///   <para>rdfs:comment : An averaged measurement or calculation of the speed of vehicles at the specified location.</para>
    ///   <a href="http://vocab.datex.org/terms#averageVehicleSpeed">datex:averageVehicleSpeed</a>
    /// </summary>
    let averageVehicleSpeed = _prefixId.prefix "averageVehicleSpeed"
    /// <summary>
    ///   <para>rdfs:comment : An averaged measurement or calculation of flow rate defined in terms of the number of vehicle axles passing the specified measurement site.</para>
    ///   <a href="http://vocab.datex.org/terms#axleFlow">datex:axleFlow</a>
    /// </summary>
    let axleFlow = _prefixId.prefix "axleFlow"
    /// <summary>
    ///   <para>rdfs:comment : A value of the flow rate of vehicle axles expressed in axles per hour.</para>
    ///   <a href="http://vocab.datex.org/terms#axleFlowRate">datex:axleFlowRate</a>
    /// </summary>
    let axleFlowRate = _prefixId.prefix "axleFlowRate"
    let axleFlowValueExtension = _prefixId.prefix "axleFlowValueExtension"
    let axlePositionIdentifier = _prefixId.prefix "axlePositionIdentifier"
    let axleSpacing = _prefixId.prefix "axleSpacing"
    let axleSpacingExtension = _prefixId.prefix "axleSpacingExtension"
    let axleSpacingOnVehicle = _prefixId.prefix "axleSpacingOnVehicle"
    let axleSpacingSequenceIdentifier = _prefixId.prefix "axleSpacingSequenceIdentifier"
    let axleWeight = _prefixId.prefix "axleWeight"
    let axleWeightExtension = _prefixId.prefix "axleWeightExtension"
    let backgroundImageUrl = _prefixId.prefix "backgroundImageUrl"
    let basicData = _prefixId.prefix "basicData"
    let basicDataExtension = _prefixId.prefix "basicDataExtension"
    let bearing = _prefixId.prefix "bearing"
    let blurredAvailability = _prefixId.prefix "blurredAvailability"
    let cancel = _prefixId.prefix "cancel"
    let capacityRemaining = _prefixId.prefix "capacityRemaining"
    let carParkConfiguration = _prefixId.prefix "carParkConfiguration"
    /// <summary>
    ///   <para>rdfs:comment : The identity of one or a group of car parks.</para>
    ///   <a href="http://vocab.datex.org/terms#carParkIdentity">datex:carParkIdentity</a>
    /// </summary>
    let carParkIdentity = _prefixId.prefix "carParkIdentity"
    /// <summary>
    ///   <para>rdfs:comment : The percentage value of car parking spaces occupied.</para>
    ///   <a href="http://vocab.datex.org/terms#carParkOccupancy">datex:carParkOccupancy</a>
    /// </summary>
    let carParkOccupancy = _prefixId.prefix "carParkOccupancy"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the status of one or more specified car parks.</para>
    ///   <a href="http://vocab.datex.org/terms#carParkStatus">datex:carParkStatus</a>
    /// </summary>
    let carParkStatus = _prefixId.prefix "carParkStatus"
    let carParksExtension = _prefixId.prefix "carParksExtension"
    let carriageway = _prefixId.prefix "carriageway"
    let catalogueReference = _prefixId.prefix "catalogueReference"
    let catalogueReferenceExtension = _prefixId.prefix "catalogueReferenceExtension"
    let categoryOfPeopleInvolved = _prefixId.prefix "categoryOfPeopleInvolved"
    let cause = _prefixId.prefix "cause"
    /// <summary>
    ///   <para>rdfs:comment : Description of a cause which is not managed by the publication creator (e.g. an off network cause).</para>
    ///   <a href="http://vocab.datex.org/terms#causeDescription">datex:causeDescription</a>
    /// </summary>
    let causeDescription = _prefixId.prefix "causeDescription"
    let causeExtension = _prefixId.prefix "causeExtension"
    /// <summary>
    ///   <para>rdfs:comment : Indicates an external influence that may be the causation of components of a situation.</para>
    ///   <a href="http://vocab.datex.org/terms#causeType">datex:causeType</a>
    /// </summary>
    let causeType = _prefixId.prefix "causeType"
    /// <summary>
    ///   <para>rdfs:comment : Centre point of a circular geometric area.</para>
    ///   <a href="http://vocab.datex.org/terms#centrePoint">datex:centrePoint</a>
    /// </summary>
    let centrePoint = _prefixId.prefix "centrePoint"
    let certifiedSecureParking = _prefixId.prefix "certifiedSecureParking"
    let changeOfOccupiedSpaces = _prefixId.prefix "changeOfOccupiedSpaces"
    let changedFlag = _prefixId.prefix "changedFlag"
    let charge = _prefixId.prefix "charge"
    let chargeBand = _prefixId.prefix "chargeBand"
    let chargeBandByReference = _prefixId.prefix "chargeBandByReference"

    let chargeBandByReferenceExtension = _prefixId.prefix "chargeBandByReferenceExtension"

    let chargeBandExtension = _prefixId.prefix "chargeBandExtension"
    let chargeBandName = _prefixId.prefix "chargeBandName"
    let chargeBandReference = _prefixId.prefix "chargeBandReference"
    let chargeCurrency = _prefixId.prefix "chargeCurrency"
    let chargeExtension = _prefixId.prefix "chargeExtension"
    let chargeInterval = _prefixId.prefix "chargeInterval"
    let chargeOrderIndex = _prefixId.prefix "chargeOrderIndex"
    let chargePaid = _prefixId.prefix "chargePaid"
    let chargeType = _prefixId.prefix "chargeType"
    let chargeTypeDescription = _prefixId.prefix "chargeTypeDescription"
    let chargingStationConnectorType = _prefixId.prefix "chargingStationConnectorType"
    let chargingStationModelType = _prefixId.prefix "chargingStationModelType"
    let chargingStationUsageType = _prefixId.prefix "chargingStationUsageType"
    let chemicalName = _prefixId.prefix "chemicalName"
    let clientIdentification = _prefixId.prefix "clientIdentification"
    let codedReasonForSetting = _prefixId.prefix "codedReasonForSetting"
    let colourName = _prefixId.prefix "colourName"
    let comment = _prefixId.prefix "comment"
    let commentDateTime = _prefixId.prefix "commentDateTime"
    let commentExtension = _prefixId.prefix "commentExtension"
    let commentType = _prefixId.prefix "commentType"
    let comparisonOperator = _prefixId.prefix "comparisonOperator"
    /// <summary>
    ///   <para>rdfs:comment : Defines whether the network management instruction or the control resulting from a network management action is advisory or mandatory.</para>
    ///   <a href="http://vocab.datex.org/terms#complianceOption">datex:complianceOption</a>
    /// </summary>
    let complianceOption = _prefixId.prefix "complianceOption"
    let computationMethod = _prefixId.prefix "computationMethod"
    let computationalMethod = _prefixId.prefix "computationalMethod"
    /// <summary>
    ///   <para>rdfs:comment : An averaged measurement or calculation of the concentration of vehicles at the specified measurement site.</para>
    ///   <a href="http://vocab.datex.org/terms#concentration">datex:concentration</a>
    /// </summary>
    let concentration = _prefixId.prefix "concentration"
    /// <summary>
    ///   <para>rdfs:comment : A value of traffic density expressed in the number of vehicles per kilometre of road.</para>
    ///   <a href="http://vocab.datex.org/terms#concentrationOfVehicles">datex:concentrationOfVehicles</a>
    /// </summary>
    let concentrationOfVehicles = _prefixId.prefix "concentrationOfVehicles"

    let concentrationOfVehiclesValueExtension = _prefixId.prefix "concentrationOfVehiclesValueExtension"

    let conditionsExtension = _prefixId.prefix "conditionsExtension"
    let confidentiality = _prefixId.prefix "confidentiality"
    let confidentialityOverride = _prefixId.prefix "confidentialityOverride"
    /// <summary>
    ///   <para>rdfs:comment : The type of construction work being performed.</para>
    ///   <a href="http://vocab.datex.org/terms#constructionWorkType">datex:constructionWorkType</a>
    /// </summary>
    let constructionWorkType = _prefixId.prefix "constructionWorkType"
    let constructionWorksExtension = _prefixId.prefix "constructionWorksExtension"
    let contactByReferenceExtension = _prefixId.prefix "contactByReferenceExtension"
    /// <summary>
    ///   <para>rdfs:comment : Complete address of the contact. Alternatively use the separate fields to describe the address.</para>
    ///   <a href="http://vocab.datex.org/terms#contactDetailsAddress">datex:contactDetailsAddress</a>
    /// </summary>
    let contactDetailsAddress = _prefixId.prefix "contactDetailsAddress"
    /// <summary>
    ///   <para>rdfs:comment : City of the contact.</para>
    ///   <a href="http://vocab.datex.org/terms#contactDetailsCity">datex:contactDetailsCity</a>
    /// </summary>
    let contactDetailsCity = _prefixId.prefix "contactDetailsCity"
    /// <summary>
    ///   <para>rdfs:comment : E-Mail address of the contact.</para>
    ///   <a href="http://vocab.datex.org/terms#contactDetailsEMail">datex:contactDetailsEMail</a>
    /// </summary>
    let contactDetailsEMail = _prefixId.prefix "contactDetailsEMail"
    let contactDetailsExtension = _prefixId.prefix "contactDetailsExtension"
    /// <summary>
    ///   <para>rdfs:comment : Fax of the contact.</para>
    ///   <a href="http://vocab.datex.org/terms#contactDetailsFax">datex:contactDetailsFax</a>
    /// </summary>
    let contactDetailsFax = _prefixId.prefix "contactDetailsFax"
    /// <summary>
    ///   <para>rdfs:comment : House number of the contact. Supports a multiplicity up to two, to specify lower and upper numbers.</para>
    ///   <a href="http://vocab.datex.org/terms#contactDetailsHouseNumber">datex:contactDetailsHouseNumber</a>
    /// </summary>
    let contactDetailsHouseNumber = _prefixId.prefix "contactDetailsHouseNumber"
    /// <summary>
    ///   <para>rdfs:comment : Language(s) this contact is able to speak resp. understand.</para>
    ///   <a href="http://vocab.datex.org/terms#contactDetailsLanguage">datex:contactDetailsLanguage</a>
    /// </summary>
    let contactDetailsLanguage = _prefixId.prefix "contactDetailsLanguage"
    /// <summary>
    ///   <para>rdfs:comment : Url to define a logo of this contact.</para>
    ///   <a href="http://vocab.datex.org/terms#contactDetailsLogoUrl">datex:contactDetailsLogoUrl</a>
    /// </summary>
    let contactDetailsLogoUrl = _prefixId.prefix "contactDetailsLogoUrl"
    /// <summary>
    ///   <para>rdfs:comment : Additional information relating to the contact.</para>
    ///   <a href="http://vocab.datex.org/terms#contactDetailsMoreInfo">datex:contactDetailsMoreInfo</a>
    /// </summary>
    let contactDetailsMoreInfo = _prefixId.prefix "contactDetailsMoreInfo"
    /// <summary>
    ///   <para>rdfs:comment : Information if the contact in question is a private or public institution.</para>
    ///   <a href="http://vocab.datex.org/terms#contactDetailsOwnership">datex:contactDetailsOwnership</a>
    /// </summary>
    let contactDetailsOwnership = _prefixId.prefix "contactDetailsOwnership"
    /// <summary>
    ///   <para>rdfs:comment : Postcode of the contact.</para>
    ///   <a href="http://vocab.datex.org/terms#contactDetailsPostcode">datex:contactDetailsPostcode</a>
    /// </summary>
    let contactDetailsPostcode = _prefixId.prefix "contactDetailsPostcode"
    /// <summary>
    ///   <para>rdfs:comment : Specification of what service or equipment the contact is responsible for.</para>
    ///   <a href="http://vocab.datex.org/terms#contactDetailsResponsibility">datex:contactDetailsResponsibility</a>
    /// </summary>
    let contactDetailsResponsibility = _prefixId.prefix "contactDetailsResponsibility"
    /// <summary>
    ///   <para>rdfs:comment : Street of the contact.</para>
    ///   <a href="http://vocab.datex.org/terms#contactDetailsStreet">datex:contactDetailsStreet</a>
    /// </summary>
    let contactDetailsStreet = _prefixId.prefix "contactDetailsStreet"
    /// <summary>
    ///   <para>rdfs:comment : Telephone Number of contact.</para>
    ///   <a href="http://vocab.datex.org/terms#contactDetailsTelephoneNumber">datex:contactDetailsTelephoneNumber</a>
    /// </summary>
    let contactDetailsTelephoneNumber = _prefixId.prefix "contactDetailsTelephoneNumber"
    let contactExtension = _prefixId.prefix "contactExtension"
    let contactNotDefined = _prefixId.prefix "contactNotDefined"
    /// <summary>
    ///   <para>rdfs:comment : Name of the organisation or service. Do not use this attribute in combination with role "parkingSiteAddress".</para>
    ///   <a href="http://vocab.datex.org/terms#contactOrganisationName">datex:contactOrganisationName</a>
    /// </summary>
    let contactOrganisationName = _prefixId.prefix "contactOrganisationName"
    /// <summary>
    ///   <para>rdfs:comment : First name of the contact person.</para>
    ///   <a href="http://vocab.datex.org/terms#contactPersonFirstName">datex:contactPersonFirstName</a>
    /// </summary>
    let contactPersonFirstName = _prefixId.prefix "contactPersonFirstName"
    /// <summary>
    ///   <para>rdfs:comment : Name of the contact person.</para>
    ///   <a href="http://vocab.datex.org/terms#contactPersonName">datex:contactPersonName</a>
    /// </summary>
    let contactPersonName = _prefixId.prefix "contactPersonName"
    /// <summary>
    ///   <para>rdfs:comment : The position of the contact person.</para>
    ///   <a href="http://vocab.datex.org/terms#contactPersonPosition">datex:contactPersonPosition</a>
    /// </summary>
    let contactPersonPosition = _prefixId.prefix "contactPersonPosition"
    /// <summary>
    ///   <para>rdfs:comment : Contact information provided by a reference.</para>
    ///   <a href="http://vocab.datex.org/terms#contactReference">datex:contactReference</a>
    /// </summary>
    let contactReference = _prefixId.prefix "contactReference"
    let contactUnknown = _prefixId.prefix "contactUnknown"
    let countedVehicles = _prefixId.prefix "countedVehicles"
    /// <summary>
    ///   <para>rdfs:comment : ISO 3166-1 two character country code.</para>
    ///   <a href="http://vocab.datex.org/terms#country">datex:country</a>
    /// </summary>
    let country = _prefixId.prefix "country"
    let countrySubdivision = _prefixId.prefix "countrySubdivision"
    let county = _prefixId.prefix "county"
    let coveringPetrolStationArea = _prefixId.prefix "coveringPetrolStationArea"
    let d2LogicalModel = _prefixId.prefix "d2LogicalModel"
    let d2LogicalModelExtension = _prefixId.prefix "d2LogicalModelExtension"
    let dangerousGoodsFlashPoint = _prefixId.prefix "dangerousGoodsFlashPoint"
    let dangerousGoodsRegulations = _prefixId.prefix "dangerousGoodsRegulations"
    let dataError = _prefixId.prefix "dataError"
    let dataValueExtension = _prefixId.prefix "dataValueExtension"
    let dateOfCertification = _prefixId.prefix "dateOfCertification"
    /// <summary>
    ///   <para>rdfs:comment : A time stamp defining an instance in time.</para>
    ///   <a href="http://vocab.datex.org/terms#dateTime">datex:dateTime</a>
    /// </summary>
    let dateTime = _prefixId.prefix "dateTime"
    let dateTimeValueExtension = _prefixId.prefix "dateTimeValueExtension"
    let dayWeekMonthExtension = _prefixId.prefix "dayWeekMonthExtension"
    let deIcingApplicationRate = _prefixId.prefix "deIcingApplicationRate"
    let deIcingConcentration = _prefixId.prefix "deIcingConcentration"
    let dedicatedAccess = _prefixId.prefix "dedicatedAccess"
    let dedicatedAccessExtension = _prefixId.prefix "dedicatedAccessExtension"
    let delayBand = _prefixId.prefix "delayBand"
    let delayTimeValue = _prefixId.prefix "delayTimeValue"
    let delays = _prefixId.prefix "delays"
    let delaysExtension = _prefixId.prefix "delaysExtension"
    let delaysType = _prefixId.prefix "delaysType"
    let deleteFilter = _prefixId.prefix "deleteFilter"
    let deleteSubscription = _prefixId.prefix "deleteSubscription"
    let deliveryBreak = _prefixId.prefix "deliveryBreak"
    let deliveryInterval = _prefixId.prefix "deliveryInterval"
    let denyReason = _prefixId.prefix "denyReason"
    let depositionDepth = _prefixId.prefix "depositionDepth"
    /// <summary>
    ///   <para>rdfs:comment : The depth of flooding or of snow on the road.</para>
    ///   <a href="http://vocab.datex.org/terms#depth">datex:depth</a>
    /// </summary>
    let depth = _prefixId.prefix "depth"
    let depthOfSnow = _prefixId.prefix "depthOfSnow"
    let description = _prefixId.prefix "description"
    let descriptor = _prefixId.prefix "descriptor"
    let destination = _prefixId.prefix "destination"
    let destinationExtension = _prefixId.prefix "destinationExtension"
    let destinationMotorway = _prefixId.prefix "destinationMotorway"
    let dewPointTemperature = _prefixId.prefix "dewPointTemperature"
    let dimensionExtension = _prefixId.prefix "dimensionExtension"
    let dimensionHeight = _prefixId.prefix "dimensionHeight"
    let dimensionLength = _prefixId.prefix "dimensionLength"
    /// <summary>
    ///   <para>rdfs:comment : Dimension of a virtual rectangle encapsulating the group of parking spaces. Use 'dimensionUsableArea' to define the total space available for parking within this group. Do not use 'dimensionHeight'.</para>
    ///   <a href="http://vocab.datex.org/terms#dimensionOfGroup">datex:dimensionOfGroup</a>
    /// </summary>
    let dimensionOfGroup = _prefixId.prefix "dimensionOfGroup"
    let dimensionUsableArea = _prefixId.prefix "dimensionUsableArea"
    let dimensionWidth = _prefixId.prefix "dimensionWidth"
    /// <summary>
    ///   <para>rdfs:comment : A value of direction expressed in terms of a bearing measured in whole degrees. Unless otherwise specified the reference direction corresponding to 0 degrees is North.</para>
    ///   <a href="http://vocab.datex.org/terms#directionBearing">datex:directionBearing</a>
    /// </summary>
    let directionBearing = _prefixId.prefix "directionBearing"

    let directionBearingValueExtension = _prefixId.prefix "directionBearingValueExtension"

    let directionBoundAtPoint = _prefixId.prefix "directionBoundAtPoint"
    let directionBoundOnLinearSection = _prefixId.prefix "directionBoundOnLinearSection"
    /// <summary>
    ///   <para>rdfs:comment : A value of direction expressed in terms of points of the compass.</para>
    ///   <a href="http://vocab.datex.org/terms#directionCompass">datex:directionCompass</a>
    /// </summary>
    let directionCompass = _prefixId.prefix "directionCompass"

    let directionCompassValueExtension = _prefixId.prefix "directionCompassValueExtension"

    let directionRelativeAtPoint = _prefixId.prefix "directionRelativeAtPoint"

    let directionRelativeOnLinearSection = _prefixId.prefix "directionRelativeOnLinearSection"

    /// <summary>
    ///   <para>rdfs:comment : A measure of distance along a linear element.</para>
    ///   <a href="http://vocab.datex.org/terms#distanceAlong">datex:distanceAlong</a>
    /// </summary>
    let distanceAlong = _prefixId.prefix "distanceAlong"
    let distanceAlongLinearElement = _prefixId.prefix "distanceAlongLinearElement"

    let distanceAlongLinearElementExtension = _prefixId.prefix "distanceAlongLinearElementExtension"

    let distanceAttribute = _prefixId.prefix "distanceAttribute"

    let distanceFromLinearElementReferentExtension = _prefixId.prefix "distanceFromLinearElementReferentExtension"

    let distanceFromLinearElementStartExtension = _prefixId.prefix "distanceFromLinearElementStartExtension"

    let distanceFromLogicalLocation = _prefixId.prefix "distanceFromLogicalLocation"
    /// <summary>
    ///   <para>rdfs:comment : If the service facility is not located on the parking site itself, its distance can be specified here in metres.</para>
    ///   <a href="http://vocab.datex.org/terms#distanceFromParkingSite">datex:distanceFromParkingSite</a>
    /// </summary>
    let distanceFromParkingSite = _prefixId.prefix "distanceFromParkingSite"
    let distanceFromParkingSpace = _prefixId.prefix "distanceFromParkingSpace"
    let distanceFromPrimaryRoad = _prefixId.prefix "distanceFromPrimaryRoad"
    let distanceFromSituationRecord = _prefixId.prefix "distanceFromSituationRecord"
    /// <summary>
    ///   <para>rdfs:comment : The measured distance between the front of this vehicle and the rear of the preceding one, in metres at the specified measurement site.</para>
    ///   <a href="http://vocab.datex.org/terms#distanceGap">datex:distanceGap</a>
    /// </summary>
    let distanceGap = _prefixId.prefix "distanceGap"
    /// <summary>
    ///   <para>rdfs:comment : The measured distance between the front (respectively back) of this vehicle and the front (respectively  back) of the preceding vehicle at the specified measurement site.</para>
    ///   <a href="http://vocab.datex.org/terms#distanceHeadway">datex:distanceHeadway</a>
    /// </summary>
    let distanceHeadway = _prefixId.prefix "distanceHeadway"
    let distanceToThisRoad = _prefixId.prefix "distanceToThisRoad"
    let disturbanceActivityExtension = _prefixId.prefix "disturbanceActivityExtension"
    /// <summary>
    ///   <para>rdfs:comment : Includes all situations of a public disorder type or of an alert type, with potential to disrupt traffic.</para>
    ///   <a href="http://vocab.datex.org/terms#disturbanceActivityType">datex:disturbanceActivityType</a>
    /// </summary>
    let disturbanceActivityType = _prefixId.prefix "disturbanceActivityType"
    /// <summary>
    ///   <para>rdfs:comment : Description of the driving conditions at the specified location.</para>
    ///   <a href="http://vocab.datex.org/terms#drivingConditionType">datex:drivingConditionType</a>
    /// </summary>
    let drivingConditionType = _prefixId.prefix "drivingConditionType"
    /// <summary>
    ///   <para>rdfs:comment : A period of time expressed in seconds.</para>
    ///   <a href="http://vocab.datex.org/terms#duration">datex:duration</a>
    /// </summary>
    let duration = _prefixId.prefix "duration"
    let durationValueExtension = _prefixId.prefix "durationValueExtension"
    /// <summary>
    ///   <para>rdfs:comment : Indicates that there is dynamic route management for truck parking, i.e. a management system concerning several truck parkings (including this one) along a route.</para>
    ///   <a href="http://vocab.datex.org/terms#dynamicRouteManagement">datex:dynamicRouteManagement</a>
    /// </summary>
    let dynamicRouteManagement = _prefixId.prefix "dynamicRouteManagement"

    let dynamicallyConfigurableDisplayAreas = _prefixId.prefix "dynamicallyConfigurableDisplayAreas"

    let elaboratedData = _prefixId.prefix "elaboratedData"
    let elaboratedDataExtension = _prefixId.prefix "elaboratedDataExtension"
    /// <summary>
    ///   <para>rdfs:comment : The type of fault which is being reported for the specified elaborated data.</para>
    ///   <a href="http://vocab.datex.org/terms#elaboratedDataFault">datex:elaboratedDataFault</a>
    /// </summary>
    let elaboratedDataFault = _prefixId.prefix "elaboratedDataFault"
    let elaboratedDataFaultExtension = _prefixId.prefix "elaboratedDataFaultExtension"

    let elaboratedDataPublicationExtension = _prefixId.prefix "elaboratedDataPublicationExtension"

    let electricCharging = _prefixId.prefix "electricCharging"
    let electricChargingExtension = _prefixId.prefix "electricChargingExtension"
    let emergencyAssemblyPoint = _prefixId.prefix "emergencyAssemblyPoint"
    let emergencyContact = _prefixId.prefix "emergencyContact"
    let emissionClassification = _prefixId.prefix "emissionClassification"
    let end_ = _prefixId.prefix "end"
    let endOfPeriod = _prefixId.prefix "endOfPeriod"
    /// <summary>
    ///   <para>rdfs:comment : The referent at a known location on the linear object which defines the end of the linear element.</para>
    ///   <a href="http://vocab.datex.org/terms#endPointOfLinearElement">datex:endPointOfLinearElement</a>
    /// </summary>
    let endPointOfLinearElement = _prefixId.prefix "endPointOfLinearElement"
    /// <summary>
    ///   <para>rdfs:comment : End of time period.</para>
    ///   <a href="http://vocab.datex.org/terms#endTimeOfPeriod">datex:endTimeOfPeriod</a>
    /// </summary>
    let endTimeOfPeriod = _prefixId.prefix "endTimeOfPeriod"
    let entireArea = _prefixId.prefix "entireArea"
    let entranceFull = _prefixId.prefix "entranceFull"
    /// <summary>
    ///   <para>rdfs:comment : The specified entry on to another road at which the alternative route commences.</para>
    ///   <a href="http://vocab.datex.org/terms#entry">datex:entry</a>
    /// </summary>
    let entry = _prefixId.prefix "entry"

    let environmentalObstructionExtension = _prefixId.prefix "environmentalObstructionExtension"

    /// <summary>
    ///   <para>rdfs:comment : Characterization of an obstruction on the road resulting from an environmental cause.</para>
    ///   <a href="http://vocab.datex.org/terms#environmentalObstructionType">datex:environmentalObstructionType</a>
    /// </summary>
    let environmentalObstructionType = _prefixId.prefix "environmentalObstructionType"
    let equipmentExtension = _prefixId.prefix "equipmentExtension"
    let equipmentOperationStatus = _prefixId.prefix "equipmentOperationStatus"

    let equipmentOrServiceFacilityIdentifier = _prefixId.prefix "equipmentOrServiceFacilityIdentifier"

    let equipmentOrServiceFacilityIndex = _prefixId.prefix "equipmentOrServiceFacilityIndex"

    let equipmentOrSystemFaultExtension = _prefixId.prefix "equipmentOrSystemFaultExtension"

    /// <summary>
    ///   <para>rdfs:comment : Failure, malfunction or non operational condition of equipment or system.</para>
    ///   <a href="http://vocab.datex.org/terms#equipmentOrSystemFaultType">datex:equipmentOrSystemFaultType</a>
    /// </summary>
    let equipmentOrSystemFaultType = _prefixId.prefix "equipmentOrSystemFaultType"
    /// <summary>
    ///   <para>rdfs:comment : One type of equipment, that is available on the parking site.</para>
    ///   <a href="http://vocab.datex.org/terms#equipmentType">datex:equipmentType</a>
    /// </summary>
    let equipmentType = _prefixId.prefix "equipmentType"
    let eventParkingType = _prefixId.prefix "eventParkingType"
    let eventParkingType2 = _prefixId.prefix "eventParkingType2"
    let exceptionPeriod = _prefixId.prefix "exceptionPeriod"
    let exchange = _prefixId.prefix "exchange"
    let exchangeExtension = _prefixId.prefix "exchangeExtension"
    /// <summary>
    ///   <para>rdfs:comment : The specified exit from the normal route/road at which the alternative route commences.</para>
    ///   <a href="http://vocab.datex.org/terms#exit">datex:exit</a>
    /// </summary>
    let exit = _prefixId.prefix "exit"
    /// <summary>
    ///   <para>rdfs:comment : The rate at which vehicles are exiting the car park.</para>
    ///   <a href="http://vocab.datex.org/terms#exitRate">datex:exitRate</a>
    /// </summary>
    let exitRate = _prefixId.prefix "exitRate"
    /// <summary>
    ///   <para>rdfs:comment : The time when an individual vehicle leaves a detection zone.</para>
    ///   <a href="http://vocab.datex.org/terms#exitTime">datex:exitTime</a>
    /// </summary>
    let exitTime = _prefixId.prefix "exitTime"
    let externalLocationCode = _prefixId.prefix "externalLocationCode"
    let externalReferencing = _prefixId.prefix "externalReferencing"
    let externalReferencingExtension = _prefixId.prefix "externalReferencingExtension"
    let externalReferencingSystem = _prefixId.prefix "externalReferencingSystem"
    let faultCreationTime = _prefixId.prefix "faultCreationTime"
    let faultDescription = _prefixId.prefix "faultDescription"
    let faultExtension = _prefixId.prefix "faultExtension"
    let faultIdentifier = _prefixId.prefix "faultIdentifier"
    let faultLastUpdateTime = _prefixId.prefix "faultLastUpdateTime"
    let faultSeverity = _prefixId.prefix "faultSeverity"
    /// <summary>
    ///   <para>rdfs:comment : The type of equipment or system which is faulty, malfunctioning or not in a fully operational state.</para>
    ///   <a href="http://vocab.datex.org/terms#faultyEquipmentOrSystemType">datex:faultyEquipmentOrSystemType</a>
    /// </summary>
    let faultyEquipmentOrSystemType = _prefixId.prefix "faultyEquipmentOrSystemType"
    let feedDescription = _prefixId.prefix "feedDescription"
    let feedType = _prefixId.prefix "feedType"
    let fillRate = _prefixId.prefix "fillRate"
    let filterEnd = _prefixId.prefix "filterEnd"
    let filterExitManagement = _prefixId.prefix "filterExitManagement"
    let filterExitManagementExtension = _prefixId.prefix "filterExitManagementExtension"
    let filterOperationApproved = _prefixId.prefix "filterOperationApproved"
    let filterOutOfRange = _prefixId.prefix "filterOutOfRange"
    let filterReference = _prefixId.prefix "filterReference"
    let filterReferenceExtension = _prefixId.prefix "filterReferenceExtension"
    let firstDirection = _prefixId.prefix "firstDirection"
    /// <summary>
    ///   <para>rdfs:comment : A value of distance expressed in metres in a floating point format.</para>
    ///   <a href="http://vocab.datex.org/terms#floatingPointMetreDistance">datex:floatingPointMetreDistance</a>
    /// </summary>
    let floatingPointMetreDistance = _prefixId.prefix "floatingPointMetreDistance"

    let floatingPointMetreDistanceValueExtension = _prefixId.prefix "floatingPointMetreDistanceValueExtension"

    let footpath = _prefixId.prefix "footpath"

    /// <summary>
    ///   <para>rdfs:comment : The characteristics of those vehicles for which the network management is applicable.rdfs:comment : Used to define the vehicle characteristics to which the TrafficValue is applicable primarily in Elaborated Data Publications, but may also be used in Measured Data Publications to override vehicle characteristics defined for the measurement site.</para>
    ///   <a href="http://vocab.datex.org/terms#forVehiclesWithCharacteristicsOf">datex:forVehiclesWithCharacteristicsOf</a>
    /// </summary>
    let forVehiclesWithCharacteristicsOf = _prefixId.prefix "forVehiclesWithCharacteristicsOf"

    let forecast = _prefixId.prefix "forecast"
    /// <summary>
    ///   <para>rdfs:comment : The default value for the publication of whether the elaborated data is a forecast (true = forecast).</para>
    ///   <a href="http://vocab.datex.org/terms#forecastDefault">datex:forecastDefault</a>
    /// </summary>
    let forecastDefault = _prefixId.prefix "forecastDefault"
    /// <summary>
    ///   <para>rdfs:comment : A single non junction point on the road network which is framed between two other specified points on the road network.</para>
    ///   <a href="http://vocab.datex.org/terms#framedPoint">datex:framedPoint</a>
    /// </summary>
    let framedPoint = _prefixId.prefix "framedPoint"
    /// <summary>
    ///   <para>rdfs:comment : The free flow speed expected under ideal conditions, corresponding to the freeFlowTravelTime.</para>
    ///   <a href="http://vocab.datex.org/terms#freeFlowSpeed">datex:freeFlowSpeed</a>
    /// </summary>
    let freeFlowSpeed = _prefixId.prefix "freeFlowSpeed"
    /// <summary>
    ///   <para>rdfs:comment : The travel time which would be expected under ideal free flow conditions.</para>
    ///   <a href="http://vocab.datex.org/terms#freeFlowTravelTime">datex:freeFlowTravelTime</a>
    /// </summary>
    let freeFlowTravelTime = _prefixId.prefix "freeFlowTravelTime"
    let freeOfCharge = _prefixId.prefix "freeOfCharge"
    /// <summary>
    ///   <para>rdfs:comment : The location at the up stream end of the section of road which frames the TPEGFramedPoint.</para>
    ///   <a href="http://vocab.datex.org/terms#from">datex:from</a>
    /// </summary>
    let from = _prefixId.prefix "from"
    let fromPoint = _prefixId.prefix "fromPoint"
    /// <summary>
    ///   <para>rdfs:comment : A known location along the linear element from which the distanceAlong is measured, termed the "fromReferent" in ISO 19148. </para>
    ///   <a href="http://vocab.datex.org/terms#fromReferent">datex:fromReferent</a>
    /// </summary>
    let fromReferent = _prefixId.prefix "fromReferent"
    let fuelType = _prefixId.prefix "fuelType"
    let fuelType2 = _prefixId.prefix "fuelType2"
    let fullDecreasing = _prefixId.prefix "fullDecreasing"
    let fullIncreasing = _prefixId.prefix "fullIncreasing"

    let generalInstructionOrMessageToRoadUsersExtension = _prefixId.prefix "generalInstructionOrMessageToRoadUsersExtension"

    /// <summary>
    ///   <para>rdfs:comment : General instruction that is issued by the network/road operator which is applicable to drivers and sometimes passengers.</para>
    ///   <a href="http://vocab.datex.org/terms#generalInstructionToRoadUsersType">datex:generalInstructionToRoadUsersType</a>
    /// </summary>
    let generalInstructionToRoadUsersType = _prefixId.prefix "generalInstructionToRoadUsersType"

    /// <summary>
    ///   <para>rdfs:comment : General message that is issued by the network/road operator which is applicable to drivers and sometimes passengers, e.g. details about an amber alert (missing or abducted child alert).</para>
    ///   <a href="http://vocab.datex.org/terms#generalMessageToRoadUsers">datex:generalMessageToRoadUsers</a>
    /// </summary>
    let generalMessageToRoadUsers = _prefixId.prefix "generalMessageToRoadUsers"

    let generalNetworkManagementExtension = _prefixId.prefix "generalNetworkManagementExtension"

    /// <summary>
    ///   <para>rdfs:comment : The type of traffic management action instigated by the network/road operator.</para>
    ///   <a href="http://vocab.datex.org/terms#generalNetworkManagementType">datex:generalNetworkManagementType</a>
    /// </summary>
    let generalNetworkManagementType = _prefixId.prefix "generalNetworkManagementType"
    let generalObstructionExtension = _prefixId.prefix "generalObstructionExtension"
    let generalPublicComment = _prefixId.prefix "generalPublicComment"
    let genericPublicationExtension = _prefixId.prefix "genericPublicationExtension"
    /// <summary>
    ///   <para>rdfs:comment : The name of the generic publication.</para>
    ///   <a href="http://vocab.datex.org/terms#genericPublicationName">datex:genericPublicationName</a>
    /// </summary>
    let genericPublicationName = _prefixId.prefix "genericPublicationName"

    let genericSituationRecordExtension = _prefixId.prefix "genericSituationRecordExtension"

    /// <summary>
    ///   <para>rdfs:comment : The name of the GenericSituationRecord.</para>
    ///   <a href="http://vocab.datex.org/terms#genericSituationRecordName">datex:genericSituationRecordName</a>
    /// </summary>
    let genericSituationRecordName = _prefixId.prefix "genericSituationRecordName"
    let grossVehicleWeight = _prefixId.prefix "grossVehicleWeight"
    let grossWeightCharacteristic = _prefixId.prefix "grossWeightCharacteristic"

    let grossWeightCharacteristicExtension = _prefixId.prefix "grossWeightCharacteristicExtension"

    /// <summary>
    ///   <para>rdfs:comment : Override validity of AssignedParkingSpaces: True = Parking space declaration is valid now; False = Parking space declaration is invalid now; Omitted = Static validity information is significant (if static validity is omitted too, declaration is valid).</para>
    ///   <a href="http://vocab.datex.org/terms#groupDeclarationValidNow">datex:groupDeclarationValidNow</a>
    /// </summary>
    let groupDeclarationValidNow = _prefixId.prefix "groupDeclarationValidNow"
    let groupIndex = _prefixId.prefix "groupIndex"
    let groupOfLocations = _prefixId.prefix "groupOfLocations"
    let groupOfLocationsExtension = _prefixId.prefix "groupOfLocationsExtension"
    let groupOfParkingSitesExtension = _prefixId.prefix "groupOfParkingSitesExtension"
    /// <summary>
    ///   <para>rdfs:comment : The status of the group of parking sites (available spaces or not).</para>
    ///   <a href="http://vocab.datex.org/terms#groupOfParkingSitesStatus">datex:groupOfParkingSitesStatus</a>
    /// </summary>
    let groupOfParkingSitesStatus = _prefixId.prefix "groupOfParkingSitesStatus"

    let groupOfParkingSitesStatusExtension = _prefixId.prefix "groupOfParkingSitesStatusExtension"

    /// <summary>
    ///   <para>rdfs:comment : The type of this group of parking sites.</para>
    ///   <a href="http://vocab.datex.org/terms#groupOfParkingSitesType">datex:groupOfParkingSitesType</a>
    /// </summary>
    let groupOfParkingSitesType = _prefixId.prefix "groupOfParkingSitesType"
    let groupOfParkingSpaces = _prefixId.prefix "groupOfParkingSpaces"
    /// <summary>
    ///   <para>rdfs:comment : True: The group of parking spaces is closed / not accessible. False or omitted: The group of parking spaces is accessible. This is no statement about its occupation.</para>
    ///   <a href="http://vocab.datex.org/terms#groupOfParkingSpacesClosed">datex:groupOfParkingSpacesClosed</a>
    /// </summary>
    let groupOfParkingSpacesClosed = _prefixId.prefix "groupOfParkingSpacesClosed"
    let groupOfParkingSpacesExtension = _prefixId.prefix "groupOfParkingSpacesExtension"
    let groupOfParkingSpacesReference = _prefixId.prefix "groupOfParkingSpacesReference"
    let groupOfParkingSpacesStatus = _prefixId.prefix "groupOfParkingSpacesStatus"

    let groupOfParkingSpacesStatusExtension = _prefixId.prefix "groupOfParkingSpacesStatusExtension"

    let groupOfPeopleInvolved = _prefixId.prefix "groupOfPeopleInvolved"

    let groupOfPeopleInvolvedExtension = _prefixId.prefix "groupOfPeopleInvolvedExtension"

    let groupOfVehiclesInvolved = _prefixId.prefix "groupOfVehiclesInvolved"

    let groupOfVehiclesInvolvedExtension = _prefixId.prefix "groupOfVehiclesInvolvedExtension"

    let hazardCodeIdentification = _prefixId.prefix "hazardCodeIdentification"
    let hazardCodeVersionNumber = _prefixId.prefix "hazardCodeVersionNumber"
    let hazardSubstanceItemPageNumber = _prefixId.prefix "hazardSubstanceItemPageNumber"

    let hazardousGoodsAssociatedWithVehicle = _prefixId.prefix "hazardousGoodsAssociatedWithVehicle"

    let hazardousMaterials = _prefixId.prefix "hazardousMaterials"
    let hazardousMaterialsExtension = _prefixId.prefix "hazardousMaterialsExtension"
    let headerInformation = _prefixId.prefix "headerInformation"
    let headerInformationExtension = _prefixId.prefix "headerInformationExtension"
    let heaviestAxleWeight = _prefixId.prefix "heaviestAxleWeight"

    let heaviestAxleWeightCharacteristic = _prefixId.prefix "heaviestAxleWeightCharacteristic"

    let heaviestAxleWeightCharacteristicExtension = _prefixId.prefix "heaviestAxleWeightCharacteristicExtension"

    let height = _prefixId.prefix "height"
    let heightAttribute = _prefixId.prefix "heightAttribute"
    let heightCharacteristic = _prefixId.prefix "heightCharacteristic"
    let heightCharacteristicExtension = _prefixId.prefix "heightCharacteristicExtension"
    let heightGradeOfLinearSection = _prefixId.prefix "heightGradeOfLinearSection"
    let heightGradeOfPoint = _prefixId.prefix "heightGradeOfPoint"
    let heightType = _prefixId.prefix "heightType"
    /// <summary>
    ///   <para>rdfs:comment : Highest floor of the parking site. It is possible to have negative values here in case it is underground only. Must be higher or equal than 'lowestFloor'.</para>
    ///   <a href="http://vocab.datex.org/terms#highestFloor">datex:highestFloor</a>
    /// </summary>
    let highestFloor = _prefixId.prefix "highestFloor"
    let historicalStartDate = _prefixId.prefix "historicalStartDate"
    let historicalStopDate = _prefixId.prefix "historicalStopDate"
    let humidity = _prefixId.prefix "humidity"
    let humidityExtension = _prefixId.prefix "humidityExtension"
    let humidityInformationExtension = _prefixId.prefix "humidityInformationExtension"
    let id = _prefixId.prefix "id"
    /// <summary>
    ///   <para>rdfs:comment : Points to another instance of 'GroupOfParkingSpaces', which is identical from a local point of view. To be used when defining mixed parking areas with different time slots.</para>
    ///   <a href="http://vocab.datex.org/terms#identicalToGroup">datex:identicalToGroup</a>
    /// </summary>
    let identicalToGroup = _prefixId.prefix "identicalToGroup"
    /// <summary>
    ///   <para>rdfs:comment : Points to another instance of 'ParkingSpace', which is identical from a local point of view (i.e. which is the same parking space). To be used when defining mixed parking areas (with using different time slots).</para>
    ///   <a href="http://vocab.datex.org/terms#identicalToParkingSpace">datex:identicalToParkingSpace</a>
    /// </summary>
    let identicalToParkingSpace = _prefixId.prefix "identicalToParkingSpace"
    /// <summary>
    ///   <para>rdfs:comment : A descriptor for describing a junction by identifying the intersecting roads at a road junction.</para>
    ///   <a href="http://vocab.datex.org/terms#ilc">datex:ilc</a>
    /// </summary>
    let ilc = _prefixId.prefix "ilc"
    let impact = _prefixId.prefix "impact"
    let impactExtension = _prefixId.prefix "impactExtension"
    let index = _prefixId.prefix "index"
    let individualCharge = _prefixId.prefix "individualCharge"
    let individualChargeExtension = _prefixId.prefix "individualChargeExtension"

    let individualVehicleDataValuesExtension = _prefixId.prefix "individualVehicleDataValuesExtension"

    /// <summary>
    ///   <para>rdfs:comment : The measured speed of the individual vehicle at the specified measurement site.</para>
    ///   <a href="http://vocab.datex.org/terms#individualVehicleSpeed">datex:individualVehicleSpeed</a>
    /// </summary>
    let individualVehicleSpeed = _prefixId.prefix "individualVehicleSpeed"
    let informationStatus = _prefixId.prefix "informationStatus"

    let infrastructureDamageObstructionExtension = _prefixId.prefix "infrastructureDamageObstructionExtension"

    /// <summary>
    ///   <para>rdfs:comment : Characterization of an obstruction on the road resulting from the failure or damage of infrastructure on, under, above or close to the road.</para>
    ///   <a href="http://vocab.datex.org/terms#infrastructureDamageType">datex:infrastructureDamageType</a>
    /// </summary>
    let infrastructureDamageType = _prefixId.prefix "infrastructureDamageType"
    let injuryStatus = _prefixId.prefix "injuryStatus"
    /// <summary>
    ///   <para>rdfs:comment : A value of distance expressed in metres in a non negative integer format.</para>
    ///   <a href="http://vocab.datex.org/terms#integerMetreDistance">datex:integerMetreDistance</a>
    /// </summary>
    let integerMetreDistance = _prefixId.prefix "integerMetreDistance"

    let integerMetreDistanceValueExtension = _prefixId.prefix "integerMetreDistanceValueExtension"

    let interUrbanParkingSiteExtension = _prefixId.prefix "interUrbanParkingSiteExtension"

    /// <summary>
    ///   <para>rdfs:comment : Defines whether the interurban parking site is located in or nearby a motorway context, is a layby or on-street parking.</para>
    ///   <a href="http://vocab.datex.org/terms#interUrbanParkingSiteLocation">datex:interUrbanParkingSiteLocation</a>
    /// </summary>
    let interUrbanParkingSiteLocation = _prefixId.prefix "interUrbanParkingSiteLocation"

    /// <summary>
    ///   <para>rdfs:comment : A referent at a known location on the linear object which is neither the start or end of the linear element.</para>
    ///   <a href="http://vocab.datex.org/terms#intermediatePointOnLinearElement">datex:intermediatePointOnLinearElement</a>
    /// </summary>
    let intermediatePointOnLinearElement = _prefixId.prefix "intermediatePointOnLinearElement"

    let internationalIdentifierExtension = _prefixId.prefix "internationalIdentifierExtension"

    let intersectWithApplicableDays = _prefixId.prefix "intersectWithApplicableDays"
    let involvementRole = _prefixId.prefix "involvementRole"

    let itineraryByIndexedLocationsExtension = _prefixId.prefix "itineraryByIndexedLocationsExtension"

    let itineraryByReferenceExtension = _prefixId.prefix "itineraryByReferenceExtension"
    let itineraryExtension = _prefixId.prefix "itineraryExtension"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the stated termination point of the transit journey.</para>
    ///   <a href="http://vocab.datex.org/terms#journeyDestination">datex:journeyDestination</a>
    /// </summary>
    let journeyDestination = _prefixId.prefix "journeyDestination"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the stated starting point of the transit journey.</para>
    ///   <a href="http://vocab.datex.org/terms#journeyOrigin">datex:journeyOrigin</a>
    /// </summary>
    let journeyOrigin = _prefixId.prefix "journeyOrigin"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a transit service journey number.</para>
    ///   <a href="http://vocab.datex.org/terms#journeyReference">datex:journeyReference</a>
    /// </summary>
    let journeyReference = _prefixId.prefix "journeyReference"
    let junction = _prefixId.prefix "junction"
    let junctionClassification = _prefixId.prefix "junctionClassification"
    let junctionExtension = _prefixId.prefix "junctionExtension"
    /// <summary>
    ///   <para>rdfs:comment : Name of the junction.</para>
    ///   <a href="http://vocab.datex.org/terms#junctionName">datex:junctionName</a>
    /// </summary>
    let junctionName = _prefixId.prefix "junctionName"
    let junctionNumber = _prefixId.prefix "junctionNumber"
    let keepAlive = _prefixId.prefix "keepAlive"
    let keyCatalogueReference = _prefixId.prefix "keyCatalogueReference"
    let keyFilterReference = _prefixId.prefix "keyFilterReference"
    /// <summary>
    ///   <para>rdfs:comment : A value defining the amount of a substance in a given volume (concentration) expressed in kilograms per cubic metre.</para>
    ///   <a href="http://vocab.datex.org/terms#kilogramsConcentration">datex:kilogramsConcentration</a>
    /// </summary>
    let kilogramsConcentration = _prefixId.prefix "kilogramsConcentration"

    let kilogramsConcentrationValueExtension = _prefixId.prefix "kilogramsConcentrationValueExtension"

    let labelSecurityLevel = _prefixId.prefix "labelSecurityLevel"

    let labelSecurityLevelSelfAssessment = _prefixId.prefix "labelSecurityLevelSelfAssessment"

    let labelServiceLevel = _prefixId.prefix "labelServiceLevel"

    let labelServiceLevelSelfAssessment = _prefixId.prefix "labelServiceLevelSelfAssessment"

    let lane = _prefixId.prefix "lane"
    let lang = _prefixId.prefix "lang"
    let lastCalibration = _prefixId.prefix "lastCalibration"
    let lastUpdated = _prefixId.prefix "lastUpdated"
    let latitude = _prefixId.prefix "latitude"
    let legendCodeListIdentifier = _prefixId.prefix "legendCodeListIdentifier"
    let lengthAffected = _prefixId.prefix "lengthAffected"
    let lengthAttribute = _prefixId.prefix "lengthAttribute"
    let lengthCharacteristic = _prefixId.prefix "lengthCharacteristic"
    let lengthCharacteristicExtension = _prefixId.prefix "lengthCharacteristicExtension"
    let lifeCycleManagement = _prefixId.prefix "lifeCycleManagement"
    let lifeCycleManagementExtension = _prefixId.prefix "lifeCycleManagementExtension"
    let lineIndex = _prefixId.prefix "lineIndex"
    let linearElement = _prefixId.prefix "linearElement"
    let linearElementByCodeExtension = _prefixId.prefix "linearElementByCodeExtension"

    let linearElementByPointsExtension = _prefixId.prefix "linearElementByPointsExtension"

    let linearElementExtension = _prefixId.prefix "linearElementExtension"
    /// <summary>
    ///   <para>rdfs:comment : An identifier or code of a linear element (or link) in the road network reference model that is specified in the LinearElement class. </para>
    ///   <a href="http://vocab.datex.org/terms#linearElementIdentifier">datex:linearElementIdentifier</a>
    /// </summary>
    let linearElementIdentifier = _prefixId.prefix "linearElementIdentifier"
    let linearElementNature = _prefixId.prefix "linearElementNature"
    let linearElementReferenceModel = _prefixId.prefix "linearElementReferenceModel"

    let linearElementReferenceModelVersion = _prefixId.prefix "linearElementReferenceModelVersion"

    let linearExtension = _prefixId.prefix "linearExtension"

    let linearPredefinedLocationReference = _prefixId.prefix "linearPredefinedLocationReference"

    let linearTrafficView = _prefixId.prefix "linearTrafficView"
    let linearTrafficViewExtension = _prefixId.prefix "linearTrafficViewExtension"
    let linearWithinLinearElement = _prefixId.prefix "linearWithinLinearElement"

    let linearWithinLinearElementExtension = _prefixId.prefix "linearWithinLinearElementExtension"

    let loadType = _prefixId.prefix "loadType"
    let loadType2 = _prefixId.prefix "loadType2"
    let location = _prefixId.prefix "location"
    let locationByReferenceExtension = _prefixId.prefix "locationByReferenceExtension"

    let locationCharacteristicsOverride = _prefixId.prefix "locationCharacteristicsOverride"

    let locationCharacteristicsOverrideExtension = _prefixId.prefix "locationCharacteristicsOverrideExtension"

    /// <summary>
    ///   <para>rdfs:comment : Linear location defined by a specific Alert-C location.</para>
    ///   <a href="http://vocab.datex.org/terms#locationCodeForLinearLocation">datex:locationCodeForLinearLocation</a>
    /// </summary>
    let locationCodeForLinearLocation = _prefixId.prefix "locationCodeForLinearLocation"
    /// <summary>
    ///   <para>rdfs:comment : A location contained in a non ordered group of locations.</para>
    ///   <a href="http://vocab.datex.org/terms#locationContainedInGroup">datex:locationContainedInGroup</a>
    /// </summary>
    let locationContainedInGroup = _prefixId.prefix "locationContainedInGroup"
    /// <summary>
    ///   <para>rdfs:comment : A location contained in an itinerary (i.e. an ordered set of locations defining a route or itinerary).</para>
    ///   <a href="http://vocab.datex.org/terms#locationContainedInItinerary">datex:locationContainedInItinerary</a>
    /// </summary>
    let locationContainedInItinerary = _prefixId.prefix "locationContainedInItinerary"
    let locationDescriptor = _prefixId.prefix "locationDescriptor"
    let locationExtension = _prefixId.prefix "locationExtension"
    /// <summary>
    ///   <para>rdfs:comment : A location which may be used by clients for visual display on user interfaces.</para>
    ///   <a href="http://vocab.datex.org/terms#locationForDisplay">datex:locationForDisplay</a>
    /// </summary>
    let locationForDisplay = _prefixId.prefix "locationForDisplay"
    let locationPrecision = _prefixId.prefix "locationPrecision"
    let longitude = _prefixId.prefix "longitude"
    /// <summary>
    ///   <para>rdfs:comment : Lowest floor of the parking site. Positive values may apply in case it is over ground only. Must be lower or equal than 'highestFloor'.</para>
    ///   <a href="http://vocab.datex.org/terms#lowestFloor">datex:lowestFloor</a>
    /// </summary>
    let lowestFloor = _prefixId.prefix "lowestFloor"
    let maintenanceVehicleActions = _prefixId.prefix "maintenanceVehicleActions"
    let maintenanceVehicles = _prefixId.prefix "maintenanceVehicles"
    let maintenanceVehiclesExtension = _prefixId.prefix "maintenanceVehiclesExtension"
    let maintenanceWorksExtension = _prefixId.prefix "maintenanceWorksExtension"
    /// <summary>
    ///   <para>rdfs:comment : A reference to another situation record produced by the same publication creator which defines a cause of the event defined here.</para>
    ///   <a href="http://vocab.datex.org/terms#managedCause">datex:managedCause</a>
    /// </summary>
    let managedCause = _prefixId.prefix "managedCause"
    let managedCauseExtension = _prefixId.prefix "managedCauseExtension"
    let managedLocation = _prefixId.prefix "managedLocation"
    let managedLogicalLocation = _prefixId.prefix "managedLogicalLocation"

    let managedLogicalLocationOverride = _prefixId.prefix "managedLogicalLocationOverride"

    let management = _prefixId.prefix "management"
    let managementExtension = _prefixId.prefix "managementExtension"
    let mareNostrumCompliant = _prefixId.prefix "mareNostrumCompliant"
    let maxFontHeight = _prefixId.prefix "maxFontHeight"
    let maxFontSpacing = _prefixId.prefix "maxFontSpacing"
    let maxFontWidth = _prefixId.prefix "maxFontWidth"
    let maxIterationsOfCharge = _prefixId.prefix "maxIterationsOfCharge"
    let maxNumberOfCharacters = _prefixId.prefix "maxNumberOfCharacters"
    let maxNumberOfRows = _prefixId.prefix "maxNumberOfRows"
    let maxNumberOfSequentialPages = _prefixId.prefix "maxNumberOfSequentialPages"

    let maxNumberOfSequentialPictograms = _prefixId.prefix "maxNumberOfSequentialPictograms"

    let maxPictogramLuminanceLevel = _prefixId.prefix "maxPictogramLuminanceLevel"
    let maxTextLuminanceLevel = _prefixId.prefix "maxTextLuminanceLevel"
    let maximumCurrent = _prefixId.prefix "maximumCurrent"
    let maximumDuration = _prefixId.prefix "maximumDuration"
    let maximumParkingDuration = _prefixId.prefix "maximumParkingDuration"
    /// <summary>
    ///   <para>rdfs:comment : Dimension of the largest space within this group (i.e. there must be at least one space of this dimension). If the comparison of dimension values is not unique, the length is decisive.</para>
    ///   <a href="http://vocab.datex.org/terms#maximumParkingSpaceDimension">datex:maximumParkingSpaceDimension</a>
    /// </summary>
    let maximumParkingSpaceDimension = _prefixId.prefix "maximumParkingSpaceDimension"
    let maximumPermittedAxleWeight = _prefixId.prefix "maximumPermittedAxleWeight"
    let maximumTemperature = _prefixId.prefix "maximumTemperature"
    let maximumWindSpeed = _prefixId.prefix "maximumWindSpeed"

    let measuredDataPublicationExtension = _prefixId.prefix "measuredDataPublicationExtension"

    let measuredValue = _prefixId.prefix "measuredValue"
    let measuredValueExtension = _prefixId.prefix "measuredValueExtension"
    let measuredValueIndex = _prefixId.prefix "measuredValueIndex"
    let measuredVehicles = _prefixId.prefix "measuredVehicles"
    let measurementEquipmentFault = _prefixId.prefix "measurementEquipmentFault"

    let measurementEquipmentFaultExtension = _prefixId.prefix "measurementEquipmentFaultExtension"

    let measurementEquipmentReference = _prefixId.prefix "measurementEquipmentReference"
    let measurementEquipmentTypeUsed = _prefixId.prefix "measurementEquipmentTypeUsed"
    let measurementInterval = _prefixId.prefix "measurementInterval"
    let measurementLanesOverride = _prefixId.prefix "measurementLanesOverride"
    let measurementOrCalcualtionTime = _prefixId.prefix "measurementOrCalcualtionTime"

    let measurementOrCalculatedTimePrecision = _prefixId.prefix "measurementOrCalculatedTimePrecision"

    let measurementOrCalculationPeriod = _prefixId.prefix "measurementOrCalculationPeriod"

    let measurementOrCalculationTime = _prefixId.prefix "measurementOrCalculationTime"
    let measurementSide = _prefixId.prefix "measurementSide"
    let measurementSiteIdentification = _prefixId.prefix "measurementSiteIdentification"
    let measurementSiteLocation = _prefixId.prefix "measurementSiteLocation"
    let measurementSiteName = _prefixId.prefix "measurementSiteName"
    let measurementSiteNumberOfLanes = _prefixId.prefix "measurementSiteNumberOfLanes"
    let measurementSiteRecord = _prefixId.prefix "measurementSiteRecord"

    let measurementSiteRecordExtension = _prefixId.prefix "measurementSiteRecordExtension"

    let measurementSiteRecordVersionTime = _prefixId.prefix "measurementSiteRecordVersionTime"

    let measurementSiteReference = _prefixId.prefix "measurementSiteReference"
    let measurementSiteTable = _prefixId.prefix "measurementSiteTable"
    let measurementSiteTableExtension = _prefixId.prefix "measurementSiteTableExtension"

    let measurementSiteTableIdentification = _prefixId.prefix "measurementSiteTableIdentification"

    let measurementSiteTablePublicationExtension = _prefixId.prefix "measurementSiteTablePublicationExtension"

    /// <summary>
    ///   <para>rdfs:comment : A reference to a versioned Measurement Site table.</para>
    ///   <a href="http://vocab.datex.org/terms#measurementSiteTableReference">datex:measurementSiteTableReference</a>
    /// </summary>
    let measurementSiteTableReference = _prefixId.prefix "measurementSiteTableReference"

    let measurementSpecificCharacteristics = _prefixId.prefix "measurementSpecificCharacteristics"

    let measurementSpecificCharacteristicsExtension = _prefixId.prefix "measurementSpecificCharacteristicsExtension"

    let measurementTimeDefault = _prefixId.prefix "measurementTimeDefault"
    let messageIndex = _prefixId.prefix "messageIndex"
    let messageSetBy = _prefixId.prefix "messageSetBy"
    /// <summary>
    ///   <para>rdfs:comment : A value of the amount of a substance in a given volume (concentration) expressed in µg/m3 (microgrammes/cubic metre).</para>
    ///   <a href="http://vocab.datex.org/terms#microgramsConcentration">datex:microgramsConcentration</a>
    /// </summary>
    let microgramsConcentration = _prefixId.prefix "microgramsConcentration"

    let microgramsConcentrationValueExtension = _prefixId.prefix "microgramsConcentrationValueExtension"

    /// <summary>
    ///   <para>rdfs:comment : A value of precipitation intensity expressed in units of millimetres per hour.</para>
    ///   <a href="http://vocab.datex.org/terms#millimetresPerHourIntensity">datex:millimetresPerHourIntensity</a>
    /// </summary>
    let millimetresPerHourIntensity = _prefixId.prefix "millimetresPerHourIntensity"
    let minFontHeight = _prefixId.prefix "minFontHeight"
    let minFontSpacing = _prefixId.prefix "minFontSpacing"
    let minFontWidth = _prefixId.prefix "minFontWidth"
    let minIterationsOfCharge = _prefixId.prefix "minIterationsOfCharge"
    /// <summary>
    ///   <para>rdfs:comment : The minimum number of persons required in a vehicle in order for it to be allowed to transit the specified road section.</para>
    ///   <a href="http://vocab.datex.org/terms#minimumCarOccupancy">datex:minimumCarOccupancy</a>
    /// </summary>
    let minimumCarOccupancy = _prefixId.prefix "minimumCarOccupancy"
    /// <summary>
    ///   <para>rdfs:comment : Lower dimension boundaries for all spaces within the group. Note that there must not exist a space with this dimension, but each space's dimension values must be equal or higher.</para>
    ///   <a href="http://vocab.datex.org/terms#minimumParkingSpaceDimension">datex:minimumParkingSpaceDimension</a>
    /// </summary>
    let minimumParkingSpaceDimension = _prefixId.prefix "minimumParkingSpaceDimension"
    let minimumTemperature = _prefixId.prefix "minimumTemperature"
    let minimumVisibilityDistance = _prefixId.prefix "minimumVisibilityDistance"
    let mobility = _prefixId.prefix "mobility"
    let mobilityExtension = _prefixId.prefix "mobilityExtension"
    /// <summary>
    ///   <para>rdfs:comment : Mobility of the activity.</para>
    ///   <a href="http://vocab.datex.org/terms#mobilityOfActivity">datex:mobilityOfActivity</a>
    /// </summary>
    let mobilityOfActivity = _prefixId.prefix "mobilityOfActivity"
    /// <summary>
    ///   <para>rdfs:comment : The mobility of the obstruction.</para>
    ///   <a href="http://vocab.datex.org/terms#mobilityOfObstruction">datex:mobilityOfObstruction</a>
    /// </summary>
    let mobilityOfObstruction = _prefixId.prefix "mobilityOfObstruction"
    let mobilityType = _prefixId.prefix "mobilityType"
    let modelBaseVersion = _prefixId.prefix "modelBaseVersion"
    let motorway = _prefixId.prefix "motorway"
    /// <summary>
    ///   <para>rdfs:comment : A descriptive name which helps to identify the non junction point. At least one descriptor must identify the road on which the point is located, i.e. must be of type 'linkName' or 'localLinkName'.rdfs:comment : A name which identifies a junction point on the road networkrdfs:comment : Name of area.</para>
    ///   <a href="http://vocab.datex.org/terms#name">datex:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    let nameOfRoad = _prefixId.prefix "nameOfRoad"
    let nameOrBrand = _prefixId.prefix "nameOrBrand"
    let namedArea = _prefixId.prefix "namedArea"
    let namedAreaExtension = _prefixId.prefix "namedAreaExtension"
    let nation = _prefixId.prefix "nation"
    let nationalIdentifier = _prefixId.prefix "nationalIdentifier"
    let networkLocationExtension = _prefixId.prefix "networkLocationExtension"
    let networkManagementExtension = _prefixId.prefix "networkManagementExtension"
    /// <summary>
    ///   <para>rdfs:comment : Indication of whether precipitation is present or not. True indicates there is no precipitation.</para>
    ///   <a href="http://vocab.datex.org/terms#noPrecipitation">datex:noPrecipitation</a>
    /// </summary>
    let noPrecipitation = _prefixId.prefix "noPrecipitation"
    let nonGeneralPublicComment = _prefixId.prefix "nonGeneralPublicComment"
    let nonManagedCauseExtension = _prefixId.prefix "nonManagedCauseExtension"

    let nonOrderedLocationGroupByListExtension = _prefixId.prefix "nonOrderedLocationGroupByListExtension"

    let nonOrderedLocationGroupByReferenceExtension = _prefixId.prefix "nonOrderedLocationGroupByReferenceExtension"

    let nonOrderedLocationsExtension = _prefixId.prefix "nonOrderedLocationsExtension"

    let nonRoadEventInformationExtension = _prefixId.prefix "nonRoadEventInformationExtension"

    /// <summary>
    ///   <para>rdfs:comment : The type of road conditions which are not related to the weather.</para>
    ///   <a href="http://vocab.datex.org/terms#nonWeatherRelatedRoadConditionType">datex:nonWeatherRelatedRoadConditionType</a>
    /// </summary>
    let nonWeatherRelatedRoadConditionType = _prefixId.prefix "nonWeatherRelatedRoadConditionType"

    let nonWeatherRelatedRoadConditionsExtension = _prefixId.prefix "nonWeatherRelatedRoadConditionsExtension"

    /// <summary>
    ///   <para>rdfs:comment : The travel time which is expected for the given period (e.g. date/time, holiday status etc.) and any known quasi-static conditions (e.g. long term roadworks). This value is derived from historical analysis.</para>
    ///   <a href="http://vocab.datex.org/terms#normallyExpectedTravelTime">datex:normallyExpectedTravelTime</a>
    /// </summary>
    let normallyExpectedTravelTime = _prefixId.prefix "normallyExpectedTravelTime"
    let numberOfAxles = _prefixId.prefix "numberOfAxles"
    let numberOfAxlesCharacteristic = _prefixId.prefix "numberOfAxlesCharacteristic"

    let numberOfAxlesCharacteristicExtension = _prefixId.prefix "numberOfAxlesCharacteristicExtension"

    let numberOfChargingPoints = _prefixId.prefix "numberOfChargingPoints"

    let numberOfEquipmentOrServiceFacility = _prefixId.prefix "numberOfEquipmentOrServiceFacility"

    let numberOfEquipmentOrServiceFacilityOverride = _prefixId.prefix "numberOfEquipmentOrServiceFacilityOverride"

    let numberOfIncomingVehicles = _prefixId.prefix "numberOfIncomingVehicles"
    let numberOfIncompleteInputs = _prefixId.prefix "numberOfIncompleteInputs"
    let numberOfInputValuesUsed = _prefixId.prefix "numberOfInputValuesUsed"
    let numberOfLanesRestricted = _prefixId.prefix "numberOfLanesRestricted"
    let numberOfMaintenanceVehicles = _prefixId.prefix "numberOfMaintenanceVehicles"
    /// <summary>
    ///   <para>rdfs:comment : The number of obstructions that are partly or wholly blocking the road.</para>
    ///   <a href="http://vocab.datex.org/terms#numberOfObstructions">datex:numberOfObstructions</a>
    /// </summary>
    let numberOfObstructions = _prefixId.prefix "numberOfObstructions"
    let numberOfOperationalLanes = _prefixId.prefix "numberOfOperationalLanes"
    let numberOfOutgoingVehicles = _prefixId.prefix "numberOfOutgoingVehicles"
    let numberOfPeople = _prefixId.prefix "numberOfPeople"
    let numberOfPictogramDisplayAreas = _prefixId.prefix "numberOfPictogramDisplayAreas"
    /// <summary>
    ///   <para>rdfs:comment : The quantity of sub items to this service facility type, e.g. the total number of restaurant places or fuel dispensers etc.</para>
    ///   <a href="http://vocab.datex.org/terms#numberOfSubitems">datex:numberOfSubitems</a>
    /// </summary>
    let numberOfSubitems = _prefixId.prefix "numberOfSubitems"
    let numberOfSubitemsOverride = _prefixId.prefix "numberOfSubitemsOverride"
    let numberOfSubjects = _prefixId.prefix "numberOfSubjects"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the number of vacant parking spaces available in a specified parking area.</para>
    ///   <a href="http://vocab.datex.org/terms#numberOfVacantParkingSpaces">datex:numberOfVacantParkingSpaces</a>
    /// </summary>
    let numberOfVacantParkingSpaces = _prefixId.prefix "numberOfVacantParkingSpaces"
    let numberOfVehicles = _prefixId.prefix "numberOfVehicles"
    /// <summary>
    ///   <para>rdfs:comment : The number of vehicles waiting in a queue.</para>
    ///   <a href="http://vocab.datex.org/terms#numberOfVehiclesWaiting">datex:numberOfVehiclesWaiting</a>
    /// </summary>
    let numberOfVehiclesWaiting = _prefixId.prefix "numberOfVehiclesWaiting"
    let numberOfVms = _prefixId.prefix "numberOfVms"
    /// <summary>
    ///   <para>rdfs:comment : The obstructing vehicle.</para>
    ///   <a href="http://vocab.datex.org/terms#obstructingVehicle">datex:obstructingVehicle</a>
    /// </summary>
    let obstructingVehicle = _prefixId.prefix "obstructingVehicle"
    let obstructionExtension = _prefixId.prefix "obstructionExtension"
    /// <summary>
    ///   <para>rdfs:comment : Characterization of the type of general obstruction.</para>
    ///   <a href="http://vocab.datex.org/terms#obstructionType">datex:obstructionType</a>
    /// </summary>
    let obstructionType = _prefixId.prefix "obstructionType"
    /// <summary>
    ///   <para>rdfs:comment : An averaged measurement or calculation of the percentage of time that a section of road at the specified measurement site is occupied by vehicles.</para>
    ///   <a href="http://vocab.datex.org/terms#occupancy">datex:occupancy</a>
    /// </summary>
    let occupancy = _prefixId.prefix "occupancy"
    /// <summary>
    ///   <para>rdfs:comment : A measured or calculated absolut change of occupied parking spaces within a specified time expressed as integer.</para>
    ///   <a href="http://vocab.datex.org/terms#occupancyChange">datex:occupancyChange</a>
    /// </summary>
    let occupancyChange = _prefixId.prefix "occupancyChange"
    let occupancyChangeValueExtension = _prefixId.prefix "occupancyChangeValueExtension"
    /// <summary>
    ///   <para>rdfs:comment : Number of currently occupied spaces.</para>
    ///   <a href="http://vocab.datex.org/terms#occupiedSpaces">datex:occupiedSpaces</a>
    /// </summary>
    let occupiedSpaces = _prefixId.prefix "occupiedSpaces"
    let offsetDistance = _prefixId.prefix "offsetDistance"
    let offsetDistanceExtension = _prefixId.prefix "offsetDistanceExtension"
    let onlyAssignedParking = _prefixId.prefix "onlyAssignedParking"
    let ontology = _prefixId.prefix "ontology"
    let openAllYear = _prefixId.prefix "openAllYear"
    let openingTimes = _prefixId.prefix "openingTimes"
    let openingTimesExtension = _prefixId.prefix "openingTimesExtension"
    let openingTimesNotSpecified = _prefixId.prefix "openingTimesNotSpecified"
    let openingTimesUnknown = _prefixId.prefix "openingTimesUnknown"
    let openlrAreaLocationReference = _prefixId.prefix "openlrAreaLocationReference"

    let openlrAreaLocationReferenceExtension = _prefixId.prefix "openlrAreaLocationReferenceExtension"

    let openlrBaseLocationReferencePointExtension = _prefixId.prefix "openlrBaseLocationReferencePointExtension"

    let openlrBasePointLocationExtension = _prefixId.prefix "openlrBasePointLocationExtension"

    let openlrBearing = _prefixId.prefix "openlrBearing"

    let openlrCircleLocationReferenceExtension = _prefixId.prefix "openlrCircleLocationReferenceExtension"

    let openlrClosedLineLocationReferenceExtension = _prefixId.prefix "openlrClosedLineLocationReferenceExtension"

    /// <summary>
    ///   <para>rdfs:comment : The coordinate of the actual point of interest</para>
    ///   <a href="http://vocab.datex.org/terms#openlrCoordinate">datex:openlrCoordinate</a>
    /// </summary>
    let openlrCoordinate = _prefixId.prefix "openlrCoordinate"
    let openlrDistanceToNextLRPoint = _prefixId.prefix "openlrDistanceToNextLRPoint"
    let openlrExtendedArea = _prefixId.prefix "openlrExtendedArea"
    let openlrExtendedLinear = _prefixId.prefix "openlrExtendedLinear"
    let openlrExtendedPoint = _prefixId.prefix "openlrExtendedPoint"
    let openlrFormOfWay = _prefixId.prefix "openlrFormOfWay"
    let openlrFunctionalRoadClass = _prefixId.prefix "openlrFunctionalRoadClass"
    let openlrGeoCoordinate = _prefixId.prefix "openlrGeoCoordinate"
    let openlrGeoCoordinateExtension = _prefixId.prefix "openlrGeoCoordinateExtension"
    let openlrGridAttributes = _prefixId.prefix "openlrGridAttributes"
    let openlrGridAttributesExtension = _prefixId.prefix "openlrGridAttributesExtension"

    let openlrGridLocationReferenceExtension = _prefixId.prefix "openlrGridLocationReferenceExtension"

    let openlrLastLine = _prefixId.prefix "openlrLastLine"

    let openlrLastLocationReferencePoint = _prefixId.prefix "openlrLastLocationReferencePoint"

    let openlrLastLocationReferencePointExtension = _prefixId.prefix "openlrLastLocationReferencePointExtension"

    let openlrLineAttributes = _prefixId.prefix "openlrLineAttributes"
    let openlrLineAttributesExtension = _prefixId.prefix "openlrLineAttributesExtension"

    let openlrLineLocationReferenceExtension = _prefixId.prefix "openlrLineLocationReferenceExtension"

    let openlrLocationReferencePoint = _prefixId.prefix "openlrLocationReferencePoint"

    let openlrLocationReferencePointExtension = _prefixId.prefix "openlrLocationReferencePointExtension"

    let openlrLowerLeft = _prefixId.prefix "openlrLowerLeft"
    let openlrLowestFRCToNextLRPoint = _prefixId.prefix "openlrLowestFRCToNextLRPoint"
    let openlrNegativeOffset = _prefixId.prefix "openlrNegativeOffset"
    let openlrNumColumns = _prefixId.prefix "openlrNumColumns"
    let openlrNumRows = _prefixId.prefix "openlrNumRows"
    let openlrOffsets = _prefixId.prefix "openlrOffsets"
    let openlrOffsetsExtension = _prefixId.prefix "openlrOffsetsExtension"
    let openlrOrientation = _prefixId.prefix "openlrOrientation"
    let openlrPathAttributes = _prefixId.prefix "openlrPathAttributes"
    let openlrPathAttributesExtension = _prefixId.prefix "openlrPathAttributesExtension"
    let openlrPoiWithAccessPoint = _prefixId.prefix "openlrPoiWithAccessPoint"

    let openlrPoiWithAccessPointExtension = _prefixId.prefix "openlrPoiWithAccessPointExtension"

    let openlrPointAlongLine = _prefixId.prefix "openlrPointAlongLine"
    let openlrPointAlongLineExtension = _prefixId.prefix "openlrPointAlongLineExtension"
    let openlrPointLocationReference = _prefixId.prefix "openlrPointLocationReference"

    let openlrPointLocationReferenceExtension = _prefixId.prefix "openlrPointLocationReferenceExtension"

    let openlrPolygonCorners = _prefixId.prefix "openlrPolygonCorners"
    let openlrPolygonCornersExtension = _prefixId.prefix "openlrPolygonCornersExtension"

    let openlrPolygonLocationReferenceExtension = _prefixId.prefix "openlrPolygonLocationReferenceExtension"

    let openlrPositiveOffset = _prefixId.prefix "openlrPositiveOffset"
    let openlrRectangle = _prefixId.prefix "openlrRectangle"
    let openlrRectangleExtension = _prefixId.prefix "openlrRectangleExtension"

    let openlrRectangleLocationReferenceExtension = _prefixId.prefix "openlrRectangleLocationReferenceExtension"

    let openlrSideOfRoad = _prefixId.prefix "openlrSideOfRoad"
    let openlrUpperRight = _prefixId.prefix "openlrUpperRight"
    let operatingMode = _prefixId.prefix "operatingMode"
    let operationFreeOfEmission = _prefixId.prefix "operationFreeOfEmission"
    let operator = _prefixId.prefix "operator"
    let operatorAction = _prefixId.prefix "operatorAction"
    let operatorActionExtension = _prefixId.prefix "operatorActionExtension"
    /// <summary>
    ///   <para>rdfs:comment : The status of the defined operator action.</para>
    ///   <a href="http://vocab.datex.org/terms#operatorActionStatus">datex:operatorActionStatus</a>
    /// </summary>
    let operatorActionStatus = _prefixId.prefix "operatorActionStatus"
    let oppositeDirection = _prefixId.prefix "oppositeDirection"
    let originalNumberOfLanes = _prefixId.prefix "originalNumberOfLanes"

    let otherEquipmentOrServiceFacility = _prefixId.prefix "otherEquipmentOrServiceFacility"

    /// <summary>
    ///   <para>rdfs:comment : A descriptive name which helps to identify the junction point.</para>
    ///   <a href="http://vocab.datex.org/terms#otherName">datex:otherName</a>
    /// </summary>
    let otherName = _prefixId.prefix "otherName"
    let otherPaymentCard = _prefixId.prefix "otherPaymentCard"
    let otherPaymentCardBrand = _prefixId.prefix "otherPaymentCardBrand"
    let otherPaymentCardBrands = _prefixId.prefix "otherPaymentCardBrands"
    let otherPaymentCards = _prefixId.prefix "otherPaymentCards"
    let overallEndTime = _prefixId.prefix "overallEndTime"
    let overallPeriodExtension = _prefixId.prefix "overallPeriodExtension"
    let overallSeverity = _prefixId.prefix "overallSeverity"
    let overallStartTime = _prefixId.prefix "overallStartTime"
    let overcrowding = _prefixId.prefix "overcrowding"
    let overcrowdingLevel1 = _prefixId.prefix "overcrowdingLevel1"
    let overcrowdingLevel2 = _prefixId.prefix "overcrowdingLevel2"
    let overrideParkingThresholds = _prefixId.prefix "overrideParkingThresholds"
    let overrunning = _prefixId.prefix "overrunning"
    let owner = _prefixId.prefix "owner"
    let pageNumber = _prefixId.prefix "pageNumber"
    /// <summary>
    ///   <para>rdfs:comment : An exit from the parking facility onto the road network from any parking space unless separate exits are specified for assigned parking spaces, in which case this is an exit from only the principal parking spaces.</para>
    ///   <a href="http://vocab.datex.org/terms#parkingAccess">datex:parkingAccess</a>
    /// </summary>
    let parkingAccess = _prefixId.prefix "parkingAccess"
    let parkingAccessExtension = _prefixId.prefix "parkingAccessExtension"
    let parkingAccessStatus = _prefixId.prefix "parkingAccessStatus"
    let parkingAccessStatusExtension = _prefixId.prefix "parkingAccessStatusExtension"
    let parkingAdditionalSecurity = _prefixId.prefix "parkingAdditionalSecurity"
    let parkingAlias = _prefixId.prefix "parkingAlias"
    let parkingAssignmentExtension = _prefixId.prefix "parkingAssignmentExtension"
    let parkingColour = _prefixId.prefix "parkingColour"
    let parkingConditions = _prefixId.prefix "parkingConditions"
    let parkingDescription = _prefixId.prefix "parkingDescription"
    let parkingDuration = _prefixId.prefix "parkingDuration"

    let parkingEquipmentOrServiceFacility = _prefixId.prefix "parkingEquipmentOrServiceFacility"

    let parkingEquipmentOrServiceFacilityExtension = _prefixId.prefix "parkingEquipmentOrServiceFacilityExtension"

    let parkingEquipmentOrServiceFacilityStatus = _prefixId.prefix "parkingEquipmentOrServiceFacilityStatus"

    let parkingEquipmentOrServiceFacilityStatusExtension = _prefixId.prefix "parkingEquipmentOrServiceFacilityStatusExtension"

    let parkingFault = _prefixId.prefix "parkingFault"
    let parkingFloorOrLevel = _prefixId.prefix "parkingFloorOrLevel"
    let parkingLastMaximumOccupancy = _prefixId.prefix "parkingLastMaximumOccupancy"
    /// <summary>
    ///   <para>rdfs:comment : Layout of the parking site.</para>
    ///   <a href="http://vocab.datex.org/terms#parkingLayout">datex:parkingLayout</a>
    /// </summary>
    let parkingLayout = _prefixId.prefix "parkingLayout"
    let parkingLocation = _prefixId.prefix "parkingLocation"
    let parkingMode = _prefixId.prefix "parkingMode"
    let parkingName = _prefixId.prefix "parkingName"
    let parkingNotAllowed = _prefixId.prefix "parkingNotAllowed"
    let parkingNumberOfOccupiedSpaces = _prefixId.prefix "parkingNumberOfOccupiedSpaces"
    /// <summary>
    ///   <para>rdfs:comment : Number of parking spaces (attribute is used for a parking record as well as for a group of parking spaces).</para>
    ///   <a href="http://vocab.datex.org/terms#parkingNumberOfSpaces">datex:parkingNumberOfSpaces</a>
    /// </summary>
    let parkingNumberOfSpaces = _prefixId.prefix "parkingNumberOfSpaces"
    let parkingNumberOfSpacesOverride = _prefixId.prefix "parkingNumberOfSpacesOverride"
    let parkingNumberOfVacantSpaces = _prefixId.prefix "parkingNumberOfVacantSpaces"

    let parkingNumberOfVacantSpacesGraded = _prefixId.prefix "parkingNumberOfVacantSpacesGraded"

    let parkingNumberOfVacantSpacesHigherThan = _prefixId.prefix "parkingNumberOfVacantSpacesHigherThan"

    let parkingNumberOfVacantSpacesLowerThan = _prefixId.prefix "parkingNumberOfVacantSpacesLowerThan"

    let parkingNumberOfVehicles = _prefixId.prefix "parkingNumberOfVehicles"
    let parkingOccupancy = _prefixId.prefix "parkingOccupancy"
    let parkingOccupancyExtension = _prefixId.prefix "parkingOccupancyExtension"
    let parkingOccupancyGraded = _prefixId.prefix "parkingOccupancyGraded"
    let parkingOccupancyTrend = _prefixId.prefix "parkingOccupancyTrend"
    let parkingOccupanyDetectionType = _prefixId.prefix "parkingOccupanyDetectionType"
    /// <summary>
    ///   <para>rdfs:comment : A special location not available in the enumeration. Use literal 'other' in this case.</para>
    ///   <a href="http://vocab.datex.org/terms#parkingOtherSpecialLocation">datex:parkingOtherSpecialLocation</a>
    /// </summary>
    let parkingOtherSpecialLocation = _prefixId.prefix "parkingOtherSpecialLocation"
    let parkingPeriod = _prefixId.prefix "parkingPeriod"
    let parkingPermit = _prefixId.prefix "parkingPermit"
    let parkingPermitExtension = _prefixId.prefix "parkingPermitExtension"
    let parkingPermitIdentifier = _prefixId.prefix "parkingPermitIdentifier"
    let parkingPermitScheme = _prefixId.prefix "parkingPermitScheme"
    let parkingPermitType = _prefixId.prefix "parkingPermitType"

    let parkingPrincipalNumberOfSpaces = _prefixId.prefix "parkingPrincipalNumberOfSpaces"

    let parkingQueueingTime = _prefixId.prefix "parkingQueueingTime"
    let parkingRecord = _prefixId.prefix "parkingRecord"
    let parkingRecordDimension = _prefixId.prefix "parkingRecordDimension"
    let parkingRecordExtension = _prefixId.prefix "parkingRecordExtension"
    let parkingRecordReference = _prefixId.prefix "parkingRecordReference"
    let parkingRecordStatus = _prefixId.prefix "parkingRecordStatus"
    let parkingRecordStatusExtension = _prefixId.prefix "parkingRecordStatusExtension"
    let parkingRecordVersionTime = _prefixId.prefix "parkingRecordVersionTime"
    /// <summary>
    ///   <para>rdfs:comment : Indication of whether a parking reservation service is available and/or mandatory.</para>
    ///   <a href="http://vocab.datex.org/terms#parkingReservation">datex:parkingReservation</a>
    /// </summary>
    let parkingReservation = _prefixId.prefix "parkingReservation"
    let parkingRoute = _prefixId.prefix "parkingRoute"
    let parkingRouteActive = _prefixId.prefix "parkingRouteActive"

    let parkingRouteByReferenceExtension = _prefixId.prefix "parkingRouteByReferenceExtension"

    let parkingRouteColour = _prefixId.prefix "parkingRouteColour"
    let parkingRouteDetailsExtension = _prefixId.prefix "parkingRouteDetailsExtension"
    /// <summary>
    ///   <para>rdfs:comment : The direction of traffic, for which the parking route can be used. If not specified, the route can be used in the order of the given locations.</para>
    ///   <a href="http://vocab.datex.org/terms#parkingRouteDirection">datex:parkingRouteDirection</a>
    /// </summary>
    let parkingRouteDirection = _prefixId.prefix "parkingRouteDirection"
    /// <summary>
    ///   <para>rdfs:comment : Additional directions of traffic, for which the parking route can be used. If not specified, the route can be used in the order of the given locations.</para>
    ///   <a href="http://vocab.datex.org/terms#parkingRouteDirection2">datex:parkingRouteDirection2</a>
    /// </summary>
    let parkingRouteDirection2 = _prefixId.prefix "parkingRouteDirection2"
    let parkingRouteExtension = _prefixId.prefix "parkingRouteExtension"
    /// <summary>
    ///   <para>rdfs:comment : An index, which can identify some icon for visualisation of the route. Note that form and usage of this index as well as the icons itself are not further determined here.</para>
    ///   <a href="http://vocab.datex.org/terms#parkingRouteIconIndex">datex:parkingRouteIconIndex</a>
    /// </summary>
    let parkingRouteIconIndex = _prefixId.prefix "parkingRouteIconIndex"
    /// <summary>
    ///   <para>rdfs:comment : Name of the parking route.</para>
    ///   <a href="http://vocab.datex.org/terms#parkingRouteName">datex:parkingRouteName</a>
    /// </summary>
    let parkingRouteName = _prefixId.prefix "parkingRouteName"
    /// <summary>
    ///   <para>rdfs:comment : A reference to a parking route.</para>
    ///   <a href="http://vocab.datex.org/terms#parkingRouteReference">datex:parkingRouteReference</a>
    /// </summary>
    let parkingRouteReference = _prefixId.prefix "parkingRouteReference"
    let parkingRouteStatus = _prefixId.prefix "parkingRouteStatus"
    let parkingRouteStatusExtension = _prefixId.prefix "parkingRouteStatusExtension"
    /// <summary>
    ///   <para>rdfs:comment : The type of parking route. If not specified, the route is designed for any type of vehicles.</para>
    ///   <a href="http://vocab.datex.org/terms#parkingRouteType">datex:parkingRouteType</a>
    /// </summary>
    let parkingRouteType = _prefixId.prefix "parkingRouteType"
    let parkingSecurity = _prefixId.prefix "parkingSecurity"

    let parkingSecurityNationalClassification = _prefixId.prefix "parkingSecurityNationalClassification"

    let parkingSite = _prefixId.prefix "parkingSite"
    /// <summary>
    ///   <para>rdfs:comment : Information about the parking site itself (address etc.). The 'GroupOfLocations' association must not be used for this role.</para>
    ///   <a href="http://vocab.datex.org/terms#parkingSiteAddress">datex:parkingSiteAddress</a>
    /// </summary>
    let parkingSiteAddress = _prefixId.prefix "parkingSiteAddress"
    /// <summary>
    ///   <para>rdfs:comment : Parking sites of this collection defined by reference.</para>
    ///   <a href="http://vocab.datex.org/terms#parkingSiteByReference">datex:parkingSiteByReference</a>
    /// </summary>
    let parkingSiteByReference = _prefixId.prefix "parkingSiteByReference"
    let parkingSiteExtension = _prefixId.prefix "parkingSiteExtension"
    /// <summary>
    ///   <para>rdfs:comment : The parking site is full at the specified floor(s).</para>
    ///   <a href="http://vocab.datex.org/terms#parkingSiteFullAtFloor">datex:parkingSiteFullAtFloor</a>
    /// </summary>
    let parkingSiteFullAtFloor = _prefixId.prefix "parkingSiteFullAtFloor"
    /// <summary>
    ///   <para>rdfs:comment : The opening status of the parking site (open or not).</para>
    ///   <a href="http://vocab.datex.org/terms#parkingSiteOpeningStatus">datex:parkingSiteOpeningStatus</a>
    /// </summary>
    let parkingSiteOpeningStatus = _prefixId.prefix "parkingSiteOpeningStatus"
    /// <summary>
    ///   <para>rdfs:comment : The overcrowding status of the parking site. Choose between using a two-stage approach or the more general statement ‘(not) overcrowding’. You can sharpen this information by using the ‘Thresholds’ component. </para>
    ///   <a href="http://vocab.datex.org/terms#parkingSiteOvercrowdingStatus">datex:parkingSiteOvercrowdingStatus</a>
    /// </summary>
    let parkingSiteOvercrowdingStatus = _prefixId.prefix "parkingSiteOvercrowdingStatus"
    /// <summary>
    ///   <para>rdfs:comment : The status of the parking site (spaces available or not).</para>
    ///   <a href="http://vocab.datex.org/terms#parkingSiteStatus">datex:parkingSiteStatus</a>
    /// </summary>
    let parkingSiteStatus = _prefixId.prefix "parkingSiteStatus"
    let parkingSiteStatusExtension = _prefixId.prefix "parkingSiteStatusExtension"
    let parkingSpace = _prefixId.prefix "parkingSpace"
    let parkingSpaceAccessibility = _prefixId.prefix "parkingSpaceAccessibility"
    let parkingSpaceBasics = _prefixId.prefix "parkingSpaceBasics"
    let parkingSpaceBasicsExtension = _prefixId.prefix "parkingSpaceBasicsExtension"
    let parkingSpaceClosed = _prefixId.prefix "parkingSpaceClosed"

    let parkingSpaceDeclarationValidNow = _prefixId.prefix "parkingSpaceDeclarationValidNow"

    /// <summary>
    ///   <para>rdfs:comment : Dimension of the parking space (not all dimension attributes need to be provided). If the parking space is not rectangular, its dimension is specified as the smallest rectangle fitting inside its shape.</para>
    ///   <a href="http://vocab.datex.org/terms#parkingSpaceDimension">datex:parkingSpaceDimension</a>
    /// </summary>
    let parkingSpaceDimension = _prefixId.prefix "parkingSpaceDimension"
    let parkingSpaceExtension = _prefixId.prefix "parkingSpaceExtension"
    let parkingSpaceIndex = _prefixId.prefix "parkingSpaceIndex"
    let parkingSpaceOccupied = _prefixId.prefix "parkingSpaceOccupied"
    let parkingSpaceOrGroupIdentifier = _prefixId.prefix "parkingSpaceOrGroupIdentifier"
    let parkingSpacePhysics = _prefixId.prefix "parkingSpacePhysics"
    let parkingSpaceReference = _prefixId.prefix "parkingSpaceReference"
    let parkingSpaceStatus = _prefixId.prefix "parkingSpaceStatus"
    let parkingSpaceStatusExtension = _prefixId.prefix "parkingSpaceStatusExtension"
    /// <summary>
    ///   <para>rdfs:comment : The special location of the parking site.</para>
    ///   <a href="http://vocab.datex.org/terms#parkingSpecialLocation">datex:parkingSpecialLocation</a>
    /// </summary>
    let parkingSpecialLocation = _prefixId.prefix "parkingSpecialLocation"
    let parkingStandardsAndSecurity = _prefixId.prefix "parkingStandardsAndSecurity"

    let parkingStandardsAndSecurityExtension = _prefixId.prefix "parkingStandardsAndSecurityExtension"

    let parkingStatusColourMapping = _prefixId.prefix "parkingStatusColourMapping"

    let parkingStatusColourMappingExtension = _prefixId.prefix "parkingStatusColourMappingExtension"

    let parkingStatusDescription = _prefixId.prefix "parkingStatusDescription"
    let parkingStatusOriginTime = _prefixId.prefix "parkingStatusOriginTime"
    let parkingStatusPublication = _prefixId.prefix "parkingStatusPublication"
    let parkingStatusTime = _prefixId.prefix "parkingStatusTime"

    let parkingStatusTimeOffsetToOrigin = _prefixId.prefix "parkingStatusTimeOffsetToOrigin"

    let parkingStatusValidity = _prefixId.prefix "parkingStatusValidity"

    let parkingStatusValidityExtension = _prefixId.prefix "parkingStatusValidityExtension"

    let parkingSupervision = _prefixId.prefix "parkingSupervision"
    let parkingTable = _prefixId.prefix "parkingTable"
    let parkingTableExtension = _prefixId.prefix "parkingTableExtension"
    let parkingTableName = _prefixId.prefix "parkingTableName"
    let parkingTablePublication = _prefixId.prefix "parkingTablePublication"
    let parkingTableReference = _prefixId.prefix "parkingTableReference"
    let parkingTableVersionTime = _prefixId.prefix "parkingTableVersionTime"
    let parkingThresholds = _prefixId.prefix "parkingThresholds"
    let parkingThresholdsExtension = _prefixId.prefix "parkingThresholdsExtension"
    /// <summary>
    ///   <para>rdfs:comment : Defines the type of this group specification.</para>
    ///   <a href="http://vocab.datex.org/terms#parkingTypeOfGroup">datex:parkingTypeOfGroup</a>
    /// </summary>
    let parkingTypeOfGroup = _prefixId.prefix "parkingTypeOfGroup"
    let parkingUsageScenario = _prefixId.prefix "parkingUsageScenario"
    let parkingUsageScenarioExtension = _prefixId.prefix "parkingUsageScenarioExtension"
    let parkingUsageScenarioStatus = _prefixId.prefix "parkingUsageScenarioStatus"

    let parkingUsageScenarioStatusExtension = _prefixId.prefix "parkingUsageScenarioStatusExtension"

    let parkingVMS = _prefixId.prefix "parkingVMS"
    let parkingVMSExtension = _prefixId.prefix "parkingVMSExtension"
    let parkingVehicle = _prefixId.prefix "parkingVehicle"
    let parkingVehicleExtension = _prefixId.prefix "parkingVehicleExtension"
    let parkingVehiclesPublication = _prefixId.prefix "parkingVehiclesPublication"
    /// <summary>
    ///   <para>rdfs:comment : Name or identifier of a parking zone this parking site belongs to. To be filled with the string value 'True', if there is a parking zone with unknown name.</para>
    ///   <a href="http://vocab.datex.org/terms#parkingZone">datex:parkingZone</a>
    /// </summary>
    let parkingZone = _prefixId.prefix "parkingZone"
    /// <summary>
    ///   <para>rdfs:comment : The time elapsed between an individual vehicle entering a detection zone and exiting the same detection zone as detected by entry and exit sensors.</para>
    ///   <a href="http://vocab.datex.org/terms#passageDurationTime">datex:passageDurationTime</a>
    /// </summary>
    let passageDurationTime = _prefixId.prefix "passageDurationTime"
    let payloadPublication = _prefixId.prefix "payloadPublication"
    let payloadPublicationExtension = _prefixId.prefix "payloadPublicationExtension"
    let paymentAdditionalDescription = _prefixId.prefix "paymentAdditionalDescription"
    let paymentCard = _prefixId.prefix "paymentCard"
    let paymentCardBrand = _prefixId.prefix "paymentCardBrand"
    let paymentCardBrands = _prefixId.prefix "paymentCardBrands"
    let paymentCards = _prefixId.prefix "paymentCards"
    let paymentMode = _prefixId.prefix "paymentMode"
    /// <summary>
    ///   <para>rdfs:comment : An averaged measurement or calculation of flow rate defined in terms of the number of passenger car units passing the specified measurement site.</para>
    ///   <a href="http://vocab.datex.org/terms#pcuFlow">datex:pcuFlow</a>
    /// </summary>
    let pcuFlow = _prefixId.prefix "pcuFlow"
    /// <summary>
    ///   <para>rdfs:comment : A value of passenger car unit flow rate expressed in passenger car units per hour.</para>
    ///   <a href="http://vocab.datex.org/terms#pcuFlowRate">datex:pcuFlowRate</a>
    /// </summary>
    let pcuFlowRate = _prefixId.prefix "pcuFlowRate"
    let pcuFlowValueExtension = _prefixId.prefix "pcuFlowValueExtension"
    /// <summary>
    ///   <para>rdfs:comment : A value expressed as a percentage.</para>
    ///   <a href="http://vocab.datex.org/terms#percentage">datex:percentage</a>
    /// </summary>
    let percentage = _prefixId.prefix "percentage"
    /// <summary>
    ///   <para>rdfs:comment : A measure of distance along a linear element from the start of the element expressed as a percentage of the total length of the linear object.</para>
    ///   <a href="http://vocab.datex.org/terms#percentageDistanceAlong">datex:percentageDistanceAlong</a>
    /// </summary>
    let percentageDistanceAlong = _prefixId.prefix "percentageDistanceAlong"

    let percentageDistanceAlongLinearElementExtension = _prefixId.prefix "percentageDistanceAlongLinearElementExtension"

    /// <summary>
    ///   <para>rdfs:comment : An averaged measurement or calculation of the percentage of long vehicles contained in the traffic flow at the specified measurement site.</para>
    ///   <a href="http://vocab.datex.org/terms#percentageLongVehicles">datex:percentageLongVehicles</a>
    /// </summary>
    let percentageLongVehicles = _prefixId.prefix "percentageLongVehicles"
    let percentageValueExtension = _prefixId.prefix "percentageValueExtension"
    let period = _prefixId.prefix "period"
    /// <summary>
    ///   <para>rdfs:comment : The default value for the publication of the time elapsed between the beginning and the end of the sampling or measurement period. This item may differ from the unit attribute; e.g. an hourly flow can be estimated from a 5-minute measurement period.</para>
    ///   <a href="http://vocab.datex.org/terms#periodDefault">datex:periodDefault</a>
    /// </summary>
    let periodDefault = _prefixId.prefix "periodDefault"
    let periodExtended = _prefixId.prefix "periodExtended"
    let periodExtension = _prefixId.prefix "periodExtension"
    let periodName = _prefixId.prefix "periodName"
    let permitsAndProhibitions = _prefixId.prefix "permitsAndProhibitions"

    let permitsAndProhibitionsExtension = _prefixId.prefix "permitsAndProhibitionsExtension"

    let pertinentLocation = _prefixId.prefix "pertinentLocation"
    let photoUrl = _prefixId.prefix "photoUrl"
    let pictogramCode = _prefixId.prefix "pictogramCode"
    let pictogramCodeListIdentifier = _prefixId.prefix "pictogramCodeListIdentifier"
    let pictogramDescription = _prefixId.prefix "pictogramDescription"
    let pictogramDisplayAreaIndex = _prefixId.prefix "pictogramDisplayAreaIndex"
    let pictogramDisplayAreaSettings = _prefixId.prefix "pictogramDisplayAreaSettings"

    let pictogramDisplayAreaSettingsExtension = _prefixId.prefix "pictogramDisplayAreaSettingsExtension"

    let pictogramDisplayHeight = _prefixId.prefix "pictogramDisplayHeight"
    let pictogramDisplayWidth = _prefixId.prefix "pictogramDisplayWidth"
    let pictogramFlashing = _prefixId.prefix "pictogramFlashing"
    let pictogramInInverseColour = _prefixId.prefix "pictogramInInverseColour"
    let pictogramLanternsOn = _prefixId.prefix "pictogramLanternsOn"
    let pictogramLanternsPresent = _prefixId.prefix "pictogramLanternsPresent"
    let pictogramLuminanceLevel = _prefixId.prefix "pictogramLuminanceLevel"
    let pictogramLuminanceLevelName = _prefixId.prefix "pictogramLuminanceLevelName"
    let pictogramLuminanceOverride = _prefixId.prefix "pictogramLuminanceOverride"
    let pictogramNumberOfColours = _prefixId.prefix "pictogramNumberOfColours"
    let pictogramPixelsAcross = _prefixId.prefix "pictogramPixelsAcross"
    let pictogramPixelsDown = _prefixId.prefix "pictogramPixelsDown"
    let pictogramPositionAbsolute = _prefixId.prefix "pictogramPositionAbsolute"

    let pictogramPositionRelativeToText = _prefixId.prefix "pictogramPositionRelativeToText"

    let pictogramPositionX = _prefixId.prefix "pictogramPositionX"
    let pictogramPositionY = _prefixId.prefix "pictogramPositionY"
    let pictogramSequencingCapable = _prefixId.prefix "pictogramSequencingCapable"
    let pictogramSequencingIndex = _prefixId.prefix "pictogramSequencingIndex"
    let pictogramUrl = _prefixId.prefix "pictogramUrl"
    /// <summary>
    ///   <para>rdfs:comment : Places, in generic terms, at which the network management applies.</para>
    ///   <a href="http://vocab.datex.org/terms#placesAtWhichApplicable">datex:placesAtWhichApplicable</a>
    /// </summary>
    let placesAtWhichApplicable = _prefixId.prefix "placesAtWhichApplicable"
    /// <summary>
    ///   <para>rdfs:comment : A single point defined by a coordinate set and TPEG decriptors.</para>
    ///   <a href="http://vocab.datex.org/terms#point">datex:point</a>
    /// </summary>
    let point = _prefixId.prefix "point"
    let pointAlongLinearElement = _prefixId.prefix "pointAlongLinearElement"

    let pointAlongLinearElementExtension = _prefixId.prefix "pointAlongLinearElementExtension"

    let pointByCoordinates = _prefixId.prefix "pointByCoordinates"
    let pointByCoordinatesExtension = _prefixId.prefix "pointByCoordinatesExtension"
    let pointCoordinates = _prefixId.prefix "pointCoordinates"
    let pointCoordinatesExtension = _prefixId.prefix "pointCoordinatesExtension"
    let pointDestinationExtension = _prefixId.prefix "pointDestinationExtension"
    let pointExtended = _prefixId.prefix "pointExtended"
    let pointExtension = _prefixId.prefix "pointExtension"
    let policeForceControlArea = _prefixId.prefix "policeForceControlArea"
    let pollutantConcentration = _prefixId.prefix "pollutantConcentration"
    let pollutantType = _prefixId.prefix "pollutantType"
    let pollution = _prefixId.prefix "pollution"
    let pollutionExtension = _prefixId.prefix "pollutionExtension"
    let pollutionInformationExtension = _prefixId.prefix "pollutionInformationExtension"
    let polygonArea = _prefixId.prefix "polygonArea"
    let polygonAreaExtension = _prefixId.prefix "polygonAreaExtension"

    let poorEnvironmentConditionsExtension = _prefixId.prefix "poorEnvironmentConditionsExtension"

    /// <summary>
    ///   <para>rdfs:comment : The type of environment condition which is affecting driving conditions.</para>
    ///   <a href="http://vocab.datex.org/terms#poorEnvironmentType">datex:poorEnvironmentType</a>
    /// </summary>
    let poorEnvironmentType = _prefixId.prefix "poorEnvironmentType"
    let precipitationDetail = _prefixId.prefix "precipitationDetail"
    let precipitationDetailExtension = _prefixId.prefix "precipitationDetailExtension"

    let precipitationInformationExtension = _prefixId.prefix "precipitationInformationExtension"

    let precipitationIntensity = _prefixId.prefix "precipitationIntensity"

    let precipitationIntensityValueExtension = _prefixId.prefix "precipitationIntensityValueExtension"

    let precipitationType = _prefixId.prefix "precipitationType"
    let predefinedItineraryExtension = _prefixId.prefix "predefinedItineraryExtension"
    /// <summary>
    ///   <para>rdfs:comment : A name assigned to the predefined itinerary.</para>
    ///   <a href="http://vocab.datex.org/terms#predefinedItineraryName">datex:predefinedItineraryName</a>
    /// </summary>
    let predefinedItineraryName = _prefixId.prefix "predefinedItineraryName"
    /// <summary>
    ///   <para>rdfs:comment : A reference to a versioned instance of a predefined itinerary as specified in a PredefinedLocationsPublication.</para>
    ///   <a href="http://vocab.datex.org/terms#predefinedItineraryReference">datex:predefinedItineraryReference</a>
    /// </summary>
    let predefinedItineraryReference = _prefixId.prefix "predefinedItineraryReference"
    let predefinedLocation = _prefixId.prefix "predefinedLocation"
    let predefinedLocationContainer = _prefixId.prefix "predefinedLocationContainer"

    let predefinedLocationContainerExtension = _prefixId.prefix "predefinedLocationContainerExtension"

    let predefinedLocationExtension = _prefixId.prefix "predefinedLocationExtension"
    /// <summary>
    ///   <para>rdfs:comment : A name assigned to the predefined location (e.g. extracted out of the network operator's gazetteer).</para>
    ///   <a href="http://vocab.datex.org/terms#predefinedLocationName">datex:predefinedLocationName</a>
    /// </summary>
    let predefinedLocationName = _prefixId.prefix "predefinedLocationName"
    /// <summary>
    ///   <para>rdfs:comment : A reference to a versioned predefined location.</para>
    ///   <a href="http://vocab.datex.org/terms#predefinedLocationReference">datex:predefinedLocationReference</a>
    /// </summary>
    let predefinedLocationReference = _prefixId.prefix "predefinedLocationReference"

    let predefinedLocationsPublicationExtension = _prefixId.prefix "predefinedLocationsPublicationExtension"

    let predefinedNonOrderedLocationGroupExtension = _prefixId.prefix "predefinedNonOrderedLocationGroupExtension"

    /// <summary>
    ///   <para>rdfs:comment : A name assigned to the predefined group of non ordered locations.</para>
    ///   <a href="http://vocab.datex.org/terms#predefinedNonOrderedLocationGroupName">datex:predefinedNonOrderedLocationGroupName</a>
    /// </summary>
    let predefinedNonOrderedLocationGroupName = _prefixId.prefix "predefinedNonOrderedLocationGroupName"

    /// <summary>
    ///   <para>rdfs:comment : A reference to a versioned instance of a predefined non ordered location group as specified in a PredefinedLocationsPublication.</para>
    ///   <a href="http://vocab.datex.org/terms#predefinedNonOrderedLocationGroupReference">datex:predefinedNonOrderedLocationGroupReference</a>
    /// </summary>
    let predefinedNonOrderedLocationGroupReference = _prefixId.prefix "predefinedNonOrderedLocationGroupReference"

    /// <summary>
    ///   <para>rdfs:comment : The period of time during which a vehicle activates a presence sensor.</para>
    ///   <a href="http://vocab.datex.org/terms#presenceDurationTime">datex:presenceDurationTime</a>
    /// </summary>
    let presenceDurationTime = _prefixId.prefix "presenceDurationTime"
    let presenceOfRedTriangle = _prefixId.prefix "presenceOfRedTriangle"
    let primaryRoad = _prefixId.prefix "primaryRoad"
    let primarySetting = _prefixId.prefix "primarySetting"
    let probabilityOfOccurrence = _prefixId.prefix "probabilityOfOccurrence"
    let prohibitedParking = _prefixId.prefix "prohibitedParking"
    let protectionTemperature = _prefixId.prefix "protectionTemperature"
    let protocol = _prefixId.prefix "protocol"
    let publicEventExtension = _prefixId.prefix "publicEventExtension"
    /// <summary>
    ///   <para>rdfs:comment : Type of public event which could disrupt traffic.</para>
    ///   <a href="http://vocab.datex.org/terms#publicEventType">datex:publicEventType</a>
    /// </summary>
    let publicEventType = _prefixId.prefix "publicEventType"
    let publicHoliday = _prefixId.prefix "publicHoliday"
    let publicHolidayExtension = _prefixId.prefix "publicHolidayExtension"
    let publicHolidayName = _prefixId.prefix "publicHolidayName"
    let publicHolidayType = _prefixId.prefix "publicHolidayType"
    let publicationCreator = _prefixId.prefix "publicationCreator"
    let publicationTime = _prefixId.prefix "publicationTime"
    /// <summary>
    ///   <para>rdfs:comment : Indication, whether the contact accepted publishing its contact information.</para>
    ///   <a href="http://vocab.datex.org/terms#publishingAgreement">datex:publishingAgreement</a>
    /// </summary>
    let publishingAgreement = _prefixId.prefix "publishingAgreement"
    /// <summary>
    ///   <para>rdfs:comment : The length of a queue or the average length of queues in separate lanes due to a situation.</para>
    ///   <a href="http://vocab.datex.org/terms#queueLength">datex:queueLength</a>
    /// </summary>
    let queueLength = _prefixId.prefix "queueLength"
    /// <summary>
    ///   <para>rdfs:comment : The current queuing time (duration) for entering the car park.</para>
    ///   <a href="http://vocab.datex.org/terms#queuingTime">datex:queuingTime</a>
    /// </summary>
    let queuingTime = _prefixId.prefix "queuingTime"
    /// <summary>
    ///   <para>rdfs:comment : The radius of the geometric area identified.</para>
    ///   <a href="http://vocab.datex.org/terms#radius">datex:radius</a>
    /// </summary>
    let radius = _prefixId.prefix "radius"
    /// <summary>
    ///   <para>rdfs:comment : Points to another instance of 'GroupOfParkingSpaces', which is a real superset from a local point of view. To be used when defining mixed parking areas with different time slots.</para>
    ///   <a href="http://vocab.datex.org/terms#realSubsetOfGroup">datex:realSubsetOfGroup</a>
    /// </summary>
    let realSubsetOfGroup = _prefixId.prefix "realSubsetOfGroup"
    let reasonForDataError = _prefixId.prefix "reasonForDataError"
    let reasonForSetting = _prefixId.prefix "reasonForSetting"
    let recordSequenceNumber = _prefixId.prefix "recordSequenceNumber"
    let recurringDayWeekMonthPeriod = _prefixId.prefix "recurringDayWeekMonthPeriod"
    let recurringSpecialDay = _prefixId.prefix "recurringSpecialDay"
    let recurringTimePeriodOfDay = _prefixId.prefix "recurringTimePeriodOfDay"
    let referenceSettings = _prefixId.prefix "referenceSettings"
    let referenceSettingsExtension = _prefixId.prefix "referenceSettingsExtension"
    let referent = _prefixId.prefix "referent"
    let referentDescription = _prefixId.prefix "referentDescription"
    let referentExtension = _prefixId.prefix "referentExtension"
    let referentIdentifier = _prefixId.prefix "referentIdentifier"
    let referentName = _prefixId.prefix "referentName"
    let referentType = _prefixId.prefix "referentType"
    let region = _prefixId.prefix "region"
    let regulation = _prefixId.prefix "regulation"
    let relatedSituation = _prefixId.prefix "relatedSituation"
    let relativeHumidity = _prefixId.prefix "relativeHumidity"

    let relativePositionToPictogramArea = _prefixId.prefix "relativePositionToPictogramArea"

    /// <summary>
    ///   <para>rdfs:comment : Assessment of the traffic flow conditions relative to normally expected conditions at this date/time.</para>
    ///   <a href="http://vocab.datex.org/terms#relativeTrafficFlow">datex:relativeTrafficFlow</a>
    /// </summary>
    let relativeTrafficFlow = _prefixId.prefix "relativeTrafficFlow"
    let reliable = _prefixId.prefix "reliable"
    let requestType = _prefixId.prefix "requestType"
    let requestedBy = _prefixId.prefix "requestedBy"
    /// <summary>
    ///   <para>rdfs:comment : A description of the rerouting itinerary.</para>
    ///   <a href="http://vocab.datex.org/terms#reroutingItineraryDescription">datex:reroutingItineraryDescription</a>
    /// </summary>
    let reroutingItineraryDescription = _prefixId.prefix "reroutingItineraryDescription"
    let reroutingManagementExtension = _prefixId.prefix "reroutingManagementExtension"
    /// <summary>
    ///   <para>rdfs:comment : Type of rerouting management action instigated by operator.</para>
    ///   <a href="http://vocab.datex.org/terms#reroutingManagementType">datex:reroutingManagementType</a>
    /// </summary>
    let reroutingManagementType = _prefixId.prefix "reroutingManagementType"
    let reservationFee = _prefixId.prefix "reservationFee"
    /// <summary>
    ///   <para>rdfs:comment : Reservation service (for end users). It is recommended to give URL and telephone.</para>
    ///   <a href="http://vocab.datex.org/terms#reservationService">datex:reservationService</a>
    /// </summary>
    let reservationService = _prefixId.prefix "reservationService"
    let residualRoadWidth = _prefixId.prefix "residualRoadWidth"
    let responisbleAuthority = _prefixId.prefix "responisbleAuthority"
    let response = _prefixId.prefix "response"
    let reversedFlow = _prefixId.prefix "reversedFlow"
    let rgbBlueValue = _prefixId.prefix "rgbBlueValue"
    let rgbColour = _prefixId.prefix "rgbColour"
    let rgbColourExtension = _prefixId.prefix "rgbColourExtension"
    let rgbGreenValue = _prefixId.prefix "rgbGreenValue"
    let rgbRedValue = _prefixId.prefix "rgbRedValue"
    let roadConditionsExtension = _prefixId.prefix "roadConditionsExtension"
    let roadDestination = _prefixId.prefix "roadDestination"
    let roadExtension = _prefixId.prefix "roadExtension"
    let roadIdentifier = _prefixId.prefix "roadIdentifier"
    /// <summary>
    ///   <para>rdfs:comment : The type of road maintenance or installation work at the specified location.</para>
    ///   <a href="http://vocab.datex.org/terms#roadMaintenanceType">datex:roadMaintenanceType</a>
    /// </summary>
    let roadMaintenanceType = _prefixId.prefix "roadMaintenanceType"
    let roadName = _prefixId.prefix "roadName"
    let roadNodeExtension = _prefixId.prefix "roadNodeExtension"
    let roadNumber = _prefixId.prefix "roadNumber"
    let roadOperatorControlArea = _prefixId.prefix "roadOperatorControlArea"

    let roadOperatorServiceDisruptionExtension = _prefixId.prefix "roadOperatorServiceDisruptionExtension"

    /// <summary>
    ///   <para>rdfs:comment : The type of road operator service which is disrupted.</para>
    ///   <a href="http://vocab.datex.org/terms#roadOperatorServiceDisruptionType">datex:roadOperatorServiceDisruptionType</a>
    /// </summary>
    let roadOperatorServiceDisruptionType = _prefixId.prefix "roadOperatorServiceDisruptionType"

    let roadOrCarriagewayOrLaneManagementExtension = _prefixId.prefix "roadOrCarriagewayOrLaneManagementExtension"

    /// <summary>
    ///   <para>rdfs:comment : Type of road, carriageway or lane management action instigated by operator.</para>
    ///   <a href="http://vocab.datex.org/terms#roadOrCarriagewayOrLaneManagementType">datex:roadOrCarriagewayOrLaneManagementType</a>
    /// </summary>
    let roadOrCarriagewayOrLaneManagementType = _prefixId.prefix "roadOrCarriagewayOrLaneManagementType"

    /// <summary>
    ///   <para>rdfs:comment : The intersecting road or the junction at which the alternative route commences.</para>
    ///   <a href="http://vocab.datex.org/terms#roadOrJunctionNumber">datex:roadOrJunctionNumber</a>
    /// </summary>
    let roadOrJunctionNumber = _prefixId.prefix "roadOrJunctionNumber"
    let roadOrigination = _prefixId.prefix "roadOrigination"

    let roadSurfaceConditionInformationExtension = _prefixId.prefix "roadSurfaceConditionInformationExtension"

    let roadSurfaceConditionMeasurements = _prefixId.prefix "roadSurfaceConditionMeasurements"

    let roadSurfaceConditionMeasurementsExtension = _prefixId.prefix "roadSurfaceConditionMeasurementsExtension"

    let roadSurfaceTemperature = _prefixId.prefix "roadSurfaceTemperature"
    let roadsideAssistanceExtension = _prefixId.prefix "roadsideAssistanceExtension"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the nature of the road side assistance that will be, is or has been provided.</para>
    ///   <a href="http://vocab.datex.org/terms#roadsideAssistanceType">datex:roadsideAssistanceType</a>
    /// </summary>
    let roadsideAssistanceType = _prefixId.prefix "roadsideAssistanceType"

    let roadsideServiceDisruptionExtension = _prefixId.prefix "roadsideServiceDisruptionExtension"

    /// <summary>
    ///   <para>rdfs:comment : The type of roadside service which is disrupted.</para>
    ///   <a href="http://vocab.datex.org/terms#roadsideServiceDisruptionType">datex:roadsideServiceDisruptionType</a>
    /// </summary>
    let roadsideServiceDisruptionType = _prefixId.prefix "roadsideServiceDisruptionType"
    /// <summary>
    ///   <para>rdfs:comment : Indicates in general terms the expected duration of the roadworks.</para>
    ///   <a href="http://vocab.datex.org/terms#roadworksDuration">datex:roadworksDuration</a>
    /// </summary>
    let roadworksDuration = _prefixId.prefix "roadworksDuration"
    let roadworksExtension = _prefixId.prefix "roadworksExtension"
    /// <summary>
    ///   <para>rdfs:comment : Indication of the scale of the roadworks in terms of the traffic disruption they are likely to cause.</para>
    ///   <a href="http://vocab.datex.org/terms#roadworksScale">datex:roadworksScale</a>
    /// </summary>
    let roadworksScale = _prefixId.prefix "roadworksScale"
    /// <summary>
    ///   <para>rdfs:comment : Destination of a route or final location in an itinerary.</para>
    ///   <a href="http://vocab.datex.org/terms#routeDestination">datex:routeDestination</a>
    /// </summary>
    let routeDestination = _prefixId.prefix "routeDestination"
    let safetyRelatedMessage = _prefixId.prefix "safetyRelatedMessage"
    let scenarioAvailability = _prefixId.prefix "scenarioAvailability"
    let scenarioIndex = _prefixId.prefix "scenarioIndex"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the timetabled departure time of a transit service for a specified location.</para>
    ///   <a href="http://vocab.datex.org/terms#scheduledDepartureTime">datex:scheduledDepartureTime</a>
    /// </summary>
    let scheduledDepartureTime = _prefixId.prefix "scheduledDepartureTime"
    let sectionName = _prefixId.prefix "sectionName"
    let securityService = _prefixId.prefix "securityService"
    let sequentialRampNumber = _prefixId.prefix "sequentialRampNumber"
    let serviceFacilityExtension = _prefixId.prefix "serviceFacilityExtension"
    let serviceFacilityOpeningStatus = _prefixId.prefix "serviceFacilityOpeningStatus"
    /// <summary>
    ///   <para>rdfs:comment : One type of service, that is available on the parking site.</para>
    ///   <a href="http://vocab.datex.org/terms#serviceFacilityType">datex:serviceFacilityType</a>
    /// </summary>
    let serviceFacilityType = _prefixId.prefix "serviceFacilityType"
    let servicePartner = _prefixId.prefix "servicePartner"
    let setBySystem = _prefixId.prefix "setBySystem"
    let severity = _prefixId.prefix "severity"
    let signSettingExtension = _prefixId.prefix "signSettingExtension"
    /// <summary>
    ///   <para>rdfs:comment : Indication of whether the rerouting is signed.</para>
    ///   <a href="http://vocab.datex.org/terms#signedRerouting">datex:signedRerouting</a>
    /// </summary>
    let signedRerouting = _prefixId.prefix "signedRerouting"
    let siteMeasurements = _prefixId.prefix "siteMeasurements"
    let siteMeasurementsExtension = _prefixId.prefix "siteMeasurementsExtension"
    let situation = _prefixId.prefix "situation"
    let situationExtension = _prefixId.prefix "situationExtension"
    let situationPublicationExtension = _prefixId.prefix "situationPublicationExtension"
    let situationRecord = _prefixId.prefix "situationRecord"

    let situationRecordCreationReference = _prefixId.prefix "situationRecordCreationReference"

    let situationRecordCreationTime = _prefixId.prefix "situationRecordCreationTime"

    let situationRecordExtendedApproved = _prefixId.prefix "situationRecordExtendedApproved"

    let situationRecordExtension = _prefixId.prefix "situationRecordExtension"

    let situationRecordFirstSupplierVersionTime = _prefixId.prefix "situationRecordFirstSupplierVersionTime"

    let situationRecordObservationTime = _prefixId.prefix "situationRecordObservationTime"

    let situationRecordToWhichMessageIsRelated = _prefixId.prefix "situationRecordToWhichMessageIsRelated"

    let situationRecordVersionTime = _prefixId.prefix "situationRecordVersionTime"

    let situationToWhichMessageIsRelated = _prefixId.prefix "situationToWhichMessageIsRelated"

    let situationVersionTime = _prefixId.prefix "situationVersionTime"
    let smoothingFactor = _prefixId.prefix "smoothingFactor"
    let source = _prefixId.prefix "source"
    let sourceCountry = _prefixId.prefix "sourceCountry"
    let sourceExtension = _prefixId.prefix "sourceExtension"
    let sourceIdentification = _prefixId.prefix "sourceIdentification"
    let sourceName = _prefixId.prefix "sourceName"
    let sourceType = _prefixId.prefix "sourceType"
    let specialDayExtension = _prefixId.prefix "specialDayExtension"
    let specialDayName = _prefixId.prefix "specialDayName"
    let specialDayType = _prefixId.prefix "specialDayType"

    let specialLocationParkingSiteExtension = _prefixId.prefix "specialLocationParkingSiteExtension"

    let specificAxleWeight = _prefixId.prefix "specificAxleWeight"
    let specificLane = _prefixId.prefix "specificLane"
    let specificLocation = _prefixId.prefix "specificLocation"
    let specificMeasurementValueType = _prefixId.prefix "specificMeasurementValueType"

    let specificVehicleCharacteristics = _prefixId.prefix "specificVehicleCharacteristics"

    /// <summary>
    ///   <para>rdfs:comment : A value of speed expressed in kilometres per hour.</para>
    ///   <a href="http://vocab.datex.org/terms#speed">datex:speed</a>
    /// </summary>
    let speed = _prefixId.prefix "speed"
    let speedAttribute = _prefixId.prefix "speedAttribute"
    let speedManagementExtension = _prefixId.prefix "speedManagementExtension"
    /// <summary>
    ///   <para>rdfs:comment : Type of speed management action instigated by operator.</para>
    ///   <a href="http://vocab.datex.org/terms#speedManagementType">datex:speedManagementType</a>
    /// </summary>
    let speedManagementType = _prefixId.prefix "speedManagementType"
    let speedPercentile = _prefixId.prefix "speedPercentile"
    let speedPercentileExtension = _prefixId.prefix "speedPercentileExtension"
    let speedValueExtension = _prefixId.prefix "speedValueExtension"
    let standardDeviation = _prefixId.prefix "standardDeviation"
    let startOfPeriod = _prefixId.prefix "startOfPeriod"
    /// <summary>
    ///   <para>rdfs:comment : The referent at a known location on the linear object which defines the start of the linear element.</para>
    ///   <a href="http://vocab.datex.org/terms#startPointOfLinearElement">datex:startPointOfLinearElement</a>
    /// </summary>
    let startPointOfLinearElement = _prefixId.prefix "startPointOfLinearElement"
    /// <summary>
    ///   <para>rdfs:comment : Start of time period.</para>
    ///   <a href="http://vocab.datex.org/terms#startTimeOfPeriod">datex:startTimeOfPeriod</a>
    /// </summary>
    let startTimeOfPeriod = _prefixId.prefix "startTimeOfPeriod"
    let subjectTypeOfWorks = _prefixId.prefix "subjectTypeOfWorks"
    let subjects = _prefixId.prefix "subjects"
    let subjectsExtension = _prefixId.prefix "subjectsExtension"
    let subscription = _prefixId.prefix "subscription"
    let subscriptionExtension = _prefixId.prefix "subscriptionExtension"
    let subscriptionReference = _prefixId.prefix "subscriptionReference"
    let subscriptionStartTime = _prefixId.prefix "subscriptionStartTime"
    let subscriptionState = _prefixId.prefix "subscriptionState"
    let subscriptionStopTime = _prefixId.prefix "subscriptionStopTime"

    let supplementaryMessageDescription = _prefixId.prefix "supplementaryMessageDescription"

    let supplementaryPanelDisplayHeight = _prefixId.prefix "supplementaryPanelDisplayHeight"

    let supplementaryPanelDisplayWidth = _prefixId.prefix "supplementaryPanelDisplayWidth"

    let supplementaryPanelPixelsAcross = _prefixId.prefix "supplementaryPanelPixelsAcross"

    let supplementaryPanelPixelsDown = _prefixId.prefix "supplementaryPanelPixelsDown"
    let supplementaryPanelPositionX = _prefixId.prefix "supplementaryPanelPositionX"
    let supplementaryPanelPositionY = _prefixId.prefix "supplementaryPanelPositionY"
    let supplementaryPictogramCode = _prefixId.prefix "supplementaryPictogramCode"

    let supplementaryPictogramCodeListIdentifier = _prefixId.prefix "supplementaryPictogramCodeListIdentifier"

    let supplementaryPictogramDescription = _prefixId.prefix "supplementaryPictogramDescription"

    let supplementaryPictogramUrl = _prefixId.prefix "supplementaryPictogramUrl"

    let supplementaryPositionalDescription = _prefixId.prefix "supplementaryPositionalDescription"

    let supplementaryPositionalDescriptionExtension = _prefixId.prefix "supplementaryPositionalDescriptionExtension"

    let supplierCalculatedDataQuality = _prefixId.prefix "supplierCalculatedDataQuality"
    let supplierIdentification = _prefixId.prefix "supplierIdentification"

    let synchronizedSequencingWithTextPages = _prefixId.prefix "synchronizedSequencingWithTextPages"

    let target = _prefixId.prefix "target"
    let targetClass = _prefixId.prefix "targetClass"
    let targetExtension = _prefixId.prefix "targetExtension"
    let tariffsAndPayment = _prefixId.prefix "tariffsAndPayment"
    let tariffsAndPaymentExtension = _prefixId.prefix "tariffsAndPaymentExtension"
    /// <summary>
    ///   <para>rdfs:comment : A value of temperature expressed in degrees Celsius.</para>
    ///   <a href="http://vocab.datex.org/terms#temperature">datex:temperature</a>
    /// </summary>
    let temperature = _prefixId.prefix "temperature"
    let temperatureExtension = _prefixId.prefix "temperatureExtension"

    let temperatureInformationExtension = _prefixId.prefix "temperatureInformationExtension"

    let temperatureValueExtension = _prefixId.prefix "temperatureValueExtension"
    /// <summary>
    ///   <para>rdfs:comment : Indicates that the parking site is on a temporary basis. It might close permanently within short notice or might only be partial equipped. The physical parking possibilities might be provisional, too.</para>
    ///   <a href="http://vocab.datex.org/terms#temporaryParking">datex:temporaryParking</a>
    /// </summary>
    let temporaryParking = _prefixId.prefix "temporaryParking"
    /// <summary>
    ///   <para>rdfs:comment : Temporary limit defining the maximum advisory or mandatory speed of vehicles.</para>
    ///   <a href="http://vocab.datex.org/terms#temporarySpeedLimit">datex:temporarySpeedLimit</a>
    /// </summary>
    let temporarySpeedLimit = _prefixId.prefix "temporarySpeedLimit"
    let textDisplayAreaSettings = _prefixId.prefix "textDisplayAreaSettings"

    let textDisplayAreaSettingsExtension = _prefixId.prefix "textDisplayAreaSettingsExtension"

    let textDisplayHeight = _prefixId.prefix "textDisplayHeight"
    let textDisplayWidth = _prefixId.prefix "textDisplayWidth"
    let textLanternsOn = _prefixId.prefix "textLanternsOn"
    let textLanternsPresent = _prefixId.prefix "textLanternsPresent"
    let textLuminanceLevel = _prefixId.prefix "textLuminanceLevel"
    let textLuminanceLevelName = _prefixId.prefix "textLuminanceLevelName"
    let textLuminanceOverride = _prefixId.prefix "textLuminanceOverride"
    let textPage = _prefixId.prefix "textPage"
    let textPageSequencingCapable = _prefixId.prefix "textPageSequencingCapable"

    let textPictogramSequencingInterval = _prefixId.prefix "textPictogramSequencingInterval"

    let textPixelsAcross = _prefixId.prefix "textPixelsAcross"
    let textPixelsDown = _prefixId.prefix "textPixelsDown"
    let textPositionAbsolute = _prefixId.prefix "textPositionAbsolute"
    let textPositionX = _prefixId.prefix "textPositionX"
    let textPositionY = _prefixId.prefix "textPositionY"
    /// <summary>
    ///   <para>rdfs:comment : The default for the publication of the time at which the values have been computed/derived.</para>
    ///   <a href="http://vocab.datex.org/terms#timeDefault">datex:timeDefault</a>
    /// </summary>
    let timeDefault = _prefixId.prefix "timeDefault"
    /// <summary>
    ///   <para>rdfs:comment : The time interval between the arrival of this vehicle's front at a point on the roadway, and that of the departure of the rear of the preceding one.</para>
    ///   <a href="http://vocab.datex.org/terms#timeGap">datex:timeGap</a>
    /// </summary>
    let timeGap = _prefixId.prefix "timeGap"
    /// <summary>
    ///   <para>rdfs:comment : The measured time interval between this vehicle's arrival at (or departure from) a point on the roadway, and that of the preceding one.</para>
    ///   <a href="http://vocab.datex.org/terms#timeHeadway">datex:timeHeadway</a>
    /// </summary>
    let timeHeadway = _prefixId.prefix "timeHeadway"
    let timeLastSet = _prefixId.prefix "timeLastSet"
    let timePeriodByHour = _prefixId.prefix "timePeriodByHour"
    let timePeriodByHourExtension = _prefixId.prefix "timePeriodByHourExtension"
    let timePeriodOfDay = _prefixId.prefix "timePeriodOfDay"
    let timePeriodOfDayExtension = _prefixId.prefix "timePeriodOfDayExtension"
    /// <summary>
    ///   <para>rdfs:comment : The location at the down stream end of the section of road which frames the TPEGFramedPoint.</para>
    ///   <a href="http://vocab.datex.org/terms#to">datex:to</a>
    /// </summary>
    let to_ = _prefixId.prefix "to"
    let toPoint = _prefixId.prefix "toPoint"
    /// <summary>
    ///   <para>rdfs:comment : Total number of car parking spaces.</para>
    ///   <a href="http://vocab.datex.org/terms#totalCapacity">datex:totalCapacity</a>
    /// </summary>
    let totalCapacity = _prefixId.prefix "totalCapacity"
    /// <summary>
    ///   <para>rdfs:comment : The total number of people that are involved.</para>
    ///   <a href="http://vocab.datex.org/terms#totalNumberOfPeopleInvolved">datex:totalNumberOfPeopleInvolved</a>
    /// </summary>
    let totalNumberOfPeopleInvolved = _prefixId.prefix "totalNumberOfPeopleInvolved"
    /// <summary>
    ///   <para>rdfs:comment : The total number of vehicles that are involved.</para>
    ///   <a href="http://vocab.datex.org/terms#totalNumberOfVehiclesInvolved">datex:totalNumberOfVehiclesInvolved</a>
    /// </summary>
    let totalNumberOfVehiclesInvolved = _prefixId.prefix "totalNumberOfVehiclesInvolved"
    /// <summary>
    ///   <para>rdfs:comment : A known location along the linear element towards which the distanceAlong is measured, termed the "towardsReferent" in ISO 19148.</para>
    ///   <a href="http://vocab.datex.org/terms#towardsReferent">datex:towardsReferent</a>
    /// </summary>
    let towardsReferent = _prefixId.prefix "towardsReferent"
    let tpegAreaDescriptorExtension = _prefixId.prefix "tpegAreaDescriptorExtension"
    /// <summary>
    ///   <para>rdfs:comment : The nature of the descriptor used to define the location under consideration (derived from the TPEG Loc table 03).</para>
    ///   <a href="http://vocab.datex.org/terms#tpegAreaDescriptorType">datex:tpegAreaDescriptorType</a>
    /// </summary>
    let tpegAreaDescriptorType = _prefixId.prefix "tpegAreaDescriptorType"
    let tpegAreaLocation = _prefixId.prefix "tpegAreaLocation"
    let tpegAreaLocationExtension = _prefixId.prefix "tpegAreaLocationExtension"
    let tpegAreaLocationType = _prefixId.prefix "tpegAreaLocationType"
    let tpegDescriptorExtension = _prefixId.prefix "tpegDescriptorExtension"
    let tpegDirection = _prefixId.prefix "tpegDirection"
    let tpegFramedPointExtension = _prefixId.prefix "tpegFramedPointExtension"
    /// <summary>
    ///   <para>rdfs:comment : The type of TPEG location.</para>
    ///   <a href="http://vocab.datex.org/terms#tpegFramedPointLocationType">datex:tpegFramedPointLocationType</a>
    /// </summary>
    let tpegFramedPointLocationType = _prefixId.prefix "tpegFramedPointLocationType"
    let tpegGeometricAreaExtension = _prefixId.prefix "tpegGeometricAreaExtension"
    let tpegHeight = _prefixId.prefix "tpegHeight"
    let tpegHeightExtension = _prefixId.prefix "tpegHeightExtension"

    let tpegIlcPointDescriptorExtension = _prefixId.prefix "tpegIlcPointDescriptorExtension"

    /// <summary>
    ///   <para>rdfs:comment : The nature of the descriptor used to define the location under consideration (derived from the TPEG Loc table 03).</para>
    ///   <a href="http://vocab.datex.org/terms#tpegIlcPointDescriptorType">datex:tpegIlcPointDescriptorType</a>
    /// </summary>
    let tpegIlcPointDescriptorType = _prefixId.prefix "tpegIlcPointDescriptorType"
    let tpegJunctionExtension = _prefixId.prefix "tpegJunctionExtension"

    let tpegJunctionPointDescriptorExtension = _prefixId.prefix "tpegJunctionPointDescriptorExtension"

    /// <summary>
    ///   <para>rdfs:comment : The nature of the descriptor used to define the location under consideration (derived from the TPEG Loc table 03).</para>
    ///   <a href="http://vocab.datex.org/terms#tpegJunctionPointDescriptorType">datex:tpegJunctionPointDescriptorType</a>
    /// </summary>
    let tpegJunctionPointDescriptorType = _prefixId.prefix "tpegJunctionPointDescriptorType"

    let tpegLinearLocation = _prefixId.prefix "tpegLinearLocation"
    let tpegLinearLocationExtension = _prefixId.prefix "tpegLinearLocationExtension"
    let tpegLinearLocationType = _prefixId.prefix "tpegLinearLocationType"
    let tpegNamedOnlyAreaExtension = _prefixId.prefix "tpegNamedOnlyAreaExtension"
    let tpegNonJunctionPointExtension = _prefixId.prefix "tpegNonJunctionPointExtension"

    let tpegOtherPointDescriptorExtension = _prefixId.prefix "tpegOtherPointDescriptorExtension"

    /// <summary>
    ///   <para>rdfs:comment : The nature of the descriptor used to define the location under consideration (derived from the TPEG Loc table 03).</para>
    ///   <a href="http://vocab.datex.org/terms#tpegOtherPointDescriptorType">datex:tpegOtherPointDescriptorType</a>
    /// </summary>
    let tpegOtherPointDescriptorType = _prefixId.prefix "tpegOtherPointDescriptorType"
    let tpegPointDescriptorExtension = _prefixId.prefix "tpegPointDescriptorExtension"
    let tpegPointExtension = _prefixId.prefix "tpegPointExtension"
    let tpegPointLocation = _prefixId.prefix "tpegPointLocation"
    let tpegPointLocationExtension = _prefixId.prefix "tpegPointLocationExtension"
    let tpegSimplePointExtension = _prefixId.prefix "tpegSimplePointExtension"
    /// <summary>
    ///   <para>rdfs:comment : The type of TPEG location.</para>
    ///   <a href="http://vocab.datex.org/terms#tpegSimplePointLocationType">datex:tpegSimplePointLocationType</a>
    /// </summary>
    let tpegSimplePointLocationType = _prefixId.prefix "tpegSimplePointLocationType"
    let trafficConcentrationExtension = _prefixId.prefix "trafficConcentrationExtension"
    let trafficConstrictionType = _prefixId.prefix "trafficConstrictionType"
    let trafficDataExtension = _prefixId.prefix "trafficDataExtension"
    let trafficElement = _prefixId.prefix "trafficElement"
    let trafficElementExtension = _prefixId.prefix "trafficElementExtension"
    /// <summary>
    ///   <para>rdfs:comment : A characterization of the traffic flow.</para>
    ///   <a href="http://vocab.datex.org/terms#trafficFlowCharacteristics">datex:trafficFlowCharacteristics</a>
    /// </summary>
    let trafficFlowCharacteristics = _prefixId.prefix "trafficFlowCharacteristics"
    let trafficFlowExtension = _prefixId.prefix "trafficFlowExtension"
    let trafficHeadwayExtension = _prefixId.prefix "trafficHeadwayExtension"
    /// <summary>
    ///   <para>rdfs:comment : Type of person that is manually directing traffic (applicable if generalNetworkManagementType is set to "trafficBeingManuallyDirected").</para>
    ///   <a href="http://vocab.datex.org/terms#trafficManuallyDirectedBy">datex:trafficManuallyDirectedBy</a>
    /// </summary>
    let trafficManuallyDirectedBy = _prefixId.prefix "trafficManuallyDirectedBy"
    let trafficSpeedExtension = _prefixId.prefix "trafficSpeedExtension"
    /// <summary>
    ///   <para>rdfs:comment : Status of traffic conditions on the identified section of road in the specified direction.</para>
    ///   <a href="http://vocab.datex.org/terms#trafficStatus">datex:trafficStatus</a>
    /// </summary>
    let trafficStatus = _prefixId.prefix "trafficStatus"
    let trafficStatusDefault = _prefixId.prefix "trafficStatusDefault"
    let trafficStatusExtension = _prefixId.prefix "trafficStatusExtension"
    /// <summary>
    ///   <para>rdfs:comment : A status value of traffic conditions on the identified section of road in the specified direction.</para>
    ///   <a href="http://vocab.datex.org/terms#trafficStatusValue">datex:trafficStatusValue</a>
    /// </summary>
    let trafficStatusValue = _prefixId.prefix "trafficStatusValue"
    let trafficStatusValueExtension = _prefixId.prefix "trafficStatusValueExtension"
    /// <summary>
    ///   <para>rdfs:comment : A characterization of the trend in the traffic conditions at the specified location and direction.</para>
    ///   <a href="http://vocab.datex.org/terms#trafficTrendType">datex:trafficTrendType</a>
    /// </summary>
    let trafficTrendType = _prefixId.prefix "trafficTrendType"
    let trafficView = _prefixId.prefix "trafficView"
    let trafficViewExtension = _prefixId.prefix "trafficViewExtension"

    let trafficViewPublicationExtension = _prefixId.prefix "trafficViewPublicationExtension"

    let trafficViewRecord = _prefixId.prefix "trafficViewRecord"
    let trafficViewRecordExtension = _prefixId.prefix "trafficViewRecordExtension"
    let trafficViewTime = _prefixId.prefix "trafficViewTime"
    let transitInformationExtension = _prefixId.prefix "transitInformationExtension"
    /// <summary>
    ///   <para>rdfs:comment : Information about transit services.</para>
    ///   <a href="http://vocab.datex.org/terms#transitServiceInformation">datex:transitServiceInformation</a>
    /// </summary>
    let transitServiceInformation = _prefixId.prefix "transitServiceInformation"
    /// <summary>
    ///   <para>rdfs:comment : The type of transit service to which the information relates.</para>
    ///   <a href="http://vocab.datex.org/terms#transitServiceType">datex:transitServiceType</a>
    /// </summary>
    let transitServiceType = _prefixId.prefix "transitServiceType"
    /// <summary>
    ///   <para>rdfs:comment : Derived/computed travel time information relating to a specific group of locations.</para>
    ///   <a href="http://vocab.datex.org/terms#travelTime">datex:travelTime</a>
    /// </summary>
    let travelTime = _prefixId.prefix "travelTime"
    let travelTimeDataExtension = _prefixId.prefix "travelTimeDataExtension"
    /// <summary>
    ///   <para>rdfs:comment : The current trend in the travel time between the defined locations in the specified direction.</para>
    ///   <a href="http://vocab.datex.org/terms#travelTimeTrendType">datex:travelTimeTrendType</a>
    /// </summary>
    let travelTimeTrendType = _prefixId.prefix "travelTimeTrendType"
    /// <summary>
    ///   <para>rdfs:comment : Indication of the way in which the travel time is derived.</para>
    ///   <a href="http://vocab.datex.org/terms#travelTimeType">datex:travelTimeType</a>
    /// </summary>
    let travelTimeType = _prefixId.prefix "travelTimeType"
    let tremCardNumber = _prefixId.prefix "tremCardNumber"
    let truckParkingDynamicManagement = _prefixId.prefix "truckParkingDynamicManagement"
    let typeOfRoad = _prefixId.prefix "typeOfRoad"
    /// <summary>
    ///   <para>rdfs:comment : Indicates that the road section where the roadworks are located is under traffic or not under traffic. 'True' indicates the road is under traffic.</para>
    ///   <a href="http://vocab.datex.org/terms#underTraffic">datex:underTraffic</a>
    /// </summary>
    let underTraffic = _prefixId.prefix "underTraffic"
    let undgNumber = _prefixId.prefix "undgNumber"
    let updateMethod = _prefixId.prefix "updateMethod"
    let urbanParkingSiteExtension = _prefixId.prefix "urbanParkingSiteExtension"
    /// <summary>
    ///   <para>rdfs:comment : The type of urban parking site.</para>
    ///   <a href="http://vocab.datex.org/terms#urbanParkingSiteType">datex:urbanParkingSiteType</a>
    /// </summary>
    let urbanParkingSiteType = _prefixId.prefix "urbanParkingSiteType"
    let urgency = _prefixId.prefix "urgency"
    /// <summary>
    ///   <para>rdfs:comment : Indication of whether the roadworks are considered to be urgent whereby emergency work is being, or needs to be, undertaken to mitigate safety concerns. 'True' indicates they are urgent.</para>
    ///   <a href="http://vocab.datex.org/terms#urgentRoadworks">datex:urgentRoadworks</a>
    /// </summary>
    let urgentRoadworks = _prefixId.prefix "urgentRoadworks"
    let urlLink = _prefixId.prefix "urlLink"
    /// <summary>
    ///   <para>rdfs:comment : A Uniform Resource Locator (URL) address pointing to a resource available on the Internet from where further relevant information may be obtained.</para>
    ///   <a href="http://vocab.datex.org/terms#urlLinkAddress">datex:urlLinkAddress</a>
    /// </summary>
    let urlLinkAddress = _prefixId.prefix "urlLinkAddress"
    let urlLinkDescription = _prefixId.prefix "urlLinkDescription"
    let urlLinkExtension = _prefixId.prefix "urlLinkExtension"
    let urlLinkType = _prefixId.prefix "urlLinkType"
    let usageScenarioOperationStatus = _prefixId.prefix "usageScenarioOperationStatus"
    let usedMeansOfPayment = _prefixId.prefix "usedMeansOfPayment"
    let usedPaymentCard = _prefixId.prefix "usedPaymentCard"
    let usedPaymentCardExtension = _prefixId.prefix "usedPaymentCardExtension"

    let vacantEquipmentOrServiceFacilitySubitems = _prefixId.prefix "vacantEquipmentOrServiceFacilitySubitems"

    let validPeriod = _prefixId.prefix "validPeriod"
    let validity = _prefixId.prefix "validity"
    let validityExtension = _prefixId.prefix "validityExtension"
    let validityOfContact = _prefixId.prefix "validityOfContact"
    let validityStatus = _prefixId.prefix "validityStatus"
    let validityTimeSpecification = _prefixId.prefix "validityTimeSpecification"
    let value = _prefixId.prefix "value"
    let values = _prefixId.prefix "values"
    let valuesType = _prefixId.prefix "valuesType"
    let vehicle = _prefixId.prefix "vehicle"
    let vehicleCharacteristics = _prefixId.prefix "vehicleCharacteristics"

    let vehicleCharacteristicsExtended = _prefixId.prefix "vehicleCharacteristicsExtended"

    let vehicleCharacteristicsExtension = _prefixId.prefix "vehicleCharacteristicsExtension"

    let vehicleColour = _prefixId.prefix "vehicleColour"
    /// <summary>
    ///   <para>rdfs:comment : A measured or calculated absolute count of vehicles within a specified period of time expressed as non negative integer.</para>
    ///   <a href="http://vocab.datex.org/terms#vehicleCount">datex:vehicleCount</a>
    /// </summary>
    let vehicleCount = _prefixId.prefix "vehicleCount"
    let vehicleCountAndRate = _prefixId.prefix "vehicleCountAndRate"
    let vehicleCountAndRateExtension = _prefixId.prefix "vehicleCountAndRateExtension"
    let vehicleCountValueExtension = _prefixId.prefix "vehicleCountValueExtension"
    let vehicleCountWithinInterval = _prefixId.prefix "vehicleCountWithinInterval"

    let vehicleCountWithinIntervalExtension = _prefixId.prefix "vehicleCountWithinIntervalExtension"

    let vehicleCountryOfOrigin = _prefixId.prefix "vehicleCountryOfOrigin"
    let vehicleEquipment = _prefixId.prefix "vehicleEquipment"
    let vehicleExtension = _prefixId.prefix "vehicleExtension"
    /// <summary>
    ///   <para>rdfs:comment : An averaged measurement of flow rate defined in terms of the number of vehicles passing the specified measurement site.</para>
    ///   <a href="http://vocab.datex.org/terms#vehicleFlow">datex:vehicleFlow</a>
    /// </summary>
    let vehicleFlow = _prefixId.prefix "vehicleFlow"
    /// <summary>
    ///   <para>rdfs:comment : A value of vehicle flow rate expressed in vehicles per hour.</para>
    ///   <a href="http://vocab.datex.org/terms#vehicleFlowRate">datex:vehicleFlowRate</a>
    /// </summary>
    let vehicleFlowRate = _prefixId.prefix "vehicleFlowRate"
    let vehicleFlowValueExtension = _prefixId.prefix "vehicleFlowValueExtension"
    let vehicleHeight = _prefixId.prefix "vehicleHeight"
    let vehicleIdentifier = _prefixId.prefix "vehicleIdentifier"
    /// <summary>
    ///   <para>rdfs:comment : The vehicle involved in the accident.</para>
    ///   <a href="http://vocab.datex.org/terms#vehicleInvolved">datex:vehicleInvolved</a>
    /// </summary>
    let vehicleInvolved = _prefixId.prefix "vehicleInvolved"
    let vehicleLength = _prefixId.prefix "vehicleLength"
    let vehicleManufacturer = _prefixId.prefix "vehicleManufacturer"
    let vehicleModel = _prefixId.prefix "vehicleModel"
    let vehicleObstructionExtension = _prefixId.prefix "vehicleObstructionExtension"
    /// <summary>
    ///   <para>rdfs:comment : Characterization of an obstruction on the road caused by one or more vehicles.</para>
    ///   <a href="http://vocab.datex.org/terms#vehicleObstructionType">datex:vehicleObstructionType</a>
    /// </summary>
    let vehicleObstructionType = _prefixId.prefix "vehicleObstructionType"
    let vehiclePercentage = _prefixId.prefix "vehiclePercentage"
    let vehicleRate = _prefixId.prefix "vehicleRate"
    let vehicleRateExtension = _prefixId.prefix "vehicleRateExtension"

    let vehicleRegistrationPlateIdentifier = _prefixId.prefix "vehicleRegistrationPlateIdentifier"

    let vehicleStatus = _prefixId.prefix "vehicleStatus"
    /// <summary>
    ///   <para>rdfs:comment : Vehicle type.</para>
    ///   <a href="http://vocab.datex.org/terms#vehicleType">datex:vehicleType</a>
    /// </summary>
    let vehicleType = _prefixId.prefix "vehicleType"
    let vehicleType2 = _prefixId.prefix "vehicleType2"
    let vehicleUsage = _prefixId.prefix "vehicleUsage"
    let vehicleUsage2 = _prefixId.prefix "vehicleUsage2"
    let vehicleWidth = _prefixId.prefix "vehicleWidth"
    let version = _prefixId.prefix "version"
    let viennaConventionCompliant = _prefixId.prefix "viennaConventionCompliant"
    let visibility = _prefixId.prefix "visibility"
    let visibilityExtension = _prefixId.prefix "visibilityExtension"

    let visibilityInformationExtension = _prefixId.prefix "visibilityInformationExtension"

    let vms = _prefixId.prefix "vms"
    let vmsDescription = _prefixId.prefix "vmsDescription"
    let vmsDisplayHeight = _prefixId.prefix "vmsDisplayHeight"
    let vmsDisplayWidth = _prefixId.prefix "vmsDisplayWidth"
    let vmsDynamicCharacteristics = _prefixId.prefix "vmsDynamicCharacteristics"

    let vmsDynamicCharacteristicsExtension = _prefixId.prefix "vmsDynamicCharacteristicsExtension"

    let vmsExtension = _prefixId.prefix "vmsExtension"
    let vmsFault = _prefixId.prefix "vmsFault"
    let vmsFaultExtension = _prefixId.prefix "vmsFaultExtension"
    let vmsHeightAboveRoadway = _prefixId.prefix "vmsHeightAboveRoadway"
    let vmsIndex = _prefixId.prefix "vmsIndex"
    let vmsLegendCode = _prefixId.prefix "vmsLegendCode"
    let vmsLocation = _prefixId.prefix "vmsLocation"
    let vmsLocationOverride = _prefixId.prefix "vmsLocationOverride"
    let vmsManagedLogicalLocation = _prefixId.prefix "vmsManagedLogicalLocation"

    let vmsManagedLogicalLocationExtension = _prefixId.prefix "vmsManagedLogicalLocationExtension"

    let vmsMessage = _prefixId.prefix "vmsMessage"
    let vmsMessageExtension = _prefixId.prefix "vmsMessageExtension"
    let vmsMessageInformationType = _prefixId.prefix "vmsMessageInformationType"
    let vmsMessageSequencingInterval = _prefixId.prefix "vmsMessageSequencingInterval"
    let vmsOperator = _prefixId.prefix "vmsOperator"
    let vmsOwner = _prefixId.prefix "vmsOwner"
    let vmsPhysicalMounting = _prefixId.prefix "vmsPhysicalMounting"
    let vmsPictogram = _prefixId.prefix "vmsPictogram"
    let vmsPictogramDisplayArea = _prefixId.prefix "vmsPictogramDisplayArea"

    let vmsPictogramDisplayAreaExtension = _prefixId.prefix "vmsPictogramDisplayAreaExtension"

    let vmsPictogramDisplayCharacteristics = _prefixId.prefix "vmsPictogramDisplayCharacteristics"

    let vmsPictogramDisplayCharacteristicsExtension = _prefixId.prefix "vmsPictogramDisplayCharacteristicsExtension"

    let vmsPictogramExtension = _prefixId.prefix "vmsPictogramExtension"
    let vmsPublicationExtension = _prefixId.prefix "vmsPublicationExtension"
    let vmsRecord = _prefixId.prefix "vmsRecord"
    let vmsRecordExtension = _prefixId.prefix "vmsRecordExtension"
    let vmsSetting = _prefixId.prefix "vmsSetting"
    let vmsSettingExtension = _prefixId.prefix "vmsSettingExtension"
    let vmsSupplementaryPanel = _prefixId.prefix "vmsSupplementaryPanel"

    let vmsSupplementaryPanelCharacteristics = _prefixId.prefix "vmsSupplementaryPanelCharacteristics"

    let vmsSupplementaryPanelCharacteristicsExtension = _prefixId.prefix "vmsSupplementaryPanelCharacteristicsExtension"

    let vmsSupplementaryPanelExtension = _prefixId.prefix "vmsSupplementaryPanelExtension"

    let vmsSupplementaryPictogram = _prefixId.prefix "vmsSupplementaryPictogram"

    let vmsSupplementaryPictogramExtension = _prefixId.prefix "vmsSupplementaryPictogramExtension"

    let vmsSupplementaryText = _prefixId.prefix "vmsSupplementaryText"
    let vmsTablePublicationExtension = _prefixId.prefix "vmsTablePublicationExtension"
    let vmsText = _prefixId.prefix "vmsText"
    let vmsTextDisplayCharacteristics = _prefixId.prefix "vmsTextDisplayCharacteristics"

    let vmsTextDisplayCharacteristicsExtension = _prefixId.prefix "vmsTextDisplayCharacteristicsExtension"

    let vmsTextExtension = _prefixId.prefix "vmsTextExtension"
    let vmsTextImageUrl = _prefixId.prefix "vmsTextImageUrl"
    let vmsTextLine = _prefixId.prefix "vmsTextLine"
    let vmsTextLineColour = _prefixId.prefix "vmsTextLineColour"
    let vmsTextLineExtension = _prefixId.prefix "vmsTextLineExtension"
    let vmsTextLineFlashing = _prefixId.prefix "vmsTextLineFlashing"
    let vmsTextLineHtml = _prefixId.prefix "vmsTextLineHtml"
    let vmsTextLineLanguage = _prefixId.prefix "vmsTextLineLanguage"
    let vmsType = _prefixId.prefix "vmsType"
    let vmsTypeCode = _prefixId.prefix "vmsTypeCode"
    let vmsUnit = _prefixId.prefix "vmsUnit"
    let vmsUnitElectronicAddress = _prefixId.prefix "vmsUnitElectronicAddress"
    let vmsUnitExtension = _prefixId.prefix "vmsUnitExtension"
    /// <summary>
    ///   <para>rdfs:comment : The type of fault which is being reported for the VMS unit.</para>
    ///   <a href="http://vocab.datex.org/terms#vmsUnitFault">datex:vmsUnitFault</a>
    /// </summary>
    let vmsUnitFault = _prefixId.prefix "vmsUnitFault"
    let vmsUnitFaultExtension = _prefixId.prefix "vmsUnitFaultExtension"
    let vmsUnitIPAddress = _prefixId.prefix "vmsUnitIPAddress"
    let vmsUnitIdentifier = _prefixId.prefix "vmsUnitIdentifier"
    let vmsUnitRecord = _prefixId.prefix "vmsUnitRecord"
    let vmsUnitRecordExtension = _prefixId.prefix "vmsUnitRecordExtension"
    /// <summary>
    ///   <para>rdfs:comment : A reference to a versioned VMS unit record in a VMS Unit table which defines the characteristics of the VMS unit.</para>
    ///   <a href="http://vocab.datex.org/terms#vmsUnitReference">datex:vmsUnitReference</a>
    /// </summary>
    let vmsUnitReference = _prefixId.prefix "vmsUnitReference"
    let vmsUnitTable = _prefixId.prefix "vmsUnitTable"
    let vmsUnitTableExtension = _prefixId.prefix "vmsUnitTableExtension"
    let vmsUnitTableIdentification = _prefixId.prefix "vmsUnitTableIdentification"
    /// <summary>
    ///   <para>rdfs:comment : A reference to a versioned VMS Unit table.</para>
    ///   <a href="http://vocab.datex.org/terms#vmsUnitTableReference">datex:vmsUnitTableReference</a>
    /// </summary>
    let vmsUnitTableReference = _prefixId.prefix "vmsUnitTableReference"
    let vmsUnitUsedToManageParking = _prefixId.prefix "vmsUnitUsedToManageParking"
    let vmsWorking = _prefixId.prefix "vmsWorking"
    let voltage = _prefixId.prefix "voltage"
    let volumeOfDangerousGoods = _prefixId.prefix "volumeOfDangerousGoods"
    let waterFilmThickness = _prefixId.prefix "waterFilmThickness"
    let weatherDataExtension = _prefixId.prefix "weatherDataExtension"

    /// <summary>
    ///   <para>rdfs:comment : The type of road surface condition that is related to the weather which is affecting the driving conditions.</para>
    ///   <a href="http://vocab.datex.org/terms#weatherRelatedRoadConditionType">datex:weatherRelatedRoadConditionType</a>
    /// </summary>
    let weatherRelatedRoadConditionType = _prefixId.prefix "weatherRelatedRoadConditionType"

    let weatherRelatedRoadConditionsExtension = _prefixId.prefix "weatherRelatedRoadConditionsExtension"

    let weightAttribute = _prefixId.prefix "weightAttribute"
    let weightOfDangerousGoods = _prefixId.prefix "weightOfDangerousGoods"
    let weightPerAxleAttribute = _prefixId.prefix "weightPerAxleAttribute"
    let widthAttribute = _prefixId.prefix "widthAttribute"
    let widthCharacteristic = _prefixId.prefix "widthCharacteristic"
    let widthCharacteristicExtension = _prefixId.prefix "widthCharacteristicExtension"
    let wind = _prefixId.prefix "wind"
    let windDirectionBearing = _prefixId.prefix "windDirectionBearing"
    let windDirectionCompass = _prefixId.prefix "windDirectionCompass"
    let windExtension = _prefixId.prefix "windExtension"
    let windInformationExtension = _prefixId.prefix "windInformationExtension"
    let windMeasurementHeight = _prefixId.prefix "windMeasurementHeight"
    let windSpeed = _prefixId.prefix "windSpeed"

    let winterDrivingManagementExtension = _prefixId.prefix "winterDrivingManagementExtension"

    /// <summary>
    ///   <para>rdfs:comment : Type of winter equipment management action instigated by operator.</para>
    ///   <a href="http://vocab.datex.org/terms#winterEquipmentManagementType">datex:winterEquipmentManagementType</a>
    /// </summary>
    let winterEquipmentManagementType = _prefixId.prefix "winterEquipmentManagementType"
    let withReservation = _prefixId.prefix "withReservation"
