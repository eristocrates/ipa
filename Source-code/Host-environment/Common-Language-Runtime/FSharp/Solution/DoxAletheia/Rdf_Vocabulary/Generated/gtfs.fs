namespace http.vocab.gtfs.org.terms.hash

open DoxAletheia.Rdf_Vocabulary

module gtfs =
    let _namespace_name = "http://vocab.gtfs.org/terms#"

    /// <summary>
    /// Gondola, Suspended cable car. Typically used for aerial cable cars where the car is suspended from the cable.
    /// <see href="http://vocab.gtfs.org/terms#:Gondola"></see></summary>
    let ``_:Gondola`` =
        Namespaced_IRI.parse _namespace_name ":Gondola" |> NamespacedName

    /// <summary>
    /// Describes the type of transportation used on a route
    /// <see href="http://vocab.gtfs.org/terms#RouteType"></see></summary>
    let RouteType = Namespaced_IRI.parse _namespace_name "RouteType" |> NamespacedName
    /// <summary>
    /// An agency operates a certain schedule based transport mode
    /// <see href="http://vocab.gtfs.org/terms#Agency"></see></summary>
    let Agency = Namespaced_IRI.parse _namespace_name "Agency" |> NamespacedName

    /// <summary>
    /// Ticket should be bought before boarding
    /// <see href="http://vocab.gtfs.org/terms#BeforeBoarding"></see></summary>
    let BeforeBoarding =
        Namespaced_IRI.parse _namespace_name "BeforeBoarding" |> NamespacedName

    /// <summary>
    /// Method to pay for the public transit service
    /// <see href="http://vocab.gtfs.org/terms#PaymentMethod"></see></summary>
    let PaymentMethod =
        Namespaced_IRI.parse _namespace_name "PaymentMethod" |> NamespacedName

    /// <summary>
    /// Used for short- and long-distance bus routes.
    /// <see href="http://vocab.gtfs.org/terms#Bus"></see></summary>
    let Bus = Namespaced_IRI.parse _namespace_name "Bus" |> NamespacedName
    /// <summary>
    /// Used for street-level cable cars where the cable runs beneath the car.
    /// <see href="http://vocab.gtfs.org/terms#CableCar"></see></summary>
    let CableCar = Namespaced_IRI.parse _namespace_name "CableCar" |> NamespacedName

    /// <summary>
    /// Defines service availability for a specific date
    /// <see href="http://vocab.gtfs.org/terms#CalendarDateRule"></see></summary>
    let CalendarDateRule =
        Namespaced_IRI.parse _namespace_name "CalendarDateRule" |> NamespacedName

    /// <summary>
    /// A comment on the relation between the RDFS ontology and the CSV specification.
    /// <see href="http://vocab.gtfs.org/terms#comment"></see></summary>
    let comment = Namespaced_IRI.parse _namespace_name "comment" |> NamespacedName

    /// <summary>
    /// One or more service rules define a set of dates
    /// <see href="http://vocab.gtfs.org/terms#ServiceRule"></see></summary>
    let ServiceRule =
        Namespaced_IRI.parse _namespace_name "ServiceRule" |> NamespacedName

    /// <summary>
    /// Defines on which days of the week for a certain period the service is available.
    /// <see href="http://vocab.gtfs.org/terms#CalendarRule"></see></summary>
    let CalendarRule =
        Namespaced_IRI.parse _namespace_name "CalendarRule" |> NamespacedName

    /// <summary>
    /// Check the (parent) station for accessibility infomration.
    /// <see href="http://vocab.gtfs.org/terms#CheckParentStation"></see></summary>
    let CheckParentStation =
        Namespaced_IRI.parse _namespace_name "CheckParentStation" |> NamespacedName

    /// <summary>
    /// A class whom's instances indicate how accessible a gtfs:Trip, gtfs:Stop or gtfs:Station is.
    /// <see href="http://vocab.gtfs.org/terms#WheelchairBoardingStatus"></see></summary>
    let WheelchairBoardingStatus =
        Namespaced_IRI.parse _namespace_name "WheelchairBoardingStatus" |> NamespacedName

    /// <summary>
    /// Instances of this class can be used by gtfs:dropOffType
    /// <see href="http://vocab.gtfs.org/terms#DropOffType"></see></summary>
    let DropOffType =
        Namespaced_IRI.parse _namespace_name "DropOffType" |> NamespacedName

    /// <summary>
    /// This is a timed transfer point between two routes. The departing vehicle is expected to wait for the arriving one, with sufficient time for a passenger to transfer between routes.
    /// <see href="http://vocab.gtfs.org/terms#EnsuredTransfer"></see></summary>
    let EnsuredTransfer =
        Namespaced_IRI.parse _namespace_name "EnsuredTransfer" |> NamespacedName

    /// <summary>
    /// Instances of this class can be used to describe how to handle a transfer rule
    /// <see href="http://vocab.gtfs.org/terms#TransferType"></see></summary>
    let TransferType =
        Namespaced_IRI.parse _namespace_name "TransferType" |> NamespacedName

    /// <summary>
    /// A class describing how the fare is calculated.
    /// <see href="http://vocab.gtfs.org/terms#FareClass"></see></summary>
    let FareClass = Namespaced_IRI.parse _namespace_name "FareClass" |> NamespacedName
    /// <summary>
    /// A rule which binds a gtfs:FareClass to a part of the network.
    /// <see href="http://vocab.gtfs.org/terms#FareRule"></see></summary>
    let FareRule = Namespaced_IRI.parse _namespace_name "FareRule" |> NamespacedName
    /// <summary>
    /// An instance of a gtfs:Feed is a linked GTFS feed that complies to this specification.
    /// <see href="http://vocab.gtfs.org/terms#Feed"></see></summary>
    let Feed = Namespaced_IRI.parse _namespace_name "Feed" |> NamespacedName
    /// <summary>
    /// Used for short- and long-distance boat service.
    /// <see href="http://vocab.gtfs.org/terms#Ferry"></see></summary>
    let Ferry = Namespaced_IRI.parse _namespace_name "Ferry" |> NamespacedName
    /// <summary>
    /// An alternative to defining departures and arrivals as StopTimes: define frequencies for transit vehicle
    /// <see href="http://vocab.gtfs.org/terms#Frequency"></see></summary>
    let Frequency = Namespaced_IRI.parse _namespace_name "Frequency" |> NamespacedName
    /// <summary>
    /// Any rail system designed for steep inclines.
    /// <see href="http://vocab.gtfs.org/terms#Funicular"></see></summary>
    let Funicular = Namespaced_IRI.parse _namespace_name "Funicular" |> NamespacedName
    /// <summary>
    /// Any light rail or street level system within a metropolitan area.
    /// <see href="http://vocab.gtfs.org/terms#LightRail"></see></summary>
    let LightRail = Namespaced_IRI.parse _namespace_name "LightRail" |> NamespacedName

    /// <summary>
    /// This transfer requires a minimum amount of time between arrival and departure to ensure a connection. The time required to transfer is specified by gtfs:minimumTransferTime
    /// <see href="http://vocab.gtfs.org/terms#MinimumTimeTransfer"></see></summary>
    let MinimumTimeTransfer =
        Namespaced_IRI.parse _namespace_name "MinimumTimeTransfer" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.gtfs.org/terms#MustCoordinateWithDriver"></see>
    /// </summary>
    let MustCoordinateWithDriver =
        Namespaced_IRI.parse _namespace_name "MustCoordinateWithDriver" |> NamespacedName

    /// <summary>
    /// Instances of this class can be used by gtfs:pickupType
    /// <see href="http://vocab.gtfs.org/terms#PickupType"></see></summary>
    let PickupType = Namespaced_IRI.parse _namespace_name "PickupType" |> NamespacedName
    /// <summary>
    ///   <see href="http://vocab.gtfs.org/terms#MustPhone"></see>
    /// </summary>
    let MustPhone = Namespaced_IRI.parse _namespace_name "MustPhone" |> NamespacedName
    /// <summary>
    /// Transfers are not possible between routes at this location.
    /// <see href="http://vocab.gtfs.org/terms#NoTransfer"></see></summary>
    let NoTransfer = Namespaced_IRI.parse _namespace_name "NoTransfer" |> NamespacedName

    /// <summary>
    /// Indicate that a passenger should buy a new ticket when transferring
    /// <see href="http://vocab.gtfs.org/terms#NoTransfersAllowed"></see></summary>
    let NoTransfersAllowed =
        Namespaced_IRI.parse _namespace_name "NoTransfersAllowed" |> NamespacedName

    /// <summary>
    /// Instances of this class describe whether tickets remain valid when transferring
    /// <see href="http://vocab.gtfs.org/terms#TransfersAllowedType"></see></summary>
    let TransfersAllowedType =
        Namespaced_IRI.parse _namespace_name "TransfersAllowedType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.gtfs.org/terms#NotAvailable"></see>
    /// </summary>
    let NotAvailable =
        Namespaced_IRI.parse _namespace_name "NotAvailable" |> NamespacedName

    /// <summary>
    /// No riders in wheelchairs can be accommodated on this trip or wheelchair boarding is not possible at this stop and/or there exists no accessible path from outside the station to the specific stop.
    /// <see href="http://vocab.gtfs.org/terms#NotWheelchairAccessible"></see></summary>
    let NotWheelchairAccessible =
        Namespaced_IRI.parse _namespace_name "NotWheelchairAccessible" |> NamespacedName

    /// <summary>
    /// Fare should be bought on board
    /// <see href="http://vocab.gtfs.org/terms#OnBoard"></see></summary>
    let OnBoard = Namespaced_IRI.parse _namespace_name "OnBoard" |> NamespacedName

    /// <summary>
    /// Indicate that a passenger should buy a new ticket when transferring a second time
    /// <see href="http://vocab.gtfs.org/terms#OneTransfersAllowed"></see></summary>
    let OneTransfersAllowed =
        Namespaced_IRI.parse _namespace_name "OneTransfersAllowed" |> NamespacedName

    /// <summary>
    /// Used for intercity or long-distance travel.
    /// <see href="http://vocab.gtfs.org/terms#Rail"></see></summary>
    let Rail = Namespaced_IRI.parse _namespace_name "Rail" |> NamespacedName

    /// <summary>
    /// This is a recommended transfer point between two routes
    /// <see href="http://vocab.gtfs.org/terms#RecommendedTransfer"></see></summary>
    let RecommendedTransfer =
        Namespaced_IRI.parse _namespace_name "RecommendedTransfer" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.gtfs.org/terms#Regular"></see>
    /// </summary>
    let Regular = Namespaced_IRI.parse _namespace_name "Regular" |> NamespacedName
    /// <summary>
    /// A gtfs:Route is a commercial route followed entirely or partly by gtfs:Trips
    /// <see href="http://vocab.gtfs.org/terms#Route"></see></summary>
    let Route = Namespaced_IRI.parse _namespace_name "Route" |> NamespacedName
    /// <summary>
    /// A gtfs:Service identifies a set of dates when a service is available for one or more routes
    /// <see href="http://vocab.gtfs.org/terms#Service"></see></summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName
    /// <summary>
    /// A polygon formed by gtfs:ShapePoints
    /// <see href="http://vocab.gtfs.org/terms#Shape"></see></summary>
    let Shape = Namespaced_IRI.parse _namespace_name "Shape" |> NamespacedName
    /// <summary>
    /// A geographic point within a gtfs:Shape
    /// <see href="http://vocab.gtfs.org/terms#ShapePoint"></see></summary>
    let ShapePoint = Namespaced_IRI.parse _namespace_name "ShapePoint" |> NamespacedName
    /// <summary>
    /// A physical structure or area that contains one or more stop.
    /// <see href="http://vocab.gtfs.org/terms#Station"></see></summary>
    let Station = Namespaced_IRI.parse _namespace_name "Station" |> NamespacedName
    /// <summary>
    /// A location where passengers board or disembark from a transit vehicle.
    /// <see href="http://vocab.gtfs.org/terms#Stop"></see></summary>
    let Stop = Namespaced_IRI.parse _namespace_name "Stop" |> NamespacedName
    /// <summary>
    /// Describes a stop time as part of a trip
    /// <see href="http://vocab.gtfs.org/terms#StopTime"></see></summary>
    let StopTime = Namespaced_IRI.parse _namespace_name "StopTime" |> NamespacedName
    /// <summary>
    /// Any underground rail system within a metropolitan area.
    /// <see href="http://vocab.gtfs.org/terms#Subway"></see></summary>
    let Subway = Namespaced_IRI.parse _namespace_name "Subway" |> NamespacedName

    /// <summary>
    /// Define additional rules for making connections between routes.
    /// <see href="http://vocab.gtfs.org/terms#TransferRule"></see></summary>
    let TransferRule =
        Namespaced_IRI.parse _namespace_name "TransferRule" |> NamespacedName

    /// <summary>
    /// A collection of gtfs:StopTimes followed by a transit vehicle
    /// <see href="http://vocab.gtfs.org/terms#Trip"></see></summary>
    let Trip = Namespaced_IRI.parse _namespace_name "Trip" |> NamespacedName

    /// <summary>
    /// Indicate that a passenger should buy a new ticket when transferring for the third time
    /// <see href="http://vocab.gtfs.org/terms#TwoTransfersAllowed"></see></summary>
    let TwoTransfersAllowed =
        Namespaced_IRI.parse _namespace_name "TwoTransfersAllowed" |> NamespacedName

    /// <summary>
    /// Indicate that a passenger should buy a new ticket when transferring for the third time
    /// <see href="http://vocab.gtfs.org/terms#UnlimitedTransfersAllowed"></see></summary>
    let UnlimitedTransfersAllowed =
        Namespaced_IRI.parse _namespace_name "UnlimitedTransfersAllowed" |> NamespacedName

    /// <summary>
    /// Indicates that the vehicle being used on this particular trip can accommodate at least one rider in a wheelchair, or identifies that wheelchair boardings are possible from the specified stop, some trips at this stop are accessible by wheelchair and if this stop has a parentStation, there exists some accessible path from outside the station to the specific stop.
    /// <see href="http://vocab.gtfs.org/terms#WheelchairAccessible"></see></summary>
    let WheelchairAccessible =
        Namespaced_IRI.parse _namespace_name "WheelchairAccessible" |> NamespacedName

    /// <summary>
    /// Zones are required if you want to provide fare information using gtfs:FareClass
    /// <see href="http://vocab.gtfs.org/terms#Zone"></see></summary>
    let Zone = Namespaced_IRI.parse _namespace_name "Zone" |> NamespacedName
    /// <summary>
    /// links to an agency that this is part of.
    /// <see href="http://vocab.gtfs.org/terms#agency"></see></summary>
    let agency = Namespaced_IRI.parse _namespace_name "agency" |> NamespacedName

    /// <summary>
    /// Check the original specification for special cases
    /// <see href="http://vocab.gtfs.org/terms#arrivalTime"></see></summary>
    let arrivalTime =
        Namespaced_IRI.parse _namespace_name "arrivalTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.gtfs.org/terms#bikesAllowed"></see>
    /// </summary>
    let bikesAllowed =
        Namespaced_IRI.parse _namespace_name "bikesAllowed" |> NamespacedName

    /// <summary>
    /// Identifies the block to which the trip within this feed belongs. A block consists of two or more sequential trips made using the same vehicle, where a passenger can transfer from one trip to the next just by staying in the vehicle.
    /// <see href="http://vocab.gtfs.org/terms#block"></see></summary>
    let block = Namespaced_IRI.parse _namespace_name "block" |> NamespacedName
    /// <summary>
    /// A 6 character hexidecimal color (without #)
    /// <see href="http://vocab.gtfs.org/terms#color"></see></summary>
    let color = Namespaced_IRI.parse _namespace_name "color" |> NamespacedName

    /// <summary>
    /// A boolean whether to add (true) or remove (false) a date
    /// <see href="http://vocab.gtfs.org/terms#dateAddition"></see></summary>
    let dateAddition =
        Namespaced_IRI.parse _namespace_name "dateAddition" |> NamespacedName

    /// <summary>
    /// Check the original specification for special cases
    /// <see href="http://vocab.gtfs.org/terms#departureTime"></see></summary>
    let departureTime =
        Namespaced_IRI.parse _namespace_name "departureTime" |> NamespacedName

    /// <summary>
    /// Link to gtfs:Stop to go to
    /// <see href="http://vocab.gtfs.org/terms#destinationStop"></see></summary>
    let destinationStop =
        Namespaced_IRI.parse _namespace_name "destinationStop" |> NamespacedName

    /// <summary>
    /// The destination zone where this applies
    /// <see href="http://vocab.gtfs.org/terms#destinationZone"></see></summary>
    let destinationZone =
        Namespaced_IRI.parse _namespace_name "destinationZone" |> NamespacedName

    /// <summary>
    /// A binary property to indicate the direction the trip is going (e.g., outbound/inbound, center/airport)
    /// <see href="http://vocab.gtfs.org/terms#direction"></see></summary>
    let direction = Namespaced_IRI.parse _namespace_name "direction" |> NamespacedName

    /// <summary>
    /// Positions a stop as a distance from the first shape point. It represents a real distance traveled along the route in units such as feet or kilometers. This information allows the trip planner to determine how much of the shape to draw when showing part of a trip on the map. The values used for gtfs:distanceTraveled must increase along with gtfs:stopSequence: they cannot be used to show reverse travel along a route.
    /// <see href="http://vocab.gtfs.org/terms#distanceTraveled"></see></summary>
    let distanceTraveled =
        Namespaced_IRI.parse _namespace_name "distanceTraveled" |> NamespacedName

    /// <summary>
    /// Which type of drop off
    /// <see href="http://vocab.gtfs.org/terms#dropOffType"></see></summary>
    let dropOffType =
        Namespaced_IRI.parse _namespace_name "dropOffType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.gtfs.org/terms#endTime"></see>
    /// </summary>
    let endTime = Namespaced_IRI.parse _namespace_name "endTime" |> NamespacedName
    /// <summary>
    /// The URL of a web page that allows a rider to purchase tickets or other fare instruments for that agency online
    /// <see href="http://vocab.gtfs.org/terms#fareUrl"></see></summary>
    let fareUrl = Namespaced_IRI.parse _namespace_name "fareUrl" |> NamespacedName
    /// <summary>
    /// Service is available on Friday
    /// <see href="http://vocab.gtfs.org/terms#friday"></see></summary>
    let friday = Namespaced_IRI.parse _namespace_name "friday" |> NamespacedName
    /// <summary>
    /// The gtfs:headsign property contains the text that appears on a sign that identifies the trip's destination to passengers.
    /// <see href="http://vocab.gtfs.org/terms#headsign"></see></summary>
    let headsign = Namespaced_IRI.parse _namespace_name "headsign" |> NamespacedName

    /// <summary>
    /// Indicates the time between departures from the same stop (headway) for this trip type, during the time interval specified by gtfs:startTime and gtfs:endTime.
    /// <see href="http://vocab.gtfs.org/terms#headwaySeconds"></see></summary>
    let headwaySeconds =
        Namespaced_IRI.parse _namespace_name "headwaySeconds" |> NamespacedName

    /// <summary>
    /// Long name given to a route
    /// <see href="http://vocab.gtfs.org/terms#longName"></see></summary>
    let longName = Namespaced_IRI.parse _namespace_name "longName" |> NamespacedName

    /// <summary>
    /// The minimum transfer time when the gtfs:transferType is gtfs:MinimumTimeTransfer.
    /// <see href="http://vocab.gtfs.org/terms#minimumTransferTime"></see></summary>
    let minimumTransferTime =
        Namespaced_IRI.parse _namespace_name "minimumTransferTime" |> NamespacedName

    /// <summary>
    /// Service is available on Monday
    /// <see href="http://vocab.gtfs.org/terms#monday"></see></summary>
    let monday = Namespaced_IRI.parse _namespace_name "monday" |> NamespacedName
    /// <summary>
    /// Link to gtfs:Stop to start from
    /// <see href="http://vocab.gtfs.org/terms#originStop"></see></summary>
    let originStop = Namespaced_IRI.parse _namespace_name "originStop" |> NamespacedName
    /// <summary>
    /// The origin zone where this applies
    /// <see href="http://vocab.gtfs.org/terms#originZone"></see></summary>
    let originZone = Namespaced_IRI.parse _namespace_name "originZone" |> NamespacedName

    /// <summary>
    /// gtfs:parentStation identifies the station associated with the stop
    /// <see href="http://vocab.gtfs.org/terms#parentStation"></see></summary>
    let parentStation =
        Namespaced_IRI.parse _namespace_name "parentStation" |> NamespacedName

    /// <summary>
    /// The payment method
    /// <see href="http://vocab.gtfs.org/terms#paymentMethod"></see></summary>
    let paymentMethod =
        Namespaced_IRI.parse _namespace_name "paymentMethod" |> NamespacedName

    /// <summary>
    /// Which type of pickup
    /// <see href="http://vocab.gtfs.org/terms#pickupType"></see></summary>
    let pickupType = Namespaced_IRI.parse _namespace_name "pickupType" |> NamespacedName

    /// <summary>
    /// The shape_pt_sequence field associates the latitude and longitude of a shape point with its sequence order along the shape. The values for shape_pt_sequence must be non-negative integers, and they must increase along the trip.
    /// <see href="http://vocab.gtfs.org/terms#pointSequence"></see></summary>
    let pointSequence =
        Namespaced_IRI.parse _namespace_name "pointSequence" |> NamespacedName

    /// <summary>
    /// This thing is applicable to this gtfs:Route
    /// <see href="http://vocab.gtfs.org/terms#route"></see></summary>
    let route = Namespaced_IRI.parse _namespace_name "route" |> NamespacedName
    /// <summary>
    /// Links to the type of vehicle operating this on route
    /// <see href="http://vocab.gtfs.org/terms#routeType"></see></summary>
    let routeType = Namespaced_IRI.parse _namespace_name "routeType" |> NamespacedName
    /// <summary>
    /// Service is available on Saturday
    /// <see href="http://vocab.gtfs.org/terms#saturday"></see></summary>
    let saturday = Namespaced_IRI.parse _namespace_name "saturday" |> NamespacedName
    /// <summary>
    /// Follows this gtfs:Service.
    /// <see href="http://vocab.gtfs.org/terms#service"></see></summary>
    let service = Namespaced_IRI.parse _namespace_name "service" |> NamespacedName

    /// <summary>
    /// Service rules which define together a set of dates
    /// <see href="http://vocab.gtfs.org/terms#serviceRule"></see></summary>
    let serviceRule =
        Namespaced_IRI.parse _namespace_name "serviceRule" |> NamespacedName

    /// <summary>
    /// a link to a shape the trip follows.
    /// <see href="http://vocab.gtfs.org/terms#shape"></see></summary>
    let shape = Namespaced_IRI.parse _namespace_name "shape" |> NamespacedName
    /// <summary>
    /// Links to a gtfs:ShapePoint
    /// <see href="http://vocab.gtfs.org/terms#shapePoint"></see></summary>
    let shapePoint = Namespaced_IRI.parse _namespace_name "shapePoint" |> NamespacedName
    /// <summary>
    /// Short name given to a route or a trip
    /// <see href="http://vocab.gtfs.org/terms#shortName"></see></summary>
    let shortName = Namespaced_IRI.parse _namespace_name "shortName" |> NamespacedName
    /// <summary>
    /// Specifies the time at which service begins with the specified frequency
    /// <see href="http://vocab.gtfs.org/terms#startTime"></see></summary>
    let startTime = Namespaced_IRI.parse _namespace_name "startTime" |> NamespacedName
    /// <summary>
    /// Indicates that this has a certain stop.
    /// <see href="http://vocab.gtfs.org/terms#stop"></see></summary>
    let stop = Namespaced_IRI.parse _namespace_name "stop" |> NamespacedName

    /// <summary>
    /// The stopSequence property identifies the order of the stops for a particular trip. The values must increase along the gtfs:Trip referenced in the gtfs:trip property.
    /// <see href="http://vocab.gtfs.org/terms#stopSequence"></see></summary>
    let stopSequence =
        Namespaced_IRI.parse _namespace_name "stopSequence" |> NamespacedName

    /// <summary>
    /// Service is available on Sunday
    /// <see href="http://vocab.gtfs.org/terms#sunday"></see></summary>
    let sunday = Namespaced_IRI.parse _namespace_name "sunday" |> NamespacedName
    /// <summary>
    /// A 6 character hexidecimal color (without #) asigned to a text label.
    /// <see href="http://vocab.gtfs.org/terms#textColor"></see></summary>
    let textColor = Namespaced_IRI.parse _namespace_name "textColor" |> NamespacedName
    /// <summary>
    /// Service is available on Thursday
    /// <see href="http://vocab.gtfs.org/terms#thursday"></see></summary>
    let thursday = Namespaced_IRI.parse _namespace_name "thursday" |> NamespacedName
    /// <summary>
    /// The timezone where a person or organisation is located.
    /// <see href="http://vocab.gtfs.org/terms#timeZone"></see></summary>
    let timeZone = Namespaced_IRI.parse _namespace_name "timeZone" |> NamespacedName

    /// <summary>
    /// The time a ticket remains valid when having left the previous vehicle
    /// <see href="http://vocab.gtfs.org/terms#transferExpiryTime"></see></summary>
    let transferExpiryTime =
        Namespaced_IRI.parse _namespace_name "transferExpiryTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.gtfs.org/terms#transferType"></see>
    /// </summary>
    let transferType =
        Namespaced_IRI.parse _namespace_name "transferType" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.gtfs.org/terms#Transfer"></see>
    /// </summary>
    let Transfer = Namespaced_IRI.parse _namespace_name "Transfer" |> NamespacedName
    /// <summary>
    /// The validity of the ticket when transferring
    /// <see href="http://vocab.gtfs.org/terms#transfers"></see></summary>
    let transfers = Namespaced_IRI.parse _namespace_name "transfers" |> NamespacedName
    /// <summary>
    /// Indictates that this is part of a certain gtfs:Trip
    /// <see href="http://vocab.gtfs.org/terms#trip"></see></summary>
    let trip = Namespaced_IRI.parse _namespace_name "trip" |> NamespacedName
    /// <summary>
    /// Service is available on Tuesday
    /// <see href="http://vocab.gtfs.org/terms#tuesday"></see></summary>
    let tuesday = Namespaced_IRI.parse _namespace_name "tuesday" |> NamespacedName

    /// <summary>
    ///   <see href="http://vocab.gtfs.org/terms#usesExactTimes"></see>
    /// </summary>
    let usesExactTimes =
        Namespaced_IRI.parse _namespace_name "usesExactTimes" |> NamespacedName

    /// <summary>
    /// Service is available on Wednesday
    /// <see href="http://vocab.gtfs.org/terms#wednesday"></see></summary>
    let wednesday = Namespaced_IRI.parse _namespace_name "wednesday" |> NamespacedName

    /// <summary>
    /// Wheelchair boardings are possible from the specified stop or station. If this stop is part of a station, there is also a wheelchair accessible path from outside the station towards the stop.
    /// <see href="http://vocab.gtfs.org/terms#wheelchairAccessible"></see></summary>
    let wheelchairAccessible =
        Namespaced_IRI.parse _namespace_name "wheelchairAccessible" |> NamespacedName

    /// <summary>
    /// A gtfs:Stop defines the fare zone. Zones are required if you want to provide fare information using gtfs:FareClass.
    /// <see href="http://vocab.gtfs.org/terms#zone"></see></summary>
    let zone = Namespaced_IRI.parse _namespace_name "zone" |> NamespacedName
