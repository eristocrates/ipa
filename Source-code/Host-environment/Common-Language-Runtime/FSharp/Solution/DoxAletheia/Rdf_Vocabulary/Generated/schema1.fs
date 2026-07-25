namespace http.schema.org.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module schema1 =
    let _namespace_iri = Namespace_Iri schema1 |> NamespaceIRI
    /// <summary>
    ///   <para>schema1:RadioChannel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A unique instance of a radio BroadcastService on a CableOrSatelliteService lineup.</para>
    /// labels<para>RadioChannel</para></remarks>
    /// <seealso href="http://schema.org/RadioChannel">http://schema.org/RadioChannel</seealso>
    let RadioChannel = Prefixed_Name(schema1, "RadioChannel") |> PrefixedName
    /// <summary>
    ///   <para>schema1:AcceptAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of committing to/adopting an object.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/RejectAction"&gt;RejectAction&lt;/a&gt;: The antonym of AcceptAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>AcceptAction</para></remarks>
    /// <seealso href="http://schema.org/AcceptAction">http://schema.org/AcceptAction</seealso>
    let AcceptAction = Prefixed_Name(schema1, "AcceptAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:BookSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A series of books. Included books can be indicated with the hasPart property.</para>
    /// labels<para>BookSeries</para></remarks>
    /// <seealso href="http://schema.org/BookSeries">http://schema.org/BookSeries</seealso>
    let BookSeries = Prefixed_Name(schema1, "BookSeries") |> PrefixedName
    /// <summary>
    ///   <para>schema1:BookmarkAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An agent bookmarks/flags/labels/tags/marks an object.</para>
    /// labels<para>BookmarkAction</para></remarks>
    /// <seealso href="http://schema.org/BookmarkAction">http://schema.org/BookmarkAction</seealso>
    let BookmarkAction = Prefixed_Name(schema1, "BookmarkAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Boolean</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:DataType</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Boolean: True or False.</para>
    /// labels<para>Boolean</para></remarks>
    /// <seealso href="http://schema.org/Boolean">http://schema.org/Boolean</seealso>
    let Boolean = Prefixed_Name(schema1, "Boolean") |> PrefixedName
    /// <summary>
    ///   <para>schema1:DataType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The basic data types such as Integers, Strings, etc.</para>
    /// labels<para>DataType</para></remarks>
    /// <seealso href="http://schema.org/DataType">http://schema.org/DataType</seealso>
    let DataType = Prefixed_Name(schema1, "DataType") |> PrefixedName
    /// <summary>
    ///   <para>schema1:BorrowAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of obtaining an object under an agreement to return it at a later date. Reciprocal of LendAction.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/LendAction"&gt;LendAction&lt;/a&gt;: Reciprocal of BorrowAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>BorrowAction</para></remarks>
    /// <seealso href="http://schema.org/BorrowAction">http://schema.org/BorrowAction</seealso>
    let BorrowAction = Prefixed_Name(schema1, "BorrowAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:BowlingAlley</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A bowling alley.</para>
    /// labels<para>BowlingAlley</para></remarks>
    /// <seealso href="http://schema.org/BowlingAlley">http://schema.org/BowlingAlley</seealso>
    let BowlingAlley = Prefixed_Name(schema1, "BowlingAlley") |> PrefixedName

    /// <summary>
    ///   <para>schema1:SportsActivityLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A sports location, such as a playing field.</para>
    /// labels<para>SportsActivityLocation</para></remarks>
    /// <seealso href="http://schema.org/SportsActivityLocation">http://schema.org/SportsActivityLocation</seealso>
    let SportsActivityLocation =
        Prefixed_Name(schema1, "SportsActivityLocation") |> PrefixedName

    /// <summary>
    ///   <para>schema1:Brand</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A brand is a name used by an organization or business person for labeling a product, product group, or similar.</para>
    /// labels<para>Brand</para></remarks>
    /// <seealso href="http://schema.org/Brand">http://schema.org/Brand</seealso>
    let Brand = Prefixed_Name(schema1, "Brand") |> PrefixedName
    /// <summary>
    ///   <para>schema1:BreadcrumbList</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A BreadcrumbList is an ItemList consisting of a chain of linked Web pages, typically described using at least their URL and their name, and typically ending with the current page.&lt;br/&gt;&lt;br/&gt;
    ///
    /// The &lt;a class="localLink" href="http://schema.org/position"&gt;position&lt;/a&gt; property is used to reconstruct the order of the items in a BreadcrumbList The convention is that a breadcrumb list has an &lt;a class="localLink" href="http://schema.org/itemListOrder"&gt;itemListOrder&lt;/a&gt; of &lt;a class="localLink" href="http://schema.org/ItemListOrderAscending"&gt;ItemListOrderAscending&lt;/a&gt; (lower values listed first), and that the first items in this list correspond to the "top" or beginning of the breadcrumb trail, e.g. with a site or section homepage. The specific values of 'position' are not assigned meaning for a BreadcrumbList, but they should be integers, e.g. beginning with '1' for the first item in the list.</para>
    /// labels<para>BreadcrumbList</para></remarks>
    /// <seealso href="http://schema.org/BreadcrumbList">http://schema.org/BreadcrumbList</seealso>
    let BreadcrumbList = Prefixed_Name(schema1, "BreadcrumbList") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Bridge</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A bridge.</para>
    /// labels<para>Bridge</para></remarks>
    /// <seealso href="http://schema.org/Bridge">http://schema.org/Bridge</seealso>
    let Bridge = Prefixed_Name(schema1, "Bridge") |> PrefixedName
    /// <summary>
    ///   <para>schema1:BroadcastEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An over the air or online broadcast event.</para>
    /// labels<para>BroadcastEvent</para></remarks>
    /// <seealso href="http://schema.org/BroadcastEvent">http://schema.org/BroadcastEvent</seealso>
    let BroadcastEvent = Prefixed_Name(schema1, "BroadcastEvent") |> PrefixedName
    /// <summary>
    ///   <para>schema1:BroadcastRelease</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:MusicAlbumReleaseType</para>
    ///   <para>BroadcastRelease.</para>
    /// labels<para>BroadcastRelease</para></remarks>
    /// <seealso href="http://schema.org/BroadcastRelease">http://schema.org/BroadcastRelease</seealso>
    let BroadcastRelease = Prefixed_Name(schema1, "BroadcastRelease") |> PrefixedName
    /// <summary>
    ///   <para>schema1:BroadcastService</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A delivery service through which content is provided via broadcast over the air or online.</para>
    /// labels<para>BroadcastService</para></remarks>
    /// <seealso href="http://schema.org/BroadcastService">http://schema.org/BroadcastService</seealso>
    let BroadcastService = Prefixed_Name(schema1, "BroadcastService") |> PrefixedName
    /// <summary>
    ///   <para>schema1:PlaceOfWorship</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Place of worship, such as a church, synagogue, or mosque.</para>
    /// labels<para>PlaceOfWorship</para></remarks>
    /// <seealso href="http://schema.org/PlaceOfWorship">http://schema.org/PlaceOfWorship</seealso>
    let PlaceOfWorship = Prefixed_Name(schema1, "PlaceOfWorship") |> PrefixedName
    /// <summary>
    ///   <para>schema1:BusReservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A reservation for bus travel. &lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use &lt;a class="localLink" href="http://schema.org/Offer"&gt;Offer&lt;/a&gt;.</para>
    /// labels<para>BusReservation</para></remarks>
    /// <seealso href="http://schema.org/BusReservation">http://schema.org/BusReservation</seealso>
    let BusReservation = Prefixed_Name(schema1, "BusReservation") |> PrefixedName
    /// <summary>
    ///   <para>schema1:BusStop</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A bus stop.</para>
    /// labels<para>BusStop</para></remarks>
    /// <seealso href="http://schema.org/BusStop">http://schema.org/BusStop</seealso>
    let BusStop = Prefixed_Name(schema1, "BusStop") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Trip</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A trip or journey. An itinerary of visits to one or more places.</para>
    /// labels<para>Trip</para></remarks>
    /// <seealso href="http://schema.org/Trip">http://schema.org/Trip</seealso>
    let Trip = Prefixed_Name(schema1, "Trip") |> PrefixedName
    /// <summary>
    ///   <para>schema1:BusinessAudience</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A set of characteristics belonging to businesses, e.g. who compose an item's target audience.</para>
    /// labels<para>BusinessAudience</para></remarks>
    /// <seealso href="http://schema.org/BusinessAudience">http://schema.org/BusinessAudience</seealso>
    let BusinessAudience = Prefixed_Name(schema1, "BusinessAudience") |> PrefixedName
    /// <summary>
    ///   <para>schema1:BusinessEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Event type: Business event.</para>
    /// labels<para>BusinessEvent</para></remarks>
    /// <seealso href="http://schema.org/BusinessEvent">http://schema.org/BusinessEvent</seealso>
    let BusinessEvent = Prefixed_Name(schema1, "BusinessEvent") |> PrefixedName
    /// <summary>
    ///   <para>schema1:BuyAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of giving money to a seller in exchange for goods or services rendered. An agent buys an object, product, or service from a seller for a price. Reciprocal of SellAction.</para>
    /// labels<para>BuyAction</para></remarks>
    /// <seealso href="http://schema.org/BuyAction">http://schema.org/BuyAction</seealso>
    let BuyAction = Prefixed_Name(schema1, "BuyAction") |> PrefixedName

    /// <summary>
    ///   <para>schema1:CableOrSatelliteService</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A service which provides access to media programming like TV or radio. Access may be via cable or satellite.</para>
    /// labels<para>CableOrSatelliteService</para></remarks>
    /// <seealso href="http://schema.org/CableOrSatelliteService">http://schema.org/CableOrSatelliteService</seealso>
    let CableOrSatelliteService =
        Prefixed_Name(schema1, "CableOrSatelliteService") |> PrefixedName

    /// <summary>
    ///   <para>schema1:CafeOrCoffeeShop</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A cafe or coffee shop.</para>
    /// labels<para>CafeOrCoffeeShop</para></remarks>
    /// <seealso href="http://schema.org/CafeOrCoffeeShop">http://schema.org/CafeOrCoffeeShop</seealso>
    let CafeOrCoffeeShop = Prefixed_Name(schema1, "CafeOrCoffeeShop") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Canal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A canal, like the Panama Canal.</para>
    /// labels<para>Canal</para></remarks>
    /// <seealso href="http://schema.org/Canal">http://schema.org/Canal</seealso>
    let Canal = Prefixed_Name(schema1, "Canal") |> PrefixedName
    /// <summary>
    ///   <para>schema1:CancelAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of asserting that a future event/action is no longer going to happen.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ConfirmAction"&gt;ConfirmAction&lt;/a&gt;: The antonym of CancelAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>CancelAction</para></remarks>
    /// <seealso href="http://schema.org/CancelAction">http://schema.org/CancelAction</seealso>
    let CancelAction = Prefixed_Name(schema1, "CancelAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Vehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.</para>
    /// labels<para>Vehicle</para></remarks>
    /// <seealso href="http://schema.org/Vehicle">http://schema.org/Vehicle</seealso>
    let Vehicle = Prefixed_Name(schema1, "Vehicle") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Casino</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A casino.</para>
    /// labels<para>Casino</para></remarks>
    /// <seealso href="http://schema.org/Casino">http://schema.org/Casino</seealso>
    let Casino = Prefixed_Name(schema1, "Casino") |> PrefixedName
    /// <summary>
    ///   <para>schema1:CassetteFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:MusicReleaseFormatType</para>
    ///   <para>CassetteFormat.</para>
    /// labels<para>CassetteFormat</para></remarks>
    /// <seealso href="http://schema.org/CassetteFormat">http://schema.org/CassetteFormat</seealso>
    let CassetteFormat = Prefixed_Name(schema1, "CassetteFormat") |> PrefixedName
    /// <summary>
    ///   <para>schema1:CatholicChurch</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Catholic church.</para>
    /// labels<para>CatholicChurch</para></remarks>
    /// <seealso href="http://schema.org/CatholicChurch">http://schema.org/CatholicChurch</seealso>
    let CatholicChurch = Prefixed_Name(schema1, "CatholicChurch") |> PrefixedName
    /// <summary>
    ///   <para>schema1:CheckAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An agent inspects, determines, investigates, inquires, or examines an object's accuracy, quality, condition, or state.</para>
    /// labels<para>CheckAction</para></remarks>
    /// <seealso href="http://schema.org/CheckAction">http://schema.org/CheckAction</seealso>
    let CheckAction = Prefixed_Name(schema1, "CheckAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:FindAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of finding an object.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/SearchAction"&gt;SearchAction&lt;/a&gt;: FindAction is generally lead by a SearchAction, but not necessarily.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>FindAction</para></remarks>
    /// <seealso href="http://schema.org/FindAction">http://schema.org/FindAction</seealso>
    let FindAction = Prefixed_Name(schema1, "FindAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:CheckInAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of an agent communicating (service provider, social media, etc) their arrival by registering/confirming for a previously reserved service (e.g. flight check in) or at a place (e.g. hotel), possibly resulting in a result (boarding pass, etc).&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/CheckOutAction"&gt;CheckOutAction&lt;/a&gt;: The antonym of CheckInAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ArriveAction"&gt;ArriveAction&lt;/a&gt;: Unlike ArriveAction, CheckInAction implies that the agent is informing/confirming the start of a previously reserved service.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ConfirmAction"&gt;ConfirmAction&lt;/a&gt;: Unlike ConfirmAction, CheckInAction implies that the agent is informing/confirming the &lt;em&gt;start&lt;/em&gt; of a previously reserved service rather than its validity/existence.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>CheckInAction</para></remarks>
    /// <seealso href="http://schema.org/CheckInAction">http://schema.org/CheckInAction</seealso>
    let CheckInAction = Prefixed_Name(schema1, "CheckInAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:CheckoutPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Web page type: Checkout page.</para>
    /// labels<para>CheckoutPage</para></remarks>
    /// <seealso href="http://schema.org/CheckoutPage">http://schema.org/CheckoutPage</seealso>
    let CheckoutPage = Prefixed_Name(schema1, "CheckoutPage") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ChildCare</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Childcare center.</para>
    /// labels<para>ChildCare</para></remarks>
    /// <seealso href="http://schema.org/ChildCare">http://schema.org/ChildCare</seealso>
    let ChildCare = Prefixed_Name(schema1, "ChildCare") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ChildrensEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Event type: Children's event.</para>
    /// labels<para>ChildrensEvent</para></remarks>
    /// <seealso href="http://schema.org/ChildrensEvent">http://schema.org/ChildrensEvent</seealso>
    let ChildrensEvent = Prefixed_Name(schema1, "ChildrensEvent") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ChooseAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of expressing a preference from a set of options or a large or unbounded set of choices/options.</para>
    /// labels<para>ChooseAction</para></remarks>
    /// <seealso href="http://schema.org/ChooseAction">http://schema.org/ChooseAction</seealso>
    let ChooseAction = Prefixed_Name(schema1, "ChooseAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:City</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A city or town.</para>
    /// labels<para>City</para></remarks>
    /// <seealso href="http://schema.org/City">http://schema.org/City</seealso>
    let City = Prefixed_Name(schema1, "City") |> PrefixedName

    /// <summary>
    ///   <para>schema1:GovernmentBuilding</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A government building.</para>
    /// labels<para>GovernmentBuilding</para></remarks>
    /// <seealso href="http://schema.org/GovernmentBuilding">http://schema.org/GovernmentBuilding</seealso>
    let GovernmentBuilding =
        Prefixed_Name(schema1, "GovernmentBuilding") |> PrefixedName

    /// <summary>
    ///   <para>schema1:ClaimReview</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A fact-checking review of claims made (or reported) in some creative work (referenced via itemReviewed).</para>
    /// labels<para>ClaimReview</para></remarks>
    /// <seealso href="http://schema.org/ClaimReview">http://schema.org/ClaimReview</seealso>
    let ClaimReview = Prefixed_Name(schema1, "ClaimReview") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Clip</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A short TV or radio program or a segment/part of a program.</para>
    /// labels<para>Clip</para></remarks>
    /// <seealso href="http://schema.org/Clip">http://schema.org/Clip</seealso>
    let Clip = Prefixed_Name(schema1, "Clip") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ClothingStore</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A clothing store.</para>
    /// labels<para>ClothingStore</para></remarks>
    /// <seealso href="http://schema.org/ClothingStore">http://schema.org/ClothingStore</seealso>
    let ClothingStore = Prefixed_Name(schema1, "ClothingStore") |> PrefixedName
    /// <summary>
    ///   <para>schema1:CoOp</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:GamePlayMode</para>
    ///   <para>Play mode: CoOp. Co-operative games, where you play on the same team with friends.</para>
    /// labels<para>CoOp</para></remarks>
    /// <seealso href="http://schema.org/CoOp">http://schema.org/CoOp</seealso>
    let CoOp = Prefixed_Name(schema1, "CoOp") |> PrefixedName
    /// <summary>
    ///   <para>schema1:GamePlayMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Indicates whether this game is multi-player, co-op or single-player.</para>
    /// labels<para>GamePlayMode</para></remarks>
    /// <seealso href="http://schema.org/GamePlayMode">http://schema.org/GamePlayMode</seealso>
    let GamePlayMode = Prefixed_Name(schema1, "GamePlayMode") |> PrefixedName
    /// <summary>
    ///   <para>schema1:CollectionPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Web page type: Collection page.</para>
    /// labels<para>CollectionPage</para></remarks>
    /// <seealso href="http://schema.org/CollectionPage">http://schema.org/CollectionPage</seealso>
    let CollectionPage = Prefixed_Name(schema1, "CollectionPage") |> PrefixedName

    /// <summary>
    ///   <para>schema1:CollegeOrUniversity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A college, university, or other third-level educational institution.</para>
    /// labels<para>CollegeOrUniversity</para></remarks>
    /// <seealso href="http://schema.org/CollegeOrUniversity">http://schema.org/CollegeOrUniversity</seealso>
    let CollegeOrUniversity =
        Prefixed_Name(schema1, "CollegeOrUniversity") |> PrefixedName

    /// <summary>
    ///   <para>schema1:EducationalOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An educational organization.</para>
    /// labels<para>EducationalOrganization</para></remarks>
    /// <seealso href="http://schema.org/EducationalOrganization">http://schema.org/EducationalOrganization</seealso>
    let EducationalOrganization =
        Prefixed_Name(schema1, "EducationalOrganization") |> PrefixedName

    /// <summary>
    ///   <para>schema1:ComedyClub</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A comedy club.</para>
    /// labels<para>ComedyClub</para></remarks>
    /// <seealso href="http://schema.org/ComedyClub">http://schema.org/ComedyClub</seealso>
    let ComedyClub = Prefixed_Name(schema1, "ComedyClub") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ComedyEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Event type: Comedy event.</para>
    /// labels<para>ComedyEvent</para></remarks>
    /// <seealso href="http://schema.org/ComedyEvent">http://schema.org/ComedyEvent</seealso>
    let ComedyEvent = Prefixed_Name(schema1, "ComedyEvent") |> PrefixedName
    /// <summary>
    ///   <para>schema1:CommentAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of generating a comment about a subject.</para>
    /// labels<para>CommentAction</para></remarks>
    /// <seealso href="http://schema.org/CommentAction">http://schema.org/CommentAction</seealso>
    let CommentAction = Prefixed_Name(schema1, "CommentAction") |> PrefixedName

    /// <summary>
    ///   <para>schema1:DigitalDocumentPermissionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A type of permission which can be granted for accessing a digital document.</para>
    /// labels<para>DigitalDocumentPermissionType</para></remarks>
    /// <seealso href="http://schema.org/DigitalDocumentPermissionType">http://schema.org/DigitalDocumentPermissionType</seealso>
    let DigitalDocumentPermissionType =
        Prefixed_Name(schema1, "DigitalDocumentPermissionType") |> PrefixedName

    /// <summary>
    ///   <para>schema1:CompilationAlbum</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:MusicAlbumProductionType</para>
    ///   <para>CompilationAlbum.</para>
    /// labels<para>CompilationAlbum</para></remarks>
    /// <seealso href="http://schema.org/CompilationAlbum">http://schema.org/CompilationAlbum</seealso>
    let CompilationAlbum = Prefixed_Name(schema1, "CompilationAlbum") |> PrefixedName

    /// <summary>
    ///   <para>schema1:MusicAlbumProductionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Classification of the album by it's type of content: soundtrack, live album, studio album, etc.</para>
    /// labels<para>MusicAlbumProductionType</para></remarks>
    /// <seealso href="http://schema.org/MusicAlbumProductionType">http://schema.org/MusicAlbumProductionType</seealso>
    let MusicAlbumProductionType =
        Prefixed_Name(schema1, "MusicAlbumProductionType") |> PrefixedName

    /// <summary>
    ///   <para>schema1:CompletedActionStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:ActionStatusType</para>
    ///   <para>An action that has already taken place.</para>
    /// labels<para>CompletedActionStatus</para></remarks>
    /// <seealso href="http://schema.org/CompletedActionStatus">http://schema.org/CompletedActionStatus</seealso>
    let CompletedActionStatus =
        Prefixed_Name(schema1, "CompletedActionStatus") |> PrefixedName

    /// <summary>
    ///   <para>schema1:CompoundPriceSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A compound price specification is one that bundles multiple prices that all apply in combination for different dimensions of consumption. Use the name property of the attached unit price specification for indicating the dimension of a price component (e.g. "electricity" or "final cleaning").</para>
    /// labels<para>CompoundPriceSpecification</para></remarks>
    /// <seealso href="http://schema.org/CompoundPriceSpecification">http://schema.org/CompoundPriceSpecification</seealso>
    let CompoundPriceSpecification =
        Prefixed_Name(schema1, "CompoundPriceSpecification") |> PrefixedName

    /// <summary>
    ///   <para>schema1:PriceSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A structured value representing a price or price range. Typically, only the subclasses of this type are used for markup. It is recommended to use &lt;a class="localLink" href="http://schema.org/MonetaryAmount"&gt;MonetaryAmount&lt;/a&gt; to describe independent amounts of money such as a salary, credit card limits, etc.</para>
    /// labels<para>PriceSpecification</para></remarks>
    /// <seealso href="http://schema.org/PriceSpecification">http://schema.org/PriceSpecification</seealso>
    let PriceSpecification =
        Prefixed_Name(schema1, "PriceSpecification") |> PrefixedName

    /// <summary>
    ///   <para>schema1:ConfirmAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of notifying someone that a future event/action is going to happen as expected.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/CancelAction"&gt;CancelAction&lt;/a&gt;: The antonym of ConfirmAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>ConfirmAction</para></remarks>
    /// <seealso href="http://schema.org/ConfirmAction">http://schema.org/ConfirmAction</seealso>
    let ConfirmAction = Prefixed_Name(schema1, "ConfirmAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:InformAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of notifying someone of information pertinent to them, with no expectation of a response.</para>
    /// labels<para>InformAction</para></remarks>
    /// <seealso href="http://schema.org/InformAction">http://schema.org/InformAction</seealso>
    let InformAction = Prefixed_Name(schema1, "InformAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ConsumeAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of ingesting information/resources/food.</para>
    /// labels<para>ConsumeAction</para></remarks>
    /// <seealso href="http://schema.org/ConsumeAction">http://schema.org/ConsumeAction</seealso>
    let ConsumeAction = Prefixed_Name(schema1, "ConsumeAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ContactPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Web page type: Contact page.</para>
    /// labels<para>ContactPage</para></remarks>
    /// <seealso href="http://schema.org/ContactPage">http://schema.org/ContactPage</seealso>
    let ContactPage = Prefixed_Name(schema1, "ContactPage") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ContactPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A contact point&amp;#x2014;for example, a Customer Complaints department.</para>
    /// labels<para>ContactPoint</para></remarks>
    /// <seealso href="http://schema.org/ContactPoint">http://schema.org/ContactPoint</seealso>
    let ContactPoint = Prefixed_Name(schema1, "ContactPoint") |> PrefixedName
    /// <summary>
    ///   <para>schema1:StructuredValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Structured values are used when the value of a property has a more complex structure than simply being a textual value or a reference to another thing.</para>
    /// labels<para>StructuredValue</para></remarks>
    /// <seealso href="http://schema.org/StructuredValue">http://schema.org/StructuredValue</seealso>
    let StructuredValue = Prefixed_Name(schema1, "StructuredValue") |> PrefixedName

    /// <summary>
    ///   <para>schema1:ContactPointOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Enumerated options related to a ContactPoint.</para>
    /// labels<para>ContactPointOption</para></remarks>
    /// <seealso href="http://schema.org/ContactPointOption">http://schema.org/ContactPointOption</seealso>
    let ContactPointOption =
        Prefixed_Name(schema1, "ContactPointOption") |> PrefixedName

    /// <summary>
    ///   <para>schema1:ConvenienceStore</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A convenience store.</para>
    /// labels<para>ConvenienceStore</para></remarks>
    /// <seealso href="http://schema.org/ConvenienceStore">http://schema.org/ConvenienceStore</seealso>
    let ConvenienceStore = Prefixed_Name(schema1, "ConvenienceStore") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Conversation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>One or more messages between organizations or people on a particular topic. Individual messages can be linked to the conversation with isPartOf or hasPart properties.</para>
    /// labels<para>Conversation</para></remarks>
    /// <seealso href="http://schema.org/Conversation">http://schema.org/Conversation</seealso>
    let Conversation = Prefixed_Name(schema1, "Conversation") |> PrefixedName
    /// <summary>
    ///   <para>schema1:CookAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of producing/preparing food.</para>
    /// labels<para>CookAction</para></remarks>
    /// <seealso href="http://schema.org/CookAction">http://schema.org/CookAction</seealso>
    let CookAction = Prefixed_Name(schema1, "CookAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:CreateAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of deliberately creating/producing/generating/building a result out of the agent.</para>
    /// labels<para>CreateAction</para></remarks>
    /// <seealso href="http://schema.org/CreateAction">http://schema.org/CreateAction</seealso>
    let CreateAction = Prefixed_Name(schema1, "CreateAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Corporation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Organization: A business corporation.</para>
    /// labels<para>Corporation</para></remarks>
    /// <seealso href="http://schema.org/Corporation">http://schema.org/Corporation</seealso>
    let Corporation = Prefixed_Name(schema1, "Corporation") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Country</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A country.</para>
    /// labels<para>Country</para></remarks>
    /// <seealso href="http://schema.org/Country">http://schema.org/Country</seealso>
    let Country = Prefixed_Name(schema1, "Country") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Course</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A description of an educational course which may be offered as distinct instances at which take place at different times or take place at different locations, or be offered through different media or modes of study. An educational course is a sequence of one or more educational events and/or creative works which aims to build knowledge, competence or ability of learners.</para>
    /// labels<para>Course</para></remarks>
    /// <seealso href="http://schema.org/Course">http://schema.org/Course</seealso>
    let Course = Prefixed_Name(schema1, "Course") |> PrefixedName
    /// <summary>
    ///   <para>schema1:CourseInstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An instance of a &lt;a class="localLink" href="http://schema.org/Course"&gt;Course&lt;/a&gt; which is distinct from other instances because it is offered at a different time or location or through different media or modes of study or to a specific section of students.</para>
    /// labels<para>CourseInstance</para></remarks>
    /// <seealso href="http://schema.org/CourseInstance">http://schema.org/CourseInstance</seealso>
    let CourseInstance = Prefixed_Name(schema1, "CourseInstance") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Courthouse</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A courthouse.</para>
    /// labels<para>Courthouse</para></remarks>
    /// <seealso href="http://schema.org/Courthouse">http://schema.org/Courthouse</seealso>
    let Courthouse = Prefixed_Name(schema1, "Courthouse") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Series</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Series in schema.org is a group of related items, typically but not necessarily of the same kind. See also &lt;a class="localLink" href="http://schema.org/CreativeWorkSeries"&gt;CreativeWorkSeries&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/EventSeries"&gt;EventSeries&lt;/a&gt;.</para>
    /// labels<para>Series</para></remarks>
    /// <seealso href="http://schema.org/Series">http://schema.org/Series</seealso>
    let Series = Prefixed_Name(schema1, "Series") |> PrefixedName
    /// <summary>
    ///   <para>schema1:CreditCard</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A card payment method of a particular brand or name.  Used to mark up a particular payment method and/or the financial product/service that supplies the card account.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Commonly used values:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#AmericanExpress&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#DinersClub&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#Discover&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#JCB&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#MasterCard&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#VISA&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>CreditCard</para></remarks>
    /// <seealso href="http://schema.org/CreditCard">http://schema.org/CreditCard</seealso>
    let CreditCard = Prefixed_Name(schema1, "CreditCard") |> PrefixedName
    /// <summary>
    ///   <para>schema1:LoanOrCredit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A financial product for the loaning of an amount of money under agreed terms and charges.</para>
    /// labels<para>LoanOrCredit</para></remarks>
    /// <seealso href="http://schema.org/LoanOrCredit">http://schema.org/LoanOrCredit</seealso>
    let LoanOrCredit = Prefixed_Name(schema1, "LoanOrCredit") |> PrefixedName
    /// <summary>
    ///   <para>schema1:PaymentCard</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A payment method using a credit, debit, store or other card to associate the payment with an account.</para>
    /// labels<para>PaymentCard</para></remarks>
    /// <seealso href="http://schema.org/PaymentCard">http://schema.org/PaymentCard</seealso>
    let PaymentCard = Prefixed_Name(schema1, "PaymentCard") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Crematorium</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A crematorium.</para>
    /// labels<para>Crematorium</para></remarks>
    /// <seealso href="http://schema.org/Crematorium">http://schema.org/Crematorium</seealso>
    let Crematorium = Prefixed_Name(schema1, "Crematorium") |> PrefixedName

    /// <summary>
    ///   <para>schema1:CurrencyConversionService</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A service to convert funds from one currency to another currency.</para>
    /// labels<para>CurrencyConversionService</para></remarks>
    /// <seealso href="http://schema.org/CurrencyConversionService">http://schema.org/CurrencyConversionService</seealso>
    let CurrencyConversionService =
        Prefixed_Name(schema1, "CurrencyConversionService") |> PrefixedName

    /// <summary>
    ///   <para>schema1:DVDFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:MusicReleaseFormatType</para>
    ///   <para>DVDFormat.</para>
    /// labels<para>DVDFormat</para></remarks>
    /// <seealso href="http://schema.org/DVDFormat">http://schema.org/DVDFormat</seealso>
    let DVDFormat = Prefixed_Name(schema1, "DVDFormat") |> PrefixedName
    /// <summary>
    ///   <para>schema1:DamagedCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:OfferItemCondition</para>
    ///   <para>Indicates that the item is damaged.</para>
    /// labels<para>DamagedCondition</para></remarks>
    /// <seealso href="http://schema.org/DamagedCondition">http://schema.org/DamagedCondition</seealso>
    let DamagedCondition = Prefixed_Name(schema1, "DamagedCondition") |> PrefixedName

    /// <summary>
    ///   <para>schema1:OfferItemCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A list of possible conditions for the item.</para>
    /// labels<para>OfferItemCondition</para></remarks>
    /// <seealso href="http://schema.org/OfferItemCondition">http://schema.org/OfferItemCondition</seealso>
    let OfferItemCondition =
        Prefixed_Name(schema1, "OfferItemCondition") |> PrefixedName

    /// <summary>
    ///   <para>schema1:DanceEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Event type: A social dance.</para>
    /// labels<para>DanceEvent</para></remarks>
    /// <seealso href="http://schema.org/DanceEvent">http://schema.org/DanceEvent</seealso>
    let DanceEvent = Prefixed_Name(schema1, "DanceEvent") |> PrefixedName
    /// <summary>
    ///   <para>schema1:DanceGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A dance group&amp;#x2014;for example, the Alvin Ailey Dance Theater or Riverdance.</para>
    /// labels<para>DanceGroup</para></remarks>
    /// <seealso href="http://schema.org/DanceGroup">http://schema.org/DanceGroup</seealso>
    let DanceGroup = Prefixed_Name(schema1, "DanceGroup") |> PrefixedName
    /// <summary>
    ///   <para>schema1:PerformingGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A performance group, such as a band, an orchestra, or a circus.</para>
    /// labels<para>PerformingGroup</para></remarks>
    /// <seealso href="http://schema.org/PerformingGroup">http://schema.org/PerformingGroup</seealso>
    let PerformingGroup = Prefixed_Name(schema1, "PerformingGroup") |> PrefixedName
    /// <summary>
    ///   <para>schema1:DataFeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A single feed providing structured information about one or more entities or topics.</para>
    /// labels<para>DataFeed</para></remarks>
    /// <seealso href="http://schema.org/DataFeed">http://schema.org/DataFeed</seealso>
    let DataFeed = Prefixed_Name(schema1, "DataFeed") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A body of structured information describing some topic(s) of interest.</para>
    /// labels<para>Dataset</para></remarks>
    /// <seealso href="http://schema.org/Dataset">http://schema.org/Dataset</seealso>
    let Dataset = Prefixed_Name(schema1, "Dataset") |> PrefixedName
    /// <summary>
    ///   <para>schema1:DataFeedItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A single item within a larger data feed.</para>
    /// labels<para>DataFeedItem</para></remarks>
    /// <seealso href="http://schema.org/DataFeedItem">http://schema.org/DataFeedItem</seealso>
    let DataFeedItem = Prefixed_Name(schema1, "DataFeedItem") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Date</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:DataType</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A date value in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.</para>
    /// labels<para>Date</para></remarks>
    /// <seealso href="http://schema.org/Date">http://schema.org/Date</seealso>
    let Date = Prefixed_Name(schema1, "Date") |> PrefixedName
    /// <summary>
    ///   <para>schema1:DateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:DataType</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A combination of date and time of day in the form [-]CCYY-MM-DDThh:mm:ss[Z|(+|-)hh:mm] (see Chapter 5.4 of ISO 8601).</para>
    /// labels<para>DateTime</para></remarks>
    /// <seealso href="http://schema.org/DateTime">http://schema.org/DateTime</seealso>
    let DateTime = Prefixed_Name(schema1, "DateTime") |> PrefixedName

    /// <summary>
    ///   <para>schema1:DatedMoneySpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A DatedMoneySpecification represents monetary values with optional start and end dates. For example, this could represent an employee's salary over a specific period of time. &lt;strong&gt;Note:&lt;/strong&gt; This type has been superseded by &lt;a class="localLink" href="http://schema.org/MonetaryAmount"&gt;MonetaryAmount&lt;/a&gt; use of that type is recommended</para>
    /// labels<para>DatedMoneySpecification</para></remarks>
    /// <seealso href="http://schema.org/DatedMoneySpecification">http://schema.org/DatedMoneySpecification</seealso>
    let DatedMoneySpecification =
        Prefixed_Name(schema1, "DatedMoneySpecification") |> PrefixedName

    /// <summary>
    ///   <para>schema1:MonetaryAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A monetary value or range. This type can be used to describe an amount of money such as $50 USD, or a range as in describing a bank account being suitable for a balance between £1,000 and £1,000,000 GBP, or the value of a salary, etc. It is recommended to use &lt;a class="localLink" href="http://schema.org/PriceSpecification"&gt;PriceSpecification&lt;/a&gt; Types to describe the price of an Offer, Invoice, etc.</para>
    /// labels<para>MonetaryAmount</para></remarks>
    /// <seealso href="http://schema.org/MonetaryAmount">http://schema.org/MonetaryAmount</seealso>
    let MonetaryAmount = Prefixed_Name(schema1, "MonetaryAmount") |> PrefixedName
    /// <summary>
    ///   <para>schema1:DayOfWeek</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The day of the week, e.g. used to specify to which day the opening hours of an OpeningHoursSpecification refer.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Originally, URLs from &lt;a href="http://purl.org/goodrelations/v1"&gt;GoodRelations&lt;/a&gt; were used (for &lt;a class="localLink" href="http://schema.org/Monday"&gt;Monday&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Tuesday"&gt;Tuesday&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Wednesday"&gt;Wednesday&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Thursday"&gt;Thursday&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Friday"&gt;Friday&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Saturday"&gt;Saturday&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Sunday"&gt;Sunday&lt;/a&gt; plus a special entry for &lt;a class="localLink" href="http://schema.org/PublicHolidays"&gt;PublicHolidays&lt;/a&gt;); these have now been integrated directly into schema.org.</para>
    /// labels<para>DayOfWeek</para></remarks>
    /// <seealso href="http://schema.org/DayOfWeek">http://schema.org/DayOfWeek</seealso>
    let DayOfWeek = Prefixed_Name(schema1, "DayOfWeek") |> PrefixedName
    /// <summary>
    ///   <para>schema1:DaySpa</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A day spa.</para>
    /// labels<para>DaySpa</para></remarks>
    /// <seealso href="http://schema.org/DaySpa">http://schema.org/DaySpa</seealso>
    let DaySpa = Prefixed_Name(schema1, "DaySpa") |> PrefixedName
    /// <summary>
    ///   <para>schema1:DeactivateAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of stopping or deactivating a device or application (e.g. stopping a timer or turning off a flashlight).</para>
    /// labels<para>DeactivateAction</para></remarks>
    /// <seealso href="http://schema.org/DeactivateAction">http://schema.org/DeactivateAction</seealso>
    let DeactivateAction = Prefixed_Name(schema1, "DeactivateAction") |> PrefixedName

    /// <summary>
    ///   <para>schema1:DefenceEstablishment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A defence establishment, such as an army or navy base.</para>
    /// labels<para>DefenceEstablishment</para></remarks>
    /// <seealso href="http://schema.org/DefenceEstablishment">http://schema.org/DefenceEstablishment</seealso>
    let DefenceEstablishment =
        Prefixed_Name(schema1, "DefenceEstablishment") |> PrefixedName

    /// <summary>
    ///   <para>schema1:DeleteAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of editing a recipient by removing one of its objects.</para>
    /// labels<para>DeleteAction</para></remarks>
    /// <seealso href="http://schema.org/DeleteAction">http://schema.org/DeleteAction</seealso>
    let DeleteAction = Prefixed_Name(schema1, "DeleteAction") |> PrefixedName

    /// <summary>
    ///   <para>schema1:DeliveryChargeSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The price for the delivery of an offer using a particular delivery method.</para>
    /// labels<para>DeliveryChargeSpecification</para></remarks>
    /// <seealso href="http://schema.org/DeliveryChargeSpecification">http://schema.org/DeliveryChargeSpecification</seealso>
    let DeliveryChargeSpecification =
        Prefixed_Name(schema1, "DeliveryChargeSpecification") |> PrefixedName

    /// <summary>
    ///   <para>schema1:DeliveryEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An event involving the delivery of an item.</para>
    /// labels<para>DeliveryEvent</para></remarks>
    /// <seealso href="http://schema.org/DeliveryEvent">http://schema.org/DeliveryEvent</seealso>
    let DeliveryEvent = Prefixed_Name(schema1, "DeliveryEvent") |> PrefixedName
    /// <summary>
    ///   <para>schema1:DeliveryMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A delivery method is a standardized procedure for transferring the product or service to the destination of fulfillment chosen by the customer. Delivery methods are characterized by the means of transportation used, and by the organization or group that is the contracting party for the sending organization or person.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Commonly used values:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#DeliveryModeDirectDownload&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#DeliveryModeFreight&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#DeliveryModeMail&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#DeliveryModeOwnFleet&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#DeliveryModePickUp&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#DHL&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#FederalExpress&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#UPS&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>DeliveryMethod</para></remarks>
    /// <seealso href="http://schema.org/DeliveryMethod">http://schema.org/DeliveryMethod</seealso>
    let DeliveryMethod = Prefixed_Name(schema1, "DeliveryMethod") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Dentist</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A dentist.</para>
    /// labels<para>Dentist</para></remarks>
    /// <seealso href="http://schema.org/Dentist">http://schema.org/Dentist</seealso>
    let Dentist = Prefixed_Name(schema1, "Dentist") |> PrefixedName
    /// <summary>
    ///   <para>schema1:MedicalBusiness</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schema.org/MedicalBusiness">http://schema.org/MedicalBusiness</seealso>
    let MedicalBusiness = Prefixed_Name(schema1, "MedicalBusiness") |> PrefixedName

    /// <summary>
    ///   <para>schema1:MedicalOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A medical organization (physical or not), such as hospital, institution or clinic.</para>
    /// labels<para>MedicalOrganization</para></remarks>
    /// <seealso href="http://schema.org/MedicalOrganization">http://schema.org/MedicalOrganization</seealso>
    let MedicalOrganization =
        Prefixed_Name(schema1, "MedicalOrganization") |> PrefixedName

    /// <summary>
    ///   <para>schema1:DepartAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of  departing from a place. An agent departs from an fromLocation for a destination, optionally with participants.</para>
    /// labels<para>DepartAction</para></remarks>
    /// <seealso href="http://schema.org/DepartAction">http://schema.org/DepartAction</seealso>
    let DepartAction = Prefixed_Name(schema1, "DepartAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:DepartmentStore</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A department store.</para>
    /// labels<para>DepartmentStore</para></remarks>
    /// <seealso href="http://schema.org/DepartmentStore">http://schema.org/DepartmentStore</seealso>
    let DepartmentStore = Prefixed_Name(schema1, "DepartmentStore") |> PrefixedName
    /// <summary>
    ///   <para>schema1:DepositAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A type of Bank Account with a main purpose of depositing funds to gain interest or other benefits.</para>
    /// labels<para>DepositAccount</para></remarks>
    /// <seealso href="http://schema.org/DepositAccount">http://schema.org/DepositAccount</seealso>
    let DepositAccount = Prefixed_Name(schema1, "DepositAccount") |> PrefixedName

    /// <summary>
    ///   <para>schema1:InvestmentOrDeposit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A type of financial product that typically requires the client to transfer funds to a financial service in return for potential beneficial financial return.</para>
    /// labels<para>InvestmentOrDeposit</para></remarks>
    /// <seealso href="http://schema.org/InvestmentOrDeposit">http://schema.org/InvestmentOrDeposit</seealso>
    let InvestmentOrDeposit =
        Prefixed_Name(schema1, "InvestmentOrDeposit") |> PrefixedName

    /// <summary>
    ///   <para>schema1:DiabeticDiet</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:RestrictedDiet</para>
    ///   <para>A diet appropriate for people with diabetes.</para>
    /// labels<para>DiabeticDiet</para></remarks>
    /// <seealso href="http://schema.org/DiabeticDiet">http://schema.org/DiabeticDiet</seealso>
    let DiabeticDiet = Prefixed_Name(schema1, "DiabeticDiet") |> PrefixedName
    /// <summary>
    ///   <para>schema1:RestrictedDiet</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A diet restricted to certain foods or preparations for cultural, religious, health or lifestyle reasons.</para>
    /// labels<para>RestrictedDiet</para></remarks>
    /// <seealso href="http://schema.org/RestrictedDiet">http://schema.org/RestrictedDiet</seealso>
    let RestrictedDiet = Prefixed_Name(schema1, "RestrictedDiet") |> PrefixedName

    /// <summary>
    ///   <para>schema1:DigitalAudioTapeFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:MusicReleaseFormatType</para>
    ///   <para>DigitalAudioTapeFormat.</para>
    /// labels<para>DigitalAudioTapeFormat</para></remarks>
    /// <seealso href="http://schema.org/DigitalAudioTapeFormat">http://schema.org/DigitalAudioTapeFormat</seealso>
    let DigitalAudioTapeFormat =
        Prefixed_Name(schema1, "DigitalAudioTapeFormat") |> PrefixedName

    /// <summary>
    ///   <para>schema1:DigitalDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An electronic file or document.</para>
    /// labels<para>DigitalDocument</para></remarks>
    /// <seealso href="http://schema.org/DigitalDocument">http://schema.org/DigitalDocument</seealso>
    let DigitalDocument = Prefixed_Name(schema1, "DigitalDocument") |> PrefixedName

    /// <summary>
    ///   <para>schema1:DigitalDocumentPermission</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A permission for a particular person or group to access a particular file.</para>
    /// labels<para>DigitalDocumentPermission</para></remarks>
    /// <seealso href="http://schema.org/DigitalDocumentPermission">http://schema.org/DigitalDocumentPermission</seealso>
    let DigitalDocumentPermission =
        Prefixed_Name(schema1, "DigitalDocumentPermission") |> PrefixedName

    /// <summary>
    ///   <para>schema1:DigitalFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:MusicReleaseFormatType</para>
    ///   <para>DigitalFormat.</para>
    /// labels<para>DigitalFormat</para></remarks>
    /// <seealso href="http://schema.org/DigitalFormat">http://schema.org/DigitalFormat</seealso>
    let DigitalFormat = Prefixed_Name(schema1, "DigitalFormat") |> PrefixedName
    /// <summary>
    ///   <para>schema1:DislikeAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of expressing a negative sentiment about the object. An agent dislikes an object (a proposition, topic or theme) with participants.</para>
    /// labels<para>DislikeAction</para></remarks>
    /// <seealso href="http://schema.org/DislikeAction">http://schema.org/DislikeAction</seealso>
    let DislikeAction = Prefixed_Name(schema1, "DislikeAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Distance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Properties that take Distances as values are of the form '&amp;lt;Number&amp;gt; &amp;lt;Length unit of measure&amp;gt;'. E.g., '7 ft'.</para>
    /// labels<para>Distance</para></remarks>
    /// <seealso href="http://schema.org/Distance">http://schema.org/Distance</seealso>
    let Distance = Prefixed_Name(schema1, "Distance") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Quantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Quantities such as distance, time, mass, weight, etc. Particular instances of say Mass are entities like '3 Kg' or '4 milligrams'.</para>
    /// labels<para>Quantity</para></remarks>
    /// <seealso href="http://schema.org/Quantity">http://schema.org/Quantity</seealso>
    let Quantity = Prefixed_Name(schema1, "Quantity") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Distillery</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A distillery.</para>
    /// labels<para>Distillery</para></remarks>
    /// <seealso href="http://schema.org/Distillery">http://schema.org/Distillery</seealso>
    let Distillery = Prefixed_Name(schema1, "Distillery") |> PrefixedName
    /// <summary>
    ///   <para>schema1:DonateAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of providing goods, services, or money without compensation, often for philanthropic reasons.</para>
    /// labels<para>DonateAction</para></remarks>
    /// <seealso href="http://schema.org/DonateAction">http://schema.org/DonateAction</seealso>
    let DonateAction = Prefixed_Name(schema1, "DonateAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:DownloadAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of downloading an object.</para>
    /// labels<para>DownloadAction</para></remarks>
    /// <seealso href="http://schema.org/DownloadAction">http://schema.org/DownloadAction</seealso>
    let DownloadAction = Prefixed_Name(schema1, "DownloadAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:DrawAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of producing a visual/graphical representation of an object, typically with a pen/pencil and paper as instruments.</para>
    /// labels<para>DrawAction</para></remarks>
    /// <seealso href="http://schema.org/DrawAction">http://schema.org/DrawAction</seealso>
    let DrawAction = Prefixed_Name(schema1, "DrawAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:DrinkAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of swallowing liquids.</para>
    /// labels<para>DrinkAction</para></remarks>
    /// <seealso href="http://schema.org/DrinkAction">http://schema.org/DrinkAction</seealso>
    let DrinkAction = Prefixed_Name(schema1, "DrinkAction") |> PrefixedName

    /// <summary>
    ///   <para>schema1:DryCleaningOrLaundry</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A dry-cleaning business.</para>
    /// labels<para>DryCleaningOrLaundry</para></remarks>
    /// <seealso href="http://schema.org/DryCleaningOrLaundry">http://schema.org/DryCleaningOrLaundry</seealso>
    let DryCleaningOrLaundry =
        Prefixed_Name(schema1, "DryCleaningOrLaundry") |> PrefixedName

    /// <summary>
    ///   <para>schema1:Duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Quantity: Duration (use &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;).</para>
    /// labels<para>Duration</para></remarks>
    /// <seealso href="http://schema.org/Duration">http://schema.org/Duration</seealso>
    let Duration = Prefixed_Name(schema1, "Duration") |> PrefixedName
    /// <summary>
    ///   <para>schema1:EatAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of swallowing solid objects.</para>
    /// labels<para>EatAction</para></remarks>
    /// <seealso href="http://schema.org/EatAction">http://schema.org/EatAction</seealso>
    let EatAction = Prefixed_Name(schema1, "EatAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:EducationEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Event type: Education event.</para>
    /// labels<para>EducationEvent</para></remarks>
    /// <seealso href="http://schema.org/EducationEvent">http://schema.org/EducationEvent</seealso>
    let EducationEvent = Prefixed_Name(schema1, "EducationEvent") |> PrefixedName

    /// <summary>
    ///   <para>schema1:EducationalAudience</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An EducationalAudience.</para>
    /// labels<para>EducationalAudience</para></remarks>
    /// <seealso href="http://schema.org/EducationalAudience">http://schema.org/EducationalAudience</seealso>
    let EducationalAudience =
        Prefixed_Name(schema1, "EducationalAudience") |> PrefixedName

    /// <summary>
    ///   <para>schema1:Electrician</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An electrician.</para>
    /// labels<para>Electrician</para></remarks>
    /// <seealso href="http://schema.org/Electrician">http://schema.org/Electrician</seealso>
    let Electrician = Prefixed_Name(schema1, "Electrician") |> PrefixedName

    /// <summary>
    ///   <para>schema1:HomeAndConstructionBusiness</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A construction business.&lt;br/&gt;&lt;br/&gt;
    ///
    /// A HomeAndConstructionBusiness is a &lt;a class="localLink" href="http://schema.org/LocalBusiness"&gt;LocalBusiness&lt;/a&gt; that provides services around homes and buildings.&lt;br/&gt;&lt;br/&gt;
    ///
    /// As a &lt;a class="localLink" href="http://schema.org/LocalBusiness"&gt;LocalBusiness&lt;/a&gt; it can be described as a &lt;a class="localLink" href="http://schema.org/provider"&gt;provider&lt;/a&gt; of one or more &lt;a class="localLink" href="http://schema.org/Service"&gt;Service&lt;/a&gt;(s).</para>
    /// labels<para>HomeAndConstructionBusiness</para></remarks>
    /// <seealso href="http://schema.org/HomeAndConstructionBusiness">http://schema.org/HomeAndConstructionBusiness</seealso>
    let HomeAndConstructionBusiness =
        Prefixed_Name(schema1, "HomeAndConstructionBusiness") |> PrefixedName

    /// <summary>
    ///   <para>schema1:ElectronicsStore</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An electronics store.</para>
    /// labels<para>ElectronicsStore</para></remarks>
    /// <seealso href="http://schema.org/ElectronicsStore">http://schema.org/ElectronicsStore</seealso>
    let ElectronicsStore = Prefixed_Name(schema1, "ElectronicsStore") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ElementarySchool</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An elementary school.</para>
    /// labels<para>ElementarySchool</para></remarks>
    /// <seealso href="http://schema.org/ElementarySchool">http://schema.org/ElementarySchool</seealso>
    let ElementarySchool = Prefixed_Name(schema1, "ElementarySchool") |> PrefixedName
    /// <summary>
    ///   <para>schema1:EmailMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An email message.</para>
    /// labels<para>EmailMessage</para></remarks>
    /// <seealso href="http://schema.org/EmailMessage">http://schema.org/EmailMessage</seealso>
    let EmailMessage = Prefixed_Name(schema1, "EmailMessage") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Message</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A single message from a sender to one or more organizations or people.</para>
    /// labels<para>Message</para></remarks>
    /// <seealso href="http://schema.org/Message">http://schema.org/Message</seealso>
    let Message = Prefixed_Name(schema1, "Message") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Embassy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An embassy.</para>
    /// labels<para>Embassy</para></remarks>
    /// <seealso href="http://schema.org/Embassy">http://schema.org/Embassy</seealso>
    let Embassy = Prefixed_Name(schema1, "Embassy") |> PrefixedName
    /// <summary>
    ///   <para>schema1:EmergencyService</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An emergency service, such as a fire station or ER.</para>
    /// labels<para>EmergencyService</para></remarks>
    /// <seealso href="http://schema.org/EmergencyService">http://schema.org/EmergencyService</seealso>
    let EmergencyService = Prefixed_Name(schema1, "EmergencyService") |> PrefixedName
    /// <summary>
    ///   <para>schema1:EmployeeRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A subclass of OrganizationRole used to describe employee relationships.</para>
    /// labels<para>EmployeeRole</para></remarks>
    /// <seealso href="http://schema.org/EmployeeRole">http://schema.org/EmployeeRole</seealso>
    let EmployeeRole = Prefixed_Name(schema1, "EmployeeRole") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Museum</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A museum.</para>
    /// labels<para>Museum</para></remarks>
    /// <seealso href="http://schema.org/Museum">http://schema.org/Museum</seealso>
    let Museum = Prefixed_Name(schema1, "Museum") |> PrefixedName
    /// <summary>
    ///   <para>schema1:MusicAlbum</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A collection of music tracks.</para>
    /// labels<para>MusicAlbum</para></remarks>
    /// <seealso href="http://schema.org/MusicAlbum">http://schema.org/MusicAlbum</seealso>
    let MusicAlbum = Prefixed_Name(schema1, "MusicAlbum") |> PrefixedName
    /// <summary>
    ///   <para>schema1:MusicPlaylist</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A collection of music tracks in playlist form.</para>
    /// labels<para>MusicPlaylist</para></remarks>
    /// <seealso href="http://schema.org/MusicPlaylist">http://schema.org/MusicPlaylist</seealso>
    let MusicPlaylist = Prefixed_Name(schema1, "MusicPlaylist") |> PrefixedName
    /// <summary>
    ///   <para>schema1:MusicComposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A musical composition.</para>
    /// labels<para>MusicComposition</para></remarks>
    /// <seealso href="http://schema.org/MusicComposition">http://schema.org/MusicComposition</seealso>
    let MusicComposition = Prefixed_Name(schema1, "MusicComposition") |> PrefixedName
    /// <summary>
    ///   <para>schema1:MusicEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Event type: Music event.</para>
    /// labels<para>MusicEvent</para></remarks>
    /// <seealso href="http://schema.org/MusicEvent">http://schema.org/MusicEvent</seealso>
    let MusicEvent = Prefixed_Name(schema1, "MusicEvent") |> PrefixedName
    /// <summary>
    ///   <para>schema1:MusicGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A musical group, such as a band, an orchestra, or a choir. Can also be a solo musician.</para>
    /// labels<para>MusicGroup</para></remarks>
    /// <seealso href="http://schema.org/MusicGroup">http://schema.org/MusicGroup</seealso>
    let MusicGroup = Prefixed_Name(schema1, "MusicGroup") |> PrefixedName
    /// <summary>
    ///   <para>schema1:MusicRecording</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A music recording (track), usually a single song.</para>
    /// labels<para>MusicRecording</para></remarks>
    /// <seealso href="http://schema.org/MusicRecording">http://schema.org/MusicRecording</seealso>
    let MusicRecording = Prefixed_Name(schema1, "MusicRecording") |> PrefixedName
    /// <summary>
    ///   <para>schema1:MusicRelease</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A MusicRelease is a specific release of a music album.</para>
    /// labels<para>MusicRelease</para></remarks>
    /// <seealso href="http://schema.org/MusicRelease">http://schema.org/MusicRelease</seealso>
    let MusicRelease = Prefixed_Name(schema1, "MusicRelease") |> PrefixedName
    /// <summary>
    ///   <para>schema1:MusicVenue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A music venue.</para>
    /// labels<para>MusicVenue</para></remarks>
    /// <seealso href="http://schema.org/MusicVenue">http://schema.org/MusicVenue</seealso>
    let MusicVenue = Prefixed_Name(schema1, "MusicVenue") |> PrefixedName
    /// <summary>
    ///   <para>schema1:MusicVideoObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A music video file.</para>
    /// labels<para>MusicVideoObject</para></remarks>
    /// <seealso href="http://schema.org/MusicVideoObject">http://schema.org/MusicVideoObject</seealso>
    let MusicVideoObject = Prefixed_Name(schema1, "MusicVideoObject") |> PrefixedName
    /// <summary>
    ///   <para>schema1:NGO</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Organization: Non-governmental Organization.</para>
    /// labels<para>NGO</para></remarks>
    /// <seealso href="http://schema.org/NGO">http://schema.org/NGO</seealso>
    let NGO = Prefixed_Name(schema1, "NGO") |> PrefixedName
    /// <summary>
    ///   <para>schema1:NailSalon</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A nail salon.</para>
    /// labels<para>NailSalon</para></remarks>
    /// <seealso href="http://schema.org/NailSalon">http://schema.org/NailSalon</seealso>
    let NailSalon = Prefixed_Name(schema1, "NailSalon") |> PrefixedName
    /// <summary>
    ///   <para>schema1:NewCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:OfferItemCondition</para>
    ///   <para>Indicates that the item is new.</para>
    /// labels<para>NewCondition</para></remarks>
    /// <seealso href="http://schema.org/NewCondition">http://schema.org/NewCondition</seealso>
    let NewCondition = Prefixed_Name(schema1, "NewCondition") |> PrefixedName
    /// <summary>
    ///   <para>schema1:NewsArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A NewsArticle is an article whose content reports news, or provides background context and supporting materials for understanding the news.&lt;br/&gt;&lt;br/&gt;
    ///
    /// A more detailed overview of &lt;a href="/docs/news.html"&gt;schema.org News markup&lt;/a&gt; is also available.</para>
    /// labels<para>NewsArticle</para></remarks>
    /// <seealso href="http://schema.org/NewsArticle">http://schema.org/NewsArticle</seealso>
    let NewsArticle = Prefixed_Name(schema1, "NewsArticle") |> PrefixedName
    /// <summary>
    ///   <para>schema1:NightClub</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A nightclub or discotheque.</para>
    /// labels<para>NightClub</para></remarks>
    /// <seealso href="http://schema.org/NightClub">http://schema.org/NightClub</seealso>
    let NightClub = Prefixed_Name(schema1, "NightClub") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Notary</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A notary.</para>
    /// labels<para>Notary</para></remarks>
    /// <seealso href="http://schema.org/Notary">http://schema.org/Notary</seealso>
    let Notary = Prefixed_Name(schema1, "Notary") |> PrefixedName

    /// <summary>
    ///   <para>schema1:NoteDigitalDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A file containing a note, primarily for the author.</para>
    /// labels<para>NoteDigitalDocument</para></remarks>
    /// <seealso href="http://schema.org/NoteDigitalDocument">http://schema.org/NoteDigitalDocument</seealso>
    let NoteDigitalDocument =
        Prefixed_Name(schema1, "NoteDigitalDocument") |> PrefixedName

    /// <summary>
    ///   <para>schema1:countriesSupported</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Countries for which the application is supported. You can also provide the two-letter ISO 3166-1 alpha-2 country code.</para>
    /// labels<para>countriesSupported</para></remarks>
    /// <seealso href="http://schema.org/countriesSupported">http://schema.org/countriesSupported</seealso>
    let countriesSupported =
        Prefixed_Name(schema1, "countriesSupported") |> PrefixedName

    /// <summary>
    ///   <para>schema1:countryOfOrigin</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The country of the principal offices of the production company or individual responsible for the movie or program.</para>
    /// labels<para>countryOfOrigin</para></remarks>
    /// <seealso href="http://schema.org/countryOfOrigin">http://schema.org/countryOfOrigin</seealso>
    let countryOfOrigin = Prefixed_Name(schema1, "countryOfOrigin") |> PrefixedName
    /// <summary>
    ///   <para>schema1:course</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of location. The course where this action was taken.</para>
    /// labels<para>course</para></remarks>
    /// <seealso href="http://schema.org/course">http://schema.org/course</seealso>
    let course = Prefixed_Name(schema1, "course") |> PrefixedName
    /// <summary>
    ///   <para>schema1:exerciseCourse</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of location. The course where this action was taken.</para>
    /// labels<para>exerciseCourse</para></remarks>
    /// <seealso href="http://schema.org/exerciseCourse">http://schema.org/exerciseCourse</seealso>
    let exerciseCourse = Prefixed_Name(schema1, "exerciseCourse") |> PrefixedName
    /// <summary>
    ///   <para>schema1:location</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The location of for example where the event is happening, an organization is located, or where an action takes place.</para>
    /// labels<para>location</para></remarks>
    /// <seealso href="http://schema.org/location">http://schema.org/location</seealso>
    let location = Prefixed_Name(schema1, "location") |> PrefixedName
    /// <summary>
    ///   <para>schema1:courseCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The identifier for the &lt;a class="localLink" href="http://schema.org/Course"&gt;Course&lt;/a&gt; used by the course &lt;a class="localLink" href="http://schema.org/provider"&gt;provider&lt;/a&gt; (e.g. CS101 or 6.001).</para>
    /// labels<para>courseCode</para></remarks>
    /// <seealso href="http://schema.org/courseCode">http://schema.org/courseCode</seealso>
    let courseCode = Prefixed_Name(schema1, "courseCode") |> PrefixedName
    /// <summary>
    ///   <para>schema1:courseMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The medium or means of delivery of the course instance or the mode of study, either as a text label (e.g. "online", "onsite" or "blended"; "synchronous" or "asynchronous"; "full-time" or "part-time") or as a URL reference to a term from a controlled vocabulary (e.g. https://ceds.ed.gov/element/001311#Asynchronous ).</para>
    /// labels<para>courseMode</para></remarks>
    /// <seealso href="http://schema.org/courseMode">http://schema.org/courseMode</seealso>
    let courseMode = Prefixed_Name(schema1, "courseMode") |> PrefixedName

    /// <summary>
    ///   <para>schema1:coursePrerequisites</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Requirements for taking the Course. May be completion of another &lt;a class="localLink" href="http://schema.org/Course"&gt;Course&lt;/a&gt; or a textual description like "permission of instructor". Requirements may be a pre-requisite competency, referenced using &lt;a class="localLink" href="http://schema.org/AlignmentObject"&gt;AlignmentObject&lt;/a&gt;.</para>
    /// labels<para>coursePrerequisites</para></remarks>
    /// <seealso href="http://schema.org/coursePrerequisites">http://schema.org/coursePrerequisites</seealso>
    let coursePrerequisites =
        Prefixed_Name(schema1, "coursePrerequisites") |> PrefixedName

    /// <summary>
    ///   <para>schema1:coverageEndTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The time when the live blog will stop covering the Event. Note that coverage may continue after the Event concludes.</para>
    /// labels<para>coverageEndTime</para></remarks>
    /// <seealso href="http://schema.org/coverageEndTime">http://schema.org/coverageEndTime</seealso>
    let coverageEndTime = Prefixed_Name(schema1, "coverageEndTime") |> PrefixedName
    /// <summary>
    ///   <para>schema1:coverageStartTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The time when the live blog will begin covering the Event. Note that coverage may begin before the Event's start time. The LiveBlogPosting may also be created before coverage begins.</para>
    /// labels<para>coverageStartTime</para></remarks>
    /// <seealso href="http://schema.org/coverageStartTime">http://schema.org/coverageStartTime</seealso>
    let coverageStartTime = Prefixed_Name(schema1, "coverageStartTime") |> PrefixedName
    /// <summary>
    ///   <para>schema1:creator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The creator/author of this CreativeWork. This is the same as the Author property for CreativeWork.</para>
    /// labels<para>creator</para></remarks>
    /// <seealso href="http://schema.org/creator">http://schema.org/creator</seealso>
    let creator = Prefixed_Name(schema1, "creator") |> PrefixedName
    /// <summary>
    ///   <para>schema1:creditedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The group the release is credited to if different than the byArtist. For example, Red and Blue is credited to "Stefani Germanotta Band", but by Lady Gaga.</para>
    /// labels<para>creditedTo</para></remarks>
    /// <seealso href="http://schema.org/creditedTo">http://schema.org/creditedTo</seealso>
    let creditedTo = Prefixed_Name(schema1, "creditedTo") |> PrefixedName

    /// <summary>
    ///   <para>schema1:hostingOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The organization (airline, travelers' club, etc.) the membership is made with.</para>
    /// labels<para>hostingOrganization</para></remarks>
    /// <seealso href="http://schema.org/hostingOrganization">http://schema.org/hostingOrganization</seealso>
    let hostingOrganization =
        Prefixed_Name(schema1, "hostingOrganization") |> PrefixedName

    /// <summary>
    ///   <para>schema1:hoursAvailable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The hours during which this service or contact is available.</para>
    /// labels<para>hoursAvailable</para></remarks>
    /// <seealso href="http://schema.org/hoursAvailable">http://schema.org/hoursAvailable</seealso>
    let hoursAvailable = Prefixed_Name(schema1, "hoursAvailable") |> PrefixedName
    /// <summary>
    ///   <para>schema1:httpMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An HTTP method that specifies the appropriate HTTP method for a request to an HTTP EntryPoint. Values are capitalized strings as used in HTTP.</para>
    /// labels<para>httpMethod</para></remarks>
    /// <seealso href="http://schema.org/httpMethod">http://schema.org/httpMethod</seealso>
    let httpMethod = Prefixed_Name(schema1, "httpMethod") |> PrefixedName
    /// <summary>
    ///   <para>schema1:iataCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>IATA identifier for an airline or airport.</para>
    /// labels<para>iataCode</para></remarks>
    /// <seealso href="http://schema.org/iataCode">http://schema.org/iataCode</seealso>
    let iataCode = Prefixed_Name(schema1, "iataCode") |> PrefixedName
    /// <summary>
    ///   <para>schema1:icaoCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>ICAO identifier for an airport.</para>
    /// labels<para>icaoCode</para></remarks>
    /// <seealso href="http://schema.org/icaoCode">http://schema.org/icaoCode</seealso>
    let icaoCode = Prefixed_Name(schema1, "icaoCode") |> PrefixedName
    /// <summary>
    ///   <para>schema1:illustrator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The illustrator of the book.</para>
    /// labels<para>illustrator</para></remarks>
    /// <seealso href="http://schema.org/illustrator">http://schema.org/illustrator</seealso>
    let illustrator = Prefixed_Name(schema1, "illustrator") |> PrefixedName
    /// <summary>
    ///   <para>schema1:image</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An image of the item. This can be a &lt;a class="localLink" href="http://schema.org/URL"&gt;URL&lt;/a&gt; or a fully described &lt;a class="localLink" href="http://schema.org/ImageObject"&gt;ImageObject&lt;/a&gt;.</para>
    /// labels<para>image</para></remarks>
    /// <seealso href="http://schema.org/image">http://schema.org/image</seealso>
    let image = Prefixed_Name(schema1, "image") |> PrefixedName
    /// <summary>
    ///   <para>schema1:inAlbum</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The album to which this recording belongs.</para>
    /// labels<para>inAlbum</para></remarks>
    /// <seealso href="http://schema.org/inAlbum">http://schema.org/inAlbum</seealso>
    let inAlbum = Prefixed_Name(schema1, "inAlbum") |> PrefixedName
    /// <summary>
    ///   <para>schema1:inBroadcastLineup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The CableOrSatelliteService offering the channel.</para>
    /// labels<para>inBroadcastLineup</para></remarks>
    /// <seealso href="http://schema.org/inBroadcastLineup">http://schema.org/inBroadcastLineup</seealso>
    let inBroadcastLineup = Prefixed_Name(schema1, "inBroadcastLineup") |> PrefixedName
    /// <summary>
    ///   <para>schema1:pickupLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Where a taxi will pick up a passenger or a rental car can be picked up.</para>
    /// labels<para>pickupLocation</para></remarks>
    /// <seealso href="http://schema.org/pickupLocation">http://schema.org/pickupLocation</seealso>
    let pickupLocation = Prefixed_Name(schema1, "pickupLocation") |> PrefixedName
    /// <summary>
    ///   <para>schema1:pickupTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>When a taxi will pickup a passenger or a rental car can be picked up.</para>
    /// labels<para>pickupTime</para></remarks>
    /// <seealso href="http://schema.org/pickupTime">http://schema.org/pickupTime</seealso>
    let pickupTime = Prefixed_Name(schema1, "pickupTime") |> PrefixedName
    /// <summary>
    ///   <para>schema1:playMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates whether this game is multi-player, co-op or single-player.  The game can be marked as multi-player, co-op and single-player at the same time.</para>
    /// labels<para>playMode</para></remarks>
    /// <seealso href="http://schema.org/playMode">http://schema.org/playMode</seealso>
    let playMode = Prefixed_Name(schema1, "playMode") |> PrefixedName
    /// <summary>
    ///   <para>schema1:playerType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Player type required&amp;#x2014;for example, Flash or Silverlight.</para>
    /// labels<para>playerType</para></remarks>
    /// <seealso href="http://schema.org/playerType">http://schema.org/playerType</seealso>
    let playerType = Prefixed_Name(schema1, "playerType") |> PrefixedName
    /// <summary>
    ///   <para>schema1:playersOnline</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Number of players on the server.</para>
    /// labels<para>playersOnline</para></remarks>
    /// <seealso href="http://schema.org/playersOnline">http://schema.org/playersOnline</seealso>
    let playersOnline = Prefixed_Name(schema1, "playersOnline") |> PrefixedName
    /// <summary>
    ///   <para>schema1:polygon</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A polygon is the area enclosed by a point-to-point path for which the starting and ending points are the same. A polygon is expressed as a series of four or more space delimited points where the first and final points are identical.</para>
    /// labels<para>polygon</para></remarks>
    /// <seealso href="http://schema.org/polygon">http://schema.org/polygon</seealso>
    let polygon = Prefixed_Name(schema1, "polygon") |> PrefixedName

    /// <summary>
    ///   <para>schema1:postOfficeBoxNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The post office box number for PO box addresses.</para>
    /// labels<para>postOfficeBoxNumber</para></remarks>
    /// <seealso href="http://schema.org/postOfficeBoxNumber">http://schema.org/postOfficeBoxNumber</seealso>
    let postOfficeBoxNumber =
        Prefixed_Name(schema1, "postOfficeBoxNumber") |> PrefixedName

    /// <summary>
    ///   <para>schema1:postalCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The postal code. For example, 94043.</para>
    /// labels<para>postalCode</para></remarks>
    /// <seealso href="http://schema.org/postalCode">http://schema.org/postalCode</seealso>
    let postalCode = Prefixed_Name(schema1, "postalCode") |> PrefixedName
    /// <summary>
    ///   <para>schema1:potentialAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a potential Action, which describes an idealized action in which this thing would play an 'object' role.</para>
    /// labels<para>potentialAction</para></remarks>
    /// <seealso href="http://schema.org/potentialAction">http://schema.org/potentialAction</seealso>
    let potentialAction = Prefixed_Name(schema1, "potentialAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:predecessorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A pointer from a previous, often discontinued variant of the product to its newer variant.</para>
    /// labels<para>predecessorOf</para></remarks>
    /// <seealso href="http://schema.org/predecessorOf">http://schema.org/predecessorOf</seealso>
    let predecessorOf = Prefixed_Name(schema1, "predecessorOf") |> PrefixedName
    /// <summary>
    ///   <para>schema1:prepTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The length of time it takes to prepare the items to be used in instructions or a direction, in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.</para>
    /// labels<para>prepTime</para></remarks>
    /// <seealso href="http://schema.org/prepTime">http://schema.org/prepTime</seealso>
    let prepTime = Prefixed_Name(schema1, "prepTime") |> PrefixedName
    /// <summary>
    ///   <para>schema1:previousItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A link to the ListItem that preceeds the current one.</para>
    /// labels<para>previousItem</para></remarks>
    /// <seealso href="http://schema.org/previousItem">http://schema.org/previousItem</seealso>
    let previousItem = Prefixed_Name(schema1, "previousItem") |> PrefixedName
    /// <summary>
    ///   <para>schema1:previousStartDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Used in conjunction with eventStatus for rescheduled or cancelled events. This property contains the previously scheduled start date. For rescheduled events, the startDate property should be used for the newly scheduled start date. In the (rare) case of an event that has been postponed and rescheduled multiple times, this field may be repeated.</para>
    /// labels<para>previousStartDate</para></remarks>
    /// <seealso href="http://schema.org/previousStartDate">http://schema.org/previousStartDate</seealso>
    let previousStartDate = Prefixed_Name(schema1, "previousStartDate") |> PrefixedName
    /// <summary>
    ///   <para>schema1:price</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The offer price of a product, or of a price component when attached to PriceSpecification and its subtypes.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Usage guidelines:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;Use the &lt;a class="localLink" href="http://schema.org/priceCurrency"&gt;priceCurrency&lt;/a&gt; property (with standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR") instead of including &lt;a href="http://en.wikipedia.org/wiki/Dollar_sign#Currencies_that_use_the_dollar_or_peso_sign"&gt;ambiguous symbols&lt;/a&gt; such as '$' in the value.&lt;/li&gt;
    /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
    /// &lt;li&gt;Note that both &lt;a href="http://www.w3.org/TR/xhtml-rdfa-primer/#using-the-content-attribute"&gt;RDFa&lt;/a&gt; and Microdata syntax allow the use of a "content=" attribute for publishing simple machine-readable values alongside more human-friendly formatting.&lt;/li&gt;
    /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>price</para></remarks>
    /// <seealso href="http://schema.org/price">http://schema.org/price</seealso>
    let price = Prefixed_Name(schema1, "price") |> PrefixedName
    /// <summary>
    ///   <para>schema1:priceComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property links to all &lt;a class="localLink" href="http://schema.org/UnitPriceSpecification"&gt;UnitPriceSpecification&lt;/a&gt; nodes that apply in parallel for the &lt;a class="localLink" href="http://schema.org/CompoundPriceSpecification"&gt;CompoundPriceSpecification&lt;/a&gt; node.</para>
    /// labels<para>priceComponent</para></remarks>
    /// <seealso href="http://schema.org/priceComponent">http://schema.org/priceComponent</seealso>
    let priceComponent = Prefixed_Name(schema1, "priceComponent") |> PrefixedName
    /// <summary>
    ///   <para>schema1:priceCurrency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The currency of the price, or a price component when attached to &lt;a class="localLink" href="http://schema.org/PriceSpecification"&gt;PriceSpecification&lt;/a&gt; and its subtypes.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".</para>
    /// labels<para>priceCurrency</para></remarks>
    /// <seealso href="http://schema.org/priceCurrency">http://schema.org/priceCurrency</seealso>
    let priceCurrency = Prefixed_Name(schema1, "priceCurrency") |> PrefixedName
    /// <summary>
    ///   <para>schema1:priceRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The price range of the business, for example &lt;code&gt;$$$&lt;/code&gt;.</para>
    /// labels<para>priceRange</para></remarks>
    /// <seealso href="http://schema.org/priceRange">http://schema.org/priceRange</seealso>
    let priceRange = Prefixed_Name(schema1, "priceRange") |> PrefixedName

    /// <summary>
    ///   <para>schema1:priceSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>One or more detailed price specifications, indicating the unit price and delivery or payment charges.</para>
    /// labels<para>priceSpecification</para></remarks>
    /// <seealso href="http://schema.org/priceSpecification">http://schema.org/priceSpecification</seealso>
    let priceSpecification =
        Prefixed_Name(schema1, "priceSpecification") |> PrefixedName

    /// <summary>
    ///   <para>schema1:priceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A short text or acronym indicating multiple price specifications for the same offer, e.g. SRP for the suggested retail price or INVOICE for the invoice price, mostly used in the car industry.</para>
    /// labels<para>priceType</para></remarks>
    /// <seealso href="http://schema.org/priceType">http://schema.org/priceType</seealso>
    let priceType = Prefixed_Name(schema1, "priceType") |> PrefixedName
    /// <summary>
    ///   <para>schema1:priceValidUntil</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The date after which the price is no longer available.</para>
    /// labels<para>priceValidUntil</para></remarks>
    /// <seealso href="http://schema.org/priceValidUntil">http://schema.org/priceValidUntil</seealso>
    let priceValidUntil = Prefixed_Name(schema1, "priceValidUntil") |> PrefixedName

    /// <summary>
    ///   <para>schema1:primaryImageOfPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the main image on the page.</para>
    /// labels<para>primaryImageOfPage</para></remarks>
    /// <seealso href="http://schema.org/primaryImageOfPage">http://schema.org/primaryImageOfPage</seealso>
    let primaryImageOfPage =
        Prefixed_Name(schema1, "primaryImageOfPage") |> PrefixedName

    /// <summary>
    ///   <para>schema1:valueMaxLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies the allowed range for number of characters in a literal value.</para>
    /// labels<para>valueMaxLength</para></remarks>
    /// <seealso href="http://schema.org/valueMaxLength">http://schema.org/valueMaxLength</seealso>
    let valueMaxLength = Prefixed_Name(schema1, "valueMaxLength") |> PrefixedName
    /// <summary>
    ///   <para>schema1:valueMinLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies the minimum allowed range for number of characters in a literal value.</para>
    /// labels<para>valueMinLength</para></remarks>
    /// <seealso href="http://schema.org/valueMinLength">http://schema.org/valueMinLength</seealso>
    let valueMinLength = Prefixed_Name(schema1, "valueMinLength") |> PrefixedName
    /// <summary>
    ///   <para>schema1:valueName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the name of the PropertyValueSpecification to be used in URL templates and form encoding in a manner analogous to HTML's input@name.</para>
    /// labels<para>valueName</para></remarks>
    /// <seealso href="http://schema.org/valueName">http://schema.org/valueName</seealso>
    let valueName = Prefixed_Name(schema1, "valueName") |> PrefixedName
    /// <summary>
    ///   <para>schema1:valuePattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies a regular expression for testing literal values according to the HTML spec.</para>
    /// labels<para>valuePattern</para></remarks>
    /// <seealso href="http://schema.org/valuePattern">http://schema.org/valuePattern</seealso>
    let valuePattern = Prefixed_Name(schema1, "valuePattern") |> PrefixedName
    /// <summary>
    ///   <para>schema1:valueReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A pointer to a secondary value that provides additional information on the original value, e.g. a reference temperature.</para>
    /// labels<para>valueReference</para></remarks>
    /// <seealso href="http://schema.org/valueReference">http://schema.org/valueReference</seealso>
    let valueReference = Prefixed_Name(schema1, "valueReference") |> PrefixedName
    /// <summary>
    ///   <para>schema1:valueRequired</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether the property must be filled in to complete the action.  Default is false.</para>
    /// labels<para>valueRequired</para></remarks>
    /// <seealso href="http://schema.org/valueRequired">http://schema.org/valueRequired</seealso>
    let valueRequired = Prefixed_Name(schema1, "valueRequired") |> PrefixedName
    /// <summary>
    ///   <para>schema1:vatID</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Value-added Tax ID of the organization or person.</para>
    /// labels<para>vatID</para></remarks>
    /// <seealso href="http://schema.org/vatID">http://schema.org/vatID</seealso>
    let vatID = Prefixed_Name(schema1, "vatID") |> PrefixedName

    /// <summary>
    ///   <para>schema1:vehicleConfiguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A short text indicating the configuration of the vehicle, e.g. '5dr hatchback ST 2.5 MT 225 hp' or 'limited edition'.</para>
    /// labels<para>vehicleConfiguration</para></remarks>
    /// <seealso href="http://schema.org/vehicleConfiguration">http://schema.org/vehicleConfiguration</seealso>
    let vehicleConfiguration =
        Prefixed_Name(schema1, "vehicleConfiguration") |> PrefixedName

    /// <summary>
    ///   <para>schema1:vehicleEngine</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Information about the engine or engines of the vehicle.</para>
    /// labels<para>vehicleEngine</para></remarks>
    /// <seealso href="http://schema.org/vehicleEngine">http://schema.org/vehicleEngine</seealso>
    let vehicleEngine = Prefixed_Name(schema1, "vehicleEngine") |> PrefixedName

    /// <summary>
    ///   <para>schema1:vehicleIdentificationNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Vehicle Identification Number (VIN) is a unique serial number used by the automotive industry to identify individual motor vehicles.</para>
    /// labels<para>vehicleIdentificationNumber</para></remarks>
    /// <seealso href="http://schema.org/vehicleIdentificationNumber">http://schema.org/vehicleIdentificationNumber</seealso>
    let vehicleIdentificationNumber =
        Prefixed_Name(schema1, "vehicleIdentificationNumber") |> PrefixedName

    /// <summary>
    ///   <para>schema1:vehicleInteriorColor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The color or color combination of the interior of the vehicle.</para>
    /// labels<para>vehicleInteriorColor</para></remarks>
    /// <seealso href="http://schema.org/vehicleInteriorColor">http://schema.org/vehicleInteriorColor</seealso>
    let vehicleInteriorColor =
        Prefixed_Name(schema1, "vehicleInteriorColor") |> PrefixedName

    /// <summary>
    ///   <para>schema1:vehicleInteriorType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The type or material of the interior of the vehicle (e.g. synthetic fabric, leather, wood, etc.). While most interior types are characterized by the material used, an interior type can also be based on vehicle usage or target audience.</para>
    /// labels<para>vehicleInteriorType</para></remarks>
    /// <seealso href="http://schema.org/vehicleInteriorType">http://schema.org/vehicleInteriorType</seealso>
    let vehicleInteriorType =
        Prefixed_Name(schema1, "vehicleInteriorType") |> PrefixedName

    /// <summary>
    ///   <para>schema1:vehicleModelDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The release date of a vehicle model (often used to differentiate versions of the same make and model).</para>
    /// labels<para>vehicleModelDate</para></remarks>
    /// <seealso href="http://schema.org/vehicleModelDate">http://schema.org/vehicleModelDate</seealso>
    let vehicleModelDate = Prefixed_Name(schema1, "vehicleModelDate") |> PrefixedName

    /// <summary>
    ///   <para>schema1:vehicleSeatingCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of passengers that can be seated in the vehicle, both in terms of the physical space available, and in terms of limitations set by law.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Typical unit code(s): C62 for persons.</para>
    /// labels<para>vehicleSeatingCapacity</para></remarks>
    /// <seealso href="http://schema.org/vehicleSeatingCapacity">http://schema.org/vehicleSeatingCapacity</seealso>
    let vehicleSeatingCapacity =
        Prefixed_Name(schema1, "vehicleSeatingCapacity") |> PrefixedName

    /// <summary>
    ///   <para>schema1:vehicleTransmission</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The type of component used for transmitting the power from a rotating power source to the wheels or other relevant component(s) ("gearbox" for cars).</para>
    /// labels<para>vehicleTransmission</para></remarks>
    /// <seealso href="http://schema.org/vehicleTransmission">http://schema.org/vehicleTransmission</seealso>
    let vehicleTransmission =
        Prefixed_Name(schema1, "vehicleTransmission") |> PrefixedName

    /// <summary>
    ///   <para>schema1:vendor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>'vendor' is an earlier term for 'seller'.</para>
    /// labels<para>vendor</para></remarks>
    /// <seealso href="http://schema.org/vendor">http://schema.org/vendor</seealso>
    let vendor = Prefixed_Name(schema1, "vendor") |> PrefixedName
    /// <summary>
    ///   <para>schema1:version</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The version of the CreativeWork embodied by a specified resource.</para>
    /// labels<para>version</para></remarks>
    /// <seealso href="http://schema.org/version">http://schema.org/version</seealso>
    let version = Prefixed_Name(schema1, "version") |> PrefixedName
    /// <summary>
    ///   <para>schema1:video</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An embedded video object.</para>
    /// labels<para>video</para></remarks>
    /// <seealso href="http://schema.org/video">http://schema.org/video</seealso>
    let video = Prefixed_Name(schema1, "video") |> PrefixedName
    /// <summary>
    ///   <para>schema1:videoFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The type of screening or video broadcast used (e.g. IMAX, 3D, SD, HD, etc.).</para>
    /// labels<para>videoFormat</para></remarks>
    /// <seealso href="http://schema.org/videoFormat">http://schema.org/videoFormat</seealso>
    let videoFormat = Prefixed_Name(schema1, "videoFormat") |> PrefixedName
    /// <summary>
    ///   <para>schema1:videoFrameSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The frame size of the video.</para>
    /// labels<para>videoFrameSize</para></remarks>
    /// <seealso href="http://schema.org/videoFrameSize">http://schema.org/videoFrameSize</seealso>
    let videoFrameSize = Prefixed_Name(schema1, "videoFrameSize") |> PrefixedName
    /// <summary>
    ///   <para>schema1:videoQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The quality of the video.</para>
    /// labels<para>videoQuality</para></remarks>
    /// <seealso href="http://schema.org/videoQuality">http://schema.org/videoQuality</seealso>
    let videoQuality = Prefixed_Name(schema1, "videoQuality") |> PrefixedName
    /// <summary>
    ///   <para>schema1:wordCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of words in the text of the Article.</para>
    /// labels<para>wordCount</para></remarks>
    /// <seealso href="http://schema.org/wordCount">http://schema.org/wordCount</seealso>
    let wordCount = Prefixed_Name(schema1, "wordCount") |> PrefixedName
    /// <summary>
    ///   <para>schema1:workFeatured</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A work featured in some event, e.g. exhibited in an ExhibitionEvent.
    ///        Specific subproperties are available for workPerformed (e.g. a play), or a workPresented (a Movie at a ScreeningEvent).</para>
    /// labels<para>workFeatured</para></remarks>
    /// <seealso href="http://schema.org/workFeatured">http://schema.org/workFeatured</seealso>
    let workFeatured = Prefixed_Name(schema1, "workFeatured") |> PrefixedName
    /// <summary>
    ///   <para>schema1:workHours</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The typical working hours for this job (e.g. 1st shift, night shift, 8am-5pm).</para>
    /// labels<para>workHours</para></remarks>
    /// <seealso href="http://schema.org/workHours">http://schema.org/workHours</seealso>
    let workHours = Prefixed_Name(schema1, "workHours") |> PrefixedName
    /// <summary>
    ///   <para>schema1:workLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A contact location for a person's place of work.</para>
    /// labels<para>workLocation</para></remarks>
    /// <seealso href="http://schema.org/workLocation">http://schema.org/workLocation</seealso>
    let workLocation = Prefixed_Name(schema1, "workLocation") |> PrefixedName
    /// <summary>
    ///   <para>schema1:workPerformed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A work performed in some event, for example a play performed in a TheaterEvent.</para>
    /// labels<para>workPerformed</para></remarks>
    /// <seealso href="http://schema.org/workPerformed">http://schema.org/workPerformed</seealso>
    let workPerformed = Prefixed_Name(schema1, "workPerformed") |> PrefixedName
    /// <summary>
    ///   <para>schema1:workPresented</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The movie presented during this event.</para>
    /// labels<para>workPresented</para></remarks>
    /// <seealso href="http://schema.org/workPresented">http://schema.org/workPresented</seealso>
    let workPresented = Prefixed_Name(schema1, "workPresented") |> PrefixedName
    /// <summary>
    ///   <para>schema1:worksFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Organizations that the person works for.</para>
    /// labels<para>worksFor</para></remarks>
    /// <seealso href="http://schema.org/worksFor">http://schema.org/worksFor</seealso>
    let worksFor = Prefixed_Name(schema1, "worksFor") |> PrefixedName
    /// <summary>
    ///   <para>schema1:worstRating</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The lowest value allowed in this rating system. If worstRating is omitted, 1 is assumed.</para>
    /// labels<para>worstRating</para></remarks>
    /// <seealso href="http://schema.org/worstRating">http://schema.org/worstRating</seealso>
    let worstRating = Prefixed_Name(schema1, "worstRating") |> PrefixedName
    /// <summary>
    ///   <para>schema1:xpath</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An XPath, e.g. of a &lt;a class="localLink" href="http://schema.org/SpeakableSpecification"&gt;SpeakableSpecification&lt;/a&gt; or &lt;a class="localLink" href="http://schema.org/WebPageElement"&gt;WebPageElement&lt;/a&gt;. In the latter case, multiple matches within a page can constitute a single conceptual "Web page element".</para>
    /// labels<para>xpath</para></remarks>
    /// <seealso href="http://schema.org/xpath">http://schema.org/xpath</seealso>
    let xpath = Prefixed_Name(schema1, "xpath") |> PrefixedName
    /// <summary>
    ///   <para>schema1:XPathType</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schema.org/XPathType">http://schema.org/XPathType</seealso>
    let XPathType = Prefixed_Name(schema1, "XPathType") |> PrefixedName
    /// <summary>
    ///   <para>schema1:yearlyRevenue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The size of the business in annual revenue.</para>
    /// labels<para>yearlyRevenue</para></remarks>
    /// <seealso href="http://schema.org/yearlyRevenue">http://schema.org/yearlyRevenue</seealso>
    let yearlyRevenue = Prefixed_Name(schema1, "yearlyRevenue") |> PrefixedName
    /// <summary>
    ///   <para>schema1:yearsInOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The age of the business.</para>
    /// labels<para>yearsInOperation</para></remarks>
    /// <seealso href="http://schema.org/yearsInOperation">http://schema.org/yearsInOperation</seealso>
    let yearsInOperation = Prefixed_Name(schema1, "yearsInOperation") |> PrefixedName
    /// <summary>
    ///   <para>schema1:category</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.</para>
    /// labels<para>category</para></remarks>
    /// <seealso href="http://schema.org/category">http://schema.org/category</seealso>
    let category = Prefixed_Name(schema1, "category") |> PrefixedName

    /// <summary>
    ///   <para>schema1:ActiveActionStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:ActionStatusType</para>
    ///   <para>An in-progress action (e.g, while watching the movie, or driving to a location).</para>
    /// labels<para>ActiveActionStatus</para></remarks>
    /// <seealso href="http://schema.org/ActiveActionStatus">http://schema.org/ActiveActionStatus</seealso>
    let ActiveActionStatus =
        Prefixed_Name(schema1, "ActiveActionStatus") |> PrefixedName

    /// <summary>
    ///   <para>schema1:AddAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of editing by adding an object to a collection.</para>
    /// labels<para>AddAction</para></remarks>
    /// <seealso href="http://schema.org/AddAction">http://schema.org/AddAction</seealso>
    let AddAction = Prefixed_Name(schema1, "AddAction") |> PrefixedName

    /// <summary>
    ///   <para>schema1:EntertainmentBusiness</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A business providing entertainment.</para>
    /// labels<para>EntertainmentBusiness</para></remarks>
    /// <seealso href="http://schema.org/EntertainmentBusiness">http://schema.org/EntertainmentBusiness</seealso>
    let EntertainmentBusiness =
        Prefixed_Name(schema1, "EntertainmentBusiness") |> PrefixedName

    /// <summary>
    ///   <para>schema1:Offer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An offer to transfer some rights to an item or to provide a service — for example, an offer to sell tickets to an event, to rent the DVD of a movie, to stream a TV show over the internet, to repair a motorcycle, or to loan a book.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: As the &lt;a class="localLink" href="http://schema.org/businessFunction"&gt;businessFunction&lt;/a&gt; property, which identifies the form of offer (e.g. sell, lease, repair, dispose), defaults to http://purl.org/goodrelations/v1#Sell; an Offer without a defined businessFunction value can be assumed to be an offer to sell.&lt;br/&gt;&lt;br/&gt;
    ///
    /// For &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GTIN&lt;/a&gt;-related fields, see &lt;a href="http://www.gs1.org/barcodes/support/check_digit_calculator"&gt;Check Digit calculator&lt;/a&gt; and &lt;a href="http://www.gs1us.org/resources/standards/gtin-validation-guide"&gt;validation guide&lt;/a&gt; from &lt;a href="http://www.gs1.org/"&gt;GS1&lt;/a&gt;.</para>
    /// labels<para>Offer</para></remarks>
    /// <seealso href="http://schema.org/Offer">http://schema.org/Offer</seealso>
    let Offer = Prefixed_Name(schema1, "Offer") |> PrefixedName
    /// <summary>
    ///   <para>schema1:AggregateRating</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The average rating based on multiple ratings or reviews.</para>
    /// labels<para>AggregateRating</para></remarks>
    /// <seealso href="http://schema.org/AggregateRating">http://schema.org/AggregateRating</seealso>
    let AggregateRating = Prefixed_Name(schema1, "AggregateRating") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ReactAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of responding instinctively and emotionally to an object, expressing a sentiment.</para>
    /// labels<para>ReactAction</para></remarks>
    /// <seealso href="http://schema.org/ReactAction">http://schema.org/ReactAction</seealso>
    let ReactAction = Prefixed_Name(schema1, "ReactAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Airline</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An organization that provides flights for passengers.</para>
    /// labels<para>Airline</para></remarks>
    /// <seealso href="http://schema.org/Airline">http://schema.org/Airline</seealso>
    let Airline = Prefixed_Name(schema1, "Airline") |> PrefixedName

    /// <summary>
    ///   <para>schema1:MusicAlbumReleaseType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The kind of release which this album is: single, EP or album.</para>
    /// labels<para>MusicAlbumReleaseType</para></remarks>
    /// <seealso href="http://schema.org/MusicAlbumReleaseType">http://schema.org/MusicAlbumReleaseType</seealso>
    let MusicAlbumReleaseType =
        Prefixed_Name(schema1, "MusicAlbumReleaseType") |> PrefixedName

    /// <summary>
    ///   <para>schema1:DriveWheelConfigurationValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A value indicating which roadwheels will receive torque.</para>
    /// labels<para>DriveWheelConfigurationValue</para></remarks>
    /// <seealso href="http://schema.org/DriveWheelConfigurationValue">http://schema.org/DriveWheelConfigurationValue</seealso>
    let DriveWheelConfigurationValue =
        Prefixed_Name(schema1, "DriveWheelConfigurationValue") |> PrefixedName

    /// <summary>
    ///   <para>schema1:TieAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of reaching a draw in a competitive activity.</para>
    /// labels<para>TieAction</para></remarks>
    /// <seealso href="http://schema.org/TieAction">http://schema.org/TieAction</seealso>
    let TieAction = Prefixed_Name(schema1, "TieAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:TollFree</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:ContactPointOption</para>
    ///   <para>The associated telephone number is toll free.</para>
    /// labels<para>TollFree</para></remarks>
    /// <seealso href="http://schema.org/TollFree">http://schema.org/TollFree</seealso>
    let TollFree = Prefixed_Name(schema1, "TollFree") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ToyStore</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A toy store.</para>
    /// labels<para>ToyStore</para></remarks>
    /// <seealso href="http://schema.org/ToyStore">http://schema.org/ToyStore</seealso>
    let ToyStore = Prefixed_Name(schema1, "ToyStore") |> PrefixedName
    /// <summary>
    ///   <para>schema1:availableFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>When the item is available for pickup from the store, locker, etc.</para>
    /// labels<para>availableFrom</para></remarks>
    /// <seealso href="http://schema.org/availableFrom">http://schema.org/availableFrom</seealso>
    let availableFrom = Prefixed_Name(schema1, "availableFrom") |> PrefixedName
    /// <summary>
    ///   <para>schema1:availableOnDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Device required to run the application. Used in cases where a specific make/model is required to run the application.</para>
    /// labels<para>availableOnDevice</para></remarks>
    /// <seealso href="http://schema.org/availableOnDevice">http://schema.org/availableOnDevice</seealso>
    let availableOnDevice = Prefixed_Name(schema1, "availableOnDevice") |> PrefixedName
    /// <summary>
    ///   <para>schema1:availableThrough</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>After this date, the item will no longer be available for pickup.</para>
    /// labels<para>availableThrough</para></remarks>
    /// <seealso href="http://schema.org/availableThrough">http://schema.org/availableThrough</seealso>
    let availableThrough = Prefixed_Name(schema1, "availableThrough") |> PrefixedName
    /// <summary>
    ///   <para>schema1:awards</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Awards won by or for this item.</para>
    /// labels<para>awards</para></remarks>
    /// <seealso href="http://schema.org/awards">http://schema.org/awards</seealso>
    let awards = Prefixed_Name(schema1, "awards") |> PrefixedName
    /// <summary>
    ///   <para>schema1:baseSalary</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The base salary of the job or of an employee in an EmployeeRole.</para>
    /// labels<para>baseSalary</para></remarks>
    /// <seealso href="http://schema.org/baseSalary">http://schema.org/baseSalary</seealso>
    let baseSalary = Prefixed_Name(schema1, "baseSalary") |> PrefixedName
    /// <summary>
    ///   <para>schema1:bccRecipient</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of recipient. The recipient blind copied on a message.</para>
    /// labels<para>bccRecipient</para></remarks>
    /// <seealso href="http://schema.org/bccRecipient">http://schema.org/bccRecipient</seealso>
    let bccRecipient = Prefixed_Name(schema1, "bccRecipient") |> PrefixedName
    /// <summary>
    ///   <para>schema1:beforeMedia</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A media object representing the circumstances before performing this direction.</para>
    /// labels<para>beforeMedia</para></remarks>
    /// <seealso href="http://schema.org/beforeMedia">http://schema.org/beforeMedia</seealso>
    let beforeMedia = Prefixed_Name(schema1, "beforeMedia") |> PrefixedName
    /// <summary>
    ///   <para>schema1:benefits</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Description of benefits associated with the job.</para>
    /// labels<para>benefits</para></remarks>
    /// <seealso href="http://schema.org/benefits">http://schema.org/benefits</seealso>
    let benefits = Prefixed_Name(schema1, "benefits") |> PrefixedName
    /// <summary>
    ///   <para>schema1:jobBenefits</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Description of benefits associated with the job.</para>
    /// labels<para>jobBenefits</para></remarks>
    /// <seealso href="http://schema.org/jobBenefits">http://schema.org/jobBenefits</seealso>
    let jobBenefits = Prefixed_Name(schema1, "jobBenefits") |> PrefixedName
    /// <summary>
    ///   <para>schema1:bestRating</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The highest value allowed in this rating system. If bestRating is omitted, 5 is assumed.</para>
    /// labels<para>bestRating</para></remarks>
    /// <seealso href="http://schema.org/bestRating">http://schema.org/bestRating</seealso>
    let bestRating = Prefixed_Name(schema1, "bestRating") |> PrefixedName
    /// <summary>
    ///   <para>schema1:billingAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The billing address for the order.</para>
    /// labels<para>billingAddress</para></remarks>
    /// <seealso href="http://schema.org/billingAddress">http://schema.org/billingAddress</seealso>
    let billingAddress = Prefixed_Name(schema1, "billingAddress") |> PrefixedName
    /// <summary>
    ///   <para>schema1:billingIncrement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property specifies the minimal quantity and rounding increment that will be the basis for the billing. The unit of measurement is specified by the unitCode property.</para>
    /// labels<para>billingIncrement</para></remarks>
    /// <seealso href="http://schema.org/billingIncrement">http://schema.org/billingIncrement</seealso>
    let billingIncrement = Prefixed_Name(schema1, "billingIncrement") |> PrefixedName
    /// <summary>
    ///   <para>schema1:birthDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Date of birth.</para>
    /// labels<para>birthDate</para></remarks>
    /// <seealso href="http://schema.org/birthDate">http://schema.org/birthDate</seealso>
    let birthDate = Prefixed_Name(schema1, "birthDate") |> PrefixedName
    /// <summary>
    ///   <para>schema1:birthPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The place where the person was born.</para>
    /// labels<para>birthPlace</para></remarks>
    /// <seealso href="http://schema.org/birthPlace">http://schema.org/birthPlace</seealso>
    let birthPlace = Prefixed_Name(schema1, "birthPlace") |> PrefixedName
    /// <summary>
    ///   <para>schema1:bitrate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The bitrate of the media object.</para>
    /// labels<para>bitrate</para></remarks>
    /// <seealso href="http://schema.org/bitrate">http://schema.org/bitrate</seealso>
    let bitrate = Prefixed_Name(schema1, "bitrate") |> PrefixedName
    /// <summary>
    ///   <para>schema1:blogPost</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A posting that is part of this blog.</para>
    /// labels<para>blogPost</para></remarks>
    /// <seealso href="http://schema.org/blogPost">http://schema.org/blogPost</seealso>
    let blogPost = Prefixed_Name(schema1, "blogPost") |> PrefixedName
    /// <summary>
    ///   <para>schema1:blogPosts</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The postings that are part of this blog.</para>
    /// labels<para>blogPosts</para></remarks>
    /// <seealso href="http://schema.org/blogPosts">http://schema.org/blogPosts</seealso>
    let blogPosts = Prefixed_Name(schema1, "blogPosts") |> PrefixedName
    /// <summary>
    ///   <para>schema1:boardingGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The airline-specific indicator of boarding order / preference.</para>
    /// labels<para>boardingGroup</para></remarks>
    /// <seealso href="http://schema.org/boardingGroup">http://schema.org/boardingGroup</seealso>
    let boardingGroup = Prefixed_Name(schema1, "boardingGroup") |> PrefixedName
    /// <summary>
    ///   <para>schema1:boardingPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The type of boarding policy used by the airline (e.g. zone-based or group-based).</para>
    /// labels<para>boardingPolicy</para></remarks>
    /// <seealso href="http://schema.org/boardingPolicy">http://schema.org/boardingPolicy</seealso>
    let boardingPolicy = Prefixed_Name(schema1, "boardingPolicy") |> PrefixedName
    /// <summary>
    ///   <para>schema1:bookEdition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The edition of the book.</para>
    /// labels<para>bookEdition</para></remarks>
    /// <seealso href="http://schema.org/bookEdition">http://schema.org/bookEdition</seealso>
    let bookEdition = Prefixed_Name(schema1, "bookEdition") |> PrefixedName
    /// <summary>
    ///   <para>schema1:bookFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The format of the book.</para>
    /// labels<para>bookFormat</para></remarks>
    /// <seealso href="http://schema.org/bookFormat">http://schema.org/bookFormat</seealso>
    let bookFormat = Prefixed_Name(schema1, "bookFormat") |> PrefixedName
    /// <summary>
    ///   <para>schema1:broker</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An entity that arranges for an exchange between a buyer and a seller.  In most cases a broker never acquires or releases ownership of a product or service involved in an exchange.  If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred.</para>
    /// labels<para>broker</para></remarks>
    /// <seealso href="http://schema.org/broker">http://schema.org/broker</seealso>
    let broker = Prefixed_Name(schema1, "broker") |> PrefixedName
    /// <summary>
    ///   <para>schema1:bookingTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The date and time the reservation was booked.</para>
    /// labels<para>bookingTime</para></remarks>
    /// <seealso href="http://schema.org/bookingTime">http://schema.org/bookingTime</seealso>
    let bookingTime = Prefixed_Name(schema1, "bookingTime") |> PrefixedName
    /// <summary>
    ///   <para>schema1:borrower</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of participant. The person that borrows the object being lent.</para>
    /// labels<para>borrower</para></remarks>
    /// <seealso href="http://schema.org/borrower">http://schema.org/borrower</seealso>
    let borrower = Prefixed_Name(schema1, "borrower") |> PrefixedName
    /// <summary>
    ///   <para>schema1:participant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Other co-agents that participated in the action indirectly. e.g. John wrote a book with &lt;em&gt;Steve&lt;/em&gt;.</para>
    /// labels<para>participant</para></remarks>
    /// <seealso href="http://schema.org/participant">http://schema.org/participant</seealso>
    let participant = Prefixed_Name(schema1, "participant") |> PrefixedName
    /// <summary>
    ///   <para>schema1:box</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A box is the area enclosed by the rectangle formed by two points. The first point is the lower corner, the second point is the upper corner. A box is expressed as two points separated by a space character.</para>
    /// labels<para>box</para></remarks>
    /// <seealso href="http://schema.org/box">http://schema.org/box</seealso>
    let box = Prefixed_Name(schema1, "box") |> PrefixedName
    /// <summary>
    ///   <para>schema1:branchCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A short textual code (also called "store code") that uniquely identifies a place of business. The code is typically assigned by the parentOrganization and used in structured URLs.&lt;br/&gt;&lt;br/&gt;
    ///
    /// For example, in the URL http://www.starbucks.co.uk/store-locator/etc/detail/3047 the code "3047" is a branchCode for a particular branch.</para>
    /// labels<para>branchCode</para></remarks>
    /// <seealso href="http://schema.org/branchCode">http://schema.org/branchCode</seealso>
    let branchCode = Prefixed_Name(schema1, "branchCode") |> PrefixedName
    /// <summary>
    ///   <para>schema1:branchOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The larger organization that this local business is a branch of, if any. Not to be confused with (anatomical)&lt;a class="localLink" href="http://schema.org/branch"&gt;branch&lt;/a&gt;.</para>
    /// labels<para>branchOf</para></remarks>
    /// <seealso href="http://schema.org/branchOf">http://schema.org/branchOf</seealso>
    let branchOf = Prefixed_Name(schema1, "branchOf") |> PrefixedName
    /// <summary>
    ///   <para>schema1:brand</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.</para>
    /// labels<para>brand</para></remarks>
    /// <seealso href="http://schema.org/brand">http://schema.org/brand</seealso>
    let brand = Prefixed_Name(schema1, "brand") |> PrefixedName
    /// <summary>
    ///   <para>schema1:breadcrumb</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A set of links that can help a user understand and navigate a website hierarchy.</para>
    /// labels<para>breadcrumb</para></remarks>
    /// <seealso href="http://schema.org/breadcrumb">http://schema.org/breadcrumb</seealso>
    let breadcrumb = Prefixed_Name(schema1, "breadcrumb") |> PrefixedName

    /// <summary>
    ///   <para>schema1:broadcastAffiliateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The media network(s) whose content is broadcast on this station.</para>
    /// labels<para>broadcastAffiliateOf</para></remarks>
    /// <seealso href="http://schema.org/broadcastAffiliateOf">http://schema.org/broadcastAffiliateOf</seealso>
    let broadcastAffiliateOf =
        Prefixed_Name(schema1, "broadcastAffiliateOf") |> PrefixedName

    /// <summary>
    ///   <para>schema1:expectedArrivalFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The earliest date the package may arrive.</para>
    /// labels<para>expectedArrivalFrom</para></remarks>
    /// <seealso href="http://schema.org/expectedArrivalFrom">http://schema.org/expectedArrivalFrom</seealso>
    let expectedArrivalFrom =
        Prefixed_Name(schema1, "expectedArrivalFrom") |> PrefixedName

    /// <summary>
    ///   <para>schema1:expectedArrivalUntil</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The latest date the package may arrive.</para>
    /// labels<para>expectedArrivalUntil</para></remarks>
    /// <seealso href="http://schema.org/expectedArrivalUntil">http://schema.org/expectedArrivalUntil</seealso>
    let expectedArrivalUntil =
        Prefixed_Name(schema1, "expectedArrivalUntil") |> PrefixedName

    /// <summary>
    ///   <para>schema1:expectsAcceptanceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An Offer which must be accepted before the user can perform the Action. For example, the user may need to buy a movie before being able to watch it.</para>
    /// labels<para>expectsAcceptanceOf</para></remarks>
    /// <seealso href="http://schema.org/expectsAcceptanceOf">http://schema.org/expectsAcceptanceOf</seealso>
    let expectsAcceptanceOf =
        Prefixed_Name(schema1, "expectsAcceptanceOf") |> PrefixedName

    /// <summary>
    ///   <para>schema1:experienceRequirements</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Description of skills and experience needed for the position or Occupation.</para>
    /// labels<para>experienceRequirements</para></remarks>
    /// <seealso href="http://schema.org/experienceRequirements">http://schema.org/experienceRequirements</seealso>
    let experienceRequirements =
        Prefixed_Name(schema1, "experienceRequirements") |> PrefixedName

    /// <summary>
    ///   <para>schema1:expires</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Date the content expires and is no longer useful or available. For example a &lt;a class="localLink" href="http://schema.org/VideoObject"&gt;VideoObject&lt;/a&gt; or &lt;a class="localLink" href="http://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt; whose availability or relevance is time-limited, or a &lt;a class="localLink" href="http://schema.org/ClaimReview"&gt;ClaimReview&lt;/a&gt; fact check whose publisher wants to indicate that it may no longer be relevant (or helpful to highlight) after some date.</para>
    /// labels<para>expires</para></remarks>
    /// <seealso href="http://schema.org/expires">http://schema.org/expires</seealso>
    let expires = Prefixed_Name(schema1, "expires") |> PrefixedName
    /// <summary>
    ///   <para>schema1:fatContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of grams of fat.</para>
    /// labels<para>fatContent</para></remarks>
    /// <seealso href="http://schema.org/fatContent">http://schema.org/fatContent</seealso>
    let fatContent = Prefixed_Name(schema1, "fatContent") |> PrefixedName
    /// <summary>
    ///   <para>schema1:faxNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The fax number.</para>
    /// labels<para>faxNumber</para></remarks>
    /// <seealso href="http://schema.org/faxNumber">http://schema.org/faxNumber</seealso>
    let faxNumber = Prefixed_Name(schema1, "faxNumber") |> PrefixedName
    /// <summary>
    ///   <para>schema1:featureList</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Features or modules provided by this application (and possibly required by other applications).</para>
    /// labels<para>featureList</para></remarks>
    /// <seealso href="http://schema.org/featureList">http://schema.org/featureList</seealso>
    let featureList = Prefixed_Name(schema1, "featureList") |> PrefixedName

    /// <summary>
    ///   <para>schema1:feesAndCommissionsSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Description of fees, commissions, and other terms applied either to a class of financial product, or by a financial service organization.</para>
    /// labels<para>feesAndCommissionsSpecification</para></remarks>
    /// <seealso href="http://schema.org/feesAndCommissionsSpecification">http://schema.org/feesAndCommissionsSpecification</seealso>
    let feesAndCommissionsSpecification =
        Prefixed_Name(schema1, "feesAndCommissionsSpecification") |> PrefixedName

    /// <summary>
    ///   <para>schema1:fiberContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of grams of fiber.</para>
    /// labels<para>fiberContent</para></remarks>
    /// <seealso href="http://schema.org/fiberContent">http://schema.org/fiberContent</seealso>
    let fiberContent = Prefixed_Name(schema1, "fiberContent") |> PrefixedName
    /// <summary>
    ///   <para>schema1:nationality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Nationality of the person.</para>
    /// labels<para>nationality</para></remarks>
    /// <seealso href="http://schema.org/nationality">http://schema.org/nationality</seealso>
    let nationality = Prefixed_Name(schema1, "nationality") |> PrefixedName
    /// <summary>
    ///   <para>schema1:netWorth</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The total financial value of the person as calculated by subtracting assets from liabilities.</para>
    /// labels<para>netWorth</para></remarks>
    /// <seealso href="http://schema.org/netWorth">http://schema.org/netWorth</seealso>
    let netWorth = Prefixed_Name(schema1, "netWorth") |> PrefixedName
    /// <summary>
    ///   <para>schema1:nextItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A link to the ListItem that follows the current one.</para>
    /// labels<para>nextItem</para></remarks>
    /// <seealso href="http://schema.org/nextItem">http://schema.org/nextItem</seealso>
    let nextItem = Prefixed_Name(schema1, "nextItem") |> PrefixedName
    /// <summary>
    ///   <para>schema1:nonEqual</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This ordering relation for qualitative values indicates that the subject is not equal to the object.</para>
    /// labels<para>nonEqual</para></remarks>
    /// <seealso href="http://schema.org/nonEqual">http://schema.org/nonEqual</seealso>
    let nonEqual = Prefixed_Name(schema1, "nonEqual") |> PrefixedName
    /// <summary>
    ///   <para>schema1:numAdults</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of adults staying in the unit.</para>
    /// labels<para>numAdults</para></remarks>
    /// <seealso href="http://schema.org/numAdults">http://schema.org/numAdults</seealso>
    let numAdults = Prefixed_Name(schema1, "numAdults") |> PrefixedName
    /// <summary>
    ///   <para>schema1:successorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A pointer from a newer variant of a product  to its previous, often discontinued predecessor.</para>
    /// labels<para>successorOf</para></remarks>
    /// <seealso href="http://schema.org/successorOf">http://schema.org/successorOf</seealso>
    let successorOf = Prefixed_Name(schema1, "successorOf") |> PrefixedName
    /// <summary>
    ///   <para>schema1:sugarContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of grams of sugar.</para>
    /// labels<para>sugarContent</para></remarks>
    /// <seealso href="http://schema.org/sugarContent">http://schema.org/sugarContent</seealso>
    let sugarContent = Prefixed_Name(schema1, "sugarContent") |> PrefixedName
    /// <summary>
    ///   <para>schema1:suggestedGender</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The gender of the person or audience.</para>
    /// labels<para>suggestedGender</para></remarks>
    /// <seealso href="http://schema.org/suggestedGender">http://schema.org/suggestedGender</seealso>
    let suggestedGender = Prefixed_Name(schema1, "suggestedGender") |> PrefixedName
    /// <summary>
    ///   <para>schema1:suggestedMaxAge</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Maximal age recommended for viewing content.</para>
    /// labels<para>suggestedMaxAge</para></remarks>
    /// <seealso href="http://schema.org/suggestedMaxAge">http://schema.org/suggestedMaxAge</seealso>
    let suggestedMaxAge = Prefixed_Name(schema1, "suggestedMaxAge") |> PrefixedName
    /// <summary>
    ///   <para>schema1:suggestedMinAge</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Minimal age recommended for viewing content.</para>
    /// labels<para>suggestedMinAge</para></remarks>
    /// <seealso href="http://schema.org/suggestedMinAge">http://schema.org/suggestedMinAge</seealso>
    let suggestedMinAge = Prefixed_Name(schema1, "suggestedMinAge") |> PrefixedName
    /// <summary>
    ///   <para>schema1:TechArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A technical article - Example: How-to (task) topics, step-by-step, procedural troubleshooting, specifications, etc.</para>
    /// labels<para>TechArticle</para></remarks>
    /// <seealso href="http://schema.org/TechArticle">http://schema.org/TechArticle</seealso>
    let TechArticle = Prefixed_Name(schema1, "TechArticle") |> PrefixedName
    /// <summary>
    ///   <para>schema1:WebPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A web page. Every web page is implicitly assumed to be declared to be of type WebPage, so the various properties about that webpage, such as &lt;code&gt;breadcrumb&lt;/code&gt; may be used. We recommend explicit declaration if these properties are specified, but if they are found outside of an itemscope, they will be assumed to be about the page.</para>
    /// labels<para>WebPage</para></remarks>
    /// <seealso href="http://schema.org/WebPage">http://schema.org/WebPage</seealso>
    let WebPage = Prefixed_Name(schema1, "WebPage") |> PrefixedName
    /// <summary>
    ///   <para>schema1:BlogPosting</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A blog post.</para>
    /// labels<para>BlogPosting</para></remarks>
    /// <seealso href="http://schema.org/BlogPosting">http://schema.org/BlogPosting</seealso>
    let BlogPosting = Prefixed_Name(schema1, "BlogPosting") |> PrefixedName
    /// <summary>
    ///   <para>schema1:BodyOfWater</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A body of water, such as a sea, ocean, or lake.</para>
    /// labels<para>BodyOfWater</para></remarks>
    /// <seealso href="http://schema.org/BodyOfWater">http://schema.org/BodyOfWater</seealso>
    let BodyOfWater = Prefixed_Name(schema1, "BodyOfWater") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Landform</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A landform or physical feature.  Landform elements include mountains, plains, lakes, rivers, seascape and oceanic waterbody interface features such as bays, peninsulas, seas and so forth, including sub-aqueous terrain features such as submersed mountain ranges, volcanoes, and the great ocean basins.</para>
    /// labels<para>Landform</para></remarks>
    /// <seealso href="http://schema.org/Landform">http://schema.org/Landform</seealso>
    let Landform = Prefixed_Name(schema1, "Landform") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Book</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A book.</para>
    /// labels<para>Book</para></remarks>
    /// <seealso href="http://schema.org/Book">http://schema.org/Book</seealso>
    let Book = Prefixed_Name(schema1, "Book") |> PrefixedName

    /// <summary>
    ///   <para>schema1:DiscussionForumPosting</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A posting to a discussion forum.</para>
    /// labels<para>DiscussionForumPosting</para></remarks>
    /// <seealso href="http://schema.org/DiscussionForumPosting">http://schema.org/DiscussionForumPosting</seealso>
    let DiscussionForumPosting =
        Prefixed_Name(schema1, "DiscussionForumPosting") |> PrefixedName

    /// <summary>
    ///   <para>schema1:MobileApplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A software application designed specifically to work well on a mobile device such as a telephone.</para>
    /// labels<para>MobileApplication</para></remarks>
    /// <seealso href="http://schema.org/MobileApplication">http://schema.org/MobileApplication</seealso>
    let MobileApplication = Prefixed_Name(schema1, "MobileApplication") |> PrefixedName

    /// <summary>
    ///   <para>schema1:MonetaryAmountDistribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A statistical distribution of monetary amounts.</para>
    /// labels<para>MonetaryAmountDistribution</para></remarks>
    /// <seealso href="http://schema.org/MonetaryAmountDistribution">http://schema.org/MonetaryAmountDistribution</seealso>
    let MonetaryAmountDistribution =
        Prefixed_Name(schema1, "MonetaryAmountDistribution") |> PrefixedName

    /// <summary>
    ///   <para>schema1:SeatingMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:MapCategoryType</para>
    ///   <para>A seating map.</para>
    /// labels<para>SeatingMap</para></remarks>
    /// <seealso href="http://schema.org/SeatingMap">http://schema.org/SeatingMap</seealso>
    let SeatingMap = Prefixed_Name(schema1, "SeatingMap") |> PrefixedName
    /// <summary>
    ///   <para>schema1:SendAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of physically/electronically dispatching an object for transfer from an origin to a destination.Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ReceiveAction"&gt;ReceiveAction&lt;/a&gt;: The reciprocal of SendAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/GiveAction"&gt;GiveAction&lt;/a&gt;: Unlike GiveAction, SendAction does not imply the transfer of ownership (e.g. I can send you my laptop, but I'm not necessarily giving it to you).&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>SendAction</para></remarks>
    /// <seealso href="http://schema.org/SendAction">http://schema.org/SendAction</seealso>
    let SendAction = Prefixed_Name(schema1, "SendAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ShoeStore</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A shoe store.</para>
    /// labels<para>ShoeStore</para></remarks>
    /// <seealso href="http://schema.org/ShoeStore">http://schema.org/ShoeStore</seealso>
    let ShoeStore = Prefixed_Name(schema1, "ShoeStore") |> PrefixedName
    /// <summary>
    ///   <para>schema1:SingleRelease</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:MusicAlbumReleaseType</para>
    ///   <para>SingleRelease.</para>
    /// labels<para>SingleRelease</para></remarks>
    /// <seealso href="http://schema.org/SingleRelease">http://schema.org/SingleRelease</seealso>
    let SingleRelease = Prefixed_Name(schema1, "SingleRelease") |> PrefixedName
    /// <summary>
    ///   <para>schema1:citation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A citation or reference to another creative work, such as another publication, web page, scholarly article, etc.</para>
    /// labels<para>citation</para></remarks>
    /// <seealso href="http://schema.org/citation">http://schema.org/citation</seealso>
    let citation = Prefixed_Name(schema1, "citation") |> PrefixedName
    /// <summary>
    ///   <para>schema1:fuelType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The type of fuel suitable for the engine or engines of the vehicle. If the vehicle has only one engine, this property can be attached directly to the vehicle.</para>
    /// labels<para>fuelType</para></remarks>
    /// <seealso href="http://schema.org/fuelType">http://schema.org/fuelType</seealso>
    let fuelType = Prefixed_Name(schema1, "fuelType") |> PrefixedName
    /// <summary>
    ///   <para>schema1:funder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A person or organization that supports (sponsors) something through some kind of financial contribution.</para>
    /// labels<para>funder</para></remarks>
    /// <seealso href="http://schema.org/funder">http://schema.org/funder</seealso>
    let funder = Prefixed_Name(schema1, "funder") |> PrefixedName
    /// <summary>
    ///   <para>schema1:gameItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An item is an object within the game world that can be collected by a player or, occasionally, a non-player character.</para>
    /// labels<para>gameItem</para></remarks>
    /// <seealso href="http://schema.org/gameItem">http://schema.org/gameItem</seealso>
    let gameItem = Prefixed_Name(schema1, "gameItem") |> PrefixedName
    /// <summary>
    ///   <para>schema1:nutrition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Nutrition information about the recipe or menu item.</para>
    /// labels<para>nutrition</para></remarks>
    /// <seealso href="http://schema.org/nutrition">http://schema.org/nutrition</seealso>
    let nutrition = Prefixed_Name(schema1, "nutrition") |> PrefixedName
    /// <summary>
    ///   <para>schema1:occupancy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The allowed total occupancy for the accommodation in persons (including infants etc). For individual accommodations, this is not necessarily the legal maximum but defines the permitted usage as per the contractual agreement (e.g. a double room used by a single person).
    /// Typical unit code(s): C62 for person</para>
    /// labels<para>occupancy</para></remarks>
    /// <seealso href="http://schema.org/occupancy">http://schema.org/occupancy</seealso>
    let occupancy = Prefixed_Name(schema1, "occupancy") |> PrefixedName

    /// <summary>
    ///   <para>schema1:occupationLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The region/country for which this occupational description is appropriate. Note that educational requirements and qualifications can vary between jurisdictions.</para>
    /// labels<para>occupationLocation</para></remarks>
    /// <seealso href="http://schema.org/occupationLocation">http://schema.org/occupationLocation</seealso>
    let occupationLocation =
        Prefixed_Name(schema1, "occupationLocation") |> PrefixedName

    /// <summary>
    ///   <para>schema1:targetPlatform</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Type of app development: phone, Metro style, desktop, XBox, etc.</para>
    /// labels<para>targetPlatform</para></remarks>
    /// <seealso href="http://schema.org/targetPlatform">http://schema.org/targetPlatform</seealso>
    let targetPlatform = Prefixed_Name(schema1, "targetPlatform") |> PrefixedName
    /// <summary>
    ///   <para>schema1:targetProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Target Operating System / Product to which the code applies.  If applies to several versions, just the product name can be used.</para>
    /// labels<para>targetProduct</para></remarks>
    /// <seealso href="http://schema.org/targetProduct">http://schema.org/targetProduct</seealso>
    let targetProduct = Prefixed_Name(schema1, "targetProduct") |> PrefixedName
    /// <summary>
    ///   <para>schema1:targetUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The URL of a node in an established educational framework.</para>
    /// labels<para>targetUrl</para></remarks>
    /// <seealso href="http://schema.org/targetUrl">http://schema.org/targetUrl</seealso>
    let targetUrl = Prefixed_Name(schema1, "targetUrl") |> PrefixedName
    /// <summary>
    ///   <para>schema1:telephone</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The telephone number.</para>
    /// labels<para>telephone</para></remarks>
    /// <seealso href="http://schema.org/telephone">http://schema.org/telephone</seealso>
    let telephone = Prefixed_Name(schema1, "telephone") |> PrefixedName
    /// <summary>
    ///   <para>schema1:temporal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The "temporal" property can be used in cases where more specific properties
    /// (e.g. &lt;a class="localLink" href="http://schema.org/temporalCoverage"&gt;temporalCoverage&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/dateCreated"&gt;dateCreated&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/dateModified"&gt;dateModified&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/datePublished"&gt;datePublished&lt;/a&gt;) are not known to be appropriate.</para>
    /// labels<para>temporal</para></remarks>
    /// <seealso href="http://schema.org/temporal">http://schema.org/temporal</seealso>
    let temporal = Prefixed_Name(schema1, "temporal") |> PrefixedName
    /// <summary>
    ///   <para>schema1:thumbnail</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Thumbnail image for an image or video.</para>
    /// labels<para>thumbnail</para></remarks>
    /// <seealso href="http://schema.org/thumbnail">http://schema.org/thumbnail</seealso>
    let thumbnail = Prefixed_Name(schema1, "thumbnail") |> PrefixedName
    /// <summary>
    ///   <para>schema1:thumbnailUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A thumbnail image relevant to the Thing.</para>
    /// labels<para>thumbnailUrl</para></remarks>
    /// <seealso href="http://schema.org/thumbnailUrl">http://schema.org/thumbnailUrl</seealso>
    let thumbnailUrl = Prefixed_Name(schema1, "thumbnailUrl") |> PrefixedName
    /// <summary>
    ///   <para>schema1:tickerSymbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The exchange traded instrument associated with a Corporation object. The tickerSymbol is expressed as an exchange and an instrument name separated by a space character. For the exchange component of the tickerSymbol attribute, we recommend using the controlled vocabulary of Market Identifier Codes (MIC) specified in ISO15022.</para>
    /// labels<para>tickerSymbol</para></remarks>
    /// <seealso href="http://schema.org/tickerSymbol">http://schema.org/tickerSymbol</seealso>
    let tickerSymbol = Prefixed_Name(schema1, "tickerSymbol") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ticketToken</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Reference to an asset (e.g., Barcode, QR code image or PDF) usable for entrance.</para>
    /// labels<para>ticketToken</para></remarks>
    /// <seealso href="http://schema.org/ticketToken">http://schema.org/ticketToken</seealso>
    let ticketToken = Prefixed_Name(schema1, "ticketToken") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ticketedSeat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The seat associated with the ticket.</para>
    /// labels<para>ticketedSeat</para></remarks>
    /// <seealso href="http://schema.org/ticketedSeat">http://schema.org/ticketedSeat</seealso>
    let ticketedSeat = Prefixed_Name(schema1, "ticketedSeat") |> PrefixedName
    /// <summary>
    ///   <para>schema1:timeRequired</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Approximate or typical time it takes to work with or through this learning resource for the typical intended target audience, e.g. 'PT30M', 'PT1H25M'.</para>
    /// labels<para>timeRequired</para></remarks>
    /// <seealso href="http://schema.org/timeRequired">http://schema.org/timeRequired</seealso>
    let timeRequired = Prefixed_Name(schema1, "timeRequired") |> PrefixedName
    /// <summary>
    ///   <para>schema1:toRecipient</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of recipient. The recipient who was directly sent the message.</para>
    /// labels<para>toRecipient</para></remarks>
    /// <seealso href="http://schema.org/toRecipient">http://schema.org/toRecipient</seealso>
    let toRecipient = Prefixed_Name(schema1, "toRecipient") |> PrefixedName
    /// <summary>
    ///   <para>schema1:tool</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of instrument. An object used (but not consumed) when performing instructions or a direction.</para>
    /// labels<para>tool</para></remarks>
    /// <seealso href="http://schema.org/tool">http://schema.org/tool</seealso>
    let tool = Prefixed_Name(schema1, "tool") |> PrefixedName
    /// <summary>
    ///   <para>schema1:totalPaymentDue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The total amount due.</para>
    /// labels<para>totalPaymentDue</para></remarks>
    /// <seealso href="http://schema.org/totalPaymentDue">http://schema.org/totalPaymentDue</seealso>
    let totalPaymentDue = Prefixed_Name(schema1, "totalPaymentDue") |> PrefixedName
    /// <summary>
    ///   <para>schema1:AllocateAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of organizing tasks/objects/events by associating resources to it.</para>
    /// labels<para>AllocateAction</para></remarks>
    /// <seealso href="http://schema.org/AllocateAction">http://schema.org/AllocateAction</seealso>
    let AllocateAction = Prefixed_Name(schema1, "AllocateAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:FinancialService</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Financial services business.</para>
    /// labels<para>FinancialService</para></remarks>
    /// <seealso href="http://schema.org/FinancialService">http://schema.org/FinancialService</seealso>
    let FinancialService = Prefixed_Name(schema1, "FinancialService") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A service provided by an organization, e.g. delivery service, print services, etc.</para>
    /// labels<para>Service</para></remarks>
    /// <seealso href="http://schema.org/Service">http://schema.org/Service</seealso>
    let Service = Prefixed_Name(schema1, "Service") |> PrefixedName
    /// <summary>
    ///   <para>schema1:BuddhistTemple</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Buddhist temple.</para>
    /// labels<para>BuddhistTemple</para></remarks>
    /// <seealso href="http://schema.org/BuddhistTemple">http://schema.org/BuddhistTemple</seealso>
    let BuddhistTemple = Prefixed_Name(schema1, "BuddhistTemple") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Reservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Describes a reservation for travel, dining or an event. Some reservations require tickets. &lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, restaurant reservations, flights, or rental cars, use &lt;a class="localLink" href="http://schema.org/Offer"&gt;Offer&lt;/a&gt;.</para>
    /// labels<para>Reservation</para></remarks>
    /// <seealso href="http://schema.org/Reservation">http://schema.org/Reservation</seealso>
    let Reservation = Prefixed_Name(schema1, "Reservation") |> PrefixedName
    /// <summary>
    ///   <para>schema1:BusStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A bus station.</para>
    /// labels<para>BusStation</para></remarks>
    /// <seealso href="http://schema.org/BusStation">http://schema.org/BusStation</seealso>
    let BusStation = Prefixed_Name(schema1, "BusStation") |> PrefixedName
    /// <summary>
    ///   <para>schema1:BusTrip</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A trip on a commercial bus line.</para>
    /// labels<para>BusTrip</para></remarks>
    /// <seealso href="http://schema.org/BusTrip">http://schema.org/BusTrip</seealso>
    let BusTrip = Prefixed_Name(schema1, "BusTrip") |> PrefixedName

    /// <summary>
    ///   <para>schema1:BusinessEntityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A business entity type is a conceptual entity representing the legal form, the size, the main line of business, the position in the value chain, or any combination thereof, of an organization or business person.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Commonly used values:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#Business&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#Enduser&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#PublicInstitution&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#Reseller&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>BusinessEntityType</para></remarks>
    /// <seealso href="http://schema.org/BusinessEntityType">http://schema.org/BusinessEntityType</seealso>
    let BusinessEntityType =
        Prefixed_Name(schema1, "BusinessEntityType") |> PrefixedName

    /// <summary>
    ///   <para>schema1:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the &lt;a class="localLink" href="http://schema.org/offers"&gt;offers&lt;/a&gt; property. Repeated events may be structured as separate Event objects.</para>
    /// labels<para>Event</para></remarks>
    /// <seealso href="http://schema.org/Event">http://schema.org/Event</seealso>
    let Event = Prefixed_Name(schema1, "Event") |> PrefixedName
    /// <summary>
    ///   <para>schema1:BusinessFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The business function specifies the type of activity or access (i.e., the bundle of rights) offered by the organization or business person through the offer. Typical are sell, rental or lease, maintenance or repair, manufacture / produce, recycle / dispose, engineering / construction, or installation. Proprietary specifications of access rights are also instances of this class.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Commonly used values:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#ConstructionInstallation&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#Dispose&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#LeaseOut&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#Maintain&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#ProvideService&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#Repair&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#Sell&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#Buy&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>BusinessFunction</para></remarks>
    /// <seealso href="http://schema.org/BusinessFunction">http://schema.org/BusinessFunction</seealso>
    let BusinessFunction = Prefixed_Name(schema1, "BusinessFunction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:TradeAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of participating in an exchange of goods and services for monetary compensation. An agent trades an object, product or service with a participant in exchange for a one time or periodic payment.</para>
    /// labels<para>TradeAction</para></remarks>
    /// <seealso href="http://schema.org/TradeAction">http://schema.org/TradeAction</seealso>
    let TradeAction = Prefixed_Name(schema1, "TradeAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:CDFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:MusicReleaseFormatType</para>
    ///   <para>CDFormat.</para>
    /// labels<para>CDFormat</para></remarks>
    /// <seealso href="http://schema.org/CDFormat">http://schema.org/CDFormat</seealso>
    let CDFormat = Prefixed_Name(schema1, "CDFormat") |> PrefixedName

    /// <summary>
    ///   <para>schema1:MusicReleaseFormatType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Format of this release (the type of recording media used, ie. compact disc, digital media, LP, etc.).</para>
    /// labels<para>MusicReleaseFormatType</para></remarks>
    /// <seealso href="http://schema.org/MusicReleaseFormatType">http://schema.org/MusicReleaseFormatType</seealso>
    let MusicReleaseFormatType =
        Prefixed_Name(schema1, "MusicReleaseFormatType") |> PrefixedName

    /// <summary>
    ///   <para>schema1:Campground</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A camping site, campsite, or &lt;a class="localLink" href="http://schema.org/Campground"&gt;Campground&lt;/a&gt; is a place used for overnight stay in the outdoors, typically containing individual &lt;a class="localLink" href="http://schema.org/CampingPitch"&gt;CampingPitch&lt;/a&gt; locations. &lt;br/&gt;&lt;br/&gt;
    ///
    /// In British English a campsite is an area, usually divided into a number of pitches, where people can camp overnight using tents or camper vans or caravans; this British English use of the word is synonymous with the American English expression campground. In American English the term campsite generally means an area where an individual, family, group, or military unit can pitch a tent or park a camper; a campground may contain many campsites (Source: Wikipedia see &lt;a href="https://en.wikipedia.org/wiki/Campsite"&gt;https://en.wikipedia.org/wiki/Campsite&lt;/a&gt;).&lt;br/&gt;&lt;br/&gt;
    ///
    /// See also the dedicated &lt;a href="/docs/hotels.html"&gt;document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.</para>
    /// labels<para>Campground</para></remarks>
    /// <seealso href="http://schema.org/Campground">http://schema.org/Campground</seealso>
    let Campground = Prefixed_Name(schema1, "Campground") |> PrefixedName
    /// <summary>
    ///   <para>schema1:CampingPitch</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A &lt;a class="localLink" href="http://schema.org/CampingPitch"&gt;CampingPitch&lt;/a&gt; is an individual place for overnight stay in the outdoors, typically being part of a larger camping site, or &lt;a class="localLink" href="http://schema.org/Campground"&gt;Campground&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
    ///
    /// In British English a campsite, or campground, is an area, usually divided into a number of pitches, where people can camp overnight using tents or camper vans or caravans; this British English use of the word is synonymous with the American English expression campground. In American English the term campsite generally means an area where an individual, family, group, or military unit can pitch a tent or park a camper; a campground may contain many campsites.
    /// (Source: Wikipedia see &lt;a href="https://en.wikipedia.org/wiki/Campsite"&gt;https://en.wikipedia.org/wiki/Campsite&lt;/a&gt;).&lt;br/&gt;&lt;br/&gt;
    ///
    /// See also the dedicated &lt;a href="/docs/hotels.html"&gt;document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.</para>
    /// labels<para>CampingPitch</para></remarks>
    /// <seealso href="http://schema.org/CampingPitch">http://schema.org/CampingPitch</seealso>
    let CampingPitch = Prefixed_Name(schema1, "CampingPitch") |> PrefixedName
    /// <summary>
    ///   <para>schema1:PlanAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of planning the execution of an event/task/action/reservation/plan to a future date.</para>
    /// labels<para>PlanAction</para></remarks>
    /// <seealso href="http://schema.org/PlanAction">http://schema.org/PlanAction</seealso>
    let PlanAction = Prefixed_Name(schema1, "PlanAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Car</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A car is a wheeled, self-powered motor vehicle used for transportation.</para>
    /// labels<para>Car</para></remarks>
    /// <seealso href="http://schema.org/Car">http://schema.org/Car</seealso>
    let Car = Prefixed_Name(schema1, "Car") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Church</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A church.</para>
    /// labels<para>Church</para></remarks>
    /// <seealso href="http://schema.org/Church">http://schema.org/Church</seealso>
    let Church = Prefixed_Name(schema1, "Church") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Cemetery</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A graveyard.</para>
    /// labels<para>Cemetery</para></remarks>
    /// <seealso href="http://schema.org/Cemetery">http://schema.org/Cemetery</seealso>
    let Cemetery = Prefixed_Name(schema1, "Cemetery") |> PrefixedName
    /// <summary>
    ///   <para>schema1:SportsEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Event type: Sports event.</para>
    /// labels<para>SportsEvent</para></remarks>
    /// <seealso href="http://schema.org/SportsEvent">http://schema.org/SportsEvent</seealso>
    let SportsEvent = Prefixed_Name(schema1, "SportsEvent") |> PrefixedName
    /// <summary>
    ///   <para>schema1:SportsTeam</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Organization: Sports team.</para>
    /// labels<para>SportsTeam</para></remarks>
    /// <seealso href="http://schema.org/SportsTeam">http://schema.org/SportsTeam</seealso>
    let SportsTeam = Prefixed_Name(schema1, "SportsTeam") |> PrefixedName
    /// <summary>
    ///   <para>schema1:StadiumOrArena</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A stadium.</para>
    /// labels<para>StadiumOrArena</para></remarks>
    /// <seealso href="http://schema.org/StadiumOrArena">http://schema.org/StadiumOrArena</seealso>
    let StadiumOrArena = Prefixed_Name(schema1, "StadiumOrArena") |> PrefixedName

    /// <summary>
    ///   <para>schema1:albumProductionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Classification of the album by it's type of content: soundtrack, live album, studio album, etc.</para>
    /// labels<para>albumProductionType</para></remarks>
    /// <seealso href="http://schema.org/albumProductionType">http://schema.org/albumProductionType</seealso>
    let albumProductionType =
        Prefixed_Name(schema1, "albumProductionType") |> PrefixedName

    /// <summary>
    ///   <para>schema1:albumRelease</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A release of this album.</para>
    /// labels<para>albumRelease</para></remarks>
    /// <seealso href="http://schema.org/albumRelease">http://schema.org/albumRelease</seealso>
    let albumRelease = Prefixed_Name(schema1, "albumRelease") |> PrefixedName
    /// <summary>
    ///   <para>schema1:releaseOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The album this is a release of.</para>
    /// labels<para>releaseOf</para></remarks>
    /// <seealso href="http://schema.org/releaseOf">http://schema.org/releaseOf</seealso>
    let releaseOf = Prefixed_Name(schema1, "releaseOf") |> PrefixedName
    /// <summary>
    ///   <para>schema1:albumReleaseType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The kind of release which this album is: single, EP or album.</para>
    /// labels<para>albumReleaseType</para></remarks>
    /// <seealso href="http://schema.org/albumReleaseType">http://schema.org/albumReleaseType</seealso>
    let albumReleaseType = Prefixed_Name(schema1, "albumReleaseType") |> PrefixedName
    /// <summary>
    ///   <para>schema1:alignmentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A category of alignment between the learning resource and the framework node. Recommended values include: 'assesses', 'teaches', 'requires', 'textComplexity', 'readingLevel', 'educationalSubject', and 'educationalLevel'.</para>
    /// labels<para>alignmentType</para></remarks>
    /// <seealso href="http://schema.org/alignmentType">http://schema.org/alignmentType</seealso>
    let alignmentType = Prefixed_Name(schema1, "alignmentType") |> PrefixedName
    /// <summary>
    ///   <para>schema1:alternateName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An alias for the item.</para>
    /// labels<para>alternateName</para></remarks>
    /// <seealso href="http://schema.org/alternateName">http://schema.org/alternateName</seealso>
    let alternateName = Prefixed_Name(schema1, "alternateName") |> PrefixedName
    /// <summary>
    ///   <para>schema1:alumniOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An organization that the person is an alumni of.</para>
    /// labels<para>alumniOf</para></remarks>
    /// <seealso href="http://schema.org/alumniOf">http://schema.org/alumniOf</seealso>
    let alumniOf = Prefixed_Name(schema1, "alumniOf") |> PrefixedName
    /// <summary>
    ///   <para>schema1:amenityFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An amenity feature (e.g. a characteristic or service) of the Accommodation. This generic property does not make a statement about whether the feature is included in an offer for the main accommodation or available at extra costs.</para>
    /// labels<para>amenityFeature</para></remarks>
    /// <seealso href="http://schema.org/amenityFeature">http://schema.org/amenityFeature</seealso>
    let amenityFeature = Prefixed_Name(schema1, "amenityFeature") |> PrefixedName
    /// <summary>
    ///   <para>schema1:FloorPlan</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schema.org/FloorPlan">http://schema.org/FloorPlan</seealso>
    let FloorPlan = Prefixed_Name(schema1, "FloorPlan") |> PrefixedName
    /// <summary>
    ///   <para>schema1:MoneyTransfer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schema.org/MoneyTransfer">http://schema.org/MoneyTransfer</seealso>
    let MoneyTransfer = Prefixed_Name(schema1, "MoneyTransfer") |> PrefixedName
    /// <summary>
    ///   <para>schema1:MonetaryGrant</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schema.org/MonetaryGrant">http://schema.org/MonetaryGrant</seealso>
    let MonetaryGrant = Prefixed_Name(schema1, "MonetaryGrant") |> PrefixedName
    /// <summary>
    ///   <para>schema1:amountOfThisGood</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The quantity of the goods included in the offer.</para>
    /// labels<para>amountOfThisGood</para></remarks>
    /// <seealso href="http://schema.org/amountOfThisGood">http://schema.org/amountOfThisGood</seealso>
    let amountOfThisGood = Prefixed_Name(schema1, "amountOfThisGood") |> PrefixedName

    /// <summary>
    ///   <para>schema1:annualPercentageRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The annual rate that is charged for borrowing (or made by investing), expressed as a single percentage number that represents the actual yearly cost of funds over the term of a loan. This includes any fees or additional costs associated with the transaction.</para>
    /// labels<para>annualPercentageRate</para></remarks>
    /// <seealso href="http://schema.org/annualPercentageRate">http://schema.org/annualPercentageRate</seealso>
    let annualPercentageRate =
        Prefixed_Name(schema1, "annualPercentageRate") |> PrefixedName

    /// <summary>
    ///   <para>schema1:datePosted</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Publication date of an online listing.</para>
    /// labels<para>datePosted</para></remarks>
    /// <seealso href="http://schema.org/datePosted">http://schema.org/datePosted</seealso>
    let datePosted = Prefixed_Name(schema1, "datePosted") |> PrefixedName
    /// <summary>
    ///   <para>schema1:RealEstateListing</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schema.org/RealEstateListing">http://schema.org/RealEstateListing</seealso>
    let RealEstateListing = Prefixed_Name(schema1, "RealEstateListing") |> PrefixedName
    /// <summary>
    ///   <para>schema1:datePublished</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Date of first broadcast/publication.</para>
    /// labels<para>datePublished</para></remarks>
    /// <seealso href="http://schema.org/datePublished">http://schema.org/datePublished</seealso>
    let datePublished = Prefixed_Name(schema1, "datePublished") |> PrefixedName
    /// <summary>
    ///   <para>schema1:printSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>If this NewsArticle appears in print, this field indicates the print section in which the article appeared.</para>
    /// labels<para>printSection</para></remarks>
    /// <seealso href="http://schema.org/printSection">http://schema.org/printSection</seealso>
    let printSection = Prefixed_Name(schema1, "printSection") |> PrefixedName
    /// <summary>
    ///   <para>schema1:processingTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Estimated processing time for the service using this channel.</para>
    /// labels<para>processingTime</para></remarks>
    /// <seealso href="http://schema.org/processingTime">http://schema.org/processingTime</seealso>
    let processingTime = Prefixed_Name(schema1, "processingTime") |> PrefixedName
    /// <summary>
    ///   <para>schema1:produces</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The tangible thing generated by the service, e.g. a passport, permit, etc.</para>
    /// labels<para>produces</para></remarks>
    /// <seealso href="http://schema.org/produces">http://schema.org/produces</seealso>
    let produces = Prefixed_Name(schema1, "produces") |> PrefixedName
    /// <summary>
    ///   <para>schema1:serviceOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The tangible thing generated by the service, e.g. a passport, permit, etc.</para>
    /// labels<para>serviceOutput</para></remarks>
    /// <seealso href="http://schema.org/serviceOutput">http://schema.org/serviceOutput</seealso>
    let serviceOutput = Prefixed_Name(schema1, "serviceOutput") |> PrefixedName
    /// <summary>
    ///   <para>schema1:productID</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The product identifier, such as ISBN. For example: &lt;code&gt;meta itemprop="productID" content="isbn:123-456-789"&lt;/code&gt;.</para>
    /// labels<para>productID</para></remarks>
    /// <seealso href="http://schema.org/productID">http://schema.org/productID</seealso>
    let productID = Prefixed_Name(schema1, "productID") |> PrefixedName
    /// <summary>
    ///   <para>schema1:productionCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The production company or studio responsible for the item e.g. series, video game, episode etc.</para>
    /// labels<para>productionCompany</para></remarks>
    /// <seealso href="http://schema.org/productionCompany">http://schema.org/productionCompany</seealso>
    let productionCompany = Prefixed_Name(schema1, "productionCompany") |> PrefixedName
    /// <summary>
    ///   <para>schema1:productionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The date of production of the item, e.g. vehicle.</para>
    /// labels<para>productionDate</para></remarks>
    /// <seealso href="http://schema.org/productionDate">http://schema.org/productionDate</seealso>
    let productionDate = Prefixed_Name(schema1, "productionDate") |> PrefixedName
    /// <summary>
    ///   <para>schema1:proficiencyLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Proficiency needed for this content; expected values: 'Beginner', 'Expert'.</para>
    /// labels<para>proficiencyLevel</para></remarks>
    /// <seealso href="http://schema.org/proficiencyLevel">http://schema.org/proficiencyLevel</seealso>
    let proficiencyLevel = Prefixed_Name(schema1, "proficiencyLevel") |> PrefixedName
    /// <summary>
    ///   <para>schema1:warrantyPromise</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The warranty promise(s) included in the offer.</para>
    /// labels<para>warrantyPromise</para></remarks>
    /// <seealso href="http://schema.org/warrantyPromise">http://schema.org/warrantyPromise</seealso>
    let warrantyPromise = Prefixed_Name(schema1, "warrantyPromise") |> PrefixedName
    /// <summary>
    ///   <para>schema1:warrantyScope</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The scope of the warranty promise.</para>
    /// labels<para>warrantyScope</para></remarks>
    /// <seealso href="http://schema.org/warrantyScope">http://schema.org/warrantyScope</seealso>
    let warrantyScope = Prefixed_Name(schema1, "warrantyScope") |> PrefixedName
    /// <summary>
    ///   <para>schema1:webCheckinTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The time when a passenger can check into the flight online.</para>
    /// labels<para>webCheckinTime</para></remarks>
    /// <seealso href="http://schema.org/webCheckinTime">http://schema.org/webCheckinTime</seealso>
    let webCheckinTime = Prefixed_Name(schema1, "webCheckinTime") |> PrefixedName
    /// <summary>
    ///   <para>schema1:weight</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The weight of the product or person.</para>
    /// labels<para>weight</para></remarks>
    /// <seealso href="http://schema.org/weight">http://schema.org/weight</seealso>
    let weight = Prefixed_Name(schema1, "weight") |> PrefixedName
    /// <summary>
    ///   <para>schema1:width</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The width of the item.</para>
    /// labels<para>width</para></remarks>
    /// <seealso href="http://schema.org/width">http://schema.org/width</seealso>
    let width = Prefixed_Name(schema1, "width") |> PrefixedName
    /// <summary>
    ///   <para>schema1:winner</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of participant. The winner of the action.</para>
    /// labels<para>winner</para></remarks>
    /// <seealso href="http://schema.org/winner">http://schema.org/winner</seealso>
    let winner = Prefixed_Name(schema1, "winner") |> PrefixedName
    /// <summary>
    ///   <para>schema1:MediaObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A media object, such as an image, video, or audio object embedded in a web page or a downloadable dataset i.e. DataDownload. Note that a creative work may have many media objects associated with it on the same web page. For example, a page about a single song (MusicRecording) may have a music video (VideoObject), and a high and low bandwidth audio stream (2 AudioObject's).</para>
    /// labels<para>MediaObject</para></remarks>
    /// <seealso href="http://schema.org/MediaObject">http://schema.org/MediaObject</seealso>
    let MediaObject = Prefixed_Name(schema1, "MediaObject") |> PrefixedName
    /// <summary>
    ///   <para>schema1:AuthorizeAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of granting permission to an object.</para>
    /// labels<para>AuthorizeAction</para></remarks>
    /// <seealso href="http://schema.org/AuthorizeAction">http://schema.org/AuthorizeAction</seealso>
    let AuthorizeAction = Prefixed_Name(schema1, "AuthorizeAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:AutoDealer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An car dealership.</para>
    /// labels<para>AutoDealer</para></remarks>
    /// <seealso href="http://schema.org/AutoDealer">http://schema.org/AutoDealer</seealso>
    let AutoDealer = Prefixed_Name(schema1, "AutoDealer") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Store</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A retail good store.</para>
    /// labels<para>Store</para></remarks>
    /// <seealso href="http://schema.org/Store">http://schema.org/Store</seealso>
    let Store = Prefixed_Name(schema1, "Store") |> PrefixedName
    /// <summary>
    ///   <para>schema1:AutoWash</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A car wash business.</para>
    /// labels<para>AutoWash</para></remarks>
    /// <seealso href="http://schema.org/AutoWash">http://schema.org/AutoWash</seealso>
    let AutoWash = Prefixed_Name(schema1, "AutoWash") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Bakery</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A bakery.</para>
    /// labels<para>Bakery</para></remarks>
    /// <seealso href="http://schema.org/Bakery">http://schema.org/Bakery</seealso>
    let Bakery = Prefixed_Name(schema1, "Bakery") |> PrefixedName
    /// <summary>
    ///   <para>schema1:BarOrPub</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A bar or pub.</para>
    /// labels<para>BarOrPub</para></remarks>
    /// <seealso href="http://schema.org/BarOrPub">http://schema.org/BarOrPub</seealso>
    let BarOrPub = Prefixed_Name(schema1, "BarOrPub") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Beach</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Beach.</para>
    /// labels<para>Beach</para></remarks>
    /// <seealso href="http://schema.org/Beach">http://schema.org/Beach</seealso>
    let Beach = Prefixed_Name(schema1, "Beach") |> PrefixedName
    /// <summary>
    ///   <para>schema1:LodgingBusiness</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A lodging business, such as a motel, hotel, or inn.</para>
    /// labels<para>LodgingBusiness</para></remarks>
    /// <seealso href="http://schema.org/LodgingBusiness">http://schema.org/LodgingBusiness</seealso>
    let LodgingBusiness = Prefixed_Name(schema1, "LodgingBusiness") |> PrefixedName
    /// <summary>
    ///   <para>schema1:BedDetails</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An entity holding detailed information about the available bed types, e.g. the quantity of twin beds for a hotel room. For the single case of just one bed of a certain type, you can use bed directly with a text. See also &lt;a class="localLink" href="http://schema.org/BedType"&gt;BedType&lt;/a&gt; (under development).</para>
    /// labels<para>BedDetails</para></remarks>
    /// <seealso href="http://schema.org/BedDetails">http://schema.org/BedDetails</seealso>
    let BedDetails = Prefixed_Name(schema1, "BedDetails") |> PrefixedName
    /// <summary>
    ///   <para>schema1:BedType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A type of bed. This is used for indicating the bed or beds available in an accommodation.</para>
    /// labels<para>BedType</para></remarks>
    /// <seealso href="http://schema.org/BedType">http://schema.org/BedType</seealso>
    let BedType = Prefixed_Name(schema1, "BedType") |> PrefixedName
    /// <summary>
    ///   <para>schema1:BefriendAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of forming a personal connection with someone (object) mutually/bidirectionally/symmetrically.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/FollowAction"&gt;FollowAction&lt;/a&gt;: Unlike FollowAction, BefriendAction implies that the connection is reciprocal.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>BefriendAction</para></remarks>
    /// <seealso href="http://schema.org/BefriendAction">http://schema.org/BefriendAction</seealso>
    let BefriendAction = Prefixed_Name(schema1, "BefriendAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:InteractAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of interacting with another person or organization.</para>
    /// labels<para>InteractAction</para></remarks>
    /// <seealso href="http://schema.org/InteractAction">http://schema.org/InteractAction</seealso>
    let InteractAction = Prefixed_Name(schema1, "InteractAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Blog</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A blog.</para>
    /// labels<para>Blog</para></remarks>
    /// <seealso href="http://schema.org/Blog">http://schema.org/Blog</seealso>
    let Blog = Prefixed_Name(schema1, "Blog") |> PrefixedName

    /// <summary>
    ///   <para>schema1:SocialMediaPosting</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A post to a social media platform, including blog posts, tweets, Facebook posts, etc.</para>
    /// labels<para>SocialMediaPosting</para></remarks>
    /// <seealso href="http://schema.org/SocialMediaPosting">http://schema.org/SocialMediaPosting</seealso>
    let SocialMediaPosting =
        Prefixed_Name(schema1, "SocialMediaPosting") |> PrefixedName

    /// <summary>
    ///   <para>schema1:BoardingPolicyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A type of boarding policy used by an airline.</para>
    /// labels<para>BoardingPolicyType</para></remarks>
    /// <seealso href="http://schema.org/BoardingPolicyType">http://schema.org/BoardingPolicyType</seealso>
    let BoardingPolicyType =
        Prefixed_Name(schema1, "BoardingPolicyType") |> PrefixedName

    /// <summary>
    ///   <para>schema1:CreativeWorkSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A CreativeWorkSeries in schema.org is a group of related items, typically but not necessarily of the same kind. CreativeWorkSeries are usually organized into some order, often chronological. Unlike &lt;a class="localLink" href="http://schema.org/ItemList"&gt;ItemList&lt;/a&gt; which is a general purpose data structure for lists of things, the emphasis with CreativeWorkSeries is on published materials (written e.g. books and periodicals, or media such as tv, radio and games).&lt;br/&gt;&lt;br/&gt;
    ///
    /// Specific subtypes are available for describing &lt;a class="localLink" href="http://schema.org/TVSeries"&gt;TVSeries&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/RadioSeries"&gt;RadioSeries&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/MovieSeries"&gt;MovieSeries&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/BookSeries"&gt;BookSeries&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Periodical"&gt;Periodical&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/VideoGameSeries"&gt;VideoGameSeries&lt;/a&gt;. In each case, the &lt;a class="localLink" href="http://schema.org/hasPart"&gt;hasPart&lt;/a&gt; / &lt;a class="localLink" href="http://schema.org/isPartOf"&gt;isPartOf&lt;/a&gt; properties can be used to relate the CreativeWorkSeries to its parts. The general CreativeWorkSeries type serves largely just to organize these more specific and practical subtypes.&lt;br/&gt;&lt;br/&gt;
    ///
    /// It is common for properties applicable to an item from the series to be usefully applied to the containing group. Schema.org attempts to anticipate some of these cases, but publishers should be free to apply properties of the series parts to the series as a whole wherever they seem appropriate.</para>
    /// labels<para>CreativeWorkSeries</para></remarks>
    /// <seealso href="http://schema.org/CreativeWorkSeries">http://schema.org/CreativeWorkSeries</seealso>
    let CreativeWorkSeries =
        Prefixed_Name(schema1, "CreativeWorkSeries") |> PrefixedName

    /// <summary>
    ///   <para>schema1:BookStore</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A bookstore.</para>
    /// labels<para>BookStore</para></remarks>
    /// <seealso href="http://schema.org/BookStore">http://schema.org/BookStore</seealso>
    let BookStore = Prefixed_Name(schema1, "BookStore") |> PrefixedName
    /// <summary>
    ///   <para>schema1:MeetingRoom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A meeting room, conference room, or conference hall is a room provided for singular events such as business conferences and meetings (Source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Conference_hall"&gt;http://en.wikipedia.org/wiki/Conference_hall&lt;/a&gt;).
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.</para>
    /// labels<para>MeetingRoom</para></remarks>
    /// <seealso href="http://schema.org/MeetingRoom">http://schema.org/MeetingRoom</seealso>
    let MeetingRoom = Prefixed_Name(schema1, "MeetingRoom") |> PrefixedName
    /// <summary>
    ///   <para>schema1:MenuSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A sub-grouping of food or drink items in a menu. E.g. courses (such as 'Dinner', 'Breakfast', etc.), specific type of dishes (such as 'Meat', 'Vegan', 'Drinks', etc.), or some other classification made by the menu provider.</para>
    /// labels<para>MenuSection</para></remarks>
    /// <seealso href="http://schema.org/MenuSection">http://schema.org/MenuSection</seealso>
    let MenuSection = Prefixed_Name(schema1, "MenuSection") |> PrefixedName
    /// <summary>
    ///   <para>schema1:SearchResultsPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Web page type: Search results page.</para>
    /// labels<para>SearchResultsPage</para></remarks>
    /// <seealso href="http://schema.org/SearchResultsPage">http://schema.org/SearchResultsPage</seealso>
    let SearchResultsPage = Prefixed_Name(schema1, "SearchResultsPage") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Season</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A media season e.g. tv, radio, video game etc.</para>
    /// labels<para>Season</para></remarks>
    /// <seealso href="http://schema.org/Season">http://schema.org/Season</seealso>
    let Season = Prefixed_Name(schema1, "Season") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Seat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Used to describe a seat, such as a reserved seat in an event reservation.</para>
    /// labels<para>Seat</para></remarks>
    /// <seealso href="http://schema.org/Seat">http://schema.org/Seat</seealso>
    let Seat = Prefixed_Name(schema1, "Seat") |> PrefixedName
    /// <summary>
    ///   <para>schema1:SelfStorage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A self-storage facility.</para>
    /// labels<para>SelfStorage</para></remarks>
    /// <seealso href="http://schema.org/SelfStorage">http://schema.org/SelfStorage</seealso>
    let SelfStorage = Prefixed_Name(schema1, "SelfStorage") |> PrefixedName
    /// <summary>
    ///   <para>schema1:SellAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of taking money from a buyer in exchange for goods or services rendered. An agent sells an object, product, or service to a buyer for a price. Reciprocal of BuyAction.</para>
    /// labels<para>SellAction</para></remarks>
    /// <seealso href="http://schema.org/SellAction">http://schema.org/SellAction</seealso>
    let SellAction = Prefixed_Name(schema1, "SellAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ServiceChannel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A means for accessing a service, e.g. a government office location, web site, or phone number.</para>
    /// labels<para>ServiceChannel</para></remarks>
    /// <seealso href="http://schema.org/ServiceChannel">http://schema.org/ServiceChannel</seealso>
    let ServiceChannel = Prefixed_Name(schema1, "ServiceChannel") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ShareAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of distributing content to people for their amusement or edification.</para>
    /// labels<para>ShareAction</para></remarks>
    /// <seealso href="http://schema.org/ShareAction">http://schema.org/ShareAction</seealso>
    let ShareAction = Prefixed_Name(schema1, "ShareAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ShoppingCenter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A shopping center or mall.</para>
    /// labels<para>ShoppingCenter</para></remarks>
    /// <seealso href="http://schema.org/ShoppingCenter">http://schema.org/ShoppingCenter</seealso>
    let ShoppingCenter = Prefixed_Name(schema1, "ShoppingCenter") |> PrefixedName

    /// <summary>
    ///   <para>schema1:SingleFamilyResidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Residence type: Single-family home.</para>
    /// labels<para>SingleFamilyResidence</para></remarks>
    /// <seealso href="http://schema.org/SingleFamilyResidence">http://schema.org/SingleFamilyResidence</seealso>
    let SingleFamilyResidence =
        Prefixed_Name(schema1, "SingleFamilyResidence") |> PrefixedName

    /// <summary>
    ///   <para>schema1:SinglePlayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:GamePlayMode</para>
    ///   <para>Play mode: SinglePlayer. Which is played by a lone player.</para>
    /// labels<para>SinglePlayer</para></remarks>
    /// <seealso href="http://schema.org/SinglePlayer">http://schema.org/SinglePlayer</seealso>
    let SinglePlayer = Prefixed_Name(schema1, "SinglePlayer") |> PrefixedName
    /// <summary>
    ///   <para>schema1:actors</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An actor, e.g. in tv, radio, movie, video games etc. Actors can be associated with individual items or with a series, episode, clip.</para>
    /// labels<para>actors</para></remarks>
    /// <seealso href="http://schema.org/actors">http://schema.org/actors</seealso>
    let actors = Prefixed_Name(schema1, "actors") |> PrefixedName
    /// <summary>
    ///   <para>schema1:addOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An additional offer that can only be obtained in combination with the first base offer (e.g. supplements and extensions that are available for a surcharge).</para>
    /// labels<para>addOn</para></remarks>
    /// <seealso href="http://schema.org/addOn">http://schema.org/addOn</seealso>
    let addOn = Prefixed_Name(schema1, "addOn") |> PrefixedName
    /// <summary>
    ///   <para>schema1:additionalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An additional name for a Person, can be used for a middle name.</para>
    /// labels<para>additionalName</para></remarks>
    /// <seealso href="http://schema.org/additionalName">http://schema.org/additionalName</seealso>
    let additionalName = Prefixed_Name(schema1, "additionalName") |> PrefixedName

    /// <summary>
    ///   <para>schema1:additionalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A property-value pair representing an additional characteristics of the entitity, e.g. a product feature or another characteristic for which there is no matching property in schema.org.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: Publishers should be aware that applications designed to use specific schema.org properties (e.g. http://schema.org/width, http://schema.org/color, http://schema.org/gtin13, ...) will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.</para>
    /// labels<para>additionalProperty</para></remarks>
    /// <seealso href="http://schema.org/additionalProperty">http://schema.org/additionalProperty</seealso>
    let additionalProperty =
        Prefixed_Name(schema1, "additionalProperty") |> PrefixedName

    /// <summary>
    ///   <para>schema1:additionalType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An additional type for the item, typically used for adding more specific types from external vocabularies in microdata syntax. This is a relationship between something and a class that the thing is in. In RDFa syntax, it is better to use the native RDFa syntax - the 'typeof' attribute - for multiple types. Schema.org tools may have only weaker understanding of extra types, in particular those defined externally.</para>
    /// labels<para>additionalType</para></remarks>
    /// <seealso href="http://schema.org/additionalType">http://schema.org/additionalType</seealso>
    let additionalType = Prefixed_Name(schema1, "additionalType") |> PrefixedName
    /// <summary>
    ///   <para>schema1:address</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Physical address of the item.</para>
    /// labels<para>address</para></remarks>
    /// <seealso href="http://schema.org/address">http://schema.org/address</seealso>
    let address = Prefixed_Name(schema1, "address") |> PrefixedName
    /// <summary>
    ///   <para>schema1:addressCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The country. For example, USA. You can also provide the two-letter &lt;a href="http://en.wikipedia.org/wiki/ISO_3166-1"&gt;ISO 3166-1 alpha-2 country code&lt;/a&gt;.</para>
    /// labels<para>addressCountry</para></remarks>
    /// <seealso href="http://schema.org/addressCountry">http://schema.org/addressCountry</seealso>
    let addressCountry = Prefixed_Name(schema1, "addressCountry") |> PrefixedName
    /// <summary>
    ///   <para>schema1:addressLocality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The locality in which the street address is, and which is in the region. For example, Mountain View.</para>
    /// labels<para>addressLocality</para></remarks>
    /// <seealso href="http://schema.org/addressLocality">http://schema.org/addressLocality</seealso>
    let addressLocality = Prefixed_Name(schema1, "addressLocality") |> PrefixedName
    /// <summary>
    ///   <para>schema1:addressRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The region in which the locality is, and which is in the country. For example, California or another appropriate first-level &lt;a href="https://en.wikipedia.org/wiki/List_of_administrative_divisions_by_country"&gt;Administrative division&lt;/a&gt;</para>
    /// labels<para>addressRegion</para></remarks>
    /// <seealso href="http://schema.org/addressRegion">http://schema.org/addressRegion</seealso>
    let addressRegion = Prefixed_Name(schema1, "addressRegion") |> PrefixedName

    /// <summary>
    ///   <para>schema1:advanceBookingRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The amount of time that is required between accepting the offer and the actual usage of the resource or service.</para>
    /// labels<para>advanceBookingRequirement</para></remarks>
    /// <seealso href="http://schema.org/advanceBookingRequirement">http://schema.org/advanceBookingRequirement</seealso>
    let advanceBookingRequirement =
        Prefixed_Name(schema1, "advanceBookingRequirement") |> PrefixedName

    /// <summary>
    ///   <para>schema1:affiliation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An organization that this person is affiliated with. For example, a school/university, a club, or a team.</para>
    /// labels<para>affiliation</para></remarks>
    /// <seealso href="http://schema.org/affiliation">http://schema.org/affiliation</seealso>
    let affiliation = Prefixed_Name(schema1, "affiliation") |> PrefixedName
    /// <summary>
    ///   <para>schema1:memberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An Organization (or ProgramMembership) to which this Person or Organization belongs.</para>
    /// labels<para>memberOf</para></remarks>
    /// <seealso href="http://schema.org/memberOf">http://schema.org/memberOf</seealso>
    let memberOf = Prefixed_Name(schema1, "memberOf") |> PrefixedName
    /// <summary>
    ///   <para>schema1:afterMedia</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A media object representing the circumstances after performing this direction.</para>
    /// labels<para>afterMedia</para></remarks>
    /// <seealso href="http://schema.org/afterMedia">http://schema.org/afterMedia</seealso>
    let afterMedia = Prefixed_Name(schema1, "afterMedia") |> PrefixedName
    /// <summary>
    ///   <para>schema1:agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The direct performer or driver of the action (animate or inanimate). e.g. &lt;em&gt;John&lt;/em&gt; wrote a book.</para>
    /// labels<para>agent</para></remarks>
    /// <seealso href="http://schema.org/agent">http://schema.org/agent</seealso>
    let agent = Prefixed_Name(schema1, "agent") |> PrefixedName
    /// <summary>
    ///   <para>schema1:aggregateRating</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The overall rating, based on a collection of reviews or ratings, of the item.</para>
    /// labels<para>aggregateRating</para></remarks>
    /// <seealso href="http://schema.org/aggregateRating">http://schema.org/aggregateRating</seealso>
    let aggregateRating = Prefixed_Name(schema1, "aggregateRating") |> PrefixedName
    /// <summary>
    ///   <para>schema1:aircraft</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The kind of aircraft (e.g., "Boeing 747").</para>
    /// labels<para>aircraft</para></remarks>
    /// <seealso href="http://schema.org/aircraft">http://schema.org/aircraft</seealso>
    let aircraft = Prefixed_Name(schema1, "aircraft") |> PrefixedName
    /// <summary>
    ///   <para>schema1:album</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A music album.</para>
    /// labels<para>album</para></remarks>
    /// <seealso href="http://schema.org/album">http://schema.org/album</seealso>
    let album = Prefixed_Name(schema1, "album") |> PrefixedName
    /// <summary>
    ///   <para>schema1:cssSelector</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A CSS selector, e.g. of a &lt;a class="localLink" href="http://schema.org/SpeakableSpecification"&gt;SpeakableSpecification&lt;/a&gt; or &lt;a class="localLink" href="http://schema.org/WebPageElement"&gt;WebPageElement&lt;/a&gt;. In the latter case, multiple matches within a page can constitute a single conceptual "Web page element".</para>
    /// labels<para>cssSelector</para></remarks>
    /// <seealso href="http://schema.org/cssSelector">http://schema.org/cssSelector</seealso>
    let cssSelector = Prefixed_Name(schema1, "cssSelector") |> PrefixedName
    /// <summary>
    ///   <para>schema1:CssSelectorType</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schema.org/CssSelectorType">http://schema.org/CssSelectorType</seealso>
    let CssSelectorType = Prefixed_Name(schema1, "CssSelectorType") |> PrefixedName

    /// <summary>
    ///   <para>schema1:currenciesAccepted</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The currency accepted.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".</para>
    /// labels<para>currenciesAccepted</para></remarks>
    /// <seealso href="http://schema.org/currenciesAccepted">http://schema.org/currenciesAccepted</seealso>
    let currenciesAccepted =
        Prefixed_Name(schema1, "currenciesAccepted") |> PrefixedName

    /// <summary>
    ///   <para>schema1:currency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The currency in which the monetary amount is expressed.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".</para>
    /// labels<para>currency</para></remarks>
    /// <seealso href="http://schema.org/currency">http://schema.org/currency</seealso>
    let currency = Prefixed_Name(schema1, "currency") |> PrefixedName

    /// <summary>
    ///   <para>schema1:ExchangeRateSpecification</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schema.org/ExchangeRateSpecification">http://schema.org/ExchangeRateSpecification</seealso>
    let ExchangeRateSpecification =
        Prefixed_Name(schema1, "ExchangeRateSpecification") |> PrefixedName

    /// <summary>
    ///   <para>schema1:customer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Party placing the order or paying the invoice.</para>
    /// labels<para>customer</para></remarks>
    /// <seealso href="http://schema.org/customer">http://schema.org/customer</seealso>
    let customer = Prefixed_Name(schema1, "customer") |> PrefixedName

    /// <summary>
    ///   <para>schema1:datasetTimeInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The range of temporal applicability of a dataset, e.g. for a 2011 census dataset, the year 2011 (in ISO 8601 time interval format).</para>
    /// labels<para>datasetTimeInterval</para></remarks>
    /// <seealso href="http://schema.org/datasetTimeInterval">http://schema.org/datasetTimeInterval</seealso>
    let datasetTimeInterval =
        Prefixed_Name(schema1, "datasetTimeInterval") |> PrefixedName

    /// <summary>
    ///   <para>schema1:temporalCoverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The temporalCoverage of a CreativeWork indicates the period that the content applies to, i.e. that it describes, either as a DateTime or as a textual string indicating a time period in &lt;a href="https://en.wikipedia.org/wiki/ISO_8601#Time_intervals"&gt;ISO 8601 time interval format&lt;/a&gt;. In
    ///       the case of a Dataset it will typically indicate the relevant time period in a precise notation (e.g. for a 2011 census dataset, the year 2011 would be written "2011/2012"). Other forms of content e.g. ScholarlyArticle, Book, TVSeries or TVEpisode may indicate their temporalCoverage in broader terms - textually or via well-known URL.
    ///       Written works such as books may sometimes have precise temporal coverage too, e.g. a work set in 1939 - 1945 can be indicated in ISO 8601 interval format format via "1939/1945".&lt;br/&gt;&lt;br/&gt;
    ///
    /// Open-ended date ranges can be written with ".." in place of the end date. For example, "2015-11/.." indicates a range beginning in November 2015 and with no specified final date. This is tentative and might be updated in future when ISO 8601 is officially updated.</para>
    /// labels<para>temporalCoverage</para></remarks>
    /// <seealso href="http://schema.org/temporalCoverage">http://schema.org/temporalCoverage</seealso>
    let temporalCoverage = Prefixed_Name(schema1, "temporalCoverage") |> PrefixedName
    /// <summary>
    ///   <para>schema1:dateCreated</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The date on which the CreativeWork was created or the item was added to a DataFeed.</para>
    /// labels<para>dateCreated</para></remarks>
    /// <seealso href="http://schema.org/dateCreated">http://schema.org/dateCreated</seealso>
    let dateCreated = Prefixed_Name(schema1, "dateCreated") |> PrefixedName
    /// <summary>
    ///   <para>schema1:dateDeleted</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The datetime the item was removed from the DataFeed.</para>
    /// labels<para>dateDeleted</para></remarks>
    /// <seealso href="http://schema.org/dateDeleted">http://schema.org/dateDeleted</seealso>
    let dateDeleted = Prefixed_Name(schema1, "dateDeleted") |> PrefixedName
    /// <summary>
    ///   <para>schema1:dateIssued</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The date the ticket was issued.</para>
    /// labels<para>dateIssued</para></remarks>
    /// <seealso href="http://schema.org/dateIssued">http://schema.org/dateIssued</seealso>
    let dateIssued = Prefixed_Name(schema1, "dateIssued") |> PrefixedName
    /// <summary>
    ///   <para>schema1:dateModified</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The date on which the CreativeWork was most recently modified or when the item's entry was modified within a DataFeed.</para>
    /// labels<para>dateModified</para></remarks>
    /// <seealso href="http://schema.org/dateModified">http://schema.org/dateModified</seealso>
    let dateModified = Prefixed_Name(schema1, "dateModified") |> PrefixedName
    /// <summary>
    ///   <para>schema1:dateRead</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The date/time at which the message has been read by the recipient if a single recipient exists.</para>
    /// labels<para>dateRead</para></remarks>
    /// <seealso href="http://schema.org/dateRead">http://schema.org/dateRead</seealso>
    let dateRead = Prefixed_Name(schema1, "dateRead") |> PrefixedName
    /// <summary>
    ///   <para>schema1:dateReceived</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The date/time the message was received if a single recipient exists.</para>
    /// labels<para>dateReceived</para></remarks>
    /// <seealso href="http://schema.org/dateReceived">http://schema.org/dateReceived</seealso>
    let dateReceived = Prefixed_Name(schema1, "dateReceived") |> PrefixedName
    /// <summary>
    ///   <para>schema1:dateSent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The date/time at which the message was sent.</para>
    /// labels<para>dateSent</para></remarks>
    /// <seealso href="http://schema.org/dateSent">http://schema.org/dateSent</seealso>
    let dateSent = Prefixed_Name(schema1, "dateSent") |> PrefixedName

    /// <summary>
    ///   <para>schema1:dateVehicleFirstRegistered</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The date of the first registration of the vehicle with the respective public authorities.</para>
    /// labels<para>dateVehicleFirstRegistered</para></remarks>
    /// <seealso href="http://schema.org/dateVehicleFirstRegistered">http://schema.org/dateVehicleFirstRegistered</seealso>
    let dateVehicleFirstRegistered =
        Prefixed_Name(schema1, "dateVehicleFirstRegistered") |> PrefixedName

    /// <summary>
    ///   <para>schema1:dateline</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A &lt;a href="https://en.wikipedia.org/wiki/Dateline"&gt;dateline&lt;/a&gt; is a brief piece of text included in news articles that describes where and when the story was written or filed though the date is often omitted. Sometimes only a placename is provided.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Structured representations of dateline-related information can also be expressed more explicitly using &lt;a class="localLink" href="http://schema.org/locationCreated"&gt;locationCreated&lt;/a&gt; (which represents where a work was created e.g. where a news report was written).  For location depicted or described in the content, use &lt;a class="localLink" href="http://schema.org/contentLocation"&gt;contentLocation&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Dateline summaries are oriented more towards human readers than towards automated processing, and can vary substantially. Some examples: "BEIRUT, Lebanon, June 2.", "Paris, France", "December 19, 2017 11:43AM Reporting from Washington", "Beijing/Moscow", "QUEZON CITY, Philippines".</para>
    /// labels<para>dateline</para></remarks>
    /// <seealso href="http://schema.org/dateline">http://schema.org/dateline</seealso>
    let dateline = Prefixed_Name(schema1, "dateline") |> PrefixedName
    /// <summary>
    ///   <para>schema1:defaultValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The default value of the input.  For properties that expect a literal, the default is a literal value, for properties that expect an object, it's an ID reference to one of the current values.</para>
    /// labels<para>defaultValue</para></remarks>
    /// <seealso href="http://schema.org/defaultValue">http://schema.org/defaultValue</seealso>
    let defaultValue = Prefixed_Name(schema1, "defaultValue") |> PrefixedName
    /// <summary>
    ///   <para>schema1:deliveryAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Destination address.</para>
    /// labels<para>deliveryAddress</para></remarks>
    /// <seealso href="http://schema.org/deliveryAddress">http://schema.org/deliveryAddress</seealso>
    let deliveryAddress = Prefixed_Name(schema1, "deliveryAddress") |> PrefixedName
    /// <summary>
    ///   <para>schema1:deliveryLeadTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The typical delay between the receipt of the order and the goods either leaving the warehouse or being prepared for pickup, in case the delivery method is on site pickup.</para>
    /// labels<para>deliveryLeadTime</para></remarks>
    /// <seealso href="http://schema.org/deliveryLeadTime">http://schema.org/deliveryLeadTime</seealso>
    let deliveryLeadTime = Prefixed_Name(schema1, "deliveryLeadTime") |> PrefixedName
    /// <summary>
    ///   <para>schema1:deliveryMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of instrument. The method of delivery.</para>
    /// labels<para>deliveryMethod</para></remarks>
    /// <seealso href="http://schema.org/deliveryMethod">http://schema.org/deliveryMethod</seealso>
    let deliveryMethod = Prefixed_Name(schema1, "deliveryMethod") |> PrefixedName
    /// <summary>
    ///   <para>schema1:instrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The object that helped the agent perform the action. e.g. John wrote a book with &lt;em&gt;a pen&lt;/em&gt;.</para>
    /// labels<para>instrument</para></remarks>
    /// <seealso href="http://schema.org/instrument">http://schema.org/instrument</seealso>
    let instrument = Prefixed_Name(schema1, "instrument") |> PrefixedName
    /// <summary>
    ///   <para>schema1:deliveryStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>New entry added as the package passes through each leg of its journey (from shipment to final delivery).</para>
    /// labels<para>deliveryStatus</para></remarks>
    /// <seealso href="http://schema.org/deliveryStatus">http://schema.org/deliveryStatus</seealso>
    let deliveryStatus = Prefixed_Name(schema1, "deliveryStatus") |> PrefixedName
    /// <summary>
    ///   <para>schema1:departureAirport</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The airport where the flight originates.</para>
    /// labels<para>departureAirport</para></remarks>
    /// <seealso href="http://schema.org/departureAirport">http://schema.org/departureAirport</seealso>
    let departureAirport = Prefixed_Name(schema1, "departureAirport") |> PrefixedName
    /// <summary>
    ///   <para>schema1:departureBusStop</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The stop or station from which the bus departs.</para>
    /// labels<para>departureBusStop</para></remarks>
    /// <seealso href="http://schema.org/departureBusStop">http://schema.org/departureBusStop</seealso>
    let departureBusStop = Prefixed_Name(schema1, "departureBusStop") |> PrefixedName
    /// <summary>
    ///   <para>schema1:departureGate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Identifier of the flight's departure gate.</para>
    /// labels<para>departureGate</para></remarks>
    /// <seealso href="http://schema.org/departureGate">http://schema.org/departureGate</seealso>
    let departureGate = Prefixed_Name(schema1, "departureGate") |> PrefixedName
    /// <summary>
    ///   <para>schema1:departurePlatform</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The platform from which the train departs.</para>
    /// labels<para>departurePlatform</para></remarks>
    /// <seealso href="http://schema.org/departurePlatform">http://schema.org/departurePlatform</seealso>
    let departurePlatform = Prefixed_Name(schema1, "departurePlatform") |> PrefixedName
    /// <summary>
    ///   <para>schema1:departureStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The station from which the train departs.</para>
    /// labels<para>departureStation</para></remarks>
    /// <seealso href="http://schema.org/departureStation">http://schema.org/departureStation</seealso>
    let departureStation = Prefixed_Name(schema1, "departureStation") |> PrefixedName
    /// <summary>
    ///   <para>schema1:departureTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The expected departure time.</para>
    /// labels<para>departureTime</para></remarks>
    /// <seealso href="http://schema.org/departureTime">http://schema.org/departureTime</seealso>
    let departureTime = Prefixed_Name(schema1, "departureTime") |> PrefixedName
    /// <summary>
    ///   <para>schema1:dependencies</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Prerequisites needed to fulfill steps in article.</para>
    /// labels<para>dependencies</para></remarks>
    /// <seealso href="http://schema.org/dependencies">http://schema.org/dependencies</seealso>
    let dependencies = Prefixed_Name(schema1, "dependencies") |> PrefixedName
    /// <summary>
    ///   <para>schema1:depth</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The depth of the item.</para>
    /// labels<para>depth</para></remarks>
    /// <seealso href="http://schema.org/depth">http://schema.org/depth</seealso>
    let depth = Prefixed_Name(schema1, "depth") |> PrefixedName
    /// <summary>
    ///   <para>schema1:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A description of the item.</para>
    /// labels<para>description</para></remarks>
    /// <seealso href="http://schema.org/description">http://schema.org/description</seealso>
    let description = Prefixed_Name(schema1, "description") |> PrefixedName
    /// <summary>
    ///   <para>schema1:device</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Device required to run the application. Used in cases where a specific make/model is required to run the application.</para>
    /// labels<para>device</para></remarks>
    /// <seealso href="http://schema.org/device">http://schema.org/device</seealso>
    let device = Prefixed_Name(schema1, "device") |> PrefixedName
    /// <summary>
    ///   <para>schema1:directors</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A director of e.g. tv, radio, movie, video games etc. content. Directors can be associated with individual items or with a series, episode, clip.</para>
    /// labels<para>directors</para></remarks>
    /// <seealso href="http://schema.org/directors">http://schema.org/directors</seealso>
    let directors = Prefixed_Name(schema1, "directors") |> PrefixedName

    /// <summary>
    ///   <para>schema1:disambiguatingDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of description. A short description of the item used to disambiguate from other, similar items. Information from other properties (in particular, name) may be necessary for the description to be useful for disambiguation.</para>
    /// labels<para>disambiguatingDescription</para></remarks>
    /// <seealso href="http://schema.org/disambiguatingDescription">http://schema.org/disambiguatingDescription</seealso>
    let disambiguatingDescription =
        Prefixed_Name(schema1, "disambiguatingDescription") |> PrefixedName

    /// <summary>
    ///   <para>schema1:discount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Any discount applied (to an Order).</para>
    /// labels<para>discount</para></remarks>
    /// <seealso href="http://schema.org/discount">http://schema.org/discount</seealso>
    let discount = Prefixed_Name(schema1, "discount") |> PrefixedName
    /// <summary>
    ///   <para>schema1:discountCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Code used to redeem a discount.</para>
    /// labels<para>discountCode</para></remarks>
    /// <seealso href="http://schema.org/discountCode">http://schema.org/discountCode</seealso>
    let discountCode = Prefixed_Name(schema1, "discountCode") |> PrefixedName
    /// <summary>
    ///   <para>schema1:discountCurrency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The currency of the discount.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".</para>
    /// labels<para>discountCurrency</para></remarks>
    /// <seealso href="http://schema.org/discountCurrency">http://schema.org/discountCurrency</seealso>
    let discountCurrency = Prefixed_Name(schema1, "discountCurrency") |> PrefixedName
    /// <summary>
    ///   <para>schema1:distance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The distance travelled, e.g. exercising or travelling.</para>
    /// labels<para>distance</para></remarks>
    /// <seealso href="http://schema.org/distance">http://schema.org/distance</seealso>
    let distance = Prefixed_Name(schema1, "distance") |> PrefixedName
    /// <summary>
    ///   <para>schema1:distribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A downloadable form of this dataset, at a specific location, in a specific format.</para>
    /// labels<para>distribution</para></remarks>
    /// <seealso href="http://schema.org/distribution">http://schema.org/distribution</seealso>
    let distribution = Prefixed_Name(schema1, "distribution") |> PrefixedName
    /// <summary>
    ///   <para>schema1:doorTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The time admission will commence.</para>
    /// labels<para>doorTime</para></remarks>
    /// <seealso href="http://schema.org/doorTime">http://schema.org/doorTime</seealso>
    let doorTime = Prefixed_Name(schema1, "doorTime") |> PrefixedName
    /// <summary>
    ///   <para>schema1:downloadUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>If the file can be downloaded, URL to download the binary.</para>
    /// labels<para>downloadUrl</para></remarks>
    /// <seealso href="http://schema.org/downloadUrl">http://schema.org/downloadUrl</seealso>
    let downloadUrl = Prefixed_Name(schema1, "downloadUrl") |> PrefixedName
    /// <summary>
    ///   <para>schema1:downvoteCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of downvotes this question, answer or comment has received from the community.</para>
    /// labels<para>downvoteCount</para></remarks>
    /// <seealso href="http://schema.org/downvoteCount">http://schema.org/downvoteCount</seealso>
    let downvoteCount = Prefixed_Name(schema1, "downvoteCount") |> PrefixedName

    /// <summary>
    ///   <para>schema1:driveWheelConfiguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The drive wheel configuration, i.e. which roadwheels will receive torque from the vehicle's engine via the drivetrain.</para>
    /// labels<para>driveWheelConfiguration</para></remarks>
    /// <seealso href="http://schema.org/driveWheelConfiguration">http://schema.org/driveWheelConfiguration</seealso>
    let driveWheelConfiguration =
        Prefixed_Name(schema1, "driveWheelConfiguration") |> PrefixedName

    /// <summary>
    ///   <para>schema1:dropoffLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Where a rental car can be dropped off.</para>
    /// labels<para>dropoffLocation</para></remarks>
    /// <seealso href="http://schema.org/dropoffLocation">http://schema.org/dropoffLocation</seealso>
    let dropoffLocation = Prefixed_Name(schema1, "dropoffLocation") |> PrefixedName
    /// <summary>
    ///   <para>schema1:dropoffTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>When a rental car can be dropped off.</para>
    /// labels<para>dropoffTime</para></remarks>
    /// <seealso href="http://schema.org/dropoffTime">http://schema.org/dropoffTime</seealso>
    let dropoffTime = Prefixed_Name(schema1, "dropoffTime") |> PrefixedName
    /// <summary>
    ///   <para>schema1:duns</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Dun &amp;amp; Bradstreet DUNS number for identifying an organization or business person.</para>
    /// labels<para>duns</para></remarks>
    /// <seealso href="http://schema.org/duns">http://schema.org/duns</seealso>
    let duns = Prefixed_Name(schema1, "duns") |> PrefixedName
    /// <summary>
    ///   <para>schema1:duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The duration of the item (movie, audio recording, event, etc.) in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.</para>
    /// labels<para>duration</para></remarks>
    /// <seealso href="http://schema.org/duration">http://schema.org/duration</seealso>
    let duration = Prefixed_Name(schema1, "duration") |> PrefixedName

    /// <summary>
    ///   <para>schema1:durationOfWarranty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The duration of the warranty promise. Common unitCode values are ANN for year, MON for months, or DAY for days.</para>
    /// labels<para>durationOfWarranty</para></remarks>
    /// <seealso href="http://schema.org/durationOfWarranty">http://schema.org/durationOfWarranty</seealso>
    let durationOfWarranty =
        Prefixed_Name(schema1, "durationOfWarranty") |> PrefixedName

    /// <summary>
    ///   <para>schema1:duringMedia</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A media object representing the circumstances while performing this direction.</para>
    /// labels<para>duringMedia</para></remarks>
    /// <seealso href="http://schema.org/duringMedia">http://schema.org/duringMedia</seealso>
    let duringMedia = Prefixed_Name(schema1, "duringMedia") |> PrefixedName
    /// <summary>
    ///   <para>schema1:editor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies the Person who edited the CreativeWork.</para>
    /// labels<para>editor</para></remarks>
    /// <seealso href="http://schema.org/editor">http://schema.org/editor</seealso>
    let editor = Prefixed_Name(schema1, "editor") |> PrefixedName

    /// <summary>
    ///   <para>schema1:educationalAlignment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An alignment to an established educational framework.</para>
    /// labels<para>educationalAlignment</para></remarks>
    /// <seealso href="http://schema.org/educationalAlignment">http://schema.org/educationalAlignment</seealso>
    let educationalAlignment =
        Prefixed_Name(schema1, "educationalAlignment") |> PrefixedName

    /// <summary>
    ///   <para>schema1:educationalCredentialAwarded</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A description of the qualification, award, certificate, diploma or other educational credential awarded as a consequence of successful completion of this course or program.</para>
    /// labels<para>educationalCredentialAwarded</para></remarks>
    /// <seealso href="http://schema.org/educationalCredentialAwarded">http://schema.org/educationalCredentialAwarded</seealso>
    let educationalCredentialAwarded =
        Prefixed_Name(schema1, "educationalCredentialAwarded") |> PrefixedName

    /// <summary>
    ///   <para>schema1:EducationalOccupationalCredential</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schema.org/EducationalOccupationalCredential">http://schema.org/EducationalOccupationalCredential</seealso>
    let EducationalOccupationalCredential =
        Prefixed_Name(schema1, "EducationalOccupationalCredential") |> PrefixedName

    /// <summary>
    ///   <para>schema1:educationalFramework</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The framework to which the resource being described is aligned.</para>
    /// labels<para>educationalFramework</para></remarks>
    /// <seealso href="http://schema.org/educationalFramework">http://schema.org/educationalFramework</seealso>
    let educationalFramework =
        Prefixed_Name(schema1, "educationalFramework") |> PrefixedName

    /// <summary>
    ///   <para>schema1:educationalRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An educationalRole of an EducationalAudience.</para>
    /// labels<para>educationalRole</para></remarks>
    /// <seealso href="http://schema.org/educationalRole">http://schema.org/educationalRole</seealso>
    let educationalRole = Prefixed_Name(schema1, "educationalRole") |> PrefixedName
    /// <summary>
    ///   <para>schema1:educationalUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The purpose of a work in the context of education; for example, 'assignment', 'group work'.</para>
    /// labels<para>educationalUse</para></remarks>
    /// <seealso href="http://schema.org/educationalUse">http://schema.org/educationalUse</seealso>
    let educationalUse = Prefixed_Name(schema1, "educationalUse") |> PrefixedName
    /// <summary>
    ///   <para>schema1:elevation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The elevation of a location (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;). Values may be of the form 'NUMBER UNIT&lt;em&gt;OF&lt;/em&gt;MEASUREMENT' (e.g., '1,000 m', '3,200 ft') while numbers alone should be assumed to be a value in meters.</para>
    /// labels<para>elevation</para></remarks>
    /// <seealso href="http://schema.org/elevation">http://schema.org/elevation</seealso>
    let elevation = Prefixed_Name(schema1, "elevation") |> PrefixedName

    /// <summary>
    ///   <para>schema1:eligibleCustomerType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The type(s) of customers for which the given offer is valid.</para>
    /// labels<para>eligibleCustomerType</para></remarks>
    /// <seealso href="http://schema.org/eligibleCustomerType">http://schema.org/eligibleCustomerType</seealso>
    let eligibleCustomerType =
        Prefixed_Name(schema1, "eligibleCustomerType") |> PrefixedName

    /// <summary>
    ///   <para>schema1:eligibleRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is valid.&lt;br/&gt;&lt;br/&gt;
    ///
    /// See also &lt;a class="localLink" href="http://schema.org/ineligibleRegion"&gt;ineligibleRegion&lt;/a&gt;.</para>
    /// labels<para>eligibleRegion</para></remarks>
    /// <seealso href="http://schema.org/eligibleRegion">http://schema.org/eligibleRegion</seealso>
    let eligibleRegion = Prefixed_Name(schema1, "eligibleRegion") |> PrefixedName

    /// <summary>
    ///   <para>schema1:eligibleTransactionVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The transaction volume, in a monetary unit, for which the offer or price specification is valid, e.g. for indicating a minimal purchasing volume, to express free shipping above a certain order volume, or to limit the acceptance of credit cards to purchases to a certain minimal amount.</para>
    /// labels<para>eligibleTransactionVolume</para></remarks>
    /// <seealso href="http://schema.org/eligibleTransactionVolume">http://schema.org/eligibleTransactionVolume</seealso>
    let eligibleTransactionVolume =
        Prefixed_Name(schema1, "eligibleTransactionVolume") |> PrefixedName

    /// <summary>
    ///   <para>schema1:email</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Email address.</para>
    /// labels<para>email</para></remarks>
    /// <seealso href="http://schema.org/email">http://schema.org/email</seealso>
    let email = Prefixed_Name(schema1, "email") |> PrefixedName
    /// <summary>
    ///   <para>schema1:embedUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A URL pointing to a player for a specific video. In general, this is the information in the &lt;code&gt;src&lt;/code&gt; element of an &lt;code&gt;embed&lt;/code&gt; tag and should not be the same as the content of the &lt;code&gt;loc&lt;/code&gt; tag.</para>
    /// labels<para>embedUrl</para></remarks>
    /// <seealso href="http://schema.org/embedUrl">http://schema.org/embedUrl</seealso>
    let embedUrl = Prefixed_Name(schema1, "embedUrl") |> PrefixedName
    /// <summary>
    ///   <para>schema1:employee</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Someone working for this organization.</para>
    /// labels<para>employee</para></remarks>
    /// <seealso href="http://schema.org/employee">http://schema.org/employee</seealso>
    let employee = Prefixed_Name(schema1, "employee") |> PrefixedName
    /// <summary>
    ///   <para>schema1:employees</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>People working for this organization.</para>
    /// labels<para>employees</para></remarks>
    /// <seealso href="http://schema.org/employees">http://schema.org/employees</seealso>
    let employees = Prefixed_Name(schema1, "employees") |> PrefixedName
    /// <summary>
    ///   <para>schema1:employmentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Type of employment (e.g. full-time, part-time, contract, temporary, seasonal, internship).</para>
    /// labels<para>employmentType</para></remarks>
    /// <seealso href="http://schema.org/employmentType">http://schema.org/employmentType</seealso>
    let employmentType = Prefixed_Name(schema1, "employmentType") |> PrefixedName

    /// <summary>
    ///   <para>schema1:encodesCreativeWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The CreativeWork encoded by this media object.</para>
    /// labels<para>encodesCreativeWork</para></remarks>
    /// <seealso href="http://schema.org/encodesCreativeWork">http://schema.org/encodesCreativeWork</seealso>
    let encodesCreativeWork =
        Prefixed_Name(schema1, "encodesCreativeWork") |> PrefixedName

    /// <summary>
    ///   <para>schema1:encoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A media object that encodes this CreativeWork. This property is a synonym for associatedMedia.</para>
    /// labels<para>encoding</para></remarks>
    /// <seealso href="http://schema.org/encoding">http://schema.org/encoding</seealso>
    let encoding = Prefixed_Name(schema1, "encoding") |> PrefixedName
    /// <summary>
    ///   <para>schema1:encodingFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Media type typically expressed using a MIME format (see &lt;a href="http://www.iana.org/assignments/media-types/media-types.xhtml"&gt;IANA site&lt;/a&gt; and &lt;a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Basics_of_HTTP/MIME_types"&gt;MDN reference&lt;/a&gt;) e.g. application/zip for a SoftwareApplication binary, audio/mpeg for .mp3 etc.).&lt;br/&gt;&lt;br/&gt;
    ///
    /// In cases where a &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt; has several media type representations, &lt;a class="localLink" href="http://schema.org/encoding"&gt;encoding&lt;/a&gt; can be used to indicate each &lt;a class="localLink" href="http://schema.org/MediaObject"&gt;MediaObject&lt;/a&gt; alongside particular &lt;a class="localLink" href="http://schema.org/encodingFormat"&gt;encodingFormat&lt;/a&gt; information.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Unregistered or niche encoding and file formats can be indicated instead via the most appropriate URL, e.g. defining Web page or a Wikipedia/Wikidata entry.</para>
    /// labels<para>encodingFormat</para></remarks>
    /// <seealso href="http://schema.org/encodingFormat">http://schema.org/encodingFormat</seealso>
    let encodingFormat = Prefixed_Name(schema1, "encodingFormat") |> PrefixedName
    /// <summary>
    ///   <para>schema1:encodingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The supported encoding type(s) for an EntryPoint request.</para>
    /// labels<para>encodingType</para></remarks>
    /// <seealso href="http://schema.org/encodingType">http://schema.org/encodingType</seealso>
    let encodingType = Prefixed_Name(schema1, "encodingType") |> PrefixedName
    /// <summary>
    ///   <para>schema1:endDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The end date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).</para>
    /// labels<para>endDate</para></remarks>
    /// <seealso href="http://schema.org/endDate">http://schema.org/endDate</seealso>
    let endDate = Prefixed_Name(schema1, "endDate") |> PrefixedName
    /// <summary>
    ///   <para>schema1:endTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The endTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to end. For actions that span a period of time, when the action was performed. e.g. John wrote a book from January to &lt;em&gt;December&lt;/em&gt;. For media, including audio and video, it's the time offset of the end of a clip within a larger file.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.</para>
    /// labels<para>endTime</para></remarks>
    /// <seealso href="http://schema.org/endTime">http://schema.org/endTime</seealso>
    let endTime = Prefixed_Name(schema1, "endTime") |> PrefixedName
    /// <summary>
    ///   <para>schema1:endorsee</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of participant. The person/organization being supported.</para>
    /// labels<para>endorsee</para></remarks>
    /// <seealso href="http://schema.org/endorsee">http://schema.org/endorsee</seealso>
    let endorsee = Prefixed_Name(schema1, "endorsee") |> PrefixedName

    /// <summary>
    ///   <para>schema1:entertainmentBusiness</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of location. The entertainment business where the action occurred.</para>
    /// labels<para>entertainmentBusiness</para></remarks>
    /// <seealso href="http://schema.org/entertainmentBusiness">http://schema.org/entertainmentBusiness</seealso>
    let entertainmentBusiness =
        Prefixed_Name(schema1, "entertainmentBusiness") |> PrefixedName

    /// <summary>
    ///   <para>schema1:episode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An episode of a tv, radio or game media within a series or season.</para>
    /// labels<para>episode</para></remarks>
    /// <seealso href="http://schema.org/episode">http://schema.org/episode</seealso>
    let episode = Prefixed_Name(schema1, "episode") |> PrefixedName
    /// <summary>
    ///   <para>schema1:episodeNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Position of the episode within an ordered group of episodes.</para>
    /// labels<para>episodeNumber</para></remarks>
    /// <seealso href="http://schema.org/episodeNumber">http://schema.org/episodeNumber</seealso>
    let episodeNumber = Prefixed_Name(schema1, "episodeNumber") |> PrefixedName
    /// <summary>
    ///   <para>schema1:episodes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An episode of a TV/radio series or season.</para>
    /// labels<para>episodes</para></remarks>
    /// <seealso href="http://schema.org/episodes">http://schema.org/episodes</seealso>
    let episodes = Prefixed_Name(schema1, "episodes") |> PrefixedName
    /// <summary>
    ///   <para>schema1:equal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This ordering relation for qualitative values indicates that the subject is equal to the object.</para>
    /// labels<para>equal</para></remarks>
    /// <seealso href="http://schema.org/equal">http://schema.org/equal</seealso>
    let equal = Prefixed_Name(schema1, "equal") |> PrefixedName
    /// <summary>
    ///   <para>schema1:error</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>For failed actions, more information on the cause of the failure.</para>
    /// labels<para>error</para></remarks>
    /// <seealso href="http://schema.org/error">http://schema.org/error</seealso>
    let error = Prefixed_Name(schema1, "error") |> PrefixedName
    /// <summary>
    ///   <para>schema1:estimatedCost</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The estimated cost of the supply or supplies consumed when performing instructions.</para>
    /// labels<para>estimatedCost</para></remarks>
    /// <seealso href="http://schema.org/estimatedCost">http://schema.org/estimatedCost</seealso>
    let estimatedCost = Prefixed_Name(schema1, "estimatedCost") |> PrefixedName
    /// <summary>
    ///   <para>schema1:slogan</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A slogan or motto associated with the item.</para>
    /// labels<para>slogan</para></remarks>
    /// <seealso href="http://schema.org/slogan">http://schema.org/slogan</seealso>
    let slogan = Prefixed_Name(schema1, "slogan") |> PrefixedName
    /// <summary>
    ///   <para>schema1:smokingAllowed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates whether it is allowed to smoke in the place, e.g. in the restaurant, hotel or hotel room.</para>
    /// labels<para>smokingAllowed</para></remarks>
    /// <seealso href="http://schema.org/smokingAllowed">http://schema.org/smokingAllowed</seealso>
    let smokingAllowed = Prefixed_Name(schema1, "smokingAllowed") |> PrefixedName
    /// <summary>
    ///   <para>schema1:sodiumContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of milligrams of sodium.</para>
    /// labels<para>sodiumContent</para></remarks>
    /// <seealso href="http://schema.org/sodiumContent">http://schema.org/sodiumContent</seealso>
    let sodiumContent = Prefixed_Name(schema1, "sodiumContent") |> PrefixedName
    /// <summary>
    ///   <para>schema1:softwareAddOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Additional content for a software application.</para>
    /// labels<para>softwareAddOn</para></remarks>
    /// <seealso href="http://schema.org/softwareAddOn">http://schema.org/softwareAddOn</seealso>
    let softwareAddOn = Prefixed_Name(schema1, "softwareAddOn") |> PrefixedName
    /// <summary>
    ///   <para>schema1:softwareHelp</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Software application help.</para>
    /// labels<para>softwareHelp</para></remarks>
    /// <seealso href="http://schema.org/softwareHelp">http://schema.org/softwareHelp</seealso>
    let softwareHelp = Prefixed_Name(schema1, "softwareHelp") |> PrefixedName
    /// <summary>
    ///   <para>schema1:softwareVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Version of the software instance.</para>
    /// labels<para>softwareVersion</para></remarks>
    /// <seealso href="http://schema.org/softwareVersion">http://schema.org/softwareVersion</seealso>
    let softwareVersion = Prefixed_Name(schema1, "softwareVersion") |> PrefixedName

    /// <summary>
    ///   <para>schema1:sourceOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Organization on whose behalf the creator was working.</para>
    /// labels<para>sourceOrganization</para></remarks>
    /// <seealso href="http://schema.org/sourceOrganization">http://schema.org/sourceOrganization</seealso>
    let sourceOrganization =
        Prefixed_Name(schema1, "sourceOrganization") |> PrefixedName

    /// <summary>
    ///   <para>schema1:spatial</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The "spatial" property can be used in cases when more specific properties
    /// (e.g. &lt;a class="localLink" href="http://schema.org/locationCreated"&gt;locationCreated&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/spatialCoverage"&gt;spatialCoverage&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/contentLocation"&gt;contentLocation&lt;/a&gt;) are not known to be appropriate.</para>
    /// labels<para>spatial</para></remarks>
    /// <seealso href="http://schema.org/spatial">http://schema.org/spatial</seealso>
    let spatial = Prefixed_Name(schema1, "spatial") |> PrefixedName
    /// <summary>
    ///   <para>schema1:spatialCoverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The spatialCoverage of a CreativeWork indicates the place(s) which are the focus of the content. It is a subproperty of
    ///       contentLocation intended primarily for more technical and detailed materials. For example with a Dataset, it indicates
    ///       areas that the dataset describes: a dataset of New York weather would have spatialCoverage which was the place: the state of New York.</para>
    /// labels<para>spatialCoverage</para></remarks>
    /// <seealso href="http://schema.org/spatialCoverage">http://schema.org/spatialCoverage</seealso>
    let spatialCoverage = Prefixed_Name(schema1, "spatialCoverage") |> PrefixedName
    /// <summary>
    ///   <para>schema1:speakable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates sections of a Web page that are particularly 'speakable' in the sense of being highlighted as being especially appropriate for text-to-speech conversion. Other sections of a page may also be usefully spoken in particular circumstances; the 'speakable' property serves to indicate the parts most likely to be generally useful for speech.&lt;br/&gt;&lt;br/&gt;
    ///
    /// The &lt;em&gt;speakable&lt;/em&gt; property can be repeated an arbitrary number of times, with three kinds of possible 'content-locator' values:&lt;br/&gt;&lt;br/&gt;
    ///
    /// 1.) &lt;em&gt;id-value&lt;/em&gt; URL references - uses &lt;em&gt;id-value&lt;/em&gt; of an element in the page being annotated. The simplest use of &lt;em&gt;speakable&lt;/em&gt; has (potentially relative) URL values, referencing identified sections of the document concerned.&lt;br/&gt;&lt;br/&gt;
    ///
    /// 2.) CSS Selectors - addresses content in the annotated page, eg. via class attribute. Use the &lt;a class="localLink" href="http://schema.org/cssSelector"&gt;cssSelector&lt;/a&gt; property.&lt;br/&gt;&lt;br/&gt;
    ///
    /// 3.)  XPaths - addresses content via XPaths (assuming an XML view of the content). Use the &lt;a class="localLink" href="http://schema.org/xpath"&gt;xpath&lt;/a&gt; property.&lt;br/&gt;&lt;br/&gt;
    ///
    /// For more sophisticated markup of speakable sections beyond simple ID references, either CSS selectors or XPath expressions to pick out document section(s) as speakable. For this
    /// we define a supporting type, &lt;a class="localLink" href="http://schema.org/SpeakableSpecification"&gt;SpeakableSpecification&lt;/a&gt;  which is defined to be a possible value of the &lt;em&gt;speakable&lt;/em&gt; property.</para>
    /// labels<para>speakable</para></remarks>
    /// <seealso href="http://schema.org/speakable">http://schema.org/speakable</seealso>
    let speakable = Prefixed_Name(schema1, "speakable") |> PrefixedName
    /// <summary>
    ///   <para>schema1:APIReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Reference documentation for application programming interfaces (APIs).</para>
    /// labels<para>APIReference</para></remarks>
    /// <seealso href="http://schema.org/APIReference">http://schema.org/APIReference</seealso>
    let APIReference = Prefixed_Name(schema1, "APIReference") |> PrefixedName
    /// <summary>
    ///   <para>schema1:AutoRental</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A car rental business.</para>
    /// labels<para>AutoRental</para></remarks>
    /// <seealso href="http://schema.org/AutoRental">http://schema.org/AutoRental</seealso>
    let AutoRental = Prefixed_Name(schema1, "AutoRental") |> PrefixedName
    /// <summary>
    ///   <para>schema1:DemoAlbum</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:MusicAlbumProductionType</para>
    ///   <para>DemoAlbum.</para>
    /// labels<para>DemoAlbum</para></remarks>
    /// <seealso href="http://schema.org/DemoAlbum">http://schema.org/DemoAlbum</seealso>
    let DemoAlbum = Prefixed_Name(schema1, "DemoAlbum") |> PrefixedName
    /// <summary>
    ///   <para>schema1:JoinAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An agent joins an event/group with participants/friends at a location.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/RegisterAction"&gt;RegisterAction&lt;/a&gt;: Unlike RegisterAction, JoinAction refers to joining a group/team of people.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/SubscribeAction"&gt;SubscribeAction&lt;/a&gt;: Unlike SubscribeAction, JoinAction does not imply that you'll be receiving updates.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/FollowAction"&gt;FollowAction&lt;/a&gt;: Unlike FollowAction, JoinAction does not imply that you'll be polling for updates.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>JoinAction</para></remarks>
    /// <seealso href="http://schema.org/JoinAction">http://schema.org/JoinAction</seealso>
    let JoinAction = Prefixed_Name(schema1, "JoinAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Language</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Natural languages such as Spanish, Tamil, Hindi, English, etc. Formal language code tags expressed in &lt;a href="https://en.wikipedia.org/wiki/IETF_language_tag"&gt;BCP 47&lt;/a&gt; can be used via the &lt;a class="localLink" href="http://schema.org/alternateName"&gt;alternateName&lt;/a&gt; property. The Language type previously also covered programming languages such as Scheme and Lisp, which are now best represented using &lt;a class="localLink" href="http://schema.org/ComputerLanguage"&gt;ComputerLanguage&lt;/a&gt;.</para>
    /// labels<para>Language</para></remarks>
    /// <seealso href="http://schema.org/Language">http://schema.org/Language</seealso>
    let Language = Prefixed_Name(schema1, "Language") |> PrefixedName
    /// <summary>
    ///   <para>schema1:LeaveAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An agent leaves an event / group with participants/friends at a location.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/JoinAction"&gt;JoinAction&lt;/a&gt;: The antonym of LeaveAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/UnRegisterAction"&gt;UnRegisterAction&lt;/a&gt;: Unlike UnRegisterAction, LeaveAction implies leaving a group/team of people rather than a service.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>LeaveAction</para></remarks>
    /// <seealso href="http://schema.org/LeaveAction">http://schema.org/LeaveAction</seealso>
    let LeaveAction = Prefixed_Name(schema1, "LeaveAction") |> PrefixedName

    /// <summary>
    ///   <para>schema1:LegislativeBuilding</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A legislative building&amp;#x2014;for example, the state capitol.</para>
    /// labels<para>LegislativeBuilding</para></remarks>
    /// <seealso href="http://schema.org/LegislativeBuilding">http://schema.org/LegislativeBuilding</seealso>
    let LegislativeBuilding =
        Prefixed_Name(schema1, "LegislativeBuilding") |> PrefixedName

    /// <summary>
    ///   <para>schema1:LimitedAvailability</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:ItemAvailability</para>
    ///   <para>Indicates that the item has limited availability.</para>
    /// labels<para>LimitedAvailability</para></remarks>
    /// <seealso href="http://schema.org/LimitedAvailability">http://schema.org/LimitedAvailability</seealso>
    let LimitedAvailability =
        Prefixed_Name(schema1, "LimitedAvailability") |> PrefixedName

    /// <summary>
    ///   <para>schema1:ResumeAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of resuming a device or application which was formerly paused (e.g. resume music playback or resume a timer).</para>
    /// labels<para>ResumeAction</para></remarks>
    /// <seealso href="http://schema.org/ResumeAction">http://schema.org/ResumeAction</seealso>
    let ResumeAction = Prefixed_Name(schema1, "ResumeAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ReturnAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of returning to the origin that which was previously received (concrete objects) or taken (ownership).</para>
    /// labels<para>ReturnAction</para></remarks>
    /// <seealso href="http://schema.org/ReturnAction">http://schema.org/ReturnAction</seealso>
    let ReturnAction = Prefixed_Name(schema1, "ReturnAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:RightHandDriving</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:SteeringPositionValue</para>
    ///   <para>The steering position is on the right side of the vehicle (viewed from the main direction of driving).</para>
    /// labels<para>RightHandDriving</para></remarks>
    /// <seealso href="http://schema.org/RightHandDriving">http://schema.org/RightHandDriving</seealso>
    let RightHandDriving = Prefixed_Name(schema1, "RightHandDriving") |> PrefixedName
    /// <summary>
    ///   <para>schema1:RoofingContractor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A roofing contractor.</para>
    /// labels<para>RoofingContractor</para></remarks>
    /// <seealso href="http://schema.org/RoofingContractor">http://schema.org/RoofingContractor</seealso>
    let RoofingContractor = Prefixed_Name(schema1, "RoofingContractor") |> PrefixedName
    /// <summary>
    ///   <para>schema1:RsvpResponseNo</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:RsvpResponseType</para>
    ///   <para>The invitee will not attend.</para>
    /// labels<para>RsvpResponseNo</para></remarks>
    /// <seealso href="http://schema.org/RsvpResponseNo">http://schema.org/RsvpResponseNo</seealso>
    let RsvpResponseNo = Prefixed_Name(schema1, "RsvpResponseNo") |> PrefixedName
    /// <summary>
    ///   <para>schema1:RsvpResponseYes</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:RsvpResponseType</para>
    ///   <para>The invitee will attend.</para>
    /// labels<para>RsvpResponseYes</para></remarks>
    /// <seealso href="http://schema.org/RsvpResponseYes">http://schema.org/RsvpResponseYes</seealso>
    let RsvpResponseYes = Prefixed_Name(schema1, "RsvpResponseYes") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Saturday</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:DayOfWeek</para>
    ///   <para>The day of the week between Friday and Sunday.</para>
    /// labels<para>Saturday</para></remarks>
    /// <seealso href="http://schema.org/Saturday">http://schema.org/Saturday</seealso>
    let Saturday = Prefixed_Name(schema1, "Saturday") |> PrefixedName
    /// <summary>
    ///   <para>schema1:School</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A school.</para>
    /// labels<para>School</para></remarks>
    /// <seealso href="http://schema.org/School">http://schema.org/School</seealso>
    let School = Prefixed_Name(schema1, "School") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Sculpture</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A piece of sculpture.</para>
    /// labels<para>Sculpture</para></remarks>
    /// <seealso href="http://schema.org/Sculpture">http://schema.org/Sculpture</seealso>
    let Sculpture = Prefixed_Name(schema1, "Sculpture") |> PrefixedName
    /// <summary>
    ///   <para>schema1:SeaBodyOfWater</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A sea (for example, the Caspian sea).</para>
    /// labels<para>SeaBodyOfWater</para></remarks>
    /// <seealso href="http://schema.org/SeaBodyOfWater">http://schema.org/SeaBodyOfWater</seealso>
    let SeaBodyOfWater = Prefixed_Name(schema1, "SeaBodyOfWater") |> PrefixedName
    /// <summary>
    ///   <para>schema1:accessibilityAPI</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates that the resource is compatible with the referenced accessibility API (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).</para>
    /// labels<para>accessibilityAPI</para></remarks>
    /// <seealso href="http://schema.org/accessibilityAPI">http://schema.org/accessibilityAPI</seealso>
    let accessibilityAPI = Prefixed_Name(schema1, "accessibilityAPI") |> PrefixedName

    /// <summary>
    ///   <para>schema1:accessibilityControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Identifies input methods that are sufficient to fully control the described resource (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).</para>
    /// labels<para>accessibilityControl</para></remarks>
    /// <seealso href="http://schema.org/accessibilityControl">http://schema.org/accessibilityControl</seealso>
    let accessibilityControl =
        Prefixed_Name(schema1, "accessibilityControl") |> PrefixedName

    /// <summary>
    ///   <para>schema1:accessibilityFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Content features of the resource, such as accessible media, alternatives and supported enhancements for accessibility (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).</para>
    /// labels<para>accessibilityFeature</para></remarks>
    /// <seealso href="http://schema.org/accessibilityFeature">http://schema.org/accessibilityFeature</seealso>
    let accessibilityFeature =
        Prefixed_Name(schema1, "accessibilityFeature") |> PrefixedName

    /// <summary>
    ///   <para>schema1:accessibilitySummary</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A human-readable summary of specific accessibility features or deficiencies, consistent with the other accessibility metadata but expressing subtleties such as "short descriptions are present but long descriptions will be needed for non-visual users" or "short descriptions are present and no long descriptions are needed."</para>
    /// labels<para>accessibilitySummary</para></remarks>
    /// <seealso href="http://schema.org/accessibilitySummary">http://schema.org/accessibilitySummary</seealso>
    let accessibilitySummary =
        Prefixed_Name(schema1, "accessibilitySummary") |> PrefixedName

    /// <summary>
    ///   <para>schema1:accountId</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The identifier for the account the payment will be applied to.</para>
    /// labels<para>accountId</para></remarks>
    /// <seealso href="http://schema.org/accountId">http://schema.org/accountId</seealso>
    let accountId = Prefixed_Name(schema1, "accountId") |> PrefixedName
    /// <summary>
    ///   <para>schema1:identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The identifier property represents any kind of identifier for any kind of &lt;a class="localLink" href="http://schema.org/Thing"&gt;Thing&lt;/a&gt;, such as ISBNs, GTIN codes, UUIDs etc. Schema.org provides dedicated properties for representing many of these, either as textual strings or as URL (URI) links. See &lt;a href="/docs/datamodel.html#identifierBg"&gt;background notes&lt;/a&gt; for more details.</para>
    /// labels<para>identifier</para></remarks>
    /// <seealso href="http://schema.org/identifier">http://schema.org/identifier</seealso>
    let identifier = Prefixed_Name(schema1, "identifier") |> PrefixedName

    /// <summary>
    ///   <para>schema1:actionAccessibilityRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A set of requirements that a must be fulfilled in order to perform an Action. If more than one value is specied, fulfilling one set of requirements will allow the Action to be performed.</para>
    /// labels<para>actionAccessibilityRequirement</para></remarks>
    /// <seealso href="http://schema.org/actionAccessibilityRequirement">http://schema.org/actionAccessibilityRequirement</seealso>
    let actionAccessibilityRequirement =
        Prefixed_Name(schema1, "actionAccessibilityRequirement") |> PrefixedName

    /// <summary>
    ///   <para>schema1:actionApplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An application that can complete the request.</para>
    /// labels<para>actionApplication</para></remarks>
    /// <seealso href="http://schema.org/actionApplication">http://schema.org/actionApplication</seealso>
    let actionApplication = Prefixed_Name(schema1, "actionApplication") |> PrefixedName
    /// <summary>
    ///   <para>schema1:actionPlatform</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The high level platform(s) where the Action can be performed for the given URL. To specify a specific application or operating system instance, use actionApplication.</para>
    /// labels<para>actionPlatform</para></remarks>
    /// <seealso href="http://schema.org/actionPlatform">http://schema.org/actionPlatform</seealso>
    let actionPlatform = Prefixed_Name(schema1, "actionPlatform") |> PrefixedName
    /// <summary>
    ///   <para>schema1:actionStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the current disposition of the Action.</para>
    /// labels<para>actionStatus</para></remarks>
    /// <seealso href="http://schema.org/actionStatus">http://schema.org/actionStatus</seealso>
    let actionStatus = Prefixed_Name(schema1, "actionStatus") |> PrefixedName
    /// <summary>
    ///   <para>schema1:actor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.</para>
    /// labels<para>actor</para></remarks>
    /// <seealso href="http://schema.org/actor">http://schema.org/actor</seealso>
    let actor = Prefixed_Name(schema1, "actor") |> PrefixedName
    /// <summary>
    ///   <para>schema1:comment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Comments, typically from users.</para>
    /// labels<para>comment</para></remarks>
    /// <seealso href="http://schema.org/comment">http://schema.org/comment</seealso>
    let comment = Prefixed_Name(schema1, "comment") |> PrefixedName
    /// <summary>
    ///   <para>schema1:commentCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of comments this CreativeWork (e.g. Article, Question or Answer) has received. This is most applicable to works published in Web sites with commenting system; additional comments may exist elsewhere.</para>
    /// labels<para>commentCount</para></remarks>
    /// <seealso href="http://schema.org/commentCount">http://schema.org/commentCount</seealso>
    let commentCount = Prefixed_Name(schema1, "commentCount") |> PrefixedName
    /// <summary>
    ///   <para>schema1:commentText</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The text of the UserComment.</para>
    /// labels<para>commentText</para></remarks>
    /// <seealso href="http://schema.org/commentText">http://schema.org/commentText</seealso>
    let commentText = Prefixed_Name(schema1, "commentText") |> PrefixedName
    /// <summary>
    ///   <para>schema1:geoEquals</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Represents spatial relations in which two geometries (or the places they represent) are topologically equal, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;. "Two geometries are topologically equal if their interiors intersect and no part of the interior or boundary of one geometry intersects the exterior of the other" (a symmetric relationship)</para>
    /// labels<para>geoEquals</para></remarks>
    /// <seealso href="http://schema.org/geoEquals">http://schema.org/geoEquals</seealso>
    let geoEquals = Prefixed_Name(schema1, "geoEquals") |> PrefixedName
    /// <summary>
    ///   <para>schema1:geoIntersects</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Represents spatial relations in which two geometries (or the places they represent) have at least one point in common. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.</para>
    /// labels<para>geoIntersects</para></remarks>
    /// <seealso href="http://schema.org/geoIntersects">http://schema.org/geoIntersects</seealso>
    let geoIntersects = Prefixed_Name(schema1, "geoIntersects") |> PrefixedName
    /// <summary>
    ///   <para>schema1:geoMidpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the GeoCoordinates at the centre of a GeoShape e.g. GeoCircle.</para>
    /// labels<para>geoMidpoint</para></remarks>
    /// <seealso href="http://schema.org/geoMidpoint">http://schema.org/geoMidpoint</seealso>
    let geoMidpoint = Prefixed_Name(schema1, "geoMidpoint") |> PrefixedName
    /// <summary>
    ///   <para>schema1:geoTouches</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Represents spatial relations in which two geometries (or the places they represent) touch: they have at least one boundary point in common, but no interior points." (a symmetric relationship, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt; )</para>
    /// labels<para>geoTouches</para></remarks>
    /// <seealso href="http://schema.org/geoTouches">http://schema.org/geoTouches</seealso>
    let geoTouches = Prefixed_Name(schema1, "geoTouches") |> PrefixedName
    /// <summary>
    ///   <para>schema1:geoWithin</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Represents a relationship between two geometries (or the places they represent), relating a geometry to one that contains it, i.e. it is inside (i.e. within) its interior. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.</para>
    /// labels<para>geoWithin</para></remarks>
    /// <seealso href="http://schema.org/geoWithin">http://schema.org/geoWithin</seealso>
    let geoWithin = Prefixed_Name(schema1, "geoWithin") |> PrefixedName
    /// <summary>
    ///   <para>schema1:geographicArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The geographic area associated with the audience.</para>
    /// labels<para>geographicArea</para></remarks>
    /// <seealso href="http://schema.org/geographicArea">http://schema.org/geographicArea</seealso>
    let geographicArea = Prefixed_Name(schema1, "geographicArea") |> PrefixedName
    /// <summary>
    ///   <para>schema1:givenName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Given name. In the U.S., the first name of a Person. This can be used along with familyName instead of the name property.</para>
    /// labels<para>givenName</para></remarks>
    /// <seealso href="http://schema.org/givenName">http://schema.org/givenName</seealso>
    let givenName = Prefixed_Name(schema1, "givenName") |> PrefixedName

    /// <summary>
    ///   <para>schema1:globalLocationNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The &lt;a href="http://www.gs1.org/gln"&gt;Global Location Number&lt;/a&gt; (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.</para>
    /// labels<para>globalLocationNumber</para></remarks>
    /// <seealso href="http://schema.org/globalLocationNumber">http://schema.org/globalLocationNumber</seealso>
    let globalLocationNumber =
        Prefixed_Name(schema1, "globalLocationNumber") |> PrefixedName

    /// <summary>
    ///   <para>schema1:grantee</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The person, organization, contact point, or audience that has been granted this permission.</para>
    /// labels<para>grantee</para></remarks>
    /// <seealso href="http://schema.org/grantee">http://schema.org/grantee</seealso>
    let grantee = Prefixed_Name(schema1, "grantee") |> PrefixedName
    /// <summary>
    ///   <para>schema1:greater</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This ordering relation for qualitative values indicates that the subject is greater than the object.</para>
    /// labels<para>greater</para></remarks>
    /// <seealso href="http://schema.org/greater">http://schema.org/greater</seealso>
    let greater = Prefixed_Name(schema1, "greater") |> PrefixedName
    /// <summary>
    ///   <para>schema1:greaterOrEqual</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This ordering relation for qualitative values indicates that the subject is greater than or equal to the object.</para>
    /// labels<para>greaterOrEqual</para></remarks>
    /// <seealso href="http://schema.org/greaterOrEqual">http://schema.org/greaterOrEqual</seealso>
    let greaterOrEqual = Prefixed_Name(schema1, "greaterOrEqual") |> PrefixedName
    /// <summary>
    ///   <para>schema1:gtin12</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The GTIN-12 code of the product, or the product to which the offer refers. The GTIN-12 is the 12-digit GS1 Identification Key composed of a U.P.C. Company Prefix, Item Reference, and Check Digit used to identify trade items. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.</para>
    /// labels<para>gtin12</para></remarks>
    /// <seealso href="http://schema.org/gtin12">http://schema.org/gtin12</seealso>
    let gtin12 = Prefixed_Name(schema1, "gtin12") |> PrefixedName
    /// <summary>
    ///   <para>schema1:gtin</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schema.org/gtin">http://schema.org/gtin</seealso>
    let gtin = Prefixed_Name(schema1, "gtin") |> PrefixedName
    /// <summary>
    ///   <para>schema1:gtin13</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The GTIN-13 code of the product, or the product to which the offer refers. This is equivalent to 13-digit ISBN codes and EAN UCC-13. Former 12-digit UPC codes can be converted into a GTIN-13 code by simply adding a preceeding zero. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.</para>
    /// labels<para>gtin13</para></remarks>
    /// <seealso href="http://schema.org/gtin13">http://schema.org/gtin13</seealso>
    let gtin13 = Prefixed_Name(schema1, "gtin13") |> PrefixedName
    /// <summary>
    ///   <para>schema1:gtin14</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The GTIN-14 code of the product, or the product to which the offer refers. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.</para>
    /// labels<para>gtin14</para></remarks>
    /// <seealso href="http://schema.org/gtin14">http://schema.org/gtin14</seealso>
    let gtin14 = Prefixed_Name(schema1, "gtin14") |> PrefixedName
    /// <summary>
    ///   <para>schema1:totalPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The total price for the reservation or ticket, including applicable taxes, shipping, etc.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Usage guidelines:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
    /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>totalPrice</para></remarks>
    /// <seealso href="http://schema.org/totalPrice">http://schema.org/totalPrice</seealso>
    let totalPrice = Prefixed_Name(schema1, "totalPrice") |> PrefixedName
    /// <summary>
    ///   <para>schema1:totalTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The total time required to perform instructions or a direction (including time to prepare the supplies), in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.</para>
    /// labels<para>totalTime</para></remarks>
    /// <seealso href="http://schema.org/totalTime">http://schema.org/totalTime</seealso>
    let totalTime = Prefixed_Name(schema1, "totalTime") |> PrefixedName
    /// <summary>
    ///   <para>schema1:touristType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Attraction suitable for type(s) of tourist. eg. Children, visitors from a particular country, etc.</para>
    /// labels<para>touristType</para></remarks>
    /// <seealso href="http://schema.org/touristType">http://schema.org/touristType</seealso>
    let touristType = Prefixed_Name(schema1, "touristType") |> PrefixedName

    /// <summary>
    ///   <para>schema1:TouristDestination</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schema.org/TouristDestination">http://schema.org/TouristDestination</seealso>
    let TouristDestination =
        Prefixed_Name(schema1, "TouristDestination") |> PrefixedName

    /// <summary>
    ///   <para>schema1:TouristTrip</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schema.org/TouristTrip">http://schema.org/TouristTrip</seealso>
    let TouristTrip = Prefixed_Name(schema1, "TouristTrip") |> PrefixedName
    /// <summary>
    ///   <para>schema1:track</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A music recording (track)&amp;#x2014;usually a single song. If an ItemList is given, the list should contain items of type MusicRecording.</para>
    /// labels<para>track</para></remarks>
    /// <seealso href="http://schema.org/track">http://schema.org/track</seealso>
    let track = Prefixed_Name(schema1, "track") |> PrefixedName
    /// <summary>
    ///   <para>schema1:AboutPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Web page type: About page.</para>
    /// labels<para>AboutPage</para></remarks>
    /// <seealso href="http://schema.org/AboutPage">http://schema.org/AboutPage</seealso>
    let AboutPage = Prefixed_Name(schema1, "AboutPage") |> PrefixedName
    /// <summary>
    ///   <para>schema1:BeautySalon</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Beauty salon.</para>
    /// labels<para>BeautySalon</para></remarks>
    /// <seealso href="http://schema.org/BeautySalon">http://schema.org/BeautySalon</seealso>
    let BeautySalon = Prefixed_Name(schema1, "BeautySalon") |> PrefixedName
    /// <summary>
    ///   <para>schema1:QualitativeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A predefined value for a product characteristic, e.g. the power cord plug type 'US' or the garment sizes 'S', 'M', 'L', and 'XL'.</para>
    /// labels<para>QualitativeValue</para></remarks>
    /// <seealso href="http://schema.org/QualitativeValue">http://schema.org/QualitativeValue</seealso>
    let QualitativeValue = Prefixed_Name(schema1, "QualitativeValue") |> PrefixedName
    /// <summary>
    ///   <para>schema1:BikeStore</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A bike store.</para>
    /// labels<para>BikeStore</para></remarks>
    /// <seealso href="http://schema.org/BikeStore">http://schema.org/BikeStore</seealso>
    let BikeStore = Prefixed_Name(schema1, "BikeStore") |> PrefixedName
    /// <summary>
    ///   <para>schema1:DisagreeAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of expressing a difference of opinion with the object. An agent disagrees to/about an object (a proposition, topic or theme) with participants.</para>
    /// labels<para>DisagreeAction</para></remarks>
    /// <seealso href="http://schema.org/DisagreeAction">http://schema.org/DisagreeAction</seealso>
    let DisagreeAction = Prefixed_Name(schema1, "DisagreeAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Discontinued</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:ItemAvailability</para>
    ///   <para>Indicates that the item has been discontinued.</para>
    /// labels<para>Discontinued</para></remarks>
    /// <seealso href="http://schema.org/Discontinued">http://schema.org/Discontinued</seealso>
    let Discontinued = Prefixed_Name(schema1, "Discontinued") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ItemAvailability</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A list of possible product availability options.</para>
    /// labels<para>ItemAvailability</para></remarks>
    /// <seealso href="http://schema.org/ItemAvailability">http://schema.org/ItemAvailability</seealso>
    let ItemAvailability = Prefixed_Name(schema1, "ItemAvailability") |> PrefixedName
    /// <summary>
    ///   <para>schema1:DiscoverAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of discovering/finding an object.</para>
    /// labels<para>DiscoverAction</para></remarks>
    /// <seealso href="http://schema.org/DiscoverAction">http://schema.org/DiscoverAction</seealso>
    let DiscoverAction = Prefixed_Name(schema1, "DiscoverAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:SaleEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Event type: Sales event.</para>
    /// labels<para>SaleEvent</para></remarks>
    /// <seealso href="http://schema.org/SaleEvent">http://schema.org/SaleEvent</seealso>
    let SaleEvent = Prefixed_Name(schema1, "SaleEvent") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ScheduleAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Scheduling future actions, events, or tasks.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ReserveAction"&gt;ReserveAction&lt;/a&gt;: Unlike ReserveAction, ScheduleAction allocates future actions (e.g. an event, a task, etc) towards a time slot / spatial allocation.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>ScheduleAction</para></remarks>
    /// <seealso href="http://schema.org/ScheduleAction">http://schema.org/ScheduleAction</seealso>
    let ScheduleAction = Prefixed_Name(schema1, "ScheduleAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ScholarlyArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A scholarly article.</para>
    /// labels<para>ScholarlyArticle</para></remarks>
    /// <seealso href="http://schema.org/ScholarlyArticle">http://schema.org/ScholarlyArticle</seealso>
    let ScholarlyArticle = Prefixed_Name(schema1, "ScholarlyArticle") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ScreeningEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A screening of a movie or other video.</para>
    /// labels<para>ScreeningEvent</para></remarks>
    /// <seealso href="http://schema.org/ScreeningEvent">http://schema.org/ScreeningEvent</seealso>
    let ScreeningEvent = Prefixed_Name(schema1, "ScreeningEvent") |> PrefixedName
    /// <summary>
    ///   <para>schema1:SearchAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of searching for an object.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/FindAction"&gt;FindAction&lt;/a&gt;: SearchAction generally leads to a FindAction, but not necessarily.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>SearchAction</para></remarks>
    /// <seealso href="http://schema.org/SearchAction">http://schema.org/SearchAction</seealso>
    let SearchAction = Prefixed_Name(schema1, "SearchAction") |> PrefixedName

    /// <summary>
    ///   <para>schema1:accessibilityHazard</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A characteristic of the described resource that is physiologically dangerous to some users. Related to WCAG 2.0 guideline 2.3 (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).</para>
    /// labels<para>accessibilityHazard</para></remarks>
    /// <seealso href="http://schema.org/accessibilityHazard">http://schema.org/accessibilityHazard</seealso>
    let accessibilityHazard =
        Prefixed_Name(schema1, "accessibilityHazard") |> PrefixedName

    /// <summary>
    ///   <para>schema1:accountablePerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies the Person that is legally accountable for the CreativeWork.</para>
    /// labels<para>accountablePerson</para></remarks>
    /// <seealso href="http://schema.org/accountablePerson">http://schema.org/accountablePerson</seealso>
    let accountablePerson = Prefixed_Name(schema1, "accountablePerson") |> PrefixedName
    /// <summary>
    ///   <para>schema1:acquiredFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The organization or person from which the product was acquired.</para>
    /// labels<para>acquiredFrom</para></remarks>
    /// <seealso href="http://schema.org/acquiredFrom">http://schema.org/acquiredFrom</seealso>
    let acquiredFrom = Prefixed_Name(schema1, "acquiredFrom") |> PrefixedName
    /// <summary>
    ///   <para>schema1:actionOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of object. The options subject to this action.</para>
    /// labels<para>actionOption</para></remarks>
    /// <seealso href="http://schema.org/actionOption">http://schema.org/actionOption</seealso>
    let actionOption = Prefixed_Name(schema1, "actionOption") |> PrefixedName
    /// <summary>
    ///   <para>schema1:object</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The object upon which the action is carried out, whose state is kept intact or changed. Also known as the semantic roles patient, affected or undergoer (which change their state) or theme (which doesn't). e.g. John read &lt;em&gt;a book&lt;/em&gt;.</para>
    /// labels<para>object</para></remarks>
    /// <seealso href="http://schema.org/object">http://schema.org/object</seealso>
    let object = Prefixed_Name(schema1, "object") |> PrefixedName
    /// <summary>
    ///   <para>schema1:sponsor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.</para>
    /// labels<para>sponsor</para></remarks>
    /// <seealso href="http://schema.org/sponsor">http://schema.org/sponsor</seealso>
    let sponsor = Prefixed_Name(schema1, "sponsor") |> PrefixedName
    /// <summary>
    ///   <para>schema1:game</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Video game which is played on this server.</para>
    /// labels<para>game</para></remarks>
    /// <seealso href="http://schema.org/game">http://schema.org/game</seealso>
    let game = Prefixed_Name(schema1, "game") |> PrefixedName
    /// <summary>
    ///   <para>schema1:gameServer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The server on which  it is possible to play the game.</para>
    /// labels<para>gameServer</para></remarks>
    /// <seealso href="http://schema.org/gameServer">http://schema.org/gameServer</seealso>
    let gameServer = Prefixed_Name(schema1, "gameServer") |> PrefixedName
    /// <summary>
    ///   <para>schema1:gameLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Real or fictional location of the game (or part of game).</para>
    /// labels<para>gameLocation</para></remarks>
    /// <seealso href="http://schema.org/gameLocation">http://schema.org/gameLocation</seealso>
    let gameLocation = Prefixed_Name(schema1, "gameLocation") |> PrefixedName
    /// <summary>
    ///   <para>schema1:gamePlatform</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The electronic systems used to play &lt;a href="http://en.wikipedia.org/wiki/Category:Video_game_platforms"&gt;video games&lt;/a&gt;.</para>
    /// labels<para>gamePlatform</para></remarks>
    /// <seealso href="http://schema.org/gamePlatform">http://schema.org/gamePlatform</seealso>
    let gamePlatform = Prefixed_Name(schema1, "gamePlatform") |> PrefixedName
    /// <summary>
    ///   <para>schema1:geo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The geo coordinates of the place.</para>
    /// labels<para>geo</para></remarks>
    /// <seealso href="http://schema.org/geo">http://schema.org/geo</seealso>
    let geo = Prefixed_Name(schema1, "geo") |> PrefixedName
    /// <summary>
    ///   <para>schema1:geoContains</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Represents a relationship between two geometries (or the places they represent), relating a containing geometry to a contained geometry. "a contains b iff no points of b lie in the exterior of a, and at least one point of the interior of b lies in the interior of a". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.</para>
    /// labels<para>geoContains</para></remarks>
    /// <seealso href="http://schema.org/geoContains">http://schema.org/geoContains</seealso>
    let geoContains = Prefixed_Name(schema1, "geoContains") |> PrefixedName

    /// <summary>
    ///   <para>schema1:GeospatialGeometry</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schema.org/GeospatialGeometry">http://schema.org/GeospatialGeometry</seealso>
    let GeospatialGeometry =
        Prefixed_Name(schema1, "GeospatialGeometry") |> PrefixedName

    /// <summary>
    ///   <para>schema1:geoCovers</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Represents a relationship between two geometries (or the places they represent), relating a covering geometry to a covered geometry. "Every point of b is a point of (the interior or boundary of) a". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.</para>
    /// labels<para>geoCovers</para></remarks>
    /// <seealso href="http://schema.org/geoCovers">http://schema.org/geoCovers</seealso>
    let geoCovers = Prefixed_Name(schema1, "geoCovers") |> PrefixedName
    /// <summary>
    ///   <para>schema1:geoCrosses</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Represents a relationship between two geometries (or the places they represent), relating a geometry to another that crosses it: "a crosses b: they have some but not all interior points in common, and the dimension of the intersection is less than that of at least one of them". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.</para>
    /// labels<para>geoCrosses</para></remarks>
    /// <seealso href="http://schema.org/geoCrosses">http://schema.org/geoCrosses</seealso>
    let geoCrosses = Prefixed_Name(schema1, "geoCrosses") |> PrefixedName
    /// <summary>
    ///   <para>schema1:geoDisjoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Represents spatial relations in which two geometries (or the places they represent) are topologically disjoint: they have no point in common. They form a set of disconnected geometries." (a symmetric relationship, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;)</para>
    /// labels<para>geoDisjoint</para></remarks>
    /// <seealso href="http://schema.org/geoDisjoint">http://schema.org/geoDisjoint</seealso>
    let geoDisjoint = Prefixed_Name(schema1, "geoDisjoint") |> PrefixedName
    /// <summary>
    ///   <para>schema1:geoOverlaps</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Represents a relationship between two geometries (or the places they represent), relating a geometry to another that geospatially overlaps it, i.e. they have some but not all points in common. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.</para>
    /// labels<para>geoOverlaps</para></remarks>
    /// <seealso href="http://schema.org/geoOverlaps">http://schema.org/geoOverlaps</seealso>
    let geoOverlaps = Prefixed_Name(schema1, "geoOverlaps") |> PrefixedName
    /// <summary>
    ///   <para>schema1:geoRadius</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the approximate radius of a GeoCircle (metres unless indicated otherwise via Distance notation).</para>
    /// labels<para>geoRadius</para></remarks>
    /// <seealso href="http://schema.org/geoRadius">http://schema.org/geoRadius</seealso>
    let geoRadius = Prefixed_Name(schema1, "geoRadius") |> PrefixedName
    /// <summary>
    ///   <para>schema1:orderItemStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The current status of the order item.</para>
    /// labels<para>orderItemStatus</para></remarks>
    /// <seealso href="http://schema.org/orderItemStatus">http://schema.org/orderItemStatus</seealso>
    let orderItemStatus = Prefixed_Name(schema1, "orderItemStatus") |> PrefixedName
    /// <summary>
    ///   <para>schema1:orderNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The identifier of the transaction.</para>
    /// labels<para>orderNumber</para></remarks>
    /// <seealso href="http://schema.org/orderNumber">http://schema.org/orderNumber</seealso>
    let orderNumber = Prefixed_Name(schema1, "orderNumber") |> PrefixedName
    /// <summary>
    ///   <para>schema1:orderQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of the item ordered. If the property is not set, assume the quantity is one.</para>
    /// labels<para>orderQuantity</para></remarks>
    /// <seealso href="http://schema.org/orderQuantity">http://schema.org/orderQuantity</seealso>
    let orderQuantity = Prefixed_Name(schema1, "orderQuantity") |> PrefixedName
    /// <summary>
    ///   <para>schema1:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The title of the job.</para>
    /// labels<para>title</para></remarks>
    /// <seealso href="http://schema.org/title">http://schema.org/title</seealso>
    let title = Prefixed_Name(schema1, "title") |> PrefixedName
    /// <summary>
    ///   <para>schema1:toLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of location. The final location of the object or the agent after the action.</para>
    /// labels<para>toLocation</para></remarks>
    /// <seealso href="http://schema.org/toLocation">http://schema.org/toLocation</seealso>
    let toLocation = Prefixed_Name(schema1, "toLocation") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Place</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Entities that have a somewhat fixed, physical extension.</para>
    /// labels<para>Place</para></remarks>
    /// <seealso href="http://schema.org/Place">http://schema.org/Place</seealso>
    let Place = Prefixed_Name(schema1, "Place") |> PrefixedName

    /// <summary>
    ///   <para>schema1:BroadcastFrequencySpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The frequency in MHz and the modulation used for a particular BroadcastService.</para>
    /// labels<para>BroadcastFrequencySpecification</para></remarks>
    /// <seealso href="http://schema.org/BroadcastFrequencySpecification">http://schema.org/BroadcastFrequencySpecification</seealso>
    let BroadcastFrequencySpecification =
        Prefixed_Name(schema1, "BroadcastFrequencySpecification") |> PrefixedName

    /// <summary>
    ///   <para>schema1:OrganizationRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A subclass of Role used to describe roles within organizations.</para>
    /// labels<para>OrganizationRole</para></remarks>
    /// <seealso href="http://schema.org/OrganizationRole">http://schema.org/OrganizationRole</seealso>
    let OrganizationRole = Prefixed_Name(schema1, "OrganizationRole") |> PrefixedName
    /// <summary>
    ///   <para>schema1:EmploymentAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An employment agency.</para>
    /// labels<para>EmploymentAgency</para></remarks>
    /// <seealso href="http://schema.org/EmploymentAgency">http://schema.org/EmploymentAgency</seealso>
    let EmploymentAgency = Prefixed_Name(schema1, "EmploymentAgency") |> PrefixedName
    /// <summary>
    ///   <para>schema1:EndorsementRating</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An EndorsementRating is a rating that expresses some level of endorsement, for example inclusion in a "critic's pick" blog, a
    /// "Like" or "+1" on a social network. It can be considered the &lt;a class="localLink" href="http://schema.org/result"&gt;result&lt;/a&gt; of an &lt;a class="localLink" href="http://schema.org/EndorseAction"&gt;EndorseAction&lt;/a&gt; in which the &lt;a class="localLink" href="http://schema.org/object"&gt;object&lt;/a&gt; of the action is rated positively by
    /// some &lt;a class="localLink" href="http://schema.org/agent"&gt;agent&lt;/a&gt;. As is common elsewhere in schema.org, it is sometimes more useful to describe the results of such an action without explicitly describing the &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
    ///
    /// An &lt;a class="localLink" href="http://schema.org/EndorsementRating"&gt;EndorsementRating&lt;/a&gt; may be part of a numeric scale or organized system, but this is not required: having an explicit type for indicating a positive,
    /// endorsement rating is particularly useful in the absence of numeric scales as it helps consumers understand that the rating is broadly positive.</para>
    /// labels<para>EndorsementRating</para></remarks>
    /// <seealso href="http://schema.org/EndorsementRating">http://schema.org/EndorsementRating</seealso>
    let EndorsementRating = Prefixed_Name(schema1, "EndorsementRating") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Energy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Properties that take Energy as values are of the form '&amp;lt;Number&amp;gt; &amp;lt;Energy unit of measure&amp;gt;'.</para>
    /// labels<para>Energy</para></remarks>
    /// <seealso href="http://schema.org/Energy">http://schema.org/Energy</seealso>
    let Energy = Prefixed_Name(schema1, "Energy") |> PrefixedName
    /// <summary>
    ///   <para>schema1:EntryPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An entry point, within some Web-based protocol.</para>
    /// labels<para>EntryPoint</para></remarks>
    /// <seealso href="http://schema.org/EntryPoint">http://schema.org/EntryPoint</seealso>
    let EntryPoint = Prefixed_Name(schema1, "EntryPoint") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Episode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A media episode (e.g. TV, radio, video game) which can be part of a series or season.</para>
    /// labels<para>Episode</para></remarks>
    /// <seealso href="http://schema.org/Episode">http://schema.org/Episode</seealso>
    let Episode = Prefixed_Name(schema1, "Episode") |> PrefixedName
    /// <summary>
    ///   <para>schema1:EventStatusType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>EventStatusType is an enumeration type whose instances represent several states that an Event may be in.</para>
    /// labels<para>EventStatusType</para></remarks>
    /// <seealso href="http://schema.org/EventStatusType">http://schema.org/EventStatusType</seealso>
    let EventStatusType = Prefixed_Name(schema1, "EventStatusType") |> PrefixedName
    /// <summary>
    ///   <para>schema1:EventMovedOnline</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:EventStatusType</para>
    ///   <para>Indicates that the event was changed to allow online participation. See &lt;a class="localLink" href="http://schema.org/eventAttendanceMode"&gt;eventAttendanceMode&lt;/a&gt; for specifics of whether it is now fully or partially online.</para>
    /// labels<para>EventMovedOnline</para></remarks>
    /// <seealso href="http://schema.org/EventMovedOnline">http://schema.org/EventMovedOnline</seealso>
    let EventMovedOnline = Prefixed_Name(schema1, "EventMovedOnline") |> PrefixedName
    /// <summary>
    ///   <para>schema1:EventReservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A reservation for an event like a concert, sporting event, or lecture.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use &lt;a class="localLink" href="http://schema.org/Offer"&gt;Offer&lt;/a&gt;.</para>
    /// labels<para>EventReservation</para></remarks>
    /// <seealso href="http://schema.org/EventReservation">http://schema.org/EventReservation</seealso>
    let EventReservation = Prefixed_Name(schema1, "EventReservation") |> PrefixedName
    /// <summary>
    ///   <para>schema1:EventScheduled</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:EventStatusType</para>
    ///   <para>The event is taking place or has taken place on the startDate as scheduled. Use of this value is optional, as it is assumed by default.</para>
    /// labels<para>EventScheduled</para></remarks>
    /// <seealso href="http://schema.org/EventScheduled">http://schema.org/EventScheduled</seealso>
    let EventScheduled = Prefixed_Name(schema1, "EventScheduled") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ExerciseAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of participating in exertive activity for the purposes of improving health and fitness.</para>
    /// labels<para>ExerciseAction</para></remarks>
    /// <seealso href="http://schema.org/ExerciseAction">http://schema.org/ExerciseAction</seealso>
    let ExerciseAction = Prefixed_Name(schema1, "ExerciseAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:PlayAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of playing/exercising/training/performing for enjoyment, leisure, recreation, Competition or exercise.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ListenAction"&gt;ListenAction&lt;/a&gt;: Unlike ListenAction (which is under ConsumeAction), PlayAction refers to performing for an audience or at an event, rather than consuming music.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/WatchAction"&gt;WatchAction&lt;/a&gt;: Unlike WatchAction (which is under ConsumeAction), PlayAction refers to showing/displaying for an audience or at an event, rather than consuming visual content.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>PlayAction</para></remarks>
    /// <seealso href="http://schema.org/PlayAction">http://schema.org/PlayAction</seealso>
    let PlayAction = Prefixed_Name(schema1, "PlayAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:FAQPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A &lt;a class="localLink" href="http://schema.org/FAQPage"&gt;FAQPage&lt;/a&gt; is a &lt;a class="localLink" href="http://schema.org/WebPage"&gt;WebPage&lt;/a&gt; presenting one or more "&lt;a href="https://en.wikipedia.org/wiki/FAQ"&gt;Frequently asked questions&lt;/a&gt;" (see also &lt;a class="localLink" href="http://schema.org/QAPage"&gt;QAPage&lt;/a&gt;).</para>
    /// labels<para>FAQPage</para></remarks>
    /// <seealso href="http://schema.org/FAQPage">http://schema.org/FAQPage</seealso>
    let FAQPage = Prefixed_Name(schema1, "FAQPage") |> PrefixedName
    /// <summary>
    ///   <para>schema1:FMRadioChannel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A radio channel that uses FM.</para>
    /// labels<para>FMRadioChannel</para></remarks>
    /// <seealso href="http://schema.org/FMRadioChannel">http://schema.org/FMRadioChannel</seealso>
    let FMRadioChannel = Prefixed_Name(schema1, "FMRadioChannel") |> PrefixedName

    /// <summary>
    ///   <para>schema1:FailedActionStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:ActionStatusType</para>
    ///   <para>An action that failed to complete. The action's error property and the HTTP return code contain more information about the failure.</para>
    /// labels<para>FailedActionStatus</para></remarks>
    /// <seealso href="http://schema.org/FailedActionStatus">http://schema.org/FailedActionStatus</seealso>
    let FailedActionStatus =
        Prefixed_Name(schema1, "FailedActionStatus") |> PrefixedName

    /// <summary>
    ///   <para>schema1:False</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Boolean</para>
    ///   <para>The boolean value false.</para>
    /// labels<para>False</para></remarks>
    /// <seealso href="http://schema.org/False">http://schema.org/False</seealso>
    let False = Prefixed_Name(schema1, "False") |> PrefixedName

    /// <summary>
    ///   <para>schema1:FastFoodRestaurant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A fast-food restaurant.</para>
    /// labels<para>FastFoodRestaurant</para></remarks>
    /// <seealso href="http://schema.org/FastFoodRestaurant">http://schema.org/FastFoodRestaurant</seealso>
    let FastFoodRestaurant =
        Prefixed_Name(schema1, "FastFoodRestaurant") |> PrefixedName

    /// <summary>
    ///   <para>schema1:Female</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:GenderType</para>
    ///   <para>The female gender.</para>
    /// labels<para>Female</para></remarks>
    /// <seealso href="http://schema.org/Female">http://schema.org/Female</seealso>
    let Female = Prefixed_Name(schema1, "Female") |> PrefixedName
    /// <summary>
    ///   <para>schema1:GenderType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An enumeration of genders.</para>
    /// labels<para>GenderType</para></remarks>
    /// <seealso href="http://schema.org/GenderType">http://schema.org/GenderType</seealso>
    let GenderType = Prefixed_Name(schema1, "GenderType") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Festival</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Event type: Festival.</para>
    /// labels<para>Festival</para></remarks>
    /// <seealso href="http://schema.org/Festival">http://schema.org/Festival</seealso>
    let Festival = Prefixed_Name(schema1, "Festival") |> PrefixedName
    /// <summary>
    ///   <para>schema1:FireStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A fire station. With firemen.</para>
    /// labels<para>FireStation</para></remarks>
    /// <seealso href="http://schema.org/FireStation">http://schema.org/FireStation</seealso>
    let FireStation = Prefixed_Name(schema1, "FireStation") |> PrefixedName
    /// <summary>
    ///   <para>schema1:FlightReservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A reservation for air travel.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use &lt;a class="localLink" href="http://schema.org/Offer"&gt;Offer&lt;/a&gt;.</para>
    /// labels<para>FlightReservation</para></remarks>
    /// <seealso href="http://schema.org/FlightReservation">http://schema.org/FlightReservation</seealso>
    let FlightReservation = Prefixed_Name(schema1, "FlightReservation") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Float</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Data type: Floating number.</para>
    /// labels<para>Float</para></remarks>
    /// <seealso href="http://schema.org/Float">http://schema.org/Float</seealso>
    let Float = Prefixed_Name(schema1, "Float") |> PrefixedName
    /// <summary>
    ///   <para>schema1:FollowAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of forming a personal connection with someone/something (object) unidirectionally/asymmetrically to get updates polled from.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/BefriendAction"&gt;BefriendAction&lt;/a&gt;: Unlike BefriendAction, FollowAction implies that the connection is &lt;em&gt;not&lt;/em&gt; necessarily reciprocal.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/SubscribeAction"&gt;SubscribeAction&lt;/a&gt;: Unlike SubscribeAction, FollowAction implies that the follower acts as an active agent constantly/actively polling for updates.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/RegisterAction"&gt;RegisterAction&lt;/a&gt;: Unlike RegisterAction, FollowAction implies that the agent is interested in continuing receiving updates from the object.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/JoinAction"&gt;JoinAction&lt;/a&gt;: Unlike JoinAction, FollowAction implies that the agent is interested in getting updates from the object.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/TrackAction"&gt;TrackAction&lt;/a&gt;: Unlike TrackAction, FollowAction refers to the polling of updates of all aspects of animate objects rather than the location of inanimate objects (e.g. you track a package, but you don't follow it).&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>FollowAction</para></remarks>
    /// <seealso href="http://schema.org/FollowAction">http://schema.org/FollowAction</seealso>
    let FollowAction = Prefixed_Name(schema1, "FollowAction") |> PrefixedName

    /// <summary>
    ///   <para>schema1:FoodEstablishmentReservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A reservation to dine at a food-related business.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.</para>
    /// labels<para>FoodEstablishmentReservation</para></remarks>
    /// <seealso href="http://schema.org/FoodEstablishmentReservation">http://schema.org/FoodEstablishmentReservation</seealso>
    let FoodEstablishmentReservation =
        Prefixed_Name(schema1, "FoodEstablishmentReservation") |> PrefixedName

    /// <summary>
    ///   <para>schema1:FourWheelDriveConfiguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:DriveWheelConfigurationValue</para>
    ///   <para>Four-wheel drive is a transmission layout where the engine primarily drives two wheels with a part-time four-wheel drive capability.</para>
    /// labels<para>FourWheelDriveConfiguration</para></remarks>
    /// <seealso href="http://schema.org/FourWheelDriveConfiguration">http://schema.org/FourWheelDriveConfiguration</seealso>
    let FourWheelDriveConfiguration =
        Prefixed_Name(schema1, "FourWheelDriveConfiguration") |> PrefixedName

    /// <summary>
    ///   <para>schema1:Friday</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:DayOfWeek</para>
    ///   <para>The day of the week between Thursday and Saturday.</para>
    /// labels<para>Friday</para></remarks>
    /// <seealso href="http://schema.org/Friday">http://schema.org/Friday</seealso>
    let Friday = Prefixed_Name(schema1, "Friday") |> PrefixedName
    /// <summary>
    ///   <para>schema1:sameAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>URL of a reference Web page that unambiguously indicates the item's identity. E.g. the URL of the item's Wikipedia page, Wikidata entry, or official website.</para>
    /// labels<para>sameAs</para></remarks>
    /// <seealso href="http://schema.org/sameAs">http://schema.org/sameAs</seealso>
    let sameAs = Prefixed_Name(schema1, "sameAs") |> PrefixedName
    /// <summary>
    ///   <para>schema1:FurnitureStore</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A furniture store.</para>
    /// labels<para>FurnitureStore</para></remarks>
    /// <seealso href="http://schema.org/FurnitureStore">http://schema.org/FurnitureStore</seealso>
    let FurnitureStore = Prefixed_Name(schema1, "FurnitureStore") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Game</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The Game type represents things which are games. These are typically rule-governed recreational activities, e.g. role-playing games in which players assume the role of characters in a fictional setting.</para>
    /// labels<para>Game</para></remarks>
    /// <seealso href="http://schema.org/Game">http://schema.org/Game</seealso>
    let Game = Prefixed_Name(schema1, "Game") |> PrefixedName
    /// <summary>
    ///   <para>schema1:GameServerStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Status of a game server.</para>
    /// labels<para>GameServerStatus</para></remarks>
    /// <seealso href="http://schema.org/GameServerStatus">http://schema.org/GameServerStatus</seealso>
    let GameServerStatus = Prefixed_Name(schema1, "GameServerStatus") |> PrefixedName
    /// <summary>
    ///   <para>schema1:GardenStore</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A garden store.</para>
    /// labels<para>GardenStore</para></remarks>
    /// <seealso href="http://schema.org/GardenStore">http://schema.org/GardenStore</seealso>
    let GardenStore = Prefixed_Name(schema1, "GardenStore") |> PrefixedName
    /// <summary>
    ///   <para>schema1:GasStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A gas station.</para>
    /// labels<para>GasStation</para></remarks>
    /// <seealso href="http://schema.org/GasStation">http://schema.org/GasStation</seealso>
    let GasStation = Prefixed_Name(schema1, "GasStation") |> PrefixedName
    /// <summary>
    ///   <para>schema1:GeneralContractor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A general contractor.</para>
    /// labels<para>GeneralContractor</para></remarks>
    /// <seealso href="http://schema.org/GeneralContractor">http://schema.org/GeneralContractor</seealso>
    let GeneralContractor = Prefixed_Name(schema1, "GeneralContractor") |> PrefixedName
    /// <summary>
    ///   <para>schema1:GeoCircle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A GeoCircle is a GeoShape representing a circular geographic area. As it is a GeoShape
    ///           it provides the simple textual property 'circle', but also allows the combination of postalCode alongside geoRadius.
    ///           The center of the circle can be indicated via the 'geoMidpoint' property, or more approximately using 'address', 'postalCode'.</para>
    /// labels<para>GeoCircle</para></remarks>
    /// <seealso href="http://schema.org/GeoCircle">http://schema.org/GeoCircle</seealso>
    let GeoCircle = Prefixed_Name(schema1, "GeoCircle") |> PrefixedName
    /// <summary>
    ///   <para>schema1:GiveAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of transferring ownership of an object to a destination. Reciprocal of TakeAction.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/TakeAction"&gt;TakeAction&lt;/a&gt;: Reciprocal of GiveAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/SendAction"&gt;SendAction&lt;/a&gt;: Unlike SendAction, GiveAction implies that ownership is being transferred (e.g. I may send my laptop to you, but that doesn't mean I'm giving it to you).&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>GiveAction</para></remarks>
    /// <seealso href="http://schema.org/GiveAction">http://schema.org/GiveAction</seealso>
    let GiveAction = Prefixed_Name(schema1, "GiveAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:GlutenFreeDiet</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:RestrictedDiet</para>
    ///   <para>A diet exclusive of gluten.</para>
    /// labels<para>GlutenFreeDiet</para></remarks>
    /// <seealso href="http://schema.org/GlutenFreeDiet">http://schema.org/GlutenFreeDiet</seealso>
    let GlutenFreeDiet = Prefixed_Name(schema1, "GlutenFreeDiet") |> PrefixedName
    /// <summary>
    ///   <para>schema1:GolfCourse</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A golf course.</para>
    /// labels<para>GolfCourse</para></remarks>
    /// <seealso href="http://schema.org/GolfCourse">http://schema.org/GolfCourse</seealso>
    let GolfCourse = Prefixed_Name(schema1, "GolfCourse") |> PrefixedName
    /// <summary>
    ///   <para>schema1:GovernmentOffice</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A government office&amp;#x2014;for example, an IRS or DMV office.</para>
    /// labels<para>GovernmentOffice</para></remarks>
    /// <seealso href="http://schema.org/GovernmentOffice">http://schema.org/GovernmentOffice</seealso>
    let GovernmentOffice = Prefixed_Name(schema1, "GovernmentOffice") |> PrefixedName
    /// <summary>
    ///   <para>schema1:GovernmentPermit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A permit issued by a government agency.</para>
    /// labels<para>GovernmentPermit</para></remarks>
    /// <seealso href="http://schema.org/GovernmentPermit">http://schema.org/GovernmentPermit</seealso>
    let GovernmentPermit = Prefixed_Name(schema1, "GovernmentPermit") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Permit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A permit issued by an organization, e.g. a parking pass.</para>
    /// labels<para>Permit</para></remarks>
    /// <seealso href="http://schema.org/Permit">http://schema.org/Permit</seealso>
    let Permit = Prefixed_Name(schema1, "Permit") |> PrefixedName
    /// <summary>
    ///   <para>schema1:GovernmentService</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A service provided by a government organization, e.g. food stamps, veterans benefits, etc.</para>
    /// labels<para>GovernmentService</para></remarks>
    /// <seealso href="http://schema.org/GovernmentService">http://schema.org/GovernmentService</seealso>
    let GovernmentService = Prefixed_Name(schema1, "GovernmentService") |> PrefixedName
    /// <summary>
    ///   <para>schema1:GroceryStore</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A grocery store.</para>
    /// labels<para>GroceryStore</para></remarks>
    /// <seealso href="http://schema.org/GroceryStore">http://schema.org/GroceryStore</seealso>
    let GroceryStore = Prefixed_Name(schema1, "GroceryStore") |> PrefixedName

    /// <summary>
    ///   <para>schema1:GroupBoardingPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:BoardingPolicyType</para>
    ///   <para>The airline boards by groups based on check-in time, priority, etc.</para>
    /// labels<para>GroupBoardingPolicy</para></remarks>
    /// <seealso href="http://schema.org/GroupBoardingPolicy">http://schema.org/GroupBoardingPolicy</seealso>
    let GroupBoardingPolicy =
        Prefixed_Name(schema1, "GroupBoardingPolicy") |> PrefixedName

    /// <summary>
    ///   <para>schema1:HVACBusiness</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A business that provide Heating, Ventilation and Air Conditioning services.</para>
    /// labels<para>HVACBusiness</para></remarks>
    /// <seealso href="http://schema.org/HVACBusiness">http://schema.org/HVACBusiness</seealso>
    let HVACBusiness = Prefixed_Name(schema1, "HVACBusiness") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Hardcover</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:BookFormatType</para>
    ///   <para>Book format: Hardcover.</para>
    /// labels<para>Hardcover</para></remarks>
    /// <seealso href="http://schema.org/Hardcover">http://schema.org/Hardcover</seealso>
    let Hardcover = Prefixed_Name(schema1, "Hardcover") |> PrefixedName
    /// <summary>
    ///   <para>schema1:HardwareStore</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A hardware store.</para>
    /// labels<para>HardwareStore</para></remarks>
    /// <seealso href="http://schema.org/HardwareStore">http://schema.org/HardwareStore</seealso>
    let HardwareStore = Prefixed_Name(schema1, "HardwareStore") |> PrefixedName
    /// <summary>
    ///   <para>schema1:HealthClub</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A health club.</para>
    /// labels<para>HealthClub</para></remarks>
    /// <seealso href="http://schema.org/HealthClub">http://schema.org/HealthClub</seealso>
    let HealthClub = Prefixed_Name(schema1, "HealthClub") |> PrefixedName

    /// <summary>
    ///   <para>schema1:HearingImpairedSupported</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:ContactPointOption</para>
    ///   <para>Uses devices to support users with hearing impairments.</para>
    /// labels<para>HearingImpairedSupported</para></remarks>
    /// <seealso href="http://schema.org/HearingImpairedSupported">http://schema.org/HearingImpairedSupported</seealso>
    let HearingImpairedSupported =
        Prefixed_Name(schema1, "HearingImpairedSupported") |> PrefixedName

    /// <summary>
    ///   <para>schema1:HighSchool</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A high school.</para>
    /// labels<para>HighSchool</para></remarks>
    /// <seealso href="http://schema.org/HighSchool">http://schema.org/HighSchool</seealso>
    let HighSchool = Prefixed_Name(schema1, "HighSchool") |> PrefixedName
    /// <summary>
    ///   <para>schema1:HinduDiet</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:RestrictedDiet</para>
    ///   <para>A diet conforming to Hindu dietary practices, in particular, beef-free.</para>
    /// labels<para>HinduDiet</para></remarks>
    /// <seealso href="http://schema.org/HinduDiet">http://schema.org/HinduDiet</seealso>
    let HinduDiet = Prefixed_Name(schema1, "HinduDiet") |> PrefixedName
    /// <summary>
    ///   <para>schema1:HinduTemple</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Hindu temple.</para>
    /// labels<para>HinduTemple</para></remarks>
    /// <seealso href="http://schema.org/HinduTemple">http://schema.org/HinduTemple</seealso>
    let HinduTemple = Prefixed_Name(schema1, "HinduTemple") |> PrefixedName
    /// <summary>
    ///   <para>schema1:HobbyShop</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A store that sells materials useful or necessary for various hobbies.</para>
    /// labels<para>HobbyShop</para></remarks>
    /// <seealso href="http://schema.org/HobbyShop">http://schema.org/HobbyShop</seealso>
    let HobbyShop = Prefixed_Name(schema1, "HobbyShop") |> PrefixedName
    /// <summary>
    ///   <para>schema1:HomeGoodsStore</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A home goods store.</para>
    /// labels<para>HomeGoodsStore</para></remarks>
    /// <seealso href="http://schema.org/HomeGoodsStore">http://schema.org/HomeGoodsStore</seealso>
    let HomeGoodsStore = Prefixed_Name(schema1, "HomeGoodsStore") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Hospital</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A hospital.</para>
    /// labels<para>Hospital</para></remarks>
    /// <seealso href="http://schema.org/Hospital">http://schema.org/Hospital</seealso>
    let Hospital = Prefixed_Name(schema1, "Hospital") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Hotel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A hotel is an establishment that provides lodging paid on a short-term basis (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Hotel).
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.</para>
    /// labels<para>Hotel</para></remarks>
    /// <seealso href="http://schema.org/Hotel">http://schema.org/Hotel</seealso>
    let Hotel = Prefixed_Name(schema1, "Hotel") |> PrefixedName
    /// <summary>
    ///   <para>schema1:HotelRoom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A hotel room is a single room in a hotel.
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.</para>
    /// labels<para>HotelRoom</para></remarks>
    /// <seealso href="http://schema.org/HotelRoom">http://schema.org/HotelRoom</seealso>
    let HotelRoom = Prefixed_Name(schema1, "HotelRoom") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Room</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A room is a distinguishable space within a structure, usually separated from other spaces by interior walls. (Source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Room"&gt;http://en.wikipedia.org/wiki/Room&lt;/a&gt;).
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.</para>
    /// labels<para>Room</para></remarks>
    /// <seealso href="http://schema.org/Room">http://schema.org/Room</seealso>
    let Room = Prefixed_Name(schema1, "Room") |> PrefixedName
    /// <summary>
    ///   <para>schema1:House</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A house is a building or structure that has the ability to be occupied for habitation by humans or other creatures (Source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/House"&gt;http://en.wikipedia.org/wiki/House&lt;/a&gt;).</para>
    /// labels<para>House</para></remarks>
    /// <seealso href="http://schema.org/House">http://schema.org/House</seealso>
    let House = Prefixed_Name(schema1, "House") |> PrefixedName
    /// <summary>
    ///   <para>schema1:HousePainter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A house painting service.</para>
    /// labels<para>HousePainter</para></remarks>
    /// <seealso href="http://schema.org/HousePainter">http://schema.org/HousePainter</seealso>
    let HousePainter = Prefixed_Name(schema1, "HousePainter") |> PrefixedName
    /// <summary>
    ///   <para>schema1:HowTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Instructions that explain how to achieve a result by performing a sequence of steps.</para>
    /// labels<para>HowTo</para></remarks>
    /// <seealso href="http://schema.org/HowTo">http://schema.org/HowTo</seealso>
    let HowTo = Prefixed_Name(schema1, "HowTo") |> PrefixedName
    /// <summary>
    ///   <para>schema1:HowToSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A sub-grouping of steps in the instructions for how to achieve a result (e.g. steps for making a pie crust within a pie recipe).</para>
    /// labels<para>HowToSection</para></remarks>
    /// <seealso href="http://schema.org/HowToSection">http://schema.org/HowToSection</seealso>
    let HowToSection = Prefixed_Name(schema1, "HowToSection") |> PrefixedName
    /// <summary>
    ///   <para>schema1:HowToStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A step in the instructions for how to achieve a result. It is an ordered list with HowToDirection and/or HowToTip items.</para>
    /// labels<para>HowToStep</para></remarks>
    /// <seealso href="http://schema.org/HowToStep">http://schema.org/HowToStep</seealso>
    let HowToStep = Prefixed_Name(schema1, "HowToStep") |> PrefixedName
    /// <summary>
    ///   <para>schema1:HowToSupply</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A supply consumed when performing the instructions for how to achieve a result.</para>
    /// labels<para>HowToSupply</para></remarks>
    /// <seealso href="http://schema.org/HowToSupply">http://schema.org/HowToSupply</seealso>
    let HowToSupply = Prefixed_Name(schema1, "HowToSupply") |> PrefixedName
    /// <summary>
    ///   <para>schema1:HowToTip</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An explanation in the instructions for how to achieve a result. It provides supplementary information about a technique, supply, author's preference, etc. It can explain what could be done, or what should not be done, but doesn't specify what should be done (see HowToDirection).</para>
    /// labels<para>HowToTip</para></remarks>
    /// <seealso href="http://schema.org/HowToTip">http://schema.org/HowToTip</seealso>
    let HowToTip = Prefixed_Name(schema1, "HowToTip") |> PrefixedName
    /// <summary>
    ///   <para>schema1:HowToTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A tool used (but not consumed) when performing instructions for how to achieve a result.</para>
    /// labels<para>HowToTool</para></remarks>
    /// <seealso href="http://schema.org/HowToTool">http://schema.org/HowToTool</seealso>
    let HowToTool = Prefixed_Name(schema1, "HowToTool") |> PrefixedName
    /// <summary>
    ///   <para>schema1:IceCreamShop</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An ice cream shop.</para>
    /// labels<para>IceCreamShop</para></remarks>
    /// <seealso href="http://schema.org/IceCreamShop">http://schema.org/IceCreamShop</seealso>
    let IceCreamShop = Prefixed_Name(schema1, "IceCreamShop") |> PrefixedName
    /// <summary>
    ///   <para>schema1:IgnoreAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of intentionally disregarding the object. An agent ignores an object.</para>
    /// labels<para>IgnoreAction</para></remarks>
    /// <seealso href="http://schema.org/IgnoreAction">http://schema.org/IgnoreAction</seealso>
    let IgnoreAction = Prefixed_Name(schema1, "IgnoreAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ImageGallery</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Web page type: Image gallery page.</para>
    /// labels<para>ImageGallery</para></remarks>
    /// <seealso href="http://schema.org/ImageGallery">http://schema.org/ImageGallery</seealso>
    let ImageGallery = Prefixed_Name(schema1, "ImageGallery") |> PrefixedName
    /// <summary>
    ///   <para>schema1:MediaGallery</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Web page type: Media gallery page. A mixed-media page that can contains media such as images, videos, and other multimedia.</para>
    /// labels<para>MediaGallery</para></remarks>
    /// <seealso href="http://schema.org/MediaGallery">http://schema.org/MediaGallery</seealso>
    let MediaGallery = Prefixed_Name(schema1, "MediaGallery") |> PrefixedName
    /// <summary>
    ///   <para>schema1:InStock</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:ItemAvailability</para>
    ///   <para>Indicates that the item is in stock.</para>
    /// labels<para>InStock</para></remarks>
    /// <seealso href="http://schema.org/InStock">http://schema.org/InStock</seealso>
    let InStock = Prefixed_Name(schema1, "InStock") |> PrefixedName
    /// <summary>
    ///   <para>schema1:IndividualProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A single, identifiable product instance (e.g. a laptop with a particular serial number).</para>
    /// labels<para>IndividualProduct</para></remarks>
    /// <seealso href="http://schema.org/IndividualProduct">http://schema.org/IndividualProduct</seealso>
    let IndividualProduct = Prefixed_Name(schema1, "IndividualProduct") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Product</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.</para>
    /// labels<para>Product</para></remarks>
    /// <seealso href="http://schema.org/Product">http://schema.org/Product</seealso>
    let Product = Prefixed_Name(schema1, "Product") |> PrefixedName
    /// <summary>
    ///   <para>schema1:InstallAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of installing an application.</para>
    /// labels<para>InstallAction</para></remarks>
    /// <seealso href="http://schema.org/InstallAction">http://schema.org/InstallAction</seealso>
    let InstallAction = Prefixed_Name(schema1, "InstallAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:InsuranceAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An Insurance agency.</para>
    /// labels<para>InsuranceAgency</para></remarks>
    /// <seealso href="http://schema.org/InsuranceAgency">http://schema.org/InsuranceAgency</seealso>
    let InsuranceAgency = Prefixed_Name(schema1, "InsuranceAgency") |> PrefixedName

    /// <summary>
    ///   <para>schema1:RearWheelDriveConfiguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:DriveWheelConfigurationValue</para>
    ///   <para>Real-wheel drive is a transmission layout where the engine drives the rear wheels.</para>
    /// labels<para>RearWheelDriveConfiguration</para></remarks>
    /// <seealso href="http://schema.org/RearWheelDriveConfiguration">http://schema.org/RearWheelDriveConfiguration</seealso>
    let RearWheelDriveConfiguration =
        Prefixed_Name(schema1, "RearWheelDriveConfiguration") |> PrefixedName

    /// <summary>
    ///   <para>schema1:ReceiveAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of physically/electronically taking delivery of an object thathas been transferred from an origin to a destination. Reciprocal of SendAction.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/SendAction"&gt;SendAction&lt;/a&gt;: The reciprocal of ReceiveAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/TakeAction"&gt;TakeAction&lt;/a&gt;: Unlike TakeAction, ReceiveAction does not imply that the ownership has been transfered (e.g. I can receive a package, but it does not mean the package is now mine).&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>ReceiveAction</para></remarks>
    /// <seealso href="http://schema.org/ReceiveAction">http://schema.org/ReceiveAction</seealso>
    let ReceiveAction = Prefixed_Name(schema1, "ReceiveAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Recipe</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A recipe. For dietary restrictions covered by the recipe, a few common restrictions are enumerated via &lt;a class="localLink" href="http://schema.org/suitableForDiet"&gt;suitableForDiet&lt;/a&gt;. The &lt;a class="localLink" href="http://schema.org/keywords"&gt;keywords&lt;/a&gt; property can also be used to add more detail.</para>
    /// labels<para>Recipe</para></remarks>
    /// <seealso href="http://schema.org/Recipe">http://schema.org/Recipe</seealso>
    let Recipe = Prefixed_Name(schema1, "Recipe") |> PrefixedName
    /// <summary>
    ///   <para>schema1:RecyclingCenter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A recycling center.</para>
    /// labels<para>RecyclingCenter</para></remarks>
    /// <seealso href="http://schema.org/RecyclingCenter">http://schema.org/RecyclingCenter</seealso>
    let RecyclingCenter = Prefixed_Name(schema1, "RecyclingCenter") |> PrefixedName

    /// <summary>
    ///   <para>schema1:RefurbishedCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:OfferItemCondition</para>
    ///   <para>Indicates that the item is refurbished.</para>
    /// labels<para>RefurbishedCondition</para></remarks>
    /// <seealso href="http://schema.org/RefurbishedCondition">http://schema.org/RefurbishedCondition</seealso>
    let RefurbishedCondition =
        Prefixed_Name(schema1, "RefurbishedCondition") |> PrefixedName

    /// <summary>
    ///   <para>schema1:RegisterAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of registering to be a user of a service, product or web page.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/JoinAction"&gt;JoinAction&lt;/a&gt;: Unlike JoinAction, RegisterAction implies you are registering to be a user of a service, &lt;em&gt;not&lt;/em&gt; a group/team of people.&lt;/li&gt;
    /// &lt;li&gt;[FollowAction]]: Unlike FollowAction, RegisterAction doesn't imply that the agent is expecting to poll for updates from the object.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/SubscribeAction"&gt;SubscribeAction&lt;/a&gt;: Unlike SubscribeAction, RegisterAction doesn't imply that the agent is expecting updates from the object.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>RegisterAction</para></remarks>
    /// <seealso href="http://schema.org/RegisterAction">http://schema.org/RegisterAction</seealso>
    let RegisterAction = Prefixed_Name(schema1, "RegisterAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:RejectAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of rejecting to/adopting an object.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/AcceptAction"&gt;AcceptAction&lt;/a&gt;: The antonym of RejectAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>RejectAction</para></remarks>
    /// <seealso href="http://schema.org/RejectAction">http://schema.org/RejectAction</seealso>
    let RejectAction = Prefixed_Name(schema1, "RejectAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:RemixAlbum</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:MusicAlbumProductionType</para>
    ///   <para>RemixAlbum.</para>
    /// labels<para>RemixAlbum</para></remarks>
    /// <seealso href="http://schema.org/RemixAlbum">http://schema.org/RemixAlbum</seealso>
    let RemixAlbum = Prefixed_Name(schema1, "RemixAlbum") |> PrefixedName
    /// <summary>
    ///   <para>schema1:RentAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of giving money in return for temporary use, but not ownership, of an object such as a vehicle or property. For example, an agent rents a property from a landlord in exchange for a periodic payment.</para>
    /// labels<para>RentAction</para></remarks>
    /// <seealso href="http://schema.org/RentAction">http://schema.org/RentAction</seealso>
    let RentAction = Prefixed_Name(schema1, "RentAction") |> PrefixedName

    /// <summary>
    ///   <para>schema1:RentalCarReservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A reservation for a rental car.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.</para>
    /// labels<para>RentalCarReservation</para></remarks>
    /// <seealso href="http://schema.org/RentalCarReservation">http://schema.org/RentalCarReservation</seealso>
    let RentalCarReservation =
        Prefixed_Name(schema1, "RentalCarReservation") |> PrefixedName

    /// <summary>
    ///   <para>schema1:ReplaceAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of editing a recipient by replacing an old object with a new object.</para>
    /// labels<para>ReplaceAction</para></remarks>
    /// <seealso href="http://schema.org/ReplaceAction">http://schema.org/ReplaceAction</seealso>
    let ReplaceAction = Prefixed_Name(schema1, "ReplaceAction") |> PrefixedName

    /// <summary>
    ///   <para>schema1:ReservationConfirmed</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:ReservationStatusType</para>
    ///   <para>The status of a confirmed reservation.</para>
    /// labels<para>ReservationConfirmed</para></remarks>
    /// <seealso href="http://schema.org/ReservationConfirmed">http://schema.org/ReservationConfirmed</seealso>
    let ReservationConfirmed =
        Prefixed_Name(schema1, "ReservationConfirmed") |> PrefixedName

    /// <summary>
    ///   <para>schema1:ReservationHold</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:ReservationStatusType</para>
    ///   <para>The status of a reservation on hold pending an update like credit card number or flight changes.</para>
    /// labels<para>ReservationHold</para></remarks>
    /// <seealso href="http://schema.org/ReservationHold">http://schema.org/ReservationHold</seealso>
    let ReservationHold = Prefixed_Name(schema1, "ReservationHold") |> PrefixedName

    /// <summary>
    ///   <para>schema1:ReservationPackage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A group of multiple reservations with common values for all sub-reservations.</para>
    /// labels<para>ReservationPackage</para></remarks>
    /// <seealso href="http://schema.org/ReservationPackage">http://schema.org/ReservationPackage</seealso>
    let ReservationPackage =
        Prefixed_Name(schema1, "ReservationPackage") |> PrefixedName

    /// <summary>
    ///   <para>schema1:ReservationPending</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:ReservationStatusType</para>
    ///   <para>The status of a reservation when a request has been sent, but not confirmed.</para>
    /// labels<para>ReservationPending</para></remarks>
    /// <seealso href="http://schema.org/ReservationPending">http://schema.org/ReservationPending</seealso>
    let ReservationPending =
        Prefixed_Name(schema1, "ReservationPending") |> PrefixedName

    /// <summary>
    ///   <para>schema1:ReserveAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Reserving a concrete object.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ScheduleAction"&gt;ScheduleAction&lt;/a&gt;&lt;/a&gt;: Unlike ScheduleAction, ReserveAction reserves concrete objects (e.g. a table, a hotel) towards a time slot / spatial allocation.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>ReserveAction</para></remarks>
    /// <seealso href="http://schema.org/ReserveAction">http://schema.org/ReserveAction</seealso>
    let ReserveAction = Prefixed_Name(schema1, "ReserveAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Reservoir</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A reservoir of water, typically an artificially created lake, like the Lake Kariba reservoir.</para>
    /// labels<para>Reservoir</para></remarks>
    /// <seealso href="http://schema.org/Reservoir">http://schema.org/Reservoir</seealso>
    let Reservoir = Prefixed_Name(schema1, "Reservoir") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Resort</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A resort is a place used for relaxation or recreation, attracting visitors for holidays or vacations. Resorts are places, towns or sometimes commercial establishment operated by a single company (Source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Resort"&gt;http://en.wikipedia.org/wiki/Resort&lt;/a&gt;).
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.</para>
    /// labels<para>Resort</para></remarks>
    /// <seealso href="http://schema.org/Resort">http://schema.org/Resort</seealso>
    let Resort = Prefixed_Name(schema1, "Resort") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Restaurant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A restaurant.</para>
    /// labels<para>Restaurant</para></remarks>
    /// <seealso href="http://schema.org/Restaurant">http://schema.org/Restaurant</seealso>
    let Restaurant = Prefixed_Name(schema1, "Restaurant") |> PrefixedName
    /// <summary>
    ///   <para>schema1:WebSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A WebSite is a set of related web pages and other items typically served from a single web domain and accessible via URLs.</para>
    /// labels<para>WebSite</para></remarks>
    /// <seealso href="http://schema.org/WebSite">http://schema.org/WebSite</seealso>
    let WebSite = Prefixed_Name(schema1, "WebSite") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Wednesday</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:DayOfWeek</para>
    ///   <para>The day of the week between Tuesday and Thursday.</para>
    /// labels<para>Wednesday</para></remarks>
    /// <seealso href="http://schema.org/Wednesday">http://schema.org/Wednesday</seealso>
    let Wednesday = Prefixed_Name(schema1, "Wednesday") |> PrefixedName
    /// <summary>
    ///   <para>schema1:WholesaleStore</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A wholesale store.</para>
    /// labels<para>WholesaleStore</para></remarks>
    /// <seealso href="http://schema.org/WholesaleStore">http://schema.org/WholesaleStore</seealso>
    let WholesaleStore = Prefixed_Name(schema1, "WholesaleStore") |> PrefixedName
    /// <summary>
    ///   <para>schema1:WinAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of achieving victory in a competitive activity.</para>
    /// labels<para>WinAction</para></remarks>
    /// <seealso href="http://schema.org/WinAction">http://schema.org/WinAction</seealso>
    let WinAction = Prefixed_Name(schema1, "WinAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Winery</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A winery.</para>
    /// labels<para>Winery</para></remarks>
    /// <seealso href="http://schema.org/Winery">http://schema.org/Winery</seealso>
    let Winery = Prefixed_Name(schema1, "Winery") |> PrefixedName
    /// <summary>
    ///   <para>schema1:WorkersUnion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Workers Union (also known as a Labor Union, Labour Union, or Trade Union) is an organization that promotes the interests of its worker members by collectively bargaining with management, organizing, and political lobbying.</para>
    /// labels<para>WorkersUnion</para></remarks>
    /// <seealso href="http://schema.org/WorkersUnion">http://schema.org/WorkersUnion</seealso>
    let WorkersUnion = Prefixed_Name(schema1, "WorkersUnion") |> PrefixedName
    /// <summary>
    ///   <para>schema1:WriteAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of authoring written creative content.</para>
    /// labels<para>WriteAction</para></remarks>
    /// <seealso href="http://schema.org/WriteAction">http://schema.org/WriteAction</seealso>
    let WriteAction = Prefixed_Name(schema1, "WriteAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:WritePermission</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:DigitalDocumentPermissionType</para>
    ///   <para>Permission to write or edit the document.</para>
    /// labels<para>WritePermission</para></remarks>
    /// <seealso href="http://schema.org/WritePermission">http://schema.org/WritePermission</seealso>
    let WritePermission = Prefixed_Name(schema1, "WritePermission") |> PrefixedName
    /// <summary>
    ///   <para>schema1:domainIncludes</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schema.org/domainIncludes">http://schema.org/domainIncludes</seealso>
    let domainIncludes = Prefixed_Name(schema1, "domainIncludes") |> PrefixedName
    /// <summary>
    ///   <para>schema1:inverseOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schema.org/inverseOf">http://schema.org/inverseOf</seealso>
    let inverseOf = Prefixed_Name(schema1, "inverseOf") |> PrefixedName
    /// <summary>
    ///   <para>schema1:subjectOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A CreativeWork or Event about this Thing.</para>
    /// labels<para>subjectOf</para></remarks>
    /// <seealso href="http://schema.org/subjectOf">http://schema.org/subjectOf</seealso>
    let subjectOf = Prefixed_Name(schema1, "subjectOf") |> PrefixedName
    /// <summary>
    ///   <para>schema1:rangeIncludes</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schema.org/rangeIncludes">http://schema.org/rangeIncludes</seealso>
    let rangeIncludes = Prefixed_Name(schema1, "rangeIncludes") |> PrefixedName
    /// <summary>
    ///   <para>schema1:acceptedAnswer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The answer(s) that has been accepted as best, typically on a Question/Answer site. Sites vary in their selection mechanisms, e.g. drawing on community opinion and/or the view of the Question author.</para>
    /// labels<para>acceptedAnswer</para></remarks>
    /// <seealso href="http://schema.org/acceptedAnswer">http://schema.org/acceptedAnswer</seealso>
    let acceptedAnswer = Prefixed_Name(schema1, "acceptedAnswer") |> PrefixedName
    /// <summary>
    ///   <para>schema1:suggestedAnswer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An answer (possibly one of several, possibly incorrect) to a Question, e.g. on a Question/Answer site.</para>
    /// labels<para>suggestedAnswer</para></remarks>
    /// <seealso href="http://schema.org/suggestedAnswer">http://schema.org/suggestedAnswer</seealso>
    let suggestedAnswer = Prefixed_Name(schema1, "suggestedAnswer") |> PrefixedName
    /// <summary>
    ///   <para>schema1:acceptedOffer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The offer(s) -- e.g., product, quantity and price combinations -- included in the order.</para>
    /// labels<para>acceptedOffer</para></remarks>
    /// <seealso href="http://schema.org/acceptedOffer">http://schema.org/acceptedOffer</seealso>
    let acceptedOffer = Prefixed_Name(schema1, "acceptedOffer") |> PrefixedName

    /// <summary>
    ///   <para>schema1:acceptedPaymentMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The payment method(s) accepted by seller for this offer.</para>
    /// labels<para>acceptedPaymentMethod</para></remarks>
    /// <seealso href="http://schema.org/acceptedPaymentMethod">http://schema.org/acceptedPaymentMethod</seealso>
    let acceptedPaymentMethod =
        Prefixed_Name(schema1, "acceptedPaymentMethod") |> PrefixedName

    /// <summary>
    ///   <para>schema1:acceptsReservations</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates whether a FoodEstablishment accepts reservations. Values can be Boolean, an URL at which reservations can be made or (for backwards compatibility) the strings &lt;code&gt;Yes&lt;/code&gt; or &lt;code&gt;No&lt;/code&gt;.</para>
    /// labels<para>acceptsReservations</para></remarks>
    /// <seealso href="http://schema.org/acceptsReservations">http://schema.org/acceptsReservations</seealso>
    let acceptsReservations =
        Prefixed_Name(schema1, "acceptsReservations") |> PrefixedName

    /// <summary>
    ///   <para>schema1:accessCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Password, PIN, or access code needed for delivery (e.g. from a locker).</para>
    /// labels<para>accessCode</para></remarks>
    /// <seealso href="http://schema.org/accessCode">http://schema.org/accessCode</seealso>
    let accessCode = Prefixed_Name(schema1, "accessCode") |> PrefixedName
    /// <summary>
    ///   <para>schema1:accessMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The human sensory perceptual system or cognitive faculty through which a person may process or perceive information. Expected values include: auditory, tactile, textual, visual, colorDependent, chartOnVisual, chemOnVisual, diagramOnVisual, mathOnVisual, musicOnVisual, textOnVisual.</para>
    /// labels<para>accessMode</para></remarks>
    /// <seealso href="http://schema.org/accessMode">http://schema.org/accessMode</seealso>
    let accessMode = Prefixed_Name(schema1, "accessMode") |> PrefixedName

    /// <summary>
    ///   <para>schema1:accessModeSufficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A list of single or combined accessModes that are sufficient to understand all the intellectual content of a resource. Expected values include:  auditory, tactile, textual, visual.</para>
    /// labels<para>accessModeSufficient</para></remarks>
    /// <seealso href="http://schema.org/accessModeSufficient">http://schema.org/accessModeSufficient</seealso>
    let accessModeSufficient =
        Prefixed_Name(schema1, "accessModeSufficient") |> PrefixedName

    /// <summary>
    ///   <para>schema1:character</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Fictional person connected with a creative work.</para>
    /// labels<para>character</para></remarks>
    /// <seealso href="http://schema.org/character">http://schema.org/character</seealso>
    let character = Prefixed_Name(schema1, "character") |> PrefixedName

    /// <summary>
    ///   <para>schema1:characterAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A piece of data that represents a particular aspect of a fictional character (skill, power, character points, advantage, disadvantage).</para>
    /// labels<para>characterAttribute</para></remarks>
    /// <seealso href="http://schema.org/characterAttribute">http://schema.org/characterAttribute</seealso>
    let characterAttribute =
        Prefixed_Name(schema1, "characterAttribute") |> PrefixedName

    /// <summary>
    ///   <para>schema1:characterName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The name of a character played in some acting or performing role, i.e. in a PerformanceRole.</para>
    /// labels<para>characterName</para></remarks>
    /// <seealso href="http://schema.org/characterName">http://schema.org/characterName</seealso>
    let characterName = Prefixed_Name(schema1, "characterName") |> PrefixedName
    /// <summary>
    ///   <para>schema1:cheatCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Cheat codes to the game.</para>
    /// labels<para>cheatCode</para></remarks>
    /// <seealso href="http://schema.org/cheatCode">http://schema.org/cheatCode</seealso>
    let cheatCode = Prefixed_Name(schema1, "cheatCode") |> PrefixedName
    /// <summary>
    ///   <para>schema1:checkinTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The earliest someone may check into a lodging establishment.</para>
    /// labels<para>checkinTime</para></remarks>
    /// <seealso href="http://schema.org/checkinTime">http://schema.org/checkinTime</seealso>
    let checkinTime = Prefixed_Name(schema1, "checkinTime") |> PrefixedName
    /// <summary>
    ///   <para>schema1:checkoutTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The latest someone may check out of a lodging establishment.</para>
    /// labels<para>checkoutTime</para></remarks>
    /// <seealso href="http://schema.org/checkoutTime">http://schema.org/checkoutTime</seealso>
    let checkoutTime = Prefixed_Name(schema1, "checkoutTime") |> PrefixedName
    /// <summary>
    ///   <para>schema1:childMaxAge</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Maximal age of the child.</para>
    /// labels<para>childMaxAge</para></remarks>
    /// <seealso href="http://schema.org/childMaxAge">http://schema.org/childMaxAge</seealso>
    let childMaxAge = Prefixed_Name(schema1, "childMaxAge") |> PrefixedName
    /// <summary>
    ///   <para>schema1:childMinAge</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Minimal age of the child.</para>
    /// labels<para>childMinAge</para></remarks>
    /// <seealso href="http://schema.org/childMinAge">http://schema.org/childMinAge</seealso>
    let childMinAge = Prefixed_Name(schema1, "childMinAge") |> PrefixedName
    /// <summary>
    ///   <para>schema1:children</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A child of the person.</para>
    /// labels<para>children</para></remarks>
    /// <seealso href="http://schema.org/children">http://schema.org/children</seealso>
    let children = Prefixed_Name(schema1, "children") |> PrefixedName

    /// <summary>
    ///   <para>schema1:cholesterolContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of milligrams of cholesterol.</para>
    /// labels<para>cholesterolContent</para></remarks>
    /// <seealso href="http://schema.org/cholesterolContent">http://schema.org/cholesterolContent</seealso>
    let cholesterolContent =
        Prefixed_Name(schema1, "cholesterolContent") |> PrefixedName

    /// <summary>
    ///   <para>schema1:circle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A circle is the circular region of a specified radius centered at a specified latitude and longitude. A circle is expressed as a pair followed by a radius in meters.</para>
    /// labels<para>circle</para></remarks>
    /// <seealso href="http://schema.org/circle">http://schema.org/circle</seealso>
    let circle = Prefixed_Name(schema1, "circle") |> PrefixedName
    /// <summary>
    ///   <para>schema1:claimReviewed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A short summary of the specific claims reviewed in a ClaimReview.</para>
    /// labels<para>claimReviewed</para></remarks>
    /// <seealso href="http://schema.org/claimReviewed">http://schema.org/claimReviewed</seealso>
    let claimReviewed = Prefixed_Name(schema1, "claimReviewed") |> PrefixedName
    /// <summary>
    ///   <para>schema1:clipNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Position of the clip within an ordered group of clips.</para>
    /// labels<para>clipNumber</para></remarks>
    /// <seealso href="http://schema.org/clipNumber">http://schema.org/clipNumber</seealso>
    let clipNumber = Prefixed_Name(schema1, "clipNumber") |> PrefixedName
    /// <summary>
    ///   <para>schema1:position</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The position of an item in a series or sequence of items.</para>
    /// labels<para>position</para></remarks>
    /// <seealso href="http://schema.org/position">http://schema.org/position</seealso>
    let position = Prefixed_Name(schema1, "position") |> PrefixedName
    /// <summary>
    ///   <para>schema1:closes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The closing hour of the place or service on the given day(s) of the week.</para>
    /// labels<para>closes</para></remarks>
    /// <seealso href="http://schema.org/closes">http://schema.org/closes</seealso>
    let closes = Prefixed_Name(schema1, "closes") |> PrefixedName
    /// <summary>
    ///   <para>schema1:coach</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A person that acts in a coaching role for a sports team.</para>
    /// labels<para>coach</para></remarks>
    /// <seealso href="http://schema.org/coach">http://schema.org/coach</seealso>
    let coach = Prefixed_Name(schema1, "coach") |> PrefixedName
    /// <summary>
    ///   <para>schema1:codeRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Link to the repository where the un-compiled, human readable code and related code is located (SVN, github, CodePlex).</para>
    /// labels<para>codeRepository</para></remarks>
    /// <seealso href="http://schema.org/codeRepository">http://schema.org/codeRepository</seealso>
    let codeRepository = Prefixed_Name(schema1, "codeRepository") |> PrefixedName
    /// <summary>
    ///   <para>schema1:codeSampleType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>What type of code sample: full (compile ready) solution, code snippet, inline code, scripts, template.</para>
    /// labels<para>codeSampleType</para></remarks>
    /// <seealso href="http://schema.org/codeSampleType">http://schema.org/codeSampleType</seealso>
    let codeSampleType = Prefixed_Name(schema1, "codeSampleType") |> PrefixedName
    /// <summary>
    ///   <para>schema1:colleague</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A colleague of the person.</para>
    /// labels<para>colleague</para></remarks>
    /// <seealso href="http://schema.org/colleague">http://schema.org/colleague</seealso>
    let colleague = Prefixed_Name(schema1, "colleague") |> PrefixedName
    /// <summary>
    ///   <para>schema1:colleagues</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A colleague of the person.</para>
    /// labels<para>colleagues</para></remarks>
    /// <seealso href="http://schema.org/colleagues">http://schema.org/colleagues</seealso>
    let colleagues = Prefixed_Name(schema1, "colleagues") |> PrefixedName
    /// <summary>
    ///   <para>schema1:collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of object. The collection target of the action.</para>
    /// labels<para>collection</para></remarks>
    /// <seealso href="http://schema.org/collection">http://schema.org/collection</seealso>
    let collection = Prefixed_Name(schema1, "collection") |> PrefixedName
    /// <summary>
    ///   <para>schema1:targetCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of object. The collection target of the action.</para>
    /// labels<para>targetCollection</para></remarks>
    /// <seealso href="http://schema.org/targetCollection">http://schema.org/targetCollection</seealso>
    let targetCollection = Prefixed_Name(schema1, "targetCollection") |> PrefixedName
    /// <summary>
    ///   <para>schema1:color</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The color of the product.</para>
    /// labels<para>color</para></remarks>
    /// <seealso href="http://schema.org/color">http://schema.org/color</seealso>
    let color = Prefixed_Name(schema1, "color") |> PrefixedName
    /// <summary>
    ///   <para>schema1:commentTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The time at which the UserComment was made.</para>
    /// labels<para>commentTime</para></remarks>
    /// <seealso href="http://schema.org/commentTime">http://schema.org/commentTime</seealso>
    let commentTime = Prefixed_Name(schema1, "commentTime") |> PrefixedName
    /// <summary>
    ///   <para>schema1:composer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The person or organization who wrote a composition, or who is the composer of a work performed at some event.</para>
    /// labels<para>composer</para></remarks>
    /// <seealso href="http://schema.org/composer">http://schema.org/composer</seealso>
    let composer = Prefixed_Name(schema1, "composer") |> PrefixedName

    /// <summary>
    ///   <para>schema1:confirmationNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A number that confirms the given order or payment has been received.</para>
    /// labels<para>confirmationNumber</para></remarks>
    /// <seealso href="http://schema.org/confirmationNumber">http://schema.org/confirmationNumber</seealso>
    let confirmationNumber =
        Prefixed_Name(schema1, "confirmationNumber") |> PrefixedName

    /// <summary>
    ///   <para>schema1:contactOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An option available on this contact point (e.g. a toll-free number or support for hearing-impaired callers).</para>
    /// labels<para>contactOption</para></remarks>
    /// <seealso href="http://schema.org/contactOption">http://schema.org/contactOption</seealso>
    let contactOption = Prefixed_Name(schema1, "contactOption") |> PrefixedName
    /// <summary>
    ///   <para>schema1:contactPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A contact point for a person or organization.</para>
    /// labels<para>contactPoint</para></remarks>
    /// <seealso href="http://schema.org/contactPoint">http://schema.org/contactPoint</seealso>
    let contactPoint = Prefixed_Name(schema1, "contactPoint") |> PrefixedName

    /// <summary>
    ///   <para>schema1:HealthInsurancePlan</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schema.org/HealthInsurancePlan">http://schema.org/HealthInsurancePlan</seealso>
    let HealthInsurancePlan =
        Prefixed_Name(schema1, "HealthInsurancePlan") |> PrefixedName

    /// <summary>
    ///   <para>schema1:contactPoints</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A contact point for a person or organization.</para>
    /// labels<para>contactPoints</para></remarks>
    /// <seealso href="http://schema.org/contactPoints">http://schema.org/contactPoints</seealso>
    let contactPoints = Prefixed_Name(schema1, "contactPoints") |> PrefixedName
    /// <summary>
    ///   <para>schema1:contactType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A person or organization can have different contact points, for different purposes. For example, a sales contact point, a PR contact point and so on. This property is used to specify the kind of contact point.</para>
    /// labels<para>contactType</para></remarks>
    /// <seealso href="http://schema.org/contactType">http://schema.org/contactType</seealso>
    let contactType = Prefixed_Name(schema1, "contactType") |> PrefixedName
    /// <summary>
    ///   <para>schema1:containedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The basic containment relation between a place and one that contains it.</para>
    /// labels<para>containedIn</para></remarks>
    /// <seealso href="http://schema.org/containedIn">http://schema.org/containedIn</seealso>
    let containedIn = Prefixed_Name(schema1, "containedIn") |> PrefixedName
    /// <summary>
    ///   <para>schema1:containedInPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The basic containment relation between a place and one that contains it.</para>
    /// labels<para>containedInPlace</para></remarks>
    /// <seealso href="http://schema.org/containedInPlace">http://schema.org/containedInPlace</seealso>
    let containedInPlace = Prefixed_Name(schema1, "containedInPlace") |> PrefixedName
    /// <summary>
    ///   <para>schema1:containsPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The basic containment relation between a place and another that it contains.</para>
    /// labels<para>containsPlace</para></remarks>
    /// <seealso href="http://schema.org/containsPlace">http://schema.org/containsPlace</seealso>
    let containsPlace = Prefixed_Name(schema1, "containsPlace") |> PrefixedName
    /// <summary>
    ///   <para>schema1:contentLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The location depicted or described in the content. For example, the location in a photograph or painting.</para>
    /// labels<para>contentLocation</para></remarks>
    /// <seealso href="http://schema.org/contentLocation">http://schema.org/contentLocation</seealso>
    let contentLocation = Prefixed_Name(schema1, "contentLocation") |> PrefixedName
    /// <summary>
    ///   <para>schema1:contentRating</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Official rating of a piece of content&amp;#x2014;for example,'MPAA PG-13'.</para>
    /// labels<para>contentRating</para></remarks>
    /// <seealso href="http://schema.org/contentRating">http://schema.org/contentRating</seealso>
    let contentRating = Prefixed_Name(schema1, "contentRating") |> PrefixedName
    /// <summary>
    ///   <para>schema1:contentSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>File size in (mega/kilo) bytes.</para>
    /// labels<para>contentSize</para></remarks>
    /// <seealso href="http://schema.org/contentSize">http://schema.org/contentSize</seealso>
    let contentSize = Prefixed_Name(schema1, "contentSize") |> PrefixedName
    /// <summary>
    ///   <para>schema1:contentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The supported content type(s) for an EntryPoint response.</para>
    /// labels<para>contentType</para></remarks>
    /// <seealso href="http://schema.org/contentType">http://schema.org/contentType</seealso>
    let contentType = Prefixed_Name(schema1, "contentType") |> PrefixedName
    /// <summary>
    ///   <para>schema1:contentUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Actual bytes of the media object, for example the image file or video file.</para>
    /// labels<para>contentUrl</para></remarks>
    /// <seealso href="http://schema.org/contentUrl">http://schema.org/contentUrl</seealso>
    let contentUrl = Prefixed_Name(schema1, "contentUrl") |> PrefixedName
    /// <summary>
    ///   <para>schema1:contributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A secondary contributor to the CreativeWork or Event.</para>
    /// labels<para>contributor</para></remarks>
    /// <seealso href="http://schema.org/contributor">http://schema.org/contributor</seealso>
    let contributor = Prefixed_Name(schema1, "contributor") |> PrefixedName
    /// <summary>
    ///   <para>schema1:cookTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The time it takes to actually cook the dish, in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.</para>
    /// labels<para>cookTime</para></remarks>
    /// <seealso href="http://schema.org/cookTime">http://schema.org/cookTime</seealso>
    let cookTime = Prefixed_Name(schema1, "cookTime") |> PrefixedName
    /// <summary>
    ///   <para>schema1:performTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The length of time it takes to perform instructions or a direction (not including time to prepare the supplies), in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.</para>
    /// labels<para>performTime</para></remarks>
    /// <seealso href="http://schema.org/performTime">http://schema.org/performTime</seealso>
    let performTime = Prefixed_Name(schema1, "performTime") |> PrefixedName
    /// <summary>
    ///   <para>schema1:cookingMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The method of cooking, such as Frying, Steaming, ...</para>
    /// labels<para>cookingMethod</para></remarks>
    /// <seealso href="http://schema.org/cookingMethod">http://schema.org/cookingMethod</seealso>
    let cookingMethod = Prefixed_Name(schema1, "cookingMethod") |> PrefixedName
    /// <summary>
    ///   <para>schema1:copyrightHolder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The party holding the legal copyright to the CreativeWork.</para>
    /// labels<para>copyrightHolder</para></remarks>
    /// <seealso href="http://schema.org/copyrightHolder">http://schema.org/copyrightHolder</seealso>
    let copyrightHolder = Prefixed_Name(schema1, "copyrightHolder") |> PrefixedName
    /// <summary>
    ///   <para>schema1:copyrightYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The year during which the claimed copyright for the CreativeWork was first asserted.</para>
    /// labels<para>copyrightYear</para></remarks>
    /// <seealso href="http://schema.org/copyrightYear">http://schema.org/copyrightYear</seealso>
    let copyrightYear = Prefixed_Name(schema1, "copyrightYear") |> PrefixedName

    /// <summary>
    ///   <para>schema1:countriesNotSupported</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Countries for which the application is not supported. You can also provide the two-letter ISO 3166-1 alpha-2 country code.</para>
    /// labels<para>countriesNotSupported</para></remarks>
    /// <seealso href="http://schema.org/countriesNotSupported">http://schema.org/countriesNotSupported</seealso>
    let countriesNotSupported =
        Prefixed_Name(schema1, "countriesNotSupported") |> PrefixedName

    /// <summary>
    ///   <para>schema1:gtin8</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The &lt;a href="http://apps.gs1.org/GDD/glossary/Pages/GTIN-8.aspx"&gt;GTIN-8&lt;/a&gt; code of the product, or the product to which the offer refers. This code is also known as EAN/UCC-8 or 8-digit EAN. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.</para>
    /// labels<para>gtin8</para></remarks>
    /// <seealso href="http://schema.org/gtin8">http://schema.org/gtin8</seealso>
    let gtin8 = Prefixed_Name(schema1, "gtin8") |> PrefixedName

    /// <summary>
    ///   <para>schema1:hasBroadcastChannel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A broadcast channel of a broadcast service.</para>
    /// labels<para>hasBroadcastChannel</para></remarks>
    /// <seealso href="http://schema.org/hasBroadcastChannel">http://schema.org/hasBroadcastChannel</seealso>
    let hasBroadcastChannel =
        Prefixed_Name(schema1, "hasBroadcastChannel") |> PrefixedName

    /// <summary>
    ///   <para>schema1:providesBroadcastService</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The BroadcastService offered on this channel.</para>
    /// labels<para>providesBroadcastService</para></remarks>
    /// <seealso href="http://schema.org/providesBroadcastService">http://schema.org/providesBroadcastService</seealso>
    let providesBroadcastService =
        Prefixed_Name(schema1, "providesBroadcastService") |> PrefixedName

    /// <summary>
    ///   <para>schema1:hasCourseInstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An offering of the course at a specific time and place or through specific media or mode of study or to a specific section of students.</para>
    /// labels<para>hasCourseInstance</para></remarks>
    /// <seealso href="http://schema.org/hasCourseInstance">http://schema.org/hasCourseInstance</seealso>
    let hasCourseInstance = Prefixed_Name(schema1, "hasCourseInstance") |> PrefixedName
    /// <summary>
    ///   <para>schema1:hasDeliveryMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Method used for delivery or shipping.</para>
    /// labels<para>hasDeliveryMethod</para></remarks>
    /// <seealso href="http://schema.org/hasDeliveryMethod">http://schema.org/hasDeliveryMethod</seealso>
    let hasDeliveryMethod = Prefixed_Name(schema1, "hasDeliveryMethod") |> PrefixedName

    /// <summary>
    ///   <para>schema1:hasDigitalDocumentPermission</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A permission related to the access to this document (e.g. permission to read or write an electronic document). For a public document, specify a grantee with an Audience with audienceType equal to "public".</para>
    /// labels<para>hasDigitalDocumentPermission</para></remarks>
    /// <seealso href="http://schema.org/hasDigitalDocumentPermission">http://schema.org/hasDigitalDocumentPermission</seealso>
    let hasDigitalDocumentPermission =
        Prefixed_Name(schema1, "hasDigitalDocumentPermission") |> PrefixedName

    /// <summary>
    ///   <para>schema1:hasMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A URL to a map of the place.</para>
    /// labels<para>hasMap</para></remarks>
    /// <seealso href="http://schema.org/hasMap">http://schema.org/hasMap</seealso>
    let hasMap = Prefixed_Name(schema1, "hasMap") |> PrefixedName
    /// <summary>
    ///   <para>schema1:hasMenu</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Either the actual menu as a structured representation, as text, or a URL of the menu.</para>
    /// labels<para>hasMenu</para></remarks>
    /// <seealso href="http://schema.org/hasMenu">http://schema.org/hasMenu</seealso>
    let hasMenu = Prefixed_Name(schema1, "hasMenu") |> PrefixedName
    /// <summary>
    ///   <para>schema1:hasMenuItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A food or drink item contained in a menu or menu section.</para>
    /// labels<para>hasMenuItem</para></remarks>
    /// <seealso href="http://schema.org/hasMenuItem">http://schema.org/hasMenuItem</seealso>
    let hasMenuItem = Prefixed_Name(schema1, "hasMenuItem") |> PrefixedName
    /// <summary>
    ///   <para>schema1:hasMenuSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A subgrouping of the menu (by dishes, course, serving time period, etc.).</para>
    /// labels<para>hasMenuSection</para></remarks>
    /// <seealso href="http://schema.org/hasMenuSection">http://schema.org/hasMenuSection</seealso>
    let hasMenuSection = Prefixed_Name(schema1, "hasMenuSection") |> PrefixedName
    /// <summary>
    ///   <para>schema1:hasOccupation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Person's occupation. For past professions, use Role for expressing dates.</para>
    /// labels<para>hasOccupation</para></remarks>
    /// <seealso href="http://schema.org/hasOccupation">http://schema.org/hasOccupation</seealso>
    let hasOccupation = Prefixed_Name(schema1, "hasOccupation") |> PrefixedName
    /// <summary>
    ///   <para>schema1:hasOfferCatalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates an OfferCatalog listing for this Organization, Person, or Service.</para>
    /// labels<para>hasOfferCatalog</para></remarks>
    /// <seealso href="http://schema.org/hasOfferCatalog">http://schema.org/hasOfferCatalog</seealso>
    let hasOfferCatalog = Prefixed_Name(schema1, "hasOfferCatalog") |> PrefixedName
    /// <summary>
    ///   <para>schema1:hasPOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Points-of-Sales operated by the organization or person.</para>
    /// labels<para>hasPOS</para></remarks>
    /// <seealso href="http://schema.org/hasPOS">http://schema.org/hasPOS</seealso>
    let hasPOS = Prefixed_Name(schema1, "hasPOS") |> PrefixedName
    /// <summary>
    ///   <para>schema1:isPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates an item or CreativeWork that this item, or CreativeWork (in some sense), is part of.</para>
    /// labels<para>isPartOf</para></remarks>
    /// <seealso href="http://schema.org/isPartOf">http://schema.org/isPartOf</seealso>
    let isPartOf = Prefixed_Name(schema1, "isPartOf") |> PrefixedName
    /// <summary>
    ///   <para>schema1:headline</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Headline of the article.</para>
    /// labels<para>headline</para></remarks>
    /// <seealso href="http://schema.org/headline">http://schema.org/headline</seealso>
    let headline = Prefixed_Name(schema1, "headline") |> PrefixedName
    /// <summary>
    ///   <para>schema1:height</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The height of the item.</para>
    /// labels<para>height</para></remarks>
    /// <seealso href="http://schema.org/height">http://schema.org/height</seealso>
    let height = Prefixed_Name(schema1, "height") |> PrefixedName
    /// <summary>
    ///   <para>schema1:highPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The highest price of all offers available.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Usage guidelines:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
    /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>highPrice</para></remarks>
    /// <seealso href="http://schema.org/highPrice">http://schema.org/highPrice</seealso>
    let highPrice = Prefixed_Name(schema1, "highPrice") |> PrefixedName

    /// <summary>
    ///   <para>schema1:hiringOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Organization offering the job position.</para>
    /// labels<para>hiringOrganization</para></remarks>
    /// <seealso href="http://schema.org/hiringOrganization">http://schema.org/hiringOrganization</seealso>
    let hiringOrganization =
        Prefixed_Name(schema1, "hiringOrganization") |> PrefixedName

    /// <summary>
    ///   <para>schema1:homeLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A contact location for a person's residence.</para>
    /// labels<para>homeLocation</para></remarks>
    /// <seealso href="http://schema.org/homeLocation">http://schema.org/homeLocation</seealso>
    let homeLocation = Prefixed_Name(schema1, "homeLocation") |> PrefixedName
    /// <summary>
    ///   <para>schema1:homeTeam</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The home team in a sports event.</para>
    /// labels<para>homeTeam</para></remarks>
    /// <seealso href="http://schema.org/homeTeam">http://schema.org/homeTeam</seealso>
    let homeTeam = Prefixed_Name(schema1, "homeTeam") |> PrefixedName
    /// <summary>
    ///   <para>schema1:honorificPrefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An honorific prefix preceding a Person's name such as Dr/Mrs/Mr.</para>
    /// labels<para>honorificPrefix</para></remarks>
    /// <seealso href="http://schema.org/honorificPrefix">http://schema.org/honorificPrefix</seealso>
    let honorificPrefix = Prefixed_Name(schema1, "honorificPrefix") |> PrefixedName
    /// <summary>
    ///   <para>schema1:honorificSuffix</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An honorific suffix preceding a Person's name such as M.D. /PhD/MSCSW.</para>
    /// labels<para>honorificSuffix</para></remarks>
    /// <seealso href="http://schema.org/honorificSuffix">http://schema.org/honorificSuffix</seealso>
    let honorificSuffix = Prefixed_Name(schema1, "honorificSuffix") |> PrefixedName
    /// <summary>
    ///   <para>schema1:inLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The language of the content or performance or used in an action. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/availableLanguage"&gt;availableLanguage&lt;/a&gt;.</para>
    /// labels<para>inLanguage</para></remarks>
    /// <seealso href="http://schema.org/inLanguage">http://schema.org/inLanguage</seealso>
    let inLanguage = Prefixed_Name(schema1, "inLanguage") |> PrefixedName
    /// <summary>
    ///   <para>schema1:LinkRole</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schema.org/LinkRole">http://schema.org/LinkRole</seealso>
    let LinkRole = Prefixed_Name(schema1, "LinkRole") |> PrefixedName
    /// <summary>
    ///   <para>schema1:PronounceableText</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schema.org/PronounceableText">http://schema.org/PronounceableText</seealso>
    let PronounceableText = Prefixed_Name(schema1, "PronounceableText") |> PrefixedName
    /// <summary>
    ///   <para>schema1:inPlaylist</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The playlist to which this recording belongs.</para>
    /// labels<para>inPlaylist</para></remarks>
    /// <seealso href="http://schema.org/inPlaylist">http://schema.org/inPlaylist</seealso>
    let inPlaylist = Prefixed_Name(schema1, "inPlaylist") |> PrefixedName

    /// <summary>
    ///   <para>schema1:incentiveCompensation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Description of bonus and commission compensation aspects of the job.</para>
    /// labels<para>incentiveCompensation</para></remarks>
    /// <seealso href="http://schema.org/incentiveCompensation">http://schema.org/incentiveCompensation</seealso>
    let incentiveCompensation =
        Prefixed_Name(schema1, "incentiveCompensation") |> PrefixedName

    /// <summary>
    ///   <para>schema1:incentives</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Description of bonus and commission compensation aspects of the job.</para>
    /// labels<para>incentives</para></remarks>
    /// <seealso href="http://schema.org/incentives">http://schema.org/incentives</seealso>
    let incentives = Prefixed_Name(schema1, "incentives") |> PrefixedName

    /// <summary>
    ///   <para>schema1:includedComposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Smaller compositions included in this work (e.g. a movement in a symphony).</para>
    /// labels<para>includedComposition</para></remarks>
    /// <seealso href="http://schema.org/includedComposition">http://schema.org/includedComposition</seealso>
    let includedComposition =
        Prefixed_Name(schema1, "includedComposition") |> PrefixedName

    /// <summary>
    ///   <para>schema1:includedDataCatalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A data catalog which contains this dataset (this property was previously 'catalog', preferred name is now 'includedInDataCatalog').</para>
    /// labels<para>includedDataCatalog</para></remarks>
    /// <seealso href="http://schema.org/includedDataCatalog">http://schema.org/includedDataCatalog</seealso>
    let includedDataCatalog =
        Prefixed_Name(schema1, "includedDataCatalog") |> PrefixedName

    /// <summary>
    ///   <para>schema1:includesObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This links to a node or nodes indicating the exact quantity of the products included in the offer.</para>
    /// labels<para>includesObject</para></remarks>
    /// <seealso href="http://schema.org/includesObject">http://schema.org/includesObject</seealso>
    let includesObject = Prefixed_Name(schema1, "includesObject") |> PrefixedName
    /// <summary>
    ///   <para>schema1:industry</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The industry associated with the job position.</para>
    /// labels<para>industry</para></remarks>
    /// <seealso href="http://schema.org/industry">http://schema.org/industry</seealso>
    let industry = Prefixed_Name(schema1, "industry") |> PrefixedName
    /// <summary>
    ///   <para>schema1:DefinedTerm</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schema.org/DefinedTerm">http://schema.org/DefinedTerm</seealso>
    let DefinedTerm = Prefixed_Name(schema1, "DefinedTerm") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ingredients</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A single ingredient used in the recipe, e.g. sugar, flour or garlic.</para>
    /// labels<para>ingredients</para></remarks>
    /// <seealso href="http://schema.org/ingredients">http://schema.org/ingredients</seealso>
    let ingredients = Prefixed_Name(schema1, "ingredients") |> PrefixedName
    /// <summary>
    ///   <para>schema1:recipeIngredient</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A single ingredient used in the recipe, e.g. sugar, flour or garlic.</para>
    /// labels<para>recipeIngredient</para></remarks>
    /// <seealso href="http://schema.org/recipeIngredient">http://schema.org/recipeIngredient</seealso>
    let recipeIngredient = Prefixed_Name(schema1, "recipeIngredient") |> PrefixedName
    /// <summary>
    ///   <para>schema1:supply</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub-property of instrument. A supply consumed when performing instructions or a direction.</para>
    /// labels<para>supply</para></remarks>
    /// <seealso href="http://schema.org/supply">http://schema.org/supply</seealso>
    let supply = Prefixed_Name(schema1, "supply") |> PrefixedName
    /// <summary>
    ///   <para>schema1:installUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>URL at which the app may be installed, if different from the URL of the item.</para>
    /// labels<para>installUrl</para></remarks>
    /// <seealso href="http://schema.org/installUrl">http://schema.org/installUrl</seealso>
    let installUrl = Prefixed_Name(schema1, "installUrl") |> PrefixedName
    /// <summary>
    ///   <para>schema1:instructor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A person assigned to instruct or provide instructional assistance for the &lt;a class="localLink" href="http://schema.org/CourseInstance"&gt;CourseInstance&lt;/a&gt;.</para>
    /// labels<para>instructor</para></remarks>
    /// <seealso href="http://schema.org/instructor">http://schema.org/instructor</seealso>
    let instructor = Prefixed_Name(schema1, "instructor") |> PrefixedName
    /// <summary>
    ///   <para>schema1:interactionCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property is deprecated, alongside the UserInteraction types on which it depended.</para>
    /// labels<para>interactionCount</para></remarks>
    /// <seealso href="http://schema.org/interactionCount">http://schema.org/interactionCount</seealso>
    let interactionCount = Prefixed_Name(schema1, "interactionCount") |> PrefixedName

    /// <summary>
    ///   <para>schema1:interactionStatistic</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of interactions for the CreativeWork using the WebSite or SoftwareApplication. The most specific child type of InteractionCounter should be used.</para>
    /// labels<para>interactionStatistic</para></remarks>
    /// <seealso href="http://schema.org/interactionStatistic">http://schema.org/interactionStatistic</seealso>
    let interactionStatistic =
        Prefixed_Name(schema1, "interactionStatistic") |> PrefixedName

    /// <summary>
    ///   <para>schema1:interactionService</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The WebSite or SoftwareApplication where the interactions took place.</para>
    /// labels<para>interactionService</para></remarks>
    /// <seealso href="http://schema.org/interactionService">http://schema.org/interactionService</seealso>
    let interactionService =
        Prefixed_Name(schema1, "interactionService") |> PrefixedName

    /// <summary>
    ///   <para>schema1:interactionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Action representing the type of interaction. For up votes, +1s, etc. use &lt;a class="localLink" href="http://schema.org/LikeAction"&gt;LikeAction&lt;/a&gt;. For down votes use &lt;a class="localLink" href="http://schema.org/DislikeAction"&gt;DislikeAction&lt;/a&gt;. Otherwise, use the most specific Action.</para>
    /// labels<para>interactionType</para></remarks>
    /// <seealso href="http://schema.org/interactionType">http://schema.org/interactionType</seealso>
    let interactionType = Prefixed_Name(schema1, "interactionType") |> PrefixedName
    /// <summary>
    ///   <para>schema1:interactivityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The predominant mode of learning supported by the learning resource. Acceptable values are 'active', 'expositive', or 'mixed'.</para>
    /// labels<para>interactivityType</para></remarks>
    /// <seealso href="http://schema.org/interactivityType">http://schema.org/interactivityType</seealso>
    let interactivityType = Prefixed_Name(schema1, "interactivityType") |> PrefixedName
    /// <summary>
    ///   <para>schema1:interestRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The interest rate, charged or paid, applicable to the financial product. Note: This is different from the calculated annualPercentageRate.</para>
    /// labels<para>interestRate</para></remarks>
    /// <seealso href="http://schema.org/interestRate">http://schema.org/interestRate</seealso>
    let interestRate = Prefixed_Name(schema1, "interestRate") |> PrefixedName
    /// <summary>
    ///   <para>schema1:inventoryLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The current approximate inventory level for the item or items.</para>
    /// labels<para>inventoryLevel</para></remarks>
    /// <seealso href="http://schema.org/inventoryLevel">http://schema.org/inventoryLevel</seealso>
    let inventoryLevel = Prefixed_Name(schema1, "inventoryLevel") |> PrefixedName
    /// <summary>
    ///   <para>schema1:isFamilyFriendly</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates whether this content is family friendly.</para>
    /// labels<para>isFamilyFriendly</para></remarks>
    /// <seealso href="http://schema.org/isFamilyFriendly">http://schema.org/isFamilyFriendly</seealso>
    let isFamilyFriendly = Prefixed_Name(schema1, "isFamilyFriendly") |> PrefixedName
    /// <summary>
    ///   <para>schema1:isGift</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Was the offer accepted as a gift for someone other than the buyer.</para>
    /// labels<para>isGift</para></remarks>
    /// <seealso href="http://schema.org/isGift">http://schema.org/isGift</seealso>
    let isGift = Prefixed_Name(schema1, "isGift") |> PrefixedName
    /// <summary>
    ///   <para>schema1:isLiveBroadcast</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>True is the broadcast is of a live event.</para>
    /// labels<para>isLiveBroadcast</para></remarks>
    /// <seealso href="http://schema.org/isLiveBroadcast">http://schema.org/isLiveBroadcast</seealso>
    let isLiveBroadcast = Prefixed_Name(schema1, "isLiveBroadcast") |> PrefixedName
    /// <summary>
    ///   <para>schema1:isRelatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A pointer to another, somehow related product (or multiple products).</para>
    /// labels<para>isRelatedTo</para></remarks>
    /// <seealso href="http://schema.org/isRelatedTo">http://schema.org/isRelatedTo</seealso>
    let isRelatedTo = Prefixed_Name(schema1, "isRelatedTo") |> PrefixedName
    /// <summary>
    ///   <para>schema1:isSimilarTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A pointer to another, functionally similar product (or multiple products).</para>
    /// labels<para>isSimilarTo</para></remarks>
    /// <seealso href="http://schema.org/isSimilarTo">http://schema.org/isSimilarTo</seealso>
    let isSimilarTo = Prefixed_Name(schema1, "isSimilarTo") |> PrefixedName
    /// <summary>
    ///   <para>schema1:isVariantOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A pointer to a base product from which this product is a variant. It is safe to infer that the variant inherits all product features from the base model, unless defined locally. This is not transitive.</para>
    /// labels<para>isVariantOf</para></remarks>
    /// <seealso href="http://schema.org/isVariantOf">http://schema.org/isVariantOf</seealso>
    let isVariantOf = Prefixed_Name(schema1, "isVariantOf") |> PrefixedName
    /// <summary>
    ///   <para>schema1:isbn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ISBN of the book.</para>
    /// labels<para>isbn</para></remarks>
    /// <seealso href="http://schema.org/isbn">http://schema.org/isbn</seealso>
    let isbn = Prefixed_Name(schema1, "isbn") |> PrefixedName
    /// <summary>
    ///   <para>schema1:isicV4</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.</para>
    /// labels<para>isicV4</para></remarks>
    /// <seealso href="http://schema.org/isicV4">http://schema.org/isicV4</seealso>
    let isicV4 = Prefixed_Name(schema1, "isicV4") |> PrefixedName
    /// <summary>
    ///   <para>schema1:isrcCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The International Standard Recording Code for the recording.</para>
    /// labels<para>isrcCode</para></remarks>
    /// <seealso href="http://schema.org/isrcCode">http://schema.org/isrcCode</seealso>
    let isrcCode = Prefixed_Name(schema1, "isrcCode") |> PrefixedName
    /// <summary>
    ///   <para>schema1:issn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The International Standard Serial Number (ISSN) that identifies this serial publication. You can repeat this property to identify different formats of, or the linking ISSN (ISSN-L) for, this serial publication.</para>
    /// labels<para>issn</para></remarks>
    /// <seealso href="http://schema.org/issn">http://schema.org/issn</seealso>
    let issn = Prefixed_Name(schema1, "issn") |> PrefixedName
    /// <summary>
    ///   <para>schema1:issueNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Identifies the issue of publication; for example, "iii" or "2".</para>
    /// labels<para>issueNumber</para></remarks>
    /// <seealso href="http://schema.org/issueNumber">http://schema.org/issueNumber</seealso>
    let issueNumber = Prefixed_Name(schema1, "issueNumber") |> PrefixedName
    /// <summary>
    ///   <para>schema1:issuedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The organization issuing the ticket or permit.</para>
    /// labels<para>issuedBy</para></remarks>
    /// <seealso href="http://schema.org/issuedBy">http://schema.org/issuedBy</seealso>
    let issuedBy = Prefixed_Name(schema1, "issuedBy") |> PrefixedName
    /// <summary>
    ///   <para>schema1:issuedThrough</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The service through with the permit was granted.</para>
    /// labels<para>issuedThrough</para></remarks>
    /// <seealso href="http://schema.org/issuedThrough">http://schema.org/issuedThrough</seealso>
    let issuedThrough = Prefixed_Name(schema1, "issuedThrough") |> PrefixedName
    /// <summary>
    ///   <para>schema1:iswcCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The International Standard Musical Work Code for the composition.</para>
    /// labels<para>iswcCode</para></remarks>
    /// <seealso href="http://schema.org/iswcCode">http://schema.org/iswcCode</seealso>
    let iswcCode = Prefixed_Name(schema1, "iswcCode") |> PrefixedName
    /// <summary>
    ///   <para>schema1:item</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An entity represented by an entry in a list or data feed (e.g. an 'artist' in a list of 'artists')’.</para>
    /// labels<para>item</para></remarks>
    /// <seealso href="http://schema.org/item">http://schema.org/item</seealso>
    let item = Prefixed_Name(schema1, "item") |> PrefixedName
    /// <summary>
    ///   <para>schema1:itemCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A predefined value from OfferItemCondition or a textual description of the condition of the product or service, or the products or services included in the offer.</para>
    /// labels<para>itemCondition</para></remarks>
    /// <seealso href="http://schema.org/itemCondition">http://schema.org/itemCondition</seealso>
    let itemCondition = Prefixed_Name(schema1, "itemCondition") |> PrefixedName
    /// <summary>
    ///   <para>schema1:itemListElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>For itemListElement values, you can use simple strings (e.g. "Peter", "Paul", "Mary"), existing entities, or use ListItem.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Text values are best if the elements in the list are plain strings. Existing entities are best for a simple, unordered list of existing things in your data. ListItem is used with ordered lists when you want to provide additional context about the element in that list or when the same item might be in different places in different lists.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: The order of elements in your mark-up is not sufficient for indicating the order or elements.  Use ListItem with a 'position' property in such cases.</para>
    /// labels<para>itemListElement</para></remarks>
    /// <seealso href="http://schema.org/itemListElement">http://schema.org/itemListElement</seealso>
    let itemListElement = Prefixed_Name(schema1, "itemListElement") |> PrefixedName
    /// <summary>
    ///   <para>schema1:itemListOrder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Type of ordering (e.g. Ascending, Descending, Unordered).</para>
    /// labels<para>itemListOrder</para></remarks>
    /// <seealso href="http://schema.org/itemListOrder">http://schema.org/itemListOrder</seealso>
    let itemListOrder = Prefixed_Name(schema1, "itemListOrder") |> PrefixedName
    /// <summary>
    ///   <para>schema1:itemOffered</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An item being offered (or demanded). The transactional nature of the offer or demand is documented using &lt;a class="localLink" href="http://schema.org/businessFunction"&gt;businessFunction&lt;/a&gt;, e.g. sell, lease etc. While several common expected types are listed explicitly in this definition, others can be used. Using a second type, such as Product or a subtype of Product, can clarify the nature of the offer.</para>
    /// labels<para>itemOffered</para></remarks>
    /// <seealso href="http://schema.org/itemOffered">http://schema.org/itemOffered</seealso>
    let itemOffered = Prefixed_Name(schema1, "itemOffered") |> PrefixedName
    /// <summary>
    ///   <para>schema1:offers</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event. Use &lt;a class="localLink" href="http://schema.org/businessFunction"&gt;businessFunction&lt;/a&gt; to indicate the kind of transaction offered, i.e. sell, lease, etc. This property can also be used to describe a &lt;a class="localLink" href="http://schema.org/Demand"&gt;Demand&lt;/a&gt;. While this property is listed as expected on a number of common types, it can be used in others. In that case, using a second type, such as Product or a subtype of Product, can clarify the nature of the offer.</para>
    /// labels<para>offers</para></remarks>
    /// <seealso href="http://schema.org/offers">http://schema.org/offers</seealso>
    let offers = Prefixed_Name(schema1, "offers") |> PrefixedName

    /// <summary>
    ///   <para>schema1:programMembershipUsed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Any membership in a frequent flyer, hotel loyalty program, etc. being applied to the reservation.</para>
    /// labels<para>programMembershipUsed</para></remarks>
    /// <seealso href="http://schema.org/programMembershipUsed">http://schema.org/programMembershipUsed</seealso>
    let programMembershipUsed =
        Prefixed_Name(schema1, "programMembershipUsed") |> PrefixedName

    /// <summary>
    ///   <para>schema1:programName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The program providing the membership.</para>
    /// labels<para>programName</para></remarks>
    /// <seealso href="http://schema.org/programName">http://schema.org/programName</seealso>
    let programName = Prefixed_Name(schema1, "programName") |> PrefixedName

    /// <summary>
    ///   <para>schema1:programmingLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The computer programming language.</para>
    /// labels<para>programmingLanguage</para></remarks>
    /// <seealso href="http://schema.org/programmingLanguage">http://schema.org/programmingLanguage</seealso>
    let programmingLanguage =
        Prefixed_Name(schema1, "programmingLanguage") |> PrefixedName

    /// <summary>
    ///   <para>schema1:programmingModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates whether API is managed or unmanaged.</para>
    /// labels<para>programmingModel</para></remarks>
    /// <seealso href="http://schema.org/programmingModel">http://schema.org/programmingModel</seealso>
    let programmingModel = Prefixed_Name(schema1, "programmingModel") |> PrefixedName
    /// <summary>
    ///   <para>schema1:propertyID</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A commonly used identifier for the characteristic represented by the property, e.g. a manufacturer or a standard code for a property. propertyID can be
    /// (1) a prefixed string, mainly meant to be used with standards for product properties; (2) a site-specific, non-prefixed string (e.g. the primary key of the property or the vendor-specific id of the property), or (3)
    /// a URL indicating the type of the property, either pointing to an external vocabulary, or a Web resource that describes the property (e.g. a glossary entry).
    /// Standards bodies should promote a standard prefix for the identifiers of properties from their standards.</para>
    /// labels<para>propertyID</para></remarks>
    /// <seealso href="http://schema.org/propertyID">http://schema.org/propertyID</seealso>
    let propertyID = Prefixed_Name(schema1, "propertyID") |> PrefixedName
    /// <summary>
    ///   <para>schema1:proteinContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of grams of protein.</para>
    /// labels<para>proteinContent</para></remarks>
    /// <seealso href="http://schema.org/proteinContent">http://schema.org/proteinContent</seealso>
    let proteinContent = Prefixed_Name(schema1, "proteinContent") |> PrefixedName
    /// <summary>
    ///   <para>schema1:providerMobility</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the mobility of a provided service (e.g. 'static', 'dynamic').</para>
    /// labels<para>providerMobility</para></remarks>
    /// <seealso href="http://schema.org/providerMobility">http://schema.org/providerMobility</seealso>
    let providerMobility = Prefixed_Name(schema1, "providerMobility") |> PrefixedName
    /// <summary>
    ///   <para>schema1:providesService</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The service provided by this channel.</para>
    /// labels<para>providesService</para></remarks>
    /// <seealso href="http://schema.org/providesService">http://schema.org/providesService</seealso>
    let providesService = Prefixed_Name(schema1, "providesService") |> PrefixedName
    /// <summary>
    ///   <para>schema1:publicAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A flag to signal that the &lt;a class="localLink" href="http://schema.org/Place"&gt;Place&lt;/a&gt; is open to public visitors.  If this property is omitted there is no assumed default boolean value</para>
    /// labels<para>publicAccess</para></remarks>
    /// <seealso href="http://schema.org/publicAccess">http://schema.org/publicAccess</seealso>
    let publicAccess = Prefixed_Name(schema1, "publicAccess") |> PrefixedName
    /// <summary>
    ///   <para>schema1:publication</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A publication event associated with the item.</para>
    /// labels<para>publication</para></remarks>
    /// <seealso href="http://schema.org/publication">http://schema.org/publication</seealso>
    let publication = Prefixed_Name(schema1, "publication") |> PrefixedName
    /// <summary>
    ///   <para>schema1:publishedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A broadcast service associated with the publication event.</para>
    /// labels<para>publishedOn</para></remarks>
    /// <seealso href="http://schema.org/publishedOn">http://schema.org/publishedOn</seealso>
    let publishedOn = Prefixed_Name(schema1, "publishedOn") |> PrefixedName
    /// <summary>
    ///   <para>schema1:publisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The publisher of the creative work.</para>
    /// labels<para>publisher</para></remarks>
    /// <seealso href="http://schema.org/publisher">http://schema.org/publisher</seealso>
    let publisher = Prefixed_Name(schema1, "publisher") |> PrefixedName

    /// <summary>
    ///   <para>schema1:publishingPrinciples</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The publishingPrinciples property indicates (typically via &lt;a class="localLink" href="http://schema.org/URL"&gt;URL&lt;/a&gt;) a document describing the editorial principles of an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (or individual e.g. a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt; writing a blog) that relate to their activities as a publisher, e.g. ethics or diversity policies. When applied to a &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt; (e.g. &lt;a class="localLink" href="http://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt;) the principles are those of the party primarily responsible for the creation of the &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
    ///
    /// While such policies are most typically expressed in natural language, sometimes related information (e.g. indicating a &lt;a class="localLink" href="http://schema.org/funder"&gt;funder&lt;/a&gt;) can be expressed using schema.org terminology.</para>
    /// labels<para>publishingPrinciples</para></remarks>
    /// <seealso href="http://schema.org/publishingPrinciples">http://schema.org/publishingPrinciples</seealso>
    let publishingPrinciples =
        Prefixed_Name(schema1, "publishingPrinciples") |> PrefixedName

    /// <summary>
    ///   <para>schema1:purchaseDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The date the item e.g. vehicle was purchased by the current owner.</para>
    /// labels<para>purchaseDate</para></remarks>
    /// <seealso href="http://schema.org/purchaseDate">http://schema.org/purchaseDate</seealso>
    let purchaseDate = Prefixed_Name(schema1, "purchaseDate") |> PrefixedName
    /// <summary>
    ///   <para>schema1:query</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of instrument. The query used on this action.</para>
    /// labels<para>query</para></remarks>
    /// <seealso href="http://schema.org/query">http://schema.org/query</seealso>
    let query = Prefixed_Name(schema1, "query") |> PrefixedName
    /// <summary>
    ///   <para>schema1:quest</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The task that a player-controlled character, or group of characters may complete in order to gain a reward.</para>
    /// labels<para>quest</para></remarks>
    /// <seealso href="http://schema.org/quest">http://schema.org/quest</seealso>
    let quest = Prefixed_Name(schema1, "quest") |> PrefixedName
    /// <summary>
    ///   <para>schema1:question</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of object. A question.</para>
    /// labels<para>question</para></remarks>
    /// <seealso href="http://schema.org/question">http://schema.org/question</seealso>
    let question = Prefixed_Name(schema1, "question") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ratingCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The count of total number of ratings.</para>
    /// labels<para>ratingCount</para></remarks>
    /// <seealso href="http://schema.org/ratingCount">http://schema.org/ratingCount</seealso>
    let ratingCount = Prefixed_Name(schema1, "ratingCount") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ratingValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The rating for the content.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Usage guidelines:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
    /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>ratingValue</para></remarks>
    /// <seealso href="http://schema.org/ratingValue">http://schema.org/ratingValue</seealso>
    let ratingValue = Prefixed_Name(schema1, "ratingValue") |> PrefixedName
    /// <summary>
    ///   <para>schema1:readonlyValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether or not a property is mutable.  Default is false. Specifying this for a property that also has a value makes it act similar to a "hidden" input in an HTML form.</para>
    /// labels<para>readonlyValue</para></remarks>
    /// <seealso href="http://schema.org/readonlyValue">http://schema.org/readonlyValue</seealso>
    let readonlyValue = Prefixed_Name(schema1, "readonlyValue") |> PrefixedName
    /// <summary>
    ///   <para>schema1:recipeYield</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The quantity produced by the recipe (for example, number of people served, number of servings, etc).</para>
    /// labels<para>recipeYield</para></remarks>
    /// <seealso href="http://schema.org/recipeYield">http://schema.org/recipeYield</seealso>
    let recipeYield = Prefixed_Name(schema1, "recipeYield") |> PrefixedName
    /// <summary>
    ///   <para>schema1:yield</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The quantity that results by performing instructions. For example, a paper airplane, 10 personalized candles.</para>
    /// labels<para>yield</para></remarks>
    /// <seealso href="http://schema.org/yield">http://schema.org/yield</seealso>
    let yield_ = Prefixed_Name(schema1, "yield") |> PrefixedName
    /// <summary>
    ///   <para>schema1:recordLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The label that issued the release.</para>
    /// labels<para>recordLabel</para></remarks>
    /// <seealso href="http://schema.org/recordLabel">http://schema.org/recordLabel</seealso>
    let recordLabel = Prefixed_Name(schema1, "recordLabel") |> PrefixedName
    /// <summary>
    ///   <para>schema1:recordedAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An audio recording of the work.</para>
    /// labels<para>recordedAs</para></remarks>
    /// <seealso href="http://schema.org/recordedAs">http://schema.org/recordedAs</seealso>
    let recordedAs = Prefixed_Name(schema1, "recordedAs") |> PrefixedName
    /// <summary>
    ///   <para>schema1:recordingOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The composition this track is a recording of.</para>
    /// labels<para>recordingOf</para></remarks>
    /// <seealso href="http://schema.org/recordingOf">http://schema.org/recordingOf</seealso>
    let recordingOf = Prefixed_Name(schema1, "recordingOf") |> PrefixedName
    /// <summary>
    ///   <para>schema1:recordedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Event where the CreativeWork was recorded. The CreativeWork may capture all or part of the event.</para>
    /// labels<para>recordedAt</para></remarks>
    /// <seealso href="http://schema.org/recordedAt">http://schema.org/recordedAt</seealso>
    let recordedAt = Prefixed_Name(schema1, "recordedAt") |> PrefixedName
    /// <summary>
    ///   <para>schema1:recordedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The CreativeWork that captured all or part of this Event.</para>
    /// labels<para>recordedIn</para></remarks>
    /// <seealso href="http://schema.org/recordedIn">http://schema.org/recordedIn</seealso>
    let recordedIn = Prefixed_Name(schema1, "recordedIn") |> PrefixedName
    /// <summary>
    ///   <para>schema1:referenceQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The reference quantity for which a certain price applies, e.g. 1 EUR per 4 kWh of electricity. This property is a replacement for unitOfMeasurement for the advanced cases where the price does not relate to a standard unit.</para>
    /// labels<para>referenceQuantity</para></remarks>
    /// <seealso href="http://schema.org/referenceQuantity">http://schema.org/referenceQuantity</seealso>
    let referenceQuantity = Prefixed_Name(schema1, "referenceQuantity") |> PrefixedName
    /// <summary>
    ///   <para>schema1:referencesOrder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Order(s) related to this Invoice. One or more Orders may be combined into a single Invoice.</para>
    /// labels<para>referencesOrder</para></remarks>
    /// <seealso href="http://schema.org/referencesOrder">http://schema.org/referencesOrder</seealso>
    let referencesOrder = Prefixed_Name(schema1, "referencesOrder") |> PrefixedName
    /// <summary>
    ///   <para>schema1:regionsAllowed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The regions where the media is allowed. If not specified, then it's assumed to be allowed everywhere. Specify the countries in &lt;a href="http://en.wikipedia.org/wiki/ISO_3166"&gt;ISO 3166 format&lt;/a&gt;.</para>
    /// labels<para>regionsAllowed</para></remarks>
    /// <seealso href="http://schema.org/regionsAllowed">http://schema.org/regionsAllowed</seealso>
    let regionsAllowed = Prefixed_Name(schema1, "regionsAllowed") |> PrefixedName
    /// <summary>
    ///   <para>schema1:relatedLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A link related to this web page, for example to other related web pages.</para>
    /// labels<para>relatedLink</para></remarks>
    /// <seealso href="http://schema.org/relatedLink">http://schema.org/relatedLink</seealso>
    let relatedLink = Prefixed_Name(schema1, "relatedLink") |> PrefixedName
    /// <summary>
    ///   <para>schema1:relatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The most generic familial relation.</para>
    /// labels<para>relatedTo</para></remarks>
    /// <seealso href="http://schema.org/relatedTo">http://schema.org/relatedTo</seealso>
    let relatedTo = Prefixed_Name(schema1, "relatedTo") |> PrefixedName
    /// <summary>
    ///   <para>schema1:releaseDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The release date of a product or product model. This can be used to distinguish the exact variant of a product.</para>
    /// labels<para>releaseDate</para></remarks>
    /// <seealso href="http://schema.org/releaseDate">http://schema.org/releaseDate</seealso>
    let releaseDate = Prefixed_Name(schema1, "releaseDate") |> PrefixedName
    /// <summary>
    ///   <para>schema1:releaseNotes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Description of what changed in this version.</para>
    /// labels<para>releaseNotes</para></remarks>
    /// <seealso href="http://schema.org/releaseNotes">http://schema.org/releaseNotes</seealso>
    let releaseNotes = Prefixed_Name(schema1, "releaseNotes") |> PrefixedName
    /// <summary>
    ///   <para>schema1:releasedEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The place and time the release was issued, expressed as a PublicationEvent.</para>
    /// labels<para>releasedEvent</para></remarks>
    /// <seealso href="http://schema.org/releasedEvent">http://schema.org/releasedEvent</seealso>
    let releasedEvent = Prefixed_Name(schema1, "releasedEvent") |> PrefixedName

    /// <summary>
    ///   <para>schema1:relevantOccupation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Occupation for the JobPosting.</para>
    /// labels<para>relevantOccupation</para></remarks>
    /// <seealso href="http://schema.org/relevantOccupation">http://schema.org/relevantOccupation</seealso>
    let relevantOccupation =
        Prefixed_Name(schema1, "relevantOccupation") |> PrefixedName

    /// <summary>
    ///   <para>schema1:remainingAttendeeCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of attendee places for an event that remain unallocated.</para>
    /// labels<para>remainingAttendeeCapacity</para></remarks>
    /// <seealso href="http://schema.org/remainingAttendeeCapacity">http://schema.org/remainingAttendeeCapacity</seealso>
    let remainingAttendeeCapacity =
        Prefixed_Name(schema1, "remainingAttendeeCapacity") |> PrefixedName

    /// <summary>
    ///   <para>schema1:replacee</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of object. The object that is being replaced.</para>
    /// labels<para>replacee</para></remarks>
    /// <seealso href="http://schema.org/replacee">http://schema.org/replacee</seealso>
    let replacee = Prefixed_Name(schema1, "replacee") |> PrefixedName
    /// <summary>
    ///   <para>schema1:replacer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of object. The object that replaces.</para>
    /// labels<para>replacer</para></remarks>
    /// <seealso href="http://schema.org/replacer">http://schema.org/replacer</seealso>
    let replacer = Prefixed_Name(schema1, "replacer") |> PrefixedName
    /// <summary>
    ///   <para>schema1:replyToUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The URL at which a reply may be posted to the specified UserComment.</para>
    /// labels<para>replyToUrl</para></remarks>
    /// <seealso href="http://schema.org/replyToUrl">http://schema.org/replyToUrl</seealso>
    let replyToUrl = Prefixed_Name(schema1, "replyToUrl") |> PrefixedName
    /// <summary>
    ///   <para>schema1:requiredMaxAge</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Audiences defined by a person's maximum age.</para>
    /// labels<para>requiredMaxAge</para></remarks>
    /// <seealso href="http://schema.org/requiredMaxAge">http://schema.org/requiredMaxAge</seealso>
    let requiredMaxAge = Prefixed_Name(schema1, "requiredMaxAge") |> PrefixedName
    /// <summary>
    ///   <para>schema1:requiredMinAge</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Audiences defined by a person's minimum age.</para>
    /// labels<para>requiredMinAge</para></remarks>
    /// <seealso href="http://schema.org/requiredMinAge">http://schema.org/requiredMinAge</seealso>
    let requiredMinAge = Prefixed_Name(schema1, "requiredMinAge") |> PrefixedName
    /// <summary>
    ///   <para>schema1:requiredQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The required quantity of the item(s).</para>
    /// labels<para>requiredQuantity</para></remarks>
    /// <seealso href="http://schema.org/requiredQuantity">http://schema.org/requiredQuantity</seealso>
    let requiredQuantity = Prefixed_Name(schema1, "requiredQuantity") |> PrefixedName
    /// <summary>
    ///   <para>schema1:requirements</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Component dependency requirements for application. This includes runtime environments and shared libraries that are not included in the application distribution package, but required to run the application (Examples: DirectX, Java or .NET runtime).</para>
    /// labels<para>requirements</para></remarks>
    /// <seealso href="http://schema.org/requirements">http://schema.org/requirements</seealso>
    let requirements = Prefixed_Name(schema1, "requirements") |> PrefixedName

    /// <summary>
    ///   <para>schema1:softwareRequirements</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Component dependency requirements for application. This includes runtime environments and shared libraries that are not included in the application distribution package, but required to run the application (Examples: DirectX, Java or .NET runtime).</para>
    /// labels<para>softwareRequirements</para></remarks>
    /// <seealso href="http://schema.org/softwareRequirements">http://schema.org/softwareRequirements</seealso>
    let softwareRequirements =
        Prefixed_Name(schema1, "softwareRequirements") |> PrefixedName

    /// <summary>
    ///   <para>schema1:requiresSubscription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates if use of the media require a subscription  (either paid or free). Allowed values are &lt;code&gt;true&lt;/code&gt; or &lt;code&gt;false&lt;/code&gt; (note that an earlier version had 'yes', 'no').</para>
    /// labels<para>requiresSubscription</para></remarks>
    /// <seealso href="http://schema.org/requiresSubscription">http://schema.org/requiresSubscription</seealso>
    let requiresSubscription =
        Prefixed_Name(schema1, "requiresSubscription") |> PrefixedName

    /// <summary>
    ///   <para>schema1:reservationFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The thing -- flight, event, restaurant,etc. being reserved.</para>
    /// labels<para>reservationFor</para></remarks>
    /// <seealso href="http://schema.org/reservationFor">http://schema.org/reservationFor</seealso>
    let reservationFor = Prefixed_Name(schema1, "reservationFor") |> PrefixedName
    /// <summary>
    ///   <para>schema1:reservationId</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A unique identifier for the reservation.</para>
    /// labels<para>reservationId</para></remarks>
    /// <seealso href="http://schema.org/reservationId">http://schema.org/reservationId</seealso>
    let reservationId = Prefixed_Name(schema1, "reservationId") |> PrefixedName
    /// <summary>
    ///   <para>schema1:reservationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The current status of the reservation.</para>
    /// labels<para>reservationStatus</para></remarks>
    /// <seealso href="http://schema.org/reservationStatus">http://schema.org/reservationStatus</seealso>
    let reservationStatus = Prefixed_Name(schema1, "reservationStatus") |> PrefixedName
    /// <summary>
    ///   <para>schema1:reservedTicket</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A ticket associated with the reservation.</para>
    /// labels<para>reservedTicket</para></remarks>
    /// <seealso href="http://schema.org/reservedTicket">http://schema.org/reservedTicket</seealso>
    let reservedTicket = Prefixed_Name(schema1, "reservedTicket") |> PrefixedName
    /// <summary>
    ///   <para>schema1:responsibilities</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Responsibilities associated with this role or Occupation.</para>
    /// labels<para>responsibilities</para></remarks>
    /// <seealso href="http://schema.org/responsibilities">http://schema.org/responsibilities</seealso>
    let responsibilities = Prefixed_Name(schema1, "responsibilities") |> PrefixedName
    /// <summary>
    ///   <para>schema1:result</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The result produced in the action. e.g. John wrote &lt;em&gt;a book&lt;/em&gt;.</para>
    /// labels<para>result</para></remarks>
    /// <seealso href="http://schema.org/result">http://schema.org/result</seealso>
    let result = Prefixed_Name(schema1, "result") |> PrefixedName
    /// <summary>
    ///   <para>schema1:resultComment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of result. The Comment created or sent as a result of this action.</para>
    /// labels<para>resultComment</para></remarks>
    /// <seealso href="http://schema.org/resultComment">http://schema.org/resultComment</seealso>
    let resultComment = Prefixed_Name(schema1, "resultComment") |> PrefixedName
    /// <summary>
    ///   <para>schema1:resultReview</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of result. The review that resulted in the performing of the action.</para>
    /// labels<para>resultReview</para></remarks>
    /// <seealso href="http://schema.org/resultReview">http://schema.org/resultReview</seealso>
    let resultReview = Prefixed_Name(schema1, "resultReview") |> PrefixedName
    /// <summary>
    ///   <para>schema1:review</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A review of the item.</para>
    /// labels<para>review</para></remarks>
    /// <seealso href="http://schema.org/review">http://schema.org/review</seealso>
    let review = Prefixed_Name(schema1, "review") |> PrefixedName
    /// <summary>
    ///   <para>schema1:reviewAspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This Review or Rating is relevant to this part or facet of the itemReviewed.</para>
    /// labels<para>reviewAspect</para></remarks>
    /// <seealso href="http://schema.org/reviewAspect">http://schema.org/reviewAspect</seealso>
    let reviewAspect = Prefixed_Name(schema1, "reviewAspect") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Guide</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schema.org/Guide">http://schema.org/Guide</seealso>
    let Guide = Prefixed_Name(schema1, "Guide") |> PrefixedName
    /// <summary>
    ///   <para>schema1:reviewBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The actual body of the review.</para>
    /// labels<para>reviewBody</para></remarks>
    /// <seealso href="http://schema.org/reviewBody">http://schema.org/reviewBody</seealso>
    let reviewBody = Prefixed_Name(schema1, "reviewBody") |> PrefixedName
    /// <summary>
    ///   <para>schema1:reviewCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The count of total number of reviews.</para>
    /// labels<para>reviewCount</para></remarks>
    /// <seealso href="http://schema.org/reviewCount">http://schema.org/reviewCount</seealso>
    let reviewCount = Prefixed_Name(schema1, "reviewCount") |> PrefixedName
    /// <summary>
    ///   <para>schema1:reviewRating</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The rating given in this review. Note that reviews can themselves be rated. The &lt;code&gt;reviewRating&lt;/code&gt; applies to rating given by the review. The &lt;a class="localLink" href="http://schema.org/aggregateRating"&gt;aggregateRating&lt;/a&gt; property applies to the review itself, as a creative work.</para>
    /// labels<para>reviewRating</para></remarks>
    /// <seealso href="http://schema.org/reviewRating">http://schema.org/reviewRating</seealso>
    let reviewRating = Prefixed_Name(schema1, "reviewRating") |> PrefixedName
    /// <summary>
    ///   <para>schema1:reviewedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>People or organizations that have reviewed the content on this web page for accuracy and/or completeness.</para>
    /// labels<para>reviewedBy</para></remarks>
    /// <seealso href="http://schema.org/reviewedBy">http://schema.org/reviewedBy</seealso>
    let reviewedBy = Prefixed_Name(schema1, "reviewedBy") |> PrefixedName
    /// <summary>
    ///   <para>schema1:reviews</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Review of the item.</para>
    /// labels<para>reviews</para></remarks>
    /// <seealso href="http://schema.org/reviews">http://schema.org/reviews</seealso>
    let reviews = Prefixed_Name(schema1, "reviews") |> PrefixedName

    /// <summary>
    ///   <para>schema1:scheduledPaymentDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The date the invoice is scheduled to be paid.</para>
    /// labels<para>scheduledPaymentDate</para></remarks>
    /// <seealso href="http://schema.org/scheduledPaymentDate">http://schema.org/scheduledPaymentDate</seealso>
    let scheduledPaymentDate =
        Prefixed_Name(schema1, "scheduledPaymentDate") |> PrefixedName

    /// <summary>
    ///   <para>schema1:scheduledTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The time the object is scheduled to.</para>
    /// labels<para>scheduledTime</para></remarks>
    /// <seealso href="http://schema.org/scheduledTime">http://schema.org/scheduledTime</seealso>
    let scheduledTime = Prefixed_Name(schema1, "scheduledTime") |> PrefixedName
    /// <summary>
    ///   <para>schema1:schemaVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates (by URL or string) a particular version of a schema used in some CreativeWork. For example, a document could declare a schemaVersion using an URL such as http://schema.org/version/2.0/ if precise indication of schema version was required by some application.</para>
    /// labels<para>schemaVersion</para></remarks>
    /// <seealso href="http://schema.org/schemaVersion">http://schema.org/schemaVersion</seealso>
    let schemaVersion = Prefixed_Name(schema1, "schemaVersion") |> PrefixedName
    /// <summary>
    ///   <para>schema1:screenCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of screens in the movie theater.</para>
    /// labels<para>screenCount</para></remarks>
    /// <seealso href="http://schema.org/screenCount">http://schema.org/screenCount</seealso>
    let screenCount = Prefixed_Name(schema1, "screenCount") |> PrefixedName
    /// <summary>
    ///   <para>schema1:screenshot</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A link to a screenshot image of the app.</para>
    /// labels<para>screenshot</para></remarks>
    /// <seealso href="http://schema.org/screenshot">http://schema.org/screenshot</seealso>
    let screenshot = Prefixed_Name(schema1, "screenshot") |> PrefixedName
    /// <summary>
    ///   <para>schema1:season</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A season in a media series.</para>
    /// labels<para>season</para></remarks>
    /// <seealso href="http://schema.org/season">http://schema.org/season</seealso>
    let season = Prefixed_Name(schema1, "season") |> PrefixedName
    /// <summary>
    ///   <para>schema1:seasonNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Position of the season within an ordered group of seasons.</para>
    /// labels<para>seasonNumber</para></remarks>
    /// <seealso href="http://schema.org/seasonNumber">http://schema.org/seasonNumber</seealso>
    let seasonNumber = Prefixed_Name(schema1, "seasonNumber") |> PrefixedName
    /// <summary>
    ///   <para>schema1:seasons</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A season in a media series.</para>
    /// labels<para>seasons</para></remarks>
    /// <seealso href="http://schema.org/seasons">http://schema.org/seasons</seealso>
    let seasons = Prefixed_Name(schema1, "seasons") |> PrefixedName
    /// <summary>
    ///   <para>schema1:seatNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The location of the reserved seat (e.g., 27).</para>
    /// labels<para>seatNumber</para></remarks>
    /// <seealso href="http://schema.org/seatNumber">http://schema.org/seatNumber</seealso>
    let seatNumber = Prefixed_Name(schema1, "seatNumber") |> PrefixedName
    /// <summary>
    ///   <para>schema1:seatRow</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The row location of the reserved seat (e.g., B).</para>
    /// labels<para>seatRow</para></remarks>
    /// <seealso href="http://schema.org/seatRow">http://schema.org/seatRow</seealso>
    let seatRow = Prefixed_Name(schema1, "seatRow") |> PrefixedName
    /// <summary>
    ///   <para>schema1:seatSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The section location of the reserved seat (e.g. Orchestra).</para>
    /// labels<para>seatSection</para></remarks>
    /// <seealso href="http://schema.org/seatSection">http://schema.org/seatSection</seealso>
    let seatSection = Prefixed_Name(schema1, "seatSection") |> PrefixedName
    /// <summary>
    ///   <para>schema1:seatingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The type/class of the seat.</para>
    /// labels<para>seatingType</para></remarks>
    /// <seealso href="http://schema.org/seatingType">http://schema.org/seatingType</seealso>
    let seatingType = Prefixed_Name(schema1, "seatingType") |> PrefixedName
    /// <summary>
    ///   <para>schema1:securityScreening</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The type of security screening the passenger is subject to.</para>
    /// labels<para>securityScreening</para></remarks>
    /// <seealso href="http://schema.org/securityScreening">http://schema.org/securityScreening</seealso>
    let securityScreening = Prefixed_Name(schema1, "securityScreening") |> PrefixedName
    /// <summary>
    ///   <para>schema1:seeks</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A pointer to products or services sought by the organization or person (demand).</para>
    /// labels<para>seeks</para></remarks>
    /// <seealso href="http://schema.org/seeks">http://schema.org/seeks</seealso>
    let seeks = Prefixed_Name(schema1, "seeks") |> PrefixedName
    /// <summary>
    ///   <para>schema1:sender</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of participant. The participant who is at the sending end of the action.</para>
    /// labels<para>sender</para></remarks>
    /// <seealso href="http://schema.org/sender">http://schema.org/sender</seealso>
    let sender = Prefixed_Name(schema1, "sender") |> PrefixedName
    /// <summary>
    ///   <para>schema1:serialNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The serial number or any alphanumeric identifier of a particular product. When attached to an offer, it is a shortcut for the serial number of the product included in the offer.</para>
    /// labels<para>serialNumber</para></remarks>
    /// <seealso href="http://schema.org/serialNumber">http://schema.org/serialNumber</seealso>
    let serialNumber = Prefixed_Name(schema1, "serialNumber") |> PrefixedName
    /// <summary>
    ///   <para>schema1:serverStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Status of a game server.</para>
    /// labels<para>serverStatus</para></remarks>
    /// <seealso href="http://schema.org/serverStatus">http://schema.org/serverStatus</seealso>
    let serverStatus = Prefixed_Name(schema1, "serverStatus") |> PrefixedName
    /// <summary>
    ///   <para>schema1:servesCuisine</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The cuisine of the restaurant.</para>
    /// labels<para>servesCuisine</para></remarks>
    /// <seealso href="http://schema.org/servesCuisine">http://schema.org/servesCuisine</seealso>
    let servesCuisine = Prefixed_Name(schema1, "servesCuisine") |> PrefixedName
    /// <summary>
    ///   <para>schema1:serviceAudience</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The audience eligible for this service.</para>
    /// labels<para>serviceAudience</para></remarks>
    /// <seealso href="http://schema.org/serviceAudience">http://schema.org/serviceAudience</seealso>
    let serviceAudience = Prefixed_Name(schema1, "serviceAudience") |> PrefixedName
    /// <summary>
    ///   <para>schema1:serviceLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The location (e.g. civic structure, local business, etc.) where a person can go to access the service.</para>
    /// labels<para>serviceLocation</para></remarks>
    /// <seealso href="http://schema.org/serviceLocation">http://schema.org/serviceLocation</seealso>
    let serviceLocation = Prefixed_Name(schema1, "serviceLocation") |> PrefixedName
    /// <summary>
    ///   <para>schema1:serviceOperator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The operating organization, if different from the provider.  This enables the representation of services that are provided by an organization, but operated by another organization like a subcontractor.</para>
    /// labels<para>serviceOperator</para></remarks>
    /// <seealso href="http://schema.org/serviceOperator">http://schema.org/serviceOperator</seealso>
    let serviceOperator = Prefixed_Name(schema1, "serviceOperator") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Accommodation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An accommodation is a place that can accommodate human beings, e.g. a hotel room, a camping pitch, or a meeting room. Many accommodations are for overnight stays, but this is not a mandatory requirement.
    /// For more specific types of accommodations not defined in schema.org, one can use additionalType with external vocabularies.
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.</para>
    /// labels<para>Accommodation</para></remarks>
    /// <seealso href="http://schema.org/Accommodation">http://schema.org/Accommodation</seealso>
    let Accommodation = Prefixed_Name(schema1, "Accommodation") |> PrefixedName
    /// <summary>
    ///   <para>schema1:AccountingService</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Accountancy business.&lt;br/&gt;&lt;br/&gt;
    ///
    /// As a &lt;a class="localLink" href="http://schema.org/LocalBusiness"&gt;LocalBusiness&lt;/a&gt; it can be described as a &lt;a class="localLink" href="http://schema.org/provider"&gt;provider&lt;/a&gt; of one or more &lt;a class="localLink" href="http://schema.org/Service"&gt;Service&lt;/a&gt;(s).</para>
    /// labels<para>AccountingService</para></remarks>
    /// <seealso href="http://schema.org/AccountingService">http://schema.org/AccountingService</seealso>
    let AccountingService = Prefixed_Name(schema1, "AccountingService") |> PrefixedName
    /// <summary>
    ///   <para>schema1:AchieveAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of accomplishing something via previous efforts. It is an instantaneous action rather than an ongoing process.</para>
    /// labels<para>AchieveAction</para></remarks>
    /// <seealso href="http://schema.org/AchieveAction">http://schema.org/AchieveAction</seealso>
    let AchieveAction = Prefixed_Name(schema1, "AchieveAction") |> PrefixedName

    /// <summary>
    ///   <para>schema1:EmployerAggregateRating</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An aggregate rating of an Organization related to its role as an employer.</para>
    /// labels<para>EmployerAggregateRating</para></remarks>
    /// <seealso href="http://schema.org/EmployerAggregateRating">http://schema.org/EmployerAggregateRating</seealso>
    let EmployerAggregateRating =
        Prefixed_Name(schema1, "EmployerAggregateRating") |> PrefixedName

    /// <summary>
    ///   <para>schema1:EndorseAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An agent approves/certifies/likes/supports/sanction an object.</para>
    /// labels<para>EndorseAction</para></remarks>
    /// <seealso href="http://schema.org/EndorseAction">http://schema.org/EndorseAction</seealso>
    let EndorseAction = Prefixed_Name(schema1, "EndorseAction") |> PrefixedName

    /// <summary>
    ///   <para>schema1:EngineSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Information about the engine of the vehicle. A vehicle can have multiple engines represented by multiple engine specification entities.</para>
    /// labels<para>EngineSpecification</para></remarks>
    /// <seealso href="http://schema.org/EngineSpecification">http://schema.org/EngineSpecification</seealso>
    let EngineSpecification =
        Prefixed_Name(schema1, "EngineSpecification") |> PrefixedName

    /// <summary>
    ///   <para>schema1:EventCancelled</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:EventStatusType</para>
    ///   <para>The event has been cancelled. If the event has multiple startDate values, all are assumed to be cancelled. Either startDate or previousStartDate may be used to specify the event's cancelled date(s).</para>
    /// labels<para>EventCancelled</para></remarks>
    /// <seealso href="http://schema.org/EventCancelled">http://schema.org/EventCancelled</seealso>
    let EventCancelled = Prefixed_Name(schema1, "EventCancelled") |> PrefixedName
    /// <summary>
    ///   <para>schema1:EventPostponed</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:EventStatusType</para>
    ///   <para>The event has been postponed and no new date has been set. The event's previousStartDate should be set.</para>
    /// labels<para>EventPostponed</para></remarks>
    /// <seealso href="http://schema.org/EventPostponed">http://schema.org/EventPostponed</seealso>
    let EventPostponed = Prefixed_Name(schema1, "EventPostponed") |> PrefixedName
    /// <summary>
    ///   <para>schema1:EventRescheduled</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:EventStatusType</para>
    ///   <para>The event has been rescheduled. The event's previousStartDate should be set to the old date and the startDate should be set to the event's new date. (If the event has been rescheduled multiple times, the previousStartDate property may be repeated).</para>
    /// labels<para>EventRescheduled</para></remarks>
    /// <seealso href="http://schema.org/EventRescheduled">http://schema.org/EventRescheduled</seealso>
    let EventRescheduled = Prefixed_Name(schema1, "EventRescheduled") |> PrefixedName
    /// <summary>
    ///   <para>schema1:EventVenue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An event venue.</para>
    /// labels<para>EventVenue</para></remarks>
    /// <seealso href="http://schema.org/EventVenue">http://schema.org/EventVenue</seealso>
    let EventVenue = Prefixed_Name(schema1, "EventVenue") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ExerciseGym</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A gym.</para>
    /// labels<para>ExerciseGym</para></remarks>
    /// <seealso href="http://schema.org/ExerciseGym">http://schema.org/ExerciseGym</seealso>
    let ExerciseGym = Prefixed_Name(schema1, "ExerciseGym") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ExhibitionEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Event type: Exhibition event, e.g. at a museum, library, archive, tradeshow, ...</para>
    /// labels<para>ExhibitionEvent</para></remarks>
    /// <seealso href="http://schema.org/ExhibitionEvent">http://schema.org/ExhibitionEvent</seealso>
    let ExhibitionEvent = Prefixed_Name(schema1, "ExhibitionEvent") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Occupation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A profession, may involve prolonged training and/or a formal qualification.</para>
    /// labels<para>Occupation</para></remarks>
    /// <seealso href="http://schema.org/Occupation">http://schema.org/Occupation</seealso>
    let Occupation = Prefixed_Name(schema1, "Occupation") |> PrefixedName

    /// <summary>
    ///   <para>schema1:OfficeEquipmentStore</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An office equipment store.</para>
    /// labels<para>OfficeEquipmentStore</para></remarks>
    /// <seealso href="http://schema.org/OfficeEquipmentStore">http://schema.org/OfficeEquipmentStore</seealso>
    let OfficeEquipmentStore =
        Prefixed_Name(schema1, "OfficeEquipmentStore") |> PrefixedName

    /// <summary>
    ///   <para>schema1:OfflinePermanently</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:GameServerStatus</para>
    ///   <para>Game server status: OfflinePermanently. Server is offline and not available.</para>
    /// labels<para>OfflinePermanently</para></remarks>
    /// <seealso href="http://schema.org/OfflinePermanently">http://schema.org/OfflinePermanently</seealso>
    let OfflinePermanently =
        Prefixed_Name(schema1, "OfflinePermanently") |> PrefixedName

    /// <summary>
    ///   <para>schema1:OfflineTemporarily</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:GameServerStatus</para>
    ///   <para>Game server status: OfflineTemporarily. Server is offline now but it can be online soon.</para>
    /// labels<para>OfflineTemporarily</para></remarks>
    /// <seealso href="http://schema.org/OfflineTemporarily">http://schema.org/OfflineTemporarily</seealso>
    let OfflineTemporarily =
        Prefixed_Name(schema1, "OfflineTemporarily") |> PrefixedName

    /// <summary>
    ///   <para>schema1:Online</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:GameServerStatus</para>
    ///   <para>Game server status: Online. Server is available.</para>
    /// labels<para>Online</para></remarks>
    /// <seealso href="http://schema.org/Online">http://schema.org/Online</seealso>
    let Online = Prefixed_Name(schema1, "Online") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Order</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An order is a confirmation of a transaction (a receipt), which can contain multiple line items, each represented by an Offer that has been accepted by the customer.</para>
    /// labels<para>Order</para></remarks>
    /// <seealso href="http://schema.org/Order">http://schema.org/Order</seealso>
    let Order = Prefixed_Name(schema1, "Order") |> PrefixedName
    /// <summary>
    ///   <para>schema1:OrderAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An agent orders an object/product/service to be delivered/sent.</para>
    /// labels<para>OrderAction</para></remarks>
    /// <seealso href="http://schema.org/OrderAction">http://schema.org/OrderAction</seealso>
    let OrderAction = Prefixed_Name(schema1, "OrderAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:OrderInTransit</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:OrderStatus</para>
    ///   <para>OrderStatus representing that an order is in transit.</para>
    /// labels<para>OrderInTransit</para></remarks>
    /// <seealso href="http://schema.org/OrderInTransit">http://schema.org/OrderInTransit</seealso>
    let OrderInTransit = Prefixed_Name(schema1, "OrderInTransit") |> PrefixedName
    /// <summary>
    ///   <para>schema1:OrderItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An order item is a line of an order. It includes the quantity and shipping details of a bought offer.</para>
    /// labels<para>OrderItem</para></remarks>
    /// <seealso href="http://schema.org/OrderItem">http://schema.org/OrderItem</seealso>
    let OrderItem = Prefixed_Name(schema1, "OrderItem") |> PrefixedName
    /// <summary>
    ///   <para>schema1:OrderProblem</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:OrderStatus</para>
    ///   <para>OrderStatus representing that there is a problem with the order.</para>
    /// labels<para>OrderProblem</para></remarks>
    /// <seealso href="http://schema.org/OrderProblem">http://schema.org/OrderProblem</seealso>
    let OrderProblem = Prefixed_Name(schema1, "OrderProblem") |> PrefixedName
    /// <summary>
    ///   <para>schema1:OrderProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:OrderStatus</para>
    ///   <para>OrderStatus representing that an order is being processed.</para>
    /// labels<para>OrderProcessing</para></remarks>
    /// <seealso href="http://schema.org/OrderProcessing">http://schema.org/OrderProcessing</seealso>
    let OrderProcessing = Prefixed_Name(schema1, "OrderProcessing") |> PrefixedName
    /// <summary>
    ///   <para>schema1:OrderReturned</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:OrderStatus</para>
    ///   <para>OrderStatus representing that an order has been returned.</para>
    /// labels<para>OrderReturned</para></remarks>
    /// <seealso href="http://schema.org/OrderReturned">http://schema.org/OrderReturned</seealso>
    let OrderReturned = Prefixed_Name(schema1, "OrderReturned") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Represents additional information about a relationship or property. For example a Role can be used to say that a 'member' role linking some SportsTeam to a player occurred during a particular time period. Or that a Person's 'actor' role in a Movie was for some particular characterName. Such properties can be attached to a Role entity, which is then associated with the main entities using ordinary properties like 'member' or 'actor'.&lt;br/&gt;&lt;br/&gt;
    ///
    /// See also &lt;a href="http://blog.schema.org/2014/06/introducing-role.html"&gt;blog post&lt;/a&gt;.</para>
    /// labels<para>Role</para></remarks>
    /// <seealso href="http://schema.org/Role">http://schema.org/Role</seealso>
    let Role = Prefixed_Name(schema1, "Role") |> PrefixedName
    /// <summary>
    ///   <para>schema1:OutOfStock</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:ItemAvailability</para>
    ///   <para>Indicates that the item is out of stock.</para>
    /// labels<para>OutOfStock</para></remarks>
    /// <seealso href="http://schema.org/OutOfStock">http://schema.org/OutOfStock</seealso>
    let OutOfStock = Prefixed_Name(schema1, "OutOfStock") |> PrefixedName
    /// <summary>
    ///   <para>schema1:PaintAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of producing a painting, typically with paint and canvas as instruments.</para>
    /// labels<para>PaintAction</para></remarks>
    /// <seealso href="http://schema.org/PaintAction">http://schema.org/PaintAction</seealso>
    let PaintAction = Prefixed_Name(schema1, "PaintAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Painting</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A painting.</para>
    /// labels<para>Painting</para></remarks>
    /// <seealso href="http://schema.org/Painting">http://schema.org/Painting</seealso>
    let Painting = Prefixed_Name(schema1, "Painting") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ParcelDelivery</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The delivery of a parcel either via the postal service or a commercial service.</para>
    /// labels<para>ParcelDelivery</para></remarks>
    /// <seealso href="http://schema.org/ParcelDelivery">http://schema.org/ParcelDelivery</seealso>
    let ParcelDelivery = Prefixed_Name(schema1, "ParcelDelivery") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ParcelService</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A private parcel service as the delivery mode available for a certain offer.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Commonly used values:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#DHL&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#FederalExpress&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#UPS&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>ParcelService</para></remarks>
    /// <seealso href="http://schema.org/ParcelService">http://schema.org/ParcelService</seealso>
    let ParcelService = Prefixed_Name(schema1, "ParcelService") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ParentAudience</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A set of characteristics describing parents, who can be interested in viewing some content.</para>
    /// labels<para>ParentAudience</para></remarks>
    /// <seealso href="http://schema.org/ParentAudience">http://schema.org/ParentAudience</seealso>
    let ParentAudience = Prefixed_Name(schema1, "ParentAudience") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ParkingFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A parking lot or other parking facility.</para>
    /// labels<para>ParkingFacility</para></remarks>
    /// <seealso href="http://schema.org/ParkingFacility">http://schema.org/ParkingFacility</seealso>
    let ParkingFacility = Prefixed_Name(schema1, "ParkingFacility") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ParkingMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:MapCategoryType</para>
    ///   <para>A parking map.</para>
    /// labels<para>ParkingMap</para></remarks>
    /// <seealso href="http://schema.org/ParkingMap">http://schema.org/ParkingMap</seealso>
    let ParkingMap = Prefixed_Name(schema1, "ParkingMap") |> PrefixedName

    /// <summary>
    ///   <para>schema1:PaymentAutomaticallyApplied</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:PaymentStatusType</para>
    ///   <para>An automatic payment system is in place and will be used.</para>
    /// labels<para>PaymentAutomaticallyApplied</para></remarks>
    /// <seealso href="http://schema.org/PaymentAutomaticallyApplied">http://schema.org/PaymentAutomaticallyApplied</seealso>
    let PaymentAutomaticallyApplied =
        Prefixed_Name(schema1, "PaymentAutomaticallyApplied") |> PrefixedName

    /// <summary>
    ///   <para>schema1:PaymentStatusType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A specific payment status. For example, PaymentDue, PaymentComplete, etc.</para>
    /// labels<para>PaymentStatusType</para></remarks>
    /// <seealso href="http://schema.org/PaymentStatusType">http://schema.org/PaymentStatusType</seealso>
    let PaymentStatusType = Prefixed_Name(schema1, "PaymentStatusType") |> PrefixedName
    /// <summary>
    ///   <para>schema1:PaymentDue</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:PaymentStatusType</para>
    ///   <para>The payment is due, but still within an acceptable time to be received.</para>
    /// labels<para>PaymentDue</para></remarks>
    /// <seealso href="http://schema.org/PaymentDue">http://schema.org/PaymentDue</seealso>
    let PaymentDue = Prefixed_Name(schema1, "PaymentDue") |> PrefixedName
    /// <summary>
    ///   <para>schema1:PaymentPastDue</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:PaymentStatusType</para>
    ///   <para>The payment is due and considered late.</para>
    /// labels<para>PaymentPastDue</para></remarks>
    /// <seealso href="http://schema.org/PaymentPastDue">http://schema.org/PaymentPastDue</seealso>
    let PaymentPastDue = Prefixed_Name(schema1, "PaymentPastDue") |> PrefixedName
    /// <summary>
    ///   <para>schema1:PaymentService</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Service to transfer funds from a person or organization to a beneficiary person or organization.</para>
    /// labels<para>PaymentService</para></remarks>
    /// <seealso href="http://schema.org/PaymentService">http://schema.org/PaymentService</seealso>
    let PaymentService = Prefixed_Name(schema1, "PaymentService") |> PrefixedName
    /// <summary>
    ///   <para>schema1:PerformanceRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A PerformanceRole is a Role that some entity places with regard to a theatrical performance, e.g. in a Movie, TVSeries etc.</para>
    /// labels<para>PerformanceRole</para></remarks>
    /// <seealso href="http://schema.org/PerformanceRole">http://schema.org/PerformanceRole</seealso>
    let PerformanceRole = Prefixed_Name(schema1, "PerformanceRole") |> PrefixedName

    /// <summary>
    ///   <para>schema1:PerformingArtsTheater</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A theater or other performing art center.</para>
    /// labels<para>PerformingArtsTheater</para></remarks>
    /// <seealso href="http://schema.org/PerformingArtsTheater">http://schema.org/PerformingArtsTheater</seealso>
    let PerformingArtsTheater =
        Prefixed_Name(schema1, "PerformingArtsTheater") |> PrefixedName

    /// <summary>
    ///   <para>schema1:Periodical</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A publication in any medium issued in successive parts bearing numerical or chronological designations and intended, such as a magazine, scholarly journal, or newspaper to continue indefinitely.&lt;br/&gt;&lt;br/&gt;
    ///
    /// See also &lt;a href="http://blog.schema.org/2014/09/schemaorg-support-for-bibliographic_2.html"&gt;blog post&lt;/a&gt;.</para>
    /// labels<para>Periodical</para></remarks>
    /// <seealso href="http://schema.org/Periodical">http://schema.org/Periodical</seealso>
    let Periodical = Prefixed_Name(schema1, "Periodical") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A person (alive, dead, undead, or fictional).</para>
    /// labels<para>Person</para></remarks>
    /// <seealso href="http://schema.org/Person">http://schema.org/Person</seealso>
    let Person = Prefixed_Name(schema1, "Person") |> PrefixedName
    /// <summary>
    ///   <para>schema1:PetStore</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A pet store.</para>
    /// labels<para>PetStore</para></remarks>
    /// <seealso href="http://schema.org/PetStore">http://schema.org/PetStore</seealso>
    let PetStore = Prefixed_Name(schema1, "PetStore") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Pharmacy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A pharmacy or drugstore.</para>
    /// labels<para>Pharmacy</para></remarks>
    /// <seealso href="http://schema.org/Pharmacy">http://schema.org/Pharmacy</seealso>
    let Pharmacy = Prefixed_Name(schema1, "Pharmacy") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Photograph</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A photograph.</para>
    /// labels<para>Photograph</para></remarks>
    /// <seealso href="http://schema.org/Photograph">http://schema.org/Photograph</seealso>
    let Photograph = Prefixed_Name(schema1, "Photograph") |> PrefixedName
    /// <summary>
    ///   <para>schema1:PhotographAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of capturing still images of objects using a camera.</para>
    /// labels<para>PhotographAction</para></remarks>
    /// <seealso href="http://schema.org/PhotographAction">http://schema.org/PhotographAction</seealso>
    let PhotographAction = Prefixed_Name(schema1, "PhotographAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Physician</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A doctor's office.</para>
    /// labels<para>Physician</para></remarks>
    /// <seealso href="http://schema.org/Physician">http://schema.org/Physician</seealso>
    let Physician = Prefixed_Name(schema1, "Physician") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Playground</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A playground.</para>
    /// labels<para>Playground</para></remarks>
    /// <seealso href="http://schema.org/Playground">http://schema.org/Playground</seealso>
    let Playground = Prefixed_Name(schema1, "Playground") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Plumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A plumbing service.</para>
    /// labels<para>Plumber</para></remarks>
    /// <seealso href="http://schema.org/Plumber">http://schema.org/Plumber</seealso>
    let Plumber = Prefixed_Name(schema1, "Plumber") |> PrefixedName
    /// <summary>
    ///   <para>schema1:PoliceStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A police station.</para>
    /// labels<para>PoliceStation</para></remarks>
    /// <seealso href="http://schema.org/PoliceStation">http://schema.org/PoliceStation</seealso>
    let PoliceStation = Prefixed_Name(schema1, "PoliceStation") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Pond</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A pond.</para>
    /// labels<para>Pond</para></remarks>
    /// <seealso href="http://schema.org/Pond">http://schema.org/Pond</seealso>
    let Pond = Prefixed_Name(schema1, "Pond") |> PrefixedName
    /// <summary>
    ///   <para>schema1:PostalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The mailing address.</para>
    /// labels<para>PostalAddress</para></remarks>
    /// <seealso href="http://schema.org/PostalAddress">http://schema.org/PostalAddress</seealso>
    let PostalAddress = Prefixed_Name(schema1, "PostalAddress") |> PrefixedName

    /// <summary>
    ///   <para>schema1:PotentialActionStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:ActionStatusType</para>
    ///   <para>A description of an action that is supported.</para>
    /// labels<para>PotentialActionStatus</para></remarks>
    /// <seealso href="http://schema.org/PotentialActionStatus">http://schema.org/PotentialActionStatus</seealso>
    let PotentialActionStatus =
        Prefixed_Name(schema1, "PotentialActionStatus") |> PrefixedName

    /// <summary>
    ///   <para>schema1:PreOrder</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:ItemAvailability</para>
    ///   <para>Indicates that the item is available for pre-order.</para>
    /// labels<para>PreOrder</para></remarks>
    /// <seealso href="http://schema.org/PreOrder">http://schema.org/PreOrder</seealso>
    let PreOrder = Prefixed_Name(schema1, "PreOrder") |> PrefixedName
    /// <summary>
    ///   <para>schema1:PreOrderAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An agent orders a (not yet released) object/product/service to be delivered/sent.</para>
    /// labels<para>PreOrderAction</para></remarks>
    /// <seealso href="http://schema.org/PreOrderAction">http://schema.org/PreOrderAction</seealso>
    let PreOrderAction = Prefixed_Name(schema1, "PreOrderAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:PreSale</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:ItemAvailability</para>
    ///   <para>Indicates that the item is available for ordering and delivery before general availability.</para>
    /// labels<para>PreSale</para></remarks>
    /// <seealso href="http://schema.org/PreSale">http://schema.org/PreSale</seealso>
    let PreSale = Prefixed_Name(schema1, "PreSale") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ProductModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A datasheet or vendor specification of a product (in the sense of a prototypical description).</para>
    /// labels<para>ProductModel</para></remarks>
    /// <seealso href="http://schema.org/ProductModel">http://schema.org/ProductModel</seealso>
    let ProductModel = Prefixed_Name(schema1, "ProductModel") |> PrefixedName

    /// <summary>
    ///   <para>schema1:ProfessionalService</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Original definition: "provider of professional services."&lt;br/&gt;&lt;br/&gt;
    ///
    /// The general &lt;a class="localLink" href="http://schema.org/ProfessionalService"&gt;ProfessionalService&lt;/a&gt; type for local businesses was deprecated due to confusion with &lt;a class="localLink" href="http://schema.org/Service"&gt;Service&lt;/a&gt;. For reference, the types that it included were: &lt;a class="localLink" href="http://schema.org/Dentist"&gt;Dentist&lt;/a&gt;,
    ///         &lt;a class="localLink" href="http://schema.org/AccountingService"&gt;AccountingService&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Attorney"&gt;Attorney&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Notary"&gt;Notary&lt;/a&gt;, as well as types for several kinds of &lt;a class="localLink" href="http://schema.org/HomeAndConstructionBusiness"&gt;HomeAndConstructionBusiness&lt;/a&gt;: &lt;a class="localLink" href="http://schema.org/Electrician"&gt;Electrician&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/GeneralContractor"&gt;GeneralContractor&lt;/a&gt;,
    ///         &lt;a class="localLink" href="http://schema.org/HousePainter"&gt;HousePainter&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Locksmith"&gt;Locksmith&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Plumber"&gt;Plumber&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/RoofingContractor"&gt;RoofingContractor&lt;/a&gt;. &lt;a class="localLink" href="http://schema.org/LegalService"&gt;LegalService&lt;/a&gt; was introduced as a more inclusive supertype of &lt;a class="localLink" href="http://schema.org/Attorney"&gt;Attorney&lt;/a&gt;.</para>
    /// labels<para>ProfessionalService</para></remarks>
    /// <seealso href="http://schema.org/ProfessionalService">http://schema.org/ProfessionalService</seealso>
    let ProfessionalService =
        Prefixed_Name(schema1, "ProfessionalService") |> PrefixedName

    /// <summary>
    ///   <para>schema1:ProfilePage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Web page type: Profile page.</para>
    /// labels<para>ProfilePage</para></remarks>
    /// <seealso href="http://schema.org/ProfilePage">http://schema.org/ProfilePage</seealso>
    let ProfilePage = Prefixed_Name(schema1, "ProfilePage") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ProgramMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Used to describe membership in a loyalty programs (e.g. "StarAliance"), traveler clubs (e.g. "AAA"), purchase clubs ("Safeway Club"), etc.</para>
    /// labels<para>ProgramMembership</para></remarks>
    /// <seealso href="http://schema.org/ProgramMembership">http://schema.org/ProgramMembership</seealso>
    let ProgramMembership = Prefixed_Name(schema1, "ProgramMembership") |> PrefixedName

    /// <summary>
    ///   <para>schema1:PropertyValueSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Property value specification.</para>
    /// labels<para>PropertyValueSpecification</para></remarks>
    /// <seealso href="http://schema.org/PropertyValueSpecification">http://schema.org/PropertyValueSpecification</seealso>
    let PropertyValueSpecification =
        Prefixed_Name(schema1, "PropertyValueSpecification") |> PrefixedName

    /// <summary>
    ///   <para>schema1:PublicHolidays</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:DayOfWeek</para>
    ///   <para>This stands for any day that is a public holiday; it is a placeholder for all official public holidays in some particular location. While not technically a "day of the week", it can be used with &lt;a class="localLink" href="http://schema.org/OpeningHoursSpecification"&gt;OpeningHoursSpecification&lt;/a&gt;. In the context of an opening hours specification it can be used to indicate opening hours on public holidays, overriding general opening hours for the day of the week on which a public holiday occurs.</para>
    /// labels<para>PublicHolidays</para></remarks>
    /// <seealso href="http://schema.org/PublicHolidays">http://schema.org/PublicHolidays</seealso>
    let PublicHolidays = Prefixed_Name(schema1, "PublicHolidays") |> PrefixedName

    /// <summary>
    ///   <para>schema1:PublicSwimmingPool</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A public swimming pool.</para>
    /// labels<para>PublicSwimmingPool</para></remarks>
    /// <seealso href="http://schema.org/PublicSwimmingPool">http://schema.org/PublicSwimmingPool</seealso>
    let PublicSwimmingPool =
        Prefixed_Name(schema1, "PublicSwimmingPool") |> PrefixedName

    /// <summary>
    ///   <para>schema1:PublicationIssue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A part of a successively published publication such as a periodical or publication volume, often numbered, usually containing a grouping of works such as articles.&lt;br/&gt;&lt;br/&gt;
    ///
    /// See also &lt;a href="http://blog.schema.org/2014/09/schemaorg-support-for-bibliographic_2.html"&gt;blog post&lt;/a&gt;.</para>
    /// labels<para>PublicationIssue</para></remarks>
    /// <seealso href="http://schema.org/PublicationIssue">http://schema.org/PublicationIssue</seealso>
    let PublicationIssue = Prefixed_Name(schema1, "PublicationIssue") |> PrefixedName
    /// <summary>
    ///   <para>schema1:PublicationVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A part of a successively published publication such as a periodical or multi-volume work, often numbered. It may represent a time span, such as a year.&lt;br/&gt;&lt;br/&gt;
    ///
    /// See also &lt;a href="http://blog.schema.org/2014/09/schemaorg-support-for-bibliographic_2.html"&gt;blog post&lt;/a&gt;.</para>
    /// labels<para>PublicationVolume</para></remarks>
    /// <seealso href="http://schema.org/PublicationVolume">http://schema.org/PublicationVolume</seealso>
    let PublicationVolume = Prefixed_Name(schema1, "PublicationVolume") |> PrefixedName
    /// <summary>
    ///   <para>schema1:QuantitativeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A point value or interval for product characteristics and other purposes.</para>
    /// labels<para>QuantitativeValue</para></remarks>
    /// <seealso href="http://schema.org/QuantitativeValue">http://schema.org/QuantitativeValue</seealso>
    let QuantitativeValue = Prefixed_Name(schema1, "QuantitativeValue") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Question</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A specific question - e.g. from a user seeking answers online, or collected in a Frequently Asked Questions (FAQ) document.</para>
    /// labels<para>Question</para></remarks>
    /// <seealso href="http://schema.org/Question">http://schema.org/Question</seealso>
    let Question = Prefixed_Name(schema1, "Question") |> PrefixedName
    /// <summary>
    ///   <para>schema1:QuoteAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An agent quotes/estimates/appraises an object/product/service with a price at a location/store.</para>
    /// labels<para>QuoteAction</para></remarks>
    /// <seealso href="http://schema.org/QuoteAction">http://schema.org/QuoteAction</seealso>
    let QuoteAction = Prefixed_Name(schema1, "QuoteAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:RadioClip</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A short radio program or a segment/part of a radio program.</para>
    /// labels<para>RadioClip</para></remarks>
    /// <seealso href="http://schema.org/RadioClip">http://schema.org/RadioClip</seealso>
    let RadioClip = Prefixed_Name(schema1, "RadioClip") |> PrefixedName
    /// <summary>
    ///   <para>schema1:RadioEpisode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A radio episode which can be part of a series or season.</para>
    /// labels<para>RadioEpisode</para></remarks>
    /// <seealso href="http://schema.org/RadioEpisode">http://schema.org/RadioEpisode</seealso>
    let RadioEpisode = Prefixed_Name(schema1, "RadioEpisode") |> PrefixedName
    /// <summary>
    ///   <para>schema1:RadioSeason</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Season dedicated to radio broadcast and associated online delivery.</para>
    /// labels<para>RadioSeason</para></remarks>
    /// <seealso href="http://schema.org/RadioSeason">http://schema.org/RadioSeason</seealso>
    let RadioSeason = Prefixed_Name(schema1, "RadioSeason") |> PrefixedName
    /// <summary>
    ///   <para>schema1:RadioSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>CreativeWorkSeries dedicated to radio broadcast and associated online delivery.</para>
    /// labels<para>RadioSeries</para></remarks>
    /// <seealso href="http://schema.org/RadioSeries">http://schema.org/RadioSeries</seealso>
    let RadioSeries = Prefixed_Name(schema1, "RadioSeries") |> PrefixedName
    /// <summary>
    ///   <para>schema1:RadioStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A radio station.</para>
    /// labels<para>RadioStation</para></remarks>
    /// <seealso href="http://schema.org/RadioStation">http://schema.org/RadioStation</seealso>
    let RadioStation = Prefixed_Name(schema1, "RadioStation") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ReadAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of consuming written content.</para>
    /// labels<para>ReadAction</para></remarks>
    /// <seealso href="http://schema.org/ReadAction">http://schema.org/ReadAction</seealso>
    let ReadAction = Prefixed_Name(schema1, "ReadAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ReadPermission</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:DigitalDocumentPermissionType</para>
    ///   <para>Permission to read or view the document.</para>
    /// labels<para>ReadPermission</para></remarks>
    /// <seealso href="http://schema.org/ReadPermission">http://schema.org/ReadPermission</seealso>
    let ReadPermission = Prefixed_Name(schema1, "ReadPermission") |> PrefixedName
    /// <summary>
    ///   <para>schema1:RealEstateAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A real-estate agent.</para>
    /// labels<para>RealEstateAgent</para></remarks>
    /// <seealso href="http://schema.org/RealEstateAgent">http://schema.org/RealEstateAgent</seealso>
    let RealEstateAgent = Prefixed_Name(schema1, "RealEstateAgent") |> PrefixedName
    /// <summary>
    ///   <para>schema1:VideoGallery</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Web page type: Video gallery page.</para>
    /// labels<para>VideoGallery</para></remarks>
    /// <seealso href="http://schema.org/VideoGallery">http://schema.org/VideoGallery</seealso>
    let VideoGallery = Prefixed_Name(schema1, "VideoGallery") |> PrefixedName
    /// <summary>
    ///   <para>schema1:VideoGame</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A video game is an electronic game that involves human interaction with a user interface to generate visual feedback on a video device.</para>
    /// labels<para>VideoGame</para></remarks>
    /// <seealso href="http://schema.org/VideoGame">http://schema.org/VideoGame</seealso>
    let VideoGame = Prefixed_Name(schema1, "VideoGame") |> PrefixedName
    /// <summary>
    ///   <para>schema1:VideoGameClip</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A short segment/part of a video game.</para>
    /// labels<para>VideoGameClip</para></remarks>
    /// <seealso href="http://schema.org/VideoGameClip">http://schema.org/VideoGameClip</seealso>
    let VideoGameClip = Prefixed_Name(schema1, "VideoGameClip") |> PrefixedName
    /// <summary>
    ///   <para>schema1:VideoGameSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A video game series.</para>
    /// labels<para>VideoGameSeries</para></remarks>
    /// <seealso href="http://schema.org/VideoGameSeries">http://schema.org/VideoGameSeries</seealso>
    let VideoGameSeries = Prefixed_Name(schema1, "VideoGameSeries") |> PrefixedName
    /// <summary>
    ///   <para>schema1:VideoObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A video file.</para>
    /// labels<para>VideoObject</para></remarks>
    /// <seealso href="http://schema.org/VideoObject">http://schema.org/VideoObject</seealso>
    let VideoObject = Prefixed_Name(schema1, "VideoObject") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ViewAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of consuming static visual content.</para>
    /// labels<para>ViewAction</para></remarks>
    /// <seealso href="http://schema.org/ViewAction">http://schema.org/ViewAction</seealso>
    let ViewAction = Prefixed_Name(schema1, "ViewAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:VinylFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:MusicReleaseFormatType</para>
    ///   <para>VinylFormat.</para>
    /// labels<para>VinylFormat</para></remarks>
    /// <seealso href="http://schema.org/VinylFormat">http://schema.org/VinylFormat</seealso>
    let VinylFormat = Prefixed_Name(schema1, "VinylFormat") |> PrefixedName
    /// <summary>
    ///   <para>schema1:VisualArtsEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Event type: Visual arts event.</para>
    /// labels<para>VisualArtsEvent</para></remarks>
    /// <seealso href="http://schema.org/VisualArtsEvent">http://schema.org/VisualArtsEvent</seealso>
    let VisualArtsEvent = Prefixed_Name(schema1, "VisualArtsEvent") |> PrefixedName
    /// <summary>
    ///   <para>schema1:VisualArtwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A work of art that is primarily visual in character.</para>
    /// labels<para>VisualArtwork</para></remarks>
    /// <seealso href="http://schema.org/VisualArtwork">http://schema.org/VisualArtwork</seealso>
    let VisualArtwork = Prefixed_Name(schema1, "VisualArtwork") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Volcano</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A volcano, like Fuji san.</para>
    /// labels<para>Volcano</para></remarks>
    /// <seealso href="http://schema.org/Volcano">http://schema.org/Volcano</seealso>
    let Volcano = Prefixed_Name(schema1, "Volcano") |> PrefixedName
    /// <summary>
    ///   <para>schema1:WPAdBlock</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An advertising section of the page.</para>
    /// labels<para>WPAdBlock</para></remarks>
    /// <seealso href="http://schema.org/WPAdBlock">http://schema.org/WPAdBlock</seealso>
    let WPAdBlock = Prefixed_Name(schema1, "WPAdBlock") |> PrefixedName
    /// <summary>
    ///   <para>schema1:WPFooter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The footer section of the page.</para>
    /// labels<para>WPFooter</para></remarks>
    /// <seealso href="http://schema.org/WPFooter">http://schema.org/WPFooter</seealso>
    let WPFooter = Prefixed_Name(schema1, "WPFooter") |> PrefixedName
    /// <summary>
    ///   <para>schema1:WPHeader</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The header section of the page.</para>
    /// labels<para>WPHeader</para></remarks>
    /// <seealso href="http://schema.org/WPHeader">http://schema.org/WPHeader</seealso>
    let WPHeader = Prefixed_Name(schema1, "WPHeader") |> PrefixedName
    /// <summary>
    ///   <para>schema1:WPSideBar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A sidebar section of the page.</para>
    /// labels<para>WPSideBar</para></remarks>
    /// <seealso href="http://schema.org/WPSideBar">http://schema.org/WPSideBar</seealso>
    let WPSideBar = Prefixed_Name(schema1, "WPSideBar") |> PrefixedName
    /// <summary>
    ///   <para>schema1:WantAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of expressing a desire about the object. An agent wants an object.</para>
    /// labels<para>WantAction</para></remarks>
    /// <seealso href="http://schema.org/WantAction">http://schema.org/WantAction</seealso>
    let WantAction = Prefixed_Name(schema1, "WantAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:WarrantyPromise</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A structured value representing the duration and scope of services that will be provided to a customer free of charge in case of a defect or malfunction of a product.</para>
    /// labels<para>WarrantyPromise</para></remarks>
    /// <seealso href="http://schema.org/WarrantyPromise">http://schema.org/WarrantyPromise</seealso>
    let WarrantyPromise = Prefixed_Name(schema1, "WarrantyPromise") |> PrefixedName
    /// <summary>
    ///   <para>schema1:WarrantyScope</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A range of of services that will be provided to a customer free of charge in case of a defect or malfunction of a product.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Commonly used values:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#Labor-BringIn&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#PartsAndLabor-BringIn&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#PartsAndLabor-PickUp&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>WarrantyScope</para></remarks>
    /// <seealso href="http://schema.org/WarrantyScope">http://schema.org/WarrantyScope</seealso>
    let WarrantyScope = Prefixed_Name(schema1, "WarrantyScope") |> PrefixedName
    /// <summary>
    ///   <para>schema1:WatchAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of consuming dynamic/moving visual content.</para>
    /// labels<para>WatchAction</para></remarks>
    /// <seealso href="http://schema.org/WatchAction">http://schema.org/WatchAction</seealso>
    let WatchAction = Prefixed_Name(schema1, "WatchAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Waterfall</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A waterfall, like Niagara.</para>
    /// labels<para>Waterfall</para></remarks>
    /// <seealso href="http://schema.org/Waterfall">http://schema.org/Waterfall</seealso>
    let Waterfall = Prefixed_Name(schema1, "Waterfall") |> PrefixedName
    /// <summary>
    ///   <para>schema1:WearAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of dressing oneself in clothing.</para>
    /// labels<para>WearAction</para></remarks>
    /// <seealso href="http://schema.org/WearAction">http://schema.org/WearAction</seealso>
    let WearAction = Prefixed_Name(schema1, "WearAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:WebApplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Web applications.</para>
    /// labels<para>WebApplication</para></remarks>
    /// <seealso href="http://schema.org/WebApplication">http://schema.org/WebApplication</seealso>
    let WebApplication = Prefixed_Name(schema1, "WebApplication") |> PrefixedName
    /// <summary>
    ///   <para>schema1:broadcastOfEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The event being broadcast such as a sporting event or awards ceremony.</para>
    /// labels<para>broadcastOfEvent</para></remarks>
    /// <seealso href="http://schema.org/broadcastOfEvent">http://schema.org/broadcastOfEvent</seealso>
    let broadcastOfEvent = Prefixed_Name(schema1, "broadcastOfEvent") |> PrefixedName

    /// <summary>
    ///   <para>schema1:broadcastServiceTier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The type of service required to have access to the channel (e.g. Standard or Premium).</para>
    /// labels<para>broadcastServiceTier</para></remarks>
    /// <seealso href="http://schema.org/broadcastServiceTier">http://schema.org/broadcastServiceTier</seealso>
    let broadcastServiceTier =
        Prefixed_Name(schema1, "broadcastServiceTier") |> PrefixedName

    /// <summary>
    ///   <para>schema1:broadcastTimezone</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The timezone in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 format&lt;/a&gt; for which the service bases its broadcasts</para>
    /// labels<para>broadcastTimezone</para></remarks>
    /// <seealso href="http://schema.org/broadcastTimezone">http://schema.org/broadcastTimezone</seealso>
    let broadcastTimezone = Prefixed_Name(schema1, "broadcastTimezone") |> PrefixedName
    /// <summary>
    ///   <para>schema1:broadcaster</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The organization owning or operating the broadcast service.</para>
    /// labels<para>broadcaster</para></remarks>
    /// <seealso href="http://schema.org/broadcaster">http://schema.org/broadcaster</seealso>
    let broadcaster = Prefixed_Name(schema1, "broadcaster") |> PrefixedName

    /// <summary>
    ///   <para>schema1:browserRequirements</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies browser requirements in human-readable text. For example, 'requires HTML5 support'.</para>
    /// labels<para>browserRequirements</para></remarks>
    /// <seealso href="http://schema.org/browserRequirements">http://schema.org/browserRequirements</seealso>
    let browserRequirements =
        Prefixed_Name(schema1, "browserRequirements") |> PrefixedName

    /// <summary>
    ///   <para>schema1:busName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The name of the bus (e.g. Bolt Express).</para>
    /// labels<para>busName</para></remarks>
    /// <seealso href="http://schema.org/busName">http://schema.org/busName</seealso>
    let busName = Prefixed_Name(schema1, "busName") |> PrefixedName
    /// <summary>
    ///   <para>schema1:busNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The unique identifier for the bus.</para>
    /// labels<para>busNumber</para></remarks>
    /// <seealso href="http://schema.org/busNumber">http://schema.org/busNumber</seealso>
    let busNumber = Prefixed_Name(schema1, "busNumber") |> PrefixedName
    /// <summary>
    ///   <para>schema1:businessFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The business function (e.g. sell, lease, repair, dispose) of the offer or component of a bundle (TypeAndQuantityNode). The default is http://purl.org/goodrelations/v1#Sell.</para>
    /// labels<para>businessFunction</para></remarks>
    /// <seealso href="http://schema.org/businessFunction">http://schema.org/businessFunction</seealso>
    let businessFunction = Prefixed_Name(schema1, "businessFunction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:buyer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of participant. The participant/person/organization that bought the object.</para>
    /// labels<para>buyer</para></remarks>
    /// <seealso href="http://schema.org/buyer">http://schema.org/buyer</seealso>
    let buyer = Prefixed_Name(schema1, "buyer") |> PrefixedName
    /// <summary>
    ///   <para>schema1:byArtist</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The artist that performed this album or recording.</para>
    /// labels<para>byArtist</para></remarks>
    /// <seealso href="http://schema.org/byArtist">http://schema.org/byArtist</seealso>
    let byArtist = Prefixed_Name(schema1, "byArtist") |> PrefixedName
    /// <summary>
    ///   <para>schema1:caption</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The caption for this object. For downloadable machine formats (closed caption, subtitles etc.) use MediaObject and indicate the &lt;a class="localLink" href="http://schema.org/encodingFormat"&gt;encodingFormat&lt;/a&gt;.</para>
    /// labels<para>caption</para></remarks>
    /// <seealso href="http://schema.org/caption">http://schema.org/caption</seealso>
    let caption = Prefixed_Name(schema1, "caption") |> PrefixedName

    /// <summary>
    ///   <para>schema1:carbohydrateContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of grams of carbohydrates.</para>
    /// labels<para>carbohydrateContent</para></remarks>
    /// <seealso href="http://schema.org/carbohydrateContent">http://schema.org/carbohydrateContent</seealso>
    let carbohydrateContent =
        Prefixed_Name(schema1, "carbohydrateContent") |> PrefixedName

    /// <summary>
    ///   <para>schema1:cargoVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The available volume for cargo or luggage. For automobiles, this is usually the trunk volume.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Typical unit code(s): LTR for liters, FTQ for cubic foot/feet&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: You can use &lt;a class="localLink" href="http://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate ranges.</para>
    /// labels<para>cargoVolume</para></remarks>
    /// <seealso href="http://schema.org/cargoVolume">http://schema.org/cargoVolume</seealso>
    let cargoVolume = Prefixed_Name(schema1, "cargoVolume") |> PrefixedName
    /// <summary>
    ///   <para>schema1:carrier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>'carrier' is an out-dated term indicating the 'provider' for parcel delivery and flights.</para>
    /// labels<para>carrier</para></remarks>
    /// <seealso href="http://schema.org/carrier">http://schema.org/carrier</seealso>
    let carrier = Prefixed_Name(schema1, "carrier") |> PrefixedName
    /// <summary>
    ///   <para>schema1:provider</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.</para>
    /// labels<para>provider</para></remarks>
    /// <seealso href="http://schema.org/provider">http://schema.org/provider</seealso>
    let provider = Prefixed_Name(schema1, "provider") |> PrefixedName

    /// <summary>
    ///   <para>schema1:carrierRequirements</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies specific carrier(s) requirements for the application (e.g. an application may only work on a specific carrier network).</para>
    /// labels<para>carrierRequirements</para></remarks>
    /// <seealso href="http://schema.org/carrierRequirements">http://schema.org/carrierRequirements</seealso>
    let carrierRequirements =
        Prefixed_Name(schema1, "carrierRequirements") |> PrefixedName

    /// <summary>
    ///   <para>schema1:catalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A data catalog which contains this dataset.</para>
    /// labels<para>catalog</para></remarks>
    /// <seealso href="http://schema.org/catalog">http://schema.org/catalog</seealso>
    let catalog = Prefixed_Name(schema1, "catalog") |> PrefixedName

    /// <summary>
    ///   <para>schema1:includedInDataCatalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A data catalog which contains this dataset.</para>
    /// labels<para>includedInDataCatalog</para></remarks>
    /// <seealso href="http://schema.org/includedInDataCatalog">http://schema.org/includedInDataCatalog</seealso>
    let includedInDataCatalog =
        Prefixed_Name(schema1, "includedInDataCatalog") |> PrefixedName

    /// <summary>
    ///   <para>schema1:catalogNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The catalog number for the release.</para>
    /// labels<para>catalogNumber</para></remarks>
    /// <seealso href="http://schema.org/catalogNumber">http://schema.org/catalogNumber</seealso>
    let catalogNumber = Prefixed_Name(schema1, "catalogNumber") |> PrefixedName

    /// <summary>
    ///   <para>schema1:SpecialAnnouncement</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schema.org/SpecialAnnouncement">http://schema.org/SpecialAnnouncement</seealso>
    let SpecialAnnouncement =
        Prefixed_Name(schema1, "SpecialAnnouncement") |> PrefixedName

    /// <summary>
    ///   <para>schema1:PhysicalActivity</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schema.org/PhysicalActivity">http://schema.org/PhysicalActivity</seealso>
    let PhysicalActivity = Prefixed_Name(schema1, "PhysicalActivity") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Recommendation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schema.org/Recommendation">http://schema.org/Recommendation</seealso>
    let Recommendation = Prefixed_Name(schema1, "Recommendation") |> PrefixedName

    /// <summary>
    ///   <para>schema1:PhysicalActivityCategory</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schema.org/PhysicalActivityCategory">http://schema.org/PhysicalActivityCategory</seealso>
    let PhysicalActivityCategory =
        Prefixed_Name(schema1, "PhysicalActivityCategory") |> PrefixedName

    /// <summary>
    ///   <para>schema1:ccRecipient</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of recipient. The recipient copied on a message.</para>
    /// labels<para>ccRecipient</para></remarks>
    /// <seealso href="http://schema.org/ccRecipient">http://schema.org/ccRecipient</seealso>
    let ccRecipient = Prefixed_Name(schema1, "ccRecipient") |> PrefixedName
    /// <summary>
    ///   <para>schema1:follows</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The most generic uni-directional social relation.</para>
    /// labels<para>follows</para></remarks>
    /// <seealso href="http://schema.org/follows">http://schema.org/follows</seealso>
    let follows = Prefixed_Name(schema1, "follows") |> PrefixedName
    /// <summary>
    ///   <para>schema1:foodEstablishment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of location. The specific food establishment where the action occurred.</para>
    /// labels<para>foodEstablishment</para></remarks>
    /// <seealso href="http://schema.org/foodEstablishment">http://schema.org/foodEstablishment</seealso>
    let foodEstablishment = Prefixed_Name(schema1, "foodEstablishment") |> PrefixedName
    /// <summary>
    ///   <para>schema1:foodEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of location. The specific food event where the action occurred.</para>
    /// labels<para>foodEvent</para></remarks>
    /// <seealso href="http://schema.org/foodEvent">http://schema.org/foodEvent</seealso>
    let foodEvent = Prefixed_Name(schema1, "foodEvent") |> PrefixedName
    /// <summary>
    ///   <para>schema1:founder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A person who founded this organization.</para>
    /// labels<para>founder</para></remarks>
    /// <seealso href="http://schema.org/founder">http://schema.org/founder</seealso>
    let founder = Prefixed_Name(schema1, "founder") |> PrefixedName
    /// <summary>
    ///   <para>schema1:founders</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A person who founded this organization.</para>
    /// labels<para>founders</para></remarks>
    /// <seealso href="http://schema.org/founders">http://schema.org/founders</seealso>
    let founders = Prefixed_Name(schema1, "founders") |> PrefixedName
    /// <summary>
    ///   <para>schema1:foundingDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The date that this organization was founded.</para>
    /// labels<para>foundingDate</para></remarks>
    /// <seealso href="http://schema.org/foundingDate">http://schema.org/foundingDate</seealso>
    let foundingDate = Prefixed_Name(schema1, "foundingDate") |> PrefixedName
    /// <summary>
    ///   <para>schema1:foundingLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The place where the Organization was founded.</para>
    /// labels<para>foundingLocation</para></remarks>
    /// <seealso href="http://schema.org/foundingLocation">http://schema.org/foundingLocation</seealso>
    let foundingLocation = Prefixed_Name(schema1, "foundingLocation") |> PrefixedName
    /// <summary>
    ///   <para>schema1:free</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A flag to signal that the item, event, or place is accessible for free.</para>
    /// labels<para>free</para></remarks>
    /// <seealso href="http://schema.org/free">http://schema.org/free</seealso>
    let free = Prefixed_Name(schema1, "free") |> PrefixedName

    /// <summary>
    ///   <para>schema1:isAccessibleForFree</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A flag to signal that the item, event, or place is accessible for free.</para>
    /// labels<para>isAccessibleForFree</para></remarks>
    /// <seealso href="http://schema.org/isAccessibleForFree">http://schema.org/isAccessibleForFree</seealso>
    let isAccessibleForFree =
        Prefixed_Name(schema1, "isAccessibleForFree") |> PrefixedName

    /// <summary>
    ///   <para>schema1:fromLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of location. The original location of the object or the agent before the action.</para>
    /// labels<para>fromLocation</para></remarks>
    /// <seealso href="http://schema.org/fromLocation">http://schema.org/fromLocation</seealso>
    let fromLocation = Prefixed_Name(schema1, "fromLocation") |> PrefixedName
    /// <summary>
    ///   <para>schema1:fuelConsumption</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The amount of fuel consumed for traveling a particular distance or temporal duration with the given vehicle (e.g. liters per 100 km).&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;Note 1: There are unfortunately no standard unit codes for liters per 100 km.  Use &lt;a class="localLink" href="http://schema.org/unitText"&gt;unitText&lt;/a&gt; to indicate the unit of measurement, e.g. L/100 km.&lt;/li&gt;
    /// &lt;li&gt;Note 2: There are two ways of indicating the fuel consumption, &lt;a class="localLink" href="http://schema.org/fuelConsumption"&gt;fuelConsumption&lt;/a&gt; (e.g. 8 liters per 100 km) and &lt;a class="localLink" href="http://schema.org/fuelEfficiency"&gt;fuelEfficiency&lt;/a&gt; (e.g. 30 miles per gallon). They are reciprocal.&lt;/li&gt;
    /// &lt;li&gt;Note 3: Often, the absolute value is useful only when related to driving speed ("at 80 km/h") or usage pattern ("city traffic"). You can use &lt;a class="localLink" href="http://schema.org/valueReference"&gt;valueReference&lt;/a&gt; to link the value for the fuel consumption to another value.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>fuelConsumption</para></remarks>
    /// <seealso href="http://schema.org/fuelConsumption">http://schema.org/fuelConsumption</seealso>
    let fuelConsumption = Prefixed_Name(schema1, "fuelConsumption") |> PrefixedName
    /// <summary>
    ///   <para>schema1:fuelEfficiency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The distance traveled per unit of fuel used; most commonly miles per gallon (mpg) or kilometers per liter (km/L).&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;Note 1: There are unfortunately no standard unit codes for miles per gallon or kilometers per liter. Use &lt;a class="localLink" href="http://schema.org/unitText"&gt;unitText&lt;/a&gt; to indicate the unit of measurement, e.g. mpg or km/L.&lt;/li&gt;
    /// &lt;li&gt;Note 2: There are two ways of indicating the fuel consumption, &lt;a class="localLink" href="http://schema.org/fuelConsumption"&gt;fuelConsumption&lt;/a&gt; (e.g. 8 liters per 100 km) and &lt;a class="localLink" href="http://schema.org/fuelEfficiency"&gt;fuelEfficiency&lt;/a&gt; (e.g. 30 miles per gallon). They are reciprocal.&lt;/li&gt;
    /// &lt;li&gt;Note 3: Often, the absolute value is useful only when related to driving speed ("at 80 km/h") or usage pattern ("city traffic"). You can use &lt;a class="localLink" href="http://schema.org/valueReference"&gt;valueReference&lt;/a&gt; to link the value for the fuel economy to another value.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>fuelEfficiency</para></remarks>
    /// <seealso href="http://schema.org/fuelEfficiency">http://schema.org/fuelEfficiency</seealso>
    let fuelEfficiency = Prefixed_Name(schema1, "fuelEfficiency") |> PrefixedName
    /// <summary>
    ///   <para>schema1:numberOfDoors</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of doors.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Typical unit code(s): C62</para>
    /// labels<para>numberOfDoors</para></remarks>
    /// <seealso href="http://schema.org/numberOfDoors">http://schema.org/numberOfDoors</seealso>
    let numberOfDoors = Prefixed_Name(schema1, "numberOfDoors") |> PrefixedName
    /// <summary>
    ///   <para>schema1:numberOfEmployees</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of employees in an organization e.g. business.</para>
    /// labels<para>numberOfEmployees</para></remarks>
    /// <seealso href="http://schema.org/numberOfEmployees">http://schema.org/numberOfEmployees</seealso>
    let numberOfEmployees = Prefixed_Name(schema1, "numberOfEmployees") |> PrefixedName
    /// <summary>
    ///   <para>schema1:numberOfEpisodes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of episodes in this season or series.</para>
    /// labels<para>numberOfEpisodes</para></remarks>
    /// <seealso href="http://schema.org/numberOfEpisodes">http://schema.org/numberOfEpisodes</seealso>
    let numberOfEpisodes = Prefixed_Name(schema1, "numberOfEpisodes") |> PrefixedName

    /// <summary>
    ///   <para>schema1:numberOfForwardGears</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The total number of forward gears available for the transmission system of the vehicle.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Typical unit code(s): C62</para>
    /// labels<para>numberOfForwardGears</para></remarks>
    /// <seealso href="http://schema.org/numberOfForwardGears">http://schema.org/numberOfForwardGears</seealso>
    let numberOfForwardGears =
        Prefixed_Name(schema1, "numberOfForwardGears") |> PrefixedName

    /// <summary>
    ///   <para>schema1:numberOfItems</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of items in an ItemList. Note that some descriptions might not fully describe all items in a list (e.g., multi-page pagination); in such cases, the numberOfItems would be for the entire list.</para>
    /// labels<para>numberOfItems</para></remarks>
    /// <seealso href="http://schema.org/numberOfItems">http://schema.org/numberOfItems</seealso>
    let numberOfItems = Prefixed_Name(schema1, "numberOfItems") |> PrefixedName
    /// <summary>
    ///   <para>schema1:numberOfPages</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of pages in the book.</para>
    /// labels<para>numberOfPages</para></remarks>
    /// <seealso href="http://schema.org/numberOfPages">http://schema.org/numberOfPages</seealso>
    let numberOfPages = Prefixed_Name(schema1, "numberOfPages") |> PrefixedName
    /// <summary>
    ///   <para>schema1:numberOfPlayers</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicate how many people can play this game (minimum, maximum, or range).</para>
    /// labels<para>numberOfPlayers</para></remarks>
    /// <seealso href="http://schema.org/numberOfPlayers">http://schema.org/numberOfPlayers</seealso>
    let numberOfPlayers = Prefixed_Name(schema1, "numberOfPlayers") |> PrefixedName

    /// <summary>
    ///   <para>schema1:numberOfPreviousOwners</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of owners of the vehicle, including the current one.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Typical unit code(s): C62</para>
    /// labels<para>numberOfPreviousOwners</para></remarks>
    /// <seealso href="http://schema.org/numberOfPreviousOwners">http://schema.org/numberOfPreviousOwners</seealso>
    let numberOfPreviousOwners =
        Prefixed_Name(schema1, "numberOfPreviousOwners") |> PrefixedName

    /// <summary>
    ///   <para>schema1:numberOfRooms</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of rooms (excluding bathrooms and closets) of the accommodation or lodging business.
    /// Typical unit code(s): ROM for room or C62 for no unit. The type of room can be put in the unitText property of the QuantitativeValue.</para>
    /// labels<para>numberOfRooms</para></remarks>
    /// <seealso href="http://schema.org/numberOfRooms">http://schema.org/numberOfRooms</seealso>
    let numberOfRooms = Prefixed_Name(schema1, "numberOfRooms") |> PrefixedName
    /// <summary>
    ///   <para>schema1:numberOfSeasons</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of seasons in this series.</para>
    /// labels<para>numberOfSeasons</para></remarks>
    /// <seealso href="http://schema.org/numberOfSeasons">http://schema.org/numberOfSeasons</seealso>
    let numberOfSeasons = Prefixed_Name(schema1, "numberOfSeasons") |> PrefixedName
    /// <summary>
    ///   <para>schema1:numberedPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A number associated with a role in an organization, for example, the number on an athlete's jersey.</para>
    /// labels<para>numberedPosition</para></remarks>
    /// <seealso href="http://schema.org/numberedPosition">http://schema.org/numberedPosition</seealso>
    let numberedPosition = Prefixed_Name(schema1, "numberedPosition") |> PrefixedName
    /// <summary>
    ///   <para>schema1:offerCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of offers for the product.</para>
    /// labels<para>offerCount</para></remarks>
    /// <seealso href="http://schema.org/offerCount">http://schema.org/offerCount</seealso>
    let offerCount = Prefixed_Name(schema1, "offerCount") |> PrefixedName
    /// <summary>
    ///   <para>schema1:openingHours</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The general opening hours for a business. Opening hours can be specified as a weekly time range, starting with days, then times per day. Multiple days can be listed with commas ',' separating each day. Day or time ranges are specified using a hyphen '-'.&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;Days are specified using the following two-letter combinations: &lt;code&gt;Mo&lt;/code&gt;, &lt;code&gt;Tu&lt;/code&gt;, &lt;code&gt;We&lt;/code&gt;, &lt;code&gt;Th&lt;/code&gt;, &lt;code&gt;Fr&lt;/code&gt;, &lt;code&gt;Sa&lt;/code&gt;, &lt;code&gt;Su&lt;/code&gt;.&lt;/li&gt;
    /// &lt;li&gt;Times are specified using 24:00 time. For example, 3pm is specified as &lt;code&gt;15:00&lt;/code&gt;. &lt;/li&gt;
    /// &lt;li&gt;Here is an example: &lt;code&gt;&amp;lt;time itemprop="openingHours" datetime=&amp;quot;Tu,Th 16:00-20:00&amp;quot;&amp;gt;Tuesdays and Thursdays 4-8pm&amp;lt;/time&amp;gt;&lt;/code&gt;.&lt;/li&gt;
    /// &lt;li&gt;If a business is open 7 days a week, then it can be specified as &lt;code&gt;&amp;lt;time itemprop=&amp;quot;openingHours&amp;quot; datetime=&amp;quot;Mo-Su&amp;quot;&amp;gt;Monday through Sunday, all day&amp;lt;/time&amp;gt;&lt;/code&gt;.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>openingHours</para></remarks>
    /// <seealso href="http://schema.org/openingHours">http://schema.org/openingHours</seealso>
    let openingHours = Prefixed_Name(schema1, "openingHours") |> PrefixedName

    /// <summary>
    ///   <para>schema1:openingHoursSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The opening hours of a certain place.</para>
    /// labels<para>openingHoursSpecification</para></remarks>
    /// <seealso href="http://schema.org/openingHoursSpecification">http://schema.org/openingHoursSpecification</seealso>
    let openingHoursSpecification =
        Prefixed_Name(schema1, "openingHoursSpecification") |> PrefixedName

    /// <summary>
    ///   <para>schema1:opens</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The opening hour of the place or service on the given day(s) of the week.</para>
    /// labels<para>opens</para></remarks>
    /// <seealso href="http://schema.org/opens">http://schema.org/opens</seealso>
    let opens = Prefixed_Name(schema1, "opens") |> PrefixedName
    /// <summary>
    ///   <para>schema1:operatingSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Operating systems supported (Windows 7, OSX 10.6, Android 1.6).</para>
    /// labels<para>operatingSystem</para></remarks>
    /// <seealso href="http://schema.org/operatingSystem">http://schema.org/operatingSystem</seealso>
    let operatingSystem = Prefixed_Name(schema1, "operatingSystem") |> PrefixedName
    /// <summary>
    ///   <para>schema1:opponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of participant. The opponent on this action.</para>
    /// labels<para>opponent</para></remarks>
    /// <seealso href="http://schema.org/opponent">http://schema.org/opponent</seealso>
    let opponent = Prefixed_Name(schema1, "opponent") |> PrefixedName
    /// <summary>
    ///   <para>schema1:option</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of object. The options subject to this action.</para>
    /// labels<para>option</para></remarks>
    /// <seealso href="http://schema.org/option">http://schema.org/option</seealso>
    let option = Prefixed_Name(schema1, "option") |> PrefixedName
    /// <summary>
    ///   <para>schema1:orderDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Date order was placed.</para>
    /// labels<para>orderDate</para></remarks>
    /// <seealso href="http://schema.org/orderDate">http://schema.org/orderDate</seealso>
    let orderDate = Prefixed_Name(schema1, "orderDate") |> PrefixedName
    /// <summary>
    ///   <para>schema1:orderDelivery</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The delivery of the parcel related to this order or order item.</para>
    /// labels<para>orderDelivery</para></remarks>
    /// <seealso href="http://schema.org/orderDelivery">http://schema.org/orderDelivery</seealso>
    let orderDelivery = Prefixed_Name(schema1, "orderDelivery") |> PrefixedName
    /// <summary>
    ///   <para>schema1:orderItemNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The identifier of the order item.</para>
    /// labels<para>orderItemNumber</para></remarks>
    /// <seealso href="http://schema.org/orderItemNumber">http://schema.org/orderItemNumber</seealso>
    let orderItemNumber = Prefixed_Name(schema1, "orderItemNumber") |> PrefixedName
    /// <summary>
    ///   <para>schema1:orderStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The current status of the order.</para>
    /// labels<para>orderStatus</para></remarks>
    /// <seealso href="http://schema.org/orderStatus">http://schema.org/orderStatus</seealso>
    let orderStatus = Prefixed_Name(schema1, "orderStatus") |> PrefixedName
    /// <summary>
    ///   <para>schema1:orderedItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The item ordered.</para>
    /// labels<para>orderedItem</para></remarks>
    /// <seealso href="http://schema.org/orderedItem">http://schema.org/orderedItem</seealso>
    let orderedItem = Prefixed_Name(schema1, "orderedItem") |> PrefixedName
    /// <summary>
    ///   <para>schema1:organizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An organizer of an Event.</para>
    /// labels<para>organizer</para></remarks>
    /// <seealso href="http://schema.org/organizer">http://schema.org/organizer</seealso>
    let organizer = Prefixed_Name(schema1, "organizer") |> PrefixedName
    /// <summary>
    ///   <para>schema1:originAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Shipper's address.</para>
    /// labels<para>originAddress</para></remarks>
    /// <seealso href="http://schema.org/originAddress">http://schema.org/originAddress</seealso>
    let originAddress = Prefixed_Name(schema1, "originAddress") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ownedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The date and time of obtaining the product.</para>
    /// labels<para>ownedFrom</para></remarks>
    /// <seealso href="http://schema.org/ownedFrom">http://schema.org/ownedFrom</seealso>
    let ownedFrom = Prefixed_Name(schema1, "ownedFrom") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ownedThrough</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The date and time of giving up ownership on the product.</para>
    /// labels<para>ownedThrough</para></remarks>
    /// <seealso href="http://schema.org/ownedThrough">http://schema.org/ownedThrough</seealso>
    let ownedThrough = Prefixed_Name(schema1, "ownedThrough") |> PrefixedName
    /// <summary>
    ///   <para>schema1:owns</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Products owned by the organization or person.</para>
    /// labels<para>owns</para></remarks>
    /// <seealso href="http://schema.org/owns">http://schema.org/owns</seealso>
    let owns = Prefixed_Name(schema1, "owns") |> PrefixedName
    /// <summary>
    ///   <para>schema1:pageEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The page on which the work ends; for example "138" or "xvi".</para>
    /// labels<para>pageEnd</para></remarks>
    /// <seealso href="http://schema.org/pageEnd">http://schema.org/pageEnd</seealso>
    let pageEnd = Prefixed_Name(schema1, "pageEnd") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Chapter</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schema.org/Chapter">http://schema.org/Chapter</seealso>
    let Chapter = Prefixed_Name(schema1, "Chapter") |> PrefixedName
    /// <summary>
    ///   <para>schema1:pageStart</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The page on which the work starts; for example "135" or "xiii".</para>
    /// labels<para>pageStart</para></remarks>
    /// <seealso href="http://schema.org/pageStart">http://schema.org/pageStart</seealso>
    let pageStart = Prefixed_Name(schema1, "pageStart") |> PrefixedName
    /// <summary>
    ///   <para>schema1:pagination</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Any description of pages that is not separated into pageStart and pageEnd; for example, "1-6, 9, 55" or "10-12, 46-49".</para>
    /// labels<para>pagination</para></remarks>
    /// <seealso href="http://schema.org/pagination">http://schema.org/pagination</seealso>
    let pagination = Prefixed_Name(schema1, "pagination") |> PrefixedName
    /// <summary>
    ///   <para>schema1:parent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A parent of this person.</para>
    /// labels<para>parent</para></remarks>
    /// <seealso href="http://schema.org/parent">http://schema.org/parent</seealso>
    let parent = Prefixed_Name(schema1, "parent") |> PrefixedName
    /// <summary>
    ///   <para>schema1:parentItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The parent of a question, answer or item in general.</para>
    /// labels<para>parentItem</para></remarks>
    /// <seealso href="http://schema.org/parentItem">http://schema.org/parentItem</seealso>
    let parentItem = Prefixed_Name(schema1, "parentItem") |> PrefixedName
    /// <summary>
    ///   <para>schema1:subOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A relationship between two organizations where the first includes the second, e.g., as a subsidiary. See also: the more specific 'department' property.</para>
    /// labels<para>subOrganization</para></remarks>
    /// <seealso href="http://schema.org/subOrganization">http://schema.org/subOrganization</seealso>
    let subOrganization = Prefixed_Name(schema1, "subOrganization") |> PrefixedName
    /// <summary>
    ///   <para>schema1:parentService</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A broadcast service to which the broadcast service may belong to such as regional variations of a national channel.</para>
    /// labels<para>parentService</para></remarks>
    /// <seealso href="http://schema.org/parentService">http://schema.org/parentService</seealso>
    let parentService = Prefixed_Name(schema1, "parentService") |> PrefixedName
    /// <summary>
    ///   <para>schema1:parents</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A parents of the person.</para>
    /// labels<para>parents</para></remarks>
    /// <seealso href="http://schema.org/parents">http://schema.org/parents</seealso>
    let parents = Prefixed_Name(schema1, "parents") |> PrefixedName
    /// <summary>
    ///   <para>schema1:partOfEpisode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The episode to which this clip belongs.</para>
    /// labels<para>partOfEpisode</para></remarks>
    /// <seealso href="http://schema.org/partOfEpisode">http://schema.org/partOfEpisode</seealso>
    let partOfEpisode = Prefixed_Name(schema1, "partOfEpisode") |> PrefixedName
    /// <summary>
    ///   <para>schema1:partOfInvoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The order is being paid as part of the referenced Invoice.</para>
    /// labels<para>partOfInvoice</para></remarks>
    /// <seealso href="http://schema.org/partOfInvoice">http://schema.org/partOfInvoice</seealso>
    let partOfInvoice = Prefixed_Name(schema1, "partOfInvoice") |> PrefixedName
    /// <summary>
    ///   <para>schema1:partOfOrder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The overall order the items in this delivery were included in.</para>
    /// labels<para>partOfOrder</para></remarks>
    /// <seealso href="http://schema.org/partOfOrder">http://schema.org/partOfOrder</seealso>
    let partOfOrder = Prefixed_Name(schema1, "partOfOrder") |> PrefixedName
    /// <summary>
    ///   <para>schema1:partOfSeason</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The season to which this episode belongs.</para>
    /// labels<para>partOfSeason</para></remarks>
    /// <seealso href="http://schema.org/partOfSeason">http://schema.org/partOfSeason</seealso>
    let partOfSeason = Prefixed_Name(schema1, "partOfSeason") |> PrefixedName
    /// <summary>
    ///   <para>schema1:partOfSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The series to which this episode or season belongs.</para>
    /// labels<para>partOfSeries</para></remarks>
    /// <seealso href="http://schema.org/partOfSeries">http://schema.org/partOfSeries</seealso>
    let partOfSeries = Prefixed_Name(schema1, "partOfSeries") |> PrefixedName
    /// <summary>
    ///   <para>schema1:paymentAccepted</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Cash, Credit Card, Cryptocurrency, Local Exchange Tradings System, etc.</para>
    /// labels<para>paymentAccepted</para></remarks>
    /// <seealso href="http://schema.org/paymentAccepted">http://schema.org/paymentAccepted</seealso>
    let paymentAccepted = Prefixed_Name(schema1, "paymentAccepted") |> PrefixedName
    /// <summary>
    ///   <para>schema1:paymentDue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The date that payment is due.</para>
    /// labels<para>paymentDue</para></remarks>
    /// <seealso href="http://schema.org/paymentDue">http://schema.org/paymentDue</seealso>
    let paymentDue = Prefixed_Name(schema1, "paymentDue") |> PrefixedName
    /// <summary>
    ///   <para>schema1:paymentDueDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The date that payment is due.</para>
    /// labels<para>paymentDueDate</para></remarks>
    /// <seealso href="http://schema.org/paymentDueDate">http://schema.org/paymentDueDate</seealso>
    let paymentDueDate = Prefixed_Name(schema1, "paymentDueDate") |> PrefixedName
    /// <summary>
    ///   <para>schema1:paymentMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The name of the credit card or other method of payment for the order.</para>
    /// labels<para>paymentMethod</para></remarks>
    /// <seealso href="http://schema.org/paymentMethod">http://schema.org/paymentMethod</seealso>
    let paymentMethod = Prefixed_Name(schema1, "paymentMethod") |> PrefixedName
    /// <summary>
    ///   <para>schema1:paymentMethodId</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An identifier for the method of payment used (e.g. the last 4 digits of the credit card).</para>
    /// labels<para>paymentMethodId</para></remarks>
    /// <seealso href="http://schema.org/paymentMethodId">http://schema.org/paymentMethodId</seealso>
    let paymentMethodId = Prefixed_Name(schema1, "paymentMethodId") |> PrefixedName
    /// <summary>
    ///   <para>schema1:paymentStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The status of payment; whether the invoice has been paid or not.</para>
    /// labels<para>paymentStatus</para></remarks>
    /// <seealso href="http://schema.org/paymentStatus">http://schema.org/paymentStatus</seealso>
    let paymentStatus = Prefixed_Name(schema1, "paymentStatus") |> PrefixedName
    /// <summary>
    ///   <para>schema1:paymentUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The URL for sending a payment.</para>
    /// labels<para>paymentUrl</para></remarks>
    /// <seealso href="http://schema.org/paymentUrl">http://schema.org/paymentUrl</seealso>
    let paymentUrl = Prefixed_Name(schema1, "paymentUrl") |> PrefixedName
    /// <summary>
    ///   <para>schema1:percentile10</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The 10th percentile value.</para>
    /// labels<para>percentile10</para></remarks>
    /// <seealso href="http://schema.org/percentile10">http://schema.org/percentile10</seealso>
    let percentile10 = Prefixed_Name(schema1, "percentile10") |> PrefixedName
    /// <summary>
    ///   <para>schema1:percentile25</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The 25th percentile value.</para>
    /// labels<para>percentile25</para></remarks>
    /// <seealso href="http://schema.org/percentile25">http://schema.org/percentile25</seealso>
    let percentile25 = Prefixed_Name(schema1, "percentile25") |> PrefixedName
    /// <summary>
    ///   <para>schema1:percentile75</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The 75th percentile value.</para>
    /// labels<para>percentile75</para></remarks>
    /// <seealso href="http://schema.org/percentile75">http://schema.org/percentile75</seealso>
    let percentile75 = Prefixed_Name(schema1, "percentile75") |> PrefixedName
    /// <summary>
    ///   <para>schema1:percentile90</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The 90th percentile value.</para>
    /// labels<para>percentile90</para></remarks>
    /// <seealso href="http://schema.org/percentile90">http://schema.org/percentile90</seealso>
    let percentile90 = Prefixed_Name(schema1, "percentile90") |> PrefixedName
    /// <summary>
    ///   <para>schema1:performer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A performer at the event&amp;#x2014;for example, a presenter, musician, musical group or actor.</para>
    /// labels<para>performer</para></remarks>
    /// <seealso href="http://schema.org/performer">http://schema.org/performer</seealso>
    let performer = Prefixed_Name(schema1, "performer") |> PrefixedName
    /// <summary>
    ///   <para>schema1:performerIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Event that this person is a performer or participant in.</para>
    /// labels<para>performerIn</para></remarks>
    /// <seealso href="http://schema.org/performerIn">http://schema.org/performerIn</seealso>
    let performerIn = Prefixed_Name(schema1, "performerIn") |> PrefixedName
    /// <summary>
    ///   <para>schema1:performers</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The main performer or performers of the event&amp;#x2014;for example, a presenter, musician, or actor.</para>
    /// labels<para>performers</para></remarks>
    /// <seealso href="http://schema.org/performers">http://schema.org/performers</seealso>
    let performers = Prefixed_Name(schema1, "performers") |> PrefixedName
    /// <summary>
    ///   <para>schema1:permissionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The type of permission granted the person, organization, or audience.</para>
    /// labels<para>permissionType</para></remarks>
    /// <seealso href="http://schema.org/permissionType">http://schema.org/permissionType</seealso>
    let permissionType = Prefixed_Name(schema1, "permissionType") |> PrefixedName
    /// <summary>
    ///   <para>schema1:permissions</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Permission(s) required to run the app (for example, a mobile app may require full internet access or may run only on wifi).</para>
    /// labels<para>permissions</para></remarks>
    /// <seealso href="http://schema.org/permissions">http://schema.org/permissions</seealso>
    let permissions = Prefixed_Name(schema1, "permissions") |> PrefixedName
    /// <summary>
    ///   <para>schema1:permitAudience</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The target audience for this permit.</para>
    /// labels<para>permitAudience</para></remarks>
    /// <seealso href="http://schema.org/permitAudience">http://schema.org/permitAudience</seealso>
    let permitAudience = Prefixed_Name(schema1, "permitAudience") |> PrefixedName
    /// <summary>
    ///   <para>schema1:permittedUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indications regarding the permitted usage of the accommodation.</para>
    /// labels<para>permittedUsage</para></remarks>
    /// <seealso href="http://schema.org/permittedUsage">http://schema.org/permittedUsage</seealso>
    let permittedUsage = Prefixed_Name(schema1, "permittedUsage") |> PrefixedName
    /// <summary>
    ///   <para>schema1:petsAllowed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates whether pets are allowed to enter the accommodation or lodging business. More detailed information can be put in a text value.</para>
    /// labels<para>petsAllowed</para></remarks>
    /// <seealso href="http://schema.org/petsAllowed">http://schema.org/petsAllowed</seealso>
    let petsAllowed = Prefixed_Name(schema1, "petsAllowed") |> PrefixedName
    /// <summary>
    ///   <para>schema1:photo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A photograph of this place.</para>
    /// labels<para>photo</para></remarks>
    /// <seealso href="http://schema.org/photo">http://schema.org/photo</seealso>
    let photo = Prefixed_Name(schema1, "photo") |> PrefixedName
    /// <summary>
    ///   <para>schema1:photos</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Photographs of this place.</para>
    /// labels<para>photos</para></remarks>
    /// <seealso href="http://schema.org/photos">http://schema.org/photos</seealso>
    let photos = Prefixed_Name(schema1, "photos") |> PrefixedName
    /// <summary>
    ///   <para>schema1:transFatContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of grams of trans fat.</para>
    /// labels<para>transFatContent</para></remarks>
    /// <seealso href="http://schema.org/transFatContent">http://schema.org/transFatContent</seealso>
    let transFatContent = Prefixed_Name(schema1, "transFatContent") |> PrefixedName
    /// <summary>
    ///   <para>schema1:transcript</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>If this MediaObject is an AudioObject or VideoObject, the transcript of that object.</para>
    /// labels<para>transcript</para></remarks>
    /// <seealso href="http://schema.org/transcript">http://schema.org/transcript</seealso>
    let transcript = Prefixed_Name(schema1, "transcript") |> PrefixedName
    /// <summary>
    ///   <para>schema1:translator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Organization or person who adapts a creative work to different languages, regional differences and technical requirements of a target market, or that translates during some event.</para>
    /// labels<para>translator</para></remarks>
    /// <seealso href="http://schema.org/translator">http://schema.org/translator</seealso>
    let translator = Prefixed_Name(schema1, "translator") |> PrefixedName
    /// <summary>
    ///   <para>schema1:typeOfBed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The type of bed to which the BedDetail refers, i.e. the type of bed available in the quantity indicated by quantity.</para>
    /// labels<para>typeOfBed</para></remarks>
    /// <seealso href="http://schema.org/typeOfBed">http://schema.org/typeOfBed</seealso>
    let typeOfBed = Prefixed_Name(schema1, "typeOfBed") |> PrefixedName
    /// <summary>
    ///   <para>schema1:typeOfGood</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The product that this structured value is referring to.</para>
    /// labels<para>typeOfGood</para></remarks>
    /// <seealso href="http://schema.org/typeOfGood">http://schema.org/typeOfGood</seealso>
    let typeOfGood = Prefixed_Name(schema1, "typeOfGood") |> PrefixedName
    /// <summary>
    ///   <para>schema1:typicalAgeRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The typical expected age range, e.g. '7-9', '11-'.</para>
    /// labels<para>typicalAgeRange</para></remarks>
    /// <seealso href="http://schema.org/typicalAgeRange">http://schema.org/typicalAgeRange</seealso>
    let typicalAgeRange = Prefixed_Name(schema1, "typicalAgeRange") |> PrefixedName
    /// <summary>
    ///   <para>schema1:underName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The person or organization the reservation or ticket is for.</para>
    /// labels<para>underName</para></remarks>
    /// <seealso href="http://schema.org/underName">http://schema.org/underName</seealso>
    let underName = Prefixed_Name(schema1, "underName") |> PrefixedName
    /// <summary>
    ///   <para>schema1:unitCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The unit of measurement given using the UN/CEFACT Common Code (3 characters) or a URL. Other codes than the UN/CEFACT Common Code may be used with a prefix followed by a colon.</para>
    /// labels<para>unitCode</para></remarks>
    /// <seealso href="http://schema.org/unitCode">http://schema.org/unitCode</seealso>
    let unitCode = Prefixed_Name(schema1, "unitCode") |> PrefixedName
    /// <summary>
    ///   <para>schema1:unitText</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A string or text indicating the unit of measurement. Useful if you cannot provide a standard unit code for
    /// &lt;a href='unitCode'&gt;unitCode&lt;/a&gt;.</para>
    /// labels<para>unitText</para></remarks>
    /// <seealso href="http://schema.org/unitText">http://schema.org/unitText</seealso>
    let unitText = Prefixed_Name(schema1, "unitText") |> PrefixedName

    /// <summary>
    ///   <para>schema1:unsaturatedFatContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of grams of unsaturated fat.</para>
    /// labels<para>unsaturatedFatContent</para></remarks>
    /// <seealso href="http://schema.org/unsaturatedFatContent">http://schema.org/unsaturatedFatContent</seealso>
    let unsaturatedFatContent =
        Prefixed_Name(schema1, "unsaturatedFatContent") |> PrefixedName

    /// <summary>
    ///   <para>schema1:uploadDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Date when this media object was uploaded to this site.</para>
    /// labels<para>uploadDate</para></remarks>
    /// <seealso href="http://schema.org/uploadDate">http://schema.org/uploadDate</seealso>
    let uploadDate = Prefixed_Name(schema1, "uploadDate") |> PrefixedName
    /// <summary>
    ///   <para>schema1:upvoteCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of upvotes this question, answer or comment has received from the community.</para>
    /// labels<para>upvoteCount</para></remarks>
    /// <seealso href="http://schema.org/upvoteCount">http://schema.org/upvoteCount</seealso>
    let upvoteCount = Prefixed_Name(schema1, "upvoteCount") |> PrefixedName
    /// <summary>
    ///   <para>schema1:url</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>URL of the item.</para>
    /// labels<para>url</para></remarks>
    /// <seealso href="http://schema.org/url">http://schema.org/url</seealso>
    let url = Prefixed_Name(schema1, "url") |> PrefixedName
    /// <summary>
    ///   <para>schema1:urlTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An url template (RFC6570) that will be used to construct the target of the execution of the action.</para>
    /// labels<para>urlTemplate</para></remarks>
    /// <seealso href="http://schema.org/urlTemplate">http://schema.org/urlTemplate</seealso>
    let urlTemplate = Prefixed_Name(schema1, "urlTemplate") |> PrefixedName

    /// <summary>
    ///   <para>schema1:userInteractionCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of interactions for the CreativeWork using the WebSite or SoftwareApplication.</para>
    /// labels<para>userInteractionCount</para></remarks>
    /// <seealso href="http://schema.org/userInteractionCount">http://schema.org/userInteractionCount</seealso>
    let userInteractionCount =
        Prefixed_Name(schema1, "userInteractionCount") |> PrefixedName

    /// <summary>
    ///   <para>schema1:validFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The duration of validity of a permit or similar thing.</para>
    /// labels<para>validFor</para></remarks>
    /// <seealso href="http://schema.org/validFor">http://schema.org/validFor</seealso>
    let validFor = Prefixed_Name(schema1, "validFor") |> PrefixedName
    /// <summary>
    ///   <para>schema1:validFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The date when the item becomes valid.</para>
    /// labels<para>validFrom</para></remarks>
    /// <seealso href="http://schema.org/validFrom">http://schema.org/validFrom</seealso>
    let validFrom = Prefixed_Name(schema1, "validFrom") |> PrefixedName
    /// <summary>
    ///   <para>schema1:validIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The geographic area where a permit or similar thing is valid.</para>
    /// labels<para>validIn</para></remarks>
    /// <seealso href="http://schema.org/validIn">http://schema.org/validIn</seealso>
    let validIn = Prefixed_Name(schema1, "validIn") |> PrefixedName
    /// <summary>
    ///   <para>schema1:validThrough</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.</para>
    /// labels<para>validThrough</para></remarks>
    /// <seealso href="http://schema.org/validThrough">http://schema.org/validThrough</seealso>
    let validThrough = Prefixed_Name(schema1, "validThrough") |> PrefixedName
    /// <summary>
    ///   <para>schema1:validUntil</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The date when the item is no longer valid.</para>
    /// labels<para>validUntil</para></remarks>
    /// <seealso href="http://schema.org/validUntil">http://schema.org/validUntil</seealso>
    let validUntil = Prefixed_Name(schema1, "validUntil") |> PrefixedName
    /// <summary>
    ///   <para>schema1:TransferAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of transferring/moving (abstract or concrete) animate or inanimate objects from one place to another.</para>
    /// labels<para>TransferAction</para></remarks>
    /// <seealso href="http://schema.org/TransferAction">http://schema.org/TransferAction</seealso>
    let TransferAction = Prefixed_Name(schema1, "TransferAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ItemList</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A list of items of any sort&amp;#x2014;for example, Top 10 Movies About Weathermen, or Top 100 Party Songs. Not to be confused with HTML lists, which are often used only for formatting.</para>
    /// labels<para>ItemList</para></remarks>
    /// <seealso href="http://schema.org/ItemList">http://schema.org/ItemList</seealso>
    let ItemList = Prefixed_Name(schema1, "ItemList") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Brewery</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Brewery.</para>
    /// labels<para>Brewery</para></remarks>
    /// <seealso href="http://schema.org/Brewery">http://schema.org/Brewery</seealso>
    let Brewery = Prefixed_Name(schema1, "Brewery") |> PrefixedName
    /// <summary>
    ///   <para>schema1:BroadcastChannel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A unique instance of a BroadcastService on a CableOrSatelliteService lineup.</para>
    /// labels<para>BroadcastChannel</para></remarks>
    /// <seealso href="http://schema.org/BroadcastChannel">http://schema.org/BroadcastChannel</seealso>
    let BroadcastChannel = Prefixed_Name(schema1, "BroadcastChannel") |> PrefixedName
    /// <summary>
    ///   <para>schema1:PublicationEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A PublicationEvent corresponds indifferently to the event of publication for a CreativeWork of any type e.g. a broadcast event, an on-demand event, a book/journal publication via a variety of delivery media.</para>
    /// labels<para>PublicationEvent</para></remarks>
    /// <seealso href="http://schema.org/PublicationEvent">http://schema.org/PublicationEvent</seealso>
    let PublicationEvent = Prefixed_Name(schema1, "PublicationEvent") |> PrefixedName
    /// <summary>
    ///   <para>schema1:MovieRentalStore</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A movie rental store.</para>
    /// labels<para>MovieRentalStore</para></remarks>
    /// <seealso href="http://schema.org/MovieRentalStore">http://schema.org/MovieRentalStore</seealso>
    let MovieRentalStore = Prefixed_Name(schema1, "MovieRentalStore") |> PrefixedName
    /// <summary>
    ///   <para>schema1:MovieTheater</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A movie theater.</para>
    /// labels<para>MovieTheater</para></remarks>
    /// <seealso href="http://schema.org/MovieTheater">http://schema.org/MovieTheater</seealso>
    let MovieTheater = Prefixed_Name(schema1, "MovieTheater") |> PrefixedName
    /// <summary>
    ///   <para>schema1:MovingCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A moving company.</para>
    /// labels<para>MovingCompany</para></remarks>
    /// <seealso href="http://schema.org/MovingCompany">http://schema.org/MovingCompany</seealso>
    let MovingCompany = Prefixed_Name(schema1, "MovingCompany") |> PrefixedName
    /// <summary>
    ///   <para>schema1:SomeProducts</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A placeholder for multiple similar products of the same kind.</para>
    /// labels<para>SomeProducts</para></remarks>
    /// <seealso href="http://schema.org/SomeProducts">http://schema.org/SomeProducts</seealso>
    let SomeProducts = Prefixed_Name(schema1, "SomeProducts") |> PrefixedName
    /// <summary>
    ///   <para>schema1:containsSeason</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A season that is part of the media series.</para>
    /// labels<para>containsSeason</para></remarks>
    /// <seealso href="http://schema.org/containsSeason">http://schema.org/containsSeason</seealso>
    let containsSeason = Prefixed_Name(schema1, "containsSeason") |> PrefixedName
    /// <summary>
    ///   <para>schema1:hasPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates an item or CreativeWork that is part of this item, or CreativeWork (in some sense).</para>
    /// labels<para>hasPart</para></remarks>
    /// <seealso href="http://schema.org/hasPart">http://schema.org/hasPart</seealso>
    let hasPart = Prefixed_Name(schema1, "hasPart") |> PrefixedName
    /// <summary>
    ///   <para>schema1:text</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The textual content of this CreativeWork.</para>
    /// labels<para>text</para></remarks>
    /// <seealso href="http://schema.org/text">http://schema.org/text</seealso>
    let text = Prefixed_Name(schema1, "text") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ticketNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The unique identifier for the ticket.</para>
    /// labels<para>ticketNumber</para></remarks>
    /// <seealso href="http://schema.org/ticketNumber">http://schema.org/ticketNumber</seealso>
    let ticketNumber = Prefixed_Name(schema1, "ticketNumber") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An action performed by a direct agent and indirect participants upon a direct object. Optionally happens at a location with the help of an inanimate instrument. The execution of the action may produce a result. Specific action sub-type documentation specifies the exact expectation of each argument/role.&lt;br/&gt;&lt;br/&gt;
    ///
    /// See also &lt;a href="http://blog.schema.org/2014/04/announcing-schemaorg-actions.html"&gt;blog post&lt;/a&gt; and &lt;a href="http://schema.org/docs/actions.html"&gt;Actions overview document&lt;/a&gt;.</para>
    /// labels<para>Action</para></remarks>
    /// <seealso href="http://schema.org/Action">http://schema.org/Action</seealso>
    let Action = Prefixed_Name(schema1, "Action") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ActionStatusType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The status of an Action.</para>
    /// labels<para>ActionStatusType</para></remarks>
    /// <seealso href="http://schema.org/ActionStatusType">http://schema.org/ActionStatusType</seealso>
    let ActionStatusType = Prefixed_Name(schema1, "ActionStatusType") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ActivateAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of starting or activating a device or application (e.g. starting a timer or turning on a flashlight).</para>
    /// labels<para>ActivateAction</para></remarks>
    /// <seealso href="http://schema.org/ActivateAction">http://schema.org/ActivateAction</seealso>
    let ActivateAction = Prefixed_Name(schema1, "ActivateAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ControlAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An agent controls a device or application.</para>
    /// labels<para>ControlAction</para></remarks>
    /// <seealso href="http://schema.org/ControlAction">http://schema.org/ControlAction</seealso>
    let ControlAction = Prefixed_Name(schema1, "ControlAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:UpdateAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of managing by changing/editing the state of the object.</para>
    /// labels<para>UpdateAction</para></remarks>
    /// <seealso href="http://schema.org/UpdateAction">http://schema.org/UpdateAction</seealso>
    let UpdateAction = Prefixed_Name(schema1, "UpdateAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:CityHall</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A city hall.</para>
    /// labels<para>CityHall</para></remarks>
    /// <seealso href="http://schema.org/CityHall">http://schema.org/CityHall</seealso>
    let CityHall = Prefixed_Name(schema1, "CityHall") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Review</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A review of an item - for example, of a restaurant, movie, or store.</para>
    /// labels<para>Review</para></remarks>
    /// <seealso href="http://schema.org/Review">http://schema.org/Review</seealso>
    let Review = Prefixed_Name(schema1, "Review") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Code</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Computer programming source code. Example: Full (compile ready) solutions, code snippet samples, scripts, templates.</para>
    /// labels<para>Code</para></remarks>
    /// <seealso href="http://schema.org/Code">http://schema.org/Code</seealso>
    let Code = Prefixed_Name(schema1, "Code") |> PrefixedName
    /// <summary>
    ///   <para>schema1:supersededBy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schema.org/supersededBy">http://schema.org/supersededBy</seealso>
    let supersededBy = Prefixed_Name(schema1, "supersededBy") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Flight</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An airline flight.</para>
    /// labels<para>Flight</para></remarks>
    /// <seealso href="http://schema.org/Flight">http://schema.org/Flight</seealso>
    let Flight = Prefixed_Name(schema1, "Flight") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Number</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:DataType</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Data type: Number.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Usage guidelines:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
    /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>Number</para></remarks>
    /// <seealso href="http://schema.org/Number">http://schema.org/Number</seealso>
    let Number = Prefixed_Name(schema1, "Number") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Florist</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A florist.</para>
    /// labels<para>Florist</para></remarks>
    /// <seealso href="http://schema.org/Florist">http://schema.org/Florist</seealso>
    let Florist = Prefixed_Name(schema1, "Florist") |> PrefixedName
    /// <summary>
    ///   <para>schema1:FoodEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Event type: Food event.</para>
    /// labels<para>FoodEvent</para></remarks>
    /// <seealso href="http://schema.org/FoodEvent">http://schema.org/FoodEvent</seealso>
    let FoodEvent = Prefixed_Name(schema1, "FoodEvent") |> PrefixedName
    /// <summary>
    ///   <para>schema1:FoodService</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A food service, like breakfast, lunch, or dinner.</para>
    /// labels<para>FoodService</para></remarks>
    /// <seealso href="http://schema.org/FoodService">http://schema.org/FoodService</seealso>
    let FoodService = Prefixed_Name(schema1, "FoodService") |> PrefixedName

    /// <summary>
    ///   <para>schema1:FrontWheelDriveConfiguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:DriveWheelConfigurationValue</para>
    ///   <para>Front-wheel drive is a transmission layout where the engine drives the front wheels.</para>
    /// labels<para>FrontWheelDriveConfiguration</para></remarks>
    /// <seealso href="http://schema.org/FrontWheelDriveConfiguration">http://schema.org/FrontWheelDriveConfiguration</seealso>
    let FrontWheelDriveConfiguration =
        Prefixed_Name(schema1, "FrontWheelDriveConfiguration") |> PrefixedName

    /// <summary>
    ///   <para>schema1:GameServer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Server that provides game interaction in a multiplayer game.</para>
    /// labels<para>GameServer</para></remarks>
    /// <seealso href="http://schema.org/GameServer">http://schema.org/GameServer</seealso>
    let GameServer = Prefixed_Name(schema1, "GameServer") |> PrefixedName

    /// <summary>
    ///   <para>schema1:GatedResidenceCommunity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Residence type: Gated community.</para>
    /// labels<para>GatedResidenceCommunity</para></remarks>
    /// <seealso href="http://schema.org/GatedResidenceCommunity">http://schema.org/GatedResidenceCommunity</seealso>
    let GatedResidenceCommunity =
        Prefixed_Name(schema1, "GatedResidenceCommunity") |> PrefixedName

    /// <summary>
    ///   <para>schema1:GeoShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The geographic shape of a place. A GeoShape can be described using several properties whose values are based on latitude/longitude pairs. Either whitespace or commas can be used to separate latitude and longitude; whitespace should be used when writing a list of several such points.</para>
    /// labels<para>GeoShape</para></remarks>
    /// <seealso href="http://schema.org/GeoShape">http://schema.org/GeoShape</seealso>
    let GeoShape = Prefixed_Name(schema1, "GeoShape") |> PrefixedName
    /// <summary>
    ///   <para>schema1:GeoCoordinates</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The geographic coordinates of a place or event.</para>
    /// labels<para>GeoCoordinates</para></remarks>
    /// <seealso href="http://schema.org/GeoCoordinates">http://schema.org/GeoCoordinates</seealso>
    let GeoCoordinates = Prefixed_Name(schema1, "GeoCoordinates") |> PrefixedName
    /// <summary>
    ///   <para>schema1:PaymentComplete</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:PaymentStatusType</para>
    ///   <para>The payment has been received and processed.</para>
    /// labels<para>PaymentComplete</para></remarks>
    /// <seealso href="http://schema.org/PaymentComplete">http://schema.org/PaymentComplete</seealso>
    let PaymentComplete = Prefixed_Name(schema1, "PaymentComplete") |> PrefixedName
    /// <summary>
    ///   <para>schema1:PaymentDeclined</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:PaymentStatusType</para>
    ///   <para>The payee received the payment, but it was declined for some reason.</para>
    /// labels<para>PaymentDeclined</para></remarks>
    /// <seealso href="http://schema.org/PaymentDeclined">http://schema.org/PaymentDeclined</seealso>
    let PaymentDeclined = Prefixed_Name(schema1, "PaymentDeclined") |> PrefixedName
    /// <summary>
    ///   <para>schema1:PerformAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of participating in performance arts.</para>
    /// labels<para>PerformAction</para></remarks>
    /// <seealso href="http://schema.org/PerformAction">http://schema.org/PerformAction</seealso>
    let PerformAction = Prefixed_Name(schema1, "PerformAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:dayOfWeek</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The day of the week for which these opening hours are valid.</para>
    /// labels<para>dayOfWeek</para></remarks>
    /// <seealso href="http://schema.org/dayOfWeek">http://schema.org/dayOfWeek</seealso>
    let dayOfWeek = Prefixed_Name(schema1, "dayOfWeek") |> PrefixedName

    /// <summary>
    ///   <para>schema1:EducationalOccupationalProgram</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schema.org/EducationalOccupationalProgram">http://schema.org/EducationalOccupationalProgram</seealso>
    let EducationalOccupationalProgram =
        Prefixed_Name(schema1, "EducationalOccupationalProgram") |> PrefixedName

    /// <summary>
    ///   <para>schema1:deathDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Date of death.</para>
    /// labels<para>deathDate</para></remarks>
    /// <seealso href="http://schema.org/deathDate">http://schema.org/deathDate</seealso>
    let deathDate = Prefixed_Name(schema1, "deathDate") |> PrefixedName
    /// <summary>
    ///   <para>schema1:deathPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The place where the person died.</para>
    /// labels<para>deathPlace</para></remarks>
    /// <seealso href="http://schema.org/deathPlace">http://schema.org/deathPlace</seealso>
    let deathPlace = Prefixed_Name(schema1, "deathPlace") |> PrefixedName
    /// <summary>
    ///   <para>schema1:itemReviewed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The item that is being reviewed/rated.</para>
    /// labels<para>itemReviewed</para></remarks>
    /// <seealso href="http://schema.org/itemReviewed">http://schema.org/itemReviewed</seealso>
    let itemReviewed = Prefixed_Name(schema1, "itemReviewed") |> PrefixedName
    /// <summary>
    ///   <para>schema1:itemShipped</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Item(s) being shipped.</para>
    /// labels<para>itemShipped</para></remarks>
    /// <seealso href="http://schema.org/itemShipped">http://schema.org/itemShipped</seealso>
    let itemShipped = Prefixed_Name(schema1, "itemShipped") |> PrefixedName

    /// <summary>
    ///   <para>schema1:knownVehicleDamages</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A textual description of known damages, both repaired and unrepaired.</para>
    /// labels<para>knownVehicleDamages</para></remarks>
    /// <seealso href="http://schema.org/knownVehicleDamages">http://schema.org/knownVehicleDamages</seealso>
    let knownVehicleDamages =
        Prefixed_Name(schema1, "knownVehicleDamages") |> PrefixedName

    /// <summary>
    ///   <para>schema1:knows</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The most generic bi-directional social/work relation.</para>
    /// labels<para>knows</para></remarks>
    /// <seealso href="http://schema.org/knows">http://schema.org/knows</seealso>
    let knows = Prefixed_Name(schema1, "knows") |> PrefixedName
    /// <summary>
    ///   <para>schema1:lastReviewed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Date on which the content on this web page was last reviewed for accuracy and/or completeness.</para>
    /// labels<para>lastReviewed</para></remarks>
    /// <seealso href="http://schema.org/lastReviewed">http://schema.org/lastReviewed</seealso>
    let lastReviewed = Prefixed_Name(schema1, "lastReviewed") |> PrefixedName
    /// <summary>
    ///   <para>schema1:latitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The latitude of a location. For example &lt;code&gt;37.42242&lt;/code&gt; (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).</para>
    /// labels<para>latitude</para></remarks>
    /// <seealso href="http://schema.org/latitude">http://schema.org/latitude</seealso>
    let latitude = Prefixed_Name(schema1, "latitude") |> PrefixedName

    /// <summary>
    ///   <para>schema1:learningResourceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The predominant type or kind characterizing the learning resource. For example, 'presentation', 'handout'.</para>
    /// labels<para>learningResourceType</para></remarks>
    /// <seealso href="http://schema.org/learningResourceType">http://schema.org/learningResourceType</seealso>
    let learningResourceType =
        Prefixed_Name(schema1, "learningResourceType") |> PrefixedName

    /// <summary>
    ///   <para>schema1:legalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The official name of the organization, e.g. the registered company name.</para>
    /// labels<para>legalName</para></remarks>
    /// <seealso href="http://schema.org/legalName">http://schema.org/legalName</seealso>
    let legalName = Prefixed_Name(schema1, "legalName") |> PrefixedName
    /// <summary>
    ///   <para>schema1:leiCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An organization identifier that uniquely identifies a legal entity as defined in ISO 17442.</para>
    /// labels<para>leiCode</para></remarks>
    /// <seealso href="http://schema.org/leiCode">http://schema.org/leiCode</seealso>
    let leiCode = Prefixed_Name(schema1, "leiCode") |> PrefixedName
    /// <summary>
    ///   <para>schema1:lender</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of participant. The person that lends the object being borrowed.</para>
    /// labels<para>lender</para></remarks>
    /// <seealso href="http://schema.org/lender">http://schema.org/lender</seealso>
    let lender = Prefixed_Name(schema1, "lender") |> PrefixedName
    /// <summary>
    ///   <para>schema1:lesser</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This ordering relation for qualitative values indicates that the subject is lesser than the object.</para>
    /// labels<para>lesser</para></remarks>
    /// <seealso href="http://schema.org/lesser">http://schema.org/lesser</seealso>
    let lesser = Prefixed_Name(schema1, "lesser") |> PrefixedName
    /// <summary>
    ///   <para>schema1:lesserOrEqual</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This ordering relation for qualitative values indicates that the subject is lesser than or equal to the object.</para>
    /// labels<para>lesserOrEqual</para></remarks>
    /// <seealso href="http://schema.org/lesserOrEqual">http://schema.org/lesserOrEqual</seealso>
    let lesserOrEqual = Prefixed_Name(schema1, "lesserOrEqual") |> PrefixedName
    /// <summary>
    ///   <para>schema1:line</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A line is a point-to-point path consisting of two or more points. A line is expressed as a series of two or more point objects separated by space.</para>
    /// labels<para>line</para></remarks>
    /// <seealso href="http://schema.org/line">http://schema.org/line</seealso>
    let line = Prefixed_Name(schema1, "line") |> PrefixedName
    /// <summary>
    ///   <para>schema1:liveBlogUpdate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An update to the LiveBlog.</para>
    /// labels<para>liveBlogUpdate</para></remarks>
    /// <seealso href="http://schema.org/liveBlogUpdate">http://schema.org/liveBlogUpdate</seealso>
    let liveBlogUpdate = Prefixed_Name(schema1, "liveBlogUpdate") |> PrefixedName

    /// <summary>
    ///   <para>schema1:representativeOfPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates whether this image is representative of the content of the page.</para>
    /// labels<para>representativeOfPage</para></remarks>
    /// <seealso href="http://schema.org/representativeOfPage">http://schema.org/representativeOfPage</seealso>
    let representativeOfPage =
        Prefixed_Name(schema1, "representativeOfPage") |> PrefixedName

    /// <summary>
    ///   <para>schema1:requiredCollateral</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Assets required to secure loan or credit repayments. It may take form of third party pledge, goods, financial instruments (cash, securities, etc.)</para>
    /// labels<para>requiredCollateral</para></remarks>
    /// <seealso href="http://schema.org/requiredCollateral">http://schema.org/requiredCollateral</seealso>
    let requiredCollateral =
        Prefixed_Name(schema1, "requiredCollateral") |> PrefixedName

    /// <summary>
    ///   <para>schema1:requiredGender</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Audiences defined by a person's gender.</para>
    /// labels<para>requiredGender</para></remarks>
    /// <seealso href="http://schema.org/requiredGender">http://schema.org/requiredGender</seealso>
    let requiredGender = Prefixed_Name(schema1, "requiredGender") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Thing</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The most generic type of item.</para>
    /// labels<para>Thing</para></remarks>
    /// <seealso href="http://schema.org/Thing">http://schema.org/Thing</seealso>
    let Thing = Prefixed_Name(schema1, "Thing") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Intangible</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A utility class that serves as the umbrella for a number of 'intangible' things such as quantities, structured values, etc.</para>
    /// labels<para>Intangible</para></remarks>
    /// <seealso href="http://schema.org/Intangible">http://schema.org/Intangible</seealso>
    let Intangible = Prefixed_Name(schema1, "Intangible") |> PrefixedName
    /// <summary>
    ///   <para>schema1:CheckOutAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of an agent communicating (service provider, social media, etc) their departure of a previously reserved service (e.g. flight check in) or place (e.g. hotel).&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/CheckInAction"&gt;CheckInAction&lt;/a&gt;: The antonym of CheckOutAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/DepartAction"&gt;DepartAction&lt;/a&gt;: Unlike DepartAction, CheckOutAction implies that the agent is informing/confirming the end of a previously reserved service.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/CancelAction"&gt;CancelAction&lt;/a&gt;: Unlike CancelAction, CheckOutAction implies that the agent is informing/confirming the end of a previously reserved service.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>CheckOutAction</para></remarks>
    /// <seealso href="http://schema.org/CheckOutAction">http://schema.org/CheckOutAction</seealso>
    let CheckOutAction = Prefixed_Name(schema1, "CheckOutAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:SubscribeAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of forming a personal connection with someone/something (object) unidirectionally/asymmetrically to get updates pushed to.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/FollowAction"&gt;FollowAction&lt;/a&gt;: Unlike FollowAction, SubscribeAction implies that the subscriber acts as a passive agent being constantly/actively pushed for updates.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/RegisterAction"&gt;RegisterAction&lt;/a&gt;: Unlike RegisterAction, SubscribeAction implies that the agent is interested in continuing receiving updates from the object.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/JoinAction"&gt;JoinAction&lt;/a&gt;: Unlike JoinAction, SubscribeAction implies that the agent is interested in continuing receiving updates from the object.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>SubscribeAction</para></remarks>
    /// <seealso href="http://schema.org/SubscribeAction">http://schema.org/SubscribeAction</seealso>
    let SubscribeAction = Prefixed_Name(schema1, "SubscribeAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:SubwayStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A subway station.</para>
    /// labels<para>SubwayStation</para></remarks>
    /// <seealso href="http://schema.org/SubwayStation">http://schema.org/SubwayStation</seealso>
    let SubwayStation = Prefixed_Name(schema1, "SubwayStation") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Sunday</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:DayOfWeek</para>
    ///   <para>The day of the week between Saturday and Monday.</para>
    /// labels<para>Sunday</para></remarks>
    /// <seealso href="http://schema.org/Sunday">http://schema.org/Sunday</seealso>
    let Sunday = Prefixed_Name(schema1, "Sunday") |> PrefixedName

    /// <summary>
    ///   <para>schema1:alternativeHeadline</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A secondary title of the CreativeWork.</para>
    /// labels<para>alternativeHeadline</para></remarks>
    /// <seealso href="http://schema.org/alternativeHeadline">http://schema.org/alternativeHeadline</seealso>
    let alternativeHeadline =
        Prefixed_Name(schema1, "alternativeHeadline") |> PrefixedName

    /// <summary>
    ///   <para>schema1:alumni</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Alumni of an organization.</para>
    /// labels<para>alumni</para></remarks>
    /// <seealso href="http://schema.org/alumni">http://schema.org/alumni</seealso>
    let alumni = Prefixed_Name(schema1, "alumni") |> PrefixedName
    /// <summary>
    ///   <para>schema1:amount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The amount of money.</para>
    /// labels<para>amount</para></remarks>
    /// <seealso href="http://schema.org/amount">http://schema.org/amount</seealso>
    let amount = Prefixed_Name(schema1, "amount") |> PrefixedName
    /// <summary>
    ///   <para>schema1:isBasedOnUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A resource that was used in the creation of this resource. This term can be repeated for multiple sources. For example, http://example.com/great-multiplication-intro.html.</para>
    /// labels<para>isBasedOnUrl</para></remarks>
    /// <seealso href="http://schema.org/isBasedOnUrl">http://schema.org/isBasedOnUrl</seealso>
    let isBasedOnUrl = Prefixed_Name(schema1, "isBasedOnUrl") |> PrefixedName
    /// <summary>
    ///   <para>schema1:isConsumableFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A pointer to another product (or multiple products) for which this product is a consumable.</para>
    /// labels<para>isConsumableFor</para></remarks>
    /// <seealso href="http://schema.org/isConsumableFor">http://schema.org/isConsumableFor</seealso>
    let isConsumableFor = Prefixed_Name(schema1, "isConsumableFor") |> PrefixedName

    /// <summary>
    ///   <para>schema1:processorRequirements</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Processor architecture required to run the application (e.g. IA64).</para>
    /// labels<para>processorRequirements</para></remarks>
    /// <seealso href="http://schema.org/processorRequirements">http://schema.org/processorRequirements</seealso>
    let processorRequirements =
        Prefixed_Name(schema1, "processorRequirements") |> PrefixedName

    /// <summary>
    ///   <para>schema1:producer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The person or organization who produced the work (e.g. music album, movie, tv/radio series etc.).</para>
    /// labels<para>producer</para></remarks>
    /// <seealso href="http://schema.org/producer">http://schema.org/producer</seealso>
    let producer = Prefixed_Name(schema1, "producer") |> PrefixedName
    /// <summary>
    ///   <para>schema1:productSupported</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The product or service this support contact point is related to (such as product support for a particular product line). This can be a specific product or product line (e.g. "iPhone") or a general category of products or services (e.g. "smartphones").</para>
    /// labels<para>productSupported</para></remarks>
    /// <seealso href="http://schema.org/productSupported">http://schema.org/productSupported</seealso>
    let productSupported = Prefixed_Name(schema1, "productSupported") |> PrefixedName
    /// <summary>
    ///   <para>schema1:volumeNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Identifies the volume of publication or multi-part work; for example, "iii" or "2".</para>
    /// labels<para>volumeNumber</para></remarks>
    /// <seealso href="http://schema.org/volumeNumber">http://schema.org/volumeNumber</seealso>
    let volumeNumber = Prefixed_Name(schema1, "volumeNumber") |> PrefixedName
    /// <summary>
    ///   <para>schema1:warranty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The warranty promise(s) included in the offer.</para>
    /// labels<para>warranty</para></remarks>
    /// <seealso href="http://schema.org/warranty">http://schema.org/warranty</seealso>
    let warranty = Prefixed_Name(schema1, "warranty") |> PrefixedName

    /// <summary>
    ///   <para>schema1:ActionAccessSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A set of requirements that a must be fulfilled in order to perform an Action.</para>
    /// labels<para>ActionAccessSpecification</para></remarks>
    /// <seealso href="http://schema.org/ActionAccessSpecification">http://schema.org/ActionAccessSpecification</seealso>
    let ActionAccessSpecification =
        Prefixed_Name(schema1, "ActionAccessSpecification") |> PrefixedName

    /// <summary>
    ///   <para>schema1:Enumeration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Lists or enumerations—for example, a list of cuisines or music genres, etc.</para>
    /// labels<para>Enumeration</para></remarks>
    /// <seealso href="http://schema.org/Enumeration">http://schema.org/Enumeration</seealso>
    let Enumeration = Prefixed_Name(schema1, "Enumeration") |> PrefixedName

    /// <summary>
    ///   <para>schema1:NutritionInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Nutritional information about the recipe.</para>
    /// labels<para>NutritionInformation</para></remarks>
    /// <seealso href="http://schema.org/NutritionInformation">http://schema.org/NutritionInformation</seealso>
    let NutritionInformation =
        Prefixed_Name(schema1, "NutritionInformation") |> PrefixedName

    /// <summary>
    ///   <para>schema1:OceanBodyOfWater</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An ocean (for example, the Pacific).</para>
    /// labels<para>OceanBodyOfWater</para></remarks>
    /// <seealso href="http://schema.org/OceanBodyOfWater">http://schema.org/OceanBodyOfWater</seealso>
    let OceanBodyOfWater = Prefixed_Name(schema1, "OceanBodyOfWater") |> PrefixedName
    /// <summary>
    ///   <para>schema1:OfferCatalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An OfferCatalog is an ItemList that contains related Offers and/or further OfferCatalogs that are offeredBy the same provider.</para>
    /// labels<para>OfferCatalog</para></remarks>
    /// <seealso href="http://schema.org/OfferCatalog">http://schema.org/OfferCatalog</seealso>
    let OfferCatalog = Prefixed_Name(schema1, "OfferCatalog") |> PrefixedName
    /// <summary>
    ///   <para>schema1:OnDemandEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A publication event e.g. catch-up TV or radio podcast, during which a program is available on-demand.</para>
    /// labels<para>OnDemandEvent</para></remarks>
    /// <seealso href="http://schema.org/OnDemandEvent">http://schema.org/OnDemandEvent</seealso>
    let OnDemandEvent = Prefixed_Name(schema1, "OnDemandEvent") |> PrefixedName
    /// <summary>
    ///   <para>schema1:OnSitePickup</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:DeliveryMethod</para>
    ///   <para>A DeliveryMethod in which an item is collected on site, e.g. in a store or at a box office.</para>
    /// labels<para>OnSitePickup</para></remarks>
    /// <seealso href="http://schema.org/OnSitePickup">http://schema.org/OnSitePickup</seealso>
    let OnSitePickup = Prefixed_Name(schema1, "OnSitePickup") |> PrefixedName
    /// <summary>
    ///   <para>schema1:OnlineOnly</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:ItemAvailability</para>
    ///   <para>Indicates that the item is available only online.</para>
    /// labels<para>OnlineOnly</para></remarks>
    /// <seealso href="http://schema.org/OnlineOnly">http://schema.org/OnlineOnly</seealso>
    let OnlineOnly = Prefixed_Name(schema1, "OnlineOnly") |> PrefixedName
    /// <summary>
    ///   <para>schema1:OrderStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Enumerated status values for Order.</para>
    /// labels<para>OrderStatus</para></remarks>
    /// <seealso href="http://schema.org/OrderStatus">http://schema.org/OrderStatus</seealso>
    let OrderStatus = Prefixed_Name(schema1, "OrderStatus") |> PrefixedName
    /// <summary>
    ///   <para>schema1:OrderDelivered</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:OrderStatus</para>
    ///   <para>OrderStatus representing successful delivery of an order.</para>
    /// labels<para>OrderDelivered</para></remarks>
    /// <seealso href="http://schema.org/OrderDelivered">http://schema.org/OrderDelivered</seealso>
    let OrderDelivered = Prefixed_Name(schema1, "OrderDelivered") |> PrefixedName

    /// <summary>
    ///   <para>schema1:OrderPickupAvailable</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:OrderStatus</para>
    ///   <para>OrderStatus representing availability of an order for pickup.</para>
    /// labels<para>OrderPickupAvailable</para></remarks>
    /// <seealso href="http://schema.org/OrderPickupAvailable">http://schema.org/OrderPickupAvailable</seealso>
    let OrderPickupAvailable =
        Prefixed_Name(schema1, "OrderPickupAvailable") |> PrefixedName

    /// <summary>
    ///   <para>schema1:SuspendAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of momentarily pausing a device or application (e.g. pause music playback or pause a timer).</para>
    /// labels<para>SuspendAction</para></remarks>
    /// <seealso href="http://schema.org/SuspendAction">http://schema.org/SuspendAction</seealso>
    let SuspendAction = Prefixed_Name(schema1, "SuspendAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Synagogue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A synagogue.</para>
    /// labels<para>Synagogue</para></remarks>
    /// <seealso href="http://schema.org/Synagogue">http://schema.org/Synagogue</seealso>
    let Synagogue = Prefixed_Name(schema1, "Synagogue") |> PrefixedName
    /// <summary>
    ///   <para>schema1:TVClip</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A short TV program or a segment/part of a TV program.</para>
    /// labels<para>TVClip</para></remarks>
    /// <seealso href="http://schema.org/TVClip">http://schema.org/TVClip</seealso>
    let TVClip = Prefixed_Name(schema1, "TVClip") |> PrefixedName
    /// <summary>
    ///   <para>schema1:TVEpisode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A TV episode which can be part of a series or season.</para>
    /// labels<para>TVEpisode</para></remarks>
    /// <seealso href="http://schema.org/TVEpisode">http://schema.org/TVEpisode</seealso>
    let TVEpisode = Prefixed_Name(schema1, "TVEpisode") |> PrefixedName
    /// <summary>
    ///   <para>schema1:TVSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>CreativeWorkSeries dedicated to TV broadcast and associated online delivery.</para>
    /// labels<para>TVSeries</para></remarks>
    /// <seealso href="http://schema.org/TVSeries">http://schema.org/TVSeries</seealso>
    let TVSeries = Prefixed_Name(schema1, "TVSeries") |> PrefixedName
    /// <summary>
    ///   <para>schema1:TakeAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of gaining ownership of an object from an origin. Reciprocal of GiveAction.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/GiveAction"&gt;GiveAction&lt;/a&gt;: The reciprocal of TakeAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ReceiveAction"&gt;ReceiveAction&lt;/a&gt;: Unlike ReceiveAction, TakeAction implies that ownership has been transfered.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>TakeAction</para></remarks>
    /// <seealso href="http://schema.org/TakeAction">http://schema.org/TakeAction</seealso>
    let TakeAction = Prefixed_Name(schema1, "TakeAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:TattooParlor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A tattoo parlor.</para>
    /// labels<para>TattooParlor</para></remarks>
    /// <seealso href="http://schema.org/TattooParlor">http://schema.org/TattooParlor</seealso>
    let TattooParlor = Prefixed_Name(schema1, "TattooParlor") |> PrefixedName
    /// <summary>
    ///   <para>schema1:TaxiReservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A reservation for a taxi.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use &lt;a class="localLink" href="http://schema.org/Offer"&gt;Offer&lt;/a&gt;.</para>
    /// labels<para>TaxiReservation</para></remarks>
    /// <seealso href="http://schema.org/TaxiReservation">http://schema.org/TaxiReservation</seealso>
    let TaxiReservation = Prefixed_Name(schema1, "TaxiReservation") |> PrefixedName
    /// <summary>
    ///   <para>schema1:TelevisionChannel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A unique instance of a television BroadcastService on a CableOrSatelliteService lineup.</para>
    /// labels<para>TelevisionChannel</para></remarks>
    /// <seealso href="http://schema.org/TelevisionChannel">http://schema.org/TelevisionChannel</seealso>
    let TelevisionChannel = Prefixed_Name(schema1, "TelevisionChannel") |> PrefixedName
    /// <summary>
    ///   <para>schema1:TelevisionStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A television station.</para>
    /// labels<para>TelevisionStation</para></remarks>
    /// <seealso href="http://schema.org/TelevisionStation">http://schema.org/TelevisionStation</seealso>
    let TelevisionStation = Prefixed_Name(schema1, "TelevisionStation") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Text</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:DataType</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Data type: Text.</para>
    /// labels<para>Text</para></remarks>
    /// <seealso href="http://schema.org/Text">http://schema.org/Text</seealso>
    let Text = Prefixed_Name(schema1, "Text") |> PrefixedName

    /// <summary>
    ///   <para>schema1:TextDigitalDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A file composed primarily of text.</para>
    /// labels<para>TextDigitalDocument</para></remarks>
    /// <seealso href="http://schema.org/TextDigitalDocument">http://schema.org/TextDigitalDocument</seealso>
    let TextDigitalDocument =
        Prefixed_Name(schema1, "TextDigitalDocument") |> PrefixedName

    /// <summary>
    ///   <para>schema1:TheaterEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Event type: Theater performance.</para>
    /// labels<para>TheaterEvent</para></remarks>
    /// <seealso href="http://schema.org/TheaterEvent">http://schema.org/TheaterEvent</seealso>
    let TheaterEvent = Prefixed_Name(schema1, "TheaterEvent") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Thursday</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:DayOfWeek</para>
    ///   <para>The day of the week between Wednesday and Friday.</para>
    /// labels<para>Thursday</para></remarks>
    /// <seealso href="http://schema.org/Thursday">http://schema.org/Thursday</seealso>
    let Thursday = Prefixed_Name(schema1, "Thursday") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Ticket</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Used to describe a ticket to an event, a flight, a bus ride, etc.</para>
    /// labels<para>Ticket</para></remarks>
    /// <seealso href="http://schema.org/Ticket">http://schema.org/Ticket</seealso>
    let Ticket = Prefixed_Name(schema1, "Ticket") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Time</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:DataType</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A point in time recurring on multiple days in the form hh:mm:ss[Z|(+|-)hh:mm] (see &lt;a href="http://www.w3.org/TR/xmlschema-2/#time"&gt;XML schema for details&lt;/a&gt;).</para>
    /// labels<para>Time</para></remarks>
    /// <seealso href="http://schema.org/Time">http://schema.org/Time</seealso>
    let Time = Prefixed_Name(schema1, "Time") |> PrefixedName
    /// <summary>
    ///   <para>schema1:TipAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of giving money voluntarily to a beneficiary in recognition of services rendered.</para>
    /// labels<para>TipAction</para></remarks>
    /// <seealso href="http://schema.org/TipAction">http://schema.org/TipAction</seealso>
    let TipAction = Prefixed_Name(schema1, "TipAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:TireShop</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A tire shop.</para>
    /// labels<para>TireShop</para></remarks>
    /// <seealso href="http://schema.org/TireShop">http://schema.org/TireShop</seealso>
    let TireShop = Prefixed_Name(schema1, "TireShop") |> PrefixedName
    /// <summary>
    ///   <para>schema1:TouristAttraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A tourist attraction.  In principle any Thing can be a &lt;a class="localLink" href="http://schema.org/TouristAttraction"&gt;TouristAttraction&lt;/a&gt;, from a &lt;a class="localLink" href="http://schema.org/Mountain"&gt;Mountain&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/LandmarksOrHistoricalBuildings"&gt;LandmarksOrHistoricalBuildings&lt;/a&gt; to a &lt;a class="localLink" href="http://schema.org/LocalBusiness"&gt;LocalBusiness&lt;/a&gt;.  This Type can be used on its own to describe a general &lt;a class="localLink" href="http://schema.org/TouristAttraction"&gt;TouristAttraction&lt;/a&gt;, or be used as an &lt;a class="localLink" href="http://schema.org/additionalType"&gt;additionalType&lt;/a&gt; to add tourist attraction properties to any other type.  (See examples below)</para>
    /// labels<para>TouristAttraction</para></remarks>
    /// <seealso href="http://schema.org/TouristAttraction">http://schema.org/TouristAttraction</seealso>
    let TouristAttraction = Prefixed_Name(schema1, "TouristAttraction") |> PrefixedName

    /// <summary>
    ///   <para>schema1:TouristInformationCenter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A tourist information center.</para>
    /// labels<para>TouristInformationCenter</para></remarks>
    /// <seealso href="http://schema.org/TouristInformationCenter">http://schema.org/TouristInformationCenter</seealso>
    let TouristInformationCenter =
        Prefixed_Name(schema1, "TouristInformationCenter") |> PrefixedName

    /// <summary>
    ///   <para>schema1:TrackAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An agent tracks an object for updates.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/FollowAction"&gt;FollowAction&lt;/a&gt;: Unlike FollowAction, TrackAction refers to the interest on the location of innanimates objects.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/SubscribeAction"&gt;SubscribeAction&lt;/a&gt;: Unlike SubscribeAction, TrackAction refers to  the interest on the location of innanimate objects.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>TrackAction</para></remarks>
    /// <seealso href="http://schema.org/TrackAction">http://schema.org/TrackAction</seealso>
    let TrackAction = Prefixed_Name(schema1, "TrackAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:TrainReservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A reservation for train travel.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use &lt;a class="localLink" href="http://schema.org/Offer"&gt;Offer&lt;/a&gt;.</para>
    /// labels<para>TrainReservation</para></remarks>
    /// <seealso href="http://schema.org/TrainReservation">http://schema.org/TrainReservation</seealso>
    let TrainReservation = Prefixed_Name(schema1, "TrainReservation") |> PrefixedName
    /// <summary>
    ///   <para>schema1:TrainTrip</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A trip on a commercial train line.</para>
    /// labels<para>TrainTrip</para></remarks>
    /// <seealso href="http://schema.org/TrainTrip">http://schema.org/TrainTrip</seealso>
    let TrainTrip = Prefixed_Name(schema1, "TrainTrip") |> PrefixedName
    /// <summary>
    ///   <para>schema1:TransitMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:MapCategoryType</para>
    ///   <para>A transit map.</para>
    /// labels<para>TransitMap</para></remarks>
    /// <seealso href="http://schema.org/TransitMap">http://schema.org/TransitMap</seealso>
    let TransitMap = Prefixed_Name(schema1, "TransitMap") |> PrefixedName
    /// <summary>
    ///   <para>schema1:TravelAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A travel agency.</para>
    /// labels<para>TravelAgency</para></remarks>
    /// <seealso href="http://schema.org/TravelAgency">http://schema.org/TravelAgency</seealso>
    let TravelAgency = Prefixed_Name(schema1, "TravelAgency") |> PrefixedName
    /// <summary>
    ///   <para>schema1:True</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Boolean</para>
    ///   <para>The boolean value true.</para>
    /// labels<para>True</para></remarks>
    /// <seealso href="http://schema.org/True">http://schema.org/True</seealso>
    let True = Prefixed_Name(schema1, "True") |> PrefixedName

    /// <summary>
    ///   <para>schema1:TypeAndQuantityNode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A structured value indicating the quantity, unit of measurement, and business function of goods included in a bundle offer.</para>
    /// labels<para>TypeAndQuantityNode</para></remarks>
    /// <seealso href="http://schema.org/TypeAndQuantityNode">http://schema.org/TypeAndQuantityNode</seealso>
    let TypeAndQuantityNode =
        Prefixed_Name(schema1, "TypeAndQuantityNode") |> PrefixedName

    /// <summary>
    ///   <para>schema1:URL</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Data type: URL.</para>
    /// labels<para>URL</para></remarks>
    /// <seealso href="http://schema.org/URL">http://schema.org/URL</seealso>
    let URL = Prefixed_Name(schema1, "URL") |> PrefixedName
    /// <summary>
    ///   <para>schema1:UnRegisterAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of un-registering from a service.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/RegisterAction"&gt;RegisterAction&lt;/a&gt;: antonym of UnRegisterAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/LeaveAction"&gt;LeaveAction&lt;/a&gt;: Unlike LeaveAction, UnRegisterAction implies that you are unregistering from a service you werer previously registered, rather than leaving a team/group of people.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>UnRegisterAction</para></remarks>
    /// <seealso href="http://schema.org/UnRegisterAction">http://schema.org/UnRegisterAction</seealso>
    let UnRegisterAction = Prefixed_Name(schema1, "UnRegisterAction") |> PrefixedName

    /// <summary>
    ///   <para>schema1:UnitPriceSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The price asked for a given offer by the respective organization or person.</para>
    /// labels<para>UnitPriceSpecification</para></remarks>
    /// <seealso href="http://schema.org/UnitPriceSpecification">http://schema.org/UnitPriceSpecification</seealso>
    let UnitPriceSpecification =
        Prefixed_Name(schema1, "UnitPriceSpecification") |> PrefixedName

    /// <summary>
    ///   <para>schema1:UsedCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:OfferItemCondition</para>
    ///   <para>Indicates that the item is used.</para>
    /// labels<para>UsedCondition</para></remarks>
    /// <seealso href="http://schema.org/UsedCondition">http://schema.org/UsedCondition</seealso>
    let UsedCondition = Prefixed_Name(schema1, "UsedCondition") |> PrefixedName
    /// <summary>
    ///   <para>schema1:UserBlocks</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.</para>
    /// labels<para>UserBlocks</para></remarks>
    /// <seealso href="http://schema.org/UserBlocks">http://schema.org/UserBlocks</seealso>
    let UserBlocks = Prefixed_Name(schema1, "UserBlocks") |> PrefixedName
    /// <summary>
    ///   <para>schema1:UserInteraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.</para>
    /// labels<para>UserInteraction</para></remarks>
    /// <seealso href="http://schema.org/UserInteraction">http://schema.org/UserInteraction</seealso>
    let UserInteraction = Prefixed_Name(schema1, "UserInteraction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:UserCheckins</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.</para>
    /// labels<para>UserCheckins</para></remarks>
    /// <seealso href="http://schema.org/UserCheckins">http://schema.org/UserCheckins</seealso>
    let UserCheckins = Prefixed_Name(schema1, "UserCheckins") |> PrefixedName
    /// <summary>
    ///   <para>schema1:UserComments</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.</para>
    /// labels<para>UserComments</para></remarks>
    /// <seealso href="http://schema.org/UserComments">http://schema.org/UserComments</seealso>
    let UserComments = Prefixed_Name(schema1, "UserComments") |> PrefixedName
    /// <summary>
    ///   <para>schema1:UserDownloads</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.</para>
    /// labels<para>UserDownloads</para></remarks>
    /// <seealso href="http://schema.org/UserDownloads">http://schema.org/UserDownloads</seealso>
    let UserDownloads = Prefixed_Name(schema1, "UserDownloads") |> PrefixedName
    /// <summary>
    ///   <para>schema1:UserLikes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.</para>
    /// labels<para>UserLikes</para></remarks>
    /// <seealso href="http://schema.org/UserLikes">http://schema.org/UserLikes</seealso>
    let UserLikes = Prefixed_Name(schema1, "UserLikes") |> PrefixedName
    /// <summary>
    ///   <para>schema1:UserPlays</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.</para>
    /// labels<para>UserPlays</para></remarks>
    /// <seealso href="http://schema.org/UserPlays">http://schema.org/UserPlays</seealso>
    let UserPlays = Prefixed_Name(schema1, "UserPlays") |> PrefixedName
    /// <summary>
    ///   <para>schema1:UserPlusOnes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.</para>
    /// labels<para>UserPlusOnes</para></remarks>
    /// <seealso href="http://schema.org/UserPlusOnes">http://schema.org/UserPlusOnes</seealso>
    let UserPlusOnes = Prefixed_Name(schema1, "UserPlusOnes") |> PrefixedName
    /// <summary>
    ///   <para>schema1:UserTweets</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.</para>
    /// labels<para>UserTweets</para></remarks>
    /// <seealso href="http://schema.org/UserTweets">http://schema.org/UserTweets</seealso>
    let UserTweets = Prefixed_Name(schema1, "UserTweets") |> PrefixedName
    /// <summary>
    ///   <para>schema1:VeganDiet</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:RestrictedDiet</para>
    ///   <para>A diet exclusive of all animal products.</para>
    /// labels<para>VeganDiet</para></remarks>
    /// <seealso href="http://schema.org/VeganDiet">http://schema.org/VeganDiet</seealso>
    let VeganDiet = Prefixed_Name(schema1, "VeganDiet") |> PrefixedName
    /// <summary>
    ///   <para>schema1:VegetarianDiet</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:RestrictedDiet</para>
    ///   <para>A diet exclusive of animal meat.</para>
    /// labels<para>VegetarianDiet</para></remarks>
    /// <seealso href="http://schema.org/VegetarianDiet">http://schema.org/VegetarianDiet</seealso>
    let VegetarianDiet = Prefixed_Name(schema1, "VegetarianDiet") |> PrefixedName
    /// <summary>
    ///   <para>schema1:VenueMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:MapCategoryType</para>
    ///   <para>A venue map (e.g. for malls, auditoriums, museums, etc.).</para>
    /// labels<para>VenueMap</para></remarks>
    /// <seealso href="http://schema.org/VenueMap">http://schema.org/VenueMap</seealso>
    let VenueMap = Prefixed_Name(schema1, "VenueMap") |> PrefixedName
    /// <summary>
    ///   <para>schema1:eventStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An eventStatus of an event represents its status; particularly useful when an event is cancelled or rescheduled.</para>
    /// labels<para>eventStatus</para></remarks>
    /// <seealso href="http://schema.org/eventStatus">http://schema.org/eventStatus</seealso>
    let eventStatus = Prefixed_Name(schema1, "eventStatus") |> PrefixedName
    /// <summary>
    ///   <para>schema1:events</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Upcoming or past events associated with this place or organization.</para>
    /// labels<para>events</para></remarks>
    /// <seealso href="http://schema.org/events">http://schema.org/events</seealso>
    let events = Prefixed_Name(schema1, "events") |> PrefixedName
    /// <summary>
    ///   <para>schema1:exampleOfWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A creative work that this work is an example/instance/realization/derivation of.</para>
    /// labels<para>exampleOfWork</para></remarks>
    /// <seealso href="http://schema.org/exampleOfWork">http://schema.org/exampleOfWork</seealso>
    let exampleOfWork = Prefixed_Name(schema1, "exampleOfWork") |> PrefixedName
    /// <summary>
    ///   <para>schema1:workExample</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Example/instance/realization/derivation of the concept of this creative work. eg. The paperback edition, first edition, or eBook.</para>
    /// labels<para>workExample</para></remarks>
    /// <seealso href="http://schema.org/workExample">http://schema.org/workExample</seealso>
    let workExample = Prefixed_Name(schema1, "workExample") |> PrefixedName
    /// <summary>
    ///   <para>schema1:exifData</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>exif data for this object.</para>
    /// labels<para>exifData</para></remarks>
    /// <seealso href="http://schema.org/exifData">http://schema.org/exifData</seealso>
    let exifData = Prefixed_Name(schema1, "exifData") |> PrefixedName
    /// <summary>
    ///   <para>schema1:musicArrangement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An arrangement derived from the composition.</para>
    /// labels<para>musicArrangement</para></remarks>
    /// <seealso href="http://schema.org/musicArrangement">http://schema.org/musicArrangement</seealso>
    let musicArrangement = Prefixed_Name(schema1, "musicArrangement") |> PrefixedName
    /// <summary>
    ///   <para>schema1:musicBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The composer of the soundtrack.</para>
    /// labels<para>musicBy</para></remarks>
    /// <seealso href="http://schema.org/musicBy">http://schema.org/musicBy</seealso>
    let musicBy = Prefixed_Name(schema1, "musicBy") |> PrefixedName

    /// <summary>
    ///   <para>schema1:musicCompositionForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The type of composition (e.g. overture, sonata, symphony, etc.).</para>
    /// labels<para>musicCompositionForm</para></remarks>
    /// <seealso href="http://schema.org/musicCompositionForm">http://schema.org/musicCompositionForm</seealso>
    let musicCompositionForm =
        Prefixed_Name(schema1, "musicCompositionForm") |> PrefixedName

    /// <summary>
    ///   <para>schema1:musicGroupMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A member of a music group&amp;#x2014;for example, John, Paul, George, or Ringo.</para>
    /// labels<para>musicGroupMember</para></remarks>
    /// <seealso href="http://schema.org/musicGroupMember">http://schema.org/musicGroupMember</seealso>
    let musicGroupMember = Prefixed_Name(schema1, "musicGroupMember") |> PrefixedName

    /// <summary>
    ///   <para>schema1:musicReleaseFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Format of this release (the type of recording media used, ie. compact disc, digital media, LP, etc.).</para>
    /// labels<para>musicReleaseFormat</para></remarks>
    /// <seealso href="http://schema.org/musicReleaseFormat">http://schema.org/musicReleaseFormat</seealso>
    let musicReleaseFormat =
        Prefixed_Name(schema1, "musicReleaseFormat") |> PrefixedName

    /// <summary>
    ///   <para>schema1:musicalKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The key, mode, or scale this composition uses.</para>
    /// labels<para>musicalKey</para></remarks>
    /// <seealso href="http://schema.org/musicalKey">http://schema.org/musicalKey</seealso>
    let musicalKey = Prefixed_Name(schema1, "musicalKey") |> PrefixedName
    /// <summary>
    ///   <para>schema1:startTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The startTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to start. For actions that span a period of time, when the action was performed. e.g. John wrote a book from &lt;em&gt;January&lt;/em&gt; to December. For media, including audio and video, it's the time offset of the start of a clip within a larger file.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.</para>
    /// labels<para>startTime</para></remarks>
    /// <seealso href="http://schema.org/startTime">http://schema.org/startTime</seealso>
    let startTime = Prefixed_Name(schema1, "startTime") |> PrefixedName
    /// <summary>
    ///   <para>schema1:steeringPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The position of the steering wheel or similar device (mostly for cars).</para>
    /// labels<para>steeringPosition</para></remarks>
    /// <seealso href="http://schema.org/steeringPosition">http://schema.org/steeringPosition</seealso>
    let steeringPosition = Prefixed_Name(schema1, "steeringPosition") |> PrefixedName
    /// <summary>
    ///   <para>schema1:stepValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The stepValue attribute indicates the granularity that is expected (and required) of the value in a PropertyValueSpecification.</para>
    /// labels<para>stepValue</para></remarks>
    /// <seealso href="http://schema.org/stepValue">http://schema.org/stepValue</seealso>
    let stepValue = Prefixed_Name(schema1, "stepValue") |> PrefixedName
    /// <summary>
    ///   <para>schema1:steps</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A single step item (as HowToStep, text, document, video, etc.) or a HowToSection (originally misnamed 'steps'; 'step' is preferred).</para>
    /// labels<para>steps</para></remarks>
    /// <seealso href="http://schema.org/steps">http://schema.org/steps</seealso>
    let steps = Prefixed_Name(schema1, "steps") |> PrefixedName

    /// <summary>
    ///   <para>schema1:storageRequirements</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Storage requirements (free space required).</para>
    /// labels<para>storageRequirements</para></remarks>
    /// <seealso href="http://schema.org/storageRequirements">http://schema.org/storageRequirements</seealso>
    let storageRequirements =
        Prefixed_Name(schema1, "storageRequirements") |> PrefixedName

    /// <summary>
    ///   <para>schema1:streetAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The street address. For example, 1600 Amphitheatre Pkwy.</para>
    /// labels<para>streetAddress</para></remarks>
    /// <seealso href="http://schema.org/streetAddress">http://schema.org/streetAddress</seealso>
    let streetAddress = Prefixed_Name(schema1, "streetAddress") |> PrefixedName
    /// <summary>
    ///   <para>schema1:subEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An Event that is part of this event. For example, a conference event includes many presentations, each of which is a subEvent of the conference.</para>
    /// labels<para>subEvent</para></remarks>
    /// <seealso href="http://schema.org/subEvent">http://schema.org/subEvent</seealso>
    let subEvent = Prefixed_Name(schema1, "subEvent") |> PrefixedName
    /// <summary>
    ///   <para>schema1:superEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An event that this event is a part of. For example, a collection of individual music performances might each have a music festival as their superEvent.</para>
    /// labels<para>superEvent</para></remarks>
    /// <seealso href="http://schema.org/superEvent">http://schema.org/superEvent</seealso>
    let superEvent = Prefixed_Name(schema1, "superEvent") |> PrefixedName
    /// <summary>
    ///   <para>schema1:subEvents</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Events that are a part of this event. For example, a conference event includes many presentations, each subEvents of the conference.</para>
    /// labels<para>subEvents</para></remarks>
    /// <seealso href="http://schema.org/subEvents">http://schema.org/subEvents</seealso>
    let subEvents = Prefixed_Name(schema1, "subEvents") |> PrefixedName
    /// <summary>
    ///   <para>schema1:subReservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The individual reservations included in the package. Typically a repeated property.</para>
    /// labels<para>subReservation</para></remarks>
    /// <seealso href="http://schema.org/subReservation">http://schema.org/subReservation</seealso>
    let subReservation = Prefixed_Name(schema1, "subReservation") |> PrefixedName
    /// <summary>
    ///   <para>schema1:MusicStore</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A music store.</para>
    /// labels<para>MusicStore</para></remarks>
    /// <seealso href="http://schema.org/MusicStore">http://schema.org/MusicStore</seealso>
    let MusicStore = Prefixed_Name(schema1, "MusicStore") |> PrefixedName
    /// <summary>
    ///   <para>schema1:SportsClub</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A sports club.</para>
    /// labels<para>SportsClub</para></remarks>
    /// <seealso href="http://schema.org/SportsClub">http://schema.org/SportsClub</seealso>
    let SportsClub = Prefixed_Name(schema1, "SportsClub") |> PrefixedName

    /// <summary>
    ///   <para>schema1:SportsOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Represents the collection of all sports organizations, including sports teams, governing bodies, and sports associations.</para>
    /// labels<para>SportsOrganization</para></remarks>
    /// <seealso href="http://schema.org/SportsOrganization">http://schema.org/SportsOrganization</seealso>
    let SportsOrganization =
        Prefixed_Name(schema1, "SportsOrganization") |> PrefixedName

    /// <summary>
    ///   <para>schema1:SpreadsheetDigitalDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A spreadsheet file.</para>
    /// labels<para>SpreadsheetDigitalDocument</para></remarks>
    /// <seealso href="http://schema.org/SpreadsheetDigitalDocument">http://schema.org/SpreadsheetDigitalDocument</seealso>
    let SpreadsheetDigitalDocument =
        Prefixed_Name(schema1, "SpreadsheetDigitalDocument") |> PrefixedName

    /// <summary>
    ///   <para>schema1:State</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A state or province of a country.</para>
    /// labels<para>State</para></remarks>
    /// <seealso href="http://schema.org/State">http://schema.org/State</seealso>
    let State = Prefixed_Name(schema1, "State") |> PrefixedName
    /// <summary>
    ///   <para>schema1:StudioAlbum</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:MusicAlbumProductionType</para>
    ///   <para>StudioAlbum.</para>
    /// labels<para>StudioAlbum</para></remarks>
    /// <seealso href="http://schema.org/StudioAlbum">http://schema.org/StudioAlbum</seealso>
    let StudioAlbum = Prefixed_Name(schema1, "StudioAlbum") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Suite</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A suite in a hotel or other public accommodation, denotes a class of luxury accommodations, the key feature of which is multiple rooms (Source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Suite_(hotel)"&gt;http://en.wikipedia.org/wiki/Suite_(hotel)&lt;/a&gt;).
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.</para>
    /// labels<para>Suite</para></remarks>
    /// <seealso href="http://schema.org/Suite">http://schema.org/Suite</seealso>
    let Suite = Prefixed_Name(schema1, "Suite") |> PrefixedName
    /// <summary>
    ///   <para>schema1:albums</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A collection of music albums.</para>
    /// labels<para>albums</para></remarks>
    /// <seealso href="http://schema.org/albums">http://schema.org/albums</seealso>
    let albums = Prefixed_Name(schema1, "albums") |> PrefixedName
    /// <summary>
    ///   <para>schema1:dataFeedElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An item within in a data feed. Data feeds may have many elements.</para>
    /// labels<para>dataFeedElement</para></remarks>
    /// <seealso href="http://schema.org/dataFeedElement">http://schema.org/dataFeedElement</seealso>
    let dataFeedElement = Prefixed_Name(schema1, "dataFeedElement") |> PrefixedName
    /// <summary>
    ///   <para>schema1:dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A dataset contained in this catalog.</para>
    /// labels<para>dataset</para></remarks>
    /// <seealso href="http://schema.org/dataset">http://schema.org/dataset</seealso>
    let dataset = Prefixed_Name(schema1, "dataset") |> PrefixedName

    /// <summary>
    ///   <para>schema1:isAccessoryOrSparePartFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A pointer to another product (or multiple products) for which this product is an accessory or spare part.</para>
    /// labels<para>isAccessoryOrSparePartFor</para></remarks>
    /// <seealso href="http://schema.org/isAccessoryOrSparePartFor">http://schema.org/isAccessoryOrSparePartFor</seealso>
    let isAccessoryOrSparePartFor =
        Prefixed_Name(schema1, "isAccessoryOrSparePartFor") |> PrefixedName

    /// <summary>
    ///   <para>schema1:isBasedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A resource from which this work is derived or from which it is a modification or adaption.</para>
    /// labels<para>isBasedOn</para></remarks>
    /// <seealso href="http://schema.org/isBasedOn">http://schema.org/isBasedOn</seealso>
    let isBasedOn = Prefixed_Name(schema1, "isBasedOn") |> PrefixedName
    /// <summary>
    ///   <para>schema1:printColumn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of the column in which the NewsArticle appears in the print edition.</para>
    /// labels<para>printColumn</para></remarks>
    /// <seealso href="http://schema.org/printColumn">http://schema.org/printColumn</seealso>
    let printColumn = Prefixed_Name(schema1, "printColumn") |> PrefixedName
    /// <summary>
    ///   <para>schema1:printEdition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The edition of the print product in which the NewsArticle appears.</para>
    /// labels<para>printEdition</para></remarks>
    /// <seealso href="http://schema.org/printEdition">http://schema.org/printEdition</seealso>
    let printEdition = Prefixed_Name(schema1, "printEdition") |> PrefixedName
    /// <summary>
    ///   <para>schema1:printPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>If this NewsArticle appears in print, this field indicates the name of the page on which the article is found. Please note that this field is intended for the exact page name (e.g. A5, B18).</para>
    /// labels<para>printPage</para></remarks>
    /// <seealso href="http://schema.org/printPage">http://schema.org/printPage</seealso>
    let printPage = Prefixed_Name(schema1, "printPage") |> PrefixedName
    /// <summary>
    ///   <para>schema1:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The value of the quantitative value or property value node.&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;For &lt;a class="localLink" href="http://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/MonetaryAmount"&gt;MonetaryAmount&lt;/a&gt;, the recommended type for values is 'Number'.&lt;/li&gt;
    /// &lt;li&gt;For &lt;a class="localLink" href="http://schema.org/PropertyValue"&gt;PropertyValue&lt;/a&gt;, it can be 'Text;', 'Number', 'Boolean', or 'StructuredValue'.&lt;/li&gt;
    /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
    /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>value</para></remarks>
    /// <seealso href="http://schema.org/value">http://schema.org/value</seealso>
    let value = Prefixed_Name(schema1, "value") |> PrefixedName

    /// <summary>
    ///   <para>schema1:valueAddedTaxIncluded</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies whether the applicable value-added tax (VAT) is included in the price specification or not.</para>
    /// labels<para>valueAddedTaxIncluded</para></remarks>
    /// <seealso href="http://schema.org/valueAddedTaxIncluded">http://schema.org/valueAddedTaxIncluded</seealso>
    let valueAddedTaxIncluded =
        Prefixed_Name(schema1, "valueAddedTaxIncluded") |> PrefixedName

    /// <summary>
    ///   <para>schema1:AgreeAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of expressing a consistency of opinion with the object. An agent agrees to/about an object (a proposition, topic or theme) with participants.</para>
    /// labels<para>AgreeAction</para></remarks>
    /// <seealso href="http://schema.org/AgreeAction">http://schema.org/AgreeAction</seealso>
    let AgreeAction = Prefixed_Name(schema1, "AgreeAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An organization such as a school, NGO, corporation, club, etc.</para>
    /// labels<para>Organization</para></remarks>
    /// <seealso href="http://schema.org/Organization">http://schema.org/Organization</seealso>
    let Organization = Prefixed_Name(schema1, "Organization") |> PrefixedName
    /// <summary>
    ///   <para>schema1:CivicStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A public structure, such as a town hall or concert hall.</para>
    /// labels<para>CivicStructure</para></remarks>
    /// <seealso href="http://schema.org/CivicStructure">http://schema.org/CivicStructure</seealso>
    let CivicStructure = Prefixed_Name(schema1, "CivicStructure") |> PrefixedName
    /// <summary>
    ///   <para>schema1:AlbumRelease</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:MusicAlbumReleaseType</para>
    ///   <para>AlbumRelease.</para>
    /// labels<para>AlbumRelease</para></remarks>
    /// <seealso href="http://schema.org/AlbumRelease">http://schema.org/AlbumRelease</seealso>
    let AlbumRelease = Prefixed_Name(schema1, "AlbumRelease") |> PrefixedName
    /// <summary>
    ///   <para>schema1:AlignmentObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An intangible item that describes an alignment between a learning resource and a node in an educational framework.</para>
    /// labels<para>AlignmentObject</para></remarks>
    /// <seealso href="http://schema.org/AlignmentObject">http://schema.org/AlignmentObject</seealso>
    let AlignmentObject = Prefixed_Name(schema1, "AlignmentObject") |> PrefixedName

    /// <summary>
    ///   <para>schema1:AllWheelDriveConfiguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:DriveWheelConfigurationValue</para>
    ///   <para>All-wheel Drive is a transmission layout where the engine drives all four wheels.</para>
    /// labels<para>AllWheelDriveConfiguration</para></remarks>
    /// <seealso href="http://schema.org/AllWheelDriveConfiguration">http://schema.org/AllWheelDriveConfiguration</seealso>
    let AllWheelDriveConfiguration =
        Prefixed_Name(schema1, "AllWheelDriveConfiguration") |> PrefixedName

    /// <summary>
    ///   <para>schema1:Continent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>One of the continents (for example, Europe or Africa).</para>
    /// labels<para>Continent</para></remarks>
    /// <seealso href="http://schema.org/Continent">http://schema.org/Continent</seealso>
    let Continent = Prefixed_Name(schema1, "Continent") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Hostel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A hostel - cheap accommodation, often in shared dormitories.
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.</para>
    /// labels<para>Hostel</para></remarks>
    /// <seealso href="http://schema.org/Hostel">http://schema.org/Hostel</seealso>
    let Hostel = Prefixed_Name(schema1, "Hostel") |> PrefixedName
    /// <summary>
    ///   <para>schema1:PostOffice</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A post office.</para>
    /// labels<para>PostOffice</para></remarks>
    /// <seealso href="http://schema.org/PostOffice">http://schema.org/PostOffice</seealso>
    let PostOffice = Prefixed_Name(schema1, "PostOffice") |> PrefixedName
    /// <summary>
    ///   <para>schema1:PrependAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of inserting at the beginning if an ordered collection.</para>
    /// labels<para>PrependAction</para></remarks>
    /// <seealso href="http://schema.org/PrependAction">http://schema.org/PrependAction</seealso>
    let PrependAction = Prefixed_Name(schema1, "PrependAction") |> PrefixedName

    /// <summary>
    ///   <para>schema1:PresentationDigitalDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A file containing slides or used for a presentation.</para>
    /// labels<para>PresentationDigitalDocument</para></remarks>
    /// <seealso href="http://schema.org/PresentationDigitalDocument">http://schema.org/PresentationDigitalDocument</seealso>
    let PresentationDigitalDocument =
        Prefixed_Name(schema1, "PresentationDigitalDocument") |> PrefixedName

    /// <summary>
    ///   <para>schema1:availableChannel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A means of accessing the service (e.g. a phone bank, a web site, a location, etc.).</para>
    /// labels<para>availableChannel</para></remarks>
    /// <seealso href="http://schema.org/availableChannel">http://schema.org/availableChannel</seealso>
    let availableChannel = Prefixed_Name(schema1, "availableChannel") |> PrefixedName

    /// <summary>
    ///   <para>schema1:availableDeliveryMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The delivery method(s) available for this offer.</para>
    /// labels<para>availableDeliveryMethod</para></remarks>
    /// <seealso href="http://schema.org/availableDeliveryMethod">http://schema.org/availableDeliveryMethod</seealso>
    let availableDeliveryMethod =
        Prefixed_Name(schema1, "availableDeliveryMethod") |> PrefixedName

    /// <summary>
    ///   <para>schema1:availableLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A language someone may use with or at the item, service or place. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/inLanguage"&gt;inLanguage&lt;/a&gt;</para>
    /// labels<para>availableLanguage</para></remarks>
    /// <seealso href="http://schema.org/availableLanguage">http://schema.org/availableLanguage</seealso>
    let availableLanguage = Prefixed_Name(schema1, "availableLanguage") |> PrefixedName
    /// <summary>
    ///   <para>schema1:award</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An award won by or for this item.</para>
    /// labels<para>award</para></remarks>
    /// <seealso href="http://schema.org/award">http://schema.org/award</seealso>
    let award = Prefixed_Name(schema1, "award") |> PrefixedName
    /// <summary>
    ///   <para>schema1:awayTeam</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The away team in a sports event.</para>
    /// labels<para>awayTeam</para></remarks>
    /// <seealso href="http://schema.org/awayTeam">http://schema.org/awayTeam</seealso>
    let awayTeam = Prefixed_Name(schema1, "awayTeam") |> PrefixedName
    /// <summary>
    ///   <para>schema1:competitor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A competitor in a sports event.</para>
    /// labels<para>competitor</para></remarks>
    /// <seealso href="http://schema.org/competitor">http://schema.org/competitor</seealso>
    let competitor = Prefixed_Name(schema1, "competitor") |> PrefixedName
    /// <summary>
    ///   <para>schema1:recipient</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of participant. The participant who is at the receiving end of the action.</para>
    /// labels<para>recipient</para></remarks>
    /// <seealso href="http://schema.org/recipient">http://schema.org/recipient</seealso>
    let recipient = Prefixed_Name(schema1, "recipient") |> PrefixedName
    /// <summary>
    ///   <para>schema1:bed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The type of bed or beds included in the accommodation. For the single case of just one bed of a certain type, you use bed directly with a text.
    ///       If you want to indicate the quantity of a certain kind of bed, use an instance of BedDetails. For more detailed information, use the amenityFeature property.</para>
    /// labels<para>bed</para></remarks>
    /// <seealso href="http://schema.org/bed">http://schema.org/bed</seealso>
    let bed = Prefixed_Name(schema1, "bed") |> PrefixedName
    /// <summary>
    ///   <para>schema1:loser</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of participant. The loser of the action.</para>
    /// labels<para>loser</para></remarks>
    /// <seealso href="http://schema.org/loser">http://schema.org/loser</seealso>
    let loser = Prefixed_Name(schema1, "loser") |> PrefixedName
    /// <summary>
    ///   <para>schema1:rsvpResponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The response (yes, no, maybe) to the RSVP.</para>
    /// labels<para>rsvpResponse</para></remarks>
    /// <seealso href="http://schema.org/rsvpResponse">http://schema.org/rsvpResponse</seealso>
    let rsvpResponse = Prefixed_Name(schema1, "rsvpResponse") |> PrefixedName
    /// <summary>
    ///   <para>schema1:runtime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Runtime platform or script interpreter dependencies (Example - Java v1, Python2.3, .Net Framework 3.0).</para>
    /// labels<para>runtime</para></remarks>
    /// <seealso href="http://schema.org/runtime">http://schema.org/runtime</seealso>
    let runtime = Prefixed_Name(schema1, "runtime") |> PrefixedName
    /// <summary>
    ///   <para>schema1:runtimePlatform</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Runtime platform or script interpreter dependencies (Example - Java v1, Python2.3, .Net Framework 3.0).</para>
    /// labels<para>runtimePlatform</para></remarks>
    /// <seealso href="http://schema.org/runtimePlatform">http://schema.org/runtimePlatform</seealso>
    let runtimePlatform = Prefixed_Name(schema1, "runtimePlatform") |> PrefixedName
    /// <summary>
    ///   <para>schema1:sampleType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>What type of code sample: full (compile ready) solution, code snippet, inline code, scripts, template.</para>
    /// labels<para>sampleType</para></remarks>
    /// <seealso href="http://schema.org/sampleType">http://schema.org/sampleType</seealso>
    let sampleType = Prefixed_Name(schema1, "sampleType") |> PrefixedName

    /// <summary>
    ///   <para>schema1:saturatedFatContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of grams of saturated fat.</para>
    /// labels<para>saturatedFatContent</para></remarks>
    /// <seealso href="http://schema.org/saturatedFatContent">http://schema.org/saturatedFatContent</seealso>
    let saturatedFatContent =
        Prefixed_Name(schema1, "saturatedFatContent") |> PrefixedName

    /// <summary>
    ///   <para>schema1:AdministrativeArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A geographical region, typically under the jurisdiction of a particular government.</para>
    /// labels<para>AdministrativeArea</para></remarks>
    /// <seealso href="http://schema.org/AdministrativeArea">http://schema.org/AdministrativeArea</seealso>
    let AdministrativeArea =
        Prefixed_Name(schema1, "AdministrativeArea") |> PrefixedName

    /// <summary>
    ///   <para>schema1:AggregateOffer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>When a single product is associated with multiple offers (for example, the same pair of shoes is offered by different merchants), then AggregateOffer can be used.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: AggregateOffers are normally expected to associate multiple offers that all share the same defined &lt;a class="localLink" href="http://schema.org/businessFunction"&gt;businessFunction&lt;/a&gt; value, or default to http://purl.org/goodrelations/v1#Sell if businessFunction is not explicitly defined.</para>
    /// labels<para>AggregateOffer</para></remarks>
    /// <seealso href="http://schema.org/AggregateOffer">http://schema.org/AggregateOffer</seealso>
    let AggregateOffer = Prefixed_Name(schema1, "AggregateOffer") |> PrefixedName

    /// <summary>
    ///   <para>schema1:SoftwareSourceCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Computer programming source code. Example: Full (compile ready) solutions, code snippet samples, scripts, templates.</para>
    /// labels<para>SoftwareSourceCode</para></remarks>
    /// <seealso href="http://schema.org/SoftwareSourceCode">http://schema.org/SoftwareSourceCode</seealso>
    let SoftwareSourceCode =
        Prefixed_Name(schema1, "SoftwareSourceCode") |> PrefixedName

    /// <summary>
    ///   <para>schema1:answerCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of answers this question has received.</para>
    /// labels<para>answerCount</para></remarks>
    /// <seealso href="http://schema.org/answerCount">http://schema.org/answerCount</seealso>
    let answerCount = Prefixed_Name(schema1, "answerCount") |> PrefixedName
    /// <summary>
    ///   <para>schema1:application</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An application that can complete the request.</para>
    /// labels<para>application</para></remarks>
    /// <seealso href="http://schema.org/application">http://schema.org/application</seealso>
    let application = Prefixed_Name(schema1, "application") |> PrefixedName

    /// <summary>
    ///   <para>schema1:applicationSubCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Subcategory of the application, e.g. 'Arcade Game'.</para>
    /// labels<para>applicationSubCategory</para></remarks>
    /// <seealso href="http://schema.org/applicationSubCategory">http://schema.org/applicationSubCategory</seealso>
    let applicationSubCategory =
        Prefixed_Name(schema1, "applicationSubCategory") |> PrefixedName

    /// <summary>
    ///   <para>schema1:appliesToDeliveryMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The delivery method(s) to which the delivery charge or payment charge specification applies.</para>
    /// labels<para>appliesToDeliveryMethod</para></remarks>
    /// <seealso href="http://schema.org/appliesToDeliveryMethod">http://schema.org/appliesToDeliveryMethod</seealso>
    let appliesToDeliveryMethod =
        Prefixed_Name(schema1, "appliesToDeliveryMethod") |> PrefixedName

    /// <summary>
    ///   <para>schema1:appliesToPaymentMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The payment method(s) to which the payment charge specification applies.</para>
    /// labels<para>appliesToPaymentMethod</para></remarks>
    /// <seealso href="http://schema.org/appliesToPaymentMethod">http://schema.org/appliesToPaymentMethod</seealso>
    let appliesToPaymentMethod =
        Prefixed_Name(schema1, "appliesToPaymentMethod") |> PrefixedName

    /// <summary>
    ///   <para>schema1:areaServed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The geographic area where a service or offered item is provided.</para>
    /// labels<para>areaServed</para></remarks>
    /// <seealso href="http://schema.org/areaServed">http://schema.org/areaServed</seealso>
    let areaServed = Prefixed_Name(schema1, "areaServed") |> PrefixedName
    /// <summary>
    ///   <para>schema1:arrivalAirport</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The airport where the flight terminates.</para>
    /// labels<para>arrivalAirport</para></remarks>
    /// <seealso href="http://schema.org/arrivalAirport">http://schema.org/arrivalAirport</seealso>
    let arrivalAirport = Prefixed_Name(schema1, "arrivalAirport") |> PrefixedName
    /// <summary>
    ///   <para>schema1:arrivalBusStop</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The stop or station from which the bus arrives.</para>
    /// labels<para>arrivalBusStop</para></remarks>
    /// <seealso href="http://schema.org/arrivalBusStop">http://schema.org/arrivalBusStop</seealso>
    let arrivalBusStop = Prefixed_Name(schema1, "arrivalBusStop") |> PrefixedName
    /// <summary>
    ///   <para>schema1:arrivalGate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Identifier of the flight's arrival gate.</para>
    /// labels<para>arrivalGate</para></remarks>
    /// <seealso href="http://schema.org/arrivalGate">http://schema.org/arrivalGate</seealso>
    let arrivalGate = Prefixed_Name(schema1, "arrivalGate") |> PrefixedName
    /// <summary>
    ///   <para>schema1:arrivalStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The station where the train trip ends.</para>
    /// labels<para>arrivalStation</para></remarks>
    /// <seealso href="http://schema.org/arrivalStation">http://schema.org/arrivalStation</seealso>
    let arrivalStation = Prefixed_Name(schema1, "arrivalStation") |> PrefixedName
    /// <summary>
    ///   <para>schema1:arrivalTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The expected arrival time.</para>
    /// labels<para>arrivalTime</para></remarks>
    /// <seealso href="http://schema.org/arrivalTime">http://schema.org/arrivalTime</seealso>
    let arrivalTime = Prefixed_Name(schema1, "arrivalTime") |> PrefixedName
    /// <summary>
    ///   <para>schema1:artMedium</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The material used. (e.g. Oil, Watercolour, Acrylic, Linoprint, Marble, Cyanotype, Digital, Lithograph, DryPoint, Intaglio, Pastel, Woodcut, Pencil, Mixed Media, etc.)</para>
    /// labels<para>artMedium</para></remarks>
    /// <seealso href="http://schema.org/artMedium">http://schema.org/artMedium</seealso>
    let artMedium = Prefixed_Name(schema1, "artMedium") |> PrefixedName
    /// <summary>
    ///   <para>schema1:articleBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The actual body of the article.</para>
    /// labels<para>articleBody</para></remarks>
    /// <seealso href="http://schema.org/articleBody">http://schema.org/articleBody</seealso>
    let articleBody = Prefixed_Name(schema1, "articleBody") |> PrefixedName
    /// <summary>
    ///   <para>schema1:artworkSurface</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The supporting materials for the artwork, e.g. Canvas, Paper, Wood, Board, etc.</para>
    /// labels<para>artworkSurface</para></remarks>
    /// <seealso href="http://schema.org/artworkSurface">http://schema.org/artworkSurface</seealso>
    let artworkSurface = Prefixed_Name(schema1, "artworkSurface") |> PrefixedName
    /// <summary>
    ///   <para>schema1:assemblyVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Associated product/technology version. e.g., .NET Framework 4.5.</para>
    /// labels<para>assemblyVersion</para></remarks>
    /// <seealso href="http://schema.org/assemblyVersion">http://schema.org/assemblyVersion</seealso>
    let assemblyVersion = Prefixed_Name(schema1, "assemblyVersion") |> PrefixedName
    /// <summary>
    ///   <para>schema1:athlete</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A person that acts as performing member of a sports team; a player as opposed to a coach.</para>
    /// labels<para>athlete</para></remarks>
    /// <seealso href="http://schema.org/athlete">http://schema.org/athlete</seealso>
    let athlete = Prefixed_Name(schema1, "athlete") |> PrefixedName
    /// <summary>
    ///   <para>schema1:attendee</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A person or organization attending the event.</para>
    /// labels<para>attendee</para></remarks>
    /// <seealso href="http://schema.org/attendee">http://schema.org/attendee</seealso>
    let attendee = Prefixed_Name(schema1, "attendee") |> PrefixedName
    /// <summary>
    ///   <para>schema1:audienceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The target group associated with a given audience (e.g. veterans, car owners, musicians, etc.).</para>
    /// labels<para>audienceType</para></remarks>
    /// <seealso href="http://schema.org/audienceType">http://schema.org/audienceType</seealso>
    let audienceType = Prefixed_Name(schema1, "audienceType") |> PrefixedName
    /// <summary>
    ///   <para>schema1:audio</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An embedded audio object.</para>
    /// labels<para>audio</para></remarks>
    /// <seealso href="http://schema.org/audio">http://schema.org/audio</seealso>
    let audio = Prefixed_Name(schema1, "audio") |> PrefixedName
    /// <summary>
    ///   <para>schema1:author</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The author of this content or rating. Please note that author is special in that HTML 5 provides a special mechanism for indicating authorship via the rel tag. That is equivalent to this and may be used interchangeably.</para>
    /// labels<para>author</para></remarks>
    /// <seealso href="http://schema.org/author">http://schema.org/author</seealso>
    let author = Prefixed_Name(schema1, "author") |> PrefixedName
    /// <summary>
    ///   <para>schema1:availability</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The availability of this item&amp;#x2014;for example In stock, Out of stock, Pre-order, etc.</para>
    /// labels<para>availability</para></remarks>
    /// <seealso href="http://schema.org/availability">http://schema.org/availability</seealso>
    let availability = Prefixed_Name(schema1, "availability") |> PrefixedName
    /// <summary>
    ///   <para>schema1:availabilityEnds</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The end of the availability of the product or service included in the offer.</para>
    /// labels<para>availabilityEnds</para></remarks>
    /// <seealso href="http://schema.org/availabilityEnds">http://schema.org/availabilityEnds</seealso>
    let availabilityEnds = Prefixed_Name(schema1, "availabilityEnds") |> PrefixedName
    /// <summary>
    ///   <para>schema1:discusses</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies the CreativeWork associated with the UserComment.</para>
    /// labels<para>discusses</para></remarks>
    /// <seealso href="http://schema.org/discusses">http://schema.org/discusses</seealso>
    let discusses = Prefixed_Name(schema1, "discusses") |> PrefixedName
    /// <summary>
    ///   <para>schema1:discussionUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A link to the page containing the comments of the CreativeWork.</para>
    /// labels<para>discussionUrl</para></remarks>
    /// <seealso href="http://schema.org/discussionUrl">http://schema.org/discussionUrl</seealso>
    let discussionUrl = Prefixed_Name(schema1, "discussionUrl") |> PrefixedName
    /// <summary>
    ///   <para>schema1:dissolutionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The date that this organization was dissolved.</para>
    /// labels<para>dissolutionDate</para></remarks>
    /// <seealso href="http://schema.org/dissolutionDate">http://schema.org/dissolutionDate</seealso>
    let dissolutionDate = Prefixed_Name(schema1, "dissolutionDate") |> PrefixedName
    /// <summary>
    ///   <para>schema1:loanTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The duration of the loan or credit agreement.</para>
    /// labels<para>loanTerm</para></remarks>
    /// <seealso href="http://schema.org/loanTerm">http://schema.org/loanTerm</seealso>
    let loanTerm = Prefixed_Name(schema1, "loanTerm") |> PrefixedName
    /// <summary>
    ///   <para>schema1:VirtualLocation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schema.org/VirtualLocation">http://schema.org/VirtualLocation</seealso>
    let VirtualLocation = Prefixed_Name(schema1, "VirtualLocation") |> PrefixedName
    /// <summary>
    ///   <para>schema1:locationCreated</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The location where the CreativeWork was created, which may not be the same as the location depicted in the CreativeWork.</para>
    /// labels<para>locationCreated</para></remarks>
    /// <seealso href="http://schema.org/locationCreated">http://schema.org/locationCreated</seealso>
    let locationCreated = Prefixed_Name(schema1, "locationCreated") |> PrefixedName
    /// <summary>
    ///   <para>schema1:lodgingUnitType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Textual description of the unit type (including suite vs. room, size of bed, etc.).</para>
    /// labels<para>lodgingUnitType</para></remarks>
    /// <seealso href="http://schema.org/lodgingUnitType">http://schema.org/lodgingUnitType</seealso>
    let lodgingUnitType = Prefixed_Name(schema1, "lodgingUnitType") |> PrefixedName
    /// <summary>
    ///   <para>schema1:logo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An associated logo.</para>
    /// labels<para>logo</para></remarks>
    /// <seealso href="http://schema.org/logo">http://schema.org/logo</seealso>
    let logo = Prefixed_Name(schema1, "logo") |> PrefixedName
    /// <summary>
    ///   <para>schema1:longitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The longitude of a location. For example &lt;code&gt;-122.08585&lt;/code&gt; (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).</para>
    /// labels<para>longitude</para></remarks>
    /// <seealso href="http://schema.org/longitude">http://schema.org/longitude</seealso>
    let longitude = Prefixed_Name(schema1, "longitude") |> PrefixedName
    /// <summary>
    ///   <para>schema1:lowPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The lowest price of all offers available.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Usage guidelines:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
    /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>lowPrice</para></remarks>
    /// <seealso href="http://schema.org/lowPrice">http://schema.org/lowPrice</seealso>
    let lowPrice = Prefixed_Name(schema1, "lowPrice") |> PrefixedName
    /// <summary>
    ///   <para>schema1:lyricist</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The person who wrote the words.</para>
    /// labels<para>lyricist</para></remarks>
    /// <seealso href="http://schema.org/lyricist">http://schema.org/lyricist</seealso>
    let lyricist = Prefixed_Name(schema1, "lyricist") |> PrefixedName
    /// <summary>
    ///   <para>schema1:lyrics</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The words in the song.</para>
    /// labels<para>lyrics</para></remarks>
    /// <seealso href="http://schema.org/lyrics">http://schema.org/lyrics</seealso>
    let lyrics = Prefixed_Name(schema1, "lyrics") |> PrefixedName
    /// <summary>
    ///   <para>schema1:mainEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the primary entity described in some page or other CreativeWork.</para>
    /// labels<para>mainEntity</para></remarks>
    /// <seealso href="http://schema.org/mainEntity">http://schema.org/mainEntity</seealso>
    let mainEntity = Prefixed_Name(schema1, "mainEntity") |> PrefixedName
    /// <summary>
    ///   <para>schema1:mainEntityOfPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a page (or other CreativeWork) for which this thing is the main entity being described. See &lt;a href="/docs/datamodel.html#mainEntityBackground"&gt;background notes&lt;/a&gt; for details.</para>
    /// labels<para>mainEntityOfPage</para></remarks>
    /// <seealso href="http://schema.org/mainEntityOfPage">http://schema.org/mainEntityOfPage</seealso>
    let mainEntityOfPage = Prefixed_Name(schema1, "mainEntityOfPage") |> PrefixedName
    /// <summary>
    ///   <para>schema1:manufacturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The manufacturer of the product.</para>
    /// labels<para>manufacturer</para></remarks>
    /// <seealso href="http://schema.org/manufacturer">http://schema.org/manufacturer</seealso>
    let manufacturer = Prefixed_Name(schema1, "manufacturer") |> PrefixedName
    /// <summary>
    ///   <para>schema1:DietarySupplement</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schema.org/DietarySupplement">http://schema.org/DietarySupplement</seealso>
    let DietarySupplement = Prefixed_Name(schema1, "DietarySupplement") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Drug</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schema.org/Drug">http://schema.org/Drug</seealso>
    let Drug = Prefixed_Name(schema1, "Drug") |> PrefixedName
    /// <summary>
    ///   <para>schema1:map</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A URL to a map of the place.</para>
    /// labels<para>map</para></remarks>
    /// <seealso href="http://schema.org/map">http://schema.org/map</seealso>
    let map = Prefixed_Name(schema1, "map") |> PrefixedName
    /// <summary>
    ///   <para>schema1:mapType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the kind of Map, from the MapCategoryType Enumeration.</para>
    /// labels<para>mapType</para></remarks>
    /// <seealso href="http://schema.org/mapType">http://schema.org/mapType</seealso>
    let mapType = Prefixed_Name(schema1, "mapType") |> PrefixedName
    /// <summary>
    ///   <para>schema1:maps</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A URL to a map of the place.</para>
    /// labels<para>maps</para></remarks>
    /// <seealso href="http://schema.org/maps">http://schema.org/maps</seealso>
    let maps = Prefixed_Name(schema1, "maps") |> PrefixedName
    /// <summary>
    ///   <para>schema1:maxValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The upper value of some characteristic or property.</para>
    /// labels<para>maxValue</para></remarks>
    /// <seealso href="http://schema.org/maxValue">http://schema.org/maxValue</seealso>
    let maxValue = Prefixed_Name(schema1, "maxValue") |> PrefixedName

    /// <summary>
    ///   <para>schema1:maximumAttendeeCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The total number of individuals that may attend an event or venue.</para>
    /// labels<para>maximumAttendeeCapacity</para></remarks>
    /// <seealso href="http://schema.org/maximumAttendeeCapacity">http://schema.org/maximumAttendeeCapacity</seealso>
    let maximumAttendeeCapacity =
        Prefixed_Name(schema1, "maximumAttendeeCapacity") |> PrefixedName

    /// <summary>
    ///   <para>schema1:mealService</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Description of the meals that will be provided or available for purchase.</para>
    /// labels<para>mealService</para></remarks>
    /// <seealso href="http://schema.org/mealService">http://schema.org/mealService</seealso>
    let mealService = Prefixed_Name(schema1, "mealService") |> PrefixedName
    /// <summary>
    ///   <para>schema1:median</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The median value.</para>
    /// labels<para>median</para></remarks>
    /// <seealso href="http://schema.org/median">http://schema.org/median</seealso>
    let median = Prefixed_Name(schema1, "median") |> PrefixedName
    /// <summary>
    ///   <para>schema1:member</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A member of an Organization or a ProgramMembership. Organizations can be members of organizations; ProgramMembership is typically for individuals.</para>
    /// labels<para>member</para></remarks>
    /// <seealso href="http://schema.org/member">http://schema.org/member</seealso>
    let member_ = Prefixed_Name(schema1, "member") |> PrefixedName
    /// <summary>
    ///   <para>schema1:members</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A member of this organization.</para>
    /// labels<para>members</para></remarks>
    /// <seealso href="http://schema.org/members">http://schema.org/members</seealso>
    let members = Prefixed_Name(schema1, "members") |> PrefixedName
    /// <summary>
    ///   <para>schema1:membershipNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A unique identifier for the membership.</para>
    /// labels<para>membershipNumber</para></remarks>
    /// <seealso href="http://schema.org/membershipNumber">http://schema.org/membershipNumber</seealso>
    let membershipNumber = Prefixed_Name(schema1, "membershipNumber") |> PrefixedName

    /// <summary>
    ///   <para>schema1:memoryRequirements</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Minimum memory requirements.</para>
    /// labels<para>memoryRequirements</para></remarks>
    /// <seealso href="http://schema.org/memoryRequirements">http://schema.org/memoryRequirements</seealso>
    let memoryRequirements =
        Prefixed_Name(schema1, "memoryRequirements") |> PrefixedName

    /// <summary>
    ///   <para>schema1:mentions</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates that the CreativeWork contains a reference to, but is not necessarily about a concept.</para>
    /// labels<para>mentions</para></remarks>
    /// <seealso href="http://schema.org/mentions">http://schema.org/mentions</seealso>
    let mentions = Prefixed_Name(schema1, "mentions") |> PrefixedName
    /// <summary>
    ///   <para>schema1:menu</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Either the actual menu as a structured representation, as text, or a URL of the menu.</para>
    /// labels<para>menu</para></remarks>
    /// <seealso href="http://schema.org/menu">http://schema.org/menu</seealso>
    let menu = Prefixed_Name(schema1, "menu") |> PrefixedName
    /// <summary>
    ///   <para>schema1:merchant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>'merchant' is an out-dated term for 'seller'.</para>
    /// labels<para>merchant</para></remarks>
    /// <seealso href="http://schema.org/merchant">http://schema.org/merchant</seealso>
    let merchant = Prefixed_Name(schema1, "merchant") |> PrefixedName
    /// <summary>
    ///   <para>schema1:seller</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An entity which offers (sells / leases / lends / loans) the services / goods.  A seller may also be a provider.</para>
    /// labels<para>seller</para></remarks>
    /// <seealso href="http://schema.org/seller">http://schema.org/seller</seealso>
    let seller = Prefixed_Name(schema1, "seller") |> PrefixedName
    /// <summary>
    ///   <para>schema1:messageAttachment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A CreativeWork attached to the message.</para>
    /// labels<para>messageAttachment</para></remarks>
    /// <seealso href="http://schema.org/messageAttachment">http://schema.org/messageAttachment</seealso>
    let messageAttachment = Prefixed_Name(schema1, "messageAttachment") |> PrefixedName

    /// <summary>
    ///   <para>schema1:mileageFromOdometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The total distance travelled by the particular vehicle since its initial production, as read from its odometer.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Typical unit code(s): KMT for kilometers, SMI for statute miles</para>
    /// labels<para>mileageFromOdometer</para></remarks>
    /// <seealso href="http://schema.org/mileageFromOdometer">http://schema.org/mileageFromOdometer</seealso>
    let mileageFromOdometer =
        Prefixed_Name(schema1, "mileageFromOdometer") |> PrefixedName

    /// <summary>
    ///   <para>schema1:minPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The lowest price if the price is a range.</para>
    /// labels<para>minPrice</para></remarks>
    /// <seealso href="http://schema.org/minPrice">http://schema.org/minPrice</seealso>
    let minPrice = Prefixed_Name(schema1, "minPrice") |> PrefixedName
    /// <summary>
    ///   <para>schema1:minimumPaymentDue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The minimum payment required at this time.</para>
    /// labels<para>minimumPaymentDue</para></remarks>
    /// <seealso href="http://schema.org/minimumPaymentDue">http://schema.org/minimumPaymentDue</seealso>
    let minimumPaymentDue = Prefixed_Name(schema1, "minimumPaymentDue") |> PrefixedName
    /// <summary>
    ///   <para>schema1:model</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The model of the product. Use with the URL of a ProductModel or a textual representation of the model identifier. The URL of the ProductModel can be from an external source. It is recommended to additionally provide strong product identifiers via the gtin8/gtin13/gtin14 and mpn properties.</para>
    /// labels<para>model</para></remarks>
    /// <seealso href="http://schema.org/model">http://schema.org/model</seealso>
    let model = Prefixed_Name(schema1, "model") |> PrefixedName
    /// <summary>
    ///   <para>schema1:modifiedTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The date and time the reservation was modified.</para>
    /// labels<para>modifiedTime</para></remarks>
    /// <seealso href="http://schema.org/modifiedTime">http://schema.org/modifiedTime</seealso>
    let modifiedTime = Prefixed_Name(schema1, "modifiedTime") |> PrefixedName
    /// <summary>
    ///   <para>schema1:mpn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Manufacturer Part Number (MPN) of the product, or the product to which the offer refers.</para>
    /// labels<para>mpn</para></remarks>
    /// <seealso href="http://schema.org/mpn">http://schema.org/mpn</seealso>
    let mpn = Prefixed_Name(schema1, "mpn") |> PrefixedName
    /// <summary>
    ///   <para>schema1:multipleValues</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether multiple values are allowed for the property.  Default is false.</para>
    /// labels<para>multipleValues</para></remarks>
    /// <seealso href="http://schema.org/multipleValues">http://schema.org/multipleValues</seealso>
    let multipleValues = Prefixed_Name(schema1, "multipleValues") |> PrefixedName
    /// <summary>
    ///   <para>schema1:sportsEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of location. The sports event where this action occurred.</para>
    /// labels<para>sportsEvent</para></remarks>
    /// <seealso href="http://schema.org/sportsEvent">http://schema.org/sportsEvent</seealso>
    let sportsEvent = Prefixed_Name(schema1, "sportsEvent") |> PrefixedName
    /// <summary>
    ///   <para>schema1:sportsTeam</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of participant. The sports team that participated on this action.</para>
    /// labels<para>sportsTeam</para></remarks>
    /// <seealso href="http://schema.org/sportsTeam">http://schema.org/sportsTeam</seealso>
    let sportsTeam = Prefixed_Name(schema1, "sportsTeam") |> PrefixedName
    /// <summary>
    ///   <para>schema1:spouse</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The person's spouse.</para>
    /// labels<para>spouse</para></remarks>
    /// <seealso href="http://schema.org/spouse">http://schema.org/spouse</seealso>
    let spouse = Prefixed_Name(schema1, "spouse") |> PrefixedName
    /// <summary>
    ///   <para>schema1:starRating</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An official rating for a lodging business or food establishment, e.g. from national associations or standards bodies. Use the author property to indicate the rating organization, e.g. as an Organization with name such as (e.g. HOTREC, DEHOGA, WHR, or Hotelstars).</para>
    /// labels<para>starRating</para></remarks>
    /// <seealso href="http://schema.org/starRating">http://schema.org/starRating</seealso>
    let starRating = Prefixed_Name(schema1, "starRating") |> PrefixedName
    /// <summary>
    ///   <para>schema1:startDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The start date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).</para>
    /// labels<para>startDate</para></remarks>
    /// <seealso href="http://schema.org/startDate">http://schema.org/startDate</seealso>
    let startDate = Prefixed_Name(schema1, "startDate") |> PrefixedName

    /// <summary>
    ///   <para>schema1:AdultEntertainment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An adult entertainment establishment.</para>
    /// labels<para>AdultEntertainment</para></remarks>
    /// <seealso href="http://schema.org/AdultEntertainment">http://schema.org/AdultEntertainment</seealso>
    let AdultEntertainment =
        Prefixed_Name(schema1, "AdultEntertainment") |> PrefixedName

    /// <summary>
    ///   <para>schema1:FilmAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of capturing sound and moving images on film, video, or digitally.</para>
    /// labels<para>FilmAction</para></remarks>
    /// <seealso href="http://schema.org/FilmAction">http://schema.org/FilmAction</seealso>
    let FilmAction = Prefixed_Name(schema1, "FilmAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:OnlineFull</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:GameServerStatus</para>
    ///   <para>Game server status: OnlineFull. Server is online but unavailable. The maximum number of players has reached.</para>
    /// labels<para>OnlineFull</para></remarks>
    /// <seealso href="http://schema.org/OnlineFull">http://schema.org/OnlineFull</seealso>
    let OnlineFull = Prefixed_Name(schema1, "OnlineFull") |> PrefixedName

    /// <summary>
    ///   <para>schema1:OpeningHoursSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A structured value providing information about the opening hours of a place or a certain service inside a place.&lt;br/&gt;&lt;br/&gt;
    ///
    /// The place is &lt;strong&gt;open&lt;/strong&gt; if the &lt;a class="localLink" href="http://schema.org/opens"&gt;opens&lt;/a&gt; property is specified, and &lt;strong&gt;closed&lt;/strong&gt; otherwise.&lt;br/&gt;&lt;br/&gt;
    ///
    /// If the value for the &lt;a class="localLink" href="http://schema.org/closes"&gt;closes&lt;/a&gt; property is less than the value for the &lt;a class="localLink" href="http://schema.org/opens"&gt;opens&lt;/a&gt; property then the hour range is assumed to span over the next day.</para>
    /// labels<para>OpeningHoursSpecification</para></remarks>
    /// <seealso href="http://schema.org/OpeningHoursSpecification">http://schema.org/OpeningHoursSpecification</seealso>
    let OpeningHoursSpecification =
        Prefixed_Name(schema1, "OpeningHoursSpecification") |> PrefixedName

    /// <summary>
    ///   <para>schema1:OrderCancelled</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:OrderStatus</para>
    ///   <para>OrderStatus representing cancellation of an order.</para>
    /// labels<para>OrderCancelled</para></remarks>
    /// <seealso href="http://schema.org/OrderCancelled">http://schema.org/OrderCancelled</seealso>
    let OrderCancelled = Prefixed_Name(schema1, "OrderCancelled") |> PrefixedName
    /// <summary>
    ///   <para>schema1:OrderPaymentDue</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:OrderStatus</para>
    ///   <para>OrderStatus representing that payment is due on an order.</para>
    /// labels<para>OrderPaymentDue</para></remarks>
    /// <seealso href="http://schema.org/OrderPaymentDue">http://schema.org/OrderPaymentDue</seealso>
    let OrderPaymentDue = Prefixed_Name(schema1, "OrderPaymentDue") |> PrefixedName
    /// <summary>
    ///   <para>schema1:OutletStore</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An outlet store.</para>
    /// labels<para>OutletStore</para></remarks>
    /// <seealso href="http://schema.org/OutletStore">http://schema.org/OutletStore</seealso>
    let OutletStore = Prefixed_Name(schema1, "OutletStore") |> PrefixedName
    /// <summary>
    ///   <para>schema1:OwnershipInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A structured value providing information about when a certain organization or person owned a certain product.</para>
    /// labels<para>OwnershipInfo</para></remarks>
    /// <seealso href="http://schema.org/OwnershipInfo">http://schema.org/OwnershipInfo</seealso>
    let OwnershipInfo = Prefixed_Name(schema1, "OwnershipInfo") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Paperback</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:BookFormatType</para>
    ///   <para>Book format: Paperback.</para>
    /// labels<para>Paperback</para></remarks>
    /// <seealso href="http://schema.org/Paperback">http://schema.org/Paperback</seealso>
    let Paperback = Prefixed_Name(schema1, "Paperback") |> PrefixedName
    /// <summary>
    ///   <para>schema1:PeopleAudience</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A set of characteristics belonging to people, e.g. who compose an item's target audience.</para>
    /// labels<para>PeopleAudience</para></remarks>
    /// <seealso href="http://schema.org/PeopleAudience">http://schema.org/PeopleAudience</seealso>
    let PeopleAudience = Prefixed_Name(schema1, "PeopleAudience") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Park</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A park.</para>
    /// labels<para>Park</para></remarks>
    /// <seealso href="http://schema.org/Park">http://schema.org/Park</seealso>
    let Park = Prefixed_Name(schema1, "Park") |> PrefixedName
    /// <summary>
    ///   <para>schema1:PawnShop</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A shop that will buy, or lend money against the security of, personal possessions.</para>
    /// labels<para>PawnShop</para></remarks>
    /// <seealso href="http://schema.org/PawnShop">http://schema.org/PawnShop</seealso>
    let PawnShop = Prefixed_Name(schema1, "PawnShop") |> PrefixedName
    /// <summary>
    ///   <para>schema1:PayAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An agent pays a price to a participant.</para>
    /// labels<para>PayAction</para></remarks>
    /// <seealso href="http://schema.org/PayAction">http://schema.org/PayAction</seealso>
    let PayAction = Prefixed_Name(schema1, "PayAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:PaymentMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A payment method is a standardized procedure for transferring the monetary amount for a purchase. Payment methods are characterized by the legal and technical structures used, and by the organization or group carrying out the transaction.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Commonly used values:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#ByBankTransferInAdvance&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#ByInvoice&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#Cash&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#CheckInAdvance&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#COD&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#DirectDebit&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#GoogleCheckout&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#PayPal&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#PaySwarm&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>PaymentMethod</para></remarks>
    /// <seealso href="http://schema.org/PaymentMethod">http://schema.org/PaymentMethod</seealso>
    let PaymentMethod = Prefixed_Name(schema1, "PaymentMethod") |> PrefixedName

    /// <summary>
    ///   <para>schema1:PaymentChargeSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The costs of settling the payment using a particular payment method.</para>
    /// labels<para>PaymentChargeSpecification</para></remarks>
    /// <seealso href="http://schema.org/PaymentChargeSpecification">http://schema.org/PaymentChargeSpecification</seealso>
    let PaymentChargeSpecification =
        Prefixed_Name(schema1, "PaymentChargeSpecification") |> PrefixedName

    /// <summary>
    ///   <para>schema1:Table</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A table on a Web page.</para>
    /// labels<para>Table</para></remarks>
    /// <seealso href="http://schema.org/Table">http://schema.org/Table</seealso>
    let Table = Prefixed_Name(schema1, "Table") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Taxi</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A taxi.</para>
    /// labels<para>Taxi</para></remarks>
    /// <seealso href="http://schema.org/Taxi">http://schema.org/Taxi</seealso>
    let Taxi = Prefixed_Name(schema1, "Taxi") |> PrefixedName
    /// <summary>
    ///   <para>schema1:TaxiService</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A service for a vehicle for hire with a driver for local travel. Fares are usually calculated based on distance traveled.</para>
    /// labels<para>TaxiService</para></remarks>
    /// <seealso href="http://schema.org/TaxiService">http://schema.org/TaxiService</seealso>
    let TaxiService = Prefixed_Name(schema1, "TaxiService") |> PrefixedName
    /// <summary>
    ///   <para>schema1:TaxiStand</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A taxi stand.</para>
    /// labels<para>TaxiStand</para></remarks>
    /// <seealso href="http://schema.org/TaxiStand">http://schema.org/TaxiStand</seealso>
    let TaxiStand = Prefixed_Name(schema1, "TaxiStand") |> PrefixedName
    /// <summary>
    ///   <para>schema1:department</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A relationship between an organization and a department of that organization, also described as an organization (allowing different urls, logos, opening hours). For example: a store with a pharmacy, or a bakery with a cafe.</para>
    /// labels<para>department</para></remarks>
    /// <seealso href="http://schema.org/department">http://schema.org/department</seealso>
    let department = Prefixed_Name(schema1, "department") |> PrefixedName
    /// <summary>
    ///   <para>schema1:jobLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A (typically single) geographic location associated with the job position.</para>
    /// labels<para>jobLocation</para></remarks>
    /// <seealso href="http://schema.org/jobLocation">http://schema.org/jobLocation</seealso>
    let jobLocation = Prefixed_Name(schema1, "jobLocation") |> PrefixedName
    /// <summary>
    ///   <para>schema1:keywords</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Keywords or tags used to describe this content. Multiple entries in a keywords list are typically delimited by commas.</para>
    /// labels<para>keywords</para></remarks>
    /// <seealso href="http://schema.org/keywords">http://schema.org/keywords</seealso>
    let keywords = Prefixed_Name(schema1, "keywords") |> PrefixedName
    /// <summary>
    ///   <para>schema1:landlord</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of participant. The owner of the real estate property.</para>
    /// labels<para>landlord</para></remarks>
    /// <seealso href="http://schema.org/landlord">http://schema.org/landlord</seealso>
    let landlord = Prefixed_Name(schema1, "landlord") |> PrefixedName
    /// <summary>
    ///   <para>schema1:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of instrument. The language used on this action.</para>
    /// labels<para>language</para></remarks>
    /// <seealso href="http://schema.org/language">http://schema.org/language</seealso>
    let language = Prefixed_Name(schema1, "language") |> PrefixedName
    /// <summary>
    ///   <para>schema1:realEstateAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of participant. The real estate agent involved in the action.</para>
    /// labels<para>realEstateAgent</para></remarks>
    /// <seealso href="http://schema.org/realEstateAgent">http://schema.org/realEstateAgent</seealso>
    let realEstateAgent = Prefixed_Name(schema1, "realEstateAgent") |> PrefixedName
    /// <summary>
    ///   <para>schema1:recipe</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of instrument. The recipe/instructions used to perform the action.</para>
    /// labels<para>recipe</para></remarks>
    /// <seealso href="http://schema.org/recipe">http://schema.org/recipe</seealso>
    let recipe = Prefixed_Name(schema1, "recipe") |> PrefixedName
    /// <summary>
    ///   <para>schema1:recipeCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The category of the recipe—for example, appetizer, entree, etc.</para>
    /// labels<para>recipeCategory</para></remarks>
    /// <seealso href="http://schema.org/recipeCategory">http://schema.org/recipeCategory</seealso>
    let recipeCategory = Prefixed_Name(schema1, "recipeCategory") |> PrefixedName
    /// <summary>
    ///   <para>schema1:recipeCuisine</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The cuisine of the recipe (for example, French or Ethiopian).</para>
    /// labels<para>recipeCuisine</para></remarks>
    /// <seealso href="http://schema.org/recipeCuisine">http://schema.org/recipeCuisine</seealso>
    let recipeCuisine = Prefixed_Name(schema1, "recipeCuisine") |> PrefixedName

    /// <summary>
    ///   <para>schema1:recipeInstructions</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A step in making the recipe, in the form of a single item (document, video, etc.) or an ordered list with HowToStep and/or HowToSection items.</para>
    /// labels<para>recipeInstructions</para></remarks>
    /// <seealso href="http://schema.org/recipeInstructions">http://schema.org/recipeInstructions</seealso>
    let recipeInstructions =
        Prefixed_Name(schema1, "recipeInstructions") |> PrefixedName

    /// <summary>
    ///   <para>schema1:step</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A single step item (as HowToStep, text, document, video, etc.) or a HowToSection.</para>
    /// labels<para>step</para></remarks>
    /// <seealso href="http://schema.org/step">http://schema.org/step</seealso>
    let step = Prefixed_Name(schema1, "step") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Rating</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A rating is an evaluation on a numeric scale, such as 1 to 5 stars.</para>
    /// labels<para>Rating</para></remarks>
    /// <seealso href="http://schema.org/Rating">http://schema.org/Rating</seealso>
    let Rating = Prefixed_Name(schema1, "Rating") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Airport</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An airport.</para>
    /// labels<para>Airport</para></remarks>
    /// <seealso href="http://schema.org/Airport">http://schema.org/Airport</seealso>
    let Airport = Prefixed_Name(schema1, "Airport") |> PrefixedName

    /// <summary>
    ///   <para>schema1:GovernmentOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A governmental organization or agency.</para>
    /// labels<para>GovernmentOrganization</para></remarks>
    /// <seealso href="http://schema.org/GovernmentOrganization">http://schema.org/GovernmentOrganization</seealso>
    let GovernmentOrganization =
        Prefixed_Name(schema1, "GovernmentOrganization") |> PrefixedName

    /// <summary>
    ///   <para>schema1:HairSalon</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A hair salon.</para>
    /// labels<para>HairSalon</para></remarks>
    /// <seealso href="http://schema.org/HairSalon">http://schema.org/HairSalon</seealso>
    let HairSalon = Prefixed_Name(schema1, "HairSalon") |> PrefixedName
    /// <summary>
    ///   <para>schema1:HalalDiet</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:RestrictedDiet</para>
    ///   <para>A diet conforming to Islamic dietary practices.</para>
    /// labels<para>HalalDiet</para></remarks>
    /// <seealso href="http://schema.org/HalalDiet">http://schema.org/HalalDiet</seealso>
    let HalalDiet = Prefixed_Name(schema1, "HalalDiet") |> PrefixedName
    /// <summary>
    ///   <para>schema1:director</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.</para>
    /// labels<para>director</para></remarks>
    /// <seealso href="http://schema.org/director">http://schema.org/director</seealso>
    let director = Prefixed_Name(schema1, "director") |> PrefixedName
    /// <summary>
    ///   <para>schema1:license</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A license document that applies to this content, typically indicated by URL.</para>
    /// labels<para>license</para></remarks>
    /// <seealso href="http://schema.org/license">http://schema.org/license</seealso>
    let license = Prefixed_Name(schema1, "license") |> PrefixedName
    /// <summary>
    ///   <para>schema1:reportNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number or other unique designator assigned to a Report by the publishing organization.</para>
    /// labels<para>reportNumber</para></remarks>
    /// <seealso href="http://schema.org/reportNumber">http://schema.org/reportNumber</seealso>
    let reportNumber = Prefixed_Name(schema1, "reportNumber") |> PrefixedName
    /// <summary>
    ///   <para>schema1:CommentPermission</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:DigitalDocumentPermissionType</para>
    ///   <para>Permission to add comments to the document.</para>
    /// labels<para>CommentPermission</para></remarks>
    /// <seealso href="http://schema.org/CommentPermission">http://schema.org/CommentPermission</seealso>
    let CommentPermission = Prefixed_Name(schema1, "CommentPermission") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ComputerLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This type covers computer programming languages such as Scheme and Lisp, as well as other language-like computer representations. Natural languages are best represented with the &lt;a class="localLink" href="http://schema.org/Language"&gt;Language&lt;/a&gt; type.</para>
    /// labels<para>ComputerLanguage</para></remarks>
    /// <seealso href="http://schema.org/ComputerLanguage">http://schema.org/ComputerLanguage</seealso>
    let ComputerLanguage = Prefixed_Name(schema1, "ComputerLanguage") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ComputerStore</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A computer store.</para>
    /// labels<para>ComputerStore</para></remarks>
    /// <seealso href="http://schema.org/ComputerStore">http://schema.org/ComputerStore</seealso>
    let ComputerStore = Prefixed_Name(schema1, "ComputerStore") |> PrefixedName
    /// <summary>
    ///   <para>schema1:TennisComplex</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A tennis complex.</para>
    /// labels<para>TennisComplex</para></remarks>
    /// <seealso href="http://schema.org/TennisComplex">http://schema.org/TennisComplex</seealso>
    let TennisComplex = Prefixed_Name(schema1, "TennisComplex") |> PrefixedName
    /// <summary>
    ///   <para>schema1:TheaterGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A theater group or company, for example, the Royal Shakespeare Company or Druid Theatre.</para>
    /// labels<para>TheaterGroup</para></remarks>
    /// <seealso href="http://schema.org/TheaterGroup">http://schema.org/TheaterGroup</seealso>
    let TheaterGroup = Prefixed_Name(schema1, "TheaterGroup") |> PrefixedName
    /// <summary>
    ///   <para>schema1:departureTerminal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Identifier of the flight's departure terminal.</para>
    /// labels<para>departureTerminal</para></remarks>
    /// <seealso href="http://schema.org/departureTerminal">http://schema.org/departureTerminal</seealso>
    let departureTerminal = Prefixed_Name(schema1, "departureTerminal") |> PrefixedName
    /// <summary>
    ///   <para>schema1:TVSeason</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Season dedicated to TV broadcast and associated online delivery.</para>
    /// labels<para>TVSeason</para></remarks>
    /// <seealso href="http://schema.org/TVSeason">http://schema.org/TVSeason</seealso>
    let TVSeason = Prefixed_Name(schema1, "TVSeason") |> PrefixedName

    /// <summary>
    ///   <para>schema1:applicationCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Type of software application, e.g. 'Game, Multimedia'.</para>
    /// labels<para>applicationCategory</para></remarks>
    /// <seealso href="http://schema.org/applicationCategory">http://schema.org/applicationCategory</seealso>
    let applicationCategory =
        Prefixed_Name(schema1, "applicationCategory") |> PrefixedName

    /// <summary>
    ///   <para>schema1:applicationSuite</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The name of the application suite to which the application belongs (e.g. Excel belongs to Office).</para>
    /// labels<para>applicationSuite</para></remarks>
    /// <seealso href="http://schema.org/applicationSuite">http://schema.org/applicationSuite</seealso>
    let applicationSuite = Prefixed_Name(schema1, "applicationSuite") |> PrefixedName
    /// <summary>
    ///   <para>schema1:area</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The area within which users can expect to reach the broadcast service.</para>
    /// labels<para>area</para></remarks>
    /// <seealso href="http://schema.org/area">http://schema.org/area</seealso>
    let area = Prefixed_Name(schema1, "area") |> PrefixedName
    /// <summary>
    ///   <para>schema1:serviceArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The geographic area where the service is provided.</para>
    /// labels<para>serviceArea</para></remarks>
    /// <seealso href="http://schema.org/serviceArea">http://schema.org/serviceArea</seealso>
    let serviceArea = Prefixed_Name(schema1, "serviceArea") |> PrefixedName
    /// <summary>
    ///   <para>schema1:arrivalPlatform</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The platform where the train arrives.</para>
    /// labels<para>arrivalPlatform</para></remarks>
    /// <seealso href="http://schema.org/arrivalPlatform">http://schema.org/arrivalPlatform</seealso>
    let arrivalPlatform = Prefixed_Name(schema1, "arrivalPlatform") |> PrefixedName
    /// <summary>
    ///   <para>schema1:arrivalTerminal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Identifier of the flight's arrival terminal.</para>
    /// labels<para>arrivalTerminal</para></remarks>
    /// <seealso href="http://schema.org/arrivalTerminal">http://schema.org/arrivalTerminal</seealso>
    let arrivalTerminal = Prefixed_Name(schema1, "arrivalTerminal") |> PrefixedName
    /// <summary>
    ///   <para>schema1:artEdition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of copies when multiple copies of a piece of artwork are produced - e.g. for a limited edition of 20 prints, 'artEdition' refers to the total number of copies (in this example "20").</para>
    /// labels<para>artEdition</para></remarks>
    /// <seealso href="http://schema.org/artEdition">http://schema.org/artEdition</seealso>
    let artEdition = Prefixed_Name(schema1, "artEdition") |> PrefixedName
    /// <summary>
    ///   <para>schema1:material</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A material that something is made from, e.g. leather, wool, cotton, paper.</para>
    /// labels<para>material</para></remarks>
    /// <seealso href="http://schema.org/material">http://schema.org/material</seealso>
    let material = Prefixed_Name(schema1, "material") |> PrefixedName
    /// <summary>
    ///   <para>schema1:artform</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>e.g. Painting, Drawing, Sculpture, Print, Photograph, Assemblage, Collage, etc.</para>
    /// labels<para>artform</para></remarks>
    /// <seealso href="http://schema.org/artform">http://schema.org/artform</seealso>
    let artform = Prefixed_Name(schema1, "artform") |> PrefixedName
    /// <summary>
    ///   <para>schema1:articleSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Articles may belong to one or more 'sections' in a magazine or newspaper, such as Sports, Lifestyle, etc.</para>
    /// labels<para>articleSection</para></remarks>
    /// <seealso href="http://schema.org/articleSection">http://schema.org/articleSection</seealso>
    let articleSection = Prefixed_Name(schema1, "articleSection") |> PrefixedName
    /// <summary>
    ///   <para>schema1:assembly</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Library file name e.g., mscorlib.dll, system.web.dll.</para>
    /// labels<para>assembly</para></remarks>
    /// <seealso href="http://schema.org/assembly">http://schema.org/assembly</seealso>
    let assembly = Prefixed_Name(schema1, "assembly") |> PrefixedName

    /// <summary>
    ///   <para>schema1:executableLibraryName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Library file name e.g., mscorlib.dll, system.web.dll.</para>
    /// labels<para>executableLibraryName</para></remarks>
    /// <seealso href="http://schema.org/executableLibraryName">http://schema.org/executableLibraryName</seealso>
    let executableLibraryName =
        Prefixed_Name(schema1, "executableLibraryName") |> PrefixedName

    /// <summary>
    ///   <para>schema1:associatedArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A NewsArticle associated with the Media Object.</para>
    /// labels<para>associatedArticle</para></remarks>
    /// <seealso href="http://schema.org/associatedArticle">http://schema.org/associatedArticle</seealso>
    let associatedArticle = Prefixed_Name(schema1, "associatedArticle") |> PrefixedName
    /// <summary>
    ///   <para>schema1:associatedMedia</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A media object that encodes this CreativeWork. This property is a synonym for encoding.</para>
    /// labels<para>associatedMedia</para></remarks>
    /// <seealso href="http://schema.org/associatedMedia">http://schema.org/associatedMedia</seealso>
    let associatedMedia = Prefixed_Name(schema1, "associatedMedia") |> PrefixedName
    /// <summary>
    ///   <para>schema1:attendees</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A person attending the event.</para>
    /// labels<para>attendees</para></remarks>
    /// <seealso href="http://schema.org/attendees">http://schema.org/attendees</seealso>
    let attendees = Prefixed_Name(schema1, "attendees") |> PrefixedName
    /// <summary>
    ///   <para>schema1:audience</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An intended audience, i.e. a group for whom something was created.</para>
    /// labels<para>audience</para></remarks>
    /// <seealso href="http://schema.org/audience">http://schema.org/audience</seealso>
    let audience = Prefixed_Name(schema1, "audience") |> PrefixedName
    /// <summary>
    ///   <para>schema1:authenticator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Organization responsible for authenticating the user's subscription. For example, many media apps require a cable/satellite provider to authenticate your subscription before playing media.</para>
    /// labels<para>authenticator</para></remarks>
    /// <seealso href="http://schema.org/authenticator">http://schema.org/authenticator</seealso>
    let authenticator = Prefixed_Name(schema1, "authenticator") |> PrefixedName

    /// <summary>
    ///   <para>schema1:availabilityStarts</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The beginning of the availability of the product or service included in the offer.</para>
    /// labels<para>availabilityStarts</para></remarks>
    /// <seealso href="http://schema.org/availabilityStarts">http://schema.org/availabilityStarts</seealso>
    let availabilityStarts =
        Prefixed_Name(schema1, "availabilityStarts") |> PrefixedName

    /// <summary>
    ///   <para>schema1:availableAtOrFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The place(s) from which the offer can be obtained (e.g. store locations).</para>
    /// labels<para>availableAtOrFrom</para></remarks>
    /// <seealso href="http://schema.org/availableAtOrFrom">http://schema.org/availableAtOrFrom</seealso>
    let availableAtOrFrom = Prefixed_Name(schema1, "availableAtOrFrom") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Audiobook</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schema.org/Audiobook">http://schema.org/Audiobook</seealso>
    let Audiobook = Prefixed_Name(schema1, "Audiobook") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Schedule</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schema.org/Schedule">http://schema.org/Schedule</seealso>
    let Schedule = Prefixed_Name(schema1, "Schedule") |> PrefixedName

    /// <summary>
    ///   <para>schema1:lodgingUnitDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A full description of the lodging unit.</para>
    /// labels<para>lodgingUnitDescription</para></remarks>
    /// <seealso href="http://schema.org/lodgingUnitDescription">http://schema.org/lodgingUnitDescription</seealso>
    let lodgingUnitDescription =
        Prefixed_Name(schema1, "lodgingUnitDescription") |> PrefixedName

    /// <summary>
    ///   <para>schema1:OrganizeAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of manipulating/administering/supervising/controlling one or more objects.</para>
    /// labels<para>OrganizeAction</para></remarks>
    /// <seealso href="http://schema.org/OrganizeAction">http://schema.org/OrganizeAction</seealso>
    let OrganizeAction = Prefixed_Name(schema1, "OrganizeAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:AnimalShelter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Animal shelter.</para>
    /// labels<para>AnimalShelter</para></remarks>
    /// <seealso href="http://schema.org/AnimalShelter">http://schema.org/AnimalShelter</seealso>
    let AnimalShelter = Prefixed_Name(schema1, "AnimalShelter") |> PrefixedName
    /// <summary>
    ///   <para>schema1:LocalBusiness</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A particular physical business or branch of an organization. Examples of LocalBusiness include a restaurant, a particular branch of a restaurant chain, a branch of a bank, a medical practice, a club, a bowling alley, etc.</para>
    /// labels<para>LocalBusiness</para></remarks>
    /// <seealso href="http://schema.org/LocalBusiness">http://schema.org/LocalBusiness</seealso>
    let LocalBusiness = Prefixed_Name(schema1, "LocalBusiness") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Apartment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An apartment (in American English) or flat (in British English) is a self-contained housing unit (a type of residential real estate) that occupies only part of a building (Source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Apartment"&gt;http://en.wikipedia.org/wiki/Apartment&lt;/a&gt;).</para>
    /// labels<para>Apartment</para></remarks>
    /// <seealso href="http://schema.org/Apartment">http://schema.org/Apartment</seealso>
    let Apartment = Prefixed_Name(schema1, "Apartment") |> PrefixedName
    /// <summary>
    ///   <para>schema1:AppendAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of inserting at the end if an ordered collection.</para>
    /// labels<para>AppendAction</para></remarks>
    /// <seealso href="http://schema.org/AppendAction">http://schema.org/AppendAction</seealso>
    let AppendAction = Prefixed_Name(schema1, "AppendAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:UseAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of applying an object to its intended purpose.</para>
    /// labels<para>UseAction</para></remarks>
    /// <seealso href="http://schema.org/UseAction">http://schema.org/UseAction</seealso>
    let UseAction = Prefixed_Name(schema1, "UseAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:bookingAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>'bookingAgent' is an out-dated term indicating a 'broker' that serves as a booking agent.</para>
    /// labels<para>bookingAgent</para></remarks>
    /// <seealso href="http://schema.org/bookingAgent">http://schema.org/bookingAgent</seealso>
    let bookingAgent = Prefixed_Name(schema1, "bookingAgent") |> PrefixedName
    /// <summary>
    ///   <para>schema1:serviceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The type of service being offered, e.g. veterans' benefits, emergency relief, etc.</para>
    /// labels<para>serviceType</para></remarks>
    /// <seealso href="http://schema.org/serviceType">http://schema.org/serviceType</seealso>
    let serviceType = Prefixed_Name(schema1, "serviceType") |> PrefixedName
    /// <summary>
    ///   <para>schema1:AmusementPark</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An amusement park.</para>
    /// labels<para>AmusementPark</para></remarks>
    /// <seealso href="http://schema.org/AmusementPark">http://schema.org/AmusementPark</seealso>
    let AmusementPark = Prefixed_Name(schema1, "AmusementPark") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Answer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An answer offered to a question; perhaps correct, perhaps opinionated or wrong.</para>
    /// labels<para>Answer</para></remarks>
    /// <seealso href="http://schema.org/Answer">http://schema.org/Answer</seealso>
    let Answer = Prefixed_Name(schema1, "Answer") |> PrefixedName
    /// <summary>
    ///   <para>schema1:HowToDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A direction indicating a single action to do in the instructions for how to achieve a result.</para>
    /// labels<para>HowToDirection</para></remarks>
    /// <seealso href="http://schema.org/HowToDirection">http://schema.org/HowToDirection</seealso>
    let HowToDirection = Prefixed_Name(schema1, "HowToDirection") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ListItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An list item, e.g. a step in a checklist or how-to description.</para>
    /// labels<para>ListItem</para></remarks>
    /// <seealso href="http://schema.org/ListItem">http://schema.org/ListItem</seealso>
    let ListItem = Prefixed_Name(schema1, "ListItem") |> PrefixedName
    /// <summary>
    ///   <para>schema1:HowToItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An item used as either a tool or supply when performing the instructions for how to to achieve a result.</para>
    /// labels<para>HowToItem</para></remarks>
    /// <seealso href="http://schema.org/HowToItem">http://schema.org/HowToItem</seealso>
    let HowToItem = Prefixed_Name(schema1, "HowToItem") |> PrefixedName
    /// <summary>
    ///   <para>schema1:TrainStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A train station.</para>
    /// labels<para>TrainStation</para></remarks>
    /// <seealso href="http://schema.org/TrainStation">http://schema.org/TrainStation</seealso>
    let TrainStation = Prefixed_Name(schema1, "TrainStation") |> PrefixedName
    /// <summary>
    ///   <para>schema1:TravelAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of traveling from an fromLocation to a destination by a specified mode of transport, optionally with participants.</para>
    /// labels<para>TravelAction</para></remarks>
    /// <seealso href="http://schema.org/TravelAction">http://schema.org/TravelAction</seealso>
    let TravelAction = Prefixed_Name(schema1, "TravelAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:eligibleDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The duration for which the given offer is valid.</para>
    /// labels<para>eligibleDuration</para></remarks>
    /// <seealso href="http://schema.org/eligibleDuration">http://schema.org/eligibleDuration</seealso>
    let eligibleDuration = Prefixed_Name(schema1, "eligibleDuration") |> PrefixedName
    /// <summary>
    ///   <para>schema1:eligibleQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The interval and unit of measurement of ordering quantities for which the offer or price specification is valid. This allows e.g. specifying that a certain freight charge is valid only for a certain quantity.</para>
    /// labels<para>eligibleQuantity</para></remarks>
    /// <seealso href="http://schema.org/eligibleQuantity">http://schema.org/eligibleQuantity</seealso>
    let eligibleQuantity = Prefixed_Name(schema1, "eligibleQuantity") |> PrefixedName
    /// <summary>
    ///   <para>schema1:servicePhone</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The phone number to use to access the service.</para>
    /// labels<para>servicePhone</para></remarks>
    /// <seealso href="http://schema.org/servicePhone">http://schema.org/servicePhone</seealso>
    let servicePhone = Prefixed_Name(schema1, "servicePhone") |> PrefixedName
    /// <summary>
    ///   <para>schema1:serviceSmsNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number to access the service by text message.</para>
    /// labels<para>serviceSmsNumber</para></remarks>
    /// <seealso href="http://schema.org/serviceSmsNumber">http://schema.org/serviceSmsNumber</seealso>
    let serviceSmsNumber = Prefixed_Name(schema1, "serviceSmsNumber") |> PrefixedName
    /// <summary>
    ///   <para>schema1:serviceUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The website to access the service.</para>
    /// labels<para>serviceUrl</para></remarks>
    /// <seealso href="http://schema.org/serviceUrl">http://schema.org/serviceUrl</seealso>
    let serviceUrl = Prefixed_Name(schema1, "serviceUrl") |> PrefixedName
    /// <summary>
    ///   <para>schema1:servingSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The serving size, in terms of the number of volume or mass.</para>
    /// labels<para>servingSize</para></remarks>
    /// <seealso href="http://schema.org/servingSize">http://schema.org/servingSize</seealso>
    let servingSize = Prefixed_Name(schema1, "servingSize") |> PrefixedName
    /// <summary>
    ///   <para>schema1:sibling</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sibling of the person.</para>
    /// labels<para>sibling</para></remarks>
    /// <seealso href="http://schema.org/sibling">http://schema.org/sibling</seealso>
    let sibling = Prefixed_Name(schema1, "sibling") |> PrefixedName
    /// <summary>
    ///   <para>schema1:significantLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>One of the more significant URLs on the page. Typically, these are the non-navigation links that are clicked on the most.</para>
    /// labels<para>significantLink</para></remarks>
    /// <seealso href="http://schema.org/significantLink">http://schema.org/significantLink</seealso>
    let significantLink = Prefixed_Name(schema1, "significantLink") |> PrefixedName
    /// <summary>
    ///   <para>schema1:significantLinks</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The most significant URLs on the page. Typically, these are the non-navigation links that are clicked on the most.</para>
    /// labels<para>significantLinks</para></remarks>
    /// <seealso href="http://schema.org/significantLinks">http://schema.org/significantLinks</seealso>
    let significantLinks = Prefixed_Name(schema1, "significantLinks") |> PrefixedName
    /// <summary>
    ///   <para>schema1:skills</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A statement of knowledge, skill, ability, task or any other assertion expressing a competency that is desired or required to fulfill this role or to work in this occupation.</para>
    /// labels<para>skills</para></remarks>
    /// <seealso href="http://schema.org/skills">http://schema.org/skills</seealso>
    let skills = Prefixed_Name(schema1, "skills") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Comment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A comment on an item - for example, a comment on a blog post. The comment's content is expressed via the &lt;a class="localLink" href="http://schema.org/text"&gt;text&lt;/a&gt; property, and its topic via &lt;a class="localLink" href="http://schema.org/about"&gt;about&lt;/a&gt;, properties shared with all CreativeWorks.</para>
    /// labels<para>Comment</para></remarks>
    /// <seealso href="http://schema.org/Comment">http://schema.org/Comment</seealso>
    let Comment = Prefixed_Name(schema1, "Comment") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ApartmentComplex</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Residence type: Apartment complex.</para>
    /// labels<para>ApartmentComplex</para></remarks>
    /// <seealso href="http://schema.org/ApartmentComplex">http://schema.org/ApartmentComplex</seealso>
    let ApartmentComplex = Prefixed_Name(schema1, "ApartmentComplex") |> PrefixedName
    /// <summary>
    ///   <para>schema1:InsertAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of adding at a specific location in an ordered collection.</para>
    /// labels<para>InsertAction</para></remarks>
    /// <seealso href="http://schema.org/InsertAction">http://schema.org/InsertAction</seealso>
    let InsertAction = Prefixed_Name(schema1, "InsertAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ArriveAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of arriving at a place. An agent arrives at a destination from a fromLocation, optionally with participants.</para>
    /// labels<para>ArriveAction</para></remarks>
    /// <seealso href="http://schema.org/ArriveAction">http://schema.org/ArriveAction</seealso>
    let ArriveAction = Prefixed_Name(schema1, "ArriveAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:AskAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of posing a question / favor to someone.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ReplyAction"&gt;ReplyAction&lt;/a&gt;: Appears generally as a response to AskAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>AskAction</para></remarks>
    /// <seealso href="http://schema.org/AskAction">http://schema.org/AskAction</seealso>
    let AskAction = Prefixed_Name(schema1, "AskAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:AssessAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of forming one's opinion, reaction or sentiment.</para>
    /// labels<para>AssessAction</para></remarks>
    /// <seealso href="http://schema.org/AssessAction">http://schema.org/AssessAction</seealso>
    let AssessAction = Prefixed_Name(schema1, "AssessAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Attorney</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Professional service: Attorney. &lt;br/&gt;&lt;br/&gt;
    ///
    /// This type is deprecated - &lt;a class="localLink" href="http://schema.org/LegalService"&gt;LegalService&lt;/a&gt; is more inclusive and less ambiguous.</para>
    /// labels<para>Attorney</para></remarks>
    /// <seealso href="http://schema.org/Attorney">http://schema.org/Attorney</seealso>
    let Attorney = Prefixed_Name(schema1, "Attorney") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Audience</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Intended audience for an item, i.e. the group for whom the item was created.</para>
    /// labels<para>Audience</para></remarks>
    /// <seealso href="http://schema.org/Audience">http://schema.org/Audience</seealso>
    let Audience = Prefixed_Name(schema1, "Audience") |> PrefixedName
    /// <summary>
    ///   <para>schema1:AudiobookFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:BookFormatType</para>
    ///   <para>Book format: Audiobook. This is an enumerated value for use with the bookFormat property. There is also a type 'Audiobook' in the bib extension which includes Audiobook specific properties.</para>
    /// labels<para>AudiobookFormat</para></remarks>
    /// <seealso href="http://schema.org/AudiobookFormat">http://schema.org/AudiobookFormat</seealso>
    let AudiobookFormat = Prefixed_Name(schema1, "AudiobookFormat") |> PrefixedName
    /// <summary>
    ///   <para>schema1:BookFormatType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The publication format of the book.</para>
    /// labels<para>BookFormatType</para></remarks>
    /// <seealso href="http://schema.org/BookFormatType">http://schema.org/BookFormatType</seealso>
    let BookFormatType = Prefixed_Name(schema1, "BookFormatType") |> PrefixedName
    /// <summary>
    ///   <para>schema1:AutoBodyShop</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Auto body shop.</para>
    /// labels<para>AutoBodyShop</para></remarks>
    /// <seealso href="http://schema.org/AutoBodyShop">http://schema.org/AutoBodyShop</seealso>
    let AutoBodyShop = Prefixed_Name(schema1, "AutoBodyShop") |> PrefixedName
    /// <summary>
    ///   <para>schema1:AutoPartsStore</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An auto parts store.</para>
    /// labels<para>AutoPartsStore</para></remarks>
    /// <seealso href="http://schema.org/AutoPartsStore">http://schema.org/AutoPartsStore</seealso>
    let AutoPartsStore = Prefixed_Name(schema1, "AutoPartsStore") |> PrefixedName
    /// <summary>
    ///   <para>schema1:AutoRepair</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Car repair business.</para>
    /// labels<para>AutoRepair</para></remarks>
    /// <seealso href="http://schema.org/AutoRepair">http://schema.org/AutoRepair</seealso>
    let AutoRepair = Prefixed_Name(schema1, "AutoRepair") |> PrefixedName
    /// <summary>
    ///   <para>schema1:AutomatedTeller</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>ATM/cash machine.</para>
    /// labels<para>AutomatedTeller</para></remarks>
    /// <seealso href="http://schema.org/AutomatedTeller">http://schema.org/AutomatedTeller</seealso>
    let AutomatedTeller = Prefixed_Name(schema1, "AutomatedTeller") |> PrefixedName
    /// <summary>
    ///   <para>schema1:FoodEstablishment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A food-related business.</para>
    /// labels<para>FoodEstablishment</para></remarks>
    /// <seealso href="http://schema.org/FoodEstablishment">http://schema.org/FoodEstablishment</seealso>
    let FoodEstablishment = Prefixed_Name(schema1, "FoodEstablishment") |> PrefixedName
    /// <summary>
    ///   <para>schema1:BankAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A product or service offered by a bank whereby one may deposit, withdraw or transfer money and in some cases be paid interest.</para>
    /// labels<para>BankAccount</para></remarks>
    /// <seealso href="http://schema.org/BankAccount">http://schema.org/BankAccount</seealso>
    let BankAccount = Prefixed_Name(schema1, "BankAccount") |> PrefixedName
    /// <summary>
    ///   <para>schema1:FinancialProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A product provided to consumers and businesses by financial institutions such as banks, insurance companies, brokerage firms, consumer finance companies, and investment companies which comprise the financial services industry.</para>
    /// labels<para>FinancialProduct</para></remarks>
    /// <seealso href="http://schema.org/FinancialProduct">http://schema.org/FinancialProduct</seealso>
    let FinancialProduct = Prefixed_Name(schema1, "FinancialProduct") |> PrefixedName
    /// <summary>
    ///   <para>schema1:BankOrCreditUnion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Bank or credit union.</para>
    /// labels<para>BankOrCreditUnion</para></remarks>
    /// <seealso href="http://schema.org/BankOrCreditUnion">http://schema.org/BankOrCreditUnion</seealso>
    let BankOrCreditUnion = Prefixed_Name(schema1, "BankOrCreditUnion") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Barcode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An image of a visual machine-readable code such as a barcode or QR code.</para>
    /// labels<para>Barcode</para></remarks>
    /// <seealso href="http://schema.org/Barcode">http://schema.org/Barcode</seealso>
    let Barcode = Prefixed_Name(schema1, "Barcode") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ImageObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An image file.</para>
    /// labels<para>ImageObject</para></remarks>
    /// <seealso href="http://schema.org/ImageObject">http://schema.org/ImageObject</seealso>
    let ImageObject = Prefixed_Name(schema1, "ImageObject") |> PrefixedName

    /// <summary>
    ///   <para>schema1:HealthAndBeautyBusiness</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Health and beauty.</para>
    /// labels<para>HealthAndBeautyBusiness</para></remarks>
    /// <seealso href="http://schema.org/HealthAndBeautyBusiness">http://schema.org/HealthAndBeautyBusiness</seealso>
    let HealthAndBeautyBusiness =
        Prefixed_Name(schema1, "HealthAndBeautyBusiness") |> PrefixedName

    /// <summary>
    ///   <para>schema1:BedAndBreakfast</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Bed and breakfast.
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.</para>
    /// labels<para>BedAndBreakfast</para></remarks>
    /// <seealso href="http://schema.org/BedAndBreakfast">http://schema.org/BedAndBreakfast</seealso>
    let BedAndBreakfast = Prefixed_Name(schema1, "BedAndBreakfast") |> PrefixedName
    /// <summary>
    ///   <para>schema1:LowFatDiet</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:RestrictedDiet</para>
    ///   <para>A diet focused on reduced fat and cholesterol intake.</para>
    /// labels<para>LowFatDiet</para></remarks>
    /// <seealso href="http://schema.org/LowFatDiet">http://schema.org/LowFatDiet</seealso>
    let LowFatDiet = Prefixed_Name(schema1, "LowFatDiet") |> PrefixedName
    /// <summary>
    ///   <para>schema1:LowLactoseDiet</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:RestrictedDiet</para>
    ///   <para>A diet appropriate for people with lactose intolerance.</para>
    /// labels<para>LowLactoseDiet</para></remarks>
    /// <seealso href="http://schema.org/LowLactoseDiet">http://schema.org/LowLactoseDiet</seealso>
    let LowLactoseDiet = Prefixed_Name(schema1, "LowLactoseDiet") |> PrefixedName
    /// <summary>
    ///   <para>schema1:MapCategoryType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An enumeration of several kinds of Map.</para>
    /// labels<para>MapCategoryType</para></remarks>
    /// <seealso href="http://schema.org/MapCategoryType">http://schema.org/MapCategoryType</seealso>
    let MapCategoryType = Prefixed_Name(schema1, "MapCategoryType") |> PrefixedName
    /// <summary>
    ///   <para>schema1:MarryAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of marrying a person.</para>
    /// labels<para>MarryAction</para></remarks>
    /// <seealso href="http://schema.org/MarryAction">http://schema.org/MarryAction</seealso>
    let MarryAction = Prefixed_Name(schema1, "MarryAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Mass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Properties that take Mass as values are of the form '&amp;lt;Number&amp;gt; &amp;lt;Mass unit of measure&amp;gt;'. E.g., '7 kg'.</para>
    /// labels<para>Mass</para></remarks>
    /// <seealso href="http://schema.org/Mass">http://schema.org/Mass</seealso>
    let Mass = Prefixed_Name(schema1, "Mass") |> PrefixedName
    /// <summary>
    ///   <para>schema1:MediaSubscription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A subscription which allows a user to access media including audio, video, books, etc.</para>
    /// labels<para>MediaSubscription</para></remarks>
    /// <seealso href="http://schema.org/MediaSubscription">http://schema.org/MediaSubscription</seealso>
    let MediaSubscription = Prefixed_Name(schema1, "MediaSubscription") |> PrefixedName
    /// <summary>
    ///   <para>schema1:MensClothingStore</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A men's clothing store.</para>
    /// labels<para>MensClothingStore</para></remarks>
    /// <seealso href="http://schema.org/MensClothingStore">http://schema.org/MensClothingStore</seealso>
    let MensClothingStore = Prefixed_Name(schema1, "MensClothingStore") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Menu</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A structured representation of food or drink items available from a FoodEstablishment.</para>
    /// labels<para>Menu</para></remarks>
    /// <seealso href="http://schema.org/Menu">http://schema.org/Menu</seealso>
    let Menu = Prefixed_Name(schema1, "Menu") |> PrefixedName
    /// <summary>
    ///   <para>schema1:MenuItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A food or drink item listed in a menu or menu section.</para>
    /// labels<para>MenuItem</para></remarks>
    /// <seealso href="http://schema.org/MenuItem">http://schema.org/MenuItem</seealso>
    let MenuItem = Prefixed_Name(schema1, "MenuItem") |> PrefixedName
    /// <summary>
    ///   <para>schema1:MiddleSchool</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A middle school (typically for children aged around 11-14, although this varies somewhat).</para>
    /// labels<para>MiddleSchool</para></remarks>
    /// <seealso href="http://schema.org/MiddleSchool">http://schema.org/MiddleSchool</seealso>
    let MiddleSchool = Prefixed_Name(schema1, "MiddleSchool") |> PrefixedName
    /// <summary>
    ///   <para>schema1:MixtapeAlbum</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:MusicAlbumProductionType</para>
    ///   <para>MixtapeAlbum.</para>
    /// labels<para>MixtapeAlbum</para></remarks>
    /// <seealso href="http://schema.org/MixtapeAlbum">http://schema.org/MixtapeAlbum</seealso>
    let MixtapeAlbum = Prefixed_Name(schema1, "MixtapeAlbum") |> PrefixedName

    /// <summary>
    ///   <para>schema1:SoftwareApplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A software application.</para>
    /// labels<para>SoftwareApplication</para></remarks>
    /// <seealso href="http://schema.org/SoftwareApplication">http://schema.org/SoftwareApplication</seealso>
    let SoftwareApplication =
        Prefixed_Name(schema1, "SoftwareApplication") |> PrefixedName

    /// <summary>
    ///   <para>schema1:MobilePhoneStore</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A store that sells mobile phones and related accessories.</para>
    /// labels<para>MobilePhoneStore</para></remarks>
    /// <seealso href="http://schema.org/MobilePhoneStore">http://schema.org/MobilePhoneStore</seealso>
    let MobilePhoneStore = Prefixed_Name(schema1, "MobilePhoneStore") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Monday</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:DayOfWeek</para>
    ///   <para>The day of the week between Sunday and Tuesday.</para>
    /// labels<para>Monday</para></remarks>
    /// <seealso href="http://schema.org/Monday">http://schema.org/Monday</seealso>
    let Monday = Prefixed_Name(schema1, "Monday") |> PrefixedName

    /// <summary>
    ///   <para>schema1:QuantitativeValueDistribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A statistical distribution of values.</para>
    /// labels<para>QuantitativeValueDistribution</para></remarks>
    /// <seealso href="http://schema.org/QuantitativeValueDistribution">http://schema.org/QuantitativeValueDistribution</seealso>
    let QuantitativeValueDistribution =
        Prefixed_Name(schema1, "QuantitativeValueDistribution") |> PrefixedName

    /// <summary>
    ///   <para>schema1:Mosque</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A mosque.</para>
    /// labels<para>Mosque</para></remarks>
    /// <seealso href="http://schema.org/Mosque">http://schema.org/Mosque</seealso>
    let Mosque = Prefixed_Name(schema1, "Mosque") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Motel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A motel.
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.</para>
    /// labels<para>Motel</para></remarks>
    /// <seealso href="http://schema.org/Motel">http://schema.org/Motel</seealso>
    let Motel = Prefixed_Name(schema1, "Motel") |> PrefixedName
    /// <summary>
    ///   <para>schema1:MotorcycleRepair</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A motorcycle repair shop.</para>
    /// labels<para>MotorcycleRepair</para></remarks>
    /// <seealso href="http://schema.org/MotorcycleRepair">http://schema.org/MotorcycleRepair</seealso>
    let MotorcycleRepair = Prefixed_Name(schema1, "MotorcycleRepair") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Mountain</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A mountain, like Mount Whitney or Mount Everest.</para>
    /// labels<para>Mountain</para></remarks>
    /// <seealso href="http://schema.org/Mountain">http://schema.org/Mountain</seealso>
    let Mountain = Prefixed_Name(schema1, "Mountain") |> PrefixedName

    /// <summary>
    ///   <para>schema1:SiteNavigationElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A navigation element of the page.</para>
    /// labels<para>SiteNavigationElement</para></remarks>
    /// <seealso href="http://schema.org/SiteNavigationElement">http://schema.org/SiteNavigationElement</seealso>
    let SiteNavigationElement =
        Prefixed_Name(schema1, "SiteNavigationElement") |> PrefixedName

    /// <summary>
    ///   <para>schema1:WebPageElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A web page element, like a table or an image.</para>
    /// labels<para>WebPageElement</para></remarks>
    /// <seealso href="http://schema.org/WebPageElement">http://schema.org/WebPageElement</seealso>
    let WebPageElement = Prefixed_Name(schema1, "WebPageElement") |> PrefixedName
    /// <summary>
    ///   <para>schema1:SkiResort</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A ski resort.</para>
    /// labels<para>SkiResort</para></remarks>
    /// <seealso href="http://schema.org/SkiResort">http://schema.org/SkiResort</seealso>
    let SkiResort = Prefixed_Name(schema1, "SkiResort") |> PrefixedName
    /// <summary>
    ///   <para>schema1:SocialEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Event type: Social event.</para>
    /// labels<para>SocialEvent</para></remarks>
    /// <seealso href="http://schema.org/SocialEvent">http://schema.org/SocialEvent</seealso>
    let SocialEvent = Prefixed_Name(schema1, "SocialEvent") |> PrefixedName
    /// <summary>
    ///   <para>schema1:SoldOut</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:ItemAvailability</para>
    ///   <para>Indicates that the item has sold out.</para>
    /// labels<para>SoldOut</para></remarks>
    /// <seealso href="http://schema.org/SoldOut">http://schema.org/SoldOut</seealso>
    let SoldOut = Prefixed_Name(schema1, "SoldOut") |> PrefixedName
    /// <summary>
    ///   <para>schema1:SoundtrackAlbum</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:MusicAlbumProductionType</para>
    ///   <para>SoundtrackAlbum.</para>
    /// labels<para>SoundtrackAlbum</para></remarks>
    /// <seealso href="http://schema.org/SoundtrackAlbum">http://schema.org/SoundtrackAlbum</seealso>
    let SoundtrackAlbum = Prefixed_Name(schema1, "SoundtrackAlbum") |> PrefixedName

    /// <summary>
    ///   <para>schema1:SpeakableSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SpeakableSpecification indicates (typically via &lt;a class="localLink" href="http://schema.org/xpath"&gt;xpath&lt;/a&gt; or &lt;a class="localLink" href="http://schema.org/cssSelector"&gt;cssSelector&lt;/a&gt;) sections of a document that are highlighted as particularly &lt;a class="localLink" href="http://schema.org/speakable"&gt;speakable&lt;/a&gt;. Instances of this type are expected to be used primarily as values of the &lt;a class="localLink" href="http://schema.org/speakable"&gt;speakable&lt;/a&gt; property.</para>
    /// labels<para>SpeakableSpecification</para></remarks>
    /// <seealso href="http://schema.org/SpeakableSpecification">http://schema.org/SpeakableSpecification</seealso>
    let SpeakableSpecification =
        Prefixed_Name(schema1, "SpeakableSpecification") |> PrefixedName

    /// <summary>
    ///   <para>schema1:Specialty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Any branch of a field in which people typically develop specific expertise, usually after significant study, time, and effort.</para>
    /// labels<para>Specialty</para></remarks>
    /// <seealso href="http://schema.org/Specialty">http://schema.org/Specialty</seealso>
    let Specialty = Prefixed_Name(schema1, "Specialty") |> PrefixedName
    /// <summary>
    ///   <para>schema1:SpokenWordAlbum</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:MusicAlbumProductionType</para>
    ///   <para>SpokenWordAlbum.</para>
    /// labels<para>SpokenWordAlbum</para></remarks>
    /// <seealso href="http://schema.org/SpokenWordAlbum">http://schema.org/SpokenWordAlbum</seealso>
    let SpokenWordAlbum = Prefixed_Name(schema1, "SpokenWordAlbum") |> PrefixedName

    /// <summary>
    ///   <para>schema1:SportingGoodsStore</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A sporting goods store.</para>
    /// labels<para>SportingGoodsStore</para></remarks>
    /// <seealso href="http://schema.org/SportingGoodsStore">http://schema.org/SportingGoodsStore</seealso>
    let SportingGoodsStore =
        Prefixed_Name(schema1, "SportingGoodsStore") |> PrefixedName

    /// <summary>
    ///   <para>schema1:partOfTVSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The TV series to which this episode or season belongs.</para>
    /// labels<para>partOfTVSeries</para></remarks>
    /// <seealso href="http://schema.org/partOfTVSeries">http://schema.org/partOfTVSeries</seealso>
    let partOfTVSeries = Prefixed_Name(schema1, "partOfTVSeries") |> PrefixedName
    /// <summary>
    ///   <para>schema1:partySize</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Number of people the reservation should accommodate.</para>
    /// labels<para>partySize</para></remarks>
    /// <seealso href="http://schema.org/partySize">http://schema.org/partySize</seealso>
    let partySize = Prefixed_Name(schema1, "partySize") |> PrefixedName

    /// <summary>
    ///   <para>schema1:passengerPriorityStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The priority status assigned to a passenger for security or boarding (e.g. FastTrack or Priority).</para>
    /// labels<para>passengerPriorityStatus</para></remarks>
    /// <seealso href="http://schema.org/passengerPriorityStatus">http://schema.org/passengerPriorityStatus</seealso>
    let passengerPriorityStatus =
        Prefixed_Name(schema1, "passengerPriorityStatus") |> PrefixedName

    /// <summary>
    ///   <para>schema1:passengerSequenceNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The passenger's sequence number as assigned by the airline.</para>
    /// labels<para>passengerSequenceNumber</para></remarks>
    /// <seealso href="http://schema.org/passengerSequenceNumber">http://schema.org/passengerSequenceNumber</seealso>
    let passengerSequenceNumber =
        Prefixed_Name(schema1, "passengerSequenceNumber") |> PrefixedName

    /// <summary>
    ///   <para>schema1:trackingNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Shipper tracking number.</para>
    /// labels<para>trackingNumber</para></remarks>
    /// <seealso href="http://schema.org/trackingNumber">http://schema.org/trackingNumber</seealso>
    let trackingNumber = Prefixed_Name(schema1, "trackingNumber") |> PrefixedName
    /// <summary>
    ///   <para>schema1:trackingUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Tracking url for the parcel delivery.</para>
    /// labels<para>trackingUrl</para></remarks>
    /// <seealso href="http://schema.org/trackingUrl">http://schema.org/trackingUrl</seealso>
    let trackingUrl = Prefixed_Name(schema1, "trackingUrl") |> PrefixedName
    /// <summary>
    ///   <para>schema1:tracks</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A music recording (track)&amp;#x2014;usually a single song.</para>
    /// labels<para>tracks</para></remarks>
    /// <seealso href="http://schema.org/tracks">http://schema.org/tracks</seealso>
    let tracks = Prefixed_Name(schema1, "tracks") |> PrefixedName
    /// <summary>
    ///   <para>schema1:trailer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The trailer of a movie or tv/radio series, season, episode, etc.</para>
    /// labels<para>trailer</para></remarks>
    /// <seealso href="http://schema.org/trailer">http://schema.org/trailer</seealso>
    let trailer = Prefixed_Name(schema1, "trailer") |> PrefixedName
    /// <summary>
    ///   <para>schema1:trainName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The name of the train (e.g. The Orient Express).</para>
    /// labels<para>trainName</para></remarks>
    /// <seealso href="http://schema.org/trainName">http://schema.org/trainName</seealso>
    let trainName = Prefixed_Name(schema1, "trainName") |> PrefixedName
    /// <summary>
    ///   <para>schema1:trainNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The unique identifier for the train.</para>
    /// labels<para>trainNumber</para></remarks>
    /// <seealso href="http://schema.org/trainNumber">http://schema.org/trainNumber</seealso>
    let trainNumber = Prefixed_Name(schema1, "trainNumber") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Preschool</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A preschool.</para>
    /// labels<para>Preschool</para></remarks>
    /// <seealso href="http://schema.org/Preschool">http://schema.org/Preschool</seealso>
    let Preschool = Prefixed_Name(schema1, "Preschool") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Tuesday</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:DayOfWeek</para>
    ///   <para>The day of the week between Monday and Wednesday.</para>
    /// labels<para>Tuesday</para></remarks>
    /// <seealso href="http://schema.org/Tuesday">http://schema.org/Tuesday</seealso>
    let Tuesday = Prefixed_Name(schema1, "Tuesday") |> PrefixedName
    /// <summary>
    ///   <para>schema1:billingPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The time interval used to compute the invoice.</para>
    /// labels<para>billingPeriod</para></remarks>
    /// <seealso href="http://schema.org/billingPeriod">http://schema.org/billingPeriod</seealso>
    let billingPeriod = Prefixed_Name(schema1, "billingPeriod") |> PrefixedName
    /// <summary>
    ///   <para>schema1:mainContentOfPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates if this web page element is the main subject of the page.</para>
    /// labels<para>mainContentOfPage</para></remarks>
    /// <seealso href="http://schema.org/mainContentOfPage">http://schema.org/mainContentOfPage</seealso>
    let mainContentOfPage = Prefixed_Name(schema1, "mainContentOfPage") |> PrefixedName
    /// <summary>
    ///   <para>schema1:makesOffer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A pointer to products or services offered by the organization or person.</para>
    /// labels<para>makesOffer</para></remarks>
    /// <seealso href="http://schema.org/makesOffer">http://schema.org/makesOffer</seealso>
    let makesOffer = Prefixed_Name(schema1, "makesOffer") |> PrefixedName
    /// <summary>
    ///   <para>schema1:offeredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A pointer to the organization or person making the offer.</para>
    /// labels<para>offeredBy</para></remarks>
    /// <seealso href="http://schema.org/offeredBy">http://schema.org/offeredBy</seealso>
    let offeredBy = Prefixed_Name(schema1, "offeredBy") |> PrefixedName
    /// <summary>
    ///   <para>schema1:salaryCurrency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The currency (coded using &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217&lt;/a&gt; ) used for the main salary information in this job posting or for this employee.</para>
    /// labels<para>salaryCurrency</para></remarks>
    /// <seealso href="http://schema.org/salaryCurrency">http://schema.org/salaryCurrency</seealso>
    let salaryCurrency = Prefixed_Name(schema1, "salaryCurrency") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Residence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The place where a person lives.</para>
    /// labels<para>Residence</para></remarks>
    /// <seealso href="http://schema.org/Residence">http://schema.org/Residence</seealso>
    let Residence = Prefixed_Name(schema1, "Residence") |> PrefixedName

    /// <summary>
    ///   <para>schema1:CreativeWorkSeason</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A media season e.g. tv, radio, video game etc.</para>
    /// labels<para>CreativeWorkSeason</para></remarks>
    /// <seealso href="http://schema.org/CreativeWorkSeason">http://schema.org/CreativeWorkSeason</seealso>
    let CreativeWorkSeason =
        Prefixed_Name(schema1, "CreativeWorkSeason") |> PrefixedName

    /// <summary>
    ///   <para>schema1:QAPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A QAPage is a WebPage focussed on a specific Question and its Answer(s), e.g. in a question answering site or documenting Frequently Asked Questions (FAQs).</para>
    /// labels<para>QAPage</para></remarks>
    /// <seealso href="http://schema.org/QAPage">http://schema.org/QAPage</seealso>
    let QAPage = Prefixed_Name(schema1, "QAPage") |> PrefixedName
    /// <summary>
    ///   <para>schema1:UserPageVisits</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.</para>
    /// labels<para>UserPageVisits</para></remarks>
    /// <seealso href="http://schema.org/UserPageVisits">http://schema.org/UserPageVisits</seealso>
    let UserPageVisits = Prefixed_Name(schema1, "UserPageVisits") |> PrefixedName

    /// <summary>
    ///   <para>schema1:parentOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The larger organization that this organization is a &lt;a class="localLink" href="http://schema.org/subOrganization"&gt;subOrganization&lt;/a&gt; of, if any.</para>
    /// labels<para>parentOrganization</para></remarks>
    /// <seealso href="http://schema.org/parentOrganization">http://schema.org/parentOrganization</seealso>
    let parentOrganization =
        Prefixed_Name(schema1, "parentOrganization") |> PrefixedName

    /// <summary>
    ///   <para>schema1:menuAddOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Additional menu item(s) such as a side dish of salad or side order of fries that can be added to this menu item. Additionally it can be a menu section containing allowed add-on menu items for this menu item.</para>
    /// labels<para>menuAddOn</para></remarks>
    /// <seealso href="http://schema.org/menuAddOn">http://schema.org/menuAddOn</seealso>
    let menuAddOn = Prefixed_Name(schema1, "menuAddOn") |> PrefixedName
    /// <summary>
    ///   <para>schema1:minValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The lower value of some characteristic or property.</para>
    /// labels<para>minValue</para></remarks>
    /// <seealso href="http://schema.org/minValue">http://schema.org/minValue</seealso>
    let minValue = Prefixed_Name(schema1, "minValue") |> PrefixedName

    /// <summary>
    ///   <para>schema1:specialCommitments</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Any special commitments associated with this job posting. Valid entries include VeteranCommit, MilitarySpouseCommit, etc.</para>
    /// labels<para>specialCommitments</para></remarks>
    /// <seealso href="http://schema.org/specialCommitments">http://schema.org/specialCommitments</seealso>
    let specialCommitments =
        Prefixed_Name(schema1, "specialCommitments") |> PrefixedName

    /// <summary>
    ///   <para>schema1:specialty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>One of the domain specialities to which this web page's content applies.</para>
    /// labels<para>specialty</para></remarks>
    /// <seealso href="http://schema.org/specialty">http://schema.org/specialty</seealso>
    let specialty = Prefixed_Name(schema1, "specialty") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Grant</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schema.org/Grant">http://schema.org/Grant</seealso>
    let Grant = Prefixed_Name(schema1, "Grant") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ApplyAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of registering to an organization/service without the guarantee to receive it.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/RegisterAction"&gt;RegisterAction&lt;/a&gt;: Unlike RegisterAction, ApplyAction has no guarantees that the application will be accepted.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>ApplyAction</para></remarks>
    /// <seealso href="http://schema.org/ApplyAction">http://schema.org/ApplyAction</seealso>
    let ApplyAction = Prefixed_Name(schema1, "ApplyAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:MoveAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of an agent relocating to a place.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/TransferAction"&gt;TransferAction&lt;/a&gt;: Unlike TransferAction, the subject of the move is a living Person or Organization rather than an inanimate object.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>MoveAction</para></remarks>
    /// <seealso href="http://schema.org/MoveAction">http://schema.org/MoveAction</seealso>
    let MoveAction = Prefixed_Name(schema1, "MoveAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:DJMixAlbum</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:MusicAlbumProductionType</para>
    ///   <para>DJMixAlbum.</para>
    /// labels<para>DJMixAlbum</para></remarks>
    /// <seealso href="http://schema.org/DJMixAlbum">http://schema.org/DJMixAlbum</seealso>
    let DJMixAlbum = Prefixed_Name(schema1, "DJMixAlbum") |> PrefixedName
    /// <summary>
    ///   <para>schema1:DataCatalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A collection of datasets.</para>
    /// labels<para>DataCatalog</para></remarks>
    /// <seealso href="http://schema.org/DataCatalog">http://schema.org/DataCatalog</seealso>
    let DataCatalog = Prefixed_Name(schema1, "DataCatalog") |> PrefixedName
    /// <summary>
    ///   <para>schema1:InStoreOnly</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:ItemAvailability</para>
    ///   <para>Indicates that the item is available only at physical locations.</para>
    /// labels<para>InStoreOnly</para></remarks>
    /// <seealso href="http://schema.org/InStoreOnly">http://schema.org/InStoreOnly</seealso>
    let InStoreOnly = Prefixed_Name(schema1, "InStoreOnly") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Integer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Data type: Integer.</para>
    /// labels<para>Integer</para></remarks>
    /// <seealso href="http://schema.org/Integer">http://schema.org/Integer</seealso>
    let Integer = Prefixed_Name(schema1, "Integer") |> PrefixedName

    /// <summary>
    ///   <para>schema1:InteractionCounter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A summary of how users have interacted with this CreativeWork. In most cases, authors will use a subtype to specify the specific type of interaction.</para>
    /// labels<para>InteractionCounter</para></remarks>
    /// <seealso href="http://schema.org/InteractionCounter">http://schema.org/InteractionCounter</seealso>
    let InteractionCounter =
        Prefixed_Name(schema1, "InteractionCounter") |> PrefixedName

    /// <summary>
    ///   <para>schema1:InternetCafe</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An internet cafe.</para>
    /// labels<para>InternetCafe</para></remarks>
    /// <seealso href="http://schema.org/InternetCafe">http://schema.org/InternetCafe</seealso>
    let InternetCafe = Prefixed_Name(schema1, "InternetCafe") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Invoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A statement of the money due for goods or services; a bill.</para>
    /// labels<para>Invoice</para></remarks>
    /// <seealso href="http://schema.org/Invoice">http://schema.org/Invoice</seealso>
    let Invoice = Prefixed_Name(schema1, "Invoice") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ItemListOrderType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Enumerated for values for itemListOrder for indicating how an ordered ItemList is organized.</para>
    /// labels<para>ItemListOrderType</para></remarks>
    /// <seealso href="http://schema.org/ItemListOrderType">http://schema.org/ItemListOrderType</seealso>
    let ItemListOrderType = Prefixed_Name(schema1, "ItemListOrderType") |> PrefixedName

    /// <summary>
    ///   <para>schema1:ItemListOrderDescending</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:ItemListOrderType</para>
    ///   <para>An ItemList ordered with higher values listed first.</para>
    /// labels<para>ItemListOrderDescending</para></remarks>
    /// <seealso href="http://schema.org/ItemListOrderDescending">http://schema.org/ItemListOrderDescending</seealso>
    let ItemListOrderDescending =
        Prefixed_Name(schema1, "ItemListOrderDescending") |> PrefixedName

    /// <summary>
    ///   <para>schema1:ItemPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A page devoted to a single item, such as a particular product or hotel.</para>
    /// labels<para>ItemPage</para></remarks>
    /// <seealso href="http://schema.org/ItemPage">http://schema.org/ItemPage</seealso>
    let ItemPage = Prefixed_Name(schema1, "ItemPage") |> PrefixedName
    /// <summary>
    ///   <para>schema1:JewelryStore</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A jewelry store.</para>
    /// labels<para>JewelryStore</para></remarks>
    /// <seealso href="http://schema.org/JewelryStore">http://schema.org/JewelryStore</seealso>
    let JewelryStore = Prefixed_Name(schema1, "JewelryStore") |> PrefixedName
    /// <summary>
    ///   <para>schema1:LakeBodyOfWater</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A lake (for example, Lake Pontrachain).</para>
    /// labels<para>LakeBodyOfWater</para></remarks>
    /// <seealso href="http://schema.org/LakeBodyOfWater">http://schema.org/LakeBodyOfWater</seealso>
    let LakeBodyOfWater = Prefixed_Name(schema1, "LakeBodyOfWater") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Researcher</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Audience</para>
    ///   <para>Researchers.</para>
    /// labels<para>Researcher</para></remarks>
    /// <seealso href="http://schema.org/Researcher">http://schema.org/Researcher</seealso>
    let Researcher = Prefixed_Name(schema1, "Researcher") |> PrefixedName
    /// <summary>
    ///   <para>schema1:VoteAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of expressing a preference from a fixed/finite/structured set of choices/options.</para>
    /// labels<para>VoteAction</para></remarks>
    /// <seealso href="http://schema.org/VoteAction">http://schema.org/VoteAction</seealso>
    let VoteAction = Prefixed_Name(schema1, "VoteAction") |> PrefixedName

    /// <summary>
    ///   <para>schema1:broadcastChannelId</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The unique address by which the BroadcastService can be identified in a provider lineup. In US, this is typically a number.</para>
    /// labels<para>broadcastChannelId</para></remarks>
    /// <seealso href="http://schema.org/broadcastChannelId">http://schema.org/broadcastChannelId</seealso>
    let broadcastChannelId =
        Prefixed_Name(schema1, "broadcastChannelId") |> PrefixedName

    /// <summary>
    ///   <para>schema1:broadcastDisplayName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The name displayed in the channel guide. For many US affiliates, it is the network name.</para>
    /// labels<para>broadcastDisplayName</para></remarks>
    /// <seealso href="http://schema.org/broadcastDisplayName">http://schema.org/broadcastDisplayName</seealso>
    let broadcastDisplayName =
        Prefixed_Name(schema1, "broadcastDisplayName") |> PrefixedName

    /// <summary>
    ///   <para>schema1:broadcastFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The frequency used for over-the-air broadcasts. Numeric values or simple ranges e.g. 87-99. In addition a shortcut idiom is supported for frequences of AM and FM radio channels, e.g. "87 FM".</para>
    /// labels<para>broadcastFrequency</para></remarks>
    /// <seealso href="http://schema.org/broadcastFrequency">http://schema.org/broadcastFrequency</seealso>
    let broadcastFrequency =
        Prefixed_Name(schema1, "broadcastFrequency") |> PrefixedName

    /// <summary>
    ///   <para>schema1:broadcastFrequencyValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The frequency in MHz for a particular broadcast.</para>
    /// labels<para>broadcastFrequencyValue</para></remarks>
    /// <seealso href="http://schema.org/broadcastFrequencyValue">http://schema.org/broadcastFrequencyValue</seealso>
    let broadcastFrequencyValue =
        Prefixed_Name(schema1, "broadcastFrequencyValue") |> PrefixedName

    /// <summary>
    ///   <para>schema1:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The name of the item.</para>
    /// labels<para>name</para></remarks>
    /// <seealso href="http://schema.org/name">http://schema.org/name</seealso>
    let name = Prefixed_Name(schema1, "name") |> PrefixedName
    /// <summary>
    ///   <para>schema1:namedPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A position played, performed or filled by a person or organization, as part of an organization. For example, an athlete in a SportsTeam might play in the position named 'Quarterback'.</para>
    /// labels<para>namedPosition</para></remarks>
    /// <seealso href="http://schema.org/namedPosition">http://schema.org/namedPosition</seealso>
    let namedPosition = Prefixed_Name(schema1, "namedPosition") |> PrefixedName
    /// <summary>
    ///   <para>schema1:roleName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A role played, performed or filled by a person or organization. For example, the team of creators for a comic book might fill the roles named 'inker', 'penciller', and 'letterer'; or an athlete in a SportsTeam might play in the position named 'Quarterback'.</para>
    /// labels<para>roleName</para></remarks>
    /// <seealso href="http://schema.org/roleName">http://schema.org/roleName</seealso>
    let roleName = Prefixed_Name(schema1, "roleName") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Aquarium</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Aquarium.</para>
    /// labels<para>Aquarium</para></remarks>
    /// <seealso href="http://schema.org/Aquarium">http://schema.org/Aquarium</seealso>
    let Aquarium = Prefixed_Name(schema1, "Aquarium") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ArtGallery</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An art gallery.</para>
    /// labels<para>ArtGallery</para></remarks>
    /// <seealso href="http://schema.org/ArtGallery">http://schema.org/ArtGallery</seealso>
    let ArtGallery = Prefixed_Name(schema1, "ArtGallery") |> PrefixedName
    /// <summary>
    ///   <para>schema1:CreativeWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The most generic kind of creative work, including books, movies, photographs, software programs, etc.</para>
    /// labels<para>CreativeWork</para></remarks>
    /// <seealso href="http://schema.org/CreativeWork">http://schema.org/CreativeWork</seealso>
    let CreativeWork = Prefixed_Name(schema1, "CreativeWork") |> PrefixedName
    /// <summary>
    ///   <para>schema1:encodings</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A media object that encodes this CreativeWork.</para>
    /// labels<para>encodings</para></remarks>
    /// <seealso href="http://schema.org/encodings">http://schema.org/encodings</seealso>
    let encodings = Prefixed_Name(schema1, "encodings") |> PrefixedName
    /// <summary>
    ///   <para>schema1:maxPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The highest price if the price is a range.</para>
    /// labels<para>maxPrice</para></remarks>
    /// <seealso href="http://schema.org/maxPrice">http://schema.org/maxPrice</seealso>
    let maxPrice = Prefixed_Name(schema1, "maxPrice") |> PrefixedName

    /// <summary>
    ///   <para>schema1:servicePostalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The address for accessing the service by mail.</para>
    /// labels<para>servicePostalAddress</para></remarks>
    /// <seealso href="http://schema.org/servicePostalAddress">http://schema.org/servicePostalAddress</seealso>
    let servicePostalAddress =
        Prefixed_Name(schema1, "servicePostalAddress") |> PrefixedName

    /// <summary>
    ///   <para>schema1:sharedContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A CreativeWork such as an image, video, or audio clip shared as part of this posting.</para>
    /// labels<para>sharedContent</para></remarks>
    /// <seealso href="http://schema.org/sharedContent">http://schema.org/sharedContent</seealso>
    let sharedContent = Prefixed_Name(schema1, "sharedContent") |> PrefixedName
    /// <summary>
    ///   <para>schema1:siblings</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sibling of the person.</para>
    /// labels<para>siblings</para></remarks>
    /// <seealso href="http://schema.org/siblings">http://schema.org/siblings</seealso>
    let siblings = Prefixed_Name(schema1, "siblings") |> PrefixedName
    /// <summary>
    ///   <para>schema1:sku</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Stock Keeping Unit (SKU), i.e. a merchant-specific identifier for a product or service, or the product to which the offer refers.</para>
    /// labels<para>sku</para></remarks>
    /// <seealso href="http://schema.org/sku">http://schema.org/sku</seealso>
    let sku = Prefixed_Name(schema1, "sku") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Article</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An article, such as a news article or piece of investigative report. Newspapers and magazines have articles of many different types and this is intended to cover them all.&lt;br/&gt;&lt;br/&gt;
    ///
    /// See also &lt;a href="http://blog.schema.org/2014/09/schemaorg-support-for-bibliographic_2.html"&gt;blog post&lt;/a&gt;.</para>
    /// labels<para>Article</para></remarks>
    /// <seealso href="http://schema.org/Article">http://schema.org/Article</seealso>
    let Article = Prefixed_Name(schema1, "Article") |> PrefixedName
    /// <summary>
    ///   <para>schema1:InviteAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of asking someone to attend an event. Reciprocal of RsvpAction.</para>
    /// labels<para>InviteAction</para></remarks>
    /// <seealso href="http://schema.org/InviteAction">http://schema.org/InviteAction</seealso>
    let InviteAction = Prefixed_Name(schema1, "InviteAction") |> PrefixedName

    /// <summary>
    ///   <para>schema1:ItemListOrderAscending</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:ItemListOrderType</para>
    ///   <para>An ItemList ordered with lower values listed first.</para>
    /// labels<para>ItemListOrderAscending</para></remarks>
    /// <seealso href="http://schema.org/ItemListOrderAscending">http://schema.org/ItemListOrderAscending</seealso>
    let ItemListOrderAscending =
        Prefixed_Name(schema1, "ItemListOrderAscending") |> PrefixedName

    /// <summary>
    ///   <para>schema1:ItemListUnordered</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:ItemListOrderType</para>
    ///   <para>An ItemList ordered with no explicit order.</para>
    /// labels<para>ItemListUnordered</para></remarks>
    /// <seealso href="http://schema.org/ItemListUnordered">http://schema.org/ItemListUnordered</seealso>
    let ItemListUnordered = Prefixed_Name(schema1, "ItemListUnordered") |> PrefixedName
    /// <summary>
    ///   <para>schema1:JobPosting</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A listing that describes a job opening in a certain organization.</para>
    /// labels<para>JobPosting</para></remarks>
    /// <seealso href="http://schema.org/JobPosting">http://schema.org/JobPosting</seealso>
    let JobPosting = Prefixed_Name(schema1, "JobPosting") |> PrefixedName
    /// <summary>
    ///   <para>schema1:KosherDiet</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:RestrictedDiet</para>
    ///   <para>A diet conforming to Jewish dietary practices.</para>
    /// labels<para>KosherDiet</para></remarks>
    /// <seealso href="http://schema.org/KosherDiet">http://schema.org/KosherDiet</seealso>
    let KosherDiet = Prefixed_Name(schema1, "KosherDiet") |> PrefixedName

    /// <summary>
    ///   <para>schema1:LandmarksOrHistoricalBuildings</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An historical landmark or building.</para>
    /// labels<para>LandmarksOrHistoricalBuildings</para></remarks>
    /// <seealso href="http://schema.org/LandmarksOrHistoricalBuildings">http://schema.org/LandmarksOrHistoricalBuildings</seealso>
    let LandmarksOrHistoricalBuildings =
        Prefixed_Name(schema1, "LandmarksOrHistoricalBuildings") |> PrefixedName

    /// <summary>
    ///   <para>schema1:LaserDiscFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:MusicReleaseFormatType</para>
    ///   <para>LaserDiscFormat.</para>
    /// labels<para>LaserDiscFormat</para></remarks>
    /// <seealso href="http://schema.org/LaserDiscFormat">http://schema.org/LaserDiscFormat</seealso>
    let LaserDiscFormat = Prefixed_Name(schema1, "LaserDiscFormat") |> PrefixedName
    /// <summary>
    ///   <para>schema1:LeftHandDriving</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:SteeringPositionValue</para>
    ///   <para>The steering position is on the left side of the vehicle (viewed from the main direction of driving).</para>
    /// labels<para>LeftHandDriving</para></remarks>
    /// <seealso href="http://schema.org/LeftHandDriving">http://schema.org/LeftHandDriving</seealso>
    let LeftHandDriving = Prefixed_Name(schema1, "LeftHandDriving") |> PrefixedName

    /// <summary>
    ///   <para>schema1:SteeringPositionValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A value indicating a steering position.</para>
    /// labels<para>SteeringPositionValue</para></remarks>
    /// <seealso href="http://schema.org/SteeringPositionValue">http://schema.org/SteeringPositionValue</seealso>
    let SteeringPositionValue =
        Prefixed_Name(schema1, "SteeringPositionValue") |> PrefixedName

    /// <summary>
    ///   <para>schema1:Library</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A library.</para>
    /// labels<para>Library</para></remarks>
    /// <seealso href="http://schema.org/Library">http://schema.org/Library</seealso>
    let Library = Prefixed_Name(schema1, "Library") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ListenAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of consuming audio content.</para>
    /// labels<para>ListenAction</para></remarks>
    /// <seealso href="http://schema.org/ListenAction">http://schema.org/ListenAction</seealso>
    let ListenAction = Prefixed_Name(schema1, "ListenAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:LiveAlbum</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:MusicAlbumProductionType</para>
    ///   <para>LiveAlbum.</para>
    /// labels<para>LiveAlbum</para></remarks>
    /// <seealso href="http://schema.org/LiveAlbum">http://schema.org/LiveAlbum</seealso>
    let LiveAlbum = Prefixed_Name(schema1, "LiveAlbum") |> PrefixedName
    /// <summary>
    ///   <para>schema1:PropertyValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A property-value pair, e.g. representing a feature of a product or place. Use the 'name' property for the name of the property. If there is an additional human-readable version of the value, put that into the 'description' property.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Always use specific schema.org properties when a) they exist and b) you can populate them. Using PropertyValue as a substitute will typically not trigger the same effect as using the original, specific property.</para>
    /// labels<para>PropertyValue</para></remarks>
    /// <seealso href="http://schema.org/PropertyValue">http://schema.org/PropertyValue</seealso>
    let PropertyValue = Prefixed_Name(schema1, "PropertyValue") |> PrefixedName
    /// <summary>
    ///   <para>schema1:LockerDelivery</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A DeliveryMethod in which an item is made available via locker.</para>
    /// labels<para>LockerDelivery</para></remarks>
    /// <seealso href="http://schema.org/LockerDelivery">http://schema.org/LockerDelivery</seealso>
    let LockerDelivery = Prefixed_Name(schema1, "LockerDelivery") |> PrefixedName

    /// <summary>
    ///   <para>schema1:LodgingReservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A reservation for lodging at a hotel, motel, inn, etc.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.</para>
    /// labels<para>LodgingReservation</para></remarks>
    /// <seealso href="http://schema.org/LodgingReservation">http://schema.org/LodgingReservation</seealso>
    let LodgingReservation =
        Prefixed_Name(schema1, "LodgingReservation") |> PrefixedName

    /// <summary>
    ///   <para>schema1:LoseAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of being defeated in a competitive activity.</para>
    /// labels<para>LoseAction</para></remarks>
    /// <seealso href="http://schema.org/LoseAction">http://schema.org/LoseAction</seealso>
    let LoseAction = Prefixed_Name(schema1, "LoseAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:LowCalorieDiet</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:RestrictedDiet</para>
    ///   <para>A diet focused on reduced calorie intake.</para>
    /// labels<para>LowCalorieDiet</para></remarks>
    /// <seealso href="http://schema.org/LowCalorieDiet">http://schema.org/LowCalorieDiet</seealso>
    let LowCalorieDiet = Prefixed_Name(schema1, "LowCalorieDiet") |> PrefixedName
    /// <summary>
    ///   <para>schema1:LowSaltDiet</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:RestrictedDiet</para>
    ///   <para>A diet focused on reduced sodium intake.</para>
    /// labels<para>LowSaltDiet</para></remarks>
    /// <seealso href="http://schema.org/LowSaltDiet">http://schema.org/LowSaltDiet</seealso>
    let LowSaltDiet = Prefixed_Name(schema1, "LowSaltDiet") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Male</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:GenderType</para>
    ///   <para>The male gender.</para>
    /// labels<para>Male</para></remarks>
    /// <seealso href="http://schema.org/Male">http://schema.org/Male</seealso>
    let Male = Prefixed_Name(schema1, "Male") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Map</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A map.</para>
    /// labels<para>Map</para></remarks>
    /// <seealso href="http://schema.org/Map">http://schema.org/Map</seealso>
    let Map = Prefixed_Name(schema1, "Map") |> PrefixedName
    /// <summary>
    ///   <para>schema1:RsvpAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of notifying an event organizer as to whether you expect to attend the event.</para>
    /// labels<para>RsvpAction</para></remarks>
    /// <seealso href="http://schema.org/RsvpAction">http://schema.org/RsvpAction</seealso>
    let RsvpAction = Prefixed_Name(schema1, "RsvpAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:RsvpResponseMaybe</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:RsvpResponseType</para>
    ///   <para>The invitee may or may not attend.</para>
    /// labels<para>RsvpResponseMaybe</para></remarks>
    /// <seealso href="http://schema.org/RsvpResponseMaybe">http://schema.org/RsvpResponseMaybe</seealso>
    let RsvpResponseMaybe = Prefixed_Name(schema1, "RsvpResponseMaybe") |> PrefixedName
    /// <summary>
    ///   <para>schema1:RsvpResponseType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>RsvpResponseType is an enumeration type whose instances represent responding to an RSVP request.</para>
    /// labels<para>RsvpResponseType</para></remarks>
    /// <seealso href="http://schema.org/RsvpResponseType">http://schema.org/RsvpResponseType</seealso>
    let RsvpResponseType = Prefixed_Name(schema1, "RsvpResponseType") |> PrefixedName
    /// <summary>
    ///   <para>schema1:calories</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of calories.</para>
    /// labels<para>calories</para></remarks>
    /// <seealso href="http://schema.org/calories">http://schema.org/calories</seealso>
    let calories = Prefixed_Name(schema1, "calories") |> PrefixedName
    /// <summary>
    ///   <para>schema1:candidate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of object. The candidate subject of this action.</para>
    /// labels<para>candidate</para></remarks>
    /// <seealso href="http://schema.org/candidate">http://schema.org/candidate</seealso>
    let candidate = Prefixed_Name(schema1, "candidate") |> PrefixedName
    /// <summary>
    ///   <para>schema1:fileFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Media type, typically MIME format (see &lt;a href="http://www.iana.org/assignments/media-types/media-types.xhtml"&gt;IANA site&lt;/a&gt;) of the content e.g. application/zip of a SoftwareApplication binary. In cases where a CreativeWork has several media type representations, 'encoding' can be used to indicate each MediaObject alongside particular fileFormat information. Unregistered or niche file formats can be indicated instead via the most appropriate URL, e.g. defining Web page or a Wikipedia entry.</para>
    /// labels<para>fileFormat</para></remarks>
    /// <seealso href="http://schema.org/fileFormat">http://schema.org/fileFormat</seealso>
    let fileFormat = Prefixed_Name(schema1, "fileFormat") |> PrefixedName
    /// <summary>
    ///   <para>schema1:fileSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Size of the application / package (e.g. 18MB). In the absence of a unit (MB, KB etc.), KB will be assumed.</para>
    /// labels<para>fileSize</para></remarks>
    /// <seealso href="http://schema.org/fileSize">http://schema.org/fileSize</seealso>
    let fileSize = Prefixed_Name(schema1, "fileSize") |> PrefixedName
    /// <summary>
    ///   <para>schema1:firstPerformance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The date and place the work was first performed.</para>
    /// labels<para>firstPerformance</para></remarks>
    /// <seealso href="http://schema.org/firstPerformance">http://schema.org/firstPerformance</seealso>
    let firstPerformance = Prefixed_Name(schema1, "firstPerformance") |> PrefixedName
    /// <summary>
    ///   <para>schema1:flightNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The unique identifier for a flight including the airline IATA code. For example, if describing United flight 110, where the IATA code for United is 'UA', the flightNumber is 'UA110'.</para>
    /// labels<para>flightNumber</para></remarks>
    /// <seealso href="http://schema.org/flightNumber">http://schema.org/flightNumber</seealso>
    let flightNumber = Prefixed_Name(schema1, "flightNumber") |> PrefixedName
    /// <summary>
    ///   <para>schema1:floorSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The size of the accommodation, e.g. in square meter or squarefoot.
    /// Typical unit code(s): MTK for square meter, FTK for square foot, or YDK for square yard</para>
    /// labels<para>floorSize</para></remarks>
    /// <seealso href="http://schema.org/floorSize">http://schema.org/floorSize</seealso>
    let floorSize = Prefixed_Name(schema1, "floorSize") |> PrefixedName
    /// <summary>
    ///   <para>schema1:followee</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of object. The person or organization being followed.</para>
    /// labels<para>followee</para></remarks>
    /// <seealso href="http://schema.org/followee">http://schema.org/followee</seealso>
    let followee = Prefixed_Name(schema1, "followee") |> PrefixedName
    /// <summary>
    ///   <para>schema1:numberOfAxles</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of axles.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Typical unit code(s): C62</para>
    /// labels<para>numberOfAxles</para></remarks>
    /// <seealso href="http://schema.org/numberOfAxles">http://schema.org/numberOfAxles</seealso>
    let numberOfAxles = Prefixed_Name(schema1, "numberOfAxles") |> PrefixedName
    /// <summary>
    ///   <para>schema1:numberOfBeds</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The quantity of the given bed type available in the HotelRoom, Suite, House, or Apartment.</para>
    /// labels<para>numberOfBeds</para></remarks>
    /// <seealso href="http://schema.org/numberOfBeds">http://schema.org/numberOfBeds</seealso>
    let numberOfBeds = Prefixed_Name(schema1, "numberOfBeds") |> PrefixedName
    /// <summary>
    ///   <para>schema1:supportingData</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Supporting data for a SoftwareApplication.</para>
    /// labels<para>supportingData</para></remarks>
    /// <seealso href="http://schema.org/supportingData">http://schema.org/supportingData</seealso>
    let supportingData = Prefixed_Name(schema1, "supportingData") |> PrefixedName
    /// <summary>
    ///   <para>schema1:surface</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A material used as a surface in some artwork, e.g. Canvas, Paper, Wood, Board, etc.</para>
    /// labels<para>surface</para></remarks>
    /// <seealso href="http://schema.org/surface">http://schema.org/surface</seealso>
    let surface = Prefixed_Name(schema1, "surface") |> PrefixedName
    /// <summary>
    ///   <para>schema1:target</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a target EntryPoint for an Action.</para>
    /// labels<para>target</para></remarks>
    /// <seealso href="http://schema.org/target">http://schema.org/target</seealso>
    let target = Prefixed_Name(schema1, "target") |> PrefixedName
    /// <summary>
    ///   <para>schema1:DataDownload</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A dataset in downloadable form.</para>
    /// labels<para>DataDownload</para></remarks>
    /// <seealso href="http://schema.org/DataDownload">http://schema.org/DataDownload</seealso>
    let DataDownload = Prefixed_Name(schema1, "DataDownload") |> PrefixedName
    /// <summary>
    ///   <para>schema1:RVPark</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A place offering space for "Recreational Vehicles", Caravans, mobile homes and the like.</para>
    /// labels<para>RVPark</para></remarks>
    /// <seealso href="http://schema.org/RVPark">http://schema.org/RVPark</seealso>
    let RVPark = Prefixed_Name(schema1, "RVPark") |> PrefixedName

    /// <summary>
    ///   <para>schema1:estimatedFlightDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The estimated time the flight will take.</para>
    /// labels<para>estimatedFlightDuration</para></remarks>
    /// <seealso href="http://schema.org/estimatedFlightDuration">http://schema.org/estimatedFlightDuration</seealso>
    let estimatedFlightDuration =
        Prefixed_Name(schema1, "estimatedFlightDuration") |> PrefixedName

    /// <summary>
    ///   <para>schema1:estimatedSalary</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An estimated salary for a job posting or occupation, based on a variety of variables including, but not limited to industry, job title, and location. Estimated salaries  are often computed by outside organizations rather than the hiring organization, who may not have committed to the estimated value.</para>
    /// labels<para>estimatedSalary</para></remarks>
    /// <seealso href="http://schema.org/estimatedSalary">http://schema.org/estimatedSalary</seealso>
    let estimatedSalary = Prefixed_Name(schema1, "estimatedSalary") |> PrefixedName
    /// <summary>
    ///   <para>schema1:event</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Upcoming or past event associated with this place, organization, or action.</para>
    /// labels<para>event</para></remarks>
    /// <seealso href="http://schema.org/event">http://schema.org/event</seealso>
    let event_ = Prefixed_Name(schema1, "event") |> PrefixedName

    /// <summary>
    ///   <para>schema1:specialOpeningHoursSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The special opening hours of a certain place.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Use this to explicitly override general opening hours brought in scope by &lt;a class="localLink" href="http://schema.org/openingHoursSpecification"&gt;openingHoursSpecification&lt;/a&gt; or &lt;a class="localLink" href="http://schema.org/openingHours"&gt;openingHours&lt;/a&gt;.</para>
    /// labels<para>specialOpeningHoursSpecification</para></remarks>
    /// <seealso href="http://schema.org/specialOpeningHoursSpecification">http://schema.org/specialOpeningHoursSpecification</seealso>
    let specialOpeningHoursSpecification =
        Prefixed_Name(schema1, "specialOpeningHoursSpecification") |> PrefixedName

    /// <summary>
    ///   <para>schema1:MedicalStudy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://schema.org/MedicalStudy">http://schema.org/MedicalStudy</seealso>
    let MedicalStudy = Prefixed_Name(schema1, "MedicalStudy") |> PrefixedName

    /// <summary>
    ///   <para>schema1:sportsActivityLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A sub property of location. The sports activity location where this action occurred.</para>
    /// labels<para>sportsActivityLocation</para></remarks>
    /// <seealso href="http://schema.org/sportsActivityLocation">http://schema.org/sportsActivityLocation</seealso>
    let sportsActivityLocation =
        Prefixed_Name(schema1, "sportsActivityLocation") |> PrefixedName

    /// <summary>
    ///   <para>schema1:CommunicateAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of conveying information to another person via a communication medium (instrument) such as speech, email, or telephone conversation.</para>
    /// labels<para>CommunicateAction</para></remarks>
    /// <seealso href="http://schema.org/CommunicateAction">http://schema.org/CommunicateAction</seealso>
    let CommunicateAction = Prefixed_Name(schema1, "CommunicateAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:AssignAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of allocating an action/event/task to some destination (someone or something).</para>
    /// labels<para>AssignAction</para></remarks>
    /// <seealso href="http://schema.org/AssignAction">http://schema.org/AssignAction</seealso>
    let AssignAction = Prefixed_Name(schema1, "AssignAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:LegalService</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A LegalService is a business that provides legally-oriented services, advice and representation, e.g. law firms.&lt;br/&gt;&lt;br/&gt;
    ///
    /// As a &lt;a class="localLink" href="http://schema.org/LocalBusiness"&gt;LocalBusiness&lt;/a&gt; it can be described as a &lt;a class="localLink" href="http://schema.org/provider"&gt;provider&lt;/a&gt; of one or more &lt;a class="localLink" href="http://schema.org/Service"&gt;Service&lt;/a&gt;(s).</para>
    /// labels<para>LegalService</para></remarks>
    /// <seealso href="http://schema.org/LegalService">http://schema.org/LegalService</seealso>
    let LegalService = Prefixed_Name(schema1, "LegalService") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ReplyAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of responding to a question/message asked/sent by the object. Related to &lt;a class="localLink" href="http://schema.org/AskAction"&gt;AskAction&lt;/a&gt;&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/AskAction"&gt;AskAction&lt;/a&gt;: Appears generally as an origin of a ReplyAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>ReplyAction</para></remarks>
    /// <seealso href="http://schema.org/ReplyAction">http://schema.org/ReplyAction</seealso>
    let ReplyAction = Prefixed_Name(schema1, "ReplyAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Report</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Report generated by governmental or non-governmental organization.</para>
    /// labels<para>Report</para></remarks>
    /// <seealso href="http://schema.org/Report">http://schema.org/Report</seealso>
    let Report = Prefixed_Name(schema1, "Report") |> PrefixedName

    /// <summary>
    ///   <para>schema1:ReservationCancelled</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:ReservationStatusType</para>
    ///   <para>The status for a previously confirmed reservation that is now cancelled.</para>
    /// labels<para>ReservationCancelled</para></remarks>
    /// <seealso href="http://schema.org/ReservationCancelled">http://schema.org/ReservationCancelled</seealso>
    let ReservationCancelled =
        Prefixed_Name(schema1, "ReservationCancelled") |> PrefixedName

    /// <summary>
    ///   <para>schema1:ReservationStatusType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Enumerated status values for Reservation.</para>
    /// labels<para>ReservationStatusType</para></remarks>
    /// <seealso href="http://schema.org/ReservationStatusType">http://schema.org/ReservationStatusType</seealso>
    let ReservationStatusType =
        Prefixed_Name(schema1, "ReservationStatusType") |> PrefixedName

    /// <summary>
    ///   <para>schema1:familyName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Family name. In the U.S., the last name of an Person. This can be used along with givenName instead of the name property.</para>
    /// labels<para>familyName</para></remarks>
    /// <seealso href="http://schema.org/familyName">http://schema.org/familyName</seealso>
    let familyName = Prefixed_Name(schema1, "familyName") |> PrefixedName
    /// <summary>
    ///   <para>schema1:naics</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The North American Industry Classification System (NAICS) code for a particular organization or business person.</para>
    /// labels<para>naics</para></remarks>
    /// <seealso href="http://schema.org/naics">http://schema.org/naics</seealso>
    let naics = Prefixed_Name(schema1, "naics") |> PrefixedName
    /// <summary>
    ///   <para>schema1:AudioObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An audio file.</para>
    /// labels<para>AudioObject</para></remarks>
    /// <seealso href="http://schema.org/AudioObject">http://schema.org/AudioObject</seealso>
    let AudioObject = Prefixed_Name(schema1, "AudioObject") |> PrefixedName

    /// <summary>
    ///   <para>schema1:AutomotiveBusiness</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Car repair, sales, or parts.</para>
    /// labels<para>AutomotiveBusiness</para></remarks>
    /// <seealso href="http://schema.org/AutomotiveBusiness">http://schema.org/AutomotiveBusiness</seealso>
    let AutomotiveBusiness =
        Prefixed_Name(schema1, "AutomotiveBusiness") |> PrefixedName

    /// <summary>
    ///   <para>schema1:Demand</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.</para>
    /// labels<para>Demand</para></remarks>
    /// <seealso href="http://schema.org/Demand">http://schema.org/Demand</seealso>
    let Demand = Prefixed_Name(schema1, "Demand") |> PrefixedName
    /// <summary>
    ///   <para>schema1:LendAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of providing an object under an agreement that it will be returned at a later date. Reciprocal of BorrowAction.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/BorrowAction"&gt;BorrowAction&lt;/a&gt;: Reciprocal of LendAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </para>
    /// labels<para>LendAction</para></remarks>
    /// <seealso href="http://schema.org/LendAction">http://schema.org/LendAction</seealso>
    let LendAction = Prefixed_Name(schema1, "LendAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:LikeAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of expressing a positive sentiment about the object. An agent likes an object (a proposition, topic or theme) with participants.</para>
    /// labels<para>LikeAction</para></remarks>
    /// <seealso href="http://schema.org/LikeAction">http://schema.org/LikeAction</seealso>
    let LikeAction = Prefixed_Name(schema1, "LikeAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:LiquorStore</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A shop that sells alcoholic drinks such as wine, beer, whisky and other spirits.</para>
    /// labels<para>LiquorStore</para></remarks>
    /// <seealso href="http://schema.org/LiquorStore">http://schema.org/LiquorStore</seealso>
    let LiquorStore = Prefixed_Name(schema1, "LiquorStore") |> PrefixedName
    /// <summary>
    ///   <para>schema1:LiteraryEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Event type: Literary event.</para>
    /// labels<para>LiteraryEvent</para></remarks>
    /// <seealso href="http://schema.org/LiteraryEvent">http://schema.org/LiteraryEvent</seealso>
    let LiteraryEvent = Prefixed_Name(schema1, "LiteraryEvent") |> PrefixedName
    /// <summary>
    ///   <para>schema1:LiveBlogPosting</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A blog post intended to provide a rolling textual coverage of an ongoing event through continuous updates.</para>
    /// labels<para>LiveBlogPosting</para></remarks>
    /// <seealso href="http://schema.org/LiveBlogPosting">http://schema.org/LiveBlogPosting</seealso>
    let LiveBlogPosting = Prefixed_Name(schema1, "LiveBlogPosting") |> PrefixedName

    /// <summary>
    ///   <para>schema1:LocationFeatureSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Specifies a location feature by providing a structured value representing a feature of an accommodation as a property-value pair of varying degrees of formality.</para>
    /// labels<para>LocationFeatureSpecification</para></remarks>
    /// <seealso href="http://schema.org/LocationFeatureSpecification">http://schema.org/LocationFeatureSpecification</seealso>
    let LocationFeatureSpecification =
        Prefixed_Name(schema1, "LocationFeatureSpecification") |> PrefixedName

    /// <summary>
    ///   <para>schema1:Locksmith</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A locksmith.</para>
    /// labels<para>Locksmith</para></remarks>
    /// <seealso href="http://schema.org/Locksmith">http://schema.org/Locksmith</seealso>
    let Locksmith = Prefixed_Name(schema1, "Locksmith") |> PrefixedName
    /// <summary>
    ///   <para>schema1:ReviewAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The act of producing a balanced opinion about the object for an audience. An agent reviews an object with participants resulting in a review.</para>
    /// labels<para>ReviewAction</para></remarks>
    /// <seealso href="http://schema.org/ReviewAction">http://schema.org/ReviewAction</seealso>
    let ReviewAction = Prefixed_Name(schema1, "ReviewAction") |> PrefixedName
    /// <summary>
    ///   <para>schema1:RiverBodyOfWater</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A river (for example, the broad majestic Shannon).</para>
    /// labels<para>RiverBodyOfWater</para></remarks>
    /// <seealso href="http://schema.org/RiverBodyOfWater">http://schema.org/RiverBodyOfWater</seealso>
    let RiverBodyOfWater = Prefixed_Name(schema1, "RiverBodyOfWater") |> PrefixedName

    /// <summary>
    ///   <para>schema1:ZoneBoardingPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:BoardingPolicyType</para>
    ///   <para>The airline boards by zones of the plane.</para>
    /// labels<para>ZoneBoardingPolicy</para></remarks>
    /// <seealso href="http://schema.org/ZoneBoardingPolicy">http://schema.org/ZoneBoardingPolicy</seealso>
    let ZoneBoardingPolicy =
        Prefixed_Name(schema1, "ZoneBoardingPolicy") |> PrefixedName

    /// <summary>
    ///   <para>schema1:Zoo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A zoo.</para>
    /// labels<para>Zoo</para></remarks>
    /// <seealso href="http://schema.org/Zoo">http://schema.org/Zoo</seealso>
    let Zoo = Prefixed_Name(schema1, "Zoo") |> PrefixedName
    /// <summary>
    ///   <para>schema1:about</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The subject matter of the content.</para>
    /// labels<para>about</para></remarks>
    /// <seealso href="http://schema.org/about">http://schema.org/about</seealso>
    let about = Prefixed_Name(schema1, "about") |> PrefixedName
    /// <summary>
    ///   <para>schema1:flightDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The distance of the flight.</para>
    /// labels<para>flightDistance</para></remarks>
    /// <seealso href="http://schema.org/flightDistance">http://schema.org/flightDistance</seealso>
    let flightDistance = Prefixed_Name(schema1, "flightDistance") |> PrefixedName
    /// <summary>
    ///   <para>schema1:numChildren</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of children staying in the unit.</para>
    /// labels<para>numChildren</para></remarks>
    /// <seealso href="http://schema.org/numChildren">http://schema.org/numChildren</seealso>
    let numChildren = Prefixed_Name(schema1, "numChildren") |> PrefixedName
    /// <summary>
    ///   <para>schema1:numTracks</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of tracks in this album or playlist.</para>
    /// labels<para>numTracks</para></remarks>
    /// <seealso href="http://schema.org/numTracks">http://schema.org/numTracks</seealso>
    let numTracks = Prefixed_Name(schema1, "numTracks") |> PrefixedName
    /// <summary>
    ///   <para>schema1:numberOfAirbags</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number or type of airbags in the vehicle.</para>
    /// labels<para>numberOfAirbags</para></remarks>
    /// <seealso href="http://schema.org/numberOfAirbags">http://schema.org/numberOfAirbags</seealso>
    let numberOfAirbags = Prefixed_Name(schema1, "numberOfAirbags") |> PrefixedName
    /// <summary>
    ///   <para>schema1:suitableForDiet</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates a dietary restriction or guideline for which this recipe or menu item is suitable, e.g. diabetic, halal etc.</para>
    /// labels<para>suitableForDiet</para></remarks>
    /// <seealso href="http://schema.org/suitableForDiet">http://schema.org/suitableForDiet</seealso>
    let suitableForDiet = Prefixed_Name(schema1, "suitableForDiet") |> PrefixedName
    /// <summary>
    ///   <para>schema1:AMRadioChannel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A radio channel that uses AM.</para>
    /// labels<para>AMRadioChannel</para></remarks>
    /// <seealso href="http://schema.org/AMRadioChannel">http://schema.org/AMRadioChannel</seealso>
    let AMRadioChannel = Prefixed_Name(schema1, "AMRadioChannel") |> PrefixedName
    /// <summary>
    ///   <para>schema1:EBook</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:BookFormatType</para>
    ///   <para>Book format: Ebook.</para>
    /// labels<para>EBook</para></remarks>
    /// <seealso href="http://schema.org/EBook">http://schema.org/EBook</seealso>
    let EBook = Prefixed_Name(schema1, "EBook") |> PrefixedName
    /// <summary>
    ///   <para>schema1:EPRelease</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:MusicAlbumReleaseType</para>
    ///   <para>EPRelease.</para>
    /// labels<para>EPRelease</para></remarks>
    /// <seealso href="http://schema.org/EPRelease">http://schema.org/EPRelease</seealso>
    let EPRelease = Prefixed_Name(schema1, "EPRelease") |> PrefixedName
    /// <summary>
    ///   <para>schema1:MotorcycleDealer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A motorcycle dealer.</para>
    /// labels<para>MotorcycleDealer</para></remarks>
    /// <seealso href="http://schema.org/MotorcycleDealer">http://schema.org/MotorcycleDealer</seealso>
    let MotorcycleDealer = Prefixed_Name(schema1, "MotorcycleDealer") |> PrefixedName
    /// <summary>
    ///   <para>schema1:Movie</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A movie.</para>
    /// labels<para>Movie</para></remarks>
    /// <seealso href="http://schema.org/Movie">http://schema.org/Movie</seealso>
    let Movie = Prefixed_Name(schema1, "Movie") |> PrefixedName
    /// <summary>
    ///   <para>schema1:MovieClip</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A short segment/part of a movie.</para>
    /// labels<para>MovieClip</para></remarks>
    /// <seealso href="http://schema.org/MovieClip">http://schema.org/MovieClip</seealso>
    let MovieClip = Prefixed_Name(schema1, "MovieClip") |> PrefixedName
    /// <summary>
    ///   <para>schema1:MovieSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A series of movies. Included movies can be indicated with the hasPart property.</para>
    /// labels<para>MovieSeries</para></remarks>
    /// <seealso href="http://schema.org/MovieSeries">http://schema.org/MovieSeries</seealso>
    let MovieSeries = Prefixed_Name(schema1, "MovieSeries") |> PrefixedName
    /// <summary>
    ///   <para>schema1:MultiPlayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:GamePlayMode</para>
    ///   <para>Play mode: MultiPlayer. Requiring or allowing multiple human players to play simultaneously.</para>
    /// labels<para>MultiPlayer</para></remarks>
    /// <seealso href="http://schema.org/MultiPlayer">http://schema.org/MultiPlayer</seealso>
    let MultiPlayer = Prefixed_Name(schema1, "MultiPlayer") |> PrefixedName

    /// <summary>
    ///   <para>schema1:additionalNumberOfGuests</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>If responding yes, the number of guests who will attend in addition to the invitee.</para>
    /// labels<para>additionalNumberOfGuests</para></remarks>
    /// <seealso href="http://schema.org/additionalNumberOfGuests">http://schema.org/additionalNumberOfGuests</seealso>
    let additionalNumberOfGuests =
        Prefixed_Name(schema1, "additionalNumberOfGuests") |> PrefixedName

    /// <summary>
    ///   <para>schema1:gameTip</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Links to tips, tactics, etc.</para>
    /// labels<para>gameTip</para></remarks>
    /// <seealso href="http://schema.org/gameTip">http://schema.org/gameTip</seealso>
    let gameTip = Prefixed_Name(schema1, "gameTip") |> PrefixedName
    /// <summary>
    ///   <para>schema1:genre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Genre of the creative work, broadcast channel or group.</para>
    /// labels<para>genre</para></remarks>
    /// <seealso href="http://schema.org/genre">http://schema.org/genre</seealso>
    let genre = Prefixed_Name(schema1, "genre") |> PrefixedName
    /// <summary>
    ///   <para>schema1:geoCoveredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Represents a relationship between two geometries (or the places they represent), relating a geometry to another that covers it. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.</para>
    /// labels<para>geoCoveredBy</para></remarks>
    /// <seealso href="http://schema.org/geoCoveredBy">http://schema.org/geoCoveredBy</seealso>
    let geoCoveredBy = Prefixed_Name(schema1, "geoCoveredBy") |> PrefixedName
    /// <summary>
    ///   <para>schema1:targetDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The description of a node in an established educational framework.</para>
    /// labels<para>targetDescription</para></remarks>
    /// <seealso href="http://schema.org/targetDescription">http://schema.org/targetDescription</seealso>
    let targetDescription = Prefixed_Name(schema1, "targetDescription") |> PrefixedName
    /// <summary>
    ///   <para>schema1:targetName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The name of a node in an established educational framework.</para>
    /// labels<para>targetName</para></remarks>
    /// <seealso href="http://schema.org/targetName">http://schema.org/targetName</seealso>
    let targetName = Prefixed_Name(schema1, "targetName") |> PrefixedName
    /// <summary>
    ///   <para>schema1:taxID</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Tax / Fiscal ID of the organization or person, e.g. the TIN in the US or the CIF/NIF in Spain.</para>
    /// labels<para>taxID</para></remarks>
    /// <seealso href="http://schema.org/taxID">http://schema.org/taxID</seealso>
    let taxID = Prefixed_Name(schema1, "taxID") |> PrefixedName
