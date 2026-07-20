namespace http.vocab.gtfs.org.terms.hash

open DoxAletheia

module gtfs =
    let _namespace_name = "http://vocab.gtfs.org/terms#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Gondola, Suspended cable car. Typically used for aerial cable cars where the car is suspended from the cable.
    /// <see href="http://vocab.gtfs.org/terms#:Gondola"></see></summary>
    let ``_:Gondola`` = _prefix ":Gondola"
    /// <summary>
    /// Describes the type of transportation used on a route
    /// <see href="http://vocab.gtfs.org/terms#RouteType"></see></summary>
    let RouteType = _prefix "RouteType"
    /// <summary>
    /// An agency operates a certain schedule based transport mode
    /// <see href="http://vocab.gtfs.org/terms#Agency"></see></summary>
    let Agency = _prefix "Agency"
    /// <summary>
    /// Ticket should be bought before boarding
    /// <see href="http://vocab.gtfs.org/terms#BeforeBoarding"></see></summary>
    let BeforeBoarding = _prefix "BeforeBoarding"
    /// <summary>
    /// Method to pay for the public transit service
    /// <see href="http://vocab.gtfs.org/terms#PaymentMethod"></see></summary>
    let PaymentMethod = _prefix "PaymentMethod"
    /// <summary>
    /// Used for short- and long-distance bus routes.
    /// <see href="http://vocab.gtfs.org/terms#Bus"></see></summary>
    let Bus = _prefix "Bus"
    /// <summary>
    /// Used for street-level cable cars where the cable runs beneath the car.
    /// <see href="http://vocab.gtfs.org/terms#CableCar"></see></summary>
    let CableCar = _prefix "CableCar"
    /// <summary>
    /// Defines service availability for a specific date
    /// <see href="http://vocab.gtfs.org/terms#CalendarDateRule"></see></summary>
    let CalendarDateRule = _prefix "CalendarDateRule"
    /// <summary>
    /// A comment on the relation between the RDFS ontology and the CSV specification.
    /// <see href="http://vocab.gtfs.org/terms#comment"></see></summary>
    let comment = _prefix "comment"
    /// <summary>
    /// One or more service rules define a set of dates
    /// <see href="http://vocab.gtfs.org/terms#ServiceRule"></see></summary>
    let ServiceRule = _prefix "ServiceRule"
    /// <summary>
    /// Defines on which days of the week for a certain period the service is available.
    /// <see href="http://vocab.gtfs.org/terms#CalendarRule"></see></summary>
    let CalendarRule = _prefix "CalendarRule"
    /// <summary>
    /// Check the (parent) station for accessibility infomration.
    /// <see href="http://vocab.gtfs.org/terms#CheckParentStation"></see></summary>
    let CheckParentStation = _prefix "CheckParentStation"
    /// <summary>
    /// A class whom's instances indicate how accessible a gtfs:Trip, gtfs:Stop or gtfs:Station is.
    /// <see href="http://vocab.gtfs.org/terms#WheelchairBoardingStatus"></see></summary>
    let WheelchairBoardingStatus = _prefix "WheelchairBoardingStatus"
    /// <summary>
    /// Instances of this class can be used by gtfs:dropOffType
    /// <see href="http://vocab.gtfs.org/terms#DropOffType"></see></summary>
    let DropOffType = _prefix "DropOffType"
    /// <summary>
    /// This is a timed transfer point between two routes. The departing vehicle is expected to wait for the arriving one, with sufficient time for a passenger to transfer between routes.
    /// <see href="http://vocab.gtfs.org/terms#EnsuredTransfer"></see></summary>
    let EnsuredTransfer = _prefix "EnsuredTransfer"
    /// <summary>
    /// Instances of this class can be used to describe how to handle a transfer rule
    /// <see href="http://vocab.gtfs.org/terms#TransferType"></see></summary>
    let TransferType = _prefix "TransferType"
    /// <summary>
    /// A class describing how the fare is calculated.
    /// <see href="http://vocab.gtfs.org/terms#FareClass"></see></summary>
    let FareClass = _prefix "FareClass"
    /// <summary>
    /// A rule which binds a gtfs:FareClass to a part of the network.
    /// <see href="http://vocab.gtfs.org/terms#FareRule"></see></summary>
    let FareRule = _prefix "FareRule"
    /// <summary>
    /// An instance of a gtfs:Feed is a linked GTFS feed that complies to this specification.
    /// <see href="http://vocab.gtfs.org/terms#Feed"></see></summary>
    let Feed = _prefix "Feed"
    /// <summary>
    /// Used for short- and long-distance boat service.
    /// <see href="http://vocab.gtfs.org/terms#Ferry"></see></summary>
    let Ferry = _prefix "Ferry"
    /// <summary>
    /// An alternative to defining departures and arrivals as StopTimes: define frequencies for transit vehicle
    /// <see href="http://vocab.gtfs.org/terms#Frequency"></see></summary>
    let Frequency = _prefix "Frequency"
    /// <summary>
    /// Any rail system designed for steep inclines.
    /// <see href="http://vocab.gtfs.org/terms#Funicular"></see></summary>
    let Funicular = _prefix "Funicular"
    /// <summary>
    /// Any light rail or street level system within a metropolitan area.
    /// <see href="http://vocab.gtfs.org/terms#LightRail"></see></summary>
    let LightRail = _prefix "LightRail"
    /// <summary>
    /// This transfer requires a minimum amount of time between arrival and departure to ensure a connection. The time required to transfer is specified by gtfs:minimumTransferTime
    /// <see href="http://vocab.gtfs.org/terms#MinimumTimeTransfer"></see></summary>
    let MinimumTimeTransfer = _prefix "MinimumTimeTransfer"
    /// <summary>
    ///   <see href="http://vocab.gtfs.org/terms#MustCoordinateWithDriver"></see>
    /// </summary>
    let MustCoordinateWithDriver = _prefix "MustCoordinateWithDriver"
    /// <summary>
    /// Instances of this class can be used by gtfs:pickupType
    /// <see href="http://vocab.gtfs.org/terms#PickupType"></see></summary>
    let PickupType = _prefix "PickupType"
    /// <summary>
    ///   <see href="http://vocab.gtfs.org/terms#MustPhone"></see>
    /// </summary>
    let MustPhone = _prefix "MustPhone"
    /// <summary>
    /// Transfers are not possible between routes at this location.
    /// <see href="http://vocab.gtfs.org/terms#NoTransfer"></see></summary>
    let NoTransfer = _prefix "NoTransfer"
    /// <summary>
    /// Indicate that a passenger should buy a new ticket when transferring
    /// <see href="http://vocab.gtfs.org/terms#NoTransfersAllowed"></see></summary>
    let NoTransfersAllowed = _prefix "NoTransfersAllowed"
    /// <summary>
    /// Instances of this class describe whether tickets remain valid when transferring
    /// <see href="http://vocab.gtfs.org/terms#TransfersAllowedType"></see></summary>
    let TransfersAllowedType = _prefix "TransfersAllowedType"
    /// <summary>
    ///   <see href="http://vocab.gtfs.org/terms#NotAvailable"></see>
    /// </summary>
    let NotAvailable = _prefix "NotAvailable"
    /// <summary>
    /// No riders in wheelchairs can be accommodated on this trip or wheelchair boarding is not possible at this stop and/or there exists no accessible path from outside the station to the specific stop.
    /// <see href="http://vocab.gtfs.org/terms#NotWheelchairAccessible"></see></summary>
    let NotWheelchairAccessible = _prefix "NotWheelchairAccessible"
    /// <summary>
    /// Fare should be bought on board
    /// <see href="http://vocab.gtfs.org/terms#OnBoard"></see></summary>
    let OnBoard = _prefix "OnBoard"
    /// <summary>
    /// Indicate that a passenger should buy a new ticket when transferring a second time
    /// <see href="http://vocab.gtfs.org/terms#OneTransfersAllowed"></see></summary>
    let OneTransfersAllowed = _prefix "OneTransfersAllowed"
    /// <summary>
    /// Used for intercity or long-distance travel.
    /// <see href="http://vocab.gtfs.org/terms#Rail"></see></summary>
    let Rail = _prefix "Rail"
    /// <summary>
    /// This is a recommended transfer point between two routes
    /// <see href="http://vocab.gtfs.org/terms#RecommendedTransfer"></see></summary>
    let RecommendedTransfer = _prefix "RecommendedTransfer"
    /// <summary>
    ///   <see href="http://vocab.gtfs.org/terms#Regular"></see>
    /// </summary>
    let Regular = _prefix "Regular"
    /// <summary>
    /// A gtfs:Route is a commercial route followed entirely or partly by gtfs:Trips
    /// <see href="http://vocab.gtfs.org/terms#Route"></see></summary>
    let Route = _prefix "Route"
    /// <summary>
    /// A gtfs:Service identifies a set of dates when a service is available for one or more routes
    /// <see href="http://vocab.gtfs.org/terms#Service"></see></summary>
    let Service = _prefix "Service"
    /// <summary>
    /// A polygon formed by gtfs:ShapePoints
    /// <see href="http://vocab.gtfs.org/terms#Shape"></see></summary>
    let Shape = _prefix "Shape"
    /// <summary>
    /// A geographic point within a gtfs:Shape
    /// <see href="http://vocab.gtfs.org/terms#ShapePoint"></see></summary>
    let ShapePoint = _prefix "ShapePoint"
    /// <summary>
    /// A physical structure or area that contains one or more stop.
    /// <see href="http://vocab.gtfs.org/terms#Station"></see></summary>
    let Station = _prefix "Station"
    /// <summary>
    /// A location where passengers board or disembark from a transit vehicle.
    /// <see href="http://vocab.gtfs.org/terms#Stop"></see></summary>
    let Stop = _prefix "Stop"
    /// <summary>
    /// Describes a stop time as part of a trip
    /// <see href="http://vocab.gtfs.org/terms#StopTime"></see></summary>
    let StopTime = _prefix "StopTime"
    /// <summary>
    /// Any underground rail system within a metropolitan area.
    /// <see href="http://vocab.gtfs.org/terms#Subway"></see></summary>
    let Subway = _prefix "Subway"
    /// <summary>
    /// Define additional rules for making connections between routes.
    /// <see href="http://vocab.gtfs.org/terms#TransferRule"></see></summary>
    let TransferRule = _prefix "TransferRule"
    /// <summary>
    /// A collection of gtfs:StopTimes followed by a transit vehicle
    /// <see href="http://vocab.gtfs.org/terms#Trip"></see></summary>
    let Trip = _prefix "Trip"
    /// <summary>
    /// Indicate that a passenger should buy a new ticket when transferring for the third time
    /// <see href="http://vocab.gtfs.org/terms#TwoTransfersAllowed"></see></summary>
    let TwoTransfersAllowed = _prefix "TwoTransfersAllowed"
    /// <summary>
    /// Indicate that a passenger should buy a new ticket when transferring for the third time
    /// <see href="http://vocab.gtfs.org/terms#UnlimitedTransfersAllowed"></see></summary>
    let UnlimitedTransfersAllowed = _prefix "UnlimitedTransfersAllowed"
    /// <summary>
    /// Indicates that the vehicle being used on this particular trip can accommodate at least one rider in a wheelchair, or identifies that wheelchair boardings are possible from the specified stop, some trips at this stop are accessible by wheelchair and if this stop has a parentStation, there exists some accessible path from outside the station to the specific stop.
    /// <see href="http://vocab.gtfs.org/terms#WheelchairAccessible"></see></summary>
    let WheelchairAccessible = _prefix "WheelchairAccessible"
    /// <summary>
    /// Zones are required if you want to provide fare information using gtfs:FareClass
    /// <see href="http://vocab.gtfs.org/terms#Zone"></see></summary>
    let Zone = _prefix "Zone"
    /// <summary>
    /// links to an agency that this is part of.
    /// <see href="http://vocab.gtfs.org/terms#agency"></see></summary>
    let agency = _prefix "agency"
    /// <summary>
    /// Check the original specification for special cases
    /// <see href="http://vocab.gtfs.org/terms#arrivalTime"></see></summary>
    let arrivalTime = _prefix "arrivalTime"
    /// <summary>
    ///   <see href="http://vocab.gtfs.org/terms#bikesAllowed"></see>
    /// </summary>
    let bikesAllowed = _prefix "bikesAllowed"
    /// <summary>
    /// Identifies the block to which the trip within this feed belongs. A block consists of two or more sequential trips made using the same vehicle, where a passenger can transfer from one trip to the next just by staying in the vehicle.
    /// <see href="http://vocab.gtfs.org/terms#block"></see></summary>
    let block = _prefix "block"
    /// <summary>
    /// A 6 character hexidecimal color (without #)
    /// <see href="http://vocab.gtfs.org/terms#color"></see></summary>
    let color = _prefix "color"
    /// <summary>
    /// A boolean whether to add (true) or remove (false) a date
    /// <see href="http://vocab.gtfs.org/terms#dateAddition"></see></summary>
    let dateAddition = _prefix "dateAddition"
    /// <summary>
    /// Check the original specification for special cases
    /// <see href="http://vocab.gtfs.org/terms#departureTime"></see></summary>
    let departureTime = _prefix "departureTime"
    /// <summary>
    /// Link to gtfs:Stop to go to
    /// <see href="http://vocab.gtfs.org/terms#destinationStop"></see></summary>
    let destinationStop = _prefix "destinationStop"
    /// <summary>
    /// The destination zone where this applies
    /// <see href="http://vocab.gtfs.org/terms#destinationZone"></see></summary>
    let destinationZone = _prefix "destinationZone"
    /// <summary>
    /// A binary property to indicate the direction the trip is going (e.g., outbound/inbound, center/airport)
    /// <see href="http://vocab.gtfs.org/terms#direction"></see></summary>
    let direction = _prefix "direction"
    /// <summary>
    /// Positions a stop as a distance from the first shape point. It represents a real distance traveled along the route in units such as feet or kilometers. This information allows the trip planner to determine how much of the shape to draw when showing part of a trip on the map. The values used for gtfs:distanceTraveled must increase along with gtfs:stopSequence: they cannot be used to show reverse travel along a route.
    /// <see href="http://vocab.gtfs.org/terms#distanceTraveled"></see></summary>
    let distanceTraveled = _prefix "distanceTraveled"
    /// <summary>
    /// Which type of drop off
    /// <see href="http://vocab.gtfs.org/terms#dropOffType"></see></summary>
    let dropOffType = _prefix "dropOffType"
    /// <summary>
    ///   <see href="http://vocab.gtfs.org/terms#endTime"></see>
    /// </summary>
    let endTime = _prefix "endTime"
    /// <summary>
    /// The URL of a web page that allows a rider to purchase tickets or other fare instruments for that agency online
    /// <see href="http://vocab.gtfs.org/terms#fareUrl"></see></summary>
    let fareUrl = _prefix "fareUrl"
    /// <summary>
    /// Service is available on Friday
    /// <see href="http://vocab.gtfs.org/terms#friday"></see></summary>
    let friday = _prefix "friday"
    /// <summary>
    /// The gtfs:headsign property contains the text that appears on a sign that identifies the trip's destination to passengers.
    /// <see href="http://vocab.gtfs.org/terms#headsign"></see></summary>
    let headsign = _prefix "headsign"
    /// <summary>
    /// Indicates the time between departures from the same stop (headway) for this trip type, during the time interval specified by gtfs:startTime and gtfs:endTime.
    /// <see href="http://vocab.gtfs.org/terms#headwaySeconds"></see></summary>
    let headwaySeconds = _prefix "headwaySeconds"
    /// <summary>
    /// Long name given to a route
    /// <see href="http://vocab.gtfs.org/terms#longName"></see></summary>
    let longName = _prefix "longName"
    /// <summary>
    /// The minimum transfer time when the gtfs:transferType is gtfs:MinimumTimeTransfer.
    /// <see href="http://vocab.gtfs.org/terms#minimumTransferTime"></see></summary>
    let minimumTransferTime = _prefix "minimumTransferTime"
    /// <summary>
    /// Service is available on Monday
    /// <see href="http://vocab.gtfs.org/terms#monday"></see></summary>
    let monday = _prefix "monday"
    /// <summary>
    /// Link to gtfs:Stop to start from
    /// <see href="http://vocab.gtfs.org/terms#originStop"></see></summary>
    let originStop = _prefix "originStop"
    /// <summary>
    /// The origin zone where this applies
    /// <see href="http://vocab.gtfs.org/terms#originZone"></see></summary>
    let originZone = _prefix "originZone"
    /// <summary>
    /// gtfs:parentStation identifies the station associated with the stop
    /// <see href="http://vocab.gtfs.org/terms#parentStation"></see></summary>
    let parentStation = _prefix "parentStation"
    /// <summary>
    /// The payment method
    /// <see href="http://vocab.gtfs.org/terms#paymentMethod"></see></summary>
    let paymentMethod = _prefix "paymentMethod"
    /// <summary>
    /// Which type of pickup
    /// <see href="http://vocab.gtfs.org/terms#pickupType"></see></summary>
    let pickupType = _prefix "pickupType"
    /// <summary>
    /// The shape_pt_sequence field associates the latitude and longitude of a shape point with its sequence order along the shape. The values for shape_pt_sequence must be non-negative integers, and they must increase along the trip.
    /// <see href="http://vocab.gtfs.org/terms#pointSequence"></see></summary>
    let pointSequence = _prefix "pointSequence"
    /// <summary>
    /// This thing is applicable to this gtfs:Route
    /// <see href="http://vocab.gtfs.org/terms#route"></see></summary>
    let route = _prefix "route"
    /// <summary>
    /// Links to the type of vehicle operating this on route
    /// <see href="http://vocab.gtfs.org/terms#routeType"></see></summary>
    let routeType = _prefix "routeType"
    /// <summary>
    /// Service is available on Saturday
    /// <see href="http://vocab.gtfs.org/terms#saturday"></see></summary>
    let saturday = _prefix "saturday"
    /// <summary>
    /// Follows this gtfs:Service.
    /// <see href="http://vocab.gtfs.org/terms#service"></see></summary>
    let service = _prefix "service"
    /// <summary>
    /// Service rules which define together a set of dates
    /// <see href="http://vocab.gtfs.org/terms#serviceRule"></see></summary>
    let serviceRule = _prefix "serviceRule"
    /// <summary>
    /// a link to a shape the trip follows.
    /// <see href="http://vocab.gtfs.org/terms#shape"></see></summary>
    let shape = _prefix "shape"
    /// <summary>
    /// Links to a gtfs:ShapePoint
    /// <see href="http://vocab.gtfs.org/terms#shapePoint"></see></summary>
    let shapePoint = _prefix "shapePoint"
    /// <summary>
    /// Short name given to a route or a trip
    /// <see href="http://vocab.gtfs.org/terms#shortName"></see></summary>
    let shortName = _prefix "shortName"
    /// <summary>
    /// Specifies the time at which service begins with the specified frequency
    /// <see href="http://vocab.gtfs.org/terms#startTime"></see></summary>
    let startTime = _prefix "startTime"
    /// <summary>
    /// Indicates that this has a certain stop.
    /// <see href="http://vocab.gtfs.org/terms#stop"></see></summary>
    let stop = _prefix "stop"
    /// <summary>
    /// The stopSequence property identifies the order of the stops for a particular trip. The values must increase along the gtfs:Trip referenced in the gtfs:trip property.
    /// <see href="http://vocab.gtfs.org/terms#stopSequence"></see></summary>
    let stopSequence = _prefix "stopSequence"
    /// <summary>
    /// Service is available on Sunday
    /// <see href="http://vocab.gtfs.org/terms#sunday"></see></summary>
    let sunday = _prefix "sunday"
    /// <summary>
    /// A 6 character hexidecimal color (without #) asigned to a text label.
    /// <see href="http://vocab.gtfs.org/terms#textColor"></see></summary>
    let textColor = _prefix "textColor"
    /// <summary>
    /// Service is available on Thursday
    /// <see href="http://vocab.gtfs.org/terms#thursday"></see></summary>
    let thursday = _prefix "thursday"
    /// <summary>
    /// The timezone where a person or organisation is located.
    /// <see href="http://vocab.gtfs.org/terms#timeZone"></see></summary>
    let timeZone = _prefix "timeZone"
    /// <summary>
    /// The time a ticket remains valid when having left the previous vehicle
    /// <see href="http://vocab.gtfs.org/terms#transferExpiryTime"></see></summary>
    let transferExpiryTime = _prefix "transferExpiryTime"
    /// <summary>
    ///   <see href="http://vocab.gtfs.org/terms#transferType"></see>
    /// </summary>
    let transferType = _prefix "transferType"
    /// <summary>
    ///   <see href="http://vocab.gtfs.org/terms#Transfer"></see>
    /// </summary>
    let Transfer = _prefix "Transfer"
    /// <summary>
    /// The validity of the ticket when transferring
    /// <see href="http://vocab.gtfs.org/terms#transfers"></see></summary>
    let transfers = _prefix "transfers"
    /// <summary>
    /// Indictates that this is part of a certain gtfs:Trip
    /// <see href="http://vocab.gtfs.org/terms#trip"></see></summary>
    let trip = _prefix "trip"
    /// <summary>
    /// Service is available on Tuesday
    /// <see href="http://vocab.gtfs.org/terms#tuesday"></see></summary>
    let tuesday = _prefix "tuesday"
    /// <summary>
    ///   <see href="http://vocab.gtfs.org/terms#usesExactTimes"></see>
    /// </summary>
    let usesExactTimes = _prefix "usesExactTimes"
    /// <summary>
    /// Service is available on Wednesday
    /// <see href="http://vocab.gtfs.org/terms#wednesday"></see></summary>
    let wednesday = _prefix "wednesday"
    /// <summary>
    /// Wheelchair boardings are possible from the specified stop or station. If this stop is part of a station, there is also a wheelchair accessible path from outside the station towards the stop.
    /// <see href="http://vocab.gtfs.org/terms#wheelchairAccessible"></see></summary>
    let wheelchairAccessible = _prefix "wheelchairAccessible"
    /// <summary>
    /// A gtfs:Stop defines the fare zone. Zones are required if you want to provide fare information using gtfs:FareClass.
    /// <see href="http://vocab.gtfs.org/terms#zone"></see></summary>
    let zone = _prefix "zone"
