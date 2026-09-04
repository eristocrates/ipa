#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module gtfs =
    let _prefixId = PrefixId.fromNamespaceLabel "http://vocab.gtfs.org/terms#" "gtfs"
    let _namespaceIri = _prefixId.prefix ""
    let _Gondola = _prefixId.prefix ":Gondola"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Agency</para>
    ///   <para>rdfs:comment : An agency operates a certain schedule based transport mode</para>
    ///   <a href="http://vocab.gtfs.org/terms#Agency">gtfs:Agency</a>
    /// </summary>
    let Agency = _prefixId.prefix "Agency"
    let BeforeBoarding = _prefixId.prefix "BeforeBoarding"
    let Bus = _prefixId.prefix "Bus"
    let CableCar = _prefixId.prefix "CableCar"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>gtfs:comment : a row from calendar_dates.txt</para>
    ///   <para>rdfs:label : Calendar date rule</para>
    ///   <para>rdfs:comment : Defines service availability for a specific date</para>
    ///   <a href="http://vocab.gtfs.org/terms#CalendarDateRule">gtfs:CalendarDateRule</a>
    /// </summary>
    let CalendarDateRule = _prefixId.prefix "CalendarDateRule"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>gtfs:comment : a row from calendar.txt</para>
    ///   <para>rdfs:label : Calendar rule</para>
    ///   <para>rdfs:comment : Defines on which days of the week for a certain period the service is available.</para>
    ///   <a href="http://vocab.gtfs.org/terms#CalendarRule">gtfs:CalendarRule</a>
    /// </summary>
    let CalendarRule = _prefixId.prefix "CalendarRule"
    let CheckParentStation = _prefixId.prefix "CheckParentStation"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Drop Off Type^^xsd:string</para>
    ///   <para>rdfs:comment : Instances of this class can be used by gtfs:dropOffType</para>
    ///   <a href="http://vocab.gtfs.org/terms#DropOffType">gtfs:DropOffType</a>
    /// </summary>
    let DropOffType = _prefixId.prefix "DropOffType"
    let EnsuredTransfer = _prefixId.prefix "EnsuredTransfer"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>gtfs:comment : A gtfs:FareClass corresponds to a row in the fare_attributes.txt file.</para>
    ///   <para>rdfs:label : Fare Class</para>
    ///   <para>rdfs:comment : A class describing how the fare is calculated.</para>
    ///   <a href="http://vocab.gtfs.org/terms#FareClass">gtfs:FareClass</a>
    /// </summary>
    let FareClass = _prefixId.prefix "FareClass"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Fare Rule</para>
    ///   <para>rdfs:comment : A rule which binds a gtfs:FareClass to a part of the network.</para>
    ///   <a href="http://vocab.gtfs.org/terms#FareRule">gtfs:FareRule</a>
    /// </summary>
    let FareRule = _prefixId.prefix "FareRule"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : GTFS Feed</para>
    ///   <para>rdfs:comment : An instance of a gtfs:Feed is a linked GTFS feed that complies to this specification.</para>
    ///   <a href="http://vocab.gtfs.org/terms#Feed">gtfs:Feed</a>
    /// </summary>
    let Feed = _prefixId.prefix "Feed"
    let Ferry = _prefixId.prefix "Ferry"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Frequency</para>
    ///   <para>rdfs:comment : An alternative to defining departures and arrivals as StopTimes: define frequencies for transit vehicle^^xsd:string</para>
    ///   <a href="http://vocab.gtfs.org/terms#Frequency">gtfs:Frequency</a>
    /// </summary>
    let Frequency = _prefixId.prefix "Frequency"
    let Funicular = _prefixId.prefix "Funicular"
    let LightRail = _prefixId.prefix "LightRail"
    let MinimumTimeTransfer = _prefixId.prefix "MinimumTimeTransfer"
    let MustCoordinateWithDriver = _prefixId.prefix "MustCoordinateWithDriver"
    let MustPhone = _prefixId.prefix "MustPhone"
    let NoTransfer = _prefixId.prefix "NoTransfer"
    let NoTransfersAllowed = _prefixId.prefix "NoTransfersAllowed"
    let NotAvailable = _prefixId.prefix "NotAvailable"
    let NotWheelchairAccessible = _prefixId.prefix "NotWheelchairAccessible"
    let OnBoard = _prefixId.prefix "OnBoard"
    let OneTransfersAllowed = _prefixId.prefix "OneTransfersAllowed"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Payment Method</para>
    ///   <para>rdfs:comment : Method to pay for the public transit service</para>
    ///   <a href="http://vocab.gtfs.org/terms#PaymentMethod">gtfs:PaymentMethod</a>
    /// </summary>
    let PaymentMethod = _prefixId.prefix "PaymentMethod"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Pickup Type^^xsd:string</para>
    ///   <para>rdfs:comment : Instances of this class can be used by gtfs:pickupType</para>
    ///   <a href="http://vocab.gtfs.org/terms#PickupType">gtfs:PickupType</a>
    /// </summary>
    let PickupType = _prefixId.prefix "PickupType"
    let Rail = _prefixId.prefix "Rail"
    let RecommendedTransfer = _prefixId.prefix "RecommendedTransfer"
    let Regular = _prefixId.prefix "Regular"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Route</para>
    ///   <para>rdfs:comment : A gtfs:Route is a commercial route followed entirely or partly by gtfs:Trips</para>
    ///   <a href="http://vocab.gtfs.org/terms#Route">gtfs:Route</a>
    /// </summary>
    let Route = _prefixId.prefix "Route"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Route type</para>
    ///   <para>rdfs:comment : Describes the type of transportation used on a route</para>
    ///   <a href="http://vocab.gtfs.org/terms#RouteType">gtfs:RouteType</a>
    /// </summary>
    let RouteType = _prefixId.prefix "RouteType"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>gtfs:comment : A gtfs:Service is a set of gtfs:ServiceRules which can be found in both calendar.txt as calendar_dates.txt</para>
    ///   <para>rdfs:label : Service</para>
    ///   <para>rdfs:comment : A gtfs:Service identifies a set of dates when a service is available for one or more routes</para>
    ///   <a href="http://vocab.gtfs.org/terms#Service">gtfs:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Service rule</para>
    ///   <para>rdfs:comment : One or more service rules define a set of dates</para>
    ///   <a href="http://vocab.gtfs.org/terms#ServiceRule">gtfs:ServiceRule</a>
    /// </summary>
    let ServiceRule = _prefixId.prefix "ServiceRule"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Shape</para>
    ///   <para>rdfs:comment : A polygon formed by gtfs:ShapePoints</para>
    ///   <a href="http://vocab.gtfs.org/terms#Shape">gtfs:Shape</a>
    /// </summary>
    let Shape = _prefixId.prefix "Shape"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Shape Point</para>
    ///   <para>rdfs:comment : A geographic point within a gtfs:Shape</para>
    ///   <a href="http://vocab.gtfs.org/terms#ShapePoint">gtfs:ShapePoint</a>
    /// </summary>
    let ShapePoint = _prefixId.prefix "ShapePoint"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>gtfs:comment : Map a row in stops.txt to gtfs:Station when the location_type is 1.</para>
    ///   <para>rdfs:label : Station</para>
    ///   <para>rdfs:comment : A physical structure or area that contains one or more stop.</para>
    ///   <a href="http://vocab.gtfs.org/terms#Station">gtfs:Station</a>
    /// </summary>
    let Station = _prefixId.prefix "Station"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Stop</para>
    ///   <para>rdfs:comment : A location where passengers board or disembark from a transit vehicle.</para>
    ///   <a href="http://vocab.gtfs.org/terms#Stop">gtfs:Stop</a>
    /// </summary>
    let Stop = _prefixId.prefix "Stop"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Stop time</para>
    ///   <para>rdfs:comment : Describes a stop time as part of a trip</para>
    ///   <a href="http://vocab.gtfs.org/terms#StopTime">gtfs:StopTime</a>
    /// </summary>
    let StopTime = _prefixId.prefix "StopTime"
    let Subway = _prefixId.prefix "Subway"
    let Transfer = _prefixId.prefix "Transfer"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Transfer Rule</para>
    ///   <para>rdfs:comment : Define additional rules for making connections between routes.</para>
    ///   <a href="http://vocab.gtfs.org/terms#TransferRule">gtfs:TransferRule</a>
    /// </summary>
    let TransferRule = _prefixId.prefix "TransferRule"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>gtfs:comment : When transfer_type in transfers.txt is 0 or empty, map to gtfs:RecommendedTransfer, when 1, map to gtfs:EnsuredTransfer, when 2, gtfs:MinimumTimeTransfer, when 3: gtfs:NoTransfer.</para>
    ///   <para>rdfs:label : Transfer Type</para>
    ///   <para>rdfs:comment : Instances of this class can be used to describe how to handle a transfer rule</para>
    ///   <a href="http://vocab.gtfs.org/terms#TransferType">gtfs:TransferType</a>
    /// </summary>
    let TransferType = _prefixId.prefix "TransferType"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Transfers Allowed Type</para>
    ///   <para>rdfs:comment : Instances of this class describe whether tickets remain valid when transferring</para>
    ///   <a href="http://vocab.gtfs.org/terms#TransfersAllowedType">gtfs:TransfersAllowedType</a>
    /// </summary>
    let TransfersAllowedType = _prefixId.prefix "TransfersAllowedType"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Trip</para>
    ///   <para>rdfs:comment : A collection of gtfs:StopTimes followed by a transit vehicle</para>
    ///   <a href="http://vocab.gtfs.org/terms#Trip">gtfs:Trip</a>
    /// </summary>
    let Trip = _prefixId.prefix "Trip"
    let TwoTransfersAllowed = _prefixId.prefix "TwoTransfersAllowed"
    let UnlimitedTransfersAllowed = _prefixId.prefix "UnlimitedTransfersAllowed"
    let WheelchairAccessible = _prefixId.prefix "WheelchairAccessible"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Wheelchair Boarding Information</para>
    ///   <para>rdfs:comment : A class whom's instances indicate how accessible a gtfs:Trip, gtfs:Stop or gtfs:Station is.</para>
    ///   <a href="http://vocab.gtfs.org/terms#WheelchairBoardingStatus">gtfs:WheelchairBoardingStatus</a>
    /// </summary>
    let WheelchairBoardingStatus = _prefixId.prefix "WheelchairBoardingStatus"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Zone</para>
    ///   <para>rdfs:comment : Zones are required if you want to provide fare information using gtfs:FareClass</para>
    ///   <a href="http://vocab.gtfs.org/terms#Zone">gtfs:Zone</a>
    /// </summary>
    let Zone = _prefixId.prefix "Zone"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : agency</para>
    ///   <para>rdfs:comment : links to an agency that this is part of.</para>
    ///   <a href="http://vocab.gtfs.org/terms#agency">gtfs:agency</a>
    /// </summary>
    let agency = _prefixId.prefix "agency"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Arrival time</para>
    ///   <para>rdfs:comment : Check the original specification for special cases</para>
    ///   <a href="http://vocab.gtfs.org/terms#arrivalTime">gtfs:arrivalTime</a>
    /// </summary>
    let arrivalTime = _prefixId.prefix "arrivalTime"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Bikes allowed</para>
    ///   <a href="http://vocab.gtfs.org/terms#bikesAllowed">gtfs:bikesAllowed</a>
    /// </summary>
    let bikesAllowed = _prefixId.prefix "bikesAllowed"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Block</para>
    ///   <para>rdfs:comment : Identifies the block to which the trip within this feed belongs. A block consists of two or more sequential trips made using the same vehicle, where a passenger can transfer from one trip to the next just by staying in the vehicle.</para>
    ///   <a href="http://vocab.gtfs.org/terms#block">gtfs:block</a>
    /// </summary>
    let block = _prefixId.prefix "block"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Color</para>
    ///   <para>rdfs:comment : A 6 character hexidecimal color (without #)</para>
    ///   <a href="http://vocab.gtfs.org/terms#color">gtfs:color</a>
    /// </summary>
    let color = _prefixId.prefix "color"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Mapping comment</para>
    ///   <para>rdfs:comment : A comment on the relation between the RDFS ontology and the CSV specification.</para>
    ///   <a href="http://vocab.gtfs.org/terms#comment">gtfs:comment</a>
    /// </summary>
    let comment = _prefixId.prefix "comment"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>gtfs:comment : The exception_type field in calendar_dates.txt - 1 is true, 2 is false.</para>
    ///   <para>rdfs:label : Date Addition</para>
    ///   <para>rdfs:comment : A boolean whether to add (true) or remove (false) a date</para>
    ///   <a href="http://vocab.gtfs.org/terms#dateAddition">gtfs:dateAddition</a>
    /// </summary>
    let dateAddition = _prefixId.prefix "dateAddition"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Departure time</para>
    ///   <para>rdfs:comment : Check the original specification for special cases</para>
    ///   <a href="http://vocab.gtfs.org/terms#departureTime">gtfs:departureTime</a>
    /// </summary>
    let departureTime = _prefixId.prefix "departureTime"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>gtfs:comment : Map from to_stop_id in transfers.txt</para>
    ///   <para>rdfs:label : Destination Stop</para>
    ///   <para>rdfs:comment : Link to gtfs:Stop to go to</para>
    ///   <a href="http://vocab.gtfs.org/terms#destinationStop">gtfs:destinationStop</a>
    /// </summary>
    let destinationStop = _prefixId.prefix "destinationStop"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Destination Zone</para>
    ///   <para>rdfs:comment : The destination zone where this applies</para>
    ///   <a href="http://vocab.gtfs.org/terms#destinationZone">gtfs:destinationZone</a>
    /// </summary>
    let destinationZone = _prefixId.prefix "destinationZone"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Direction</para>
    ///   <para>rdfs:comment : A binary property to indicate the direction the trip is going (e.g., outbound/inbound, center/airport)</para>
    ///   <a href="http://vocab.gtfs.org/terms#direction">gtfs:direction</a>
    /// </summary>
    let direction = _prefixId.prefix "direction"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Distance Traveled</para>
    ///   <para>rdfs:comment : Positions a stop as a distance from the first shape point. It represents a real distance traveled along the route in units such as feet or kilometers. This information allows the trip planner to determine how much of the shape to draw when showing part of a trip on the map. The values used for gtfs:distanceTraveled must increase along with gtfs:stopSequence: they cannot be used to show reverse travel along a route.</para>
    ///   <a href="http://vocab.gtfs.org/terms#distanceTraveled">gtfs:distanceTraveled</a>
    /// </summary>
    let distanceTraveled = _prefixId.prefix "distanceTraveled"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Drop off type</para>
    ///   <para>rdfs:comment : Which type of drop off</para>
    ///   <a href="http://vocab.gtfs.org/terms#dropOffType">gtfs:dropOffType</a>
    /// </summary>
    let dropOffType = _prefixId.prefix "dropOffType"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : End Time</para>
    ///   <para>rdfs:comment : </para>
    ///   <a href="http://vocab.gtfs.org/terms#endTime">gtfs:endTime</a>
    /// </summary>
    let endTime = _prefixId.prefix "endTime"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : fare URL</para>
    ///   <para>rdfs:comment : The URL of a web page that allows a rider to purchase tickets or other fare instruments for that agency online</para>
    ///   <a href="http://vocab.gtfs.org/terms#fareUrl">gtfs:fareUrl</a>
    /// </summary>
    let fareUrl = _prefixId.prefix "fareUrl"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Friday</para>
    ///   <para>rdfs:comment : Service is available on Friday</para>
    ///   <a href="http://vocab.gtfs.org/terms#friday">gtfs:friday</a>
    /// </summary>
    let friday = _prefixId.prefix "friday"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Headsign</para>
    ///   <para>rdfs:comment : The gtfs:headsign property contains the text that appears on a sign that identifies the trip's destination to passengers.</para>
    ///   <a href="http://vocab.gtfs.org/terms#headsign">gtfs:headsign</a>
    /// </summary>
    let headsign = _prefixId.prefix "headsign"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Headway Seconds</para>
    ///   <para>rdfs:comment : Indicates the time between departures from the same stop (headway) for this trip type, during the time interval specified by gtfs:startTime and gtfs:endTime.</para>
    ///   <a href="http://vocab.gtfs.org/terms#headwaySeconds">gtfs:headwaySeconds</a>
    /// </summary>
    let headwaySeconds = _prefixId.prefix "headwaySeconds"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Long name</para>
    ///   <para>rdfs:comment : Long name given to a route</para>
    ///   <a href="http://vocab.gtfs.org/terms#longName">gtfs:longName</a>
    /// </summary>
    let longName = _prefixId.prefix "longName"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Minimum Transfer Time</para>
    ///   <para>rdfs:comment : The minimum transfer time when the gtfs:transferType is gtfs:MinimumTimeTransfer.</para>
    ///   <a href="http://vocab.gtfs.org/terms#minimumTransferTime">gtfs:minimumTransferTime</a>
    /// </summary>
    let minimumTransferTime = _prefixId.prefix "minimumTransferTime"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Monday</para>
    ///   <para>rdfs:comment : Service is available on Monday</para>
    ///   <a href="http://vocab.gtfs.org/terms#monday">gtfs:monday</a>
    /// </summary>
    let monday = _prefixId.prefix "monday"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>gtfs:comment : Map from from_stop_id in transfers.txt</para>
    ///   <para>rdfs:label : Origin Stop</para>
    ///   <para>rdfs:comment : Link to gtfs:Stop to start from</para>
    ///   <a href="http://vocab.gtfs.org/terms#originStop">gtfs:originStop</a>
    /// </summary>
    let originStop = _prefixId.prefix "originStop"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Origin Zone</para>
    ///   <para>rdfs:comment : The origin zone where this applies</para>
    ///   <a href="http://vocab.gtfs.org/terms#originZone">gtfs:originZone</a>
    /// </summary>
    let originZone = _prefixId.prefix "originZone"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>gtfs:comment : Links to a row in stop.txt where locationType=1.</para>
    ///   <para>rdfs:label : Parent Station</para>
    ///   <para>rdfs:comment : gtfs:parentStation identifies the station associated with the stop</para>
    ///   <a href="http://vocab.gtfs.org/terms#parentStation">gtfs:parentStation</a>
    /// </summary>
    let parentStation = _prefixId.prefix "parentStation"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>gtfs:comment : payment_method field in fare_attributes. If 0, use gtfs:OnBoard; if 1, use gtfs:BeforeBoarding</para>
    ///   <para>rdfs:label : Payment method</para>
    ///   <para>rdfs:comment : The payment method</para>
    ///   <a href="http://vocab.gtfs.org/terms#paymentMethod">gtfs:paymentMethod</a>
    /// </summary>
    let paymentMethod = _prefixId.prefix "paymentMethod"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Pickup type</para>
    ///   <para>rdfs:comment : Which type of pickup</para>
    ///   <a href="http://vocab.gtfs.org/terms#pickupType">gtfs:pickupType</a>
    /// </summary>
    let pickupType = _prefixId.prefix "pickupType"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Point Sequence</para>
    ///   <para>rdfs:comment : The shape_pt_sequence field associates the latitude and longitude of a shape point with its sequence order along the shape. The values for shape_pt_sequence must be non-negative integers, and they must increase along the trip.</para>
    ///   <a href="http://vocab.gtfs.org/terms#pointSequence">gtfs:pointSequence</a>
    /// </summary>
    let pointSequence = _prefixId.prefix "pointSequence"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Route</para>
    ///   <para>rdfs:comment : This thing is applicable to this gtfs:Route</para>
    ///   <a href="http://vocab.gtfs.org/terms#route">gtfs:route</a>
    /// </summary>
    let route = _prefixId.prefix "route"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:kabel : Route type</para>
    ///   <para>rdfs:comment : Links to the type of vehicle operating this on route</para>
    ///   <a href="http://vocab.gtfs.org/terms#routeType">gtfs:routeType</a>
    /// </summary>
    let routeType = _prefixId.prefix "routeType"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Saturday</para>
    ///   <para>rdfs:comment : Service is available on Saturday</para>
    ///   <a href="http://vocab.gtfs.org/terms#saturday">gtfs:saturday</a>
    /// </summary>
    let saturday = _prefixId.prefix "saturday"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Service</para>
    ///   <para>rdfs:comment : Follows this gtfs:Service.</para>
    ///   <a href="http://vocab.gtfs.org/terms#service">gtfs:service</a>
    /// </summary>
    let service = _prefixId.prefix "service"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Service rule</para>
    ///   <para>rdfs:comment : Service rules which define together a set of dates</para>
    ///   <a href="http://vocab.gtfs.org/terms#serviceRule">gtfs:serviceRule</a>
    /// </summary>
    let serviceRule = _prefixId.prefix "serviceRule"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Shape</para>
    ///   <para>rdfs:comment : a link to a shape the trip follows.</para>
    ///   <a href="http://vocab.gtfs.org/terms#shape">gtfs:shape</a>
    /// </summary>
    let shape = _prefixId.prefix "shape"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Shape Point</para>
    ///   <para>rdfs:comment : Links to a gtfs:ShapePoint</para>
    ///   <a href="http://vocab.gtfs.org/terms#shapePoint">gtfs:shapePoint</a>
    /// </summary>
    let shapePoint = _prefixId.prefix "shapePoint"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Short name</para>
    ///   <para>rdfs:comment : Short name given to a route or a trip</para>
    ///   <a href="http://vocab.gtfs.org/terms#shortName">gtfs:shortName</a>
    /// </summary>
    let shortName = _prefixId.prefix "shortName"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Start Time</para>
    ///   <para>rdfs:comment : Specifies the time at which service begins with the specified frequency</para>
    ///   <a href="http://vocab.gtfs.org/terms#startTime">gtfs:startTime</a>
    /// </summary>
    let startTime = _prefixId.prefix "startTime"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Stop</para>
    ///   <para>rdfs:comment : Indicates that this has a certain stop.</para>
    ///   <a href="http://vocab.gtfs.org/terms#stop">gtfs:stop</a>
    /// </summary>
    let stop = _prefixId.prefix "stop"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Stop sequence</para>
    ///   <para>rdfs:comment : The stopSequence property identifies the order of the stops for a particular trip. The values must increase along the gtfs:Trip referenced in the gtfs:trip property.</para>
    ///   <a href="http://vocab.gtfs.org/terms#stopSequence">gtfs:stopSequence</a>
    /// </summary>
    let stopSequence = _prefixId.prefix "stopSequence"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Sunday</para>
    ///   <para>rdfs:comment : Service is available on Sunday</para>
    ///   <a href="http://vocab.gtfs.org/terms#sunday">gtfs:sunday</a>
    /// </summary>
    let sunday = _prefixId.prefix "sunday"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Text color</para>
    ///   <para>rdfs:comment : A 6 character hexidecimal color (without #) asigned to a text label.</para>
    ///   <a href="http://vocab.gtfs.org/terms#textColor">gtfs:textColor</a>
    /// </summary>
    let textColor = _prefixId.prefix "textColor"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Thursday</para>
    ///   <para>rdfs:comment : Service is available on Thursday</para>
    ///   <a href="http://vocab.gtfs.org/terms#thursday">gtfs:thursday</a>
    /// </summary>
    let thursday = _prefixId.prefix "thursday"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : Time zone</para>
    ///   <para>rdfs:comment : The timezone where a person or organisation is located.</para>
    ///   <a href="http://vocab.gtfs.org/terms#timeZone">gtfs:timeZone</a>
    /// </summary>
    let timeZone = _prefixId.prefix "timeZone"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Transfer Expiry Time</para>
    ///   <para>rdfs:comment : The time a ticket remains valid when having left the previous vehicle</para>
    ///   <a href="http://vocab.gtfs.org/terms#transferExpiryTime">gtfs:transferExpiryTime</a>
    /// </summary>
    let transferExpiryTime = _prefixId.prefix "transferExpiryTime"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Transfer Type</para>
    ///   <a href="http://vocab.gtfs.org/terms#transferType">gtfs:transferType</a>
    /// </summary>
    let transferType = _prefixId.prefix "transferType"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>gtfs:comment : Map to 0 to gtfs:NoTransfersAllowed, 1 to gtfs:OneTransferAllowed, 2 to gtfs:TwoTransfersAllowed and empty to gtfs:UnlimitedTransfersAllowed</para>
    ///   <para>rdfs:label : Transfers</para>
    ///   <para>rdfs:comment : The validity of the ticket when transferring</para>
    ///   <a href="http://vocab.gtfs.org/terms#transfers">gtfs:transfers</a>
    /// </summary>
    let transfers = _prefixId.prefix "transfers"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Trip</para>
    ///   <para>rdfs:comment : Indictates that this is part of a certain gtfs:Trip</para>
    ///   <a href="http://vocab.gtfs.org/terms#trip">gtfs:trip</a>
    /// </summary>
    let trip = _prefixId.prefix "trip"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Tuesday</para>
    ///   <para>rdfs:comment : Service is available on Tuesday</para>
    ///   <a href="http://vocab.gtfs.org/terms#tuesday">gtfs:tuesday</a>
    /// </summary>
    let tuesday = _prefixId.prefix "tuesday"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>gtfs:comment : This is false when exact_times for this row is 0 or empty, true when it is 1</para>
    ///   <para>rdfs:label : Frequency uses exact times</para>
    ///   <a href="http://vocab.gtfs.org/terms#usesExactTimes">gtfs:usesExactTimes</a>
    /// </summary>
    let usesExactTimes = _prefixId.prefix "usesExactTimes"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Wednesday</para>
    ///   <para>rdfs:comment : Service is available on Wednesday</para>
    ///   <a href="http://vocab.gtfs.org/terms#wednesday">gtfs:wednesday</a>
    /// </summary>
    let wednesday = _prefixId.prefix "wednesday"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>gtfs:comment : When wheelchair_accessible is 0, map to gtfs:CheckParentStation; if 1 map to gtfs:WheelchairAccessible; if 2 map to gtfs:NotWheelchairAccessible.</para>
    ///   <para>rdfs:label : wheelchair boarding</para>
    ///   <para>rdfs:comment : Wheelchair boardings are possible from the specified stop or station. If this stop is part of a station, there is also a wheelchair accessible path from outside the station towards the stop.</para>
    ///   <a href="http://vocab.gtfs.org/terms#wheelchairAccessible">gtfs:wheelchairAccessible</a>
    /// </summary>
    let wheelchairAccessible = _prefixId.prefix "wheelchairAccessible"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>gtfs:comment : You can create a new URI per zone, or just keep it an integer as per your own taste.</para>
    ///   <para>rdfs:label : Zone</para>
    ///   <para>rdfs:comment : A gtfs:Stop defines the fare zone. Zones are required if you want to provide fare information using gtfs:FareClass.</para>
    ///   <a href="http://vocab.gtfs.org/terms#zone">gtfs:zone</a>
    /// </summary>
    let zone = _prefixId.prefix "zone"
