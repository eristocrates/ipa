namespace http.vocab.gtfs.org.terms.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module gtfs =
    let _namespace_iri = Namespace_Iri gtfs |> NamespaceIRI
    /// <summary>
    ///   <para>gtfs:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"General Transit Feed Specification"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#">http://vocab.gtfs.org/terms#</seealso>
    let _prefix_iri = Prefixed_Name(gtfs, "") |> PrefixedName
    /// <summary>
    ///   <para>gtfs::Gondola</para>
    /// </summary>
    /// <remarks>
    ///   <para>gtfs:RouteType</para>
    ///   <para>"Gondola, Suspended cable car. Typically used for aerial cable cars where the car is suspended from the cable."</para>
    /// labels<para>"Gondola, Suspended cable car"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#:Gondola">http://vocab.gtfs.org/terms#:Gondola</seealso>
    let ``_:Gondola`` = Prefixed_Name(gtfs, ":Gondola") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:Agency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Una empresa opera un cierto modo de transporte de manera programada"</para>
    ///   <para>"An agency operates a certain schedule based transport mode"</para>
    /// labels<para>"Agency"</para><para>"Empresa"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#Agency">http://vocab.gtfs.org/terms#Agency</seealso>
    let Agency = Prefixed_Name(gtfs, "Agency") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:BeforeBoarding</para>
    /// </summary>
    /// <remarks>
    ///   <para>gtfs:PaymentMethod</para>
    ///   <para>"Ticket should be bought before boarding"</para>
    /// labels<para>"Before Boarding"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#BeforeBoarding">http://vocab.gtfs.org/terms#BeforeBoarding</seealso>
    let BeforeBoarding = Prefixed_Name(gtfs, "BeforeBoarding") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:Bus</para>
    /// </summary>
    /// <remarks>
    ///   <para>gtfs:RouteType</para>
    ///   <para>"Used for short- and long-distance bus routes."</para>
    /// labels<para>"Bus"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#Bus">http://vocab.gtfs.org/terms#Bus</seealso>
    let Bus = Prefixed_Name(gtfs, "Bus") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:CableCar</para>
    /// </summary>
    /// <remarks>
    ///   <para>gtfs:RouteType</para>
    ///   <para>"Used for street-level cable cars where the cable runs beneath the car."</para>
    /// labels<para>"Cable car"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#CableCar">http://vocab.gtfs.org/terms#CableCar</seealso>
    let CableCar = Prefixed_Name(gtfs, "CableCar") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:CalendarDateRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Defines service availability for a specific date"</para>
    /// labels<para>"Calendar date rule"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#CalendarDateRule">http://vocab.gtfs.org/terms#CalendarDateRule</seealso>
    let CalendarDateRule = Prefixed_Name(gtfs, "CalendarDateRule") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:CalendarRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Defines on which days of the week for a certain period the service is available."</para>
    /// labels<para>"Calendar rule"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#CalendarRule">http://vocab.gtfs.org/terms#CalendarRule</seealso>
    let CalendarRule = Prefixed_Name(gtfs, "CalendarRule") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:CheckParentStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>gtfs:WheelchairBoardingStatus</para>
    ///   <para>"Check the (parent) station for accessibility infomration."</para>
    /// labels<para>"Check the parent station"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#CheckParentStation">http://vocab.gtfs.org/terms#CheckParentStation</seealso>
    let CheckParentStation = Prefixed_Name(gtfs, "CheckParentStation") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:DropOffType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Instances of this class can be used by gtfs:dropOffType"</para>
    /// labels<para>"Drop Off Type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#DropOffType">http://vocab.gtfs.org/terms#DropOffType</seealso>
    let DropOffType = Prefixed_Name(gtfs, "DropOffType") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:EnsuredTransfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>gtfs:TransferType</para>
    ///   <para>"This is a timed transfer point between two routes. The departing vehicle is expected to wait for the arriving one, with sufficient time for a passenger to transfer between routes."</para>
    /// labels<para>"Ensured Transfer"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#EnsuredTransfer">http://vocab.gtfs.org/terms#EnsuredTransfer</seealso>
    let EnsuredTransfer = Prefixed_Name(gtfs, "EnsuredTransfer") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:FareClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A class describing how the fare is calculated."</para>
    /// labels<para>"Fare Class"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#FareClass">http://vocab.gtfs.org/terms#FareClass</seealso>
    let FareClass = Prefixed_Name(gtfs, "FareClass") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:FareRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A rule which binds a gtfs:FareClass to a part of the network."</para>
    /// labels<para>"Fare Rule"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#FareRule">http://vocab.gtfs.org/terms#FareRule</seealso>
    let FareRule = Prefixed_Name(gtfs, "FareRule") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:Feed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An instance of a gtfs:Feed is a linked GTFS feed that complies to this specification."</para>
    /// labels<para>"GTFS Feed"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#Feed">http://vocab.gtfs.org/terms#Feed</seealso>
    let Feed = Prefixed_Name(gtfs, "Feed") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:Ferry</para>
    /// </summary>
    /// <remarks>
    ///   <para>gtfs:RouteType</para>
    ///   <para>"Used for short- and long-distance boat service."</para>
    /// labels<para>"Ferry"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#Ferry">http://vocab.gtfs.org/terms#Ferry</seealso>
    let Ferry = Prefixed_Name(gtfs, "Ferry") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:Frequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An alternative to defining departures and arrivals as StopTimes: define frequencies for transit vehicle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Frequency"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#Frequency">http://vocab.gtfs.org/terms#Frequency</seealso>
    let Frequency = Prefixed_Name(gtfs, "Frequency") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:Funicular</para>
    /// </summary>
    /// <remarks>
    ///   <para>gtfs:RouteType</para>
    ///   <para>"Any rail system designed for steep inclines."</para>
    /// labels<para>"Funicular"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#Funicular">http://vocab.gtfs.org/terms#Funicular</seealso>
    let Funicular = Prefixed_Name(gtfs, "Funicular") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:LightRail</para>
    /// </summary>
    /// <remarks>
    ///   <para>gtfs:RouteType</para>
    ///   <para>"Any light rail or street level system within a metropolitan area."</para>
    /// labels<para>"Tram, Streetcar, Light rail"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#LightRail">http://vocab.gtfs.org/terms#LightRail</seealso>
    let LightRail = Prefixed_Name(gtfs, "LightRail") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:MinimumTimeTransfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>gtfs:TransferType</para>
    ///   <para>"This transfer requires a minimum amount of time between arrival and departure to ensure a connection. The time required to transfer is specified by gtfs:minimumTransferTime"</para>
    /// labels<para>"Mimimum Time Transfer"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#MinimumTimeTransfer">http://vocab.gtfs.org/terms#MinimumTimeTransfer</seealso>
    let MinimumTimeTransfer = Prefixed_Name(gtfs, "MinimumTimeTransfer") |> PrefixedName

    /// <summary>
    ///   <para>gtfs:MustCoordinateWithDriver</para>
    /// </summary>
    /// <remarks>
    ///   <para>gtfs:PickupType</para>
    ///   <para>gtfs:DropOffType</para>
    ///
    /// labels<para>"Must coordinate with driver to arrange pickup or drop off"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#MustCoordinateWithDriver">http://vocab.gtfs.org/terms#MustCoordinateWithDriver</seealso>
    let MustCoordinateWithDriver =
        Prefixed_Name(gtfs, "MustCoordinateWithDriver") |> PrefixedName

    /// <summary>
    ///   <para>gtfs:MustPhone</para>
    /// </summary>
    /// <remarks>
    ///   <para>gtfs:DropOffType</para>
    ///   <para>gtfs:PickupType</para>
    ///
    /// labels<para>"Must phone agency to arrange pickup or drop off"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#MustPhone">http://vocab.gtfs.org/terms#MustPhone</seealso>
    let MustPhone = Prefixed_Name(gtfs, "MustPhone") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:NoTransfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>gtfs:TransferType</para>
    ///   <para>"Transfers are not possible between routes at this location."</para>
    /// labels<para>"No Transfer"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#NoTransfer">http://vocab.gtfs.org/terms#NoTransfer</seealso>
    let NoTransfer = Prefixed_Name(gtfs, "NoTransfer") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:NoTransfersAllowed</para>
    /// </summary>
    /// <remarks>
    ///   <para>gtfs:TransfersAllowedType</para>
    ///   <para>"Indicate that a passenger should buy a new ticket when transferring"</para>
    /// labels<para>"No transfers allowed"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#NoTransfersAllowed">http://vocab.gtfs.org/terms#NoTransfersAllowed</seealso>
    let NoTransfersAllowed = Prefixed_Name(gtfs, "NoTransfersAllowed") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:NotAvailable</para>
    /// </summary>
    /// <remarks>
    ///   <para>gtfs:PickupType</para>
    ///   <para>gtfs:DropOffType</para>
    ///
    /// labels<para>"Pickup or drop off not available"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#NotAvailable">http://vocab.gtfs.org/terms#NotAvailable</seealso>
    let NotAvailable = Prefixed_Name(gtfs, "NotAvailable") |> PrefixedName

    /// <summary>
    ///   <para>gtfs:NotWheelchairAccessible</para>
    /// </summary>
    /// <remarks>
    ///   <para>gtfs:WheelchairBoardingStatus</para>
    ///   <para>"No riders in wheelchairs can be accommodated on this trip or wheelchair boarding is not possible at this stop and/or there exists no accessible path from outside the station to the specific stop."</para>
    /// labels<para>"Not wheelchair accessible"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#NotWheelchairAccessible">http://vocab.gtfs.org/terms#NotWheelchairAccessible</seealso>
    let NotWheelchairAccessible =
        Prefixed_Name(gtfs, "NotWheelchairAccessible") |> PrefixedName

    /// <summary>
    ///   <para>gtfs:OnBoard</para>
    /// </summary>
    /// <remarks>
    ///   <para>gtfs:PaymentMethod</para>
    ///   <para>"Fare should be bought on board"</para>
    /// labels<para>"On Board"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#OnBoard">http://vocab.gtfs.org/terms#OnBoard</seealso>
    let OnBoard = Prefixed_Name(gtfs, "OnBoard") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:OneTransfersAllowed</para>
    /// </summary>
    /// <remarks>
    ///   <para>gtfs:TransfersAllowedType</para>
    ///   <para>"Indicate that a passenger should buy a new ticket when transferring a second time"</para>
    /// labels<para>"No transfers allowed"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#OneTransfersAllowed">http://vocab.gtfs.org/terms#OneTransfersAllowed</seealso>
    let OneTransfersAllowed = Prefixed_Name(gtfs, "OneTransfersAllowed") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:PaymentMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Method to pay for the public transit service"</para>
    /// labels<para>"Payment Method"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#PaymentMethod">http://vocab.gtfs.org/terms#PaymentMethod</seealso>
    let PaymentMethod = Prefixed_Name(gtfs, "PaymentMethod") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:PickupType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Instances of this class can be used by gtfs:pickupType"</para>
    /// labels<para>"Pickup Type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#PickupType">http://vocab.gtfs.org/terms#PickupType</seealso>
    let PickupType = Prefixed_Name(gtfs, "PickupType") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:Rail</para>
    /// </summary>
    /// <remarks>
    ///   <para>gtfs:RouteType</para>
    ///   <para>"Used for intercity or long-distance travel."</para>
    /// labels<para>"Rail"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#Rail">http://vocab.gtfs.org/terms#Rail</seealso>
    let Rail = Prefixed_Name(gtfs, "Rail") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:RecommendedTransfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>gtfs:TransferType</para>
    ///   <para>"This is a recommended transfer point between two routes"</para>
    /// labels<para>"Recommended Transfer"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#RecommendedTransfer">http://vocab.gtfs.org/terms#RecommendedTransfer</seealso>
    let RecommendedTransfer = Prefixed_Name(gtfs, "RecommendedTransfer") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:Regular</para>
    /// </summary>
    /// <remarks>
    ///   <para>gtfs:DropOffType</para>
    ///   <para>gtfs:PickupType</para>
    ///
    /// labels<para>"Regularly scheduled pickup or drop off"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#Regular">http://vocab.gtfs.org/terms#Regular</seealso>
    let Regular = Prefixed_Name(gtfs, "Regular") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:Route</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Es un grupo de viajes (gtfs:Trips) que se muestran a los usuarios como servicio independiente"</para>
    ///   <para>"It is a commercial route followed entirely or partly by gtfs:Trips"</para>
    ///   <para>"A gtfs:Route is a commercial route followed entirely or partly by gtfs:Trips"</para>
    /// labels<para>"Route"</para><para>"Ruta"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#Route">http://vocab.gtfs.org/terms#Route</seealso>
    let Route = Prefixed_Name(gtfs, "Route") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:RouteType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Describes the type of transportation used on a route"</para>
    /// labels<para>"Route type"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#RouteType">http://vocab.gtfs.org/terms#RouteType</seealso>
    let RouteType = Prefixed_Name(gtfs, "RouteType") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A gtfs:Service identifies a set of dates when a service is available for one or more routes"</para>
    /// labels<para>"Service"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#Service">http://vocab.gtfs.org/terms#Service</seealso>
    let Service = Prefixed_Name(gtfs, "Service") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:ServiceRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"One or more service rules define a set of dates"</para>
    /// labels<para>"Service rule"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#ServiceRule">http://vocab.gtfs.org/terms#ServiceRule</seealso>
    let ServiceRule = Prefixed_Name(gtfs, "ServiceRule") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:Shape</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A polygon formed by gtfs:ShapePoints"</para>
    /// labels<para>"Shape"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#Shape">http://vocab.gtfs.org/terms#Shape</seealso>
    let Shape = Prefixed_Name(gtfs, "Shape") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:ShapePoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A geographic point within a gtfs:Shape"</para>
    /// labels<para>"Shape Point"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#ShapePoint">http://vocab.gtfs.org/terms#ShapePoint</seealso>
    let ShapePoint = Prefixed_Name(gtfs, "ShapePoint") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:Station</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A physical structure or area that contains one or more stop."</para>
    /// labels<para>"Station"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#Station">http://vocab.gtfs.org/terms#Station</seealso>
    let Station = Prefixed_Name(gtfs, "Station") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:Stop</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Un lugar donde los pasajeros suben o bajan de un vehículo de transporte público"</para>
    ///   <para>"A location where passengers board or disembark from a transit vehicle."</para>
    ///   <para>"A location where passengers board or disembark from a transit vehicle"</para>
    /// labels<para>"Parada"</para><para>"Stop"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#Stop">http://vocab.gtfs.org/terms#Stop</seealso>
    let Stop = Prefixed_Name(gtfs, "Stop") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:StopTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Describes a stop time as part of a trip"</para>
    ///   <para>"Describe una hora de parada como parte de un viaje"</para>
    /// labels<para>"Stop time"</para><para>"Hora de parada"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#StopTime">http://vocab.gtfs.org/terms#StopTime</seealso>
    let StopTime = Prefixed_Name(gtfs, "StopTime") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:Subway</para>
    /// </summary>
    /// <remarks>
    ///   <para>gtfs:RouteType</para>
    ///   <para>"Any underground rail system within a metropolitan area."</para>
    /// labels<para>"Subway, Metro"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#Subway">http://vocab.gtfs.org/terms#Subway</seealso>
    let Subway = Prefixed_Name(gtfs, "Subway") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:Transfer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#Transfer">http://vocab.gtfs.org/terms#Transfer</seealso>
    let Transfer = Prefixed_Name(gtfs, "Transfer") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:TransferRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Define additional rules for making connections between routes."</para>
    /// labels<para>"Transfer Rule"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#TransferRule">http://vocab.gtfs.org/terms#TransferRule</seealso>
    let TransferRule = Prefixed_Name(gtfs, "TransferRule") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:TransferType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Instances of this class can be used to describe how to handle a transfer rule"</para>
    /// labels<para>"Transfer Type"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#TransferType">http://vocab.gtfs.org/terms#TransferType</seealso>
    let TransferType = Prefixed_Name(gtfs, "TransferType") |> PrefixedName

    /// <summary>
    ///   <para>gtfs:TransfersAllowedType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Instances of this class describe whether tickets remain valid when transferring"</para>
    /// labels<para>"Transfers Allowed Type"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#TransfersAllowedType">http://vocab.gtfs.org/terms#TransfersAllowedType</seealso>
    let TransfersAllowedType =
        Prefixed_Name(gtfs, "TransfersAllowedType") |> PrefixedName

    /// <summary>
    ///   <para>gtfs:Trip</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Trayecto de dos o más paradas realizadas por un vehículo que se produce a una gtfs:StopTime"</para>
    ///   <para>"A collection of gtfs:StopTimes followed by a transit vehicle"</para>
    /// labels<para>"Viaje"</para><para>"Trip"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#Trip">http://vocab.gtfs.org/terms#Trip</seealso>
    let Trip = Prefixed_Name(gtfs, "Trip") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:TwoTransfersAllowed</para>
    /// </summary>
    /// <remarks>
    ///   <para>gtfs:TransfersAllowedType</para>
    ///   <para>"Indicate that a passenger should buy a new ticket when transferring for the third time"</para>
    /// labels<para>"Two transfers allowed"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#TwoTransfersAllowed">http://vocab.gtfs.org/terms#TwoTransfersAllowed</seealso>
    let TwoTransfersAllowed = Prefixed_Name(gtfs, "TwoTransfersAllowed") |> PrefixedName

    /// <summary>
    ///   <para>gtfs:UnlimitedTransfersAllowed</para>
    /// </summary>
    /// <remarks>
    ///   <para>gtfs:TransfersAllowedType</para>
    ///   <para>"Indicate that a passenger should buy a new ticket when transferring for the third time"</para>
    /// labels<para>"Unlimited transfers allowed"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#UnlimitedTransfersAllowed">http://vocab.gtfs.org/terms#UnlimitedTransfersAllowed</seealso>
    let UnlimitedTransfersAllowed =
        Prefixed_Name(gtfs, "UnlimitedTransfersAllowed") |> PrefixedName

    /// <summary>
    ///   <para>gtfs:WheelchairAccessible</para>
    /// </summary>
    /// <remarks>
    ///   <para>gtfs:WheelchairBoardingStatus</para>
    ///   <para>"Indicates that the vehicle being used on this particular trip can accommodate at least one rider in a wheelchair, or identifies that wheelchair boardings are possible from the specified stop, some trips at this stop are accessible by wheelchair and if this stop has a parentStation, there exists some accessible path from outside the station to the specific stop."</para>
    /// labels<para>"Wheelchair accessible"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#WheelchairAccessible">http://vocab.gtfs.org/terms#WheelchairAccessible</seealso>
    let WheelchairAccessible =
        Prefixed_Name(gtfs, "WheelchairAccessible") |> PrefixedName

    /// <summary>
    ///   <para>gtfs:WheelchairBoardingStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A class whom's instances indicate how accessible a gtfs:Trip, gtfs:Stop or gtfs:Station is."</para>
    /// labels<para>"Wheelchair Boarding Information"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#WheelchairBoardingStatus">http://vocab.gtfs.org/terms#WheelchairBoardingStatus</seealso>
    let WheelchairBoardingStatus =
        Prefixed_Name(gtfs, "WheelchairBoardingStatus") |> PrefixedName

    /// <summary>
    ///   <para>gtfs:Zone</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Zones are required if you want to provide fare information using gtfs:FareClass"</para>
    /// labels<para>"Zone"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#Zone">http://vocab.gtfs.org/terms#Zone</seealso>
    let Zone = Prefixed_Name(gtfs, "Zone") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:agency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Agencia"</para>
    ///   <para>"links to an agency that this is part of."</para>
    /// labels<para>"Agencia"</para><para>"agency"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#agency">http://vocab.gtfs.org/terms#agency</seealso>
    let agency = Prefixed_Name(gtfs, "agency") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:arrivalTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Llegada"</para>
    ///   <para>"Check the original specification for special cases"</para>
    /// labels<para>"Llegada"</para><para>"Arrival time"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#arrivalTime">http://vocab.gtfs.org/terms#arrivalTime</seealso>
    let arrivalTime = Prefixed_Name(gtfs, "arrivalTime") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:bikesAllowed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Bikes allowed"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#bikesAllowed">http://vocab.gtfs.org/terms#bikesAllowed</seealso>
    let bikesAllowed = Prefixed_Name(gtfs, "bikesAllowed") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:block</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Identifies the block to which the trip within this feed belongs. A block consists of two or more sequential trips made using the same vehicle, where a passenger can transfer from one trip to the next just by staying in the vehicle."</para>
    /// labels<para>"Block"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#block">http://vocab.gtfs.org/terms#block</seealso>
    let block = Prefixed_Name(gtfs, "block") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:color</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A 6 character hexidecimal color (without #)"</para>
    /// labels<para>"Color"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#color">http://vocab.gtfs.org/terms#color</seealso>
    let color = Prefixed_Name(gtfs, "color") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:comment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A comment on the relation between the RDFS ontology and the CSV specification."</para>
    /// labels<para>"Mapping comment"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#comment">http://vocab.gtfs.org/terms#comment</seealso>
    let comment = Prefixed_Name(gtfs, "comment") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:dateAddition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A boolean whether to add (true) or remove (false) a date"</para>
    /// labels<para>"Date Addition"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#dateAddition">http://vocab.gtfs.org/terms#dateAddition</seealso>
    let dateAddition = Prefixed_Name(gtfs, "dateAddition") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:departureTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Check the original specification for special cases"</para>
    /// labels<para>"Departure time"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#departureTime">http://vocab.gtfs.org/terms#departureTime</seealso>
    let departureTime = Prefixed_Name(gtfs, "departureTime") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:destinationStop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Destino"</para>
    ///   <para>"Link to gtfs:Stop to go to"</para>
    /// labels<para>"Destino"</para><para>"Destination Stop"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#destinationStop">http://vocab.gtfs.org/terms#destinationStop</seealso>
    let destinationStop = Prefixed_Name(gtfs, "destinationStop") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:destinationZone</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The destination zone where this applies"</para>
    /// labels<para>"Destination Zone"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#destinationZone">http://vocab.gtfs.org/terms#destinationZone</seealso>
    let destinationZone = Prefixed_Name(gtfs, "destinationZone") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:direction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A binary property to indicate the direction the trip is going (e.g., outbound/inbound, center/airport)"</para>
    /// labels<para>"Direction"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#direction">http://vocab.gtfs.org/terms#direction</seealso>
    let direction = Prefixed_Name(gtfs, "direction") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:distanceTraveled</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Positions a stop as a distance from the first shape point. It represents a real distance traveled along the route in units such as feet or kilometers. This information allows the trip planner to determine how much of the shape to draw when showing part of a trip on the map. The values used for gtfs:distanceTraveled must increase along with gtfs:stopSequence: they cannot be used to show reverse travel along a route."</para>
    /// labels<para>"Distance Traveled"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#distanceTraveled">http://vocab.gtfs.org/terms#distanceTraveled</seealso>
    let distanceTraveled = Prefixed_Name(gtfs, "distanceTraveled") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:dropOffType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Which type of drop off"</para>
    /// labels<para>"Drop off type"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#dropOffType">http://vocab.gtfs.org/terms#dropOffType</seealso>
    let dropOffType = Prefixed_Name(gtfs, "dropOffType") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:endTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>""</para>
    /// labels<para>"End Time"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#endTime">http://vocab.gtfs.org/terms#endTime</seealso>
    let endTime = Prefixed_Name(gtfs, "endTime") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:fareUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The URL of a web page that allows a rider to purchase tickets or other fare instruments for that agency online"</para>
    /// labels<para>"fare URL"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#fareUrl">http://vocab.gtfs.org/terms#fareUrl</seealso>
    let fareUrl = Prefixed_Name(gtfs, "fareUrl") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:friday</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Service is available on Friday"</para>
    /// labels<para>"Friday"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#friday">http://vocab.gtfs.org/terms#friday</seealso>
    let friday = Prefixed_Name(gtfs, "friday") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:headsign</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The gtfs:headsign property contains the text that appears on a sign that identifies the trip's destination to passengers."</para>
    /// labels<para>"Headsign"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#headsign">http://vocab.gtfs.org/terms#headsign</seealso>
    let headsign = Prefixed_Name(gtfs, "headsign") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:headwaySeconds</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates the time between departures from the same stop (headway) for this trip type, during the time interval specified by gtfs:startTime and gtfs:endTime."</para>
    /// labels<para>"Headway Seconds"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#headwaySeconds">http://vocab.gtfs.org/terms#headwaySeconds</seealso>
    let headwaySeconds = Prefixed_Name(gtfs, "headwaySeconds") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:longName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Long name given to a route"</para>
    /// labels<para>"Long name"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#longName">http://vocab.gtfs.org/terms#longName</seealso>
    let longName = Prefixed_Name(gtfs, "longName") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:minimumTransferTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The minimum transfer time when the gtfs:transferType is gtfs:MinimumTimeTransfer."</para>
    /// labels<para>"Minimum Transfer Time"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#minimumTransferTime">http://vocab.gtfs.org/terms#minimumTransferTime</seealso>
    let minimumTransferTime = Prefixed_Name(gtfs, "minimumTransferTime") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:monday</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Service is available on Monday"</para>
    /// labels<para>"Monday"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#monday">http://vocab.gtfs.org/terms#monday</seealso>
    let monday = Prefixed_Name(gtfs, "monday") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:originStop</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Link to gtfs:Stop to start from"</para>
    ///   <para>"Inicio"</para>
    /// labels<para>"Inicio"</para><para>"Origin Stop"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#originStop">http://vocab.gtfs.org/terms#originStop</seealso>
    let originStop = Prefixed_Name(gtfs, "originStop") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:originZone</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The origin zone where this applies"</para>
    /// labels<para>"Origin Zone"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#originZone">http://vocab.gtfs.org/terms#originZone</seealso>
    let originZone = Prefixed_Name(gtfs, "originZone") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:parentStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"gtfs:parentStation identifies the station associated with the stop"</para>
    /// labels<para>"Parent Station"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#parentStation">http://vocab.gtfs.org/terms#parentStation</seealso>
    let parentStation = Prefixed_Name(gtfs, "parentStation") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:paymentMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The payment method"</para>
    /// labels<para>"Payment method"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#paymentMethod">http://vocab.gtfs.org/terms#paymentMethod</seealso>
    let paymentMethod = Prefixed_Name(gtfs, "paymentMethod") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:pickupType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Which type of pickup"</para>
    /// labels<para>"Pickup type"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#pickupType">http://vocab.gtfs.org/terms#pickupType</seealso>
    let pickupType = Prefixed_Name(gtfs, "pickupType") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:pointSequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The shape_pt_sequence field associates the latitude and longitude of a shape point with its sequence order along the shape. The values for shape_pt_sequence must be non-negative integers, and they must increase along the trip."</para>
    /// labels<para>"Point Sequence"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#pointSequence">http://vocab.gtfs.org/terms#pointSequence</seealso>
    let pointSequence = Prefixed_Name(gtfs, "pointSequence") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:route</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"This thing is applicable to this gtfs:Route"</para>
    ///   <para>"Enlace con ruta"</para>
    /// labels<para>"Ruta"</para><para>"Route"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#route">http://vocab.gtfs.org/terms#route</seealso>
    let route = Prefixed_Name(gtfs, "route") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:routeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Links to the type of vehicle operating this on route"</para>
    ///   <para>"Tipo de ruta"</para>
    /// </remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#routeType">http://vocab.gtfs.org/terms#routeType</seealso>
    let routeType = Prefixed_Name(gtfs, "routeType") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:saturday</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Service is available on Saturday"</para>
    /// labels<para>"Saturday"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#saturday">http://vocab.gtfs.org/terms#saturday</seealso>
    let saturday = Prefixed_Name(gtfs, "saturday") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:service</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Follows this gtfs:Service."</para>
    /// labels<para>"Service"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#service">http://vocab.gtfs.org/terms#service</seealso>
    let service = Prefixed_Name(gtfs, "service") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:serviceRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Service rules which define together a set of dates"</para>
    /// labels<para>"Service rule"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#serviceRule">http://vocab.gtfs.org/terms#serviceRule</seealso>
    let serviceRule = Prefixed_Name(gtfs, "serviceRule") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:shape</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"a link to a shape the trip follows."</para>
    /// labels<para>"Shape"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#shape">http://vocab.gtfs.org/terms#shape</seealso>
    let shape = Prefixed_Name(gtfs, "shape") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:shapePoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Links to a gtfs:ShapePoint"</para>
    /// labels<para>"Shape Point"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#shapePoint">http://vocab.gtfs.org/terms#shapePoint</seealso>
    let shapePoint = Prefixed_Name(gtfs, "shapePoint") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:shortName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Short name given to a route or a trip"</para>
    /// labels<para>"Short name"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#shortName">http://vocab.gtfs.org/terms#shortName</seealso>
    let shortName = Prefixed_Name(gtfs, "shortName") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:startTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Specifies the time at which service begins with the specified frequency"</para>
    /// labels<para>"Start Time"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#startTime">http://vocab.gtfs.org/terms#startTime</seealso>
    let startTime = Prefixed_Name(gtfs, "startTime") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:stop</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Parada"</para>
    ///   <para>"Indicates that this has a certain stop."</para>
    /// labels<para>"Stop"</para><para>"Parada"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#stop">http://vocab.gtfs.org/terms#stop</seealso>
    let stop = Prefixed_Name(gtfs, "stop") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:stopSequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The stopSequence property identifies the order of the stops for a particular trip. The values must increase along the gtfs:Trip referenced in the gtfs:trip property."</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Stop sequence"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#stopSequence">http://vocab.gtfs.org/terms#stopSequence</seealso>
    let stopSequence = Prefixed_Name(gtfs, "stopSequence") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:sunday</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Service is available on Sunday"</para>
    /// labels<para>"Sunday"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#sunday">http://vocab.gtfs.org/terms#sunday</seealso>
    let sunday = Prefixed_Name(gtfs, "sunday") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:textColor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A 6 character hexidecimal color (without #) asigned to a text label."</para>
    /// labels<para>"Text color"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#textColor">http://vocab.gtfs.org/terms#textColor</seealso>
    let textColor = Prefixed_Name(gtfs, "textColor") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:thursday</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Service is available on Thursday"</para>
    /// labels<para>"Thursday"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#thursday">http://vocab.gtfs.org/terms#thursday</seealso>
    let thursday = Prefixed_Name(gtfs, "thursday") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:timeZone</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The timezone where a person or organisation is located."</para>
    /// labels<para>"Time zone"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#timeZone">http://vocab.gtfs.org/terms#timeZone</seealso>
    let timeZone = Prefixed_Name(gtfs, "timeZone") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:transferExpiryTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The time a ticket remains valid when having left the previous vehicle"</para>
    /// labels<para>"Transfer Expiry Time"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#transferExpiryTime">http://vocab.gtfs.org/terms#transferExpiryTime</seealso>
    let transferExpiryTime = Prefixed_Name(gtfs, "transferExpiryTime") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:transferType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Transfer Type"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#transferType">http://vocab.gtfs.org/terms#transferType</seealso>
    let transferType = Prefixed_Name(gtfs, "transferType") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:transfers</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The validity of the ticket when transferring"</para>
    /// labels<para>"Transfers"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#transfers">http://vocab.gtfs.org/terms#transfers</seealso>
    let transfers = Prefixed_Name(gtfs, "transfers") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:trip</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indictates that this is part of a certain gtfs:Trip"</para>
    ///   <para>"Enlace con viaje"</para>
    /// labels<para>"Trip"</para><para>"viaje"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#trip">http://vocab.gtfs.org/terms#trip</seealso>
    let trip = Prefixed_Name(gtfs, "trip") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:tuesday</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Service is available on Tuesday"</para>
    /// labels<para>"Tuesday"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#tuesday">http://vocab.gtfs.org/terms#tuesday</seealso>
    let tuesday = Prefixed_Name(gtfs, "tuesday") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:usesExactTimes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Frequency uses exact times"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#usesExactTimes">http://vocab.gtfs.org/terms#usesExactTimes</seealso>
    let usesExactTimes = Prefixed_Name(gtfs, "usesExactTimes") |> PrefixedName
    /// <summary>
    ///   <para>gtfs:wednesday</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Service is available on Wednesday"</para>
    /// labels<para>"Wednesday"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#wednesday">http://vocab.gtfs.org/terms#wednesday</seealso>
    let wednesday = Prefixed_Name(gtfs, "wednesday") |> PrefixedName

    /// <summary>
    ///   <para>gtfs:wheelchairAccessible</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Wheelchair boardings are possible from the specified stop or station. If this stop is part of a station, there is also a wheelchair accessible path from outside the station towards the stop."</para>
    /// labels<para>"wheelchair boarding"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#wheelchairAccessible">http://vocab.gtfs.org/terms#wheelchairAccessible</seealso>
    let wheelchairAccessible =
        Prefixed_Name(gtfs, "wheelchairAccessible") |> PrefixedName

    /// <summary>
    ///   <para>gtfs:zone</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A gtfs:Stop defines the fare zone. Zones are required if you want to provide fare information using gtfs:FareClass."</para>
    /// labels<para>"Zone"</para></remarks>
    /// <seealso href="http://vocab.gtfs.org/terms#zone">http://vocab.gtfs.org/terms#zone</seealso>
    let zone = Prefixed_Name(gtfs, "zone") |> PrefixedName
