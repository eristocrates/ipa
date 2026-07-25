namespace https.data.nasa.gov.ontologies.atmonto.NAS.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module nas =
    let _namespace_iri = Namespace_Iri nas |> NamespaceIRI
    /// <summary>
    ///   <para>nas:ARTCCtier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A donut-shaped geographical area surrounding a designated central ARTCC. The first tier includes all the ARTCCs that share a boundary with the designated  ARTCC. The tier two ARTCCs includes the first tier ARTCCs plus those adjacent to the first tier ARCCCs. And so on.</para>
    /// labels<para>ARTCCtier</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#ARTCCtier">https://data.nasa.gov/ontologies/atmonto/NAS#ARTCCtier</seealso>
    let ARTCCtier = Prefixed_Name(nas, "ARTCCtier") |> PrefixedName
    /// <summary>
    ///   <para>nas:DeicingPad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A physical location in the airport where deicing is performed.</para>
    /// labels<para>Deicing pad</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#DeicingPad">https://data.nasa.gov/ontologies/atmonto/NAS#DeicingPad</seealso>
    let DeicingPad = Prefixed_Name(nas, "DeicingPad") |> PrefixedName
    /// <summary>
    ///   <para>nas:DeicingTruck</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A vehicle that holds deicing fluid and pumping equipment to support deicing.</para>
    /// labels<para>Deicing truck</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#DeicingTruck">https://data.nasa.gov/ontologies/atmonto/NAS#DeicingTruck</seealso>
    let DeicingTruck = Prefixed_Name(nas, "DeicingTruck") |> PrefixedName
    /// <summary>
    ///   <para>nas:terminalID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The alphanumeric identifier of the airport terminal.</para>
    /// labels<para>terminal ID</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#terminalID">https://data.nasa.gov/ontologies/atmonto/NAS#terminalID</seealso>
    let terminalID = Prefixed_Name(nas, "terminalID") |> PrefixedName
    /// <summary>
    ///   <para>nas:hasTRACONtype</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The type of TRACON: Tower-colocated TRACON or standalone TRACON.</para>
    /// labels<para>has TRACONtype</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTRACONtype">https://data.nasa.gov/ontologies/atmonto/NAS#hasTRACONtype</seealso>
    let hasTRACONtype = Prefixed_Name(nas, "hasTRACONtype") |> PrefixedName
    /// <summary>
    ///   <para>nas:TRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A low altitude RNAV airway route. (RNAV routes allow an aircraft to choose any course within a network of navigation beacons, rather than navigate directly to and from the beacons.)</para>
    /// labels<para>T-Route</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#TRoute">https://data.nasa.gov/ontologies/atmonto/NAS#TRoute</seealso>
    let TRoute = Prefixed_Name(nas, "TRoute") |> PrefixedName
    /// <summary>
    ///   <para>nas:Taxiway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An airport surface leading that connects the ramp area (i.e., the area in the vicinity of the gates) with the runways.</para>
    /// labels<para>Taxiway</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#Taxiway">https://data.nasa.gov/ontologies/atmonto/NAS#Taxiway</seealso>
    let Taxiway = Prefixed_Name(nas, "Taxiway") |> PrefixedName
    /// <summary>
    ///   <para>nas:Terminal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A structure on the airport surface that serves as an interface between people, baggage, and aircraft.</para>
    /// labels<para>Terminal</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#Terminal">https://data.nasa.gov/ontologies/atmonto/NAS#Terminal</seealso>
    let Terminal = Prefixed_Name(nas, "Terminal") |> PrefixedName
    /// <summary>
    ///   <para>nas:VictorRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A low altitude airway based on ground-based VOR sensor locations.</para>
    /// labels<para>Victor route</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#VictorRoute">https://data.nasa.gov/ontologies/atmonto/NAS#VictorRoute</seealso>
    let VictorRoute = Prefixed_Name(nas, "VictorRoute") |> PrefixedName
    /// <summary>
    ///   <para>nas:adjacentSector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a sector to an immediately adjacent sector that shares a boundary.</para>
    /// labels<para>adjacent sector</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#adjacentSector">https://data.nasa.gov/ontologies/atmonto/NAS#adjacentSector</seealso>
    let adjacentSector = Prefixed_Name(nas, "adjacentSector") |> PrefixedName
    /// <summary>
    ///   <para>nas:airCarrierAlias</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>An alternative name for an air carrier.</para>
    /// labels<para>air carrier alias</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#airCarrierAlias">https://data.nasa.gov/ontologies/atmonto/NAS#airCarrierAlias</seealso>
    let airCarrierAlias = Prefixed_Name(nas, "airCarrierAlias") |> PrefixedName
    /// <summary>
    ///   <para>nas:airlineCallsign</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The radio call sign associated with an the air carrier. Used by pilots and controllers to identify aircraft over radio frequencies.</para>
    /// labels<para>airline callsign</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#airlineCallsign">https://data.nasa.gov/ontologies/atmonto/NAS#airlineCallsign</seealso>
    let airlineCallsign = Prefixed_Name(nas, "airlineCallsign") |> PrefixedName
    /// <summary>
    ///   <para>nas:airportLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links to a geographic point designated as the airport location.</para>
    /// labels<para>airport location</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#airportLocation">https://data.nasa.gov/ontologies/atmonto/NAS#airportLocation</seealso>
    let airportLocation = Prefixed_Name(nas, "airportLocation") |> PrefixedName

    /// <summary>
    ///   <para>nas:airspaceLayerLowAltitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The lower altitude bound of an airspace layer.</para>
    /// labels<para>airspace layer low altitude</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#airspaceLayerLowAltitude">https://data.nasa.gov/ontologies/atmonto/NAS#airspaceLayerLowAltitude</seealso>
    let airspaceLayerLowAltitude =
        Prefixed_Name(nas, "airspaceLayerLowAltitude") |> PrefixedName

    /// <summary>
    ///   <para>nas:artccID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The 3-letter ARTCC (Air Route Traffic Control Center) code.</para>
    /// labels<para>artcc ID</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#artccID">https://data.nasa.gov/ontologies/atmonto/NAS#artccID</seealso>
    let artccID = Prefixed_Name(nas, "artccID") |> PrefixedName
    /// <summary>
    ///   <para>nas:associatedOpRunway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a physical runway with its two operational runways (180 degrees apart, representing approaches from either end of the physical runway).</para>
    /// labels<para>associated operational runway</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#associatedOpRunway">https://data.nasa.gov/ontologies/atmonto/NAS#associatedOpRunway</seealso>
    let associatedOpRunway = Prefixed_Name(nas, "associatedOpRunway") |> PrefixedName
    /// <summary>
    ///   <para>nas:calendarYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The calendar year associated with a day class.</para>
    /// </remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#calendarYear">https://data.nasa.gov/ontologies/atmonto/NAS#calendarYear</seealso>
    let calendarYear = Prefixed_Name(nas, "calendarYear") |> PrefixedName
    /// <summary>
    ///   <para>nas:countryOfRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The country name of the airline registration.</para>
    /// labels<para>country of registry</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#countryOfRegistry">https://data.nasa.gov/ontologies/atmonto/NAS#countryOfRegistry</seealso>
    let countryOfRegistry = Prefixed_Name(nas, "countryOfRegistry") |> PrefixedName
    /// <summary>
    ///   <para>nas:dayOfMonth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The day number associated with a day class.</para>
    /// </remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#dayOfMonth">https://data.nasa.gov/ontologies/atmonto/NAS#dayOfMonth</seealso>
    let dayOfMonth = Prefixed_Name(nas, "dayOfMonth") |> PrefixedName
    /// <summary>
    ///   <para>nas:deicingPadLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Links a deicing pad with its location as a two-dimensional bounding polygon.</para>
    /// labels<para>deicing pad location</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#deicingPadLocation">https://data.nasa.gov/ontologies/atmonto/NAS#deicingPadLocation</seealso>
    let deicingPadLocation = Prefixed_Name(nas, "deicingPadLocation") |> PrefixedName

    /// <summary>
    ///   <para>nas:departureRouteAirport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links to the airport from which this route is destined.</para>
    /// labels<para>departure route airport</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#departureRouteAirport">https://data.nasa.gov/ontologies/atmonto/NAS#departureRouteAirport</seealso>
    let departureRouteAirport =
        Prefixed_Name(nas, "departureRouteAirport") |> PrefixedName

    /// <summary>
    ///   <para>nas:gateID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The gate identifier assigned by the airport authority.</para>
    /// labels<para>gate ID</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#gateID">https://data.nasa.gov/ontologies/atmonto/NAS#gateID</seealso>
    let gateID = Prefixed_Name(nas, "gateID") |> PrefixedName
    /// <summary>
    ///   <para>nas:hasAirportRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates an airport route with a SID or STAR. A SID or STAR has a single common route, but can have multiple airport or transition routes.</para>
    /// labels<para>has airport route</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#hasAirportRoute">https://data.nasa.gov/ontologies/atmonto/NAS#hasAirportRoute</seealso>
    let hasAirportRoute = Prefixed_Name(nas, "hasAirportRoute") |> PrefixedName
    /// <summary>
    ///   <para>nas:hasCenterGeometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an ARTCC to a 2-dimensional bounding polygon.</para>
    /// labels<para>has center geometry</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#hasCenterGeometry">https://data.nasa.gov/ontologies/atmonto/NAS#hasCenterGeometry</seealso>
    let hasCenterGeometry = Prefixed_Name(nas, "hasCenterGeometry") |> PrefixedName
    /// <summary>
    ///   <para>nas:hasCommonRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a common route with a SID or STAR. A SID or STAR has a single common route, but can have multiple airport or transition routes.</para>
    /// labels<para>has common route</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#hasCommonRoute">https://data.nasa.gov/ontologies/atmonto/NAS#hasCommonRoute</seealso>
    let hasCommonRoute = Prefixed_Name(nas, "hasCommonRoute") |> PrefixedName
    /// <summary>
    ///   <para>nas:hasGate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates an airport terminal with a aircraft gate located at that terminal.</para>
    /// labels<para>has gate</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#hasGate">https://data.nasa.gov/ontologies/atmonto/NAS#hasGate</seealso>
    let hasGate = Prefixed_Name(nas, "hasGate") |> PrefixedName
    /// <summary>
    ///   <para>nas:hasLOAwith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>This property links a NAS facility to another NAS facility when there is a letter of agreement (LOA) in place between them.</para>
    /// labels<para>has LOA with</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#hasLOAwith">https://data.nasa.gov/ontologies/atmonto/NAS#hasLOAwith</seealso>
    let hasLOAwith = Prefixed_Name(nas, "hasLOAwith") |> PrefixedName
    /// <summary>
    ///   <para>nas:hasQueue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a deicing pad to its queue of aircraft waiting to be deiced.</para>
    /// labels<para>has queue</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#hasQueue">https://data.nasa.gov/ontologies/atmonto/NAS#hasQueue</seealso>
    let hasQueue = Prefixed_Name(nas, "hasQueue") |> PrefixedName
    /// <summary>
    ///   <para>nas:hasRunway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an airport to a physical runway for that airport.</para>
    /// labels<para>has runway</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#hasRunway">https://data.nasa.gov/ontologies/atmonto/NAS#hasRunway</seealso>
    let hasRunway = Prefixed_Name(nas, "hasRunway") |> PrefixedName
    /// <summary>
    ///   <para>nas:hasSID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates an airport with the the SIDs designated to route aircraft from that airport.</para>
    /// labels<para>has SID</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#hasSID">https://data.nasa.gov/ontologies/atmonto/NAS#hasSID</seealso>
    let hasSID = Prefixed_Name(nas, "hasSID") |> PrefixedName
    /// <summary>
    ///   <para>nas:hasSTAR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates an airport with the the STARs designated to route aircraft to that airport.</para>
    /// labels<para>has STAR</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#hasSTAR">https://data.nasa.gov/ontologies/atmonto/NAS#hasSTAR</seealso>
    let hasSTAR = Prefixed_Name(nas, "hasSTAR") |> PrefixedName
    /// <summary>
    ///   <para>nas:hasSectorLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a sector to its vertically-stacked set of layers.</para>
    /// labels<para>has sector layer</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#hasSectorLayer">https://data.nasa.gov/ontologies/atmonto/NAS#hasSectorLayer</seealso>
    let hasSectorLayer = Prefixed_Name(nas, "hasSectorLayer") |> PrefixedName
    /// <summary>
    ///   <para>nas:hasSectorName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>An alphanumeric sector name that is in general different than the sector ID.</para>
    /// labels<para>has sector name</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#hasSectorName">https://data.nasa.gov/ontologies/atmonto/NAS#hasSectorName</seealso>
    let hasSectorName = Prefixed_Name(nas, "hasSectorName") |> PrefixedName
    /// <summary>
    ///   <para>nas:hasTRACONid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The FAA alphanumeric code for the TRACON.</para>
    /// labels<para>has TRACON ID</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTRACONid">https://data.nasa.gov/ontologies/atmonto/NAS#hasTRACONid</seealso>
    let hasTRACONid = Prefixed_Name(nas, "hasTRACONid") |> PrefixedName
    /// <summary>
    ///   <para>nas:hasTRACONlayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A link between the TRACON and its geographic extent, represented as a single shear-sided polygonal volume.</para>
    /// labels<para>has TRACON layer</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTRACONlayer">https://data.nasa.gov/ontologies/atmonto/NAS#hasTRACONlayer</seealso>
    let hasTRACONlayer = Prefixed_Name(nas, "hasTRACONlayer") |> PrefixedName
    /// <summary>
    ///   <para>nas:hasTRACONstate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The name of the US state in which the TRACON command center is located.</para>
    /// labels<para>has TRACONstate</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTRACONstate">https://data.nasa.gov/ontologies/atmonto/NAS#hasTRACONstate</seealso>
    let hasTRACONstate = Prefixed_Name(nas, "hasTRACONstate") |> PrefixedName
    /// <summary>
    ///   <para>nas:hasTaxiway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an airport to a taxiway for that airport.</para>
    /// labels<para>has taxiway</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTaxiway">https://data.nasa.gov/ontologies/atmonto/NAS#hasTaxiway</seealso>
    let hasTaxiway = Prefixed_Name(nas, "hasTaxiway") |> PrefixedName
    /// <summary>
    ///   <para>nas:hasTier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Asociates an ARTCC with the set of ARTCCs in its nth level tier.  Tier 1 includes the central ARTCC plus all ARTCCs immediately adjoining the central ARTCC; tier 2 includes tier 1 plus all adjacent ARTCCs two steps away from the central ARTCC. And so on.</para>
    /// labels<para>has tier</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTier">https://data.nasa.gov/ontologies/atmonto/NAS#hasTier</seealso>
    let hasTier = Prefixed_Name(nas, "hasTier") |> PrefixedName
    /// <summary>
    ///   <para>nas:hasTower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an airport to an air traffic control tower for that airport.</para>
    /// labels<para>has tower</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTower">https://data.nasa.gov/ontologies/atmonto/NAS#hasTower</seealso>
    let hasTower = Prefixed_Name(nas, "hasTower") |> PrefixedName
    /// <summary>
    ///   <para>nas:hasTransitionRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a transition route with a SID or STAR. A SID or STAR has a single common route, but can have multiple airport or transition routes.</para>
    /// labels<para>has transition route</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTransitionRoute">https://data.nasa.gov/ontologies/atmonto/NAS#hasTransitionRoute</seealso>
    let hasTransitionRoute = Prefixed_Name(nas, "hasTransitionRoute") |> PrefixedName
    /// <summary>
    ///   <para>nas:hoursOffsetFromUTC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The number of hours that the airport is offset from the UTC timezone.</para>
    /// labels<para>hours offset from UTC</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#hoursOffsetFromUTC">https://data.nasa.gov/ontologies/atmonto/NAS#hoursOffsetFromUTC</seealso>
    let hoursOffsetFromUTC = Prefixed_Name(nas, "hoursOffsetFromUTC") |> PrefixedName
    /// <summary>
    ///   <para>nas:iataAirportCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The thre-letter IATA code assigned to the airport. Contrast with the ICAO and FAA airport codes.</para>
    /// labels<para>IATA Airport Code</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#iataAirportCode">https://data.nasa.gov/ontologies/atmonto/NAS#iataAirportCode</seealso>
    let iataAirportCode = Prefixed_Name(nas, "iataAirportCode") |> PrefixedName
    /// <summary>
    ///   <para>nas:iataCarrierCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The two-letter IATA code assigned to the carrier.</para>
    /// labels<para>IATA Carrier Code</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#iataCarrierCode">https://data.nasa.gov/ontologies/atmonto/NAS#iataCarrierCode</seealso>
    let iataCarrierCode = Prefixed_Name(nas, "iataCarrierCode") |> PrefixedName
    /// <summary>
    ///   <para>nas:icaoAirportCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The four-letter ICAO code assignied to the airport. Contrast with the IATA and FAA airport codes.</para>
    /// labels<para>ICAO airport code</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#icaoAirportCode">https://data.nasa.gov/ontologies/atmonto/NAS#icaoAirportCode</seealso>
    let icaoAirportCode = Prefixed_Name(nas, "icaoAirportCode") |> PrefixedName
    /// <summary>
    ///   <para>nas:icaoCarrierCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The three-letter ICAO code assigned to the airline carrier.</para>
    /// labels<para>ICAO Air Carrier Code</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#icaoCarrierCode">https://data.nasa.gov/ontologies/atmonto/NAS#icaoCarrierCode</seealso>
    let icaoCarrierCode = Prefixed_Name(nas, "icaoCarrierCode") |> PrefixedName
    /// <summary>
    ///   <para>nas:includesARTCC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A link between an ARTCC tier and the ARTCCs included in the tier.</para>
    /// labels<para>includes ARTCC</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#includesARTCC">https://data.nasa.gov/ontologies/atmonto/NAS#includesARTCC</seealso>
    let includesARTCC = Prefixed_Name(nas, "includesARTCC") |> PrefixedName

    /// <summary>
    ///   <para>nas:isInstrumentControlEligible</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates whether this airport is capable of an instrument approach.</para>
    /// labels<para>is instrument control eligible</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#isInstrumentControlEligible">https://data.nasa.gov/ontologies/atmonto/NAS#isInstrumentControlEligible</seealso>
    let isInstrumentControlEligible =
        Prefixed_Name(nas, "isInstrumentControlEligible") |> PrefixedName

    /// <summary>
    ///   <para>nas:locatedInCenter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a sector to the ARTCC in which the sector is located.</para>
    /// labels<para>located in Center</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#locatedInCenter">https://data.nasa.gov/ontologies/atmonto/NAS#locatedInCenter</seealso>
    let locatedInCenter = Prefixed_Name(nas, "locatedInCenter") |> PrefixedName
    /// <summary>
    ///   <para>nas:locatedInState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The 2-letter US postal code for the state in which the airport is located.</para>
    /// labels<para>Located in State</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#locatedInState">https://data.nasa.gov/ontologies/atmonto/NAS#locatedInState</seealso>
    let locatedInState = Prefixed_Name(nas, "locatedInState") |> PrefixedName

    /// <summary>
    ///   <para>nas:manufacturerCountryName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The country name where the manufacturer is established.</para>
    /// labels<para>manufacturer country name</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#manufacturerCountryName">https://data.nasa.gov/ontologies/atmonto/NAS#manufacturerCountryName</seealso>
    let manufacturerCountryName =
        Prefixed_Name(nas, "manufacturerCountryName") |> PrefixedName

    /// <summary>
    ///   <para>nas:manufacturerFullName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The full name of the manufacturer.</para>
    /// labels<para>manufacturer full name</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#manufacturerFullName">https://data.nasa.gov/ontologies/atmonto/NAS#manufacturerFullName</seealso>
    let manufacturerFullName =
        Prefixed_Name(nas, "manufacturerFullName") |> PrefixedName

    /// <summary>
    ///   <para>nas:maxVisibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The upper bound of visibility in feet over the centerline of the runway.</para>
    /// labels<para>max visibility</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#maxVisibility">https://data.nasa.gov/ontologies/atmonto/NAS#maxVisibility</seealso>
    let maxVisibility = Prefixed_Name(nas, "maxVisibility") |> PrefixedName
    /// <summary>
    ///   <para>nas:routeID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>FAA alphanumeric identifier assigned to the route/airway.</para>
    /// labels<para>route ID</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#routeID">https://data.nasa.gov/ontologies/atmonto/NAS#routeID</seealso>
    let routeID = Prefixed_Name(nas, "routeID") |> PrefixedName
    /// <summary>
    ///   <para>nas:runwayFootprint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a physical runway with its bounding two-dimensional rectangle.</para>
    /// labels<para>runway footprint</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#runwayFootprint">https://data.nasa.gov/ontologies/atmonto/NAS#runwayFootprint</seealso>
    let runwayFootprint = Prefixed_Name(nas, "runwayFootprint") |> PrefixedName
    /// <summary>
    ///   <para>nas:runwayID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>An identifier for the runway. For physical runways, the convention is to label runways by their heading, dropping the last digit. E.g. for Liverpool, runway 9/27 is facing approximately magnetic heading 90 degrees in one direction, and 270 degrees in the opposite direction. If an airport has parallel runways, these would then be marked Left, Center and Right, e.g. 9L, 9C, 9R. For operational runways, the runway identifiers specifies one direction only: either 9 or 27 in the Liverpool example.</para>
    /// labels<para>runway ID</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#runwayID">https://data.nasa.gov/ontologies/atmonto/NAS#runwayID</seealso>
    let runwayID = Prefixed_Name(nas, "runwayID") |> PrefixedName
    /// <summary>
    ///   <para>nas:runwayLengthInFeet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The length in feet of the physical runway.</para>
    /// labels<para>runway length in feet</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#runwayLengthInFeet">https://data.nasa.gov/ontologies/atmonto/NAS#runwayLengthInFeet</seealso>
    let runwayLengthInFeet = Prefixed_Name(nas, "runwayLengthInFeet") |> PrefixedName
    /// <summary>
    ///   <para>nas:runwayWidthInFeet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The width in feet of the physical runway.</para>
    /// labels<para>runway width in feet</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#runwayWidthInFeet">https://data.nasa.gov/ontologies/atmonto/NAS#runwayWidthInFeet</seealso>
    let runwayWidthInFeet = Prefixed_Name(nas, "runwayWidthInFeet") |> PrefixedName
    /// <summary>
    ///   <para>nas:sidstarID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The FAA identifier for the SID or STAR. Typically, but not uniformly, 5 alpha characters plus a revision digit.</para>
    /// labels<para>sidstar ID</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#sidstarID">https://data.nasa.gov/ontologies/atmonto/NAS#sidstarID</seealso>
    let sidstarID = Prefixed_Name(nas, "sidstarID") |> PrefixedName
    /// <summary>
    ///   <para>nas:startingTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The beginning of the hour stored as a datetime value.</para>
    /// labels<para>starting time</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#startingTime">https://data.nasa.gov/ontologies/atmonto/NAS#startingTime</seealso>
    let startingTime = Prefixed_Name(nas, "startingTime") |> PrefixedName
    /// <summary>
    ///   <para>nas:taxiwayFootprint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a taxiway with its bounding two-dimensional rectangle.</para>
    /// labels<para>taxiway location</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#taxiwayFootprint">https://data.nasa.gov/ontologies/atmonto/NAS#taxiwayFootprint</seealso>
    let taxiwayFootprint = Prefixed_Name(nas, "taxiwayFootprint") |> PrefixedName
    /// <summary>
    ///   <para>nas:taxiwayID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>An identifier for the taxiway.</para>
    /// labels<para>taxiway ID</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#taxiwayID">https://data.nasa.gov/ontologies/atmonto/NAS#taxiwayID</seealso>
    let taxiwayID = Prefixed_Name(nas, "taxiwayID") |> PrefixedName
    /// <summary>
    ///   <para>nas:tierLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The degree number of the ARTCC tier. Tier 1 includes the central ARTCC plus all ARTCCs immediately adjoining the central ARTCC; tier 2 includes tier 1 plus all adjacent ARTCCs two steps away from the central ARTCC. And so on.</para>
    /// labels<para>tier level</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#tierLevel">https://data.nasa.gov/ontologies/atmonto/NAS#tierLevel</seealso>
    let tierLevel = Prefixed_Name(nas, "tierLevel") |> PrefixedName
    /// <summary>
    ///   <para>nas:touchdownPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Links to the geographical point location that is the touchdown spot on the operational runway.</para>
    /// labels<para>touchdown point</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#touchdownPoint">https://data.nasa.gov/ontologies/atmonto/NAS#touchdownPoint</seealso>
    let touchdownPoint = Prefixed_Name(nas, "touchdownPoint") |> PrefixedName
    /// <summary>
    ///   <para>nas:towerID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The FAA identifier for air traffic control tower.</para>
    /// labels<para>tower ID</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#towerID">https://data.nasa.gov/ontologies/atmonto/NAS#towerID</seealso>
    let towerID = Prefixed_Name(nas, "towerID") |> PrefixedName
    /// <summary>
    ///   <para>nas:withinARTCC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links the airport to the ARTCC within which it is located.</para>
    /// labels<para>within ARTCC</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#withinARTCC">https://data.nasa.gov/ontologies/atmonto/NAS#withinARTCC</seealso>
    let withinARTCC = Prefixed_Name(nas, "withinARTCC") |> PrefixedName
    /// <summary>
    ///   <para>nas:withinTimezone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The timezone identifier for the airport, where the timezone is specified as Area/Location, e.g. America/New_York.</para>
    /// labels<para>within timezone</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#withinTimezone">https://data.nasa.gov/ontologies/atmonto/NAS#withinTimezone</seealso>
    let withinTimezone = Prefixed_Name(nas, "withinTimezone") |> PrefixedName

    /// <summary>
    ///   <para>nas:AirspaceInfrastructureComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A defined substructure of the airspace used to manage air traffic, including sectors, SIDs, STARs, routes, etc.</para>
    /// labels<para>Airspace infrastructure component</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#AirspaceInfrastructureComponent">https://data.nasa.gov/ontologies/atmonto/NAS#AirspaceInfrastructureComponent</seealso>
    let AirspaceInfrastructureComponent =
        Prefixed_Name(nas, "AirspaceInfrastructureComponent") |> PrefixedName

    /// <summary>
    ///   <para>nas:FederalAirway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An airspace route that is defined by FAA and can be filed as part of a flight plan: a jet route, a Q-route,  a T-Route, a Victor route.</para>
    /// labels<para>Federal airway</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#FederalAirway">https://data.nasa.gov/ontologies/atmonto/NAS#FederalAirway</seealso>
    let FederalAirway = Prefixed_Name(nas, "FederalAirway") |> PrefixedName
    /// <summary>
    ///   <para>nas:Gate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A physical interface between the aircraft and the terminal, used to board passengers and crew.</para>
    /// labels<para>Gate</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#Gate">https://data.nasa.gov/ontologies/atmonto/NAS#Gate</seealso>
    let Gate = Prefixed_Name(nas, "Gate") |> PrefixedName

    /// <summary>
    ///   <para>nas:GovernmentAviationServiceProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The set of govenment agencies that perform aviation services.</para>
    /// labels<para>Government aviation service provider</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#GovernmentAviationServiceProvider">https://data.nasa.gov/ontologies/atmonto/NAS#GovernmentAviationServiceProvider</seealso>
    let GovernmentAviationServiceProvider =
        Prefixed_Name(nas, "GovernmentAviationServiceProvider") |> PrefixedName

    /// <summary>
    ///   <para>nas:JetRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A high altitude airway based on ground-based VOR sensor locations.</para>
    /// labels<para>Jet route</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#JetRoute">https://data.nasa.gov/ontologies/atmonto/NAS#JetRoute</seealso>
    let JetRoute = Prefixed_Name(nas, "JetRoute") |> PrefixedName
    /// <summary>
    ///   <para>nas:VORroute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A VOR route is defined relative to a network of existing ground-based VOR navigation beacons. VOR routes consist of point-to-point segments, where the points are defined by the beacons. More modern RNAV routes allow any path within the network, not limited to VOR-to-VOR segments.</para>
    /// labels<para>VOR route</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#VORroute">https://data.nasa.gov/ontologies/atmonto/NAS#VORroute</seealso>
    let VORroute = Prefixed_Name(nas, "VORroute") |> PrefixedName
    /// <summary>
    ///   <para>nas:NASday</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class that represents a day of the year. Events, such as flights, weather forecasts, and other events are linked to the instance of the day they occurred.</para>
    /// labels<para>NAS day</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#NASday">https://data.nasa.gov/ontologies/atmonto/NAS#NASday</seealso>
    let NASday = Prefixed_Name(nas, "NASday") |> PrefixedName
    /// <summary>
    ///   <para>nas:NAShour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class that represents an hour within a day. Events, such as flights, weather forecasts, and other events are linked to the instance of the day they occurred.</para>
    /// labels<para>NAShour</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#NAShour">https://data.nasa.gov/ontologies/atmonto/NAS#NAShour</seealso>
    let NAShour = Prefixed_Name(nas, "NAShour") |> PrefixedName
    /// <summary>
    ///   <para>nas:NonCONUSairport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The set of airports located in the United States, but outside the contiguous lower 48 states.</para>
    /// labels<para>Non CONUS airport</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#NonCONUSairport">https://data.nasa.gov/ontologies/atmonto/NAS#NonCONUSairport</seealso>
    let NonCONUSairport = Prefixed_Name(nas, "NonCONUSairport") |> PrefixedName
    /// <summary>
    ///   <para>nas:OperationalRunway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An operational runway is a named runway one used in airport operations. There are two operational runways corresponding to one physical runway; these operational runways are 180 degrees apart.</para>
    /// labels<para>Operational runway</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#OperationalRunway">https://data.nasa.gov/ontologies/atmonto/NAS#OperationalRunway</seealso>
    let OperationalRunway = Prefixed_Name(nas, "OperationalRunway") |> PrefixedName
    /// <summary>
    ///   <para>nas:QRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A high altitude RNAV airway route. (RNAV routes allow an aircraft to choose any course within a network of navigation beacons, rather than navigate directly to and from the beacons.)</para>
    /// labels<para>Q-Route</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#QRoute">https://data.nasa.gov/ontologies/atmonto/NAS#QRoute</seealso>
    let QRoute = Prefixed_Name(nas, "QRoute") |> PrefixedName

    /// <summary>
    ///   <para>nas:tfmsMonitorAlertParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The maximum number of aircraft permitted in a given sector at any time, per agreement between FAA and Air Traffic Controller union. MAP (Monitor Alert Parameter) is a TFMS input parameter.</para>
    /// labels<para>tfms monitor alert parameter</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#tfmsMonitorAlertParameter">https://data.nasa.gov/ontologies/atmonto/NAS#tfmsMonitorAlertParameter</seealso>
    let tfmsMonitorAlertParameter =
        Prefixed_Name(nas, "tfmsMonitorAlertParameter") |> PrefixedName

    /// <summary>
    ///   <para>nas:NASfacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The set of FAA and airport facilities involved in operational air traffic management.</para>
    /// labels<para>NAS facility</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#NASfacility">https://data.nasa.gov/ontologies/atmonto/NAS#NASfacility</seealso>
    let NASfacility = Prefixed_Name(nas, "NASfacility") |> PrefixedName
    /// <summary>
    ///   <para>nas:PhysicalRunway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A physical runway, defined as a delimited rectangular surface region of the airport. Each physical runway is associated with two operational runways, 180 degrees apart.</para>
    /// labels<para>Physical Runway</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#PhysicalRunway">https://data.nasa.gov/ontologies/atmonto/NAS#PhysicalRunway</seealso>
    let PhysicalRunway = Prefixed_Name(nas, "PhysicalRunway") |> PrefixedName
    /// <summary>
    ///   <para>nas:RNAVroute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An RNAV (Random Navigation) route is defined relative to a network of existing ground-based navigation beacons.  RNAV allows an aircraft to choose any course within the network, rather than navigate using only point-to-point routes defined by the beacons.</para>
    /// labels<para>RNAV route</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#RNAVroute">https://data.nasa.gov/ontologies/atmonto/NAS#RNAVroute</seealso>
    let RNAVroute = Prefixed_Name(nas, "RNAVroute") |> PrefixedName
    /// <summary>
    ///   <para>nas:RadialRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A route that follows a specified radial path emanating from a given fix.</para>
    /// labels<para>Radial Route</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#RadialRoute">https://data.nasa.gov/ontologies/atmonto/NAS#RadialRoute</seealso>
    let RadialRoute = Prefixed_Name(nas, "RadialRoute") |> PrefixedName

    /// <summary>
    ///   <para>nas:AirportInfrastructureComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Part of an airport's physical infrastructure, including gates, terminals, runways, taxiways, etc.</para>
    /// labels<para>Airport infrastructure component</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#AirportInfrastructureComponent">https://data.nasa.gov/ontologies/atmonto/NAS#AirportInfrastructureComponent</seealso>
    let AirportInfrastructureComponent =
        Prefixed_Name(nas, "AirportInfrastructureComponent") |> PrefixedName

    /// <summary>
    ///   <para>nas:AircraftEngineManufacturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A manufacturer of aircraft engines.</para>
    /// labels<para>Aircraft engine manufacturer</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#AircraftEngineManufacturer">https://data.nasa.gov/ontologies/atmonto/NAS#AircraftEngineManufacturer</seealso>
    let AircraftEngineManufacturer =
        Prefixed_Name(nas, "AircraftEngineManufacturer") |> PrefixedName

    /// <summary>
    ///   <para>nas:AirframeManufacturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A manufacturer of physical aircraft.</para>
    /// labels<para>Airframe manufacturer</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#AirframeManufacturer">https://data.nasa.gov/ontologies/atmonto/NAS#AirframeManufacturer</seealso>
    let AirframeManufacturer =
        Prefixed_Name(nas, "AirframeManufacturer") |> PrefixedName

    /// <summary>
    ///   <para>nas:Airport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A facility where regularly-scheduled aircraft arrive and depart.</para>
    /// labels<para>Airport</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#Airport">https://data.nasa.gov/ontologies/atmonto/NAS#Airport</seealso>
    let Airport = Prefixed_Name(nas, "Airport") |> PrefixedName

    /// <summary>
    ///   <para>nas:AirportServiceVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class of vehicles that service the flights and maintain the airport physical infrastructure.</para>
    /// labels<para>Airport service vehicle</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#AirportServiceVehicle">https://data.nasa.gov/ontologies/atmonto/NAS#AirportServiceVehicle</seealso>
    let AirportServiceVehicle =
        Prefixed_Name(nas, "AirportServiceVehicle") |> PrefixedName

    /// <summary>
    ///   <para>nas:AirspaceRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An ordered sequence of navigation elements specifying a path through the airspace.</para>
    /// </remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#AirspaceRoute">https://data.nasa.gov/ontologies/atmonto/NAS#AirspaceRoute</seealso>
    let AirspaceRoute = Prefixed_Name(nas, "AirspaceRoute") |> PrefixedName
    /// <summary>
    ///   <para>nas:airCarrierName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The official name of an air carrier.</para>
    /// labels<para>Air carrier name</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#airCarrierName">https://data.nasa.gov/ontologies/atmonto/NAS#airCarrierName</seealso>
    let airCarrierName = Prefixed_Name(nas, "airCarrierName") |> PrefixedName
    /// <summary>
    ///   <para>nas:airportBoundary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an airport to a representation of its perimeter boundary.</para>
    /// labels<para>airport boundary</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#airportBoundary">https://data.nasa.gov/ontologies/atmonto/NAS#airportBoundary</seealso>
    let airportBoundary = Prefixed_Name(nas, "airportBoundary") |> PrefixedName
    /// <summary>
    ///   <para>nas:airportName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The official name of the airport.</para>
    /// labels<para>airport name</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#airportName">https://data.nasa.gov/ontologies/atmonto/NAS#airportName</seealso>
    let airportName = Prefixed_Name(nas, "airportName") |> PrefixedName

    /// <summary>
    ///   <para>nas:airspaceLayerHighAltitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The upper altitude bound of an airspace layer.</para>
    /// labels<para>airspace layer high altitude</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#airspaceLayerHighAltitude">https://data.nasa.gov/ontologies/atmonto/NAS#airspaceLayerHighAltitude</seealso>
    let airspaceLayerHighAltitude =
        Prefixed_Name(nas, "airspaceLayerHighAltitude") |> PrefixedName

    /// <summary>
    ///   <para>nas:ATCT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Air Traffic Control Tower (ATCT) facility</para>
    /// labels<para>ATCT</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#ATCT">https://data.nasa.gov/ontologies/atmonto/NAS#ATCT</seealso>
    let ATCT = Prefixed_Name(nas, "ATCT") |> PrefixedName
    /// <summary>
    ///   <para>nas:AirCarrier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An entity that it licensed to operate aircraft.</para>
    /// labels<para>Air carrier</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#AirCarrier">https://data.nasa.gov/ontologies/atmonto/NAS#AirCarrier</seealso>
    let AirCarrier = Prefixed_Name(nas, "AirCarrier") |> PrefixedName

    /// <summary>
    ///   <para>nas:AviationServiceProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A superclass encompassing all entities that provide aviation services in the public and private sectors.</para>
    /// labels<para>Aviation service provider</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#AviationServiceProvider">https://data.nasa.gov/ontologies/atmonto/NAS#AviationServiceProvider</seealso>
    let AviationServiceProvider =
        Prefixed_Name(nas, "AviationServiceProvider") |> PrefixedName

    /// <summary>
    ///   <para>nas:AviationIndustryManufacturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A superclass encompassing the set of airframe and engine manufacturers.</para>
    /// labels<para>Aviation industry manufacturer</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#AviationIndustryManufacturer">https://data.nasa.gov/ontologies/atmonto/NAS#AviationIndustryManufacturer</seealso>
    let AviationIndustryManufacturer =
        Prefixed_Name(nas, "AviationIndustryManufacturer") |> PrefixedName

    /// <summary>
    ///   <para>nas:STAR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A STAR (Standard Terminal Arrival Route) is an air traffic control coded arrival route established for application to arriving IFR (Instrument Flight Rules) aircraft destined for certain airports.</para>
    /// labels<para>Standard Arrival Route</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#STAR">https://data.nasa.gov/ontologies/atmonto/NAS#STAR</seealso>
    let STAR = Prefixed_Name(nas, "STAR") |> PrefixedName
    /// <summary>
    ///   <para>nas:Sector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A defined volume in the the airspace of an ARTCC or TRACON whose flight traffic is typically controlled by a single controller.</para>
    /// labels<para>Sector</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#Sector">https://data.nasa.gov/ontologies/atmonto/NAS#Sector</seealso>
    let Sector = Prefixed_Name(nas, "Sector") |> PrefixedName
    /// <summary>
    ///   <para>nas:RampTower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A control tower from which ramp controllers guide aircraft movements as they enter and exit the taxiways, and arrive and leave the gates. The ramp is the area of the airport surface where planes, service vehicles, and people meet.</para>
    /// labels<para>Ramp tower</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#RampTower">https://data.nasa.gov/ontologies/atmonto/NAS#RampTower</seealso>
    let RampTower = Prefixed_Name(nas, "RampTower") |> PrefixedName
    /// <summary>
    ///   <para>nas:RefuelingTruck</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Vechicle that transports and pumps jet fuel to refuel aircraft.</para>
    /// labels<para>Refueling truck</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#RefuelingTruck">https://data.nasa.gov/ontologies/atmonto/NAS#RefuelingTruck</seealso>
    let RefuelingTruck = Prefixed_Name(nas, "RefuelingTruck") |> PrefixedName

    /// <summary>
    ///   <para>nas:RunwayVisibleRangeMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A measurement of the distance over which a pilot of an aircraft on the centerline of a runway can see the runway surface markings delineating the runway and its centerline. RVR (Runway Visible Range) is expressed as an interval specifying the minimum and maximum number of feet visible.</para>
    /// labels<para>RVR measurement</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#RunwayVisibleRangeMeasurement">https://data.nasa.gov/ontologies/atmonto/NAS#RunwayVisibleRangeMeasurement</seealso>
    let RunwayVisibleRangeMeasurement =
        Prefixed_Name(nas, "RunwayVisibleRangeMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>nas:SID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A SID (Standard Instrument Departure) is an air traffic control coded departure procedure that has been established at certain airports to simplify clearance delivery procedures.</para>
    /// labels<para>Standard Instrument Departure</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#SID">https://data.nasa.gov/ontologies/atmonto/NAS#SID</seealso>
    let SID = Prefixed_Name(nas, "SID") |> PrefixedName
    /// <summary>
    ///   <para>nas:SIDSTAR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A superclass of SID and STAR defining the properties shared by both, specifically the set of common, airport, and transition routes that comprise the SID/STAR.</para>
    /// labels<para>SIDSTAR</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#SIDSTAR">https://data.nasa.gov/ontologies/atmonto/NAS#SIDSTAR</seealso>
    let SIDSTAR = Prefixed_Name(nas, "SIDSTAR") |> PrefixedName
    /// <summary>
    ///   <para>nas:AirportRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A route within a SID or STAR that connects the common route to one of multiple airports that use the SID/STAR.</para>
    /// labels<para>Airport route</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#AirportRoute">https://data.nasa.gov/ontologies/atmonto/NAS#AirportRoute</seealso>
    let AirportRoute = Prefixed_Name(nas, "AirportRoute") |> PrefixedName
    /// <summary>
    ///   <para>nas:AirspaceLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents a layer within the airspace, defined by a shear-sided polygon with specified low and high altitudes.</para>
    /// labels<para>Airspace layer</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#AirspaceLayer">https://data.nasa.gov/ontologies/atmonto/NAS#AirspaceLayer</seealso>
    let AirspaceLayer = Prefixed_Name(nas, "AirspaceLayer") |> PrefixedName

    /// <summary>
    ///   <para>nas:StandAloneWeatherStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A non-airport location where operational weather monitoring hardware is installed.</para>
    /// labels<para>Stand-alone weather station</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#StandAloneWeatherStation">https://data.nasa.gov/ontologies/atmonto/NAS#StandAloneWeatherStation</seealso>
    let StandAloneWeatherStation =
        Prefixed_Name(nas, "StandAloneWeatherStation") |> PrefixedName

    /// <summary>
    ///   <para>nas:TRACON</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Terminal Radar Approach Control (TRACON) facility</para>
    /// labels<para>TRACON</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#TRACON">https://data.nasa.gov/ontologies/atmonto/NAS#TRACON</seealso>
    let TRACON = Prefixed_Name(nas, "TRACON") |> PrefixedName
    /// <summary>
    ///   <para>nas:TransitionRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A route within a SID or STAR that feeds aircraft into or out from the common route of the SID/STAR. In other words, the transition route is a feeder route from the en route segment of a flight into the heart of a STAR for arrival; or an exit route from a SID funneling flights to their appropriate initial jet routes for the en route segment of flight.</para>
    /// labels<para>Transition route</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#TransitionRoute">https://data.nasa.gov/ontologies/atmonto/NAS#TransitionRoute</seealso>
    let TransitionRoute = Prefixed_Name(nas, "TransitionRoute") |> PrefixedName
    /// <summary>
    ///   <para>nas:SIDSTARroute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A route that defines a SID or STAR.</para>
    /// labels<para>SIDSTARroute</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#SIDSTARroute">https://data.nasa.gov/ontologies/atmonto/NAS#SIDSTARroute</seealso>
    let SIDSTARroute = Prefixed_Name(nas, "SIDSTARroute") |> PrefixedName
    /// <summary>
    ///   <para>nas:CONUSairport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The set of airports in the continental US.</para>
    /// labels<para>Continental US airport</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#CONUSairport">https://data.nasa.gov/ontologies/atmonto/NAS#CONUSairport</seealso>
    let CONUSairport = Prefixed_Name(nas, "CONUSairport") |> PrefixedName
    /// <summary>
    ///   <para>nas:CanadianAirport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The set of Canadian airports.</para>
    /// labels<para>Canadian airport</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#CanadianAirport">https://data.nasa.gov/ontologies/atmonto/NAS#CanadianAirport</seealso>
    let CanadianAirport = Prefixed_Name(nas, "CanadianAirport") |> PrefixedName
    /// <summary>
    ///   <para>nas:CommonRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The backbone portion of a SID or STAR that is flown by all aircraft.</para>
    /// labels<para>Common route</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#CommonRoute">https://data.nasa.gov/ontologies/atmonto/NAS#CommonRoute</seealso>
    let CommonRoute = Prefixed_Name(nas, "CommonRoute") |> PrefixedName
    /// <summary>
    ///   <para>nas:DeicingQueue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An ordered sequence of aircraft awaiting deicing at a deicing pad.</para>
    /// labels<para>Deicing queue</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#DeicingQueue">https://data.nasa.gov/ontologies/atmonto/NAS#DeicingQueue</seealso>
    let DeicingQueue = Prefixed_Name(nas, "DeicingQueue") |> PrefixedName
    /// <summary>
    ///   <para>nas:faaAirportCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The alphanumeric FAA code of lenth 3 or 4 for the airport. Contrasted with the ICAO and IATA codes, which in general are different. Often the IATA and FAA codes are identical.</para>
    /// labels<para>FAA airport code</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#faaAirportCode">https://data.nasa.gov/ontologies/atmonto/NAS#faaAirportCode</seealso>
    let faaAirportCode = Prefixed_Name(nas, "faaAirportCode") |> PrefixedName

    /// <summary>
    ///   <para>nas:hasAirspaceLayerGeometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an airspace layer with a polygon describing its location in 3-space. A sector is composed of a sequence of layers, each of which is represented as a shear-sided polygonal volume.</para>
    /// labels<para>has airspace layer geometry</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#hasAirspaceLayerGeometry">https://data.nasa.gov/ontologies/atmonto/NAS#hasAirspaceLayerGeometry</seealso>
    let hasAirspaceLayerGeometry =
        Prefixed_Name(nas, "hasAirspaceLayerGeometry") |> PrefixedName

    /// <summary>
    ///   <para>nas:USairport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The set of airports located in the United States.</para>
    /// labels<para>USairport</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#USairport">https://data.nasa.gov/ontologies/atmonto/NAS#USairport</seealso>
    let USairport = Prefixed_Name(nas, "USairport") |> PrefixedName
    /// <summary>
    ///   <para>nas:arrivalRouteAirport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links to the airport for which this route is destined.</para>
    /// labels<para>arrival route airport</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#arrivalRouteAirport">https://data.nasa.gov/ontologies/atmonto/NAS#arrivalRouteAirport</seealso>
    let arrivalRouteAirport = Prefixed_Name(nas, "arrivalRouteAirport") |> PrefixedName
    /// <summary>
    ///   <para>nas:associatedAirport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Associates some component of airport infrastructure (runway, terminal, tower, etc.) with its airport.</para>
    /// labels<para>associated airport</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#associatedAirport">https://data.nasa.gov/ontologies/atmonto/NAS#associatedAirport</seealso>
    let associatedAirport = Prefixed_Name(nas, "associatedAirport") |> PrefixedName
    /// <summary>
    ///   <para>nas:calendarMonth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The month number associated with a day class.</para>
    /// </remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#calendarMonth">https://data.nasa.gov/ontologies/atmonto/NAS#calendarMonth</seealso>
    let calendarMonth = Prefixed_Name(nas, "calendarMonth") |> PrefixedName
    /// <summary>
    ///   <para>nas:date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date corresponding to the day represented by the day class. The value of this property is a date datatype. In contrast, the class represents the day conceptually as an object.</para>
    /// labels<para>date</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#date">https://data.nasa.gov/ontologies/atmonto/NAS#date</seealso>
    let date = Prefixed_Name(nas, "date") |> PrefixedName

    /// <summary>
    ///   <para>nas:InternationalAirport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The set of international (i.e., non-US) airports.</para>
    /// labels<para>International airport</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#InternationalAirport">https://data.nasa.gov/ontologies/atmonto/NAS#InternationalAirport</seealso>
    let InternationalAirport =
        Prefixed_Name(nas, "InternationalAirport") |> PrefixedName

    /// <summary>
    ///   <para>nas:hasRampTower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates an airport terminal with a ramp tower that controlls the aircraft and vehicle traffic in the vicinity of that terminal.</para>
    /// labels<para>has ramp tower</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#hasRampTower">https://data.nasa.gov/ontologies/atmonto/NAS#hasRampTower</seealso>
    let hasRampTower = Prefixed_Name(nas, "hasRampTower") |> PrefixedName
    /// <summary>
    ///   <para>nas:hasSectorID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A sector identifier that consists of the ARTCC identifier concatenated with a three-digit number. This identifier is in general different than the sector name.</para>
    /// labels<para>has sector ID</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#hasSectorID">https://data.nasa.gov/ontologies/atmonto/NAS#hasSectorID</seealso>
    let hasSectorID = Prefixed_Name(nas, "hasSectorID") |> PrefixedName
    /// <summary>
    ///   <para>nas:hasTRACONcity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The city name where the TRACON command center is located.</para>
    /// labels<para>has TRACONcity</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTRACONcity">https://data.nasa.gov/ontologies/atmonto/NAS#hasTRACONcity</seealso>
    let hasTRACONcity = Prefixed_Name(nas, "hasTRACONcity") |> PrefixedName
    /// <summary>
    ///   <para>nas:hasTRACONname</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The common name for the TRACON.</para>
    /// labels<para>has TRACON name</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTRACONname">https://data.nasa.gov/ontologies/atmonto/NAS#hasTRACONname</seealso>
    let hasTRACONname = Prefixed_Name(nas, "hasTRACONname") |> PrefixedName
    /// <summary>
    ///   <para>nas:hasTerminal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an airport to a terminal for that airport.</para>
    /// labels<para>has terminal</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTerminal">https://data.nasa.gov/ontologies/atmonto/NAS#hasTerminal</seealso>
    let hasTerminal = Prefixed_Name(nas, "hasTerminal") |> PrefixedName

    /// <summary>
    ///   <para>nas:isWeatherReportingStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates whether this airport is a METAR weather reporting station.</para>
    /// labels<para>is weather reporting station</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#isWeatherReportingStation">https://data.nasa.gov/ontologies/atmonto/NAS#isWeatherReportingStation</seealso>
    let isWeatherReportingStation =
        Prefixed_Name(nas, "isWeatherReportingStation") |> PrefixedName

    /// <summary>
    ///   <para>nas:minVisibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The lower bound of visibility in feet over the centerline of the runway.</para>
    /// labels<para>min visibility</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#minVisibility">https://data.nasa.gov/ontologies/atmonto/NAS#minVisibility</seealso>
    let minVisibility = Prefixed_Name(nas, "minVisibility") |> PrefixedName
    /// <summary>
    ///   <para>nas:runwayMeasured</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Indicates which operational runway is being measured for visible range.</para>
    /// labels<para>runway measured</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#runwayMeasured">https://data.nasa.gov/ontologies/atmonto/NAS#runwayMeasured</seealso>
    let runwayMeasured = Prefixed_Name(nas, "runwayMeasured") |> PrefixedName
    /// <summary>
    ///   <para>nas:ARTCC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Air Route Traffic Control Center (ARTCC or 'Center') facility</para>
    /// labels<para>ARTCC</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#ARTCC">https://data.nasa.gov/ontologies/atmonto/NAS#ARTCC</seealso>
    let ARTCC = Prefixed_Name(nas, "ARTCC") |> PrefixedName
    /// <summary>
    ///   <para>nas:ATCSCC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Air Traffic Control System Command Center (ATCSCC) facility</para>
    /// labels<para>ATCSCC</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/NAS#ATCSCC">https://data.nasa.gov/ontologies/atmonto/NAS#ATCSCC</seealso>
    let ATCSCC = Prefixed_Name(nas, "ATCSCC") |> PrefixedName
